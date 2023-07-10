using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Отчеты

{
    
    public partial class ОтчетПоЗакупкамФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоЗакупкамФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn4 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn5 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn6 = new NsgSoft.Forms.NsgGridColumn();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Подразделение_vmoФильтр = new TechControl.Метаданные.Мониторинг.Подразделения.ColumnDescriptor();
            this.Сотрудник_vmoФильтр = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_vmoФильтр = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.vmoДопДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаОтчета_vmoДопДанные = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Размер = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.КоличествоНаОбъекте = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Количество = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Цена = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Номенклатура = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.rdsДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsДоп = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДанные", this.rdsДанные);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДоп", this.rdsДоп);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДоп)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 482);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(803, 30);
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
            this.printButton.Location = new System.Drawing.Point(783, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Номенклатура);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Цена);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Количество);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Должность);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КоличествоНаОбъекте);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Размер);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn4.Caption = "";
            nsgGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn4.ImportedFromVMO = false;
            nsgGridColumn4.Name = "Подразделение";
            nsgGridColumn4.Root = this.nsgObjectFilter1.Columns.Collection;
            nsgGridColumn5.Caption = "";
            nsgGridColumn5.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn5.ImportedFromVMO = false;
            nsgGridColumn5.Name = "Сотрудник";
            nsgGridColumn5.Root = this.nsgObjectFilter1.Columns.Collection;
            nsgGridColumn6.Caption = "";
            nsgGridColumn6.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn6.ImportedFromVMO = false;
            nsgGridColumn6.Name = "Объект";
            nsgGridColumn6.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn4);
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn5);
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn6);
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(13, 13);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(442, 453);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
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
            // vmoДопДанные
            // 
            this.vmoДопДанные.Columns.Collection.Add(this.ДатаОтчета_vmoДопДанные);
            this.vmoДопДанные.IsActive = true;
            this.vmoДопДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДопДанные.MetaDataName = "";
            this.vmoДопДанные.FullName = "";
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
            // Размер
            // 
            this.Размер.Caption = "Размер";
            this.Размер.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Размер.Name = "Размер";
            this.Размер.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.SearchCondition.OwnerComponent = this.Размер;
            this.Размер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоНаОбъекте
            // 
            this.КоличествоНаОбъекте.CalcTotal = false;
            this.КоличествоНаОбъекте.Caption = "КоличествоНаОбъекте";
            this.КоличествоНаОбъекте.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КоличествоНаОбъекте.Name = "КоличествоНаОбъекте";
            this.КоличествоНаОбъекте.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоНаОбъекте.PropertyType = typeof(long);
            this.КоличествоНаОбъекте.SearchCondition.OwnerComponent = this.КоличествоНаОбъекте;
            this.КоличествоНаОбъекте.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность
            // 
            this.Должность.Caption = "Должность";
            this.Должность.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность.Name = "Должность";
            this.Должность.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.SearchCondition.OwnerComponent = this.Должность;
            this.Должность.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник
            // 
            this.Сотрудник.Caption = "Сотрудник";
            this.Сотрудник.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.SearchCondition.OwnerComponent = this.Сотрудник;
            this.Сотрудник.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество
            // 
            this.Количество.CalcTotal = false;
            this.Количество.Caption = "Количество";
            this.Количество.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество.Name = "Количество";
            this.Количество.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество.PropertyType = typeof(long);
            this.Количество.SearchCondition.OwnerComponent = this.Количество;
            this.Количество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект
            // 
            this.Объект.Caption = "Объект";
            this.Объект.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект.Name = "Объект";
            this.Объект.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект.SearchCondition.OwnerComponent = this.Объект;
            this.Объект.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена
            // 
            this.Цена.CalcTotal = false;
            this.Цена.Caption = "Цена";
            this.Цена.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Цена.Name = "Цена";
            this.Цена.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена.PropertyType = typeof(decimal);
            this.Цена.SearchCondition.OwnerComponent = this.Цена;
            this.Цена.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура
            // 
            this.Номенклатура.Caption = "Номенклатура";
            this.Номенклатура.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура.Name = "Номенклатура";
            this.Номенклатура.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура.SearchCondition.OwnerComponent = this.Номенклатура;
            this.Номенклатура.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.nsgInput1.Location = new System.Drawing.Point(458, 13);
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
            this.nsgInput1.Size = new System.Drawing.Size(191, 20);
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
            this.nsgGroupsList1.Location = new System.Drawing.Point(461, 46);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = null;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(332, 175);
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
            this.nsgReport1.ReportAlias = "Report";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportGuid = "3647c21fc4ec4e6f8db7573c9acd2849";
            this.nsgReport1.ReportLoaded = false;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = null;
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // rdsДанные
            // 
            this.rdsДанные.MasterComponent = this.nsgVisualMultipleObject;
            this.rdsДанные.Name = "rdsДанные";
            // 
            // rdsДоп
            // 
            this.rdsДоп.MasterComponent = this.vmoДопДанные;
            this.rdsДоп.Name = "rdsДоп";
            this.rdsДоп.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsДанные;
            this.stiReportDataSource1.Name = "rdsДанные";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsДоп;
            this.stiReportDataSource2.Name = "rdsДоп";
            // 
            // ОтчетПоЗакупкамФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(803, 532);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДоп)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected NsgColumnDescriptor.DateTime ДатаОтчета_vmoДопДанные;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура;
        protected Мониторинг.Подразделения.ColumnDescriptor Подразделение_vmoФильтр;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoФильтр;
        private Мониторинг.Объекты.ColumnDescriptor Объект_vmoФильтр;
        protected NsgInput nsgInput1;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgColumnDescriptor.Decimal Цена;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgColumnDescriptor.Int64 Количество;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        protected Мониторинг.Должности.ColumnDescriptor Должность;
        protected NsgColumnDescriptor.Int64 КоличествоНаОбъекте;
        protected Учет.Размеры.ColumnDescriptor Размер;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДанные;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДоп;
        private NsgVisualMultipleObject vmoДопДанные;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
    }
}