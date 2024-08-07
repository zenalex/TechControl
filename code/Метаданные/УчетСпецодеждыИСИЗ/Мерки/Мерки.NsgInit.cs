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

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    [NsgTypeName("NsgDataDictionary", Guid = "cb0104be-0190-4741-a696-48e93842ad71")]
    public partial class Мерки : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Мерки()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Мерки(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Мерки Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("cb0104be-0190-4741-a696-48e93842ad71"));
            if (obj == null)
                obj = new Мерки();
            return obj as Мерки;
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
	Владелец.FilterForConfigurator = "Мониторинг.ФизЛица";
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
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Владелец"});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("263c9b0d-c3be-4b0b-964b-a79c79bf67f7");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	Идентификатор.Guid = NsgService.StringToGuid("6e390d5d-e396-4311-9f56-fcb58f475311");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("b52347af-b4b8-43d5-b899-17ef532469cc");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("d17fc804-9302-4d1f-8fc8-193770e08f22");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("c83ced09-1ecb-4b67-b8ce-cdaadecd523e");
	
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
	Уровень.Guid = NsgService.StringToGuid("21362d22-6e71-496d-aa16-f950b4735fcb");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("5f41600c-6327-4b7d-8fe4-a242db6234ab");
	
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
	НомерКода.Guid = NsgService.StringToGuid("151f64b4-b99a-4118-a5af-a2994f56636e");
	
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
	Код.Guid = NsgService.StringToGuid("8b6ccda6-6b66-411e-adef-48d6636dab91");
	
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
	Наименование.Length = 50;
	Наименование.StringFormat = "";
	Наименование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наименование.IncludeInPredefined = true;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = false;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
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
	Наименование.Guid = NsgService.StringToGuid("f70388ff-d5f0-438d-bb64-6e4edc06d058");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("5cd2cafb-891a-4e67-9e81-d21f0bd011ed");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание System.Decimal ОбхватТалии
			{  
                NsgDataFloat ОбхватТалии = null;
				if (ObjectList.Contains("ОбхватТалии"))
                    ОбхватТалии = ObjectList["ОбхватТалии"] as NsgDataFloat;
                else
                    ОбхватТалии = new NsgDataFloat();
	//NsgDataFloat
	ОбхватТалии.IsLoadedFromDll = true;
	ОбхватТалии.Precision = 2;
	ОбхватТалии.HideZero = true;
	ОбхватТалии.DefaultValue = 0M;
	ОбхватТалии.MinValue = -100000000000000000M;
	ОбхватТалии.MaxValue = 100000000000000000M;
	ОбхватТалии.UseCalculator = true;
	ОбхватТалии.StringFormat = "";
	ОбхватТалии.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватТалии.IncludeInPredefined = false;
	ОбхватТалии.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватТалии.Required = false;
	ОбхватТалии.EmptyValue = "";
	ОбхватТалии.NullAllow = false;
	ОбхватТалии.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватТалии.FieldName = "ObkhvatTalii";
	ОбхватТалии.SaveInDatabase = true;
	ОбхватТалии.InformMetaDataOnValueChanged = false;
	ОбхватТалии.Visible = true;
	ОбхватТалии.Name = "ОбхватТалии";
	ОбхватТалии.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватТалии.Description = "Обхват талии";
	ОбхватТалии.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватТалии.GroupName = "";
	ОбхватТалии.Guid = NsgService.StringToGuid("302c0031-e0f7-4f8e-b2bd-7859f2550dd0");
	
				if (!ObjectList.Contains("ОбхватТалии"))
                    ObjectList.Add(ОбхватТалии);
			}
			#endregion //создание System.Decimal ОбхватТалии
			
			#region создание System.Decimal Рост
			{  
                NsgDataFloat Рост = null;
				if (ObjectList.Contains("Рост"))
                    Рост = ObjectList["Рост"] as NsgDataFloat;
                else
                    Рост = new NsgDataFloat();
	//NsgDataFloat
	Рост.IsLoadedFromDll = true;
	Рост.Precision = 2;
	Рост.HideZero = true;
	Рост.DefaultValue = 0M;
	Рост.MinValue = -100000000000000000M;
	Рост.MaxValue = 100000000000000000M;
	Рост.UseCalculator = true;
	Рост.StringFormat = "";
	Рост.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Рост.IncludeInPredefined = false;
	Рост.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Рост.Required = false;
	Рост.EmptyValue = "";
	Рост.NullAllow = false;
	Рост.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Рост.FieldName = "Rost";
	Рост.SaveInDatabase = true;
	Рост.InformMetaDataOnValueChanged = false;
	Рост.Visible = true;
	Рост.Name = "Рост";
	Рост.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Рост.Description = "Рост";
	Рост.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Рост.GroupName = "";
	Рост.Guid = NsgService.StringToGuid("4d4e75d0-ac2d-4ae6-9294-45f9b7efe071");
	
				if (!ObjectList.Contains("Рост"))
                    ObjectList.Add(Рост);
			}
			#endregion //создание System.Decimal Рост
			
			#region создание System.Decimal ОбхватБедер
			{  
                NsgDataFloat ОбхватБедер = null;
				if (ObjectList.Contains("ОбхватБедер"))
                    ОбхватБедер = ObjectList["ОбхватБедер"] as NsgDataFloat;
                else
                    ОбхватБедер = new NsgDataFloat();
	//NsgDataFloat
	ОбхватБедер.IsLoadedFromDll = true;
	ОбхватБедер.Precision = 2;
	ОбхватБедер.HideZero = true;
	ОбхватБедер.DefaultValue = 0M;
	ОбхватБедер.MinValue = -100000000000000000M;
	ОбхватБедер.MaxValue = 100000000000000000M;
	ОбхватБедер.UseCalculator = true;
	ОбхватБедер.StringFormat = "";
	ОбхватБедер.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватБедер.IncludeInPredefined = false;
	ОбхватБедер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватБедер.Required = false;
	ОбхватБедер.EmptyValue = "";
	ОбхватБедер.NullAllow = false;
	ОбхватБедер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватБедер.FieldName = "ObkhvatBeder";
	ОбхватБедер.SaveInDatabase = true;
	ОбхватБедер.InformMetaDataOnValueChanged = false;
	ОбхватБедер.Visible = true;
	ОбхватБедер.Name = "ОбхватБедер";
	ОбхватБедер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватБедер.Description = "Обхват бедер";
	ОбхватБедер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватБедер.GroupName = "";
	ОбхватБедер.Guid = NsgService.StringToGuid("45f31a3a-068f-47c9-843b-a33e2d62b5a8");
	
				if (!ObjectList.Contains("ОбхватБедер"))
                    ObjectList.Add(ОбхватБедер);
			}
			#endregion //создание System.Decimal ОбхватБедер
			
			#region создание System.Decimal БоковаяДлинаБрюк
			{  
                NsgDataFloat БоковаяДлинаБрюк = null;
				if (ObjectList.Contains("БоковаяДлинаБрюк"))
                    БоковаяДлинаБрюк = ObjectList["БоковаяДлинаБрюк"] as NsgDataFloat;
                else
                    БоковаяДлинаБрюк = new NsgDataFloat();
	//NsgDataFloat
	БоковаяДлинаБрюк.IsLoadedFromDll = true;
	БоковаяДлинаБрюк.Precision = 2;
	БоковаяДлинаБрюк.HideZero = true;
	БоковаяДлинаБрюк.DefaultValue = 0M;
	БоковаяДлинаБрюк.MinValue = -100000000000000000M;
	БоковаяДлинаБрюк.MaxValue = 100000000000000000M;
	БоковаяДлинаБрюк.UseCalculator = true;
	БоковаяДлинаБрюк.StringFormat = "";
	БоковаяДлинаБрюк.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	БоковаяДлинаБрюк.IncludeInPredefined = false;
	БоковаяДлинаБрюк.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	БоковаяДлинаБрюк.Required = false;
	БоковаяДлинаБрюк.EmptyValue = "";
	БоковаяДлинаБрюк.NullAllow = false;
	БоковаяДлинаБрюк.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	БоковаяДлинаБрюк.FieldName = "BokovajaDlinaBrjuk";
	БоковаяДлинаБрюк.SaveInDatabase = true;
	БоковаяДлинаБрюк.InformMetaDataOnValueChanged = false;
	БоковаяДлинаБрюк.Visible = true;
	БоковаяДлинаБрюк.Name = "БоковаяДлинаБрюк";
	БоковаяДлинаБрюк.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	БоковаяДлинаБрюк.Description = "Боковая длина брюк";
	БоковаяДлинаБрюк.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	БоковаяДлинаБрюк.GroupName = "";
	БоковаяДлинаБрюк.Guid = NsgService.StringToGuid("2ca67878-79a7-4f46-a308-5c0dd2b6c93c");
	
				if (!ObjectList.Contains("БоковаяДлинаБрюк"))
                    ObjectList.Add(БоковаяДлинаБрюк);
			}
			#endregion //создание System.Decimal БоковаяДлинаБрюк
			
			#region создание System.Decimal ДлинаБрюкПоВнутреннемуШву
			{  
                NsgDataFloat ДлинаБрюкПоВнутреннемуШву = null;
				if (ObjectList.Contains("ДлинаБрюкПоВнутреннемуШву"))
                    ДлинаБрюкПоВнутреннемуШву = ObjectList["ДлинаБрюкПоВнутреннемуШву"] as NsgDataFloat;
                else
                    ДлинаБрюкПоВнутреннемуШву = new NsgDataFloat();
	//NsgDataFloat
	ДлинаБрюкПоВнутреннемуШву.IsLoadedFromDll = true;
	ДлинаБрюкПоВнутреннемуШву.Precision = 2;
	ДлинаБрюкПоВнутреннемуШву.HideZero = true;
	ДлинаБрюкПоВнутреннемуШву.DefaultValue = 0M;
	ДлинаБрюкПоВнутреннемуШву.MinValue = -100000000000000000M;
	ДлинаБрюкПоВнутреннемуШву.MaxValue = 100000000000000000M;
	ДлинаБрюкПоВнутреннемуШву.UseCalculator = true;
	ДлинаБрюкПоВнутреннемуШву.StringFormat = "";
	ДлинаБрюкПоВнутреннемуШву.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаБрюкПоВнутреннемуШву.IncludeInPredefined = false;
	ДлинаБрюкПоВнутреннемуШву.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаБрюкПоВнутреннемуШву.Required = false;
	ДлинаБрюкПоВнутреннемуШву.EmptyValue = "";
	ДлинаБрюкПоВнутреннемуШву.NullAllow = false;
	ДлинаБрюкПоВнутреннемуШву.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаБрюкПоВнутреннемуШву.FieldName = "DlinaBrjukPoVnutr";
	ДлинаБрюкПоВнутреннемуШву.SaveInDatabase = true;
	ДлинаБрюкПоВнутреннемуШву.InformMetaDataOnValueChanged = false;
	ДлинаБрюкПоВнутреннемуШву.Visible = true;
	ДлинаБрюкПоВнутреннемуШву.Name = "ДлинаБрюкПоВнутреннемуШву";
	ДлинаБрюкПоВнутреннемуШву.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаБрюкПоВнутреннемуШву.Description = "Длина брюк по внутреннему шву";
	ДлинаБрюкПоВнутреннемуШву.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаБрюкПоВнутреннемуШву.GroupName = "";
	ДлинаБрюкПоВнутреннемуШву.Guid = NsgService.StringToGuid("e82a29b9-2d2d-43b5-be77-b2559b5684e7");
	
				if (!ObjectList.Contains("ДлинаБрюкПоВнутреннемуШву"))
                    ObjectList.Add(ДлинаБрюкПоВнутреннемуШву);
			}
			#endregion //создание System.Decimal ДлинаБрюкПоВнутреннемуШву
			
			#region создание System.Decimal ОбхватШеи
			{  
                NsgDataFloat ОбхватШеи = null;
				if (ObjectList.Contains("ОбхватШеи"))
                    ОбхватШеи = ObjectList["ОбхватШеи"] as NsgDataFloat;
                else
                    ОбхватШеи = new NsgDataFloat();
	//NsgDataFloat
	ОбхватШеи.IsLoadedFromDll = true;
	ОбхватШеи.Precision = 2;
	ОбхватШеи.HideZero = true;
	ОбхватШеи.DefaultValue = 0M;
	ОбхватШеи.MinValue = -100000000000000000M;
	ОбхватШеи.MaxValue = 100000000000000000M;
	ОбхватШеи.UseCalculator = true;
	ОбхватШеи.StringFormat = "";
	ОбхватШеи.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватШеи.IncludeInPredefined = false;
	ОбхватШеи.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватШеи.Required = false;
	ОбхватШеи.EmptyValue = "";
	ОбхватШеи.NullAllow = false;
	ОбхватШеи.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватШеи.FieldName = "ObkhvatSHei";
	ОбхватШеи.SaveInDatabase = true;
	ОбхватШеи.InformMetaDataOnValueChanged = false;
	ОбхватШеи.Visible = true;
	ОбхватШеи.Name = "ОбхватШеи";
	ОбхватШеи.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватШеи.Description = "Обхват шеи";
	ОбхватШеи.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватШеи.GroupName = "";
	ОбхватШеи.Guid = NsgService.StringToGuid("8c527d53-9f7c-4897-9a21-f6cae50fe6b1");
	
				if (!ObjectList.Contains("ОбхватШеи"))
                    ObjectList.Add(ОбхватШеи);
			}
			#endregion //создание System.Decimal ОбхватШеи
			
			#region создание System.Decimal ДлинаРукава
			{  
                NsgDataFloat ДлинаРукава = null;
				if (ObjectList.Contains("ДлинаРукава"))
                    ДлинаРукава = ObjectList["ДлинаРукава"] as NsgDataFloat;
                else
                    ДлинаРукава = new NsgDataFloat();
	//NsgDataFloat
	ДлинаРукава.IsLoadedFromDll = true;
	ДлинаРукава.Precision = 2;
	ДлинаРукава.HideZero = true;
	ДлинаРукава.DefaultValue = 0M;
	ДлинаРукава.MinValue = -100000000000000000M;
	ДлинаРукава.MaxValue = 100000000000000000M;
	ДлинаРукава.UseCalculator = true;
	ДлинаРукава.StringFormat = "";
	ДлинаРукава.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаРукава.IncludeInPredefined = false;
	ДлинаРукава.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаРукава.Required = false;
	ДлинаРукава.EmptyValue = "";
	ДлинаРукава.NullAllow = false;
	ДлинаРукава.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаРукава.FieldName = "DlinaRukava";
	ДлинаРукава.SaveInDatabase = true;
	ДлинаРукава.InformMetaDataOnValueChanged = false;
	ДлинаРукава.Visible = true;
	ДлинаРукава.Name = "ДлинаРукава";
	ДлинаРукава.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаРукава.Description = "Длина рукава";
	ДлинаРукава.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаРукава.GroupName = "";
	ДлинаРукава.Guid = NsgService.StringToGuid("6acabfc6-685c-4e6c-850c-cd8d797de853");
	
				if (!ObjectList.Contains("ДлинаРукава"))
                    ObjectList.Add(ДлинаРукава);
			}
			#endregion //создание System.Decimal ДлинаРукава
			
			#region создание System.Decimal ДлинаСтопы
			{  
                NsgDataFloat ДлинаСтопы = null;
				if (ObjectList.Contains("ДлинаСтопы"))
                    ДлинаСтопы = ObjectList["ДлинаСтопы"] as NsgDataFloat;
                else
                    ДлинаСтопы = new NsgDataFloat();
	//NsgDataFloat
	ДлинаСтопы.IsLoadedFromDll = true;
	ДлинаСтопы.Precision = 2;
	ДлинаСтопы.HideZero = true;
	ДлинаСтопы.DefaultValue = 0M;
	ДлинаСтопы.MinValue = -100000000000000000M;
	ДлинаСтопы.MaxValue = 100000000000000000M;
	ДлинаСтопы.UseCalculator = true;
	ДлинаСтопы.StringFormat = "";
	ДлинаСтопы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаСтопы.IncludeInPredefined = false;
	ДлинаСтопы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаСтопы.Required = false;
	ДлинаСтопы.EmptyValue = "";
	ДлинаСтопы.NullAllow = false;
	ДлинаСтопы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаСтопы.FieldName = "DlinaStopy";
	ДлинаСтопы.SaveInDatabase = true;
	ДлинаСтопы.InformMetaDataOnValueChanged = false;
	ДлинаСтопы.Visible = true;
	ДлинаСтопы.Name = "ДлинаСтопы";
	ДлинаСтопы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаСтопы.Description = "Длина стопы";
	ДлинаСтопы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаСтопы.GroupName = "";
	ДлинаСтопы.Guid = NsgService.StringToGuid("45304e91-ba3e-4de6-9b52-bdd0499de09c");
	
				if (!ObjectList.Contains("ДлинаСтопы"))
                    ObjectList.Add(ДлинаСтопы);
			}
			#endregion //создание System.Decimal ДлинаСтопы
			
			#region создание System.Decimal ОбхватГруди
			{  
                NsgDataFloat ОбхватГруди = null;
				if (ObjectList.Contains("ОбхватГруди"))
                    ОбхватГруди = ObjectList["ОбхватГруди"] as NsgDataFloat;
                else
                    ОбхватГруди = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГруди.IsLoadedFromDll = true;
	ОбхватГруди.Precision = 2;
	ОбхватГруди.HideZero = true;
	ОбхватГруди.DefaultValue = 0M;
	ОбхватГруди.MinValue = -100000000000000000M;
	ОбхватГруди.MaxValue = 100000000000000000M;
	ОбхватГруди.UseCalculator = true;
	ОбхватГруди.StringFormat = "";
	ОбхватГруди.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГруди.IncludeInPredefined = false;
	ОбхватГруди.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГруди.Required = false;
	ОбхватГруди.EmptyValue = "";
	ОбхватГруди.NullAllow = false;
	ОбхватГруди.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГруди.FieldName = "ObkhvatGrudi";
	ОбхватГруди.SaveInDatabase = true;
	ОбхватГруди.InformMetaDataOnValueChanged = false;
	ОбхватГруди.Visible = true;
	ОбхватГруди.Name = "ОбхватГруди";
	ОбхватГруди.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГруди.Description = "Обхват груди";
	ОбхватГруди.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГруди.GroupName = "";
	ОбхватГруди.Guid = NsgService.StringToGuid("f9db978a-137c-4b8e-81b5-4327acb82f81");
	
				if (!ObjectList.Contains("ОбхватГруди"))
                    ObjectList.Add(ОбхватГруди);
			}
			#endregion //создание System.Decimal ОбхватГруди
			
			#region создание System.Decimal ОбхватГоловы
			{  
                NsgDataFloat ОбхватГоловы = null;
				if (ObjectList.Contains("ОбхватГоловы"))
                    ОбхватГоловы = ObjectList["ОбхватГоловы"] as NsgDataFloat;
                else
                    ОбхватГоловы = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГоловы.IsLoadedFromDll = true;
	ОбхватГоловы.Precision = 2;
	ОбхватГоловы.HideZero = true;
	ОбхватГоловы.DefaultValue = 0M;
	ОбхватГоловы.MinValue = -100000000000000000M;
	ОбхватГоловы.MaxValue = 100000000000000000M;
	ОбхватГоловы.UseCalculator = true;
	ОбхватГоловы.StringFormat = "";
	ОбхватГоловы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГоловы.IncludeInPredefined = false;
	ОбхватГоловы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГоловы.Required = false;
	ОбхватГоловы.EmptyValue = "";
	ОбхватГоловы.NullAllow = false;
	ОбхватГоловы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГоловы.FieldName = "ObkhvatGolovy";
	ОбхватГоловы.SaveInDatabase = true;
	ОбхватГоловы.InformMetaDataOnValueChanged = false;
	ОбхватГоловы.Visible = true;
	ОбхватГоловы.Name = "ОбхватГоловы";
	ОбхватГоловы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГоловы.Description = "Обхват головы";
	ОбхватГоловы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГоловы.GroupName = "";
	ОбхватГоловы.Guid = NsgService.StringToGuid("7b64ac1e-371d-45ba-b225-2ab6abc08ddc");
	
				if (!ObjectList.Contains("ОбхватГоловы"))
                    ObjectList.Add(ОбхватГоловы);
			}
			#endregion //создание System.Decimal ОбхватГоловы
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Мерки";
	Visible = true;
	Guid = NsgService.StringToGuid("cb0104be-0190-4741-a696-48e93842ad71");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Merki";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Справочник";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "УчетСпецодеждыИСИЗ";
	
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
            /// Обхват талии
            /// </summary>
            public static String ОбхватТалии
            {
                get
                {
                    return "ОбхватТалии";
                }
            }
            
            /// <summary>
            /// Рост
            /// </summary>
            public static String Рост
            {
                get
                {
                    return "Рост";
                }
            }
            
            /// <summary>
            /// Обхват бедер
            /// </summary>
            public static String ОбхватБедер
            {
                get
                {
                    return "ОбхватБедер";
                }
            }
            
            /// <summary>
            /// Боковая длина брюк
            /// </summary>
            public static String БоковаяДлинаБрюк
            {
                get
                {
                    return "БоковаяДлинаБрюк";
                }
            }
            
            /// <summary>
            /// Длина брюк по внутреннему шву
            /// </summary>
            public static String ДлинаБрюкПоВнутреннемуШву
            {
                get
                {
                    return "ДлинаБрюкПоВнутреннемуШву";
                }
            }
            
            /// <summary>
            /// Обхват шеи
            /// </summary>
            public static String ОбхватШеи
            {
                get
                {
                    return "ОбхватШеи";
                }
            }
            
            /// <summary>
            /// Длина рукава
            /// </summary>
            public static String ДлинаРукава
            {
                get
                {
                    return "ДлинаРукава";
                }
            }
            
            /// <summary>
            /// Длина стопы
            /// </summary>
            public static String ДлинаСтопы
            {
                get
                {
                    return "ДлинаСтопы";
                }
            }
            
            /// <summary>
            /// Обхват груди
            /// </summary>
            public static String ОбхватГруди
            {
                get
                {
                    return "ОбхватГруди";
                }
            }
            
            /// <summary>
            /// Обхват головы
            /// </summary>
            public static String ОбхватГоловы
            {
                get
                {
                    return "ОбхватГоловы";
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
                    descriptor.Name = "Мерки";
                    descriptor.GroupName = "УчетСпецодеждыИСИЗ";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "УчетСпецодеждыИСИЗ.Мерки";
        }

        
        /// <summary>
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Мониторинг.ФизЛица")]
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
        /// Обхват талии
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватТалии
        {
            get
            {
				 NsgDataFloat __ОбхватТалии = ObjectList["ОбхватТалии"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватТалии.Value;
            }
            set
            {
                NsgDataFloat __ОбхватТалии = ObjectList["ОбхватТалии"] as NsgDataFloat;
                __ОбхватТалии.Value = value;
            }
        }
        
        /// <summary>
        /// Рост
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Рост
        {
            get
            {
				 NsgDataFloat __Рост = ObjectList["Рост"] as NsgDataFloat;
                 return (System.Decimal)__Рост.Value;
            }
            set
            {
                NsgDataFloat __Рост = ObjectList["Рост"] as NsgDataFloat;
                __Рост.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват бедер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватБедер
        {
            get
            {
				 NsgDataFloat __ОбхватБедер = ObjectList["ОбхватБедер"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватБедер.Value;
            }
            set
            {
                NsgDataFloat __ОбхватБедер = ObjectList["ОбхватБедер"] as NsgDataFloat;
                __ОбхватБедер.Value = value;
            }
        }
        
        /// <summary>
        /// Боковая длина брюк
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal БоковаяДлинаБрюк
        {
            get
            {
				 NsgDataFloat __БоковаяДлинаБрюк = ObjectList["БоковаяДлинаБрюк"] as NsgDataFloat;
                 return (System.Decimal)__БоковаяДлинаБрюк.Value;
            }
            set
            {
                NsgDataFloat __БоковаяДлинаБрюк = ObjectList["БоковаяДлинаБрюк"] as NsgDataFloat;
                __БоковаяДлинаБрюк.Value = value;
            }
        }
        
        /// <summary>
        /// Длина брюк по внутреннему шву
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаБрюкПоВнутреннемуШву
        {
            get
            {
				 NsgDataFloat __ДлинаБрюкПоВнутреннемуШву = ObjectList["ДлинаБрюкПоВнутреннемуШву"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаБрюкПоВнутреннемуШву.Value;
            }
            set
            {
                NsgDataFloat __ДлинаБрюкПоВнутреннемуШву = ObjectList["ДлинаБрюкПоВнутреннемуШву"] as NsgDataFloat;
                __ДлинаБрюкПоВнутреннемуШву.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват шеи
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватШеи
        {
            get
            {
				 NsgDataFloat __ОбхватШеи = ObjectList["ОбхватШеи"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватШеи.Value;
            }
            set
            {
                NsgDataFloat __ОбхватШеи = ObjectList["ОбхватШеи"] as NsgDataFloat;
                __ОбхватШеи.Value = value;
            }
        }
        
        /// <summary>
        /// Длина рукава
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаРукава
        {
            get
            {
				 NsgDataFloat __ДлинаРукава = ObjectList["ДлинаРукава"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаРукава.Value;
            }
            set
            {
                NsgDataFloat __ДлинаРукава = ObjectList["ДлинаРукава"] as NsgDataFloat;
                __ДлинаРукава.Value = value;
            }
        }
        
        /// <summary>
        /// Длина стопы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаСтопы
        {
            get
            {
				 NsgDataFloat __ДлинаСтопы = ObjectList["ДлинаСтопы"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаСтопы.Value;
            }
            set
            {
                NsgDataFloat __ДлинаСтопы = ObjectList["ДлинаСтопы"] as NsgDataFloat;
                __ДлинаСтопы.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват груди
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГруди
        {
            get
            {
				 NsgDataFloat __ОбхватГруди = ObjectList["ОбхватГруди"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГруди.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГруди = ObjectList["ОбхватГруди"] as NsgDataFloat;
                __ОбхватГруди.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват головы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГоловы
        {
            get
            {
				 NsgDataFloat __ОбхватГоловы = ObjectList["ОбхватГоловы"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГоловы.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГоловы = ObjectList["ОбхватГоловы"] as NsgDataFloat;
                __ОбхватГоловы.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public Мерки Родитель
        {
            get
            {
                return base.Parent as Мерки;
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
        private Мерки[] convertArray(NsgMultipleObject[] array)
        {
            Мерки[] res = new Мерки[array.Length];
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
        public new virtual Мерки[] FindAll(NsgCompare compare)
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
        public new virtual Мерки[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Мерки[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Мерки[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Мерки(this as NsgObject);
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
                base.NSGType = typeof(Мерки);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Мерки Value
            {
                get
                {
                    return (Мерки)base.Value;
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
