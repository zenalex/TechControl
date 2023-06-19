using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.Метаданные.Учет;

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    public partial class КомплектыСпецодеждыФормаЭлемента

    {
        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            var cmp = НоменклатураСпецодеждыИСИЗ.SearchCondition;
            cmp.Add(Номенклатура.Names.ТипНоменклатуры, ТипНоменклатуры.Спецодежда);
            cmp.Add(Номенклатура.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);

            base.OnSetFormObject(formObject);
        }

        public КомплектыСпецодеждыФормаЭлемента()
        {
            InitializeComponent();
		}

	}
    


}