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
    
    public partial class РежимыРаботыФормаЭлемента

    {
        public РежимыРаботыФормаЭлемента()
        {
            InitializeComponent();
		}

        private NsgMultipleObject выбраннаяСтрока;
        private int номерСтроки;

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            var неделя = Мониторинг.ДеньНедели.ByDayOfWeek;
            
            if (vmoТабличнаяЧасть.Data.DataTable != null)
            {
                vmoТабличнаяЧасть.Data.DataTable.CopyTo(vmoТаблицаРасписание.Data.MemoryTable);
            }
            else
            {
                vmoТаблицаРасписание.Data.BeginUpdateData();
                foreach (var day in неделя)
                {
                    var row = vmoТаблицаРасписание.Data.MemoryTable.NewRow();
                    row[ДеньНедели_vmoТаблицаРаспиание].Value = day.Value;
                    row.Post();
                }
                vmoТаблицаРасписание.Data.UpdateDataAsync(this);
            }

            base.OnSetFormObject(formObject);
        }

        private void nsgButton3_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (vmoТаблицаРасписание.Data.MemoryTable != null)
            {
                vmoТабличнаяЧасть.Data.BeginUpdateData();
                vmoТаблицаРасписание.Data.MemoryTable.CopyTo(vmoТабличнаяЧасть.Data.DataTable);
                vmoТабличнаяЧасть.Data.UpdateDataAsync(this);
            }
            else
                NsgSettings.MainForm.ShowMessage("Заполните данные в таблице");
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            vmoТабличнаяЧасть.Data.BeginUpdateData();
            foreach (var строка in vmoТаблицаРасписание.Data.MemoryTable.Rows)
            {
                строка[ВремяНачалаРабочегоДня_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяНачалаРабочегоДня_vmoТаблицаРасписание].Value;
                строка[ВремяОкончанияРабочегоДня_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяОкончанияРабочегоДня_vmoТаблицаРасписание].Value;
                строка[ВремяНачалаПерерыва_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяНачалаПерерыва_vmoТаблицаРасписание].Value;
                строка[ВремяОкончанияПерерыва_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяОкончанияПерерыва_vmoТаблицаРасписание].Value;
                строка[ВремяНачалаСмены1_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяНачалаСмены1_vmoТаблицаРасписание].Value;
                строка[ВремяОкончанияСмены1_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяОкончанияСмены1_vmoТаблицаРасписание].Value;
                строка[ВремяНачалаСмены2_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяНачалаСмены2_vmoТаблицаРасписание].Value;
                строка[ВремяОкончанияСмены2_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяОкончанияСмены2_vmoТаблицаРасписание].Value;
                строка[ВремяНачалаСмены3_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяНачалаСмены3_vmoТаблицаРасписание].Value;
                строка[ВремяОкончанияСмены3_vmoТаблицаРасписание].Value = выбраннаяСтрока[ВремяОкончанияСмены3_vmoТаблицаРасписание].Value;
            }
            vmoТабличнаяЧасть.Data.UpdateDataAsync(this);
        }

        private void nsgIGrid1_RowEnter(object sender, NsgIGrid.NsgIGridRowEventArgs e)
        {
            выбраннаяСтрока = e.RowObject;
            номерСтроки = e.RowIndex;
        }

        private void nsgButton2_AsyncClick(object sender, DoWorkEventArgs e)
        {
            vmoТабличнаяЧасть.Data.BeginUpdateData();
            var row = vmoТаблицаРасписание.Data.MemoryTable.Rows[номерСтроки];
            row[ВремяНачалаРабочегоДня_vmoТаблицаРасписание].Value = null;
            row[ВремяОкончанияРабочегоДня_vmoТаблицаРасписание].Value = null;
            row[ВремяНачалаПерерыва_vmoТаблицаРасписание].Value = null;
            row[ВремяОкончанияПерерыва_vmoТаблицаРасписание].Value = null;
            row[ВремяНачалаСмены1_vmoТаблицаРасписание].Value = null;
            row[ВремяОкончанияСмены1_vmoТаблицаРасписание].Value = null;
            row[ВремяНачалаСмены2_vmoТаблицаРасписание].Value = null;
            row[ВремяОкончанияСмены2_vmoТаблицаРасписание].Value = null;
            row[ВремяНачалаСмены3_vmoТаблицаРасписание].Value = null;
            row[ВремяОкончанияСмены3_vmoТаблицаРасписание].Value = null;
            vmoТабличнаяЧасть.Data.UpdateDataAsync(this);
        }
    }
}