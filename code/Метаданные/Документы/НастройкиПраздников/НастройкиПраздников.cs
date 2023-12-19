using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using System.Linq;



namespace TechControl.Метаданные.Документы
{
    
    public partial class НастройкиПраздников
    {
        public static bool ЯвляетсяВыходным(DateTime дата, Объекты объект)
        {
            var cmp = new NsgCompare();
            var cmpНаГод = new NsgCompare();
            cmpНаГод.Add(НастройкиПраздников.Names.Год, new DateTime(дата.Year, 1, 1));
            cmpНаГод.Add(НастройкиПраздников.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            cmp.Add(cmpНаГод);
            if (объект != null && объект.Selected)
            {
                cmp.Add(НастройкиПраздников.Names.Объект, объект);
            }
            var праздники = НастройкиПраздников.Новый();
            if (праздники.Find(cmp))
            {
                return праздники.ТаблицаПраздников.AllRows.Any(x => x.Дата.Date == дата.Date);
            }
            else if (праздники.Find(cmpНаГод))
            {
                return праздники.ТаблицаПраздников.AllRows.Any(x => x.Дата.Date == дата.Date);
            }
            else
            {
                return false;
            }
        }
    }

}
