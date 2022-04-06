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

namespace TechControl.Метаданные.Мониторинг
{
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "13ff2378-5ed8-4049-94e1-13b17aedf0c1")]
    public partial class ФиксацияИсторииСотрудников : NsgSoft.DataObjects.NsgDataCharacteristics
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
        public static ФиксацияИсторииСотрудников Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("13ff2378-5ed8-4049-94e1-13b17aedf0c1"));
            if (obj == null)
                obj = new ФиксацияИсторииСотрудников();
            (obj as ФиксацияИсторииСотрудников).Document = document;
            return obj as ФиксацияИсторииСотрудников;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ФиксацияИсторииСотрудников()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ФиксацияИсторииСотрудников(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ФиксацияИсторииСотрудников Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("13ff2378-5ed8-4049-94e1-13b17aedf0c1"));
            if (obj == null)
                obj = new ФиксацияИсторииСотрудников();
            return obj as ФиксацияИсторииСотрудников;
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
	Идентификатор.Guid = NsgService.StringToGuid("7243f493-2354-4cc7-b46f-111fcf4e2108");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("16acd14f-1667-4e1b-9b02-4701ba21dfc4");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.МониторингФиксацияИсторииСотрудниковДвижения Движения
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
	Движения.ReferentName = "МониторингФиксацияИсторииСотрудниковДвижения";
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
	Движения.Guid = NsgService.StringToGuid("8029e23d-2e7d-45fa-8ac4-687480ca00e5");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.МониторингФиксацияИсторииСотрудниковДвижения Движения
			
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
	Владелец.Guid = NsgService.StringToGuid("3f614d0f-400e-4be0-8694-82478199341a");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание Мониторинг.СтатусСотрудника СтатусСотрудника
			{  
                NsgDataEnumReference СтатусСотрудника = null;
				if (ObjectList.Contains("СтатусСотрудника"))
                    СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                else
                    СтатусСотрудника = new NsgDataEnumReference();
	//NsgDataEnumReference
	СтатусСотрудника.IsLoadedFromDll = true;
	СтатусСотрудника.ReferentGroup = "Мониторинг";
	СтатусСотрудника.ReferentName = "СтатусСотрудника";
	СтатусСотрудника.SaveInDatabase = true;
	СтатусСотрудника.OwnerName = "";
	СтатусСотрудника.AllowEmptyOwner = false;
	СтатусСотрудника.StringFormat = "";
	СтатусСотрудника.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	СтатусСотрудника.IncludeInPredefined = false;
	СтатусСотрудника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СтатусСотрудника.Required = false;
	СтатусСотрудника.EmptyValue = "";
	СтатусСотрудника.NullAllow = false;
	СтатусСотрудника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СтатусСотрудника.FieldName = "StatusSotrudnika";
	СтатусСотрудника.InformMetaDataOnValueChanged = false;
	СтатусСотрудника.Visible = true;
	СтатусСотрудника.Name = "СтатусСотрудника";
	СтатусСотрудника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусСотрудника.Description = "Статус сотрудника";
	СтатусСотрудника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СтатусСотрудника.GroupName = "";
	СтатусСотрудника.Guid = NsgService.StringToGuid("b89ab7b8-230c-4ed5-88e0-7db248e3d92f");
	
				if (!ObjectList.Contains("СтатусСотрудника"))
                    ObjectList.Add(СтатусСотрудника);
			}
			#endregion //создание Мониторинг.СтатусСотрудника СтатусСотрудника
			
			#region создание System.DateTime Время
			{  
                NsgDataDateTime Время = null;
				if (ObjectList.Contains("Время"))
                    Время = ObjectList["Время"] as NsgDataDateTime;
                else
                    Время = new NsgDataDateTime();
	//NsgDataDateTime
	Время.IsLoadedFromDll = true;
	Время.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Время.StringFormat = "";
	Время.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Время.IncludeInPredefined = false;
	Время.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Время.Required = false;
	Время.EmptyValue = "";
	Время.NullAllow = false;
	Время.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Время.FieldName = "Vremja";
	Время.SaveInDatabase = true;
	Время.InformMetaDataOnValueChanged = false;
	Время.Visible = true;
	Время.Name = "Время";
	Время.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Время.Description = "Время";
	Время.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Время.GroupName = "";
	Время.Guid = NsgService.StringToGuid("0d6b37d0-3c02-4849-b390-6048bf793df6");
	
				if (!ObjectList.Contains("Время"))
                    ObjectList.Add(Время);
			}
			#endregion //создание System.DateTime Время
			
			#region создание System.Int64 НомерСмены
			{  
                NsgDataInteger НомерСмены = null;
				if (ObjectList.Contains("НомерСмены"))
                    НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                else
                    НомерСмены = new NsgDataInteger();
	//NsgDataInteger
	НомерСмены.IsLoadedFromDll = true;
	НомерСмены.DefaultValue = 0M;
	НомерСмены.MinValue = 0M;
	НомерСмены.MaxValue = 0M;
	НомерСмены.UseCalculator = true;
	НомерСмены.StringFormat = "";
	НомерСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	НомерСмены.IncludeInPredefined = false;
	НомерСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСмены.Required = false;
	НомерСмены.EmptyValue = "";
	НомерСмены.NullAllow = false;
	НомерСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСмены.FieldName = "NomerSmeny";
	НомерСмены.SaveInDatabase = true;
	НомерСмены.InformMetaDataOnValueChanged = false;
	НомерСмены.Visible = true;
	НомерСмены.Name = "НомерСмены";
	НомерСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСмены.Description = "Номер смены";
	НомерСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерСмены.GroupName = "";
	НомерСмены.Guid = NsgService.StringToGuid("9347e562-65a7-43ca-b893-eb9e7e40693f");
	
				if (!ObjectList.Contains("НомерСмены"))
                    ObjectList.Add(НомерСмены);
			}
			#endregion //создание System.Int64 НомерСмены
			
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
	Сотрудники.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Сотрудники.IncludeInPredefined = false;
	Сотрудники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудники.Required = false;
	Сотрудники.EmptyValue = "";
	Сотрудники.NullAllow = false;
	Сотрудники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сотрудники.FieldName = "Sotrudniki";
	Сотрудники.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Сотрудники.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Сотрудники.CharactericticWeight = 1;
	Сотрудники.InformMetaDataOnValueChanged = false;
	Сотрудники.Visible = true;
	Сотрудники.Name = "Сотрудники";
	Сотрудники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудники.Description = "Сотрудники";
	Сотрудники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудники.GroupName = "";
	Сотрудники.Guid = NsgService.StringToGuid("212e6208-3618-47c2-ab49-1aeaf5d0b051");
	
				if (!ObjectList.Contains("Сотрудники"))
                    ObjectList.Add(Сотрудники);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудники
			
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
	Тариф.Guid = NsgService.StringToGuid("af3ebdf3-6fba-4559-9a7f-700009310d10");
	
				if (!ObjectList.Contains("Тариф"))
                    ObjectList.Add(Тариф);
			}
			#endregion //создание Мониторинг.Тарифы Тариф
			
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
	Объект.Guid = NsgService.StringToGuid("9d449ff2-06a2-40ae-a897-43782154d9e2");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = false;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "ФиксацияИсторииСотрудников";
	Visible = true;
	Guid = NsgService.StringToGuid("13ff2378-5ed8-4049-94e1-13b17aedf0c1");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_FiksacijaIstoriiSot";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Фиксация истории (без техники)"});
	Description = "Фиксация истории (без техники)";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
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
            /// Статус сотрудника
            /// </summary>
            public static String СтатусСотрудника
            {
                get
                {
                    return "СтатусСотрудника";
                }
            }
            
            /// <summary>
            /// Время
            /// </summary>
            public static String Время
            {
                get
                {
                    return "Время";
                }
            }
            
            /// <summary>
            /// Номер смены
            /// </summary>
            public static String НомерСмены
            {
                get
                {
                    return "НомерСмены";
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
                    descriptor.Name = "ФиксацияИсторииСотрудников";
                    descriptor.GroupName = "Мониторинг";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Мониторинг.ФиксацияИсторииСотрудников";
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
        
        public _SystemTables.МониторингФиксацияИсторииСотрудниковДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.МониторингФиксацияИсторииСотрудниковДвижения)__Движения.Referent;
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
        /// Статус сотрудника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.СтатусСотрудника СтатусСотрудника
        {
            get
            {
				 NsgDataEnumReference __СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                 return (Мониторинг.СтатусСотрудника)__СтатусСотрудника.Referent;
            }
            set
            {
                NsgDataEnumReference __СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                __СтатусСотрудника.Referent = value;
            }
        }
        
        /// <summary>
        /// Время
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime Время
        {
            get
            {
				 NsgDataDateTime __Время = ObjectList["Время"] as NsgDataDateTime;
                 return (System.DateTime)__Время.Value;
            }
            set
            {
                NsgDataDateTime __Время = ObjectList["Время"] as NsgDataDateTime;
                __Время.Value = value;
            }
        }
        
        /// <summary>
        /// Номер смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСмены
        {
            get
            {
				 NsgDataInteger __НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                 return (System.Int64)__НомерСмены.Value;
            }
            set
            {
                NsgDataInteger __НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                __НомерСмены.Value = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataCharacteristics
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataCharacteristics

        #region Методы NsgMultipleObject
        private ФиксацияИсторииСотрудников[] convertArray(NsgMultipleObject[] array)
        {
            ФиксацияИсторииСотрудников[] res = new ФиксацияИсторииСотрудников[array.Length];
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
        public new virtual ФиксацияИсторииСотрудников[] FindAll(NsgCompare compare)
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
        public new virtual ФиксацияИсторииСотрудников[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ФиксацияИсторииСотрудников[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ФиксацияИсторииСотрудников[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ФиксацияИсторииСотрудников(this as NsgObject);
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
                base.NSGType = typeof(ФиксацияИсторииСотрудников);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ФиксацияИсторииСотрудников Value
            {
                get
                {
                    return (ФиксацияИсторииСотрудников)base.Value;
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
