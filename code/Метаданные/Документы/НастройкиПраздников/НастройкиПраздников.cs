using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using System.Linq;



namespace TechControl.Метаданные.Документы
{
    
    public partial class НастройкиПраздников
    {
        public static bool ЯвляетсяВыходным(DateTime дата, Объекты объект)
        {
            var cmp = new NsgCompare();
            var cmpНаГод = new NsgCompare();
            cmpНаГод.Add(НастройкиПраздников.Names.Год, new DateTime(дата.Year, 1, 1));
            cmpНаГод.Add(НастройкиПраздников.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            cmp.Add(cmpНаГод);
            if (объект != null && объект.Selected)
            {
                cmp.Add(НастройкиПраздников.Names.Объект, объект);
            }
            var праздники = НастройкиПраздников.Новый();
            if (праздники.Find(cmp))
            {
                return праздники.ТаблицаПраздников.AllRows.Any(x => x.Дата.Date == дата.Date);
            }
            else if (праздники.Find(cmpНаГод))
            {
                return праздники.ТаблицаПраздников.AllRows.Any(x => x.Дата.Date == дата.Date);
            }
            else
            {
                return false;
            }
        }

        public void ЗаполнитьТаблицуАвтоматически() 
        {
            if (Год != NsgService.MinDate)
            {
                ТаблицаПраздников.DeleteAll();
                var началоГода = new DateTime(Год.Year, 1, 1);
                var конецГода = new DateTime(Год.Year, 12, 31);
                var текущаяДата = началоГода;
                while (текущаяДата <= конецГода)
                {
                    //if (текущаяДата.DayOfWeek == DayOfWeek.Sunday)
                    {
                        var row = ТаблицаПраздников.NewRow();
                        row.Дата = текущаяДата;
                        row.Post();
                    }
                    

                    текущаяДата = текущаяДата.AddDays(1);
                }
            }
        }

        //public static DateTime[] БезусловноПраздничныеДни = new DateTime[]
        //{
        //    new DateTime()
        //};

    }

}
