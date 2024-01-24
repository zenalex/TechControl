using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.ПечатныеФормыДокументов

{
    
    public partial class ПФЭСМФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПФЭСМФорма));
            this.vmoПодписант = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Подписант_vmoПодписанты = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Должность_vmoПодписанты = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.Подпись_vmoПодписанты = new NsgSoft.Forms.NsgColumnDescriptor();
            this.Печать_vmoПодписанты = new NsgSoft.Forms.NsgColumnDescriptor();
            this.НеПечататьПодписи_vmoПодписанты = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.rdsОсновной = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsТаблица = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoТаблица = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Дата_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ОтработаноЧасов_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДеньМесяца_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Тариф_vmoТаблица = new TechControl.Метаданные.Мониторинг.Тарифы.ColumnDescriptor();
            this.rdsПодписант = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsОсновной", this.rdsОсновной);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsТаблица", this.rdsТаблица);
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsПодписант", this.rdsПодписант);
            this.rdsДляРасчЗПМаш = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Мес1_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес2_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес3_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес4_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес5_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес6_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес7_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес8_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес9_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес10_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Мес11_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЧМ1_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ2_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ3_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ4_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ5_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ6_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ7_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ8_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ9_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ10_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ЧМ11_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ИтогоДней_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.stiReportDataSource4 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДляРасчЗПМаш", this.rdsДляРасчЗПМаш);
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
            this.Техника = new TechControl.Метаданные.Мониторинг.Техника.ColumnDescriptor();
            this.Контрагент = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Фирма = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.Объект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Сотрудник = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.Таблица = new TechControl.Метаданные._SystemTables.ДокументыЭСМТаблица.ColumnDescriptor();
            this.По = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ТаблицаДокументов = new TechControl.Метаданные._SystemTables.ДокументыЭСМТаблицаДокументов.ColumnDescriptor();
            this.СотрудникПодписант = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.ДолжностьПодписанта = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.НеПечататьПодписи = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.С = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.Цена_vmoТаблица = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoПодписант)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновной)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsПодписант)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДляРасчЗПМаш)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДляРасчЗПМашинистов)).BeginInit();
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Техника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Контрагент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Фирма);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Объект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Сотрудник);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Таблица);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.По);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаДокументов);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СотрудникПодписант);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДолжностьПодписанта);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НеПечататьПодписи);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.С);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Документы.ЭСМ";
            // 
            // vmoПодписант
            // 
            this.vmoПодписант.Columns.Collection.Add(this.Подписант_vmoПодписанты);
            this.vmoПодписант.Columns.Collection.Add(this.Должность_vmoПодписанты);
            this.vmoПодписант.Columns.Collection.Add(this.Подпись_vmoПодписанты);
            this.vmoПодписант.Columns.Collection.Add(this.Печать_vmoПодписанты);
            this.vmoПодписант.Columns.Collection.Add(this.НеПечататьПодписи_vmoПодписанты);
            this.vmoПодписант.IsActive = true;
            this.vmoПодписант.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoПодписант.MetaDataName = "";
            this.vmoПодписант.FullName = "";
            // 
            // Подписант_vmoПодписанты
            // 
            this.Подписант_vmoПодписанты.Caption = "Подписант";
            this.Подписант_vmoПодписанты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подписант_vmoПодписанты.Name = "Подписант";
            this.Подписант_vmoПодписанты.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Подписант_vmoПодписанты.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.Подписант_vmoПодписанты.SearchCondition.OwnerComponent = this.Подписант_vmoПодписанты;
            this.Подписант_vmoПодписанты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность_vmoПодписанты
            // 
            this.Должность_vmoПодписанты.Caption = "Должность";
            this.Должность_vmoПодписанты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Должность_vmoПодписанты.Name = "Должность";
            this.Должность_vmoПодписанты.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoПодписанты.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoПодписанты.SearchCondition.OwnerComponent = this.Должность_vmoПодписанты;
            this.Должность_vmoПодписанты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подпись_vmoПодписанты
            // 
            this.Подпись_vmoПодписанты.Caption = "Подпись";
            this.Подпись_vmoПодписанты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Подпись_vmoПодписанты.Name = "Подпись";
            this.Подпись_vmoПодписанты.NSGType = typeof(NsgSoft.DataObjects.NsgDataImage);
            this.Подпись_vmoПодписанты.PropertyType = typeof(System.Drawing.Image);
            this.Подпись_vmoПодписанты.SearchCondition.OwnerComponent = this.Подпись_vmoПодписанты;
            this.Подпись_vmoПодписанты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Печать_vmoПодписанты
            // 
            this.Печать_vmoПодписанты.Caption = "Печать";
            this.Печать_vmoПодписанты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Печать_vmoПодписанты.Name = "Печать";
            this.Печать_vmoПодписанты.NSGType = typeof(NsgSoft.DataObjects.NsgDataImage);
            this.Печать_vmoПодписанты.PropertyType = typeof(System.Drawing.Image);
            this.Печать_vmoПодписанты.SearchCondition.OwnerComponent = this.Печать_vmoПодписанты;
            this.Печать_vmoПодписанты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НеПечататьПодписи_vmoПодписанты
            // 
            this.НеПечататьПодписи_vmoПодписанты.Caption = "НеПечататьПодписи";
            this.НеПечататьПодписи_vmoПодписанты.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НеПечататьПодписи_vmoПодписанты.Name = "НеПечататьПодписи";
            this.НеПечататьПодписи_vmoПодписанты.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.НеПечататьПодписи_vmoПодписанты.PropertyType = typeof(bool);
            this.НеПечататьПодписи_vmoПодписанты.SearchCondition.OwnerComponent = this.НеПечататьПодписи_vmoПодписанты;
            this.НеПечататьПодписи_vmoПодписанты.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsОсновной
            // 
            this.rdsОсновной.MasterComponent = this.nsgVisualMultipleObject;
            this.rdsОсновной.Name = "rdsОсновной";
            this.rdsОсновной.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // rdsТаблица
            // 
            this.rdsТаблица.MasterComponent = this.vmoТаблица;
            this.rdsТаблица.Name = "rdsТаблица";
            // 
            // vmoТаблица
            // 
            this.vmoТаблица.Columns.Collection.Add(this.Дата_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.ОтработаноЧасов_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.ДеньМесяца_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Тариф_vmoТаблица);
            this.vmoТаблица.Columns.Collection.Add(this.Цена_vmoТаблица);
            this.vmoТаблица.IsActive = true;
            this.vmoТаблица.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблица.MetaDataName = "";
            this.vmoТаблица.FullName = "";
            // 
            // Дата_vmoТаблица
            // 
            this.Дата_vmoТаблица.Caption = "Дата";
            this.Дата_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Дата_vmoТаблица.Name = "Дата";
            this.Дата_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.Дата_vmoТаблица.PropertyType = typeof(System.DateTime);
            this.Дата_vmoТаблица.SearchCondition.OwnerComponent = this.Дата_vmoТаблица;
            this.Дата_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОтработаноЧасов_vmoТаблица
            // 
            this.ОтработаноЧасов_vmoТаблица.CalcTotal = false;
            this.ОтработаноЧасов_vmoТаблица.Caption = "ОтработаноЧасов";
            this.ОтработаноЧасов_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ОтработаноЧасов_vmoТаблица.Name = "ОтработаноЧасов";
            this.ОтработаноЧасов_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОтработаноЧасов_vmoТаблица.PropertyType = typeof(decimal);
            this.ОтработаноЧасов_vmoТаблица.SearchCondition.OwnerComponent = this.ОтработаноЧасов_vmoТаблица;
            this.ОтработаноЧасов_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДеньМесяца_vmoТаблица
            // 
            this.ДеньМесяца_vmoТаблица.CalcTotal = false;
            this.ДеньМесяца_vmoТаблица.Caption = "ДеньМесяца";
            this.ДеньМесяца_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДеньМесяца_vmoТаблица.Name = "ДеньМесяца";
            this.ДеньМесяца_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ДеньМесяца_vmoТаблица.PropertyType = typeof(long);
            this.ДеньМесяца_vmoТаблица.SearchCondition.OwnerComponent = this.ДеньМесяца_vmoТаблица;
            this.ДеньМесяца_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Тариф_vmoТаблица
            // 
            this.Тариф_vmoТаблица.Caption = "Тариф";
            this.Тариф_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Тариф_vmoТаблица.Name = "Тариф";
            this.Тариф_vmoТаблица.NSGType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Тарифы);
            this.Тариф_vmoТаблица.SearchCondition.OwnerComponent = this.Тариф_vmoТаблица;
            this.Тариф_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsПодписант
            // 
            this.rdsПодписант.MasterComponent = this.vmoПодписант;
            this.rdsПодписант.Name = "rdsПодписант";
            this.rdsПодписант.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
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
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource3);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource4);
            this.nsgReport1.ReportGuid = "0ef1c4bf184e4555b034ce8141bd761a";
            this.nsgReport1.ReportLoaded = false;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = null;
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsОсновной;
            this.stiReportDataSource1.Name = "rdsОсновной";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsТаблица;
            this.stiReportDataSource2.Name = "rdsТаблица";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.rdsПодписант;
            this.stiReportDataSource3.Name = "rdsПодписант";
            // 
            // rdsДляРасчЗПМаш
            // 
            this.rdsДляРасчЗПМаш.MasterComponent = this.vmoДляРасчЗПМашинистов;
            this.rdsДляРасчЗПМаш.Name = "rdsДляРасчЗПМаш";
            this.rdsДляРасчЗПМаш.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // vmoДляРасчЗПМашинистов
            // 
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес1_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес2_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес3_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес4_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес5_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес6_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес7_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес8_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес9_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес10_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.Мес11_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ1_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ2_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ3_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ4_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ5_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ6_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ7_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ8_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ9_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ10_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ЧМ11_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ИтогоДней_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.Columns.Collection.Add(this.ИтогоЧасов_vmoДляРасчЗПМашинистов);
            this.vmoДляРасчЗПМашинистов.IsActive = true;
            this.vmoДляРасчЗПМашинистов.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДляРасчЗПМашинистов.MetaDataName = "";
            this.vmoДляРасчЗПМашинистов.FullName = "";
            // 
            // Мес1_vmoДляРасчЗПМашинистов
            // 
            this.Мес1_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес1_vmoДляРасчЗПМашинистов.Caption = "Мес1";
            this.Мес1_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес1_vmoДляРасчЗПМашинистов.Name = "Мес1";
            this.Мес1_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес1_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес1_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес1_vmoДляРасчЗПМашинистов;
            this.Мес1_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес2_vmoДляРасчЗПМашинистов
            // 
            this.Мес2_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес2_vmoДляРасчЗПМашинистов.Caption = "Мес2";
            this.Мес2_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес2_vmoДляРасчЗПМашинистов.Name = "Мес2";
            this.Мес2_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес2_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес2_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес2_vmoДляРасчЗПМашинистов;
            this.Мес2_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес3_vmoДляРасчЗПМашинистов
            // 
            this.Мес3_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес3_vmoДляРасчЗПМашинистов.Caption = "Мес3";
            this.Мес3_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес3_vmoДляРасчЗПМашинистов.Name = "Мес3";
            this.Мес3_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес3_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес3_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес3_vmoДляРасчЗПМашинистов;
            this.Мес3_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес4_vmoДляРасчЗПМашинистов
            // 
            this.Мес4_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес4_vmoДляРасчЗПМашинистов.Caption = "Мес4";
            this.Мес4_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес4_vmoДляРасчЗПМашинистов.Name = "Мес4";
            this.Мес4_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес4_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес4_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес4_vmoДляРасчЗПМашинистов;
            this.Мес4_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес5_vmoДляРасчЗПМашинистов
            // 
            this.Мес5_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес5_vmoДляРасчЗПМашинистов.Caption = "Мес5";
            this.Мес5_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес5_vmoДляРасчЗПМашинистов.Name = "Мес5";
            this.Мес5_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес5_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес5_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес5_vmoДляРасчЗПМашинистов;
            this.Мес5_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес6_vmoДляРасчЗПМашинистов
            // 
            this.Мес6_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес6_vmoДляРасчЗПМашинистов.Caption = "Мес6";
            this.Мес6_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес6_vmoДляРасчЗПМашинистов.Name = "Мес6";
            this.Мес6_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес6_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес6_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес6_vmoДляРасчЗПМашинистов;
            this.Мес6_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес7_vmoДляРасчЗПМашинистов
            // 
            this.Мес7_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес7_vmoДляРасчЗПМашинистов.Caption = "Мес7";
            this.Мес7_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес7_vmoДляРасчЗПМашинистов.Name = "Мес7";
            this.Мес7_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес7_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес7_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес7_vmoДляРасчЗПМашинистов;
            this.Мес7_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес8_vmoДляРасчЗПМашинистов
            // 
            this.Мес8_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес8_vmoДляРасчЗПМашинистов.Caption = "Мес8";
            this.Мес8_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес8_vmoДляРасчЗПМашинистов.Name = "Мес8";
            this.Мес8_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес8_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес8_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес8_vmoДляРасчЗПМашинистов;
            this.Мес8_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес9_vmoДляРасчЗПМашинистов
            // 
            this.Мес9_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес9_vmoДляРасчЗПМашинистов.Caption = "Мес9";
            this.Мес9_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес9_vmoДляРасчЗПМашинистов.Name = "Мес9";
            this.Мес9_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес9_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес9_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес9_vmoДляРасчЗПМашинистов;
            this.Мес9_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес10_vmoДляРасчЗПМашинистов
            // 
            this.Мес10_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес10_vmoДляРасчЗПМашинистов.Caption = "Мес10";
            this.Мес10_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес10_vmoДляРасчЗПМашинистов.Name = "Мес10";
            this.Мес10_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес10_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес10_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес10_vmoДляРасчЗПМашинистов;
            this.Мес10_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Мес11_vmoДляРасчЗПМашинистов
            // 
            this.Мес11_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.Мес11_vmoДляРасчЗПМашинистов.Caption = "Мес11";
            this.Мес11_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Мес11_vmoДляРасчЗПМашинистов.Name = "Мес11";
            this.Мес11_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Мес11_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.Мес11_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.Мес11_vmoДляРасчЗПМашинистов;
            this.Мес11_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ1_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ1_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ1_vmoДляРасчЗПМашинистов.Caption = "ЧМ1";
            this.ЧМ1_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ1_vmoДляРасчЗПМашинистов.Name = "ЧМ1";
            this.ЧМ1_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ1_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ1_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ1_vmoДляРасчЗПМашинистов;
            this.ЧМ1_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ2_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ2_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ2_vmoДляРасчЗПМашинистов.Caption = "ЧМ2";
            this.ЧМ2_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ2_vmoДляРасчЗПМашинистов.Name = "ЧМ2";
            this.ЧМ2_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ2_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ2_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ2_vmoДляРасчЗПМашинистов;
            this.ЧМ2_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ3_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ3_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ3_vmoДляРасчЗПМашинистов.Caption = "ЧМ3";
            this.ЧМ3_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ3_vmoДляРасчЗПМашинистов.Name = "ЧМ3";
            this.ЧМ3_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ3_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ3_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ3_vmoДляРасчЗПМашинистов;
            this.ЧМ3_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ4_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ4_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ4_vmoДляРасчЗПМашинистов.Caption = "ЧМ4";
            this.ЧМ4_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ4_vmoДляРасчЗПМашинистов.Name = "ЧМ4";
            this.ЧМ4_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ4_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ4_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ4_vmoДляРасчЗПМашинистов;
            this.ЧМ4_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ5_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ5_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ5_vmoДляРасчЗПМашинистов.Caption = "ЧМ5";
            this.ЧМ5_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ5_vmoДляРасчЗПМашинистов.Name = "ЧМ5";
            this.ЧМ5_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ5_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ5_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ5_vmoДляРасчЗПМашинистов;
            this.ЧМ5_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ6_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ6_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ6_vmoДляРасчЗПМашинистов.Caption = "ЧМ6";
            this.ЧМ6_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ6_vmoДляРасчЗПМашинистов.Name = "ЧМ6";
            this.ЧМ6_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ6_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ6_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ6_vmoДляРасчЗПМашинистов;
            this.ЧМ6_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ7_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ7_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ7_vmoДляРасчЗПМашинистов.Caption = "ЧМ7";
            this.ЧМ7_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ7_vmoДляРасчЗПМашинистов.Name = "ЧМ7";
            this.ЧМ7_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ7_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ7_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ7_vmoДляРасчЗПМашинистов;
            this.ЧМ7_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ8_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ8_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ8_vmoДляРасчЗПМашинистов.Caption = "ЧМ8";
            this.ЧМ8_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ8_vmoДляРасчЗПМашинистов.Name = "ЧМ8";
            this.ЧМ8_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ8_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ8_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ8_vmoДляРасчЗПМашинистов;
            this.ЧМ8_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ9_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ9_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ9_vmoДляРасчЗПМашинистов.Caption = "ЧМ9";
            this.ЧМ9_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ9_vmoДляРасчЗПМашинистов.Name = "ЧМ9";
            this.ЧМ9_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ9_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ9_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ9_vmoДляРасчЗПМашинистов;
            this.ЧМ9_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ10_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ10_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ10_vmoДляРасчЗПМашинистов.Caption = "ЧМ10";
            this.ЧМ10_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ10_vmoДляРасчЗПМашинистов.Name = "ЧМ10";
            this.ЧМ10_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ10_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ10_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ10_vmoДляРасчЗПМашинистов;
            this.ЧМ10_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЧМ11_vmoДляРасчЗПМашинистов
            // 
            this.ЧМ11_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ЧМ11_vmoДляРасчЗПМашинистов.Caption = "ЧМ11";
            this.ЧМ11_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ЧМ11_vmoДляРасчЗПМашинистов.Name = "ЧМ11";
            this.ЧМ11_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ЧМ11_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ЧМ11_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ЧМ11_vmoДляРасчЗПМашинистов;
            this.ЧМ11_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоДней_vmoДляРасчЗПМашинистов
            // 
            this.ИтогоДней_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ИтогоДней_vmoДляРасчЗПМашинистов.Caption = "ИтогоДней";
            this.ИтогоДней_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоДней_vmoДляРасчЗПМашинистов.Name = "ИтогоДней";
            this.ИтогоДней_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.ИтогоДней_vmoДляРасчЗПМашинистов.PropertyType = typeof(long);
            this.ИтогоДней_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ИтогоДней_vmoДляРасчЗПМашинистов;
            this.ИтогоДней_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИтогоЧасов_vmoДляРасчЗПМашинистов
            // 
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.CalcTotal = false;
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.Caption = "ИтогоЧасов";
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.Name = "ИтогоЧасов";
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.PropertyType = typeof(decimal);
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.SearchCondition.OwnerComponent = this.ИтогоЧасов_vmoДляРасчЗПМашинистов;
            this.ИтогоЧасов_vmoДляРасчЗПМашинистов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource4
            // 
            this.stiReportDataSource4.Item = this.rdsДляРасчЗПМаш;
            this.stiReportDataSource4.Name = "rdsДляРасчЗПМаш";
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
            // Фирма
            // 
            this.Фирма.AutoGenerated = true;
            this.Фирма.Caption = "Фирма";
            this.Фирма.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фирма.Name = "Фирма";
            this.Фирма.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма.SearchCondition.OwnerComponent = this.Фирма;
            this.Фирма.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Таблица
            // 
            this.Таблица.AutoGenerated = true;
            this.Таблица.Caption = "Таблица";
            this.Таблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Таблица.Name = "Таблица";
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.ДокументыЭСМТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.ДокументыЭСМТаблица);
            this.Таблица.SearchCondition.OwnerComponent = this.Таблица;
            this.Таблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Таблица.Visible = false;
            // 
            // По
            // 
            this.По.AutoGenerated = true;
            this.По.Caption = "По";
            this.По.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.По.Name = "По";
            this.По.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.По.PropertyType = typeof(System.DateTime);
            this.По.SearchCondition.OwnerComponent = this.По;
            this.По.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаДокументов
            // 
            this.ТаблицаДокументов.AutoGenerated = true;
            this.ТаблицаДокументов.Caption = "ТаблицаДокументов";
            this.ТаблицаДокументов.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ТаблицаДокументов.Name = "ТаблицаДокументов";
            this.ТаблицаДокументов.NSGType = typeof(TechControl.Метаданные._SystemTables.ДокументыЭСМТаблицаДокументов);
            this.ТаблицаДокументов.PropertyType = typeof(TechControl.Метаданные._SystemTables.ДокументыЭСМТаблицаДокументов);
            this.ТаблицаДокументов.SearchCondition.OwnerComponent = this.ТаблицаДокументов;
            this.ТаблицаДокументов.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаДокументов.Visible = false;
            // 
            // СотрудникПодписант
            // 
            this.СотрудникПодписант.AutoGenerated = true;
            this.СотрудникПодписант.Caption = "СотрудникПодписант";
            this.СотрудникПодписант.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникПодписант.Name = "СотрудникПодписант";
            this.СотрудникПодписант.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПодписант.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПодписант.SearchCondition.OwnerComponent = this.СотрудникПодписант;
            this.СотрудникПодписант.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДолжностьПодписанта
            // 
            this.ДолжностьПодписанта.AutoGenerated = true;
            this.ДолжностьПодписанта.Caption = "ДолжностьПодписанта";
            this.ДолжностьПодписанта.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДолжностьПодписанта.Name = "ДолжностьПодписанта";
            this.ДолжностьПодписанта.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.ДолжностьПодписанта.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.ДолжностьПодписанта.SearchCondition.OwnerComponent = this.ДолжностьПодписанта;
            this.ДолжностьПодписанта.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НеПечататьПодписи
            // 
            this.НеПечататьПодписи.AutoGenerated = true;
            this.НеПечататьПодписи.Caption = "НеПечататьПодписи";
            this.НеПечататьПодписи.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НеПечататьПодписи.Name = "НеПечататьПодписи";
            this.НеПечататьПодписи.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.НеПечататьПодписи.PropertyType = typeof(bool);
            this.НеПечататьПодписи.SearchCondition.OwnerComponent = this.НеПечататьПодписи;
            this.НеПечататьПодписи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // С
            // 
            this.С.AutoGenerated = true;
            this.С.Caption = "С";
            this.С.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.С.Name = "С";
            this.С.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.С.PropertyType = typeof(System.DateTime);
            this.С.SearchCondition.OwnerComponent = this.С;
            this.С.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТаблица
            // 
            this.Цена_vmoТаблица.CalcTotal = false;
            this.Цена_vmoТаблица.Caption = "Цена";
            this.Цена_vmoТаблица.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Цена_vmoТаблица.Name = "Цена";
            this.Цена_vmoТаблица.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТаблица.PropertyType = typeof(decimal);
            this.Цена_vmoТаблица.SearchCondition.OwnerComponent = this.Цена_vmoТаблица;
            this.Цена_vmoТаблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПФЭСМФорма
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoПодписант)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновной)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsПодписант)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДляРасчЗПМаш)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДляРасчЗПМашинистов)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsОсновной;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsТаблица;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsПодписант;
        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.DateTime С;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String НомерДокумента;
        protected NsgColumnDescriptor.DateTime ДатаДокумента;
        protected NsgColumnDescriptor.String Индекс;
        protected NsgColumnDescriptor.MultipleObject ДокументОснование;
        protected NsgColumnDescriptor.String Комментарий;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected Мониторинг.Техника.ColumnDescriptor Техника;
        protected Мониторинг.Контрагенты.ColumnDescriptor Контрагент;
        protected Мониторинг.Контрагенты.ColumnDescriptor Фирма;
        protected Мониторинг.Объекты.ColumnDescriptor Объект;
        protected Мониторинг.Сотрудники.ColumnDescriptor Сотрудник;
        protected _SystemTables.ДокументыЭСМТаблица.ColumnDescriptor Таблица;
        protected NsgColumnDescriptor.DateTime По;
        protected _SystemTables.ДокументыЭСМТаблицаДокументов.ColumnDescriptor ТаблицаДокументов;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникПодписант;
        protected Мониторинг.Должности.ColumnDescriptor ДолжностьПодписанта;
        protected NsgColumnDescriptor.Boolean НеПечататьПодписи;
        protected NsgColumnDescriptor.DateTime Дата_vmoТаблица;
        protected Мониторинг.Должности.ColumnDescriptor Должность_vmoПодписанты;
        protected NsgColumnDescriptor Подпись_vmoПодписанты;
        protected NsgColumnDescriptor Печать_vmoПодписанты;
        protected NsgColumnDescriptor.Boolean НеПечататьПодписи_vmoПодписанты;
        protected Мониторинг.Сотрудники.ColumnDescriptor Подписант_vmoПодписанты;
        protected NsgColumnDescriptor.Decimal ОтработаноЧасов_vmoТаблица;
        protected NsgColumnDescriptor.Int64 ДеньМесяца_vmoТаблица;
        protected Мониторинг.Тарифы.ColumnDescriptor Тариф_vmoТаблица;
        protected NsgColumnDescriptor.Int64 Мес1_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 ИтогоДней_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес2_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес3_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес4_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес5_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес6_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес7_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес8_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес9_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес10_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Int64 Мес11_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ1_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ2_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ3_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ4_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ5_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ6_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ7_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ8_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ9_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ10_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal ЧМ11_vmoДляРасчЗПМашинистов;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource4;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДляРасчЗПМаш;
        protected NsgColumnDescriptor.Decimal ИтогоЧасов_vmoДляРасчЗПМашинистов;
        protected NsgColumnDescriptor.Decimal Цена_vmoТаблица;
        private NsgVisualMultipleObject vmoПодписант;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgVisualMultipleObject vmoТаблица;
        private NsgVisualMultipleObject vmoДляРасчЗПМашинистов;
    }
}