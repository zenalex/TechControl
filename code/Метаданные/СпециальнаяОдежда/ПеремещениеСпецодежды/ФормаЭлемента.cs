using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace TechControl.Метаданные.СпециальнаяОдежда
{
    
    public partial class ПеремещениеСпецодеждыФормаЭлемента

    {
        public ПеремещениеСпецодеждыФормаЭлемента()
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

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName.Contains("Размер"))
            {
                Размер.SearchCondition.Clear();
                if (Спецодежда != null)
                {
                    Размер.SearchCondition.Add(Размеры.Names.ВидСпецодежды, Спецодежда.Value.ВидСпецодежды);
                }                    
            }
        }

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName.Contains("Цена"))
            {
                if (Количество.Value != 0)
                {
                    Стоимость.Value = Цена.Value * Количество.Value;
                }
            }
            else if (e.ColumnName.Contains("Стоимость"))
            {
                if (Количество.Value != 0)
                {
                    Цена.Value = Стоимость.Value / Количество.Value;
                }
            }
            else if (e.ColumnName.Contains("Количество"))
            {
                if (Стоимость.Value != 0 && Цена.Value == 0)
                {
                    Цена.Value = Стоимость.Value / Количество.Value;
                }
                else if (Цена.Value != 0 && Стоимость.Value == 0)
                {
                    Стоимость.Value = Цена.Value * Количество.Value;
                }    
            }
        }
    }
    


}