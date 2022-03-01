using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ОтработанноеВремяТехники
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        #endregion //Методы

        protected override bool Handling()
        {
            var рег = РегистрОтработанногоВремени.Новый();
            foreach (var row in this.Таблица.Rows)
            {
                рег.New();
                рег.Техника = row.Техника;
                рег.ДатаНачалаРаботы = row.ДатаНачалаРаботы;
                рег.ДатаОкончанияРаботы = row.ДатаОкончанияРаботы;
                рег.ДлительностьРаботы = row.ДлительностьРаботы;
                рег.КоличествоЗаправок = row.КоличествоЗаправок;
                рег.КонечныйЗапасТоплива = row.КонечныйЗапасТоплива;
                рег.НачальныйЗапасТоплива = row.НачальныйЗапасТоплива;
                рег.общийОбъемЗаправленногоТоплива = row.общийОбъемЗаправленногоТоплива;
                рег.AddMovement();
            }

            return рег.Post();
        }
    }

}
