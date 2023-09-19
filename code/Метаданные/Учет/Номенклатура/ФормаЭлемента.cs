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





namespace TechControl.Метаданные.Учет
{
    
    public partial class НоменклатураФормаЭлемента

    {
        public НоменклатураФормаЭлемента()
        {
            InitializeComponent();
		}

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            if (formObject != null)
            {
                vmoАмортизация.ReadOnly = false;
                if (vmoАмортизация.Data.CurrentRow == null)
                {
                    vmoАмортизация.Data.CurrentRow = vmoАмортизация.Data.MemoryTable.NewRow();
                    if (formObject is Номенклатура номенклатура)
                    {
                        if (номенклатура.ПланАмортизации.Selected)
                        {
                            СрокАмортизации_vmoАмортизация.Value = номенклатура.ПланАмортизации.СрокАмортизацииМес;
                            КоличествоПериодов_vmoАмортизация.Value = номенклатура.ПланАмортизации.КоличествоПериодов;
                        }
                    }
                }
                vmoАмортизация.ReadOnly = nsgVisualMultipleObject.ReadOnly;
            }
        }

        private void nsgVisualMultipleObject_ReadOnlyChanged(object sender, bool isNowReadOnly)
        {
            vmoАмортизация.ReadOnly = nsgVisualMultipleObject.ReadOnly;
        }

        private void nsgInput11_EndEdit(object sender, EndEditEventArgs e)
        {
            ЗаполнитьЗначенияСрокаИКоличестваПериодов();
            НайтиИлиСоздатьПланАмортизации();
        }

        private void НайтиИлиСоздатьПланАмортизации() 
        {
            if (СрокАмортизации_vmoАмортизация.Value != 0 && КоличествоПериодов_vmoАмортизация.Value != 0)
            {
                if (!(ПланАмортизации.Value.Selected 
                    && ПланАмортизации.Value.СрокАмортизацииМес == СрокАмортизации_vmoАмортизация.Value 
                    && ПланАмортизации.Value.КоличествоПериодов == КоличествоПериодов_vmoАмортизация.Value))
                {
                    var cmp = new NsgCompare();
                    cmp.Add(ПланыАмортизации.Names.СрокАмортизацииМес, СрокАмортизации_vmoАмортизация.Value);
                    cmp.Add(ПланыАмортизации.Names.КоличествоПериодов, КоличествоПериодов_vmoАмортизация.Value);
                    cmp.Add(ПланыАмортизации.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

                    var план = ПланыАмортизации.Новый();
                    if (!план.Find(cmp))
                    {
                        план.New();
                        план.Наименование = $"{СрокАмортизации_vmoАмортизация.Value} на {КоличествоПериодов_vmoАмортизация.Value}";
                        план.СрокАмортизацииМес = СрокАмортизации_vmoАмортизация.Value;
                        план.КоличествоПериодов = КоличествоПериодов_vmoАмортизация.Value;
                        план.Post();
                    }

                    ПланАмортизации.Value = план;
                }
            }
        }

        private void nsgInput12_EndEdit(object sender, EndEditEventArgs e)
        {
            ЗаполнитьЗначенияСрокаИКоличестваПериодов();
            НайтиИлиСоздатьПланАмортизации();
        }

        private void nsgInput7_Selected(object sender, EventArgs e)
        {
            if (ПланАмортизации.Value.Selected)
            {
                if (vmoАмортизация.ReadOnly)
                {
                    vmoАмортизация.ReadOnly = false;
                }

                СрокАмортизации_vmoАмортизация.Value = ПланАмортизации.Value.СрокАмортизацииМес;
                КоличествоПериодов_vmoАмортизация.Value = ПланАмортизации.Value.КоличествоПериодов;
                var месяцевВПериоде = (int)(СрокАмортизации_vmoАмортизация.Value / КоличествоПериодов_vmoАмортизация.Value);
                ПериодАмортизации_vmoАмортизация.Value = Метаданные.Новый().ПолучитьВидПериодаПоКоличествуМесяцев(месяцевВПериоде);
            }
        }

        private void nsgInput13_EndEdit(object sender, EndEditEventArgs e)
        {
            ЗаполнитьЗначенияСрокаИКоличестваПериодов();
            НайтиИлиСоздатьПланАмортизации();
        }

        private void ЗаполнитьЗначенияСрокаИКоличестваПериодов() 
        {
            if (СрокАмортизации_vmoАмортизация.Value != 0)
            {
                var месяцевВПериоде = Метаданные.Новый().ПолучитьКоличествоМесяцевИзПериода(ПериодАмортизации_vmoАмортизация.Value);
                var срокАмортизации = СрокАмортизации_vmoАмортизация.Value;
                if (срокАмортизации < месяцевВПериоде)
                {
                    срокАмортизации = месяцевВПериоде;
                }
                var количествоПериодов = (int)срокАмортизации / месяцевВПериоде;
                if (срокАмортизации % месяцевВПериоде != 0)
                {
                    срокАмортизации = количествоПериодов * месяцевВПериоде;
                    NsgSettings.MainForm.ShowMessage("Изменен срок амортизации");
                }
                СрокАмортизации_vmoАмортизация.Value = срокАмортизации;
                КоличествоПериодов_vmoАмортизация.Value = количествоПериодов;
            }
            else if (КоличествоПериодов_vmoАмортизация.Value != 0)
            {
                var месяцевВПериоде = Метаданные.Новый().ПолучитьКоличествоМесяцевИзПериода(ПериодАмортизации_vmoАмортизация.Value);
                var количествоПериодов = КоличествоПериодов_vmoАмортизация.Value;
                var срокАмортизации = количествоПериодов * месяцевВПериоде;

                СрокАмортизации_vmoАмортизация.Value = срокАмортизации;
                КоличествоПериодов_vmoАмортизация.Value = количествоПериодов;
            }
        }
    }
    


}