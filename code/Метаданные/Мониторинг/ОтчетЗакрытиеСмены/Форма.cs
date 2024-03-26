using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Сервис;
using TechControl.Метаданные.СлужебныеСправочники;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ОтчетЗакрытиеСменыФорма

    {
        public ОтчетЗакрытиеСменыФорма()
        {
            InitializeComponent();
		}
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ФиксацияИстории фи = ФиксацияИстории.Новый();
            ЗакрытиеСмены зс = ЗакрытиеСмены.Новый();
            DateTime dt = NsgService.BeginOfDay(nsgPeriodPicker1.Period.Begin);
            do
            {
                var endOfDay = NsgService.EndOfDay(dt);
                var a = фи.GetRests(endOfDay, new NsgCompare().Add(ФиксацияИстории.Names.СтатусТехники, СтатусТехники.ВРаботе))
                    .CollapseToNewTable(new[] { ФиксацияИстории.Names.Объект }, null);
                foreach (var i in a.Rows)
                {
                    var объект = i[ФиксацияИстории.Names.Объект].ToReferent() as Объекты;
                    if (!зс.Find(new NsgCompare()
                        .Add(ЗакрытиеСмены.Names.Объект, объект)
                        .Add(ЗакрытиеСмены.Names.ДатаДокумента, endOfDay)))
                    {
                        зс.New();
                        зс.ДатаДокумента = зс.Время = endOfDay;
                        зс.Объект = объект;
                        зс.Post();
                    }
                    зс.Handle();
                }
                dt = dt.AddDays(1);
            }
            while (dt < nsgPeriodPicker1.Period.End);
        }

        #region Служебные действия
        // Перепровести все формирования смен
        private void nsgButtonПВФС_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ФормированиеСмены формированиеСмены = ФормированиеСмены.Новый();
            var all = формированиеСмены.FindAll(new NsgCompare()
                .Add(NsgDataFixedFields._State, NsgDataDocState.Handled)
                .Add(ФормированиеСмены.Names.ДатаДокумента, nsgPeriodPicker1.Period));
            foreach (var i in all)
            {
                try
                {
                    i.Handle();
                }
                catch (Exception x)
                {
                    NsgSettings.MainForm.ShowMessage("Не удалось провести " + i.ToString(), x);
                }
            }
        }

        private void nsgButtonОтменаПроведенияЗС_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗакрытиеСмены закрытиеСмены = ЗакрытиеСмены.Новый();
            var all = закрытиеСмены.FindAll(new NsgCompare()
                .Add(NsgDataFixedFields._State, NsgDataDocState.Handled)
                .Add(ЗакрытиеСмены.Names.ДатаДокумента, nsgPeriodPicker1.Period));
            foreach (var i in all)
            {
                try
                {
                    i.Unhandle();
                }
                catch (Exception x)
                {
                    i.Cancel();
                }
            }
            if (NsgMessage.ShowQuestionText("Удалить документы закрытия смен?") == DialogResult.Yes)
            {
                foreach (var i in all)
                {
                    i.SetDeleteMark();
                }
            }
        }

        private void bУдалитьУведомления_AsyncClick(object sender, DoWorkEventArgs e)
        {
            Уведомления уведомления = Уведомления.Новый();
            уведомления.Просмотрено = true;
            уведомления.UpdateArray(new NsgCompare().Add(Уведомления.Names.Просмотрено, false),
                уведомления.ObjectList[Уведомления.Names.Просмотрено]);
        }

        private void bСброситьПроверки_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (MessageBox.Show("Удалить документы проверки?", string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ПроверкаЗаправки проверкаЗаправки = ПроверкаЗаправки.Новый();
                var пз = проверкаЗаправки.FindAll(new NsgCompare()
                    .Add(ПроверкаЗаправки.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual));
                foreach (var i in пз) i.SetDeleteMark();
            }
            if (MessageBox.Show("Снять отометки \"Проверено\" у заправок?", string.Empty, MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Заправка заправка = Заправка.Новый();
                заправка.Проверено = false;
                заправка.UpdateArray(new NsgCompare().Add(Заправка.Names.Проверено, true),
                    заправка.ObjectList[Заправка.Names.Проверено]);
            }
        }

        private void bЗагрузитьИзТитана_AsyncClick(object sender, DoWorkEventArgs e)
        {
            //if (MessageBox.Show("Если данные уже загружались, они будут продублированы. Продолжить?", "", MessageBoxButtons.YesNo)
            //    != DialogResult.Yes) return;

            //var jsonSerializer =
            //    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Newtonsoft.Json.Formatting.Indented });
            //FileStream stream = new FileStream("titanControl.json", FileMode.Open, FileAccess.Read);
            //using (StreamReader streamReader = new StreamReader(stream))
            //{
            //    JsonTextReader jtr = new JsonTextReader(streamReader);
            //    Dictionary<string, IEnumerable<object>> dict = jsonSerializer.Deserialize<Dictionary<string, IEnumerable<object>>>(jtr);

            //    Dictionary<string, Сотрудники> всеСотрудники = new Dictionary<string, Сотрудники>();
            //    Dictionary<string, Контрагенты> всеКонтрагенты = new Dictionary<string, Контрагенты>();
            //    Dictionary<string, Тарифы> всеТарифы = new Dictionary<string, Тарифы>();
            //    Dictionary<string, Объекты> всеОбъекты = new Dictionary<string, Объекты>();

            //    List<ТитанКонтроль.Сотрудник> сотрудникиDict = new List<ТитанКонтроль.Сотрудник>();
            //    foreach (var i in dict["sotrudniki"])
            //        сотрудникиDict.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<ТитанКонтроль.Сотрудник>());

            //    List<ТитанКонтроль.Контрагент> контрагентыDict = new List<ТитанКонтроль.Контрагент>();
            //    foreach (var i in dict["kontragents"])
            //        контрагентыDict.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<ТитанКонтроль.Контрагент>());

            //    List<ТитанКонтроль.ТарифыСотрудниковНаОбъектах> тарифыDict = new List<ТитанКонтроль.ТарифыСотрудниковНаОбъектах>();
            //    foreach (var i in dict["tariffs"])
            //        тарифыDict.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<ТитанКонтроль.ТарифыСотрудниковНаОбъектах>());

            //    List<ТитанКонтроль.Объекты> объектыDict = new List<ТитанКонтроль.Объекты>();
            //    foreach (var i in dict["workObjects"])
            //        объектыDict.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<ТитанКонтроль.Объекты>());

            //    Сотрудники сотрудники = Сотрудники.Новый();
            //    Контрагенты контрагенты = Контрагенты.Новый();
            //    Тарифы тарифы = Тарифы.Новый();
            //    Объекты объекты = Объекты.Новый();

            //    Договоры договоры = Договоры.Новый();

            //    ReportProgress(-1, "Сотрудники");
            //    foreach (ТитанКонтроль.Сотрудник i in сотрудникиDict)
            //    {
            //        сотрудники.New();
            //        string name = string.Empty;
            //        сотрудники.Имя = i.FirstName;
            //        сотрудники.Отчество = i.MiddleName;
            //        сотрудники.Фамилия = i.LastName;
            //        if (!string.IsNullOrWhiteSpace(сотрудники.Фамилия)) name += сотрудники.Фамилия + ' ';
            //        if (!string.IsNullOrWhiteSpace(сотрудники.Имя)) name += сотрудники.Имя + ' ';
            //        if (!string.IsNullOrWhiteSpace(сотрудники.Отчество)) name += сотрудники.Отчество;
            //        сотрудники.Наименование = name.Trim();
            //        if (string.IsNullOrWhiteSpace(сотрудники.Наименование))
            //            сотрудники.Наименование = "Сотрудник не заполнен (" + i.Id + ")";
            //        сотрудники.ДатаРождения = i.BirthDate;
            //        сотрудники.ДатаПриемаНаРаботу = i.EmploymentDate;
            //        сотрудники.ДатаУвольнения = i.FiringDate;
            //        сотрудники.НомерТелефона = i.Phone;
            //        сотрудники.ТабельныйНомер = i.PersonnelNumber;
            //        сотрудники.Post();
            //        всеСотрудники.Add(i.Id, сотрудники);
            //        сотрудники = Сотрудники.Новый();
            //    }
            //    ReportProgress(-1, "Контрагенты");
            //    foreach (ТитанКонтроль.Контрагент i in контрагентыDict)
            //    {
            //        контрагенты.New();
            //        string name = string.Empty;
            //        контрагенты.Наименование = i.Name;
            //        контрагенты.ИНН = i.INN;
            //        контрагенты.Адрес = i.Address;
            //        if (string.IsNullOrWhiteSpace(контрагенты.Наименование))
            //            контрагенты.Наименование = i.Address;
            //        if (string.IsNullOrWhiteSpace(контрагенты.Наименование))
            //            контрагенты.Наименование = i.INN;
            //        if (string.IsNullOrWhiteSpace(контрагенты.Наименование))
            //            контрагенты.Наименование = "Сотрудник не заполнен (" + i.Id + ")";
            //        контрагенты.ЯвляетсяНашейФирмой = i.IsFirma;
            //        контрагенты.Post();
            //        всеКонтрагенты.Add(i.Id, контрагенты);
            //        контрагенты = Контрагенты.Новый();
            //    }
            //    ReportProgress(-1, "Тарифы");
            //    foreach (ТитанКонтроль.ТарифыСотрудниковНаОбъектах i in тарифыDict)
            //    {
            //        if (тарифы.Find(new NsgCompare().Add(Тарифы.Names.Наименование, i.Tariff))) continue;
            //        тарифы.New();
            //        тарифы.Наименование = i.Tariff;
            //        тарифы.Стоимость = i.Sum;
            //        тарифы.Post();
            //        всеТарифы.Add(i.Tariff, тарифы);
            //        тарифы = Тарифы.Новый();
            //    }
            //    ReportProgress(-1, "Объекты");
            //    foreach (ТитанКонтроль.Объекты i in объектыDict)
            //    {
            //        объекты.New();
            //        объекты.Наименование = i.Name;
            //        if (string.IsNullOrWhiteSpace(объекты.Наименование))
            //            объекты.Наименование = i.Address;
            //        if (string.IsNullOrWhiteSpace(объекты.Наименование))
            //            объекты.Наименование = "Объект не заполнен (" + i.Id + ")";
            //        объекты.Адрес = i.Address;
            //        if (всеКонтрагенты.TryGetValue(i.Zakazchik, out Контрагенты ка))
            //            объекты.Заказчик = ка;
            //        объекты.Договор = i.Dogovor;
            //        if (договоры.Find(new NsgCompare().Add(Договоры.Names.Наименование, i.Dogovor)))
            //        {
            //            объекты.ДоговорСсылка = договоры;
            //        }
            //        else
            //        {
            //            договоры.New();
            //            договоры.Наименование = i.Dogovor;
            //            договоры.Post();
            //            объекты.ДоговорСсылка = договоры;
            //        }
            //        if (всеКонтрагенты.TryGetValue(i.Firma, out Контрагенты фи))
            //            объекты.Фирма = фи;
            //        foreach (ТитанКонтроль.ТарифыСотрудниковНаОбъектах j in тарифыDict)
            //        {
            //            if (j.WorkObject != i.Id) continue;


            //            if (всеСотрудники.TryGetValue(j.Sotrudnik, out Сотрудники со) &&
            //                объекты.ТаблицаПерсонал.FindRow(new NsgCompare()
            //                    .Add(МониторингОбъектыТаблицаПерсонал.Names.Сотрудник, со)) == null)
            //            {
            //                var row = объекты.ТаблицаПерсонал.NewRow();
            //                row.Сотрудник = со;
            //                row.Post();
            //            }

            //            if (всеТарифы.TryGetValue(j.Tariff, out Тарифы та) &&
            //                объекты.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
            //                    .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, та)
            //                    .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Стоимость, j.Sum)) == null)
            //            {
            //                var rowT = объекты.ТаблицаТарифыСотрудников.NewRow();
            //                rowT.Тариф = та;
            //                rowT.Стоимость = j.Sum;
            //                rowT.Post();
            //            }
            //        }
            //        объекты.Post();
            //        всеОбъекты.Add(i.Id, объекты);
            //        объекты = Объекты.Новый();
            //    }
            //}
        }

        public class ТитанКонтроль
        {
            public class Объекты
            {
                public override string ToString()
                {
                    if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Address))
                        return Name + " (" + Address + ')';
                    if (!string.IsNullOrWhiteSpace(Name))
                        return Name;
                    if (!string.IsNullOrWhiteSpace(Address))
                        return Address;
                    return Name;
                }

                public string Id { get; set; }

                public string Name { get; set; }

                public string Address { get; set; }

                public string Dogovor { get; set; }

                public string Zakazchik { get; set; }

                public string Firma { get; set; }
            }
            public class Контрагент
            {
                public override string ToString()
                {
                    return Name;
                }

                public string Id { get; set; }

                public string Name { get; set; }

                public string Address { get; set; }

                public string INN { get; set; }

                public bool IsFirma { get; set; }
            }
            public class Сотрудник
            {
                public override string ToString()
                {
                    return LastName + ' ' + FirstName + ' ' + MiddleName;
                }

                public string Id { get; set; }

                public string FirstName { get; set; }

                public string MiddleName { get; set; }

                public string LastName { get; set; }

                public DateTime BirthDate { get; set; }

                public DateTime EmploymentDate { get; set; }

                public DateTime FiringDate { get; set; }

                public string Phone { get; set; }

                public string PersonnelNumber { get; set; }
            }
            public class ТарифыСотрудниковНаОбъектах
            {
                public override string ToString()
                {
                    return WorkObject + ' ' + Sotrudnik + ' ' + Tariff + ' ' + Sum;
                }

                public string Id { get; set; }

                public string Sotrudnik { get; set; }

                public string WorkObject { get; set; }

                public string Tariff { get; set; }

                public decimal Sum { get; set; }
            }
        }
        #endregion Служебные действия

    }
    


}