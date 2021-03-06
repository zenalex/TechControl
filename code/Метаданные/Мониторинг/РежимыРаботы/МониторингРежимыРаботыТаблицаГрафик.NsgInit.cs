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
    
    [NsgTypeName("NsgDataTable", Guid = "5b76beb8-0f1f-481a-9451-f4c3126624a9")]
    public partial class МониторингРежимыРаботыТаблицаГрафик : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингРежимыРаботыТаблицаГрафик()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингРежимыРаботыТаблицаГрафик(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингРежимыРаботыТаблицаГрафик Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("5b76beb8-0f1f-481a-9451-f4c3126624a9"));
            if (obj == null)
                obj = new МониторингРежимыРаботыТаблицаГрафик();
            return obj as МониторингРежимыРаботыТаблицаГрафик;
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
	Идентификатор.Guid = NsgService.StringToGuid("deca13e3-b210-4e47-8aaf-59ba30d5ffb7");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("3024152d-b732-42f5-9065-39da5a558a91");
	
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
	Владелец.FilterForConfigurator = "Мониторинг.РежимыРаботы";
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
	Владелец.Guid = NsgService.StringToGuid("08b928d8-673a-489a-bc11-dbee4d2fb47a");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("fdc684a0-d7ff-413d-a686-ce28f1b5917f");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Мониторинг.ДеньНедели ДеньНедели
			{  
                NsgDataEnumReference ДеньНедели = null;
				if (ObjectList.Contains("ДеньНедели"))
                    ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                else
                    ДеньНедели = new NsgDataEnumReference();
	//NsgDataEnumReference
	ДеньНедели.IsLoadedFromDll = true;
	ДеньНедели.ReferentGroup = "Мониторинг";
	ДеньНедели.ReferentName = "ДеньНедели";
	ДеньНедели.SaveInDatabase = true;
	ДеньНедели.OwnerName = "";
	ДеньНедели.AllowEmptyOwner = false;
	ДеньНедели.StringFormat = "";
	ДеньНедели.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДеньНедели.IncludeInPredefined = false;
	ДеньНедели.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДеньНедели.Required = false;
	ДеньНедели.EmptyValue = "";
	ДеньНедели.NullAllow = false;
	ДеньНедели.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДеньНедели.FieldName = "DenNedeli";
	ДеньНедели.InformMetaDataOnValueChanged = false;
	ДеньНедели.Visible = true;
	ДеньНедели.Name = "ДеньНедели";
	ДеньНедели.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДеньНедели.Description = "День недели";
	ДеньНедели.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДеньНедели.GroupName = "";
	ДеньНедели.Guid = NsgService.StringToGuid("d064fff9-ff18-4482-a10c-b4f78f2471ab");
	
				if (!ObjectList.Contains("ДеньНедели"))
                    ObjectList.Add(ДеньНедели);
			}
			#endregion //создание Мониторинг.ДеньНедели ДеньНедели
			
			#region создание System.DateTime ВремяНачалаРабочегоДня
			{  
                NsgDataDateTime ВремяНачалаРабочегоДня = null;
				if (ObjectList.Contains("ВремяНачалаРабочегоДня"))
                    ВремяНачалаРабочегоДня = ObjectList["ВремяНачалаРабочегоДня"] as NsgDataDateTime;
                else
                    ВремяНачалаРабочегоДня = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаРабочегоДня.IsLoadedFromDll = true;
	ВремяНачалаРабочегоДня.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаРабочегоДня.StringFormat = "";
	ВремяНачалаРабочегоДня.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаРабочегоДня.IncludeInPredefined = false;
	ВремяНачалаРабочегоДня.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаРабочегоДня.Required = false;
	ВремяНачалаРабочегоДня.EmptyValue = "";
	ВремяНачалаРабочегоДня.NullAllow = false;
	ВремяНачалаРабочегоДня.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаРабочегоДня.FieldName = "VremjaNachalaRabo";
	ВремяНачалаРабочегоДня.SaveInDatabase = true;
	ВремяНачалаРабочегоДня.InformMetaDataOnValueChanged = false;
	ВремяНачалаРабочегоДня.Visible = true;
	ВремяНачалаРабочегоДня.Name = "ВремяНачалаРабочегоДня";
	ВремяНачалаРабочегоДня.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаРабочегоДня.Description = "Время начала рабочего дня";
	ВремяНачалаРабочегоДня.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаРабочегоДня.GroupName = "";
	ВремяНачалаРабочегоДня.Guid = NsgService.StringToGuid("624ea45c-e522-46ba-80cf-b79d9a49bb15");
	
				if (!ObjectList.Contains("ВремяНачалаРабочегоДня"))
                    ObjectList.Add(ВремяНачалаРабочегоДня);
			}
			#endregion //создание System.DateTime ВремяНачалаРабочегоДня
			
			#region создание System.DateTime ВремяКонцаРабочегоДня
			{  
                NsgDataDateTime ВремяКонцаРабочегоДня = null;
				if (ObjectList.Contains("ВремяКонцаРабочегоДня"))
                    ВремяКонцаРабочегоДня = ObjectList["ВремяКонцаРабочегоДня"] as NsgDataDateTime;
                else
                    ВремяКонцаРабочегоДня = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяКонцаРабочегоДня.IsLoadedFromDll = true;
	ВремяКонцаРабочегоДня.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяКонцаРабочегоДня.StringFormat = "";
	ВремяКонцаРабочегоДня.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяКонцаРабочегоДня.IncludeInPredefined = false;
	ВремяКонцаРабочегоДня.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяКонцаРабочегоДня.Required = false;
	ВремяКонцаРабочегоДня.EmptyValue = "";
	ВремяКонцаРабочегоДня.NullAllow = false;
	ВремяКонцаРабочегоДня.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяКонцаРабочегоДня.FieldName = "VremjaKoncaRaboch";
	ВремяКонцаРабочегоДня.SaveInDatabase = true;
	ВремяКонцаРабочегоДня.InformMetaDataOnValueChanged = false;
	ВремяКонцаРабочегоДня.Visible = true;
	ВремяКонцаРабочегоДня.Name = "ВремяКонцаРабочегоДня";
	ВремяКонцаРабочегоДня.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяКонцаРабочегоДня.Description = "Время конца рабочего дня";
	ВремяКонцаРабочегоДня.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяКонцаРабочегоДня.GroupName = "";
	ВремяКонцаРабочегоДня.Guid = NsgService.StringToGuid("266e0cf2-1d05-4f44-8793-e9677b8736a3");
	
				if (!ObjectList.Contains("ВремяКонцаРабочегоДня"))
                    ObjectList.Add(ВремяКонцаРабочегоДня);
			}
			#endregion //создание System.DateTime ВремяКонцаРабочегоДня
			
			#region создание System.DateTime ВремяНачалаПерерыва
			{  
                NsgDataDateTime ВремяНачалаПерерыва = null;
				if (ObjectList.Contains("ВремяНачалаПерерыва"))
                    ВремяНачалаПерерыва = ObjectList["ВремяНачалаПерерыва"] as NsgDataDateTime;
                else
                    ВремяНачалаПерерыва = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаПерерыва.IsLoadedFromDll = true;
	ВремяНачалаПерерыва.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаПерерыва.StringFormat = "";
	ВремяНачалаПерерыва.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаПерерыва.IncludeInPredefined = false;
	ВремяНачалаПерерыва.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаПерерыва.Required = false;
	ВремяНачалаПерерыва.EmptyValue = "";
	ВремяНачалаПерерыва.NullAllow = false;
	ВремяНачалаПерерыва.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаПерерыва.FieldName = "VremjaNachalaPere";
	ВремяНачалаПерерыва.SaveInDatabase = true;
	ВремяНачалаПерерыва.InformMetaDataOnValueChanged = false;
	ВремяНачалаПерерыва.Visible = true;
	ВремяНачалаПерерыва.Name = "ВремяНачалаПерерыва";
	ВремяНачалаПерерыва.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаПерерыва.Description = "Время начала перерыва";
	ВремяНачалаПерерыва.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаПерерыва.GroupName = "";
	ВремяНачалаПерерыва.Guid = NsgService.StringToGuid("783ac665-160a-4bae-88f1-f6a224b4488e");
	
				if (!ObjectList.Contains("ВремяНачалаПерерыва"))
                    ObjectList.Add(ВремяНачалаПерерыва);
			}
			#endregion //создание System.DateTime ВремяНачалаПерерыва
			
			#region создание System.DateTime ВремяКонцаПерерыва
			{  
                NsgDataDateTime ВремяКонцаПерерыва = null;
				if (ObjectList.Contains("ВремяКонцаПерерыва"))
                    ВремяКонцаПерерыва = ObjectList["ВремяКонцаПерерыва"] as NsgDataDateTime;
                else
                    ВремяКонцаПерерыва = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяКонцаПерерыва.IsLoadedFromDll = true;
	ВремяКонцаПерерыва.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяКонцаПерерыва.StringFormat = "";
	ВремяКонцаПерерыва.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяКонцаПерерыва.IncludeInPredefined = false;
	ВремяКонцаПерерыва.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяКонцаПерерыва.Required = false;
	ВремяКонцаПерерыва.EmptyValue = "";
	ВремяКонцаПерерыва.NullAllow = false;
	ВремяКонцаПерерыва.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяКонцаПерерыва.FieldName = "VremjaKoncaPereryva";
	ВремяКонцаПерерыва.SaveInDatabase = true;
	ВремяКонцаПерерыва.InformMetaDataOnValueChanged = false;
	ВремяКонцаПерерыва.Visible = true;
	ВремяКонцаПерерыва.Name = "ВремяКонцаПерерыва";
	ВремяКонцаПерерыва.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяКонцаПерерыва.Description = "Время конца перерыва";
	ВремяКонцаПерерыва.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяКонцаПерерыва.GroupName = "";
	ВремяКонцаПерерыва.Guid = NsgService.StringToGuid("91ec3800-4b71-47e8-afd5-7f0427b48d24");
	
				if (!ObjectList.Contains("ВремяКонцаПерерыва"))
                    ObjectList.Add(ВремяКонцаПерерыва);
			}
			#endregion //создание System.DateTime ВремяКонцаПерерыва
			
			#region создание System.DateTime ВремяОкончанияСмены1
			{  
                NsgDataDateTime ВремяОкончанияСмены1 = null;
				if (ObjectList.Contains("ВремяОкончанияСмены1"))
                    ВремяОкончанияСмены1 = ObjectList["ВремяОкончанияСмены1"] as NsgDataDateTime;
                else
                    ВремяОкончанияСмены1 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяОкончанияСмены1.IsLoadedFromDll = true;
	ВремяОкончанияСмены1.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяОкончанияСмены1.StringFormat = "";
	ВремяОкончанияСмены1.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяОкончанияСмены1.IncludeInPredefined = false;
	ВремяОкончанияСмены1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяОкончанияСмены1.Required = false;
	ВремяОкончанияСмены1.EmptyValue = "";
	ВремяОкончанияСмены1.NullAllow = false;
	ВремяОкончанияСмены1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяОкончанияСмены1.FieldName = "VremjaOkonchanija";
	ВремяОкончанияСмены1.SaveInDatabase = true;
	ВремяОкончанияСмены1.InformMetaDataOnValueChanged = false;
	ВремяОкончанияСмены1.Visible = true;
	ВремяОкончанияСмены1.Name = "ВремяОкончанияСмены1";
	ВремяОкончанияСмены1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяОкончанияСмены1.Description = "Время окончания смены1";
	ВремяОкончанияСмены1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяОкончанияСмены1.GroupName = "";
	ВремяОкончанияСмены1.Guid = NsgService.StringToGuid("c393e480-2642-46cf-ab23-e37ba3c32055");
	
				if (!ObjectList.Contains("ВремяОкончанияСмены1"))
                    ObjectList.Add(ВремяОкончанияСмены1);
			}
			#endregion //создание System.DateTime ВремяОкончанияСмены1
			
			#region создание System.DateTime ВремяНачалаСмены2
			{  
                NsgDataDateTime ВремяНачалаСмены2 = null;
				if (ObjectList.Contains("ВремяНачалаСмены2"))
                    ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены2 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены2.IsLoadedFromDll = true;
	ВремяНачалаСмены2.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены2.StringFormat = "";
	ВремяНачалаСмены2.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены2.IncludeInPredefined = false;
	ВремяНачалаСмены2.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены2.Required = false;
	ВремяНачалаСмены2.EmptyValue = "";
	ВремяНачалаСмены2.NullAllow = false;
	ВремяНачалаСмены2.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены2.FieldName = "VremjaNachalaSmeny2";
	ВремяНачалаСмены2.SaveInDatabase = true;
	ВремяНачалаСмены2.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены2.Visible = true;
	ВремяНачалаСмены2.Name = "ВремяНачалаСмены2";
	ВремяНачалаСмены2.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены2.Description = "Время начала смены2";
	ВремяНачалаСмены2.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены2.GroupName = "";
	ВремяНачалаСмены2.Guid = NsgService.StringToGuid("9628f27b-bddc-4aef-825e-0758950a1475");
	
				if (!ObjectList.Contains("ВремяНачалаСмены2"))
                    ObjectList.Add(ВремяНачалаСмены2);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены2
			
			#region создание System.DateTime ВремяНачалаСмены3
			{  
                NsgDataDateTime ВремяНачалаСмены3 = null;
				if (ObjectList.Contains("ВремяНачалаСмены3"))
                    ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены3 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены3.IsLoadedFromDll = true;
	ВремяНачалаСмены3.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены3.StringFormat = "";
	ВремяНачалаСмены3.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены3.IncludeInPredefined = false;
	ВремяНачалаСмены3.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены3.Required = false;
	ВремяНачалаСмены3.EmptyValue = "";
	ВремяНачалаСмены3.NullAllow = false;
	ВремяНачалаСмены3.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены3.FieldName = "VremjaNachalaSmeny3";
	ВремяНачалаСмены3.SaveInDatabase = true;
	ВремяНачалаСмены3.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены3.Visible = true;
	ВремяНачалаСмены3.Name = "ВремяНачалаСмены3";
	ВремяНачалаСмены3.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены3.Description = "Время начала смены3";
	ВремяНачалаСмены3.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены3.GroupName = "";
	ВремяНачалаСмены3.Guid = NsgService.StringToGuid("c238f978-89c4-45ef-950d-4244c6dfd01f");
	
				if (!ObjectList.Contains("ВремяНачалаСмены3"))
                    ObjectList.Add(ВремяНачалаСмены3);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены3
			
			#region создание System.DateTime ВремяОкончанияСмены2
			{  
                NsgDataDateTime ВремяОкончанияСмены2 = null;
				if (ObjectList.Contains("ВремяОкончанияСмены2"))
                    ВремяОкончанияСмены2 = ObjectList["ВремяОкончанияСмены2"] as NsgDataDateTime;
                else
                    ВремяОкончанияСмены2 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяОкончанияСмены2.IsLoadedFromDll = true;
	ВремяОкончанияСмены2.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяОкончанияСмены2.StringFormat = "";
	ВремяОкончанияСмены2.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяОкончанияСмены2.IncludeInPredefined = false;
	ВремяОкончанияСмены2.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяОкончанияСмены2.Required = false;
	ВремяОкончанияСмены2.EmptyValue = "";
	ВремяОкончанияСмены2.NullAllow = false;
	ВремяОкончанияСмены2.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяОкончанияСмены2.FieldName = "VremjaOkonchanija1";
	ВремяОкончанияСмены2.SaveInDatabase = true;
	ВремяОкончанияСмены2.InformMetaDataOnValueChanged = false;
	ВремяОкончанияСмены2.Visible = true;
	ВремяОкончанияСмены2.Name = "ВремяОкончанияСмены2";
	ВремяОкончанияСмены2.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяОкончанияСмены2.Description = "Время окончания смены2";
	ВремяОкончанияСмены2.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяОкончанияСмены2.GroupName = "";
	ВремяОкончанияСмены2.Guid = NsgService.StringToGuid("1bee1f82-6e86-4a1b-b414-3e525fa324ee");
	
				if (!ObjectList.Contains("ВремяОкончанияСмены2"))
                    ObjectList.Add(ВремяОкончанияСмены2);
			}
			#endregion //создание System.DateTime ВремяОкончанияСмены2
			
			#region создание System.DateTime ВремяОкончанияСмены3
			{  
                NsgDataDateTime ВремяОкончанияСмены3 = null;
				if (ObjectList.Contains("ВремяОкончанияСмены3"))
                    ВремяОкончанияСмены3 = ObjectList["ВремяОкончанияСмены3"] as NsgDataDateTime;
                else
                    ВремяОкончанияСмены3 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяОкончанияСмены3.IsLoadedFromDll = true;
	ВремяОкончанияСмены3.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяОкончанияСмены3.StringFormat = "";
	ВремяОкончанияСмены3.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяОкончанияСмены3.IncludeInPredefined = false;
	ВремяОкончанияСмены3.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяОкончанияСмены3.Required = false;
	ВремяОкончанияСмены3.EmptyValue = "";
	ВремяОкончанияСмены3.NullAllow = false;
	ВремяОкончанияСмены3.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяОкончанияСмены3.FieldName = "VremjaOkonchanija2";
	ВремяОкончанияСмены3.SaveInDatabase = true;
	ВремяОкончанияСмены3.InformMetaDataOnValueChanged = false;
	ВремяОкончанияСмены3.Visible = true;
	ВремяОкончанияСмены3.Name = "ВремяОкончанияСмены3";
	ВремяОкончанияСмены3.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяОкончанияСмены3.Description = "Время окончания смены3";
	ВремяОкончанияСмены3.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяОкончанияСмены3.GroupName = "";
	ВремяОкончанияСмены3.Guid = NsgService.StringToGuid("ead39fe1-af65-4d8e-b1e3-f165c263446a");
	
				if (!ObjectList.Contains("ВремяОкончанияСмены3"))
                    ObjectList.Add(ВремяОкончанияСмены3);
			}
			#endregion //создание System.DateTime ВремяОкончанияСмены3
			
			#region создание System.Int64 КоличествоСмен
			{  
                NsgDataInteger КоличествоСмен = null;
				if (ObjectList.Contains("КоличествоСмен"))
                    КоличествоСмен = ObjectList["КоличествоСмен"] as NsgDataInteger;
                else
                    КоличествоСмен = new NsgDataInteger();
	//NsgDataInteger
	КоличествоСмен.IsLoadedFromDll = true;
	КоличествоСмен.DefaultValue = 0M;
	КоличествоСмен.MinValue = 0M;
	КоличествоСмен.MaxValue = 0M;
	КоличествоСмен.UseCalculator = true;
	КоличествоСмен.StringFormat = "";
	КоличествоСмен.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КоличествоСмен.IncludeInPredefined = false;
	КоличествоСмен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоСмен.Required = false;
	КоличествоСмен.EmptyValue = "";
	КоличествоСмен.NullAllow = false;
	КоличествоСмен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоСмен.FieldName = "KolichestvoSmen";
	КоличествоСмен.SaveInDatabase = true;
	КоличествоСмен.InformMetaDataOnValueChanged = false;
	КоличествоСмен.Visible = true;
	КоличествоСмен.Name = "КоличествоСмен";
	КоличествоСмен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоСмен.Description = "Количество смен";
	КоличествоСмен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоСмен.GroupName = "";
	КоличествоСмен.Guid = NsgService.StringToGuid("55dcd644-8b0c-4d83-afc5-3019f650c49e");
	
				if (!ObjectList.Contains("КоличествоСмен"))
                    ObjectList.Add(КоличествоСмен);
			}
			#endregion //создание System.Int64 КоличествоСмен
			
			#region создание System.DateTime ВремяНачалаСмены1
			{  
                NsgDataDateTime ВремяНачалаСмены1 = null;
				if (ObjectList.Contains("ВремяНачалаСмены1"))
                    ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены1 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены1.IsLoadedFromDll = true;
	ВремяНачалаСмены1.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены1.StringFormat = "";
	ВремяНачалаСмены1.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены1.IncludeInPredefined = false;
	ВремяНачалаСмены1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены1.Required = false;
	ВремяНачалаСмены1.EmptyValue = "";
	ВремяНачалаСмены1.NullAllow = false;
	ВремяНачалаСмены1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены1.FieldName = "VremjaNachalaSmeny1";
	ВремяНачалаСмены1.SaveInDatabase = true;
	ВремяНачалаСмены1.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены1.Visible = true;
	ВремяНачалаСмены1.Name = "ВремяНачалаСмены1";
	ВремяНачалаСмены1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены1.Description = "Время начала смены1";
	ВремяНачалаСмены1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены1.GroupName = "";
	ВремяНачалаСмены1.Guid = NsgService.StringToGuid("dcdc7770-787b-4479-89fa-663a6e294319");
	
				if (!ObjectList.Contains("ВремяНачалаСмены1"))
                    ObjectList.Add(ВремяНачалаСмены1);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены1
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.РежимыРаботы";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингРежимыРаботыТаблицаГрафик";
	Visible = true;
	Guid = NsgService.StringToGuid("5b76beb8-0f1f-481a-9451-f4c3126624a9");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringRezhimyRa";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг режимы работы таблица график";
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
            /// День недели
            /// </summary>
            public static String ДеньНедели
            {
                get
                {
                    return "ДеньНедели";
                }
            }
            
            /// <summary>
            /// Время начала рабочего дня
            /// </summary>
            public static String ВремяНачалаРабочегоДня
            {
                get
                {
                    return "ВремяНачалаРабочегоДня";
                }
            }
            
            /// <summary>
            /// Время конца рабочего дня
            /// </summary>
            public static String ВремяКонцаРабочегоДня
            {
                get
                {
                    return "ВремяКонцаРабочегоДня";
                }
            }
            
            /// <summary>
            /// Время начала перерыва
            /// </summary>
            public static String ВремяНачалаПерерыва
            {
                get
                {
                    return "ВремяНачалаПерерыва";
                }
            }
            
            /// <summary>
            /// Время конца перерыва
            /// </summary>
            public static String ВремяКонцаПерерыва
            {
                get
                {
                    return "ВремяКонцаПерерыва";
                }
            }
            
            /// <summary>
            /// Время окончания смены1
            /// </summary>
            public static String ВремяОкончанияСмены1
            {
                get
                {
                    return "ВремяОкончанияСмены1";
                }
            }
            
            /// <summary>
            /// Время начала смены2
            /// </summary>
            public static String ВремяНачалаСмены2
            {
                get
                {
                    return "ВремяНачалаСмены2";
                }
            }
            
            /// <summary>
            /// Время начала смены3
            /// </summary>
            public static String ВремяНачалаСмены3
            {
                get
                {
                    return "ВремяНачалаСмены3";
                }
            }
            
            /// <summary>
            /// Время окончания смены2
            /// </summary>
            public static String ВремяОкончанияСмены2
            {
                get
                {
                    return "ВремяОкончанияСмены2";
                }
            }
            
            /// <summary>
            /// Время окончания смены3
            /// </summary>
            public static String ВремяОкончанияСмены3
            {
                get
                {
                    return "ВремяОкончанияСмены3";
                }
            }
            
            /// <summary>
            /// Количество смен
            /// </summary>
            public static String КоличествоСмен
            {
                get
                {
                    return "КоличествоСмен";
                }
            }
            
            /// <summary>
            /// Время начала смены1
            /// </summary>
            public static String ВремяНачалаСмены1
            {
                get
                {
                    return "ВремяНачалаСмены1";
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
                    descriptor.Name = "МониторингРежимыРаботыТаблицаГрафик";
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
            return "_SystemTables.МониторингРежимыРаботыТаблицаГрафик";
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
        [NsgReferentsFilterAttribute("Мониторинг.РежимыРаботы")]
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
        /// День недели
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ДеньНедели ДеньНедели
        {
            get
            {
				 NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                 return (Мониторинг.ДеньНедели)__ДеньНедели.Referent;
            }
            set
            {
                NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                __ДеньНедели.Referent = value;
            }
        }
        
        /// <summary>
        /// Время начала рабочего дня
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаРабочегоДня
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаРабочегоДня = ObjectList["ВремяНачалаРабочегоДня"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаРабочегоДня.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаРабочегоДня = ObjectList["ВремяНачалаРабочегоДня"] as NsgDataDateTime;
                __ВремяНачалаРабочегоДня.Value = value;
            }
        }
        
        /// <summary>
        /// Время конца рабочего дня
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяКонцаРабочегоДня
        {
            get
            {
				 NsgDataDateTime __ВремяКонцаРабочегоДня = ObjectList["ВремяКонцаРабочегоДня"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяКонцаРабочегоДня.Value;
            }
            set
            {
                NsgDataDateTime __ВремяКонцаРабочегоДня = ObjectList["ВремяКонцаРабочегоДня"] as NsgDataDateTime;
                __ВремяКонцаРабочегоДня.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала перерыва
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаПерерыва
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаПерерыва = ObjectList["ВремяНачалаПерерыва"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаПерерыва.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаПерерыва = ObjectList["ВремяНачалаПерерыва"] as NsgDataDateTime;
                __ВремяНачалаПерерыва.Value = value;
            }
        }
        
        /// <summary>
        /// Время конца перерыва
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяКонцаПерерыва
        {
            get
            {
				 NsgDataDateTime __ВремяКонцаПерерыва = ObjectList["ВремяКонцаПерерыва"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяКонцаПерерыва.Value;
            }
            set
            {
                NsgDataDateTime __ВремяКонцаПерерыва = ObjectList["ВремяКонцаПерерыва"] as NsgDataDateTime;
                __ВремяКонцаПерерыва.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены1
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены1 = ObjectList["ВремяОкончанияСмены1"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены1.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены1 = ObjectList["ВремяОкончанияСмены1"] as NsgDataDateTime;
                __ВремяОкончанияСмены1.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены2
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены2.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                __ВремяНачалаСмены2.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены3
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены3.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                __ВремяНачалаСмены3.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены2
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены2 = ObjectList["ВремяОкончанияСмены2"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены2.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены2 = ObjectList["ВремяОкончанияСмены2"] as NsgDataDateTime;
                __ВремяОкончанияСмены2.Value = value;
            }
        }
        
        /// <summary>
        /// Время окончания смены3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяОкончанияСмены3
        {
            get
            {
				 NsgDataDateTime __ВремяОкончанияСмены3 = ObjectList["ВремяОкончанияСмены3"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяОкончанияСмены3.Value;
            }
            set
            {
                NsgDataDateTime __ВремяОкончанияСмены3 = ObjectList["ВремяОкончанияСмены3"] as NsgDataDateTime;
                __ВремяОкончанияСмены3.Value = value;
            }
        }
        
        /// <summary>
        /// Количество смен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоСмен
        {
            get
            {
				 NsgDataInteger __КоличествоСмен = ObjectList["КоличествоСмен"] as NsgDataInteger;
                 return (System.Int64)__КоличествоСмен.Value;
            }
            set
            {
                NsgDataInteger __КоличествоСмен = ObjectList["КоличествоСмен"] as NsgDataInteger;
                __КоличествоСмен.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены1
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены1.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                __ВремяНачалаСмены1.Value = value;
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
        public new МониторингРежимыРаботыТаблицаГрафик.Строка NewRow()
        {
            return newRow(null) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингРежимыРаботыТаблицаГрафик.Строка(this);
            return base.newRow(row) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингРежимыРаботыТаблицаГрафик.Строка NewRow(МониторингРежимыРаботыТаблицаГрафик.Строка inRow)
        {
            МониторингРежимыРаботыТаблицаГрафик.Строка row = inRow.Clone as МониторингРежимыРаботыТаблицаГрафик.Строка;
            return base.newRow(row) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка GetEtalonRow()
        {
            МониторингРежимыРаботыТаблицаГрафик.Строка row = new МониторингРежимыРаботыТаблицаГрафик.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингРежимыРаботыТаблицаГрафик.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингРежимыРаботыТаблицаГрафик.Строка[] res = new МониторингРежимыРаботыТаблицаГрафик.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингРежимыРаботыТаблицаГрафик> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингРежимыРаботыТаблицаГрафик>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингРежимыРаботыТаблицаГрафик.Строка[] AllRows
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
        public new МониторингРежимыРаботыТаблицаГрафик.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингРежимыРаботыТаблицаГрафик.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингРежимыРаботыТаблицаГрафик[] convertArray(NsgMultipleObject[] array)
        {
            МониторингРежимыРаботыТаблицаГрафик[] res = new МониторингРежимыРаботыТаблицаГрафик[array.Length];
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
        public new virtual МониторингРежимыРаботыТаблицаГрафик[] FindAll(NsgCompare compare)
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
        public new virtual МониторингРежимыРаботыТаблицаГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингРежимыРаботыТаблицаГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингРежимыРаботыТаблицаГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингРежимыРаботыТаблицаГрафик(this as NsgObject);
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
                base.NSGType = typeof(МониторингРежимыРаботыТаблицаГрафик);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингРежимыРаботыТаблицаГрафик Value
            {
                get
                {
                    return (МониторингРежимыРаботыТаблицаГрафик)base.Value;
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
