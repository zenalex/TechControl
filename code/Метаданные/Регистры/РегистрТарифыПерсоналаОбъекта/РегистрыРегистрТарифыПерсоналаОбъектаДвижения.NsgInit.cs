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
    
    [NsgTypeName("NsgDataTable", Guid = "eebe78d9-071e-4855-b499-3db21dfc3e4a")]
    public partial class РегистрыРегистрТарифыПерсоналаОбъектаДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected РегистрыРегистрТарифыПерсоналаОбъектаДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрыРегистрТарифыПерсоналаОбъектаДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрыРегистрТарифыПерсоналаОбъектаДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("eebe78d9-071e-4855-b499-3db21dfc3e4a"));
            if (obj == null)
                obj = new РегистрыРегистрТарифыПерсоналаОбъектаДвижения();
            return obj as РегистрыРегистрТарифыПерсоналаОбъектаДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("eae3f7da-e343-4728-ba22-9325c2f047f4");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("ee61d915-5f62-450b-8ca8-22af785f050b");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
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
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("5c7e0962-bd6b-4817-9086-0c8f167f4413");
	
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
	Дата.Guid = NsgService.StringToGuid("bbcfc48d-1a73-45f3-9293-e8ff17f30c32");
	
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
	КонецПериода.Guid = NsgService.StringToGuid("1785b815-7840-4fab-80e2-b8f60983078e");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
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
	Объект.Guid = NsgService.StringToGuid("310aba33-4934-463c-a19e-d3c79be40c0f");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Мониторинг.Тарифы Тариф
			{  
                NsgDataTypedReference Тариф = null;
				if (ObjectList.Contains("Тариф"))
                    Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                else
                    Тариф = new NsgDataTypedReference();
	//NsgDataTypedReference
	Тариф.IsLoadedFromDll = true;
	Тариф.ReferentGroup = "Мониторинг";
	Тариф.ReferentName = "Тарифы";
	Тариф.SaveInDatabase = true;
	Тариф.OwnerName = "";
	Тариф.AllowEmptyOwner = false;
	Тариф.StringFormat = "";
	Тариф.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Тариф.IncludeInPredefined = false;
	Тариф.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Тариф.Required = false;
	Тариф.EmptyValue = "";
	Тариф.NullAllow = false;
	Тариф.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Тариф.FieldName = "Tarif";
	Тариф.InformMetaDataOnValueChanged = false;
	Тариф.Visible = true;
	Тариф.Name = "Тариф";
	Тариф.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Тариф.Description = "Тариф";
	Тариф.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Тариф.GroupName = "";
	Тариф.Guid = NsgService.StringToGuid("072eb620-2a96-4dc8-b0b0-320378277bcb");
	
				if (!ObjectList.Contains("Тариф"))
                    ObjectList.Add(Тариф);
			}
			#endregion //создание Мониторинг.Тарифы Тариф
			
			#region создание Мониторинг.Должности Должность
			{  
                NsgDataTypedReference Должность = null;
				if (ObjectList.Contains("Должность"))
                    Должность = ObjectList["Должность"] as NsgDataTypedReference;
                else
                    Должность = new NsgDataTypedReference();
	//NsgDataTypedReference
	Должность.IsLoadedFromDll = true;
	Должность.ReferentGroup = "Мониторинг";
	Должность.ReferentName = "Должности";
	Должность.SaveInDatabase = true;
	Должность.OwnerName = "";
	Должность.AllowEmptyOwner = false;
	Должность.StringFormat = "";
	Должность.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Должность.IncludeInPredefined = false;
	Должность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Должность.Required = false;
	Должность.EmptyValue = "";
	Должность.NullAllow = false;
	Должность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Должность.FieldName = "Dolzhnost";
	Должность.InformMetaDataOnValueChanged = false;
	Должность.Visible = true;
	Должность.Name = "Должность";
	Должность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Должность.Description = "Должность";
	Должность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Должность.GroupName = "";
	Должность.Guid = NsgService.StringToGuid("732f5043-6a7f-42b4-99b5-f0a28be2bded");
	
				if (!ObjectList.Contains("Должность"))
                    ObjectList.Add(Должность);
			}
			#endregion //создание Мониторинг.Должности Должность
			
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
	Стоимость.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Стоимость.IncludeInPredefined = false;
	Стоимость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Стоимость.Required = false;
	Стоимость.EmptyValue = "";
	Стоимость.NullAllow = false;
	Стоимость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Стоимость.FieldName = "Stoimost";
	Стоимость.SaveInDatabase = true;
	Стоимость.InformMetaDataOnValueChanged = false;
	Стоимость.Visible = true;
	Стоимость.Name = "Стоимость";
	Стоимость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Стоимость.Description = "Стоимость";
	Стоимость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Стоимость.GroupName = "";
	Стоимость.Guid = NsgService.StringToGuid("18a72e41-774a-4015-9241-4ed18da78a58");
	
				if (!ObjectList.Contains("Стоимость"))
                    ObjectList.Add(Стоимость);
			}
			#endregion //создание System.Decimal Стоимость
			
			#region создание System.Boolean ИспоьзоватьПоУмолчанию
			{  
                NsgDataBoolean ИспоьзоватьПоУмолчанию = null;
				if (ObjectList.Contains("ИспоьзоватьПоУмолчанию"))
                    ИспоьзоватьПоУмолчанию = ObjectList["ИспоьзоватьПоУмолчанию"] as NsgDataBoolean;
                else
                    ИспоьзоватьПоУмолчанию = new NsgDataBoolean();
	//NsgDataBoolean
	ИспоьзоватьПоУмолчанию.IsLoadedFromDll = true;
	ИспоьзоватьПоУмолчанию.DefaultValue = false;
	ИспоьзоватьПоУмолчанию.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспоьзоватьПоУмолчанию.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспоьзоватьПоУмолчанию.StringFormat = "";
	ИспоьзоватьПоУмолчанию.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИспоьзоватьПоУмолчанию.IncludeInPredefined = false;
	ИспоьзоватьПоУмолчанию.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИспоьзоватьПоУмолчанию.Required = false;
	ИспоьзоватьПоУмолчанию.EmptyValue = "";
	ИспоьзоватьПоУмолчанию.NullAllow = false;
	ИспоьзоватьПоУмолчанию.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИспоьзоватьПоУмолчанию.FieldName = "IspozovatPoUmolch";
	ИспоьзоватьПоУмолчанию.SaveInDatabase = true;
	ИспоьзоватьПоУмолчанию.InformMetaDataOnValueChanged = false;
	ИспоьзоватьПоУмолчанию.Visible = true;
	ИспоьзоватьПоУмолчанию.Name = "ИспоьзоватьПоУмолчанию";
	ИспоьзоватьПоУмолчанию.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспоьзоватьПоУмолчанию.Description = "Испоьзовать по умолчанию";
	ИспоьзоватьПоУмолчанию.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИспоьзоватьПоУмолчанию.GroupName = "";
	ИспоьзоватьПоУмолчанию.Guid = NsgService.StringToGuid("2de7b646-24d9-43dc-9b35-3e1214cd10dc");
	
				if (!ObjectList.Contains("ИспоьзоватьПоУмолчанию"))
                    ObjectList.Add(ИспоьзоватьПоУмолчанию);
			}
			#endregion //создание System.Boolean ИспоьзоватьПоУмолчанию
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Регистры.РегистрТарифыПерсоналаОбъекта";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCharacteristicsTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "РегистрыРегистрТарифыПерсоналаОбъектаДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("eebe78d9-071e-4855-b499-3db21dfc3e4a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_RegistryRegistrTari";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистры регистр тарифы персонала объекта движения";
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
            /// Испоьзовать по умолчанию
            /// </summary>
            public static String ИспоьзоватьПоУмолчанию
            {
                get
                {
                    return "ИспоьзоватьПоУмолчанию";
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
                    descriptor.Name = "РегистрыРегистрТарифыПерсоналаОбъектаДвижения";
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
            return "_SystemTables.РегистрыРегистрТарифыПерсоналаОбъектаДвижения";
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
        /// Испоьзовать по умолчанию
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ИспоьзоватьПоУмолчанию
        {
            get
            {
				 NsgDataBoolean __ИспоьзоватьПоУмолчанию = ObjectList["ИспоьзоватьПоУмолчанию"] as NsgDataBoolean;
                 return (System.Boolean)__ИспоьзоватьПоУмолчанию.Value;
            }
            set
            {
                NsgDataBoolean __ИспоьзоватьПоУмолчанию = ObjectList["ИспоьзоватьПоУмолчанию"] as NsgDataBoolean;
                __ИспоьзоватьПоУмолчанию.Value = value;
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
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка NewRow()
        {
            return newRow(null) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка(this);
            return base.newRow(row) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка NewRow(РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка inRow)
        {
            РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка row = inRow.Clone as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
            return base.newRow(row) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка GetEtalonRow()
        {
            РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка row = new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] res = new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<РегистрыРегистрТарифыПерсоналаОбъектаДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<РегистрыРегистрТарифыПерсоналаОбъектаДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка[] AllRows
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
        public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] convertArray(NsgMultipleObject[] array)
        {
            РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] res = new РегистрыРегистрТарифыПерсоналаОбъектаДвижения[array.Length];
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
        public new virtual РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] FindAll(NsgCompare compare)
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
        public new virtual РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрыРегистрТарифыПерсоналаОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрыРегистрТарифыПерсоналаОбъектаДвижения(this as NsgObject);
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
                base.NSGType = typeof(РегистрыРегистрТарифыПерсоналаОбъектаДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрыРегистрТарифыПерсоналаОбъектаДвижения Value
            {
                get
                {
                    return (РегистрыРегистрТарифыПерсоналаОбъектаДвижения)base.Value;
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
