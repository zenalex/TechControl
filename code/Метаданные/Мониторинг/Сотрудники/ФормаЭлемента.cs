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
    
    public partial class СотрудникиФормаЭлемента

    {
        public СотрудникиФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                НайтиИлиСоздатьМерку();
            }
        }

        private void НайтиИлиСоздатьМерку() 
        {
            //vmoМерки.Data.BeginUpdateData();
            var cmp = new NsgCompare();
            cmp.Add(Мерки.Names.Владелец, FormObject);
            var мерка = Мерки.Новый();
            if (!мерка.Find(cmp))
            {
                мерка.New();
            }
            else
            {
                мерка.Edit();
            }
            vmoМерки.Data.CurrentRow = мерка;
            //vmoМерки.Data.UpdateDataSync(this);
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
        }
    }
    


}