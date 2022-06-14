using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ОтчетПоЗаправкамФорма:NsgSoft.Forms.NsgReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоЗаправкамФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn1 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn2 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn3 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn4 = new NsgSoft.Forms.NsgGridColumn();
            this.nsgObjectFilter = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Техника_ф = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Поставщик_ф = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект_ф = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Заказчик_ф = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.nsgPeriodPicker = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgGroupsList = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport3 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.nsgReportDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource9 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource", this.nsgReportDataSource);
            this.rdsФильтр = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource10 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsФильтр", this.rdsФильтр);
            this.rdsШапка = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoШапка = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаСоставления = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НачалоПериода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ОкончаниеПериода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ИтогКостыль = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.stiReportDataSource11 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsШапка", this.rdsШапка);
            this.rdsЗаправки = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoЗаправки = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Поставщик_vmoЗаправки = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект_vmoЗаправки = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ГосНомер_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.День1_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День2_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День3_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День4_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День5_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День6_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День7_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День8_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День9_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День10_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День11_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День12_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День13_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День14_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День15_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День16_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День17_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День18_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День19_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День20_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День21_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День22_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День23_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День24_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День25_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День26_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День27_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День28_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День29_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День30_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День31_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Время_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяСтрока_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СтоимостьЗаЛитр_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоЛ_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоРуб_vmoЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Заказчик_vmoЗаправки = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.stiReportDataSource12 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsЗаправки", this.rdsЗаправки);
            this.nsgReport2 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource5 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource", this.nsgReportDataSource);
            this.stiReportDataSource6 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsФильтр", this.rdsФильтр);
            this.stiReportDataSource7 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsШапка", this.rdsШапка);
            this.stiReportDataSource8 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsЗаправки", this.rdsЗаправки);
            this.rdsЗаправки1 = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoЗаправки1 = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Поставщик_з1 = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Заказчик_з1 = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект_з1 = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ГосНомер_з1 = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Время_з1 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяСтрока_з1 = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.День1_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День2_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День3_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День4_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День5_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День6_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День7_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День8_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День9_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День10_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День11_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День12_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День13_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День14_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День15_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День16_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День17_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День18_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День19_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День20_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День21_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День22_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День23_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День24_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День25_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День26_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День27_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День28_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День29_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День30_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День31_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.СтоимостьЗаЛитр_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоЛ_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоРуб_з1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.stiReportDataSource13 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsЗаправки1", this.rdsЗаправки1);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource", this.nsgReportDataSource);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsФильтр", this.rdsФильтр);
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsШапка", this.rdsШапка);
            this.stiReportDataSource4 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsЗаправки", this.rdsЗаправки);
            this.Техника_ = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Поставщик_ = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект_ = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ГосНомер_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.День1_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День2_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День3_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День4_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День5_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День6_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День7_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День8_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День9_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День10_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День11_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День12_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День13_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День14_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День15_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День16_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День17_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День18_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День19_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День20_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День21_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День22_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День23_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День24_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День25_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День26_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День27_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День28_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День29_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День30_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.День31_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итого_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Время_ = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяСтрока_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Заказчик_ = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.ИтогоСлив_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоЗаправка_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoШапка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsЗаправки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаправки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsЗаправки1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаправки1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateReport.DisabledImageKey = "disabled_nsgdatadocument";
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateReport.ImageKey = "nsgdatadocument";
            this.btnCreateReport.Location = new System.Drawing.Point(0, 0);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(112, 30);
            this.btnCreateReport.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnCreateReport.TabIndex = 0;
            this.btnCreateReport.Text = "Сформировать";
            this.btnCreateReport.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.AllowDrop = true;
            this.panelButtonReportForm.Controls.Add(this.formSettingsButton);
            this.panelButtonReportForm.Controls.Add(this.printButton);
            this.panelButtonReportForm.Controls.Add(this.btnCreateReport);
            this.panelButtonReportForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 396);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(984, 30);
            this.panelButtonReportForm.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Печать";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(964, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 30);
            this.printButton.TabIndex = 1;
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.formSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formSettingsButton.DisabledImageKey = "disabled_Settings";
            this.formSettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.formSettingsButton.ImageKey = "Settings";
            this.formSettingsButton.ImagePosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.formSettingsButton.Location = new System.Drawing.Point(112, 0);
            this.formSettingsButton.Name = "formSettingsButton";
            this.formSettingsButton.Size = new System.Drawing.Size(28, 30);
            this.formSettingsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.formSettingsButton.TabIndex = 2;
            this.formSettingsButton.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Техника_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Поставщик_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГосНомер_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День1_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День2_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День3_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День4_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День5_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День6_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День7_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День8_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День9_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День10_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День11_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День12_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День13_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День14_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День15_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День16_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День17_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День18_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День19_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День20_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День21_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День22_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День23_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День24_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День25_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День26_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День27_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День28_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День29_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День30_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.День31_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Итого_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Время_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВремяСтрока_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Заказчик_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИтогоСлив_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИтогоЗаправка_);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgObjectFilter
            // 
            this.nsgObjectFilter.AllowDrop = true;
            this.nsgObjectFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgObjectFilter.AutoSetCompare = true;
            this.nsgObjectFilter.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn1.Caption = "";
            nsgGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn1.ImportedFromVMO = false;
            nsgGridColumn1.Name = "Техника";
            nsgGridColumn1.Root = this.nsgObjectFilter.Columns.Collection;
            nsgGridColumn2.Caption = "";
            nsgGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn2.ImportedFromVMO = false;
            nsgGridColumn2.Name = "Поставщик";
            nsgGridColumn2.Root = this.nsgObjectFilter.Columns.Collection;
            nsgGridColumn3.Caption = "";
            nsgGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn3.ImportedFromVMO = false;
            nsgGridColumn3.Name = "Объект";
            nsgGridColumn3.Root = this.nsgObjectFilter.Columns.Collection;
            nsgGridColumn4.Caption = "";
            nsgGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn4.ImportedFromVMO = false;
            nsgGridColumn4.Name = "Объект.Заказчик";
            nsgGridColumn4.Root = this.nsgObjectFilter.Columns.Collection;
            this.nsgObjectFilter.Columns.Collection.Add(nsgGridColumn1);
            this.nsgObjectFilter.Columns.Collection.Add(nsgGridColumn2);
            this.nsgObjectFilter.Columns.Collection.Add(nsgGridColumn3);
            this.nsgObjectFilter.Columns.Collection.Add(nsgGridColumn4);
            this.nsgObjectFilter.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter.Grouping = false;
            this.nsgObjectFilter.IsModify = true;
            this.nsgObjectFilter.LineHeight = 20;
            this.nsgObjectFilter.Location = new System.Drawing.Point(0, 0);
            this.nsgObjectFilter.LockAdditionalColumns = false;
            this.nsgObjectFilter.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter.Name = "NsgObjectFilter";
            this.nsgObjectFilter.ReadOnly = false;
            this.nsgObjectFilter.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter.SaveSettings = true;
            this.nsgObjectFilter.Size = new System.Drawing.Size(678, 390);
            this.nsgObjectFilter.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter.TabIndex = 11;
            this.nsgObjectFilter.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Техника_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Поставщик_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Объект_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Заказчик_ф);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // Техника_ф
            // 
            this.Техника_ф.Caption = "Техника";
            this.Техника_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_ф.Name = "Техника";
            this.Техника_ф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_ф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_ф.SearchCondition.OwnerComponent = this.Техника_ф;
            this.Техника_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Поставщик_ф
            // 
            this.Поставщик_ф.Caption = "Поставщик";
            this.Поставщик_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Поставщик_ф.Name = "Поставщик";
            this.Поставщик_ф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_ф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_ф.SearchCondition.OwnerComponent = this.Поставщик_ф;
            this.Поставщик_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_ф
            // 
            this.Объект_ф.Caption = "Объект";
            this.Объект_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_ф.Name = "Объект";
            this.Объект_ф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_ф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_ф.SearchCondition.OwnerComponent = this.Объект_ф;
            this.Объект_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик_ф
            // 
            this.Заказчик_ф.Caption = "Объект.Заказчик";
            this.Заказчик_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Заказчик_ф.Name = "Объект.Заказчик";
            this.Заказчик_ф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_ф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_ф.SearchCondition.OwnerComponent = this.Заказчик_ф;
            this.Заказчик_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgPeriodPicker
            // 
            this.nsgPeriodPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgPeriodPicker.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker.Location = new System.Drawing.Point(684, 0);
            this.nsgPeriodPicker.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker.Size = new System.Drawing.Size(300, 27);
            this.nsgPeriodPicker.TabIndex = 12;
            // 
            // nsgGroupsList
            // 
            this.nsgGroupsList.AllowDrop = true;
            this.nsgGroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgGroupsList.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList.DisableComponents")));
            this.nsgGroupsList.Location = new System.Drawing.Point(684, 33);
            this.nsgGroupsList.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList.Name = "NsgGroupsList";
            this.nsgGroupsList.NsgRemoveMasterComponent = true;
            this.nsgGroupsList.SetReport = this.nsgReport3;
            this.nsgGroupsList.SetTitle = "Группировка";
            this.nsgGroupsList.Size = new System.Drawing.Size(300, 357);
            this.nsgGroupsList.TabIndex = 10;
            // 
            // nsgReport3
            // 
            this.nsgReport3.CurrentProgressValue = 0;
            this.nsgReport3.HighlightedComponent = null;
            this.nsgReport3.IsSyncMode = true;
            this.nsgReport3.MaxProgressValue = 100;
            this.nsgReport3.OwnerForm = null;
            this.nsgReport3.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport3.ProgressObject = null;
            this.nsgReport3.ProgressProcentage = 0;
            this.nsgReport3.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "TechControl.exe",
        "TechControl",
        "NsgSoft.Common.dll",
        "NsgSoft.DataObjects.dll",
        "NsgSoft.Design.dll",
        "NsgSoft.Windows.iGridLib.iGrid.dll",
        "NsgSoft.Database.dll",
        "NsgSoft.ReportCompression.dll",
        "NsgSoft.Database.FireBird.dll",
        "NsgSoft.Forms.dll",
        "WeifenLuo.WinFormsUI.Docking.dll",
        "NsgSoft.ReportBuilder.dll",
        "NsgSoft.ReportBase.dll",
        "NsgSoft.ReportControls.dll",
        "NsgSoft.ReportEditor.dll"};
            this.nsgReport3.ReportAlias = "Отчет_по_заправкам___13_04";
            this.nsgReport3.ReportDataSources.Add(this.stiReportDataSource9);
            this.nsgReport3.ReportDataSources.Add(this.stiReportDataSource10);
            this.nsgReport3.ReportDataSources.Add(this.stiReportDataSource11);
            this.nsgReport3.ReportDataSources.Add(this.stiReportDataSource12);
            this.nsgReport3.ReportGuid = "1c0ca394f9c64cffb6f7dafe317d0af3";
            this.nsgReport3.ReportLoaded = true;
            this.nsgReport3.ReportName = "Отчет_по_заправкам___13_04";
            this.nsgReport3.ReportSource = resources.GetString("nsgReport3.ReportSource");
            this.nsgReport3.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport3.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport3.ShowBookmarksPanel = false;
            // 
            // nsgReportDataSource
            // 
            this.nsgReportDataSource.MasterComponent = this.nsgVisualMultipleObject;
            this.nsgReportDataSource.Name = "nsgReportDataSource";
            // 
            // stiReportDataSource9
            // 
            this.stiReportDataSource9.Item = this.nsgReportDataSource;
            this.stiReportDataSource9.Name = "nsgReportDataSource";
            // 
            // rdsФильтр
            // 
            this.rdsФильтр.MasterComponent = this.vmoФильтр;
            this.rdsФильтр.Name = "rdsФильтр";
            // 
            // stiReportDataSource10
            // 
            this.stiReportDataSource10.Item = this.rdsФильтр;
            this.stiReportDataSource10.Name = "rdsФильтр";
            // 
            // rdsШапка
            // 
            this.rdsШапка.MasterComponent = this.vmoШапка;
            this.rdsШапка.Name = "rdsШапка";
            this.rdsШапка.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // vmoШапка
            // 
            this.vmoШапка.Columns.Collection.Add(this.ДатаСоставления);
            this.vmoШапка.Columns.Collection.Add(this.НачалоПериода);
            this.vmoШапка.Columns.Collection.Add(this.ОкончаниеПериода);
            this.vmoШапка.Columns.Collection.Add(this.ИтогКостыль);
            this.vmoШапка.IsActive = true;
            this.vmoШапка.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoШапка.MetaDataName = "";
            this.vmoШапка.FullName = "";
            // 
            // ДатаСоставления
            // 
            this.ДатаСоставления.Caption = "ДатаСоставления";
            this.ДатаСоставления.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаСоставления.Name = "ДатаСоставления";
            this.ДатаСоставления.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ДатаСоставления.PropertyType = typeof(string);
            this.ДатаСоставления.SearchCondition.OwnerComponent = this.ДатаСоставления;
            this.ДатаСоставления.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НачалоПериода
            // 
            this.НачалоПериода.Caption = "НачалоПериода";
            this.НачалоПериода.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НачалоПериода.Name = "НачалоПериода";
            this.НачалоПериода.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НачалоПериода.PropertyType = typeof(string);
            this.НачалоПериода.SearchCondition.OwnerComponent = this.НачалоПериода;
            this.НачалоПериода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОкончаниеПериода
            // 
            this.ОкончаниеПериода.Caption = "ОкончаниеПериода";
            this.ОкончаниеПериода.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОкончаниеПериода.Name = "ОкончаниеПериода";
            this.ОкончаниеПериода.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ОкончаниеПериода.PropertyType = typeof(string);
            this.ОкончаниеПериода.SearchCondition.OwnerComponent = this.ОкончаниеПериода;
            this.ОкончаниеПериода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогКостыль
            // 
            this.ИтогКостыль.Caption = "ИтогКостыль";
            this.ИтогКостыль.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогКостыль.Name = "ИтогКостыль";
            this.ИтогКостыль.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИтогКостыль.PropertyType = typeof(string);
            this.ИтогКостыль.SearchCondition.OwnerComponent = this.ИтогКостыль;
            this.ИтогКостыль.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource11
            // 
            this.stiReportDataSource11.Item = this.rdsШапка;
            this.stiReportDataSource11.Name = "rdsШапка";
            // 
            // rdsЗаправки
            // 
            this.rdsЗаправки.MasterComponent = this.vmoЗаправки;
            this.rdsЗаправки.Name = "rdsЗаправки";
            // 
            // vmoЗаправки
            // 
            this.vmoЗаправки.Columns.Collection.Add(this.Поставщик_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.Объект_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.ГосНомер_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День1_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День2_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День3_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День4_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День5_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День6_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День7_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День8_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День9_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День10_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День11_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День12_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День13_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День14_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День15_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День16_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День17_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День18_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День19_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День20_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День21_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День22_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День23_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День24_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День25_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День26_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День27_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День28_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День29_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День30_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.День31_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.Время_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.ВремяСтрока_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.СтоимостьЗаЛитр_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.ИтогоЛ_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.ИтогоРуб_vmoЗаправки);
            this.vmoЗаправки.Columns.Collection.Add(this.Заказчик_vmoЗаправки);
            this.vmoЗаправки.IsActive = true;
            this.vmoЗаправки.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoЗаправки.MetaDataName = "";
            this.vmoЗаправки.FullName = "";
            // 
            // Поставщик_vmoЗаправки
            // 
            this.Поставщик_vmoЗаправки.Caption = "Поставщик";
            this.Поставщик_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Поставщик_vmoЗаправки.Name = "Поставщик";
            this.Поставщик_vmoЗаправки.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_vmoЗаправки.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_vmoЗаправки.SearchCondition.OwnerComponent = this.Поставщик_vmoЗаправки;
            this.Поставщик_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoЗаправки
            // 
            this.Объект_vmoЗаправки.Caption = "Объект";
            this.Объект_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoЗаправки.Name = "Объект";
            this.Объект_vmoЗаправки.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoЗаправки.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoЗаправки.SearchCondition.OwnerComponent = this.Объект_vmoЗаправки;
            this.Объект_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГосНомер_vmoЗаправки
            // 
            this.ГосНомер_vmoЗаправки.Caption = "ГосНомер";
            this.ГосНомер_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГосНомер_vmoЗаправки.Name = "ГосНомер";
            this.ГосНомер_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГосНомер_vmoЗаправки.PropertyType = typeof(string);
            this.ГосНомер_vmoЗаправки.SearchCondition.OwnerComponent = this.ГосНомер_vmoЗаправки;
            this.ГосНомер_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День1_vmoЗаправки
            // 
            this.День1_vmoЗаправки.CalcTotal = false;
            this.День1_vmoЗаправки.Caption = "1";
            this.День1_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День1_vmoЗаправки.Name = "1";
            this.День1_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День1_vmoЗаправки.PropertyType = typeof(decimal);
            this.День1_vmoЗаправки.SearchCondition.OwnerComponent = this.День1_vmoЗаправки;
            this.День1_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День2_vmoЗаправки
            // 
            this.День2_vmoЗаправки.CalcTotal = false;
            this.День2_vmoЗаправки.Caption = "2";
            this.День2_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День2_vmoЗаправки.Name = "2";
            this.День2_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День2_vmoЗаправки.PropertyType = typeof(decimal);
            this.День2_vmoЗаправки.SearchCondition.OwnerComponent = this.День2_vmoЗаправки;
            this.День2_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День3_vmoЗаправки
            // 
            this.День3_vmoЗаправки.CalcTotal = false;
            this.День3_vmoЗаправки.Caption = "3";
            this.День3_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День3_vmoЗаправки.Name = "3";
            this.День3_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День3_vmoЗаправки.PropertyType = typeof(decimal);
            this.День3_vmoЗаправки.SearchCondition.OwnerComponent = this.День3_vmoЗаправки;
            this.День3_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День4_vmoЗаправки
            // 
            this.День4_vmoЗаправки.CalcTotal = false;
            this.День4_vmoЗаправки.Caption = "4";
            this.День4_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День4_vmoЗаправки.Name = "4";
            this.День4_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День4_vmoЗаправки.PropertyType = typeof(decimal);
            this.День4_vmoЗаправки.SearchCondition.OwnerComponent = this.День4_vmoЗаправки;
            this.День4_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День5_vmoЗаправки
            // 
            this.День5_vmoЗаправки.CalcTotal = false;
            this.День5_vmoЗаправки.Caption = "5";
            this.День5_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День5_vmoЗаправки.Name = "5";
            this.День5_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День5_vmoЗаправки.PropertyType = typeof(decimal);
            this.День5_vmoЗаправки.SearchCondition.OwnerComponent = this.День5_vmoЗаправки;
            this.День5_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День6_vmoЗаправки
            // 
            this.День6_vmoЗаправки.CalcTotal = false;
            this.День6_vmoЗаправки.Caption = "6";
            this.День6_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День6_vmoЗаправки.Name = "6";
            this.День6_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День6_vmoЗаправки.PropertyType = typeof(decimal);
            this.День6_vmoЗаправки.SearchCondition.OwnerComponent = this.День6_vmoЗаправки;
            this.День6_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День7_vmoЗаправки
            // 
            this.День7_vmoЗаправки.CalcTotal = false;
            this.День7_vmoЗаправки.Caption = "7";
            this.День7_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День7_vmoЗаправки.Name = "7";
            this.День7_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День7_vmoЗаправки.PropertyType = typeof(decimal);
            this.День7_vmoЗаправки.SearchCondition.OwnerComponent = this.День7_vmoЗаправки;
            this.День7_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День8_vmoЗаправки
            // 
            this.День8_vmoЗаправки.CalcTotal = false;
            this.День8_vmoЗаправки.Caption = "8";
            this.День8_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День8_vmoЗаправки.Name = "8";
            this.День8_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День8_vmoЗаправки.PropertyType = typeof(decimal);
            this.День8_vmoЗаправки.SearchCondition.OwnerComponent = this.День8_vmoЗаправки;
            this.День8_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День9_vmoЗаправки
            // 
            this.День9_vmoЗаправки.CalcTotal = false;
            this.День9_vmoЗаправки.Caption = "9";
            this.День9_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День9_vmoЗаправки.Name = "9";
            this.День9_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День9_vmoЗаправки.PropertyType = typeof(decimal);
            this.День9_vmoЗаправки.SearchCondition.OwnerComponent = this.День9_vmoЗаправки;
            this.День9_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День10_vmoЗаправки
            // 
            this.День10_vmoЗаправки.CalcTotal = false;
            this.День10_vmoЗаправки.Caption = "10";
            this.День10_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День10_vmoЗаправки.Name = "10";
            this.День10_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День10_vmoЗаправки.PropertyType = typeof(decimal);
            this.День10_vmoЗаправки.SearchCondition.OwnerComponent = this.День10_vmoЗаправки;
            this.День10_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День11_vmoЗаправки
            // 
            this.День11_vmoЗаправки.CalcTotal = false;
            this.День11_vmoЗаправки.Caption = "11";
            this.День11_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День11_vmoЗаправки.Name = "11";
            this.День11_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День11_vmoЗаправки.PropertyType = typeof(decimal);
            this.День11_vmoЗаправки.SearchCondition.OwnerComponent = this.День11_vmoЗаправки;
            this.День11_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День12_vmoЗаправки
            // 
            this.День12_vmoЗаправки.CalcTotal = false;
            this.День12_vmoЗаправки.Caption = "12";
            this.День12_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День12_vmoЗаправки.Name = "12";
            this.День12_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День12_vmoЗаправки.PropertyType = typeof(decimal);
            this.День12_vmoЗаправки.SearchCondition.OwnerComponent = this.День12_vmoЗаправки;
            this.День12_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День13_vmoЗаправки
            // 
            this.День13_vmoЗаправки.CalcTotal = false;
            this.День13_vmoЗаправки.Caption = "13";
            this.День13_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День13_vmoЗаправки.Name = "13";
            this.День13_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День13_vmoЗаправки.PropertyType = typeof(decimal);
            this.День13_vmoЗаправки.SearchCondition.OwnerComponent = this.День13_vmoЗаправки;
            this.День13_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День14_vmoЗаправки
            // 
            this.День14_vmoЗаправки.CalcTotal = false;
            this.День14_vmoЗаправки.Caption = "14";
            this.День14_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День14_vmoЗаправки.Name = "14";
            this.День14_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День14_vmoЗаправки.PropertyType = typeof(decimal);
            this.День14_vmoЗаправки.SearchCondition.OwnerComponent = this.День14_vmoЗаправки;
            this.День14_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День15_vmoЗаправки
            // 
            this.День15_vmoЗаправки.CalcTotal = false;
            this.День15_vmoЗаправки.Caption = "15";
            this.День15_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День15_vmoЗаправки.Name = "15";
            this.День15_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День15_vmoЗаправки.PropertyType = typeof(decimal);
            this.День15_vmoЗаправки.SearchCondition.OwnerComponent = this.День15_vmoЗаправки;
            this.День15_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День16_vmoЗаправки
            // 
            this.День16_vmoЗаправки.CalcTotal = false;
            this.День16_vmoЗаправки.Caption = "16";
            this.День16_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День16_vmoЗаправки.Name = "16";
            this.День16_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День16_vmoЗаправки.PropertyType = typeof(decimal);
            this.День16_vmoЗаправки.SearchCondition.OwnerComponent = this.День16_vmoЗаправки;
            this.День16_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День17_vmoЗаправки
            // 
            this.День17_vmoЗаправки.CalcTotal = false;
            this.День17_vmoЗаправки.Caption = "17";
            this.День17_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День17_vmoЗаправки.Name = "17";
            this.День17_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День17_vmoЗаправки.PropertyType = typeof(decimal);
            this.День17_vmoЗаправки.SearchCondition.OwnerComponent = this.День17_vmoЗаправки;
            this.День17_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День18_vmoЗаправки
            // 
            this.День18_vmoЗаправки.CalcTotal = false;
            this.День18_vmoЗаправки.Caption = "18";
            this.День18_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День18_vmoЗаправки.Name = "18";
            this.День18_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День18_vmoЗаправки.PropertyType = typeof(decimal);
            this.День18_vmoЗаправки.SearchCondition.OwnerComponent = this.День18_vmoЗаправки;
            this.День18_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День19_vmoЗаправки
            // 
            this.День19_vmoЗаправки.CalcTotal = false;
            this.День19_vmoЗаправки.Caption = "19";
            this.День19_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День19_vmoЗаправки.Name = "19";
            this.День19_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День19_vmoЗаправки.PropertyType = typeof(decimal);
            this.День19_vmoЗаправки.SearchCondition.OwnerComponent = this.День19_vmoЗаправки;
            this.День19_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День20_vmoЗаправки
            // 
            this.День20_vmoЗаправки.CalcTotal = false;
            this.День20_vmoЗаправки.Caption = "20";
            this.День20_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День20_vmoЗаправки.Name = "20";
            this.День20_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День20_vmoЗаправки.PropertyType = typeof(decimal);
            this.День20_vmoЗаправки.SearchCondition.OwnerComponent = this.День20_vmoЗаправки;
            this.День20_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День21_vmoЗаправки
            // 
            this.День21_vmoЗаправки.CalcTotal = false;
            this.День21_vmoЗаправки.Caption = "21";
            this.День21_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День21_vmoЗаправки.Name = "21";
            this.День21_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День21_vmoЗаправки.PropertyType = typeof(decimal);
            this.День21_vmoЗаправки.SearchCondition.OwnerComponent = this.День21_vmoЗаправки;
            this.День21_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День22_vmoЗаправки
            // 
            this.День22_vmoЗаправки.CalcTotal = false;
            this.День22_vmoЗаправки.Caption = "22";
            this.День22_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День22_vmoЗаправки.Name = "22";
            this.День22_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День22_vmoЗаправки.PropertyType = typeof(decimal);
            this.День22_vmoЗаправки.SearchCondition.OwnerComponent = this.День22_vmoЗаправки;
            this.День22_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День23_vmoЗаправки
            // 
            this.День23_vmoЗаправки.CalcTotal = false;
            this.День23_vmoЗаправки.Caption = "23";
            this.День23_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День23_vmoЗаправки.Name = "23";
            this.День23_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День23_vmoЗаправки.PropertyType = typeof(decimal);
            this.День23_vmoЗаправки.SearchCondition.OwnerComponent = this.День23_vmoЗаправки;
            this.День23_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День24_vmoЗаправки
            // 
            this.День24_vmoЗаправки.CalcTotal = false;
            this.День24_vmoЗаправки.Caption = "24";
            this.День24_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День24_vmoЗаправки.Name = "24";
            this.День24_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День24_vmoЗаправки.PropertyType = typeof(decimal);
            this.День24_vmoЗаправки.SearchCondition.OwnerComponent = this.День24_vmoЗаправки;
            this.День24_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День25_vmoЗаправки
            // 
            this.День25_vmoЗаправки.CalcTotal = false;
            this.День25_vmoЗаправки.Caption = "25";
            this.День25_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День25_vmoЗаправки.Name = "25";
            this.День25_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День25_vmoЗаправки.PropertyType = typeof(decimal);
            this.День25_vmoЗаправки.SearchCondition.OwnerComponent = this.День25_vmoЗаправки;
            this.День25_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День26_vmoЗаправки
            // 
            this.День26_vmoЗаправки.CalcTotal = false;
            this.День26_vmoЗаправки.Caption = "26";
            this.День26_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День26_vmoЗаправки.Name = "26";
            this.День26_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День26_vmoЗаправки.PropertyType = typeof(decimal);
            this.День26_vmoЗаправки.SearchCondition.OwnerComponent = this.День26_vmoЗаправки;
            this.День26_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День27_vmoЗаправки
            // 
            this.День27_vmoЗаправки.CalcTotal = false;
            this.День27_vmoЗаправки.Caption = "27";
            this.День27_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День27_vmoЗаправки.Name = "27";
            this.День27_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День27_vmoЗаправки.PropertyType = typeof(decimal);
            this.День27_vmoЗаправки.SearchCondition.OwnerComponent = this.День27_vmoЗаправки;
            this.День27_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День28_vmoЗаправки
            // 
            this.День28_vmoЗаправки.CalcTotal = false;
            this.День28_vmoЗаправки.Caption = "28";
            this.День28_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День28_vmoЗаправки.Name = "28";
            this.День28_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День28_vmoЗаправки.PropertyType = typeof(decimal);
            this.День28_vmoЗаправки.SearchCondition.OwnerComponent = this.День28_vmoЗаправки;
            this.День28_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День29_vmoЗаправки
            // 
            this.День29_vmoЗаправки.CalcTotal = false;
            this.День29_vmoЗаправки.Caption = "29";
            this.День29_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День29_vmoЗаправки.Name = "29";
            this.День29_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День29_vmoЗаправки.PropertyType = typeof(decimal);
            this.День29_vmoЗаправки.SearchCondition.OwnerComponent = this.День29_vmoЗаправки;
            this.День29_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День30_vmoЗаправки
            // 
            this.День30_vmoЗаправки.CalcTotal = false;
            this.День30_vmoЗаправки.Caption = "30";
            this.День30_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День30_vmoЗаправки.Name = "30";
            this.День30_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День30_vmoЗаправки.PropertyType = typeof(decimal);
            this.День30_vmoЗаправки.SearchCondition.OwnerComponent = this.День30_vmoЗаправки;
            this.День30_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День31_vmoЗаправки
            // 
            this.День31_vmoЗаправки.CalcTotal = false;
            this.День31_vmoЗаправки.Caption = "31";
            this.День31_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День31_vmoЗаправки.Name = "31";
            this.День31_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День31_vmoЗаправки.PropertyType = typeof(decimal);
            this.День31_vmoЗаправки.SearchCondition.OwnerComponent = this.День31_vmoЗаправки;
            this.День31_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Время_vmoЗаправки
            // 
            this.Время_vmoЗаправки.Caption = "Время";
            this.Время_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Время_vmoЗаправки.Name = "Время";
            this.Время_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Время_vmoЗаправки.PropertyType = typeof(System.DateTime);
            this.Время_vmoЗаправки.SearchCondition.OwnerComponent = this.Время_vmoЗаправки;
            this.Время_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяСтрока_vmoЗаправки
            // 
            this.ВремяСтрока_vmoЗаправки.Caption = "ВремяСтрока";
            this.ВремяСтрока_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяСтрока_vmoЗаправки.Name = "ВремяСтрока";
            this.ВремяСтрока_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ВремяСтрока_vmoЗаправки.PropertyType = typeof(string);
            this.ВремяСтрока_vmoЗаправки.SearchCondition.OwnerComponent = this.ВремяСтрока_vmoЗаправки;
            this.ВремяСтрока_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтоимостьЗаЛитр_vmoЗаправки
            // 
            this.СтоимостьЗаЛитр_vmoЗаправки.CalcTotal = false;
            this.СтоимостьЗаЛитр_vmoЗаправки.Caption = "СтоимостьЗаЛитр";
            this.СтоимостьЗаЛитр_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтоимостьЗаЛитр_vmoЗаправки.Name = "СтоимостьЗаЛитр";
            this.СтоимостьЗаЛитр_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.СтоимостьЗаЛитр_vmoЗаправки.PropertyType = typeof(decimal);
            this.СтоимостьЗаЛитр_vmoЗаправки.SearchCondition.OwnerComponent = this.СтоимостьЗаЛитр_vmoЗаправки;
            this.СтоимостьЗаЛитр_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоЛ_vmoЗаправки
            // 
            this.ИтогоЛ_vmoЗаправки.CalcTotal = false;
            this.ИтогоЛ_vmoЗаправки.Caption = "ИтогоЛ";
            this.ИтогоЛ_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоЛ_vmoЗаправки.Name = "ИтогоЛ";
            this.ИтогоЛ_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоЛ_vmoЗаправки.PropertyType = typeof(decimal);
            this.ИтогоЛ_vmoЗаправки.SearchCondition.OwnerComponent = this.ИтогоЛ_vmoЗаправки;
            this.ИтогоЛ_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоРуб_vmoЗаправки
            // 
            this.ИтогоРуб_vmoЗаправки.CalcTotal = false;
            this.ИтогоРуб_vmoЗаправки.Caption = "ИтогоРуб";
            this.ИтогоРуб_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоРуб_vmoЗаправки.Name = "ИтогоРуб";
            this.ИтогоРуб_vmoЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоРуб_vmoЗаправки.PropertyType = typeof(decimal);
            this.ИтогоРуб_vmoЗаправки.SearchCondition.OwnerComponent = this.ИтогоРуб_vmoЗаправки;
            this.ИтогоРуб_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик_vmoЗаправки
            // 
            this.Заказчик_vmoЗаправки.Caption = "Заказчик";
            this.Заказчик_vmoЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Заказчик_vmoЗаправки.Name = "Заказчик";
            this.Заказчик_vmoЗаправки.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_vmoЗаправки.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_vmoЗаправки.SearchCondition.OwnerComponent = this.Заказчик_vmoЗаправки;
            this.Заказчик_vmoЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource12
            // 
            this.stiReportDataSource12.Item = this.rdsЗаправки;
            this.stiReportDataSource12.Name = "rdsЗаправки";
            // 
            // nsgReport2
            // 
            this.nsgReport2.CurrentProgressValue = 0;
            this.nsgReport2.HighlightedComponent = null;
            this.nsgReport2.IsSyncMode = true;
            this.nsgReport2.MaxProgressValue = 100;
            this.nsgReport2.OwnerForm = null;
            this.nsgReport2.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport2.ProgressObject = null;
            this.nsgReport2.ProgressProcentage = 0;
            this.nsgReport2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "TechControl.exe",
        "TechControl",
        "NsgSoft.Common.dll",
        "NsgSoft.DataObjects.dll",
        "NsgSoft.Design.dll",
        "NsgSoft.Windows.iGridLib.iGrid.dll",
        "NsgSoft.Database.dll",
        "NsgSoft.ReportCompression.dll",
        "NsgSoft.Database.FireBird.dll",
        "NsgSoft.Forms.dll",
        "WeifenLuo.WinFormsUI.Docking.dll",
        "NsgSoft.ReportBuilder.dll",
        "NsgSoft.ReportBase.dll",
        "NsgSoft.ReportControls.dll",
        "NsgSoft.ReportEditor.dll"};
            this.nsgReport2.ReportAlias = "Отчет_по_заправкам___22_59";
            this.nsgReport2.ReportDataSources.Add(this.stiReportDataSource5);
            this.nsgReport2.ReportDataSources.Add(this.stiReportDataSource6);
            this.nsgReport2.ReportDataSources.Add(this.stiReportDataSource7);
            this.nsgReport2.ReportDataSources.Add(this.stiReportDataSource8);
            this.nsgReport2.ReportDataSources.Add(this.stiReportDataSource13);
            this.nsgReport2.ReportGuid = "675404236d9543c88e385080b4385f9d";
            this.nsgReport2.ReportLoaded = true;
            this.nsgReport2.ReportName = "Отчет_по_заправкам___22_59";
            this.nsgReport2.ReportSource = resources.GetString("nsgReport2.ReportSource");
            this.nsgReport2.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport2.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport2.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource5
            // 
            this.stiReportDataSource5.Item = this.nsgReportDataSource;
            this.stiReportDataSource5.Name = "nsgReportDataSource";
            // 
            // stiReportDataSource6
            // 
            this.stiReportDataSource6.Item = this.rdsФильтр;
            this.stiReportDataSource6.Name = "rdsФильтр";
            // 
            // stiReportDataSource7
            // 
            this.stiReportDataSource7.Item = this.rdsШапка;
            this.stiReportDataSource7.Name = "rdsШапка";
            // 
            // stiReportDataSource8
            // 
            this.stiReportDataSource8.Item = this.rdsЗаправки;
            this.stiReportDataSource8.Name = "rdsЗаправки";
            // 
            // rdsЗаправки1
            // 
            this.rdsЗаправки1.MasterComponent = this.vmoЗаправки1;
            this.rdsЗаправки1.Name = "rdsЗаправки1";
            // 
            // vmoЗаправки1
            // 
            this.vmoЗаправки1.Columns.Collection.Add(this.Поставщик_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.Заказчик_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.Объект_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.ГосНомер_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.Время_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.ВремяСтрока_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День1_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День2_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День3_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День4_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День5_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День6_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День7_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День8_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День9_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День10_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День11_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День12_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День13_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День14_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День15_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День16_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День17_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День18_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День19_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День20_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День21_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День22_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День23_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День24_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День25_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День26_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День27_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День28_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День29_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День30_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.День31_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.СтоимостьЗаЛитр_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.ИтогоЛ_з1);
            this.vmoЗаправки1.Columns.Collection.Add(this.ИтогоРуб_з1);
            this.vmoЗаправки1.IsActive = true;
            this.vmoЗаправки1.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoЗаправки1.MetaDataName = "";
            this.vmoЗаправки1.FullName = "";
            // 
            // Поставщик_з1
            // 
            this.Поставщик_з1.Caption = "Поставщик";
            this.Поставщик_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Поставщик_з1.Name = "Поставщик";
            this.Поставщик_з1.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_з1.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_з1.SearchCondition.OwnerComponent = this.Поставщик_з1;
            this.Поставщик_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик_з1
            // 
            this.Заказчик_з1.Caption = "Заказчик";
            this.Заказчик_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Заказчик_з1.Name = "Заказчик";
            this.Заказчик_з1.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_з1.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_з1.SearchCondition.OwnerComponent = this.Заказчик_з1;
            this.Заказчик_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_з1
            // 
            this.Объект_з1.Caption = "Объект";
            this.Объект_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_з1.Name = "Объект";
            this.Объект_з1.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_з1.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_з1.SearchCondition.OwnerComponent = this.Объект_з1;
            this.Объект_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГосНомер_з1
            // 
            this.ГосНомер_з1.Caption = "ГосНомер";
            this.ГосНомер_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГосНомер_з1.Name = "ГосНомер";
            this.ГосНомер_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГосНомер_з1.PropertyType = typeof(string);
            this.ГосНомер_з1.SearchCondition.OwnerComponent = this.ГосНомер_з1;
            this.ГосНомер_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Время_з1
            // 
            this.Время_з1.Caption = "Время";
            this.Время_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Время_з1.Name = "Время";
            this.Время_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Время_з1.PropertyType = typeof(System.DateTime);
            this.Время_з1.SearchCondition.OwnerComponent = this.Время_з1;
            this.Время_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяСтрока_з1
            // 
            this.ВремяСтрока_з1.Caption = "ВремяСтрока";
            this.ВремяСтрока_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяСтрока_з1.Name = "ВремяСтрока";
            this.ВремяСтрока_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ВремяСтрока_з1.PropertyType = typeof(string);
            this.ВремяСтрока_з1.SearchCondition.OwnerComponent = this.ВремяСтрока_з1;
            this.ВремяСтрока_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День1_з1
            // 
            this.День1_з1.CalcTotal = false;
            this.День1_з1.Caption = "День1";
            this.День1_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День1_з1.Name = "День1";
            this.День1_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День1_з1.PropertyType = typeof(decimal);
            this.День1_з1.SearchCondition.OwnerComponent = this.День1_з1;
            this.День1_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День2_з1
            // 
            this.День2_з1.CalcTotal = false;
            this.День2_з1.Caption = "День2";
            this.День2_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День2_з1.Name = "День2";
            this.День2_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День2_з1.PropertyType = typeof(decimal);
            this.День2_з1.SearchCondition.OwnerComponent = this.День2_з1;
            this.День2_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День3_з1
            // 
            this.День3_з1.CalcTotal = false;
            this.День3_з1.Caption = "День3";
            this.День3_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День3_з1.Name = "День3";
            this.День3_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День3_з1.PropertyType = typeof(decimal);
            this.День3_з1.SearchCondition.OwnerComponent = this.День3_з1;
            this.День3_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День4_з1
            // 
            this.День4_з1.CalcTotal = false;
            this.День4_з1.Caption = "День4";
            this.День4_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День4_з1.Name = "День4";
            this.День4_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День4_з1.PropertyType = typeof(decimal);
            this.День4_з1.SearchCondition.OwnerComponent = this.День4_з1;
            this.День4_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День5_з1
            // 
            this.День5_з1.CalcTotal = false;
            this.День5_з1.Caption = "День5";
            this.День5_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День5_з1.Name = "День5";
            this.День5_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День5_з1.PropertyType = typeof(decimal);
            this.День5_з1.SearchCondition.OwnerComponent = this.День5_з1;
            this.День5_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День6_з1
            // 
            this.День6_з1.CalcTotal = false;
            this.День6_з1.Caption = "День6";
            this.День6_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День6_з1.Name = "День6";
            this.День6_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День6_з1.PropertyType = typeof(decimal);
            this.День6_з1.SearchCondition.OwnerComponent = this.День6_з1;
            this.День6_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День7_з1
            // 
            this.День7_з1.CalcTotal = false;
            this.День7_з1.Caption = "День7";
            this.День7_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День7_з1.Name = "День7";
            this.День7_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День7_з1.PropertyType = typeof(decimal);
            this.День7_з1.SearchCondition.OwnerComponent = this.День7_з1;
            this.День7_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День8_з1
            // 
            this.День8_з1.CalcTotal = false;
            this.День8_з1.Caption = "День8";
            this.День8_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День8_з1.Name = "День8";
            this.День8_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День8_з1.PropertyType = typeof(decimal);
            this.День8_з1.SearchCondition.OwnerComponent = this.День8_з1;
            this.День8_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День9_з1
            // 
            this.День9_з1.CalcTotal = false;
            this.День9_з1.Caption = "День9";
            this.День9_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День9_з1.Name = "День9";
            this.День9_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День9_з1.PropertyType = typeof(decimal);
            this.День9_з1.SearchCondition.OwnerComponent = this.День9_з1;
            this.День9_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День10_з1
            // 
            this.День10_з1.CalcTotal = false;
            this.День10_з1.Caption = "День10";
            this.День10_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День10_з1.Name = "День10";
            this.День10_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День10_з1.PropertyType = typeof(decimal);
            this.День10_з1.SearchCondition.OwnerComponent = this.День10_з1;
            this.День10_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День11_з1
            // 
            this.День11_з1.CalcTotal = false;
            this.День11_з1.Caption = "День11";
            this.День11_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День11_з1.Name = "День11";
            this.День11_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День11_з1.PropertyType = typeof(decimal);
            this.День11_з1.SearchCondition.OwnerComponent = this.День11_з1;
            this.День11_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День12_з1
            // 
            this.День12_з1.CalcTotal = false;
            this.День12_з1.Caption = "День12";
            this.День12_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День12_з1.Name = "День12";
            this.День12_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День12_з1.PropertyType = typeof(decimal);
            this.День12_з1.SearchCondition.OwnerComponent = this.День12_з1;
            this.День12_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День13_з1
            // 
            this.День13_з1.CalcTotal = false;
            this.День13_з1.Caption = "День13";
            this.День13_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День13_з1.Name = "День13";
            this.День13_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День13_з1.PropertyType = typeof(decimal);
            this.День13_з1.SearchCondition.OwnerComponent = this.День13_з1;
            this.День13_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День14_з1
            // 
            this.День14_з1.CalcTotal = false;
            this.День14_з1.Caption = "День14";
            this.День14_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День14_з1.Name = "День14";
            this.День14_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День14_з1.PropertyType = typeof(decimal);
            this.День14_з1.SearchCondition.OwnerComponent = this.День14_з1;
            this.День14_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День15_з1
            // 
            this.День15_з1.CalcTotal = false;
            this.День15_з1.Caption = "День15";
            this.День15_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День15_з1.Name = "День15";
            this.День15_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День15_з1.PropertyType = typeof(decimal);
            this.День15_з1.SearchCondition.OwnerComponent = this.День15_з1;
            this.День15_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День16_з1
            // 
            this.День16_з1.CalcTotal = false;
            this.День16_з1.Caption = "День16";
            this.День16_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День16_з1.Name = "День16";
            this.День16_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День16_з1.PropertyType = typeof(decimal);
            this.День16_з1.SearchCondition.OwnerComponent = this.День16_з1;
            this.День16_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День17_з1
            // 
            this.День17_з1.CalcTotal = false;
            this.День17_з1.Caption = "День17";
            this.День17_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День17_з1.Name = "День17";
            this.День17_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День17_з1.PropertyType = typeof(decimal);
            this.День17_з1.SearchCondition.OwnerComponent = this.День17_з1;
            this.День17_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День18_з1
            // 
            this.День18_з1.CalcTotal = false;
            this.День18_з1.Caption = "День18";
            this.День18_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День18_з1.Name = "День18";
            this.День18_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День18_з1.PropertyType = typeof(decimal);
            this.День18_з1.SearchCondition.OwnerComponent = this.День18_з1;
            this.День18_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День19_з1
            // 
            this.День19_з1.CalcTotal = false;
            this.День19_з1.Caption = "День19";
            this.День19_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День19_з1.Name = "День19";
            this.День19_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День19_з1.PropertyType = typeof(decimal);
            this.День19_з1.SearchCondition.OwnerComponent = this.День19_з1;
            this.День19_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День20_з1
            // 
            this.День20_з1.CalcTotal = false;
            this.День20_з1.Caption = "День20";
            this.День20_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День20_з1.Name = "День20";
            this.День20_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День20_з1.PropertyType = typeof(decimal);
            this.День20_з1.SearchCondition.OwnerComponent = this.День20_з1;
            this.День20_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День21_з1
            // 
            this.День21_з1.CalcTotal = false;
            this.День21_з1.Caption = "День21";
            this.День21_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День21_з1.Name = "День21";
            this.День21_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День21_з1.PropertyType = typeof(decimal);
            this.День21_з1.SearchCondition.OwnerComponent = this.День21_з1;
            this.День21_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День22_з1
            // 
            this.День22_з1.CalcTotal = false;
            this.День22_з1.Caption = "День22";
            this.День22_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День22_з1.Name = "День22";
            this.День22_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День22_з1.PropertyType = typeof(decimal);
            this.День22_з1.SearchCondition.OwnerComponent = this.День22_з1;
            this.День22_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День23_з1
            // 
            this.День23_з1.CalcTotal = false;
            this.День23_з1.Caption = "День23";
            this.День23_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День23_з1.Name = "День23";
            this.День23_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День23_з1.PropertyType = typeof(decimal);
            this.День23_з1.SearchCondition.OwnerComponent = this.День23_з1;
            this.День23_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День24_з1
            // 
            this.День24_з1.CalcTotal = false;
            this.День24_з1.Caption = "День24";
            this.День24_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День24_з1.Name = "День24";
            this.День24_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День24_з1.PropertyType = typeof(decimal);
            this.День24_з1.SearchCondition.OwnerComponent = this.День24_з1;
            this.День24_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День25_з1
            // 
            this.День25_з1.CalcTotal = false;
            this.День25_з1.Caption = "День25";
            this.День25_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День25_з1.Name = "День25";
            this.День25_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День25_з1.PropertyType = typeof(decimal);
            this.День25_з1.SearchCondition.OwnerComponent = this.День25_з1;
            this.День25_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День26_з1
            // 
            this.День26_з1.CalcTotal = false;
            this.День26_з1.Caption = "День26";
            this.День26_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День26_з1.Name = "День26";
            this.День26_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День26_з1.PropertyType = typeof(decimal);
            this.День26_з1.SearchCondition.OwnerComponent = this.День26_з1;
            this.День26_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День27_з1
            // 
            this.День27_з1.CalcTotal = false;
            this.День27_з1.Caption = "День27";
            this.День27_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День27_з1.Name = "День27";
            this.День27_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День27_з1.PropertyType = typeof(decimal);
            this.День27_з1.SearchCondition.OwnerComponent = this.День27_з1;
            this.День27_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День28_з1
            // 
            this.День28_з1.CalcTotal = false;
            this.День28_з1.Caption = "День28";
            this.День28_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День28_з1.Name = "День28";
            this.День28_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День28_з1.PropertyType = typeof(decimal);
            this.День28_з1.SearchCondition.OwnerComponent = this.День28_з1;
            this.День28_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День29_з1
            // 
            this.День29_з1.CalcTotal = false;
            this.День29_з1.Caption = "День29";
            this.День29_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День29_з1.Name = "День29";
            this.День29_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День29_з1.PropertyType = typeof(decimal);
            this.День29_з1.SearchCondition.OwnerComponent = this.День29_з1;
            this.День29_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День30_з1
            // 
            this.День30_з1.CalcTotal = false;
            this.День30_з1.Caption = "День30";
            this.День30_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День30_з1.Name = "День30";
            this.День30_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День30_з1.PropertyType = typeof(decimal);
            this.День30_з1.SearchCondition.OwnerComponent = this.День30_з1;
            this.День30_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День31_з1
            // 
            this.День31_з1.CalcTotal = false;
            this.День31_з1.Caption = "День31";
            this.День31_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День31_з1.Name = "День31";
            this.День31_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День31_з1.PropertyType = typeof(decimal);
            this.День31_з1.SearchCondition.OwnerComponent = this.День31_з1;
            this.День31_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтоимостьЗаЛитр_з1
            // 
            this.СтоимостьЗаЛитр_з1.CalcTotal = false;
            this.СтоимостьЗаЛитр_з1.Caption = "СтоимостьЗаЛитр";
            this.СтоимостьЗаЛитр_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтоимостьЗаЛитр_з1.Name = "СтоимостьЗаЛитр";
            this.СтоимостьЗаЛитр_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.СтоимостьЗаЛитр_з1.PropertyType = typeof(decimal);
            this.СтоимостьЗаЛитр_з1.SearchCondition.OwnerComponent = this.СтоимостьЗаЛитр_з1;
            this.СтоимостьЗаЛитр_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоЛ_з1
            // 
            this.ИтогоЛ_з1.CalcTotal = false;
            this.ИтогоЛ_з1.Caption = "ИтогоЛ";
            this.ИтогоЛ_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоЛ_з1.Name = "ИтогоЛ";
            this.ИтогоЛ_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоЛ_з1.PropertyType = typeof(decimal);
            this.ИтогоЛ_з1.SearchCondition.OwnerComponent = this.ИтогоЛ_з1;
            this.ИтогоЛ_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоРуб_з1
            // 
            this.ИтогоРуб_з1.CalcTotal = false;
            this.ИтогоРуб_з1.Caption = "ИтогоРуб";
            this.ИтогоРуб_з1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоРуб_з1.Name = "ИтогоРуб";
            this.ИтогоРуб_з1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоРуб_з1.PropertyType = typeof(decimal);
            this.ИтогоРуб_з1.SearchCondition.OwnerComponent = this.ИтогоРуб_з1;
            this.ИтогоРуб_з1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource13
            // 
            this.stiReportDataSource13.Item = this.rdsЗаправки1;
            this.stiReportDataSource13.Name = "rdsЗаправки1";
            // 
            // nsgReport1
            // 
            this.nsgReport1.CurrentProgressValue = 0;
            this.nsgReport1.HighlightedComponent = null;
            this.nsgReport1.IsSyncMode = true;
            this.nsgReport1.MaxProgressValue = 100;
            this.nsgReport1.OwnerForm = null;
            this.nsgReport1.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport1.ProgressObject = null;
            this.nsgReport1.ProgressProcentage = 0;
            this.nsgReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "NsgSoft.CityGuide.Dll"};
            this.nsgReport1.ReportAlias = "Отчет";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource3);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource4);
            this.nsgReport1.ReportGuid = "1e8e35902d1a491d8a99bcb98cb935c9";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.nsgReportDataSource;
            this.stiReportDataSource1.Name = "nsgReportDataSource";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsФильтр;
            this.stiReportDataSource2.Name = "rdsФильтр";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.rdsШапка;
            this.stiReportDataSource3.Name = "rdsШапка";
            // 
            // stiReportDataSource4
            // 
            this.stiReportDataSource4.Item = this.rdsЗаправки;
            this.stiReportDataSource4.Name = "rdsЗаправки";
            // 
            // Техника_
            // 
            this.Техника_.Caption = "Техника";
            this.Техника_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_.Name = "Техника";
            this.Техника_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_.SearchCondition.OwnerComponent = this.Техника_;
            this.Техника_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Поставщик_
            // 
            this.Поставщик_.Caption = "Поставщик";
            this.Поставщик_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Поставщик_.Name = "Поставщик";
            this.Поставщик_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Поставщик_.SearchCondition.OwnerComponent = this.Поставщик_;
            this.Поставщик_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_
            // 
            this.Объект_.Caption = "Объект";
            this.Объект_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_.Name = "Объект";
            this.Объект_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_.SearchCondition.OwnerComponent = this.Объект_;
            this.Объект_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГосНомер_
            // 
            this.ГосНомер_.Caption = "ГосНомер";
            this.ГосНомер_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГосНомер_.Name = "ГосНомер";
            this.ГосНомер_.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГосНомер_.PropertyType = typeof(string);
            this.ГосНомер_.SearchCondition.OwnerComponent = this.ГосНомер_;
            this.ГосНомер_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День1_
            // 
            this.День1_.CalcTotal = false;
            this.День1_.Caption = "1";
            this.День1_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День1_.Name = "1";
            this.День1_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День1_.PropertyType = typeof(decimal);
            this.День1_.SearchCondition.OwnerComponent = this.День1_;
            this.День1_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День2_
            // 
            this.День2_.CalcTotal = false;
            this.День2_.Caption = "2";
            this.День2_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День2_.Name = "2";
            this.День2_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День2_.PropertyType = typeof(decimal);
            this.День2_.SearchCondition.OwnerComponent = this.День2_;
            this.День2_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День3_
            // 
            this.День3_.CalcTotal = false;
            this.День3_.Caption = "3";
            this.День3_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День3_.Name = "3";
            this.День3_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День3_.PropertyType = typeof(decimal);
            this.День3_.SearchCondition.OwnerComponent = this.День3_;
            this.День3_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День4_
            // 
            this.День4_.CalcTotal = false;
            this.День4_.Caption = "4";
            this.День4_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День4_.Name = "4";
            this.День4_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День4_.PropertyType = typeof(decimal);
            this.День4_.SearchCondition.OwnerComponent = this.День4_;
            this.День4_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День5_
            // 
            this.День5_.CalcTotal = false;
            this.День5_.Caption = "5";
            this.День5_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День5_.Name = "5";
            this.День5_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День5_.PropertyType = typeof(decimal);
            this.День5_.SearchCondition.OwnerComponent = this.День5_;
            this.День5_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День6_
            // 
            this.День6_.CalcTotal = false;
            this.День6_.Caption = "6";
            this.День6_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День6_.Name = "6";
            this.День6_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День6_.PropertyType = typeof(decimal);
            this.День6_.SearchCondition.OwnerComponent = this.День6_;
            this.День6_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День7_
            // 
            this.День7_.CalcTotal = false;
            this.День7_.Caption = "7";
            this.День7_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День7_.Name = "7";
            this.День7_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День7_.PropertyType = typeof(decimal);
            this.День7_.SearchCondition.OwnerComponent = this.День7_;
            this.День7_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День8_
            // 
            this.День8_.CalcTotal = false;
            this.День8_.Caption = "8";
            this.День8_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День8_.Name = "8";
            this.День8_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День8_.PropertyType = typeof(decimal);
            this.День8_.SearchCondition.OwnerComponent = this.День8_;
            this.День8_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День9_
            // 
            this.День9_.CalcTotal = false;
            this.День9_.Caption = "9";
            this.День9_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День9_.Name = "9";
            this.День9_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День9_.PropertyType = typeof(decimal);
            this.День9_.SearchCondition.OwnerComponent = this.День9_;
            this.День9_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День10_
            // 
            this.День10_.CalcTotal = false;
            this.День10_.Caption = "10";
            this.День10_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День10_.Name = "10";
            this.День10_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День10_.PropertyType = typeof(decimal);
            this.День10_.SearchCondition.OwnerComponent = this.День10_;
            this.День10_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День11_
            // 
            this.День11_.CalcTotal = false;
            this.День11_.Caption = "11";
            this.День11_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День11_.Name = "11";
            this.День11_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День11_.PropertyType = typeof(decimal);
            this.День11_.SearchCondition.OwnerComponent = this.День11_;
            this.День11_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День12_
            // 
            this.День12_.CalcTotal = false;
            this.День12_.Caption = "12";
            this.День12_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День12_.Name = "12";
            this.День12_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День12_.PropertyType = typeof(decimal);
            this.День12_.SearchCondition.OwnerComponent = this.День12_;
            this.День12_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День13_
            // 
            this.День13_.CalcTotal = false;
            this.День13_.Caption = "13";
            this.День13_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День13_.Name = "13";
            this.День13_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День13_.PropertyType = typeof(decimal);
            this.День13_.SearchCondition.OwnerComponent = this.День13_;
            this.День13_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День14_
            // 
            this.День14_.CalcTotal = false;
            this.День14_.Caption = "14";
            this.День14_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День14_.Name = "14";
            this.День14_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День14_.PropertyType = typeof(decimal);
            this.День14_.SearchCondition.OwnerComponent = this.День14_;
            this.День14_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День15_
            // 
            this.День15_.CalcTotal = false;
            this.День15_.Caption = "15";
            this.День15_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День15_.Name = "15";
            this.День15_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День15_.PropertyType = typeof(decimal);
            this.День15_.SearchCondition.OwnerComponent = this.День15_;
            this.День15_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День16_
            // 
            this.День16_.CalcTotal = false;
            this.День16_.Caption = "16";
            this.День16_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День16_.Name = "16";
            this.День16_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День16_.PropertyType = typeof(decimal);
            this.День16_.SearchCondition.OwnerComponent = this.День16_;
            this.День16_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День17_
            // 
            this.День17_.CalcTotal = false;
            this.День17_.Caption = "17";
            this.День17_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День17_.Name = "17";
            this.День17_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День17_.PropertyType = typeof(decimal);
            this.День17_.SearchCondition.OwnerComponent = this.День17_;
            this.День17_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День18_
            // 
            this.День18_.CalcTotal = false;
            this.День18_.Caption = "18";
            this.День18_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День18_.Name = "18";
            this.День18_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День18_.PropertyType = typeof(decimal);
            this.День18_.SearchCondition.OwnerComponent = this.День18_;
            this.День18_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День19_
            // 
            this.День19_.CalcTotal = false;
            this.День19_.Caption = "19";
            this.День19_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День19_.Name = "19";
            this.День19_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День19_.PropertyType = typeof(decimal);
            this.День19_.SearchCondition.OwnerComponent = this.День19_;
            this.День19_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День20_
            // 
            this.День20_.CalcTotal = false;
            this.День20_.Caption = "20";
            this.День20_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День20_.Name = "20";
            this.День20_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День20_.PropertyType = typeof(decimal);
            this.День20_.SearchCondition.OwnerComponent = this.День20_;
            this.День20_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День21_
            // 
            this.День21_.CalcTotal = false;
            this.День21_.Caption = "21";
            this.День21_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День21_.Name = "21";
            this.День21_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День21_.PropertyType = typeof(decimal);
            this.День21_.SearchCondition.OwnerComponent = this.День21_;
            this.День21_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День22_
            // 
            this.День22_.CalcTotal = false;
            this.День22_.Caption = "22";
            this.День22_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День22_.Name = "22";
            this.День22_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День22_.PropertyType = typeof(decimal);
            this.День22_.SearchCondition.OwnerComponent = this.День22_;
            this.День22_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День23_
            // 
            this.День23_.CalcTotal = false;
            this.День23_.Caption = "23";
            this.День23_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День23_.Name = "23";
            this.День23_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День23_.PropertyType = typeof(decimal);
            this.День23_.SearchCondition.OwnerComponent = this.День23_;
            this.День23_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День24_
            // 
            this.День24_.CalcTotal = false;
            this.День24_.Caption = "24";
            this.День24_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День24_.Name = "24";
            this.День24_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День24_.PropertyType = typeof(decimal);
            this.День24_.SearchCondition.OwnerComponent = this.День24_;
            this.День24_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День25_
            // 
            this.День25_.CalcTotal = false;
            this.День25_.Caption = "25";
            this.День25_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День25_.Name = "25";
            this.День25_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День25_.PropertyType = typeof(decimal);
            this.День25_.SearchCondition.OwnerComponent = this.День25_;
            this.День25_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День26_
            // 
            this.День26_.CalcTotal = false;
            this.День26_.Caption = "26";
            this.День26_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День26_.Name = "26";
            this.День26_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День26_.PropertyType = typeof(decimal);
            this.День26_.SearchCondition.OwnerComponent = this.День26_;
            this.День26_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День27_
            // 
            this.День27_.CalcTotal = false;
            this.День27_.Caption = "27";
            this.День27_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День27_.Name = "27";
            this.День27_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День27_.PropertyType = typeof(decimal);
            this.День27_.SearchCondition.OwnerComponent = this.День27_;
            this.День27_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День28_
            // 
            this.День28_.CalcTotal = false;
            this.День28_.Caption = "28";
            this.День28_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День28_.Name = "28";
            this.День28_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День28_.PropertyType = typeof(decimal);
            this.День28_.SearchCondition.OwnerComponent = this.День28_;
            this.День28_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День29_
            // 
            this.День29_.CalcTotal = false;
            this.День29_.Caption = "29";
            this.День29_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День29_.Name = "29";
            this.День29_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День29_.PropertyType = typeof(decimal);
            this.День29_.SearchCondition.OwnerComponent = this.День29_;
            this.День29_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День30_
            // 
            this.День30_.CalcTotal = false;
            this.День30_.Caption = "30";
            this.День30_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День30_.Name = "30";
            this.День30_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День30_.PropertyType = typeof(decimal);
            this.День30_.SearchCondition.OwnerComponent = this.День30_;
            this.День30_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // День31_
            // 
            this.День31_.CalcTotal = false;
            this.День31_.Caption = "31";
            this.День31_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.День31_.Name = "31";
            this.День31_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.День31_.PropertyType = typeof(decimal);
            this.День31_.SearchCondition.OwnerComponent = this.День31_;
            this.День31_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Итого_
            // 
            this.Итого_.CalcTotal = false;
            this.Итого_.Caption = "Итого";
            this.Итого_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Итого_.Name = "Итого";
            this.Итого_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Итого_.PropertyType = typeof(decimal);
            this.Итого_.SearchCondition.OwnerComponent = this.Итого_;
            this.Итого_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Время_
            // 
            this.Время_.Caption = "Время";
            this.Время_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Время_.Name = "Время";
            this.Время_.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Время_.PropertyType = typeof(System.DateTime);
            this.Время_.SearchCondition.OwnerComponent = this.Время_;
            this.Время_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяСтрока_
            // 
            this.ВремяСтрока_.Caption = "ВремяСтрока";
            this.ВремяСтрока_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяСтрока_.Name = "ВремяСтрока";
            this.ВремяСтрока_.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ВремяСтрока_.PropertyType = typeof(string);
            this.ВремяСтрока_.SearchCondition.OwnerComponent = this.ВремяСтрока_;
            this.ВремяСтрока_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик_
            // 
            this.Заказчик_.Caption = "Заказчик";
            this.Заказчик_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Заказчик_.Name = "Заказчик";
            this.Заказчик_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_.SearchCondition.OwnerComponent = this.Заказчик_;
            this.Заказчик_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоСлив_
            // 
            this.ИтогоСлив_.CalcTotal = false;
            this.ИтогоСлив_.Caption = "ИтогоСлив";
            this.ИтогоСлив_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоСлив_.Name = "ИтогоСлив";
            this.ИтогоСлив_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоСлив_.PropertyType = typeof(decimal);
            this.ИтогоСлив_.SearchCondition.OwnerComponent = this.ИтогоСлив_;
            this.ИтогоСлив_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоЗаправка_
            // 
            this.ИтогоЗаправка_.CalcTotal = false;
            this.ИтогоЗаправка_.Caption = "ИтогоЗаправка";
            this.ИтогоЗаправка_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоЗаправка_.Name = "ИтогоЗаправка";
            this.ИтогоЗаправка_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоЗаправка_.PropertyType = typeof(decimal);
            this.ИтогоЗаправка_.SearchCondition.OwnerComponent = this.ИтогоЗаправка_;
            this.ИтогоЗаправка_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтчетПоЗаправкамФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(984, 446);
            this.Controls.Add(this.nsgPeriodPicker);
            this.Controls.Add(this.nsgGroupsList);
            this.Controls.Add(this.nsgObjectFilter);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = this.nsgReport3;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgObjectFilter, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoШапка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsЗаправки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаправки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsЗаправки1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаправки1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected NsgPeriodPicker nsgPeriodPicker;
        protected Техника.ColumnDescriptor Техника_;
        protected Контрагенты.ColumnDescriptor Поставщик_;
        protected Объекты.ColumnDescriptor Объект_;
        protected NsgColumnDescriptor.String ГосНомер_;
        protected NsgColumnDescriptor.Decimal День1_;
        protected NsgColumnDescriptor.Decimal День2_;
        protected NsgColumnDescriptor.Decimal День3_;
        protected NsgColumnDescriptor.Decimal День4_;
        protected NsgColumnDescriptor.Decimal День5_;
        protected NsgColumnDescriptor.Decimal День6_;
        protected NsgColumnDescriptor.Decimal День7_;
        protected NsgColumnDescriptor.Decimal День8_;
        protected NsgColumnDescriptor.Decimal День9_;
        protected NsgColumnDescriptor.Decimal День10_;
        protected NsgColumnDescriptor.Decimal День11_;
        protected NsgColumnDescriptor.Decimal День12_;
        protected NsgColumnDescriptor.Decimal День13_;
        protected NsgColumnDescriptor.Decimal День14_;
        protected NsgColumnDescriptor.Decimal День15_;
        protected NsgColumnDescriptor.Decimal День16_;
        protected NsgColumnDescriptor.Decimal День17_;
        protected NsgColumnDescriptor.Decimal День18_;
        protected NsgColumnDescriptor.Decimal День19_;
        protected NsgColumnDescriptor.Decimal День20_;
        protected NsgColumnDescriptor.Decimal День21_;
        protected NsgColumnDescriptor.Decimal День22_;
        protected NsgColumnDescriptor.Decimal День23_;
        protected NsgColumnDescriptor.Decimal День24_;
        protected NsgColumnDescriptor.Decimal День25_;
        protected NsgColumnDescriptor.Decimal День26_;
        protected NsgColumnDescriptor.Decimal День27_;
        protected NsgColumnDescriptor.Decimal День28_;
        protected NsgColumnDescriptor.Decimal День29_;
        protected NsgColumnDescriptor.Decimal День30_;
        protected NsgColumnDescriptor.Decimal День31_;
        protected NsgColumnDescriptor.Decimal Итого_;
        protected NsgColumnDescriptor.DateTime Время_;
        protected NsgColumnDescriptor.String ВремяСтрока_;
        protected Техника.ColumnDescriptor Техника_ф;
        protected Контрагенты.ColumnDescriptor Поставщик_ф;
        protected Объекты.ColumnDescriptor Объект_ф;
        protected Контрагенты.ColumnDescriptor Поставщик_vmoЗаправки;
        protected NsgColumnDescriptor.String ГосНомер_vmoЗаправки;
        protected NsgColumnDescriptor.String ВремяСтрока_vmoЗаправки;
        protected Объекты.ColumnDescriptor Объект_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День1_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День2_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День3_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День4_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День5_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День6_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День7_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День8_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День9_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День10_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День11_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День12_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День13_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День14_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День15_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День16_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День17_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День18_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День19_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День20_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День21_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День22_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День23_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День24_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День25_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День26_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День27_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День28_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День29_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День30_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal День31_vmoЗаправки;
        protected NsgColumnDescriptor.DateTime Время_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal СтоимостьЗаЛитр_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal ИтогоЛ_vmoЗаправки;
        protected NsgColumnDescriptor.Decimal ИтогоРуб_vmoЗаправки;
        protected NsgColumnDescriptor.String ДатаСоставления;
        protected NsgColumnDescriptor.String НачалоПериода;
        protected NsgColumnDescriptor.String ОкончаниеПериода;
        protected NsgColumnDescriptor.String ИтогКостыль;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList;
        protected Контрагенты.ColumnDescriptor Заказчик_;
        protected Контрагенты.ColumnDescriptor Заказчик_vmoЗаправки;
        protected Контрагенты.ColumnDescriptor Поставщик_з1;
        protected Контрагенты.ColumnDescriptor Заказчик_з1;
        protected Объекты.ColumnDescriptor Объект_з1;
        protected NsgColumnDescriptor.String ГосНомер_з1;
        protected NsgColumnDescriptor.DateTime Время_з1;
        protected NsgColumnDescriptor.String ВремяСтрока_з1;
        protected NsgColumnDescriptor.Decimal День2_з1;
        protected NsgColumnDescriptor.Decimal День1_з1;
        protected NsgColumnDescriptor.Decimal День3_з1;
        protected NsgColumnDescriptor.Decimal День4_з1;
        protected NsgColumnDescriptor.Decimal День5_з1;
        protected NsgColumnDescriptor.Decimal День6_з1;
        protected NsgColumnDescriptor.Decimal День7_з1;
        protected NsgColumnDescriptor.Decimal День8_з1;
        protected NsgColumnDescriptor.Decimal День9_з1;
        protected NsgColumnDescriptor.Decimal День10_з1;
        protected NsgColumnDescriptor.Decimal День11_з1;
        protected NsgColumnDescriptor.Decimal День12_з1;
        protected NsgColumnDescriptor.Decimal День13_з1;
        protected NsgColumnDescriptor.Decimal День14_з1;
        protected NsgColumnDescriptor.Decimal День15_з1;
        protected NsgColumnDescriptor.Decimal День16_з1;
        protected NsgColumnDescriptor.Decimal День17_з1;
        protected NsgColumnDescriptor.Decimal День18_з1;
        protected NsgColumnDescriptor.Decimal День19_з1;
        protected NsgColumnDescriptor.Decimal День20_з1;
        protected NsgColumnDescriptor.Decimal День21_з1;
        protected NsgColumnDescriptor.Decimal День22_з1;
        protected NsgColumnDescriptor.Decimal День23_з1;
        protected NsgColumnDescriptor.Decimal День24_з1;
        protected NsgColumnDescriptor.Decimal День25_з1;
        protected NsgColumnDescriptor.Decimal День26_з1;
        protected NsgColumnDescriptor.Decimal День27_з1;
        protected NsgColumnDescriptor.Decimal День28_з1;
        protected NsgColumnDescriptor.Decimal День29_з1;
        protected NsgColumnDescriptor.Decimal День30_з1;
        protected NsgColumnDescriptor.Decimal День31_з1;
        protected NsgColumnDescriptor.Decimal СтоимостьЗаЛитр_з1;
        protected NsgColumnDescriptor.Decimal ИтогоЛ_з1;
        protected NsgColumnDescriptor.Decimal ИтогоРуб_з1;
        private NsgSoft.ReportBuilder.NsgReport nsgReport3;
        private NsgSoft.ReportBuilder.NsgReport nsgReport2;
        protected NsgColumnDescriptor.Decimal ИтогоСлив_;
        protected NsgColumnDescriptor.Decimal ИтогоЗаправка_;
        protected Контрагенты.ColumnDescriptor Заказчик_ф;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsШапка;
        private NsgSoft.ReportBuilder.NsgReportDataSource nsgReportDataSource;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsЗаправки1;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsФильтр;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource4;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource9;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource10;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource11;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource12;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource5;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource6;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource7;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource8;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource13;
        private NsgVisualMultipleObject vmoЗаправки1;
        private NsgVisualMultipleObject vmoШапка;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgVisualMultipleObject vmoЗаправки;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsЗаправки;
    }
}