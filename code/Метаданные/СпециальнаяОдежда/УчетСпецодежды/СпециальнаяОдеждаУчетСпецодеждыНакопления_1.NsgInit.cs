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
    
    [NsgTypeName("NsgDataTable", Guid = "b03473de-6e37-4c1c-b4ea-f0830407c943")]
    public partial class СпециальнаяОдеждаУчетСпецодеждыНакопления_1 : NsgSoft.DataObjects.NsgDataTable
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
        protected СпециальнаяОдеждаУчетСпецодеждыНакопления_1()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected СпециальнаяОдеждаУчетСпецодеждыНакопления_1(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static СпециальнаяОдеждаУчетСпецодеждыНакопления_1 Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b03473de-6e37-4c1c-b4ea-f0830407c943"));
            if (obj == null)
                obj = new СпециальнаяОдеждаУчетСпецодеждыНакопления_1();
            return obj as СпециальнаяОдеждаУчетСпецодеждыНакопления_1;
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
			
			#region создание System.DateTime ДатаВыдачи
			{  
                NsgDataDateTime ДатаВыдачи = null;
				if (ObjectList.Contains("ДатаВыдачи"))
                    ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                else
                    ДатаВыдачи = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаВыдачи.IsLoadedFromDll = true;
	ДатаВыдачи.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаВыдачи.StringFormat = "";
	ДатаВыдачи.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ДатаВыдачи.IncludeInPredefined = false;
	ДатаВыдачи.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаВыдачи.Required = false;
	ДатаВыдачи.EmptyValue = "";
	ДатаВыдачи.NullAllow = false;
	ДатаВыдачи.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаВыдачи.FieldName = "DataVydachi";
	ДатаВыдачи.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	ДатаВыдачи.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	ДатаВыдачи.CharactericticWeight = 1;
	ДатаВыдачи.InformMetaDataOnValueChanged = false;
	ДатаВыдачи.Visible = true;
	ДатаВыдачи.Name = "ДатаВыдачи";
	ДатаВыдачи.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаВыдачи.Description = "Дата выдачи";
	ДатаВыдачи.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаВыдачи.GroupName = "";
	ДатаВыдачи.Guid = NsgService.StringToGuid("2afd82e6-50e8-473f-878c-ba448c1134b8");
	
				if (!ObjectList.Contains("ДатаВыдачи"))
                    ObjectList.Add(ДатаВыдачи);
			}
			#endregion //создание System.DateTime ДатаВыдачи
			
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
	Автоинкремент.Guid = NsgService.StringToGuid("04c9eda9-6202-49f2-9f23-bb571ff1d1ea");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание СпециальнаяОдежда.Спецодежда Спецодежда
			{  
                NsgDataTypedReference Спецодежда = null;
				if (ObjectList.Contains("Спецодежда"))
                    Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                else
                    Спецодежда = new NsgDataTypedReference();
	//NsgDataTypedReference
	Спецодежда.IsLoadedFromDll = true;
	Спецодежда.ReferentGroup = "СпециальнаяОдежда";
	Спецодежда.ReferentName = "Спецодежда";
	Спецодежда.SaveInDatabase = true;
	Спецодежда.OwnerName = "";
	Спецодежда.AllowEmptyOwner = false;
	Спецодежда.StringFormat = "";
	Спецодежда.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Спецодежда.IncludeInPredefined = false;
	Спецодежда.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Спецодежда.Required = false;
	Спецодежда.EmptyValue = "";
	Спецодежда.NullAllow = false;
	Спецодежда.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Спецодежда.FieldName = "Specodezhda";
	Спецодежда.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Спецодежда.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Спецодежда.CharactericticWeight = 1;
	Спецодежда.InformMetaDataOnValueChanged = false;
	Спецодежда.Visible = true;
	Спецодежда.Name = "Спецодежда";
	Спецодежда.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Спецодежда.Description = "Спецодежда";
	Спецодежда.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Спецодежда.GroupName = "";
	Спецодежда.Guid = NsgService.StringToGuid("81098b01-b622-438e-ad97-1804436a2c4b");
	
				if (!ObjectList.Contains("Спецодежда"))
                    ObjectList.Add(Спецодежда);
			}
			#endregion //создание СпециальнаяОдежда.Спецодежда Спецодежда
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("2c8f5d23-7b0f-4fe4-ad9b-250fce713258");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание Мониторинг.Сотрудники Сотрудник
			{  
                NsgDataTypedReference Сотрудник = null;
				if (ObjectList.Contains("Сотрудник"))
                    Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                else
                    Сотрудник = new NsgDataTypedReference();
	//NsgDataTypedReference
	Сотрудник.IsLoadedFromDll = true;
	Сотрудник.ReferentGroup = "Мониторинг";
	Сотрудник.ReferentName = "Сотрудники";
	Сотрудник.SaveInDatabase = true;
	Сотрудник.OwnerName = "";
	Сотрудник.AllowEmptyOwner = false;
	Сотрудник.StringFormat = "";
	Сотрудник.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Сотрудник.IncludeInPredefined = false;
	Сотрудник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудник.Required = false;
	Сотрудник.EmptyValue = "";
	Сотрудник.NullAllow = false;
	Сотрудник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Сотрудник.FieldName = "Sotrudnik";
	Сотрудник.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Сотрудник.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Сотрудник.CharactericticWeight = 1;
	Сотрудник.InformMetaDataOnValueChanged = false;
	Сотрудник.Visible = true;
	Сотрудник.Name = "Сотрудник";
	Сотрудник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудник.Description = "Сотрудник";
	Сотрудник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудник.GroupName = "";
	Сотрудник.Guid = NsgService.StringToGuid("eae26df2-00e2-42df-b227-5506586e90d1");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудник
			
			#region создание System.Int64 Количество
			{  
                NsgDataInteger Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataInteger;
                else
                    Количество = new NsgDataInteger();
	//NsgDataInteger
	Количество.IsLoadedFromDll = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = -10000000000000000000M;
	Количество.MaxValue = 10000000000000000000M;
	Количество.UseCalculator = true;
	Количество.StringFormat = "";
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("c03a8b06-6d06-4920-a2c9-3926c5557776");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Int64 Количество
			
			#region создание System.Decimal Стоимость
			{  
                NsgDataFloat Стоимость = null;
				if (ObjectList.Contains("Стоимость"))
                    Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                else
                    Стоимость = new NsgDataFloat();
	//NsgDataFloat
	Стоимость.IsLoadedFromDll = true;
	Стоимость.Precision = 2;
	Стоимость.HideZero = true;
	Стоимость.DefaultValue = 0M;
	Стоимость.MinValue = -100000000000000000M;
	Стоимость.MaxValue = 100000000000000000M;
	Стоимость.UseCalculator = true;
	Стоимость.StringFormat = "";
	Стоимость.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Стоимость.IncludeInPredefined = false;
	Стоимость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Стоимость.Required = false;
	Стоимость.EmptyValue = "";
	Стоимость.NullAllow = false;
	Стоимость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Стоимость.FieldName = "Stoimost";
	Стоимость.InformMetaDataOnValueChanged = false;
	Стоимость.Visible = true;
	Стоимость.Name = "Стоимость";
	Стоимость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Стоимость.Description = "Стоимость";
	Стоимость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Стоимость.GroupName = "";
	Стоимость.Guid = NsgService.StringToGuid("509d040b-9a12-4e1a-96cd-faf257b784bb");
	
				if (!ObjectList.Contains("Стоимость"))
                    ObjectList.Add(Стоимость);
			}
			#endregion //создание System.Decimal Стоимость
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "СпециальнаяОдежда.УчетСпецодежды";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.Month;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterAccumTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СпециальнаяОдеждаУчетСпецодеждыНакопления_1";
	Visible = true;
	Guid = NsgService.StringToGuid("b03473de-6e37-4c1c-b4ea-f0830407c943");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_SpecialnajaOdezhdaU2";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Специальная одежда учет спецодежды накопления_1";
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
            /// Дата выдачи
            /// </summary>
            public static String ДатаВыдачи
            {
                get
                {
                    return "ДатаВыдачи";
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
            /// Спецодежда
            /// </summary>
            public static String Спецодежда
            {
                get
                {
                    return "Спецодежда";
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
            /// Стоимость
            /// </summary>
            public static String Стоимость
            {
                get
                {
                    return "Стоимость";
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
                    descriptor.Name = "СпециальнаяОдеждаУчетСпецодеждыНакопления_1";
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
            return "_SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления_1";
        }

        
        /// <summary>
        /// Дата выдачи
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаВыдачи
        {
            get
            {
				 NsgDataDateTime __ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаВыдачи.Value;
            }
            set
            {
                NsgDataDateTime __ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                __ДатаВыдачи.Value = value;
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
        /// Спецодежда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СпециальнаяОдежда.Спецодежда Спецодежда
        {
            get
            {
				 NsgDataTypedReference __Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                 return (СпециальнаяОдежда.Спецодежда)__Спецодежда.Referent;
            }
            set
            {
                NsgDataTypedReference __Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                __Спецодежда.Referent = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка NewRow()
        {
            return newRow(null) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка(this);
            return base.newRow(row) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка NewRow(СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка inRow)
        {
            СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка row = inRow.Clone as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
            return base.newRow(row) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка GetEtalonRow()
        {
            СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка row = new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] res = new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<СпециальнаяОдеждаУчетСпецодеждыНакопления_1> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<СпециальнаяОдеждаУчетСпецодеждыНакопления_1>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка[] AllRows
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
        public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as СпециальнаяОдеждаУчетСпецодеждыНакопления_1.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] convertArray(NsgMultipleObject[] array)
        {
            СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] res = new СпециальнаяОдеждаУчетСпецодеждыНакопления_1[array.Length];
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
        public new virtual СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] FindAll(NsgCompare compare)
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
        public new virtual СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual СпециальнаяОдеждаУчетСпецодеждыНакопления_1[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new СпециальнаяОдеждаУчетСпецодеждыНакопления_1(this as NsgObject);
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
                base.NSGType = typeof(СпециальнаяОдеждаУчетСпецодеждыНакопления_1);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new СпециальнаяОдеждаУчетСпецодеждыНакопления_1 Value
            {
                get
                {
                    return (СпециальнаяОдеждаУчетСпецодеждыНакопления_1)base.Value;
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
