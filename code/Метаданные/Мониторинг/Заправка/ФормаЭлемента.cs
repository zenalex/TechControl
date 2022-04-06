using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ЗаправкаФормаЭлемента

    {
        public ЗаправкаФормаЭлемента()
        {
            InitializeComponent();
		}

        public override void OnDataLoaded()
        {
            base.OnDataLoaded();
            //if (FormObject.ObjectState == NsgObjectStates.New)
            //{
            //    ЭтоИтоговыйДокумент.Value = true;
            //}
        }

        private void nsgInput8_ValueChanged(object sender, bool init)
        {
            nsgIGrid1.Visible = bДобавить.Visible = ЭтоИтоговыйДокумент.Value;
        }

        private void bДобавить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var row = vmoТаблица.Data.DataTable.NewRow();
            row.CopyNotPredefinedFieldsFromObject(this.FormObject);
            row.Post();
            vmoТаблица.Data.UpdateDataAsync(this);
        }
    }
    


}