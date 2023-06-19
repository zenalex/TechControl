using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Сотрудники
    {
        protected override List<Guid> BasePost()
        {
            if (ТаблицаРазмеров.Count > 0)
            {
                Размеры размер = Размеры.Новый();
                var cmp = new NsgCompare();
                cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.Размер, размер);
                var row = ТаблицаРазмеров.FindRow(cmp);
                if (row != null)
                {
                    throw new Exception($"Не заполнен размер {row.ВидСвойствНоменклатуры}");
                }
            }
            return base.BasePost();
        }

        public Размеры РазмерНоменклатуры(Номенклатура номенклатура) 
        {
            Размеры размер = Размеры.Новый();
            if (ТаблицаРазмеров.Count > 0)
            {
                var cmp = new NsgCompare();
                cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.ВидСвойствНоменклатуры, номенклатура.ВидНоменклатуры);
                var row = ТаблицаРазмеров.FindRow(cmp);
                if (row != null)
                {
                    размер = row.Размер;
                }
            }
            return размер;
        }
    }

}
