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
using TechControl.Метаданные.Регистры;





namespace TechControl.Метаданные.ПечатныеФормыДокументов
{
    
    public partial class ПФЭСМФорма

    {
        public ПФЭСМФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (vmoПодписант.Data.CurrentRow == null)
            {
                vmoПодписант.Data.CurrentRow = vmoПодписант.Data.MemoryTable.NewRow();
            }

            if (vmoДляРасчЗПМашинистов.Data.CurrentRow == null)
            {
                vmoДляРасчЗПМашинистов.Data.CurrentRow = vmoДляРасчЗПМашинистов.Data.MemoryTable.NewRow();
            }
        }
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            ЗаполнитьТаблицу();
            ЗаполнитьПодписантов();
            ЗаполнитьТаблицуРасчетаЗПМашиниста();
            base.OnCreateReport(nsgBackgroundReporter, e);
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private void ЗаполнитьПодписантов() 
        {
            if (!СотрудникПодписант.Value.Selected && !ДолжностьПодписанта.Value.Selected)
            {
                if (Объект.Value.Selected && Объект.Value.ДоговорСсылка.Selected && Объект.Value.ДоговорСсылка.СотрудникПодписант.Selected)
                {
                    Подписант_vmoПодписанты.Value = Объект.Value.ДоговорСсылка.СотрудникПодписант;
                    Должность_vmoПодписанты.Value = Объект.Value.ДоговорСсылка.ДолжностьПодписанта;
                }
                else if (Объект.Value.Selected && Объект.Value.Фирма.Selected && Объект.Value.Фирма.СотрудникПодписант.Selected)
                {
                    Подписант_vmoПодписанты.Value = Объект.Value.Фирма.СотрудникПодписант;
                    Должность_vmoПодписанты.Value = Объект.Value.Фирма.ДолжностьПодписанта;
                }
            }
            else
            {
                Подписант_vmoПодписанты.Value = СотрудникПодписант.Value;
                Должность_vmoПодписанты.Value = ДолжностьПодписанта.Value;
            }
            Подпись_vmoПодписанты.Value = Подписант_vmoПодписанты.Value.КартинкаПодпись.Картинка;
            Печать_vmoПодписанты.Value = Объект.Value.Фирма.КартинкаПечать.Картинка;
        }

        private void ЗаполнитьТаблицу()
        {
            vmoТаблица.Data.BeginUpdateData();
            vmoТаблица.Data.MemoryTable.Clear();
            var тарифыТехники = Объект.Value.ДействующиеТарифыТехники();
            foreach (var item in Таблица.Value.AllRows)
            {
                var row = vmoТаблица.Data.MemoryTable.NewRow();
                row[Дата_vmoТаблица].Value = item.ДатаВремя;
                row[Тариф_vmoТаблица].Value = item.Тариф;
                row[ОтработаноЧасов_vmoТаблица].Value = item.ОтработаноМашиноЧасов;
                row[ДеньМесяца_vmoТаблица].Value = item.ДатаВремя.Day;
                var строка = тарифыТехники.FindRow(new NsgCompare().Add(РегистрТарифыТехникиОбъекта.Names.Тариф, item.Тариф)
                    .Add(РегистрТарифыТехникиОбъекта.Names.ГруппаСпецТехники, Техника.Value.ГруппаСпецТехники));
                if (строка != null)
                {
                    row[Цена_vmoТаблица].Value = строка[РегистрТарифыТехникиОбъекта.Names.Стоимость].ToDecimal();
                }
                row.Post();
            }

            vmoТаблица.Data.UpdateDataSync(this);
        }

        private void ЗаполнитьТаблицуРасчетаЗПМашиниста()
        {
            vmoДляРасчЗПМашинистов.Data.BeginUpdateData();
            vmoДляРасчЗПМашинистов.Data.MemoryTable.Clear();
            int итогоДней = 0;
            decimal итогоЧасов = 0;
            for (int i = 0; i < Таблица.Value.Count; i++)
            {
                итогоДней++;
                итогоЧасов += Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                if (i == 0)
                {
                    Мес1_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ1_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 1)
                {
                    Мес2_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ2_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 2)
                {
                    Мес3_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ3_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 3)
                {
                    Мес4_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ4_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 4)
                {
                    Мес5_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ5_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 5)
                {
                    Мес6_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ6_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 6)
                {
                    Мес7_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ7_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 7)
                {
                    Мес8_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ8_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 8)
                {
                    Мес9_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ9_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 9)
                {
                    Мес10_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ10_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
                else if (i == 10)
                {
                    Мес11_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ДатаВремя.Day;
                    ЧМ11_vmoДляРасчЗПМашинистов.Value = Таблица.Value.AllRows[i].ОтработаноМашиноЧасов;
                }
            }
            ИтогоДней_vmoДляРасчЗПМашинистов.Value = итогоДней;
            ИтогоЧасов_vmoДляРасчЗПМашинистов.Value = итогоЧасов;
            НеПечататьПодписи_vmoПодписанты.Value = НеПечататьПодписи.Value;
            vmoДляРасчЗПМашинистов.Data.UpdateDataSync(this);
        }

    }
    


}