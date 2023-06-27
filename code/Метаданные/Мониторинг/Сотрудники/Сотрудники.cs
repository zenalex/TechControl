using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;
using System.Linq;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class Сотрудники
    {
        protected override List<Guid> BasePost()
        {
            if (ТаблицаРазмеров.Count > 0)
            {
                Размеры размер = Размеры.Новый();
                var cmp = new NsgCompare();
                cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.Размер, размер);
                var row = ТаблицаРазмеров.FindRow(cmp);
                if (row != null)
                {
                    throw new Exception($"Не заполнен размер {row.ВидСвойствНоменклатуры}");
                }
            }

            if (ДокументКонтроляСпецодежды.Selected)
            {
                foreach (var item in ДокументКонтроляСпецодежды.Таблица.AllRows)
                {
                    var вид = item.НоменклатураСпецодеждыИСИЗ.ВидНоменклатуры;
                    var видРазмернойСетки = item.НоменклатураСпецодеждыИСИЗ.ВидРазмернойСетки;
                    var cmp = new NsgCompare();
                    cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.ВидСвойствНоменклатуры, вид);
                    cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.ВидРазмернойСетки, видРазмернойСетки);
                    var строкаТаблицыРазмеров = ТаблицаРазмеров.FindRow(cmp);
                    if (строкаТаблицыРазмеров != null)
                    {
                        строкаТаблицыРазмеров.Размер = item.Размер;
                        строкаТаблицыРазмеров.Post();
                    }
                    else
                    {
                        строкаТаблицыРазмеров = ТаблицаРазмеров.NewRow();
                        строкаТаблицыРазмеров.Размер = item.Размер;
                        строкаТаблицыРазмеров.ВидСвойствНоменклатуры = вид;
                        строкаТаблицыРазмеров.ВидРазмернойСетки = видРазмернойСетки;
                        строкаТаблицыРазмеров.Post();
                    }
                }

                ДокументКонтроляСпецодежды = ПеремещениеСпецодежды.Новый();
            }
            return base.BasePost();
        }

        public Размеры РазмерНоменклатуры(Номенклатура номенклатура) 
        {
            Размеры размер = Размеры.Новый();
            if (ТаблицаРазмеров.Count > 0)
            {
                var cmp = new NsgCompare();
                cmp.Add(МониторингСотрудникиТаблицаРазмеров.Names.ВидСвойствНоменклатуры, номенклатура.ВидНоменклатуры);
                var row = ТаблицаРазмеров.FindRow(cmp);
                if (row != null)
                {
                    размер = row.Размер;
                }
            }
            return размер;
        }

        public Мерки ПолучитьМерку(bool запостить = false) 
        {
            var cmp = new NsgCompare();
            cmp.Add(Мерки.Names.Владелец, this);
            var мерка = Мерки.Новый();
            if (!мерка.Find(cmp))
            {
                мерка.New();
                мерка.Владелец = this;
            }
            else
            {
                мерка.Edit();
            }

            if (запостить)
            {
                мерка.Post();
            }

            return мерка;
        }

        public Размеры ПолучитьРазмер(Номенклатура номенклатураОдежды) 
        {
            var мерка = ПолучитьМерку(true);

            var cmp = new NsgCompare();

            var размер = Размеры.Новый();

            if (!номенклатураОдежды.ВидРазмернойСетки.Selected)
            {
                NsgSettings.MainForm.ShowMessage($"В номенклатуре не задан вид размернойй сетки. Поиск отменен",System.Windows.Forms.MessageBoxIcon.Warning);
                return размер;
            }

            if (!номенклатураОдежды.ВидНоменклатуры.Selected)
            {
                NsgSettings.MainForm.ShowMessage($"В номенклатуре не задан вид. Поиск отменен", System.Windows.Forms.MessageBoxIcon.Warning);
                return размер;
            }

            cmp.Add(Размеры.Names.ВидРазмернойСетки, номенклатураОдежды.ВидРазмернойСетки);
            cmp.Add(Размеры.Names.ВидСвойствНоменклатуры, номенклатураОдежды.ВидНоменклатуры);
            cmp.Add(Размеры.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var cmpOr = new NsgCompare(NsgLogicalOperator.Or);

            var cmpБоковаяДлинаБрюк = new NsgCompare();
            cmpБоковаяДлинаБрюк.Add(Размеры.Names.БоковаяДлинаБрюкМин, мерка.БоковаяДлинаБрюк, NsgComparison.LessOrEqual);
            cmpБоковаяДлинаБрюк.Add(Размеры.Names.БоковаяДлинаБрюкМакс, мерка.БоковаяДлинаБрюк, NsgComparison.Greater);
            cmpOr.Add(cmpБоковаяДлинаБрюк);

            var cmpВнутренняяДлинаБрюк = new NsgCompare();
            cmpВнутренняяДлинаБрюк.Add(Размеры.Names.ВнутренняяДлинаБрюкМин, мерка.ДлинаБрюкПоВнутреннемуШву, NsgComparison.LessOrEqual);
            cmpВнутренняяДлинаБрюк.Add(Размеры.Names.ВнутренняяДлинаБрюкМакс, мерка.ДлинаБрюкПоВнутреннемуШву, NsgComparison.Greater);
            cmpOr.Add(cmpВнутренняяДлинаБрюк);

            var cmpДлинаРукава = new NsgCompare();
            cmpДлинаРукава.Add(Размеры.Names.ДлинаРукаваМин, мерка.ДлинаРукава, NsgComparison.LessOrEqual);
            cmpДлинаРукава.Add(Размеры.Names.ДлинаРукаваМакс, мерка.ДлинаРукава, NsgComparison.Greater);
            cmpOr.Add(cmpДлинаРукава);

            var cmpДлинаСтупни = new NsgCompare();
            cmpДлинаСтупни.Add(Размеры.Names.ДлинаСтупниМин, мерка.ДлинаСтопы, NsgComparison.LessOrEqual);
            cmpДлинаСтупни.Add(Размеры.Names.ДлинаСтупниМакс, мерка.ДлинаСтопы, NsgComparison.Greater);
            cmpOr.Add(cmpДлинаСтупни);

            var cmpОбхватБедер = new NsgCompare();
            cmpОбхватБедер.Add(Размеры.Names.ОбхватБедерМин, мерка.ОбхватБедер, NsgComparison.LessOrEqual);
            cmpОбхватБедер.Add(Размеры.Names.ОбхватБедерМакс, мерка.ОбхватБедер, NsgComparison.Greater);
            cmpOr.Add(cmpОбхватБедер);

            var cmpОбхватГруди = new NsgCompare();
            cmpОбхватГруди.Add(Размеры.Names.ОбхватГрудиМин, мерка.ОбхватГруди, NsgComparison.LessOrEqual);
            cmpОбхватГруди.Add(Размеры.Names.ОбхватГрудиМакс, мерка.ОбхватГруди, NsgComparison.Greater);
            cmpOr.Add(cmpОбхватГруди);

            var cmpОбхватТалии = new NsgCompare();
            cmpОбхватТалии.Add(Размеры.Names.ОбхватТалииМин, мерка.ОбхватТалии, NsgComparison.LessOrEqual);
            cmpОбхватТалии.Add(Размеры.Names.ОбхватТалииМакс, мерка.ОбхватТалии, NsgComparison.Greater);
            cmpOr.Add(cmpОбхватТалии);

            var cmpОбхватШеи = new NsgCompare();
            cmpОбхватШеи.Add(Размеры.Names.ОбхватШеиМин, мерка.ОбхватШеи, NsgComparison.LessOrEqual);
            cmpОбхватШеи.Add(Размеры.Names.ОбхватШеиМакс, мерка.ОбхватШеи, NsgComparison.Greater);
            cmpOr.Add(cmpОбхватШеи);

            var cmpРост = new NsgCompare();
            cmpРост.Add(Размеры.Names.РостМин, мерка.Рост, NsgComparison.LessOrEqual);
            cmpРост.Add(Размеры.Names.РостМакс, мерка.Рост, NsgComparison.Greater);
            cmpOr.Add(cmpРост);

            cmp.Add(cmpOr);

            var всеРазмеры = Размеры.Новый().FindAll(cmp);

            if (всеРазмеры.Length == 0)
            {
                NsgSettings.MainForm.ShowMessage($"Для {номенклатураОдежды} не найден подходящий размер в справочнике", System.Windows.Forms.MessageBoxIcon.Warning);
                return размер;
            }
            else if (всеРазмеры.Length == 1)
            {
                размер = всеРазмеры[0];
                return размер;
            }
            else
            {
                Dictionary<Размеры, int> совпадения = new Dictionary<Размеры, int>();
                foreach (var разм in всеРазмеры)
                {
                    if (!совпадения.ContainsKey(разм))
                        совпадения[разм] = 0;

                    if (разм.БоковаяДлинаБрюкМакс > мерка.БоковаяДлинаБрюк && разм.БоковаяДлинаБрюкМин <= мерка.БоковаяДлинаБрюк)
                        совпадения[разм]++;

                    if (разм.ВнутренняяДлинаБрюкМакс > мерка.ДлинаБрюкПоВнутреннемуШву && разм.ВнутренняяДлинаБрюкМин <= мерка.ДлинаБрюкПоВнутреннемуШву)
                        совпадения[разм]++;

                    if (разм.ДлинаРукаваМакс > мерка.ДлинаРукава && разм.ДлинаРукаваМин <= мерка.ДлинаРукава)
                        совпадения[разм]++;

                    if (разм.ДлинаСтупниМакс > мерка.ДлинаСтопы && разм.ДлинаСтупниМин <= мерка.ДлинаСтопы)
                        совпадения[разм]++;

                    if (разм.ОбхватБедерМакс > мерка.ОбхватБедер && разм.ОбхватБедерМин <= мерка.ОбхватБедер)
                        совпадения[разм]++;

                    if (разм.ОбхватГрудиМакс > мерка.ОбхватГруди && разм.ОбхватГрудиМин <= мерка.ОбхватГруди)
                        совпадения[разм]++;

                    if (разм.ОбхватТалииМакс > мерка.ОбхватТалии && разм.ОбхватТалииМин <= мерка.ОбхватТалии)
                        совпадения[разм]++;

                    if (разм.ОбхватШеиМакс > мерка.ОбхватШеи && разм.ОбхватШеиМин <= мерка.ОбхватШеи)
                        совпадения[разм]++;

                    if (разм.РостМакс > мерка.Рост && разм.РостМин <= мерка.Рост)
                        совпадения[разм]++;
                }

                размер = совпадения.OrderByDescending(x => x.Value).First().Key;
                return размер;
            }
        }
    }

}
