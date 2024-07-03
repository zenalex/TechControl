using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;

namespace TechControl.Метаданные.Отчеты
{
    
    public partial class ОтчетПоЗакупкамФорма

    {
        public ОтчетПоЗакупкамФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                if (vmoДопДанные.Data.CurrentRow == null)
                {
                    vmoДопДанные.Data.CurrentRow = vmoДопДанные.Data.MemoryTable.NewRow(); 
                }

                if (vmoФильтр.Data.CurrentRow == null)
                {
                    vmoФильтр.Data.CurrentRow = vmoФильтр.Data.MemoryTable.NewRow();
                }
            }
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            СформироватьОтчетПоЗакупкам();
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }


        private void СформироватьОтчетПоЗакупкам()
        {
            var дата = ДатаОтчета_vmoДопДанные.Value != NsgService.MinDate ? ДатаОтчета_vmoДопДанные.Value : DateTime.Now;
            var cmp = new NsgCompare();
            
            var cmpПодразделение = nsgObjectFilter1.GetCompare(Подразделение_vmoФильтр.Name);
            if (!cmpПодразделение.IsEmpty)
            {
                cmpПодразделение.ReplaceParametersNames(Подразделение_vmoФильтр.Name, ФизЛица.Names.Подразделение + "." + Подразделения.Names.Идентификатор);
                cmp.Add(cmpПодразделение);
            }

            var cmpОбъект = nsgObjectFilter1.GetCompare(Объект_vmoФильтр.Name);
            if (!cmpОбъект.IsEmpty)
            {
                cmpОбъект.ReplaceParametersNames(Объект_vmoФильтр.Name, ФизЛица.Names.ОбъектВыдачиСпецодежды + "." + Объекты.Names.Идентификатор);
                cmp.Add(cmpОбъект);
            }

            cmp.Add(nsgObjectFilter1.Compare);
            cmp.Add(ФизЛица.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var всеСотрудники = ФизЛица.Новый().FindAll(cmp);

            РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
            var cmpРег = new NsgCompare();
            cmpРег.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);
            var остаткиПоСпецодежде = рег.GetRests(дата, cmpРег);

            ОстаткиНоменклатуры регОстатков = ОстаткиНоменклатуры.Новый();
            var cmpРегОстатков = new NsgCompare();
            cmpРегОстатков.Add(ОстаткиНоменклатуры.Names.Номенклатура + "." + Учет.Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.Спецодежда);
            var остаткиНаСкладах = регОстатков.GetRests(дата);

            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();

            Dictionary<Tuple<Номенклатура, Размеры, ФизЛица>, int> всегоТребуетсяСпецодежды = new Dictionary<Tuple<Номенклатура, Размеры, ФизЛица>, int>();

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
                                var key = new Tuple<Номенклатура, Размеры, ФизЛица>(ном, размер, сотрудник);

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

                var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                row[Номенклатура].Value = номенклатура;
                row[Цена].Value = номенклатура.ПолучитьЦену(дата);
                row[Объект].Value = объект;
                row[Количество].Value = item.Value - наОбъекте;
                row[Сотрудник].Value = сотрудник;
                row[Должность].Value = сотрудник.Должность;
                row[КоличествоНаОбъекте].Value = наОбъекте;
                row[Размер].Value = размер;
                row.Post();
            }

            nsgVisualMultipleObject.Data.UpdateDataSync(this);
        }

        public void УстановитьПараметрыФормы(NsgCompare cmp, DateTime дата)
        {
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                nsgObjectFilter1.Compare = cmp;
            }), null);

            ДатаОтчета_vmoДопДанные.Value = дата;
        }

    }



}