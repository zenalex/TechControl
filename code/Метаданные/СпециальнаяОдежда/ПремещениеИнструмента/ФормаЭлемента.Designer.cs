using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.СпециальнаяОдежда

{
    
    public partial class ПремещениеИнструментаФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПремещениеИнструментаФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.Идентификатор_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Инструмент = new TechControl.Метаданные.СпециальнаяОдежда.Инструменты.ColumnDescriptor();
            this.Цена_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество_vmoТабЧаст = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Идентификатор_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Инструмент_vmoТабличнаяЧасть = new TechControl.Метаданные.СпециальнаяОдежда.Инструменты.ColumnDescriptor();
            this.Цена_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Идентификатор_vmoТабЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Инструменты = new TechControl.Метаданные.СпециальнаяОдежда.Инструменты.ColumnDescriptor();
            this.Цена = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.Идентификатор_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Инструмент_vmoТабличЧасть = new TechControl.Метаданные.СпециальнаяОдежда.Инструменты.ColumnDescriptor();
            this.Цена_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество_vmoТабличЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
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
            this.Таблица = new TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.vmoТабЧас = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Инструмент_vmoТабЧас = new TechControl.Метаданные.СпециальнаяОдежда.Инструменты.ColumnDescriptor();
            this.Цена_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество_vmoТабЧас = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабЧас)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(729, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(845, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(924, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(459, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(554, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(638, 1);
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
            this.panelButtons.Size = new System.Drawing.Size(924, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(459, 1);
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
            this.Comment.FullName = "СпециальнаяОдежда.ПремещениеИнструмента.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(924, 23);
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
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "СпециальнаяОдежда.ПремещениеИнструмента";
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
            nsgIGridColumn2.InitiateRowEdit = true;
            nsgIGridColumn2.Name = "Инструмент";
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
            nsgIGridColumn3.InitiateRowEdit = true;
            nsgIGridColumn3.Name = "Цена";
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
            nsgIGridColumn4.InitiateRowEdit = true;
            nsgIGridColumn4.Name = "Сумма";
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
            nsgIGridColumn5.InitiateRowEdit = true;
            nsgIGridColumn5.Name = "Количество";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(21, 74);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(877, 238);
            this.nsgIGrid1.SourceObject = this.vmoТабЧас;
            this.nsgIGrid1.TabIndex = 15;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // Идентификатор_vmoТабЧаст
            // 
            this.Идентификатор_vmoТабЧаст.AutoGenerated = true;
            this.Идентификатор_vmoТабЧаст.Caption = "Идентификатор";
            this.Идентификатор_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабЧаст.Name = "Идентификатор";
            this.Идентификатор_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабЧаст.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабЧаст.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабЧаст;
            this.Идентификатор_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабЧаст.Visible = false;
            // 
            // Автоинкремент_vmoТабЧаст
            // 
            this.Автоинкремент_vmoТабЧаст.AutoGenerated = true;
            this.Автоинкремент_vmoТабЧаст.CalcTotal = false;
            this.Автоинкремент_vmoТабЧаст.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабЧаст.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабЧаст.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабЧаст.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабЧаст;
            this.Автоинкремент_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабЧаст.Visible = false;
            // 
            // Владелец_vmoТабЧаст
            // 
            this.Владелец_vmoТабЧаст.AutoGenerated = true;
            this.Владелец_vmoТабЧаст.Caption = "Владелец";
            this.Владелец_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТабЧаст.Name = "Владелец";
            this.Владелец_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабЧаст.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабЧаст.SearchCondition.OwnerComponent = this.Владелец_vmoТабЧаст;
            this.Владелец_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТабЧаст
            // 
            this.НомерСтроки_vmoТабЧаст.AutoGenerated = true;
            this.НомерСтроки_vmoТабЧаст.CalcTotal = false;
            this.НомерСтроки_vmoТабЧаст.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТабЧаст.Name = "НомерСтроки";
            this.НомерСтроки_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТабЧаст.PropertyType = typeof(long);
            this.НомерСтроки_vmoТабЧаст.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТабЧаст;
            this.НомерСтроки_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТабЧаст.Visible = false;
            // 
            // Инструмент
            // 
            this.Инструмент.AutoGenerated = true;
            this.Инструмент.Caption = "Инструмент";
            this.Инструмент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Инструмент.Name = "Инструмент";
            this.Инструмент.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент.SearchCondition.OwnerComponent = this.Инструмент;
            this.Инструмент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТабЧаст
            // 
            this.Цена_vmoТабЧаст.AutoGenerated = true;
            this.Цена_vmoТабЧаст.CalcTotal = false;
            this.Цена_vmoТабЧаст.Caption = "Цена";
            this.Цена_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Цена_vmoТабЧаст.Name = "Цена";
            this.Цена_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТабЧаст.PropertyType = typeof(decimal);
            this.Цена_vmoТабЧаст.SearchCondition.OwnerComponent = this.Цена_vmoТабЧаст;
            this.Цена_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoТабЧаст
            // 
            this.Сумма_vmoТабЧаст.AutoGenerated = true;
            this.Сумма_vmoТабЧаст.CalcTotal = false;
            this.Сумма_vmoТабЧаст.Caption = "Сумма";
            this.Сумма_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сумма_vmoТабЧаст.Name = "Сумма";
            this.Сумма_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoТабЧаст.PropertyType = typeof(decimal);
            this.Сумма_vmoТабЧаст.SearchCondition.OwnerComponent = this.Сумма_vmoТабЧаст;
            this.Сумма_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoТабЧаст
            // 
            this.Количество_vmoТабЧаст.AutoGenerated = true;
            this.Количество_vmoТабЧаст.CalcTotal = false;
            this.Количество_vmoТабЧаст.Caption = "Количество";
            this.Количество_vmoТабЧаст.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество_vmoТабЧаст.Name = "Количество";
            this.Количество_vmoТабЧаст.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoТабЧаст.PropertyType = typeof(long);
            this.Количество_vmoТабЧаст.SearchCondition.OwnerComponent = this.Количество_vmoТабЧаст;
            this.Количество_vmoТабЧаст.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_vmoТабличнаяЧасть
            // 
            this.Идентификатор_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Идентификатор_vmoТабличнаяЧасть.Caption = "Идентификатор";
            this.Идентификатор_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабличнаяЧасть.Name = "Идентификатор";
            this.Идентификатор_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабличнаяЧасть.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабличнаяЧасть;
            this.Идентификатор_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабличнаяЧасть.Visible = false;
            // 
            // Автоинкремент_vmoТабличнаяЧасть
            // 
            this.Автоинкремент_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Автоинкремент_vmoТабличнаяЧасть.CalcTotal = false;
            this.Автоинкремент_vmoТабличнаяЧасть.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабличнаяЧасть.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабличнаяЧасть.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабличнаяЧасть;
            this.Автоинкремент_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабличнаяЧасть.Visible = false;
            // 
            // Владелец_vmoТабличнаяЧасть
            // 
            this.Владелец_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Владелец_vmoТабличнаяЧасть.Caption = "Владелец";
            this.Владелец_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТабличнаяЧасть.Name = "Владелец";
            this.Владелец_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабличнаяЧасть.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Владелец_vmoТабличнаяЧасть;
            this.Владелец_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТабличнаяЧасть
            // 
            this.НомерСтроки_vmoТабличнаяЧасть.AutoGenerated = true;
            this.НомерСтроки_vmoТабличнаяЧасть.CalcTotal = false;
            this.НомерСтроки_vmoТабличнаяЧасть.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТабличнаяЧасть.Name = "НомерСтроки";
            this.НомерСтроки_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТабличнаяЧасть.PropertyType = typeof(long);
            this.НомерСтроки_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТабличнаяЧасть;
            this.НомерСтроки_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТабличнаяЧасть.Visible = false;
            // 
            // Инструмент_vmoТабличнаяЧасть
            // 
            this.Инструмент_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Инструмент_vmoТабличнаяЧасть.Caption = "Инструменты";
            this.Инструмент_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Инструмент_vmoТабличнаяЧасть.Name = "Инструменты";
            this.Инструмент_vmoТабличнаяЧасть.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабличнаяЧасть.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Инструмент_vmoТабличнаяЧасть;
            this.Инструмент_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТабличнаяЧасть
            // 
            this.Цена_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Цена_vmoТабличнаяЧасть.CalcTotal = false;
            this.Цена_vmoТабличнаяЧасть.Caption = "Цена";
            this.Цена_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Цена_vmoТабличнаяЧасть.Name = "Цена";
            this.Цена_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТабличнаяЧасть.PropertyType = typeof(decimal);
            this.Цена_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Цена_vmoТабличнаяЧасть;
            this.Цена_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoТабличнаяЧасть
            // 
            this.Сумма_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Сумма_vmoТабличнаяЧасть.CalcTotal = false;
            this.Сумма_vmoТабличнаяЧасть.Caption = "Сумма";
            this.Сумма_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сумма_vmoТабличнаяЧасть.Name = "Сумма";
            this.Сумма_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoТабличнаяЧасть.PropertyType = typeof(decimal);
            this.Сумма_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Сумма_vmoТабличнаяЧасть;
            this.Сумма_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoТабличнаяЧасть
            // 
            this.Количество_vmoТабличнаяЧасть.AutoGenerated = true;
            this.Количество_vmoТабличнаяЧасть.CalcTotal = false;
            this.Количество_vmoТабличнаяЧасть.Caption = "Количество";
            this.Количество_vmoТабличнаяЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество_vmoТабличнаяЧасть.Name = "Количество";
            this.Количество_vmoТабличнаяЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoТабличнаяЧасть.PropertyType = typeof(long);
            this.Количество_vmoТабличнаяЧасть.SearchCondition.OwnerComponent = this.Количество_vmoТабличнаяЧасть;
            this.Количество_vmoТабличнаяЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_vmoТабЧасть
            // 
            this.Идентификатор_vmoТабЧасть.AutoGenerated = true;
            this.Идентификатор_vmoТабЧасть.Caption = "Идентификатор";
            this.Идентификатор_vmoТабЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабЧасть.Name = "Идентификатор";
            this.Идентификатор_vmoТабЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабЧасть.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабЧасть.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабЧасть;
            this.Идентификатор_vmoТабЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабЧасть.Visible = false;
            // 
            // Автоинкремент_vmoТабЧасть
            // 
            this.Автоинкремент_vmoТабЧасть.AutoGenerated = true;
            this.Автоинкремент_vmoТабЧасть.CalcTotal = false;
            this.Автоинкремент_vmoТабЧасть.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабЧасть.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабЧасть.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабЧасть.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабЧасть;
            this.Автоинкремент_vmoТабЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабЧасть.Visible = false;
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
            // Инструменты
            // 
            this.Инструменты.AutoGenerated = true;
            this.Инструменты.Caption = "Инструмент";
            this.Инструменты.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Инструменты.Name = "Инструмент";
            this.Инструменты.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструменты.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструменты.SearchCondition.OwnerComponent = this.Инструменты;
            this.Инструменты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена
            // 
            this.Цена.AutoGenerated = true;
            this.Цена.CalcTotal = false;
            this.Цена.Caption = "Цена";
            this.Цена.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Цена.Name = "Цена";
            this.Цена.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена.PropertyType = typeof(decimal);
            this.Цена.SearchCondition.OwnerComponent = this.Цена;
            this.Цена.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма
            // 
            this.Сумма.AutoGenerated = true;
            this.Сумма.CalcTotal = false;
            this.Сумма.Caption = "Сумма";
            this.Сумма.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сумма.Name = "Сумма";
            this.Сумма.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма.PropertyType = typeof(decimal);
            this.Сумма.SearchCondition.OwnerComponent = this.Сумма;
            this.Сумма.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество
            // 
            this.Количество.AutoGenerated = true;
            this.Количество.CalcTotal = false;
            this.Количество.Caption = "Количество";
            this.Количество.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество.Name = "Количество";
            this.Количество.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество.PropertyType = typeof(long);
            this.Количество.SearchCondition.OwnerComponent = this.Количество;
            this.Количество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "СпециальнаяОдежда.ПремещениеИнструмента.НомерДокумента";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(135, 29);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "Метаданные";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "НомерДокумента";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(169, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер документа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата документа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Объект:";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "СпециальнаяОдежда.ПремещениеИнструмента.ДатаДокумента";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(417, 29);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "ДатаДокумента";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(144, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 13;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "СпециальнаяОдежда.ПремещениеИнструмента.Объект";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(631, 29);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Объект";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(194, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 14;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Идентификатор_vmoТабличЧасть
            // 
            this.Идентификатор_vmoТабличЧасть.AutoGenerated = true;
            this.Идентификатор_vmoТабличЧасть.Caption = "Идентификатор";
            this.Идентификатор_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабличЧасть.Name = "Идентификатор";
            this.Идентификатор_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабличЧасть.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабличЧасть;
            this.Идентификатор_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабличЧасть.Visible = false;
            // 
            // Автоинкремент_vmoТабличЧасть
            // 
            this.Автоинкремент_vmoТабличЧасть.AutoGenerated = true;
            this.Автоинкремент_vmoТабличЧасть.CalcTotal = false;
            this.Автоинкремент_vmoТабличЧасть.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабличЧасть.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабличЧасть.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабличЧасть;
            this.Автоинкремент_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабличЧасть.Visible = false;
            // 
            // Владелец_vmoТабличЧасть
            // 
            this.Владелец_vmoТабличЧасть.AutoGenerated = true;
            this.Владелец_vmoТабличЧасть.Caption = "Владелец";
            this.Владелец_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТабличЧасть.Name = "Владелец";
            this.Владелец_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабличЧасть.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Владелец_vmoТабличЧасть;
            this.Владелец_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТабличЧасть
            // 
            this.НомерСтроки_vmoТабличЧасть.AutoGenerated = true;
            this.НомерСтроки_vmoТабличЧасть.CalcTotal = false;
            this.НомерСтроки_vmoТабличЧасть.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТабличЧасть.Name = "НомерСтроки";
            this.НомерСтроки_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТабличЧасть.PropertyType = typeof(long);
            this.НомерСтроки_vmoТабличЧасть.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТабличЧасть;
            this.НомерСтроки_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТабличЧасть.Visible = false;
            // 
            // Инструмент_vmoТабличЧасть
            // 
            this.Инструмент_vmoТабличЧасть.AutoGenerated = true;
            this.Инструмент_vmoТабличЧасть.Caption = "Инструменты";
            this.Инструмент_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Инструмент_vmoТабличЧасть.Name = "Инструменты";
            this.Инструмент_vmoТабличЧасть.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабличЧасть.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Инструмент_vmoТабличЧасть;
            this.Инструмент_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТабличЧасть
            // 
            this.Цена_vmoТабличЧасть.AutoGenerated = true;
            this.Цена_vmoТабличЧасть.CalcTotal = false;
            this.Цена_vmoТабличЧасть.Caption = "Цена";
            this.Цена_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Цена_vmoТабличЧасть.Name = "Цена";
            this.Цена_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТабличЧасть.PropertyType = typeof(decimal);
            this.Цена_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Цена_vmoТабличЧасть;
            this.Цена_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoТабличЧасть
            // 
            this.Сумма_vmoТабличЧасть.AutoGenerated = true;
            this.Сумма_vmoТабличЧасть.CalcTotal = false;
            this.Сумма_vmoТабличЧасть.Caption = "Сумма";
            this.Сумма_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сумма_vmoТабличЧасть.Name = "Сумма";
            this.Сумма_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoТабличЧасть.PropertyType = typeof(decimal);
            this.Сумма_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Сумма_vmoТабличЧасть;
            this.Сумма_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoТабличЧасть
            // 
            this.Количество_vmoТабличЧасть.AutoGenerated = true;
            this.Количество_vmoТабличЧасть.CalcTotal = false;
            this.Количество_vmoТабличЧасть.Caption = "Количество";
            this.Количество_vmoТабличЧасть.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество_vmoТабличЧасть.Name = "Количество";
            this.Количество_vmoТабличЧасть.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoТабличЧасть.PropertyType = typeof(long);
            this.Количество_vmoТабличЧасть.SearchCondition.OwnerComponent = this.Количество_vmoТабличЧасть;
            this.Количество_vmoТабличЧасть.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица);
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
            this.vmoТабЧас.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТабЧас.MetaDataName = "Метаданные";
            this.vmoТабЧас.FullName = "_SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица.Владелец";
            // 
            // vmoТабЧас
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "СпециальнаяОдежда.ПремещениеИнструмента.Таблица";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТабЧас.Columns.Collection.Add(this.Идентификатор_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Автоинкремент_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Владелец_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.НомерСтроки_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Инструмент_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Цена_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Сумма_vmoТабЧас);
            this.vmoТабЧас.Columns.Collection.Add(this.Количество_vmoТабЧас);
            this.vmoТабЧас.IsActive = true;
            this.vmoТабЧас.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТабЧас.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoТабЧас
            // 
            this.Идентификатор_vmoТабЧас.AutoGenerated = true;
            this.Идентификатор_vmoТабЧас.Caption = "Идентификатор";
            this.Идентификатор_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабЧас.Name = "Идентификатор";
            this.Идентификатор_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабЧас.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабЧас.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабЧас;
            this.Идентификатор_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабЧас.Visible = false;
            // 
            // Автоинкремент_vmoТабЧас
            // 
            this.Автоинкремент_vmoТабЧас.AutoGenerated = true;
            this.Автоинкремент_vmoТабЧас.CalcTotal = false;
            this.Автоинкремент_vmoТабЧас.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабЧас.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабЧас.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабЧас.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабЧас;
            this.Автоинкремент_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабЧас.Visible = false;
            // 
            // Владелец_vmoТабЧас
            // 
            this.Владелец_vmoТабЧас.AutoGenerated = true;
            this.Владелец_vmoТабЧас.Caption = "Владелец";
            this.Владелец_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТабЧас.Name = "Владелец";
            this.Владелец_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабЧас.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТабЧас.SearchCondition.OwnerComponent = this.Владелец_vmoТабЧас;
            this.Владелец_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТабЧас
            // 
            this.НомерСтроки_vmoТабЧас.AutoGenerated = true;
            this.НомерСтроки_vmoТабЧас.CalcTotal = false;
            this.НомерСтроки_vmoТабЧас.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТабЧас.Name = "НомерСтроки";
            this.НомерСтроки_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТабЧас.PropertyType = typeof(long);
            this.НомерСтроки_vmoТабЧас.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТабЧас;
            this.НомерСтроки_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТабЧас.Visible = false;
            // 
            // Инструмент_vmoТабЧас
            // 
            this.Инструмент_vmoТабЧас.AutoGenerated = true;
            this.Инструмент_vmoТабЧас.Caption = "Инструмент";
            this.Инструмент_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Инструмент_vmoТабЧас.Name = "Инструмент";
            this.Инструмент_vmoТабЧас.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабЧас.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Инструменты);
            this.Инструмент_vmoТабЧас.SearchCondition.OwnerComponent = this.Инструмент_vmoТабЧас;
            this.Инструмент_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТабЧас
            // 
            this.Цена_vmoТабЧас.AutoGenerated = true;
            this.Цена_vmoТабЧас.CalcTotal = false;
            this.Цена_vmoТабЧас.Caption = "Цена";
            this.Цена_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Цена_vmoТабЧас.Name = "Цена";
            this.Цена_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТабЧас.PropertyType = typeof(decimal);
            this.Цена_vmoТабЧас.SearchCondition.OwnerComponent = this.Цена_vmoТабЧас;
            this.Цена_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoТабЧас
            // 
            this.Сумма_vmoТабЧас.AutoGenerated = true;
            this.Сумма_vmoТабЧас.CalcTotal = false;
            this.Сумма_vmoТабЧас.Caption = "Сумма";
            this.Сумма_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Сумма_vmoТабЧас.Name = "Сумма";
            this.Сумма_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoТабЧас.PropertyType = typeof(decimal);
            this.Сумма_vmoТабЧас.SearchCondition.OwnerComponent = this.Сумма_vmoТабЧас;
            this.Сумма_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoТабЧас
            // 
            this.Количество_vmoТабЧас.AutoGenerated = true;
            this.Количество_vmoТабЧас.CalcTotal = false;
            this.Количество_vmoТабЧас.Caption = "Количество";
            this.Количество_vmoТабЧас.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество_vmoТабЧас.Name = "Количество";
            this.Количество_vmoТабЧас.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoТабЧас.PropertyType = typeof(long);
            this.Количество_vmoТабЧас.SearchCondition.OwnerComponent = this.Количество_vmoТабЧас;
            this.Количество_vmoТабЧас.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПремещениеИнструментаФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 410);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgInput3);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабЧас)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected NsgInput nsgInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected NsgInput nsgInput2;
        protected NsgInput nsgInput3;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабЧасть;
        protected NsgColumnDescriptor.Int64 Количество;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТабЧасть;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected Инструменты.ColumnDescriptor Инструменты;
        protected NsgColumnDescriptor.Decimal Цена;
        protected NsgColumnDescriptor.Decimal Сумма;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабличЧасть;
        protected Инструменты.ColumnDescriptor Инструмент_vmoТабличЧасть;
        protected NsgColumnDescriptor.Int64 Количество_vmoТабличЧасть;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТабличЧасть;
        protected NsgColumnDescriptor.MultipleObject Владелец_vmoТабличЧасть;
        protected NsgColumnDescriptor.Int64 НомерСтроки_vmoТабличЧасть;
        protected NsgColumnDescriptor.Decimal Цена_vmoТабличЧасть;
        protected NsgColumnDescriptor.Decimal Сумма_vmoТабличЧасть;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабличнаяЧасть;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТабличнаяЧасть;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТабличнаяЧасть;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТабличнаяЧасть;
        protected Инструменты.ColumnDescriptor Инструмент_vmoТабличнаяЧасть;
        private NsgColumnDescriptor.Decimal Цена_vmoТабличнаяЧасть;
        private NsgColumnDescriptor.Decimal Сумма_vmoТабличнаяЧасть;
        protected NsgColumnDescriptor.Int64 Количество_vmoТабличнаяЧасть;
        private NsgIGrid nsgIGrid1;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабЧаст;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТабЧаст;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТабЧаст;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТабЧаст;
        protected Инструменты.ColumnDescriptor Инструмент;
        private NsgColumnDescriptor.Decimal Цена_vmoТабЧаст;
        private NsgColumnDescriptor.Decimal Сумма_vmoТабЧаст;
        protected NsgColumnDescriptor.Int64 Количество_vmoТабЧаст;
        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String НомерДокумента;
        protected NsgColumnDescriptor.DateTime ДатаДокумента;
        protected NsgColumnDescriptor.String Индекс;
        protected NsgColumnDescriptor.MultipleObject ДокументОснование;
        protected NsgColumnDescriptor.String Комментарий;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected _SystemTables.СпециальнаяОдеждаПремещениеИнструментаТаблица.ColumnDescriptor Таблица;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgVisualMultipleObject vmoТабЧас;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабЧас;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТабЧас;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТабЧас;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТабЧас;
        protected Инструменты.ColumnDescriptor Инструмент_vmoТабЧас;
        private NsgColumnDescriptor.Decimal Цена_vmoТабЧас;
        private NsgColumnDescriptor.Decimal Сумма_vmoТабЧас;
        protected NsgColumnDescriptor.Int64 Количество_vmoТабЧас;
    }
}