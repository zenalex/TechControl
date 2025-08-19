using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;





namespace TechControl.Метаданные.Отчеты
{
    
    public partial class ОтчетПоОтработанномуВремениФорма

    {
        public ОтчетПоОтработанномуВремениФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
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

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmpОбъект = nsgObjectFilter1.GetCompare(Объект_vmoFilter.Name).ReplaceParametersNames(Объект_vmoFilter.Name, Объекты.Names.Идентификатор);
            var cmpТехника = nsgObjectFilter1.GetCompare(Техника_vmoFilter.Name).ReplaceParametersNames(Техника_vmoFilter.Name, Техника.Names.Идентификатор);
            var cmpСотрудник = nsgObjectFilter1.GetCompare(Сотрудник_vmoFilter.Name).ReplaceParametersNames(Сотрудник_vmoFilter.Name, ФизЛица.Names.Идентификатор);
            var cmpТариф = nsgObjectFilter1.GetCompare(Тариф_vmoFilter.Name).ReplaceParametersNames(Тариф_vmoFilter.Name, Тарифы.Names.Идентификатор);
            var cmpДолжность = nsgObjectFilter1.GetCompare(Должность_vmoFilter.Name).ReplaceParametersNames(Должность_vmoFilter.Name, Должности.Names.Идентификатор);
            var доступныеОбъекты = Объекты.Новый().FindAll(cmpОбъект);
            var доступнаяТехника= Техника.Новый().FindAll(cmpТехника);
            var доступныеСотрудники = ФизЛица.Новый().FindAll(cmpСотрудник);
            var доступныеТарифы = Тарифы.Новый().FindAll(cmpТариф);
            var доступныеДолжности = Должности.Новый().FindAll(cmpДолжность);

        }
    }
    


}