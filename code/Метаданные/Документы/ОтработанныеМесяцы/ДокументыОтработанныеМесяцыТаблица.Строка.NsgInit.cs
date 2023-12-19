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
    public partial class ДокументыОтработанныеМесяцыТаблица
{
    [NsgTypeName("NsgDataTableRow", Guid = "8dcec5fe-e3c0-4dbc-9caf-80261c74f684")]
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
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("8dcec5fe-e3c0-4dbc-9caf-80261c74f684"));
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
            /// Техника
            /// </summary>
            public static String Техника
            {
                get
                {
                    return "Техника";
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
            /// Д2
            /// </summary>
            public static String Д2
            {
                get
                {
                    return "Д2";
                }
            }
            
            /// <summary>
            /// Тариф
            /// </summary>
            public static String Тариф
            {
                get
                {
                    return "Тариф";
                }
            }
            
            /// <summary>
            /// Д3
            /// </summary>
            public static String Д3
            {
                get
                {
                    return "Д3";
                }
            }
            
            /// <summary>
            /// Д14
            /// </summary>
            public static String Д14
            {
                get
                {
                    return "Д14";
                }
            }
            
            /// <summary>
            /// Д25
            /// </summary>
            public static String Д25
            {
                get
                {
                    return "Д25";
                }
            }
            
            /// <summary>
            /// Д27
            /// </summary>
            public static String Д27
            {
                get
                {
                    return "Д27";
                }
            }
            
            /// <summary>
            /// Д28
            /// </summary>
            public static String Д28
            {
                get
                {
                    return "Д28";
                }
            }
            
            /// <summary>
            /// Д29
            /// </summary>
            public static String Д29
            {
                get
                {
                    return "Д29";
                }
            }
            
            /// <summary>
            /// Д30
            /// </summary>
            public static String Д30
            {
                get
                {
                    return "Д30";
                }
            }
            
            /// <summary>
            /// Д31
            /// </summary>
            public static String Д31
            {
                get
                {
                    return "Д31";
                }
            }
            
            /// <summary>
            /// Д4
            /// </summary>
            public static String Д4
            {
                get
                {
                    return "Д4";
                }
            }
            
            /// <summary>
            /// Д5
            /// </summary>
            public static String Д5
            {
                get
                {
                    return "Д5";
                }
            }
            
            /// <summary>
            /// Д6
            /// </summary>
            public static String Д6
            {
                get
                {
                    return "Д6";
                }
            }
            
            /// <summary>
            /// Д7
            /// </summary>
            public static String Д7
            {
                get
                {
                    return "Д7";
                }
            }
            
            /// <summary>
            /// Д8
            /// </summary>
            public static String Д8
            {
                get
                {
                    return "Д8";
                }
            }
            
            /// <summary>
            /// Д9
            /// </summary>
            public static String Д9
            {
                get
                {
                    return "Д9";
                }
            }
            
            /// <summary>
            /// Д10
            /// </summary>
            public static String Д10
            {
                get
                {
                    return "Д10";
                }
            }
            
            /// <summary>
            /// Д11
            /// </summary>
            public static String Д11
            {
                get
                {
                    return "Д11";
                }
            }
            
            /// <summary>
            /// Д12
            /// </summary>
            public static String Д12
            {
                get
                {
                    return "Д12";
                }
            }
            
            /// <summary>
            /// Д13
            /// </summary>
            public static String Д13
            {
                get
                {
                    return "Д13";
                }
            }
            
            /// <summary>
            /// Д15
            /// </summary>
            public static String Д15
            {
                get
                {
                    return "Д15";
                }
            }
            
            /// <summary>
            /// Д16
            /// </summary>
            public static String Д16
            {
                get
                {
                    return "Д16";
                }
            }
            
            /// <summary>
            /// Д17
            /// </summary>
            public static String Д17
            {
                get
                {
                    return "Д17";
                }
            }
            
            /// <summary>
            /// Д18
            /// </summary>
            public static String Д18
            {
                get
                {
                    return "Д18";
                }
            }
            
            /// <summary>
            /// Д19
            /// </summary>
            public static String Д19
            {
                get
                {
                    return "Д19";
                }
            }
            
            /// <summary>
            /// Д20
            /// </summary>
            public static String Д20
            {
                get
                {
                    return "Д20";
                }
            }
            
            /// <summary>
            /// Д21
            /// </summary>
            public static String Д21
            {
                get
                {
                    return "Д21";
                }
            }
            
            /// <summary>
            /// Д22
            /// </summary>
            public static String Д22
            {
                get
                {
                    return "Д22";
                }
            }
            
            /// <summary>
            /// Д23
            /// </summary>
            public static String Д23
            {
                get
                {
                    return "Д23";
                }
            }
            
            /// <summary>
            /// Д24
            /// </summary>
            public static String Д24
            {
                get
                {
                    return "Д24";
                }
            }
            
            /// <summary>
            /// Д26
            /// </summary>
            public static String Д26
            {
                get
                {
                    return "Д26";
                }
            }
            
            /// <summary>
            /// Д1
            /// </summary>
            public static String Д1
            {
                get
                {
                    return "Д1";
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
                    descriptor.Name = "ДокументыОтработанныеМесяцыТаблица";
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
        [NsgReferentsFilterAttribute("Документы.ОтработанныеМесяцы")]
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
        /// Техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Техника Техника
        {
            get
            {
				 NsgDataTypedReference __Техника = ObjectList["Техника"] as NsgDataTypedReference;
                 return (Мониторинг.Техника)__Техника.Referent;
            }
            set
            {
                NsgDataTypedReference __Техника = ObjectList["Техника"] as NsgDataTypedReference;
                __Техника.Referent = value;
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
        /// Д2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д2
        {
            get
            {
				 NsgDataFloat __Д2 = ObjectList["Д2"] as NsgDataFloat;
                 return (System.Decimal)__Д2.Value;
            }
            set
            {
                NsgDataFloat __Д2 = ObjectList["Д2"] as NsgDataFloat;
                __Д2.Value = value;
            }
        }
        
        /// <summary>
        /// Тариф
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Тарифы Тариф
        {
            get
            {
				 NsgDataTypedReference __Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                 return (Мониторинг.Тарифы)__Тариф.Referent;
            }
            set
            {
                NsgDataTypedReference __Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                __Тариф.Referent = value;
            }
        }
        
        /// <summary>
        /// Д3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д3
        {
            get
            {
				 NsgDataFloat __Д3 = ObjectList["Д3"] as NsgDataFloat;
                 return (System.Decimal)__Д3.Value;
            }
            set
            {
                NsgDataFloat __Д3 = ObjectList["Д3"] as NsgDataFloat;
                __Д3.Value = value;
            }
        }
        
        /// <summary>
        /// Д14
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д14
        {
            get
            {
				 NsgDataFloat __Д14 = ObjectList["Д14"] as NsgDataFloat;
                 return (System.Decimal)__Д14.Value;
            }
            set
            {
                NsgDataFloat __Д14 = ObjectList["Д14"] as NsgDataFloat;
                __Д14.Value = value;
            }
        }
        
        /// <summary>
        /// Д25
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д25
        {
            get
            {
				 NsgDataFloat __Д25 = ObjectList["Д25"] as NsgDataFloat;
                 return (System.Decimal)__Д25.Value;
            }
            set
            {
                NsgDataFloat __Д25 = ObjectList["Д25"] as NsgDataFloat;
                __Д25.Value = value;
            }
        }
        
        /// <summary>
        /// Д27
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д27
        {
            get
            {
				 NsgDataFloat __Д27 = ObjectList["Д27"] as NsgDataFloat;
                 return (System.Decimal)__Д27.Value;
            }
            set
            {
                NsgDataFloat __Д27 = ObjectList["Д27"] as NsgDataFloat;
                __Д27.Value = value;
            }
        }
        
        /// <summary>
        /// Д28
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д28
        {
            get
            {
				 NsgDataFloat __Д28 = ObjectList["Д28"] as NsgDataFloat;
                 return (System.Decimal)__Д28.Value;
            }
            set
            {
                NsgDataFloat __Д28 = ObjectList["Д28"] as NsgDataFloat;
                __Д28.Value = value;
            }
        }
        
        /// <summary>
        /// Д29
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д29
        {
            get
            {
				 NsgDataFloat __Д29 = ObjectList["Д29"] as NsgDataFloat;
                 return (System.Decimal)__Д29.Value;
            }
            set
            {
                NsgDataFloat __Д29 = ObjectList["Д29"] as NsgDataFloat;
                __Д29.Value = value;
            }
        }
        
        /// <summary>
        /// Д30
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д30
        {
            get
            {
				 NsgDataFloat __Д30 = ObjectList["Д30"] as NsgDataFloat;
                 return (System.Decimal)__Д30.Value;
            }
            set
            {
                NsgDataFloat __Д30 = ObjectList["Д30"] as NsgDataFloat;
                __Д30.Value = value;
            }
        }
        
        /// <summary>
        /// Д31
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д31
        {
            get
            {
				 NsgDataFloat __Д31 = ObjectList["Д31"] as NsgDataFloat;
                 return (System.Decimal)__Д31.Value;
            }
            set
            {
                NsgDataFloat __Д31 = ObjectList["Д31"] as NsgDataFloat;
                __Д31.Value = value;
            }
        }
        
        /// <summary>
        /// Д4
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д4
        {
            get
            {
				 NsgDataFloat __Д4 = ObjectList["Д4"] as NsgDataFloat;
                 return (System.Decimal)__Д4.Value;
            }
            set
            {
                NsgDataFloat __Д4 = ObjectList["Д4"] as NsgDataFloat;
                __Д4.Value = value;
            }
        }
        
        /// <summary>
        /// Д5
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д5
        {
            get
            {
				 NsgDataFloat __Д5 = ObjectList["Д5"] as NsgDataFloat;
                 return (System.Decimal)__Д5.Value;
            }
            set
            {
                NsgDataFloat __Д5 = ObjectList["Д5"] as NsgDataFloat;
                __Д5.Value = value;
            }
        }
        
        /// <summary>
        /// Д6
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д6
        {
            get
            {
				 NsgDataFloat __Д6 = ObjectList["Д6"] as NsgDataFloat;
                 return (System.Decimal)__Д6.Value;
            }
            set
            {
                NsgDataFloat __Д6 = ObjectList["Д6"] as NsgDataFloat;
                __Д6.Value = value;
            }
        }
        
        /// <summary>
        /// Д7
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д7
        {
            get
            {
				 NsgDataFloat __Д7 = ObjectList["Д7"] as NsgDataFloat;
                 return (System.Decimal)__Д7.Value;
            }
            set
            {
                NsgDataFloat __Д7 = ObjectList["Д7"] as NsgDataFloat;
                __Д7.Value = value;
            }
        }
        
        /// <summary>
        /// Д8
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д8
        {
            get
            {
				 NsgDataFloat __Д8 = ObjectList["Д8"] as NsgDataFloat;
                 return (System.Decimal)__Д8.Value;
            }
            set
            {
                NsgDataFloat __Д8 = ObjectList["Д8"] as NsgDataFloat;
                __Д8.Value = value;
            }
        }
        
        /// <summary>
        /// Д9
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д9
        {
            get
            {
				 NsgDataFloat __Д9 = ObjectList["Д9"] as NsgDataFloat;
                 return (System.Decimal)__Д9.Value;
            }
            set
            {
                NsgDataFloat __Д9 = ObjectList["Д9"] as NsgDataFloat;
                __Д9.Value = value;
            }
        }
        
        /// <summary>
        /// Д10
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д10
        {
            get
            {
				 NsgDataFloat __Д10 = ObjectList["Д10"] as NsgDataFloat;
                 return (System.Decimal)__Д10.Value;
            }
            set
            {
                NsgDataFloat __Д10 = ObjectList["Д10"] as NsgDataFloat;
                __Д10.Value = value;
            }
        }
        
        /// <summary>
        /// Д11
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д11
        {
            get
            {
				 NsgDataFloat __Д11 = ObjectList["Д11"] as NsgDataFloat;
                 return (System.Decimal)__Д11.Value;
            }
            set
            {
                NsgDataFloat __Д11 = ObjectList["Д11"] as NsgDataFloat;
                __Д11.Value = value;
            }
        }
        
        /// <summary>
        /// Д12
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д12
        {
            get
            {
				 NsgDataFloat __Д12 = ObjectList["Д12"] as NsgDataFloat;
                 return (System.Decimal)__Д12.Value;
            }
            set
            {
                NsgDataFloat __Д12 = ObjectList["Д12"] as NsgDataFloat;
                __Д12.Value = value;
            }
        }
        
        /// <summary>
        /// Д13
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д13
        {
            get
            {
				 NsgDataFloat __Д13 = ObjectList["Д13"] as NsgDataFloat;
                 return (System.Decimal)__Д13.Value;
            }
            set
            {
                NsgDataFloat __Д13 = ObjectList["Д13"] as NsgDataFloat;
                __Д13.Value = value;
            }
        }
        
        /// <summary>
        /// Д15
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д15
        {
            get
            {
				 NsgDataFloat __Д15 = ObjectList["Д15"] as NsgDataFloat;
                 return (System.Decimal)__Д15.Value;
            }
            set
            {
                NsgDataFloat __Д15 = ObjectList["Д15"] as NsgDataFloat;
                __Д15.Value = value;
            }
        }
        
        /// <summary>
        /// Д16
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д16
        {
            get
            {
				 NsgDataFloat __Д16 = ObjectList["Д16"] as NsgDataFloat;
                 return (System.Decimal)__Д16.Value;
            }
            set
            {
                NsgDataFloat __Д16 = ObjectList["Д16"] as NsgDataFloat;
                __Д16.Value = value;
            }
        }
        
        /// <summary>
        /// Д17
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д17
        {
            get
            {
				 NsgDataFloat __Д17 = ObjectList["Д17"] as NsgDataFloat;
                 return (System.Decimal)__Д17.Value;
            }
            set
            {
                NsgDataFloat __Д17 = ObjectList["Д17"] as NsgDataFloat;
                __Д17.Value = value;
            }
        }
        
        /// <summary>
        /// Д18
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д18
        {
            get
            {
				 NsgDataFloat __Д18 = ObjectList["Д18"] as NsgDataFloat;
                 return (System.Decimal)__Д18.Value;
            }
            set
            {
                NsgDataFloat __Д18 = ObjectList["Д18"] as NsgDataFloat;
                __Д18.Value = value;
            }
        }
        
        /// <summary>
        /// Д19
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д19
        {
            get
            {
				 NsgDataFloat __Д19 = ObjectList["Д19"] as NsgDataFloat;
                 return (System.Decimal)__Д19.Value;
            }
            set
            {
                NsgDataFloat __Д19 = ObjectList["Д19"] as NsgDataFloat;
                __Д19.Value = value;
            }
        }
        
        /// <summary>
        /// Д20
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д20
        {
            get
            {
				 NsgDataFloat __Д20 = ObjectList["Д20"] as NsgDataFloat;
                 return (System.Decimal)__Д20.Value;
            }
            set
            {
                NsgDataFloat __Д20 = ObjectList["Д20"] as NsgDataFloat;
                __Д20.Value = value;
            }
        }
        
        /// <summary>
        /// Д21
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д21
        {
            get
            {
				 NsgDataFloat __Д21 = ObjectList["Д21"] as NsgDataFloat;
                 return (System.Decimal)__Д21.Value;
            }
            set
            {
                NsgDataFloat __Д21 = ObjectList["Д21"] as NsgDataFloat;
                __Д21.Value = value;
            }
        }
        
        /// <summary>
        /// Д22
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д22
        {
            get
            {
				 NsgDataFloat __Д22 = ObjectList["Д22"] as NsgDataFloat;
                 return (System.Decimal)__Д22.Value;
            }
            set
            {
                NsgDataFloat __Д22 = ObjectList["Д22"] as NsgDataFloat;
                __Д22.Value = value;
            }
        }
        
        /// <summary>
        /// Д23
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д23
        {
            get
            {
				 NsgDataFloat __Д23 = ObjectList["Д23"] as NsgDataFloat;
                 return (System.Decimal)__Д23.Value;
            }
            set
            {
                NsgDataFloat __Д23 = ObjectList["Д23"] as NsgDataFloat;
                __Д23.Value = value;
            }
        }
        
        /// <summary>
        /// Д24
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д24
        {
            get
            {
				 NsgDataFloat __Д24 = ObjectList["Д24"] as NsgDataFloat;
                 return (System.Decimal)__Д24.Value;
            }
            set
            {
                NsgDataFloat __Д24 = ObjectList["Д24"] as NsgDataFloat;
                __Д24.Value = value;
            }
        }
        
        /// <summary>
        /// Д26
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д26
        {
            get
            {
				 NsgDataFloat __Д26 = ObjectList["Д26"] as NsgDataFloat;
                 return (System.Decimal)__Д26.Value;
            }
            set
            {
                NsgDataFloat __Д26 = ObjectList["Д26"] as NsgDataFloat;
                __Д26.Value = value;
            }
        }
        
        /// <summary>
        /// Д1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д1
        {
            get
            {
				 NsgDataFloat __Д1 = ObjectList["Д1"] as NsgDataFloat;
                 return (System.Decimal)__Д1.Value;
            }
            set
            {
                NsgDataFloat __Д1 = ObjectList["Д1"] as NsgDataFloat;
                __Д1.Value = value;
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
