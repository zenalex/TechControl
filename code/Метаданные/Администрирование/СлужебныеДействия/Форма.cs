using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            cmp.Add(ФизЛица.Names.ЗагрузочныйИдентификатор, string.Empty, NsgComparison.NotEqual);

            var всеСотрудники = ФизЛица.Новый().FindAll(cmp);
            foreach (var item in всеСотрудники)
            {
                NsgSettings.MainForm.ShowMessage($"Удаляется {item}");
                item.Delete();
            }
        }

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmp = new NsgCompare();
            cmp.Add(ФизЛица.Names.ЗагрузочныйИдентификатор, string.Empty, NsgComparison.NotEqual);

            var всеСотрудники = ФизЛица.Новый().FindAll(cmp);

            var всеПодразделения = всеСотрудники.Where(x => x.Подразделение.Selected).Select(x => x.Подразделение).ToArray();

            Dictionary<string, Подразделения> словарьПодразделений = new Dictionary<string, Подразделения>();
            foreach (var подразделение in всеПодразделения)
            {
                if (!словарьПодразделений.ContainsKey(подразделение.ЗагрузочныйИдентификатор))
                {
                    словарьПодразделений[подразделение.ЗагрузочныйИдентификатор] = подразделение;
                }
            }


            foreach (var item in всеСотрудники)
            {
                foreach (var загрИдент in словарьПодразделений.Keys)
                {
                    if (item.Подразделение.ЗагрузочныйИдентификатор == загрИдент && item.Подразделение != словарьПодразделений[загрИдент])
                    {
                        item.Edit();
                        item.Подразделение = словарьПодразделений[загрИдент];
                        item.Post();
                        NsgSettings.MainForm.ShowMessage($"обработан {item}");
                    }
                }
                
            }

            List<Guid> гуидыПодразделений = new List<Guid>();
            

            var cmpПодр = new NsgCompare();

            var подразделения = Подразделения.Новый().FindAll(cmpПодр);
            гуидыПодразделений = подразделения.Select(x => x.Идентификатор).ToList();

            foreach (var подразделение in подразделения)
            {
                foreach (var загрИдент in словарьПодразделений.Keys)
                {
                    if (подразделение.ЗагрузочныйИдентификатор == загрИдент)
                    {
                        if (подразделение.Идентификатор != словарьПодразделений[загрИдент].Идентификатор)
                        {
                            подразделение.Delete();
                            NsgSettings.MainForm.ShowMessage($"Удаляется {подразделение}");
                        }
                    }
                }
            }
        }
    }
    


}