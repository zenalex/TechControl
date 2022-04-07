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
            #region техника
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
            #endregion
            #region персонал
            var фиксацияИсторииСотрудников = ФиксацияИсторииСотрудников.Новый(this);
            фиксацияИсторииСотрудников.New();
            фиксацияИсторииСотрудников.Владелец = this;
            фиксацияИсторииСотрудников.Объект = this.Объект;
            allRests = фиксацияИсторииСотрудников.GetRests(this.Время,
                new NsgCompare()
                .Add(ФиксацияИсторииСотрудников.Names.Объект, this.Объект)
                .Add(ФиксацияИсторииСотрудников.Names.СтатусСотрудника, СтатусСотрудника.НаРаботе));
            foreach (var i in allRests.Rows)
            {
                var предВремя = i[ФиксацияИсторииСотрудников.Names.Дата].ToDateTime();
                РегистрСмен регистрСмен = РегистрСмен.Новый(this);
                фиксацияИсторииСотрудников.New();
                регистрСмен.New();
                регистрСмен.Объект = фиксацияИсторииСотрудников.Объект = i[ФиксацияИсторииСотрудников.Names.Объект].ToReferent() as Объекты;
                регистрСмен.НомерСмены = фиксацияИсторииСотрудников.НомерСмены = i[ФиксацияИсторииСотрудников.Names.НомерСмены].ToInt();
                decimal price;
                if (i[ФиксацияИсторииСотрудников.Names.Тариф].ToReferent().Selected)
                {
                    price = i[ФиксацияИсторииСотрудников.Names.Тариф + '.' + Тарифы.Names.Стоимость].ToDecimal();
                }
                else
                {
                    регистрСмен.GetRest(this.Время);
                    price = (регистрСмен.ОтработанноеВремя == 0) ? 0 : регистрСмен.Сумма / регистрСмен.ОтработанноеВремя;
                }
                регистрСмен.Сотрудник = фиксацияИсторииСотрудников.Сотрудник = i[ФиксацияИсторииСотрудников.Names.Сотрудник].ToReferent() as Сотрудники;
                регистрСмен.ДатаДокумента = фиксацияИсторииСотрудников.Дата = фиксацияИсторииСотрудников.Время = NsgService.EndOfDay(this.ДатаДокумента);
                фиксацияИсторииСотрудников.Тариф = i[ФиксацияИсторииСотрудников.Names.Тариф].ToReferent() as Тарифы;
                фиксацияИсторииСотрудников.СтатусСотрудника = СтатусСотрудника.Отсутствует;
                фиксацияИсторииСотрудников.Владелец = this;
                фиксацияИсторииСотрудников.AddMovement();

                регистрСмен.ОтработанноеВремя = (предВремя == NsgService.MinDate) ? 0 : (decimal)(фиксацияИсторииСотрудников.Время - предВремя).TotalHours;
                регистрСмен.Сумма = price * регистрСмен.ОтработанноеВремя;
                регистрСмен.ВидДвижения = Сервис.ВидыДвижений.Расход;
                регистрСмен.AddMovement();
                регистрСмен.Post();

                фиксацияИсторииСотрудников.Сотрудник = i[ФиксацияИсторииСотрудников.Names.Сотрудник].ToReferent() as Сотрудники;
                фиксацияИсторииСотрудников.Объект = i[ФиксацияИсторииСотрудников.Names.Объект].ToReferent() as Объекты;
                фиксацияИсторииСотрудников.НомерСмены = i[ФиксацияИсторииСотрудников.Names.НомерСмены].ToInt();
                фиксацияИсторииСотрудников.Дата = фиксацияИсторииСотрудников.Время = NsgService.BeginOfDay(this.ДатаДокумента.AddDays(1));
                фиксацияИсторииСотрудников.Тариф = i[ФиксацияИсторииСотрудников.Names.Тариф].ToReferent() as Тарифы;
                фиксацияИсторииСотрудников.СтатусСотрудника = СтатусСотрудника.НаРаботе;
                фиксацияИсторииСотрудников.Владелец = this;
                фиксацияИсторииСотрудников.AddMovement();
                фиксацияИсторииСотрудников.Post();

                регистрСмен.New();
                var all = регистрСмен.GetCirculate(this.Время.AddSeconds(1), NsgService.MaxDate, new NsgCompare()
                    .Add(РегистрСмен.Names.Объект, фиксацияИсторииСотрудников.Объект)
                    .Add(РегистрСмен.Names.Сотрудник, i[ФиксацияИсторииСотрудников.Names.Сотрудник].ToReferent() as Сотрудники)
                    .Add(РегистрСмен.Names.НомерСмены, i[ФиксацияИсторииСотрудников.Names.НомерСмены].ToInt())
                    .Add(РегистрСмен.Names.Техника, Техника.Новый()), NsgRegisterResult.Debit | NsgRegisterResult.Credit,
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
            #endregion
            return true;
        }

        public override void Unhandle()
        {
            base.Unhandle();
            РегистрСмен регистрСмен = РегистрСмен.Новый();
            #region техника
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
            #endregion
            #region сотрудники
            var фиксацияИсторииСотрудников = ФиксацияИсторииСотрудников.Новый();
            фиксацияИсторииСотрудников.New();
            фиксацияИсторииСотрудников.Объект = this.Объект;
            allRests = фиксацияИсторииСотрудников.GetRests(this.Время, new NsgCompare()
                .Add(ФиксацияИсторииСотрудников.Names.Объект, this.Объект)
                .Add(ФиксацияИсторииСотрудников.Names.СтатусСотрудника, СтатусСотрудника.НаРаботе));
            foreach (var i in allRests.Rows)
            {
                регистрСмен.New();
                var all = регистрСмен.GetCirculate(this.Время.AddSeconds(1), NsgService.MaxDate, new NsgCompare()
                    .Add(РегистрСмен.Names.Объект, фиксацияИсторииСотрудников.Объект)
                    .Add(РегистрСмен.Names.Сотрудник, i[ФиксацияИсторииСотрудников.Names.Сотрудник].ToReferent() as Сотрудники)
                    .Add(РегистрСмен.Names.НомерСмены, i[ФиксацияИсторииСотрудников.Names.НомерСмены].ToInt())
                    .Add(РегистрСмен.Names.Техника, Техника.Новый()), NsgRegisterResult.Debit | NsgRegisterResult.Credit,
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
            #endregion
        }
    }

}
