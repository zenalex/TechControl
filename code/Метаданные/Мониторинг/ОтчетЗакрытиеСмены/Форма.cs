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
            МониторингФормированиеСменыТаблица т = МониторингФормированиеСменыТаблица.Новый();
            var tall = т.GetAll();
            ФиксацияИстории фи = ФиксацияИстории.Новый();
            ЗакрытиеСмены зс = ЗакрытиеСмены.Новый();
            var рс = РегистрСмен.Новый();
            DateTime dt = NsgService.BeginOfDay(nsgPeriodPicker1.Period.Begin);
            //var all = рс.FindAll(new NsgCompare());
            //foreach (var i in all)
            {
                //if (i.Владелец is ФормированиеСмены фс)
                //{
                //    var _dt = NsgService.MinDate;
                //    foreach (var j in фс.Таблица.Rows)
                //    {
                //        //_dt = j[МониторингФормированиеСменыТаблица.Names.Время]
                //    }
                //}
                //var na = фи.GetRests(new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе, NsgSoft.Database.NsgComparison.NotEqual));
                //фи.New();
                do
                {
                    var a = фи.GetRests(dt, new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
                    //a.Filter(new NsgCompare().Add(ФиксацияИстории.Names.Время, new NsgDateTimePeriod(dt, dt.AddDays(1))));
                    dt = dt.AddDays(1);
                    foreach (var i in a.Rows)
                    {
                        //зс.New();
                        //зс.ДокументОснование = i[ФиксацияИстории.Names.Владелец].ToReferent();
                        //зс.Время = dt.AddTicks(-1);
                        //зс.Техника = i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                        //зс.Объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                        //зс.Post();
                        //зс.Handle();
                        ////зс.
                        фи.New();
                        рс.New();
                        рс.Техника = фи.Техника = i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                        рс.Объект = фи.Объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                        рс.Сотрудник = фи.Сотрудник = i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники;
                        фи.Дата = фи.Время = dt.AddTicks(-1);
                        фи.СтатусТехники = СтатусТехники.НеРаботает;
                        фи.AddMovement();
                        var предВремя = i[ФиксацияИстории.Names.Дата].ToDateTime();
                        рс.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(фи.Время - предВремя).TotalHours;
                        //рс.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                        рс.ВидДвижения = Сервис.ВидыДвижений.Расход;
                        рс.AddMovement();
                        рс.Post();

                        фи.Дата = фи.Время = dt;
                        фи.СтатусТехники = СтатусТехники.ВРаботе;
                        фи.AddMovement();
                        фи.Post();
                    }
                }
                while (dt < nsgPeriodPicker1.Period.End);
            }
        }
    }
    


}