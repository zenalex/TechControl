using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Грузы

{
    
    public partial class УправлениеВъездамиВыездамиФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(УправлениеВъездамиВыездамиФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoФотографии = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСостояние = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpОформление = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.label10 = new System.Windows.Forms.Label();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.label9 = new System.Windows.Forms.Label();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.nLblСтатус = new NsgSoft.Forms.NsgLabel();
            this.nbВыезд = new NsgSoft.Design.NsgButton();
            this.nbВъезд = new NsgSoft.Design.NsgButton();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.label5 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.tpТехника = new System.Windows.Forms.TabPage();
            this.cbПоказатьВсе = new System.Windows.Forms.CheckBox();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nbwЗаполнениеСостояния = new NsgSoft.Forms.NsgBackgroundWorker(this.components);
            this.Фото_vmoФотографии = new TechControl.Метаданные.Учет.Фотографии.ColumnDescriptor();
            this.ГосНомер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ПроезжающаяТехника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Дата = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВодительСтрока = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Водитель = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.КПП = new TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты.ColumnDescriptor();
            this.СтатусТехники = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ВидГруза = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.ОбъемГруза = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.КомментарийПроезд = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.КомментарийГруз = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ТекущаяТехника_vmoСостояние = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВремяПриезда_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Груз_vmoСостояние = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.Объем_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Объект_vmoСостояние = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.tpЗаднимЧислом = new System.Windows.Forms.TabPage();
            this.vmoЗаднимЧислом = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФотографии)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояние)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpОформление.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыезд)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВъезд)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            this.tpТехника.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаднимЧислом)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 494);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1154, 30);
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
            this.printButton.Location = new System.Drawing.Point(1134, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГосНомер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПроезжающаяТехника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Дата);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВодительСтрока);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Водитель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КПП);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СтатусТехники);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВидГруза);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъемГруза);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КомментарийПроезд);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КомментарийГруз);
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
            this.nsgIGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            nsgIGridColumn1.Name = "Фото";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(561, 30);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(197, 369);
            this.nsgIGrid1.SourceObject = this.vmoФотографии;
            this.nsgIGrid1.TabIndex = 20;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoФотографии
            // 
            this.vmoФотографии.Columns.Collection.Add(this.Фото_vmoФотографии);
            this.vmoФотографии.IsActive = true;
            this.vmoФотографии.CurrentRowChanged += new NsgSoft.Forms.CurrentRowChangedEventHandler(this.vmoФотографии_CurrentRowChanged);
            this.vmoФотографии.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФотографии.MetaDataName = "";
            this.vmoФотографии.FullName = "";
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
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.ImportedFromVMO = false;
            nsgIGridColumn2.Name = "Объект";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.ImportedFromVMO = false;
            nsgIGridColumn3.Name = "Техника";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.ImportedFromVMO = false;
            nsgIGridColumn4.Name = "ВремяПриезда";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.ImportedFromVMO = false;
            nsgIGridColumn5.Name = "Груз";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn6.ImportedFromVMO = false;
            nsgIGridColumn6.Name = "Объем";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(9, 38);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(1116, 364);
            this.nsgIGrid2.SourceObject = this.vmoСостояние;
            this.nsgIGrid2.TabIndex = 0;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoСостояние
            // 
            this.vmoСостояние.Columns.Collection.Add(this.ТекущаяТехника_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.ВремяПриезда_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Груз_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Объем_vmoСостояние);
            this.vmoСостояние.Columns.Collection.Add(this.Объект_vmoСостояние);
            this.vmoСостояние.IsActive = true;
            this.vmoСостояние.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСостояние.MetaDataName = "";
            this.vmoСостояние.FullName = "";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpОформление);
            this.tabControl1.Controls.Add(this.tpТехника);
            this.tabControl1.Controls.Add(this.tpЗаднимЧислом);
            this.tabControl1.Location = new System.Drawing.Point(6, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1136, 431);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpОформление
            // 
            this.tpОформление.AllowDrop = true;
            this.tpОформление.Controls.Add(this.label12);
            this.tpОформление.Controls.Add(this.pictureBox1);
            this.tpОформление.Controls.Add(this.nsgIGrid1);
            this.tpОформление.Controls.Add(this.nsgInput1);
            this.tpОформление.Controls.Add(this.label1);
            this.tpОформление.Controls.Add(this.groupBox1);
            this.tpОформление.Controls.Add(this.nLblСтатус);
            this.tpОформление.Controls.Add(this.nbВыезд);
            this.tpОформление.Controls.Add(this.nbВъезд);
            this.tpОформление.Controls.Add(this.nsgInput7);
            this.tpОформление.Controls.Add(this.label7);
            this.tpОформление.Controls.Add(this.nsgInput5);
            this.tpОформление.Controls.Add(this.label5);
            this.tpОформление.Controls.Add(this.nsgInput4);
            this.tpОформление.Controls.Add(this.label4);
            this.tpОформление.Controls.Add(this.nsgInput3);
            this.tpОформление.Controls.Add(this.label3);
            this.tpОформление.Controls.Add(this.nsgInput2);
            this.tpОформление.Controls.Add(this.label2);
            this.tpОформление.Enabled = true;
            this.tpОформление.Location = new System.Drawing.Point(4, 22);
            this.tpОформление.Name = "tpОформление";
            this.tpОформление.Padding = new System.Windows.Forms.Padding(3);
            this.tpОформление.Size = new System.Drawing.Size(1128, 405);
            this.tpОформление.TabIndex = 0;
            this.tpОформление.Text = "Оформление";
            this.tpОформление.UseVisualStyleBackColor = true;
            this.tpОформление.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(587, 10);
            this.label12.Name = "label6";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Фотографии";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(764, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 360);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "КомментарийПроезд";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsMultiline = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(102, 155);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "КомментарийПроезд";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(442, 61);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 19;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Комментарий";
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nsgInput10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nsgInput9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nsgInput8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(9, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 148);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Груз";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Комментарий";
            // 
            // nsgInput10
            // 
            this.nsgInput10.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput10.ConfigurationName = "";
            this.nsgInput10.DisableLeaveControlEvent = false;
            this.nsgInput10.FullName = "КомментарийГруз";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsMultiline = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(93, 75);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "КомментарийГруз";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(442, 61);
            this.nsgInput10.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput10.TabIndex = 21;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, -28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Комментарий";
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "ОбъемГруза";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(93, 45);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "ОбъемГруза";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(130, 20);
            this.nsgInput9.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput9.TabIndex = 21;
            this.nsgInput9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Объем м3";
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "ВидГруза";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(93, 16);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "ВидГруза";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(442, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 19;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput8.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput8_EndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вид";
            // 
            // nLblСтатус
            // 
            this.nLblСтатус.AutoSize = true;
            this.nLblСтатус.ConfigurationName = "";
            this.nLblСтатус.FullName = "";
            this.nLblСтатус.IsInitialized = true;
            this.nLblСтатус.Location = new System.Drawing.Point(247, 39);
            this.nLblСтатус.MetaDataName = "";
            this.nLblСтатус.Name = "nLblСтатус";
            this.nLblСтатус.Requsite = "СтатусТехники";
            this.nLblСтатус.Size = new System.Drawing.Size(41, 13);
            this.nLblСтатус.SourceObject = this.nsgVisualMultipleObject;
            this.nLblСтатус.TabIndex = 16;
            this.nLblСтатус.Text = "Статус";
            // 
            // nbВыезд
            // 
            this.nbВыезд.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbВыезд.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbВыезд.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbВыезд.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbВыезд.Location = new System.Drawing.Point(181, 374);
            this.nbВыезд.Name = "NsgButton";
            this.nbВыезд.Size = new System.Drawing.Size(158, 25);
            this.nbВыезд.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbВыезд.TabIndex = 15;
            this.nbВыезд.Text = "Оформить Выезд";
            this.nbВыезд.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbВыезд.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbВыезд_AsyncClick);
            // 
            // nbВъезд
            // 
            this.nbВъезд.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbВъезд.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbВъезд.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbВъезд.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbВъезд.Location = new System.Drawing.Point(6, 374);
            this.nbВъезд.Name = "NsgButton";
            this.nbВъезд.Size = new System.Drawing.Size(158, 25);
            this.nbВъезд.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbВъезд.TabIndex = 14;
            this.nbВъезд.Text = "Оформить Въезд";
            this.nbВъезд.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbВъезд.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbВъезд_AsyncClick);
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "КПП";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(102, 3);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "КПП";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(130, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 13;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кпп";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Водитель";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(102, 126);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Водитель";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(442, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 9;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Водитель";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "ВодительСтрока";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(102, 96);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ВодительСтрока";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(442, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 7;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Водитель ФИО";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "ПроезжающаяТехника";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(102, 64);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "ПроезжающаяТехника";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(442, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 5;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput3.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput3_EndEdit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Техника";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "ГосНомер";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(102, 32);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ГосНомер";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(130, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 3;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput2.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput2_EndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ГосНомер";
            // 
            // tpТехника
            // 
            this.tpТехника.AllowDrop = true;
            this.tpТехника.Controls.Add(this.cbПоказатьВсе);
            this.tpТехника.Controls.Add(this.nsgIGrid2);
            this.tpТехника.Enabled = true;
            this.tpТехника.Location = new System.Drawing.Point(4, 22);
            this.tpТехника.Name = "tpТехника";
            this.tpТехника.Size = new System.Drawing.Size(1128, 405);
            this.tpТехника.TabIndex = 2;
            this.tpТехника.Text = "Обзор техники";
            this.tpТехника.UseVisualStyleBackColor = true;
            this.tpТехника.Visible = false;
            // 
            // cbПоказатьВсе
            // 
            this.cbПоказатьВсе.AutoSize = true;
            this.cbПоказатьВсе.Location = new System.Drawing.Point(9, 9);
            this.cbПоказатьВсе.Name = "cbПоказатьВсе";
            this.cbПоказатьВсе.Size = new System.Drawing.Size(154, 17);
            this.cbПоказатьВсе.TabIndex = 1;
            this.cbПоказатьВсе.Text = "Показывать всю технику";
            this.cbПоказатьВсе.UseVisualStyleBackColor = true;
            this.cbПоказатьВсе.CheckedChanged += new System.EventHandler(this.cbПоказатьВсе_CheckedChanged);
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Объект";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(112, 9);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Объект";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(442, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 11;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput6.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput6_EndEdit);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Объект";
            // 
            // nbwЗаполнениеСостояния
            // 
            this.nbwЗаполнениеСостояния.CancelForbidden = false;
            this.nbwЗаполнениеСостояния.CurrentProgressValue = 0;
            this.nbwЗаполнениеСостояния.Description = "";
            this.nbwЗаполнениеСостояния.EventGeneratorObject = null;
            this.nbwЗаполнениеСостояния.MaxProgressValue = 100;
            this.nbwЗаполнениеСостояния.Name = "nbwЗаполнениеСостояния";
            this.nbwЗаполнениеСостояния.OwnerForm = this;
            this.nbwЗаполнениеСостояния.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nbwЗаполнениеСостояния.ProgressObject = null;
            this.nbwЗаполнениеСостояния.ProgressProcentage = 0;
            this.nbwЗаполнениеСостояния.DoWork += new System.ComponentModel.DoWorkEventHandler(this.nbwЗаполнениеСостояния_DoWork);
            // 
            // Фото_vmoФотографии
            // 
            this.Фото_vmoФотографии.Caption = "Фото";
            this.Фото_vmoФотографии.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фото_vmoФотографии.Name = "Фото";
            this.Фото_vmoФотографии.NSGType = typeof(TechControl.Метаданные.Учет.Фотографии);
            this.Фото_vmoФотографии.PropertyType = typeof(TechControl.Метаданные.Учет.Фотографии);
            this.Фото_vmoФотографии.SearchCondition.OwnerComponent = this.Фото_vmoФотографии;
            this.Фото_vmoФотографии.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГосНомер
            // 
            this.ГосНомер.Caption = "ГосНомер";
            this.ГосНомер.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГосНомер.Name = "ГосНомер";
            this.ГосНомер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГосНомер.PropertyType = typeof(string);
            this.ГосНомер.SearchCondition.OwnerComponent = this.ГосНомер;
            this.ГосНомер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПроезжающаяТехника
            // 
            this.ПроезжающаяТехника.Caption = "ПроезжающаяТехника";
            this.ПроезжающаяТехника.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПроезжающаяТехника.Name = "ПроезжающаяТехника";
            this.ПроезжающаяТехника.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ПроезжающаяТехника.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ПроезжающаяТехника.SearchCondition.OwnerComponent = this.ПроезжающаяТехника;
            this.ПроезжающаяТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // ВодительСтрока
            // 
            this.ВодительСтрока.Caption = "ВодительСтрока";
            this.ВодительСтрока.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВодительСтрока.Name = "ВодительСтрока";
            this.ВодительСтрока.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ВодительСтрока.PropertyType = typeof(string);
            this.ВодительСтрока.SearchCondition.OwnerComponent = this.ВодительСтрока;
            this.ВодительСтрока.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Водитель
            // 
            this.Водитель.Caption = "Водитель";
            this.Водитель.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Водитель.Name = "Водитель";
            this.Водитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Водитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Водитель.SearchCondition.OwnerComponent = this.Водитель;
            this.Водитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КПП
            // 
            this.КПП.Caption = "КПП";
            this.КПП.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КПП.Dependency = "Объект";
            this.КПП.Name = "КПП";
            this.КПП.NSGType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КПП.PropertyType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КПП.SearchCondition.OwnerComponent = this.КПП;
            this.КПП.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтатусТехники
            // 
            this.СтатусТехники.Caption = "СтатусТехники";
            this.СтатусТехники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтатусТехники.Name = "СтатусТехники";
            this.СтатусТехники.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СтатусТехники.PropertyType = typeof(string);
            this.СтатусТехники.SearchCondition.OwnerComponent = this.СтатусТехники;
            this.СтатусТехники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.ОбъемГруза.Caption = "ОбъемГруза";
            this.ОбъемГруза.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемГруза.Name = "ОбъемГруза";
            this.ОбъемГруза.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемГруза.PropertyType = typeof(decimal);
            this.ОбъемГруза.SearchCondition.OwnerComponent = this.ОбъемГруза;
            this.ОбъемГруза.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КомментарийПроезд
            // 
            this.КомментарийПроезд.Caption = "КомментарийПроезд";
            this.КомментарийПроезд.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КомментарийПроезд.Name = "КомментарийПроезд";
            this.КомментарийПроезд.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КомментарийПроезд.PropertyType = typeof(string);
            this.КомментарийПроезд.SearchCondition.OwnerComponent = this.КомментарийПроезд;
            this.КомментарийПроезд.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КомментарийГруз
            // 
            this.КомментарийГруз.Caption = "КомментарийГруз";
            this.КомментарийГруз.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КомментарийГруз.Name = "КомментарийГруз";
            this.КомментарийГруз.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КомментарийГруз.PropertyType = typeof(string);
            this.КомментарийГруз.SearchCondition.OwnerComponent = this.КомментарийГруз;
            this.КомментарийГруз.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТекущаяТехника_vmoСостояние
            // 
            this.ТекущаяТехника_vmoСостояние.Caption = "Техника";
            this.ТекущаяТехника_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТекущаяТехника_vmoСостояние.Name = "Техника";
            this.ТекущаяТехника_vmoСостояние.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ТекущаяТехника_vmoСостояние.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ТекущаяТехника_vmoСостояние.ReadOnly = true;
            this.ТекущаяТехника_vmoСостояние.SearchCondition.OwnerComponent = this.ТекущаяТехника_vmoСостояние;
            this.ТекущаяТехника_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяПриезда_vmoСостояние
            // 
            this.ВремяПриезда_vmoСостояние.Caption = "ВремяПриезда";
            this.ВремяПриезда_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВремяПриезда_vmoСостояние.Name = "ВремяПриезда";
            this.ВремяПриезда_vmoСостояние.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяПриезда_vmoСостояние.PropertyType = typeof(System.DateTime);
            this.ВремяПриезда_vmoСостояние.ReadOnly = true;
            this.ВремяПриезда_vmoСостояние.SearchCondition.OwnerComponent = this.ВремяПриезда_vmoСостояние;
            this.ВремяПриезда_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Объект_vmoСостояние
            // 
            this.Объект_vmoСостояние.Caption = "Объект";
            this.Объект_vmoСостояние.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoСостояние.Name = "Объект";
            this.Объект_vmoСостояние.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСостояние.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСостояние.ReadOnly = true;
            this.Объект_vmoСостояние.SearchCondition.OwnerComponent = this.Объект_vmoСостояние;
            this.Объект_vmoСостояние.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tpЗаднимЧислом
            // 
            this.tpЗаднимЧислом.AllowDrop = true;
            this.tpЗаднимЧислом.Enabled = true;
            this.tpЗаднимЧислом.Location = new System.Drawing.Point(4, 22);
            this.tpЗаднимЧислом.Name = "tpЗаднимЧислом";
            this.tpЗаднимЧислом.Size = new System.Drawing.Size(1128, 405);
            this.tpЗаднимЧислом.TabIndex = 3;
            this.tpЗаднимЧислом.Text = "ОформлениеЗаднимЧислом";
            this.tpЗаднимЧислом.UseVisualStyleBackColor = true;
            this.tpЗаднимЧислом.Visible = true;
            // 
            // vmoЗаднимЧислом
            // 
            this.vmoЗаднимЧислом.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoЗаднимЧислом.MetaDataName = "";
            this.vmoЗаднимЧислом.FullName = "";
            // 
            // УправлениеВъездамиВыездамиФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1154, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Controls.Add(this.nsgInput6);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.nsgInput6, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoФотографии)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояние)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpОформление.ResumeLayout(false);
            this.tpОформление.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыезд)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВъезд)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            this.tpТехника.ResumeLayout(false);
            this.tpТехника.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаднимЧислом)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected NsgColumnDescriptor.String ГосНомер;
        protected Мониторинг.Техника.ColumnDescriptor ПроезжающаяТехника;
        protected NsgColumnDescriptor.String ВодительСтрока;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgColumnDescriptor.DateTime Дата;
        protected Мониторинг.ФизЛица.ColumnDescriptor Водитель;
        protected КонтрольноПропускныеПункты.ColumnDescriptor КПП;
        protected NsgSoft.Design.NsgButton nbВыезд;
        protected NsgSoft.Design.NsgButton nbВъезд;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.Label label6;
        protected NsgInput nsgInput5;
        protected System.Windows.Forms.Label label5;
        protected NsgInput nsgInput4;
        protected System.Windows.Forms.Label label4;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        protected NsgInput nsgInput2;
        protected System.Windows.Forms.Label label2;
        protected NsgColumnDescriptor.String СтатусТехники;
        protected ВидыГрузов.ColumnDescriptor ВидГруза;
        protected NsgColumnDescriptor.Decimal ОбъемГруза;
        protected NsgInput nsgInput9;
        protected System.Windows.Forms.Label label9;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tpОформление;
        protected System.Windows.Forms.TabPage tpТехника;
        protected NsgLabel nLblСтатус;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected NsgColumnDescriptor.String КомментарийПроезд;
        protected NsgColumnDescriptor.String КомментарийГруз;
        protected NsgInput nsgInput1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label11;
        protected NsgInput nsgInput10;
        protected System.Windows.Forms.Label label10;
        protected Учет.Фотографии.ColumnDescriptor Фото_vmoФотографии;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label label12;
        private NsgIGrid nsgIGrid1;
        protected Мониторинг.Техника.ColumnDescriptor ТекущаяТехника_vmoСостояние;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoСостояние;
        protected NsgColumnDescriptor.DateTime ВремяПриезда_vmoСостояние;
        protected ВидыГрузов.ColumnDescriptor Груз_vmoСостояние;
        protected NsgColumnDescriptor.Decimal Объем_vmoСостояние;
        protected NsgBackgroundWorker nbwЗаполнениеСостояния;
        private NsgIGrid nsgIGrid2;
        private System.Windows.Forms.TabPage tpЗаднимЧислом;
        protected NsgVisualMultipleObject vmoЗаднимЧислом;
        protected NsgVisualMultipleObject vmoФотографии;
        protected System.Windows.Forms.CheckBox cbПоказатьВсе;
        protected NsgVisualMultipleObject vmoСостояние;
    }
}