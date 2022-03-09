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
            string ЗАКАЗЧИК = РегистрСмен.Names.Объект + '.' + Объекты.Names.Заказчик;
            var dims = nsgGroupsList1.GetAllItems();
            dims.Add(ФиксацияИстории.Names.Техника);
            dims.Add(ФиксацияИстории.Names.Сотрудник);
            dims.Remove(Арендатор_.Caption);
            dims.Remove(Время_.Caption);

            var рс = РегистрСмен.Новый();
            var all = рс.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, NsgSoft.Common.NsgPeriod.Day, nsgObjectFilter1.Compare,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit/*, new[] { РегистрСмен.Names.Объект }*/,
                dims.ToArray());
            vmoГруппы.Data.BeginUpdateData();
            vmoГруппы.Data.MemoryTable.Clear();
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();
            foreach (var i in all.Rows)
            {
                //foreach (var j in i.Таблица.Rows)
                {
                    DateTime dateTime = i[NsgSoft.Common.NsgDataFixedFields._Period].ToDateTime();
                    NsgCompare cmp = new NsgCompare()
                        .Add(Объект_.Name, i[РегистрСмен.Names.Объект].Value)
                        .Add(Наименование_.Name, i[РегистрСмен.Names.Техника + '.' + Техника.Names.Наименование].Value)
                        .Add(Время_.Name, NsgService.BeginOfMonth(dateTime));
                    var row = nsgVisualMultipleObject.Data.MemoryTable.FindRow(cmp);
                    if (row == null)
                    row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    Тарифы тариф = Тарифы.Новый();//вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    row[Арендатор_].Value = i[ЗАКАЗЧИК].Value;
                    row[Объект_].Value = i[РегистрСмен.Names.Объект].Value;
                    row[Тариф_].Value = тариф;
                    row[Наименование_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.Наименование].Value;
                    row[ГНомер_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.ГосНомер].Value;
                    //row[СтоимостьВЧас_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Время_].Value = NsgService.BeginOfMonth(dateTime);
                    row[ВремяСтрока_].Value = new NsgDateTimePeriod(NsgService.BeginOfMonth(dateTime), NsgService.EndOfMonth(dateTime)).ToString();
                    decimal itogo = row[Итого_].ToDecimal();
                    decimal stArItogo = row[СтоимостьАрендыИтого_].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        if (dateTime.Day == day)
                        {
                            row[$"{day}"].Value = row[$"{day}"].ToDecimal() + i[РегистрСмен.Names.ОтработанноеВремя].ToDebit();
                            itogo += i[РегистрСмен.Names.ОтработанноеВремя].ToDebit();
                            stArItogo += /*тариф[Тарифы.Names.Стоимость].ToDecimal() **/ i[РегистрСмен.Names.Сумма].ToDebit();
                        }
                        else
                        {
                            //row[$"{day}"].Value = 0;
                        }
                    }
                    row[Итого_].Value = itogo;
                    row[СтоимостьАрендыИтого_].Value = stArItogo;
                    row[СтоимостьВЧас_].Value = itogo == 0 ? 0 : stArItogo / itogo;
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