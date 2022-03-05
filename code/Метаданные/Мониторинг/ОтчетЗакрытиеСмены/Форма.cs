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
    
    public partial class ОтчетЗакрытиеСменыФорма

    {
        public ОтчетЗакрытиеСменыФорма()
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

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            //ФиксацияИстории рег = ФиксацияИстории.Новый();
            //ЗакрытиеСмены зс = ЗакрытиеСмены.Новый();
            //DateTime dt = NsgService.BeginOfDay(nsgPeriodPicker1.Period.Begin);
            //var a = фи.GetRests(new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
            //var na = фи.GetRests(new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе, NsgSoft.Database.NsgComparison.NotEqual));
            //фи.New();
            //do
            //{
            //    //
            //    a.Filter(new NsgCompare().Add(ФиксацияИстории.Names.Время, new NsgDateTimePeriod(dt, dt.AddDays(1))));
            //    зс.New();
            //    dt = dt.AddDays(1);

            //    //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //    //в РегистрСмен пишем время в работе 
            //    рег.New();
            //    рег.Объект = this.Объект;

            //    var регСмены = РегистрСмен.Новый();
            //    регСмены.New();
            //    регСмены.Document = this;

            //    foreach (var i in this.Таблица.Rows)
            //    {
            //        рег.Сотрудник = i.Сотрудник;
            //        рег.Техника = i.Техника;
            //        рег.GetRest(this.ДатаДокумента.AddTicks(-1));
            //        var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
            //        рег.СтатусТехники = i.СтатусТехники;
            //        if (i.СтатусТехники != СтатусТехники.ВРаботе)
            //        {
            //            if (предСтатусТехники == СтатусТехники.ВРаботе)
            //            {
            //                var предВремя = рег.Время;
            //                рег.Время = i.Время.Date == NsgService.MinDate ?
            //                    this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
            //                    i.Время;
            //                регСмены.Объект = this.Объект;
            //                регСмены.Сотрудник = i.Сотрудник;
            //                регСмены.Техника = i.Техника;
            //                регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
            //                регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
            //                регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
            //                регСмены.AddMovement();
            //            }
            //        }
            //        else
            //        {
            //            рег.Время = i.Время.Date == NsgService.MinDate ?
            //                this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
            //                i.Время;
            //        }
            //        рег.AddMovement();
            //    }
            //    if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            //    return рег.Post();
            //}
            //while (dt < nsgPeriodPicker1.Period.End);
        }
    }
    


}