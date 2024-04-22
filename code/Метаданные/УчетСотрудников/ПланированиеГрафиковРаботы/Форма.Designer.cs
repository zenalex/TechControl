using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.УчетСотрудников

{
    
    public partial class ПланированиеГрафиковРаботыФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПланированиеГрафиковРаботыФорма));
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
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаМесяца = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Сотрудник_vmoТаблицаМесяца = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.ВидРежимаРаботы_vmoТаблицаМесяца = new TechControl.Метаданные.Перечисления.ВидыРежимовРаботы.ColumnDescriptor();
            this.Д1_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д2_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д3_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д4_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д5 = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д6_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д7_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д8_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д9_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д10_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д11_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д12_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д13_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д14_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д15_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д16_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д17_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д18_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д19_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д20_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д21_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д22_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д23_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д24_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д25_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д26_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д27_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д28_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д29_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д30_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Д31_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Сбросить_vmoТаблицаМесяца = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpПланирование = new System.Windows.Forms.TabPage();
            this.nbСохранить = new NsgSoft.Design.NsgButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.МесяцГрафика = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.bgwЗаполнениеТаблицы = new NsgSoft.Forms.NsgBackgroundWorker(this.components);
            this.Должность_vmoТаблицаМесяца = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаМесяца)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpПланирование.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbСохранить)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
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
            this.panelButtonReportForm.Size = new System.Drawing.Size(684, 30);
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
            this.printButton.Location = new System.Drawing.Point(398, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 28);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МесяцГрафика);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
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
            nsgIGridColumn1.Name = "Сотрудник";
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
            nsgIGridColumn2.Name = "ВидРежимаРаботы";
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
            nsgIGridColumn3.Name = "1";
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
            nsgIGridColumn4.Name = "2";
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
            nsgIGridColumn5.Name = "3";
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
            nsgIGridColumn6.ImportedFromVMO = false;
            nsgIGridColumn6.Name = "4";
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
            nsgIGridColumn7.ImportedFromVMO = false;
            nsgIGridColumn7.Name = "5";
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
            nsgIGridColumn8.ImportedFromVMO = false;
            nsgIGridColumn8.Name = "6";
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
            nsgIGridColumn9.ImportedFromVMO = false;
            nsgIGridColumn9.Name = "7";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Width = 100;
            nsgIGridColumn10.AllowFilter = true;
            nsgIGridColumn10.AllowGroupSelect = false;
            nsgIGridColumn10.AllowResize = true;
            nsgIGridColumn10.AutoResize = true;
            nsgIGridColumn10.Caption = "";
            nsgIGridColumn10.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.Name = "8";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Width = 100;
            nsgIGridColumn11.AllowFilter = true;
            nsgIGridColumn11.AllowGroupSelect = false;
            nsgIGridColumn11.AllowResize = true;
            nsgIGridColumn11.AutoResize = true;
            nsgIGridColumn11.Caption = "";
            nsgIGridColumn11.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn11.DateFormat = null;
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.Name = "9";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.UseAsHeaderImage = false;
            nsgIGridColumn11.Width = 100;
            nsgIGridColumn12.AllowFilter = true;
            nsgIGridColumn12.AllowGroupSelect = false;
            nsgIGridColumn12.AllowResize = true;
            nsgIGridColumn12.AutoResize = true;
            nsgIGridColumn12.Caption = "";
            nsgIGridColumn12.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn12.DateFormat = null;
            nsgIGridColumn12.ImportedFromVMO = false;
            nsgIGridColumn12.Name = "10";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn12.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn12.UseAsHeaderImage = false;
            nsgIGridColumn12.Width = 100;
            nsgIGridColumn13.AllowFilter = true;
            nsgIGridColumn13.AllowGroupSelect = false;
            nsgIGridColumn13.AllowResize = true;
            nsgIGridColumn13.AutoResize = true;
            nsgIGridColumn13.Caption = "";
            nsgIGridColumn13.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn13.DateFormat = null;
            nsgIGridColumn13.ImportedFromVMO = false;
            nsgIGridColumn13.Name = "11";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn13.UseAsHeaderImage = false;
            nsgIGridColumn13.Width = 100;
            nsgIGridColumn14.AllowFilter = true;
            nsgIGridColumn14.AllowGroupSelect = false;
            nsgIGridColumn14.AllowResize = true;
            nsgIGridColumn14.AutoResize = true;
            nsgIGridColumn14.Caption = "";
            nsgIGridColumn14.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn14.DateFormat = null;
            nsgIGridColumn14.ImportedFromVMO = false;
            nsgIGridColumn14.Name = "12";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Width = 100;
            nsgIGridColumn15.AllowFilter = true;
            nsgIGridColumn15.AllowGroupSelect = false;
            nsgIGridColumn15.AllowResize = true;
            nsgIGridColumn15.AutoResize = true;
            nsgIGridColumn15.Caption = "";
            nsgIGridColumn15.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn15.DateFormat = null;
            nsgIGridColumn15.ImportedFromVMO = false;
            nsgIGridColumn15.Name = "13";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn15.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn15.UseAsHeaderImage = false;
            nsgIGridColumn15.Width = 100;
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.ImportedFromVMO = false;
            nsgIGridColumn16.Name = "14";
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
            nsgIGridColumn17.ImportedFromVMO = false;
            nsgIGridColumn17.Name = "15";
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
            nsgIGridColumn18.ImportedFromVMO = false;
            nsgIGridColumn18.Name = "16";
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
            nsgIGridColumn19.ImportedFromVMO = false;
            nsgIGridColumn19.Name = "17";
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
            nsgIGridColumn20.ImportedFromVMO = false;
            nsgIGridColumn20.Name = "18";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn21.ImportedFromVMO = false;
            nsgIGridColumn21.Name = "19";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn22.ImportedFromVMO = false;
            nsgIGridColumn22.Name = "20";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn22.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn22.UseAsHeaderImage = false;
            nsgIGridColumn22.Width = 100;
            nsgIGridColumn23.AllowFilter = true;
            nsgIGridColumn23.AllowGroupSelect = false;
            nsgIGridColumn23.AllowResize = true;
            nsgIGridColumn23.AutoResize = true;
            nsgIGridColumn23.Caption = "";
            nsgIGridColumn23.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn23.DateFormat = null;
            nsgIGridColumn23.ImportedFromVMO = false;
            nsgIGridColumn23.Name = "21";
            nsgIGridColumn23.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn23.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn23.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn23.UseAsHeaderImage = false;
            nsgIGridColumn23.Width = 100;
            nsgIGridColumn24.AllowFilter = true;
            nsgIGridColumn24.AllowGroupSelect = false;
            nsgIGridColumn24.AllowResize = true;
            nsgIGridColumn24.AutoResize = true;
            nsgIGridColumn24.Caption = "";
            nsgIGridColumn24.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn24.DateFormat = null;
            nsgIGridColumn24.ImportedFromVMO = false;
            nsgIGridColumn24.Name = "22";
            nsgIGridColumn24.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn24.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn24.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn24.UseAsHeaderImage = false;
            nsgIGridColumn24.Width = 100;
            nsgIGridColumn25.AllowFilter = true;
            nsgIGridColumn25.AllowGroupSelect = false;
            nsgIGridColumn25.AllowResize = true;
            nsgIGridColumn25.AutoResize = true;
            nsgIGridColumn25.Caption = "";
            nsgIGridColumn25.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn25.DateFormat = null;
            nsgIGridColumn25.ImportedFromVMO = false;
            nsgIGridColumn25.Name = "23";
            nsgIGridColumn25.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn25.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn25.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn25.UseAsHeaderImage = false;
            nsgIGridColumn25.Width = 100;
            nsgIGridColumn26.AllowFilter = true;
            nsgIGridColumn26.AllowGroupSelect = false;
            nsgIGridColumn26.AllowResize = true;
            nsgIGridColumn26.AutoResize = true;
            nsgIGridColumn26.Caption = "";
            nsgIGridColumn26.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn26.DateFormat = null;
            nsgIGridColumn26.ImportedFromVMO = false;
            nsgIGridColumn26.Name = "24";
            nsgIGridColumn26.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn26.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn26.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn26.UseAsHeaderImage = false;
            nsgIGridColumn26.Width = 100;
            nsgIGridColumn27.AllowFilter = true;
            nsgIGridColumn27.AllowGroupSelect = false;
            nsgIGridColumn27.AllowResize = true;
            nsgIGridColumn27.AutoResize = true;
            nsgIGridColumn27.Caption = "";
            nsgIGridColumn27.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn27.DateFormat = null;
            nsgIGridColumn27.ImportedFromVMO = false;
            nsgIGridColumn27.Name = "25";
            nsgIGridColumn27.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn27.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn27.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn27.UseAsHeaderImage = false;
            nsgIGridColumn27.Width = 100;
            nsgIGridColumn28.AllowFilter = true;
            nsgIGridColumn28.AllowGroupSelect = false;
            nsgIGridColumn28.AllowResize = true;
            nsgIGridColumn28.AutoResize = true;
            nsgIGridColumn28.Caption = "";
            nsgIGridColumn28.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn28.DateFormat = null;
            nsgIGridColumn28.ImportedFromVMO = false;
            nsgIGridColumn28.Name = "26";
            nsgIGridColumn28.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn28.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn28.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn28.UseAsHeaderImage = false;
            nsgIGridColumn28.Width = 100;
            nsgIGridColumn29.AllowFilter = true;
            nsgIGridColumn29.AllowGroupSelect = false;
            nsgIGridColumn29.AllowResize = true;
            nsgIGridColumn29.AutoResize = true;
            nsgIGridColumn29.Caption = "";
            nsgIGridColumn29.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn29.DateFormat = null;
            nsgIGridColumn29.ImportedFromVMO = false;
            nsgIGridColumn29.Name = "27";
            nsgIGridColumn29.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn29.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn29.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn29.UseAsHeaderImage = false;
            nsgIGridColumn29.Width = 100;
            nsgIGridColumn30.AllowFilter = true;
            nsgIGridColumn30.AllowGroupSelect = false;
            nsgIGridColumn30.AllowResize = true;
            nsgIGridColumn30.AutoResize = true;
            nsgIGridColumn30.Caption = "";
            nsgIGridColumn30.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn30.DateFormat = null;
            nsgIGridColumn30.ImportedFromVMO = false;
            nsgIGridColumn30.Name = "28";
            nsgIGridColumn30.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn30.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn30.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn30.UseAsHeaderImage = false;
            nsgIGridColumn30.Width = 100;
            nsgIGridColumn31.AllowFilter = true;
            nsgIGridColumn31.AllowGroupSelect = false;
            nsgIGridColumn31.AllowResize = true;
            nsgIGridColumn31.AutoResize = true;
            nsgIGridColumn31.Caption = "";
            nsgIGridColumn31.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn31.DateFormat = null;
            nsgIGridColumn31.ImportedFromVMO = false;
            nsgIGridColumn31.Name = "29";
            nsgIGridColumn31.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn31.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn31.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn31.UseAsHeaderImage = false;
            nsgIGridColumn31.Width = 100;
            nsgIGridColumn32.AllowFilter = true;
            nsgIGridColumn32.AllowGroupSelect = false;
            nsgIGridColumn32.AllowResize = true;
            nsgIGridColumn32.AutoResize = true;
            nsgIGridColumn32.Caption = "";
            nsgIGridColumn32.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn32.DateFormat = null;
            nsgIGridColumn32.ImportedFromVMO = false;
            nsgIGridColumn32.Name = "30";
            nsgIGridColumn32.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn32.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn32.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn32.UseAsHeaderImage = false;
            nsgIGridColumn32.Width = 100;
            nsgIGridColumn33.AllowFilter = true;
            nsgIGridColumn33.AllowGroupSelect = false;
            nsgIGridColumn33.AllowResize = true;
            nsgIGridColumn33.AutoResize = true;
            nsgIGridColumn33.Caption = "";
            nsgIGridColumn33.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn33.DateFormat = null;
            nsgIGridColumn33.ImportedFromVMO = false;
            nsgIGridColumn33.Name = "31";
            nsgIGridColumn33.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn33.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn33.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn33.UseAsHeaderImage = false;
            nsgIGridColumn33.Width = 100;
            nsgIGridColumn34.AllowFilter = true;
            nsgIGridColumn34.AllowGroupSelect = false;
            nsgIGridColumn34.AllowResize = true;
            nsgIGridColumn34.AutoResize = true;
            nsgIGridColumn34.Caption = "";
            nsgIGridColumn34.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn34.DateFormat = null;
            nsgIGridColumn34.ImportedFromVMO = false;
            nsgIGridColumn34.Name = "Сбросить";
            nsgIGridColumn34.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn34.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn34.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn34.UseAsHeaderImage = false;
            nsgIGridColumn34.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
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
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn22);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn23);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn24);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn25);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn26);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn27);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn28);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn29);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn30);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn31);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn32);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn33);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn34);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 64);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(646, 384);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаМесяца;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellEndEdit);
            // 
            // vmoТаблицаМесяца
            // 
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Сотрудник_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.ВидРежимаРаботы_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д1_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д2_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д3_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д4_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д5);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д6_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д7_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д8_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д9_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д10_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д11_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д12_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д13_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д14_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д15_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д16_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д17_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д18_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д19_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д20_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д21_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д22_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д23_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д24_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д25_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д26_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д27_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д28_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д29_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д30_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Д31_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Сбросить_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.Columns.Collection.Add(this.Должность_vmoТаблицаМесяца);
            this.vmoТаблицаМесяца.IsActive = true;
            this.vmoТаблицаМесяца.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаМесяца.MetaDataName = "";
            this.vmoТаблицаМесяца.FullName = "";
            // 
            // Сотрудник_vmoТаблицаМесяца
            // 
            this.Сотрудник_vmoТаблицаМесяца.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoТаблицаМесяца.Name = "Сотрудник";
            this.Сотрудник_vmoТаблицаМесяца.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаМесяца.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблицаМесяца;
            this.Сотрудник_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВидРежимаРаботы_vmoТаблицаМесяца
            // 
            this.ВидРежимаРаботы_vmoТаблицаМесяца.Caption = "ВидРежимаРаботы";
            this.ВидРежимаРаботы_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВидРежимаРаботы_vmoТаблицаМесяца.Name = "ВидРежимаРаботы";
            this.ВидРежимаРаботы_vmoТаблицаМесяца.NSGType = typeof(TechControl.Метаданные.Перечисления.ВидыРежимовРаботы);
            this.ВидРежимаРаботы_vmoТаблицаМесяца.PropertyType = typeof(TechControl.Метаданные.Перечисления.ВидыРежимовРаботы);
            this.ВидРежимаРаботы_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.ВидРежимаРаботы_vmoТаблицаМесяца;
            this.ВидРежимаРаботы_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д1_vmoТаблицаМесяца
            // 
            this.Д1_vmoТаблицаМесяца.Caption = "1";
            this.Д1_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д1_vmoТаблицаМесяца.Name = "1";
            this.Д1_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д1_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д1_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д1_vmoТаблицаМесяца;
            this.Д1_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д2_vmoТаблицаМесяца
            // 
            this.Д2_vmoТаблицаМесяца.Caption = "2";
            this.Д2_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д2_vmoТаблицаМесяца.Name = "2";
            this.Д2_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д2_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д2_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д2_vmoТаблицаМесяца;
            this.Д2_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д3_vmoТаблицаМесяца
            // 
            this.Д3_vmoТаблицаМесяца.Caption = "3";
            this.Д3_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д3_vmoТаблицаМесяца.Name = "3";
            this.Д3_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д3_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д3_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д3_vmoТаблицаМесяца;
            this.Д3_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д4_vmoТаблицаМесяца
            // 
            this.Д4_vmoТаблицаМесяца.Caption = "4";
            this.Д4_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д4_vmoТаблицаМесяца.Name = "4";
            this.Д4_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д4_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д4_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д4_vmoТаблицаМесяца;
            this.Д4_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д5
            // 
            this.Д5.Caption = "5";
            this.Д5.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д5.Name = "5";
            this.Д5.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д5.PropertyType = typeof(bool);
            this.Д5.SearchCondition.OwnerComponent = this.Д5;
            this.Д5.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д6_vmoТаблицаМесяца
            // 
            this.Д6_vmoТаблицаМесяца.Caption = "6";
            this.Д6_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д6_vmoТаблицаМесяца.Name = "6";
            this.Д6_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д6_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д6_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д6_vmoТаблицаМесяца;
            this.Д6_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д7_vmoТаблицаМесяца
            // 
            this.Д7_vmoТаблицаМесяца.Caption = "7";
            this.Д7_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д7_vmoТаблицаМесяца.Name = "7";
            this.Д7_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д7_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д7_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д7_vmoТаблицаМесяца;
            this.Д7_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д8_vmoТаблицаМесяца
            // 
            this.Д8_vmoТаблицаМесяца.Caption = "8";
            this.Д8_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д8_vmoТаблицаМесяца.Name = "8";
            this.Д8_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д8_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д8_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д8_vmoТаблицаМесяца;
            this.Д8_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д9_vmoТаблицаМесяца
            // 
            this.Д9_vmoТаблицаМесяца.Caption = "9";
            this.Д9_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д9_vmoТаблицаМесяца.Name = "9";
            this.Д9_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д9_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д9_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д9_vmoТаблицаМесяца;
            this.Д9_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д10_vmoТаблицаМесяца
            // 
            this.Д10_vmoТаблицаМесяца.Caption = "10";
            this.Д10_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д10_vmoТаблицаМесяца.Name = "10";
            this.Д10_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д10_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д10_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д10_vmoТаблицаМесяца;
            this.Д10_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д11_vmoТаблицаМесяца
            // 
            this.Д11_vmoТаблицаМесяца.Caption = "11";
            this.Д11_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д11_vmoТаблицаМесяца.Name = "11";
            this.Д11_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д11_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д11_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д11_vmoТаблицаМесяца;
            this.Д11_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д12_vmoТаблицаМесяца
            // 
            this.Д12_vmoТаблицаМесяца.Caption = "12";
            this.Д12_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д12_vmoТаблицаМесяца.Name = "12";
            this.Д12_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д12_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д12_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д12_vmoТаблицаМесяца;
            this.Д12_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д13_vmoТаблицаМесяца
            // 
            this.Д13_vmoТаблицаМесяца.Caption = "13";
            this.Д13_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д13_vmoТаблицаМесяца.Name = "13";
            this.Д13_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д13_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д13_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д13_vmoТаблицаМесяца;
            this.Д13_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д14_vmoТаблицаМесяца
            // 
            this.Д14_vmoТаблицаМесяца.Caption = "14";
            this.Д14_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д14_vmoТаблицаМесяца.Name = "14";
            this.Д14_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д14_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д14_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д14_vmoТаблицаМесяца;
            this.Д14_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д15_vmoТаблицаМесяца
            // 
            this.Д15_vmoТаблицаМесяца.Caption = "15";
            this.Д15_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д15_vmoТаблицаМесяца.Name = "15";
            this.Д15_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д15_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д15_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д15_vmoТаблицаМесяца;
            this.Д15_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д16_vmoТаблицаМесяца
            // 
            this.Д16_vmoТаблицаМесяца.Caption = "16";
            this.Д16_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д16_vmoТаблицаМесяца.Name = "16";
            this.Д16_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д16_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д16_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д16_vmoТаблицаМесяца;
            this.Д16_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д17_vmoТаблицаМесяца
            // 
            this.Д17_vmoТаблицаМесяца.Caption = "17";
            this.Д17_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д17_vmoТаблицаМесяца.Name = "17";
            this.Д17_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д17_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д17_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д17_vmoТаблицаМесяца;
            this.Д17_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д18_vmoТаблицаМесяца
            // 
            this.Д18_vmoТаблицаМесяца.Caption = "18";
            this.Д18_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д18_vmoТаблицаМесяца.Name = "18";
            this.Д18_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д18_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д18_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д18_vmoТаблицаМесяца;
            this.Д18_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д19_vmoТаблицаМесяца
            // 
            this.Д19_vmoТаблицаМесяца.Caption = "19";
            this.Д19_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д19_vmoТаблицаМесяца.Name = "19";
            this.Д19_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д19_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д19_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д19_vmoТаблицаМесяца;
            this.Д19_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д20_vmoТаблицаМесяца
            // 
            this.Д20_vmoТаблицаМесяца.Caption = "20";
            this.Д20_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д20_vmoТаблицаМесяца.Name = "20";
            this.Д20_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д20_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д20_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д20_vmoТаблицаМесяца;
            this.Д20_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д21_vmoТаблицаМесяца
            // 
            this.Д21_vmoТаблицаМесяца.Caption = "21";
            this.Д21_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д21_vmoТаблицаМесяца.Name = "21";
            this.Д21_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д21_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д21_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д21_vmoТаблицаМесяца;
            this.Д21_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д22_vmoТаблицаМесяца
            // 
            this.Д22_vmoТаблицаМесяца.Caption = "22";
            this.Д22_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д22_vmoТаблицаМесяца.Name = "22";
            this.Д22_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д22_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д22_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д22_vmoТаблицаМесяца;
            this.Д22_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д23_vmoТаблицаМесяца
            // 
            this.Д23_vmoТаблицаМесяца.Caption = "23";
            this.Д23_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д23_vmoТаблицаМесяца.Name = "23";
            this.Д23_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д23_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д23_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д23_vmoТаблицаМесяца;
            this.Д23_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д24_vmoТаблицаМесяца
            // 
            this.Д24_vmoТаблицаМесяца.Caption = "24";
            this.Д24_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д24_vmoТаблицаМесяца.Name = "24";
            this.Д24_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д24_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д24_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д24_vmoТаблицаМесяца;
            this.Д24_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д25_vmoТаблицаМесяца
            // 
            this.Д25_vmoТаблицаМесяца.Caption = "25";
            this.Д25_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д25_vmoТаблицаМесяца.Name = "25";
            this.Д25_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д25_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д25_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д25_vmoТаблицаМесяца;
            this.Д25_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д26_vmoТаблицаМесяца
            // 
            this.Д26_vmoТаблицаМесяца.Caption = "26";
            this.Д26_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д26_vmoТаблицаМесяца.Name = "26";
            this.Д26_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д26_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д26_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д26_vmoТаблицаМесяца;
            this.Д26_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д27_vmoТаблицаМесяца
            // 
            this.Д27_vmoТаблицаМесяца.Caption = "27";
            this.Д27_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д27_vmoТаблицаМесяца.Name = "27";
            this.Д27_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д27_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д27_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д27_vmoТаблицаМесяца;
            this.Д27_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д28_vmoТаблицаМесяца
            // 
            this.Д28_vmoТаблицаМесяца.Caption = "28";
            this.Д28_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д28_vmoТаблицаМесяца.Name = "28";
            this.Д28_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д28_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д28_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д28_vmoТаблицаМесяца;
            this.Д28_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д29_vmoТаблицаМесяца
            // 
            this.Д29_vmoТаблицаМесяца.Caption = "29";
            this.Д29_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д29_vmoТаблицаМесяца.Name = "29";
            this.Д29_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д29_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д29_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д29_vmoТаблицаМесяца;
            this.Д29_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д30_vmoТаблицаМесяца
            // 
            this.Д30_vmoТаблицаМесяца.Caption = "30";
            this.Д30_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д30_vmoТаблицаМесяца.Name = "30";
            this.Д30_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д30_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д30_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д30_vmoТаблицаМесяца;
            this.Д30_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д31_vmoТаблицаМесяца
            // 
            this.Д31_vmoТаблицаМесяца.Caption = "31";
            this.Д31_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д31_vmoТаблицаМесяца.Name = "31";
            this.Д31_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Д31_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Д31_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Д31_vmoТаблицаМесяца;
            this.Д31_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сбросить_vmoТаблицаМесяца
            // 
            this.Сбросить_vmoТаблицаМесяца.Caption = "Сбросить";
            this.Сбросить_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сбросить_vmoТаблицаМесяца.Name = "Сбросить";
            this.Сбросить_vmoТаблицаМесяца.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Сбросить_vmoТаблицаМесяца.PropertyType = typeof(bool);
            this.Сбросить_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Сбросить_vmoТаблицаМесяца;
            this.Сбросить_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpПланирование);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 480);
            this.tabControl1.TabIndex = 9;
            // 
            // tpПланирование
            // 
            this.tpПланирование.AllowDrop = true;
            this.tpПланирование.Controls.Add(this.nbСохранить);
            this.tpПланирование.Controls.Add(this.label2);
            this.tpПланирование.Controls.Add(this.nsgInput2);
            this.tpПланирование.Controls.Add(this.label1);
            this.tpПланирование.Controls.Add(this.nsgInput1);
            this.tpПланирование.Controls.Add(this.nsgIGrid1);
            this.tpПланирование.Enabled = true;
            this.tpПланирование.Location = new System.Drawing.Point(4, 22);
            this.tpПланирование.Name = "tabPage1";
            this.tpПланирование.Padding = new System.Windows.Forms.Padding(3);
            this.tpПланирование.Size = new System.Drawing.Size(658, 454);
            this.tpПланирование.TabIndex = 0;
            this.tpПланирование.Text = "ПланированиеРежимаРаботыСотрудников";
            this.tpПланирование.UseVisualStyleBackColor = true;
            this.tpПланирование.Visible = true;
            // 
            // nbСохранить
            // 
            this.nbСохранить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbСохранить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbСохранить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbСохранить.Location = new System.Drawing.Point(395, 7);
            this.nbСохранить.Name = "NsgButton";
            this.nbСохранить.Size = new System.Drawing.Size(114, 25);
            this.nbСохранить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbСохранить.TabIndex = 5;
            this.nbСохранить.Text = "Сохранить";
            this.nbСохранить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbСохранить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbСохранить_AsyncClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объект";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.Format = NsgSoft.Common.NsgDateTimeFormat.Month;
            this.nsgInput2.FullName = "Объект";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(63, 41);
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
            this.nsgInput2.Size = new System.Drawing.Size(315, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 3;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput2.Selected += new System.EventHandler(this.nsgInput2_Selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Месяц";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.Format = NsgSoft.Common.NsgDateTimeFormat.Month;
            this.nsgInput1.FullName = "МесяцГрафика";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(63, 12);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "МесяцГрафика";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(155, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 1;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput1.Selected += new System.EventHandler(this.nsgInput1_Selected);
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
            // МесяцГрафика
            // 
            this.МесяцГрафика.Caption = "МесяцГрафика";
            this.МесяцГрафика.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.МесяцГрафика.Name = "МесяцГрафика";
            this.МесяцГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.МесяцГрафика.PropertyType = typeof(System.DateTime);
            this.МесяцГрафика.SearchCondition.OwnerComponent = this.МесяцГрафика;
            this.МесяцГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // bgwЗаполнениеТаблицы
            // 
            this.bgwЗаполнениеТаблицы.CancelForbidden = false;
            this.bgwЗаполнениеТаблицы.CurrentProgressValue = 0;
            this.bgwЗаполнениеТаблицы.Description = "";
            this.bgwЗаполнениеТаблицы.EventGeneratorObject = null;
            this.bgwЗаполнениеТаблицы.MaxProgressValue = 100;
            this.bgwЗаполнениеТаблицы.Name = "NsgBackgroundWorker";
            this.bgwЗаполнениеТаблицы.OwnerForm = this;
            this.bgwЗаполнениеТаблицы.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.bgwЗаполнениеТаблицы.ProgressObject = null;
            this.bgwЗаполнениеТаблицы.ProgressProcentage = 0;
            this.bgwЗаполнениеТаблицы.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwЗаполнениеТаблицы_DoWork);
            // 
            // Должность_vmoТаблицаМесяца
            // 
            this.Должность_vmoТаблицаМесяца.Caption = "Должность";
            this.Должность_vmoТаблицаМесяца.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoТаблицаМесяца.Name = "Должность";
            this.Должность_vmoТаблицаМесяца.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаМесяца.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаМесяца.SearchCondition.OwnerComponent = this.Должность_vmoТаблицаМесяца;
            this.Должность_vmoТаблицаМесяца.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПланированиеГрафиковРаботыФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(684, 548);
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаМесяца)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpПланирование.ResumeLayout(false);
            this.tpПланирование.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbСохранить)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpПланирование;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoТаблицаМесяца;
        protected Перечисления.ВидыРежимовРаботы.ColumnDescriptor ВидРежимаРаботы_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д1_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д2_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д3_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д4_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д5;
        protected NsgColumnDescriptor.Boolean Д6_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д7_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д8_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д9_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д10_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д11_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д12_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д13_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д14_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д15_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д16_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д17_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д18_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д19_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д20_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д21_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д22_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д23_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д24_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д25_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д26_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д27_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д28_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д29_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д30_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.Boolean Д31_vmoТаблицаМесяца;
        protected NsgColumnDescriptor.DateTime МесяцГрафика;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected System.Windows.Forms.Label label2;
        protected NsgInput nsgInput2;
        private System.Windows.Forms.Label label1;
        protected NsgInput nsgInput1;
        protected NsgColumnDescriptor.Boolean Сбросить_vmoТаблицаМесяца;
        protected NsgBackgroundWorker bgwЗаполнениеТаблицы;
        private NsgVisualMultipleObject vmoТаблицаМесяца;
        private NsgIGrid nsgIGrid1;
        protected NsgSoft.Design.NsgButton nbСохранить;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoТаблицаМесяца;
    }
}