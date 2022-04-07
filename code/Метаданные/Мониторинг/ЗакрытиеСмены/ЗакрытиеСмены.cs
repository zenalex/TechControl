using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Мониторинг
{

    public partial class ЗакрытиеСмены
    {
        protected override bool Handling()
        {
            var фиксацияИстории = ФиксацияИстории.Новый(this);
            фиксацияИстории.New();
            фиксацияИстории.Владелец = this;
            фиксацияИстории.Объект = this.Объект;
            var allRests = фиксацияИстории.GetRests(this.Время,
                new NsgCompare().Add(ФиксацияИстории.Names.Объект, this.Объект).Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
            foreach (var i in allRests.Rows)
            {
                var предВремя = i[ФиксацияИстории.Names.Дата].ToDateTime();
                РегистрСмен регистрСмен = РегистрСмен.Новый(this);
                фиксацияИстории.New();
                регистрСмен.New();
                регистрСмен.Техника = фиксацияИстории.Техника = i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                регистрСмен.Объект = фиксацияИстории.Объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                регистрСмен.НомерСмены = фиксацияИстории.НомерСмены = i[ФиксацияИстории.Names.НомерСмены].ToInt();
                decimal price;
                if (i[ФиксацияИстории.Names.Тариф].ToReferent().Selected)
                {
                    price = i[ФиксацияИстории.Names.Тариф + '.' + Тарифы.Names.Стоимость].ToDecimal();
                }
                else
                {
                    регистрСмен.GetRest(this.Время);
                    price = (регистрСмен.ОтработанноеВремя == 0) ? 0 : регистрСмен.Сумма / регистрСмен.ОтработанноеВремя;
                }
                регистрСмен.Сотрудник = фиксацияИстории.Сотрудник = i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники;
                регистрСмен.ДатаДокумента = фиксацияИстории.Дата = фиксацияИстории.Время = NsgService.EndOfDay(this.ДатаДокумента);
                фиксацияИстории.Тариф = i[ФиксацияИстории.Names.Тариф].ToReferent() as Тарифы;
                фиксацияИстории.СтатусТехники = СтатусТехники.НеРаботает;
                фиксацияИстории.Владелец = this;
                фиксацияИстории.AddMovement();

                регистрСмен.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(фиксацияИстории.Время - предВремя).TotalHours;
                регистрСмен.Сумма = price * регистрСмен.ОтработанноеВремя;
                регистрСмен.ВидДвижения = Сервис.ВидыДвижений.Расход;
                регистрСмен.AddMovement();
                регистрСмен.Post();

                фиксацияИстории.Техника = i[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                фиксацияИстории.Объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                фиксацияИстории.НомерСмены = i[ФиксацияИстории.Names.НомерСмены].ToInt();
                фиксацияИстории.Дата = фиксацияИстории.Время = NsgService.BeginOfDay(this.ДатаДокумента.AddDays(1));
                фиксацияИстории.Тариф = i[ФиксацияИстории.Names.Тариф].ToReferent() as Тарифы;
                фиксацияИстории.СтатусТехники = СтатусТехники.ВРаботе;
                фиксацияИстории.Владелец = this;
                фиксацияИстории.AddMovement();
                фиксацияИстории.Post();

                регистрСмен.New();
                var all = регистрСмен.GetCirculate(this.Время.AddSeconds(1), NsgService.MaxDate, new NsgCompare()
                    .Add(РегистрСмен.Names.Объект, фиксацияИстории.Объект)
                    .Add(РегистрСмен.Names.Сотрудник, i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники)
                    .Add(РегистрСмен.Names.НомерСмены, i[ФиксацияИстории.Names.НомерСмены].ToInt())
                    .Add(РегистрСмен.Names.Техника, фиксацияИстории.Техника), NsgRegisterResult.Debit | NsgRegisterResult.Credit,
                    РегистрСмен.Names.Владелец);
                if (all.Count > 0)
                {
                    NsgDataDocument fs = all.Rows[0][РегистрСмен.Names.Владелец].ToReferent() as NsgDataDocument;
                    foreach (var docRow in all.Rows)
                    {
                        var doc = docRow[РегистрСмен.Names.Владелец].ToReferent() as NsgDataDocument;
                        if (doc.DateTime < fs.DateTime) fs = doc;
                    }
                    fs.Handle();
                }
            }
            return true;
        }

        public override void Unhandle()
        {
            base.Unhandle();
            РегистрСмен регистрСмен = РегистрСмен.Новый();
            var фиксацияИстории = ФиксацияИстории.Новый();
            фиксацияИстории.New();
            фиксацияИстории.Объект = this.Объект;
            var allRests = фиксацияИстории.GetRests(this.Время,
                new NsgCompare().Add(ФиксацияИстории.Names.Объект, this.Объект).Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе));
            foreach (var i in allRests.Rows)
            {
                регистрСмен.New();
                var all = регистрСмен.GetCirculate(this.Время.AddSeconds(1), NsgService.MaxDate, new NsgCompare()
                    .Add(РегистрСмен.Names.Объект, фиксацияИстории.Объект)
                    .Add(РегистрСмен.Names.Сотрудник, i[ФиксацияИстории.Names.Сотрудник].ToReferent() as Сотрудники)
                    .Add(РегистрСмен.Names.НомерСмены, i[ФиксацияИстории.Names.НомерСмены].ToInt())
                    .Add(РегистрСмен.Names.Техника, i[ФиксацияИстории.Names.Техника].Value), NsgRegisterResult.Debit | NsgRegisterResult.Credit,
                    РегистрСмен.Names.Владелец);
                if (all.Count > 0)
                {
                    NsgDataDocument fs = all.Rows[0][РегистрСмен.Names.Владелец].ToReferent() as NsgDataDocument;
                    foreach (var docRow in all.Rows)
                    {
                        var doc = docRow[РегистрСмен.Names.Владелец].ToReferent() as NsgDataDocument;
                        if (doc.DateTime < fs.DateTime) fs = doc;
                    }
                    fs.Handle();
                }
            }
        }
    }

}
