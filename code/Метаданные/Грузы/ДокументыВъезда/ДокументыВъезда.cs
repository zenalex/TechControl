using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Грузы
{
    
    public partial class ДокументыВъезда
    {
        protected override bool Handling()
        {
            var reg = РегистрПеремещениеЧерезКПП.Новый(this);
            reg.New();
            reg.Объект = Объект;
            reg.Техника = Техника;
            reg.НахождениеНаОбъекте = 1;
            reg.КПП = КПП;
            reg.ВидГруза = ВидГруза;
            reg.ОбъемГруза = ОбъемГруза;
            reg.ВидДвижения = Сервис.ВидыДвижений.Приход;
            reg.AddMovement();
            
            return reg.Post();
        }
    }

}
