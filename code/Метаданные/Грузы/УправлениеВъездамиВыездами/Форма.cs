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
using TechControl.Метаданные._SystemTables;
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

            УстановитьФильтр();
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

                if (reg.НахождениеНаОбъекте == 0)
                {
                    СтатусТехники.Value = "Въезжает";
                    ДоступностьКнопок(false, true);
                }
                else if (reg.НахождениеНаОбъекте == 1)
                {
                    СтатусТехники.Value = $"На объекте {(Дата.Value - reg.ДатаДокумента).TotalMinutes} минут";
                    ДоступностьКнопок(true, false);
                }
                else if (reg.НахождениеНаОбъекте < 0)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько выездов без въездов";
                    nLblСтатус.ForeColor = Color.Red;
                    ДоступностьКнопок(false, false);
                }
                else if (reg.НахождениеНаОбъекте > 1)
                {
                    СтатусТехники.Value = $"На {дата} оформлено несколько въездов без выездов";
                    nLblСтатус.ForeColor = Color.Red;
                    ДоступностьКнопок(false, false);
                }
            }
            else
            {
                СтатусТехники.Value = $"";
            }
        }

        private void ДоступностьКнопок(bool выездДоступен, bool въездДоступен) 
        {
            if (nbВъезд.InvokeRequired || nbВыезд.InvokeRequired)
            {
                nbВъезд.Invoke(new MethodInvoker(() => nbВъезд.Enabled = въездДоступен));
                nbВыезд.Invoke(new MethodInvoker(() => nbВыезд.Enabled = выездДоступен));
            }
            else
            {
                nbВъезд.Enabled = въездДоступен;
                nbВыезд.Enabled = выездДоступен;
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
                var cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                var sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                int count = 1;
                var движение = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения)[0];

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

                if (видГруза.Selected && видГруза != движение.ВидГруза)
                {
                    var cmp = new NsgCompare();
                    if (движение.ВидГруза != ВидыГрузов.Пустой)
                    {
                        cmp.Add(ПривозГруза.Names.ДатаДокумента, движение.ДатаДокумента, NsgComparison.GreaterOrEqual);
                        cmp.Add(ПривозГруза.Names.ДатаДокумента, дата, NsgComparison.LessOrEqual);
                        cmp.Add(ПривозГруза.Names.ВидГруза, движение.ВидГруза);
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
                            документПривозГруза.ВидГруза = движение.ВидГруза;
                            документПривозГруза.ОбъемГруза = движение.ОбъемГруза;
                            документПривозГруза.НомерАвто = техника.ГосНомер;
                            документПривозГруза.Контрагент = техника.Подрядчик;
                            документПривозГруза.Комментарий = "Создано автоматически на основании выезда";
                            документПривозГруза.Handle();

                            NsgSettings.MainForm.ShowObject(документПривозГруза, this);
                        }
                    }
                    
                    if (видГруза != ВидыГрузов.Пустой)
                    {
                        cmp = new NsgCompare();
                        cmp.Add(ВывозГруза.Names.ДатаДокумента, движение.ДатаДокумента, NsgComparison.GreaterOrEqual);
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tpТехника)
            {
                nbwЗаполнениеСостояния.Run();
            }
        }

        private void nbwЗаполнениеСостояния_DoWork(object sender, DoWorkEventArgs e)
        {
            var reg = РегистрПеремещениеЧерезКПП.Новый();
            var состояния = reg.GetRests(NsgService.MaxDate);

            vmoСостояние.Data.BeginUpdateData();
            vmoСостояние.Data.MemoryTable.Clear();
            foreach (var состояние in состояния.AllRows)
            {
                var объект = состояние[РегистрПеремещениеЧерезКПП.Names.Объект].ToReferent() as Объекты;
                var техника = состояние[РегистрПеремещениеЧерезКПП.Names.Техника].ToReferent() as Техника;
                var нахождениеНаОбъекте = состояние[РегистрПеремещениеЧерезКПП.Names.НахождениеНаОбъекте].ToBegin();

                var cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                var sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                int count = 1;
                var движение = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения)[0];

                var row = vmoСостояние.Data.MemoryTable.NewRow();
                row[ТекущаяТехника_vmoСостояние].Value = техника;
                if (нахождениеНаОбъекте >= 1)
                {
                    row[ВремяПриезда_vmoСостояние].Value = движение.ДатаДокумента;
                    row[Объект_vmoСостояние].Value = объект;
                }
                else
                {
                    row[ВремяПриезда_vmoСостояние].Value = NsgService.MinDate;
                    row[Объект_vmoСостояние].Value = Объекты.Новый();
                }
                row[Груз_vmoСостояние].Value = движение.ВидГруза;
                row[Объем_vmoСостояние].Value = движение.ОбъемГруза;

                row.Post();
            }

            vmoСостояние.Data.UpdateDataSync(this);
            УстановитьФильтр();
        }

        private void УстановитьФильтр() 
        {
            var cmp = vmoСостояние.Data.GetComparison(this);
            cmp.Clear();
            if (!cbПоказатьВсе.Checked)
            {
                cmp.Add(Объект_vmoСостояние.Name, Объект.Value);
            }
            vmoСостояние.Data.UpdateDataAsync(this);
        }

        private void cbПоказатьВсе_CheckedChanged(object sender, EventArgs e)
        {
            УстановитьФильтр();
        }

        private void nbОформитьЗаднимЧислом_AsyncClick(object sender, DoWorkEventArgs e)
        {
            //общие данные
            var объект = Объект.Value;
            var техника = Техника_vmoЗаднимЧислом.Value;

            // въезд
            var датаВъезда = ДатаВъезда_vmoЗаднимЧислом.Value;
            var кппВъезд = КППВъезд_vmoЗаднимЧислом.Value;
            var водительВъезд = ВодительВъезд_vmoЗаднимЧислом.Value;
            var грузВъезд = ГрузНаВъезде_vmoЗаднимЧислом.Value;
            var объемВъезд = ОбъемГрузаНаВъезде_vmoЗаднимЧислом.Value;
            var комментарийВъезд = КомментарийВъезд_vmoЗаднимЧислом.Value;

            //выезд
            var датаВыезда = ДатаВыезда_vmoЗаднимЧислом.Value;
            var кппВыезд = КППВыезд_vmoЗаднимЧислом.Value;
            var водительВыезд = ВодительВыезд_vmoЗаднимЧислом.Value;
            var грузВыезд = ГрузНаВыезде_vmoЗаднимЧислом.Value;
            var объемВыезд = ОбъемГрузаНаВыезде_vmoЗаднимЧислом.Value;
            var комментарийВыезд = КомментарийВыезд_vmoЗаднимЧислом.Value;

            if (!объект.Selected || !техника.Selected)
            {
                NsgSettings.MainForm.ShowMessage("Не указан объект или техника");
                return;
            }
            if (датаВъезда == NsgService.MinDate && датаВыезда == NsgService.MinDate)
            {
                NsgSettings.MainForm.ShowMessage("Не заполнена дата въезда и дата выезда");
                return;
            }
            if (датаВъезда != NsgService.MinDate)
            {
                if (!кппВъезд.Selected || !водительВъезд.Selected || !грузВъезд.Selected || (грузВъезд != ВидыГрузов.Пустой && объемВъезд == 0) || (грузВъезд == ВидыГрузов.Пустой && объемВъезд != 0))
                {
                    NsgSettings.MainForm.ShowMessage("Не корректно заполнены данные въезда.");
                    return;
                }
            }

            if (датаВыезда != NsgService.MinDate)
            {
                if (!кппВыезд.Selected || !водительВыезд.Selected || !грузВыезд.Selected || (грузВыезд != ВидыГрузов.Пустой && объемВыезд == 0) || (грузВыезд == ВидыГрузов.Пустой && объемВыезд != 0))
                {
                    NsgSettings.MainForm.ShowMessage("Не корректно заполнены данные выезда.");
                    return;
                }
            }

            if (датаВъезда != NsgService.MinDate && датаВыезда != NsgService.MinDate)
            {
                if (датаВъезда < датаВыезда)
                {
                    //предыдущее движение
                    ГрузыРегистрПеремещениеЧерезКППДвижения предыдущееДвижение = null;
                    var cmpДвижения = new NsgCompare();
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, датаВъезда, NsgComparison.Less);
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                    var sort = new NsgSorting();
                    sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                    int count = 1;
                    var движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);
                    
                    if (движения.Length > 0)
                    {
                        предыдущееДвижение = движения[0];
                    }

                    //следующее движение
                    ГрузыРегистрПеремещениеЧерезКППДвижения следующееДвижение = null;
                    cmpДвижения = new NsgCompare();
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, датаВыезда, NsgComparison.Greater);
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                    cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                    sort = new NsgSorting();
                    sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Ascending));
                    count = 1;
                    движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);

                    if (движения.Length > 0)
                    {
                        следующееДвижение = движения[0];
                    }

                    //контроль разгрузки
                    if (предыдущееДвижение != null && предыдущееДвижение.ВидГруза != грузВъезд)
                    {
                        if (предыдущееДвижение.ВидГруза != ВидыГрузов.Пустой)
                        {
                            //var cmp = new NsgCompare();
                            //cmp.Add(ВывозГруза.Names.ДатаДокумента, предыдущееДвижение.ДатаДокумента, NsgComparison.GreaterOrEqual);
                            //cmp.Add(ВывозГруза.Names.ДатаДокумента, дата, NsgComparison.LessOrEqual);
                            //cmp.Add(ВывозГруза.Names.ВидГруза, видГруза);
                            //cmp.Add(ВывозГруза.Names.Объект, объект);
                            //cmp.Add(ВывозГруза.Names.НомерАвто, техника.ГосНомер);
                            //cmp.Add(ВывозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                            //var документВывозГруза = ВывозГруза.Новый();

                            //if (!документВывозГруза.Find(cmp))
                            //{
                            //    документВывозГруза.New();
                            //    документВывозГруза.ДокументОснование = документВыезда;
                            //    документВывозГруза.ДатаДокумента = дата;
                            //    документВывозГруза.Объект = объект;
                            //    документВывозГруза.ВидГруза = видГруза;
                            //    документВывозГруза.ОбъемГруза = объемГруза;
                            //    документВывозГруза.НомерАвто = техника.ГосНомер;
                            //    документВывозГруза.Контрагент = техника.Подрядчик;
                            //    документВывозГруза.Комментарий = комментарийГруз;
                            //    документВывозГруза.Handle();

                            //    NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                            //}
                        }
                    }

                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }


            
            if (датаВыезда != NsgService.MinDate && датаВыезда > DateTime.Now)
            {
                NsgSettings.MainForm.ShowMessage("Дата выезда не должна быть больше текущего времени.");
                return;
            }

            if (датаВъезда < датаВыезда)
            {
                var cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, датаВъезда, NsgComparison.Greater);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                var sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Ascending));
                int count = 1;
                var движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);
                if (движения.Length > 0)
                {
                    
                }
            }

            

            
        }

        private void nsgInput13_Selected(object sender, EventArgs e)
        {
            var объект = Объект.Value;
            var техника = Техника_vmoЗаднимЧислом.Value;
            var дата = ДатаВъезда_vmoЗаднимЧислом.Value;
            ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Value = NsgService.MinDate;
            ДатаСледующейЗаписи_vmoЗаднимЧислом.Value = NsgService.MinDate;
            if (объект != null && объект.Selected && техника != null && техника.Selected && дата != NsgService.MinDate)
            {
                //предыдущее движение
                var cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, дата, NsgComparison.Less);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                var sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                int count = 1;
                var движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);
                if (движения.Length > 0)
                {
                    var движение = движения[0];
                    ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Value = движение.ДатаДокумента;
                    if (движение.ВидДвижения == Сервис.ВидыДвижений.Приход)
                    {
                        ДатаВыезда_vmoЗаднимЧислом.Value = дата;
                        NsgSettings.MainForm.ShowMessage("Перед выбранной датой был въезд на объект. На выбранную дату можно оформить только выезд.");
                    }
                }
                //следующее движение
                cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, дата, NsgComparison.Greater);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Ascending));
                count = 1;
                движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);

                if (движения.Length > 0)
                {
                    var движение = движения[0];
                    ДатаСледующейЗаписи_vmoЗаднимЧислом.Value = движение.ДатаДокумента;
                    if (движение.ВидДвижения == Сервис.ВидыДвижений.Расход)
                    {
                        ДатаВъезда_vmoЗаднимЧислом.Value = движение.ДатаДокумента.AddMinutes(-10);
                        NsgSettings.MainForm.ShowMessage($"Дата въезда изменена на 10 минут до следующего выезда в {движение.ДатаДокумента}");
                    }
                }
                else
                {
                    ДатаВыезда_vmoЗаднимЧислом.Value = NsgService.MinDate;
                }
            }
        }

        private void nsgInput20_Selected(object sender, EventArgs e)
        {
            var объект = Объект.Value;
            var техника = Техника_vmoЗаднимЧислом.Value;
            var дата = ДатаВыезда_vmoЗаднимЧислом.Value;
            ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Value = NsgService.MinDate;
            ДатаСледующейЗаписи_vmoЗаднимЧислом.Value = NsgService.MinDate;
            if (объект != null && объект.Selected && техника != null && техника.Selected && дата != NsgService.MinDate)
            {
                var cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, дата, NsgComparison.Greater);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                var sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Ascending));
                int count = 1;
                var движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);
                if (движения.Length > 0)
                {
                    var движение = движения[0];
                    ДатаСледующейЗаписи_vmoЗаднимЧислом.Value = движение.ДатаДокумента;
                    if (движение.ВидДвижения == Сервис.ВидыДвижений.Расход)
                    {
                        ДатаВъезда_vmoЗаднимЧислом.Value = дата;
                        NsgSettings.MainForm.ShowMessage("После выбранной даты уже оформлен выезд. На выбранную дату можно оформить только въезд.");
                    }
                }
                cmpДвижения = new NsgCompare();
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, дата, NsgComparison.Less);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                sort = new NsgSorting();
                sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                count = 1;
                движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения);

                if (движения.Length > 0)
                {
                    var движение = движения[0];
                    ДатаПредыдущейЗаписи_vmoЗаднимЧислом.Value = движение.ДатаДокумента;
                    if (движение.ВидДвижения == Сервис.ВидыДвижений.Приход) 
                    {
                        ДатаВыезда_vmoЗаднимЧислом.Value = движение.ДатаДокумента.AddMinutes(10);
                        NsgSettings.MainForm.ShowMessage($"Дата выезда изменена на 10 минут после прошлого въезда в {движение.ДатаДокумента}");
                    }
                }
            }
        }

        private void nsgIGrid3_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.Refresh)
            {

            }
        }

        string _въездСтрока = "Въезд";
        string _выездСтрока = "Выезд";
        private void ОбновитьСостоянияВъездаВыезда() 
        {
            var cmp = new NsgCompare();
            cmp.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, nsgPeriodPicker1.Period.Begin, NsgComparison.GreaterOrEqual);
            cmp.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, nsgPeriodPicker1.Period.End, NsgComparison.LessOrEqual);
            cmp.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, Объект.Value);
            cmp.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, Техника_vmoЗаднимЧислом.Value);

            var sort = new NsgSorting();
            sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Ascending));
            var движения = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(cmp, sort);

            vmoСостояниеВъездовВыездов.Data.BeginUpdateData();
            vmoСостояниеВъездовВыездов.Data.MemoryTable.Clear();

            foreach (var item in движения)
            {
                var движение = item as ГрузыРегистрПеремещениеЧерезКППДвижения;
                var row = vmoСостояниеВъездовВыездов.Data.MemoryTable.NewRow();
                row[ВидГруза_vmoСостояниеВъездовВыездов].Value = движение.ВидГруза;
                row[ДатаДокумента_vmoСостояниеВъездовВыездов].Value = движение.ДатаДокумента;
                row[КПП_vmoСостояниеВъездовВыездов].Value = движение.КПП;
                row[НахождениеНаОбъекте_vmoСостояниеВъездовВыездов].Value = движение.НахождениеНаОбъекте;
                row[Объект_vmoСостояниеВъездовВыездов].Value = движение.Объект;
                row[ОбъемГруза_vmoСостояниеВъездовВыездов].Value = движение.ОбъемГруза;
                row[Техника_vmoСостояниеВъездовВыездов].Value = движение.Техника;
                row[НаправлениеДвижения_vmoСостояниеВъездовВыездов].Value = движение.ВидДвижения;
                row[НаправлениеДвиженияСтрока_vmoСостояниеВъездовВыездов].Value = движение.ВидДвижения == Сервис.ВидыДвижений.Приход ? _въездСтрока : _выездСтрока;
                row.Post();
            }

            vmoСостояниеВъездовВыездов.Data.UpdateDataSync(this);
        }
    }
    


}