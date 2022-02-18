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

namespace TechControl.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataDictionary", Guid = "ffe6bf09-fabd-4222-9c49-62163ad6a753")]
    public partial class Пользователи : NsgSoft.DataObjects.NsgDataDictionary
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
        protected Пользователи()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Пользователи(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Пользователи Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("ffe6bf09-fabd-4222-9c49-62163ad6a753"));
            if (obj == null)
                obj = new Пользователи();
            return obj as Пользователи;
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
	Идентификатор.Guid = NsgService.StringToGuid("15d397df-0f98-43a0-adb1-4c9e9389e207");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("d085686c-5ffc-4556-bc14-566dca961e7a");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("1706c61e-8598-4ffe-b53b-2a2933cd0258");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("1e063d96-a44d-448f-a5a4-9e4d76a05d4d");
	
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
	Уровень.Guid = NsgService.StringToGuid("7fcf7728-e9d8-4b99-be3e-b7b28a25c35a");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("d7deefaa-fe9a-477a-8b61-04cb497e266a");
	
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
	НомерКода.Guid = NsgService.StringToGuid("0aebfe04-796a-49b9-a54c-6e77a443ad3c");
	
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
	Код.Guid = NsgService.StringToGuid("9fc87860-9771-4fe9-8cd8-0d06eb3fa8c7");
	
				if (!ObjectList.Contains("Код"))
                    ObjectList.Add(Код);
			}
			#endregion //создание System.String Код
			
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("344274b4-3ad5-4f21-a99a-8a73f140f9a3");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	Наименование.Required = true;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Наименование.FieldName = "Naimenovanie";
	Наименование.SaveInDatabase = true;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Наименование"});
	Наименование.Description = "Наименование";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("e2d7fd49-c93f-46dd-97f4-94a0bc413fb9");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
			#region создание System.String Пароль
			{  
                NsgDataString Пароль = null;
				if (ObjectList.Contains("Пароль"))
                    Пароль = ObjectList["Пароль"] as NsgDataString;
                else
                    Пароль = new NsgDataString();
	//NsgDataString
	Пароль.IsLoadedFromDll = true;
	Пароль.Length = 50;
	Пароль.StringFormat = "";
	Пароль.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Пароль.IncludeInPredefined = false;
	Пароль.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пароль.Required = false;
	Пароль.EmptyValue = "";
	Пароль.NullAllow = false;
	Пароль.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Пароль.FieldName = "Parol";
	Пароль.SaveInDatabase = true;
	Пароль.InformMetaDataOnValueChanged = false;
	Пароль.Visible = true;
	Пароль.Name = "Пароль";
	Пароль.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пароль"});
	Пароль.Description = "Пароль";
	Пароль.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Пароль.GroupName = "";
	Пароль.Guid = NsgService.StringToGuid("394f1212-b145-4147-8068-4b370dd11059");
	
				if (!ObjectList.Contains("Пароль"))
                    ObjectList.Add(Пароль);
			}
			#endregion //создание System.String Пароль
			
			#region создание System.Boolean РольПользователя
			{  
                NsgDataBoolean РольПользователя = null;
				if (ObjectList.Contains("РольПользователя"))
                    РольПользователя = ObjectList["РольПользователя"] as NsgDataBoolean;
                else
                    РольПользователя = new NsgDataBoolean();
	//NsgDataBoolean
	РольПользователя.IsLoadedFromDll = true;
	РольПользователя.DefaultValue = false;
	РольПользователя.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РольПользователя.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РольПользователя.StringFormat = "";
	РольПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	РольПользователя.IncludeInPredefined = true;
	РольПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РольПользователя.Required = false;
	РольПользователя.EmptyValue = "";
	РольПользователя.NullAllow = false;
	РольПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РольПользователя.FieldName = "_Role";
	РольПользователя.SaveInDatabase = true;
	РольПользователя.InformMetaDataOnValueChanged = false;
	РольПользователя.Visible = true;
	РольПользователя.Name = "РольПользователя";
	РольПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Роль"});
	РольПользователя.Description = "Роль";
	РольПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	РольПользователя.GroupName = "";
	РольПользователя.Guid = NsgService.StringToGuid("4e7273ed-c18f-4847-a258-e2ac87067bea");
	
				if (!ObjectList.Contains("РольПользователя"))
                    ObjectList.Add(РольПользователя);
			}
			#endregion //создание System.Boolean РольПользователя
			
			#region создание _SystemTables.РолиПользователя РолиПользователя
			{  
                NsgDataTableReference РолиПользователя = null;
				if (ObjectList.Contains("РолиПользователя"))
                    РолиПользователя = ObjectList["РолиПользователя"] as NsgDataTableReference;
                else
                    РолиПользователя = new NsgDataTableReference();
	//NsgDataTableReference
	РолиПользователя.IsLoadedFromDll = true;
	РолиПользователя.Name = "РолиПользователя";
	РолиПользователя.SaveInDatabase = false;
	РолиПользователя.ReferentGroup = "_SystemTables";
	РолиПользователя.ReferentName = "РолиПользователя";
	РолиПользователя.OwnerName = "";
	РолиПользователя.AllowEmptyOwner = false;
	РолиПользователя.StringFormat = "";
	РолиПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	РолиПользователя.IncludeInPredefined = false;
	РолиПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РолиПользователя.Required = false;
	РолиПользователя.EmptyValue = "";
	РолиПользователя.NullAllow = false;
	РолиПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РолиПользователя.FieldName = "UserRoles";
	РолиПользователя.InformMetaDataOnValueChanged = false;
	РолиПользователя.Visible = true;
	РолиПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Роли пользователя"});
	РолиПользователя.Description = "Роли пользователя";
	РолиПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	РолиПользователя.GroupName = "";
	РолиПользователя.Guid = NsgService.StringToGuid("038451bb-af2a-4062-ba1f-37000ab6b9ef");
	
				if (!ObjectList.Contains("РолиПользователя"))
                    ObjectList.Add(РолиПользователя);
			}
			#endregion //создание _SystemTables.РолиПользователя РолиПользователя
			
			#region создание System.Boolean АдминистративныеПрава
			{  
                NsgDataBoolean АдминистративныеПрава = null;
				if (ObjectList.Contains("АдминистративныеПрава"))
                    АдминистративныеПрава = ObjectList["АдминистративныеПрава"] as NsgDataBoolean;
                else
                    АдминистративныеПрава = new NsgDataBoolean();
	//NsgDataBoolean
	АдминистративныеПрава.IsLoadedFromDll = true;
	АдминистративныеПрава.DefaultValue = false;
	АдминистративныеПрава.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	АдминистративныеПрава.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	АдминистративныеПрава.StringFormat = "";
	АдминистративныеПрава.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	АдминистративныеПрава.IncludeInPredefined = true;
	АдминистративныеПрава.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АдминистративныеПрава.Required = false;
	АдминистративныеПрава.EmptyValue = "";
	АдминистративныеПрава.NullAllow = false;
	АдминистративныеПрава.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АдминистративныеПрава.FieldName = "_AdminRights";
	АдминистративныеПрава.SaveInDatabase = true;
	АдминистративныеПрава.InformMetaDataOnValueChanged = false;
	АдминистративныеПрава.Visible = true;
	АдминистративныеПрава.Name = "АдминистративныеПрава";
	АдминистративныеПрава.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Административные права"});
	АдминистративныеПрава.Description = "Административные права";
	АдминистративныеПрава.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	АдминистративныеПрава.GroupName = "";
	АдминистративныеПрава.Guid = NsgService.StringToGuid("b799c0c4-9e15-44d6-b79b-f4aa5760b5bd");
	
				if (!ObjectList.Contains("АдминистративныеПрава"))
                    ObjectList.Add(АдминистративныеПрава);
			}
			#endregion //создание System.Boolean АдминистративныеПрава
			
			#region создание System.Boolean Заблокирован
			{  
                NsgDataBoolean Заблокирован = null;
				if (ObjectList.Contains("Заблокирован"))
                    Заблокирован = ObjectList["Заблокирован"] as NsgDataBoolean;
                else
                    Заблокирован = new NsgDataBoolean();
	//NsgDataBoolean
	Заблокирован.IsLoadedFromDll = true;
	Заблокирован.DefaultValue = false;
	Заблокирован.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Заблокирован.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Заблокирован.StringFormat = "";
	Заблокирован.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Заблокирован.IncludeInPredefined = true;
	Заблокирован.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Заблокирован.Required = false;
	Заблокирован.EmptyValue = "";
	Заблокирован.NullAllow = false;
	Заблокирован.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Заблокирован.FieldName = "_LockUser";
	Заблокирован.SaveInDatabase = true;
	Заблокирован.InformMetaDataOnValueChanged = false;
	Заблокирован.Visible = true;
	Заблокирован.Name = "Заблокирован";
	Заблокирован.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Заблокирован"});
	Заблокирован.Description = "Заблокирован";
	Заблокирован.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Заблокирован.GroupName = "";
	Заблокирован.Guid = NsgService.StringToGuid("bd407c55-0525-46f8-81f4-1b934a27d8b1");
	
				if (!ObjectList.Contains("Заблокирован"))
                    ObjectList.Add(Заблокирован);
			}
			#endregion //создание System.Boolean Заблокирован
			
			#region создание System.Boolean СкрыватьПользователяПриЛогине
			{  
                NsgDataBoolean СкрыватьПользователяПриЛогине = null;
				if (ObjectList.Contains("СкрыватьПользователяПриЛогине"))
                    СкрыватьПользователяПриЛогине = ObjectList["СкрыватьПользователяПриЛогине"] as NsgDataBoolean;
                else
                    СкрыватьПользователяПриЛогине = new NsgDataBoolean();
	//NsgDataBoolean
	СкрыватьПользователяПриЛогине.IsLoadedFromDll = true;
	СкрыватьПользователяПриЛогине.DefaultValue = false;
	СкрыватьПользователяПриЛогине.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СкрыватьПользователяПриЛогине.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СкрыватьПользователяПриЛогине.StringFormat = "";
	СкрыватьПользователяПриЛогине.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СкрыватьПользователяПриЛогине.IncludeInPredefined = true;
	СкрыватьПользователяПриЛогине.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СкрыватьПользователяПриЛогине.Required = false;
	СкрыватьПользователяПриЛогине.EmptyValue = "";
	СкрыватьПользователяПриЛогине.NullAllow = false;
	СкрыватьПользователяПриЛогине.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СкрыватьПользователяПриЛогине.FieldName = "_HideUser";
	СкрыватьПользователяПриЛогине.SaveInDatabase = true;
	СкрыватьПользователяПриЛогине.InformMetaDataOnValueChanged = false;
	СкрыватьПользователяПриЛогине.Visible = true;
	СкрыватьПользователяПриЛогине.Name = "СкрыватьПользователяПриЛогине";
	СкрыватьПользователяПриЛогине.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Скрывать пользователя при логине"});
	СкрыватьПользователяПриЛогине.Description = "Скрывать пользователя при логине";
	СкрыватьПользователяПриЛогине.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СкрыватьПользователяПриЛогине.GroupName = "";
	СкрыватьПользователяПриЛогине.Guid = NsgService.StringToGuid("6d72b38b-e7f3-4e00-9330-12b1f4f49645");
	
				if (!ObjectList.Contains("СкрыватьПользователяПриЛогине"))
                    ObjectList.Add(СкрыватьПользователяПриЛогине);
			}
			#endregion //создание System.Boolean СкрыватьПользователяПриЛогине
			
			#region создание System.Byte КодЗагрузки
			{  
                NsgDataByte КодЗагрузки = null;
				if (ObjectList.Contains("КодЗагрузки"))
                    КодЗагрузки = ObjectList["КодЗагрузки"] as NsgDataByte;
                else
                    КодЗагрузки = new NsgDataByte();
	//NsgDataByte
	КодЗагрузки.IsLoadedFromDll = true;
	КодЗагрузки.DefaultValue = 0M;
	КодЗагрузки.MinValue = 0M;
	КодЗагрузки.MaxValue = 0M;
	КодЗагрузки.UseCalculator = true;
	КодЗагрузки.StringFormat = "";
	КодЗагрузки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КодЗагрузки.IncludeInPredefined = true;
	КодЗагрузки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КодЗагрузки.Required = false;
	КодЗагрузки.EmptyValue = "";
	КодЗагрузки.NullAllow = false;
	КодЗагрузки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КодЗагрузки.FieldName = "_LoadCode";
	КодЗагрузки.SaveInDatabase = true;
	КодЗагрузки.InformMetaDataOnValueChanged = false;
	КодЗагрузки.Visible = true;
	КодЗагрузки.Name = "КодЗагрузки";
	КодЗагрузки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Код загрузки"});
	КодЗагрузки.Description = "Код загрузки";
	КодЗагрузки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	КодЗагрузки.GroupName = "";
	КодЗагрузки.Guid = NsgService.StringToGuid("8cfff680-71d6-4e4c-84ea-e771b54cabf4");
	
				if (!ObjectList.Contains("КодЗагрузки"))
                    ObjectList.Add(КодЗагрузки);
			}
			#endregion //создание System.Byte КодЗагрузки
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject ОбъектПриЗапуске
			{  
                NsgObjectSelector ОбъектПриЗапуске = null;
				if (ObjectList.Contains("ОбъектПриЗапуске"))
                    ОбъектПриЗапуске = ObjectList["ОбъектПриЗапуске"] as NsgObjectSelector;
                else
                    ОбъектПриЗапуске = new NsgObjectSelector();
	//NsgObjectSelector
	ОбъектПриЗапуске.IsLoadedFromDll = true;
	ОбъектПриЗапуске.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	ОбъектПриЗапуске.FilterForConfigurator = "NsgReportObject";
	ОбъектПриЗапуске.StringFormat = "";
	ОбъектПриЗапуске.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбъектПриЗапуске.IncludeInPredefined = false;
	ОбъектПриЗапуске.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектПриЗапуске.Required = false;
	ОбъектПриЗапуске.EmptyValue = "";
	ОбъектПриЗапуске.NullAllow = false;
	ОбъектПриЗапуске.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъектПриЗапуске.FieldName = "_StartObject";
	ОбъектПриЗапуске.SaveInDatabase = true;
	ОбъектПриЗапуске.InformMetaDataOnValueChanged = false;
	ОбъектПриЗапуске.Visible = true;
	ОбъектПриЗапуске.Name = "ОбъектПриЗапуске";
	ОбъектПриЗапуске.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Объект при запуске"});
	ОбъектПриЗапуске.Description = "Объект при запуске";
	ОбъектПриЗапуске.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ОбъектПриЗапуске.GroupName = "";
	ОбъектПриЗапуске.Guid = NsgService.StringToGuid("3821e0dd-9a43-4a85-be75-3eb77ef4de89");
	
				if (!ObjectList.Contains("ОбъектПриЗапуске"))
                    ObjectList.Add(ОбъектПриЗапуске);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject ОбъектПриЗапуске
			
			#region создание System.Drawing.Image ФотоПользователя
			{  
                NsgDataImage ФотоПользователя = null;
				if (ObjectList.Contains("ФотоПользователя"))
                    ФотоПользователя = ObjectList["ФотоПользователя"] as NsgDataImage;
                else
                    ФотоПользователя = new NsgDataImage();
	//NsgDataImage
	ФотоПользователя.IsLoadedFromDll = true;
	ФотоПользователя.MaximumSize = new Size(170,200);
	ФотоПользователя.MinimumSize = new Size(170,200);
	ФотоПользователя.StretchImage = true;
	ФотоПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФотоПользователя.NullAllow = true;
	ФотоПользователя.StringFormat = "";
	ФотоПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ФотоПользователя.IncludeInPredefined = false;
	ФотоПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФотоПользователя.Required = false;
	ФотоПользователя.EmptyValue = "";
	ФотоПользователя.FieldName = "FotoPolzovatelja";
	ФотоПользователя.SaveInDatabase = true;
	ФотоПользователя.InformMetaDataOnValueChanged = false;
	ФотоПользователя.Visible = true;
	ФотоПользователя.Name = "ФотоПользователя";
	ФотоПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Фото пользователя"});
	ФотоПользователя.Description = "Фото пользователя";
	ФотоПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФотоПользователя.GroupName = "";
	ФотоПользователя.Guid = NsgService.StringToGuid("737d651f-5a49-4ebc-8e71-931bcb5e9c41");
	
				if (!ObjectList.Contains("ФотоПользователя"))
                    ObjectList.Add(ФотоПользователя);
			}
			#endregion //создание System.Drawing.Image ФотоПользователя
			
			#region создание NsgSoft.Forms.NsgUserElementForm ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "NsgSoft.Forms.NsgUserElementForm";
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
	ФормаЭлемента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаЭлемента.GroupName = "";
	ФормаЭлемента.Guid = NsgService.StringToGuid("44fc3080-c538-454c-9d1b-0db24cd349f5");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание NsgSoft.Forms.NsgUserElementForm ФормаЭлемента
			
			#region создание NsgSoft.Forms.NsgUserElementForm ФормаГруппы
			{  
                NsgDataForm ФормаГруппы = null;
				if (ObjectList.Contains("ФормаГруппы"))
                    ФормаГруппы = ObjectList["ФормаГруппы"] as NsgDataForm;
                else
                    ФормаГруппы = new NsgDataForm();
	//NsgDataForm
	ФормаГруппы.IsLoadedFromDll = true;
	ФормаГруппы.FormClassName = "NsgSoft.Forms.NsgUserElementForm";
	ФормаГруппы.SaveInDatabase = false;
	ФормаГруппы.StringFormat = "";
	ФормаГруппы.SubType = NsgSoft.Common.NsgRekvisitSubType.GroupForm;
	ФормаГруппы.IncludeInPredefined = false;
	ФормаГруппы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаГруппы.Required = false;
	ФормаГруппы.EmptyValue = "";
	ФормаГруппы.NullAllow = false;
	ФормаГруппы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаГруппы.FieldName = "FormaGruppy";
	ФормаГруппы.InformMetaDataOnValueChanged = false;
	ФормаГруппы.Visible = true;
	ФормаГруппы.Name = "ФормаГруппы";
	ФормаГруппы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаГруппы.Description = "Форма группы";
	ФормаГруппы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаГруппы.GroupName = "";
	ФормаГруппы.Guid = NsgService.StringToGuid("7440e6c8-1dec-444d-9b86-d41768ea6df4");
	
				if (!ObjectList.Contains("ФормаГруппы"))
                    ObjectList.Add(ФормаГруппы);
			}
			#endregion //создание NsgSoft.Forms.NsgUserElementForm ФормаГруппы
			
			#region создание NsgSoft.Forms.NsgUserListForm ФормаСписка
			{  
                NsgDataForm ФормаСписка = null;
				if (ObjectList.Contains("ФормаСписка"))
                    ФормаСписка = ObjectList["ФормаСписка"] as NsgDataForm;
                else
                    ФормаСписка = new NsgDataForm();
	//NsgDataForm
	ФормаСписка.IsLoadedFromDll = true;
	ФормаСписка.FormClassName = "NsgSoft.Forms.NsgUserListForm";
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
	ФормаСписка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаСписка.GroupName = "";
	ФормаСписка.Guid = NsgService.StringToGuid("70f81342-dafa-47ef-b6f4-0e84cf1252f5");
	
				if (!ObjectList.Contains("ФормаСписка"))
                    ObjectList.Add(ФормаСписка);
			}
			#endregion //создание NsgSoft.Forms.NsgUserListForm ФормаСписка
			
			#region создание Сервис.Пользователи Администратор
			{  
                NsgDataPredefinedReference Администратор = null;
				if (ObjectList.Contains("Администратор"))
                    Администратор = ObjectList["Администратор"] as NsgDataPredefinedReference;
                else
                    Администратор = new NsgDataPredefinedReference();
	//NsgDataPredefinedReference
	Администратор.IsLoadedFromDll = true;
	Администратор.SaveInDatabase = false;
	Администратор.RequisiteValues = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Наименование", "АдминистративныеПрава", "РольПользователя", "Заблокирован", "СкрыватьПользователяПриЛогине", "КодЗагрузки"},
		 new System.Object[]{"Администратор", true, false, false, false,
		 new System.Byte()});
	Администратор.Guid = NsgService.StringToGuid("fedd419b-ef8e-4c15-988a-a327745d2b64");
	Администратор.ReferentGroup = "Сервис";
	Администратор.ReferentName = "Пользователи";
	Администратор.OwnerName = "";
	Администратор.AllowEmptyOwner = false;
	Администратор.StringFormat = "";
	Администратор.SubType = NsgSoft.Common.NsgRekvisitSubType.Predefined;
	Администратор.IncludeInPredefined = false;
	Администратор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Администратор.Required = false;
	Администратор.EmptyValue = "";
	Администратор.NullAllow = false;
	Администратор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Администратор.FieldName = "Administrator";
	Администратор.InformMetaDataOnValueChanged = false;
	Администратор.Visible = true;
	Администратор.Name = "Администратор";
	Администратор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Администратор"});
	Администратор.Description = "Для всех пользователей";
	Администратор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Администратор.GroupName = "";
	
				if (!ObjectList.Contains("Администратор"))
                    ObjectList.Add(Администратор);
			}
			#endregion //создание Сервис.Пользователи Администратор
			
			#region создание Сервис.Пользователи РольАдминистратора
			{  
                NsgDataPredefinedReference РольАдминистратора = null;
				if (ObjectList.Contains("РольАдминистратора"))
                    РольАдминистратора = ObjectList["РольАдминистратора"] as NsgDataPredefinedReference;
                else
                    РольАдминистратора = new NsgDataPredefinedReference();
	//NsgDataPredefinedReference
	РольАдминистратора.IsLoadedFromDll = true;
	РольАдминистратора.SaveInDatabase = false;
	РольАдминистратора.RequisiteValues = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Наименование", "АдминистративныеПрава", "РольПользователя", "Заблокирован", "СкрыватьПользователяПриЛогине", "КодЗагрузки"},
		 new System.Object[]{"РольАдминистратора", false, true, false, false,
		 new System.Byte()});
	РольАдминистратора.Guid = NsgService.StringToGuid("84c4f99e-cce1-4e17-a214-e35b11d6df35");
	РольАдминистратора.ReferentGroup = "Сервис";
	РольАдминистратора.ReferentName = "Пользователи";
	РольАдминистратора.OwnerName = "";
	РольАдминистратора.AllowEmptyOwner = false;
	РольАдминистратора.StringFormat = "";
	РольАдминистратора.SubType = NsgSoft.Common.NsgRekvisitSubType.Predefined;
	РольАдминистратора.IncludeInPredefined = false;
	РольАдминистратора.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РольАдминистратора.Required = false;
	РольАдминистратора.EmptyValue = "";
	РольАдминистратора.NullAllow = false;
	РольАдминистратора.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РольАдминистратора.FieldName = "RolAdministratora";
	РольАдминистратора.InformMetaDataOnValueChanged = false;
	РольАдминистратора.Visible = true;
	РольАдминистратора.Name = "РольАдминистратора";
	РольАдминистратора.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"РольАдминистратора"});
	РольАдминистратора.Description = "РольАдминистратора";
	РольАдминистратора.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РольАдминистратора.GroupName = "";
	
				if (!ObjectList.Contains("РольАдминистратора"))
                    ObjectList.Add(РольАдминистратора);
			}
			#endregion //создание Сервис.Пользователи РольАдминистратора
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Пользователи";
	Visible = true;
	Guid = NsgService.StringToGuid("ffe6bf09-fabd-4222-9c49-62163ad6a753");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "UserDictionary";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пользователи"});
	Description = "Пользователи";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
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
            /// Наименование
            /// </summary>
            public static String Наименование
            {
                get
                {
                    return "Наименование";
                }
            }
            
            /// <summary>
            /// Пароль
            /// </summary>
            public static String Пароль
            {
                get
                {
                    return "Пароль";
                }
            }
            
            /// <summary>
            /// Роль
            /// </summary>
            public static String РольПользователя
            {
                get
                {
                    return "РольПользователя";
                }
            }
            
            /// <summary>
            /// Роли пользователя
            /// </summary>
            public static String РолиПользователя
            {
                get
                {
                    return "РолиПользователя";
                }
            }
            
            /// <summary>
            /// Административные права
            /// </summary>
            public static String АдминистративныеПрава
            {
                get
                {
                    return "АдминистративныеПрава";
                }
            }
            
            /// <summary>
            /// Заблокирован
            /// </summary>
            public static String Заблокирован
            {
                get
                {
                    return "Заблокирован";
                }
            }
            
            /// <summary>
            /// Скрывать пользователя при логине
            /// </summary>
            public static String СкрыватьПользователяПриЛогине
            {
                get
                {
                    return "СкрыватьПользователяПриЛогине";
                }
            }
            
            /// <summary>
            /// Код загрузки
            /// </summary>
            public static String КодЗагрузки
            {
                get
                {
                    return "КодЗагрузки";
                }
            }
            
            /// <summary>
            /// Объект при запуске
            /// </summary>
            public static String ОбъектПриЗапуске
            {
                get
                {
                    return "ОбъектПриЗапуске";
                }
            }
            
            /// <summary>
            /// Фото пользователя
            /// </summary>
            public static String ФотоПользователя
            {
                get
                {
                    return "ФотоПользователя";
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
            /// Форма группы
            /// </summary>
            public static String ФормаГруппы
            {
                get
                {
                    return "ФормаГруппы";
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
            /// Для всех пользователей
            /// </summary>
            public static String Администратор
            {
                get
                {
                    return "Администратор";
                }
            }
            
            /// <summary>
            /// РольАдминистратора
            /// </summary>
            public static String РольАдминистратора
            {
                get
                {
                    return "РольАдминистратора";
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
                    descriptor.Name = "Пользователи";
                    descriptor.GroupName = "Сервис";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Сервис.Пользователи";
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
        /// Наименование
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
        /// Пароль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Пароль
        {
            get
            {
				 NsgDataString __Пароль = ObjectList["Пароль"] as NsgDataString;
                 return (System.String)__Пароль.Value;
            }
            set
            {
                NsgDataString __Пароль = ObjectList["Пароль"] as NsgDataString;
                __Пароль.Value = value;
            }
        }
        
        /// <summary>
        /// Роль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean РольПользователя
        {
            get
            {
				 NsgDataBoolean __РольПользователя = ObjectList["РольПользователя"] as NsgDataBoolean;
                 return (System.Boolean)__РольПользователя.Value;
            }
            set
            {
                NsgDataBoolean __РольПользователя = ObjectList["РольПользователя"] as NsgDataBoolean;
                __РольПользователя.Value = value;
            }
        }
        
        /// <summary>
        /// Роли пользователя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.РолиПользователя РолиПользователя
        {
            get
            {
				 NsgDataTableReference __РолиПользователя = ObjectList["РолиПользователя"] as NsgDataTableReference;
                 return (_SystemTables.РолиПользователя)__РолиПользователя.Referent;
            }
            set
            {
                NsgDataTableReference __РолиПользователя = ObjectList["РолиПользователя"] as NsgDataTableReference;
                __РолиПользователя.Referent = value;
            }
        }
        
        /// <summary>
        /// Административные права
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean АдминистративныеПрава
        {
            get
            {
				 NsgDataBoolean __АдминистративныеПрава = ObjectList["АдминистративныеПрава"] as NsgDataBoolean;
                 return (System.Boolean)__АдминистративныеПрава.Value;
            }
            set
            {
                NsgDataBoolean __АдминистративныеПрава = ObjectList["АдминистративныеПрава"] as NsgDataBoolean;
                __АдминистративныеПрава.Value = value;
            }
        }
        
        /// <summary>
        /// Заблокирован
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Заблокирован
        {
            get
            {
				 NsgDataBoolean __Заблокирован = ObjectList["Заблокирован"] as NsgDataBoolean;
                 return (System.Boolean)__Заблокирован.Value;
            }
            set
            {
                NsgDataBoolean __Заблокирован = ObjectList["Заблокирован"] as NsgDataBoolean;
                __Заблокирован.Value = value;
            }
        }
        
        /// <summary>
        /// Скрывать пользователя при логине
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean СкрыватьПользователяПриЛогине
        {
            get
            {
				 NsgDataBoolean __СкрыватьПользователяПриЛогине = ObjectList["СкрыватьПользователяПриЛогине"] as NsgDataBoolean;
                 return (System.Boolean)__СкрыватьПользователяПриЛогине.Value;
            }
            set
            {
                NsgDataBoolean __СкрыватьПользователяПриЛогине = ObjectList["СкрыватьПользователяПриЛогине"] as NsgDataBoolean;
                __СкрыватьПользователяПриЛогине.Value = value;
            }
        }
        
        /// <summary>
        /// Код загрузки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataByte")]
        
        public System.Byte КодЗагрузки
        {
            get
            {
				 NsgDataByte __КодЗагрузки = ObjectList["КодЗагрузки"] as NsgDataByte;
                 return (System.Byte)__КодЗагрузки.Value;
            }
            set
            {
                NsgDataByte __КодЗагрузки = ObjectList["КодЗагрузки"] as NsgDataByte;
                __КодЗагрузки.Value = value;
            }
        }
        
        /// <summary>
        /// Объект при запуске
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject ОбъектПриЗапуске
        {
            get
            {
				 NsgObjectSelector __ОбъектПриЗапуске = ObjectList["ОбъектПриЗапуске"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__ОбъектПриЗапуске.Object;
            }
            set
            {
                NsgObjectSelector __ОбъектПриЗапуске = ObjectList["ОбъектПриЗапуске"] as NsgObjectSelector;
                __ОбъектПриЗапуске.Object = value;
            }
        }
        
        /// <summary>
        /// Фото пользователя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataImage")]
        
        public System.Drawing.Image ФотоПользователя
        {
            get
            {
				 NsgDataImage __ФотоПользователя = ObjectList["ФотоПользователя"] as NsgDataImage;
                 return (System.Drawing.Image)__ФотоПользователя.Value;
            }
            set
            {
                NsgDataImage __ФотоПользователя = ObjectList["ФотоПользователя"] as NsgDataImage;
                __ФотоПользователя.Value = value;
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
        /// Форма группы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаГруппы
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаГруппы"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаГруппы");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаГруппы");
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
        public Пользователи Родитель
        {
            get
            {
                return base.Parent as Пользователи;
            }
            set
            {
                base.Parent = value;
            }
        }
        #region #Comment_Predefined#
        
        /// <summary>
        /// Для всех пользователей
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public static Пользователи Администратор
        {
            get
            {
                return (Пользователи)getPredefined(NsgService.StringToGuid("ffe6bf09-fabd-4222-9c49-62163ad6a753"), NsgService.StringToGuid("fedd419b-ef8e-4c15-988a-a327745d2b64"));
            }
        }
        
        /// <summary>
        /// РольАдминистратора
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public static Пользователи РольАдминистратора
        {
            get
            {
                return (Пользователи)getPredefined(NsgService.StringToGuid("ffe6bf09-fabd-4222-9c49-62163ad6a753"), NsgService.StringToGuid("84c4f99e-cce1-4e17-a214-e35b11d6df35"));
            }
        }
        
        #endregion //#Comment_Predefined#
		

        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDictionary

        #region Методы NsgMultipleObject
        private Пользователи[] convertArray(NsgMultipleObject[] array)
        {
            Пользователи[] res = new Пользователи[array.Length];
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
        public new virtual Пользователи[] FindAll(NsgCompare compare)
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
        public new virtual Пользователи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Пользователи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Пользователи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Пользователи(this as NsgObject);
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
                base.NSGType = typeof(Пользователи);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Пользователи Value
            {
                get
                {
                    return (Пользователи)base.Value;
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
