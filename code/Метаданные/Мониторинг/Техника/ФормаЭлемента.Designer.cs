using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ТехникаФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ТехникаФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding3 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor5 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor6 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgIGridСистемыСлежения = new NsgSoft.Forms.NsgIGrid();
            this.vmoСистемыСлежения = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_nsgVisualMultipleObject1 = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_nsgVisualMultipleObject1 = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ТипСистемыСлежения = new TechControl.Метаданные.Мониторинг.ТипСистемыСлежения.ColumnDescriptor();
            this.ИдентификаторСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nsgIGridТарифы = new NsgSoft.Forms.NsgIGrid();
            this.vmoТарифы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Тариф = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Стоимость = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИспользоватьПоУмолчанию = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.nsgInput12 = new NsgSoft.Forms.NsgInput();
            this.nsgInput13 = new NsgSoft.Forms.NsgInput();
            this.label13 = new System.Windows.Forms.Label();
            this.nsgInput14 = new NsgSoft.Forms.NsgInput();
            this.label14 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpОписание = new System.Windows.Forms.TabPage();
            this.tpСистемыСлежения = new System.Windows.Forms.TabPage();
            this.tpТарифы = new System.Windows.Forms.TabPage();
            this.tpДолжности = new System.Windows.Forms.TabPage();
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
            this.Марка = new TechControl.Метаданные.Мониторинг.Марка.ColumnDescriptor();
            this.Модель = new TechControl.Метаданные.Мониторинг.Модель.ColumnDescriptor();
            this.ГодВыпуска = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ГосНомер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Подрядчик = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Номер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НормативныйРасходТоплива = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбъемТопливногоБака = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Примечание = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Статус = new TechControl.Метаданные.Мониторинг.СтатусТехники.ColumnDescriptor();
            this.Тарифы = new TechControl.Метаданные._SystemTables.МониторингТехникаТарифы.ColumnDescriptor();
            this.ТипСобственности = new TechControl.Метаданные.Мониторинг.ТипСобственности.ColumnDescriptor();
            this.ГруппаСпецТехники = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.СистемыСлежения = new TechControl.Метаданные._SystemTables.МониторингТехникаСистемыСлежения.ColumnDescriptor();
            this.Иконка = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.АккаунтПользователя = new TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor();
            this.ОтслеживатьХодки = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ТаблицаДопущенныеДоУправленияДолжности = new TechControl.Метаданные._SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности.ColumnDescriptor();
            this.Родитель = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.vmoДолжности = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoДолжности = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoДолжности = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoДолжности = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoДолжности = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGridСистемыСлежения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСистемыСлежения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGridТарифы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpОписание.SuspendLayout();
            this.tpСистемыСлежения.SuspendLayout();
            this.tpТарифы.SuspendLayout();
            this.tpДолжности.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДолжности)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(570, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(686, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(765, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(300, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(395, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(479, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 404);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(765, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(300, 1);
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
            this.Comment.FullName = "Мониторинг.Техника.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(765, 23);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Марка);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Модель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГодВыпуска);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГосНомер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Подрядчик);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Номер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НормативныйРасходТоплива);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъемТопливногоБака);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Примечание);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Статус);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Тарифы);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТипСобственности);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГруппаСпецТехники);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СистемыСлежения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Иконка);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.АккаунтПользователя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОтслеживатьХодки);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаДопущенныеДоУправленияДолжности);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.Техника";
            // 
            // nsgIGridСистемыСлежения
            // 
            this.nsgIGridСистемыСлежения.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGridСистемыСлежения.AllowSaveColParamsToXML = true;
            this.nsgIGridСистемыСлежения.AllowSaveColPositionToXML = true;
            this.nsgIGridСистемыСлежения.AllowSaveColWidthToXML = true;
            this.nsgIGridСистемыСлежения.AllowSaveSettingsToXML = true;
            this.nsgIGridСистемыСлежения.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGridСистемыСлежения.AutoResizeCols = true;
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
            nsgIGridColumn1.Root = this.nsgIGridСистемыСлежения.Columns.Collection;
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
            nsgIGridColumn2.Name = "ТипСистемыСлежения";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGridСистемыСлежения.Columns.Collection;
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
            nsgIGridColumn3.Name = "ИдентификаторСистемыСлежения";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGridСистемыСлежения.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            this.nsgIGridСистемыСлежения.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGridСистемыСлежения.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGridСистемыСлежения.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGridСистемыСлежения.Filter = false;
            this.nsgIGridСистемыСлежения.FrozenColumns = 0;
            this.nsgIGridСистемыСлежения.Grouping = true;
            this.nsgIGridСистемыСлежения.Hierarhy = true;
            this.nsgIGridСистемыСлежения.ImageList = null;
            this.nsgIGridСистемыСлежения.IsCanMultiSelect = false;
            this.nsgIGridСистемыСлежения.IsCanSingleSelect = false;
            this.nsgIGridСистемыСлежения.LineHeight = 20;
            this.nsgIGridСистемыСлежения.Location = new System.Drawing.Point(5, 3);
            this.nsgIGridСистемыСлежения.MarkReadOnly = false;
            this.nsgIGridСистемыСлежения.MasterObject = null;
            this.nsgIGridСистемыСлежения.Name = "NsgIGrid";
            this.nsgIGridСистемыСлежения.PageSelector = false;
            this.nsgIGridСистемыСлежения.ReadOnly = false;
            this.nsgIGridСистемыСлежения.RowChangeInterval = 200;
            this.nsgIGridСистемыСлежения.RowHeaderImageList = null;
            this.nsgIGridСистемыСлежения.RowMode = false;
            this.nsgIGridСистемыСлежения.ScrollWidth = 0;
            this.nsgIGridСистемыСлежения.SelectedRow = -1;
            this.nsgIGridСистемыСлежения.ShowHeader = true;
            this.nsgIGridСистемыСлежения.ShowLineImages = true;
            this.nsgIGridСистемыСлежения.ShowLineNumbers = false;
            this.nsgIGridСистемыСлежения.ShowPanel = true;
            this.nsgIGridСистемыСлежения.ShowTotals = false;
            this.nsgIGridСистемыСлежения.ShowTree = false;
            this.nsgIGridСистемыСлежения.Size = new System.Drawing.Size(737, 360);
            this.nsgIGridСистемыСлежения.SourceObject = this.vmoСистемыСлежения;
            this.nsgIGridСистемыСлежения.TabIndex = 37;
            this.nsgIGridСистемыСлежения.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoСистемыСлежения.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoСистемыСлежения.MetaDataName = "Метаданные";
            this.vmoСистемыСлежения.FullName = "_SystemTables.МониторингТехникаСистемыСлежения.Владелец";
            // 
            // vmoСистемыСлежения
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингТехникаСистемыСлежения.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.Техника.СистемыСлежения";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Идентификатор_nsgVisualMultipleObject1);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Автоинкремент_nsgVisualMultipleObject1);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Владелец);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.НомерСтроки);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.ТипСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.ИдентификаторСистемыСлежения);
            this.vmoСистемыСлежения.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoСистемыСлежения.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_nsgVisualMultipleObject1
            // 
            this.Идентификатор_nsgVisualMultipleObject1.AutoGenerated = true;
            this.Идентификатор_nsgVisualMultipleObject1.Caption = "Идентификатор";
            this.Идентификатор_nsgVisualMultipleObject1.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_nsgVisualMultipleObject1.Name = "Идентификатор";
            this.Идентификатор_nsgVisualMultipleObject1.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_nsgVisualMultipleObject1.PropertyType = typeof(System.Guid);
            this.Идентификатор_nsgVisualMultipleObject1.SearchCondition.OwnerComponent = this.Идентификатор_nsgVisualMultipleObject1;
            this.Идентификатор_nsgVisualMultipleObject1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_nsgVisualMultipleObject1.Visible = false;
            // 
            // Автоинкремент_nsgVisualMultipleObject1
            // 
            this.Автоинкремент_nsgVisualMultipleObject1.AutoGenerated = true;
            this.Автоинкремент_nsgVisualMultipleObject1.CalcTotal = false;
            this.Автоинкремент_nsgVisualMultipleObject1.Caption = "Автоинкремент";
            this.Автоинкремент_nsgVisualMultipleObject1.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_nsgVisualMultipleObject1.Name = "Автоинкремент";
            this.Автоинкремент_nsgVisualMultipleObject1.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_nsgVisualMultipleObject1.PropertyType = typeof(long);
            this.Автоинкремент_nsgVisualMultipleObject1.SearchCondition.OwnerComponent = this.Автоинкремент_nsgVisualMultipleObject1;
            this.Автоинкремент_nsgVisualMultipleObject1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_nsgVisualMultipleObject1.Visible = false;
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
            // ТипСистемыСлежения
            // 
            this.ТипСистемыСлежения.AutoGenerated = true;
            this.ТипСистемыСлежения.Caption = "ТипСистемыСлежения";
            this.ТипСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТипСистемыСлежения.Name = "ТипСистемыСлежения";
            this.ТипСистемыСлежения.NSGType = typeof(TechControl.Метаданные.Мониторинг.ТипСистемыСлежения);
            this.ТипСистемыСлежения.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ТипСистемыСлежения);
            this.ТипСистемыСлежения.SearchCondition.OwnerComponent = this.ТипСистемыСлежения;
            this.ТипСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИдентификаторСистемыСлежения
            // 
            this.ИдентификаторСистемыСлежения.AutoGenerated = true;
            this.ИдентификаторСистемыСлежения.Caption = "ИдентификаторСистемыСлежения";
            this.ИдентификаторСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторСистемыСлежения.Name = "ИдентификаторСистемыСлежения";
            this.ИдентификаторСистемыСлежения.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИдентификаторСистемыСлежения.PropertyType = typeof(string);
            this.ИдентификаторСистемыСлежения.SearchCondition.OwnerComponent = this.ИдентификаторСистемыСлежения;
            this.ИдентификаторСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGridТарифы
            // 
            this.nsgIGridТарифы.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGridТарифы.AllowSaveColParamsToXML = true;
            this.nsgIGridТарифы.AllowSaveColPositionToXML = true;
            this.nsgIGridТарифы.AllowSaveColWidthToXML = true;
            this.nsgIGridТарифы.AllowSaveSettingsToXML = true;
            this.nsgIGridТарифы.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGridТарифы.AutoResizeCols = true;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.ImportedFromVMO = false;
            nsgIGridColumn4.InitiateRowEdit = true;
            nsgIGridColumn4.Name = "Владелец";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGridТарифы.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Visible = false;
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
            nsgIGridColumn5.InitiateRowEdit = true;
            nsgIGridColumn5.Name = "Тариф";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGridТарифы.Columns.Collection;
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
            nsgIGridColumn6.InitiateRowEdit = true;
            nsgIGridColumn6.Name = "Стоимость";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGridТарифы.Columns.Collection;
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
            nsgIGridColumn7.InitiateRowEdit = true;
            nsgIGridColumn7.Name = "ИспользоватьПоУмолчанию";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGridТарифы.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Width = 100;
            this.nsgIGridТарифы.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGridТарифы.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGridТарифы.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGridТарифы.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGridТарифы.Filter = false;
            this.nsgIGridТарифы.FrozenColumns = 0;
            this.nsgIGridТарифы.Grouping = true;
            this.nsgIGridТарифы.Hierarhy = true;
            this.nsgIGridТарифы.ImageList = null;
            this.nsgIGridТарифы.IsCanMultiSelect = false;
            this.nsgIGridТарифы.IsCanSingleSelect = false;
            this.nsgIGridТарифы.LineHeight = 20;
            this.nsgIGridТарифы.Location = new System.Drawing.Point(6, 6);
            this.nsgIGridТарифы.MarkReadOnly = false;
            this.nsgIGridТарифы.MasterObject = null;
            this.nsgIGridТарифы.Name = "NsgIGrid";
            this.nsgIGridТарифы.PageSelector = false;
            this.nsgIGridТарифы.ReadOnly = false;
            this.nsgIGridТарифы.RowChangeInterval = 200;
            this.nsgIGridТарифы.RowHeaderImageList = null;
            this.nsgIGridТарифы.RowMode = false;
            this.nsgIGridТарифы.ScrollWidth = 0;
            this.nsgIGridТарифы.SelectedRow = -1;
            this.nsgIGridТарифы.ShowHeader = true;
            this.nsgIGridТарифы.ShowLineImages = true;
            this.nsgIGridТарифы.ShowLineNumbers = false;
            this.nsgIGridТарифы.ShowPanel = true;
            this.nsgIGridТарифы.ShowTotals = false;
            this.nsgIGridТарифы.ShowTree = false;
            this.nsgIGridТарифы.Size = new System.Drawing.Size(733, 354);
            this.nsgIGridТарифы.SourceObject = this.vmoТарифы;
            this.nsgIGridТарифы.TabIndex = 38;
            this.nsgIGridТарифы.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТарифы.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТарифы.MetaDataName = "Метаданные";
            this.vmoТарифы.FullName = "_SystemTables.МониторингТехникаТарифы.Владелец";
            // 
            // vmoТарифы
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.МониторингТехникаТарифы.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Мониторинг.Техника.Тарифы";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТарифы.Columns.Collection.Add(this.Идентификатор_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Автоинкремент_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Владелец_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.НомерСтроки_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Тариф);
            this.vmoТарифы.Columns.Collection.Add(this.Стоимость);
            this.vmoТарифы.Columns.Collection.Add(this.ИспользоватьПоУмолчанию);
            this.vmoТарифы.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТарифы.Binding = nsgMasterDetailBinding2;
            // 
            // Идентификатор_vmoТарифы
            // 
            this.Идентификатор_vmoТарифы.AutoGenerated = true;
            this.Идентификатор_vmoТарифы.Caption = "Идентификатор";
            this.Идентификатор_vmoТарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТарифы.Name = "Идентификатор";
            this.Идентификатор_vmoТарифы.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТарифы.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТарифы.SearchCondition.OwnerComponent = this.Идентификатор_vmoТарифы;
            this.Идентификатор_vmoТарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТарифы.Visible = false;
            // 
            // Автоинкремент_vmoТарифы
            // 
            this.Автоинкремент_vmoТарифы.AutoGenerated = true;
            this.Автоинкремент_vmoТарифы.CalcTotal = false;
            this.Автоинкремент_vmoТарифы.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТарифы.Name = "Автоинкремент";
            this.Автоинкремент_vmoТарифы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТарифы.PropertyType = typeof(long);
            this.Автоинкремент_vmoТарифы.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТарифы;
            this.Автоинкремент_vmoТарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТарифы.Visible = false;
            // 
            // Владелец_vmoТарифы
            // 
            this.Владелец_vmoТарифы.AutoGenerated = true;
            this.Владелец_vmoТарифы.Caption = "Владелец";
            this.Владелец_vmoТарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТарифы.Name = "Владелец";
            this.Владелец_vmoТарифы.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТарифы.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТарифы.SearchCondition.OwnerComponent = this.Владелец_vmoТарифы;
            this.Владелец_vmoТарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТарифы
            // 
            this.НомерСтроки_vmoТарифы.AutoGenerated = true;
            this.НомерСтроки_vmoТарифы.CalcTotal = false;
            this.НомерСтроки_vmoТарифы.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТарифы.Name = "НомерСтроки";
            this.НомерСтроки_vmoТарифы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТарифы.PropertyType = typeof(long);
            this.НомерСтроки_vmoТарифы.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТарифы;
            this.НомерСтроки_vmoТарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТарифы.Visible = false;
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
            // Стоимость
            // 
            this.Стоимость.AutoGenerated = true;
            this.Стоимость.CalcTotal = false;
            this.Стоимость.Caption = "Стоимость";
            this.Стоимость.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Стоимость.PropertyType = typeof(decimal);
            this.Стоимость.SearchCondition.OwnerComponent = this.Стоимость;
            this.Стоимость.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИспользоватьПоУмолчанию
            // 
            this.ИспользоватьПоУмолчанию.AutoGenerated = true;
            this.ИспользоватьПоУмолчанию.Caption = "ИспользоватьПоУмолчанию";
            this.ИспользоватьПоУмолчанию.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИспользоватьПоУмолчанию.Name = "ИспользоватьПоУмолчанию";
            this.ИспользоватьПоУмолчанию.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ИспользоватьПоУмолчанию.PropertyType = typeof(bool);
            this.ИспользоватьПоУмолчанию.SearchCondition.OwnerComponent = this.ИспользоватьПоУмолчанию;
            this.ИспользоватьПоУмолчанию.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Статус:";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.Техника.Наименование";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(143, 3);
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
            this.nsgInput2.Size = new System.Drawing.Size(283, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 13;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Государственый номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Марка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Модель:";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.Техника.Статус";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(143, 36);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Статус";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(198, 20);
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
            this.nsgInput4.FullName = "Мониторинг.Техника.ГосНомер";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(556, 69);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ГосНомер";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(129, 20);
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
            this.nsgInput5.FullName = "Мониторинг.Техника.Марка";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(143, 69);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Марка";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(198, 20);
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
            this.nsgInput6.FullName = "Мониторинг.Техника.Модель";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(143, 100);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Модель";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(198, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 20;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Номер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Нормативный расход топлива:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Объем топливного бака:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Подрядчик:";
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Мониторинг.Техника.Номер";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(143, 167);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "Номер";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(198, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 25;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "TechControl";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "Мониторинг.Техника.НормативныйРасходТоплива";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(556, 100);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "Метаданные";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "НормативныйРасходТоплива";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(129, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 26;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "TechControl";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "Мониторинг.Техника.ОбъемТопливногоБака";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(556, 133);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "Метаданные";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "ОбъемТопливногоБака";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(129, 20);
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
            this.nsgInput10.FullName = "Мониторинг.Техника.Подрядчик";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(143, 133);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "Метаданные";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "Подрядчик";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(198, 20);
            this.nsgInput10.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput10.TabIndex = 28;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Группа:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Примечание:";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "TechControl";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "Мониторинг.Техника.ГруппаСпецТехники";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(487, 36);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "Метаданные";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "ГруппаСпецТехники";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(198, 20);
            this.nsgInput11.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput11.TabIndex = 31;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput12
            // 
            this.nsgInput12.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput12.ConfigurationName = "TechControl";
            this.nsgInput12.DisableLeaveControlEvent = false;
            this.nsgInput12.FullName = "Мониторинг.Техника.Примечание";
            this.nsgInput12.FullTextSearch = false;
            this.nsgInput12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput12.IsButton = false;
            this.nsgInput12.IsInitialized = true;
            this.nsgInput12.IsPassword = false;
            this.nsgInput12.Location = new System.Drawing.Point(143, 233);
            this.nsgInput12.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput12.Mask = "";
            this.nsgInput12.MetaDataName = "Метаданные";
            this.nsgInput12.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput12.Name = "NsgInput";
            this.nsgInput12.ObjectImages = null;
            this.nsgInput12.ObjectIndex = null;
            this.nsgInput12.ObjectStrings = null;
            this.nsgInput12.Requsite = "Примечание";
            this.nsgInput12.SearchFieldName = "";
            this.nsgInput12.ShowMultipleObjectInComboBox = false;
            this.nsgInput12.ShowRowCount = 10;
            this.nsgInput12.Size = new System.Drawing.Size(314, 20);
            this.nsgInput12.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput12.TabIndex = 32;
            this.nsgInput12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput13
            // 
            this.nsgInput13.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput13.ConfigurationName = "TechControl";
            this.nsgInput13.DisableLeaveControlEvent = false;
            this.nsgInput13.FullName = "Мониторинг.Техника.ГодВыпуска";
            this.nsgInput13.FullTextSearch = false;
            this.nsgInput13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput13.IsButton = false;
            this.nsgInput13.IsInitialized = true;
            this.nsgInput13.IsPassword = false;
            this.nsgInput13.Location = new System.Drawing.Point(556, 167);
            this.nsgInput13.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput13.Mask = "";
            this.nsgInput13.MetaDataName = "Метаданные";
            this.nsgInput13.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput13.Name = "NsgInput";
            this.nsgInput13.ObjectImages = null;
            this.nsgInput13.ObjectIndex = null;
            this.nsgInput13.ObjectStrings = null;
            this.nsgInput13.Requsite = "ГодВыпуска";
            this.nsgInput13.SearchFieldName = "";
            this.nsgInput13.ShowMultipleObjectInComboBox = false;
            this.nsgInput13.ShowRowCount = 10;
            this.nsgInput13.Size = new System.Drawing.Size(129, 20);
            this.nsgInput13.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput13.TabIndex = 34;
            this.nsgInput13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(406, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Год выпуска:";
            // 
            // nsgInput14
            // 
            this.nsgInput14.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput14.ConfigurationName = "TechControl";
            this.nsgInput14.DisableLeaveControlEvent = false;
            this.nsgInput14.FullName = "Мониторинг.Техника.ТипСобственности";
            this.nsgInput14.FullTextSearch = false;
            this.nsgInput14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput14.IsButton = false;
            this.nsgInput14.IsInitialized = true;
            this.nsgInput14.IsPassword = false;
            this.nsgInput14.Location = new System.Drawing.Point(556, 204);
            this.nsgInput14.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput14.Mask = "";
            this.nsgInput14.MetaDataName = "Метаданные";
            this.nsgInput14.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput14.Name = "NsgInput";
            this.nsgInput14.ObjectImages = null;
            this.nsgInput14.ObjectIndex = null;
            this.nsgInput14.ObjectStrings = null;
            this.nsgInput14.Requsite = "ТипСобственности";
            this.nsgInput14.SearchFieldName = "";
            this.nsgInput14.ShowMultipleObjectInComboBox = false;
            this.nsgInput14.ShowRowCount = 10;
            this.nsgInput14.Size = new System.Drawing.Size(129, 20);
            this.nsgInput14.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput14.TabIndex = 36;
            this.nsgInput14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(406, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Тип собственности:";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.Техника.ОтслеживатьХодки";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(143, 197);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "Метаданные";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "ОтслеживатьХодки";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(18, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 39;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Отслеживать ходки:";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpОписание);
            this.tabControl1.Controls.Add(this.tpСистемыСлежения);
            this.tabControl1.Controls.Add(this.tpТарифы);
            this.tabControl1.Controls.Add(this.tpДолжности);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(753, 392);
            this.tabControl1.TabIndex = 41;
            // 
            // tpОписание
            // 
            this.tpОписание.AllowDrop = true;
            this.tpОписание.Controls.Add(this.nsgInput2);
            this.tpОписание.Controls.Add(this.label1);
            this.tpОписание.Controls.Add(this.label2);
            this.tpОписание.Controls.Add(this.nsgInput1);
            this.tpОписание.Controls.Add(this.label3);
            this.tpОписание.Controls.Add(this.label4);
            this.tpОписание.Controls.Add(this.label5);
            this.tpОписание.Controls.Add(this.nsgInput14);
            this.tpОписание.Controls.Add(this.label6);
            this.tpОписание.Controls.Add(this.label14);
            this.tpОписание.Controls.Add(this.nsgInput3);
            this.tpОписание.Controls.Add(this.nsgInput13);
            this.tpОписание.Controls.Add(this.nsgInput4);
            this.tpОписание.Controls.Add(this.label13);
            this.tpОписание.Controls.Add(this.nsgInput5);
            this.tpОписание.Controls.Add(this.nsgInput12);
            this.tpОписание.Controls.Add(this.nsgInput6);
            this.tpОписание.Controls.Add(this.nsgInput11);
            this.tpОписание.Controls.Add(this.label7);
            this.tpОписание.Controls.Add(this.label12);
            this.tpОписание.Controls.Add(this.label8);
            this.tpОписание.Controls.Add(this.label11);
            this.tpОписание.Controls.Add(this.label9);
            this.tpОписание.Controls.Add(this.nsgInput10);
            this.tpОписание.Controls.Add(this.label10);
            this.tpОписание.Controls.Add(this.nsgInput9);
            this.tpОписание.Controls.Add(this.nsgInput7);
            this.tpОписание.Controls.Add(this.nsgInput8);
            this.tpОписание.Enabled = true;
            this.tpОписание.Location = new System.Drawing.Point(4, 22);
            this.tpОписание.Name = "tpОписание";
            this.tpОписание.Padding = new System.Windows.Forms.Padding(3);
            this.tpОписание.Size = new System.Drawing.Size(745, 366);
            this.tpОписание.TabIndex = 0;
            this.tpОписание.Text = "Описание";
            this.tpОписание.UseVisualStyleBackColor = true;
            this.tpОписание.Visible = false;
            // 
            // tpСистемыСлежения
            // 
            this.tpСистемыСлежения.AllowDrop = true;
            this.tpСистемыСлежения.Controls.Add(this.nsgIGridТарифы);
            this.tpСистемыСлежения.Enabled = true;
            this.tpСистемыСлежения.Location = new System.Drawing.Point(4, 22);
            this.tpСистемыСлежения.Name = "tpСистемыСлежения";
            this.tpСистемыСлежения.Padding = new System.Windows.Forms.Padding(3);
            this.tpСистемыСлежения.Size = new System.Drawing.Size(745, 366);
            this.tpСистемыСлежения.TabIndex = 1;
            this.tpСистемыСлежения.Text = "СистемыСлежения";
            this.tpСистемыСлежения.UseVisualStyleBackColor = true;
            this.tpСистемыСлежения.Visible = false;
            // 
            // tpТарифы
            // 
            this.tpТарифы.AllowDrop = true;
            this.tpТарифы.Controls.Add(this.nsgIGridСистемыСлежения);
            this.tpТарифы.Enabled = true;
            this.tpТарифы.Location = new System.Drawing.Point(4, 22);
            this.tpТарифы.Name = "tpТарифы";
            this.tpТарифы.Size = new System.Drawing.Size(745, 366);
            this.tpТарифы.TabIndex = 2;
            this.tpТарифы.Text = "Тарифы";
            this.tpТарифы.UseVisualStyleBackColor = true;
            this.tpТарифы.Visible = false;
            // 
            // tpДолжности
            // 
            this.tpДолжности.AllowDrop = true;
            this.tpДолжности.Controls.Add(this.nsgIGrid1);
            this.tpДолжности.Enabled = true;
            this.tpДолжности.Location = new System.Drawing.Point(4, 22);
            this.tpДолжности.Name = "tpДолжности";
            this.tpДолжности.Size = new System.Drawing.Size(745, 366);
            this.tpДолжности.TabIndex = 3;
            this.tpДолжности.Text = "Должности";
            this.tpДолжности.UseVisualStyleBackColor = true;
            this.tpДолжности.Visible = true;
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
            // Марка
            // 
            this.Марка.AutoGenerated = true;
            this.Марка.Caption = "Марка";
            this.Марка.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Марка.Name = "Марка";
            this.Марка.NSGType = typeof(TechControl.Метаданные.Мониторинг.Марка);
            this.Марка.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Марка);
            this.Марка.SearchCondition.OwnerComponent = this.Марка;
            this.Марка.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Модель
            // 
            this.Модель.AutoGenerated = true;
            this.Модель.Caption = "Модель";
            this.Модель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Модель.Name = "Модель";
            this.Модель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Модель);
            this.Модель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Модель);
            this.Модель.SearchCondition.OwnerComponent = this.Модель;
            this.Модель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГодВыпуска
            // 
            this.ГодВыпуска.AutoGenerated = true;
            this.ГодВыпуска.Caption = "ГодВыпуска";
            this.ГодВыпуска.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГодВыпуска.Name = "ГодВыпуска";
            this.ГодВыпуска.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГодВыпуска.PropertyType = typeof(string);
            this.ГодВыпуска.SearchCondition.OwnerComponent = this.ГодВыпуска;
            this.ГодВыпуска.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГосНомер
            // 
            this.ГосНомер.AutoGenerated = true;
            this.ГосНомер.Caption = "ГосНомер";
            this.ГосНомер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГосНомер.Name = "ГосНомер";
            this.ГосНомер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГосНомер.PropertyType = typeof(string);
            this.ГосНомер.SearchCondition.OwnerComponent = this.ГосНомер;
            this.ГосНомер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подрядчик
            // 
            this.Подрядчик.AutoGenerated = true;
            this.Подрядчик.Caption = "Подрядчик";
            this.Подрядчик.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Подрядчик.Name = "Подрядчик";
            this.Подрядчик.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Подрядчик.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Подрядчик.SearchCondition.OwnerComponent = this.Подрядчик;
            this.Подрядчик.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номер
            // 
            this.Номер.AutoGenerated = true;
            this.Номер.Caption = "Номер";
            this.Номер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Номер.Name = "Номер";
            this.Номер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Номер.PropertyType = typeof(string);
            this.Номер.SearchCondition.OwnerComponent = this.Номер;
            this.Номер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НормативныйРасходТоплива
            // 
            this.НормативныйРасходТоплива.AutoGenerated = true;
            this.НормативныйРасходТоплива.CalcTotal = false;
            this.НормативныйРасходТоплива.Caption = "НормативныйРасходТоплива";
            this.НормативныйРасходТоплива.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НормативныйРасходТоплива.Name = "НормативныйРасходТоплива";
            this.НормативныйРасходТоплива.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.НормативныйРасходТоплива.PropertyType = typeof(decimal);
            this.НормативныйРасходТоплива.SearchCondition.OwnerComponent = this.НормативныйРасходТоплива;
            this.НормативныйРасходТоплива.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъемТопливногоБака
            // 
            this.ОбъемТопливногоБака.AutoGenerated = true;
            this.ОбъемТопливногоБака.CalcTotal = false;
            this.ОбъемТопливногоБака.Caption = "ОбъемТопливногоБака";
            this.ОбъемТопливногоБака.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбъемТопливногоБака.Name = "ОбъемТопливногоБака";
            this.ОбъемТопливногоБака.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбъемТопливногоБака.PropertyType = typeof(decimal);
            this.ОбъемТопливногоБака.SearchCondition.OwnerComponent = this.ОбъемТопливногоБака;
            this.ОбъемТопливногоБака.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Примечание
            // 
            this.Примечание.AutoGenerated = true;
            this.Примечание.Caption = "Примечание";
            this.Примечание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Примечание.Name = "Примечание";
            this.Примечание.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Примечание.PropertyType = typeof(string);
            this.Примечание.SearchCondition.OwnerComponent = this.Примечание;
            this.Примечание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Статус
            // 
            this.Статус.AutoGenerated = true;
            this.Статус.Caption = "Статус";
            this.Статус.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Статус.Name = "Статус";
            this.Статус.NSGType = typeof(TechControl.Метаданные.Мониторинг.СтатусТехники);
            this.Статус.PropertyType = typeof(TechControl.Метаданные.Мониторинг.СтатусТехники);
            this.Статус.SearchCondition.OwnerComponent = this.Статус;
            this.Статус.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тарифы
            // 
            this.Тарифы.AutoGenerated = true;
            this.Тарифы.Caption = "Тарифы";
            this.Тарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Тарифы.Name = "Тарифы";
            this.Тарифы.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаТарифы);
            this.Тарифы.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаТарифы);
            this.Тарифы.SearchCondition.OwnerComponent = this.Тарифы;
            this.Тарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Тарифы.Visible = false;
            // 
            // ТипСобственности
            // 
            this.ТипСобственности.AutoGenerated = true;
            this.ТипСобственности.Caption = "ТипСобственности";
            this.ТипСобственности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТипСобственности.Name = "ТипСобственности";
            this.ТипСобственности.NSGType = typeof(TechControl.Метаданные.Мониторинг.ТипСобственности);
            this.ТипСобственности.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ТипСобственности);
            this.ТипСобственности.SearchCondition.OwnerComponent = this.ТипСобственности;
            this.ТипСобственности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГруппаСпецТехники
            // 
            this.ГруппаСпецТехники.AutoGenerated = true;
            this.ГруппаСпецТехники.Caption = "ГруппаСпецТехники";
            this.ГруппаСпецТехники.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГруппаСпецТехники.Name = "ГруппаСпецТехники";
            this.ГруппаСпецТехники.NSGType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпецТехники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпецТехники.SearchCondition.OwnerComponent = this.ГруппаСпецТехники;
            this.ГруппаСпецТехники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СистемыСлежения
            // 
            this.СистемыСлежения.AutoGenerated = true;
            this.СистемыСлежения.Caption = "СистемыСлежения";
            this.СистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СистемыСлежения.Name = "СистемыСлежения";
            this.СистемыСлежения.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаСистемыСлежения);
            this.СистемыСлежения.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаСистемыСлежения);
            this.СистемыСлежения.SearchCondition.OwnerComponent = this.СистемыСлежения;
            this.СистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.СистемыСлежения.Visible = false;
            // 
            // Иконка
            // 
            this.Иконка.AutoGenerated = true;
            this.Иконка.CalcTotal = false;
            this.Иконка.Caption = "Иконка";
            this.Иконка.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Иконка.Name = "Иконка";
            this.Иконка.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Иконка.PropertyType = typeof(long);
            this.Иконка.SearchCondition.OwnerComponent = this.Иконка;
            this.Иконка.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // ОтслеживатьХодки
            // 
            this.ОтслеживатьХодки.AutoGenerated = true;
            this.ОтслеживатьХодки.Caption = "ОтслеживатьХодки";
            this.ОтслеживатьХодки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОтслеживатьХодки.Name = "ОтслеживатьХодки";
            this.ОтслеживатьХодки.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ОтслеживатьХодки.PropertyType = typeof(bool);
            this.ОтслеживатьХодки.SearchCondition.OwnerComponent = this.ОтслеживатьХодки;
            this.ОтслеживатьХодки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаДопущенныеДоУправленияДолжности
            // 
            this.ТаблицаДопущенныеДоУправленияДолжности.AutoGenerated = true;
            this.ТаблицаДопущенныеДоУправленияДолжности.Caption = "ТаблицаДопущенныеДоУправленияДолжности";
            this.ТаблицаДопущенныеДоУправленияДолжности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаДопущенныеДоУправленияДолжности.Name = "ТаблицаДопущенныеДоУправленияДолжности";
            this.ТаблицаДопущенныеДоУправленияДолжности.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности);
            this.ТаблицаДопущенныеДоУправленияДолжности.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности);
            this.ТаблицаДопущенныеДоУправленияДолжности.SearchCondition.OwnerComponent = this.ТаблицаДопущенныеДоУправленияДолжности;
            this.ТаблицаДопущенныеДоУправленияДолжности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаДопущенныеДоУправленияДолжности.Visible = false;
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.vmoДолжности.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor6.ConfigurationName = "TechControl";
            this.vmoДолжности.MetaDataName = "Метаданные";
            this.vmoДолжности.FullName = "_SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности.Владелец";
            // 
            // vmoДолжности
            // 
            nsgObjectDescriptor5.ConfigurationName = "TechControl";
            nsgObjectDescriptor5.FullName = "_SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности.Владелец";
            nsgObjectDescriptor5.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.DetailField = nsgObjectDescriptor5;
            nsgObjectDescriptor6.FullName = "Мониторинг.Техника.ТаблицаДопущенныеДоУправленияДолжности";
            nsgObjectDescriptor6.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.MasterField = nsgObjectDescriptor6;
            nsgMasterDetailBinding3.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoДолжности.Columns.Collection.Add(this.Идентификатор_vmoДолжности);
            this.vmoДолжности.Columns.Collection.Add(this.Автоинкремент_vmoДолжности);
            this.vmoДолжности.Columns.Collection.Add(this.Владелец_vmoДолжности);
            this.vmoДолжности.Columns.Collection.Add(this.НомерСтроки_vmoДолжности);
            this.vmoДолжности.Columns.Collection.Add(this.Должность);
            this.vmoДолжности.IsActive = true;
            this.vmoДолжности.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoДолжности.Binding = nsgMasterDetailBinding3;
            // 
            // Идентификатор_vmoДолжности
            // 
            this.Идентификатор_vmoДолжности.AutoGenerated = true;
            this.Идентификатор_vmoДолжности.Caption = "Идентификатор";
            this.Идентификатор_vmoДолжности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoДолжности.Name = "Идентификатор";
            this.Идентификатор_vmoДолжности.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoДолжности.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoДолжности.SearchCondition.OwnerComponent = this.Идентификатор_vmoДолжности;
            this.Идентификатор_vmoДолжности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoДолжности.Visible = false;
            // 
            // Автоинкремент_vmoДолжности
            // 
            this.Автоинкремент_vmoДолжности.AutoGenerated = true;
            this.Автоинкремент_vmoДолжности.CalcTotal = false;
            this.Автоинкремент_vmoДолжности.Caption = "Автоинкремент";
            this.Автоинкремент_vmoДолжности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoДолжности.Name = "Автоинкремент";
            this.Автоинкремент_vmoДолжности.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoДолжности.PropertyType = typeof(long);
            this.Автоинкремент_vmoДолжности.SearchCondition.OwnerComponent = this.Автоинкремент_vmoДолжности;
            this.Автоинкремент_vmoДолжности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoДолжности.Visible = false;
            // 
            // Владелец_vmoДолжности
            // 
            this.Владелец_vmoДолжности.AutoGenerated = true;
            this.Владелец_vmoДолжности.Caption = "Владелец";
            this.Владелец_vmoДолжности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoДолжности.Name = "Владелец";
            this.Владелец_vmoДолжности.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoДолжности.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoДолжности.SearchCondition.OwnerComponent = this.Владелец_vmoДолжности;
            this.Владелец_vmoДолжности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoДолжности
            // 
            this.НомерСтроки_vmoДолжности.AutoGenerated = true;
            this.НомерСтроки_vmoДолжности.CalcTotal = false;
            this.НомерСтроки_vmoДолжности.Caption = "НомерСтроки";
            this.НомерСтроки_vmoДолжности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoДолжности.Name = "НомерСтроки";
            this.НомерСтроки_vmoДолжности.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoДолжности.PropertyType = typeof(long);
            this.НомерСтроки_vmoДолжности.SearchCondition.OwnerComponent = this.НомерСтроки_vmoДолжности;
            this.НомерСтроки_vmoДолжности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoДолжности.Visible = false;
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
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
            this.nsgIGrid1.AutoResizeCols = true;
            nsgIGridColumn8.AllowFilter = true;
            nsgIGridColumn8.AllowGroupSelect = false;
            nsgIGridColumn8.AllowResize = true;
            nsgIGridColumn8.AutoResize = true;
            nsgIGridColumn8.Caption = "";
            nsgIGridColumn8.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.InitiateRowEdit = true;
            nsgIGridColumn8.Name = "Владелец";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Visible = false;
            nsgIGridColumn8.Width = 100;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.InitiateRowEdit = true;
            nsgIGridColumn9.Name = "Должность";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Width = 100;
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
            this.nsgIGrid1.Location = new System.Drawing.Point(5, 3);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(732, 360);
            this.nsgIGrid1.SourceObject = this.vmoДолжности;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // ТехникаФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(765, 477);
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGridСистемыСлежения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСистемыСлежения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGridТарифы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpОписание.ResumeLayout(false);
            this.tpОписание.PerformLayout();
            this.tpСистемыСлежения.ResumeLayout(false);
            this.tpТарифы.ResumeLayout(false);
            this.tpДолжности.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vmoДолжности)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected NsgInput nsgInput2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected NsgInput nsgInput3;
        protected NsgInput nsgInput4;
        protected NsgInput nsgInput5;
        protected NsgInput nsgInput6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        protected NsgInput nsgInput7;
        protected NsgInput nsgInput8;
        protected NsgInput nsgInput9;
        protected NsgInput nsgInput10;
        private System.Windows.Forms.Label label12;
        protected NsgInput nsgInput11;
        protected NsgInput nsgInput12;
        protected NsgInput nsgInput13;
        protected System.Windows.Forms.Label label13;
        protected NsgInput nsgInput14;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label11;
        protected NsgColumnDescriptor.Guid Идентификатор_nsgVisualMultipleObject1;
        protected NsgColumnDescriptor.Int64 Автоинкремент_nsgVisualMultipleObject1;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected ТипСистемыСлежения.ColumnDescriptor ТипСистемыСлежения;
        protected NsgColumnDescriptor.String ИдентификаторСистемыСлежения;
        protected NsgColumnDescriptor.Boolean ИспользоватьПоУмолчанию;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТарифы;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТарифы;
        protected NsgColumnDescriptor.MultipleObject Владелец_vmoТарифы;
        protected NsgColumnDescriptor.Int64 НомерСтроки_vmoТарифы;
        protected Тарифы.ColumnDescriptor Тариф;
        protected NsgColumnDescriptor.Decimal Стоимость;
        private NsgIGrid nsgIGridСистемыСлежения;
        private NsgVisualMultipleObject vmoСистемыСлежения;
        private NsgIGrid nsgIGridТарифы;
        private NsgVisualMultipleObject vmoТарифы;
        protected NsgInput nsgInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpОписание;
        private System.Windows.Forms.TabPage tpСистемыСлежения;
        private System.Windows.Forms.TabPage tpТарифы;
        private System.Windows.Forms.TabPage tpДолжности;
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
        protected Марка.ColumnDescriptor Марка;
        protected Модель.ColumnDescriptor Модель;
        protected NsgColumnDescriptor.String ГодВыпуска;
        protected NsgColumnDescriptor.String ГосНомер;
        protected Контрагенты.ColumnDescriptor Подрядчик;
        protected NsgColumnDescriptor.String Номер;
        protected NsgColumnDescriptor.Decimal НормативныйРасходТоплива;
        protected NsgColumnDescriptor.Decimal ОбъемТопливногоБака;
        protected NsgColumnDescriptor.String Примечание;
        protected СтатусТехники.ColumnDescriptor Статус;
        protected _SystemTables.МониторингТехникаТарифы.ColumnDescriptor Тарифы;
        protected ТипСобственности.ColumnDescriptor ТипСобственности;
        protected ГруппыСпецТехники.ColumnDescriptor ГруппаСпецТехники;
        protected _SystemTables.МониторингТехникаСистемыСлежения.ColumnDescriptor СистемыСлежения;
        protected NsgColumnDescriptor.Int64 Иконка;
        protected СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        protected NsgColumnDescriptor.Boolean ОтслеживатьХодки;
        protected _SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности.ColumnDescriptor ТаблицаДопущенныеДоУправленияДолжности;
        protected Техника.ColumnDescriptor Родитель;
        protected NsgIGrid nsgIGrid1;
        protected NsgVisualMultipleObject vmoДолжности;
        private NsgColumnDescriptor.Guid Идентификатор_vmoДолжности;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoДолжности;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoДолжности;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoДолжности;
        protected Должности.ColumnDescriptor Должность;
    }
}