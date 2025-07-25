using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные._SystemTables;
using System.Linq;
using TechControl.Метаданные.Регистры;
using System.Threading.Tasks;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФормированиеСменыДень
    {
        protected override List<Guid> BasePost()
        {
            if (Объект == null || !Объект.Selected)
            {
                throw new Exception("Запрещено создавать документ без указания Объекта");
            }
            if (ДокументОснование == null || !ДокументОснование.Selected)
            {
                ДокументОснование = Объект.ПолучитьСменуНаДату(ДатаДокумента);
            }
            
            if (ДокументОснование.ObjectState == NsgObjectStates.New)
            {
                foreach (var item in ТаблицаПерсонал.AllRows)
                {
                    item.СтатусСотрудника = СтатусСотрудника.НаРаботе;
                }

                foreach (var item in ТаблицаТехника.AllRows)
                {
                    item.СтатусТехники = СтатусТехники.ВРаботе;
                }
                ДокументОснование.Post();
            }

            ДатаПоследнгегоИзменения = DateTime.Now;

            var смена = ДокументОснование as ФормированиеСмены;

            if (смена != null && смена.Selected && смена.ДатаДокумента > ДатаДокумента)
            {
                ДатаДокумента = смена.ДатаДокумента;
            }

            if (ЗавершаетСмену)
            {
                if (смена != null && смена.Selected && смена.ДатаОкончанияСмены != ДатаДокумента) 
                {
                    смена.ДатаОкончанияСмены = ДатаДокумента;
                    смена.UpdateArray(new NsgCompare().Add(ФормированиеСмены.Names.Идентификатор, смена.Идентификатор),
                        смена.ObjectList[ФормированиеСмены.Names.ДатаОкончанияСмены]);
                }
                var регС = ФиксацияИсторииСотрудников.Новый(this);
                регС.New();
                регС.Объект = this.Объект;
                var сост = регС.GetRests(ДатаДокумента.AddTicks(-1));
                ТаблицаПерсонал.DeleteAll();
                foreach (var item in сост.AllRows)
                {
                    var статус = item[ФиксацияИсторииСотрудников.Names.СтатусСотрудника].ToReferent() as СтатусСотрудника;
                    if (статус == СтатусСотрудника.НаРаботе)
                    {
                        var row = ТаблицаПерсонал.NewRow();
                        row.Сотрудник = item[ФиксацияИсторииСотрудников.Names.Сотрудник].ToReferent() as ФизЛица;
                        row.Должность = item[ФиксацияИсторииСотрудников.Names.Должность].ToReferent() as Должности;
                        row.Тариф = item[ФиксацияИсторииСотрудников.Names.Тариф].ToReferent() as Тарифы;
                        row.НомерСмены = item[ФиксацияИсторииСотрудников.Names.НомерСмены].ToInt();
                        row.Post();
                    }
                }
                var регТехн = ФиксацияИстории.Новый(this);
                регТехн.New();
                регТехн.Объект = this.Объект;
                var состТехн = регТехн.GetRests(ДатаДокумента.AddTicks(-1));
                ТаблицаТехника.DeleteAll();
                foreach (var item in состТехн.AllRows)
                {
                    var статус = item[ФиксацияИстории.Names.СтатусТехники].ToReferent() as СтатусТехники;
                    if (статус == СтатусТехники.ВРаботе)
                    {
                        var row = ТаблицаТехника.NewRow();
                        row.Сотрудник = item[ФиксацияИстории.Names.Сотрудник].ToReferent() as ФизЛица;
                        row.Техника = item[ФиксацияИстории.Names.Техника].ToReferent() as Техника;
                        row.Тариф = item[ФиксацияИстории.Names.Тариф].ToReferent() as Тарифы;
                        row.НомерСмены = item[ФиксацияИстории.Names.НомерСмены].ToInt();
                        row.Post();
                    }
                }
            }

            foreach (var item in ТаблицаПерсонал.AllRows)
            {
                if (item.Время == NsgService.MinDate || item.Время < смена.ДатаДокумента || item.СтатусСотрудника == СтатусСотрудника.Отсутствует) 
                {
                    item.Время = ДатаДокумента;
                }
                if (ЗавершаетСмену)
                {
                    item.СтатусСотрудника = СтатусСотрудника.Отсутствует;
                    item.Время = ДатаДокумента;
                }
                else
                {
                    if (item.СтатусСотрудника == СтатусСотрудника.Отсутствует && item.Сотрудник.Selected)
                    {
                        var строкиТехники = ТаблицаТехника.AllRows.Where(x => x.Сотрудник == item.Сотрудник).ToArray();
                        foreach (var строка in строкиТехники)
                        {
                            строка.СтатусТехники = СтатусТехники.НеРаботает;
                        }
                    }
                }
            }

            foreach (var item in ТаблицаТехника.AllRows)
            {
                if (item.Время == NsgService.MinDate || item.Время < смена.ДатаДокумента || item.СтатусТехники == СтатусТехники.НеРаботает)
                {
                    item.Время = ДатаДокумента;
                }
                if (ЗавершаетСмену)
                {
                    item.СтатусТехники = СтатусТехники.НеРаботает;
                    item.Время = ДатаДокумента;
                }
            }

            return base.BasePost();
        }

        protected override bool Handling()
        {
            var смена = ДокументОснование as ФормированиеСмены;
            if (смена == null || !смена.Selected)
            {
                throw new Exception("Не выбрана смена");
            }

            #region техника
            var регТехн = ФиксацияИстории.Новый(this);
            регТехн.New();
            регТехн.Объект = this.Объект;
            регТехн.Смена = смена;
            регТехн.Владелец = this;

            var регТехнСост = ФиксацияИстории.Новый(this);
            регТехнСост.New();
            foreach (var i in this.ТаблицаТехника.AllRows)
            {
                регТехнСост.New();
                регТехнСост.Объект = Объект;
                регТехнСост.Смена = смена;
                регТехнСост.Сотрудник = i.Сотрудник;
                регТехнСост.Техника = i.Техника;
                регТехнСост.НомерСмены = i.НомерСмены;
                if (регТехнСост.GetRest(i.Время.AddTicks(-1)))
                {
                    var предСтатусТехники = регТехнСост.СтатусТехники.Clone as СтатусТехники;
                    регТехн.Тариф = i.Тариф;
                    if (i.СтатусТехники != предСтатусТехники)
                    {
                        var предВремя = регТехнСост.Время;
                        регТехн.Смена = смена;
                        регТехн.СтатусТехники = i.СтатусТехники;
                        регТехн.Сотрудник = i.Сотрудник;
                        регТехн.Техника = i.Техника;
                        регТехн.НомерСмены = i.НомерСмены;
                        регТехн.Тариф = i.Тариф;
                        регТехн.Дата = ДатаДокумента;
                        регТехн.Дата = i.Время == NsgService.MinDate ? this.ДатаДокумента : i.Время;
                        регТехн.AddMovement();
                    }
                }
                else
                {
                    var предВремя = регТехн.Время;
                    регТехн.Смена = смена;
                    регТехн.Сотрудник = i.Сотрудник;
                    регТехн.Техника = i.Техника;
                    регТехн.НомерСмены = i.НомерСмены;
                    регТехн.Дата = ДатаДокумента;
                    регТехн.Тариф = i.Тариф;
                    регТехн.СтатусТехники = i.СтатусТехники;
                    регТехн.Дата = i.Время == NsgService.MinDate ? this.ДатаДокумента : i.Время;
                    регТехн.AddMovement();
                }
            }
            #endregion

            #region персонал
            var регС = ФиксацияИсторииСотрудников.Новый(this);
            регС.New();
            регС.Объект = this.Объект;
            регС.Владелец = this;
            регС.Смена = смена;

            var регССост = ФиксацияИсторииСотрудников.Новый(this);
            регССост.New();

            foreach (var i in this.ТаблицаПерсонал.Rows)
            {
                регССост.New();
                регССост.Объект = Объект;
                регССост.Сотрудник = i.Сотрудник;
                регССост.Должность = i.Должность;
                регССост.НомерСмены = i.НомерСмены;
                регССост.Смена = смена;
                if (регССост.GetRest(i.Время.AddTicks(-1)))
                {
                    var предСтатусСотрудника = регССост.СтатусСотрудника.Clone as СтатусСотрудника;
                    регС.Тариф = i.Тариф;
                    if (i.СтатусСотрудника != предСтатусСотрудника)
                    {
                        var предВремя = регССост.Время;
                        регС.СтатусСотрудника = i.СтатусСотрудника;
                        регС.Смена = смена;
                        регС.Сотрудник = i.Сотрудник;
                        регС.Должность = i.Должность;
                        регС.Тариф = i.Тариф;
                        регС.НомерСмены = i.НомерСмены;
                        регС.Дата = ДатаДокумента;
                        регС.Дата = i.Время == NsgService.MinDate ? this.ДатаДокумента : i.Время;
                        регС.AddMovement();
                    }
                }
                else
                {
                    var предВремя = регС.Время;
                    регС.Смена = смена;
                    регС.Сотрудник = i.Сотрудник;
                    регС.Должность = i.Должность;
                    регС.НомерСмены = i.НомерСмены;
                    регС.Тариф = i.Тариф;
                    регС.Дата = ДатаДокумента;
                    регС.СтатусСотрудника = i.СтатусСотрудника;
                    регС.Дата = i.Время == NsgService.MinDate ? this.ДатаДокумента : i.Время;
                    регС.AddMovement();
                }
            }
            #endregion

            return регС.Post() && регТехн.Post();
        }

        protected override void OnAfterHandle(HandleEventArgs e)
        {
            var смена = ДокументОснование as ФормированиеСмены;
            if (смена == null || !смена.Selected)
            {
                throw new Exception("Не выбрана смена");
            }
            if (ЗавершаетСмену)
            {
                try
                {
                    смена.Edit();
                    смена.ЗаполнитьИтоговуюТаблицу();
                    смена.Post();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            base.OnAfterHandle(e);
        }

        public void Заполнить()
        {
            var датаНачалаСмены = (ДокументОснование as ФормированиеСмены).ДатаДокумента;

            this.ТаблицаТехника.FullClear();
            
            var cmpТехн = new NsgCompare();
            cmpТехн.Add(МониторингФиксацияИсторииДвижения.Names.Объект, Объект);
            cmpТехн.Add(МониторингФиксацияИсторииДвижения.Names.Дата, датаНачалаСмены, NsgComparison.GreaterOrEqual);
            cmpТехн.Add(МониторингФиксацияИсторииДвижения.Names.Дата, ДатаДокумента, NsgComparison.LessOrEqual);

            var всеДвиженияТехники = МониторингФиксацияИсторииДвижения.Новый().FindAll(cmpТехн);

            Dictionary<Техника, List<ФизЛица>> сотрудникиНаТехнике = new Dictionary<Техника, List<ФизЛица>>();
            foreach (var item in всеДвиженияТехники)
            {
                List<ФизЛица> сотрудники = null;
                if (!сотрудникиНаТехнике.TryGetValue(item.Техника, out сотрудники))
                {
                    сотрудники = new List<ФизЛица>();
                }
                if (!сотрудники.Contains(item.Сотрудник))
                {
                    сотрудники.Add(item.Сотрудник);
                }
                сотрудникиНаТехнике[item.Техника] = сотрудники;
            }

            foreach (var техника in сотрудникиНаТехнике.Keys)
            {
                foreach (var сотрудник in сотрудникиНаТехнике[техника])
                {
                    var движенияПоТехнике = всеДвиженияТехники.Where(x => x.Сотрудник == сотрудник && x.Техника == техника).OrderBy(x => x.Дата).ToArray();
                    for (int i = 0; i < движенияПоТехнике.Length; i += 2)
                    {
                        var начало = движенияПоТехнике[i];
                        МониторингФиксацияИсторииДвижения конец = null;
                        if (i + 1 < движенияПоТехнике.Length)
                        {
                            конец = движенияПоТехнике[i + 1];
                        }
                        if (конец == null)
                        {
                            var row = ТаблицаТехника.NewRow();
                            row.Время = начало.Дата;
                            row.Сотрудник = сотрудник;
                            row.Техника = техника;
                            row.СтатусТехники = СтатусТехники.ВРаботе;
                            //if (конец != null)
                            //{
                            //    row.Длительность = (decimal)(конец.Дата - начало.Дата).TotalHours;
                            //    row.СтатусСотрудника = СтатусСотрудника.Отсутствует;
                            //}
                            row.Post();
                        }
                    }
                }
            }

            var cmpСотр = new NsgCompare();
            cmpСотр.Add(МониторингФиксацияИсторииСотрудниковДвижения.Names.Объект, Объект);
            cmpСотр.Add(МониторингФиксацияИсторииСотрудниковДвижения.Names.Дата, датаНачалаСмены, NsgComparison.GreaterOrEqual);
            cmpСотр.Add(МониторингФиксацияИсторииСотрудниковДвижения.Names.Дата, ДатаДокумента, NsgComparison.LessOrEqual);

            var всеДвижения = МониторингФиксацияИсторииСотрудниковДвижения.Новый().FindAll(cmpСотр);

            Dictionary<ФизЛица, List<Должности>> должностиСотрудников = new Dictionary<ФизЛица, List<Должности>>();
            foreach (var item in всеДвижения)
            {
                List<Должности> должности = null;
                if (!должностиСотрудников.TryGetValue(item.Сотрудник, out должности))
                {
                    должности = new List<Должности>();
                }
                if (!должности.Contains(item.Должность))
                {
                    должности.Add(item.Должность);
                }
                должностиСотрудников[item.Сотрудник] = должности;
            }

            ТаблицаПерсонал.DeleteAll();
            foreach (var сотрудник in должностиСотрудников.Keys)
            {
                foreach (var должность in должностиСотрудников[сотрудник])
                {
                    var движенияПоСотруднику = всеДвижения.Where(x => x.Сотрудник == сотрудник && x.Должность == должность).OrderBy(x => x.Дата).ToArray();
                    for (int i = 0; i < движенияПоСотруднику.Length; i += 2)
                    {
                        var начало = движенияПоСотруднику[i];
                        МониторингФиксацияИсторииСотрудниковДвижения конец = null;
                        if (i + 1 < движенияПоСотруднику.Length)
                        {
                            конец = движенияПоСотруднику[i + 1];
                        }
                        if (конец == null)
                        {
                            var row = ТаблицаПерсонал.NewRow();
                            row.Время = начало.Дата;
                            row.Сотрудник = сотрудник;
                            row.Должность = должность;
                            row.СтатусСотрудника = СтатусСотрудника.НаРаботе;
                            if (конец != null)
                            {
                                row.Длительность = (decimal)(конец.Дата - начало.Дата).TotalHours;
                                row.СтатусСотрудника = СтатусСотрудника.Отсутствует;
                            }
                            row.Post();
                        }
                    }
                }
            }
        }
    }

}
