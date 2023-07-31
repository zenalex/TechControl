using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using System.IO;
using NsgSoft.Common;
using TechControl.Метаданные.УчетСпецодеждыИСИЗ;
using TechControl.Метаданные.Перечисления;

namespace TechControl.Метаданные
{
    public partial class Метаданные
    {

        public Dictionary<ЗаявкаНаСотрудника, СтатусыЗаявокНаСотрудника> СтатусыДоИзменения = new Dictionary<ЗаявкаНаСотрудника, СтатусыЗаявокНаСотрудника>();
        #region Данные
        #endregion //Данные

        #region Конструкторы
        /// <summary>
        /// Создание объекта
        /// </summary>
        public Метаданные()
            : base()
        {
            InitializeComponent();
        }
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        #endregion //Методы
    }
}
