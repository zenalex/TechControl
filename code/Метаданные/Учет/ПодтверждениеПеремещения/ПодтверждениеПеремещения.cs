using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace TechControl.Метаданные.Учет
{

    public partial class ПодтверждениеПеремещения
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        protected override bool Handling()
        {
            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый(this);
            var cmp = new NsgCompare().Add(ОстаткиНоменклатуры.Names.Перемещение, ДокументОснование);
            var движ = остаткиНоменклатуры.GetRests(cmp);
            foreach (var ост in движ.Rows)
            {

            }

            остаткиНоменклатуры.New();
            foreach (var i in this.Таблица.Rows)
            {
                остаткиНоменклатуры.ВидДвижения = Сервис.ВидыДвижений.Приход;
                остаткиНоменклатуры.Количество = i.Количество;
                остаткиНоменклатуры.Номенклатура = i.Номенклатура;
                остаткиНоменклатуры.Объект = this.Объект;
                остаткиНоменклатуры.Размер = i.Размер;
                остаткиНоменклатуры.Сотрудник = this.Сотрудник;
                //      остаткиНоменклатуры.Стоимость = i.Стоимость;
                остаткиНоменклатуры.Перемещение = null;
                остаткиНоменклатуры.AddMovement();
            }
            return остаткиНоменклатуры.Post();
            #endregion //Методы
        }
        public override void OnBaseAssigned()
        {
            base.OnBaseAssigned();
            if (ДокументОснование != null && ДокументОснование.Selected && ДокументОснование is Перемещение)
            {
                var докПеремещение = ДокументОснование as Перемещение;
                this.CopyNotPredefinedFieldsFromObject(докПеремещение);
                this.Таблица.CopyNotPredefinedFieldsFromObject(докПеремещение.Таблица);
            }
        }
    }
}
