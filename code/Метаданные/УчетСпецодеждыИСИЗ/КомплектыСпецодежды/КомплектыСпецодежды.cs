using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class КомплектыСпецодежды
    {
        protected override List<Guid> BasePost()
        {
            if (ТаблицаКомплектаСпецодежды.Count > 0)
            {
                var cmp = new NsgCompare();
                cmp.Add(УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Names.Количество, 0);
                var нулевыеСтроки = ТаблицаКомплектаСпецодежды.FindRows(cmp);
                if (нулевыеСтроки != null && нулевыеСтроки.Length > 0)
                {
                    foreach (var item in нулевыеСтроки)
                    {
                        item.Количество = 1;
                    }
                }
            }
            return base.BasePost();
        }
    }

}
