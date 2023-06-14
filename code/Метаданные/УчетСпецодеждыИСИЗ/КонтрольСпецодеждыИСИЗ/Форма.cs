using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class КонтрольСпецодеждыИСИЗФорма

    {
        public КонтрольСпецодеждыИСИЗФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (vmoСписокСпецодежды.Data.CurrentRow == null)
            {
                vmoСписокСпецодежды.Data.CurrentRow = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
            }
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            //base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            //base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void nbЗаполнить_AsyncClick(object sender, DoWorkEventArgs e)
        {
            ЗаполнитьТаблицуСпецодежды();
        }

        private void ЗаполнитьТаблицуСпецодежды() 
        {
            vmoСписокСпецодежды.Data.BeginUpdateData();
            vmoСписокСпецодежды.Data.MemoryTable.Clear();
            var сотрудник = Сотрудник.Value;
            if (!сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                vmoСписокСпецодежды.Data.UpdateDataSync(this);
                return;
            }

            УчетСпецодеждыИСИЗ рег = УчетСпецодеждыИСИЗ.Новый();
            рег.Сотрудник = сотрудник;
            var остатки = рег.GetRests();

            foreach (var комплект in сотрудник.Должность.ТаблицаКомплектовСпецодежды.AllRows)
            {
                foreach (var строкаСпецодежды in комплект.КомплектСпецодежды.ТаблицаКомплектаСпецодежды.AllRows)
                {
                    var nom = строкаСпецодежды.НоменклатураСпецодеждыИСИЗ;
                    var компл = комплект.КомплектСпецодежды;

                    var row = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
                    row[Номенклатура_vmoСписокСпецодежды].Value = nom;
                    row[Комплект_vmoСписокСпецодежды].Value = компл;
                    row[РазмерКВыдаче_vmoСписокСпецодежды].Value = сотрудник.РазмерНоменклатуры(nom);

                    if (остатки.AllRows.Any(x => (x[УчетСпецодеждыИСИЗ.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                        && (x[УчетСпецодеждыИСИЗ.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                    {
                        var ужеВыдано = 0;
                        var всегоЗаконченСрок = 0;
                        foreach (var item in остатки.AllRows.Where(x => (x[УчетСпецодеждыИСИЗ.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура) == nom
                        && (x[УчетСпецодеждыИСИЗ.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды) == компл))
                        {
                            ужеВыдано++;
                            if (nom.СрокЭксплуатации != 0 && item[УчетСпецодеждыИСИЗ.Names.ДатаВыдачи].ToDateTime().AddMonths((int)nom.СрокЭксплуатации) > DateTime.Now)
                            {
                                всегоЗаконченСрок++;
                            }
                            if (!(row[РазмерВыданных_vmoСписокСпецодежды].ToReferent() as Размеры).Selected)
                            {
                                row[РазмерВыданных_vmoСписокСпецодежды].Value = item[УчетСпецодеждыИСИЗ.Names.Размер].ToReferent() as Размеры;
                            }
                            остатки.DeleteRow(item);
                        }

                        row[ВсегоВыдано_vmoСписокСпецодежды].Value = ужеВыдано;
                        row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;
                    }

                    row.Post();
                }
            }

            foreach (var строкаОстатков in остатки.AllRows)
            {
                var nom = строкаОстатков[УчетСпецодеждыИСИЗ.Names.НоменклатураСпецодеждыИСИЗ].ToReferent() as Номенклатура;
                var компл = строкаОстатков[УчетСпецодеждыИСИЗ.Names.КомплектСпецодежды].ToReferent() as КомплектыСпецодежды;

                var row = vmoСписокСпецодежды.Data.MemoryTable.NewRow();
                row[Номенклатура_vmoСписокСпецодежды].Value = nom;
                row[Комплект_vmoСписокСпецодежды].Value = компл;

                var ужеВыдано = 0;
                var всегоЗаконченСрок = 0;
                ужеВыдано++;
                if (nom.СрокЭксплуатации != 0 && строкаОстатков[УчетСпецодеждыИСИЗ.Names.ДатаВыдачи].ToDateTime().AddMonths((int)nom.СрокЭксплуатации) > DateTime.Now)
                {
                    всегоЗаконченСрок++;
                }

                row[ВсегоВыдано_vmoСписокСпецодежды].Value = ужеВыдано;
                row[ВсегоЗаконченСрок_vmoСписокСпецодежды].Value = всегоЗаконченСрок;

                row.Post();
            }

            vmoСписокСпецодежды.Data.UpdateDataSync(this);
        }

        private void nbВыдать_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var сотрудник = Сотрудник.Value;
            if (!сотрудник.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите сотрудника");
                vmoСписокСпецодежды.Data.UpdateDataSync(this);
                return;
            }

            var перемещение = ПеремещениеСпецодежды.Новый();
            перемещение.Отправитель = Объекты.Новый();
            перемещение.Получатель = сотрудник;
            foreach (var item in vmoСписокСпецодежды.Data.MemoryTable.AllRows.Where(x => x[КВыдаче_vmoСписокСпецодежды].ToInt() > 0))
            {
                var строка = перемещение.Таблица.NewRow();
                строка.НоменклатураСпецодеждыИСИЗ = item[Номенклатура_vmoСписокСпецодежды].ToReferent() as Номенклатура;
                строка.КомплектСпецодежды = item[Комплект_vmoСписокСпецодежды].ToReferent() as КомплектыСпецодежды;
                строка.Размер = item[РазмерКВыдаче_vmoСписокСпецодежды].ToReferent() as Размеры;
                строка.Количество = item[КВыдаче_vmoСписокСпецодежды].ToInt();
                строка.Post();
            }
            //перемещение.Post();

            NsgSettings.MainForm.ShowObject(перемещение, this);

            ЗаполнитьТаблицуСпецодежды();
        }

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            ЗаполнитьТаблицуСпецодежды();
        }
    }
    


}