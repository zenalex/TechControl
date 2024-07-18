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
    
    public partial class ФотографииФормаСписка

    {
        public ФотографииФормаСписка()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectBaseForm

        private void nsgVisualMultipleObject_CurrentRowChanged(object sender, NsgMultipleObject oldRow, NsgMultipleObject newRow)
        {
            if (newRow != null && newRow is Фотографии фото)
            {
                pictureBox1.Image = фото.ПолучитьФото();
            }
        }
    }
    


}