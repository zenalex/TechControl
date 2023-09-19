using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class ЗаявкиПоставщикамФормаЭлемента

    {
        public ЗаявкиПоставщикамФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                if (vmoДопДанные.Data.CurrentRow == null)
                {
                    vmoДопДанные.Data.CurrentRow = vmoДопДанные.Data.MemoryTable.NewRow();
                }
            }
        }

        private void nbЗавершить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject != null && FormObject is ЗаявкиПоставщикам заявка && заявка.Selected)
            {
                try
                {
                    var док = заявка.ЗавершитьЗаявку(Дата_vmoДопДанные.Value);
                    NsgSettings.MainForm.ShowObject(док, this);
                }
                catch (Exception ee)
                {
                    NsgSettings.MainForm.ShowMessage(ee.Message);

                }
            }
        }

        private void nbОтменить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject != null && FormObject is ЗаявкиПоставщикам заявка && заявка.Selected)
            {
                try
                {
                    заявка.Отменить(Дата_vmoДопДанные.Value);
                }
                catch (Exception ee)
                {
                    NsgSettings.MainForm.ShowMessage(ee.Message);

                }
            }
        }
    }
    


}