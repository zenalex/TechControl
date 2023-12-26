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
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn15 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn21 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn22 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn23 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn24 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn25 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn26 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn27 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn28 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn29 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn30 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn31 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn32 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn33 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn34 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn35 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn36 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn37 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn38 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn39 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn40 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn41 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn42 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn43 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn44 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn45 = new NsgSoft.Forms.NsgIGridColumn();
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
            this.НомерСмены_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ГруппаСпецТехники_vmoТаблица = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаИтогов = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Сотрудник_vmoТаблицаИтогов = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Техника_vmoТаблицаИтогов = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Тариф_vmoТаблицаИтогов = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Дл1_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл2_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл3_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл4_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл5_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл6_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл7_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл8_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл9_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл10_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл11_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл12_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл13_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл14_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл15_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл16_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл17_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл18_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл19_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл20_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл21_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл22_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл23_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл24_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл25_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл26_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл27_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл28_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл29_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл30_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дл31_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Должность_vmoТаблицаИтогов = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.ГруппаСпТехн_vmoТаблицаИтогов = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.КоличествоДляСравнения_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpФормирование = new System.Windows.Forms.TabPage();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.nbСформироватьСмену = new NsgSoft.Design.NsgButton();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpИтоги = new System.Windows.Forms.TabPage();
            this.nbЗаполнитьПоГрафику = new NsgSoft.Design.NsgButton();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Объект_vmoИтоги = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Контрагент_vmoИтоги = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Сотрудник_vmoИтоги = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Техника_vmoИтоги = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.МесяцИтогов_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.nbСохрнитьИтоги = new NsgSoft.Design.NsgButton();
            this.nbЗаполнитьИтоги = new NsgSoft.Design.NsgButton();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.label5 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Дата = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.НомерСмены = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.КодГруппы_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.КодГруппы_vmoТаблицаИтогов = new NsgSoft.Forms.NsgColumnDescriptor.String();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаИтогов)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpФормирование.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbСформироватьСмену)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.tpИтоги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПоГрафику)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbСохрнитьИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
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
        "Visible",
        "Index"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.Name = "Должность";
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
        "Visible",
        "Index"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.Name = "Сотрудник";
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
        "Visible",
        "Index"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.Name = "ГруппаСпецТехники";
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
        "Visible",
        "Index"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "Техника";
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
        "Visible",
        "Index"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "Тариф";
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
        "Index",
        "Format"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Format = "HH:mm";
            nsgIGridColumn6.Name = "НачалоСмены";
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
            nsgIGridColumn7.Name = "Длительность ч.";
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
            nsgIGridColumn8.Name = "Объект";
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
            nsgIGridColumn9.Name = "НомерСмены";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Visible = false;
            nsgIGridColumn9.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
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
            this.vmoТаблица.Columns.Collection.Add(this.ГруппаСпецТехники_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.КодГруппы_vmoТаблица);
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
            this.НомерСмены_vmoТаблица.Visible = false;
            // 
            // ГруппаСпецТехники_vmoТаблица
            // 
            this.ГруппаСпецТехники_vmoТаблица.Caption = "ГруппаСпецТехники";
            this.ГруппаСпецТехники_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГруппаСпецТехники_vmoТаблица.Name = "ГруппаСпецТехники";
            this.ГруппаСпецТехники_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпецТехники_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпецТехники_vmoТаблица.SearchCondition.OwnerComponent = this.ГруппаСпецТехники_vmoТаблица;
            this.ГруппаСпецТехники_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn10.AllowFilter = true;
            nsgIGridColumn10.AllowGroupSelect = false;
            nsgIGridColumn10.AllowResize = true;
            nsgIGridColumn10.AutoResize = true;
            nsgIGridColumn10.Caption = "";
            nsgIGridColumn10.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.Name = "Должность";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn11.Name = "Сотрудник";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn12.Name = "ГруппаСпТехн";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn13.Name = "Техника";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn14.Name = "Тариф";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn15.Name = "1";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn16.Name = "2";
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
        "Visible",
        "Index"};
            nsgIGridColumn17.DateFormat = null;
            nsgIGridColumn17.Name = "3";
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
        "Visible",
        "Index"};
            nsgIGridColumn18.DateFormat = null;
            nsgIGridColumn18.Name = "4";
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
        "Visible",
        "Index"};
            nsgIGridColumn19.DateFormat = null;
            nsgIGridColumn19.Name = "5";
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
        "Visible",
        "Index"};
            nsgIGridColumn20.DateFormat = null;
            nsgIGridColumn20.Name = "6";
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
        "Visible",
        "Index"};
            nsgIGridColumn21.DateFormat = null;
            nsgIGridColumn21.Name = "7";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Width = 100;
            nsgIGridColumn22.AllowFilter = true;
            nsgIGridColumn22.AllowGroupSelect = false;
            nsgIGridColumn22.AllowResize = true;
            nsgIGridColumn22.AutoResize = true;
            nsgIGridColumn22.Caption = "";
            nsgIGridColumn22.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn22.DateFormat = null;
            nsgIGridColumn22.Name = "8";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn22.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn22.UseAsHeaderImage = false;
            nsgIGridColumn22.Width = 100;
            nsgIGridColumn23.AllowFilter = true;
            nsgIGridColumn23.AllowGroupSelect = false;
            nsgIGridColumn23.AllowResize = true;
            nsgIGridColumn23.AutoResize = true;
            nsgIGridColumn23.Caption = "";
            nsgIGridColumn23.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn23.DateFormat = null;
            nsgIGridColumn23.Name = "9";
            nsgIGridColumn23.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn23.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn23.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn23.UseAsHeaderImage = false;
            nsgIGridColumn23.Width = 100;
            nsgIGridColumn24.AllowFilter = true;
            nsgIGridColumn24.AllowGroupSelect = false;
            nsgIGridColumn24.AllowResize = true;
            nsgIGridColumn24.AutoResize = true;
            nsgIGridColumn24.Caption = "";
            nsgIGridColumn24.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn24.DateFormat = null;
            nsgIGridColumn24.Name = "10";
            nsgIGridColumn24.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn24.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn24.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn24.UseAsHeaderImage = false;
            nsgIGridColumn24.Width = 100;
            nsgIGridColumn25.AllowFilter = true;
            nsgIGridColumn25.AllowGroupSelect = false;
            nsgIGridColumn25.AllowResize = true;
            nsgIGridColumn25.AutoResize = true;
            nsgIGridColumn25.Caption = "";
            nsgIGridColumn25.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn25.DateFormat = null;
            nsgIGridColumn25.Name = "11";
            nsgIGridColumn25.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn25.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn25.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn25.UseAsHeaderImage = false;
            nsgIGridColumn25.Width = 100;
            nsgIGridColumn26.AllowFilter = true;
            nsgIGridColumn26.AllowGroupSelect = false;
            nsgIGridColumn26.AllowResize = true;
            nsgIGridColumn26.AutoResize = true;
            nsgIGridColumn26.Caption = "";
            nsgIGridColumn26.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn26.DateFormat = null;
            nsgIGridColumn26.Name = "12";
            nsgIGridColumn26.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn26.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn26.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn26.UseAsHeaderImage = false;
            nsgIGridColumn26.Width = 100;
            nsgIGridColumn27.AllowFilter = true;
            nsgIGridColumn27.AllowGroupSelect = false;
            nsgIGridColumn27.AllowResize = true;
            nsgIGridColumn27.AutoResize = true;
            nsgIGridColumn27.Caption = "";
            nsgIGridColumn27.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn27.DateFormat = null;
            nsgIGridColumn27.Name = "13";
            nsgIGridColumn27.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn27.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn27.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn27.UseAsHeaderImage = false;
            nsgIGridColumn27.Width = 100;
            nsgIGridColumn28.AllowFilter = true;
            nsgIGridColumn28.AllowGroupSelect = false;
            nsgIGridColumn28.AllowResize = true;
            nsgIGridColumn28.AutoResize = true;
            nsgIGridColumn28.Caption = "";
            nsgIGridColumn28.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn28.DateFormat = null;
            nsgIGridColumn28.Name = "14";
            nsgIGridColumn28.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn28.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn28.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn28.UseAsHeaderImage = false;
            nsgIGridColumn28.Width = 100;
            nsgIGridColumn29.AllowFilter = true;
            nsgIGridColumn29.AllowGroupSelect = false;
            nsgIGridColumn29.AllowResize = true;
            nsgIGridColumn29.AutoResize = true;
            nsgIGridColumn29.Caption = "";
            nsgIGridColumn29.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn29.DateFormat = null;
            nsgIGridColumn29.Name = "15";
            nsgIGridColumn29.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn29.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn29.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn29.UseAsHeaderImage = false;
            nsgIGridColumn29.Width = 100;
            nsgIGridColumn30.AllowFilter = true;
            nsgIGridColumn30.AllowGroupSelect = false;
            nsgIGridColumn30.AllowResize = true;
            nsgIGridColumn30.AutoResize = true;
            nsgIGridColumn30.Caption = "";
            nsgIGridColumn30.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn30.DateFormat = null;
            nsgIGridColumn30.Name = "16";
            nsgIGridColumn30.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn30.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn30.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn30.UseAsHeaderImage = false;
            nsgIGridColumn30.Width = 100;
            nsgIGridColumn31.AllowFilter = true;
            nsgIGridColumn31.AllowGroupSelect = false;
            nsgIGridColumn31.AllowResize = true;
            nsgIGridColumn31.AutoResize = true;
            nsgIGridColumn31.Caption = "";
            nsgIGridColumn31.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn31.DateFormat = null;
            nsgIGridColumn31.Name = "17";
            nsgIGridColumn31.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn31.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn31.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn31.UseAsHeaderImage = false;
            nsgIGridColumn31.Width = 100;
            nsgIGridColumn32.AllowFilter = true;
            nsgIGridColumn32.AllowGroupSelect = false;
            nsgIGridColumn32.AllowResize = true;
            nsgIGridColumn32.AutoResize = true;
            nsgIGridColumn32.Caption = "";
            nsgIGridColumn32.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn32.DateFormat = null;
            nsgIGridColumn32.Name = "18";
            nsgIGridColumn32.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn32.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn32.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn32.UseAsHeaderImage = false;
            nsgIGridColumn32.Width = 100;
            nsgIGridColumn33.AllowFilter = true;
            nsgIGridColumn33.AllowGroupSelect = false;
            nsgIGridColumn33.AllowResize = true;
            nsgIGridColumn33.AutoResize = true;
            nsgIGridColumn33.Caption = "";
            nsgIGridColumn33.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn33.DateFormat = null;
            nsgIGridColumn33.Name = "19";
            nsgIGridColumn33.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn33.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn33.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn33.UseAsHeaderImage = false;
            nsgIGridColumn33.Width = 100;
            nsgIGridColumn34.AllowFilter = true;
            nsgIGridColumn34.AllowGroupSelect = false;
            nsgIGridColumn34.AllowResize = true;
            nsgIGridColumn34.AutoResize = true;
            nsgIGridColumn34.Caption = "";
            nsgIGridColumn34.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn34.DateFormat = null;
            nsgIGridColumn34.Name = "20";
            nsgIGridColumn34.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn34.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn34.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn34.UseAsHeaderImage = false;
            nsgIGridColumn34.Width = 100;
            nsgIGridColumn35.AllowFilter = true;
            nsgIGridColumn35.AllowGroupSelect = false;
            nsgIGridColumn35.AllowResize = true;
            nsgIGridColumn35.AutoResize = true;
            nsgIGridColumn35.Caption = "";
            nsgIGridColumn35.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn35.DateFormat = null;
            nsgIGridColumn35.Name = "21";
            nsgIGridColumn35.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn35.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn35.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn35.UseAsHeaderImage = false;
            nsgIGridColumn35.Width = 100;
            nsgIGridColumn36.AllowFilter = true;
            nsgIGridColumn36.AllowGroupSelect = false;
            nsgIGridColumn36.AllowResize = true;
            nsgIGridColumn36.AutoResize = true;
            nsgIGridColumn36.Caption = "";
            nsgIGridColumn36.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn36.DateFormat = null;
            nsgIGridColumn36.Name = "22";
            nsgIGridColumn36.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn36.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn36.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn36.UseAsHeaderImage = false;
            nsgIGridColumn36.Width = 100;
            nsgIGridColumn37.AllowFilter = true;
            nsgIGridColumn37.AllowGroupSelect = false;
            nsgIGridColumn37.AllowResize = true;
            nsgIGridColumn37.AutoResize = true;
            nsgIGridColumn37.Caption = "";
            nsgIGridColumn37.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn37.DateFormat = null;
            nsgIGridColumn37.Name = "23";
            nsgIGridColumn37.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn37.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn37.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn37.UseAsHeaderImage = false;
            nsgIGridColumn37.Width = 100;
            nsgIGridColumn38.AllowFilter = true;
            nsgIGridColumn38.AllowGroupSelect = false;
            nsgIGridColumn38.AllowResize = true;
            nsgIGridColumn38.AutoResize = true;
            nsgIGridColumn38.Caption = "";
            nsgIGridColumn38.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn38.DateFormat = null;
            nsgIGridColumn38.Name = "24";
            nsgIGridColumn38.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn38.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn38.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn38.UseAsHeaderImage = false;
            nsgIGridColumn38.Width = 100;
            nsgIGridColumn39.AllowFilter = true;
            nsgIGridColumn39.AllowGroupSelect = false;
            nsgIGridColumn39.AllowResize = true;
            nsgIGridColumn39.AutoResize = true;
            nsgIGridColumn39.Caption = "";
            nsgIGridColumn39.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn39.DateFormat = null;
            nsgIGridColumn39.Name = "25";
            nsgIGridColumn39.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn39.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn39.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn39.UseAsHeaderImage = false;
            nsgIGridColumn39.Width = 100;
            nsgIGridColumn40.AllowFilter = true;
            nsgIGridColumn40.AllowGroupSelect = false;
            nsgIGridColumn40.AllowResize = true;
            nsgIGridColumn40.AutoResize = true;
            nsgIGridColumn40.Caption = "";
            nsgIGridColumn40.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn40.DateFormat = null;
            nsgIGridColumn40.Name = "26";
            nsgIGridColumn40.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn40.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn40.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn40.UseAsHeaderImage = false;
            nsgIGridColumn40.Width = 100;
            nsgIGridColumn41.AllowFilter = true;
            nsgIGridColumn41.AllowGroupSelect = false;
            nsgIGridColumn41.AllowResize = true;
            nsgIGridColumn41.AutoResize = true;
            nsgIGridColumn41.Caption = "";
            nsgIGridColumn41.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn41.DateFormat = null;
            nsgIGridColumn41.Name = "27";
            nsgIGridColumn41.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn41.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn41.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn41.UseAsHeaderImage = false;
            nsgIGridColumn41.Width = 100;
            nsgIGridColumn42.AllowFilter = true;
            nsgIGridColumn42.AllowGroupSelect = false;
            nsgIGridColumn42.AllowResize = true;
            nsgIGridColumn42.AutoResize = true;
            nsgIGridColumn42.Caption = "";
            nsgIGridColumn42.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn42.DateFormat = null;
            nsgIGridColumn42.Name = "28";
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
            nsgIGridColumn43.Name = "29";
            nsgIGridColumn43.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn43.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn43.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn43.UseAsHeaderImage = false;
            nsgIGridColumn43.Width = 100;
            nsgIGridColumn44.AllowFilter = true;
            nsgIGridColumn44.AllowGroupSelect = false;
            nsgIGridColumn44.AllowResize = true;
            nsgIGridColumn44.AutoResize = true;
            nsgIGridColumn44.Caption = "";
            nsgIGridColumn44.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn44.DateFormat = null;
            nsgIGridColumn44.Name = "30";
            nsgIGridColumn44.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn44.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn45.Name = "31";
            nsgIGridColumn45.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn45.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn45.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn45.UseAsHeaderImage = false;
            nsgIGridColumn45.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn22);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn23);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn24);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn25);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn26);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn27);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn28);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn29);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn30);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn31);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn32);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn33);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn34);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn35);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn36);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn37);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn38);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn39);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn40);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn41);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn42);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn43);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn44);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn45);
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(9, 146);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(757, 261);
            this.nsgIGrid2.SourceObject = this.vmoТаблицаИтогов;
            this.nsgIGrid2.TabIndex = 9;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid2.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid2_CellRequestEdit);
            // 
            // vmoТаблицаИтогов
            // 
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Сотрудник_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Техника_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Тариф_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл1_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл2_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл3_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл4_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл5_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл6_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл7_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл8_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл9_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл10_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл11_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл12_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл13_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл14_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл15_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл16_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл17_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл18_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл19_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл20_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл21_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл22_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл23_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл24_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл25_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл26_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл27_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл28_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл29_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл30_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Дл31_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.Должность_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.ГруппаСпТехн_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.КоличествоДляСравнения_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.Columns.Collection.Add(this.КодГруппы_vmoТаблицаИтогов);
            this.vmoТаблицаИтогов.IsActive = true;
            this.vmoТаблицаИтогов.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаИтогов.MetaDataName = "";
            this.vmoТаблицаИтогов.FullName = "";
            // 
            // Сотрудник_vmoТаблицаИтогов
            // 
            this.Сотрудник_vmoТаблицаИтогов.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoТаблицаИтогов.Name = "Сотрудник";
            this.Сотрудник_vmoТаблицаИтогов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаИтогов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблицаИтогов;
            this.Сотрудник_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoТаблицаИтогов
            // 
            this.Техника_vmoТаблицаИтогов.Caption = "Техника";
            this.Техника_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoТаблицаИтогов.Name = "Техника";
            this.Техника_vmoТаблицаИтогов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoТаблицаИтогов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Техника_vmoТаблицаИтогов;
            this.Техника_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТаблицаИтогов
            // 
            this.Тариф_vmoТаблицаИтогов.Caption = "Тариф";
            this.Тариф_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_vmoТаблицаИтогов.Name = "Тариф";
            this.Тариф_vmoТаблицаИтогов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблицаИтогов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Тариф_vmoТаблицаИтогов;
            this.Тариф_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл1_vmoТаблицаИтогов
            // 
            this.Дл1_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл1_vmoТаблицаИтогов.Caption = "1";
            this.Дл1_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл1_vmoТаблицаИтогов.Name = "1";
            this.Дл1_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл1_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл1_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл1_vmoТаблицаИтогов;
            this.Дл1_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл2_vmoТаблицаИтогов
            // 
            this.Дл2_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл2_vmoТаблицаИтогов.Caption = "2";
            this.Дл2_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл2_vmoТаблицаИтогов.Name = "2";
            this.Дл2_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл2_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл2_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл2_vmoТаблицаИтогов;
            this.Дл2_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл3_vmoТаблицаИтогов
            // 
            this.Дл3_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл3_vmoТаблицаИтогов.Caption = "3";
            this.Дл3_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл3_vmoТаблицаИтогов.Name = "3";
            this.Дл3_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл3_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл3_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл3_vmoТаблицаИтогов;
            this.Дл3_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл4_vmoТаблицаИтогов
            // 
            this.Дл4_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл4_vmoТаблицаИтогов.Caption = "4";
            this.Дл4_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл4_vmoТаблицаИтогов.Name = "4";
            this.Дл4_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл4_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл4_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл4_vmoТаблицаИтогов;
            this.Дл4_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл5_vmoТаблицаИтогов
            // 
            this.Дл5_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл5_vmoТаблицаИтогов.Caption = "5";
            this.Дл5_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл5_vmoТаблицаИтогов.Name = "5";
            this.Дл5_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл5_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл5_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл5_vmoТаблицаИтогов;
            this.Дл5_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл6_vmoТаблицаИтогов
            // 
            this.Дл6_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл6_vmoТаблицаИтогов.Caption = "6";
            this.Дл6_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл6_vmoТаблицаИтогов.Name = "6";
            this.Дл6_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл6_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл6_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл6_vmoТаблицаИтогов;
            this.Дл6_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл7_vmoТаблицаИтогов
            // 
            this.Дл7_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл7_vmoТаблицаИтогов.Caption = "7";
            this.Дл7_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл7_vmoТаблицаИтогов.Name = "7";
            this.Дл7_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл7_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл7_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл7_vmoТаблицаИтогов;
            this.Дл7_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл8_vmoТаблицаИтогов
            // 
            this.Дл8_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл8_vmoТаблицаИтогов.Caption = "8";
            this.Дл8_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл8_vmoТаблицаИтогов.Name = "8";
            this.Дл8_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл8_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл8_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл8_vmoТаблицаИтогов;
            this.Дл8_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл9_vmoТаблицаИтогов
            // 
            this.Дл9_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл9_vmoТаблицаИтогов.Caption = "9";
            this.Дл9_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл9_vmoТаблицаИтогов.Name = "9";
            this.Дл9_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл9_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл9_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл9_vmoТаблицаИтогов;
            this.Дл9_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл10_vmoТаблицаИтогов
            // 
            this.Дл10_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл10_vmoТаблицаИтогов.Caption = "10";
            this.Дл10_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл10_vmoТаблицаИтогов.Name = "10";
            this.Дл10_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл10_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл10_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл10_vmoТаблицаИтогов;
            this.Дл10_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл11_vmoТаблицаИтогов
            // 
            this.Дл11_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл11_vmoТаблицаИтогов.Caption = "11";
            this.Дл11_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл11_vmoТаблицаИтогов.Name = "11";
            this.Дл11_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл11_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл11_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл11_vmoТаблицаИтогов;
            this.Дл11_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл12_vmoТаблицаИтогов
            // 
            this.Дл12_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл12_vmoТаблицаИтогов.Caption = "12";
            this.Дл12_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл12_vmoТаблицаИтогов.Name = "12";
            this.Дл12_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл12_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл12_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл12_vmoТаблицаИтогов;
            this.Дл12_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл13_vmoТаблицаИтогов
            // 
            this.Дл13_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл13_vmoТаблицаИтогов.Caption = "13";
            this.Дл13_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл13_vmoТаблицаИтогов.Name = "13";
            this.Дл13_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл13_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл13_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл13_vmoТаблицаИтогов;
            this.Дл13_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл14_vmoТаблицаИтогов
            // 
            this.Дл14_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл14_vmoТаблицаИтогов.Caption = "14";
            this.Дл14_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл14_vmoТаблицаИтогов.Name = "14";
            this.Дл14_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл14_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл14_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл14_vmoТаблицаИтогов;
            this.Дл14_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл15_vmoТаблицаИтогов
            // 
            this.Дл15_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл15_vmoТаблицаИтогов.Caption = "15";
            this.Дл15_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл15_vmoТаблицаИтогов.Name = "15";
            this.Дл15_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл15_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл15_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл15_vmoТаблицаИтогов;
            this.Дл15_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл16_vmoТаблицаИтогов
            // 
            this.Дл16_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл16_vmoТаблицаИтогов.Caption = "16";
            this.Дл16_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл16_vmoТаблицаИтогов.Name = "16";
            this.Дл16_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл16_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл16_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл16_vmoТаблицаИтогов;
            this.Дл16_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл17_vmoТаблицаИтогов
            // 
            this.Дл17_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл17_vmoТаблицаИтогов.Caption = "17";
            this.Дл17_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл17_vmoТаблицаИтогов.Name = "17";
            this.Дл17_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл17_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл17_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл17_vmoТаблицаИтогов;
            this.Дл17_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл18_vmoТаблицаИтогов
            // 
            this.Дл18_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл18_vmoТаблицаИтогов.Caption = "18";
            this.Дл18_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл18_vmoТаблицаИтогов.Name = "18";
            this.Дл18_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл18_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл18_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл18_vmoТаблицаИтогов;
            this.Дл18_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл19_vmoТаблицаИтогов
            // 
            this.Дл19_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл19_vmoТаблицаИтогов.Caption = "19";
            this.Дл19_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл19_vmoТаблицаИтогов.Name = "19";
            this.Дл19_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл19_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл19_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл19_vmoТаблицаИтогов;
            this.Дл19_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл20_vmoТаблицаИтогов
            // 
            this.Дл20_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл20_vmoТаблицаИтогов.Caption = "20";
            this.Дл20_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл20_vmoТаблицаИтогов.Name = "20";
            this.Дл20_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл20_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл20_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл20_vmoТаблицаИтогов;
            this.Дл20_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл21_vmoТаблицаИтогов
            // 
            this.Дл21_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл21_vmoТаблицаИтогов.Caption = "21";
            this.Дл21_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл21_vmoТаблицаИтогов.Name = "21";
            this.Дл21_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл21_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл21_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл21_vmoТаблицаИтогов;
            this.Дл21_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл22_vmoТаблицаИтогов
            // 
            this.Дл22_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл22_vmoТаблицаИтогов.Caption = "22";
            this.Дл22_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл22_vmoТаблицаИтогов.Name = "22";
            this.Дл22_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл22_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл22_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл22_vmoТаблицаИтогов;
            this.Дл22_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл23_vmoТаблицаИтогов
            // 
            this.Дл23_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл23_vmoТаблицаИтогов.Caption = "23";
            this.Дл23_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл23_vmoТаблицаИтогов.Name = "23";
            this.Дл23_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл23_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл23_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл23_vmoТаблицаИтогов;
            this.Дл23_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл24_vmoТаблицаИтогов
            // 
            this.Дл24_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл24_vmoТаблицаИтогов.Caption = "24";
            this.Дл24_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл24_vmoТаблицаИтогов.Name = "24";
            this.Дл24_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл24_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл24_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл24_vmoТаблицаИтогов;
            this.Дл24_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл25_vmoТаблицаИтогов
            // 
            this.Дл25_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл25_vmoТаблицаИтогов.Caption = "25";
            this.Дл25_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл25_vmoТаблицаИтогов.Name = "25";
            this.Дл25_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл25_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл25_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл25_vmoТаблицаИтогов;
            this.Дл25_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл26_vmoТаблицаИтогов
            // 
            this.Дл26_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл26_vmoТаблицаИтогов.Caption = "26";
            this.Дл26_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл26_vmoТаблицаИтогов.Name = "26";
            this.Дл26_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл26_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл26_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл26_vmoТаблицаИтогов;
            this.Дл26_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл27_vmoТаблицаИтогов
            // 
            this.Дл27_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл27_vmoТаблицаИтогов.Caption = "27";
            this.Дл27_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл27_vmoТаблицаИтогов.Name = "27";
            this.Дл27_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл27_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл27_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл27_vmoТаблицаИтогов;
            this.Дл27_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл28_vmoТаблицаИтогов
            // 
            this.Дл28_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл28_vmoТаблицаИтогов.Caption = "28";
            this.Дл28_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл28_vmoТаблицаИтогов.Name = "28";
            this.Дл28_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл28_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл28_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл28_vmoТаблицаИтогов;
            this.Дл28_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл29_vmoТаблицаИтогов
            // 
            this.Дл29_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл29_vmoТаблицаИтогов.Caption = "29";
            this.Дл29_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл29_vmoТаблицаИтогов.Name = "29";
            this.Дл29_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл29_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл29_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл29_vmoТаблицаИтогов;
            this.Дл29_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл30_vmoТаблицаИтогов
            // 
            this.Дл30_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл30_vmoТаблицаИтогов.Caption = "30";
            this.Дл30_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл30_vmoТаблицаИтогов.Name = "30";
            this.Дл30_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл30_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл30_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл30_vmoТаблицаИтогов;
            this.Дл30_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дл31_vmoТаблицаИтогов
            // 
            this.Дл31_vmoТаблицаИтогов.CalcTotal = false;
            this.Дл31_vmoТаблицаИтогов.Caption = "31";
            this.Дл31_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дл31_vmoТаблицаИтогов.Name = "31";
            this.Дл31_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дл31_vmoТаблицаИтогов.PropertyType = typeof(decimal);
            this.Дл31_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Дл31_vmoТаблицаИтогов;
            this.Дл31_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность_vmoТаблицаИтогов
            // 
            this.Должность_vmoТаблицаИтогов.Caption = "Должность";
            this.Должность_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoТаблицаИтогов.Name = "Должность";
            this.Должность_vmoТаблицаИтогов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаИтогов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.Должность_vmoТаблицаИтогов;
            this.Должность_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГруппаСпТехн_vmoТаблицаИтогов
            // 
            this.ГруппаСпТехн_vmoТаблицаИтогов.Caption = "ГруппаСпТехн";
            this.ГруппаСпТехн_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГруппаСпТехн_vmoТаблицаИтогов.Name = "ГруппаСпТехн";
            this.ГруппаСпТехн_vmoТаблицаИтогов.NSGType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпТехн_vmoТаблицаИтогов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпТехн_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.ГруппаСпТехн_vmoТаблицаИтогов;
            this.ГруппаСпТехн_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоДляСравнения_vmoТаблицаИтогов
            // 
            this.КоличествоДляСравнения_vmoТаблицаИтогов.CalcTotal = false;
            this.КоличествоДляСравнения_vmoТаблицаИтогов.Caption = "КоличествоДляСравнения";
            this.КоличествоДляСравнения_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КоличествоДляСравнения_vmoТаблицаИтогов.Name = "КоличествоДляСравнения";
            this.КоличествоДляСравнения_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоДляСравнения_vmoТаблицаИтогов.PropertyType = typeof(long);
            this.КоличествоДляСравнения_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.КоличествоДляСравнения_vmoТаблицаИтогов;
            this.КоличествоДляСравнения_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.КоличествоДляСравнения_vmoТаблицаИтогов.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpФормирование);
            this.tabControl1.Controls.Add(this.tpИтоги);
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
            // tpИтоги
            // 
            this.tpИтоги.AllowDrop = true;
            this.tpИтоги.Controls.Add(this.nbЗаполнитьПоГрафику);
            this.tpИтоги.Controls.Add(this.nsgInput8);
            this.tpИтоги.Controls.Add(this.label8);
            this.tpИтоги.Controls.Add(this.nbСохрнитьИтоги);
            this.tpИтоги.Controls.Add(this.nbЗаполнитьИтоги);
            this.tpИтоги.Controls.Add(this.nsgIGrid2);
            this.tpИтоги.Controls.Add(this.nsgInput7);
            this.tpИтоги.Controls.Add(this.label7);
            this.tpИтоги.Controls.Add(this.nsgInput6);
            this.tpИтоги.Controls.Add(this.label6);
            this.tpИтоги.Controls.Add(this.nsgInput5);
            this.tpИтоги.Controls.Add(this.label5);
            this.tpИтоги.Controls.Add(this.nsgInput4);
            this.tpИтоги.Controls.Add(this.label4);
            this.tpИтоги.Enabled = true;
            this.tpИтоги.Location = new System.Drawing.Point(4, 22);
            this.tpИтоги.Name = "tabPage2";
            this.tpИтоги.Padding = new System.Windows.Forms.Padding(3);
            this.tpИтоги.Size = new System.Drawing.Size(774, 413);
            this.tpИтоги.TabIndex = 1;
            this.tpИтоги.Text = "Итоги";
            this.tpИтоги.UseVisualStyleBackColor = true;
            this.tpИтоги.Visible = false;
            // 
            // nbЗаполнитьПоГрафику
            // 
            this.nbЗаполнитьПоГрафику.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнитьПоГрафику.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнитьПоГрафику.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнитьПоГрафику.Location = new System.Drawing.Point(405, 36);
            this.nbЗаполнитьПоГрафику.Name = "NsgButton";
            this.nbЗаполнитьПоГрафику.Size = new System.Drawing.Size(178, 25);
            this.nbЗаполнитьПоГрафику.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнитьПоГрафику.TabIndex = 14;
            this.nbЗаполнитьПоГрафику.Text = "Заполнить по графику";
            this.nbЗаполнитьПоГрафику.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнитьПоГрафику.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнитьПоГрафику_AsyncClick);
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.Format = NsgSoft.Common.NsgDateTimeFormat.Month;
            this.nsgInput8.FullName = "МесяцИтогов";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(86, 6);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "МесяцИтогов";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(132, 20);
            this.nsgInput8.SourceObject = this.vmoИтоги;
            this.nsgInput8.TabIndex = 13;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.Объект_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Контрагент_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Сотрудник_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Техника_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.МесяцИтогов_vmoИтоги);
            this.vmoИтоги.IsActive = true;
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // Объект_vmoИтоги
            // 
            this.Объект_vmoИтоги.Caption = "Объект";
            this.Объект_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoИтоги.Name = "Объект";
            this.Объект_vmoИтоги.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoИтоги.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoИтоги.SearchCondition.OwnerComponent = this.Объект_vmoИтоги;
            this.Объект_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Контрагент_vmoИтоги
            // 
            this.Контрагент_vmoИтоги.Caption = "Контрагент";
            this.Контрагент_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Контрагент_vmoИтоги.Name = "Контрагент";
            this.Контрагент_vmoИтоги.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Контрагент_vmoИтоги.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Контрагент_vmoИтоги.SearchCondition.OwnerComponent = this.Контрагент_vmoИтоги;
            this.Контрагент_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoИтоги
            // 
            this.Сотрудник_vmoИтоги.Caption = "Сотрудник";
            this.Сотрудник_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoИтоги.Name = "Сотрудник";
            this.Сотрудник_vmoИтоги.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoИтоги.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoИтоги.SearchCondition.OwnerComponent = this.Сотрудник_vmoИтоги;
            this.Сотрудник_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoИтоги
            // 
            this.Техника_vmoИтоги.Caption = "Техника";
            this.Техника_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoИтоги.Name = "Техника";
            this.Техника_vmoИтоги.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoИтоги.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoИтоги.SearchCondition.OwnerComponent = this.Техника_vmoИтоги;
            this.Техника_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // МесяцИтогов_vmoИтоги
            // 
            this.МесяцИтогов_vmoИтоги.Caption = "МесяцИтогов";
            this.МесяцИтогов_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.МесяцИтогов_vmoИтоги.Name = "МесяцИтогов";
            this.МесяцИтогов_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.МесяцИтогов_vmoИтоги.PropertyType = typeof(System.DateTime);
            this.МесяцИтогов_vmoИтоги.SearchCondition.OwnerComponent = this.МесяцИтогов_vmoИтоги;
            this.МесяцИтогов_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label4";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Месяц итогов";
            // 
            // nbСохрнитьИтоги
            // 
            this.nbСохрнитьИтоги.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbСохрнитьИтоги.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbСохрнитьИтоги.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbСохрнитьИтоги.Location = new System.Drawing.Point(405, 118);
            this.nbСохрнитьИтоги.Name = "NsgButton";
            this.nbСохрнитьИтоги.Size = new System.Drawing.Size(178, 25);
            this.nbСохрнитьИтоги.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbСохрнитьИтоги.TabIndex = 11;
            this.nbСохрнитьИтоги.Text = "Сохранить итоговый документ";
            this.nbСохрнитьИтоги.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbСохрнитьИтоги.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbСохрнитьИтоги_AsyncClick);
            // 
            // nbЗаполнитьИтоги
            // 
            this.nbЗаполнитьИтоги.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнитьИтоги.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнитьИтоги.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнитьИтоги.Location = new System.Drawing.Point(405, 6);
            this.nbЗаполнитьИтоги.Name = "NsgButton";
            this.nbЗаполнитьИтоги.Size = new System.Drawing.Size(178, 25);
            this.nbЗаполнитьИтоги.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнитьИтоги.TabIndex = 10;
            this.nbЗаполнитьИтоги.Text = "Заполнить данными смен";
            this.nbЗаполнитьИтоги.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнитьИтоги.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнитьИтоги_AsyncClick);
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Техника";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(74, 123);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "Техника";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(320, 20);
            this.nsgInput7.SourceObject = this.vmoИтоги;
            this.nsgInput7.TabIndex = 8;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label4";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Техника";
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Сотрудник";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(74, 94);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Сотрудник";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(320, 20);
            this.nsgInput6.SourceObject = this.vmoИтоги;
            this.nsgInput6.TabIndex = 6;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label4";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сотрудник";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Объект";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(74, 65);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Объект";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(320, 20);
            this.nsgInput5.SourceObject = this.vmoИтоги;
            this.nsgInput5.TabIndex = 4;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label4";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Объект";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Контрагент";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(74, 36);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Контрагент";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(320, 20);
            this.nsgInput4.SourceObject = this.vmoИтоги;
            this.nsgInput4.TabIndex = 2;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Контрагент";
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
            // КодГруппы_vmoТаблица
            // 
            this.КодГруппы_vmoТаблица.Caption = "КодГруппы";
            this.КодГруппы_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КодГруппы_vmoТаблица.Name = "КодГруппы";
            this.КодГруппы_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КодГруппы_vmoТаблица.PropertyType = typeof(string);
            this.КодГруппы_vmoТаблица.SearchCondition.OwnerComponent = this.КодГруппы_vmoТаблица;
            this.КодГруппы_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.КодГруппы_vmoТаблица.Visible = false;
            // 
            // КодГруппы_vmoТаблицаИтогов
            // 
            this.КодГруппы_vmoТаблицаИтогов.Caption = "КодГруппы";
            this.КодГруппы_vmoТаблицаИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КодГруппы_vmoТаблицаИтогов.Name = "КодГруппы";
            this.КодГруппы_vmoТаблицаИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КодГруппы_vmoТаблицаИтогов.PropertyType = typeof(string);
            this.КодГруппы_vmoТаблицаИтогов.SearchCondition.OwnerComponent = this.КодГруппы_vmoТаблицаИтогов;
            this.КодГруппы_vmoТаблицаИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.КодГруппы_vmoТаблицаИтогов.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаИтогов)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpФормирование.ResumeLayout(false);
            this.tpФормирование.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbСформироватьСмену)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.tpИтоги.ResumeLayout(false);
            this.tpИтоги.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьПоГрафику)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbСохрнитьИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
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
        protected System.Windows.Forms.TabPage tpИтоги;
        protected System.Windows.Forms.Label label1;
        protected NsgColumnDescriptor.Int64 НомерСмены;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        private NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.Int64 НомерСмены_vmoТаблица;
        protected Мониторинг.ГруппыСпецТехники.ColumnDescriptor ГруппаСпецТехники_vmoТаблица;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoИтоги;
        protected Мониторинг.Контрагенты.ColumnDescriptor Контрагент_vmoИтоги;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoИтоги;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoТаблицаИтогов;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoИтоги;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoТаблицаИтогов;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл1_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл2_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл3_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл4_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл5_vmoТаблицаИтогов;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.Label label6;
        protected NsgInput nsgInput5;
        protected System.Windows.Forms.Label label5;
        protected NsgInput nsgInput4;
        protected NsgSoft.Design.NsgButton nbЗаполнитьИтоги;
        protected NsgColumnDescriptor.Decimal Дл6_vmoТаблицаИтогов;
        protected NsgSoft.Design.NsgButton nbСохрнитьИтоги;
        private NsgIGrid nsgIGrid2;
        protected System.Windows.Forms.TabPage tpФормирование;
        protected System.Windows.Forms.Label label4;
        protected NsgColumnDescriptor.Decimal Дл7_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл8_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл9_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл10_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл11_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл12_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл13_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл14_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл15_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл16_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл17_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл18_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл19_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл20_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл21_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл22_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл23_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл24_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл25_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл26_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл27_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл28_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл29_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл30_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Decimal Дл31_vmoТаблицаИтогов;
        protected NsgInput nsgInput8;
        protected NsgColumnDescriptor.DateTime МесяцИтогов_vmoИтоги;
        protected System.Windows.Forms.Label label8;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoТаблицаИтогов;
        protected NsgSoft.Design.NsgButton nbЗаполнитьПоГрафику;
        protected Мониторинг.ГруппыСпецТехники.ColumnDescriptor ГруппаСпТехн_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.Int64 КоличествоДляСравнения_vmoТаблицаИтогов;
        protected NsgColumnDescriptor.String КодГруппы_vmoТаблица;
        private NsgVisualMultipleObject vmoТаблица;
        private System.Windows.Forms.TabControl tabControl1;
        private NsgVisualMultipleObject vmoИтоги;
        private NsgVisualMultipleObject vmoТаблицаИтогов;
        protected NsgColumnDescriptor.String КодГруппы_vmoТаблицаИтогов;
    }
}