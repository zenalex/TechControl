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
using TechControl.Метаданные._SystemTables;

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
            ФиксацияИстории фи = ФиксацияИстории.Новый();
            ЗакрытиеСмены зс = ЗакрытиеСмены.Новый();
            DateTime dt = NsgService.BeginOfDay(nsgPeriodPicker1.Period.Begin);
            do
            {
                var endOfDay = NsgService.EndOfDay(dt);
                var a = фи.GetRests(endOfDay, new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
                foreach (var i in a.Rows)
                {
                    зс.New();
                    зс.ДокументОснование = i[ФиксацияИстории.Names.Владелец].ToReferent();
                    зс.ДатаДокумента = зс.Время = endOfDay;
                    зс.Техника = i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                    зс.Объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                    зс.Post();
                    зс.Handle();
                    dt = dt.AddDays(1);
                }
            }
            while (dt < nsgPeriodPicker1.Period.End);
        }
    }
    


}