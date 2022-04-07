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
    
    public partial class ОбъектыФормаЭлемента

    {
        public ОбъектыФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void nsgIGridТарифыТехники_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Тариф.Name && e.RowObject[Стоимость].ToDecimal() == 0)
            {
                e.RowObject[Стоимость].Value = (e.CellObject.ToReferent() as Тарифы).Стоимость;
            }
        }

        private void nsgIGridТарифыПерсонала_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Тариф_vmoТарифыПерсонал.Name && e.RowObject[Стоимость_vmoТарифыПерсонал].ToDecimal() == 0)
            {
                e.RowObject[Стоимость_vmoТарифыПерсонал].Value = (e.CellObject.ToReferent() as Тарифы).Стоимость;
            }
        }
    }
    


}