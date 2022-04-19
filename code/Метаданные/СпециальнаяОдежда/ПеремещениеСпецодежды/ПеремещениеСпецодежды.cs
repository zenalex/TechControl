using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.СпециальнаяОдежда
{
    
    public partial class ПеремещениеСпецодежды
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
            var учетСпецодежды = УчетСпецодежды.Новый(this);
            учетСпецодежды.New();
            foreach (var row in this.Таблица.Rows)
            {
                учетСпецодежды.Сотрудник = Сотрудник;
                учетСпецодежды.Спецодежда = row.Спецодежда;
                учетСпецодежды.Количество = row.Количество;
                учетСпецодежды.Стоимость = row.Стоимость;
                учетСпецодежды.ВидДвижения = Сервис.ВидыДвижений.Расход;
                учетСпецодежды.AddMovement();
            }
            return учетСпецодежды.Post();
        }
    }

}
