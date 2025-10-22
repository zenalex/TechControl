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
using TechControl.Метаданные.Перечисления;
using TechControl.Метаданные.Регистры;
using static NsgSoft.UI.WinControls.UI.ValueMapper;

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
            List<ФизЛица> сотрудникиВТаблице = new List<ФизЛица>();
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
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as ФизЛица;
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
                var cmp = Сотрудник_vmoТаблица.SearchCondition;
                cmp.Clear();
                if (!cbShowAll.Checked) 
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

                        cmp.Add(ФизЛица.Names.Идентификатор, сотрудникиНаОбъекте, NsgComparison.In);
                    }
                }
                
            }

            if (e.ColumnName == Техника_vmoТаблица.Name)
            {
                var cmp = Техника_vmoТаблица.SearchCondition;
                cmp.Clear();
                if (!cbShowAll.Checked)
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

                        cmp.Add(Техника.Names.Идентификатор, техникаНаОбъекте, NsgComparison.In);
                    }
                }
            }
        }

        private void nsgIGrid1_AfterAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (e.RowObject != null) 
            {
                if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
                {
                    var объект = Объект.Value;
                    var дата = Дата.Value;
                    e.RowObject[Объект_vmoТаблица].Value = объект;
                    e.RowObject[дата_vmoТаблица].Value = дата;
                }
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
                var заполняемПерсонал = vmoТаблица.Data.MemoryTable.AllRows.Any(x => (x[Сотрудник_vmoТаблица].ToReferent() as ФизЛица).Selected);
                foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
                {
                    var техника = item[Техника_vmoТаблица].ToReferent() as Техника;
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as ФизЛица;
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

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            nbСохрнитьИтоги.Visible = false;
            base.OnSetFormObject(formObject);
            if (vmoИтоги.Data.CurrentRow == null)
            {
                vmoИтоги.Data.CurrentRow = vmoИтоги.Data.MemoryTable.NewRow();
            }

            if (vmoПараметрыЗаполнения.Data.CurrentRow == null)
            {
                vmoПараметрыЗаполнения.Data.CurrentRow = vmoПараметрыЗаполнения.Data.MemoryTable.NewRow();
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
                    row.Сотрудник = item[Сотрудник_vmoТаблицаИтогов].ToReferent() as ФизЛица;
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
                    var idСотрудниковОбъекта = объект.СписокПерсонала().Select(x => x.Item1.Идентификатор).ToArray();
                    cmp.Add(ФизЛица.Names.Идентификатор, idСотрудниковОбъекта, NsgComparison.In);
                    var должн = e.RowObject[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                    if (должн != null && должн.Selected)
                    {
                        var cmpДолжн = new NsgCompare(NsgLogicalOperator.Or);
                        cmpДолжн.Add(ФизЛица.Names.Должность, должн);

                        var cmpСписокСотрудников = new NsgCompare();
                        cmpСписокСотрудников.Add(МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Names.Должность, должн);
                        var idСотрудниковССовмещаемыми = МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Новый().FindAllRequisits(cmpСписокСотрудников, МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Names.Владелец)
                            .AllRows
                            .Select(x => (x[МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Names.Владелец] as NsgDataUntypedReference).RefID)
                            .ToArray();
                        cmpДолжн.Add(ФизЛица.Names.Идентификатор, idСотрудниковССовмещаемыми, NsgComparison.In);
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
                    cmpСписокСотрудников.Add(РегистрПерсоналОбъекта.Names.Объект, всеОбъекты, NsgComparison.In);
                    var idСотрудниковОбъекта = РегистрПерсоналОбъекта.Новый().GetRests(cmpСписокСотрудников)
                        .AllRows
                        .Select(x => x[РегистрПерсоналОбъекта.Names.Сотрудники].ToReferent().Guid)
                        .ToArray();

                    cmp.Add(ФизЛица.Names.Идентификатор, idСотрудниковОбъекта, NsgComparison.In);
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
                        idТарифовОбъекта = объект.ДействующиеТарифыТехники()
                            .AllRows
                            .Where(x => (x[РегистрТарифыТехникиОбъекта.Names.ГруппаСпецТехники].ToReferent() as ГруппыСпецТехники) == техника.ГруппаСпецТехники)
                            .Select(x => (x[РегистрТарифыТехникиОбъекта.Names.Тариф].ToReferent() as Тарифы).Идентификатор)
                            .ToArray();
                    }
                    else
                    {
                        idТарифовОбъекта = объект.ДействующиеТарифыПерсонала()
                            .AllRows
                            .Select(x => (x[РегистрТарифыПерсоналаОбъекта.Names.Тариф].ToReferent() as Тарифы).Идентификатор)
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
                    var idТехникиОбъекта = объект.СписокТехникиОбъекта().Select(x => x.Идентификатор).ToArray();
                    cmp.Add(Техника.Names.Идентификатор, idТехникиОбъекта, NsgComparison.In);
                    var группаСпТехн = e.RowObject[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
                    if (группаСпТехн != null && группаСпТехн.Selected)
                    {
                        cmp.Add(Техника.Names.ГруппаСпецТехники, группаСпТехн);
                    }
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

            HashSet<Tuple<string, Техника, ФизЛица, Должности, Тарифы>> рабочаяТехника = new HashSet<Tuple<string, Техника, ФизЛица, Должности, Тарифы>>();
            foreach (var item in сменыТехники)
            {
                рабочаяТехника.Add(new Tuple<string, Техника, ФизЛица, Должности, Тарифы>(item.КодГруппы, item.Техника, item.Сотрудник, item.Должность, item.Тариф));
            }

            HashSet<Tuple<string, Должности, ФизЛица, Тарифы>> рабочийПерсонал = new HashSet<Tuple<string, Должности, ФизЛица, Тарифы>>();

            foreach (var item in сменыПерсонала)
            {
                рабочийПерсонал.Add(new Tuple<string, Должности, ФизЛица, Тарифы>(item.КодГруппы, item.Должность, item.Сотрудник, item.Тариф));
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
            var таблицаСотрудников = new List<Tuple<ФизЛица, Должности>> (объект.СписокПерсонала());
            var таблицаТехники = объект.СписокТехникиОбъекта().ToList();

            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            var началоПериода = rdb1Decade.Checked ? 1 : rdb2Decade.Checked ? 2 : 3;
            var конецПериода = rdb1Decade.Checked ? 10 : rdb2Decade.Checked ? 20 : месяцИтогов.DaysInMonth();
            for (int i = началоПериода; i <= конецПериода; i++)
            {
                var дата = new DateTime(месяцИтогов.Year, месяцИтогов.Month, i);

                var графикРаботыОбъекта = объект.ДействующийНаДатуГрафикРаботы(дата);
                if (графикРаботыОбъекта.Selected)
                {
                    var параметры = графикРаботыОбъекта.ПараметрыВыходаНАСменуНаДату(дата);
                    foreach (var key in параметры.Keys)
                    {
                        var value = параметры[key];

                        if (value.Item1 && (key.Item2.Selected || key.Item3.Selected))
                        {
                            var количество = key.Item4 == 0 ? 1 : key.Item4;

                            var строки = vmoТаблицаИтогов.Data.MemoryTable
                                .FindRows(new NsgCompare()
                                .Add(КодГруппы_vmoТаблицаИтогов.Name, key.Item1)
                                .Add(ГруппаСпТехн_vmoТаблицаИтогов.Name, key.Item3)
                                .Add(Должность_vmoТаблицаИтогов.Name, key.Item2)
                                .Add(КоличествоДляСравнения_vmoТаблицаИтогов.Name, key.Item4));

                            for (int j = 0; j < количество; j++)
                            {
                                var суммируемаяКолонка = i.ToString();
                                NsgMemoryTableRow row = null;
                                if (строки != null && строки.Length > 0 && строки.Length > j)
                                {
                                    row = строки[j];
                                    row[суммируемаяКолонка].Value = row[суммируемаяКолонка].ToDecimal() + value.Item3;
                                }
                                else
                                {
                                    row = vmoТаблицаИтогов.Data.MemoryTable.NewRow();
                                    row[суммируемаяКолонка].Value = value.Item3;
                                    row[КодГруппы_vmoТаблицаИтогов].Value = key.Item1;
                                    row[ГруппаСпТехн_vmoТаблицаИтогов].Value = key.Item3;
                                    row[Должность_vmoТаблицаИтогов].Value = key.Item2;
                                    row[КоличествоДляСравнения_vmoТаблицаИтогов].Value = key.Item4;
                                    

                                    row.Post();
                                }
                            }
                        }
                    }
                }
            }

            foreach (var item in vmoТаблицаИтогов.Data.MemoryTable.AllRows)
            {
                var грСпТех = item[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
                if (грСпТех != null && грСпТех.Selected)
                {
                    var тар = объект.ДействующиеТарифыТехники()
                                            .AllRows
                                            .FirstOrDefault(x => (x[РегистрТарифыТехникиОбъекта.Names.ГруппаСпецТехники].ToReferent() as ГруппыСпецТехники) == грСпТех);
                    if (тар != null)
                    {
                        item[Тариф_vmoТаблицаИтогов].Value = тар[РегистрТарифыТехникиОбъекта.Names.Тариф].ToReferent() as Тарифы;
                    }
                    var техн = ВыбратьТехнику(таблицаТехники, item);
                    if (техн.Selected)
                    {
                        item[Техника_vmoТаблицаИтогов].Value = техн;
                        var сотр = объект.СписокПерсонала().FirstOrDefault(x => x.Item1.ДопущенКУправлению(техн));
                        if (сотр != null && сотр.Item1.Selected)
                        {
                            item[Сотрудник_vmoТаблицаИтогов].Value = сотр.Item1;
                            item[Должность_vmoТаблицаИтогов].Value = сотр.Item2;
                        }
                    }
                }
                else
                {
                    var должн = item[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                    if (должн != null && должн.Selected)
                    {
                        var сотр = ВыбратьСотрудника(таблицаСотрудников, item);
                        if (сотр != null)
                        {
                            item[Сотрудник_vmoТаблицаИтогов].Value = сотр;
                        }
                        var тариф = объект.ДействующиеТарифыПерсонала()
                                        .AllRows
                                        .FirstOrDefault(x => (x[РегистрТарифыПерсоналаОбъекта.Names.Должность].ToReferent() as Должности) == должн);
                        if (тариф != null)
                        {
                            item[Тариф_vmoТаблицаИтогов].Value = тариф[РегистрТарифыПерсоналаОбъекта.Names.Тариф].ToReferent() as Тарифы;
                        }
                    }
                }
            }
            vmoТаблицаИтогов.Data.UpdateDataSync(this);

        }

        private Техника ВыбратьТехнику(List<Техника> table, NsgMemoryTableRow row)
        {
            var техника = Техника.Новый();
            var группаСпТехн = row[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
            if (группаСпТехн != null && группаСпТехн.Selected)
            {
                var tehn = table.FirstOrDefault(x => x.ГруппаСпецТехники == группаСпТехн);
                if (tehn != null)
                {
                    техника = tehn;
                    table.Remove(tehn);
                }
            }
            return техника;
        }

        private ФизЛица ВыбратьСотрудника(List<Tuple<ФизЛица, Должности>> table, NsgMemoryTableRow row) 
        {
            var сотрудник = ФизЛица.Новый();
            var группаСпТехн = row[ГруппаСпТехн_vmoТаблицаИтогов].ToReferent() as ГруппыСпецТехники;
            if (группаСпТехн != null && группаСпТехн.Selected)
            {
                var техника = row[Техника_vmoТаблицаИтогов].ToReferent() as Техника;
                if (техника != null && техника.Selected)
                {
                    var tehn = table.FirstOrDefault(x => x.Item1.ДопущенКУправлению(техника));
                    if (tehn != null)
                    {
                        сотрудник = tehn.Item1;
                        table.Remove(tehn);
                    }
                }
            }
            else
            {
                var должность = row[Должность_vmoТаблицаИтогов].ToReferent() as Должности;
                var искомаяСтрока = table.FirstOrDefault(x => x.Item2 == должность);
                if (искомаяСтрока != null)
                {
                    сотрудник = искомаяСтрока.Item1;
                    table.Remove(искомаяСтрока);
                }
                else
                {
                    искомаяСтрока = table.FirstOrDefault(x => x.Item1.ТаблицаСовмещаемыхДолжностей.AllRows.Any(y => y.Должность == должность));
                    if (искомаяСтрока != null)
                    {
                        сотрудник = искомаяСтрока.Item1;
                        table.Remove(искомаяСтрока);
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
                        var сотрудник = item[Сотрудник_vmoТаблицаИтогов].ToReferent() as ФизЛица;
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

            var началоДекады = rdb1Decade.Checked ? 1 : rdb2Decade.Checked ? 2 : 3;
            var конецДекады = rdb1Decade.Checked ? 10 : rdb2Decade.Checked ? 20 : месяцИтогов.DaysInMonth();
            for (int i = началоДекады; i <= конецДекады; i++)
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

            for (int i = 1; i <= 31; i++)
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
                        else if (i >= 21 && i <= месяцИтогов.DaysInMonth())
                        {
                            item.Visible = rdb3Decade.Checked;
                        }
                        else
                        {
                            item.Visible = false;
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
                var копияТаблицы = new NsgMemoryTable(Метаданные.Новый());
                vmoТаблица.Data.MemoryTable.CopyTo(копияТаблицы);

                foreach (var item in vmoТаблица.Data.MemoryTable.AllRows)
                {
                    var сотрудник = item[Сотрудник_vmoТаблица].ToReferent() as ФизЛица;
                    var техника = item[Техника_vmoТаблица].ToReferent() as Техника;
                    var длительность = item[Длительность_vmoТаблица].ToDecimal();
                }
            }
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var объект = Объект.Value;
            if (объект != null && объект.Selected && e.RowObject[Объект_vmoТаблица].ToReferent() as Объекты != объект)
            {
                e.RowObject[Объект_vmoТаблица].Value = объект;

                var дата = Дата.Value;
                e.RowObject[дата_vmoТаблица].Value = дата;
            }
        }

        private void nBwЗаполнениеДаннымиСмен_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ДатаПодекадная.Value == NsgService.MinDate || !ОбъектПодекадный.Value.Selected)
            {
                vmoПодробности.Data.BeginUpdateData();
                vmoПодробности.Data.MemoryTable.Clear();
                vmoПодробности.Data.UpdateDataAsync(this);

                vmoСводка.Data.BeginUpdateData();
                vmoСводка.Data.MemoryTable.Clear();
                vmoСводка.Data.UpdateDataAsync(this);
            }

            nsgIGrid3.BeginLongOperation();
            nsgIGrid4.BeginLongOperation();

            var объект = ОбъектПодекадный.Value;

            var начало = NsgService.BeginOfMonth( ДатаПодекадная.Value);
            var конец = NsgService.EndOfMonth(ДатаПодекадная.Value) > DateTime.Now ? DateTime.Now : NsgService.EndOfMonth(ДатаПодекадная.Value);

            var cmp = new NsgCompare();
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, начало, NsgComparison.GreaterOrEqual);
            cmp.Add(ФормированиеСмены.Names.ДатаДокумента, конец, NsgComparison.LessOrEqual);
            cmp.Add(ФормированиеСмены.Names.Объект, объект);
            cmp.Add(ФормированиеСмены.Names.ДатаОкончанияСмены, NsgService.MinDate, NsgComparison.NotEqual);
            cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var сменыВПериоде = ФормированиеСмены.Новый().FindAll(cmp);

            var днейВМесяце = ДатаПодекадная.Value.DaysInMonth();

            vmoПодробности.Data.BeginUpdateData();
            vmoПодробности.Data.MemoryTable.Clear();
            
            vmoСводка.Data.BeginUpdateData();
            vmoСводка.Data.MemoryTable.Clear();
            
            foreach (var смена in сменыВПериоде)
            {
                var данныеСмены = смена.ПолучитьСгруппированныеДанныеТаблиц();
                foreach (var данные in данныеСмены)
                {
                    var строкаСводки = vmoСводка.Data.MemoryTable.AllRows
                        .FirstOrDefault(x => (x[Техника_vmoСводка].ToReferent() as Техника) == данные.Item2
                        && (x[Сотрудник_vmoСводка].ToReferent() as ФизЛица) == данные.Item3
                        && (x[Должность_vmoСводка].ToReferent() as Должности) == данные.Item4
                        && (x[Тариф_vmoСводка].ToReferent() as Тарифы) == данные.Item5);
                    if (строкаСводки == null)
                    {
                        строкаСводки = vmoСводка.Data.MemoryTable.NewRow();
                        var объедГуид = Guid.NewGuid().ToString();
                        строкаСводки[ОбъедГуид_vmoСводка].Value = объедГуид;
                        строкаСводки[Загружено_vmoСводка].Value = true;

                        строкаСводки[Техника_vmoСводка].Value = данные.Item2;
                        строкаСводки[Сотрудник_vmoСводка].Value = данные.Item3;
                        строкаСводки[Должность_vmoСводка].Value = данные.Item4;
                        строкаСводки[Тариф_vmoСводка].Value = данные.Item5;

                        строкаСводки[Техника_vmoСводка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGray);
                        строкаСводки[Сотрудник_vmoСводка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGray);
                        строкаСводки[Должность_vmoСводка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGray);
                        //строкаСводки[Тариф_vmoСводка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightSlateGray);

                        строкаСводки[данные.Item1.Day.ToString()].Value = Math.Round( данные.Item6,0);
                        if (данные.Item1.DayOfWeek == DayOfWeek.Sunday || данные.Item1.DayOfWeek == DayOfWeek.Saturday)
                        {
                            строкаСводки[данные.Item1.Day.ToString()].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.MistyRose);
                        }

                        строкаСводки.Post();
                        for (int i = 1; i <= днейВМесяце; i++)
                        {
                            var строкаПодробностей = vmoПодробности.Data.MemoryTable.NewRow();
                            строкаПодробностей[ОбъедГуид_vmoПодробности].Value = объедГуид;
                            if (данные.Item1.Day == i)
                            {
                                строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, i, данные.Item1.Hour, данные.Item1.Minute, данные.Item1.Second);
                                строкаПодробностей[Длительность_vmoПодробности].Value = данные.Item6;
                                строкаПодробностей[ИзЗаполненногоДокумента_vmoПодробности].Value = true;
                                строкаСводки[данные.Item1.Day.ToString()].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGray);
                            }
                            else
                            {
                                строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, i);
                            }
                            
                            строкаПодробностей[Техника_vmoПодробности].Value = данные.Item2;
                            строкаПодробностей[Сотрудник_vmoПодробности].Value = данные.Item3;
                            строкаПодробностей[Должность_vmoПодробности].Value = данные.Item4;
                            строкаПодробностей[Тариф_vmoПодробности].Value = данные.Item5;

                            строкаПодробностей.Post();
                        }
                    }
                    else
                    {
                        строкаСводки[данные.Item1.Day.ToString()].Value = Math.Round(данные.Item6, 0);
                        if (данные.Item1.DayOfWeek == DayOfWeek.Sunday || данные.Item1.DayOfWeek == DayOfWeek.Saturday)
                        {
                            строкаСводки[данные.Item1.Day.ToString()].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.MistyRose);
                        }
                        var объедГуид = строкаСводки[ОбъедГуид_vmoСводка].ToString();
                        var строкаПодробностей = vmoПодробности.Data.MemoryTable.AllRows
                            .FirstOrDefault(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид 
                            && x[ДатаСмены_vmoПодробности].ToDateTime().Day == данные.Item1.Day);
                        if (строкаПодробностей != null)
                        {
                            строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, данные.Item1.Day, данные.Item1.Hour, данные.Item1.Minute, данные.Item1.Second);
                            строкаПодробностей[Длительность_vmoПодробности].Value = данные.Item6;
                            строкаПодробностей[ИзЗаполненногоДокумента_vmoПодробности].Value = true;
                            строкаПодробностей.Post();
                        }
                    }
                }
            }

            foreach (var item in vmoСводка.Data.MemoryTable.AllRows)
            {
                foreach (var col in nsgIGrid3.Columns.Collection)
                {
                    if (int.TryParse(col.Name, out int result) && result <= начало.DaysInMonth())
                    {
                        if (string.IsNullOrWhiteSpace(item[col.Name].ToString()))
                        {
                            item[col.Name].Value = _пустоеЗначение;
                        }
                        var дата = new DateTime(начало.Year, начало.Month, result);
                        var объедГуид = item[ОбъедГуид_vmoСводка].ToString();

                        var строкаПодробностей = vmoПодробности.Data.MemoryTable.AllRows
                            .FirstOrDefault(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид
                            && x[ДатаСмены_vmoПодробности].ToDateTime().Day == дата.Day);
                        if (строкаПодробностей != null && !строкаПодробностей[ИзЗаполненногоДокумента_vmoПодробности].ToBoolean())
                        {
                            if (дата.DayOfWeek == DayOfWeek.Sunday || дата.DayOfWeek == DayOfWeek.Saturday)
                            {
                                item[col.Name].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.MistyRose);
                            }
                        }

                    }
                }
            }
            ВидимостьКолонокСводка();
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
            vmoСводка.Data.UpdateDataAsync(this);

            nsgIGrid3.EndLongOperation();
            nsgIGrid4.EndLongOperation();
        }

        private string _пустоеЗначение = "н";

        private void ФильтрНаПодробности() 
        {
            var объедГуид = ОбъедГуид_vmoСводка.Value;
            var период = ВыбранныйПериод();
            var начало = период.Begin;
            var конец = период.End;
            
            var cmp = vmoПодробности.Data.GetComparison(this);
            cmp.Clear();
            cmp.Add(ОбъедГуид_vmoПодробности.Name, объедГуид);
            cmp.Add(ДатаСмены_vmoПодробности.Name, начало, NsgComparison.GreaterOrEqual);
            cmp.Add(ДатаСмены_vmoПодробности.Name, конец, NsgComparison.LessOrEqual);
        }

        private NsgDateTimePeriod ВыбранныйПериод() 
        {
            var начало = NsgService.BeginOfMonth(ДатаПодекадная.Value);
            var конец = NsgService.EndOfMonth(ДатаПодекадная.Value) > DateTime.Now ? DateTime.Now : NsgService.EndOfMonth(ДатаПодекадная.Value);
            if (rdb1Декада.Checked)
            {
                начало = new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, 1);
                var конецДекады = NsgService.EndOfDay(new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, 10));
                конец = конецДекады > DateTime.Now ? DateTime.Now : конецДекады;
            }
            else if (rdb2Декада.Checked)
            {
                начало = new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, 11);
                var конецДекады = NsgService.EndOfDay(new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, 20));
                конец = конецДекады > DateTime.Now ? DateTime.Now : конецДекады;
            }
            else if (rdb3Декада.Checked)
            {
                начало = new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, 21);
                var конецДекады = NsgService.EndOfDay(new DateTime(ДатаПодекадная.Value.Year, ДатаПодекадная.Value.Month, ДатаПодекадная.Value.DaysInMonth()));
                конец = конецДекады > DateTime.Now ? DateTime.Now : конецДекады;
            }

            return new NsgDateTimePeriod(начало, конец);
        }

        private void ВидимостьКолонокСводка() 
        {
            for (int i = 1; i <= 31; i++)
            {
                var colvmoСводка = vmoСводка.Columns.Collection.First(x => x.Name == i.ToString());
                if (i <= 10)
                {
                    colvmoСводка.Visible = rdb1Декада.Checked || rdbВесьМесяц.Checked;
                }
                else if (i >= 11 && i <= 20)
                {
                    colvmoСводка.Visible = rdb2Декада.Checked || rdbВесьМесяц.Checked;
                }
                else if (i >= 21 && i <= ДатаПодекадная.Value.DaysInMonth())
                {
                    colvmoСводка.Visible = rdb3Декада.Checked || rdbВесьМесяц.Checked;
                }
                else
                {
                    colvmoСводка.Visible = false;
                }
            }
        }

        private void nsgInput3_Selected(object sender, EventArgs e)
        {
            if (nBwЗаполнениеДаннымиСмен.IsProcessing)
            {
                nBwЗаполнениеДаннымиСмен.Cancel();
            }
            nBwЗаполнениеДаннымиСмен.Run();
        }

        private void nsgInput4_Selected(object sender, EventArgs e)
        {
            if (nBwЗаполнениеДаннымиСмен.IsProcessing)
            {
                nBwЗаполнениеДаннымиСмен.Cancel();
            }
            nBwЗаполнениеДаннымиСмен.Run();
        }

        private void rdbВесьМесяц_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокСводка();
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
            vmoСводка.Data.UpdateDataAsync(this);
        }

        private void rdb2Декада_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокСводка();
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
            vmoСводка.Data.UpdateDataAsync(this);
        }

        private void rdb1Декада_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокСводка();
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
            vmoСводка.Data.UpdateDataAsync(this);
        }

        private void rdb3Декада_CheckedChanged(object sender, EventArgs e)
        {
            ВидимостьКолонокСводка();
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
            vmoСводка.Data.UpdateDataAsync(this);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpПодекадное && !rdbВесьМесяц.Checked && !rdb1Декада.Checked && !rdb2Декада.Checked && !rdb3Декада.Checked)
            {
                rdbВесьМесяц.Checked = true;
            }
        }

        private void nsgIGrid3_CellActivated(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (int.TryParse(e.ColumnName, out int day))
            {
                var период = ВыбранныйПериод();
                var начало = период.Begin;
                var конец = период.End;
                if (начало.Day < day)
                {
                    начало = new DateTime(начало.Year, начало.Month, day);
                }

                var объедГуид = e.RowObject[ОбъедГуид_vmoСводка].ToString();

                var строкаПодробностей = vmoПодробности.Data.MemoryTable.AllRows
                        .FirstOrDefault(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид
                        && x[ДатаСмены_vmoПодробности].ToDateTime().Date == new DateTime(начало.Year, начало.Month, day));
                if (строкаПодробностей != null)
                {
                    var запрещеноРедактирование = строкаПодробностей[ИзЗаполненногоДокумента_vmoПодробности].ToBoolean();
                    if (!запрещеноРедактирование)
                    {
                        var длительность = ДлительностьСмены_vmoПараметрыЗаполнения.Value;
                        if (int.TryParse(e.RowObject[day.ToString()].ToString(), out int часы))
                        {
                            строкаПодробностей[Длительность_vmoПодробности].Value = 0;
                            строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, day);
                            e.RowObject[e.ColumnName].Value = _пустоеЗначение;
                        }
                        else if (длительность != 0)
                        {
                            var режим = РежимРаботы_vmoПараметрыЗаполнения.Value;
                            var времяНачала = НачалоСмены_vmoПараметрыЗаполнения.Value;

                            if (vmoПодробности.Data.MemoryTable.AllRows.Any(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид 
                                && x[ДатаСмены_vmoПодробности].ToDateTime() > NsgService.EndOfDay(начало) 
                                && x[Длительность_vmoПодробности].ToDecimal() != 0))
                            {
                                строкаПодробностей[Длительность_vmoПодробности].Value = длительность;
                                строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, day, времяНачала.Hour, времяНачала.Minute, времяНачала.Second);
                                e.RowObject[day.ToString()].Value = Math.Round(длительность, 0);
                            }
                            else
                            {
                                for (int i = day; i <= конец.Day; i++)
                                {
                                    if (ТекущийДеньВРежимеРабочий(day, i, режим, начало))
                                    {
                                        строкаПодробностей = vmoПодробности.Data.MemoryTable.AllRows
                                            .FirstOrDefault(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид
                                            && x[ДатаСмены_vmoПодробности].ToDateTime().Date == new DateTime(начало.Year, начало.Month, i));
                                        if (строкаПодробностей != null && !строкаПодробностей[ИзЗаполненногоДокумента_vmoПодробности].ToBoolean())
                                        {
                                            строкаПодробностей[Длительность_vmoПодробности].Value = длительность;
                                            строкаПодробностей[ДатаСмены_vmoПодробности].Value = new DateTime(начало.Year, начало.Month, i, времяНачала.Hour, времяНачала.Minute, времяНачала.Second);
                                            e.RowObject[i.ToString()].Value = Math.Round(длительность, 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool ТекущийДеньВРежимеРабочий(int первыйДень, int текущийДень, ВидыРежимовРаботы режим, DateTime месяцРаботы) 
        {
            int погрешность = 0;
            if (первыйДень <= 0)
            {
                int temp = первыйДень;
                while (temp <= 0)
                {
                    погрешность++;
                    temp++;
                }
            }
            первыйДень = первыйДень + погрешность;

            if (режим == ВидыРежимовРаботы.ДваЧерезДва)
            {
                bool первый = погрешность == 0;
                bool второй = погрешность == 1;
                bool третий = погрешность == 2;
                bool четвертый = погрешность == 3;

                int j = погрешность;
                int i = первыйДень;
                
                while (i < текущийДень)
                {
                    if (первый)
                    {
                        первый = false;
                        второй = true;
                        третий = false;
                        четвертый = false;
                    }
                    else if (второй)
                    {
                        первый = false;
                        второй = false;
                        третий = true;
                        четвертый = false;
                    }
                    else if (третий)
                    {
                        первый = false;
                        второй = false;
                        третий = false;
                        четвертый = true;
                    }
                    else if (четвертый)
                    {
                        первый = true;
                        второй = false;
                        третий = false;
                        четвертый = false;
                    }
                    j++;
                    i++;
                }
                

                return первый || второй;
            }
            else if (режим == ВидыРежимовРаботы.Ежедневно)
            {
                return true;
            }
            else if (режим == ВидыРежимовРаботы.ПятьЧерезДва)
            {
                var дата = new DateTime(месяцРаботы.Year, месяцРаботы.Month, текущийДень);
                return !(дата.DayOfWeek == DayOfWeek.Sunday || дата.DayOfWeek == DayOfWeek.Saturday);
            }
            else if (режим == ВидыРежимовРаботы.СуткиЧерезДвое)
            {
                int j = погрешность;
                int i = первыйДень;
                
                while (i < текущийДень)
                {
                    j++;
                    i++;
                }

                return j == 0 || j % 3 == 0;
            }
            else if (режим == ВидыРежимовРаботы.СуткиЧерезСутки)
            {
                int j = погрешность;
                int i = первыйДень;
                
                while (i < текущийДень)
                {
                    j++;
                    i++;
                }
                return j % 2 == 0;
            }
            else if (режим == ВидыРежимовРаботы.СуткиЧерезТрое)
            {
                int j = погрешность;
                int i = первыйДень;
                
                while (i < текущийДень)
                {
                    j++;
                    i++;
                }
                return j == 0 || j % 4 == 0;
            }
            else if (режим == ВидыРежимовРаботы.ШестьЧерезОдин)
            {
                var дата = new DateTime(месяцРаботы.Year, месяцРаботы.Month, текущийДень);
                return дата.DayOfWeek != DayOfWeek.Sunday;
            }
            else
            {
                return true;
            }
        }

        private void vmoСводка_CurrentRowChanged(object sender, NsgMultipleObject oldRow, NsgMultipleObject newRow)
        {
            ФильтрНаПодробности();
            vmoПодробности.Data.UpdateDataAsync(this);
        }

        private void nsgIGrid3_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.RowObject[Загружено_vmoСводка].ToBoolean() && e.ColumnName != Тариф_vmoСводка.Name)
            {
                e.Cancel = true;
                return;
            }
        }

        private void nsgIGrid3_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сотрудник_vmoСводка.Name 
                || e.ColumnName == Техника_vmoСводка.Name 
                || e.ColumnName == Должность_vmoСводка.Name 
                || e.ColumnName == Тариф_vmoСводка.Name)
            {
                vmoПодробности.Data.BeginUpdateData();

                if (e.RowObject[e.ColumnName].ToReferent().Selected)
                {
                    var объедГуид = e.RowObject[ОбъедГуид_vmoСводка].ToString();
                    if (string.IsNullOrWhiteSpace(объедГуид))
                    {
                        объедГуид = Guid.NewGuid().ToString();
                        e.RowObject[ОбъедГуид_vmoСводка].Value = объедГуид;
                        var месяцЗаполнения = ДатаПодекадная.Value;
                        var днейВМесяце = месяцЗаполнения.DaysInMonth();
                        for (int i = 1; i <= днейВМесяце; i++)
                        {
                            var дата = new DateTime(месяцЗаполнения.Year, месяцЗаполнения.Month, i);
                            var строкаПодробностей = vmoПодробности.Data.MemoryTable.NewRow();
                            строкаПодробностей[ОбъедГуид_vmoПодробности].Value = объедГуид;
                            строкаПодробностей[ДатаСмены_vmoПодробности].Value = дата;

                            e.RowObject[i.ToString()].Value = _пустоеЗначение;
                            if (дата.DayOfWeek == DayOfWeek.Sunday || дата.DayOfWeek == DayOfWeek.Saturday)
                            {
                                e.RowObject[i.ToString()].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.MistyRose);
                            }

                            строкаПодробностей[Техника_vmoПодробности].Value = e.RowObject[Техника_vmoСводка].ToReferent() as Техника;
                            строкаПодробностей[Сотрудник_vmoПодробности].Value = e.RowObject[Сотрудник_vmoСводка].ToReferent() as ФизЛица;
                            строкаПодробностей[Должность_vmoПодробности].Value = e.RowObject[Должность_vmoСводка].ToReferent() as Должности;
                            строкаПодробностей[Тариф_vmoПодробности].Value = e.RowObject[Тариф_vmoСводка].ToReferent() as Тарифы;

                            строкаПодробностей.Post();
                        }
                    }
                    else
                    {
                        var всеПодробности = vmoПодробности.Data.MemoryTable.AllRows.Where(x => x[ОбъедГуид_vmoПодробности].ToString() == объедГуид).ToArray();
                        foreach (var строкаПодробностей in всеПодробности)
                        {
                            строкаПодробностей[Техника_vmoПодробности].Value = e.RowObject[Техника_vmoСводка].ToReferent() as Техника;
                            строкаПодробностей[Сотрудник_vmoПодробности].Value = e.RowObject[Сотрудник_vmoСводка].ToReferent() as ФизЛица;
                            строкаПодробностей[Должность_vmoПодробности].Value = e.RowObject[Должность_vmoСводка].ToReferent() as Должности;
                            строкаПодробностей[Тариф_vmoПодробности].Value = e.RowObject[Тариф_vmoСводка].ToReferent() as Тарифы;
                        }
                    }
                }
                else
                {
                    if (!e.RowObject[Сотрудник_vmoСводка].ToReferent().Selected 
                        && !e.RowObject[Техника_vmoСводка].ToReferent().Selected
                        && !e.RowObject[Должность_vmoСводка].ToReferent().Selected
                        && !e.RowObject[Тариф_vmoСводка].ToReferent().Selected)
                    {
                        var объедГуид = e.RowObject[ОбъедГуид_vmoСводка].ToString();
                        vmoПодробности.Data.MemoryTable.DeleteRows(new NsgCompare().Add(ОбъедГуид_vmoПодробности.Name, объедГуид));
                        e.RowObject[ОбъедГуид_vmoСводка].Value = string.Empty;
                    }
                }
                ФильтрНаПодробности();
                vmoПодробности.Data.UpdateDataAsync(this);
            }
        }

        private void nbСохранитьСмены_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (vmoПодробности.Data.MemoryTable.AllRowsCount == 0)
            {
                NsgSettings.MainForm.ShowMessage("Нет данных для сохранения");
                return;
            }

            var объект = ОбъектПодекадный.Value;

            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран объект");
                return;
            }

            Dictionary<DateTime, List<NsgMemoryTableRow>> словарьСмен = new Dictionary<DateTime, List<NsgMemoryTableRow>>();
            foreach (var item in vmoПодробности.Data.MemoryTable.AllRows)
            {
                if (item[Длительность_vmoПодробности].ToDecimal() != 0)
                {
                    var дата = item[ДатаСмены_vmoПодробности].ToDateTime().Date;
                    List<NsgMemoryTableRow> строки = null;
                    if (!словарьСмен.TryGetValue(дата, out строки))
                    {
                        строки = new List<NsgMemoryTableRow>();
                    }
                    словарьСмен[дата].Add(item);
                }
            }

            try
            {
                NsgSettings.BeginTransaction();
                foreach (var дата in словарьСмен.Keys)
                {
                    var cmp = new NsgCompare();
                    cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfMonth(дата), NsgComparison.GreaterOrEqual);
                    cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfDay(дата), NsgComparison.LessOrEqual);
                    cmp.Add(ФормированиеСмены.Names.Объект, объект);
                    cmp.Add(ФормированиеСмены.Names.ДатаОкончанияСмены, NsgService.MinDate, NsgComparison.NotEqual);
                    cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                    var смена = ФормированиеСмены.Новый();
                    if (смена.Find(cmp))
                    {
                        смена.Edit();
                    }
                    else
                    {
                        смена.New();
                    }
                    смена.ДатаДокумента = словарьСмен[дата].OrderBy(x => x[ДатаСмены_vmoПодробности].ToDateTime()).First()[ДатаСмены_vmoПодробности].ToDateTime();
                    смена.ДатаОкончанияСмены = смена.ДатаДокумента.AddHours((double)словарьСмен[дата].Max(x => x[Длительность_vmoПодробности].ToDecimal()));
                    смена.Таблица.DeleteAll();
                    смена.ТаблицаПерсонал.DeleteAll();

                    foreach (var item in словарьСмен[дата])
                    {
                        var техника = item[Техника_vmoПодробности].ToReferent() as Техника;
                        if (техника != null && техника.Selected)
                        {
                            var row = смена.Таблица.NewRow();
                            row.Техника = техника;
                            row.Сотрудник = item[Сотрудник_vmoПодробности].ToReferent() as ФизЛица;
                            row.Должность = item[Должность_vmoПодробности].ToReferent() as Должности;
                            row.Время = item[ДатаСмены_vmoПодробности].ToDateTime();
                            row.Длительность = item[Длительность_vmoПодробности].ToDecimal();
                            row.Тариф = item[Тариф_vmoПодробности].ToReferent() as Тарифы;
                            row.Post();
                        }
                        else
                        {
                            var row = смена.ТаблицаПерсонал.NewRow();
                            row.Сотрудник = item[Сотрудник_vmoПодробности].ToReferent() as ФизЛица;
                            row.Должность = item[Должность_vmoПодробности].ToReferent() as Должности;
                            row.Время = item[ДатаСмены_vmoПодробности].ToDateTime();
                            row.Длительность = item[Длительность_vmoПодробности].ToDecimal();
                            row.Тариф = item[Тариф_vmoПодробности].ToReferent() as Тарифы;
                            row.Post();
                        }
                    }

                    смена.Post();
                }
                NsgSettings.CommitTransaction();

                if (nBwЗаполнениеДаннымиСмен.IsProcessing)
                {
                    nBwЗаполнениеДаннымиСмен.Cancel();
                }
                nBwЗаполнениеДаннымиСмен.Run();
            }
            catch (Exception ee)
            {
                NsgSettings.RollbackTransaction();
                NsgSettings.MainForm.ShowMessage(ee.Message);
            }
            
        }

        private void nsgIGrid3_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.Delete)
            {
                if (e.RowObject != null)
                {
                    var объедГуид = e.RowObject[ОбъедГуид_vmoСводка].ToString();
                    vmoПодробности.Data.MemoryTable.DeleteRows(new NsgCompare().Add(ОбъедГуид_vmoПодробности.Name, объедГуид));
                    vmoПодробности.Data.UpdateDataAsync(this);
                }
            }
        }
    }
    


}