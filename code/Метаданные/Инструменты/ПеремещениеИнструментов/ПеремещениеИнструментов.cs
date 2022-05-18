using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Инструменты
{
    
    public partial class ПеремещениеИнструментов
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
            var учетИнструментов = УчетИнструментов.Новый(this);
            учетИнструментов.New();
            foreach (var row in this.Таблица.Rows)
            {
                учетИнструментов.Сотрудник = Сотрудник;
                учетИнструментов.Объект = Объект;
                учетИнструментов.Инструмент = row.Инструмент;
                учетИнструментов.Количество = row.Количество;
                учетИнструментов.Стоимость = row.Сумма;
                учетИнструментов.ИнвентарныйНомер = row.ИнвентарныйНомер;
                учетИнструментов.ДатаВыдачи = ДатаДокумента;

                if (ПризнакДвижения == Перечисления.ПризнакиДвижений.Возврат)
                    учетИнструментов.ВидДвижения = Сервис.ВидыДвижений.Приход;
                else
                    учетИнструментов.ВидДвижения = Сервис.ВидыДвижений.Расход;

                учетИнструментов.AddMovement();
            }
            return учетИнструментов.Post();
        }
    }

}
