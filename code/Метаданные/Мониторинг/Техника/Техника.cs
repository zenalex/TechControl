using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using static NsgSoft.ReportBuilder.Func;
using System.Linq;
using static NsgSoft.ReportBuilder.Design.Images.StiReportDesignImages;



namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Техника
    {
        public static Техника ПоискТехникиПоГосНомеру(string госНомер) 
        {
            if (!string.IsNullOrEmpty(госНомер))
            {
                var cmp = new NsgCompare();
                var cmpOr = new NsgCompare(NsgLogicalOperator.Or);
                cmpOr.Add(Техника.Names.ГосНомер, госНомер);
                cmpOr.Add(Техника.Names.ГосНомер, госНомер.Replace(" ", ""));
                cmpOr.Add(Техника.Names.ГосНомер, ФорматироватьГосномер(госНомер.Replace(" ", "")));
                cmp.Add(cmpOr);
                cmp.Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                var техника = Техника.Новый();
                if (техника.Find(cmp))
                {
                    return техника;
                }
                else
                {
                    throw new Exception("Техника с указанным гос номером не найдена");
                }
            }
            else
            {
                throw new Exception("необходимо указать гос номер техники");
            }
        }

        public static string ФорматироватьГосномер(string госНомерБезПробелов)
        {
            if ((!string.IsNullOrEmpty(госНомерБезПробелов)) && госНомерБезПробелов.Length > 9)
            {
                var sb = new StringBuilder();
                int[] позицииРазделителей = new int[] { 1, 4, 6 };
                int первыйДопРазделитель = 8;
                int второйДопРазделитель = 9;

                for (int i = 0; i < госНомерБезПробелов.Length; i++)
                {
                    if (позицииРазделителей.Contains(i) || (i == первыйДопРазделитель && !char.IsDigit(госНомерБезПробелов[i + 1])) || (i == второйДопРазделитель && госНомерБезПробелов.Length > второйДопРазделитель))
                    {
                        sb.Append(" ");
                    }

                    sb.Append(госНомерБезПробелов[i]);
                }
                return sb.ToString();
            }
            else
            {
                throw new Exception("необходимо указать гос номер техники или номер слишком короткий");
            }
        }
    }

}
