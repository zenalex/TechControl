using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class РежимыРаботы
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        #endregion //Методы
        public override void New()
        {
            base.New();
            var неделя = Мониторинг.ДеньНедели.ByDayOfWeek;

            foreach (var day in неделя)
            {
                var row = ТаблицаГрафик.NewRow();
                row.ДеньНедели = day.Value;
                row.Post();
            }
        }
    }

}
