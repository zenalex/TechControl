using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Документы
{
    
    public partial class ЗаявкиНаТехнику
    {
        public override void New()
        {
            base.New();
            this.КолВоМашин = 1;
        }
    }

}
