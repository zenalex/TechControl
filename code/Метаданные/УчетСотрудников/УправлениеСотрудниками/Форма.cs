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
using NsgSoft.ReportData.Extensions;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Документы;
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

            var фомированиеСмены = ФормированиеСмены.Новый();
            var cmp = new NsgCompare();
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfDay(дата), NsgComparison.GreaterOrEqual);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfDay(дата), NsgComparison.LessOrEqual);
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
                var параметры = графикРаботыОбъекта.ПараметрыВыходаНАСменуНаДату(дата);
                foreach (var item in параметры)
                {
                    if (item.Value.Item1 && (item.Key.Item2.Selected || item.Key.Item3.Selected))
                    {
                        var количество = item.Key.Item4 == 0 ? 1 : item.Key.Item4;

                        for (int i = 1; i <= количество; i++)
                        {
                            var row = vmoТаблица.Data.MemoryTable.NewRow();
                            row[Объект_vmoТаблица].Value = объект;
                            row[дата_vmoТаблица].Value = дата;
                            var началоСмены = new DateTime(дата.Year, дата.Month, дата.Day, item.Value.Item2.Hour, item.Value.Item2.Minute, item.Value.Item2.Second);
                            row[НачалоСмены_vmoТаблица].Value = началоСмены;
                            row[КодГруппы_vmoТаблица].Value = item.Key.Item1;
                            row[Должность_vmoТаблица].Value = item.Key.Item2;
                            row[ГруппаСпецТехники_vmoТаблица].Value = item.Key.Item3;
                            row[Длительность_vmoТаблица].Value = item.Value.Item3;
                            row.Post();
                        }
                    }
                }

            }
            ЗаполнитьТехникуИСотрудников();
            vmoТаблица.Data.UpdateDataSync(this);
        }

        private void ЗаполнитьТехникуИСотрудников() 
        {
            var объект = Объект.Value;
            var дата = Дата.Value;

            var сотрудники = объект.СписокПерсонала();
            var выходНаРаботу = объект.ПланируемыеПараметрыВыходаСотрудниковНаРаботу(дата);

            var техника = объект.СписокТехникиОбъекта();

            List<Техника> техникаВТаблице = new List<Техника>();
            List<Сотрудники> сотрудникиВТаблице = new List<Сотрудники>();
            foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
            {
                var группаСпТехн = item[ГруппаСпецТехники_vmoТаблица].ToReferent() as ГруппыСпецТехники;
                var техн = item[Техника_vmoТаблица].ToReferent() as Техника;
                if (группаСпТехн != null && группаСпТехн.Selected && техн != null && !техн.Selected)
                {
                    техн = техника.FirstOrDefault(x => x.ГруппаСпецТехники == группаСпТехн);
                    if (техн != null)
                    {
                        if (!техникаВТаблице.Contains(техн))
                        {
                            item[Техника_vmoТаблица].Value = техн;
                        }
                        техникаВТаблице.Add(техн);
                    }
                }
                else
                {
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as Сотрудники;
                    if ((сотрудник != null && !сотрудник.Selected) || сотрудник == null)
                    {
                        var должность = item[Должность_vmoТаблица].ToReferent() as Должности;
                        if (должность != null && должность.Selected)
                        {
                            var подходящиеСотрудники = сотрудники.Where(x => x.Item2 == должность).Select(x => x.Item1).ToArray();
                            foreach (var сотр in подходящиеСотрудники)
                            {
                                if (выходНаРаботу.ContainsKey(сотр))
                                {
                                    if (!сотрудникиВТаблице.Contains(сотр) && выходНаРаботу[сотр])
                                    {
                                        item[Сотрудник_vmoТаблица].Value = сотр;
                                    }
                                    сотрудникиВТаблице.Add(сотр);
                                }
                                else
                                {
                                    if (!сотрудникиВТаблице.Contains(сотр))
                                    {
                                        item[Сотрудник_vmoТаблица].Value = сотр;
                                    }
                                    сотрудникиВТаблице.Add(сотр);
                                }
                            }
                        }
                    }
                }
            }
            //vmoТаблица.Data.UpdateDataSync(this);
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
                        сотрудникиНаОбъекте = объект.СписокПерсонала().Select(x => x.Item1.Идентификатор).ToArray();
                    }
                    else if (техника.Selected)
                    {
                        сотрудникиНаОбъекте = объект.СписокПерсонала().Where(x => x.Item1.ДопущенКУправлению(техника)).Select(x => x.Item1.Идентификатор).ToArray();
                    }
                    else
                    {
                        сотрудникиНаОбъекте = объект.СписокПерсонала().Select(x => x.Item1.Идентификатор).ToArray();
                    }
                    var cmp = Сотрудник_vmoТаблица.SearchCondition;
                    cmp.Clear();
                    cmp.Add(Сотрудники.Names.Идентификатор, сотрудникиНаОбъекте, NsgComparison.In);
                }
            }

            if (e.ColumnName == Техника_vmoТаблица.Name)
            {
                var объект = e.RowObject[Объект_vmoТаблица.Name].ToReferent() as Объекты;
                var грСпТех = e.RowObject[ГруппаСпецТехники_vmoТаблица.Name].ToReferent() as ГруппыСпецТехники;
                var техника = e.RowObject[Техника_vmoТаблица.Name].ToReferent() as Техника;
                if (объект.Selected)
                {
                    Guid[] техникаНаОбъекте = null;
                    if (грСпТех.Selected)
                    {
                        техникаНаОбъекте = объект.СписокТехникиОбъекта().Where(x => x.ГруппаСпецТехники == грСпТех).Select(x => x.Идентификатор).ToArray();
                    }
                    else 
                    {
                        техникаНаОбъекте = объект.СписокТехникиОбъекта().Select(x => x.Идентификатор).ToArray();
                    }
                    var cmp = Техника_vmoТаблица.SearchCondition;
                    cmp.Clear();
                    cmp.Add(Техника.Names.Идентификатор, техникаНаОбъекте, NsgComparison.In);
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

                var фомированиеСмены = ФормированиеСмены.Новый();
                фомированиеСмены.New();
                фомированиеСмены.ДатаДокумента = дата;
                фомированиеСмены.Объект = объект;

                var заполняемТехнику = vmoТаблица.Data.MemoryTable.AllRows.Any(x => (x[Техника_vmoТаблица].ToReferent() as Техника).Selected);
                var заполняемПерсонал = vmoТаблица.Data.MemoryTable.AllRows.Any(x => (x[Сотрудник_vmoТаблица].ToReferent() as Сотрудники).Selected);
                foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
                {
                    var техника = item[Техника_vmoТаблица].ToReferent() as Техника;
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as Сотрудники;
                    var должность = item[Должность_vmoТаблица].ToReferent() as Должности;
                    if (заполняемТехнику)
                    {
                        if (техника.Selected)
                        {
                            var строкаТехника = фомированиеСмены.Таблица.NewRow();
                            строкаТехника.Техника = техника;
                            строкаТехника.Время = item[НачалоСмены_vmoТаблица].ToDateTime();
                            строкаТехника.Длительность = item[Длительность_vmoТаблица].ToDecimal();
                            строкаТехника.Сотрудник = сотрудник;
                            строкаТехника.Должность = должность;
                            строкаТехника.Тариф = item[Тариф_vmoТаблица].ToReferent() as Тарифы;
                            строкаТехника.КодГруппы = item[КодГруппы_vmoТаблица].ToString();
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
                            строкаПерсонал.Должность = должность;
                            строкаПерсонал.Тариф = item[Тариф_vmoТаблица].ToReferent() as Тарифы;
                            строкаПерсонал.КодГруппы = item[КодГруппы_vmoТаблица].ToString();
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
            
        }

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            nbСохрнитьИтоги.Visible = false;
            base.OnSetFormObject(formObject);
            if (vmoИтоги.Data.CurrentRow == null)
            {
                vmoИтоги.Data.CurrentRow = vmoИтоги.Data.MemoryTable.NewRow();
            }
        }

        private void nbСохрнитьИтоги_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var месяцИтогов = NsgService.BeginOfMonth(МесяцИтогов_vmoИтоги.Value);
            var объект = Объект_vmoИтоги.Value;

            if (месяцИтогов == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage($"Не указан итоговый месяц");
                e.Cancel = true;
                return;
            }
            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage($"Не выбран объект");
                e.Cancel = true;
                return;
            }
            if (vmoТаблицаИтогов.Data.MemoryTable.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage($"Не заполнена таблица итогов");
                e.Cancel = true;
                return;
            }

            var cmp = new NsgCompare();
            cmp.Add(ОтработанныеМесяцы.Names.МесяцИтогов, месяцИтогов);
            cmp.Add(ОтработанныеМесяцы.Names.Объект, объект);
            cmp.Add(ОтработанныеМесяцы.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var отработанныйМесяц = ОтработанныеМесяцы.Новый();
            if (отработанныйМесяц.Find(cmp))
            {
                NsgSettings.MainForm.ShowObject(отработанныйМесяц, this);
                NsgSettings.MainForm.ShowMessage($"на данный месяц уже имеется итоговый документ");
                e.Cancel = true;
                return;
            }
            else
            {
                отработанныйМесяц.New();
                отработанныйМесяц.МесяцИтогов = месяцИтогов;
                отработанныйМесяц.Объект = объект;

                foreach (var item in vmoТаблицаИтогов.Data.MemoryTable.AllRows)
                {
                    var row = отработанныйМесяц.Таблица.NewRow();
                    row.Должность = item[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                    row.Сотрудник = item[Сотрудник_vmoТаблицаИтогов].ToReferent() as Сотрудники;
                    row.Тариф = item[Тариф_vmoТаблицаИтогов].ToReferent() as Тарифы;
                    row.КодГруппы = item[КодГруппы_vmoТаблицаИтогов].ToString();
                    //row.Объект = объект;
                    row.Д1 = item[Дл1_vmoТаблицаИтогов].ToDecimal();
                    row.Д2 = item[Дл2_vmoТаблицаИтогов].ToDecimal();
                    row.Д3 = item[Дл3_vmoТаблицаИтогов].ToDecimal();
                    row.Д4 = item[Дл4_vmoТаблицаИтогов].ToDecimal();
                    row.Д5 = item[Дл5_vmoТаблицаИтогов].ToDecimal();
                    row.Д6 = item[Дл6_vmoТаблицаИтогов].ToDecimal();
                    row.Д7 = item[Дл7_vmoТаблицаИтогов].ToDecimal();
                    row.Д8 = item[Дл8_vmoТаблицаИтогов].ToDecimal();
                    row.Д9 = item[Дл9_vmoТаблицаИтогов].ToDecimal();
                    row.Д10 = item[Дл10_vmoТаблицаИтогов].ToDecimal();
                    row.Д11 = item[Дл11_vmoТаблицаИтогов].ToDecimal();
                    row.Д12 = item[Дл12_vmoТаблицаИтогов].ToDecimal();
                    row.Д13 = item[Дл13_vmoТаблицаИтогов].ToDecimal();
                    row.Д14 = item[Дл14_vmoТаблицаИтогов].ToDecimal();
                    row.Д15 = item[Дл15_vmoТаблицаИтогов].ToDecimal();
                    row.Д16 = item[Дл16_vmoТаблицаИтогов].ToDecimal();
                    row.Д17 = item[Дл17_vmoТаблицаИтогов].ToDecimal();
                    row.Д18 = item[Дл18_vmoТаблицаИтогов].ToDecimal();
                    row.Д19 = item[Дл19_vmoТаблицаИтогов].ToDecimal();
                    row.Д20 = item[Дл20_vmoТаблицаИтогов].ToDecimal();
                    row.Д21 = item[Дл21_vmoТаблицаИтогов].ToDecimal();
                    row.Д22 = item[Дл22_vmoТаблицаИтогов].ToDecimal();
                    row.Д23 = item[Дл23_vmoТаблицаИтогов].ToDecimal();
                    row.Д24 = item[Дл24_vmoТаблицаИтогов].ToDecimal();
                    row.Д25 = item[Дл25_vmoТаблицаИтогов].ToDecimal();
                    row.Д26 = item[Дл26_vmoТаблицаИтогов].ToDecimal();
                    row.Д27 = item[Дл27_vmoТаблицаИтогов].ToDecimal();
                    row.Д28 = item[Дл28_vmoТаблицаИтогов].ToDecimal();
                    row.Д29 = item[Дл29_vmoТаблицаИтогов].ToDecimal();
                    row.Д30 = item[Дл30_vmoТаблицаИтогов].ToDecimal();
                    row.Д31 = item[Дл31_vmoТаблицаИтогов].ToDecimal();
                    row.Post();
                }

                отработанныйМесяц.Post();
                NsgSettings.MainForm.ShowMessage($"Итоговый документ за {месяцИтогов:Y} создан удачно");
                NsgSettings.MainForm.ShowObject(отработанныйМесяц, this);
            }

        }

        private void nsgIGrid2_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var контрагент = Контрагент_vmoИтоги.Value;
            var объект = Объект_vmoИтоги.Value;

            if (e.ColumnName == Сотрудник_vmoТаблицаИтогов.Name)
            {
                var cmp = Сотрудник_vmoТаблицаИтогов.SearchCondition;
                cmp.Clear();
                if (объект.Selected)
                {
                    var idСотрудниковОбъекта = объект.ТаблицаПерсонал.AllRows.Select(x => x.Сотрудник.Идентификатор).ToArray();
                    cmp.Add(Сотрудники.Names.Идентификатор, idСотрудниковОбъекта, NsgComparison.In);
                    var должн = e.RowObject[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                    if (должн != null && должн.Selected)
                    {
                        var cmpДолжн = new NsgCompare(NsgLogicalOperator.Or);
                        cmpДолжн.Add(Сотрудники.Names.Должность, должн);

                        var cmpСписокСотрудников = new NsgCompare();
                        cmpСписокСотрудников.Add(МониторингСотрудникиТаблицаСовмещаемыхДолжностей.Names.Должность, должн);
                        var idСотрудниковССовмещаемыми = МониторингСотрудникиТаблицаСовмещаемыхДолжностей.Новый().FindAllRequisits(cmpСписокСотрудников, МониторингСотрудникиТаблицаСовмещаемыхДолжностей.Names.Владелец)
                            .AllRows
                            .Select(x => (x[МониторингСотрудникиТаблицаСовмещаемыхДолжностей.Names.Владелец] as NsgDataUntypedReference).RefID)
                            .ToArray();
                        cmpДолжн.Add(Сотрудники.Names.Идентификатор, idСотрудниковССовмещаемыми, NsgComparison.In);
                        cmp.Add(cmpДолжн);
                    }
                }
                else if (контрагент.Selected)
                {
                    var cmpОбъекты = new NsgCompare();
                    cmpОбъекты.Add(Объекты.Names.Заказчик, контрагент);
                    cmpОбъекты.Add(Объекты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    var всеОбъекты = Объекты.Новый().FindAll(cmpОбъекты);

                    var cmpСписокСотрудников = new NsgCompare();
                    cmpСписокСотрудников.Add(МониторингОбъектыТаблицаПерсонал.Names.Владелец, всеОбъекты, NsgComparison.In);
                    var idСотрудниковОбъекта = МониторингОбъектыТаблицаПерсонал.Новый().FindAllRequisits(cmpСписокСотрудников, МониторингОбъектыТаблицаПерсонал.Names.Сотрудник)
                        .AllRows
                        .Select(x => x[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent().Guid)
                        .ToArray();

                    cmp.Add(Сотрудники.Names.Идентификатор, idСотрудниковОбъекта, NsgComparison.In);
                }
            }

            if (e.ColumnName == Тариф_vmoТаблицаИтогов.Name)
            {
                var cmp = Тариф_vmoТаблицаИтогов.SearchCondition;
                cmp.Clear();
                var техника = e.RowObject[Техника_vmoТаблицаИтогов].ToReferent() as Техника;

                if (объект.Selected)
                {
                    Guid[] idТарифовОбъекта = null; 
                    if (техника.Selected)
                    {
                        idТарифовОбъекта = объект.ТаблицаТарифы
                            .AllRows
                            .Where(x => x.ГруппаСпецТехники == техника.ГруппаСпецТехники)
                            .Select(x => x.Тариф.Идентификатор)
                            .ToArray();
                    }
                    else
                    {
                        idТарифовОбъекта = объект.ТаблицаТарифыСотрудников
                            .AllRows
                            .Select(x => x.Тариф.Идентификатор)
                            .ToArray();
                    }
                    cmp.Add(Тарифы.Names.Идентификатор, idТарифовОбъекта, NsgComparison.In);
                }
                else if (контрагент.Selected)
                {
                    var cmpОбъекты = new NsgCompare();
                    cmpОбъекты.Add(Объекты.Names.Заказчик, контрагент);
                    cmpОбъекты.Add(Объекты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    var всеОбъекты = Объекты.Новый().FindAll(cmpОбъекты);

                    Guid[] idТарифовОбъекта = null;
                    if (техника.Selected)
                    {
                        var cmpСписокТарифов = new NsgCompare();
                        cmpСписокТарифов.Add(МониторингОбъектыТаблицаТарифы.Names.Владелец, всеОбъекты, NsgComparison.In);
                        cmpСписокТарифов.Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, техника.ГруппаСпецТехники);
                        idТарифовОбъекта = МониторингОбъектыТаблицаТарифы.Новый().FindAllRequisits(cmpСписокТарифов, МониторингОбъектыТаблицаТарифы.Names.Тариф)
                            .AllRows
                            .Select(x => x[МониторингОбъектыТаблицаТарифы.Names.Тариф].ToReferent().Guid) 
                            .ToArray();

                    }
                    else
                    {
                        var cmpСписокТарифов = new NsgCompare();
                        cmpСписокТарифов.Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Владелец, всеОбъекты, NsgComparison.In);
                        idТарифовОбъекта = МониторингОбъектыТаблицаТарифыСотрудников.Новый().FindAllRequisits(cmpСписокТарифов, МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф)
                            .AllRows
                            .Select(x => x[МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф].ToReferent().Guid)
                            .ToArray();
                    }

                    cmp.Add(Тарифы.Names.Идентификатор, idТарифовОбъекта, NsgComparison.In);
                }
                
                
            }

            if (e.ColumnName == Техника_vmoТаблицаИтогов.Name)
            {
                var cmp = Техника_vmoТаблицаИтогов.SearchCondition;
                cmp.Clear();
                if (объект.Selected)
                {
                    var idТехникиОбъекта = объект.ТаблицаТехника.AllRows.Select(x => x.Техника.Идентификатор).ToArray();
                    cmp.Add(Техника.Names.Идентификатор, idТехникиОбъекта, NsgComparison.In);
                    var группаСпТехн = e.RowObject[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
                    if (группаСпТехн != null && группаСпТехн.Selected)
                    {
                        cmp.Add(Техника.Names.ГруппаСпецТехники, группаСпТехн);
                    }
                }
                else if (контрагент.Selected)
                {
                    var cmpОбъекты = new NsgCompare();
                    cmpОбъекты.Add(Объекты.Names.Заказчик, контрагент);
                    cmpОбъекты.Add(Объекты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    var всеОбъекты = Объекты.Новый().FindAll(cmpОбъекты);

                    var cmpСписокТехники = new NsgCompare();
                    cmpСписокТехники.Add(МониторингОбъектыТаблицаТехника.Names.Владелец, всеОбъекты, NsgComparison.In);
                    var idСотрудниковОбъекта = МониторингОбъектыТаблицаТехника.Новый().FindAllRequisits(cmpСписокТехники, МониторингОбъектыТаблицаТехника.Names.Техника)
                        .AllRows
                        .Select(x => x[МониторингОбъектыТаблицаТехника.Names.Техника].ToReferent().Guid)
                        .ToArray();

                    cmp.Add(Техника.Names.Идентификатор, idСотрудниковОбъекта, NsgComparison.In);
                }
            }
        }

        private void nbЗаполнитьИтоги_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = Объект_vmoИтоги.Value;
            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо указать объект");
                e.Cancel = true;
                return;
            }
            var месяцИтогов = МесяцИтогов_vmoИтоги.Value.Date;

            if (месяцИтогов == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать месяц итогов");
                e.Cancel = true;
                return;
            }

            var cmp = new NsgCompare();
            cmp.Add(ФормированиеСмены.Names.Объект, объект);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfMonth(месяцИтогов), NsgComparison.GreaterOrEqual);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfMonth(месяцИтогов), NsgComparison.LessOrEqual);
            cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var всеСмены = ФормированиеСмены.Новый().FindAll(cmp);
            var гуиды = всеСмены.Select(x => x.Идентификатор).ToArray();
            var cmpСменыТехника = new NsgCompare();
            cmpСменыТехника.Add(МониторингФормированиеСменыТаблица.Names.Владелец, гуиды, NsgComparison.In);
            var сменыТехники = МониторингФормированиеСменыТаблица.Новый().FindAll(cmpСменыТехника);

            var cmpСменыПерсонал = new NsgCompare();
            cmpСменыПерсонал.Add(МониторингФормированиеСменыТаблицаПерсонал.Names.Владелец, гуиды, NsgComparison.In);
            var сменыПерсонала = МониторингФормированиеСменыТаблицаПерсонал.Новый().FindAll(cmpСменыПерсонал);

            vmoТаблицаИтогов.Data.BeginUpdateData();
            vmoТаблицаИтогов.Data.MemoryTable.Clear();

            HashSet<Tuple<string, Техника, Сотрудники, Должности, Тарифы>> рабочаяТехника = new HashSet<Tuple<string, Техника, Сотрудники, Должности, Тарифы>>();
            foreach (var item in сменыТехники)
            {
                рабочаяТехника.Add(new Tuple<string, Техника, Сотрудники, Должности, Тарифы>(item.КодГруппы, item.Техника, item.Сотрудник, item.Должность, item.Тариф));
            }

            HashSet<Tuple<string, Должности, Сотрудники, Тарифы>> рабочийПерсонал = new HashSet<Tuple<string, Должности, Сотрудники, Тарифы>>();

            foreach (var item in сменыПерсонала)
            {
                рабочийПерсонал.Add(new Tuple<string, Должности, Сотрудники, Тарифы>(item.КодГруппы, item.Должность, item.Сотрудник, item.Тариф));
            }

            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            foreach (var item in рабочаяТехника)
            {
                var row = vmoТаблицаИтогов.Data.MemoryTable.NewRow();
                row[КодГруппы_vmoТаблицаИтогов].Value = item.Item1;
                row[Техника_vmoТаблицаИтогов].Value = item.Item2;
                row[ГруппаСпТехн_vmoТаблицаИтогов].Value = item.Item2.ГруппаСпецТехники;
                row[Сотрудник_vmoТаблицаИтогов].Value = item.Item3;
                row[Должность_vmoТаблицаИтогов].Value = item.Item4;
                row[Тариф_vmoТаблицаИтогов].Value = item.Item5;
                for (int i = 1; i <= всегоДней; i++)
                {
                    var строка = сменыТехники.First(x => x.КодГруппы == item.Item1 && x.Техника == item.Item2 && x.Сотрудник == item.Item3 && x.Должность == item.Item4 && x.Время.Day == i);
                    if (строка != null)
                    {
                        //row["Дл" + i].Value = строка.Длительность;
                        row[i.ToString()].Value = строка.Длительность;
                    }
                }
                row.Post();
            }

            foreach (var item in рабочийПерсонал)
            {
                var row = vmoТаблицаИтогов.Data.MemoryTable.NewRow();
                row[КодГруппы_vmoТаблицаИтогов].Value = item.Item1;
                row[Сотрудник_vmoТаблицаИтогов].Value = item.Item3;
                row[Должность_vmoТаблицаИтогов].Value = item.Item2;
                row[Тариф_vmoТаблицаИтогов].Value = item.Item4;
                for (int i = 1; i <= всегоДней; i++)
                {
                    var строка = сменыПерсонала.First(x => x.КодГруппы == item.Item1 && x.Должность == item.Item2 && x.Сотрудник == item.Item3 && x.Время.Day == i);
                    if (строка != null)
                    {
                        //row["Дл" + i].Value = строка.Длительность;
                        row[i.ToString()].Value = строка.Длительность;
                    }
                }
                row.Post();
            }
            vmoТаблицаИтогов.Data.UpdateDataSync(this);
        }

        private void nbЗаполнитьПоГрафику_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = Объект_vmoИтоги.Value;
            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо указать объект");
                e.Cancel = true;
                return;
            }
            var месяцИтогов = МесяцИтогов_vmoИтоги.Value.Date;

            if (месяцИтогов == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать месяц итогов");
                e.Cancel = true;
                return;
            }

            vmoТаблицаИтогов.Data.BeginUpdateData();
            vmoТаблицаИтогов.Data.MemoryTable.Clear();
            NsgMemoryTable таблицаСотрудников = new NsgMemoryTable(Метаданные.Новый());
            NsgMemoryTable таблицаТехники = new NsgMemoryTable(Метаданные.Новый());
            объект.ТаблицаПерсонал.CopyTo(таблицаСотрудников);
            объект.ТаблицаТехника.CopyTo(таблицаТехники);

            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            for (int i = 1; i <= всегоДней; i++)
            {
                var дата = new DateTime(месяцИтогов.Year, месяцИтогов.Month, i);

                var графикРаботыОбъекта = объект.ДействующийНаДатуГрафикРаботы(дата);
                if (графикРаботыОбъекта.Selected)
                {
                    var параметры = графикРаботыОбъекта.ПараметрыВыходаНАСменуНаДату(дата);
                    foreach (var item in параметры)
                    {
                        if (item.Value.Item1 && (item.Key.Item2.Selected || item.Key.Item3.Selected))
                        {
                            var количество = item.Key.Item4 == 0 ? 1 : item.Key.Item4;

                            var строки = vmoТаблицаИтогов.Data.MemoryTable
                                .FindRows(new NsgCompare()
                                .Add(КодГруппы_vmoТаблицаИтогов.Name, item.Key.Item1)
                                .Add(ГруппаСпТехн_vmoТаблицаИтогов.Name, item.Key.Item3)
                                .Add(Должность_vmoТаблицаИтогов.Name, item.Key.Item2)
                                .Add(КоличествоДляСравнения_vmoТаблицаИтогов.Name, item.Key.Item4));

                            for (int j = 0; j < количество; j++)
                            {
                                var суммируемаяКолонка = i.ToString();
                                NsgMemoryTableRow row = null;
                                if (строки != null && строки.Length > 0 && строки.Length > j)
                                {
                                    row = строки[j];
                                    row[суммируемаяКолонка].Value = row[суммируемаяКолонка].ToDecimal() + item.Value.Item3;
                                }
                                else
                                {
                                    row = vmoТаблицаИтогов.Data.MemoryTable.NewRow();
                                    row[суммируемаяКолонка].Value = item.Value.Item3;
                                    row[КодГруппы_vmoТаблицаИтогов].Value = item.Key.Item1;
                                    row[ГруппаСпТехн_vmoТаблицаИтогов].Value = item.Key.Item3;
                                    if (item.Key.Item3.Selected)
                                    {
                                        row[Техника_vmoТаблицаИтогов].Value = ВыбратьТехнику(таблицаТехники, row);
                                    }
                                    row[Должность_vmoТаблицаИтогов].Value = item.Key.Item2;
                                    row[КоличествоДляСравнения_vmoТаблицаИтогов].Value = item.Key.Item4;
                                    if (item.Key.Item2.Selected || item.Key.Item3.Selected)
                                    {
                                        row[Сотрудник_vmoТаблицаИтогов].Value = ВыбратьСотрудника(таблицаСотрудников, row);
                                    }
                                    
                                    row.Post();
                                }
                            }
                        }
                    }
                }
            }
            vmoТаблицаИтогов.Data.UpdateDataSync(this);

        }

        private Техника ВыбратьТехнику(NsgMemoryTable table, NsgMemoryTableRow row)
        {
            var техника = Техника.Новый();
            var группаСпТехн = row[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
            if (группаСпТехн != null && группаСпТехн.Selected)
            {
                var строка = table.AllRows.FirstOrDefault(x => (x[МониторингОбъектыТаблицаТехника.Names.Техника].ToReferent() as Техника).ГруппаСпецТехники == группаСпТехн);
                if (строка != null)
                {
                    техника = строка[МониторингОбъектыТаблицаТехника.Names.Техника].ToReferent() as Техника;
                    table.DeleteRow(строка);
                }
            }
            return техника;
        }

        private Сотрудники ВыбратьСотрудника(NsgMemoryTable table, NsgMemoryTableRow row) 
        {
            var сотрудник = Сотрудники.Новый();
            var группаСпТехн = row[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
            if (группаСпТехн != null && группаСпТехн.Selected)
            {
                var техника = row[Техника_vmoТаблицаИтогов].ToReferent() as Техника;
                if (техника != null && техника.Selected)
                {
                    var строка = table.AllRows.FirstOrDefault(x => (x[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники).ДопущенКУправлению(техника));
                    if (строка != null)
                    {
                        сотрудник = строка[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники;
                        table.DeleteRow(строка);
                    }
                }
            }
            else
            {
                var должность = row[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                var искомаяСтрока = table.AllRows.FirstOrDefault(x => (x[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники).Должность == должность);
                if (искомаяСтрока != null)
                {
                    сотрудник = искомаяСтрока[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники;
                    table.DeleteRow(искомаяСтрока);
                }
                else
                {
                    искомаяСтрока = table.AllRows.FirstOrDefault(x => (x[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники).ТаблицаСовмещаемыхДолжностей.AllRows.Any(y => y.Должность == должность));
                    if (искомаяСтрока != null)
                    {
                        сотрудник = искомаяСтрока[МониторингОбъектыТаблицаПерсонал.Names.Сотрудник].ToReferent() as Сотрудники;
                        table.DeleteRow(искомаяСтрока);
                    }
                }
            }
            return сотрудник;
        }

        private void nbСформироватьСменыИЭСМ_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = Объект_vmoИтоги.Value;
            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо указать объект");
                e.Cancel = true;
                return;
            }
            var месяцИтогов = МесяцИтогов_vmoИтоги.Value.Date;

            if (месяцИтогов == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать месяц итогов");
                e.Cancel = true;
                return;
            }

            var cmp = new NsgCompare();
            cmp.Add(ФормированиеСмены.Names.Объект, объект);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfMonth(месяцИтогов), NsgComparison.GreaterOrEqual);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfMonth(месяцИтогов), NsgComparison.LessOrEqual);
            cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var всеСмены = ФормированиеСмены.Новый().FindAll(cmp);

            var cmpЭСМ = new NsgCompare();
            cmpЭСМ.Add(ЭСМ.Names.Объект, объект);
            cmpЭСМ.Add(ЭСМ.Names.По, NsgService.BeginOfMonth(месяцИтогов), NsgComparison.GreaterOrEqual);
            cmpЭСМ.Add(ЭСМ.Names.По, NsgService.EndOfMonth(месяцИтогов), NsgComparison.LessOrEqual);
            cmpЭСМ.Add(ЭСМ.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var всеЭСМзаМесяцИтогов = ЭСМ.Новый().FindAll(cmpЭСМ);

            List<ЭСМ> новыеЭСМ = new List<ЭСМ>();

            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            for (int i = 1; i <= всегоДней; i++)
            {
                var колонкаДаты = i.ToString();
                var датаСмены = new DateTime(месяцИтогов.Year, месяцИтогов.Month, i);
                if (всеСмены.Any(x => x.ДатаДокумента.Date == датаСмены))
                {
                    NsgSettings.MainForm.ShowMessage($"За {датаСмены:d} смена уже сформирована");
                }
                else
                {
                    var фомированиеСмены = ФормированиеСмены.Новый();
                    фомированиеСмены.New();
                    фомированиеСмены.ДатаДокумента = датаСмены;
                    фомированиеСмены.Объект = объект;
                    фомированиеСмены.ЭтоИтоговыйДокумент = true;

                    foreach (var item in vmoТаблицаИтогов.Data.MemoryTable.AllRows.Where(x => x[колонкаДаты].ToDecimal() > 0).ToArray())
                    {
                        var техника = item[Техника_vmoТаблицаИтогов].ToReferent() as Техника;
                        var группаСпТехн = item[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
                        var должность = item[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                        var сотрудник = item[Сотрудник_vmoТаблицаИтогов].ToReferent() as Сотрудники;
                        var тариф = item[Тариф_vmoТаблицаИтогов].ToReferent() as Тарифы;
                        var кодГруппы = item[КодГруппы_vmoТаблицаИтогов].ToString();
                        var длительность = item[колонкаДаты].ToDecimal();

                        if (техника != null && техника.Selected)
                        {
                            var строкаТехника = фомированиеСмены.Таблица.NewRow();
                            строкаТехника.Техника = техника;
                            строкаТехника.Время = датаСмены;
                            строкаТехника.Длительность = длительность;
                            строкаТехника.Сотрудник = сотрудник;
                            строкаТехника.Должность = должность;
                            строкаТехника.Тариф = тариф;
                            строкаТехника.КодГруппы = кодГруппы;
                            строкаТехника.Post();
                        }
                        else
                        {
                            if (сотрудник.Selected && !техника.Selected)
                            {
                                var строкаПерсонал = фомированиеСмены.ТаблицаПерсонал.NewRow();
                                строкаПерсонал.Время = датаСмены;
                                строкаПерсонал.Длительность = длительность;
                                строкаПерсонал.Сотрудник = сотрудник;
                                строкаПерсонал.Должность = должность;
                                строкаПерсонал.Тариф = тариф;
                                строкаПерсонал.КодГруппы = кодГруппы;
                                строкаПерсонал.Post();
                            }
                        }
                    }

                    if (фомированиеСмены.Таблица.Count > 0  || фомированиеСмены.ТаблицаПерсонал.Count > 0)
                    {
                        фомированиеСмены.Handle();
                    }
                }
            }

            var cmpСменыСНовыми = new NsgCompare();
            cmpСменыСНовыми.Add(ФормированиеСмены.Names.Объект, объект);
            cmpСменыСНовыми.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfMonth(месяцИтогов), NsgComparison.GreaterOrEqual);
            cmpСменыСНовыми.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfMonth(месяцИтогов), NsgComparison.LessOrEqual);
            cmpСменыСНовыми.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var всеСменыСНовыми = ФормированиеСмены.Новый().FindAll(cmpСменыСНовыми);

            for (int i = 1; i <= всегоДней; i++)
            {
                var колонкаДаты = i.ToString();
                var датаСмены = new DateTime(месяцИтогов.Year, месяцИтогов.Month, i);
                foreach (var item in всеСменыСНовыми.Where(x => x.ДатаДокумента.Date == датаСмены.Date).ToArray())
                {
                    foreach (var строкаСменыТехники in item.Таблица.AllRows)
                    {
                        var техника = строкаСменыТехники.Техника;
                        var должность = строкаСменыТехники.Должность;
                        var сотрудник = строкаСменыТехники.Сотрудник;
                        var тариф = строкаСменыТехники.Тариф;
                        var кодГруппы = строкаСменыТехники.КодГруппы;
                        var длительность = строкаСменыТехники.Длительность;
                        var началоСмены = строкаСменыТехники.Время;

                        if (техника != null && техника.Selected)
                        {
                            if (!всеЭСМзаМесяцИтогов.Any(x => x.С <= датаСмены && x.По >= датаСмены
                                && x.Техника == техника
                                && x.Объект == объект
                                && x.Сотрудник == сотрудник))
                            {
                                var эсм = новыеЭСМ.FirstOrDefault(x => x.С <= датаСмены && x.По >= датаСмены
                                    && x.Техника == техника
                                    && x.Объект == объект
                                    && x.Сотрудник == сотрудник);
                                if (эсм == null)
                                {
                                    эсм = ЭСМ.Новый();
                                    эсм.New();
                                    эсм.Техника = техника;
                                    эсм.Объект = объект;
                                    эсм.Сотрудник = сотрудник;
                                    эсм.Контрагент = объект.Заказчик;
                                    эсм.Фирма = объект.Фирма;
                                    var началоПериода = i >= 1 && i <= 10 ? new DateTime(месяцИтогов.Year, месяцИтогов.Month, 1)
                                        : i >= 11 && i <= 20 ? new DateTime(месяцИтогов.Year, месяцИтогов.Month, 11)
                                        : new DateTime(месяцИтогов.Year, месяцИтогов.Month, 21);
                                    var конецПериода = i >= 1 && i <= 10 ? new DateTime(месяцИтогов.Year, месяцИтогов.Month, 10)
                                        : i >= 11 && i <= 20 ? new DateTime(месяцИтогов.Year, месяцИтогов.Month, 20)
                                        : new DateTime(месяцИтогов.Year, месяцИтогов.Month, всегоДней);
                                    эсм.С = началоПериода;
                                    эсм.По = конецПериода;

                                    новыеЭСМ.Add(эсм);
                                }

                                var новаяЗапись = эсм.Таблица.NewRow();
                                новаяЗапись.ДатаВремя = началоСмены;
                                новаяЗапись.ОтработаноМашиноЧасов = длительность;
                                новаяЗапись.Тариф = тариф;
                                новаяЗапись.Post();

                                var добавленныйДокумент = эсм.ТаблицаДокументов.NewRow();
                                добавленныйДокумент.ФормированиеСмены = item;
                                добавленныйДокумент.Post();
                            }
                        }
                    }
                    
                }
            }

            foreach (var item in новыеЭСМ)
            {
                item.Post();
            }
        }

        private void rdb1Decade_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокТаблицы();
        }

        private void rdb2Decade_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокТаблицы();
        }

        private void rdb3Decade_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокТаблицы();
        }

        private void ВидимостьКолонокТаблицы()
        {
            var месяцИтогов = МесяцИтогов_vmoИтоги.Value;
            var всеКолонкиВМО = vmoТаблицаИтогов.Columns;

            for (int i = 1; i <= месяцИтогов.DaysInMonth(); i++)
            {
                foreach (var item in всеКолонкиВМО.Collection)
                {
                    if (item.Name == i.ToString())
                    {
                        if (i <= 10)
                        {
                            item.Visible = rdb1Decade.Checked;
                        }
                        else if (i >= 11 && i <= 20)
                        {
                            item.Visible = rdb2Decade.Checked;
                        }
                        else
                        {
                            item.Visible = rdb3Decade.Checked;
                        }
                        break;
                    }
                }
            }
        }

        private void bgwАнализТаблицы_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void АнализТаблицы() 
        {
            var объект = Объект.Value;
            var дата = Дата.Value.Date;
            if (объект.Selected && дата == NsgService.MinDate) 
            {
                foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
                {
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as Сотрудники;
                    var техника = item[Техника_vmoТаблица].ToReferent() as Техника;
                    var длительность = item[Длительность_vmoТаблица].ToDecimal();
                }
            }
        }
    }
    


}