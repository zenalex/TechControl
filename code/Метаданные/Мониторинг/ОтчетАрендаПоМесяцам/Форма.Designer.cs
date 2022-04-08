using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ОтчетАрендаПоМесяцамФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетАрендаПоМесяцамФорма));
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.rdsФильтр = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsФильтр", this.rdsФильтр);
            this.nsgReportDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource", this.nsgReportDataSource);
            this.rdsШапка = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoШапка = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsШапка", this.rdsШапка);
            this.rdsГруппы = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoГруппы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.Наименование_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ГНомер_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СтоимостьВЧас_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Итого_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.СтоимостьАрендыИтого_ = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
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
            this.ВремяСтрока_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Время_ = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.СменаСтрока_ = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерСмены_ = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_ф = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.Объект_ф = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник_ф = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Техника_ф = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект_ = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Арендатор_ = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Тариф_ = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Техника_ = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Сотрудник_ = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_г = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Арендатор_г = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoШапка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsГруппы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoГруппы)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 416);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Арендатор_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Наименование_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГНомер_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СтоимостьВЧас_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Итого_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СтоимостьАрендыИтого_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Тариф_);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВремяСтрока_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Время_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Техника_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерСмены_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СменаСтрока_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник_);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(0, 0);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(678, 396);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Владелец_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Объект_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Сотрудник_ф);
            this.vmoФильтр.Columns.Collection.Add(this.Техника_ф);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(684, 33);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = this.nsgReport1;
            this.nsgGroupsList1.SetTitle = "Группировка";
            this.nsgGroupsList1.Size = new System.Drawing.Size(300, 363);
            this.nsgGroupsList1.TabIndex = 0;
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
            this.nsgReport1.ReportGuid = "fdc7453252d946fb9b8f20bc6dbcc326";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // rdsФильтр
            // 
            this.rdsФильтр.MasterComponent = this.vmoФильтр;
            this.rdsФильтр.Name = "rdsФильтр";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsФильтр;
            this.stiReportDataSource1.Name = "rdsФильтр";
            // 
            // nsgReportDataSource
            // 
            this.nsgReportDataSource.MasterComponent = this.nsgVisualMultipleObject;
            this.nsgReportDataSource.Name = "nsgReportDataSource";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.nsgReportDataSource;
            this.stiReportDataSource2.Name = "nsgReportDataSource";
            // 
            // rdsШапка
            // 
            this.rdsШапка.MasterComponent = this.vmoШапка;
            this.rdsШапка.Name = "rdsШапка";
            // 
            // vmoШапка
            // 
            this.vmoШапка.IsActive = true;
            this.vmoШапка.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoШапка.MetaDataName = "";
            this.vmoШапка.FullName = "";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.rdsШапка;
            this.stiReportDataSource3.Name = "rdsШапка";
            // 
            // rdsГруппы
            // 
            this.rdsГруппы.MasterComponent = this.vmoГруппы;
            this.rdsГруппы.Name = "rdsГруппы";
            // 
            // vmoГруппы
            // 
            this.vmoГруппы.Columns.Collection.Add(this.Объект_г);
            this.vmoГруппы.Columns.Collection.Add(this.Арендатор_г);
            this.vmoГруппы.IsActive = true;
            this.vmoГруппы.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoГруппы.MetaDataName = "";
            this.vmoГруппы.FullName = "";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(684, 0);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(300, 27);
            this.nsgPeriodPicker1.TabIndex = 9;
            // 
            // Наименование_
            // 
            this.Наименование_.Caption = "Наименование";
            this.Наименование_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Наименование_.Name = "Наименование";
            this.Наименование_.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_.PropertyType = typeof(string);
            this.Наименование_.SearchCondition.OwnerComponent = this.Наименование_;
            this.Наименование_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГНомер_
            // 
            this.ГНомер_.Caption = "ГНомер";
            this.ГНомер_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГНомер_.Name = "ГНомер";
            this.ГНомер_.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГНомер_.PropertyType = typeof(string);
            this.ГНомер_.SearchCondition.OwnerComponent = this.ГНомер_;
            this.ГНомер_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтоимостьВЧас_
            // 
            this.СтоимостьВЧас_.CalcTotal = false;
            this.СтоимостьВЧас_.Caption = "СтоимостьВЧас";
            this.СтоимостьВЧас_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтоимостьВЧас_.Name = "СтоимостьВЧас";
            this.СтоимостьВЧас_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.СтоимостьВЧас_.PropertyType = typeof(decimal);
            this.СтоимостьВЧас_.SearchCondition.OwnerComponent = this.СтоимостьВЧас_;
            this.СтоимостьВЧас_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // СтоимостьАрендыИтого_
            // 
            this.СтоимостьАрендыИтого_.CalcTotal = false;
            this.СтоимостьАрендыИтого_.Caption = "СтоимостьАрендыИтого";
            this.СтоимостьАрендыИтого_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтоимостьАрендыИтого_.Name = "СтоимостьАрендыИтого";
            this.СтоимостьАрендыИтого_.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.СтоимостьАрендыИтого_.PropertyType = typeof(decimal);
            this.СтоимостьАрендыИтого_.SearchCondition.OwnerComponent = this.СтоимостьАрендыИтого_;
            this.СтоимостьАрендыИтого_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // СменаСтрока_
            // 
            this.СменаСтрока_.Caption = "СменаСтрока";
            this.СменаСтрока_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СменаСтрока_.Name = "СменаСтрока";
            this.СменаСтрока_.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СменаСтрока_.PropertyType = typeof(string);
            this.СменаСтрока_.SearchCondition.OwnerComponent = this.СменаСтрока_;
            this.СменаСтрока_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСмены_
            // 
            this.НомерСмены_.CalcTotal = false;
            this.НомерСмены_.Caption = "НомерСмены";
            this.НомерСмены_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерСмены_.Name = "НомерСмены";
            this.НомерСмены_.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСмены_.PropertyType = typeof(long);
            this.НомерСмены_.SearchCondition.OwnerComponent = this.НомерСмены_;
            this.НомерСмены_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Владелец_ф
            // 
            this.Владелец_ф.Caption = "Владелец";
            this.Владелец_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Владелец_ф.Name = "Владелец";
            this.Владелец_ф.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_ф.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_ф.SearchCondition.OwnerComponent = this.Владелец_ф;
            this.Владелец_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Сотрудник_ф
            // 
            this.Сотрудник_ф.Caption = "Сотрудник";
            this.Сотрудник_ф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_ф.Name = "Сотрудник";
            this.Сотрудник_ф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_ф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_ф.SearchCondition.OwnerComponent = this.Сотрудник_ф;
            this.Сотрудник_ф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Арендатор_
            // 
            this.Арендатор_.Caption = "Арендатор";
            this.Арендатор_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Арендатор_.Name = "Арендатор";
            this.Арендатор_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Арендатор_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Арендатор_.SearchCondition.OwnerComponent = this.Арендатор_;
            this.Арендатор_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_
            // 
            this.Тариф_.Caption = "Тариф";
            this.Тариф_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_.Name = "Тариф";
            this.Тариф_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_.SearchCondition.OwnerComponent = this.Тариф_;
            this.Тариф_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Сотрудник_
            // 
            this.Сотрудник_.Caption = "Сотрудник";
            this.Сотрудник_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_.Name = "Сотрудник";
            this.Сотрудник_.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_.SearchCondition.OwnerComponent = this.Сотрудник_;
            this.Сотрудник_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_г
            // 
            this.Объект_г.Caption = "Объект";
            this.Объект_г.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_г.Name = "Объект";
            this.Объект_г.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_г.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_г.SearchCondition.OwnerComponent = this.Объект_г;
            this.Объект_г.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Арендатор_г
            // 
            this.Арендатор_г.Caption = "Арендатор";
            this.Арендатор_г.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Арендатор_г.Name = "Арендатор";
            this.Арендатор_г.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Арендатор_г.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Арендатор_г.SearchCondition.OwnerComponent = this.Арендатор_г;
            this.Арендатор_г.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтчетАрендаПоМесяцамФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(984, 446);
            this.Controls.Add(this.nsgPeriodPicker1);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgObjectFilter1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = this.nsgReport1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgObjectFilter1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoШапка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsГруппы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoГруппы)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgVisualMultipleObject vmoШапка;
        protected Объекты.ColumnDescriptor Объект_;
        protected NsgColumnDescriptor.String Наименование_;
        protected NsgColumnDescriptor.String ГНомер_;
        protected Контрагенты.ColumnDescriptor Арендатор_;
        protected NsgColumnDescriptor.Decimal СтоимостьВЧас_;
        protected NsgColumnDescriptor.Decimal Итого_;
        protected NsgColumnDescriptor.Decimal СтоимостьАрендыИтого_;
        protected Объекты.ColumnDescriptor Объект_г;
        protected Тарифы.ColumnDescriptor Тариф_;
        protected NsgColumnDescriptor.Decimal День1_;
        protected NsgColumnDescriptor.Decimal День14_;
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
        protected NsgColumnDescriptor.String ВремяСтрока_;
        protected Контрагенты.ColumnDescriptor Арендатор_г;
        protected Техника.ColumnDescriptor Техника_ф;
        protected NsgColumnDescriptor.MultipleObject Владелец_ф;
        protected Объекты.ColumnDescriptor Объект_ф;
        protected Сотрудники.ColumnDescriptor Сотрудник_ф;
        protected NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected NsgColumnDescriptor.DateTime Время_;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Техника.ColumnDescriptor Техника_;
        private NsgSoft.ReportBuilder.NsgReportDataSource nsgReportDataSource;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsГруппы;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsШапка;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsФильтр;
        protected NsgColumnDescriptor.Int64 НомерСмены_;
        protected NsgColumnDescriptor.String СменаСтрока_;
        protected Сотрудники.ColumnDescriptor Сотрудник_;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        protected NsgVisualMultipleObject vmoГруппы;
        protected NsgVisualMultipleObject vmoФильтр;
        protected NsgSoft.ReportBuilder.NsgReport nsgReport1;
    }
}