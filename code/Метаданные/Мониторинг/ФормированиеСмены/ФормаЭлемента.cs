using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Регистры;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСменыФормаЭлемента

    {
        public ФормированиеСменыФормаЭлемента()
        {
            InitializeComponent();
        }

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            previousWO = Объект.Value.Идентификатор;
            if (FormObject.ObjectState == NsgObjectStates.New)
            {
                ЭтоИтоговыйДокумент.Value = true;
            }
            ВидимостьКолонок();
        }

        public override void OnDataLoaded()
        {
            base.OnDataLoaded();
            if (FormObject.ObjectState == NsgObjectStates.New)
            {
                ЭтоИтоговыйДокумент.Value = true;
            }
            nsgInput4_Selected(nsgInput4, EventArgs.Empty);
            ВидимостьКолонок();
        }

        public override void SettingsFromXml(XmlElement root)
        {
            base.SettingsFromXml(root);
            ВидимостьКолонок();
        }

        private void bЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ВидимостьКолонок();
            if (!this.Объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран объект", MessageBoxIcon.Exclamation);
                return;
            }
            ФормированиеСмены формированиеСмены = this.FormObject as ФормированиеСмены;
            формированиеСмены.Заполнить();
            vmoТаблица.Data.UpdateDataSync(this);
            vmoТаблицаПерсонал.Data.UpdateDataSync(this);
        }

        private void nsgInput4_Selected(object sender, EventArgs e)
        {
            if (Объект.Selected)
            {
                previousWO = this.Объект.Value.Идентификатор;
                List<Техника> техникаОбъекта = Объект.Value.СписокТехникиОбъекта().ToList();
                List<ФизЛица> персоналОбъекта = Объект.Value.СписокПерсонала().Select(x => x.Item1).ToList();
                List<Тарифы> тарифыОбъекта = Объект.Value.ДействующиеТарифыТехники().AllRows.Select(x => x[РегистрТарифыТехникиОбъекта.Names.Тариф].ToReferent() as Тарифы).ToList();
                List<Тарифы> тарифыСотрудниковОбъекта = Объект.Value.ДействующиеТарифыПерсонала().AllRows.Select(x => x[РегистрТарифыПерсоналаОбъекта.Names.Тариф].ToReferent() as Тарифы).ToList();
                
                Техника_т.SearchCondition.Clear();
                Техника_т.SearchCondition.Add(Мониторинг.Техника.Names.Идентификатор, техникаОбъекта.ToArray(), NsgComparison.In);
                Сотрудник_т.SearchCondition.Clear();
                Сотрудник_т.SearchCondition.Add(ФизЛица.Names.Идентификатор, персоналОбъекта.ToArray(), NsgComparison.In);
                Сотрудник_vmoТаблицаПерсонал.SearchCondition.Clear();
                Сотрудник_vmoТаблицаПерсонал.SearchCondition.Add(ФизЛица.Names.Идентификатор, персоналОбъекта.ToArray(), NsgComparison.In);
                Тариф_т.SearchCondition.Clear();
                Тариф_т.SearchCondition.Add(Тарифы.Names.Идентификатор, тарифыОбъекта.ToArray(), NsgComparison.In);
                Тариф_vmoТаблицаПерсонал.SearchCondition.Clear();
                Тариф_vmoТаблицаПерсонал.SearchCondition.Add(Тарифы.Names.Идентификатор, тарифыСотрудниковОбъекта.ToArray(), NsgComparison.In);
            }
        }

        private void nsgInput7_ValueChanged(object sender, bool init)
        {
            ВидимостьКолонок();
        }

        void ВидимостьКолонок()
        {
            ФормированиеСмены формированиеСмены = FormObject as ФормированиеСмены;
            //vmoТаблица.Columns[Длительность_т.Name].Visible = ЭтоИтоговыйДокумент.Value;
            //gridТехника.Columns[Длительность_т.Name].Visible = true;
            //vmoТаблица.Columns[СтатусТехники_т.Name].Visible = true;
            //gridТехника.Columns[СтатусТехники_т.Name].Visible = true;
            //vmoТаблица.Columns[Время_т.Name].Visible = true;
            //vmoТаблица.Columns[Сотрудник_т.Name].Visible = true;
            //Время_т.Caption = ЭтоИтоговыйДокумент.Value ? "Время начала" : "Время";
            foreach (var i in формированиеСмены.Таблица.Rows)
            {
                ПодсветкаСтроки(i);
            }
            //vmoТаблицаПерсонал.Columns[Длительность_vmoТаблицаПерсонал.Name].Visible = ЭтоИтоговыйДокумент.Value;
            //gridПерсонал.Columns[Длительность_vmoТаблицаПерсонал.Name].Visible = true;
            //vmoТаблицаПерсонал.Columns[СтатусСотрудника.Name].Visible = true;
            //gridПерсонал.Columns[СтатусСотрудника.Name].Visible = true;
            //vmoТаблицаПерсонал.Columns[Время_vmoТаблицаПерсонал.Name].Visible = true;
            //vmoТаблицаПерсонал.Columns[Сотрудник_vmoТаблицаПерсонал.Name].Visible = true;
            //Время_vmoТаблицаПерсонал.Caption = ЭтоИтоговыйДокумент.Value ? "Время начала" : "Время";
            foreach (var i in формированиеСмены.ТаблицаПерсонал.Rows)
            {
                ПодсветкаСтроки(i);
            }
        }

        Guid previousWO = Guid.Empty;
        private void nsgInput4_ValueChanged(object sender, bool init)
        {
            if (this.Объект.Selected && this.Объект.Value.Идентификатор != previousWO)
            {
                if (!Ответственный.Selected) Ответственный.Value = Объект.Value.Ответственный;
                ФормированиеСмены формированиеСмены = this.FormObject as ФормированиеСмены;
                формированиеСмены.Заполнить();
                vmoТаблица.Data.UpdateDataSync(this);
                vmoТаблицаПерсонал.Data.UpdateDataSync(this);
                previousWO = this.Объект.Value.Идентификатор;
            }
        }

        private void gridТехника_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var i = e.RowObject as МониторингФормированиеСменыТаблица.Строка;
            ПодсветкаСтроки(i);
        }

        private void gridПерсонал_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var i = e.RowObject as МониторингФормированиеСменыТаблицаПерсонал.Строка;
            ПодсветкаСтроки(i);
        }

        private void gridТехника_DataChanged(object sender, EventArgs e)
        {
            if (!this.Объект.Selected || this.Таблица.Value.Count == 0) return;

            bool error = false;
            List<Техника> t = new List<Техника>();
            List<Техника> tt = new List<Техника>();
            foreach (var i in this.Таблица.Value.Rows)
            {
                ПодсветкаСтроки(i);
                if (t.Contains(i.Техника))
                {
                    error = !this.ЭтоИтоговыйДокумент.Value;
                    tt.Add(i.Техника);
                }
                else t.Add(i.Техника);
            }
            if (error)
            {
                foreach (var i in this.Таблица.Value.Rows)
                {
                    if (tt.Contains(i.Техника))
                    {
                        i[МониторингФормированиеСменыТаблица.Names.Техника].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                    }
                }
            }
        }

        private void gridПерсонал_DataChanged(object sender, EventArgs e)
        {
            if (!this.Объект.Selected || this.ТаблицаПерсонал.Value.Count == 0) return;

            bool error = false;
            List<ФизЛица> s = new List<ФизЛица>();
            List<ФизЛица> ss = new List<ФизЛица>();
            foreach (var i in this.ТаблицаПерсонал.Value.Rows)
            {
                ПодсветкаСтроки(i);
                if (s.Contains(i.Сотрудник))
                {
                    error = true;
                    ss.Add(i.Сотрудник);
                }
                else s.Add(i.Сотрудник);
            }
            if (error)
            {
                foreach (var i in this.ТаблицаПерсонал.Value.Rows)
                {
                    if (ss.Contains(i.Сотрудник))
                    {
                        i[МониторингФормированиеСменыТаблицаПерсонал.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                    }
                }
            }
        }

        private void ПодсветкаСтроки(МониторингФормированиеСменыТаблица.Строка i)
        {
            i.ClearUserProperties();
            foreach (NsgSimpleObject col in i.ObjectList)
            {
                col.ClearUserProperties();
            }
            if (this.ЭтоИтоговыйДокумент.Value && i.Длительность == 0)
            {
                i.AddUserProperty(NsgIGrid.FORECOLOR, Color.Gray);
                return;
            }

            if (!i.Техника.Selected)
            {
                i[МониторингФормированиеСменыТаблица.Names.Техника].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (!i.Тариф.Selected)
            {
                i[МониторингФормированиеСменыТаблица.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (this.Объект.Selected)
            {
                var tariff = this.Объект.Value.ДействующиеТарифыТехники().FindRow(new NsgCompare()
                    .Add(РегистрТарифыТехникиОбъекта.Names.Тариф, i.Тариф)
                    .Add(РегистрТарифыТехникиОбъекта.Names.ГруппаСпецТехники, i.Техника.ГруппаСпецТехники));
                if (tariff == null)
                {
                    tariff = this.Объект.Value.ДействующиеТарифыТехники().FindRow(new NsgCompare()
                        .Add(РегистрТарифыТехникиОбъекта.Names.Тариф, i.Тариф)
                        .Add(РегистрТарифыТехникиОбъекта.Names.ГруппаСпецТехники, ГруппыСпецТехники.Новый()));
                }
                if (tariff == null)
                {
                    i[МониторингФормированиеСменыТаблица.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                }
            }
            if (!i.Сотрудник.Selected)
            {
                i[МониторингФормированиеСменыТаблица.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
        }

        private void ПодсветкаСтроки(МониторингФормированиеСменыТаблицаПерсонал.Строка i)
        {
            i.ClearUserProperties();
            if (this.ЭтоИтоговыйДокумент.Value && i.Длительность == 0)
            {
                i.AddUserProperty(NsgIGrid.FORECOLOR, Color.Gray);
                return;
            }

            if (!i.Тариф.Selected)
            {
                i[МониторингФормированиеСменыТаблицаПерсонал.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (this.Объект.Selected)
            {
                var tariff = this.Объект.Value.ДействующиеТарифыПерсонала().FindRow(new NsgCompare()
                .Add(РегистрТарифыПерсоналаОбъекта.Names.Тариф, i.Тариф)
                .Add(РегистрТарифыПерсоналаОбъекта.Names.Должность, i.Сотрудник.Должность));
                if (tariff == null)
                {
                    tariff = this.Объект.Value.ДействующиеТарифыПерсонала().FindRow(new NsgCompare()
                        .Add(РегистрТарифыПерсоналаОбъекта.Names.Тариф, i.Тариф)
                        .Add(РегистрТарифыПерсоналаОбъекта.Names.Должность, Должности.Новый()));
                }
                if (tariff == null)
                {
                    i[МониторингФормированиеСменыТаблицаПерсонал.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                }
            }
            if (!i.Сотрудник.Selected)
            {
                i[МониторингФормированиеСменыТаблицаПерсонал.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
        }
    }
    


}