using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    public partial class Мерки
    {
        public bool МеркаЗаполнена => БоковаяДлинаБрюк != 0
            || ДлинаБрюкПоВнутреннемуШву != 0
            || ДлинаРукава != 0
            || ДлинаСтопы != 0
            || ОбхватБедер != 0
            || ОбхватГоловы != 0
            || ОбхватГруди != 0
            || ОбхватТалии != 0
            || ОбхватШеи != 0
            || Рост != 0;

        protected override List<Guid> BasePost()
        {
            return base.BasePost();
        }
    }

}
