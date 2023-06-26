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
	БоковаяДлинаБрюк.Guid = NsgService.StringToGuid("a3f02804-ca73-4105-bfc1-52474595bdf9");
	
				if (!ObjectList.Contains("БоковаяДлинаБрюк"))
                    ObjectList.Add(БоковаяДлинаБрюк);
			}
			#endregion //создание System.Decimal БоковаяДлинаБрюк
			
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
			
			#region создание System.Decimal ВнутренняяДлинаБрюк
			{  
                NsgDataFloat ВнутренняяДлинаБрюк = null;
				if (ObjectList.Contains("ВнутренняяДлинаБрюк"))
                    ВнутренняяДлинаБрюк = ObjectList["ВнутренняяДлинаБрюк"] as NsgDataFloat;
                else
                    ВнутренняяДлинаБрюк = new NsgDataFloat();
	//NsgDataFloat
	ВнутренняяДлинаБрюк.IsLoadedFromDll = true;
	ВнутренняяДлинаБрюк.Precision = 2;
	ВнутренняяДлинаБрюк.HideZero = true;
	ВнутренняяДлинаБрюк.DefaultValue = 0M;
	ВнутренняяДлинаБрюк.MinValue = -100000000000000000M;
	ВнутренняяДлинаБрюк.MaxValue = 100000000000000000M;
	ВнутренняяДлинаБрюк.UseCalculator = true;
	ВнутренняяДлинаБрюк.StringFormat = "";
	ВнутренняяДлинаБрюк.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВнутренняяДлинаБрюк.IncludeInPredefined = false;
	ВнутренняяДлинаБрюк.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВнутренняяДлинаБрюк.Required = false;
	ВнутренняяДлинаБрюк.EmptyValue = "";
	ВнутренняяДлинаБрюк.NullAllow = false;
	ВнутренняяДлинаБрюк.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВнутренняяДлинаБрюк.FieldName = "VnutrennjajaDlina";
	ВнутренняяДлинаБрюк.SaveInDatabase = true;
	ВнутренняяДлинаБрюк.InformMetaDataOnValueChanged = false;
	ВнутренняяДлинаБрюк.Visible = true;
	ВнутренняяДлинаБрюк.Name = "ВнутренняяДлинаБрюк";
	ВнутренняяДлинаБрюк.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВнутренняяДлинаБрюк.Description = "Внутренняя длина брюк";
	ВнутренняяДлинаБрюк.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВнутренняяДлинаБрюк.GroupName = "";
	ВнутренняяДлинаБрюк.Guid = NsgService.StringToGuid("674ba73a-3100-42ca-bb8d-4cc89578e8cd");
	
				if (!ObjectList.Contains("ВнутренняяДлинаБрюк"))
                    ObjectList.Add(ВнутренняяДлинаБрюк);
			}
			#endregion //создание System.Decimal ВнутренняяДлинаБрюк
			
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
	ДлинаРукава.Guid = NsgService.StringToGuid("ac01e391-9024-4c8c-89b8-f4b726efe98c");
	
				if (!ObjectList.Contains("ДлинаРукава"))
                    ObjectList.Add(ДлинаРукава);
			}
			#endregion //создание System.Decimal ДлинаРукава
			
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
			
			#region создание System.Decimal ДлинаСтупни
			{  
                NsgDataFloat ДлинаСтупни = null;
				if (ObjectList.Contains("ДлинаСтупни"))
                    ДлинаСтупни = ObjectList["ДлинаСтупни"] as NsgDataFloat;
                else
                    ДлинаСтупни = new NsgDataFloat();
	//NsgDataFloat
	ДлинаСтупни.IsLoadedFromDll = true;
	ДлинаСтупни.Precision = 2;
	ДлинаСтупни.HideZero = true;
	ДлинаСтупни.DefaultValue = 0M;
	ДлинаСтупни.MinValue = -100000000000000000M;
	ДлинаСтупни.MaxValue = 100000000000000000M;
	ДлинаСтупни.UseCalculator = true;
	ДлинаСтупни.StringFormat = "";
	ДлинаСтупни.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДлинаСтупни.IncludeInPredefined = false;
	ДлинаСтупни.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлинаСтупни.Required = false;
	ДлинаСтупни.EmptyValue = "";
	ДлинаСтупни.NullAllow = false;
	ДлинаСтупни.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлинаСтупни.FieldName = "DlinaStupni";
	ДлинаСтупни.SaveInDatabase = true;
	ДлинаСтупни.InformMetaDataOnValueChanged = false;
	ДлинаСтупни.Visible = true;
	ДлинаСтупни.Name = "ДлинаСтупни";
	ДлинаСтупни.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлинаСтупни.Description = "Длина ступни";
	ДлинаСтупни.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлинаСтупни.GroupName = "";
	ДлинаСтупни.Guid = NsgService.StringToGuid("5fb0251f-eb59-4b4e-abc8-a1067407dd75");
	
				if (!ObjectList.Contains("ДлинаСтупни"))
                    ObjectList.Add(ДлинаСтупни);
			}
			#endregion //создание System.Decimal ДлинаСтупни
			
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
            /// Внутренняя длина брюк
            /// </summary>
            public static String ВнутренняяДлинаБрюк
            {
                get
                {
                    return "ВнутренняяДлинаБрюк";
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
            /// Длина ступни
            /// </summary>
            public static String ДлинаСтупни
            {
                get
                {
                    return "ДлинаСтупни";
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
        /// Внутренняя длина брюк
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ВнутренняяДлинаБрюк
        {
            get
            {
				 NsgDataFloat __ВнутренняяДлинаБрюк = ObjectList["ВнутренняяДлинаБрюк"] as NsgDataFloat;
                 return (System.Decimal)__ВнутренняяДлинаБрюк.Value;
            }
            set
            {
                NsgDataFloat __ВнутренняяДлинаБрюк = ObjectList["ВнутренняяДлинаБрюк"] as NsgDataFloat;
                __ВнутренняяДлинаБрюк.Value = value;
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
        /// Длина ступни
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлинаСтупни
        {
            get
            {
				 NsgDataFloat __ДлинаСтупни = ObjectList["ДлинаСтупни"] as NsgDataFloat;
                 return (System.Decimal)__ДлинаСтупни.Value;
            }
            set
            {
                NsgDataFloat __ДлинаСтупни = ObjectList["ДлинаСтупни"] as NsgDataFloat;
                __ДлинаСтупни.Value = value;
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
