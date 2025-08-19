using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Отчеты

{
    
    public partial class ОтчетПоОтработанномуВремениФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоОтработанномуВремениФорма));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.МесяцОтчета_nsgVisualMultipleObject = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoFilter = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Д1_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д2_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д3 = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д4_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д5_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д6_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д7_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д8_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д9_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д10_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д11_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д12_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д13_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д14_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д15_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д16_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д17_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д18_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д19_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д20_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д21_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д22_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д23_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д24_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д25_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д26_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д27_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д28_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д29_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д30_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Д31_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Техника_vmoТаблица = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект_vmoТаблица = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Тариф_vmoТаблица = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Сотрудник_vmoТаблица = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Тариф_vmoFilter = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Сотрудник_vmoFilter = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Техника_vmoFilter = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект_vmoFilter = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbТехника = new System.Windows.Forms.RadioButton();
            this.rdbСотрудники = new System.Windows.Forms.RadioButton();
            this.cbОбъект = new System.Windows.Forms.CheckBox();
            this.cbСотрудник = new System.Windows.Forms.CheckBox();
            this.cbТехника = new System.Windows.Forms.CheckBox();
            this.cbТариф = new System.Windows.Forms.CheckBox();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.cbДолжность = new System.Windows.Forms.CheckBox();
            this.Должность_vmoFilter = new NsgSoft.Forms.NsgColumnDescriptor.String();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoFilter)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 450);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(749, 30);
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
            this.printButton.Location = new System.Drawing.Point(729, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МесяцОтчета_nsgVisualMultipleObject);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.nbЗаполнить);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(749, 450);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.nsgObjectFilter1);
            this.splitContainer2.Panel1.Controls.Add(this.nsgInput1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AllowDrop = true;
            this.splitContainer2.Panel2.Controls.Add(this.nsgIGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(541, 450);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 0;
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
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(4, 3);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(534, 257);
            this.nsgIGrid1.SourceObject = null;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbДолжность);
            this.groupBox1.Controls.Add(this.cbТариф);
            this.groupBox1.Controls.Add(this.cbТехника);
            this.groupBox1.Controls.Add(this.cbСотрудник);
            this.groupBox1.Controls.Add(this.cbОбъект);
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группировки";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.Format = NsgSoft.Common.NsgDateTimeFormat.Month;
            this.nsgInput1.FullName = "МесяцОтчета";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = false;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(19, 9);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "МесяцОтчета";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(132, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 0;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // МесяцОтчета_nsgVisualMultipleObject
            // 
            this.МесяцОтчета_nsgVisualMultipleObject.Caption = "МесяцОтчета";
            this.МесяцОтчета_nsgVisualMultipleObject.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.МесяцОтчета_nsgVisualMultipleObject.Name = "МесяцОтчета";
            this.МесяцОтчета_nsgVisualMultipleObject.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.МесяцОтчета_nsgVisualMultipleObject.PropertyType = typeof(System.DateTime);
            this.МесяцОтчета_nsgVisualMultipleObject.SearchCondition.OwnerComponent = this.МесяцОтчета_nsgVisualMultipleObject;
            this.МесяцОтчета_nsgVisualMultipleObject.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.nsgObjectFilter1.Location = new System.Drawing.Point(6, 32);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.ShowMenu = false;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(532, 145);
            this.nsgObjectFilter1.SourceObject = null;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Месяц отчета";
            // 
            // vmoТаблица
            // 
            this.vmoТаблица.Columns.Collection.Add(this.Сотрудник_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Тариф_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Объект_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Техника_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д1_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д2_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д3);
            this.vmoТаблица.Columns.Collection.Add(this.Д4_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д5_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д6_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д7_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д8_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д9_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д10_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д11_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д12_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д13_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д14_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д15_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д16_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д17_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д18_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д19_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д20_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д21_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д22_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д23_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д24_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д25_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д26_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д27_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д28_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д29_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д30_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Д31_vmoТаблица);
            this.vmoТаблица.IsActive = true;
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблица.MetaDataName = "";
            this.vmoТаблица.FullName = "";
            // 
            // vmoFilter
            // 
            this.vmoFilter.Columns.Collection.Add(this.Объект_vmoFilter);
            this.vmoFilter.Columns.Collection.Add(this.Техника_vmoFilter);
            this.vmoFilter.Columns.Collection.Add(this.Сотрудник_vmoFilter);
            this.vmoFilter.Columns.Collection.Add(this.Тариф_vmoFilter);
            this.vmoFilter.Columns.Collection.Add(this.Должность_vmoFilter);
            this.vmoFilter.IsActive = true;
            this.vmoFilter.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoFilter.MetaDataName = "";
            this.vmoFilter.FullName = "";
            // 
            // Д1_vmoТаблица
            // 
            this.Д1_vmoТаблица.Caption = "1";
            this.Д1_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д1_vmoТаблица.Name = "1";
            this.Д1_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д1_vmoТаблица.PropertyType = typeof(string);
            this.Д1_vmoТаблица.SearchCondition.OwnerComponent = this.Д1_vmoТаблица;
            this.Д1_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д2_vmoТаблица
            // 
            this.Д2_vmoТаблица.Caption = "2";
            this.Д2_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д2_vmoТаблица.Name = "2";
            this.Д2_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д2_vmoТаблица.PropertyType = typeof(string);
            this.Д2_vmoТаблица.SearchCondition.OwnerComponent = this.Д2_vmoТаблица;
            this.Д2_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д3
            // 
            this.Д3.Caption = "3";
            this.Д3.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д3.Name = "3";
            this.Д3.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д3.PropertyType = typeof(string);
            this.Д3.SearchCondition.OwnerComponent = this.Д3;
            this.Д3.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д4_vmoТаблица
            // 
            this.Д4_vmoТаблица.Caption = "4";
            this.Д4_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д4_vmoТаблица.Name = "4";
            this.Д4_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д4_vmoТаблица.PropertyType = typeof(string);
            this.Д4_vmoТаблица.SearchCondition.OwnerComponent = this.Д4_vmoТаблица;
            this.Д4_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д5_vmoТаблица
            // 
            this.Д5_vmoТаблица.Caption = "5";
            this.Д5_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д5_vmoТаблица.Name = "5";
            this.Д5_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д5_vmoТаблица.PropertyType = typeof(string);
            this.Д5_vmoТаблица.SearchCondition.OwnerComponent = this.Д5_vmoТаблица;
            this.Д5_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д6_vmoТаблица
            // 
            this.Д6_vmoТаблица.Caption = "6";
            this.Д6_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д6_vmoТаблица.Name = "6";
            this.Д6_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д6_vmoТаблица.PropertyType = typeof(string);
            this.Д6_vmoТаблица.SearchCondition.OwnerComponent = this.Д6_vmoТаблица;
            this.Д6_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д7_vmoТаблица
            // 
            this.Д7_vmoТаблица.Caption = "7";
            this.Д7_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д7_vmoТаблица.Name = "7";
            this.Д7_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д7_vmoТаблица.PropertyType = typeof(string);
            this.Д7_vmoТаблица.SearchCondition.OwnerComponent = this.Д7_vmoТаблица;
            this.Д7_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д8_vmoТаблица
            // 
            this.Д8_vmoТаблица.Caption = "8";
            this.Д8_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д8_vmoТаблица.Name = "8";
            this.Д8_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д8_vmoТаблица.PropertyType = typeof(string);
            this.Д8_vmoТаблица.SearchCondition.OwnerComponent = this.Д8_vmoТаблица;
            this.Д8_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д9_vmoТаблица
            // 
            this.Д9_vmoТаблица.Caption = "9";
            this.Д9_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д9_vmoТаблица.Name = "9";
            this.Д9_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д9_vmoТаблица.PropertyType = typeof(string);
            this.Д9_vmoТаблица.SearchCondition.OwnerComponent = this.Д9_vmoТаблица;
            this.Д9_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д10_vmoТаблица
            // 
            this.Д10_vmoТаблица.Caption = "10";
            this.Д10_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д10_vmoТаблица.Name = "10";
            this.Д10_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д10_vmoТаблица.PropertyType = typeof(string);
            this.Д10_vmoТаблица.SearchCondition.OwnerComponent = this.Д10_vmoТаблица;
            this.Д10_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д11_vmoТаблица
            // 
            this.Д11_vmoТаблица.Caption = "11";
            this.Д11_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д11_vmoТаблица.Name = "11";
            this.Д11_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д11_vmoТаблица.PropertyType = typeof(string);
            this.Д11_vmoТаблица.SearchCondition.OwnerComponent = this.Д11_vmoТаблица;
            this.Д11_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д12_vmoТаблица
            // 
            this.Д12_vmoТаблица.Caption = "12";
            this.Д12_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д12_vmoТаблица.Name = "12";
            this.Д12_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д12_vmoТаблица.PropertyType = typeof(string);
            this.Д12_vmoТаблица.SearchCondition.OwnerComponent = this.Д12_vmoТаблица;
            this.Д12_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д13_vmoТаблица
            // 
            this.Д13_vmoТаблица.Caption = "13";
            this.Д13_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д13_vmoТаблица.Name = "13";
            this.Д13_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д13_vmoТаблица.PropertyType = typeof(string);
            this.Д13_vmoТаблица.SearchCondition.OwnerComponent = this.Д13_vmoТаблица;
            this.Д13_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д14_vmoТаблица
            // 
            this.Д14_vmoТаблица.Caption = "14";
            this.Д14_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д14_vmoТаблица.Name = "14";
            this.Д14_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д14_vmoТаблица.PropertyType = typeof(string);
            this.Д14_vmoТаблица.SearchCondition.OwnerComponent = this.Д14_vmoТаблица;
            this.Д14_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д15_vmoТаблица
            // 
            this.Д15_vmoТаблица.Caption = "15";
            this.Д15_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д15_vmoТаблица.Name = "15";
            this.Д15_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д15_vmoТаблица.PropertyType = typeof(string);
            this.Д15_vmoТаблица.SearchCondition.OwnerComponent = this.Д15_vmoТаблица;
            this.Д15_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д16_vmoТаблица
            // 
            this.Д16_vmoТаблица.Caption = "16";
            this.Д16_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д16_vmoТаблица.Name = "16";
            this.Д16_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д16_vmoТаблица.PropertyType = typeof(string);
            this.Д16_vmoТаблица.SearchCondition.OwnerComponent = this.Д16_vmoТаблица;
            this.Д16_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д17_vmoТаблица
            // 
            this.Д17_vmoТаблица.Caption = "17";
            this.Д17_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д17_vmoТаблица.Name = "17";
            this.Д17_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д17_vmoТаблица.PropertyType = typeof(string);
            this.Д17_vmoТаблица.SearchCondition.OwnerComponent = this.Д17_vmoТаблица;
            this.Д17_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д18_vmoТаблица
            // 
            this.Д18_vmoТаблица.Caption = "18";
            this.Д18_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д18_vmoТаблица.Name = "18";
            this.Д18_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д18_vmoТаблица.PropertyType = typeof(string);
            this.Д18_vmoТаблица.SearchCondition.OwnerComponent = this.Д18_vmoТаблица;
            this.Д18_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д19_vmoТаблица
            // 
            this.Д19_vmoТаблица.Caption = "19";
            this.Д19_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д19_vmoТаблица.Name = "19";
            this.Д19_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д19_vmoТаблица.PropertyType = typeof(string);
            this.Д19_vmoТаблица.SearchCondition.OwnerComponent = this.Д19_vmoТаблица;
            this.Д19_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д20_vmoТаблица
            // 
            this.Д20_vmoТаблица.Caption = "20";
            this.Д20_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д20_vmoТаблица.Name = "20";
            this.Д20_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д20_vmoТаблица.PropertyType = typeof(string);
            this.Д20_vmoТаблица.SearchCondition.OwnerComponent = this.Д20_vmoТаблица;
            this.Д20_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д21_vmoТаблица
            // 
            this.Д21_vmoТаблица.Caption = "21";
            this.Д21_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д21_vmoТаблица.Name = "21";
            this.Д21_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д21_vmoТаблица.PropertyType = typeof(string);
            this.Д21_vmoТаблица.SearchCondition.OwnerComponent = this.Д21_vmoТаблица;
            this.Д21_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д22_vmoТаблица
            // 
            this.Д22_vmoТаблица.Caption = "22";
            this.Д22_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д22_vmoТаблица.Name = "22";
            this.Д22_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д22_vmoТаблица.PropertyType = typeof(string);
            this.Д22_vmoТаблица.SearchCondition.OwnerComponent = this.Д22_vmoТаблица;
            this.Д22_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д23_vmoТаблица
            // 
            this.Д23_vmoТаблица.Caption = "23";
            this.Д23_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д23_vmoТаблица.Name = "23";
            this.Д23_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д23_vmoТаблица.PropertyType = typeof(string);
            this.Д23_vmoТаблица.SearchCondition.OwnerComponent = this.Д23_vmoТаблица;
            this.Д23_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д24_vmoТаблица
            // 
            this.Д24_vmoТаблица.Caption = "24";
            this.Д24_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д24_vmoТаблица.Name = "24";
            this.Д24_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д24_vmoТаблица.PropertyType = typeof(string);
            this.Д24_vmoТаблица.SearchCondition.OwnerComponent = this.Д24_vmoТаблица;
            this.Д24_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д25_vmoТаблица
            // 
            this.Д25_vmoТаблица.Caption = "25";
            this.Д25_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д25_vmoТаблица.Name = "25";
            this.Д25_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д25_vmoТаблица.PropertyType = typeof(string);
            this.Д25_vmoТаблица.SearchCondition.OwnerComponent = this.Д25_vmoТаблица;
            this.Д25_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д26_vmoТаблица
            // 
            this.Д26_vmoТаблица.Caption = "26";
            this.Д26_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д26_vmoТаблица.Name = "26";
            this.Д26_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д26_vmoТаблица.PropertyType = typeof(string);
            this.Д26_vmoТаблица.SearchCondition.OwnerComponent = this.Д26_vmoТаблица;
            this.Д26_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д27_vmoТаблица
            // 
            this.Д27_vmoТаблица.Caption = "27";
            this.Д27_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д27_vmoТаблица.Name = "27";
            this.Д27_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д27_vmoТаблица.PropertyType = typeof(string);
            this.Д27_vmoТаблица.SearchCondition.OwnerComponent = this.Д27_vmoТаблица;
            this.Д27_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д28_vmoТаблица
            // 
            this.Д28_vmoТаблица.Caption = "28";
            this.Д28_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д28_vmoТаблица.Name = "28";
            this.Д28_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д28_vmoТаблица.PropertyType = typeof(string);
            this.Д28_vmoТаблица.SearchCondition.OwnerComponent = this.Д28_vmoТаблица;
            this.Д28_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д29_vmoТаблица
            // 
            this.Д29_vmoТаблица.Caption = "29";
            this.Д29_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д29_vmoТаблица.Name = "29";
            this.Д29_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д29_vmoТаблица.PropertyType = typeof(string);
            this.Д29_vmoТаблица.SearchCondition.OwnerComponent = this.Д29_vmoТаблица;
            this.Д29_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д30_vmoТаблица
            // 
            this.Д30_vmoТаблица.Caption = "30";
            this.Д30_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д30_vmoТаблица.Name = "30";
            this.Д30_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д30_vmoТаблица.PropertyType = typeof(string);
            this.Д30_vmoТаблица.SearchCondition.OwnerComponent = this.Д30_vmoТаблица;
            this.Д30_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д31_vmoТаблица
            // 
            this.Д31_vmoТаблица.Caption = "31";
            this.Д31_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д31_vmoТаблица.Name = "31";
            this.Д31_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Д31_vmoТаблица.PropertyType = typeof(string);
            this.Д31_vmoТаблица.SearchCondition.OwnerComponent = this.Д31_vmoТаблица;
            this.Д31_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Сотрудник_vmoТаблица
            // 
            this.Сотрудник_vmoТаблица.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoТаблица.Name = "Сотрудник";
            this.Сотрудник_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_vmoТаблица.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблица;
            this.Сотрудник_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoFilter
            // 
            this.Тариф_vmoFilter.Caption = "Тариф";
            this.Тариф_vmoFilter.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_vmoFilter.Name = "Тариф";
            this.Тариф_vmoFilter.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoFilter.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoFilter.SearchCondition.OwnerComponent = this.Тариф_vmoFilter;
            this.Тариф_vmoFilter.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoFilter
            // 
            this.Сотрудник_vmoFilter.Caption = "Сотрудник";
            this.Сотрудник_vmoFilter.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoFilter.Name = "Сотрудник";
            this.Сотрудник_vmoFilter.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_vmoFilter.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник_vmoFilter.SearchCondition.OwnerComponent = this.Сотрудник_vmoFilter;
            this.Сотрудник_vmoFilter.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoFilter
            // 
            this.Техника_vmoFilter.Caption = "Техника";
            this.Техника_vmoFilter.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoFilter.Name = "Техника";
            this.Техника_vmoFilter.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoFilter.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoFilter.SearchCondition.OwnerComponent = this.Техника_vmoFilter;
            this.Техника_vmoFilter.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoFilter
            // 
            this.Объект_vmoFilter.Caption = "Объект";
            this.Объект_vmoFilter.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoFilter.Name = "Объект";
            this.Объект_vmoFilter.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoFilter.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoFilter.SearchCondition.OwnerComponent = this.Объект_vmoFilter;
            this.Объект_vmoFilter.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // groupBox2
            // 
            this.groupBox2.AllowDrop = true;
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdbСотрудники);
            this.groupBox2.Controls.Add(this.rdbТехника);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вид отчета";
            // 
            // rdbТехника
            // 
            this.rdbТехника.AutoSize = true;
            this.rdbТехника.Location = new System.Drawing.Point(6, 19);
            this.rdbТехника.Name = "rdbТехника";
            this.rdbТехника.Size = new System.Drawing.Size(80, 17);
            this.rdbТехника.TabIndex = 0;
            this.rdbТехника.TabStop = true;
            this.rdbТехника.Text = "по технике";
            this.rdbТехника.UseVisualStyleBackColor = true;
            // 
            // rdbСотрудники
            // 
            this.rdbСотрудники.AutoSize = true;
            this.rdbСотрудники.Location = new System.Drawing.Point(6, 42);
            this.rdbСотрудники.Name = "rdbСотрудники";
            this.rdbСотрудники.Size = new System.Drawing.Size(106, 17);
            this.rdbСотрудники.TabIndex = 1;
            this.rdbСотрудники.TabStop = true;
            this.rdbСотрудники.Text = "по сотрудникам";
            this.rdbСотрудники.UseVisualStyleBackColor = true;
            // 
            // cbОбъект
            // 
            this.cbОбъект.AutoSize = true;
            this.cbОбъект.Location = new System.Drawing.Point(7, 19);
            this.cbОбъект.Name = "cbОбъект";
            this.cbОбъект.Size = new System.Drawing.Size(64, 17);
            this.cbОбъект.TabIndex = 0;
            this.cbОбъект.Text = "Объект";
            this.cbОбъект.UseVisualStyleBackColor = true;
            // 
            // cbСотрудник
            // 
            this.cbСотрудник.AutoSize = true;
            this.cbСотрудник.Location = new System.Drawing.Point(7, 42);
            this.cbСотрудник.Name = "cbОбъект";
            this.cbСотрудник.Size = new System.Drawing.Size(79, 17);
            this.cbСотрудник.TabIndex = 1;
            this.cbСотрудник.Text = "Сотрудник";
            this.cbСотрудник.UseVisualStyleBackColor = true;
            // 
            // cbТехника
            // 
            this.cbТехника.AutoSize = true;
            this.cbТехника.Location = new System.Drawing.Point(7, 65);
            this.cbТехника.Name = "cbОбъект";
            this.cbТехника.Size = new System.Drawing.Size(68, 17);
            this.cbТехника.TabIndex = 2;
            this.cbТехника.Text = "Техника";
            this.cbТехника.UseVisualStyleBackColor = true;
            // 
            // cbТариф
            // 
            this.cbТариф.AutoSize = true;
            this.cbТариф.Location = new System.Drawing.Point(7, 88);
            this.cbТариф.Name = "cbОбъект";
            this.cbТариф.Size = new System.Drawing.Size(59, 17);
            this.cbТариф.TabIndex = 3;
            this.cbТариф.Text = "Тариф";
            this.cbТариф.UseVisualStyleBackColor = true;
            // 
            // nbЗаполнить
            // 
            this.nbЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнить.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнить.Location = new System.Drawing.Point(10, 217);
            this.nbЗаполнить.Name = "NsgButton";
            this.nbЗаполнить.Size = new System.Drawing.Size(182, 25);
            this.nbЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнить.TabIndex = 2;
            this.nbЗаполнить.Text = "Заполнить";
            this.nbЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнить_AsyncClick);
            // 
            // cbДолжность
            // 
            this.cbДолжность.AutoSize = true;
            this.cbДолжность.Location = new System.Drawing.Point(7, 108);
            this.cbДолжность.Name = "cbОбъект";
            this.cbДолжность.Size = new System.Drawing.Size(84, 17);
            this.cbДолжность.TabIndex = 4;
            this.cbДолжность.Text = "Должность";
            this.cbДолжность.UseVisualStyleBackColor = true;
            // 
            // Должность_vmoFilter
            // 
            this.Должность_vmoFilter.Caption = "Должность";
            this.Должность_vmoFilter.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoFilter.Name = "Должность";
            this.Должность_vmoFilter.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Должность_vmoFilter.PropertyType = typeof(string);
            this.Должность_vmoFilter.SearchCondition.OwnerComponent = this.Должность_vmoFilter;
            this.Должность_vmoFilter.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтчетПоОтработанномуВремениФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(749, 500);
            this.Controls.Add(this.splitContainer1);
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
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoFilter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        protected NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.DateTime МесяцОтчета_nsgVisualMultipleObject;
        protected NsgInput nsgInput1;
        private System.Windows.Forms.GroupBox groupBox1;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        private System.Windows.Forms.Label label1;
        protected NsgVisualMultipleObject vmoТаблица;
        protected Мониторинг.ФизЛица.ColumnDescriptor Сотрудник_vmoТаблица;
        protected NsgColumnDescriptor.String Д1_vmoТаблица;
        protected NsgColumnDescriptor.String Д2_vmoТаблица;
        protected NsgColumnDescriptor.String Д3;
        protected NsgColumnDescriptor.String Д4_vmoТаблица;
        protected NsgColumnDescriptor.String Д5_vmoТаблица;
        protected NsgColumnDescriptor.String Д6_vmoТаблица;
        protected NsgColumnDescriptor.String Д7_vmoТаблица;
        protected NsgColumnDescriptor.String Д8_vmoТаблица;
        protected NsgColumnDescriptor.String Д9_vmoТаблица;
        protected NsgColumnDescriptor.String Д10_vmoТаблица;
        protected NsgColumnDescriptor.String Д11_vmoТаблица;
        protected NsgColumnDescriptor.String Д12_vmoТаблица;
        protected NsgColumnDescriptor.String Д13_vmoТаблица;
        protected NsgColumnDescriptor.String Д14_vmoТаблица;
        protected NsgColumnDescriptor.String Д15_vmoТаблица;
        protected NsgColumnDescriptor.String Д16_vmoТаблица;
        protected NsgColumnDescriptor.String Д17_vmoТаблица;
        protected NsgColumnDescriptor.String Д18_vmoТаблица;
        protected NsgColumnDescriptor.String Д19_vmoТаблица;
        protected NsgColumnDescriptor.String Д20_vmoТаблица;
        protected NsgColumnDescriptor.String Д21_vmoТаблица;
        protected NsgColumnDescriptor.String Д22_vmoТаблица;
        protected NsgColumnDescriptor.String Д23_vmoТаблица;
        protected NsgColumnDescriptor.String Д24_vmoТаблица;
        protected NsgColumnDescriptor.String Д25_vmoТаблица;
        protected NsgColumnDescriptor.String Д26_vmoТаблица;
        protected NsgColumnDescriptor.String Д27_vmoТаблица;
        protected NsgColumnDescriptor.String Д28_vmoТаблица;
        protected NsgColumnDescriptor.String Д29_vmoТаблица;
        protected NsgColumnDescriptor.String Д30_vmoТаблица;
        protected NsgColumnDescriptor.String Д31_vmoТаблица;
        protected NsgVisualMultipleObject vmoFilter;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoТаблица;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoТаблица;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoТаблица;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoFilter;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoFilter;
        protected Мониторинг.ФизЛица.ColumnDescriptor Сотрудник_vmoFilter;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbСотрудники;
        private System.Windows.Forms.RadioButton rdbТехника;
        protected System.Windows.Forms.CheckBox cbТариф;
        protected System.Windows.Forms.CheckBox cbТехника;
        protected System.Windows.Forms.CheckBox cbСотрудник;
        private System.Windows.Forms.CheckBox cbОбъект;
        protected NsgSoft.Design.NsgButton nbЗаполнить;
        protected System.Windows.Forms.CheckBox cbДолжность;
        protected NsgColumnDescriptor.String Должность_vmoFilter;
    }
}