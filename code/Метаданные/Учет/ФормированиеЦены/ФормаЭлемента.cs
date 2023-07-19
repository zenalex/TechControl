using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace TechControl.Метаданные.Учет
{
    
    public partial class ФормированиеЦеныФормаЭлемента

    {
        public ФормированиеЦеныФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            if (vmoДопДанные.Data.CurrentRow == null)
            {
                vmoДопДанные.Data.CurrentRow = vmoДопДанные.Data.MemoryTable.NewRow();
            }
            base.OnSetFormObject(formObject);
        }

        private void nbТипЦены_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (!ТипЦены_vmoДопДанные.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Необходимо указать тип цены");
                return;
            }

            vmoТаблица.Data.BeginUpdateData();
            foreach (var item in vmoТаблица.Data.DataTable.AllRows)
            {
                item[ТипЦены.Name].Value = ТипЦены_vmoДопДанные.Value;
            }
            vmoТаблица.Data.UpdateDataSync(this);
        }
    }
    


}