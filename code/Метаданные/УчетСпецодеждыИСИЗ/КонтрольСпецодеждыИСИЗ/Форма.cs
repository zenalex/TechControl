using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using NsgSoft.ReportData.Extensions;
using NsgSoft.ReportDatabase;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Сервис;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class КонтрольСпецодеждыИСИЗФорма
    {
        private bool _первыйЗапуск;

        public КонтрольСпецодеждыИСИЗФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            
            if (nsgVisualMultipleObject.Data.CurrentRow == null)
            {
                nsgVisualMultipleObject.Data.CurrentRow = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
            }

            _первыйЗапуск = true;

            vmoСписокСпецодежды.Data.BeginUpdateData();
            vmoСписокСпецодежды.Data.MemoryTable.Clear();
            vmoСписокСпецодежды.Data.UpdateDataSync(this);

            var user = (NsgSettings.CurrentUser as Пользователи).Сотрудник;
            var cmp = Объект.SearchCondition;
            cmp.Clear();
            cmp.Add(Объекты.Names.Ответственный, user);
            cmp.Add(Объекты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);


            var cmpСпецодежда = Номенклатура_vmoСписокСпецодежды.SearchCondition;
            cmpСпецодежда.Clear();
            cmpСпецодежда.Add(Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.Спецодежда);
            cmpСпецодежда.Add(Номенклатура.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var отправитель = Объекты.Новый();
            if (отправитель.Find(cmp))
            {
                Объект.Value = отправитель;
            }
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьТаблицуКомплектов();
            ЗаполнитьТаблицуСпецодежды();
            ЗаполнитьОстатки();
            РаскраситьЯчейки();
        }

        private void ЗаполнитьТаблицуСпецодежды() 
        {
            if (!_первыйЗапуск)
            {
                vmoСписокСпецодежды.Data.BeginUpdateData();
                vmoСписокСпецодежды.Data.MemoryTable.Clear();
                var сотрудник = Сотрудник.Value;
                if (!сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                    vmoСписокСпецодежды.Data.UpdateDataSync(this);
                    return;
                }

                РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
                рег.Сотрудник = сотрудник;
                var остатки = рег.GetRests();

                foreach (var комплект in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
                {
                    foreach (var строкаСпецодежды in комплект.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
                    {
                        var nom = строкаСпецодежды.НоменклатураСпецодеждыИСИЗ;
                        var компл = комплект.КомплектСпецодежды;

                        var row = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
                        row[Номенклатура_vmoСписокСпецодежды].Value = nom;
                        row[Комплект_vmoСписокСпецодежды].Value = компл;
                        row[Размер_vmoСписокСпецодежды].Value = сотрудник.ПолучитьРазмер(nom);
                        var ужеВыдано = 0;
                        var всегоЗаконченСрок = 0;

                        if (остатки.AllRows.Any(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                            && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                        {

                            foreach (var item in остатки.AllRows.Where(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                            && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                            {
                                ужеВыдано++;
                                int срокЭксплуатации = nom.ПланАмортизации.Selected ? (int)nom.ПланАмортизации.СрокАмортизацииМес : 0;
                                if (срокЭксплуатации != 0 && item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths(срокЭксплуатации) < DateTime.Now)
                                {
                                    всегоЗаконченСрок++;
                                }
                                остатки.DeleteRow(item);
                            }

                            row[КоличествоВыданоРанее_vmoСписокСпецодежды].Value = ужеВыдано;
                            row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;
                        }

                        var кВыдаче = строкаСпецодежды.Количество - (ужеВыдано - всегоЗаконченСрок);
                        row[ТребуетсяПоКомплекту_vmoСписокСпецодежды].Value = строкаСпецодежды.Количество;

                        row.Post();
                    }
                }

                foreach (var строкаСовмещения in сотрудник.ТаблицаСовмещаемыхДолжностей.AllRows)
                {
                    foreach (var строкаПрочее in строкаСовмещения.Должность.ТаблицаНеобязательнойНоменклатуры.AllRows)
                    {
                        var nom = строкаПрочее.Номенклатура;
                        var компл = КомплектыСпецодежды.Прочее;
                        var размер = сотрудник.ПолучитьРазмер(nom);

                        var cmpПрочее = new NsgCompare();
                        cmpПрочее.Add(Номенклатура_vmoСписокСпецодежды.Name, nom);
                        cmpПрочее.Add(Комплект_vmoСписокСпецодежды.Name, компл);
                        cmpПрочее.Add(Размер_vmoСписокСпецодежды.Name, размер);
                        var строкаПрочего = vmoСписокСпецодежды.Data.MemoryTable.FindRow(cmpПрочее);

                        NsgMemoryTableRow row = null;
                        var ужеВыдано = 0;
                        var всегоЗаконченСрок = 0;
                        if (строкаПрочего != null)
                        {
                            row = строкаПрочего;
                            ужеВыдано = (int)строкаПрочего[КоличествоВыданоРанее_vmoСписокСпецодежды].ToInt();
                            всегоЗаконченСрок = (int)строкаПрочего[ВсегоЗаконченСрок_vmoСписокСпецодежды].ToInt();
                        }
                        else
                        {
                            row = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
                        }

                        row[Номенклатура_vmoСписокСпецодежды].Value = nom;
                        row[Комплект_vmoСписокСпецодежды].Value = компл;
                        row[Размер_vmoСписокСпецодежды].Value = размер;

                        if (остатки.AllRows.Any(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                            && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                        {

                            foreach (var item in остатки.AllRows.Where(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                            && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                            {
                                ужеВыдано++;
                                int срокЭксплуатации = nom.ПланАмортизации.Selected ? (int)nom.ПланАмортизации.СрокАмортизацииМес : 0;
                                if (срокЭксплуатации != 0 && item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths(срокЭксплуатации) < DateTime.Now)
                                {
                                    всегоЗаконченСрок++;
                                }
                                остатки.DeleteRow(item);
                            }

                            row[КоличествоВыданоРанее_vmoСписокСпецодежды].Value = ужеВыдано;
                            row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;
                        }

                        var кВыдаче = строкаПрочее.Количество - (ужеВыдано - всегоЗаконченСрок);
                        row[ТребуетсяПоКомплекту_vmoСписокСпецодежды].Value = строкаПрочее.Количество;

                        row.Post();
                    }
                }

                foreach (var строкаОстатков in остатки.AllRows)
                {
                    var nom = строкаОстатков[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                    var компл = строкаОстатков[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;

                    var row = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoСписокСпецодежды].Value = nom;
                    row[Комплект_vmoСписокСпецодежды].Value = компл;

                    var ужеВыдано = 0;
                    var всегоЗаконченСрок = 0;
                    ужеВыдано++;

                    int срокЭксплуатации = nom.ПланАмортизации.Selected ? (int)nom.ПланАмортизации.СрокАмортизацииМес : 0;
                    if (срокЭксплуатации != 0 && строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths(срокЭксплуатации) > DateTime.Now)
                    {
                        всегоЗаконченСрок++;
                    }

                    row[КоличествоВыданоРанее_vmoСписокСпецодежды].Value = ужеВыдано;
                    row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;

                    row.Post();
                }

                vmoСписокСпецодежды.Data.UpdateDataSync(this);
            }
            _первыйЗапуск = false;
            
        }

        private void nbВыдать_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var сотрудник = Сотрудник.Value;
            var отправитель = Объект.Value;
            if (!сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                vmoСписокСпецодежды.Data.UpdateDataSync(this);
                return;
            }

            if (!отправитель.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите выдающий объект.");
                vmoСписокСпецодежды.Data.UpdateDataSync(this);
                return;
            }

            try
            {
                NsgSettings.BeginTransaction();
                var перемещение = ПеремещениеСпецодежды.Новый();
                перемещение.New();
                перемещение.Отправитель = отправитель;
                перемещение.Получатель = сотрудник;
                перемещение.ДатаНачалаЭксплуатации = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : перемещение.ДатаДокумента;
                foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[КоличествоВыдать_vmoСписокСпецодежды].ToInt() > 0))
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    var компл = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                    var количество = item[КоличествоВыдать_vmoСписокСпецодежды].ToInt();

                    var строка = перемещение.Таблица.NewRow();
                    строка.НоменклатураСпецодеждыИСИЗ = nom;
                    строка.КомплектСпецодежды = компл;
                    строка.Размер = размер;
                    строка.Количество = количество;
                    строка.Post();

                    var cmp = new NsgCompare();
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Номенклатура, nom);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Размер, размер);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Комплект, компл);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Количество, количество, NsgComparison.LessOrEqual);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.Индивидуальная, false);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.Статус, Перечисления.СтатусыЗаявокНаСотрудника.ГотоваКВыдаче);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.Сотрудник, сотрудник);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.Объект, отправитель);
                    cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    var строкиЗнС = УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Новый().FindAll(cmp);
                    if (строкиЗнС.Length > 0)
                    {
                        var всеЗнС = строкиЗнС.Select(x => x.Владелец as ЗаявкаНаСотрудника).Distinct().ToArray();
                        foreach (var заявка in всеЗнС)
                        {
                            заявка.Edit();
                            заявка.ЗавершитьЗаявку(DateTime.Now);
                            заявка.Post();
                        }
                    }
                }
                перемещение.Handle();

                NsgSettings.MainForm.ShowObject(перемещение, this);
                NsgSettings.CommitTransaction();
            }
            catch (Exception ee)
            {
                NsgSettings.RollbackTransaction();
                NsgSettings.MainForm.ShowMessage($"Ошибка выдачи {ee.Message}");
            }
            
            //ЗаполнитьТаблицуКомплектов();
            ЗаполнитьТаблицуСпецодежды();
            ЗаполнитьОстатки();
            РаскраситьЯчейки();
        }

        private void ЗаполнитьОстатки() 
        {
            if (Объект.Value.Selected && vmoСписокСпецодежды.Data.MemoryTable.Count > 0 && Сотрудник.Value.Selected)
            {
                var reg = ОстаткиНоменклатуры.Новый();
                var резервНаСотрудника = РегистрРезерваЗнС.Новый();
                var резервПоПоставщикам = РегистрРезерваЗП.Новый();
                var сотрудник = Сотрудник.Value;
                var объект = Объект.Value;
                foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    
                    if (nom != null && nom.Selected)
                    {
                        var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                        var комплект = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                        //reg.New();
                        reg.Номенклатура = nom;
                        резервНаСотрудника.Номенклатура = nom;
                        резервНаСотрудника.Комплект = комплект;
                        резервНаСотрудника.Сотрудник = сотрудник;
                        резервПоПоставщикам.Номенклатура = nom;
                        резервПоПоставщикам.Комплект = комплект;
                        if (размер != null && размер.Selected)
                        {
                            reg.Размер = размер;
                            резервНаСотрудника.Размер = размер;
                            резервПоПоставщикам.Размер = размер;
                        }
                        reg.Объект = объект;
                        резервНаСотрудника.Объект = объект;
                        резервПоПоставщикам.Объект = объект;
                        if (nom.Поставщик.Selected)
                        {
                            резервПоПоставщикам.Поставщик = nom.Поставщик;
                        }

                        reg.GetRest();
                        item[КоличествоНаСкладе_vmoСписокСпецодежды].Value = reg.Количество;

                        резервНаСотрудника.GetRest();
                        item[УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды].Value = резервНаСотрудника.Количество;

                        резервПоПоставщикам.GetRest();
                        item[ЗаказаноУПоставщикаКоличество_vmoСписокСпецодежды].Value = резервПоПоставщикам.Количество;
                    }
                }
            }
        }

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            ЗаполнитьТаблицуКомплектов();
            ЗаполнитьТаблицуСпецодежды();
            ЗаполнитьОстатки();
            РаскраситьЯчейки();
        }

        private void ЗаполнитьТаблицуКомплектов() 
        {
            if (!_первыйЗапуск)
            {
                vmoКомплекты.Data.BeginUpdateData();
                vmoКомплекты.Data.MemoryTable.Clear();

                var сотрудник = Сотрудник.Value;
                if (!сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                    vmoКомплекты.Data.UpdateDataSync(this);
                    return;
                }

                foreach (var item in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
                {
                    var row = vmoКомплекты.Data.MemoryTable.NewRow();
                    row[Комплект_vmoКомплекты].Value = item.КомплектСпецодежды;
                    row[Выбрано_vmoКомплекты].Value = true;
                    row.Post();
                }

                var rowПрочее = vmoКомплекты.Data.MemoryTable.NewRow();
                rowПрочее[Комплект_vmoКомплекты].Value = КомплектыСпецодежды.Прочее;
                rowПрочее[Выбрано_vmoКомплекты].Value = true;
                rowПрочее.Post();

                vmoКомплекты.Data.UpdateDataSync(this);
            }
            //_первыйЗапуск = false;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpОформлениеЗаказов)
            {
                rdbОбщийЗаказПоставщикам.Checked = true;
            }

            if (tabControl1.SelectedTab == tpГотовыКВыдаче)
            {
                ЗаполнитьГотовыеКВыдаче();
                РаскраситьГотовыеКВыдаче();
            }
        }

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Размер_vmoСписокСпецодежды.Name)
            {
                var номенклатура = e.RowObject[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                if (!номенклатура.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Необходимо выбрать номенклатуру");
                    e.Cancel = true;
                    return;
                }
                else
                {
                    var сотрудник = Сотрудник.Value;
                    var объект = Объект.Value;
                    if (номенклатура.Selected && сотрудник.Selected && объект.Selected)
                    {
                        DialogResult dialogResult = DialogResult.None;
                        int количество = 0;
                        Размеры размер = Размеры.Новый();
                        Invoke(new MethodInvoker(() =>
                        {
                            var iФормаВыбораРазмера = new ДопФормы.ФормаВыбораРазмера(номенклатура, сотрудник, объект);
                            iФормаВыбораРазмера.ShowDialog(this);
                            dialogResult = iФормаВыбораРазмера.DialogResult;
                            if (dialogResult != DialogResult.OK) 
                            {
                                e.Cancel = false;
                                return;
                            }
                            количество = (int)iФормаВыбораРазмера.КоличествоВыбрано;
                            размер = iФормаВыбораРазмера.ВыбранныйРазмер;
                        }));

                        if (размер.Selected)
                        {
                            e.RowObject[Размер_vmoСписокСпецодежды].Value = размер;
                            e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды].Value = количество;
                            e.Cancel = true;
                            РаскраситьЯчейки();
                        }
                    }
                }
            }

            if (e.ColumnName == Выдать_vmoСписокСпецодежды.Name)
            {
                var количествоНаСкладе = e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды.Name].ToInt();
                var количествоТребуемое = e.RowObject[ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name].ToInt();
                if (количествоНаСкладе == 0)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (e.ColumnName == Заказать_vmoСписокСпецодежды.Name)
            {
                var количествоЗаказаноНаСотрудника = e.RowObject[УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Name].ToInt();
                var количествоТребуемое = e.RowObject[ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name].ToInt();
                if (количествоЗаказаноНаСотрудника >= количествоТребуемое)
                {
                    NsgSettings.MainForm.ShowMessage("Уже заказано на сотрудника");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Размер_vmoСписокСпецодежды.Name || e.ColumnName == Номенклатура_vmoСписокСпецодежды.Name)
            {
                if (!Объект.Value.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать объект выдачи спецодежды");
                }
                else
                {
                    ЗаполнитьОстатки();
                }
            }

            if (e.ColumnName == КоличествоВыдать_vmoСписокСпецодежды.Name)
            {
                var количествоНаСкладе = e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды.Name].ToInt();
                var количествоВыдаваемое = e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].ToInt();
                if (количествоНаСкладе <= количествоВыдаваемое)
                {
                    e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = количествоНаСкладе;
                }
            }

            if (e.ColumnName == Выдать_vmoСписокСпецодежды.Name)
            {
                if (e.RowObject[Выдать_vmoСписокСпецодежды.Name].ToBoolean())
                {
                    var количествоНаСкладе = e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды.Name].ToInt();
                    var количествоТребуемое = e.RowObject[ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name].ToInt();
                    if (количествоНаСкладе < количествоТребуемое)
                    {
                        e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = количествоНаСкладе;
                    }
                    else
                    {
                        e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = количествоТребуемое;
                    }

                    e.RowObject[Заказать_vmoСписокСпецодежды.Name].Value = false;
                    e.RowObject[КоличествоЗаказать_vmoСписокСпецодежды.Name].Value = 0;
                }
                else
                {
                    e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = 0;
                }

            }

            if (e.ColumnName == Заказать_vmoСписокСпецодежды.Name)
            {
                if (e.RowObject[Заказать_vmoСписокСпецодежды.Name].ToBoolean())
                {
                    var количествоЗаказаноНаСотрудника = e.RowObject[УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Name].ToInt();
                    var количествоТребуемое = e.RowObject[ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name].ToInt();

                    e.RowObject[КоличествоЗаказать_vmoСписокСпецодежды.Name].Value = количествоТребуемое - количествоЗаказаноНаСотрудника;

                    e.RowObject[Выдать_vmoСписокСпецодежды.Name].Value = false;
                    e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = 0;
                }
                else
                {
                    e.RowObject[КоличествоЗаказать_vmoСписокСпецодежды.Name].Value = 0;
                }

            }

            if (e.ColumnName == КоличествоЗаказать_vmoСписокСпецодежды.Name)
            {
                var количествоЗаказаноНаСотрудника = e.RowObject[УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды.Name].ToInt();
                var количествоТребуемое = e.RowObject[ТребуетсяПоКомплекту_vmoСписокСпецодежды.Name].ToInt();
                var колЗак = e.RowObject[КоличествоЗаказать_vmoСписокСпецодежды.Name].ToInt();
                if (количествоЗаказаноНаСотрудника != 0)
                {
                    if (колЗак > количествоЗаказаноНаСотрудника)
                    {
                        колЗак = колЗак - количествоЗаказаноНаСотрудника;
                    }
                    else
                    {
                        колЗак = 0;
                    }
                }
                else
                {
                    if (колЗак > количествоТребуемое)
                    {
                        колЗак = количествоТребуемое;
                    }
                }

                e.RowObject[Заказать_vmoСписокСпецодежды.Name].Value = колЗак != 0;

                if (e.RowObject[Заказать_vmoСписокСпецодежды.Name].ToBoolean())
                {
                    e.RowObject[Выдать_vmoСписокСпецодежды.Name].Value = false;
                    e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = 0;
                }
                else
                {
                    e.RowObject[КоличествоЗаказать_vmoСписокСпецодежды.Name].Value = 0;
                }

            }

            РаскраситьЯчейки();
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmp = new NsgCompare();
            cmp.Add(Сотрудники.Names.ДатаУвольнения, NsgService.MinDate);
            cmp.Add(Сотрудники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var всеСотрудники = Сотрудники.Новый().FindAll(cmp);

            if (всеСотрудники.Length > 0)
            {
                var cmpВидНоменклатуры = new NsgCompare();
                cmpВидНоменклатуры.Add(ВидСвойствНоменклатуры.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var всеВидыНоменклатуры = ВидСвойствНоменклатуры.Новый().FindAll(cmpВидНоменклатуры);

                string неЗаполненаМерка = "Не заполнена мерка";

                vmoСотрудники.Data.BeginUpdateData();
                vmoСотрудники.Data.MemoryTable.Clear();
                foreach (var сотрудник in всеСотрудники)
                {
                    if (!сотрудник.ПолучитьМерку(false, true).МеркаЗаполнена)
                    {
                        var row = vmoСотрудники.Data.MemoryTable.NewRow();
                        row[Сотрудник_vmoСотрудники].Value = сотрудник;
                        row[Подразделение_vmoСотрудники].Value = сотрудник.Подразделение;
                        row[Проблема_vmoСотрудники].Value = неЗаполненаМерка;
                        row.Post();
                    }
                    else
                    {
                        foreach (var вид in всеВидыНоменклатуры)
                        {
                            var cmpРазмерныеСетки = new NsgCompare();
                            cmpРазмерныеСетки.Add(ВидыРазмернойСетки.Names.ВидНоменклатуры, вид);
                            cmpРазмерныеСетки.Add(ВидыРазмернойСетки.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                            var всеРазмерныеСетки = ВидыРазмернойСетки.Новый().FindAll(cmpРазмерныеСетки);

                            foreach (var размернаяСетка in всеРазмерныеСетки)
                            {
                                var размер = сотрудник.ПолучитьРазмер(Номенклатура.Новый(), размернаяСетка, вид);
                                if (!размер.Selected)
                                {
                                    var row = vmoСотрудники.Data.MemoryTable.NewRow();
                                    row[Сотрудник_vmoСотрудники].Value = сотрудник;
                                    row[Подразделение_vmoСотрудники].Value = сотрудник.Подразделение;
                                    row[Проблема_vmoСотрудники].Value = $"Не найден подходящий размер для {вид} из {размернаяСетка}";
                                    row.Post();
                                }
                            }
                        }

                    }
                }
                vmoСотрудники.Data.UpdateDataSync(this);
            }
        }

        private void nsgIGrid3_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Выбрано_vmoКомплекты.Name)
            {
                НаложитьФильтрПоКомплектам();
                РаскраситьЯчейки();
            }
        }

        private void НаложитьФильтрПоКомплектам() 
        {
            var cmp = vmoСписокСпецодежды.Data.GetComparison(this);
            КомплектыСпецодежды[] выбранныеКомплекты = vmoКомплекты.Data.MemoryTable.AllRows
                .Where(x => x[Выбрано_vmoКомплекты].ToBoolean())
                .Select(x => x[Комплект_vmoКомплекты].ToReferent() as КомплектыСпецодежды)
                .ToArray();

            cmp.Clear();
            cmp.Add(Комплект_vmoСписокСпецодежды.Name, выбранныеКомплекты);

            vmoСписокСпецодежды.Data.UpdateDataSync(this);
        }

        private void vmoКомплекты_GetAvailableTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.Settings;
        }

        private void nbЗакупки_AsyncClick(object sender, DoWorkEventArgs e)
        {

        }

        private void nbСпецодежда_AsyncClick(object sender, DoWorkEventArgs e)
        {

        }

        private void nsgInput3_Selected(object sender, EventArgs e)
        {
            if (vmoСписокСпецодежды.Data.MemoryTable.Count > 0)
            {
                if (!Объект.Value.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать объект выдачи спецодежды");
                }
                else
                {
                    ЗаполнитьОстатки();
                    РаскраситьЯчейки();
                }
            }
        }

        private void РаскраситьЯчейки() 
        {
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.Rows)
            {
                var колНаСкладе = item[КоличествоНаСкладе_vmoСписокСпецодежды].ToInt();
                var колТреб = item[ТребуетсяПоКомплекту_vmoСписокСпецодежды].ToInt();
                if (колНаСкладе == 0)
                {
                    item[КоличествоНаСкладе_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Tomato);
                }
                else if (колНаСкладе < колТреб)
                {
                    item[КоличествоНаСкладе_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightYellow);
                }
                else
                {
                    item[КоличествоНаСкладе_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGreen);
                }

                var номенклатура = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                if (номенклатура != null && !номенклатура.Selected)
                {
                    item[Номенклатура_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Tomato);
                }
                else
                {
                    if (номенклатура.ТипНоменклатуры == ТипНоменклатуры.Спецодежда && номенклатура.ВидНоменклатуры.Selected && номенклатура.ВидРазмернойСетки.Selected)
                    {
                        if (размер != null && размер.Selected)
                        {
                            if (Сотрудник.Value.ПолучитьРазмер(номенклатура) != размер)
                            {
                                item[Размер_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightYellow);
                            }
                            else
                            {
                                item[Размер_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGreen);
                            }
                        }
                        else
                        {
                            item[Размер_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Tomato);
                        }
                    }
                }

                var количВыдать = item[КоличествоВыдать_vmoСписокСпецодежды].ToInt();
                if (количВыдать != 0 && колНаСкладе != 0)
                {
                    if (количВыдать <= колНаСкладе)
                    {
                        item[КоличествоВыдать_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGreen);
                    }
                    else
                    {
                        item[КоличествоВыдать_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightYellow);
                    }
                }
                else
                {
                    item[КоличествоВыдать_vmoСписокСпецодежды].ClearUserProperties();
                }

                
                var количЗаказать = item[КоличествоЗаказать_vmoСписокСпецодежды].ToInt();
                var колЗаказаноНаСотрудника = item[УжеЗаказаноНаСотрудникаКоличество_vmoСписокСпецодежды].ToInt();
                var колЗаказаноУПоставщика = item[ЗаказаноУПоставщикаКоличество_vmoСписокСпецодежды].ToInt();
                if (количЗаказать != 0)
                {
                    if (колЗаказаноНаСотрудника != 0)
                    {
                        item[КоличествоЗаказать_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightCoral);
                    }
                    else if (колЗаказаноУПоставщика != 0)
                    {
                        item[КоличествоЗаказать_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightYellow);
                    }
                    else
                    {
                        item[КоличествоЗаказать_vmoСписокСпецодежды].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGreen);
                    }
                }
                else
                {
                    item[КоличествоЗаказать_vmoСписокСпецодежды].ClearUserProperties();
                }
            }
        }

        private void nsgButton2_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var сотрудник = Сотрудник.Value;
            var отправитель = Объект.Value;
            if (!сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                return;
            }

            if (!отправитель.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект для заказа.");
                return;
            }

            var date = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : DateTime.Now;
            var список = vmoСписокСпецодежды.Data.MemoryTable.Rows.Where(x => x[Заказать_vmoСписокСпецодежды].ToBoolean()).ToArray();

            if (список.Length == 0)
            {
                NsgSettings.MainForm.ShowMessage("Не выбрано позиций для заказа.");
            }
            else
            {
                foreach (var item in список)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    var компл = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                    var контрагент = nom.Поставщик;
                    var количествоЗаказать = item[КоличествоЗаказать_vmoСписокСпецодежды].ToInt();

                    var заявка = ЗаявкаНаСотрудника.Новый();
                    заявка.New();
                    заявка.Контрагент = контрагент;
                    заявка.Индивидуальная = false;
                    заявка.Объект = отправитель;
                    заявка.Сотрудник = сотрудник;
                    заявка.Статус = Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения;

                    var строка = заявка.Таблица.NewRow();
                    строка.Номенклатура = nom;
                    строка.Размер = размер;
                    строка.Количество = количествоЗаказать;
                    строка.Комплект = компл;
                    строка.Цена = строка.Номенклатура.ПолучитьЦену(date);
                    строка.Post();

                    заявка.Handle();
                }
                NsgSettings.MainForm.ShowMessage("Заказ добавлен в общий заказ поставщику.");

                //ЗаполнитьТаблицуКомплектов();
                ЗаполнитьТаблицуСпецодежды();
                ЗаполнитьОстатки();
                РаскраситьЯчейки();
            }
        }

        private void nsgButton1_AsyncClick_1(object sender, DoWorkEventArgs e)
        {
            var сотрудник = Сотрудник.Value;
            var отправитель = Объект.Value;
            if (!сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                return;
            }

            if (!отправитель.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите выдающий объект.");
                return;
            }

            Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>> словарьДляЗаявки = new Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>>();
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[Заказать_vmoСписокСпецодежды].ToBoolean()))
            {
                var количествоЗаказать = (int)item[КоличествоЗаказать_vmoСписокСпецодежды].ToInt();
                
                if (количествоЗаказать > 0)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    var компл = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                    var контрагент = nom.Поставщик;

                    if (!словарьДляЗаявки.ContainsKey(контрагент))
                    {
                        словарьДляЗаявки[контрагент] = new List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>();
                    }

                    словарьДляЗаявки[контрагент].Add(new Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>(nom, компл, размер, количествоЗаказать));
                }
            }

            if (словарьДляЗаявки.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage("Все требующиеся позиции уже заказаны.");
            }
            else
            {
                var date = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : DateTime.Now;
                foreach (var поставщик in словарьДляЗаявки.Keys)
                {
                    var заявка = ЗаявкаНаСотрудника.Новый();
                    заявка.New();
                    заявка.Контрагент = поставщик;
                    заявка.Индивидуальная = true;
                    заявка.Объект = отправитель;
                    заявка.Сотрудник = сотрудник;

                    foreach (var массив in словарьДляЗаявки[поставщик])
                    {
                        var строка = заявка.Таблица.NewRow();
                        строка.Номенклатура = массив.Item1;
                        строка.Размер = массив.Item3;
                        строка.Количество = массив.Item4;
                        строка.Комплект = массив.Item2;
                        строка.Цена = строка.Номенклатура.ПолучитьЦену(date);
                        строка.Post();
                    }
                    заявка.Handle();

                    NsgSettings.MainForm.ShowObject(заявка, this);
                }
            }

            //ЗаполнитьТаблицуКомплектов();
            ЗаполнитьТаблицуСпецодежды();
            ЗаполнитьОстатки();
            РаскраситьЯчейки();
        }

        private void nbЗаполнитьВозврат_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьТаблицуВозврата();
        }

        private void ЗаполнитьТаблицуВозврата() 
        {
            vmoВозврат.Data.BeginUpdateData();
            vmoВозврат.Data.MemoryTable.Clear();
            if (!СотрудникВозврат.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника для возврата.");
                vmoВозврат.Data.UpdateDataSync(this);
                return;
            }

            var сотрудник = СотрудникВозврат.Value;

            var рег = РегистрУчетСпецодежды.Новый();
            рег.Сотрудник = сотрудник;
            var остатки = рег.GetRests();

            if (остатки.Count > 0)
            {
                foreach (var item in остатки.AllRows)
                {
                    var row = vmoВозврат.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoВозврат.Name].Value = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                    row[Размер_vmoВозврат.Name].Value = item[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;
                    row[Комплект_vmoВозврат.Name].Value = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;
                    row[Количество_vmoВозврат.Name].Value = 1;
                }

                vmoВозврат.Data.MemoryTable.Collapse(new string[] { Номенклатура_vmoВозврат.Name, Размер_vmoВозврат.Name, Комплект_vmoВозврат.Name }, new string[] { Количество_vmoВозврат.Name }, false);
            }
            
            vmoВозврат.Data.UpdateDataSync(this);
        }

        private void nsgInput6_Selected(object sender, EventArgs e)
        {
            ЗаполнитьТаблицуВозврата();
        }

        private void ОформитьВозврат() 
        {
            if (!ОбъектВозврат.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект для приема возвращаемого имущества.");
                return;
            }

            if (!СотрудникВозврат.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника для возврата.");
                return;
            }

            var сотрудник = СотрудникВозврат.Value;
            var объект = ОбъектВозврат.Value;

            var возврат = ПеремещениеСпецодежды.Новый();
            возврат.New();
            возврат.ДатаДокумента = DateTime.Now;
            возврат.Отправитель = сотрудник;
            возврат.Получатель = объект;

            foreach (var item in vmoВозврат.Data.MemoryTable.AllRows)
            {
                if (item[Принять_vmoВозврат].ToBoolean())
                {
                    var row = возврат.Таблица.NewRow();
                    row.НоменклатураСпецодеждыИСИЗ = item[Номенклатура_vmoВозврат].ToReferent() as Номенклатура;
                    row.КомплектСпецодежды = item[Комплект_vmoВозврат].ToReferent() as КомплектыСпецодежды;
                    row.Размер = item[Размер_vmoВозврат].ToReferent() as Размеры;
                    row.Количество = item[Количество_vmoВозврат].ToInt();
                    row.Post();
                }
            }
            if (возврат.Таблица.Count > 0)
            {
                возврат.Handle();

                NsgSettings.MainForm.ShowObject(возврат, this);
            }

            ЗаполнитьТаблицуВозврата();
        }

        private void nbОформитьВозврат_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ОформитьВозврат();
        }

        private void nbЗаполнитьЗаказы_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (rdbНаДолжности.Checked)
            {
                ЗаполнитьТаблицуЗаказовПоТребованиямДолжностей();
            }
            else if (rdbОбщийЗаказПоставщикам.Checked)
            {
                ЗаполнитьТаблицуЗаказовПоЗаявкамНаСотрудников();
            }
            
        }

        ЗаявкаНаСотрудника[] _ЗаявкиДляСменыСтатуса;
        private void ЗаполнитьТаблицуЗаказовПоЗаявкамНаСотрудников() 
        {
            vmoЗаказы.Data.BeginUpdateData();
            vmoЗаказы.Data.MemoryTable.Clear();

            if (!ОбъектДляЗаказов.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект для формирования заказа.");
                vmoЗаказы.Data.UpdateDataSync(this);
                return;
            }

            var дата = ДатаОпределенияПотребностейДляЗаказа.Value != NsgService.MinDate ? ДатаОпределенияПотребностейДляЗаказа.Value : DateTime.Now;

            var cmp = new NsgCompare();
            cmp.Add(ЗаявкаНаСотрудника.Names.ДатаДокумента, дата, NsgComparison.LessOrEqual);
            cmp.Add(ЗаявкаНаСотрудника.Names.Объект, ОбъектДляЗаказов.Value);
            cmp.Add(ЗаявкаНаСотрудника.Names.Статус, Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения);
            cmp.Add(ЗаявкаНаСотрудника.Names.Индивидуальная, false);
            cmp.Add(ЗаявкаНаСотрудника.Names.ОбщаяЗаявкаПоставщика, ЗаявкиПоставщикам.Новый());
            cmp.Add(ЗаявкаНаСотрудника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            
            if (Подразделение.Value.Selected)
            {
                cmp.Add(ЗаявкаНаСотрудника.Names.Сотрудник + "." + Сотрудники.Names.Подразделение, Подразделение.Value);
            }

            var всеЗаявки = ЗаявкаНаСотрудника.Новый().FindAll(cmp);
            _ЗаявкиДляСменыСтатуса = всеЗаявки;

            var регРезервы = РегистрРезерваЗП.Новый();
            регРезервы.Объект = ОбъектДляЗаказов.Value;
            var резервы = регРезервы.GetRests(дата);

            foreach (var заявка in всеЗаявки)
            {
                foreach (var item in заявка.Таблица.AllRows)
                {
                    var row = vmoЗаказы.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoЗаказы].Value = item.Номенклатура;
                    row[Размер_vmoЗаказы].Value = item.Размер;
                    row[Поставщик_vmoЗаказы].Value = item.Номенклатура.Поставщик;
                    row[КоличествоТребуется_vmoЗаказы].Value = item.Количество;
                    row[Комплект_vmoЗаказы].Value = item.Комплект;
                    row.Post();
                }
            }

            var колонкиКоллапса = new string[]
            {
                Номенклатура_vmoЗаказы.Name,
                Размер_vmoЗаказы.Name,
                Поставщик_vmoЗаказы.Name,
                Комплект_vmoЗаказы.Name
            };

            var колонкиСуммирования = new string[]
            {
                КоличествоТребуется_vmoЗаказы.Name
            };

            vmoЗаказы.Data.MemoryTable.Collapse(колонкиКоллапса, колонкиСуммирования, false);

            vmoЗаказы.Data.UpdateDataSync(this);
        }

        private void ЗаполнитьТаблицуЗаказовПоТребованиямДолжностей() 
        {
            vmoЗаказы.Data.BeginUpdateData();
            vmoЗаказы.Data.MemoryTable.Clear();

            _ЗаявкиДляСменыСтатуса = null;

            if (!ОбъектДляЗаказов.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект для формирования заказа.");
                vmoЗаказы.Data.UpdateDataSync(this);
                return;
            }

            var дата = ДатаОпределенияПотребностейДляЗаказа.Value != NsgService.MinDate ? ДатаОпределенияПотребностейДляЗаказа.Value : DateTime.Now;

            var cmp = new NsgCompare();
            cmp.Add(Сотрудники.Names.ДатаУвольнения, NsgService.MinDate);
            cmp.Add(Сотрудники.Names.ОбъектВыдачиСпецодежды, ОбъектДляЗаказов.Value);

            if (Подразделение.Value.Selected)
            {
                cmp.Add(Сотрудники.Names.Подразделение, Подразделение.Value);
            }

            var всеСотрудники = Сотрудники.Новый().FindAll(cmp);

            var регРезервы = РегистрРезерваЗП.Новый();
            регРезервы.Объект = ОбъектДляЗаказов.Value;
            var резервы = регРезервы.GetRests(дата);

            var регУчета = РегистрУчетСпецодежды.Новый();

            var cmpРегУчета = new NsgCompare();
            cmpРегУчета.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);

            var остаткиНаСотрудниках = регУчета.GetRests(дата, cmpРегУчета);

            foreach (var сотрудник in всеСотрудники)
            {
                if (сотрудник.Должность.Selected)
                {
                    foreach (var строкаТаблицыКомплектов in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
                    {
                        foreach (var строкаКомплекта in строкаТаблицыКомплектов.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
                        {
                            var ном = строкаКомплекта.НоменклатураСпецодеждыИСИЗ;
                            var размер = сотрудник.ПолучитьРазмер(ном);
                            if ((ном.ВидРазмернойСетки.Selected && размер != Размеры.Новый()) || !ном.ВидРазмернойСетки.Selected)
                            {
                                var количество = (int)строкаКомплекта.Количество;
                                for (int i = 1; i <= количество; i++)
                                {
                                    var cmpОстатки = new NsgCompare();
                                    cmpОстатки.Add(РегистрУчетСпецодежды.Names.Сотрудник, сотрудник);
                                    cmpОстатки.Add(РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ, ном);
                                    cmpОстатки.Add(РегистрУчетСпецодежды.Names.Размер, размер);
                                    cmpОстатки.Add(РегистрУчетСпецодежды.Names.КомплектСпецодежды, строкаТаблицыКомплектов.КомплектСпецодежды);

                                    var остаток = остаткиНаСотрудниках.FindRow(cmpОстатки);
                                    if (остаток != null)
                                    {
                                        количество--;
                                        остаткиНаСотрудниках.DeleteRow(остаток);
                                    }
                                }

                                if (количество > 0)
                                {
                                    var row = vmoЗаказы.Data.MemoryTable.NewRow();
                                    row[Номенклатура_vmoЗаказы].Value = ном;
                                    row[Размер_vmoЗаказы].Value = размер;
                                    row[Поставщик_vmoЗаказы].Value = ном.Поставщик;
                                    row[КоличествоТребуется_vmoЗаказы].Value = количество;
                                    row[Комплект_vmoЗаказы].Value = строкаТаблицыКомплектов.КомплектСпецодежды;
                                    row.Post();
                                }
                            }
                        }
                    }
                }
            }

            var колонкиКоллапса = new string[]
            {
                Номенклатура_vmoЗаказы.Name,
                Размер_vmoЗаказы.Name,
                Поставщик_vmoЗаказы.Name
            };

            var колонкиСуммирования = new string[]
            {
                КоличествоТребуется_vmoЗаказы.Name
            };

            vmoЗаказы.Data.MemoryTable.Collapse(колонкиКоллапса, колонкиСуммирования, false);

            foreach (var item in vmoЗаказы.Data.MemoryTable.AllRows)
            {
                var ном = item[Номенклатура_vmoЗаказы].ToReferent() as Номенклатура;
                var размер = item[Размер_vmoЗаказы].ToReferent() as Размеры;
                var поставщик = item[Поставщик_vmoЗаказы].ToReferent() as Контрагенты;

                var cmpРезервы = new NsgCompare();
                cmpРезервы.Add(РегистрРезерваЗП.Names.Номенклатура, ном);
                cmpРезервы.Add(РегистрРезерваЗП.Names.Размер, размер);
                cmpРезервы.Add(РегистрРезерваЗП.Names.Поставщик, поставщик);
                var строкаРезерва = резервы.FindRow(cmpРезервы);
                if (строкаРезерва != null)
                {
                    item[УжеЗаказаноКоличество_vmoЗаказы].Value = (int)строкаРезерва[РегистрРезерваЗП.Names.Количество].ToBegin();
                }
            }


            vmoЗаказы.Data.UpdateDataSync(this);
        }

        private void nbСормироватьЗаказы_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (!ОбъектДляЗаказов.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект для формирования заказа.");
                return;
            }

            Dictionary<Контрагенты, List<NsgMemoryTableRow>> словарьПоПоставщику = new Dictionary<Контрагенты, List<NsgMemoryTableRow>>();
            foreach (var item in vmoЗаказы.Data.MemoryTable.AllRows)
            {
                if (item[Заказать_vmoЗаказы].ToBoolean())
                {
                    var поставщик = item[Поставщик_vmoЗаказы].ToReferent() as Контрагенты;
                    if (поставщик != null)
                    {
                        if (!словарьПоПоставщику.ContainsKey(поставщик))
                        {
                            словарьПоПоставщику[поставщик] = new List<NsgMemoryTableRow>();
                        }
                        словарьПоПоставщику[поставщик].Add(item);
                    }
                }
            }

            foreach (var поставщик in словарьПоПоставщику.Keys)
            {
                try
                {
                    NsgSettings.BeginTransaction();

                    var заявка = ЗаявкиПоставщикам.Новый();
                    заявка.New();
                    заявка.Поставщик = поставщик;
                    заявка.Объект = ОбъектДляЗаказов.Value;
                    заявка.Сотрудник = (NsgSettings.CurrentUser as Пользователи).Сотрудник;
                    foreach (var item in словарьПоПоставщику[поставщик])
                    {
                        var nom = item[Номенклатура_vmoЗаказы].ToReferent() as Номенклатура;
                        var размер = item[Размер_vmoЗаказы].ToReferent() as Размеры;
                        var комплект = item[Комплект_vmoЗаказы].ToReferent() as КомплектыСпецодежды;

                        var строка = заявка.Таблица.NewRow();
                        строка.Номенклатура = nom;
                        строка.Размер = размер;
                        строка.Количество = item[ЗаказатьКоличество_vmoЗаказы].ToInt();
                        строка.Комплект = комплект;
                        строка.Post();

                        if (_ЗаявкиДляСменыСтатуса != null)
                        {
                            var cmp = new NsgCompare();
                            cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Номенклатура, nom); 
                            cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Размер, размер);
                            cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Комплект, комплект); 
                            cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец, _ЗаявкиДляСменыСтатуса, NsgComparison.In);
                            cmp.Add(УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Names.Владелец + "." + ЗаявкаНаСотрудника.Names.Статус, Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения);

                            var строкиЗнС = УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Новый().FindAll(cmp);
                            if (строкиЗнС.Length > 0)
                            {
                                var всеЗнС = строкиЗнС.Select(x => x.Владелец as ЗаявкаНаСотрудника).Distinct().ToArray();
                                foreach (var знс in всеЗнС)
                                {
                                    знс.Edit();
                                    знс.Статус = Перечисления.СтатусыЗаявокНаСотрудника.Объединена;
                                    знс.ОбщаяЗаявкаПоставщика = заявка;
                                    знс.Post();
                                }
                            }
                        }
                    
                    }
                    заявка.Handle();

                    NsgSettings.MainForm.ShowObject(заявка, this);

                    NsgSettings.CommitTransaction();
                }
                catch (Exception ee)
                {
                    NsgSettings.RollbackTransaction();
                    NsgSettings.MainForm.ShowMessage($"Не удалось сформировать заявку на поставщика {поставщик}. Ошибка :{ee.Message}");
                }
            }

            if (_ЗаявкиДляСменыСтатуса != null)
            {
                _ЗаявкиДляСменыСтатуса = null;
                ЗаполнитьТаблицуЗаказовПоЗаявкамНаСотрудников();
            }
        }

        private void nsgIGrid5_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Заказать_vmoЗаказы.Name)
            {
                if (e.RowObject[Заказать_vmoЗаказы].ToBoolean())
                {
                    var требуется = e.RowObject[КоличествоТребуется_vmoЗаказы].ToInt();
                    var заказано = e.RowObject[УжеЗаказаноКоличество_vmoЗаказы].ToInt();
                    var заказать = требуется - заказано;
                    if (заказать < 0)
                    {
                        заказать = 0;
                    }
                    e.RowObject[ЗаказатьКоличество_vmoЗаказы].Value = заказать;
                }
            }
        }

        private void ЗаполнитьГотовыеКВыдаче() 
        {
            vmoГотовыеКВыдаче.Data.BeginUpdateData();
            vmoГотовыеКВыдаче.Data.MemoryTable.Clear();

            var cmp = new NsgCompare();
            cmp.Add(ЗаявкаНаСотрудника.Names.Статус, Перечисления.СтатусыЗаявокНаСотрудника.ГотоваКВыдаче);
            cmp.Add(ЗаявкаНаСотрудника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var всеЗаявки = ЗаявкаНаСотрудника.Новый().FindAll(cmp);
            foreach (var заявка in всеЗаявки)
            {
                foreach (var item in заявка.Таблица.AllRows)
                {
                    var row = vmoГотовыеКВыдаче.Data.MemoryTable.NewRow();
                    row[Сотрудник_vmoГотовыеКВыдаче].Value = заявка.Сотрудник;
                    row[Номенклатура_vmoГотовыеКВыдаче].Value = item.Номенклатура;
                    row[Размер_vmoГотовыеКВыдаче].Value = item.Размер;
                    row[Комплект_vmoГотовыеКВыдаче].Value = item.Комплект;
                    row[Объект_vmoГотовыеКВыдаче].Value = заявка.Объект;
                    row[Количество_vmoГотовыеКВыдаче].Value = item.Количество;
                    row[ДатаОповещения_vmoГотовыеКВыдаче].Value = заявка.ДатаОповещения;
                    row.Post();
                }
            }
            
            vmoГотовыеКВыдаче.Data.UpdateDataSync(this);
        }

        private void РаскраситьГотовыеКВыдаче()
        {
            int дниИгнорирования = 7;
            foreach (var item in vmoГотовыеКВыдаче.Data.MemoryTable.AllRows)
            {
                var датаОповещения = item[ДатаОповещения_vmoГотовыеКВыдаче].ToDateTime();
                
                if (датаОповещения == NsgService.MinDate)
                {
                    item[ДатаОповещения_vmoГотовыеКВыдаче].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Tomato);
                }
                else if (датаОповещения < DateTime.Now.AddDays(-дниИгнорирования))
                {
                    item[ДатаОповещения_vmoГотовыеКВыдаче].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightYellow);
                }
                else
                {
                    item[ДатаОповещения_vmoГотовыеКВыдаче].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightGreen);
                }
            }
        }
    }
    


}