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
using TechControl.Метаданные.Перечисления;





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

        private void nbВъезд_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var техника = ПроезжающаяТехника.Value;
            var объект = Объект.Value;
            var дата = Дата.Value;
            var кпп = КПП.Value;
            var водитель = Водитель.Value;
            var видГруза = ВидГруза.Value;
            var объемГруза = ОбъемГруза.Value;

            if (!техника.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите технику");
                return;
            }

            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект");
                return;
            }

            if (дата == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Укажите дату");
                return;
            }

            if (!кпп.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите КПП");
                return;
            }

            if (!водитель.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите водителя");
                return;
            }

            if (!видГруза.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите вид груза или выберите Пустой");
                return;
            }

            if (видГруза.Selected && видГруза != ВидыГрузов.Пустой && объемГруза == 0)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объем груза");
                return;
            }

            var reg = РегистрПеремещениеЧерезКПП.Новый();
            reg.Техника = техника;
            reg.Объект = объект;
            reg.GetRest(дата);
            if (reg.НахождениеНаОбъекте == 0)
            {
                var документВъезда = ДокументыВъезда.Новый();
                документВъезда.New();
                документВъезда.ДатаДокумента = дата;
                документВъезда.Объект = объект;
                документВъезда.КПП = кпп;
                документВъезда.Водитель = водитель;
                документВъезда.Техника = техника;
                документВъезда.ВидГруза = видГруза;
                документВъезда.ОбъемГруза = объемГруза;
                документВъезда.Handle();

                NsgSettings.MainForm.ShowObject(документВъезда, this);

                //if (видГруза.Selected && видГруза != ВидыГрузов.Пустой)
                //{
                //    var документПривозГруза = ПривозГруза.Новый();
                //    документПривозГруза.New();
                //    документПривозГруза.ДатаДокумента = дата;
                //    документПривозГруза.Объект = объект;
                //    документПривозГруза.ВидГруза = видГруза;
                //    документПривозГруза.ОбъемГруза = объемГруза;
                //    документПривозГруза.НомерАвто = техника.ГосНомер;
                //    документПривозГруза.Контрагент = техника.Подрядчик;
                //    документПривозГруза.Handle();

                //    NsgSettings.MainForm.ShowObject(документПривозГруза, this);
                //}
            }
            else
            {
                string сообщение = string.Empty;
                if (reg.НахождениеНаОбъекте >= 1)
                {
                    сообщение = $"На {дата} уже оформлены выезды. Оформить еще 1?";
                }
                else
                {
                    сообщение = $"На {дата} {техника} уже на объекте. Продолжить оформление Въезда?";
                }

                var dialRes = MessageBox.Show(сообщение, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (dialRes == DialogResult.Yes)
                {
                    var документВъезда = ДокументыВъезда.Новый();
                    документВъезда.New();
                    документВъезда.ДатаДокумента = дата;
                    документВъезда.Объект = объект;
                    документВъезда.КПП = кпп;
                    документВъезда.Водитель = водитель;
                    документВъезда.Техника = техника;
                    документВъезда.ВидГруза = видГруза;
                    документВъезда.ОбъемГруза = объемГруза;
                    документВъезда.Handle();

                    NsgSettings.MainForm.ShowObject(документВъезда, this);

                    //if (видГруза.Selected && видГруза != ВидыГрузов.Пустой)
                    //{
                    //    var документПривозГруза = ПривозГруза.Новый();
                    //    документПривозГруза.New();
                    //    документПривозГруза.ДатаДокумента = дата;
                    //    документПривозГруза.Объект = объект;
                    //    документПривозГруза.ВидГруза = видГруза;
                    //    документПривозГруза.ОбъемГруза = объемГруза;
                    //    документПривозГруза.НомерАвто = техника.ГосНомер;
                    //    документПривозГруза.Контрагент = техника.Подрядчик;
                    //    документПривозГруза.Handle();

                    //    NsgSettings.MainForm.ShowObject(документПривозГруза, this);
                    //}
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            ОбновитьСтатус();
        }

        private void nbВыезд_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var техника = ПроезжающаяТехника.Value;
            var объект = Объект.Value;
            var дата = Дата.Value;
            var кпп = КПП.Value;
            var водитель = Водитель.Value;
            var видГруза = ВидГруза.Value;
            var объемГруза = ОбъемГруза.Value;

            if (!техника.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите технику");
                return;
            }

            if (!объект.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объект");
                return;
            }

            if (дата == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Укажите дату");
                return;
            }

            if (!кпп.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите КПП");
                return;
            }

            if (!водитель.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите водителя");
                return;
            }

            if (!видГруза.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Укажите вид груза или выберите Пустой");
                return;
            }

            if (видГруза.Selected && видГруза != ВидыГрузов.Пустой && объемГруза == 0)
            {
                NsgSettings.MainForm.ShowMessage("Укажите объем груза");
                return;
            }

            var reg = РегистрПеремещениеЧерезКПП.Новый();
            reg.Техника = техника;
            reg.Объект = объект;
            reg.GetRest(дата);
            if (reg.НахождениеНаОбъекте == 1)
            {
                var документВыезда = ДокументыВыезда.Новый();
                документВыезда.New();
                документВыезда.ДатаДокумента = дата;
                документВыезда.Объект = объект;
                документВыезда.КПП = кпп;
                документВыезда.Водитель = водитель;
                документВыезда.Техника = техника;
                документВыезда.ВидГруза = видГруза;
                документВыезда.ОбъемГруза = объемГруза;
                документВыезда.Handle();

                NsgSettings.MainForm.ShowObject(документВыезда, this);

                //if (видГруза.Selected && видГруза != ВидыГрузов.Пустой)
                //{
                //    var документВывозГруза = ВывозГруза.Новый();
                //    документВывозГруза.New();
                //    документВывозГруза.ДатаДокумента = дата;
                //    документВывозГруза.Объект = объект;
                //    документВывозГруза.ВидГруза = видГруза;
                //    документВывозГруза.ОбъемГруза = объемГруза;
                //    документВывозГруза.НомерАвто = техника.ГосНомер;
                //    документВывозГруза.Контрагент = техника.Подрядчик;
                //    документВывозГруза.Handle();

                //    NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                //}
            }
            else
            {
                string сообщение = string.Empty;
                if (reg.НахождениеНаОбъекте <= 0)
                {
                    сообщение = $"На {дата} уже оформлены въезды. Оформить еще 1?";
                }
                else
                {
                    сообщение = $"На {дата} {техника} уже выехал. Продолжить оформление Выезда?";
                }

                var dialRes = MessageBox.Show(сообщение, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (dialRes == DialogResult.Yes)
                {
                    var документВыезда = ДокументыВыезда.Новый();
                    документВыезда.New();
                    документВыезда.ДатаДокумента = дата;
                    документВыезда.Объект = объект;
                    документВыезда.КПП = кпп;
                    документВыезда.Водитель = водитель;
                    документВыезда.Техника = техника;
                    документВыезда.ВидГруза = видГруза;
                    документВыезда.ОбъемГруза = объемГруза;
                    документВыезда.Handle();

                    NsgSettings.MainForm.ShowObject(документВыезда, this);

                    //if (видГруза.Selected && видГруза != ВидыГрузов.Пустой)
                    //{
                    //    var документВывозГруза = ВывозГруза.Новый();
                    //    документВывозГруза.New();
                    //    документВывозГруза.ДатаДокумента = дата;
                    //    документВывозГруза.Объект = объект;
                    //    документВывозГруза.ВидГруза = видГруза;
                    //    документВывозГруза.ОбъемГруза = объемГруза;
                    //    документВывозГруза.НомерАвто = техника.ГосНомер;
                    //    документВывозГруза.Контрагент = техника.Подрядчик;
                    //    документВывозГруза.Handle();

                    //    NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                    //}
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            ОбновитьСтатус();
        }
    }
    


}