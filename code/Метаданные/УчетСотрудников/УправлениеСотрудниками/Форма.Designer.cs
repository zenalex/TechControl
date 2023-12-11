using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.УчетСотрудников

{
    
    public partial class УправлениеСотрудникамиФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(УправлениеСотрудникамиФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.НачалоСмены_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Длительность_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сотрудник_vmoТаблица = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Тариф_vmoТаблица = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Техника_vmoТаблица = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект_vmoТаблица = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.дата_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Должность_vmoТаблица = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpФормирование = new System.Windows.Forms.TabPage();
            this.nbСформироватьСмену = new NsgSoft.Design.NsgButton();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Дата = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.НомерСмены = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.НомерСмены_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpФормирование.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbСформироватьСмену)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 448);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(788, 30);
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
            this.printButton.Location = new System.Drawing.Point(768, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Дата);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерСмены);
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
            nsgIGridColumn1.Name = "НачалоСмены";
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
            nsgIGridColumn2.Name = "Длительность ч.";
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
            nsgIGridColumn3.Name = "Сотрудник";
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
            nsgIGridColumn4.Name = "Тариф";
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
            nsgIGridColumn5.Name = "Техника";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            nsgIGridColumn6.AllowFilter = true;
            nsgIGridColumn6.AllowGroupSelect = false;
            nsgIGridColumn6.AllowResize = true;
            nsgIGridColumn6.AutoResize = true;
            nsgIGridColumn6.Caption = "";
            nsgIGridColumn6.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Name = "Объект";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            nsgIGridColumn7.AllowFilter = true;
            nsgIGridColumn7.AllowGroupSelect = false;
            nsgIGridColumn7.AllowResize = true;
            nsgIGridColumn7.AutoResize = true;
            nsgIGridColumn7.Caption = "";
            nsgIGridColumn7.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "Должность";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 101);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(762, 306);
            this.nsgIGrid1.SourceObject = this.vmoТаблица;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            this.nsgIGrid1.AfterAction += new NsgSoft.Forms.NsgIGrid.NsgIGridCellActionEventHandler(this.nsgIGrid1_AfterAction);
            // 
            // vmoТаблица
            // 
            this.vmoТаблица.Columns.Collection.Add(this.НачалоСмены_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Длительность_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Сотрудник_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Тариф_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Техника_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Объект_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.дата_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Должность_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.НомерСмены_vmoТаблица);
            this.vmoТаблица.IsActive = true;
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблица.MetaDataName = "";
            this.vmoТаблица.FullName = "";
            // 
            // НачалоСмены_vmoТаблица
            // 
            this.НачалоСмены_vmoТаблица.Caption = "НачалоСмены";
            this.НачалоСмены_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НачалоСмены_vmoТаблица.Name = "НачалоСмены";
            this.НачалоСмены_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.НачалоСмены_vmoТаблица.PropertyType = typeof(System.DateTime);
            this.НачалоСмены_vmoТаблица.SearchCondition.OwnerComponent = this.НачалоСмены_vmoТаблица;
            this.НачалоСмены_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Длительность_vmoТаблица
            // 
            this.Длительность_vmoТаблица.CalcTotal = false;
            this.Длительность_vmoТаблица.Caption = "Длительность ч.";
            this.Длительность_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Длительность_vmoТаблица.Name = "Длительность ч.";
            this.Длительность_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Длительность_vmoТаблица.PropertyType = typeof(decimal);
            this.Длительность_vmoТаблица.SearchCondition.OwnerComponent = this.Длительность_vmoТаблица;
            this.Длительность_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoТаблица
            // 
            this.Сотрудник_vmoТаблица.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoТаблица.Name = "Сотрудник";
            this.Сотрудник_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблица.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблица;
            this.Сотрудник_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТаблица
            // 
            this.Тариф_vmoТаблица.Caption = "Тариф";
            this.Тариф_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_vmoТаблица.Name = "Тариф";
            this.Тариф_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.SearchCondition.OwnerComponent = this.Тариф_vmoТаблица;
            this.Тариф_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoТаблица
            // 
            this.Техника_vmoТаблица.Caption = "Техника";
            this.Техника_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoТаблица.Name = "Техника";
            this.Техника_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoТаблица.SearchCondition.OwnerComponent = this.Техника_vmoТаблица;
            this.Техника_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoТаблица
            // 
            this.Объект_vmoТаблица.Caption = "Объект";
            this.Объект_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoТаблица.Name = "Объект";
            this.Объект_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблица.SearchCondition.OwnerComponent = this.Объект_vmoТаблица;
            this.Объект_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Объект_vmoТаблица.Visible = false;
            // 
            // дата_vmoТаблица
            // 
            this.дата_vmoТаблица.Caption = "Дата";
            this.дата_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.дата_vmoТаблица.Name = "Дата";
            this.дата_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.дата_vmoТаблица.PropertyType = typeof(System.DateTime);
            this.дата_vmoТаблица.SearchCondition.OwnerComponent = this.дата_vmoТаблица;
            this.дата_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.дата_vmoТаблица.Visible = false;
            // 
            // Должность_vmoТаблица
            // 
            this.Должность_vmoТаблица.Caption = "Должность";
            this.Должность_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoТаблица.Name = "Должность";
            this.Должность_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблица.SearchCondition.OwnerComponent = this.Должность_vmoТаблица;
            this.Должность_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpФормирование);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 439);
            this.tabControl1.TabIndex = 9;
            // 
            // tpФормирование
            // 
            this.tpФормирование.AllowDrop = true;
            this.tpФормирование.Controls.Add(this.nsgInput3);
            this.tpФормирование.Controls.Add(this.label3);
            this.tpФормирование.Controls.Add(this.nbСформироватьСмену);
            this.tpФормирование.Controls.Add(this.nbЗаполнить);
            this.tpФормирование.Controls.Add(this.nsgInput2);
            this.tpФормирование.Controls.Add(this.nsgInput1);
            this.tpФормирование.Controls.Add(this.label2);
            this.tpФормирование.Controls.Add(this.label1);
            this.tpФормирование.Controls.Add(this.nsgIGrid1);
            this.tpФормирование.Enabled = true;
            this.tpФормирование.Location = new System.Drawing.Point(4, 22);
            this.tpФормирование.Name = "tpФормирование";
            this.tpФормирование.Padding = new System.Windows.Forms.Padding(3);
            this.tpФормирование.Size = new System.Drawing.Size(774, 413);
            this.tpФормирование.TabIndex = 0;
            this.tpФормирование.Text = "Формирование смены";
            this.tpФормирование.UseVisualStyleBackColor = true;
            this.tpФормирование.Visible = true;
            // 
            // nbСформироватьСмену
            // 
            this.nbСформироватьСмену.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbСформироватьСмену.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbСформироватьСмену.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbСформироватьСмену.Location = new System.Drawing.Point(475, 39);
            this.nbСформироватьСмену.Name = "NsgButton";
            this.nbСформироватьСмену.Size = new System.Drawing.Size(128, 25);
            this.nbСформироватьСмену.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbСформироватьСмену.TabIndex = 6;
            this.nbСформироватьСмену.Text = "Сформировать смену";
            this.nbСформироватьСмену.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbСформироватьСмену.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbСформироватьСмену_AsyncClick);
            // 
            // nbЗаполнить
            // 
            this.nbЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнить.Location = new System.Drawing.Point(474, 7);
            this.nbЗаполнить.Name = "NsgButton";
            this.nbЗаполнить.Size = new System.Drawing.Size(129, 25);
            this.nbЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнить.TabIndex = 5;
            this.nbЗаполнить.Text = "Заполнить";
            this.nbЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнить_AsyncClick);
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Объект";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(88, 39);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Объект";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(331, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 4;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Дата";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(88, 7);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "Дата";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(130, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 3;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Объект";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Enabled = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = false;
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
            // Дата
            // 
            this.Дата.Caption = "Дата";
            this.Дата.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дата.Name = "Дата";
            this.Дата.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Дата.PropertyType = typeof(System.DateTime);
            this.Дата.SearchCondition.OwnerComponent = this.Дата;
            this.Дата.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "НомерСмены";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(88, 64);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "НомерСмены";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(72, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 8;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput3.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput3_EndEdit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label2";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер смены";
            // 
            // НомерСмены
            // 
            this.НомерСмены.CalcTotal = false;
            this.НомерСмены.Caption = "НомерСмены";
            this.НомерСмены.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерСмены.Name = "НомерСмены";
            this.НомерСмены.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСмены.PropertyType = typeof(long);
            this.НомерСмены.SearchCondition.OwnerComponent = this.НомерСмены;
            this.НомерСмены.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСмены_vmoТаблица
            // 
            this.НомерСмены_vmoТаблица.CalcTotal = false;
            this.НомерСмены_vmoТаблица.Caption = "НомерСмены";
            this.НомерСмены_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерСмены_vmoТаблица.Name = "НомерСмены";
            this.НомерСмены_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСмены_vmoТаблица.PropertyType = typeof(long);
            this.НомерСмены_vmoТаблица.SearchCondition.OwnerComponent = this.НомерСмены_vmoТаблица;
            this.НомерСмены_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // УправлениеСотрудникамиФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(788, 498);
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
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpФормирование.ResumeLayout(false);
            this.tpФормирование.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbСформироватьСмену)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgColumnDescriptor.DateTime Дата;
        protected NsgInput nsgInput2;
        protected NsgInput nsgInput1;
        protected System.Windows.Forms.Label label2;
        protected NsgSoft.Design.NsgButton nbЗаполнить;
        protected NsgColumnDescriptor.DateTime НачалоСмены_vmoТаблица;
        protected NsgColumnDescriptor.Decimal Длительность_vmoТаблица;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoТаблица;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoТаблица;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoТаблица;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoТаблица;
        protected NsgColumnDescriptor.DateTime дата_vmoТаблица;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoТаблица;
        protected NsgSoft.Design.NsgButton nbСформироватьСмену;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpФормирование;
        private NsgVisualMultipleObject vmoТаблица;
        protected NsgColumnDescriptor.Int64 НомерСмены;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        private NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.Int64 НомерСмены_vmoТаблица;
    }
}