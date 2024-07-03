using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные._SystemTables;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class ПеремещениеСпецодежды
    {
        protected override List<Guid> BasePost()
        {
            if (Таблица.Count > 0)
            {
                var cmp = new NsgCompare();
                cmp.Add(УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица.Names.НоменклатураСпецодеждыИСИЗ + "." + Номенклатура.Names.ТипНоменклатуры , ТипНоменклатуры.Спецодежда, NsgComparison.NotEqual);
                var row = Таблица.FindRow(cmp);
                if (row != null)
                {
                    throw new Exception($"В документе указана номенклатура, не являющаяся спецодеждой: {row.НоменклатураСпецодеждыИСИЗ}");
                }

                if (Получатель is ФизЛица сотрудникПолучатель)
                {
                    try
                    {
                        сотрудникПолучатель.Edit();
                        сотрудникПолучатель.ДокументКонтроляСпецодежды = this;
                        сотрудникПолучатель.Post();
                    }
                    catch (Exception ee)
                    {
                        NsgSettings.MainForm.ShowMessage($"Ошибка работы с сотрудником {сотрудникПолучатель}. {ee.Message}");
                    }
                }
            }
            return base.BasePost();
        }

        protected override bool Handling()
        {
            РегистрУчетСпецодежды рег = РегистрУчетСпецодежды.Новый(this);
            рег.New();
            ОстаткиНоменклатуры остаткиНоменклатуры = ОстаткиНоменклатуры.Новый(this);
            остаткиНоменклатуры.New();
            if (Отправитель is ФизЛица сотрудникОтправитель)
            {
                РегистрУчетСпецодежды регОстатки = РегистрУчетСпецодежды.Новый();
                регОстатки.Сотрудник = сотрудникОтправитель;
                var остатки = регОстатки.GetRests(ДатаДокумента.AddTicks(-1));
                List<string> уникальныеНомера = new List<string>();
                foreach (var строка in Таблица.AllRows)
                {
                    foreach (var item in остатки.AllRows)
                    {
                        var nom = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;

                        if (строка.НоменклатураСпецодеждыИСИЗ == nom)
                        {
                            for (int i = 0; i < строка.Количество; i++)
                            {
                                var номер = item[РегистрУчетСпецодежды.Names.УникальныйНомер].ToString();
                                if (!уникальныеНомера.Contains(номер))
                                {
                                    рег.Сотрудник = сотрудникОтправитель;
                                    рег.КомплектСпецодежды = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;
                                    рег.НоменклатураСпецодеждыИСИЗ = nom;
                                    рег.ДатаВыдачи = item[РегистрУчетСпецодежды.Names.ДатаВыдачи].ToDateTime();
                                    рег.КонецПериода = ДатаДокумента;
                                    рег.УникальныйНомер = номер;
                                    рег.Размер = item[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;
                                    рег.AddMovement();

                                    уникальныеНомера.Add(номер);
                                }
                            }
                        }
                    }
                }
            }
            else if (Отправитель is Объекты объект)
            {
                остаткиНоменклатуры.New();
                foreach (var i in Таблица.AllRows)
                {
                    остаткиНоменклатуры.ВидДвижения = Сервис.ВидыДвижений.Расход;
                    остаткиНоменклатуры.Количество = i.Количество;
                    остаткиНоменклатуры.Стоимость = i.Количество * i.НоменклатураСпецодеждыИСИЗ.ПолучитьЦену(ДатаНачалаЭксплуатации != NsgService.MinDate ? ДатаНачалаЭксплуатации : ДатаДокумента);
                    остаткиНоменклатуры.Номенклатура = i.НоменклатураСпецодеждыИСИЗ;
                    остаткиНоменклатуры.Объект = объект;
                    остаткиНоменклатуры.Размер = i.Размер;
                    остаткиНоменклатуры.Сотрудник = Получатель is ФизЛица ? Получатель as ФизЛица : ФизЛица.Новый();
                    остаткиНоменклатуры.AddMovement();
                }
            }

            if (Получатель is ФизЛица сотрудник)
            {
                foreach (var item in Таблица.AllRows)
                {
                    for (int i = 0; i < item.Количество; i++)
                    {
                        рег.Сотрудник = сотрудник;
                        рег.КомплектСпецодежды = item.КомплектСпецодежды;
                        рег.НоменклатураСпецодеждыИСИЗ = item.НоменклатураСпецодеждыИСИЗ;
                        рег.ДатаВыдачи = ДатаНачалаЭксплуатации != NsgService.MinDate ? ДатаНачалаЭксплуатации : ДатаДокумента;
                        рег.Размер = item.Размер;
                        рег.УникальныйНомер = Guid.NewGuid().ToString();

                        рег.AddMovement();
                    }
                }
            }
            else if (Получатель is Объекты объект)
            {
                остаткиНоменклатуры.New();
                foreach (var i in Таблица.AllRows)
                {
                    остаткиНоменклатуры.ВидДвижения = Сервис.ВидыДвижений.Приход;
                    остаткиНоменклатуры.Количество = i.Количество;
                    остаткиНоменклатуры.Стоимость = i.Количество * i.НоменклатураСпецодеждыИСИЗ.ПолучитьЦену(ДатаНачалаЭксплуатации != NsgService.MinDate ? ДатаНачалаЭксплуатации : ДатаДокумента);
                    остаткиНоменклатуры.Номенклатура = i.НоменклатураСпецодеждыИСИЗ;
                    остаткиНоменклатуры.Объект = объект;
                    остаткиНоменклатуры.Размер = i.Размер;
                    остаткиНоменклатуры.Сотрудник = Получатель is ФизЛица ? Получатель as ФизЛица : ФизЛица.Новый();
                    остаткиНоменклатуры.AddMovement();
                }
            }

            return рег.Post() && остаткиНоменклатуры.Post();
        }

        public void ВводНаОсновании(NsgDataDocument document, bool наОбъект = false)
        {
            if (document is ЗаявкаНаСотрудника заявкаНаСотрудника)
            {
                ДокументОснование = заявкаНаСотрудника;
                if (наОбъект)
                {
                    Отправитель = заявкаНаСотрудника.Контрагент;
                    Получатель = заявкаНаСотрудника.Объект;
                }
                else
                {
                    Отправитель = заявкаНаСотрудника.Объект;
                    Получатель = заявкаНаСотрудника.Сотрудник;
                }
                
                foreach (var item in заявкаНаСотрудника.Таблица.AllRows)
                {
                    var row = Таблица.NewRow();
                    row.НоменклатураСпецодеждыИСИЗ = item.Номенклатура;
                    row.Размер = item.Размер;
                    row.Количество = item.Количество;
                    row.Цена = item.Цена;
                    row.Стоимость = item.Сумма;
                    row.Post();
                }
            }
            else if (document is ЗаявкиПоставщикам заявкаПоставщику)
            {
                ДокументОснование = заявкаПоставщику;
                if (наОбъект)
                {
                    Отправитель = заявкаПоставщику.Поставщик;
                    Получатель = заявкаПоставщику.Объект;
                }
                else
                {
                    Отправитель = заявкаПоставщику.Объект;
                    Получатель = заявкаПоставщику.Сотрудник;
                }
                foreach (var item in заявкаПоставщику.Таблица.AllRows)
                {
                    var row = Таблица.NewRow();
                    row.НоменклатураСпецодеждыИСИЗ = item.Номенклатура;
                    row.Размер = item.Размер;
                    row.Количество = item.Количество;
                    row.Цена = item.Цена;
                    row.Стоимость = item.Стоимость;
                    row.Post();
                }
            }
        }
    }

}
