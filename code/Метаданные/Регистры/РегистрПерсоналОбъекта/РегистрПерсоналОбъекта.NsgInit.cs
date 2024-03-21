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

namespace TechControl.Метаданные.Регистры
{
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "0ed2024d-b06f-45d3-b705-84c3794536ce")]
    public partial class РегистрПерсоналОбъекта : NsgSoft.DataObjects.NsgDataCharacteristics
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics
        

		/// <summary>
        /// Конструктор для проведения документов, передается проводимый документ.
        /// </summary>
        public static РегистрПерсоналОбъекта Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0ed2024d-b06f-45d3-b705-84c3794536ce"));
            if (obj == null)
                obj = new РегистрПерсоналОбъекта();
            (obj as РегистрПерсоналОбъекта).Document = document;
            return obj as РегистрПерсоналОбъекта;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрПерсоналОбъекта()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрПерсоналОбъекта(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрПерсоналОбъекта Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0ed2024d-b06f-45d3-b705-84c3794536ce"));
            if (obj == null)
                obj = new РегистрПерсоналОбъекта();
            return obj as РегистрПерсоналОбъекта;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = true;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("d016205e-18e2-4c70-a78b-8a2922bd9859");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
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
	Автоинкремент.Guid = NsgService.StringToGuid("30f508ea-0ab3-4b46-ab5e-0d3083a6126f");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.РегистрыРегистрПерсоналОбъектаДвижения Движения
			{  
                NsgRegisterTable Движения = null;
				if (ObjectList.Contains("Движения"))
                    Движения = ObjectList["Движения"] as NsgRegisterTable;
                else
                    Движения = new NsgRegisterTable();
	//NsgRegisterTable
	Движения.IsLoadedFromDll = true;
	Движения.Name = "Движения";
	Движения.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Движения.RegisterPeriodCount = 1;
	Движения.ReferentGroup = "_SystemTables";
	Движения.ReferentName = "РегистрыРегистрПерсоналОбъектаДвижения";
	Движения.SaveInDatabase = false;
	Движения.OwnerName = "";
	Движения.AllowEmptyOwner = false;
	Движения.StringFormat = "";
	Движения.SubType = NsgSoft.Common.NsgRekvisitSubType.TabCharacteristics;
	Движения.IncludeInPredefined = false;
	Движения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Движения.Required = false;
	Движения.EmptyValue = "";
	Движения.NullAllow = false;
	Движения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Движения.FieldName = "Dvizhenija";
	Движения.InformMetaDataOnValueChanged = false;
	Движения.Visible = true;
	Движения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Движения.Description = "Движения";
	Движения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Движения.GroupName = "";
	Движения.Guid = NsgService.StringToGuid("75be8b9e-84d2-49fb-98e5-ce0f0e7e0c27");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.РегистрыРегистрПерсоналОбъектаДвижения Движения
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			{  
                NsgDataUntypedReference Владелец = null;
				if (ObjectList.Contains("Владелец"))
                    Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                else
                    Владелец = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	Владелец.IsLoadedFromDll = true;
	Владелец.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("992fad77-7223-4223-a04e-16e001001d5e");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.DateTime Дата
			{  
                NsgDataDateTime Дата = null;
				if (ObjectList.Contains("Дата"))
                    Дата = ObjectList["Дата"] as NsgDataDateTime;
                else
                    Дата = new NsgDataDateTime();
	//NsgDataDateTime
	Дата.IsLoadedFromDll = true;
	Дата.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Дата.StringFormat = "";
	Дата.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Дата.IncludeInPredefined = false;
	Дата.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Дата.Required = false;
	Дата.EmptyValue = "";
	Дата.NullAllow = false;
	Дата.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Дата.FieldName = "_Date";
	Дата.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Дата.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Дата.CharactericticWeight = 1;
	Дата.InformMetaDataOnValueChanged = false;
	Дата.Visible = true;
	Дата.Name = "Дата";
	Дата.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	Дата.Description = "Дата документа";
	Дата.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Дата.GroupName = "";
	Дата.Guid = NsgService.StringToGuid("639d9dce-fc52-4a6a-9fa7-3598edcc6bb4");
	
				if (!ObjectList.Contains("Дата"))
                    ObjectList.Add(Дата);
			}
			#endregion //создание System.DateTime Дата
			
			#region создание System.DateTime КонецПериода
			{  
                NsgDataDateTime КонецПериода = null;
				if (ObjectList.Contains("КонецПериода"))
                    КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                else
                    КонецПериода = new NsgDataDateTime();
	//NsgDataDateTime
	КонецПериода.IsLoadedFromDll = true;
	КонецПериода.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	КонецПериода.StringFormat = "";
	КонецПериода.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	КонецПериода.IncludeInPredefined = false;
	КонецПериода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонецПериода.Required = false;
	КонецПериода.EmptyValue = "";
	КонецПериода.NullAllow = false;
	КонецПериода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонецПериода.FieldName = "_DateEnd";
	КонецПериода.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	КонецПериода.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	КонецПериода.CharactericticWeight = 1;
	КонецПериода.InformMetaDataOnValueChanged = false;
	КонецПериода.Visible = true;
	КонецПериода.Name = "КонецПериода";
	КонецПериода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонецПериода.Description = "Конец периода";
	КонецПериода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	КонецПериода.GroupName = "";
	КонецПериода.Guid = NsgService.StringToGuid("b524c369-593b-4154-85eb-1fb05123149c");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
			#region создание Мониторинг.Сотрудники Сотрудники
			{  
                NsgDataTypedReference Сотрудники = null;
				if (ObjectList.Contains("Сотрудники"))
                    Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                else
                    Сотрудники = new NsgDataTypedReference();
	//NsgDataTypedReference
	Сотрудники.IsLoadedFromDll = true;
	Сотрудники.ReferentGroup = "Мониторинг";
	Сотрудники.ReferentName = "Сотрудники";
	Сотрудники.SaveInDatabase = true;
	Сотрудники.OwnerName = "";
	Сотрудники.AllowEmptyOwner = false;
	Сотрудники.StringFormat = "";
	Сотрудники.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Сотрудники.IncludeInPredefined = false;
	Сотрудники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудники.Required = false;
	Сотрудники.EmptyValue = "";
	Сотрудники.NullAllow = false;
	Сотрудники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сотрудники.FieldName = "Sotrudniki";
	Сотрудники.InformMetaDataOnValueChanged = false;
	Сотрудники.Visible = true;
	Сотрудники.Name = "Сотрудники";
	Сотрудники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудники.Description = "Сотрудники";
	Сотрудники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудники.GroupName = "";
	Сотрудники.Guid = NsgService.StringToGuid("e2cf7bd7-1b6b-4bb8-bc57-ea77afaad96b");
	
				if (!ObjectList.Contains("Сотрудники"))
                    ObjectList.Add(Сотрудники);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудники
			
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
	Объект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
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
	Объект.Guid = NsgService.StringToGuid("aa934866-fdc0-4192-8169-bd91c2a231e4");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Мониторинг.Должности Должности
			{  
                NsgDataTypedReference Должности = null;
				if (ObjectList.Contains("Должности"))
                    Должности = ObjectList["Должности"] as NsgDataTypedReference;
                else
                    Должности = new NsgDataTypedReference();
	//NsgDataTypedReference
	Должности.IsLoadedFromDll = true;
	Должности.ReferentGroup = "Мониторинг";
	Должности.ReferentName = "Должности";
	Должности.SaveInDatabase = true;
	Должности.OwnerName = "";
	Должности.AllowEmptyOwner = false;
	Должности.StringFormat = "";
	Должности.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Должности.IncludeInPredefined = false;
	Должности.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Должности.Required = false;
	Должности.EmptyValue = "";
	Должности.NullAllow = false;
	Должности.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Должности.FieldName = "Dolzhnosti";
	Должности.InformMetaDataOnValueChanged = false;
	Должности.Visible = true;
	Должности.Name = "Должности";
	Должности.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Должности.Description = "Должности";
	Должности.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Должности.GroupName = "";
	Должности.Guid = NsgService.StringToGuid("cffaebc3-f7de-4933-adba-ad3cb6e78878");
	
				if (!ObjectList.Contains("Должности"))
                    ObjectList.Add(Должности);
			}
			#endregion //создание Мониторинг.Должности Должности
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = true;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "РегистрПерсоналОбъекта";
	Visible = true;
	Guid = NsgService.StringToGuid("0ed2024d-b06f-45d3-b705-84c3794536ce");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrPersonalObekta";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Характеристики";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Регистры";
	ConnectAdditionalTables();

			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataCharacteristics.Names
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
            /// Движения
            /// </summary>
            public static String Движения
            {
                get
                {
                    return "Движения";
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
            public static String Дата
            {
                get
                {
                    return "Дата";
                }
            }
            
            /// <summary>
            /// Конец периода
            /// </summary>
            public static String КонецПериода
            {
                get
                {
                    return "КонецПериода";
                }
            }
            
            /// <summary>
            /// Сотрудники
            /// </summary>
            public static String Сотрудники
            {
                get
                {
                    return "Сотрудники";
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
            /// Должности
            /// </summary>
            public static String Должности
            {
                get
                {
                    return "Должности";
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
                    descriptor.Name = "РегистрПерсоналОбъекта";
                    descriptor.GroupName = "Регистры";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Регистры.РегистрПерсоналОбъекта";
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
        /// Движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.РегистрыРегистрПерсоналОбъектаДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.РегистрыРегистрПерсоналОбъектаДвижения)__Движения.Referent;
            }
            set
            {
                NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                __Движения.Referent = value;
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
        
        public System.DateTime Дата
        {
            get
            {
				 NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                 return (System.DateTime)__Дата.Value;
            }
            set
            {
                NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                __Дата.Value = value;
            }
        }
        
        /// <summary>
        /// Конец периода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime КонецПериода
        {
            get
            {
				 NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                 return (System.DateTime)__КонецПериода.Value;
            }
            set
            {
                NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                __КонецПериода.Value = value;
            }
        }
        
        /// <summary>
        /// Сотрудники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Сотрудники Сотрудники
        {
            get
            {
				 NsgDataTypedReference __Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                 return (Мониторинг.Сотрудники)__Сотрудники.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                __Сотрудники.Referent = value;
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
        /// Должности
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Должности Должности
        {
            get
            {
				 NsgDataTypedReference __Должности = ObjectList["Должности"] as NsgDataTypedReference;
                 return (Мониторинг.Должности)__Должности.Referent;
            }
            set
            {
                NsgDataTypedReference __Должности = ObjectList["Должности"] as NsgDataTypedReference;
                __Должности.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataCharacteristics
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataCharacteristics

        #region Методы NsgMultipleObject
        private РегистрПерсоналОбъекта[] convertArray(NsgMultipleObject[] array)
        {
            РегистрПерсоналОбъекта[] res = new РегистрПерсоналОбъекта[array.Length];
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
        public new virtual РегистрПерсоналОбъекта[] FindAll(NsgCompare compare)
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
        public new virtual РегистрПерсоналОбъекта[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрПерсоналОбъекта[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрПерсоналОбъекта[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрПерсоналОбъекта(this as NsgObject);
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
                base.NSGType = typeof(РегистрПерсоналОбъекта);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрПерсоналОбъекта Value
            {
                get
                {
                    return (РегистрПерсоналОбъекта)base.Value;
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
                    return "s_NsgDataCharacteristics";
                }
            }
        }

    }

}
