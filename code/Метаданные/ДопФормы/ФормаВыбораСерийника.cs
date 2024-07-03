using NsgSoft.DataObjects;
using NsgSoft.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechControl.Метаданные._SystemTables;
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;
using TechControl.Метаданные.УчетИнструмента;

namespace TechControl.Метаданные.ДопФормы
{
    public partial class ФормаВыбораСерийника : NsgReportForm
    {
        private string _выбранныйСерийник;

        public string ВыбранныйСерийник => _выбранныйСерийник;

        public ФормаВыбораСерийника()
        {
            InitializeComponent();
        }

        public ФормаВыбораСерийника(Номенклатура номенклатура, Объекты объект, ФизЛица сотрудник, string[] исключенныеСерийники) : this()
        {
            var reg = УчетИнструментаРегистрУчетИнструментаДвижения.Новый();
            var cmp = new NsgCompare();
            cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.НоменклатураИнструмента, номенклатура);
            if (объект.Selected)
            {
                cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.Объект, объект);
            }
            if (сотрудник.Selected)
            {
                cmp.Add(УчетИнструментаРегистрУчетИнструментаДвижения.Names.Сотрудник, сотрудник);
            }
            var всеДвижения = reg.FindAll(cmp);
            if (всеДвижения != null && всеДвижения.Length > 0)
            {
                ЗаполнитьДоступныеСерийники(всеДвижения, исключенныеСерийники);
            }
        }

        private void ЗаполнитьДоступныеСерийники(УчетИнструментаРегистрУчетИнструментаДвижения[] движения, string[] исключенныеСерийники) 
        {
            nsgVisualMultipleObject.Data.BeginUpdateData();
            nsgVisualMultipleObject.Data.MemoryTable.Clear();
            var всеСерийники = движения.Select(x => x.СерийныйНомер).Distinct().ToArray();
            всеСерийники = всеСерийники.Except(исключенныеСерийники).ToArray();
            var объект = движения.First().Объект;
            var сотрудник = движения.First().Сотрудник;

            var reg = РегистрУчетИнструмента.Новый();
            foreach (var номер in всеСерийники)
            {
                reg.New();
                reg.СерийныйНомер = номер;
                if (объект.Selected)
                {
                    reg.Объект = объект;
                }
                if (сотрудник.Selected)
                {
                    reg.Сотрудник = сотрудник;
                }
                
                if (reg.GetRest())
                {
                    var row = nsgVisualMultipleObject.Data.MemoryTable.NewRow();
                    row[СерийныйНомер].Value = номер;
                    row.Post();
                }
            }

            nsgVisualMultipleObject.Data.UpdateDataSync(this);
        }

        private void nsgIGrid1_CellEnter(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == СерийныйНомер.Name)
            {
                _выбранныйСерийник = e.RowObject[СерийныйНомер].ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
