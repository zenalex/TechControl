using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Документы;
using System.Linq;
using TechControl.Метаданные.Регистры;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Объекты
    {
        protected override List<Guid> BasePost()
        {
            if (this.ObjectState != NsgObjectStates.New && !ЗаправочнаяЕмкость.Selected)
            {
                var r = FindAllRequisits(new NsgCompare().Add(Names.Идентификатор, Идентификатор), Names.ЗаправочнаяЕмкость)
                    .Rows[0][Names.ЗаправочнаяЕмкость].ToReferent() as Техника;
                if (!r.Selected)
                {
                    var row = СписокТехникиОбъекта().FirstOrDefault();
                    if (row != null)
                    {
                        r = row;
                    }
                    else
                    {
                        r.New();
                        r.АккаунтПользователя = АккаунтПользователя;
                        r.Наименование = Наименование + " - заправочная емкость";
                        r.Post();
                    }
                }
                ЗаправочнаяЕмкость = r;
            }
            return base.BasePost();
        }

        public ГрафикРаботыОбъекта ДействующийНаДатуГрафикРаботы(DateTime дата) 
        {
            var cmp = new NsgCompare();
            cmp.Add(ГрафикРаботыОбъекта.Names.ДатаНачалаДействияГрафика, дата, NsgComparison.LessOrEqual);
            cmp.Add(ГрафикРаботыОбъекта.Names.ДатаНачалаДействияГрафика, NsgService.MinDate, NsgComparison.NotEqual);
            cmp.Add(ГрафикРаботыОбъекта.Names.Объект, this);
            cmp.Add(ГрафикРаботыОбъекта.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var графики = ГрафикРаботыОбъекта.Новый().FindAll(cmp);
            if (графики.Length > 0)
            {
                return графики.OrderByDescending(x => x.ДатаНачалаДействияГрафика).First();
            }
            else
            {
                NsgSettings.MainForm.ShowMessage($"На объекте отсуттствуют действующие на {дата} графики работы"); 
                return ГрафикРаботыОбъекта.Новый();
            }
        }

        public List<Tuple<Сотрудники, Должности>> СписокПерсонала() 
        {
            List<Tuple<Сотрудники, Должности>> сотрудники = new List<Tuple<Сотрудники, Должности>>();
            var reg = РегистрПерсоналОбъекта.Новый();
            reg.Объект = this;
            var список = reg.GetRests();

            сотрудники = список.AllRows
                .Select(x => new Tuple<Сотрудники, Должности>(x[РегистрПерсоналОбъекта.Names.Сотрудники].ToReferent() as Сотрудники, x[РегистрПерсоналОбъекта.Names.Должности].ToReferent() as Должности))
                .ToList();
            return сотрудники;
        }

        public Dictionary<Сотрудники, bool> ПланируемыеПараметрыВыходаСотрудниковНаРаботу(DateTime дата) 
        {
            Dictionary<Сотрудники, bool> параметры = new Dictionary<Сотрудники, bool>();
            var персонал = СписокПерсонала();
            if (персонал != null && персонал.Count > 0)
            {
                var cmpГрафик = new NsgCompare();
                cmpГрафик.Add(ПлановыйГрафикРаботы.Names.Объект, this);
                cmpГрафик.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, NsgService.BeginOfMonth(дата), NsgComparison.GreaterOrEqual);
                cmpГрафик.Add(ПлановыйГрафикРаботы.Names.МесяцГрафика, NsgService.EndOfMonth(дата), NsgComparison.LessOrEqual);
                cmpГрафик.Add(ПлановыйГрафикРаботы.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var графики = ПлановыйГрафикРаботы.Новый().FindAll(cmpГрафик);

                if (графики != null && графики.Length > 0)
                {
                    параметры = new Dictionary<Сотрудники, bool>();
                    foreach (var item in персонал)
                    {
                        var график = графики.FirstOrDefault(x => x.Сотрудник == item.Item1);
                        if (график != null)
                        {
                            параметры[item.Item1] = график.ТребуетсяВыход(дата);
                        }
                    }
                }
            }

            return параметры;
        }

        public Техника[] СписокТехникиОбъекта() 
        {
            Техника[] списокТехники = new Техника[0];
            var reg = РегистрТехникаОбъекта.Новый();
            reg.Объект = this;
            var список = reg.GetRests();

            списокТехники = список.AllRows
                .Select(x => x[РегистрТехникаОбъекта.Names.Техника].ToReferent() as Техника)
                .ToArray();
            return списокТехники;
        }

        public NsgMemoryTable ДействующиеТарифыПерсонала()
        {
            var reg = РегистрТарифыПерсоналаОбъекта.Новый();
            reg.Объект = this;
            return reg.GetRests();
        }

        public NsgMemoryTable ДействующиеТарифыТехники()
        {
            var reg = РегистрТарифыТехникиОбъекта.Новый();
            reg.Объект = this;
            return reg.GetRests();
        }
    }

}
