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





namespace TechControl.Метаданные.ПечатныеФормыДокументов
{
    
    public partial class ПФОтработанныеМесяцыФорма

    {
        public ПФОтработанныеМесяцыФорма()
        {
            InitializeComponent();
		}

        public DateTime НачалоПериода;
        public DateTime КонецПериода;

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (vmoПараметрыОтчета.Data.CurrentRow == null)
            {
                vmoПараметрыОтчета.Data.CurrentRow = vmoПараметрыОтчета.Data.MemoryTable.NewRow();
            }
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            //base.OnCreateReport(nsgBackgroundReporter, e);
            ЗаполнитьДанные();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void ЗаполнитьДанные() 
        {
            if (Таблица.Value.Count > 0)
            {
                int minDay = 1;
                int maxDay = 31;
                if (НачалоПериода != DateTime.MinValue && КонецПериода != DateTime.MinValue)
                {
                    minDay = НачалоПериода.Day;
                    maxDay = КонецПериода.Day;
                }

                ДатаНачалаОтчета_vmoПараметрыОтчета.Value = НачалоПериода != DateTime.MinValue ? НачалоПериода : NsgService.BeginOfMonth(МесяцИтогов.Value);
                ДатаОкончанияОтчета_vmoПараметрыОтчета.Value = КонецПериода != DateTime.MinValue ? КонецПериода : NsgService.EndOfMonth(МесяцИтогов.Value);

                vmoДанные.Data.BeginUpdateData();
                vmoДанные.Data.MemoryTable.Clear();
                foreach (var item in Таблица.Value.AllRows)
                {
                    var row = vmoДанные.Data.MemoryTable.NewRow();
                    row[ОтработанноеВремя_vmoДанные].Value = ОтработанноеВремя(item, minDay, maxDay);
                    //row[Объект_vmoДанные].Value = item.Объект;
                    row[Сотрудник_vmoДанные].Value = item.Сотрудник;
                    row[Тариф_vmoДанные].Value = item.Тариф;
                    row[Техника_vmoДанные].Value = item.Техника;
                    row.Post();
                }
                vmoДанные.Data.UpdateDataSync(this);
            }
        }

        private decimal ОтработанноеВремя(ДокументыОтработанныеМесяцыТаблица.Строка item, int minDay, int maxDay)
        {
            decimal отработанноеВремя = 0;
            for (int i = minDay; i <= maxDay; i++)
            {
                отработанноеВремя += item["Д" + i].ToDecimal();
            }
            return отработанноеВремя;
        }

        private decimal ПолучитьОтработанноеВремя(ДокументыОтработанныеМесяцыТаблица.Строка item, int minDay, int maxDay) 
        {
            decimal отработанноеВремя = 0;
            if (minDay <= 1 && maxDay >= 1)
                отработанноеВремя += item.Д1;
            if (minDay <= 2 && maxDay >= 2)
                отработанноеВремя += item.Д2;
            if (minDay <= 3 && maxDay >= 3)
                отработанноеВремя += item.Д3;
            if (minDay <= 4 && maxDay >= 4)
                отработанноеВремя += item.Д4;
            if (minDay <= 5 && maxDay >= 5)
                отработанноеВремя += item.Д5;
            if (minDay <= 6 && maxDay >= 6)
                отработанноеВремя += item.Д6;
            if (minDay <= 7 && maxDay >= 7)
                отработанноеВремя += item.Д7;
            if (minDay <= 8 && maxDay >= 8)
                отработанноеВремя += item.Д8;
            if (minDay <= 9 && maxDay >= 9)
                отработанноеВремя += item.Д9;
            if (minDay <= 10 && maxDay >= 10)
                отработанноеВремя += item.Д10;
            if (minDay <= 11 && maxDay >= 11)
                отработанноеВремя += item.Д11;
            if (minDay <= 12 && maxDay >= 12)
                отработанноеВремя += item.Д12;
            if (minDay <= 13 && maxDay >= 13)
                отработанноеВремя += item.Д13;
            if (minDay <= 14 && maxDay >= 14)
                отработанноеВремя += item.Д14;
            if (minDay <= 15 && maxDay >= 15)
                отработанноеВремя += item.Д15;
            if (minDay <= 16 && maxDay >= 16)
                отработанноеВремя += item.Д16;
            if (minDay <= 17 && maxDay >= 17)
                отработанноеВремя += item.Д17;
            if (minDay <= 18 && maxDay >= 18)
                отработанноеВремя += item.Д18;
            if (minDay <= 19 && maxDay >= 19)
                отработанноеВремя += item.Д19;
            if (minDay <= 20 && maxDay >= 20)
                отработанноеВремя += item.Д20;
            if (minDay <= 21 && maxDay >= 21)
                отработанноеВремя += item.Д21;
            if (minDay <= 22 && maxDay >= 22)
                отработанноеВремя += item.Д22;
            if (minDay <= 23 && maxDay >= 23)
                отработанноеВремя += item.Д23;
            if (minDay <= 24 && maxDay >= 24)
                отработанноеВремя += item.Д24;
            if (minDay <= 25 && maxDay >= 25)
                отработанноеВремя += item.Д25;
            if (minDay <= 26 && maxDay >= 26)
                отработанноеВремя += item.Д26;
            if (minDay <= 27 && maxDay >= 27)
                отработанноеВремя += item.Д27;
            if (minDay <= 28 && maxDay >= 28)
                отработанноеВремя += item.Д28;
            if (minDay <= 29 && maxDay >= 29)
                отработанноеВремя += item.Д29;
            if (minDay <= 30 && maxDay >= 30)
                отработанноеВремя += item.Д30;
            if (minDay <= 31 && maxDay >= 31)
                отработанноеВремя += item.Д31;

            return отработанноеВремя;
        }
	}
    


}