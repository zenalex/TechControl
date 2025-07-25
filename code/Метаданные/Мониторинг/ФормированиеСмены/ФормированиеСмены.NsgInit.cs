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
    
    [NsgTypeName("NsgDataDocument", Guid = "3db50703-a1f1-4356-9a40-8923864558c0")]
    public partial class ФормированиеСмены : NsgSoft.DataObjects.NsgDataDocument
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDocument

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDocument

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ФормированиеСмены()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ФормированиеСмены(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ФормированиеСмены Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3db50703-a1f1-4356-9a40-8923864558c0"));
            if (obj == null)
                obj = new ФормированиеСмены();
            return obj as ФормированиеСмены;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDocument
			
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
	Идентификатор.Guid = NsgService.StringToGuid("d29eae73-72ea-49af-a771-f796d139e834");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("50100842-e310-4a4f-b9ba-014788e7e021");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("2c248ed7-0bc6-4d77-904c-92c56ae99813");
	
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
	НомерКода.Guid = NsgService.StringToGuid("2dbfe6fa-29bf-4aa9-8743-b8c2d85c3125");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("27a90d2b-239a-4845-820d-061e4001e699");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("18d83190-2cb4-4c62-b8b0-17dc98f6bdab");
	
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
	Индекс.Guid = NsgService.StringToGuid("88984629-10ba-4b0b-841b-70f20efd93c4");
	
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
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
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
	ДокументОснование.Guid = NsgService.StringToGuid("db292415-574c-4796-9370-6f69007659bc");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
			#region создание System.String Комментарий
			{  
                NsgDataString Комментарий = null;
				if (ObjectList.Contains("Комментарий"))
                    Комментарий = ObjectList["Комментарий"] as NsgDataString;
                else
                    Комментарий = new NsgDataString();
	//NsgDataString
	Комментарий.IsLoadedFromDll = true;
	Комментарий.Length = 0;
	Комментарий.StringFormat = "";
	Комментарий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Комментарий.IncludeInPredefined = false;
	Комментарий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Комментарий.Required = false;
	Комментарий.EmptyValue = "";
	Комментарий.NullAllow = false;
	Комментарий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Комментарий.FieldName = "Kommentariij";
	Комментарий.SaveInDatabase = true;
	Комментарий.InformMetaDataOnValueChanged = false;
	Комментарий.Visible = true;
	Комментарий.Name = "Комментарий";
	Комментарий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Комментарий.Description = "Комментарий";
	Комментарий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Комментарий.GroupName = "";
	Комментарий.Guid = NsgService.StringToGuid("33aad471-cac3-4bac-a682-14ec45e6673c");
	
				if (!ObjectList.Contains("Комментарий"))
                    ObjectList.Add(Комментарий);
			}
			#endregion //создание System.String Комментарий
			
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("ec9f62fb-ce9a-4720-bcde-43615fcb2b77");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание _SystemTables.МониторингФормированиеСменыТаблица Таблица
			{  
                NsgDataTableReference Таблица = null;
				if (ObjectList.Contains("Таблица"))
                    Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                else
                    Таблица = new NsgDataTableReference();
	//NsgDataTableReference
	Таблица.IsLoadedFromDll = true;
	Таблица.Name = "Таблица";
	Таблица.SaveInDatabase = false;
	Таблица.ReferentGroup = "_SystemTables";
	Таблица.ReferentName = "МониторингФормированиеСменыТаблица";
	Таблица.OwnerName = "";
	Таблица.AllowEmptyOwner = false;
	Таблица.StringFormat = "";
	Таблица.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	Таблица.IncludeInPredefined = false;
	Таблица.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Таблица.Required = false;
	Таблица.EmptyValue = "";
	Таблица.NullAllow = false;
	Таблица.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Таблица.FieldName = "Tablica";
	Таблица.InformMetaDataOnValueChanged = false;
	Таблица.Visible = true;
	Таблица.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Таблица.Description = "Таблица";
	Таблица.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Таблица.GroupName = "";
	Таблица.Guid = NsgService.StringToGuid("c691608d-c927-496f-bea5-3d5dac5d0010");
	
				if (!ObjectList.Contains("Таблица"))
                    ObjectList.Add(Таблица);
			}
			#endregion //создание _SystemTables.МониторингФормированиеСменыТаблица Таблица
			
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
	Объект.Guid = NsgService.StringToGuid("41af4770-5f39-4f3b-bc6d-09ecd3b49178");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Мониторинг.ФизЛица Ответственный
			{  
                NsgDataTypedReference Ответственный = null;
				if (ObjectList.Contains("Ответственный"))
                    Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                else
                    Ответственный = new NsgDataTypedReference();
	//NsgDataTypedReference
	Ответственный.IsLoadedFromDll = true;
	Ответственный.ReferentGroup = "Мониторинг";
	Ответственный.ReferentName = "ФизЛица";
	Ответственный.SaveInDatabase = true;
	Ответственный.OwnerName = "";
	Ответственный.AllowEmptyOwner = false;
	Ответственный.StringFormat = "";
	Ответственный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Ответственный.IncludeInPredefined = false;
	Ответственный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Ответственный.Required = false;
	Ответственный.EmptyValue = "";
	Ответственный.NullAllow = false;
	Ответственный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Ответственный.FieldName = "Otvetstvennyij";
	Ответственный.InformMetaDataOnValueChanged = false;
	Ответственный.Visible = true;
	Ответственный.Name = "Ответственный";
	Ответственный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Ответственный.Description = "Ответственный";
	Ответственный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Ответственный.GroupName = "";
	Ответственный.Guid = NsgService.StringToGuid("d260e7be-63c5-44c0-8a86-665fdd7b6163");
	
				if (!ObjectList.Contains("Ответственный"))
                    ObjectList.Add(Ответственный);
			}
			#endregion //создание Мониторинг.ФизЛица Ответственный
			
			#region создание TechControl.Метаданные.Мониторинг.ФормированиеСменыФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ФормированиеСменыФормаЭлемента";
	ФормаЭлемента.SaveInDatabase = false;
	ФормаЭлемента.StringFormat = "";
	ФормаЭлемента.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	ФормаЭлемента.IncludeInPredefined = false;
	ФормаЭлемента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаЭлемента.Required = false;
	ФормаЭлемента.EmptyValue = "";
	ФормаЭлемента.NullAllow = false;
	ФормаЭлемента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаЭлемента.FieldName = "FormaEHlementa";
	ФормаЭлемента.InformMetaDataOnValueChanged = false;
	ФормаЭлемента.Visible = true;
	ФормаЭлемента.Name = "ФормаЭлемента";
	ФормаЭлемента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаЭлемента.Description = "Форма элемента";
	ФормаЭлемента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ФормаЭлемента.GroupName = "";
	ФормаЭлемента.Guid = NsgService.StringToGuid("62c6280a-0a90-4f9a-9c6b-6b9d869787ee");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ФормированиеСменыФормаЭлемента ФормаЭлемента
			
			#region создание _SystemTables.МониторингФормированиеСменыТаблицаПерсонал ТаблицаПерсонал
			{  
                NsgDataTableReference ТаблицаПерсонал = null;
				if (ObjectList.Contains("ТаблицаПерсонал"))
                    ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                else
                    ТаблицаПерсонал = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаПерсонал.IsLoadedFromDll = true;
	ТаблицаПерсонал.Name = "ТаблицаПерсонал";
	ТаблицаПерсонал.SaveInDatabase = false;
	ТаблицаПерсонал.ReferentGroup = "_SystemTables";
	ТаблицаПерсонал.ReferentName = "МониторингФормированиеСменыТаблицаПерсонал";
	ТаблицаПерсонал.OwnerName = "";
	ТаблицаПерсонал.AllowEmptyOwner = false;
	ТаблицаПерсонал.StringFormat = "";
	ТаблицаПерсонал.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаПерсонал.IncludeInPredefined = false;
	ТаблицаПерсонал.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаПерсонал.Required = false;
	ТаблицаПерсонал.EmptyValue = "";
	ТаблицаПерсонал.NullAllow = false;
	ТаблицаПерсонал.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаПерсонал.FieldName = "TablicaPersonal";
	ТаблицаПерсонал.InformMetaDataOnValueChanged = false;
	ТаблицаПерсонал.Visible = true;
	ТаблицаПерсонал.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаПерсонал.Description = "Таблица персонал";
	ТаблицаПерсонал.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаПерсонал.GroupName = "";
	ТаблицаПерсонал.Guid = NsgService.StringToGuid("bc49e820-d71f-49ea-891e-f7417d6a2f92");
	
				if (!ObjectList.Contains("ТаблицаПерсонал"))
                    ObjectList.Add(ТаблицаПерсонал);
			}
			#endregion //создание _SystemTables.МониторингФормированиеСменыТаблицаПерсонал ТаблицаПерсонал
			
			#region создание System.Boolean ЭтоИтоговыйДокумент
			{  
                NsgDataBoolean ЭтоИтоговыйДокумент = null;
				if (ObjectList.Contains("ЭтоИтоговыйДокумент"))
                    ЭтоИтоговыйДокумент = ObjectList["ЭтоИтоговыйДокумент"] as NsgDataBoolean;
                else
                    ЭтоИтоговыйДокумент = new NsgDataBoolean();
	//NsgDataBoolean
	ЭтоИтоговыйДокумент.IsLoadedFromDll = true;
	ЭтоИтоговыйДокумент.DefaultValue = false;
	ЭтоИтоговыйДокумент.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоИтоговыйДокумент.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоИтоговыйДокумент.StringFormat = "";
	ЭтоИтоговыйДокумент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЭтоИтоговыйДокумент.IncludeInPredefined = false;
	ЭтоИтоговыйДокумент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЭтоИтоговыйДокумент.Required = false;
	ЭтоИтоговыйДокумент.EmptyValue = "";
	ЭтоИтоговыйДокумент.NullAllow = false;
	ЭтоИтоговыйДокумент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЭтоИтоговыйДокумент.FieldName = "EHtoItogovyijDoku";
	ЭтоИтоговыйДокумент.SaveInDatabase = true;
	ЭтоИтоговыйДокумент.InformMetaDataOnValueChanged = false;
	ЭтоИтоговыйДокумент.Visible = true;
	ЭтоИтоговыйДокумент.Name = "ЭтоИтоговыйДокумент";
	ЭтоИтоговыйДокумент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоИтоговыйДокумент.Description = "Это итоговый документ";
	ЭтоИтоговыйДокумент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЭтоИтоговыйДокумент.GroupName = "";
	ЭтоИтоговыйДокумент.Guid = NsgService.StringToGuid("27306623-1c2a-425e-aed4-58c73f11df40");
	
				if (!ObjectList.Contains("ЭтоИтоговыйДокумент"))
                    ObjectList.Add(ЭтоИтоговыйДокумент);
			}
			#endregion //создание System.Boolean ЭтоИтоговыйДокумент
			
			#region создание System.Decimal ИтогоЧасовТехника
			{  
                NsgDataAggregate ИтогоЧасовТехника = null;
				if (ObjectList.Contains("ИтогоЧасовТехника"))
                    ИтогоЧасовТехника = ObjectList["ИтогоЧасовТехника"] as NsgDataAggregate;
                else
                    ИтогоЧасовТехника = new NsgDataAggregate();
	//NsgDataAggregate
	ИтогоЧасовТехника.IsLoadedFromDll = true;
	ИтогоЧасовТехника.ReferentName = "Таблица";
	ИтогоЧасовТехника.ReferentFieldName = "Длительность";
	ИтогоЧасовТехника.SaveInDatabase = true;
	ИтогоЧасовТехника.Precision = 2;
	ИтогоЧасовТехника.HideZero = true;
	ИтогоЧасовТехника.DefaultValue = 0M;
	ИтогоЧасовТехника.MinValue = -100000000000000000M;
	ИтогоЧасовТехника.MaxValue = 100000000000000000M;
	ИтогоЧасовТехника.UseCalculator = true;
	ИтогоЧасовТехника.StringFormat = "";
	ИтогоЧасовТехника.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИтогоЧасовТехника.IncludeInPredefined = false;
	ИтогоЧасовТехника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИтогоЧасовТехника.Required = false;
	ИтогоЧасовТехника.EmptyValue = "";
	ИтогоЧасовТехника.NullAllow = false;
	ИтогоЧасовТехника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИтогоЧасовТехника.FieldName = "ItogoCHasovTekhnika";
	ИтогоЧасовТехника.InformMetaDataOnValueChanged = false;
	ИтогоЧасовТехника.Visible = true;
	ИтогоЧасовТехника.Name = "ИтогоЧасовТехника";
	ИтогоЧасовТехника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИтогоЧасовТехника.Description = "Итого часов техника";
	ИтогоЧасовТехника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИтогоЧасовТехника.GroupName = "";
	ИтогоЧасовТехника.Guid = NsgService.StringToGuid("49cd73f5-4116-4960-b033-704a9fcbd56b");
	
				if (!ObjectList.Contains("ИтогоЧасовТехника"))
                    ObjectList.Add(ИтогоЧасовТехника);
			}
			#endregion //создание System.Decimal ИтогоЧасовТехника
			
			#region создание System.Decimal ИтогоЧасовПерсонал
			{  
                NsgDataAggregate ИтогоЧасовПерсонал = null;
				if (ObjectList.Contains("ИтогоЧасовПерсонал"))
                    ИтогоЧасовПерсонал = ObjectList["ИтогоЧасовПерсонал"] as NsgDataAggregate;
                else
                    ИтогоЧасовПерсонал = new NsgDataAggregate();
	//NsgDataAggregate
	ИтогоЧасовПерсонал.IsLoadedFromDll = true;
	ИтогоЧасовПерсонал.ReferentName = "ТаблицаПерсонал";
	ИтогоЧасовПерсонал.ReferentFieldName = "Длительность";
	ИтогоЧасовПерсонал.SaveInDatabase = true;
	ИтогоЧасовПерсонал.Precision = 2;
	ИтогоЧасовПерсонал.HideZero = true;
	ИтогоЧасовПерсонал.DefaultValue = 0M;
	ИтогоЧасовПерсонал.MinValue = -100000000000000000M;
	ИтогоЧасовПерсонал.MaxValue = 100000000000000000M;
	ИтогоЧасовПерсонал.UseCalculator = true;
	ИтогоЧасовПерсонал.StringFormat = "";
	ИтогоЧасовПерсонал.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИтогоЧасовПерсонал.IncludeInPredefined = false;
	ИтогоЧасовПерсонал.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИтогоЧасовПерсонал.Required = false;
	ИтогоЧасовПерсонал.EmptyValue = "";
	ИтогоЧасовПерсонал.NullAllow = false;
	ИтогоЧасовПерсонал.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИтогоЧасовПерсонал.FieldName = "ItogoCHasovPersonal";
	ИтогоЧасовПерсонал.InformMetaDataOnValueChanged = false;
	ИтогоЧасовПерсонал.Visible = true;
	ИтогоЧасовПерсонал.Name = "ИтогоЧасовПерсонал";
	ИтогоЧасовПерсонал.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИтогоЧасовПерсонал.Description = "Итого часов персонал";
	ИтогоЧасовПерсонал.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИтогоЧасовПерсонал.GroupName = "";
	ИтогоЧасовПерсонал.Guid = NsgService.StringToGuid("1aea7920-1b09-4e1a-ae27-5f6857dde88e");
	
				if (!ObjectList.Contains("ИтогоЧасовПерсонал"))
                    ObjectList.Add(ИтогоЧасовПерсонал);
			}
			#endregion //создание System.Decimal ИтогоЧасовПерсонал
			
			#region создание System.Int64 КоличествоТехники
			{  
                NsgDataInteger КоличествоТехники = null;
				if (ObjectList.Contains("КоличествоТехники"))
                    КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                else
                    КоличествоТехники = new NsgDataInteger();
	//NsgDataInteger
	КоличествоТехники.IsLoadedFromDll = true;
	КоличествоТехники.DefaultValue = 0M;
	КоличествоТехники.MinValue = 0M;
	КоличествоТехники.MaxValue = 0M;
	КоличествоТехники.UseCalculator = true;
	КоличествоТехники.StringFormat = "";
	КоличествоТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КоличествоТехники.IncludeInPredefined = false;
	КоличествоТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоТехники.Required = false;
	КоличествоТехники.EmptyValue = "";
	КоличествоТехники.NullAllow = false;
	КоличествоТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоТехники.FieldName = "KolichestvoTekhniki";
	КоличествоТехники.SaveInDatabase = true;
	КоличествоТехники.InformMetaDataOnValueChanged = false;
	КоличествоТехники.Visible = true;
	КоличествоТехники.Name = "КоличествоТехники";
	КоличествоТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоТехники.Description = "Количество техники";
	КоличествоТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоТехники.GroupName = "";
	КоличествоТехники.Guid = NsgService.StringToGuid("7cc1840e-104a-497a-baf9-168bebf0355c");
	
				if (!ObjectList.Contains("КоличествоТехники"))
                    ObjectList.Add(КоличествоТехники);
			}
			#endregion //создание System.Int64 КоличествоТехники
			
			#region создание System.Int64 ВсегоТехникиВРаботе
			{  
                NsgDataInteger ВсегоТехникиВРаботе = null;
				if (ObjectList.Contains("ВсегоТехникиВРаботе"))
                    ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                else
                    ВсегоТехникиВРаботе = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиВРаботе.IsLoadedFromDll = true;
	ВсегоТехникиВРаботе.DefaultValue = 0M;
	ВсегоТехникиВРаботе.MinValue = 0M;
	ВсегоТехникиВРаботе.MaxValue = 0M;
	ВсегоТехникиВРаботе.UseCalculator = true;
	ВсегоТехникиВРаботе.StringFormat = "";
	ВсегоТехникиВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиВРаботе.IncludeInPredefined = false;
	ВсегоТехникиВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиВРаботе.Required = false;
	ВсегоТехникиВРаботе.EmptyValue = "";
	ВсегоТехникиВРаботе.NullAllow = false;
	ВсегоТехникиВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиВРаботе.FieldName = "VsegoTekhnikiVRabote";
	ВсегоТехникиВРаботе.SaveInDatabase = true;
	ВсегоТехникиВРаботе.InformMetaDataOnValueChanged = false;
	ВсегоТехникиВРаботе.Visible = true;
	ВсегоТехникиВРаботе.Name = "ВсегоТехникиВРаботе";
	ВсегоТехникиВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиВРаботе.Description = "Всего техники ВРаботе";
	ВсегоТехникиВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиВРаботе.GroupName = "";
	ВсегоТехникиВРаботе.Guid = NsgService.StringToGuid("530e79d3-e532-4da9-98ff-5aa76f1c14df");
	
				if (!ObjectList.Contains("ВсегоТехникиВРаботе"))
                    ObjectList.Add(ВсегоТехникиВРаботе);
			}
			#endregion //создание System.Int64 ВсегоТехникиВРаботе
			
			#region создание System.Int64 ВсегоТехникиНеВРаботе
			{  
                NsgDataInteger ВсегоТехникиНеВРаботе = null;
				if (ObjectList.Contains("ВсегоТехникиНеВРаботе"))
                    ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                else
                    ВсегоТехникиНеВРаботе = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиНеВРаботе.IsLoadedFromDll = true;
	ВсегоТехникиНеВРаботе.DefaultValue = 0M;
	ВсегоТехникиНеВРаботе.MinValue = 0M;
	ВсегоТехникиНеВРаботе.MaxValue = 0M;
	ВсегоТехникиНеВРаботе.UseCalculator = true;
	ВсегоТехникиНеВРаботе.StringFormat = "";
	ВсегоТехникиНеВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиНеВРаботе.IncludeInPredefined = false;
	ВсегоТехникиНеВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиНеВРаботе.Required = false;
	ВсегоТехникиНеВРаботе.EmptyValue = "";
	ВсегоТехникиНеВРаботе.NullAllow = false;
	ВсегоТехникиНеВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиНеВРаботе.FieldName = "VsegoTekhnikiNeVR";
	ВсегоТехникиНеВРаботе.SaveInDatabase = true;
	ВсегоТехникиНеВРаботе.InformMetaDataOnValueChanged = false;
	ВсегоТехникиНеВРаботе.Visible = true;
	ВсегоТехникиНеВРаботе.Name = "ВсегоТехникиНеВРаботе";
	ВсегоТехникиНеВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиНеВРаботе.Description = "Всего техники не ВРаботе";
	ВсегоТехникиНеВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиНеВРаботе.GroupName = "";
	ВсегоТехникиНеВРаботе.Guid = NsgService.StringToGuid("818a203f-ced0-4c76-affc-f6065aa75d60");
	
				if (!ObjectList.Contains("ВсегоТехникиНеВРаботе"))
                    ObjectList.Add(ВсегоТехникиНеВРаботе);
			}
			#endregion //создание System.Int64 ВсегоТехникиНеВРаботе
			
			#region создание System.Int64 ВсегоТехникиСломано
			{  
                NsgDataInteger ВсегоТехникиСломано = null;
				if (ObjectList.Contains("ВсегоТехникиСломано"))
                    ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                else
                    ВсегоТехникиСломано = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиСломано.IsLoadedFromDll = true;
	ВсегоТехникиСломано.DefaultValue = 0M;
	ВсегоТехникиСломано.MinValue = 0M;
	ВсегоТехникиСломано.MaxValue = 0M;
	ВсегоТехникиСломано.UseCalculator = true;
	ВсегоТехникиСломано.StringFormat = "";
	ВсегоТехникиСломано.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиСломано.IncludeInPredefined = false;
	ВсегоТехникиСломано.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиСломано.Required = false;
	ВсегоТехникиСломано.EmptyValue = "";
	ВсегоТехникиСломано.NullAllow = false;
	ВсегоТехникиСломано.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиСломано.FieldName = "VsegoTekhnikiSlomano";
	ВсегоТехникиСломано.SaveInDatabase = true;
	ВсегоТехникиСломано.InformMetaDataOnValueChanged = false;
	ВсегоТехникиСломано.Visible = true;
	ВсегоТехникиСломано.Name = "ВсегоТехникиСломано";
	ВсегоТехникиСломано.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиСломано.Description = "Всего техники сломано";
	ВсегоТехникиСломано.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиСломано.GroupName = "";
	ВсегоТехникиСломано.Guid = NsgService.StringToGuid("9af41814-adfa-47cd-b876-89802a18a356");
	
				if (!ObjectList.Contains("ВсегоТехникиСломано"))
                    ObjectList.Add(ВсегоТехникиСломано);
			}
			#endregion //создание System.Int64 ВсегоТехникиСломано
			
			#region создание System.Int64 ВсегоТехникиВРемонте
			{  
                NsgDataInteger ВсегоТехникиВРемонте = null;
				if (ObjectList.Contains("ВсегоТехникиВРемонте"))
                    ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                else
                    ВсегоТехникиВРемонте = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиВРемонте.IsLoadedFromDll = true;
	ВсегоТехникиВРемонте.DefaultValue = 0M;
	ВсегоТехникиВРемонте.MinValue = 0M;
	ВсегоТехникиВРемонте.MaxValue = 0M;
	ВсегоТехникиВРемонте.UseCalculator = true;
	ВсегоТехникиВРемонте.StringFormat = "";
	ВсегоТехникиВРемонте.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиВРемонте.IncludeInPredefined = false;
	ВсегоТехникиВРемонте.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиВРемонте.Required = false;
	ВсегоТехникиВРемонте.EmptyValue = "";
	ВсегоТехникиВРемонте.NullAllow = false;
	ВсегоТехникиВРемонте.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиВРемонте.FieldName = "VsegoTekhnikiVRem";
	ВсегоТехникиВРемонте.SaveInDatabase = true;
	ВсегоТехникиВРемонте.InformMetaDataOnValueChanged = false;
	ВсегоТехникиВРемонте.Visible = true;
	ВсегоТехникиВРемонте.Name = "ВсегоТехникиВРемонте";
	ВсегоТехникиВРемонте.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиВРемонте.Description = "Всего техники ВРемонте";
	ВсегоТехникиВРемонте.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиВРемонте.GroupName = "";
	ВсегоТехникиВРемонте.Guid = NsgService.StringToGuid("bf310740-2b89-4afd-bbf4-5f3920731e23");
	
				if (!ObjectList.Contains("ВсегоТехникиВРемонте"))
                    ObjectList.Add(ВсегоТехникиВРемонте);
			}
			#endregion //создание System.Int64 ВсегоТехникиВРемонте
			
			#region создание System.Boolean ПровереноАвтоматически
			{  
                NsgDataBoolean ПровереноАвтоматически = null;
				if (ObjectList.Contains("ПровереноАвтоматически"))
                    ПровереноАвтоматически = ObjectList["ПровереноАвтоматически"] as NsgDataBoolean;
                else
                    ПровереноАвтоматически = new NsgDataBoolean();
	//NsgDataBoolean
	ПровереноАвтоматически.IsLoadedFromDll = true;
	ПровереноАвтоматически.DefaultValue = false;
	ПровереноАвтоматически.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПровереноАвтоматически.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПровереноАвтоматически.StringFormat = "";
	ПровереноАвтоматически.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПровереноАвтоматически.IncludeInPredefined = false;
	ПровереноАвтоматически.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПровереноАвтоматически.Required = false;
	ПровереноАвтоматически.EmptyValue = "";
	ПровереноАвтоматически.NullAllow = false;
	ПровереноАвтоматически.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПровереноАвтоматически.FieldName = "AvtomaticheskajaP";
	ПровереноАвтоматически.SaveInDatabase = true;
	ПровереноАвтоматически.InformMetaDataOnValueChanged = false;
	ПровереноАвтоматически.Visible = true;
	ПровереноАвтоматически.Name = "ПровереноАвтоматически";
	ПровереноАвтоматически.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПровереноАвтоматически.Description = "Проверено автоматически";
	ПровереноАвтоматически.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПровереноАвтоматически.GroupName = "";
	ПровереноАвтоматически.Guid = NsgService.StringToGuid("816962b2-ff29-4776-baf2-b9f845228dff");
	
				if (!ObjectList.Contains("ПровереноАвтоматически"))
                    ObjectList.Add(ПровереноАвтоматически);
			}
			#endregion //создание System.Boolean ПровереноАвтоматически
			
			#region создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			{  
                NsgDataTypedReference АккаунтПользователя = null;
				if (ObjectList.Contains("АккаунтПользователя"))
                    АккаунтПользователя = ObjectList["АккаунтПользователя"] as NsgDataTypedReference;
                else
                    АккаунтПользователя = new NsgDataTypedReference();
	//NsgDataTypedReference
	АккаунтПользователя.IsLoadedFromDll = true;
	АккаунтПользователя.ReferentGroup = "СлужебныеСправочники";
	АккаунтПользователя.ReferentName = "АккаунтПользователя";
	АккаунтПользователя.SaveInDatabase = true;
	АккаунтПользователя.OwnerName = "";
	АккаунтПользователя.AllowEmptyOwner = false;
	АккаунтПользователя.StringFormat = "";
	АккаунтПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	АккаунтПользователя.IncludeInPredefined = false;
	АккаунтПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АккаунтПользователя.Required = false;
	АккаунтПользователя.EmptyValue = "";
	АккаунтПользователя.NullAllow = false;
	АккаунтПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АккаунтПользователя.FieldName = "AkkauntPolzovatelja";
	АккаунтПользователя.InformMetaDataOnValueChanged = false;
	АккаунтПользователя.Visible = true;
	АккаунтПользователя.Name = "АккаунтПользователя";
	АккаунтПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	АккаунтПользователя.Description = "Аккаунт пользователя";
	АккаунтПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	АккаунтПользователя.GroupName = "";
	АккаунтПользователя.Guid = NsgService.StringToGuid("55c42bfa-9580-4f3a-9aea-a9d3245c40c5");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.DateTime ДатаОкончанияСмены
			{  
                NsgDataDateTime ДатаОкончанияСмены = null;
				if (ObjectList.Contains("ДатаОкончанияСмены"))
                    ДатаОкончанияСмены = ObjectList["ДатаОкончанияСмены"] as NsgDataDateTime;
                else
                    ДатаОкончанияСмены = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияСмены.IsLoadedFromDll = true;
	ДатаОкончанияСмены.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончанияСмены.StringFormat = "";
	ДатаОкончанияСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияСмены.IncludeInPredefined = false;
	ДатаОкончанияСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияСмены.Required = false;
	ДатаОкончанияСмены.EmptyValue = "";
	ДатаОкончанияСмены.NullAllow = false;
	ДатаОкончанияСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончанияСмены.FieldName = "DataOkonchanijaSmeny";
	ДатаОкончанияСмены.SaveInDatabase = true;
	ДатаОкончанияСмены.InformMetaDataOnValueChanged = false;
	ДатаОкончанияСмены.Visible = true;
	ДатаОкончанияСмены.Name = "ДатаОкончанияСмены";
	ДатаОкончанияСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончанияСмены.Description = "Дата окончания смены";
	ДатаОкончанияСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончанияСмены.GroupName = "";
	ДатаОкончанияСмены.Guid = NsgService.StringToGuid("62b20471-ae80-446e-bffc-161d500dd7af");
	
				if (!ObjectList.Contains("ДатаОкончанияСмены"))
                    ObjectList.Add(ДатаОкончанияСмены);
			}
			#endregion //создание System.DateTime ДатаОкончанияСмены
			
			#region создание СлужебныеСправочники.ПользователиСервисов ПользовательСервисов
			{  
                NsgDataTypedReference ПользовательСервисов = null;
				if (ObjectList.Contains("ПользовательСервисов"))
                    ПользовательСервисов = ObjectList["ПользовательСервисов"] as NsgDataTypedReference;
                else
                    ПользовательСервисов = new NsgDataTypedReference();
	//NsgDataTypedReference
	ПользовательСервисов.IsLoadedFromDll = true;
	ПользовательСервисов.ReferentGroup = "СлужебныеСправочники";
	ПользовательСервисов.ReferentName = "ПользователиСервисов";
	ПользовательСервисов.SaveInDatabase = true;
	ПользовательСервисов.OwnerName = "";
	ПользовательСервисов.AllowEmptyOwner = false;
	ПользовательСервисов.StringFormat = "";
	ПользовательСервисов.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПользовательСервисов.IncludeInPredefined = false;
	ПользовательСервисов.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПользовательСервисов.Required = false;
	ПользовательСервисов.EmptyValue = "";
	ПользовательСервисов.NullAllow = false;
	ПользовательСервисов.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПользовательСервисов.FieldName = "PolzovatelServisov";
	ПользовательСервисов.InformMetaDataOnValueChanged = false;
	ПользовательСервисов.Visible = true;
	ПользовательСервисов.Name = "ПользовательСервисов";
	ПользовательСервисов.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПользовательСервисов.Description = "Пользователь сервисов";
	ПользовательСервисов.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПользовательСервисов.GroupName = "";
	ПользовательСервисов.Guid = NsgService.StringToGuid("ceb3b418-5aec-4d20-9d22-3d7b5a41d401");
	
				if (!ObjectList.Contains("ПользовательСервисов"))
                    ObjectList.Add(ПользовательСервисов);
			}
			#endregion //создание СлужебныеСправочники.ПользователиСервисов ПользовательСервисов
			
			#region создание System.DateTime ДатаПоследнегоИзменения
			{  
                NsgDataDateTime ДатаПоследнегоИзменения = null;
				if (ObjectList.Contains("ДатаПоследнегоИзменения"))
                    ДатаПоследнегоИзменения = ObjectList["ДатаПоследнегоИзменения"] as NsgDataDateTime;
                else
                    ДатаПоследнегоИзменения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПоследнегоИзменения.IsLoadedFromDll = true;
	ДатаПоследнегоИзменения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПоследнегоИзменения.StringFormat = "";
	ДатаПоследнегоИзменения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаПоследнегоИзменения.IncludeInPredefined = false;
	ДатаПоследнегоИзменения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПоследнегоИзменения.Required = false;
	ДатаПоследнегоИзменения.EmptyValue = "";
	ДатаПоследнегоИзменения.NullAllow = false;
	ДатаПоследнегоИзменения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПоследнегоИзменения.FieldName = "DataPoslednegoIzm";
	ДатаПоследнегоИзменения.SaveInDatabase = true;
	ДатаПоследнегоИзменения.InformMetaDataOnValueChanged = false;
	ДатаПоследнегоИзменения.Visible = true;
	ДатаПоследнегоИзменения.Name = "ДатаПоследнегоИзменения";
	ДатаПоследнегоИзменения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПоследнегоИзменения.Description = "Дата последнего изменения";
	ДатаПоследнегоИзменения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПоследнегоИзменения.GroupName = "";
	ДатаПоследнегоИзменения.Guid = NsgService.StringToGuid("bce63288-4862-4976-881a-ff69184d3ade");
	
				if (!ObjectList.Contains("ДатаПоследнегоИзменения"))
                    ObjectList.Add(ДатаПоследнегоИзменения);
			}
			#endregion //создание System.DateTime ДатаПоследнегоИзменения
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "Мониторинг.ФормированиеСменыДень", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ЗаявкиНаТехнику"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ФормированиеСмены";
	Visible = true;
	Guid = NsgService.StringToGuid("3db50703-a1f1-4356-9a40-8923864558c0");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_FormirovanieSmeny";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Формирование смены (итоговое)";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDocument

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDocument.Names
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
            /// Комментарий
            /// </summary>
            public static String Комментарий
            {
                get
                {
                    return "Комментарий";
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
            
            /// <summary>
            /// Таблица
            /// </summary>
            public static String Таблица
            {
                get
                {
                    return "Таблица";
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
            /// Ответственный
            /// </summary>
            public static String Ответственный
            {
                get
                {
                    return "Ответственный";
                }
            }
            
            /// <summary>
            /// Форма элемента
            /// </summary>
            public static String ФормаЭлемента
            {
                get
                {
                    return "ФормаЭлемента";
                }
            }
            
            /// <summary>
            /// Таблица персонал
            /// </summary>
            public static String ТаблицаПерсонал
            {
                get
                {
                    return "ТаблицаПерсонал";
                }
            }
            
            /// <summary>
            /// Это итоговый документ
            /// </summary>
            public static String ЭтоИтоговыйДокумент
            {
                get
                {
                    return "ЭтоИтоговыйДокумент";
                }
            }
            
            /// <summary>
            /// Итого часов техника
            /// </summary>
            public static String ИтогоЧасовТехника
            {
                get
                {
                    return "ИтогоЧасовТехника";
                }
            }
            
            /// <summary>
            /// Итого часов персонал
            /// </summary>
            public static String ИтогоЧасовПерсонал
            {
                get
                {
                    return "ИтогоЧасовПерсонал";
                }
            }
            
            /// <summary>
            /// Количество техники
            /// </summary>
            public static String КоличествоТехники
            {
                get
                {
                    return "КоличествоТехники";
                }
            }
            
            /// <summary>
            /// Всего техники ВРаботе
            /// </summary>
            public static String ВсегоТехникиВРаботе
            {
                get
                {
                    return "ВсегоТехникиВРаботе";
                }
            }
            
            /// <summary>
            /// Всего техники не ВРаботе
            /// </summary>
            public static String ВсегоТехникиНеВРаботе
            {
                get
                {
                    return "ВсегоТехникиНеВРаботе";
                }
            }
            
            /// <summary>
            /// Всего техники сломано
            /// </summary>
            public static String ВсегоТехникиСломано
            {
                get
                {
                    return "ВсегоТехникиСломано";
                }
            }
            
            /// <summary>
            /// Всего техники ВРемонте
            /// </summary>
            public static String ВсегоТехникиВРемонте
            {
                get
                {
                    return "ВсегоТехникиВРемонте";
                }
            }
            
            /// <summary>
            /// Проверено автоматически
            /// </summary>
            public static String ПровереноАвтоматически
            {
                get
                {
                    return "ПровереноАвтоматически";
                }
            }
            
            /// <summary>
            /// Аккаунт пользователя
            /// </summary>
            public static String АккаунтПользователя
            {
                get
                {
                    return "АккаунтПользователя";
                }
            }
            
            /// <summary>
            /// Дата окончания смены
            /// </summary>
            public static String ДатаОкончанияСмены
            {
                get
                {
                    return "ДатаОкончанияСмены";
                }
            }
            
            /// <summary>
            /// Пользователь сервисов
            /// </summary>
            public static String ПользовательСервисов
            {
                get
                {
                    return "ПользовательСервисов";
                }
            }
            
            /// <summary>
            /// Дата последнего изменения
            /// </summary>
            public static String ДатаПоследнегоИзменения
            {
                get
                {
                    return "ДатаПоследнегоИзменения";
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
                    descriptor.Name = "ФормированиеСмены";
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
            return "Мониторинг.ФормированиеСмены";
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
        /// Комментарий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Комментарий
        {
            get
            {
				 NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                 return (System.String)__Комментарий.Value;
            }
            set
            {
                NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                __Комментарий.Value = value;
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
        
        /// <summary>
        /// Таблица
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФормированиеСменыТаблица Таблица
        {
            get
            {
				 NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФормированиеСменыТаблица)__Таблица.Referent;
            }
            set
            {
                NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                __Таблица.Referent = value;
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
        /// Ответственный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Ответственный
        {
            get
            {
				 NsgDataTypedReference __Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Ответственный.Referent;
            }
            set
            {
                NsgDataTypedReference __Ответственный = ObjectList["Ответственный"] as NsgDataTypedReference;
                __Ответственный.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица персонал
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФормированиеСменыТаблицаПерсонал ТаблицаПерсонал
        {
            get
            {
				 NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФормированиеСменыТаблицаПерсонал)__ТаблицаПерсонал.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                __ТаблицаПерсонал.Referent = value;
            }
        }
        
        /// <summary>
        /// Это итоговый документ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЭтоИтоговыйДокумент
        {
            get
            {
				 NsgDataBoolean __ЭтоИтоговыйДокумент = ObjectList["ЭтоИтоговыйДокумент"] as NsgDataBoolean;
                 return (System.Boolean)__ЭтоИтоговыйДокумент.Value;
            }
            set
            {
                NsgDataBoolean __ЭтоИтоговыйДокумент = ObjectList["ЭтоИтоговыйДокумент"] as NsgDataBoolean;
                __ЭтоИтоговыйДокумент.Value = value;
            }
        }
        
        /// <summary>
        /// Итого часов техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataAggregate")]
        
        public System.Decimal ИтогоЧасовТехника
        {
            get
            {
				 NsgDataAggregate __ИтогоЧасовТехника = ObjectList["ИтогоЧасовТехника"] as NsgDataAggregate;
                 return (System.Decimal)__ИтогоЧасовТехника.Value;
            }
            set
            {
                NsgDataAggregate __ИтогоЧасовТехника = ObjectList["ИтогоЧасовТехника"] as NsgDataAggregate;
                __ИтогоЧасовТехника.Value = value;
            }
        }
        
        /// <summary>
        /// Итого часов персонал
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataAggregate")]
        
        public System.Decimal ИтогоЧасовПерсонал
        {
            get
            {
				 NsgDataAggregate __ИтогоЧасовПерсонал = ObjectList["ИтогоЧасовПерсонал"] as NsgDataAggregate;
                 return (System.Decimal)__ИтогоЧасовПерсонал.Value;
            }
            set
            {
                NsgDataAggregate __ИтогоЧасовПерсонал = ObjectList["ИтогоЧасовПерсонал"] as NsgDataAggregate;
                __ИтогоЧасовПерсонал.Value = value;
            }
        }
        
        /// <summary>
        /// Количество техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоТехники
        {
            get
            {
				 NsgDataInteger __КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                 return (System.Int64)__КоличествоТехники.Value;
            }
            set
            {
                NsgDataInteger __КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                __КоличествоТехники.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиВРаботе
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиВРаботе.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                __ВсегоТехникиВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники не ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиНеВРаботе
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиНеВРаботе.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                __ВсегоТехникиНеВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники сломано
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиСломано
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиСломано.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                __ВсегоТехникиСломано.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники ВРемонте
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиВРемонте
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиВРемонте.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                __ВсегоТехникиВРемонте.Value = value;
            }
        }
        
        /// <summary>
        /// Проверено автоматически
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ПровереноАвтоматически
        {
            get
            {
				 NsgDataBoolean __ПровереноАвтоматически = ObjectList["ПровереноАвтоматически"] as NsgDataBoolean;
                 return (System.Boolean)__ПровереноАвтоматически.Value;
            }
            set
            {
                NsgDataBoolean __ПровереноАвтоматически = ObjectList["ПровереноАвтоматически"] as NsgDataBoolean;
                __ПровереноАвтоматически.Value = value;
            }
        }
        
        /// <summary>
        /// Аккаунт пользователя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
        {
            get
            {
				 NsgDataTypedReference __АккаунтПользователя = ObjectList["АккаунтПользователя"] as NsgDataTypedReference;
                 return (СлужебныеСправочники.АккаунтПользователя)__АккаунтПользователя.Referent;
            }
            set
            {
                NsgDataTypedReference __АккаунтПользователя = ObjectList["АккаунтПользователя"] as NsgDataTypedReference;
                __АккаунтПользователя.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата окончания смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияСмены
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияСмены = ObjectList["ДатаОкончанияСмены"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияСмены.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияСмены = ObjectList["ДатаОкончанияСмены"] as NsgDataDateTime;
                __ДатаОкончанияСмены.Value = value;
            }
        }
        
        /// <summary>
        /// Пользователь сервисов
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СлужебныеСправочники.ПользователиСервисов ПользовательСервисов
        {
            get
            {
				 NsgDataTypedReference __ПользовательСервисов = ObjectList["ПользовательСервисов"] as NsgDataTypedReference;
                 return (СлужебныеСправочники.ПользователиСервисов)__ПользовательСервисов.Referent;
            }
            set
            {
                NsgDataTypedReference __ПользовательСервисов = ObjectList["ПользовательСервисов"] as NsgDataTypedReference;
                __ПользовательСервисов.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПоследнегоИзменения
        {
            get
            {
				 NsgDataDateTime __ДатаПоследнегоИзменения = ObjectList["ДатаПоследнегоИзменения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПоследнегоИзменения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПоследнегоИзменения = ObjectList["ДатаПоследнегоИзменения"] as NsgDataDateTime;
                __ДатаПоследнегоИзменения.Value = value;
            }
        }
        

        
        /// <summary>
        /// Форма элемента
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаЭлемента
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаЭлемента"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаЭлемента");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаЭлемента");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgDataDocument
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDocument

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDocument

        #region Методы NsgMultipleObject
        private ФормированиеСмены[] convertArray(NsgMultipleObject[] array)
        {
            ФормированиеСмены[] res = new ФормированиеСмены[array.Length];
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
        public new virtual ФормированиеСмены[] FindAll(NsgCompare compare)
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
        public new virtual ФормированиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ФормированиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ФормированиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ФормированиеСмены(this as NsgObject);
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
                base.NSGType = typeof(ФормированиеСмены);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ФормированиеСмены Value
            {
                get
                {
                    return (ФормированиеСмены)base.Value;
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
                    return "s_NsgDataDocument";
                }
            }
        }

    }

}
