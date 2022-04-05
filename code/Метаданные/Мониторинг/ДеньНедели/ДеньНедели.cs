using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Common;


namespace TechControl.Метаданные.Мониторинг
{
    
    public partial class ДеньНедели
	{
		#region Данные
		#endregion //Данные

		#region Конструкторы
		#endregion //Конструкторы

		#region Свойства
		#endregion //Свойства

		#region Методы
		public static Dictionary<DayOfWeek, ДеньНедели> ByDayOfWeek = new Dictionary<DayOfWeek, ДеньНедели>()
		{
			[System.DayOfWeek.Monday] = ДеньНедели.Понедельник,
			[System.DayOfWeek.Tuesday] = ДеньНедели.Вторник,
			[System.DayOfWeek.Wednesday] = ДеньНедели.Среда,
			[System.DayOfWeek.Thursday] = ДеньНедели.Четверг,
			[System.DayOfWeek.Friday] = ДеньНедели.Пятница,
			[System.DayOfWeek.Saturday] = ДеньНедели.Суббота,
			[System.DayOfWeek.Sunday] = ДеньНедели.Воскресенье
		};
		#endregion //Методы
	}
    
}
