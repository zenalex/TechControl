using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ФормированиеСменыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ФормированиеСменыФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn15 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.gridТехника = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Техника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.СтатусТехники = new TechControl.Метаданные.Мониторинг.СтатусТехники.ColumnDescriptor();
            this.Время = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Тариф_vmoТаблица = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.НомерСмены = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Длительность = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.gridПерсонал = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаПерсонал = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.СтатусСотрудника = new TechControl.Метаданные.Мониторинг.СтатусСотрудника.ColumnDescriptor();
            this.Время_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.НомерСмены_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Сотрудник_vmoТаблицаПерсонал = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Тариф_vmoТаблицаПерсонал = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Длительность_vmoТаблицаПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel1 = new NsgSoft.Forms.NsgLabel();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel4 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel5 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel6 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel3 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.bЗаполнить = new NsgSoft.Design.NsgButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.Идентификатор = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ПрефиксКода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.НомерДокумента = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаДокумента = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Индекс = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДокументОснование = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.Комментарий = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента = new TechControl.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.Таблица = new TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблица.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Ответственный = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Тариф = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.ТаблицаПерсонал = new TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблицаПерсонал.ColumnDescriptor();
            this.ЭтоИтоговыйДокумент = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            ((System.ComponentModel.ISupportInitialize)(this.nsgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgToolStrip2)).BeginInit();
            this.nsgToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgHandling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgSave)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButtonBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMovementsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsersActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInListButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridТехника)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridПерсонал)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаПерсонал)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнить)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            this.SuspendLayout();
            // 
            // nsgEdit
            // 
            this.nsgEdit.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgEdit.DisabledImageKey = "disabled_EditElement";
            this.nsgEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgEdit.ImageKey = "EditElement";
            this.nsgEdit.Location = new System.Drawing.Point(890, 1);
            this.nsgEdit.Name = "nsgEdit";
            this.nsgEdit.NsgToolStrip = this.nsgToolStrip2;
            this.nsgEdit.Size = new System.Drawing.Size(116, 26);
            this.nsgEdit.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgEdit.TabIndex = 2;
            this.nsgEdit.Text = "Редактировать";
            this.nsgEdit.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgClose
            // 
            this.nsgClose.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgClose.DisabledImageKey = "disabled_Exit";
            this.nsgClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgClose.ImageKey = "Exit";
            this.nsgClose.Location = new System.Drawing.Point(1006, 1);
            this.nsgClose.Name = "nsgClose";
            this.nsgClose.NsgToolStrip = this.nsgToolStrip2;
            this.nsgClose.Size = new System.Drawing.Size(78, 26);
            this.nsgClose.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgClose.TabIndex = 0;
            this.nsgClose.Text = "Закрыть";
            this.nsgClose.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgToolStrip2
            // 
            this.nsgToolStrip2.AllowDrop = true;
            this.nsgToolStrip2.CausesValidation = false;
            this.nsgToolStrip2.Controls.Add(this.documentStructure);
            this.nsgToolStrip2.Controls.Add(this.showInListButton);
            this.nsgToolStrip2.Controls.Add(this.btnUsersActions);
            this.nsgToolStrip2.Controls.Add(this.documentMovementsButton);
            this.nsgToolStrip2.Controls.Add(this.documentButton);
            this.nsgToolStrip2.Controls.Add(this.nsgButtonBasic);
            this.nsgToolStrip2.Controls.Add(this.printButton);
            this.nsgToolStrip2.Controls.Add(this.nsgAll);
            this.nsgToolStrip2.Controls.Add(this.nsgHandling);
            this.nsgToolStrip2.Controls.Add(this.nsgSave);
            this.nsgToolStrip2.Controls.Add(this.nsgEdit);
            this.nsgToolStrip2.Controls.Add(this.nsgClose);
            this.nsgToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nsgToolStrip2.Location = new System.Drawing.Point(0, 2);
            this.nsgToolStrip2.Name = "nsgToolStrip2";
            this.nsgToolStrip2.Padding = new System.Windows.Forms.Padding(1);
            this.nsgToolStrip2.Size = new System.Drawing.Size(1085, 28);
            this.nsgToolStrip2.TabIndex = 1;
            this.nsgToolStrip2.TabStop = false;
            this.nsgToolStrip2.Text = "nsgToolStrip2";
            // 
            // nsgAll
            // 
            this.nsgAll.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgAll.Location = new System.Drawing.Point(620, 1);
            this.nsgAll.Name = "nsgAll";
            this.nsgAll.NsgToolStrip = this.nsgToolStrip2;
            this.nsgAll.Size = new System.Drawing.Size(95, 26);
            this.nsgAll.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgAll.TabIndex = 10;
            this.nsgAll.Text = "Выполнить всё";
            this.nsgAll.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgHandling
            // 
            this.nsgHandling.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgHandling.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgHandling.DisabledImageKey = "disabled_Handle";
            this.nsgHandling.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgHandling.ImageKey = "Handle";
            this.nsgHandling.Location = new System.Drawing.Point(715, 1);
            this.nsgHandling.Name = "nsgHandling";
            this.nsgHandling.NsgToolStrip = this.nsgToolStrip2;
            this.nsgHandling.Size = new System.Drawing.Size(84, 26);
            this.nsgHandling.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgHandling.TabIndex = 9;
            this.nsgHandling.Text = "Провести";
            this.nsgHandling.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgSave
            // 
            this.nsgSave.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgSave.DisabledImageKey = "disabled_Save";
            this.nsgSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgSave.ImageKey = "Save";
            this.nsgSave.Location = new System.Drawing.Point(799, 1);
            this.nsgSave.Name = "nsgSave";
            this.nsgSave.NsgToolStrip = this.nsgToolStrip2;
            this.nsgSave.Size = new System.Drawing.Size(91, 26);
            this.nsgSave.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgSave.TabIndex = 5;
            this.nsgSave.Text = "Сохранить";
            this.nsgSave.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.AllowDrop = true;
            this.panelButtons.Controls.Add(this.nsgToolStrip2);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 337);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1085, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(620, 1);
            this.nsgButtonBasic.Name = "nsgButtonBasic";
            this.nsgButtonBasic.Size = new System.Drawing.Size(0, 26);
            this.nsgButtonBasic.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButtonBasic.TabIndex = 12;
            this.nsgButtonBasic.Text = "Ввод на основании";
            this.nsgButtonBasic.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // documentButton
            // 
            this.documentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.documentButton.ButtonEnabled = true;
            this.documentButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("documentButton.ButtonImage")));
            this.documentButton.ButtonText = "";
            this.documentButton.DefaultCaption = "Действие";
            this.documentButton.DefaultImagekey = "";
            this.documentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentButton.Location = new System.Drawing.Point(21, 1);
            this.documentButton.Name = "documentButton";
            this.documentButton.ShowImage = false;
            this.documentButton.ShowText = false;
            this.documentButton.Size = new System.Drawing.Size(147, 26);
            this.documentButton.TabIndex = 13;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Кнопка";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(1, 1);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 26);
            this.printButton.TabIndex = 11;
            // 
            // documentMovementsButton
            // 
            this.documentMovementsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.documentMovementsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentMovementsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.documentMovementsButton.Container = this.documentButton;
            this.documentMovementsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentMovementsButton.Location = new System.Drawing.Point(168, 1);
            this.documentMovementsButton.Name = "documentMovementsButton";
            this.documentMovementsButton.Size = new System.Drawing.Size(68, 26);
            this.documentMovementsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.documentMovementsButton.TabIndex = 14;
            this.documentMovementsButton.Text = "Движения документа";
            this.documentMovementsButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsersActions
            // 
            this.btnUsersActions.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUsersActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsersActions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsersActions.Container = this.documentButton;
            this.btnUsersActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsersActions.Location = new System.Drawing.Point(236, 1);
            this.btnUsersActions.Name = "btnUsersActions";
            this.btnUsersActions.Size = new System.Drawing.Size(68, 26);
            this.btnUsersActions.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnUsersActions.TabIndex = 15;
            this.btnUsersActions.Text = "История Изменений";
            this.btnUsersActions.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showInListButton
            // 
            this.showInListButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showInListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showInListButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showInListButton.Container = this.documentButton;
            this.showInListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.showInListButton.Location = new System.Drawing.Point(304, 1);
            this.showInListButton.Name = "showInListButton";
            this.showInListButton.Size = new System.Drawing.Size(68, 26);
            this.showInListButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.showInListButton.TabIndex = 16;
            this.showInListButton.Text = "Показать в списке";
            this.showInListButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.SystemColors.Window;
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comment.ConfigurationName = "TechControl";
            this.Comment.DisableLeaveControlEvent = false;
            this.Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment.FullName = "Мониторинг.ФормированиеСмены.Идентификатор";
            this.Comment.FullTextSearch = false;
            this.Comment.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.Comment.IsButton = false;
            this.Comment.IsInitialized = true;
            this.Comment.IsPassword = false;
            this.Comment.Location = new System.Drawing.Point(0, 0);
            this.Comment.Margin = new System.Windows.Forms.Padding(0);
            this.Comment.Mask = "";
            this.Comment.MetaDataName = "Метаданные";
            this.Comment.MinimumSize = new System.Drawing.Size(4, 20);
            this.Comment.Name = "NsgInput";
            this.Comment.ObjectImages = null;
            this.Comment.ObjectIndex = null;
            this.Comment.ObjectStrings = null;
            this.Comment.Requsite = "Идентификатор";
            this.Comment.SearchFieldName = "";
            this.Comment.ShowMultipleObjectInComboBox = false;
            this.Comment.ShowRowCount = 10;
            this.Comment.Size = new System.Drawing.Size(1085, 23);
            this.Comment.SourceObject = this.nsgVisualMultipleObject;
            this.Comment.TabIndex = 0;
            this.Comment.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // documentStructure
            // 
            this.documentStructure.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.documentStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentStructure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.documentStructure.Container = this.documentButton;
            this.documentStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentStructure.Location = new System.Drawing.Point(372, 1);
            this.documentStructure.Name = "documentStructure";
            this.documentStructure.Size = new System.Drawing.Size(75, 26);
            this.documentStructure.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.documentStructure.TabIndex = 17;
            this.documentStructure.Text = "Структура документов";
            this.documentStructure.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Идентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Автоинкремент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Индекс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДокументОснование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Комментарий);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Таблица);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Ответственный);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Тариф);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаПерсонал);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЭтоИтоговыйДокумент);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.ФормированиеСмены";
            // 
            // gridТехника
            // 
            this.gridТехника.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.gridТехника.AllowSaveColParamsToXML = true;
            this.gridТехника.AllowSaveColPositionToXML = true;
            this.gridТехника.AllowSaveColWidthToXML = true;
            this.gridТехника.AllowSaveSettingsToXML = true;
            this.gridТехника.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridТехника.AutoResizeCols = true;
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.ImportedFromVMO = false;
            nsgIGridColumn1.InitiateRowEdit = true;
            nsgIGridColumn1.Name = "Тариф";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.gridТехника.Columns.Collection;
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
            nsgIGridColumn2.ImportedFromVMO = false;
            nsgIGridColumn2.InitiateRowEdit = true;
            nsgIGridColumn2.Name = "Техника";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.gridТехника.Columns.Collection;
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
            nsgIGridColumn3.InitiateRowEdit = true;
            nsgIGridColumn3.Name = "Сотрудник";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.gridТехника.Columns.Collection;
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
            nsgIGridColumn4.InitiateRowEdit = true;
            nsgIGridColumn4.Name = "НомерСмены";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.gridТехника.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            nsgIGridColumn5.InitiateRowEdit = true;
            nsgIGridColumn5.Name = "СтатусТехники";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.gridТехника.Columns.Collection;
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
            nsgIGridColumn6.InitiateRowEdit = true;
            nsgIGridColumn6.Name = "Владелец";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.gridТехника.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Visible = false;
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
            nsgIGridColumn7.ImportedFromVMO = false;
            nsgIGridColumn7.InitiateRowEdit = true;
            nsgIGridColumn7.Name = "Время";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.gridТехника.Columns.Collection;
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
            nsgIGridColumn8.InitiateRowEdit = true;
            nsgIGridColumn8.Name = "Длительность";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.gridТехника.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn1);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn2);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn3);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn4);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn5);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn6);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn7);
            this.gridТехника.Columns.Collection.Add(nsgIGridColumn8);
            this.gridТехника.Filter = false;
            this.gridТехника.FrozenColumns = 0;
            this.gridТехника.Grouping = true;
            this.gridТехника.Hierarhy = true;
            this.gridТехника.ImageList = null;
            this.gridТехника.IsCanMultiSelect = false;
            this.gridТехника.IsCanSingleSelect = false;
            this.gridТехника.LineHeight = 20;
            this.gridТехника.Location = new System.Drawing.Point(0, 0);
            this.gridТехника.MarkReadOnly = false;
            this.gridТехника.MasterObject = null;
            this.gridТехника.Name = "NsgIGrid";
            this.gridТехника.PageSelector = false;
            this.gridТехника.ReadOnly = false;
            this.gridТехника.RowChangeInterval = 200;
            this.gridТехника.RowHeaderImageList = null;
            this.gridТехника.RowMode = false;
            this.gridТехника.ScrollWidth = 0;
            this.gridТехника.SelectedRow = -1;
            this.gridТехника.ShowHeader = true;
            this.gridТехника.ShowLineImages = true;
            this.gridТехника.ShowLineNumbers = false;
            this.gridТехника.ShowPanel = true;
            this.gridТехника.ShowTotals = false;
            this.gridТехника.ShowTree = false;
            this.gridТехника.Size = new System.Drawing.Size(1076, 288);
            this.gridТехника.SourceObject = this.vmoТаблица;
            this.gridТехника.TabIndex = 21;
            this.gridТехника.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТаблица.MetaDataName = "Метаданные";
            this.vmoТаблица.FullName = "_SystemTables.МониторингФормированиеСменыТаблица.Владелец";
            // 
            // vmoТаблица
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингФормированиеСменыТаблица.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.ФормированиеСмены.Таблица";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблица.Columns.Collection.Add(this.Идентификатор_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Автоинкремент_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Владелец);
            this.vmoТаблица.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблица.Columns.Collection.Add(this.Техника);
            this.vmoТаблица.Columns.Collection.Add(this.Сотрудник);
            this.vmoТаблица.Columns.Collection.Add(this.СтатусТехники);
            this.vmoТаблица.Columns.Collection.Add(this.Время);
            this.vmoТаблица.Columns.Collection.Add(this.Тариф_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.НомерСмены);
            this.vmoТаблица.Columns.Collection.Add(this.Длительность);
            this.vmoТаблица.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблица.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoТаблица
            // 
            this.Идентификатор_vmoТаблица.AutoGenerated = true;
            this.Идентификатор_vmoТаблица.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблица.Name = "Идентификатор";
            this.Идентификатор_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблица.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблица.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблица;
            this.Идентификатор_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблица.Visible = false;
            // 
            // Автоинкремент_vmoТаблица
            // 
            this.Автоинкремент_vmoТаблица.AutoGenerated = true;
            this.Автоинкремент_vmoТаблица.CalcTotal = false;
            this.Автоинкремент_vmoТаблица.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблица.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблица.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблица.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблица;
            this.Автоинкремент_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблица.Visible = false;
            // 
            // Владелец
            // 
            this.Владелец.AutoGenerated = true;
            this.Владелец.Caption = "Владелец";
            this.Владелец.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец.Name = "Владелец";
            this.Владелец.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец.SearchCondition.OwnerComponent = this.Владелец;
            this.Владелец.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки
            // 
            this.НомерСтроки.AutoGenerated = true;
            this.НомерСтроки.CalcTotal = false;
            this.НомерСтроки.Caption = "НомерСтроки";
            this.НомерСтроки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки.Name = "НомерСтроки";
            this.НомерСтроки.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки.PropertyType = typeof(long);
            this.НомерСтроки.SearchCondition.OwnerComponent = this.НомерСтроки;
            this.НомерСтроки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки.Visible = false;
            // 
            // Техника
            // 
            this.Техника.AutoGenerated = true;
            this.Техника.Caption = "Техника";
            this.Техника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Техника.Name = "Техника";
            this.Техника.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника.SearchCondition.OwnerComponent = this.Техника;
            this.Техника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник
            // 
            this.Сотрудник.AutoGenerated = true;
            this.Сотрудник.Caption = "Сотрудник";
            this.Сотрудник.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.SearchCondition.OwnerComponent = this.Сотрудник;
            this.Сотрудник.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтатусТехники
            // 
            this.СтатусТехники.AutoGenerated = true;
            this.СтатусТехники.Caption = "СтатусТехники";
            this.СтатусТехники.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СтатусТехники.Name = "СтатусТехники";
            this.СтатусТехники.NSGType = typeof(TechControl.Метаданные.Мониторинг.СтатусТехники);
            this.СтатусТехники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.СтатусТехники);
            this.СтатусТехники.SearchCondition.OwnerComponent = this.СтатусТехники;
            this.СтатусТехники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Время
            // 
            this.Время.AutoGenerated = true;
            this.Время.Caption = "Время";
            this.Время.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Время.Name = "Время";
            this.Время.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Время.PropertyType = typeof(System.DateTime);
            this.Время.SearchCondition.OwnerComponent = this.Время;
            this.Время.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТаблица
            // 
            this.Тариф_vmoТаблица.AutoGenerated = true;
            this.Тариф_vmoТаблица.Caption = "Тариф";
            this.Тариф_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Тариф_vmoТаблица.Name = "Тариф";
            this.Тариф_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.SearchCondition.OwnerComponent = this.Тариф_vmoТаблица;
            this.Тариф_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСмены
            // 
            this.НомерСмены.AutoGenerated = true;
            this.НомерСмены.CalcTotal = false;
            this.НомерСмены.Caption = "НомерСмены";
            this.НомерСмены.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСмены.Name = "НомерСмены";
            this.НомерСмены.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСмены.PropertyType = typeof(long);
            this.НомерСмены.SearchCondition.OwnerComponent = this.НомерСмены;
            this.НомерСмены.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Длительность
            // 
            this.Длительность.AutoGenerated = true;
            this.Длительность.CalcTotal = false;
            this.Длительность.Caption = "Длительность";
            this.Длительность.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Длительность.Name = "Длительность";
            this.Длительность.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Длительность.PropertyType = typeof(decimal);
            this.Длительность.SearchCondition.OwnerComponent = this.Длительность;
            this.Длительность.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // gridПерсонал
            // 
            this.gridПерсонал.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.gridПерсонал.AllowSaveColParamsToXML = true;
            this.gridПерсонал.AllowSaveColPositionToXML = true;
            this.gridПерсонал.AllowSaveColWidthToXML = true;
            this.gridПерсонал.AllowSaveSettingsToXML = true;
            this.gridПерсонал.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridПерсонал.AutoResizeCols = true;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.ImportedFromVMO = false;
            nsgIGridColumn9.InitiateRowEdit = true;
            nsgIGridColumn9.Name = "Владелец";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.gridПерсонал.Columns.Collection;
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
        "Visible",
        "Index"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.InitiateRowEdit = true;
            nsgIGridColumn10.Name = "Тариф";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.gridПерсонал.Columns.Collection;
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
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.InitiateRowEdit = true;
            nsgIGridColumn11.Name = "Сотрудник";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.gridПерсонал.Columns.Collection;
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
            nsgIGridColumn12.ImportedFromVMO = false;
            nsgIGridColumn12.InitiateRowEdit = true;
            nsgIGridColumn12.Name = "НомерСмены";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.gridПерсонал.Columns.Collection;
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
            nsgIGridColumn13.ImportedFromVMO = false;
            nsgIGridColumn13.InitiateRowEdit = true;
            nsgIGridColumn13.Name = "СтатусСотрудника";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.gridПерсонал.Columns.Collection;
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
            nsgIGridColumn14.ImportedFromVMO = false;
            nsgIGridColumn14.InitiateRowEdit = true;
            nsgIGridColumn14.Name = "Время";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.gridПерсонал.Columns.Collection;
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
            nsgIGridColumn15.InitiateRowEdit = true;
            nsgIGridColumn15.Name = "Длительность";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.gridПерсонал.Columns.Collection;
            nsgIGridColumn15.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn15.UseAsHeaderImage = false;
            nsgIGridColumn15.Width = 100;
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn9);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn10);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn11);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn12);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn13);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn14);
            this.gridПерсонал.Columns.Collection.Add(nsgIGridColumn15);
            this.gridПерсонал.Filter = false;
            this.gridПерсонал.FrozenColumns = 0;
            this.gridПерсонал.Grouping = true;
            this.gridПерсонал.Hierarhy = true;
            this.gridПерсонал.ImageList = null;
            this.gridПерсонал.IsCanMultiSelect = false;
            this.gridПерсонал.IsCanSingleSelect = false;
            this.gridПерсонал.LineHeight = 20;
            this.gridПерсонал.Location = new System.Drawing.Point(0, 0);
            this.gridПерсонал.MarkReadOnly = false;
            this.gridПерсонал.MasterObject = null;
            this.gridПерсонал.Name = "NsgIGrid";
            this.gridПерсонал.PageSelector = false;
            this.gridПерсонал.ReadOnly = false;
            this.gridПерсонал.RowChangeInterval = 200;
            this.gridПерсонал.RowHeaderImageList = null;
            this.gridПерсонал.RowMode = false;
            this.gridПерсонал.ScrollWidth = 0;
            this.gridПерсонал.SelectedRow = -1;
            this.gridПерсонал.ShowHeader = true;
            this.gridПерсонал.ShowLineImages = true;
            this.gridПерсонал.ShowLineNumbers = false;
            this.gridПерсонал.ShowPanel = true;
            this.gridПерсонал.ShowTotals = false;
            this.gridПерсонал.ShowTree = false;
            this.gridПерсонал.Size = new System.Drawing.Size(1076, 288);
            this.gridПерсонал.SourceObject = this.vmoТаблицаПерсонал;
            this.gridПерсонал.TabIndex = 22;
            this.gridПерсонал.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТаблицаПерсонал.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТаблицаПерсонал.MetaDataName = "Метаданные";
            this.vmoТаблицаПерсонал.FullName = "_SystemTables.МониторингФормированиеСменыТаблицаПерсонал.Владелец";
            // 
            // vmoТаблицаПерсонал
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.МониторингФормированиеСменыТаблицаПерсонал.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Мониторинг.ФормированиеСмены.ТаблицаПерсонал";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Идентификатор_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Владелец_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.НомерСтроки_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.СтатусСотрудника);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Время_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.НомерСмены_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Сотрудник_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Тариф_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.Columns.Collection.Add(this.Длительность_vmoТаблицаПерсонал);
            this.vmoТаблицаПерсонал.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаПерсонал.Binding = nsgMasterDetailBinding2;
            // 
            // Идентификатор_vmoТаблицаПерсонал
            // 
            this.Идентификатор_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаПерсонал.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаПерсонал.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаПерсонал.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаПерсонал;
            this.Идентификатор_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаПерсонал.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаПерсонал
            // 
            this.Автоинкремент_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаПерсонал.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаПерсонал.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаПерсонал.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаПерсонал.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаПерсонал;
            this.Автоинкремент_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаПерсонал.Visible = false;
            // 
            // Владелец_vmoТаблицаПерсонал
            // 
            this.Владелец_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Владелец_vmoТаблицаПерсонал.Caption = "Владелец";
            this.Владелец_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТаблицаПерсонал.Name = "Владелец";
            this.Владелец_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаПерсонал.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Владелец_vmoТаблицаПерсонал;
            this.Владелец_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТаблицаПерсонал
            // 
            this.НомерСтроки_vmoТаблицаПерсонал.AutoGenerated = true;
            this.НомерСтроки_vmoТаблицаПерсонал.CalcTotal = false;
            this.НомерСтроки_vmoТаблицаПерсонал.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТаблицаПерсонал.Name = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТаблицаПерсонал.PropertyType = typeof(long);
            this.НомерСтроки_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТаблицаПерсонал;
            this.НомерСтроки_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТаблицаПерсонал.Visible = false;
            // 
            // СтатусСотрудника
            // 
            this.СтатусСотрудника.AutoGenerated = true;
            this.СтатусСотрудника.Caption = "СтатусСотрудника";
            this.СтатусСотрудника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СтатусСотрудника.Name = "СтатусСотрудника";
            this.СтатусСотрудника.NSGType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.СтатусСотрудника.PropertyType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.СтатусСотрудника.SearchCondition.OwnerComponent = this.СтатусСотрудника;
            this.СтатусСотрудника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Время_vmoТаблицаПерсонал
            // 
            this.Время_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Время_vmoТаблицаПерсонал.Caption = "Время";
            this.Время_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Время_vmoТаблицаПерсонал.Name = "Время";
            this.Время_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Время_vmoТаблицаПерсонал.PropertyType = typeof(System.DateTime);
            this.Время_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Время_vmoТаблицаПерсонал;
            this.Время_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСмены_vmoТаблицаПерсонал
            // 
            this.НомерСмены_vmoТаблицаПерсонал.AutoGenerated = true;
            this.НомерСмены_vmoТаблицаПерсонал.CalcTotal = false;
            this.НомерСмены_vmoТаблицаПерсонал.Caption = "НомерСмены";
            this.НомерСмены_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСмены_vmoТаблицаПерсонал.Name = "НомерСмены";
            this.НомерСмены_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСмены_vmoТаблицаПерсонал.PropertyType = typeof(long);
            this.НомерСмены_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.НомерСмены_vmoТаблицаПерсонал;
            this.НомерСмены_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoТаблицаПерсонал
            // 
            this.Сотрудник_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Сотрудник_vmoТаблицаПерсонал.Caption = "Сотрудник";
            this.Сотрудник_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сотрудник_vmoТаблицаПерсонал.Name = "Сотрудник";
            this.Сотрудник_vmoТаблицаПерсонал.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаПерсонал.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Сотрудник_vmoТаблицаПерсонал;
            this.Сотрудник_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТаблицаПерсонал
            // 
            this.Тариф_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Тариф_vmoТаблицаПерсонал.Caption = "Тариф";
            this.Тариф_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Тариф_vmoТаблицаПерсонал.Name = "Тариф";
            this.Тариф_vmoТаблицаПерсонал.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблицаПерсонал.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Тариф_vmoТаблицаПерсонал;
            this.Тариф_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Длительность_vmoТаблицаПерсонал
            // 
            this.Длительность_vmoТаблицаПерсонал.AutoGenerated = true;
            this.Длительность_vmoТаблицаПерсонал.CalcTotal = false;
            this.Длительность_vmoТаблицаПерсонал.Caption = "Длительность";
            this.Длительность_vmoТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Длительность_vmoТаблицаПерсонал.Name = "Длительность";
            this.Длительность_vmoТаблицаПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Длительность_vmoТаблицаПерсонал.PropertyType = typeof(decimal);
            this.Длительность_vmoТаблицаПерсонал.SearchCondition.OwnerComponent = this.Длительность_vmoТаблицаПерсонал;
            this.Длительность_vmoТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.ФормированиеСмены.ДатаДокумента";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(117, 9);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "Метаданные";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "ДатаДокумента";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(130, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel1
            // 
            this.nsgLabel1.AutoSize = true;
            this.nsgLabel1.ConfigurationName = "";
            this.nsgLabel1.FullName = "";
            this.nsgLabel1.IsInitialized = false;
            this.nsgLabel1.Location = new System.Drawing.Point(21, 13);
            this.nsgLabel1.MetaDataName = "";
            this.nsgLabel1.Name = "nsgLabel1";
            this.nsgLabel1.Requsite = "";
            this.nsgLabel1.Size = new System.Drawing.Size(93, 13);
            this.nsgLabel1.TabIndex = 10;
            this.nsgLabel1.Text = "Дата документа:";
            // 
            // nsgLabel2
            // 
            this.nsgLabel2.AutoSize = true;
            this.nsgLabel2.ConfigurationName = "";
            this.nsgLabel2.FullName = "";
            this.nsgLabel2.IsInitialized = false;
            this.nsgLabel2.Location = new System.Drawing.Point(517, 13);
            this.nsgLabel2.MetaDataName = "";
            this.nsgLabel2.Name = "nsgLabel2";
            this.nsgLabel2.Requsite = "";
            this.nsgLabel2.Size = new System.Drawing.Size(118, 13);
            this.nsgLabel2.TabIndex = 12;
            this.nsgLabel2.Text = "Документ основание:";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.ФормированиеСмены.ДокументОснование";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(638, 9);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ДокументОснование";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(130, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 11;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel4
            // 
            this.nsgLabel4.AutoSize = true;
            this.nsgLabel4.ConfigurationName = "";
            this.nsgLabel4.FullName = "";
            this.nsgLabel4.IsInitialized = false;
            this.nsgLabel4.Location = new System.Drawing.Point(21, 44);
            this.nsgLabel4.MetaDataName = "";
            this.nsgLabel4.Name = "nsgLabel4";
            this.nsgLabel4.Requsite = "";
            this.nsgLabel4.Size = new System.Drawing.Size(48, 13);
            this.nsgLabel4.TabIndex = 16;
            this.nsgLabel4.Text = "Объект:";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Мониторинг.ФормированиеСмены.Объект";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(72, 40);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Объект";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(175, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 15;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput4.Selected += new System.EventHandler(this.nsgInput4_Selected);
            // 
            // nsgLabel5
            // 
            this.nsgLabel5.AutoSize = true;
            this.nsgLabel5.ConfigurationName = "";
            this.nsgLabel5.FullName = "";
            this.nsgLabel5.IsInitialized = false;
            this.nsgLabel5.Location = new System.Drawing.Point(265, 44);
            this.nsgLabel5.MetaDataName = "";
            this.nsgLabel5.Name = "nsgLabel5";
            this.nsgLabel5.Requsite = "";
            this.nsgLabel5.Size = new System.Drawing.Size(89, 13);
            this.nsgLabel5.TabIndex = 18;
            this.nsgLabel5.Text = "Ответственный:";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Мониторинг.ФормированиеСмены.Ответственный";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(357, 40);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Ответственный";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(223, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 17;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel6
            // 
            this.nsgLabel6.AutoSize = true;
            this.nsgLabel6.ConfigurationName = "";
            this.nsgLabel6.FullName = "";
            this.nsgLabel6.IsInitialized = false;
            this.nsgLabel6.Location = new System.Drawing.Point(265, 13);
            this.nsgLabel6.MetaDataName = "";
            this.nsgLabel6.Name = "nsgLabel6";
            this.nsgLabel6.Requsite = "";
            this.nsgLabel6.Size = new System.Drawing.Size(101, 13);
            this.nsgLabel6.TabIndex = 20;
            this.nsgLabel6.Text = "Номер документа:";
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Мониторинг.ФормированиеСмены.НомерДокумента";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(372, 9);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "НомерДокумента";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(130, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 19;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel3
            // 
            this.nsgLabel3.AutoSize = true;
            this.nsgLabel3.ConfigurationName = "";
            this.nsgLabel3.FullName = "";
            this.nsgLabel3.IsInitialized = false;
            this.nsgLabel3.Location = new System.Drawing.Point(592, 43);
            this.nsgLabel3.MetaDataName = "";
            this.nsgLabel3.Name = "nsgLabel3";
            this.nsgLabel3.Requsite = "";
            this.nsgLabel3.Size = new System.Drawing.Size(43, 13);
            this.nsgLabel3.TabIndex = 23;
            this.nsgLabel3.Text = "Тариф:";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.ФормированиеСмены.Тариф";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(638, 40);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Тариф";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(130, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 22;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bЗаполнить
            // 
            this.bЗаполнить.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bЗаполнить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bЗаполнить.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bЗаполнить.Location = new System.Drawing.Point(771, 40);
            this.bЗаполнить.Name = "NsgButton";
            this.bЗаполнить.ReadOnlyProvider = this.nsgVisualMultipleObject;
            this.bЗаполнить.Size = new System.Drawing.Size(75, 25);
            this.bЗаполнить.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.bЗаполнить.TabIndex = 24;
            this.bЗаполнить.Text = "Заполнить";
            this.bЗаполнить.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.bЗаполнить.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.bЗаполнить_AsyncClick);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(1084, 314);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.gridТехника);
            this.tabPage1.Enabled = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Техника";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.gridПерсонал);
            this.tabPage2.Enabled = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Персонал";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = true;
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Control;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Мониторинг.ФормированиеСмены.ЭтоИтоговыйДокумент";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(771, 9);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "ЭтоИтоговыйДокумент";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(130, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 26;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.nsgInput7.ValueChanged += new NsgSoft.Design.ValueChangedInitEventHandler(this.nsgInput7_ValueChanged);
            // 
            // Идентификатор
            // 
            this.Идентификатор.AutoGenerated = true;
            this.Идентификатор.Caption = "Идентификатор";
            this.Идентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор.Name = "Идентификатор";
            this.Идентификатор.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор.PropertyType = typeof(System.Guid);
            this.Идентификатор.SearchCondition.OwnerComponent = this.Идентификатор;
            this.Идентификатор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор.Visible = false;
            // 
            // Автоинкремент
            // 
            this.Автоинкремент.AutoGenerated = true;
            this.Автоинкремент.CalcTotal = false;
            this.Автоинкремент.Caption = "Автоинкремент";
            this.Автоинкремент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент.Name = "Автоинкремент";
            this.Автоинкремент.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент.PropertyType = typeof(long);
            this.Автоинкремент.SearchCondition.OwnerComponent = this.Автоинкремент;
            this.Автоинкремент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент.Visible = false;
            // 
            // ПрефиксКода
            // 
            this.ПрефиксКода.AutoGenerated = true;
            this.ПрефиксКода.Caption = "ПрефиксКода";
            this.ПрефиксКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПрефиксКода.Name = "ПрефиксКода";
            this.ПрефиксКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода.PropertyType = typeof(string);
            this.ПрефиксКода.SearchCondition.OwnerComponent = this.ПрефиксКода;
            this.ПрефиксКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода.Visible = false;
            // 
            // НомерКода
            // 
            this.НомерКода.AutoGenerated = true;
            this.НомерКода.CalcTotal = false;
            this.НомерКода.Caption = "НомерКода";
            this.НомерКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерКода.Name = "НомерКода";
            this.НомерКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода.PropertyType = typeof(long);
            this.НомерКода.SearchCondition.OwnerComponent = this.НомерКода;
            this.НомерКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода.Visible = false;
            // 
            // НомерДокумента
            // 
            this.НомерДокумента.AutoGenerated = true;
            this.НомерДокумента.Caption = "НомерДокумента";
            this.НомерДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерДокумента.Name = "НомерДокумента";
            this.НомерДокумента.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерДокумента.PropertyType = typeof(string);
            this.НомерДокумента.SearchCondition.OwnerComponent = this.НомерДокумента;
            this.НомерДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаДокумента
            // 
            this.ДатаДокумента.AutoGenerated = true;
            this.ДатаДокумента.Caption = "ДатаДокумента";
            this.ДатаДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДатаДокумента.Name = "ДатаДокумента";
            this.ДатаДокумента.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаДокумента.PropertyType = typeof(System.DateTime);
            this.ДатаДокумента.SearchCondition.OwnerComponent = this.ДатаДокумента;
            this.ДатаДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Индекс
            // 
            this.Индекс.AutoGenerated = true;
            this.Индекс.Caption = "Индекс";
            this.Индекс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Индекс.Name = "Индекс";
            this.Индекс.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Индекс.PropertyType = typeof(string);
            this.Индекс.SearchCondition.OwnerComponent = this.Индекс;
            this.Индекс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Индекс.Visible = false;
            // 
            // ДокументОснование
            // 
            this.ДокументОснование.AutoGenerated = true;
            this.ДокументОснование.Caption = "ДокументОснование";
            this.ДокументОснование.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДокументОснование.Name = "ДокументОснование";
            this.ДокументОснование.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.ДокументОснование.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.ДокументОснование.SearchCondition.OwnerComponent = this.ДокументОснование;
            this.ДокументОснование.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комментарий
            // 
            this.Комментарий.AutoGenerated = true;
            this.Комментарий.Caption = "Комментарий";
            this.Комментарий.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Комментарий.Name = "Комментарий";
            this.Комментарий.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Комментарий.PropertyType = typeof(string);
            this.Комментарий.SearchCondition.OwnerComponent = this.Комментарий;
            this.Комментарий.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента
            // 
            this.СостояниеДокумента.AutoGenerated = true;
            this.СостояниеДокумента.Caption = "СостояниеДокумента";
            this.СостояниеДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СостояниеДокумента.Name = "СостояниеДокумента";
            this.СостояниеДокумента.NSGType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.PropertyType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.SearchCondition.OwnerComponent = this.СостояниеДокумента;
            this.СостояниеДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Таблица
            // 
            this.Таблица.AutoGenerated = true;
            this.Таблица.Caption = "Таблица";
            this.Таблица.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Таблица.Name = "Таблица";
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблица);
            this.Таблица.SearchCondition.OwnerComponent = this.Таблица;
            this.Таблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Таблица.Visible = false;
            // 
            // Объект
            // 
            this.Объект.AutoGenerated = true;
            this.Объект.Caption = "Объект";
            this.Объект.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Объект.Name = "Объект";
            this.Объект.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект.SearchCondition.OwnerComponent = this.Объект;
            this.Объект.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Ответственный
            // 
            this.Ответственный.AutoGenerated = true;
            this.Ответственный.Caption = "Ответственный";
            this.Ответственный.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Ответственный.Name = "Ответственный";
            this.Ответственный.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Ответственный.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Ответственный.SearchCondition.OwnerComponent = this.Ответственный;
            this.Ответственный.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф
            // 
            this.Тариф.AutoGenerated = true;
            this.Тариф.Caption = "Тариф";
            this.Тариф.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Тариф.Name = "Тариф";
            this.Тариф.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф.SearchCondition.OwnerComponent = this.Тариф;
            this.Тариф.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаПерсонал
            // 
            this.ТаблицаПерсонал.AutoGenerated = true;
            this.ТаблицаПерсонал.Caption = "ТаблицаПерсонал";
            this.ТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаПерсонал.Name = "ТаблицаПерсонал";
            this.ТаблицаПерсонал.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблицаПерсонал);
            this.ТаблицаПерсонал.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблицаПерсонал);
            this.ТаблицаПерсонал.SearchCondition.OwnerComponent = this.ТаблицаПерсонал;
            this.ТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаПерсонал.Visible = false;
            // 
            // ЭтоИтоговыйДокумент
            // 
            this.ЭтоИтоговыйДокумент.AutoGenerated = true;
            this.ЭтоИтоговыйДокумент.Caption = "ЭтоИтоговыйДокумент";
            this.ЭтоИтоговыйДокумент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЭтоИтоговыйДокумент.Name = "ЭтоИтоговыйДокумент";
            this.ЭтоИтоговыйДокумент.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоИтоговыйДокумент.PropertyType = typeof(bool);
            this.ЭтоИтоговыйДокумент.SearchCondition.OwnerComponent = this.ЭтоИтоговыйДокумент;
            this.ЭтоИтоговыйДокумент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ФормированиеСменыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 410);
            this.Controls.Add(this.nsgInput7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bЗаполнить);
            this.Controls.Add(this.nsgLabel3);
            this.Controls.Add(this.nsgInput3);
            this.Controls.Add(this.nsgLabel6);
            this.Controls.Add(this.nsgInput6);
            this.Controls.Add(this.nsgLabel5);
            this.Controls.Add(this.nsgInput5);
            this.Controls.Add(this.nsgLabel4);
            this.Controls.Add(this.nsgInput4);
            this.Controls.Add(this.nsgLabel2);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.nsgLabel1);
            this.Controls.Add(this.nsgInput1);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandleButtonVisible = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgMultipleObjectElementForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgMultipleObjectElementForm";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.nsgLabel1, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.nsgLabel2, 0);
            this.Controls.SetChildIndex(this.nsgInput4, 0);
            this.Controls.SetChildIndex(this.nsgLabel4, 0);
            this.Controls.SetChildIndex(this.nsgInput5, 0);
            this.Controls.SetChildIndex(this.nsgLabel5, 0);
            this.Controls.SetChildIndex(this.nsgInput6, 0);
            this.Controls.SetChildIndex(this.nsgLabel6, 0);
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgLabel3, 0);
            this.Controls.SetChildIndex(this.bЗаполнить, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.nsgInput7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nsgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgToolStrip2)).EndInit();
            this.nsgToolStrip2.ResumeLayout(false);
            this.nsgToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgHandling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgSave)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButtonBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMovementsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsersActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInListButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridТехника)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridПерсонал)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаПерсонал)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bЗаполнить)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected NsgInput nsgInput1;
        protected NsgLabel nsgLabel2;
        protected NsgInput nsgInput2;
        protected NsgLabel nsgLabel4;
        protected NsgInput nsgInput4;
        protected NsgLabel nsgLabel5;
        protected NsgInput nsgInput5;
        protected NsgLabel nsgLabel6;
        protected NsgInput nsgInput6;
        protected NsgLabel nsgLabel3;
        protected NsgInput nsgInput3;
        protected NsgSoft.Design.NsgButton bЗаполнить;
        private NsgIGrid gridТехника;
        protected System.Windows.Forms.TabPage tabPage1;
        private NsgIGrid gridПерсонал;
        protected NsgInput nsgInput7;
        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.Boolean ЭтоИтоговыйДокумент;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТаблица;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблица;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected Техника.ColumnDescriptor Техника;
        protected Сотрудники.ColumnDescriptor Сотрудник;
        protected СтатусТехники.ColumnDescriptor СтатусТехники;
        protected NsgColumnDescriptor.DateTime Время;
        protected Тарифы.ColumnDescriptor Тариф_vmoТаблица;
        protected NsgColumnDescriptor.Int64 НомерСмены;
        protected NsgColumnDescriptor.Decimal Длительность;
        protected NsgColumnDescriptor.Decimal Длительность_vmoТаблицаПерсонал;
        protected NsgLabel nsgLabel1;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabPage2;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String НомерДокумента;
        protected NsgColumnDescriptor.DateTime ДатаДокумента;
        protected NsgColumnDescriptor.String Индекс;
        protected NsgColumnDescriptor.MultipleObject ДокументОснование;
        protected NsgColumnDescriptor.String Комментарий;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected _SystemTables.МониторингФормированиеСменыТаблица.ColumnDescriptor Таблица;
        protected Объекты.ColumnDescriptor Объект;
        protected Сотрудники.ColumnDescriptor Ответственный;
        protected Тарифы.ColumnDescriptor Тариф;
        protected _SystemTables.МониторингФормированиеСменыТаблицаПерсонал.ColumnDescriptor ТаблицаПерсонал;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаПерсонал;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаПерсонал;
        protected NsgColumnDescriptor.MultipleObject Владелец_vmoТаблицаПерсонал;
        protected NsgColumnDescriptor.Int64 НомерСтроки_vmoТаблицаПерсонал;
        protected СтатусСотрудника.ColumnDescriptor СтатусСотрудника;
        protected NsgColumnDescriptor.DateTime Время_vmoТаблицаПерсонал;
        protected NsgColumnDescriptor.Int64 НомерСмены_vmoТаблицаПерсонал;
        protected Сотрудники.ColumnDescriptor Сотрудник_vmoТаблицаПерсонал;
        protected Тарифы.ColumnDescriptor Тариф_vmoТаблицаПерсонал;
        private NsgVisualMultipleObject vmoТаблица;
        private NsgVisualMultipleObject vmoТаблицаПерсонал;
    }
}