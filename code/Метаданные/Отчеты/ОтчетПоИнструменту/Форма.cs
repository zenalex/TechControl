using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные.УчетИнструмента;

namespace TechControl.Метаданные.Отчеты
{
    
    public partial class ОтчетПоИнструментуФорма

    {
        public ОтчетПоИнструментуФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (nsgVisualMultipleObject.Data.CurrentRow == null)
            {
                nsgVisualMultipleObject.Data.CurrentRow = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
            }

            if (vmoФильтр.Data.CurrentRow == null)
            {
                vmoФильтр.Data.CurrentRow = vmoФильтр.Data.MemoryTable.NewRow();
            }
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            ЗаполнитьДанные();
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void ЗаполнитьДанные() 
        {
            var cmp = new NsgCompare();
            var cmpFilter = nsgObjectFilter1.Compare;
            List<string> всеСерийники = new List<string>();
            if (!cmpFilter.IsEmpty)
            {
                cmp.Add(cmpFilter);
                var cmpСотрудник = nsgObjectFilter1.GetCompare(Сотрудник_vmoФильтр.Name);
                var cmpОбъекты = nsgObjectFilter1.GetCompare(Объект_vmoФильтр.Name);
                var cmpНоменклатура = nsgObjectFilter1.GetCompare(Номенклатура_vmoФильтр.Name);

                if (!cmpСотрудник.IsEmpty)
                {
                    var сотрудники = ФизЛица.Новый().FindAll(cmpСотрудник);
                    var серийникиПоСотруднику = УчетИнструментаРегистрУчетИнструментаДвижения
                        .Новый()
                        .FindAllRequisits(new NsgCompare()
                        .Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.Сотрудник, сотрудники, NsgSoft.Database.NsgComparison.In)
                        , УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер)
                        .AllRows
                        .Select(x => x[УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер].ToString())
                        .ToArray();
                    всеСерийники.AddRange(серийникиПоСотруднику);
                }

                if (!cmpОбъекты.IsEmpty)
                {
                    var объекты = Объекты.Новый().FindAll(cmpОбъекты);
                    var серийникиПоОбъектам = УчетИнструментаРегистрУчетИнструментаДвижения
                        .Новый()
                        .FindAllRequisits(new NsgCompare()
                        .Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.Объект, объекты, NsgSoft.Database.NsgComparison.In)
                        , УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер)
                        .AllRows
                        .Select(x => x[УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер].ToString())
                        .ToArray();
                    всеСерийники.AddRange(серийникиПоОбъектам);
                }

                if (!cmpНоменклатура.IsEmpty)
                {
                    var номенклатуры = Номенклатура.Новый().FindAll(cmpНоменклатура);
                    var серийникиПоНоменклатуре = УчетИнструментаРегистрУчетИнструментаДвижения
                        .Новый()
                        .FindAllRequisits(new NsgCompare()
                        .Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.НоменклатураИнструмента, номенклатуры, NsgSoft.Database.NsgComparison.In)
                        , УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер)
                        .AllRows
                        .Select(x => x[УчетИнструментаРегистрУчетИнструментаДвижения.Names.СерийныйНомер].ToString())
                        .ToArray();
                    всеСерийники.AddRange(серийникиПоНоменклатуре);
                }
            }

            if (всеСерийники.Count > 0)
            {
                cmp.Add(РегистрУчетИнструмента.Names.СерийныйНомер, всеСерийники.Distinct().ToArray(), NsgSoft.Database.NsgComparison.In);
            }

            var остатки = РегистрУчетИнструмента.Новый().GetRests(cmp);

            Dictionary<string, NsgMemoryTableRow> строкиПоследнегоСостояния = new Dictionary<string, NsgMemoryTableRow>();
            foreach (var item in остатки.AllRows)
            {
                var серийник = item[РегистрУчетИнструмента.Names.СерийныйНомер].ToString();
                if (строкиПоследнегоСостояния.ContainsKey(серийник))
                {
                    var датаТекущейСтроки = item[РегистрУчетИнструмента.Names.Дата].ToDateTime();
                    var датаСтрокиВСловаре = строкиПоследнегоСостояния[серийник][РегистрУчетИнструмента.Names.Дата].ToDateTime();
                    if (датаТекущейСтроки > датаСтрокиВСловаре)
                    {
                        строкиПоследнегоСостояния[серийник] = item;
                    }
                }
                else
                {
                    строкиПоследнегоСостояния[серийник] = item;
                }
            }
            vmoДанные.Data.BeginUpdateData();
            vmoДанные.Data.MemoryTable.Clear();

            foreach (var item in строкиПоследнегоСостояния)
            {
                var row = vmoДанные.Data.MemoryTable.NewRow();
                row[Номенклатура_vmoДанные].Value = item.Value[РегистрУчетИнструмента.Names.НоменклатураИнструмента].ToReferent() as Номенклатура;
                row[Объект_vmoДанные].Value = item.Value[РегистрУчетИнструмента.Names.Объект].ToReferent() as Объекты;
                row[Сотрудник_vmoДанные].Value = item.Value[РегистрУчетИнструмента.Names.Сотрудник].ToReferent() as ФизЛица;
                row[СерийныйНомер_vmoДанные].Value = item.Value[РегистрУчетИнструмента.Names.СерийныйНомер].ToString();
                row[Количество_vmoДанные].Value = 1;
                row.Post();
            }
            vmoДанные.Data.UpdateDataSync(this);
        }
	}
    


}