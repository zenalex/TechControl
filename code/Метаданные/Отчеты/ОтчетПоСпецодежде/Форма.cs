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

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            if (vmoДопДанные.Data.CurrentRow == null)
            {
                vmoДопДанные.Data.CurrentRow = vmoДопДанные.Data.MemoryTable.NewRow();
            }

            if (vmoФильтр.Data.CurrentRow == null)
            {
                vmoФильтр.Data.CurrentRow = vmoФильтр.Data.MemoryTable.NewRow();
            }
            base.OnSetFormObject(formObject);
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            СформироватьОтчетПоСпецодежде();
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        public void УстановитьПараметрыФормы(NsgCompare cmp, DateTime дата) 
        {
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                nsgObjectFilter1.Compare = cmp; 
            }), null);

            ДатаОтчета_vmoДопДанные.Value = дата;
        }

        private void СформироватьОтчетПоСпецодежде()
        {
            var дата = ДатаОтчета_vmoДопДанные.Value != NsgService.MinDate ? ДатаОтчета_vmoДопДанные.Value : DateTime.Now;
            var cmp = new NsgCompare();
            cmp.Add(nsgObjectFilter1.Compare);
            if (!nsgObjectFilter1.GetCompare(Объект_vmoФильтр.Name).IsEmpty)
            {
                var cmpОбъектФильтр1 = nsgObjectFilter1.GetCompare(Объект_vmoФильтр.Name);
                var cmpОбъектФильтр2 = nsgObjectFilter1.GetCompare(Объект_vmoФильтр.Name);
                var cmpОбъект = new NsgCompare(NsgLogicalOperator.Or);
                var cmpОснОбъект = cmpОбъектФильтр1.ReplaceParametersNames(Объект_vmoФильтр.Name, ФизЛица.Names.ОсновнойОбъект);
                cmpОбъект.Add(cmpОснОбъект);
                var cmpОбъектВыдачи = cmpОбъектФильтр2.ReplaceParametersNames(Объект_vmoФильтр.Name, ФизЛица.Names.ОбъектВыдачиСпецодежды);
                cmpОбъект.Add(cmpОбъектВыдачи);

                cmp.Add(cmpОбъект);
            }

            if (!nsgObjectFilter1.GetCompare(Подразделение_vmoФильтр.Name).IsEmpty)
            {
                var cmpПодразделениеФильтр = nsgObjectFilter1.GetCompare(Подразделение_vmoФильтр.Name).ReplaceParametersNames(Подразделение_vmoФильтр.Name, ФизЛица.Names.Подразделение);
                
                cmp.Add(cmpПодразделениеФильтр);
            }

            cmp.Add(ФизЛица.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var всеСотрудники = ФизЛица.Новый().FindAll(cmp);

            РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый();
            var cmpРег = new NsgCompare();
            cmpРег.Add(РегистрУчетСпецодежды.Names.Сотрудник, всеСотрудники, NsgComparison.In);
            var остатки = рег.GetRests(дата, cmpРег);
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();

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
                                 && (x[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл
                                 && (x[РегистрУчетСпецодежды.Names.Сотрудник].ToReferent() as ФизЛица) == сотрудник).ToArray();
                            if (остаткиПоСотруднику.Length > 0)
                            {
                                var размер = сотрудник.РазмерНоменклатуры(ном);
                                if (размер == Размеры.Новый())
                                {
                                    размер = сотрудник.ПолучитьРазмер(ном);
                                }
                                if ((размер != Размеры.Новый() && ном.ВидРазмернойСетки.Selected) || (размер == Размеры.Новый() && !ном.ВидРазмернойСетки.Selected))
                                {
                                    for (int i = 0; i < item.Количество; i++)
                                    {
                                        var строкаОстатков = остаткиПоСотруднику.FirstOrDefault();

                                        var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                                        row[Номенклатура_осн].Value = ном;
                                        row[Комплект_осн].Value = компл;
                                        row[Количество_осн].Value = 1;
                                        row[Сотрудник_осн].Value = сотрудник;
                                        row[Должность_осн].Value = сотрудник.Должность;
                                        row[ОбъектВыдачи_осн].Value = сотрудник.ОбъектВыдачиСпецодежды;
                                        row[ОсновнойОбъект_осн].Value = сотрудник.ОсновнойОбъект;
                                        row[Размер_осн].Value = размер;
                                        if (строкаОстатков != null)
                                        {
                                            var датаВыдачи = строкаОстатков[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                                            row[ДатаВыдачи_осн].Value = датаВыдачи;
                                            row[Выдано_осн].Value = true;
                                            row[ГруппировкаПоФактуВыдачи_осн].Value = "Выдано ранее";
                                            row[Стоимость_осн].Value = ном.СтоимостьСУчетомАмортизацииНаДату(дата, датаВыдачи);
                                            остатки.DeleteRow(строкаОстатков);
                                        }

                                        row.Post();
                                    }
                                }
                                else
                                {
                                    остаткиПоСотруднику = остаткиПоСотруднику.OrderByDescending(x => x[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime()).ToArray();
                                    var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                                    row[Номенклатура_осн].Value = ном;
                                    row[Комплект_осн].Value = компл;
                                    row[Количество_осн].Value = остаткиПоСотруднику.Length;
                                    row[Сотрудник_осн].Value = сотрудник;
                                    row[Должность_осн].Value = сотрудник.Должность;
                                    row[ОбъектВыдачи_осн].Value = сотрудник.ОбъектВыдачиСпецодежды;
                                    row[ОсновнойОбъект_осн].Value = сотрудник.ОсновнойОбъект;
                                    var датаВыдачи = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                                    размер = остаткиПоСотруднику.First()[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;
                                    row[Размер_осн].Value = размер;
                                    row[ДатаВыдачи_осн].Value = датаВыдачи;
                                    row[Стоимость_осн].Value = ном.СтоимостьСУчетомАмортизацииНаДату(дата, датаВыдачи);
                                    row[Выдано_осн].Value = true;
                                    row[ГруппировкаПоФактуВыдачи_осн].Value = "Выдано ранее";
                                    row.Post();
                                    foreach (var ост in остаткиПоСотруднику)
                                    {
                                        остатки.DeleteRow(ост);
                                    }
                                }

                            }
                            else if (cbПоказыватьНевыданные.Checked)
                            {
                                var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                                row[Номенклатура_осн].Value = ном;
                                row[Комплект_осн].Value = компл;
                                row[Количество_осн].Value = item.Количество;
                                row[Сотрудник_осн].Value = сотрудник;
                                row[Должность_осн].Value = сотрудник.Должность;
                                row[ГруппировкаПоФактуВыдачи_осн].Value = "Требуется выдача";
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
                    var сотрудник = item[РегистрУчетСпецодежды.Names.Сотрудник].ToReferent() as ФизЛица;
                    var ном = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                    var комплект = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;
                    var размер = item[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;

                    var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    row[Номенклатура_осн].Value = ном;
                    row[Комплект_осн].Value = комплект;
                    row[Размер_осн].Value = размер;
                    row[Количество_осн].Value = 1;
                    row[Сотрудник_осн].Value = сотрудник;
                    row[Должность_осн].Value = сотрудник.Должность;
                    row[ОбъектВыдачи_осн].Value = сотрудник.ОбъектВыдачиСпецодежды;
                    row[ОсновнойОбъект_осн].Value = сотрудник.ОсновнойОбъект;
                    row[ДатаВыдачи_осн].Value = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                    row[Выдано_осн].Value = true;
                    row[ГруппировкаПоФактуВыдачи_осн].Value = "Выдано ранее";
                    row.Post();
                }
            }

            nsgVisualMultipleObject.Data.UpdateDataSync(this);
        }


    }



}