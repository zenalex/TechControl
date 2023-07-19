using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Учет
{
    
    public partial class ФормированиеЦены
    {
        protected override bool Handling()
        {
            return ПроведениеПоРегиструЦен();
        }

        private bool ПроведениеПоРегиструЦен() 
        {
            var reg = РегистрЦен.Новый(this);
            reg.New();
            foreach (var item in Таблица.AllRows)
            {
                reg.Дата = ДатаДокумента;
                reg.Номенклатура = item.Номенклатура;
                reg.Размер = item.Размер;
                reg.ТипЦены = item.ТипЦены;
                reg.Цена = item.Цена;
                reg.AddMovement();
            }
            return reg.Post();
        }
    }

}
