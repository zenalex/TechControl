using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Документы;
using System.Linq;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Объекты
    {
        protected override List<Guid> BasePost()
        {
            if (this.ObjectState != NsgObjectStates.New && !ЗаправочнаяЕмкость.Selected)
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

        public ГрафикРаботыОбъекта ДействующийНаДатуГрафикРаботы(DateTime дата) 
        {
            var cmp = new NsgCompare();
            cmp.Add(ГрафикРаботыОбъекта.Names.ДатаНачалаДействияГрафика, дата, NsgComparison.LessOrEqual);
            cmp.Add(ГрафикРаботыОбъекта.Names.ДатаНачалаДействияГрафика, NsgService.MinDate, NsgComparison.NotEqual);
            cmp.Add(ГрафикРаботыОбъекта.Names.Объект, this);
            cmp.Add(ГрафикРаботыОбъекта.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var графики = ГрафикРаботыОбъекта.Новый().FindAll(cmp);
            if (графики.Length > 0)
            {
                return графики.OrderByDescending(x => x.ДатаНачалаДействияГрафика).First();
            }
            else
            {
                NsgSettings.MainForm.ShowMessage($"На объекте отсуттствуют действующие на {дата} графики работы"); 
                return ГрафикРаботыОбъекта.Новый();
            }
        }
    }

}
