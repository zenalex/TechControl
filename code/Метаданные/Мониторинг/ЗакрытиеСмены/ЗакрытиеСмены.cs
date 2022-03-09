using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{

    public partial class ЗакрытиеСмены
    {
        protected override bool Handling()
        {
            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var фи = ФиксацияИстории.Новый();
            фи.New();
            фи.Владелец = this;
            фи.Объект = this.Объект;
            фи.Техника = this.Техника;
            var фи2 = ФиксацияИстории.Новый();
            фи2.Владелец = this;
            фи2.Объект = this.Объект;
            фи2.Техника = this.Техника;
            фи2.GetRest(this.Время);
            if (фи2.СтатусТехники == СтатусТехники.ВРаботе)
            {
                //РегистрСмен рс2 = РегистрСмен.Новый();
                //рс2.Техника = this.Техника;
                //рс2.GetRest();

                var предВремя = фи2.Дата;
                РегистрСмен рс = РегистрСмен.Новый();
                фи.New();
                рс.New();
                рс.Document = this;//vl as NsgDataDocument;
                //var vl = this.ДокументОснование;
                рс.Техника = фи.Техника = this.Техника;
                рс.Объект = фи.Объект = this.Объект;
                decimal price = 0;
                if (фи2.Владелец is ФормированиеСмены)
                {
                    var doc = фи2.Владелец as ФормированиеСмены;
                    price = doc.Тариф.Стоимость;
                }
                else
                {
                    рс.GetRest(this.Время);
                    price = (рс.ОтработанноеВремя == 0) ? 0 : рс.Сумма / рс.ОтработанноеВремя;
                }
                рс.Сотрудник = фи.Сотрудник = фи2.Сотрудник;
                //рс.Сотрудник = фи.Сотрудник = i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники;
                //DateTime dt = NsgService.EndOfDay(this.Время);
                рс.ДатаДокумента = фи.Дата = фи.Время = NsgService.EndOfDay(this.ДатаДокумента);//.Время;//.AddSeconds(-1);
                фи.СтатусТехники = СтатусТехники.НеРаботает;
                фи.Владелец = this;
                фи.AddMovement();
                //фи.Post();

                //var предВремя = this.ДокументОснование[ФормированиеСмены.Names.ДатаДокумента].ToDateTime();
                рс.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(фи.Время - предВремя).TotalHours;
                рс.Сумма = price * рс.ОтработанноеВремя;
                рс.ВидДвижения = Сервис.ВидыДвижений.Расход;
                рс.AddMovement();
                рс.Post();

                //фи.New();
                фи.Техника = this.Техника;
                фи.Объект = this.Объект;
                //фи.Сотрудник = i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники;
                фи.Дата = фи.Время = NsgService.BeginOfDay(this.ДатаДокумента.AddDays(1));
                фи.СтатусТехники = СтатусТехники.ВРаботе;
                фи.Владелец = this;
                фи.AddMovement();
                фи.Post();
            }
            //фи.Дата = фи.Время = this.Время;

            {
                //var регСмены = РегистрСмен.Новый();
                //регСмены.New();
                //регСмены.Document = this;

                ////foreach (var i in this.Таблица.Rows)
                //{
                //    //рег.Сотрудник = i.Сотрудник;
                //    //рег.Техника = i.Техника;
                //    рег.GetRest(this.ДатаДокумента.AddTicks(-1));
                //    var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
                //    рег.СтатусТехники = i.СтатусТехники;
                //    if (i.СтатусТехники != СтатусТехники.ВРаботе)
                //    {
                //        if (предСтатусТехники == СтатусТехники.ВРаботе)
                //        {
                //            var предВремя = рег.Время;
                //            рег.Время = i.Время.Date == NsgService.MinDate ?
                //                this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                //                i.Время;
                //            регСмены.Объект = this.Объект;
                //            регСмены.Сотрудник = i.Сотрудник;
                //            регСмены.Техника = i.Техника;
                //            регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                //            регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                //            регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                //            регСмены.AddMovement();
                //        }
                //    }
                //    else
                //    {
                //        рег.Время = i.Время.Date == NsgService.MinDate ?
                //            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                //            i.Время;
                //    }
                //    рег.AddMovement();
                //}
            }
            //if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            return true;//фи.Post();


            //рег.GetRest(this.ДатаДокумента.AddTicks(-1));
            ///*var */
            //регСмены = РегистрСмен.Новый();
            //регСмены.New();
            //foreach (var i in this.Таблица.Rows)
            //{
            //    if (i.СтатусТехники != СтатусТехники.ВРаботе)
            //    {
            //        регСмены.Объект = this.Объект;
            //        регСмены.Сотрудник = i.Сотрудник;
            //        регСмены.Техника = i.Техника;
            //        регСмены.ОтработанноеВремя = 0;
            //        регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя; //Брать из текущего тарифа по объекту * время работы
            //        регСмены.AddMovement();
            //    }
            //}
            //return регСмены.Post();
        }
    }

}
