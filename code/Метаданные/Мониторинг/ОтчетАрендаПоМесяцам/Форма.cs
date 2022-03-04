using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;
using System.Linq;
using NsgSoft.Common;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ОтчетАрендаПоМесяцамФорма

    {
        public ОтчетАрендаПоМесяцамФорма()
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
            //var фс = ФормированиеСмены.Новый();
            //var all = фс.FindAll(new NsgCompare());
            //var рс = МониторингРегистрСменДвижения.Новый();
            //var all = рс.FindAll(new NsgCompare());
            string ЗАКАЗЧИК = РегистрСмен.Names.Объект + '.' + Объекты.Names.Заказчик;
            var dims = nsgGroupsList1.GetAllItems();
            dims.Add(ФиксацияИстории.Names.Владелец);
            dims.Add(ФиксацияИстории.Names.Техника);
            dims.Remove(Арендатор_.Caption);
            dims.Remove(Время_.Caption);

            var рс = РегистрСмен.Новый();
            var all = рс.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter1.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit, new[] { РегистрСмен.Names.Объект },
                dims.ToArray());
            //var рс = ФиксацияИстории.Новый();
            //var all = рс.GetRests(nsgPeriodPicker1.Period.End, nsgObjectFilter1.Compare,
            //    new List<string> { ФиксацияИстории.Names.Объект },
            //    dims.ToArray());
            //var all = рс.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter1.Compare,
            //    NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit, new[] { ФиксацияИстории.Names.Объект },
            //    dims.ToArray());
            vmoГруппы.Data.BeginUpdateData();
            vmoГруппы.Data.MemoryTable.Clear();
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();
            //var ov = РегистрСмен.Новый().GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, NsgSoft.Common.NsgPeriod.Day, null,
            //    NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
            //    РегистрСмен.Names.Владелец);
            foreach (var i in all.Rows)
            {
                //foreach (var j in i.Таблица.Rows)
                {
                    var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    //row[Арендатор_].Value = i[ФормированиеСмены.Names.Объект + '.' + Объекты.Names.Заказчик].Value;
                    //row[Объект_].Value = i[ФормированиеСмены.Names.Объект].Value;
                    //row[Тариф_].Value = i[ФормированиеСмены.Names.Тариф].Value;
                    //row[Наименование_].Value = j[МониторингФормированиеСменыТаблица.Names.Техника + '.' + Техника.Names.Наименование].Value;
                    //row[ГНомер_].Value = j[МониторингФормированиеСменыТаблица.Names.Техника + '.' + Техника.Names.ГосНомер].Value;
                    //row[СтоимостьВЧас_].Value =  i[ФормированиеСмены.Names.Тариф + '.' + Тарифы.Names.Стоимость].Value;
                    //row[Итого_].Value = i[ФормированиеСмены.Names.Тариф + '.' + Тарифы.Names.Стоимость].Value;
                    ////row[СтоимостьАрендыИтого_].Value = null;
                    //var fnd = фи.GetRests(new NsgCompare()
                    //    .Add(ФиксацияИстории.Names.Владелец, i[РегистрСмен.Names.Владелец].Value)
                    //    .Add(ФиксацияИстории.Names.Техника, i[РегистрСмен.Names.Техника].Value));
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    ФормированиеСмены вл = i[РегистрСмен.Names.Владелец].ToReferent() as ФормированиеСмены;
                    Тарифы тариф = вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    row[Арендатор_].Value = i[ЗАКАЗЧИК].Value;
                    row[Объект_].Value = i[РегистрСмен.Names.Объект].Value;
                    row[Тариф_].Value = тариф;
                    row[Наименование_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.Наименование].Value;
                    row[ГНомер_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.ГосНомер].Value;
                    row[СтоимостьВЧас_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Время_].Value = NsgService.BeginOfMonth(dateTime);
                    row[ВремяСтрока_].Value = new NsgDateTimePeriod(NsgService.BeginOfMonth(dateTime), NsgService.EndOfMonth(dateTime)).ToString();
                    decimal itogo = 0;
                    decimal stArItogo = 0;
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = i[РегистрСмен.Names.ОтработанноеВремя].ToDebit();
                            itogo += i[РегистрСмен.Names.ОтработанноеВремя].ToDebit();
                            stArItogo += тариф[Тарифы.Names.Стоимость].ToDecimal() * i[РегистрСмен.Names.ОтработанноеВремя].ToDebit();
                        }
                        else
                        {
                            row[$"{day}"].Value = 0;
                        }
                    }
                    row[Итого_].Value = itogo;
                    row[СтоимостьАрендыИтого_].Value = stArItogo;
                    row.Post();

                    var rowG = vmoГруппы.Data.MemoryTable.NewRow();
                    rowG[Объект_г].Value = i[РегистрСмен.Names.Объект].Value;
                    rowG[Арендатор_г].Value = i[ЗАКАЗЧИК].Value;
                }
            }
            vmoГруппы.Data.UpdateDataAsync(this);
            nsgVisualMultipleObject.Data.UpdateDataAsync(this);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

	}
    


}