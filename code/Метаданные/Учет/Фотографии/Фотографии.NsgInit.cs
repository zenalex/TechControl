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

namespace TechControl.Метаданные.Учет
{
    
    [NsgTypeName("NsgDataDictionary", Guid = "feeb7e32-730b-451c-8370-5b2928485c18")]
    public partial class Фотографии : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Фотографии()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Фотографии(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Фотографии Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("feeb7e32-730b-451c-8370-5b2928485c18"));
            if (obj == null)
                obj = new Фотографии();
            return obj as Фотографии;
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
	Владелец.FilterForConfigurator = "Мониторинг.Контрагенты,Мониторинг.Объекты,Мониторинг.Техника,Мониторинг.ФизЛица,Учет.Номенклатура,УчетСотрудников.ДокументыФизЛиц";
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
	Владелец.Guid = NsgService.StringToGuid("6c3d6cd1-a6e5-44e2-8b21-7a6be834452c");
	
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
	Идентификатор.Guid = NsgService.StringToGuid("1d55d15e-a923-4771-b858-c5b088c00d2d");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("2d6d8f56-6825-4fec-a889-56b58d0db362");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("33c1650b-c7bb-433c-be0c-ac76ed314fb8");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("927c8d22-26b9-464e-bcd4-52a023e6bf64");
	
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
	Уровень.Guid = NsgService.StringToGuid("32405e2c-8817-4351-a8f2-1655aa747297");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("0c95333b-d1d2-4411-814c-5bbdbe9ff9a0");
	
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
	НомерКода.Guid = NsgService.StringToGuid("9ee5418c-f47e-46ee-b576-aee9120f82c6");
	
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
	Код.Guid = NsgService.StringToGuid("7237e37a-49c3-4c94-a29a-717a60a45111");
	
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
	Наименование.Guid = NsgService.StringToGuid("0c6eb55c-a804-4754-8ef6-690fe743376c");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("64ec9f14-3470-414a-a883-2c77b9c46928");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание TechControl.Метаданные.Учет.ФотографииФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Учет.ФотографииФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("30a13938-65ae-4ec8-b06a-96f0531d90c9");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Учет.ФотографииФормаЭлемента ФормаЭлемента
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("53af6181-bd0e-4a70-afd7-6569aaeb96af");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.DateTime ДатаФотографии
			{  
                NsgDataDateTime ДатаФотографии = null;
				if (ObjectList.Contains("ДатаФотографии"))
                    ДатаФотографии = ObjectList["ДатаФотографии"] as NsgDataDateTime;
                else
                    ДатаФотографии = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаФотографии.IsLoadedFromDll = true;
	ДатаФотографии.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаФотографии.StringFormat = "";
	ДатаФотографии.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаФотографии.IncludeInPredefined = false;
	ДатаФотографии.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаФотографии.Required = false;
	ДатаФотографии.EmptyValue = "";
	ДатаФотографии.NullAllow = false;
	ДатаФотографии.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаФотографии.FieldName = "DataFotografii";
	ДатаФотографии.SaveInDatabase = true;
	ДатаФотографии.InformMetaDataOnValueChanged = false;
	ДатаФотографии.Visible = true;
	ДатаФотографии.Name = "ДатаФотографии";
	ДатаФотографии.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаФотографии.Description = "Дата фотографии";
	ДатаФотографии.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаФотографии.GroupName = "";
	ДатаФотографии.Guid = NsgService.StringToGuid("8c079616-ecf0-4735-8e9c-e4db31d1ab97");
	
				if (!ObjectList.Contains("ДатаФотографии"))
                    ObjectList.Add(ДатаФотографии);
			}
			#endregion //создание System.DateTime ДатаФотографии
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ДокументДвижения
			{  
                NsgDataUntypedReference ДокументДвижения = null;
				if (ObjectList.Contains("ДокументДвижения"))
                    ДокументДвижения = ObjectList["ДокументДвижения"] as NsgDataUntypedReference;
                else
                    ДокументДвижения = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ДокументДвижения.IsLoadedFromDll = true;
	ДокументДвижения.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	ДокументДвижения.FilterForConfigurator = "Мониторинг.ФормированиеСменыДень,Учет.Перемещение";
	ДокументДвижения.ReferentName = "";
	ДокументДвижения.ReferentGroup = "";
	ДокументДвижения.TypeSelectorName = "";
	ДокументДвижения.SaveInDatabase = true;
	ДокументДвижения.OwnerName = "";
	ДокументДвижения.AllowEmptyOwner = false;
	ДокументДвижения.StringFormat = "";
	ДокументДвижения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДокументДвижения.IncludeInPredefined = false;
	ДокументДвижения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументДвижения.Required = false;
	ДокументДвижения.EmptyValue = "";
	ДокументДвижения.NullAllow = false;
	ДокументДвижения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДокументДвижения.FieldName = "DokumentDvizhenija";
	ДокументДвижения.InformMetaDataOnValueChanged = false;
	ДокументДвижения.Visible = true;
	ДокументДвижения.Name = "ДокументДвижения";
	ДокументДвижения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументДвижения.Description = "Документ движения";
	ДокументДвижения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДокументДвижения.GroupName = "";
	ДокументДвижения.Guid = NsgService.StringToGuid("de96f49c-8be7-4fc1-8dd6-adbd3a5a51a9");
	
				if (!ObjectList.Contains("ДокументДвижения"))
                    ObjectList.Add(ДокументДвижения);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументДвижения
			
			#region создание System.String Путь
			{  
                NsgDataString Путь = null;
				if (ObjectList.Contains("Путь"))
                    Путь = ObjectList["Путь"] as NsgDataString;
                else
                    Путь = new NsgDataString();
	//NsgDataString
	Путь.IsLoadedFromDll = true;
	Путь.Length = 0;
	Путь.StringFormat = "";
	Путь.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Путь.IncludeInPredefined = false;
	Путь.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Путь.Required = false;
	Путь.EmptyValue = "";
	Путь.NullAllow = false;
	Путь.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Путь.FieldName = "Put";
	Путь.SaveInDatabase = true;
	Путь.InformMetaDataOnValueChanged = false;
	Путь.Visible = true;
	Путь.Name = "Путь";
	Путь.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Путь.Description = "Путь";
	Путь.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Путь.GroupName = "";
	Путь.Guid = NsgService.StringToGuid("73b80280-f903-4c8b-a25f-ab601b02112a");
	
				if (!ObjectList.Contains("Путь"))
                    ObjectList.Add(Путь);
			}
			#endregion //создание System.String Путь
			
			#region создание System.String АдресСервера
			{  
                NsgDataString АдресСервера = null;
				if (ObjectList.Contains("АдресСервера"))
                    АдресСервера = ObjectList["АдресСервера"] as NsgDataString;
                else
                    АдресСервера = new NsgDataString();
	//NsgDataString
	АдресСервера.IsLoadedFromDll = true;
	АдресСервера.Length = 0;
	АдресСервера.StringFormat = "";
	АдресСервера.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	АдресСервера.IncludeInPredefined = false;
	АдресСервера.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АдресСервера.Required = false;
	АдресСервера.EmptyValue = "";
	АдресСервера.NullAllow = false;
	АдресСервера.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АдресСервера.FieldName = "AdresServera";
	АдресСервера.SaveInDatabase = true;
	АдресСервера.InformMetaDataOnValueChanged = false;
	АдресСервера.Visible = true;
	АдресСервера.Name = "АдресСервера";
	АдресСервера.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	АдресСервера.Description = "Адрес сервера";
	АдресСервера.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	АдресСервера.GroupName = "";
	АдресСервера.Guid = NsgService.StringToGuid("45c7de2d-206f-4748-afae-e2c506e5024e");
	
				if (!ObjectList.Contains("АдресСервера"))
                    ObjectList.Add(АдресСервера);
			}
			#endregion //создание System.String АдресСервера
			
			#region создание TechControl.Метаданные.Учет.ФотографииФормаСписка ФормаСписка
			{  
                NsgDataForm ФормаСписка = null;
				if (ObjectList.Contains("ФормаСписка"))
                    ФормаСписка = ObjectList["ФормаСписка"] as NsgDataForm;
                else
                    ФормаСписка = new NsgDataForm();
	//NsgDataForm
	ФормаСписка.IsLoadedFromDll = true;
	ФормаСписка.FormClassName = "TechControl.Метаданные.Учет.ФотографииФормаСписка";
	ФормаСписка.SaveInDatabase = false;
	ФормаСписка.StringFormat = "";
	ФормаСписка.SubType = NsgSoft.Common.NsgRekvisitSubType.ListForm;
	ФормаСписка.IncludeInPredefined = false;
	ФормаСписка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаСписка.Required = false;
	ФормаСписка.EmptyValue = "";
	ФормаСписка.NullAllow = false;
	ФормаСписка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаСписка.FieldName = "FormaSpiska";
	ФормаСписка.InformMetaDataOnValueChanged = false;
	ФормаСписка.Visible = true;
	ФормаСписка.Name = "ФормаСписка";
	ФормаСписка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаСписка.Description = "Форма списка";
	ФормаСписка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ФормаСписка.GroupName = "";
	ФормаСписка.Guid = NsgService.StringToGuid("a0e9bdaf-756d-4889-b8dc-e4e54c1d823e");
	
				if (!ObjectList.Contains("ФормаСписка"))
                    ObjectList.Add(ФормаСписка);
			}
			#endregion //создание TechControl.Метаданные.Учет.ФотографииФормаСписка ФормаСписка
			
			#region создание Мониторинг.ФормированиеСмены ФормированиеСмены
			{  
                NsgDataTypedReference ФормированиеСмены = null;
				if (ObjectList.Contains("ФормированиеСмены"))
                    ФормированиеСмены = ObjectList["ФормированиеСмены"] as NsgDataTypedReference;
                else
                    ФормированиеСмены = new NsgDataTypedReference();
	//NsgDataTypedReference
	ФормированиеСмены.IsLoadedFromDll = true;
	ФормированиеСмены.ReferentGroup = "Мониторинг";
	ФормированиеСмены.ReferentName = "ФормированиеСмены";
	ФормированиеСмены.SaveInDatabase = true;
	ФормированиеСмены.OwnerName = "";
	ФормированиеСмены.AllowEmptyOwner = false;
	ФормированиеСмены.StringFormat = "";
	ФормированиеСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ФормированиеСмены.IncludeInPredefined = false;
	ФормированиеСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормированиеСмены.Required = false;
	ФормированиеСмены.EmptyValue = "";
	ФормированиеСмены.NullAllow = false;
	ФормированиеСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормированиеСмены.FieldName = "FormirovanieSmeny";
	ФормированиеСмены.InformMetaDataOnValueChanged = false;
	ФормированиеСмены.Visible = true;
	ФормированиеСмены.Name = "ФормированиеСмены";
	ФормированиеСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормированиеСмены.Description = "Формирование смены";
	ФормированиеСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ФормированиеСмены.GroupName = "";
	ФормированиеСмены.Guid = NsgService.StringToGuid("ed2e5337-f2fa-4467-953b-1ecd70211904");
	
				if (!ObjectList.Contains("ФормированиеСмены"))
                    ObjectList.Add(ФормированиеСмены);
			}
			#endregion //создание Мониторинг.ФормированиеСмены ФормированиеСмены
			
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
	Объект.Guid = NsgService.StringToGuid("08fd4e56-889e-4188-89fc-9eec0c689407");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Учет.ТипыФотографий ТипФотографии
			{  
                NsgDataTypedReference ТипФотографии = null;
				if (ObjectList.Contains("ТипФотографии"))
                    ТипФотографии = ObjectList["ТипФотографии"] as NsgDataTypedReference;
                else
                    ТипФотографии = new NsgDataTypedReference();
	//NsgDataTypedReference
	ТипФотографии.IsLoadedFromDll = true;
	ТипФотографии.ReferentGroup = "Учет";
	ТипФотографии.ReferentName = "ТипыФотографий";
	ТипФотографии.SaveInDatabase = true;
	ТипФотографии.OwnerName = "";
	ТипФотографии.AllowEmptyOwner = false;
	ТипФотографии.StringFormat = "";
	ТипФотографии.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТипФотографии.IncludeInPredefined = false;
	ТипФотографии.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипФотографии.Required = false;
	ТипФотографии.EmptyValue = "";
	ТипФотографии.NullAllow = false;
	ТипФотографии.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипФотографии.FieldName = "TipFotografii";
	ТипФотографии.InformMetaDataOnValueChanged = false;
	ТипФотографии.Visible = true;
	ТипФотографии.Name = "ТипФотографии";
	ТипФотографии.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипФотографии.Description = "Тип фотографии";
	ТипФотографии.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипФотографии.GroupName = "";
	ТипФотографии.Guid = NsgService.StringToGuid("50e49546-4e87-41ce-82c8-65d3f4a49602");
	
				if (!ObjectList.Contains("ТипФотографии"))
                    ObjectList.Add(ТипФотографии);
			}
			#endregion //создание Учет.ТипыФотографий ТипФотографии
			
			#region создание Учет.ИсточникФотографииКлиента ИсточникФайлаКлиента
			{  
                NsgDataEnumReference ИсточникФайлаКлиента = null;
				if (ObjectList.Contains("ИсточникФайлаКлиента"))
                    ИсточникФайлаКлиента = ObjectList["ИсточникФайлаКлиента"] as NsgDataEnumReference;
                else
                    ИсточникФайлаКлиента = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИсточникФайлаКлиента.IsLoadedFromDll = true;
	ИсточникФайлаКлиента.ReferentGroup = "Учет";
	ИсточникФайлаКлиента.ReferentName = "ИсточникФотографииКлиента";
	ИсточникФайлаКлиента.SaveInDatabase = true;
	ИсточникФайлаКлиента.OwnerName = "";
	ИсточникФайлаКлиента.AllowEmptyOwner = false;
	ИсточникФайлаКлиента.StringFormat = "";
	ИсточникФайлаКлиента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИсточникФайлаКлиента.IncludeInPredefined = false;
	ИсточникФайлаКлиента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИсточникФайлаКлиента.Required = false;
	ИсточникФайлаКлиента.EmptyValue = "";
	ИсточникФайлаКлиента.NullAllow = false;
	ИсточникФайлаКлиента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИсточникФайлаКлиента.FieldName = "IstochnikFaijlaKl";
	ИсточникФайлаКлиента.InformMetaDataOnValueChanged = false;
	ИсточникФайлаКлиента.Visible = true;
	ИсточникФайлаКлиента.Name = "ИсточникФайлаКлиента";
	ИсточникФайлаКлиента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИсточникФайлаКлиента.Description = "Источник файла клиента";
	ИсточникФайлаКлиента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИсточникФайлаКлиента.GroupName = "";
	ИсточникФайлаКлиента.Guid = NsgService.StringToGuid("5935e7ce-5b44-4bb2-989a-07d6e72dff15");
	
				if (!ObjectList.Contains("ИсточникФайлаКлиента"))
                    ObjectList.Add(ИсточникФайлаКлиента);
			}
			#endregion //создание Учет.ИсточникФотографииКлиента ИсточникФайлаКлиента
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Фотографии";
	Visible = true;
	Guid = NsgService.StringToGuid("feeb7e32-730b-451c-8370-5b2928485c18");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Fotografii";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Фотографии";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Учет";
	
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
            /// Дата фотографии
            /// </summary>
            public static String ДатаФотографии
            {
                get
                {
                    return "ДатаФотографии";
                }
            }
            
            /// <summary>
            /// Документ движения
            /// </summary>
            public static String ДокументДвижения
            {
                get
                {
                    return "ДокументДвижения";
                }
            }
            
            /// <summary>
            /// Путь
            /// </summary>
            public static String Путь
            {
                get
                {
                    return "Путь";
                }
            }
            
            /// <summary>
            /// Адрес сервера
            /// </summary>
            public static String АдресСервера
            {
                get
                {
                    return "АдресСервера";
                }
            }
            
            /// <summary>
            /// Форма списка
            /// </summary>
            public static String ФормаСписка
            {
                get
                {
                    return "ФормаСписка";
                }
            }
            
            /// <summary>
            /// Формирование смены
            /// </summary>
            public static String ФормированиеСмены
            {
                get
                {
                    return "ФормированиеСмены";
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
            /// Тип фотографии
            /// </summary>
            public static String ТипФотографии
            {
                get
                {
                    return "ТипФотографии";
                }
            }
            
            /// <summary>
            /// Источник файла клиента
            /// </summary>
            public static String ИсточникФайлаКлиента
            {
                get
                {
                    return "ИсточникФайлаКлиента";
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
                    descriptor.Name = "Фотографии";
                    descriptor.GroupName = "Учет";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Учет.Фотографии";
        }

        
        /// <summary>
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Мониторинг.Контрагенты,Мониторинг.Объекты,Мониторинг.Техника,Мониторинг.ФизЛица,Учет.Номенклатура,УчетСотрудников.ДокументыФизЛиц")]
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
        /// Дата фотографии
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаФотографии
        {
            get
            {
				 NsgDataDateTime __ДатаФотографии = ObjectList["ДатаФотографии"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаФотографии.Value;
            }
            set
            {
                NsgDataDateTime __ДатаФотографии = ObjectList["ДатаФотографии"] as NsgDataDateTime;
                __ДатаФотографии.Value = value;
            }
        }
        
        /// <summary>
        /// Документ движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Мониторинг.ФормированиеСменыДень,Учет.Перемещение")]
        public NsgSoft.DataObjects.NsgReferencedObject ДокументДвижения
        {
            get
            {
				 NsgDataUntypedReference __ДокументДвижения = ObjectList["ДокументДвижения"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ДокументДвижения.Referent;
            }
            set
            {
                NsgDataUntypedReference __ДокументДвижения = ObjectList["ДокументДвижения"] as NsgDataUntypedReference;
                __ДокументДвижения.Referent = value;
            }
        }
        
        /// <summary>
        /// Путь
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Путь
        {
            get
            {
				 NsgDataString __Путь = ObjectList["Путь"] as NsgDataString;
                 return (System.String)__Путь.Value;
            }
            set
            {
                NsgDataString __Путь = ObjectList["Путь"] as NsgDataString;
                __Путь.Value = value;
            }
        }
        
        /// <summary>
        /// Адрес сервера
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String АдресСервера
        {
            get
            {
				 NsgDataString __АдресСервера = ObjectList["АдресСервера"] as NsgDataString;
                 return (System.String)__АдресСервера.Value;
            }
            set
            {
                NsgDataString __АдресСервера = ObjectList["АдресСервера"] as NsgDataString;
                __АдресСервера.Value = value;
            }
        }
        
        /// <summary>
        /// Формирование смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDocument")]
        
        public Мониторинг.ФормированиеСмены ФормированиеСмены
        {
            get
            {
				 NsgDataTypedReference __ФормированиеСмены = ObjectList["ФормированиеСмены"] as NsgDataTypedReference;
                 return (Мониторинг.ФормированиеСмены)__ФормированиеСмены.Referent;
            }
            set
            {
                NsgDataTypedReference __ФормированиеСмены = ObjectList["ФормированиеСмены"] as NsgDataTypedReference;
                __ФормированиеСмены.Referent = value;
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
        /// Тип фотографии
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ТипыФотографий ТипФотографии
        {
            get
            {
				 NsgDataTypedReference __ТипФотографии = ObjectList["ТипФотографии"] as NsgDataTypedReference;
                 return (Учет.ТипыФотографий)__ТипФотографии.Referent;
            }
            set
            {
                NsgDataTypedReference __ТипФотографии = ObjectList["ТипФотографии"] as NsgDataTypedReference;
                __ТипФотографии.Referent = value;
            }
        }
        
        /// <summary>
        /// Источник файла клиента
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Учет.ИсточникФотографииКлиента ИсточникФайлаКлиента
        {
            get
            {
				 NsgDataEnumReference __ИсточникФайлаКлиента = ObjectList["ИсточникФайлаКлиента"] as NsgDataEnumReference;
                 return (Учет.ИсточникФотографииКлиента)__ИсточникФайлаКлиента.Referent;
            }
            set
            {
                NsgDataEnumReference __ИсточникФайлаКлиента = ObjectList["ИсточникФайлаКлиента"] as NsgDataEnumReference;
                __ИсточникФайлаКлиента.Referent = value;
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
        
        /// <summary>
        /// Форма списка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаСписка
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаСписка"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаСписка");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаСписка");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public Фотографии Родитель
        {
            get
            {
                return base.Parent as Фотографии;
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
        private Фотографии[] convertArray(NsgMultipleObject[] array)
        {
            Фотографии[] res = new Фотографии[array.Length];
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
        public new virtual Фотографии[] FindAll(NsgCompare compare)
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
        public new virtual Фотографии[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Фотографии[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Фотографии[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Фотографии(this as NsgObject);
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
                base.NSGType = typeof(Фотографии);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Фотографии Value
            {
                get
                {
                    return (Фотографии)base.Value;
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
