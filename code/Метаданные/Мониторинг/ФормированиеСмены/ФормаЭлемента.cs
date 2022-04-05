using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСменыФормаЭлемента

    {
        public ФормированиеСменыФормаЭлемента()
        {
            InitializeComponent();
		}

        public override void OnDataLoaded()
        {
            base.OnDataLoaded();
            if (FormObject.ObjectState == NsgObjectStates.New)
            {
                ЭтоИтоговыйДокумент.Value = true;
            }
        }

        private void bЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (!this.Объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран объект", MessageBoxIcon.Exclamation);
                return;
            }
            ФормированиеСмены формированиеСмены = this.FormObject as ФормированиеСмены;
            List<Техника> техникаОбъекта = new List<Техника>();
            foreach (var i in this.Объект.Value.ТаблицаТехника.Rows)
            {
                //if (vmoТаблица.Data.DataTable.FindRow(new NsgCompare().Add(МониторингФормированиеСменыТаблица.Names.Техника, i.Техника)) == null)
                {
                    //МониторингФормированиеСменыТаблица.Строка row = vmoТаблица.Data.DataTable.NewRow() as МониторингФормированиеСменыТаблица.Строка;
                    //row.Техника = i.Техника;
                    //row.Post();
                    техникаОбъекта.Add(i.Техника);
                }
            }
            ФиксацияИстории фиксацияИстории = ФиксацияИстории.Новый();
            NsgCompare cmp = new NsgCompare()
                .Add(ФиксацияИстории.Names.Объект, формированиеСмены.Объект)
                .Add(ФиксацияИстории.Names.Техника, техникаОбъекта.ToArray(), NsgSoft.Database.NsgComparison.In);
            var rsts = фиксацияИстории.GetRests(формированиеСмены.ДатаДокумента, cmp);
            foreach (var i in rsts.Rows)
            {
                //if (vmoТаблица.Data.DataTable.FindRow(new NsgCompare()
                //    .Add(МониторингФормированиеСменыТаблица.Names.Техника, i[МониторингФормированиеСменыТаблица.Names.Техника].Value)) != null)
                //    continue;
                var row = vmoТаблица.Data.DataTable.NewRow();
                row.CopyNotPredefinedFieldsFromObject(i, МониторингФормированиеСменыТаблица.Names.СтатусТехники, МониторингФормированиеСменыТаблица.Names.Время);
                var смена = row[МониторингФормированиеСменыТаблица.Names.НомерСмены].ToInt();
                var статус = i[МониторингФормированиеСменыТаблица.Names.СтатусТехники].ToReferent() as СтатусТехники;
                if (статус == Мониторинг.СтатусТехники.ВРаботе)
                {
                    row[МониторингФормированиеСменыТаблица.Names.СтатусТехники].Value = Мониторинг.СтатусТехники.НеРаботает;
                }
                else
                {
                    row[МониторингФормированиеСменыТаблица.Names.СтатусТехники].Value = Мониторинг.СтатусТехники.ВРаботе;
                }
                if (смена > 0)
                {
                    if (this.Объект.Value.РежимРаботы.Selected)
                    {
                        ДеньНедели деньНедели = ДеньНедели.Новый();
                        DayOfWeek dayOfWeek = формированиеСмены.ДатаДокумента.DayOfWeek;
                        if (dayOfWeek == DayOfWeek.Sunday)
                        {
                            деньНедели.Value = 6;
                        }
                        else
                        {
                            деньНедели.Value = (int)dayOfWeek - 1;
                        }
                        var cmpRR = new NsgCompare()
                            .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, деньНедели);
                        var RRRow = this.Объект.Value.РежимРаботы.ТаблицаГрафик.FindRow(cmpRR);
                        if (RRRow != null)
                        {
                            if (статус == Мониторинг.СтатусТехники.ВРаботе)
                            {
                                row[МониторингФормированиеСменыТаблица.Names.Время].Value = RRRow[$"ВремяОкончанияСмены{смена}"].Value;
                            }
                            else
                            {
                                row[МониторингФормированиеСменыТаблица.Names.Время].Value = RRRow[$"ВремяНачалаСмены{смена}"].Value;
                            }
                        }
                    }
                }

                row.Post();
            }
            vmoТаблица.Data.UpdateDataSync(this);
            List<Сотрудники> персоналОбъекта = new List<Сотрудники>();
            foreach (var i in this.Объект.Value.ТаблицаПерсонал.Rows)
            {
                //if (vmoТаблицаПерсонал.Data.DataTable.FindRow(new NsgCompare().Add(МониторингФормированиеСменыТаблицаПерсонал.Names.Сотрудник, i.Сотрудник)) == null)
                {
                    персоналОбъекта.Add(i.Сотрудник);
                }
            }
            foreach (var i in персоналОбъекта)
            {
                var row = vmoТаблицаПерсонал.Data.DataTable.NewRow();
                row.CopyNotPredefinedFieldsFromObject(i, МониторингФормированиеСменыТаблицаПерсонал.Names.СтатусСотрудника, МониторингФормированиеСменыТаблицаПерсонал.Names.Время);
                var смена = row[МониторингФормированиеСменыТаблицаПерсонал.Names.НомерСмены].ToInt();
                var статус = i[МониторингФормированиеСменыТаблицаПерсонал.Names.СтатусСотрудника].ToReferent() as СтатусСотрудника;
                if (статус == Мониторинг.СтатусСотрудника.НаРаботе)
                {
                    row[МониторингФормированиеСменыТаблицаПерсонал.Names.СтатусСотрудника].Value = Мониторинг.СтатусСотрудника.Отсутствует;
                }
                else
                {
                    row[МониторингФормированиеСменыТаблицаПерсонал.Names.СтатусСотрудника].Value = Мониторинг.СтатусСотрудника.НаРаботе;
                }
                if (смена > 0)
                {
                    if (this.Объект.Value.РежимРаботы.Selected)
                    {
                        ДеньНедели деньНедели = ДеньНедели.Новый();
                        DayOfWeek dayOfWeek = формированиеСмены.ДатаДокумента.DayOfWeek;
                        if (dayOfWeek == DayOfWeek.Sunday)
                        {
                            деньНедели.Value = 6;
                        }
                        else
                        {
                            деньНедели.Value = (int)dayOfWeek - 1;
                        }
                        var cmpRR = new NsgCompare()
                            .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, деньНедели);
                        var RRRow = this.Объект.Value.РежимРаботы.ТаблицаГрафик.FindRow(cmpRR);
                        if (RRRow != null)
                        {
                            if (статус == Мониторинг.СтатусСотрудника.НаРаботе)
                            {
                                row[МониторингФормированиеСменыТаблицаПерсонал.Names.Время].Value = RRRow[$"ВремяОкончанияСмены{смена}"].Value;
                            }
                            else
                            {
                                row[МониторингФормированиеСменыТаблицаПерсонал.Names.Время].Value = RRRow[$"ВремяНачалаСмены{смена}"].Value;
                            }
                        }
                    }
                }

                row.Post();
            }
            vmoТаблицаПерсонал.Data.UpdateDataSync(this);
        }

        private void nsgInput4_Selected(object sender, EventArgs e)
        {
            if (Объект.Selected)
                Ответственный.Value = Объект.Value.Ответственный;
        }

        private void nsgInput7_ValueChanged(object sender, bool init)
        {
            РежимыРаботы рр = Объект.Value?.РежимРаботы;
            var rr = рр.ТаблицаГрафик.FindRow(new NsgCompare()
                .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, ДеньНедели.ByDayOfWeek[ДатаДокумента.Value.DayOfWeek]));
            gridТехника.Columns[Длительность.Name].Visible = ЭтоИтоговыйДокумент.Value;
            gridТехника.Columns[СтатусТехники.Name].Visible = !ЭтоИтоговыйДокумент.Value;
            gridТехника.Columns[Время.Name].Visible = !ЭтоИтоговыйДокумент.Value;
            gridПерсонал.Columns[Длительность_vmoТаблицаПерсонал.Name].Visible = ЭтоИтоговыйДокумент.Value;
            gridПерсонал.Columns[СтатусСотрудника.Name].Visible = !ЭтоИтоговыйДокумент.Value;
            gridПерсонал.Columns[Время_vmoТаблицаПерсонал.Name].Visible = !ЭтоИтоговыйДокумент.Value;
        }
    }
    


}