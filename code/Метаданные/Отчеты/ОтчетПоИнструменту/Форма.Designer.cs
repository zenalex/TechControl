using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Отчеты

{
    
    public partial class ОтчетПоИнструментуФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоИнструментуФорма));
            this.vmoДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoФильтр = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Сотрудник_vmoФильтр = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_vmoФильтр = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.СерийныйНомер_vmoДанные = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Количество_vmoДанные = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Сотрудник_vmoДанные = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_vmoДанные = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Номенклатура_vmoДанные = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Период = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.rdsДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsШапка = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДанные", this.rdsДанные);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsШапка", this.rdsШапка);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 473);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(881, 30);
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
            this.printButton.Location = new System.Drawing.Point(861, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Период);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // vmoДанные
            // 
            this.vmoДанные.Columns.Collection.Add(this.Номенклатура_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Объект_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Сотрудник_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.СерийныйНомер_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Количество_vmoДанные);
            this.vmoДанные.IsActive = true;
            this.vmoДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДанные.MetaDataName = "";
            this.vmoДанные.FullName = "";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Объект_vmoФильтр);
            this.vmoФильтр.Columns.Collection.Add(this.Сотрудник_vmoФильтр);
            this.vmoФильтр.Columns.Collection.Add(this.Номенклатура_vmoФильтр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // Номенклатура_vmoФильтр
            // 
            this.Номенклатура_vmoФильтр.Caption = "Номенклатура";
            this.Номенклатура_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoФильтр.Name = "Номенклатура";
            this.Номенклатура_vmoФильтр.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoФильтр.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoФильтр.SearchCondition.OwnerComponent = this.Номенклатура_vmoФильтр;
            this.Номенклатура_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.nsgObjectFilter1.Location = new System.Drawing.Point(6, 12);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(533, 455);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(545, 12);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 9;
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(545, 45);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = null;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(332, 175);
            this.nsgGroupsList1.TabIndex = 0;
            // 
            // СерийныйНомер_vmoДанные
            // 
            this.СерийныйНомер_vmoДанные.Caption = "СерийныйНомер";
            this.СерийныйНомер_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СерийныйНомер_vmoДанные.Name = "СерийныйНомер";
            this.СерийныйНомер_vmoДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СерийныйНомер_vmoДанные.PropertyType = typeof(string);
            this.СерийныйНомер_vmoДанные.SearchCondition.OwnerComponent = this.СерийныйНомер_vmoДанные;
            this.СерийныйНомер_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoДанные
            // 
            this.Количество_vmoДанные.CalcTotal = false;
            this.Количество_vmoДанные.Caption = "Количество";
            this.Количество_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_vmoДанные.Name = "Количество";
            this.Количество_vmoДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoДанные.PropertyType = typeof(long);
            this.Количество_vmoДанные.SearchCondition.OwnerComponent = this.Количество_vmoДанные;
            this.Количество_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoДанные
            // 
            this.Сотрудник_vmoДанные.Caption = "Сотрудник";
            this.Сотрудник_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoДанные.Name = "Сотрудник";
            this.Сотрудник_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанные.SearchCondition.OwnerComponent = this.Сотрудник_vmoДанные;
            this.Сотрудник_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoДанные
            // 
            this.Объект_vmoДанные.Caption = "Объект";
            this.Объект_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoДанные.Name = "Объект";
            this.Объект_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoДанные.SearchCondition.OwnerComponent = this.Объект_vmoДанные;
            this.Объект_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура_vmoДанные
            // 
            this.Номенклатура_vmoДанные.Caption = "Номенклатура";
            this.Номенклатура_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoДанные.Name = "Номенклатура";
            this.Номенклатура_vmoДанные.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoДанные.SearchCondition.OwnerComponent = this.Номенклатура_vmoДанные;
            this.Номенклатура_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Период
            // 
            this.Период.Caption = "Период";
            this.Период.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Период.Name = "Период";
            this.Период.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Период.PropertyType = typeof(string);
            this.Период.SearchCondition.OwnerComponent = this.Период;
            this.Период.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsДанные
            // 
            this.rdsДанные.MasterComponent = this.vmoДанные;
            this.rdsДанные.Name = "rdsДанные";
            // 
            // rdsШапка
            // 
            this.rdsШапка.MasterComponent = this.nsgVisualMultipleObject;
            this.rdsШапка.Name = "rdsШапка";
            this.rdsШапка.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
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
            this.nsgReport1.ReportAlias = "Report";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportGuid = "ecd307299f834f6bb0d3ae380fe61b4d";
            this.nsgReport1.ReportLoaded = false;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsДанные;
            this.stiReportDataSource1.Name = "rdsДанные";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsШапка;
            this.stiReportDataSource2.Name = "rdsШапка";
            // 
            // ОтчетПоИнструментуФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(881, 523);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgPeriodPicker1);
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
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsШапка)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected NsgVisualMultipleObject vmoДанные;
        protected NsgVisualMultipleObject vmoФильтр;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoФильтр;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoФильтр;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoФильтр;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoДанные;
        protected NsgColumnDescriptor.String СерийныйНомер_vmoДанные;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected NsgPeriodPicker nsgPeriodPicker1;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoДанные;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoДанные;
        protected NsgColumnDescriptor.Int64 Количество_vmoДанные;
        protected NsgColumnDescriptor.String Период;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДанные;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsШапка;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
    }
}