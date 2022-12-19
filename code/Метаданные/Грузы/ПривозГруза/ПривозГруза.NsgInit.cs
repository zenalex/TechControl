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

namespace TechControl.Метаданные.Грузы
{
    
    [NsgTypeName("NsgDataDocument", Guid = "3cdd4645-7c73-40dc-8407-5e108ab1f992")]
    public partial class ПривозГруза : NsgSoft.DataObjects.NsgDataDocument
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
        protected ПривозГруза()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ПривозГруза(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ПривозГруза Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3cdd4645-7c73-40dc-8407-5e108ab1f992"));
            if (obj == null)
                obj = new ПривозГруза();
            return obj as ПривозГруза;
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
	Идентификатор.Guid = NsgService.StringToGuid("fdf7777b-a17a-4616-91ca-b5ff447e4293");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("ce96e655-eb04-46c1-a2ef-cd6e0d752cba");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("c82b6bda-ba66-4ea3-b008-f100eed4db60");
	
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
	НомерКода.Guid = NsgService.StringToGuid("fde5603a-96c1-4b42-9fac-a41e4a85f96b");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("80c91a73-6bc0-407c-a2ce-c2b768cbcf4a");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("64b2886d-8d86-4b56-b10e-32a545e35fc9");
	
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
	Индекс.Guid = NsgService.StringToGuid("8a66f9f9-5915-48b5-a499-b63680ca7385");
	
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
	ДокументОснование.Guid = NsgService.StringToGuid("66ad3ef9-a02c-4ae3-984d-c3773153caa5");
	
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
	Комментарий.Guid = NsgService.StringToGuid("beb50de0-f96a-45f5-90b4-1648e6479dff");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("25b6bc71-194a-4d9b-aca2-8c11be9e30e2");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	Объект.Guid = NsgService.StringToGuid("577d095f-94ba-42e7-9e0d-f8d347f83fd9");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Учет.ТипНоменклатуры ТипГруза
			{  
                NsgDataEnumReference ТипГруза = null;
				if (ObjectList.Contains("ТипГруза"))
                    ТипГруза = ObjectList["ТипГруза"] as NsgDataEnumReference;
                else
                    ТипГруза = new NsgDataEnumReference();
	//NsgDataEnumReference
	ТипГруза.IsLoadedFromDll = true;
	ТипГруза.ReferentGroup = "Учет";
	ТипГруза.ReferentName = "ТипНоменклатуры";
	ТипГруза.SaveInDatabase = true;
	ТипГруза.OwnerName = "";
	ТипГруза.AllowEmptyOwner = false;
	ТипГруза.StringFormat = "";
	ТипГруза.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТипГруза.IncludeInPredefined = false;
	ТипГруза.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипГруза.Required = false;
	ТипГруза.EmptyValue = "";
	ТипГруза.NullAllow = false;
	ТипГруза.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипГруза.FieldName = "TipGruza";
	ТипГруза.InformMetaDataOnValueChanged = false;
	ТипГруза.Visible = true;
	ТипГруза.Name = "ТипГруза";
	ТипГруза.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипГруза.Description = "Тип груза";
	ТипГруза.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипГруза.GroupName = "";
	ТипГруза.Guid = NsgService.StringToGuid("d486945a-9bb4-466b-8d26-40c07776bb54");
	
				if (!ObjectList.Contains("ТипГруза"))
                    ObjectList.Add(ТипГруза);
			}
			#endregion //создание Учет.ТипНоменклатуры ТипГруза
			
			#region создание System.String НомерАвто
			{  
                NsgDataString НомерАвто = null;
				if (ObjectList.Contains("НомерАвто"))
                    НомерАвто = ObjectList["НомерАвто"] as NsgDataString;
                else
                    НомерАвто = new NsgDataString();
	//NsgDataString
	НомерАвто.IsLoadedFromDll = true;
	НомерАвто.Length = 50;
	НомерАвто.StringFormat = "";
	НомерАвто.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерАвто.IncludeInPredefined = false;
	НомерАвто.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерАвто.Required = false;
	НомерАвто.EmptyValue = "";
	НомерАвто.NullAllow = false;
	НомерАвто.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерАвто.FieldName = "NomerAvto";
	НомерАвто.SaveInDatabase = true;
	НомерАвто.InformMetaDataOnValueChanged = false;
	НомерАвто.Visible = true;
	НомерАвто.Name = "НомерАвто";
	НомерАвто.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерАвто.Description = "Номер авто";
	НомерАвто.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерАвто.GroupName = "";
	НомерАвто.Guid = NsgService.StringToGuid("120ec0cc-7ad3-4346-856e-aa0abb884393");
	
				if (!ObjectList.Contains("НомерАвто"))
                    ObjectList.Add(НомерАвто);
			}
			#endregion //создание System.String НомерАвто
			
			#region создание System.Decimal ОбъемГруза
			{  
                NsgDataFloat ОбъемГруза = null;
				if (ObjectList.Contains("ОбъемГруза"))
                    ОбъемГруза = ObjectList["ОбъемГруза"] as NsgDataFloat;
                else
                    ОбъемГруза = new NsgDataFloat();
	//NsgDataFloat
	ОбъемГруза.IsLoadedFromDll = true;
	ОбъемГруза.Precision = 2;
	ОбъемГруза.HideZero = true;
	ОбъемГруза.DefaultValue = 0M;
	ОбъемГруза.MinValue = -100000000000000000M;
	ОбъемГруза.MaxValue = 100000000000000000M;
	ОбъемГруза.UseCalculator = true;
	ОбъемГруза.StringFormat = "";
	ОбъемГруза.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбъемГруза.IncludeInPredefined = false;
	ОбъемГруза.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъемГруза.Required = false;
	ОбъемГруза.EmptyValue = "";
	ОбъемГруза.NullAllow = false;
	ОбъемГруза.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъемГруза.FieldName = "ObemGruza";
	ОбъемГруза.SaveInDatabase = true;
	ОбъемГруза.InformMetaDataOnValueChanged = false;
	ОбъемГруза.Visible = true;
	ОбъемГруза.Name = "ОбъемГруза";
	ОбъемГруза.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъемГруза.Description = "Объем груза";
	ОбъемГруза.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъемГруза.GroupName = "";
	ОбъемГруза.Guid = NsgService.StringToGuid("3e4f829a-565c-405f-8254-4983080833d5");
	
				if (!ObjectList.Contains("ОбъемГруза"))
                    ObjectList.Add(ОбъемГруза);
			}
			#endregion //создание System.Decimal ОбъемГруза
			
			#region создание Мониторинг.Контрагенты Контрагент
			{  
                NsgDataTypedReference Контрагент = null;
				if (ObjectList.Contains("Контрагент"))
                    Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                else
                    Контрагент = new NsgDataTypedReference();
	//NsgDataTypedReference
	Контрагент.IsLoadedFromDll = true;
	Контрагент.ReferentGroup = "Мониторинг";
	Контрагент.ReferentName = "Контрагенты";
	Контрагент.SaveInDatabase = true;
	Контрагент.OwnerName = "";
	Контрагент.AllowEmptyOwner = false;
	Контрагент.StringFormat = "";
	Контрагент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Контрагент.IncludeInPredefined = false;
	Контрагент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Контрагент.Required = false;
	Контрагент.EmptyValue = "";
	Контрагент.NullAllow = false;
	Контрагент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Контрагент.FieldName = "Kontragent";
	Контрагент.InformMetaDataOnValueChanged = false;
	Контрагент.Visible = true;
	Контрагент.Name = "Контрагент";
	Контрагент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Контрагент.Description = "Контрагент";
	Контрагент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Контрагент.GroupName = "";
	Контрагент.Guid = NsgService.StringToGuid("eaee8e96-adba-4ec3-b572-664378788f45");
	
				if (!ObjectList.Contains("Контрагент"))
                    ObjectList.Add(Контрагент);
			}
			#endregion //создание Мониторинг.Контрагенты Контрагент
			
			#region создание _SystemTables.ГрузыПривозГрузаТаблицаКартинок ТаблицаКартинок
			{  
                NsgDataTableReference ТаблицаКартинок = null;
				if (ObjectList.Contains("ТаблицаКартинок"))
                    ТаблицаКартинок = ObjectList["ТаблицаКартинок"] as NsgDataTableReference;
                else
                    ТаблицаКартинок = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаКартинок.IsLoadedFromDll = true;
	ТаблицаКартинок.Name = "ТаблицаКартинок";
	ТаблицаКартинок.SaveInDatabase = false;
	ТаблицаКартинок.ReferentGroup = "_SystemTables";
	ТаблицаКартинок.ReferentName = "ГрузыПривозГрузаТаблицаКартинок";
	ТаблицаКартинок.OwnerName = "";
	ТаблицаКартинок.AllowEmptyOwner = false;
	ТаблицаКартинок.StringFormat = "";
	ТаблицаКартинок.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаКартинок.IncludeInPredefined = false;
	ТаблицаКартинок.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаКартинок.Required = false;
	ТаблицаКартинок.EmptyValue = "";
	ТаблицаКартинок.NullAllow = false;
	ТаблицаКартинок.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаКартинок.FieldName = "TablicaKartinok";
	ТаблицаКартинок.InformMetaDataOnValueChanged = false;
	ТаблицаКартинок.Visible = true;
	ТаблицаКартинок.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаКартинок.Description = "Таблица картинок";
	ТаблицаКартинок.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаКартинок.GroupName = "";
	ТаблицаКартинок.Guid = NsgService.StringToGuid("99ac44bf-6343-4205-acb1-b8a88563006b");
	
				if (!ObjectList.Contains("ТаблицаКартинок"))
                    ObjectList.Add(ТаблицаКартинок);
			}
			#endregion //создание _SystemTables.ГрузыПривозГрузаТаблицаКартинок ТаблицаКартинок
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Мониторинг.ФормированиеСмены", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "Мониторинг.ФормированиеСменыДень", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.ПриходнаяНакладная", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "Грузы.ВывозГруза", "Грузы.ПривозГруза"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ПривозГруза";
	Visible = true;
	Guid = NsgService.StringToGuid("3cdd4645-7c73-40dc-8407-5e108ab1f992");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_PrivozGruza";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Привоз груза";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Грузы";
	
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
            /// Тип груза
            /// </summary>
            public static String ТипГруза
            {
                get
                {
                    return "ТипГруза";
                }
            }
            
            /// <summary>
            /// Номер авто
            /// </summary>
            public static String НомерАвто
            {
                get
                {
                    return "НомерАвто";
                }
            }
            
            /// <summary>
            /// Объем груза
            /// </summary>
            public static String ОбъемГруза
            {
                get
                {
                    return "ОбъемГруза";
                }
            }
            
            /// <summary>
            /// Контрагент
            /// </summary>
            public static String Контрагент
            {
                get
                {
                    return "Контрагент";
                }
            }
            
            /// <summary>
            /// Таблица картинок
            /// </summary>
            public static String ТаблицаКартинок
            {
                get
                {
                    return "ТаблицаКартинок";
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
                    descriptor.Name = "ПривозГруза";
                    descriptor.GroupName = "Грузы";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Грузы.ПривозГруза";
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
        /// Тип груза
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Учет.ТипНоменклатуры ТипГруза
        {
            get
            {
				 NsgDataEnumReference __ТипГруза = ObjectList["ТипГруза"] as NsgDataEnumReference;
                 return (Учет.ТипНоменклатуры)__ТипГруза.Referent;
            }
            set
            {
                NsgDataEnumReference __ТипГруза = ObjectList["ТипГруза"] as NsgDataEnumReference;
                __ТипГруза.Referent = value;
            }
        }
        
        /// <summary>
        /// Номер авто
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String НомерАвто
        {
            get
            {
				 NsgDataString __НомерАвто = ObjectList["НомерАвто"] as NsgDataString;
                 return (System.String)__НомерАвто.Value;
            }
            set
            {
                NsgDataString __НомерАвто = ObjectList["НомерАвто"] as NsgDataString;
                __НомерАвто.Value = value;
            }
        }
        
        /// <summary>
        /// Объем груза
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбъемГруза
        {
            get
            {
				 NsgDataFloat __ОбъемГруза = ObjectList["ОбъемГруза"] as NsgDataFloat;
                 return (System.Decimal)__ОбъемГруза.Value;
            }
            set
            {
                NsgDataFloat __ОбъемГруза = ObjectList["ОбъемГруза"] as NsgDataFloat;
                __ОбъемГруза.Value = value;
            }
        }
        
        /// <summary>
        /// Контрагент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Контрагент
        {
            get
            {
				 NsgDataTypedReference __Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Контрагент.Referent;
            }
            set
            {
                NsgDataTypedReference __Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                __Контрагент.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица картинок
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.ГрузыПривозГрузаТаблицаКартинок ТаблицаКартинок
        {
            get
            {
				 NsgDataTableReference __ТаблицаКартинок = ObjectList["ТаблицаКартинок"] as NsgDataTableReference;
                 return (_SystemTables.ГрузыПривозГрузаТаблицаКартинок)__ТаблицаКартинок.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаКартинок = ObjectList["ТаблицаКартинок"] as NsgDataTableReference;
                __ТаблицаКартинок.Referent = value;
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
        private ПривозГруза[] convertArray(NsgMultipleObject[] array)
        {
            ПривозГруза[] res = new ПривозГруза[array.Length];
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
        public new virtual ПривозГруза[] FindAll(NsgCompare compare)
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
        public new virtual ПривозГруза[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ПривозГруза[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ПривозГруза[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ПривозГруза(this as NsgObject);
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
                base.NSGType = typeof(ПривозГруза);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ПривозГруза Value
            {
                get
                {
                    return (ПривозГруза)base.Value;
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
