using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.ПечатныеФормыДокументов

{
    
    public partial class ПФОтработанныеМесяцыФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПФОтработанныеМесяцыФорма));
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
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
            this.vmoДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Объект_vmoДанные = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник_vmoДанные = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Тариф_vmoДанные = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.Техника_vmoДанные = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.ОтработанноеВремя_vmoДанные = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Техника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Объект_vmoТаблица = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
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
            this.rdsДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoПараметрыОтчета = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.ДатаНачалаОтчета_vmoПараметрыОтчета = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.rdsПараметры = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДанные", this.rdsДанные);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsПараметры", this.rdsПараметры);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoПараметрыОтчета)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsПараметры)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateReport.DisabledImageKey = "disabled_nsgdatadocument";
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateReport.ImageKey = "nsgdatadocument";
            this.btnCreateReport.Location = new System.Drawing.Point(0, 0);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(112, 28);
            this.btnCreateReport.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnCreateReport.TabIndex = 0;
            this.btnCreateReport.Text = "Сформировать";
            this.btnCreateReport.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.AllowDrop = true;
            this.panelButtonReportForm.Controls.Add(this.elementRightsButton);
            this.panelButtonReportForm.Controls.Add(this.formSettingsButton);
            this.panelButtonReportForm.Controls.Add(this.printButton);
            this.panelButtonReportForm.Controls.Add(this.btnCreateReport);
            this.panelButtonReportForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 148);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(418, 28);
            this.panelButtonReportForm.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Печать";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(398, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 28);
            this.printButton.TabIndex = 1;
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.formSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formSettingsButton.DisabledImageKey = "disabled_Settings";
            this.formSettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.formSettingsButton.ImageKey = "Settings";
            this.formSettingsButton.ImagePosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.formSettingsButton.Location = new System.Drawing.Point(112, 0);
            this.formSettingsButton.Name = "formSettingsButton";
            this.formSettingsButton.Size = new System.Drawing.Size(28, 28);
            this.formSettingsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.formSettingsButton.TabIndex = 2;
            this.formSettingsButton.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elementRightsButton
            // 
            this.elementRightsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elementRightsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elementRightsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.elementRightsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.elementRightsButton.Location = new System.Drawing.Point(140, 0);
            this.elementRightsButton.Name = "elementRightsButton";
            this.elementRightsButton.Size = new System.Drawing.Size(88, 28);
            this.elementRightsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.elementRightsButton.TabIndex = 19;
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
            // Идентификатор
            // 
            this.Идентификатор.AutoGenerated = true;
            this.Идентификатор.Caption = "Идентификатор";
            this.Идентификатор.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Автоинкремент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.ПрефиксКода.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.НомерКода.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.НомерДокумента.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.ДатаДокумента.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Индекс.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.ДокументОснование.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Комментарий.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.СостояниеДокумента.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Таблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Объект.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.МесяцИтогов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.МесяцИтогов.Name = "МесяцИтогов";
            this.МесяцИтогов.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.МесяцИтогов.PropertyType = typeof(System.DateTime);
            this.МесяцИтогов.SearchCondition.OwnerComponent = this.МесяцИтогов;
            this.МесяцИтогов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДанные
            // 
            this.vmoДанные.Columns.Collection.Add(this.Объект_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Сотрудник_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Тариф_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.Техника_vmoДанные);
            this.vmoДанные.Columns.Collection.Add(this.ОтработанноеВремя_vmoДанные);
            this.vmoДанные.IsActive = true;
            this.vmoДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДанные.MetaDataName = "";
            this.vmoДанные.FullName = "";
            // 
            // Объект_vmoДанные
            // 
            this.Объект_vmoДанные.Caption = "Объект";
            this.Объект_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoДанные.Name = "Объект";
            this.Объект_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoДанные.SearchCondition.OwnerComponent = this.Объект_vmoДанные;
            this.Объект_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник_vmoДанные
            // 
            this.Сотрудник_vmoДанные.Caption = "Сотрудник";
            this.Сотрудник_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник_vmoДанные.Name = "Сотрудник";
            this.Сотрудник_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник_vmoДанные.SearchCondition.OwnerComponent = this.Сотрудник_vmoДанные;
            this.Сотрудник_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoДанные
            // 
            this.Тариф_vmoДанные.Caption = "Тариф";
            this.Тариф_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_vmoДанные.Name = "Тариф";
            this.Тариф_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoДанные.SearchCondition.OwnerComponent = this.Тариф_vmoДанные;
            this.Тариф_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Техника_vmoДанные
            // 
            this.Техника_vmoДанные.Caption = "Техника";
            this.Техника_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника_vmoДанные.Name = "Техника";
            this.Техника_vmoДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника_vmoДанные.SearchCondition.OwnerComponent = this.Техника_vmoДанные;
            this.Техника_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтработанноеВремя_vmoДанные
            // 
            this.ОтработанноеВремя_vmoДанные.CalcTotal = false;
            this.ОтработанноеВремя_vmoДанные.Caption = "ОтработанноеВремя";
            this.ОтработанноеВремя_vmoДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОтработанноеВремя_vmoДанные.Name = "ОтработанноеВремя";
            this.ОтработанноеВремя_vmoДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОтработанноеВремя_vmoДанные.PropertyType = typeof(decimal);
            this.ОтработанноеВремя_vmoДанные.SearchCondition.OwnerComponent = this.ОтработанноеВремя_vmoДанные;
            this.ОтработанноеВремя_vmoДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoТаблица.MetaDataName = "Метаданные";
            this.vmoТаблица.FullName = "_SystemTables.ДокументыОтработанныеМесяцыТаблица.Владелец";
            // 
            // vmoТаблица
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "_SystemTables.ДокументыОтработанныеМесяцыТаблица.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Документы.ОтработанныеМесяцы.Таблица";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблица.Columns.Collection.Add(this.Идентификатор_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Автоинкремент_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Владелец);
            this.vmoТаблица.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблица.Columns.Collection.Add(this.Техника);
            this.vmoТаблица.Columns.Collection.Add(this.Объект_vmoТаблица);
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
            this.vmoТаблица.IsActive = true;
            this.vmoТаблица.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблица.Binding = nsgMasterDetailBinding2;
            // 
            // Идентификатор_vmoТаблица
            // 
            this.Идентификатор_vmoТаблица.AutoGenerated = true;
            this.Идентификатор_vmoТаблица.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Автоинкремент_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Владелец.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.НомерСтроки.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Техника.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Техника.Name = "Техника";
            this.Техника.NSGType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Техника);
            this.Техника.SearchCondition.OwnerComponent = this.Техника;
            this.Техника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Объект_vmoТаблица
            // 
            this.Объект_vmoТаблица.AutoGenerated = true;
            this.Объект_vmoТаблица.Caption = "Объект";
            this.Объект_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Объект_vmoТаблица.Name = "Объект";
            this.Объект_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.Объект_vmoТаблица.SearchCondition.OwnerComponent = this.Объект_vmoТаблица;
            this.Объект_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сотрудник
            // 
            this.Сотрудник.AutoGenerated = true;
            this.Сотрудник.Caption = "Сотрудник";
            this.Сотрудник.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Сотрудник.SearchCondition.OwnerComponent = this.Сотрудник;
            this.Сотрудник.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Д2
            // 
            this.Д2.AutoGenerated = true;
            this.Д2.CalcTotal = false;
            this.Д2.Caption = "Д2";
            this.Д2.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Тариф.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д3.Caption = "Д3";
            this.Д3.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д14.Caption = "Д14";
            this.Д14.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д25.Caption = "Д25";
            this.Д25.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д27.Caption = "Д27";
            this.Д27.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д28.Caption = "Д28";
            this.Д28.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д29.Caption = "Д29";
            this.Д29.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д30.Caption = "Д30";
            this.Д30.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д31.Caption = "Д31";
            this.Д31.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д4.Caption = "Д4";
            this.Д4.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д5.Caption = "Д5";
            this.Д5.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д6.Caption = "Д6";
            this.Д6.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д7.Caption = "Д7";
            this.Д7.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д8.Caption = "Д8";
            this.Д8.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д9.Caption = "Д9";
            this.Д9.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д10.Caption = "Д10";
            this.Д10.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д11.Caption = "Д11";
            this.Д11.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д12.Caption = "Д12";
            this.Д12.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д13.Caption = "Д13";
            this.Д13.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д15.Caption = "Д15";
            this.Д15.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д16.Caption = "Д16";
            this.Д16.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д17.Caption = "Д17";
            this.Д17.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д18.Caption = "Д18";
            this.Д18.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д19.Caption = "Д19";
            this.Д19.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д20.Caption = "Д20";
            this.Д20.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д21.Caption = "Д21";
            this.Д21.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д22.Caption = "Д22";
            this.Д22.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д23.Caption = "Д23";
            this.Д23.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д24.Caption = "Д24";
            this.Д24.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д26.Caption = "Д26";
            this.Д26.Creator = typeof(NsgSoft.Forms.NsgReportForm);
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
            this.Д1.Caption = "Д1";
            this.Д1.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Д1.Name = "Д1";
            this.Д1.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Д1.PropertyType = typeof(decimal);
            this.Д1.SearchCondition.OwnerComponent = this.Д1;
            this.Д1.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsДанные
            // 
            this.rdsДанные.MasterComponent = this.vmoДанные;
            this.rdsДанные.Name = "rdsДанные";
            // 
            // vmoПараметрыОтчета
            // 
            this.vmoПараметрыОтчета.Columns.Collection.Add(this.ДатаНачалаОтчета_vmoПараметрыОтчета);
            this.vmoПараметрыОтчета.Columns.Collection.Add(this.ДатаОкончанияОтчета_vmoПараметрыОтчета);
            this.vmoПараметрыОтчета.IsActive = true;
            this.vmoПараметрыОтчета.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoПараметрыОтчета.MetaDataName = "";
            this.vmoПараметрыОтчета.FullName = "";
            // 
            // ДатаНачалаОтчета_vmoПараметрыОтчета
            // 
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.Caption = "ДатаНачалаОтчета";
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.Name = "ДатаНачалаОтчета";
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.PropertyType = typeof(System.DateTime);
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.SearchCondition.OwnerComponent = this.ДатаНачалаОтчета_vmoПараметрыОтчета;
            this.ДатаНачалаОтчета_vmoПараметрыОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаОкончанияОтчета_vmoПараметрыОтчета
            // 
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.Caption = "ДатаОкончанияОтчета";
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.Name = "ДатаОкончанияОтчета";
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.PropertyType = typeof(System.DateTime);
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.SearchCondition.OwnerComponent = this.ДатаОкончанияОтчета_vmoПараметрыОтчета;
            this.ДатаОкончанияОтчета_vmoПараметрыОтчета.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsПараметры
            // 
            this.rdsПараметры.MasterComponent = this.vmoПараметрыОтчета;
            this.rdsПараметры.Name = "rdsПараметры";
            this.rdsПараметры.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // nsgReport1
            // 
            this.nsgReport1.CurrentProgressValue = 0;
            this.nsgReport1.HighlightedComponent = null;
            this.nsgReport1.IsSyncMode = true;
            this.nsgReport1.MaxProgressValue = 100;
            this.nsgReport1.OwnerForm = null;
            this.nsgReport1.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport1.ProgressObject = null;
            this.nsgReport1.ProgressProcentage = 0;
            this.nsgReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "NsgSoft.CityGuide.Dll"};
            this.nsgReport1.ReportAlias = "Report";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportGuid = "b47791cb083241d2aecaee26ab11ce48";
            this.nsgReport1.ReportLoaded = false;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsДанные;
            this.stiReportDataSource1.Name = "rdsДанные";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsПараметры;
            this.stiReportDataSource2.Name = "rdsПараметры";
            // 
            // ПФОтработанныеМесяцыФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(418, 176);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoПараметрыОтчета)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsПараметры)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        protected _SystemTables.ДокументыОтработанныеМесяцыТаблица.ColumnDescriptor Таблица;
        protected Мониторинг.Контрагенты.ColumnDescriptor Контрагент;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected NsgColumnDescriptor.DateTime МесяцИтогов;
        protected Мониторинг.Объекты.ColumnDescriptor Объект_vmoДанные;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник_vmoДанные;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoДанные;
        protected Мониторинг.Техника.ColumnDescriptor Техника_vmoДанные;
        protected NsgColumnDescriptor.Decimal ОтработанноеВремя_vmoДанные;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТаблица;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблица;
        private NsgColumnDescriptor.MultipleObject Владелец;
        private NsgColumnDescriptor.Int64 НомерСтроки;
        private Мониторинг.Техника.ColumnDescriptor Техника;
        private Мониторинг.Объекты.ColumnDescriptor Объект_vmoТаблица;
        private Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        private NsgColumnDescriptor.Decimal Д2;
        private Мониторинг.Тарифы.ColumnDescriptor Тариф;
        private NsgColumnDescriptor.Decimal Д3;
        private NsgColumnDescriptor.Decimal Д14;
        private NsgColumnDescriptor.Decimal Д25;
        private NsgColumnDescriptor.Decimal Д27;
        private NsgColumnDescriptor.Decimal Д28;
        private NsgColumnDescriptor.Decimal Д29;
        private NsgColumnDescriptor.Decimal Д30;
        private NsgColumnDescriptor.Decimal Д31;
        private NsgColumnDescriptor.Decimal Д4;
        private NsgColumnDescriptor.Decimal Д5;
        private NsgColumnDescriptor.Decimal Д6;
        private NsgColumnDescriptor.Decimal Д7;
        private NsgColumnDescriptor.Decimal Д8;
        private NsgColumnDescriptor.Decimal Д9;
        private NsgColumnDescriptor.Decimal Д10;
        private NsgColumnDescriptor.Decimal Д11;
        private NsgColumnDescriptor.Decimal Д12;
        private NsgColumnDescriptor.Decimal Д13;
        private NsgColumnDescriptor.Decimal Д15;
        private NsgColumnDescriptor.Decimal Д16;
        private NsgColumnDescriptor.Decimal Д17;
        private NsgColumnDescriptor.Decimal Д18;
        private NsgColumnDescriptor.Decimal Д19;
        private NsgColumnDescriptor.Decimal Д20;
        private NsgColumnDescriptor.Decimal Д21;
        private NsgColumnDescriptor.Decimal Д22;
        private NsgColumnDescriptor.Decimal Д23;
        private NsgColumnDescriptor.Decimal Д24;
        private NsgColumnDescriptor.Decimal Д26;
        protected NsgColumnDescriptor.Decimal Д1;
        private NsgVisualMultipleObject vmoДанные;
        private NsgVisualMultipleObject vmoТаблица;
        protected NsgColumnDescriptor.DateTime ДатаНачалаОтчета_vmoПараметрыОтчета;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsПараметры;
        protected NsgColumnDescriptor.DateTime ДатаОкончанияОтчета_vmoПараметрыОтчета;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.ReportBuilder.NsgReportDataSource rdsДанные;
        private NsgVisualMultipleObject vmoПараметрыОтчета;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
    }
}