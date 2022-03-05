using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ЗакрытиеСмен
    {
        protected override bool Handling()
        {
            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var рег = ФиксацияИстории.Новый();
            рег.New();
            рег.Объект = this.Объект;

            var регСмены = РегистрСмен.Новый();
            регСмены.New();
            регСмены.Document = this;

            //foreach (var i in this.Таблица.Rows)
            {
                рег.Сотрудник = i.Сотрудник;
                рег.Техника = i.Техника;
                рег.GetRest(this.ДатаДокумента.AddTicks(-1));
                var предСтатусТехники = рег.СтатусТехники.Clone as СтатусТехники;
                рег.СтатусТехники = i.СтатусТехники;
                if (i.СтатусТехники != СтатусТехники.ВРаботе)
                {
                    if (предСтатусТехники == СтатусТехники.ВРаботе)
                    {
                        var предВремя = рег.Время;
                        рег.Время = i.Время.Date == NsgService.MinDate ?
                            this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                            i.Время;
                        регСмены.Объект = this.Объект;
                        регСмены.Сотрудник = i.Сотрудник;
                        регСмены.Техника = i.Техника;
                        регСмены.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(рег.Время - предВремя).TotalHours;
                        регСмены.Сумма = this.Тариф.Стоимость * регСмены.ОтработанноеВремя;
                        регСмены.ВидДвижения = Сервис.ВидыДвижений.Расход;
                        регСмены.AddMovement();
                    }
                }
                else
                {
                    рег.Время = i.Время.Date == NsgService.MinDate ?
                        this.ДатаДокумента.Date.Add(i.Время.Subtract(i.Время.Date)) :
                        i.Время;
                }
                рег.AddMovement();
            }
            if (регСмены.MovementTable.Count > 0 && !регСмены.Post()) return false;
            return рег.Post();
        }
    }

}
