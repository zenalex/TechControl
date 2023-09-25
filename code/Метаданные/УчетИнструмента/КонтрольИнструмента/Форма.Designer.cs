using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.УчетИнструмента

{
    
    public partial class КонтрольИнструментаФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(КонтрольИнструментаФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn21 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаПодтверждения = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.СерийныйНомер_vmoТаблицаПодтверждения = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Номенклатура_vmoТаблицаПодтверждения = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ОформитьВозврать_vmoТаблицаПодтверждения = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Сотрудник_vmoТаблицаПодтверждения = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Объект_vmoТаблицаПодтверждения = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСменаСерийников = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Объект_vmoСменаСерийников = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник_vmoСменаСерийников = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.ТекущийСерийник_vmoСменаСерийников = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НовыйСерийник_vmoСменаСерийников = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Подтвердить_vmoСменаСерийников = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Номенклатура_vmoСменаСерийников = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаВыдачи = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoТаблицаВыдачи = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.СерийныйНомер_vmoТаблицаВыдачи = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Выдать_vmoТаблицаВыдачи = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpВыдача = new System.Windows.Forms.TabPage();
            this.nbЗаполнитьПоОбъекту = new NsgSoft.Design.NsgButton();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.cbТребуетсяПодтверждение = new System.Windows.Forms.CheckBox();
            this.nbВыдать = new NsgSoft.Design.NsgButton();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.tpПриемка = new System.Windows.Forms.TabPage();
            this.nbОбработатьПодтверждения = new NsgSoft.Design.NsgButton();
            this.nbЗаполнитьПодтверждения = new NsgSoft.Design.NsgButton();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.label5 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.tpСерийники = new System.Windows.Forms.TabPage();
            this.nbНовыеСерийники = new NsgSoft.Design.NsgButton();
            this.nbПоказатьИнструменты = new NsgSoft.Design.NsgButton();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.СотрудникПолучатель = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.ОбъектПолучатель = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОбъектВыдачи = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОбъектПодтверждения = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.СотрудникПодтверждение = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.СотрудникСерийники = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.ОбъектСерийники = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.СотрудникВыдачи = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаПодтверждения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСменаСерийников)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаВыдачи)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpВыдача.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПоОбъекту)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.tpПриемка.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbОбработатьПодтверждения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПодтверждения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            this.tpСерийники.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbНовыеСерийники)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbПоказатьИнструменты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 498);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(923, 30);
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
            this.printButton.Location = new System.Drawing.Point(903, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектВыдачи);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектПолучатель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СотрудникПолучатель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектПодтверждения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СотрудникПодтверждение);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектСерийники);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СотрудникСерийники);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СотрудникВыдачи);
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
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.Name = "СерийныйНомер";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn17.Name = "Номенклатура";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn18.Name = "ОформитьВозврат";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn19.Name = "ПодтвердитьПолучение";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn20.Name = "Сотрудник";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn20.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn20.UseAsHeaderImage = false;
            nsgIGridColumn20.Width = 100;
            nsgIGridColumn21.AllowFilter = true;
            nsgIGridColumn21.AllowGroupSelect = false;
            nsgIGridColumn21.AllowResize = true;
            nsgIGridColumn21.AutoResize = true;
            nsgIGridColumn21.Caption = "";
            nsgIGridColumn21.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn21.DateFormat = null;
            nsgIGridColumn21.Name = "Объект";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(8, 92);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(895, 356);
            this.nsgIGrid2.SourceObject = this.vmoТаблицаПодтверждения;
            this.nsgIGrid2.TabIndex = 8;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid2.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid2_CellEndEdit);
            // 
            // vmoТаблицаПодтверждения
            // 
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.СерийныйНомер_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.Номенклатура_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.ПодтвердитьПолучение_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.ОформитьВозврать_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.Сотрудник_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.Columns.Collection.Add(this.Объект_vmoТаблицаПодтверждения);
            this.vmoТаблицаПодтверждения.IsActive = true;
            this.vmoТаблицаПодтверждения.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаПодтверждения.MetaDataName = "";
            this.vmoТаблицаПодтверждения.FullName = "";
            // 
            // СерийныйНомер_vmoТаблицаПодтверждения
            // 
            this.СерийныйНомер_vmoТаблицаПодтверждения.Caption = "СерийныйНомер";
            this.СерийныйНомер_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СерийныйНомер_vmoТаблицаПодтверждения.Name = "СерийныйНомер";
            this.СерийныйНомер_vmoТаблицаПодтверждения.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СерийныйНомер_vmoТаблицаПодтверждения.PropertyType = typeof(string);
            this.СерийныйНомер_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.СерийныйНомер_vmoТаблицаПодтверждения;
            this.СерийныйНомер_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура_vmoТаблицаПодтверждения
            // 
            this.Номенклатура_vmoТаблицаПодтверждения.Caption = "Номенклатура";
            this.Номенклатура_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoТаблицаПодтверждения.Name = "Номенклатура";
            this.Номенклатура_vmoТаблицаПодтверждения.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаПодтверждения.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.Номенклатура_vmoТаблицаПодтверждения;
            this.Номенклатура_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПодтвердитьПолучение_vmoТаблицаПодтверждения
            // 
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.Caption = "ПодтвердитьПолучение";
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.Name = "ПодтвердитьПолучение";
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.PropertyType = typeof(bool);
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.ПодтвердитьПолучение_vmoТаблицаПодтверждения;
            this.ПодтвердитьПолучение_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОформитьВозврать_vmoТаблицаПодтверждения
            // 
            this.ОформитьВозврать_vmoТаблицаПодтверждения.Caption = "ОформитьВозврат";
            this.ОформитьВозврать_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОформитьВозврать_vmoТаблицаПодтверждения.Name = "ОформитьВозврат";
            this.ОформитьВозврать_vmoТаблицаПодтверждения.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ОформитьВозврать_vmoТаблицаПодтверждения.PropertyType = typeof(bool);
            this.ОформитьВозврать_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.ОформитьВозврать_vmoТаблицаПодтверждения;
            this.ОформитьВозврать_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoТаблицаПодтверждения
            // 
            this.Сотрудник_vmoТаблицаПодтверждения.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoТаблицаПодтверждения.Name = "Сотрудник";
            this.Сотрудник_vmoТаблицаПодтверждения.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаПодтверждения.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблицаПодтверждения;
            this.Сотрудник_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoТаблицаПодтверждения
            // 
            this.Объект_vmoТаблицаПодтверждения.Caption = "Объект";
            this.Объект_vmoТаблицаПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoТаблицаПодтверждения.Name = "Объект";
            this.Объект_vmoТаблицаПодтверждения.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблицаПодтверждения.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблицаПодтверждения.SearchCondition.OwnerComponent = this.Объект_vmoТаблицаПодтверждения;
            this.Объект_vmoТаблицаПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.Name = "Номенклатура";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.Name = "Объект";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn3.Name = "Сотрудник";
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
        "Visible",
        "Index"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "ТекущийСерийник";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn5.Name = "НовыйСерийник";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn6.Name = "Подтвердить";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(8, 61);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(893, 390);
            this.nsgIGrid3.SourceObject = this.vmoСменаСерийников;
            this.nsgIGrid3.TabIndex = 12;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid3.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid3_CellRequestEdit);
            // 
            // vmoСменаСерийников
            // 
            this.vmoСменаСерийников.Columns.Collection.Add(this.Объект_vmoСменаСерийников);
            this.vmoСменаСерийников.Columns.Collection.Add(this.Сотрудник_vmoСменаСерийников);
            this.vmoСменаСерийников.Columns.Collection.Add(this.ТекущийСерийник_vmoСменаСерийников);
            this.vmoСменаСерийников.Columns.Collection.Add(this.НовыйСерийник_vmoСменаСерийников);
            this.vmoСменаСерийников.Columns.Collection.Add(this.Подтвердить_vmoСменаСерийников);
            this.vmoСменаСерийников.Columns.Collection.Add(this.Номенклатура_vmoСменаСерийников);
            this.vmoСменаСерийников.IsActive = true;
            this.vmoСменаСерийников.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСменаСерийников.MetaDataName = "";
            this.vmoСменаСерийников.FullName = "";
            // 
            // Объект_vmoСменаСерийников
            // 
            this.Объект_vmoСменаСерийников.Caption = "Объект";
            this.Объект_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoСменаСерийников.Name = "Объект";
            this.Объект_vmoСменаСерийников.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСменаСерийников.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСменаСерийников.ReadOnly = true;
            this.Объект_vmoСменаСерийников.SearchCondition.OwnerComponent = this.Объект_vmoСменаСерийников;
            this.Объект_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoСменаСерийников
            // 
            this.Сотрудник_vmoСменаСерийников.Caption = "Сотрудник";
            this.Сотрудник_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoСменаСерийников.Name = "Сотрудник";
            this.Сотрудник_vmoСменаСерийников.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoСменаСерийников.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoСменаСерийников.ReadOnly = true;
            this.Сотрудник_vmoСменаСерийников.SearchCondition.OwnerComponent = this.Сотрудник_vmoСменаСерийников;
            this.Сотрудник_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТекущийСерийник_vmoСменаСерийников
            // 
            this.ТекущийСерийник_vmoСменаСерийников.Caption = "ТекущийСерийник";
            this.ТекущийСерийник_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТекущийСерийник_vmoСменаСерийников.Name = "ТекущийСерийник";
            this.ТекущийСерийник_vmoСменаСерийников.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ТекущийСерийник_vmoСменаСерийников.PropertyType = typeof(string);
            this.ТекущийСерийник_vmoСменаСерийников.ReadOnly = true;
            this.ТекущийСерийник_vmoСменаСерийников.SearchCondition.OwnerComponent = this.ТекущийСерийник_vmoСменаСерийников;
            this.ТекущийСерийник_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НовыйСерийник_vmoСменаСерийников
            // 
            this.НовыйСерийник_vmoСменаСерийников.Caption = "НовыйСерийник";
            this.НовыйСерийник_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НовыйСерийник_vmoСменаСерийников.Name = "НовыйСерийник";
            this.НовыйСерийник_vmoСменаСерийников.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НовыйСерийник_vmoСменаСерийников.PropertyType = typeof(string);
            this.НовыйСерийник_vmoСменаСерийников.SearchCondition.OwnerComponent = this.НовыйСерийник_vmoСменаСерийников;
            this.НовыйСерийник_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подтвердить_vmoСменаСерийников
            // 
            this.Подтвердить_vmoСменаСерийников.Caption = "Подтвердить";
            this.Подтвердить_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подтвердить_vmoСменаСерийников.Name = "Подтвердить";
            this.Подтвердить_vmoСменаСерийников.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Подтвердить_vmoСменаСерийников.PropertyType = typeof(bool);
            this.Подтвердить_vmoСменаСерийников.SearchCondition.OwnerComponent = this.Подтвердить_vmoСменаСерийников;
            this.Подтвердить_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура_vmoСменаСерийников
            // 
            this.Номенклатура_vmoСменаСерийников.Caption = "Номенклатура";
            this.Номенклатура_vmoСменаСерийников.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoСменаСерийников.Name = "Номенклатура";
            this.Номенклатура_vmoСменаСерийников.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoСменаСерийников.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoСменаСерийников.ReadOnly = true;
            this.Номенклатура_vmoСменаСерийников.SearchCondition.OwnerComponent = this.Номенклатура_vmoСменаСерийников;
            this.Номенклатура_vmoСменаСерийников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn7.AllowFilter = true;
            nsgIGridColumn7.AllowGroupSelect = false;
            nsgIGridColumn7.AllowResize = true;
            nsgIGridColumn7.AutoResize = true;
            nsgIGridColumn7.Caption = "";
            nsgIGridColumn7.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "Номенклатура";
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
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "СерийныйНомер";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.Name = "Выдать";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 156);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(897, 292);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаВыдачи;
            this.nsgIGrid1.TabIndex = 1;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            // 
            // vmoТаблицаВыдачи
            // 
            this.vmoТаблицаВыдачи.Columns.Collection.Add(this.Номенклатура_vmoТаблицаВыдачи);
            this.vmoТаблицаВыдачи.Columns.Collection.Add(this.СерийныйНомер_vmoТаблицаВыдачи);
            this.vmoТаблицаВыдачи.Columns.Collection.Add(this.Выдать_vmoТаблицаВыдачи);
            this.vmoТаблицаВыдачи.IsActive = true;
            this.vmoТаблицаВыдачи.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаВыдачи.MetaDataName = "";
            this.vmoТаблицаВыдачи.FullName = "";
            // 
            // Номенклатура_vmoТаблицаВыдачи
            // 
            this.Номенклатура_vmoТаблицаВыдачи.Caption = "Номенклатура";
            this.Номенклатура_vmoТаблицаВыдачи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoТаблицаВыдачи.Name = "Номенклатура";
            this.Номенклатура_vmoТаблицаВыдачи.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаВыдачи.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаВыдачи.SearchCondition.OwnerComponent = this.Номенклатура_vmoТаблицаВыдачи;
            this.Номенклатура_vmoТаблицаВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СерийныйНомер_vmoТаблицаВыдачи
            // 
            this.СерийныйНомер_vmoТаблицаВыдачи.Caption = "СерийныйНомер";
            this.СерийныйНомер_vmoТаблицаВыдачи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СерийныйНомер_vmoТаблицаВыдачи.Name = "СерийныйНомер";
            this.СерийныйНомер_vmoТаблицаВыдачи.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СерийныйНомер_vmoТаблицаВыдачи.PropertyType = typeof(string);
            this.СерийныйНомер_vmoТаблицаВыдачи.SearchCondition.OwnerComponent = this.СерийныйНомер_vmoТаблицаВыдачи;
            this.СерийныйНомер_vmoТаблицаВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Выдать_vmoТаблицаВыдачи
            // 
            this.Выдать_vmoТаблицаВыдачи.Caption = "Выдать";
            this.Выдать_vmoТаблицаВыдачи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выдать_vmoТаблицаВыдачи.Name = "Выдать";
            this.Выдать_vmoТаблицаВыдачи.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выдать_vmoТаблицаВыдачи.PropertyType = typeof(bool);
            this.Выдать_vmoТаблицаВыдачи.SearchCondition.OwnerComponent = this.Выдать_vmoТаблицаВыдачи;
            this.Выдать_vmoТаблицаВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpВыдача);
            this.tabControl1.Controls.Add(this.tpПриемка);
            this.tabControl1.Controls.Add(this.tpСерийники);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(917, 480);
            this.tabControl1.TabIndex = 9;
            // 
            // tpВыдача
            // 
            this.tpВыдача.AllowDrop = true;
            this.tpВыдача.Controls.Add(this.nbЗаполнитьПоОбъекту);
            this.tpВыдача.Controls.Add(this.nsgInput8);
            this.tpВыдача.Controls.Add(this.label8);
            this.tpВыдача.Controls.Add(this.cbТребуетсяПодтверждение);
            this.tpВыдача.Controls.Add(this.nbВыдать);
            this.tpВыдача.Controls.Add(this.nbЗаполнить);
            this.tpВыдача.Controls.Add(this.nsgInput3);
            this.tpВыдача.Controls.Add(this.label3);
            this.tpВыдача.Controls.Add(this.nsgInput2);
            this.tpВыдача.Controls.Add(this.label2);
            this.tpВыдача.Controls.Add(this.nsgInput1);
            this.tpВыдача.Controls.Add(this.nsgIGrid1);
            this.tpВыдача.Controls.Add(this.label1);
            this.tpВыдача.Enabled = true;
            this.tpВыдача.Location = new System.Drawing.Point(4, 22);
            this.tpВыдача.Name = "tpВыдача";
            this.tpВыдача.Padding = new System.Windows.Forms.Padding(3);
            this.tpВыдача.Size = new System.Drawing.Size(909, 454);
            this.tpВыдача.TabIndex = 0;
            this.tpВыдача.Text = "Выдача";
            this.tpВыдача.UseVisualStyleBackColor = true;
            this.tpВыдача.Visible = false;
            // 
            // nbЗаполнитьПоОбъекту
            // 
            this.nbЗаполнитьПоОбъекту.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнитьПоОбъекту.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнитьПоОбъекту.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнитьПоОбъекту.Location = new System.Drawing.Point(145, 84);
            this.nbЗаполнитьПоОбъекту.Name = "NsgButton";
            this.nbЗаполнитьПоОбъекту.Size = new System.Drawing.Size(240, 20);
            this.nbЗаполнитьПоОбъекту.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнитьПоОбъекту.TabIndex = 12;
            this.nbЗаполнитьПоОбъекту.Text = "Заполнить по требованиям на объект";
            this.nbЗаполнитьПоОбъекту.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнитьПоОбъекту.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнитьПоОбъекту_AsyncClick);
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "СотрудникВыдачи";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(145, 3);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "СотрудникВыдачи";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(372, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 11;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 3);
            this.label8.Name = "label1";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Сотрудник";
            // 
            // cbТребуетсяПодтверждение
            // 
            this.cbТребуетсяПодтверждение.AutoSize = true;
            this.cbТребуетсяПодтверждение.Location = new System.Drawing.Point(525, 9);
            this.cbТребуетсяПодтверждение.Name = "cbТребуетсяПодтверждение";
            this.cbТребуетсяПодтверждение.Size = new System.Drawing.Size(159, 17);
            this.cbТребуетсяПодтверждение.TabIndex = 9;
            this.cbТребуетсяПодтверждение.Text = "требуется подтверждение";
            this.cbТребуетсяПодтверждение.UseVisualStyleBackColor = true;
            // 
            // nbВыдать
            // 
            this.nbВыдать.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbВыдать.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbВыдать.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbВыдать.Location = new System.Drawing.Point(525, 32);
            this.nbВыдать.Name = "NsgButton";
            this.nbВыдать.Size = new System.Drawing.Size(159, 25);
            this.nbВыдать.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbВыдать.TabIndex = 8;
            this.nbВыдать.Text = "Выдать";
            this.nbВыдать.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbВыдать.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbВыдать_AsyncClick);
            // 
            // nbЗаполнить
            // 
            this.nbЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнить.Location = new System.Drawing.Point(145, 130);
            this.nbЗаполнить.Name = "NsgButton";
            this.nbЗаполнить.Size = new System.Drawing.Size(240, 20);
            this.nbЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнить.TabIndex = 7;
            this.nbЗаполнить.Text = "Заполнить по требованиям на сотрудника";
            this.nbЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнить_AsyncClick);
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "СотрудникПолучатель";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(145, 107);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "СотрудникПолучатель";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(372, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 6;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сотрудник принимающий";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "ОбъектПолучатель";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(145, 61);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ОбъектПолучатель";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(372, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 4;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput2.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.nsgInput2_EndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Объект принимающий";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "ОбъектВыдачи";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(145, 32);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "ОбъектВыдачи";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(372, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 2;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект выдачи";
            // 
            // tpПриемка
            // 
            this.tpПриемка.AllowDrop = true;
            this.tpПриемка.Controls.Add(this.nbОбработатьПодтверждения);
            this.tpПриемка.Controls.Add(this.nsgIGrid2);
            this.tpПриемка.Controls.Add(this.nbЗаполнитьПодтверждения);
            this.tpПриемка.Controls.Add(this.nsgInput5);
            this.tpПриемка.Controls.Add(this.label5);
            this.tpПриемка.Controls.Add(this.nsgInput4);
            this.tpПриемка.Controls.Add(this.label4);
            this.tpПриемка.Enabled = true;
            this.tpПриемка.Location = new System.Drawing.Point(4, 22);
            this.tpПриемка.Name = "tpПриемка";
            this.tpПриемка.Padding = new System.Windows.Forms.Padding(3);
            this.tpПриемка.Size = new System.Drawing.Size(909, 454);
            this.tpПриемка.TabIndex = 1;
            this.tpПриемка.Text = "Подтверждение";
            this.tpПриемка.UseVisualStyleBackColor = true;
            this.tpПриемка.Visible = true;
            // 
            // nbОбработатьПодтверждения
            // 
            this.nbОбработатьПодтверждения.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbОбработатьПодтверждения.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbОбработатьПодтверждения.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbОбработатьПодтверждения.Location = new System.Drawing.Point(337, 55);
            this.nbОбработатьПодтверждения.Name = "NsgButton";
            this.nbОбработатьПодтверждения.Size = new System.Drawing.Size(160, 31);
            this.nbОбработатьПодтверждения.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbОбработатьПодтверждения.TabIndex = 9;
            this.nbОбработатьПодтверждения.Text = "Обработать подтверждения";
            this.nbОбработатьПодтверждения.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbОбработатьПодтверждения.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbОбработатьПодтверждения_AsyncClick);
            // 
            // nbЗаполнитьПодтверждения
            // 
            this.nbЗаполнитьПодтверждения.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнитьПодтверждения.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнитьПодтверждения.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнитьПодтверждения.Location = new System.Drawing.Point(102, 55);
            this.nbЗаполнитьПодтверждения.Name = "NsgButton";
            this.nbЗаполнитьПодтверждения.Size = new System.Drawing.Size(81, 31);
            this.nbЗаполнитьПодтверждения.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнитьПодтверждения.TabIndex = 7;
            this.nbЗаполнитьПодтверждения.Text = "Заполнить таблицу";
            this.nbЗаполнитьПодтверждения.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнитьПодтверждения.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнитьПодтверждения_AsyncClick);
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "СотрудникПодтверждение";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(102, 32);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "СотрудникПодтверждение";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(395, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 6;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 39);
            this.label5.Name = "label1";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Сотрудник";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "ОбъектПодтверждения";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(102, 3);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ОбъектПодтверждения";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(395, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 4;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 10);
            this.label4.Name = "label1";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Объект ";
            // 
            // tpСерийники
            // 
            this.tpСерийники.AllowDrop = true;
            this.tpСерийники.Controls.Add(this.nbНовыеСерийники);
            this.tpСерийники.Controls.Add(this.nsgIGrid3);
            this.tpСерийники.Controls.Add(this.nbПоказатьИнструменты);
            this.tpСерийники.Controls.Add(this.nsgInput6);
            this.tpСерийники.Controls.Add(this.label6);
            this.tpСерийники.Controls.Add(this.nsgInput7);
            this.tpСерийники.Controls.Add(this.label7);
            this.tpСерийники.Enabled = true;
            this.tpСерийники.Location = new System.Drawing.Point(4, 22);
            this.tpСерийники.Name = "tpСерийники";
            this.tpСерийники.Size = new System.Drawing.Size(909, 454);
            this.tpСерийники.TabIndex = 2;
            this.tpСерийники.Text = "Присваивание серийных номеров";
            this.tpСерийники.UseVisualStyleBackColor = true;
            this.tpСерийники.Visible = false;
            // 
            // nbНовыеСерийники
            // 
            this.nbНовыеСерийники.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbНовыеСерийники.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbНовыеСерийники.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbНовыеСерийники.Location = new System.Drawing.Point(235, 38);
            this.nbНовыеСерийники.Name = "NsgButton";
            this.nbНовыеСерийники.Size = new System.Drawing.Size(204, 20);
            this.nbНовыеСерийники.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbНовыеСерийники.TabIndex = 13;
            this.nbНовыеСерийники.Text = "Присвоить новые серийные номера";
            this.nbНовыеСерийники.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbНовыеСерийники.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbНовыеСерийники_AsyncClick);
            // 
            // nbПоказатьИнструменты
            // 
            this.nbПоказатьИнструменты.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbПоказатьИнструменты.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbПоказатьИнструменты.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbПоказатьИнструменты.Location = new System.Drawing.Point(235, 9);
            this.nbПоказатьИнструменты.Name = "NsgButton";
            this.nbПоказатьИнструменты.Size = new System.Drawing.Size(157, 20);
            this.nbПоказатьИнструменты.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbПоказатьИнструменты.TabIndex = 11;
            this.nbПоказатьИнструменты.Text = "Показать";
            this.nbПоказатьИнструменты.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbПоказатьИнструменты.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbПоказатьИнструменты_AsyncClick);
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "СотрудникСерийники";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(102, 38);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "СотрудникСерийники";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(130, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 10;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 45);
            this.label6.Name = "label1";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сотрудник";
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "ОбъектСерийники";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(102, 9);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "ОбъектСерийники";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(130, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 8;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 16);
            this.label7.Name = "label1";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Объект ";
            // 
            // СотрудникПолучатель
            // 
            this.СотрудникПолучатель.Caption = "СотрудникПолучатель";
            this.СотрудникПолучатель.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникПолучатель.Name = "СотрудникПолучатель";
            this.СотрудникПолучатель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПолучатель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПолучатель.SearchCondition.OwnerComponent = this.СотрудникПолучатель;
            this.СотрудникПолучатель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектПолучатель
            // 
            this.ОбъектПолучатель.Caption = "ОбъектПолучатель";
            this.ОбъектПолучатель.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъектПолучатель.Name = "ОбъектПолучатель";
            this.ОбъектПолучатель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектПолучатель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектПолучатель.SearchCondition.OwnerComponent = this.ОбъектПолучатель;
            this.ОбъектПолучатель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектВыдачи
            // 
            this.ОбъектВыдачи.Caption = "ОбъектВыдачи";
            this.ОбъектВыдачи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъектВыдачи.Name = "ОбъектВыдачи";
            this.ОбъектВыдачи.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачи.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачи.SearchCondition.OwnerComponent = this.ОбъектВыдачи;
            this.ОбъектВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектПодтверждения
            // 
            this.ОбъектПодтверждения.Caption = "ОбъектПодтверждения";
            this.ОбъектПодтверждения.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъектПодтверждения.Name = "ОбъектПодтверждения";
            this.ОбъектПодтверждения.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектПодтверждения.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектПодтверждения.SearchCondition.OwnerComponent = this.ОбъектПодтверждения;
            this.ОбъектПодтверждения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СотрудникПодтверждение
            // 
            this.СотрудникПодтверждение.Caption = "СотрудникПодтверждение";
            this.СотрудникПодтверждение.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникПодтверждение.Name = "СотрудникПодтверждение";
            this.СотрудникПодтверждение.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПодтверждение.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПодтверждение.SearchCondition.OwnerComponent = this.СотрудникПодтверждение;
            this.СотрудникПодтверждение.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СотрудникСерийники
            // 
            this.СотрудникСерийники.Caption = "СотрудникСерийники";
            this.СотрудникСерийники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникСерийники.Name = "СотрудникСерийники";
            this.СотрудникСерийники.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникСерийники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникСерийники.SearchCondition.OwnerComponent = this.СотрудникСерийники;
            this.СотрудникСерийники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектСерийники
            // 
            this.ОбъектСерийники.Caption = "ОбъектСерийники";
            this.ОбъектСерийники.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъектСерийники.Name = "ОбъектСерийники";
            this.ОбъектСерийники.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектСерийники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектСерийники.SearchCondition.OwnerComponent = this.ОбъектСерийники;
            this.ОбъектСерийники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СотрудникВыдачи
            // 
            this.СотрудникВыдачи.Caption = "СотрудникВыдачи";
            this.СотрудникВыдачи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникВыдачи.Name = "СотрудникВыдачи";
            this.СотрудникВыдачи.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникВыдачи.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникВыдачи.SearchCondition.OwnerComponent = this.СотрудникВыдачи;
            this.СотрудникВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КонтрольИнструментаФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(923, 548);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаПодтверждения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСменаСерийников)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаВыдачи)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpВыдача.ResumeLayout(false);
            this.tpВыдача.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПоОбъекту)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.tpПриемка.ResumeLayout(false);
            this.tpПриемка.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbОбработатьПодтверждения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПодтверждения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            this.tpСерийники.ResumeLayout(false);
            this.tpСерийники.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbНовыеСерийники)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbПоказатьИнструменты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpВыдача;
        private System.Windows.Forms.TabPage tpПриемка;
        protected Мониторинг.Объекты.ColumnDescriptor ОбъектВыдачи;
        protected NsgInput nsgInput1;
        private System.Windows.Forms.Label label1;
        protected Мониторинг.Объекты.ColumnDescriptor ОбъектПолучатель;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникПолучатель;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        protected NsgInput nsgInput2;
        protected System.Windows.Forms.Label label2;
        private NsgVisualMultipleObject vmoТаблицаВыдачи;
        protected NsgSoft.Design.NsgButton nbЗаполнить;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoТаблицаВыдачи;
        protected NsgColumnDescriptor.String СерийныйНомер_vmoТаблицаВыдачи;
        private NsgColumnDescriptor.Boolean Выдать_vmoТаблицаВыдачи;
        protected NsgSoft.Design.NsgButton nbВыдать;
        private System.Windows.Forms.CheckBox cbТребуетсяПодтверждение;
        protected NsgColumnDescriptor.String СерийныйНомер_vmoТаблицаПодтверждения;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoТаблицаПодтверждения;
        protected NsgColumnDescriptor.Boolean ПодтвердитьПолучение_vmoТаблицаПодтверждения;
        protected NsgColumnDescriptor.Boolean ОформитьВозврать_vmoТаблицаПодтверждения;
        protected Мониторинг.Объекты.ColumnDescriptor ОбъектПодтверждения;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникПодтверждение;
        protected NsgSoft.Design.NsgButton nbЗаполнитьПодтверждения;
        protected NsgInput nsgInput5;
        protected System.Windows.Forms.Label label5;
        protected NsgInput nsgInput4;
        protected System.Windows.Forms.Label label4;
        private NsgVisualMultipleObject vmoТаблицаПодтверждения;
        private NsgIGrid nsgIGrid2;
        protected NsgSoft.Design.NsgButton nbОбработатьПодтверждения;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoТаблицаПодтверждения;
        private Мониторинг.Объекты.ColumnDescriptor Объект_vmoТаблицаПодтверждения;
        private System.Windows.Forms.TabPage tpСерийники;
        protected Мониторинг.Объекты.ColumnDescriptor ОбъектСерийники;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникСерийники;
        protected NsgSoft.Design.NsgButton nbПоказатьИнструменты;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.Label label6;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoСменаСерийников;
        protected NsgColumnDescriptor.String ТекущийСерийник_vmoСменаСерийников;
        protected NsgColumnDescriptor.String НовыйСерийник_vmoСменаСерийников;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoСменаСерийников;
        protected NsgColumnDescriptor.Boolean Подтвердить_vmoСменаСерийников;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoСменаСерийников;
        protected NsgSoft.Design.NsgButton nbНовыеСерийники;
        private NsgVisualMultipleObject vmoСменаСерийников;
        private NsgIGrid nsgIGrid3;
        private NsgIGrid nsgIGrid1;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникВыдачи;
        protected NsgSoft.Design.NsgButton nbЗаполнитьПоОбъекту;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label8;
    }
}