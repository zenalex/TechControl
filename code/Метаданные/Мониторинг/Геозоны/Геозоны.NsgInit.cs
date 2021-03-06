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
    
    [NsgTypeName("NsgDataDictionary", Guid = "91038ae1-8740-4f05-b39e-984e0cb4403d")]
    public partial class Геозоны : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Геозоны()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Геозоны(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Геозоны Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("91038ae1-8740-4f05-b39e-984e0cb4403d"));
            if (obj == null)
                obj = new Геозоны();
            return obj as Геозоны;
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
	Идентификатор.Guid = NsgService.StringToGuid("24974491-64bb-484a-a8a2-401ec4c19a61");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("9e9612bd-3360-4ab8-998c-51bc38c266c1");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("6a7e5f34-2083-4884-8b65-024f016a2c91");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("2de5a9fc-097f-44fe-be91-ca7436517c18");
	
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
	Уровень.Guid = NsgService.StringToGuid("05731500-f870-4d63-92a9-fd391b0ef442");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("ffb8541d-b598-4ab1-b6fb-dbaf88f98d6f");
	
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
	НомерКода.Guid = NsgService.StringToGuid("79eda6db-6192-4e19-9dee-ac654ab54c67");
	
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
	Код.Guid = NsgService.StringToGuid("35a3bdc8-9ffc-4d4c-a0aa-22bc5d356561");
	
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
	Наименование.Guid = NsgService.StringToGuid("b75dfed5-e514-4d99-8b74-15830400649e");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("e1620e8c-2bb4-431b-896f-3d9d1817617c");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание TechControl.Метаданные.Мониторинг.ГеозоныФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ГеозоныФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("b63dd05e-49fe-4499-bc20-090e3cca7fc2");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ГеозоныФормаЭлемента ФормаЭлемента
			
			#region создание System.Decimal Широта
			{  
                NsgDataFloat Широта = null;
				if (ObjectList.Contains("Широта"))
                    Широта = ObjectList["Широта"] as NsgDataFloat;
                else
                    Широта = new NsgDataFloat();
	//NsgDataFloat
	Широта.IsLoadedFromDll = true;
	Широта.Precision = 6;
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
	Широта.Guid = NsgService.StringToGuid("e9eda0ee-e40d-40ff-a4eb-ae838ed91a62");
	
				if (!ObjectList.Contains("Широта"))
                    ObjectList.Add(Широта);
			}
			#endregion //создание System.Decimal Широта
			
			#region создание System.Decimal Долгота
			{  
                NsgDataFloat Долгота = null;
				if (ObjectList.Contains("Долгота"))
                    Долгота = ObjectList["Долгота"] as NsgDataFloat;
                else
                    Долгота = new NsgDataFloat();
	//NsgDataFloat
	Долгота.IsLoadedFromDll = true;
	Долгота.Precision = 6;
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
	Долгота.Guid = NsgService.StringToGuid("93aa2f87-c237-4bb8-8b30-f3dc64acf9a4");
	
				if (!ObjectList.Contains("Долгота"))
                    ObjectList.Add(Долгота);
			}
			#endregion //создание System.Decimal Долгота
			
			#region создание System.Decimal РадиусГеозоны
			{  
                NsgDataFloat РадиусГеозоны = null;
				if (ObjectList.Contains("РадиусГеозоны"))
                    РадиусГеозоны = ObjectList["РадиусГеозоны"] as NsgDataFloat;
                else
                    РадиусГеозоны = new NsgDataFloat();
	//NsgDataFloat
	РадиусГеозоны.IsLoadedFromDll = true;
	РадиусГеозоны.Precision = 6;
	РадиусГеозоны.HideZero = true;
	РадиусГеозоны.DefaultValue = 0M;
	РадиусГеозоны.MinValue = -100000000000000000M;
	РадиусГеозоны.MaxValue = 100000000000000000M;
	РадиусГеозоны.UseCalculator = true;
	РадиусГеозоны.StringFormat = "";
	РадиусГеозоны.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РадиусГеозоны.IncludeInPredefined = false;
	РадиусГеозоны.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РадиусГеозоны.Required = false;
	РадиусГеозоны.EmptyValue = "";
	РадиусГеозоны.NullAllow = false;
	РадиусГеозоны.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РадиусГеозоны.FieldName = "RadiusGeozony";
	РадиусГеозоны.SaveInDatabase = true;
	РадиусГеозоны.InformMetaDataOnValueChanged = false;
	РадиусГеозоны.Visible = true;
	РадиусГеозоны.Name = "РадиусГеозоны";
	РадиусГеозоны.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РадиусГеозоны.Description = "Радиус геозоны";
	РадиусГеозоны.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РадиусГеозоны.GroupName = "";
	РадиусГеозоны.Guid = NsgService.StringToGuid("3c948461-b49c-464d-80c5-3b67a1a6f401");
	
				if (!ObjectList.Contains("РадиусГеозоны"))
                    ObjectList.Add(РадиусГеозоны);
			}
			#endregion //создание System.Decimal РадиусГеозоны
			
			#region создание System.Decimal ЛевыйНижнийУголШирота
			{  
                NsgDataFloat ЛевыйНижнийУголШирота = null;
				if (ObjectList.Contains("ЛевыйНижнийУголШирота"))
                    ЛевыйНижнийУголШирота = ObjectList["ЛевыйНижнийУголШирота"] as NsgDataFloat;
                else
                    ЛевыйНижнийУголШирота = new NsgDataFloat();
	//NsgDataFloat
	ЛевыйНижнийУголШирота.IsLoadedFromDll = true;
	ЛевыйНижнийУголШирота.Precision = 6;
	ЛевыйНижнийУголШирота.HideZero = true;
	ЛевыйНижнийУголШирота.DefaultValue = 0M;
	ЛевыйНижнийУголШирота.MinValue = -100000000000000000M;
	ЛевыйНижнийУголШирота.MaxValue = 100000000000000000M;
	ЛевыйНижнийУголШирота.UseCalculator = true;
	ЛевыйНижнийУголШирота.StringFormat = "";
	ЛевыйНижнийУголШирота.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЛевыйНижнийУголШирота.IncludeInPredefined = false;
	ЛевыйНижнийУголШирота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЛевыйНижнийУголШирота.Required = false;
	ЛевыйНижнийУголШирота.EmptyValue = "";
	ЛевыйНижнийУголШирота.NullAllow = false;
	ЛевыйНижнийУголШирота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЛевыйНижнийУголШирота.FieldName = "LevyijNizhniijUgo";
	ЛевыйНижнийУголШирота.SaveInDatabase = true;
	ЛевыйНижнийУголШирота.InformMetaDataOnValueChanged = false;
	ЛевыйНижнийУголШирота.Visible = true;
	ЛевыйНижнийУголШирота.Name = "ЛевыйНижнийУголШирота";
	ЛевыйНижнийУголШирота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЛевыйНижнийУголШирота.Description = "Левый нижний угол широта";
	ЛевыйНижнийУголШирота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЛевыйНижнийУголШирота.GroupName = "";
	ЛевыйНижнийУголШирота.Guid = NsgService.StringToGuid("2fa4c552-6980-4f6b-bb3c-e6bdbf5ff672");
	
				if (!ObjectList.Contains("ЛевыйНижнийУголШирота"))
                    ObjectList.Add(ЛевыйНижнийУголШирота);
			}
			#endregion //создание System.Decimal ЛевыйНижнийУголШирота
			
			#region создание System.Decimal ЛевыйНижнийУголДолгота
			{  
                NsgDataFloat ЛевыйНижнийУголДолгота = null;
				if (ObjectList.Contains("ЛевыйНижнийУголДолгота"))
                    ЛевыйНижнийУголДолгота = ObjectList["ЛевыйНижнийУголДолгота"] as NsgDataFloat;
                else
                    ЛевыйНижнийУголДолгота = new NsgDataFloat();
	//NsgDataFloat
	ЛевыйНижнийУголДолгота.IsLoadedFromDll = true;
	ЛевыйНижнийУголДолгота.Precision = 6;
	ЛевыйНижнийУголДолгота.HideZero = true;
	ЛевыйНижнийУголДолгота.DefaultValue = 0M;
	ЛевыйНижнийУголДолгота.MinValue = -100000000000000000M;
	ЛевыйНижнийУголДолгота.MaxValue = 100000000000000000M;
	ЛевыйНижнийУголДолгота.UseCalculator = true;
	ЛевыйНижнийУголДолгота.StringFormat = "";
	ЛевыйНижнийУголДолгота.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ЛевыйНижнийУголДолгота.IncludeInPredefined = false;
	ЛевыйНижнийУголДолгота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЛевыйНижнийУголДолгота.Required = false;
	ЛевыйНижнийУголДолгота.EmptyValue = "";
	ЛевыйНижнийУголДолгота.NullAllow = false;
	ЛевыйНижнийУголДолгота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЛевыйНижнийУголДолгота.FieldName = "LevyijNizhniijUgo1";
	ЛевыйНижнийУголДолгота.SaveInDatabase = true;
	ЛевыйНижнийУголДолгота.InformMetaDataOnValueChanged = false;
	ЛевыйНижнийУголДолгота.Visible = true;
	ЛевыйНижнийУголДолгота.Name = "ЛевыйНижнийУголДолгота";
	ЛевыйНижнийУголДолгота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЛевыйНижнийУголДолгота.Description = "Левый нижний угол долгота";
	ЛевыйНижнийУголДолгота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЛевыйНижнийУголДолгота.GroupName = "";
	ЛевыйНижнийУголДолгота.Guid = NsgService.StringToGuid("4d9436ca-8388-449f-a58e-0af3dd4be901");
	
				if (!ObjectList.Contains("ЛевыйНижнийУголДолгота"))
                    ObjectList.Add(ЛевыйНижнийУголДолгота);
			}
			#endregion //создание System.Decimal ЛевыйНижнийУголДолгота
			
			#region создание System.Decimal ПравыйВерхнийУголШирота
			{  
                NsgDataFloat ПравыйВерхнийУголШирота = null;
				if (ObjectList.Contains("ПравыйВерхнийУголШирота"))
                    ПравыйВерхнийУголШирота = ObjectList["ПравыйВерхнийУголШирота"] as NsgDataFloat;
                else
                    ПравыйВерхнийУголШирота = new NsgDataFloat();
	//NsgDataFloat
	ПравыйВерхнийУголШирота.IsLoadedFromDll = true;
	ПравыйВерхнийУголШирота.Precision = 6;
	ПравыйВерхнийУголШирота.HideZero = true;
	ПравыйВерхнийУголШирота.DefaultValue = 0M;
	ПравыйВерхнийУголШирота.MinValue = -100000000000000000M;
	ПравыйВерхнийУголШирота.MaxValue = 100000000000000000M;
	ПравыйВерхнийУголШирота.UseCalculator = true;
	ПравыйВерхнийУголШирота.StringFormat = "";
	ПравыйВерхнийУголШирота.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПравыйВерхнийУголШирота.IncludeInPredefined = false;
	ПравыйВерхнийУголШирота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПравыйВерхнийУголШирота.Required = false;
	ПравыйВерхнийУголШирота.EmptyValue = "";
	ПравыйВерхнийУголШирота.NullAllow = false;
	ПравыйВерхнийУголШирота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПравыйВерхнийУголШирота.FieldName = "PravyijVerkhniijU";
	ПравыйВерхнийУголШирота.SaveInDatabase = true;
	ПравыйВерхнийУголШирота.InformMetaDataOnValueChanged = false;
	ПравыйВерхнийУголШирота.Visible = true;
	ПравыйВерхнийУголШирота.Name = "ПравыйВерхнийУголШирота";
	ПравыйВерхнийУголШирота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПравыйВерхнийУголШирота.Description = "Правый верхний угол широта";
	ПравыйВерхнийУголШирота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПравыйВерхнийУголШирота.GroupName = "";
	ПравыйВерхнийУголШирота.Guid = NsgService.StringToGuid("91d78b77-900f-4021-ad64-64d6e18418c8");
	
				if (!ObjectList.Contains("ПравыйВерхнийУголШирота"))
                    ObjectList.Add(ПравыйВерхнийУголШирота);
			}
			#endregion //создание System.Decimal ПравыйВерхнийУголШирота
			
			#region создание System.Decimal ПравыйВерхнийУголДолгота
			{  
                NsgDataFloat ПравыйВерхнийУголДолгота = null;
				if (ObjectList.Contains("ПравыйВерхнийУголДолгота"))
                    ПравыйВерхнийУголДолгота = ObjectList["ПравыйВерхнийУголДолгота"] as NsgDataFloat;
                else
                    ПравыйВерхнийУголДолгота = new NsgDataFloat();
	//NsgDataFloat
	ПравыйВерхнийУголДолгота.IsLoadedFromDll = true;
	ПравыйВерхнийУголДолгота.Precision = 6;
	ПравыйВерхнийУголДолгота.HideZero = true;
	ПравыйВерхнийУголДолгота.DefaultValue = 0M;
	ПравыйВерхнийУголДолгота.MinValue = -100000000000000000M;
	ПравыйВерхнийУголДолгота.MaxValue = 100000000000000000M;
	ПравыйВерхнийУголДолгота.UseCalculator = true;
	ПравыйВерхнийУголДолгота.StringFormat = "";
	ПравыйВерхнийУголДолгота.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПравыйВерхнийУголДолгота.IncludeInPredefined = false;
	ПравыйВерхнийУголДолгота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПравыйВерхнийУголДолгота.Required = false;
	ПравыйВерхнийУголДолгота.EmptyValue = "";
	ПравыйВерхнийУголДолгота.NullAllow = false;
	ПравыйВерхнийУголДолгота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПравыйВерхнийУголДолгота.FieldName = "PravyijVerkhniijU1";
	ПравыйВерхнийУголДолгота.SaveInDatabase = true;
	ПравыйВерхнийУголДолгота.InformMetaDataOnValueChanged = false;
	ПравыйВерхнийУголДолгота.Visible = true;
	ПравыйВерхнийУголДолгота.Name = "ПравыйВерхнийУголДолгота";
	ПравыйВерхнийУголДолгота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПравыйВерхнийУголДолгота.Description = "Правый верхний угол долгота";
	ПравыйВерхнийУголДолгота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПравыйВерхнийУголДолгота.GroupName = "";
	ПравыйВерхнийУголДолгота.Guid = NsgService.StringToGuid("739c5dc5-666b-453f-93d9-a5efa74c6228");
	
				if (!ObjectList.Contains("ПравыйВерхнийУголДолгота"))
                    ObjectList.Add(ПравыйВерхнийУголДолгота);
			}
			#endregion //создание System.Decimal ПравыйВерхнийУголДолгота
			
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
	Объект.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
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
	Объект.Guid = NsgService.StringToGuid("dc826764-a612-42ff-8e60-d1c4075fc602");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Геозоны";
	Visible = true;
	Guid = NsgService.StringToGuid("91038ae1-8740-4f05-b39e-984e0cb4403d");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Geozony";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Геозоны";
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
            /// Радиус геозоны
            /// </summary>
            public static String РадиусГеозоны
            {
                get
                {
                    return "РадиусГеозоны";
                }
            }
            
            /// <summary>
            /// Левый нижний угол широта
            /// </summary>
            public static String ЛевыйНижнийУголШирота
            {
                get
                {
                    return "ЛевыйНижнийУголШирота";
                }
            }
            
            /// <summary>
            /// Левый нижний угол долгота
            /// </summary>
            public static String ЛевыйНижнийУголДолгота
            {
                get
                {
                    return "ЛевыйНижнийУголДолгота";
                }
            }
            
            /// <summary>
            /// Правый верхний угол широта
            /// </summary>
            public static String ПравыйВерхнийУголШирота
            {
                get
                {
                    return "ПравыйВерхнийУголШирота";
                }
            }
            
            /// <summary>
            /// Правый верхний угол долгота
            /// </summary>
            public static String ПравыйВерхнийУголДолгота
            {
                get
                {
                    return "ПравыйВерхнийУголДолгота";
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
                    descriptor.Name = "Геозоны";
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
            return "Мониторинг.Геозоны";
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
        /// Радиус геозоны
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal РадиусГеозоны
        {
            get
            {
				 NsgDataFloat __РадиусГеозоны = ObjectList["РадиусГеозоны"] as NsgDataFloat;
                 return (System.Decimal)__РадиусГеозоны.Value;
            }
            set
            {
                NsgDataFloat __РадиусГеозоны = ObjectList["РадиусГеозоны"] as NsgDataFloat;
                __РадиусГеозоны.Value = value;
            }
        }
        
        /// <summary>
        /// Левый нижний угол широта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ЛевыйНижнийУголШирота
        {
            get
            {
				 NsgDataFloat __ЛевыйНижнийУголШирота = ObjectList["ЛевыйНижнийУголШирота"] as NsgDataFloat;
                 return (System.Decimal)__ЛевыйНижнийУголШирота.Value;
            }
            set
            {
                NsgDataFloat __ЛевыйНижнийУголШирота = ObjectList["ЛевыйНижнийУголШирота"] as NsgDataFloat;
                __ЛевыйНижнийУголШирота.Value = value;
            }
        }
        
        /// <summary>
        /// Левый нижний угол долгота
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ЛевыйНижнийУголДолгота
        {
            get
            {
				 NsgDataFloat __ЛевыйНижнийУголДолгота = ObjectList["ЛевыйНижнийУголДолгота"] as NsgDataFloat;
                 return (System.Decimal)__ЛевыйНижнийУголДолгота.Value;
            }
            set
            {
                NsgDataFloat __ЛевыйНижнийУголДолгота = ObjectList["ЛевыйНижнийУголДолгота"] as NsgDataFloat;
                __ЛевыйНижнийУголДолгота.Value = value;
            }
        }
        
        /// <summary>
        /// Правый верхний угол широта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ПравыйВерхнийУголШирота
        {
            get
            {
				 NsgDataFloat __ПравыйВерхнийУголШирота = ObjectList["ПравыйВерхнийУголШирота"] as NsgDataFloat;
                 return (System.Decimal)__ПравыйВерхнийУголШирота.Value;
            }
            set
            {
                NsgDataFloat __ПравыйВерхнийУголШирота = ObjectList["ПравыйВерхнийУголШирота"] as NsgDataFloat;
                __ПравыйВерхнийУголШирота.Value = value;
            }
        }
        
        /// <summary>
        /// Правый верхний угол долгота
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ПравыйВерхнийУголДолгота
        {
            get
            {
				 NsgDataFloat __ПравыйВерхнийУголДолгота = ObjectList["ПравыйВерхнийУголДолгота"] as NsgDataFloat;
                 return (System.Decimal)__ПравыйВерхнийУголДолгота.Value;
            }
            set
            {
                NsgDataFloat __ПравыйВерхнийУголДолгота = ObjectList["ПравыйВерхнийУголДолгота"] as NsgDataFloat;
                __ПравыйВерхнийУголДолгота.Value = value;
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
        public Геозоны Родитель
        {
            get
            {
                return base.Parent as Геозоны;
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
        private Геозоны[] convertArray(NsgMultipleObject[] array)
        {
            Геозоны[] res = new Геозоны[array.Length];
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
        public new virtual Геозоны[] FindAll(NsgCompare compare)
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
        public new virtual Геозоны[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Геозоны[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Геозоны[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Геозоны(this as NsgObject);
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
                base.NSGType = typeof(Геозоны);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Геозоны Value
            {
                get
                {
                    return (Геозоны)base.Value;
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
