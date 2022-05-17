using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.СпециальнаяОдежда

{
    
    public partial class ПеремещениеСпецодеждыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПеремещениеСпецодеждыФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТабл = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.Идентификатор_vmoТабл = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабл = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Размер = new TechControl.Метаданные.СпециальнаяОдежда.Размеры.ColumnDescriptor();
            this.Спецодежда = new TechControl.Метаданные.СпециальнаяОдежда.Спецодежда.ColumnDescriptor();
            this.Стоимость = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Цена = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
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
            this.Таблица = new TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица.ColumnDescriptor();
            this.ПризнакДвижения = new TechControl.Метаданные.Перечисления.ПризнакиДвижений.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабл)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(1022, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(1138, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(1217, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(752, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(847, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(931, 1);
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
            this.panelButtons.Size = new System.Drawing.Size(1217, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(752, 1);
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
            this.Comment.FullName = "СпециальнаяОдежда.ПеремещениеСпецодежды.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(1217, 23);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПризнакДвижения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "СпециальнаяОдежда.ПеремещениеСпецодежды";
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
            nsgIGridColumn9.Name = "Размер";
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
            nsgIGridColumn10.InitiateRowEdit = true;
            nsgIGridColumn10.Name = "Спецодежда";
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
            nsgIGridColumn11.InitiateRowEdit = true;
            nsgIGridColumn11.Name = "Сотрудник";
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
        "Visible",
        "Index"};
            nsgIGridColumn12.DateFormat = null;
            nsgIGridColumn12.InitiateRowEdit = true;
            nsgIGridColumn12.Name = "Количество";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn13.InitiateRowEdit = true;
            nsgIGridColumn13.Name = "Цена";
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
        "Visible",
        "Index"};
            nsgIGridColumn14.DateFormat = null;
            nsgIGridColumn14.InitiateRowEdit = true;
            nsgIGridColumn14.Name = "Стоимость";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(21, 77);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(1171, 193);
            this.nsgIGrid1.SourceObject = this.vmoТабл;
            this.nsgIGrid1.TabIndex = 13;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellEndEdit);
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            this.vmoТабл.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТабл.MetaDataName = "Метаданные";
            this.vmoТабл.FullName = "_SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица.Владелец";
            // 
            // vmoТабл
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "СпециальнаяОдежда.ПеремещениеСпецодежды.Таблица";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТабл.Columns.Collection.Add(this.Идентификатор_vmoТабл);
            this.vmoТабл.Columns.Collection.Add(this.Автоинкремент_vmoТабл);
            this.vmoТабл.Columns.Collection.Add(this.Владелец);
            this.vmoТабл.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТабл.Columns.Collection.Add(this.Размер);
            this.vmoТабл.Columns.Collection.Add(this.Спецодежда);
            this.vmoТабл.Columns.Collection.Add(this.Стоимость);
            this.vmoТабл.Columns.Collection.Add(this.Цена);
            this.vmoТабл.Columns.Collection.Add(this.Количество);
            this.vmoТабл.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТабл.Binding = nsgMasterDetailBinding2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер документа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата документа:";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "СпециальнаяОдежда.ПеремещениеСпецодежды.НомерДокумента";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(122, 25);
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
            this.nsgInput1.Size = new System.Drawing.Size(325, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 11;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "СпециальнаяОдежда.ПеремещениеСпецодежды.ДатаДокумента";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(557, 26);
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
            this.nsgInput2.Size = new System.Drawing.Size(165, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 12;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Идентификатор_vmoТабл
            // 
            this.Идентификатор_vmoТабл.AutoGenerated = true;
            this.Идентификатор_vmoТабл.Caption = "Идентификатор";
            this.Идентификатор_vmoТабл.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТабл.Name = "Идентификатор";
            this.Идентификатор_vmoТабл.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТабл.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТабл.SearchCondition.OwnerComponent = this.Идентификатор_vmoТабл;
            this.Идентификатор_vmoТабл.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТабл.Visible = false;
            // 
            // Автоинкремент_vmoТабл
            // 
            this.Автоинкремент_vmoТабл.AutoGenerated = true;
            this.Автоинкремент_vmoТабл.CalcTotal = false;
            this.Автоинкремент_vmoТабл.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТабл.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТабл.Name = "Автоинкремент";
            this.Автоинкремент_vmoТабл.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТабл.PropertyType = typeof(long);
            this.Автоинкремент_vmoТабл.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТабл;
            this.Автоинкремент_vmoТабл.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТабл.Visible = false;
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
            // Размер
            // 
            this.Размер.AutoGenerated = true;
            this.Размер.Caption = "Размер";
            this.Размер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Размер.Name = "Размер";
            this.Размер.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Размеры);
            this.Размер.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Размеры);
            this.Размер.SearchCondition.OwnerComponent = this.Размер;
            this.Размер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Спецодежда
            // 
            this.Спецодежда.AutoGenerated = true;
            this.Спецодежда.Caption = "Спецодежда";
            this.Спецодежда.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Спецодежда.Name = "Спецодежда";
            this.Спецодежда.NSGType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Спецодежда);
            this.Спецодежда.PropertyType = typeof(TechControl.Метаданные.СпециальнаяОдежда.Спецодежда);
            this.Спецодежда.SearchCondition.OwnerComponent = this.Спецодежда;
            this.Спецодежда.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица);
            this.Таблица.SearchCondition.OwnerComponent = this.Таблица;
            this.Таблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Таблица.Visible = false;
            // 
            // ПризнакДвижения
            // 
            this.ПризнакДвижения.AutoGenerated = true;
            this.ПризнакДвижения.Caption = "ПризнакДвижения";
            this.ПризнакДвижения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПризнакДвижения.Name = "ПризнакДвижения";
            this.ПризнакДвижения.NSGType = typeof(TechControl.Метаданные.Перечисления.ПризнакиДвижений);
            this.ПризнакДвижения.PropertyType = typeof(TechControl.Метаданные.Перечисления.ПризнакиДвижений);
            this.ПризнакДвижения.SearchCondition.OwnerComponent = this.ПризнакДвижения;
            this.ПризнакДвижения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Сотрудник:";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Сотрудник";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = false;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(802, 26);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Сотрудник";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(166, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 15;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Объект";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = false;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(1034, 26);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Объект";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(147, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 16;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(983, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Объект:";
            // 
            // ПеремещениеСпецодеждыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1217, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nsgInput4);
            this.Controls.Add(this.nsgInput3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.nsgInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgInput4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабл)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected NsgInput nsgInput1;
        protected NsgInput nsgInput2;
        private NsgVisualMultipleObject vmoТабл;
        private NsgIGrid nsgIGrid1;
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
        protected _SystemTables.СпециальнаяОдеждаПеремещениеСпецодеждыТаблица.ColumnDescriptor Таблица;
        protected Перечисления.ПризнакиДвижений.ColumnDescriptor ПризнакДвижения;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабл;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТабл;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected Размеры.ColumnDescriptor Размер;
        protected Спецодежда.ColumnDescriptor Спецодежда;
        protected NsgColumnDescriptor.Decimal Стоимость;
        protected NsgColumnDescriptor.Decimal Цена;
        protected NsgColumnDescriptor.Int64 Количество;
        private System.Windows.Forms.Label label3;
        protected NsgInput nsgInput3;
        protected NsgInput nsgInput4;
        private System.Windows.Forms.Label label4;
    }
}