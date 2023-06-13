using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using NsgSoft.ReportBase.Wizards;
using System.Linq.Expressions;

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
                if (ТребуетПодтверждения)
                    остаткиНоменклатуры.Перемещение = this;
                остаткиНоменклатуры.AddMovement();
            }
            var докПодтверждения = ПодтверждениеПеремещения.Новый();
            var cmp = new NsgCompare().Add(ПодтверждениеПеремещения.Names.ДокументОснование, this);
            var спПодтверждений = докПодтверждения.FindAll(cmp);
            foreach(var текПодтв in спПодтверждений)
            {
                try 
                {
                    текПодтв.Handle();
                }
                catch(Exception ex) 
                {
                    NsgSettings.MainForm.ShowMessage(ex.ToString());
                }
                
                
            }    
            return остаткиНоменклатуры.Post();

        }
       
    }

}
