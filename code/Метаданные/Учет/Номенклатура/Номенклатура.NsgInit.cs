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
    
    [NsgTypeName("NsgDataDictionary", Guid = "3e503a15-be62-4faa-bfb7-42895bfdad61")]
    public partial class Номенклатура : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Номенклатура()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Номенклатура(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Номенклатура Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3e503a15-be62-4faa-bfb7-42895bfdad61"));
            if (obj == null)
                obj = new Номенклатура();
            return obj as Номенклатура;
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
	Идентификатор.Guid = NsgService.StringToGuid("8e4b9b50-0a88-4e73-8391-69495cfbf3e6");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("091ff146-8d65-4b54-9933-8b68dadb8725");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("2dfdc138-4234-4563-b124-fc6a1da6b4c5");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("85252b2b-9baf-403b-ab57-3d368983f360");
	
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
	Уровень.Guid = NsgService.StringToGuid("bbbd9739-21a7-42e3-8ef4-e35c382b6fa7");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("9f153b83-6950-46b4-b308-68c81ae7ac8a");
	
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
	НомерКода.Guid = NsgService.StringToGuid("c0234cc6-075d-44de-bbb1-85700a292c1a");
	
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
	Код.Guid = NsgService.StringToGuid("3128abb5-170e-4347-adde-254227361b96");
	
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
	Наименование.Guid = NsgService.StringToGuid("1677671f-eb45-4511-a46b-7e873495f89c");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("168008b8-af62-4f0a-a711-748673bd7c6f");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("6fe685f0-8a31-4ef4-a087-d612e739534b");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание Учет.ВидСвойствНоменклатуры ВидНоменклатуры
			{  
                NsgDataTypedReference ВидНоменклатуры = null;
				if (ObjectList.Contains("ВидНоменклатуры"))
                    ВидНоменклатуры = ObjectList["ВидНоменклатуры"] as NsgDataTypedReference;
                else
                    ВидНоменклатуры = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидНоменклатуры.IsLoadedFromDll = true;
	ВидНоменклатуры.ReferentGroup = "Учет";
	ВидНоменклатуры.ReferentName = "ВидСвойствНоменклатуры";
	ВидНоменклатуры.SaveInDatabase = true;
	ВидНоменклатуры.OwnerName = "";
	ВидНоменклатуры.AllowEmptyOwner = false;
	ВидНоменклатуры.StringFormat = "";
	ВидНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВидНоменклатуры.IncludeInPredefined = false;
	ВидНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидНоменклатуры.Required = false;
	ВидНоменклатуры.EmptyValue = "";
	ВидНоменклатуры.NullAllow = false;
	ВидНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидНоменклатуры.FieldName = "VidNomenklatury";
	ВидНоменклатуры.InformMetaDataOnValueChanged = false;
	ВидНоменклатуры.Visible = true;
	ВидНоменклатуры.Name = "ВидНоменклатуры";
	ВидНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидНоменклатуры.Description = "Вид номенклатуры";
	ВидНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидНоменклатуры.GroupName = "";
	ВидНоменклатуры.Guid = NsgService.StringToGuid("9c4565f7-e393-412a-888f-425c173e751b");
	
				if (!ObjectList.Contains("ВидНоменклатуры"))
                    ObjectList.Add(ВидНоменклатуры);
			}
			#endregion //создание Учет.ВидСвойствНоменклатуры ВидНоменклатуры
			
			#region создание System.DateTime ПоследнееИзменение
			{  
                NsgDataDateTime ПоследнееИзменение = null;
				if (ObjectList.Contains("ПоследнееИзменение"))
                    ПоследнееИзменение = ObjectList["ПоследнееИзменение"] as NsgDataDateTime;
                else
                    ПоследнееИзменение = new NsgDataDateTime();
	//NsgDataDateTime
	ПоследнееИзменение.IsLoadedFromDll = true;
	ПоследнееИзменение.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ПоследнееИзменение.StringFormat = "";
	ПоследнееИзменение.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПоследнееИзменение.IncludeInPredefined = false;
	ПоследнееИзменение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПоследнееИзменение.Required = false;
	ПоследнееИзменение.EmptyValue = "";
	ПоследнееИзменение.NullAllow = false;
	ПоследнееИзменение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПоследнееИзменение.FieldName = "PosledneeIzmenenie";
	ПоследнееИзменение.SaveInDatabase = true;
	ПоследнееИзменение.InformMetaDataOnValueChanged = false;
	ПоследнееИзменение.Visible = true;
	ПоследнееИзменение.Name = "ПоследнееИзменение";
	ПоследнееИзменение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПоследнееИзменение.Description = "Последнее изменение";
	ПоследнееИзменение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПоследнееИзменение.GroupName = "";
	ПоследнееИзменение.Guid = NsgService.StringToGuid("c5f7737d-b16b-46f6-b4de-3f6c39a0eaae");
	
				if (!ObjectList.Contains("ПоследнееИзменение"))
                    ObjectList.Add(ПоследнееИзменение);
			}
			#endregion //создание System.DateTime ПоследнееИзменение
			
			#region создание Учет.ТипНоменклатуры ТипНоменклатуры
			{  
                NsgDataEnumReference ТипНоменклатуры = null;
				if (ObjectList.Contains("ТипНоменклатуры"))
                    ТипНоменклатуры = ObjectList["ТипНоменклатуры"] as NsgDataEnumReference;
                else
                    ТипНоменклатуры = new NsgDataEnumReference();
	//NsgDataEnumReference
	ТипНоменклатуры.IsLoadedFromDll = true;
	ТипНоменклатуры.ReferentGroup = "Учет";
	ТипНоменклатуры.ReferentName = "ТипНоменклатуры";
	ТипНоменклатуры.SaveInDatabase = true;
	ТипНоменклатуры.OwnerName = "";
	ТипНоменклатуры.AllowEmptyOwner = false;
	ТипНоменклатуры.StringFormat = "";
	ТипНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТипНоменклатуры.IncludeInPredefined = false;
	ТипНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипНоменклатуры.Required = false;
	ТипНоменклатуры.EmptyValue = "";
	ТипНоменклатуры.NullAllow = false;
	ТипНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипНоменклатуры.FieldName = "TipNomenklatury";
	ТипНоменклатуры.InformMetaDataOnValueChanged = false;
	ТипНоменклатуры.Visible = true;
	ТипНоменклатуры.Name = "ТипНоменклатуры";
	ТипНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипНоменклатуры.Description = "Тип номенклатуры";
	ТипНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипНоменклатуры.GroupName = "";
	ТипНоменклатуры.Guid = NsgService.StringToGuid("d4a2fe39-4ffa-4b5a-817b-d46e07950c3b");
	
				if (!ObjectList.Contains("ТипНоменклатуры"))
                    ObjectList.Add(ТипНоменклатуры);
			}
			#endregion //создание Учет.ТипНоменклатуры ТипНоменклатуры
			
			#region создание Учет.КатегорияНоменклатуры КатегорияНоменклатуры
			{  
                NsgDataTypedReference КатегорияНоменклатуры = null;
				if (ObjectList.Contains("КатегорияНоменклатуры"))
                    КатегорияНоменклатуры = ObjectList["КатегорияНоменклатуры"] as NsgDataTypedReference;
                else
                    КатегорияНоменклатуры = new NsgDataTypedReference();
	//NsgDataTypedReference
	КатегорияНоменклатуры.IsLoadedFromDll = true;
	КатегорияНоменклатуры.ReferentGroup = "Учет";
	КатегорияНоменклатуры.ReferentName = "КатегорияНоменклатуры";
	КатегорияНоменклатуры.SaveInDatabase = true;
	КатегорияНоменклатуры.OwnerName = "";
	КатегорияНоменклатуры.AllowEmptyOwner = false;
	КатегорияНоменклатуры.StringFormat = "";
	КатегорияНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КатегорияНоменклатуры.IncludeInPredefined = false;
	КатегорияНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КатегорияНоменклатуры.Required = false;
	КатегорияНоменклатуры.EmptyValue = "";
	КатегорияНоменклатуры.NullAllow = false;
	КатегорияНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КатегорияНоменклатуры.FieldName = "KategorijaNomenkl";
	КатегорияНоменклатуры.InformMetaDataOnValueChanged = false;
	КатегорияНоменклатуры.Visible = true;
	КатегорияНоменклатуры.Name = "КатегорияНоменклатуры";
	КатегорияНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КатегорияНоменклатуры.Description = "Категория номенклатуры";
	КатегорияНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КатегорияНоменклатуры.GroupName = "";
	КатегорияНоменклатуры.Guid = NsgService.StringToGuid("7a34651d-e88b-4404-94a0-d80fc89ecea8");
	
				if (!ObjectList.Contains("КатегорияНоменклатуры"))
                    ObjectList.Add(КатегорияНоменклатуры);
			}
			#endregion //создание Учет.КатегорияНоменклатуры КатегорияНоменклатуры
			
			#region создание TechControl.Метаданные.Учет.НоменклатураФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Учет.НоменклатураФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("4f4c18d7-58c2-46fe-a4cc-646fe68cb451");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Учет.НоменклатураФормаЭлемента ФормаЭлемента
			
			#region создание System.Int64 СрокПоставкиДней
			{  
                NsgDataInteger СрокПоставкиДней = null;
				if (ObjectList.Contains("СрокПоставкиДней"))
                    СрокПоставкиДней = ObjectList["СрокПоставкиДней"] as NsgDataInteger;
                else
                    СрокПоставкиДней = new NsgDataInteger();
	//NsgDataInteger
	СрокПоставкиДней.IsLoadedFromDll = true;
	СрокПоставкиДней.DefaultValue = 0M;
	СрокПоставкиДней.MinValue = 0M;
	СрокПоставкиДней.MaxValue = 0M;
	СрокПоставкиДней.UseCalculator = true;
	СрокПоставкиДней.StringFormat = "";
	СрокПоставкиДней.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СрокПоставкиДней.IncludeInPredefined = false;
	СрокПоставкиДней.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СрокПоставкиДней.Required = false;
	СрокПоставкиДней.EmptyValue = "";
	СрокПоставкиДней.NullAllow = false;
	СрокПоставкиДней.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СрокПоставкиДней.FieldName = "SrokPostavkiDneij";
	СрокПоставкиДней.SaveInDatabase = true;
	СрокПоставкиДней.InformMetaDataOnValueChanged = false;
	СрокПоставкиДней.Visible = true;
	СрокПоставкиДней.Name = "СрокПоставкиДней";
	СрокПоставкиДней.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СрокПоставкиДней.Description = "Срок поставки дней";
	СрокПоставкиДней.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СрокПоставкиДней.GroupName = "";
	СрокПоставкиДней.Guid = NsgService.StringToGuid("fee67bad-efc8-43fa-a738-a021462163de");
	
				if (!ObjectList.Contains("СрокПоставкиДней"))
                    ObjectList.Add(СрокПоставкиДней);
			}
			#endregion //создание System.Int64 СрокПоставкиДней
			
			#region создание Учет.ПланыАмортизации ПланАмортизации
			{  
                NsgDataTypedReference ПланАмортизации = null;
				if (ObjectList.Contains("ПланАмортизации"))
                    ПланАмортизации = ObjectList["ПланАмортизации"] as NsgDataTypedReference;
                else
                    ПланАмортизации = new NsgDataTypedReference();
	//NsgDataTypedReference
	ПланАмортизации.IsLoadedFromDll = true;
	ПланАмортизации.ReferentGroup = "Учет";
	ПланАмортизации.ReferentName = "ПланыАмортизации";
	ПланАмортизации.SaveInDatabase = true;
	ПланАмортизации.OwnerName = "";
	ПланАмортизации.AllowEmptyOwner = false;
	ПланАмортизации.StringFormat = "";
	ПланАмортизации.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПланАмортизации.IncludeInPredefined = false;
	ПланАмортизации.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПланАмортизации.Required = false;
	ПланАмортизации.EmptyValue = "";
	ПланАмортизации.NullAllow = false;
	ПланАмортизации.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПланАмортизации.FieldName = "PlanAmortizacii";
	ПланАмортизации.InformMetaDataOnValueChanged = false;
	ПланАмортизации.Visible = true;
	ПланАмортизации.Name = "ПланАмортизации";
	ПланАмортизации.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПланАмортизации.Description = "План амортизации";
	ПланАмортизации.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПланАмортизации.GroupName = "";
	ПланАмортизации.Guid = NsgService.StringToGuid("38793015-2a2c-40f6-adac-3f432658998c");
	
				if (!ObjectList.Contains("ПланАмортизации"))
                    ObjectList.Add(ПланАмортизации);
			}
			#endregion //создание Учет.ПланыАмортизации ПланАмортизации
			
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
	ВидРазмернойСетки.Guid = NsgService.StringToGuid("41ed2854-de40-4710-bd1a-1d4a630a3b99");
	
				if (!ObjectList.Contains("ВидРазмернойСетки"))
                    ObjectList.Add(ВидРазмернойСетки);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.ВидыРазмернойСетки ВидРазмернойСетки
			
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
	Поставщик.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	Поставщик.Guid = NsgService.StringToGuid("6565407b-1cb8-4bba-902a-fa2e53c2c70b");
	
				if (!ObjectList.Contains("Поставщик"))
                    ObjectList.Add(Поставщик);
			}
			#endregion //создание Мониторинг.Контрагенты Поставщик
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Номенклатура";
	Visible = true;
	Guid = NsgService.StringToGuid("3e503a15-be62-4faa-bfb7-42895bfdad61");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Nomenklatura";
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
            /// Вид номенклатуры
            /// </summary>
            public static String ВидНоменклатуры
            {
                get
                {
                    return "ВидНоменклатуры";
                }
            }
            
            /// <summary>
            /// Последнее изменение
            /// </summary>
            public static String ПоследнееИзменение
            {
                get
                {
                    return "ПоследнееИзменение";
                }
            }
            
            /// <summary>
            /// Тип номенклатуры
            /// </summary>
            public static String ТипНоменклатуры
            {
                get
                {
                    return "ТипНоменклатуры";
                }
            }
            
            /// <summary>
            /// Категория номенклатуры
            /// </summary>
            public static String КатегорияНоменклатуры
            {
                get
                {
                    return "КатегорияНоменклатуры";
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
            /// Срок поставки дней
            /// </summary>
            public static String СрокПоставкиДней
            {
                get
                {
                    return "СрокПоставкиДней";
                }
            }
            
            /// <summary>
            /// План амортизации
            /// </summary>
            public static String ПланАмортизации
            {
                get
                {
                    return "ПланАмортизации";
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
            /// Поставщик
            /// </summary>
            public static String Поставщик
            {
                get
                {
                    return "Поставщик";
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
                    descriptor.Name = "Номенклатура";
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
            return "Учет.Номенклатура";
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
        /// Вид номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ВидСвойствНоменклатуры ВидНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __ВидНоменклатуры = ObjectList["ВидНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.ВидСвойствНоменклатуры)__ВидНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидНоменклатуры = ObjectList["ВидНоменклатуры"] as NsgDataTypedReference;
                __ВидНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Последнее изменение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ПоследнееИзменение
        {
            get
            {
				 NsgDataDateTime __ПоследнееИзменение = ObjectList["ПоследнееИзменение"] as NsgDataDateTime;
                 return (System.DateTime)__ПоследнееИзменение.Value;
            }
            set
            {
                NsgDataDateTime __ПоследнееИзменение = ObjectList["ПоследнееИзменение"] as NsgDataDateTime;
                __ПоследнееИзменение.Value = value;
            }
        }
        
        /// <summary>
        /// Тип номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Учет.ТипНоменклатуры ТипНоменклатуры
        {
            get
            {
				 NsgDataEnumReference __ТипНоменклатуры = ObjectList["ТипНоменклатуры"] as NsgDataEnumReference;
                 return (Учет.ТипНоменклатуры)__ТипНоменклатуры.Referent;
            }
            set
            {
                NsgDataEnumReference __ТипНоменклатуры = ObjectList["ТипНоменклатуры"] as NsgDataEnumReference;
                __ТипНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Категория номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.КатегорияНоменклатуры КатегорияНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __КатегорияНоменклатуры = ObjectList["КатегорияНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.КатегорияНоменклатуры)__КатегорияНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __КатегорияНоменклатуры = ObjectList["КатегорияНоменклатуры"] as NsgDataTypedReference;
                __КатегорияНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Срок поставки дней
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 СрокПоставкиДней
        {
            get
            {
				 NsgDataInteger __СрокПоставкиДней = ObjectList["СрокПоставкиДней"] as NsgDataInteger;
                 return (System.Int64)__СрокПоставкиДней.Value;
            }
            set
            {
                NsgDataInteger __СрокПоставкиДней = ObjectList["СрокПоставкиДней"] as NsgDataInteger;
                __СрокПоставкиДней.Value = value;
            }
        }
        
        /// <summary>
        /// План амортизации
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ПланыАмортизации ПланАмортизации
        {
            get
            {
				 NsgDataTypedReference __ПланАмортизации = ObjectList["ПланАмортизации"] as NsgDataTypedReference;
                 return (Учет.ПланыАмортизации)__ПланАмортизации.Referent;
            }
            set
            {
                NsgDataTypedReference __ПланАмортизации = ObjectList["ПланАмортизации"] as NsgDataTypedReference;
                __ПланАмортизации.Referent = value;
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
        public Номенклатура Родитель
        {
            get
            {
                return base.Parent as Номенклатура;
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
        private Номенклатура[] convertArray(NsgMultipleObject[] array)
        {
            Номенклатура[] res = new Номенклатура[array.Length];
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
        public new virtual Номенклатура[] FindAll(NsgCompare compare)
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
        public new virtual Номенклатура[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Номенклатура[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Номенклатура[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Номенклатура(this as NsgObject);
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
                base.NSGType = typeof(Номенклатура);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Номенклатура Value
            {
                get
                {
                    return (Номенклатура)base.Value;
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
