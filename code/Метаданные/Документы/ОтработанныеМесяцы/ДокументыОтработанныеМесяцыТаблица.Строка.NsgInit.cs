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
            /// 2
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
            /// 3
            /// </summary>
            public static String Д3
            {
                get
                {
                    return "Д3";
                }
            }
            
            /// <summary>
            /// 14
            /// </summary>
            public static String Д14
            {
                get
                {
                    return "Д14";
                }
            }
            
            /// <summary>
            /// 25
            /// </summary>
            public static String Д25
            {
                get
                {
                    return "Д25";
                }
            }
            
            /// <summary>
            /// 27
            /// </summary>
            public static String Д27
            {
                get
                {
                    return "Д27";
                }
            }
            
            /// <summary>
            /// 28
            /// </summary>
            public static String Д28
            {
                get
                {
                    return "Д28";
                }
            }
            
            /// <summary>
            /// 29
            /// </summary>
            public static String Д29
            {
                get
                {
                    return "Д29";
                }
            }
            
            /// <summary>
            /// 30
            /// </summary>
            public static String Д30
            {
                get
                {
                    return "Д30";
                }
            }
            
            /// <summary>
            /// 31
            /// </summary>
            public static String Д31
            {
                get
                {
                    return "Д31";
                }
            }
            
            /// <summary>
            /// 4
            /// </summary>
            public static String Д4
            {
                get
                {
                    return "Д4";
                }
            }
            
            /// <summary>
            /// 5
            /// </summary>
            public static String Д5
            {
                get
                {
                    return "Д5";
                }
            }
            
            /// <summary>
            /// 6
            /// </summary>
            public static String Д6
            {
                get
                {
                    return "Д6";
                }
            }
            
            /// <summary>
            /// 7
            /// </summary>
            public static String Д7
            {
                get
                {
                    return "Д7";
                }
            }
            
            /// <summary>
            /// 8
            /// </summary>
            public static String Д8
            {
                get
                {
                    return "Д8";
                }
            }
            
            /// <summary>
            /// 9
            /// </summary>
            public static String Д9
            {
                get
                {
                    return "Д9";
                }
            }
            
            /// <summary>
            /// 10
            /// </summary>
            public static String Д10
            {
                get
                {
                    return "Д10";
                }
            }
            
            /// <summary>
            /// 11
            /// </summary>
            public static String Д11
            {
                get
                {
                    return "Д11";
                }
            }
            
            /// <summary>
            /// 12
            /// </summary>
            public static String Д12
            {
                get
                {
                    return "Д12";
                }
            }
            
            /// <summary>
            /// 13
            /// </summary>
            public static String Д13
            {
                get
                {
                    return "Д13";
                }
            }
            
            /// <summary>
            /// 15
            /// </summary>
            public static String Д15
            {
                get
                {
                    return "Д15";
                }
            }
            
            /// <summary>
            /// 16
            /// </summary>
            public static String Д16
            {
                get
                {
                    return "Д16";
                }
            }
            
            /// <summary>
            /// 17
            /// </summary>
            public static String Д17
            {
                get
                {
                    return "Д17";
                }
            }
            
            /// <summary>
            /// 18
            /// </summary>
            public static String Д18
            {
                get
                {
                    return "Д18";
                }
            }
            
            /// <summary>
            /// 19
            /// </summary>
            public static String Д19
            {
                get
                {
                    return "Д19";
                }
            }
            
            /// <summary>
            /// 20
            /// </summary>
            public static String Д20
            {
                get
                {
                    return "Д20";
                }
            }
            
            /// <summary>
            /// 21
            /// </summary>
            public static String Д21
            {
                get
                {
                    return "Д21";
                }
            }
            
            /// <summary>
            /// 22
            /// </summary>
            public static String Д22
            {
                get
                {
                    return "Д22";
                }
            }
            
            /// <summary>
            /// 23
            /// </summary>
            public static String Д23
            {
                get
                {
                    return "Д23";
                }
            }
            
            /// <summary>
            /// 24
            /// </summary>
            public static String Д24
            {
                get
                {
                    return "Д24";
                }
            }
            
            /// <summary>
            /// 26
            /// </summary>
            public static String Д26
            {
                get
                {
                    return "Д26";
                }
            }
            
            /// <summary>
            /// 1
            /// </summary>
            public static String Д1
            {
                get
                {
                    return "Д1";
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
            /// Итого
            /// </summary>
            public static String Итого
            {
                get
                {
                    return "Итого";
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
        /// Сотрудник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Сотрудник
        {
            get
            {
				 NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Сотрудник.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                __Сотрудник.Referent = value;
            }
        }
        
        /// <summary>
        /// 2
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
        /// 3
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
        /// 14
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
        /// 25
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
        /// 27
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
        /// 28
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
        /// 29
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
        /// 30
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
        /// 31
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
        /// 4
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
        /// 5
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
        /// 6
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
        /// 7
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
        /// 8
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
        /// 9
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
        /// 10
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
        /// 11
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
        /// 12
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
        /// 13
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
        /// 15
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
        /// 16
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
        /// 17
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
        /// 18
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
        /// 19
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
        /// 20
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
        /// 21
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
        /// 22
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
        /// 23
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
        /// 24
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
        /// 26
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
        /// 1
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
        /// Итого
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Итого
        {
            get
            {
				 NsgDataFloat __Итого = ObjectList["Итого"] as NsgDataFloat;
                 return (System.Decimal)__Итого.Value;
            }
            set
            {
                NsgDataFloat __Итого = ObjectList["Итого"] as NsgDataFloat;
                __Итого.Value = value;
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
