using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Грузы

{
    
    public partial class УправлениеПогрузкойРазгрузкойФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(УправлениеПогрузкойРазгрузкойФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
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
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСостояние = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpСостояние = new System.Windows.Forms.TabPage();
            this.tpРазгрузка = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.label5 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.tpПогрузка = new System.Windows.Forms.TabPage();
            this.nsgVisualMultipleObject2 = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.label9 = new System.Windows.Forms.Label();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.label10 = new System.Windows.Forms.Label();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.label11 = new System.Windows.Forms.Label();
            this.Техника_vmoСостояние = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Груз_vmoСостояние = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.Объем_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Номер_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаПриезда_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.НомерАвто = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ВыбраннаяТехника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВидГруза = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.ОбъемГруза = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Комментарий = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nbПогрузка = new NsgSoft.Design.NsgButton();
            this.nbРазгрузка = new NsgSoft.Design.NsgButton();
            this.ДатаПриезда = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояние)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpСостояние.SuspendLayout();
            this.tpРазгрузка.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            this.tpПогрузка.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbПогрузка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbРазгрузка)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 355);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(561, 30);
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
            this.printButton.IsActive = false;
            this.printButton.Location = new System.Drawing.Point(541, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 30);
            this.printButton.TabIndex = 1;
            this.printButton.Visible = false;
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерАвто);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВыбраннаяТехника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВидГруза);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъемГруза);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Комментарий);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаПриезда);
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
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.Name = "Техника";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn16.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn16.UseAsHeaderImage = false;
            nsgIGridColumn16.Width = 100;
            nsgIGridColumn17.AllowFilter = true;
            nsgIGridColumn17.AllowGroupSelect = false;
            nsgIGridColumn17.AllowResize = true;
            nsgIGridColumn17.AutoResize = true;
            nsgIGridColumn17.Caption = "";
            nsgIGridColumn17.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn17.DateFormat = null;
            nsgIGridColumn17.Name = "Груз";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn17.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn17.UseAsHeaderImage = false;
            nsgIGridColumn17.Width = 100;
            nsgIGridColumn18.AllowFilter = true;
            nsgIGridColumn18.AllowGroupSelect = false;
            nsgIGridColumn18.AllowResize = true;
            nsgIGridColumn18.AutoResize = true;
            nsgIGridColumn18.Caption = "";
            nsgIGridColumn18.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn18.DateFormat = null;
            nsgIGridColumn18.Name = "Объем";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn18.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn18.UseAsHeaderImage = false;
            nsgIGridColumn18.Width = 100;
            nsgIGridColumn19.AllowFilter = true;
            nsgIGridColumn19.AllowGroupSelect = false;
            nsgIGridColumn19.AllowResize = true;
            nsgIGridColumn19.AutoResize = true;
            nsgIGridColumn19.Caption = "";
            nsgIGridColumn19.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn19.DateFormat = null;
            nsgIGridColumn19.Name = "Номер";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn19.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn19.UseAsHeaderImage = false;
            nsgIGridColumn19.Width = 100;
            nsgIGridColumn20.AllowFilter = true;
            nsgIGridColumn20.AllowGroupSelect = false;
            nsgIGridColumn20.AllowResize = true;
            nsgIGridColumn20.AutoResize = true;
            nsgIGridColumn20.Caption = "";
            nsgIGridColumn20.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn20.DateFormat = null;
            nsgIGridColumn20.Name = "ДатаПриезда";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn20.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn20.UseAsHeaderImage = false;
            nsgIGridColumn20.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(3, 3);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(530, 272);
            this.nsgIGrid1.SourceObject = this.vmoСостояние;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.BeforeAction += new NsgSoft.Forms.NsgIGrid.NsgIGridCellActionEventHandler(this.nsgIGrid1_BeforeAction);
            // 
            // vmoСостояние
            // 
            this.vmoСостояние.Columns.Collection.Add(this.Техника_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Груз_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Объем_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Номер_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.ДатаПриезда_vmoСостояние);
            this.vmoСостояние.IsActive = true;
            this.vmoСостояние.CurrentRowChanged += new NsgSoft.Forms.CurrentRowChangedEventHandler(this.vmoСостояние_CurrentRowChanged);
            this.vmoСостояние.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСостояние.MetaDataName = "";
            this.vmoСостояние.FullName = "";
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
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.Name = "Техника";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn2.Name = "Груз";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Visible = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.Name = "Объем";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Visible = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "Номер";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Visible = false;
            nsgIGridColumn4.Width = 100;
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "ДатаПриезда";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Visible = false;
            nsgIGridColumn5.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(9, 3);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(165, 266);
            this.nsgIGrid2.SourceObject = this.vmoСостояние;
            this.nsgIGrid2.TabIndex = 0;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Объект";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Объект";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(70, 2);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "Объект";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(311, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 10;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput1.Selected += new System.EventHandler(this.nsgInput1_Selected);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpСостояние);
            this.tabControl1.Controls.Add(this.tpРазгрузка);
            this.tabControl1.Controls.Add(this.tpПогрузка);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(549, 304);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpСостояние
            // 
            this.tpСостояние.AllowDrop = true;
            this.tpСостояние.Controls.Add(this.nsgIGrid1);
            this.tpСостояние.Enabled = true;
            this.tpСостояние.Location = new System.Drawing.Point(4, 22);
            this.tpСостояние.Name = "tpСостояние";
            this.tpСостояние.Size = new System.Drawing.Size(541, 278);
            this.tpСостояние.TabIndex = 2;
            this.tpСостояние.Text = "Состояние";
            this.tpСостояние.UseVisualStyleBackColor = true;
            this.tpСостояние.Visible = false;
            // 
            // tpРазгрузка
            // 
            this.tpРазгрузка.AllowDrop = true;
            this.tpРазгрузка.Controls.Add(this.splitContainer1);
            this.tpРазгрузка.Enabled = true;
            this.tpРазгрузка.Location = new System.Drawing.Point(4, 22);
            this.tpРазгрузка.Name = "tpРазгрузка";
            this.tpРазгрузка.Padding = new System.Windows.Forms.Padding(3);
            this.tpРазгрузка.Size = new System.Drawing.Size(541, 278);
            this.tpРазгрузка.TabIndex = 0;
            this.tpРазгрузка.Text = "Разгрузка";
            this.tpРазгрузка.UseVisualStyleBackColor = true;
            this.tpРазгрузка.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.nsgIGrid2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.nbРазгрузка);
            this.splitContainer1.Panel2.Controls.Add(this.nsgInput6);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.nsgInput5);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.nsgInput4);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.nsgInput3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.nsgInput2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(535, 272);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Комментарий";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsMultiline = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(92, 122);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Комментарий";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(248, 58);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 9;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label2";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Комментарий";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "ОбъекмГруза";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(92, 93);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "ОбъекмГруза";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(122, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 7;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label2";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Объем";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "ВидГруза";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(92, 63);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ВидГруза";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(248, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 5;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label2";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Груз";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "НомерАвто";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(92, 34);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "НомерАвто";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(122, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 3;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label2";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер авто";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "ВыбраннаяТехника";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(92, 5);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ВыбраннаяТехника";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(248, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 1;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Техника";
            // 
            // tpПогрузка
            // 
            this.tpПогрузка.AllowDrop = true;
            this.tpПогрузка.Controls.Add(this.splitContainer2);
            this.tpПогрузка.Enabled = true;
            this.tpПогрузка.Location = new System.Drawing.Point(4, 22);
            this.tpПогрузка.Name = "tpПогрузка";
            this.tpПогрузка.Padding = new System.Windows.Forms.Padding(3);
            this.tpПогрузка.Size = new System.Drawing.Size(541, 278);
            this.tpПогрузка.TabIndex = 1;
            this.tpПогрузка.Text = "Погрузка";
            this.tpПогрузка.UseVisualStyleBackColor = true;
            this.tpПогрузка.Visible = true;
            // 
            // nsgVisualMultipleObject2
            // 
            this.nsgVisualMultipleObject2.MetaDataName = "";
            this.nsgVisualMultipleObject2.FullName = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.Controls.Add(this.nsgIGrid3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AllowDrop = true;
            this.splitContainer2.Panel2.Controls.Add(this.nbПогрузка);
            this.splitContainer2.Panel2.Controls.Add(this.nsgInput7);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.nsgInput8);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.nsgInput9);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.nsgInput10);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.nsgInput11);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Size = new System.Drawing.Size(535, 272);
            this.splitContainer2.SplitterDistance = 178;
            this.splitContainer2.TabIndex = 0;
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
            nsgIGridColumn6.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn7.Name = "Груз";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Visible = false;
            nsgIGridColumn7.Width = 100;
            nsgIGridColumn8.AllowFilter = true;
            nsgIGridColumn8.AllowGroupSelect = false;
            nsgIGridColumn8.AllowResize = true;
            nsgIGridColumn8.AutoResize = true;
            nsgIGridColumn8.Caption = "";
            nsgIGridColumn8.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "Объем";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Visible = false;
            nsgIGridColumn8.Width = 100;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.Name = "Номер";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Visible = false;
            nsgIGridColumn9.Width = 100;
            nsgIGridColumn10.AllowFilter = true;
            nsgIGridColumn10.AllowGroupSelect = false;
            nsgIGridColumn10.AllowResize = true;
            nsgIGridColumn10.AutoResize = true;
            nsgIGridColumn10.Caption = "";
            nsgIGridColumn10.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.Name = "ДатаПриезда";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Visible = false;
            nsgIGridColumn10.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(3, 3);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(172, 266);
            this.nsgIGrid3.SourceObject = this.vmoСостояние;
            this.nsgIGrid3.TabIndex = 0;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Комментарий";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsMultiline = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(83, 123);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "Комментарий";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(248, 58);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 19;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label2";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Комментарий";
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "ОбъекмГруза";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(83, 94);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "ОбъекмГруза";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(122, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 17;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput8.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput8_EndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label2";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Объем";
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "ВидГруза";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(83, 64);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "ВидГруза";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(248, 20);
            this.nsgInput9.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput9.TabIndex = 15;
            this.nsgInput9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput9.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput9_EndEdit);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label2";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Груз";
            // 
            // nsgInput10
            // 
            this.nsgInput10.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput10.ConfigurationName = "";
            this.nsgInput10.DisableLeaveControlEvent = false;
            this.nsgInput10.FullName = "НомерАвто";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(83, 35);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "НомерАвто";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(122, 20);
            this.nsgInput10.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput10.TabIndex = 13;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label2";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Номер авто";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "ВыбраннаяТехника";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(83, 6);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "ВыбраннаяТехника";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(248, 20);
            this.nsgInput11.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput11.TabIndex = 11;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label2";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Техника";
            // 
            // Техника_vmoСостояние
            // 
            this.Техника_vmoСостояние.Caption = "Техника";
            this.Техника_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoСостояние.Name = "Техника";
            this.Техника_vmoСостояние.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСостояние.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСостояние.ReadOnly = true;
            this.Техника_vmoСостояние.SearchCondition.OwnerComponent = this.Техника_vmoСостояние;
            this.Техника_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Груз_vmoСостояние
            // 
            this.Груз_vmoСостояние.Caption = "Груз";
            this.Груз_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Груз_vmoСостояние.Name = "Груз";
            this.Груз_vmoСостояние.NSGType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.Груз_vmoСостояние.PropertyType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.Груз_vmoСостояние.ReadOnly = true;
            this.Груз_vmoСостояние.SearchCondition.OwnerComponent = this.Груз_vmoСостояние;
            this.Груз_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объем_vmoСостояние
            // 
            this.Объем_vmoСостояние.CalcTotal = false;
            this.Объем_vmoСостояние.Caption = "Объем";
            this.Объем_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объем_vmoСостояние.Name = "Объем";
            this.Объем_vmoСостояние.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Объем_vmoСостояние.PropertyType = typeof(decimal);
            this.Объем_vmoСостояние.ReadOnly = true;
            this.Объем_vmoСостояние.SearchCondition.OwnerComponent = this.Объем_vmoСостояние;
            this.Объем_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номер_vmoСостояние
            // 
            this.Номер_vmoСостояние.Caption = "Номер";
            this.Номер_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номер_vmoСостояние.Name = "Номер";
            this.Номер_vmoСостояние.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Номер_vmoСостояние.PropertyType = typeof(string);
            this.Номер_vmoСостояние.ReadOnly = true;
            this.Номер_vmoСостояние.SearchCondition.OwnerComponent = this.Номер_vmoСостояние;
            this.Номер_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаПриезда_vmoСостояние
            // 
            this.ДатаПриезда_vmoСостояние.Caption = "ДатаПриезда";
            this.ДатаПриезда_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаПриезда_vmoСостояние.Name = "ДатаПриезда";
            this.ДатаПриезда_vmoСостояние.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПриезда_vmoСостояние.PropertyType = typeof(System.DateTime);
            this.ДатаПриезда_vmoСостояние.ReadOnly = true;
            this.ДатаПриезда_vmoСостояние.SearchCondition.OwnerComponent = this.ДатаПриезда_vmoСостояние;
            this.ДатаПриезда_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // НомерАвто
            // 
            this.НомерАвто.Caption = "НомерАвто";
            this.НомерАвто.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерАвто.Name = "НомерАвто";
            this.НомерАвто.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерАвто.PropertyType = typeof(string);
            this.НомерАвто.SearchCondition.OwnerComponent = this.НомерАвто;
            this.НомерАвто.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВыбраннаяТехника
            // 
            this.ВыбраннаяТехника.Caption = "ВыбраннаяТехника";
            this.ВыбраннаяТехника.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВыбраннаяТехника.Name = "ВыбраннаяТехника";
            this.ВыбраннаяТехника.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ВыбраннаяТехника.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ВыбраннаяТехника.SearchCondition.OwnerComponent = this.ВыбраннаяТехника;
            this.ВыбраннаяТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВидГруза
            // 
            this.ВидГруза.Caption = "ВидГруза";
            this.ВидГруза.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВидГруза.Name = "ВидГруза";
            this.ВидГруза.NSGType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ВидГруза.PropertyType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ВидГруза.SearchCondition.OwnerComponent = this.ВидГруза;
            this.ВидГруза.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемГруза
            // 
            this.ОбъемГруза.CalcTotal = false;
            this.ОбъемГруза.Caption = "ОбъекмГруза";
            this.ОбъемГруза.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемГруза.Name = "ОбъекмГруза";
            this.ОбъемГруза.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемГруза.PropertyType = typeof(decimal);
            this.ОбъемГруза.SearchCondition.OwnerComponent = this.ОбъемГруза;
            this.ОбъемГруза.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комментарий
            // 
            this.Комментарий.Caption = "Комментарий";
            this.Комментарий.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комментарий.Name = "Комментарий";
            this.Комментарий.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Комментарий.PropertyType = typeof(string);
            this.Комментарий.SearchCondition.OwnerComponent = this.Комментарий;
            this.Комментарий.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nbПогрузка
            // 
            this.nbПогрузка.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbПогрузка.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbПогрузка.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbПогрузка.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbПогрузка.Location = new System.Drawing.Point(6, 244);
            this.nbПогрузка.Name = "NsgButton";
            this.nbПогрузка.Size = new System.Drawing.Size(125, 25);
            this.nbПогрузка.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbПогрузка.TabIndex = 20;
            this.nbПогрузка.Text = "Оформить погрузку";
            this.nbПогрузка.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbПогрузка.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbПогрузка_AsyncClick);
            // 
            // nbРазгрузка
            // 
            this.nbРазгрузка.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbРазгрузка.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbРазгрузка.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbРазгрузка.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbРазгрузка.Location = new System.Drawing.Point(4, 244);
            this.nbРазгрузка.Name = "NsgButton";
            this.nbРазгрузка.Size = new System.Drawing.Size(126, 25);
            this.nbРазгрузка.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbРазгрузка.TabIndex = 10;
            this.nbРазгрузка.Text = "Оформить разгрузку";
            this.nbРазгрузка.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbРазгрузка.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbРазгрузка_AsyncClick);
            // 
            // ДатаПриезда
            // 
            this.ДатаПриезда.Caption = "ДатаПриезда";
            this.ДатаПриезда.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаПриезда.Name = "ДатаПриезда";
            this.ДатаПриезда.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПриезда.PropertyType = typeof(System.DateTime);
            this.ДатаПриезда.SearchCondition.OwnerComponent = this.ДатаПриезда;
            this.ДатаПриезда.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // УправлениеПогрузкойРазгрузкойФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(561, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nsgInput1);
            this.Controls.Add(this.label1);
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
            this.UseDefaultButtons = false;
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояние)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpСостояние.ResumeLayout(false);
            this.tpРазгрузка.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            this.tpПогрузка.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbПогрузка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbРазгрузка)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgInput nsgInput1;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoСостояние;
        protected NsgVisualMultipleObject nsgVisualMultipleObject2;
        protected ВидыГрузов.ColumnDescriptor Груз_vmoСостояние;
        protected NsgColumnDescriptor.Decimal Объем_vmoСостояние;
        protected NsgColumnDescriptor.String Номер_vmoСостояние;
        protected NsgColumnDescriptor.DateTime ДатаПриезда_vmoСостояние;
        protected NsgIGrid nsgIGrid2;
        private NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.String НомерАвто;
        protected Мониторинг.Техника.ColumnDescriptor ВыбраннаяТехника;
        protected NsgColumnDescriptor.String Комментарий;
        protected ВидыГрузов.ColumnDescriptor ВидГруза;
        protected NsgColumnDescriptor.Decimal ОбъемГруза;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.Label label6;
        protected NsgInput nsgInput5;
        protected System.Windows.Forms.Label label5;
        protected NsgInput nsgInput4;
        protected System.Windows.Forms.Label label4;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        protected NsgInput nsgInput2;
        protected NsgIGrid nsgIGrid3;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label8;
        protected NsgInput nsgInput9;
        protected System.Windows.Forms.Label label9;
        protected NsgInput nsgInput10;
        protected System.Windows.Forms.Label label10;
        protected NsgInput nsgInput11;
        protected System.Windows.Forms.Label label11;
        protected NsgSoft.Design.NsgButton nbРазгрузка;
        protected NsgSoft.Design.NsgButton nbПогрузка;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tpРазгрузка;
        protected System.Windows.Forms.TabPage tpПогрузка;
        protected System.Windows.Forms.TabPage tpСостояние;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected NsgVisualMultipleObject vmoСостояние;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.SplitContainer splitContainer2;
        protected NsgColumnDescriptor.DateTime ДатаПриезда;
    }
}