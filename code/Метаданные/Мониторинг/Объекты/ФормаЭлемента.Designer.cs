using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ОбъектыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОбъектыФормаЭлемента));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn11 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding3 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor5 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor6 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn12 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn13 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn15 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding4 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor7 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor8 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding5 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor9 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor10 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoПерсонал = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Приоритет = new TechControl.Метаданные.Сервис.Приоритет.ColumnDescriptor();
            this.Должность_vmoПерсонал = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТехника = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТехника = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТехника = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТехника = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТехника = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Техника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТарифы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТарифы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Тариф = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Стоимость = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИспользоватьПоУмолчанию = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ГруппаСпецТехники = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.nsgIGrid4 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТарифыПерсонал = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.Стоимость_vmoТарифыПерсонал = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Тариф_vmoТарифыПерсонал = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.nsgIGrid5 = new NsgSoft.Forms.NsgIGrid();
            this.vmoСистемыСлежения = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ТипСистемыСлежения = new TechControl.Метаданные.Мониторинг.ТипСистемыСлежения.ColumnDescriptor();
            this.ИдентификаторСистемыСлежения = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel1 = new NsgSoft.Forms.NsgLabel();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel3 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel4 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel5 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel6 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel7 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel8 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel9 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel10 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel11 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.nsgInput12 = new NsgSoft.Forms.NsgInput();
            this.nsgInput13 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel12 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput14 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel13 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput15 = new NsgSoft.Forms.NsgInput();
            this.ПоставщикТоплива = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.tabControlТарифы = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput16 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel14 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput17 = new NsgSoft.Forms.NsgInput();
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
            this.Адрес = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Заказчик = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.СобственностьТехники = new TechControl.Метаданные.Мониторинг.ТипСобственности.ColumnDescriptor();
            this.ГраницаОбъектаМониторинга = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НачалоРабочейСмены = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Ответственный = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.КонецРабочейСмены = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Фирма = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.РежимРаботы = new TechControl.Метаданные.Мониторинг.РежимыРаботы.ColumnDescriptor();
            this.Договор = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Включен = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ТаблицаПерсонал = new TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаПерсонал.ColumnDescriptor();
            this.ТаблицаТехника = new TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТехника.ColumnDescriptor();
            this.Руководитель = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.СменаОткрыта = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ТаблицаТарифы = new TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифы.ColumnDescriptor();
            this.ПоставщикТоплива_nsgVisualMultipleObject = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.ТаблицаТарифыСотрудников = new TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифыСотрудников.ColumnDescriptor();
            this.МашинВРаботе = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.МашинНеВРаботе = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.МашинСломано = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ТаблицаСистемыСлежения = new TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаСистемыСлежения.ColumnDescriptor();
            this.АккаунтПользователя = new TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor();
            this.Геозона = new TechControl.Метаданные.Мониторинг.Геозоны.ColumnDescriptor();
            this.ЗаправочнаяЕмкость = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Родитель = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoПерсонал)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТехника)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифыПерсонал)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСистемыСлежения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).BeginInit();
            this.tabControlТарифы.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).BeginInit();
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
            this.nsgEdit.Location = new System.Drawing.Point(1127, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(1243, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(1322, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(857, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(952, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(1036, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 418);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1322, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(857, 1);
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
            this.Comment.FullName = "Мониторинг.Объекты.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(1322, 23);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Адрес);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Заказчик);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СобственностьТехники);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ГраницаОбъектаМониторинга);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НачалоРабочейСмены);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Ответственный);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КонецРабочейСмены);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Фирма);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.РежимРаботы);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Договор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Включен);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаПерсонал);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаТехника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Руководитель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СменаОткрыта);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаТарифы);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПоставщикТоплива_nsgVisualMultipleObject);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаТарифыСотрудников);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МашинВРаботе);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МашинНеВРаботе);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МашинСломано);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаСистемыСлежения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.АккаунтПользователя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Геозона);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЗаправочнаяЕмкость);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.Объекты";
            // 
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
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
            nsgIGridColumn2.Name = "Сотрудник";
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
            nsgIGridColumn3.Name = "Должность";
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
            nsgIGridColumn4.ImportedFromVMO = false;
            nsgIGridColumn4.InitiateRowEdit = true;
            nsgIGridColumn4.Name = "Приоритет";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(21, 161);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(283, 224);
            this.nsgIGrid1.SourceObject = this.vmoПерсонал;
            this.nsgIGrid1.TabIndex = 31;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellEndEdit);
            this.vmoПерсонал.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoПерсонал.MetaDataName = "Метаданные";
            this.vmoПерсонал.FullName = "_SystemTables.МониторингОбъектыТаблицаПерсонал.Владелец";
            // 
            // vmoПерсонал
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингОбъектыТаблицаПерсонал.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.Объекты.ТаблицаПерсонал";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoПерсонал.Columns.Collection.Add(this.Идентификатор_vmoПерсонал);
            this.vmoПерсонал.Columns.Collection.Add(this.Автоинкремент_vmoПерсонал);
            this.vmoПерсонал.Columns.Collection.Add(this.Владелец);
            this.vmoПерсонал.Columns.Collection.Add(this.НомерСтроки);
            this.vmoПерсонал.Columns.Collection.Add(this.Сотрудник);
            this.vmoПерсонал.Columns.Collection.Add(this.Приоритет);
            this.vmoПерсонал.Columns.Collection.Add(this.Должность_vmoПерсонал);
            this.vmoПерсонал.IsActive = true;
            this.vmoПерсонал.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoПерсонал.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoПерсонал
            // 
            this.Идентификатор_vmoПерсонал.AutoGenerated = true;
            this.Идентификатор_vmoПерсонал.Caption = "Идентификатор";
            this.Идентификатор_vmoПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoПерсонал.Name = "Идентификатор";
            this.Идентификатор_vmoПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoПерсонал.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoПерсонал.SearchCondition.OwnerComponent = this.Идентификатор_vmoПерсонал;
            this.Идентификатор_vmoПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoПерсонал.Visible = false;
            // 
            // Автоинкремент_vmoПерсонал
            // 
            this.Автоинкремент_vmoПерсонал.AutoGenerated = true;
            this.Автоинкремент_vmoПерсонал.CalcTotal = false;
            this.Автоинкремент_vmoПерсонал.Caption = "Автоинкремент";
            this.Автоинкремент_vmoПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoПерсонал.Name = "Автоинкремент";
            this.Автоинкремент_vmoПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoПерсонал.PropertyType = typeof(long);
            this.Автоинкремент_vmoПерсонал.SearchCondition.OwnerComponent = this.Автоинкремент_vmoПерсонал;
            this.Автоинкремент_vmoПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoПерсонал.Visible = false;
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
            // Приоритет
            // 
            this.Приоритет.AutoGenerated = true;
            this.Приоритет.Caption = "Приоритет";
            this.Приоритет.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Приоритет.Name = "Приоритет";
            this.Приоритет.NSGType = typeof(TechControl.Метаданные.Сервис.Приоритет);
            this.Приоритет.PropertyType = typeof(TechControl.Метаданные.Сервис.Приоритет);
            this.Приоритет.SearchCondition.OwnerComponent = this.Приоритет;
            this.Приоритет.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность_vmoПерсонал
            // 
            this.Должность_vmoПерсонал.AutoGenerated = true;
            this.Должность_vmoПерсонал.Caption = "Должность";
            this.Должность_vmoПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Должность_vmoПерсонал.Name = "Должность";
            this.Должность_vmoПерсонал.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoПерсонал.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoПерсонал.SearchCondition.OwnerComponent = this.Должность_vmoПерсонал;
            this.Должность_vmoПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid2
            // 
            this.nsgIGrid2.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid2.AllowSaveColParamsToXML = true;
            this.nsgIGrid2.AllowSaveColPositionToXML = true;
            this.nsgIGrid2.AllowSaveColWidthToXML = true;
            this.nsgIGrid2.AllowSaveSettingsToXML = true;
            this.nsgIGrid2.AutoResizeCols = true;
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
            nsgIGridColumn5.Name = "Владелец";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Visible = false;
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
            nsgIGridColumn6.Name = "Техника";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
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
            this.nsgIGrid2.Location = new System.Drawing.Point(331, 161);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(306, 224);
            this.nsgIGrid2.SourceObject = this.vmoТехника;
            this.nsgIGrid2.TabIndex = 32;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТехника.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТехника.MetaDataName = "Метаданные";
            this.vmoТехника.FullName = "_SystemTables.МониторингОбъектыТаблицаТехника.Владелец";
            // 
            // vmoТехника
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.МониторингОбъектыТаблицаТехника.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Мониторинг.Объекты.ТаблицаТехника";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТехника.Columns.Collection.Add(this.Идентификатор_vmoТехника);
            this.vmoТехника.Columns.Collection.Add(this.Автоинкремент_vmoТехника);
            this.vmoТехника.Columns.Collection.Add(this.Владелец_vmoТехника);
            this.vmoТехника.Columns.Collection.Add(this.НомерСтроки_vmoТехника);
            this.vmoТехника.Columns.Collection.Add(this.Техника);
            this.vmoТехника.IsActive = true;
            this.vmoТехника.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТехника.Binding = nsgMasterDetailBinding2;
            // 
            // Идентификатор_vmoТехника
            // 
            this.Идентификатор_vmoТехника.AutoGenerated = true;
            this.Идентификатор_vmoТехника.Caption = "Идентификатор";
            this.Идентификатор_vmoТехника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТехника.Name = "Идентификатор";
            this.Идентификатор_vmoТехника.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТехника.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТехника.SearchCondition.OwnerComponent = this.Идентификатор_vmoТехника;
            this.Идентификатор_vmoТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТехника.Visible = false;
            // 
            // Автоинкремент_vmoТехника
            // 
            this.Автоинкремент_vmoТехника.AutoGenerated = true;
            this.Автоинкремент_vmoТехника.CalcTotal = false;
            this.Автоинкремент_vmoТехника.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТехника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТехника.Name = "Автоинкремент";
            this.Автоинкремент_vmoТехника.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТехника.PropertyType = typeof(long);
            this.Автоинкремент_vmoТехника.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТехника;
            this.Автоинкремент_vmoТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТехника.Visible = false;
            // 
            // Владелец_vmoТехника
            // 
            this.Владелец_vmoТехника.AutoGenerated = true;
            this.Владелец_vmoТехника.Caption = "Владелец";
            this.Владелец_vmoТехника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТехника.Name = "Владелец";
            this.Владелец_vmoТехника.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТехника.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТехника.SearchCondition.OwnerComponent = this.Владелец_vmoТехника;
            this.Владелец_vmoТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТехника
            // 
            this.НомерСтроки_vmoТехника.AutoGenerated = true;
            this.НомерСтроки_vmoТехника.CalcTotal = false;
            this.НомерСтроки_vmoТехника.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТехника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТехника.Name = "НомерСтроки";
            this.НомерСтроки_vmoТехника.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТехника.PropertyType = typeof(long);
            this.НомерСтроки_vmoТехника.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТехника;
            this.НомерСтроки_vmoТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТехника.Visible = false;
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
        "Visible"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.ImportedFromVMO = false;
            nsgIGridColumn7.InitiateRowEdit = true;
            nsgIGridColumn7.Name = "Владелец";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Visible = false;
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
            nsgIGridColumn8.ImportedFromVMO = false;
            nsgIGridColumn8.InitiateRowEdit = true;
            nsgIGridColumn8.Name = "ГруппаСпецТехники";
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
            nsgIGridColumn9.ImportedFromVMO = false;
            nsgIGridColumn9.InitiateRowEdit = true;
            nsgIGridColumn9.Name = "Тариф";
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
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.InitiateRowEdit = true;
            nsgIGridColumn10.Name = "Стоимость";
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
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.InitiateRowEdit = true;
            nsgIGridColumn11.Name = "ИспользоватьПоУмолчанию";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.UseAsHeaderImage = false;
            nsgIGridColumn11.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(0, 0);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(348, 169);
            this.nsgIGrid3.SourceObject = this.vmoТарифы;
            this.nsgIGrid3.TabIndex = 34;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid3.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGridТарифыТехники_CellEndEdit);
            this.vmoТарифы.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor6.ConfigurationName = "TechControl";
            this.vmoТарифы.MetaDataName = "Метаданные";
            this.vmoТарифы.FullName = "_SystemTables.МониторингОбъектыТаблицаТарифы.Владелец";
            // 
            // vmoТарифы
            // 
            nsgObjectDescriptor5.ConfigurationName = "TechControl";
            nsgObjectDescriptor5.FullName = "_SystemTables.МониторингОбъектыТаблицаТарифы.Владелец";
            nsgObjectDescriptor5.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.DetailField = nsgObjectDescriptor5;
            nsgObjectDescriptor6.FullName = "Мониторинг.Объекты.ТаблицаТарифы";
            nsgObjectDescriptor6.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.MasterField = nsgObjectDescriptor6;
            nsgMasterDetailBinding3.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТарифы.Columns.Collection.Add(this.Идентификатор_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Автоинкремент_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Владелец_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.НомерСтроки_vmoТарифы);
            this.vmoТарифы.Columns.Collection.Add(this.Тариф);
            this.vmoТарифы.Columns.Collection.Add(this.Стоимость);
            this.vmoТарифы.Columns.Collection.Add(this.ИспользоватьПоУмолчанию);
            this.vmoТарифы.Columns.Collection.Add(this.ГруппаСпецТехники);
            this.vmoТарифы.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТарифы.Binding = nsgMasterDetailBinding3;
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
            // nsgIGrid4
            // 
            this.nsgIGrid4.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid4.AllowSaveColParamsToXML = true;
            this.nsgIGrid4.AllowSaveColPositionToXML = true;
            this.nsgIGrid4.AllowSaveColWidthToXML = true;
            this.nsgIGrid4.AllowSaveSettingsToXML = true;
            this.nsgIGrid4.AutoResizeCols = true;
            nsgIGridColumn12.AllowFilter = true;
            nsgIGridColumn12.AllowGroupSelect = false;
            nsgIGridColumn12.AllowResize = true;
            nsgIGridColumn12.AutoResize = true;
            nsgIGridColumn12.Caption = "";
            nsgIGridColumn12.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn12.DateFormat = null;
            nsgIGridColumn12.ImportedFromVMO = false;
            nsgIGridColumn12.InitiateRowEdit = true;
            nsgIGridColumn12.Name = "Владелец";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn12.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn12.UseAsHeaderImage = false;
            nsgIGridColumn12.Visible = false;
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
            nsgIGridColumn13.InitiateRowEdit = true;
            nsgIGridColumn13.Name = "ГруппаДолжностей";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn14.Name = "Тариф";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Width = 100;
            nsgIGridColumn15.AllowFilter = true;
            nsgIGridColumn15.AllowGroupSelect = false;
            nsgIGridColumn15.AllowResize = true;
            nsgIGridColumn15.AutoResize = true;
            nsgIGridColumn15.Caption = "";
            nsgIGridColumn15.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn15.DateFormat = null;
            nsgIGridColumn15.ImportedFromVMO = false;
            nsgIGridColumn15.InitiateRowEdit = true;
            nsgIGridColumn15.Name = "Стоимость";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn15.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn15.UseAsHeaderImage = false;
            nsgIGridColumn15.Width = 100;
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.ImportedFromVMO = false;
            nsgIGridColumn16.InitiateRowEdit = true;
            nsgIGridColumn16.Name = "ИспользоватьПоУмолчанию";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn17.InitiateRowEdit = true;
            nsgIGridColumn17.Name = "Должность";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn17.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn17.UseAsHeaderImage = false;
            nsgIGridColumn17.Visible = false;
            nsgIGridColumn17.Width = 100;
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid4.Filter = false;
            this.nsgIGrid4.FrozenColumns = 0;
            this.nsgIGrid4.Grouping = true;
            this.nsgIGrid4.Hierarhy = true;
            this.nsgIGrid4.ImageList = null;
            this.nsgIGrid4.IsCanMultiSelect = false;
            this.nsgIGrid4.IsCanSingleSelect = false;
            this.nsgIGrid4.LineHeight = 20;
            this.nsgIGrid4.Location = new System.Drawing.Point(0, 0);
            this.nsgIGrid4.MarkReadOnly = false;
            this.nsgIGrid4.MasterObject = null;
            this.nsgIGrid4.Name = "NsgIGrid";
            this.nsgIGrid4.PageSelector = false;
            this.nsgIGrid4.ReadOnly = false;
            this.nsgIGrid4.RowChangeInterval = 200;
            this.nsgIGrid4.RowHeaderImageList = null;
            this.nsgIGrid4.RowMode = false;
            this.nsgIGrid4.ScrollWidth = 0;
            this.nsgIGrid4.SelectedRow = -1;
            this.nsgIGrid4.ShowHeader = true;
            this.nsgIGrid4.ShowLineImages = true;
            this.nsgIGrid4.ShowLineNumbers = false;
            this.nsgIGrid4.ShowPanel = true;
            this.nsgIGrid4.ShowTotals = false;
            this.nsgIGrid4.ShowTree = false;
            this.nsgIGrid4.Size = new System.Drawing.Size(351, 172);
            this.nsgIGrid4.SourceObject = this.vmoТарифыПерсонал;
            this.nsgIGrid4.TabIndex = 0;
            this.nsgIGrid4.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid4.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGridТарифыПерсонала_CellEndEdit);
            this.vmoТарифыПерсонал.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor8.ConfigurationName = "TechControl";
            this.vmoТарифыПерсонал.MetaDataName = "Метаданные";
            this.vmoТарифыПерсонал.FullName = "_SystemTables.МониторингОбъектыТаблицаТарифыСотрудников.Владелец";
            // 
            // vmoТарифыПерсонал
            // 
            nsgObjectDescriptor7.ConfigurationName = "TechControl";
            nsgObjectDescriptor7.FullName = "_SystemTables.МониторингОбъектыТаблицаТарифыСотрудников.Владелец";
            nsgObjectDescriptor7.MetaDataName = "Метаданные";
            nsgMasterDetailBinding4.DetailField = nsgObjectDescriptor7;
            nsgObjectDescriptor8.FullName = "Мониторинг.Объекты.ТаблицаТарифыСотрудников";
            nsgObjectDescriptor8.MetaDataName = "Метаданные";
            nsgMasterDetailBinding4.MasterField = nsgObjectDescriptor8;
            nsgMasterDetailBinding4.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Идентификатор_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Автоинкремент_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Владелец_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.НомерСтроки_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Стоимость_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Тариф_vmoТарифыПерсонал);
            this.vmoТарифыПерсонал.Columns.Collection.Add(this.Должность);
            this.vmoТарифыПерсонал.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТарифыПерсонал.Binding = nsgMasterDetailBinding4;
            // 
            // Идентификатор_vmoТарифыПерсонал
            // 
            this.Идентификатор_vmoТарифыПерсонал.AutoGenerated = true;
            this.Идентификатор_vmoТарифыПерсонал.Caption = "Идентификатор";
            this.Идентификатор_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТарифыПерсонал.Name = "Идентификатор";
            this.Идентификатор_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТарифыПерсонал.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.Идентификатор_vmoТарифыПерсонал;
            this.Идентификатор_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТарифыПерсонал.Visible = false;
            // 
            // Автоинкремент_vmoТарифыПерсонал
            // 
            this.Автоинкремент_vmoТарифыПерсонал.AutoGenerated = true;
            this.Автоинкремент_vmoТарифыПерсонал.CalcTotal = false;
            this.Автоинкремент_vmoТарифыПерсонал.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТарифыПерсонал.Name = "Автоинкремент";
            this.Автоинкремент_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТарифыПерсонал.PropertyType = typeof(long);
            this.Автоинкремент_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТарифыПерсонал;
            this.Автоинкремент_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТарифыПерсонал.Visible = false;
            // 
            // Владелец_vmoТарифыПерсонал
            // 
            this.Владелец_vmoТарифыПерсонал.AutoGenerated = true;
            this.Владелец_vmoТарифыПерсонал.Caption = "Владелец";
            this.Владелец_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТарифыПерсонал.Name = "Владелец";
            this.Владелец_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТарифыПерсонал.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.Владелец_vmoТарифыПерсонал;
            this.Владелец_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТарифыПерсонал
            // 
            this.НомерСтроки_vmoТарифыПерсонал.AutoGenerated = true;
            this.НомерСтроки_vmoТарифыПерсонал.CalcTotal = false;
            this.НомерСтроки_vmoТарифыПерсонал.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТарифыПерсонал.Name = "НомерСтроки";
            this.НомерСтроки_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТарифыПерсонал.PropertyType = typeof(long);
            this.НомерСтроки_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТарифыПерсонал;
            this.НомерСтроки_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТарифыПерсонал.Visible = false;
            // 
            // ИспользоватьПоУмолчанию_vmoТарифыПерсонал
            // 
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.AutoGenerated = true;
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.Caption = "ИспользоватьПоУмолчанию";
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.Name = "ИспользоватьПоУмолчанию";
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.PropertyType = typeof(bool);
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал;
            this.ИспользоватьПоУмолчанию_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Стоимость_vmoТарифыПерсонал
            // 
            this.Стоимость_vmoТарифыПерсонал.AutoGenerated = true;
            this.Стоимость_vmoТарифыПерсонал.CalcTotal = false;
            this.Стоимость_vmoТарифыПерсонал.Caption = "Стоимость";
            this.Стоимость_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Стоимость_vmoТарифыПерсонал.Name = "Стоимость";
            this.Стоимость_vmoТарифыПерсонал.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Стоимость_vmoТарифыПерсонал.PropertyType = typeof(decimal);
            this.Стоимость_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.Стоимость_vmoТарифыПерсонал;
            this.Стоимость_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТарифыПерсонал
            // 
            this.Тариф_vmoТарифыПерсонал.AutoGenerated = true;
            this.Тариф_vmoТарифыПерсонал.Caption = "Тариф";
            this.Тариф_vmoТарифыПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Тариф_vmoТарифыПерсонал.Name = "Тариф";
            this.Тариф_vmoТарифыПерсонал.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТарифыПерсонал.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТарифыПерсонал.SearchCondition.OwnerComponent = this.Тариф_vmoТарифыПерсонал;
            this.Тариф_vmoТарифыПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // nsgIGrid5
            // 
            this.nsgIGrid5.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid5.AllowSaveColParamsToXML = true;
            this.nsgIGrid5.AllowSaveColPositionToXML = true;
            this.nsgIGrid5.AllowSaveColWidthToXML = true;
            this.nsgIGrid5.AllowSaveSettingsToXML = true;
            this.nsgIGrid5.AutoResizeCols = true;
            nsgIGridColumn18.AllowFilter = true;
            nsgIGridColumn18.AllowGroupSelect = false;
            nsgIGridColumn18.AllowResize = true;
            nsgIGridColumn18.AutoResize = true;
            nsgIGridColumn18.Caption = "";
            nsgIGridColumn18.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn18.DateFormat = null;
            nsgIGridColumn18.ImportedFromVMO = false;
            nsgIGridColumn18.InitiateRowEdit = true;
            nsgIGridColumn18.Name = "Владелец";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid5.Columns.Collection;
            nsgIGridColumn18.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn18.UseAsHeaderImage = false;
            nsgIGridColumn18.Visible = false;
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
            nsgIGridColumn19.InitiateRowEdit = true;
            nsgIGridColumn19.Name = "ТипСистемыСлежения";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid5.Columns.Collection;
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
            nsgIGridColumn20.InitiateRowEdit = true;
            nsgIGridColumn20.Name = "ИдентификаторСистемыСлежения";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid5.Columns.Collection;
            nsgIGridColumn20.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn20.UseAsHeaderImage = false;
            nsgIGridColumn20.Width = 100;
            this.nsgIGrid5.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid5.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid5.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid5.Filter = false;
            this.nsgIGrid5.FrozenColumns = 0;
            this.nsgIGrid5.Grouping = true;
            this.nsgIGrid5.Hierarhy = true;
            this.nsgIGrid5.ImageList = null;
            this.nsgIGrid5.IsCanMultiSelect = false;
            this.nsgIGrid5.IsCanSingleSelect = false;
            this.nsgIGrid5.LineHeight = 20;
            this.nsgIGrid5.Location = new System.Drawing.Point(0, 0);
            this.nsgIGrid5.MarkReadOnly = false;
            this.nsgIGrid5.MasterObject = null;
            this.nsgIGrid5.Name = "NsgIGrid";
            this.nsgIGrid5.PageSelector = false;
            this.nsgIGrid5.ReadOnly = false;
            this.nsgIGrid5.RowChangeInterval = 200;
            this.nsgIGrid5.RowHeaderImageList = null;
            this.nsgIGrid5.RowMode = false;
            this.nsgIGrid5.ScrollWidth = 0;
            this.nsgIGrid5.SelectedRow = -1;
            this.nsgIGrid5.ShowHeader = true;
            this.nsgIGrid5.ShowLineImages = true;
            this.nsgIGrid5.ShowLineNumbers = false;
            this.nsgIGrid5.ShowPanel = true;
            this.nsgIGrid5.ShowTotals = false;
            this.nsgIGrid5.ShowTree = false;
            this.nsgIGrid5.Size = new System.Drawing.Size(351, 172);
            this.nsgIGrid5.SourceObject = this.vmoСистемыСлежения;
            this.nsgIGrid5.TabIndex = 0;
            this.nsgIGrid5.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoСистемыСлежения.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor10.ConfigurationName = "TechControl";
            this.vmoСистемыСлежения.MetaDataName = "Метаданные";
            this.vmoСистемыСлежения.FullName = "_SystemTables.МониторингОбъектыТаблицаСистемыСлежения.Владелец";
            // 
            // vmoСистемыСлежения
            // 
            nsgObjectDescriptor9.ConfigurationName = "TechControl";
            nsgObjectDescriptor9.FullName = "_SystemTables.МониторингОбъектыТаблицаСистемыСлежения.Владелец";
            nsgObjectDescriptor9.MetaDataName = "Метаданные";
            nsgMasterDetailBinding5.DetailField = nsgObjectDescriptor9;
            nsgObjectDescriptor10.FullName = "Мониторинг.Объекты.ТаблицаСистемыСлежения";
            nsgObjectDescriptor10.MetaDataName = "Метаданные";
            nsgMasterDetailBinding5.MasterField = nsgObjectDescriptor10;
            nsgMasterDetailBinding5.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Идентификатор_vmoСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Автоинкремент_vmoСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.Владелец_vmoСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.НомерСтроки_vmoСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.ТипСистемыСлежения);
            this.vmoСистемыСлежения.Columns.Collection.Add(this.ИдентификаторСистемыСлежения);
            this.vmoСистемыСлежения.IsActive = true;
            this.vmoСистемыСлежения.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoСистемыСлежения.Binding = nsgMasterDetailBinding5;
            // 
            // Идентификатор_vmoСистемыСлежения
            // 
            this.Идентификатор_vmoСистемыСлежения.AutoGenerated = true;
            this.Идентификатор_vmoСистемыСлежения.Caption = "Идентификатор";
            this.Идентификатор_vmoСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoСистемыСлежения.Name = "Идентификатор";
            this.Идентификатор_vmoСистемыСлежения.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoСистемыСлежения.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoСистемыСлежения.SearchCondition.OwnerComponent = this.Идентификатор_vmoСистемыСлежения;
            this.Идентификатор_vmoСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoСистемыСлежения.Visible = false;
            // 
            // Автоинкремент_vmoСистемыСлежения
            // 
            this.Автоинкремент_vmoСистемыСлежения.AutoGenerated = true;
            this.Автоинкремент_vmoСистемыСлежения.CalcTotal = false;
            this.Автоинкремент_vmoСистемыСлежения.Caption = "Автоинкремент";
            this.Автоинкремент_vmoСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoСистемыСлежения.Name = "Автоинкремент";
            this.Автоинкремент_vmoСистемыСлежения.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoСистемыСлежения.PropertyType = typeof(long);
            this.Автоинкремент_vmoСистемыСлежения.SearchCondition.OwnerComponent = this.Автоинкремент_vmoСистемыСлежения;
            this.Автоинкремент_vmoСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoСистемыСлежения.Visible = false;
            // 
            // Владелец_vmoСистемыСлежения
            // 
            this.Владелец_vmoСистемыСлежения.AutoGenerated = true;
            this.Владелец_vmoСистемыСлежения.Caption = "Владелец";
            this.Владелец_vmoСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoСистемыСлежения.Name = "Владелец";
            this.Владелец_vmoСистемыСлежения.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoСистемыСлежения.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoСистемыСлежения.SearchCondition.OwnerComponent = this.Владелец_vmoСистемыСлежения;
            this.Владелец_vmoСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoСистемыСлежения
            // 
            this.НомерСтроки_vmoСистемыСлежения.AutoGenerated = true;
            this.НомерСтроки_vmoСистемыСлежения.CalcTotal = false;
            this.НомерСтроки_vmoСистемыСлежения.Caption = "НомерСтроки";
            this.НомерСтроки_vmoСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoСистемыСлежения.Name = "НомерСтроки";
            this.НомерСтроки_vmoСистемыСлежения.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoСистемыСлежения.PropertyType = typeof(long);
            this.НомерСтроки_vmoСистемыСлежения.SearchCondition.OwnerComponent = this.НомерСтроки_vmoСистемыСлежения;
            this.НомерСтроки_vmoСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoСистемыСлежения.Visible = false;
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
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.Объекты.Наименование";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(106, 9);
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
            this.nsgInput1.Size = new System.Drawing.Size(198, 20);
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
            this.nsgLabel1.Location = new System.Drawing.Point(18, 9);
            this.nsgLabel1.MetaDataName = "";
            this.nsgLabel1.Name = "nsgLabel1";
            this.nsgLabel1.Requsite = "";
            this.nsgLabel1.Size = new System.Drawing.Size(86, 13);
            this.nsgLabel1.TabIndex = 10;
            this.nsgLabel1.Text = "Наименование:";
            // 
            // nsgLabel2
            // 
            this.nsgLabel2.AutoSize = true;
            this.nsgLabel2.ConfigurationName = "";
            this.nsgLabel2.FullName = "";
            this.nsgLabel2.IsInitialized = false;
            this.nsgLabel2.Location = new System.Drawing.Point(18, 41);
            this.nsgLabel2.MetaDataName = "";
            this.nsgLabel2.Name = "nsgLabel1";
            this.nsgLabel2.Requsite = "";
            this.nsgLabel2.Size = new System.Drawing.Size(41, 13);
            this.nsgLabel2.TabIndex = 12;
            this.nsgLabel2.Text = "Адрес:";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.Объекты.Адрес";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(106, 41);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Адрес";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(198, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 11;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel3
            // 
            this.nsgLabel3.AutoSize = true;
            this.nsgLabel3.ConfigurationName = "";
            this.nsgLabel3.FullName = "";
            this.nsgLabel3.IsInitialized = false;
            this.nsgLabel3.Location = new System.Drawing.Point(328, 9);
            this.nsgLabel3.MetaDataName = "";
            this.nsgLabel3.Name = "nsgLabel1";
            this.nsgLabel3.Requsite = "";
            this.nsgLabel3.Size = new System.Drawing.Size(166, 13);
            this.nsgLabel3.TabIndex = 14;
            this.nsgLabel3.Text = "Граница объекта мониторинга:";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.Объекты.ГраницаОбъектаМониторинга";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(497, 9);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "ГраницаОбъектаМониторинга";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(337, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 13;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel4
            // 
            this.nsgLabel4.AutoSize = true;
            this.nsgLabel4.ConfigurationName = "";
            this.nsgLabel4.FullName = "";
            this.nsgLabel4.IsInitialized = false;
            this.nsgLabel4.Location = new System.Drawing.Point(18, 105);
            this.nsgLabel4.MetaDataName = "";
            this.nsgLabel4.Name = "nsgLabel1";
            this.nsgLabel4.Requsite = "";
            this.nsgLabel4.Size = new System.Drawing.Size(54, 13);
            this.nsgLabel4.TabIndex = 16;
            this.nsgLabel4.Text = "Договор:";
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Мониторинг.Объекты.Договор";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(106, 105);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Договор";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(198, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 15;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel5
            // 
            this.nsgLabel5.AutoSize = true;
            this.nsgLabel5.ConfigurationName = "";
            this.nsgLabel5.FullName = "";
            this.nsgLabel5.IsInitialized = false;
            this.nsgLabel5.Location = new System.Drawing.Point(18, 138);
            this.nsgLabel5.MetaDataName = "";
            this.nsgLabel5.Name = "nsgLabel1";
            this.nsgLabel5.Requsite = "";
            this.nsgLabel5.Size = new System.Drawing.Size(58, 13);
            this.nsgLabel5.TabIndex = 18;
            this.nsgLabel5.Text = "Заказчик:";
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Мониторинг.Объекты.Заказчик";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(106, 138);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "Заказчик";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(198, 20);
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
            this.nsgLabel6.Location = new System.Drawing.Point(328, 41);
            this.nsgLabel6.MetaDataName = "";
            this.nsgLabel6.Name = "nsgLabel1";
            this.nsgLabel6.Requsite = "";
            this.nsgLabel6.Size = new System.Drawing.Size(124, 13);
            this.nsgLabel6.TabIndex = 20;
            this.nsgLabel6.Text = "Время рабочей смены:";
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Мониторинг.Объекты.НачалоРабочейСмены";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(455, 41);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "НачалоРабочейСмены";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(182, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 19;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel7
            // 
            this.nsgLabel7.AutoSize = true;
            this.nsgLabel7.ConfigurationName = "";
            this.nsgLabel7.FullName = "";
            this.nsgLabel7.IsInitialized = false;
            this.nsgLabel7.Location = new System.Drawing.Point(641, 41);
            this.nsgLabel7.MetaDataName = "";
            this.nsgLabel7.Name = "nsgLabel1";
            this.nsgLabel7.Requsite = "";
            this.nsgLabel7.Size = new System.Drawing.Size(10, 13);
            this.nsgLabel7.TabIndex = 22;
            this.nsgLabel7.Text = "-";
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Мониторинг.Объекты.КонецРабочейСмены";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(654, 41);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "КонецРабочейСмены";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(180, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 21;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel8
            // 
            this.nsgLabel8.AutoSize = true;
            this.nsgLabel8.ConfigurationName = "";
            this.nsgLabel8.FullName = "";
            this.nsgLabel8.IsInitialized = false;
            this.nsgLabel8.Location = new System.Drawing.Point(328, 138);
            this.nsgLabel8.MetaDataName = "";
            this.nsgLabel8.Name = "nsgLabel1";
            this.nsgLabel8.Requsite = "";
            this.nsgLabel8.Size = new System.Drawing.Size(89, 13);
            this.nsgLabel8.TabIndex = 24;
            this.nsgLabel8.Text = "Ответственный:";
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "TechControl";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "Мониторинг.Объекты.Ответственный";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(455, 138);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "Метаданные";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "Ответственный";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(182, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 23;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel9
            // 
            this.nsgLabel9.AutoSize = true;
            this.nsgLabel9.ConfigurationName = "";
            this.nsgLabel9.FullName = "";
            this.nsgLabel9.IsInitialized = false;
            this.nsgLabel9.Location = new System.Drawing.Point(18, 73);
            this.nsgLabel9.MetaDataName = "";
            this.nsgLabel9.Name = "nsgLabel1";
            this.nsgLabel9.Requsite = "";
            this.nsgLabel9.Size = new System.Drawing.Size(85, 13);
            this.nsgLabel9.TabIndex = 26;
            this.nsgLabel9.Text = "Режим работы:";
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "TechControl";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "Мониторинг.Объекты.РежимРаботы";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(106, 73);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "Метаданные";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "РежимРаботы";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(198, 20);
            this.nsgInput9.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput9.TabIndex = 25;
            this.nsgInput9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel10
            // 
            this.nsgLabel10.AutoSize = true;
            this.nsgLabel10.ConfigurationName = "";
            this.nsgLabel10.FullName = "";
            this.nsgLabel10.IsInitialized = false;
            this.nsgLabel10.Location = new System.Drawing.Point(328, 73);
            this.nsgLabel10.MetaDataName = "";
            this.nsgLabel10.Name = "nsgLabel1";
            this.nsgLabel10.Requsite = "";
            this.nsgLabel10.Size = new System.Drawing.Size(108, 13);
            this.nsgLabel10.TabIndex = 28;
            this.nsgLabel10.Text = "Тип собственности:";
            // 
            // nsgInput10
            // 
            this.nsgInput10.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput10.ConfigurationName = "TechControl";
            this.nsgInput10.DisableLeaveControlEvent = false;
            this.nsgInput10.FullName = "Мониторинг.Объекты.СобственностьТехники";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(455, 73);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "Метаданные";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "СобственностьТехники";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(182, 20);
            this.nsgInput10.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput10.TabIndex = 27;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel11
            // 
            this.nsgLabel11.AutoSize = true;
            this.nsgLabel11.ConfigurationName = "";
            this.nsgLabel11.FullName = "";
            this.nsgLabel11.IsInitialized = false;
            this.nsgLabel11.Location = new System.Drawing.Point(328, 105);
            this.nsgLabel11.MetaDataName = "";
            this.nsgLabel11.Name = "nsgLabel1";
            this.nsgLabel11.Requsite = "";
            this.nsgLabel11.Size = new System.Drawing.Size(47, 13);
            this.nsgLabel11.TabIndex = 30;
            this.nsgLabel11.Text = "Фирма:";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "TechControl";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "Мониторинг.Объекты.Фирма";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(455, 105);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "Метаданные";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "Фирма";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(182, 20);
            this.nsgInput11.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput11.TabIndex = 29;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput12
            // 
            this.nsgInput12.BackColor = System.Drawing.SystemColors.Control;
            this.nsgInput12.ConfigurationName = "TechControl";
            this.nsgInput12.DisableLeaveControlEvent = false;
            this.nsgInput12.FullName = "Мониторинг.Объекты.Включен";
            this.nsgInput12.FullTextSearch = false;
            this.nsgInput12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput12.IsButton = false;
            this.nsgInput12.IsInitialized = true;
            this.nsgInput12.IsPassword = false;
            this.nsgInput12.Location = new System.Drawing.Point(654, 66);
            this.nsgInput12.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput12.Mask = "";
            this.nsgInput12.MetaDataName = "Метаданные";
            this.nsgInput12.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput12.Name = "NsgInput";
            this.nsgInput12.ObjectImages = null;
            this.nsgInput12.ObjectIndex = null;
            this.nsgInput12.ObjectStrings = null;
            this.nsgInput12.Requsite = "Включен";
            this.nsgInput12.SearchFieldName = "";
            this.nsgInput12.ShowMultipleObjectInComboBox = false;
            this.nsgInput12.ShowRowCount = 10;
            this.nsgInput12.Size = new System.Drawing.Size(180, 20);
            this.nsgInput12.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput12.TabIndex = 33;
            this.nsgInput12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput13
            // 
            this.nsgInput13.BackColor = System.Drawing.SystemColors.Control;
            this.nsgInput13.ConfigurationName = "TechControl";
            this.nsgInput13.DisableLeaveControlEvent = false;
            this.nsgInput13.FullName = "Мониторинг.Объекты.СменаОткрыта";
            this.nsgInput13.FullTextSearch = false;
            this.nsgInput13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput13.IsButton = false;
            this.nsgInput13.IsInitialized = true;
            this.nsgInput13.IsPassword = false;
            this.nsgInput13.Location = new System.Drawing.Point(654, 86);
            this.nsgInput13.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput13.Mask = "";
            this.nsgInput13.MetaDataName = "Метаданные";
            this.nsgInput13.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput13.Name = "NsgInput";
            this.nsgInput13.ObjectImages = null;
            this.nsgInput13.ObjectIndex = null;
            this.nsgInput13.ObjectStrings = null;
            this.nsgInput13.Requsite = "СменаОткрыта";
            this.nsgInput13.SearchFieldName = "";
            this.nsgInput13.ShowMultipleObjectInComboBox = false;
            this.nsgInput13.ShowRowCount = 10;
            this.nsgInput13.Size = new System.Drawing.Size(180, 20);
            this.nsgInput13.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput13.TabIndex = 35;
            this.nsgInput13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel12
            // 
            this.nsgLabel12.AutoSize = true;
            this.nsgLabel12.ConfigurationName = "";
            this.nsgLabel12.FullName = "";
            this.nsgLabel12.IsInitialized = false;
            this.nsgLabel12.Location = new System.Drawing.Point(641, 138);
            this.nsgLabel12.MetaDataName = "";
            this.nsgLabel12.Name = "nsgLabel1";
            this.nsgLabel12.Requsite = "";
            this.nsgLabel12.Size = new System.Drawing.Size(81, 13);
            this.nsgLabel12.TabIndex = 37;
            this.nsgLabel12.Text = "Руководитель:";
            // 
            // nsgInput14
            // 
            this.nsgInput14.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput14.ConfigurationName = "TechControl";
            this.nsgInput14.DisableLeaveControlEvent = false;
            this.nsgInput14.FullName = "Мониторинг.Объекты.Руководитель";
            this.nsgInput14.FullTextSearch = false;
            this.nsgInput14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput14.IsButton = false;
            this.nsgInput14.IsInitialized = true;
            this.nsgInput14.IsPassword = false;
            this.nsgInput14.Location = new System.Drawing.Point(764, 135);
            this.nsgInput14.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput14.Mask = "";
            this.nsgInput14.MetaDataName = "Метаданные";
            this.nsgInput14.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput14.Name = "NsgInput";
            this.nsgInput14.ObjectImages = null;
            this.nsgInput14.ObjectIndex = null;
            this.nsgInput14.ObjectStrings = null;
            this.nsgInput14.Requsite = "Руководитель";
            this.nsgInput14.SearchFieldName = "";
            this.nsgInput14.ShowMultipleObjectInComboBox = false;
            this.nsgInput14.ShowRowCount = 10;
            this.nsgInput14.Size = new System.Drawing.Size(182, 20);
            this.nsgInput14.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput14.TabIndex = 36;
            this.nsgInput14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel13
            // 
            this.nsgLabel13.AutoSize = true;
            this.nsgLabel13.ConfigurationName = "";
            this.nsgLabel13.FullName = "";
            this.nsgLabel13.IsInitialized = false;
            this.nsgLabel13.Location = new System.Drawing.Point(641, 105);
            this.nsgLabel13.MetaDataName = "";
            this.nsgLabel13.Name = "nsgLabel1";
            this.nsgLabel13.Requsite = "";
            this.nsgLabel13.Size = new System.Drawing.Size(112, 13);
            this.nsgLabel13.TabIndex = 39;
            this.nsgLabel13.Text = "Поставщик топлива:";
            // 
            // nsgInput15
            // 
            this.nsgInput15.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput15.ConfigurationName = "TechControl";
            this.nsgInput15.DisableLeaveControlEvent = false;
            this.nsgInput15.FullName = "Мониторинг.Объекты.ПоставщикТоплива";
            this.nsgInput15.FullTextSearch = false;
            this.nsgInput15.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput15.IsButton = false;
            this.nsgInput15.IsInitialized = true;
            this.nsgInput15.IsPassword = false;
            this.nsgInput15.Location = new System.Drawing.Point(764, 102);
            this.nsgInput15.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput15.Mask = "";
            this.nsgInput15.MetaDataName = "Метаданные";
            this.nsgInput15.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput15.Name = "NsgInput";
            this.nsgInput15.ObjectImages = null;
            this.nsgInput15.ObjectIndex = null;
            this.nsgInput15.ObjectStrings = null;
            this.nsgInput15.Requsite = "ПоставщикТоплива";
            this.nsgInput15.SearchFieldName = "";
            this.nsgInput15.ShowMultipleObjectInComboBox = false;
            this.nsgInput15.ShowRowCount = 10;
            this.nsgInput15.Size = new System.Drawing.Size(182, 20);
            this.nsgInput15.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput15.TabIndex = 38;
            this.nsgInput15.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ПоставщикТоплива
            // 
            this.ПоставщикТоплива.Caption = "";
            this.ПоставщикТоплива.Creator = null;
            this.ПоставщикТоплива.Name = "";
            this.ПоставщикТоплива.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.ПоставщикТоплива.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.ПоставщикТоплива.SearchCondition.OwnerComponent = this.ПоставщикТоплива;
            this.ПоставщикТоплива.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tabControlТарифы
            // 
            this.tabControlТарифы.AllowDrop = true;
            this.tabControlТарифы.Controls.Add(this.tabPage1);
            this.tabControlТарифы.Controls.Add(this.tabPage2);
            this.tabControlТарифы.Controls.Add(this.tabPage3);
            this.tabControlТарифы.Location = new System.Drawing.Point(643, 187);
            this.tabControlТарифы.Name = "tabControlТарифы";
            this.tabControlТарифы.SelectedIndex = 2;
            this.tabControlТарифы.Size = new System.Drawing.Size(359, 198);
            this.tabControlТарифы.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.nsgIGrid3);
            this.tabPage1.Enabled = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Техника";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.nsgIGrid4);
            this.tabPage2.Enabled = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Персонал";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.nsgIGrid5);
            this.tabPage3.Enabled = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(351, 172);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Система слежения";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Геозона:";
            // 
            // nsgInput16
            // 
            this.nsgInput16.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput16.ConfigurationName = "TechControl";
            this.nsgInput16.DisableLeaveControlEvent = false;
            this.nsgInput16.FullName = "Мониторинг.Объекты.Геозона";
            this.nsgInput16.FullTextSearch = false;
            this.nsgInput16.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput16.IsButton = false;
            this.nsgInput16.IsInitialized = true;
            this.nsgInput16.IsPassword = false;
            this.nsgInput16.Location = new System.Drawing.Point(909, 9);
            this.nsgInput16.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput16.Mask = "";
            this.nsgInput16.MetaDataName = "Метаданные";
            this.nsgInput16.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput16.Name = "NsgInput";
            this.nsgInput16.ObjectImages = null;
            this.nsgInput16.ObjectIndex = null;
            this.nsgInput16.ObjectStrings = null;
            this.nsgInput16.Requsite = "Геозона";
            this.nsgInput16.SearchFieldName = "";
            this.nsgInput16.ShowMultipleObjectInComboBox = false;
            this.nsgInput16.ShowRowCount = 10;
            this.nsgInput16.Size = new System.Drawing.Size(130, 20);
            this.nsgInput16.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput16.TabIndex = 42;
            this.nsgInput16.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel14
            // 
            this.nsgLabel14.AutoSize = true;
            this.nsgLabel14.ConfigurationName = "";
            this.nsgLabel14.FullName = "";
            this.nsgLabel14.IsInitialized = false;
            this.nsgLabel14.Location = new System.Drawing.Point(641, 164);
            this.nsgLabel14.MetaDataName = "";
            this.nsgLabel14.Name = "nsgLabel1";
            this.nsgLabel14.Requsite = "";
            this.nsgLabel14.Size = new System.Drawing.Size(120, 13);
            this.nsgLabel14.TabIndex = 44;
            this.nsgLabel14.Text = "ЗаправочнаяЕмкость:";
            // 
            // nsgInput17
            // 
            this.nsgInput17.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput17.ConfigurationName = "";
            this.nsgInput17.DisableLeaveControlEvent = false;
            this.nsgInput17.FullName = "ЗаправочнаяЕмкость";
            this.nsgInput17.FullTextSearch = false;
            this.nsgInput17.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput17.IsButton = false;
            this.nsgInput17.IsInitialized = true;
            this.nsgInput17.IsPassword = false;
            this.nsgInput17.Location = new System.Drawing.Point(764, 161);
            this.nsgInput17.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput17.Mask = "";
            this.nsgInput17.MetaDataName = "";
            this.nsgInput17.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput17.Name = "NsgInput";
            this.nsgInput17.ObjectImages = null;
            this.nsgInput17.ObjectIndex = null;
            this.nsgInput17.ObjectStrings = null;
            this.nsgInput17.Requsite = "ЗаправочнаяЕмкость";
            this.nsgInput17.SearchFieldName = "";
            this.nsgInput17.ShowMultipleObjectInComboBox = false;
            this.nsgInput17.ShowRowCount = 10;
            this.nsgInput17.Size = new System.Drawing.Size(182, 20);
            this.nsgInput17.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput17.TabIndex = 43;
            this.nsgInput17.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            // Адрес
            // 
            this.Адрес.AutoGenerated = true;
            this.Адрес.Caption = "Адрес";
            this.Адрес.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Адрес.Name = "Адрес";
            this.Адрес.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Адрес.PropertyType = typeof(string);
            this.Адрес.SearchCondition.OwnerComponent = this.Адрес;
            this.Адрес.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Заказчик
            // 
            this.Заказчик.AutoGenerated = true;
            this.Заказчик.Caption = "Заказчик";
            this.Заказчик.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Заказчик.Name = "Заказчик";
            this.Заказчик.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Заказчик.SearchCondition.OwnerComponent = this.Заказчик;
            this.Заказчик.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СобственностьТехники
            // 
            this.СобственностьТехники.AutoGenerated = true;
            this.СобственностьТехники.Caption = "СобственностьТехники";
            this.СобственностьТехники.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СобственностьТехники.Name = "СобственностьТехники";
            this.СобственностьТехники.NSGType = typeof(TechControl.Метаданные.Мониторинг.ТипСобственности);
            this.СобственностьТехники.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ТипСобственности);
            this.СобственностьТехники.SearchCondition.OwnerComponent = this.СобственностьТехники;
            this.СобственностьТехники.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГраницаОбъектаМониторинга
            // 
            this.ГраницаОбъектаМониторинга.AutoGenerated = true;
            this.ГраницаОбъектаМониторинга.Caption = "ГраницаОбъектаМониторинга";
            this.ГраницаОбъектаМониторинга.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГраницаОбъектаМониторинга.Name = "ГраницаОбъектаМониторинга";
            this.ГраницаОбъектаМониторинга.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ГраницаОбъектаМониторинга.PropertyType = typeof(string);
            this.ГраницаОбъектаМониторинга.SearchCondition.OwnerComponent = this.ГраницаОбъектаМониторинга;
            this.ГраницаОбъектаМониторинга.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НачалоРабочейСмены
            // 
            this.НачалоРабочейСмены.AutoGenerated = true;
            this.НачалоРабочейСмены.Caption = "НачалоРабочейСмены";
            this.НачалоРабочейСмены.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НачалоРабочейСмены.Name = "НачалоРабочейСмены";
            this.НачалоРабочейСмены.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.НачалоРабочейСмены.PropertyType = typeof(System.DateTime);
            this.НачалоРабочейСмены.SearchCondition.OwnerComponent = this.НачалоРабочейСмены;
            this.НачалоРабочейСмены.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // КонецРабочейСмены
            // 
            this.КонецРабочейСмены.AutoGenerated = true;
            this.КонецРабочейСмены.Caption = "КонецРабочейСмены";
            this.КонецРабочейСмены.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КонецРабочейСмены.Name = "КонецРабочейСмены";
            this.КонецРабочейСмены.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.КонецРабочейСмены.PropertyType = typeof(System.DateTime);
            this.КонецРабочейСмены.SearchCondition.OwnerComponent = this.КонецРабочейСмены;
            this.КонецРабочейСмены.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Фирма
            // 
            this.Фирма.AutoGenerated = true;
            this.Фирма.Caption = "Фирма";
            this.Фирма.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Фирма.Name = "Фирма";
            this.Фирма.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма.SearchCondition.OwnerComponent = this.Фирма;
            this.Фирма.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Договор
            // 
            this.Договор.AutoGenerated = true;
            this.Договор.Caption = "Договор";
            this.Договор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Договор.Name = "Договор";
            this.Договор.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Договор.PropertyType = typeof(string);
            this.Договор.SearchCondition.OwnerComponent = this.Договор;
            this.Договор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Включен
            // 
            this.Включен.AutoGenerated = true;
            this.Включен.Caption = "Включен";
            this.Включен.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Включен.Name = "Включен";
            this.Включен.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.Включен.PropertyType = typeof(bool);
            this.Включен.SearchCondition.OwnerComponent = this.Включен;
            this.Включен.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаПерсонал
            // 
            this.ТаблицаПерсонал.AutoGenerated = true;
            this.ТаблицаПерсонал.Caption = "ТаблицаПерсонал";
            this.ТаблицаПерсонал.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаПерсонал.Name = "ТаблицаПерсонал";
            this.ТаблицаПерсонал.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаПерсонал);
            this.ТаблицаПерсонал.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаПерсонал);
            this.ТаблицаПерсонал.SearchCondition.OwnerComponent = this.ТаблицаПерсонал;
            this.ТаблицаПерсонал.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаПерсонал.Visible = false;
            // 
            // ТаблицаТехника
            // 
            this.ТаблицаТехника.AutoGenerated = true;
            this.ТаблицаТехника.Caption = "ТаблицаТехника";
            this.ТаблицаТехника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаТехника.Name = "ТаблицаТехника";
            this.ТаблицаТехника.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТехника);
            this.ТаблицаТехника.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТехника);
            this.ТаблицаТехника.SearchCondition.OwnerComponent = this.ТаблицаТехника;
            this.ТаблицаТехника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаТехника.Visible = false;
            // 
            // Руководитель
            // 
            this.Руководитель.AutoGenerated = true;
            this.Руководитель.Caption = "Руководитель";
            this.Руководитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Руководитель.Name = "Руководитель";
            this.Руководитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Руководитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Руководитель.SearchCondition.OwnerComponent = this.Руководитель;
            this.Руководитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СменаОткрыта
            // 
            this.СменаОткрыта.AutoGenerated = true;
            this.СменаОткрыта.Caption = "СменаОткрыта";
            this.СменаОткрыта.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СменаОткрыта.Name = "СменаОткрыта";
            this.СменаОткрыта.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.СменаОткрыта.PropertyType = typeof(bool);
            this.СменаОткрыта.SearchCondition.OwnerComponent = this.СменаОткрыта;
            this.СменаОткрыта.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаТарифы
            // 
            this.ТаблицаТарифы.AutoGenerated = true;
            this.ТаблицаТарифы.Caption = "ТаблицаТарифы";
            this.ТаблицаТарифы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаТарифы.Name = "ТаблицаТарифы";
            this.ТаблицаТарифы.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифы);
            this.ТаблицаТарифы.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифы);
            this.ТаблицаТарифы.SearchCondition.OwnerComponent = this.ТаблицаТарифы;
            this.ТаблицаТарифы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаТарифы.Visible = false;
            // 
            // ПоставщикТоплива_nsgVisualMultipleObject
            // 
            this.ПоставщикТоплива_nsgVisualMultipleObject.AutoGenerated = true;
            this.ПоставщикТоплива_nsgVisualMultipleObject.Caption = "ПоставщикТоплива";
            this.ПоставщикТоплива_nsgVisualMultipleObject.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПоставщикТоплива_nsgVisualMultipleObject.Name = "ПоставщикТоплива";
            this.ПоставщикТоплива_nsgVisualMultipleObject.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.ПоставщикТоплива_nsgVisualMultipleObject.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.ПоставщикТоплива_nsgVisualMultipleObject.SearchCondition.OwnerComponent = this.ПоставщикТоплива_nsgVisualMultipleObject;
            this.ПоставщикТоплива_nsgVisualMultipleObject.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаТарифыСотрудников
            // 
            this.ТаблицаТарифыСотрудников.AutoGenerated = true;
            this.ТаблицаТарифыСотрудников.Caption = "ТаблицаТарифыСотрудников";
            this.ТаблицаТарифыСотрудников.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаТарифыСотрудников.Name = "ТаблицаТарифыСотрудников";
            this.ТаблицаТарифыСотрудников.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифыСотрудников);
            this.ТаблицаТарифыСотрудников.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТарифыСотрудников);
            this.ТаблицаТарифыСотрудников.SearchCondition.OwnerComponent = this.ТаблицаТарифыСотрудников;
            this.ТаблицаТарифыСотрудников.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаТарифыСотрудников.Visible = false;
            // 
            // МашинВРаботе
            // 
            this.МашинВРаботе.AutoGenerated = true;
            this.МашинВРаботе.CalcTotal = false;
            this.МашинВРаботе.Caption = "МашинВРаботе";
            this.МашинВРаботе.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.МашинВРаботе.Name = "МашинВРаботе";
            this.МашинВРаботе.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.МашинВРаботе.PropertyType = typeof(long);
            this.МашинВРаботе.SearchCondition.OwnerComponent = this.МашинВРаботе;
            this.МашинВРаботе.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // МашинНеВРаботе
            // 
            this.МашинНеВРаботе.AutoGenerated = true;
            this.МашинНеВРаботе.CalcTotal = false;
            this.МашинНеВРаботе.Caption = "МашинНеВРаботе";
            this.МашинНеВРаботе.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.МашинНеВРаботе.Name = "МашинНеВРаботе";
            this.МашинНеВРаботе.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.МашинНеВРаботе.PropertyType = typeof(long);
            this.МашинНеВРаботе.SearchCondition.OwnerComponent = this.МашинНеВРаботе;
            this.МашинНеВРаботе.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // МашинСломано
            // 
            this.МашинСломано.AutoGenerated = true;
            this.МашинСломано.CalcTotal = false;
            this.МашинСломано.Caption = "МашинСломано";
            this.МашинСломано.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.МашинСломано.Name = "МашинСломано";
            this.МашинСломано.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.МашинСломано.PropertyType = typeof(long);
            this.МашинСломано.SearchCondition.OwnerComponent = this.МашинСломано;
            this.МашинСломано.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаСистемыСлежения
            // 
            this.ТаблицаСистемыСлежения.AutoGenerated = true;
            this.ТаблицаСистемыСлежения.Caption = "ТаблицаСистемыСлежения";
            this.ТаблицаСистемыСлежения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТаблицаСистемыСлежения.Name = "ТаблицаСистемыСлежения";
            this.ТаблицаСистемыСлежения.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаСистемыСлежения);
            this.ТаблицаСистемыСлежения.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаСистемыСлежения);
            this.ТаблицаСистемыСлежения.SearchCondition.OwnerComponent = this.ТаблицаСистемыСлежения;
            this.ТаблицаСистемыСлежения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаСистемыСлежения.Visible = false;
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
            // Геозона
            // 
            this.Геозона.AutoGenerated = true;
            this.Геозона.Caption = "Геозона";
            this.Геозона.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Геозона.Name = "Геозона";
            this.Геозона.NSGType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Геозоны);
            this.Геозона.SearchCondition.OwnerComponent = this.Геозона;
            this.Геозона.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЗаправочнаяЕмкость
            // 
            this.ЗаправочнаяЕмкость.AutoGenerated = true;
            this.ЗаправочнаяЕмкость.Caption = "ЗаправочнаяЕмкость";
            this.ЗаправочнаяЕмкость.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЗаправочнаяЕмкость.Name = "ЗаправочнаяЕмкость";
            this.ЗаправочнаяЕмкость.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ЗаправочнаяЕмкость.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.ЗаправочнаяЕмкость.SearchCondition.OwnerComponent = this.ЗаправочнаяЕмкость;
            this.ЗаправочнаяЕмкость.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбъектыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1322, 491);
            this.Controls.Add(this.nsgLabel14);
            this.Controls.Add(this.nsgInput17);
            this.Controls.Add(this.nsgInput16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlТарифы);
            this.Controls.Add(this.nsgLabel13);
            this.Controls.Add(this.nsgInput15);
            this.Controls.Add(this.nsgLabel12);
            this.Controls.Add(this.nsgInput14);
            this.Controls.Add(this.nsgInput13);
            this.Controls.Add(this.nsgInput12);
            this.Controls.Add(this.nsgIGrid2);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgLabel11);
            this.Controls.Add(this.nsgInput11);
            this.Controls.Add(this.nsgLabel10);
            this.Controls.Add(this.nsgInput10);
            this.Controls.Add(this.nsgLabel9);
            this.Controls.Add(this.nsgInput9);
            this.Controls.Add(this.nsgLabel8);
            this.Controls.Add(this.nsgInput8);
            this.Controls.Add(this.nsgLabel7);
            this.Controls.Add(this.nsgInput7);
            this.Controls.Add(this.nsgLabel6);
            this.Controls.Add(this.nsgInput6);
            this.Controls.Add(this.nsgLabel5);
            this.Controls.Add(this.nsgInput5);
            this.Controls.Add(this.nsgLabel4);
            this.Controls.Add(this.nsgInput4);
            this.Controls.Add(this.nsgLabel3);
            this.Controls.Add(this.nsgInput3);
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
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgLabel3, 0);
            this.Controls.SetChildIndex(this.nsgInput4, 0);
            this.Controls.SetChildIndex(this.nsgLabel4, 0);
            this.Controls.SetChildIndex(this.nsgInput5, 0);
            this.Controls.SetChildIndex(this.nsgLabel5, 0);
            this.Controls.SetChildIndex(this.nsgInput6, 0);
            this.Controls.SetChildIndex(this.nsgLabel6, 0);
            this.Controls.SetChildIndex(this.nsgInput7, 0);
            this.Controls.SetChildIndex(this.nsgLabel7, 0);
            this.Controls.SetChildIndex(this.nsgInput8, 0);
            this.Controls.SetChildIndex(this.nsgLabel8, 0);
            this.Controls.SetChildIndex(this.nsgInput9, 0);
            this.Controls.SetChildIndex(this.nsgLabel9, 0);
            this.Controls.SetChildIndex(this.nsgInput10, 0);
            this.Controls.SetChildIndex(this.nsgLabel10, 0);
            this.Controls.SetChildIndex(this.nsgInput11, 0);
            this.Controls.SetChildIndex(this.nsgLabel11, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.nsgIGrid2, 0);
            this.Controls.SetChildIndex(this.nsgInput12, 0);
            this.Controls.SetChildIndex(this.nsgInput13, 0);
            this.Controls.SetChildIndex(this.nsgInput14, 0);
            this.Controls.SetChildIndex(this.nsgLabel12, 0);
            this.Controls.SetChildIndex(this.nsgInput15, 0);
            this.Controls.SetChildIndex(this.nsgLabel13, 0);
            this.Controls.SetChildIndex(this.tabControlТарифы, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nsgInput16, 0);
            this.Controls.SetChildIndex(this.nsgInput17, 0);
            this.Controls.SetChildIndex(this.nsgLabel14, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoПерсонал)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТехника)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТарифыПерсонал)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoСистемыСлежения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).EndInit();
            this.tabControlТарифы.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NsgLabel nsgLabel1;
        private NsgVisualMultipleObject vmoПерсонал;
        private NsgVisualMultipleObject vmoТехника;
        private NsgIGrid nsgIGrid1;
        private NsgIGrid nsgIGrid2;
        private NsgIGrid nsgIGrid3;
        private NsgVisualMultipleObject vmoТарифы;
        private Контрагенты.ColumnDescriptor ПоставщикТоплива;
        private System.Windows.Forms.TabControl tabControlТарифы;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private NsgIGrid nsgIGrid4;
        private NsgVisualMultipleObject vmoТарифыПерсонал;
        private NsgInput nsgInput1;
        private NsgLabel nsgLabel2;
        private NsgInput nsgInput2;
        private NsgLabel nsgLabel3;
        private NsgInput nsgInput3;
        private NsgLabel nsgLabel4;
        private NsgInput nsgInput4;
        private NsgLabel nsgLabel5;
        private NsgInput nsgInput5;
        private NsgLabel nsgLabel6;
        private NsgInput nsgInput6;
        private NsgLabel nsgLabel7;
        private NsgInput nsgInput7;
        private NsgLabel nsgLabel8;
        private NsgInput nsgInput8;
        private NsgLabel nsgLabel9;
        private NsgInput nsgInput9;
        private NsgLabel nsgLabel10;
        private NsgInput nsgInput10;
        private NsgLabel nsgLabel11;
        private NsgInput nsgInput11;
        private NsgInput nsgInput12;
        private NsgInput nsgInput13;
        private NsgLabel nsgLabel12;
        private NsgInput nsgInput14;
        private NsgLabel nsgLabel13;
        private NsgInput nsgInput15;
        private Должности.ColumnDescriptor Должность;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТехника;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТехника;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТехника;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТехника;
        private Техника.ColumnDescriptor Техника;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТарифы;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТарифы;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТарифы;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТарифы;
        private Тарифы.ColumnDescriptor Тариф;
        private NsgColumnDescriptor.Decimal Стоимость;
        private NsgColumnDescriptor.Boolean ИспользоватьПоУмолчанию;
        private ГруппыСпецТехники.ColumnDescriptor ГруппаСпецТехники;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТарифыПерсонал;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТарифыПерсонал;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТарифыПерсонал;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТарифыПерсонал;
        private NsgColumnDescriptor.Boolean ИспользоватьПоУмолчанию_vmoТарифыПерсонал;
        private NsgColumnDescriptor.Decimal Стоимость_vmoТарифыПерсонал;
        private Тарифы.ColumnDescriptor Тариф_vmoТарифыПерсонал;
        private NsgColumnDescriptor.Guid Идентификатор_vmoПерсонал;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoПерсонал;
        private NsgColumnDescriptor.MultipleObject Владелец;
        private NsgColumnDescriptor.Int64 НомерСтроки;
        private Сотрудники.ColumnDescriptor Сотрудник;
        private Сервис.Приоритет.ColumnDescriptor Приоритет;
        private System.Windows.Forms.TabPage tabPage3;
        private NsgIGrid nsgIGrid5;
        private NsgVisualMultipleObject vmoСистемыСлежения;
        private Должности.ColumnDescriptor Должность_vmoПерсонал;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoСистемыСлежения;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoСистемыСлежения;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoСистемыСлежения;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoСистемыСлежения;
        private ТипСистемыСлежения.ColumnDescriptor ТипСистемыСлежения;
        protected NsgColumnDescriptor.String ИдентификаторСистемыСлежения;
        private System.Windows.Forms.Label label1;
        protected NsgInput nsgInput16;
        private NsgColumnDescriptor.Guid Идентификатор;
        private NsgColumnDescriptor.Int64 Автоинкремент;
        private NsgColumnDescriptor.Boolean ЭтоГруппа;
        private NsgColumnDescriptor.Guid ИдентификаторРодителя;
        private NsgColumnDescriptor.Byte Уровень;
        private NsgColumnDescriptor.String ПрефиксКода;
        private NsgColumnDescriptor.Int64 НомерКода;
        private NsgColumnDescriptor.String Код;
        private NsgColumnDescriptor.String Наименование;
        private Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        private NsgColumnDescriptor.String Адрес;
        private Контрагенты.ColumnDescriptor Заказчик;
        private ТипСобственности.ColumnDescriptor СобственностьТехники;
        private NsgColumnDescriptor.String ГраницаОбъектаМониторинга;
        private NsgColumnDescriptor.DateTime НачалоРабочейСмены;
        private Сотрудники.ColumnDescriptor Ответственный;
        private NsgColumnDescriptor.DateTime КонецРабочейСмены;
        private Контрагенты.ColumnDescriptor Фирма;
        private РежимыРаботы.ColumnDescriptor РежимРаботы;
        private NsgColumnDescriptor.String Договор;
        private NsgColumnDescriptor.Boolean Включен;
        private _SystemTables.МониторингОбъектыТаблицаПерсонал.ColumnDescriptor ТаблицаПерсонал;
        private _SystemTables.МониторингОбъектыТаблицаТехника.ColumnDescriptor ТаблицаТехника;
        private Сотрудники.ColumnDescriptor Руководитель;
        private NsgColumnDescriptor.Boolean СменаОткрыта;
        private _SystemTables.МониторингОбъектыТаблицаТарифы.ColumnDescriptor ТаблицаТарифы;
        private Контрагенты.ColumnDescriptor ПоставщикТоплива_nsgVisualMultipleObject;
        private _SystemTables.МониторингОбъектыТаблицаТарифыСотрудников.ColumnDescriptor ТаблицаТарифыСотрудников;
        private NsgColumnDescriptor.Int64 МашинВРаботе;
        private NsgColumnDescriptor.Int64 МашинНеВРаботе;
        private NsgColumnDescriptor.Int64 МашинСломано;
        private _SystemTables.МониторингОбъектыТаблицаСистемыСлежения.ColumnDescriptor ТаблицаСистемыСлежения;
        private СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        private Геозоны.ColumnDescriptor Геозона;
        private Техника.ColumnDescriptor ЗаправочнаяЕмкость;
        protected Объекты.ColumnDescriptor Родитель;
        protected NsgLabel nsgLabel14;
        protected NsgInput nsgInput17;
    }
}