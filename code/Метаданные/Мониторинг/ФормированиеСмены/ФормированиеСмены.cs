using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСмены
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        protected override bool Handling()
        {
            //Get rest по ФиксацияИстории на дату документа - тик. Оттуда берем время работы. Если статус в работе не менялся в ФиксацияИстории пишем старое время.
            //в РегистрСмен пишем время в работе 
            var рег = ФиксацияИстории.Новый();
            рег.New();
            рег.Объект = this.Объект;
            foreach (var i in this.Таблица.Rows)
            {
                рег.Время = DateTime.Now;
                рег.Сотрудник = i.Сотрудник;
                рег.Техника = i.Техника;
                рег.СтатусТехники = i.СтатусТехники;
                рег.AddMovement();
            }
            return рег.Post();


            var регСмены = РегистрСмен.Новый();
            регСмены.New();
            foreach (var i in this.Таблица.Rows)
            {
                if (i.СтатусТехники != СтатусТехники.ВРаботе)
                {
                    регСмены.Объект = this.Объект;
                    регСмены.Сотрудник = i.Сотрудник;
                    регСмены.Техника = i.Техника;
                    регСмены.ОтработанноеВремя = 0;
                    регСмены.Сумма = 0; //Брать из текущего тарифа по объекту * время работы
                    регСмены.AddMovement();
                }
            }
            return регСмены.Post();
        }
        #endregion //Методы
    }

}
