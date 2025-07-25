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
    
    [NsgTypeName("NsgDataDocument", Guid = "6a0edca0-2e61-46c1-9a06-b7cea491674d")]
    public partial class Заправка : NsgSoft.DataObjects.NsgDataDocument
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
        protected Заправка()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Заправка(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Заправка Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("6a0edca0-2e61-46c1-9a06-b7cea491674d"));
            if (obj == null)
                obj = new Заправка();
            return obj as Заправка;
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
	Идентификатор.Guid = NsgService.StringToGuid("228ef7a7-4f69-4434-90e7-5a00d96f3166");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("bcabd767-8f9a-4588-b238-4f1a034a6295");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("4e45de9f-ae51-41d8-b606-936c21ae8c9c");
	
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
	НомерКода.Guid = NsgService.StringToGuid("4b29e0fa-dea5-4bbb-a9f9-c71549cab727");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("accb3a1c-d39f-402b-8bdf-354e3eee4a85");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("7b3ad864-7343-4649-8c9f-1a14997937cb");
	
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
	Индекс.Guid = NsgService.StringToGuid("b574c27b-1913-44de-be65-bd5dece848a3");
	
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
	ДокументОснование.Guid = NsgService.StringToGuid("a6a1ac82-7b51-4b25-8fd2-fd5140ca4570");
	
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
	Комментарий.Guid = NsgService.StringToGuid("e30e56a4-00ee-4f4e-b7f4-ab9c14604467");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("b3399d8d-64aa-4c26-ae85-bc29d55f2a8c");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	Техника.Guid = NsgService.StringToGuid("8a7a2491-66b4-44f5-9275-7333ac537bd2");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
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
	Поставщик.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Поставщик.IncludeInPredefined = false;
	Поставщик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Поставщик.Required = false;
	Поставщик.EmptyValue = "";
	Поставщик.NullAllow = false;
	Поставщик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Поставщик.FieldName = "Postavschik";
	Поставщик.InformMetaDataOnValueChanged = false;
	Поставщик.Visible = true;
	Поставщик.Name = "Поставщик";
	Поставщик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Поставщик.Description = "Поставщик";
	Поставщик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Поставщик.GroupName = "";
	Поставщик.Guid = NsgService.StringToGuid("cdbbae0d-4acb-4b62-9e29-34985e4b273b");
	
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
	Объект.Guid = NsgService.StringToGuid("da59b94b-f8ba-4a25-9296-ee6b72f2b497");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	ОбъемТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбъемТоплива.IncludeInPredefined = false;
	ОбъемТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъемТоплива.Required = false;
	ОбъемТоплива.EmptyValue = "";
	ОбъемТоплива.NullAllow = false;
	ОбъемТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъемТоплива.FieldName = "ObemTopliva";
	ОбъемТоплива.SaveInDatabase = true;
	ОбъемТоплива.InformMetaDataOnValueChanged = false;
	ОбъемТоплива.Visible = true;
	ОбъемТоплива.Name = "ОбъемТоплива";
	ОбъемТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъемТоплива.Description = "Объем топлива";
	ОбъемТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъемТоплива.GroupName = "";
	ОбъемТоплива.Guid = NsgService.StringToGuid("1fc170c7-10b2-4296-9b68-da6dc2c632cf");
	
				if (!ObjectList.Contains("ОбъемТоплива"))
                    ObjectList.Add(ОбъемТоплива);
			}
			#endregion //создание System.Decimal ОбъемТоплива
			
			#region создание TechControl.Метаданные.Мониторинг.ЗаправкаФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ЗаправкаФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("9d04b08a-e38f-4179-b5b3-daaa682d3304");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ЗаправкаФормаЭлемента ФормаЭлемента
			
			#region создание Мониторинг.Техника ЗаправочнаяЕмкость
			{  
                NsgDataTypedReference ЗаправочнаяЕмкость = null;
				if (ObjectList.Contains("ЗаправочнаяЕмкость"))
                    ЗаправочнаяЕмкость = ObjectList["ЗаправочнаяЕмкость"] as NsgDataTypedReference;
                else
                    ЗаправочнаяЕмкость = new NsgDataTypedReference();
	//NsgDataTypedReference
	ЗаправочнаяЕмкость.IsLoadedFromDll = true;
	ЗаправочнаяЕмкость.ReferentGroup = "Мониторинг";
	ЗаправочнаяЕмкость.ReferentName = "Техника";
	ЗаправочнаяЕмкость.SaveInDatabase = true;
	ЗаправочнаяЕмкость.OwnerName = "";
	ЗаправочнаяЕмкость.AllowEmptyOwner = false;
	ЗаправочнаяЕмкость.StringFormat = "";
	ЗаправочнаяЕмкость.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЗаправочнаяЕмкость.IncludeInPredefined = false;
	ЗаправочнаяЕмкость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЗаправочнаяЕмкость.Required = false;
	ЗаправочнаяЕмкость.EmptyValue = "";
	ЗаправочнаяЕмкость.NullAllow = false;
	ЗаправочнаяЕмкость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЗаправочнаяЕмкость.FieldName = "ZapravochnajaEmkost";
	ЗаправочнаяЕмкость.InformMetaDataOnValueChanged = false;
	ЗаправочнаяЕмкость.Visible = true;
	ЗаправочнаяЕмкость.Name = "ЗаправочнаяЕмкость";
	ЗаправочнаяЕмкость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗаправочнаяЕмкость.Description = "Заправочная емкость";
	ЗаправочнаяЕмкость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЗаправочнаяЕмкость.GroupName = "";
	ЗаправочнаяЕмкость.Guid = NsgService.StringToGuid("70c28122-a38d-41fa-be03-0dd5e62ec4b5");
	
				if (!ObjectList.Contains("ЗаправочнаяЕмкость"))
                    ObjectList.Add(ЗаправочнаяЕмкость);
			}
			#endregion //создание Мониторинг.Техника ЗаправочнаяЕмкость
			
			#region создание Мониторинг.ВидОперацииЗаправки ВидОперации
			{  
                NsgDataEnumReference ВидОперации = null;
				if (ObjectList.Contains("ВидОперации"))
                    ВидОперации = ObjectList["ВидОперации"] as NsgDataEnumReference;
                else
                    ВидОперации = new NsgDataEnumReference();
	//NsgDataEnumReference
	ВидОперации.IsLoadedFromDll = true;
	ВидОперации.ReferentGroup = "Мониторинг";
	ВидОперации.ReferentName = "ВидОперацииЗаправки";
	ВидОперации.SaveInDatabase = true;
	ВидОперации.OwnerName = "";
	ВидОперации.AllowEmptyOwner = false;
	ВидОперации.StringFormat = "";
	ВидОперации.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВидОперации.IncludeInPredefined = false;
	ВидОперации.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидОперации.Required = false;
	ВидОперации.EmptyValue = "";
	ВидОперации.NullAllow = false;
	ВидОперации.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидОперации.FieldName = "VidOperacii";
	ВидОперации.InformMetaDataOnValueChanged = false;
	ВидОперации.Visible = true;
	ВидОперации.Name = "ВидОперации";
	ВидОперации.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидОперации.Description = "Вид операции";
	ВидОперации.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидОперации.GroupName = "";
	ВидОперации.Guid = NsgService.StringToGuid("0cb83d88-d529-446f-886e-65a29e44dfbf");
	
				if (!ObjectList.Contains("ВидОперации"))
                    ObjectList.Add(ВидОперации);
			}
			#endregion //создание Мониторинг.ВидОперацииЗаправки ВидОперации
			
			#region создание Мониторинг.ИсточникиЗаправки Источник
			{  
                NsgDataEnumReference Источник = null;
				if (ObjectList.Contains("Источник"))
                    Источник = ObjectList["Источник"] as NsgDataEnumReference;
                else
                    Источник = new NsgDataEnumReference();
	//NsgDataEnumReference
	Источник.IsLoadedFromDll = true;
	Источник.ReferentGroup = "Мониторинг";
	Источник.ReferentName = "ИсточникиЗаправки";
	Источник.SaveInDatabase = true;
	Источник.OwnerName = "";
	Источник.AllowEmptyOwner = false;
	Источник.StringFormat = "";
	Источник.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Источник.IncludeInPredefined = false;
	Источник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Источник.Required = false;
	Источник.EmptyValue = "";
	Источник.NullAllow = false;
	Источник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Источник.FieldName = "Istochnik";
	Источник.InformMetaDataOnValueChanged = false;
	Источник.Visible = true;
	Источник.Name = "Источник";
	Источник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Источник.Description = "Источник";
	Источник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Источник.GroupName = "";
	Источник.Guid = NsgService.StringToGuid("6139d6d3-e44b-42f0-b714-0cc5605958fa");
	
				if (!ObjectList.Contains("Источник"))
                    ObjectList.Add(Источник);
			}
			#endregion //создание Мониторинг.ИсточникиЗаправки Источник
			
			#region создание _SystemTables.МониторингЗаправкаТаблица Таблица
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
	Таблица.ReferentName = "МониторингЗаправкаТаблица";
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
	Таблица.Guid = NsgService.StringToGuid("76b6a030-9a9d-4bed-86ba-d2410a9842eb");
	
				if (!ObjectList.Contains("Таблица"))
                    ObjectList.Add(Таблица);
			}
			#endregion //создание _SystemTables.МониторингЗаправкаТаблица Таблица
			
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
	ЭтоИтоговыйДокумент.Guid = NsgService.StringToGuid("6d536d9b-77c0-4f20-b9aa-f6d76d3af98b");
	
				if (!ObjectList.Contains("ЭтоИтоговыйДокумент"))
                    ObjectList.Add(ЭтоИтоговыйДокумент);
			}
			#endregion //создание System.Boolean ЭтоИтоговыйДокумент
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("a4c160b7-1f6c-4e92-9809-a015ec79a389");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.Boolean ЕстьРасхожодения
			{  
                NsgDataBoolean ЕстьРасхожодения = null;
				if (ObjectList.Contains("ЕстьРасхожодения"))
                    ЕстьРасхожодения = ObjectList["ЕстьРасхожодения"] as NsgDataBoolean;
                else
                    ЕстьРасхожодения = new NsgDataBoolean();
	//NsgDataBoolean
	ЕстьРасхожодения.IsLoadedFromDll = true;
	ЕстьРасхожодения.DefaultValue = false;
	ЕстьРасхожодения.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЕстьРасхожодения.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЕстьРасхожодения.StringFormat = "";
	ЕстьРасхожодения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЕстьРасхожодения.IncludeInPredefined = false;
	ЕстьРасхожодения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЕстьРасхожодения.Required = false;
	ЕстьРасхожодения.EmptyValue = "";
	ЕстьРасхожодения.NullAllow = false;
	ЕстьРасхожодения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЕстьРасхожодения.FieldName = "EstRaskhozhodenija";
	ЕстьРасхожодения.SaveInDatabase = true;
	ЕстьРасхожодения.InformMetaDataOnValueChanged = false;
	ЕстьРасхожодения.Visible = true;
	ЕстьРасхожодения.Name = "ЕстьРасхожодения";
	ЕстьРасхожодения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЕстьРасхожодения.Description = "Есть расхожодения";
	ЕстьРасхожодения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЕстьРасхожодения.GroupName = "";
	ЕстьРасхожодения.Guid = NsgService.StringToGuid("c1bdbb4d-6256-4e72-b220-d351e204d638");
	
				if (!ObjectList.Contains("ЕстьРасхожодения"))
                    ObjectList.Add(ЕстьРасхожодения);
			}
			#endregion //создание System.Boolean ЕстьРасхожодения
			
			#region создание System.Boolean Проверено
			{  
                NsgDataBoolean Проверено = null;
				if (ObjectList.Contains("Проверено"))
                    Проверено = ObjectList["Проверено"] as NsgDataBoolean;
                else
                    Проверено = new NsgDataBoolean();
	//NsgDataBoolean
	Проверено.IsLoadedFromDll = true;
	Проверено.DefaultValue = false;
	Проверено.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Проверено.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Проверено.StringFormat = "";
	Проверено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Проверено.IncludeInPredefined = false;
	Проверено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Проверено.Required = false;
	Проверено.EmptyValue = "";
	Проверено.NullAllow = false;
	Проверено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Проверено.FieldName = "Provereno";
	Проверено.SaveInDatabase = true;
	Проверено.InformMetaDataOnValueChanged = false;
	Проверено.Visible = true;
	Проверено.Name = "Проверено";
	Проверено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Проверено.Description = "Проверено";
	Проверено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Проверено.GroupName = "";
	Проверено.Guid = NsgService.StringToGuid("f3516c37-5c5f-4e60-8ca7-55ea85e0aaaa");
	
				if (!ObjectList.Contains("Проверено"))
                    ObjectList.Add(Проверено);
			}
			#endregion //создание System.Boolean Проверено
			
			#region создание System.Decimal МаксимальныйПроцентОтклонения
			{  
                NsgDataFloat МаксимальныйПроцентОтклонения = null;
				if (ObjectList.Contains("МаксимальныйПроцентОтклонения"))
                    МаксимальныйПроцентОтклонения = ObjectList["МаксимальныйПроцентОтклонения"] as NsgDataFloat;
                else
                    МаксимальныйПроцентОтклонения = new NsgDataFloat();
	//NsgDataFloat
	МаксимальныйПроцентОтклонения.IsLoadedFromDll = true;
	МаксимальныйПроцентОтклонения.Precision = 2;
	МаксимальныйПроцентОтклонения.HideZero = true;
	МаксимальныйПроцентОтклонения.DefaultValue = 0M;
	МаксимальныйПроцентОтклонения.MinValue = -100000000000000000M;
	МаксимальныйПроцентОтклонения.MaxValue = 100000000000000000M;
	МаксимальныйПроцентОтклонения.UseCalculator = true;
	МаксимальныйПроцентОтклонения.StringFormat = "";
	МаксимальныйПроцентОтклонения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	МаксимальныйПроцентОтклонения.IncludeInPredefined = false;
	МаксимальныйПроцентОтклонения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	МаксимальныйПроцентОтклонения.Required = false;
	МаксимальныйПроцентОтклонения.EmptyValue = "";
	МаксимальныйПроцентОтклонения.NullAllow = false;
	МаксимальныйПроцентОтклонения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	МаксимальныйПроцентОтклонения.FieldName = "MaksimalnyijProce";
	МаксимальныйПроцентОтклонения.SaveInDatabase = true;
	МаксимальныйПроцентОтклонения.InformMetaDataOnValueChanged = false;
	МаксимальныйПроцентОтклонения.Visible = true;
	МаксимальныйПроцентОтклонения.Name = "МаксимальныйПроцентОтклонения";
	МаксимальныйПроцентОтклонения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	МаксимальныйПроцентОтклонения.Description = "Максимальный процент отклонения";
	МаксимальныйПроцентОтклонения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	МаксимальныйПроцентОтклонения.GroupName = "";
	МаксимальныйПроцентОтклонения.Guid = NsgService.StringToGuid("0fff29cd-1bf2-4070-96e3-91c664588c21");
	
				if (!ObjectList.Contains("МаксимальныйПроцентОтклонения"))
                    ObjectList.Add(МаксимальныйПроцентОтклонения);
			}
			#endregion //создание System.Decimal МаксимальныйПроцентОтклонения
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ЗаявкиНаТехнику"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Заправка";
	Visible = true;
	Guid = NsgService.StringToGuid("6a0edca0-2e61-46c1-9a06-b7cea491674d");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_Zapravka";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документ";
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
            /// Заправочная емкость
            /// </summary>
            public static String ЗаправочнаяЕмкость
            {
                get
                {
                    return "ЗаправочнаяЕмкость";
                }
            }
            
            /// <summary>
            /// Вид операции
            /// </summary>
            public static String ВидОперации
            {
                get
                {
                    return "ВидОперации";
                }
            }
            
            /// <summary>
            /// Источник
            /// </summary>
            public static String Источник
            {
                get
                {
                    return "Источник";
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
            /// Есть расхожодения
            /// </summary>
            public static String ЕстьРасхожодения
            {
                get
                {
                    return "ЕстьРасхожодения";
                }
            }
            
            /// <summary>
            /// Проверено
            /// </summary>
            public static String Проверено
            {
                get
                {
                    return "Проверено";
                }
            }
            
            /// <summary>
            /// Максимальный процент отклонения
            /// </summary>
            public static String МаксимальныйПроцентОтклонения
            {
                get
                {
                    return "МаксимальныйПроцентОтклонения";
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
                    descriptor.Name = "Заправка";
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
            return "Мониторинг.Заправка";
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
        /// Заправочная емкость
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Техника ЗаправочнаяЕмкость
        {
            get
            {
				 NsgDataTypedReference __ЗаправочнаяЕмкость = ObjectList["ЗаправочнаяЕмкость"] as NsgDataTypedReference;
                 return (Мониторинг.Техника)__ЗаправочнаяЕмкость.Referent;
            }
            set
            {
                NsgDataTypedReference __ЗаправочнаяЕмкость = ObjectList["ЗаправочнаяЕмкость"] as NsgDataTypedReference;
                __ЗаправочнаяЕмкость.Referent = value;
            }
        }
        
        /// <summary>
        /// Вид операции
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ВидОперацииЗаправки ВидОперации
        {
            get
            {
				 NsgDataEnumReference __ВидОперации = ObjectList["ВидОперации"] as NsgDataEnumReference;
                 return (Мониторинг.ВидОперацииЗаправки)__ВидОперации.Referent;
            }
            set
            {
                NsgDataEnumReference __ВидОперации = ObjectList["ВидОперации"] as NsgDataEnumReference;
                __ВидОперации.Referent = value;
            }
        }
        
        /// <summary>
        /// Источник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ИсточникиЗаправки Источник
        {
            get
            {
				 NsgDataEnumReference __Источник = ObjectList["Источник"] as NsgDataEnumReference;
                 return (Мониторинг.ИсточникиЗаправки)__Источник.Referent;
            }
            set
            {
                NsgDataEnumReference __Источник = ObjectList["Источник"] as NsgDataEnumReference;
                __Источник.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингЗаправкаТаблица Таблица
        {
            get
            {
				 NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                 return (_SystemTables.МониторингЗаправкаТаблица)__Таблица.Referent;
            }
            set
            {
                NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                __Таблица.Referent = value;
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
        /// Есть расхожодения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЕстьРасхожодения
        {
            get
            {
				 NsgDataBoolean __ЕстьРасхожодения = ObjectList["ЕстьРасхожодения"] as NsgDataBoolean;
                 return (System.Boolean)__ЕстьРасхожодения.Value;
            }
            set
            {
                NsgDataBoolean __ЕстьРасхожодения = ObjectList["ЕстьРасхожодения"] as NsgDataBoolean;
                __ЕстьРасхожодения.Value = value;
            }
        }
        
        /// <summary>
        /// Проверено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Проверено
        {
            get
            {
				 NsgDataBoolean __Проверено = ObjectList["Проверено"] as NsgDataBoolean;
                 return (System.Boolean)__Проверено.Value;
            }
            set
            {
                NsgDataBoolean __Проверено = ObjectList["Проверено"] as NsgDataBoolean;
                __Проверено.Value = value;
            }
        }
        
        /// <summary>
        /// Максимальный процент отклонения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal МаксимальныйПроцентОтклонения
        {
            get
            {
				 NsgDataFloat __МаксимальныйПроцентОтклонения = ObjectList["МаксимальныйПроцентОтклонения"] as NsgDataFloat;
                 return (System.Decimal)__МаксимальныйПроцентОтклонения.Value;
            }
            set
            {
                NsgDataFloat __МаксимальныйПроцентОтклонения = ObjectList["МаксимальныйПроцентОтклонения"] as NsgDataFloat;
                __МаксимальныйПроцентОтклонения.Value = value;
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
        private Заправка[] convertArray(NsgMultipleObject[] array)
        {
            Заправка[] res = new Заправка[array.Length];
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
        public new virtual Заправка[] FindAll(NsgCompare compare)
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
        public new virtual Заправка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Заправка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Заправка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Заправка(this as NsgObject);
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
                base.NSGType = typeof(Заправка);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Заправка Value
            {
                get
                {
                    return (Заправка)base.Value;
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
