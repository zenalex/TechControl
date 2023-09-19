using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;

namespace TechControl.Метаданные.Учет
{
    
    public partial class ПриходнаяНакладнаяФормаЭлемента

    {
        public ПриходнаяНакладнаяФормаЭлемента()
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

        private void nbФормированиеЦены_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (FormObject != null && FormObject is ПриходнаяНакладная накладная)
            {
                var cmp = new NsgCompare();
                cmp.Add(ФормированиеЦены.Names.ДокументОснование, FormObject);
                cmp.Add(ФормированиеЦены.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var формирование = ФормированиеЦены.Новый();
                if (формирование.Find(cmp))
                {
                    формирование.New();
                    формирование.ДокументОснование = накладная;
                    формирование.Поставщик = накладная.Контрагент;

                    foreach (var item in накладная.Таблица.AllRows)
                    {
                        var row = формирование.Таблица.NewRow();
                        row.Номенклатура = item.Номенклатура;
                        row.Размер = item.Размер;
                        row.ТипЦены = ТипыЦен.ПриходнаяЦена;
                        row.Цена = item.Цена;
                        row.Post();
                    }
                    формирование.Post();
                }
                NsgSettings.MainForm.ShowObject(формирование, this );
            }
        }

    }
    


}