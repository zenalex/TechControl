using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using System.Linq;
using static NsgSoft.Forms.NsgColumnDescriptor;



namespace TechControl.Метаданные.Документы
{

    public partial class ГрафикРаботыОбъекта
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        #endregion //Методы

        /// <summary>
        /// возвращает ключ: должность. грСпТехн и колич. Значение: bool требуетсяВыход, DateTime время выхода на смену, decimal длительность смены
        /// </summary>
        /// <param name="датаВыхода"></param>
        /// <param name="номерСмены"></param>
        /// <returns></returns>
        public Dictionary<Tuple<string, Должности, ГруппыСпецТехники, long>, Tuple<bool, System.DateTime, decimal>> ПараметрыВыходаНАСменуНаДату(System.DateTime датаВыхода, int номерСмены)
        {
            var параметры = new Dictionary<Tuple<string, Должности, ГруппыСпецТехники, long>, Tuple<bool, System.DateTime, decimal>>();
            if (Таблица.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage("Не заполнена таблица графика");
            }
            else
            {
                var пары = ДолжностиИТехникаИзГрафика();
                var выходной = НастройкиПраздников.ЯвляетсяВыходным(датаВыхода, Объект);
                foreach (var item in пары)
                {
                    if (выходной)
                    {
                        параметры[item] = new Tuple<bool, System.DateTime, decimal>(false, NsgService.MinDate, 0);
                    }
                    else
                    {
                        bool выход = false;
                        System.DateTime времяВыхода = NsgService.MinDate;
                        decimal длительность = 0;
                        if (номерСмены == 1)
                        {
                            выход = Таблица.AllRows.Any(x => x.КодГруппы == item.Item1 
                            && x.Должность == item.Item2
                            && x.ГруппаСпецТехники == item.Item3
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ДлительностьСмены1ВЧасах != 0);
                            if (выход)
                            {
                                времяВыхода = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2 
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены1ВЧасах != 0).ВремяНачалаСмены1;

                                длительность = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены1ВЧасах != 0).ДлительностьСмены1ВЧасах;
                            }
                        }
                        if (номерСмены == 2)
                        {
                            выход = Таблица.AllRows.Any(x => x.КодГруппы == item.Item1
                            && x.Должность == item.Item2
                            && x.ГруппаСпецТехники == item.Item3
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ДлительностьСмены2ВЧасах != 0);

                            if (выход)
                            {
                                времяВыхода = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены2ВЧасах != 0).ВремяНачалаСмены2;

                                длительность = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены2ВЧасах != 0).ДлительностьСмены2ВЧасах;
                            }
                        }
                        if (номерСмены == 3)
                        {
                            выход = Таблица.AllRows.Any(x => x.КодГруппы == item.Item1
                            && x.Должность == item.Item2
                            && x.ГруппаСпецТехники == item.Item3
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ДлительностьСмены3ВЧасах != 0);

                            if (выход)
                            {
                                времяВыхода = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены3ВЧасах != 0).ВремяНачалаСмены3;

                                длительность = Таблица.AllRows.First(x => x.КодГруппы == item.Item1
                                && x.Должность == item.Item2
                                && x.ГруппаСпецТехники == item.Item3
                                && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                                && x.ДлительностьСмены3ВЧасах != 0).ДлительностьСмены3ВЧасах;
                            }
                        }

                        параметры[item] = new Tuple<bool, System.DateTime, decimal>(выход, времяВыхода, длительность);
                    }
                }
            }

            return параметры;
        }

        public Tuple<string, Должности, ГруппыСпецТехники, long>[] ДолжностиИТехникаИзГрафика()
        {
            var пары = new Tuple<string, Должности, ГруппыСпецТехники, long>[0];
            if (Таблица.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage("Не заполнена таблица графика");
            }
            else
            {
                List<Tuple<string, Должности, ГруппыСпецТехники, long>> доступныеДолжностиИТехника = new List<Tuple<string, Должности, ГруппыСпецТехники, long>>();
                foreach (var item in Таблица.AllRows)
                {
                    if (item.Должность.Selected || item.ГруппаСпецТехники.Selected)
                    {
                        доступныеДолжностиИТехника.Add(new Tuple<string, Должности, ГруппыСпецТехники, long>(item.КодГруппы, item.Должность, item.ГруппаСпецТехники, item.Количество));
                    }
                }

                пары = доступныеДолжностиИТехника.Distinct().ToArray();
            }
            return пары;
        }
    }

}
