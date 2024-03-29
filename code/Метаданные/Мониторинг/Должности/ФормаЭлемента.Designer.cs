using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ДолжностиФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ДолжностиФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаКомплектов = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаКомплектов = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаКомплектов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.КомплектСпецодежды = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Количество = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label4 = new System.Windows.Forms.Label();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.label5 = new System.Windows.Forms.Label();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpОсновные = new System.Windows.Forms.TabPage();
            this.tpКомплекты = new System.Windows.Forms.TabPage();
            this.tpТаблНоменклатуры = new System.Windows.Forms.TabPage();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаНоменклатуры = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаНоменклатуры = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаНоменклатуры = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТаблицаНоменклатуры = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТаблицаНоменклатуры = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Номенклатура = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.РежимРаботы = new TechControl.Метаданные.Мониторинг.РежимыРаботы.ColumnDescriptor();
            this.Описание = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ЯвляетсяСтаршимПоОбъекту = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ГруппаДолжностей = new TechControl.Метаданные.Мониторинг.ГруппыДолжностей.ColumnDescriptor();
            this.Роль = new TechControl.Метаданные.Мониторинг.Роль.ColumnDescriptor();
            this.АккаунтПользователя = new TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor();
            this.ТаблицаКомплектовСпецодежды = new TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды.ColumnDescriptor();
            this.ЗагрузочныйИдентификатор = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ТаблицаНеобязательнойНоменклатуры = new TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры.ColumnDescriptor();
            this.НаименованиеРодительныйПадеж = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Родитель = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаКомплектов)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpОсновные.SuspendLayout();
            this.tpКомплекты.SuspendLayout();
            this.tpТаблНоменклатуры.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаНоменклатуры)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.nsgEdit.Location = new System.Drawing.Point(833, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(949, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(1028, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(563, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(658, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(742, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 497);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1028, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(563, 1);
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
            this.Comment.FullName = "Мониторинг.Должности.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(1028, 23);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.РежимРаботы);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Описание);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЯвляетсяСтаршимПоОбъекту);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГруппаДолжностей);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Роль);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.АккаунтПользователя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаКомплектовСпецодежды);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЗагрузочныйИдентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаНеобязательнойНоменклатуры);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НаименованиеРодительныйПадеж);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.Должности";
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
            nsgIGridColumn2.Name = "КомплектСпецодежды";
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
            nsgIGridColumn3.Name = "Количество";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
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
            this.nsgIGrid1.Location = new System.Drawing.Point(11, 7);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(985, 443);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаКомплектов;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТаблицаКомплектов.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТаблицаКомплектов.MetaDataName = "Метаданные";
            this.vmoТаблицаКомплектов.FullName = "_SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды.Владелец";
            // 
            // vmoТаблицаКомплектов
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.Должности.ТаблицаКомплектовСпецодежды";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.Идентификатор_vmoТаблицаКомплектов);
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаКомплектов);
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.Владелец);
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.КомплектСпецодежды);
            this.vmoТаблицаКомплектов.Columns.Collection.Add(this.Количество);
            this.vmoТаблицаКомплектов.IsActive = true;
            this.vmoТаблицаКомплектов.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаКомплектов.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoТаблицаКомплектов
            // 
            this.Идентификатор_vmoТаблицаКомплектов.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаКомплектов.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаКомплектов.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаКомплектов.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаКомплектов.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаКомплектов.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаКомплектов.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаКомплектов;
            this.Идентификатор_vmoТаблицаКомплектов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаКомплектов.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаКомплектов
            // 
            this.Автоинкремент_vmoТаблицаКомплектов.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаКомплектов.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаКомплектов.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаКомплектов.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаКомплектов.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаКомплектов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаКомплектов.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаКомплектов.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаКомплектов;
            this.Автоинкремент_vmoТаблицаКомплектов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаКомплектов.Visible = false;
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
            // КомплектСпецодежды
            // 
            this.КомплектСпецодежды.AutoGenerated = true;
            this.КомплектСпецодежды.Caption = "КомплектСпецодежды";
            this.КомплектСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КомплектСпецодежды.Name = "КомплектСпецодежды";
            this.КомплектСпецодежды.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.КомплектСпецодежды.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.КомплектСпецодежды.SearchCondition.OwnerComponent = this.КомплектСпецодежды;
            this.КомплектСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.nsgInput1.FullName = "Мониторинг.Должности.Наименование";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(125, 14);
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
            this.nsgInput1.Size = new System.Drawing.Size(247, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Режим работы:";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.Должности.РежимРаботы";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(125, 44);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "РежимРаботы";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(209, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 12;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Является старшим по объекту:";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Control;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.Должности.ЯвляетсяСтаршимПоОбъекту";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(562, 14);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "ЯвляетсяСтаршимПоОбъекту";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(18, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 13;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Группа должностей:";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Мониторинг.Должности.ГруппаДолжностей";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(125, 74);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "ГруппаДолжностей";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(247, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 15;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Роль:";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Мониторинг.Должности.Роль";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(125, 104);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Роль";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(247, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 17;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Описание:";
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Мониторинг.Должности.Описание";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsMultiline = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(15, 154);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Описание";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(565, 42);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 19;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpОсновные);
            this.tabControl1.Controls.Add(this.tpКомплекты);
            this.tabControl1.Controls.Add(this.tpТаблНоменклатуры);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 479);
            this.tabControl1.TabIndex = 21;
            // 
            // tpОсновные
            // 
            this.tpОсновные.AllowDrop = true;
            this.tpОсновные.Controls.Add(this.groupBox1);
            this.tpОсновные.Controls.Add(this.nsgInput1);
            this.tpОсновные.Controls.Add(this.label6);
            this.tpОсновные.Controls.Add(this.label1);
            this.tpОсновные.Controls.Add(this.nsgInput6);
            this.tpОсновные.Controls.Add(this.label2);
            this.tpОсновные.Controls.Add(this.label5);
            this.tpОсновные.Controls.Add(this.nsgInput2);
            this.tpОсновные.Controls.Add(this.nsgInput5);
            this.tpОсновные.Controls.Add(this.nsgInput3);
            this.tpОсновные.Controls.Add(this.label4);
            this.tpОсновные.Controls.Add(this.label3);
            this.tpОсновные.Controls.Add(this.nsgInput4);
            this.tpОсновные.Enabled = true;
            this.tpОсновные.Location = new System.Drawing.Point(4, 22);
            this.tpОсновные.Name = "tpОсновные";
            this.tpОсновные.Padding = new System.Windows.Forms.Padding(3);
            this.tpОсновные.Size = new System.Drawing.Size(1002, 453);
            this.tpОсновные.TabIndex = 0;
            this.tpОсновные.Text = "Основные";
            this.tpОсновные.UseVisualStyleBackColor = true;
            this.tpОсновные.Visible = true;
            // 
            // tpКомплекты
            // 
            this.tpКомплекты.AllowDrop = true;
            this.tpКомплекты.Controls.Add(this.nsgIGrid1);
            this.tpКомплекты.Enabled = true;
            this.tpКомплекты.Location = new System.Drawing.Point(4, 22);
            this.tpКомплекты.Name = "tpКомплекты";
            this.tpКомплекты.Padding = new System.Windows.Forms.Padding(3);
            this.tpКомплекты.Size = new System.Drawing.Size(1002, 453);
            this.tpКомплекты.TabIndex = 1;
            this.tpКомплекты.Text = "Комплекты спецодежды";
            this.tpКомплекты.UseVisualStyleBackColor = true;
            this.tpКомплекты.Visible = false;
            // 
            // tpТаблНоменклатуры
            // 
            this.tpТаблНоменклатуры.AllowDrop = true;
            this.tpТаблНоменклатуры.Controls.Add(this.nsgIGrid2);
            this.tpТаблНоменклатуры.Enabled = true;
            this.tpТаблНоменклатуры.Location = new System.Drawing.Point(4, 22);
            this.tpТаблНоменклатуры.Name = "tpТаблНоменклатуры";
            this.tpТаблНоменклатуры.Size = new System.Drawing.Size(1002, 453);
            this.tpТаблНоменклатуры.TabIndex = 2;
            this.tpТаблНоменклатуры.Text = "Номенклатура";
            this.tpТаблНоменклатуры.UseVisualStyleBackColor = true;
            this.tpТаблНоменклатуры.Visible = false;
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
            this.nsgIGrid2.Filter = false;
            this.nsgIGrid2.FrozenColumns = 0;
            this.nsgIGrid2.Grouping = true;
            this.nsgIGrid2.Hierarhy = true;
            this.nsgIGrid2.ImageList = null;
            this.nsgIGrid2.IsCanMultiSelect = false;
            this.nsgIGrid2.IsCanSingleSelect = false;
            this.nsgIGrid2.LineHeight = 20;
            this.nsgIGrid2.Location = new System.Drawing.Point(3, 3);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(996, 447);
            this.nsgIGrid2.SourceObject = this.vmoТаблицаНоменклатуры;
            this.nsgIGrid2.TabIndex = 0;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТаблицаНоменклатуры.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТаблицаНоменклатуры.MetaDataName = "Метаданные";
            this.vmoТаблицаНоменклатуры.FullName = "_SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры.Владелец";
            // 
            // vmoТаблицаНоменклатуры
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Мониторинг.Должности.ТаблицаНеобязательнойНоменклатуры";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаНоменклатуры.Columns.Collection.Add(this.Идентификатор_vmoТаблицаНоменклатуры);
            this.vmoТаблицаНоменклатуры.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаНоменклатуры);
            this.vmoТаблицаНоменклатуры.Columns.Collection.Add(this.Владелец_vmoТаблицаНоменклатуры);
            this.vmoТаблицаНоменклатуры.Columns.Collection.Add(this.НомерСтроки_vmoТаблицаНоменклатуры);
            this.vmoТаблицаНоменклатуры.Columns.Collection.Add(this.Номенклатура);
            this.vmoТаблицаНоменклатуры.IsActive = true;
            this.vmoТаблицаНоменклатуры.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаНоменклатуры.Binding = nsgMasterDetailBinding2;
            // 
            // Идентификатор_vmoТаблицаНоменклатуры
            // 
            this.Идентификатор_vmoТаблицаНоменклатуры.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаНоменклатуры.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаНоменклатуры.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаНоменклатуры.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаНоменклатуры.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаНоменклатуры.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаНоменклатуры;
            this.Идентификатор_vmoТаблицаНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаНоменклатуры.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаНоменклатуры
            // 
            this.Автоинкремент_vmoТаблицаНоменклатуры.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаНоменклатуры.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаНоменклатуры.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаНоменклатуры.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаНоменклатуры.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаНоменклатуры.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаНоменклатуры.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаНоменклатуры;
            this.Автоинкремент_vmoТаблицаНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаНоменклатуры.Visible = false;
            // 
            // Владелец_vmoТаблицаНоменклатуры
            // 
            this.Владелец_vmoТаблицаНоменклатуры.AutoGenerated = true;
            this.Владелец_vmoТаблицаНоменклатуры.Caption = "Владелец";
            this.Владелец_vmoТаблицаНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТаблицаНоменклатуры.Name = "Владелец";
            this.Владелец_vmoТаблицаНоменклатуры.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаНоменклатуры.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаНоменклатуры.SearchCondition.OwnerComponent = this.Владелец_vmoТаблицаНоменклатуры;
            this.Владелец_vmoТаблицаНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТаблицаНоменклатуры
            // 
            this.НомерСтроки_vmoТаблицаНоменклатуры.AutoGenerated = true;
            this.НомерСтроки_vmoТаблицаНоменклатуры.CalcTotal = false;
            this.НомерСтроки_vmoТаблицаНоменклатуры.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТаблицаНоменклатуры.Name = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаНоменклатуры.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТаблицаНоменклатуры.PropertyType = typeof(long);
            this.НомерСтроки_vmoТаблицаНоменклатуры.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТаблицаНоменклатуры;
            this.НомерСтроки_vmoТаблицаНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТаблицаНоменклатуры.Visible = false;
            // 
            // Номенклатура
            // 
            this.Номенклатура.AutoGenerated = true;
            this.Номенклатура.Caption = "Номенклатура";
            this.Номенклатура.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Номенклатура.Name = "Номенклатура";
            this.Номенклатура.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура.SearchCondition.OwnerComponent = this.Номенклатура;
            this.Номенклатура.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.Controls.Add(this.nsgInput7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 44);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для документов";
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
            // РежимРаботы
            // 
            this.РежимРаботы.AutoGenerated = true;
            this.РежимРаботы.Caption = "РежимРаботы";
            this.РежимРаботы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.РежимРаботы.Name = "РежимРаботы";
            this.РежимРаботы.NSGType = typeof(TechControl.Метаданные.Мониторинг.РежимыРаботы);
            this.РежимРаботы.PropertyType = typeof(TechControl.Метаданные.Мониторинг.РежимыРаботы);
            this.РежимРаботы.SearchCondition.OwnerComponent = this.РежимРаботы;
            this.РежимРаботы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Описание
            // 
            this.Описание.AutoGenerated = true;
            this.Описание.Caption = "Описание";
            this.Описание.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Описание.Name = "Описание";
            this.Описание.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Описание.PropertyType = typeof(string);
            this.Описание.SearchCondition.OwnerComponent = this.Описание;
            this.Описание.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЯвляетсяСтаршимПоОбъекту
            // 
            this.ЯвляетсяСтаршимПоОбъекту.AutoGenerated = true;
            this.ЯвляетсяСтаршимПоОбъекту.Caption = "ЯвляетсяСтаршимПоОбъекту";
            this.ЯвляетсяСтаршимПоОбъекту.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЯвляетсяСтаршимПоОбъекту.Name = "ЯвляетсяСтаршимПоОбъекту";
            this.ЯвляетсяСтаршимПоОбъекту.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЯвляетсяСтаршимПоОбъекту.PropertyType = typeof(bool);
            this.ЯвляетсяСтаршимПоОбъекту.SearchCondition.OwnerComponent = this.ЯвляетсяСтаршимПоОбъекту;
            this.ЯвляетсяСтаршимПоОбъекту.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГруппаДолжностей
            // 
            this.ГруппаДолжностей.AutoGenerated = true;
            this.ГруппаДолжностей.Caption = "ГруппаДолжностей";
            this.ГруппаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГруппаДолжностей.Name = "ГруппаДолжностей";
            this.ГруппаДолжностей.NSGType = typeof(TechControl.Метаданные.Мониторинг.ГруппыДолжностей);
            this.ГруппаДолжностей.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ГруппыДолжностей);
            this.ГруппаДолжностей.SearchCondition.OwnerComponent = this.ГруппаДолжностей;
            this.ГруппаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Роль
            // 
            this.Роль.AutoGenerated = true;
            this.Роль.Caption = "Роль";
            this.Роль.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Роль.Name = "Роль";
            this.Роль.NSGType = typeof(TechControl.Метаданные.Мониторинг.Роль);
            this.Роль.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Роль);
            this.Роль.SearchCondition.OwnerComponent = this.Роль;
            this.Роль.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // ТаблицаКомплектовСпецодежды
            // 
            this.ТаблицаКомплектовСпецодежды.AutoGenerated = true;
            this.ТаблицаКомплектовСпецодежды.Caption = "ТаблицаКомплектовСпецодежды";
            this.ТаблицаКомплектовСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаКомплектовСпецодежды.Name = "ТаблицаКомплектовСпецодежды";
            this.ТаблицаКомплектовСпецодежды.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды);
            this.ТаблицаКомплектовСпецодежды.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды);
            this.ТаблицаКомплектовСпецодежды.SearchCondition.OwnerComponent = this.ТаблицаКомплектовСпецодежды;
            this.ТаблицаКомплектовСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаКомплектовСпецодежды.Visible = false;
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
            // ТаблицаНеобязательнойНоменклатуры
            // 
            this.ТаблицаНеобязательнойНоменклатуры.AutoGenerated = true;
            this.ТаблицаНеобязательнойНоменклатуры.Caption = "ТаблицаНеобязательнойНоменклатуры";
            this.ТаблицаНеобязательнойНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаНеобязательнойНоменклатуры.Name = "ТаблицаНеобязательнойНоменклатуры";
            this.ТаблицаНеобязательнойНоменклатуры.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры);
            this.ТаблицаНеобязательнойНоменклатуры.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры);
            this.ТаблицаНеобязательнойНоменклатуры.SearchCondition.OwnerComponent = this.ТаблицаНеобязательнойНоменклатуры;
            this.ТаблицаНеобязательнойНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаНеобязательнойНоменклатуры.Visible = false;
            // 
            // НаименованиеРодительныйПадеж
            // 
            this.НаименованиеРодительныйПадеж.AutoGenerated = true;
            this.НаименованиеРодительныйПадеж.Caption = "НаименованиеРодительныйПадеж";
            this.НаименованиеРодительныйПадеж.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НаименованиеРодительныйПадеж.Name = "НаименованиеРодительныйПадеж";
            this.НаименованиеРодительныйПадеж.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НаименованиеРодительныйПадеж.PropertyType = typeof(string);
            this.НаименованиеРодительныйПадеж.SearchCondition.OwnerComponent = this.НаименованиеРодительныйПадеж;
            this.НаименованиеРодительныйПадеж.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "НаименованиеРодительныйПадеж";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(151, 16);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "НаименованиеРодительныйПадеж";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(280, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 11;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label1";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Наименование Род.Падеж";
            // 
            // ДолжностиФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 570);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаКомплектов)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpОсновные.ResumeLayout(false);
            this.tpОсновные.PerformLayout();
            this.tpКомплекты.ResumeLayout(false);
            this.tpТаблНоменклатуры.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаНоменклатуры)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgInput nsgInput1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected NsgInput nsgInput2;
        protected System.Windows.Forms.Label label3;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label4;
        protected NsgInput nsgInput4;
        protected System.Windows.Forms.Label label5;
        protected NsgInput nsgInput5;
        protected System.Windows.Forms.Label label6;
        protected NsgInput nsgInput6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpОсновные;
        private System.Windows.Forms.TabPage tpКомплекты;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаКомплектов;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаКомплектов;
        private NsgColumnDescriptor.MultipleObject Владелец;
        private NsgColumnDescriptor.Int64 НомерСтроки;
        private УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor КомплектСпецодежды;
        protected NsgColumnDescriptor.Int64 Количество;
        private NsgIGrid nsgIGrid1;
        private NsgVisualMultipleObject vmoТаблицаКомплектов;
        private System.Windows.Forms.TabPage tpТаблНоменклатуры;
        protected NsgIGrid nsgIGrid2;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаНоменклатуры;
        protected NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаНоменклатуры;
        protected NsgColumnDescriptor.MultipleObject Владелец_vmoТаблицаНоменклатуры;
        protected NsgColumnDescriptor.Int64 НомерСтроки_vmoТаблицаНоменклатуры;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура;
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
        protected РежимыРаботы.ColumnDescriptor РежимРаботы;
        protected NsgColumnDescriptor.String Описание;
        protected NsgColumnDescriptor.Boolean ЯвляетсяСтаршимПоОбъекту;
        protected ГруппыДолжностей.ColumnDescriptor ГруппаДолжностей;
        protected Роль.ColumnDescriptor Роль;
        protected СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        protected _SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды.ColumnDescriptor ТаблицаКомплектовСпецодежды;
        protected NsgColumnDescriptor.String ЗагрузочныйИдентификатор;
        protected _SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры.ColumnDescriptor ТаблицаНеобязательнойНоменклатуры;
        protected NsgColumnDescriptor.String НаименованиеРодительныйПадеж;
        protected Должности.ColumnDescriptor Родитель;
        private System.Windows.Forms.GroupBox groupBox1;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        private NsgVisualMultipleObject vmoТаблицаНоменклатуры;
    }
}