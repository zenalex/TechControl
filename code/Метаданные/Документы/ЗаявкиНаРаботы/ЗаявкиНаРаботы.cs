using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Документы
{
    
    public partial class ЗаявкиНаРаботы
    {
        protected override List<Guid> BasePost()
        {
            if (Идентификатор != Guid.Empty && Объект != null && Объект.Selected)
            {
                var cmp = new NsgCompare();
                cmp.Add(ЗаявкиНаРаботы.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
                cmp.Add(ЗаявкиНаРаботы.Names.Объект, Объект);
                var cmpOr = new NsgCompare(NsgLogicalOperator.Or);
                cmpOr.Add(ЗаявкиНаРаботы.Names.ДатаОкончанияРаботПоОбъекту, NsgService.MinDate);
                cmpOr.Add(ЗаявкиНаРаботы.Names.ДатаОкончанияРаботПоОбъекту, ДатаДокумента, NsgComparison.GreaterOrEqual);
                cmp.Add(cmpOr);
                var заявка = ЗаявкиНаРаботы.Новый();
                if (заявка.Find(cmp))
                {
                    throw new Exception($"Уже существует заявка по объекту {Объект}");
                }
            }
            
            return base.BasePost();
        }
    }

}
