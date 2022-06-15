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
            var dims = nsgGroupsList.GetCheckItems(); //nsgGroupsList.GetAllItems();
            bool hasDimОбъект = dims.Contains(Объект_.Caption);
            bool hasDimЗаказчик = dims.Contains(Заказчик_.Caption);
            bool hasDimПоставщик = dims.Contains(Поставщик_.Caption);
            bool hasDimТехника = dims.Contains(Техника_.Caption);
            //dims.Add(ФиксацияИстории.Names.Техника);
            //dims.Add(ФиксацияИстории.Names.Сотрудник);
            //dims.Remove(Арендатор_.Caption);
            dims.Remove(Время_.Caption);
            dims.Remove(Заказчик_.Caption);
            if (dims.Contains(Заказчик_.Caption) && !dims.Contains(Объект_.Caption))
                dims.Add(Объект_.Caption);
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
                    Техника техника = hasDimТехника ? i[РегистрЗаправок.Names.Техника].ToReferent() as Техника : Техника.Новый();
                    Объекты объект = hasDimОбъект ? i[РегистрЗаправок.Names.Объект].ToReferent() as Объекты : Объекты.Новый();
                    Контрагенты заказчик = hasDimЗаказчик ? i[ЗАКАЗЧИК].ToReferent() as Контрагенты : Контрагенты.Новый();
                    Контрагенты поставщик = hasDimПоставщик ? i[РегистрЗаправок.Names.Поставщик].ToReferent() as Контрагенты : Контрагенты.Новый();
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_.Name, объект)
                        .Add(Техника_.Name, техника)
                        .Add(Заказчик_.Name, заказчик)
                        .Add(Поставщик_.Name, поставщик)
                        .Add(Время_.Name, NsgService.BeginOfMonth(dateTime));
                    var row = nsgVisualMultipleObject.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                        row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    row[Заказчик_].Value = заказчик;
                    row[Поставщик_].Value = поставщик;
                    //Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    //row[Тариф_].Value = тариф;
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
                    decimal itogoZapravka = row[ИтогоЗаправка_].ToDecimal();
                    decimal itogoSleeve = row[ИтогоСлив_].ToDecimal();
                    //decimal stArItogo = row[СтоимостьАрендыИтого_].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = row[$"{day}"].ToDecimal() - i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal();
                            if (i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal() < 0)
                            {
                                itogoZapravka -= i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal();
                            }
                            else
                            {
                                itogoSleeve += i[РегистрЗаправок.Names.ОбъемТоплива].ToDecimal();
                            }
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
                    row[ИтогоЗаправка_].Value = itogoZapravka;
                    row[ИтогоСлив_].Value = itogoSleeve;
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

            ЗаполнитьПоставкиТоплива();
        }

        private void ЗаполнитьПоставкиТоплива()
        {
            string ЗАКАЗЧИК = РегистрПоставокТоплива.Names.Объект + '.' + Объекты.Names.Заказчик;
            var dims = nsgGroupsList.GetCheckItems();

            bool hasDimОбъект = dims.Contains(Объект_.Caption);
            bool hasDimЗаказчик = dims.Contains(Заказчик_.Caption);
            bool hasDimПоставщик = dims.Contains(Поставщик_.Caption);

            dims.Remove(Время_.Caption);
            dims.Remove(Техника_.Caption);
            dims.Remove(Заказчик_.Caption);
            if (dims.Contains(Заказчик_.Caption) && !dims.Contains(Объект_.Caption))
                dims.Add(Объект_.Caption);

            var регистрЗаправок = РегистрПоставокТоплива.Новый();
            var all = регистрЗаправок.GetCirculate(nsgPeriodPicker.Period.Begin, nsgPeriodPicker.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit/*, new[] { РегистрПоставокТоплива.Names.Объект }*/,
                dims.ToArray());

            vmoЗаправки.Data.BeginUpdateData();
            vmoЗаправки.Data.MemoryTable.Clear();
            foreach (var i in nsgVisualMultipleObject.Data.MemoryTable.Rows)
            {
                var row = vmoЗаправки.Data.MemoryTable.NewRow();
                row[Время_vmoЗаправки].Value = i[Время_].Value;
                row[Объект_vmoЗаправки].Value = i[Объект_].Value;
                row[Заказчик_vmoЗаправки].Value = i[Заказчик_].Value;
                row[Поставщик_vmoЗаправки].Value = i[Поставщик_].Value;
                row[ГосНомер_vmoЗаправки].Value = i[ГосНомер_].Value;
            }

            foreach (var i in all.Rows)
            {
                var iCmp = new NsgCompare();
                if (hasDimОбъект)
                    iCmp.Add(Объект_.Name, i[Объект_vmoЗаправки].ToReferent());
                if (hasDimЗаказчик)
                    iCmp.Add(Заказчик_.Name, i[ЗАКАЗЧИК].ToReferent());
                if (hasDimПоставщик)
                    iCmp.Add(Поставщик_.Name, i[Поставщик_vmoЗаправки].ToReferent());
                if (nsgVisualMultipleObject.Data.MemoryTable.FindRow(iCmp) != null)
                //foreach (var j in i.Таблица.Rows)
                {
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    Объекты объект = hasDimОбъект ? i[РегистрПоставокТоплива.Names.Объект].ToReferent() as Объекты : Объекты.Новый();
                    Контрагенты заказчик = hasDimЗаказчик ? i[ЗАКАЗЧИК].ToReferent() as Контрагенты : Контрагенты.Новый();
                    Контрагенты поставщик = hasDimПоставщик ? i[РегистрЗаправок.Names.Поставщик].ToReferent() as Контрагенты : Контрагенты.Новый();
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_vmoЗаправки.Name, объект)
                        .Add(Заказчик_vmoЗаправки.Name, заказчик)
                        .Add(Поставщик_vmoЗаправки.Name, поставщик)
                        .Add(Время_vmoЗаправки.Name, NsgService.BeginOfMonth(dateTime));
                    var row = vmoЗаправки.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                        row = vmoЗаправки.Data.MemoryTable.NewRow();
                    row[Заказчик_vmoЗаправки].Value = заказчик;
                    row[Поставщик_vmoЗаправки].Value = поставщик;
                    //Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    //row[Тариф_].Value = тариф;
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