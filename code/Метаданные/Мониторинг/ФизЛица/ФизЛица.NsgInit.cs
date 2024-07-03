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
    
    [NsgTypeName("NsgDataDictionary", Guid = "f786c300-0c59-4ced-9998-affd2704a408")]
    public partial class ФизЛица : NsgSoft.DataObjects.NsgDataDictionary
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
        protected ФизЛица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ФизЛица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ФизЛица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f786c300-0c59-4ced-9998-affd2704a408"));
            if (obj == null)
                obj = new ФизЛица();
            return obj as ФизЛица;
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
	Идентификатор.Guid = NsgService.StringToGuid("231bf332-62ac-48e9-8106-d7081e00a524");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("dcff6638-dc40-4bf3-9034-3321f631f83c");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("a4f0c259-fa59-4bc6-95e3-7b49b0104b56");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("653a50a5-67d6-4375-83a5-2261f712ca5b");
	
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
	Уровень.Guid = NsgService.StringToGuid("3a666a65-7a6e-4cc9-8c60-d44141c5bb4d");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("07f4dd7d-bf80-48c5-854e-258ec9a48462");
	
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
	НомерКода.Guid = NsgService.StringToGuid("7599add2-9da3-4a66-8639-cbf2f53e6814");
	
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
	Код.Guid = NsgService.StringToGuid("faa8fb85-8a47-4638-84cd-776cd4ab07f1");
	
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
	Наименование.Guid = NsgService.StringToGuid("026d2f00-24cd-4adf-9f72-946947ad8677");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("d28519c2-c72a-4c25-9916-1d2e98946ead");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание System.String Фамилия
			{  
                NsgDataString Фамилия = null;
				if (ObjectList.Contains("Фамилия"))
                    Фамилия = ObjectList["Фамилия"] as NsgDataString;
                else
                    Фамилия = new NsgDataString();
	//NsgDataString
	Фамилия.IsLoadedFromDll = true;
	Фамилия.Length = 50;
	Фамилия.StringFormat = "";
	Фамилия.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Фамилия.IncludeInPredefined = false;
	Фамилия.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Фамилия.Required = false;
	Фамилия.EmptyValue = "";
	Фамилия.NullAllow = false;
	Фамилия.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Фамилия.FieldName = "Familija";
	Фамилия.SaveInDatabase = true;
	Фамилия.InformMetaDataOnValueChanged = false;
	Фамилия.Visible = true;
	Фамилия.Name = "Фамилия";
	Фамилия.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Фамилия.Description = "Фамилия";
	Фамилия.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Фамилия.GroupName = "";
	Фамилия.Guid = NsgService.StringToGuid("26ab03c6-880e-4d14-ac12-a0351d21dc05");
	
				if (!ObjectList.Contains("Фамилия"))
                    ObjectList.Add(Фамилия);
			}
			#endregion //создание System.String Фамилия
			
			#region создание System.String Отчество
			{  
                NsgDataString Отчество = null;
				if (ObjectList.Contains("Отчество"))
                    Отчество = ObjectList["Отчество"] as NsgDataString;
                else
                    Отчество = new NsgDataString();
	//NsgDataString
	Отчество.IsLoadedFromDll = true;
	Отчество.Length = 50;
	Отчество.StringFormat = "";
	Отчество.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Отчество.IncludeInPredefined = false;
	Отчество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Отчество.Required = false;
	Отчество.EmptyValue = "";
	Отчество.NullAllow = false;
	Отчество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Отчество.FieldName = "Otchestvo";
	Отчество.SaveInDatabase = true;
	Отчество.InformMetaDataOnValueChanged = false;
	Отчество.Visible = true;
	Отчество.Name = "Отчество";
	Отчество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Отчество.Description = "Отчество";
	Отчество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Отчество.GroupName = "";
	Отчество.Guid = NsgService.StringToGuid("0a6b618f-7509-4095-9482-9a6d1641ce04");
	
				if (!ObjectList.Contains("Отчество"))
                    ObjectList.Add(Отчество);
			}
			#endregion //создание System.String Отчество
			
			#region создание System.String НомерТелефона
			{  
                NsgDataString НомерТелефона = null;
				if (ObjectList.Contains("НомерТелефона"))
                    НомерТелефона = ObjectList["НомерТелефона"] as NsgDataString;
                else
                    НомерТелефона = new NsgDataString();
	//NsgDataString
	НомерТелефона.IsLoadedFromDll = true;
	НомерТелефона.Length = 50;
	НомерТелефона.StringFormat = "";
	НомерТелефона.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НомерТелефона.IncludeInPredefined = false;
	НомерТелефона.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерТелефона.Required = false;
	НомерТелефона.EmptyValue = "";
	НомерТелефона.NullAllow = false;
	НомерТелефона.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерТелефона.FieldName = "NomerTelefona";
	НомерТелефона.SaveInDatabase = true;
	НомерТелефона.InformMetaDataOnValueChanged = false;
	НомерТелефона.Visible = true;
	НомерТелефона.Name = "НомерТелефона";
	НомерТелефона.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерТелефона.Description = "Номер телефона";
	НомерТелефона.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерТелефона.GroupName = "";
	НомерТелефона.Guid = NsgService.StringToGuid("98161ddf-34fd-42cf-96a8-7451fe9d9453");
	
				if (!ObjectList.Contains("НомерТелефона"))
                    ObjectList.Add(НомерТелефона);
			}
			#endregion //создание System.String НомерТелефона
			
			#region создание Мониторинг.Должности Должность
			{  
                NsgDataTypedReference Должность = null;
				if (ObjectList.Contains("Должность"))
                    Должность = ObjectList["Должность"] as NsgDataTypedReference;
                else
                    Должность = new NsgDataTypedReference();
	//NsgDataTypedReference
	Должность.IsLoadedFromDll = true;
	Должность.ReferentGroup = "Мониторинг";
	Должность.ReferentName = "Должности";
	Должность.SaveInDatabase = true;
	Должность.OwnerName = "";
	Должность.AllowEmptyOwner = false;
	Должность.StringFormat = "";
	Должность.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Должность.IncludeInPredefined = false;
	Должность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Должность.Required = false;
	Должность.EmptyValue = "";
	Должность.NullAllow = false;
	Должность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Должность.FieldName = "Dolzhnost";
	Должность.InformMetaDataOnValueChanged = false;
	Должность.Visible = true;
	Должность.Name = "Должность";
	Должность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Должность.Description = "Должность";
	Должность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Должность.GroupName = "";
	Должность.Guid = NsgService.StringToGuid("02d61b9c-6324-4115-88b3-566d42297b6b");
	
				if (!ObjectList.Contains("Должность"))
                    ObjectList.Add(Должность);
			}
			#endregion //создание Мониторинг.Должности Должность
			
			#region создание System.String Имя
			{  
                NsgDataString Имя = null;
				if (ObjectList.Contains("Имя"))
                    Имя = ObjectList["Имя"] as NsgDataString;
                else
                    Имя = new NsgDataString();
	//NsgDataString
	Имя.IsLoadedFromDll = true;
	Имя.Length = 50;
	Имя.StringFormat = "";
	Имя.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Имя.IncludeInPredefined = false;
	Имя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Имя.Required = false;
	Имя.EmptyValue = "";
	Имя.NullAllow = false;
	Имя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Имя.FieldName = "Imja";
	Имя.SaveInDatabase = true;
	Имя.InformMetaDataOnValueChanged = false;
	Имя.Visible = true;
	Имя.Name = "Имя";
	Имя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Имя.Description = "Имя";
	Имя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Имя.GroupName = "";
	Имя.Guid = NsgService.StringToGuid("5d4569bc-89a7-463f-beec-a82e358ab24c");
	
				if (!ObjectList.Contains("Имя"))
                    ObjectList.Add(Имя);
			}
			#endregion //создание System.String Имя
			
			#region создание TechControl.Метаданные.Мониторинг.ФизЛицаФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ФизЛицаФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("b626b0d1-eccc-4b29-af75-5fd02306e0e2");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ФизЛицаФормаЭлемента ФормаЭлемента
			
			#region создание Мониторинг.СтатусСотрудника Статус
			{  
                NsgDataEnumReference Статус = null;
				if (ObjectList.Contains("Статус"))
                    Статус = ObjectList["Статус"] as NsgDataEnumReference;
                else
                    Статус = new NsgDataEnumReference();
	//NsgDataEnumReference
	Статус.IsLoadedFromDll = true;
	Статус.ReferentGroup = "Мониторинг";
	Статус.ReferentName = "СтатусСотрудника";
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
	Статус.Guid = NsgService.StringToGuid("44b4e773-997a-4597-85e4-86b82cd91c5f");
	
				if (!ObjectList.Contains("Статус"))
                    ObjectList.Add(Статус);
			}
			#endregion //создание Мониторинг.СтатусСотрудника Статус
			
			#region создание System.String ИдентификаторСтрока
			{  
                NsgDataString ИдентификаторСтрока = null;
				if (ObjectList.Contains("ИдентификаторСтрока"))
                    ИдентификаторСтрока = ObjectList["ИдентификаторСтрока"] as NsgDataString;
                else
                    ИдентификаторСтрока = new NsgDataString();
	//NsgDataString
	ИдентификаторСтрока.IsLoadedFromDll = true;
	ИдентификаторСтрока.Length = 50;
	ИдентификаторСтрока.StringFormat = "";
	ИдентификаторСтрока.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ИдентификаторСтрока.IncludeInPredefined = false;
	ИдентификаторСтрока.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторСтрока.Required = false;
	ИдентификаторСтрока.EmptyValue = "";
	ИдентификаторСтрока.NullAllow = false;
	ИдентификаторСтрока.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИдентификаторСтрока.FieldName = "IdentifikatorStroka";
	ИдентификаторСтрока.SaveInDatabase = true;
	ИдентификаторСтрока.InformMetaDataOnValueChanged = false;
	ИдентификаторСтрока.Visible = true;
	ИдентификаторСтрока.Name = "ИдентификаторСтрока";
	ИдентификаторСтрока.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИдентификаторСтрока.Description = "Идентификатор строка";
	ИдентификаторСтрока.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИдентификаторСтрока.GroupName = "";
	ИдентификаторСтрока.Guid = NsgService.StringToGuid("9dbfebce-0c0c-4838-b60b-24755f5abc02");
	
				if (!ObjectList.Contains("ИдентификаторСтрока"))
                    ObjectList.Add(ИдентификаторСтрока);
			}
			#endregion //создание System.String ИдентификаторСтрока
			
			#region создание System.Int64 IDСотрудника
			{  
                NsgDataInteger IDСотрудника = null;
				if (ObjectList.Contains("IDСотрудника"))
                    IDСотрудника = ObjectList["IDСотрудника"] as NsgDataInteger;
                else
                    IDСотрудника = new NsgDataInteger();
	//NsgDataInteger
	IDСотрудника.IsLoadedFromDll = true;
	IDСотрудника.DefaultValue = 0M;
	IDСотрудника.MinValue = 0M;
	IDСотрудника.MaxValue = 0M;
	IDСотрудника.UseCalculator = true;
	IDСотрудника.StringFormat = "";
	IDСотрудника.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	IDСотрудника.IncludeInPredefined = false;
	IDСотрудника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	IDСотрудника.Required = false;
	IDСотрудника.EmptyValue = "";
	IDСотрудника.NullAllow = false;
	IDСотрудника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	IDСотрудника.FieldName = "IDSotrudnika";
	IDСотрудника.SaveInDatabase = true;
	IDСотрудника.InformMetaDataOnValueChanged = false;
	IDСотрудника.Visible = true;
	IDСотрудника.Name = "IDСотрудника";
	IDСотрудника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	IDСотрудника.Description = "IDСотрудника";
	IDСотрудника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	IDСотрудника.GroupName = "";
	IDСотрудника.Guid = NsgService.StringToGuid("f8199b5a-f8a4-40bc-8bdf-adb33a646fb0");
	
				if (!ObjectList.Contains("IDСотрудника"))
                    ObjectList.Add(IDСотрудника);
			}
			#endregion //создание System.Int64 IDСотрудника
			
			#region создание Учет.Размеры Размер
			{  
                NsgDataTypedReference Размер = null;
				if (ObjectList.Contains("Размер"))
                    Размер = ObjectList["Размер"] as NsgDataTypedReference;
                else
                    Размер = new NsgDataTypedReference();
	//NsgDataTypedReference
	Размер.IsLoadedFromDll = true;
	Размер.ReferentGroup = "Учет";
	Размер.ReferentName = "Размеры";
	Размер.SaveInDatabase = true;
	Размер.OwnerName = "";
	Размер.AllowEmptyOwner = false;
	Размер.StringFormat = "";
	Размер.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Размер.IncludeInPredefined = false;
	Размер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Размер.Required = false;
	Размер.EmptyValue = "";
	Размер.NullAllow = false;
	Размер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Размер.FieldName = "Razmer";
	Размер.InformMetaDataOnValueChanged = false;
	Размер.Visible = true;
	Размер.Name = "Размер";
	Размер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Размер.Description = "Размер";
	Размер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Размер.GroupName = "";
	Размер.Guid = NsgService.StringToGuid("a58848f0-8226-485b-bf0f-38ffb9303c4d");
	
				if (!ObjectList.Contains("Размер"))
                    ObjectList.Add(Размер);
			}
			#endregion //создание Учет.Размеры Размер
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("e3d3d0ca-e691-4257-89d5-509cd6a13a1e");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.String ТабельныйНомер
			{  
                NsgDataString ТабельныйНомер = null;
				if (ObjectList.Contains("ТабельныйНомер"))
                    ТабельныйНомер = ObjectList["ТабельныйНомер"] as NsgDataString;
                else
                    ТабельныйНомер = new NsgDataString();
	//NsgDataString
	ТабельныйНомер.IsLoadedFromDll = true;
	ТабельныйНомер.Length = 50;
	ТабельныйНомер.StringFormat = "";
	ТабельныйНомер.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТабельныйНомер.IncludeInPredefined = false;
	ТабельныйНомер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТабельныйНомер.Required = false;
	ТабельныйНомер.EmptyValue = "";
	ТабельныйНомер.NullAllow = false;
	ТабельныйНомер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТабельныйНомер.FieldName = "TabelnyijNomer";
	ТабельныйНомер.SaveInDatabase = true;
	ТабельныйНомер.InformMetaDataOnValueChanged = false;
	ТабельныйНомер.Visible = true;
	ТабельныйНомер.Name = "ТабельныйНомер";
	ТабельныйНомер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТабельныйНомер.Description = "Табельный номер";
	ТабельныйНомер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТабельныйНомер.GroupName = "";
	ТабельныйНомер.Guid = NsgService.StringToGuid("21e2a7bf-1ee0-4689-a8bb-93974fe5b0a8");
	
				if (!ObjectList.Contains("ТабельныйНомер"))
                    ObjectList.Add(ТабельныйНомер);
			}
			#endregion //создание System.String ТабельныйНомер
			
			#region создание System.DateTime ДатаРождения
			{  
                NsgDataDateTime ДатаРождения = null;
				if (ObjectList.Contains("ДатаРождения"))
                    ДатаРождения = ObjectList["ДатаРождения"] as NsgDataDateTime;
                else
                    ДатаРождения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаРождения.IsLoadedFromDll = true;
	ДатаРождения.Format = NsgSoft.Common.NsgDateTimeFormat.Date;
	ДатаРождения.StringFormat = "";
	ДатаРождения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаРождения.IncludeInPredefined = false;
	ДатаРождения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаРождения.Required = false;
	ДатаРождения.EmptyValue = "";
	ДатаРождения.NullAllow = false;
	ДатаРождения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаРождения.FieldName = "DataRozhdenija";
	ДатаРождения.SaveInDatabase = true;
	ДатаРождения.InformMetaDataOnValueChanged = false;
	ДатаРождения.Visible = true;
	ДатаРождения.Name = "ДатаРождения";
	ДатаРождения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаРождения.Description = "Дата рождения";
	ДатаРождения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаРождения.GroupName = "";
	ДатаРождения.Guid = NsgService.StringToGuid("431b921c-35bd-41f3-a1bb-2527b3a638c0");
	
				if (!ObjectList.Contains("ДатаРождения"))
                    ObjectList.Add(ДатаРождения);
			}
			#endregion //создание System.DateTime ДатаРождения
			
			#region создание System.DateTime ДатаПриемаНаРаботу
			{  
                NsgDataDateTime ДатаПриемаНаРаботу = null;
				if (ObjectList.Contains("ДатаПриемаНаРаботу"))
                    ДатаПриемаНаРаботу = ObjectList["ДатаПриемаНаРаботу"] as NsgDataDateTime;
                else
                    ДатаПриемаНаРаботу = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПриемаНаРаботу.IsLoadedFromDll = true;
	ДатаПриемаНаРаботу.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПриемаНаРаботу.StringFormat = "";
	ДатаПриемаНаРаботу.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаПриемаНаРаботу.IncludeInPredefined = false;
	ДатаПриемаНаРаботу.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПриемаНаРаботу.Required = false;
	ДатаПриемаНаРаботу.EmptyValue = "";
	ДатаПриемаНаРаботу.NullAllow = false;
	ДатаПриемаНаРаботу.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПриемаНаРаботу.FieldName = "DataPriemaNaRabotu";
	ДатаПриемаНаРаботу.SaveInDatabase = true;
	ДатаПриемаНаРаботу.InformMetaDataOnValueChanged = false;
	ДатаПриемаНаРаботу.Visible = true;
	ДатаПриемаНаРаботу.Name = "ДатаПриемаНаРаботу";
	ДатаПриемаНаРаботу.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПриемаНаРаботу.Description = "Дата приема на работу";
	ДатаПриемаНаРаботу.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПриемаНаРаботу.GroupName = "";
	ДатаПриемаНаРаботу.Guid = NsgService.StringToGuid("c6c9cd54-c2ef-4b6d-95f7-31e4f098a95a");
	
				if (!ObjectList.Contains("ДатаПриемаНаРаботу"))
                    ObjectList.Add(ДатаПриемаНаРаботу);
			}
			#endregion //создание System.DateTime ДатаПриемаНаРаботу
			
			#region создание System.DateTime ДатаУвольнения
			{  
                NsgDataDateTime ДатаУвольнения = null;
				if (ObjectList.Contains("ДатаУвольнения"))
                    ДатаУвольнения = ObjectList["ДатаУвольнения"] as NsgDataDateTime;
                else
                    ДатаУвольнения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаУвольнения.IsLoadedFromDll = true;
	ДатаУвольнения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаУвольнения.StringFormat = "";
	ДатаУвольнения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаУвольнения.IncludeInPredefined = false;
	ДатаУвольнения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаУвольнения.Required = false;
	ДатаУвольнения.EmptyValue = "";
	ДатаУвольнения.NullAllow = false;
	ДатаУвольнения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаУвольнения.FieldName = "DataUvolnenija";
	ДатаУвольнения.SaveInDatabase = true;
	ДатаУвольнения.InformMetaDataOnValueChanged = false;
	ДатаУвольнения.Visible = true;
	ДатаУвольнения.Name = "ДатаУвольнения";
	ДатаУвольнения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаУвольнения.Description = "Дата увольнения";
	ДатаУвольнения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаУвольнения.GroupName = "";
	ДатаУвольнения.Guid = NsgService.StringToGuid("fea7f4b3-fc9c-460d-88ad-9dd97ea9e1dd");
	
				if (!ObjectList.Contains("ДатаУвольнения"))
                    ObjectList.Add(ДатаУвольнения);
			}
			#endregion //создание System.DateTime ДатаУвольнения
			
			#region создание _SystemTables.МониторингФизЛицаТаблицаРазмеров ТаблицаРазмеров
			{  
                NsgDataTableReference ТаблицаРазмеров = null;
				if (ObjectList.Contains("ТаблицаРазмеров"))
                    ТаблицаРазмеров = ObjectList["ТаблицаРазмеров"] as NsgDataTableReference;
                else
                    ТаблицаРазмеров = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаРазмеров.IsLoadedFromDll = true;
	ТаблицаРазмеров.Name = "ТаблицаРазмеров";
	ТаблицаРазмеров.SaveInDatabase = false;
	ТаблицаРазмеров.ReferentGroup = "_SystemTables";
	ТаблицаРазмеров.ReferentName = "МониторингФизЛицаТаблицаРазмеров";
	ТаблицаРазмеров.OwnerName = "";
	ТаблицаРазмеров.AllowEmptyOwner = false;
	ТаблицаРазмеров.StringFormat = "";
	ТаблицаРазмеров.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаРазмеров.IncludeInPredefined = false;
	ТаблицаРазмеров.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаРазмеров.Required = false;
	ТаблицаРазмеров.EmptyValue = "";
	ТаблицаРазмеров.NullAllow = false;
	ТаблицаРазмеров.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаРазмеров.FieldName = "TablicaRazmerov";
	ТаблицаРазмеров.InformMetaDataOnValueChanged = false;
	ТаблицаРазмеров.Visible = true;
	ТаблицаРазмеров.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаРазмеров.Description = "Таблица размеров";
	ТаблицаРазмеров.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаРазмеров.GroupName = "";
	ТаблицаРазмеров.Guid = NsgService.StringToGuid("16670079-aa4b-48e6-ac76-3a62e9a19879");
	
				if (!ObjectList.Contains("ТаблицаРазмеров"))
                    ObjectList.Add(ТаблицаРазмеров);
			}
			#endregion //создание _SystemTables.МониторингФизЛицаТаблицаРазмеров ТаблицаРазмеров
			
			#region создание Мониторинг.Объекты ОбъектВыдачиСпецодежды
			{  
                NsgDataTypedReference ОбъектВыдачиСпецодежды = null;
				if (ObjectList.Contains("ОбъектВыдачиСпецодежды"))
                    ОбъектВыдачиСпецодежды = ObjectList["ОбъектВыдачиСпецодежды"] as NsgDataTypedReference;
                else
                    ОбъектВыдачиСпецодежды = new NsgDataTypedReference();
	//NsgDataTypedReference
	ОбъектВыдачиСпецодежды.IsLoadedFromDll = true;
	ОбъектВыдачиСпецодежды.ReferentGroup = "Мониторинг";
	ОбъектВыдачиСпецодежды.ReferentName = "Объекты";
	ОбъектВыдачиСпецодежды.SaveInDatabase = true;
	ОбъектВыдачиСпецодежды.OwnerName = "";
	ОбъектВыдачиСпецодежды.AllowEmptyOwner = false;
	ОбъектВыдачиСпецодежды.StringFormat = "";
	ОбъектВыдачиСпецодежды.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбъектВыдачиСпецодежды.IncludeInPredefined = false;
	ОбъектВыдачиСпецодежды.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектВыдачиСпецодежды.Required = false;
	ОбъектВыдачиСпецодежды.EmptyValue = "";
	ОбъектВыдачиСпецодежды.NullAllow = false;
	ОбъектВыдачиСпецодежды.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъектВыдачиСпецодежды.FieldName = "ObektVydachiSpeco";
	ОбъектВыдачиСпецодежды.InformMetaDataOnValueChanged = false;
	ОбъектВыдачиСпецодежды.Visible = true;
	ОбъектВыдачиСпецодежды.Name = "ОбъектВыдачиСпецодежды";
	ОбъектВыдачиСпецодежды.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъектВыдачиСпецодежды.Description = "Объект выдачи спецодежды";
	ОбъектВыдачиСпецодежды.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъектВыдачиСпецодежды.GroupName = "";
	ОбъектВыдачиСпецодежды.Guid = NsgService.StringToGuid("f61a1649-dafa-4393-b07a-ac97287ff5e6");
	
				if (!ObjectList.Contains("ОбъектВыдачиСпецодежды"))
                    ObjectList.Add(ОбъектВыдачиСпецодежды);
			}
			#endregion //создание Мониторинг.Объекты ОбъектВыдачиСпецодежды
			
			#region создание Мониторинг.Объекты ОсновнойОбъект
			{  
                NsgDataTypedReference ОсновнойОбъект = null;
				if (ObjectList.Contains("ОсновнойОбъект"))
                    ОсновнойОбъект = ObjectList["ОсновнойОбъект"] as NsgDataTypedReference;
                else
                    ОсновнойОбъект = new NsgDataTypedReference();
	//NsgDataTypedReference
	ОсновнойОбъект.IsLoadedFromDll = true;
	ОсновнойОбъект.ReferentGroup = "Мониторинг";
	ОсновнойОбъект.ReferentName = "Объекты";
	ОсновнойОбъект.SaveInDatabase = true;
	ОсновнойОбъект.OwnerName = "";
	ОсновнойОбъект.AllowEmptyOwner = false;
	ОсновнойОбъект.StringFormat = "";
	ОсновнойОбъект.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОсновнойОбъект.IncludeInPredefined = false;
	ОсновнойОбъект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОсновнойОбъект.Required = false;
	ОсновнойОбъект.EmptyValue = "";
	ОсновнойОбъект.NullAllow = false;
	ОсновнойОбъект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОсновнойОбъект.FieldName = "OsnovnoijObekt";
	ОсновнойОбъект.InformMetaDataOnValueChanged = false;
	ОсновнойОбъект.Visible = true;
	ОсновнойОбъект.Name = "ОсновнойОбъект";
	ОсновнойОбъект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОсновнойОбъект.Description = "Основной объект";
	ОсновнойОбъект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОсновнойОбъект.GroupName = "";
	ОсновнойОбъект.Guid = NsgService.StringToGuid("2eea8cbf-15f0-45ef-82d3-930b4c7196bb");
	
				if (!ObjectList.Contains("ОсновнойОбъект"))
                    ObjectList.Add(ОсновнойОбъект);
			}
			#endregion //создание Мониторинг.Объекты ОсновнойОбъект
			
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
	ЗагрузочныйИдентификатор.Guid = NsgService.StringToGuid("3e1dfc80-680b-447b-a19c-f4d3790081a9");
	
				if (!ObjectList.Contains("ЗагрузочныйИдентификатор"))
                    ObjectList.Add(ЗагрузочныйИдентификатор);
			}
			#endregion //создание System.String ЗагрузочныйИдентификатор
			
			#region создание УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды ДокументКонтроляСпецодежды
			{  
                NsgDataTypedReference ДокументКонтроляСпецодежды = null;
				if (ObjectList.Contains("ДокументКонтроляСпецодежды"))
                    ДокументКонтроляСпецодежды = ObjectList["ДокументКонтроляСпецодежды"] as NsgDataTypedReference;
                else
                    ДокументКонтроляСпецодежды = new NsgDataTypedReference();
	//NsgDataTypedReference
	ДокументКонтроляСпецодежды.IsLoadedFromDll = true;
	ДокументКонтроляСпецодежды.ReferentGroup = "УчетСпецодеждыИСИЗ";
	ДокументКонтроляСпецодежды.ReferentName = "ПеремещениеСпецодежды";
	ДокументКонтроляСпецодежды.SaveInDatabase = true;
	ДокументКонтроляСпецодежды.OwnerName = "";
	ДокументКонтроляСпецодежды.AllowEmptyOwner = false;
	ДокументКонтроляСпецодежды.StringFormat = "";
	ДокументКонтроляСпецодежды.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДокументКонтроляСпецодежды.IncludeInPredefined = false;
	ДокументКонтроляСпецодежды.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументКонтроляСпецодежды.Required = false;
	ДокументКонтроляСпецодежды.EmptyValue = "";
	ДокументКонтроляСпецодежды.NullAllow = false;
	ДокументКонтроляСпецодежды.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДокументКонтроляСпецодежды.FieldName = "DokumentKontrolja";
	ДокументКонтроляСпецодежды.InformMetaDataOnValueChanged = false;
	ДокументКонтроляСпецодежды.Visible = true;
	ДокументКонтроляСпецодежды.Name = "ДокументКонтроляСпецодежды";
	ДокументКонтроляСпецодежды.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументКонтроляСпецодежды.Description = "Документ контроля спецодежды";
	ДокументКонтроляСпецодежды.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДокументКонтроляСпецодежды.GroupName = "";
	ДокументКонтроляСпецодежды.Guid = NsgService.StringToGuid("d769bc5b-c731-4a6e-8446-2764ade5b7d9");
	
				if (!ObjectList.Contains("ДокументКонтроляСпецодежды"))
                    ObjectList.Add(ДокументКонтроляСпецодежды);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды ДокументКонтроляСпецодежды
			
			#region создание Мониторинг.Подразделения Подразделение
			{  
                NsgDataTypedReference Подразделение = null;
				if (ObjectList.Contains("Подразделение"))
                    Подразделение = ObjectList["Подразделение"] as NsgDataTypedReference;
                else
                    Подразделение = new NsgDataTypedReference();
	//NsgDataTypedReference
	Подразделение.IsLoadedFromDll = true;
	Подразделение.ReferentGroup = "Мониторинг";
	Подразделение.ReferentName = "Подразделения";
	Подразделение.SaveInDatabase = true;
	Подразделение.OwnerName = "";
	Подразделение.AllowEmptyOwner = false;
	Подразделение.StringFormat = "";
	Подразделение.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Подразделение.IncludeInPredefined = false;
	Подразделение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Подразделение.Required = false;
	Подразделение.EmptyValue = "";
	Подразделение.NullAllow = false;
	Подразделение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Подразделение.FieldName = "Podrazdelenie";
	Подразделение.InformMetaDataOnValueChanged = false;
	Подразделение.Visible = true;
	Подразделение.Name = "Подразделение";
	Подразделение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Подразделение.Description = "Подразделение";
	Подразделение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Подразделение.GroupName = "";
	Подразделение.Guid = NsgService.StringToGuid("962f50e8-6cae-4cb6-89d8-09434d4eca7d");
	
				if (!ObjectList.Contains("Подразделение"))
                    ObjectList.Add(Подразделение);
			}
			#endregion //создание Мониторинг.Подразделения Подразделение
			
			#region создание _SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей ТаблицаСовмещаемыхДолжностей
			{  
                NsgDataTableReference ТаблицаСовмещаемыхДолжностей = null;
				if (ObjectList.Contains("ТаблицаСовмещаемыхДолжностей"))
                    ТаблицаСовмещаемыхДолжностей = ObjectList["ТаблицаСовмещаемыхДолжностей"] as NsgDataTableReference;
                else
                    ТаблицаСовмещаемыхДолжностей = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаСовмещаемыхДолжностей.IsLoadedFromDll = true;
	ТаблицаСовмещаемыхДолжностей.Name = "ТаблицаСовмещаемыхДолжностей";
	ТаблицаСовмещаемыхДолжностей.SaveInDatabase = false;
	ТаблицаСовмещаемыхДолжностей.ReferentGroup = "_SystemTables";
	ТаблицаСовмещаемыхДолжностей.ReferentName = "МониторингФизЛицаТаблицаСовмещаемыхДолжностей";
	ТаблицаСовмещаемыхДолжностей.OwnerName = "";
	ТаблицаСовмещаемыхДолжностей.AllowEmptyOwner = false;
	ТаблицаСовмещаемыхДолжностей.StringFormat = "";
	ТаблицаСовмещаемыхДолжностей.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаСовмещаемыхДолжностей.IncludeInPredefined = false;
	ТаблицаСовмещаемыхДолжностей.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаСовмещаемыхДолжностей.Required = false;
	ТаблицаСовмещаемыхДолжностей.EmptyValue = "";
	ТаблицаСовмещаемыхДолжностей.NullAllow = false;
	ТаблицаСовмещаемыхДолжностей.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаСовмещаемыхДолжностей.FieldName = "TablicaSovmeschae";
	ТаблицаСовмещаемыхДолжностей.InformMetaDataOnValueChanged = false;
	ТаблицаСовмещаемыхДолжностей.Visible = true;
	ТаблицаСовмещаемыхДолжностей.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаСовмещаемыхДолжностей.Description = "Таблица совмещаемых должностей";
	ТаблицаСовмещаемыхДолжностей.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаСовмещаемыхДолжностей.GroupName = "";
	ТаблицаСовмещаемыхДолжностей.Guid = NsgService.StringToGuid("a2976aa2-b9e5-4bc0-bb0b-3408baeb4e7b");
	
				if (!ObjectList.Contains("ТаблицаСовмещаемыхДолжностей"))
                    ObjectList.Add(ТаблицаСовмещаемыхДолжностей);
			}
			#endregion //создание _SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей ТаблицаСовмещаемыхДолжностей
			
			#region создание Мониторинг.Картинки КартинкаПодпись
			{  
                NsgDataTypedReference КартинкаПодпись = null;
				if (ObjectList.Contains("КартинкаПодпись"))
                    КартинкаПодпись = ObjectList["КартинкаПодпись"] as NsgDataTypedReference;
                else
                    КартинкаПодпись = new NsgDataTypedReference();
	//NsgDataTypedReference
	КартинкаПодпись.IsLoadedFromDll = true;
	КартинкаПодпись.ReferentGroup = "Мониторинг";
	КартинкаПодпись.ReferentName = "Картинки";
	КартинкаПодпись.SaveInDatabase = true;
	КартинкаПодпись.OwnerName = "";
	КартинкаПодпись.AllowEmptyOwner = false;
	КартинкаПодпись.StringFormat = "";
	КартинкаПодпись.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	КартинкаПодпись.IncludeInPredefined = false;
	КартинкаПодпись.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КартинкаПодпись.Required = false;
	КартинкаПодпись.EmptyValue = "";
	КартинкаПодпись.NullAllow = false;
	КартинкаПодпись.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КартинкаПодпись.FieldName = "KartinkaPodpis";
	КартинкаПодпись.InformMetaDataOnValueChanged = false;
	КартинкаПодпись.Visible = true;
	КартинкаПодпись.Name = "КартинкаПодпись";
	КартинкаПодпись.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КартинкаПодпись.Description = "Картинка подпись";
	КартинкаПодпись.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КартинкаПодпись.GroupName = "";
	КартинкаПодпись.Guid = NsgService.StringToGuid("2870da7d-44fe-4d6c-bc1f-6144f70636b7");
	
				if (!ObjectList.Contains("КартинкаПодпись"))
                    ObjectList.Add(КартинкаПодпись);
			}
			#endregion //создание Мониторинг.Картинки КартинкаПодпись
			
			#region создание System.String ФИО
			{  
                NsgDataString ФИО = null;
				if (ObjectList.Contains("ФИО"))
                    ФИО = ObjectList["ФИО"] as NsgDataString;
                else
                    ФИО = new NsgDataString();
	//NsgDataString
	ФИО.IsLoadedFromDll = true;
	ФИО.Length = 0;
	ФИО.StringFormat = "";
	ФИО.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ФИО.IncludeInPredefined = false;
	ФИО.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФИО.Required = false;
	ФИО.EmptyValue = "";
	ФИО.NullAllow = false;
	ФИО.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФИО.FieldName = "FIO";
	ФИО.SaveInDatabase = true;
	ФИО.InformMetaDataOnValueChanged = false;
	ФИО.Visible = true;
	ФИО.Name = "ФИО";
	ФИО.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФИО.Description = "ФИО";
	ФИО.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ФИО.GroupName = "";
	ФИО.Guid = NsgService.StringToGuid("e5f955f7-7847-4767-aef2-3595b2e1030c");
	
				if (!ObjectList.Contains("ФИО"))
                    ObjectList.Add(ФИО);
			}
			#endregion //создание System.String ФИО
			
			#region создание System.String ФИОРодительныйПадеж
			{  
                NsgDataString ФИОРодительныйПадеж = null;
				if (ObjectList.Contains("ФИОРодительныйПадеж"))
                    ФИОРодительныйПадеж = ObjectList["ФИОРодительныйПадеж"] as NsgDataString;
                else
                    ФИОРодительныйПадеж = new NsgDataString();
	//NsgDataString
	ФИОРодительныйПадеж.IsLoadedFromDll = true;
	ФИОРодительныйПадеж.Length = 0;
	ФИОРодительныйПадеж.StringFormat = "";
	ФИОРодительныйПадеж.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ФИОРодительныйПадеж.IncludeInPredefined = false;
	ФИОРодительныйПадеж.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФИОРодительныйПадеж.Required = false;
	ФИОРодительныйПадеж.EmptyValue = "";
	ФИОРодительныйПадеж.NullAllow = false;
	ФИОРодительныйПадеж.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФИОРодительныйПадеж.FieldName = "FIORoditelnyijPadezh";
	ФИОРодительныйПадеж.SaveInDatabase = true;
	ФИОРодительныйПадеж.InformMetaDataOnValueChanged = false;
	ФИОРодительныйПадеж.Visible = true;
	ФИОРодительныйПадеж.Name = "ФИОРодительныйПадеж";
	ФИОРодительныйПадеж.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФИОРодительныйПадеж.Description = "ФИОРодительный падеж";
	ФИОРодительныйПадеж.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ФИОРодительныйПадеж.GroupName = "";
	ФИОРодительныйПадеж.Guid = NsgService.StringToGuid("589236ea-a6bd-4105-a584-8ae5ff4d6e7a");
	
				if (!ObjectList.Contains("ФИОРодительныйПадеж"))
                    ObjectList.Add(ФИОРодительныйПадеж);
			}
			#endregion //создание System.String ФИОРодительныйПадеж
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 100;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ФизЛица";
	Visible = true;
	Guid = NsgService.StringToGuid("f786c300-0c59-4ced-9998-affd2704a408");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_dic_Sotrudniki";
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
            /// Фамилия
            /// </summary>
            public static String Фамилия
            {
                get
                {
                    return "Фамилия";
                }
            }
            
            /// <summary>
            /// Отчество
            /// </summary>
            public static String Отчество
            {
                get
                {
                    return "Отчество";
                }
            }
            
            /// <summary>
            /// Номер телефона
            /// </summary>
            public static String НомерТелефона
            {
                get
                {
                    return "НомерТелефона";
                }
            }
            
            /// <summary>
            /// Должность
            /// </summary>
            public static String Должность
            {
                get
                {
                    return "Должность";
                }
            }
            
            /// <summary>
            /// Имя
            /// </summary>
            public static String Имя
            {
                get
                {
                    return "Имя";
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
            /// Идентификатор строка
            /// </summary>
            public static String ИдентификаторСтрока
            {
                get
                {
                    return "ИдентификаторСтрока";
                }
            }
            
            /// <summary>
            /// IDСотрудника
            /// </summary>
            public static String IDСотрудника
            {
                get
                {
                    return "IDСотрудника";
                }
            }
            
            /// <summary>
            /// Размер
            /// </summary>
            public static String Размер
            {
                get
                {
                    return "Размер";
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
            /// Табельный номер
            /// </summary>
            public static String ТабельныйНомер
            {
                get
                {
                    return "ТабельныйНомер";
                }
            }
            
            /// <summary>
            /// Дата рождения
            /// </summary>
            public static String ДатаРождения
            {
                get
                {
                    return "ДатаРождения";
                }
            }
            
            /// <summary>
            /// Дата приема на работу
            /// </summary>
            public static String ДатаПриемаНаРаботу
            {
                get
                {
                    return "ДатаПриемаНаРаботу";
                }
            }
            
            /// <summary>
            /// Дата увольнения
            /// </summary>
            public static String ДатаУвольнения
            {
                get
                {
                    return "ДатаУвольнения";
                }
            }
            
            /// <summary>
            /// Таблица размеров
            /// </summary>
            public static String ТаблицаРазмеров
            {
                get
                {
                    return "ТаблицаРазмеров";
                }
            }
            
            /// <summary>
            /// Объект выдачи спецодежды
            /// </summary>
            public static String ОбъектВыдачиСпецодежды
            {
                get
                {
                    return "ОбъектВыдачиСпецодежды";
                }
            }
            
            /// <summary>
            /// Основной объект
            /// </summary>
            public static String ОсновнойОбъект
            {
                get
                {
                    return "ОсновнойОбъект";
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
            /// Документ контроля спецодежды
            /// </summary>
            public static String ДокументКонтроляСпецодежды
            {
                get
                {
                    return "ДокументКонтроляСпецодежды";
                }
            }
            
            /// <summary>
            /// Подразделение
            /// </summary>
            public static String Подразделение
            {
                get
                {
                    return "Подразделение";
                }
            }
            
            /// <summary>
            /// Таблица совмещаемых должностей
            /// </summary>
            public static String ТаблицаСовмещаемыхДолжностей
            {
                get
                {
                    return "ТаблицаСовмещаемыхДолжностей";
                }
            }
            
            /// <summary>
            /// Картинка подпись
            /// </summary>
            public static String КартинкаПодпись
            {
                get
                {
                    return "КартинкаПодпись";
                }
            }
            
            /// <summary>
            /// ФИО
            /// </summary>
            public static String ФИО
            {
                get
                {
                    return "ФИО";
                }
            }
            
            /// <summary>
            /// ФИОРодительный падеж
            /// </summary>
            public static String ФИОРодительныйПадеж
            {
                get
                {
                    return "ФИОРодительныйПадеж";
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
                    descriptor.Name = "ФизЛица";
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
            return "Мониторинг.ФизЛица";
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
        /// Фамилия
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Фамилия
        {
            get
            {
				 NsgDataString __Фамилия = ObjectList["Фамилия"] as NsgDataString;
                 return (System.String)__Фамилия.Value;
            }
            set
            {
                NsgDataString __Фамилия = ObjectList["Фамилия"] as NsgDataString;
                __Фамилия.Value = value;
            }
        }
        
        /// <summary>
        /// Отчество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Отчество
        {
            get
            {
				 NsgDataString __Отчество = ObjectList["Отчество"] as NsgDataString;
                 return (System.String)__Отчество.Value;
            }
            set
            {
                NsgDataString __Отчество = ObjectList["Отчество"] as NsgDataString;
                __Отчество.Value = value;
            }
        }
        
        /// <summary>
        /// Номер телефона
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String НомерТелефона
        {
            get
            {
				 NsgDataString __НомерТелефона = ObjectList["НомерТелефона"] as NsgDataString;
                 return (System.String)__НомерТелефона.Value;
            }
            set
            {
                NsgDataString __НомерТелефона = ObjectList["НомерТелефона"] as NsgDataString;
                __НомерТелефона.Value = value;
            }
        }
        
        /// <summary>
        /// Должность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Должности Должность
        {
            get
            {
				 NsgDataTypedReference __Должность = ObjectList["Должность"] as NsgDataTypedReference;
                 return (Мониторинг.Должности)__Должность.Referent;
            }
            set
            {
                NsgDataTypedReference __Должность = ObjectList["Должность"] as NsgDataTypedReference;
                __Должность.Referent = value;
            }
        }
        
        /// <summary>
        /// Имя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Имя
        {
            get
            {
				 NsgDataString __Имя = ObjectList["Имя"] as NsgDataString;
                 return (System.String)__Имя.Value;
            }
            set
            {
                NsgDataString __Имя = ObjectList["Имя"] as NsgDataString;
                __Имя.Value = value;
            }
        }
        
        /// <summary>
        /// Статус
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.СтатусСотрудника Статус
        {
            get
            {
				 NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                 return (Мониторинг.СтатусСотрудника)__Статус.Referent;
            }
            set
            {
                NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                __Статус.Referent = value;
            }
        }
        
        /// <summary>
        /// Идентификатор строка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ИдентификаторСтрока
        {
            get
            {
				 NsgDataString __ИдентификаторСтрока = ObjectList["ИдентификаторСтрока"] as NsgDataString;
                 return (System.String)__ИдентификаторСтрока.Value;
            }
            set
            {
                NsgDataString __ИдентификаторСтрока = ObjectList["ИдентификаторСтрока"] as NsgDataString;
                __ИдентификаторСтрока.Value = value;
            }
        }
        
        /// <summary>
        /// IDСотрудника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 IDСотрудника
        {
            get
            {
				 NsgDataInteger __IDСотрудника = ObjectList["IDСотрудника"] as NsgDataInteger;
                 return (System.Int64)__IDСотрудника.Value;
            }
            set
            {
                NsgDataInteger __IDСотрудника = ObjectList["IDСотрудника"] as NsgDataInteger;
                __IDСотрудника.Value = value;
            }
        }
        
        /// <summary>
        /// Размер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Размеры Размер
        {
            get
            {
				 NsgDataTypedReference __Размер = ObjectList["Размер"] as NsgDataTypedReference;
                 return (Учет.Размеры)__Размер.Referent;
            }
            set
            {
                NsgDataTypedReference __Размер = ObjectList["Размер"] as NsgDataTypedReference;
                __Размер.Referent = value;
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
        /// Табельный номер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ТабельныйНомер
        {
            get
            {
				 NsgDataString __ТабельныйНомер = ObjectList["ТабельныйНомер"] as NsgDataString;
                 return (System.String)__ТабельныйНомер.Value;
            }
            set
            {
                NsgDataString __ТабельныйНомер = ObjectList["ТабельныйНомер"] as NsgDataString;
                __ТабельныйНомер.Value = value;
            }
        }
        
        /// <summary>
        /// Дата рождения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаРождения
        {
            get
            {
				 NsgDataDateTime __ДатаРождения = ObjectList["ДатаРождения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаРождения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаРождения = ObjectList["ДатаРождения"] as NsgDataDateTime;
                __ДатаРождения.Value = value;
            }
        }
        
        /// <summary>
        /// Дата приема на работу
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПриемаНаРаботу
        {
            get
            {
				 NsgDataDateTime __ДатаПриемаНаРаботу = ObjectList["ДатаПриемаНаРаботу"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПриемаНаРаботу.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПриемаНаРаботу = ObjectList["ДатаПриемаНаРаботу"] as NsgDataDateTime;
                __ДатаПриемаНаРаботу.Value = value;
            }
        }
        
        /// <summary>
        /// Дата увольнения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаУвольнения
        {
            get
            {
				 NsgDataDateTime __ДатаУвольнения = ObjectList["ДатаУвольнения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаУвольнения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаУвольнения = ObjectList["ДатаУвольнения"] as NsgDataDateTime;
                __ДатаУвольнения.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица размеров
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФизЛицаТаблицаРазмеров ТаблицаРазмеров
        {
            get
            {
				 NsgDataTableReference __ТаблицаРазмеров = ObjectList["ТаблицаРазмеров"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФизЛицаТаблицаРазмеров)__ТаблицаРазмеров.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаРазмеров = ObjectList["ТаблицаРазмеров"] as NsgDataTableReference;
                __ТаблицаРазмеров.Referent = value;
            }
        }
        
        /// <summary>
        /// Объект выдачи спецодежды
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Объекты ОбъектВыдачиСпецодежды
        {
            get
            {
				 NsgDataTypedReference __ОбъектВыдачиСпецодежды = ObjectList["ОбъектВыдачиСпецодежды"] as NsgDataTypedReference;
                 return (Мониторинг.Объекты)__ОбъектВыдачиСпецодежды.Referent;
            }
            set
            {
                NsgDataTypedReference __ОбъектВыдачиСпецодежды = ObjectList["ОбъектВыдачиСпецодежды"] as NsgDataTypedReference;
                __ОбъектВыдачиСпецодежды.Referent = value;
            }
        }
        
        /// <summary>
        /// Основной объект
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Объекты ОсновнойОбъект
        {
            get
            {
				 NsgDataTypedReference __ОсновнойОбъект = ObjectList["ОсновнойОбъект"] as NsgDataTypedReference;
                 return (Мониторинг.Объекты)__ОсновнойОбъект.Referent;
            }
            set
            {
                NsgDataTypedReference __ОсновнойОбъект = ObjectList["ОсновнойОбъект"] as NsgDataTypedReference;
                __ОсновнойОбъект.Referent = value;
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
        /// Документ контроля спецодежды
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDocument")]
        
        public УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды ДокументКонтроляСпецодежды
        {
            get
            {
				 NsgDataTypedReference __ДокументКонтроляСпецодежды = ObjectList["ДокументКонтроляСпецодежды"] as NsgDataTypedReference;
                 return (УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды)__ДокументКонтроляСпецодежды.Referent;
            }
            set
            {
                NsgDataTypedReference __ДокументКонтроляСпецодежды = ObjectList["ДокументКонтроляСпецодежды"] as NsgDataTypedReference;
                __ДокументКонтроляСпецодежды.Referent = value;
            }
        }
        
        /// <summary>
        /// Подразделение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Подразделения Подразделение
        {
            get
            {
				 NsgDataTypedReference __Подразделение = ObjectList["Подразделение"] as NsgDataTypedReference;
                 return (Мониторинг.Подразделения)__Подразделение.Referent;
            }
            set
            {
                NsgDataTypedReference __Подразделение = ObjectList["Подразделение"] as NsgDataTypedReference;
                __Подразделение.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица совмещаемых должностей
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей ТаблицаСовмещаемыхДолжностей
        {
            get
            {
				 NsgDataTableReference __ТаблицаСовмещаемыхДолжностей = ObjectList["ТаблицаСовмещаемыхДолжностей"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей)__ТаблицаСовмещаемыхДолжностей.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаСовмещаемыхДолжностей = ObjectList["ТаблицаСовмещаемыхДолжностей"] as NsgDataTableReference;
                __ТаблицаСовмещаемыхДолжностей.Referent = value;
            }
        }
        
        /// <summary>
        /// Картинка подпись
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Картинки КартинкаПодпись
        {
            get
            {
				 NsgDataTypedReference __КартинкаПодпись = ObjectList["КартинкаПодпись"] as NsgDataTypedReference;
                 return (Мониторинг.Картинки)__КартинкаПодпись.Referent;
            }
            set
            {
                NsgDataTypedReference __КартинкаПодпись = ObjectList["КартинкаПодпись"] as NsgDataTypedReference;
                __КартинкаПодпись.Referent = value;
            }
        }
        
        /// <summary>
        /// ФИО
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ФИО
        {
            get
            {
				 NsgDataString __ФИО = ObjectList["ФИО"] as NsgDataString;
                 return (System.String)__ФИО.Value;
            }
            set
            {
                NsgDataString __ФИО = ObjectList["ФИО"] as NsgDataString;
                __ФИО.Value = value;
            }
        }
        
        /// <summary>
        /// ФИОРодительный падеж
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ФИОРодительныйПадеж
        {
            get
            {
				 NsgDataString __ФИОРодительныйПадеж = ObjectList["ФИОРодительныйПадеж"] as NsgDataString;
                 return (System.String)__ФИОРодительныйПадеж.Value;
            }
            set
            {
                NsgDataString __ФИОРодительныйПадеж = ObjectList["ФИОРодительныйПадеж"] as NsgDataString;
                __ФИОРодительныйПадеж.Value = value;
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
        public ФизЛица Родитель
        {
            get
            {
                return base.Parent as ФизЛица;
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
        private ФизЛица[] convertArray(NsgMultipleObject[] array)
        {
            ФизЛица[] res = new ФизЛица[array.Length];
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
        public new virtual ФизЛица[] FindAll(NsgCompare compare)
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
        public new virtual ФизЛица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ФизЛица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ФизЛица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ФизЛица(this as NsgObject);
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
                base.NSGType = typeof(ФизЛица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ФизЛица Value
            {
                get
                {
                    return (ФизЛица)base.Value;
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
