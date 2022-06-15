using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ПолучениеДанныхСПИКФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПолучениеДанныхСПИКФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСигнализации = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Техника_vmoСигнализации = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВремяРаботыСкаут_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВремяРаботыДок_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВремяРаботыСигнализации_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дата_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoАнализДанных = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Техника_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Геозона_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Геозоны.ColumnDescriptor();
            this.ВремяПриездаВГеозону_vmoАнализДанных = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Объект_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ВремяПриездаНаОбъект_vmoАнализДанных = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmo = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаПоследнейЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Техника_vmo = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ОбъемЗаправки = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nsgButton2 = new NsgSoft.Design.NsgButton();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nsgPeriodPicker2 = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgButton3 = new NsgSoft.Design.NsgButton();
            this.НаименованиеГеозоны_vmoГеозоны = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Долгота_vmoГеозоны = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Широта_vmoГеозоны = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.РадиусГеозоны = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСигнализации)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoАнализДанных)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton3)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 427);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(867, 30);
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
            this.printButton.Location = new System.Drawing.Point(847, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.РадиусГеозоны);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
            this.nsgIGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid1.AutoResizeCols = true;
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.ImportedFromVMO = false;
            nsgIGridColumn1.Name = "Техника";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.ImportedFromVMO = false;
            nsgIGridColumn2.Name = "ВремяРаботыСкаут";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.ImportedFromVMO = false;
            nsgIGridColumn3.Name = "ВремяРаботыДок";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.ImportedFromVMO = false;
            nsgIGridColumn4.Name = "ВремяРаботыСигнализация";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.ImportedFromVMO = false;
            nsgIGridColumn5.Name = "Дата";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 72);
            this.nsgIGrid1.MarkReadOnly = false;
            this.nsgIGrid1.MasterObject = null;
            this.nsgIGrid1.Name = "NsgIGrid";
            this.nsgIGrid1.PageSelector = false;
            this.nsgIGrid1.ReadOnly = false;
            this.nsgIGrid1.RowChangeInterval = 200;
            this.nsgIGrid1.RowHeaderImageList = null;
            this.nsgIGrid1.RowMode = false;
            this.nsgIGrid1.ScrollWidth = 0;
            this.nsgIGrid1.SelectedRow = -1;
            this.nsgIGrid1.ShowHeader = true;
            this.nsgIGrid1.ShowLineImages = true;
            this.nsgIGrid1.ShowLineNumbers = false;
            this.nsgIGrid1.ShowPanel = true;
            this.nsgIGrid1.ShowTotals = false;
            this.nsgIGrid1.ShowTree = false;
            this.nsgIGrid1.Size = new System.Drawing.Size(841, 314);
            this.nsgIGrid1.SourceObject = this.vmoСигнализации;
            this.nsgIGrid1.TabIndex = 11;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoСигнализации
            // 
            this.vmoСигнализации.Columns.Collection.Add(this.Техника_vmoСигнализации);
            this.vmoСигнализации.Columns.Collection.Add(this.ВремяРаботыСкаут_vmoСигнализации);
            this.vmoСигнализации.Columns.Collection.Add(this.ВремяРаботыДок_vmoСигнализации);
            this.vmoСигнализации.Columns.Collection.Add(this.ВремяРаботыСигнализации_vmoСигнализации);
            this.vmoСигнализации.Columns.Collection.Add(this.Дата_vmoСигнализации);
            this.vmoСигнализации.IsActive = true;
            this.vmoСигнализации.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСигнализации.MetaDataName = "";
            this.vmoСигнализации.FullName = "";
            // 
            // Техника_vmoСигнализации
            // 
            this.Техника_vmoСигнализации.Caption = "Техника";
            this.Техника_vmoСигнализации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoСигнализации.Name = "Техника";
            this.Техника_vmoСигнализации.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСигнализации.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСигнализации.SearchCondition.OwnerComponent = this.Техника_vmoСигнализации;
            this.Техника_vmoСигнализации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяРаботыСкаут_vmoСигнализации
            // 
            this.ВремяРаботыСкаут_vmoСигнализации.CalcTotal = false;
            this.ВремяРаботыСкаут_vmoСигнализации.Caption = "ВремяРаботыСкаут";
            this.ВремяРаботыСкаут_vmoСигнализации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяРаботыСкаут_vmoСигнализации.Name = "ВремяРаботыСкаут";
            this.ВремяРаботыСкаут_vmoСигнализации.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ВремяРаботыСкаут_vmoСигнализации.PropertyType = typeof(decimal);
            this.ВремяРаботыСкаут_vmoСигнализации.SearchCondition.OwnerComponent = this.ВремяРаботыСкаут_vmoСигнализации;
            this.ВремяРаботыСкаут_vmoСигнализации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяРаботыДок_vmoСигнализации
            // 
            this.ВремяРаботыДок_vmoСигнализации.CalcTotal = false;
            this.ВремяРаботыДок_vmoСигнализации.Caption = "ВремяРаботыДок";
            this.ВремяРаботыДок_vmoСигнализации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяРаботыДок_vmoСигнализации.Name = "ВремяРаботыДок";
            this.ВремяРаботыДок_vmoСигнализации.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ВремяРаботыДок_vmoСигнализации.PropertyType = typeof(decimal);
            this.ВремяРаботыДок_vmoСигнализации.SearchCondition.OwnerComponent = this.ВремяРаботыДок_vmoСигнализации;
            this.ВремяРаботыДок_vmoСигнализации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяРаботыСигнализации_vmoСигнализации
            // 
            this.ВремяРаботыСигнализации_vmoСигнализации.CalcTotal = false;
            this.ВремяРаботыСигнализации_vmoСигнализации.Caption = "ВремяРаботыСигнализация";
            this.ВремяРаботыСигнализации_vmoСигнализации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяРаботыСигнализации_vmoСигнализации.Name = "ВремяРаботыСигнализация";
            this.ВремяРаботыСигнализации_vmoСигнализации.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ВремяРаботыСигнализации_vmoСигнализации.PropertyType = typeof(decimal);
            this.ВремяРаботыСигнализации_vmoСигнализации.SearchCondition.OwnerComponent = this.ВремяРаботыСигнализации_vmoСигнализации;
            this.ВремяРаботыСигнализации_vmoСигнализации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дата_vmoСигнализации
            // 
            this.Дата_vmoСигнализации.Caption = "Дата";
            this.Дата_vmoСигнализации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дата_vmoСигнализации.Name = "Дата";
            this.Дата_vmoСигнализации.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Дата_vmoСигнализации.PropertyType = typeof(System.DateTime);
            this.Дата_vmoСигнализации.SearchCondition.OwnerComponent = this.Дата_vmoСигнализации;
            this.Дата_vmoСигнализации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid2
            // 
            this.nsgIGrid2.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid2.AllowSaveColParamsToXML = true;
            this.nsgIGrid2.AllowSaveColPositionToXML = true;
            this.nsgIGrid2.AllowSaveColWidthToXML = true;
            this.nsgIGrid2.AllowSaveSettingsToXML = true;
            this.nsgIGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid2.AutoResizeCols = true;
            nsgIGridColumn6.AllowFilter = true;
            nsgIGridColumn6.AllowGroupSelect = false;
            nsgIGridColumn6.AllowResize = true;
            nsgIGridColumn6.AutoResize = true;
            nsgIGridColumn6.Caption = "";
            nsgIGridColumn6.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Name = "Техника";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            nsgIGridColumn7.AllowFilter = true;
            nsgIGridColumn7.AllowGroupSelect = false;
            nsgIGridColumn7.AllowResize = true;
            nsgIGridColumn7.AutoResize = true;
            nsgIGridColumn7.Caption = "";
            nsgIGridColumn7.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "Геозона";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Width = 100;
            nsgIGridColumn8.AllowFilter = true;
            nsgIGridColumn8.AllowGroupSelect = false;
            nsgIGridColumn8.AllowResize = true;
            nsgIGridColumn8.AutoResize = true;
            nsgIGridColumn8.Caption = "";
            nsgIGridColumn8.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "ВремяПриездаВГеозону";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.Name = "Объект";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Width = 100;
            nsgIGridColumn10.AllowFilter = true;
            nsgIGridColumn10.AllowGroupSelect = false;
            nsgIGridColumn10.AllowResize = true;
            nsgIGridColumn10.AutoResize = true;
            nsgIGridColumn10.Caption = "";
            nsgIGridColumn10.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.Name = "ВремяПриездаНаОбъект";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(6, 48);
            this.nsgIGrid2.MarkReadOnly = false;
            this.nsgIGrid2.MasterObject = null;
            this.nsgIGrid2.Name = "NsgIGrid";
            this.nsgIGrid2.PageSelector = false;
            this.nsgIGrid2.ReadOnly = false;
            this.nsgIGrid2.RowChangeInterval = 200;
            this.nsgIGrid2.RowHeaderImageList = null;
            this.nsgIGrid2.RowMode = false;
            this.nsgIGrid2.ScrollWidth = 0;
            this.nsgIGrid2.SelectedRow = -1;
            this.nsgIGrid2.ShowHeader = true;
            this.nsgIGrid2.ShowLineImages = true;
            this.nsgIGrid2.ShowLineNumbers = false;
            this.nsgIGrid2.ShowPanel = true;
            this.nsgIGrid2.ShowTotals = false;
            this.nsgIGrid2.ShowTree = false;
            this.nsgIGrid2.Size = new System.Drawing.Size(839, 338);
            this.nsgIGrid2.SourceObject = this.vmoАнализДанных;
            this.nsgIGrid2.TabIndex = 2;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoАнализДанных
            // 
            this.vmoАнализДанных.Columns.Collection.Add(this.Техника_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.Геозона_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.ВремяПриездаВГеозону_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.Объект_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.ВремяПриездаНаОбъект_vmoАнализДанных);
            this.vmoАнализДанных.IsActive = true;
            this.vmoАнализДанных.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoАнализДанных.MetaDataName = "";
            this.vmoАнализДанных.FullName = "";
            // 
            // Техника_vmoАнализДанных
            // 
            this.Техника_vmoАнализДанных.Caption = "Техника";
            this.Техника_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoАнализДанных.Name = "Техника";
            this.Техника_vmoАнализДанных.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoАнализДанных.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoАнализДанных.SearchCondition.OwnerComponent = this.Техника_vmoАнализДанных;
            this.Техника_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Геозона_vmoАнализДанных
            // 
            this.Геозона_vmoАнализДанных.Caption = "Геозона";
            this.Геозона_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Геозона_vmoАнализДанных.Name = "Геозона";
            this.Геозона_vmoАнализДанных.NSGType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона_vmoАнализДанных.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона_vmoАнализДанных.SearchCondition.OwnerComponent = this.Геозона_vmoАнализДанных;
            this.Геозона_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяПриездаВГеозону_vmoАнализДанных
            // 
            this.ВремяПриездаВГеозону_vmoАнализДанных.Caption = "Время приезда в геозону";
            this.ВремяПриездаВГеозону_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяПриездаВГеозону_vmoАнализДанных.Name = "ВремяПриездаВГеозону";
            this.ВремяПриездаВГеозону_vmoАнализДанных.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяПриездаВГеозону_vmoАнализДанных.PropertyType = typeof(System.DateTime);
            this.ВремяПриездаВГеозону_vmoАнализДанных.SearchCondition.OwnerComponent = this.ВремяПриездаВГеозону_vmoАнализДанных;
            this.ВремяПриездаВГеозону_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoАнализДанных
            // 
            this.Объект_vmoАнализДанных.Caption = "Объект";
            this.Объект_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoАнализДанных.Name = "Объект";
            this.Объект_vmoАнализДанных.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoАнализДанных.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoАнализДанных.SearchCondition.OwnerComponent = this.Объект_vmoАнализДанных;
            this.Объект_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяПриездаНаОбъект_vmoАнализДанных
            // 
            this.ВремяПриездаНаОбъект_vmoАнализДанных.Caption = "ВремяПриездаНаОбъект";
            this.ВремяПриездаНаОбъект_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяПриездаНаОбъект_vmoАнализДанных.Name = "ВремяПриездаНаОбъект";
            this.ВремяПриездаНаОбъект_vmoАнализДанных.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяПриездаНаОбъект_vmoАнализДанных.PropertyType = typeof(System.DateTime);
            this.ВремяПриездаНаОбъект_vmoАнализДанных.SearchCondition.OwnerComponent = this.ВремяПриездаНаОбъект_vmoАнализДанных;
            this.ВремяПриездаНаОбъект_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid3
            // 
            this.nsgIGrid3.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid3.AllowSaveColParamsToXML = true;
            this.nsgIGrid3.AllowSaveColPositionToXML = true;
            this.nsgIGrid3.AllowSaveColWidthToXML = true;
            this.nsgIGrid3.AllowSaveSettingsToXML = true;
            this.nsgIGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid3.AutoResizeCols = true;
            nsgIGridColumn11.AllowFilter = true;
            nsgIGridColumn11.AllowGroupSelect = false;
            nsgIGridColumn11.AllowResize = true;
            nsgIGridColumn11.AutoResize = true;
            nsgIGridColumn11.Caption = "";
            nsgIGridColumn11.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn11.DateFormat = null;
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.Name = "Техника";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.UseAsHeaderImage = false;
            nsgIGridColumn11.Width = 100;
            nsgIGridColumn12.AllowFilter = true;
            nsgIGridColumn12.AllowGroupSelect = false;
            nsgIGridColumn12.AllowResize = true;
            nsgIGridColumn12.AutoResize = true;
            nsgIGridColumn12.Caption = "";
            nsgIGridColumn12.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn12.DateFormat = null;
            nsgIGridColumn12.ImportedFromVMO = false;
            nsgIGridColumn12.Name = "ДатаПоследнейЗаправки";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn12.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn12.UseAsHeaderImage = false;
            nsgIGridColumn12.Width = 100;
            nsgIGridColumn13.AllowFilter = true;
            nsgIGridColumn13.AllowGroupSelect = false;
            nsgIGridColumn13.AllowResize = true;
            nsgIGridColumn13.AutoResize = true;
            nsgIGridColumn13.Caption = "";
            nsgIGridColumn13.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn13.DateFormat = null;
            nsgIGridColumn13.ImportedFromVMO = false;
            nsgIGridColumn13.Name = "ОбъемЗаправки";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn13.UseAsHeaderImage = false;
            nsgIGridColumn13.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(27, 64);
            this.nsgIGrid3.MarkReadOnly = false;
            this.nsgIGrid3.MasterObject = null;
            this.nsgIGrid3.Name = "NsgIGrid";
            this.nsgIGrid3.PageSelector = false;
            this.nsgIGrid3.ReadOnly = false;
            this.nsgIGrid3.RowChangeInterval = 200;
            this.nsgIGrid3.RowHeaderImageList = null;
            this.nsgIGrid3.RowMode = false;
            this.nsgIGrid3.ScrollWidth = 0;
            this.nsgIGrid3.SelectedRow = -1;
            this.nsgIGrid3.ShowHeader = true;
            this.nsgIGrid3.ShowLineImages = true;
            this.nsgIGrid3.ShowLineNumbers = false;
            this.nsgIGrid3.ShowPanel = true;
            this.nsgIGrid3.ShowTotals = false;
            this.nsgIGrid3.ShowTree = false;
            this.nsgIGrid3.Size = new System.Drawing.Size(818, 310);
            this.nsgIGrid3.SourceObject = this.vmo;
            this.nsgIGrid3.TabIndex = 1;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmo
            // 
            this.vmo.Columns.Collection.Add(this.ДатаПоследнейЗаправки);
            this.vmo.Columns.Collection.Add(this.Техника_vmo);
            this.vmo.Columns.Collection.Add(this.ОбъемЗаправки);
            this.vmo.IsActive = true;
            this.vmo.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmo.MetaDataName = "";
            this.vmo.FullName = "";
            // 
            // ДатаПоследнейЗаправки
            // 
            this.ДатаПоследнейЗаправки.Caption = "ДатаПоследнейЗаправки";
            this.ДатаПоследнейЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаПоследнейЗаправки.Name = "ДатаПоследнейЗаправки";
            this.ДатаПоследнейЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПоследнейЗаправки.PropertyType = typeof(System.DateTime);
            this.ДатаПоследнейЗаправки.SearchCondition.OwnerComponent = this.ДатаПоследнейЗаправки;
            this.ДатаПоследнейЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmo
            // 
            this.Техника_vmo.Caption = "Техника";
            this.Техника_vmo.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmo.Name = "Техника";
            this.Техника_vmo.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmo.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmo.SearchCondition.OwnerComponent = this.Техника_vmo;
            this.Техника_vmo.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемЗаправки
            // 
            this.ОбъемЗаправки.CalcTotal = false;
            this.ОбъемЗаправки.Caption = "ОбъемЗаправки";
            this.ОбъемЗаправки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемЗаправки.Name = "ОбъемЗаправки";
            this.ОбъемЗаправки.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемЗаправки.PropertyType = typeof(decimal);
            this.ОбъемЗаправки.SearchCondition.OwnerComponent = this.ОбъемЗаправки;
            this.ОбъемЗаправки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(6, 9);
            this.nsgButton1.Name = "NsgButton";
            this.nsgButton1.Size = new System.Drawing.Size(164, 57);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 10;
            this.nsgButton1.Text = "Получить данные с систем слижения";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(861, 418);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.nsgIGrid1);
            this.tabPage1.Controls.Add(this.nsgButton1);
            this.tabPage1.Enabled = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Получение данных с систем слежения";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.nsgIGrid2);
            this.tabPage2.Controls.Add(this.nsgButton2);
            this.tabPage2.Controls.Add(this.nsgPeriodPicker1);
            this.tabPage2.Enabled = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ данных самосвалов";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = true;
            // 
            // nsgButton2
            // 
            this.nsgButton2.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton2.Location = new System.Drawing.Point(234, 6);
            this.nsgButton2.Name = "NsgButton";
            this.nsgButton2.Size = new System.Drawing.Size(101, 36);
            this.nsgButton2.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton2.TabIndex = 1;
            this.nsgButton2.Text = "Получить данные";
            this.nsgButton2.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton2.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton2_AsyncClick);
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(16, 15);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.nsgPeriodPicker2);
            this.tabPage3.Controls.Add(this.nsgIGrid3);
            this.tabPage3.Controls.Add(this.nsgButton3);
            this.tabPage3.Enabled = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(853, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "test";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = false;
            // 
            // nsgPeriodPicker2
            // 
            this.nsgPeriodPicker2.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker2.Location = new System.Drawing.Point(142, 20);
            this.nsgPeriodPicker2.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker2.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker2.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker2.TabIndex = 2;
            // 
            // nsgButton3
            // 
            this.nsgButton3.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton3.Location = new System.Drawing.Point(27, 20);
            this.nsgButton3.Name = "NsgButton";
            this.nsgButton3.Size = new System.Drawing.Size(75, 36);
            this.nsgButton3.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton3.TabIndex = 0;
            this.nsgButton3.Text = "Получить данные";
            this.nsgButton3.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton3.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton3_AsyncClick);
            // 
            // НаименованиеГеозоны_vmoГеозоны
            // 
            this.НаименованиеГеозоны_vmoГеозоны.Caption = "НаименованиеГеозоны";
            this.НаименованиеГеозоны_vmoГеозоны.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НаименованиеГеозоны_vmoГеозоны.Name = "НаименованиеГеозоны";
            this.НаименованиеГеозоны_vmoГеозоны.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НаименованиеГеозоны_vmoГеозоны.PropertyType = typeof(string);
            this.НаименованиеГеозоны_vmoГеозоны.SearchCondition.OwnerComponent = this.НаименованиеГеозоны_vmoГеозоны;
            this.НаименованиеГеозоны_vmoГеозоны.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Долгота_vmoГеозоны
            // 
            this.Долгота_vmoГеозоны.CalcTotal = false;
            this.Долгота_vmoГеозоны.Caption = "Долгота";
            this.Долгота_vmoГеозоны.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Долгота_vmoГеозоны.Name = "Долгота";
            this.Долгота_vmoГеозоны.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Долгота_vmoГеозоны.PropertyType = typeof(decimal);
            this.Долгота_vmoГеозоны.SearchCondition.OwnerComponent = this.Долгота_vmoГеозоны;
            this.Долгота_vmoГеозоны.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Широта_vmoГеозоны
            // 
            this.Широта_vmoГеозоны.CalcTotal = false;
            this.Широта_vmoГеозоны.Caption = "Широта";
            this.Широта_vmoГеозоны.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Широта_vmoГеозоны.Name = "Широта";
            this.Широта_vmoГеозоны.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Широта_vmoГеозоны.PropertyType = typeof(decimal);
            this.Широта_vmoГеозоны.SearchCondition.OwnerComponent = this.Широта_vmoГеозоны;
            this.Широта_vmoГеозоны.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РадиусГеозоны
            // 
            this.РадиусГеозоны.CalcTotal = false;
            this.РадиусГеозоны.Caption = "РадиусГеозоны";
            this.РадиусГеозоны.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.РадиусГеозоны.Name = "РадиусГеозоны";
            this.РадиусГеозоны.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.РадиусГеозоны.PropertyType = typeof(decimal);
            this.РадиусГеозоны.SearchCondition.OwnerComponent = this.РадиусГеозоны;
            this.РадиусГеозоны.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПолучениеДанныхСПИКФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(867, 477);
            this.Controls.Add(this.tabControl1);
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
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСигнализации)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoАнализДанных)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NsgIGrid nsgIGrid1;
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected Техника.ColumnDescriptor Техника_vmoСигнализации;
        protected NsgColumnDescriptor.Decimal ВремяРаботыСкаут_vmoСигнализации;
        protected NsgColumnDescriptor.DateTime Дата_vmoСигнализации;
        protected NsgSoft.Design.NsgButton nsgButton2;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Техника.ColumnDescriptor Техника_vmoАнализДанных;
        protected Геозоны.ColumnDescriptor Геозона_vmoАнализДанных;
        private NsgIGrid nsgIGrid2;
        protected NsgColumnDescriptor.String НаименованиеГеозоны_vmoГеозоны;
        protected NsgColumnDescriptor.Decimal Долгота_vmoГеозоны;
        protected NsgColumnDescriptor.Decimal Широта_vmoГеозоны;
        protected NsgColumnDescriptor.Decimal ВремяРаботыДок_vmoСигнализации;
        protected NsgColumnDescriptor.Decimal ВремяРаботыСигнализации_vmoСигнализации;
        protected System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.TabPage tabPage2;
        protected NsgColumnDescriptor.DateTime ВремяПриездаВГеозону_vmoАнализДанных;
        protected NsgColumnDescriptor.Decimal РадиусГеозоны;
        private NsgVisualMultipleObject vmoСигнализации;
        private System.Windows.Forms.TabControl tabControl1;
        private NsgVisualMultipleObject vmoАнализДанных;
        private System.Windows.Forms.TabPage tabPage3;
        protected NsgSoft.Design.NsgButton nsgButton3;
        protected NsgPeriodPicker nsgPeriodPicker2;
        protected NsgColumnDescriptor.DateTime ДатаПоследнейЗаправки;
        protected Техника.ColumnDescriptor Техника_vmo;
        protected NsgColumnDescriptor.Decimal ОбъемЗаправки;
        protected Объекты.ColumnDescriptor Объект_vmoАнализДанных;
        protected NsgColumnDescriptor.DateTime ВремяПриездаНаОбъект_vmoАнализДанных;
        private NsgIGrid nsgIGrid3;
        private NsgVisualMultipleObject vmo;
    }
}