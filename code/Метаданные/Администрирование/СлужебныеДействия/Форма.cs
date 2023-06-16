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

namespace TechControl.Метаданные.Администрирование
{
    
    public partial class СлужебныеДействияФорма

    {
        public СлужебныеДействияФорма()
        {
            InitializeComponent();
		}

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void nbУдалениеЛишнихДолжностей_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmp = new NsgCompare();
            cmp.Add(Должности.Names.РежимРаботы, РежимыРаботы.Новый());
            cmp.Add(Должности.Names.Описание, string.Empty);
            cmp.Add(Должности.Names.ГруппаДолжностей, ГруппыДолжностей.Новый());

            var всеДолжности = Должности.Новый().FindAll(cmp);
            foreach (var item in всеДолжности)
            {
                NsgSettings.MainForm.ShowMessage($"Удаляется {item}");
                item.Delete();
            }
        }

        private void nbУдалениеСотрудников_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmp = new NsgCompare();
            cmp.Add(Сотрудники.Names.ЗагрузочныйИдентификатор, string.Empty, NsgComparison.NotEqual);

            var всеСотрудники = Сотрудники.Новый().FindAll(cmp);
            foreach (var item in всеСотрудники)
            {
                NsgSettings.MainForm.ShowMessage($"Удаляется {item}");
                item.Delete();
            }
        }
    }
    


}