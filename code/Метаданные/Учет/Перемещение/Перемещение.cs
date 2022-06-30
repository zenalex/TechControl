using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Учет
{
    
    public partial class Перемещение
    {
        protected override bool Handling()
        {
            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый(this);
            остаткиНоменклатуры.New();
            foreach (var i in this.Таблица.Rows)
            {
                остаткиНоменклатуры.ВидДвижения = Сервис.ВидыДвижений.Приход;
                остаткиНоменклатуры.Количество = i.Количество;
                остаткиНоменклатуры.Номенклатура = i.Номенклатура;
                остаткиНоменклатуры.Объект = this.Объект;
                остаткиНоменклатуры.СвойствоНоменклатуры = i.СвойствоНоменклатуры;
                остаткиНоменклатуры.Сотрудник = this.Сотрудник;
                остаткиНоменклатуры.Стоимость = i.Стоимость;
                остаткиНоменклатуры.AddMovement();
            }
            return остаткиНоменклатуры.Post();
        }
    }

}
