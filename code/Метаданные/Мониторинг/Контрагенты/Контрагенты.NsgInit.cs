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
    
    [NsgTypeName("NsgDataDictionary", Guid = "db34431e-a7fe-44ea-9092-d1d01193ec1f")]
    public partial class Контрагенты : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Контрагенты()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Контрагенты(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Контрагенты Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("db34431e-a7fe-44ea-9092-d1d01193ec1f"));
            if (obj == null)
                obj = new Контрагенты();
            return obj as Контрагенты;
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
	Идентификатор.Guid = NsgService.StringToGuid("1c87b57f-b928-4c99-920b-d9db3b4919b9");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("f8e6d4c8-9765-4ce6-ad2d-180868e33f29");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("233372d1-69df-4db0-8677-e2794f393c49");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("406aed06-194d-4b2d-b677-3c529ef5edf5");
	
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
	Уровень.Guid = NsgService.StringToGuid("96ddc1eb-a63d-453a-87e5-660ebbdb9afd");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("da84bd31-a997-4752-b203-0a0f56710d11");
	
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
	НомерКода.Guid = NsgService.StringToGuid("fadda410-f0fb-423c-bc6f-f918a87dfbb6");
	
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
	Код.Guid = NsgService.StringToGuid("c58a5433-b5e4-4bde-a97f-a75160846959");
	
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
	Наименование.Guid = NsgService.StringToGuid("28d0b979-179a-4b05-81e5-cdfe5e267570");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("12726e59-5976-423a-9047-cf4fbd3f1639");
	
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
	Адрес.Length = 100;
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
	Адрес.Guid = NsgService.StringToGuid("b750d330-f33e-42ef-bfbd-efa94acfae6a");
	
				if (!ObjectList.Contains("Адрес"))
                    ObjectList.Add(Адрес);
			}
			#endregion //создание System.String Адрес
			
			#region создание System.Boolean ЯвляетсяНашейФирмой
			{  
                NsgDataBoolean ЯвляетсяНашейФирмой = null;
				if (ObjectList.Contains("ЯвляетсяНашейФирмой"))
                    ЯвляетсяНашейФирмой = ObjectList["ЯвляетсяНашейФирмой"] as NsgDataBoolean;
                else
                    ЯвляетсяНашейФирмой = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяНашейФирмой.IsLoadedFromDll = true;
	ЯвляетсяНашейФирмой.DefaultValue = false;
	ЯвляетсяНашейФирмой.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяНашейФирмой.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяНашейФирмой.StringFormat = "";
	ЯвляетсяНашейФирмой.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяНашейФирмой.IncludeInPredefined = false;
	ЯвляетсяНашейФирмой.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяНашейФирмой.Required = false;
	ЯвляетсяНашейФирмой.EmptyValue = "";
	ЯвляетсяНашейФирмой.NullAllow = false;
	ЯвляетсяНашейФирмой.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяНашейФирмой.FieldName = "JAvljaetsjaNashei";
	ЯвляетсяНашейФирмой.SaveInDatabase = true;
	ЯвляетсяНашейФирмой.InformMetaDataOnValueChanged = false;
	ЯвляетсяНашейФирмой.Visible = true;
	ЯвляетсяНашейФирмой.Name = "ЯвляетсяНашейФирмой";
	ЯвляетсяНашейФирмой.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяНашейФирмой.Description = "Является нашей фирмой";
	ЯвляетсяНашейФирмой.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяНашейФирмой.GroupName = "";
	ЯвляетсяНашейФирмой.Guid = NsgService.StringToGuid("324620ea-e83c-471f-b184-dcf9d0bdf5d3");
	
				if (!ObjectList.Contains("ЯвляетсяНашейФирмой"))
                    ObjectList.Add(ЯвляетсяНашейФирмой);
			}
			#endregion //создание System.Boolean ЯвляетсяНашейФирмой
			
			#region создание System.Boolean ЯвляетсяПодрядчиком
			{  
                NsgDataBoolean ЯвляетсяПодрядчиком = null;
				if (ObjectList.Contains("ЯвляетсяПодрядчиком"))
                    ЯвляетсяПодрядчиком = ObjectList["ЯвляетсяПодрядчиком"] as NsgDataBoolean;
                else
                    ЯвляетсяПодрядчиком = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяПодрядчиком.IsLoadedFromDll = true;
	ЯвляетсяПодрядчиком.DefaultValue = false;
	ЯвляетсяПодрядчиком.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПодрядчиком.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПодрядчиком.StringFormat = "";
	ЯвляетсяПодрядчиком.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяПодрядчиком.IncludeInPredefined = false;
	ЯвляетсяПодрядчиком.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяПодрядчиком.Required = false;
	ЯвляетсяПодрядчиком.EmptyValue = "";
	ЯвляетсяПодрядчиком.NullAllow = false;
	ЯвляетсяПодрядчиком.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяПодрядчиком.FieldName = "JAvljaetsjaPodrja";
	ЯвляетсяПодрядчиком.SaveInDatabase = true;
	ЯвляетсяПодрядчиком.InformMetaDataOnValueChanged = false;
	ЯвляетсяПодрядчиком.Visible = true;
	ЯвляетсяПодрядчиком.Name = "ЯвляетсяПодрядчиком";
	ЯвляетсяПодрядчиком.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПодрядчиком.Description = "Является подрядчиком";
	ЯвляетсяПодрядчиком.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяПодрядчиком.GroupName = "";
	ЯвляетсяПодрядчиком.Guid = NsgService.StringToGuid("ba73a8ae-3430-420d-96e0-28beb8286e9d");
	
				if (!ObjectList.Contains("ЯвляетсяПодрядчиком"))
                    ObjectList.Add(ЯвляетсяПодрядчиком);
			}
			#endregion //создание System.Boolean ЯвляетсяПодрядчиком
			
			#region создание System.Boolean ЯвляетсяЗаказчиком
			{  
                NsgDataBoolean ЯвляетсяЗаказчиком = null;
				if (ObjectList.Contains("ЯвляетсяЗаказчиком"))
                    ЯвляетсяЗаказчиком = ObjectList["ЯвляетсяЗаказчиком"] as NsgDataBoolean;
                else
                    ЯвляетсяЗаказчиком = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяЗаказчиком.IsLoadedFromDll = true;
	ЯвляетсяЗаказчиком.DefaultValue = false;
	ЯвляетсяЗаказчиком.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяЗаказчиком.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяЗаказчиком.StringFormat = "";
	ЯвляетсяЗаказчиком.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяЗаказчиком.IncludeInPredefined = false;
	ЯвляетсяЗаказчиком.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяЗаказчиком.Required = false;
	ЯвляетсяЗаказчиком.EmptyValue = "";
	ЯвляетсяЗаказчиком.NullAllow = false;
	ЯвляетсяЗаказчиком.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяЗаказчиком.FieldName = "JAvljaetsjaZakazc";
	ЯвляетсяЗаказчиком.SaveInDatabase = true;
	ЯвляетсяЗаказчиком.InformMetaDataOnValueChanged = false;
	ЯвляетсяЗаказчиком.Visible = true;
	ЯвляетсяЗаказчиком.Name = "ЯвляетсяЗаказчиком";
	ЯвляетсяЗаказчиком.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяЗаказчиком.Description = "Является заказчиком";
	ЯвляетсяЗаказчиком.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяЗаказчиком.GroupName = "";
	ЯвляетсяЗаказчиком.Guid = NsgService.StringToGuid("0c596bc2-e1af-4dd7-908b-cb1ed03cf68f");
	
				if (!ObjectList.Contains("ЯвляетсяЗаказчиком"))
                    ObjectList.Add(ЯвляетсяЗаказчиком);
			}
			#endregion //создание System.Boolean ЯвляетсяЗаказчиком
			
			#region создание System.Boolean ЯвляетсяПоставщикомТоплива
			{  
                NsgDataBoolean ЯвляетсяПоставщикомТоплива = null;
				if (ObjectList.Contains("ЯвляетсяПоставщикомТоплива"))
                    ЯвляетсяПоставщикомТоплива = ObjectList["ЯвляетсяПоставщикомТоплива"] as NsgDataBoolean;
                else
                    ЯвляетсяПоставщикомТоплива = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяПоставщикомТоплива.IsLoadedFromDll = true;
	ЯвляетсяПоставщикомТоплива.DefaultValue = false;
	ЯвляетсяПоставщикомТоплива.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомТоплива.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомТоплива.StringFormat = "";
	ЯвляетсяПоставщикомТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяПоставщикомТоплива.IncludeInPredefined = false;
	ЯвляетсяПоставщикомТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяПоставщикомТоплива.Required = false;
	ЯвляетсяПоставщикомТоплива.EmptyValue = "";
	ЯвляетсяПоставщикомТоплива.NullAllow = false;
	ЯвляетсяПоставщикомТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяПоставщикомТоплива.FieldName = "JAvljaetsjaPostav";
	ЯвляетсяПоставщикомТоплива.SaveInDatabase = true;
	ЯвляетсяПоставщикомТоплива.InformMetaDataOnValueChanged = false;
	ЯвляетсяПоставщикомТоплива.Visible = true;
	ЯвляетсяПоставщикомТоплива.Name = "ЯвляетсяПоставщикомТоплива";
	ЯвляетсяПоставщикомТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомТоплива.Description = "Является поставщиком топлива";
	ЯвляетсяПоставщикомТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяПоставщикомТоплива.GroupName = "";
	ЯвляетсяПоставщикомТоплива.Guid = NsgService.StringToGuid("3ea5387e-4719-47af-81e7-e64a739c3cb2");
	
				if (!ObjectList.Contains("ЯвляетсяПоставщикомТоплива"))
                    ObjectList.Add(ЯвляетсяПоставщикомТоплива);
			}
			#endregion //создание System.Boolean ЯвляетсяПоставщикомТоплива
			
			#region создание TechControl.Метаданные.Мониторинг.КонтрагентыФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.КонтрагентыФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("ad83e70e-4193-432f-9869-a3e5d022a197");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.КонтрагентыФормаЭлемента ФормаЭлемента
			
			#region создание System.String ИНН
			{  
                NsgDataString ИНН = null;
				if (ObjectList.Contains("ИНН"))
                    ИНН = ObjectList["ИНН"] as NsgDataString;
                else
                    ИНН = new NsgDataString();
	//NsgDataString
	ИНН.IsLoadedFromDll = true;
	ИНН.Length = 14;
	ИНН.StringFormat = "";
	ИНН.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ИНН.IncludeInPredefined = false;
	ИНН.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИНН.Required = false;
	ИНН.EmptyValue = "";
	ИНН.NullAllow = false;
	ИНН.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИНН.FieldName = "INN";
	ИНН.SaveInDatabase = true;
	ИНН.InformMetaDataOnValueChanged = false;
	ИНН.Visible = true;
	ИНН.Name = "ИНН";
	ИНН.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИНН.Description = "ИНН";
	ИНН.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИНН.GroupName = "";
	ИНН.Guid = NsgService.StringToGuid("cc846536-d76b-4535-9abd-57a34339654e");
	
				if (!ObjectList.Contains("ИНН"))
                    ObjectList.Add(ИНН);
			}
			#endregion //создание System.String ИНН
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("3351e5ab-27ba-4679-b460-4918e59bfe98");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.Boolean ЯвляетсяПоставщикомСпецодежды
			{  
                NsgDataBoolean ЯвляетсяПоставщикомСпецодежды = null;
				if (ObjectList.Contains("ЯвляетсяПоставщикомСпецодежды"))
                    ЯвляетсяПоставщикомСпецодежды = ObjectList["ЯвляетсяПоставщикомСпецодежды"] as NsgDataBoolean;
                else
                    ЯвляетсяПоставщикомСпецодежды = new NsgDataBoolean();
	//NsgDataBoolean
	ЯвляетсяПоставщикомСпецодежды.IsLoadedFromDll = true;
	ЯвляетсяПоставщикомСпецодежды.DefaultValue = false;
	ЯвляетсяПоставщикомСпецодежды.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомСпецодежды.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомСпецодежды.StringFormat = "";
	ЯвляетсяПоставщикомСпецодежды.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЯвляетсяПоставщикомСпецодежды.IncludeInPredefined = false;
	ЯвляетсяПоставщикомСпецодежды.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЯвляетсяПоставщикомСпецодежды.Required = false;
	ЯвляетсяПоставщикомСпецодежды.EmptyValue = "";
	ЯвляетсяПоставщикомСпецодежды.NullAllow = false;
	ЯвляетсяПоставщикомСпецодежды.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЯвляетсяПоставщикомСпецодежды.FieldName = "JAvljaetsjaPostav1";
	ЯвляетсяПоставщикомСпецодежды.SaveInDatabase = true;
	ЯвляетсяПоставщикомСпецодежды.InformMetaDataOnValueChanged = false;
	ЯвляетсяПоставщикомСпецодежды.Visible = true;
	ЯвляетсяПоставщикомСпецодежды.Name = "ЯвляетсяПоставщикомСпецодежды";
	ЯвляетсяПоставщикомСпецодежды.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЯвляетсяПоставщикомСпецодежды.Description = "Является поставщиком спецодежды";
	ЯвляетсяПоставщикомСпецодежды.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЯвляетсяПоставщикомСпецодежды.GroupName = "";
	ЯвляетсяПоставщикомСпецодежды.Guid = NsgService.StringToGuid("b7a6ec92-a843-444e-a0c3-2069885a150d");
	
				if (!ObjectList.Contains("ЯвляетсяПоставщикомСпецодежды"))
                    ObjectList.Add(ЯвляетсяПоставщикомСпецодежды);
			}
			#endregion //создание System.Boolean ЯвляетсяПоставщикомСпецодежды
			
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
	ЗагрузочныйИдентификатор.Guid = NsgService.StringToGuid("8adade55-23f0-41d3-951e-3bc9d57cc93b");
	
				if (!ObjectList.Contains("ЗагрузочныйИдентификатор"))
                    ObjectList.Add(ЗагрузочныйИдентификатор);
			}
			#endregion //создание System.String ЗагрузочныйИдентификатор
			
			#region создание Мониторинг.ФизЛица СотрудникПодписант
			{  
                NsgDataTypedReference СотрудникПодписант = null;
				if (ObjectList.Contains("СотрудникПодписант"))
                    СотрудникПодписант = ObjectList["СотрудникПодписант"] as NsgDataTypedReference;
                else
                    СотрудникПодписант = new NsgDataTypedReference();
	//NsgDataTypedReference
	СотрудникПодписант.IsLoadedFromDll = true;
	СотрудникПодписант.ReferentGroup = "Мониторинг";
	СотрудникПодписант.ReferentName = "ФизЛица";
	СотрудникПодписант.SaveInDatabase = true;
	СотрудникПодписант.OwnerName = "";
	СотрудникПодписант.AllowEmptyOwner = false;
	СотрудникПодписант.StringFormat = "";
	СотрудникПодписант.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СотрудникПодписант.IncludeInPredefined = false;
	СотрудникПодписант.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СотрудникПодписант.Required = false;
	СотрудникПодписант.EmptyValue = "";
	СотрудникПодписант.NullAllow = false;
	СотрудникПодписант.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СотрудникПодписант.FieldName = "SotrudnikPodpisant";
	СотрудникПодписант.InformMetaDataOnValueChanged = false;
	СотрудникПодписант.Visible = true;
	СотрудникПодписант.Name = "СотрудникПодписант";
	СотрудникПодписант.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СотрудникПодписант.Description = "Сотрудник подписант";
	СотрудникПодписант.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СотрудникПодписант.GroupName = "";
	СотрудникПодписант.Guid = NsgService.StringToGuid("fbcb81ae-e2b2-4bfb-9d99-8ad1aded32dd");
	
				if (!ObjectList.Contains("СотрудникПодписант"))
                    ObjectList.Add(СотрудникПодписант);
			}
			#endregion //создание Мониторинг.ФизЛица СотрудникПодписант
			
			#region создание Мониторинг.Должности ДолжностьПодписанта
			{  
                NsgDataTypedReference ДолжностьПодписанта = null;
				if (ObjectList.Contains("ДолжностьПодписанта"))
                    ДолжностьПодписанта = ObjectList["ДолжностьПодписанта"] as NsgDataTypedReference;
                else
                    ДолжностьПодписанта = new NsgDataTypedReference();
	//NsgDataTypedReference
	ДолжностьПодписанта.IsLoadedFromDll = true;
	ДолжностьПодписанта.ReferentGroup = "Мониторинг";
	ДолжностьПодписанта.ReferentName = "Должности";
	ДолжностьПодписанта.SaveInDatabase = true;
	ДолжностьПодписанта.OwnerName = "";
	ДолжностьПодписанта.AllowEmptyOwner = false;
	ДолжностьПодписанта.StringFormat = "";
	ДолжностьПодписанта.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДолжностьПодписанта.IncludeInPredefined = false;
	ДолжностьПодписанта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДолжностьПодписанта.Required = false;
	ДолжностьПодписанта.EmptyValue = "";
	ДолжностьПодписанта.NullAllow = false;
	ДолжностьПодписанта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДолжностьПодписанта.FieldName = "DolzhnostPodpisanta";
	ДолжностьПодписанта.InformMetaDataOnValueChanged = false;
	ДолжностьПодписанта.Visible = true;
	ДолжностьПодписанта.Name = "ДолжностьПодписанта";
	ДолжностьПодписанта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДолжностьПодписанта.Description = "Должность подписанта";
	ДолжностьПодписанта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДолжностьПодписанта.GroupName = "";
	ДолжностьПодписанта.Guid = NsgService.StringToGuid("735a7524-1eed-4f6f-8adc-fcc928716e4b");
	
				if (!ObjectList.Contains("ДолжностьПодписанта"))
                    ObjectList.Add(ДолжностьПодписанта);
			}
			#endregion //создание Мониторинг.Должности ДолжностьПодписанта
			
			#region создание Мониторинг.Картинки КартинкаПечать
			{  
                NsgDataTypedReference КартинкаПечать = null;
				if (ObjectList.Contains("КартинкаПечать"))
                    КартинкаПечать = ObjectList["КартинкаПечать"] as NsgDataTypedReference;
                else
                    КартинкаПечать = new NsgDataTypedReference();
	//NsgDataTypedReference
	КартинкаПечать.IsLoadedFromDll = true;
	КартинкаПечать.ReferentGroup = "Мониторинг";
	КартинкаПечать.ReferentName = "Картинки";
	КартинкаПечать.SaveInDatabase = true;
	КартинкаПечать.OwnerName = "";
	КартинкаПечать.AllowEmptyOwner = false;
	КартинкаПечать.StringFormat = "";
	КартинкаПечать.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КартинкаПечать.IncludeInPredefined = false;
	КартинкаПечать.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КартинкаПечать.Required = false;
	КартинкаПечать.EmptyValue = "";
	КартинкаПечать.NullAllow = false;
	КартинкаПечать.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КартинкаПечать.FieldName = "KartinkaPechat";
	КартинкаПечать.InformMetaDataOnValueChanged = false;
	КартинкаПечать.Visible = true;
	КартинкаПечать.Name = "КартинкаПечать";
	КартинкаПечать.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КартинкаПечать.Description = "Картинка печать";
	КартинкаПечать.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КартинкаПечать.GroupName = "";
	КартинкаПечать.Guid = NsgService.StringToGuid("32ca76af-a9c4-45e9-8ade-a0d1b440e52f");
	
				if (!ObjectList.Contains("КартинкаПечать"))
                    ObjectList.Add(КартинкаПечать);
			}
			#endregion //создание Мониторинг.Картинки КартинкаПечать
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Контрагенты";
	Visible = true;
	Guid = NsgService.StringToGuid("db34431e-a7fe-44ea-9092-d1d01193ec1f");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Kontragent";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Контрагенты";
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
            /// Является нашей фирмой
            /// </summary>
            public static String ЯвляетсяНашейФирмой
            {
                get
                {
                    return "ЯвляетсяНашейФирмой";
                }
            }
            
            /// <summary>
            /// Является подрядчиком
            /// </summary>
            public static String ЯвляетсяПодрядчиком
            {
                get
                {
                    return "ЯвляетсяПодрядчиком";
                }
            }
            
            /// <summary>
            /// Является заказчиком
            /// </summary>
            public static String ЯвляетсяЗаказчиком
            {
                get
                {
                    return "ЯвляетсяЗаказчиком";
                }
            }
            
            /// <summary>
            /// Является поставщиком топлива
            /// </summary>
            public static String ЯвляетсяПоставщикомТоплива
            {
                get
                {
                    return "ЯвляетсяПоставщикомТоплива";
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
            /// ИНН
            /// </summary>
            public static String ИНН
            {
                get
                {
                    return "ИНН";
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
            /// Является поставщиком спецодежды
            /// </summary>
            public static String ЯвляетсяПоставщикомСпецодежды
            {
                get
                {
                    return "ЯвляетсяПоставщикомСпецодежды";
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
            /// Сотрудник подписант
            /// </summary>
            public static String СотрудникПодписант
            {
                get
                {
                    return "СотрудникПодписант";
                }
            }
            
            /// <summary>
            /// Должность подписанта
            /// </summary>
            public static String ДолжностьПодписанта
            {
                get
                {
                    return "ДолжностьПодписанта";
                }
            }
            
            /// <summary>
            /// Картинка печать
            /// </summary>
            public static String КартинкаПечать
            {
                get
                {
                    return "КартинкаПечать";
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
                    descriptor.Name = "Контрагенты";
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
            return "Мониторинг.Контрагенты";
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
        /// Является нашей фирмой
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяНашейФирмой
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяНашейФирмой = ObjectList["ЯвляетсяНашейФирмой"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяНашейФирмой.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяНашейФирмой = ObjectList["ЯвляетсяНашейФирмой"] as NsgDataBoolean;
                __ЯвляетсяНашейФирмой.Value = value;
            }
        }
        
        /// <summary>
        /// Является подрядчиком
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяПодрядчиком
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяПодрядчиком = ObjectList["ЯвляетсяПодрядчиком"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяПодрядчиком.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяПодрядчиком = ObjectList["ЯвляетсяПодрядчиком"] as NsgDataBoolean;
                __ЯвляетсяПодрядчиком.Value = value;
            }
        }
        
        /// <summary>
        /// Является заказчиком
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяЗаказчиком
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяЗаказчиком = ObjectList["ЯвляетсяЗаказчиком"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяЗаказчиком.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяЗаказчиком = ObjectList["ЯвляетсяЗаказчиком"] as NsgDataBoolean;
                __ЯвляетсяЗаказчиком.Value = value;
            }
        }
        
        /// <summary>
        /// Является поставщиком топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяПоставщикомТоплива
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяПоставщикомТоплива = ObjectList["ЯвляетсяПоставщикомТоплива"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяПоставщикомТоплива.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяПоставщикомТоплива = ObjectList["ЯвляетсяПоставщикомТоплива"] as NsgDataBoolean;
                __ЯвляетсяПоставщикомТоплива.Value = value;
            }
        }
        
        /// <summary>
        /// ИНН
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ИНН
        {
            get
            {
				 NsgDataString __ИНН = ObjectList["ИНН"] as NsgDataString;
                 return (System.String)__ИНН.Value;
            }
            set
            {
                NsgDataString __ИНН = ObjectList["ИНН"] as NsgDataString;
                __ИНН.Value = value;
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
        /// Является поставщиком спецодежды
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЯвляетсяПоставщикомСпецодежды
        {
            get
            {
				 NsgDataBoolean __ЯвляетсяПоставщикомСпецодежды = ObjectList["ЯвляетсяПоставщикомСпецодежды"] as NsgDataBoolean;
                 return (System.Boolean)__ЯвляетсяПоставщикомСпецодежды.Value;
            }
            set
            {
                NsgDataBoolean __ЯвляетсяПоставщикомСпецодежды = ObjectList["ЯвляетсяПоставщикомСпецодежды"] as NsgDataBoolean;
                __ЯвляетсяПоставщикомСпецодежды.Value = value;
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
        /// Сотрудник подписант
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица СотрудникПодписант
        {
            get
            {
				 NsgDataTypedReference __СотрудникПодписант = ObjectList["СотрудникПодписант"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__СотрудникПодписант.Referent;
            }
            set
            {
                NsgDataTypedReference __СотрудникПодписант = ObjectList["СотрудникПодписант"] as NsgDataTypedReference;
                __СотрудникПодписант.Referent = value;
            }
        }
        
        /// <summary>
        /// Должность подписанта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Должности ДолжностьПодписанта
        {
            get
            {
				 NsgDataTypedReference __ДолжностьПодписанта = ObjectList["ДолжностьПодписанта"] as NsgDataTypedReference;
                 return (Мониторинг.Должности)__ДолжностьПодписанта.Referent;
            }
            set
            {
                NsgDataTypedReference __ДолжностьПодписанта = ObjectList["ДолжностьПодписанта"] as NsgDataTypedReference;
                __ДолжностьПодписанта.Referent = value;
            }
        }
        
        /// <summary>
        /// Картинка печать
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Картинки КартинкаПечать
        {
            get
            {
				 NsgDataTypedReference __КартинкаПечать = ObjectList["КартинкаПечать"] as NsgDataTypedReference;
                 return (Мониторинг.Картинки)__КартинкаПечать.Referent;
            }
            set
            {
                NsgDataTypedReference __КартинкаПечать = ObjectList["КартинкаПечать"] as NsgDataTypedReference;
                __КартинкаПечать.Referent = value;
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
        public Контрагенты Родитель
        {
            get
            {
                return base.Parent as Контрагенты;
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
        private Контрагенты[] convertArray(NsgMultipleObject[] array)
        {
            Контрагенты[] res = new Контрагенты[array.Length];
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
        public new virtual Контрагенты[] FindAll(NsgCompare compare)
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
        public new virtual Контрагенты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Контрагенты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Контрагенты[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Контрагенты(this as NsgObject);
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
                base.NSGType = typeof(Контрагенты);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Контрагенты Value
            {
                get
                {
                    return (Контрагенты)base.Value;
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
