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
    public partial class УчетОстаткиНоменклатурыДвижения
{
    [NsgTypeName("NsgDataTableRow", Guid = "abe89d6c-5115-45d9-9372-2b0033d03869")]
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
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("abe89d6c-5115-45d9-9372-2b0033d03869"));
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
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
                }
            }
            
            /// <summary>
            /// Вид движения
            /// </summary>
            public static String ВидДвижения
            {
                get
                {
                    return "ВидДвижения";
                }
            }
            
            /// <summary>
            /// Активность
            /// </summary>
            public static String Активность
            {
                get
                {
                    return "Активность";
                }
            }
            
            /// <summary>
            /// Номенклатура
            /// </summary>
            public static String Номенклатура
            {
                get
                {
                    return "Номенклатура";
                }
            }
            
            /// <summary>
            /// Свойство номенклатуры
            /// </summary>
            public static String СвойствоНоменклатуры
            {
                get
                {
                    return "СвойствоНоменклатуры";
                }
            }
            
            /// <summary>
            /// Сотрудник
            /// </summary>
            public static String Сотрудник
            {
                get
                {
                    return "Сотрудник";
                }
            }
            
            /// <summary>
            /// Объект
            /// </summary>
            public static String Объект
            {
                get
                {
                    return "Объект";
                }
            }
            
            /// <summary>
            /// Стоимость
            /// </summary>
            public static String Стоимость
            {
                get
                {
                    return "Стоимость";
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
                    descriptor.Name = "УчетОстаткиНоменклатурыДвижения";
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра")]
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
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Вид движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.ВидыДвижений ВидДвижения
        {
            get
            {
				 NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                 return (Сервис.ВидыДвижений)__ВидДвижения.Referent;
            }
            set
            {
                NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                __ВидДвижения.Referent = value;
            }
        }
        
        /// <summary>
        /// Активность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Активность
        {
            get
            {
				 NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                 return (System.Boolean)__Активность.Value;
            }
            set
            {
                NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                __Активность.Value = value;
            }
        }
        
        /// <summary>
        /// Номенклатура
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Номенклатура Номенклатура
        {
            get
            {
				 NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                 return (Учет.Номенклатура)__Номенклатура.Referent;
            }
            set
            {
                NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                __Номенклатура.Referent = value;
            }
        }
        
        /// <summary>
        /// Свойство номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.СвойствоНоменклатуры СвойствоНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __СвойствоНоменклатуры = ObjectList["СвойствоНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.СвойствоНоменклатуры)__СвойствоНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __СвойствоНоменклатуры = ObjectList["СвойствоНоменклатуры"] as NsgDataTypedReference;
                __СвойствоНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Сотрудник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Сотрудники Сотрудник
        {
            get
            {
				 NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                 return (Мониторинг.Сотрудники)__Сотрудник.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                __Сотрудник.Referent = value;
            }
        }
        
        /// <summary>
        /// Объект
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Объекты Объект
        {
            get
            {
				 NsgDataTypedReference __Объект = ObjectList["Объект"] as NsgDataTypedReference;
                 return (Мониторинг.Объекты)__Объект.Referent;
            }
            set
            {
                NsgDataTypedReference __Объект = ObjectList["Объект"] as NsgDataTypedReference;
                __Объект.Referent = value;
            }
        }
        
        /// <summary>
        /// Стоимость
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Стоимость
        {
            get
            {
				 NsgDataFloat __Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                 return (System.Decimal)__Стоимость.Value;
            }
            set
            {
                NsgDataFloat __Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                __Стоимость.Value = value;
            }
        }
        
        /// <summary>
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Количество
        {
            get
            {
				 NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                 return (System.Decimal)__Количество.Value;
            }
            set
            {
                NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                __Количество.Value = value;
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
