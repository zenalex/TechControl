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
    
    public partial class ОтчетПоСпецодеждеФорма

    {
        public ОтчетПоСпецодеждеФорма()
        {
            InitializeComponent();
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


        private void СформироватьОтчетПоСпецодежде()
        {
            //var дата = ДатаОтчета_vmoДопДанныеДляОтчета.Value != NsgService.MinDate ? ДатаОтчета_vmoДопДанныеДляОтчета.Value : DateTime.Now;
            //var cmp = new NsgCompare();
            //cmp.Add(nsgObjectFilter1.Compare);
            //cmp.Add(Сотрудники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            //var всеСотрудники = Сотрудники.Новый().FindAll(cmp);

            //РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
            //var cmpРег = new NsgCompare();
            //cmpРег.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);
            //var остатки = рег.GetRests(дата, cmpРег);
            //vmoДанныеДляОтчета.Data.BeginUpdateData();
            //vmoДанныеДляОтчета.Data.MemoryTable.Clear();

            //foreach (var сотрудник in всеСотрудники)
            //{
            //    if (сотрудник.Должность.Selected)
            //    {
            //        foreach (var срокаТаблицыКомплектов in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
            //        {
            //            foreach (var item in срокаТаблицыКомплектов.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
            //            {
            //                var ном = item.НоменклатураСпецодеждыИСИЗ;
            //                var компл = срокаТаблицыКомплектов.КомплектСпецодежды;
            //                var остаткиПоСотруднику = остатки.AllRows.Where(x => (x[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == ном
            //                     && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл).ToArray();
            //                if (остаткиПоСотруднику.Length > 0)
            //                {
            //                    if (сотрудник.РазмерНоменклатуры(ном) != Размеры.Новый())
            //                    {
            //                        for (int i = 0; i < item.Количество; i++)
            //                        {
            //                            var строкаОстатков = остаткиПоСотруднику.FirstOrDefault();

            //                            var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
            //                            row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
            //                            row[Комплект_vmoДанныеДляОтчета].Value = компл;
            //                            row[Количество_vmoДанныеДляОтчета].Value = 1;
            //                            row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
            //                            row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
            //                            if (строкаОстатков != null)
            //                            {
            //                                row[ДатаВыдачи_vmoДанныеДляОтчета].Value = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
            //                                row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
            //                                остатки.DeleteRow(строкаОстатков);
            //                            }

            //                            row.Post();
            //                        }
            //                    }
            //                    else
            //                    {
            //                        остаткиПоСотруднику = остаткиПоСотруднику.OrderByDescending(x => x[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime()).ToArray();
            //                        var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
            //                        row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
            //                        row[Комплект_vmoДанныеДляОтчета].Value = компл;
            //                        row[Количество_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.Length;
            //                        row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
            //                        row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
            //                        row[ДатаВыдачи_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
            //                        row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
            //                        row.Post();
            //                        foreach (var ост in остаткиПоСотруднику)
            //                        {
            //                            остатки.DeleteRow(ост);
            //                        }
            //                    }

            //                }
            //                else
            //                {
            //                    var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
            //                    row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
            //                    row[Комплект_vmoДанныеДляОтчета].Value = компл;
            //                    row[Количество_vmoДанныеДляОтчета].Value = item.Количество;
            //                    row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = true;
            //                    row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
            //                    row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
            //                    row.Post();
            //                }

            //            }
            //        }
            //    }
            //}

            //if (остатки.Count > 0)
            //{
            //    foreach (var item in остатки.AllRows)
            //    {
            //        var сотрудник = item[РегистрУчетСпецодежды.Names.Сотрудник].ToReferent() as Сотрудники;
            //        var ном = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
            //        var комплект = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;

            //        var row = vmoДанныеДляОтчета.Data.MemoryTable.NewRow();
            //        row[Номенклатура_vmoДанныеДляОтчета].Value = ном;
            //        row[Комплект_vmoДанныеДляОтчета].Value = комплект;
            //        row[Количество_vmoДанныеДляОтчета].Value = 1;
            //        row[Сотрудник_vmoДанныеДляОтчета].Value = сотрудник;
            //        row[Должность_vmoДанныеДляОтчета].Value = сотрудник.Должность;
            //        row[ДатаВыдачи_vmoДанныеДляОтчета].Value = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
            //        row[ТребуетсяВыдача_vmoДанныеДляОтчета].Value = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) < дата;
            //        row[ТребуетсяВозврат_vmoДанныеДляОтчета].Value = комплект.Selected && item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime().AddMonths((int)ном.ПланАмортизации.СрокАмортизацииМес) > дата;
            //        row.Post();
            //    }
            //}

            //vmoДанныеДляОтчета.Data.UpdateDataSync(this);

        }


    }



}