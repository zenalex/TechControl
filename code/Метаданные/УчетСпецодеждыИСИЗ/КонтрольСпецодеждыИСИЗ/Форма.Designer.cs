using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ

{
    
    public partial class КонтрольСпецодеждыИСИЗФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(КонтрольСпецодеждыИСИЗФорма));
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
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСотрудники = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Сотрудник_vmoСотрудники = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Подразделение_vmoСотрудники = new TechControl.Метаданные.Мониторинг.Подразделения.ColumnDescriptor();
            this.Проблема_vmoСотрудники = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmoКомплекты = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Комплект_vmoКомплекты = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Выбрано_vmoКомплекты = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСписокСпецодежды = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoСписокСпецодежды = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Комплект_vmoСписокСпецодежды = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.КоличествоВыданоРанее_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.КоличествоВыдать_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.КоличествоНаСкладе_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Размер_vmoСписокСпецодежды = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.Выдать_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpВыдача = new System.Windows.Forms.TabPage();
            this.nsgButton2 = new NsgSoft.Design.NsgButton();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nbВыдать = new NsgSoft.Design.NsgButton();
            this.tpОтчеты = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbСпецодежда = new NsgSoft.Design.NsgButton();
            this.nbЗакупки = new NsgSoft.Design.NsgButton();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Сотрудник_vmoФильтр = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.tpСотрудники = new System.Windows.Forms.TabPage();
            this.nbПроблемныеСотрудники = new NsgSoft.Design.NsgButton();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ДатаНачалаЭксплуатации = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ЗаказаноУПоставщикаКоличество = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСотрудники)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКомплекты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСписокСпецодежды)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpВыдача.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).BeginInit();
            this.tpОтчеты.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbСпецодежда)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗакупки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            this.tpСотрудники.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbПроблемныеСотрудники)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 511);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(879, 30);
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
            this.printButton.Location = new System.Drawing.Point(859, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаНачалаЭксплуатации);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
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
            nsgIGridColumn1.Name = "Сотрудник";
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
            nsgIGridColumn2.Name = "Подразделение";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(3, 32);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(860, 444);
            this.nsgIGrid2.SourceObject = this.vmoСотрудники;
            this.nsgIGrid2.TabIndex = 0;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoСотрудники
            // 
            this.vmoСотрудники.Columns.Collection.Add(this.Сотрудник_vmoСотрудники);
            this.vmoСотрудники.Columns.Collection.Add(this.Подразделение_vmoСотрудники);
            this.vmoСотрудники.Columns.Collection.Add(this.Проблема_vmoСотрудники);
            this.vmoСотрудники.IsActive = true;
            this.vmoСотрудники.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСотрудники.MetaDataName = "";
            this.vmoСотрудники.FullName = "";
            // 
            // Сотрудник_vmoСотрудники
            // 
            this.Сотрудник_vmoСотрудники.Caption = "Сотрудник";
            this.Сотрудник_vmoСотрудники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoСотрудники.Name = "Сотрудник";
            this.Сотрудник_vmoСотрудники.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoСотрудники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoСотрудники.ReadOnly = true;
            this.Сотрудник_vmoСотрудники.SearchCondition.OwnerComponent = this.Сотрудник_vmoСотрудники;
            this.Сотрудник_vmoСотрудники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подразделение_vmoСотрудники
            // 
            this.Подразделение_vmoСотрудники.Caption = "Подразделение";
            this.Подразделение_vmoСотрудники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подразделение_vmoСотрудники.Name = "Подразделение";
            this.Подразделение_vmoСотрудники.NSGType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_vmoСотрудники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение_vmoСотрудники.ReadOnly = true;
            this.Подразделение_vmoСотрудники.SearchCondition.OwnerComponent = this.Подразделение_vmoСотрудники;
            this.Подразделение_vmoСотрудники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Проблема_vmoСотрудники
            // 
            this.Проблема_vmoСотрудники.Caption = "Проблема";
            this.Проблема_vmoСотрудники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Проблема_vmoСотрудники.Name = "Проблема";
            this.Проблема_vmoСотрудники.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Проблема_vmoСотрудники.PropertyType = typeof(string);
            this.Проблема_vmoСотрудники.ReadOnly = true;
            this.Проблема_vmoСотрудники.SearchCondition.OwnerComponent = this.Проблема_vmoСотрудники;
            this.Проблема_vmoСотрудники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.Name = "Комплект";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn4.Name = "Выбрано";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = false;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(350, 7);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(502, 201);
            this.nsgIGrid3.SourceObject = this.vmoКомплекты;
            this.nsgIGrid3.TabIndex = 9;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid3.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid3_CellEndEdit);
            // 
            // vmoКомплекты
            // 
            this.vmoКомплекты.Columns.Collection.Add(this.Комплект_vmoКомплекты);
            this.vmoКомплекты.Columns.Collection.Add(this.Выбрано_vmoКомплекты);
            this.vmoКомплекты.IsActive = true;
            this.vmoКомплекты.GetAvailableTools += new NsgSoft.Forms.GetActionToolsEventHandler(this.vmoКомплекты_GetAvailableTools);
            this.vmoКомплекты.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoКомплекты.MetaDataName = "";
            this.vmoКомплекты.FullName = "";
            // 
            // Комплект_vmoКомплекты
            // 
            this.Комплект_vmoКомплекты.Caption = "Комплект";
            this.Комплект_vmoКомплекты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комплект_vmoКомплекты.Name = "Комплект";
            this.Комплект_vmoКомплекты.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoКомплекты.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoКомплекты.ReadOnly = true;
            this.Комплект_vmoКомплекты.SearchCondition.OwnerComponent = this.Комплект_vmoКомплекты;
            this.Комплект_vmoКомплекты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Выбрано_vmoКомплекты
            // 
            this.Выбрано_vmoКомплекты.Caption = "Выбрано";
            this.Выбрано_vmoКомплекты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выбрано_vmoКомплекты.Name = "Выбрано";
            this.Выбрано_vmoКомплекты.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выбрано_vmoКомплекты.PropertyType = typeof(bool);
            this.Выбрано_vmoКомплекты.SearchCondition.OwnerComponent = this.Выбрано_vmoКомплекты;
            this.Выбрано_vmoКомплекты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "Номенкатура";
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
        "Visible",
        "Index"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Name = "Комплект";
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
        "Visible",
        "Index"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "Размер";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn8.Name = "ТребуетсяПоКомплекту";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            nsgIGridColumn9.Name = "КоличествоНаСкладе";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.Name = "УжеЗаказаноКоличество";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Width = 100;
            nsgIGridColumn11.AllowFilter = true;
            nsgIGridColumn11.AllowGroupSelect = false;
            nsgIGridColumn11.AllowResize = true;
            nsgIGridColumn11.AutoResize = true;
            nsgIGridColumn11.Caption = "";
            nsgIGridColumn11.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn11.DateFormat = null;
            nsgIGridColumn11.Name = "КоличествоВыданоРанее";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            nsgIGridColumn12.Name = "ВсегоЗаконченСрок";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn12.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn12.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn12.UseAsHeaderImage = false;
            nsgIGridColumn12.Width = 100;
            nsgIGridColumn13.AllowFilter = true;
            nsgIGridColumn13.AllowGroupSelect = false;
            nsgIGridColumn13.AllowResize = true;
            nsgIGridColumn13.AutoResize = true;
            nsgIGridColumn13.Caption = "";
            nsgIGridColumn13.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn13.DateFormat = null;
            nsgIGridColumn13.Name = "КоличествоВыдать";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn13.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn13.UseAsHeaderImage = false;
            nsgIGridColumn13.Width = 100;
            nsgIGridColumn14.AllowFilter = true;
            nsgIGridColumn14.AllowGroupSelect = false;
            nsgIGridColumn14.AllowResize = true;
            nsgIGridColumn14.AutoResize = true;
            nsgIGridColumn14.Caption = "";
            nsgIGridColumn14.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn14.DateFormat = null;
            nsgIGridColumn14.Name = "Выдать";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn14);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(849, 201);
            this.nsgIGrid1.SourceObject = this.vmoСписокСпецодежды;
            this.nsgIGrid1.TabIndex = 2;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellEndEdit);
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            // 
            // vmoСписокСпецодежды
            // 
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Номенклатура_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Комплект_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.КоличествоВыданоРанее_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.ВсегоЗаконченСрок_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.КоличествоВыдать_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.ТребуетсяПоКомплекту_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.КоличествоНаСкладе_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Размер_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Выдать_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.ЗаказаноУПоставщикаКоличество);
            this.vmoСписокСпецодежды.IsActive = true;
            this.vmoСписокСпецодежды.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСписокСпецодежды.MetaDataName = "";
            this.vmoСписокСпецодежды.FullName = "";
            // 
            // Номенклатура_vmoСписокСпецодежды
            // 
            this.Номенклатура_vmoСписокСпецодежды.Caption = "Номенкатура";
            this.Номенклатура_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoСписокСпецодежды.Name = "Номенкатура";
            this.Номенклатура_vmoСписокСпецодежды.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoСписокСпецодежды.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.Номенклатура_vmoСписокСпецодежды;
            this.Номенклатура_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комплект_vmoСписокСпецодежды
            // 
            this.Комплект_vmoСписокСпецодежды.Caption = "Комплект";
            this.Комплект_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комплект_vmoСписокСпецодежды.Name = "Комплект";
            this.Комплект_vmoСписокСпецодежды.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoСписокСпецодежды.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoСписокСпецодежды.ReadOnly = true;
            this.Комплект_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.Комплект_vmoСписокСпецодежды;
            this.Комплект_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоВыданоРанее_vmoСписокСпецодежды
            // 
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.CalcTotal = false;
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.Caption = "КоличествоВыданоРанее";
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.Name = "КоличествоВыданоРанее";
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.ReadOnly = true;
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.КоличествоВыданоРанее_vmoСписокСпецодежды;
            this.КоличествоВыданоРанее_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВсегоЗаконченСрок_vmoСписокСпецодежды
            // 
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.CalcTotal = false;
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Caption = "ВсегоЗаконченСрок";
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Name = "ВсегоЗаконченСрок";
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.ReadOnly = true;
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.ВсегоЗаконченСрок_vmoСписокСпецодежды;
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоВыдать_vmoСписокСпецодежды
            // 
            this.КоличествоВыдать_vmoСписокСпецодежды.CalcTotal = false;
            this.КоличествоВыдать_vmoСписокСпецодежды.Caption = "КоличествоВыдать";
            this.КоличествоВыдать_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КоличествоВыдать_vmoСписокСпецодежды.Name = "КоличествоВыдать";
            this.КоличествоВыдать_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоВыдать_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.КоличествоВыдать_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.КоличествоВыдать_vmoСписокСпецодежды;
            this.КоличествоВыдать_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТребуетсяПоКомплекту_vmoСписокСпецодежды
            // 
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.CalcTotal = false;
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.Caption = "ТребуетсяПоКомплекту";
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name = "ТребуетсяПоКомплекту";
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.ReadOnly = true;
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.ТребуетсяПоКомплекту_vmoСписокСпецодежды;
            this.ТребуетсяПоКомплекту_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоНаСкладе_vmoСписокСпецодежды
            // 
            this.КоличествоНаСкладе_vmoСписокСпецодежды.CalcTotal = false;
            this.КоличествоНаСкладе_vmoСписокСпецодежды.Caption = "КоличествоНаСкладе";
            this.КоличествоНаСкладе_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КоличествоНаСкладе_vmoСписокСпецодежды.Name = "КоличествоНаСкладе";
            this.КоличествоНаСкладе_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоНаСкладе_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.КоличествоНаСкладе_vmoСписокСпецодежды.ReadOnly = true;
            this.КоличествоНаСкладе_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.КоличествоНаСкладе_vmoСписокСпецодежды;
            this.КоличествоНаСкладе_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_vmoСписокСпецодежды
            // 
            this.Размер_vmoСписокСпецодежды.Caption = "Размер";
            this.Размер_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Размер_vmoСписокСпецодежды.Name = "Размер";
            this.Размер_vmoСписокСпецодежды.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoСписокСпецодежды.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.Размер_vmoСписокСпецодежды;
            this.Размер_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Выдать_vmoСписокСпецодежды
            // 
            this.Выдать_vmoСписокСпецодежды.Caption = "Выдать";
            this.Выдать_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выдать_vmoСписокСпецодежды.Name = "Выдать";
            this.Выдать_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выдать_vmoСписокСпецодежды.PropertyType = typeof(bool);
            this.Выдать_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.Выдать_vmoСписокСпецодежды;
            this.Выдать_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды
            // 
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.CalcTotal = false;
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Caption = "УжеЗаказаноКоличество";
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Name = "УжеЗаказаноНаСотрудникаКоличество";
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды;
            this.УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpВыдача);
            this.tabControl1.Controls.Add(this.tpОтчеты);
            this.tabControl1.Controls.Add(this.tpСотрудники);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 505);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpВыдача
            // 
            this.tpВыдача.AllowDrop = true;
            this.tpВыдача.Controls.Add(this.nsgButton2);
            this.tpВыдача.Controls.Add(this.nsgButton1);
            this.tpВыдача.Controls.Add(this.splitContainer1);
            this.tpВыдача.Controls.Add(this.nbВыдать);
            this.tpВыдача.Enabled = true;
            this.tpВыдача.Location = new System.Drawing.Point(4, 22);
            this.tpВыдача.Name = "tpВыдача";
            this.tpВыдача.Padding = new System.Windows.Forms.Padding(3);
            this.tpВыдача.Size = new System.Drawing.Size(871, 479);
            this.tpВыдача.TabIndex = 0;
            this.tpВыдача.Text = "Выдача спецодежды";
            this.tpВыдача.UseVisualStyleBackColor = true;
            this.tpВыдача.Visible = true;
            // 
            // nsgButton2
            // 
            this.nsgButton2.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nsgButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton2.Location = new System.Drawing.Point(143, 434);
            this.nsgButton2.Name = "NsgButton";
            this.nsgButton2.Size = new System.Drawing.Size(129, 39);
            this.nsgButton2.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton2.TabIndex = 12;
            this.nsgButton2.Text = "Создать заявку на недостающее";
            this.nsgButton2.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton2.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton2_AsyncClick);
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(8, 434);
            this.nsgButton1.Name = "NsgButton";
            this.nsgButton1.Size = new System.Drawing.Size(129, 39);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 11;
            this.nsgButton1.Text = "Создать заявку на все";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.nsgInput3);
            this.splitContainer1.Panel1.Controls.Add(this.nsgIGrid3);
            this.splitContainer1.Panel1.Controls.Add(this.nsgInput1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.nsgInput4);
            this.splitContainer1.Panel1.Controls.Add(this.nbЗаполнить);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.nsgIGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(855, 422);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 10;
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Объект";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(115, 16);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Объект";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(217, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 0;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput3.Selected += new System.EventHandler(this.nsgInput3_Selected);
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Сотрудник";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(115, 51);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "Сотрудник";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(217, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 1;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput1.Selected += new System.EventHandler(this.nsgInput1_Selected);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата начала эксплуатации";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "ДатаНачалаЭксплуатации";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(115, 85);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ДатаНачалаЭксплуатации";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(120, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 2;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nbЗаполнить
            // 
            this.nbЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнить.Location = new System.Drawing.Point(250, 85);
            this.nbЗаполнить.Name = "NsgButton";
            this.nbЗаполнить.Size = new System.Drawing.Size(82, 20);
            this.nbЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнить.TabIndex = 3;
            this.nbЗаполнить.Text = "Заполнить";
            this.nbЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнить_AsyncClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выдающий объект";
            // 
            // nbВыдать
            // 
            this.nbВыдать.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbВыдать.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbВыдать.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbВыдать.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbВыдать.Location = new System.Drawing.Point(278, 434);
            this.nbВыдать.Name = "NsgButton";
            this.nbВыдать.Size = new System.Drawing.Size(129, 39);
            this.nbВыдать.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbВыдать.TabIndex = 4;
            this.nbВыдать.Text = "ВыдатьСотруднику";
            this.nbВыдать.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbВыдать.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbВыдать_AsyncClick);
            // 
            // tpОтчеты
            // 
            this.tpОтчеты.AllowDrop = true;
            this.tpОтчеты.Controls.Add(this.groupBox1);
            this.tpОтчеты.Controls.Add(this.nsgInput2);
            this.tpОтчеты.Controls.Add(this.nsgObjectFilter1);
            this.tpОтчеты.Enabled = true;
            this.tpОтчеты.Location = new System.Drawing.Point(4, 22);
            this.tpОтчеты.Name = "tabPage2";
            this.tpОтчеты.Padding = new System.Windows.Forms.Padding(3);
            this.tpОтчеты.Size = new System.Drawing.Size(871, 479);
            this.tpОтчеты.TabIndex = 1;
            this.tpОтчеты.Text = "Отчеты";
            this.tpОтчеты.UseVisualStyleBackColor = true;
            this.tpОтчеты.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nbСпецодежда);
            this.groupBox1.Controls.Add(this.nbЗакупки);
            this.groupBox1.Location = new System.Drawing.Point(533, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип отчета";
            // 
            // nbСпецодежда
            // 
            this.nbСпецодежда.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbСпецодежда.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbСпецодежда.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbСпецодежда.Location = new System.Drawing.Point(7, 51);
            this.nbСпецодежда.Name = "NsgButton";
            this.nbСпецодежда.Size = new System.Drawing.Size(75, 25);
            this.nbСпецодежда.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbСпецодежда.TabIndex = 1;
            this.nbСпецодежда.Text = "Спеодежда";
            this.nbСпецодежда.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbСпецодежда.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbСпецодежда_AsyncClick);
            // 
            // nbЗакупки
            // 
            this.nbЗакупки.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗакупки.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗакупки.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗакупки.Location = new System.Drawing.Point(7, 20);
            this.nbЗакупки.Name = "NsgButton";
            this.nbЗакупки.Size = new System.Drawing.Size(75, 25);
            this.nbЗакупки.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗакупки.TabIndex = 0;
            this.nbЗакупки.Text = "Закупки";
            this.nbЗакупки.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗакупки.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗакупки_AsyncClick);
            // 
            // nsgInput2
            // 
            this.nsgInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "ДатаОтчета";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(533, 7);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ДатаОтчета";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(210, 20);
            this.nsgInput2.TabIndex = 1;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.nsgObjectFilter1.Location = new System.Drawing.Point(9, 7);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = false;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(518, 466);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Сотрудник_vmoФильтр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
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
            // tpСотрудники
            // 
            this.tpСотрудники.AllowDrop = true;
            this.tpСотрудники.Controls.Add(this.nbПроблемныеСотрудники);
            this.tpСотрудники.Controls.Add(this.nsgIGrid2);
            this.tpСотрудники.Enabled = true;
            this.tpСотрудники.Location = new System.Drawing.Point(4, 22);
            this.tpСотрудники.Name = "tpСотрудники";
            this.tpСотрудники.Size = new System.Drawing.Size(871, 479);
            this.tpСотрудники.TabIndex = 2;
            this.tpСотрудники.Text = "Проверка сотрудников";
            this.tpСотрудники.UseVisualStyleBackColor = true;
            this.tpСотрудники.Visible = false;
            // 
            // nbПроблемныеСотрудники
            // 
            this.nbПроблемныеСотрудники.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbПроблемныеСотрудники.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbПроблемныеСотрудники.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbПроблемныеСотрудники.Location = new System.Drawing.Point(8, 3);
            this.nbПроблемныеСотрудники.Name = "NsgButton";
            this.nbПроблемныеСотрудники.Size = new System.Drawing.Size(128, 25);
            this.nbПроблемныеСотрудники.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbПроблемныеСотрудники.TabIndex = 1;
            this.nbПроблемныеСотрудники.Text = "Заполнить";
            this.nbПроблемныеСотрудники.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbПроблемныеСотрудники.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
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
            // ДатаНачалаЭксплуатации
            // 
            this.ДатаНачалаЭксплуатации.Caption = "ДатаНачалаЭксплуатации";
            this.ДатаНачалаЭксплуатации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаНачалаЭксплуатации.Name = "ДатаНачалаЭксплуатации";
            this.ДатаНачалаЭксплуатации.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаНачалаЭксплуатации.PropertyType = typeof(System.DateTime);
            this.ДатаНачалаЭксплуатации.SearchCondition.OwnerComponent = this.ДатаНачалаЭксплуатации;
            this.ДатаНачалаЭксплуатации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЗаказаноУПоставщикаКоличество
            // 
            this.ЗаказаноУПоставщикаКоличество.CalcTotal = false;
            this.ЗаказаноУПоставщикаКоличество.Caption = "ЗаказаноУПостащикаКоличество";
            this.ЗаказаноУПоставщикаКоличество.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЗаказаноУПоставщикаКоличество.Name = "ЗаказаноУПостащикаКоличество";
            this.ЗаказаноУПоставщикаКоличество.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ЗаказаноУПоставщикаКоличество.PropertyType = typeof(long);
            this.ЗаказаноУПоставщикаКоличество.SearchCondition.OwnerComponent = this.ЗаказаноУПоставщикаКоличество;
            this.ЗаказаноУПоставщикаКоличество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КонтрольСпецодеждыИСИЗФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(879, 561);
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
            this.UseDefaultButtons = false;
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСотрудники)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКомплекты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСписокСпецодежды)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpВыдача.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).EndInit();
            this.tpОтчеты.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbСпецодежда)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗакупки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            this.tpСотрудники.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbПроблемныеСотрудники)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        protected КомплектыСпецодежды.ColumnDescriptor Комплект_vmoСписокСпецодежды;
        protected NsgInput nsgInput1;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Int64 ВсегоЗаконченСрок_vmoСписокСпецодежды;
        protected NsgSoft.Design.NsgButton nbЗаполнить;
        protected NsgSoft.Design.NsgButton nbВыдать;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoФильтр;
        protected NsgInput nsgInput2;
        protected NsgColumnDescriptor.DateTime ДатаОтчета_vmoДопДанныеДляОтчета;
        protected System.Windows.Forms.Label label1;
        protected NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected System.Windows.Forms.Label label2;
        protected NsgInput nsgInput3;
        protected NsgColumnDescriptor.Int64 КоличествоВыдать_vmoСписокСпецодежды;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected NsgColumnDescriptor.Int64 ТребуетсяПоКомплекту_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Int64 КоличествоВыданоРанее_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.DateTime ДатаНачалаЭксплуатации;
        protected System.Windows.Forms.Label label3;
        protected NsgInput nsgInput4;
        protected NsgColumnDescriptor.Int64 КоличествоНаСкладе_vmoСписокСпецодежды;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoСотрудники;
        protected NsgSoft.Design.NsgButton nbПроблемныеСотрудники;
        protected NsgColumnDescriptor.String Проблема_vmoСотрудники;
        protected Мониторинг.Подразделения.ColumnDescriptor Подразделение_vmoСотрудники;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tpСотрудники;
        private NsgIGrid nsgIGrid2;
        protected КомплектыСпецодежды.ColumnDescriptor Комплект_vmoКомплекты;
        private NsgIGrid nsgIGrid3;
        protected System.Windows.Forms.TabPage tpВыдача;
        protected NsgColumnDescriptor.Boolean Выбрано_vmoКомплекты;
        protected NsgSoft.Design.NsgButton nbСпецодежда;
        protected NsgSoft.Design.NsgButton nbЗакупки;
        protected NsgSoft.Design.NsgButton nsgButton2;
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected Учет.Размеры.ColumnDescriptor Размер_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Boolean Выдать_vmoСписокСпецодежды;
        private NsgIGrid nsgIGrid1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        private NsgVisualMultipleObject vmoСотрудники;
        private System.Windows.Forms.TabPage tpОтчеты;
        private NsgVisualMultipleObject vmoСписокСпецодежды;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgVisualMultipleObject vmoКомплекты;
        protected NsgColumnDescriptor.Int64 УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Int64 ЗаказаноУПоставщикаКоличество;
    }
}