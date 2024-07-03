using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Документы

{
    
    public partial class ОтработанныеМесяцыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтработанныеМесяцыФормаЭлемента));
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
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn14 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn15 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn16 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn17 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn18 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn19 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn20 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn21 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn22 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn23 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn24 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn25 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn26 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn27 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn28 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn29 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn30 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn31 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn32 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn33 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn34 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn35 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn36 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn37 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Техника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Д2 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Тариф = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Д3 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д14 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д25 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д27 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д28 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д29 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д30 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д31 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д4 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д5 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д6 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д7 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д8 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д9 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д10 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д11 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д12 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д13 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д15 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д16 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д17 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д18 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д19 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д20 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д21 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д22 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д23 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д24 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д26 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Д1 = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.ГруппаСпецТехники = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.label1 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.label2 = new System.Windows.Forms.Label();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Таблица = new TechControl.Метаданные._SystemTables.ДокументыОтработанныеМесяцыТаблица.ColumnDescriptor();
            this.Контрагент = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.МесяцИтогов = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.bgwЗаполнениеДанныхПоГрафику = new NsgSoft.Forms.NsgBackgroundWorker(this.components);
            this.nbАнализ = new NsgSoft.Design.NsgButton();
            this.vmoДанныеГрафика = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Должность_vmoДанныеГрафика = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.ГруппаСпТехн_vmoДанныеГрафика = new TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.ColumnDescriptor();
            this.КоличДляСравнения_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.КодГруппы_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДГ1_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ2_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ3_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ4_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ5_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ6_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ7_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ8_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ9_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ10_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ11_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ12_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ13_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ14_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ15_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ16_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ17_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ18_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ19_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ20_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ21_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ22_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ23_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ24_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ25_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ26_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ27_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Дг28_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ29_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ30_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДГ31_vmoДанныеГрафика = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbАнализ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанныеГрафика)).BeginInit();
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
            this.panelButtons.Location = new System.Drawing.Point(0, 430);
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
            this.Comment.FullName = "Документы.ОтработанныеМесяцы.Идентификатор";
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Индекс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДокументОснование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Комментарий);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Таблица);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Контрагент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.МесяцИтогов);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Документы.ОтработанныеМесяцы";
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
        "Visible",
        "Index"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.ImportedFromVMO = false;
            nsgIGridColumn2.InitiateRowEdit = true;
            nsgIGridColumn2.Name = "Должность";
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
            nsgIGridColumn3.Name = "Сотрудник";
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
            nsgIGridColumn4.Name = "ГруппаСпецТехники";
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
            nsgIGridColumn5.Name = "Техника";
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
            nsgIGridColumn6.ImportedFromVMO = false;
            nsgIGridColumn6.InitiateRowEdit = true;
            nsgIGridColumn6.Name = "Тариф";
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
            nsgIGridColumn7.ImportedFromVMO = false;
            nsgIGridColumn7.InitiateRowEdit = true;
            nsgIGridColumn7.Name = "Д1";
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
            nsgIGridColumn8.ImportedFromVMO = false;
            nsgIGridColumn8.InitiateRowEdit = true;
            nsgIGridColumn8.Name = "Д2";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn9.Name = "Д3";
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
        "Visible",
        "Index"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.InitiateRowEdit = true;
            nsgIGridColumn10.Name = "Д4";
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
        "Visible",
        "Index"};
            nsgIGridColumn11.DateFormat = null;
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.InitiateRowEdit = true;
            nsgIGridColumn11.Name = "Д5";
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
            nsgIGridColumn12.ImportedFromVMO = false;
            nsgIGridColumn12.InitiateRowEdit = true;
            nsgIGridColumn12.Name = "Д6";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn13.ImportedFromVMO = false;
            nsgIGridColumn13.InitiateRowEdit = true;
            nsgIGridColumn13.Name = "Д7";
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
            nsgIGridColumn14.ImportedFromVMO = false;
            nsgIGridColumn14.InitiateRowEdit = true;
            nsgIGridColumn14.Name = "Д8";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn15.Name = "Д9";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn16.Name = "Д10";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn16.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn16.UseAsHeaderImage = false;
            nsgIGridColumn16.Width = 100;
            nsgIGridColumn17.AllowFilter = true;
            nsgIGridColumn17.AllowGroupSelect = false;
            nsgIGridColumn17.AllowResize = true;
            nsgIGridColumn17.AutoResize = true;
            nsgIGridColumn17.Caption = "";
            nsgIGridColumn17.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn17.DateFormat = null;
            nsgIGridColumn17.ImportedFromVMO = false;
            nsgIGridColumn17.InitiateRowEdit = true;
            nsgIGridColumn17.Name = "Д11";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn17.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn17.UseAsHeaderImage = false;
            nsgIGridColumn17.Width = 100;
            nsgIGridColumn18.AllowFilter = true;
            nsgIGridColumn18.AllowGroupSelect = false;
            nsgIGridColumn18.AllowResize = true;
            nsgIGridColumn18.AutoResize = true;
            nsgIGridColumn18.Caption = "";
            nsgIGridColumn18.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn18.DateFormat = null;
            nsgIGridColumn18.ImportedFromVMO = false;
            nsgIGridColumn18.InitiateRowEdit = true;
            nsgIGridColumn18.Name = "Д12";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn18.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn18.UseAsHeaderImage = false;
            nsgIGridColumn18.Width = 100;
            nsgIGridColumn19.AllowFilter = true;
            nsgIGridColumn19.AllowGroupSelect = false;
            nsgIGridColumn19.AllowResize = true;
            nsgIGridColumn19.AutoResize = true;
            nsgIGridColumn19.Caption = "";
            nsgIGridColumn19.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn19.DateFormat = null;
            nsgIGridColumn19.ImportedFromVMO = false;
            nsgIGridColumn19.InitiateRowEdit = true;
            nsgIGridColumn19.Name = "Д13";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn19.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn19.UseAsHeaderImage = false;
            nsgIGridColumn19.Width = 100;
            nsgIGridColumn20.AllowFilter = true;
            nsgIGridColumn20.AllowGroupSelect = false;
            nsgIGridColumn20.AllowResize = true;
            nsgIGridColumn20.AutoResize = true;
            nsgIGridColumn20.Caption = "";
            nsgIGridColumn20.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn20.DateFormat = null;
            nsgIGridColumn20.ImportedFromVMO = false;
            nsgIGridColumn20.InitiateRowEdit = true;
            nsgIGridColumn20.Name = "Д14";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn20.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn20.UseAsHeaderImage = false;
            nsgIGridColumn20.Width = 100;
            nsgIGridColumn21.AllowFilter = true;
            nsgIGridColumn21.AllowGroupSelect = false;
            nsgIGridColumn21.AllowResize = true;
            nsgIGridColumn21.AutoResize = true;
            nsgIGridColumn21.Caption = "";
            nsgIGridColumn21.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn21.DateFormat = null;
            nsgIGridColumn21.ImportedFromVMO = false;
            nsgIGridColumn21.InitiateRowEdit = true;
            nsgIGridColumn21.Name = "Д15";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Width = 100;
            nsgIGridColumn22.AllowFilter = true;
            nsgIGridColumn22.AllowGroupSelect = false;
            nsgIGridColumn22.AllowResize = true;
            nsgIGridColumn22.AutoResize = true;
            nsgIGridColumn22.Caption = "";
            nsgIGridColumn22.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn22.DateFormat = null;
            nsgIGridColumn22.ImportedFromVMO = false;
            nsgIGridColumn22.InitiateRowEdit = true;
            nsgIGridColumn22.Name = "Д16";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn22.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn22.UseAsHeaderImage = false;
            nsgIGridColumn22.Width = 100;
            nsgIGridColumn23.AllowFilter = true;
            nsgIGridColumn23.AllowGroupSelect = false;
            nsgIGridColumn23.AllowResize = true;
            nsgIGridColumn23.AutoResize = true;
            nsgIGridColumn23.Caption = "";
            nsgIGridColumn23.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn23.DateFormat = null;
            nsgIGridColumn23.ImportedFromVMO = false;
            nsgIGridColumn23.InitiateRowEdit = true;
            nsgIGridColumn23.Name = "Д17";
            nsgIGridColumn23.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn23.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn23.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn23.UseAsHeaderImage = false;
            nsgIGridColumn23.Width = 100;
            nsgIGridColumn24.AllowFilter = true;
            nsgIGridColumn24.AllowGroupSelect = false;
            nsgIGridColumn24.AllowResize = true;
            nsgIGridColumn24.AutoResize = true;
            nsgIGridColumn24.Caption = "";
            nsgIGridColumn24.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn24.DateFormat = null;
            nsgIGridColumn24.ImportedFromVMO = false;
            nsgIGridColumn24.InitiateRowEdit = true;
            nsgIGridColumn24.Name = "Д18";
            nsgIGridColumn24.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn24.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn24.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn24.UseAsHeaderImage = false;
            nsgIGridColumn24.Width = 100;
            nsgIGridColumn25.AllowFilter = true;
            nsgIGridColumn25.AllowGroupSelect = false;
            nsgIGridColumn25.AllowResize = true;
            nsgIGridColumn25.AutoResize = true;
            nsgIGridColumn25.Caption = "";
            nsgIGridColumn25.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn25.DateFormat = null;
            nsgIGridColumn25.ImportedFromVMO = false;
            nsgIGridColumn25.InitiateRowEdit = true;
            nsgIGridColumn25.Name = "Д19";
            nsgIGridColumn25.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn25.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn25.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn25.UseAsHeaderImage = false;
            nsgIGridColumn25.Width = 100;
            nsgIGridColumn26.AllowFilter = true;
            nsgIGridColumn26.AllowGroupSelect = false;
            nsgIGridColumn26.AllowResize = true;
            nsgIGridColumn26.AutoResize = true;
            nsgIGridColumn26.Caption = "";
            nsgIGridColumn26.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn26.DateFormat = null;
            nsgIGridColumn26.ImportedFromVMO = false;
            nsgIGridColumn26.InitiateRowEdit = true;
            nsgIGridColumn26.Name = "Д20";
            nsgIGridColumn26.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn26.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn26.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn26.UseAsHeaderImage = false;
            nsgIGridColumn26.Width = 100;
            nsgIGridColumn27.AllowFilter = true;
            nsgIGridColumn27.AllowGroupSelect = false;
            nsgIGridColumn27.AllowResize = true;
            nsgIGridColumn27.AutoResize = true;
            nsgIGridColumn27.Caption = "";
            nsgIGridColumn27.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn27.DateFormat = null;
            nsgIGridColumn27.ImportedFromVMO = false;
            nsgIGridColumn27.InitiateRowEdit = true;
            nsgIGridColumn27.Name = "Д21";
            nsgIGridColumn27.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn27.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn27.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn27.UseAsHeaderImage = false;
            nsgIGridColumn27.Width = 100;
            nsgIGridColumn28.AllowFilter = true;
            nsgIGridColumn28.AllowGroupSelect = false;
            nsgIGridColumn28.AllowResize = true;
            nsgIGridColumn28.AutoResize = true;
            nsgIGridColumn28.Caption = "";
            nsgIGridColumn28.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn28.DateFormat = null;
            nsgIGridColumn28.ImportedFromVMO = false;
            nsgIGridColumn28.InitiateRowEdit = true;
            nsgIGridColumn28.Name = "Д22";
            nsgIGridColumn28.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn28.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn28.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn28.UseAsHeaderImage = false;
            nsgIGridColumn28.Width = 100;
            nsgIGridColumn29.AllowFilter = true;
            nsgIGridColumn29.AllowGroupSelect = false;
            nsgIGridColumn29.AllowResize = true;
            nsgIGridColumn29.AutoResize = true;
            nsgIGridColumn29.Caption = "";
            nsgIGridColumn29.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn29.DateFormat = null;
            nsgIGridColumn29.ImportedFromVMO = false;
            nsgIGridColumn29.InitiateRowEdit = true;
            nsgIGridColumn29.Name = "Д23";
            nsgIGridColumn29.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn29.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn29.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn29.UseAsHeaderImage = false;
            nsgIGridColumn29.Width = 100;
            nsgIGridColumn30.AllowFilter = true;
            nsgIGridColumn30.AllowGroupSelect = false;
            nsgIGridColumn30.AllowResize = true;
            nsgIGridColumn30.AutoResize = true;
            nsgIGridColumn30.Caption = "";
            nsgIGridColumn30.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn30.DateFormat = null;
            nsgIGridColumn30.ImportedFromVMO = false;
            nsgIGridColumn30.InitiateRowEdit = true;
            nsgIGridColumn30.Name = "Д24";
            nsgIGridColumn30.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn30.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn30.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn30.UseAsHeaderImage = false;
            nsgIGridColumn30.Width = 100;
            nsgIGridColumn31.AllowFilter = true;
            nsgIGridColumn31.AllowGroupSelect = false;
            nsgIGridColumn31.AllowResize = true;
            nsgIGridColumn31.AutoResize = true;
            nsgIGridColumn31.Caption = "";
            nsgIGridColumn31.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn31.DateFormat = null;
            nsgIGridColumn31.ImportedFromVMO = false;
            nsgIGridColumn31.InitiateRowEdit = true;
            nsgIGridColumn31.Name = "Д25";
            nsgIGridColumn31.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn31.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn31.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn31.UseAsHeaderImage = false;
            nsgIGridColumn31.Width = 100;
            nsgIGridColumn32.AllowFilter = true;
            nsgIGridColumn32.AllowGroupSelect = false;
            nsgIGridColumn32.AllowResize = true;
            nsgIGridColumn32.AutoResize = true;
            nsgIGridColumn32.Caption = "";
            nsgIGridColumn32.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn32.DateFormat = null;
            nsgIGridColumn32.ImportedFromVMO = false;
            nsgIGridColumn32.InitiateRowEdit = true;
            nsgIGridColumn32.Name = "Д26";
            nsgIGridColumn32.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn32.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn32.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn32.UseAsHeaderImage = false;
            nsgIGridColumn32.Width = 100;
            nsgIGridColumn33.AllowFilter = true;
            nsgIGridColumn33.AllowGroupSelect = false;
            nsgIGridColumn33.AllowResize = true;
            nsgIGridColumn33.AutoResize = true;
            nsgIGridColumn33.Caption = "";
            nsgIGridColumn33.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn33.DateFormat = null;
            nsgIGridColumn33.ImportedFromVMO = false;
            nsgIGridColumn33.InitiateRowEdit = true;
            nsgIGridColumn33.Name = "Д27";
            nsgIGridColumn33.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn33.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn33.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn33.UseAsHeaderImage = false;
            nsgIGridColumn33.Width = 100;
            nsgIGridColumn34.AllowFilter = true;
            nsgIGridColumn34.AllowGroupSelect = false;
            nsgIGridColumn34.AllowResize = true;
            nsgIGridColumn34.AutoResize = true;
            nsgIGridColumn34.Caption = "";
            nsgIGridColumn34.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn34.DateFormat = null;
            nsgIGridColumn34.ImportedFromVMO = false;
            nsgIGridColumn34.InitiateRowEdit = true;
            nsgIGridColumn34.Name = "Д28";
            nsgIGridColumn34.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn34.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn34.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn34.UseAsHeaderImage = false;
            nsgIGridColumn34.Width = 100;
            nsgIGridColumn35.AllowFilter = true;
            nsgIGridColumn35.AllowGroupSelect = false;
            nsgIGridColumn35.AllowResize = true;
            nsgIGridColumn35.AutoResize = true;
            nsgIGridColumn35.Caption = "";
            nsgIGridColumn35.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn35.DateFormat = null;
            nsgIGridColumn35.ImportedFromVMO = false;
            nsgIGridColumn35.InitiateRowEdit = true;
            nsgIGridColumn35.Name = "Д29";
            nsgIGridColumn35.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn35.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn35.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn35.UseAsHeaderImage = false;
            nsgIGridColumn35.Width = 100;
            nsgIGridColumn36.AllowFilter = true;
            nsgIGridColumn36.AllowGroupSelect = false;
            nsgIGridColumn36.AllowResize = true;
            nsgIGridColumn36.AutoResize = true;
            nsgIGridColumn36.Caption = "";
            nsgIGridColumn36.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn36.DateFormat = null;
            nsgIGridColumn36.ImportedFromVMO = false;
            nsgIGridColumn36.InitiateRowEdit = true;
            nsgIGridColumn36.Name = "Д30";
            nsgIGridColumn36.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn36.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn36.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn36.UseAsHeaderImage = false;
            nsgIGridColumn36.Width = 100;
            nsgIGridColumn37.AllowFilter = true;
            nsgIGridColumn37.AllowGroupSelect = false;
            nsgIGridColumn37.AllowResize = true;
            nsgIGridColumn37.AutoResize = true;
            nsgIGridColumn37.Caption = "";
            nsgIGridColumn37.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn37.DateFormat = null;
            nsgIGridColumn37.ImportedFromVMO = false;
            nsgIGridColumn37.InitiateRowEdit = true;
            nsgIGridColumn37.Name = "Д31";
            nsgIGridColumn37.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn37.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn37.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn37.UseAsHeaderImage = false;
            nsgIGridColumn37.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn22);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn23);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn24);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn25);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn26);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn27);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn28);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn29);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn30);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn31);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn32);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn33);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn34);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn35);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn36);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn37);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 92);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(723, 334);
            this.nsgIGrid1.SourceObject = this.vmoТаблица;
            this.nsgIGrid1.TabIndex = 16;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellEndEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellEndEdit);
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТаблица.MetaDataName = "Метаданные";
            this.vmoТаблица.FullName = "_SystemTables.ДокументыОтработанныеМесяцыТаблица.Владелец";
            // 
            // vmoТаблица
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.ДокументыОтработанныеМесяцыТаблица.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Документы.ОтработанныеМесяцы.Таблица";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблица.Columns.Collection.Add(this.Идентификатор_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Автоинкремент_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Владелец);
            this.vmoТаблица.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблица.Columns.Collection.Add(this.Техника);
            this.vmoТаблица.Columns.Collection.Add(this.Сотрудник);
            this.vmoТаблица.Columns.Collection.Add(this.Д2);
            this.vmoТаблица.Columns.Collection.Add(this.Тариф);
            this.vmoТаблица.Columns.Collection.Add(this.Д3);
            this.vmoТаблица.Columns.Collection.Add(this.Д14);
            this.vmoТаблица.Columns.Collection.Add(this.Д25);
            this.vmoТаблица.Columns.Collection.Add(this.Д27);
            this.vmoТаблица.Columns.Collection.Add(this.Д28);
            this.vmoТаблица.Columns.Collection.Add(this.Д29);
            this.vmoТаблица.Columns.Collection.Add(this.Д30);
            this.vmoТаблица.Columns.Collection.Add(this.Д31);
            this.vmoТаблица.Columns.Collection.Add(this.Д4);
            this.vmoТаблица.Columns.Collection.Add(this.Д5);
            this.vmoТаблица.Columns.Collection.Add(this.Д6);
            this.vmoТаблица.Columns.Collection.Add(this.Д7);
            this.vmoТаблица.Columns.Collection.Add(this.Д8);
            this.vmoТаблица.Columns.Collection.Add(this.Д9);
            this.vmoТаблица.Columns.Collection.Add(this.Д10);
            this.vmoТаблица.Columns.Collection.Add(this.Д11);
            this.vmoТаблица.Columns.Collection.Add(this.Д12);
            this.vmoТаблица.Columns.Collection.Add(this.Д13);
            this.vmoТаблица.Columns.Collection.Add(this.Д15);
            this.vmoТаблица.Columns.Collection.Add(this.Д16);
            this.vmoТаблица.Columns.Collection.Add(this.Д17);
            this.vmoТаблица.Columns.Collection.Add(this.Д18);
            this.vmoТаблица.Columns.Collection.Add(this.Д19);
            this.vmoТаблица.Columns.Collection.Add(this.Д20);
            this.vmoТаблица.Columns.Collection.Add(this.Д21);
            this.vmoТаблица.Columns.Collection.Add(this.Д22);
            this.vmoТаблица.Columns.Collection.Add(this.Д23);
            this.vmoТаблица.Columns.Collection.Add(this.Д24);
            this.vmoТаблица.Columns.Collection.Add(this.Д26);
            this.vmoТаблица.Columns.Collection.Add(this.Д1);
            this.vmoТаблица.Columns.Collection.Add(this.Должность);
            this.vmoТаблица.Columns.Collection.Add(this.ГруппаСпецТехники);
            this.vmoТаблица.IsActive = true;
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
            this.Сотрудник.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Сотрудник.SearchCondition.OwnerComponent = this.Сотрудник;
            this.Сотрудник.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д2
            // 
            this.Д2.AutoGenerated = true;
            this.Д2.CalcTotal = false;
            this.Д2.Caption = "2";
            this.Д2.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д2.Name = "Д2";
            this.Д2.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д2.PropertyType = typeof(decimal);
            this.Д2.SearchCondition.OwnerComponent = this.Д2;
            this.Д2.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Д3
            // 
            this.Д3.AutoGenerated = true;
            this.Д3.CalcTotal = false;
            this.Д3.Caption = "3";
            this.Д3.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д3.Name = "Д3";
            this.Д3.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д3.PropertyType = typeof(decimal);
            this.Д3.SearchCondition.OwnerComponent = this.Д3;
            this.Д3.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д14
            // 
            this.Д14.AutoGenerated = true;
            this.Д14.CalcTotal = false;
            this.Д14.Caption = "14";
            this.Д14.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д14.Name = "Д14";
            this.Д14.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д14.PropertyType = typeof(decimal);
            this.Д14.SearchCondition.OwnerComponent = this.Д14;
            this.Д14.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д25
            // 
            this.Д25.AutoGenerated = true;
            this.Д25.CalcTotal = false;
            this.Д25.Caption = "25";
            this.Д25.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д25.Name = "Д25";
            this.Д25.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д25.PropertyType = typeof(decimal);
            this.Д25.SearchCondition.OwnerComponent = this.Д25;
            this.Д25.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д27
            // 
            this.Д27.AutoGenerated = true;
            this.Д27.CalcTotal = false;
            this.Д27.Caption = "27";
            this.Д27.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д27.Name = "Д27";
            this.Д27.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д27.PropertyType = typeof(decimal);
            this.Д27.SearchCondition.OwnerComponent = this.Д27;
            this.Д27.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д28
            // 
            this.Д28.AutoGenerated = true;
            this.Д28.CalcTotal = false;
            this.Д28.Caption = "28";
            this.Д28.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д28.Name = "Д28";
            this.Д28.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д28.PropertyType = typeof(decimal);
            this.Д28.SearchCondition.OwnerComponent = this.Д28;
            this.Д28.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д29
            // 
            this.Д29.AutoGenerated = true;
            this.Д29.CalcTotal = false;
            this.Д29.Caption = "29";
            this.Д29.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д29.Name = "Д29";
            this.Д29.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д29.PropertyType = typeof(decimal);
            this.Д29.SearchCondition.OwnerComponent = this.Д29;
            this.Д29.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д30
            // 
            this.Д30.AutoGenerated = true;
            this.Д30.CalcTotal = false;
            this.Д30.Caption = "30";
            this.Д30.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д30.Name = "Д30";
            this.Д30.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д30.PropertyType = typeof(decimal);
            this.Д30.SearchCondition.OwnerComponent = this.Д30;
            this.Д30.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д31
            // 
            this.Д31.AutoGenerated = true;
            this.Д31.CalcTotal = false;
            this.Д31.Caption = "31";
            this.Д31.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д31.Name = "Д31";
            this.Д31.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д31.PropertyType = typeof(decimal);
            this.Д31.SearchCondition.OwnerComponent = this.Д31;
            this.Д31.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д4
            // 
            this.Д4.AutoGenerated = true;
            this.Д4.CalcTotal = false;
            this.Д4.Caption = "4";
            this.Д4.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д4.Name = "Д4";
            this.Д4.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д4.PropertyType = typeof(decimal);
            this.Д4.SearchCondition.OwnerComponent = this.Д4;
            this.Д4.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д5
            // 
            this.Д5.AutoGenerated = true;
            this.Д5.CalcTotal = false;
            this.Д5.Caption = "5";
            this.Д5.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д5.Name = "Д5";
            this.Д5.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д5.PropertyType = typeof(decimal);
            this.Д5.SearchCondition.OwnerComponent = this.Д5;
            this.Д5.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д6
            // 
            this.Д6.AutoGenerated = true;
            this.Д6.CalcTotal = false;
            this.Д6.Caption = "6";
            this.Д6.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д6.Name = "Д6";
            this.Д6.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д6.PropertyType = typeof(decimal);
            this.Д6.SearchCondition.OwnerComponent = this.Д6;
            this.Д6.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д7
            // 
            this.Д7.AutoGenerated = true;
            this.Д7.CalcTotal = false;
            this.Д7.Caption = "7";
            this.Д7.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д7.Name = "Д7";
            this.Д7.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д7.PropertyType = typeof(decimal);
            this.Д7.SearchCondition.OwnerComponent = this.Д7;
            this.Д7.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д8
            // 
            this.Д8.AutoGenerated = true;
            this.Д8.CalcTotal = false;
            this.Д8.Caption = "8";
            this.Д8.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д8.Name = "Д8";
            this.Д8.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д8.PropertyType = typeof(decimal);
            this.Д8.SearchCondition.OwnerComponent = this.Д8;
            this.Д8.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д9
            // 
            this.Д9.AutoGenerated = true;
            this.Д9.CalcTotal = false;
            this.Д9.Caption = "9";
            this.Д9.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д9.Name = "Д9";
            this.Д9.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д9.PropertyType = typeof(decimal);
            this.Д9.SearchCondition.OwnerComponent = this.Д9;
            this.Д9.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д10
            // 
            this.Д10.AutoGenerated = true;
            this.Д10.CalcTotal = false;
            this.Д10.Caption = "10";
            this.Д10.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д10.Name = "Д10";
            this.Д10.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д10.PropertyType = typeof(decimal);
            this.Д10.SearchCondition.OwnerComponent = this.Д10;
            this.Д10.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д11
            // 
            this.Д11.AutoGenerated = true;
            this.Д11.CalcTotal = false;
            this.Д11.Caption = "11";
            this.Д11.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д11.Name = "Д11";
            this.Д11.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д11.PropertyType = typeof(decimal);
            this.Д11.SearchCondition.OwnerComponent = this.Д11;
            this.Д11.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д12
            // 
            this.Д12.AutoGenerated = true;
            this.Д12.CalcTotal = false;
            this.Д12.Caption = "12";
            this.Д12.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д12.Name = "Д12";
            this.Д12.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д12.PropertyType = typeof(decimal);
            this.Д12.SearchCondition.OwnerComponent = this.Д12;
            this.Д12.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д13
            // 
            this.Д13.AutoGenerated = true;
            this.Д13.CalcTotal = false;
            this.Д13.Caption = "13";
            this.Д13.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д13.Name = "Д13";
            this.Д13.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д13.PropertyType = typeof(decimal);
            this.Д13.SearchCondition.OwnerComponent = this.Д13;
            this.Д13.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д15
            // 
            this.Д15.AutoGenerated = true;
            this.Д15.CalcTotal = false;
            this.Д15.Caption = "15";
            this.Д15.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д15.Name = "Д15";
            this.Д15.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д15.PropertyType = typeof(decimal);
            this.Д15.SearchCondition.OwnerComponent = this.Д15;
            this.Д15.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д16
            // 
            this.Д16.AutoGenerated = true;
            this.Д16.CalcTotal = false;
            this.Д16.Caption = "16";
            this.Д16.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д16.Name = "Д16";
            this.Д16.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д16.PropertyType = typeof(decimal);
            this.Д16.SearchCondition.OwnerComponent = this.Д16;
            this.Д16.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д17
            // 
            this.Д17.AutoGenerated = true;
            this.Д17.CalcTotal = false;
            this.Д17.Caption = "17";
            this.Д17.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д17.Name = "Д17";
            this.Д17.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д17.PropertyType = typeof(decimal);
            this.Д17.SearchCondition.OwnerComponent = this.Д17;
            this.Д17.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д18
            // 
            this.Д18.AutoGenerated = true;
            this.Д18.CalcTotal = false;
            this.Д18.Caption = "18";
            this.Д18.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д18.Name = "Д18";
            this.Д18.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д18.PropertyType = typeof(decimal);
            this.Д18.SearchCondition.OwnerComponent = this.Д18;
            this.Д18.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д19
            // 
            this.Д19.AutoGenerated = true;
            this.Д19.CalcTotal = false;
            this.Д19.Caption = "19";
            this.Д19.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д19.Name = "Д19";
            this.Д19.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д19.PropertyType = typeof(decimal);
            this.Д19.SearchCondition.OwnerComponent = this.Д19;
            this.Д19.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д20
            // 
            this.Д20.AutoGenerated = true;
            this.Д20.CalcTotal = false;
            this.Д20.Caption = "20";
            this.Д20.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д20.Name = "Д20";
            this.Д20.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д20.PropertyType = typeof(decimal);
            this.Д20.SearchCondition.OwnerComponent = this.Д20;
            this.Д20.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д21
            // 
            this.Д21.AutoGenerated = true;
            this.Д21.CalcTotal = false;
            this.Д21.Caption = "21";
            this.Д21.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д21.Name = "Д21";
            this.Д21.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д21.PropertyType = typeof(decimal);
            this.Д21.SearchCondition.OwnerComponent = this.Д21;
            this.Д21.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д22
            // 
            this.Д22.AutoGenerated = true;
            this.Д22.CalcTotal = false;
            this.Д22.Caption = "22";
            this.Д22.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д22.Name = "Д22";
            this.Д22.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д22.PropertyType = typeof(decimal);
            this.Д22.SearchCondition.OwnerComponent = this.Д22;
            this.Д22.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д23
            // 
            this.Д23.AutoGenerated = true;
            this.Д23.CalcTotal = false;
            this.Д23.Caption = "23";
            this.Д23.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д23.Name = "Д23";
            this.Д23.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д23.PropertyType = typeof(decimal);
            this.Д23.SearchCondition.OwnerComponent = this.Д23;
            this.Д23.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д24
            // 
            this.Д24.AutoGenerated = true;
            this.Д24.CalcTotal = false;
            this.Д24.Caption = "24";
            this.Д24.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д24.Name = "Д24";
            this.Д24.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д24.PropertyType = typeof(decimal);
            this.Д24.SearchCondition.OwnerComponent = this.Д24;
            this.Д24.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д26
            // 
            this.Д26.AutoGenerated = true;
            this.Д26.CalcTotal = false;
            this.Д26.Caption = "26";
            this.Д26.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д26.Name = "Д26";
            this.Д26.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д26.PropertyType = typeof(decimal);
            this.Д26.SearchCondition.OwnerComponent = this.Д26;
            this.Д26.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д1
            // 
            this.Д1.AutoGenerated = true;
            this.Д1.CalcTotal = false;
            this.Д1.Caption = "1";
            this.Д1.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Д1.Name = "Д1";
            this.Д1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д1.PropertyType = typeof(decimal);
            this.Д1.SearchCondition.OwnerComponent = this.Д1;
            this.Д1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата документа";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Документы.ОтработанныеМесяцы.ДатаДокумента";
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
            this.nsgInput1.Requsite = "ДатаДокумента";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(130, 20);
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
            this.nsgInput2.FullName = "Документы.ОтработанныеМесяцы.Объект";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(106, 38);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Объект";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(349, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 13;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 45);
            this.label2.Name = "label1";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Объект";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.Format = NsgSoft.Common.NsgDateTimeFormat.Month;
            this.nsgInput3.FullName = "Документы.ОтработанныеМесяцы.МесяцИтогов";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(106, 69);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "МесяцИтогов";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(130, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 15;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label1";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Месяц итогов";
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
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.ДокументыОтработанныеМесяцыТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.ДокументыОтработанныеМесяцыТаблица);
            this.Таблица.SearchCondition.OwnerComponent = this.Таблица;
            this.Таблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Таблица.Visible = false;
            // 
            // Контрагент
            // 
            this.Контрагент.AutoGenerated = true;
            this.Контрагент.Caption = "Контрагент";
            this.Контрагент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Контрагент.Name = "Контрагент";
            this.Контрагент.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Контрагент.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Контрагент.SearchCondition.OwnerComponent = this.Контрагент;
            this.Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // МесяцИтогов
            // 
            this.МесяцИтогов.AutoGenerated = true;
            this.МесяцИтогов.Caption = "МесяцИтогов";
            this.МесяцИтогов.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.МесяцИтогов.Name = "МесяцИтогов";
            this.МесяцИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.МесяцИтогов.PropertyType = typeof(System.DateTime);
            this.МесяцИтогов.SearchCondition.OwnerComponent = this.МесяцИтогов;
            this.МесяцИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // bgwЗаполнениеДанныхПоГрафику
            // 
            this.bgwЗаполнениеДанныхПоГрафику.CancelForbidden = false;
            this.bgwЗаполнениеДанныхПоГрафику.CurrentProgressValue = 0;
            this.bgwЗаполнениеДанныхПоГрафику.Description = "";
            this.bgwЗаполнениеДанныхПоГрафику.EventGeneratorObject = null;
            this.bgwЗаполнениеДанныхПоГрафику.MaxProgressValue = 100;
            this.bgwЗаполнениеДанныхПоГрафику.Name = "NsgBackgroundWorker";
            this.bgwЗаполнениеДанныхПоГрафику.OwnerForm = this;
            this.bgwЗаполнениеДанныхПоГрафику.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.bgwЗаполнениеДанныхПоГрафику.ProgressObject = null;
            this.bgwЗаполнениеДанныхПоГрафику.ProgressProcentage = 0;
            this.bgwЗаполнениеДанныхПоГрафику.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwЗаполнениеДанныхПоГрафику_RunWorkerCompleted);
            this.bgwЗаполнениеДанныхПоГрафику.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwЗаполнениеДанныхПоГрафику_DoWork);
            // 
            // nbАнализ
            // 
            this.nbАнализ.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbАнализ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbАнализ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbАнализ.Location = new System.Drawing.Point(471, 61);
            this.nbАнализ.Name = "NsgButton";
            this.nbАнализ.Size = new System.Drawing.Size(163, 25);
            this.nbАнализ.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbАнализ.TabIndex = 17;
            this.nbАнализ.Text = "Сравнить с расписанием";
            this.nbАнализ.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbАнализ.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbАнализ_AsyncClick);
            // 
            // vmoДанныеГрафика
            // 
            this.vmoДанныеГрафика.Columns.Collection.Add(this.Должность_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ГруппаСпТехн_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.КоличДляСравнения_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.КодГруппы_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ1_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ2_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ3_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ4_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ5_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ6_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ7_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ8_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ9_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ10_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ11_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ12_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ13_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ14_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ15_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ16_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ17_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ18_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ19_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ20_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ21_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ22_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ23_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ24_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ25_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ26_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ27_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.Дг28_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ29_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ30_vmoДанныеГрафика);
            this.vmoДанныеГрафика.Columns.Collection.Add(this.ДГ31_vmoДанныеГрафика);
            this.vmoДанныеГрафика.IsActive = true;
            this.vmoДанныеГрафика.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДанныеГрафика.MetaDataName = "";
            this.vmoДанныеГрафика.FullName = "";
            // 
            // Должность_vmoДанныеГрафика
            // 
            this.Должность_vmoДанныеГрафика.Caption = "Должность";
            this.Должность_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Должность_vmoДанныеГрафика.Name = "Должность";
            this.Должность_vmoДанныеГрафика.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoДанныеГрафика.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.Должность_vmoДанныеГрафика;
            this.Должность_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ГруппаСпТехн_vmoДанныеГрафика
            // 
            this.ГруппаСпТехн_vmoДанныеГрафика.Caption = "ГруппаСпТехн";
            this.ГруппаСпТехн_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ГруппаСпТехн_vmoДанныеГрафика.Name = "ГруппаСпТехн";
            this.ГруппаСпТехн_vmoДанныеГрафика.NSGType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпТехн_vmoДанныеГрафика.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ГруппыСпецТехники);
            this.ГруппаСпТехн_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ГруппаСпТехн_vmoДанныеГрафика;
            this.ГруппаСпТехн_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КоличДляСравнения_vmoДанныеГрафика
            // 
            this.КоличДляСравнения_vmoДанныеГрафика.CalcTotal = false;
            this.КоличДляСравнения_vmoДанныеГрафика.Caption = "КоличествоДляСравнения";
            this.КоличДляСравнения_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КоличДляСравнения_vmoДанныеГрафика.Name = "КоличествоДляСравнения";
            this.КоличДляСравнения_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.КоличДляСравнения_vmoДанныеГрафика.PropertyType = typeof(long);
            this.КоличДляСравнения_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.КоличДляСравнения_vmoДанныеГрафика;
            this.КоличДляСравнения_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КодГруппы_vmoДанныеГрафика
            // 
            this.КодГруппы_vmoДанныеГрафика.Caption = "КодГруппы";
            this.КодГруппы_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КодГруппы_vmoДанныеГрафика.Name = "КодГруппы";
            this.КодГруппы_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КодГруппы_vmoДанныеГрафика.PropertyType = typeof(string);
            this.КодГруппы_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.КодГруппы_vmoДанныеГрафика;
            this.КодГруппы_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ1_vmoДанныеГрафика
            // 
            this.ДГ1_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ1_vmoДанныеГрафика.Caption = "1";
            this.ДГ1_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ1_vmoДанныеГрафика.Name = "1";
            this.ДГ1_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ1_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ1_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ1_vmoДанныеГрафика;
            this.ДГ1_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ2_vmoДанныеГрафика
            // 
            this.ДГ2_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ2_vmoДанныеГрафика.Caption = "2";
            this.ДГ2_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ2_vmoДанныеГрафика.Name = "2";
            this.ДГ2_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ2_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ2_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ2_vmoДанныеГрафика;
            this.ДГ2_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ3_vmoДанныеГрафика
            // 
            this.ДГ3_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ3_vmoДанныеГрафика.Caption = "3";
            this.ДГ3_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ3_vmoДанныеГрафика.Name = "3";
            this.ДГ3_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ3_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ3_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ3_vmoДанныеГрафика;
            this.ДГ3_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ4_vmoДанныеГрафика
            // 
            this.ДГ4_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ4_vmoДанныеГрафика.Caption = "4";
            this.ДГ4_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ4_vmoДанныеГрафика.Name = "4";
            this.ДГ4_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ4_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ4_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ4_vmoДанныеГрафика;
            this.ДГ4_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ5_vmoДанныеГрафика
            // 
            this.ДГ5_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ5_vmoДанныеГрафика.Caption = "5";
            this.ДГ5_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ5_vmoДанныеГрафика.Name = "5";
            this.ДГ5_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ5_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ5_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ5_vmoДанныеГрафика;
            this.ДГ5_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ6_vmoДанныеГрафика
            // 
            this.ДГ6_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ6_vmoДанныеГрафика.Caption = "6";
            this.ДГ6_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ6_vmoДанныеГрафика.Name = "6";
            this.ДГ6_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ6_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ6_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ6_vmoДанныеГрафика;
            this.ДГ6_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ7_vmoДанныеГрафика
            // 
            this.ДГ7_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ7_vmoДанныеГрафика.Caption = "7";
            this.ДГ7_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ7_vmoДанныеГрафика.Name = "7";
            this.ДГ7_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ7_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ7_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ7_vmoДанныеГрафика;
            this.ДГ7_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ8_vmoДанныеГрафика
            // 
            this.ДГ8_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ8_vmoДанныеГрафика.Caption = "8";
            this.ДГ8_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ8_vmoДанныеГрафика.Name = "8";
            this.ДГ8_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ8_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ8_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ8_vmoДанныеГрафика;
            this.ДГ8_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ9_vmoДанныеГрафика
            // 
            this.ДГ9_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ9_vmoДанныеГрафика.Caption = "9";
            this.ДГ9_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ9_vmoДанныеГрафика.Name = "9";
            this.ДГ9_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ9_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ9_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ9_vmoДанныеГрафика;
            this.ДГ9_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ10_vmoДанныеГрафика
            // 
            this.ДГ10_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ10_vmoДанныеГрафика.Caption = "10";
            this.ДГ10_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ10_vmoДанныеГрафика.Name = "10";
            this.ДГ10_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ10_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ10_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ10_vmoДанныеГрафика;
            this.ДГ10_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ11_vmoДанныеГрафика
            // 
            this.ДГ11_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ11_vmoДанныеГрафика.Caption = "11";
            this.ДГ11_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ11_vmoДанныеГрафика.Name = "11";
            this.ДГ11_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ11_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ11_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ11_vmoДанныеГрафика;
            this.ДГ11_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ12_vmoДанныеГрафика
            // 
            this.ДГ12_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ12_vmoДанныеГрафика.Caption = "12";
            this.ДГ12_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ12_vmoДанныеГрафика.Name = "12";
            this.ДГ12_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ12_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ12_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ12_vmoДанныеГрафика;
            this.ДГ12_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ13_vmoДанныеГрафика
            // 
            this.ДГ13_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ13_vmoДанныеГрафика.Caption = "13";
            this.ДГ13_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ13_vmoДанныеГрафика.Name = "13";
            this.ДГ13_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ13_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ13_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ13_vmoДанныеГрафика;
            this.ДГ13_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ14_vmoДанныеГрафика
            // 
            this.ДГ14_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ14_vmoДанныеГрафика.Caption = "14";
            this.ДГ14_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ14_vmoДанныеГрафика.Name = "14";
            this.ДГ14_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ14_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ14_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ14_vmoДанныеГрафика;
            this.ДГ14_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ15_vmoДанныеГрафика
            // 
            this.ДГ15_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ15_vmoДанныеГрафика.Caption = "15";
            this.ДГ15_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ15_vmoДанныеГрафика.Name = "15";
            this.ДГ15_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ15_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ15_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ15_vmoДанныеГрафика;
            this.ДГ15_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ16_vmoДанныеГрафика
            // 
            this.ДГ16_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ16_vmoДанныеГрафика.Caption = "16";
            this.ДГ16_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ16_vmoДанныеГрафика.Name = "16";
            this.ДГ16_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ16_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ16_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ16_vmoДанныеГрафика;
            this.ДГ16_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ17_vmoДанныеГрафика
            // 
            this.ДГ17_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ17_vmoДанныеГрафика.Caption = "17";
            this.ДГ17_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ17_vmoДанныеГрафика.Name = "17";
            this.ДГ17_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ17_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ17_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ17_vmoДанныеГрафика;
            this.ДГ17_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ18_vmoДанныеГрафика
            // 
            this.ДГ18_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ18_vmoДанныеГрафика.Caption = "18";
            this.ДГ18_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ18_vmoДанныеГрафика.Name = "18";
            this.ДГ18_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ18_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ18_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ18_vmoДанныеГрафика;
            this.ДГ18_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ19_vmoДанныеГрафика
            // 
            this.ДГ19_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ19_vmoДанныеГрафика.Caption = "19";
            this.ДГ19_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ19_vmoДанныеГрафика.Name = "19";
            this.ДГ19_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ19_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ19_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ19_vmoДанныеГрафика;
            this.ДГ19_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ20_vmoДанныеГрафика
            // 
            this.ДГ20_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ20_vmoДанныеГрафика.Caption = "20";
            this.ДГ20_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ20_vmoДанныеГрафика.Name = "20";
            this.ДГ20_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ20_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ20_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ20_vmoДанныеГрафика;
            this.ДГ20_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ21_vmoДанныеГрафика
            // 
            this.ДГ21_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ21_vmoДанныеГрафика.Caption = "21";
            this.ДГ21_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ21_vmoДанныеГрафика.Name = "21";
            this.ДГ21_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ21_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ21_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ21_vmoДанныеГрафика;
            this.ДГ21_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ22_vmoДанныеГрафика
            // 
            this.ДГ22_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ22_vmoДанныеГрафика.Caption = "22";
            this.ДГ22_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ22_vmoДанныеГрафика.Name = "22";
            this.ДГ22_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ22_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ22_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ22_vmoДанныеГрафика;
            this.ДГ22_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ23_vmoДанныеГрафика
            // 
            this.ДГ23_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ23_vmoДанныеГрафика.Caption = "23";
            this.ДГ23_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ23_vmoДанныеГрафика.Name = "23";
            this.ДГ23_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ23_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ23_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ23_vmoДанныеГрафика;
            this.ДГ23_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ24_vmoДанныеГрафика
            // 
            this.ДГ24_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ24_vmoДанныеГрафика.Caption = "24";
            this.ДГ24_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ24_vmoДанныеГрафика.Name = "24";
            this.ДГ24_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ24_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ24_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ24_vmoДанныеГрафика;
            this.ДГ24_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ25_vmoДанныеГрафика
            // 
            this.ДГ25_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ25_vmoДанныеГрафика.Caption = "25";
            this.ДГ25_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ25_vmoДанныеГрафика.Name = "25";
            this.ДГ25_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ25_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ25_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ25_vmoДанныеГрафика;
            this.ДГ25_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ26_vmoДанныеГрафика
            // 
            this.ДГ26_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ26_vmoДанныеГрафика.Caption = "26";
            this.ДГ26_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ26_vmoДанныеГрафика.Name = "26";
            this.ДГ26_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ26_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ26_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ26_vmoДанныеГрафика;
            this.ДГ26_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ27_vmoДанныеГрафика
            // 
            this.ДГ27_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ27_vmoДанныеГрафика.Caption = "27";
            this.ДГ27_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ27_vmoДанныеГрафика.Name = "27";
            this.ДГ27_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ27_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ27_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ27_vmoДанныеГрафика;
            this.ДГ27_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Дг28_vmoДанныеГрафика
            // 
            this.Дг28_vmoДанныеГрафика.CalcTotal = false;
            this.Дг28_vmoДанныеГрафика.Caption = "28";
            this.Дг28_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Дг28_vmoДанныеГрафика.Name = "28";
            this.Дг28_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Дг28_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.Дг28_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.Дг28_vmoДанныеГрафика;
            this.Дг28_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ29_vmoДанныеГрафика
            // 
            this.ДГ29_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ29_vmoДанныеГрафика.Caption = "29";
            this.ДГ29_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ29_vmoДанныеГрафика.Name = "29";
            this.ДГ29_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ29_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ29_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ29_vmoДанныеГрафика;
            this.ДГ29_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ30_vmoДанныеГрафика
            // 
            this.ДГ30_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ30_vmoДанныеГрафика.Caption = "30";
            this.ДГ30_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ30_vmoДанныеГрафика.Name = "30";
            this.ДГ30_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ30_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ30_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ30_vmoДанныеГрафика;
            this.ДГ30_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДГ31_vmoДанныеГрафика
            // 
            this.ДГ31_vmoДанныеГрафика.CalcTotal = false;
            this.ДГ31_vmoДанныеГрафика.Caption = "31";
            this.ДГ31_vmoДанныеГрафика.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДГ31_vmoДанныеГрафика.Name = "31";
            this.ДГ31_vmoДанныеГрафика.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДГ31_vmoДанныеГрафика.PropertyType = typeof(decimal);
            this.ДГ31_vmoДанныеГрафика.SearchCondition.OwnerComponent = this.ДГ31_vmoДанныеГрафика;
            this.ДГ31_vmoДанныеГрафика.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтработанныеМесяцыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Controls.Add(this.nbАнализ);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgInput3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.label2);
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
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.nbАнализ, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbАнализ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанныеГрафика)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        protected NsgInput nsgInput1;
        protected NsgInput nsgInput2;
        protected System.Windows.Forms.Label label2;
        protected NsgInput nsgInput3;
        protected System.Windows.Forms.Label label3;
        private NsgColumnDescriptor.Guid Идентификатор;
        private NsgColumnDescriptor.Int64 Автоинкремент;
        private NsgColumnDescriptor.String ПрефиксКода;
        private NsgColumnDescriptor.Int64 НомерКода;
        private NsgColumnDescriptor.String НомерДокумента;
        private NsgColumnDescriptor.DateTime ДатаДокумента;
        private NsgColumnDescriptor.String Индекс;
        private NsgColumnDescriptor.MultipleObject ДокументОснование;
        private NsgColumnDescriptor.String Комментарий;
        private Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        private _SystemTables.ДокументыОтработанныеМесяцыТаблица.ColumnDescriptor Таблица;
        private Мониторинг.Контрагенты.ColumnDescriptor Контрагент;
        private Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgColumnDescriptor.DateTime МесяцИтогов;
        private NsgVisualMultipleObject vmoТаблица;
        protected NsgColumnDescriptor.Guid Идентификатор_vmoТаблица;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблица;
        private NsgColumnDescriptor.MultipleObject Владелец;
        private NsgColumnDescriptor.Int64 НомерСтроки;
        private Мониторинг.Техника.ColumnDescriptor Техника;
        private Мониторинг.ФизЛица.ColumnDescriptor Сотрудник;
        private NsgColumnDescriptor.Decimal Д2;
        private Мониторинг.Тарифы.ColumnDescriptor Тариф;
        protected NsgColumnDescriptor.Decimal Д3;
        protected NsgColumnDescriptor.Decimal Д14;
        protected NsgColumnDescriptor.Decimal Д25;
        protected NsgColumnDescriptor.Decimal Д27;
        protected NsgColumnDescriptor.Decimal Д28;
        protected NsgColumnDescriptor.Decimal Д29;
        protected NsgColumnDescriptor.Decimal Д30;
        protected NsgColumnDescriptor.Decimal Д31;
        protected NsgColumnDescriptor.Decimal Д4;
        protected NsgColumnDescriptor.Decimal Д5;
        protected NsgColumnDescriptor.Decimal Д6;
        protected NsgColumnDescriptor.Decimal Д7;
        protected NsgColumnDescriptor.Decimal Д8;
        protected NsgColumnDescriptor.Decimal Д9;
        protected NsgColumnDescriptor.Decimal Д10;
        protected NsgColumnDescriptor.Decimal Д11;
        protected NsgColumnDescriptor.Decimal Д12;
        protected NsgColumnDescriptor.Decimal Д13;
        protected NsgColumnDescriptor.Decimal Д15;
        protected NsgColumnDescriptor.Decimal Д16;
        protected NsgColumnDescriptor.Decimal Д17;
        protected NsgColumnDescriptor.Decimal Д18;
        protected NsgColumnDescriptor.Decimal Д19;
        protected NsgColumnDescriptor.Decimal Д20;
        protected NsgColumnDescriptor.Decimal Д21;
        protected NsgColumnDescriptor.Decimal Д22;
        protected NsgColumnDescriptor.Decimal Д23;
        protected NsgColumnDescriptor.Decimal Д24;
        protected NsgColumnDescriptor.Decimal Д26;
        protected NsgColumnDescriptor.Decimal Д1;
        private Мониторинг.Должности.ColumnDescriptor Должность;
        protected Мониторинг.ГруппыСпецТехники.ColumnDescriptor ГруппаСпецТехники;
        private NsgIGrid nsgIGrid1;
        protected NsgSoft.Design.NsgButton nbАнализ;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoДанныеГрафика;
        private Мониторинг.ГруппыСпецТехники.ColumnDescriptor ГруппаСпТехн_vmoДанныеГрафика;
        private NsgColumnDescriptor.Int64 КоличДляСравнения_vmoДанныеГрафика;
        protected NsgColumnDescriptor.String КодГруппы_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ1_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ2_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ3_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ4_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ5_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ6_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ7_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ8_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ9_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ10_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ11_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ12_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ13_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ14_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ15_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ16_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ17_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ18_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ19_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ20_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ21_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ22_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ23_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ24_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ25_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ26_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ27_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal Дг28_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ29_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ30_vmoДанныеГрафика;
        private NsgColumnDescriptor.Decimal ДГ31_vmoДанныеГрафика;
        private NsgVisualMultipleObject vmoДанныеГрафика;
        private NsgBackgroundWorker bgwЗаполнениеДанныхПоГрафику;
    }
}