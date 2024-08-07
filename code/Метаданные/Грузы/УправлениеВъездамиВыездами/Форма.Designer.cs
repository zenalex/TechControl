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
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoФотографии = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Фото_vmoФотографии = new TechControl.Метаданные.Учет.Фотографии.ColumnDescriptor();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСостояние = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ТекущаяТехника_vmoСостояние = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ВремяПриезда_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Груз_vmoСостояние = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.Объем_vmoСостояние = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Объект_vmoСостояние = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
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
            this.tpЗаднимЧислом = new System.Windows.Forms.TabPage();
            this.nbОформитьЗаднимЧислом = new NsgSoft.Design.NsgButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nsgInput19 = new NsgSoft.Forms.NsgInput();
            this.vmoЗаднимЧислом = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаВъезда_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаВыезда_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Техника_vmoЗаднимЧислом = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.НомерАвто_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ГрузНаВъезде_vmoЗаднимЧислом = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ГрузНаВыезде_vmoЗаднимЧислом = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВодительВъезд_vmoЗаднимЧислом = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.ВодительВыезд_vmoЗаднимЧислом = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.КППВъезд_vmoЗаднимЧислом = new TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты.ColumnDescriptor();
            this.КППВыезд_vmoЗаднимЧислом = new TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты.ColumnDescriptor();
            this.КомментарийВъезд_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.КомментарийВыезд_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.nsgInput24 = new NsgSoft.Forms.NsgInput();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nsgInput20 = new NsgSoft.Forms.NsgInput();
            this.nsgInput23 = new NsgSoft.Forms.NsgInput();
            this.nsgInput21 = new NsgSoft.Forms.NsgInput();
            this.nsgInput22 = new NsgSoft.Forms.NsgInput();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nsgInput14 = new NsgSoft.Forms.NsgInput();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nsgInput13 = new NsgSoft.Forms.NsgInput();
            this.nsgInput18 = new NsgSoft.Forms.NsgInput();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nsgInput15 = new NsgSoft.Forms.NsgInput();
            this.nsgInput17 = new NsgSoft.Forms.NsgInput();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nsgInput16 = new NsgSoft.Forms.NsgInput();
            this.nsgInput12 = new NsgSoft.Forms.NsgInput();
            this.label14 = new System.Windows.Forms.Label();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.label13 = new System.Windows.Forms.Label();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nbwЗаполнениеСостояния = new NsgSoft.Forms.NsgBackgroundWorker(this.components);
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
            this.vmoСостояниеВъездовВыездов = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ВидГруза_vmoСостояниеВъездовВыездов = new TechControl.Метаданные.Грузы.ВидыГрузов.ColumnDescriptor();
            this.ДатаДокумента_vmoСостояниеВъездовВыездов = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.КПП_vmoСостояниеВъездовВыездов = new TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты.ColumnDescriptor();
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Объект_vmoСостояниеВъездовВыездов = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОбъемГруза_vmoСостояниеВъездовВыездов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Техника_vmoСостояниеВъездовВыездов = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов = new TechControl.Метаданные.Сервис.ВидыДвижений.ColumnDescriptor();
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
            this.tpЗаднимЧислом.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbОформитьЗаднимЧислом)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаднимЧислом)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput22)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояниеВъездовВыездов)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 474);
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
            // tpЗаднимЧислом
            // 
            this.tpЗаднимЧислом.AllowDrop = true;
            this.tpЗаднимЧислом.Controls.Add(this.nsgPeriodPicker1);
            this.tpЗаднимЧислом.Controls.Add(this.nsgIGrid3);
            this.tpЗаднимЧислом.Controls.Add(this.nbОформитьЗаднимЧислом);
            this.tpЗаднимЧислом.Controls.Add(this.groupBox3);
            this.tpЗаднимЧислом.Controls.Add(this.groupBox2);
            this.tpЗаднимЧислом.Controls.Add(this.nsgInput12);
            this.tpЗаднимЧислом.Controls.Add(this.label14);
            this.tpЗаднимЧислом.Controls.Add(this.nsgInput11);
            this.tpЗаднимЧислом.Controls.Add(this.label13);
            this.tpЗаднимЧислом.Enabled = true;
            this.tpЗаднимЧислом.Location = new System.Drawing.Point(4, 22);
            this.tpЗаднимЧислом.Name = "tpЗаднимЧислом";
            this.tpЗаднимЧислом.Size = new System.Drawing.Size(1128, 405);
            this.tpЗаднимЧислом.TabIndex = 3;
            this.tpЗаднимЧислом.Text = "ОформлениеЗаднимЧислом";
            this.tpЗаднимЧислом.UseVisualStyleBackColor = true;
            this.tpЗаднимЧислом.Visible = true;
            // 
            // nbОформитьЗаднимЧислом
            // 
            this.nbОформитьЗаднимЧислом.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbОформитьЗаднимЧислом.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbОформитьЗаднимЧислом.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbОформитьЗаднимЧислом.Location = new System.Drawing.Point(9, 335);
            this.nbОформитьЗаднимЧислом.Name = "NsgButton";
            this.nbОформитьЗаднимЧислом.Size = new System.Drawing.Size(168, 25);
            this.nbОформитьЗаднимЧислом.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbОформитьЗаднимЧислом.TabIndex = 32;
            this.nbОформитьЗаднимЧислом.Text = "Оформить";
            this.nbОформитьЗаднимЧислом.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbОформитьЗаднимЧислом.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbОформитьЗаднимЧислом_AsyncClick);
            // 
            // groupBox3
            // 
            this.groupBox3.AllowDrop = true;
            this.groupBox3.Controls.Add(this.nsgInput19);
            this.groupBox3.Controls.Add(this.nsgInput24);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.nsgInput20);
            this.groupBox3.Controls.Add(this.nsgInput23);
            this.groupBox3.Controls.Add(this.nsgInput21);
            this.groupBox3.Controls.Add(this.nsgInput22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Location = new System.Drawing.Point(240, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 266);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выезд";
            // 
            // nsgInput19
            // 
            this.nsgInput19.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput19.ConfigurationName = "";
            this.nsgInput19.DisableLeaveControlEvent = false;
            this.nsgInput19.FullName = "КомментарийВыезд";
            this.nsgInput19.FullTextSearch = false;
            this.nsgInput19.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput19.IsButton = false;
            this.nsgInput19.IsInitialized = true;
            this.nsgInput19.IsMultiline = true;
            this.nsgInput19.IsPassword = false;
            this.nsgInput19.Location = new System.Drawing.Point(102, 158);
            this.nsgInput19.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput19.Mask = "";
            this.nsgInput19.MetaDataName = "";
            this.nsgInput19.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput19.Name = "NsgInput";
            this.nsgInput19.ObjectImages = null;
            this.nsgInput19.ObjectIndex = null;
            this.nsgInput19.ObjectStrings = null;
            this.nsgInput19.Requsite = "КомментарийВыезд";
            this.nsgInput19.SearchFieldName = "";
            this.nsgInput19.ShowMultipleObjectInComboBox = false;
            this.nsgInput19.ShowRowCount = 10;
            this.nsgInput19.Size = new System.Drawing.Size(116, 98);
            this.nsgInput19.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput19.TabIndex = 32;
            this.nsgInput19.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // vmoЗаднимЧислом
            // 
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ДатаВъезда_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ДатаВыезда_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.Техника_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.НомерАвто_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ГрузНаВъезде_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ГрузНаВыезде_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ВодительВъезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ВодительВыезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.КППВъезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.КППВыезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.КомментарийВъезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.КомментарийВыезд_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.Columns.Collection.Add(this.ДатаСледующейЗаписи_vmoЗаднимЧислом);
            this.vmoЗаднимЧислом.IsActive = true;
            this.vmoЗаднимЧислом.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoЗаднимЧислом.MetaDataName = "";
            this.vmoЗаднимЧислом.FullName = "";
            // 
            // ДатаВъезда_vmoЗаднимЧислом
            // 
            this.ДатаВъезда_vmoЗаднимЧислом.Caption = "Дата въезда";
            this.ДатаВъезда_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаВъезда_vmoЗаднимЧислом.Name = "ДатаВъезда";
            this.ДатаВъезда_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаВъезда_vmoЗаднимЧислом.PropertyType = typeof(System.DateTime);
            this.ДатаВъезда_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ДатаВъезда_vmoЗаднимЧислом;
            this.ДатаВъезда_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаВыезда_vmoЗаднимЧислом
            // 
            this.ДатаВыезда_vmoЗаднимЧислом.Caption = "ДатаВыезда";
            this.ДатаВыезда_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаВыезда_vmoЗаднимЧислом.Name = "ДатаВыезда";
            this.ДатаВыезда_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаВыезда_vmoЗаднимЧислом.PropertyType = typeof(System.DateTime);
            this.ДатаВыезда_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ДатаВыезда_vmoЗаднимЧислом;
            this.ДатаВыезда_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoЗаднимЧислом
            // 
            this.Техника_vmoЗаднимЧислом.Caption = "Техника";
            this.Техника_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoЗаднимЧислом.Name = "Техника";
            this.Техника_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.Техника_vmoЗаднимЧислом;
            this.Техника_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерАвто_vmoЗаднимЧислом
            // 
            this.НомерАвто_vmoЗаднимЧислом.Caption = "НомерАвто";
            this.НомерАвто_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерАвто_vmoЗаднимЧислом.Name = "НомерАвто";
            this.НомерАвто_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерАвто_vmoЗаднимЧислом.PropertyType = typeof(string);
            this.НомерАвто_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.НомерАвто_vmoЗаднимЧислом;
            this.НомерАвто_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГрузНаВъезде_vmoЗаднимЧислом
            // 
            this.ГрузНаВъезде_vmoЗаднимЧислом.Caption = "ГрузНаВъезде";
            this.ГрузНаВъезде_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГрузНаВъезде_vmoЗаднимЧислом.Name = "ГрузНаВъезде";
            this.ГрузНаВъезде_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ГрузНаВъезде_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ГрузНаВъезде_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ГрузНаВъезде_vmoЗаднимЧислом;
            this.ГрузНаВъезде_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемГрузаНаВъезде_vmoЗаднимЧислом
            // 
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.CalcTotal = false;
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.Caption = "ОбъекмГрузаНаВъезде";
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.Name = "ОбъемГрузаНаВъезде";
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.PropertyType = typeof(decimal);
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом;
            this.ОбъемГрузаНаВъезде_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГрузНаВыезде_vmoЗаднимЧислом
            // 
            this.ГрузНаВыезде_vmoЗаднимЧислом.Caption = "ГрузНаВыезде";
            this.ГрузНаВыезде_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ГрузНаВыезде_vmoЗаднимЧислом.Name = "ГрузНаВыезде";
            this.ГрузНаВыезде_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ГрузНаВыезде_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ГрузНаВыезде_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ГрузНаВыезде_vmoЗаднимЧислом;
            this.ГрузНаВыезде_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемГрузаНаВыезде_vmoЗаднимЧислом
            // 
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.CalcTotal = false;
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.Caption = "ОбъемГрузаНаВыезде";
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.Name = "ОбъемГрузаНаВыезде";
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.PropertyType = typeof(decimal);
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом;
            this.ОбъемГрузаНаВыезде_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВодительВъезд_vmoЗаднимЧислом
            // 
            this.ВодительВъезд_vmoЗаднимЧислом.Caption = "ВодительВъезд";
            this.ВодительВъезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВодительВъезд_vmoЗаднимЧислом.Name = "ВодительВъезд";
            this.ВодительВъезд_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.ВодительВъезд_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.ВодительВъезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ВодительВъезд_vmoЗаднимЧислом;
            this.ВодительВъезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВодительВыезд_vmoЗаднимЧислом
            // 
            this.ВодительВыезд_vmoЗаднимЧислом.Caption = "ВодительВыезд";
            this.ВодительВыезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВодительВыезд_vmoЗаднимЧислом.Name = "ВодительВыезд";
            this.ВодительВыезд_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.ВодительВыезд_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.ВодительВыезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ВодительВыезд_vmoЗаднимЧислом;
            this.ВодительВыезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КППВъезд_vmoЗаднимЧислом
            // 
            this.КППВъезд_vmoЗаднимЧислом.Caption = "КППВъезд";
            this.КППВъезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КППВъезд_vmoЗаднимЧислом.Name = "КППВъезд";
            this.КППВъезд_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КППВъезд_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КППВъезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.КППВъезд_vmoЗаднимЧислом;
            this.КППВъезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КППВыезд_vmoЗаднимЧислом
            // 
            this.КППВыезд_vmoЗаднимЧислом.Caption = "КППВыезд";
            this.КППВыезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КППВыезд_vmoЗаднимЧислом.Name = "КППВыезд";
            this.КППВыезд_vmoЗаднимЧислом.NSGType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КППВыезд_vmoЗаднимЧислом.PropertyType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КППВыезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.КППВыезд_vmoЗаднимЧислом;
            this.КППВыезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КомментарийВъезд_vmoЗаднимЧислом
            // 
            this.КомментарийВъезд_vmoЗаднимЧислом.Caption = "КомментарийВъезд";
            this.КомментарийВъезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КомментарийВъезд_vmoЗаднимЧислом.Name = "КомментарийВъезд";
            this.КомментарийВъезд_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КомментарийВъезд_vmoЗаднимЧислом.PropertyType = typeof(string);
            this.КомментарийВъезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.КомментарийВъезд_vmoЗаднимЧислом;
            this.КомментарийВъезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КомментарийВыезд_vmoЗаднимЧислом
            // 
            this.КомментарийВыезд_vmoЗаднимЧислом.Caption = "КомментарийВыезд";
            this.КомментарийВыезд_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КомментарийВыезд_vmoЗаднимЧислом.Name = "КомментарийВыезд";
            this.КомментарийВыезд_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КомментарийВыезд_vmoЗаднимЧислом.PropertyType = typeof(string);
            this.КомментарийВыезд_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.КомментарийВыезд_vmoЗаднимЧислом;
            this.КомментарийВыезд_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаПредыдущейЗаписи_vmoЗаднимЧислом
            // 
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Caption = "ДатаПредыдущейЗаписи";
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Name = "ДатаПредыдущейЗаписи";
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.PropertyType = typeof(System.DateTime);
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом;
            this.ДатаПредыдущейЗаписи_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаСледующейЗаписи_vmoЗаднимЧислом
            // 
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.Caption = "ДатаСледующейЗаписи";
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.Name = "ДатаСледующейЗаписи";
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.PropertyType = typeof(System.DateTime);
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.SearchCondition.OwnerComponent = this.ДатаСледующейЗаписи_vmoЗаднимЧислом;
            this.ДатаСледующейЗаписи_vmoЗаднимЧислом.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput24
            // 
            this.nsgInput24.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput24.ConfigurationName = "";
            this.nsgInput24.DisableLeaveControlEvent = false;
            this.nsgInput24.FullName = "ВодительВыезд";
            this.nsgInput24.FullTextSearch = false;
            this.nsgInput24.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput24.IsButton = false;
            this.nsgInput24.IsInitialized = true;
            this.nsgInput24.IsPassword = false;
            this.nsgInput24.Location = new System.Drawing.Point(102, 67);
            this.nsgInput24.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput24.Mask = "";
            this.nsgInput24.MetaDataName = "";
            this.nsgInput24.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput24.Name = "NsgInput";
            this.nsgInput24.ObjectImages = null;
            this.nsgInput24.ObjectIndex = null;
            this.nsgInput24.ObjectStrings = null;
            this.nsgInput24.Requsite = "ВодительВыезд";
            this.nsgInput24.SearchFieldName = "";
            this.nsgInput24.ShowMultipleObjectInComboBox = false;
            this.nsgInput24.ShowRowCount = 10;
            this.nsgInput24.Size = new System.Drawing.Size(116, 20);
            this.nsgInput24.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput24.TabIndex = 37;
            this.nsgInput24.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 165);
            this.label21.Name = "label7";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Комментарий";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 104);
            this.label26.Name = "label7";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 38;
            this.label26.Text = "Груз";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 16);
            this.label22.Name = "label7";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "Дата";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 74);
            this.label25.Name = "label7";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "Водитель";
            // 
            // nsgInput20
            // 
            this.nsgInput20.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput20.ConfigurationName = "";
            this.nsgInput20.DisableLeaveControlEvent = false;
            this.nsgInput20.FullName = "ДатаВыезда";
            this.nsgInput20.FullTextSearch = false;
            this.nsgInput20.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput20.IsButton = false;
            this.nsgInput20.IsInitialized = true;
            this.nsgInput20.IsPassword = false;
            this.nsgInput20.Location = new System.Drawing.Point(102, 9);
            this.nsgInput20.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput20.Mask = "";
            this.nsgInput20.MetaDataName = "";
            this.nsgInput20.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput20.Name = "NsgInput";
            this.nsgInput20.ObjectImages = null;
            this.nsgInput20.ObjectIndex = null;
            this.nsgInput20.ObjectStrings = null;
            this.nsgInput20.Requsite = "ДатаВыезда";
            this.nsgInput20.SearchFieldName = "";
            this.nsgInput20.ShowMultipleObjectInComboBox = false;
            this.nsgInput20.ShowRowCount = 10;
            this.nsgInput20.Size = new System.Drawing.Size(116, 20);
            this.nsgInput20.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput20.TabIndex = 33;
            this.nsgInput20.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput20.Selected += new System.EventHandler(this.nsgInput20_Selected);
            // 
            // nsgInput23
            // 
            this.nsgInput23.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput23.ConfigurationName = "";
            this.nsgInput23.DisableLeaveControlEvent = false;
            this.nsgInput23.FullName = "ГрузНаВыезде";
            this.nsgInput23.FullTextSearch = false;
            this.nsgInput23.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput23.IsButton = false;
            this.nsgInput23.IsInitialized = true;
            this.nsgInput23.IsPassword = false;
            this.nsgInput23.Location = new System.Drawing.Point(102, 97);
            this.nsgInput23.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput23.Mask = "";
            this.nsgInput23.MetaDataName = "";
            this.nsgInput23.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput23.Name = "NsgInput";
            this.nsgInput23.ObjectImages = null;
            this.nsgInput23.ObjectIndex = null;
            this.nsgInput23.ObjectStrings = null;
            this.nsgInput23.Requsite = "ГрузНаВыезде";
            this.nsgInput23.SearchFieldName = "";
            this.nsgInput23.ShowMultipleObjectInComboBox = false;
            this.nsgInput23.ShowRowCount = 10;
            this.nsgInput23.Size = new System.Drawing.Size(116, 20);
            this.nsgInput23.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput23.TabIndex = 39;
            this.nsgInput23.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput21
            // 
            this.nsgInput21.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput21.ConfigurationName = "";
            this.nsgInput21.DisableLeaveControlEvent = false;
            this.nsgInput21.FullName = "ОбъемГрузаНаВыезде";
            this.nsgInput21.FullTextSearch = false;
            this.nsgInput21.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput21.IsButton = false;
            this.nsgInput21.IsInitialized = true;
            this.nsgInput21.IsPassword = false;
            this.nsgInput21.Location = new System.Drawing.Point(102, 128);
            this.nsgInput21.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput21.Mask = "";
            this.nsgInput21.MetaDataName = "";
            this.nsgInput21.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput21.Name = "NsgInput";
            this.nsgInput21.ObjectImages = null;
            this.nsgInput21.ObjectIndex = null;
            this.nsgInput21.ObjectStrings = null;
            this.nsgInput21.Requsite = "ОбъемГрузаНаВыезде";
            this.nsgInput21.SearchFieldName = "";
            this.nsgInput21.ShowMultipleObjectInComboBox = false;
            this.nsgInput21.ShowRowCount = 10;
            this.nsgInput21.Size = new System.Drawing.Size(116, 20);
            this.nsgInput21.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput21.TabIndex = 41;
            this.nsgInput21.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput22
            // 
            this.nsgInput22.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput22.ConfigurationName = "";
            this.nsgInput22.DisableLeaveControlEvent = false;
            this.nsgInput22.FullName = "КППВыезд";
            this.nsgInput22.FullTextSearch = false;
            this.nsgInput22.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput22.IsButton = false;
            this.nsgInput22.IsInitialized = true;
            this.nsgInput22.IsPassword = false;
            this.nsgInput22.Location = new System.Drawing.Point(102, 38);
            this.nsgInput22.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput22.Mask = "";
            this.nsgInput22.MetaDataName = "";
            this.nsgInput22.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput22.Name = "NsgInput";
            this.nsgInput22.ObjectImages = null;
            this.nsgInput22.ObjectIndex = null;
            this.nsgInput22.ObjectStrings = null;
            this.nsgInput22.Requsite = "КППВыезд";
            this.nsgInput22.SearchFieldName = "";
            this.nsgInput22.ShowMultipleObjectInComboBox = false;
            this.nsgInput22.ShowRowCount = 10;
            this.nsgInput22.Size = new System.Drawing.Size(116, 20);
            this.nsgInput22.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput22.TabIndex = 35;
            this.nsgInput22.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 45);
            this.label23.Name = "label7";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 34;
            this.label23.Text = "КПП";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 135);
            this.label24.Name = "label7";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Объем";
            // 
            // groupBox2
            // 
            this.groupBox2.AllowDrop = true;
            this.groupBox2.Controls.Add(this.nsgInput14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nsgInput13);
            this.groupBox2.Controls.Add(this.nsgInput18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.nsgInput15);
            this.groupBox2.Controls.Add(this.nsgInput17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.nsgInput16);
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 266);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Въезд";
            // 
            // nsgInput14
            // 
            this.nsgInput14.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput14.ConfigurationName = "";
            this.nsgInput14.DisableLeaveControlEvent = false;
            this.nsgInput14.FullName = "КомментарийВъезд";
            this.nsgInput14.FullTextSearch = false;
            this.nsgInput14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput14.IsButton = false;
            this.nsgInput14.IsInitialized = true;
            this.nsgInput14.IsMultiline = true;
            this.nsgInput14.IsPassword = false;
            this.nsgInput14.Location = new System.Drawing.Point(102, 158);
            this.nsgInput14.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput14.Mask = "";
            this.nsgInput14.MetaDataName = "";
            this.nsgInput14.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput14.Name = "NsgInput";
            this.nsgInput14.ObjectImages = null;
            this.nsgInput14.ObjectIndex = null;
            this.nsgInput14.ObjectStrings = null;
            this.nsgInput14.Requsite = "КомментарийВъезд";
            this.nsgInput14.SearchFieldName = "";
            this.nsgInput14.ShowMultipleObjectInComboBox = false;
            this.nsgInput14.ShowRowCount = 10;
            this.nsgInput14.Size = new System.Drawing.Size(116, 98);
            this.nsgInput14.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput14.TabIndex = 31;
            this.nsgInput14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 165);
            this.label16.Name = "label7";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Комментарий";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label7";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Дата";
            // 
            // nsgInput13
            // 
            this.nsgInput13.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput13.ConfigurationName = "";
            this.nsgInput13.DisableLeaveControlEvent = false;
            this.nsgInput13.FullName = "Дата въезда";
            this.nsgInput13.FullTextSearch = false;
            this.nsgInput13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput13.IsButton = false;
            this.nsgInput13.IsInitialized = true;
            this.nsgInput13.IsPassword = false;
            this.nsgInput13.Location = new System.Drawing.Point(102, 9);
            this.nsgInput13.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput13.Mask = "";
            this.nsgInput13.MetaDataName = "";
            this.nsgInput13.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput13.Name = "NsgInput";
            this.nsgInput13.ObjectImages = null;
            this.nsgInput13.ObjectIndex = null;
            this.nsgInput13.ObjectStrings = null;
            this.nsgInput13.Requsite = "Дата въезда";
            this.nsgInput13.SearchFieldName = "";
            this.nsgInput13.ShowMultipleObjectInComboBox = false;
            this.nsgInput13.ShowRowCount = 10;
            this.nsgInput13.Size = new System.Drawing.Size(116, 20);
            this.nsgInput13.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput13.TabIndex = 19;
            this.nsgInput13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput13.Selected += new System.EventHandler(this.nsgInput13_Selected);
            // 
            // nsgInput18
            // 
            this.nsgInput18.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput18.ConfigurationName = "";
            this.nsgInput18.DisableLeaveControlEvent = false;
            this.nsgInput18.FullName = "ОбъекмГрузаНаВъезде";
            this.nsgInput18.FullTextSearch = false;
            this.nsgInput18.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput18.IsButton = false;
            this.nsgInput18.IsInitialized = true;
            this.nsgInput18.IsPassword = false;
            this.nsgInput18.Location = new System.Drawing.Point(102, 128);
            this.nsgInput18.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput18.Mask = "";
            this.nsgInput18.MetaDataName = "";
            this.nsgInput18.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput18.Name = "NsgInput";
            this.nsgInput18.ObjectImages = null;
            this.nsgInput18.ObjectIndex = null;
            this.nsgInput18.ObjectStrings = null;
            this.nsgInput18.Requsite = "ОбъекмГрузаНаВъезде";
            this.nsgInput18.SearchFieldName = "";
            this.nsgInput18.ShowMultipleObjectInComboBox = false;
            this.nsgInput18.ShowRowCount = 10;
            this.nsgInput18.Size = new System.Drawing.Size(116, 20);
            this.nsgInput18.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput18.TabIndex = 29;
            this.nsgInput18.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Name = "label7";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "КПП";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 135);
            this.label20.Name = "label7";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Объем";
            // 
            // nsgInput15
            // 
            this.nsgInput15.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput15.ConfigurationName = "";
            this.nsgInput15.DisableLeaveControlEvent = false;
            this.nsgInput15.FullName = "КППВъезд";
            this.nsgInput15.FullTextSearch = false;
            this.nsgInput15.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput15.IsButton = false;
            this.nsgInput15.IsInitialized = true;
            this.nsgInput15.IsPassword = false;
            this.nsgInput15.Location = new System.Drawing.Point(102, 38);
            this.nsgInput15.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput15.Mask = "";
            this.nsgInput15.MetaDataName = "";
            this.nsgInput15.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput15.Name = "NsgInput";
            this.nsgInput15.ObjectImages = null;
            this.nsgInput15.ObjectIndex = null;
            this.nsgInput15.ObjectStrings = null;
            this.nsgInput15.Requsite = "КППВъезд";
            this.nsgInput15.SearchFieldName = "";
            this.nsgInput15.ShowMultipleObjectInComboBox = false;
            this.nsgInput15.ShowRowCount = 10;
            this.nsgInput15.Size = new System.Drawing.Size(116, 20);
            this.nsgInput15.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput15.TabIndex = 23;
            this.nsgInput15.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput17
            // 
            this.nsgInput17.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput17.ConfigurationName = "";
            this.nsgInput17.DisableLeaveControlEvent = false;
            this.nsgInput17.FullName = "ГрузНаВъезде";
            this.nsgInput17.FullTextSearch = false;
            this.nsgInput17.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput17.IsButton = false;
            this.nsgInput17.IsInitialized = true;
            this.nsgInput17.IsPassword = false;
            this.nsgInput17.Location = new System.Drawing.Point(102, 97);
            this.nsgInput17.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput17.Mask = "";
            this.nsgInput17.MetaDataName = "";
            this.nsgInput17.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput17.Name = "NsgInput";
            this.nsgInput17.ObjectImages = null;
            this.nsgInput17.ObjectIndex = null;
            this.nsgInput17.ObjectStrings = null;
            this.nsgInput17.Requsite = "ГрузНаВъезде";
            this.nsgInput17.SearchFieldName = "";
            this.nsgInput17.ShowMultipleObjectInComboBox = false;
            this.nsgInput17.ShowRowCount = 10;
            this.nsgInput17.Size = new System.Drawing.Size(116, 20);
            this.nsgInput17.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput17.TabIndex = 27;
            this.nsgInput17.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 74);
            this.label18.Name = "label7";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Водитель";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 104);
            this.label19.Name = "label7";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Груз";
            // 
            // nsgInput16
            // 
            this.nsgInput16.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput16.ConfigurationName = "";
            this.nsgInput16.DisableLeaveControlEvent = false;
            this.nsgInput16.FullName = "ВодительВъезд";
            this.nsgInput16.FullTextSearch = false;
            this.nsgInput16.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput16.IsButton = false;
            this.nsgInput16.IsInitialized = true;
            this.nsgInput16.IsPassword = false;
            this.nsgInput16.Location = new System.Drawing.Point(102, 67);
            this.nsgInput16.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput16.Mask = "";
            this.nsgInput16.MetaDataName = "";
            this.nsgInput16.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput16.Name = "NsgInput";
            this.nsgInput16.ObjectImages = null;
            this.nsgInput16.ObjectIndex = null;
            this.nsgInput16.ObjectStrings = null;
            this.nsgInput16.Requsite = "ВодительВъезд";
            this.nsgInput16.SearchFieldName = "";
            this.nsgInput16.ShowMultipleObjectInComboBox = false;
            this.nsgInput16.ShowRowCount = 10;
            this.nsgInput16.Size = new System.Drawing.Size(116, 20);
            this.nsgInput16.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput16.TabIndex = 25;
            this.nsgInput16.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput12
            // 
            this.nsgInput12.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput12.ConfigurationName = "";
            this.nsgInput12.DisableLeaveControlEvent = false;
            this.nsgInput12.FullName = "НомерАвто";
            this.nsgInput12.FullTextSearch = false;
            this.nsgInput12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput12.IsButton = false;
            this.nsgInput12.IsInitialized = true;
            this.nsgInput12.IsPassword = false;
            this.nsgInput12.Location = new System.Drawing.Point(102, 40);
            this.nsgInput12.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput12.Mask = "";
            this.nsgInput12.MetaDataName = "";
            this.nsgInput12.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput12.Name = "NsgInput";
            this.nsgInput12.ObjectImages = null;
            this.nsgInput12.ObjectIndex = null;
            this.nsgInput12.ObjectStrings = null;
            this.nsgInput12.Requsite = "НомерАвто";
            this.nsgInput12.SearchFieldName = "";
            this.nsgInput12.ShowMultipleObjectInComboBox = false;
            this.nsgInput12.ShowRowCount = 10;
            this.nsgInput12.Size = new System.Drawing.Size(116, 20);
            this.nsgInput12.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput12.TabIndex = 17;
            this.nsgInput12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label7";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Номер авто";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "Техника";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(102, 10);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "Техника";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(218, 20);
            this.nsgInput11.SourceObject = this.vmoЗаднимЧислом;
            this.nsgInput11.TabIndex = 15;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label7";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Техника";
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
            // vmoСостояниеВъездовВыездов
            // 
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.ВидГруза_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.ДатаДокумента_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.КПП_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.Объект_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.ОбъемГруза_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.Техника_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.Columns.Collection.Add(this.НаправлениеДвижения_vmoСостояниеВъездовВыездов);
            this.vmoСостояниеВъездовВыездов.IsActive = true;
            this.vmoСостояниеВъездовВыездов.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoСостояниеВъездовВыездов.MetaDataName = "";
            this.vmoСостояниеВъездовВыездов.FullName = "";
            // 
            // ВидГруза_vmoСостояниеВъездовВыездов
            // 
            this.ВидГруза_vmoСостояниеВъездовВыездов.Caption = "ВидГруза";
            this.ВидГруза_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ВидГруза_vmoСостояниеВъездовВыездов.Name = "ВидГруза";
            this.ВидГруза_vmoСостояниеВъездовВыездов.NSGType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ВидГруза_vmoСостояниеВъездовВыездов.PropertyType = typeof(TechControl.Метаданные.Грузы.ВидыГрузов);
            this.ВидГруза_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.ВидГруза_vmoСостояниеВъездовВыездов;
            this.ВидГруза_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаДокумента_vmoСостояниеВъездовВыездов
            // 
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.Caption = "ДатаДокумента";
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.Name = "ДатаДокумента";
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.PropertyType = typeof(System.DateTime);
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.ДатаДокумента_vmoСостояниеВъездовВыездов;
            this.ДатаДокумента_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КПП_vmoСостояниеВъездовВыездов
            // 
            this.КПП_vmoСостояниеВъездовВыездов.Caption = "КПП";
            this.КПП_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КПП_vmoСостояниеВъездовВыездов.Name = "КПП";
            this.КПП_vmoСостояниеВъездовВыездов.NSGType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КПП_vmoСостояниеВъездовВыездов.PropertyType = typeof(TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты);
            this.КПП_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.КПП_vmoСостояниеВъездовВыездов;
            this.КПП_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НахождениеНаОбъекте_vmoСостояниеВъездовВыездов
            // 
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.CalcTotal = false;
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.Caption = "НахождениеНаОбъекте";
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.Name = "НахождениеНаОбъекте";
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.PropertyType = typeof(long);
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов;
            this.НахождениеНаОбъекте_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoСостояниеВъездовВыездов
            // 
            this.Объект_vmoСостояниеВъездовВыездов.Caption = "Объект";
            this.Объект_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoСостояниеВъездовВыездов.Name = "Объект";
            this.Объект_vmoСостояниеВъездовВыездов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСостояниеВъездовВыездов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.Объект_vmoСостояниеВъездовВыездов;
            this.Объект_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемГруза_vmoСостояниеВъездовВыездов
            // 
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.CalcTotal = false;
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.Caption = "ОбъемГруза";
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.Name = "ОбъемГруза";
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.PropertyType = typeof(decimal);
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.ОбъемГруза_vmoСостояниеВъездовВыездов;
            this.ОбъемГруза_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoСостояниеВъездовВыездов
            // 
            this.Техника_vmoСостояниеВъездовВыездов.Caption = "Техника";
            this.Техника_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoСостояниеВъездовВыездов.Name = "Техника";
            this.Техника_vmoСостояниеВъездовВыездов.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСостояниеВъездовВыездов.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.Техника_vmoСостояниеВъездовВыездов;
            this.Техника_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn7.AllowFilter = true;
            nsgIGridColumn7.AllowGroupSelect = false;
            nsgIGridColumn7.AllowResize = true;
            nsgIGridColumn7.AutoResize = true;
            nsgIGridColumn7.Caption = "";
            nsgIGridColumn7.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "ДатаДокумента";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn8.Name = "Техника";
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
            nsgIGridColumn9.Name = "КПП";
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
            nsgIGridColumn10.Name = "ВидГруза";
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
            nsgIGridColumn11.Name = "НахождениеНаОбъекте";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn12.Name = "Объект";
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
            nsgIGridColumn13.Name = "ОбъемГруза";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn13.UseAsHeaderImage = false;
            nsgIGridColumn13.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(471, 63);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(654, 266);
            this.nsgIGrid3.SourceObject = this.vmoСостояниеВъездовВыездов;
            this.nsgIGrid3.TabIndex = 33;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid3.BeforeAction += new NsgSoft.Forms.NsgIGrid.NsgIGridCellActionEventHandler(this.nsgIGrid3_BeforeAction);
            // 
            // НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов
            // 
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.Caption = "НаправлениеДвиженияСтрока";
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.Name = "НаправлениеДвиженияСтрока";
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.PropertyType = typeof(string);
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов;
            this.НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(471, 30);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(191, 27);
            this.nsgPeriodPicker1.TabIndex = 34;
            // 
            // НаправлениеДвижения_vmoСостояниеВъездовВыездов
            // 
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.Caption = "НаправлениеДвижения";
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.Name = "НаправлениеДвижения";
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.NSGType = typeof(TechControl.Метаданные.Сервис.ВидыДвижений);
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.PropertyType = typeof(TechControl.Метаданные.Сервис.ВидыДвижений);
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.SearchCondition.OwnerComponent = this.НаправлениеДвижения_vmoСостояниеВъездовВыездов;
            this.НаправлениеДвижения_vmoСостояниеВъездовВыездов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.tpЗаднимЧислом.ResumeLayout(false);
            this.tpЗаднимЧислом.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbОформитьЗаднимЧислом)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаднимЧислом)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput22)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСостояниеВъездовВыездов)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
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
        private NsgIGrid nsgIGrid2;
        private System.Windows.Forms.TabPage tpЗаднимЧислом;
        protected System.Windows.Forms.CheckBox cbПоказатьВсе;
        protected NsgColumnDescriptor.DateTime ДатаВъезда_vmoЗаднимЧислом;
        protected NsgColumnDescriptor.String НомерАвто_vmoЗаднимЧислом;
        private NsgVisualMultipleObject vmoФотографии;
        private NsgVisualMultipleObject vmoСостояние;
        protected NsgColumnDescriptor.DateTime ДатаВыезда_vmoЗаднимЧислом;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoЗаднимЧислом;
        protected ВидыГрузов.ColumnDescriptor ГрузНаВъезде_vmoЗаднимЧислом;
        protected NsgColumnDescriptor.Decimal ОбъемГрузаНаВъезде_vmoЗаднимЧислом;
        protected NsgColumnDescriptor.Decimal ОбъемГрузаНаВыезде_vmoЗаднимЧислом;
        protected Мониторинг.ФизЛица.ColumnDescriptor ВодительВъезд_vmoЗаднимЧислом;
        protected Мониторинг.ФизЛица.ColumnDescriptor ВодительВыезд_vmoЗаднимЧислом;
        protected КонтрольноПропускныеПункты.ColumnDescriptor КППВъезд_vmoЗаднимЧислом;
        protected КонтрольноПропускныеПункты.ColumnDescriptor КППВыезд_vmoЗаднимЧислом;
        protected NsgColumnDescriptor.String КомментарийВъезд_vmoЗаднимЧислом;
        protected NsgColumnDescriptor.String КомментарийВыезд_vmoЗаднимЧислом;
        protected NsgInput nsgInput13;
        protected System.Windows.Forms.Label label15;
        protected NsgInput nsgInput12;
        protected System.Windows.Forms.Label label14;
        protected NsgInput nsgInput11;
        protected System.Windows.Forms.Label label13;
        protected NsgInput nsgInput16;
        protected System.Windows.Forms.Label label18;
        protected NsgInput nsgInput15;
        protected System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        protected NsgInput nsgInput24;
        protected System.Windows.Forms.Label label21;
        protected System.Windows.Forms.Label label26;
        protected System.Windows.Forms.Label label22;
        protected System.Windows.Forms.Label label25;
        protected NsgInput nsgInput20;
        protected NsgInput nsgInput23;
        protected NsgInput nsgInput21;
        protected NsgInput nsgInput22;
        protected System.Windows.Forms.Label label23;
        protected System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        protected NsgInput nsgInput14;
        protected System.Windows.Forms.Label label16;
        protected NsgInput nsgInput18;
        protected System.Windows.Forms.Label label20;
        protected NsgInput nsgInput17;
        protected System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabControl tabControl1;
        private NsgVisualMultipleObject vmoЗаднимЧислом;
        protected NsgInput nsgInput19;
        protected ВидыГрузов.ColumnDescriptor ГрузНаВыезде_vmoЗаднимЧислом;
        protected NsgSoft.Design.NsgButton nbОформитьЗаднимЧислом;
        protected NsgColumnDescriptor.DateTime ДатаПредыдущейЗаписи_vmoЗаднимЧислом;
        private NsgColumnDescriptor.DateTime ДатаСледующейЗаписи_vmoЗаднимЧислом;
        private NsgBackgroundWorker nbwЗаполнениеСостояния;
        protected NsgVisualMultipleObject vmoСостояниеВъездовВыездов;
        protected ВидыГрузов.ColumnDescriptor ВидГруза_vmoСостояниеВъездовВыездов;
        protected NsgColumnDescriptor.DateTime ДатаДокумента_vmoСостояниеВъездовВыездов;
        protected КонтрольноПропускныеПункты.ColumnDescriptor КПП_vmoСостояниеВъездовВыездов;
        protected NsgColumnDescriptor.Int64 НахождениеНаОбъекте_vmoСостояниеВъездовВыездов;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoСостояниеВъездовВыездов;
        protected NsgColumnDescriptor.Decimal ОбъемГруза_vmoСостояниеВъездовВыездов;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoСостояниеВъездовВыездов;
        protected NsgIGrid nsgIGrid3;
        protected NsgColumnDescriptor.String НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Сервис.ВидыДвижений.ColumnDescriptor НаправлениеДвижения_vmoСостояниеВъездовВыездов;
    }
}