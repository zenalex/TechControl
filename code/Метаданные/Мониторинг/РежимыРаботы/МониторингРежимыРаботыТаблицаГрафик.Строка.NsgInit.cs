using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace TechControl.Метаданные._SystemTables
{
    public partial class МониторингРежимыРаботыТаблицаГрафик
{
    [NsgTypeName("NsgDataTableRow", Guid = "5b76beb8-0f1f-481a-9451-f4c3126624a9")]
    public partial class Строка : NsgSoft.DataObjects.NsgDataTableRow
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTableRow
        

		/// <summary>
        /// "Пустой" конструктор для строки таблицы, необходимо указание таблицы которой принадлежит строка
        /// </summary>
        public Строка(NsgDataTable owner)
            : base(owner)
        {
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTableRow

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Строка()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Строка(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Строка Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("5b76beb8-0f1f-481a-9451-f4c3126624a9"));
            if (obj == null)
                obj = new Строка();
            return obj as Строка;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

            if (NsgSettings.Regime != NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
        



			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

			#region заполнение полей класса
			
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTableRow
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTableRow

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTableRow.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Владелец
            /// </summary>
            public static String Владелец
            {
                get
                {
                    return "Владелец";
                }
            }
            
            /// <summary>
            /// Номер строки
            /// </summary>
            public static String НомерСтроки
            {
                get
                {
                    return "НомерСтроки";
                }
            }
            
            /// <summary>
            /// День недели
            /// </summary>
            public static String ДеньНедели
            {
                get
                {
                    return "ДеньНедели";
                }
            }
            
            /// <summary>
            /// Время начала рабочего дня
            /// </summary>
            public static String ВремяНачалаРабочегоДня
            {
                get
                {
                    return "ВремяНачалаРабочегоДня";
                }
            }
            
            /// <summary>
            /// Время конца рабочего дня
            /// </summary>
            public static String ВремяКонцаРабочегоДня
            {
                get
                {
                    return "ВремяКонцаРабочегоДня";
                }
            }
            
            /// <summary>
            /// Время начала перерыва
            /// </summary>
            public static String ВремяНачалаПерерыва
            {
                get
                {
                    return "ВремяНачалаПерерыва";
                }
            }
            
            /// <summary>
            /// Время конца перерыва
            /// </summary>
            public static String ВремяКонцаПерерыва
            {
                get
                {
                    return "ВремяКонцаПерерыва";
                }
            }
            
            /// <summary>
            /// Время окончания смены1
            /// </summary>
            public static String ВремяОкончанияСмены1
            {
                get
                {
                    return "ВремяОкончанияСмены1";
                }
            }
            
            /// <summary>
            /// Время начала смены2
            /// </summary>
            public static String ВремяНачалаСмены2
            {
                get
                {
                    return "ВремяНачалаСмены2";
                }
            }
            
            /// <summary>
            /// Время начала смены3
            /// </summary>
            public static String ВремяНачалаСмены3
            {
                get
                {
                    return "ВремяНачалаСмены3";
                }
            }
            
            /// <summary>
            /// Время окончания смены2
            /// </summary>
            public static String ВремяОкончанияСмены2
            {
                get
                {
                    return "ВремяОкончанияСмены2";
                }
            }
            
            /// <summary>
            /// Время окончания смены3
            /// </summary>
            public static String ВремяОкончанияСмены3
            {
                get
                {
                    return "ВремяОкончанияСмены3";
                }
            }
            
            /// <summary>
            /// Количество смен
            /// </summary>
            public static String КоличествоСмен
            {
                get
                {
                    return "КоличествоСмен";
                }
            }
            
            /// <summary>
            /// Время начала смены1
            /// </summary>
            public static String ВремяНачалаСмены1
            {
                get
                {
                    return "ВремяНачалаСмены1";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "МониторингРежимыРаботыТаблицаГрафик";
                    descriptor.GroupName = "_SystemTables";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "_SystemTables.Строка";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Мониторинг.РежимыРаботы")]
        public NsgSoft.DataObjects.NsgReferencedObject Владелец
        {
            get
            {
				 NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__Владелец.Referent;
            }
            set
            {
                NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                __Владелец.Referent = value;
            }
        }
        
        /// <summary>
        /// Номер строки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСтроки
        {
            get
            {
				 NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                 return (System.Int64)__НомерСтроки.Value;
            }
            set
            {
                NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                __НомерСтроки.Value = value;
            }
        }
        
        /// <summary>
        /// День недели
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ДеньНедели ДеньНедели
        {
            get
            {
				 NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                 return (Мониторинг.ДеньНедели)__ДеньНедели.Referent;
            }
            set
            {
                NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                __ДеньНедели.Referent = value;
            }
        }
        
        /// <summary>
        /// Время начала рабочего дня
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаРабочегоДня
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаРабочегоДня = ObjectList["ВремяНачалаРабочегоДня"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаРабочегоДня.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаРабочегоДня = ObjectList["ВремяНачалаРабочегоДня"] as NsgDataDateTime;
                __ВремяНачалаРабочегоДня.Value = value;
            }
        }
        
        /// <summary>
        /// Время конца рабочего дня
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяКонцаРабочегоДня
        {
            get
            {
				 NsgDataDateTime __ВремяКонцаРабочегоДня = ObjectList["ВремяКонцаРабочегоДня"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяКонцаРабочегоДня.Value;
            }
            set
            {
                NsgDataDateTime __ВремяКонцаРабочегоДня = ObjectList["ВремяКонцаРабочегоДня"] as NsgDataDateTime;
                __ВремяКонцаРабочегоДня.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала перерыва
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаПерерыва
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаПерерыва = ObjectList["ВремяНачалаПерерыва"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаПерерыва.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаПерерыва = ObjectList["ВремяНачалаПерерыва"] as NsgDataDateTime;
                __ВремяНачалаПерерыва.Value = value;
            }
        }
        
        /// <summary>
        /// Время конца перерыва
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяКонцаПерерыва
        {
            get
            {
				 NsgDataDateTime __ВремяКонцаПерерыва = ObjectList["ВремяКонцаПерерыва"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяКонцаПерерыва.Value;
            }
            set
            {
                NsgDataDateTime __ВремяКонцаПерерыва = ObjectList["ВремяКонцаПерерыва"] as NsgDataDateTime;
                __ВремяКонцаПерерыва.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены1
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены1 = ObjectList["ВремяОкончанияСмены1"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены1.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены1 = ObjectList["ВремяОкончанияСмены1"] as NsgDataDateTime;
                __ВремяОкончанияСмены1.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены2
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены2.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                __ВремяНачалаСмены2.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены3
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены3.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                __ВремяНачалаСмены3.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены2
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены2 = ObjectList["ВремяОкончанияСмены2"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены2.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены2 = ObjectList["ВремяОкончанияСмены2"] as NsgDataDateTime;
                __ВремяОкончанияСмены2.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены3
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены3 = ObjectList["ВремяОкончанияСмены3"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены3.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены3 = ObjectList["ВремяОкончанияСмены3"] as NsgDataDateTime;
                __ВремяОкончанияСмены3.Value = value;
            }
        }
        
        /// <summary>
        /// Количество смен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоСмен
        {
            get
            {
				 NsgDataInteger __КоличествоСмен = ObjectList["КоличествоСмен"] as NsgDataInteger;
                 return (System.Int64)__КоличествоСмен.Value;
            }
            set
            {
                NsgDataInteger __КоличествоСмен = ObjectList["КоличествоСмен"] as NsgDataInteger;
                __КоличествоСмен.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены1
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены1.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                __ВремяНачалаСмены1.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTableRow
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataTableRow

        #region Методы NsgMultipleObject
        private Строка[] convertArray(NsgMultipleObject[] array)
        {
            Строка[] res = new Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Строка(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(Строка);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Строка Value
            {
                get
                {
                    return (Строка)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgDataTableRow";
                }
            }
        }

    }
}
}
