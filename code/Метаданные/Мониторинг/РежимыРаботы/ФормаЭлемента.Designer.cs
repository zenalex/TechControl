using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class РежимыРаботыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РежимыРаботыФормаЭлемента));
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
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаРасписание = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДеньНедели_vmoТаблицаРаспиание = new TechControl.Метаданные.Мониторинг.ДеньНедели.ColumnDescriptor();
            this.ВремяНачалаСмены1_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.КоличествоСмен_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.vmoТабличнаяЧасть = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТабличнаяЧасть = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ДеньНедели = new TechControl.Метаданные.Мониторинг.ДеньНедели.ColumnDescriptor();
            this.ВремяНачалаРабочегоДня = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяКонцаРабочегоДня = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаПерерыва = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяКонцаПерерыва = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияСмены1 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаСмены2 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаСмены3 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияСмены2 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяОкончанияСмены3 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.КоличествоСмен = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ВремяНачалаСмены1 = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.nsgButton2 = new NsgSoft.Design.NsgButton();
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
            this.ТаблицаГрафик = new TechControl.Метаданные._SystemTables.МониторингРежимыРаботыТаблицаГрафик.ColumnDescriptor();
            this.Родитель = new TechControl.Метаданные.Мониторинг.РежимыРаботы.ColumnDescriptor();
            this.nsgButton3 = new NsgSoft.Design.NsgButton();
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаСмены3_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ВремяНачалаСмены2_vmoТаблицаРасписание = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРасписание)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабличнаяЧасть)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton3)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(546, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(662, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(741, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(276, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(371, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(455, 1);
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
            this.panelButtons.Size = new System.Drawing.Size(741, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(276, 1);
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
            this.Comment.FullName = "Мониторинг.РежимыРаботы.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(741, 23);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЭтоГруппа);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторРодителя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Уровень);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Код);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Наименование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаГрафик);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.РежимыРаботы";
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
        "Visible",
        "Index"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.ImportedFromVMO = false;
            nsgIGridColumn1.InitiateRowEdit = true;
            nsgIGridColumn1.Name = "КоличествоСмен";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            nsgIGridColumn2.Name = "ДеньНедели";
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
        "Visible",
        "Index"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.ImportedFromVMO = false;
            nsgIGridColumn3.InitiateRowEdit = true;
            nsgIGridColumn3.Name = "ВремяНачалаРабочегоДня";
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
        "Visible",
        "Index"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.Name = "ВремяОкончанияРабочегоДня";
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
        "Visible",
        "Index"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.ImportedFromVMO = false;
            nsgIGridColumn5.InitiateRowEdit = true;
            nsgIGridColumn5.Name = "ВремяНачалаПерерыва";
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
        "Visible",
        "Index"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Name = "ВремяОкончанияПерерыва";
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
        "Visible",
        "Index"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "ВремяНачалаСмены";
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
        "Visible",
        "Index"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "ВремяОкончанияСмены";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(12, 59);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(717, 261);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаРасписание;
            this.nsgIGrid1.TabIndex = 11;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.RowEnter += new NsgSoft.Forms.NsgIGrid.NsgIGridRowEventHandler(this.nsgIGrid1_RowEnter);
            // 
            // vmoТаблицаРасписание
            // 
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ДеньНедели_vmoТаблицаРаспиание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяНачалаСмены1_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяОкончанияСмены1_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяНачалаПерерыва_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяОкончанияПерерыва_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.КоличествоСмен_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяНачалаСмены2_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяОкончанияСмены2_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяНачалаСмены3_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.Columns.Collection.Add(this.ВремяОкончанияСмены3_vmoТаблицаРасписание);
            this.vmoТаблицаРасписание.IsActive = true;
            this.vmoТаблицаРасписание.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаРасписание.MetaDataName = "";
            this.vmoТаблицаРасписание.FullName = "";
            // 
            // ДеньНедели_vmoТаблицаРаспиание
            // 
            this.ДеньНедели_vmoТаблицаРаспиание.Caption = "ДеньНедели";
            this.ДеньНедели_vmoТаблицаРаспиание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДеньНедели_vmoТаблицаРаспиание.Name = "ДеньНедели";
            this.ДеньНедели_vmoТаблицаРаспиание.NSGType = typeof(TechControl.Метаданные.Мониторинг.ДеньНедели);
            this.ДеньНедели_vmoТаблицаРаспиание.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ДеньНедели);
            this.ДеньНедели_vmoТаблицаРаспиание.SearchCondition.OwnerComponent = this.ДеньНедели_vmoТаблицаРаспиание;
            this.ДеньНедели_vmoТаблицаРаспиание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены1_vmoТаблицаРасписание
            // 
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.Caption = "ВремяНачалаСмены1";
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.Name = "ВремяНачалаСмены1";
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяНачалаСмены1_vmoТаблицаРасписание;
            this.ВремяНачалаСмены1_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияСмены1_vmoТаблицаРасписание
            // 
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.Caption = "ВремяОкончанияСмены1";
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.Name = "ВремяОкончанияСмены1";
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены1_vmoТаблицаРасписание;
            this.ВремяОкончанияСмены1_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаПерерыва_vmoТаблицаРасписание
            // 
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.Caption = "ВремяНачалаПерерыва";
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.Name = "ВремяНачалаПерерыва";
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяНачалаПерерыва_vmoТаблицаРасписание;
            this.ВремяНачалаПерерыва_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияПерерыва_vmoТаблицаРасписание
            // 
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.Caption = "ВремяОкончанияПерерыва";
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.Name = "ВремяОкончанияПерерыва";
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяОкончанияПерерыва_vmoТаблицаРасписание;
            this.ВремяОкончанияПерерыва_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаРабочегоДня_vmoТаблицаРасписание
            // 
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.Caption = "ВремяНачалаРабочегоДня";
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.Name = "ВремяНачалаРабочегоДня";
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание;
            this.ВремяНачалаРабочегоДня_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияРабочегоДня_vmoТаблицаРасписание
            // 
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.Caption = "ВремяОкончанияРабочегоДня";
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.Name = "ВремяОкончанияРабочегоДня";
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание;
            this.ВремяОкончанияРабочегоДня_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоСмен_vmoТаблицаРасписание
            // 
            this.КоличествоСмен_vmoТаблицаРасписание.CalcTotal = false;
            this.КоличествоСмен_vmoТаблицаРасписание.Caption = "КоличествоСмен";
            this.КоличествоСмен_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КоличествоСмен_vmoТаблицаРасписание.Name = "КоличествоСмен";
            this.КоличествоСмен_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоСмен_vmoТаблицаРасписание.PropertyType = typeof(long);
            this.КоличествоСмен_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.КоличествоСмен_vmoТаблицаРасписание;
            this.КоличествоСмен_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.vmoТабличнаяЧасть.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТабличнаяЧасть.MetaDataName = "Метаданные";
            this.vmoТабличнаяЧасть.FullName = "_SystemTables.МониторингРежимыРаботыТаблицаГрафик.Владелец";
            // 
            // vmoТабличнаяЧасть
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингРежимыРаботыТаблицаГрафик.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.РежимыРаботы.ТаблицаГрафик";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.Идентификатор_vmoТабличнаяЧасть);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.Автоинкремент_vmoТабличнаяЧасть);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.Владелец);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ДеньНедели);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяНачалаРабочегоДня);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяКонцаРабочегоДня);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяНачалаПерерыва);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяКонцаПерерыва);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяОкончанияСмены1);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяНачалаСмены2);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяНачалаСмены3);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяОкончанияСмены2);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяОкончанияСмены3);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.КоличествоСмен);
            this.vmoТабличнаяЧасть.Columns.Collection.Add(this.ВремяНачалаСмены1);
            this.vmoТабличнаяЧасть.IsActive = true;
            this.vmoТабличнаяЧасть.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТабличнаяЧасть.Binding = nsgMasterDetailBinding1;
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
            // ДеньНедели
            // 
            this.ДеньНедели.AutoGenerated = true;
            this.ДеньНедели.Caption = "ДеньНедели";
            this.ДеньНедели.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДеньНедели.Name = "ДеньНедели";
            this.ДеньНедели.NSGType = typeof(TechControl.Метаданные.Мониторинг.ДеньНедели);
            this.ДеньНедели.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ДеньНедели);
            this.ДеньНедели.SearchCondition.OwnerComponent = this.ДеньНедели;
            this.ДеньНедели.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаРабочегоДня
            // 
            this.ВремяНачалаРабочегоДня.AutoGenerated = true;
            this.ВремяНачалаРабочегоДня.Caption = "ВремяНачалаРабочегоДня";
            this.ВремяНачалаРабочегоДня.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаРабочегоДня.Name = "ВремяНачалаРабочегоДня";
            this.ВремяНачалаРабочегоДня.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаРабочегоДня.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаРабочегоДня.SearchCondition.OwnerComponent = this.ВремяНачалаРабочегоДня;
            this.ВремяНачалаРабочегоДня.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяКонцаРабочегоДня
            // 
            this.ВремяКонцаРабочегоДня.AutoGenerated = true;
            this.ВремяКонцаРабочегоДня.Caption = "ВремяКонцаРабочегоДня";
            this.ВремяКонцаРабочегоДня.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяКонцаРабочегоДня.Name = "ВремяКонцаРабочегоДня";
            this.ВремяКонцаРабочегоДня.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяКонцаРабочегоДня.PropertyType = typeof(System.DateTime);
            this.ВремяКонцаРабочегоДня.SearchCondition.OwnerComponent = this.ВремяКонцаРабочегоДня;
            this.ВремяКонцаРабочегоДня.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаПерерыва
            // 
            this.ВремяНачалаПерерыва.AutoGenerated = true;
            this.ВремяНачалаПерерыва.Caption = "ВремяНачалаПерерыва";
            this.ВремяНачалаПерерыва.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаПерерыва.Name = "ВремяНачалаПерерыва";
            this.ВремяНачалаПерерыва.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаПерерыва.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаПерерыва.SearchCondition.OwnerComponent = this.ВремяНачалаПерерыва;
            this.ВремяНачалаПерерыва.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяКонцаПерерыва
            // 
            this.ВремяКонцаПерерыва.AutoGenerated = true;
            this.ВремяКонцаПерерыва.Caption = "ВремяКонцаПерерыва";
            this.ВремяКонцаПерерыва.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяКонцаПерерыва.Name = "ВремяКонцаПерерыва";
            this.ВремяКонцаПерерыва.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяКонцаПерерыва.PropertyType = typeof(System.DateTime);
            this.ВремяКонцаПерерыва.SearchCondition.OwnerComponent = this.ВремяКонцаПерерыва;
            this.ВремяКонцаПерерыва.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияСмены1
            // 
            this.ВремяОкончанияСмены1.AutoGenerated = true;
            this.ВремяОкончанияСмены1.Caption = "ВремяОкончанияСмены1";
            this.ВремяОкончанияСмены1.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены1.Name = "ВремяОкончанияСмены1";
            this.ВремяОкончанияСмены1.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияСмены1.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияСмены1.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены1;
            this.ВремяОкончанияСмены1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены2
            // 
            this.ВремяНачалаСмены2.AutoGenerated = true;
            this.ВремяНачалаСмены2.Caption = "ВремяНачалаСмены2";
            this.ВремяНачалаСмены2.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены2.Name = "ВремяНачалаСмены2";
            this.ВремяНачалаСмены2.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены2.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены2.SearchCondition.OwnerComponent = this.ВремяНачалаСмены2;
            this.ВремяНачалаСмены2.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены3
            // 
            this.ВремяНачалаСмены3.AutoGenerated = true;
            this.ВремяНачалаСмены3.Caption = "ВремяНачалаСмены3";
            this.ВремяНачалаСмены3.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены3.Name = "ВремяНачалаСмены3";
            this.ВремяНачалаСмены3.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены3.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены3.SearchCondition.OwnerComponent = this.ВремяНачалаСмены3;
            this.ВремяНачалаСмены3.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияСмены2
            // 
            this.ВремяОкончанияСмены2.AutoGenerated = true;
            this.ВремяОкончанияСмены2.Caption = "ВремяОкончанияСмены2";
            this.ВремяОкончанияСмены2.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены2.Name = "ВремяОкончанияСмены2";
            this.ВремяОкончанияСмены2.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияСмены2.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияСмены2.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены2;
            this.ВремяОкончанияСмены2.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияСмены3
            // 
            this.ВремяОкончанияСмены3.AutoGenerated = true;
            this.ВремяОкончанияСмены3.Caption = "ВремяОкончанияСмены3";
            this.ВремяОкончанияСмены3.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены3.Name = "ВремяОкончанияСмены3";
            this.ВремяОкончанияСмены3.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияСмены3.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияСмены3.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены3;
            this.ВремяОкончанияСмены3.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличествоСмен
            // 
            this.КоличествоСмен.AutoGenerated = true;
            this.КоличествоСмен.CalcTotal = false;
            this.КоличествоСмен.Caption = "КоличествоСмен";
            this.КоличествоСмен.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КоличествоСмен.Name = "КоличествоСмен";
            this.КоличествоСмен.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличествоСмен.PropertyType = typeof(long);
            this.КоличествоСмен.SearchCondition.OwnerComponent = this.КоличествоСмен;
            this.КоличествоСмен.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены1
            // 
            this.ВремяНачалаСмены1.AutoGenerated = true;
            this.ВремяНачалаСмены1.Caption = "ВремяНачалаСмены1";
            this.ВремяНачалаСмены1.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены1.Name = "ВремяНачалаСмены1";
            this.ВремяНачалаСмены1.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены1.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены1.SearchCondition.OwnerComponent = this.ВремяНачалаСмены1;
            this.ВремяНачалаСмены1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование:";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.РежимыРаботы.Наименование";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(110, 15);
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
            this.nsgInput1.Size = new System.Drawing.Size(203, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 10;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(499, 15);
            this.nsgButton1.Name = "NsgButton";
            this.nsgButton1.Size = new System.Drawing.Size(104, 38);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 12;
            this.nsgButton1.Text = "Скопировать на все";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
            // 
            // nsgButton2
            // 
            this.nsgButton2.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton2.Location = new System.Drawing.Point(609, 15);
            this.nsgButton2.Name = "NsgButton";
            this.nsgButton2.Size = new System.Drawing.Size(108, 38);
            this.nsgButton2.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton2.TabIndex = 13;
            this.nsgButton2.Text = "Очистить";
            this.nsgButton2.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton2.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton2_AsyncClick);
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
            // ТаблицаГрафик
            // 
            this.ТаблицаГрафик.AutoGenerated = true;
            this.ТаблицаГрафик.Caption = "ТаблицаГрафик";
            this.ТаблицаГрафик.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаГрафик.Name = "ТаблицаГрафик";
            this.ТаблицаГрафик.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингРежимыРаботыТаблицаГрафик);
            this.ТаблицаГрафик.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингРежимыРаботыТаблицаГрафик);
            this.ТаблицаГрафик.SearchCondition.OwnerComponent = this.ТаблицаГрафик;
            this.ТаблицаГрафик.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаГрафик.Visible = false;
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.РежимыРаботы);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.РежимыРаботы);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgButton3
            // 
            this.nsgButton3.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton3.Location = new System.Drawing.Point(389, 15);
            this.nsgButton3.Name = "NsgButton";
            this.nsgButton3.Size = new System.Drawing.Size(104, 38);
            this.nsgButton3.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton3.TabIndex = 14;
            this.nsgButton3.Text = "Сохранить";
            this.nsgButton3.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton3.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton3_AsyncClick);
            // 
            // ВремяОкончанияСмены2_vmoТаблицаРасписание
            // 
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.Caption = "ВремяОкончанияСмены2";
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.Name = "ВремяОкончанияСмены2";
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.PropertyType = typeof(string);
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены2_vmoТаблицаРасписание;
            this.ВремяОкончанияСмены2_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяОкончанияСмены3_vmoТаблицаРасписание
            // 
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.Caption = "ВремяОкончанияСмены3";
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.Name = "ВремяОкончанияСмены3";
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяОкончанияСмены3_vmoТаблицаРасписание;
            this.ВремяОкончанияСмены3_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены3_vmoТаблицаРасписание
            // 
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.Caption = "ВремяНачалаСмены3";
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.Name = "ВремяНачалаСмены3";
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяНачалаСмены3_vmoТаблицаРасписание;
            this.ВремяНачалаСмены3_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВремяНачалаСмены2_vmoТаблицаРасписание
            // 
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.Caption = "ВремяНачалаСмены2";
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.Name = "ВремяНачалаСмены2";
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.PropertyType = typeof(System.DateTime);
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.SearchCondition.OwnerComponent = this.ВремяНачалаСмены2_vmoТаблицаРасписание;
            this.ВремяНачалаСмены2_vmoТаблицаРасписание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РежимыРаботыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.nsgButton3);
            this.Controls.Add(this.nsgButton2);
            this.Controls.Add(this.nsgButton1);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgInput1);
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
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.nsgButton1, 0);
            this.Controls.SetChildIndex(this.nsgButton2, 0);
            this.Controls.SetChildIndex(this.nsgButton3, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРасписание)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабличнаяЧасть)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected NsgInput nsgInput1;
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected NsgSoft.Design.NsgButton nsgButton2;
        private NsgIGrid nsgIGrid1;
        protected РежимыРаботы.ColumnDescriptor Родитель;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТабличнаяЧасть;
        protected System.Windows.Forms.Label label1;
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
        protected _SystemTables.МониторингРежимыРаботыТаблицаГрафик.ColumnDescriptor ТаблицаГрафик;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТабличнаяЧасть;
        protected NsgColumnDescriptor.MultipleObject Владелец;
        protected NsgColumnDescriptor.Int64 НомерСтроки;
        protected ДеньНедели.ColumnDescriptor ДеньНедели;
        protected NsgColumnDescriptor.DateTime ВремяНачалаРабочегоДня;
        protected NsgColumnDescriptor.DateTime ВремяКонцаРабочегоДня;
        protected NsgColumnDescriptor.DateTime ВремяНачалаПерерыва;
        protected NsgColumnDescriptor.DateTime ВремяКонцаПерерыва;
        protected NsgColumnDescriptor.DateTime ВремяОкончанияСмены1;
        protected NsgColumnDescriptor.DateTime ВремяНачалаСмены2;
        protected NsgColumnDescriptor.DateTime ВремяНачалаСмены3;
        protected NsgColumnDescriptor.DateTime ВремяОкончанияСмены2;
        protected NsgColumnDescriptor.DateTime ВремяОкончанияСмены3;
        protected NsgColumnDescriptor.Int64 КоличествоСмен;
        protected NsgColumnDescriptor.DateTime ВремяНачалаСмены1;
        protected ДеньНедели.ColumnDescriptor ДеньНедели_vmoТаблицаРаспиание;
        private NsgColumnDescriptor.DateTime ВремяНачалаСмены1_vmoТаблицаРасписание;
        private NsgColumnDescriptor.DateTime ВремяОкончанияСмены1_vmoТаблицаРасписание;
        private NsgColumnDescriptor.DateTime ВремяНачалаПерерыва_vmoТаблицаРасписание;
        private NsgColumnDescriptor.DateTime ВремяОкончанияПерерыва_vmoТаблицаРасписание;
        private NsgColumnDescriptor.DateTime ВремяНачалаРабочегоДня_vmoТаблицаРасписание;
        private NsgColumnDescriptor.DateTime ВремяОкончанияРабочегоДня_vmoТаблицаРасписание;
        private NsgColumnDescriptor.Int64 КоличествоСмен_vmoТаблицаРасписание;
        private NsgVisualMultipleObject vmoТабличнаяЧасть;
        private NsgVisualMultipleObject vmoТаблицаРасписание;
        protected NsgSoft.Design.NsgButton nsgButton3;
        protected NsgColumnDescriptor.String ВремяОкончанияСмены2_vmoТаблицаРасписание;
        protected NsgColumnDescriptor.DateTime ВремяНачалаСмены2_vmoТаблицаРасписание;
        protected NsgColumnDescriptor.DateTime ВремяНачалаСмены3_vmoТаблицаРасписание;
        protected NsgColumnDescriptor.DateTime ВремяОкончанияСмены3_vmoТаблицаРасписание;
    }
}