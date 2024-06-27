using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;





namespace TechControl.Метаданные.Грузы
{
    
    public partial class УправлениеВъездамиВыездамиФорма

    {
        public УправлениеВъездамиВыездамиФорма()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (nsgVisualMultipleObject.Data.CurrentRow == null)
            {
                nsgVisualMultipleObject.Data.CurrentRow = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
            }
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

        private void nsgInput6_EndEdit(object sender, EndEditEventArgs e)
        {
            if (Объект.Value.Selected)
            {
                if (!КПП.Value.Selected || КПП.Value.Владелец != Объект.Value)
                {
                    var cmp = new NsgCompare();
                    cmp.Add(КонтрольноПропускныеПункты.Names.Владелец, Объект.Value);
                    cmp.Add(КонтрольноПропускныеПункты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    var кпп = КонтрольноПропускныеПункты.Новый();
                    
                    if (!кпп.Find(cmp))
                    {
                        NsgSettings.MainForm.ShowMessage($"На объекте {Объект.Value}, не заданы КПП");
                    }
                    КПП.Value = кпп;
                }
                ОбновитьСтатус();
            }
            else
            {
                Объект.Value = Объекты.Новый();
                КПП.Value = КонтрольноПропускныеПункты.Новый();
            }
        }

        private void nsgInput2_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ГосНомер.Value != string.Empty && ГосНомер.Value.Length > 9)
            {
                ГосНомер.Value = Техника.ФорматироватьГосномер(ГосНомер.Value.Replace(" ", ""));
                ПроезжающаяТехника.Value = Техника.ПоискТехникиПоГосНомеру(ГосНомер.Value);
                if (ПроезжающаяТехника.Value.Selected)
                {
                    ВидГруза.Value = ВидыГрузов.Пустой;
                    ОбъемГруза.Value = 0;
                }
                ОбновитьСтатус();
            }
            else
            {
                ПроезжающаяТехника.Value = Техника.Новый();
            }
        }

        private void nsgInput3_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ПроезжающаяТехника.Value.Selected)
            {
                ГосНомер.Value = ПроезжающаяТехника.Value.ГосНомер;
                ОбновитьСтатус();
            }
            else
            {
                ГосНомер.Value = string.Empty;
            }
        }

        private void ОбновитьСтатус() 
        {
            nLblСтатус.ForeColor = DefaultForeColor;

            var техника = ПроезжающаяТехника.Value;
            var объект = Объект.Value;
            var дата = Дата.Value;
            if (техника.Selected && объект.Selected && дата != NsgService.MinDate)
            {
                var reg = РегистрПеремещениеЧерезКПП.Новый();
                reg.Техника = техника;
                reg.Объект = объект;
                reg.GetRest(дата);
                if (reg.НахождениеНаОбъекте == 0)
                {
                    СтатусТехники.Value = "Въезжает";
                }
                else if (reg.НахождениеНаОбъекте == 1)
                {
                    СтатусТехники.Value = "Выезжает";
                }
                else if (reg.НахождениеНаОбъекте < 0)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько выездов без въездов";
                    nLblСтатус.ForeColor = Color.Red;
                }
                else if (reg.НахождениеНаОбъекте > 1)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько въездов без выездов";
                    nLblСтатус.ForeColor = Color.Red;
                }
            }
            else
            {
                СтатусТехники.Value = $"";
            }
        }

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            ОбновитьСтатус();
        }

        private void nsgInput8_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ВидГруза.Value.Selected && ВидГруза.Value != ВидыГрузов.Пустой && ПроезжающаяТехника.Value.Selected)
            {
                ОбъемГруза.Value = ПроезжающаяТехника.Value.ПолезныйОбъемМКуб;
            }
        }
    }
    


}