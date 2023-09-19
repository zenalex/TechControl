using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using System.Linq;

namespace TechControl.Метаданные.Учет
{
    
    public partial class Размеры
    {
        public Размеры ПолучитьБольший() 
        {
            var размер = Размеры.Новый();
            if (Selected)
            {
                var cmp = new NsgCompare();
                cmp.Add(Размеры.Names.ВидСвойствНоменклатуры, ВидСвойствНоменклатуры);
                cmp.Add(Размеры.Names.ВидРазмернойСетки, ВидРазмернойСетки);
                cmp.Add(Размеры.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                if (БоковаяДлинаБрюкМин != 0)
                    cmp.Add(Размеры.Names.БоковаяДлинаБрюкМин, БоковаяДлинаБрюкМин, NsgComparison.Greater);

                if (ВнутренняяДлинаБрюкМин != 0)
                    cmp.Add(Размеры.Names.ВнутренняяДлинаБрюкМин, ВнутренняяДлинаБрюкМин, NsgComparison.Greater);

                if (ДлинаРукаваМин != 0)
                    cmp.Add(Размеры.Names.ДлинаРукаваМин, ДлинаРукаваМин, NsgComparison.Greater);

                if (ДлинаСтупниМин != 0)
                    cmp.Add(Размеры.Names.ДлинаСтупниМин, ДлинаСтупниМин, NsgComparison.Greater);

                if (ОбхватБедерМин != 0)
                    cmp.Add(Размеры.Names.ОбхватБедерМин, ОбхватБедерМин, NsgComparison.Greater);

                if (ОбхватГрудиМин != 0)
                    cmp.Add(Размеры.Names.ОбхватГрудиМин, ОбхватГрудиМин, NsgComparison.Greater);

                if (ОбхватТалииМин != 0)
                    cmp.Add(Размеры.Names.ОбхватТалииМин, ОбхватТалииМин, NsgComparison.Greater);

                if (ОбхватШеиМин != 0)
                    cmp.Add(Размеры.Names.ОбхватШеиМин, ОбхватШеиМин, NsgComparison.Greater);

                if (ОбхватГоловыМин != 0)
                    cmp.Add(Размеры.Names.ОбхватГоловыМин, ОбхватГоловыМин, NsgComparison.Greater);

                if (РостМин != 0)
                    cmp.Add(Размеры.Names.РостМин, РостМин, NsgComparison.Greater);

                var всеРазмеры = Размеры.Новый().FindAll(cmp);
                if (всеРазмеры.Length == 0)
                {
                    return размер;
                }
                else if (всеРазмеры.Length == 1)
                {
                    размер = всеРазмеры[0];
                }
                else
                {
                    Dictionary<Размеры, int> совпадения = new Dictionary<Размеры, int>();
                    foreach (var разм in всеРазмеры)
                    {
                        совпадения[разм] = 0;
                    }

                    if (БоковаяДлинаБрюкМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.БоковаяДлинаБрюкМин).First()]++;

                    if (ВнутренняяДлинаБрюкМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ВнутренняяДлинаБрюкМин).First()]++;

                    if (ДлинаРукаваМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ДлинаРукаваМин).First()]++;

                    if (ДлинаСтупниМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ДлинаСтупниМин).First()]++;

                    if (ОбхватБедерМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ОбхватБедерМин).First()]++;

                    if (ОбхватГрудиМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ОбхватГрудиМин).First()]++;

                    if (ОбхватТалииМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ОбхватТалииМин).First()]++;

                    if (ОбхватШеиМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ОбхватШеиМин).First()]++;

                    if (ОбхватГоловыМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.ОбхватГоловыМин).First()]++;

                    if (РостМин != 0)
                        совпадения[всеРазмеры.OrderBy(x => x.РостМин).First()]++;

                    размер = совпадения.OrderByDescending(x => x.Value).First().Key;
                }
            }

            return размер;
        }

        public Размеры ПолучитьМеньший()
        {
            var размер = Размеры.Новый();
            if (Selected)
            {
                var cmp = new NsgCompare();
                cmp.Add(Размеры.Names.ВидСвойствНоменклатуры, ВидСвойствНоменклатуры);
                cmp.Add(Размеры.Names.ВидРазмернойСетки, ВидРазмернойСетки);
                cmp.Add(Размеры.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                if (БоковаяДлинаБрюкМакс != 0)
                    cmp.Add(Размеры.Names.БоковаяДлинаБрюкМакс, БоковаяДлинаБрюкМакс, NsgComparison.Less);

                if (ВнутренняяДлинаБрюкМакс != 0)
                    cmp.Add(Размеры.Names.ВнутренняяДлинаБрюкМакс, ВнутренняяДлинаБрюкМакс, NsgComparison.Less);

                if (ДлинаРукаваМакс != 0)
                    cmp.Add(Размеры.Names.ДлинаРукаваМакс, ДлинаРукаваМакс, NsgComparison.Less);

                if (ДлинаСтупниМакс != 0)
                    cmp.Add(Размеры.Names.ДлинаСтупниМакс, ДлинаСтупниМакс, NsgComparison.Less);

                if (ОбхватБедерМакс != 0)
                    cmp.Add(Размеры.Names.ОбхватБедерМакс, ОбхватБедерМакс, NsgComparison.Less);

                if (ОбхватГрудиМакс != 0)
                    cmp.Add(Размеры.Names.ОбхватГрудиМакс, ОбхватГрудиМакс, NsgComparison.Less);

                if (ОбхватТалииМакс != 0)
                    cmp.Add(Размеры.Names.ОбхватТалииМакс, ОбхватТалииМакс, NsgComparison.Less);

                if (ОбхватШеиМакс != 0)
                    cmp.Add(Размеры.Names.ОбхватШеиМакс, ОбхватШеиМакс, NsgComparison.Less);

                if (ОбхватГоловыМакс != 0)
                    cmp.Add(Размеры.Names.ОбхватГоловыМакс, ОбхватГоловыМакс, NsgComparison.Less);

                if (РостМакс != 0)
                    cmp.Add(Размеры.Names.РостМакс, РостМакс, NsgComparison.Less);

                var всеРазмеры = Размеры.Новый().FindAll(cmp);
                if (всеРазмеры.Length == 0)
                {
                    return размер;
                }
                else if (всеРазмеры.Length == 1)
                {
                    размер = всеРазмеры[0];
                }
                else
                {
                    Dictionary<Размеры, int> совпадения = new Dictionary<Размеры, int>();
                    foreach (var разм in всеРазмеры)
                    {
                        совпадения[разм] = 0;
                    }

                    if (БоковаяДлинаБрюкМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.БоковаяДлинаБрюкМакс).First()]++;

                    if (ВнутренняяДлинаБрюкМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ВнутренняяДлинаБрюкМакс).First()]++;

                    if (ДлинаРукаваМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ДлинаРукаваМакс).First()]++;

                    if (ДлинаСтупниМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ДлинаСтупниМакс).First()]++;

                    if (ОбхватБедерМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ОбхватБедерМакс).First()]++;

                    if (ОбхватГрудиМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ОбхватГрудиМакс).First()]++;

                    if (ОбхватТалииМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ОбхватТалииМакс).First()]++;

                    if (ОбхватШеиМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ОбхватШеиМакс).First()]++;

                    if (ОбхватГоловыМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.ОбхватГоловыМакс).First()]++;

                    if (РостМакс != 0)
                        совпадения[всеРазмеры.OrderByDescending(x => x.РостМакс).First()]++;

                    размер = совпадения.OrderByDescending(x => x.Value).First().Key;
                }
            }

            return размер;
        }
    }

}
