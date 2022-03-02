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
            var рс = МониторингРегистрСменДвижения.Новый();
            var all = рс.FindAll(new NsgCompare());
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();
            string ЗАКАЗЧИК = РегистрСмен.Names.Объект + '.' + Объекты.Names.Заказчик;
            var ov = РегистрСмен.Новый().GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, NsgSoft.Common.NsgPeriod.Day, null,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                РегистрСмен.Names.Владелец);
            foreach (var i in all)
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

                    ФормированиеСмены вл = i[РегистрСмен.Names.Владелец].ToReferent() as ФормированиеСмены;
                    Тарифы тариф = вл[ФормированиеСмены.Names.Тариф].ToReferent() as Тарифы;
                    row[Арендатор_].Value = i[ЗАКАЗЧИК].Value;
                    row[Объект_].Value = i[РегистрСмен.Names.Объект].Value;
                    row[Тариф_].Value = тариф;
                    row[Наименование_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.Наименование].Value;
                    row[ГНомер_].Value = i[РегистрСмен.Names.Техника + '.' + Техника.Names.ГосНомер].Value;
                    row[СтоимостьВЧас_].Value = тариф[Тарифы.Names.Стоимость].Value;
                    row[Итого_].Value = тариф[Тарифы.Names.Стоимость].ToDecimal() * i[РегистрСмен.Names.ОтработанноеВремя].ToDecimal();
                    for (int day = 1; day <= 31; day++)
                    {
                        var vlR = ov.Rows.FirstOrDefault(z => z[РегистрСмен.Names.Владелец].ToReferent() == вл &&
                            z[РегистрСмен.Names.ДатаДокумента].ToDateTime().Day == day);
                        row[$"{day}"].Value = vlR?[РегистрСмен.Names.ОтработанноеВремя].Value ?? 0;
                    }
                    //row[СтоимостьАрендыИтого_].Value = 
                    row.Post();
                }
            }
            nsgVisualMultipleObject.Data.UpdateDataAsync(this);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

	}
    


}