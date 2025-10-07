using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ФизЛицаФормаСписка:NsgSoft.Forms.NsgMultipleObjectBaseForm
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
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
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
            this.Фамилия = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Отчество = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерТелефона = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Должность = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.Имя = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Статус = new TechControl.Метаданные.Мониторинг.СтатусСотрудника.ColumnDescriptor();
            this.ИдентификаторСтрока = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.IDСотрудника = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Размер = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.АккаунтПользователя = new TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor();
            this.ТабельныйНомер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаРождения = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаПриемаНаРаботу = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДатаУвольнения = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ТаблицаРазмеров = new TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаРазмеров.ColumnDescriptor();
            this.ОбъектВыдачиСпецодежды = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ОсновнойОбъект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.ЗагрузочныйИдентификатор = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДокументКонтроляСпецодежды = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды.ColumnDescriptor();
            this.Подразделение = new TechControl.Метаданные.Мониторинг.Подразделения.ColumnDescriptor();
            this.ТаблицаСовмещаемыхДолжностей = new TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.ColumnDescriptor();
            this.КартинкаПодпись = new TechControl.Метаданные.Мониторинг.Картинки.ColumnDescriptor();
            this.ФИО = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ФИОРодительныйПадеж = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ТекущийОбъект = new TechControl.Метаданные.Мониторинг.Объекты.ColumnDescriptor();
            this.Родитель = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Фамилия);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Отчество);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерТелефона);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Должность);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Имя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Статус);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторСтрока);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.IDСотрудника);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Размер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.АккаунтПользователя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТабельныйНомер);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаРождения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаПриемаНаРаботу);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДатаУвольнения);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаРазмеров);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОбъектВыдачиСпецодежды);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ОсновнойОбъект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЗагрузочныйИдентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ДокументКонтроляСпецодежды);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Подразделение);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТаблицаСовмещаемыхДолжностей);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.КартинкаПодпись);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ФИО);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ФИОРодительныйПадеж);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТекущийОбъект);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Мониторинг.ФизЛица";
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
            nsgIGridColumn1.Name = "Код";
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
            nsgIGridColumn2.Name = "Наименование";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Visible = false;
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
            nsgIGridColumn3.Name = "СостояниеДокумента";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Visible = false;
            nsgIGridColumn3.Width = 100;
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
            nsgIGridColumn4.Name = "Фамилия";
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
            nsgIGridColumn5.ImportedFromVMO = false;
            nsgIGridColumn5.InitiateRowEdit = true;
            nsgIGridColumn5.Name = "Отчество";
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
        "Visible"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.ImportedFromVMO = false;
            nsgIGridColumn6.InitiateRowEdit = true;
            nsgIGridColumn6.Name = "НомерТелефона";
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
        "Visible"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.ImportedFromVMO = false;
            nsgIGridColumn7.InitiateRowEdit = true;
            nsgIGridColumn7.Name = "Должность";
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
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.ImportedFromVMO = false;
            nsgIGridColumn8.InitiateRowEdit = true;
            nsgIGridColumn8.Name = "Имя";
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
            nsgIGridColumn9.ImportedFromVMO = false;
            nsgIGridColumn9.InitiateRowEdit = true;
            nsgIGridColumn9.Name = "Статус";
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
            nsgIGridColumn10.ImportedFromVMO = false;
            nsgIGridColumn10.InitiateRowEdit = true;
            nsgIGridColumn10.Name = "ИдентификаторСтрока";
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
            nsgIGridColumn11.ImportedFromVMO = false;
            nsgIGridColumn11.InitiateRowEdit = true;
            nsgIGridColumn11.Name = "IDСотрудника";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn11.UseAsHeaderImage = false;
            nsgIGridColumn11.Width = 100;
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
            nsgIGridColumn12.Name = "Размер";
            nsgIGridColumn12.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn12.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn13.Name = "АккаунтПользователя";
            nsgIGridColumn13.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn13.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn13.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn13.UseAsHeaderImage = false;
            nsgIGridColumn13.Visible = false;
            nsgIGridColumn13.Width = 100;
            nsgIGridColumn14.AllowFilter = true;
            nsgIGridColumn14.AllowGroupSelect = false;
            nsgIGridColumn14.AllowResize = true;
            nsgIGridColumn14.AutoResize = true;
            nsgIGridColumn14.Caption = "";
            nsgIGridColumn14.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn14.DateFormat = null;
            nsgIGridColumn14.ImportedFromVMO = false;
            nsgIGridColumn14.InitiateRowEdit = true;
            nsgIGridColumn14.Name = "ТабельныйНомер";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn14.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn14.UseAsHeaderImage = false;
            nsgIGridColumn14.Visible = false;
            nsgIGridColumn14.Width = 100;
            nsgIGridColumn15.AllowFilter = true;
            nsgIGridColumn15.AllowGroupSelect = false;
            nsgIGridColumn15.AllowResize = true;
            nsgIGridColumn15.AutoResize = true;
            nsgIGridColumn15.Caption = "";
            nsgIGridColumn15.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn15.DateFormat = null;
            nsgIGridColumn15.ImportedFromVMO = false;
            nsgIGridColumn15.InitiateRowEdit = true;
            nsgIGridColumn15.Name = "ДатаРождения";
            nsgIGridColumn15.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn15.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn15.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn15.UseAsHeaderImage = false;
            nsgIGridColumn15.Visible = false;
            nsgIGridColumn15.Width = 100;
            nsgIGridColumn16.AllowFilter = true;
            nsgIGridColumn16.AllowGroupSelect = false;
            nsgIGridColumn16.AllowResize = true;
            nsgIGridColumn16.AutoResize = true;
            nsgIGridColumn16.Caption = "";
            nsgIGridColumn16.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.ImportedFromVMO = false;
            nsgIGridColumn16.InitiateRowEdit = true;
            nsgIGridColumn16.Name = "ДатаПриемаНаРаботу";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn16.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn16.UseAsHeaderImage = false;
            nsgIGridColumn16.Visible = false;
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
            nsgIGridColumn17.Name = "ДатаУвольнения";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn17.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn17.UseAsHeaderImage = false;
            nsgIGridColumn17.Visible = false;
            nsgIGridColumn17.Width = 100;
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
            nsgIGridColumn18.Name = "ОбъектВыдачиСпецодежды";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid1.Columns.Collection;
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
            nsgIGridColumn19.Name = "ОсновнойОбъект";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn19.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn19.UseAsHeaderImage = false;
            nsgIGridColumn19.Visible = false;
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
            nsgIGridColumn20.Name = "ЗагрузочныйИдентификатор";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn20.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn20.UseAsHeaderImage = false;
            nsgIGridColumn20.Visible = false;
            nsgIGridColumn20.Width = 100;
            nsgIGridColumn21.AllowFilter = true;
            nsgIGridColumn21.AllowGroupSelect = false;
            nsgIGridColumn21.AllowResize = true;
            nsgIGridColumn21.AutoResize = true;
            nsgIGridColumn21.Caption = "";
            nsgIGridColumn21.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn21.DateFormat = null;
            nsgIGridColumn21.ImportedFromVMO = false;
            nsgIGridColumn21.InitiateRowEdit = true;
            nsgIGridColumn21.Name = "ДокументКонтроляСпецодежды";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Visible = false;
            nsgIGridColumn21.Width = 100;
            nsgIGridColumn22.AllowFilter = true;
            nsgIGridColumn22.AllowGroupSelect = false;
            nsgIGridColumn22.AllowResize = true;
            nsgIGridColumn22.AutoResize = true;
            nsgIGridColumn22.Caption = "";
            nsgIGridColumn22.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn22.DateFormat = null;
            nsgIGridColumn22.ImportedFromVMO = false;
            nsgIGridColumn22.InitiateRowEdit = true;
            nsgIGridColumn22.Name = "Подразделение";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn22.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn22.UseAsHeaderImage = false;
            nsgIGridColumn22.Visible = false;
            nsgIGridColumn22.Width = 100;
            nsgIGridColumn23.AllowFilter = true;
            nsgIGridColumn23.AllowGroupSelect = false;
            nsgIGridColumn23.AllowResize = true;
            nsgIGridColumn23.AutoResize = true;
            nsgIGridColumn23.Caption = "";
            nsgIGridColumn23.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn23.DateFormat = null;
            nsgIGridColumn23.ImportedFromVMO = false;
            nsgIGridColumn23.InitiateRowEdit = true;
            nsgIGridColumn23.Name = "КартинкаПодпись";
            nsgIGridColumn23.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn23.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn23.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn23.UseAsHeaderImage = false;
            nsgIGridColumn23.Visible = false;
            nsgIGridColumn23.Width = 100;
            nsgIGridColumn24.AllowFilter = true;
            nsgIGridColumn24.AllowGroupSelect = false;
            nsgIGridColumn24.AllowResize = true;
            nsgIGridColumn24.AutoResize = true;
            nsgIGridColumn24.Caption = "";
            nsgIGridColumn24.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn24.DateFormat = null;
            nsgIGridColumn24.ImportedFromVMO = false;
            nsgIGridColumn24.InitiateRowEdit = true;
            nsgIGridColumn24.Name = "ФИО";
            nsgIGridColumn24.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn24.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn24.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn24.UseAsHeaderImage = false;
            nsgIGridColumn24.Visible = false;
            nsgIGridColumn24.Width = 100;
            nsgIGridColumn25.AllowFilter = true;
            nsgIGridColumn25.AllowGroupSelect = false;
            nsgIGridColumn25.AllowResize = true;
            nsgIGridColumn25.AutoResize = true;
            nsgIGridColumn25.Caption = "";
            nsgIGridColumn25.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn25.DateFormat = null;
            nsgIGridColumn25.ImportedFromVMO = false;
            nsgIGridColumn25.InitiateRowEdit = true;
            nsgIGridColumn25.Name = "ФИОРодительныйПадеж";
            nsgIGridColumn25.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn25.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn25.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn25.UseAsHeaderImage = false;
            nsgIGridColumn25.Visible = false;
            nsgIGridColumn25.Width = 100;
            nsgIGridColumn26.AllowFilter = true;
            nsgIGridColumn26.AllowGroupSelect = false;
            nsgIGridColumn26.AllowResize = true;
            nsgIGridColumn26.AutoResize = true;
            nsgIGridColumn26.Caption = "";
            nsgIGridColumn26.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn26.DateFormat = null;
            nsgIGridColumn26.ImportedFromVMO = false;
            nsgIGridColumn26.InitiateRowEdit = true;
            nsgIGridColumn26.Name = "ТекущийОбъект";
            nsgIGridColumn26.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn26.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn26.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn26.UseAsHeaderImage = false;
            nsgIGridColumn26.Visible = false;
            nsgIGridColumn26.Width = 100;
            nsgIGridColumn27.AllowFilter = true;
            nsgIGridColumn27.AllowGroupSelect = false;
            nsgIGridColumn27.AllowResize = true;
            nsgIGridColumn27.AutoResize = true;
            nsgIGridColumn27.Caption = "";
            nsgIGridColumn27.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn27.DateFormat = null;
            nsgIGridColumn27.ImportedFromVMO = false;
            nsgIGridColumn27.InitiateRowEdit = true;
            nsgIGridColumn27.Name = "Родитель";
            nsgIGridColumn27.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn27.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn27.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn27.UseAsHeaderImage = false;
            nsgIGridColumn27.Visible = false;
            nsgIGridColumn27.Width = 100;
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
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(6, 12);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(655, 467);
            this.nsgIGrid1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgIGrid1.TabIndex = 9;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // Идентификатор
            // 
            this.Идентификатор.AutoGenerated = true;
            this.Идентификатор.Caption = "Идентификатор";
            this.Идентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.Автоинкремент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.ЭтоГруппа.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.ИдентификаторРодителя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.Уровень.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.ПрефиксКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.НомерКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.Код.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.Наименование.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
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
            this.СостояниеДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.СостояниеДокумента.Name = "СостояниеДокумента";
            this.СостояниеДокумента.NSGType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.PropertyType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.SearchCondition.OwnerComponent = this.СостояниеДокумента;
            this.СостояниеДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Фамилия
            // 
            this.Фамилия.AutoGenerated = true;
            this.Фамилия.Caption = "Фамилия";
            this.Фамилия.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Фамилия.PropertyType = typeof(string);
            this.Фамилия.SearchCondition.OwnerComponent = this.Фамилия;
            this.Фамилия.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Отчество
            // 
            this.Отчество.AutoGenerated = true;
            this.Отчество.Caption = "Отчество";
            this.Отчество.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Отчество.Name = "Отчество";
            this.Отчество.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Отчество.PropertyType = typeof(string);
            this.Отчество.SearchCondition.OwnerComponent = this.Отчество;
            this.Отчество.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерТелефона
            // 
            this.НомерТелефона.AutoGenerated = true;
            this.НомерТелефона.Caption = "НомерТелефона";
            this.НомерТелефона.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.НомерТелефона.Name = "НомерТелефона";
            this.НомерТелефона.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.НомерТелефона.PropertyType = typeof(string);
            this.НомерТелефона.SearchCondition.OwnerComponent = this.НомерТелефона;
            this.НомерТелефона.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Должность
            // 
            this.Должность.AutoGenerated = true;
            this.Должность.Caption = "Должность";
            this.Должность.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Должность.Name = "Должность";
            this.Должность.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность.SearchCondition.OwnerComponent = this.Должность;
            this.Должность.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Имя
            // 
            this.Имя.AutoGenerated = true;
            this.Имя.Caption = "Имя";
            this.Имя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Имя.Name = "Имя";
            this.Имя.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Имя.PropertyType = typeof(string);
            this.Имя.SearchCondition.OwnerComponent = this.Имя;
            this.Имя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Статус
            // 
            this.Статус.AutoGenerated = true;
            this.Статус.Caption = "Статус";
            this.Статус.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Статус.Name = "Статус";
            this.Статус.NSGType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.Статус.PropertyType = typeof(TechControl.Метаданные.Мониторинг.СтатусСотрудника);
            this.Статус.SearchCondition.OwnerComponent = this.Статус;
            this.Статус.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ИдентификаторСтрока
            // 
            this.ИдентификаторСтрока.AutoGenerated = true;
            this.ИдентификаторСтрока.Caption = "ИдентификаторСтрока";
            this.ИдентификаторСтрока.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ИдентификаторСтрока.Name = "ИдентификаторСтрока";
            this.ИдентификаторСтрока.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ИдентификаторСтрока.PropertyType = typeof(string);
            this.ИдентификаторСтрока.SearchCondition.OwnerComponent = this.ИдентификаторСтрока;
            this.ИдентификаторСтрока.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // IDСотрудника
            // 
            this.IDСотрудника.AutoGenerated = true;
            this.IDСотрудника.CalcTotal = false;
            this.IDСотрудника.Caption = "IDСотрудника";
            this.IDСотрудника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.IDСотрудника.Name = "IDСотрудника";
            this.IDСотрудника.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.IDСотрудника.PropertyType = typeof(long);
            this.IDСотрудника.SearchCondition.OwnerComponent = this.IDСотрудника;
            this.IDСотрудника.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер
            // 
            this.Размер.AutoGenerated = true;
            this.Размер.Caption = "Размер";
            this.Размер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Размер.Name = "Размер";
            this.Размер.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер.SearchCondition.OwnerComponent = this.Размер;
            this.Размер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // АккаунтПользователя
            // 
            this.АккаунтПользователя.AutoGenerated = true;
            this.АккаунтПользователя.Caption = "АккаунтПользователя";
            this.АккаунтПользователя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.АккаунтПользователя.Name = "АккаунтПользователя";
            this.АккаунтПользователя.NSGType = typeof(TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя);
            this.АккаунтПользователя.PropertyType = typeof(TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя);
            this.АккаунтПользователя.SearchCondition.OwnerComponent = this.АккаунтПользователя;
            this.АккаунтПользователя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТабельныйНомер
            // 
            this.ТабельныйНомер.AutoGenerated = true;
            this.ТабельныйНомер.Caption = "ТабельныйНомер";
            this.ТабельныйНомер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ТабельныйНомер.Name = "ТабельныйНомер";
            this.ТабельныйНомер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ТабельныйНомер.PropertyType = typeof(string);
            this.ТабельныйНомер.SearchCondition.OwnerComponent = this.ТабельныйНомер;
            this.ТабельныйНомер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаРождения
            // 
            this.ДатаРождения.AutoGenerated = true;
            this.ДатаРождения.Caption = "ДатаРождения";
            this.ДатаРождения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ДатаРождения.Name = "ДатаРождения";
            this.ДатаРождения.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаРождения.PropertyType = typeof(System.DateTime);
            this.ДатаРождения.SearchCondition.OwnerComponent = this.ДатаРождения;
            this.ДатаРождения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаПриемаНаРаботу
            // 
            this.ДатаПриемаНаРаботу.AutoGenerated = true;
            this.ДатаПриемаНаРаботу.Caption = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ДатаПриемаНаРаботу.Name = "ДатаПриемаНаРаботу";
            this.ДатаПриемаНаРаботу.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаПриемаНаРаботу.PropertyType = typeof(System.DateTime);
            this.ДатаПриемаНаРаботу.SearchCondition.OwnerComponent = this.ДатаПриемаНаРаботу;
            this.ДатаПриемаНаРаботу.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаУвольнения
            // 
            this.ДатаУвольнения.AutoGenerated = true;
            this.ДатаУвольнения.Caption = "ДатаУвольнения";
            this.ДатаУвольнения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ДатаУвольнения.Name = "ДатаУвольнения";
            this.ДатаУвольнения.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаУвольнения.PropertyType = typeof(System.DateTime);
            this.ДатаУвольнения.SearchCondition.OwnerComponent = this.ДатаУвольнения;
            this.ДатаУвольнения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаРазмеров
            // 
            this.ТаблицаРазмеров.AutoGenerated = true;
            this.ТаблицаРазмеров.Caption = "ТаблицаРазмеров";
            this.ТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ТаблицаРазмеров.Name = "ТаблицаРазмеров";
            this.ТаблицаРазмеров.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаРазмеров);
            this.ТаблицаРазмеров.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаРазмеров);
            this.ТаблицаРазмеров.SearchCondition.OwnerComponent = this.ТаблицаРазмеров;
            this.ТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаРазмеров.Visible = false;
            // 
            // ОбъектВыдачиСпецодежды
            // 
            this.ОбъектВыдачиСпецодежды.AutoGenerated = true;
            this.ОбъектВыдачиСпецодежды.Caption = "ОбъектВыдачиСпецодежды";
            this.ОбъектВыдачиСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ОбъектВыдачиСпецодежды.Name = "ОбъектВыдачиСпецодежды";
            this.ОбъектВыдачиСпецодежды.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачиСпецодежды.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОбъектВыдачиСпецодежды.SearchCondition.OwnerComponent = this.ОбъектВыдачиСпецодежды;
            this.ОбъектВыдачиСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОсновнойОбъект
            // 
            this.ОсновнойОбъект.AutoGenerated = true;
            this.ОсновнойОбъект.Caption = "ОсновнойОбъект";
            this.ОсновнойОбъект.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ОсновнойОбъект.Name = "ОсновнойОбъект";
            this.ОсновнойОбъект.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ОсновнойОбъект.SearchCondition.OwnerComponent = this.ОсновнойОбъект;
            this.ОсновнойОбъект.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ЗагрузочныйИдентификатор
            // 
            this.ЗагрузочныйИдентификатор.AutoGenerated = true;
            this.ЗагрузочныйИдентификатор.Caption = "ЗагрузочныйИдентификатор";
            this.ЗагрузочныйИдентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ЗагрузочныйИдентификатор.Name = "ЗагрузочныйИдентификатор";
            this.ЗагрузочныйИдентификатор.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ЗагрузочныйИдентификатор.PropertyType = typeof(string);
            this.ЗагрузочныйИдентификатор.SearchCondition.OwnerComponent = this.ЗагрузочныйИдентификатор;
            this.ЗагрузочныйИдентификатор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДокументКонтроляСпецодежды
            // 
            this.ДокументКонтроляСпецодежды.AutoGenerated = true;
            this.ДокументКонтроляСпецодежды.Caption = "ДокументКонтроляСпецодежды";
            this.ДокументКонтроляСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ДокументКонтроляСпецодежды.Name = "ДокументКонтроляСпецодежды";
            this.ДокументКонтроляСпецодежды.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды);
            this.ДокументКонтроляСпецодежды.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды);
            this.ДокументКонтроляСпецодежды.SearchCondition.OwnerComponent = this.ДокументКонтроляСпецодежды;
            this.ДокументКонтроляСпецодежды.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Подразделение
            // 
            this.Подразделение.AutoGenerated = true;
            this.Подразделение.Caption = "Подразделение";
            this.Подразделение.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Подразделение.Name = "Подразделение";
            this.Подразделение.NSGType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Подразделения);
            this.Подразделение.SearchCondition.OwnerComponent = this.Подразделение;
            this.Подразделение.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТаблицаСовмещаемыхДолжностей
            // 
            this.ТаблицаСовмещаемыхДолжностей.AutoGenerated = true;
            this.ТаблицаСовмещаемыхДолжностей.Caption = "ТаблицаСовмещаемыхДолжностей";
            this.ТаблицаСовмещаемыхДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ТаблицаСовмещаемыхДолжностей.Name = "ТаблицаСовмещаемыхДолжностей";
            this.ТаблицаСовмещаемыхДолжностей.NSGType = typeof(TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей);
            this.ТаблицаСовмещаемыхДолжностей.PropertyType = typeof(TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей);
            this.ТаблицаСовмещаемыхДолжностей.SearchCondition.OwnerComponent = this.ТаблицаСовмещаемыхДолжностей;
            this.ТаблицаСовмещаемыхДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ТаблицаСовмещаемыхДолжностей.Visible = false;
            // 
            // КартинкаПодпись
            // 
            this.КартинкаПодпись.AutoGenerated = true;
            this.КартинкаПодпись.Caption = "КартинкаПодпись";
            this.КартинкаПодпись.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.КартинкаПодпись.Name = "КартинкаПодпись";
            this.КартинкаПодпись.NSGType = typeof(TechControl.Метаданные.Мониторинг.Картинки);
            this.КартинкаПодпись.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Картинки);
            this.КартинкаПодпись.SearchCondition.OwnerComponent = this.КартинкаПодпись;
            this.КартинкаПодпись.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ФИО
            // 
            this.ФИО.AutoGenerated = true;
            this.ФИО.Caption = "ФИО";
            this.ФИО.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ФИО.Name = "ФИО";
            this.ФИО.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ФИО.PropertyType = typeof(string);
            this.ФИО.SearchCondition.OwnerComponent = this.ФИО;
            this.ФИО.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ФИОРодительныйПадеж
            // 
            this.ФИОРодительныйПадеж.AutoGenerated = true;
            this.ФИОРодительныйПадеж.Caption = "ФИОРодительныйПадеж";
            this.ФИОРодительныйПадеж.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ФИОРодительныйПадеж.Name = "ФИОРодительныйПадеж";
            this.ФИОРодительныйПадеж.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ФИОРодительныйПадеж.PropertyType = typeof(string);
            this.ФИОРодительныйПадеж.SearchCondition.OwnerComponent = this.ФИОРодительныйПадеж;
            this.ФИОРодительныйПадеж.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТекущийОбъект
            // 
            this.ТекущийОбъект.AutoGenerated = true;
            this.ТекущийОбъект.Caption = "ТекущийОбъект";
            this.ТекущийОбъект.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.ТекущийОбъект.Name = "ТекущийОбъект";
            this.ТекущийОбъект.NSGType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ТекущийОбъект.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Объекты);
            this.ТекущийОбъект.SearchCondition.OwnerComponent = this.ТекущийОбъект;
            this.ТекущийОбъект.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectBaseForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ФизЛицаФормаСписка
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.nsgIGrid1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgMultipleObjectBaseForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "Форма объекта";
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected ФизЛица.ColumnDescriptor Родитель;
        protected NsgIGrid nsgIGrid1;
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
        protected NsgColumnDescriptor.String Фамилия;
        protected NsgColumnDescriptor.String Отчество;
        protected NsgColumnDescriptor.String НомерТелефона;
        protected Должности.ColumnDescriptor Должность;
        protected NsgColumnDescriptor.String Имя;
        protected СтатусСотрудника.ColumnDescriptor Статус;
        protected NsgColumnDescriptor.String ИдентификаторСтрока;
        protected NsgColumnDescriptor.Int64 IDСотрудника;
        protected Учет.Размеры.ColumnDescriptor Размер;
        protected СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        protected NsgColumnDescriptor.String ТабельныйНомер;
        protected NsgColumnDescriptor.DateTime ДатаРождения;
        protected NsgColumnDescriptor.DateTime ДатаПриемаНаРаботу;
        protected NsgColumnDescriptor.DateTime ДатаУвольнения;
        protected _SystemTables.МониторингФизЛицаТаблицаРазмеров.ColumnDescriptor ТаблицаРазмеров;
        protected Объекты.ColumnDescriptor ОбъектВыдачиСпецодежды;
        protected Объекты.ColumnDescriptor ОсновнойОбъект;
        protected NsgColumnDescriptor.String ЗагрузочныйИдентификатор;
        protected УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды.ColumnDescriptor ДокументКонтроляСпецодежды;
        protected Подразделения.ColumnDescriptor Подразделение;
        protected _SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.ColumnDescriptor ТаблицаСовмещаемыхДолжностей;
        protected Картинки.ColumnDescriptor КартинкаПодпись;
        protected NsgColumnDescriptor.String ФИО;
        protected NsgColumnDescriptor.String ФИОРодительныйПадеж;
        protected Объекты.ColumnDescriptor ТекущийОбъект;
    }
}