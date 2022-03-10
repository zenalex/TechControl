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
                var a = фи.GetRests(endOfDay, new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе))
                    .CollapseToNewTable(new[] { ФиксацияИстории.Names.Объект }, null);
                foreach (var i in a.Rows)
                {
                    var объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                    if (!зс.Find(new NsgCompare()
                        .Add(ЗакрытиеСмены.Names.Объект, объект)
                        .Add(ЗакрытиеСмены.Names.ДатаДокумента, endOfDay)))
                    {
                        зс.New();
                        зс.ДатаДокумента = зс.Время = endOfDay;
                        зс.Объект = объект;
                        зс.Post();
                    }    
                    зс.Handle();
                }
                dt = dt.AddDays(1);
            }
            while (dt < nsgPeriodPicker1.Period.End);
        }
    }
    


}