using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Отчеты

{
    
    public partial class ОтчетПоСпецодеждеФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоСпецодеждеФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn1 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn2 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn3 = new NsgSoft.Forms.NsgGridColumn();
            this.vmoДопДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.rdsОсновной = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsДопДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsФильтр = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsОсновной", this.rdsОсновной);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДопДанные", this.rdsДопДанные);
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsФильтр", this.rdsФильтр);
            this.cbПоказыватьНевыданные = new System.Windows.Forms.CheckBox();
            this.ДатаОтчета_vmoДопДанные = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Подразделение_vmoФильтр = new TechControl.Метаданные.Мониторинг.Подразделения.ColumnDescriptor();
            this.Сотрудник_vmoФильтр = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_vmoФильтр = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Номенклатура_осн = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Комплект_осн = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Количество_осн = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Сотрудник_осн = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Подразделение_осн = new TechControl.Метаданные.Мониторинг.Подразделения.ColumnDescriptor();
            this.Должность_осн = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.ДатаВыдачи_осн = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Стоимость_осн = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Выдано_осн = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ГруппировкаПоФактуВыдачи_осн = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Размер_осн = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.ОбъектВыдачи_осн = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОсновнойОбъект_осн = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновной)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).BeginInit();
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
            this.panelButtonReportForm.Controls.Add(this.elementRightsButton);
            this.panelButtonReportForm.Controls.Add(this.formSettingsButton);
            this.panelButtonReportForm.Controls.Add(this.printButton);
            this.panelButtonReportForm.Controls.Add(this.btnCreateReport);
            this.panelButtonReportForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 454);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(700, 30);
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
            this.printButton.Location = new System.Drawing.Point(680, 0);
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
            // elementRightsButton
            // 
            this.elementRightsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elementRightsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elementRightsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.elementRightsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.elementRightsButton.Location = new System.Drawing.Point(140, 0);
            this.elementRightsButton.Name = "elementRightsButton";
            this.elementRightsButton.Size = new System.Drawing.Size(88, 30);
            this.elementRightsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.elementRightsButton.TabIndex = 19;
            this.elementRightsButton.Text = "Права пользователей";
            this.elementRightsButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Номенклатура_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Комплект_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Количество_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Подразделение_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Должность_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаВыдачи_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Стоимость_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Выдано_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГруппировкаПоФактуВыдачи_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Размер_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектВыдачи_осн);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОсновнойОбъект_осн);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // vmoДопДанные
            // 
            this.vmoДопДанные.Columns.Collection.Add(this.ДатаОтчета_vmoДопДанные);
            this.vmoДопДанные.IsActive = true;
            this.vmoДопДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДопДанные.MetaDataName = "";
            this.vmoДопДанные.FullName = "";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Подразделение_vmoФильтр);
            this.vmoФильтр.Columns.Collection.Add(this.Сотрудник_vmoФильтр);
            this.vmoФильтр.Columns.Collection.Add(this.Объект_vmoФильтр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn1.Caption = "";
            nsgGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn1.ImportedFromVMO = false;
            nsgGridColumn1.Name = "Подразделение";
            nsgGridColumn1.Root = this.nsgObjectFilter1.Columns.Collection;
            nsgGridColumn2.Caption = "";
            nsgGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn2.ImportedFromVMO = false;
            nsgGridColumn2.Name = "Сотрудник";
            nsgGridColumn2.Root = this.nsgObjectFilter1.Columns.Collection;
            nsgGridColumn3.Caption = "";
            nsgGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn3.ImportedFromVMO = false;
            nsgGridColumn3.Name = "Объект";
            nsgGridColumn3.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn1);
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn2);
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn3);
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(6, 3);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(349, 425);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // nsgInput1
            // 
            this.nsgInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "ДатаОтчета";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(358, 3);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "ДатаОтчета";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(211, 20);
            this.nsgInput1.SourceObject = this.vmoДопДанные;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(361, 26);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = null;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(332, 175);
            this.nsgGroupsList1.TabIndex = 0;
            // 
            // rdsОсновной
            // 
            this.rdsОсновной.MasterComponent = this.nsgVisualMultipleObject;
            this.rdsОсновной.Name = "rdsОсновной";
            // 
            // rdsДопДанные
            // 
            this.rdsДопДанные.MasterComponent = this.vmoДопДанные;
            this.rdsДопДанные.Name = "rdsДопДанные";
            this.rdsДопДанные.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // rdsФильтр
            // 
            this.rdsФильтр.MasterComponent = this.vmoФильтр;
            this.rdsФильтр.Name = "rdsФильтр";
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
        "NsgSoft.CityGuide.Dll",
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
        "NsgSoft.Report.dll",
        "NsgSoft.ReportBuilder.dll",
        "NsgSoft.ReportBase.dll",
        "NsgSoft.ReportData.dll",
        "NsgSoft.ReportBuilder.Design.dll",
        "NsgSoft.ReportControls.dll",
        "NsgSoft.ReportEditor.dll",
        "NsgSoft.ReportBuilder.Check.dll",
        "NsgSoft.ReportBuilder.Helper.dll",
        "NsgSoft.ReportBuilder.Win.dll",
        "NsgSoft.ReportDesign.dll"};
            this.nsgReport1.ReportAlias = "Отчет по спецодежде - 16:22";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource3);
            this.nsgReport1.ReportGuid = "e9cda903961d4ee2964fae0920c72ab2";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет по спецодежде - 16:22";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsОсновной;
            this.stiReportDataSource1.Name = "rdsОсновной";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsДопДанные;
            this.stiReportDataSource2.Name = "rdsДопДанные";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.rdsФильтр;
            this.stiReportDataSource3.Name = "rdsФильтр";
            // 
            // cbПоказыватьНевыданные
            // 
            this.cbПоказыватьНевыданные.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbПоказыватьНевыданные.AutoSize = true;
            this.cbПоказыватьНевыданные.Location = new System.Drawing.Point(361, 207);
            this.cbПоказыватьНевыданные.Name = "cbПоказыватьНевыданные";
            this.cbПоказыватьНевыданные.Size = new System.Drawing.Size(257, 17);
            this.cbПоказыватьНевыданные.TabIndex = 10;
            this.cbПоказыватьНевыданные.Text = "Показывать недополученные по должностям";
            this.cbПоказыватьНевыданные.UseVisualStyleBackColor = true;
            // 
            // ДатаОтчета_vmoДопДанные
            // 
            this.ДатаОтчета_vmoДопДанные.Caption = "ДатаОтчета";
            this.ДатаОтчета_vmoДопДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаОтчета_vmoДопДанные.Name = "ДатаОтчета";
            this.ДатаОтчета_vmoДопДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаОтчета_vmoДопДанные.PropertyType = typeof(System.DateTime);
            this.ДатаОтчета_vmoДопДанные.SearchCondition.OwnerComponent = this.ДатаОтчета_vmoДопДанные;
            this.ДатаОтчета_vmoДопДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подразделение_vmoФильтр
            // 
            this.Подразделение_vmoФильтр.Caption = "Подразделение";
            this.Подразделение_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подразделение_vmoФильтр.Name = "Подразделение";
            this.Подразделение_vmoФильтр.NSGType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_vmoФильтр.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_vmoФильтр.SearchCondition.OwnerComponent = this.Подразделение_vmoФильтр;
            this.Подразделение_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoФильтр
            // 
            this.Сотрудник_vmoФильтр.Caption = "Сотрудник";
            this.Сотрудник_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoФильтр.Name = "Сотрудник";
            this.Сотрудник_vmoФильтр.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoФильтр.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoФильтр.SearchCondition.OwnerComponent = this.Сотрудник_vmoФильтр;
            this.Сотрудник_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoФильтр
            // 
            this.Объект_vmoФильтр.Caption = "Объект";
            this.Объект_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoФильтр.Name = "Объект";
            this.Объект_vmoФильтр.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoФильтр.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoФильтр.SearchCondition.OwnerComponent = this.Объект_vmoФильтр;
            this.Объект_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура_осн
            // 
            this.Номенклатура_осн.Caption = "Номенклатура";
            this.Номенклатура_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_осн.Name = "Номенклатура";
            this.Номенклатура_осн.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_осн.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_осн.SearchCondition.OwnerComponent = this.Номенклатура_осн;
            this.Номенклатура_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комплект_осн
            // 
            this.Комплект_осн.Caption = "Комплект";
            this.Комплект_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комплект_осн.Name = "Комплект";
            this.Комплект_осн.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_осн.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_осн.SearchCondition.OwnerComponent = this.Комплект_осн;
            this.Комплект_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_осн
            // 
            this.Количество_осн.CalcTotal = false;
            this.Количество_осн.Caption = "Количество";
            this.Количество_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_осн.Name = "Количество";
            this.Количество_осн.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_осн.PropertyType = typeof(long);
            this.Количество_осн.SearchCondition.OwnerComponent = this.Количество_осн;
            this.Количество_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_осн
            // 
            this.Сотрудник_осн.Caption = "Сотрудник";
            this.Сотрудник_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_осн.Name = "Сотрудник";
            this.Сотрудник_осн.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_осн.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_осн.SearchCondition.OwnerComponent = this.Сотрудник_осн;
            this.Сотрудник_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подразделение_осн
            // 
            this.Подразделение_осн.Caption = "Подразделение";
            this.Подразделение_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подразделение_осн.Name = "Подразделение";
            this.Подразделение_осн.NSGType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_осн.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_осн.SearchCondition.OwnerComponent = this.Подразделение_осн;
            this.Подразделение_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность_осн
            // 
            this.Должность_осн.Caption = "Должность";
            this.Должность_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_осн.Name = "Должность";
            this.Должность_осн.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_осн.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_осн.SearchCondition.OwnerComponent = this.Должность_осн;
            this.Должность_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаВыдачи_осн
            // 
            this.ДатаВыдачи_осн.Caption = "НоваяКолонка";
            this.ДатаВыдачи_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаВыдачи_осн.Name = "ДатаВыдачи";
            this.ДатаВыдачи_осн.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаВыдачи_осн.PropertyType = typeof(System.DateTime);
            this.ДатаВыдачи_осн.SearchCondition.OwnerComponent = this.ДатаВыдачи_осн;
            this.ДатаВыдачи_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Стоимость_осн
            // 
            this.Стоимость_осн.CalcTotal = false;
            this.Стоимость_осн.Caption = "Стоимость";
            this.Стоимость_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Стоимость_осн.Name = "Стоимость";
            this.Стоимость_осн.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Стоимость_осн.PropertyType = typeof(decimal);
            this.Стоимость_осн.SearchCondition.OwnerComponent = this.Стоимость_осн;
            this.Стоимость_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Выдано_осн
            // 
            this.Выдано_осн.Caption = "Выдано";
            this.Выдано_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выдано_осн.Name = "Выдано";
            this.Выдано_осн.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выдано_осн.PropertyType = typeof(bool);
            this.Выдано_осн.SearchCondition.OwnerComponent = this.Выдано_осн;
            this.Выдано_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГруппировкаПоФактуВыдачи_осн
            // 
            this.ГруппировкаПоФактуВыдачи_осн.Caption = "ГруппировкаПоФактуВыдачи";
            this.ГруппировкаПоФактуВыдачи_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГруппировкаПоФактуВыдачи_осн.Name = "ГруппировкаПоФактуВыдачи";
            this.ГруппировкаПоФактуВыдачи_осн.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГруппировкаПоФактуВыдачи_осн.PropertyType = typeof(string);
            this.ГруппировкаПоФактуВыдачи_осн.SearchCondition.OwnerComponent = this.ГруппировкаПоФактуВыдачи_осн;
            this.ГруппировкаПоФактуВыдачи_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_осн
            // 
            this.Размер_осн.Caption = "Размер";
            this.Размер_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Размер_осн.Name = "Размер";
            this.Размер_осн.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_осн.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_осн.SearchCondition.OwnerComponent = this.Размер_осн;
            this.Размер_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектВыдачи_осн
            // 
            this.ОбъектВыдачи_осн.Caption = "ОбъектВыдачи";
            this.ОбъектВыдачи_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъектВыдачи_осн.Name = "ОбъектВыдачи";
            this.ОбъектВыдачи_осн.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачи_осн.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачи_осн.SearchCondition.OwnerComponent = this.ОбъектВыдачи_осн;
            this.ОбъектВыдачи_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОсновнойОбъект_осн
            // 
            this.ОсновнойОбъект_осн.Caption = "ОсновнойОбъект";
            this.ОсновнойОбъект_осн.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОсновнойОбъект_осн.Name = "ОсновнойОбъект";
            this.ОсновнойОбъект_осн.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект_осн.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект_осн.SearchCondition.OwnerComponent = this.ОсновнойОбъект_осн;
            this.ОсновнойОбъект_осн.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтчетПоСпецодеждеФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(700, 484);
            this.Controls.Add(this.cbПоказыватьНевыданные);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgInput1);
            this.Controls.Add(this.nsgObjectFilter1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgObjectFilter1, 0);
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            this.Controls.SetChildIndex(this.cbПоказыватьНевыданные, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновной)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsФильтр)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_осн;
        protected NsgColumnDescriptor.DateTime ДатаВыдачи_осн;
        protected NsgVisualMultipleObject vmoДопДанные;
        protected NsgColumnDescriptor.DateTime ДатаОтчета_vmoДопДанные;
        protected NsgVisualMultipleObject vmoФильтр;
        protected Мониторинг.Подразделения.ColumnDescriptor Подразделение_vmoФильтр;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoФильтр;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoФильтр;
        protected NsgInput nsgInput1;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsОсновной;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДопДанные;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsФильтр;
        protected NsgColumnDescriptor.Decimal Стоимость_осн;
        protected NsgColumnDescriptor.Boolean Выдано_осн;
        protected NsgColumnDescriptor.String ГруппировкаПоФактуВыдачи_осн;
        private System.Windows.Forms.CheckBox cbПоказыватьНевыданные;
        protected УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor Комплект_осн;
        protected NsgColumnDescriptor.Int64 Количество_осн;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_осн;
        protected Мониторинг.Подразделения.ColumnDescriptor Подразделение_осн;
        protected Мониторинг.Должности.ColumnDescriptor Должность_осн;
        protected NsgSoft.ReportBuilder.NsgReport nsgReport1;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        protected Учет.Размеры.ColumnDescriptor Размер_осн;
        protected Мониторинг.Объекты.ColumnDescriptor ОбъектВыдачи_осн;
        protected Мониторинг.Объекты.ColumnDescriptor ОсновнойОбъект_осн;
    }
}