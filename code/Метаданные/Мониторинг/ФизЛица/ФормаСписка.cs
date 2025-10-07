using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные._SystemTables;





namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ФизЛицаФормаСписка

    {
        public ФизЛицаФормаСписка()
        {
            InitializeComponent();
		}

        private NsgCompare _внешняяКомпара = null;

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            _внешняяКомпара = null;
            base.OnSetFormObject(formObject);
        }

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectBaseForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectBaseForm

        private void cbФильтр_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    


}