using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using NsgSoft.ReportData.Extensions;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Сервис;

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ЗагрузкаИзJSONФорма

    {
        public ЗагрузкаИзJSONФорма()
        {
            InitializeComponent();
		}

        #region OnCreateReport
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
        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm


        JsonSerializer JsonSerializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Newtonsoft.Json.Formatting.Indented });

        #region Контрагенты

        private void inputПовторноКА_EndEdit(object sender, EndEditEventArgs e)
        {
            vmoКонтрагенты.Data.BeginUpdateData();
            foreach (var row in vmoКонтрагенты.Data.MemoryTable.AllRows)
            {
                row.Edit();
                row[Выбор_к].Value = !row[Найдено_к].ToReferent().Selected || ПовторноКА_.Value;
                row.Post();
            }
            vmoКонтрагенты.Data.UpdateDataAsync(this);
        }

        private void bЗаполнитьКА_AsyncClick(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog ofd = null;
            DialogResult ofdResult = default;
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Json files(*.json)|*.json";
                ofdResult = ofd.ShowDialog();
            }), null);
            if (ofdResult != DialogResult.OK) return;

            Контрагенты контрагенты = Контрагенты.Новый();

            string fileNames = "Загрузка из JSON - контрагенты - ";
            List<Guid> guids = new List<Guid>();

            vmoКонтрагенты.Data.BeginUpdateData();
            vmoКонтрагенты.Data.MemoryTable.Clear();
            foreach (string filePath in ofd.FileNames)
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    JsonTextReader jtr = new JsonTextReader(streamReader);
                    Dictionary<string, IEnumerable<object>> dict =
                        JsonSerializer.Deserialize<Dictionary<string, IEnumerable<object>>>(jtr);

                    if (!dict.ContainsKey("kontragents")) continue;
                    List<Служебные.Контрагент> контрагентыList = new List<Служебные.Контрагент>();
                    foreach (var i in dict["kontragents"])
                        контрагентыList.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<Служебные.Контрагент>());

                    Dictionary<Guid, Контрагенты> всеКонтрагенты = new Dictionary<Guid, Контрагенты>();
                    var all = контрагенты.FindAll(new NsgCompare().Add(Контрагенты.Names.Идентификатор,
                        контрагентыList.Select(i => i.Id).ToArray(), NsgComparison.In));
                    foreach (var i in all)
                    {
                        всеКонтрагенты.Add(i.Идентификатор, i);
                    }

                    foreach (var i in контрагентыList)
                    {
                        if (i.Id == Guid.Empty) continue;
                        var row = vmoКонтрагенты.Data.MemoryTable.NewRow();
                        row[Идентификатор_к].Value = i.Id;
                        string name = i.Name;
                        row[Адрес_к].Value = i.Address;
                        row[ИНН_к].Value = i.INN;
                        if (string.IsNullOrWhiteSpace(name))
                            name = i.Address;
                        if (string.IsNullOrWhiteSpace(name))
                            name = i.INN;
                        if (string.IsNullOrWhiteSpace(name))
                            name = "Не заполнен (" + i.Id + ")";
                        row[Наименование_к].Value = name;
                        row[ЭтоФирма_к].Value = i.IsFirma;
                        if (всеКонтрагенты.TryGetValue(i.Id, out Контрагенты найдено))
                        {
                            row[Найдено_к].Value = найдено;
                            row[Выбор_к].Value = ПовторноКА_.Value;
                        }
                        else
                        {
                            row[Выбор_к].Value = true;
                        }
                        row.Post();
                    }
                }
            }
            vmoКонтрагенты.Data.UpdateDataSync(this);
            //var mt = vmoКонтрагенты.Data.MemoryTable.ColumnToArray(Наименование_к.Name, null, true);
            //var allOld = контрагенты.FindAll(new NsgCompare().Add(Контрагенты.Names.Наименование, mt, NsgComparison.In));
            //foreach (var i in allOld)
            //{
            //    i.SetDeleteMark();
            //}
            NsgTracer.WriteInfo(fileNames);
        }

        private void bСохранитьКА_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var dialog = MessageBox.Show("Сохранить контрагентов?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (dialog != DialogResult.OK) return;

            NsgTracer.WriteInfo("Загрузка из JSON - контрагенты, начало");

            Контрагенты контрагенты = Контрагенты.Новый();

            var goodsIds = vmoКонтрагенты.Data.MemoryTable.ColumnToArray(Идентификатор_к.Name, new NsgCompare()
                .Add(Выбор_к.Name, true), true);

            var контрагентыСущ = контрагенты.FindAll(new NsgCompare()
                .Add(Контрагенты.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual)
                .Add(Контрагенты.Names.Идентификатор, goodsIds, NsgComparison.In));
            Dictionary<Guid, Контрагенты> контрагентыDict = new Dictionary<Guid, Контрагенты>();
            foreach (Контрагенты i in контрагентыСущ)
            {
                контрагентыDict.Add(i.Идентификатор, i);
            }

            int count = 0;
            foreach (var row in vmoКонтрагенты.Data.MemoryTable.Rows)
            {
                if (!row[Выбор_к].ToBoolean()) continue;
                ReportProgress(-1, (++count).ToString() + ". " + row[Наименование_к].ToString());

                NsgSettings.BeginTransaction();

                try
                {
                    if (контрагентыDict.TryGetValue((Guid)row[Идентификатор_к].Value, out контрагенты))//номенклатура.Find(NsgDataFixedFields._ID, (Guid)i[Идентификатор_т].Value))
                    {
                        //if (номенклатура.ТаблицаСвойств.Count > 0)
                        //{
                        //    NsgSettings.RollbackTransaction();
                        //    continue;
                        //}
                        контрагенты.Edit();
                    }
                    else if (row[Найдено_к].ToReferent().Selected)
                    {
                        контрагенты = row[Найдено_к].ToReferent() as Контрагенты;
                        контрагенты.Edit();
                    }
                    else
                    {
                        контрагенты = Контрагенты.Новый();
                        контрагенты.New();
                        контрагенты.Идентификатор = (Guid)row[Идентификатор_к].Value;
                    }
                    контрагенты.Наименование = row[Наименование_к].ToString();
                    контрагенты.ИНН = row[ИНН_к].ToString();
                    контрагенты.Адрес = row[Адрес_к].ToString();
                    контрагенты.ЯвляетсяНашейФирмой = row[ЭтоФирма_к].ToBoolean();
                    контрагенты.Post();
                    NsgSettings.CommitTransaction();
                }
                catch
                {
                    NsgSettings.RollbackTransaction();
                    throw;
                }
            }
        }

        private void bСохранитьКА_AsyncClickCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NsgTracer.WriteInfo("Загрузка из JSON - контрагенты, окончание");
        }

        #endregion

        #region Объекты

        private void inputПовторноОбъ_EndEdit(object sender, EndEditEventArgs e)
        {
            vmoОбъекты.Data.BeginUpdateData();
            foreach (var row in vmoОбъекты.Data.MemoryTable.AllRows)
            {
                row.Edit();
                row[Выбор_о].Value = !row[Найдено_о].ToReferent().Selected || ПовторноОбъ_.Value;
                row.Post();
            }
            vmoОбъекты.Data.UpdateDataAsync(this);
        }

        private void bЗаполнитьОбъекты_AsyncClick(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog ofd = null;
            DialogResult ofdResult = default;
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Json files(*.json)|*.json";
                ofdResult = ofd.ShowDialog();
            }), null);
            if (ofdResult != DialogResult.OK) return;

            Объекты объекты = Объекты.Новый();

            string fileNames = "Загрузка из JSON - объекты - ";
            List<Guid> guids = new List<Guid>();

            Контрагенты контрагенты = Контрагенты.Новый();

            vmoОбъекты.Data.BeginUpdateData();
            vmoОбъекты.Data.MemoryTable.Clear();
            foreach (string filePath in ofd.FileNames)
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    JsonTextReader jtr = new JsonTextReader(streamReader);
                    Dictionary<string, IEnumerable<object>> dict =
                        JsonSerializer.Deserialize<Dictionary<string, IEnumerable<object>>>(jtr);

                    if (!dict.ContainsKey("workObjects")) continue;
                    List<Служебные.Объекты> объектыList = new List<Служебные.Объекты>();
                    foreach (var i in dict["workObjects"])
                        объектыList.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<Служебные.Объекты>());

                    Dictionary<Guid, Объекты> всеОбъекты = new Dictionary<Guid, Объекты>();
                    var all = объекты.FindAll(new NsgCompare().Add(Объекты.Names.Идентификатор,
                        объектыList.Select(i => i.Id).ToArray(), NsgComparison.In));
                    var allKA = контрагенты.FindAll(new NsgCompare(NsgLogicalOperator.Or)
                        .Add(Контрагенты.Names.Идентификатор, объектыList.Select(i => i.Zakazchik).ToArray(), NsgComparison.In)
                        .Add(Контрагенты.Names.Идентификатор, объектыList.Select(i => i.Firma).ToArray(), NsgComparison.In));
                    foreach (var i in all)
                    {
                        всеОбъекты.Add(i.Идентификатор, i);
                    }

                    foreach (var i in объектыList)
                    {
                        if (i.Id == Guid.Empty) continue;
                        var row = vmoОбъекты.Data.MemoryTable.NewRow();
                        row[Идентификатор_о].Value = i.Id;
                        string name = i.Name;
                        row[Адрес_о].Value = i.Address;
                        if (string.IsNullOrWhiteSpace(name))
                            name = i.Address;
                        if (string.IsNullOrWhiteSpace(name))
                            name = "Не заполнен (" + i.Id + ")";
                        row[Наименование_о].Value = name;
                        row[Договор_о].Value = i.Dogovor;

                        if (i.Zakazchik == Guid.Empty) { }
                        else if (allKA.Any(ka => ka.Идентификатор == i.Zakazchik))
                            row[Заказчик_о].Value = allKA.First(ka => ka.Идентификатор == i.Zakazchik);
                        else
                            row[Заказчик_о].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);

                        if (i.Firma == Guid.Empty) { }
                        else if (allKA.Any(ka => ka.Идентификатор == i.Firma))
                            row[Фирма_о].Value = allKA.First(ka => ka.Идентификатор == i.Firma);
                        else
                            row[Фирма_о].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);

                        if (всеОбъекты.TryGetValue(i.Id, out Объекты найдено))
                        {
                            row[Найдено_о].Value = найдено;
                            row[Выбор_о].Value = ПовторноОбъ_.Value;
                        }
                        else
                        {
                            row[Выбор_о].Value = true;
                        }
                        row.Post();
                    }
                }
            }
            vmoОбъекты.Data.UpdateDataSync(this);
            //var mt = vmoОбъекты.Data.MemoryTable.ColumnToArray(Наименование_о.Name, null, true);
            //var allOld = объекты.FindAll(new NsgCompare().Add(Объекты.Names.Наименование, mt, NsgComparison.In));
            //foreach (var i in allOld)
            //{
            //    i.SetDeleteMark();
            //}
            NsgTracer.WriteInfo(fileNames);
        }

        private void bСохранитьОбъекты_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var dialog = MessageBox.Show("Сохранить объекты?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (dialog != DialogResult.OK) return;

            NsgTracer.WriteInfo("Загрузка из JSON - объекты, начало");

            Объекты объекты = Объекты.Новый();

            var goodsIds = vmoОбъекты.Data.MemoryTable.ColumnToArray(Идентификатор_о.Name, new NsgCompare()
                .Add(Выбор_о.Name, true), true);

            var объектыСущ = объекты.FindAll(new NsgCompare()
                .Add(Объекты.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual)
                .Add(Объекты.Names.Идентификатор, goodsIds, NsgComparison.In));
            Dictionary<Guid, Объекты> объектыDict = new Dictionary<Guid, Объекты>();
            foreach (Объекты i in объектыСущ)
            {
                объектыDict.Add(i.Идентификатор, i);
            }

            int count = 0;
            foreach (var row in vmoОбъекты.Data.MemoryTable.Rows)
            {
                if (!row[Выбор_о].ToBoolean()) continue;
                if (row[Заказчик_о].GetUserProperty(NsgIGrid.BACKCOLOR) != null ||
                    row[Фирма_о].GetUserProperty(NsgIGrid.BACKCOLOR) != null) continue;
                ReportProgress(-1, (++count).ToString() + ". " + row[Наименование_о].ToString());

                NsgSettings.BeginTransaction();

                try
                {
                    if (объектыDict.TryGetValue((Guid)row[Идентификатор_о].Value, out объекты))
                    {
                        объекты.Edit();
                    }
                    else if (row[Найдено_о].ToReferent().Selected)
                    {
                        объекты = row[Найдено_о].ToReferent() as Объекты;
                        объекты.Edit();
                    }
                    else
                    {
                        объекты = Объекты.Новый();
                        объекты.New();
                        объекты.Идентификатор = (Guid)row[Идентификатор_о].Value;
                    }
                    объекты.Наименование = row[Наименование_о].ToString();
                    объекты.Адрес = row[Адрес_о].ToString();
                    объекты.ДоговорСсылка = row[ДоговорСсылка_о].ToReferent() as Договоры;
                    объекты.Договор = row[Договор_о].ToString();
                    объекты.Заказчик = row[Заказчик_о].ToReferent() as Контрагенты;
                    объекты.Фирма = row[Фирма_о].ToReferent() as Контрагенты;
                    объекты.Post();
                    NsgSettings.CommitTransaction();
                }
                catch
                {
                    NsgSettings.RollbackTransaction();
                    throw;
                }
            }
        }

        private void bСохранитьОбъекты_AsyncClickCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NsgTracer.WriteInfo("Загрузка из JSON - объекты, окончание");
        }

        #endregion

        #region Сотрудники

        private void inputПовторноСотр_EndEdit(object sender, EndEditEventArgs e)
        {
            vmoСотрудники.Data.BeginUpdateData();
            foreach (var row in vmoСотрудники.Data.MemoryTable.AllRows)
            {
                row.Edit();
                row[Выбор_с].Value = !row[Найдено_с].ToReferent().Selected || ПовторноСотр_.Value;
                row.Post();
            }
            vmoСотрудники.Data.UpdateDataAsync(this);
        }

        private void bЗаполнитьСотрудников_AsyncClick(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog ofd = null;
            DialogResult ofdResult = default;
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Json files(*.json)|*.json";
                ofdResult = ofd.ShowDialog();
            }), null);
            if (ofdResult != DialogResult.OK) return;

            ФизЛица сотрудники = ФизЛица.Новый();

            string fileNames = "Загрузка из JSON - сотрудники - ";
            List<Guid> guids = new List<Guid>();

            Контрагенты контрагенты = Контрагенты.Новый();

            vmoСотрудники.Data.BeginUpdateData();
            vmoСотрудники.Data.MemoryTable.Clear();
            foreach (string filePath in ofd.FileNames)
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    JsonTextReader jtr = new JsonTextReader(streamReader);
                    Dictionary<string, IEnumerable<object>> dict =
                        JsonSerializer.Deserialize<Dictionary<string, IEnumerable<object>>>(jtr);

                    if (!dict.ContainsKey("sotrudniki")) continue;
                    List<Служебные.Сотрудник> сотрудникиList = new List<Служебные.Сотрудник>();
                    foreach (var i in dict["sotrudniki"])
                        сотрудникиList.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<Служебные.Сотрудник>());

                    Dictionary<Guid, ФизЛица> всеСотрудники = new Dictionary<Guid, ФизЛица>();
                    var all = сотрудники.FindAll(new NsgCompare().Add(ФизЛица.Names.Идентификатор,
                        сотрудникиList.Select(i => i.Id).ToArray(), NsgComparison.In));
                    //var allKA = контрагенты.FindAll(new NsgCompare(NsgLogicalOperator.Or)
                    //    .Add(Контрагенты.Names.Идентификатор, сотрудникиList.Select(i => i.Zakazchik).ToArray(), NsgComparison.In)
                    //    .Add(Контрагенты.Names.Идентификатор, сотрудникиList.Select(i => i.Firma).ToArray(), NsgComparison.In));
                    foreach (var i in all)
                    {
                        всеСотрудники.Add(i.Идентификатор, i);
                    }

                    foreach (var i in сотрудникиList)
                    {
                        if (i.Id == Guid.Empty) continue;
                        var row = vmoСотрудники.Data.MemoryTable.NewRow();
                        row[Идентификатор_с].Value = i.Id;
                        row[Имя_с].Value = i.FirstName;
                        row[Отчество_с].Value = i.MiddleName;
                        row[Фамилия_с].Value = i.LastName;
                        string name = string.Empty;
                        сотрудники.Имя = i.FirstName;
                        сотрудники.Отчество = i.MiddleName;
                        сотрудники.Фамилия = i.LastName;
                        if (!string.IsNullOrWhiteSpace(i.LastName)) name += i.LastName + ' ';
                        if (!string.IsNullOrWhiteSpace(i.FirstName)) name += i.FirstName + ' ';
                        if (!string.IsNullOrWhiteSpace(i.MiddleName)) name += i.MiddleName;
                        name = name.Trim();
                        if (string.IsNullOrWhiteSpace(name))
                            name = "Сотрудник не заполнен (" + i.Id + ")";
                        row[Наименование_с].Value = name;
                        row[ДатаРождения_с].Value = i.BirthDate;
                        row[ДатаПриемаНаРаботу_с].Value = i.EmploymentDate;
                        row[ДатаУвольнения_с].Value = i.FiringDate;
                        row[Телефон_с].Value = i.Phone;
                        row[ТабельныйНомер_с].Value = i.PersonnelNumber;

                        if (всеСотрудники.TryGetValue(i.Id, out ФизЛица найдено))
                        {
                            row[Найдено_с].Value = найдено;
                            row[Выбор_с].Value = ПовторноСотр_.Value;
                        }
                        else
                        {
                            row[Выбор_с].Value = true;
                        }
                        row.Post();
                    }
                }
            }
            vmoСотрудники.Data.UpdateDataSync(this);
            //var mt = vmoСотрудники.Data.MemoryTable.ColumnToArray(Наименование_с.Name, null, true);
            //var allOld = сотрудники.FindAll(new NsgCompare().Add(Сотрудники.Names.Наименование, mt, NsgComparison.In));
            //foreach (var i in allOld)
            //{
            //    i.SetDeleteMark();
            //}
            NsgTracer.WriteInfo(fileNames);
        }

        private void bСохранитьСотрудников_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var dialog = MessageBox.Show("Сохранить сотрудников?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (dialog != DialogResult.OK) return;

            NsgTracer.WriteInfo("Загрузка из JSON - сотрудники, начало");

            ФизЛица сотрудники = ФизЛица.Новый();

            var goodsIds = vmoСотрудники.Data.MemoryTable.ColumnToArray(Идентификатор_с.Name, new NsgCompare()
                .Add(Выбор_с.Name, true), true);

            var сотрудникиСущ = сотрудники.FindAll(new NsgCompare()
                .Add(ФизЛица.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual)
                .Add(ФизЛица.Names.Идентификатор, goodsIds, NsgComparison.In));
            Dictionary<Guid, ФизЛица> сотрудникиDict = new Dictionary<Guid, ФизЛица>();
            foreach (ФизЛица i in сотрудникиСущ)
            {
                сотрудникиDict.Add(i.Идентификатор, i);
            }

            int count = 0;
            foreach (var row in vmoСотрудники.Data.MemoryTable.Rows)
            {
                if (!row[Выбор_с].ToBoolean()) continue;
                ReportProgress(-1, (++count).ToString() + ". " + row[Наименование_с].ToString());

                NsgSettings.BeginTransaction();

                try
                {
                    if (сотрудникиDict.TryGetValue((Guid)row[Идентификатор_с].Value, out сотрудники))
                    {
                        сотрудники.Edit();
                    }
                    else if (row[Найдено_с].ToReferent().Selected)
                    {
                        сотрудники = row[Найдено_с].ToReferent() as ФизЛица;
                        сотрудники.Edit();
                    }
                    else
                    {
                        сотрудники = ФизЛица.Новый();
                        сотрудники.New();
                        сотрудники.Идентификатор = (Guid)row[Идентификатор_с].Value;
                    }
                    сотрудники.Наименование = row[Наименование_с].ToString();
                    сотрудники.Имя = row[Имя_с].ToString();
                    сотрудники.Отчество = row[Отчество_с].ToString();
                    сотрудники.Фамилия = row[Фамилия_с].ToString();
                    сотрудники.ДатаРождения = row[ДатаРождения_с].ToDateTime();
                    сотрудники.ДатаПриемаНаРаботу = row[ДатаПриемаНаРаботу_с].ToDateTime();
                    сотрудники.ДатаУвольнения = row[ДатаУвольнения_с].ToDateTime();
                    сотрудники.НомерТелефона = row[Телефон_с].ToString();
                    сотрудники.ТабельныйНомер = row[ТабельныйНомер_с].ToString();
                    сотрудники.Post();
                    NsgSettings.CommitTransaction();
                }
                catch
                {
                    NsgSettings.RollbackTransaction();
                    throw;
                }
            }
        }

        private void bСохранитьСотрудников_AsyncClickCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NsgTracer.WriteInfo("Загрузка из JSON - сотрудники, окончание");
        }

        #endregion

        #region Тарифы

        private void inputПовторноТар_EndEdit(object sender, EndEditEventArgs e)
        {
            vmoТарифы.Data.BeginUpdateData();
            foreach (var row in vmoТарифы.Data.MemoryTable.AllRows)
            {
                row.Edit();
                row[Выбор_т].Value = !row[Найдено_т].ToReferent().Selected || ПовторноТар_.Value;
                row.Post();
            }
            vmoТарифы.Data.UpdateDataAsync(this);
        }

        private void bЗаполнитьТарифы_AsyncClick(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog ofd = null;
            DialogResult ofdResult = default;
            NsgSettings.MainForm.Invoke(new MethodInvoker(() =>
            {
                ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Json files(*.json)|*.json";
                ofdResult = ofd.ShowDialog();
            }), null);
            if (ofdResult != DialogResult.OK) return;

            Тарифы тарифы = Тарифы.Новый();

            string fileNames = "Загрузка из JSON - сотрудники - ";
            List<Guid> guids = new List<Guid>();

            ФизЛица сотрудники = ФизЛица.Новый();
            Объекты объекты = Объекты.Новый();

            vmoТарифы.Data.BeginUpdateData();
            vmoТарифы.Data.MemoryTable.Clear();
            foreach (string filePath in ofd.FileNames)
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    JsonTextReader jtr = new JsonTextReader(streamReader);
                    Dictionary<string, IEnumerable<object>> dict =
                        JsonSerializer.Deserialize<Dictionary<string, IEnumerable<object>>>(jtr);

                    if (!dict.ContainsKey("tariffs")) continue;
                    List<Служебные.ТарифыСотрудниковНаОбъектах> тарифыList = new List<Служебные.ТарифыСотрудниковНаОбъектах>();
                    foreach (var i in dict["tariffs"])
                        тарифыList.Add((i as Newtonsoft.Json.Linq.JObject)?.ToObject<Служебные.ТарифыСотрудниковНаОбъектах>());

                    Dictionary<string, Тарифы> всеТарифы = new Dictionary<string, Тарифы>();
                    var all = тарифы.FindAll(new NsgCompare().Add(Тарифы.Names.Наименование,
                        тарифыList.Select(i => i.Tariff).ToArray(), NsgComparison.In));
                    var allSotr = сотрудники.FindAll(new NsgCompare(NsgLogicalOperator.Or)
                        .Add(ФизЛица.Names.Идентификатор, тарифыList.Select(i => i.Sotrudnik).ToArray(), NsgComparison.In));
                    var allWO = объекты.FindAll(new NsgCompare(NsgLogicalOperator.Or)
                        .Add(Объекты.Names.Идентификатор, тарифыList.Select(i => i.WorkObject).ToArray(), NsgComparison.In));
                    foreach (var i in all)
                    {
                        всеТарифы.Add(i.Наименование, i);
                    }

                    foreach (var i in тарифыList)
                    {
                        var row = vmoТарифы.Data.MemoryTable.NewRow();
                        row[Наименование_т].Value = i.Tariff;
                        row[Стоимость_т].Value = i.Sum;

                        if (i.Sotrudnik == Guid.Empty) { }
                        else if (allSotr.Any(ka => ka.Идентификатор == i.Sotrudnik))
                            row[Сотрудник_т].Value = allSotr.First(ka => ka.Идентификатор == i.Sotrudnik);
                        else
                            row[Сотрудник_т].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);

                        if (i.WorkObject == Guid.Empty) { }
                        else if (allWO.Any(ka => ka.Идентификатор == i.WorkObject))
                            row[Объект_т].Value = allWO.First(ka => ka.Идентификатор == i.WorkObject);
                        else
                            row[Объект_т].AddUserProperty(NsgIGrid.BACKCOLOR, Color.Pink);

                        if (всеТарифы.TryGetValue(i.Tariff, out Тарифы найдено))
                        {
                            row[Найдено_т].Value = найдено;
                            row[Выбор_т].Value = ПовторноТар_.Value;
                        }
                        else
                        {
                            row[Выбор_с].Value = true;
                        }
                        row.Post();
                    }
                }
            }
            vmoТарифы.Data.UpdateDataSync(this);
            //var mt = vmoОбъекты.Data.MemoryTable.ColumnToArray(Наименование_к.Name, null, true);
            //var allOld = объекты.FindAll(new NsgCompare().Add(Объекты.Names.Наименование, mt, NsgComparison.In));
            //foreach (var i in allOld)
            //{
            //    i.SetDeleteMark();
            //}
            NsgTracer.WriteInfo(fileNames);
        }

        private void bСохранитьТарифы_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var dialog = MessageBox.Show("Сохранить тарифы?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (dialog != DialogResult.OK) return;

            NsgTracer.WriteInfo("Загрузка из JSON - тарифы, начало");

            Тарифы тарифы = Тарифы.Новый();

            var goodsIds = vmoТарифы.Data.MemoryTable.ColumnToArray(Наименование_т.Name, new NsgCompare()
                .Add(Выбор_т.Name, true), true);

            var тарифыСущ = тарифы.FindAll(new NsgCompare()
                .Add(ФизЛица.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual)
                .Add(ФизЛица.Names.Наименование, goodsIds, NsgComparison.In));
            Dictionary<string, Тарифы> тарифыDict = new Dictionary<string, Тарифы>();
            foreach (Тарифы i in тарифыСущ)
            {
                тарифыDict.Add(i.Наименование, i);
            }

            int count = 0;
            foreach (var row in vmoТарифы.Data.MemoryTable.Rows)
            {
                if (!row[Выбор_т].ToBoolean()) continue;
                //if (row[Объект_т].GetUserProperty(NsgIGrid.BACKCOLOR) != null ||
                //    row[Сотрудник_т].GetUserProperty(NsgIGrid.BACKCOLOR) != null) continue;
                ReportProgress(-1, (++count).ToString() + ". " + row[Наименование_т].ToString());

                var sum = row[Стоимость_т].ToDecimal();

                if (тарифыDict.TryGetValue(row[Наименование_т].ToString(), out тарифы)) { }
                else if (row[Найдено_т].ToReferent().Selected)
                {
                    тарифы = row[Найдено_т].ToReferent() as Тарифы;
                }
                else
                {
                    тарифы = Тарифы.Новый();
                    тарифы.New();
                    тарифы.Наименование = row[Наименование_с].ToString();
                    тарифы.Стоимость = sum;
                    тарифы.Post();
                }

                //var объект = row[Объект_т].ToReferent() as Объекты;
                //var сотрудник = row[Сотрудник_т].ToReferent() as Сотрудники;
                //if (объект.Selected)
                //{
                //    объект.Edit();
                //    if (сотрудник.Selected && объект.ТаблицаПерсонал.FindRow(new NsgCompare()
                //        .Add(МониторингОбъектыТаблицаПерсонал.Names.Сотрудник, сотрудник)) == null)
                //    {
                //        var persRow = объект.ТаблицаПерсонал.NewRow();
                //        persRow.Сотрудник = сотрудник;
                //        persRow.Post();
                //    }

                //    var tarRow = объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
                //        .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, тарифы));
                //    if (tarRow == null)
                //    {
                //        tarRow = объект.ТаблицаТарифыСотрудников.NewRow();
                //        tarRow.Тариф = тарифы;
                //    }
                //    else tarRow.Edit();
                //    tarRow.Стоимость = sum;
                //    tarRow.Post();
                //    объект.Post();
                //}
            }
        }

        private void bСохранитьТарифы_AsyncClickCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NsgTracer.WriteInfo("Загрузка из JSON - тарифы, окончание");
        }

        private void bСохранитьТарифыВОбъектах_AsyncClick(object sender, DoWorkEventArgs e)
        {
            //var dialog = MessageBox.Show("Сохранить тарифы и сотрудников в объектах?", "Подтверждение", MessageBoxButtons.OKCancel);
            //if (dialog != DialogResult.OK) return;

            //NsgTracer.WriteInfo("Загрузка из JSON - тарифы в объектах, начало");

            ////Тарифы тарифы = Тарифы.Новый();

            ////var goodsIds = vmoТарифы.Data.MemoryTable.ColumnToArray(Наименование_т.Name, new NsgCompare()
            ////    .Add(Выбор_т.Name, true), true);

            ////var тарифыСущ = тарифы.FindAll(new NsgCompare()
            ////    .Add(Сотрудники.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual)
            ////    .Add(Сотрудники.Names.Наименование, goodsIds, NsgComparison.In));
            ////Dictionary<string, Тарифы> тарифыDict = new Dictionary<string, Тарифы>();
            ////foreach (Тарифы i in тарифыСущ)
            ////{
            ////    тарифыDict.Add(i.Наименование, i);
            ////}

            //var объекты = vmoТарифы.Data.MemoryTable.ColumnToArray(Объект_т.Name, new NsgCompare().Add(Выбор_т.Name, true), true)
            //    .Select(i => i.ToReferent() as Объекты);

            //int count = 0;
            //foreach (var объект in /*vmoТарифы.Data.MemoryTable.Rows*/объекты)
            //{
            //    if (!объект.Selected) continue;
            //    ReportProgress(-1, (++count).ToString() + ". " + объект);

            //    var rows = vmoТарифы.Data.MemoryTable.FindRows(new NsgCompare().Add(Выбор_т.Name, true)
            //        .Add(Объект_т.Name, объект)
            //        .Add(Найдено_т.Name, Тарифы.Новый(), NsgComparison.NotEqual));

            //    объект.Edit();

            //    foreach (var row in rows)
            //    {
            //        var тариф = row[Найдено_т].ToReferent() as Тарифы;
            //        var sum = row[Стоимость_т].ToDecimal();

            //        var сотрудник = row[Сотрудник_т].ToReferent() as Сотрудники;
            //        var списокСотрудников = объект.СписокПерсонала();
            //        if (сотрудник.Selected && списокСотрудников.Any(x => x.Item1) объект.ТаблицаПерсонал.FindRow(new NsgCompare()
            //            .Add(МониторингОбъектыТаблицаПерсонал.Names.Сотрудник, сотрудник)) == null)
            //        {
            //            var persRow = объект.ТаблицаПерсонал.NewRow();
            //            persRow.Сотрудник = сотрудник;
            //            persRow.Post();
            //        }

            //        var tarRow = объект.ТаблицаТарифыСотрудников.FindRow(new NsgCompare()
            //            .Add(МониторингОбъектыТаблицаТарифыСотрудников.Names.Тариф, тариф));
            //        if (tarRow == null)
            //        {
            //            tarRow = объект.ТаблицаТарифыСотрудников.NewRow();
            //            tarRow.Тариф = тариф;
            //        }
            //        else tarRow.Edit();
            //        tarRow.Стоимость = sum;
            //        tarRow.Post();
            //    }

            //    объект.Post();
            //}
        }

        private void bСохранитьТарифыВОбъектах_AsyncClickCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NsgTracer.WriteInfo("Загрузка из JSON - тарифы в объектах, окончание");
        }

        #endregion

        #region классы

        public static class Служебные
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

                public Guid Id { get; set; }

                public string Name { get; set; }

                public string Address { get; set; }

                public string Dogovor { get; set; }

                public Guid Zakazchik { get; set; }

                public Guid Firma { get; set; }
            }
            public class Контрагент
            {
                public override string ToString()
                {
                    return Name;
                }

                public Guid Id { get; set; }

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

                public Guid Id { get; set; }

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
                    return $"{WorkObject} {Sotrudnik} {Tariff} {Sum}";
                }

                public Guid Id { get; set; }

                public Guid Sotrudnik { get; set; }

                public Guid WorkObject { get; set; }

                public string Tariff { get; set; }

                public decimal Sum { get; set; }
            }
        }
        #endregion

    }



}