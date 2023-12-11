using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using System.Linq;

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

        protected override List<Guid> BasePost()
        {
            if (ТаблицаГрафик.AllRows.Any(x => x.ВремяНачалаРабочегоДня == NsgService.MinDate))
            {
                throw new Exception($"В таблице есть строчки с незаполненным временем начала рабочего дня");
            }
            if (ТаблицаГрафик.AllRows.Any(x => x.ВремяКонцаРабочегоДня == NsgService.MinDate))
            {
                throw new Exception($"В таблице есть строчки с незаполненным временем конца рабочего дня");
            }

            if (ТаблицаГрафик.AllRows.Any(x => x.ВремяНачалаСмены1 == NsgService.MinDate))
            {
                foreach (var item in ТаблицаГрафик.AllRows)
                {
                    if (item.ВремяНачалаСмены1 == NsgService.MinDate)
                    {
                        item.ВремяНачалаСмены1 = item.ВремяНачалаРабочегоДня;
                        item.ВремяОкончанияСмены1 = item.ВремяКонцаРабочегоДня;
                    }
                }
            }
            return base.BasePost();
        }

        public bool ТребуетсяВыходНаРаботу(DateTime дата, int номерСмены = 1) 
        {
            foreach (var item in ТаблицаГрафик.AllRows)
            {
                if (item.ДеньНедели == ДеньНедели.ByDayOfWeek[дата.DayOfWeek] && item.ВремяНачалаРабочегоДня.TimeOfDay <= дата.TimeOfDay && item.ВремяКонцаРабочегоДня.TimeOfDay >= дата.TimeOfDay)
                {
                    if (номерСмены == 1 && item.ВремяНачалаСмены1.TimeOfDay <= дата.TimeOfDay && item.ВремяОкончанияСмены1.TimeOfDay >= дата.TimeOfDay)
                    {
                        return true;
                    }

                    if (номерСмены == 2 && item.ВремяНачалаСмены2.TimeOfDay <= дата.TimeOfDay && item.ВремяОкончанияСмены2.TimeOfDay >= дата.TimeOfDay)
                    {
                        return true;
                    }
                    if (номерСмены == 3 && item.ВремяНачалаСмены3.TimeOfDay <= дата.TimeOfDay && item.ВремяОкончанияСмены3.TimeOfDay >= дата.TimeOfDay)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
