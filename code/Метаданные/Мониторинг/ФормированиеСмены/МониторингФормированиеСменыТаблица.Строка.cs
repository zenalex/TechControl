using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;

namespace TechControl.Метаданные._SystemTables
{
    public partial class МониторингФормированиеСменыТаблица
{
    public partial class Строка
    {
            public bool БылаЗаправкаВТечениеСмены()
            {
                РегистрЗаправок регистрЗаправок = РегистрЗаправок.Новый();
                регистрЗаправок.New();
                NsgCompare cmp = new NsgCompare()
                    .Add(РегистрЗаправок.Names.Техника, this.Техника);
                if (this.СтатусТехники == СтатусТехники.ВРаботе)
                {
                    var rests = регистрЗаправок.GetCirculate(this.Время, DateTime.Now, cmp);
                    return rests.Count > 0;
                }
                else
                {
                    ФиксацияИстории фиксацияИстории = ФиксацияИстории.Новый();
                    фиксацияИстории.New();
                    фиксацияИстории.Техника = this.Техника;
                    фиксацияИстории.GetRest(this.Время.AddSeconds(-1));
                    if (фиксацияИстории.СтатусТехники == СтатусТехники.ВРаботе)
                    {
                        var rests = регистрЗаправок.GetCirculate(фиксацияИстории.Дата, this.Время, cmp);
                        return rests.Count > 0;
                    }
                }
                return false;
            }
        }
}
}
