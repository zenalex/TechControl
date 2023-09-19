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

        public int ПолучитьКоличествоМесяцевИзПериода(ВидыПериодов видПериода)
        {
            if (видПериода == ВидыПериодов.Год)
            {
                return 12;
            }
            else if (видПериода == ВидыПериодов.Полугодие)
            {
                return 6;
            }
            else if (видПериода == ВидыПериодов.Квартал)
            {
                return 3;
            }
            else 
            {
                return 1;
            }
        }

        public ВидыПериодов ПолучитьВидПериодаПоКоличествуМесяцев(int количествоМесяцев)
        {
            if (количествоМесяцев % 12 == 0)
            {
                return ВидыПериодов.Год;
            }
            else if (количествоМесяцев % 6 == 0)
            {
                return ВидыПериодов.Полугодие;
            }
            else if (количествоМесяцев % 3 == 0)
            {
                return ВидыПериодов.Квартал;
            }
            else
            {
                return ВидыПериодов.Месяц;
            }
        }
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
