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
            nsgInput8_ValueChanged(nsgInput8, false);
        }

        private void nsgInput8_ValueChanged(object sender, bool init)
        {
            nsgIGrid1.Visible = bДобавить.Visible = bЗаполнитьПоОбъекту.Visible = ЭтоИтоговыйДокумент.Value;
        }

        private void bДобавить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var row = vmoТаблица.Data.DataTable.NewRow();
            row.CopyNotPredefinedFieldsFromObject(this.FormObject);
            row.Post();
            vmoТаблица.Data.UpdateDataAsync(this);
        }

        private void bЗаполнитьПоОбъекту_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (Объект.Selected)
            {
                var списокТехники = Объект.Value.СписокТехникиОбъекта();
                foreach (var i in списокТехники)
                {
                    if (vmoТаблица.Data.DataTable.FindRow(new NsgCompare().Add(Заправка.Names.Техника, i)) == null)
                    {
                        var row = vmoТаблица.Data.DataTable.NewRow();
                        row[Заправка.Names.Объект].Value = Объект.Value;
                        row[Заправка.Names.Техника].Value = i;
                        row.Post();
                    }
                }
                vmoТаблица.Data.UpdateDataAsync(this);
            }
        }
    }
    


}