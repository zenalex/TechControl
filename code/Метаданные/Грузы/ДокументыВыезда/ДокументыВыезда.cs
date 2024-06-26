using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Грузы
{
    
    public partial class ДокументыВыезда
    {
        protected override bool Handling()
        {
            var reg = РегистрПеремещениеЧерезКПП.Новый(this);
            reg.Объект = Объект;
            reg.Техника = Техника;
            reg.НахождениеНаОбъекте = 1;
            reg.КПП = КПП;
            reg.ВидДвижения = Сервис.ВидыДвижений.Расход;
            reg.AddMovement();
            
            return reg.Post();
        }
    }

}
