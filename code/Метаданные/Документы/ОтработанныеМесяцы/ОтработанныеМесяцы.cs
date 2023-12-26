using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Мониторинг;
using System.Linq;
using TechControl.Метаданные._SystemTables;



namespace TechControl.Метаданные.Документы
{
    
    public partial class ОтработанныеМесяцы
    {
        public void ЗаполнитьТаблицуФактическимиДаннымиСмен() 
        {
            if (Объект.Selected)
            {
                var cmp = new NsgCompare();
                cmp.Add(ФормированиеСмены.Names.Объект, Объект);
                cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.BeginOfMonth(МесяцИтогов), NsgComparison.GreaterOrEqual);
                cmp.Add(ФормированиеСмены.Names.ДатаДокумента, NsgService.EndOfMonth(МесяцИтогов), NsgComparison.LessOrEqual);
                cmp.Add(ФормированиеСмены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var всеСмены = ФормированиеСмены.Новый().FindAll(cmp);
                var гуиды = всеСмены.Select(x => x.Идентификатор).ToArray();
                var cmpСменыТехника = new NsgCompare();
                cmpСменыТехника.Add(МониторингФормированиеСменыТаблица.Names.Владелец, гуиды, NsgComparison.In);
                var сменыТехники = МониторингФормированиеСменыТаблица.Новый().FindAll(cmpСменыТехника);

                var cmpСменыПерсонал = new NsgCompare();
                cmpСменыПерсонал.Add(МониторингФормированиеСменыТаблицаПерсонал.Names.Владелец, гуиды, NsgComparison.In);
                var сменыПерсонала = МониторингФормированиеСменыТаблицаПерсонал.Новый().FindAll(cmpСменыПерсонал);

                Таблица.DeleteAll();

                HashSet< Tuple<Техника, Сотрудники, Должности>> рабочаяТехника = new HashSet<Tuple<Техника, Сотрудники, Должности>>();
                foreach (var item in сменыТехники)
                {
                    рабочаяТехника.Add(new Tuple<Техника, Сотрудники, Должности>(item.Техника, item.Сотрудник, item.Должность));
                }

                HashSet<Tuple<Должности, Сотрудники>> рабочийПерсонал = new HashSet<Tuple<Должности, Сотрудники>>();

                foreach (var item in сменыПерсонала)
                {
                    рабочийПерсонал.Add(new Tuple<Должности, Сотрудники>(item.Должность, item.Сотрудник));
                }

                var всегоДней = NsgService.EndOfMonth(МесяцИтогов).Day;
                foreach (var item in рабочаяТехника)
                {
                    var row = Таблица.NewRow();
                    row.Техника = item.Item1;
                    row.ГруппаСпецТехники = item.Item1.ГруппаСпецТехники;
                    row.Сотрудник = item.Item2;
                    row.Должность = item.Item3;
                    for (int i = 1; i <= всегоДней; i++)
                    {
                        var строка = сменыТехники.First(x => x.Техника == item.Item1 && x.Сотрудник == item.Item2 && x.Должность == item.Item3 && x.Время.Day == i);
                        if (строка != null)
                        {
                            row[i.ToString()].Value = строка.Длительность;
                        }
                    }
                    row.Post();
                }

                foreach (var item in рабочийПерсонал)
                {
                    var row = Таблица.NewRow();
                    row.Сотрудник = item.Item2;
                    row.Должность = item.Item1;
                    for (int i = 1; i <= всегоДней; i++)
                    {
                        var строка = сменыПерсонала.First(x => x.Должность == item.Item1 && x.Сотрудник == item.Item2 && x.Время.Day == i);
                        if (строка != null)
                        {
                            row[i.ToString()].Value = строка.Длительность;
                        }
                    }
                    row.Post();
                }
            }
        }
    }

}
