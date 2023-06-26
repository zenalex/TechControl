using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Учет

{
    
    public partial class РазмерыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РазмерыФормаЭлемента));
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpПараметры = new System.Windows.Forms.TabPage();
            this.nsgInput16 = new NsgSoft.Forms.NsgInput();
            this.label12 = new System.Windows.Forms.Label();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.nsgInput14 = new NsgSoft.Forms.NsgInput();
            this.label11 = new System.Windows.Forms.Label();
            this.nsgInput13 = new NsgSoft.Forms.NsgInput();
            this.label10 = new System.Windows.Forms.Label();
            this.nsgInput12 = new NsgSoft.Forms.NsgInput();
            this.label9 = new System.Windows.Forms.Label();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.tpПарметрыНоги = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Идентификатор = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента = new TechControl.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.ВидСвойствНоменклатуры = new TechControl.Метаданные.Учет.ВидСвойствНоменклатуры.ColumnDescriptor();
            this.РостМакс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватГрудиМин = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватТалииМин = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватТалииМакс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватБедерМин = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватБедерМакс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.БоковаяДлинаБрюк = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватШеиМин = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВнутренняяДлинаБрюк = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДлинаРукава = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватГрудиМакс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.РостМин = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватШеиМакс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДлинаСтупни = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ВидРазмернойСетки = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки.ColumnDescriptor();
            this.Родитель = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.nsgInput15 = new NsgSoft.Forms.NsgInput();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nsgInput17 = new NsgSoft.Forms.NsgInput();
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
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpПараметры.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            this.tpПарметрыНоги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(657, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(773, 1);
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
            this.nsgToolStrip2.Controls.Add(this.elementRightsButton);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(852, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(387, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(482, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(566, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 589);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(852, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(387, 1);
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
            this.documentButton.Size = new System.Drawing.Size(79, 26);
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
            this.documentMovementsButton.Location = new System.Drawing.Point(100, 1);
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
            this.btnUsersActions.Location = new System.Drawing.Point(168, 1);
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
            this.showInListButton.Location = new System.Drawing.Point(236, 1);
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
            this.Comment.FullName = "Учет.Размеры.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(852, 23);
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
            this.documentStructure.Location = new System.Drawing.Point(304, 1);
            this.documentStructure.Name = "documentStructure";
            this.documentStructure.Size = new System.Drawing.Size(75, 26);
            this.documentStructure.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.documentStructure.TabIndex = 17;
            this.documentStructure.Text = "Структура документов";
            this.documentStructure.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementRightsButton
            // 
            this.elementRightsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elementRightsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elementRightsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.elementRightsButton.Container = this.documentButton;
            this.elementRightsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.elementRightsButton.Location = new System.Drawing.Point(379, 1);
            this.elementRightsButton.Name = "elementRightsButton";
            this.elementRightsButton.Size = new System.Drawing.Size(88, 26);
            this.elementRightsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.elementRightsButton.TabIndex = 18;
            this.elementRightsButton.Text = "Права пользователей";
            this.elementRightsButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Идентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Автоинкремент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЭтоГруппа);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторРодителя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Уровень);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Код);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Наименование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВидСвойствНоменклатуры);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.РостМакс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватГрудиМин);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватТалииМин);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватТалииМакс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватБедерМин);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватБедерМакс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.БоковаяДлинаБрюк);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватШеиМин);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВнутренняяДлинаБрюк);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДлинаРукава);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватГрудиМакс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.РостМин);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбхватШеиМакс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДлинаСтупни);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ВидРазмернойСетки);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Учет.Размеры";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Учет.Размеры.ВидСвойствНоменклатуры";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(71, 9);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "Метаданные";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "ВидСвойствНоменклатуры";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(205, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Значение";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Учет.Размеры.Наименование";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(71, 42);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Наименование";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(205, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 11;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TechControl.Properties.Resources.МеркиКостюма;
            this.pictureBox1.Location = new System.Drawing.Point(333, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpПараметры);
            this.tabControl1.Controls.Add(this.tpПарметрыНоги);
            this.tabControl1.Location = new System.Drawing.Point(13, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(838, 518);
            this.tabControl1.TabIndex = 14;
            // 
            // tpПараметры
            // 
            this.tpПараметры.AllowDrop = true;
            this.tpПараметры.Controls.Add(this.nsgInput16);
            this.tpПараметры.Controls.Add(this.label12);
            this.tpПараметры.Controls.Add(this.nsgInput11);
            this.tpПараметры.Controls.Add(this.nsgInput14);
            this.tpПараметры.Controls.Add(this.label11);
            this.tpПараметры.Controls.Add(this.nsgInput13);
            this.tpПараметры.Controls.Add(this.label10);
            this.tpПараметры.Controls.Add(this.nsgInput12);
            this.tpПараметры.Controls.Add(this.label9);
            this.tpПараметры.Controls.Add(this.nsgInput9);
            this.tpПараметры.Controls.Add(this.nsgInput10);
            this.tpПараметры.Controls.Add(this.label8);
            this.tpПараметры.Controls.Add(this.nsgInput7);
            this.tpПараметры.Controls.Add(this.nsgInput8);
            this.tpПараметры.Controls.Add(this.label7);
            this.tpПараметры.Controls.Add(this.nsgInput5);
            this.tpПараметры.Controls.Add(this.nsgInput6);
            this.tpПараметры.Controls.Add(this.label6);
            this.tpПараметры.Controls.Add(this.label5);
            this.tpПараметры.Controls.Add(this.label4);
            this.tpПараметры.Controls.Add(this.nsgInput4);
            this.tpПараметры.Controls.Add(this.nsgInput3);
            this.tpПараметры.Controls.Add(this.label3);
            this.tpПараметры.Controls.Add(this.pictureBox1);
            this.tpПараметры.Enabled = true;
            this.tpПараметры.Location = new System.Drawing.Point(4, 22);
            this.tpПараметры.Name = "tpПараметры";
            this.tpПараметры.Padding = new System.Windows.Forms.Padding(3);
            this.tpПараметры.Size = new System.Drawing.Size(830, 492);
            this.tpПараметры.TabIndex = 0;
            this.tpПараметры.Text = "Значения параметров";
            this.tpПараметры.UseVisualStyleBackColor = true;
            this.tpПараметры.Visible = false;
            // 
            // nsgInput16
            // 
            this.nsgInput16.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput16.ConfigurationName = "TechControl";
            this.nsgInput16.DisableLeaveControlEvent = false;
            this.nsgInput16.FullName = "Учет.Размеры.ДлинаРукава";
            this.nsgInput16.FullTextSearch = false;
            this.nsgInput16.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput16.IsButton = false;
            this.nsgInput16.IsInitialized = true;
            this.nsgInput16.IsPassword = false;
            this.nsgInput16.Location = new System.Drawing.Point(210, 233);
            this.nsgInput16.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput16.Mask = "";
            this.nsgInput16.MetaDataName = "Метаданные";
            this.nsgInput16.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput16.Name = "NsgInput";
            this.nsgInput16.ObjectImages = null;
            this.nsgInput16.ObjectIndex = null;
            this.nsgInput16.ObjectStrings = null;
            this.nsgInput16.Requsite = "ДлинаРукава";
            this.nsgInput16.SearchFieldName = "";
            this.nsgInput16.ShowMultipleObjectInComboBox = false;
            this.nsgInput16.ShowRowCount = 10;
            this.nsgInput16.Size = new System.Drawing.Size(40, 20);
            this.nsgInput16.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput16.TabIndex = 36;
            this.nsgInput16.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 240);
            this.label12.Name = "label3";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Длина рукава см.";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "TechControl";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "Учет.Размеры.ОбхватШеиМакс";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(247, 204);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "Метаданные";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "ОбхватШеиМакс";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(40, 20);
            this.nsgInput11.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput11.TabIndex = 34;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput14
            // 
            this.nsgInput14.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput14.ConfigurationName = "TechControl";
            this.nsgInput14.DisableLeaveControlEvent = false;
            this.nsgInput14.FullName = "Учет.Размеры.ОбхватШеиМин";
            this.nsgInput14.FullTextSearch = false;
            this.nsgInput14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput14.IsButton = false;
            this.nsgInput14.IsInitialized = true;
            this.nsgInput14.IsPassword = false;
            this.nsgInput14.Location = new System.Drawing.Point(179, 204);
            this.nsgInput14.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput14.Mask = "";
            this.nsgInput14.MetaDataName = "Метаданные";
            this.nsgInput14.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput14.Name = "NsgInput";
            this.nsgInput14.ObjectImages = null;
            this.nsgInput14.ObjectIndex = null;
            this.nsgInput14.ObjectStrings = null;
            this.nsgInput14.Requsite = "ОбхватШеиМин";
            this.nsgInput14.SearchFieldName = "";
            this.nsgInput14.ShowMultipleObjectInComboBox = false;
            this.nsgInput14.ShowRowCount = 10;
            this.nsgInput14.Size = new System.Drawing.Size(40, 20);
            this.nsgInput14.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput14.TabIndex = 33;
            this.nsgInput14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 211);
            this.label11.Name = "label3";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Обхват шеи см.";
            // 
            // nsgInput13
            // 
            this.nsgInput13.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput13.ConfigurationName = "TechControl";
            this.nsgInput13.DisableLeaveControlEvent = false;
            this.nsgInput13.FullName = "Учет.Размеры.ВнутренняяДлинаБрюк";
            this.nsgInput13.FullTextSearch = false;
            this.nsgInput13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput13.IsButton = false;
            this.nsgInput13.IsInitialized = true;
            this.nsgInput13.IsPassword = false;
            this.nsgInput13.Location = new System.Drawing.Point(210, 171);
            this.nsgInput13.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput13.Mask = "";
            this.nsgInput13.MetaDataName = "Метаданные";
            this.nsgInput13.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput13.Name = "NsgInput";
            this.nsgInput13.ObjectImages = null;
            this.nsgInput13.ObjectIndex = null;
            this.nsgInput13.ObjectStrings = null;
            this.nsgInput13.Requsite = "ВнутренняяДлинаБрюк";
            this.nsgInput13.SearchFieldName = "";
            this.nsgInput13.ShowMultipleObjectInComboBox = false;
            this.nsgInput13.ShowRowCount = 10;
            this.nsgInput13.Size = new System.Drawing.Size(40, 20);
            this.nsgInput13.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput13.TabIndex = 31;
            this.nsgInput13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(61, 171);
            this.label10.Name = "label3";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Длина брюк по внутреннему шву см.";
            // 
            // nsgInput12
            // 
            this.nsgInput12.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput12.ConfigurationName = "TechControl";
            this.nsgInput12.DisableLeaveControlEvent = false;
            this.nsgInput12.FullName = "Учет.Размеры.БоковаяДлинаБрюк";
            this.nsgInput12.FullTextSearch = false;
            this.nsgInput12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput12.IsButton = false;
            this.nsgInput12.IsInitialized = true;
            this.nsgInput12.IsPassword = false;
            this.nsgInput12.Location = new System.Drawing.Point(210, 142);
            this.nsgInput12.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput12.Mask = "";
            this.nsgInput12.MetaDataName = "Метаданные";
            this.nsgInput12.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput12.Name = "NsgInput";
            this.nsgInput12.ObjectImages = null;
            this.nsgInput12.ObjectIndex = null;
            this.nsgInput12.ObjectStrings = null;
            this.nsgInput12.Requsite = "БоковаяДлинаБрюк";
            this.nsgInput12.SearchFieldName = "";
            this.nsgInput12.ShowMultipleObjectInComboBox = false;
            this.nsgInput12.ShowRowCount = 10;
            this.nsgInput12.Size = new System.Drawing.Size(40, 20);
            this.nsgInput12.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput12.TabIndex = 29;
            this.nsgInput12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 149);
            this.label9.Name = "label3";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Боковая длина брюк см.";
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "TechControl";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "Учет.Размеры.ОбхватБедерМакс";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(247, 114);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "Метаданные";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "ОбхватБедерМакс";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(40, 20);
            this.nsgInput9.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput9.TabIndex = 27;
            this.nsgInput9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput10
            // 
            this.nsgInput10.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput10.ConfigurationName = "TechControl";
            this.nsgInput10.DisableLeaveControlEvent = false;
            this.nsgInput10.FullName = "Учет.Размеры.ОбхватБедерМин";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(179, 114);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "Метаданные";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "ОбхватБедерМин";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(40, 20);
            this.nsgInput10.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput10.TabIndex = 26;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 121);
            this.label8.Name = "label3";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Обхват бедер см.";
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Учет.Размеры.ОбхватТалииМакс";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(247, 86);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "ОбхватТалииМакс";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(40, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 24;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "TechControl";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "Учет.Размеры.ОбхватТалииМин";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(179, 86);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "Метаданные";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "ОбхватТалииМин";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(40, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 23;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 93);
            this.label7.Name = "label3";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Обхват талии см.";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Учет.Размеры.ОбхватГрудиМакс";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(247, 56);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "ОбхватГрудиМакс";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(40, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 21;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Учет.Размеры.ОбхватГрудиМин";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(179, 56);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "ОбхватГрудиМин";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(40, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 20;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 63);
            this.label6.Name = "label3";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Обхват груди см.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 8);
            this.label5.Name = "label3";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Макс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 8);
            this.label4.Name = "label3";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Мин";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Учет.Размеры.РостМакс";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(247, 27);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "РостМакс";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(40, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 16;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Учет.Размеры.РостМин";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(179, 27);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "РостМин";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(40, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 15;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Рост см.";
            // 
            // tpПарметрыНоги
            // 
            this.tpПарметрыНоги.AllowDrop = true;
            this.tpПарметрыНоги.Controls.Add(this.nsgInput15);
            this.tpПарметрыНоги.Controls.Add(this.label13);
            this.tpПарметрыНоги.Controls.Add(this.pictureBox2);
            this.tpПарметрыНоги.Enabled = true;
            this.tpПарметрыНоги.Location = new System.Drawing.Point(4, 22);
            this.tpПарметрыНоги.Name = "tpПарметрыНоги";
            this.tpПарметрыНоги.Padding = new System.Windows.Forms.Padding(3);
            this.tpПарметрыНоги.Size = new System.Drawing.Size(830, 492);
            this.tpПарметрыНоги.TabIndex = 1;
            this.tpПарметрыНоги.Text = "Парметры ступни";
            this.tpПарметрыНоги.UseVisualStyleBackColor = true;
            this.tpПарметрыНоги.Visible = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TechControl.Properties.Resources.РазмерыОбуви;
            this.pictureBox2.Location = new System.Drawing.Point(200, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 473);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            // ЭтоГруппа
            // 
            this.ЭтоГруппа.AutoGenerated = true;
            this.ЭтоГруппа.Caption = "ЭтоГруппа";
            this.ЭтоГруппа.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЭтоГруппа.Name = "ЭтоГруппа";
            this.ЭтоГруппа.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа.PropertyType = typeof(bool);
            this.ЭтоГруппа.SearchCondition.OwnerComponent = this.ЭтоГруппа;
            this.ЭтоГруппа.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа.Visible = false;
            // 
            // ИдентификаторРодителя
            // 
            this.ИдентификаторРодителя.AutoGenerated = true;
            this.ИдентификаторРодителя.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторРодителя.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя.SearchCondition.OwnerComponent = this.ИдентификаторРодителя;
            this.ИдентификаторРодителя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя.Visible = false;
            // 
            // Уровень
            // 
            this.Уровень.AutoGenerated = true;
            this.Уровень.Caption = "Уровень";
            this.Уровень.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Уровень.Name = "Уровень";
            this.Уровень.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень.PropertyType = typeof(byte);
            this.Уровень.SearchCondition.OwnerComponent = this.Уровень;
            this.Уровень.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень.Visible = false;
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
            // Код
            // 
            this.Код.AutoGenerated = true;
            this.Код.Caption = "Код";
            this.Код.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Код.Name = "Код";
            this.Код.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код.PropertyType = typeof(string);
            this.Код.SearchCondition.OwnerComponent = this.Код;
            this.Код.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование
            // 
            this.Наименование.AutoGenerated = true;
            this.Наименование.Caption = "Наименование";
            this.Наименование.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Наименование.Name = "Наименование";
            this.Наименование.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование.PropertyType = typeof(string);
            this.Наименование.SearchCondition.OwnerComponent = this.Наименование;
            this.Наименование.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // ВидСвойствНоменклатуры
            // 
            this.ВидСвойствНоменклатуры.AutoGenerated = true;
            this.ВидСвойствНоменклатуры.Caption = "ВидСвойствНоменклатуры";
            this.ВидСвойствНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВидСвойствНоменклатуры.Name = "ВидСвойствНоменклатуры";
            this.ВидСвойствНоменклатуры.NSGType = typeof(TechControl.Метаданные.Учет.ВидСвойствНоменклатуры);
            this.ВидСвойствНоменклатуры.PropertyType = typeof(TechControl.Метаданные.Учет.ВидСвойствНоменклатуры);
            this.ВидСвойствНоменклатуры.SearchCondition.OwnerComponent = this.ВидСвойствНоменклатуры;
            this.ВидСвойствНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РостМакс
            // 
            this.РостМакс.AutoGenerated = true;
            this.РостМакс.CalcTotal = false;
            this.РостМакс.Caption = "РостМакс";
            this.РостМакс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.РостМакс.Name = "РостМакс";
            this.РостМакс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.РостМакс.PropertyType = typeof(decimal);
            this.РостМакс.SearchCondition.OwnerComponent = this.РостМакс;
            this.РостМакс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватГрудиМин
            // 
            this.ОбхватГрудиМин.AutoGenerated = true;
            this.ОбхватГрудиМин.CalcTotal = false;
            this.ОбхватГрудиМин.Caption = "ОбхватГрудиМин";
            this.ОбхватГрудиМин.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватГрудиМин.Name = "ОбхватГрудиМин";
            this.ОбхватГрудиМин.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватГрудиМин.PropertyType = typeof(decimal);
            this.ОбхватГрудиМин.SearchCondition.OwnerComponent = this.ОбхватГрудиМин;
            this.ОбхватГрудиМин.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватТалииМин
            // 
            this.ОбхватТалииМин.AutoGenerated = true;
            this.ОбхватТалииМин.CalcTotal = false;
            this.ОбхватТалииМин.Caption = "ОбхватТалииМин";
            this.ОбхватТалииМин.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватТалииМин.Name = "ОбхватТалииМин";
            this.ОбхватТалииМин.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватТалииМин.PropertyType = typeof(decimal);
            this.ОбхватТалииМин.SearchCondition.OwnerComponent = this.ОбхватТалииМин;
            this.ОбхватТалииМин.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватТалииМакс
            // 
            this.ОбхватТалииМакс.AutoGenerated = true;
            this.ОбхватТалииМакс.CalcTotal = false;
            this.ОбхватТалииМакс.Caption = "ОбхватТалииМакс";
            this.ОбхватТалииМакс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватТалииМакс.Name = "ОбхватТалииМакс";
            this.ОбхватТалииМакс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватТалииМакс.PropertyType = typeof(decimal);
            this.ОбхватТалииМакс.SearchCondition.OwnerComponent = this.ОбхватТалииМакс;
            this.ОбхватТалииМакс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватБедерМин
            // 
            this.ОбхватБедерМин.AutoGenerated = true;
            this.ОбхватБедерМин.CalcTotal = false;
            this.ОбхватБедерМин.Caption = "ОбхватБедерМин";
            this.ОбхватБедерМин.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватБедерМин.Name = "ОбхватБедерМин";
            this.ОбхватБедерМин.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватБедерМин.PropertyType = typeof(decimal);
            this.ОбхватБедерМин.SearchCondition.OwnerComponent = this.ОбхватБедерМин;
            this.ОбхватБедерМин.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватБедерМакс
            // 
            this.ОбхватБедерМакс.AutoGenerated = true;
            this.ОбхватБедерМакс.CalcTotal = false;
            this.ОбхватБедерМакс.Caption = "ОбхватБедерМакс";
            this.ОбхватБедерМакс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватБедерМакс.Name = "ОбхватБедерМакс";
            this.ОбхватБедерМакс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватБедерМакс.PropertyType = typeof(decimal);
            this.ОбхватБедерМакс.SearchCondition.OwnerComponent = this.ОбхватБедерМакс;
            this.ОбхватБедерМакс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // БоковаяДлинаБрюк
            // 
            this.БоковаяДлинаБрюк.AutoGenerated = true;
            this.БоковаяДлинаБрюк.CalcTotal = false;
            this.БоковаяДлинаБрюк.Caption = "БоковаяДлинаБрюк";
            this.БоковаяДлинаБрюк.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.БоковаяДлинаБрюк.Name = "БоковаяДлинаБрюк";
            this.БоковаяДлинаБрюк.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.БоковаяДлинаБрюк.PropertyType = typeof(decimal);
            this.БоковаяДлинаБрюк.SearchCondition.OwnerComponent = this.БоковаяДлинаБрюк;
            this.БоковаяДлинаБрюк.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватШеиМин
            // 
            this.ОбхватШеиМин.AutoGenerated = true;
            this.ОбхватШеиМин.CalcTotal = false;
            this.ОбхватШеиМин.Caption = "ОбхватШеиМин";
            this.ОбхватШеиМин.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватШеиМин.Name = "ОбхватШеиМин";
            this.ОбхватШеиМин.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватШеиМин.PropertyType = typeof(decimal);
            this.ОбхватШеиМин.SearchCondition.OwnerComponent = this.ОбхватШеиМин;
            this.ОбхватШеиМин.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВнутренняяДлинаБрюк
            // 
            this.ВнутренняяДлинаБрюк.AutoGenerated = true;
            this.ВнутренняяДлинаБрюк.CalcTotal = false;
            this.ВнутренняяДлинаБрюк.Caption = "ВнутренняяДлинаБрюк";
            this.ВнутренняяДлинаБрюк.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВнутренняяДлинаБрюк.Name = "ВнутренняяДлинаБрюк";
            this.ВнутренняяДлинаБрюк.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ВнутренняяДлинаБрюк.PropertyType = typeof(decimal);
            this.ВнутренняяДлинаБрюк.SearchCondition.OwnerComponent = this.ВнутренняяДлинаБрюк;
            this.ВнутренняяДлинаБрюк.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДлинаРукава
            // 
            this.ДлинаРукава.AutoGenerated = true;
            this.ДлинаРукава.CalcTotal = false;
            this.ДлинаРукава.Caption = "ДлинаРукава";
            this.ДлинаРукава.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДлинаРукава.Name = "ДлинаРукава";
            this.ДлинаРукава.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДлинаРукава.PropertyType = typeof(decimal);
            this.ДлинаРукава.SearchCondition.OwnerComponent = this.ДлинаРукава;
            this.ДлинаРукава.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватГрудиМакс
            // 
            this.ОбхватГрудиМакс.AutoGenerated = true;
            this.ОбхватГрудиМакс.CalcTotal = false;
            this.ОбхватГрудиМакс.Caption = "ОбхватГрудиМакс";
            this.ОбхватГрудиМакс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватГрудиМакс.Name = "ОбхватГрудиМакс";
            this.ОбхватГрудиМакс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватГрудиМакс.PropertyType = typeof(decimal);
            this.ОбхватГрудиМакс.SearchCondition.OwnerComponent = this.ОбхватГрудиМакс;
            this.ОбхватГрудиМакс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РостМин
            // 
            this.РостМин.AutoGenerated = true;
            this.РостМин.CalcTotal = false;
            this.РостМин.Caption = "РостМин";
            this.РостМин.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.РостМин.Name = "РостМин";
            this.РостМин.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.РостМин.PropertyType = typeof(decimal);
            this.РостМин.SearchCondition.OwnerComponent = this.РостМин;
            this.РостМин.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватШеиМакс
            // 
            this.ОбхватШеиМакс.AutoGenerated = true;
            this.ОбхватШеиМакс.CalcTotal = false;
            this.ОбхватШеиМакс.Caption = "ОбхватШеиМакс";
            this.ОбхватШеиМакс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватШеиМакс.Name = "ОбхватШеиМакс";
            this.ОбхватШеиМакс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватШеиМакс.PropertyType = typeof(decimal);
            this.ОбхватШеиМакс.SearchCondition.OwnerComponent = this.ОбхватШеиМакс;
            this.ОбхватШеиМакс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДлинаСтупни
            // 
            this.ДлинаСтупни.AutoGenerated = true;
            this.ДлинаСтупни.CalcTotal = false;
            this.ДлинаСтупни.Caption = "ДлинаСтупни";
            this.ДлинаСтупни.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДлинаСтупни.Name = "ДлинаСтупни";
            this.ДлинаСтупни.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДлинаСтупни.PropertyType = typeof(decimal);
            this.ДлинаСтупни.SearchCondition.OwnerComponent = this.ДлинаСтупни;
            this.ДлинаСтупни.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВидРазмернойСетки
            // 
            this.ВидРазмернойСетки.AutoGenerated = true;
            this.ВидРазмернойСетки.Caption = "ВидРазмернойСетки";
            this.ВидРазмернойСетки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВидРазмернойСетки.Name = "ВидРазмернойСетки";
            this.ВидРазмернойСетки.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки);
            this.ВидРазмернойСетки.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки);
            this.ВидРазмернойСетки.SearchCondition.OwnerComponent = this.ВидРазмернойСетки;
            this.ВидРазмернойСетки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput15
            // 
            this.nsgInput15.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput15.ConfigurationName = "";
            this.nsgInput15.DisableLeaveControlEvent = false;
            this.nsgInput15.FullName = "ДлинаСтупни";
            this.nsgInput15.FullTextSearch = false;
            this.nsgInput15.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput15.IsButton = false;
            this.nsgInput15.IsInitialized = true;
            this.nsgInput15.IsPassword = false;
            this.nsgInput15.Location = new System.Drawing.Point(103, 11);
            this.nsgInput15.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput15.Mask = "";
            this.nsgInput15.MetaDataName = "";
            this.nsgInput15.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput15.Name = "NsgInput";
            this.nsgInput15.ObjectImages = null;
            this.nsgInput15.ObjectIndex = null;
            this.nsgInput15.ObjectStrings = null;
            this.nsgInput15.Requsite = "ДлинаСтупни";
            this.nsgInput15.SearchFieldName = "";
            this.nsgInput15.ShowMultipleObjectInComboBox = false;
            this.nsgInput15.ShowRowCount = 10;
            this.nsgInput15.Size = new System.Drawing.Size(40, 20);
            this.nsgInput15.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput15.TabIndex = 38;
            this.nsgInput15.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label3";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Длина стопы см.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 48);
            this.label14.Name = "label1";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Вид размерной сетки";
            // 
            // nsgInput17
            // 
            this.nsgInput17.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput17.ConfigurationName = "TechControl";
            this.nsgInput17.DisableLeaveControlEvent = false;
            this.nsgInput17.FullName = "Учет.Размеры.ВидСвойствНоменклатуры";
            this.nsgInput17.FullTextSearch = false;
            this.nsgInput17.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput17.IsButton = false;
            this.nsgInput17.IsInitialized = true;
            this.nsgInput17.IsPassword = false;
            this.nsgInput17.Location = new System.Drawing.Point(421, 42);
            this.nsgInput17.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput17.Mask = "";
            this.nsgInput17.MetaDataName = "Метаданные";
            this.nsgInput17.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput17.Name = "NsgInput";
            this.nsgInput17.ObjectImages = null;
            this.nsgInput17.ObjectIndex = null;
            this.nsgInput17.ObjectStrings = null;
            this.nsgInput17.Requsite = "ВидСвойствНоменклатуры";
            this.nsgInput17.SearchFieldName = "";
            this.nsgInput17.ShowMultipleObjectInComboBox = false;
            this.nsgInput17.ShowRowCount = 10;
            this.nsgInput17.Size = new System.Drawing.Size(205, 20);
            this.nsgInput17.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput17.TabIndex = 15;
            this.nsgInput17.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // РазмерыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 662);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nsgInput17);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.label1);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.nsgInput17, 0);
            this.Controls.SetChildIndex(this.label14, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpПараметры.ResumeLayout(false);
            this.tpПараметры.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            this.tpПарметрыНоги.ResumeLayout(false);
            this.tpПарметрыНоги.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected NsgInput nsgInput1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected NsgInput nsgInput2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tpПараметры;
        private System.Windows.Forms.TabPage tpПарметрыНоги;
        protected System.Windows.Forms.TabControl tabControl1;
        protected NsgInput nsgInput5;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected NsgInput nsgInput4;
        protected NsgInput nsgInput3;
        private System.Windows.Forms.Label label3;
        protected NsgInput nsgInput9;
        protected NsgInput nsgInput10;
        protected System.Windows.Forms.Label label8;
        protected NsgInput nsgInput7;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label7;
        protected NsgInput nsgInput16;
        protected System.Windows.Forms.Label label12;
        protected NsgInput nsgInput11;
        protected NsgInput nsgInput14;
        protected System.Windows.Forms.Label label11;
        protected NsgInput nsgInput13;
        protected System.Windows.Forms.Label label10;
        protected NsgInput nsgInput12;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.Boolean ЭтоГруппа;
        protected NsgColumnDescriptor.Guid ИдентификаторРодителя;
        protected NsgColumnDescriptor.Byte Уровень;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String Код;
        protected NsgColumnDescriptor.String Наименование;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected ВидСвойствНоменклатуры.ColumnDescriptor ВидСвойствНоменклатуры;
        protected NsgColumnDescriptor.Decimal РостМакс;
        protected NsgColumnDescriptor.Decimal ОбхватГрудиМин;
        protected NsgColumnDescriptor.Decimal ОбхватТалииМин;
        protected NsgColumnDescriptor.Decimal ОбхватТалииМакс;
        protected NsgColumnDescriptor.Decimal ОбхватБедерМин;
        protected NsgColumnDescriptor.Decimal ОбхватБедерМакс;
        protected NsgColumnDescriptor.Decimal БоковаяДлинаБрюк;
        protected NsgColumnDescriptor.Decimal ОбхватШеиМин;
        protected NsgColumnDescriptor.Decimal ВнутренняяДлинаБрюк;
        protected NsgColumnDescriptor.Decimal ДлинаРукава;
        protected NsgColumnDescriptor.Decimal ОбхватГрудиМакс;
        protected NsgColumnDescriptor.Decimal РостМин;
        protected NsgColumnDescriptor.Decimal ОбхватШеиМакс;
        protected NsgColumnDescriptor.Decimal ДлинаСтупни;
        protected УчетСпецодеждыИСИЗ.ВидыРазмернойСетки.ColumnDescriptor ВидРазмернойСетки;
        protected Размеры.ColumnDescriptor Родитель;
        protected NsgInput nsgInput15;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label14;
        protected NsgInput nsgInput17;
    }
}