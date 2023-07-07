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
        private int _выбранныйОтчет;

        public КонтрольСпецодеждыИСИЗФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            
            if (vmoДопДанныеДляОтчета.Data.CurrentRow == null)
            {
                vmoДопДанныеДляОтчета.Data.CurrentRow = vmoДопДанныеДляОтчета.Data.MemoryTable.NewRow();
            }

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
            if (_номерТаба == 2 && (rdbСпецодежда.Checked || rdbЗакупки.Checked))
            {
                base.OnBeforeCreateReport(nsgBackgroundReporter);
            }

        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            if (_номерТаба == 2)
            {
                base.OnCreateReport(nsgBackgroundReporter, e);
                if (rdbСпецодежда.Checked)
                {
                    if (nsgReport1.Pages.Count > 1)
                    {
                        nsgReport1.Pages[0].Enabled = false;
                    }
                    СформироватьОтчетПоСпецодежде();
                }
                else if (rdbЗакупки.Checked)
                {
                    if (nsgReport1.Pages.Count > 1)
                    {
                        nsgReport1.Pages[1].Enabled = false;
                    }
                    СформироватьОтчетПоЗакупкам();
                }
            }
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (_номерТаба == 2 && (rdbСпецодежда.Checked || rdbЗакупки.Checked))
            {
                base.OnCreateReportCompleted(nsgBackgroundReporter, e);
                if (rdbСпецодежда.Checked)
                {
                    if (nsgReport1.Pages.Count > 1)
                    {
                        nsgReport1.Pages[0].Enabled = true;
                        nsgReport1.Pages[1].Enabled = false;
                    }
                }
                else if (rdbЗакупки.Checked)
                {
                    if (nsgReport1.Pages.Count > 1)
                    {
                        nsgReport1.Pages[0].Enabled = false;
                        nsgReport1.Pages[1].Enabled = true;
                    }
                }
            }
        }

        private void СформироватьОтчетПоСпецодежде() 
        {
            var дата = ДатаОтчета_vmoДопДанныеДляОтчета.Value != NsgService.MinDate ? ДатаОтчета_vmoДопДанныеДляОтчета.Value : DateTime.Now;
            var cmp = new NsgCompare();
            cmp.Add(nsgObjectFilter1.Compare);
            cmp.Add(Сотрудники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var всеСотрудники = Сотрудники.Новый().FindAll(cmp);

            РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
            var cmpРег = new NsgCompare();
            cmpРег.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);
            var остатки = рег.GetRests(дата, cmpРег);
            vmoДанныеДляОтчета.Data.BeginUpdateData();
            vmoДанныеДляОтчета.Data.MemoryTable.Clear();

            foreach (var сотрудник in всеСотрудники)
            {
                if (сотрудник.Должность.Selected)
                {
                    foreach (var срокаТаблицыКомплектов in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
                    {
                        foreach (var item in срокаТаблицыКомплектов.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
                        {
                            var ном = item.НоменклатураСпецодеждыИСИЗ;
                            var компл = срокаТаблицыКомплектов.КомплектСпецодежды;
                            var остаткиПоСотруднику = остатки.AllRows.Where(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == ном
                                 && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл).ToArray();
                            if (остаткиПоСотруднику.Length > 0)
                            {
                                if (сотрудник.РазмерНоменклатуры(ном) != Размеры.Новый())
                                {
                                    for (int i = 0; i < item.Количество; i++)
                                    {
                                        var строкаОстатков = остаткиПоСотруднику.FirstOrDefault();

                                        var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
                                        row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
                                        row[Комплект_vmoДанныеДляОтчета].Value = компл;
                                        row[Количество_vmoДанныеДляОтчета].Value = 1;
                                        row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
                                        row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
                                        if (строкаОстатков != null)
                                        {
                                            row[ДатаВыдачи_vmoДанныеДляОтчета].Value = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                                            row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
                                            остатки.DeleteRow(строкаОстатков);
                                        }
                                        
                                        row.Post();
                                    }
                                }
                                else
                                {
                                    остаткиПоСотруднику = остаткиПоСотруднику.OrderByDescending(x => x[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime()).ToArray();
                                    var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
                                    row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
                                    row[Комплект_vmoДанныеДляОтчета].Value = компл;
                                    row[Количество_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.Length;
                                    row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
                                    row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
                                    row[ДатаВыдачи_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                                    row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
                                    row.Post();
                                    foreach ( var ост in остаткиПоСотруднику)
                                    {
                                        остатки.DeleteRow(ост);
                                    }
                                }

                            }
                            else
                            {
                                var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
                                row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
                                row[Комплект_vmoДанныеДляОтчета].Value = компл;
                                row[Количество_vmoДанныеДляОтчета].Value = item.Количество;
                                row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = true;
                                row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
                                row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
                                row.Post();
                            }

                        }
                    }
                }
            }

            if (остатки.Count > 0)
            {
                foreach (var item in остатки.AllRows)
                {
                    var сотрудник = item[РегистрУчетСпецодежды.Names.Сотрудник].ToReferent() as Сотрудники;
                    var ном = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                    var комплект = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;

                    var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
                    row[Комплект_vmoДанныеДляОтчета].Value = комплект;
                    row[Количество_vmoДанныеДляОтчета].Value = 1;
                    row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
                    row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
                    row[ДатаВыдачи_vmoДанныеДляОтчета].Value = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                    row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
                    row[ТребуетсяВозврат_vmoДанныеДляОтчета].Value = комплект.Selected && item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) > дата;
                    row.Post();
                }
            }

            vmoДанныеДляОтчета.Data.UpdateDataSync(this);

        }

        private void СформироватьОтчетПоЗакупкам()
        {
            var дата = ДатаОтчета_vmoДопДанныеДляОтчета.Value != NsgService.MinDate ? ДатаОтчета_vmoДопДанныеДляОтчета.Value : DateTime.Now;
            var cmp = new NsgCompare();
            cmp.Add(nsgObjectFilter1.Compare);
            cmp.Add(Сотрудники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var всеСотрудники = Сотрудники.Новый().FindAll(cmp);

            РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
            var cmpРег = new NsgCompare();
            cmpРег.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);
            var остаткиПоСпецодежде = рег.GetRests(дата, cmpРег);

            ОстаткиНоменклатуры регОстатков = ОстаткиНоменклатуры.Новый();
            var cmpРегОстатков = new NsgCompare();
            cmpРегОстатков.Add(ОстаткиНоменклатуры.Names.Номенклатура + "." + Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.Спецодежда);
            var остаткиНаСкладах = регОстатков.GetRests(дата);

            vmoДанныеДляОтчета.Data.BeginUpdateData();
            vmoДанныеДляОтчета.Data.MemoryTable.Clear();

            Dictionary<Tuple<Номенклатура, Размеры, Сотрудники>, int> всегоТребуетсяСпецодежды = new Dictionary<Tuple<Номенклатура, Размеры, Сотрудники>, int>();

            foreach (var сотрудник in всеСотрудники)
            {
                if (сотрудник.Должность.Selected)
                {
                    foreach (var срокаТаблицыКомплектов in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
                    {
                        foreach (var item in срокаТаблицыКомплектов.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
                        {
                            var ном = item.НоменклатураСпецодеждыИСИЗ;
                            var компл = срокаТаблицыКомплектов.КомплектСпецодежды;
                            var размер = сотрудник.РазмерНоменклатуры(ном);
                            if (!размер.Selected)
                            {
                                размер = сотрудник.ПолучитьРазмер(ном);
                            }

                            if (размер.Selected)
                            {
                                var key = new Tuple<Номенклатура, Размеры, Сотрудники>(ном, размер, сотрудник);

                                for (int i = 0; i < item.Количество; i++)
                                {
                                    var остаткиПоСотруднику = остаткиПоСпецодежде.AllRows.Where(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == ном
                                        && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл).ToArray();

                                    if (!всегоТребуетсяСпецодежды.ContainsKey(key))
                                    {
                                        всегоТребуетсяСпецодежды[key] = 0;
                                    }
                                    if (остаткиПоСотруднику.Length > 0)
                                    {
                                        var строкаОстатков = остаткиПоСотруднику.FirstOrDefault();

                                        if (строкаОстатков != null)
                                        {
                                            var требуетсяВыдача = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
                                            if (требуетсяВыдача)
                                            {
                                                всегоТребуетсяСпецодежды[key]++;
                                            }
                                            остаткиПоСпецодежде.DeleteRow(строкаОстатков);
                                        }
                                    }
                                    else
                                    {
                                        всегоТребуетсяСпецодежды[key]++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var item in всегоТребуетсяСпецодежды)
            {
                var номенклатура = item.Key.Item1;
                var размер = item.Key.Item2;
                var сотрудник = item.Key.Item3;
                var объект = сотрудник.ОбъектВыдачиСпецодежды.Selected ? сотрудник.ОбъектВыдачиСпецодежды : сотрудник.ОсновнойОбъект;

                var конкретныеОстаткиНаОбъектах = остаткиНаСкладах.AllRows
                    .Where(x => (x[ОстаткиНоменклатуры.Names.Номенклатура].ToReferent() as Номенклатура) == номенклатура
                && (x[ОстаткиНоменклатуры.Names.Размер].ToReferent() as Размеры) == размер 
                && (x[ОстаткиНоменклатуры.Names.Объект].ToReferent() as Объекты) == объект)
                    .ToArray();

                NsgMemoryTableRow остаток = null;
                int наОбъекте = 0;
                if (конкретныеОстаткиНаОбъектах.Length > 0)
                {
                    остаток = конкретныеОстаткиНаОбъектах.First();
                    наОбъекте = (int)остаток[ОстаткиНоменклатуры.Names.Количество].ToInt();
                }

                var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
                row[Номенклатура_vmoДанныеДляОтчета].Value = номенклатура;
                row[Цена_vmoДанныеДляОтчета].Value = номенклатура.ПолучитьЦену(дата);
                row[Объект_vmoДанныеДляОтчета].Value = объект;
                row[Количество_vmoДанныеДляОтчета].Value = item.Value - наОбъекте;
                row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
                row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
                row[КоличествоНаОбъекте_vmoДанныеДляОтчета].Value = наОбъекте;
                row[Размер_vmoДанныеДляОтчета].Value = размер;
                row.Post();
            }

            vmoДанныеДляОтчета.Data.UpdateDataSync(this);
        }

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьТаблицуСпецодежды();
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
                    row[РазмерКВыдаче_vmoСписокСпецодежды].Value = сотрудник.ПолучитьРазмер(nom);
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
                            if (!(row[РазмерВыданных_vmoСписокСпецодежды].ToReferent() as Размеры).Selected)
                            {
                                row[РазмерВыданных_vmoСписокСпецодежды].Value = item[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;
                            }
                            остатки.DeleteRow(item);
                        }

                        row[ВсегоВыдано_vmoСписокСпецодежды].Value = ужеВыдано;
                        row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;
                    }

                    var кВыдаче = строкаСпецодежды.Количество - (ужеВыдано - всегоЗаконченСрок);
                    row[КВыдаче_vmoСписокСпецодежды].Value = кВыдаче < 0 ? 0 : кВыдаче;

                    row[ТребуетсяПоКомплекту_vmoСписокСпецодежды].Value = строкаСпецодежды.Количество;

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

                row[ВсегоВыдано_vmoСписокСпецодежды].Value = ужеВыдано;
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
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[ВыдатьСотруднику_vmoСписокСпецодежды].ToInt() > 0))
            {
                var строка = перемещение.Таблица.NewRow();
                строка.НоменклатураСпецодеждыИСИЗ = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                строка.КомплектСпецодежды = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                строка.Размер = item[РазмерКВыдаче_vmoСписокСпецодежды].ToReferent() as Размеры;
                строка.Количество = item[ВыдатьСотруднику_vmoСписокСпецодежды].ToInt();
                строка.Post();
            }
            //перемещение.Post();

            NsgSettings.MainForm.ShowObject(перемещение, this);

            ЗаполнитьТаблицуСпецодежды();
        }

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            ЗаполнитьТаблицуСпецодежды();
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
            if (e.ColumnName == РазмерКВыдаче_vmoСписокСпецодежды.Name)
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
                    var вид = номенклатура.ВидНоменклатуры;
                    var cmp = РазмерКВыдаче_vmoСписокСпецодежды.SearchCondition;
                    cmp.Clear();
                    cmp.Add(Размеры.Names.ВидСвойствНоменклатуры, вид);
                }
            }
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == РазмерВыданных_vmoСписокСпецодежды.Name)
            {
                if (!Объект.Value.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать объект выдачи спецодежды");
                }
                else
                {
                    var номенклатура = e.RowObject[Номенклатура_vmoСписокСпецодежды.Name].ToReferent() as Номенклатура;
                    if (номенклатура != null && номенклатура.Selected)
                    {
                        var размерКВыдаче = e.RowObject[РазмерВыданных_vmoСписокСпецодежды.Name].ToReferent() as Размеры;
                        if (размерКВыдаче != null && размерКВыдаче.Selected)
                        {
                            var рег = ОстаткиНоменклатуры.Новый();
                            рег.Номенклатура = номенклатура;
                            рег.Размер = размерКВыдаче;
                            рег.Объект = Объект.Value;
                            рег.GetRest();
                            e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды.Name].Value = (long)рег.Количество;
                        }
                        else
                        {
                            NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать размер спецодежды к выдаче");
                        }
                    }
                    else
                    {
                        NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать номенклатуру спецодежды");
                    }
                }
            }
            else if (e.ColumnName == ВыдатьСотруднику_vmoСписокСпецодежды.Name)
            {
                var количествоНаСкладе = e.RowObject[КоличествоНаСкладе_vmoСписокСпецодежды.Name].ToInt();
                var количествоВыдаваемое = e.RowObject[ВыдатьСотруднику_vmoСписокСпецодежды.Name].ToInt();
                if (количествоНаСкладе <= количествоВыдаваемое)
                {
                    e.RowObject[ВыдатьСотруднику_vmoСписокСпецодежды.Name].Value = количествоНаСкладе;
                }
            }
        }

        private void nsgInput3_Changed(object sender, EventArgs e)
        {
            if (vmoСписокСпецодежды.Data.MemoryTable.Count > 0)
            {
                if (!Объект.Value.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Для определения остатков, необходимо указать объект выдачи спецодежды");
                }
                else
                {
                    foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows)
                    {
                        var номенклатура = item[Номенклатура_vmoСписокСпецодежды.Name].ToReferent() as Номенклатура;
                        if (номенклатура != null && номенклатура.Selected)
                        {
                            var размерКВыдаче = item[РазмерВыданных_vmoСписокСпецодежды.Name].ToReferent() as Размеры;
                            if (размерКВыдаче != null && размерКВыдаче.Selected)
                            {
                                var рег = ОстаткиНоменклатуры.Новый();
                                рег.Номенклатура = номенклатура;
                                рег.Размер = размерКВыдаче;
                                рег.Объект = Объект.Value;
                                рег.GetRest();
                                item[КоличествоНаСкладе_vmoСписокСпецодежды.Name].Value = (long)рег.Количество;
                            }
                        }
                    }
                }
            }
        }

        private void rdbСпецодежда_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbСпецодежда.Checked)
            {
                _выбранныйОтчет = 1;
            }
        }

        private void rdbЗакупки_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbЗакупки.Checked)
            {
                _выбранныйОтчет = 2;
            }
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
    }
    


}