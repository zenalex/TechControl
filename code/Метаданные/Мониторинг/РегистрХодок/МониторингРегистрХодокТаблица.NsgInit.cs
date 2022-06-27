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
    
    [NsgTypeName("NsgDataTable", Guid = "2c251389-5460-420f-9c14-3a3a5e25c09e")]
    public partial class МониторингРегистрХодокТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингРегистрХодокТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингРегистрХодокТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингРегистрХодокТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("2c251389-5460-420f-9c14-3a3a5e25c09e"));
            if (obj == null)
                obj = new МониторингРегистрХодокТаблица();
            return obj as МониторингРегистрХодокТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("c86d36b8-156d-4e5b-9797-e58d94a6f3b3");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("3202aef9-9b23-4a21-881b-3ac8c4260e7e");
	
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
	Владелец.FilterForConfigurator = "Мониторинг.РегистрХодок";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("505aa287-ee73-4936-a27f-fe11bf55c3df");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.Int64 НомерСтроки
			{  
                NsgDataInteger НомерСтроки = null;
				if (ObjectList.Contains("НомерСтроки"))
                    НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                else
                    НомерСтроки = new NsgDataInteger();
	//NsgDataInteger
	НомерСтроки.IsLoadedFromDll = true;
	НомерСтроки.DefaultValue = 0M;
	НомерСтроки.MinValue = 0M;
	НомерСтроки.MaxValue = 0M;
	НомерСтроки.UseCalculator = true;
	НомерСтроки.StringFormat = "";
	НомерСтроки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерСтроки.IncludeInPredefined = false;
	НомерСтроки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСтроки.Required = false;
	НомерСтроки.EmptyValue = "";
	НомерСтроки.NullAllow = false;
	НомерСтроки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСтроки.FieldName = "_RowNumber";
	НомерСтроки.SaveInDatabase = true;
	НомерСтроки.InformMetaDataOnValueChanged = false;
	НомерСтроки.Visible = true;
	НомерСтроки.Name = "НомерСтроки";
	НомерСтроки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСтроки.Description = "Номер строки";
	НомерСтроки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	НомерСтроки.GroupName = "";
	НомерСтроки.Guid = NsgService.StringToGuid("93804970-054f-47da-951a-3c5d00bf3663");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.DateTime ВремяПриездаНаГеозону
			{  
                NsgDataDateTime ВремяПриездаНаГеозону = null;
				if (ObjectList.Contains("ВремяПриездаНаГеозону"))
                    ВремяПриездаНаГеозону = ObjectList["ВремяПриездаНаГеозону"] as NsgDataDateTime;
                else
                    ВремяПриездаНаГеозону = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяПриездаНаГеозону.IsLoadedFromDll = true;
	ВремяПриездаНаГеозону.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ВремяПриездаНаГеозону.StringFormat = "";
	ВремяПриездаНаГеозону.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяПриездаНаГеозону.IncludeInPredefined = false;
	ВремяПриездаНаГеозону.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяПриездаНаГеозону.Required = false;
	ВремяПриездаНаГеозону.EmptyValue = "";
	ВремяПриездаНаГеозону.NullAllow = false;
	ВремяПриездаНаГеозону.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяПриездаНаГеозону.FieldName = "VremjaPriezdaNaGe";
	ВремяПриездаНаГеозону.SaveInDatabase = true;
	ВремяПриездаНаГеозону.InformMetaDataOnValueChanged = false;
	ВремяПриездаНаГеозону.Visible = true;
	ВремяПриездаНаГеозону.Name = "ВремяПриездаНаГеозону";
	ВремяПриездаНаГеозону.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяПриездаНаГеозону.Description = "Время приезда на геозону";
	ВремяПриездаНаГеозону.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяПриездаНаГеозону.GroupName = "";
	ВремяПриездаНаГеозону.Guid = NsgService.StringToGuid("ba338a62-1ca6-4c8a-9678-08b1fb373852");
	
				if (!ObjectList.Contains("ВремяПриездаНаГеозону"))
                    ObjectList.Add(ВремяПриездаНаГеозону);
			}
			#endregion //создание System.DateTime ВремяПриездаНаГеозону
			
			#region создание Мониторинг.Объекты Объекты
			{  
                NsgDataTypedReference Объекты = null;
				if (ObjectList.Contains("Объекты"))
                    Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                else
                    Объекты = new NsgDataTypedReference();
	//NsgDataTypedReference
	Объекты.IsLoadedFromDll = true;
	Объекты.ReferentGroup = "Мониторинг";
	Объекты.ReferentName = "Объекты";
	Объекты.SaveInDatabase = true;
	Объекты.OwnerName = "";
	Объекты.AllowEmptyOwner = false;
	Объекты.StringFormat = "";
	Объекты.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Объекты.IncludeInPredefined = false;
	Объекты.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объекты.Required = false;
	Объекты.EmptyValue = "";
	Объекты.NullAllow = false;
	Объекты.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Объекты.FieldName = "Obekty";
	Объекты.InformMetaDataOnValueChanged = false;
	Объекты.Visible = true;
	Объекты.Name = "Объекты";
	Объекты.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объекты.Description = "Объекты";
	Объекты.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объекты.GroupName = "";
	Объекты.Guid = NsgService.StringToGuid("4d7ac02e-ec25-4829-8225-cd7d8b3b4e97");
	
				if (!ObjectList.Contains("Объекты"))
                    ObjectList.Add(Объекты);
			}
			#endregion //создание Мониторинг.Объекты Объекты
			
			#region создание Мониторинг.Геозоны Геозона
			{  
                NsgDataTypedReference Геозона = null;
				if (ObjectList.Contains("Геозона"))
                    Геозона = ObjectList["Геозона"] as NsgDataTypedReference;
                else
                    Геозона = new NsgDataTypedReference();
	//NsgDataTypedReference
	Геозона.IsLoadedFromDll = true;
	Геозона.ReferentGroup = "Мониторинг";
	Геозона.ReferentName = "Геозоны";
	Геозона.SaveInDatabase = true;
	Геозона.OwnerName = "";
	Геозона.AllowEmptyOwner = false;
	Геозона.StringFormat = "";
	Геозона.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Геозона.IncludeInPredefined = false;
	Геозона.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Геозона.Required = false;
	Геозона.EmptyValue = "";
	Геозона.NullAllow = false;
	Геозона.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Геозона.FieldName = "Geozona";
	Геозона.InformMetaDataOnValueChanged = false;
	Геозона.Visible = true;
	Геозона.Name = "Геозона";
	Геозона.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Геозона.Description = "Геозона";
	Геозона.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Геозона.GroupName = "";
	Геозона.Guid = NsgService.StringToGuid("db6592bd-fe6b-445e-8b81-b1e93d8e3a75");
	
				if (!ObjectList.Contains("Геозона"))
                    ObjectList.Add(Геозона);
			}
			#endregion //создание Мониторинг.Геозоны Геозона
			
			#region создание System.DateTime ВремяВыездаИзГеозоны
			{  
                NsgDataDateTime ВремяВыездаИзГеозоны = null;
				if (ObjectList.Contains("ВремяВыездаИзГеозоны"))
                    ВремяВыездаИзГеозоны = ObjectList["ВремяВыездаИзГеозоны"] as NsgDataDateTime;
                else
                    ВремяВыездаИзГеозоны = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяВыездаИзГеозоны.IsLoadedFromDll = true;
	ВремяВыездаИзГеозоны.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ВремяВыездаИзГеозоны.StringFormat = "";
	ВремяВыездаИзГеозоны.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяВыездаИзГеозоны.IncludeInPredefined = false;
	ВремяВыездаИзГеозоны.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяВыездаИзГеозоны.Required = false;
	ВремяВыездаИзГеозоны.EmptyValue = "";
	ВремяВыездаИзГеозоны.NullAllow = false;
	ВремяВыездаИзГеозоны.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяВыездаИзГеозоны.FieldName = "VremjaVyezdaIzGeo";
	ВремяВыездаИзГеозоны.SaveInDatabase = true;
	ВремяВыездаИзГеозоны.InformMetaDataOnValueChanged = false;
	ВремяВыездаИзГеозоны.Visible = true;
	ВремяВыездаИзГеозоны.Name = "ВремяВыездаИзГеозоны";
	ВремяВыездаИзГеозоны.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяВыездаИзГеозоны.Description = "Время выезда из геозоны";
	ВремяВыездаИзГеозоны.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяВыездаИзГеозоны.GroupName = "";
	ВремяВыездаИзГеозоны.Guid = NsgService.StringToGuid("9052c2a5-a449-4077-bff5-346625abc9e9");
	
				if (!ObjectList.Contains("ВремяВыездаИзГеозоны"))
                    ObjectList.Add(ВремяВыездаИзГеозоны);
			}
			#endregion //создание System.DateTime ВремяВыездаИзГеозоны
			
			#region создание System.DateTime ВремяПриездаНаОбъект
			{  
                NsgDataDateTime ВремяПриездаНаОбъект = null;
				if (ObjectList.Contains("ВремяПриездаНаОбъект"))
                    ВремяПриездаНаОбъект = ObjectList["ВремяПриездаНаОбъект"] as NsgDataDateTime;
                else
                    ВремяПриездаНаОбъект = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяПриездаНаОбъект.IsLoadedFromDll = true;
	ВремяПриездаНаОбъект.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ВремяПриездаНаОбъект.StringFormat = "";
	ВремяПриездаНаОбъект.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяПриездаНаОбъект.IncludeInPredefined = false;
	ВремяПриездаНаОбъект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяПриездаНаОбъект.Required = false;
	ВремяПриездаНаОбъект.EmptyValue = "";
	ВремяПриездаНаОбъект.NullAllow = false;
	ВремяПриездаНаОбъект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяПриездаНаОбъект.FieldName = "VremjaPriezdaNaObekt";
	ВремяПриездаНаОбъект.SaveInDatabase = true;
	ВремяПриездаНаОбъект.InformMetaDataOnValueChanged = false;
	ВремяПриездаНаОбъект.Visible = true;
	ВремяПриездаНаОбъект.Name = "ВремяПриездаНаОбъект";
	ВремяПриездаНаОбъект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяПриездаНаОбъект.Description = "Время приезда на объект";
	ВремяПриездаНаОбъект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяПриездаНаОбъект.GroupName = "";
	ВремяПриездаНаОбъект.Guid = NsgService.StringToGuid("266e5f98-2b8f-4772-8c38-319f27af52b4");
	
				if (!ObjectList.Contains("ВремяПриездаНаОбъект"))
                    ObjectList.Add(ВремяПриездаНаОбъект);
			}
			#endregion //создание System.DateTime ВремяПриездаНаОбъект
			
			#region создание System.DateTime ВремяВыездаИзОбъекта
			{  
                NsgDataDateTime ВремяВыездаИзОбъекта = null;
				if (ObjectList.Contains("ВремяВыездаИзОбъекта"))
                    ВремяВыездаИзОбъекта = ObjectList["ВремяВыездаИзОбъекта"] as NsgDataDateTime;
                else
                    ВремяВыездаИзОбъекта = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяВыездаИзОбъекта.IsLoadedFromDll = true;
	ВремяВыездаИзОбъекта.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ВремяВыездаИзОбъекта.StringFormat = "";
	ВремяВыездаИзОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяВыездаИзОбъекта.IncludeInPredefined = false;
	ВремяВыездаИзОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяВыездаИзОбъекта.Required = false;
	ВремяВыездаИзОбъекта.EmptyValue = "";
	ВремяВыездаИзОбъекта.NullAllow = false;
	ВремяВыездаИзОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяВыездаИзОбъекта.FieldName = "VremjaVyezdaIzObekta";
	ВремяВыездаИзОбъекта.SaveInDatabase = true;
	ВремяВыездаИзОбъекта.InformMetaDataOnValueChanged = false;
	ВремяВыездаИзОбъекта.Visible = true;
	ВремяВыездаИзОбъекта.Name = "ВремяВыездаИзОбъекта";
	ВремяВыездаИзОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяВыездаИзОбъекта.Description = "Время выезда из объекта";
	ВремяВыездаИзОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяВыездаИзОбъекта.GroupName = "";
	ВремяВыездаИзОбъекта.Guid = NsgService.StringToGuid("d5ab3761-b527-4156-bd3c-a5539be2beba");
	
				if (!ObjectList.Contains("ВремяВыездаИзОбъекта"))
                    ObjectList.Add(ВремяВыездаИзОбъекта);
			}
			#endregion //создание System.DateTime ВремяВыездаИзОбъекта
			
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
	Техника.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Техника.IncludeInPredefined = false;
	Техника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Техника.Required = false;
	Техника.EmptyValue = "";
	Техника.NullAllow = false;
	Техника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Техника.FieldName = "Tekhnika";
	Техника.InformMetaDataOnValueChanged = false;
	Техника.Visible = true;
	Техника.Name = "Техника";
	Техника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Техника.Description = "Техника";
	Техника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Техника.GroupName = "";
	Техника.Guid = NsgService.StringToGuid("56f8dd1f-04cb-4caa-ab71-f2eafdd0bd4f");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.РегистрХодок";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингРегистрХодокТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("2c251389-5460-420f-9c14-3a3a5e25c09e");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringRegistrKH";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг регистр ходок таблица";
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
            /// Время приезда на геозону
            /// </summary>
            public static String ВремяПриездаНаГеозону
            {
                get
                {
                    return "ВремяПриездаНаГеозону";
                }
            }
            
            /// <summary>
            /// Объекты
            /// </summary>
            public static String Объекты
            {
                get
                {
                    return "Объекты";
                }
            }
            
            /// <summary>
            /// Геозона
            /// </summary>
            public static String Геозона
            {
                get
                {
                    return "Геозона";
                }
            }
            
            /// <summary>
            /// Время выезда из геозоны
            /// </summary>
            public static String ВремяВыездаИзГеозоны
            {
                get
                {
                    return "ВремяВыездаИзГеозоны";
                }
            }
            
            /// <summary>
            /// Время приезда на объект
            /// </summary>
            public static String ВремяПриездаНаОбъект
            {
                get
                {
                    return "ВремяПриездаНаОбъект";
                }
            }
            
            /// <summary>
            /// Время выезда из объекта
            /// </summary>
            public static String ВремяВыездаИзОбъекта
            {
                get
                {
                    return "ВремяВыездаИзОбъекта";
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
                    descriptor.Name = "МониторингРегистрХодокТаблица";
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
            return "_SystemTables.МониторингРегистрХодокТаблица";
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
        [NsgReferentsFilterAttribute("Мониторинг.РегистрХодок")]
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
        /// Время приезда на геозону
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяПриездаНаГеозону
        {
            get
            {
				 NsgDataDateTime __ВремяПриездаНаГеозону = ObjectList["ВремяПриездаНаГеозону"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяПриездаНаГеозону.Value;
            }
            set
            {
                NsgDataDateTime __ВремяПриездаНаГеозону = ObjectList["ВремяПриездаНаГеозону"] as NsgDataDateTime;
                __ВремяПриездаНаГеозону.Value = value;
            }
        }
        
        /// <summary>
        /// Объекты
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Объекты Объекты
        {
            get
            {
				 NsgDataTypedReference __Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                 return (Мониторинг.Объекты)__Объекты.Referent;
            }
            set
            {
                NsgDataTypedReference __Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                __Объекты.Referent = value;
            }
        }
        
        /// <summary>
        /// Геозона
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Геозоны Геозона
        {
            get
            {
				 NsgDataTypedReference __Геозона = ObjectList["Геозона"] as NsgDataTypedReference;
                 return (Мониторинг.Геозоны)__Геозона.Referent;
            }
            set
            {
                NsgDataTypedReference __Геозона = ObjectList["Геозона"] as NsgDataTypedReference;
                __Геозона.Referent = value;
            }
        }
        
        /// <summary>
        /// Время выезда из геозоны
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяВыездаИзГеозоны
        {
            get
            {
				 NsgDataDateTime __ВремяВыездаИзГеозоны = ObjectList["ВремяВыездаИзГеозоны"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяВыездаИзГеозоны.Value;
            }
            set
            {
                NsgDataDateTime __ВремяВыездаИзГеозоны = ObjectList["ВремяВыездаИзГеозоны"] as NsgDataDateTime;
                __ВремяВыездаИзГеозоны.Value = value;
            }
        }
        
        /// <summary>
        /// Время приезда на объект
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяПриездаНаОбъект
        {
            get
            {
				 NsgDataDateTime __ВремяПриездаНаОбъект = ObjectList["ВремяПриездаНаОбъект"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяПриездаНаОбъект.Value;
            }
            set
            {
                NsgDataDateTime __ВремяПриездаНаОбъект = ObjectList["ВремяПриездаНаОбъект"] as NsgDataDateTime;
                __ВремяПриездаНаОбъект.Value = value;
            }
        }
        
        /// <summary>
        /// Время выезда из объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяВыездаИзОбъекта
        {
            get
            {
				 NsgDataDateTime __ВремяВыездаИзОбъекта = ObjectList["ВремяВыездаИзОбъекта"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяВыездаИзОбъекта.Value;
            }
            set
            {
                NsgDataDateTime __ВремяВыездаИзОбъекта = ObjectList["ВремяВыездаИзОбъекта"] as NsgDataDateTime;
                __ВремяВыездаИзОбъекта.Value = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new МониторингРегистрХодокТаблица.Строка NewRow()
        {
            return newRow(null) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингРегистрХодокТаблица.Строка(this);
            return base.newRow(row) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингРегистрХодокТаблица.Строка NewRow(МониторингРегистрХодокТаблица.Строка inRow)
        {
            МониторингРегистрХодокТаблица.Строка row = inRow.Clone as МониторингРегистрХодокТаблица.Строка;
            return base.newRow(row) as МониторингРегистрХодокТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингРегистрХодокТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингРегистрХодокТаблица.Строка GetEtalonRow()
        {
            МониторингРегистрХодокТаблица.Строка row = new МониторингРегистрХодокТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингРегистрХодокТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингРегистрХодокТаблица.Строка[] res = new МониторингРегистрХодокТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрХодокТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрХодокТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингРегистрХодокТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингРегистрХодокТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингРегистрХодокТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингРегистрХодокТаблица.Строка[] AllRows
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
        public new МониторингРегистрХодокТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингРегистрХодокТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингРегистрХодокТаблица[] convertArray(NsgMultipleObject[] array)
        {
            МониторингРегистрХодокТаблица[] res = new МониторингРегистрХодокТаблица[array.Length];
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
        public new virtual МониторингРегистрХодокТаблица[] FindAll(NsgCompare compare)
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
        public new virtual МониторингРегистрХодокТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингРегистрХодокТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингРегистрХодокТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингРегистрХодокТаблица(this as NsgObject);
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
                base.NSGType = typeof(МониторингРегистрХодокТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингРегистрХодокТаблица Value
            {
                get
                {
                    return (МониторингРегистрХодокТаблица)base.Value;
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
