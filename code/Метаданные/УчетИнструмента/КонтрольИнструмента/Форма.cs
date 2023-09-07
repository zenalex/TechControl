using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетИнструмента
{
    
    public partial class КонтрольИнструментаФорма

    {
        public КонтрольИнструментаФорма()
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

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (nsgVisualMultipleObject.Data.CurrentRow == null)
            {
                nsgVisualMultipleObject.Data.CurrentRow = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
            }

            var cmp = Номенклатура_vmoТаблицаВыдачи.SearchCondition;
            cmp.Clear();

            var cmpOr = new NsgCompare(NsgSoft.Database.NsgLogicalOperator.Or);
            cmpOr.Add(Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.Инструменты);
            cmpOr.Add(Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.МатериальныеЦенности);
            cmp.Add(cmpOr);
        }

        private void nsgInput2_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ОбъектПолучатель.Value.Selected)
            {
                if (!СотрудникПолучатель.Value.Selected)
                {
                    СотрудникПолучатель.Value = ОбъектПолучатель.Value.Ответственный;
                }
            }
        }

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (!СотрудникПолучатель.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать сотрудника");
                return;
            }

            if (СотрудникПолучатель.Value.Selected)
            {
                var должность = СотрудникПолучатель.Value.Должность;
                if (должность.Selected)
                {
                    foreach (var item in должность.ТаблицаНеобязательнойНоменклатуры.AllRows)
                    {
                        var номенклатура = item.Номенклатура;
                        if (номенклатура.Selected && (номенклатура.ТипНоменклатуры == ТипНоменклатуры.Инструменты || номенклатура.ТипНоменклатуры == ТипНоменклатуры.МатериальныеЦенности))
                        {
                            var row = vmoТаблицаВыдачи.Data.MemoryTable.NewRow();
                            row[Номенклатура_vmoТаблицаВыдачи].Value = номенклатура;
                            row.Post();
                        }
                    }
                }
            }
        }

        private void ЗаполнитьОстатки() 
        {
            
        }

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Выдать_vmoТаблицаВыдачи.Name)
            {
                var объект = ОбъектВыдачи.Value;
                if (!объект.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Необходимо указать объект выдачи.");
                    e.Cancel = true;
                    return;
                }

                var номенклатура = e.RowObject[Номенклатура_vmoТаблицаВыдачи].ToReferent() as Номенклатура;
                var серийныйНомер = e.RowObject[СерийныйНомер_vmoТаблицаВыдачи].ToString();
                if (номенклатура.Selected)
                {
                    var reg = РегистрУчетИнструмента.Новый();
                    reg.Объект = объект;
                    if (серийныйНомер != string.Empty)
                    {
                        reg.СерийныйНомер = серийныйНомер;
                        if (!reg.GetRest())
                        {
                            NsgSettings.MainForm.ShowMessage("На объекте на зарегистрирована номенклатура с указанным серийным номером.");
                            e.Cancel = true;
                            return;
                        }
                    }
                    else
                    {
                        var движ = УчетИнструментаРегистрУчетИнструментаДвижения.Новый();
                        var cmp = new NsgCompare();
                        cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.НоменклатураИнструмента, номенклатура);
                        cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.Объект, объект);
                        var всеДвижения = движ.FindAll(cmp);
                        if (всеДвижения != null && всеДвижения.Length > 0)
                        {
                            var ужеУказанныеСерийники = nsgVisualMultipleObject.Data.MemoryTable.AllRows.Select(x => x[СерийныйНомер_vmoТаблицаВыдачи].ToString()).ToArray();
                            string серийник = string.Empty;
                            foreach (var номер in всеДвижения.Select(x => x.СерийныйНомер).Distinct().ToArray())
                            {
                                if (!ужеУказанныеСерийники.Contains(номер))
                                {
                                    reg.New();
                                    reg.Объект = объект;
                                    reg.СерийныйНомер = номер;
                                    if (reg.GetRest())
                                    {
                                        серийник = номер;
                                        break;
                                    }
                                }
                            }
                            if (серийник != string.Empty)
                            {
                                e.RowObject[СерийныйНомер_vmoТаблицаВыдачи].Value = серийник;
                            }
                            else
                            {
                                NsgSettings.MainForm.ShowMessage("На объекте на зарегистрирована номенклатура с указанным серийным номером.");
                                e.Cancel = true;
                                return;
                            }
                        }
                        else
                        {
                            NsgSettings.MainForm.ShowMessage("На объекте на зарегистрирована номенклатура с указанным серийным номером.");
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }

            if (e.ColumnName == СерийныйНомер_vmoТаблицаВыдачи.Name)
            {
                if (!ОбъектВыдачи.Value.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Необходимо указать объект выдачи.");
                    e.Cancel = true;
                    return;
                }

                var номенклатура = e.RowObject[Номенклатура_vmoТаблицаВыдачи].ToReferent() as Номенклатура;
                var серийныйНомер = e.RowObject[СерийныйНомер_vmoТаблицаВыдачи].ToString();
                if (номенклатура.Selected)
                {
                    var reg = РегистрУчетИнструмента.Новый();
                    reg.Объект = ОбъектВыдачи.Value;
                    reg.СерийныйНомер = серийныйНомер;
                    if (!reg.GetRest())
                    {
                        NsgSettings.MainForm.ShowMessage("На объекте на зарегистрирована номенклатура с указанным серийным номером.");
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        var объект = ОбъектВыдачи.Value;
                        if (номенклатура.Selected && объект.Selected)
                        {
                            DialogResult dialogResult = DialogResult.None;
                            string серийник = string.Empty;
                            var ужеУказанныеСерийники = nsgVisualMultipleObject.Data.MemoryTable.AllRows.Select(x => x[СерийныйНомер_vmoТаблицаВыдачи].ToString()).ToArray();
                            Invoke(new MethodInvoker(() =>
                            {
                                var iФормаВыбораСерийника = new ДопФормы.ФормаВыбораСерийника(номенклатура, объект, ужеУказанныеСерийники);
                                iФормаВыбораСерийника.ShowDialog(this);
                                dialogResult = iФормаВыбораСерийника.DialogResult;
                                if (dialogResult != DialogResult.OK)
                                {
                                    e.Cancel = false;
                                    return;
                                }
                                серийник = iФормаВыбораСерийника.ВыбранныйСерийник;
                            }));

                            e.RowObject[серийныйНомер].Value = серийник;
                        }
                    }
                }
            }
        }

        private void nbВыдать_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объектВыдачи = ОбъектВыдачи.Value;
            if (!объектВыдачи.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать объект выдачи");
                return;
            }

            var сотрудник = СотрудникПолучатель.Value;
            var объект = ОбъектПолучатель.Value;
            if (!сотрудник.Selected && !объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать сотрудника или объект получателя");
                return;
            }

            var перемещение = ПеремещениеИнструмента.Новый();
            перемещение.New();
            перемещение.ТребуетсяПодтверждение = cbТребуетсяПодтверждение.Checked;
            перемещение.Отправитель = объектВыдачи;
            if (сотрудник.Selected)
            {
                перемещение.Получатель = сотрудник;
            }
            else
            {
                перемещение.Получатель = объект;
            }

            foreach (var item in nsgVisualMultipleObject.Data.MemoryTable.AllRows)
            {
                if (item[Выдать_vmoТаблицаВыдачи].ToBoolean())
                {
                    var row = перемещение.Таблица.NewRow();
                    row.НоменклатураИнструмента = item[Номенклатура_vmoТаблицаВыдачи].ToReferent() as Номенклатура;
                    row.СерийныйНомер = item[СерийныйНомер_vmoТаблицаВыдачи].ToString();
                    row.Post();
                }
            }

            if (перемещение.Таблица.Count > 0)
            {
                перемещение.Handle();

                NsgSettings.MainForm.ShowObject(перемещение, this);
            }

        }

        private void nbЗаполнитьПодтверждения_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = ОбъектПодтверждения.Value;
            var сотрудник = СотрудникПодтверждение.Value;

            if (!объект.Selected && !сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо выбрать объект или сотрудника");
                return;
            }

            var cmp = new NsgCompare();
            if (объект.Selected)
            {
                cmp.Add(РегистрУчетИнструмента.Names.Объект, объект);
            }
            if (сотрудник.Selected)
            {
                cmp.Add(РегистрУчетИнструмента.Names.Сотрудник, сотрудник);
            }

            cmp.Add(РегистрУчетИнструмента.Names.ДокументПодтверждения, ПодтверждениеПеремещения.Новый(), NsgComparison.NotEqual);

            var reg = РегистрУчетИнструмента.Новый();
            var остатки = reg.GetRests(cmp);

            foreach (var item in остатки.AllRows)
            {
                if (item[РегистрУчетИнструмента.Names.ДокументПодтверждения].ToReferent().Selected)
                {
                    var row = vmoТаблицаПодтверждения.Data.MemoryTable.NewRow();
                    row[СерийныйНомер_vmoТаблицаПодтверждения].Value = item[РегистрУчетИнструмента.Names.СерийныйНомер].ToString();
                    row[Номенклатура_vmoТаблицаПодтверждения].Value = item[РегистрУчетИнструмента.Names.НоменклатураИнструмента].ToReferent() as Номенклатура;
                    row[Сотрудник_vmoТаблицаПодтверждения].Value = item[РегистрУчетИнструмента.Names.Сотрудник].ToReferent() as Сотрудники;
                    row[Объект_vmoТаблицаПодтверждения].Value = item[РегистрУчетИнструмента.Names.Объект].ToReferent() as Объекты;
                    row.Post();
                }
            }
        }

        private void nbОбработатьПодтверждения_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var подтверждение = ПодтверждениеПеремещения.Новый();
            подтверждение.New();
            var возврат = ПеремещениеИнструмента.Новый();
            возврат.New();
            возврат.ЭтоВозврат = true;
            var объект = ОбъектПодтверждения.Value;
            var сотрудник = СотрудникПодтверждение.Value;
            if (объект.Selected)
            {
                возврат.Отправитель = объект;
            }
            else if (сотрудник.Selected)
            {
                возврат.Отправитель = сотрудник;
            }
            foreach (var item in vmoТаблицаПодтверждения.Data.MemoryTable.AllRows)
            {
                if (item[ПодтвердитьПолучение_vmoТаблицаПодтверждения].ToBoolean())
                {
                    var row = подтверждение.Таблица.NewRow();
                    row.СерийныйНомер = item[СерийныйНомер_vmoТаблицаПодтверждения].ToString();
                    row.Номенклатура = item[Номенклатура_vmoТаблицаПодтверждения].ToReferent() as Номенклатура;
                    row.Post();
                }
                else if (item[ОформитьВозврать_vmoТаблицаПодтверждения].ToBoolean())
                {
                    var row = возврат.Таблица.NewRow();
                    row.СерийныйНомер = item[СерийныйНомер_vmoТаблицаПодтверждения].ToString();
                    row.НоменклатураИнструмента = item[Номенклатура_vmoТаблицаПодтверждения].ToReferent() as Номенклатура;
                    row.Post();
                }
            }

            if (подтверждение.Таблица.Count > 0)
            {
                подтверждение.Handle();
                NsgSettings.MainForm.ShowObject(подтверждение, this);
            }

            if (возврат.Таблица.Count > 0)
            {
                возврат.Handle();
                NsgSettings.MainForm.ShowObject(возврат, this);
            }
        }

        private void nbПоказатьИнструменты_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var объект = ОбъектСерийники.Value;
            var сотрудник = СотрудникСерийники.Value;
            if (!объект.Selected && !сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника или объект для поиска");
                return;
            }

            var рег = РегистрУчетИнструмента.Новый();
            if (объект.Selected)
            {
                рег.Объект = объект;
            }

            if (сотрудник.Selected)
            {
                рег.Сотрудник = сотрудник;
            }

            var всеИнструменты = рег.GetRests();
            vmoСменаСерийников.Data.BeginUpdateData();
            vmoСменаСерийников.Data.MemoryTable.Clear();

            foreach (var item in всеИнструменты.AllRows)
            {
                var row = vmoСменаСерийников.Data.MemoryTable.NewRow();
                row[Номенклатура_vmoСменаСерийников].Value = item[РегистрУчетИнструмента.Names.НоменклатураИнструмента].ToReferent() as Номенклатура;
                row[ТекущийСерийник_vmoСменаСерийников].Value = item[РегистрУчетИнструмента.Names.СерийныйНомер].ToString();
                row[Объект_vmoСменаСерийников].Value = item[РегистрУчетИнструмента.Names.Объект].ToReferent() as Объекты;
                row[Сотрудник_vmoСменаСерийников].Value = item[РегистрУчетИнструмента.Names.Сотрудник].ToReferent() as Сотрудники;
                row.Post();
            }
            vmoСменаСерийников.Data.UpdateDataSync(this);
        }

        private void nbНовыеСерийники_AsyncClick(object sender, DoWorkEventArgs e)
        {
            foreach (var item in vmoСменаСерийников.Data.MemoryTable.AllRows)
            {
                if (item[Подтвердить_vmoСменаСерийников].ToBoolean())
                {
                    var новыйСерийник = item[НовыйСерийник_vmoСменаСерийников].ToString();
                    var текущийСерийник = item[ТекущийСерийник_vmoСменаСерийников].ToString();
                    if (новыйСерийник == string.Empty)
                    {
                        NsgSettings.MainForm.ShowMessage($"Не указан новый серийный номер к номеру {текущийСерийник}");
                        continue;
                    }
                    else
                    {
                        УчетИнструментаРегистрУчетИнструментаДвижения движНовый= УчетИнструментаРегистрУчетИнструментаДвижения.Новый();
                        var cmp = new NsgCompare();
                        cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер, новыйСерийник);
                        var ужеИспользуется = движНовый.FindAll(cmp).Length > 0;
                        if (ужеИспользуется)
                        {
                            NsgSettings.MainForm.ShowMessage($"Cерийный номер {новыйСерийник} ужде используется.");
                            continue;
                        }
                        else
                        {
                            if (текущийСерийник != string.Empty)
                            {
                                УчетИнструментаРегистрУчетИнструментаДвижения движСтарый = УчетИнструментаРегистрУчетИнструментаДвижения.Новый();
                                var cmpСтарый = new NsgCompare();
                                cmpСтарый.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер, текущийСерийник);
                                var всеЗаписиСТекущимСерийником = движСтарый.FindAll(cmp);
                                if (всеЗаписиСТекущимСерийником.Length > 0)
                                {
                                    try
                                    {
                                        NsgSettings.BeginTransaction();
                                        foreach (var запись in всеЗаписиСТекущимСерийником)
                                        {
                                            запись.Edit();
                                            запись.СерийныйНомер = новыйСерийник;
                                            запись.Post();
                                        }
                                        NsgSettings.CommitTransaction();
                                        NsgSettings.MainForm.ShowMessage($"{новыйСерийник} присвоен в {текущийСерийник}");
                                    }
                                    catch (Exception eee)
                                    {
                                        NsgSettings.RollbackTransaction();
                                        NsgSettings.MainForm.ShowMessage($"ошибка присвоения нового номера {новыйСерийник} к старому {текущийСерийник}. Ошибка: {eee.Message}");
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }

            nbПоказатьИнструменты_AsyncClick(null, null);
        }
    }
    


}