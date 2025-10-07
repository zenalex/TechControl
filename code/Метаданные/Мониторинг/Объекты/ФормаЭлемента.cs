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
using TechControl.Метаданные.Перечисления;
using TechControl.Метаданные.Регистры;
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

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (vmoГрафикРаботы.Data.CurrentRow == null)
            {
                vmoГрафикРаботы.Data.CurrentRow = vmoГрафикРаботы.Data.MemoryTable.NewRow();
            }
        }

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
                e.RowObject[Должность_vmoПерсонал].Value = (e.RowObject[Сотрудник].ToReferent() as ФизЛица).Должность;
                e.RowObject[Приоритет].Value = (e.RowObject[Сотрудник].ToReferent() as ФизЛица).Должность.ГруппаДолжностей.Приоритет;
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
                        ВремяНачала_vmoГрафикРаботы.Value = действующийГрафик.ВремяНачалаРаботы != NsgService.MinDate ? действующийГрафик.ВремяНачалаРаботы : действующийГрафик.РассчитатьВремяНачалаРаботы();
                        ВремяОкончания_vmoГрафикРаботы.Value = действующийГрафик.ВремяОкончанияРаботы != NsgService.MinDate ? действующийГрафик.ВремяОкончанияРаботы : действующийГрафик.РассчитатьВремяОкончанияРаботы();
                        ЗаполнитьТабицыДаннымиГрафика(действующийГрафик);
                    }
                    else
                    {
                        vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();
                        vmoТаблицаГрафикаРаботы.Data.MemoryTable.Clear();
                        vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);

                        vmoГруппировкаГрафикаРаботы.Data.BeginUpdateData();
                        vmoГруппировкаГрафикаРаботы.Data.MemoryTable.Clear();
                        vmoГруппировкаГрафикаРаботы.Data.UpdateDataSync(this);
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
                row[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = item.ДлительностьСмены1ВЧасах;
                row[Количество_vmoТаблицаГрафикаРаботы].Value = item.Количество;
                row[ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы].Value = item.ВидРежимаРаботы;
                row.Post();
            }

            vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);

            ОбновитьГруппировкиГрафика();
        }

        private void ОбновитьГруппировкиГрафика() 
        {
            vmoГруппировкаГрафикаРаботы.Data.BeginUpdateData();
            vmoГруппировкаГрафикаРаботы.Data.MemoryTable.Clear();
            var датаНачалаГрафика = ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value.Date;
            List<Tuple<string, Должности, ГруппыСпецТехники, long, ВидыРежимовРаботы>> группировки = new List<Tuple<string, Должности, ГруппыСпецТехники, long, ВидыРежимовРаботы>>();
            foreach (var item in vmoТаблицаГрафикаРаботы.Data.MemoryTable.AllRows)
            {
                var должность = item[Должность_vmoТаблицаГрафикаРаботы].ToReferent() as Должности;
                var группаСпТех = item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].ToReferent() as ГруппыСпецТехники;
                var колич = item[Количество_vmoТаблицаГрафикаРаботы].ToInt();
                var кодГруппы = item[КодГруппы_vmoТаблицаГрафикаРаботы].ToString();
                var видРежимаРаботы = item[ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы].ToReferent() as ВидыРежимовРаботы;

                группировки.Add(new Tuple<string, Должности, ГруппыСпецТехники, long, ВидыРежимовРаботы>(кодГруппы, должность, группаСпТех, колич, видРежимаРаботы));
            }
            группировки = группировки.Distinct().ToList();
            foreach (var item in группировки)
            {
                var row = vmoГруппировкаГрафикаРаботы.Data.MemoryTable.NewRow();
                row[КодГруппы_vmoГруппировка].Value = item.Item1;
                row[Должность_vmoГруппировка].Value = item.Item2;
                row[ГруппаСпецТехники_vmoГруппировка].Value = item.Item3;
                row[Количество_vmoГруппировка].Value = item.Item4;
                row[ВидРежимаРаботы_vmoГруппировка].Value = item.Item5;
                row[ВремяНачалаСмены1_vmoГруппировка].Value = датаНачалаГрафика;
                row.Post();
            }

            if (vmoГруппировкаГрафикаРаботы.Data.MemoryTable.Count > 0)
            {
                vmoГруппировкаГрафикаРаботы.Data.CurrentRow = vmoГруппировкаГрафикаРаботы.Data.MemoryTable.AllRows.First();
                ОбновитьФильтрыНаГрафик();
            }

            vmoГруппировкаГрафикаРаботы.Data.UpdateDataSync(this);
        }

        bool _новаяСтрока = false;
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
                cmp.Add(КодГруппы_vmoТаблицаГрафикаРаботы.Name, КодГруппы_vmoГруппировка.Value);
                cmp.Add(ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы.Name, ВидРежимаРаботы_vmoГруппировка.Value);

                vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
            }
        }

        private void nsgIGrid7_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            ОбновитьГрафикПоГруппировке(e.RowObject);
        }

        private void ОбновитьГрафикПоГруппировке(NsgMultipleObject obj) 
        {
            var должность = obj[Должность_vmoГруппировка].ToReferent() as Должности;
            var группаСПТехн = obj[ГруппаСпецТехники_vmoГруппировка].ToReferent() as ГруппыСпецТехники;
            var видРежимаРаботы = obj[ВидРежимаРаботы_vmoГруппировка].ToReferent() as ВидыРежимовРаботы;
            var кодГруппы = obj[КодГруппы_vmoГруппировка].ToString();

            if ((должность != null && должность.Selected) || (группаСПТехн != null && группаСПТехн.Selected))
            {
                var cmp = new NsgCompare();
                var cmpДолжнИГруппа = new NsgCompare();
                cmpДолжнИГруппа.Add(Должность_vmoТаблицаГрафикаРаботы.Name, должность);
                cmpДолжнИГруппа.Add(ГруппаСпецТехники_vmoТаблицаГрафикаРаботы.Name, группаСПТехн);
                cmpДолжнИГруппа.Add(КодГруппы_vmoТаблицаГрафикаРаботы.Name, кодГруппы);
                cmpДолжнИГруппа.Add(ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы.Name, видРежимаРаботы);
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
                        item[КодГруппы_vmoТаблицаГрафикаРаботы].Value = кодГруппы;
                        item[Количество_vmoТаблицаГрафикаРаботы].Value = obj[Количество_vmoГруппировка].ToInt();
                        item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = obj[ВремяНачалаСмены1_vmoГруппировка].ToDateTime();
                        item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = obj[ДлительностьСмены1_vmoГруппировка].ToDecimal();
                        item[ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы].Value = видРежимаРаботы;
                    }
                }
                else
                {
                    кодГруппы = string.IsNullOrEmpty(кодГруппы) ? Guid.NewGuid().ToString() : кодГруппы;
                    foreach (var kvp in ДеньНедели.AllValues)
                    {
                        var item = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                        item[КодГруппы_vmoТаблицаГрафикаРаботы].Value = кодГруппы;
                        item[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = kvp;
                        item[Должность_vmoТаблицаГрафикаРаботы].Value = должность;
                        item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = группаСПТехн;
                        item[Количество_vmoТаблицаГрафикаРаботы].Value = obj[Количество_vmoГруппировка].ToInt();
                        item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = obj[ВремяНачалаСмены1_vmoГруппировка].ToDateTime();
                        item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].Value = obj[ДлительностьСмены1_vmoГруппировка].ToDecimal();
                        item[ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы].Value = видРежимаРаботы;
                        ;
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

                график.ДатаНачалаДействияГрафика = ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value.Date;
                график.Объект = FormObject as Объекты;
                List<Guid> обработанныеСтроки = new List<Guid>();
                foreach (var item in vmoТаблицаГрафикаРаботы.Data.MemoryTable.AllRows)
                {
                    var должность = item[Должность_vmoТаблицаГрафикаРаботы].ToReferent() as Должности;
                    var группаСпТехн = item[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].ToReferent() as ГруппыСпецТехники;
                    var деньНедели = item[ДеньНедели_vmoТаблицаГрафикаРаботы].ToReferent() as ДеньНедели;
                    var колич = item[Количество_vmoТаблицаГрафикаРаботы].ToInt();
                    var кодГруппы = item[КодГруппы_vmoТаблицаГрафикаРаботы].ToString();
                    var видРежимаРаботы = item[ВидРежимаРаботыть_vmoТаблицаГрафикаРаботы].ToReferent() as ВидыРежимовРаботы;
                    var cmp = new NsgCompare();
                    cmp.Add(ДокументыГрафикРаботыОбъектаТаблица.Names.КодГруппы, кодГруппы);
                    cmp.Add(ДокументыГрафикРаботыОбъектаТаблица.Names.Должность, должность);
                    cmp.Add(ДокументыГрафикРаботыОбъектаТаблица.Names.ГруппаСпецТехники, группаСпТехн);
                    cmp.Add(ДокументыГрафикРаботыОбъектаТаблица.Names.ДеньНедели, деньНедели);
                    cmp.Add(ДокументыГрафикРаботыОбъектаТаблица.Names.ВидРежимаРаботы, видРежимаРаботы);

                    ДокументыГрафикРаботыОбъектаТаблица.Строка row = null;

                    var подходящиеСтроки = график.Таблица.FindRows(cmp);
                    if (подходящиеСтроки != null && подходящиеСтроки.Length > 0)
                    {
                        if (подходящиеСтроки.Length == 1)
                        {
                            row = подходящиеСтроки.First();
                        }
                        else
                        {
                            подходящиеСтроки = подходящиеСтроки.Where(x => x.Количество == колич && !обработанныеСтроки.Contains(x.Идентификатор)).ToArray();
                            if (подходящиеСтроки.Length > 0)
                            {
                                row = подходящиеСтроки.First();
                                if (row != null)
                                {
                                    обработанныеСтроки.Add(row.Идентификатор);
                                }
                            }
                        }
                    }

                    if (row == null)
                    {
                        row = график.Таблица.NewRow();
                    }
                    
                    row.Должность = должность;
                    row.ГруппаСпецТехники = группаСпТехн;
                    row.ДеньНедели = деньНедели;
                    row.ДатаКонкретныйДень = item[ДатаКонкретныйДень_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.Выходной = item[Выходной_vmoТаблицаГрафикаРаботы].ToBoolean();
                    row.ВремяНачалаСмены1 = item[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].ToDateTime();
                    row.ДлительностьСмены1ВЧасах = item[ДлительностьСмены1Часы_vmoТаблицаГрафикаРаботы].ToDecimal();
                    row.Количество = колич;
                    row.КодГруппы = кодГруппы;
                    row.ВидРежимаРаботы = видРежимаРаботы;

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
            var объект = FormObject as Объекты;
            if (e.ColumnName == Должность_vmoГруппировка.Name)
            {
                var cmp = Должность_vmoГруппировка.SearchCondition;
                cmp.Clear();
                var списокПерсонала = объект.СписокПерсонала();
                if (списокПерсонала.Count > 0)
                {
                    var сотрудникиНаОбъектке = списокПерсонала.Select(x => x.Item1).ToArray();
                    var основныеДолжности = сотрудникиНаОбъектке.Select(x => x.Должность).ToArray();
                    var совмещаемыеДолжности = сотрудникиНаОбъектке.SelectMany(x => x.ТаблицаСовмещаемыхДолжностей.AllRows.Select(y => y.Должность)).ToArray();
                    var доступныеДолжности = основныеДолжности.Concat(совмещаемыеДолжности).Distinct().Select(x => x.Идентификатор).ToArray();

                    cmp.Add(Мониторинг.Должности.Names.Идентификатор, доступныеДолжности, NsgComparison.In);
                }
            }

            if (e.ColumnName == ГруппаСпецТехники_vmoГруппировка.Name)
            {
                var cmp = Должность_vmoГруппировка.SearchCondition;
                cmp.Clear();
                var списокТехники = объект.СписокТехникиОбъекта();
                if (списокТехники.Length > 0)
                {
                    var техникаНаОбъектке = списокТехники;
                    var группыМпецТехники = техникаНаОбъектке.Select(x => x.ГруппаСпецТехники).Distinct().Select(x => x.Идентификатор).ToArray();

                    cmp.Add(ГруппыСпецТехники.Names.Идентификатор, группыМпецТехники, NsgComparison.In);
                }
            }
        }

        private void nbЗаполнитьПоПерсоналу_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var началоДействияГрафика = ДатаНачалаДействияГрафика_vmoГрафикРаботы.Value.Date;
            if (началоДействияГрафика == NsgService.MinDate || началоДействияГрафика == DateTime.MinValue)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо указать дату начала действия графика");
                e.Cancel = true;
                return;
            }
            var объект = FormObject as Объекты;
            var списокПерсонала = объект.СписокПерсонала();
            var списокТехники = объект.СписокТехникиОбъекта();
            if (списокПерсонала.Count > 0 || списокТехники.Length > 0)
            {
                vmoТаблицаГрафикаРаботы.Data.BeginUpdateData();
                vmoТаблицаГрафикаРаботы.Data.MemoryTable.Clear();

                Dictionary<Должности, int> должности = new Dictionary<Должности, int>();
                Dictionary<ГруппыСпецТехники, int> группыСпТехн = new Dictionary<ГруппыСпецТехники, int>();

                foreach (var item in списокПерсонала)
                {
                    var должн = item.Item2;
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

                        foreach (var совм in item.Item1.ТаблицаСовмещаемыхДолжностей.AllRows)
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

                foreach (var item in списокТехники)
                {
                    var грСпТехн = item.ГруппаСпецТехники;
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
                    var кодГруппы = Guid.NewGuid().ToString();

                    foreach (var день in ДеньНедели.AllValues)
                    {
                        var row = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                        row[Должность_vmoТаблицаГрафикаРаботы].Value = item.Key;
                        row[Количество_vmoТаблицаГрафикаРаботы].Value = item.Value;
                        row[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = день;
                        row[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = началоДействияГрафика;
                        row[КодГруппы_vmoТаблицаГрафикаРаботы].Value = кодГруппы;
                        row.Post();
                    }
                }

                foreach (var item in группыСпТехн)
                {
                    var кодГруппы = Guid.NewGuid().ToString();

                    foreach (var день in ДеньНедели.AllValues)
                    {
                        var row = vmoТаблицаГрафикаРаботы.Data.MemoryTable.NewRow();
                        row[ГруппаСпецТехники_vmoТаблицаГрафикаРаботы].Value = item.Key;
                        row[Количество_vmoТаблицаГрафикаРаботы].Value = item.Value;
                        row[ДеньНедели_vmoТаблицаГрафикаРаботы].Value = день;
                        row[ВремяНачаСмены1_vmoТаблицаГрафикаРаботы].Value = началоДействияГрафика;
                        row[КодГруппы_vmoТаблицаГрафикаРаботы].Value = кодГруппы;
                        row.Post();
                    }
                }

                ОбновитьГруппировкиГрафика();
                ОбновитьФильтрыНаГрафик();

                vmoТаблицаГрафикаРаботы.Data.UpdateDataSync(this);
            }
            else
            {
                NsgSettings.MainForm.ShowMessage("Не заполнены таблицы персонала и техники");
            }
        }

        private void nsgIGrid7_AfterAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateCopyElement)
            {
                var новыйКод = Guid.NewGuid().ToString();
                //e.RowObject[КодГруппы_vmoГруппировка].Value = новыйКод;
                КодГруппы_vmoГруппировка.Value = новыйКод;
                //e.RowObject[Количество_vmoГруппировка].Value = 1;
                Количество_vmoГруппировка.Value = 1;
                ОбновитьГрафикПоГруппировке(vmoГруппировкаГрафикаРаботы.Data.CurrentRow);
            }

            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                var новыйКод = Guid.NewGuid().ToString();
                //e.RowObject[КодГруппы_vmoГруппировка].Value = новыйКод;
                КодГруппы_vmoГруппировка.Value = новыйКод;
                //e.RowObject[Количество_vmoГруппировка].Value = 1;
                Количество_vmoГруппировка.Value = 1;
            }

            
        }

        private void nsgIGrid7_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            var код = e.RowObject[КодГруппы_vmoГруппировка].ToString();
            if (args.ToolType == NsgWorkPanelTools.CreateCopyElement)
            {
                var количество = e.RowObject[Количество_vmoГруппировка].ToInt();
                if (количество <= 1)
                {
                    e.Cancel = true;
                    NsgSettings.MainForm.ShowMessage("Неоюходимо добавить персонал или технику");
                    return;
                }
                else
                {
                    e.RowObject[Количество_vmoГруппировка].Value = --количество;
                }
            }
            
            
            
        }

        private void nsgIGrid8_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                e.Cancel = true;
                РегистрПерсоналОбъекта персоналОбъекта = РегистрПерсоналОбъекта.Новый();
                персоналОбъекта.New();
                персоналОбъекта.Объект = nsgVisualMultipleObject.Data.CurrentRow as Объекты;
                NsgSettings.MainForm.ShowObject(персоналОбъекта, this);
            }
        }

        private void nsgIGrid9_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                e.Cancel = true;
                РегистрТарифыПерсоналаОбъекта тарифыПерсоналаОбъекта = РегистрТарифыПерсоналаОбъекта.Новый();
                тарифыПерсоналаОбъекта.New();
                тарифыПерсоналаОбъекта.Объект = nsgVisualMultipleObject.Data.CurrentRow as Объекты;
                NsgSettings.MainForm.ShowObject(тарифыПерсоналаОбъекта, this);
            }
        }

        private void nsgIGrid10_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                e.Cancel = true;
                РегистрТехникаОбъекта техникаОбъекта = РегистрТехникаОбъекта.Новый();
                техникаОбъекта.New();
                техникаОбъекта.Объект = nsgVisualMultipleObject.Data.CurrentRow as Объекты;
                NsgSettings.MainForm.ShowObject(техникаОбъекта, this);
            }
        }

        private void nsgIGrid1_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.CreateNewElement)
            {
                e.Cancel = true;
                РегистрТарифыТехникиОбъекта тарифыТехникиОбъекта = РегистрТарифыТехникиОбъекта.Новый();
                тарифыТехникиОбъекта.New();
                тарифыТехникиОбъекта.Объект = nsgVisualMultipleObject.Data.CurrentRow as Объекты;
                NsgSettings.MainForm.ShowObject(тарифыТехникиОбъекта, this);
            }
        }
    }
    


}