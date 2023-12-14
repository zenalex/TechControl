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
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Документы;
using static NsgSoft.Graphs.NsgTimePlot;





namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ОбъектыФормаЭлемента

    {
        public ОбъектыФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void nsgIGridТарифыТехники_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Тариф.Name && e.RowObject[Стоимость].ToDecimal() == 0)
            {
                e.RowObject[Стоимость].Value = (e.CellObject.ToReferent() as Тарифы).Стоимость;
            }
        }

        private void nsgIGridТарифыПерсонала_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Тариф_vmoТарифыПерсонал.Name)
            {
                e.RowObject[Стоимость_vmoТарифыПерсонал].Value = (e.CellObject.ToReferent() as Тарифы).Стоимость;
            }
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сотрудник.Name)
            {
                e.RowObject[Должность_vmoПерсонал].Value = (e.RowObject[Сотрудник].ToReferent() as Сотрудники).Должность;
                e.RowObject[Приоритет].Value = (e.RowObject[Сотрудник].ToReferent() as Сотрудники).Должность.ГруппаДолжностей.Приоритет;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpНастройкаГрафикаРаботы)
            {
                ЗаполнитьДанныеГрафикаРаботы();
            }
        }

        private void ЗаполнитьДанныеГрафикаРаботы() 
        {
            if (FormObject != null)
            {
                var объект = FormObject as Объекты;
                if (объект != null && объект.Selected)
                {
                    var действующийГрафик = объект.ДействующийНаДатуГрафикРаботы(DateTime.Now);
                    if (действующийГрафик != null && действующийГрафик.Selected)
                    {
                        ГрафикРаботы_vmoГрафикРаботы.Value = действующийГрафик;
                        ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value = действующийГрафик.ДатаНачалаДействияГрафика;
                        ЗаполнитьТабицыДаннымиГрафика(действующийГрафик);
                    }
                }
            }
        }

        private void ЗаполнитьТабицыДаннымиГрафика(ГрафикРаботыОбъекта график) 
        {
            vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();
            vmoТаблицаГрафикаРаботы.Data.MemoryTable.Clear();

            foreach (var item in график.Таблица.AllRows)
            {
                var row = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                row[Должность_vmoТаблицаГрафикаРаботы].Value = item.Должность;
                row[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = item.ГруппаСпецТехники;
                row[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = item.ДеньНедели;
                row[ДатаКонкретныйДень_vmoТаблицаГрафикаРаботы].Value = item.ДатаКонкретныйДень;
                row[Выходной_vmoТаблицаГрафикаРаботы].Value = item.Выходной;
                row[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = item.ВремяНачалаСмены1;
                row[ВремяНачалаСмены2_vmoТаблицаГрафикаРаботы].Value = item.ВремяНачалаСмены2;
                row[ВремяНачалаСмены3_vmoТаблицаГрафикаРаботы].Value = item.ВремяНачалаСмены3;
                row[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = item.ДлительностьСмены1ВЧасах;
                row[ДлительностьСмены2Часы_vmoТаблицаГрафикаРаботы].Value = item.ДлительностьСмены2ВЧасах;
                row[ДлительностьСмены3Часы_vmoТаблицаГрафикаРаботы].Value = item.ДлительностьСмены3ВЧасах;
                row.Post();
            }

            ОбновитьГруппировкиГрафика();

            vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
        }

        private void ОбновитьГруппировкиГрафика() 
        {
            vmoГруппировкаГрафикаРаботы.Data.BeginUpdateData();
            vmoГруппировкаГрафикаРаботы.Data.MemoryTable.Clear();

            List<Tuple<Должности, ГруппыСпецТехники, long>> группировки = new List<Tuple<Должности, ГруппыСпецТехники, long>>();
            foreach (var item in vmoТаблицаГрафикаРаботы.Data.MemoryTable.AllRows)
            {
                var должность = item[Должность_vmoТаблицаГрафикаРаботы].ToReferent() as Должности;
                var группаСпТех = item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].ToReferent() as ГруппыСпецТехники;
                var колич = item[Количество_vmoТаблицаГрафикаРаботы].ToInt();

                группировки.Add(new Tuple<Должности, ГруппыСпецТехники, long>(должность, группаСпТех, колич));
            }
            группировки = группировки.Distinct().ToList();
            foreach (var item in группировки)
            {
                var row = vmoГруппировкаГрафикаРаботы.Data.MemoryTable.NewRow();
                row[Должность_vmoГруппировка].Value = item.Item1;
                row[ГруппаСпецТехники_vmoГруппировка].Value = item.Item2;
                row[Количество_vmoГруппировка].Value = item.Item3;
                row.Post();
            }

            if (vmoГруппировкаГрафикаРаботы.Data.MemoryTable.Count > 0)
            {
                vmoГруппировкаГрафикаРаботы.Data.CurrentRow = vmoГруппировкаГрафикаРаботы.Data.MemoryTable.AllRows.First();
            }

            vmoГруппировкаГрафикаРаботы.Data.UpdateDataSync(this);
        }

        private void vmoГруппировкаГрафикаРаботы_CurrentRowChanged(object sender, NsgMultipleObject oldRow, NsgMultipleObject newRow)
        {
            ОбновитьФильтрыНаГрафик();
        }

        private void ОбновитьФильтрыНаГрафик() 
        {
            if ((Должность_vmoГруппировка.Value != null && Должность_vmoГруппировка.Value.Selected) 
                || (ГруппаСпецТехники_vmoГруппировка.Value != null && ГруппаСпецТехники_vmoГруппировка.Value.Selected))
            {
                vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();

                var cmp = vmoТаблицаГрафикаРаботы.Data.GetComparison(this);
                cmp.Clear();
                cmp.Add(Должность_vmoТаблицаГрафикаРаботы.Name, Должность_vmoГруппировка.Value);
                cmp.Add(ГруппаСпецТехники_vmoТаблицаГрафикаРаботы.Name, ГруппаСпецТехники_vmoГруппировка.Value);

                vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
            }
        }

        private void nsgIGrid7_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var должность = e.RowObject[Должность_vmoГруппировка].ToReferent() as Должности;
            var группаСПТехн = e.RowObject[ГруппаСпецТехники_vmoГруппировка].ToReferent() as ГруппыСпецТехники;

            if ((должность != null && должность.Selected) || (группаСПТехн != null && группаСПТехн.Selected))
            {
                var cmp = new NsgCompare();
                var cmpДолжнИГруппа = new NsgCompare();
                cmpДолжнИГруппа.Add(Должность_vmoТаблицаГрафикаРаботы.Name, должность);
                cmpДолжнИГруппа.Add(ГруппаСпецТехники_vmoТаблицаГрафикаРаботы.Name, группаСПТехн);
                cmp.Add(cmpДолжнИГруппа);
                var cmpДатаИВых = new NsgCompare();
                cmpДатаИВых.Add(ДатаКонкретныйДень_vmoТаблицаГрафикаРаботы.Name, NsgService.MinDate);
                cmpДатаИВых.Add(Выходной_vmoТаблицаГрафикаРаботы.Name, false);
                cmp.Add(cmpДатаИВых);

                var всеСтроки = vmoТаблицаГрафикаРаботы.Data.MemoryTable.FindRows(cmp);
                vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();
                if (всеСтроки != null && всеСтроки.Length > 0)
                {
                    foreach (var item in всеСтроки)
                    {
                        item[Должность_vmoТаблицаГрафикаРаботы].Value = должность;
                        item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = группаСПТехн;
                        item[Количество_vmoТаблицаГрафикаРаботы].Value = e.RowObject[Количество_vmoГруппировка].ToInt();
                        item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены1_vmoГруппировка].ToDateTime();
                        item[ВремяНачалаСмены2_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены2_vmoГруппировка].ToDateTime();
                        item[ВремяНачалаСмены3_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены3_vmoГруппировка].ToDateTime();
                        item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены1_vmoГруппировка].ToDecimal();
                        item[ДлительностьСмены2Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены2_vmoГруппировка].ToDecimal();
                        item[ДлительностьСмены3Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены3_vmoГруппировка].ToDecimal();
                    }
                }
                else
                {
                    foreach (var kvp in ДеньНедели.ByDayOfWeek)
                    {
                        var item = vmoГрафикРаботы.Data.MemoryTable.NewRow();
                        item[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = kvp.Value;
                        item[Должность_vmoТаблицаГрафикаРаботы].Value = должность;
                        item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = группаСПТехн;
                        item[Количество_vmoТаблицаГрафикаРаботы].Value = e.RowObject[Количество_vmoГруппировка].ToInt();
                        item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены1_vmoГруппировка].ToDateTime();
                        item[ВремяНачалаСмены2_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены2_vmoГруппировка].ToDateTime();
                        item[ВремяНачалаСмены3_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ВремяНачалаСмены3_vmoГруппировка].ToDateTime();
                        item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены1_vmoГруппировка].ToDecimal();
                        item[ДлительностьСмены2Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены2_vmoГруппировка].ToDecimal();
                        item[ДлительностьСмены3Часы_vmoТаблицаГрафикаРаботы].Value = e.RowObject[ДлительностьСмены3_vmoГруппировка].ToDecimal();
                        item.Post();
                    }
                }
                vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
            }
        }

        private void nbСохранитьГрафик_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject == null || (FormObject as Объекты) == null || !(FormObject as Объекты).Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не загрузился объект");
                e.Cancel = true;
                return;
            }

            if (ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Укажите дату начала действия графика");
                e.Cancel = true;
                return;
            }

            if (vmoТаблицаГрафикаРаботы.Data.MemoryTable.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage("Добавьте хотя бы 1 строчку графика работы");
                e.Cancel = true;
                return;
            }

            ГрафикРаботыОбъекта график = null;
            try
            {
                if (ГрафикРаботы_vmoГрафикРаботы.Value != null && ГрафикРаботы_vmoГрафикРаботы.Value.Selected)
                {
                    график = ГрафикРаботы_vmoГрафикРаботы.Value;
                    график.Edit();
                }
                else
                {
                    график = ГрафикРаботыОбъекта.Новый();
                    график.New();
                }

                график.ДатаНачалаДействияГрафика = ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value;
                график.Объект = FormObject as Объекты;
                foreach (var item in vmoТаблицаГрафикаРаботы.Data.MemoryTable.AllRows)
                {
                    var row = график.Таблица.NewRow();
                    row.Должность = item[Должность_vmoТаблицаГрафикаРаботы].ToReferent() as Должности;
                    row.ГруппаСпецТехники = item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].ToReferent() as ГруппыСпецТехники;
                    row.ДеньНедели = item[ДеньНедели_vmoТаблицаГрафикаРаботы].ToReferent() as ДеньНедели;
                    row.ДатаКонкретныйДень = item[ДатаКонкретныйДень_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.Выходной = item[Выходной_vmoТаблицаГрафикаРаботы].ToBoolean();
                    row.ВремяНачалаСмены1 = item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.ВремяНачалаСмены2 = item[ВремяНачалаСмены2_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.ВремяНачалаСмены3 = item[ВремяНачалаСмены3_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.ДлительностьСмены1ВЧасах = item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].ToDecimal();
                    row.ДлительностьСмены2ВЧасах = item[ДлительностьСмены2Часы_vmoТаблицаГрафикаРаботы].ToDecimal();
                    row.ДлительностьСмены3ВЧасах = item[ДлительностьСмены3Часы_vmoТаблицаГрафикаРаботы].ToDecimal();
                    row.Количество = item[Количество_vmoТаблицаГрафикаРаботы].ToInt();

                    row.Post();
                }

                график.Post();
                ЗаполнитьДанныеГрафикаРаботы();
                NsgSettings.MainForm.ShowMessage("График обновлен успешно");
            }
            catch (Exception ee)
            {
                NsgSettings.MainForm.ShowMessage($"Проблема сохранения графика {ee}");
            }
        }

        private void nsgIGrid7_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Должность_vmoГруппировка.Name)
            {
                var cmp = Должность_vmoГруппировка.SearchCondition;
                cmp.Clear();
                if (ТаблицаПерсонал.Value.Count > 0)
                {
                    var сотрудникиНаОбъектке = ТаблицаПерсонал.Value.AllRows.Select(x => (x[Сотрудник].ToReferent() as Сотрудники)).ToArray();
                    var основныеДолжности = сотрудникиНаОбъектке.Select(x => x.Должность).ToArray();
                    var совмещаемыеДолжности = сотрудникиНаОбъектке.SelectMany(x => x.ТаблицаСовмещаемыхДолжностей.AllRows.Select(y => y.Должность)).ToArray();
                    var доступныеДолжности = основныеДолжности.Concat(совмещаемыеДолжности).Distinct().Select(x => x.Идентификатор).ToArray();

                    cmp.Add(Должности.Names.Идентификатор, доступныеДолжности, NsgComparison.In);
                }
            }

            if (e.ColumnName == ГруппаСпецТехники_vmoГруппировка.Name)
            {
                var cmp = Должность_vmoГруппировка.SearchCondition;
                cmp.Clear();
                if (ТаблицаТехника.Value.Count > 0)
                {
                    var техникаНаОбъектке = ТаблицаТехника.Value.AllRows.Select(x => (x[Техника].ToReferent() as Мониторинг.Техника)).ToArray();
                    var группыМпецТехники = техникаНаОбъектке.Select(x => x.ГруппаСпецТехники).Distinct().Select(x => x.Идентификатор).ToArray();

                    cmp.Add(ГруппыСпецТехники.Names.Идентификатор, группыМпецТехники, NsgComparison.In);
                }
            }
        }

        private void nbЗаполнитьПоПерсоналу_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (ТаблицаПерсонал.Value.Count > 0 || ТаблицаТехника.Value.Count > 0)
            {
                vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();
                vmoТаблицаГрафикаРаботы.Data.MemoryTable.Clear();

                Dictionary<Должности, int> должности = new Dictionary<Должности, int>();
                Dictionary<ГруппыСпецТехники, int> группыСпТехн = new Dictionary<ГруппыСпецТехники, int>();

                foreach (var item in ТаблицаПерсонал.Value.AllRows)
                {
                    var должн = item.Сотрудник.Должность;
                    if (должн.Selected)
                    {
                        if (!должности.ContainsKey(должн))
                        {
                            должности[должн] = 1;
                        }
                        else
                        {
                            должности[должн]++;
                        }

                        foreach (var совм in item.Сотрудник.ТаблицаСовмещаемыхДолжностей.AllRows)
                        {
                            if (совм.Должность.Selected)
                            {
                                if (!должности.ContainsKey(должн))
                                {
                                    должности[должн] = 1;
                                }
                                else
                                {
                                    должности[должн]++;
                                }
                            }
                        }
                    }
                }

                foreach (var item in ТаблицаТехника.Value.AllRows)
                {
                    var грСпТехн = item.Техника.ГруппаСпецТехники;
                    if (грСпТехн.Selected)
                    {
                        if (!группыСпТехн.ContainsKey(грСпТехн))
                        {
                            группыСпТехн[грСпТехн] = 1;
                        }
                        else
                        {
                            группыСпТехн[грСпТехн]++;
                        }
                    }
                }

                foreach (var item in должности)
                {
                    foreach (var день in ДеньНедели.ByDayOfWeek)
                    {
                        var row = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                        row[Должность_vmoТаблицаГрафикаРаботы].Value = item.Key;
                        row[Количество_vmoТаблицаГрафикаРаботы].Value = item.Value;
                        row[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = день.Value;
                        row.Post();
                    }
                }

                foreach (var item in группыСпТехн)
                {
                    foreach (var день in ДеньНедели.ByDayOfWeek)
                    {
                        var row = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                        row[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = item.Key;
                        row[Количество_vmoТаблицаГрафикаРаботы].Value = item.Value;
                        row[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = день.Value;
                        row.Post();
                    }
                }

                ОбновитьГруппировкиГрафика();

                vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
            }
            else
            {
                NsgSettings.MainForm.ShowMessage("Не заполнены таблицы персонала и техники");
            }
        }
    }
    


}