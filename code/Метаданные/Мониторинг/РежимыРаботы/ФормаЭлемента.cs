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
        public string СокращенныеДниНедели(string деньНеделиПолный)
        {
            switch (деньНеделиПолный)
            {
                case "Понедельник":
                    return "Пн";
                case "Вторник":
                    return "Вт";
                case "Среда":
                    return "Ср";
                case "Четверг":
                    return "Чт";
                case "Пятница":
                    return "Пт";
                case "Суббота":
                    return "Сб";
                case "Воскресенье":
                    return "Вс";
                default:
                    return "Неизвестно";
            }
        }
        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {

            //var неделя = Мониторинг.ДеньНедели.ByDayOfWeek;

            //if (vmoТабличнаяЧасть.Data.DataTable != null)
            //{
            //    vmoТабличнаяЧасть.Data.DataTable.CopyTo(vmoТаблицаРасписание.Data.MemoryTable);
            //}
            //else
            //{
            //    vmoТабличнаяЧасть.Data.BeginUpdateData();
            //    foreach (var day in неделя)
            //    {
            //        var row = vmoТабличнаяЧасть.Data.DataTable.NewRow();
            //        row[ДеньНедели].Value = day.Value;
            //        row.Post();
            //    }
            //    vmoТаблицаРасписание.Data.UpdateDataAsync(this);
            //}

            base.OnSetFormObject(formObject);
        }
        public override void OnDataLoaded()
        {
            if (FormObject.ObjectState != NsgObjectStates.New)
                ЗаполнитьШапку();

            base.OnDataLoaded();
        }
        private void nsgButton3_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьШапку();
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            vmoТабличнаяЧасть.Data.BeginUpdateData();
            foreach (var строка in vmoТабличнаяЧасть.Data.DataTable.Rows)
            {
                строка[ВремяНачалаРабочегоДня].Value = выбраннаяСтрока[ВремяНачалаРабочегоДня].Value;
                строка[ВремяКонцаРабочегоДня].Value = выбраннаяСтрока[ВремяКонцаРабочегоДня].Value;
                строка[ВремяНачалаПерерыва].Value = выбраннаяСтрока[ВремяНачалаПерерыва].Value;
                строка[ВремяКонцаПерерыва].Value = выбраннаяСтрока[ВремяКонцаПерерыва].Value;
                строка[ВремяНачалаСмены1].Value = выбраннаяСтрока[ВремяНачалаСмены1].Value;
                строка[ВремяОкончанияСмены1].Value = выбраннаяСтрока[ВремяОкончанияСмены1].Value;
                строка[ВремяНачалаСмены2].Value = выбраннаяСтрока[ВремяНачалаСмены2].Value;
                строка[ВремяОкончанияСмены2].Value = выбраннаяСтрока[ВремяОкончанияСмены2].Value;
                строка[ВремяНачалаСмены3].Value = выбраннаяСтрока[ВремяНачалаСмены3].Value;
                строка[ВремяОкончанияСмены3].Value = выбраннаяСтрока[ВремяОкончанияСмены3].Value;
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
            var row = vmoТабличнаяЧасть.Data.DataTable.Rows[номерСтроки];
            row[ВремяНачалаРабочегоДня].Value = null;
            row[ВремяКонцаРабочегоДня].Value = null;
            row[ВремяНачалаПерерыва].Value = null;
            row[ВремяКонцаПерерыва].Value = null;
            row[ВремяНачалаСмены1].Value = null;
            row[ВремяОкончанияСмены1].Value = null;
            row[ВремяНачалаСмены2].Value = null;
            row[ВремяОкончанияСмены2].Value = null;
            row[ВремяНачалаСмены3].Value = null;
            row[ВремяОкончанияСмены3].Value = null;
            vmoТабличнаяЧасть.Data.UpdateDataAsync(this);
        }

        private void ЗаполнитьШапку()
        {
            var дниНеделиРабочие = new Dictionary<string, List<string>>();
            var дниНеделиСокращенные = new Dictionary<string, List<string>>();
            var дниНеделиВыходной = new List<string>();
            var период = string.Empty;
            var периодСокращенный = string.Empty;
            bool firstWork = true;
            bool firstAbbreviated = true;
            var listWork = new List<string>();
            var listAbbreviated = new List<string>();

            var rows = (FormObject as РежимыРаботы).ТаблицаГрафик.Rows;
            for (var i = 0; i < rows.Length; i++)
            {
                var деньСокр = СокращенныеДниНедели(rows[i][ДеньНедели].ToString());
                var времяНачалаРаботы = (DateTime)rows[i][ВремяНачалаРабочегоДня].Value;
                var времяОкончанияРаботы = (DateTime)rows[i][ВремяКонцаРабочегоДня].Value;
                var периодРаботы = времяНачалаРаботы.Hour.ToString() + ":" + времяНачалаРаботы.Minute.ToString() + "-" + времяОкончанияРаботы.Hour.ToString() + ":" + времяОкончанияРаботы.Minute.ToString();
                if (!дниНеделиРабочие.ContainsKey(периодРаботы) && firstWork)
                {
                    период = периодРаботы;
                    listWork.Add(деньСокр);
                    дниНеделиРабочие.Add(периодРаботы, listWork);
                    firstWork = false;
                }
                else if (дниНеделиРабочие.ContainsKey(периодРаботы) && !firstWork)
                {
                    listWork.Add(деньСокр);
                    дниНеделиРабочие[периодРаботы] = listWork;
                }
                else if (!дниНеделиСокращенные.ContainsKey(периодРаботы) && firstAbbreviated)
                {
                    периодСокращенный = периодРаботы;
                    listAbbreviated.Add(деньСокр);
                    дниНеделиСокращенные.Add(периодРаботы, listAbbreviated);
                    firstAbbreviated = false;
                }
                else if (дниНеделиСокращенные.ContainsKey(периодРаботы) && !firstWork)
                {
                    listAbbreviated.Add(деньСокр);
                    дниНеделиСокращенные[периодРаботы] = listAbbreviated;
                }
                else
                {
                    дниНеделиВыходной.Add(деньСокр);
                }
            }

            vmoШапка.Data.BeginUpdateData();
            vmoШапка.Data.MemoryTable.Clear();
            vmoШапка.Data.CurrentRow = vmoШапка.Data.MemoryTable.NewRow();

            if (дниНеделиРабочие[период].Count > 1)
                ДниНеделиРабота_vmoШапка.Value = дниНеделиРабочие[период][0] + "-" + дниНеделиРабочие[период][дниНеделиРабочие[период].Count - 1];
            else
                ДниНеделиРабота_vmoШапка.Value = дниНеделиРабочие[период][0];

            if (дниНеделиВыходной.Count > 1)
                ДниНеделиВыходные_vmoШапка.Value = дниНеделиВыходной[0] + "-" + дниНеделиВыходной[дниНеделиВыходной.Count - 1];
            else
                ДниНеделиВыходные_vmoШапка.Value = дниНеделиВыходной[0];

            if (дниНеделиСокращенные[периодСокращенный].Count > 1)
                ДниНеделиУкорочен_vmoШапка.Value = дниНеделиСокращенные[периодСокращенный][0] + "-" + дниНеделиСокращенные[периодСокращенный][дниНеделиСокращенные[периодСокращенный].Count - 1];
            else if (дниНеделиСокращенные.Count != 0)
                ДниНеделиУкорочен_vmoШапка.Value = дниНеделиСокращенные[периодСокращенный][0];

            ПериодРабота_vmoШапка.Value = период;
            ПериодУкорочен_vmoШапка.Value = периодСокращенный;

            vmoШапка.Data.UpdateDataAsync(this);
        }

        private void vmoТабличнаяЧасть_DataPosted(object sender, NsgClosingOperationEventArgs e)
        {

        }
    }
}