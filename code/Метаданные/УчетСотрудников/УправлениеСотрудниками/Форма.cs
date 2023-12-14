using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;

namespace TechControl.Метаданные.УчетСотрудников
{
    
    public partial class УправлениеСотрудникамиФорма

    {
        public УправлениеСотрудникамиФорма()
        {
            InitializeComponent();
		}

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = Объект.Value;
            var дата = Дата.Value;
            var номерСмены = НомерСмены.Value;

            var фомированиеСмены = ФормированиеСмены.Новый();
            var cmp = new NsgCompare();
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfDay(дата), NsgComparison.GreaterOrEqual);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfDay(дата), NsgComparison.LessOrEqual);
            cmp.Add(ФормированиеСмены.Names.НомерСмены, номерСмены);
            cmp.Add(ФормированиеСмены.Names.Объект, объект);
            cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            if (фомированиеСмены.Find(cmp))
            {
                NsgSettings.MainForm.ShowMessage($"На {объект}. На дату {дата.Date:d} смена уже сформирована");
                NsgSettings.MainForm.ShowObject(фомированиеСмены, this);
            }
            vmoТаблица.Data.BeginUpdateData();
            vmoТаблица.Data.MemoryTable.Clear();
            if (дата != NsgService.MinDate && объект.Selected)
            {
                var графикРаботыОбъекта = объект.ДействующийНаДатуГрафикРаботы(дата);
                var параметры = графикРаботыОбъекта.ПараметрыВыходаНАСменуНаДату(дата, (int)номерСмены);
                foreach (var item in параметры)
                {
                    if (item.Value && (item.Key.Item1.Selected || item.Key.Item1.Selected))
                    {
                        var количество = item.Key.Item3 == 0 ? 1 : item.Key.Item3;

                        for (int i = 1; i <= количество; i++)
                        {
                            var row = vmoТаблица.Data.MemoryTable.NewRow();
                            row[Объект_vmoТаблица].Value = объект;
                            row[дата_vmoТаблица].Value = дата;
                            row[НачалоСмены_vmoТаблица].Value = дата;
                            row[Должность_vmoТаблица].Value = item.Key.Item1;
                            row[ГруппаСпецТехники_vmoТаблица].Value = item.Key.Item2;
                            row[НомерСмены_vmoТаблица].Value = номерСмены;
                            row.Post();
                        }
                    }
                }

            }
            vmoТаблица.Data.UpdateDataSync(this);
        }

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сотрудник_vmoТаблица.Name)
            {
                var объект = e.RowObject[Объект_vmoТаблица.Name].ToReferent() as Объекты;
                var должность = e.RowObject[Должность_vmoТаблица.Name].ToReferent() as Должности;
                var техника = e.RowObject[Техника_vmoТаблица.Name].ToReferent() as Техника;
                if (объект.Selected)
                {
                    Guid[] сотрудникиНаОбъекте = null;
                    if (должность.Selected)
                    {
                        сотрудникиНаОбъекте = объект.ТаблицаПерсонал.AllRows.Where(x => x.Должность == должность).Select(x => x.Сотрудник.Идентификатор).ToArray();
                    }
                    else if (техника.Selected)
                    {
                        сотрудникиНаОбъекте = объект.ТаблицаПерсонал.AllRows.Where(x => x.Сотрудник.ДопущенКУправлению(техника)).Select(x => x.Сотрудник.Идентификатор).ToArray();
                    }
                    else
                    {
                        сотрудникиНаОбъекте = объект.ТаблицаПерсонал.AllRows.Select(x => x.Сотрудник.Идентификатор).ToArray();
                    }
                    var cmp = Сотрудник_vmoТаблица.SearchCondition;
                    cmp.Clear();
                    cmp.Add(Сотрудники.Names.Идентификатор, сотрудникиНаОбъекте, NsgComparison.In);
                }
            }
        }

        private void nsgIGrid1_AfterAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                var объект = Объект.Value;
                var дата = Дата.Value;
                e.RowObject[Объект_vmoТаблица].Value = объект;
                e.RowObject[дата_vmoТаблица].Value = дата;
            }
        }

        private void nbСформироватьСмену_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (vmoТаблица.Data.MemoryTable.Count > 0)
            {
                var перваяСтрока = vmoТаблица.Data.MemoryTable.AllRows.First();
                var дата = перваяСтрока[дата_vmoТаблица].ToDateTime();
                var объект = перваяСтрока[Объект_vmoТаблица].ToReferent() as Объекты;
                var номерСмены = перваяСтрока[НомерСмены_vmoТаблица].ToInt();

                var фомированиеСмены = ФормированиеСмены.Новый();
                фомированиеСмены.New();
                фомированиеСмены.ДатаДокумента = дата;
                фомированиеСмены.Объект = объект;
                фомированиеСмены.НомерСмены = номерСмены;

                var заполняемТехнику = vmoТаблица.Data.MemoryTable.AllRows.Any(x => (x[Техника_vmoТаблица].ToReferent() as Техника).Selected);
                var заполняемПерсонал = vmoТаблица.Data.MemoryTable.AllRows.Any(x => (x[Сотрудник_vmoТаблица].ToReferent() as Сотрудники).Selected);
                foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
                {
                    var техника = item[Техника_vmoТаблица].ToReferent() as Техника;
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as Сотрудники;
                    if (заполняемТехнику)
                    {
                        if (техника.Selected)
                        {
                            var строкаТехника = фомированиеСмены.Таблица.NewRow();
                            строкаТехника.Техника = техника;
                            строкаТехника.Время = item[НачалоСмены_vmoТаблица].ToDateTime();
                            строкаТехника.Длительность = item[Длительность_vmoТаблица].ToDecimal();
                            строкаТехника.Сотрудник = сотрудник;
                            строкаТехника.Тариф = item[Тариф_vmoТаблица].ToReferent() as Тарифы;
                            строкаТехника.Post();
                        }
                    }
                    if (заполняемПерсонал)
                    {
                        if (сотрудник.Selected && !техника.Selected)
                        {
                            var строкаПерсонал = фомированиеСмены.ТаблицаПерсонал.NewRow();
                            строкаПерсонал.Время = item[НачалоСмены_vmoТаблица].ToDateTime();
                            строкаПерсонал.Длительность = item[Длительность_vmoТаблица].ToDecimal();
                            строкаПерсонал.Сотрудник = сотрудник;
                            строкаПерсонал.Тариф = item[Тариф_vmoТаблица].ToReferent() as Тарифы;
                            строкаПерсонал.Post();
                        }
                    }
                }

                фомированиеСмены.Handle();

                NsgSettings.MainForm.ShowObject(фомированиеСмены, this);
            }
        }

        private void nsgInput3_EndEdit(object sender, EndEditEventArgs e)
        {
            if (НомерСмены.Value > 3)
            {
                НомерСмены.Value = 3;
            }

            if (НомерСмены.Value < 1)
            {
                НомерСмены.Value = 1;
            }
        }

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (НомерСмены.Value < 1)
            {
                НомерСмены.Value = 1;
            }
            if (НомерСмены.Value > 3)
            {
                НомерСмены.Value = 3;
            }
        }
    }
    


}