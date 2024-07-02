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
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Мониторинг;





namespace TechControl.Метаданные.Грузы
{
    
    public partial class УправлениеПогрузкойРазгрузкойФорма

    {
        public УправлениеПогрузкойРазгрузкойФорма()
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

        private void nsgInput1_Selected(object sender, EventArgs e)
        {
            ОбновитьСостояния();
        }

        private void ОбновитьСостояния() 
        {
            var объект = Объект.Value;
            vmoСостояние.Data.BeginUpdateData();
            vmoСостояние.Data.MemoryTable.Clear();
            if (объект != null && объект.Selected)
            {
                var reg = РегистрПеремещениеЧерезКПП.Новый();
                reg.Объект = объект;
                var состояния = reg.GetRests(NsgService.MaxDate);

                foreach (var состояние in состояния.AllRows)
                {
                    if (состояние[РегистрПеремещениеЧерезКПП.Names.НахождениеНаОбъекте].ToBegin() == 1)
                    {
                        var техника = состояние[РегистрПеремещениеЧерезКПП.Names.Техника].ToReferent() as Техника;
                        
                        var cmpДвижения = new NsgCompare();
                        cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Объект, объект);
                        cmpДвижения.Add(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.Техника, техника);
                        var sort = new NsgSorting();
                        sort.Add(new NsgSortingParam(ГрузыРегистрПеремещениеЧерезКППДвижения.Names.ДатаДокумента, NsgSortDirection.Descending));
                        int count = 1;
                        var движение = ГрузыРегистрПеремещениеЧерезКППДвижения.Новый().FindAll(ref count, 0, sort, cmpДвижения)[0];

                        var видГруза = движение.ВидГруза;
                        var дата = движение.ДатаДокумента;
                        var объем = движение.ОбъемГруза;

                        var cmp = new NsgCompare();
                        cmp.Add(ПривозГруза.Names.ДатаДокумента, дата, NsgComparison.GreaterOrEqual);
                        cmp.Add(ПривозГруза.Names.ДатаДокумента, DateTime.Now, NsgComparison.LessOrEqual);
                        cmp.Add(ПривозГруза.Names.ВидГруза, видГруза);
                        cmp.Add(ПривозГруза.Names.Объект, объект);
                        cmp.Add(ПривозГруза.Names.НомерАвто, техника.ГосНомер);
                        cmp.Add(ПривозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                        var документПривозГруза = ПривозГруза.Новый();

                        var row = vmoСостояние.Data.MemoryTable.NewRow();
                        row[Техника_vmoСостояние].Value = техника;
                        row[Объем_vmoСостояние].Value = объем;
                        row[Номер_vmoСостояние].Value = техника.ГосНомер;
                        row[ДатаПриезда_vmoСостояние].Value = дата;

                        if (!документПривозГруза.Find(cmp))
                        {
                            row[Груз_vmoСостояние].Value = видГруза;
                        }
                        else
                        {
                            row[Груз_vmoСостояние].Value = ВидыГрузов.Пустой;
                        }
                        row.Post();
                    }
                }

            }

            vmoСостояние.Data.UpdateDataAsync(this);
        }

        private void nsgIGrid1_BeforeAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {
            if (args.ToolType == NsgWorkPanelTools.Refresh)
            {
                ОбновитьСостояния();
            }
        }


        int _индексТаба = -1;
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            _индексТаба = tabControl1.SelectedIndex;
            УстановитьФильтр();
            ЗаполнитьДанные();
        }

        private void УстановитьФильтр() 
        {
            var cmp = vmoСостояние.Data.GetComparison(this);
            cmp.Clear();
            if (_индексТаба == 1)
            {
                cmp.Add(Груз_vmoСостояние.Name, ВидыГрузов.Пустой, NsgComparison.NotEqual);
            }
            else if (_индексТаба == 2)
            {
                cmp.Add(Груз_vmoСостояние.Name, ВидыГрузов.Пустой);
            }
            vmoСостояние.Data.UpdateDataAsync(this);
        }

        private void vmoСостояние_CurrentRowChanged(object sender, NsgMultipleObject oldRow, NsgMultipleObject newRow)
        {
            ЗаполнитьДанные();
        }

        private void ЗаполнитьДанные() 
        {
            if (vmoСостояние.Data.CurrentRow != null)
            {
                if (_индексТаба == 1)
                {
                    if (Груз_vmoСостояние.Value == ВидыГрузов.Пустой)
                    {
                        ВыбраннаяТехника.Value = Техника.Новый();
                        НомерАвто.Value = string.Empty;
                        ВидГруза.Value = ВидыГрузов.Новый();
                        ОбъемГруза.Value = 0;
                        ДатаПриезда.Value = NsgService.MinDate;
                    }
                    else
                    {
                        ВыбраннаяТехника.Value = Техника_vmoСостояние.Value;
                        НомерАвто.Value = Техника_vmoСостояние.Value.ГосНомер;
                        ВидГруза.Value = Груз_vmoСостояние.Value;
                        ОбъемГруза.Value = Объем_vmoСостояние.Value;
                        ДатаПриезда.Value = ДатаПриезда_vmoСостояние.Value;
                    }
                }
                else if (_индексТаба == 2 && ВидГруза.Value != ВидыГрузов.Пустой)
                {
                    if (Груз_vmoСостояние.Value != ВидыГрузов.Пустой)
                    {
                        ВыбраннаяТехника.Value = Техника.Новый();
                        НомерАвто.Value = string.Empty;
                        ВидГруза.Value = ВидыГрузов.Новый();
                        ОбъемГруза.Value = 0;
                        ДатаПриезда.Value = NsgService.MinDate;
                    }
                    else
                    {
                        ВыбраннаяТехника.Value = Техника_vmoСостояние.Value;
                        НомерАвто.Value = Техника_vmoСостояние.Value.ГосНомер;
                        ВидГруза.Value = Груз_vmoСостояние.Value;
                        ОбъемГруза.Value = Объем_vmoСостояние.Value;
                        ДатаПриезда.Value = ДатаПриезда_vmoСостояние.Value;
                    }
                }
            }
            else
            {
                ВыбраннаяТехника.Value = Техника.Новый();
                НомерАвто.Value = string.Empty;
                ВидГруза.Value = ВидыГрузов.Новый();
                ОбъемГруза.Value = 0;
                ДатаПриезда.Value = NsgService.MinDate;
            }
            Комментарий.Value = string.Empty;

            nsgVisualMultipleObject.Data.UpdateDataAsync(this);
        }

        private void nsgInput8_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ВыбраннаяТехника.Value.ПолезныйОбъемМКуб != 0 && ОбъемГруза.Value > ВыбраннаяТехника.Value.ПолезныйОбъемМКуб)
            {
                ОбъемГруза.Value = ВыбраннаяТехника.Value.ПолезныйОбъемМКуб;
            }
            if (ВидГруза.Value == ВидыГрузов.Пустой)
            {
                ОбъемГруза.Value = 0;
            }
            if (ОбъемГруза.Value > 0)
            {
                nbПогрузка.Enabled = false;
            }
            else
            {
                nbПогрузка.Enabled = true;
            }
        }

        private void nsgInput9_EndEdit(object sender, EndEditEventArgs e)
        {
            if (ВидГруза.Value != null && ВидГруза.Value.Selected)
            {
                if (ВидГруза.Value != ВидыГрузов.Пустой && ВыбраннаяТехника.Value.Selected)
                {
                    ОбъемГруза.Value = ВыбраннаяТехника.Value.ПолезныйОбъемМКуб;
                }
                else
                {
                    ОбъемГруза.Value = 0;
                }
            }
            if (ОбъемГруза.Value > 0)
            {
                nbПогрузка.Enabled = false;
            }
            else
            {
                nbПогрузка.Enabled = true;
            }
        }

        private void nbРазгрузка_AsyncClick(object sender, DoWorkEventArgs e)
        {
            var cmp = new NsgCompare();
            cmp.Add(ПривозГруза.Names.ДатаДокумента, ДатаПриезда.Value, NsgComparison.GreaterOrEqual);
            cmp.Add(ПривозГруза.Names.ДатаДокумента, DateTime.Now, NsgComparison.LessOrEqual);
            cmp.Add(ПривозГруза.Names.ВидГруза, ВидГруза.Value);
            cmp.Add(ПривозГруза.Names.Объект, Объект.Value);
            cmp.Add(ПривозГруза.Names.НомерАвто, ВыбраннаяТехника.Value);
            cmp.Add(ПривозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            var документПривозГруза = ПривозГруза.Новый();

            if (!документПривозГруза.Find(cmp))
            {
                документПривозГруза.New();
                документПривозГруза.ДатаДокумента = DateTime.Now;
                документПривозГруза.Объект = Объект.Value;
                документПривозГруза.ВидГруза = ВидГруза.Value;
                документПривозГруза.ОбъемГруза = ОбъемГруза.Value;
                документПривозГруза.НомерАвто = ВыбраннаяТехника.Value.ГосНомер;
                документПривозГруза.Контрагент = ВыбраннаяТехника.Value.Подрядчик;
                документПривозГруза.Комментарий = Комментарий.Value;
                документПривозГруза.Handle();

                NsgSettings.MainForm.ShowMessage($"{ВыбраннаяТехника.Value} разгрузка успешно оформлена");
                NsgSettings.MainForm.ShowObject(документПривозГруза, this);
            }
            else
            {
                NsgSettings.MainForm.ShowMessage($"{ВыбраннаяТехника.Value} уже разгружена документом {документПривозГруза}");
                NsgSettings.MainForm.ShowObject(документПривозГруза, this);
            }

            ОбновитьСостояния();
        }

        private void nbПогрузка_AsyncClick(object sender, DoWorkEventArgs e)
        {
            if (ОбъемГруза.Value > 0)
            {
                var cmp = new NsgCompare();
                cmp.Add(ВывозГруза.Names.ДатаДокумента, ДатаПриезда.Value, NsgComparison.GreaterOrEqual);
                cmp.Add(ВывозГруза.Names.ДатаДокумента, DateTime.Now, NsgComparison.LessOrEqual);
                cmp.Add(ВывозГруза.Names.ВидГруза, ВидГруза.Value);
                cmp.Add(ВывозГруза.Names.Объект, Объект.Value);
                cmp.Add(ВывозГруза.Names.НомерАвто, ВыбраннаяТехника.Value);
                cmp.Add(ВывозГруза.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                var документВывозГруза = ВывозГруза.Новый();

                if (!документВывозГруза.Find(cmp))
                {
                    документВывозГруза.New();
                    документВывозГруза.ДатаДокумента = DateTime.Now;
                    документВывозГруза.Объект = Объект.Value;
                    документВывозГруза.ВидГруза = ВидГруза.Value;
                    документВывозГруза.ОбъемГруза = ОбъемГруза.Value;
                    документВывозГруза.НомерАвто = ВыбраннаяТехника.Value.ГосНомер;
                    документВывозГруза.Контрагент = ВыбраннаяТехника.Value.Подрядчик;
                    документВывозГруза.Комментарий = Комментарий.Value;
                    документВывозГруза.Handle();

                    NsgSettings.MainForm.ShowMessage($"{ВыбраннаяТехника.Value} погрузка успешно оформлена");
                    NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                }
                else
                {
                    NsgSettings.MainForm.ShowMessage($"{ВыбраннаяТехника.Value} уже оформлена погрузка {документВывозГруза}");
                    NsgSettings.MainForm.ShowObject(документВывозГруза, this);
                }

                ОбновитьСостояния();
            }
        }
    }
    


}