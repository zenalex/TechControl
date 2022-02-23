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
            РегистрМониторингТехники рег = РегистрМониторингТехники.Новый();
            рег.New();
            рег.Объекты = this.Объект;
            foreach (var i in this.Таблица.Rows)
            {
                рег.Сотрудники = i.Сотрудник;
                рег.Техника = i.Техника;
                рег.СтатусТехники = i.СтатусТехники;
                рег.AddMovement();
            }
            return рег.Post();
        }
        #endregion //Методы
    }

}
