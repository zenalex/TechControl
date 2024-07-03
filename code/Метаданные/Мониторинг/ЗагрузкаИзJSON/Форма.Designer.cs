using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ЗагрузкаИзJSONФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ЗагрузкаИзJSONФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn35 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn36 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn37 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn38 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn39 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn40 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn41 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn42 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn43 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn15 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn44 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn45 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn46 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn21 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn22 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoКонтрагенты = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Выбор_к = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Идентификатор_к = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Наименование_к = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Адрес_к = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ИНН_к = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ЭтоФирма_к = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Найдено_к = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoОбъекты = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Выбор_о = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Идентификатор_о = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Наименование_о = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Адрес_о = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Договор_о = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Заказчик_о = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Фирма_о = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Найдено_о = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ДоговорСсылка_о = new TechControl.Метаданные.Мониторинг.Договоры.ColumnDescriptor();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСотрудники = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Выбор_с = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Имя_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Отчество_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Фамилия_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаРождения_с = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаПриемаНаРаботу_с = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаУвольнения_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Телефон_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ТабельныйНомер_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Найдено_с = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Идентификатор_с = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Наименование_с = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nsgIGrid4 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТарифы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Выбор_т = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Наименование_т = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Объект_т = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник_т = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Стоимость_т = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Найдено_т = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputПовторноКА = new NsgSoft.Forms.NsgInput();
            this.nsgLabel1 = new NsgSoft.Forms.NsgLabel();
            this.bСохранитьКА = new NsgSoft.Design.NsgButton();
            this.bЗаполнитьКА = new NsgSoft.Design.NsgButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inputПовторноОбъ = new NsgSoft.Forms.NsgInput();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.bСохранитьОбъекты = new NsgSoft.Design.NsgButton();
            this.bЗаполнитьОбъекты = new NsgSoft.Design.NsgButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inputПовторноСотр = new NsgSoft.Forms.NsgInput();
            this.nsgLabel3 = new NsgSoft.Forms.NsgLabel();
            this.bСохранитьСотрудников = new NsgSoft.Design.NsgButton();
            this.bЗаполнитьСотрудников = new NsgSoft.Design.NsgButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.inputПовторноТар = new NsgSoft.Forms.NsgInput();
            this.nsgLabel4 = new NsgSoft.Forms.NsgLabel();
            this.bСохранитьТарифы = new NsgSoft.Design.NsgButton();
            this.bЗаполнитьТарифы = new NsgSoft.Design.NsgButton();
            this.ПовторноТар_ = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ПовторноСотр_ = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ПовторноОбъ_ = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ПовторноКА_ = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.bСохранитьТарифыВОбъектах = new NsgSoft.Design.NsgButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагенты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoОбъекты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСотрудники)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноКА)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьКА)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьКА)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноОбъ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьОбъекты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьОбъекты)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноСотр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьСотрудников)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьСотрудников)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноТар)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьТарифы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьТарифы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьТарифыВОбъектах)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 433);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(1069, 30);
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
            this.printButton.Location = new System.Drawing.Point(1049, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПовторноКА_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПовторноОбъ_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПовторноСотр_);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПовторноТар_);
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
            nsgIGridColumn35.AllowFilter = true;
            nsgIGridColumn35.AllowGroupSelect = false;
            nsgIGridColumn35.AllowResize = true;
            nsgIGridColumn35.AutoResize = true;
            nsgIGridColumn35.Caption = "";
            nsgIGridColumn35.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn35.DateFormat = null;
            nsgIGridColumn35.Name = "Выбор";
            nsgIGridColumn35.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn35.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn35.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn35.UseAsHeaderImage = false;
            nsgIGridColumn35.Width = 100;
            nsgIGridColumn36.AllowFilter = true;
            nsgIGridColumn36.AllowGroupSelect = false;
            nsgIGridColumn36.AllowResize = true;
            nsgIGridColumn36.AutoResize = true;
            nsgIGridColumn36.Caption = "";
            nsgIGridColumn36.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn36.DateFormat = null;
            nsgIGridColumn36.Name = "Идентификатор";
            nsgIGridColumn36.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn36.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn36.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn36.UseAsHeaderImage = false;
            nsgIGridColumn36.Width = 100;
            nsgIGridColumn37.AllowFilter = true;
            nsgIGridColumn37.AllowGroupSelect = false;
            nsgIGridColumn37.AllowResize = true;
            nsgIGridColumn37.AutoResize = true;
            nsgIGridColumn37.Caption = "";
            nsgIGridColumn37.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn37.DateFormat = null;
            nsgIGridColumn37.Name = "Наименование";
            nsgIGridColumn37.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn37.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn37.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn37.UseAsHeaderImage = false;
            nsgIGridColumn37.Width = 100;
            nsgIGridColumn38.AllowFilter = true;
            nsgIGridColumn38.AllowGroupSelect = false;
            nsgIGridColumn38.AllowResize = true;
            nsgIGridColumn38.AutoResize = true;
            nsgIGridColumn38.Caption = "";
            nsgIGridColumn38.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn38.DateFormat = null;
            nsgIGridColumn38.Name = "Адрес";
            nsgIGridColumn38.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn38.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn38.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn38.UseAsHeaderImage = false;
            nsgIGridColumn38.Width = 100;
            nsgIGridColumn39.AllowFilter = true;
            nsgIGridColumn39.AllowGroupSelect = false;
            nsgIGridColumn39.AllowResize = true;
            nsgIGridColumn39.AutoResize = true;
            nsgIGridColumn39.Caption = "";
            nsgIGridColumn39.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn39.DateFormat = null;
            nsgIGridColumn39.Name = "ИНН";
            nsgIGridColumn39.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn39.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn39.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn39.UseAsHeaderImage = false;
            nsgIGridColumn39.Width = 100;
            nsgIGridColumn40.AllowFilter = true;
            nsgIGridColumn40.AllowGroupSelect = false;
            nsgIGridColumn40.AllowResize = true;
            nsgIGridColumn40.AutoResize = true;
            nsgIGridColumn40.Caption = "";
            nsgIGridColumn40.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn40.DateFormat = null;
            nsgIGridColumn40.Name = "ЭтоФирма";
            nsgIGridColumn40.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn40.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn40.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn40.UseAsHeaderImage = false;
            nsgIGridColumn40.Width = 100;
            nsgIGridColumn41.AllowFilter = true;
            nsgIGridColumn41.AllowGroupSelect = false;
            nsgIGridColumn41.AllowResize = true;
            nsgIGridColumn41.AutoResize = true;
            nsgIGridColumn41.Caption = "";
            nsgIGridColumn41.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn41.DateFormat = null;
            nsgIGridColumn41.Name = "Найдено";
            nsgIGridColumn41.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn41.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn41.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn41.UseAsHeaderImage = false;
            nsgIGridColumn41.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn35);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn36);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn37);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn38);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn39);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn40);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn41);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(0, 37);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(1058, 370);
            this.nsgIGrid1.SourceObject = this.vmoКонтрагенты;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoКонтрагенты
            // 
            this.vmoКонтрагенты.Columns.Collection.Add(this.Выбор_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.Идентификатор_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.Наименование_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.Адрес_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.ИНН_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.ЭтоФирма_к);
            this.vmoКонтрагенты.Columns.Collection.Add(this.Найдено_к);
            this.vmoКонтрагенты.IsActive = true;
            this.vmoКонтрагенты.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoКонтрагенты.MetaDataName = "";
            this.vmoКонтрагенты.FullName = "";
            // 
            // Выбор_к
            // 
            this.Выбор_к.Caption = "Выбор";
            this.Выбор_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выбор_к.Name = "Выбор";
            this.Выбор_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выбор_к.PropertyType = typeof(bool);
            this.Выбор_к.SearchCondition.OwnerComponent = this.Выбор_к;
            this.Выбор_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_к
            // 
            this.Идентификатор_к.Caption = "Идентификатор";
            this.Идентификатор_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Идентификатор_к.Name = "Идентификатор";
            this.Идентификатор_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_к.PropertyType = typeof(System.Guid);
            this.Идентификатор_к.SearchCondition.OwnerComponent = this.Идентификатор_к;
            this.Идентификатор_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_к
            // 
            this.Наименование_к.Caption = "Наименование";
            this.Наименование_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Наименование_к.Name = "Наименование";
            this.Наименование_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_к.PropertyType = typeof(string);
            this.Наименование_к.SearchCondition.OwnerComponent = this.Наименование_к;
            this.Наименование_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Адрес_к
            // 
            this.Адрес_к.Caption = "Адрес";
            this.Адрес_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Адрес_к.Name = "Адрес";
            this.Адрес_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Адрес_к.PropertyType = typeof(string);
            this.Адрес_к.SearchCondition.OwnerComponent = this.Адрес_к;
            this.Адрес_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИНН_к
            // 
            this.ИНН_к.Caption = "ИНН";
            this.ИНН_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИНН_к.Name = "ИНН";
            this.ИНН_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИНН_к.PropertyType = typeof(string);
            this.ИНН_к.SearchCondition.OwnerComponent = this.ИНН_к;
            this.ИНН_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЭтоФирма_к
            // 
            this.ЭтоФирма_к.Caption = "ЭтоФирма";
            this.ЭтоФирма_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЭтоФирма_к.Name = "ЭтоФирма";
            this.ЭтоФирма_к.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоФирма_к.PropertyType = typeof(bool);
            this.ЭтоФирма_к.SearchCondition.OwnerComponent = this.ЭтоФирма_к;
            this.ЭтоФирма_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Найдено_к
            // 
            this.Найдено_к.Caption = "Найдено";
            this.Найдено_к.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Найдено_к.Name = "Найдено";
            this.Найдено_к.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Найдено_к.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Найдено_к.ReadOnly = true;
            this.Найдено_к.SearchCondition.OwnerComponent = this.Найдено_к;
            this.Найдено_к.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn1.Name = "Выбор";
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
            nsgIGridColumn2.Name = "Идентификатор";
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
        "Visible"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.Name = "Наименование";
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
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "Адрес";
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
        "Visible"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "Договор";
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
            nsgIGridColumn6.Name = "ДоговорСсылка";
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
            nsgIGridColumn7.Name = "Заказчик";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Width = 100;
            nsgIGridColumn42.AllowFilter = true;
            nsgIGridColumn42.AllowGroupSelect = false;
            nsgIGridColumn42.AllowResize = true;
            nsgIGridColumn42.AutoResize = true;
            nsgIGridColumn42.Caption = "";
            nsgIGridColumn42.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn42.DateFormat = null;
            nsgIGridColumn42.Name = "Фирма";
            nsgIGridColumn42.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn42.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn42.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn42.UseAsHeaderImage = false;
            nsgIGridColumn42.Width = 100;
            nsgIGridColumn43.AllowFilter = true;
            nsgIGridColumn43.AllowGroupSelect = false;
            nsgIGridColumn43.AllowResize = true;
            nsgIGridColumn43.AutoResize = true;
            nsgIGridColumn43.Caption = "";
            nsgIGridColumn43.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn43.DateFormat = null;
            nsgIGridColumn43.Name = "Найдено";
            nsgIGridColumn43.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn43.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn43.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn43.UseAsHeaderImage = false;
            nsgIGridColumn43.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn42);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn43);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(0, 37);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(1058, 370);
            this.nsgIGrid2.SourceObject = this.vmoОбъекты;
            this.nsgIGrid2.TabIndex = 9;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoОбъекты
            // 
            this.vmoОбъекты.Columns.Collection.Add(this.Выбор_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Идентификатор_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Наименование_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Адрес_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Договор_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Заказчик_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Фирма_о);
            this.vmoОбъекты.Columns.Collection.Add(this.Найдено_о);
            this.vmoОбъекты.Columns.Collection.Add(this.ДоговорСсылка_о);
            this.vmoОбъекты.IsActive = true;
            this.vmoОбъекты.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoОбъекты.MetaDataName = "";
            this.vmoОбъекты.FullName = "";
            // 
            // Выбор_о
            // 
            this.Выбор_о.Caption = "Выбор";
            this.Выбор_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выбор_о.Name = "Выбор";
            this.Выбор_о.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выбор_о.PropertyType = typeof(bool);
            this.Выбор_о.SearchCondition.OwnerComponent = this.Выбор_о;
            this.Выбор_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_о
            // 
            this.Идентификатор_о.Caption = "Идентификатор";
            this.Идентификатор_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Идентификатор_о.Name = "Идентификатор";
            this.Идентификатор_о.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_о.PropertyType = typeof(System.Guid);
            this.Идентификатор_о.SearchCondition.OwnerComponent = this.Идентификатор_о;
            this.Идентификатор_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_о
            // 
            this.Наименование_о.Caption = "Наименование";
            this.Наименование_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Наименование_о.Name = "Наименование";
            this.Наименование_о.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_о.PropertyType = typeof(string);
            this.Наименование_о.SearchCondition.OwnerComponent = this.Наименование_о;
            this.Наименование_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Адрес_о
            // 
            this.Адрес_о.Caption = "Адрес";
            this.Адрес_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Адрес_о.Name = "Адрес";
            this.Адрес_о.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Адрес_о.PropertyType = typeof(string);
            this.Адрес_о.SearchCondition.OwnerComponent = this.Адрес_о;
            this.Адрес_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Договор_о
            // 
            this.Договор_о.Caption = "Договор";
            this.Договор_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Договор_о.Name = "Договор";
            this.Договор_о.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Договор_о.PropertyType = typeof(string);
            this.Договор_о.SearchCondition.OwnerComponent = this.Договор_о;
            this.Договор_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик_о
            // 
            this.Заказчик_о.Caption = "Заказчик";
            this.Заказчик_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Заказчик_о.Name = "Заказчик";
            this.Заказчик_о.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_о.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик_о.SearchCondition.OwnerComponent = this.Заказчик_о;
            this.Заказчик_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Фирма_о
            // 
            this.Фирма_о.Caption = "Фирма";
            this.Фирма_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фирма_о.Name = "Фирма";
            this.Фирма_о.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма_о.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма_о.SearchCondition.OwnerComponent = this.Фирма_о;
            this.Фирма_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Найдено_о
            // 
            this.Найдено_о.Caption = "Найдено";
            this.Найдено_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Найдено_о.Name = "Найдено";
            this.Найдено_о.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Найдено_о.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Найдено_о.ReadOnly = true;
            this.Найдено_о.SearchCondition.OwnerComponent = this.Найдено_о;
            this.Найдено_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДоговорСсылка_о
            // 
            this.ДоговорСсылка_о.Caption = "ДоговорСсылка";
            this.ДоговорСсылка_о.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДоговорСсылка_о.Name = "ДоговорСсылка";
            this.ДоговорСсылка_о.NSGType = typeof(TechControl.Метаданные.Мониторинг.Договоры);
            this.ДоговорСсылка_о.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Договоры);
            this.ДоговорСсылка_о.SearchCondition.OwnerComponent = this.ДоговорСсылка_о;
            this.ДоговорСсылка_о.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn8.AllowFilter = true;
            nsgIGridColumn8.AllowGroupSelect = false;
            nsgIGridColumn8.AllowResize = true;
            nsgIGridColumn8.AutoResize = true;
            nsgIGridColumn8.Caption = "";
            nsgIGridColumn8.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "Выбор";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn9.Name = "Идентификатор";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn10.Name = "Наименование";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
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
            nsgIGridColumn11.Name = "Имя";
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
            nsgIGridColumn12.Name = "Отчество";
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
        "Visible",
        "Index"};
            nsgIGridColumn13.DateFormat = null;
            nsgIGridColumn13.Name = "Фамилия";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
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
            nsgIGridColumn14.Name = "ДатаРождения";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Width = 100;
            nsgIGridColumn15.AllowFilter = true;
            nsgIGridColumn15.AllowGroupSelect = false;
            nsgIGridColumn15.AllowResize = true;
            nsgIGridColumn15.AutoResize = true;
            nsgIGridColumn15.Caption = "";
            nsgIGridColumn15.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn15.DateFormat = null;
            nsgIGridColumn15.Name = "ДатаПриемаНаРаботу";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn15.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn15.UseAsHeaderImage = false;
            nsgIGridColumn15.Width = 100;
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.Name = "ДатаУвольнения";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn16.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn16.UseAsHeaderImage = false;
            nsgIGridColumn16.Width = 100;
            nsgIGridColumn44.AllowFilter = true;
            nsgIGridColumn44.AllowGroupSelect = false;
            nsgIGridColumn44.AllowResize = true;
            nsgIGridColumn44.AutoResize = true;
            nsgIGridColumn44.Caption = "";
            nsgIGridColumn44.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn44.DateFormat = null;
            nsgIGridColumn44.Name = "Телефон";
            nsgIGridColumn44.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn44.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn44.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn44.UseAsHeaderImage = false;
            nsgIGridColumn44.Width = 100;
            nsgIGridColumn45.AllowFilter = true;
            nsgIGridColumn45.AllowGroupSelect = false;
            nsgIGridColumn45.AllowResize = true;
            nsgIGridColumn45.AutoResize = true;
            nsgIGridColumn45.Caption = "";
            nsgIGridColumn45.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn45.DateFormat = null;
            nsgIGridColumn45.Name = "ТабельныйНомер";
            nsgIGridColumn45.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn45.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn45.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn45.UseAsHeaderImage = false;
            nsgIGridColumn45.Width = 100;
            nsgIGridColumn46.AllowFilter = true;
            nsgIGridColumn46.AllowGroupSelect = false;
            nsgIGridColumn46.AllowResize = true;
            nsgIGridColumn46.AutoResize = true;
            nsgIGridColumn46.Caption = "";
            nsgIGridColumn46.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn46.DateFormat = null;
            nsgIGridColumn46.Name = "Найдено";
            nsgIGridColumn46.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn46.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn46.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn46.UseAsHeaderImage = false;
            nsgIGridColumn46.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn44);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn45);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn46);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(0, 37);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(1058, 370);
            this.nsgIGrid3.SourceObject = this.vmoСотрудники;
            this.nsgIGrid3.TabIndex = 9;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoСотрудники
            // 
            this.vmoСотрудники.Columns.Collection.Add(this.Выбор_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Имя_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Отчество_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Фамилия_с);
            this.vmoСотрудники.Columns.Collection.Add(this.ДатаРождения_с);
            this.vmoСотрудники.Columns.Collection.Add(this.ДатаПриемаНаРаботу_с);
            this.vmoСотрудники.Columns.Collection.Add(this.ДатаУвольнения_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Телефон_с);
            this.vmoСотрудники.Columns.Collection.Add(this.ТабельныйНомер_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Найдено_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Идентификатор_с);
            this.vmoСотрудники.Columns.Collection.Add(this.Наименование_с);
            this.vmoСотрудники.IsActive = true;
            this.vmoСотрудники.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСотрудники.MetaDataName = "";
            this.vmoСотрудники.FullName = "";
            // 
            // Выбор_с
            // 
            this.Выбор_с.Caption = "Выбор";
            this.Выбор_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выбор_с.Name = "Выбор";
            this.Выбор_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выбор_с.PropertyType = typeof(bool);
            this.Выбор_с.SearchCondition.OwnerComponent = this.Выбор_с;
            this.Выбор_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Имя_с
            // 
            this.Имя_с.Caption = "Имя";
            this.Имя_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Имя_с.Name = "Имя";
            this.Имя_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Имя_с.PropertyType = typeof(string);
            this.Имя_с.SearchCondition.OwnerComponent = this.Имя_с;
            this.Имя_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Отчество_с
            // 
            this.Отчество_с.Caption = "Отчество";
            this.Отчество_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Отчество_с.Name = "Отчество";
            this.Отчество_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Отчество_с.PropertyType = typeof(string);
            this.Отчество_с.SearchCondition.OwnerComponent = this.Отчество_с;
            this.Отчество_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Фамилия_с
            // 
            this.Фамилия_с.Caption = "Фамилия";
            this.Фамилия_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фамилия_с.Name = "Фамилия";
            this.Фамилия_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Фамилия_с.PropertyType = typeof(string);
            this.Фамилия_с.SearchCondition.OwnerComponent = this.Фамилия_с;
            this.Фамилия_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаРождения_с
            // 
            this.ДатаРождения_с.Caption = "ДатаРождения";
            this.ДатаРождения_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаРождения_с.Name = "ДатаРождения";
            this.ДатаРождения_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаРождения_с.PropertyType = typeof(System.DateTime);
            this.ДатаРождения_с.SearchCondition.OwnerComponent = this.ДатаРождения_с;
            this.ДатаРождения_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаПриемаНаРаботу_с
            // 
            this.ДатаПриемаНаРаботу_с.Caption = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаПриемаНаРаботу_с.Name = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПриемаНаРаботу_с.PropertyType = typeof(System.DateTime);
            this.ДатаПриемаНаРаботу_с.SearchCondition.OwnerComponent = this.ДатаПриемаНаРаботу_с;
            this.ДатаПриемаНаРаботу_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаУвольнения_с
            // 
            this.ДатаУвольнения_с.Caption = "ДатаУвольнения";
            this.ДатаУвольнения_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаУвольнения_с.Name = "ДатаУвольнения";
            this.ДатаУвольнения_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ДатаУвольнения_с.PropertyType = typeof(string);
            this.ДатаУвольнения_с.SearchCondition.OwnerComponent = this.ДатаУвольнения_с;
            this.ДатаУвольнения_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Телефон_с
            // 
            this.Телефон_с.Caption = "Телефон";
            this.Телефон_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Телефон_с.Name = "Телефон";
            this.Телефон_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Телефон_с.PropertyType = typeof(string);
            this.Телефон_с.SearchCondition.OwnerComponent = this.Телефон_с;
            this.Телефон_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТабельныйНомер_с
            // 
            this.ТабельныйНомер_с.Caption = "ТабельныйНомер";
            this.ТабельныйНомер_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТабельныйНомер_с.Name = "ТабельныйНомер";
            this.ТабельныйНомер_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ТабельныйНомер_с.PropertyType = typeof(string);
            this.ТабельныйНомер_с.SearchCondition.OwnerComponent = this.ТабельныйНомер_с;
            this.ТабельныйНомер_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Найдено_с
            // 
            this.Найдено_с.Caption = "Найдено";
            this.Найдено_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Найдено_с.Name = "Найдено";
            this.Найдено_с.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Найдено_с.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Найдено_с.SearchCondition.OwnerComponent = this.Найдено_с;
            this.Найдено_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_с
            // 
            this.Идентификатор_с.Caption = "Идентификатор";
            this.Идентификатор_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Идентификатор_с.Name = "Идентификатор";
            this.Идентификатор_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_с.PropertyType = typeof(System.Guid);
            this.Идентификатор_с.SearchCondition.OwnerComponent = this.Идентификатор_с;
            this.Идентификатор_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_с
            // 
            this.Наименование_с.Caption = "Наименование";
            this.Наименование_с.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Наименование_с.Name = "Наименование";
            this.Наименование_с.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_с.PropertyType = typeof(string);
            this.Наименование_с.SearchCondition.OwnerComponent = this.Наименование_с;
            this.Наименование_с.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid4
            // 
            this.nsgIGrid4.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid4.AllowSaveColParamsToXML = true;
            this.nsgIGrid4.AllowSaveColPositionToXML = true;
            this.nsgIGrid4.AllowSaveColWidthToXML = true;
            this.nsgIGrid4.AllowSaveSettingsToXML = true;
            this.nsgIGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid4.AutoResizeCols = true;
            nsgIGridColumn17.AllowFilter = true;
            nsgIGridColumn17.AllowGroupSelect = false;
            nsgIGridColumn17.AllowResize = true;
            nsgIGridColumn17.AutoResize = true;
            nsgIGridColumn17.Caption = "";
            nsgIGridColumn17.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn17.DateFormat = null;
            nsgIGridColumn17.Name = "Выбор";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn18.Name = "Наименование";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn19.Name = "Объект";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn20.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn21.Name = "Стоимость";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Width = 100;
            nsgIGridColumn22.AllowFilter = true;
            nsgIGridColumn22.AllowGroupSelect = false;
            nsgIGridColumn22.AllowResize = true;
            nsgIGridColumn22.AutoResize = true;
            nsgIGridColumn22.Caption = "";
            nsgIGridColumn22.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn22.DateFormat = null;
            nsgIGridColumn22.Name = "Найдено";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn22.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn22.UseAsHeaderImage = false;
            nsgIGridColumn22.Width = 100;
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn22);
            this.nsgIGrid4.Filter = false;
            this.nsgIGrid4.FrozenColumns = 0;
            this.nsgIGrid4.Grouping = true;
            this.nsgIGrid4.Hierarhy = true;
            this.nsgIGrid4.ImageList = null;
            this.nsgIGrid4.IsCanMultiSelect = false;
            this.nsgIGrid4.IsCanSingleSelect = false;
            this.nsgIGrid4.LineHeight = 20;
            this.nsgIGrid4.Location = new System.Drawing.Point(0, 37);
            this.nsgIGrid4.MarkReadOnly = false;
            this.nsgIGrid4.MasterObject = null;
            this.nsgIGrid4.Name = "NsgIGrid";
            this.nsgIGrid4.PageSelector = false;
            this.nsgIGrid4.ReadOnly = false;
            this.nsgIGrid4.RowChangeInterval = 200;
            this.nsgIGrid4.RowHeaderImageList = null;
            this.nsgIGrid4.RowMode = false;
            this.nsgIGrid4.ScrollWidth = 0;
            this.nsgIGrid4.SelectedRow = -1;
            this.nsgIGrid4.ShowHeader = true;
            this.nsgIGrid4.ShowLineImages = true;
            this.nsgIGrid4.ShowLineNumbers = false;
            this.nsgIGrid4.ShowPanel = true;
            this.nsgIGrid4.ShowTotals = false;
            this.nsgIGrid4.ShowTree = false;
            this.nsgIGrid4.Size = new System.Drawing.Size(1058, 370);
            this.nsgIGrid4.SourceObject = this.vmoТарифы;
            this.nsgIGrid4.TabIndex = 9;
            this.nsgIGrid4.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoТарифы
            // 
            this.vmoТарифы.Columns.Collection.Add(this.Выбор_т);
            this.vmoТарифы.Columns.Collection.Add(this.Наименование_т);
            this.vmoТарифы.Columns.Collection.Add(this.Объект_т);
            this.vmoТарифы.Columns.Collection.Add(this.Сотрудник_т);
            this.vmoТарифы.Columns.Collection.Add(this.Стоимость_т);
            this.vmoТарифы.Columns.Collection.Add(this.Найдено_т);
            this.vmoТарифы.IsActive = true;
            this.vmoТарифы.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТарифы.MetaDataName = "";
            this.vmoТарифы.FullName = "";
            // 
            // Выбор_т
            // 
            this.Выбор_т.Caption = "Выбор";
            this.Выбор_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Выбор_т.Name = "Выбор";
            this.Выбор_т.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Выбор_т.PropertyType = typeof(bool);
            this.Выбор_т.SearchCondition.OwnerComponent = this.Выбор_т;
            this.Выбор_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_т
            // 
            this.Наименование_т.Caption = "Наименование";
            this.Наименование_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Наименование_т.Name = "Наименование";
            this.Наименование_т.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_т.PropertyType = typeof(string);
            this.Наименование_т.SearchCondition.OwnerComponent = this.Наименование_т;
            this.Наименование_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_т
            // 
            this.Объект_т.Caption = "Объект";
            this.Объект_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_т.Name = "Объект";
            this.Объект_т.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_т.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_т.SearchCondition.OwnerComponent = this.Объект_т;
            this.Объект_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_т
            // 
            this.Сотрудник_т.Caption = "Сотрудник";
            this.Сотрудник_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_т.Name = "Сотрудник";
            this.Сотрудник_т.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_т.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_т.SearchCondition.OwnerComponent = this.Сотрудник_т;
            this.Сотрудник_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Стоимость_т
            // 
            this.Стоимость_т.CalcTotal = false;
            this.Стоимость_т.Caption = "Стоимость";
            this.Стоимость_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Стоимость_т.Name = "Стоимость";
            this.Стоимость_т.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Стоимость_т.PropertyType = typeof(decimal);
            this.Стоимость_т.SearchCondition.OwnerComponent = this.Стоимость_т;
            this.Стоимость_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Найдено_т
            // 
            this.Найдено_т.Caption = "Найдено";
            this.Найдено_т.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Найдено_т.Name = "Найдено";
            this.Найдено_т.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Найдено_т.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Найдено_т.SearchCondition.OwnerComponent = this.Найдено_т;
            this.Найдено_т.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(1066, 433);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.inputПовторноКА);
            this.tabPage1.Controls.Add(this.nsgLabel1);
            this.tabPage1.Controls.Add(this.bСохранитьКА);
            this.tabPage1.Controls.Add(this.bЗаполнитьКА);
            this.tabPage1.Controls.Add(this.nsgIGrid1);
            this.tabPage1.Enabled = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Контрагенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Visible = false;
            // 
            // inputПовторноКА
            // 
            this.inputПовторноКА.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputПовторноКА.BackColor = System.Drawing.SystemColors.Control;
            this.inputПовторноКА.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputПовторноКА.ConfigurationName = "";
            this.inputПовторноКА.DisableLeaveControlEvent = false;
            this.inputПовторноКА.FullName = "ПовторноКА";
            this.inputПовторноКА.FullTextSearch = false;
            this.inputПовторноКА.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.inputПовторноКА.IsButton = false;
            this.inputПовторноКА.IsInitialized = true;
            this.inputПовторноКА.IsPassword = false;
            this.inputПовторноКА.Location = new System.Drawing.Point(886, 6);
            this.inputПовторноКА.Margin = new System.Windows.Forms.Padding(0);
            this.inputПовторноКА.Mask = "";
            this.inputПовторноКА.MetaDataName = "";
            this.inputПовторноКА.MinimumSize = new System.Drawing.Size(4, 20);
            this.inputПовторноКА.Name = "NsgInput";
            this.inputПовторноКА.ObjectImages = null;
            this.inputПовторноКА.ObjectIndex = null;
            this.inputПовторноКА.ObjectStrings = null;
            this.inputПовторноКА.Requsite = "ПовторноКА";
            this.inputПовторноКА.SearchFieldName = "";
            this.inputПовторноКА.ShowMultipleObjectInComboBox = false;
            this.inputПовторноКА.ShowRowCount = 10;
            this.inputПовторноКА.Size = new System.Drawing.Size(20, 20);
            this.inputПовторноКА.SourceObject = this.nsgVisualMultipleObject;
            this.inputПовторноКА.TabIndex = 5;
            this.inputПовторноКА.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputПовторноКА.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.inputПовторноКА_EndEdit);
            // 
            // nsgLabel1
            // 
            this.nsgLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgLabel1.AutoSize = true;
            this.nsgLabel1.ConfigurationName = "";
            this.nsgLabel1.FullName = "";
            this.nsgLabel1.IsInitialized = false;
            this.nsgLabel1.Location = new System.Drawing.Point(827, 9);
            this.nsgLabel1.MetaDataName = "";
            this.nsgLabel1.Name = "nsgLabel1";
            this.nsgLabel1.Requsite = "";
            this.nsgLabel1.Size = new System.Drawing.Size(56, 13);
            this.nsgLabel1.TabIndex = 4;
            this.nsgLabel1.Text = "Повторно";
            // 
            // bСохранитьКА
            // 
            this.bСохранитьКА.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bСохранитьКА.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bСохранитьКА.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bСохранитьКА.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bСохранитьКА.Location = new System.Drawing.Point(927, 6);
            this.bСохранитьКА.Name = "NsgButton";
            this.bСохранитьКА.Size = new System.Drawing.Size(125, 25);
            this.bСохранитьКА.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bСохранитьКА.TabIndex = 2;
            this.bСохранитьКА.Text = "Сохранить";
            this.bСохранитьКА.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bСохранитьКА.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bСохранитьКА_AsyncClick);
            this.bСохранитьКА.AsyncClickCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bСохранитьКА_AsyncClickCompleted);
            // 
            // bЗаполнитьКА
            // 
            this.bЗаполнитьКА.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bЗаполнитьКА.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bЗаполнитьКА.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bЗаполнитьКА.Location = new System.Drawing.Point(8, 6);
            this.bЗаполнитьКА.Name = "NsgButton";
            this.bЗаполнитьКА.Size = new System.Drawing.Size(125, 25);
            this.bЗаполнитьКА.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bЗаполнитьКА.TabIndex = 1;
            this.bЗаполнитьКА.Text = "Заполнить таблицу";
            this.bЗаполнитьКА.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bЗаполнитьКА.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bЗаполнитьКА_AsyncClick);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.inputПовторноОбъ);
            this.tabPage2.Controls.Add(this.nsgIGrid2);
            this.tabPage2.Controls.Add(this.nsgLabel2);
            this.tabPage2.Controls.Add(this.bСохранитьОбъекты);
            this.tabPage2.Controls.Add(this.bЗаполнитьОбъекты);
            this.tabPage2.Enabled = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Объекты";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = false;
            // 
            // inputПовторноОбъ
            // 
            this.inputПовторноОбъ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputПовторноОбъ.BackColor = System.Drawing.SystemColors.Control;
            this.inputПовторноОбъ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputПовторноОбъ.ConfigurationName = "";
            this.inputПовторноОбъ.DisableLeaveControlEvent = false;
            this.inputПовторноОбъ.FullName = "ПовторноОбъ";
            this.inputПовторноОбъ.FullTextSearch = false;
            this.inputПовторноОбъ.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.inputПовторноОбъ.IsButton = false;
            this.inputПовторноОбъ.IsInitialized = true;
            this.inputПовторноОбъ.IsPassword = false;
            this.inputПовторноОбъ.Location = new System.Drawing.Point(886, 6);
            this.inputПовторноОбъ.Margin = new System.Windows.Forms.Padding(0);
            this.inputПовторноОбъ.Mask = "";
            this.inputПовторноОбъ.MetaDataName = "";
            this.inputПовторноОбъ.MinimumSize = new System.Drawing.Size(4, 20);
            this.inputПовторноОбъ.Name = "NsgInput";
            this.inputПовторноОбъ.ObjectImages = null;
            this.inputПовторноОбъ.ObjectIndex = null;
            this.inputПовторноОбъ.ObjectStrings = null;
            this.inputПовторноОбъ.Requsite = "ПовторноОбъ";
            this.inputПовторноОбъ.SearchFieldName = "";
            this.inputПовторноОбъ.ShowMultipleObjectInComboBox = false;
            this.inputПовторноОбъ.ShowRowCount = 10;
            this.inputПовторноОбъ.Size = new System.Drawing.Size(20, 20);
            this.inputПовторноОбъ.SourceObject = this.nsgVisualMultipleObject;
            this.inputПовторноОбъ.TabIndex = 10;
            this.inputПовторноОбъ.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputПовторноОбъ.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.inputПовторноОбъ_EndEdit);
            // 
            // nsgLabel2
            // 
            this.nsgLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgLabel2.AutoSize = true;
            this.nsgLabel2.ConfigurationName = "";
            this.nsgLabel2.FullName = "";
            this.nsgLabel2.IsInitialized = false;
            this.nsgLabel2.Location = new System.Drawing.Point(827, 9);
            this.nsgLabel2.MetaDataName = "";
            this.nsgLabel2.Name = "nsgLabel1";
            this.nsgLabel2.Requsite = "";
            this.nsgLabel2.Size = new System.Drawing.Size(56, 13);
            this.nsgLabel2.TabIndex = 8;
            this.nsgLabel2.Text = "Повторно";
            // 
            // bСохранитьОбъекты
            // 
            this.bСохранитьОбъекты.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bСохранитьОбъекты.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bСохранитьОбъекты.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bСохранитьОбъекты.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bСохранитьОбъекты.Location = new System.Drawing.Point(927, 6);
            this.bСохранитьОбъекты.Name = "NsgButton";
            this.bСохранитьОбъекты.Size = new System.Drawing.Size(125, 25);
            this.bСохранитьОбъекты.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bСохранитьОбъекты.TabIndex = 6;
            this.bСохранитьОбъекты.Text = "Сохранить";
            this.bСохранитьОбъекты.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bСохранитьОбъекты.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bСохранитьОбъекты_AsyncClick);
            this.bСохранитьОбъекты.AsyncClickCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bСохранитьОбъекты_AsyncClickCompleted);
            // 
            // bЗаполнитьОбъекты
            // 
            this.bЗаполнитьОбъекты.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bЗаполнитьОбъекты.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bЗаполнитьОбъекты.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bЗаполнитьОбъекты.Location = new System.Drawing.Point(8, 6);
            this.bЗаполнитьОбъекты.Name = "NsgButton";
            this.bЗаполнитьОбъекты.Size = new System.Drawing.Size(125, 25);
            this.bЗаполнитьОбъекты.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bЗаполнитьОбъекты.TabIndex = 5;
            this.bЗаполнитьОбъекты.Text = "Заполнить таблицу";
            this.bЗаполнитьОбъекты.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bЗаполнитьОбъекты.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bЗаполнитьОбъекты_AsyncClick);
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.inputПовторноСотр);
            this.tabPage3.Controls.Add(this.nsgIGrid3);
            this.tabPage3.Controls.Add(this.nsgLabel3);
            this.tabPage3.Controls.Add(this.bСохранитьСотрудников);
            this.tabPage3.Controls.Add(this.bЗаполнитьСотрудников);
            this.tabPage3.Enabled = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1058, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сотрудники";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = false;
            // 
            // inputПовторноСотр
            // 
            this.inputПовторноСотр.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputПовторноСотр.BackColor = System.Drawing.SystemColors.Control;
            this.inputПовторноСотр.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputПовторноСотр.ConfigurationName = "";
            this.inputПовторноСотр.DisableLeaveControlEvent = false;
            this.inputПовторноСотр.FullName = "ПовторноСотр";
            this.inputПовторноСотр.FullTextSearch = false;
            this.inputПовторноСотр.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.inputПовторноСотр.IsButton = false;
            this.inputПовторноСотр.IsInitialized = true;
            this.inputПовторноСотр.IsPassword = false;
            this.inputПовторноСотр.Location = new System.Drawing.Point(886, 6);
            this.inputПовторноСотр.Margin = new System.Windows.Forms.Padding(0);
            this.inputПовторноСотр.Mask = "";
            this.inputПовторноСотр.MetaDataName = "";
            this.inputПовторноСотр.MinimumSize = new System.Drawing.Size(4, 20);
            this.inputПовторноСотр.Name = "NsgInput";
            this.inputПовторноСотр.ObjectImages = null;
            this.inputПовторноСотр.ObjectIndex = null;
            this.inputПовторноСотр.ObjectStrings = null;
            this.inputПовторноСотр.Requsite = "ПовторноСотр";
            this.inputПовторноСотр.SearchFieldName = "";
            this.inputПовторноСотр.ShowMultipleObjectInComboBox = false;
            this.inputПовторноСотр.ShowRowCount = 10;
            this.inputПовторноСотр.Size = new System.Drawing.Size(20, 20);
            this.inputПовторноСотр.SourceObject = this.nsgVisualMultipleObject;
            this.inputПовторноСотр.TabIndex = 10;
            this.inputПовторноСотр.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputПовторноСотр.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.inputПовторноСотр_EndEdit);
            // 
            // nsgLabel3
            // 
            this.nsgLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgLabel3.AutoSize = true;
            this.nsgLabel3.ConfigurationName = "";
            this.nsgLabel3.FullName = "";
            this.nsgLabel3.IsInitialized = false;
            this.nsgLabel3.Location = new System.Drawing.Point(827, 9);
            this.nsgLabel3.MetaDataName = "";
            this.nsgLabel3.Name = "nsgLabel1";
            this.nsgLabel3.Requsite = "";
            this.nsgLabel3.Size = new System.Drawing.Size(56, 13);
            this.nsgLabel3.TabIndex = 8;
            this.nsgLabel3.Text = "Повторно";
            // 
            // bСохранитьСотрудников
            // 
            this.bСохранитьСотрудников.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bСохранитьСотрудников.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bСохранитьСотрудников.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bСохранитьСотрудников.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bСохранитьСотрудников.Location = new System.Drawing.Point(927, 6);
            this.bСохранитьСотрудников.Name = "NsgButton";
            this.bСохранитьСотрудников.Size = new System.Drawing.Size(125, 25);
            this.bСохранитьСотрудников.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bСохранитьСотрудников.TabIndex = 6;
            this.bСохранитьСотрудников.Text = "Сохранить";
            this.bСохранитьСотрудников.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bСохранитьСотрудников.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bСохранитьСотрудников_AsyncClick);
            this.bСохранитьСотрудников.AsyncClickCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bСохранитьСотрудников_AsyncClickCompleted);
            // 
            // bЗаполнитьСотрудников
            // 
            this.bЗаполнитьСотрудников.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bЗаполнитьСотрудников.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bЗаполнитьСотрудников.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bЗаполнитьСотрудников.Location = new System.Drawing.Point(8, 6);
            this.bЗаполнитьСотрудников.Name = "NsgButton";
            this.bЗаполнитьСотрудников.Size = new System.Drawing.Size(125, 25);
            this.bЗаполнитьСотрудников.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bЗаполнитьСотрудников.TabIndex = 5;
            this.bЗаполнитьСотрудников.Text = "Заполнить таблицу";
            this.bЗаполнитьСотрудников.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bЗаполнитьСотрудников.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bЗаполнитьСотрудников_AsyncClick);
            // 
            // tabPage4
            // 
            this.tabPage4.AllowDrop = true;
            this.tabPage4.Controls.Add(this.bСохранитьТарифыВОбъектах);
            this.tabPage4.Controls.Add(this.inputПовторноТар);
            this.tabPage4.Controls.Add(this.nsgIGrid4);
            this.tabPage4.Controls.Add(this.nsgLabel4);
            this.tabPage4.Controls.Add(this.bСохранитьТарифы);
            this.tabPage4.Controls.Add(this.bЗаполнитьТарифы);
            this.tabPage4.Enabled = true;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1058, 407);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Тарифы";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Visible = true;
            // 
            // inputПовторноТар
            // 
            this.inputПовторноТар.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputПовторноТар.BackColor = System.Drawing.SystemColors.Control;
            this.inputПовторноТар.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputПовторноТар.ConfigurationName = "";
            this.inputПовторноТар.DisableLeaveControlEvent = false;
            this.inputПовторноТар.FullName = "ПовторноТар";
            this.inputПовторноТар.FullTextSearch = false;
            this.inputПовторноТар.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.inputПовторноТар.IsButton = false;
            this.inputПовторноТар.IsInitialized = true;
            this.inputПовторноТар.IsPassword = false;
            this.inputПовторноТар.Location = new System.Drawing.Point(749, 6);
            this.inputПовторноТар.Margin = new System.Windows.Forms.Padding(0);
            this.inputПовторноТар.Mask = "";
            this.inputПовторноТар.MetaDataName = "";
            this.inputПовторноТар.MinimumSize = new System.Drawing.Size(4, 20);
            this.inputПовторноТар.Name = "NsgInput";
            this.inputПовторноТар.ObjectImages = null;
            this.inputПовторноТар.ObjectIndex = null;
            this.inputПовторноТар.ObjectStrings = null;
            this.inputПовторноТар.Requsite = "ПовторноТар";
            this.inputПовторноТар.SearchFieldName = "";
            this.inputПовторноТар.ShowMultipleObjectInComboBox = false;
            this.inputПовторноТар.ShowRowCount = 10;
            this.inputПовторноТар.Size = new System.Drawing.Size(20, 20);
            this.inputПовторноТар.SourceObject = this.nsgVisualMultipleObject;
            this.inputПовторноТар.TabIndex = 10;
            this.inputПовторноТар.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputПовторноТар.EndEdit += new NsgSoft.Forms.NsgInput.EndEditEventHandler(this.inputПовторноТар_EndEdit);
            // 
            // nsgLabel4
            // 
            this.nsgLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgLabel4.AutoSize = true;
            this.nsgLabel4.ConfigurationName = "";
            this.nsgLabel4.FullName = "";
            this.nsgLabel4.IsInitialized = false;
            this.nsgLabel4.Location = new System.Drawing.Point(690, 9);
            this.nsgLabel4.MetaDataName = "";
            this.nsgLabel4.Name = "nsgLabel1";
            this.nsgLabel4.Requsite = "";
            this.nsgLabel4.Size = new System.Drawing.Size(56, 13);
            this.nsgLabel4.TabIndex = 8;
            this.nsgLabel4.Text = "Повторно";
            // 
            // bСохранитьТарифы
            // 
            this.bСохранитьТарифы.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bСохранитьТарифы.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bСохранитьТарифы.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bСохранитьТарифы.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bСохранитьТарифы.Location = new System.Drawing.Point(790, 6);
            this.bСохранитьТарифы.Name = "NsgButton";
            this.bСохранитьТарифы.Size = new System.Drawing.Size(125, 25);
            this.bСохранитьТарифы.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bСохранитьТарифы.TabIndex = 6;
            this.bСохранитьТарифы.Text = "Сохранить тарифы";
            this.bСохранитьТарифы.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bСохранитьТарифы.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bСохранитьТарифы_AsyncClick);
            this.bСохранитьТарифы.AsyncClickCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bСохранитьТарифы_AsyncClickCompleted);
            // 
            // bЗаполнитьТарифы
            // 
            this.bЗаполнитьТарифы.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bЗаполнитьТарифы.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bЗаполнитьТарифы.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bЗаполнитьТарифы.Location = new System.Drawing.Point(8, 6);
            this.bЗаполнитьТарифы.Name = "NsgButton";
            this.bЗаполнитьТарифы.Size = new System.Drawing.Size(125, 25);
            this.bЗаполнитьТарифы.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bЗаполнитьТарифы.TabIndex = 5;
            this.bЗаполнитьТарифы.Text = "Заполнить таблицу";
            this.bЗаполнитьТарифы.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bЗаполнитьТарифы.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bЗаполнитьТарифы_AsyncClick);
            // 
            // ПовторноТар_
            // 
            this.ПовторноТар_.Caption = "ПовторноТар";
            this.ПовторноТар_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПовторноТар_.Name = "ПовторноТар";
            this.ПовторноТар_.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ПовторноТар_.PropertyType = typeof(bool);
            this.ПовторноТар_.SearchCondition.OwnerComponent = this.ПовторноТар_;
            this.ПовторноТар_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПовторноСотр_
            // 
            this.ПовторноСотр_.Caption = "ПовторноСотр";
            this.ПовторноСотр_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПовторноСотр_.Name = "ПовторноСотр";
            this.ПовторноСотр_.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ПовторноСотр_.PropertyType = typeof(bool);
            this.ПовторноСотр_.SearchCondition.OwnerComponent = this.ПовторноСотр_;
            this.ПовторноСотр_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПовторноОбъ_
            // 
            this.ПовторноОбъ_.Caption = "ПовторноОбъ";
            this.ПовторноОбъ_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПовторноОбъ_.Name = "ПовторноОбъ";
            this.ПовторноОбъ_.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ПовторноОбъ_.PropertyType = typeof(bool);
            this.ПовторноОбъ_.SearchCondition.OwnerComponent = this.ПовторноОбъ_;
            this.ПовторноОбъ_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПовторноКА_
            // 
            this.ПовторноКА_.Caption = "ПовторноКА";
            this.ПовторноКА_.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПовторноКА_.Name = "ПовторноКА";
            this.ПовторноКА_.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ПовторноКА_.PropertyType = typeof(bool);
            this.ПовторноКА_.SearchCondition.OwnerComponent = this.ПовторноКА_;
            this.ПовторноКА_.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // bСохранитьТарифыВОбъектах
            // 
            this.bСохранитьТарифыВОбъектах.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bСохранитьТарифыВОбъектах.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bСохранитьТарифыВОбъектах.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bСохранитьТарифыВОбъектах.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bСохранитьТарифыВОбъектах.Location = new System.Drawing.Point(927, 6);
            this.bСохранитьТарифыВОбъектах.Name = "NsgButton";
            this.bСохранитьТарифыВОбъектах.Size = new System.Drawing.Size(125, 25);
            this.bСохранитьТарифыВОбъектах.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bСохранитьТарифыВОбъектах.TabIndex = 11;
            this.bСохранитьТарифыВОбъектах.Text = "Сохранить объекты";
            this.bСохранитьТарифыВОбъектах.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bСохранитьТарифыВОбъектах.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bСохранитьТарифыВОбъектах_AsyncClick);
            this.bСохранитьТарифыВОбъектах.AsyncClickCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bСохранитьТарифыВОбъектах_AsyncClickCompleted);
            // 
            // ЗагрузкаИзJSONФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(1069, 483);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoКонтрагенты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoОбъекты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСотрудники)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноКА)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьКА)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьКА)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноОбъ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьОбъекты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьОбъекты)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноСотр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьСотрудников)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьСотрудников)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputПовторноТар)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьТарифы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнитьТарифы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bСохранитьТарифыВОбъектах)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NsgIGrid nsgIGrid1;
        private NsgIGrid nsgIGrid2;
        private NsgIGrid nsgIGrid3;
        private NsgIGrid nsgIGrid4;
        protected NsgColumnDescriptor.Boolean ПовторноКА_;
        protected NsgColumnDescriptor.Boolean Выбор_к;
        protected NsgColumnDescriptor.String Наименование_к;
        protected NsgColumnDescriptor.String Адрес_к;
        protected NsgColumnDescriptor.String ИНН_к;
        protected Контрагенты.ColumnDescriptor Найдено_к;
        protected NsgColumnDescriptor.Boolean Выбор_о;
        protected NsgColumnDescriptor.String Наименование_о;
        protected NsgColumnDescriptor.String Адрес_о;
        protected NsgColumnDescriptor.String Договор_о;
        protected Объекты.ColumnDescriptor Найдено_о;
        protected NsgColumnDescriptor.Guid Идентификатор_о;
        protected Контрагенты.ColumnDescriptor Заказчик_о;
        protected Контрагенты.ColumnDescriptor Фирма_о;
        protected NsgColumnDescriptor.Boolean Выбор_с;
        protected NsgColumnDescriptor.String Имя_с;
        protected NsgColumnDescriptor.String Отчество_с;
        protected NsgColumnDescriptor.String Фамилия_с;
        protected NsgColumnDescriptor.String ДатаУвольнения_с;
        protected NsgColumnDescriptor.String Телефон_с;
        protected NsgColumnDescriptor.String ТабельныйНомер_с;
        protected NsgColumnDescriptor.DateTime ДатаРождения_с;
        protected NsgColumnDescriptor.DateTime ДатаПриемаНаРаботу_с;
        protected ФизЛица.ColumnDescriptor Найдено_с;
        protected NsgColumnDescriptor.Boolean Выбор_т;
        protected NsgColumnDescriptor.String Наименование_т;
        protected Объекты.ColumnDescriptor Объект_т;
        protected ФизЛица.ColumnDescriptor Сотрудник_т;
        protected NsgColumnDescriptor.Decimal Стоимость_т;
        protected Тарифы.ColumnDescriptor Найдено_т;
        protected NsgColumnDescriptor.Guid Идентификатор_к;
        protected NsgColumnDescriptor.Boolean ЭтоФирма_к;
        protected NsgInput inputПовторноКА;
        protected NsgInput inputПовторноОбъ;
        protected NsgInput inputПовторноСотр;
        protected NsgInput inputПовторноТар;
        protected NsgColumnDescriptor.Guid Идентификатор_с;
        protected NsgColumnDescriptor.String Наименование_с;
        protected Договоры.ColumnDescriptor ДоговорСсылка_о;
        protected NsgColumnDescriptor.Boolean ПовторноОбъ_;
        protected NsgColumnDescriptor.Boolean ПовторноСотр_;
        protected NsgColumnDescriptor.Boolean ПовторноТар_;
        protected System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.TabPage tabPage3;
        protected System.Windows.Forms.TabPage tabPage4;
        protected NsgSoft.Design.NsgButton bСохранитьКА;
        protected NsgSoft.Design.NsgButton bЗаполнитьКА;
        protected NsgLabel nsgLabel2;
        protected NsgSoft.Design.NsgButton bСохранитьОбъекты;
        protected NsgSoft.Design.NsgButton bЗаполнитьОбъекты;
        protected NsgLabel nsgLabel3;
        protected NsgSoft.Design.NsgButton bСохранитьСотрудников;
        protected NsgSoft.Design.NsgButton bЗаполнитьСотрудников;
        protected NsgLabel nsgLabel4;
        protected NsgSoft.Design.NsgButton bСохранитьТарифы;
        protected NsgSoft.Design.NsgButton bЗаполнитьТарифы;
        protected NsgLabel nsgLabel1;
        protected NsgSoft.Design.NsgButton bСохранитьТарифыВОбъектах;
        private NsgVisualMultipleObject vmoКонтрагенты;
        private System.Windows.Forms.TabControl tabControl1;
        private NsgVisualMultipleObject vmoОбъекты;
        private NsgVisualMultipleObject vmoСотрудники;
        private NsgVisualMultipleObject vmoТарифы;
    }
}