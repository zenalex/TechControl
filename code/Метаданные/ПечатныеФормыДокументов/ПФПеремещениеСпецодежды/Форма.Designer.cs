using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.ПечатныеФормыДокументов

{
    
    public partial class ПФПеремещениеСпецодеждыФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПФПеремещениеСпецодеждыФорма));
            this.vmoТабличныеДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoТабличныеДанные = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Комплект_vmoТабличныеДанные = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Размер_vmoТабличныеДанные = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.Количество_vmoТабличныеДанные = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Цена_vmoТабличныеДанные = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Стоимость_vmoТабличныеДанные = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.НазваниеПериода_vmoТабличныеДанные = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СтоимостьВПериоде_vmoТабличныеДанные = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.rdsОсновные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.rdsТабличныеДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsОсновные", this.rdsОсновные);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsТабличныеДанные", this.rdsТабличныеДанные);
            this.rdsТаблицаАмортизации = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoТаблицаАмортизации = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.НазваниеПериода_vmoТаблицаАмортизации = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СуммаЗаПериод_vmoТаблицаАмортизации = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Номенклатура_vmoТаблицаАмортизации = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Размер_vmoТаблицаАмортизации = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.НомерПериода_vmoТаблицаАмортизации = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsТаблицаАмортизации", this.rdsТаблицаАмортизации);
            this.rdsДопДанные = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoДопДанные = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Фирма_vmoДопДанные = new TechControl.Метаданные.Мониторинг.Контрагенты.ColumnDescriptor();
            this.ПредставительФирмы_vmoДопДанные = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            this.stiReportDataSource4 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("rdsДопДанные", this.rdsДопДанные);
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
            this.Таблица = new TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица.ColumnDescriptor();
            this.Получатель = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.Отправитель = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.ДатаНачалаЭксплуатации = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.СотрудникПолучатель_vmoДопДанные = new TechControl.Метаданные.Мониторинг.Сотрудники.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабличныеДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТабличныеДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТаблицаАмортизации)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаАмортизации)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанные)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).BeginInit();
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Получатель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Отправитель);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаНачалаЭксплуатации);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды";
            // 
            // vmoТабличныеДанные
            // 
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Номенклатура_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Комплект_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Размер_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Количество_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Цена_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.Стоимость_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.НазваниеПериода_vmoТабличныеДанные);
            this.vmoТабличныеДанные.Columns.Collection.Add(this.СтоимостьВПериоде_vmoТабличныеДанные);
            this.vmoТабличныеДанные.IsActive = true;
            this.vmoТабличныеДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТабличныеДанные.MetaDataName = "";
            this.vmoТабличныеДанные.FullName = "";
            // 
            // Номенклатура_vmoТабличныеДанные
            // 
            this.Номенклатура_vmoТабличныеДанные.Caption = "Номенклатура";
            this.Номенклатура_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoТабличныеДанные.Name = "Номенклатура";
            this.Номенклатура_vmoТабличныеДанные.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТабличныеДанные.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Номенклатура_vmoТабличныеДанные;
            this.Номенклатура_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комплект_vmoТабличныеДанные
            // 
            this.Комплект_vmoТабличныеДанные.Caption = "Комплект";
            this.Комплект_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Комплект_vmoТабличныеДанные.Name = "Комплект";
            this.Комплект_vmoТабличныеДанные.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoТабличныеДанные.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Комплект_vmoТабличныеДанные;
            this.Комплект_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_vmoТабличныеДанные
            // 
            this.Размер_vmoТабличныеДанные.Caption = "Размер";
            this.Размер_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Размер_vmoТабличныеДанные.Name = "Размер";
            this.Размер_vmoТабличныеДанные.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТабличныеДанные.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Размер_vmoТабличныеДанные;
            this.Размер_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoТабличныеДанные
            // 
            this.Количество_vmoТабличныеДанные.CalcTotal = false;
            this.Количество_vmoТабличныеДанные.Caption = "Количество";
            this.Количество_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_vmoТабличныеДанные.Name = "Количество";
            this.Количество_vmoТабличныеДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoТабличныеДанные.PropertyType = typeof(long);
            this.Количество_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Количество_vmoТабличныеДанные;
            this.Количество_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Цена_vmoТабличныеДанные
            // 
            this.Цена_vmoТабличныеДанные.CalcTotal = false;
            this.Цена_vmoТабличныеДанные.Caption = "Цена";
            this.Цена_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Цена_vmoТабличныеДанные.Name = "Цена";
            this.Цена_vmoТабличныеДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Цена_vmoТабличныеДанные.PropertyType = typeof(decimal);
            this.Цена_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Цена_vmoТабличныеДанные;
            this.Цена_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Стоимость_vmoТабличныеДанные
            // 
            this.Стоимость_vmoТабличныеДанные.CalcTotal = false;
            this.Стоимость_vmoТабличныеДанные.Caption = "Стоимость";
            this.Стоимость_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Стоимость_vmoТабличныеДанные.Name = "Стоимость";
            this.Стоимость_vmoТабличныеДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Стоимость_vmoТабличныеДанные.PropertyType = typeof(decimal);
            this.Стоимость_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.Стоимость_vmoТабличныеДанные;
            this.Стоимость_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НазваниеПериода_vmoТабличныеДанные
            // 
            this.НазваниеПериода_vmoТабличныеДанные.Caption = "НазваниеПериода";
            this.НазваниеПериода_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НазваниеПериода_vmoТабличныеДанные.Name = "НазваниеПериода";
            this.НазваниеПериода_vmoТабличныеДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НазваниеПериода_vmoТабличныеДанные.PropertyType = typeof(string);
            this.НазваниеПериода_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.НазваниеПериода_vmoТабличныеДанные;
            this.НазваниеПериода_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СтоимостьВПериоде_vmoТабличныеДанные
            // 
            this.СтоимостьВПериоде_vmoТабличныеДанные.CalcTotal = false;
            this.СтоимостьВПериоде_vmoТабличныеДанные.Caption = "СтоимостьВПериоде";
            this.СтоимостьВПериоде_vmoТабличныеДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СтоимостьВПериоде_vmoТабличныеДанные.Name = "СтоимостьВПериоде";
            this.СтоимостьВПериоде_vmoТабличныеДанные.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.СтоимостьВПериоде_vmoТабличныеДанные.PropertyType = typeof(decimal);
            this.СтоимостьВПериоде_vmoТабличныеДанные.SearchCondition.OwnerComponent = this.СтоимостьВПериоде_vmoТабличныеДанные;
            this.СтоимостьВПериоде_vmoТабличныеДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // rdsОсновные
            // 
            this.rdsОсновные.MasterComponent = this.nsgVisualMultipleObject;
            this.rdsОсновные.Name = "rdsОсновные";
            this.rdsОсновные.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // rdsТабличныеДанные
            // 
            this.rdsТабличныеДанные.MasterComponent = this.vmoТабличныеДанные;
            this.rdsТабличныеДанные.Name = "rdsТабличныеДанные";
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
            this.nsgReport1.ReportGuid = "d5b7ce3aae4c4d3db0fadb5ad4f5aa62";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Report";
            this.nsgReport1.ReportSource = null;
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.rdsОсновные;
            this.stiReportDataSource1.Name = "rdsОсновные";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.rdsТабличныеДанные;
            this.stiReportDataSource2.Name = "rdsТабличныеДанные";
            // 
            // rdsТаблицаАмортизации
            // 
            this.rdsТаблицаАмортизации.MasterComponent = this.vmoТаблицаАмортизации;
            this.rdsТаблицаАмортизации.Name = "rdsТаблицаАмортизации";
            // 
            // vmoТаблицаАмортизации
            // 
            this.vmoТаблицаАмортизации.Columns.Collection.Add(this.НазваниеПериода_vmoТаблицаАмортизации);
            this.vmoТаблицаАмортизации.Columns.Collection.Add(this.СуммаЗаПериод_vmoТаблицаАмортизации);
            this.vmoТаблицаАмортизации.Columns.Collection.Add(this.Номенклатура_vmoТаблицаАмортизации);
            this.vmoТаблицаАмортизации.Columns.Collection.Add(this.Размер_vmoТаблицаАмортизации);
            this.vmoТаблицаАмортизации.Columns.Collection.Add(this.НомерПериода_vmoТаблицаАмортизации);
            this.vmoТаблицаАмортизации.IsActive = true;
            this.vmoТаблицаАмортизации.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoТаблицаАмортизации.MetaDataName = "";
            this.vmoТаблицаАмортизации.FullName = "";
            // 
            // НазваниеПериода_vmoТаблицаАмортизации
            // 
            this.НазваниеПериода_vmoТаблицаАмортизации.Caption = "НазваниеПериода";
            this.НазваниеПериода_vmoТаблицаАмортизации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НазваниеПериода_vmoТаблицаАмортизации.Name = "НазваниеПериода";
            this.НазваниеПериода_vmoТаблицаАмортизации.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НазваниеПериода_vmoТаблицаАмортизации.PropertyType = typeof(string);
            this.НазваниеПериода_vmoТаблицаАмортизации.SearchCondition.OwnerComponent = this.НазваниеПериода_vmoТаблицаАмортизации;
            this.НазваниеПериода_vmoТаблицаАмортизации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СуммаЗаПериод_vmoТаблицаАмортизации
            // 
            this.СуммаЗаПериод_vmoТаблицаАмортизации.Caption = "СуммаЗаПериод";
            this.СуммаЗаПериод_vmoТаблицаАмортизации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СуммаЗаПериод_vmoТаблицаАмортизации.Name = "СуммаЗаПериод";
            this.СуммаЗаПериод_vmoТаблицаАмортизации.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СуммаЗаПериод_vmoТаблицаАмортизации.PropertyType = typeof(string);
            this.СуммаЗаПериод_vmoТаблицаАмортизации.SearchCondition.OwnerComponent = this.СуммаЗаПериод_vmoТаблицаАмортизации;
            this.СуммаЗаПериод_vmoТаблицаАмортизации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номенклатура_vmoТаблицаАмортизации
            // 
            this.Номенклатура_vmoТаблицаАмортизации.Caption = "Номенклатура";
            this.Номенклатура_vmoТаблицаАмортизации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoТаблицаАмортизации.Name = "Номенклатура";
            this.Номенклатура_vmoТаблицаАмортизации.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаАмортизации.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoТаблицаАмортизации.SearchCondition.OwnerComponent = this.Номенклатура_vmoТаблицаАмортизации;
            this.Номенклатура_vmoТаблицаАмортизации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_vmoТаблицаАмортизации
            // 
            this.Размер_vmoТаблицаАмортизации.Caption = "Размер";
            this.Размер_vmoТаблицаАмортизации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Размер_vmoТаблицаАмортизации.Name = "Размер";
            this.Размер_vmoТаблицаАмортизации.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаАмортизации.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаАмортизации.SearchCondition.OwnerComponent = this.Размер_vmoТаблицаАмортизации;
            this.Размер_vmoТаблицаАмортизации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерПериода_vmoТаблицаАмортизации
            // 
            this.НомерПериода_vmoТаблицаАмортизации.Caption = "НомерПериода";
            this.НомерПериода_vmoТаблицаАмортизации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НомерПериода_vmoТаблицаАмортизации.Name = "НомерПериода";
            this.НомерПериода_vmoТаблицаАмортизации.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерПериода_vmoТаблицаАмортизации.PropertyType = typeof(string);
            this.НомерПериода_vmoТаблицаАмортизации.SearchCondition.OwnerComponent = this.НомерПериода_vmoТаблицаАмортизации;
            this.НомерПериода_vmoТаблицаАмортизации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.rdsТаблицаАмортизации;
            this.stiReportDataSource3.Name = "rdsТаблицаАмортизации";
            // 
            // rdsДопДанные
            // 
            this.rdsДопДанные.MasterComponent = this.vmoДопДанные;
            this.rdsДопДанные.Name = "rdsДопДанные";
            this.rdsДопДанные.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // vmoДопДанные
            // 
            this.vmoДопДанные.Columns.Collection.Add(this.Фирма_vmoДопДанные);
            this.vmoДопДанные.Columns.Collection.Add(this.ПредставительФирмы_vmoДопДанные);
            this.vmoДопДанные.Columns.Collection.Add(this.СотрудникПолучатель_vmoДопДанные);
            this.vmoДопДанные.IsActive = true;
            this.vmoДопДанные.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДопДанные.MetaDataName = "";
            this.vmoДопДанные.FullName = "";
            // 
            // Фирма_vmoДопДанные
            // 
            this.Фирма_vmoДопДанные.Caption = "Фирма";
            this.Фирма_vmoДопДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фирма_vmoДопДанные.Name = "Фирма";
            this.Фирма_vmoДопДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма_vmoДопДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Контрагенты);
            this.Фирма_vmoДопДанные.SearchCondition.OwnerComponent = this.Фирма_vmoДопДанные;
            this.Фирма_vmoДопДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПредставительФирмы_vmoДопДанные
            // 
            this.ПредставительФирмы_vmoДопДанные.Caption = "ПредставительФирмы";
            this.ПредставительФирмы_vmoДопДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПредставительФирмы_vmoДопДанные.Name = "ПредставительФирмы";
            this.ПредставительФирмы_vmoДопДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.ПредставительФирмы_vmoДопДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.ПредставительФирмы_vmoДопДанные.SearchCondition.OwnerComponent = this.ПредставительФирмы_vmoДопДанные;
            this.ПредставительФирмы_vmoДопДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource4
            // 
            this.stiReportDataSource4.Item = this.rdsДопДанные;
            this.stiReportDataSource4.Name = "rdsДопДанные";
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
            this.Таблица.NSGType = typeof(TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица);
            this.Таблица.PropertyType = typeof(TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица);
            this.Таблица.SearchCondition.OwnerComponent = this.Таблица;
            this.Таблица.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Таблица.Visible = false;
            // 
            // Получатель
            // 
            this.Получатель.AutoGenerated = true;
            this.Получатель.Caption = "Получатель";
            this.Получатель.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Получатель.Name = "Получатель";
            this.Получатель.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Получатель.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Получатель.SearchCondition.OwnerComponent = this.Получатель;
            this.Получатель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Отправитель
            // 
            this.Отправитель.AutoGenerated = true;
            this.Отправитель.Caption = "Отправитель";
            this.Отправитель.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Отправитель.Name = "Отправитель";
            this.Отправитель.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Отправитель.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Отправитель.SearchCondition.OwnerComponent = this.Отправитель;
            this.Отправитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаНачалаЭксплуатации
            // 
            this.ДатаНачалаЭксплуатации.AutoGenerated = true;
            this.ДатаНачалаЭксплуатации.Caption = "ДатаНачалаЭксплуатации";
            this.ДатаНачалаЭксплуатации.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ДатаНачалаЭксплуатации.Name = "ДатаНачалаЭксплуатации";
            this.ДатаНачалаЭксплуатации.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаНачалаЭксплуатации.PropertyType = typeof(System.DateTime);
            this.ДатаНачалаЭксплуатации.SearchCondition.OwnerComponent = this.ДатаНачалаЭксплуатации;
            this.ДатаНачалаЭксплуатации.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СотрудникПолучатель_vmoДопДанные
            // 
            this.СотрудникПолучатель_vmoДопДанные.Caption = "СотрудникПолучатель";
            this.СотрудникПолучатель_vmoДопДанные.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.СотрудникПолучатель_vmoДопДанные.Name = "СотрудникПолучатель";
            this.СотрудникПолучатель_vmoДопДанные.NSGType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПолучатель_vmoДопДанные.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Сотрудники);
            this.СотрудникПолучатель_vmoДопДанные.SearchCondition.OwnerComponent = this.СотрудникПолучатель_vmoДопДанные;
            this.СотрудникПолучатель_vmoДопДанные.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПФПеремещениеСпецодеждыФорма
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТабличныеДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsОсновные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТабличныеДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsТаблицаАмортизации)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаАмортизации)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdsДопДанные)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДопДанные)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.DateTime ДатаНачалаЭксплуатации;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String НомерДокумента;
        protected NsgColumnDescriptor.DateTime ДатаДокумента;
        protected NsgColumnDescriptor.String Индекс;
        protected NsgColumnDescriptor.MultipleObject ДокументОснование;
        protected NsgColumnDescriptor.String Комментарий;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected _SystemTables.УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица.ColumnDescriptor Таблица;
        protected NsgColumnDescriptor.MultipleObject Получатель;
        protected NsgColumnDescriptor.MultipleObject Отправитель;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoТабличныеДанные;
        protected УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor Комплект_vmoТабличныеДанные;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsОсновные;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsТабличныеДанные;
        protected Учет.Размеры.ColumnDescriptor Размер_vmoТабличныеДанные;
        protected NsgColumnDescriptor.Int64 Количество_vmoТабличныеДанные;
        protected NsgColumnDescriptor.Decimal Цена_vmoТабличныеДанные;
        protected NsgColumnDescriptor.Decimal Стоимость_vmoТабличныеДанные;
        protected NsgColumnDescriptor.String НазваниеПериода_vmoТабличныеДанные;
        protected NsgColumnDescriptor.Decimal СтоимостьВПериоде_vmoТабличныеДанные;
        protected NsgColumnDescriptor.String НазваниеПериода_vmoТаблицаАмортизации;
        protected NsgColumnDescriptor.String СуммаЗаПериод_vmoТаблицаАмортизации;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoТаблицаАмортизации;
        protected Учет.Размеры.ColumnDescriptor Размер_vmoТаблицаАмортизации;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsТаблицаАмортизации;
        protected NsgColumnDescriptor.String НомерПериода_vmoТаблицаАмортизации;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource4;
        protected NsgSoft.ReportBuilder.NsgReportDataSource rdsДопДанные;
        protected Мониторинг.Контрагенты.ColumnDescriptor Фирма_vmoДопДанные;
        private Мониторинг.Сотрудники.ColumnDescriptor ПредставительФирмы_vmoДопДанные;
        private NsgVisualMultipleObject vmoТаблицаАмортизации;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgVisualMultipleObject vmoТабличныеДанные;
        protected Мониторинг.Сотрудники.ColumnDescriptor СотрудникПолучатель_vmoДопДанные;
        private NsgVisualMultipleObject vmoДопДанные;
    }
}