using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;

namespace TechControl.Метаданные.Учет
{
    
    public partial class Номенклатура
    {
        public decimal ПолучитьСтоимость() 
        {
            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый();
            остаткиНоменклатуры.Номенклатура = this;
            остаткиНоменклатуры.GetRest();
            decimal цена = 0;
            if (остаткиНоменклатуры.Количество != 0)
            {
                цена = остаткиНоменклатуры.Стоимость / остаткиНоменклатуры.Количество;
            }

            return цена;
        }

        protected override List<Guid> BasePost()
        {
            if (ТипНоменклатуры == ТипНоменклатуры.Спецодежда)
            {
                if (!ВидНоменклатуры.Selected)
                {
                    throw new Exception("Не выбран вид спецодежды!!!");
                }

                if (!ВидРазмернойСетки.Selected)
                {
                    throw new Exception("Не выбран вид размерной сетки!!!");
                }

            }
            else
            {
                ВидНоменклатуры = ВидСвойствНоменклатуры.Новый();
                ВидРазмернойСетки = ВидыРазмернойСетки.Новый();
            }
            return base.BasePost();
        }

        //public Номенклатура СвязаннаяНоменклатураБУ()
        //{
        //    if (ЯвляетсяБУ)
        //        return this;

        //    if (НоменклатураБУ.Selected)
        //        return НоменклатураБУ;

        //    var cmp = new NsgCompare(NsgLogicalOperator.Or);
        //    var cmpName = new NsgCompare();
        //    cmpName.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    cmpName.Add(Номенклатура.Names.ЯвляетсяБУ, true);
        //    cmpName.Add(Номенклатура.Names.Наименование, string.Empty, NsgComparison.NotEqual);
        //    cmpName.Add(Номенклатура.Names.Наименование, Наименование, NsgComparison.ContainWords);
        //    cmp.Add(cmpName);

        //    var cmpFullName = new NsgCompare();
        //    cmpFullName.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    cmpFullName.Add(Номенклатура.Names.ЯвляетсяБУ, true);
        //    cmpFullName.Add(Номенклатура.Names.ПолноеНаименование, string.Empty, NsgComparison.NotEqual);
        //    cmpFullName.Add(Номенклатура.Names.ПолноеНаименование, ПолноеНаименование, NsgComparison.ContainWords);
        //    cmp.Add(cmpFullName);

        //    //var cmpFullName2 = new NsgCompare();
        //    //cmpFullName2.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    //cmpFullName2.Add(Номенклатура.Names.ПолноеНаименование2, string.Empty, NsgComparison.NotEqual);
        //    //cmpFullName2.Add(Номенклатура.Names.ПолноеНаименование2, ПолноеНаименование2, NsgComparison.ContainWords);
        //    //cmp.Add(cmpFullName2);

        //    //var cmpFullName3 = new NsgCompare();
        //    //cmpFullName3.Add(Номенклатура.Names.Идентификатор, Идентификатор, NsgComparison.NotEqual);
        //    //cmpFullName3.Add(Номенклатура.Names.ПолноеНаименование3, string.Empty, NsgComparison.NotEqual);
        //    //cmpFullName3.Add(Номенклатура.Names.ПолноеНаименование3, ПолноеНаименование3, NsgComparison.ContainWords);
        //    //cmp.Add(cmpFullName3);

        //    var nom = Номенклатура.Новый();
        //    if (!nom.Find(cmp))
        //    {
        //        nom.New();
        //        nom.CopyNotPredefinedFieldsFromObject(this);
        //        nom.ЯвляетсяБУ = true;
        //        nom.Наименование = Наименование + " (Б/У)";
        //        nom.ПолноеНаименование = ПолноеНаименование + " (Б/У)";
        //        nom.ПолноеНаименование2 = ПолноеНаименование2 + " (Б/У)";
        //        nom.ПолноеНаименование3 = ПолноеНаименование3 + " (Б/У)";
        //        nom.Post();
        //    }

        //    return nom;
        //}
    }

}
