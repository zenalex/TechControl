using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using System.Linq;



namespace TechControl.Метаданные.Документы
{
    
    public partial class ПлановыйГрафикРаботы
    {
        public bool ТребуетсяВыход(DateTime дата) 
        {
            return ТаблицаПодробныйГрафик.AllRows.First(x => x.ДеньМесяца == дата.Day).РабочийДень;
        }
    }

}
