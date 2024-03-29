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
    
    [NsgTypeName("NsgDataDictionary", Guid = "47d2a783-3a6f-4f22-8573-cdea3e3ef95b")]
    public partial class Размеры : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Размеры()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Размеры(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Размеры Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("47d2a783-3a6f-4f22-8573-cdea3e3ef95b"));
            if (obj == null)
                obj = new Размеры();
            return obj as Размеры;
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
	Идентификатор.Guid = NsgService.StringToGuid("bb9bc940-e05e-4c3b-8bba-83300022dd21");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("9aac7e8b-e5d9-4bb3-81a7-678db50d0b9d");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("654d0c5e-393c-4350-88dc-1957dd9ed2b4");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("a686bf37-a110-4522-9a03-e13fb449715c");
	
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
	Уровень.Guid = NsgService.StringToGuid("c7a23520-1106-45fe-853a-ef328f918300");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("94683500-3026-4429-b859-c825084d67e4");
	
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
	НомерКода.Guid = NsgService.StringToGuid("009731a0-cb08-4812-845c-f91b57abdee9");
	
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
	Код.Guid = NsgService.StringToGuid("5453c6ab-adb8-4e09-bfb9-b9eb20a49473");
	
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
	Наименование.Guid = NsgService.StringToGuid("40e4f4cb-08d7-4e77-aabc-5e3ed5fa8ad5");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("2a01797c-49bd-48e9-bfb6-32d5fc584e94");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
			{  
                NsgDataTypedReference ВидСвойствНоменклатуры = null;
				if (ObjectList.Contains("ВидСвойствНоменклатуры"))
                    ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                else
                    ВидСвойствНоменклатуры = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидСвойствНоменклатуры.IsLoadedFromDll = true;
	ВидСвойствНоменклатуры.ReferentGroup = "Учет";
	ВидСвойствНоменклатуры.ReferentName = "ВидСвойствНоменклатуры";
	ВидСвойствНоменклатуры.SaveInDatabase = true;
	ВидСвойствНоменклатуры.OwnerName = "";
	ВидСвойствНоменклатуры.AllowEmptyOwner = false;
	ВидСвойствНоменклатуры.StringFormat = "";
	ВидСвойствНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВидСвойствНоменклатуры.IncludeInPredefined = false;
	ВидСвойствНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидСвойствНоменклатуры.Required = false;
	ВидСвойствНоменклатуры.EmptyValue = "";
	ВидСвойствНоменклатуры.NullAllow = false;
	ВидСвойствНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидСвойствНоменклатуры.FieldName = "VidSvoijstvNomenk";
	ВидСвойствНоменклатуры.InformMetaDataOnValueChanged = false;
	ВидСвойствНоменклатуры.Visible = true;
	ВидСвойствНоменклатуры.Name = "ВидСвойствНоменклатуры";
	ВидСвойствНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидСвойствНоменклатуры.Description = "Вид свойств номенклатуры";
	ВидСвойствНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидСвойствНоменклатуры.GroupName = "";
	ВидСвойствНоменклатуры.Guid = NsgService.StringToGuid("ba1e5c0a-0bf7-4631-a314-fc0122120eac");
	
				if (!ObjectList.Contains("ВидСвойствНоменклатуры"))
                    ObjectList.Add(ВидСвойствНоменклатуры);
			}
			#endregion //создание Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
			
			#region создание TechControl.Метаданные.Учет.РазмерыФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Учет.РазмерыФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("44a86c04-f0c4-45b2-a368-6adb7bab8e4f");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Учет.РазмерыФормаЭлемента ФормаЭлемента
			
			#region создание System.Decimal РостМакс
			{  
                NsgDataFloat РостМакс = null;
				if (ObjectList.Contains("РостМакс"))
                    РостМакс = ObjectList["РостМакс"] as NsgDataFloat;
                else
                    РостМакс = new NsgDataFloat();
	//NsgDataFloat
	РостМакс.IsLoadedFromDll = true;
	РостМакс.Precision = 2;
	РостМакс.HideZero = true;
	РостМакс.DefaultValue = 0M;
	РостМакс.MinValue = -100000000000000000M;
	РостМакс.MaxValue = 100000000000000000M;
	РостМакс.UseCalculator = true;
	РостМакс.StringFormat = "";
	РостМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РостМакс.IncludeInPredefined = false;
	РостМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РостМакс.Required = false;
	РостМакс.EmptyValue = "";
	РостМакс.NullAllow = false;
	РостМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РостМакс.FieldName = "RostMaks";
	РостМакс.SaveInDatabase = true;
	РостМакс.InformMetaDataOnValueChanged = false;
	РостМакс.Visible = true;
	РостМакс.Name = "РостМакс";
	РостМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РостМакс.Description = "Рост макс";
	РостМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РостМакс.GroupName = "";
	РостМакс.Guid = NsgService.StringToGuid("636a1a3c-4fa3-4fea-ab3e-7df00976a3cc");
	
				if (!ObjectList.Contains("РостМакс"))
                    ObjectList.Add(РостМакс);
			}
			#endregion //создание System.Decimal РостМакс
			
			#region создание System.Decimal ОбхватГрудиМин
			{  
                NsgDataFloat ОбхватГрудиМин = null;
				if (ObjectList.Contains("ОбхватГрудиМин"))
                    ОбхватГрудиМин = ObjectList["ОбхватГрудиМин"] as NsgDataFloat;
                else
                    ОбхватГрудиМин = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГрудиМин.IsLoadedFromDll = true;
	ОбхватГрудиМин.Precision = 2;
	ОбхватГрудиМин.HideZero = true;
	ОбхватГрудиМин.DefaultValue = 0M;
	ОбхватГрудиМин.MinValue = -100000000000000000M;
	ОбхватГрудиМин.MaxValue = 100000000000000000M;
	ОбхватГрудиМин.UseCalculator = true;
	ОбхватГрудиМин.StringFormat = "";
	ОбхватГрудиМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГрудиМин.IncludeInPredefined = false;
	ОбхватГрудиМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГрудиМин.Required = false;
	ОбхватГрудиМин.EmptyValue = "";
	ОбхватГрудиМин.NullAllow = false;
	ОбхватГрудиМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГрудиМин.FieldName = "ObkhvatGrudiMin";
	ОбхватГрудиМин.SaveInDatabase = true;
	ОбхватГрудиМин.InformMetaDataOnValueChanged = false;
	ОбхватГрудиМин.Visible = true;
	ОбхватГрудиМин.Name = "ОбхватГрудиМин";
	ОбхватГрудиМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГрудиМин.Description = "Обхват груди мин";
	ОбхватГрудиМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГрудиМин.GroupName = "";
	ОбхватГрудиМин.Guid = NsgService.StringToGuid("58a8df17-b5af-4482-abaa-bab547a016c9");
	
				if (!ObjectList.Contains("ОбхватГрудиМин"))
                    ObjectList.Add(ОбхватГрудиМин);
			}
			#endregion //создание System.Decimal ОбхватГрудиМин
			
			#region создание System.Decimal ОбхватТалииМин
			{  
                NsgDataFloat ОбхватТалииМин = null;
				if (ObjectList.Contains("ОбхватТалииМин"))
                    ОбхватТалииМин = ObjectList["ОбхватТалииМин"] as NsgDataFloat;
                else
                    ОбхватТалииМин = new NsgDataFloat();
	//NsgDataFloat
	ОбхватТалииМин.IsLoadedFromDll = true;
	ОбхватТалииМин.Precision = 2;
	ОбхватТалииМин.HideZero = true;
	ОбхватТалииМин.DefaultValue = 0M;
	ОбхватТалииМин.MinValue = -100000000000000000M;
	ОбхватТалииМин.MaxValue = 100000000000000000M;
	ОбхватТалииМин.UseCalculator = true;
	ОбхватТалииМин.StringFormat = "";
	ОбхватТалииМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватТалииМин.IncludeInPredefined = false;
	ОбхватТалииМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватТалииМин.Required = false;
	ОбхватТалииМин.EmptyValue = "";
	ОбхватТалииМин.NullAllow = false;
	ОбхватТалииМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватТалииМин.FieldName = "ObkhvatTaliiMin";
	ОбхватТалииМин.SaveInDatabase = true;
	ОбхватТалииМин.InformMetaDataOnValueChanged = false;
	ОбхватТалииМин.Visible = true;
	ОбхватТалииМин.Name = "ОбхватТалииМин";
	ОбхватТалииМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватТалииМин.Description = "Обхват талии мин";
	ОбхватТалииМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватТалииМин.GroupName = "";
	ОбхватТалииМин.Guid = NsgService.StringToGuid("c182c8a6-b1d8-4f6c-b3ec-6a927fd37f54");
	
				if (!ObjectList.Contains("ОбхватТалииМин"))
                    ObjectList.Add(ОбхватТалииМин);
			}
			#endregion //создание System.Decimal ОбхватТалииМин
			
			#region создание System.Decimal ОбхватТалииМакс
			{  
                NsgDataFloat ОбхватТалииМакс = null;
				if (ObjectList.Contains("ОбхватТалииМакс"))
                    ОбхватТалииМакс = ObjectList["ОбхватТалииМакс"] as NsgDataFloat;
                else
                    ОбхватТалииМакс = new NsgDataFloat();
	//NsgDataFloat
	ОбхватТалииМакс.IsLoadedFromDll = true;
	ОбхватТалииМакс.Precision = 2;
	ОбхватТалииМакс.HideZero = true;
	ОбхватТалииМакс.DefaultValue = 0M;
	ОбхватТалииМакс.MinValue = -100000000000000000M;
	ОбхватТалииМакс.MaxValue = 100000000000000000M;
	ОбхватТалииМакс.UseCalculator = true;
	ОбхватТалииМакс.StringFormat = "";
	ОбхватТалииМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватТалииМакс.IncludeInPredefined = false;
	ОбхватТалииМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватТалииМакс.Required = false;
	ОбхватТалииМакс.EmptyValue = "";
	ОбхватТалииМакс.NullAllow = false;
	ОбхватТалииМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватТалииМакс.FieldName = "ObkhvatTaliiMaks";
	ОбхватТалииМакс.SaveInDatabase = true;
	ОбхватТалииМакс.InformMetaDataOnValueChanged = false;
	ОбхватТалииМакс.Visible = true;
	ОбхватТалииМакс.Name = "ОбхватТалииМакс";
	ОбхватТалииМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватТалииМакс.Description = "Обхват талии макс";
	ОбхватТалииМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватТалииМакс.GroupName = "";
	ОбхватТалииМакс.Guid = NsgService.StringToGuid("86887b72-ec8f-4427-a2e6-29ad9c7b52e5");
	
				if (!ObjectList.Contains("ОбхватТалииМакс"))
                    ObjectList.Add(ОбхватТалииМакс);
			}
			#endregion //создание System.Decimal ОбхватТалииМакс
			
			#region создание System.Decimal ОбхватБедерМин
			{  
                NsgDataFloat ОбхватБедерМин = null;
				if (ObjectList.Contains("ОбхватБедерМин"))
                    ОбхватБедерМин = ObjectList["ОбхватБедерМин"] as NsgDataFloat;
                else
                    ОбхватБедерМин = new NsgDataFloat();
	//NsgDataFloat
	ОбхватБедерМин.IsLoadedFromDll = true;
	ОбхватБедерМин.Precision = 2;
	ОбхватБедерМин.HideZero = true;
	ОбхватБедерМин.DefaultValue = 0M;
	ОбхватБедерМин.MinValue = -100000000000000000M;
	ОбхватБедерМин.MaxValue = 100000000000000000M;
	ОбхватБедерМин.UseCalculator = true;
	ОбхватБедерМин.StringFormat = "";
	ОбхватБедерМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватБедерМин.IncludeInPredefined = false;
	ОбхватБедерМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватБедерМин.Required = false;
	ОбхватБедерМин.EmptyValue = "";
	ОбхватБедерМин.NullAllow = false;
	ОбхватБедерМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватБедерМин.FieldName = "ObkhvatBederMin";
	ОбхватБедерМин.SaveInDatabase = true;
	ОбхватБедерМин.InformMetaDataOnValueChanged = false;
	ОбхватБедерМин.Visible = true;
	ОбхватБедерМин.Name = "ОбхватБедерМин";
	ОбхватБедерМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватБедерМин.Description = "Обхват бедер мин";
	ОбхватБедерМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватБедерМин.GroupName = "";
	ОбхватБедерМин.Guid = NsgService.StringToGuid("d8a32479-943e-4f25-8c16-aa9d8b5b0926");
	
				if (!ObjectList.Contains("ОбхватБедерМин"))
                    ObjectList.Add(ОбхватБедерМин);
			}
			#endregion //создание System.Decimal ОбхватБедерМин
			
			#region создание System.Decimal ОбхватБедерМакс
			{  
                NsgDataFloat ОбхватБедерМакс = null;
				if (ObjectList.Contains("ОбхватБедерМакс"))
                    ОбхватБедерМакс = ObjectList["ОбхватБедерМакс"] as NsgDataFloat;
                else
                    ОбхватБедерМакс = new NsgDataFloat();
	//NsgDataFloat
	ОбхватБедерМакс.IsLoadedFromDll = true;
	ОбхватБедерМакс.Precision = 2;
	ОбхватБедерМакс.HideZero = true;
	ОбхватБедерМакс.DefaultValue = 0M;
	ОбхватБедерМакс.MinValue = -100000000000000000M;
	ОбхватБедерМакс.MaxValue = 100000000000000000M;
	ОбхватБедерМакс.UseCalculator = true;
	ОбхватБедерМакс.StringFormat = "";
	ОбхватБедерМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватБедерМакс.IncludeInPredefined = false;
	ОбхватБедерМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватБедерМакс.Required = false;
	ОбхватБедерМакс.EmptyValue = "";
	ОбхватБедерМакс.NullAllow = false;
	ОбхватБедерМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватБедерМакс.FieldName = "ObkhvatBederMaks";
	ОбхватБедерМакс.SaveInDatabase = true;
	ОбхватБедерМакс.InformMetaDataOnValueChanged = false;
	ОбхватБедерМакс.Visible = true;
	ОбхватБедерМакс.Name = "ОбхватБедерМакс";
	ОбхватБедерМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватБедерМакс.Description = "Обхват бедер макс";
	ОбхватБедерМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватБедерМакс.GroupName = "";
	ОбхватБедерМакс.Guid = NsgService.StringToGuid("8ba9f9d6-9158-49d1-87b3-da5525b690c1");
	
				if (!ObjectList.Contains("ОбхватБедерМакс"))
                    ObjectList.Add(ОбхватБедерМакс);
			}
			#endregion //создание System.Decimal ОбхватБедерМакс
			
			#region создание System.Decimal ВнутренняяДлинаБрюкМин
			{  
                NsgDataFloat ВнутренняяДлинаБрюкМин = null;
				if (ObjectList.Contains("ВнутренняяДлинаБрюкМин"))
                    ВнутренняяДлинаБрюкМин = ObjectList["ВнутренняяДлинаБрюкМин"] as NsgDataFloat;
                else
                    ВнутренняяДлинаБрюкМин = new NsgDataFloat();
	//NsgDataFloat
	ВнутренняяДлинаБрюкМин.IsLoadedFromDll = true;
	ВнутренняяДлинаБрюкМин.Precision = 2;
	ВнутренняяДлинаБрюкМин.HideZero = true;
	ВнутренняяДлинаБрюкМин.DefaultValue = 0M;
	ВнутренняяДлинаБрюкМин.MinValue = -100000000000000000M;
	ВнутренняяДлинаБрюкМин.MaxValue = 100000000000000000M;
	ВнутренняяДлинаБрюкМин.UseCalculator = true;
	ВнутренняяДлинаБрюкМин.StringFormat = "";
	ВнутренняяДлинаБрюкМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВнутренняяДлинаБрюкМин.IncludeInPredefined = false;
	ВнутренняяДлинаБрюкМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВнутренняяДлинаБрюкМин.Required = false;
	ВнутренняяДлинаБрюкМин.EmptyValue = "";
	ВнутренняяДлинаБрюкМин.NullAllow = false;
	ВнутренняяДлинаБрюкМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВнутренняяДлинаБрюкМин.FieldName = "VnutrennjajaDlina";
	ВнутренняяДлинаБрюкМин.SaveInDatabase = true;
	ВнутренняяДлинаБрюкМин.InformMetaDataOnValueChanged = false;
	ВнутренняяДлинаБрюкМин.Visible = true;
	ВнутренняяДлинаБрюкМин.Name = "ВнутренняяДлинаБрюкМин";
	ВнутренняяДлинаБрюкМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВнутренняяДлинаБрюкМин.Description = "Внутренняя длина брюк мин";
	ВнутренняяДлинаБрюкМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВнутренняяДлинаБрюкМин.GroupName = "";
	ВнутренняяДлинаБрюкМин.Guid = NsgService.StringToGuid("674ba73a-3100-42ca-bb8d-4cc89578e8cd");
	
				if (!ObjectList.Contains("ВнутренняяДлинаБрюкМин"))
                    ObjectList.Add(ВнутренняяДлинаБрюкМин);
			}
			#endregion //создание System.Decimal ВнутренняяДлинаБрюкМин
			
			#region создание System.Decimal ОбхватШеиМин
			{  
                NsgDataFloat ОбхватШеиМин = null;
				if (ObjectList.Contains("ОбхватШеиМин"))
                    ОбхватШеиМин = ObjectList["ОбхватШеиМин"] as NsgDataFloat;
                else
                    ОбхватШеиМин = new NsgDataFloat();
	//NsgDataFloat
	ОбхватШеиМин.IsLoadedFromDll = true;
	ОбхватШеиМин.Precision = 2;
	ОбхватШеиМин.HideZero = true;
	ОбхватШеиМин.DefaultValue = 0M;
	ОбхватШеиМин.MinValue = -100000000000000000M;
	ОбхватШеиМин.MaxValue = 100000000000000000M;
	ОбхватШеиМин.UseCalculator = true;
	ОбхватШеиМин.StringFormat = "";
	ОбхватШеиМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватШеиМин.IncludeInPredefined = false;
	ОбхватШеиМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватШеиМин.Required = false;
	ОбхватШеиМин.EmptyValue = "";
	ОбхватШеиМин.NullAllow = false;
	ОбхватШеиМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватШеиМин.FieldName = "ObkhvatSHeiMin";
	ОбхватШеиМин.SaveInDatabase = true;
	ОбхватШеиМин.InformMetaDataOnValueChanged = false;
	ОбхватШеиМин.Visible = true;
	ОбхватШеиМин.Name = "ОбхватШеиМин";
	ОбхватШеиМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватШеиМин.Description = "Обхват шеи мин";
	ОбхватШеиМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватШеиМин.GroupName = "";
	ОбхватШеиМин.Guid = NsgService.StringToGuid("66bfd4ea-a3d3-41e6-bbd9-3916f06cbaaa");
	
				if (!ObjectList.Contains("ОбхватШеиМин"))
                    ObjectList.Add(ОбхватШеиМин);
			}
			#endregion //создание System.Decimal ОбхватШеиМин
			
			#region создание System.Decimal ВнутренняяДлинаБрюкМакс
			{  
                NsgDataFloat ВнутренняяДлинаБрюкМакс = null;
				if (ObjectList.Contains("ВнутренняяДлинаБрюкМакс"))
                    ВнутренняяДлинаБрюкМакс = ObjectList["ВнутренняяДлинаБрюкМакс"] as NsgDataFloat;
                else
                    ВнутренняяДлинаБрюкМакс = new NsgDataFloat();
	//NsgDataFloat
	ВнутренняяДлинаБрюкМакс.IsLoadedFromDll = true;
	ВнутренняяДлинаБрюкМакс.Precision = 2;
	ВнутренняяДлинаБрюкМакс.HideZero = true;
	ВнутренняяДлинаБрюкМакс.DefaultValue = 0M;
	ВнутренняяДлинаБрюкМакс.MinValue = -100000000000000000M;
	ВнутренняяДлинаБрюкМакс.MaxValue = 100000000000000000M;
	ВнутренняяДлинаБрюкМакс.UseCalculator = true;
	ВнутренняяДлинаБрюкМакс.StringFormat = "";
	ВнутренняяДлинаБрюкМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВнутренняяДлинаБрюкМакс.IncludeInPredefined = false;
	ВнутренняяДлинаБрюкМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВнутренняяДлинаБрюкМакс.Required = false;
	ВнутренняяДлинаБрюкМакс.EmptyValue = "";
	ВнутренняяДлинаБрюкМакс.NullAllow = false;
	ВнутренняяДлинаБрюкМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВнутренняяДлинаБрюкМакс.FieldName = "VnutrennjajaDlina1";
	ВнутренняяДлинаБрюкМакс.SaveInDatabase = true;
	ВнутренняяДлинаБрюкМакс.InformMetaDataOnValueChanged = false;
	ВнутренняяДлинаБрюкМакс.Visible = true;
	ВнутренняяДлинаБрюкМакс.Name = "ВнутренняяДлинаБрюкМакс";
	ВнутренняяДлинаБрюкМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВнутренняяДлинаБрюкМакс.Description = "Внутренняя длина брюк макс";
	ВнутренняяДлинаБрюкМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВнутренняяДлинаБрюкМакс.GroupName = "";
	ВнутренняяДлинаБрюкМакс.Guid = NsgService.StringToGuid("24ccab0b-7b81-49c7-abdb-13fd8802abed");
	
				if (!ObjectList.Contains("ВнутренняяДлинаБрюкМакс"))
                    ObjectList.Add(ВнутренняяДлинаБрюкМакс);
			}
			#endregion //создание System.Decimal ВнутренняяДлинаБрюкМакс
			
			#region создание System.Decimal ДлинаРукаваМакс
			{  
                NsgDataFloat ДлинаРукаваМакс = null;
				if (ObjectList.Contains("ДлинаРукаваМакс"))
                    ДлинаРукаваМакс = ObjectList["ДлинаРукаваМакс"] as NsgDataFloat;
                else
                    ДлинаРукаваМакс = new NsgDataFloat();
	//NsgDataFloat
	ДлинаРукаваМакс.IsLoadedFromDll = true;
	ДлинаРукаваМакс.Precision = 2;
	ДлинаРукаваМакс.HideZero = true;
	ДлинаРукаваМакс.DefaultValue = 0M;
	ДлинаРукаваМакс.MinValue = -100000000000000000M;
	ДлинаРукаваМакс.MaxValue = 100000000000000000M;
	ДлинаРукаваМакс.UseCalculator = true;
	ДлинаРукаваМакс.StringFormat = "";
	ДлинаРукаваМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаРукаваМакс.IncludeInPredefined = false;
	ДлинаРукаваМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаРукаваМакс.Required = false;
	ДлинаРукаваМакс.EmptyValue = "";
	ДлинаРукаваМакс.NullAllow = false;
	ДлинаРукаваМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаРукаваМакс.FieldName = "DlinaRukavaMaks";
	ДлинаРукаваМакс.SaveInDatabase = true;
	ДлинаРукаваМакс.InformMetaDataOnValueChanged = false;
	ДлинаРукаваМакс.Visible = true;
	ДлинаРукаваМакс.Name = "ДлинаРукаваМакс";
	ДлинаРукаваМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаРукаваМакс.Description = "Длина рукава макс";
	ДлинаРукаваМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаРукаваМакс.GroupName = "";
	ДлинаРукаваМакс.Guid = NsgService.StringToGuid("c7218705-bff4-44d9-9a20-7f670aa80923");
	
				if (!ObjectList.Contains("ДлинаРукаваМакс"))
                    ObjectList.Add(ДлинаРукаваМакс);
			}
			#endregion //создание System.Decimal ДлинаРукаваМакс
			
			#region создание System.Decimal ОбхватГрудиМакс
			{  
                NsgDataFloat ОбхватГрудиМакс = null;
				if (ObjectList.Contains("ОбхватГрудиМакс"))
                    ОбхватГрудиМакс = ObjectList["ОбхватГрудиМакс"] as NsgDataFloat;
                else
                    ОбхватГрудиМакс = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГрудиМакс.IsLoadedFromDll = true;
	ОбхватГрудиМакс.Precision = 2;
	ОбхватГрудиМакс.HideZero = true;
	ОбхватГрудиМакс.DefaultValue = 0M;
	ОбхватГрудиМакс.MinValue = -100000000000000000M;
	ОбхватГрудиМакс.MaxValue = 100000000000000000M;
	ОбхватГрудиМакс.UseCalculator = true;
	ОбхватГрудиМакс.StringFormat = "";
	ОбхватГрудиМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГрудиМакс.IncludeInPredefined = false;
	ОбхватГрудиМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГрудиМакс.Required = false;
	ОбхватГрудиМакс.EmptyValue = "";
	ОбхватГрудиМакс.NullAllow = false;
	ОбхватГрудиМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГрудиМакс.FieldName = "ObkhvatGrudiMaks";
	ОбхватГрудиМакс.SaveInDatabase = true;
	ОбхватГрудиМакс.InformMetaDataOnValueChanged = false;
	ОбхватГрудиМакс.Visible = true;
	ОбхватГрудиМакс.Name = "ОбхватГрудиМакс";
	ОбхватГрудиМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГрудиМакс.Description = "Обхват груди макс";
	ОбхватГрудиМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГрудиМакс.GroupName = "";
	ОбхватГрудиМакс.Guid = NsgService.StringToGuid("2853dc2c-a6a1-4c6f-8eea-8cfc482c0633");
	
				if (!ObjectList.Contains("ОбхватГрудиМакс"))
                    ObjectList.Add(ОбхватГрудиМакс);
			}
			#endregion //создание System.Decimal ОбхватГрудиМакс
			
			#region создание System.Decimal РостМин
			{  
                NsgDataFloat РостМин = null;
				if (ObjectList.Contains("РостМин"))
                    РостМин = ObjectList["РостМин"] as NsgDataFloat;
                else
                    РостМин = new NsgDataFloat();
	//NsgDataFloat
	РостМин.IsLoadedFromDll = true;
	РостМин.Precision = 2;
	РостМин.HideZero = true;
	РостМин.DefaultValue = 0M;
	РостМин.MinValue = -100000000000000000M;
	РостМин.MaxValue = 100000000000000000M;
	РостМин.UseCalculator = true;
	РостМин.StringFormat = "";
	РостМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РостМин.IncludeInPredefined = false;
	РостМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РостМин.Required = false;
	РостМин.EmptyValue = "";
	РостМин.NullAllow = false;
	РостМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РостМин.FieldName = "RostMin";
	РостМин.SaveInDatabase = true;
	РостМин.InformMetaDataOnValueChanged = false;
	РостМин.Visible = true;
	РостМин.Name = "РостМин";
	РостМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РостМин.Description = "Рост мин";
	РостМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РостМин.GroupName = "";
	РостМин.Guid = NsgService.StringToGuid("d3dbe4d6-f3ca-4f38-810b-7510f6f93d3c");
	
				if (!ObjectList.Contains("РостМин"))
                    ObjectList.Add(РостМин);
			}
			#endregion //создание System.Decimal РостМин
			
			#region создание System.Decimal ОбхватШеиМакс
			{  
                NsgDataFloat ОбхватШеиМакс = null;
				if (ObjectList.Contains("ОбхватШеиМакс"))
                    ОбхватШеиМакс = ObjectList["ОбхватШеиМакс"] as NsgDataFloat;
                else
                    ОбхватШеиМакс = new NsgDataFloat();
	//NsgDataFloat
	ОбхватШеиМакс.IsLoadedFromDll = true;
	ОбхватШеиМакс.Precision = 2;
	ОбхватШеиМакс.HideZero = true;
	ОбхватШеиМакс.DefaultValue = 0M;
	ОбхватШеиМакс.MinValue = -100000000000000000M;
	ОбхватШеиМакс.MaxValue = 100000000000000000M;
	ОбхватШеиМакс.UseCalculator = true;
	ОбхватШеиМакс.StringFormat = "";
	ОбхватШеиМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватШеиМакс.IncludeInPredefined = false;
	ОбхватШеиМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватШеиМакс.Required = false;
	ОбхватШеиМакс.EmptyValue = "";
	ОбхватШеиМакс.NullAllow = false;
	ОбхватШеиМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватШеиМакс.FieldName = "ObkhvatSHeiMaks";
	ОбхватШеиМакс.SaveInDatabase = true;
	ОбхватШеиМакс.InformMetaDataOnValueChanged = false;
	ОбхватШеиМакс.Visible = true;
	ОбхватШеиМакс.Name = "ОбхватШеиМакс";
	ОбхватШеиМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватШеиМакс.Description = "Обхват шеи макс";
	ОбхватШеиМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватШеиМакс.GroupName = "";
	ОбхватШеиМакс.Guid = NsgService.StringToGuid("90b1e149-40c1-4f69-873a-4a5ce7c0a525");
	
				if (!ObjectList.Contains("ОбхватШеиМакс"))
                    ObjectList.Add(ОбхватШеиМакс);
			}
			#endregion //создание System.Decimal ОбхватШеиМакс
			
			#region создание System.Decimal ДлинаСтупниМакс
			{  
                NsgDataFloat ДлинаСтупниМакс = null;
				if (ObjectList.Contains("ДлинаСтупниМакс"))
                    ДлинаСтупниМакс = ObjectList["ДлинаСтупниМакс"] as NsgDataFloat;
                else
                    ДлинаСтупниМакс = new NsgDataFloat();
	//NsgDataFloat
	ДлинаСтупниМакс.IsLoadedFromDll = true;
	ДлинаСтупниМакс.Precision = 2;
	ДлинаСтупниМакс.HideZero = true;
	ДлинаСтупниМакс.DefaultValue = 0M;
	ДлинаСтупниМакс.MinValue = -100000000000000000M;
	ДлинаСтупниМакс.MaxValue = 100000000000000000M;
	ДлинаСтупниМакс.UseCalculator = true;
	ДлинаСтупниМакс.StringFormat = "";
	ДлинаСтупниМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаСтупниМакс.IncludeInPredefined = false;
	ДлинаСтупниМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаСтупниМакс.Required = false;
	ДлинаСтупниМакс.EmptyValue = "";
	ДлинаСтупниМакс.NullAllow = false;
	ДлинаСтупниМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаСтупниМакс.FieldName = "DlinaStupniMaks";
	ДлинаСтупниМакс.SaveInDatabase = true;
	ДлинаСтупниМакс.InformMetaDataOnValueChanged = false;
	ДлинаСтупниМакс.Visible = true;
	ДлинаСтупниМакс.Name = "ДлинаСтупниМакс";
	ДлинаСтупниМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаСтупниМакс.Description = "Длина ступни макс";
	ДлинаСтупниМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаСтупниМакс.GroupName = "";
	ДлинаСтупниМакс.Guid = NsgService.StringToGuid("022f36a1-13ef-4765-aefe-110118909139");
	
				if (!ObjectList.Contains("ДлинаСтупниМакс"))
                    ObjectList.Add(ДлинаСтупниМакс);
			}
			#endregion //создание System.Decimal ДлинаСтупниМакс
			
			#region создание УчетСпецодеждыИСИЗ.ВидыРазмернойСетки ВидРазмернойСетки
			{  
                NsgDataTypedReference ВидРазмернойСетки = null;
				if (ObjectList.Contains("ВидРазмернойСетки"))
                    ВидРазмернойСетки = ObjectList["ВидРазмернойСетки"] as NsgDataTypedReference;
                else
                    ВидРазмернойСетки = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидРазмернойСетки.IsLoadedFromDll = true;
	ВидРазмернойСетки.ReferentGroup = "УчетСпецодеждыИСИЗ";
	ВидРазмернойСетки.ReferentName = "ВидыРазмернойСетки";
	ВидРазмернойСетки.SaveInDatabase = true;
	ВидРазмернойСетки.OwnerName = "";
	ВидРазмернойСетки.AllowEmptyOwner = false;
	ВидРазмернойСетки.StringFormat = "";
	ВидРазмернойСетки.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВидРазмернойСетки.IncludeInPredefined = false;
	ВидРазмернойСетки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидРазмернойСетки.Required = false;
	ВидРазмернойСетки.EmptyValue = "";
	ВидРазмернойСетки.NullAllow = false;
	ВидРазмернойСетки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидРазмернойСетки.FieldName = "VidRazmernoijSetki";
	ВидРазмернойСетки.InformMetaDataOnValueChanged = false;
	ВидРазмернойСетки.Visible = true;
	ВидРазмернойСетки.Name = "ВидРазмернойСетки";
	ВидРазмернойСетки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидРазмернойСетки.Description = "Вид размерной сетки";
	ВидРазмернойСетки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидРазмернойСетки.GroupName = "";
	ВидРазмернойСетки.Guid = NsgService.StringToGuid("6a9c8765-428d-4523-adac-04721666f7ba");
	
				if (!ObjectList.Contains("ВидРазмернойСетки"))
                    ObjectList.Add(ВидРазмернойСетки);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.ВидыРазмернойСетки ВидРазмернойСетки
			
			#region создание System.Decimal БоковаяДлинаБрюкМин
			{  
                NsgDataFloat БоковаяДлинаБрюкМин = null;
				if (ObjectList.Contains("БоковаяДлинаБрюкМин"))
                    БоковаяДлинаБрюкМин = ObjectList["БоковаяДлинаБрюкМин"] as NsgDataFloat;
                else
                    БоковаяДлинаБрюкМин = new NsgDataFloat();
	//NsgDataFloat
	БоковаяДлинаБрюкМин.IsLoadedFromDll = true;
	БоковаяДлинаБрюкМин.Precision = 2;
	БоковаяДлинаБрюкМин.HideZero = true;
	БоковаяДлинаБрюкМин.DefaultValue = 0M;
	БоковаяДлинаБрюкМин.MinValue = -100000000000000000M;
	БоковаяДлинаБрюкМин.MaxValue = 100000000000000000M;
	БоковаяДлинаБрюкМин.UseCalculator = true;
	БоковаяДлинаБрюкМин.StringFormat = "";
	БоковаяДлинаБрюкМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	БоковаяДлинаБрюкМин.IncludeInPredefined = false;
	БоковаяДлинаБрюкМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	БоковаяДлинаБрюкМин.Required = false;
	БоковаяДлинаБрюкМин.EmptyValue = "";
	БоковаяДлинаБрюкМин.NullAllow = false;
	БоковаяДлинаБрюкМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	БоковаяДлинаБрюкМин.FieldName = "BokovajaDlinaBrjuk";
	БоковаяДлинаБрюкМин.SaveInDatabase = true;
	БоковаяДлинаБрюкМин.InformMetaDataOnValueChanged = false;
	БоковаяДлинаБрюкМин.Visible = true;
	БоковаяДлинаБрюкМин.Name = "БоковаяДлинаБрюкМин";
	БоковаяДлинаБрюкМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	БоковаяДлинаБрюкМин.Description = "Боковая длина брюк мин";
	БоковаяДлинаБрюкМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	БоковаяДлинаБрюкМин.GroupName = "";
	БоковаяДлинаБрюкМин.Guid = NsgService.StringToGuid("a3f02804-ca73-4105-bfc1-52474595bdf9");
	
				if (!ObjectList.Contains("БоковаяДлинаБрюкМин"))
                    ObjectList.Add(БоковаяДлинаБрюкМин);
			}
			#endregion //создание System.Decimal БоковаяДлинаБрюкМин
			
			#region создание System.Decimal ДлинаРукаваМин
			{  
                NsgDataFloat ДлинаРукаваМин = null;
				if (ObjectList.Contains("ДлинаРукаваМин"))
                    ДлинаРукаваМин = ObjectList["ДлинаРукаваМин"] as NsgDataFloat;
                else
                    ДлинаРукаваМин = new NsgDataFloat();
	//NsgDataFloat
	ДлинаРукаваМин.IsLoadedFromDll = true;
	ДлинаРукаваМин.Precision = 2;
	ДлинаРукаваМин.HideZero = true;
	ДлинаРукаваМин.DefaultValue = 0M;
	ДлинаРукаваМин.MinValue = -100000000000000000M;
	ДлинаРукаваМин.MaxValue = 100000000000000000M;
	ДлинаРукаваМин.UseCalculator = true;
	ДлинаРукаваМин.StringFormat = "";
	ДлинаРукаваМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаРукаваМин.IncludeInPredefined = false;
	ДлинаРукаваМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаРукаваМин.Required = false;
	ДлинаРукаваМин.EmptyValue = "";
	ДлинаРукаваМин.NullAllow = false;
	ДлинаРукаваМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаРукаваМин.FieldName = "DlinaRukava";
	ДлинаРукаваМин.SaveInDatabase = true;
	ДлинаРукаваМин.InformMetaDataOnValueChanged = false;
	ДлинаРукаваМин.Visible = true;
	ДлинаРукаваМин.Name = "ДлинаРукаваМин";
	ДлинаРукаваМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаРукаваМин.Description = "Длина рукава мин";
	ДлинаРукаваМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаРукаваМин.GroupName = "";
	ДлинаРукаваМин.Guid = NsgService.StringToGuid("ac01e391-9024-4c8c-89b8-f4b726efe98c");
	
				if (!ObjectList.Contains("ДлинаРукаваМин"))
                    ObjectList.Add(ДлинаРукаваМин);
			}
			#endregion //создание System.Decimal ДлинаРукаваМин
			
			#region создание System.Decimal ДлинаСтупниМин
			{  
                NsgDataFloat ДлинаСтупниМин = null;
				if (ObjectList.Contains("ДлинаСтупниМин"))
                    ДлинаСтупниМин = ObjectList["ДлинаСтупниМин"] as NsgDataFloat;
                else
                    ДлинаСтупниМин = new NsgDataFloat();
	//NsgDataFloat
	ДлинаСтупниМин.IsLoadedFromDll = true;
	ДлинаСтупниМин.Precision = 2;
	ДлинаСтупниМин.HideZero = true;
	ДлинаСтупниМин.DefaultValue = 0M;
	ДлинаСтупниМин.MinValue = -100000000000000000M;
	ДлинаСтупниМин.MaxValue = 100000000000000000M;
	ДлинаСтупниМин.UseCalculator = true;
	ДлинаСтупниМин.StringFormat = "";
	ДлинаСтупниМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаСтупниМин.IncludeInPredefined = false;
	ДлинаСтупниМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаСтупниМин.Required = false;
	ДлинаСтупниМин.EmptyValue = "";
	ДлинаСтупниМин.NullAllow = false;
	ДлинаСтупниМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаСтупниМин.FieldName = "DlinaStupni";
	ДлинаСтупниМин.SaveInDatabase = true;
	ДлинаСтупниМин.InformMetaDataOnValueChanged = false;
	ДлинаСтупниМин.Visible = true;
	ДлинаСтупниМин.Name = "ДлинаСтупниМин";
	ДлинаСтупниМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаСтупниМин.Description = "Длина ступни мин";
	ДлинаСтупниМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаСтупниМин.GroupName = "";
	ДлинаСтупниМин.Guid = NsgService.StringToGuid("5fb0251f-eb59-4b4e-abc8-a1067407dd75");
	
				if (!ObjectList.Contains("ДлинаСтупниМин"))
                    ObjectList.Add(ДлинаСтупниМин);
			}
			#endregion //создание System.Decimal ДлинаСтупниМин
			
			#region создание System.Decimal БоковаяДлинаБрюкМакс
			{  
                NsgDataFloat БоковаяДлинаБрюкМакс = null;
				if (ObjectList.Contains("БоковаяДлинаБрюкМакс"))
                    БоковаяДлинаБрюкМакс = ObjectList["БоковаяДлинаБрюкМакс"] as NsgDataFloat;
                else
                    БоковаяДлинаБрюкМакс = new NsgDataFloat();
	//NsgDataFloat
	БоковаяДлинаБрюкМакс.IsLoadedFromDll = true;
	БоковаяДлинаБрюкМакс.Precision = 2;
	БоковаяДлинаБрюкМакс.HideZero = true;
	БоковаяДлинаБрюкМакс.DefaultValue = 0M;
	БоковаяДлинаБрюкМакс.MinValue = -100000000000000000M;
	БоковаяДлинаБрюкМакс.MaxValue = 100000000000000000M;
	БоковаяДлинаБрюкМакс.UseCalculator = true;
	БоковаяДлинаБрюкМакс.StringFormat = "";
	БоковаяДлинаБрюкМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	БоковаяДлинаБрюкМакс.IncludeInPredefined = false;
	БоковаяДлинаБрюкМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	БоковаяДлинаБрюкМакс.Required = false;
	БоковаяДлинаБрюкМакс.EmptyValue = "";
	БоковаяДлинаБрюкМакс.NullAllow = false;
	БоковаяДлинаБрюкМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	БоковаяДлинаБрюкМакс.FieldName = "BokovajaDlinaBrju";
	БоковаяДлинаБрюкМакс.SaveInDatabase = true;
	БоковаяДлинаБрюкМакс.InformMetaDataOnValueChanged = false;
	БоковаяДлинаБрюкМакс.Visible = true;
	БоковаяДлинаБрюкМакс.Name = "БоковаяДлинаБрюкМакс";
	БоковаяДлинаБрюкМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	БоковаяДлинаБрюкМакс.Description = "Боковая длина брюк макс";
	БоковаяДлинаБрюкМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	БоковаяДлинаБрюкМакс.GroupName = "";
	БоковаяДлинаБрюкМакс.Guid = NsgService.StringToGuid("7b480e50-3a00-478b-93df-270e690335b1");
	
				if (!ObjectList.Contains("БоковаяДлинаБрюкМакс"))
                    ObjectList.Add(БоковаяДлинаБрюкМакс);
			}
			#endregion //создание System.Decimal БоковаяДлинаБрюкМакс
			
			#region создание System.Decimal ОбхватГоловыМакс
			{  
                NsgDataFloat ОбхватГоловыМакс = null;
				if (ObjectList.Contains("ОбхватГоловыМакс"))
                    ОбхватГоловыМакс = ObjectList["ОбхватГоловыМакс"] as NsgDataFloat;
                else
                    ОбхватГоловыМакс = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГоловыМакс.IsLoadedFromDll = true;
	ОбхватГоловыМакс.Precision = 2;
	ОбхватГоловыМакс.HideZero = true;
	ОбхватГоловыМакс.DefaultValue = 0M;
	ОбхватГоловыМакс.MinValue = -100000000000000000M;
	ОбхватГоловыМакс.MaxValue = 100000000000000000M;
	ОбхватГоловыМакс.UseCalculator = true;
	ОбхватГоловыМакс.StringFormat = "";
	ОбхватГоловыМакс.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГоловыМакс.IncludeInPredefined = false;
	ОбхватГоловыМакс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГоловыМакс.Required = false;
	ОбхватГоловыМакс.EmptyValue = "";
	ОбхватГоловыМакс.NullAllow = false;
	ОбхватГоловыМакс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГоловыМакс.FieldName = "ObkhvatGolovyMaks";
	ОбхватГоловыМакс.SaveInDatabase = true;
	ОбхватГоловыМакс.InformMetaDataOnValueChanged = false;
	ОбхватГоловыМакс.Visible = true;
	ОбхватГоловыМакс.Name = "ОбхватГоловыМакс";
	ОбхватГоловыМакс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГоловыМакс.Description = "Обхват головы макс";
	ОбхватГоловыМакс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГоловыМакс.GroupName = "";
	ОбхватГоловыМакс.Guid = NsgService.StringToGuid("b959eddd-b609-4c0b-8b6d-f06f1ca4a6bf");
	
				if (!ObjectList.Contains("ОбхватГоловыМакс"))
                    ObjectList.Add(ОбхватГоловыМакс);
			}
			#endregion //создание System.Decimal ОбхватГоловыМакс
			
			#region создание System.Decimal ОбхватГоловыМин
			{  
                NsgDataFloat ОбхватГоловыМин = null;
				if (ObjectList.Contains("ОбхватГоловыМин"))
                    ОбхватГоловыМин = ObjectList["ОбхватГоловыМин"] as NsgDataFloat;
                else
                    ОбхватГоловыМин = new NsgDataFloat();
	//NsgDataFloat
	ОбхватГоловыМин.IsLoadedFromDll = true;
	ОбхватГоловыМин.Precision = 2;
	ОбхватГоловыМин.HideZero = true;
	ОбхватГоловыМин.DefaultValue = 0M;
	ОбхватГоловыМин.MinValue = -100000000000000000M;
	ОбхватГоловыМин.MaxValue = 100000000000000000M;
	ОбхватГоловыМин.UseCalculator = true;
	ОбхватГоловыМин.StringFormat = "";
	ОбхватГоловыМин.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбхватГоловыМин.IncludeInPredefined = false;
	ОбхватГоловыМин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбхватГоловыМин.Required = false;
	ОбхватГоловыМин.EmptyValue = "";
	ОбхватГоловыМин.NullAllow = false;
	ОбхватГоловыМин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбхватГоловыМин.FieldName = "ObkhvatGolovyMin";
	ОбхватГоловыМин.SaveInDatabase = true;
	ОбхватГоловыМин.InformMetaDataOnValueChanged = false;
	ОбхватГоловыМин.Visible = true;
	ОбхватГоловыМин.Name = "ОбхватГоловыМин";
	ОбхватГоловыМин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбхватГоловыМин.Description = "Обхват головы мин";
	ОбхватГоловыМин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбхватГоловыМин.GroupName = "";
	ОбхватГоловыМин.Guid = NsgService.StringToGuid("9b5494a8-7238-4a7e-91a9-8facad5b86b3");
	
				if (!ObjectList.Contains("ОбхватГоловыМин"))
                    ObjectList.Add(ОбхватГоловыМин);
			}
			#endregion //создание System.Decimal ОбхватГоловыМин
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Размеры";
	Visible = true;
	Guid = NsgService.StringToGuid("47d2a783-3a6f-4f22-8573-cdea3e3ef95b");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Razmery";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Справочник";
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
            /// Вид свойств номенклатуры
            /// </summary>
            public static String ВидСвойствНоменклатуры
            {
                get
                {
                    return "ВидСвойствНоменклатуры";
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
            /// Рост макс
            /// </summary>
            public static String РостМакс
            {
                get
                {
                    return "РостМакс";
                }
            }
            
            /// <summary>
            /// Обхват груди мин
            /// </summary>
            public static String ОбхватГрудиМин
            {
                get
                {
                    return "ОбхватГрудиМин";
                }
            }
            
            /// <summary>
            /// Обхват талии мин
            /// </summary>
            public static String ОбхватТалииМин
            {
                get
                {
                    return "ОбхватТалииМин";
                }
            }
            
            /// <summary>
            /// Обхват талии макс
            /// </summary>
            public static String ОбхватТалииМакс
            {
                get
                {
                    return "ОбхватТалииМакс";
                }
            }
            
            /// <summary>
            /// Обхват бедер мин
            /// </summary>
            public static String ОбхватБедерМин
            {
                get
                {
                    return "ОбхватБедерМин";
                }
            }
            
            /// <summary>
            /// Обхват бедер макс
            /// </summary>
            public static String ОбхватБедерМакс
            {
                get
                {
                    return "ОбхватБедерМакс";
                }
            }
            
            /// <summary>
            /// Внутренняя длина брюк мин
            /// </summary>
            public static String ВнутренняяДлинаБрюкМин
            {
                get
                {
                    return "ВнутренняяДлинаБрюкМин";
                }
            }
            
            /// <summary>
            /// Обхват шеи мин
            /// </summary>
            public static String ОбхватШеиМин
            {
                get
                {
                    return "ОбхватШеиМин";
                }
            }
            
            /// <summary>
            /// Внутренняя длина брюк макс
            /// </summary>
            public static String ВнутренняяДлинаБрюкМакс
            {
                get
                {
                    return "ВнутренняяДлинаБрюкМакс";
                }
            }
            
            /// <summary>
            /// Длина рукава макс
            /// </summary>
            public static String ДлинаРукаваМакс
            {
                get
                {
                    return "ДлинаРукаваМакс";
                }
            }
            
            /// <summary>
            /// Обхват груди макс
            /// </summary>
            public static String ОбхватГрудиМакс
            {
                get
                {
                    return "ОбхватГрудиМакс";
                }
            }
            
            /// <summary>
            /// Рост мин
            /// </summary>
            public static String РостМин
            {
                get
                {
                    return "РостМин";
                }
            }
            
            /// <summary>
            /// Обхват шеи макс
            /// </summary>
            public static String ОбхватШеиМакс
            {
                get
                {
                    return "ОбхватШеиМакс";
                }
            }
            
            /// <summary>
            /// Длина ступни макс
            /// </summary>
            public static String ДлинаСтупниМакс
            {
                get
                {
                    return "ДлинаСтупниМакс";
                }
            }
            
            /// <summary>
            /// Вид размерной сетки
            /// </summary>
            public static String ВидРазмернойСетки
            {
                get
                {
                    return "ВидРазмернойСетки";
                }
            }
            
            /// <summary>
            /// Боковая длина брюк мин
            /// </summary>
            public static String БоковаяДлинаБрюкМин
            {
                get
                {
                    return "БоковаяДлинаБрюкМин";
                }
            }
            
            /// <summary>
            /// Длина рукава мин
            /// </summary>
            public static String ДлинаРукаваМин
            {
                get
                {
                    return "ДлинаРукаваМин";
                }
            }
            
            /// <summary>
            /// Длина ступни мин
            /// </summary>
            public static String ДлинаСтупниМин
            {
                get
                {
                    return "ДлинаСтупниМин";
                }
            }
            
            /// <summary>
            /// Боковая длина брюк макс
            /// </summary>
            public static String БоковаяДлинаБрюкМакс
            {
                get
                {
                    return "БоковаяДлинаБрюкМакс";
                }
            }
            
            /// <summary>
            /// Обхват головы макс
            /// </summary>
            public static String ОбхватГоловыМакс
            {
                get
                {
                    return "ОбхватГоловыМакс";
                }
            }
            
            /// <summary>
            /// Обхват головы мин
            /// </summary>
            public static String ОбхватГоловыМин
            {
                get
                {
                    return "ОбхватГоловыМин";
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
                    descriptor.Name = "Размеры";
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
            return "Учет.Размеры";
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
        /// Вид свойств номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.ВидСвойствНоменклатуры)__ВидСвойствНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                __ВидСвойствНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Рост макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal РостМакс
        {
            get
            {
				 NsgDataFloat __РостМакс = ObjectList["РостМакс"] as NsgDataFloat;
                 return (System.Decimal)__РостМакс.Value;
            }
            set
            {
                NsgDataFloat __РостМакс = ObjectList["РостМакс"] as NsgDataFloat;
                __РостМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват груди мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГрудиМин
        {
            get
            {
				 NsgDataFloat __ОбхватГрудиМин = ObjectList["ОбхватГрудиМин"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГрудиМин.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГрудиМин = ObjectList["ОбхватГрудиМин"] as NsgDataFloat;
                __ОбхватГрудиМин.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват талии мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватТалииМин
        {
            get
            {
				 NsgDataFloat __ОбхватТалииМин = ObjectList["ОбхватТалииМин"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватТалииМин.Value;
            }
            set
            {
                NsgDataFloat __ОбхватТалииМин = ObjectList["ОбхватТалииМин"] as NsgDataFloat;
                __ОбхватТалииМин.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват талии макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватТалииМакс
        {
            get
            {
				 NsgDataFloat __ОбхватТалииМакс = ObjectList["ОбхватТалииМакс"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватТалииМакс.Value;
            }
            set
            {
                NsgDataFloat __ОбхватТалииМакс = ObjectList["ОбхватТалииМакс"] as NsgDataFloat;
                __ОбхватТалииМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват бедер мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватБедерМин
        {
            get
            {
				 NsgDataFloat __ОбхватБедерМин = ObjectList["ОбхватБедерМин"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватБедерМин.Value;
            }
            set
            {
                NsgDataFloat __ОбхватБедерМин = ObjectList["ОбхватБедерМин"] as NsgDataFloat;
                __ОбхватБедерМин.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват бедер макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватБедерМакс
        {
            get
            {
				 NsgDataFloat __ОбхватБедерМакс = ObjectList["ОбхватБедерМакс"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватБедерМакс.Value;
            }
            set
            {
                NsgDataFloat __ОбхватБедерМакс = ObjectList["ОбхватБедерМакс"] as NsgDataFloat;
                __ОбхватБедерМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Внутренняя длина брюк мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ВнутренняяДлинаБрюкМин
        {
            get
            {
				 NsgDataFloat __ВнутренняяДлинаБрюкМин = ObjectList["ВнутренняяДлинаБрюкМин"] as NsgDataFloat;
                 return (System.Decimal)__ВнутренняяДлинаБрюкМин.Value;
            }
            set
            {
                NsgDataFloat __ВнутренняяДлинаБрюкМин = ObjectList["ВнутренняяДлинаБрюкМин"] as NsgDataFloat;
                __ВнутренняяДлинаБрюкМин.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват шеи мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватШеиМин
        {
            get
            {
				 NsgDataFloat __ОбхватШеиМин = ObjectList["ОбхватШеиМин"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватШеиМин.Value;
            }
            set
            {
                NsgDataFloat __ОбхватШеиМин = ObjectList["ОбхватШеиМин"] as NsgDataFloat;
                __ОбхватШеиМин.Value = value;
            }
        }
        
        /// <summary>
        /// Внутренняя длина брюк макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ВнутренняяДлинаБрюкМакс
        {
            get
            {
				 NsgDataFloat __ВнутренняяДлинаБрюкМакс = ObjectList["ВнутренняяДлинаБрюкМакс"] as NsgDataFloat;
                 return (System.Decimal)__ВнутренняяДлинаБрюкМакс.Value;
            }
            set
            {
                NsgDataFloat __ВнутренняяДлинаБрюкМакс = ObjectList["ВнутренняяДлинаБрюкМакс"] as NsgDataFloat;
                __ВнутренняяДлинаБрюкМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Длина рукава макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаРукаваМакс
        {
            get
            {
				 NsgDataFloat __ДлинаРукаваМакс = ObjectList["ДлинаРукаваМакс"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаРукаваМакс.Value;
            }
            set
            {
                NsgDataFloat __ДлинаРукаваМакс = ObjectList["ДлинаРукаваМакс"] as NsgDataFloat;
                __ДлинаРукаваМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват груди макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГрудиМакс
        {
            get
            {
				 NsgDataFloat __ОбхватГрудиМакс = ObjectList["ОбхватГрудиМакс"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГрудиМакс.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГрудиМакс = ObjectList["ОбхватГрудиМакс"] as NsgDataFloat;
                __ОбхватГрудиМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Рост мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal РостМин
        {
            get
            {
				 NsgDataFloat __РостМин = ObjectList["РостМин"] as NsgDataFloat;
                 return (System.Decimal)__РостМин.Value;
            }
            set
            {
                NsgDataFloat __РостМин = ObjectList["РостМин"] as NsgDataFloat;
                __РостМин.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват шеи макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватШеиМакс
        {
            get
            {
				 NsgDataFloat __ОбхватШеиМакс = ObjectList["ОбхватШеиМакс"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватШеиМакс.Value;
            }
            set
            {
                NsgDataFloat __ОбхватШеиМакс = ObjectList["ОбхватШеиМакс"] as NsgDataFloat;
                __ОбхватШеиМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Длина ступни макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаСтупниМакс
        {
            get
            {
				 NsgDataFloat __ДлинаСтупниМакс = ObjectList["ДлинаСтупниМакс"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаСтупниМакс.Value;
            }
            set
            {
                NsgDataFloat __ДлинаСтупниМакс = ObjectList["ДлинаСтупниМакс"] as NsgDataFloat;
                __ДлинаСтупниМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Вид размерной сетки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public УчетСпецодеждыИСИЗ.ВидыРазмернойСетки ВидРазмернойСетки
        {
            get
            {
				 NsgDataTypedReference __ВидРазмернойСетки = ObjectList["ВидРазмернойСетки"] as NsgDataTypedReference;
                 return (УчетСпецодеждыИСИЗ.ВидыРазмернойСетки)__ВидРазмернойСетки.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидРазмернойСетки = ObjectList["ВидРазмернойСетки"] as NsgDataTypedReference;
                __ВидРазмернойСетки.Referent = value;
            }
        }
        
        /// <summary>
        /// Боковая длина брюк мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal БоковаяДлинаБрюкМин
        {
            get
            {
				 NsgDataFloat __БоковаяДлинаБрюкМин = ObjectList["БоковаяДлинаБрюкМин"] as NsgDataFloat;
                 return (System.Decimal)__БоковаяДлинаБрюкМин.Value;
            }
            set
            {
                NsgDataFloat __БоковаяДлинаБрюкМин = ObjectList["БоковаяДлинаБрюкМин"] as NsgDataFloat;
                __БоковаяДлинаБрюкМин.Value = value;
            }
        }
        
        /// <summary>
        /// Длина рукава мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаРукаваМин
        {
            get
            {
				 NsgDataFloat __ДлинаРукаваМин = ObjectList["ДлинаРукаваМин"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаРукаваМин.Value;
            }
            set
            {
                NsgDataFloat __ДлинаРукаваМин = ObjectList["ДлинаРукаваМин"] as NsgDataFloat;
                __ДлинаРукаваМин.Value = value;
            }
        }
        
        /// <summary>
        /// Длина ступни мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаСтупниМин
        {
            get
            {
				 NsgDataFloat __ДлинаСтупниМин = ObjectList["ДлинаСтупниМин"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаСтупниМин.Value;
            }
            set
            {
                NsgDataFloat __ДлинаСтупниМин = ObjectList["ДлинаСтупниМин"] as NsgDataFloat;
                __ДлинаСтупниМин.Value = value;
            }
        }
        
        /// <summary>
        /// Боковая длина брюк макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal БоковаяДлинаБрюкМакс
        {
            get
            {
				 NsgDataFloat __БоковаяДлинаБрюкМакс = ObjectList["БоковаяДлинаБрюкМакс"] as NsgDataFloat;
                 return (System.Decimal)__БоковаяДлинаБрюкМакс.Value;
            }
            set
            {
                NsgDataFloat __БоковаяДлинаБрюкМакс = ObjectList["БоковаяДлинаБрюкМакс"] as NsgDataFloat;
                __БоковаяДлинаБрюкМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват головы макс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГоловыМакс
        {
            get
            {
				 NsgDataFloat __ОбхватГоловыМакс = ObjectList["ОбхватГоловыМакс"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГоловыМакс.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГоловыМакс = ObjectList["ОбхватГоловыМакс"] as NsgDataFloat;
                __ОбхватГоловыМакс.Value = value;
            }
        }
        
        /// <summary>
        /// Обхват головы мин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ОбхватГоловыМин
        {
            get
            {
				 NsgDataFloat __ОбхватГоловыМин = ObjectList["ОбхватГоловыМин"] as NsgDataFloat;
                 return (System.Decimal)__ОбхватГоловыМин.Value;
            }
            set
            {
                NsgDataFloat __ОбхватГоловыМин = ObjectList["ОбхватГоловыМин"] as NsgDataFloat;
                __ОбхватГоловыМин.Value = value;
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
        public Размеры Родитель
        {
            get
            {
                return base.Parent as Размеры;
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
        private Размеры[] convertArray(NsgMultipleObject[] array)
        {
            Размеры[] res = new Размеры[array.Length];
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
        public new virtual Размеры[] FindAll(NsgCompare compare)
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
        public new virtual Размеры[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Размеры[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Размеры[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Размеры(this as NsgObject);
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
                base.NSGType = typeof(Размеры);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Размеры Value
            {
                get
                {
                    return (Размеры)base.Value;
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
