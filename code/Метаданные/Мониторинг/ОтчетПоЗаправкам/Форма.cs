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





namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ОтчетПоЗаправкамФорма

    {
        public ОтчетПоЗаправкамФорма()
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
            vmoШапка.Data.MemoryTable.Clear();
            vmoШапка.Data.CurrentRow = vmoШапка.Data.MemoryTable.NewRow();

            ДатаСоставления.Value = DateTime.Now.Date.ToShortDateString();
            НачалоПериода.Value = $"с {nsgPeriodPicker.Period.Begin.Date.ToShortDateString()}";
            ОкончаниеПериода.Value = $"по {nsgPeriodPicker.Period.End.Date.ToShortDateString()}";


            string ЗАКАЗЧИК = РегистрЗаправок.Names.Объект + '.' + Объекты.Names.Заказчик;
            var dims = nsgGroupsList.GetAllItems();
            //dims.Add(ФиксацияИстории.Names.Техника);
            //dims.Add(ФиксацияИстории.Names.Сотрудник);
            //dims.Remove(Арендатор_.Caption);
            dims.Remove(Время_.Caption);
            //for (int i = 0; i < dims.Count; i++)
            //{
            //    if (dims[i] == "Смена")
            //    {
            //        dims[i] = НомерСмены_.Name;
            //    }
            //}

            var регистрЗаправок = РегистрЗаправок.Новый();
            var all = регистрЗаправок.GetCirculate(nsgPeriodPicker.Period.Begin, nsgPeriodPicker.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit/*, new[] { РегистрЗаправок.Names.Объект }*/,
                dims.ToArray());
            //vmoГруппы.Data.BeginUpdateData();
            //vmoГруппы.Data.MemoryTable.Clear();
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();

            decimal[] itogsCrutch = new decimal[31];

            foreach (var i in all.Rows)
            {
                //foreach (var j in i.Таблица.Rows)
                {
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    Техника техника = i[РегистрЗаправок.Names.Техника].ToReferent() as Техника;
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_.Name, i[РегистрЗаправок.Names.Объект].Value)
                        .Add(Техника_.Name, техника)
                        .Add(Время_.Name, NsgService.BeginOfMonth(dateTime));
                    var row = nsgVisualMultipleObject.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                        row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    row[Поставщик_].Value = i[ЗАКАЗЧИК].Value;
                    //Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    //row[Тариф_].Value = тариф;
                    Объекты объект = i[РегистрЗаправок.Names.Объект].ToReferent() as Объекты;
                    row[Объект_].Value = объект;
                    //int номерСмены = (int)i[РегистрЗаправок.Names.НомерСмены].ToInt();
                    //row[НомерСмены_].Value = номерСмены;
                    //row[СменаСтрока_].Value = "Смена " + номерСмены;
                    //foreach (МониторингРежимыРаботыТаблицаГрафик.Строка строкаГрафика in объект.РежимРаботы.ТаблицаГрафик.Rows)
                    //{
                    //    if (строкаГрафика.)
                    //}
                    row[Техника_].Value = техника;
                    row[ГосНомер_].Value = техника.ГосНомер;
                    //row[СтоимостьВЧас_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Время_].Value = NsgService.BeginOfMonth(dateTime);
                    row[ВремяСтрока_].Value = new NsgDateTimePeriod(NsgService.BeginOfMonth(dateTime), NsgService.EndOfMonth(dateTime)).ToString();
                    decimal itogo = row[Итого_].ToDecimal();
                    //decimal stArItogo = row[СтоимостьАрендыИтого_].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = row[$"{day}"].ToDecimal() - i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal();
                            itogo -= i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal();
                            //stArItogo -= /*тариф[Тарифы.Names.Стоимость].ToDecimal() **/ i[РегистрЗаправок.Names.Сумма].ToDebit();
                            itogsCrutch[day - 1] += row[$"{day}"].ToDecimal();
                        }
                        else
                        {
                            //row[$"{day}"].Value = 0;
                        }
                    }
                    row[Итого_].Value = itogo;
                    //row[СтоимостьАрендыИтого_].Value = stArItogo;
                    //row[СтоимостьВЧас_].Value = itogo == 0 ? 0 : stArItogo / itogo;
                    row.Post();

                    //var rowG = vmoГруппы.Data.MemoryTable.NewRow();
                    //rowG[Объект_г].Value = i[РегистрЗаправок.Names.Объект].Value;
                    //rowG[Арендатор_г].Value = i[ЗАКАЗЧИК].Value;
                }
            }

            var crutch = string.Join(";", itogsCrutch);

            ИтогКостыль.Value = crutch;

            //var test = decimal.Parse(crutch.Split(';')[0]);

            //vmoГруппы.Data.UpdateDataAsync(this);
            nsgVisualMultipleObject.Data.UpdateDataAsync(this);

            ЗаполнитьЗаправки();
        }

        private void ЗаполнитьЗаправки()
        {
            string ЗАКАЗЧИК = РегистрПоставокТоплива.Names.Объект + '.' + Объекты.Names.Заказчик;
            var dims = nsgGroupsList.GetAllItems();

            dims.Remove(Время_.Caption);
            dims.Remove(Техника_.Caption);

            var регистрЗаправок = РегистрПоставокТоплива.Новый();
            var all = регистрЗаправок.GetCirculate(nsgPeriodPicker.Period.Begin, nsgPeriodPicker.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit/*, new[] { РегистрПоставокТоплива.Names.Объект }*/,
                dims.ToArray());

            vmoЗаправки.Data.BeginUpdateData();
            vmoЗаправки.Data.MemoryTable.Clear();
            foreach (var i in all.Rows)
            {
                //foreach (var j in i.Таблица.Rows)
                {
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_vmoЗаправки.Name, i[РегистрПоставокТоплива.Names.Объект].Value)
                        .Add(Время_vmoЗаправки.Name, NsgService.BeginOfMonth(dateTime));
                    var row = vmoЗаправки.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                        row = vmoЗаправки.Data.MemoryTable.NewRow();
                    row[Поставщик_vmoЗаправки].Value = i[ЗАКАЗЧИК].Value;
                    //Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    //row[Тариф_].Value = тариф;
                    Объекты объект = i[РегистрПоставокТоплива.Names.Объект].ToReferent() as Объекты;
                    row[Объект_vmoЗаправки].Value = объект;
                    //int номерСмены = (int)i[РегистрПоставокТоплива.Names.НомерСмены].ToInt();
                    //row[НомерСмены_].Value = номерСмены;
                    //row[СменаСтрока_].Value = "Смена " + номерСмены;
                    //foreach (МониторингРежимыРаботыТаблицаГрафик.Строка строкаГрафика in объект.РежимРаботы.ТаблицаГрафик.Rows)
                    //{
                    //    if (строкаГрафика.)
                    //}
                    //row[СтоимостьЗаЛитр_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Время_vmoЗаправки].Value = NsgService.BeginOfMonth(dateTime);
                    row[ВремяСтрока_vmoЗаправки].Value = new NsgDateTimePeriod(NsgService.BeginOfMonth(dateTime), NsgService.EndOfMonth(dateTime)).ToString();
                    decimal itogo = row[ИтогоЛ_vmoЗаправки].ToDecimal();
                    decimal stArItogo = row[ИтогоРуб_vmoЗаправки].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = row[$"{day}"].ToDecimal() + i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                            itogo += i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                            stArItogo += i[РегистрПоставокТоплива.Names.Сумма].ToDebit();
                            //stArItogo += /*тариф[Тарифы.Names.Стоимость].ToDecimal() **/ i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                        }
                        else
                        {
                            //row[$"{day}"].Value = 0;
                        }
                    }
                    row[ИтогоЛ_vmoЗаправки].Value = itogo;
                    row[ИтогоРуб_vmoЗаправки].Value = stArItogo;
                    row[СтоимостьЗаЛитр_vmoЗаправки].Value = itogo == 0 ? 0 : stArItogo / itogo;
                    row.Post();

                    //var rowG = vmoГруппы.Data.MemoryTable.NewRow();
                    //rowG[Объект_г].Value = i[РегистрПоставокТоплива.Names.Объект].Value;
                    //rowG[Арендатор_г].Value = i[ЗАКАЗЧИК].Value;
                }
            }
            //vmoГруппы.Data.UpdateDataAsync(this);
            vmoЗаправки.Data.UpdateDataAsync(this);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }
	}
    


}