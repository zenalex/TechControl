using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Перечисления;
using TechControl.Метаданные.Учет;





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
            var дата = DateTime.Now;
            if (техника.Selected && объект.Selected && дата != NsgService.MinDate)
            {
                var reg = РегистрПеремещениеЧерезКПП.Новый();
                reg.Техника = техника;
                reg.Объект = объект;
                reg.GetRest(NsgService.MaxDate);

                nbВъезд.Enabled = true;
                nbВыезд.Enabled = true;

                if (reg.НахождениеНаОбъекте == 0)
                {
                    СтатусТехники.Value = "Въезжает";
                    nbВыезд.Enabled = false;
                }
                else if (reg.НахождениеНаОбъекте == 1)
                {
                    СтатусТехники.Value = $"На объекте {(Дата.Value - reg.ДатаДокумента).TotalMinutes} минут";
                    nbВыезд.Enabled = false;
                }
                else if (reg.НахождениеНаОбъекте < 0)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько выездов без въездов";
                    nLblСтатус.ForeColor = Color.Red;
                    nbВъезд.Enabled = false;
                    nbВыезд.Enabled = false;
                }
                else if (reg.НахождениеНаОбъекте > 1)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько въездов без выездов";
                    nLblСтатус.ForeColor = Color.Red;
                    nbВъезд.Enabled = false;
                    nbВыезд.Enabled = false;
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
            var дата = DateTime.Now;
            var кпп = КПП.Value;
            var водитель = Водитель.Value;
            var видГруза = ВидГруза.Value;
            var объемГруза = ОбъемГруза.Value;
            var комментарий = КомментарийПроезд.Value;

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
            reg.GetRest(NsgService.MaxDate);

            if (reg.НахождениеНаОбъекте <= 0)
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
                документВъезда.Комментарий = комментарий;

                foreach (var item in vmoФотографии.Data.MemoryTable.AllRows)
                {
                    var row = документВъезда.ТаблицаФотографии.NewRow();
                    row.Фотография = item[Фото_vmoФотографии].ToReferent() as Фотографии;
                    row.Post();
                }
                документВъезда.Handle();

                NsgSettings.MainForm.ShowObject(документВъезда, this);
            }
            else
            {
                string сообщение = string.Empty;
                сообщение = $"Данная техника уже на объекте.";

                var dialRes = MessageBox.Show(сообщение, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            ОбновитьСтатус();
        }

        private void nbВыезд_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var техника = ПроезжающаяТехника.Value;
            var объект = Объект.Value;
            var дата = DateTime.Now;
            var кпп = КПП.Value;
            var водитель = Водитель.Value;
            var видГруза = ВидГруза.Value;
            var объемГруза = ОбъемГруза.Value;
            var комментарий = КомментарийПроезд.Value;
            var комментарийГруз = КомментарийГруз.Value;

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
            reg.GetRest(NsgService.MaxDate);
            if (reg.НахождениеНаОбъекте >= 1)
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
                документВыезда.Комментарий = комментарий;

                foreach (var item in vmoФотографии.Data.MemoryTable.AllRows)
                {
                    var row = документВыезда.ТаблицаФотографии.NewRow();
                    row.Фотография = item[Фото_vmoФотографии].ToReferent() as Фотографии;
                    row.Post();
                }

                if (видГруза.Selected && видГруза != reg.ВидГруза)
                {
                    var cmp = new NsgCompare();
                    cmp.Add(ПривозГруза.Names.ДатаДокумента, reg.ДатаДокумента, NsgComparison.GreaterOrEqual);
                    cmp.Add(ПривозГруза.Names.ДатаДокумента, дата, NsgComparison.LessOrEqual);
                    cmp.Add(ПривозГруза.Names.ВидГруза, reg.ВидГруза);
                    cmp.Add(ПривозГруза.Names.Объект, объект);
                    cmp.Add(ПривозГруза.Names.НомерАвто, техника.ГосНомер);
                    cmp.Add(ПривозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                    var документПривозГруза = ПривозГруза.Новый();

                    if (!документПривозГруза.Find(cmp))
                    {
                        документПривозГруза.New();
                        документПривозГруза.ДокументОснование = документВыезда;
                        документПривозГруза.ДатаДокумента = дата;
                        документПривозГруза.Объект = объект;
                        документПривозГруза.ВидГруза = reg.ВидГруза;
                        документПривозГруза.ОбъемГруза = reg.ОбъемГруза;
                        документПривозГруза.НомерАвто = техника.ГосНомер;
                        документПривозГруза.Контрагент = техника.Подрядчик;
                        документПривозГруза.Комментарий = "Создано автоматически на основании выезда";
                        документПривозГруза.Handle();

                        NsgSettings.MainForm.ShowObject(документПривозГруза, this);
                    }

                    if (видГруза != ВидыГрузов.Пустой)
                    {
                        cmp = new NsgCompare();
                        cmp.Add(ВывозГруза.Names.ДатаДокумента, reg.ДатаДокумента, NsgComparison.GreaterOrEqual);
                        cmp.Add(ВывозГруза.Names.ДатаДокумента, дата, NsgComparison.LessOrEqual);
                        cmp.Add(ВывозГруза.Names.ВидГруза, видГруза);
                        cmp.Add(ВывозГруза.Names.Объект, объект);
                        cmp.Add(ВывозГруза.Names.НомерАвто, техника.ГосНомер);
                        cmp.Add(ВывозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                        var документВывозГруза = ВывозГруза.Новый();

                        if (!документВывозГруза.Find(cmp))
                        {
                            документВывозГруза.New();
                            документВывозГруза.ДокументОснование = документВыезда;
                            документВывозГруза.ДатаДокумента = дата;
                            документВывозГруза.Объект = объект;
                            документВывозГруза.ВидГруза = видГруза;
                            документВывозГруза.ОбъемГруза = объемГруза;
                            документВывозГруза.НомерАвто = техника.ГосНомер;
                            документВывозГруза.Контрагент = техника.Подрядчик;
                            документВывозГруза.Комментарий = комментарийГруз;
                            документВывозГруза.Handle();

                            NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                        }
                    }
                }
                else
                {
                    документВыезда.ТребуетПроверки = true;
                }

                документВыезда.Handle();

                NsgSettings.MainForm.ShowObject(документВыезда, this);
            }
            else
            {
                string сообщение = string.Empty;
                сообщение = $"Данная техника уже уехала.";

                var dialRes = MessageBox.Show(сообщение, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            ОбновитьСтатус();
        }

        private void vmoФотографии_CurrentRowChanged(object sender, NsgMultipleObject oldRow, NsgMultipleObject newRow)
        {
            if (vmoФотографии.Data.CurrentRow != null)
            {
                //MemoryStream stream = (MemoryStream)Фото_vmoФотографии.Value;
                //stream.Seek(0, SeekOrigin.Begin);
                //Image img = System.Drawing.Image.FromStream(stream);

                pictureBox1.Image = Фото_vmoФотографии.Value.Фотография;
            }
        }
    }
    


}