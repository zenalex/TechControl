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
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСигнализации = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Техника_vmoСигнализации = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВремяРаботыСкаут_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВремяРаботыДок_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВремяРаботыСигнализации_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дата_vmoСигнализации = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.nsgButton2 = new NsgSoft.Design.NsgButton();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.vmoАнализДанных = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Техника_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВремяПриездаНаОбъект_vmoАнализДанных = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Объект_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ВремяПриезда_vmoАнализДанных = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяВыезда_vmoАнализДанных = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Геозона2_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Геозоны.ColumnDescriptor();
            this.Геозона1_vmoАнализДанных = new TechControl.Метаданные.Мониторинг.Геозоны.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСигнализации)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoАнализДанных)).BeginInit();
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
            this.nsgIGrid1.Size = new System.Drawing.Size(829, 305);
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
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(849, 409);
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
            this.tabPage1.Size = new System.Drawing.Size(841, 383);
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
            this.tabPage2.Size = new System.Drawing.Size(841, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = true;
            // 
            // nsgIGrid2
            // 
            this.nsgIGrid2.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid2.AllowSaveColParamsToXML = true;
            this.nsgIGrid2.AllowSaveColPositionToXML = true;
            this.nsgIGrid2.AllowSaveColWidthToXML = true;
            this.nsgIGrid2.AllowSaveSettingsToXML = true;
            this.nsgIGrid2.AutoResizeCols = true;
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(16, 57);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(819, 307);
            this.nsgIGrid2.SourceObject = null;
            this.nsgIGrid2.TabIndex = 2;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
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
            // vmoАнализДанных
            // 
            this.vmoАнализДанных.Columns.Collection.Add(this.Техника_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.Геозона1_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.Геозона2_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.ВремяВыезда_vmoАнализДанных);
            this.vmoАнализДанных.Columns.Collection.Add(this.ВремяПриезда_vmoАнализДанных);
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
            // ВремяПриезда_vmoАнализДанных
            // 
            this.ВремяПриезда_vmoАнализДанных.Caption = "ВремяПриезда";
            this.ВремяПриезда_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяПриезда_vmoАнализДанных.Name = "ВремяПриезда";
            this.ВремяПриезда_vmoАнализДанных.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяПриезда_vmoАнализДанных.PropertyType = typeof(System.DateTime);
            this.ВремяПриезда_vmoАнализДанных.SearchCondition.OwnerComponent = this.ВремяПриезда_vmoАнализДанных;
            this.ВремяПриезда_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяВыезда_vmoАнализДанных
            // 
            this.ВремяВыезда_vmoАнализДанных.Caption = "ВремяВыезда";
            this.ВремяВыезда_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяВыезда_vmoАнализДанных.Name = "ВремяВыезда";
            this.ВремяВыезда_vmoАнализДанных.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяВыезда_vmoАнализДанных.PropertyType = typeof(System.DateTime);
            this.ВремяВыезда_vmoАнализДанных.SearchCondition.OwnerComponent = this.ВремяВыезда_vmoАнализДанных;
            this.ВремяВыезда_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Геозона2_vmoАнализДанных
            // 
            this.Геозона2_vmoАнализДанных.Caption = "Геозона2";
            this.Геозона2_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Геозона2_vmoАнализДанных.Name = "Геозона2";
            this.Геозона2_vmoАнализДанных.NSGType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона2_vmoАнализДанных.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона2_vmoАнализДанных.SearchCondition.OwnerComponent = this.Геозона2_vmoАнализДанных;
            this.Геозона2_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Геозона1_vmoАнализДанных
            // 
            this.Геозона1_vmoАнализДанных.Caption = "Геозона1";
            this.Геозона1_vmoАнализДанных.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Геозона1_vmoАнализДанных.Name = "Геозона1";
            this.Геозона1_vmoАнализДанных.NSGType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона1_vmoАнализДанных.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона1_vmoАнализДанных.SearchCondition.OwnerComponent = this.Геозона1_vmoАнализДанных;
            this.Геозона1_vmoАнализДанных.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoАнализДанных)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NsgIGrid nsgIGrid1;
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected Техника.ColumnDescriptor Техника_vmoСигнализации;
        protected NsgColumnDescriptor.Decimal ВремяРаботыСкаут_vmoСигнализации;
        private NsgColumnDescriptor.Decimal ВремяРаботыДок_vmoСигнализации;
        private NsgColumnDescriptor.Decimal ВремяРаботыСигнализации_vmoСигнализации;
        private NsgVisualMultipleObject vmoСигнализации;
        protected NsgColumnDescriptor.DateTime Дата_vmoСигнализации;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        protected NsgIGrid nsgIGrid2;
        protected NsgSoft.Design.NsgButton nsgButton2;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Техника.ColumnDescriptor Техника_vmoАнализДанных;
        private NsgVisualMultipleObject vmoАнализДанных;
        protected Геозоны.ColumnDescriptor Геозона1_vmoАнализДанных;
        private Геозоны.ColumnDescriptor Геозона2_vmoАнализДанных;
        private NsgColumnDescriptor.DateTime ВремяВыезда_vmoАнализДанных;
        private NsgColumnDescriptor.DateTime ВремяПриезда_vmoАнализДанных;
        private Объекты.ColumnDescriptor Объект_vmoАнализДанных;
        private NsgColumnDescriptor.DateTime ВремяПриездаНаОбъект_vmoАнализДанных;
    }
}