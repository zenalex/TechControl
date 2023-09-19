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
    
    public partial class РазмерыФормаЭлемента

    {
        public РазмерыФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (vmoДляКопирования.Data.CurrentRow == null)
            {
                vmoДляКопирования.Data.CurrentRow = vmoДляКопирования.Data.MemoryTable.NewRow();
            }
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (!РазмерДляКопии.Value.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не выбран шаблон для копирования");
                return;
            }
            else
            {
                var размер = РазмерДляКопии.Value;
                ВидСвойствНоменклатуры.Value = размер.ВидСвойствНоменклатуры;
                ВидРазмернойСетки.Value = размер.ВидРазмернойСетки;

                РостМакс.Value = размер.РостМакс;
                РостМин.Value = размер.РостМин;

                ОбхватГрудиМакс.Value = размер.ОбхватГрудиМакс;
                ОбхватГрудиМин.Value = размер.ОбхватГрудиМин;

                ОбхватТалииМакс.Value = размер.ОбхватТалииМакс;
                ОбхватТалииМин.Value = размер.ОбхватТалииМин;

                ОбхватБедерМакс.Value = размер.ОбхватБедерМакс;
                ОбхватБедерМин.Value = размер.ОбхватБедерМин;

                БоковаяДлинаБрюкМакс.Value = размер.БоковаяДлинаБрюкМакс;
                БоковаяДлинаБрюкМин.Value = размер.БоковаяДлинаБрюкМин;

                ВнутренняяДлинаБрюкМакс.Value = размер.ВнутренняяДлинаБрюкМакс;
                ВнутренняяДлинаБрюкМин.Value = размер.ВнутренняяДлинаБрюкМин;

                ОбхватШеиМакс.Value = размер.ОбхватШеиМакс;
                ОбхватШеиМин.Value = размер.ОбхватШеиМин;

                ДлинаРукаваМакс.Value = размер.ДлинаРукаваМакс;
                ДлинаРукаваМин.Value = размер.ДлинаРукаваМин;

                ДлинаСтупниМакс.Value = размер.ДлинаСтупниМакс;
                ДлинаСтупниМин.Value = размер.ДлинаСтупниМин;
            }
        }
    }
    


}