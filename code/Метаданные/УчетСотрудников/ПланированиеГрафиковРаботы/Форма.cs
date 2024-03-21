using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using NsgSoft.ReportData.Extensions;
using TechControl.Метаданные.Документы;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Перечисления;
using static NsgSoft.Graphs.NsgTimePlot;





namespace TechControl.Метаданные.УчетСотрудников
{
    
    public partial class ПланированиеГрафиковРаботыФорма

    {
        List<string> _колонкиДат = new List<string>();

        public ПланированиеГрафиковРаботыФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            for (int i = 1; i <= 31; i++)
            {
                _колонкиДат.Add(i.ToString());
            }
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

        private void bgwЗаполнениеТаблицы_DoWork(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьТаблицу();
        }

        private void ЗаполнитьТаблицу() 
        {
            var объект = Объект.Value;
            var месяц = МесяцГрафика.Value;
            if (объект == null || !объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран объект");
                return;
            }

            if (месяц == null || месяц == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран месяц");
                return;
            }

            var сотрудники = объект.ТаблицаПерсонал.AllRows.Select(x => x.Сотрудник).ToArray();
            if (сотрудники.Length == 0)
            {
                NsgSettings.MainForm.ShowMessage($"В объекте {объект}, не заполнена таблица персонала");
                return;
            }

            vmoТаблицаМесяца.Data.BeginUpdateData();
            vmoТаблицаМесяца.Data.MemoryTable.Clear();
            foreach (var item in сотрудники)
            {
                var row = vmoТаблицаМесяца.Data.MemoryTable.NewRow();
                row[Сотрудник_vmoТаблицаМесяца].Value = item;
                row.Post();
            }

            var cmp = new NsgCompare();
            cmp.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, месяц, NsgComparison.GreaterOrEqual);
            cmp.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, месяц, NsgComparison.LessOrEqual);
            cmp.Add(ПлановыйГрафикРаботы.Names.Объект, объект);
            cmp.Add(ПлановыйГрафикРаботы.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var графики = ПлановыйГрафикРаботы.Новый().FindAll(cmp);
            if (графики.Length > 0)
            {
                foreach (var график in графики)
                {
                    var cmpСтрока = new NsgCompare();
                    cmpСтрока.Add(Сотрудник_vmoТаблицаМесяца.Name, график.Сотрудник);
                    var row = vmoТаблицаМесяца.Data.MemoryTable.FindRow(cmpСтрока);
                    if (row != null)
                    {
                        ЗаполнитьСтроку(row, график, месяц, объект);
                    }
                }
            }
            else
            {
                var cmpГрафикиПрошлогоМесяца = new NsgCompare();
                cmpГрафикиПрошлогоМесяца.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, месяц.AddMonths(-1), NsgComparison.GreaterOrEqual);
                cmpГрафикиПрошлогоМесяца.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, месяц.AddMonths(-1), NsgComparison.LessOrEqual);
                cmpГрафикиПрошлогоМесяца.Add(ПлановыйГрафикРаботы.Names.Объект, объект);
                cmpГрафикиПрошлогоМесяца.Add(ПлановыйГрафикРаботы.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                var графикиПрошлогоМесяца = ПлановыйГрафикРаботы.Новый().FindAll(cmpГрафикиПрошлогоМесяца);
                if (графикиПрошлогоМесяца.Length > 0)
                {
                    foreach (var график in графикиПрошлогоМесяца)
                    {
                        var cmpСтрока = new NsgCompare();
                        cmpСтрока.Add(Сотрудник_vmoТаблицаМесяца.Name, график.Сотрудник);
                        var row = vmoТаблицаМесяца.Data.MemoryTable.FindRow(cmpСтрока);
                        if (row != null)
                        {
                            ЗаполнитьСтроку(row, график, месяц, объект);
                        }
                    }
                }
            }
            vmoТаблицаМесяца.Data.UpdateDataSync(this);

        }

        private void ЗаполнитьСтроку(NsgMemoryTableRow row, ПлановыйГрафикРаботы график, DateTime месяц, Объекты объект) 
        {
            int деньНачала = 1;
            var началоОтсчета = 1;
            bool первый = true;

            if (график != null && график.Selected)
            {
                row[ВидРежимаРаботы_vmoТаблицаМесяца].Value = график.ВидРежимаРаботы;
                if (график.МесяцГрафика.Month != месяц.Month && график.ВидРежимаРаботы == ВидыРежимовРаботы.ДваЧерезДва)
                {
                    первый = график.ДатаПоследнегоРабочегоДня.Day != график.МесяцГрафика.DaysInMonth();
                }
                else
                {
                    деньНачала = график.ДатаПервогоРабочегоДня.Day;
                }
            }
            
            for (int i = 1; i <= месяц.DaysInMonth(); i++)
            {
                if (row[i.ToString()].ToBoolean())
                {
                    началоОтсчета = i;
                    break;
                }
            }

            var видРежимаРаботы = row[ВидРежимаРаботы_vmoТаблицаМесяца].ToReferent() as ВидыРежимовРаботы;
            for (int i = 1; i <= месяц.DaysInMonth(); i++)
            {
                if (i < деньНачала)
                {
                    row[i.ToString()].Value = false;
                }
                else if (i >= деньНачала)
                {
                    if (видРежимаРаботы == ВидыРежимовРаботы.Ежедневно)
                    {
                        row[i.ToString()].Value = true;
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.ПятьЧерезДва)
                    {
                        var дата = new DateTime(месяц.Year, месяц.Month, i);
                        row[i.ToString()].Value = !(НастройкиПраздников.ЯвляетсяВыходным(дата, объект) || дата.DayOfWeek == DayOfWeek.Sunday || дата.DayOfWeek == DayOfWeek.Saturday);
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.ШестьЧерезОдин)
                    {
                        var дата = new DateTime(месяц.Year, месяц.Month, i);
                        row[i.ToString()].Value = !(дата.DayOfWeek == DayOfWeek.Sunday);
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.ДваЧерезДва)
                    {
                        if (i == началоОтсчета)
                        {
                            row[i.ToString()].Value = true;
                            if (первый)
                            {
                                началоОтсчета++;
                                первый = false;
                            }
                            else
                            {
                                началоОтсчета += 3;
                                первый = true;
                            }
                        }
                        else
                        {
                            row[i.ToString()].Value = false;
                        }
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.СуткиЧерезСутки)
                    {
                        if (i == началоОтсчета)
                        {
                            row[i.ToString()].Value = true;
                            началоОтсчета += 2;
                        }
                        else
                        {
                            row[i.ToString()].Value = false;
                        }
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.СуткиЧерезДвое)
                    {
                        if (i == началоОтсчета)
                        {
                            row[i.ToString()].Value = true;
                            началоОтсчета += 3;
                        }
                        else
                        {
                            row[i.ToString()].Value = false;
                        }
                    }
                    else if (видРежимаРаботы == ВидыРежимовРаботы.СуткиЧерезТрое)
                    {
                        if (i == началоОтсчета)
                        {
                            row[i.ToString()].Value = true;
                            началоОтсчета += 4;
                        }
                        else
                        {
                            row[i.ToString()].Value = false;
                        }
                    }
                }
            }
        }

        private void ЗаполнитьСтрокуПоГрафику(NsgMemoryTableRow row, ПлановыйГрафикРаботы график, DateTime месяц, Объекты объект)
        {
            int деньНачала = 1;
            var началоОтсчета = 1;
            bool первый = true;

            if (график != null && график.Selected)
            {
                row[ВидРежимаРаботы_vmoТаблицаМесяца].Value = график.ВидРежимаРаботы;
                if (график.МесяцГрафика.Month != месяц.Month && график.ВидРежимаРаботы == ВидыРежимовРаботы.ДваЧерезДва)
                {
                    первый = график.ДатаПоследнегоРабочегоДня.Day != график.МесяцГрафика.DaysInMonth();
                }
                else
                {
                    деньНачала = график.ДатаПервогоРабочегоДня.Day;
                }

                //foreach (var item in график.та)
                //{

                //}
            }

            for (int i = 1; i <= месяц.DaysInMonth(); i++)
            {
                if (row[i.ToString()].ToBoolean())
                {
                    началоОтсчета = i;
                    break;
                }
            }

            var видРежимаРаботы = row[ВидРежимаРаботы_vmoТаблицаМесяца].ToReferent() as ВидыРежимовРаботы;

            
        }

        private void nsgInput2_Selected(object sender, EventArgs e)
        {
            if (bgwЗаполнениеТаблицы.IsProcessing)
            {
                bgwЗаполнениеТаблицы.Cancel();
            }
            bgwЗаполнениеТаблицы.Run();
        }

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            if (bgwЗаполнениеТаблицы.IsProcessing)
            {
                bgwЗаполнениеТаблицы.Cancel();
            }
            bgwЗаполнениеТаблицы.Run();
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сбросить_vmoТаблицаМесяца.Name)
            {
                for (int i = 1; i <= 31; i++)
                {
                    e.RowObject[i.ToString()].Value = false;
                }
                e.RowObject[Сбросить_vmoТаблицаМесяца].Value = false;
            }
            else
            {
                bool выбраноНачалоОтсчета = false;
                int выбраноДат = 0;
                for (int i = 1; i <= 31; i++)
                {
                    if (e.RowObject[i.ToString()].ToBoolean())
                    {
                        выбраноНачалоОтсчета = true;
                        выбраноДат++;
                    }
                }
                if (e.ColumnName == ВидРежимаРаботы_vmoТаблицаМесяца.Name && МесяцГрафика.Value != NsgService.MinDate && Объект.Value.Selected)
                {
                    ЗаполнитьСтроку(e.RowObject as NsgMemoryTableRow, null, МесяцГрафика.Value, Объект.Value);
                }
                if (_колонкиДат.Contains(e.ColumnName) && выбраноДат > 0  && МесяцГрафика.Value != NsgService.MinDate && Объект.Value.Selected)
                {
                    ЗаполнитьСтроку(e.RowObject as NsgMemoryTableRow, null, МесяцГрафика.Value, Объект.Value);
                }
            }
        }
    }
    


}