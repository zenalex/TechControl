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
    
    [NsgTypeName("NsgDataTable", Guid = "b657fa62-1ade-46a5-b308-3f9b89332cb7")]
    public partial class МониторингРегистрЗаправокНакопления : NsgSoft.DataObjects.NsgDataTable
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTable

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTable

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected МониторингРегистрЗаправокНакопления()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингРегистрЗаправокНакопления(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингРегистрЗаправокНакопления Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b657fa62-1ade-46a5-b308-3f9b89332cb7"));
            if (obj == null)
                obj = new МониторингРегистрЗаправокНакопления();
            return obj as МониторингРегистрЗаправокНакопления;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTable
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("7e56edf4-197f-42af-bb16-2dc71f1462fa");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание Мониторинг.Техника Техника
			{  
                NsgDataTypedReference Техника = null;
				if (ObjectList.Contains("Техника"))
                    Техника = ObjectList["Техника"] as NsgDataTypedReference;
                else
                    Техника = new NsgDataTypedReference();
	//NsgDataTypedReference
	Техника.IsLoadedFromDll = true;
	Техника.ReferentGroup = "Мониторинг";
	Техника.ReferentName = "Техника";
	Техника.SaveInDatabase = true;
	Техника.OwnerName = "";
	Техника.AllowEmptyOwner = false;
	Техника.StringFormat = "";
	Техника.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Техника.IncludeInPredefined = false;
	Техника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Техника.Required = false;
	Техника.EmptyValue = "";
	Техника.NullAllow = false;
	Техника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Техника.FieldName = "Tekhnika";
	Техника.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Техника.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Техника.CharactericticWeight = 1;
	Техника.InformMetaDataOnValueChanged = false;
	Техника.Visible = true;
	Техника.Name = "Техника";
	Техника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Техника.Description = "Техника";
	Техника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Техника.GroupName = "";
	Техника.Guid = NsgService.StringToGuid("e2938d1c-09cf-4185-8654-b25a70e73cf9");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
			#region создание System.Decimal ОбъемТоплива
			{  
                NsgDataFloat ОбъемТоплива = null;
				if (ObjectList.Contains("ОбъемТоплива"))
                    ОбъемТоплива = ObjectList["ОбъемТоплива"] as NsgDataFloat;
                else
                    ОбъемТоплива = new NsgDataFloat();
	//NsgDataFloat
	ОбъемТоплива.IsLoadedFromDll = true;
	ОбъемТоплива.Precision = 2;
	ОбъемТоплива.HideZero = true;
	ОбъемТоплива.DefaultValue = 0M;
	ОбъемТоплива.MinValue = -100000000000000000M;
	ОбъемТоплива.MaxValue = 100000000000000000M;
	ОбъемТоплива.UseCalculator = true;
	ОбъемТоплива.StringFormat = "";
	ОбъемТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	ОбъемТоплива.IncludeInPredefined = false;
	ОбъемТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъемТоплива.Required = false;
	ОбъемТоплива.EmptyValue = "";
	ОбъемТоплива.NullAllow = false;
	ОбъемТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъемТоплива.FieldName = "ObemTopliva";
	ОбъемТоплива.InformMetaDataOnValueChanged = false;
	ОбъемТоплива.Visible = true;
	ОбъемТоплива.Name = "ОбъемТоплива";
	ОбъемТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъемТоплива.Description = "Объем топлива";
	ОбъемТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъемТоплива.GroupName = "";
	ОбъемТоплива.Guid = NsgService.StringToGuid("39c0ecc5-b7d7-4df5-909d-947bde26402f");
	
				if (!ObjectList.Contains("ОбъемТоплива"))
                    ObjectList.Add(ОбъемТоплива);
			}
			#endregion //создание System.Decimal ОбъемТоплива
			
			#region создание Мониторинг.Контрагенты Поставщик
			{  
                NsgDataTypedReference Поставщик = null;
				if (ObjectList.Contains("Поставщик"))
                    Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                else
                    Поставщик = new NsgDataTypedReference();
	//NsgDataTypedReference
	Поставщик.IsLoadedFromDll = true;
	Поставщик.ReferentGroup = "Мониторинг";
	Поставщик.ReferentName = "Контрагенты";
	Поставщик.SaveInDatabase = true;
	Поставщик.OwnerName = "";
	Поставщик.AllowEmptyOwner = false;
	Поставщик.StringFormat = "";
	Поставщик.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Поставщик.IncludeInPredefined = false;
	Поставщик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Поставщик.Required = false;
	Поставщик.EmptyValue = "";
	Поставщик.NullAllow = false;
	Поставщик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Поставщик.FieldName = "Postavschik";
	Поставщик.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Поставщик.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Поставщик.CharactericticWeight = 1;
	Поставщик.InformMetaDataOnValueChanged = false;
	Поставщик.Visible = true;
	Поставщик.Name = "Поставщик";
	Поставщик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Поставщик.Description = "Поставщик";
	Поставщик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Поставщик.GroupName = "";
	Поставщик.Guid = NsgService.StringToGuid("0cf21e0e-d89a-4a12-81b2-a0630fff740d");
	
				if (!ObjectList.Contains("Поставщик"))
                    ObjectList.Add(Поставщик);
			}
			#endregion //создание Мониторинг.Контрагенты Поставщик
			
			#region создание Мониторинг.Объекты Объект
			{  
                NsgDataTypedReference Объект = null;
				if (ObjectList.Contains("Объект"))
                    Объект = ObjectList["Объект"] as NsgDataTypedReference;
                else
                    Объект = new NsgDataTypedReference();
	//NsgDataTypedReference
	Объект.IsLoadedFromDll = true;
	Объект.ReferentGroup = "Мониторинг";
	Объект.ReferentName = "Объекты";
	Объект.SaveInDatabase = true;
	Объект.OwnerName = "";
	Объект.AllowEmptyOwner = false;
	Объект.StringFormat = "";
	Объект.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Объект.IncludeInPredefined = false;
	Объект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объект.Required = false;
	Объект.EmptyValue = "";
	Объект.NullAllow = false;
	Объект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Объект.FieldName = "Obekt";
	Объект.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Объект.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Объект.CharactericticWeight = 1;
	Объект.InformMetaDataOnValueChanged = false;
	Объект.Visible = true;
	Объект.Name = "Объект";
	Объект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объект.Description = "Объект";
	Объект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объект.GroupName = "";
	Объект.Guid = NsgService.StringToGuid("04aa572b-2121-4b08-8c0d-1b59c860712a");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.РегистрЗаправок";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterAccumTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингРегистрЗаправокНакопления";
	Visible = true;
	Guid = NsgService.StringToGuid("b657fa62-1ade-46a5-b308-3f9b89332cb7");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringRegistrZa1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг регистр заправок накопления";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "_SystemTables";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTable

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTable.Names
        {
            
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
            /// Объем топлива
            /// </summary>
            public static String ОбъемТоплива
            {
                get
                {
                    return "ОбъемТоплива";
                }
            }
            
            /// <summary>
            /// Поставщик
            /// </summary>
            public static String Поставщик
            {
                get
                {
                    return "Поставщик";
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
                    descriptor.Name = "МониторингРегистрЗаправокНакопления";
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
            return "_SystemTables.МониторингРегистрЗаправокНакопления";
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
        /// Объем топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбъемТоплива
        {
            get
            {
				 NsgDataFloat __ОбъемТоплива = ObjectList["ОбъемТоплива"] as NsgDataFloat;
                 return (System.Decimal)__ОбъемТоплива.Value;
            }
            set
            {
                NsgDataFloat __ОбъемТоплива = ObjectList["ОбъемТоплива"] as NsgDataFloat;
                __ОбъемТоплива.Value = value;
            }
        }
        
        /// <summary>
        /// Поставщик
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Поставщик
        {
            get
            {
				 NsgDataTypedReference __Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Поставщик.Referent;
            }
            set
            {
                NsgDataTypedReference __Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                __Поставщик.Referent = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new МониторингРегистрЗаправокНакопления.Строка NewRow()
        {
            return newRow(null) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингРегистрЗаправокНакопления.Строка(this);
            return base.newRow(row) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингРегистрЗаправокНакопления.Строка NewRow(МониторингРегистрЗаправокНакопления.Строка inRow)
        {
            МониторингРегистрЗаправокНакопления.Строка row = inRow.Clone as МониторингРегистрЗаправокНакопления.Строка;
            return base.newRow(row) as МониторингРегистрЗаправокНакопления.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингРегистрЗаправокНакопления.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингРегистрЗаправокНакопления.Строка GetEtalonRow()
        {
            МониторингРегистрЗаправокНакопления.Строка row = new МониторингРегистрЗаправокНакопления.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингРегистрЗаправокНакопления.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингРегистрЗаправокНакопления.Строка[] res = new МониторингРегистрЗаправокНакопления.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрЗаправокНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингРегистрЗаправокНакопления> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингРегистрЗаправокНакопления>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингРегистрЗаправокНакопления.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингРегистрЗаправокНакопления.Строка[] AllRows
        {
            get
            {
                return convertRowsArray(base.AllRows);
            }
        }

        /// <summary>
        /// Получить строку таблицы
        /// </summary>
        /// <param name="inName">Идентификатор строки.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрЗаправокНакопления.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингРегистрЗаправокНакопления.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингРегистрЗаправокНакопления[] convertArray(NsgMultipleObject[] array)
        {
            МониторингРегистрЗаправокНакопления[] res = new МониторингРегистрЗаправокНакопления[array.Length];
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
        public new virtual МониторингРегистрЗаправокНакопления[] FindAll(NsgCompare compare)
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
        public new virtual МониторингРегистрЗаправокНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингРегистрЗаправокНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингРегистрЗаправокНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингРегистрЗаправокНакопления(this as NsgObject);
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
                base.NSGType = typeof(МониторингРегистрЗаправокНакопления);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингРегистрЗаправокНакопления Value
            {
                get
                {
                    return (МониторингРегистрЗаправокНакопления)base.Value;
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
                    return "s_NsgDataTable";
                }
            }
        }

    }

}
