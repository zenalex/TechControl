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
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Сервис;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class КонтрольСпецодеждыИСИЗФорма
    {

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

            var перемещение = ПеремещениеСпецодежды.Новый();
            перемещение.New();
            перемещение.Отправитель = отправитель;
            перемещение.Получатель = сотрудник;
            перемещение.ДатаНачалаЭксплуатации = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : перемещение.ДатаДокумента;
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[КоличествоВыдать_vmoСписокСпецодежды].ToInt() > 0))
            {
                var строка = перемещение.Таблица.NewRow();
                строка.НоменклатураСпецодеждыИСИЗ = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                строка.КомплектСпецодежды = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                строка.Размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                строка.Количество = item[КоличествоВыдать_vmoСписокСпецодежды].ToInt();
                строка.Post();
            }
            //перемещение.Post();

            NsgSettings.MainForm.ShowObject(перемещение, this);

            //ЗаполнитьТаблицуКомплектов();
            //ЗаполнитьТаблицуСпецодежды();
            //ЗаполнитьОстатки();
            //РаскраситьЯчейки();
        }

        private void ЗаполнитьОстатки() 
        {
            if (Объект.Value.Selected && vmoСписокСпецодежды.Data.MemoryTable.Count > 0)
            {
                var reg = ОстаткиНоменклатуры.Новый();
                foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    
                    if (nom != null && nom.Selected)
                    {
                        var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                        reg.New();
                        reg.Номенклатура = nom;
                        if (размер != null && размер.Selected)
                        {
                            reg.Размер = размер;
                        }
                        reg.Объект = Объект.Value;
                        reg.GetRest();
                        item[КоличествоНаСкладе_vmoСписокСпецодежды].Value = reg.Количество;
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

        int _номерТаба;

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpВыдача)
            {
                _номерТаба = 1;
            }
            else
            {
                _номерТаба = 2;
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
                }
                else
                {
                    e.RowObject[КоличествоВыдать_vmoСписокСпецодежды.Name].Value = 0;
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
            }
        }

        private void nsgButton2_AsyncClick(object sender, DoWorkEventArgs e)
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

            Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>> словарьДляЗаявки = new Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>>();
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[КоличествоВыдать_vmoСписокСпецодежды].ToInt() > 0))
            {
                var количествоКВыдаче = item[КоличествоВыдать_vmoСписокСпецодежды].ToInt();
                var количествоНаСкладе = item[КоличествоНаСкладе_vmoСписокСпецодежды].ToInt();
                var количествоТребуется = item[ТребуетсяПоКомплекту_vmoСписокСпецодежды].ToInt();
                var количество = 0;
                if (количествоНаСкладе >= количествоТребуется)
                {
                    continue;
                }
                else
                {
                    количество = (int)(количествоТребуется - количествоКВыдаче);
                }

                if (количество != 0)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    var компл = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                    var контрагент = nom.Поставщик;

                    if (!словарьДляЗаявки.ContainsKey(контрагент))
                    {
                        словарьДляЗаявки[контрагент] = new List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>();
                    }

                    словарьДляЗаявки[контрагент].Add(new Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>(nom, компл, размер, количество));
                }
            }

            var date = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : DateTime.Now;
            foreach (var поставщик in словарьДляЗаявки.Keys)
            {
                var заявка = ЗаявкаНаСотрудника.Новый();
                заявка.New();
                заявка.Контрагент = поставщик;
                заявка.Объект = отправитель;
                заявка.Сотрудник = сотрудник;

                foreach (var массив in словарьДляЗаявки[поставщик])
                {
                    var строка = заявка.Таблица.NewRow();
                    строка.Номенклатура = массив.Item1;
                    строка.Размер = массив.Item3;
                    строка.Количество = массив.Item4;
                    строка.Цена = строка.Номенклатура.ПолучитьЦену(date);
                    строка.Post();
                }

                NsgSettings.MainForm.ShowObject(заявка, this);
            }

            //ЗаполнитьТаблицуКомплектов();
            //ЗаполнитьТаблицуСпецодежды();
            //ЗаполнитьОстатки();
            //РаскраситьЯчейки();
        }

        private void nsgButton1_AsyncClick_1(object sender, DoWorkEventArgs e)
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

            Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>> словарьДляЗаявки = new Dictionary<Контрагенты, List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>>();
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[КоличествоВыдать_vmoСписокСпецодежды].ToInt() > 0))
            {
                var количествоКВыдаче = item[КоличествоВыдать_vmoСписокСпецодежды].ToInt();
                var количествоНаСкладе = item[КоличествоНаСкладе_vmoСписокСпецодежды].ToInt();
                var количествоТребуется = item[ТребуетсяПоКомплекту_vmoСписокСпецодежды].ToInt();
                var количество = 0;
                if (количествоНаСкладе >= количествоТребуется)
                {
                    continue;
                }
                else
                {
                    количество = (int)количествоТребуется;
                }

                if (количество != 0)
                {
                    var nom = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                    var компл = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[Размер_vmoСписокСпецодежды].ToReferent() as Размеры;
                    var контрагент = nom.Поставщик;

                    if (!словарьДляЗаявки.ContainsKey(контрагент))
                    {
                        словарьДляЗаявки[контрагент] = new List<Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>>();
                    }

                    словарьДляЗаявки[контрагент].Add(new Tuple<Номенклатура, КомплектыСпецодежды, Размеры, int>(nom, компл, размер, количество));
                }
            }

            var date = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value : DateTime.Now;
            foreach (var поставщик in словарьДляЗаявки.Keys)
            {
                var заявка = ЗаявкаНаСотрудника.Новый();
                заявка.New();
                заявка.Контрагент = поставщик;
                заявка.Объект = отправитель;
                заявка.Сотрудник = сотрудник;

                foreach (var массив in словарьДляЗаявки[поставщик])
                {
                    var строка = заявка.Таблица.NewRow();
                    строка.Номенклатура = массив.Item1;
                    строка.Размер = массив.Item3;
                    строка.Количество = массив.Item4;
                    строка.Цена = строка.Номенклатура.ПолучитьЦену(date);
                    строка.Post();
                }

                NsgSettings.MainForm.ShowObject(заявка, this);
            }

            //ЗаполнитьТаблицуКомплектов();
            //ЗаполнитьТаблицуСпецодежды();
            //ЗаполнитьОстатки();
            //РаскраситьЯчейки();
        }
    }
    


}