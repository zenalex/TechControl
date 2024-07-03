using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;





namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФизЛицаФормаЭлемента

    {
        public ФизЛицаФормаЭлемента()
        {
            InitializeComponent();
		}
        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                var мерка = (formObject as ФизЛица).ПолучитьМерку(true);
                vmoМерки.Data.CurrentRow = мерка;
            }
        }

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Размер_vmoТаблицаРазмеров.Name)
            {
                var вид = e.RowObject[ВидСвойствНоменклатуры].ToReferent() as ВидСвойствНоменклатуры;
                if (!вид.Selected)
                {
                    NsgSettings.MainForm.ShowMessage("Необходимо выбрать вид номенклатуры");
                    e.Cancel = true;
                    return;
                }
                else
                {
                    var cmp = Размер_vmoТаблицаРазмеров.SearchCondition;
                    cmp.Clear();
                    cmp.Add(Размеры.Names.ВидСвойствНоменклатуры, вид);
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpМерки)
            {
                vmoМерки.Data.BeginUpdateData();

                vmoМерки.Data.UpdateDataSync(this);
            }

            if (tabControl1.SelectedTab == tpМатЦенности)
            {
                ЗаполнитьТаблицуМатЦенностей();
            }
        }

        private void nbЗаполнитьТаблицуРазмеров_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject != null)
            {
                vmoТаблицаРазмеров.Data.BeginUpdateData();

                var сотрудник = FormObject as ФизЛица;
                сотрудник.ЗаполнитьТаблицуРазмеров();

                vmoТаблицаРазмеров.Data.UpdateDataSync(this);
            }
        }

        private void nsgIGrid3_GetAvailableTools(object sender, ref NsgSoft.Common.NsgWorkPanelTools tools)
        {
            tools = NsgSoft.Common.NsgWorkPanelTools.Settings;
        }

        private void ЗаполнитьТаблицуМатЦенностей()
        {
            if (FormObject != null && FormObject is ФизЛица сотрудник)
            {
                vmoМатЦенности.Data.BeginUpdateData();
                vmoМатЦенности.Data.MemoryTable.Clear();

                var рег = РегистрУчетСпецодежды.Новый();
                рег.Сотрудник = сотрудник;
                var остатки = рег.GetRests();

                foreach (var item in остатки.AllRows)
                {
                    var row = vmoМатЦенности.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoМатЦенности].Value = item[РегистрУчетСпецодежды.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                    row[Комплект_vmoМатЦенности].Value = item[РегистрУчетСпецодежды.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;
                    row[Размер_vmoМатЦенности].Value = item[РегистрУчетСпецодежды.Names.Размер].ToReferent() as Размеры;
                    row[Количество_vmoМатЦенности].Value = 1;
                    row.Post();
                }

                var списокКоллапса = new string[]
                {
                    Номенклатура_vmoМатЦенности.Name,
                    Комплект_vmoМатЦенности.Name,
                    Размер_vmoМатЦенности.Name
                };

                var списокСуммирования = new string[]
                {
                    Количество_vmoМатЦенности.Name
                };

                vmoМатЦенности.Data.MemoryTable.Collapse(списокКоллапса, списокСуммирования, false);

                vmoМатЦенности.Data.UpdateDataSync(this);
            }
        }

    }
    


}