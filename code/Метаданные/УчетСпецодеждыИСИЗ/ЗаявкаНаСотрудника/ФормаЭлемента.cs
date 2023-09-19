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
    
    public partial class ЗаявкаНаСотрудникаФормаЭлемента

    {
        public ЗаявкаНаСотрудникаФормаЭлемента()
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
            if (FormObject != null && FormObject is ЗаявкаНаСотрудника заявка && заявка.Selected)
            {
                try
                {
                    var доки = заявка.ЗавершитьЗаявку(Дата_vmoДопДанные.Value);
                    NsgSettings.MainForm.ShowObject(доки.Item1, this);
                    NsgSettings.MainForm.ShowObject(доки.Item2, this);
                }
                catch (Exception ee)
                {
                    NsgSettings.MainForm.ShowMessage(ee.Message);

                }
            }
        }

        private void nbОтменить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject != null && FormObject is ЗаявкаНаСотрудника заявка && заявка.Selected)
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