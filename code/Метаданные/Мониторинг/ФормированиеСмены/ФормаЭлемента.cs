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
                if (vmoТаблица.Data.DataTable.FindRow(new NsgCompare().Add("Техника", i.Техника)) == null)
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
            //foreach (МониторингФормированиеСменыТаблица.Строка i in vmoТаблица.Data.DataTable.Rows)
            //{
            //    //
            //}
        }
    }
    


}