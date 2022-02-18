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

namespace TechControl.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataServerJob", Guid = "46723407-7523-484a-bfe4-e97a53da4a90")]
    public partial class СервернаяЗадача : NsgSoft.DataObjects.NsgDataServerJob
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataServerJob
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataServerJob

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataServerJob
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataServerJob

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected СервернаяЗадача()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected СервернаяЗадача(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static СервернаяЗадача Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("46723407-7523-484a-bfe4-e97a53da4a90"));
            if (obj == null)
                obj = new СервернаяЗадача();
            return obj as СервернаяЗадача;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataServerJob
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataServerJob
			
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
	Идентификатор.Guid = NsgService.StringToGuid("aa87ff80-34ac-4fb1-b7f1-58fadf655d5b");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("99833df1-5293-46a4-bcd6-9a46816d67ef");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.String ПрефиксКода
			{  
                NsgDataString ПрефиксКода = null;
				if (ObjectList.Contains("ПрефиксКода"))
                    ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                else
                    ПрефиксКода = new NsgDataString();
	//NsgDataString
	ПрефиксКода.IsLoadedFromDll = true;
	ПрефиксКода.Length = 10;
	ПрефиксКода.StringFormat = "";
	ПрефиксКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПрефиксКода.IncludeInPredefined = false;
	ПрефиксКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПрефиксКода.Required = false;
	ПрефиксКода.EmptyValue = "";
	ПрефиксКода.NullAllow = false;
	ПрефиксКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПрефиксКода.FieldName = "_CodePrefix";
	ПрефиксКода.SaveInDatabase = true;
	ПрефиксКода.InformMetaDataOnValueChanged = false;
	ПрефиксКода.Visible = true;
	ПрефиксКода.Name = "ПрефиксКода";
	ПрефиксКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПрефиксКода.Description = "Префикс кода";
	ПрефиксКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПрефиксКода.GroupName = "";
	ПрефиксКода.Guid = NsgService.StringToGuid("ab9341d8-cc0e-4a36-9276-af40474a0dc3");
	
				if (!ObjectList.Contains("ПрефиксКода"))
                    ObjectList.Add(ПрефиксКода);
			}
			#endregion //создание System.String ПрефиксКода
			
			#region создание System.Int64 НомерКода
			{  
                NsgDataInteger НомерКода = null;
				if (ObjectList.Contains("НомерКода"))
                    НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                else
                    НомерКода = new NsgDataInteger();
	//NsgDataInteger
	НомерКода.IsLoadedFromDll = true;
	НомерКода.DefaultValue = 0M;
	НомерКода.MinValue = 0M;
	НомерКода.MaxValue = 0M;
	НомерКода.UseCalculator = true;
	НомерКода.StringFormat = "";
	НомерКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерКода.IncludeInPredefined = false;
	НомерКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерКода.Required = false;
	НомерКода.EmptyValue = "";
	НомерКода.NullAllow = false;
	НомерКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерКода.FieldName = "_CodeNumber";
	НомерКода.SaveInDatabase = true;
	НомерКода.InformMetaDataOnValueChanged = false;
	НомерКода.Visible = true;
	НомерКода.Name = "НомерКода";
	НомерКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерКода.Description = "Номер кода";
	НомерКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерКода.GroupName = "";
	НомерКода.Guid = NsgService.StringToGuid("c631af00-c9d5-4f38-a0f7-13b32ceee6bf");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String НомерДокумента
			{  
                NsgDataVirtualObject НомерДокумента = null;
				if (ObjectList.Contains("НомерДокумента"))
                    НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                else
                    НомерДокумента = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	НомерДокумента.IsLoadedFromDll = true;
	НомерДокумента.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	НомерДокумента.SaveInDatabase = false;
	НомерДокумента.StringFormat = "";
	НомерДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерДокумента.IncludeInPredefined = false;
	НомерДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерДокумента.Required = false;
	НомерДокумента.EmptyValue = "";
	НомерДокумента.NullAllow = false;
	НомерДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерДокумента.FieldName = "_Code";
	НомерДокумента.InformMetaDataOnValueChanged = false;
	НомерДокумента.Visible = true;
	НомерДокумента.Name = "НомерДокумента";
	НомерДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Номер документа"});
	НомерДокумента.Description = "Номер документа";
	НомерДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерДокумента.GroupName = "";
	НомерДокумента.Guid = NsgService.StringToGuid("90754b8f-5a8a-4410-867d-5aaf6b846156");
	
				if (!ObjectList.Contains("НомерДокумента"))
                    ObjectList.Add(НомерДокумента);
			}
			#endregion //создание System.String НомерДокумента
			
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
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("ad37b69d-277f-4c88-9ca1-a795d1226f3c");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.String Индекс
			{  
                NsgDataIndex Индекс = null;
				if (ObjectList.Contains("Индекс"))
                    Индекс = ObjectList["Индекс"] as NsgDataIndex;
                else
                    Индекс = new NsgDataIndex();
	//NsgDataIndex
	Индекс.IsLoadedFromDll = true;
	Индекс.RequisiteList = "ДатаДокумента,Автоинкремент";
	Индекс.SaveInDatabase = false;
	Индекс.StringFormat = "";
	Индекс.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Индекс.IncludeInPredefined = false;
	Индекс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Индекс.Required = false;
	Индекс.EmptyValue = "";
	Индекс.NullAllow = false;
	Индекс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Индекс.FieldName = "_Index";
	Индекс.InformMetaDataOnValueChanged = false;
	Индекс.Visible = true;
	Индекс.Name = "Индекс";
	Индекс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Индекс.Description = "Индекс";
	Индекс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Индекс.GroupName = "";
	Индекс.Guid = NsgService.StringToGuid("1b5fae30-0b35-4531-9016-9ee6529a9b8e");
	
				if (!ObjectList.Contains("Индекс"))
                    ObjectList.Add(Индекс);
			}
			#endregion //создание System.String Индекс
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			{  
                NsgDataUntypedReference ДокументОснование = null;
				if (ObjectList.Contains("ДокументОснование"))
                    ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                else
                    ДокументОснование = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ДокументОснование.IsLoadedFromDll = true;
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.None;
	ДокументОснование.FilterForConfigurator = "";
	ДокументОснование.ReferentName = "";
	ДокументОснование.ReferentGroup = "";
	ДокументОснование.TypeSelectorName = "";
	ДокументОснование.SaveInDatabase = true;
	ДокументОснование.OwnerName = "";
	ДокументОснование.AllowEmptyOwner = false;
	ДокументОснование.StringFormat = "";
	ДокументОснование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДокументОснование.IncludeInPredefined = false;
	ДокументОснование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументОснование.Required = false;
	ДокументОснование.EmptyValue = "";
	ДокументОснование.NullAllow = false;
	ДокументОснование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДокументОснование.FieldName = "_BaseDocument";
	ДокументОснование.InformMetaDataOnValueChanged = false;
	ДокументОснование.Visible = true;
	ДокументОснование.Name = "ДокументОснование";
	ДокументОснование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументОснование.Description = "Документ основание";
	ДокументОснование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДокументОснование.GroupName = "";
	ДокументОснование.Guid = NsgService.StringToGuid("c82eda59-d97f-467a-86a2-8322a3ab07b5");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
			#region создание System.DateTime ДатаЗапускаЗадания
			{  
                NsgDataDateTime ДатаЗапускаЗадания = null;
				if (ObjectList.Contains("ДатаЗапускаЗадания"))
                    ДатаЗапускаЗадания = ObjectList["ДатаЗапускаЗадания"] as NsgDataDateTime;
                else
                    ДатаЗапускаЗадания = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаЗапускаЗадания.IsLoadedFromDll = true;
	ДатаЗапускаЗадания.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаЗапускаЗадания.StringFormat = "";
	ДатаЗапускаЗадания.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаЗапускаЗадания.IncludeInPredefined = false;
	ДатаЗапускаЗадания.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаЗапускаЗадания.Required = false;
	ДатаЗапускаЗадания.EmptyValue = "";
	ДатаЗапускаЗадания.NullAllow = false;
	ДатаЗапускаЗадания.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаЗапускаЗадания.FieldName = "_StartedDate";
	ДатаЗапускаЗадания.SaveInDatabase = true;
	ДатаЗапускаЗадания.InformMetaDataOnValueChanged = false;
	ДатаЗапускаЗадания.Visible = true;
	ДатаЗапускаЗадания.Name = "ДатаЗапускаЗадания";
	ДатаЗапускаЗадания.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата запуска задания"});
	ДатаЗапускаЗадания.Description = "Дата запуска задания";
	ДатаЗапускаЗадания.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаЗапускаЗадания.GroupName = "";
	ДатаЗапускаЗадания.Guid = NsgService.StringToGuid("7fa030c2-8cc0-4a80-b067-dc0fb7012a88");
	
				if (!ObjectList.Contains("ДатаЗапускаЗадания"))
                    ObjectList.Add(ДатаЗапускаЗадания);
			}
			#endregion //создание System.DateTime ДатаЗапускаЗадания
			
			#region создание System.DateTime ДатаНачалаИсполнения
			{  
                NsgDataDateTime ДатаНачалаИсполнения = null;
				if (ObjectList.Contains("ДатаНачалаИсполнения"))
                    ДатаНачалаИсполнения = ObjectList["ДатаНачалаИсполнения"] as NsgDataDateTime;
                else
                    ДатаНачалаИсполнения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаНачалаИсполнения.IsLoadedFromDll = true;
	ДатаНачалаИсполнения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаНачалаИсполнения.StringFormat = "";
	ДатаНачалаИсполнения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаНачалаИсполнения.IncludeInPredefined = false;
	ДатаНачалаИсполнения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаНачалаИсполнения.Required = false;
	ДатаНачалаИсполнения.EmptyValue = "";
	ДатаНачалаИсполнения.NullAllow = false;
	ДатаНачалаИсполнения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаНачалаИсполнения.FieldName = "_RunDate";
	ДатаНачалаИсполнения.SaveInDatabase = true;
	ДатаНачалаИсполнения.InformMetaDataOnValueChanged = false;
	ДатаНачалаИсполнения.Visible = true;
	ДатаНачалаИсполнения.Name = "ДатаНачалаИсполнения";
	ДатаНачалаИсполнения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата начала исполнения"});
	ДатаНачалаИсполнения.Description = "Дата начала исполнения";
	ДатаНачалаИсполнения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаНачалаИсполнения.GroupName = "";
	ДатаНачалаИсполнения.Guid = NsgService.StringToGuid("731ad3df-d22a-419e-8b11-06a68429ce6e");
	
				if (!ObjectList.Contains("ДатаНачалаИсполнения"))
                    ObjectList.Add(ДатаНачалаИсполнения);
			}
			#endregion //создание System.DateTime ДатаНачалаИсполнения
			
			#region создание System.DateTime ДатаОкончанияИсполнения
			{  
                NsgDataDateTime ДатаОкончанияИсполнения = null;
				if (ObjectList.Contains("ДатаОкончанияИсполнения"))
                    ДатаОкончанияИсполнения = ObjectList["ДатаОкончанияИсполнения"] as NsgDataDateTime;
                else
                    ДатаОкончанияИсполнения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияИсполнения.IsLoadedFromDll = true;
	ДатаОкончанияИсполнения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончанияИсполнения.StringFormat = "";
	ДатаОкончанияИсполнения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияИсполнения.IncludeInPredefined = false;
	ДатаОкончанияИсполнения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияИсполнения.Required = false;
	ДатаОкончанияИсполнения.EmptyValue = "";
	ДатаОкончанияИсполнения.NullAllow = false;
	ДатаОкончанияИсполнения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаОкончанияИсполнения.FieldName = "_CompleteDate";
	ДатаОкончанияИсполнения.SaveInDatabase = true;
	ДатаОкончанияИсполнения.InformMetaDataOnValueChanged = false;
	ДатаОкончанияИсполнения.Visible = true;
	ДатаОкончанияИсполнения.Name = "ДатаОкончанияИсполнения";
	ДатаОкончанияИсполнения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата окончания исполнения"});
	ДатаОкончанияИсполнения.Description = "Дата окончания исполнения";
	ДатаОкончанияИсполнения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончанияИсполнения.GroupName = "";
	ДатаОкончанияИсполнения.Guid = NsgService.StringToGuid("bba9b329-b508-4bb5-b7a3-631bd92dd61c");
	
				if (!ObjectList.Contains("ДатаОкончанияИсполнения"))
                    ObjectList.Add(ДатаОкончанияИсполнения);
			}
			#endregion //создание System.DateTime ДатаОкончанияИсполнения
			
			#region создание Сервис.Приоритет ПриоритетЗадания
			{  
                NsgDataEnumReference ПриоритетЗадания = null;
				if (ObjectList.Contains("ПриоритетЗадания"))
                    ПриоритетЗадания = ObjectList["ПриоритетЗадания"] as NsgDataEnumReference;
                else
                    ПриоритетЗадания = new NsgDataEnumReference();
	//NsgDataEnumReference
	ПриоритетЗадания.IsLoadedFromDll = true;
	ПриоритетЗадания.ReferentGroup = "Сервис";
	ПриоритетЗадания.ReferentName = "Приоритет";
	ПриоритетЗадания.SaveInDatabase = true;
	ПриоритетЗадания.OwnerName = "";
	ПриоритетЗадания.AllowEmptyOwner = false;
	ПриоритетЗадания.StringFormat = "";
	ПриоритетЗадания.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПриоритетЗадания.IncludeInPredefined = false;
	ПриоритетЗадания.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПриоритетЗадания.Required = false;
	ПриоритетЗадания.EmptyValue = "";
	ПриоритетЗадания.NullAllow = false;
	ПриоритетЗадания.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПриоритетЗадания.FieldName = "_Priority";
	ПриоритетЗадания.InformMetaDataOnValueChanged = false;
	ПриоритетЗадания.Visible = true;
	ПриоритетЗадания.Name = "ПриоритетЗадания";
	ПриоритетЗадания.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Приоритет задания"});
	ПриоритетЗадания.Description = "Приоритет задания";
	ПриоритетЗадания.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПриоритетЗадания.GroupName = "";
	ПриоритетЗадания.Guid = NsgService.StringToGuid("594b3725-1ab1-4e64-880f-09a2d33b9b32");
	
				if (!ObjectList.Contains("ПриоритетЗадания"))
                    ObjectList.Add(ПриоритетЗадания);
			}
			#endregion //создание Сервис.Приоритет ПриоритетЗадания
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ОбрабатываемыйОбъект
			{  
                NsgDataUntypedReference ОбрабатываемыйОбъект = null;
				if (ObjectList.Contains("ОбрабатываемыйОбъект"))
                    ОбрабатываемыйОбъект = ObjectList["ОбрабатываемыйОбъект"] as NsgDataUntypedReference;
                else
                    ОбрабатываемыйОбъект = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ОбрабатываемыйОбъект.IsLoadedFromDll = true;
	ОбрабатываемыйОбъект.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	ОбрабатываемыйОбъект.FilterForConfigurator = "NsgDataDocument,NsgDataDictionary";
	ОбрабатываемыйОбъект.ReferentName = "";
	ОбрабатываемыйОбъект.ReferentGroup = "";
	ОбрабатываемыйОбъект.TypeSelectorName = "";
	ОбрабатываемыйОбъект.SaveInDatabase = true;
	ОбрабатываемыйОбъект.OwnerName = "";
	ОбрабатываемыйОбъект.AllowEmptyOwner = false;
	ОбрабатываемыйОбъект.StringFormat = "";
	ОбрабатываемыйОбъект.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбрабатываемыйОбъект.IncludeInPredefined = false;
	ОбрабатываемыйОбъект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбрабатываемыйОбъект.Required = false;
	ОбрабатываемыйОбъект.EmptyValue = "";
	ОбрабатываемыйОбъект.NullAllow = false;
	ОбрабатываемыйОбъект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбрабатываемыйОбъект.FieldName = "_Object";
	ОбрабатываемыйОбъект.InformMetaDataOnValueChanged = false;
	ОбрабатываемыйОбъект.Visible = true;
	ОбрабатываемыйОбъект.Name = "ОбрабатываемыйОбъект";
	ОбрабатываемыйОбъект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Обрабатываемый объект"});
	ОбрабатываемыйОбъект.Description = "Обрабатываемый объект";
	ОбрабатываемыйОбъект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбрабатываемыйОбъект.GroupName = "";
	ОбрабатываемыйОбъект.Guid = NsgService.StringToGuid("d977a99e-b4de-442f-a44a-51a4e4d92b99");
	
				if (!ObjectList.Contains("ОбрабатываемыйОбъект"))
                    ObjectList.Add(ОбрабатываемыйОбъект);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ОбрабатываемыйОбъект
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject ТипОбрабатываемогоОбъекта
			{  
                NsgObjectSelector ТипОбрабатываемогоОбъекта = null;
				if (ObjectList.Contains("ТипОбрабатываемогоОбъекта"))
                    ТипОбрабатываемогоОбъекта = ObjectList["ТипОбрабатываемогоОбъекта"] as NsgObjectSelector;
                else
                    ТипОбрабатываемогоОбъекта = new NsgObjectSelector();
	//NsgObjectSelector
	ТипОбрабатываемогоОбъекта.IsLoadedFromDll = true;
	ТипОбрабатываемогоОбъекта.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	ТипОбрабатываемогоОбъекта.FilterForConfigurator = "NsgDataDocument,NsgDataDictionary,NsgReportObject";
	ТипОбрабатываемогоОбъекта.StringFormat = "";
	ТипОбрабатываемогоОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТипОбрабатываемогоОбъекта.IncludeInPredefined = false;
	ТипОбрабатываемогоОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипОбрабатываемогоОбъекта.Required = false;
	ТипОбрабатываемогоОбъекта.EmptyValue = "";
	ТипОбрабатываемогоОбъекта.NullAllow = false;
	ТипОбрабатываемогоОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипОбрабатываемогоОбъекта.FieldName = "_TypeObject";
	ТипОбрабатываемогоОбъекта.SaveInDatabase = true;
	ТипОбрабатываемогоОбъекта.InformMetaDataOnValueChanged = false;
	ТипОбрабатываемогоОбъекта.Visible = true;
	ТипОбрабатываемогоОбъекта.Name = "ТипОбрабатываемогоОбъекта";
	ТипОбрабатываемогоОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Тип обрабатываемого объекта"});
	ТипОбрабатываемогоОбъекта.Description = "Тип обрабатываемого объекта";
	ТипОбрабатываемогоОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипОбрабатываемогоОбъекта.GroupName = "";
	ТипОбрабатываемогоОбъекта.Guid = NsgService.StringToGuid("2f23f58f-8f45-477a-bb37-35a34840724f");
	
				if (!ObjectList.Contains("ТипОбрабатываемогоОбъекта"))
                    ObjectList.Add(ТипОбрабатываемогоОбъекта);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject ТипОбрабатываемогоОбъекта
			
			#region создание Сервис.ТипЗадачиНаСервере ДействиеНадОбъектом
			{  
                NsgDataEnumReference ДействиеНадОбъектом = null;
				if (ObjectList.Contains("ДействиеНадОбъектом"))
                    ДействиеНадОбъектом = ObjectList["ДействиеНадОбъектом"] as NsgDataEnumReference;
                else
                    ДействиеНадОбъектом = new NsgDataEnumReference();
	//NsgDataEnumReference
	ДействиеНадОбъектом.IsLoadedFromDll = true;
	ДействиеНадОбъектом.ReferentGroup = "Сервис";
	ДействиеНадОбъектом.ReferentName = "ТипЗадачиНаСервере";
	ДействиеНадОбъектом.SaveInDatabase = true;
	ДействиеНадОбъектом.OwnerName = "";
	ДействиеНадОбъектом.AllowEmptyOwner = false;
	ДействиеНадОбъектом.StringFormat = "";
	ДействиеНадОбъектом.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДействиеНадОбъектом.IncludeInPredefined = false;
	ДействиеНадОбъектом.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДействиеНадОбъектом.Required = false;
	ДействиеНадОбъектом.EmptyValue = "";
	ДействиеНадОбъектом.NullAllow = false;
	ДействиеНадОбъектом.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДействиеНадОбъектом.FieldName = "_Action";
	ДействиеНадОбъектом.InformMetaDataOnValueChanged = false;
	ДействиеНадОбъектом.Visible = true;
	ДействиеНадОбъектом.Name = "ДействиеНадОбъектом";
	ДействиеНадОбъектом.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Действие над объектом"});
	ДействиеНадОбъектом.Description = "Действие над объектом";
	ДействиеНадОбъектом.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДействиеНадОбъектом.GroupName = "";
	ДействиеНадОбъектом.Guid = NsgService.StringToGuid("1d5d5223-121c-4ce4-9956-dc593647bd49");
	
				if (!ObjectList.Contains("ДействиеНадОбъектом"))
                    ObjectList.Add(ДействиеНадОбъектом);
			}
			#endregion //создание Сервис.ТипЗадачиНаСервере ДействиеНадОбъектом
			
			#region создание System.Boolean УведомлятьАвтораОВыполнении
			{  
                NsgDataBoolean УведомлятьАвтораОВыполнении = null;
				if (ObjectList.Contains("УведомлятьАвтораОВыполнении"))
                    УведомлятьАвтораОВыполнении = ObjectList["УведомлятьАвтораОВыполнении"] as NsgDataBoolean;
                else
                    УведомлятьАвтораОВыполнении = new NsgDataBoolean();
	//NsgDataBoolean
	УведомлятьАвтораОВыполнении.IsLoadedFromDll = true;
	УведомлятьАвтораОВыполнении.DefaultValue = false;
	УведомлятьАвтораОВыполнении.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	УведомлятьАвтораОВыполнении.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	УведомлятьАвтораОВыполнении.StringFormat = "";
	УведомлятьАвтораОВыполнении.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	УведомлятьАвтораОВыполнении.IncludeInPredefined = false;
	УведомлятьАвтораОВыполнении.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	УведомлятьАвтораОВыполнении.Required = false;
	УведомлятьАвтораОВыполнении.EmptyValue = "";
	УведомлятьАвтораОВыполнении.NullAllow = false;
	УведомлятьАвтораОВыполнении.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	УведомлятьАвтораОВыполнении.FieldName = "_IsNotificateAuthor";
	УведомлятьАвтораОВыполнении.SaveInDatabase = true;
	УведомлятьАвтораОВыполнении.InformMetaDataOnValueChanged = false;
	УведомлятьАвтораОВыполнении.Visible = true;
	УведомлятьАвтораОВыполнении.Name = "УведомлятьАвтораОВыполнении";
	УведомлятьАвтораОВыполнении.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Уведомлять автора о выполнении"});
	УведомлятьАвтораОВыполнении.Description = "Уведомлять автора о выполнении";
	УведомлятьАвтораОВыполнении.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	УведомлятьАвтораОВыполнении.GroupName = "";
	УведомлятьАвтораОВыполнении.Guid = NsgService.StringToGuid("119e0ad6-c413-49d8-8d5d-4f93fd59d3d4");
	
				if (!ObjectList.Contains("УведомлятьАвтораОВыполнении"))
                    ObjectList.Add(УведомлятьАвтораОВыполнении);
			}
			#endregion //создание System.Boolean УведомлятьАвтораОВыполнении
			
			#region создание Сервис.Пользователи АвторЗадания
			{  
                NsgDataTypedReference АвторЗадания = null;
				if (ObjectList.Contains("АвторЗадания"))
                    АвторЗадания = ObjectList["АвторЗадания"] as NsgDataTypedReference;
                else
                    АвторЗадания = new NsgDataTypedReference();
	//NsgDataTypedReference
	АвторЗадания.IsLoadedFromDll = true;
	АвторЗадания.ReferentGroup = "Сервис";
	АвторЗадания.ReferentName = "Пользователи";
	АвторЗадания.SaveInDatabase = true;
	АвторЗадания.OwnerName = "";
	АвторЗадания.AllowEmptyOwner = false;
	АвторЗадания.StringFormat = "";
	АвторЗадания.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	АвторЗадания.IncludeInPredefined = false;
	АвторЗадания.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АвторЗадания.Required = false;
	АвторЗадания.EmptyValue = "";
	АвторЗадания.NullAllow = false;
	АвторЗадания.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АвторЗадания.FieldName = "_Author";
	АвторЗадания.InformMetaDataOnValueChanged = false;
	АвторЗадания.Visible = true;
	АвторЗадания.Name = "АвторЗадания";
	АвторЗадания.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Автор задания"});
	АвторЗадания.Description = "Автор задания";
	АвторЗадания.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	АвторЗадания.GroupName = "";
	АвторЗадания.Guid = NsgService.StringToGuid("99afa5f9-e55e-4ca0-90f7-19df4fb1bb56");
	
				if (!ObjectList.Contains("АвторЗадания"))
                    ObjectList.Add(АвторЗадания);
			}
			#endregion //создание Сервис.Пользователи АвторЗадания
			
			#region создание Сервис.Пользователи ПользовательДляУведомления
			{  
                NsgDataTypedReference ПользовательДляУведомления = null;
				if (ObjectList.Contains("ПользовательДляУведомления"))
                    ПользовательДляУведомления = ObjectList["ПользовательДляУведомления"] as NsgDataTypedReference;
                else
                    ПользовательДляУведомления = new NsgDataTypedReference();
	//NsgDataTypedReference
	ПользовательДляУведомления.IsLoadedFromDll = true;
	ПользовательДляУведомления.ReferentGroup = "Сервис";
	ПользовательДляУведомления.ReferentName = "Пользователи";
	ПользовательДляУведомления.SaveInDatabase = true;
	ПользовательДляУведомления.OwnerName = "";
	ПользовательДляУведомления.AllowEmptyOwner = false;
	ПользовательДляУведомления.StringFormat = "";
	ПользовательДляУведомления.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПользовательДляУведомления.IncludeInPredefined = false;
	ПользовательДляУведомления.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПользовательДляУведомления.Required = false;
	ПользовательДляУведомления.EmptyValue = "";
	ПользовательДляУведомления.NullAllow = false;
	ПользовательДляУведомления.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПользовательДляУведомления.FieldName = "_AdditionalReceiver";
	ПользовательДляУведомления.InformMetaDataOnValueChanged = false;
	ПользовательДляУведомления.Visible = true;
	ПользовательДляУведомления.Name = "ПользовательДляУведомления";
	ПользовательДляУведомления.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пользователь для уведомления"});
	ПользовательДляУведомления.Description = "Пользователь для уведомления";
	ПользовательДляУведомления.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПользовательДляУведомления.GroupName = "";
	ПользовательДляУведомления.Guid = NsgService.StringToGuid("b68ed7bd-3ed5-4406-9d52-bcb44e1f6bdd");
	
				if (!ObjectList.Contains("ПользовательДляУведомления"))
                    ObjectList.Add(ПользовательДляУведомления);
			}
			#endregion //создание Сервис.Пользователи ПользовательДляУведомления
			
			#region создание System.Int64 КоличествоПопыток
			{  
                NsgDataInteger КоличествоПопыток = null;
				if (ObjectList.Contains("КоличествоПопыток"))
                    КоличествоПопыток = ObjectList["КоличествоПопыток"] as NsgDataInteger;
                else
                    КоличествоПопыток = new NsgDataInteger();
	//NsgDataInteger
	КоличествоПопыток.IsLoadedFromDll = true;
	КоличествоПопыток.DefaultValue = 0M;
	КоличествоПопыток.MinValue = 0M;
	КоличествоПопыток.MaxValue = 0M;
	КоличествоПопыток.UseCalculator = true;
	КоличествоПопыток.StringFormat = "";
	КоличествоПопыток.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КоличествоПопыток.IncludeInPredefined = false;
	КоличествоПопыток.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоПопыток.Required = false;
	КоличествоПопыток.EmptyValue = "";
	КоличествоПопыток.NullAllow = false;
	КоличествоПопыток.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоПопыток.FieldName = "_TryCount";
	КоличествоПопыток.SaveInDatabase = true;
	КоличествоПопыток.InformMetaDataOnValueChanged = false;
	КоличествоПопыток.Visible = true;
	КоличествоПопыток.Name = "КоличествоПопыток";
	КоличествоПопыток.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Количество попыток постановки задания на обработку"});
	КоличествоПопыток.Description = "Количество попыток постановки задания на обработку";
	КоличествоПопыток.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоПопыток.GroupName = "";
	КоличествоПопыток.Guid = NsgService.StringToGuid("9cb97d41-031a-484e-8634-4c8c93702516");
	
				if (!ObjectList.Contains("КоличествоПопыток"))
                    ObjectList.Add(КоличествоПопыток);
			}
			#endregion //создание System.Int64 КоличествоПопыток
			
			#region создание System.String Настройки
			{  
                NsgDataString Настройки = null;
				if (ObjectList.Contains("Настройки"))
                    Настройки = ObjectList["Настройки"] as NsgDataString;
                else
                    Настройки = new NsgDataString();
	//NsgDataString
	Настройки.IsLoadedFromDll = true;
	Настройки.Length = 0;
	Настройки.StringFormat = "";
	Настройки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Настройки.IncludeInPredefined = false;
	Настройки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Настройки.Required = false;
	Настройки.EmptyValue = "";
	Настройки.NullAllow = false;
	Настройки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Настройки.FieldName = "_Options";
	Настройки.SaveInDatabase = true;
	Настройки.InformMetaDataOnValueChanged = false;
	Настройки.Visible = true;
	Настройки.Name = "Настройки";
	Настройки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Настройки"});
	Настройки.Description = "Настройки";
	Настройки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Настройки.GroupName = "";
	Настройки.Guid = NsgService.StringToGuid("b2dab079-03b0-4115-b390-69523b797b8e");
	
				if (!ObjectList.Contains("Настройки"))
                    ObjectList.Add(Настройки);
			}
			#endregion //создание System.String Настройки
			
			#region создание Сервис.СостоянияОбъекта СостояниеДокумента
			{  
                NsgDataEnumReference СостояниеДокумента = null;
				if (ObjectList.Contains("СостояниеДокумента"))
                    СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                else
                    СостояниеДокумента = new NsgDataEnumReference();
	//NsgDataEnumReference
	СостояниеДокумента.IsLoadedFromDll = true;
	СостояниеДокумента.ReferentGroup = "Сервис";
	СостояниеДокумента.ReferentName = "СостоянияОбъекта";
	СостояниеДокумента.SaveInDatabase = true;
	СостояниеДокумента.OwnerName = "";
	СостояниеДокумента.AllowEmptyOwner = false;
	СостояниеДокумента.StringFormat = "";
	СостояниеДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СостояниеДокумента.IncludeInPredefined = false;
	СостояниеДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СостояниеДокумента.Required = false;
	СостояниеДокумента.EmptyValue = "";
	СостояниеДокумента.NullAllow = false;
	СостояниеДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СостояниеДокумента.FieldName = "_State";
	СостояниеДокумента.InformMetaDataOnValueChanged = false;
	СостояниеДокумента.Visible = true;
	СостояниеДокумента.Name = "СостояниеДокумента";
	СостояниеДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СостояниеДокумента.Description = "Состояние документа";
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("86697a4a-3ca4-4893-8533-2b0cf78e30be");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			

			#region заполнение полей класса
				//NsgDataServerJob
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Мониторинг.ФормированиеСмены", "Сервис.СервернаяЗадача"});
	SearchFieldName = "НомерДокумента";
	HandleWithoutTransaction = true;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СервернаяЗадача";
	Visible = true;
	Guid = NsgService.StringToGuid("46723407-7523-484a-bfe4-e97a53da4a90");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "ServerJob";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Серверная задача";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataServerJob
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataServerJob

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataServerJob.Names
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
            /// Префикс кода
            /// </summary>
            public static String ПрефиксКода
            {
                get
                {
                    return "ПрефиксКода";
                }
            }
            
            /// <summary>
            /// Номер кода
            /// </summary>
            public static String НомерКода
            {
                get
                {
                    return "НомерКода";
                }
            }
            
            /// <summary>
            /// Номер документа
            /// </summary>
            public static String НомерДокумента
            {
                get
                {
                    return "НомерДокумента";
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
            /// Индекс
            /// </summary>
            public static String Индекс
            {
                get
                {
                    return "Индекс";
                }
            }
            
            /// <summary>
            /// Документ основание
            /// </summary>
            public static String ДокументОснование
            {
                get
                {
                    return "ДокументОснование";
                }
            }
            
            /// <summary>
            /// Дата запуска задания
            /// </summary>
            public static String ДатаЗапускаЗадания
            {
                get
                {
                    return "ДатаЗапускаЗадания";
                }
            }
            
            /// <summary>
            /// Дата начала исполнения
            /// </summary>
            public static String ДатаНачалаИсполнения
            {
                get
                {
                    return "ДатаНачалаИсполнения";
                }
            }
            
            /// <summary>
            /// Дата окончания исполнения
            /// </summary>
            public static String ДатаОкончанияИсполнения
            {
                get
                {
                    return "ДатаОкончанияИсполнения";
                }
            }
            
            /// <summary>
            /// Приоритет задания
            /// </summary>
            public static String ПриоритетЗадания
            {
                get
                {
                    return "ПриоритетЗадания";
                }
            }
            
            /// <summary>
            /// Обрабатываемый объект
            /// </summary>
            public static String ОбрабатываемыйОбъект
            {
                get
                {
                    return "ОбрабатываемыйОбъект";
                }
            }
            
            /// <summary>
            /// Тип обрабатываемого объекта
            /// </summary>
            public static String ТипОбрабатываемогоОбъекта
            {
                get
                {
                    return "ТипОбрабатываемогоОбъекта";
                }
            }
            
            /// <summary>
            /// Действие над объектом
            /// </summary>
            public static String ДействиеНадОбъектом
            {
                get
                {
                    return "ДействиеНадОбъектом";
                }
            }
            
            /// <summary>
            /// Уведомлять автора о выполнении
            /// </summary>
            public static String УведомлятьАвтораОВыполнении
            {
                get
                {
                    return "УведомлятьАвтораОВыполнении";
                }
            }
            
            /// <summary>
            /// Автор задания
            /// </summary>
            public static String АвторЗадания
            {
                get
                {
                    return "АвторЗадания";
                }
            }
            
            /// <summary>
            /// Пользователь для уведомления
            /// </summary>
            public static String ПользовательДляУведомления
            {
                get
                {
                    return "ПользовательДляУведомления";
                }
            }
            
            /// <summary>
            /// Количество попыток постановки задания на обработку
            /// </summary>
            public static String КоличествоПопыток
            {
                get
                {
                    return "КоличествоПопыток";
                }
            }
            
            /// <summary>
            /// Настройки
            /// </summary>
            public static String Настройки
            {
                get
                {
                    return "Настройки";
                }
            }
            
            /// <summary>
            /// Состояние документа
            /// </summary>
            public static String СостояниеДокумента
            {
                get
                {
                    return "СостояниеДокумента";
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
                    descriptor.Name = "СервернаяЗадача";
                    descriptor.GroupName = "Сервис";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Сервис.СервернаяЗадача";
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
        /// Префикс кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПрефиксКода
        {
            get
            {
				 NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                 return (System.String)__ПрефиксКода.Value;
            }
            set
            {
                NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                __ПрефиксКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерКода
        {
            get
            {
				 NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                 return (System.Int64)__НомерКода.Value;
            }
            set
            {
                NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                __НомерКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String НомерДокумента
        {
            get
            {
				 NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                 return (System.String)__НомерДокумента.Value;
            }
            set
            {
                NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                __НомерДокумента.Value = value;
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
        /// Индекс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataIndex")]
        
        public System.String Индекс
        {
            get
            {
				 NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                 return (System.String)__Индекс.Value;
            }
            set
            {
                NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                __Индекс.Value = value;
            }
        }
        
        /// <summary>
        /// Документ основание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("")]
        public NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
        {
            get
            {
				 NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ДокументОснование.Referent;
            }
            set
            {
                NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                __ДокументОснование.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата запуска задания
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаЗапускаЗадания
        {
            get
            {
				 NsgDataDateTime __ДатаЗапускаЗадания = ObjectList["ДатаЗапускаЗадания"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаЗапускаЗадания.Value;
            }
            set
            {
                NsgDataDateTime __ДатаЗапускаЗадания = ObjectList["ДатаЗапускаЗадания"] as NsgDataDateTime;
                __ДатаЗапускаЗадания.Value = value;
            }
        }
        
        /// <summary>
        /// Дата начала исполнения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаНачалаИсполнения
        {
            get
            {
				 NsgDataDateTime __ДатаНачалаИсполнения = ObjectList["ДатаНачалаИсполнения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаНачалаИсполнения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаНачалаИсполнения = ObjectList["ДатаНачалаИсполнения"] as NsgDataDateTime;
                __ДатаНачалаИсполнения.Value = value;
            }
        }
        
        /// <summary>
        /// Дата окончания исполнения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияИсполнения
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияИсполнения = ObjectList["ДатаОкончанияИсполнения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияИсполнения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияИсполнения = ObjectList["ДатаОкончанияИсполнения"] as NsgDataDateTime;
                __ДатаОкончанияИсполнения.Value = value;
            }
        }
        
        /// <summary>
        /// Приоритет задания
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.Приоритет ПриоритетЗадания
        {
            get
            {
				 NsgDataEnumReference __ПриоритетЗадания = ObjectList["ПриоритетЗадания"] as NsgDataEnumReference;
                 return (Сервис.Приоритет)__ПриоритетЗадания.Referent;
            }
            set
            {
                NsgDataEnumReference __ПриоритетЗадания = ObjectList["ПриоритетЗадания"] as NsgDataEnumReference;
                __ПриоритетЗадания.Referent = value;
            }
        }
        
        /// <summary>
        /// Обрабатываемый объект
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("NsgDataDocument,NsgDataDictionary")]
        public NsgSoft.DataObjects.NsgReferencedObject ОбрабатываемыйОбъект
        {
            get
            {
				 NsgDataUntypedReference __ОбрабатываемыйОбъект = ObjectList["ОбрабатываемыйОбъект"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ОбрабатываемыйОбъект.Referent;
            }
            set
            {
                NsgDataUntypedReference __ОбрабатываемыйОбъект = ObjectList["ОбрабатываемыйОбъект"] as NsgDataUntypedReference;
                __ОбрабатываемыйОбъект.Referent = value;
            }
        }
        
        /// <summary>
        /// Тип обрабатываемого объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject ТипОбрабатываемогоОбъекта
        {
            get
            {
				 NsgObjectSelector __ТипОбрабатываемогоОбъекта = ObjectList["ТипОбрабатываемогоОбъекта"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__ТипОбрабатываемогоОбъекта.Object;
            }
            set
            {
                NsgObjectSelector __ТипОбрабатываемогоОбъекта = ObjectList["ТипОбрабатываемогоОбъекта"] as NsgObjectSelector;
                __ТипОбрабатываемогоОбъекта.Object = value;
            }
        }
        
        /// <summary>
        /// Действие над объектом
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.ТипЗадачиНаСервере ДействиеНадОбъектом
        {
            get
            {
				 NsgDataEnumReference __ДействиеНадОбъектом = ObjectList["ДействиеНадОбъектом"] as NsgDataEnumReference;
                 return (Сервис.ТипЗадачиНаСервере)__ДействиеНадОбъектом.Referent;
            }
            set
            {
                NsgDataEnumReference __ДействиеНадОбъектом = ObjectList["ДействиеНадОбъектом"] as NsgDataEnumReference;
                __ДействиеНадОбъектом.Referent = value;
            }
        }
        
        /// <summary>
        /// Уведомлять автора о выполнении
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean УведомлятьАвтораОВыполнении
        {
            get
            {
				 NsgDataBoolean __УведомлятьАвтораОВыполнении = ObjectList["УведомлятьАвтораОВыполнении"] as NsgDataBoolean;
                 return (System.Boolean)__УведомлятьАвтораОВыполнении.Value;
            }
            set
            {
                NsgDataBoolean __УведомлятьАвтораОВыполнении = ObjectList["УведомлятьАвтораОВыполнении"] as NsgDataBoolean;
                __УведомлятьАвтораОВыполнении.Value = value;
            }
        }
        
        /// <summary>
        /// Автор задания
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.Пользователи АвторЗадания
        {
            get
            {
				 NsgDataTypedReference __АвторЗадания = ObjectList["АвторЗадания"] as NsgDataTypedReference;
                 return (Сервис.Пользователи)__АвторЗадания.Referent;
            }
            set
            {
                NsgDataTypedReference __АвторЗадания = ObjectList["АвторЗадания"] as NsgDataTypedReference;
                __АвторЗадания.Referent = value;
            }
        }
        
        /// <summary>
        /// Пользователь для уведомления
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.Пользователи ПользовательДляУведомления
        {
            get
            {
				 NsgDataTypedReference __ПользовательДляУведомления = ObjectList["ПользовательДляУведомления"] as NsgDataTypedReference;
                 return (Сервис.Пользователи)__ПользовательДляУведомления.Referent;
            }
            set
            {
                NsgDataTypedReference __ПользовательДляУведомления = ObjectList["ПользовательДляУведомления"] as NsgDataTypedReference;
                __ПользовательДляУведомления.Referent = value;
            }
        }
        
        /// <summary>
        /// Количество попыток постановки задания на обработку
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоПопыток
        {
            get
            {
				 NsgDataInteger __КоличествоПопыток = ObjectList["КоличествоПопыток"] as NsgDataInteger;
                 return (System.Int64)__КоличествоПопыток.Value;
            }
            set
            {
                NsgDataInteger __КоличествоПопыток = ObjectList["КоличествоПопыток"] as NsgDataInteger;
                __КоличествоПопыток.Value = value;
            }
        }
        
        /// <summary>
        /// Настройки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Настройки
        {
            get
            {
				 NsgDataString __Настройки = ObjectList["Настройки"] as NsgDataString;
                 return (System.String)__Настройки.Value;
            }
            set
            {
                NsgDataString __Настройки = ObjectList["Настройки"] as NsgDataString;
                __Настройки.Value = value;
            }
        }
        
        /// <summary>
        /// Состояние документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.СостоянияОбъекта СостояниеДокумента
        {
            get
            {
				 NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                 return (Сервис.СостоянияОбъекта)__СостояниеДокумента.Referent;
            }
            set
            {
                NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                __СостояниеДокумента.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataServerJob
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataServerJob

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataServerJob
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataServerJob

        #region Методы NsgMultipleObject
        private СервернаяЗадача[] convertArray(NsgMultipleObject[] array)
        {
            СервернаяЗадача[] res = new СервернаяЗадача[array.Length];
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
        public new virtual СервернаяЗадача[] FindAll(NsgCompare compare)
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
        public new virtual СервернаяЗадача[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual СервернаяЗадача[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual СервернаяЗадача[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new СервернаяЗадача(this as NsgObject);
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
                base.NSGType = typeof(СервернаяЗадача);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new СервернаяЗадача Value
            {
                get
                {
                    return (СервернаяЗадача)base.Value;
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
                    return "s_Server";
                }
            }
        }

    }

}
