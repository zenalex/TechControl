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

namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class СотрудникиФормаЭлемента

    {
        public СотрудникиФормаЭлемента()
        {
            InitializeComponent();
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
    }
    


}