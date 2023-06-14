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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpВыдача = new System.Windows.Forms.TabPage();
            this.nbВыдать = new NsgSoft.Design.NsgButton();
            this.nbЗаполнить = new NsgSoft.Design.NsgButton();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСписокСпецодежды = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ВсегоВыдано_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.КВыдаче_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.tpСотрБезСИЗ = new System.Windows.Forms.TabPage();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoДанныеДляОтчета = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Количество_vmoДанныеДляОтчета = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ДатаВыдачи_vmoДанныеДляОтчета = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ТребуетсяВыдача_vmoДанныеДляОтчета = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ТребуетсяВозврат_vmoДанныеДляОтчета = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.vmoДопДанныеДляОтчета = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаОтчета_vmoДопДанныеДляОтчета = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.rdsОтчет = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsОтчет", this.rdsОтчет);
            this.rdsДопДанныеОтчета = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДопДанныеОтчета", this.rdsДопДанныеОтчета);
            this.Номенклатура_vmoСписокСпецодежды = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Комплект_vmoСписокСпецодежды = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.РазмерВыданных_vmoСписокСпецодежды = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.РазмерКВыдаче_vmoСписокСпецодежды = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Сотрудник_vmoФильтр = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Номенклатура_vmoДанныеДляОтчета = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Комплект_vmoДанныеДляОтчета = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Сотрудник_vmoДанныеДляОтчета = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Должность_vmoДанныеДляОтчета = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpВыдача.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСписокСпецодежды)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.tpСотрБезСИЗ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанныеДляОтчета)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанныеДляОтчета)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОтчет)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанныеОтчета)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 531);
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
            this.printButton.Location = new System.Drawing.Point(859, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpВыдача);
            this.tabControl1.Controls.Add(this.tpСотрБезСИЗ);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(879, 505);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpВыдача
            // 
            this.tpВыдача.AllowDrop = true;
            this.tpВыдача.Controls.Add(this.nbВыдать);
            this.tpВыдача.Controls.Add(this.nbЗаполнить);
            this.tpВыдача.Controls.Add(this.nsgIGrid1);
            this.tpВыдача.Controls.Add(this.label1);
            this.tpВыдача.Controls.Add(this.nsgInput1);
            this.tpВыдача.Enabled = true;
            this.tpВыдача.Location = new System.Drawing.Point(4, 22);
            this.tpВыдача.Name = "tpВыдача";
            this.tpВыдача.Padding = new System.Windows.Forms.Padding(3);
            this.tpВыдача.Size = new System.Drawing.Size(871, 479);
            this.tpВыдача.TabIndex = 0;
            this.tpВыдача.Text = "Выдача спецодежды";
            this.tpВыдача.UseVisualStyleBackColor = true;
            this.tpВыдача.Visible = false;
            // 
            // nbВыдать
            // 
            this.nbВыдать.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbВыдать.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nbВыдать.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbВыдать.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbВыдать.Location = new System.Drawing.Point(725, 440);
            this.nbВыдать.Name = "NsgButton";
            this.nbВыдать.Size = new System.Drawing.Size(138, 25);
            this.nbВыдать.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbВыдать.TabIndex = 4;
            this.nbВыдать.Text = "ВыдатьСотруднику";
            this.nbВыдать.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbВыдать.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbВыдать_AsyncClick);
            // 
            // nbЗаполнить
            // 
            this.nbЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнить.Location = new System.Drawing.Point(312, 8);
            this.nbЗаполнить.Name = "NsgButton";
            this.nbЗаполнить.Size = new System.Drawing.Size(121, 29);
            this.nbЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнить.TabIndex = 3;
            this.nbЗаполнить.Text = "Заполнить";
            this.nbЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнить_AsyncClick);
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
            this.nsgIGrid1.Location = new System.Drawing.Point(11, 43);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(854, 391);
            this.nsgIGrid1.SourceObject = this.vmoСписокСпецодежды;
            this.nsgIGrid1.TabIndex = 2;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoСписокСпецодежды
            // 
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Номенклатура_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.Комплект_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.ВсегоВыдано_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.КВыдаче_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.ВсегоЗаконченСрок_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.РазмерВыданных_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.Columns.Collection.Add(this.РазмерКВыдаче_vmoСписокСпецодежды);
            this.vmoСписокСпецодежды.IsActive = true;
            this.vmoСписокСпецодежды.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСписокСпецодежды.MetaDataName = "";
            this.vmoСписокСпецодежды.FullName = "";
            // 
            // ВсегоВыдано_vmoСписокСпецодежды
            // 
            this.ВсегоВыдано_vmoСписокСпецодежды.CalcTotal = false;
            this.ВсегоВыдано_vmoСписокСпецодежды.Caption = "ВсегоВыдано";
            this.ВсегоВыдано_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВсегоВыдано_vmoСписокСпецодежды.Name = "ВсегоВыдано";
            this.ВсегоВыдано_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ВсегоВыдано_vmoСписокСпецодежды.PropertyType = typeof(decimal);
            this.ВсегоВыдано_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.ВсегоВыдано_vmoСписокСпецодежды;
            this.ВсегоВыдано_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КВыдаче_vmoСписокСпецодежды
            // 
            this.КВыдаче_vmoСписокСпецодежды.CalcTotal = false;
            this.КВыдаче_vmoСписокСпецодежды.Caption = "КВыдаче";
            this.КВыдаче_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КВыдаче_vmoСписокСпецодежды.Name = "КВыдаче";
            this.КВыдаче_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.КВыдаче_vmoСписокСпецодежды.PropertyType = typeof(decimal);
            this.КВыдаче_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.КВыдаче_vmoСписокСпецодежды;
            this.КВыдаче_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВсегоЗаконченСрок_vmoСписокСпецодежды
            // 
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.CalcTotal = false;
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Caption = "ВсегоЗаконченСрок";
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.Name = "ВсегоЗаконченСрок";
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.PropertyType = typeof(long);
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.ВсегоЗаконченСрок_vmoСписокСпецодежды;
            this.ВсегоЗаконченСрок_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
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
            this.nsgInput1.Location = new System.Drawing.Point(70, 13);
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
            this.nsgInput1.Size = new System.Drawing.Size(229, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 0;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput1.Selected += new System.EventHandler(this.nsgInput1_Selected);
            // 
            // tpСотрБезСИЗ
            // 
            this.tpСотрБезСИЗ.AllowDrop = true;
            this.tpСотрБезСИЗ.Controls.Add(this.nsgInput2);
            this.tpСотрБезСИЗ.Controls.Add(this.nsgGroupsList1);
            this.tpСотрБезСИЗ.Controls.Add(this.nsgObjectFilter1);
            this.tpСотрБезСИЗ.Enabled = true;
            this.tpСотрБезСИЗ.Location = new System.Drawing.Point(4, 22);
            this.tpСотрБезСИЗ.Name = "tabPage2";
            this.tpСотрБезСИЗ.Padding = new System.Windows.Forms.Padding(3);
            this.tpСотрБезСИЗ.Size = new System.Drawing.Size(871, 479);
            this.tpСотрБезСИЗ.TabIndex = 1;
            this.tpСотрБезСИЗ.Text = "Сотрудники без СИЗ и Спецодежды";
            this.tpСотрБезСИЗ.UseVisualStyleBackColor = true;
            this.tpСотрБезСИЗ.Visible = true;
            // 
            // nsgInput2
            // 
            this.nsgInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "";
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
            this.nsgInput2.Requsite = "";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(210, 20);
            this.nsgInput2.TabIndex = 1;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(533, 40);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = null;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(332, 175);
            this.nsgGroupsList1.TabIndex = 0;
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
            this.nsgObjectFilter1.SaveSettings = true;
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
            // vmoДанныеДляОтчета
            // 
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.Номенклатура_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.Комплект_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.Количество_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.ДатаВыдачи_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.ТребуетсяВыдача_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.Сотрудник_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.Должность_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.Columns.Collection.Add(this.ТребуетсяВозврат_vmoДанныеДляОтчета);
            this.vmoДанныеДляОтчета.IsActive = true;
            this.vmoДанныеДляОтчета.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДанныеДляОтчета.MetaDataName = "";
            this.vmoДанныеДляОтчета.FullName = "";
            // 
            // Количество_vmoДанныеДляОтчета
            // 
            this.Количество_vmoДанныеДляОтчета.CalcTotal = false;
            this.Количество_vmoДанныеДляОтчета.Caption = "Количество";
            this.Количество_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_vmoДанныеДляОтчета.Name = "Количество";
            this.Количество_vmoДанныеДляОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoДанныеДляОтчета.PropertyType = typeof(long);
            this.Количество_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.Количество_vmoДанныеДляОтчета;
            this.Количество_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаВыдачи_vmoДанныеДляОтчета
            // 
            this.ДатаВыдачи_vmoДанныеДляОтчета.Caption = "ДатаВыдачи";
            this.ДатаВыдачи_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаВыдачи_vmoДанныеДляОтчета.Name = "ДатаВыдачи";
            this.ДатаВыдачи_vmoДанныеДляОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаВыдачи_vmoДанныеДляОтчета.PropertyType = typeof(System.DateTime);
            this.ДатаВыдачи_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.ДатаВыдачи_vmoДанныеДляОтчета;
            this.ДатаВыдачи_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТребуетсяВыдача_vmoДанныеДляОтчета
            // 
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.Caption = "ТребуетсяВыдача";
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.Name = "ТребуетсяВыдача";
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.PropertyType = typeof(bool);
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.ТребуетсяВыдача_vmoДанныеДляОтчета;
            this.ТребуетсяВыдача_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТребуетсяВозврат_vmoДанныеДляОтчета
            // 
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.Caption = "ТребуетсяВозврат";
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.Name = "ТребуетсяВозврат";
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.PropertyType = typeof(bool);
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.ТребуетсяВозврат_vmoДанныеДляОтчета;
            this.ТребуетсяВозврат_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДопДанныеДляОтчета
            // 
            this.vmoДопДанныеДляОтчета.Columns.Collection.Add(this.ДатаОтчета_vmoДопДанныеДляОтчета);
            this.vmoДопДанныеДляОтчета.IsActive = true;
            this.vmoДопДанныеДляОтчета.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДопДанныеДляОтчета.MetaDataName = "";
            this.vmoДопДанныеДляОтчета.FullName = "";
            // 
            // ДатаОтчета_vmoДопДанныеДляОтчета
            // 
            this.ДатаОтчета_vmoДопДанныеДляОтчета.Caption = "ДатаОтчета";
            this.ДатаОтчета_vmoДопДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаОтчета_vmoДопДанныеДляОтчета.Name = "ДатаОтчета";
            this.ДатаОтчета_vmoДопДанныеДляОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаОтчета_vmoДопДанныеДляОтчета.PropertyType = typeof(System.DateTime);
            this.ДатаОтчета_vmoДопДанныеДляОтчета.SearchCondition.OwnerComponent = this.ДатаОтчета_vmoДопДанныеДляОтчета;
            this.ДатаОтчета_vmoДопДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgReport1
            // 
            this.nsgReport1.CurrentProgressValue = 0;
            this.nsgReport1.HighlightedComponent = null;
            this.nsgReport1.IsSyncMode = true;
            this.nsgReport1.MaxProgressValue = 100;
            this.nsgReport1.OwnerForm = null;
            this.nsgReport1.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport1.ProgressObject = null;
            this.nsgReport1.ProgressProcentage = 0;
            this.nsgReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "NsgSoft.CityGuide.Dll"};
            this.nsgReport1.ReportAlias = "Report";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportGuid = "432815342c074ed59e40a0b6a7714a15";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = null;
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // rdsОтчет
            // 
            this.rdsОтчет.MasterComponent = this.vmoДанныеДляОтчета;
            this.rdsОтчет.Name = "rdsОтчет";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsОтчет;
            this.stiReportDataSource1.Name = "rdsОтчет";
            // 
            // rdsДопДанныеОтчета
            // 
            this.rdsДопДанныеОтчета.MasterComponent = this.vmoДопДанныеДляОтчета;
            this.rdsДопДанныеОтчета.Name = "rdsДопДанныеОтчета";
            this.rdsДопДанныеОтчета.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsДопДанныеОтчета;
            this.stiReportDataSource2.Name = "rdsДопДанныеОтчета";
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
            this.Комплект_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.Комплект_vmoСписокСпецодежды;
            this.Комплект_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РазмерВыданных_vmoСписокСпецодежды
            // 
            this.РазмерВыданных_vmoСписокСпецодежды.Caption = "РазмерВыданных";
            this.РазмерВыданных_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.РазмерВыданных_vmoСписокСпецодежды.Name = "РазмерВыданных";
            this.РазмерВыданных_vmoСписокСпецодежды.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.РазмерВыданных_vmoСписокСпецодежды.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.РазмерВыданных_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.РазмерВыданных_vmoСписокСпецодежды;
            this.РазмерВыданных_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РазмерКВыдаче_vmoСписокСпецодежды
            // 
            this.РазмерКВыдаче_vmoСписокСпецодежды.Caption = "РазмерКВыдаче";
            this.РазмерКВыдаче_vmoСписокСпецодежды.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.РазмерКВыдаче_vmoСписокСпецодежды.Name = "РазмерКВыдаче";
            this.РазмерКВыдаче_vmoСписокСпецодежды.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.РазмерКВыдаче_vmoСписокСпецодежды.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.РазмерКВыдаче_vmoСписокСпецодежды.SearchCondition.OwnerComponent = this.РазмерКВыдаче_vmoСписокСпецодежды;
            this.РазмерКВыдаче_vmoСписокСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Номенклатура_vmoДанныеДляОтчета
            // 
            this.Номенклатура_vmoДанныеДляОтчета.Caption = "Номенклатура";
            this.Номенклатура_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoДанныеДляОтчета.Name = "Номенклатура";
            this.Номенклатура_vmoДанныеДляОтчета.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoДанныеДляОтчета.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.Номенклатура_vmoДанныеДляОтчета;
            this.Номенклатура_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комплект_vmoДанныеДляОтчета
            // 
            this.Комплект_vmoДанныеДляОтчета.Caption = "Комплект";
            this.Комплект_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комплект_vmoДанныеДляОтчета.Name = "Комплект";
            this.Комплект_vmoДанныеДляОтчета.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoДанныеДляОтчета.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.Комплект_vmoДанныеДляОтчета;
            this.Комплект_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoДанныеДляОтчета
            // 
            this.Сотрудник_vmoДанныеДляОтчета.Caption = "Сотрудник";
            this.Сотрудник_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoДанныеДляОтчета.Name = "Сотрудник";
            this.Сотрудник_vmoДанныеДляОтчета.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанныеДляОтчета.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.Сотрудник_vmoДанныеДляОтчета;
            this.Сотрудник_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность_vmoДанныеДляОтчета
            // 
            this.Должность_vmoДанныеДляОтчета.Caption = "Должность";
            this.Должность_vmoДанныеДляОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoДанныеДляОтчета.Name = "Должность";
            this.Должность_vmoДанныеДляОтчета.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoДанныеДляОтчета.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoДанныеДляОтчета.SearchCondition.OwnerComponent = this.Должность_vmoДанныеДляОтчета;
            this.Должность_vmoДанныеДляОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpВыдача.ResumeLayout(false);
            this.tpВыдача.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbВыдать)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСписокСпецодежды)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.tpСотрБезСИЗ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанныеДляОтчета)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанныеДляОтчета)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОтчет)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанныеОтчета)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        protected КомплектыСпецодежды.ColumnDescriptor Комплект_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Decimal ВсегоВыдано_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Decimal КВыдаче_vmoСписокСпецодежды;
        protected NsgInput nsgInput1;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoСписокСпецодежды;
        protected NsgColumnDescriptor.Int64 ВсегоЗаконченСрок_vmoСписокСпецодежды;
        protected NsgSoft.Design.NsgButton nbЗаполнить;
        protected NsgIGrid nsgIGrid1;
        protected NsgSoft.Design.NsgButton nbВыдать;
        protected Учет.Размеры.ColumnDescriptor РазмерВыданных_vmoСписокСпецодежды;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoФильтр;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoДанныеДляОтчета;
        protected КомплектыСпецодежды.ColumnDescriptor Комплект_vmoДанныеДляОтчета;
        protected NsgColumnDescriptor.Int64 Количество_vmoДанныеДляОтчета;
        protected NsgColumnDescriptor.DateTime ДатаВыдачи_vmoДанныеДляОтчета;
        protected NsgColumnDescriptor.Boolean ТребуетсяВыдача_vmoДанныеДляОтчета;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoДанныеДляОтчета;
        protected NsgColumnDescriptor.Boolean ТребуетсяВозврат_vmoДанныеДляОтчета;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoДанныеДляОтчета;
        protected NsgInput nsgInput2;
        protected NsgColumnDescriptor.DateTime ДатаОтчета_vmoДопДанныеДляОтчета;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsОтчет;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДопДанныеОтчета;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tpВыдача;
        protected System.Windows.Forms.TabPage tpСотрБезСИЗ;
        protected System.Windows.Forms.Label label1;
        protected NsgVisualMultipleObject vmoСписокСпецодежды;
        protected Учет.Размеры.ColumnDescriptor РазмерКВыдаче_vmoСписокСпецодежды;
        protected NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        protected NsgVisualMultipleObject vmoФильтр;
        protected NsgVisualMultipleObject vmoДанныеДляОтчета;
        protected NsgVisualMultipleObject vmoДопДанныеДляОтчета;
        protected NsgSoft.ReportBuilder.NsgReport nsgReport1;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
    }
}