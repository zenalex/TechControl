using NsgSoft.Common;
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
using TechControl.Метаданные.Мониторинг;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.ДопФормы
{
    public partial class ФормаВыбораРазмера : NsgReportForm
    {
        private Размеры _размер;
        private Размеры _выбранныйРазмер;
        private Размеры _размерМеньший;
        private Размеры _размерБольший;
        private Объекты _объект;
        private decimal _количество;
        private string _размерИмя = "Размер";

        //public Размеры ПодходящийРазмер => _размер;
        //public Размеры БольшийРазмер => _размерБольший;
        //public Размеры МеньшийРазмер => _размерМеньший;
        public Размеры ВыбранныйРазмер => _выбранныйРазмер;
        public decimal КоличествоВыбрано => _количество;

        public ФормаВыбораРазмера() 
        {
            InitializeComponent();
        }

        public ФормаВыбораРазмера(Номенклатура номенклатура, Сотрудники сотрудник, Объекты объект) : this()
        {
            _размер = сотрудник.ПолучитьРазмер(номенклатура);
            if (_размер.Selected)
            {
                
                var memTable = new NsgMemoryTable(Метаданные.Новый());
                memTable.AddColumn(_размерИмя, typeof(Размеры));

                var row = memTable.NewRow();
                row[_размерИмя].Value = _размер;
                row.Post();

                _размерМеньший = _размер.ПолучитьМеньший();
                if (_размерМеньший.Selected)
                {
                    var rowМеньший = memTable.NewRow();
                    rowМеньший[_размерИмя].Value = _размерМеньший;
                    rowМеньший.Post();
                }

                _размерБольший = _размер.ПолучитьБольший();
                if (_размерБольший.Selected)
                {
                    var rowБольший = memTable.NewRow();
                    rowБольший[_размерИмя].Value = _размерБольший;
                    rowБольший.Post();
                }

                ЗаполнитьОстатки(memTable, номенклатура, объект);
            }
        }

        private void ЗаполнитьОстатки(NsgMemoryTable table, Номенклатура номенклатура, Объекты объект) 
        {
            var reg = ОстаткиНоменклатуры.Новый();
            _объект = объект;

            var col = table.AddColumn(объект.Наименование, typeof(decimal));
            col.Visible = true;
            col.ReadOnly = true;

            //nsgVisualMultipleObject.Data.BeginUpdateData();
            
            foreach (var row in table.AllRows)
            {
                var размер = row[_размерИмя].ToReferent() as Размеры;
                reg.Номенклатура = номенклатура;
                reg.Размер = размер;
                reg.Объект = объект;
                reg.GetRest();
                row[объект.Наименование].Value = reg.Количество;

                reg.New();
                var cmp = new NsgCompare();
                cmp.Add(ОстаткиНоменклатуры.Names.Номенклатура, номенклатура);
                cmp.Add(ОстаткиНоменклатуры.Names.Размер, размер);
                //var остатки = reg.GetCirculate(DateTime.Now, DateTime.Now,cmp,NsgRegisterResult.All ,ОстаткиНоменклатуры.Names.Объект, ОстаткиНоменклатуры.Names.Количество);
                var остатки = reg.GetRests(DateTime.Now, cmp, ОстаткиНоменклатуры.Names.Объект);
                foreach (var item in остатки.AllRows)
                {
                    var количество = item[ОстаткиНоменклатуры.Names.Количество].ToEnd();
                    var количество1 = item[ОстаткиНоменклатуры.Names.Количество].ToBegin();
                    var количество2 = item[ОстаткиНоменклатуры.Names.Количество].ToDebit();
                    var количество3 = item[ОстаткиНоменклатуры.Names.Количество].ToCredit();
                    if (количество1 > 0)
                    {
                        var объектДобавочный = item[ОстаткиНоменклатуры.Names.Объект].ToReferent() as Объекты;
                        if (!table.AllFieldNamesForSearch.Contains(объектДобавочный.Наименование))
                        {
                            var colAdd = table.AddColumn(объектДобавочный.Наименование, typeof(decimal));
                            colAdd.Visible = true;
                            colAdd.ReadOnly = true;
                        }
                        
                        row[объектДобавочный.Наименование].Value = количество1;
                    }
                }
            }
            
            nsgVisualMultipleObject.Data.MemoryTable = table;
            nsgIGrid1.BeginUpdateStructure();
            nsgIGrid1.getColumnsFromSourceObject(true);
            nsgIGrid1.EndUpdateStructure(true);
            nsgIGrid1.ReloadData();
        }

        private void nsgIGrid1_CellEnter(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == _объект.Наименование)
            {
                _выбранныйРазмер = e.RowObject[_размерИмя].ToReferent() as Размеры;
                _количество = e.RowObject[_объект.Наименование].ToDecimal();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void nsgIGrid1_CellActivated(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == _объект.Наименование)
            {
                //_выбранныйРазмер = e.RowObject[_размерИмя].ToReferent() as Размеры;
                //_количество = e.RowObject[_объект.Наименование].ToDecimal();
                //DialogResult = DialogResult.OK;
                //this.Close();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void nsgIGrid1_GetAvailableTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.None;
        }
    }
}
