using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Объекты
    {
        protected override List<Guid> BasePost()
        {
            if (this.СостояниеДокумента != Сервис.СостоянияОбъекта.Создан && !ЗаправочнаяЕмкость.Selected)
            {
                var r = FindAllRequisits(new NsgCompare().Add(Names.Идентификатор, Идентификатор), Names.ЗаправочнаяЕмкость)
                    .Rows[0][Names.ЗаправочнаяЕмкость].ToReferent() as Объекты;
                if (!r.Selected)
                {
                    r.New();
                    r.Адрес = Адрес;
                    r.АккаунтПользователя = АккаунтПользователя;
                    r.Наименование = Наименование + " заправочная емкость";
                    r.ЗаправочнаяЕмкость = r;
                    r.Post();
                }
                ЗаправочнаяЕмкость = r;
            }
            return base.BasePost();
        }
    }

}
