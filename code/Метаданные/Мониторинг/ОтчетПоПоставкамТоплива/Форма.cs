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
    
    public partial class ОтчетПоПоставкамТопливаФорма

    {
        public ОтчетПоПоставкамТопливаФорма()
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
            string ЗАКАЗЧИК = РегистрПоставокТоплива.Names.Объект + '.' + Объекты.Names.Заказчик;
            string ПОСТАВЩИК = РегистрПоставокТоплива.Names.Поставщик;
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

            var регистрЗаправок = РегистрПоставокТоплива.Новый();
            var all = регистрЗаправок.GetCirculate(nsgPeriodPicker.Period.Begin, nsgPeriodPicker.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit/*, new[] { РегистрПоставокТоплива.Names.Объект }*/,
                dims.ToArray());
            //vmoГруппы.Data.BeginUpdateData();
            //vmoГруппы.Data.MemoryTable.Clear();
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();
            foreach (var i in all.Rows)
            {
                //foreach (var j in i.Таблица.Rows)
                {
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_.Name, i[РегистрПоставокТоплива.Names.Объект].Value)
                        .Add(Время_.Name, NsgService.BeginOfMonth(dateTime));
                    var row = nsgVisualMultipleObject.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                        row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    row[Заказчик_].Value = i[ЗАКАЗЧИК].Value;
                    row[Поставщик_].Value = i[ПОСТАВЩИК].Value;
                    //Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    //row[Тариф_].Value = тариф;
                    Объекты объект = i[РегистрПоставокТоплива.Names.Объект].ToReferent() as Объекты;
                    row[Объект_].Value = объект;
                    //int номерСмены = (int)i[РегистрПоставокТоплива.Names.НомерСмены].ToInt();
                    //row[НомерСмены_].Value = номерСмены;
                    //row[СменаСтрока_].Value = "Смена " + номерСмены;
                    //foreach (МониторингРежимыРаботыТаблицаГрафик.Строка строкаГрафика in объект.РежимРаботы.ТаблицаГрафик.Rows)
                    //{
                    //    if (строкаГрафика.)
                    //}
                    //row[СтоимостьЗаЛитр_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Время_].Value = NsgService.BeginOfMonth(dateTime);
                    row[ВремяСтрока_].Value = new NsgDateTimePeriod(NsgService.BeginOfMonth(dateTime), NsgService.EndOfMonth(dateTime)).ToString();
                    decimal itogo = row[ИтогоЛ_].ToDecimal();
                    decimal stArItogo = row[ИтогоРуб_].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = row[$"{day}"].ToDecimal() + i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                            itogo += i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                            //stArItogo += /*тариф[Тарифы.Names.Стоимость].ToDecimal() **/ i[РегистрПоставокТоплива.Names.ОбъемТоплива].ToDebit();
                        }
                        else
                        {
                            //row[$"{day}"].Value = 0;
                        }
                    }
                    row[ИтогоЛ_].Value = itogo;
                    row[ИтогоРуб_].Value = stArItogo;
                    row[СтоимостьЗаЛитр_].Value = itogo == 0 ? 0 : stArItogo / itogo;
                    row.Post();

                    //var rowG = vmoГруппы.Data.MemoryTable.NewRow();
                    //rowG[Объект_г].Value = i[РегистрПоставокТоплива.Names.Объект].Value;
                    //rowG[Арендатор_г].Value = i[ЗАКАЗЧИК].Value;
                }
            }
            //vmoГруппы.Data.UpdateDataAsync(this);
            nsgVisualMultipleObject.Data.UpdateDataAsync(this);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }
	}
    


}