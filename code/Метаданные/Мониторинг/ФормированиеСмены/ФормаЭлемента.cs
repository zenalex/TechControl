using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
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

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            previousWO = Объект.Value.Идентификатор;
        }

        public override void OnDataLoaded()
        {
            base.OnDataLoaded();
            if (FormObject.ObjectState == NsgObjectStates.New)
            {
                ЭтоИтоговыйДокумент.Value = true;
            }
            nsgInput4_Selected(nsgInput4, EventArgs.Empty);
            nsgInput7_ValueChanged(nsgInput7, false);
        }

        private void bЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
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
            gridТехника.Columns[Длительность_т.Name].Visible = ЭтоИтоговыйДокумент.Value;
            gridТехника.Columns[СтатусТехники_т.Name].Visible = !ЭтоИтоговыйДокумент.Value;
            gridТехника.Columns[Время_т.Name].Visible = true;
            Время_т.Caption = ЭтоИтоговыйДокумент.Value ? "Время начала" : "Время";
            gridПерсонал.Columns[Длительность_vmoТаблицаПерсонал.Name].Visible = ЭтоИтоговыйДокумент.Value;
            gridПерсонал.Columns[СтатусСотрудника.Name].Visible = !ЭтоИтоговыйДокумент.Value;
            gridПерсонал.Columns[Время_vmoТаблицаПерсонал.Name].Visible = true;
            Время_vmoТаблицаПерсонал.Caption = ЭтоИтоговыйДокумент.Value ? "Время начала" : "Время";
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
    }
    


}