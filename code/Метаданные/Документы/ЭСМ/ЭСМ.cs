using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Документы
{
    
    public partial class ЭСМ
    {
        protected override List<Guid> BasePost()
        {
            if (!СотрудникПодписант.Selected && !ДолжностьПодписанта.Selected)
            {
                if (Объект.Selected && Объект.ДоговорСсылка.Selected && Объект.ДоговорСсылка.СотрудникПодписант.Selected)
                {
                    СотрудникПодписант = Объект.ДоговорСсылка.СотрудникПодписант;
                    ДолжностьПодписанта = Объект.ДоговорСсылка.ДолжностьПодписанта;
                }
                else if (Объект.Selected && Объект.Фирма.Selected && Объект.Фирма.СотрудникПодписант.Selected)
                {
                    СотрудникПодписант = Объект.Фирма.СотрудникПодписант;
                    ДолжностьПодписанта = Объект.Фирма.ДолжностьПодписанта;
                }
            }
            return base.BasePost();
        }
    }

}
