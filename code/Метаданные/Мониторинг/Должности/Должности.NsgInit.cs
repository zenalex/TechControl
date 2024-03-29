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
    
    [NsgTypeName("NsgDataDictionary", Guid = "b2e03c9f-8023-41b8-a72c-9480fb619b20")]
    public partial class Должности : NsgSoft.DataObjects.NsgDataDictionary
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDictionary

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Должности()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Должности(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Должности Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b2e03c9f-8023-41b8-a72c-9480fb619b20"));
            if (obj == null)
                obj = new Должности();
            return obj as Должности;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			
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
	Идентификатор.Guid = NsgService.StringToGuid("8b12e46c-d4a5-4bc0-8bac-d29443599e6c");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("8878ea4d-e07a-4bd6-9f98-98284c903592");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.Boolean ЭтоГруппа
			{  
                NsgDataBoolean ЭтоГруппа = null;
				if (ObjectList.Contains("ЭтоГруппа"))
                    ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                else
                    ЭтоГруппа = new NsgDataBoolean();
	//NsgDataBoolean
	ЭтоГруппа.IsLoadedFromDll = true;
	ЭтоГруппа.DefaultValue = false;
	ЭтоГруппа.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.StringFormat = "";
	ЭтоГруппа.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЭтоГруппа.IncludeInPredefined = false;
	ЭтоГруппа.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЭтоГруппа.Required = false;
	ЭтоГруппа.EmptyValue = "";
	ЭтоГруппа.NullAllow = false;
	ЭтоГруппа.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ЭтоГруппа.FieldName = "_IsFolder";
	ЭтоГруппа.SaveInDatabase = true;
	ЭтоГруппа.InformMetaDataOnValueChanged = false;
	ЭтоГруппа.Visible = true;
	ЭтоГруппа.Name = "ЭтоГруппа";
	ЭтоГруппа.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.Description = "Это группа";
	ЭтоГруппа.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ЭтоГруппа.GroupName = "";
	ЭтоГруппа.Guid = NsgService.StringToGuid("2ef26441-1d45-403f-85c1-22adbcbddeca");
	
				if (!ObjectList.Contains("ЭтоГруппа"))
                    ObjectList.Add(ЭтоГруппа);
			}
			#endregion //создание System.Boolean ЭтоГруппа
			
			#region создание System.Guid ИдентификаторРодителя
			{  
                NsgDataGuid ИдентификаторРодителя = null;
				if (ObjectList.Contains("ИдентификаторРодителя"))
                    ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                else
                    ИдентификаторРодителя = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторРодителя.IsLoadedFromDll = true;
	ИдентификаторРодителя.StringFormat = "";
	ИдентификаторРодителя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторРодителя.IncludeInPredefined = false;
	ИдентификаторРодителя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторРодителя.Required = false;
	ИдентификаторРодителя.EmptyValue = "";
	ИдентификаторРодителя.NullAllow = false;
	ИдентификаторРодителя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ИдентификаторРодителя.FieldName = "_ParentID";
	ИдентификаторРодителя.SaveInDatabase = true;
	ИдентификаторРодителя.InformMetaDataOnValueChanged = false;
	ИдентификаторРодителя.Visible = true;
	ИдентификаторРодителя.Name = "ИдентификаторРодителя";
	ИдентификаторРодителя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИдентификаторРодителя.Description = "Идентификатор родителя";
	ИдентификаторРодителя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторРодителя.GroupName = "";
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("52bbd376-177f-4cce-a4be-069c8b45c827");
	
				if (!ObjectList.Contains("ИдентификаторРодителя"))
                    ObjectList.Add(ИдентификаторРодителя);
			}
			#endregion //создание System.Guid ИдентификаторРодителя
			
			#region создание System.Byte Уровень
			{  
                NsgDataByte Уровень = null;
				if (ObjectList.Contains("Уровень"))
                    Уровень = ObjectList["Уровень"] as NsgDataByte;
                else
                    Уровень = new NsgDataByte();
	//NsgDataByte
	Уровень.IsLoadedFromDll = true;
	Уровень.DefaultValue = 0M;
	Уровень.MinValue = 0M;
	Уровень.MaxValue = 0M;
	Уровень.UseCalculator = true;
	Уровень.StringFormat = "";
	Уровень.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Уровень.IncludeInPredefined = false;
	Уровень.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Уровень.Required = false;
	Уровень.EmptyValue = "";
	Уровень.NullAllow = false;
	Уровень.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Уровень.FieldName = "_Level";
	Уровень.SaveInDatabase = true;
	Уровень.InformMetaDataOnValueChanged = false;
	Уровень.Visible = true;
	Уровень.Name = "Уровень";
	Уровень.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Уровень.Description = "Уровень";
	Уровень.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Уровень.GroupName = "";
	Уровень.Guid = NsgService.StringToGuid("15518093-11a9-40b1-810a-2ab859962d59");
	
				if (!ObjectList.Contains("Уровень"))
                    ObjectList.Add(Уровень);
			}
			#endregion //создание System.Byte Уровень
			
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
	ПрефиксКода.Guid = NsgService.StringToGuid("a5d1b015-15cf-4a28-8bff-c3c36f99af7b");
	
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
	НомерКода.Guid = NsgService.StringToGuid("624845e2-a30d-4c35-9506-fbb65b18fe92");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String Код
			{  
                NsgDataVirtualObject Код = null;
				if (ObjectList.Contains("Код"))
                    Код = ObjectList["Код"] as NsgDataVirtualObject;
                else
                    Код = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	Код.IsLoadedFromDll = true;
	Код.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	Код.SaveInDatabase = false;
	Код.StringFormat = "";
	Код.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Код.IncludeInPredefined = false;
	Код.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Код.Required = false;
	Код.EmptyValue = "";
	Код.NullAllow = false;
	Код.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Код.FieldName = "_Code";
	Код.InformMetaDataOnValueChanged = false;
	Код.Visible = true;
	Код.Name = "Код";
	Код.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Код.Description = "Код элемента справочника";
	Код.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Код.GroupName = "";
	Код.Guid = NsgService.StringToGuid("ada14a8b-5a77-47e5-87ea-14e5f34df763");
	
				if (!ObjectList.Contains("Код"))
                    ObjectList.Add(Код);
			}
			#endregion //создание System.String Код
			
			#region создание System.String Наименование
			{  
                NsgDataString Наименование = null;
				if (ObjectList.Contains("Наименование"))
                    Наименование = ObjectList["Наименование"] as NsgDataString;
                else
                    Наименование = new NsgDataString();
	//NsgDataString
	Наименование.IsLoadedFromDll = true;
	Наименование.Length = 0;
	Наименование.StringFormat = "";
	Наименование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наименование.IncludeInPredefined = true;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = false;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Наименование.FieldName = "Naimenovanie";
	Наименование.SaveInDatabase = true;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Наименование.Description = "Наименование элемента справочника";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("3bb6aa2d-12bf-4aef-9481-82edf13a9746");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
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
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("28877f31-8fd8-432c-a0fd-8a7cfe8e3c6e");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Мониторинг.РежимыРаботы РежимРаботы
			{  
                NsgDataTypedReference РежимРаботы = null;
				if (ObjectList.Contains("РежимРаботы"))
                    РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                else
                    РежимРаботы = new NsgDataTypedReference();
	//NsgDataTypedReference
	РежимРаботы.IsLoadedFromDll = true;
	РежимРаботы.ReferentGroup = "Мониторинг";
	РежимРаботы.ReferentName = "РежимыРаботы";
	РежимРаботы.SaveInDatabase = true;
	РежимРаботы.OwnerName = "";
	РежимРаботы.AllowEmptyOwner = false;
	РежимРаботы.StringFormat = "";
	РежимРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РежимРаботы.IncludeInPredefined = false;
	РежимРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РежимРаботы.Required = false;
	РежимРаботы.EmptyValue = "";
	РежимРаботы.NullAllow = false;
	РежимРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РежимРаботы.FieldName = "RezhimRaboty";
	РежимРаботы.InformMetaDataOnValueChanged = false;
	РежимРаботы.Visible = true;
	РежимРаботы.Name = "РежимРаботы";
	РежимРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РежимРаботы.Description = "Режим работы";
	РежимРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РежимРаботы.GroupName = "";
	РежимРаботы.Guid = NsgService.StringToGuid("65d92887-9e6a-494c-b67c-af4461b151c9");
	
				if (!ObjectList.Contains("РежимРаботы"))
                    ObjectList.Add(РежимРаботы);
			}
			#endregion //создание Мониторинг.РежимыРаботы РежимРаботы
			
			#region создание System.String Описание
			{  
                NsgDataString Описание = null;
				if (ObjectList.Contains("Описание"))
                    Описание = ObjectList["Описание"] as NsgDataString;
                else
                    Описание = new NsgDataString();
	//NsgDataString
	Описание.IsLoadedFromDll = true;
	Описание.Length = 0;
	Описание.StringFormat = "";
	Описание.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Описание.IncludeInPredefined = false;
	Описание.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Описание.Required = false;
	Описание.EmptyValue = "";
	Описание.NullAllow = false;
	Описание.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Описание.FieldName = "Opisanie";
	Описание.SaveInDatabase = true;
	Описание.InformMetaDataOnValueChanged = false;
	Описание.Visible = true;
	Описание.Name = "Описание";
	Описание.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Описание.Description = "Описание";
	Описание.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Описание.GroupName = "";
	Описание.Guid = NsgService.StringToGuid("c4f7e728-4f8f-4ffc-96c8-e3e69eefd0c7");
	
				if (!ObjectList.Contains("Описание"))
                    ObjectList.Add(Описание);
			}
			#endregion //создание System.String Описание
			
			#region создание System.Boolean ЯвляетсяСтаршимПоОбъекту
			{  
                NsgDataBoolean ЯвляетсяСтаршимПоОбъекту = null;
				if (ObjectList.Contains("ЯвляетсяСтаршимПоОбъекту"))
                    ЯвляетсяСтаршимПоОбъекту = ObjectList["ЯвляетсяСтаршимПоОбъекту"] as NsgDataBoolean;
                else
                    ЯвляетсяСтаршимПоОбъекту = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяСтаршимПоОбъекту.IsLoadedFromDll = true;
	ЯвляетсяСтаршимПоОбъекту.DefaultValue = false;
	ЯвляетсяСтаршимПоОбъекту.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяСтаршимПоОбъекту.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяСтаршимПоОбъекту.StringFormat = "";
	ЯвляетсяСтаршимПоОбъекту.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяСтаршимПоОбъекту.IncludeInPredefined = false;
	ЯвляетсяСтаршимПоОбъекту.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяСтаршимПоОбъекту.Required = false;
	ЯвляетсяСтаршимПоОбъекту.EmptyValue = "";
	ЯвляетсяСтаршимПоОбъекту.NullAllow = false;
	ЯвляетсяСтаршимПоОбъекту.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяСтаршимПоОбъекту.FieldName = "JAvljaetsjaStarsh";
	ЯвляетсяСтаршимПоОбъекту.SaveInDatabase = true;
	ЯвляетсяСтаршимПоОбъекту.InformMetaDataOnValueChanged = false;
	ЯвляетсяСтаршимПоОбъекту.Visible = true;
	ЯвляетсяСтаршимПоОбъекту.Name = "ЯвляетсяСтаршимПоОбъекту";
	ЯвляетсяСтаршимПоОбъекту.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяСтаршимПоОбъекту.Description = "Является старшим по объекту";
	ЯвляетсяСтаршимПоОбъекту.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяСтаршимПоОбъекту.GroupName = "";
	ЯвляетсяСтаршимПоОбъекту.Guid = NsgService.StringToGuid("28951385-fd92-4521-9a8f-16da7f7f3d94");
	
				if (!ObjectList.Contains("ЯвляетсяСтаршимПоОбъекту"))
                    ObjectList.Add(ЯвляетсяСтаршимПоОбъекту);
			}
			#endregion //создание System.Boolean ЯвляетсяСтаршимПоОбъекту
			
			#region создание TechControl.Метаданные.Мониторинг.ДолжностиФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ДолжностиФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("e1db642f-27a0-4f6a-a5ba-b40620941261");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ДолжностиФормаЭлемента ФормаЭлемента
			
			#region создание Мониторинг.ГруппыДолжностей ГруппаДолжностей
			{  
                NsgDataTypedReference ГруппаДолжностей = null;
				if (ObjectList.Contains("ГруппаДолжностей"))
                    ГруппаДолжностей = ObjectList["ГруппаДолжностей"] as NsgDataTypedReference;
                else
                    ГруппаДолжностей = new NsgDataTypedReference();
	//NsgDataTypedReference
	ГруппаДолжностей.IsLoadedFromDll = true;
	ГруппаДолжностей.ReferentGroup = "Мониторинг";
	ГруппаДолжностей.ReferentName = "ГруппыДолжностей";
	ГруппаДолжностей.SaveInDatabase = true;
	ГруппаДолжностей.OwnerName = "";
	ГруппаДолжностей.AllowEmptyOwner = false;
	ГруппаДолжностей.StringFormat = "";
	ГруппаДолжностей.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГруппаДолжностей.IncludeInPredefined = false;
	ГруппаДолжностей.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГруппаДолжностей.Required = false;
	ГруппаДолжностей.EmptyValue = "";
	ГруппаДолжностей.NullAllow = false;
	ГруппаДолжностей.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГруппаДолжностей.FieldName = "GruppaDolzhnosteij";
	ГруппаДолжностей.InformMetaDataOnValueChanged = false;
	ГруппаДолжностей.Visible = true;
	ГруппаДолжностей.Name = "ГруппаДолжностей";
	ГруппаДолжностей.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГруппаДолжностей.Description = "Группа должностей";
	ГруппаДолжностей.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГруппаДолжностей.GroupName = "";
	ГруппаДолжностей.Guid = NsgService.StringToGuid("ebc8eeff-0b42-4390-a66b-51f38714b661");
	
				if (!ObjectList.Contains("ГруппаДолжностей"))
                    ObjectList.Add(ГруппаДолжностей);
			}
			#endregion //создание Мониторинг.ГруппыДолжностей ГруппаДолжностей
			
			#region создание Мониторинг.Роль Роль
			{  
                NsgDataEnumReference Роль = null;
				if (ObjectList.Contains("Роль"))
                    Роль = ObjectList["Роль"] as NsgDataEnumReference;
                else
                    Роль = new NsgDataEnumReference();
	//NsgDataEnumReference
	Роль.IsLoadedFromDll = true;
	Роль.ReferentGroup = "Мониторинг";
	Роль.ReferentName = "Роль";
	Роль.SaveInDatabase = true;
	Роль.OwnerName = "";
	Роль.AllowEmptyOwner = false;
	Роль.StringFormat = "";
	Роль.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Роль.IncludeInPredefined = false;
	Роль.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Роль.Required = false;
	Роль.EmptyValue = "";
	Роль.NullAllow = false;
	Роль.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Роль.FieldName = "Rol";
	Роль.InformMetaDataOnValueChanged = false;
	Роль.Visible = true;
	Роль.Name = "Роль";
	Роль.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Роль.Description = "Роль";
	Роль.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Роль.GroupName = "";
	Роль.Guid = NsgService.StringToGuid("9b661eef-ebef-4974-b063-ddd4249dff6d");
	
				if (!ObjectList.Contains("Роль"))
                    ObjectList.Add(Роль);
			}
			#endregion //создание Мониторинг.Роль Роль
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("527c98af-df29-4b02-bd68-c1c887067f32");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание _SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды ТаблицаКомплектовСпецодежды
			{  
                NsgDataTableReference ТаблицаКомплектовСпецодежды = null;
				if (ObjectList.Contains("ТаблицаКомплектовСпецодежды"))
                    ТаблицаКомплектовСпецодежды = ObjectList["ТаблицаКомплектовСпецодежды"] as NsgDataTableReference;
                else
                    ТаблицаКомплектовСпецодежды = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаКомплектовСпецодежды.IsLoadedFromDll = true;
	ТаблицаКомплектовСпецодежды.Name = "ТаблицаКомплектовСпецодежды";
	ТаблицаКомплектовСпецодежды.SaveInDatabase = false;
	ТаблицаКомплектовСпецодежды.ReferentGroup = "_SystemTables";
	ТаблицаКомплектовСпецодежды.ReferentName = "МониторингДолжностиТаблицаКомплектовСпецодежды";
	ТаблицаКомплектовСпецодежды.OwnerName = "";
	ТаблицаКомплектовСпецодежды.AllowEmptyOwner = false;
	ТаблицаКомплектовСпецодежды.StringFormat = "";
	ТаблицаКомплектовСпецодежды.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаКомплектовСпецодежды.IncludeInPredefined = false;
	ТаблицаКомплектовСпецодежды.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаКомплектовСпецодежды.Required = false;
	ТаблицаКомплектовСпецодежды.EmptyValue = "";
	ТаблицаКомплектовСпецодежды.NullAllow = false;
	ТаблицаКомплектовСпецодежды.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаКомплектовСпецодежды.FieldName = "TablicaKomplektov";
	ТаблицаКомплектовСпецодежды.InformMetaDataOnValueChanged = false;
	ТаблицаКомплектовСпецодежды.Visible = true;
	ТаблицаКомплектовСпецодежды.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаКомплектовСпецодежды.Description = "Таблица комплектов спецодежды";
	ТаблицаКомплектовСпецодежды.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаКомплектовСпецодежды.GroupName = "";
	ТаблицаКомплектовСпецодежды.Guid = NsgService.StringToGuid("59e463b9-7393-4fdd-b72d-f4bd6768b663");
	
				if (!ObjectList.Contains("ТаблицаКомплектовСпецодежды"))
                    ObjectList.Add(ТаблицаКомплектовСпецодежды);
			}
			#endregion //создание _SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды ТаблицаКомплектовСпецодежды
			
			#region создание System.String ЗагрузочныйИдентификатор
			{  
                NsgDataString ЗагрузочныйИдентификатор = null;
				if (ObjectList.Contains("ЗагрузочныйИдентификатор"))
                    ЗагрузочныйИдентификатор = ObjectList["ЗагрузочныйИдентификатор"] as NsgDataString;
                else
                    ЗагрузочныйИдентификатор = new NsgDataString();
	//NsgDataString
	ЗагрузочныйИдентификатор.IsLoadedFromDll = true;
	ЗагрузочныйИдентификатор.Length = 50;
	ЗагрузочныйИдентификатор.StringFormat = "";
	ЗагрузочныйИдентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЗагрузочныйИдентификатор.IncludeInPredefined = false;
	ЗагрузочныйИдентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЗагрузочныйИдентификатор.Required = false;
	ЗагрузочныйИдентификатор.EmptyValue = "";
	ЗагрузочныйИдентификатор.NullAllow = false;
	ЗагрузочныйИдентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЗагрузочныйИдентификатор.FieldName = "ZagruzochnyijIden";
	ЗагрузочныйИдентификатор.SaveInDatabase = true;
	ЗагрузочныйИдентификатор.InformMetaDataOnValueChanged = false;
	ЗагрузочныйИдентификатор.Visible = true;
	ЗагрузочныйИдентификатор.Name = "ЗагрузочныйИдентификатор";
	ЗагрузочныйИдентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗагрузочныйИдентификатор.Description = "Загрузочный идентификатор";
	ЗагрузочныйИдентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЗагрузочныйИдентификатор.GroupName = "";
	ЗагрузочныйИдентификатор.Guid = NsgService.StringToGuid("2fe7bdf3-9f41-416f-9720-ab4d24f02efb");
	
				if (!ObjectList.Contains("ЗагрузочныйИдентификатор"))
                    ObjectList.Add(ЗагрузочныйИдентификатор);
			}
			#endregion //создание System.String ЗагрузочныйИдентификатор
			
			#region создание _SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры ТаблицаНеобязательнойНоменклатуры
			{  
                NsgDataTableReference ТаблицаНеобязательнойНоменклатуры = null;
				if (ObjectList.Contains("ТаблицаНеобязательнойНоменклатуры"))
                    ТаблицаНеобязательнойНоменклатуры = ObjectList["ТаблицаНеобязательнойНоменклатуры"] as NsgDataTableReference;
                else
                    ТаблицаНеобязательнойНоменклатуры = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаНеобязательнойНоменклатуры.IsLoadedFromDll = true;
	ТаблицаНеобязательнойНоменклатуры.Name = "ТаблицаНеобязательнойНоменклатуры";
	ТаблицаНеобязательнойНоменклатуры.SaveInDatabase = false;
	ТаблицаНеобязательнойНоменклатуры.ReferentGroup = "_SystemTables";
	ТаблицаНеобязательнойНоменклатуры.ReferentName = "МониторингДолжностиТаблицаНеобязательнойНоменклатуры";
	ТаблицаНеобязательнойНоменклатуры.OwnerName = "";
	ТаблицаНеобязательнойНоменклатуры.AllowEmptyOwner = false;
	ТаблицаНеобязательнойНоменклатуры.StringFormat = "";
	ТаблицаНеобязательнойНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаНеобязательнойНоменклатуры.IncludeInPredefined = false;
	ТаблицаНеобязательнойНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаНеобязательнойНоменклатуры.Required = false;
	ТаблицаНеобязательнойНоменклатуры.EmptyValue = "";
	ТаблицаНеобязательнойНоменклатуры.NullAllow = false;
	ТаблицаНеобязательнойНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаНеобязательнойНоменклатуры.FieldName = "TablicaNeobjazate";
	ТаблицаНеобязательнойНоменклатуры.InformMetaDataOnValueChanged = false;
	ТаблицаНеобязательнойНоменклатуры.Visible = true;
	ТаблицаНеобязательнойНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаНеобязательнойНоменклатуры.Description = "Таблица необязательной номенклатуры";
	ТаблицаНеобязательнойНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаНеобязательнойНоменклатуры.GroupName = "";
	ТаблицаНеобязательнойНоменклатуры.Guid = NsgService.StringToGuid("6e698c69-4624-4e1f-87c8-4db0042cf5ab");
	
				if (!ObjectList.Contains("ТаблицаНеобязательнойНоменклатуры"))
                    ObjectList.Add(ТаблицаНеобязательнойНоменклатуры);
			}
			#endregion //создание _SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры ТаблицаНеобязательнойНоменклатуры
			
			#region создание System.String НаименованиеРодительныйПадеж
			{  
                NsgDataString НаименованиеРодительныйПадеж = null;
				if (ObjectList.Contains("НаименованиеРодительныйПадеж"))
                    НаименованиеРодительныйПадеж = ObjectList["НаименованиеРодительныйПадеж"] as NsgDataString;
                else
                    НаименованиеРодительныйПадеж = new NsgDataString();
	//NsgDataString
	НаименованиеРодительныйПадеж.IsLoadedFromDll = true;
	НаименованиеРодительныйПадеж.Length = 0;
	НаименованиеРодительныйПадеж.StringFormat = "";
	НаименованиеРодительныйПадеж.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НаименованиеРодительныйПадеж.IncludeInPredefined = false;
	НаименованиеРодительныйПадеж.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НаименованиеРодительныйПадеж.Required = false;
	НаименованиеРодительныйПадеж.EmptyValue = "";
	НаименованиеРодительныйПадеж.NullAllow = false;
	НаименованиеРодительныйПадеж.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НаименованиеРодительныйПадеж.FieldName = "NaimenovanieRodit";
	НаименованиеРодительныйПадеж.SaveInDatabase = true;
	НаименованиеРодительныйПадеж.InformMetaDataOnValueChanged = false;
	НаименованиеРодительныйПадеж.Visible = true;
	НаименованиеРодительныйПадеж.Name = "НаименованиеРодительныйПадеж";
	НаименованиеРодительныйПадеж.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НаименованиеРодительныйПадеж.Description = "Наименование родительный падеж";
	НаименованиеРодительныйПадеж.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НаименованиеРодительныйПадеж.GroupName = "";
	НаименованиеРодительныйПадеж.Guid = NsgService.StringToGuid("a322e172-a06f-469d-a9ed-ddcef2f9fac6");
	
				if (!ObjectList.Contains("НаименованиеРодительныйПадеж"))
                    ObjectList.Add(НаименованиеРодительныйПадеж);
			}
			#endregion //создание System.String НаименованиеРодительныйПадеж
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Должности";
	Visible = true;
	Guid = NsgService.StringToGuid("b2e03c9f-8023-41b8-a72c-9480fb619b20");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Dolzhnosti";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Должности";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDictionary

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDictionary.Names
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
            /// Это группа
            /// </summary>
            public static String ЭтоГруппа
            {
                get
                {
                    return "ЭтоГруппа";
                }
            }
            
            /// <summary>
            /// Идентификатор родителя
            /// </summary>
            public static String ИдентификаторРодителя
            {
                get
                {
                    return "ИдентификаторРодителя";
                }
            }
            
            /// <summary>
            /// Уровень
            /// </summary>
            public static String Уровень
            {
                get
                {
                    return "Уровень";
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
            /// Код элемента справочника
            /// </summary>
            public static String Код
            {
                get
                {
                    return "Код";
                }
            }
            
            /// <summary>
            /// Наименование элемента справочника
            /// </summary>
            public static String Наименование
            {
                get
                {
                    return "Наименование";
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
            /// Режим работы
            /// </summary>
            public static String РежимРаботы
            {
                get
                {
                    return "РежимРаботы";
                }
            }
            
            /// <summary>
            /// Описание
            /// </summary>
            public static String Описание
            {
                get
                {
                    return "Описание";
                }
            }
            
            /// <summary>
            /// Является старшим по объекту
            /// </summary>
            public static String ЯвляетсяСтаршимПоОбъекту
            {
                get
                {
                    return "ЯвляетсяСтаршимПоОбъекту";
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
            /// Группа должностей
            /// </summary>
            public static String ГруппаДолжностей
            {
                get
                {
                    return "ГруппаДолжностей";
                }
            }
            
            /// <summary>
            /// Роль
            /// </summary>
            public static String Роль
            {
                get
                {
                    return "Роль";
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
            /// Таблица комплектов спецодежды
            /// </summary>
            public static String ТаблицаКомплектовСпецодежды
            {
                get
                {
                    return "ТаблицаКомплектовСпецодежды";
                }
            }
            
            /// <summary>
            /// Загрузочный идентификатор
            /// </summary>
            public static String ЗагрузочныйИдентификатор
            {
                get
                {
                    return "ЗагрузочныйИдентификатор";
                }
            }
            
            /// <summary>
            /// Таблица необязательной номенклатуры
            /// </summary>
            public static String ТаблицаНеобязательнойНоменклатуры
            {
                get
                {
                    return "ТаблицаНеобязательнойНоменклатуры";
                }
            }
            
            /// <summary>
            /// Наименование родительный падеж
            /// </summary>
            public static String НаименованиеРодительныйПадеж
            {
                get
                {
                    return "НаименованиеРодительныйПадеж";
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
                    descriptor.Name = "Должности";
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
            return "Мониторинг.Должности";
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
        /// Это группа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЭтоГруппа
        {
            get
            {
				 NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                 return (System.Boolean)__ЭтоГруппа.Value;
            }
            set
            {
                NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                __ЭтоГруппа.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор родителя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторРодителя
        {
            get
            {
				 NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторРодителя.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                __ИдентификаторРодителя.Value = value;
            }
        }
        
        /// <summary>
        /// Уровень
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataByte")]
        
        public System.Byte Уровень
        {
            get
            {
				 NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                 return (System.Byte)__Уровень.Value;
            }
            set
            {
                NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                __Уровень.Value = value;
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
        /// Код элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String Код
        {
            get
            {
				 NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                 return (System.String)__Код.Value;
            }
            set
            {
                NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                __Код.Value = value;
            }
        }
        
        /// <summary>
        /// Наименование элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Наименование
        {
            get
            {
				 NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                 return (System.String)__Наименование.Value;
            }
            set
            {
                NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                __Наименование.Value = value;
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
        /// Режим работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.РежимыРаботы РежимРаботы
        {
            get
            {
				 NsgDataTypedReference __РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                 return (Мониторинг.РежимыРаботы)__РежимРаботы.Referent;
            }
            set
            {
                NsgDataTypedReference __РежимРаботы = ObjectList["РежимРаботы"] as NsgDataTypedReference;
                __РежимРаботы.Referent = value;
            }
        }
        
        /// <summary>
        /// Описание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Описание
        {
            get
            {
				 NsgDataString __Описание = ObjectList["Описание"] as NsgDataString;
                 return (System.String)__Описание.Value;
            }
            set
            {
                NsgDataString __Описание = ObjectList["Описание"] as NsgDataString;
                __Описание.Value = value;
            }
        }
        
        /// <summary>
        /// Является старшим по объекту
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяСтаршимПоОбъекту
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяСтаршимПоОбъекту = ObjectList["ЯвляетсяСтаршимПоОбъекту"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяСтаршимПоОбъекту.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяСтаршимПоОбъекту = ObjectList["ЯвляетсяСтаршимПоОбъекту"] as NsgDataBoolean;
                __ЯвляетсяСтаршимПоОбъекту.Value = value;
            }
        }
        
        /// <summary>
        /// Группа должностей
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ГруппыДолжностей ГруппаДолжностей
        {
            get
            {
				 NsgDataTypedReference __ГруппаДолжностей = ObjectList["ГруппаДолжностей"] as NsgDataTypedReference;
                 return (Мониторинг.ГруппыДолжностей)__ГруппаДолжностей.Referent;
            }
            set
            {
                NsgDataTypedReference __ГруппаДолжностей = ObjectList["ГруппаДолжностей"] as NsgDataTypedReference;
                __ГруппаДолжностей.Referent = value;
            }
        }
        
        /// <summary>
        /// Роль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.Роль Роль
        {
            get
            {
				 NsgDataEnumReference __Роль = ObjectList["Роль"] as NsgDataEnumReference;
                 return (Мониторинг.Роль)__Роль.Referent;
            }
            set
            {
                NsgDataEnumReference __Роль = ObjectList["Роль"] as NsgDataEnumReference;
                __Роль.Referent = value;
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
        /// Таблица комплектов спецодежды
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды ТаблицаКомплектовСпецодежды
        {
            get
            {
				 NsgDataTableReference __ТаблицаКомплектовСпецодежды = ObjectList["ТаблицаКомплектовСпецодежды"] as NsgDataTableReference;
                 return (_SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды)__ТаблицаКомплектовСпецодежды.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаКомплектовСпецодежды = ObjectList["ТаблицаКомплектовСпецодежды"] as NsgDataTableReference;
                __ТаблицаКомплектовСпецодежды.Referent = value;
            }
        }
        
        /// <summary>
        /// Загрузочный идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ЗагрузочныйИдентификатор
        {
            get
            {
				 NsgDataString __ЗагрузочныйИдентификатор = ObjectList["ЗагрузочныйИдентификатор"] as NsgDataString;
                 return (System.String)__ЗагрузочныйИдентификатор.Value;
            }
            set
            {
                NsgDataString __ЗагрузочныйИдентификатор = ObjectList["ЗагрузочныйИдентификатор"] as NsgDataString;
                __ЗагрузочныйИдентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица необязательной номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры ТаблицаНеобязательнойНоменклатуры
        {
            get
            {
				 NsgDataTableReference __ТаблицаНеобязательнойНоменклатуры = ObjectList["ТаблицаНеобязательнойНоменклатуры"] as NsgDataTableReference;
                 return (_SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры)__ТаблицаНеобязательнойНоменклатуры.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаНеобязательнойНоменклатуры = ObjectList["ТаблицаНеобязательнойНоменклатуры"] as NsgDataTableReference;
                __ТаблицаНеобязательнойНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Наименование родительный падеж
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String НаименованиеРодительныйПадеж
        {
            get
            {
				 NsgDataString __НаименованиеРодительныйПадеж = ObjectList["НаименованиеРодительныйПадеж"] as NsgDataString;
                 return (System.String)__НаименованиеРодительныйПадеж.Value;
            }
            set
            {
                NsgDataString __НаименованиеРодительныйПадеж = ObjectList["НаименованиеРодительныйПадеж"] as NsgDataString;
                __НаименованиеРодительныйПадеж.Value = value;
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
        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public Должности Родитель
        {
            get
            {
                return base.Parent as Должности;
            }
            set
            {
                base.Parent = value;
            }
        }
        #region #Comment_Predefined#
        
        #endregion //#Comment_Predefined#
		

        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDictionary

        #region Методы NsgMultipleObject
        private Должности[] convertArray(NsgMultipleObject[] array)
        {
            Должности[] res = new Должности[array.Length];
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
        public new virtual Должности[] FindAll(NsgCompare compare)
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
        public new virtual Должности[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Должности[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Должности[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Должности(this as NsgObject);
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
                base.NSGType = typeof(Должности);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Должности Value
            {
                get
                {
                    return (Должности)base.Value;
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
                    return "s_NsgDataDictionary";
                }
            }
        }

    }

}
