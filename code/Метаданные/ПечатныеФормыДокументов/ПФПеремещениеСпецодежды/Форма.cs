using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.ПечатныеФормыДокументов
{
    
    public partial class ПФПеремещениеСпецодеждыФорма

    {
        public ПФПеремещениеСпецодеждыФорма()
        {
            InitializeComponent();
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
            vmoТабличныеДанные.Data.BeginUpdateData();
            vmoТабличныеДанные.Data.MemoryTable.Clear();
            Dictionary<Номенклатура, decimal> списокНоменклатурыИСтоимости = new Dictionary<Номенклатура, decimal>();
            foreach (var item in Таблица.Value.AllRows)
            {
                var row = vmoТабличныеДанные.Data.MemoryTable.NewRow();
                row[Номенклатура_vmoТабличныеДанные].Value = item.НоменклатураСпецодеждыИСИЗ;
                row[Комплект_vmoТабличныеДанные].Value = item.КомплектСпецодежды;
                row[Размер_vmoТабличныеДанные].Value = item.Размер;
                row[Количество_vmoТабличныеДанные].Value = item.Количество;
                row[Цена_vmoТабличныеДанные].Value = item.Цена;
                row[Стоимость_vmoТабличныеДанные].Value = item.Стоимость;
                row.Post();
                списокНоменклатурыИСтоимости.Add(item.НоменклатураСпецодеждыИСИЗ, item.Стоимость);
            }

            var списокПлановАмортизации = списокНоменклатурыИСтоимости.Keys
                .Select(x => x.ПланАмортизации)
                .Where(x => x.КоличествоПериодов != 0)
                .ToArray();

            if (списокПлановАмортизации.Length > 0)
            {
                var списокПлановАмортизацииОтсортированный = списокПлановАмортизации
                .OrderBy(x => x.СрокАмортизацииМес / x.КоличествоПериодов)
                .ToArray();

                var списокПериодовАмортизации = списокПлановАмортизацииОтсортированный
                    .Select(x => x.СрокАмортизацииМес / x.КоличествоПериодов)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                var планАмортизацииСМинимельнымПериодом = списокПлановАмортизацииОтсортированный.First();
                var минимальныйПериод = списокПериодовАмортизации.First();

                var максСрокАмортизации = списокПлановАмортизации.OrderByDescending(x => x.СрокАмортизацииМес).First().СрокАмортизацииМес;

                var датаНачалаЭксплуатации = ДатаНачалаЭксплуатации.Value != NsgService.MinDate ? ДатаНачалаЭксплуатации.Value.Date : ДатаДокумента.Value.Date;
                var датаОкончанияЭксплуатации = датаНачалаЭксплуатации.AddMonths((int)максСрокАмортизации);

                var текущаяДата = датаНачалаЭксплуатации;

                while (текущаяДата <= датаОкончанияЭксплуатации)
                {
                    var имяКолонки = $"c {текущаяДата:d} по {текущаяДата.AddMonths((int)минимальныйПериод):d}";
                    vmoТабличныеДанные.Data.MemoryTable.AddColumn(имяКолонки, typeof(decimal));
                    foreach (var row in vmoТабличныеДанные.Data.MemoryTable.AllRows)
                    {
                        var номенклатура = row[Номенклатура_vmoТабличныеДанные].ToReferent() as Номенклатура;
                        if (номенклатура.ПланАмортизации.КоличествоПериодов != 0)
                        {
                            row[имяКолонки].Value = номенклатура.СтоимостьСУчетомАмортизацииНаДату(текущаяДата, датаНачалаЭксплуатации);
                        }
                    }

                    if (списокНоменклатурыИСтоимости.Keys
                        .Where(x => минимальныйПериод == x.ПланАмортизации.СрокАмортизацииМес / x.ПланАмортизации.КоличествоПериодов 
                        && датаНачалаЭксплуатации.AddMonths((int)x.ПланАмортизации.СрокАмортизацииМес) > текущаяДата)
                        .ToArray()
                        .Length == 0)
                    {
                        if (списокПериодовАмортизации.Count > 1)
                        {
                            списокПериодовАмортизации.Remove(минимальныйПериод);
                            минимальныйПериод = списокПериодовАмортизации.First();
                        }
                    }

                    текущаяДата = текущаяДата.AddMonths((int)минимальныйПериод);
                }
            }

            vmoТабличныеДанные.Data.UpdateDataSync(this);
        }
        
	}
    


}