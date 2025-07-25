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
    
    [NsgTypeName("NsgDataDictionary", Guid = "bc382e52-39d0-4711-bb22-3297d8633fc9")]
    public partial class Техника : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Техника()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Техника(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Техника Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("bc382e52-39d0-4711-bb22-3297d8633fc9"));
            if (obj == null)
                obj = new Техника();
            return obj as Техника;
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
	Идентификатор.Guid = NsgService.StringToGuid("e404c770-5e40-4355-a4ea-164f2dff299e");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("d464fd3d-9596-4e21-9548-29e0b0789cce");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("200b3b3b-7184-4de4-993a-7066d15e490e");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("24a82c5e-5348-48bb-ad0f-0d216f38eeb4");
	
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
	Уровень.Guid = NsgService.StringToGuid("1286ed97-04a3-497a-8f53-239e2d14bc37");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("a3f29bd0-f060-48b5-b545-03fa939fcdb0");
	
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
	НомерКода.Guid = NsgService.StringToGuid("ee277103-2694-42e5-ad12-ef5c6f1b1ebc");
	
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
	Код.Guid = NsgService.StringToGuid("38b99e4e-50d2-41ac-8728-cbdb31bac39e");
	
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
	Наименование.Guid = NsgService.StringToGuid("04ffa3ba-1f07-4e6e-8099-f2c351980213");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("7dcd5cad-95ca-40fe-bc0f-2b3c52f9d077");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Мониторинг.Марка Марка
			{  
                NsgDataTypedReference Марка = null;
				if (ObjectList.Contains("Марка"))
                    Марка = ObjectList["Марка"] as NsgDataTypedReference;
                else
                    Марка = new NsgDataTypedReference();
	//NsgDataTypedReference
	Марка.IsLoadedFromDll = true;
	Марка.ReferentGroup = "Мониторинг";
	Марка.ReferentName = "Марка";
	Марка.SaveInDatabase = true;
	Марка.OwnerName = "";
	Марка.AllowEmptyOwner = false;
	Марка.StringFormat = "";
	Марка.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Марка.IncludeInPredefined = false;
	Марка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Марка.Required = false;
	Марка.EmptyValue = "";
	Марка.NullAllow = false;
	Марка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Марка.FieldName = "Marka";
	Марка.InformMetaDataOnValueChanged = false;
	Марка.Visible = true;
	Марка.Name = "Марка";
	Марка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Марка.Description = "Марка";
	Марка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Марка.GroupName = "";
	Марка.Guid = NsgService.StringToGuid("af4a0b0b-6f0c-480d-b5c4-3d090805425d");
	
				if (!ObjectList.Contains("Марка"))
                    ObjectList.Add(Марка);
			}
			#endregion //создание Мониторинг.Марка Марка
			
			#region создание Мониторинг.Модель Модель
			{  
                NsgDataTypedReference Модель = null;
				if (ObjectList.Contains("Модель"))
                    Модель = ObjectList["Модель"] as NsgDataTypedReference;
                else
                    Модель = new NsgDataTypedReference();
	//NsgDataTypedReference
	Модель.IsLoadedFromDll = true;
	Модель.ReferentGroup = "Мониторинг";
	Модель.ReferentName = "Модель";
	Модель.SaveInDatabase = true;
	Модель.OwnerName = "Марка";
	Модель.AllowEmptyOwner = false;
	Модель.StringFormat = "";
	Модель.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Модель.IncludeInPredefined = false;
	Модель.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Модель.Required = false;
	Модель.EmptyValue = "";
	Модель.NullAllow = false;
	Модель.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Модель.FieldName = "Model";
	Модель.InformMetaDataOnValueChanged = false;
	Модель.Visible = true;
	Модель.Name = "Модель";
	Модель.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Модель.Description = "Модель";
	Модель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Модель.GroupName = "";
	Модель.Guid = NsgService.StringToGuid("5f83ede7-6183-4125-8fe0-865cc54e9a5e");
	
				if (!ObjectList.Contains("Модель"))
                    ObjectList.Add(Модель);
			}
			#endregion //создание Мониторинг.Модель Модель
			
			#region создание TechControl.Метаданные.Мониторинг.ТехникаФормаСписка ФормаСписка
			{  
                NsgDataForm ФормаСписка = null;
				if (ObjectList.Contains("ФормаСписка"))
                    ФормаСписка = ObjectList["ФормаСписка"] as NsgDataForm;
                else
                    ФормаСписка = new NsgDataForm();
	//NsgDataForm
	ФормаСписка.IsLoadedFromDll = true;
	ФормаСписка.FormClassName = "TechControl.Метаданные.Мониторинг.ТехникаФормаСписка";
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
	ФормаСписка.Guid = NsgService.StringToGuid("3b0e1055-363b-4218-9dba-edf2494f1e08");
	
				if (!ObjectList.Contains("ФормаСписка"))
                    ObjectList.Add(ФормаСписка);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ТехникаФормаСписка ФормаСписка
			
			#region создание TechControl.Метаданные.Мониторинг.ТехникаФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ТехникаФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("6414f41d-b43c-4998-8404-c36b3aa0341c");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ТехникаФормаЭлемента ФормаЭлемента
			
			#region создание System.String ГодВыпуска
			{  
                NsgDataString ГодВыпуска = null;
				if (ObjectList.Contains("ГодВыпуска"))
                    ГодВыпуска = ObjectList["ГодВыпуска"] as NsgDataString;
                else
                    ГодВыпуска = new NsgDataString();
	//NsgDataString
	ГодВыпуска.IsLoadedFromDll = true;
	ГодВыпуска.Length = 50;
	ГодВыпуска.StringFormat = "";
	ГодВыпуска.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГодВыпуска.IncludeInPredefined = false;
	ГодВыпуска.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГодВыпуска.Required = false;
	ГодВыпуска.EmptyValue = "";
	ГодВыпуска.NullAllow = false;
	ГодВыпуска.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГодВыпуска.FieldName = "GodVypuska";
	ГодВыпуска.SaveInDatabase = true;
	ГодВыпуска.InformMetaDataOnValueChanged = false;
	ГодВыпуска.Visible = true;
	ГодВыпуска.Name = "ГодВыпуска";
	ГодВыпуска.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГодВыпуска.Description = "Год выпуска";
	ГодВыпуска.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГодВыпуска.GroupName = "";
	ГодВыпуска.Guid = NsgService.StringToGuid("587b5917-1a38-4e80-8346-34e583fb1d09");
	
				if (!ObjectList.Contains("ГодВыпуска"))
                    ObjectList.Add(ГодВыпуска);
			}
			#endregion //создание System.String ГодВыпуска
			
			#region создание System.String ГосНомер
			{  
                NsgDataString ГосНомер = null;
				if (ObjectList.Contains("ГосНомер"))
                    ГосНомер = ObjectList["ГосНомер"] as NsgDataString;
                else
                    ГосНомер = new NsgDataString();
	//NsgDataString
	ГосНомер.IsLoadedFromDll = true;
	ГосНомер.Length = 50;
	ГосНомер.StringFormat = "";
	ГосНомер.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГосНомер.IncludeInPredefined = false;
	ГосНомер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГосНомер.Required = false;
	ГосНомер.EmptyValue = "";
	ГосНомер.NullAllow = false;
	ГосНомер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГосНомер.FieldName = "GosNomer";
	ГосНомер.SaveInDatabase = true;
	ГосНомер.InformMetaDataOnValueChanged = false;
	ГосНомер.Visible = true;
	ГосНомер.Name = "ГосНомер";
	ГосНомер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГосНомер.Description = "Гос номер";
	ГосНомер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГосНомер.GroupName = "";
	ГосНомер.Guid = NsgService.StringToGuid("f3214964-69b1-4152-9c7f-efce8644f09e");
	
				if (!ObjectList.Contains("ГосНомер"))
                    ObjectList.Add(ГосНомер);
			}
			#endregion //создание System.String ГосНомер
			
			#region создание Мониторинг.Контрагенты Подрядчик
			{  
                NsgDataTypedReference Подрядчик = null;
				if (ObjectList.Contains("Подрядчик"))
                    Подрядчик = ObjectList["Подрядчик"] as NsgDataTypedReference;
                else
                    Подрядчик = new NsgDataTypedReference();
	//NsgDataTypedReference
	Подрядчик.IsLoadedFromDll = true;
	Подрядчик.ReferentGroup = "Мониторинг";
	Подрядчик.ReferentName = "Контрагенты";
	Подрядчик.SaveInDatabase = true;
	Подрядчик.OwnerName = "";
	Подрядчик.AllowEmptyOwner = false;
	Подрядчик.StringFormat = "";
	Подрядчик.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Подрядчик.IncludeInPredefined = false;
	Подрядчик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Подрядчик.Required = false;
	Подрядчик.EmptyValue = "";
	Подрядчик.NullAllow = false;
	Подрядчик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Подрядчик.FieldName = "Podrjadchik";
	Подрядчик.InformMetaDataOnValueChanged = false;
	Подрядчик.Visible = true;
	Подрядчик.Name = "Подрядчик";
	Подрядчик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Подрядчик.Description = "Подрядчик";
	Подрядчик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Подрядчик.GroupName = "";
	Подрядчик.Guid = NsgService.StringToGuid("cc413778-c79c-4586-ab52-eb10debc2f7e");
	
				if (!ObjectList.Contains("Подрядчик"))
                    ObjectList.Add(Подрядчик);
			}
			#endregion //создание Мониторинг.Контрагенты Подрядчик
			
			#region создание System.String Номер
			{  
                NsgDataString Номер = null;
				if (ObjectList.Contains("Номер"))
                    Номер = ObjectList["Номер"] as NsgDataString;
                else
                    Номер = new NsgDataString();
	//NsgDataString
	Номер.IsLoadedFromDll = true;
	Номер.Length = 50;
	Номер.StringFormat = "";
	Номер.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Номер.IncludeInPredefined = false;
	Номер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Номер.Required = false;
	Номер.EmptyValue = "";
	Номер.NullAllow = false;
	Номер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Номер.FieldName = "Nomer";
	Номер.SaveInDatabase = true;
	Номер.InformMetaDataOnValueChanged = false;
	Номер.Visible = true;
	Номер.Name = "Номер";
	Номер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Номер.Description = "Номер";
	Номер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Номер.GroupName = "";
	Номер.Guid = NsgService.StringToGuid("2fc91d8b-81a8-4bdf-ac2a-14a488778ac6");
	
				if (!ObjectList.Contains("Номер"))
                    ObjectList.Add(Номер);
			}
			#endregion //создание System.String Номер
			
			#region создание System.Decimal НормативныйРасходТоплива
			{  
                NsgDataFloat НормативныйРасходТоплива = null;
				if (ObjectList.Contains("НормативныйРасходТоплива"))
                    НормативныйРасходТоплива = ObjectList["НормативныйРасходТоплива"] as NsgDataFloat;
                else
                    НормативныйРасходТоплива = new NsgDataFloat();
	//NsgDataFloat
	НормативныйРасходТоплива.IsLoadedFromDll = true;
	НормативныйРасходТоплива.Precision = 2;
	НормативныйРасходТоплива.HideZero = true;
	НормативныйРасходТоплива.DefaultValue = 0M;
	НормативныйРасходТоплива.MinValue = -100000000000000000M;
	НормативныйРасходТоплива.MaxValue = 100000000000000000M;
	НормативныйРасходТоплива.UseCalculator = true;
	НормативныйРасходТоплива.StringFormat = "";
	НормативныйРасходТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НормативныйРасходТоплива.IncludeInPredefined = false;
	НормативныйРасходТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НормативныйРасходТоплива.Required = false;
	НормативныйРасходТоплива.EmptyValue = "";
	НормативныйРасходТоплива.NullAllow = false;
	НормативныйРасходТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НормативныйРасходТоплива.FieldName = "NormativnyijRaskh";
	НормативныйРасходТоплива.SaveInDatabase = true;
	НормативныйРасходТоплива.InformMetaDataOnValueChanged = false;
	НормативныйРасходТоплива.Visible = true;
	НормативныйРасходТоплива.Name = "НормативныйРасходТоплива";
	НормативныйРасходТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НормативныйРасходТоплива.Description = "Нормативный расход топлива";
	НормативныйРасходТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НормативныйРасходТоплива.GroupName = "";
	НормативныйРасходТоплива.Guid = NsgService.StringToGuid("358f0604-cf32-45ce-a1b1-a275a4af2b1f");
	
				if (!ObjectList.Contains("НормативныйРасходТоплива"))
                    ObjectList.Add(НормативныйРасходТоплива);
			}
			#endregion //создание System.Decimal НормативныйРасходТоплива
			
			#region создание System.Decimal ОбъемТопливногоБака
			{  
                NsgDataFloat ОбъемТопливногоБака = null;
				if (ObjectList.Contains("ОбъемТопливногоБака"))
                    ОбъемТопливногоБака = ObjectList["ОбъемТопливногоБака"] as NsgDataFloat;
                else
                    ОбъемТопливногоБака = new NsgDataFloat();
	//NsgDataFloat
	ОбъемТопливногоБака.IsLoadedFromDll = true;
	ОбъемТопливногоБака.Precision = 2;
	ОбъемТопливногоБака.HideZero = true;
	ОбъемТопливногоБака.DefaultValue = 0M;
	ОбъемТопливногоБака.MinValue = -100000000000000000M;
	ОбъемТопливногоБака.MaxValue = 100000000000000000M;
	ОбъемТопливногоБака.UseCalculator = true;
	ОбъемТопливногоБака.StringFormat = "";
	ОбъемТопливногоБака.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбъемТопливногоБака.IncludeInPredefined = false;
	ОбъемТопливногоБака.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъемТопливногоБака.Required = false;
	ОбъемТопливногоБака.EmptyValue = "";
	ОбъемТопливногоБака.NullAllow = false;
	ОбъемТопливногоБака.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъемТопливногоБака.FieldName = "ObemToplivnogoBaka";
	ОбъемТопливногоБака.SaveInDatabase = true;
	ОбъемТопливногоБака.InformMetaDataOnValueChanged = false;
	ОбъемТопливногоБака.Visible = true;
	ОбъемТопливногоБака.Name = "ОбъемТопливногоБака";
	ОбъемТопливногоБака.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъемТопливногоБака.Description = "Объем топливного бака";
	ОбъемТопливногоБака.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъемТопливногоБака.GroupName = "";
	ОбъемТопливногоБака.Guid = NsgService.StringToGuid("a6cde7b1-cb41-4fba-8877-079dbb58b36f");
	
				if (!ObjectList.Contains("ОбъемТопливногоБака"))
                    ObjectList.Add(ОбъемТопливногоБака);
			}
			#endregion //создание System.Decimal ОбъемТопливногоБака
			
			#region создание System.String Примечание
			{  
                NsgDataString Примечание = null;
				if (ObjectList.Contains("Примечание"))
                    Примечание = ObjectList["Примечание"] as NsgDataString;
                else
                    Примечание = new NsgDataString();
	//NsgDataString
	Примечание.IsLoadedFromDll = true;
	Примечание.Length = 100;
	Примечание.StringFormat = "";
	Примечание.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Примечание.IncludeInPredefined = false;
	Примечание.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Примечание.Required = false;
	Примечание.EmptyValue = "";
	Примечание.NullAllow = false;
	Примечание.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Примечание.FieldName = "Primechanie";
	Примечание.SaveInDatabase = true;
	Примечание.InformMetaDataOnValueChanged = false;
	Примечание.Visible = true;
	Примечание.Name = "Примечание";
	Примечание.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Примечание.Description = "Примечание";
	Примечание.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Примечание.GroupName = "";
	Примечание.Guid = NsgService.StringToGuid("44b221b4-19dd-4646-a3fc-f8ab1198ee50");
	
				if (!ObjectList.Contains("Примечание"))
                    ObjectList.Add(Примечание);
			}
			#endregion //создание System.String Примечание
			
			#region создание Мониторинг.СтатусТехники Статус
			{  
                NsgDataEnumReference Статус = null;
				if (ObjectList.Contains("Статус"))
                    Статус = ObjectList["Статус"] as NsgDataEnumReference;
                else
                    Статус = new NsgDataEnumReference();
	//NsgDataEnumReference
	Статус.IsLoadedFromDll = true;
	Статус.ReferentGroup = "Мониторинг";
	Статус.ReferentName = "СтатусТехники";
	Статус.SaveInDatabase = true;
	Статус.OwnerName = "";
	Статус.AllowEmptyOwner = false;
	Статус.StringFormat = "";
	Статус.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Статус.IncludeInPredefined = false;
	Статус.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Статус.Required = false;
	Статус.EmptyValue = "";
	Статус.NullAllow = false;
	Статус.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Статус.FieldName = "Status";
	Статус.InformMetaDataOnValueChanged = false;
	Статус.Visible = true;
	Статус.Name = "Статус";
	Статус.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Статус.Description = "Статус";
	Статус.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Статус.GroupName = "";
	Статус.Guid = NsgService.StringToGuid("f7b61854-3f4b-4253-a4e5-84436ec850e0");
	
				if (!ObjectList.Contains("Статус"))
                    ObjectList.Add(Статус);
			}
			#endregion //создание Мониторинг.СтатусТехники Статус
			
			#region создание _SystemTables.МониторингТехникаТарифы Тарифы
			{  
                NsgDataTableReference Тарифы = null;
				if (ObjectList.Contains("Тарифы"))
                    Тарифы = ObjectList["Тарифы"] as NsgDataTableReference;
                else
                    Тарифы = new NsgDataTableReference();
	//NsgDataTableReference
	Тарифы.IsLoadedFromDll = true;
	Тарифы.Name = "Тарифы";
	Тарифы.SaveInDatabase = false;
	Тарифы.ReferentGroup = "_SystemTables";
	Тарифы.ReferentName = "МониторингТехникаТарифы";
	Тарифы.OwnerName = "";
	Тарифы.AllowEmptyOwner = false;
	Тарифы.StringFormat = "";
	Тарифы.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	Тарифы.IncludeInPredefined = false;
	Тарифы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Тарифы.Required = false;
	Тарифы.EmptyValue = "";
	Тарифы.NullAllow = false;
	Тарифы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Тарифы.FieldName = "Tarify";
	Тарифы.InformMetaDataOnValueChanged = false;
	Тарифы.Visible = true;
	Тарифы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Тарифы.Description = "Тарифы";
	Тарифы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Тарифы.GroupName = "";
	Тарифы.Guid = NsgService.StringToGuid("17a55261-7cb9-4d32-918d-73de98f13081");
	
				if (!ObjectList.Contains("Тарифы"))
                    ObjectList.Add(Тарифы);
			}
			#endregion //создание _SystemTables.МониторингТехникаТарифы Тарифы
			
			#region создание Мониторинг.ТипСобственности ТипСобственности
			{  
                NsgDataEnumReference ТипСобственности = null;
				if (ObjectList.Contains("ТипСобственности"))
                    ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                else
                    ТипСобственности = new NsgDataEnumReference();
	//NsgDataEnumReference
	ТипСобственности.IsLoadedFromDll = true;
	ТипСобственности.ReferentGroup = "Мониторинг";
	ТипСобственности.ReferentName = "ТипСобственности";
	ТипСобственности.SaveInDatabase = true;
	ТипСобственности.OwnerName = "";
	ТипСобственности.AllowEmptyOwner = false;
	ТипСобственности.StringFormat = "";
	ТипСобственности.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТипСобственности.IncludeInPredefined = false;
	ТипСобственности.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипСобственности.Required = false;
	ТипСобственности.EmptyValue = "";
	ТипСобственности.NullAllow = false;
	ТипСобственности.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипСобственности.FieldName = "TipSobstvennosti";
	ТипСобственности.InformMetaDataOnValueChanged = false;
	ТипСобственности.Visible = true;
	ТипСобственности.Name = "ТипСобственности";
	ТипСобственности.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипСобственности.Description = "Тип собственности";
	ТипСобственности.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипСобственности.GroupName = "";
	ТипСобственности.Guid = NsgService.StringToGuid("68e74016-c0b5-47e0-96d8-413bc3ada5ea");
	
				if (!ObjectList.Contains("ТипСобственности"))
                    ObjectList.Add(ТипСобственности);
			}
			#endregion //создание Мониторинг.ТипСобственности ТипСобственности
			
			#region создание Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
			{  
                NsgDataTypedReference ГруппаСпецТехники = null;
				if (ObjectList.Contains("ГруппаСпецТехники"))
                    ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                else
                    ГруппаСпецТехники = new NsgDataTypedReference();
	//NsgDataTypedReference
	ГруппаСпецТехники.IsLoadedFromDll = true;
	ГруппаСпецТехники.ReferentGroup = "Мониторинг";
	ГруппаСпецТехники.ReferentName = "ГруппыСпецТехники";
	ГруппаСпецТехники.SaveInDatabase = true;
	ГруппаСпецТехники.OwnerName = "";
	ГруппаСпецТехники.AllowEmptyOwner = false;
	ГруппаСпецТехники.StringFormat = "";
	ГруппаСпецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ГруппаСпецТехники.IncludeInPredefined = false;
	ГруппаСпецТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГруппаСпецТехники.Required = false;
	ГруппаСпецТехники.EmptyValue = "";
	ГруппаСпецТехники.NullAllow = false;
	ГруппаСпецТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГруппаСпецТехники.FieldName = "GruppaSpecTekhniki";
	ГруппаСпецТехники.InformMetaDataOnValueChanged = false;
	ГруппаСпецТехники.Visible = true;
	ГруппаСпецТехники.Name = "ГруппаСпецТехники";
	ГруппаСпецТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГруппаСпецТехники.Description = "Группа спец техники";
	ГруппаСпецТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГруппаСпецТехники.GroupName = "";
	ГруппаСпецТехники.Guid = NsgService.StringToGuid("8139e01a-9470-480a-b3fc-f94b69491a0d");
	
				if (!ObjectList.Contains("ГруппаСпецТехники"))
                    ObjectList.Add(ГруппаСпецТехники);
			}
			#endregion //создание Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
			
			#region создание _SystemTables.МониторингТехникаСистемыСлежения СистемыСлежения
			{  
                NsgDataTableReference СистемыСлежения = null;
				if (ObjectList.Contains("СистемыСлежения"))
                    СистемыСлежения = ObjectList["СистемыСлежения"] as NsgDataTableReference;
                else
                    СистемыСлежения = new NsgDataTableReference();
	//NsgDataTableReference
	СистемыСлежения.IsLoadedFromDll = true;
	СистемыСлежения.Name = "СистемыСлежения";
	СистемыСлежения.SaveInDatabase = false;
	СистемыСлежения.ReferentGroup = "_SystemTables";
	СистемыСлежения.ReferentName = "МониторингТехникаСистемыСлежения";
	СистемыСлежения.OwnerName = "";
	СистемыСлежения.AllowEmptyOwner = false;
	СистемыСлежения.StringFormat = "";
	СистемыСлежения.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	СистемыСлежения.IncludeInPredefined = false;
	СистемыСлежения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СистемыСлежения.Required = false;
	СистемыСлежения.EmptyValue = "";
	СистемыСлежения.NullAllow = false;
	СистемыСлежения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СистемыСлежения.FieldName = "SistemySlezhenija";
	СистемыСлежения.InformMetaDataOnValueChanged = false;
	СистемыСлежения.Visible = true;
	СистемыСлежения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СистемыСлежения.Description = "Системы слежения";
	СистемыСлежения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СистемыСлежения.GroupName = "";
	СистемыСлежения.Guid = NsgService.StringToGuid("3e9efacd-c6cb-45f3-9ed8-c50d5ea82b9f");
	
				if (!ObjectList.Contains("СистемыСлежения"))
                    ObjectList.Add(СистемыСлежения);
			}
			#endregion //создание _SystemTables.МониторингТехникаСистемыСлежения СистемыСлежения
			
			#region создание System.Int64 Иконка
			{  
                NsgDataInteger Иконка = null;
				if (ObjectList.Contains("Иконка"))
                    Иконка = ObjectList["Иконка"] as NsgDataInteger;
                else
                    Иконка = new NsgDataInteger();
	//NsgDataInteger
	Иконка.IsLoadedFromDll = true;
	Иконка.DefaultValue = 0M;
	Иконка.MinValue = 0M;
	Иконка.MaxValue = 0M;
	Иконка.UseCalculator = true;
	Иконка.StringFormat = "";
	Иконка.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Иконка.IncludeInPredefined = false;
	Иконка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Иконка.Required = false;
	Иконка.EmptyValue = "";
	Иконка.NullAllow = false;
	Иконка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Иконка.FieldName = "Ikonka";
	Иконка.SaveInDatabase = true;
	Иконка.InformMetaDataOnValueChanged = false;
	Иконка.Visible = true;
	Иконка.Name = "Иконка";
	Иконка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Иконка.Description = "Иконка";
	Иконка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Иконка.GroupName = "";
	Иконка.Guid = NsgService.StringToGuid("227f44da-1a1b-4574-b492-771b0c28fafa");
	
				if (!ObjectList.Contains("Иконка"))
                    ObjectList.Add(Иконка);
			}
			#endregion //создание System.Int64 Иконка
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("e4a324c0-7f0b-4b96-a4b6-66773fa6e19a");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.Boolean ОтслеживатьХодки
			{  
                NsgDataBoolean ОтслеживатьХодки = null;
				if (ObjectList.Contains("ОтслеживатьХодки"))
                    ОтслеживатьХодки = ObjectList["ОтслеживатьХодки"] as NsgDataBoolean;
                else
                    ОтслеживатьХодки = new NsgDataBoolean();
	//NsgDataBoolean
	ОтслеживатьХодки.IsLoadedFromDll = true;
	ОтслеживатьХодки.DefaultValue = false;
	ОтслеживатьХодки.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОтслеживатьХодки.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОтслеживатьХодки.StringFormat = "";
	ОтслеживатьХодки.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОтслеживатьХодки.IncludeInPredefined = false;
	ОтслеживатьХодки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОтслеживатьХодки.Required = false;
	ОтслеживатьХодки.EmptyValue = "";
	ОтслеживатьХодки.NullAllow = false;
	ОтслеживатьХодки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОтслеживатьХодки.FieldName = "OtslezhivatKHodki";
	ОтслеживатьХодки.SaveInDatabase = true;
	ОтслеживатьХодки.InformMetaDataOnValueChanged = false;
	ОтслеживатьХодки.Visible = true;
	ОтслеживатьХодки.Name = "ОтслеживатьХодки";
	ОтслеживатьХодки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОтслеживатьХодки.Description = "Отслеживать ходки";
	ОтслеживатьХодки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОтслеживатьХодки.GroupName = "";
	ОтслеживатьХодки.Guid = NsgService.StringToGuid("f5fcea2e-523c-4786-a292-f1380dda8652");
	
				if (!ObjectList.Contains("ОтслеживатьХодки"))
                    ObjectList.Add(ОтслеживатьХодки);
			}
			#endregion //создание System.Boolean ОтслеживатьХодки
			
			#region создание _SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности ТаблицаДопущенныеДоУправленияДолжности
			{  
                NsgDataTableReference ТаблицаДопущенныеДоУправленияДолжности = null;
				if (ObjectList.Contains("ТаблицаДопущенныеДоУправленияДолжности"))
                    ТаблицаДопущенныеДоУправленияДолжности = ObjectList["ТаблицаДопущенныеДоУправленияДолжности"] as NsgDataTableReference;
                else
                    ТаблицаДопущенныеДоУправленияДолжности = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаДопущенныеДоУправленияДолжности.IsLoadedFromDll = true;
	ТаблицаДопущенныеДоУправленияДолжности.Name = "ТаблицаДопущенныеДоУправленияДолжности";
	ТаблицаДопущенныеДоУправленияДолжности.SaveInDatabase = false;
	ТаблицаДопущенныеДоУправленияДолжности.ReferentGroup = "_SystemTables";
	ТаблицаДопущенныеДоУправленияДолжности.ReferentName = "МониторингТехникаТаблицаДопущенныеДоУправленияДолжности";
	ТаблицаДопущенныеДоУправленияДолжности.OwnerName = "";
	ТаблицаДопущенныеДоУправленияДолжности.AllowEmptyOwner = false;
	ТаблицаДопущенныеДоУправленияДолжности.StringFormat = "";
	ТаблицаДопущенныеДоУправленияДолжности.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаДопущенныеДоУправленияДолжности.IncludeInPredefined = false;
	ТаблицаДопущенныеДоУправленияДолжности.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаДопущенныеДоУправленияДолжности.Required = false;
	ТаблицаДопущенныеДоУправленияДолжности.EmptyValue = "";
	ТаблицаДопущенныеДоУправленияДолжности.NullAllow = false;
	ТаблицаДопущенныеДоУправленияДолжности.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаДопущенныеДоУправленияДолжности.FieldName = "TablicaDopuschenn";
	ТаблицаДопущенныеДоУправленияДолжности.InformMetaDataOnValueChanged = false;
	ТаблицаДопущенныеДоУправленияДолжности.Visible = true;
	ТаблицаДопущенныеДоУправленияДолжности.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаДопущенныеДоУправленияДолжности.Description = "Таблица допущенные до управления должности";
	ТаблицаДопущенныеДоУправленияДолжности.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаДопущенныеДоУправленияДолжности.GroupName = "";
	ТаблицаДопущенныеДоУправленияДолжности.Guid = NsgService.StringToGuid("32277a49-c710-4e7d-b488-23ba59787c43");
	
				if (!ObjectList.Contains("ТаблицаДопущенныеДоУправленияДолжности"))
                    ObjectList.Add(ТаблицаДопущенныеДоУправленияДолжности);
			}
			#endregion //создание _SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности ТаблицаДопущенныеДоУправленияДолжности
			
			#region создание System.Decimal ПолезныйОбъемМКуб
			{  
                NsgDataFloat ПолезныйОбъемМКуб = null;
				if (ObjectList.Contains("ПолезныйОбъемМКуб"))
                    ПолезныйОбъемМКуб = ObjectList["ПолезныйОбъемМКуб"] as NsgDataFloat;
                else
                    ПолезныйОбъемМКуб = new NsgDataFloat();
	//NsgDataFloat
	ПолезныйОбъемМКуб.IsLoadedFromDll = true;
	ПолезныйОбъемМКуб.Precision = 2;
	ПолезныйОбъемМКуб.HideZero = true;
	ПолезныйОбъемМКуб.DefaultValue = 0M;
	ПолезныйОбъемМКуб.MinValue = -100000000000000000M;
	ПолезныйОбъемМКуб.MaxValue = 100000000000000000M;
	ПолезныйОбъемМКуб.UseCalculator = true;
	ПолезныйОбъемМКуб.StringFormat = "";
	ПолезныйОбъемМКуб.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПолезныйОбъемМКуб.IncludeInPredefined = false;
	ПолезныйОбъемМКуб.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПолезныйОбъемМКуб.Required = false;
	ПолезныйОбъемМКуб.EmptyValue = "";
	ПолезныйОбъемМКуб.NullAllow = false;
	ПолезныйОбъемМКуб.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПолезныйОбъемМКуб.FieldName = "PoleznyijObemMKub";
	ПолезныйОбъемМКуб.SaveInDatabase = true;
	ПолезныйОбъемМКуб.InformMetaDataOnValueChanged = false;
	ПолезныйОбъемМКуб.Visible = true;
	ПолезныйОбъемМКуб.Name = "ПолезныйОбъемМКуб";
	ПолезныйОбъемМКуб.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПолезныйОбъемМКуб.Description = "Полезный объем МКуб";
	ПолезныйОбъемМКуб.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПолезныйОбъемМКуб.GroupName = "";
	ПолезныйОбъемМКуб.Guid = NsgService.StringToGuid("f367ed54-f6d5-42f5-924d-fa895ff7cd48");
	
				if (!ObjectList.Contains("ПолезныйОбъемМКуб"))
                    ObjectList.Add(ПолезныйОбъемМКуб);
			}
			#endregion //создание System.Decimal ПолезныйОбъемМКуб
			
			#region создание Мониторинг.ВидыКузовов ВидКузова
			{  
                NsgDataTypedReference ВидКузова = null;
				if (ObjectList.Contains("ВидКузова"))
                    ВидКузова = ObjectList["ВидКузова"] as NsgDataTypedReference;
                else
                    ВидКузова = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидКузова.IsLoadedFromDll = true;
	ВидКузова.ReferentGroup = "Мониторинг";
	ВидКузова.ReferentName = "ВидыКузовов";
	ВидКузова.SaveInDatabase = true;
	ВидКузова.OwnerName = "";
	ВидКузова.AllowEmptyOwner = false;
	ВидКузова.StringFormat = "";
	ВидКузова.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВидКузова.IncludeInPredefined = false;
	ВидКузова.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидКузова.Required = false;
	ВидКузова.EmptyValue = "";
	ВидКузова.NullAllow = false;
	ВидКузова.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидКузова.FieldName = "VidKuzova";
	ВидКузова.InformMetaDataOnValueChanged = false;
	ВидКузова.Visible = true;
	ВидКузова.Name = "ВидКузова";
	ВидКузова.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидКузова.Description = "Вид кузова";
	ВидКузова.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидКузова.GroupName = "";
	ВидКузова.Guid = NsgService.StringToGuid("1843a194-498b-49e6-b7cf-43cdd5c20c57");
	
				if (!ObjectList.Contains("ВидКузова"))
                    ObjectList.Add(ВидКузова);
			}
			#endregion //создание Мониторинг.ВидыКузовов ВидКузова
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Техника";
	Visible = true;
	Guid = NsgService.StringToGuid("bc382e52-39d0-4711-bb22-3297d8633fc9");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Tekhnika";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Техника";
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
            /// Марка
            /// </summary>
            public static String Марка
            {
                get
                {
                    return "Марка";
                }
            }
            
            /// <summary>
            /// Модель
            /// </summary>
            public static String Модель
            {
                get
                {
                    return "Модель";
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
            /// Год выпуска
            /// </summary>
            public static String ГодВыпуска
            {
                get
                {
                    return "ГодВыпуска";
                }
            }
            
            /// <summary>
            /// Гос номер
            /// </summary>
            public static String ГосНомер
            {
                get
                {
                    return "ГосНомер";
                }
            }
            
            /// <summary>
            /// Подрядчик
            /// </summary>
            public static String Подрядчик
            {
                get
                {
                    return "Подрядчик";
                }
            }
            
            /// <summary>
            /// Номер
            /// </summary>
            public static String Номер
            {
                get
                {
                    return "Номер";
                }
            }
            
            /// <summary>
            /// Нормативный расход топлива
            /// </summary>
            public static String НормативныйРасходТоплива
            {
                get
                {
                    return "НормативныйРасходТоплива";
                }
            }
            
            /// <summary>
            /// Объем топливного бака
            /// </summary>
            public static String ОбъемТопливногоБака
            {
                get
                {
                    return "ОбъемТопливногоБака";
                }
            }
            
            /// <summary>
            /// Примечание
            /// </summary>
            public static String Примечание
            {
                get
                {
                    return "Примечание";
                }
            }
            
            /// <summary>
            /// Статус
            /// </summary>
            public static String Статус
            {
                get
                {
                    return "Статус";
                }
            }
            
            /// <summary>
            /// Тарифы
            /// </summary>
            public static String Тарифы
            {
                get
                {
                    return "Тарифы";
                }
            }
            
            /// <summary>
            /// Тип собственности
            /// </summary>
            public static String ТипСобственности
            {
                get
                {
                    return "ТипСобственности";
                }
            }
            
            /// <summary>
            /// Группа спец техники
            /// </summary>
            public static String ГруппаСпецТехники
            {
                get
                {
                    return "ГруппаСпецТехники";
                }
            }
            
            /// <summary>
            /// Системы слежения
            /// </summary>
            public static String СистемыСлежения
            {
                get
                {
                    return "СистемыСлежения";
                }
            }
            
            /// <summary>
            /// Иконка
            /// </summary>
            public static String Иконка
            {
                get
                {
                    return "Иконка";
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
            /// Отслеживать ходки
            /// </summary>
            public static String ОтслеживатьХодки
            {
                get
                {
                    return "ОтслеживатьХодки";
                }
            }
            
            /// <summary>
            /// Таблица допущенные до управления должности
            /// </summary>
            public static String ТаблицаДопущенныеДоУправленияДолжности
            {
                get
                {
                    return "ТаблицаДопущенныеДоУправленияДолжности";
                }
            }
            
            /// <summary>
            /// Полезный объем МКуб
            /// </summary>
            public static String ПолезныйОбъемМКуб
            {
                get
                {
                    return "ПолезныйОбъемМКуб";
                }
            }
            
            /// <summary>
            /// Вид кузова
            /// </summary>
            public static String ВидКузова
            {
                get
                {
                    return "ВидКузова";
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
                    descriptor.Name = "Техника";
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
            return "Мониторинг.Техника";
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
        /// Марка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Марка Марка
        {
            get
            {
				 NsgDataTypedReference __Марка = ObjectList["Марка"] as NsgDataTypedReference;
                 return (Мониторинг.Марка)__Марка.Referent;
            }
            set
            {
                NsgDataTypedReference __Марка = ObjectList["Марка"] as NsgDataTypedReference;
                __Марка.Referent = value;
            }
        }
        
        /// <summary>
        /// Модель
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Модель Модель
        {
            get
            {
				 NsgDataTypedReference __Модель = ObjectList["Модель"] as NsgDataTypedReference;
                 return (Мониторинг.Модель)__Модель.Referent;
            }
            set
            {
                NsgDataTypedReference __Модель = ObjectList["Модель"] as NsgDataTypedReference;
                __Модель.Referent = value;
            }
        }
        
        /// <summary>
        /// Год выпуска
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ГодВыпуска
        {
            get
            {
				 NsgDataString __ГодВыпуска = ObjectList["ГодВыпуска"] as NsgDataString;
                 return (System.String)__ГодВыпуска.Value;
            }
            set
            {
                NsgDataString __ГодВыпуска = ObjectList["ГодВыпуска"] as NsgDataString;
                __ГодВыпуска.Value = value;
            }
        }
        
        /// <summary>
        /// Гос номер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ГосНомер
        {
            get
            {
				 NsgDataString __ГосНомер = ObjectList["ГосНомер"] as NsgDataString;
                 return (System.String)__ГосНомер.Value;
            }
            set
            {
                NsgDataString __ГосНомер = ObjectList["ГосНомер"] as NsgDataString;
                __ГосНомер.Value = value;
            }
        }
        
        /// <summary>
        /// Подрядчик
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Подрядчик
        {
            get
            {
				 NsgDataTypedReference __Подрядчик = ObjectList["Подрядчик"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Подрядчик.Referent;
            }
            set
            {
                NsgDataTypedReference __Подрядчик = ObjectList["Подрядчик"] as NsgDataTypedReference;
                __Подрядчик.Referent = value;
            }
        }
        
        /// <summary>
        /// Номер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Номер
        {
            get
            {
				 NsgDataString __Номер = ObjectList["Номер"] as NsgDataString;
                 return (System.String)__Номер.Value;
            }
            set
            {
                NsgDataString __Номер = ObjectList["Номер"] as NsgDataString;
                __Номер.Value = value;
            }
        }
        
        /// <summary>
        /// Нормативный расход топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal НормативныйРасходТоплива
        {
            get
            {
				 NsgDataFloat __НормативныйРасходТоплива = ObjectList["НормативныйРасходТоплива"] as NsgDataFloat;
                 return (System.Decimal)__НормативныйРасходТоплива.Value;
            }
            set
            {
                NsgDataFloat __НормативныйРасходТоплива = ObjectList["НормативныйРасходТоплива"] as NsgDataFloat;
                __НормативныйРасходТоплива.Value = value;
            }
        }
        
        /// <summary>
        /// Объем топливного бака
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбъемТопливногоБака
        {
            get
            {
				 NsgDataFloat __ОбъемТопливногоБака = ObjectList["ОбъемТопливногоБака"] as NsgDataFloat;
                 return (System.Decimal)__ОбъемТопливногоБака.Value;
            }
            set
            {
                NsgDataFloat __ОбъемТопливногоБака = ObjectList["ОбъемТопливногоБака"] as NsgDataFloat;
                __ОбъемТопливногоБака.Value = value;
            }
        }
        
        /// <summary>
        /// Примечание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Примечание
        {
            get
            {
				 NsgDataString __Примечание = ObjectList["Примечание"] as NsgDataString;
                 return (System.String)__Примечание.Value;
            }
            set
            {
                NsgDataString __Примечание = ObjectList["Примечание"] as NsgDataString;
                __Примечание.Value = value;
            }
        }
        
        /// <summary>
        /// Статус
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.СтатусТехники Статус
        {
            get
            {
				 NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                 return (Мониторинг.СтатусТехники)__Статус.Referent;
            }
            set
            {
                NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                __Статус.Referent = value;
            }
        }
        
        /// <summary>
        /// Тарифы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингТехникаТарифы Тарифы
        {
            get
            {
				 NsgDataTableReference __Тарифы = ObjectList["Тарифы"] as NsgDataTableReference;
                 return (_SystemTables.МониторингТехникаТарифы)__Тарифы.Referent;
            }
            set
            {
                NsgDataTableReference __Тарифы = ObjectList["Тарифы"] as NsgDataTableReference;
                __Тарифы.Referent = value;
            }
        }
        
        /// <summary>
        /// Тип собственности
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ТипСобственности ТипСобственности
        {
            get
            {
				 NsgDataEnumReference __ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                 return (Мониторинг.ТипСобственности)__ТипСобственности.Referent;
            }
            set
            {
                NsgDataEnumReference __ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                __ТипСобственности.Referent = value;
            }
        }
        
        /// <summary>
        /// Группа спец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
        {
            get
            {
				 NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                 return (Мониторинг.ГруппыСпецТехники)__ГруппаСпецТехники.Referent;
            }
            set
            {
                NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                __ГруппаСпецТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Системы слежения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингТехникаСистемыСлежения СистемыСлежения
        {
            get
            {
				 NsgDataTableReference __СистемыСлежения = ObjectList["СистемыСлежения"] as NsgDataTableReference;
                 return (_SystemTables.МониторингТехникаСистемыСлежения)__СистемыСлежения.Referent;
            }
            set
            {
                NsgDataTableReference __СистемыСлежения = ObjectList["СистемыСлежения"] as NsgDataTableReference;
                __СистемыСлежения.Referent = value;
            }
        }
        
        /// <summary>
        /// Иконка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Иконка
        {
            get
            {
				 NsgDataInteger __Иконка = ObjectList["Иконка"] as NsgDataInteger;
                 return (System.Int64)__Иконка.Value;
            }
            set
            {
                NsgDataInteger __Иконка = ObjectList["Иконка"] as NsgDataInteger;
                __Иконка.Value = value;
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
        /// Отслеживать ходки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ОтслеживатьХодки
        {
            get
            {
				 NsgDataBoolean __ОтслеживатьХодки = ObjectList["ОтслеживатьХодки"] as NsgDataBoolean;
                 return (System.Boolean)__ОтслеживатьХодки.Value;
            }
            set
            {
                NsgDataBoolean __ОтслеживатьХодки = ObjectList["ОтслеживатьХодки"] as NsgDataBoolean;
                __ОтслеживатьХодки.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица допущенные до управления должности
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности ТаблицаДопущенныеДоУправленияДолжности
        {
            get
            {
				 NsgDataTableReference __ТаблицаДопущенныеДоУправленияДолжности = ObjectList["ТаблицаДопущенныеДоУправленияДолжности"] as NsgDataTableReference;
                 return (_SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности)__ТаблицаДопущенныеДоУправленияДолжности.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаДопущенныеДоУправленияДолжности = ObjectList["ТаблицаДопущенныеДоУправленияДолжности"] as NsgDataTableReference;
                __ТаблицаДопущенныеДоУправленияДолжности.Referent = value;
            }
        }
        
        /// <summary>
        /// Полезный объем МКуб
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ПолезныйОбъемМКуб
        {
            get
            {
				 NsgDataFloat __ПолезныйОбъемМКуб = ObjectList["ПолезныйОбъемМКуб"] as NsgDataFloat;
                 return (System.Decimal)__ПолезныйОбъемМКуб.Value;
            }
            set
            {
                NsgDataFloat __ПолезныйОбъемМКуб = ObjectList["ПолезныйОбъемМКуб"] as NsgDataFloat;
                __ПолезныйОбъемМКуб.Value = value;
            }
        }
        
        /// <summary>
        /// Вид кузова
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ВидыКузовов ВидКузова
        {
            get
            {
				 NsgDataTypedReference __ВидКузова = ObjectList["ВидКузова"] as NsgDataTypedReference;
                 return (Мониторинг.ВидыКузовов)__ВидКузова.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидКузова = ObjectList["ВидКузова"] as NsgDataTypedReference;
                __ВидКузова.Referent = value;
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
        public Техника Родитель
        {
            get
            {
                return base.Parent as Техника;
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
        private Техника[] convertArray(NsgMultipleObject[] array)
        {
            Техника[] res = new Техника[array.Length];
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
        public new virtual Техника[] FindAll(NsgCompare compare)
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
        public new virtual Техника[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Техника[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Техника[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Техника(this as NsgObject);
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
                base.NSGType = typeof(Техника);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Техника Value
            {
                get
                {
                    return (Техника)base.Value;
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
