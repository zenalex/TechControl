using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Заправка
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
            РегистрЗаправок регистрЗаправок = РегистрЗаправок.Новый(this);
            регистрЗаправок.New();
            регистрЗаправок.ВидДвижения = Сервис.ВидыДвижений.Расход;
            регистрЗаправок.ДатаДокумента = this.ДатаДокумента;
            регистрЗаправок.Объект = this.Объект;
            регистрЗаправок.Техника = this.Техника;
            регистрЗаправок.Поставщик = this.Поставщик;
            регистрЗаправок.ОбъемТоплива = this.ОбъемТоплива;
            регистрЗаправок.AddMovement();
            return регистрЗаправок.Post();
        }
        #endregion //Методы
    }

}
