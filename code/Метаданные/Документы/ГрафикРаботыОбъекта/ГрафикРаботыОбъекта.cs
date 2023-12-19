using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using System.Linq;



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

        public Dictionary<Tuple<Должности, ГруппыСпецТехники, long>, bool> ПараметрыВыходаНАСменуНаДату(DateTime датаВыхода, int номерСмены) 
        {
            var параметры = new Dictionary<Tuple<Должности, ГруппыСпецТехники, long>, bool>();
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
                        параметры[item] = false;
                    }
                    else
                    {
                        if (номерСмены == 1)
                        {
                            параметры[item] = Таблица.AllRows.Any(x => x.Должность == item.Item1
                            && x.ГруппаСпецТехники == item.Item2
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ВремяНачалаСмены1.TimeOfDay <= датаВыхода.TimeOfDay
                            && (x.ВремяНачалаСмены1.AddHours((double)x.ДлительностьСмены1ВЧасах).TimeOfDay >= датаВыхода.TimeOfDay || датаВыхода.AddHours((double)x.ДлительностьСмены1ВЧасах).Day != датаВыхода.Day));
                        }
                        if (номерСмены == 2)
                        {
                            параметры[item] = Таблица.AllRows.Any(x => x.Должность == item.Item1
                            && x.ГруппаСпецТехники == item.Item2
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ВремяНачалаСмены2.TimeOfDay <= датаВыхода.TimeOfDay
                            && (x.ВремяНачалаСмены2.AddHours((double)x.ДлительностьСмены2ВЧасах).TimeOfDay >= датаВыхода.TimeOfDay || датаВыхода.AddHours((double)x.ДлительностьСмены2ВЧасах).Day != датаВыхода.Day));
                        }
                        if (номерСмены == 3)
                        {
                            параметры[item] = Таблица.AllRows.Any(x => x.Должность == item.Item1
                            && x.ГруппаСпецТехники == item.Item2
                            && ДеньНедели.ByDayOfWeek[датаВыхода.DayOfWeek] == x.ДеньНедели
                            && x.ВремяНачалаСмены3.TimeOfDay <= датаВыхода.TimeOfDay
                            && (x.ВремяНачалаСмены3.AddHours((double)x.ДлительностьСмены3ВЧасах).TimeOfDay >= датаВыхода.TimeOfDay || датаВыхода.AddHours((double)x.ДлительностьСмены3ВЧасах).Day != датаВыхода.Day));
                        }
                    }
                }
            }

            return параметры;
        }

        public Tuple<Должности, ГруппыСпецТехники, long>[] ДолжностиИТехникаИзГрафика() 
        {
            var пары = new Tuple<Должности, ГруппыСпецТехники, long>[0];
            if (Таблица.Count == 0)
            {
                NsgSettings.MainForm.ShowMessage("Не заполнена таблица графика");
            }
            else
            {
                List<Tuple<Должности, ГруппыСпецТехники, long>> доступныеДолжностиИТехника = new List<Tuple<Должности, ГруппыСпецТехники, long>>();
                foreach (var item in Таблица.AllRows)
                {
                    if (item.Должность.Selected || item.ГруппаСпецТехники.Selected)
                    {
                        доступныеДолжностиИТехника.Add(new Tuple<Должности, ГруппыСпецТехники, long>(item.Должность, item.ГруппаСпецТехники, item.Количество));
                    }
                }

                пары = доступныеДолжностиИТехника.Distinct().ToArray();
            }
            return пары;
        }
    }

}
