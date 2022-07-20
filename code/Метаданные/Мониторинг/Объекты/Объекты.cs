using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Объекты
    {
        protected override List<Guid> BasePost()
        {
            if (this.СостояниеДокумента != Сервис.СостоянияОбъекта.Создан && !ЗаправочнаяЕмкость.Selected)
            {
                var r = FindAllRequisits(new NsgCompare().Add(Names.Идентификатор, Идентификатор), Names.ЗаправочнаяЕмкость)
                    .Rows[0][Names.ЗаправочнаяЕмкость].ToReferent() as Техника;
                if (!r.Selected)
                {
                    var row = ТаблицаТехника.FindRow(new NsgCompare()
                        .Add(МониторингОбъектыТаблицаТехника.Names.Техника, Техника.Новый(), NsgComparison.NotEqual));
                    if (row != null)
                    {
                        r = row[МониторингОбъектыТаблицаТехника.Names.Техника].ToReferent() as Техника;
                    }
                    else
                    {
                        r.New();
                        r.АккаунтПользователя = АккаунтПользователя;
                        r.Наименование = Наименование + " - заправочная емкость";
                        r.Post();
                    }
                }
                ЗаправочнаяЕмкость = r;
            }
            return base.BasePost();
        }
    }

}
