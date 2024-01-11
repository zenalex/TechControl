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
using TechControl.Метаданные.Мониторинг;





namespace TechControl.Метаданные.Документы
{
    
    public partial class ОтработанныеМесяцыФормаЭлемента

    {
        public ОтработанныеМесяцыФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                bgwЗаполнениеДанныхПоГрафику.Run();
            }
        }

        private void nbАнализ_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьГрафик();

            СравнитьСГрафиком();
        }

        private void bgwЗаполнениеДанныхПоГрафику_DoWork(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьГрафик();
        }

        private void ЗаполнитьГрафик() 
        {
            var объект = Объект.Value;
            var месяцИтогов = МесяцИтогов.Value.Date;

            vmoДанныеГрафика.Data.BeginUpdateData();
            vmoДанныеГрафика.Data.MemoryTable.Clear();

            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            for (int i = 1; i <= всегоДней; i++)
            {
                var дата = new DateTime(месяцИтогов.Year, месяцИтогов.Month, i);

                var графикРаботыОбъекта = объект.ДействующийНаДатуГрафикРаботы(дата);
                if (графикРаботыОбъекта.Selected)
                {
                    var параметры = графикРаботыОбъекта.ПараметрыВыходаНАСменуНаДату(дата);
                    foreach (var item in параметры)
                    {
                        if (item.Value.Item1 && (item.Key.Item2.Selected || item.Key.Item3.Selected))
                        {
                            var количество = item.Key.Item4 == 0 ? 1 : item.Key.Item4;

                            var строки = vmoДанныеГрафика.Data.MemoryTable
                                .FindRows(new NsgCompare()
                                .Add(КодГруппы_vmoДанныеГрафика.Name, item.Key.Item1)
                                .Add(ГруппаСпТехн_vmoДанныеГрафика.Name, item.Key.Item3)
                                .Add(Должность_vmoДанныеГрафика.Name, item.Key.Item2)
                                .Add(КоличДляСравнения_vmoДанныеГрафика.Name, item.Key.Item4));

                            for (int j = 0; j < количество; j++)
                            {
                                var суммируемаяКолонка = i.ToString();
                                NsgMemoryTableRow row = null;
                                if (строки != null && строки.Length > 0 && строки.Length > j)
                                {
                                    row = строки[j];
                                    row[суммируемаяКолонка].Value = row[суммируемаяКолонка].ToDecimal() + item.Value.Item3;
                                }
                                else
                                {
                                    row = vmoДанныеГрафика.Data.MemoryTable.NewRow();
                                    row[суммируемаяКолонка].Value = item.Value.Item3;
                                    row[КодГруппы_vmoДанныеГрафика].Value = item.Key.Item1;
                                    row[ГруппаСпТехн_vmoДанныеГрафика].Value = item.Key.Item3;
                                    row[Должность_vmoДанныеГрафика].Value = item.Key.Item2;
                                    row[КоличДляСравнения_vmoДанныеГрафика].Value = item.Key.Item4;
                                    row.Post();
                                }
                            }
                        }
                    }
                }
            }
            vmoДанныеГрафика.Data.UpdateDataSync(this);
        }

        private void СравнитьСГрафиком() 
        {
            var месяцИтогов = МесяцИтогов.Value.Date;
            foreach (var item in vmoТаблица.Data.DataTable.AllRows)
            {
                var должность = item[Должность].ToReferent() as Должности;
                var группаСпТехники = item[ГруппаСпецТехники].ToReferent() as ГруппыСпецТехники;

                var строки = vmoДанныеГрафика.Data.MemoryTable
                                    .FindRows(new NsgCompare()
                                    .Add(ГруппаСпТехн_vmoДанныеГрафика.Name, группаСпТехники)
                                    .Add(Должность_vmoДанныеГрафика.Name, должность));
                if (строки != null && строки.Length > 0)
                {
                    item.ClearUserProperties();
                    var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
                    for (int i = 1; i <= всегоДней; i++)
                    {
                        var суммируемаяКолонка = "Д" + i.ToString();
                        var суммируемаяКолонкаГрафика = i.ToString();
                        var суммаЧасовПоГрафику = строки.Sum(x => x[суммируемаяКолонкаГрафика].ToDecimal());
                        var суммаЧасовЗаявленная = vmoТаблица.Data.DataTable.AllRows
                            .Where(x => (x[Должность].ToReferent() as Должности) == должность && (x[ГруппаСпецТехники].ToReferent() as ГруппыСпецТехники) == группаСпТехники)
                            .Sum(x => x[суммируемаяКолонка].ToDecimal());

                        item[суммируемаяКолонка].ClearUserProperties();

                        if (суммаЧасовПоГрафику < суммаЧасовЗаявленная)
                        {
                            item[суммируемаяКолонка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.MediumSpringGreen);
                        }
                        else if (суммаЧасовПоГрафику > суммаЧасовЗаявленная)
                        {
                            item[суммируемаяКолонка].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.LightSalmon);
                        }
                    }
                }
                else
                {
                    item[Должность].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Red);
                    item[ГруппаСпецТехники].AddUserProperty(NsgSoft.Forms.NsgIGrid.BACKCOLOR, Color.Red);
                    NsgSettings.MainForm.ShowMessage($"Для {должность} и {группаСпТехники} не найдено записей в графике");
                }
            }
        }

        private void bgwЗаполнениеДанныхПоГрафику_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            СравнитьСГрафиком();
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var именаКолонок = new List<string>();
            var месяцИтогов = МесяцИтогов.Value.Date;
            var всегоДней = NsgService.EndOfMonth(месяцИтогов).Day;
            for (int i = 1; i <= всегоДней; i++)
            {
                именаКолонок.Add("Д" + i.ToString());
            }

            if (именаКолонок.Contains(e.ColumnName))
            {
                СравнитьСГрафиком();
            }
        }
    }
    


}