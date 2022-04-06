using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСмены
    {
        protected override List<Guid> BasePost()
        {
            if (this.ЭтоИтоговыйДокумент)
            {
                if (!this.Объект.Selected) return new List<Guid>();
                string ВРЕМЯНАЧАЛАСМЕНЫ = МониторингРежимыРаботыТаблицаГрафик.Names.ВремяНачалаСмены1.Substring(0,
                    МониторингРежимыРаботыТаблицаГрафик.Names.ВремяНачалаСмены1.Length - 1);
                //string ВРЕМЯОКОНЧАНИЯСМЕНЫ = МониторингРежимыРаботыТаблицаГрафик.Names.ВремяОкончанияСмены1.Substring(0,
                //    МониторингРежимыРаботыТаблицаГрафик.Names.ВремяОкончанияСмены1.Length - 1);
                var rr = this.Объект.РежимРаботы.ТаблицаГрафик.FindRow(new NsgCompare()
                    .Add(МониторингРежимыРаботыТаблицаГрафик.Names.ДеньНедели, ДеньНедели.ByDayOfWeek[this.ДатаДокумента.DayOfWeek]));
                var строкиТехника = new List<МониторингФормированиеСменыТаблица.Строка>();
                foreach (var i in this.Таблица.Rows)
                {
                    if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                    DateTime dateTime;
                    if (rr == null)
                    {
                        dateTime = this.ДатаДокумента;
                    }
                    else
                    {
                        dateTime = (i.НомерСмены == 0) ? rr.ВремяНачалаРабочегоДня : rr[ВРЕМЯНАЧАЛАСМЕНЫ + i.НомерСмены].ToDateTime();
                    }
                    var _cmp = new NsgCompare()
                        .Add(МониторингФормированиеСменыТаблица.Names.Техника, i.Техника);
                    var prRow =
                        строкиТехника.FindLast(r =>
                        _cmp.IsValidObject(r));
                    if (prRow != null)
                    {
                        dateTime = dateTime.AddHours((double)prRow.Длительность);
                    }
                    i.Время = this.ДатаДокумента.Date.Add(dateTime.Subtract(dateTime.Date));
                    if (!i.Тариф.Selected) i.Тариф = this.Тариф;
                    i.Post();
                    строкиТехника.Add(i);
                }
                var строкиПерсонал = new List<МониторингФормированиеСменыТаблицаПерсонал.Строка>();
                foreach (var i in this.ТаблицаПерсонал.Rows)
                {
                    if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                    DateTime dateTime;
                    if(rr == null)
                    {
                        dateTime = this.ДатаДокумента;
                    }
                    else
                    {
                        dateTime = (i.НомерСмены == 0) ? rr.ВремяНачалаРабочегоДня : rr[ВРЕМЯНАЧАЛАСМЕНЫ + i.НомерСмены].ToDateTime();
                    }
                    var _cmp = new NsgCompare()
                        .Add(МониторингФормированиеСменыТаблица.Names.Сотрудник, i.Сотрудник)
                        .Add(МониторингФормированиеСменыТаблица.Names.НомерСмены, i.НомерСмены)
                        .Add(МониторингФормированиеСменыТаблица.Names.Тариф, i.Тариф);
                    var prRow =
                        строкиПерсонал.FindLast(r =>
                        _cmp.IsValidObject(r));
                    if (prRow != null)
                    {
                        dateTime = dateTime.AddHours((double)prRow.Длительность);
                    }
                    i.Время = this.ДатаДокумента.Date.Add(dateTime.Subtract(dateTime.Date));
                    if (!i.Тариф.Selected) i.Тариф = this.Тариф;
                    i.Post();
                }
            }
            else
            {
                foreach (var i in this.Таблица.Rows)
                {
                    i.Время = this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                    if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                    i.Post();
                }
                foreach (var i in this.ТаблицаПерсонал.Rows)
                {
                    i.Время = this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                    if (i.НомерСмены < 0 || i.НомерСмены > 3) i.НомерСмены = 0;
                    i.Post();
                }
            }
            return base.BasePost();
        }

        protected override bool Handling()
        {
            List<Техника> t = new List<Техника>();
            bool error = false;
            StringBuilder ts = new StringBuilder();
            foreach (var i in this.Таблица.Rows)
            {
                if (!i.Техника.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица техники: В некоторых строках не выбрана техника",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (!i.Тариф.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица техники: В некоторых строках не выбран тариф",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                var tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                    .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                    .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, i.Техника.ГруппаСпецТехники, NsgComparison.EqualOrEmpty));
                if (tariff == null)
                {
                    NsgSettings.MainForm.ShowMessage(
                        $"Таблица техники: нужен тариф из заданных на объекте для той группы техники, к которой относится выбранная техника",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (!i.Сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица техники: В некоторых строках не выбран сотрудник",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (t.Contains(i.Техника))
                {
                    error = !this.ЭтоИтоговыйДокумент;
                    ts.Append('\n' + i.Техника.ToString());
                }
                t.Add(i.Техника);
            }
            if (error)
            {
                NsgSettings.MainForm.ShowMessage($"Техника не должна встречаться более одного раза:" + ts.ToString(),
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            List<Сотрудники> s = new List<Сотрудники>();
            error = false;
            ts.Clear();
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                if (!i.Тариф.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица персонала: В некоторых строках не выбран тариф",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                //var tariff = this.Объект.ТаблицаТарифы.FindRow(new NsgCompare()
                //    .Add(МониторингОбъектыТаблицаТарифы.Names.Тариф, i.Тариф)
                //    .Add(МониторингОбъектыТаблицаТарифы.Names.ГруппаСпецТехники, ГруппыСпецТехники.Новый()));
                //if (tariff == null)
                //{
                //    NsgSettings.MainForm.ShowMessage($"Таблица персонала: нужен тариф из заданных на объекте",
                //        System.Windows.Forms.MessageBoxIcon.Error);
                //    return false;
                //}
                if (!i.Сотрудник.Selected)
                {
                    NsgSettings.MainForm.ShowMessage($"Таблица персонала: В некоторых строках не выбран сотрудник",
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                if (s.Contains(i.Сотрудник))
                {
                    error = true;
                    ts.Append('\n' + i.Сотрудник.ToString());
                }
                s.Add(i.Сотрудник);
            }
            if (error)
            {
                NsgSettings.MainForm.ShowMessage($"Сотрудник не должен встречаться более одного раза:" + ts.ToString(),
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }

            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var рег = ФиксацияИстории.Новый(this);
            рег.New();
            рег.Объект = this.Объект;
            рег.Владелец = this;

            var регСмены = РегистрСмен.Новый(this);
            регСмены.New();

            if (this.ЭтоИтоговыйДокумент)
            {
                #region техника
                foreach (var i in this.Таблица.Rows)
                {
                    // начать смену
                    рег.Сотрудник = i.Сотрудник;
                    рег.Техника = i.Техника;
                    рег.НомерСмены = i.НомерСмены;
                    рег.Тариф = (i.Тариф.Selected) ? i.Тариф : this.Тариф;
                    рег.СтатусТехники = СтатусТехники.ВРаботе;
                    рег.Дата = рег.Время = i.Время;
                    рег.Владелец = this;
                    рег.AddMovement();

                    // завершить смену
                    //(i.НомерСмены == 0) ?
                    //rr.ВремяНачалаРабочегоДня :
                    //rr[ВРЕМЯОКОНЧАНИЯСМЕНЫ + i.НомерСмены].ToDateTime();
                    рег.Сотрудник = i.Сотрудник;
                    рег.Техника = i.Техника;
                    рег.НомерСмены = i.НомерСмены;
                    рег.Тариф = (i.Тариф.Selected) ? i.Тариф : this.Тариф;
                    рег.СтатусТехники = СтатусТехники.НеРаботает;
                    рег.Дата = рег.Время = i.Время.AddHours((double)i.Длительность);

                    регСмены.ДатаДокумента = рег.Время;
                    регСмены.Объект = this.Объект;
                    регСмены.Сотрудник = i.Сотрудник;
                    регСмены.Техника = i.Техника;
                    регСмены.НомерСмены = i.НомерСмены;
                    регСмены.ОтработанноеВремя = i.Длительность;
                    регСмены.Сумма = рег.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                    регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                    регСмены.AddMovement();

                    рег.Владелец = this;
                    рег.AddMovement();
                }
                #endregion
                #region TODO: персонал
                #endregion
            }
            else
            {
                #region техника
                foreach (var i in this.Таблица.Rows)
                {
                    рег.Сотрудник = i.Сотрудник;
                    рег.Техника = i.Техника;
                    рег.НомерСмены = i.НомерСмены;
                    рег.GetRest(i.Время.AddTicks(-1));
                    var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
                    рег.Тариф = (i.Тариф.Selected) ? i.Тариф : this.Тариф;
                    рег.СтатусТехники = i.СтатусТехники;
                    if (i.СтатусТехники != СтатусТехники.ВРаботе && предСтатусТехники == СтатусТехники.ВРаботе)
                    {
                        var предВремя = рег.Время;
                        рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                            this.ДатаДокумента :
                            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                        регСмены.ДатаДокумента = рег.Время;
                        регСмены.Объект = this.Объект;
                        регСмены.Сотрудник = i.Сотрудник;
                        регСмены.Техника = i.Техника;
                        регСмены.НомерСмены = i.НомерСмены;
                        регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                        регСмены.Сумма = рег.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                        регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                        регСмены.AddMovement();
                    }
                    else
                    {
                        рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                            this.ДатаДокумента :
                            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                    }
                    рег.Владелец = this;
                    рег.AddMovement();
                }
                #endregion
                //if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
                #region персонал
                //foreach (var i in this.ТаблицаПерсонал.Rows)
                //{
                //    рег.Сотрудник = i.Сотрудник;
                //    рег.НомерСмены = i.НомерСмены;
                //    рег.GetRest(i.Время.AddTicks(-1));
                //    var предСтатусСотрудника = рег.СтатусСотрудника.Clone as СтатусСотрудника;
                //    рег.Тариф = (i.Тариф.Selected) ? i.Тариф : this.Тариф;
                //    if (i.СтатусСотрудника != СтатусСотрудника.НаРаботе && предСтатусСотрудника == СтатусСотрудника.НаРаботе)
                //    {
                //        var предВремя = рег.Время;
                //        рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                //            this.ДатаДокумента :
                //            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                //        регСмены.ДатаДокумента = рег.Время;
                //        регСмены.Объект = this.Объект;
                //        регСмены.Сотрудник = i.Сотрудник;
                //        регСмены.НомерСмены = i.НомерСмены;
                //        регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                //        регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                //        регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                //        регСмены.AddMovement();
                //    }
                //    else
                //    {
                //        рег.Дата = рег.Время = i.Время == NsgService.MinDate ?
                //            this.ДатаДокумента :
                //            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date));
                //    }
                //    рег.Владелец = this;
                //    рег.AddMovement();
                //}
                #endregion
            }
            if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            рег.Владелец = this;

            return рег.Post();
        }

        protected override void OnAfterHandle(HandleEventArgs e)
        {
            base.OnAfterHandle(e);
            ФиксацияИстории фиксацияИстории = ФиксацияИстории.Новый();
            foreach (var i in this.Таблица.Rows)
            {
                var t = i.Техника;
                фиксацияИстории.New();
                фиксацияИстории.Техника = t;
                фиксацияИстории.GetRest(DateTime.Now);
                if (t.Статус != фиксацияИстории.СтатусТехники)
                {
                    t.Edit();
                    t.Статус = фиксацияИстории.СтатусТехники;
                    t.Post();
                }
            }
            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                var t = i.Сотрудник;
                фиксацияИстории.New();
                фиксацияИстории.Сотрудник = t;
                //фиксацияИстории.GetRest(DateTime.Now);
                if (t.Статус != i.СтатусСотрудника)//фиксацияИстории.СтатусТехники)
                {
                    t.Edit();
                    t.Статус = i.СтатусСотрудника;
                    t.Post();
                }
            }
        }
    }

}
