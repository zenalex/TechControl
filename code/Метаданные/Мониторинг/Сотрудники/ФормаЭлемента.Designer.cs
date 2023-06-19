using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class СотрудникиФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СотрудникиФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаРазмеров = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаРазмеров = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаРазмеров = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ВидСвойствНоменклатуры = new TechControl.Метаданные.Учет.ВидСвойствНоменклатуры.ColumnDescriptor();
            this.Размер_vmoТаблицаРазмеров = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpОсновные = new System.Windows.Forms.TabPage();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.tpРазмеры = new System.Windows.Forms.TabPage();
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
            this.Фамилия = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Отчество = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерТелефона = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.Имя = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Статус = new TechControl.Метаданные.Мониторинг.СтатусСотрудника.ColumnDescriptor();
            this.ИдентификаторСтрока = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.IDСотрудника = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Размер = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.АккаунтПользователя = new TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor();
            this.ТабельныйНомер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаРождения = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаПриемаНаРаботу = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаУвольнения = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ТаблицаРазмеров = new TechControl.Метаданные._SystemTables.МониторингСотрудникиТаблицаРазмеров.ColumnDescriptor();
            this.ОбъектВыдачиСпецодежды = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОсновнойОбъект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ЗагрузочныйИдентификатор = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Родитель = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРазмеров)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpОсновные.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            this.tpРазмеры.SuspendLayout();
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
            this.nsgEdit.Location = new System.Drawing.Point(737, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(853, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(932, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(467, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(562, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(646, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 480);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(932, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(467, 1);
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
            this.Comment.FullName = "Мониторинг.Сотрудники.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(932, 23);
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
            // elementRightsButton
            // 
            this.elementRightsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elementRightsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elementRightsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.elementRightsButton.Container = this.documentButton;
            this.elementRightsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.elementRightsButton.Location = new System.Drawing.Point(447, 1);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Фамилия);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Отчество);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерТелефона);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Должность);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Имя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Статус);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторСтрока);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.IDСотрудника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Размер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.АккаунтПользователя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТабельныйНомер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаРождения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаПриемаНаРаботу);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаУвольнения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаРазмеров);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектВыдачиСпецодежды);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОсновнойОбъект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЗагрузочныйИдентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.Сотрудники";
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
            nsgIGridColumn1.InitiateRowEdit = true;
            nsgIGridColumn1.Name = "Владелец";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Visible = false;
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
            nsgIGridColumn2.InitiateRowEdit = true;
            nsgIGridColumn2.Name = "ВидСвойствНоменклатуры";
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
            nsgIGridColumn3.InitiateRowEdit = true;
            nsgIGridColumn3.Name = "Размер";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(7, 7);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(903, 432);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаРазмеров;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            this.vmoТаблицаРазмеров.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТаблицаРазмеров.MetaDataName = "Метаданные";
            this.vmoТаблицаРазмеров.FullName = "_SystemTables.МониторингСотрудникиТаблицаРазмеров.Владелец";
            // 
            // vmoТаблицаРазмеров
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингСотрудникиТаблицаРазмеров.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.Сотрудники.ТаблицаРазмеров";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Идентификатор_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Владелец);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.ВидСвойствНоменклатуры);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Размер_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.IsActive = true;
            this.vmoТаблицаРазмеров.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаРазмеров.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoТаблицаРазмеров
            // 
            this.Идентификатор_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаРазмеров.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаРазмеров.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаРазмеров.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаРазмеров.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаРазмеров;
            this.Идентификатор_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаРазмеров.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаРазмеров
            // 
            this.Автоинкремент_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаРазмеров.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаРазмеров.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаРазмеров.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаРазмеров.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаРазмеров.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаРазмеров;
            this.Автоинкремент_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаРазмеров.Visible = false;
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
            // Размер_vmoТаблицаРазмеров
            // 
            this.Размер_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Размер_vmoТаблицаРазмеров.Caption = "Размер";
            this.Размер_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Размер_vmoТаблицаРазмеров.Name = "Размер";
            this.Размер_vmoТаблицаРазмеров.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаРазмеров.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Размер_vmoТаблицаРазмеров;
            this.Размер_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер телефона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Должность:";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.Сотрудники.Наименование";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(132, 13);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "Метаданные";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "Наименование";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(200, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 15;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.Сотрудники.Имя";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(132, 46);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Имя";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(130, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 16;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.Сотрудники.Фамилия";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(132, 80);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Фамилия";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(130, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 17;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Мониторинг.Сотрудники.Отчество";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(132, 112);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Отчество";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(130, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 18;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Мониторинг.Сотрудники.НомерТелефона";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(132, 148);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "НомерТелефона";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(130, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 19;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Мониторинг.Сотрудники.Должность";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(132, 180);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Должность";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(305, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 20;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpОсновные);
            this.tabControl1.Controls.Add(this.tpРазмеры);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(925, 471);
            this.tabControl1.TabIndex = 21;
            // 
            // tpОсновные
            // 
            this.tpОсновные.AllowDrop = true;
            this.tpОсновные.Controls.Add(this.nsgInput8);
            this.tpОсновные.Controls.Add(this.label8);
            this.tpОсновные.Controls.Add(this.nsgInput7);
            this.tpОсновные.Controls.Add(this.label7);
            this.tpОсновные.Controls.Add(this.nsgInput1);
            this.tpОсновные.Controls.Add(this.nsgInput6);
            this.tpОсновные.Controls.Add(this.label1);
            this.tpОсновные.Controls.Add(this.nsgInput5);
            this.tpОсновные.Controls.Add(this.label2);
            this.tpОсновные.Controls.Add(this.nsgInput4);
            this.tpОсновные.Controls.Add(this.label3);
            this.tpОсновные.Controls.Add(this.nsgInput3);
            this.tpОсновные.Controls.Add(this.label4);
            this.tpОсновные.Controls.Add(this.nsgInput2);
            this.tpОсновные.Controls.Add(this.label5);
            this.tpОсновные.Controls.Add(this.label6);
            this.tpОсновные.Enabled = true;
            this.tpОсновные.Location = new System.Drawing.Point(4, 22);
            this.tpОсновные.Name = "tpОсновные";
            this.tpОсновные.Padding = new System.Windows.Forms.Padding(3);
            this.tpОсновные.Size = new System.Drawing.Size(917, 445);
            this.tpОсновные.TabIndex = 0;
            this.tpОсновные.Text = "Основные";
            this.tpОсновные.UseVisualStyleBackColor = true;
            this.tpОсновные.Visible = false;
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "TechControl";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "Мониторинг.Сотрудники.Должность";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(132, 242);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "Метаданные";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "Должность";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(305, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 24;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 242);
            this.label8.Name = "label6";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Объект выдачи спецодежды:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Мониторинг.Сотрудники.Должность";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(132, 211);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "Должность";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(305, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 22;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 218);
            this.label7.Name = "label6";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Основной объект:";
            // 
            // tpРазмеры
            // 
            this.tpРазмеры.AllowDrop = true;
            this.tpРазмеры.Controls.Add(this.nsgIGrid1);
            this.tpРазмеры.Enabled = true;
            this.tpРазмеры.Location = new System.Drawing.Point(4, 22);
            this.tpРазмеры.Name = "tpРазмеры";
            this.tpРазмеры.Padding = new System.Windows.Forms.Padding(3);
            this.tpРазмеры.Size = new System.Drawing.Size(917, 445);
            this.tpРазмеры.TabIndex = 1;
            this.tpРазмеры.Text = "Размеры";
            this.tpРазмеры.UseVisualStyleBackColor = true;
            this.tpРазмеры.Visible = true;
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
            // Фамилия
            // 
            this.Фамилия.AutoGenerated = true;
            this.Фамилия.Caption = "Фамилия";
            this.Фамилия.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Фамилия.PropertyType = typeof(string);
            this.Фамилия.SearchCondition.OwnerComponent = this.Фамилия;
            this.Фамилия.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Отчество
            // 
            this.Отчество.AutoGenerated = true;
            this.Отчество.Caption = "Отчество";
            this.Отчество.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Отчество.Name = "Отчество";
            this.Отчество.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Отчество.PropertyType = typeof(string);
            this.Отчество.SearchCondition.OwnerComponent = this.Отчество;
            this.Отчество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерТелефона
            // 
            this.НомерТелефона.AutoGenerated = true;
            this.НомерТелефона.Caption = "НомерТелефона";
            this.НомерТелефона.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерТелефона.Name = "НомерТелефона";
            this.НомерТелефона.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерТелефона.PropertyType = typeof(string);
            this.НомерТелефона.SearchCondition.OwnerComponent = this.НомерТелефона;
            this.НомерТелефона.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность
            // 
            this.Должность.AutoGenerated = true;
            this.Должность.Caption = "Должность";
            this.Должность.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Должность.Name = "Должность";
            this.Должность.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.SearchCondition.OwnerComponent = this.Должность;
            this.Должность.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Имя
            // 
            this.Имя.AutoGenerated = true;
            this.Имя.Caption = "Имя";
            this.Имя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Имя.Name = "Имя";
            this.Имя.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Имя.PropertyType = typeof(string);
            this.Имя.SearchCondition.OwnerComponent = this.Имя;
            this.Имя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Статус
            // 
            this.Статус.AutoGenerated = true;
            this.Статус.Caption = "Статус";
            this.Статус.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Статус.Name = "Статус";
            this.Статус.NSGType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.Статус.PropertyType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.Статус.SearchCondition.OwnerComponent = this.Статус;
            this.Статус.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИдентификаторСтрока
            // 
            this.ИдентификаторСтрока.AutoGenerated = true;
            this.ИдентификаторСтрока.Caption = "ИдентификаторСтрока";
            this.ИдентификаторСтрока.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторСтрока.Name = "ИдентификаторСтрока";
            this.ИдентификаторСтрока.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИдентификаторСтрока.PropertyType = typeof(string);
            this.ИдентификаторСтрока.SearchCondition.OwnerComponent = this.ИдентификаторСтрока;
            this.ИдентификаторСтрока.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // IDСотрудника
            // 
            this.IDСотрудника.AutoGenerated = true;
            this.IDСотрудника.CalcTotal = false;
            this.IDСотрудника.Caption = "IDСотрудника";
            this.IDСотрудника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.IDСотрудника.Name = "IDСотрудника";
            this.IDСотрудника.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.IDСотрудника.PropertyType = typeof(long);
            this.IDСотрудника.SearchCondition.OwnerComponent = this.IDСотрудника;
            this.IDСотрудника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер
            // 
            this.Размер.AutoGenerated = true;
            this.Размер.Caption = "Размер";
            this.Размер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Размер.Name = "Размер";
            this.Размер.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.SearchCondition.OwnerComponent = this.Размер;
            this.Размер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // АккаунтПользователя
            // 
            this.АккаунтПользователя.AutoGenerated = true;
            this.АккаунтПользователя.Caption = "АккаунтПользователя";
            this.АккаунтПользователя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.АккаунтПользователя.Name = "АккаунтПользователя";
            this.АккаунтПользователя.NSGType = typeof(TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя);
            this.АккаунтПользователя.PropertyType = typeof(TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя);
            this.АккаунтПользователя.SearchCondition.OwnerComponent = this.АккаунтПользователя;
            this.АккаунтПользователя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТабельныйНомер
            // 
            this.ТабельныйНомер.AutoGenerated = true;
            this.ТабельныйНомер.Caption = "ТабельныйНомер";
            this.ТабельныйНомер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТабельныйНомер.Name = "ТабельныйНомер";
            this.ТабельныйНомер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ТабельныйНомер.PropertyType = typeof(string);
            this.ТабельныйНомер.SearchCondition.OwnerComponent = this.ТабельныйНомер;
            this.ТабельныйНомер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаРождения
            // 
            this.ДатаРождения.AutoGenerated = true;
            this.ДатаРождения.Caption = "ДатаРождения";
            this.ДатаРождения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДатаРождения.Name = "ДатаРождения";
            this.ДатаРождения.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаРождения.PropertyType = typeof(System.DateTime);
            this.ДатаРождения.SearchCondition.OwnerComponent = this.ДатаРождения;
            this.ДатаРождения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаПриемаНаРаботу
            // 
            this.ДатаПриемаНаРаботу.AutoGenerated = true;
            this.ДатаПриемаНаРаботу.Caption = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДатаПриемаНаРаботу.Name = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПриемаНаРаботу.PropertyType = typeof(System.DateTime);
            this.ДатаПриемаНаРаботу.SearchCondition.OwnerComponent = this.ДатаПриемаНаРаботу;
            this.ДатаПриемаНаРаботу.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаУвольнения
            // 
            this.ДатаУвольнения.AutoGenerated = true;
            this.ДатаУвольнения.Caption = "ДатаУвольнения";
            this.ДатаУвольнения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДатаУвольнения.Name = "ДатаУвольнения";
            this.ДатаУвольнения.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаУвольнения.PropertyType = typeof(System.DateTime);
            this.ДатаУвольнения.SearchCondition.OwnerComponent = this.ДатаУвольнения;
            this.ДатаУвольнения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаРазмеров
            // 
            this.ТаблицаРазмеров.AutoGenerated = true;
            this.ТаблицаРазмеров.Caption = "ТаблицаРазмеров";
            this.ТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаРазмеров.Name = "ТаблицаРазмеров";
            this.ТаблицаРазмеров.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингСотрудникиТаблицаРазмеров);
            this.ТаблицаРазмеров.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингСотрудникиТаблицаРазмеров);
            this.ТаблицаРазмеров.SearchCondition.OwnerComponent = this.ТаблицаРазмеров;
            this.ТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаРазмеров.Visible = false;
            // 
            // ОбъектВыдачиСпецодежды
            // 
            this.ОбъектВыдачиСпецодежды.AutoGenerated = true;
            this.ОбъектВыдачиСпецодежды.Caption = "ОбъектВыдачиСпецодежды";
            this.ОбъектВыдачиСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбъектВыдачиСпецодежды.Name = "ОбъектВыдачиСпецодежды";
            this.ОбъектВыдачиСпецодежды.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачиСпецодежды.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачиСпецодежды.SearchCondition.OwnerComponent = this.ОбъектВыдачиСпецодежды;
            this.ОбъектВыдачиСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОсновнойОбъект
            // 
            this.ОсновнойОбъект.AutoGenerated = true;
            this.ОсновнойОбъект.Caption = "ОсновнойОбъект";
            this.ОсновнойОбъект.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОсновнойОбъект.Name = "ОсновнойОбъект";
            this.ОсновнойОбъект.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект.SearchCondition.OwnerComponent = this.ОсновнойОбъект;
            this.ОсновнойОбъект.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЗагрузочныйИдентификатор
            // 
            this.ЗагрузочныйИдентификатор.AutoGenerated = true;
            this.ЗагрузочныйИдентификатор.Caption = "ЗагрузочныйИдентификатор";
            this.ЗагрузочныйИдентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЗагрузочныйИдентификатор.Name = "ЗагрузочныйИдентификатор";
            this.ЗагрузочныйИдентификатор.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ЗагрузочныйИдентификатор.PropertyType = typeof(string);
            this.ЗагрузочныйИдентификатор.SearchCondition.OwnerComponent = this.ЗагрузочныйИдентификатор;
            this.ЗагрузочныйИдентификатор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СотрудникиФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.tabControl1);
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
            this.Controls.SetChildIndex(this.tabControl1, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРазмеров)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpОсновные.ResumeLayout(false);
            this.tpОсновные.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            this.tpРазмеры.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpОсновные;
        private System.Windows.Forms.TabPage tpРазмеры;
        private NsgIGrid nsgIGrid1;
        private NsgInput nsgInput1;
        private NsgInput nsgInput2;
        private NsgInput nsgInput3;
        private NsgInput nsgInput4;
        private NsgInput nsgInput5;
        private NsgInput nsgInput6;
        protected Учет.Размеры.ColumnDescriptor Размер_vmoТаблицаРазмеров;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаРазмеров;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаРазмеров;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected Учет.ВидСвойствНоменклатуры.ColumnDescriptor ВидСвойствНоменклатуры;
        private NsgVisualMultipleObject vmoТаблицаРазмеров;
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
        protected NsgColumnDescriptor.String Фамилия;
        protected NsgColumnDescriptor.String Отчество;
        protected NsgColumnDescriptor.String НомерТелефона;
        protected Должности.ColumnDescriptor Должность;
        protected NsgColumnDescriptor.String Имя;
        protected СтатусСотрудника.ColumnDescriptor Статус;
        protected NsgColumnDescriptor.String ИдентификаторСтрока;
        protected NsgColumnDescriptor.Int64 IDСотрудника;
        protected Учет.Размеры.ColumnDescriptor Размер;
        protected СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        protected NsgColumnDescriptor.String ТабельныйНомер;
        protected NsgColumnDescriptor.DateTime ДатаРождения;
        protected NsgColumnDescriptor.DateTime ДатаПриемаНаРаботу;
        protected NsgColumnDescriptor.DateTime ДатаУвольнения;
        protected _SystemTables.МониторингСотрудникиТаблицаРазмеров.ColumnDescriptor ТаблицаРазмеров;
        protected Объекты.ColumnDescriptor ОбъектВыдачиСпецодежды;
        protected Объекты.ColumnDescriptor ОсновнойОбъект;
        protected NsgColumnDescriptor.String ЗагрузочныйИдентификатор;
        protected Сотрудники.ColumnDescriptor Родитель;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label8;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
    }
}