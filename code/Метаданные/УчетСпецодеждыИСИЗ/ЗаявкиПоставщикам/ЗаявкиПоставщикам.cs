using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Сервис;
using System.Linq;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class ЗаявкиПоставщикам
    {
        protected override bool Handling()
        {
            if (Статус != Перечисления.СтатусыЗаявок.Отменена)
            {
                var регРезерва = РегистрРезерваЗП.Новый(this);
                регРезерва.New();
                foreach (var item in Таблица.AllRows)
                {
                    регРезерва.Поставщик = Поставщик;
                    регРезерва.ДокументЗаявкиПоставщикам = this;
                    регРезерва.Сотрудник = Сотрудник;
                    регРезерва.Объект = Объект;
                    регРезерва.ВидДвижения = ВидыДвижений.Приход;
                    регРезерва.Номенклатура = item.Номенклатура;
                    регРезерва.Комплект = item.Комплект;
                    регРезерва.Размер = item.Размер;
                    регРезерва.Количество = item.Количество;
                    регРезерва.AddMovement();
                }
                return регРезерва.Post();
            }
            else
            {
                return true;
            }
        }

        public ПриходнаяНакладная ЗавершитьЗаявку(DateTime датаЗавершения = default(DateTime))
        {
            //if (Таблица.AllRows.Any(x => x.Цена == 0))
            //{
            //    throw new Exception("В таблице имеются строки без указанной цены");
            //}
            //else
            {
                if (Статус == Перечисления.СтатусыЗаявок.Выполнена)
                {
                    throw new Exception("Заявка уже завершена");
                }
                else if (Статус == Перечисления.СтатусыЗаявок.Отменена)
                {
                    throw new Exception("Попытка завершить отмененную заявку");
                }
                else
                {
                    var накладная = ПриходнаяНакладная.Новый();

                    var cmpНакладная = new NsgCompare();
                    cmpНакладная.Add(ПриходнаяНакладная.Names.ДокументОснование, this);
                    cmpНакладная.Add(ПриходнаяНакладная.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                    if (!накладная.Find(cmpНакладная))
                    {
                        try
                        {
                            NsgSettings.BeginTransaction();
                            Статус = Перечисления.СтатусыЗаявок.Выполнена;
                            if (датаЗавершения == default(DateTime) || датаЗавершения == NsgService.MinDate)
                            {
                                датаЗавершения = DateTime.Now;
                            }
                            ДатаЗавершенияИлиОтмены = датаЗавершения;

                            накладная.New();
                            накладная.ВводНаОсновании(this);
                            накладная.Handle();

                            var cmpВошедшиеЗаявки = new NsgCompare();
                            cmpВошедшиеЗаявки.Add(ЗаявкаНаСотрудника.Names.ОбщаяЗаявкаПоставщика, this);
                            cmpВошедшиеЗаявки.Add(ЗаявкаНаСотрудника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                            var вошедшиеЗаявки = ЗаявкаНаСотрудника.Новый().FindAll(cmpВошедшиеЗаявки);
                            if (вошедшиеЗаявки.Length > 0)
                            {
                                вошедшиеЗаявки = вошедшиеЗаявки.OrderBy(x => x.ДатаДокумента).ToArray();

                                foreach (var item in Таблица.AllRows)
                                {
                                    var количествоНоменклатуры = item.Количество;
                                    var количествоДоВычета = количествоНоменклатуры;
                                    long количествПослеВычета = 0;
                                    foreach (var заявка in вошедшиеЗаявки)
                                    {
                                        bool совпало = false;
                                        if (заявка.Статус == Перечисления.СтатусыЗаявокНаСотрудника.Объединена)
                                        {
                                            foreach (var строкаЗаявки in заявка.Таблица.AllRows)
                                            {
                                                if (строкаЗаявки.Номенклатура == item.Номенклатура && item.Размер == строкаЗаявки.Размер && item.Комплект == строкаЗаявки.Комплект)
                                                {
                                                    количествПослеВычета = количествоДоВычета - строкаЗаявки.Количество;
                                                    совпало = true;
                                                }
                                            }

                                            if (совпало)
                                            {
                                                заявка.Edit();
                                                if (количествПослеВычета >= 0)
                                                {
                                                    заявка.Статус = Перечисления.СтатусыЗаявокНаСотрудника.ГотоваКВыдаче;
                                                    foreach (var строкаЗаявки in заявка.Таблица.AllRows)
                                                    {
                                                        строкаЗаявки.Цена = item.Цена;
                                                        строкаЗаявки.Сумма = item.Цена * строкаЗаявки.Количество;
                                                    }
                                                }
                                                else
                                                {
                                                    заявка.Статус = Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения;
                                                }
                                                заявка.Handle();
                                            }
                                        }
                                    }
                                }

                                foreach (var заявка in вошедшиеЗаявки)
                                {
                                    if (заявка.Статус == Перечисления.СтатусыЗаявокНаСотрудника.Объединена)
                                    {
                                        заявка.Edit();
                                        заявка.Статус = Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения;
                                        заявка.Handle();
                                    }
                                }
                            }

                            NsgSettings.CommitTransaction();

                            return накладная;
                        }
                        catch (Exception ee )
                        {
                            NsgSettings.RollbackTransaction();
                            throw new Exception($"Ошибка выполнения заявки {ee.Message}");
                        }

                    }
                    else
                    {
                        throw new Exception("Заявку уже закрывали ранее и изменили ей статус");
                    }
                }
            }
        }

        public void Отменить(DateTime датаОтмены = default(DateTime))
        {
            if (Статус == Перечисления.СтатусыЗаявок.Отменена)
            {
                throw new Exception("Заявка уже отменена");
            }
            else
            {
                var накладная = ПриходнаяНакладная.Новый();
                var cmpНакладная = new NsgCompare();
                cmpНакладная.Add(ПриходнаяНакладная.Names.ДокументОснование, this);
                cmpНакладная.Add(ПриходнаяНакладная.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                if (накладная.Find(cmpНакладная))
                {
                    throw new Exception("На основании заявки созданы документы. Отмена невозможна.");
                }
                else
                {
                    try
                    {
                        NsgSettings.BeginTransaction();
                        Статус = Перечисления.СтатусыЗаявок.Отменена;
                        if (датаОтмены == default(DateTime) || датаОтмены == NsgService.MinDate)
                        {
                            датаОтмены = DateTime.Now;
                        }
                        ДатаЗавершенияИлиОтмены = датаОтмены;

                        var cmpВошедшиеЗаявки = new NsgCompare();
                        cmpВошедшиеЗаявки.Add(ЗаявкаНаСотрудника.Names.ОбщаяЗаявкаПоставщика, this);
                        cmpВошедшиеЗаявки.Add(ЗаявкаНаСотрудника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                        var вошедшиеЗаявки = ЗаявкаНаСотрудника.Новый().FindAll(cmpВошедшиеЗаявки);
                        if (вошедшиеЗаявки.Length > 0)
                        {
                            foreach (var заявка in вошедшиеЗаявки)
                            {
                                заявка.Edit();
                                заявка.Статус = Перечисления.СтатусыЗаявокНаСотрудника.ТребуетОбъединения;
                                заявка.ОбщаяЗаявкаПоставщика = ЗаявкиПоставщикам.Новый();
                                заявка.Handle();
                            }
                        }
                        NsgSettings.CommitTransaction();
                    }
                    catch (Exception ee)
                    {
                        NsgSettings.RollbackTransaction();
                        throw new Exception($"Ошибка выполнения заявки {ee.Message}");
                    }
                }
            }
        }
    }

}
