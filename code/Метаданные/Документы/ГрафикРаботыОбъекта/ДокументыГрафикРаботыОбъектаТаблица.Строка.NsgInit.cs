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
    public partial class ДокументыГрафикРаботыОбъектаТаблица
{
    [NsgTypeName("NsgDataTableRow", Guid = "1e47e65a-df14-4b73-96d7-0dc7cdf6be70")]
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
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("1e47e65a-df14-4b73-96d7-0dc7cdf6be70"));
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
            /// Дата конкретный день
            /// </summary>
            public static String ДатаКонкретныйДень
            {
                get
                {
                    return "ДатаКонкретныйДень";
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
            /// Должность
            /// </summary>
            public static String Должность
            {
                get
                {
                    return "Должность";
                }
            }
            
            /// <summary>
            /// Группа спец техники
            /// </summary>
            public static String ГруппаСпецТехники
            {
                get
                {
                    return "ГруппаСпецТехники";
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
            
            /// <summary>
            /// Выходной
            /// </summary>
            public static String Выходной
            {
                get
                {
                    return "Выходной";
                }
            }
            
            /// <summary>
            /// Длительность смены1 ВЧасах
            /// </summary>
            public static String ДлительностьСмены1ВЧасах
            {
                get
                {
                    return "ДлительностьСмены1ВЧасах";
                }
            }
            
            /// <summary>
            /// Количество
            /// </summary>
            public static String Количество
            {
                get
                {
                    return "Количество";
                }
            }
            
            /// <summary>
            /// Код группы
            /// </summary>
            public static String КодГруппы
            {
                get
                {
                    return "КодГруппы";
                }
            }
            
            /// <summary>
            /// Вид режима работы
            /// </summary>
            public static String ВидРежимаРаботы
            {
                get
                {
                    return "ВидРежимаРаботы";
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
                    descriptor.Name = "ДокументыГрафикРаботыОбъектаТаблица";
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
        [NsgReferentsFilterAttribute("Документы.ГрафикРаботыОбъекта")]
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
        /// Дата конкретный день
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаКонкретныйДень
        {
            get
            {
				 NsgDataDateTime __ДатаКонкретныйДень = ObjectList["ДатаКонкретныйДень"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаКонкретныйДень.Value;
            }
            set
            {
                NsgDataDateTime __ДатаКонкретныйДень = ObjectList["ДатаКонкретныйДень"] as NsgDataDateTime;
                __ДатаКонкретныйДень.Value = value;
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
        /// Должность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Должности Должность
        {
            get
            {
				 NsgDataTypedReference __Должность = ObjectList["Должность"] as NsgDataTypedReference;
                 return (Мониторинг.Должности)__Должность.Referent;
            }
            set
            {
                NsgDataTypedReference __Должность = ObjectList["Должность"] as NsgDataTypedReference;
                __Должность.Referent = value;
            }
        }
        
        /// <summary>
        /// Группа спец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
        {
            get
            {
				 NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                 return (Мониторинг.ГруппыСпецТехники)__ГруппаСпецТехники.Referent;
            }
            set
            {
                NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                __ГруппаСпецТехники.Referent = value;
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
        
        /// <summary>
        /// Выходной
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Выходной
        {
            get
            {
				 NsgDataBoolean __Выходной = ObjectList["Выходной"] as NsgDataBoolean;
                 return (System.Boolean)__Выходной.Value;
            }
            set
            {
                NsgDataBoolean __Выходной = ObjectList["Выходной"] as NsgDataBoolean;
                __Выходной.Value = value;
            }
        }
        
        /// <summary>
        /// Длительность смены1 ВЧасах
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлительностьСмены1ВЧасах
        {
            get
            {
				 NsgDataFloat __ДлительностьСмены1ВЧасах = ObjectList["ДлительностьСмены1ВЧасах"] as NsgDataFloat;
                 return (System.Decimal)__ДлительностьСмены1ВЧасах.Value;
            }
            set
            {
                NsgDataFloat __ДлительностьСмены1ВЧасах = ObjectList["ДлительностьСмены1ВЧасах"] as NsgDataFloat;
                __ДлительностьСмены1ВЧасах.Value = value;
            }
        }
        
        /// <summary>
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Количество
        {
            get
            {
				 NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                 return (System.Int64)__Количество.Value;
            }
            set
            {
                NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                __Количество.Value = value;
            }
        }
        
        /// <summary>
        /// Код группы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String КодГруппы
        {
            get
            {
				 NsgDataString __КодГруппы = ObjectList["КодГруппы"] as NsgDataString;
                 return (System.String)__КодГруппы.Value;
            }
            set
            {
                NsgDataString __КодГруппы = ObjectList["КодГруппы"] as NsgDataString;
                __КодГруппы.Value = value;
            }
        }
        
        /// <summary>
        /// Вид режима работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Перечисления.ВидыРежимовРаботы ВидРежимаРаботы
        {
            get
            {
				 NsgDataEnumReference __ВидРежимаРаботы = ObjectList["ВидРежимаРаботы"] as NsgDataEnumReference;
                 return (Перечисления.ВидыРежимовРаботы)__ВидРежимаРаботы.Referent;
            }
            set
            {
                NsgDataEnumReference __ВидРежимаРаботы = ObjectList["ВидРежимаРаботы"] as NsgDataEnumReference;
                __ВидРежимаРаботы.Referent = value;
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
