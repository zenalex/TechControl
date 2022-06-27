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
    
    [NsgTypeName("NsgDataTable", Guid = "fc35b4d0-2c11-43cf-8fa0-477c1cf9fb4f")]
    public partial class МониторингРегистрацияХодокТабличнаяЧасть : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингРегистрацияХодокТабличнаяЧасть()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингРегистрацияХодокТабличнаяЧасть(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингРегистрацияХодокТабличнаяЧасть Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("fc35b4d0-2c11-43cf-8fa0-477c1cf9fb4f"));
            if (obj == null)
                obj = new МониторингРегистрацияХодокТабличнаяЧасть();
            return obj as МониторингРегистрацияХодокТабличнаяЧасть;
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
	Идентификатор.Guid = NsgService.StringToGuid("294e44bb-0373-4730-ba19-ca25f3d434e5");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("b227e458-0b6c-4a9a-b29d-889a84c415ba");
	
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
	Владелец.FilterForConfigurator = "Мониторинг.РегистрацияХодок";
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
	Владелец.Guid = NsgService.StringToGuid("c7943152-c261-4482-ba25-1d9ccb2eede2");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("af74bc76-af79-43f6-96f4-9cd967e0d07e");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
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
	Техника.Guid = NsgService.StringToGuid("d91f6a63-1c08-4e8c-9b3b-f1b6d9786f23");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
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
	ВремяПриездаНаГеозону.Guid = NsgService.StringToGuid("cec230bf-e51b-4c4f-a04c-8d7fb1f55a35");
	
				if (!ObjectList.Contains("ВремяПриездаНаГеозону"))
                    ObjectList.Add(ВремяПриездаНаГеозону);
			}
			#endregion //создание System.DateTime ВремяПриездаНаГеозону
			
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
	ВремяВыездаИзГеозоны.Guid = NsgService.StringToGuid("e00685b8-354f-413b-b6a7-943cd99cc102");
	
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
	ВремяПриездаНаОбъект.Guid = NsgService.StringToGuid("eddd6bd4-8e5b-4575-a17b-5b9eafa38c3a");
	
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
	ВремяВыездаИзОбъекта.Guid = NsgService.StringToGuid("7c273666-7b97-4600-b34f-e1b8852f41bb");
	
				if (!ObjectList.Contains("ВремяВыездаИзОбъекта"))
                    ObjectList.Add(ВремяВыездаИзОбъекта);
			}
			#endregion //создание System.DateTime ВремяВыездаИзОбъекта
			
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
	Объект.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Объект.IncludeInPredefined = false;
	Объект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объект.Required = false;
	Объект.EmptyValue = "";
	Объект.NullAllow = false;
	Объект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Объект.FieldName = "Obekt";
	Объект.InformMetaDataOnValueChanged = false;
	Объект.Visible = true;
	Объект.Name = "Объект";
	Объект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объект.Description = "Объект";
	Объект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объект.GroupName = "";
	Объект.Guid = NsgService.StringToGuid("f3ef33d8-f801-4902-a1d9-61896d33fd2c");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	Геозона.Guid = NsgService.StringToGuid("031413db-25a0-435f-a51e-b6a724483dde");
	
				if (!ObjectList.Contains("Геозона"))
                    ObjectList.Add(Геозона);
			}
			#endregion //создание Мониторинг.Геозоны Геозона
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.РегистрацияХодок";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингРегистрацияХодокТабличнаяЧасть";
	Visible = true;
	Guid = NsgService.StringToGuid("fc35b4d0-2c11-43cf-8fa0-477c1cf9fb4f");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringRegistrac";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг регистрация ходок табличная часть";
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
            /// Геозона
            /// </summary>
            public static String Геозона
            {
                get
                {
                    return "Геозона";
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
                    descriptor.Name = "МониторингРегистрацияХодокТабличнаяЧасть";
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
            return "_SystemTables.МониторингРегистрацияХодокТабличнаяЧасть";
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
        [NsgReferentsFilterAttribute("Мониторинг.РегистрацияХодок")]
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка NewRow()
        {
            return newRow(null) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингРегистрацияХодокТабличнаяЧасть.Строка(this);
            return base.newRow(row) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингРегистрацияХодокТабличнаяЧасть.Строка NewRow(МониторингРегистрацияХодокТабличнаяЧасть.Строка inRow)
        {
            МониторингРегистрацияХодокТабличнаяЧасть.Строка row = inRow.Clone as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
            return base.newRow(row) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка GetEtalonRow()
        {
            МониторингРегистрацияХодокТабличнаяЧасть.Строка row = new МониторингРегистрацияХодокТабличнаяЧасть.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингРегистрацияХодокТабличнаяЧасть.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингРегистрацияХодокТабличнаяЧасть.Строка[] res = new МониторингРегистрацияХодокТабличнаяЧасть.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингРегистрацияХодокТабличнаяЧасть> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингРегистрацияХодокТабличнаяЧасть>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка[] AllRows
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
        public new МониторингРегистрацияХодокТабличнаяЧасть.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингРегистрацияХодокТабличнаяЧасть.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингРегистрацияХодокТабличнаяЧасть[] convertArray(NsgMultipleObject[] array)
        {
            МониторингРегистрацияХодокТабличнаяЧасть[] res = new МониторингРегистрацияХодокТабличнаяЧасть[array.Length];
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
        public new virtual МониторингРегистрацияХодокТабличнаяЧасть[] FindAll(NsgCompare compare)
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
        public new virtual МониторингРегистрацияХодокТабличнаяЧасть[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингРегистрацияХодокТабличнаяЧасть[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингРегистрацияХодокТабличнаяЧасть[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингРегистрацияХодокТабличнаяЧасть(this as NsgObject);
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
                base.NSGType = typeof(МониторингРегистрацияХодокТабличнаяЧасть);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингРегистрацияХодокТабличнаяЧасть Value
            {
                get
                {
                    return (МониторингРегистрацияХодокТабличнаяЧасть)base.Value;
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
