using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{

    public partial class ФизЛицаФормаЭлемента : NsgSoft.Forms.NsgMultipleObjectElementForm
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
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding1 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor1 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor2 = new NsgSoft.DataObjects.NsgObjectDescriptor();
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
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding2 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor3 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor4 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding3 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor5 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor6 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn22 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn23 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgMasterDetailBinding nsgMasterDetailBinding4 = new NsgSoft.Forms.NsgMasterDetailBinding();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor7 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            NsgSoft.DataObjects.NsgObjectDescriptor nsgObjectDescriptor8 = new NsgSoft.DataObjects.NsgObjectDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаРазмеров = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаРазмеров = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаРазмеров = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ВидСвойствНоменклатуры = new TechControl.Метаданные.Учет.ВидСвойствНоменклатуры.ColumnDescriptor();
            this.Размер_vmoТаблицаРазмеров = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.ВидРазмернойСетки = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки.ColumnDescriptor();
            this.nsgIGrid3 = new NsgSoft.Forms.NsgIGrid();
            this.vmoМатЦенности = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoМатЦенности = new TechControl.Метаданные.Учет.Номенклатура.ColumnDescriptor();
            this.Размер_vmoМатЦенности = new TechControl.Метаданные.Учет.Размеры.ColumnDescriptor();
            this.Комплект_vmoМатЦенности = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor();
            this.Количество_vmoМатЦенности = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.nsgIGrid4 = new NsgSoft.Forms.NsgIGrid();
            this.vmoДокументы = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Владелец_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.Идентификатор_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование_vmoДокументы = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента_vmoДокументы = new TechControl.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.ВидДокумента = new TechControl.Метаданные.УчетСотрудников.ВидыДокументов.ColumnDescriptor();
            this.Серия = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.КемВыдан = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.КодПодразделения = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Номер = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.ДатаВыдачи = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.ДействуетДо = new NsgSoft.Forms.NsgColumnDescriptor.DateTime();
            this.СсылкаНаДокумент = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Родитель_vmoДокументы = new TechControl.Метаданные.УчетСотрудников.ДокументыФизЛиц.ColumnDescriptor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            this.nsgInput4 = new NsgSoft.Forms.NsgInput();
            this.nsgInput5 = new NsgSoft.Forms.NsgInput();
            this.nsgInput6 = new NsgSoft.Forms.NsgInput();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpОсновные = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nsgInput26 = new NsgSoft.Forms.NsgInput();
            this.label26 = new System.Windows.Forms.Label();
            this.nsgInput25 = new NsgSoft.Forms.NsgInput();
            this.label25 = new System.Windows.Forms.Label();
            this.nsgInput24 = new NsgSoft.Forms.NsgInput();
            this.label24 = new System.Windows.Forms.Label();
            this.nsgInput23 = new NsgSoft.Forms.NsgInput();
            this.label23 = new System.Windows.Forms.Label();
            this.gBДаты = new System.Windows.Forms.GroupBox();
            this.nsgInput22 = new NsgSoft.Forms.NsgInput();
            this.label22 = new System.Windows.Forms.Label();
            this.nsgInput21 = new NsgSoft.Forms.NsgInput();
            this.label21 = new System.Windows.Forms.Label();
            this.nsgInput20 = new NsgSoft.Forms.NsgInput();
            this.lblРождение = new System.Windows.Forms.Label();
            this.nsgInput19 = new NsgSoft.Forms.NsgInput();
            this.label20 = new System.Windows.Forms.Label();
            this.nsgInput8 = new NsgSoft.Forms.NsgInput();
            this.label8 = new System.Windows.Forms.Label();
            this.nsgInput7 = new NsgSoft.Forms.NsgInput();
            this.label7 = new System.Windows.Forms.Label();
            this.tpДокументы = new System.Windows.Forms.TabPage();
            this.tpРазмеры = new System.Windows.Forms.TabPage();
            this.tpМерки = new System.Windows.Forms.TabPage();
            this.nbЗаполнитьТаблицуРазмеров = new NsgSoft.Design.NsgButton();
            this.label19 = new System.Windows.Forms.Label();
            this.nsgInput18 = new NsgSoft.Forms.NsgInput();
            this.vmoМерки = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.nsgInput17 = new NsgSoft.Forms.NsgInput();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nsgInput16 = new NsgSoft.Forms.NsgInput();
            this.label15 = new System.Windows.Forms.Label();
            this.nsgInput15 = new NsgSoft.Forms.NsgInput();
            this.label14 = new System.Windows.Forms.Label();
            this.nsgInput14 = new NsgSoft.Forms.NsgInput();
            this.label13 = new System.Windows.Forms.Label();
            this.nsgInput13 = new NsgSoft.Forms.NsgInput();
            this.label12 = new System.Windows.Forms.Label();
            this.nsgInput12 = new NsgSoft.Forms.NsgInput();
            this.label11 = new System.Windows.Forms.Label();
            this.nsgInput11 = new NsgSoft.Forms.NsgInput();
            this.label10 = new System.Windows.Forms.Label();
            this.nsgInput10 = new NsgSoft.Forms.NsgInput();
            this.label9 = new System.Windows.Forms.Label();
            this.nsgInput9 = new NsgSoft.Forms.NsgInput();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpСовмещаемыеДолжности = new System.Windows.Forms.TabPage();
            this.nsgIGrid2 = new NsgSoft.Forms.NsgIGrid();
            this.vmoТаблицаДолжностей = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Идентификатор_vmoТаблицаДолжностей = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoТаблицаДолжностей = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Владелец_vmoТаблицаДолжностей = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.НомерСтроки_vmoТаблицаДолжностей = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Должность_vmoТаблицаДолжностей = new TechControl.Метаданные.Мониторинг.Должности.ColumnDescriptor();
            this.tpМатЦенности = new System.Windows.Forms.TabPage();
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
            this.Родитель = new TechControl.Метаданные.Мониторинг.ФизЛица.ColumnDescriptor();
            this.Владелец_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.MultipleObject();
            this.Идентификатор_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование_vmoМерки = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента_vmoМерки = new TechControl.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.ОбхватТалии = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Рост = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватБедер = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.БоковаяДлинаБрюк = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДлинаБрюкПоВнутреннемуШву = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватШеи = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДлинаРукава = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ДлинаСтопы = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватГруди = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ОбхватГоловы = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Родитель_vmoМерки = new TechControl.Метаданные.УчетСпецодеждыИСИЗ.Мерки.ColumnDescriptor();
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРазмеров)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoМатЦенности)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДокументы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpОсновные.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput23)).BeginInit();
            this.gBДаты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).BeginInit();
            this.tpДокументы.SuspendLayout();
            this.tpРазмеры.SuspendLayout();
            this.tpМерки.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьТаблицуРазмеров)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoМерки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpСовмещаемыеДолжности.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаДолжностей)).BeginInit();
            this.tpМатЦенности.SuspendLayout();
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
            this.nsgEdit.Location = new System.Drawing.Point(978, 1);
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
            this.nsgClose.Location = new System.Drawing.Point(1094, 1);
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
            this.nsgToolStrip2.Size = new System.Drawing.Size(1173, 28);
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
            this.nsgAll.Location = new System.Drawing.Point(708, 1);
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
            this.nsgHandling.Location = new System.Drawing.Point(803, 1);
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
            this.nsgSave.Location = new System.Drawing.Point(887, 1);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 537);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1173, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButtonBasic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButtonBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButtonBasic.Container = this.documentButton;
            this.nsgButtonBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgButtonBasic.Location = new System.Drawing.Point(708, 1);
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
            this.documentButton.ButtonImage = null;
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
            this.printButton.ButtonImage = null;
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
            this.Comment.FullName = "Мониторинг.ФизЛица.Идентификатор";
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
            this.Comment.Size = new System.Drawing.Size(1173, 23);
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
            nsgIGridColumn2.Name = "ВидСвойствНоменклатуры";
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
            nsgIGridColumn3.Name = "Размер";
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
            nsgIGridColumn4.Name = "ВидРазмернойСетки";
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
            this.nsgIGrid1.Location = new System.Drawing.Point(7, 7);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(1144, 489);
            this.nsgIGrid1.SourceObject = this.vmoТаблицаРазмеров;
            this.nsgIGrid1.TabIndex = 0;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid1.CellRequestEdit += new NsgSoft.Forms.NsgIGrid.NsgIGridCellEventHandler(this.nsgIGrid1_CellRequestEdit);
            this.vmoТаблицаРазмеров.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor2.ConfigurationName = "TechControl";
            this.vmoТаблицаРазмеров.MetaDataName = "Метаданные";
            this.vmoТаблицаРазмеров.FullName = "_SystemTables.МониторингФизЛицаТаблицаРазмеров.Владелец";
            // 
            // vmoТаблицаРазмеров
            // 
            nsgObjectDescriptor1.ConfigurationName = "TechControl";
            nsgObjectDescriptor1.FullName = "_SystemTables.МониторингФизЛицаТаблицаРазмеров.Владелец";
            nsgObjectDescriptor1.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.DetailField = nsgObjectDescriptor1;
            nsgObjectDescriptor2.FullName = "Мониторинг.ФизЛица.ТаблицаРазмеров";
            nsgObjectDescriptor2.MetaDataName = "Метаданные";
            nsgMasterDetailBinding1.MasterField = nsgObjectDescriptor2;
            nsgMasterDetailBinding1.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Идентификатор_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Владелец);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.НомерСтроки);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.ВидСвойствНоменклатуры);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.Размер_vmoТаблицаРазмеров);
            this.vmoТаблицаРазмеров.Columns.Collection.Add(this.ВидРазмернойСетки);
            this.vmoТаблицаРазмеров.IsActive = true;
            this.vmoТаблицаРазмеров.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаРазмеров.Binding = nsgMasterDetailBinding1;
            // 
            // Идентификатор_vmoТаблицаРазмеров
            // 
            this.Идентификатор_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаРазмеров.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаРазмеров.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаРазмеров.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаРазмеров.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаРазмеров;
            this.Идентификатор_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаРазмеров.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаРазмеров
            // 
            this.Автоинкремент_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаРазмеров.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаРазмеров.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаРазмеров.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаРазмеров.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаРазмеров.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаРазмеров;
            this.Автоинкремент_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаРазмеров.Visible = false;
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
            // ВидСвойствНоменклатуры
            // 
            this.ВидСвойствНоменклатуры.AutoGenerated = true;
            this.ВидСвойствНоменклатуры.Caption = "ВидСвойствНоменклатуры";
            this.ВидСвойствНоменклатуры.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВидСвойствНоменклатуры.Name = "ВидСвойствНоменклатуры";
            this.ВидСвойствНоменклатуры.NSGType = typeof(TechControl.Метаданные.Учет.ВидСвойствНоменклатуры);
            this.ВидСвойствНоменклатуры.PropertyType = typeof(TechControl.Метаданные.Учет.ВидСвойствНоменклатуры);
            this.ВидСвойствНоменклатуры.SearchCondition.OwnerComponent = this.ВидСвойствНоменклатуры;
            this.ВидСвойствНоменклатуры.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_vmoТаблицаРазмеров
            // 
            this.Размер_vmoТаблицаРазмеров.AutoGenerated = true;
            this.Размер_vmoТаблицаРазмеров.Caption = "Размер";
            this.Размер_vmoТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Размер_vmoТаблицаРазмеров.Name = "Размер";
            this.Размер_vmoТаблицаРазмеров.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаРазмеров.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoТаблицаРазмеров.SearchCondition.OwnerComponent = this.Размер_vmoТаблицаРазмеров;
            this.Размер_vmoТаблицаРазмеров.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВидРазмернойСетки
            // 
            this.ВидРазмернойСетки.AutoGenerated = true;
            this.ВидРазмернойСетки.Caption = "ВидРазмернойСетки";
            this.ВидРазмернойСетки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВидРазмернойСетки.Name = "ВидРазмернойСетки";
            this.ВидРазмернойСетки.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки);
            this.ВидРазмернойСетки.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки);
            this.ВидРазмернойСетки.SearchCondition.OwnerComponent = this.ВидРазмернойСетки;
            this.ВидРазмернойСетки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.Name = "Номенклатура";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn6.Name = "Размер";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn7.Name = "Комплект";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid3.Columns.Collection;
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
            nsgIGridColumn8.Name = "Количество";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid3.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid3.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid3.Filter = false;
            this.nsgIGrid3.FrozenColumns = 0;
            this.nsgIGrid3.Grouping = true;
            this.nsgIGrid3.Hierarhy = true;
            this.nsgIGrid3.ImageList = null;
            this.nsgIGrid3.IsCanMultiSelect = false;
            this.nsgIGrid3.IsCanSingleSelect = false;
            this.nsgIGrid3.LineHeight = 20;
            this.nsgIGrid3.Location = new System.Drawing.Point(3, 3);
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
            this.nsgIGrid3.Size = new System.Drawing.Size(1148, 496);
            this.nsgIGrid3.SourceObject = this.vmoМатЦенности;
            this.nsgIGrid3.TabIndex = 0;
            this.nsgIGrid3.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.nsgIGrid3.GetAvailableTools += new NsgSoft.Forms.GetActionToolsEventHandler(this.nsgIGrid3_GetAvailableTools);
            // 
            // vmoМатЦенности
            // 
            this.vmoМатЦенности.Columns.Collection.Add(this.Номенклатура_vmoМатЦенности);
            this.vmoМатЦенности.Columns.Collection.Add(this.Размер_vmoМатЦенности);
            this.vmoМатЦенности.Columns.Collection.Add(this.Комплект_vmoМатЦенности);
            this.vmoМатЦенности.Columns.Collection.Add(this.Количество_vmoМатЦенности);
            this.vmoМатЦенности.IsActive = true;
            this.vmoМатЦенности.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoМатЦенности.MetaDataName = "";
            this.vmoМатЦенности.FullName = "";
            // 
            // Номенклатура_vmoМатЦенности
            // 
            this.Номенклатура_vmoМатЦенности.Caption = "Номенклатура";
            this.Номенклатура_vmoМатЦенности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Номенклатура_vmoМатЦенности.Name = "Номенклатура";
            this.Номенклатура_vmoМатЦенности.NSGType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoМатЦенности.PropertyType = typeof(TechControl.Метаданные.Учет.Номенклатура);
            this.Номенклатура_vmoМатЦенности.ReadOnly = true;
            this.Номенклатура_vmoМатЦенности.SearchCondition.OwnerComponent = this.Номенклатура_vmoМатЦенности;
            this.Номенклатура_vmoМатЦенности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Размер_vmoМатЦенности
            // 
            this.Размер_vmoМатЦенности.Caption = "Размер";
            this.Размер_vmoМатЦенности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Размер_vmoМатЦенности.Name = "Размер";
            this.Размер_vmoМатЦенности.NSGType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoМатЦенности.PropertyType = typeof(TechControl.Метаданные.Учет.Размеры);
            this.Размер_vmoМатЦенности.ReadOnly = true;
            this.Размер_vmoМатЦенности.SearchCondition.OwnerComponent = this.Размер_vmoМатЦенности;
            this.Размер_vmoМатЦенности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Комплект_vmoМатЦенности
            // 
            this.Комплект_vmoМатЦенности.Caption = "Комплект";
            this.Комплект_vmoМатЦенности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Комплект_vmoМатЦенности.Name = "Комплект";
            this.Комплект_vmoМатЦенности.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoМатЦенности.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды);
            this.Комплект_vmoМатЦенности.ReadOnly = true;
            this.Комплект_vmoМатЦенности.SearchCondition.OwnerComponent = this.Комплект_vmoМатЦенности;
            this.Комплект_vmoМатЦенности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoМатЦенности
            // 
            this.Количество_vmoМатЦенности.CalcTotal = false;
            this.Количество_vmoМатЦенности.Caption = "Количество";
            this.Количество_vmoМатЦенности.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Количество_vmoМатЦенности.Name = "Количество";
            this.Количество_vmoМатЦенности.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Количество_vmoМатЦенности.PropertyType = typeof(long);
            this.Количество_vmoМатЦенности.ReadOnly = true;
            this.Количество_vmoМатЦенности.SearchCondition.OwnerComponent = this.Количество_vmoМатЦенности;
            this.Количество_vmoМатЦенности.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid4
            // 
            this.nsgIGrid4.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid4.AllowSaveColParamsToXML = true;
            this.nsgIGrid4.AllowSaveColPositionToXML = true;
            this.nsgIGrid4.AllowSaveColWidthToXML = true;
            this.nsgIGrid4.AllowSaveSettingsToXML = true;
            this.nsgIGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid4.AutoResizeCols = true;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.InitiateRowEdit = true;
            nsgIGridColumn9.Name = "Код";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.Ascending;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Visible = false;
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
            nsgIGridColumn10.Name = "Наименование";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Visible = false;
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
            nsgIGridColumn11.Name = "СостояниеДокумента";
            nsgIGridColumn11.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn11.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn11.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn11.UseAsHeaderImage = false;
            nsgIGridColumn11.Visible = false;
            nsgIGridColumn11.Width = 100;
            nsgIGridColumn12.AllowFilter = true;
            nsgIGridColumn12.AllowGroupSelect = false;
            nsgIGridColumn12.AllowResize = true;
            nsgIGridColumn12.AutoResize = true;
            nsgIGridColumn12.Caption = "";
            nsgIGridColumn12.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn12.DateFormat = null;
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
            nsgIGridColumn13.InitiateRowEdit = true;
            nsgIGridColumn13.Name = "ВидДокумента";
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
        "Visible"};
            nsgIGridColumn14.DateFormat = null;
            nsgIGridColumn14.InitiateRowEdit = true;
            nsgIGridColumn14.Name = "Серия";
            nsgIGridColumn14.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn14.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn15.InitiateRowEdit = true;
            nsgIGridColumn15.Name = "КемВыдан";
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
        "Visible"};
            nsgIGridColumn16.DateFormat = null;
            nsgIGridColumn16.InitiateRowEdit = true;
            nsgIGridColumn16.Name = "КодПодразделения";
            nsgIGridColumn16.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn16.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn17.InitiateRowEdit = true;
            nsgIGridColumn17.Name = "Номер";
            nsgIGridColumn17.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn17.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn17.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn17.UseAsHeaderImage = false;
            nsgIGridColumn17.Width = 100;
            nsgIGridColumn18.AllowFilter = true;
            nsgIGridColumn18.AllowGroupSelect = false;
            nsgIGridColumn18.AllowResize = true;
            nsgIGridColumn18.AutoResize = true;
            nsgIGridColumn18.Caption = "";
            nsgIGridColumn18.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn18.DateFormat = null;
            nsgIGridColumn18.InitiateRowEdit = true;
            nsgIGridColumn18.Name = "ДатаВыдачи";
            nsgIGridColumn18.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn18.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn18.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn18.UseAsHeaderImage = false;
            nsgIGridColumn18.Width = 100;
            nsgIGridColumn19.AllowFilter = true;
            nsgIGridColumn19.AllowGroupSelect = false;
            nsgIGridColumn19.AllowResize = true;
            nsgIGridColumn19.AutoResize = true;
            nsgIGridColumn19.Caption = "";
            nsgIGridColumn19.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn19.DateFormat = null;
            nsgIGridColumn19.InitiateRowEdit = true;
            nsgIGridColumn19.Name = "ДействуетДо";
            nsgIGridColumn19.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn19.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn20.InitiateRowEdit = true;
            nsgIGridColumn20.Name = "СсылкаНаДокумент";
            nsgIGridColumn20.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn20.Root = this.nsgIGrid4.Columns.Collection;
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
            nsgIGridColumn21.InitiateRowEdit = true;
            nsgIGridColumn21.Name = "Родитель";
            nsgIGridColumn21.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn21.Root = this.nsgIGrid4.Columns.Collection;
            nsgIGridColumn21.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn21.UseAsHeaderImage = false;
            nsgIGridColumn21.Visible = false;
            nsgIGridColumn21.Width = 100;
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn10);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn11);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn12);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn13);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn14);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn15);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn16);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn17);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn18);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn19);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn20);
            this.nsgIGrid4.Columns.Collection.Add(nsgIGridColumn21);
            this.nsgIGrid4.Filter = false;
            this.nsgIGrid4.FrozenColumns = 0;
            this.nsgIGrid4.Grouping = true;
            this.nsgIGrid4.Hierarhy = true;
            this.nsgIGrid4.ImageList = null;
            this.nsgIGrid4.IsCanMultiSelect = false;
            this.nsgIGrid4.IsCanSingleSelect = false;
            this.nsgIGrid4.LineHeight = 20;
            this.nsgIGrid4.Location = new System.Drawing.Point(11, 3);
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
            this.nsgIGrid4.Size = new System.Drawing.Size(1140, 496);
            this.nsgIGrid4.SourceObject = this.vmoДокументы;
            this.nsgIGrid4.TabIndex = 32;
            this.nsgIGrid4.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoДокументы.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor4.ConfigurationName = "TechControl";
            this.vmoДокументы.MetaDataName = "Метаданные";
            this.vmoДокументы.FullName = "УчетСотрудников.ДокументыФизЛиц.Владелец";
            // 
            // vmoДокументы
            // 
            nsgObjectDescriptor3.ConfigurationName = "TechControl";
            nsgObjectDescriptor3.FullName = "УчетСотрудников.ДокументыФизЛиц.Владелец";
            nsgObjectDescriptor3.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.DetailField = nsgObjectDescriptor3;
            nsgObjectDescriptor4.FullName = "Мониторинг.ФизЛица.Идентификатор";
            nsgObjectDescriptor4.MetaDataName = "Метаданные";
            nsgMasterDetailBinding2.MasterField = nsgObjectDescriptor4;
            nsgMasterDetailBinding2.Type = NsgSoft.Forms.NsgBindingType.Subdictionaries;
            this.vmoДокументы.Columns.Collection.Add(this.Владелец_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.Идентификатор_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.Автоинкремент_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.ЭтоГруппа_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.ИдентификаторРодителя_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.Уровень_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.ПрефиксКода_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.НомерКода_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.Код_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.Наименование_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.СостояниеДокумента_vmoДокументы);
            this.vmoДокументы.Columns.Collection.Add(this.ВидДокумента);
            this.vmoДокументы.Columns.Collection.Add(this.Серия);
            this.vmoДокументы.Columns.Collection.Add(this.КемВыдан);
            this.vmoДокументы.Columns.Collection.Add(this.КодПодразделения);
            this.vmoДокументы.Columns.Collection.Add(this.Номер);
            this.vmoДокументы.Columns.Collection.Add(this.ДатаВыдачи);
            this.vmoДокументы.Columns.Collection.Add(this.ДействуетДо);
            this.vmoДокументы.Columns.Collection.Add(this.СсылкаНаДокумент);
            this.vmoДокументы.Columns.Collection.Add(this.Родитель_vmoДокументы);
            this.vmoДокументы.IsActive = true;
            this.vmoДокументы.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoДокументы.Binding = nsgMasterDetailBinding2;
            // 
            // Владелец_vmoДокументы
            // 
            this.Владелец_vmoДокументы.AutoGenerated = true;
            this.Владелец_vmoДокументы.Caption = "Владелец";
            this.Владелец_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoДокументы.Name = "Владелец";
            this.Владелец_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoДокументы.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoДокументы.SearchCondition.OwnerComponent = this.Владелец_vmoДокументы;
            this.Владелец_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_vmoДокументы
            // 
            this.Идентификатор_vmoДокументы.AutoGenerated = true;
            this.Идентификатор_vmoДокументы.Caption = "Идентификатор";
            this.Идентификатор_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoДокументы.Name = "Идентификатор";
            this.Идентификатор_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoДокументы.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoДокументы.SearchCondition.OwnerComponent = this.Идентификатор_vmoДокументы;
            this.Идентификатор_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoДокументы.Visible = false;
            // 
            // Автоинкремент_vmoДокументы
            // 
            this.Автоинкремент_vmoДокументы.AutoGenerated = true;
            this.Автоинкремент_vmoДокументы.CalcTotal = false;
            this.Автоинкремент_vmoДокументы.Caption = "Автоинкремент";
            this.Автоинкремент_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoДокументы.Name = "Автоинкремент";
            this.Автоинкремент_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoДокументы.PropertyType = typeof(long);
            this.Автоинкремент_vmoДокументы.SearchCondition.OwnerComponent = this.Автоинкремент_vmoДокументы;
            this.Автоинкремент_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoДокументы.Visible = false;
            // 
            // ЭтоГруппа_vmoДокументы
            // 
            this.ЭтоГруппа_vmoДокументы.AutoGenerated = true;
            this.ЭтоГруппа_vmoДокументы.Caption = "ЭтоГруппа";
            this.ЭтоГруппа_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЭтоГруппа_vmoДокументы.Name = "ЭтоГруппа";
            this.ЭтоГруппа_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа_vmoДокументы.PropertyType = typeof(bool);
            this.ЭтоГруппа_vmoДокументы.SearchCondition.OwnerComponent = this.ЭтоГруппа_vmoДокументы;
            this.ЭтоГруппа_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа_vmoДокументы.Visible = false;
            // 
            // ИдентификаторРодителя_vmoДокументы
            // 
            this.ИдентификаторРодителя_vmoДокументы.AutoGenerated = true;
            this.ИдентификаторРодителя_vmoДокументы.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторРодителя_vmoДокументы.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя_vmoДокументы.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя_vmoДокументы.SearchCondition.OwnerComponent = this.ИдентификаторРодителя_vmoДокументы;
            this.ИдентификаторРодителя_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя_vmoДокументы.Visible = false;
            // 
            // Уровень_vmoДокументы
            // 
            this.Уровень_vmoДокументы.AutoGenerated = true;
            this.Уровень_vmoДокументы.Caption = "Уровень";
            this.Уровень_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Уровень_vmoДокументы.Name = "Уровень";
            this.Уровень_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень_vmoДокументы.PropertyType = typeof(byte);
            this.Уровень_vmoДокументы.SearchCondition.OwnerComponent = this.Уровень_vmoДокументы;
            this.Уровень_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень_vmoДокументы.Visible = false;
            // 
            // ПрефиксКода_vmoДокументы
            // 
            this.ПрефиксКода_vmoДокументы.AutoGenerated = true;
            this.ПрефиксКода_vmoДокументы.Caption = "ПрефиксКода";
            this.ПрефиксКода_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПрефиксКода_vmoДокументы.Name = "ПрефиксКода";
            this.ПрефиксКода_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода_vmoДокументы.PropertyType = typeof(string);
            this.ПрефиксКода_vmoДокументы.SearchCondition.OwnerComponent = this.ПрефиксКода_vmoДокументы;
            this.ПрефиксКода_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода_vmoДокументы.Visible = false;
            // 
            // НомерКода_vmoДокументы
            // 
            this.НомерКода_vmoДокументы.AutoGenerated = true;
            this.НомерКода_vmoДокументы.CalcTotal = false;
            this.НомерКода_vmoДокументы.Caption = "НомерКода";
            this.НомерКода_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерКода_vmoДокументы.Name = "НомерКода";
            this.НомерКода_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода_vmoДокументы.PropertyType = typeof(long);
            this.НомерКода_vmoДокументы.SearchCondition.OwnerComponent = this.НомерКода_vmoДокументы;
            this.НомерКода_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода_vmoДокументы.Visible = false;
            // 
            // Код_vmoДокументы
            // 
            this.Код_vmoДокументы.AutoGenerated = true;
            this.Код_vmoДокументы.Caption = "Код";
            this.Код_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Код_vmoДокументы.Name = "Код";
            this.Код_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код_vmoДокументы.PropertyType = typeof(string);
            this.Код_vmoДокументы.SearchCondition.OwnerComponent = this.Код_vmoДокументы;
            this.Код_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_vmoДокументы
            // 
            this.Наименование_vmoДокументы.AutoGenerated = true;
            this.Наименование_vmoДокументы.Caption = "Наименование";
            this.Наименование_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Наименование_vmoДокументы.Name = "Наименование";
            this.Наименование_vmoДокументы.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_vmoДокументы.PropertyType = typeof(string);
            this.Наименование_vmoДокументы.SearchCondition.OwnerComponent = this.Наименование_vmoДокументы;
            this.Наименование_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента_vmoДокументы
            // 
            this.СостояниеДокумента_vmoДокументы.AutoGenerated = true;
            this.СостояниеДокумента_vmoДокументы.Caption = "СостояниеДокумента";
            this.СостояниеДокумента_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СостояниеДокумента_vmoДокументы.Name = "СостояниеДокумента";
            this.СостояниеДокумента_vmoДокументы.NSGType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoДокументы.PropertyType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoДокументы.SearchCondition.OwnerComponent = this.СостояниеДокумента_vmoДокументы;
            this.СостояниеДокумента_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ВидДокумента
            // 
            this.ВидДокумента.AutoGenerated = true;
            this.ВидДокумента.Caption = "ВидДокумента";
            this.ВидДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ВидДокумента.Name = "ВидДокумента";
            this.ВидДокумента.NSGType = typeof(TechControl.Метаданные.УчетСотрудников.ВидыДокументов);
            this.ВидДокумента.PropertyType = typeof(TechControl.Метаданные.УчетСотрудников.ВидыДокументов);
            this.ВидДокумента.SearchCondition.OwnerComponent = this.ВидДокумента;
            this.ВидДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Серия
            // 
            this.Серия.AutoGenerated = true;
            this.Серия.Caption = "Серия";
            this.Серия.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Серия.Name = "Серия";
            this.Серия.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Серия.PropertyType = typeof(string);
            this.Серия.SearchCondition.OwnerComponent = this.Серия;
            this.Серия.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КемВыдан
            // 
            this.КемВыдан.AutoGenerated = true;
            this.КемВыдан.Caption = "КемВыдан";
            this.КемВыдан.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КемВыдан.Name = "КемВыдан";
            this.КемВыдан.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КемВыдан.PropertyType = typeof(string);
            this.КемВыдан.SearchCondition.OwnerComponent = this.КемВыдан;
            this.КемВыдан.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КодПодразделения
            // 
            this.КодПодразделения.AutoGenerated = true;
            this.КодПодразделения.Caption = "КодПодразделения";
            this.КодПодразделения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.КодПодразделения.Name = "КодПодразделения";
            this.КодПодразделения.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.КодПодразделения.PropertyType = typeof(string);
            this.КодПодразделения.SearchCondition.OwnerComponent = this.КодПодразделения;
            this.КодПодразделения.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Номер
            // 
            this.Номер.AutoGenerated = true;
            this.Номер.Caption = "Номер";
            this.Номер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Номер.Name = "Номер";
            this.Номер.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Номер.PropertyType = typeof(string);
            this.Номер.SearchCondition.OwnerComponent = this.Номер;
            this.Номер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДатаВыдачи
            // 
            this.ДатаВыдачи.AutoGenerated = true;
            this.ДатаВыдачи.Caption = "ДатаВыдачи";
            this.ДатаВыдачи.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДатаВыдачи.Name = "ДатаВыдачи";
            this.ДатаВыдачи.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДатаВыдачи.PropertyType = typeof(System.DateTime);
            this.ДатаВыдачи.SearchCondition.OwnerComponent = this.ДатаВыдачи;
            this.ДатаВыдачи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДействуетДо
            // 
            this.ДействуетДо.AutoGenerated = true;
            this.ДействуетДо.Caption = "ДействуетДо";
            this.ДействуетДо.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДействуетДо.Name = "ДействуетДо";
            this.ДействуетДо.NSGType = typeof(NsgSoft.DataObjects.NsgDataDateTime);
            this.ДействуетДо.PropertyType = typeof(System.DateTime);
            this.ДействуетДо.SearchCondition.OwnerComponent = this.ДействуетДо;
            this.ДействуетДо.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СсылкаНаДокумент
            // 
            this.СсылкаНаДокумент.AutoGenerated = true;
            this.СсылкаНаДокумент.Caption = "СсылкаНаДокумент";
            this.СсылкаНаДокумент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СсылкаНаДокумент.Name = "СсылкаНаДокумент";
            this.СсылкаНаДокумент.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.СсылкаНаДокумент.PropertyType = typeof(string);
            this.СсылкаНаДокумент.SearchCondition.OwnerComponent = this.СсылкаНаДокумент;
            this.СсылкаНаДокумент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель_vmoДокументы
            // 
            this.Родитель_vmoДокументы.AutoGenerated = true;
            this.Родитель_vmoДокументы.Caption = "Родитель";
            this.Родитель_vmoДокументы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель_vmoДокументы.Name = "Родитель";
            this.Родитель_vmoДокументы.NSGType = typeof(TechControl.Метаданные.УчетСотрудников.ДокументыФизЛиц);
            this.Родитель_vmoДокументы.PropertyType = typeof(TechControl.Метаданные.УчетСотрудников.ДокументыФизЛиц);
            this.Родитель_vmoДокументы.SearchCondition.OwnerComponent = this.Родитель_vmoДокументы;
            this.Родитель_vmoДокументы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер телефона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Должность:";
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "TechControl";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Мониторинг.ФизЛица.Наименование";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = true;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(132, 13);
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
            this.nsgInput1.Size = new System.Drawing.Size(200, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 0;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "TechControl";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Мониторинг.ФизЛица.Имя";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(132, 46);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "Метаданные";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Имя";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(130, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 1;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "TechControl";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "Мониторинг.ФизЛица.Фамилия";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(132, 80);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "Метаданные";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "Фамилия";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(130, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 2;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput4
            // 
            this.nsgInput4.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput4.ConfigurationName = "TechControl";
            this.nsgInput4.DisableLeaveControlEvent = false;
            this.nsgInput4.FullName = "Мониторинг.ФизЛица.Отчество";
            this.nsgInput4.FullTextSearch = false;
            this.nsgInput4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput4.IsButton = false;
            this.nsgInput4.IsInitialized = true;
            this.nsgInput4.IsPassword = false;
            this.nsgInput4.Location = new System.Drawing.Point(132, 112);
            this.nsgInput4.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput4.Mask = "";
            this.nsgInput4.MetaDataName = "Метаданные";
            this.nsgInput4.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput4.Name = "NsgInput";
            this.nsgInput4.ObjectImages = null;
            this.nsgInput4.ObjectIndex = null;
            this.nsgInput4.ObjectStrings = null;
            this.nsgInput4.Requsite = "Отчество";
            this.nsgInput4.SearchFieldName = "";
            this.nsgInput4.ShowMultipleObjectInComboBox = false;
            this.nsgInput4.ShowRowCount = 10;
            this.nsgInput4.Size = new System.Drawing.Size(130, 20);
            this.nsgInput4.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput4.TabIndex = 3;
            this.nsgInput4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput5
            // 
            this.nsgInput5.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput5.ConfigurationName = "TechControl";
            this.nsgInput5.DisableLeaveControlEvent = false;
            this.nsgInput5.FullName = "Мониторинг.ФизЛица.НомерТелефона";
            this.nsgInput5.FullTextSearch = false;
            this.nsgInput5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput5.IsButton = false;
            this.nsgInput5.IsInitialized = true;
            this.nsgInput5.IsPassword = false;
            this.nsgInput5.Location = new System.Drawing.Point(132, 148);
            this.nsgInput5.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput5.Mask = "";
            this.nsgInput5.MetaDataName = "Метаданные";
            this.nsgInput5.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput5.Name = "NsgInput";
            this.nsgInput5.ObjectImages = null;
            this.nsgInput5.ObjectIndex = null;
            this.nsgInput5.ObjectStrings = null;
            this.nsgInput5.Requsite = "НомерТелефона";
            this.nsgInput5.SearchFieldName = "";
            this.nsgInput5.ShowMultipleObjectInComboBox = false;
            this.nsgInput5.ShowRowCount = 10;
            this.nsgInput5.Size = new System.Drawing.Size(130, 20);
            this.nsgInput5.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput5.TabIndex = 4;
            this.nsgInput5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgInput6
            // 
            this.nsgInput6.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput6.ConfigurationName = "TechControl";
            this.nsgInput6.DisableLeaveControlEvent = false;
            this.nsgInput6.FullName = "Мониторинг.ФизЛица.Должность";
            this.nsgInput6.FullTextSearch = false;
            this.nsgInput6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput6.IsButton = false;
            this.nsgInput6.IsInitialized = true;
            this.nsgInput6.IsPassword = false;
            this.nsgInput6.Location = new System.Drawing.Point(132, 180);
            this.nsgInput6.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput6.Mask = "";
            this.nsgInput6.MetaDataName = "Метаданные";
            this.nsgInput6.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput6.Name = "NsgInput";
            this.nsgInput6.ObjectImages = null;
            this.nsgInput6.ObjectIndex = null;
            this.nsgInput6.ObjectStrings = null;
            this.nsgInput6.Requsite = "Должность";
            this.nsgInput6.SearchFieldName = "";
            this.nsgInput6.ShowMultipleObjectInComboBox = false;
            this.nsgInput6.ShowRowCount = 10;
            this.nsgInput6.Size = new System.Drawing.Size(305, 20);
            this.nsgInput6.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput6.TabIndex = 5;
            this.nsgInput6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpОсновные);
            this.tabControl1.Controls.Add(this.tpДокументы);
            this.tabControl1.Controls.Add(this.tpРазмеры);
            this.tabControl1.Controls.Add(this.tpМерки);
            this.tabControl1.Controls.Add(this.tpСовмещаемыеДолжности);
            this.tabControl1.Controls.Add(this.tpМатЦенности);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 528);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpОсновные
            // 
            this.tpОсновные.AllowDrop = true;
            this.tpОсновные.Controls.Add(this.groupBox1);
            this.tpОсновные.Controls.Add(this.nsgInput23);
            this.tpОсновные.Controls.Add(this.label23);
            this.tpОсновные.Controls.Add(this.gBДаты);
            this.tpОсновные.Controls.Add(this.nsgInput19);
            this.tpОсновные.Controls.Add(this.label20);
            this.tpОсновные.Controls.Add(this.nsgInput8);
            this.tpОсновные.Controls.Add(this.label8);
            this.tpОсновные.Controls.Add(this.nsgInput7);
            this.tpОсновные.Controls.Add(this.label7);
            this.tpОсновные.Controls.Add(this.nsgInput1);
            this.tpОсновные.Controls.Add(this.nsgInput6);
            this.tpОсновные.Controls.Add(this.label1);
            this.tpОсновные.Controls.Add(this.nsgInput5);
            this.tpОсновные.Controls.Add(this.label2);
            this.tpОсновные.Controls.Add(this.nsgInput4);
            this.tpОсновные.Controls.Add(this.label3);
            this.tpОсновные.Controls.Add(this.nsgInput3);
            this.tpОсновные.Controls.Add(this.label4);
            this.tpОсновные.Controls.Add(this.nsgInput2);
            this.tpОсновные.Controls.Add(this.label5);
            this.tpОсновные.Controls.Add(this.label6);
            this.tpОсновные.Enabled = true;
            this.tpОсновные.Location = new System.Drawing.Point(4, 22);
            this.tpОсновные.Name = "tpОсновные";
            this.tpОсновные.Padding = new System.Windows.Forms.Padding(3);
            this.tpОсновные.Size = new System.Drawing.Size(1158, 502);
            this.tpОсновные.TabIndex = 0;
            this.tpОсновные.Text = "Основные";
            this.tpОсновные.UseVisualStyleBackColor = true;
            this.tpОсновные.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AllowDrop = true;
            this.groupBox1.Controls.Add(this.nsgInput26);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.nsgInput25);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.nsgInput24);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(447, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 105);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для документов";
            // 
            // nsgInput26
            // 
            this.nsgInput26.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput26.ConfigurationName = "TechControl";
            this.nsgInput26.DisableLeaveControlEvent = false;
            this.nsgInput26.FullName = "Мониторинг.ФизЛица.КартинкаПодпись";
            this.nsgInput26.FullTextSearch = false;
            this.nsgInput26.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput26.IsButton = false;
            this.nsgInput26.IsInitialized = true;
            this.nsgInput26.IsPassword = false;
            this.nsgInput26.Location = new System.Drawing.Point(102, 68);
            this.nsgInput26.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput26.Mask = "";
            this.nsgInput26.MetaDataName = "Метаданные";
            this.nsgInput26.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput26.Name = "NsgInput";
            this.nsgInput26.ObjectImages = null;
            this.nsgInput26.ObjectIndex = null;
            this.nsgInput26.ObjectStrings = null;
            this.nsgInput26.Requsite = "КартинкаПодпись";
            this.nsgInput26.SearchFieldName = "";
            this.nsgInput26.ShowMultipleObjectInComboBox = false;
            this.nsgInput26.ShowRowCount = 10;
            this.nsgInput26.Size = new System.Drawing.Size(200, 20);
            this.nsgInput26.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput26.TabIndex = 38;
            this.nsgInput26.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(48, 75);
            this.label26.Name = "label6";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 39;
            this.label26.Text = "Подпись";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput25
            // 
            this.nsgInput25.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput25.ConfigurationName = "TechControl";
            this.nsgInput25.DisableLeaveControlEvent = false;
            this.nsgInput25.FullName = "Мониторинг.ФизЛица.ФИОРодительныйПадеж";
            this.nsgInput25.FullTextSearch = false;
            this.nsgInput25.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput25.IsButton = false;
            this.nsgInput25.IsInitialized = true;
            this.nsgInput25.IsPassword = false;
            this.nsgInput25.Location = new System.Drawing.Point(102, 45);
            this.nsgInput25.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput25.Mask = "";
            this.nsgInput25.MetaDataName = "Метаданные";
            this.nsgInput25.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput25.Name = "NsgInput";
            this.nsgInput25.ObjectImages = null;
            this.nsgInput25.ObjectIndex = null;
            this.nsgInput25.ObjectStrings = null;
            this.nsgInput25.Requsite = "ФИОРодительныйПадеж";
            this.nsgInput25.SearchFieldName = "";
            this.nsgInput25.ShowMultipleObjectInComboBox = false;
            this.nsgInput25.ShowRowCount = 10;
            this.nsgInput25.Size = new System.Drawing.Size(200, 20);
            this.nsgInput25.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput25.TabIndex = 36;
            this.nsgInput25.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 52);
            this.label25.Name = "label6";
            this.label25.Size = new System.Drawing.Size(96, 13);
            this.label25.TabIndex = 37;
            this.label25.Text = "ФИО Род.Падеж.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput24
            // 
            this.nsgInput24.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput24.ConfigurationName = "TechControl";
            this.nsgInput24.DisableLeaveControlEvent = false;
            this.nsgInput24.FullName = "Мониторинг.ФизЛица.ФИО";
            this.nsgInput24.FullTextSearch = false;
            this.nsgInput24.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput24.IsButton = false;
            this.nsgInput24.IsInitialized = true;
            this.nsgInput24.IsPassword = false;
            this.nsgInput24.Location = new System.Drawing.Point(102, 22);
            this.nsgInput24.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput24.Mask = "";
            this.nsgInput24.MetaDataName = "Метаданные";
            this.nsgInput24.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput24.Name = "NsgInput";
            this.nsgInput24.ObjectImages = null;
            this.nsgInput24.ObjectIndex = null;
            this.nsgInput24.ObjectStrings = null;
            this.nsgInput24.Requsite = "ФИО";
            this.nsgInput24.SearchFieldName = "";
            this.nsgInput24.ShowMultipleObjectInComboBox = false;
            this.nsgInput24.ShowRowCount = 10;
            this.nsgInput24.Size = new System.Drawing.Size(200, 20);
            this.nsgInput24.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput24.TabIndex = 34;
            this.nsgInput24.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(65, 29);
            this.label24.Name = "label6";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "ФИО";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput23
            // 
            this.nsgInput23.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput23.ConfigurationName = "TechControl";
            this.nsgInput23.DisableLeaveControlEvent = false;
            this.nsgInput23.FullName = "Мониторинг.ФизЛица.ТабельныйНомер";
            this.nsgInput23.FullTextSearch = false;
            this.nsgInput23.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput23.IsButton = false;
            this.nsgInput23.IsInitialized = true;
            this.nsgInput23.IsPassword = false;
            this.nsgInput23.Location = new System.Drawing.Point(132, 302);
            this.nsgInput23.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput23.Mask = "";
            this.nsgInput23.MetaDataName = "Метаданные";
            this.nsgInput23.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput23.Name = "NsgInput";
            this.nsgInput23.ObjectImages = null;
            this.nsgInput23.ObjectIndex = null;
            this.nsgInput23.ObjectStrings = null;
            this.nsgInput23.Requsite = "ТабельныйНомер";
            this.nsgInput23.SearchFieldName = "";
            this.nsgInput23.ShowMultipleObjectInComboBox = false;
            this.nsgInput23.ShowRowCount = 10;
            this.nsgInput23.Size = new System.Drawing.Size(305, 20);
            this.nsgInput23.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput23.TabIndex = 29;
            this.nsgInput23.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 302);
            this.label23.Name = "label6";
            this.label23.Size = new System.Drawing.Size(99, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Табельный номер";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBДаты
            // 
            this.gBДаты.AllowDrop = true;
            this.gBДаты.Controls.Add(this.nsgInput22);
            this.gBДаты.Controls.Add(this.label22);
            this.gBДаты.Controls.Add(this.nsgInput21);
            this.gBДаты.Controls.Add(this.label21);
            this.gBДаты.Controls.Add(this.nsgInput20);
            this.gBДаты.Controls.Add(this.lblРождение);
            this.gBДаты.Location = new System.Drawing.Point(447, 13);
            this.gBДаты.Name = "gBДаты";
            this.gBДаты.Size = new System.Drawing.Size(262, 107);
            this.gBДаты.TabIndex = 28;
            this.gBДаты.TabStop = false;
            this.gBДаты.Text = "Даты";
            // 
            // nsgInput22
            // 
            this.nsgInput22.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput22.ConfigurationName = "TechControl";
            this.nsgInput22.DisableLeaveControlEvent = false;
            this.nsgInput22.FullName = "Мониторинг.ФизЛица.ДатаПриемаНаРаботу";
            this.nsgInput22.FullTextSearch = false;
            this.nsgInput22.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput22.IsButton = false;
            this.nsgInput22.IsInitialized = true;
            this.nsgInput22.IsPassword = false;
            this.nsgInput22.Location = new System.Drawing.Point(103, 67);
            this.nsgInput22.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput22.Mask = "";
            this.nsgInput22.MetaDataName = "Метаданные";
            this.nsgInput22.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput22.Name = "NsgInput";
            this.nsgInput22.ObjectImages = null;
            this.nsgInput22.ObjectIndex = null;
            this.nsgInput22.ObjectStrings = null;
            this.nsgInput22.Requsite = "ДатаПриемаНаРаботу";
            this.nsgInput22.SearchFieldName = "";
            this.nsgInput22.ShowMultipleObjectInComboBox = false;
            this.nsgInput22.ShowRowCount = 10;
            this.nsgInput22.Size = new System.Drawing.Size(148, 20);
            this.nsgInput22.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput22.TabIndex = 32;
            this.nsgInput22.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 67);
            this.label22.Name = "label6";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Увольнение";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput21
            // 
            this.nsgInput21.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput21.ConfigurationName = "TechControl";
            this.nsgInput21.DisableLeaveControlEvent = false;
            this.nsgInput21.FullName = "Мониторинг.ФизЛица.ДатаПриемаНаРаботу";
            this.nsgInput21.FullTextSearch = false;
            this.nsgInput21.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput21.IsButton = false;
            this.nsgInput21.IsInitialized = true;
            this.nsgInput21.IsPassword = false;
            this.nsgInput21.Location = new System.Drawing.Point(103, 40);
            this.nsgInput21.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput21.Mask = "";
            this.nsgInput21.MetaDataName = "Метаданные";
            this.nsgInput21.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput21.Name = "NsgInput";
            this.nsgInput21.ObjectImages = null;
            this.nsgInput21.ObjectIndex = null;
            this.nsgInput21.ObjectStrings = null;
            this.nsgInput21.Requsite = "ДатаПриемаНаРаботу";
            this.nsgInput21.SearchFieldName = "";
            this.nsgInput21.ShowMultipleObjectInComboBox = false;
            this.nsgInput21.ShowRowCount = 10;
            this.nsgInput21.Size = new System.Drawing.Size(148, 20);
            this.nsgInput21.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput21.TabIndex = 30;
            this.nsgInput21.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 40);
            this.label21.Name = "label6";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Прием на работу";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput20
            // 
            this.nsgInput20.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput20.ConfigurationName = "TechControl";
            this.nsgInput20.DisableLeaveControlEvent = false;
            this.nsgInput20.FullName = "Мониторинг.ФизЛица.ДатаРождения";
            this.nsgInput20.FullTextSearch = false;
            this.nsgInput20.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput20.IsButton = false;
            this.nsgInput20.IsInitialized = true;
            this.nsgInput20.IsPassword = false;
            this.nsgInput20.Location = new System.Drawing.Point(103, 16);
            this.nsgInput20.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput20.Mask = "";
            this.nsgInput20.MetaDataName = "Метаданные";
            this.nsgInput20.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput20.Name = "NsgInput";
            this.nsgInput20.ObjectImages = null;
            this.nsgInput20.ObjectIndex = null;
            this.nsgInput20.ObjectStrings = null;
            this.nsgInput20.Requsite = "ДатаРождения";
            this.nsgInput20.SearchFieldName = "";
            this.nsgInput20.ShowMultipleObjectInComboBox = false;
            this.nsgInput20.ShowRowCount = 10;
            this.nsgInput20.Size = new System.Drawing.Size(148, 20);
            this.nsgInput20.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput20.TabIndex = 28;
            this.nsgInput20.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblРождение
            // 
            this.lblРождение.AutoSize = true;
            this.lblРождение.Location = new System.Drawing.Point(7, 16);
            this.lblРождение.Name = "label6";
            this.lblРождение.Size = new System.Drawing.Size(58, 13);
            this.lblРождение.TabIndex = 29;
            this.lblРождение.Text = "Рождение";
            this.lblРождение.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput19
            // 
            this.nsgInput19.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput19.ConfigurationName = "TechControl";
            this.nsgInput19.DisableLeaveControlEvent = false;
            this.nsgInput19.FullName = "Мониторинг.ФизЛица.Подразделение";
            this.nsgInput19.FullTextSearch = false;
            this.nsgInput19.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput19.IsButton = false;
            this.nsgInput19.IsInitialized = true;
            this.nsgInput19.IsPassword = false;
            this.nsgInput19.Location = new System.Drawing.Point(132, 272);
            this.nsgInput19.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput19.Mask = "";
            this.nsgInput19.MetaDataName = "Метаданные";
            this.nsgInput19.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput19.Name = "NsgInput";
            this.nsgInput19.ObjectImages = null;
            this.nsgInput19.ObjectIndex = null;
            this.nsgInput19.ObjectStrings = null;
            this.nsgInput19.Requsite = "Подразделение";
            this.nsgInput19.SearchFieldName = "";
            this.nsgInput19.ShowMultipleObjectInComboBox = false;
            this.nsgInput19.ShowRowCount = 10;
            this.nsgInput19.Size = new System.Drawing.Size(305, 20);
            this.nsgInput19.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput19.TabIndex = 24;
            this.nsgInput19.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 272);
            this.label20.Name = "label6";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Подразделение";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput8
            // 
            this.nsgInput8.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput8.ConfigurationName = "TechControl";
            this.nsgInput8.DisableLeaveControlEvent = false;
            this.nsgInput8.FullName = "Мониторинг.ФизЛица.ОбъектВыдачиСпецодежды";
            this.nsgInput8.FullTextSearch = false;
            this.nsgInput8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput8.IsButton = false;
            this.nsgInput8.IsInitialized = true;
            this.nsgInput8.IsPassword = false;
            this.nsgInput8.Location = new System.Drawing.Point(132, 242);
            this.nsgInput8.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput8.Mask = "";
            this.nsgInput8.MetaDataName = "Метаданные";
            this.nsgInput8.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput8.Name = "NsgInput";
            this.nsgInput8.ObjectImages = null;
            this.nsgInput8.ObjectIndex = null;
            this.nsgInput8.ObjectStrings = null;
            this.nsgInput8.Requsite = "ОбъектВыдачиСпецодежды";
            this.nsgInput8.SearchFieldName = "";
            this.nsgInput8.ShowMultipleObjectInComboBox = false;
            this.nsgInput8.ShowRowCount = 10;
            this.nsgInput8.Size = new System.Drawing.Size(305, 20);
            this.nsgInput8.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput8.TabIndex = 7;
            this.nsgInput8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 242);
            this.label8.Name = "label6";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Объект выдачи спецодежды:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgInput7
            // 
            this.nsgInput7.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput7.ConfigurationName = "TechControl";
            this.nsgInput7.DisableLeaveControlEvent = false;
            this.nsgInput7.FullName = "Мониторинг.ФизЛица.ОсновнойОбъект";
            this.nsgInput7.FullTextSearch = false;
            this.nsgInput7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput7.IsButton = false;
            this.nsgInput7.IsInitialized = true;
            this.nsgInput7.IsPassword = false;
            this.nsgInput7.Location = new System.Drawing.Point(132, 211);
            this.nsgInput7.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput7.Mask = "";
            this.nsgInput7.MetaDataName = "Метаданные";
            this.nsgInput7.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput7.Name = "NsgInput";
            this.nsgInput7.ObjectImages = null;
            this.nsgInput7.ObjectIndex = null;
            this.nsgInput7.ObjectStrings = null;
            this.nsgInput7.Requsite = "ОсновнойОбъект";
            this.nsgInput7.SearchFieldName = "";
            this.nsgInput7.ShowMultipleObjectInComboBox = false;
            this.nsgInput7.ShowRowCount = 10;
            this.nsgInput7.Size = new System.Drawing.Size(305, 20);
            this.nsgInput7.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput7.TabIndex = 6;
            this.nsgInput7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 218);
            this.label7.Name = "label6";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Основной объект:";
            // 
            // tpДокументы
            // 
            this.tpДокументы.AllowDrop = true;
            this.tpДокументы.Controls.Add(this.nsgIGrid4);
            this.tpДокументы.Enabled = true;
            this.tpДокументы.Location = new System.Drawing.Point(4, 22);
            this.tpДокументы.Name = "tpДокументы";
            this.tpДокументы.Size = new System.Drawing.Size(1158, 502);
            this.tpДокументы.TabIndex = 5;
            this.tpДокументы.Text = "Документы";
            this.tpДокументы.UseVisualStyleBackColor = true;
            this.tpДокументы.Visible = false;
            // 
            // tpРазмеры
            // 
            this.tpРазмеры.AllowDrop = true;
            this.tpРазмеры.Controls.Add(this.nsgIGrid1);
            this.tpРазмеры.Enabled = true;
            this.tpРазмеры.Location = new System.Drawing.Point(4, 22);
            this.tpРазмеры.Name = "tpРазмеры";
            this.tpРазмеры.Padding = new System.Windows.Forms.Padding(3);
            this.tpРазмеры.Size = new System.Drawing.Size(1158, 502);
            this.tpРазмеры.TabIndex = 1;
            this.tpРазмеры.Text = "Размеры";
            this.tpРазмеры.UseVisualStyleBackColor = true;
            this.tpРазмеры.Visible = false;
            // 
            // tpМерки
            // 
            this.tpМерки.AllowDrop = true;
            this.tpМерки.Controls.Add(this.nbЗаполнитьТаблицуРазмеров);
            this.tpМерки.Controls.Add(this.label19);
            this.tpМерки.Controls.Add(this.nsgInput18);
            this.tpМерки.Controls.Add(this.label18);
            this.tpМерки.Controls.Add(this.nsgInput17);
            this.tpМерки.Controls.Add(this.pictureBox2);
            this.tpМерки.Controls.Add(this.label17);
            this.tpМерки.Controls.Add(this.label16);
            this.tpМерки.Controls.Add(this.nsgInput16);
            this.tpМерки.Controls.Add(this.label15);
            this.tpМерки.Controls.Add(this.nsgInput15);
            this.tpМерки.Controls.Add(this.label14);
            this.tpМерки.Controls.Add(this.nsgInput14);
            this.tpМерки.Controls.Add(this.label13);
            this.tpМерки.Controls.Add(this.nsgInput13);
            this.tpМерки.Controls.Add(this.label12);
            this.tpМерки.Controls.Add(this.nsgInput12);
            this.tpМерки.Controls.Add(this.label11);
            this.tpМерки.Controls.Add(this.nsgInput11);
            this.tpМерки.Controls.Add(this.label10);
            this.tpМерки.Controls.Add(this.nsgInput10);
            this.tpМерки.Controls.Add(this.label9);
            this.tpМерки.Controls.Add(this.nsgInput9);
            this.tpМерки.Controls.Add(this.pictureBox1);
            this.tpМерки.Enabled = true;
            this.tpМерки.Location = new System.Drawing.Point(4, 22);
            this.tpМерки.Name = "tpМерки";
            this.tpМерки.Size = new System.Drawing.Size(1158, 502);
            this.tpМерки.TabIndex = 2;
            this.tpМерки.Text = "Мерки";
            this.tpМерки.UseVisualStyleBackColor = true;
            this.tpМерки.Visible = false;
            // 
            // nbЗаполнитьТаблицуРазмеров
            // 
            this.nbЗаполнитьТаблицуРазмеров.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbЗаполнитьТаблицуРазмеров.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbЗаполнитьТаблицуРазмеров.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbЗаполнитьТаблицуРазмеров.Location = new System.Drawing.Point(443, 398);
            this.nbЗаполнитьТаблицуРазмеров.Name = "NsgButton";
            this.nbЗаполнитьТаблицуРазмеров.ReadOnlyProvider = this.nsgVisualMultipleObject;
            this.nbЗаполнитьТаблицуРазмеров.Size = new System.Drawing.Size(97, 63);
            this.nbЗаполнитьТаблицуРазмеров.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbЗаполнитьТаблицуРазмеров.TabIndex = 23;
            this.nbЗаполнитьТаблицуРазмеров.Text = "Заполнить таблицу размеров";
            this.nbЗаполнитьТаблицуРазмеров.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbЗаполнитьТаблицуРазмеров.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbЗаполнитьТаблицуРазмеров_AsyncClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(824, 476);
            this.label19.Name = "label9";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Обхват головы";
            // 
            // nsgInput18
            // 
            this.nsgInput18.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput18.ConfigurationName = "TechControl";
            this.nsgInput18.DisableLeaveControlEvent = false;
            this.nsgInput18.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ОбхватГоловы";
            this.nsgInput18.FullTextSearch = false;
            this.nsgInput18.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput18.IsButton = false;
            this.nsgInput18.IsInitialized = true;
            this.nsgInput18.IsPassword = false;
            this.nsgInput18.Location = new System.Drawing.Point(910, 470);
            this.nsgInput18.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput18.Mask = "";
            this.nsgInput18.MetaDataName = "Метаданные";
            this.nsgInput18.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput18.Name = "NsgInput";
            this.nsgInput18.ObjectImages = null;
            this.nsgInput18.ObjectIndex = null;
            this.nsgInput18.ObjectStrings = null;
            this.nsgInput18.Requsite = "ОбхватГоловы";
            this.nsgInput18.SearchFieldName = "";
            this.nsgInput18.ShowMultipleObjectInComboBox = false;
            this.nsgInput18.ShowRowCount = 10;
            this.nsgInput18.Size = new System.Drawing.Size(58, 20);
            this.nsgInput18.SourceObject = this.vmoМерки;
            this.nsgInput18.TabIndex = 9;
            this.nsgInput18.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.vmoМерки.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor6.ConfigurationName = "TechControl";
            this.vmoМерки.MetaDataName = "Метаданные";
            this.vmoМерки.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец";
            // 
            // vmoМерки
            // 
            nsgObjectDescriptor5.ConfigurationName = "TechControl";
            nsgObjectDescriptor5.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец";
            nsgObjectDescriptor5.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.DetailField = nsgObjectDescriptor5;
            nsgObjectDescriptor6.FullName = "Мониторинг.ФизЛица.Идентификатор";
            nsgObjectDescriptor6.MetaDataName = "Метаданные";
            nsgMasterDetailBinding3.MasterField = nsgObjectDescriptor6;
            nsgMasterDetailBinding3.Type = NsgSoft.Forms.NsgBindingType.Subdictionaries;
            this.vmoМерки.Columns.Collection.Add(this.Владелец_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.Идентификатор_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.Автоинкремент_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.ЭтоГруппа_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.ИдентификаторРодителя_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.Уровень_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.ПрефиксКода_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.НомерКода_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.Код_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.Наименование_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.СостояниеДокумента_vmoМерки);
            this.vmoМерки.Columns.Collection.Add(this.ОбхватТалии);
            this.vmoМерки.Columns.Collection.Add(this.Рост);
            this.vmoМерки.Columns.Collection.Add(this.ОбхватБедер);
            this.vmoМерки.Columns.Collection.Add(this.БоковаяДлинаБрюк);
            this.vmoМерки.Columns.Collection.Add(this.ДлинаБрюкПоВнутреннемуШву);
            this.vmoМерки.Columns.Collection.Add(this.ОбхватШеи);
            this.vmoМерки.Columns.Collection.Add(this.ДлинаРукава);
            this.vmoМерки.Columns.Collection.Add(this.ДлинаСтопы);
            this.vmoМерки.Columns.Collection.Add(this.ОбхватГруди);
            this.vmoМерки.Columns.Collection.Add(this.ОбхватГоловы);
            this.vmoМерки.Columns.Collection.Add(this.Родитель_vmoМерки);
            this.vmoМерки.IsActive = true;
            this.vmoМерки.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoМерки.Binding = nsgMasterDetailBinding3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(544, 475);
            this.label18.Name = "label9";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Длина стопы";
            // 
            // nsgInput17
            // 
            this.nsgInput17.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput17.ConfigurationName = "TechControl";
            this.nsgInput17.DisableLeaveControlEvent = false;
            this.nsgInput17.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ДлинаСтопы";
            this.nsgInput17.FullTextSearch = false;
            this.nsgInput17.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput17.IsButton = false;
            this.nsgInput17.IsInitialized = true;
            this.nsgInput17.IsPassword = false;
            this.nsgInput17.Location = new System.Drawing.Point(621, 469);
            this.nsgInput17.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput17.Mask = "";
            this.nsgInput17.MetaDataName = "Метаданные";
            this.nsgInput17.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput17.Name = "NsgInput";
            this.nsgInput17.ObjectImages = null;
            this.nsgInput17.ObjectIndex = null;
            this.nsgInput17.ObjectStrings = null;
            this.nsgInput17.Requsite = "ДлинаСтопы";
            this.nsgInput17.SearchFieldName = "";
            this.nsgInput17.ShowMultipleObjectInComboBox = false;
            this.nsgInput17.ShowRowCount = 10;
            this.nsgInput17.Size = new System.Drawing.Size(58, 20);
            this.nsgInput17.SourceObject = this.vmoМерки;
            this.nsgInput17.TabIndex = 8;
            this.nsgInput17.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TechControl.Properties.Resources.РазмерыОбуви;
            this.pictureBox2.Location = new System.Drawing.Point(546, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 457);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(445, 13);
            this.label17.Name = "label9";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Размеры в см";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(444, 70);
            this.label16.Name = "label9";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "2.";
            // 
            // nsgInput16
            // 
            this.nsgInput16.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput16.ConfigurationName = "TechControl";
            this.nsgInput16.DisableLeaveControlEvent = false;
            this.nsgInput16.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ОбхватГруди";
            this.nsgInput16.FullTextSearch = false;
            this.nsgInput16.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput16.IsButton = false;
            this.nsgInput16.IsInitialized = true;
            this.nsgInput16.IsPassword = false;
            this.nsgInput16.Location = new System.Drawing.Point(467, 64);
            this.nsgInput16.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput16.Mask = "";
            this.nsgInput16.MetaDataName = "Метаданные";
            this.nsgInput16.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput16.Name = "NsgInput";
            this.nsgInput16.ObjectImages = null;
            this.nsgInput16.ObjectIndex = null;
            this.nsgInput16.ObjectStrings = null;
            this.nsgInput16.Requsite = "ОбхватГруди";
            this.nsgInput16.SearchFieldName = "";
            this.nsgInput16.ShowMultipleObjectInComboBox = false;
            this.nsgInput16.ShowRowCount = 10;
            this.nsgInput16.Size = new System.Drawing.Size(58, 20);
            this.nsgInput16.SourceObject = this.vmoМерки;
            this.nsgInput16.TabIndex = 1;
            this.nsgInput16.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(444, 99);
            this.label15.Name = "label9";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "3.";
            // 
            // nsgInput15
            // 
            this.nsgInput15.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput15.ConfigurationName = "TechControl";
            this.nsgInput15.DisableLeaveControlEvent = false;
            this.nsgInput15.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ОбхватТалии";
            this.nsgInput15.FullTextSearch = false;
            this.nsgInput15.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput15.IsButton = false;
            this.nsgInput15.IsInitialized = true;
            this.nsgInput15.IsPassword = false;
            this.nsgInput15.Location = new System.Drawing.Point(467, 93);
            this.nsgInput15.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput15.Mask = "";
            this.nsgInput15.MetaDataName = "Метаданные";
            this.nsgInput15.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput15.Name = "NsgInput";
            this.nsgInput15.ObjectImages = null;
            this.nsgInput15.ObjectIndex = null;
            this.nsgInput15.ObjectStrings = null;
            this.nsgInput15.Requsite = "ОбхватТалии";
            this.nsgInput15.SearchFieldName = "";
            this.nsgInput15.ShowMultipleObjectInComboBox = false;
            this.nsgInput15.ShowRowCount = 10;
            this.nsgInput15.Size = new System.Drawing.Size(58, 20);
            this.nsgInput15.SourceObject = this.vmoМерки;
            this.nsgInput15.TabIndex = 2;
            this.nsgInput15.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 128);
            this.label14.Name = "label9";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "4.";
            // 
            // nsgInput14
            // 
            this.nsgInput14.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput14.ConfigurationName = "TechControl";
            this.nsgInput14.DisableLeaveControlEvent = false;
            this.nsgInput14.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ОбхватБедер";
            this.nsgInput14.FullTextSearch = false;
            this.nsgInput14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput14.IsButton = false;
            this.nsgInput14.IsInitialized = true;
            this.nsgInput14.IsPassword = false;
            this.nsgInput14.Location = new System.Drawing.Point(467, 122);
            this.nsgInput14.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput14.Mask = "";
            this.nsgInput14.MetaDataName = "Метаданные";
            this.nsgInput14.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput14.Name = "NsgInput";
            this.nsgInput14.ObjectImages = null;
            this.nsgInput14.ObjectIndex = null;
            this.nsgInput14.ObjectStrings = null;
            this.nsgInput14.Requsite = "ОбхватБедер";
            this.nsgInput14.SearchFieldName = "";
            this.nsgInput14.ShowMultipleObjectInComboBox = false;
            this.nsgInput14.ShowRowCount = 10;
            this.nsgInput14.Size = new System.Drawing.Size(58, 20);
            this.nsgInput14.SourceObject = this.vmoМерки;
            this.nsgInput14.TabIndex = 3;
            this.nsgInput14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 157);
            this.label13.Name = "label9";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "5.";
            // 
            // nsgInput13
            // 
            this.nsgInput13.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput13.ConfigurationName = "TechControl";
            this.nsgInput13.DisableLeaveControlEvent = false;
            this.nsgInput13.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.БоковаяДлинаБрюк";
            this.nsgInput13.FullTextSearch = false;
            this.nsgInput13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput13.IsButton = false;
            this.nsgInput13.IsInitialized = true;
            this.nsgInput13.IsPassword = false;
            this.nsgInput13.Location = new System.Drawing.Point(467, 151);
            this.nsgInput13.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput13.Mask = "";
            this.nsgInput13.MetaDataName = "Метаданные";
            this.nsgInput13.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput13.Name = "NsgInput";
            this.nsgInput13.ObjectImages = null;
            this.nsgInput13.ObjectIndex = null;
            this.nsgInput13.ObjectStrings = null;
            this.nsgInput13.Requsite = "БоковаяДлинаБрюк";
            this.nsgInput13.SearchFieldName = "";
            this.nsgInput13.ShowMultipleObjectInComboBox = false;
            this.nsgInput13.ShowRowCount = 10;
            this.nsgInput13.Size = new System.Drawing.Size(58, 20);
            this.nsgInput13.SourceObject = this.vmoМерки;
            this.nsgInput13.TabIndex = 4;
            this.nsgInput13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 186);
            this.label12.Name = "label9";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "6.";
            // 
            // nsgInput12
            // 
            this.nsgInput12.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput12.ConfigurationName = "TechControl";
            this.nsgInput12.DisableLeaveControlEvent = false;
            this.nsgInput12.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ДлинаБрюкПоВнутреннемуШву";
            this.nsgInput12.FullTextSearch = false;
            this.nsgInput12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput12.IsButton = false;
            this.nsgInput12.IsInitialized = true;
            this.nsgInput12.IsPassword = false;
            this.nsgInput12.Location = new System.Drawing.Point(467, 180);
            this.nsgInput12.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput12.Mask = "";
            this.nsgInput12.MetaDataName = "Метаданные";
            this.nsgInput12.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput12.Name = "NsgInput";
            this.nsgInput12.ObjectImages = null;
            this.nsgInput12.ObjectIndex = null;
            this.nsgInput12.ObjectStrings = null;
            this.nsgInput12.Requsite = "ДлинаБрюкПоВнутреннемуШву";
            this.nsgInput12.SearchFieldName = "";
            this.nsgInput12.ShowMultipleObjectInComboBox = false;
            this.nsgInput12.ShowRowCount = 10;
            this.nsgInput12.Size = new System.Drawing.Size(58, 20);
            this.nsgInput12.SourceObject = this.vmoМерки;
            this.nsgInput12.TabIndex = 5;
            this.nsgInput12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 215);
            this.label11.Name = "label9";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "7.";
            // 
            // nsgInput11
            // 
            this.nsgInput11.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput11.ConfigurationName = "TechControl";
            this.nsgInput11.DisableLeaveControlEvent = false;
            this.nsgInput11.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ОбхватШеи";
            this.nsgInput11.FullTextSearch = false;
            this.nsgInput11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput11.IsButton = false;
            this.nsgInput11.IsInitialized = true;
            this.nsgInput11.IsPassword = false;
            this.nsgInput11.Location = new System.Drawing.Point(467, 209);
            this.nsgInput11.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput11.Mask = "";
            this.nsgInput11.MetaDataName = "Метаданные";
            this.nsgInput11.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput11.Name = "NsgInput";
            this.nsgInput11.ObjectImages = null;
            this.nsgInput11.ObjectIndex = null;
            this.nsgInput11.ObjectStrings = null;
            this.nsgInput11.Requsite = "ОбхватШеи";
            this.nsgInput11.SearchFieldName = "";
            this.nsgInput11.ShowMultipleObjectInComboBox = false;
            this.nsgInput11.ShowRowCount = 10;
            this.nsgInput11.Size = new System.Drawing.Size(58, 20);
            this.nsgInput11.SourceObject = this.vmoМерки;
            this.nsgInput11.TabIndex = 6;
            this.nsgInput11.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 245);
            this.label10.Name = "label9";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "8.";
            // 
            // nsgInput10
            // 
            this.nsgInput10.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput10.ConfigurationName = "TechControl";
            this.nsgInput10.DisableLeaveControlEvent = false;
            this.nsgInput10.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.ДлинаРукава";
            this.nsgInput10.FullTextSearch = false;
            this.nsgInput10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput10.IsButton = false;
            this.nsgInput10.IsInitialized = true;
            this.nsgInput10.IsPassword = false;
            this.nsgInput10.Location = new System.Drawing.Point(467, 239);
            this.nsgInput10.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput10.Mask = "";
            this.nsgInput10.MetaDataName = "Метаданные";
            this.nsgInput10.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput10.Name = "NsgInput";
            this.nsgInput10.ObjectImages = null;
            this.nsgInput10.ObjectIndex = null;
            this.nsgInput10.ObjectStrings = null;
            this.nsgInput10.Requsite = "ДлинаРукава";
            this.nsgInput10.SearchFieldName = "";
            this.nsgInput10.ShowMultipleObjectInComboBox = false;
            this.nsgInput10.ShowRowCount = 10;
            this.nsgInput10.Size = new System.Drawing.Size(58, 20);
            this.nsgInput10.SourceObject = this.vmoМерки;
            this.nsgInput10.TabIndex = 7;
            this.nsgInput10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "1.";
            // 
            // nsgInput9
            // 
            this.nsgInput9.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput9.ConfigurationName = "TechControl";
            this.nsgInput9.DisableLeaveControlEvent = false;
            this.nsgInput9.FullName = "УчетСпецодеждыИСИЗ.Мерки.Владелец.Рост";
            this.nsgInput9.FullTextSearch = false;
            this.nsgInput9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput9.IsButton = false;
            this.nsgInput9.IsInitialized = true;
            this.nsgInput9.IsPassword = false;
            this.nsgInput9.Location = new System.Drawing.Point(467, 35);
            this.nsgInput9.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput9.Mask = "";
            this.nsgInput9.MetaDataName = "Метаданные";
            this.nsgInput9.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput9.Name = "NsgInput";
            this.nsgInput9.ObjectImages = null;
            this.nsgInput9.ObjectIndex = null;
            this.nsgInput9.ObjectStrings = null;
            this.nsgInput9.Requsite = "Рост";
            this.nsgInput9.SearchFieldName = "";
            this.nsgInput9.ShowMultipleObjectInComboBox = false;
            this.nsgInput9.ShowRowCount = 10;
            this.nsgInput9.Size = new System.Drawing.Size(58, 20);
            this.nsgInput9.SourceObject = this.vmoМерки;
            this.nsgInput9.TabIndex = 0;
            this.nsgInput9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechControl.Properties.Resources.МеркиКостюма;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 485);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpСовмещаемыеДолжности
            // 
            this.tpСовмещаемыеДолжности.AllowDrop = true;
            this.tpСовмещаемыеДолжности.Controls.Add(this.nsgIGrid2);
            this.tpСовмещаемыеДолжности.Enabled = true;
            this.tpСовмещаемыеДолжности.Location = new System.Drawing.Point(4, 22);
            this.tpСовмещаемыеДолжности.Name = "tpСовмещаемыеДолжности";
            this.tpСовмещаемыеДолжности.Size = new System.Drawing.Size(1158, 502);
            this.tpСовмещаемыеДолжности.TabIndex = 3;
            this.tpСовмещаемыеДолжности.Text = "Совмещаемые должности";
            this.tpСовмещаемыеДолжности.UseVisualStyleBackColor = true;
            this.tpСовмещаемыеДолжности.Visible = false;
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
            nsgIGridColumn22.AllowFilter = true;
            nsgIGridColumn22.AllowGroupSelect = false;
            nsgIGridColumn22.AllowResize = true;
            nsgIGridColumn22.AutoResize = true;
            nsgIGridColumn22.Caption = "";
            nsgIGridColumn22.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn22.DateFormat = null;
            nsgIGridColumn22.InitiateRowEdit = true;
            nsgIGridColumn22.Name = "Владелец";
            nsgIGridColumn22.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn22.Root = this.nsgIGrid2.Columns.Collection;
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
            nsgIGridColumn23.InitiateRowEdit = true;
            nsgIGridColumn23.Name = "Должность";
            nsgIGridColumn23.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn23.Root = this.nsgIGrid2.Columns.Collection;
            nsgIGridColumn23.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn23.UseAsHeaderImage = false;
            nsgIGridColumn23.Width = 100;
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn22);
            this.nsgIGrid2.Columns.Collection.Add(nsgIGridColumn23);
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
            this.nsgIGrid2.Size = new System.Drawing.Size(1148, 496);
            this.nsgIGrid2.SourceObject = this.vmoТаблицаДолжностей;
            this.nsgIGrid2.TabIndex = 0;
            this.nsgIGrid2.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            this.vmoТаблицаДолжностей.DataSourceType = NsgSoft.Forms.NsgDataSourceType.MasterComponent;
            nsgObjectDescriptor8.ConfigurationName = "TechControl";
            this.vmoТаблицаДолжностей.MetaDataName = "Метаданные";
            this.vmoТаблицаДолжностей.FullName = "_SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Владелец";
            // 
            // vmoТаблицаДолжностей
            // 
            nsgObjectDescriptor7.ConfigurationName = "TechControl";
            nsgObjectDescriptor7.FullName = "_SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Владелец";
            nsgObjectDescriptor7.MetaDataName = "Метаданные";
            nsgMasterDetailBinding4.DetailField = nsgObjectDescriptor7;
            nsgObjectDescriptor8.FullName = "Мониторинг.ФизЛица.ТаблицаСовмещаемыхДолжностей";
            nsgObjectDescriptor8.MetaDataName = "Метаданные";
            nsgMasterDetailBinding4.MasterField = nsgObjectDescriptor8;
            nsgMasterDetailBinding4.Type = NsgSoft.Forms.NsgBindingType.Tables;
            this.vmoТаблицаДолжностей.Columns.Collection.Add(this.Идентификатор_vmoТаблицаДолжностей);
            this.vmoТаблицаДолжностей.Columns.Collection.Add(this.Автоинкремент_vmoТаблицаДолжностей);
            this.vmoТаблицаДолжностей.Columns.Collection.Add(this.Владелец_vmoТаблицаДолжностей);
            this.vmoТаблицаДолжностей.Columns.Collection.Add(this.НомерСтроки_vmoТаблицаДолжностей);
            this.vmoТаблицаДолжностей.Columns.Collection.Add(this.Должность_vmoТаблицаДолжностей);
            this.vmoТаблицаДолжностей.IsActive = true;
            this.vmoТаблицаДолжностей.MasterComponent = this.nsgVisualMultipleObject;
            this.vmoТаблицаДолжностей.Binding = nsgMasterDetailBinding4;
            // 
            // Идентификатор_vmoТаблицаДолжностей
            // 
            this.Идентификатор_vmoТаблицаДолжностей.AutoGenerated = true;
            this.Идентификатор_vmoТаблицаДолжностей.Caption = "Идентификатор";
            this.Идентификатор_vmoТаблицаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoТаблицаДолжностей.Name = "Идентификатор";
            this.Идентификатор_vmoТаблицаДолжностей.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoТаблицаДолжностей.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoТаблицаДолжностей.SearchCondition.OwnerComponent = this.Идентификатор_vmoТаблицаДолжностей;
            this.Идентификатор_vmoТаблицаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoТаблицаДолжностей.Visible = false;
            // 
            // Автоинкремент_vmoТаблицаДолжностей
            // 
            this.Автоинкремент_vmoТаблицаДолжностей.AutoGenerated = true;
            this.Автоинкремент_vmoТаблицаДолжностей.CalcTotal = false;
            this.Автоинкремент_vmoТаблицаДолжностей.Caption = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoТаблицаДолжностей.Name = "Автоинкремент";
            this.Автоинкремент_vmoТаблицаДолжностей.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoТаблицаДолжностей.PropertyType = typeof(long);
            this.Автоинкремент_vmoТаблицаДолжностей.SearchCondition.OwnerComponent = this.Автоинкремент_vmoТаблицаДолжностей;
            this.Автоинкремент_vmoТаблицаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoТаблицаДолжностей.Visible = false;
            // 
            // Владелец_vmoТаблицаДолжностей
            // 
            this.Владелец_vmoТаблицаДолжностей.AutoGenerated = true;
            this.Владелец_vmoТаблицаДолжностей.Caption = "Владелец";
            this.Владелец_vmoТаблицаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoТаблицаДолжностей.Name = "Владелец";
            this.Владелец_vmoТаблицаДолжностей.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаДолжностей.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoТаблицаДолжностей.SearchCondition.OwnerComponent = this.Владелец_vmoТаблицаДолжностей;
            this.Владелец_vmoТаблицаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НомерСтроки_vmoТаблицаДолжностей
            // 
            this.НомерСтроки_vmoТаблицаДолжностей.AutoGenerated = true;
            this.НомерСтроки_vmoТаблицаДолжностей.CalcTotal = false;
            this.НомерСтроки_vmoТаблицаДолжностей.Caption = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерСтроки_vmoТаблицаДолжностей.Name = "НомерСтроки";
            this.НомерСтроки_vmoТаблицаДолжностей.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерСтроки_vmoТаблицаДолжностей.PropertyType = typeof(long);
            this.НомерСтроки_vmoТаблицаДолжностей.SearchCondition.OwnerComponent = this.НомерСтроки_vmoТаблицаДолжностей;
            this.НомерСтроки_vmoТаблицаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерСтроки_vmoТаблицаДолжностей.Visible = false;
            // 
            // Должность_vmoТаблицаДолжностей
            // 
            this.Должность_vmoТаблицаДолжностей.AutoGenerated = true;
            this.Должность_vmoТаблицаДолжностей.Caption = "Должность";
            this.Должность_vmoТаблицаДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Должность_vmoТаблицаДолжностей.Name = "Должность";
            this.Должность_vmoТаблицаДолжностей.NSGType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаДолжностей.PropertyType = typeof(TechControl.Метаданные.Мониторинг.Должности);
            this.Должность_vmoТаблицаДолжностей.SearchCondition.OwnerComponent = this.Должность_vmoТаблицаДолжностей;
            this.Должность_vmoТаблицаДолжностей.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // tpМатЦенности
            // 
            this.tpМатЦенности.AllowDrop = true;
            this.tpМатЦенности.Controls.Add(this.nsgIGrid3);
            this.tpМатЦенности.Enabled = true;
            this.tpМатЦенности.Location = new System.Drawing.Point(4, 22);
            this.tpМатЦенности.Name = "tpМатЦенности";
            this.tpМатЦенности.Size = new System.Drawing.Size(1158, 502);
            this.tpМатЦенности.TabIndex = 4;
            this.tpМатЦенности.Text = "Материальные ценности";
            this.tpМатЦенности.UseVisualStyleBackColor = true;
            this.tpМатЦенности.Visible = false;
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
            // Фамилия
            // 
            this.Фамилия.AutoGenerated = true;
            this.Фамилия.Caption = "Фамилия";
            this.Фамилия.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Отчество.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.НомерТелефона.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Должность.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Имя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Статус.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ИдентификаторСтрока.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.IDСотрудника.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Размер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.АккаунтПользователя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ТабельныйНомер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ДатаРождения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ДатаПриемаНаРаботу.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ДатаУвольнения.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ТаблицаРазмеров.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ОбъектВыдачиСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ОсновнойОбъект.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ЗагрузочныйИдентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ДокументКонтроляСпецодежды.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.Подразделение.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ТаблицаСовмещаемыхДолжностей.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.КартинкаПодпись.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ФИО.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
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
            this.ФИОРодительныйПадеж.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ФИОРодительныйПадеж.Name = "ФИОРодительныйПадеж";
            this.ФИОРодительныйПадеж.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ФИОРодительныйПадеж.PropertyType = typeof(string);
            this.ФИОРодительныйПадеж.SearchCondition.OwnerComponent = this.ФИОРодительныйПадеж;
            this.ФИОРодительныйПадеж.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Родитель.PropertyType = typeof(TechControl.Метаданные.Мониторинг.ФизЛица);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Владелец_vmoМерки
            // 
            this.Владелец_vmoМерки.AutoGenerated = true;
            this.Владелец_vmoМерки.Caption = "Владелец";
            this.Владелец_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Владелец_vmoМерки.Name = "Владелец";
            this.Владелец_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoМерки.PropertyType = typeof(NsgSoft.DataObjects.NsgReferencedObject);
            this.Владелец_vmoМерки.SearchCondition.OwnerComponent = this.Владелец_vmoМерки;
            this.Владелец_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Идентификатор_vmoМерки
            // 
            this.Идентификатор_vmoМерки.AutoGenerated = true;
            this.Идентификатор_vmoМерки.Caption = "Идентификатор";
            this.Идентификатор_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор_vmoМерки.Name = "Идентификатор";
            this.Идентификатор_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор_vmoМерки.PropertyType = typeof(System.Guid);
            this.Идентификатор_vmoМерки.SearchCondition.OwnerComponent = this.Идентификатор_vmoМерки;
            this.Идентификатор_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор_vmoМерки.Visible = false;
            // 
            // Автоинкремент_vmoМерки
            // 
            this.Автоинкремент_vmoМерки.AutoGenerated = true;
            this.Автоинкремент_vmoМерки.CalcTotal = false;
            this.Автоинкремент_vmoМерки.Caption = "Автоинкремент";
            this.Автоинкремент_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент_vmoМерки.Name = "Автоинкремент";
            this.Автоинкремент_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент_vmoМерки.PropertyType = typeof(long);
            this.Автоинкремент_vmoМерки.SearchCondition.OwnerComponent = this.Автоинкремент_vmoМерки;
            this.Автоинкремент_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент_vmoМерки.Visible = false;
            // 
            // ЭтоГруппа_vmoМерки
            // 
            this.ЭтоГруппа_vmoМерки.AutoGenerated = true;
            this.ЭтоГруппа_vmoМерки.Caption = "ЭтоГруппа";
            this.ЭтоГруппа_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЭтоГруппа_vmoМерки.Name = "ЭтоГруппа";
            this.ЭтоГруппа_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа_vmoМерки.PropertyType = typeof(bool);
            this.ЭтоГруппа_vmoМерки.SearchCondition.OwnerComponent = this.ЭтоГруппа_vmoМерки;
            this.ЭтоГруппа_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа_vmoМерки.Visible = false;
            // 
            // ИдентификаторРодителя_vmoМерки
            // 
            this.ИдентификаторРодителя_vmoМерки.AutoGenerated = true;
            this.ИдентификаторРодителя_vmoМерки.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторРодителя_vmoМерки.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя_vmoМерки.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя_vmoМерки.SearchCondition.OwnerComponent = this.ИдентификаторРодителя_vmoМерки;
            this.ИдентификаторРодителя_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя_vmoМерки.Visible = false;
            // 
            // Уровень_vmoМерки
            // 
            this.Уровень_vmoМерки.AutoGenerated = true;
            this.Уровень_vmoМерки.Caption = "Уровень";
            this.Уровень_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Уровень_vmoМерки.Name = "Уровень";
            this.Уровень_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень_vmoМерки.PropertyType = typeof(byte);
            this.Уровень_vmoМерки.SearchCondition.OwnerComponent = this.Уровень_vmoМерки;
            this.Уровень_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень_vmoМерки.Visible = false;
            // 
            // ПрефиксКода_vmoМерки
            // 
            this.ПрефиксКода_vmoМерки.AutoGenerated = true;
            this.ПрефиксКода_vmoМерки.Caption = "ПрефиксКода";
            this.ПрефиксКода_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПрефиксКода_vmoМерки.Name = "ПрефиксКода";
            this.ПрефиксКода_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода_vmoМерки.PropertyType = typeof(string);
            this.ПрефиксКода_vmoМерки.SearchCondition.OwnerComponent = this.ПрефиксКода_vmoМерки;
            this.ПрефиксКода_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода_vmoМерки.Visible = false;
            // 
            // НомерКода_vmoМерки
            // 
            this.НомерКода_vmoМерки.AutoGenerated = true;
            this.НомерКода_vmoМерки.CalcTotal = false;
            this.НомерКода_vmoМерки.Caption = "НомерКода";
            this.НомерКода_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерКода_vmoМерки.Name = "НомерКода";
            this.НомерКода_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода_vmoМерки.PropertyType = typeof(long);
            this.НомерКода_vmoМерки.SearchCondition.OwnerComponent = this.НомерКода_vmoМерки;
            this.НомерКода_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода_vmoМерки.Visible = false;
            // 
            // Код_vmoМерки
            // 
            this.Код_vmoМерки.AutoGenerated = true;
            this.Код_vmoМерки.Caption = "Код";
            this.Код_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Код_vmoМерки.Name = "Код";
            this.Код_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код_vmoМерки.PropertyType = typeof(string);
            this.Код_vmoМерки.SearchCondition.OwnerComponent = this.Код_vmoМерки;
            this.Код_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование_vmoМерки
            // 
            this.Наименование_vmoМерки.AutoGenerated = true;
            this.Наименование_vmoМерки.Caption = "Наименование";
            this.Наименование_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Наименование_vmoМерки.Name = "Наименование";
            this.Наименование_vmoМерки.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование_vmoМерки.PropertyType = typeof(string);
            this.Наименование_vmoМерки.SearchCondition.OwnerComponent = this.Наименование_vmoМерки;
            this.Наименование_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента_vmoМерки
            // 
            this.СостояниеДокумента_vmoМерки.AutoGenerated = true;
            this.СостояниеДокумента_vmoМерки.Caption = "СостояниеДокумента";
            this.СостояниеДокумента_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СостояниеДокумента_vmoМерки.Name = "СостояниеДокумента";
            this.СостояниеДокумента_vmoМерки.NSGType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoМерки.PropertyType = typeof(TechControl.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента_vmoМерки.SearchCondition.OwnerComponent = this.СостояниеДокумента_vmoМерки;
            this.СостояниеДокумента_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватТалии
            // 
            this.ОбхватТалии.AutoGenerated = true;
            this.ОбхватТалии.CalcTotal = false;
            this.ОбхватТалии.Caption = "ОбхватТалии";
            this.ОбхватТалии.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватТалии.Name = "ОбхватТалии";
            this.ОбхватТалии.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватТалии.PropertyType = typeof(decimal);
            this.ОбхватТалии.SearchCondition.OwnerComponent = this.ОбхватТалии;
            this.ОбхватТалии.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Рост
            // 
            this.Рост.AutoGenerated = true;
            this.Рост.CalcTotal = false;
            this.Рост.Caption = "Рост";
            this.Рост.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Рост.Name = "Рост";
            this.Рост.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Рост.PropertyType = typeof(decimal);
            this.Рост.SearchCondition.OwnerComponent = this.Рост;
            this.Рост.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватБедер
            // 
            this.ОбхватБедер.AutoGenerated = true;
            this.ОбхватБедер.CalcTotal = false;
            this.ОбхватБедер.Caption = "ОбхватБедер";
            this.ОбхватБедер.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватБедер.Name = "ОбхватБедер";
            this.ОбхватБедер.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватБедер.PropertyType = typeof(decimal);
            this.ОбхватБедер.SearchCondition.OwnerComponent = this.ОбхватБедер;
            this.ОбхватБедер.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // БоковаяДлинаБрюк
            // 
            this.БоковаяДлинаБрюк.AutoGenerated = true;
            this.БоковаяДлинаБрюк.CalcTotal = false;
            this.БоковаяДлинаБрюк.Caption = "БоковаяДлинаБрюк";
            this.БоковаяДлинаБрюк.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.БоковаяДлинаБрюк.Name = "БоковаяДлинаБрюк";
            this.БоковаяДлинаБрюк.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.БоковаяДлинаБрюк.PropertyType = typeof(decimal);
            this.БоковаяДлинаБрюк.SearchCondition.OwnerComponent = this.БоковаяДлинаБрюк;
            this.БоковаяДлинаБрюк.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДлинаБрюкПоВнутреннемуШву
            // 
            this.ДлинаБрюкПоВнутреннемуШву.AutoGenerated = true;
            this.ДлинаБрюкПоВнутреннемуШву.CalcTotal = false;
            this.ДлинаБрюкПоВнутреннемуШву.Caption = "ДлинаБрюкПоВнутреннемуШву";
            this.ДлинаБрюкПоВнутреннемуШву.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДлинаБрюкПоВнутреннемуШву.Name = "ДлинаБрюкПоВнутреннемуШву";
            this.ДлинаБрюкПоВнутреннемуШву.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДлинаБрюкПоВнутреннемуШву.PropertyType = typeof(decimal);
            this.ДлинаБрюкПоВнутреннемуШву.SearchCondition.OwnerComponent = this.ДлинаБрюкПоВнутреннемуШву;
            this.ДлинаБрюкПоВнутреннемуШву.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватШеи
            // 
            this.ОбхватШеи.AutoGenerated = true;
            this.ОбхватШеи.CalcTotal = false;
            this.ОбхватШеи.Caption = "ОбхватШеи";
            this.ОбхватШеи.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватШеи.Name = "ОбхватШеи";
            this.ОбхватШеи.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватШеи.PropertyType = typeof(decimal);
            this.ОбхватШеи.SearchCondition.OwnerComponent = this.ОбхватШеи;
            this.ОбхватШеи.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДлинаРукава
            // 
            this.ДлинаРукава.AutoGenerated = true;
            this.ДлинаРукава.CalcTotal = false;
            this.ДлинаРукава.Caption = "ДлинаРукава";
            this.ДлинаРукава.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДлинаРукава.Name = "ДлинаРукава";
            this.ДлинаРукава.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДлинаРукава.PropertyType = typeof(decimal);
            this.ДлинаРукава.SearchCondition.OwnerComponent = this.ДлинаРукава;
            this.ДлинаРукава.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДлинаСтопы
            // 
            this.ДлинаСтопы.AutoGenerated = true;
            this.ДлинаСтопы.CalcTotal = false;
            this.ДлинаСтопы.Caption = "ДлинаСтопы";
            this.ДлинаСтопы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ДлинаСтопы.Name = "ДлинаСтопы";
            this.ДлинаСтопы.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ДлинаСтопы.PropertyType = typeof(decimal);
            this.ДлинаСтопы.SearchCondition.OwnerComponent = this.ДлинаСтопы;
            this.ДлинаСтопы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватГруди
            // 
            this.ОбхватГруди.AutoGenerated = true;
            this.ОбхватГруди.CalcTotal = false;
            this.ОбхватГруди.Caption = "ОбхватГруди";
            this.ОбхватГруди.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватГруди.Name = "ОбхватГруди";
            this.ОбхватГруди.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватГруди.PropertyType = typeof(decimal);
            this.ОбхватГруди.SearchCondition.OwnerComponent = this.ОбхватГруди;
            this.ОбхватГруди.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОбхватГоловы
            // 
            this.ОбхватГоловы.AutoGenerated = true;
            this.ОбхватГоловы.CalcTotal = false;
            this.ОбхватГоловы.Caption = "ОбхватГоловы";
            this.ОбхватГоловы.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ОбхватГоловы.Name = "ОбхватГоловы";
            this.ОбхватГоловы.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ОбхватГоловы.PropertyType = typeof(decimal);
            this.ОбхватГоловы.SearchCondition.OwnerComponent = this.ОбхватГоловы;
            this.ОбхватГоловы.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель_vmoМерки
            // 
            this.Родитель_vmoМерки.AutoGenerated = true;
            this.Родитель_vmoМерки.Caption = "Родитель";
            this.Родитель_vmoМерки.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель_vmoМерки.Name = "Родитель";
            this.Родитель_vmoМерки.NSGType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.Мерки);
            this.Родитель_vmoМерки.PropertyType = typeof(TechControl.Метаданные.УчетСпецодеждыИСИЗ.Мерки);
            this.Родитель_vmoМерки.SearchCondition.OwnerComponent = this.Родитель_vmoМерки;
            this.Родитель_vmoМерки.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ФизЛицаФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 610);
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
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаРазмеров)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoМатЦенности)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДокументы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpОсновные.ResumeLayout(false);
            this.tpОсновные.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput23)).EndInit();
            this.gBДаты.ResumeLayout(false);
            this.gBДаты.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput7)).EndInit();
            this.tpДокументы.ResumeLayout(false);
            this.tpРазмеры.ResumeLayout(false);
            this.tpМерки.ResumeLayout(false);
            this.tpМерки.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbЗаполнитьТаблицуРазмеров)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoМерки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpСовмещаемыеДолжности.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoТаблицаДолжностей)).EndInit();
            this.tpМатЦенности.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NsgIGrid nsgIGrid1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TabPage tpОсновные;
        protected System.Windows.Forms.TabPage tpРазмеры;
        protected NsgInput nsgInput1;
        protected NsgInput nsgInput2;
        protected NsgInput nsgInput3;
        protected NsgInput nsgInput4;
        protected NsgInput nsgInput5;
        protected NsgInput nsgInput6;
        protected System.Windows.Forms.TabPage tpМерки;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected NsgInput nsgInput8;
        protected System.Windows.Forms.Label label8;
        protected NsgInput nsgInput7;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label16;
        protected NsgInput nsgInput16;
        protected System.Windows.Forms.Label label15;
        protected NsgInput nsgInput15;
        protected System.Windows.Forms.Label label14;
        protected NsgInput nsgInput14;
        protected System.Windows.Forms.Label label13;
        protected NsgInput nsgInput13;
        protected System.Windows.Forms.Label label12;
        protected NsgInput nsgInput12;
        protected System.Windows.Forms.Label label11;
        protected NsgInput nsgInput11;
        protected System.Windows.Forms.Label label10;
        protected NsgInput nsgInput10;
        protected NsgInput nsgInput9;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label18;
        protected NsgInput nsgInput17;
        private System.Windows.Forms.TabControl tabControl1;
        private NsgVisualMultipleObject vmoТаблицаРазмеров;
        private NsgVisualMultipleObject vmoМерки;
        protected System.Windows.Forms.Label label19;
        protected NsgInput nsgInput18;
        protected NsgSoft.Design.NsgButton nbЗаполнитьТаблицуРазмеров;
        private System.Windows.Forms.TabPage tpСовмещаемыеДолжности;
        protected NsgIGrid nsgIGrid2;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаДолжностей;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаДолжностей;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoТаблицаДолжностей;
        private NsgColumnDescriptor.Int64 НомерСтроки_vmoТаблицаДолжностей;
        protected Должности.ColumnDescriptor Должность_vmoТаблицаДолжностей;
        protected NsgInput nsgInput19;
        protected System.Windows.Forms.Label label20;
        private NsgVisualMultipleObject vmoТаблицаДолжностей;
        private System.Windows.Forms.TabPage tpМатЦенности;
        protected Учет.Номенклатура.ColumnDescriptor Номенклатура_vmoМатЦенности;
        private Учет.Размеры.ColumnDescriptor Размер_vmoМатЦенности;
        private УчетСпецодеждыИСИЗ.КомплектыСпецодежды.ColumnDescriptor Комплект_vmoМатЦенности;
        private NsgColumnDescriptor.Int64 Количество_vmoМатЦенности;
        private NsgVisualMultipleObject vmoМатЦенности;
        private NsgIGrid nsgIGrid3;
        private System.Windows.Forms.GroupBox gBДаты;
        protected NsgInput nsgInput20;
        protected System.Windows.Forms.Label lblРождение;
        protected NsgInput nsgInput23;
        protected System.Windows.Forms.Label label23;
        protected NsgInput nsgInput22;
        protected System.Windows.Forms.Label label22;
        protected NsgInput nsgInput21;
        protected System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tpДокументы;
        private NsgVisualMultipleObject vmoДокументы;
        private NsgIGrid nsgIGrid4;
        private System.Windows.Forms.GroupBox groupBox1;
        protected NsgInput nsgInput26;
        protected System.Windows.Forms.Label label26;
        protected NsgInput nsgInput25;
        protected System.Windows.Forms.Label label25;
        protected NsgInput nsgInput24;
        protected System.Windows.Forms.Label label24;
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
        private NsgColumnDescriptor.String Фамилия;
        private NsgColumnDescriptor.String Отчество;
        private NsgColumnDescriptor.String НомерТелефона;
        private Должности.ColumnDescriptor Должность;
        private NsgColumnDescriptor.String Имя;
        private СтатусСотрудника.ColumnDescriptor Статус;
        private NsgColumnDescriptor.String ИдентификаторСтрока;
        private NsgColumnDescriptor.Int64 IDСотрудника;
        private Учет.Размеры.ColumnDescriptor Размер;
        private СлужебныеСправочники.АккаунтПользователя.ColumnDescriptor АккаунтПользователя;
        private NsgColumnDescriptor.String ТабельныйНомер;
        private NsgColumnDescriptor.DateTime ДатаРождения;
        private NsgColumnDescriptor.DateTime ДатаПриемаНаРаботу;
        private NsgColumnDescriptor.DateTime ДатаУвольнения;
        private _SystemTables.МониторингФизЛицаТаблицаРазмеров.ColumnDescriptor ТаблицаРазмеров;
        private Объекты.ColumnDescriptor ОбъектВыдачиСпецодежды;
        private Объекты.ColumnDescriptor ОсновнойОбъект;
        private NsgColumnDescriptor.String ЗагрузочныйИдентификатор;
        private УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды.ColumnDescriptor ДокументКонтроляСпецодежды;
        private Подразделения.ColumnDescriptor Подразделение;
        private _SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.ColumnDescriptor ТаблицаСовмещаемыхДолжностей;
        private Картинки.ColumnDescriptor КартинкаПодпись;
        private NsgColumnDescriptor.String ФИО;
        private NsgColumnDescriptor.String ФИОРодительныйПадеж;
        protected ФизЛица.ColumnDescriptor Родитель;
        private NsgColumnDescriptor.Guid Идентификатор_vmoТаблицаРазмеров;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoТаблицаРазмеров;
        private NsgColumnDescriptor.MultipleObject Владелец;
        private NsgColumnDescriptor.Int64 НомерСтроки;
        private Учет.ВидСвойствНоменклатуры.ColumnDescriptor ВидСвойствНоменклатуры;
        private Учет.Размеры.ColumnDescriptor Размер_vmoТаблицаРазмеров;
        protected УчетСпецодеждыИСИЗ.ВидыРазмернойСетки.ColumnDescriptor ВидРазмернойСетки;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoДокументы;
        private NsgColumnDescriptor.Guid Идентификатор_vmoДокументы;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoДокументы;
        private NsgColumnDescriptor.Boolean ЭтоГруппа_vmoДокументы;
        private NsgColumnDescriptor.Guid ИдентификаторРодителя_vmoДокументы;
        private NsgColumnDescriptor.Byte Уровень_vmoДокументы;
        private NsgColumnDescriptor.String ПрефиксКода_vmoДокументы;
        private NsgColumnDescriptor.Int64 НомерКода_vmoДокументы;
        private NsgColumnDescriptor.String Код_vmoДокументы;
        private NsgColumnDescriptor.String Наименование_vmoДокументы;
        private Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента_vmoДокументы;
        private УчетСотрудников.ВидыДокументов.ColumnDescriptor ВидДокумента;
        private NsgColumnDescriptor.String Серия;
        private NsgColumnDescriptor.String КемВыдан;
        private NsgColumnDescriptor.String КодПодразделения;
        private NsgColumnDescriptor.String Номер;
        private NsgColumnDescriptor.DateTime ДатаВыдачи;
        private NsgColumnDescriptor.DateTime ДействуетДо;
        private NsgColumnDescriptor.String СсылкаНаДокумент;
        protected УчетСотрудников.ДокументыФизЛиц.ColumnDescriptor Родитель_vmoДокументы;
        private NsgColumnDescriptor.MultipleObject Владелец_vmoМерки;
        private NsgColumnDescriptor.Guid Идентификатор_vmoМерки;
        private NsgColumnDescriptor.Int64 Автоинкремент_vmoМерки;
        private NsgColumnDescriptor.Boolean ЭтоГруппа_vmoМерки;
        private NsgColumnDescriptor.Guid ИдентификаторРодителя_vmoМерки;
        private NsgColumnDescriptor.Byte Уровень_vmoМерки;
        private NsgColumnDescriptor.String ПрефиксКода_vmoМерки;
        private NsgColumnDescriptor.Int64 НомерКода_vmoМерки;
        private NsgColumnDescriptor.String Код_vmoМерки;
        private NsgColumnDescriptor.String Наименование_vmoМерки;
        private Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента_vmoМерки;
        private NsgColumnDescriptor.Decimal ОбхватТалии;
        private NsgColumnDescriptor.Decimal Рост;
        private NsgColumnDescriptor.Decimal ОбхватБедер;
        private NsgColumnDescriptor.Decimal БоковаяДлинаБрюк;
        private NsgColumnDescriptor.Decimal ДлинаБрюкПоВнутреннемуШву;
        private NsgColumnDescriptor.Decimal ОбхватШеи;
        private NsgColumnDescriptor.Decimal ДлинаРукава;
        private NsgColumnDescriptor.Decimal ДлинаСтопы;
        private NsgColumnDescriptor.Decimal ОбхватГруди;
        private NsgColumnDescriptor.Decimal ОбхватГоловы;
        protected УчетСпецодеждыИСИЗ.Мерки.ColumnDescriptor Родитель_vmoМерки;
    }
}
        
    
