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
            ФиксацияИстории фи = ФиксацияИстории.Новый();
            DateTime dt = NsgService.BeginOfDay(nsgPeriodPicker1.Period.Begin);
            var a = фи.GetRests(new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
            фи.New();
            do
            {
                //
                //var o = a.Filter(new NsgCompare().Add(ФиксацияИстории.Names.Время, ))
                dt = dt.AddDays(1);
            }
            while (dt < nsgPeriodPicker1.Period.End);
        }
    }
    


}