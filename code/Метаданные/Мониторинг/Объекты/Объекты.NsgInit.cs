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
    
    [NsgTypeName("NsgDataDictionary", Guid = "07d20ec3-3801-403d-805e-3d5bfd3eedbc")]
    public partial class Объекты : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Объекты()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Объекты(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Объекты Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("07d20ec3-3801-403d-805e-3d5bfd3eedbc"));
            if (obj == null)
                obj = new Объекты();
            return obj as Объекты;
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
	Идентификатор.Guid = NsgService.StringToGuid("bb0340f9-41ba-485b-89ea-3f20ce65e4bb");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("d06f185b-4a91-41b4-ac7d-d69bbc5893f8");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("ba7884a4-1b5e-4677-8716-6a0153040b92");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("34a3841e-d26e-4770-811b-a7f0412549a6");
	
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
	Уровень.Guid = NsgService.StringToGuid("6ecf49e9-b59c-4cdf-80d1-bc158d8bfeea");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("58212ae4-90ba-4d1a-bf3d-3b6f7e038e39");
	
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
	НомерКода.Guid = NsgService.StringToGuid("a82e49ee-5e6a-4b11-bb97-927581adc627");
	
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
	Код.Guid = NsgService.StringToGuid("f7d1ce02-044a-4f5a-aadf-424c4076ff81");
	
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
	Наименование.Length = 255;
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
	Наименование.Guid = NsgService.StringToGuid("23ac2032-13d2-443e-aa03-8f0cf586625c");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("8bce027f-6224-4dcb-81b0-5df37cf7fd12");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание System.String Адрес
			{  
                NsgDataString Адрес = null;
				if (ObjectList.Contains("Адрес"))
                    Адрес = ObjectList["Адрес"] as NsgDataString;
                else
                    Адрес = new NsgDataString();
	//NsgDataString
	Адрес.IsLoadedFromDll = true;
	Адрес.Length = 255;
	Адрес.StringFormat = "";
	Адрес.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Адрес.IncludeInPredefined = false;
	Адрес.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Адрес.Required = false;
	Адрес.EmptyValue = "";
	Адрес.NullAllow = false;
	Адрес.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Адрес.FieldName = "Adres";
	Адрес.SaveInDatabase = true;
	Адрес.InformMetaDataOnValueChanged = false;
	Адрес.Visible = true;
	Адрес.Name = "Адрес";
	Адрес.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Адрес.Description = "Адрес";
	Адрес.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Адрес.GroupName = "";
	Адрес.Guid = NsgService.StringToGuid("73adabc8-8417-464a-b974-a6be6b4de147");
	
				if (!ObjectList.Contains("Адрес"))
                    ObjectList.Add(Адрес);
			}
			#endregion //создание System.String Адрес
			
			#region создание Мониторинг.Контрагенты Заказчик
			{  
                NsgDataTypedReference Заказчик = null;
				if (ObjectList.Contains("Заказчик"))
                    Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                else
                    Заказчик = new NsgDataTypedReference();
	//NsgDataTypedReference
	Заказчик.IsLoadedFromDll = true;
	Заказчик.ReferentGroup = "Мониторинг";
	Заказчик.ReferentName = "Контрагенты";
	Заказчик.SaveInDatabase = true;
	Заказчик.OwnerName = "";
	Заказчик.AllowEmptyOwner = false;
	Заказчик.StringFormat = "";
	Заказчик.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Заказчик.IncludeInPredefined = false;
	Заказчик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Заказчик.Required = false;
	Заказчик.EmptyValue = "";
	Заказчик.NullAllow = false;
	Заказчик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Заказчик.FieldName = "Zakazchik";
	Заказчик.InformMetaDataOnValueChanged = false;
	Заказчик.Visible = true;
	Заказчик.Name = "Заказчик";
	Заказчик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Заказчик.Description = "Заказчик";
	Заказчик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Заказчик.GroupName = "";
	Заказчик.Guid = NsgService.StringToGuid("448c7c60-4809-499d-8f87-8ef5a0646058");
	
				if (!ObjectList.Contains("Заказчик"))
                    ObjectList.Add(Заказчик);
			}
			#endregion //создание Мониторинг.Контрагенты Заказчик
			
			#region создание Мониторинг.ТипСобственности СобственностьТехники
			{  
                NsgDataEnumReference СобственностьТехники = null;
				if (ObjectList.Contains("СобственностьТехники"))
                    СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                else
                    СобственностьТехники = new NsgDataEnumReference();
	//NsgDataEnumReference
	СобственностьТехники.IsLoadedFromDll = true;
	СобственностьТехники.ReferentGroup = "Мониторинг";
	СобственностьТехники.ReferentName = "ТипСобственности";
	СобственностьТехники.SaveInDatabase = true;
	СобственностьТехники.OwnerName = "";
	СобственностьТехники.AllowEmptyOwner = false;
	СобственностьТехники.StringFormat = "";
	СобственностьТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СобственностьТехники.IncludeInPredefined = false;
	СобственностьТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СобственностьТехники.Required = false;
	СобственностьТехники.EmptyValue = "";
	СобственностьТехники.NullAllow = false;
	СобственностьТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СобственностьТехники.FieldName = "SobstvennostTekhniki";
	СобственностьТехники.InformMetaDataOnValueChanged = false;
	СобственностьТехники.Visible = true;
	СобственностьТехники.Name = "СобственностьТехники";
	СобственностьТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СобственностьТехники.Description = "Собственность техники";
	СобственностьТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СобственностьТехники.GroupName = "";
	СобственностьТехники.Guid = NsgService.StringToGuid("f7f10b9e-3ec5-476a-b1e3-9fd1e861784c");
	
				if (!ObjectList.Contains("СобственностьТехники"))
                    ObjectList.Add(СобственностьТехники);
			}
			#endregion //создание Мониторинг.ТипСобственности СобственностьТехники
			
			#region создание System.String ГраницаОбъектаМониторинга
			{  
                NsgDataString ГраницаОбъектаМониторинга = null;
				if (ObjectList.Contains("ГраницаОбъектаМониторинга"))
                    ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                else
                    ГраницаОбъектаМониторинга = new NsgDataString();
	//NsgDataString
	ГраницаОбъектаМониторинга.IsLoadedFromDll = true;
	ГраницаОбъектаМониторинга.Length = 0;
	ГраницаОбъектаМониторинга.StringFormat = "";
	ГраницаОбъектаМониторинга.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГраницаОбъектаМониторинга.IncludeInPredefined = false;
	ГраницаОбъектаМониторинга.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГраницаОбъектаМониторинга.Required = false;
	ГраницаОбъектаМониторинга.EmptyValue = "";
	ГраницаОбъектаМониторинга.NullAllow = false;
	ГраницаОбъектаМониторинга.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГраницаОбъектаМониторинга.FieldName = "GranicaObektaMoni";
	ГраницаОбъектаМониторинга.SaveInDatabase = true;
	ГраницаОбъектаМониторинга.InformMetaDataOnValueChanged = false;
	ГраницаОбъектаМониторинга.Visible = true;
	ГраницаОбъектаМониторинга.Name = "ГраницаОбъектаМониторинга";
	ГраницаОбъектаМониторинга.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГраницаОбъектаМониторинга.Description = "Граница объекта мониторинга";
	ГраницаОбъектаМониторинга.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГраницаОбъектаМониторинга.GroupName = "";
	ГраницаОбъектаМониторинга.Guid = NsgService.StringToGuid("dcf03f83-9cc9-4c88-8d30-8784d15bfe7c");
	
				if (!ObjectList.Contains("ГраницаОбъектаМониторинга"))
                    ObjectList.Add(ГраницаОбъектаМониторинга);
			}
			#endregion //создание System.String ГраницаОбъектаМониторинга
			
			#region создание System.DateTime НачалоРабочейСмены
			{  
                NsgDataDateTime НачалоРабочейСмены = null;
				if (ObjectList.Contains("НачалоРабочейСмены"))
                    НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                else
                    НачалоРабочейСмены = new NsgDataDateTime();
	//NsgDataDateTime
	НачалоРабочейСмены.IsLoadedFromDll = true;
	НачалоРабочейСмены.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	НачалоРабочейСмены.StringFormat = "";
	НачалоРабочейСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НачалоРабочейСмены.IncludeInPredefined = false;
	НачалоРабочейСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НачалоРабочейСмены.Required = false;
	НачалоРабочейСмены.EmptyValue = "";
	НачалоРабочейСмены.NullAllow = false;
	НачалоРабочейСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НачалоРабочейСмены.FieldName = "NachaloRabocheijS";
	НачалоРабочейСмены.SaveInDatabase = true;
	НачалоРабочейСмены.InformMetaDataOnValueChanged = false;
	НачалоРабочейСмены.Visible = true;
	НачалоРабочейСмены.Name = "НачалоРабочейСмены";
	НачалоРабочейСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НачалоРабочейСмены.Description = "Начало рабочей смены";
	НачалоРабочейСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НачалоРабочейСмены.GroupName = "";
	НачалоРабочейСмены.Guid = NsgService.StringToGuid("12cb973b-2fe5-4e97-ab9e-cf6c894f8e63");
	
				if (!ObjectList.Contains("НачалоРабочейСмены"))
                    ObjectList.Add(НачалоРабочейСмены);
			}
			#endregion //создание System.DateTime НачалоРабочейСмены
			
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
	Ответственный.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	Ответственный.Guid = NsgService.StringToGuid("4e4c78d6-af38-422a-81be-d3fa921ef67f");
	
				if (!ObjectList.Contains("Ответственный"))
                    ObjectList.Add(Ответственный);
			}
			#endregion //создание Мониторинг.ФизЛица Ответственный
			
			#region создание System.DateTime КонецРабочейСмены
			{  
                NsgDataDateTime КонецРабочейСмены = null;
				if (ObjectList.Contains("КонецРабочейСмены"))
                    КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                else
                    КонецРабочейСмены = new NsgDataDateTime();
	//NsgDataDateTime
	КонецРабочейСмены.IsLoadedFromDll = true;
	КонецРабочейСмены.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	КонецРабочейСмены.StringFormat = "";
	КонецРабочейСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КонецРабочейСмены.IncludeInPredefined = false;
	КонецРабочейСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонецРабочейСмены.Required = false;
	КонецРабочейСмены.EmptyValue = "";
	КонецРабочейСмены.NullAllow = false;
	КонецРабочейСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонецРабочейСмены.FieldName = "KonecRabocheijSmeny";
	КонецРабочейСмены.SaveInDatabase = true;
	КонецРабочейСмены.InformMetaDataOnValueChanged = false;
	КонецРабочейСмены.Visible = true;
	КонецРабочейСмены.Name = "КонецРабочейСмены";
	КонецРабочейСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонецРабочейСмены.Description = "Конец рабочей смены";
	КонецРабочейСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КонецРабочейСмены.GroupName = "";
	КонецРабочейСмены.Guid = NsgService.StringToGuid("f802ff8a-24a8-42c5-9790-62677d53a26b");
	
				if (!ObjectList.Contains("КонецРабочейСмены"))
                    ObjectList.Add(КонецРабочейСмены);
			}
			#endregion //создание System.DateTime КонецРабочейСмены
			
			#region создание Мониторинг.Контрагенты Фирма
			{  
                NsgDataTypedReference Фирма = null;
				if (ObjectList.Contains("Фирма"))
                    Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                else
                    Фирма = new NsgDataTypedReference();
	//NsgDataTypedReference
	Фирма.IsLoadedFromDll = true;
	Фирма.ReferentGroup = "Мониторинг";
	Фирма.ReferentName = "Контрагенты";
	Фирма.SaveInDatabase = true;
	Фирма.OwnerName = "";
	Фирма.AllowEmptyOwner = false;
	Фирма.StringFormat = "";
	Фирма.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Фирма.IncludeInPredefined = false;
	Фирма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Фирма.Required = false;
	Фирма.EmptyValue = "";
	Фирма.NullAllow = false;
	Фирма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Фирма.FieldName = "Firma";
	Фирма.InformMetaDataOnValueChanged = false;
	Фирма.Visible = true;
	Фирма.Name = "Фирма";
	Фирма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Фирма.Description = "Фирма";
	Фирма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Фирма.GroupName = "";
	Фирма.Guid = NsgService.StringToGuid("c4c7ca53-fb13-4569-8df4-8078918021da");
	
				if (!ObjectList.Contains("Фирма"))
                    ObjectList.Add(Фирма);
			}
			#endregion //создание Мониторинг.Контрагенты Фирма
			
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
	РежимРаботы.Guid = NsgService.StringToGuid("ca0becdd-c3bd-4458-85f9-2d0044b1c845");
	
				if (!ObjectList.Contains("РежимРаботы"))
                    ObjectList.Add(РежимРаботы);
			}
			#endregion //создание Мониторинг.РежимыРаботы РежимРаботы
			
			#region создание System.String Договор
			{  
                NsgDataString Договор = null;
				if (ObjectList.Contains("Договор"))
                    Договор = ObjectList["Договор"] as NsgDataString;
                else
                    Договор = new NsgDataString();
	//NsgDataString
	Договор.IsLoadedFromDll = true;
	Договор.Length = 50;
	Договор.StringFormat = "";
	Договор.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Договор.IncludeInPredefined = false;
	Договор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Договор.Required = false;
	Договор.EmptyValue = "";
	Договор.NullAllow = false;
	Договор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Договор.FieldName = "Dogovor";
	Договор.SaveInDatabase = true;
	Договор.InformMetaDataOnValueChanged = false;
	Договор.Visible = true;
	Договор.Name = "Договор";
	Договор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Договор.Description = "Договор";
	Договор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Договор.GroupName = "";
	Договор.Guid = NsgService.StringToGuid("3616a987-735a-45f8-ab82-5e1309c6fc38");
	
				if (!ObjectList.Contains("Договор"))
                    ObjectList.Add(Договор);
			}
			#endregion //создание System.String Договор
			
			#region создание System.Boolean Включен
			{  
                NsgDataBoolean Включен = null;
				if (ObjectList.Contains("Включен"))
                    Включен = ObjectList["Включен"] as NsgDataBoolean;
                else
                    Включен = new NsgDataBoolean();
	//NsgDataBoolean
	Включен.IsLoadedFromDll = true;
	Включен.DefaultValue = false;
	Включен.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.StringFormat = "";
	Включен.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Включен.IncludeInPredefined = false;
	Включен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Включен.Required = false;
	Включен.EmptyValue = "";
	Включен.NullAllow = false;
	Включен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Включен.FieldName = "Vkljuchen";
	Включен.SaveInDatabase = true;
	Включен.InformMetaDataOnValueChanged = false;
	Включен.Visible = true;
	Включен.Name = "Включен";
	Включен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Включен.Description = "Включен";
	Включен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Включен.GroupName = "";
	Включен.Guid = NsgService.StringToGuid("82b3fc61-5e0d-41de-a844-8d7bc4f49cd6");
	
				if (!ObjectList.Contains("Включен"))
                    ObjectList.Add(Включен);
			}
			#endregion //создание System.Boolean Включен
			
			#region создание TechControl.Метаданные.Мониторинг.ОбъектыФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ОбъектыФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("9c4e00a0-97b8-4113-a1a8-11ad9eafbeca");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ОбъектыФормаЭлемента ФормаЭлемента
			
			#region создание Мониторинг.ФизЛица Руководитель
			{  
                NsgDataTypedReference Руководитель = null;
				if (ObjectList.Contains("Руководитель"))
                    Руководитель = ObjectList["Руководитель"] as NsgDataTypedReference;
                else
                    Руководитель = new NsgDataTypedReference();
	//NsgDataTypedReference
	Руководитель.IsLoadedFromDll = true;
	Руководитель.ReferentGroup = "Мониторинг";
	Руководитель.ReferentName = "ФизЛица";
	Руководитель.SaveInDatabase = true;
	Руководитель.OwnerName = "";
	Руководитель.AllowEmptyOwner = false;
	Руководитель.StringFormat = "";
	Руководитель.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Руководитель.IncludeInPredefined = false;
	Руководитель.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Руководитель.Required = false;
	Руководитель.EmptyValue = "";
	Руководитель.NullAllow = false;
	Руководитель.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Руководитель.FieldName = "Rukovoditel";
	Руководитель.InformMetaDataOnValueChanged = false;
	Руководитель.Visible = true;
	Руководитель.Name = "Руководитель";
	Руководитель.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Руководитель.Description = "Руководитель";
	Руководитель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Руководитель.GroupName = "";
	Руководитель.Guid = NsgService.StringToGuid("a71926e2-285e-4282-b629-fd8cdca0dc20");
	
				if (!ObjectList.Contains("Руководитель"))
                    ObjectList.Add(Руководитель);
			}
			#endregion //создание Мониторинг.ФизЛица Руководитель
			
			#region создание System.Boolean СменаОткрыта
			{  
                NsgDataBoolean СменаОткрыта = null;
				if (ObjectList.Contains("СменаОткрыта"))
                    СменаОткрыта = ObjectList["СменаОткрыта"] as NsgDataBoolean;
                else
                    СменаОткрыта = new NsgDataBoolean();
	//NsgDataBoolean
	СменаОткрыта.IsLoadedFromDll = true;
	СменаОткрыта.DefaultValue = false;
	СменаОткрыта.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СменаОткрыта.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СменаОткрыта.StringFormat = "";
	СменаОткрыта.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СменаОткрыта.IncludeInPredefined = false;
	СменаОткрыта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СменаОткрыта.Required = false;
	СменаОткрыта.EmptyValue = "";
	СменаОткрыта.NullAllow = false;
	СменаОткрыта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СменаОткрыта.FieldName = "SmenaOtkryta";
	СменаОткрыта.SaveInDatabase = true;
	СменаОткрыта.InformMetaDataOnValueChanged = false;
	СменаОткрыта.Visible = true;
	СменаОткрыта.Name = "СменаОткрыта";
	СменаОткрыта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СменаОткрыта.Description = "Смена открыта";
	СменаОткрыта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СменаОткрыта.GroupName = "";
	СменаОткрыта.Guid = NsgService.StringToGuid("be50868e-4d7b-4a4f-a938-a7749cb3a17c");
	
				if (!ObjectList.Contains("СменаОткрыта"))
                    ObjectList.Add(СменаОткрыта);
			}
			#endregion //создание System.Boolean СменаОткрыта
			
			#region создание Мониторинг.Контрагенты ПоставщикТоплива
			{  
                NsgDataTypedReference ПоставщикТоплива = null;
				if (ObjectList.Contains("ПоставщикТоплива"))
                    ПоставщикТоплива = ObjectList["ПоставщикТоплива"] as NsgDataTypedReference;
                else
                    ПоставщикТоплива = new NsgDataTypedReference();
	//NsgDataTypedReference
	ПоставщикТоплива.IsLoadedFromDll = true;
	ПоставщикТоплива.ReferentGroup = "Мониторинг";
	ПоставщикТоплива.ReferentName = "Контрагенты";
	ПоставщикТоплива.SaveInDatabase = true;
	ПоставщикТоплива.OwnerName = "";
	ПоставщикТоплива.AllowEmptyOwner = false;
	ПоставщикТоплива.StringFormat = "";
	ПоставщикТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПоставщикТоплива.IncludeInPredefined = false;
	ПоставщикТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПоставщикТоплива.Required = false;
	ПоставщикТоплива.EmptyValue = "";
	ПоставщикТоплива.NullAllow = false;
	ПоставщикТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПоставщикТоплива.FieldName = "PostavschikTopliva";
	ПоставщикТоплива.InformMetaDataOnValueChanged = false;
	ПоставщикТоплива.Visible = true;
	ПоставщикТоплива.Name = "ПоставщикТоплива";
	ПоставщикТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПоставщикТоплива.Description = "Поставщик топлива";
	ПоставщикТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПоставщикТоплива.GroupName = "";
	ПоставщикТоплива.Guid = NsgService.StringToGuid("68249440-944b-4dc0-aaa4-e8bd179c7437");
	
				if (!ObjectList.Contains("ПоставщикТоплива"))
                    ObjectList.Add(ПоставщикТоплива);
			}
			#endregion //создание Мониторинг.Контрагенты ПоставщикТоплива
			
			#region создание System.Int64 МашинВРаботе
			{  
                NsgDataInteger МашинВРаботе = null;
				if (ObjectList.Contains("МашинВРаботе"))
                    МашинВРаботе = ObjectList["МашинВРаботе"] as NsgDataInteger;
                else
                    МашинВРаботе = new NsgDataInteger();
	//NsgDataInteger
	МашинВРаботе.IsLoadedFromDll = true;
	МашинВРаботе.DefaultValue = 0M;
	МашинВРаботе.MinValue = 0M;
	МашинВРаботе.MaxValue = 0M;
	МашинВРаботе.UseCalculator = true;
	МашинВРаботе.StringFormat = "";
	МашинВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	МашинВРаботе.IncludeInPredefined = false;
	МашинВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	МашинВРаботе.Required = false;
	МашинВРаботе.EmptyValue = "";
	МашинВРаботе.NullAllow = false;
	МашинВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	МашинВРаботе.FieldName = "MashinVRabote";
	МашинВРаботе.SaveInDatabase = true;
	МашинВРаботе.InformMetaDataOnValueChanged = false;
	МашинВРаботе.Visible = true;
	МашинВРаботе.Name = "МашинВРаботе";
	МашинВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	МашинВРаботе.Description = "Машин ВРаботе";
	МашинВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	МашинВРаботе.GroupName = "";
	МашинВРаботе.Guid = NsgService.StringToGuid("53ae8bd8-18fe-4022-905d-39f8e6489a88");
	
				if (!ObjectList.Contains("МашинВРаботе"))
                    ObjectList.Add(МашинВРаботе);
			}
			#endregion //создание System.Int64 МашинВРаботе
			
			#region создание System.Int64 МашинНеВРаботе
			{  
                NsgDataInteger МашинНеВРаботе = null;
				if (ObjectList.Contains("МашинНеВРаботе"))
                    МашинНеВРаботе = ObjectList["МашинНеВРаботе"] as NsgDataInteger;
                else
                    МашинНеВРаботе = new NsgDataInteger();
	//NsgDataInteger
	МашинНеВРаботе.IsLoadedFromDll = true;
	МашинНеВРаботе.DefaultValue = 0M;
	МашинНеВРаботе.MinValue = 0M;
	МашинНеВРаботе.MaxValue = 0M;
	МашинНеВРаботе.UseCalculator = true;
	МашинНеВРаботе.StringFormat = "";
	МашинНеВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	МашинНеВРаботе.IncludeInPredefined = false;
	МашинНеВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	МашинНеВРаботе.Required = false;
	МашинНеВРаботе.EmptyValue = "";
	МашинНеВРаботе.NullAllow = false;
	МашинНеВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	МашинНеВРаботе.FieldName = "MashinNeVRabote";
	МашинНеВРаботе.SaveInDatabase = true;
	МашинНеВРаботе.InformMetaDataOnValueChanged = false;
	МашинНеВРаботе.Visible = true;
	МашинНеВРаботе.Name = "МашинНеВРаботе";
	МашинНеВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	МашинНеВРаботе.Description = "Машин не ВРаботе";
	МашинНеВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	МашинНеВРаботе.GroupName = "";
	МашинНеВРаботе.Guid = NsgService.StringToGuid("4e24a9c0-d810-42c4-b4b8-f0d89cacae8d");
	
				if (!ObjectList.Contains("МашинНеВРаботе"))
                    ObjectList.Add(МашинНеВРаботе);
			}
			#endregion //создание System.Int64 МашинНеВРаботе
			
			#region создание System.Int64 МашинСломано
			{  
                NsgDataInteger МашинСломано = null;
				if (ObjectList.Contains("МашинСломано"))
                    МашинСломано = ObjectList["МашинСломано"] as NsgDataInteger;
                else
                    МашинСломано = new NsgDataInteger();
	//NsgDataInteger
	МашинСломано.IsLoadedFromDll = true;
	МашинСломано.DefaultValue = 0M;
	МашинСломано.MinValue = 0M;
	МашинСломано.MaxValue = 0M;
	МашинСломано.UseCalculator = true;
	МашинСломано.StringFormat = "";
	МашинСломано.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	МашинСломано.IncludeInPredefined = false;
	МашинСломано.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	МашинСломано.Required = false;
	МашинСломано.EmptyValue = "";
	МашинСломано.NullAllow = false;
	МашинСломано.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	МашинСломано.FieldName = "MashinSlomano";
	МашинСломано.SaveInDatabase = true;
	МашинСломано.InformMetaDataOnValueChanged = false;
	МашинСломано.Visible = true;
	МашинСломано.Name = "МашинСломано";
	МашинСломано.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	МашинСломано.Description = "Машин сломано";
	МашинСломано.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	МашинСломано.GroupName = "";
	МашинСломано.Guid = NsgService.StringToGuid("0195581f-f0bc-4b32-82ee-4af3d33f950c");
	
				if (!ObjectList.Contains("МашинСломано"))
                    ObjectList.Add(МашинСломано);
			}
			#endregion //создание System.Int64 МашинСломано
			
			#region создание _SystemTables.МониторингОбъектыТаблицаСистемыСлежения ТаблицаСистемыСлежения
			{  
                NsgDataTableReference ТаблицаСистемыСлежения = null;
				if (ObjectList.Contains("ТаблицаСистемыСлежения"))
                    ТаблицаСистемыСлежения = ObjectList["ТаблицаСистемыСлежения"] as NsgDataTableReference;
                else
                    ТаблицаСистемыСлежения = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаСистемыСлежения.IsLoadedFromDll = true;
	ТаблицаСистемыСлежения.Name = "ТаблицаСистемыСлежения";
	ТаблицаСистемыСлежения.SaveInDatabase = false;
	ТаблицаСистемыСлежения.ReferentGroup = "_SystemTables";
	ТаблицаСистемыСлежения.ReferentName = "МониторингОбъектыТаблицаСистемыСлежения";
	ТаблицаСистемыСлежения.OwnerName = "";
	ТаблицаСистемыСлежения.AllowEmptyOwner = false;
	ТаблицаСистемыСлежения.StringFormat = "";
	ТаблицаСистемыСлежения.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаСистемыСлежения.IncludeInPredefined = false;
	ТаблицаСистемыСлежения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаСистемыСлежения.Required = false;
	ТаблицаСистемыСлежения.EmptyValue = "";
	ТаблицаСистемыСлежения.NullAllow = false;
	ТаблицаСистемыСлежения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаСистемыСлежения.FieldName = "TablicaSistemySle";
	ТаблицаСистемыСлежения.InformMetaDataOnValueChanged = false;
	ТаблицаСистемыСлежения.Visible = true;
	ТаблицаСистемыСлежения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаСистемыСлежения.Description = "Таблица системы слежения";
	ТаблицаСистемыСлежения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаСистемыСлежения.GroupName = "";
	ТаблицаСистемыСлежения.Guid = NsgService.StringToGuid("7060bbc2-5f0b-4254-b543-7e4f9323a9d7");
	
				if (!ObjectList.Contains("ТаблицаСистемыСлежения"))
                    ObjectList.Add(ТаблицаСистемыСлежения);
			}
			#endregion //создание _SystemTables.МониторингОбъектыТаблицаСистемыСлежения ТаблицаСистемыСлежения
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("e43fe0f5-8263-4cbd-8b2b-c16fbd999805");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
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
	Геозона.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	Геозона.Guid = NsgService.StringToGuid("b40b1b5e-1f78-4ffd-93fe-839c606a46ab");
	
				if (!ObjectList.Contains("Геозона"))
                    ObjectList.Add(Геозона);
			}
			#endregion //создание Мониторинг.Геозоны Геозона
			
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
	ЗаправочнаяЕмкость.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	ЗаправочнаяЕмкость.Guid = NsgService.StringToGuid("915880aa-bd41-4363-a809-4e036e4d145b");
	
				if (!ObjectList.Contains("ЗаправочнаяЕмкость"))
                    ObjectList.Add(ЗаправочнаяЕмкость);
			}
			#endregion //создание Мониторинг.Техника ЗаправочнаяЕмкость
			
			#region создание Мониторинг.Договоры ДоговорСсылка
			{  
                NsgDataTypedReference ДоговорСсылка = null;
				if (ObjectList.Contains("ДоговорСсылка"))
                    ДоговорСсылка = ObjectList["ДоговорСсылка"] as NsgDataTypedReference;
                else
                    ДоговорСсылка = new NsgDataTypedReference();
	//NsgDataTypedReference
	ДоговорСсылка.IsLoadedFromDll = true;
	ДоговорСсылка.ReferentGroup = "Мониторинг";
	ДоговорСсылка.ReferentName = "Договоры";
	ДоговорСсылка.SaveInDatabase = true;
	ДоговорСсылка.OwnerName = "";
	ДоговорСсылка.AllowEmptyOwner = false;
	ДоговорСсылка.StringFormat = "";
	ДоговорСсылка.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДоговорСсылка.IncludeInPredefined = false;
	ДоговорСсылка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДоговорСсылка.Required = false;
	ДоговорСсылка.EmptyValue = "";
	ДоговорСсылка.NullAllow = false;
	ДоговорСсылка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДоговорСсылка.FieldName = "DogovorSsylka";
	ДоговорСсылка.InformMetaDataOnValueChanged = false;
	ДоговорСсылка.Visible = true;
	ДоговорСсылка.Name = "ДоговорСсылка";
	ДоговорСсылка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДоговорСсылка.Description = "Договор ссылка";
	ДоговорСсылка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДоговорСсылка.GroupName = "";
	ДоговорСсылка.Guid = NsgService.StringToGuid("1b718f28-2a0c-4fbc-9ee8-3a6b234e34dd");
	
				if (!ObjectList.Contains("ДоговорСсылка"))
                    ObjectList.Add(ДоговорСсылка);
			}
			#endregion //создание Мониторинг.Договоры ДоговорСсылка
			
			#region создание Справочники.ТипыОбъектов ТипОбъекта
			{  
                NsgDataTypedReference ТипОбъекта = null;
				if (ObjectList.Contains("ТипОбъекта"))
                    ТипОбъекта = ObjectList["ТипОбъекта"] as NsgDataTypedReference;
                else
                    ТипОбъекта = new NsgDataTypedReference();
	//NsgDataTypedReference
	ТипОбъекта.IsLoadedFromDll = true;
	ТипОбъекта.ReferentGroup = "Справочники";
	ТипОбъекта.ReferentName = "ТипыОбъектов";
	ТипОбъекта.SaveInDatabase = true;
	ТипОбъекта.OwnerName = "";
	ТипОбъекта.AllowEmptyOwner = false;
	ТипОбъекта.StringFormat = "";
	ТипОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТипОбъекта.IncludeInPredefined = false;
	ТипОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипОбъекта.Required = false;
	ТипОбъекта.EmptyValue = "";
	ТипОбъекта.NullAllow = false;
	ТипОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипОбъекта.FieldName = "TipObekta";
	ТипОбъекта.InformMetaDataOnValueChanged = false;
	ТипОбъекта.Visible = true;
	ТипОбъекта.Name = "ТипОбъекта";
	ТипОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипОбъекта.Description = "Тип объекта";
	ТипОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипОбъекта.GroupName = "";
	ТипОбъекта.Guid = NsgService.StringToGuid("354a9019-9ace-4b86-a075-10dd9bf1bb59");
	
				if (!ObjectList.Contains("ТипОбъекта"))
                    ObjectList.Add(ТипОбъекта);
			}
			#endregion //создание Справочники.ТипыОбъектов ТипОбъекта
			
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
	ЗагрузочныйИдентификатор.Guid = NsgService.StringToGuid("affaf119-d9e9-4749-9a25-e5560fc82479");
	
				if (!ObjectList.Contains("ЗагрузочныйИдентификатор"))
                    ObjectList.Add(ЗагрузочныйИдентификатор);
			}
			#endregion //создание System.String ЗагрузочныйИдентификатор
			
			#region создание System.Decimal Долгота
			{  
                NsgDataFloat Долгота = null;
				if (ObjectList.Contains("Долгота"))
                    Долгота = ObjectList["Долгота"] as NsgDataFloat;
                else
                    Долгота = new NsgDataFloat();
	//NsgDataFloat
	Долгота.IsLoadedFromDll = true;
	Долгота.Precision = 8;
	Долгота.HideZero = true;
	Долгота.DefaultValue = 0M;
	Долгота.MinValue = -100000000000000000M;
	Долгота.MaxValue = 100000000000000000M;
	Долгота.UseCalculator = true;
	Долгота.StringFormat = "";
	Долгота.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Долгота.IncludeInPredefined = false;
	Долгота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Долгота.Required = false;
	Долгота.EmptyValue = "";
	Долгота.NullAllow = false;
	Долгота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Долгота.FieldName = "Dolgota";
	Долгота.SaveInDatabase = true;
	Долгота.InformMetaDataOnValueChanged = false;
	Долгота.Visible = true;
	Долгота.Name = "Долгота";
	Долгота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Долгота.Description = "Долгота";
	Долгота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Долгота.GroupName = "";
	Долгота.Guid = NsgService.StringToGuid("1b6dfafd-20fd-4a5a-88b8-8c337cf451e5");
	
				if (!ObjectList.Contains("Долгота"))
                    ObjectList.Add(Долгота);
			}
			#endregion //создание System.Decimal Долгота
			
			#region создание System.Decimal ПлощадьЗданий
			{  
                NsgDataFloat ПлощадьЗданий = null;
				if (ObjectList.Contains("ПлощадьЗданий"))
                    ПлощадьЗданий = ObjectList["ПлощадьЗданий"] as NsgDataFloat;
                else
                    ПлощадьЗданий = new NsgDataFloat();
	//NsgDataFloat
	ПлощадьЗданий.IsLoadedFromDll = true;
	ПлощадьЗданий.Precision = 2;
	ПлощадьЗданий.HideZero = true;
	ПлощадьЗданий.DefaultValue = 0M;
	ПлощадьЗданий.MinValue = -100000000000000000M;
	ПлощадьЗданий.MaxValue = 100000000000000000M;
	ПлощадьЗданий.UseCalculator = true;
	ПлощадьЗданий.StringFormat = "";
	ПлощадьЗданий.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПлощадьЗданий.IncludeInPredefined = false;
	ПлощадьЗданий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПлощадьЗданий.Required = false;
	ПлощадьЗданий.EmptyValue = "";
	ПлощадьЗданий.NullAllow = false;
	ПлощадьЗданий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПлощадьЗданий.FieldName = "PloschadZdaniij";
	ПлощадьЗданий.SaveInDatabase = true;
	ПлощадьЗданий.InformMetaDataOnValueChanged = false;
	ПлощадьЗданий.Visible = true;
	ПлощадьЗданий.Name = "ПлощадьЗданий";
	ПлощадьЗданий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПлощадьЗданий.Description = "Площадь зданий";
	ПлощадьЗданий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПлощадьЗданий.GroupName = "";
	ПлощадьЗданий.Guid = NsgService.StringToGuid("be49ec91-76bc-471f-93fb-271da5b1af52");
	
				if (!ObjectList.Contains("ПлощадьЗданий"))
                    ObjectList.Add(ПлощадьЗданий);
			}
			#endregion //создание System.Decimal ПлощадьЗданий
			
			#region создание System.Int64 КоличествоЗданий
			{  
                NsgDataInteger КоличествоЗданий = null;
				if (ObjectList.Contains("КоличествоЗданий"))
                    КоличествоЗданий = ObjectList["КоличествоЗданий"] as NsgDataInteger;
                else
                    КоличествоЗданий = new NsgDataInteger();
	//NsgDataInteger
	КоличествоЗданий.IsLoadedFromDll = true;
	КоличествоЗданий.DefaultValue = 0M;
	КоличествоЗданий.MinValue = 0M;
	КоличествоЗданий.MaxValue = 0M;
	КоличествоЗданий.UseCalculator = true;
	КоличествоЗданий.StringFormat = "";
	КоличествоЗданий.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КоличествоЗданий.IncludeInPredefined = false;
	КоличествоЗданий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоЗданий.Required = false;
	КоличествоЗданий.EmptyValue = "";
	КоличествоЗданий.NullAllow = false;
	КоличествоЗданий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоЗданий.FieldName = "KolichestvoZdaniij";
	КоличествоЗданий.SaveInDatabase = true;
	КоличествоЗданий.InformMetaDataOnValueChanged = false;
	КоличествоЗданий.Visible = true;
	КоличествоЗданий.Name = "КоличествоЗданий";
	КоличествоЗданий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоЗданий.Description = "Количество зданий";
	КоличествоЗданий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоЗданий.GroupName = "";
	КоличествоЗданий.Guid = NsgService.StringToGuid("e585f88d-1bd8-4026-aade-795d130798f5");
	
				if (!ObjectList.Contains("КоличествоЗданий"))
                    ObjectList.Add(КоличествоЗданий);
			}
			#endregion //создание System.Int64 КоличествоЗданий
			
			#region создание System.Decimal Широта
			{  
                NsgDataFloat Широта = null;
				if (ObjectList.Contains("Широта"))
                    Широта = ObjectList["Широта"] as NsgDataFloat;
                else
                    Широта = new NsgDataFloat();
	//NsgDataFloat
	Широта.IsLoadedFromDll = true;
	Широта.Precision = 8;
	Широта.HideZero = true;
	Широта.DefaultValue = 0M;
	Широта.MinValue = -100000000000000000M;
	Широта.MaxValue = 100000000000000000M;
	Широта.UseCalculator = true;
	Широта.StringFormat = "";
	Широта.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Широта.IncludeInPredefined = false;
	Широта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Широта.Required = false;
	Широта.EmptyValue = "";
	Широта.NullAllow = false;
	Широта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Широта.FieldName = "SHirota";
	Широта.SaveInDatabase = true;
	Широта.InformMetaDataOnValueChanged = false;
	Широта.Visible = true;
	Широта.Name = "Широта";
	Широта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Широта.Description = "Широта";
	Широта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Широта.GroupName = "";
	Широта.Guid = NsgService.StringToGuid("15aafe1a-f02e-4828-a040-4d20a0b7732e");
	
				if (!ObjectList.Contains("Широта"))
                    ObjectList.Add(Широта);
			}
			#endregion //создание System.Decimal Широта
			
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
	ДатаПоследнегоИзменения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	ДатаПоследнегоИзменения.Guid = NsgService.StringToGuid("447aadbd-f4f1-43c3-9581-9a17bf475d8e");
	
				if (!ObjectList.Contains("ДатаПоследнегоИзменения"))
                    ObjectList.Add(ДатаПоследнегоИзменения);
			}
			#endregion //создание System.DateTime ДатаПоследнегоИзменения
			
			#region создание System.Int64 МаксДлительностьСменыЧасы
			{  
                NsgDataInteger МаксДлительностьСменыЧасы = null;
				if (ObjectList.Contains("МаксДлительностьСменыЧасы"))
                    МаксДлительностьСменыЧасы = ObjectList["МаксДлительностьСменыЧасы"] as NsgDataInteger;
                else
                    МаксДлительностьСменыЧасы = new NsgDataInteger();
	//NsgDataInteger
	МаксДлительностьСменыЧасы.IsLoadedFromDll = true;
	МаксДлительностьСменыЧасы.DefaultValue = 0M;
	МаксДлительностьСменыЧасы.MinValue = 0M;
	МаксДлительностьСменыЧасы.MaxValue = 0M;
	МаксДлительностьСменыЧасы.UseCalculator = true;
	МаксДлительностьСменыЧасы.StringFormat = "";
	МаксДлительностьСменыЧасы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	МаксДлительностьСменыЧасы.IncludeInPredefined = false;
	МаксДлительностьСменыЧасы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	МаксДлительностьСменыЧасы.Required = false;
	МаксДлительностьСменыЧасы.EmptyValue = "";
	МаксДлительностьСменыЧасы.NullAllow = false;
	МаксДлительностьСменыЧасы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	МаксДлительностьСменыЧасы.FieldName = "MaksDlitelnostSme";
	МаксДлительностьСменыЧасы.SaveInDatabase = true;
	МаксДлительностьСменыЧасы.InformMetaDataOnValueChanged = false;
	МаксДлительностьСменыЧасы.Visible = true;
	МаксДлительностьСменыЧасы.Name = "МаксДлительностьСменыЧасы";
	МаксДлительностьСменыЧасы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	МаксДлительностьСменыЧасы.Description = "Макс длительность смены часы";
	МаксДлительностьСменыЧасы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	МаксДлительностьСменыЧасы.GroupName = "";
	МаксДлительностьСменыЧасы.Guid = NsgService.StringToGuid("70c582ec-76f8-4a15-aafa-36eca4f72c5e");
	
				if (!ObjectList.Contains("МаксДлительностьСменыЧасы"))
                    ObjectList.Add(МаксДлительностьСменыЧасы);
			}
			#endregion //создание System.Int64 МаксДлительностьСменыЧасы
			
			#region создание СлужебныеСправочники.ПользователиСервисов Автор
			{  
                NsgDataTypedReference Автор = null;
				if (ObjectList.Contains("Автор"))
                    Автор = ObjectList["Автор"] as NsgDataTypedReference;
                else
                    Автор = new NsgDataTypedReference();
	//NsgDataTypedReference
	Автор.IsLoadedFromDll = true;
	Автор.ReferentGroup = "СлужебныеСправочники";
	Автор.ReferentName = "ПользователиСервисов";
	Автор.SaveInDatabase = true;
	Автор.OwnerName = "";
	Автор.AllowEmptyOwner = false;
	Автор.StringFormat = "";
	Автор.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Автор.IncludeInPredefined = false;
	Автор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автор.Required = false;
	Автор.EmptyValue = "";
	Автор.NullAllow = false;
	Автор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Автор.FieldName = "Avtor";
	Автор.InformMetaDataOnValueChanged = false;
	Автор.Visible = true;
	Автор.Name = "Автор";
	Автор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автор.Description = "Автор";
	Автор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Автор.GroupName = "";
	Автор.Guid = NsgService.StringToGuid("1c2c75dd-2d22-4f16-88ef-4550b0e2f0d3");
	
				if (!ObjectList.Contains("Автор"))
                    ObjectList.Add(Автор);
			}
			#endregion //создание СлужебныеСправочники.ПользователиСервисов Автор
			
			#region создание System.DateTime ДатаСоздания
			{  
                NsgDataDateTime ДатаСоздания = null;
				if (ObjectList.Contains("ДатаСоздания"))
                    ДатаСоздания = ObjectList["ДатаСоздания"] as NsgDataDateTime;
                else
                    ДатаСоздания = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаСоздания.IsLoadedFromDll = true;
	ДатаСоздания.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаСоздания.StringFormat = "";
	ДатаСоздания.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаСоздания.IncludeInPredefined = false;
	ДатаСоздания.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаСоздания.Required = false;
	ДатаСоздания.EmptyValue = "";
	ДатаСоздания.NullAllow = false;
	ДатаСоздания.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаСоздания.FieldName = "DataSozdanija";
	ДатаСоздания.SaveInDatabase = true;
	ДатаСоздания.InformMetaDataOnValueChanged = false;
	ДатаСоздания.Visible = true;
	ДатаСоздания.Name = "ДатаСоздания";
	ДатаСоздания.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаСоздания.Description = "Дата создания";
	ДатаСоздания.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаСоздания.GroupName = "";
	ДатаСоздания.Guid = NsgService.StringToGuid("b18bb0d9-bfdb-4465-bafb-e577853f5667");
	
				if (!ObjectList.Contains("ДатаСоздания"))
                    ObjectList.Add(ДатаСоздания);
			}
			#endregion //создание System.DateTime ДатаСоздания
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Объекты";
	Visible = true;
	Guid = NsgService.StringToGuid("07d20ec3-3801-403d-805e-3d5bfd3eedbc");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Obekty";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Справочник";
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
            /// Адрес
            /// </summary>
            public static String Адрес
            {
                get
                {
                    return "Адрес";
                }
            }
            
            /// <summary>
            /// Заказчик
            /// </summary>
            public static String Заказчик
            {
                get
                {
                    return "Заказчик";
                }
            }
            
            /// <summary>
            /// Собственность техники
            /// </summary>
            public static String СобственностьТехники
            {
                get
                {
                    return "СобственностьТехники";
                }
            }
            
            /// <summary>
            /// Граница объекта мониторинга
            /// </summary>
            public static String ГраницаОбъектаМониторинга
            {
                get
                {
                    return "ГраницаОбъектаМониторинга";
                }
            }
            
            /// <summary>
            /// Начало рабочей смены
            /// </summary>
            public static String НачалоРабочейСмены
            {
                get
                {
                    return "НачалоРабочейСмены";
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
            /// Конец рабочей смены
            /// </summary>
            public static String КонецРабочейСмены
            {
                get
                {
                    return "КонецРабочейСмены";
                }
            }
            
            /// <summary>
            /// Фирма
            /// </summary>
            public static String Фирма
            {
                get
                {
                    return "Фирма";
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
            /// Договор
            /// </summary>
            public static String Договор
            {
                get
                {
                    return "Договор";
                }
            }
            
            /// <summary>
            /// Включен
            /// </summary>
            public static String Включен
            {
                get
                {
                    return "Включен";
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
            /// Руководитель
            /// </summary>
            public static String Руководитель
            {
                get
                {
                    return "Руководитель";
                }
            }
            
            /// <summary>
            /// Смена открыта
            /// </summary>
            public static String СменаОткрыта
            {
                get
                {
                    return "СменаОткрыта";
                }
            }
            
            /// <summary>
            /// Поставщик топлива
            /// </summary>
            public static String ПоставщикТоплива
            {
                get
                {
                    return "ПоставщикТоплива";
                }
            }
            
            /// <summary>
            /// Машин ВРаботе
            /// </summary>
            public static String МашинВРаботе
            {
                get
                {
                    return "МашинВРаботе";
                }
            }
            
            /// <summary>
            /// Машин не ВРаботе
            /// </summary>
            public static String МашинНеВРаботе
            {
                get
                {
                    return "МашинНеВРаботе";
                }
            }
            
            /// <summary>
            /// Машин сломано
            /// </summary>
            public static String МашинСломано
            {
                get
                {
                    return "МашинСломано";
                }
            }
            
            /// <summary>
            /// Таблица системы слежения
            /// </summary>
            public static String ТаблицаСистемыСлежения
            {
                get
                {
                    return "ТаблицаСистемыСлежения";
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
            /// Договор ссылка
            /// </summary>
            public static String ДоговорСсылка
            {
                get
                {
                    return "ДоговорСсылка";
                }
            }
            
            /// <summary>
            /// Тип объекта
            /// </summary>
            public static String ТипОбъекта
            {
                get
                {
                    return "ТипОбъекта";
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
            /// Долгота
            /// </summary>
            public static String Долгота
            {
                get
                {
                    return "Долгота";
                }
            }
            
            /// <summary>
            /// Площадь зданий
            /// </summary>
            public static String ПлощадьЗданий
            {
                get
                {
                    return "ПлощадьЗданий";
                }
            }
            
            /// <summary>
            /// Количество зданий
            /// </summary>
            public static String КоличествоЗданий
            {
                get
                {
                    return "КоличествоЗданий";
                }
            }
            
            /// <summary>
            /// Широта
            /// </summary>
            public static String Широта
            {
                get
                {
                    return "Широта";
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
            
            /// <summary>
            /// Макс длительность смены часы
            /// </summary>
            public static String МаксДлительностьСменыЧасы
            {
                get
                {
                    return "МаксДлительностьСменыЧасы";
                }
            }
            
            /// <summary>
            /// Автор
            /// </summary>
            public static String Автор
            {
                get
                {
                    return "Автор";
                }
            }
            
            /// <summary>
            /// Дата создания
            /// </summary>
            public static String ДатаСоздания
            {
                get
                {
                    return "ДатаСоздания";
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
                    descriptor.Name = "Объекты";
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
            return "Мониторинг.Объекты";
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
        /// Адрес
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Адрес
        {
            get
            {
				 NsgDataString __Адрес = ObjectList["Адрес"] as NsgDataString;
                 return (System.String)__Адрес.Value;
            }
            set
            {
                NsgDataString __Адрес = ObjectList["Адрес"] as NsgDataString;
                __Адрес.Value = value;
            }
        }
        
        /// <summary>
        /// Заказчик
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Заказчик
        {
            get
            {
				 NsgDataTypedReference __Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Заказчик.Referent;
            }
            set
            {
                NsgDataTypedReference __Заказчик = ObjectList["Заказчик"] as NsgDataTypedReference;
                __Заказчик.Referent = value;
            }
        }
        
        /// <summary>
        /// Собственность техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ТипСобственности СобственностьТехники
        {
            get
            {
				 NsgDataEnumReference __СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                 return (Мониторинг.ТипСобственности)__СобственностьТехники.Referent;
            }
            set
            {
                NsgDataEnumReference __СобственностьТехники = ObjectList["СобственностьТехники"] as NsgDataEnumReference;
                __СобственностьТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Граница объекта мониторинга
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ГраницаОбъектаМониторинга
        {
            get
            {
				 NsgDataString __ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                 return (System.String)__ГраницаОбъектаМониторинга.Value;
            }
            set
            {
                NsgDataString __ГраницаОбъектаМониторинга = ObjectList["ГраницаОбъектаМониторинга"] as NsgDataString;
                __ГраницаОбъектаМониторинга.Value = value;
            }
        }
        
        /// <summary>
        /// Начало рабочей смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime НачалоРабочейСмены
        {
            get
            {
				 NsgDataDateTime __НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                 return (System.DateTime)__НачалоРабочейСмены.Value;
            }
            set
            {
                NsgDataDateTime __НачалоРабочейСмены = ObjectList["НачалоРабочейСмены"] as NsgDataDateTime;
                __НачалоРабочейСмены.Value = value;
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
        /// Конец рабочей смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime КонецРабочейСмены
        {
            get
            {
				 NsgDataDateTime __КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                 return (System.DateTime)__КонецРабочейСмены.Value;
            }
            set
            {
                NsgDataDateTime __КонецРабочейСмены = ObjectList["КонецРабочейСмены"] as NsgDataDateTime;
                __КонецРабочейСмены.Value = value;
            }
        }
        
        /// <summary>
        /// Фирма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Фирма
        {
            get
            {
				 NsgDataTypedReference __Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Фирма.Referent;
            }
            set
            {
                NsgDataTypedReference __Фирма = ObjectList["Фирма"] as NsgDataTypedReference;
                __Фирма.Referent = value;
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
        /// Договор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Договор
        {
            get
            {
				 NsgDataString __Договор = ObjectList["Договор"] as NsgDataString;
                 return (System.String)__Договор.Value;
            }
            set
            {
                NsgDataString __Договор = ObjectList["Договор"] as NsgDataString;
                __Договор.Value = value;
            }
        }
        
        /// <summary>
        /// Включен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Включен
        {
            get
            {
				 NsgDataBoolean __Включен = ObjectList["Включен"] as NsgDataBoolean;
                 return (System.Boolean)__Включен.Value;
            }
            set
            {
                NsgDataBoolean __Включен = ObjectList["Включен"] as NsgDataBoolean;
                __Включен.Value = value;
            }
        }
        
        /// <summary>
        /// Руководитель
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Руководитель
        {
            get
            {
				 NsgDataTypedReference __Руководитель = ObjectList["Руководитель"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Руководитель.Referent;
            }
            set
            {
                NsgDataTypedReference __Руководитель = ObjectList["Руководитель"] as NsgDataTypedReference;
                __Руководитель.Referent = value;
            }
        }
        
        /// <summary>
        /// Смена открыта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean СменаОткрыта
        {
            get
            {
				 NsgDataBoolean __СменаОткрыта = ObjectList["СменаОткрыта"] as NsgDataBoolean;
                 return (System.Boolean)__СменаОткрыта.Value;
            }
            set
            {
                NsgDataBoolean __СменаОткрыта = ObjectList["СменаОткрыта"] as NsgDataBoolean;
                __СменаОткрыта.Value = value;
            }
        }
        
        /// <summary>
        /// Поставщик топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты ПоставщикТоплива
        {
            get
            {
				 NsgDataTypedReference __ПоставщикТоплива = ObjectList["ПоставщикТоплива"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__ПоставщикТоплива.Referent;
            }
            set
            {
                NsgDataTypedReference __ПоставщикТоплива = ObjectList["ПоставщикТоплива"] as NsgDataTypedReference;
                __ПоставщикТоплива.Referent = value;
            }
        }
        
        /// <summary>
        /// Машин ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 МашинВРаботе
        {
            get
            {
				 NsgDataInteger __МашинВРаботе = ObjectList["МашинВРаботе"] as NsgDataInteger;
                 return (System.Int64)__МашинВРаботе.Value;
            }
            set
            {
                NsgDataInteger __МашинВРаботе = ObjectList["МашинВРаботе"] as NsgDataInteger;
                __МашинВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Машин не ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 МашинНеВРаботе
        {
            get
            {
				 NsgDataInteger __МашинНеВРаботе = ObjectList["МашинНеВРаботе"] as NsgDataInteger;
                 return (System.Int64)__МашинНеВРаботе.Value;
            }
            set
            {
                NsgDataInteger __МашинНеВРаботе = ObjectList["МашинНеВРаботе"] as NsgDataInteger;
                __МашинНеВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Машин сломано
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 МашинСломано
        {
            get
            {
				 NsgDataInteger __МашинСломано = ObjectList["МашинСломано"] as NsgDataInteger;
                 return (System.Int64)__МашинСломано.Value;
            }
            set
            {
                NsgDataInteger __МашинСломано = ObjectList["МашинСломано"] as NsgDataInteger;
                __МашинСломано.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица системы слежения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингОбъектыТаблицаСистемыСлежения ТаблицаСистемыСлежения
        {
            get
            {
				 NsgDataTableReference __ТаблицаСистемыСлежения = ObjectList["ТаблицаСистемыСлежения"] as NsgDataTableReference;
                 return (_SystemTables.МониторингОбъектыТаблицаСистемыСлежения)__ТаблицаСистемыСлежения.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаСистемыСлежения = ObjectList["ТаблицаСистемыСлежения"] as NsgDataTableReference;
                __ТаблицаСистемыСлежения.Referent = value;
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
        /// Договор ссылка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Договоры ДоговорСсылка
        {
            get
            {
				 NsgDataTypedReference __ДоговорСсылка = ObjectList["ДоговорСсылка"] as NsgDataTypedReference;
                 return (Мониторинг.Договоры)__ДоговорСсылка.Referent;
            }
            set
            {
                NsgDataTypedReference __ДоговорСсылка = ObjectList["ДоговорСсылка"] as NsgDataTypedReference;
                __ДоговорСсылка.Referent = value;
            }
        }
        
        /// <summary>
        /// Тип объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Справочники.ТипыОбъектов ТипОбъекта
        {
            get
            {
				 NsgDataTypedReference __ТипОбъекта = ObjectList["ТипОбъекта"] as NsgDataTypedReference;
                 return (Справочники.ТипыОбъектов)__ТипОбъекта.Referent;
            }
            set
            {
                NsgDataTypedReference __ТипОбъекта = ObjectList["ТипОбъекта"] as NsgDataTypedReference;
                __ТипОбъекта.Referent = value;
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
        /// Долгота
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Долгота
        {
            get
            {
				 NsgDataFloat __Долгота = ObjectList["Долгота"] as NsgDataFloat;
                 return (System.Decimal)__Долгота.Value;
            }
            set
            {
                NsgDataFloat __Долгота = ObjectList["Долгота"] as NsgDataFloat;
                __Долгота.Value = value;
            }
        }
        
        /// <summary>
        /// Площадь зданий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ПлощадьЗданий
        {
            get
            {
				 NsgDataFloat __ПлощадьЗданий = ObjectList["ПлощадьЗданий"] as NsgDataFloat;
                 return (System.Decimal)__ПлощадьЗданий.Value;
            }
            set
            {
                NsgDataFloat __ПлощадьЗданий = ObjectList["ПлощадьЗданий"] as NsgDataFloat;
                __ПлощадьЗданий.Value = value;
            }
        }
        
        /// <summary>
        /// Количество зданий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоЗданий
        {
            get
            {
				 NsgDataInteger __КоличествоЗданий = ObjectList["КоличествоЗданий"] as NsgDataInteger;
                 return (System.Int64)__КоличествоЗданий.Value;
            }
            set
            {
                NsgDataInteger __КоличествоЗданий = ObjectList["КоличествоЗданий"] as NsgDataInteger;
                __КоличествоЗданий.Value = value;
            }
        }
        
        /// <summary>
        /// Широта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Широта
        {
            get
            {
				 NsgDataFloat __Широта = ObjectList["Широта"] as NsgDataFloat;
                 return (System.Decimal)__Широта.Value;
            }
            set
            {
                NsgDataFloat __Широта = ObjectList["Широта"] as NsgDataFloat;
                __Широта.Value = value;
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
        /// Макс длительность смены часы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 МаксДлительностьСменыЧасы
        {
            get
            {
				 NsgDataInteger __МаксДлительностьСменыЧасы = ObjectList["МаксДлительностьСменыЧасы"] as NsgDataInteger;
                 return (System.Int64)__МаксДлительностьСменыЧасы.Value;
            }
            set
            {
                NsgDataInteger __МаксДлительностьСменыЧасы = ObjectList["МаксДлительностьСменыЧасы"] as NsgDataInteger;
                __МаксДлительностьСменыЧасы.Value = value;
            }
        }
        
        /// <summary>
        /// Автор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СлужебныеСправочники.ПользователиСервисов Автор
        {
            get
            {
				 NsgDataTypedReference __Автор = ObjectList["Автор"] as NsgDataTypedReference;
                 return (СлужебныеСправочники.ПользователиСервисов)__Автор.Referent;
            }
            set
            {
                NsgDataTypedReference __Автор = ObjectList["Автор"] as NsgDataTypedReference;
                __Автор.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата создания
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаСоздания
        {
            get
            {
				 NsgDataDateTime __ДатаСоздания = ObjectList["ДатаСоздания"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаСоздания.Value;
            }
            set
            {
                NsgDataDateTime __ДатаСоздания = ObjectList["ДатаСоздания"] as NsgDataDateTime;
                __ДатаСоздания.Value = value;
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
        public Объекты Родитель
        {
            get
            {
                return base.Parent as Объекты;
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
        private Объекты[] convertArray(NsgMultipleObject[] array)
        {
            Объекты[] res = new Объекты[array.Length];
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
        public new virtual Объекты[] FindAll(NsgCompare compare)
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
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Объекты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Объекты(this as NsgObject);
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
                base.NSGType = typeof(Объекты);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Объекты Value
            {
                get
                {
                    return (Объекты)base.Value;
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
