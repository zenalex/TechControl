using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСменыДеньФормаЭлемента

    {
        public ФормированиеСменыДеньФормаЭлемента()
        {
            InitializeComponent();
        }

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            previousWO = Объект.Value.Идентификатор;
            ВидимостьКолонок();
        }

        public override void OnDataLoaded()
        {
            base.OnDataLoaded();
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
            ФормированиеСменыДень формированиеСмены = this.FormObject as ФормированиеСменыДень;
            формированиеСмены.Заполнить();
            vmoТаблицаТехника.Data.UpdateDataSync(this);
            vmoТаблицаПерсонал.Data.UpdateDataSync(this);
        }

        private void nsgInput4_Selected(object sender, EventArgs e)
        {
            if (Объект.Selected)
            {
                previousWO = this.Объект.Value.Идентификатор;
                List<Техника> техникаОбъекта = new List<Техника>();
                foreach (var i in this.Объект.Value.ТаблицаТехника.Rows)
                {
                    техникаОбъекта.Add(i.Техника);
                }
                List<Сотрудники> персоналОбъекта = new List<Сотрудники>();
                foreach (var i in this.Объект.Value.ТаблицаПерсонал.Rows)
                {
                    персоналОбъекта.Add(i.Сотрудник);
                }
                List<Тарифы> тарифыОбъекта = new List<Тарифы>();
                foreach (var i in this.Объект.Value.ТаблицаТарифы.Rows)
                {
                    тарифыОбъекта.Add(i.Тариф);
                }
                List<Тарифы> тарифыСотрудниковОбъекта = new List<Тарифы>();
                foreach (var i in this.Объект.Value.ТаблицаТарифыСотрудников.Rows)
                {
                    тарифыСотрудниковОбъекта.Add(i.Тариф);
                }
                Техника_т.SearchCondition.Clear();
                Техника_т.SearchCondition.Add(Мониторинг.Техника.Names.Идентификатор, техникаОбъекта.ToArray(), NsgComparison.In);
                Сотрудник_т.SearchCondition.Clear();
                Сотрудник_т.SearchCondition.Add(Сотрудники.Names.Идентификатор, персоналОбъекта.ToArray(), NsgComparison.In);
                Сотрудник_vmoТаблицаПерсонал.SearchCondition.Clear();
                Сотрудник_vmoТаблицаПерсонал.SearchCondition.Add(Сотрудники.Names.Идентификатор, персоналОбъекта.ToArray(), NsgComparison.In);
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
            ФормированиеСменыДень формированиеСмены = FormObject as ФормированиеСменыДень;
            vmoТаблицаТехника.Columns[СтатусТехники_т.Name].Visible = true;
            gridТехника.Columns[СтатусТехники_т.Name].Visible = true;
            vmoТаблицаТехника.Columns[Время_т.Name].Visible = true;
            vmoТаблицаТехника.Columns[Сотрудник_т.Name].Visible = true;
            foreach (var i in формированиеСмены.ТаблицаТехника.Rows)
            {
                ПодсветкаСтроки(i);
            }
            vmoТаблицаПерсонал.Columns[СтатусСотрудника.Name].Visible = true;
            gridПерсонал.Columns[СтатусСотрудника.Name].Visible = true;
            vmoТаблицаПерсонал.Columns[Время_vmoТаблицаПерсонал.Name].Visible = true;
            vmoТаблицаПерсонал.Columns[Сотрудник_vmoТаблицаПерсонал.Name].Visible = true;
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
                ФормированиеСменыДень формированиеСмены = this.FormObject as ФормированиеСменыДень;
                формированиеСмены.Заполнить();
                vmoТаблицаТехника.Data.UpdateDataSync(this);
                vmoТаблицаПерсонал.Data.UpdateDataSync(this);
                previousWO = this.Объект.Value.Идентификатор;
            }
        }

        private void gridТехника_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var i = e.RowObject as МониторингФормированиеСменыДеньТаблицаТехника.Строка;
            ПодсветкаСтроки(i);
        }

        private void gridПерсонал_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var i = e.RowObject as МониторингФормированиеСменыДеньТаблицаПерсонал.Строка;
            ПодсветкаСтроки(i);
        }

        private void gridТехника_DataChanged(object sender, EventArgs e)
        {
            if (!this.Объект.Selected || this.ТаблицаТехника.Value.Count == 0) return;

            bool error = false;
            List<Техника> t = new List<Техника>();
            List<Техника> tt = new List<Техника>();
            foreach (var i in this.ТаблицаТехника.Value.Rows)
            {
                ПодсветкаСтроки(i);
                if (t.Contains(i.Техника))
                {
                    error = true;
                    tt.Add(i.Техника);
                }
                else t.Add(i.Техника);
            }
            if (error)
            {
                foreach (var i in this.ТаблицаТехника.Value.Rows)
                {
                    if (tt.Contains(i.Техника))
                    {
                        i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                    }
                }
            }
        }

        private void gridПерсонал_DataChanged(object sender, EventArgs e)
        {
            if (!this.Объект.Selected || this.ТаблицаПерсонал.Value.Count == 0) return;

            bool error = false;
            List<Сотрудники> s = new List<Сотрудники>();
            List<Сотрудники> ss = new List<Сотрудники>();
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
                        i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                    }
                }
            }
        }

        private void ПодсветкаСтроки(МониторингФормированиеСменыДеньТаблицаТехника.Строка i)
        {
            i.ClearUserProperties();
            foreach (NsgSimpleObject col in i.ObjectList)
            {
                col.ClearUserProperties();
            }

            if (!i.Техника.Selected)
            {
                i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Техника].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (!i.Тариф.Selected)
            {
                i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (this.Объект.Selected)
            {
                var tariff = this.Объект.Value.ТаблицаТарифы.FindRow(new NsgCompare()
                    .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                    .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, i.Техника.ГруппаСпецТехники));
                if (tariff == null)
                {
                    tariff = this.Объект.Value.ТаблицаТарифы.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                        .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, ГруппыСпецТехники.Новый()));
                }
                if (tariff == null)
                {
                    i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                }
            }
            if (!i.Сотрудник.Selected)
            {
                i[МониторингФормированиеСменыДеньТаблицаТехника.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
        }

        private void ПодсветкаСтроки(МониторингФормированиеСменыДеньТаблицаПерсонал.Строка i)
        {
            i.ClearUserProperties();

            if (!i.Тариф.Selected)
            {
                i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
            if (this.Объект.Selected)
            {
                var tariff = this.Объект.Value.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, i.Тариф)
                .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, i.Сотрудник.Должность));
                if (tariff == null)
                {
                    tariff = this.Объект.Value.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, i.Тариф)
                        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Должность, Должности.Новый()));
                }
                if (tariff == null)
                {
                    i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Тариф].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
                }
            }
            if (!i.Сотрудник.Selected)
            {
                i[МониторингФормированиеСменыДеньТаблицаПерсонал.Names.Сотрудник].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);
            }
        }
    }
    


}