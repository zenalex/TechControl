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

namespace TechControl.Метаданные.Документы
{
    
    [NsgTypeName("NsgDataDocument", Guid = "3185b88c-749d-48ca-bea3-de5cec1b1b2c")]
    public partial class ЗаявкиНаРаботы : NsgSoft.DataObjects.NsgDataDocument
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDocument

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDocument

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ЗаявкиНаРаботы()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ЗаявкиНаРаботы(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ЗаявкиНаРаботы Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3185b88c-749d-48ca-bea3-de5cec1b1b2c"));
            if (obj == null)
                obj = new ЗаявкиНаРаботы();
            return obj as ЗаявкиНаРаботы;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDocument
			
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
	Идентификатор.Guid = NsgService.StringToGuid("96b3ebaf-67bd-4961-8cc0-7e03740e1099");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("1e935f20-53b5-4400-be6e-55e9ff3f6aa0");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
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
	ПрефиксКода.Guid = NsgService.StringToGuid("762d6f62-0fd1-43e2-b1b9-0bb2db4d5592");
	
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
	НомерКода.Guid = NsgService.StringToGuid("a71717a1-71ed-43ca-92c1-10b50ab89f08");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String НомерДокумента
			{  
                NsgDataVirtualObject НомерДокумента = null;
				if (ObjectList.Contains("НомерДокумента"))
                    НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                else
                    НомерДокумента = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	НомерДокумента.IsLoadedFromDll = true;
	НомерДокумента.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	НомерДокумента.SaveInDatabase = false;
	НомерДокумента.StringFormat = "";
	НомерДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерДокумента.IncludeInPredefined = false;
	НомерДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерДокумента.Required = false;
	НомерДокумента.EmptyValue = "";
	НомерДокумента.NullAllow = false;
	НомерДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерДокумента.FieldName = "_Code";
	НомерДокумента.InformMetaDataOnValueChanged = false;
	НомерДокумента.Visible = true;
	НомерДокумента.Name = "НомерДокумента";
	НомерДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Номер документа"});
	НомерДокумента.Description = "Номер документа";
	НомерДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерДокумента.GroupName = "";
	НомерДокумента.Guid = NsgService.StringToGuid("bfc8de11-ebba-4a02-81f1-cc8ed7655804");
	
				if (!ObjectList.Contains("НомерДокумента"))
                    ObjectList.Add(НомерДокумента);
			}
			#endregion //создание System.String НомерДокумента
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("8d8af067-5855-4b07-a96b-943d9737666b");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.String Индекс
			{  
                NsgDataIndex Индекс = null;
				if (ObjectList.Contains("Индекс"))
                    Индекс = ObjectList["Индекс"] as NsgDataIndex;
                else
                    Индекс = new NsgDataIndex();
	//NsgDataIndex
	Индекс.IsLoadedFromDll = true;
	Индекс.RequisiteList = "ДатаДокумента,Автоинкремент";
	Индекс.SaveInDatabase = false;
	Индекс.StringFormat = "";
	Индекс.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Индекс.IncludeInPredefined = false;
	Индекс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Индекс.Required = false;
	Индекс.EmptyValue = "";
	Индекс.NullAllow = false;
	Индекс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Индекс.FieldName = "_Index";
	Индекс.InformMetaDataOnValueChanged = false;
	Индекс.Visible = true;
	Индекс.Name = "Индекс";
	Индекс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Индекс.Description = "Индекс";
	Индекс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Индекс.GroupName = "";
	Индекс.Guid = NsgService.StringToGuid("affce341-048a-4062-8af3-3c8ded67158b");
	
				if (!ObjectList.Contains("Индекс"))
                    ObjectList.Add(Индекс);
			}
			#endregion //создание System.String Индекс
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			{  
                NsgDataUntypedReference ДокументОснование = null;
				if (ObjectList.Contains("ДокументОснование"))
                    ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                else
                    ДокументОснование = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ДокументОснование.IsLoadedFromDll = true;
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	ДокументОснование.FilterForConfigurator = "";
	ДокументОснование.ReferentName = "";
	ДокументОснование.ReferentGroup = "";
	ДокументОснование.TypeSelectorName = "";
	ДокументОснование.SaveInDatabase = true;
	ДокументОснование.OwnerName = "";
	ДокументОснование.AllowEmptyOwner = false;
	ДокументОснование.StringFormat = "";
	ДокументОснование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДокументОснование.IncludeInPredefined = false;
	ДокументОснование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументОснование.Required = false;
	ДокументОснование.EmptyValue = "";
	ДокументОснование.NullAllow = false;
	ДокументОснование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДокументОснование.FieldName = "_BaseDocument";
	ДокументОснование.InformMetaDataOnValueChanged = false;
	ДокументОснование.Visible = true;
	ДокументОснование.Name = "ДокументОснование";
	ДокументОснование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументОснование.Description = "Документ основание";
	ДокументОснование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДокументОснование.GroupName = "";
	ДокументОснование.Guid = NsgService.StringToGuid("85afa967-07b7-44ef-8396-3863b87dcd55");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
			#region создание System.String Комментарий
			{  
                NsgDataString Комментарий = null;
				if (ObjectList.Contains("Комментарий"))
                    Комментарий = ObjectList["Комментарий"] as NsgDataString;
                else
                    Комментарий = new NsgDataString();
	//NsgDataString
	Комментарий.IsLoadedFromDll = true;
	Комментарий.Length = 0;
	Комментарий.StringFormat = "";
	Комментарий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Комментарий.IncludeInPredefined = false;
	Комментарий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Комментарий.Required = false;
	Комментарий.EmptyValue = "";
	Комментарий.NullAllow = false;
	Комментарий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Комментарий.FieldName = "Kommentariij";
	Комментарий.SaveInDatabase = true;
	Комментарий.InformMetaDataOnValueChanged = false;
	Комментарий.Visible = true;
	Комментарий.Name = "Комментарий";
	Комментарий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Комментарий.Description = "Комментарий";
	Комментарий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Комментарий.GroupName = "";
	Комментарий.Guid = NsgService.StringToGuid("b0751306-fd03-46c3-86ec-3f3c19b8a25e");
	
				if (!ObjectList.Contains("Комментарий"))
                    ObjectList.Add(Комментарий);
			}
			#endregion //создание System.String Комментарий
			
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
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("c773f4bf-dd59-4bab-bd10-44a2f25c3bf3");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Перечисления.СтатусыЗаявок СтатусЗаявки
			{  
                NsgDataEnumReference СтатусЗаявки = null;
				if (ObjectList.Contains("СтатусЗаявки"))
                    СтатусЗаявки = ObjectList["СтатусЗаявки"] as NsgDataEnumReference;
                else
                    СтатусЗаявки = new NsgDataEnumReference();
	//NsgDataEnumReference
	СтатусЗаявки.IsLoadedFromDll = true;
	СтатусЗаявки.ReferentGroup = "Перечисления";
	СтатусЗаявки.ReferentName = "СтатусыЗаявок";
	СтатусЗаявки.SaveInDatabase = true;
	СтатусЗаявки.OwnerName = "";
	СтатусЗаявки.AllowEmptyOwner = false;
	СтатусЗаявки.StringFormat = "";
	СтатусЗаявки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СтатусЗаявки.IncludeInPredefined = false;
	СтатусЗаявки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СтатусЗаявки.Required = false;
	СтатусЗаявки.EmptyValue = "";
	СтатусЗаявки.NullAllow = false;
	СтатусЗаявки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СтатусЗаявки.FieldName = "StatusZajavki";
	СтатусЗаявки.InformMetaDataOnValueChanged = false;
	СтатусЗаявки.Visible = true;
	СтатусЗаявки.Name = "СтатусЗаявки";
	СтатусЗаявки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусЗаявки.Description = "Статус заявки";
	СтатусЗаявки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СтатусЗаявки.GroupName = "";
	СтатусЗаявки.Guid = NsgService.StringToGuid("f2561178-cf9a-445e-9f28-4fc0bdbc2011");
	
				if (!ObjectList.Contains("СтатусЗаявки"))
                    ObjectList.Add(СтатусЗаявки);
			}
			#endregion //создание Перечисления.СтатусыЗаявок СтатусЗаявки
			
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
	Объект.Guid = NsgService.StringToGuid("2a8fce40-64f8-4ff6-962e-1a731625c55d");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание System.DateTime ДатаПередачиОбъектаЗаказчиком
			{  
                NsgDataDateTime ДатаПередачиОбъектаЗаказчиком = null;
				if (ObjectList.Contains("ДатаПередачиОбъектаЗаказчиком"))
                    ДатаПередачиОбъектаЗаказчиком = ObjectList["ДатаПередачиОбъектаЗаказчиком"] as NsgDataDateTime;
                else
                    ДатаПередачиОбъектаЗаказчиком = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПередачиОбъектаЗаказчиком.IsLoadedFromDll = true;
	ДатаПередачиОбъектаЗаказчиком.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПередачиОбъектаЗаказчиком.StringFormat = "";
	ДатаПередачиОбъектаЗаказчиком.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаПередачиОбъектаЗаказчиком.IncludeInPredefined = false;
	ДатаПередачиОбъектаЗаказчиком.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПередачиОбъектаЗаказчиком.Required = false;
	ДатаПередачиОбъектаЗаказчиком.EmptyValue = "";
	ДатаПередачиОбъектаЗаказчиком.NullAllow = false;
	ДатаПередачиОбъектаЗаказчиком.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПередачиОбъектаЗаказчиком.FieldName = "DataPeredachiObek";
	ДатаПередачиОбъектаЗаказчиком.SaveInDatabase = true;
	ДатаПередачиОбъектаЗаказчиком.InformMetaDataOnValueChanged = false;
	ДатаПередачиОбъектаЗаказчиком.Visible = true;
	ДатаПередачиОбъектаЗаказчиком.Name = "ДатаПередачиОбъектаЗаказчиком";
	ДатаПередачиОбъектаЗаказчиком.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПередачиОбъектаЗаказчиком.Description = "Дата передачи объекта заказчиком";
	ДатаПередачиОбъектаЗаказчиком.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПередачиОбъектаЗаказчиком.GroupName = "";
	ДатаПередачиОбъектаЗаказчиком.Guid = NsgService.StringToGuid("811b83c4-2e4b-46ad-a16b-31122a3c72e6");
	
				if (!ObjectList.Contains("ДатаПередачиОбъектаЗаказчиком"))
                    ObjectList.Add(ДатаПередачиОбъектаЗаказчиком);
			}
			#endregion //создание System.DateTime ДатаПередачиОбъектаЗаказчиком
			
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
	Ответственный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Ответственный.Guid = NsgService.StringToGuid("43b56c5f-1f95-4f28-b5e3-7a92f8a35bfa");
	
				if (!ObjectList.Contains("Ответственный"))
                    ObjectList.Add(Ответственный);
			}
			#endregion //создание Мониторинг.ФизЛица Ответственный
			
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
	Автор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Автор.Guid = NsgService.StringToGuid("48a6061a-1f33-4836-a132-c654c47ff6b4");
	
				if (!ObjectList.Contains("Автор"))
                    ObjectList.Add(Автор);
			}
			#endregion //создание СлужебныеСправочники.ПользователиСервисов Автор
			
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
	Подрядчик.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Подрядчик.Guid = NsgService.StringToGuid("93c7d044-b5bc-4bb4-98f3-29cb5d560f48");
	
				if (!ObjectList.Contains("Подрядчик"))
                    ObjectList.Add(Подрядчик);
			}
			#endregion //создание Мониторинг.Контрагенты Подрядчик
			
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
	Заказчик.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Заказчик.Guid = NsgService.StringToGuid("a5fd69f5-f004-4140-8155-1b5ca0932a54");
	
				if (!ObjectList.Contains("Заказчик"))
                    ObjectList.Add(Заказчик);
			}
			#endregion //создание Мониторинг.Контрагенты Заказчик
			
			#region создание System.String ЗаказчикСтрока
			{  
                NsgDataString ЗаказчикСтрока = null;
				if (ObjectList.Contains("ЗаказчикСтрока"))
                    ЗаказчикСтрока = ObjectList["ЗаказчикСтрока"] as NsgDataString;
                else
                    ЗаказчикСтрока = new NsgDataString();
	//NsgDataString
	ЗаказчикСтрока.IsLoadedFromDll = true;
	ЗаказчикСтрока.Length = 0;
	ЗаказчикСтрока.StringFormat = "";
	ЗаказчикСтрока.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЗаказчикСтрока.IncludeInPredefined = false;
	ЗаказчикСтрока.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЗаказчикСтрока.Required = false;
	ЗаказчикСтрока.EmptyValue = "";
	ЗаказчикСтрока.NullAllow = false;
	ЗаказчикСтрока.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЗаказчикСтрока.FieldName = "ZakazchikStroka";
	ЗаказчикСтрока.SaveInDatabase = true;
	ЗаказчикСтрока.InformMetaDataOnValueChanged = false;
	ЗаказчикСтрока.Visible = true;
	ЗаказчикСтрока.Name = "ЗаказчикСтрока";
	ЗаказчикСтрока.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗаказчикСтрока.Description = "Заказчик строка";
	ЗаказчикСтрока.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЗаказчикСтрока.GroupName = "";
	ЗаказчикСтрока.Guid = NsgService.StringToGuid("c1e2363d-d9d8-4c34-a7ac-4ec46c341171");
	
				if (!ObjectList.Contains("ЗаказчикСтрока"))
                    ObjectList.Add(ЗаказчикСтрока);
			}
			#endregion //создание System.String ЗаказчикСтрока
			
			#region создание System.String НомерЗаявкиЗаказчика
			{  
                NsgDataString НомерЗаявкиЗаказчика = null;
				if (ObjectList.Contains("НомерЗаявкиЗаказчика"))
                    НомерЗаявкиЗаказчика = ObjectList["НомерЗаявкиЗаказчика"] as NsgDataString;
                else
                    НомерЗаявкиЗаказчика = new NsgDataString();
	//NsgDataString
	НомерЗаявкиЗаказчика.IsLoadedFromDll = true;
	НомерЗаявкиЗаказчика.Length = 50;
	НомерЗаявкиЗаказчика.StringFormat = "";
	НомерЗаявкиЗаказчика.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерЗаявкиЗаказчика.IncludeInPredefined = false;
	НомерЗаявкиЗаказчика.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерЗаявкиЗаказчика.Required = false;
	НомерЗаявкиЗаказчика.EmptyValue = "";
	НомерЗаявкиЗаказчика.NullAllow = false;
	НомерЗаявкиЗаказчика.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерЗаявкиЗаказчика.FieldName = "NomerZajavkiZakaz";
	НомерЗаявкиЗаказчика.SaveInDatabase = true;
	НомерЗаявкиЗаказчика.InformMetaDataOnValueChanged = false;
	НомерЗаявкиЗаказчика.Visible = true;
	НомерЗаявкиЗаказчика.Name = "НомерЗаявкиЗаказчика";
	НомерЗаявкиЗаказчика.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерЗаявкиЗаказчика.Description = "Номер заявки заказчика";
	НомерЗаявкиЗаказчика.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерЗаявкиЗаказчика.GroupName = "";
	НомерЗаявкиЗаказчика.Guid = NsgService.StringToGuid("5b4c4921-7474-4f54-969c-2c1ae9f062e6");
	
				if (!ObjectList.Contains("НомерЗаявкиЗаказчика"))
                    ObjectList.Add(НомерЗаявкиЗаказчика);
			}
			#endregion //создание System.String НомерЗаявкиЗаказчика
			
			#region создание System.DateTime ДатаОкончанияРаботПоОбъекту
			{  
                NsgDataDateTime ДатаОкончанияРаботПоОбъекту = null;
				if (ObjectList.Contains("ДатаОкончанияРаботПоОбъекту"))
                    ДатаОкончанияРаботПоОбъекту = ObjectList["ДатаОкончанияРаботПоОбъекту"] as NsgDataDateTime;
                else
                    ДатаОкончанияРаботПоОбъекту = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияРаботПоОбъекту.IsLoadedFromDll = true;
	ДатаОкончанияРаботПоОбъекту.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончанияРаботПоОбъекту.StringFormat = "";
	ДатаОкончанияРаботПоОбъекту.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияРаботПоОбъекту.IncludeInPredefined = false;
	ДатаОкончанияРаботПоОбъекту.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияРаботПоОбъекту.Required = false;
	ДатаОкончанияРаботПоОбъекту.EmptyValue = "";
	ДатаОкончанияРаботПоОбъекту.NullAllow = false;
	ДатаОкончанияРаботПоОбъекту.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончанияРаботПоОбъекту.FieldName = "DataOkonchanijaRa";
	ДатаОкончанияРаботПоОбъекту.SaveInDatabase = true;
	ДатаОкончанияРаботПоОбъекту.InformMetaDataOnValueChanged = false;
	ДатаОкончанияРаботПоОбъекту.Visible = true;
	ДатаОкончанияРаботПоОбъекту.Name = "ДатаОкончанияРаботПоОбъекту";
	ДатаОкончанияРаботПоОбъекту.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончанияРаботПоОбъекту.Description = "Дата окончания работ по объекту";
	ДатаОкончанияРаботПоОбъекту.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончанияРаботПоОбъекту.GroupName = "";
	ДатаОкончанияРаботПоОбъекту.Guid = NsgService.StringToGuid("23806c1b-ac2c-414f-85fd-134cf134e039");
	
				if (!ObjectList.Contains("ДатаОкончанияРаботПоОбъекту"))
                    ObjectList.Add(ДатаОкончанияРаботПоОбъекту);
			}
			#endregion //создание System.DateTime ДатаОкончанияРаботПоОбъекту
			
			#region создание _SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот ТаблицаВидыРабот
			{  
                NsgDataTableReference ТаблицаВидыРабот = null;
				if (ObjectList.Contains("ТаблицаВидыРабот"))
                    ТаблицаВидыРабот = ObjectList["ТаблицаВидыРабот"] as NsgDataTableReference;
                else
                    ТаблицаВидыРабот = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаВидыРабот.IsLoadedFromDll = true;
	ТаблицаВидыРабот.Name = "ТаблицаВидыРабот";
	ТаблицаВидыРабот.SaveInDatabase = false;
	ТаблицаВидыРабот.ReferentGroup = "_SystemTables";
	ТаблицаВидыРабот.ReferentName = "ДокументыЗаявкиНаРаботыТаблицаВидыРабот";
	ТаблицаВидыРабот.OwnerName = "";
	ТаблицаВидыРабот.AllowEmptyOwner = false;
	ТаблицаВидыРабот.StringFormat = "";
	ТаблицаВидыРабот.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаВидыРабот.IncludeInPredefined = false;
	ТаблицаВидыРабот.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаВидыРабот.Required = false;
	ТаблицаВидыРабот.EmptyValue = "";
	ТаблицаВидыРабот.NullAllow = false;
	ТаблицаВидыРабот.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаВидыРабот.FieldName = "TablicaVidyRabot";
	ТаблицаВидыРабот.InformMetaDataOnValueChanged = false;
	ТаблицаВидыРабот.Visible = true;
	ТаблицаВидыРабот.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаВидыРабот.Description = "Таблица виды работ";
	ТаблицаВидыРабот.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаВидыРабот.GroupName = "";
	ТаблицаВидыРабот.Guid = NsgService.StringToGuid("70152deb-d4c3-48e6-abda-7fc8b1180d0b");
	
				if (!ObjectList.Contains("ТаблицаВидыРабот"))
                    ObjectList.Add(ТаблицаВидыРабот);
			}
			#endregion //создание _SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот ТаблицаВидыРабот
			
			#region создание System.String ОписаниеОбъекта
			{  
                NsgDataString ОписаниеОбъекта = null;
				if (ObjectList.Contains("ОписаниеОбъекта"))
                    ОписаниеОбъекта = ObjectList["ОписаниеОбъекта"] as NsgDataString;
                else
                    ОписаниеОбъекта = new NsgDataString();
	//NsgDataString
	ОписаниеОбъекта.IsLoadedFromDll = true;
	ОписаниеОбъекта.Length = 0;
	ОписаниеОбъекта.StringFormat = "";
	ОписаниеОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОписаниеОбъекта.IncludeInPredefined = false;
	ОписаниеОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОписаниеОбъекта.Required = false;
	ОписаниеОбъекта.EmptyValue = "";
	ОписаниеОбъекта.NullAllow = false;
	ОписаниеОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОписаниеОбъекта.FieldName = "OpisanieObekta";
	ОписаниеОбъекта.SaveInDatabase = true;
	ОписаниеОбъекта.InformMetaDataOnValueChanged = false;
	ОписаниеОбъекта.Visible = true;
	ОписаниеОбъекта.Name = "ОписаниеОбъекта";
	ОписаниеОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОписаниеОбъекта.Description = "Описание объекта";
	ОписаниеОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОписаниеОбъекта.GroupName = "";
	ОписаниеОбъекта.Guid = NsgService.StringToGuid("e1b54a82-6ce8-4880-a98a-2d6b89b461ad");
	
				if (!ObjectList.Contains("ОписаниеОбъекта"))
                    ObjectList.Add(ОписаниеОбъекта);
			}
			#endregion //создание System.String ОписаниеОбъекта
			
			#region создание Справочники.ВидыРабот ТекущийВидРабот
			{  
                NsgDataTypedReference ТекущийВидРабот = null;
				if (ObjectList.Contains("ТекущийВидРабот"))
                    ТекущийВидРабот = ObjectList["ТекущийВидРабот"] as NsgDataTypedReference;
                else
                    ТекущийВидРабот = new NsgDataTypedReference();
	//NsgDataTypedReference
	ТекущийВидРабот.IsLoadedFromDll = true;
	ТекущийВидРабот.ReferentGroup = "Справочники";
	ТекущийВидРабот.ReferentName = "ВидыРабот";
	ТекущийВидРабот.SaveInDatabase = true;
	ТекущийВидРабот.OwnerName = "";
	ТекущийВидРабот.AllowEmptyOwner = false;
	ТекущийВидРабот.StringFormat = "";
	ТекущийВидРабот.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТекущийВидРабот.IncludeInPredefined = false;
	ТекущийВидРабот.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТекущийВидРабот.Required = false;
	ТекущийВидРабот.EmptyValue = "";
	ТекущийВидРабот.NullAllow = false;
	ТекущийВидРабот.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТекущийВидРабот.FieldName = "TekuschiijVidRabot";
	ТекущийВидРабот.InformMetaDataOnValueChanged = false;
	ТекущийВидРабот.Visible = true;
	ТекущийВидРабот.Name = "ТекущийВидРабот";
	ТекущийВидРабот.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТекущийВидРабот.Description = "Текущий вид работ";
	ТекущийВидРабот.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТекущийВидРабот.GroupName = "";
	ТекущийВидРабот.Guid = NsgService.StringToGuid("09427d9d-9726-4414-8dc8-5704d9482395");
	
				if (!ObjectList.Contains("ТекущийВидРабот"))
                    ObjectList.Add(ТекущийВидРабот);
			}
			#endregion //создание Справочники.ВидыРабот ТекущийВидРабот
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ДокументСменыТекущегоВидаРабот"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ЗаявкиНаРаботы";
	Visible = true;
	Guid = NsgService.StringToGuid("3185b88c-749d-48ca-bea3-de5cec1b1b2c");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_ZajavkiNaRaboty";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документ";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Документы";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDocument

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDocument.Names
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
            /// Номер документа
            /// </summary>
            public static String НомерДокумента
            {
                get
                {
                    return "НомерДокумента";
                }
            }
            
            /// <summary>
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
                }
            }
            
            /// <summary>
            /// Индекс
            /// </summary>
            public static String Индекс
            {
                get
                {
                    return "Индекс";
                }
            }
            
            /// <summary>
            /// Документ основание
            /// </summary>
            public static String ДокументОснование
            {
                get
                {
                    return "ДокументОснование";
                }
            }
            
            /// <summary>
            /// Комментарий
            /// </summary>
            public static String Комментарий
            {
                get
                {
                    return "Комментарий";
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
            /// Статус заявки
            /// </summary>
            public static String СтатусЗаявки
            {
                get
                {
                    return "СтатусЗаявки";
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
            /// Дата передачи объекта заказчиком
            /// </summary>
            public static String ДатаПередачиОбъектаЗаказчиком
            {
                get
                {
                    return "ДатаПередачиОбъектаЗаказчиком";
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
            /// Заказчик строка
            /// </summary>
            public static String ЗаказчикСтрока
            {
                get
                {
                    return "ЗаказчикСтрока";
                }
            }
            
            /// <summary>
            /// Номер заявки заказчика
            /// </summary>
            public static String НомерЗаявкиЗаказчика
            {
                get
                {
                    return "НомерЗаявкиЗаказчика";
                }
            }
            
            /// <summary>
            /// Дата окончания работ по объекту
            /// </summary>
            public static String ДатаОкончанияРаботПоОбъекту
            {
                get
                {
                    return "ДатаОкончанияРаботПоОбъекту";
                }
            }
            
            /// <summary>
            /// Таблица виды работ
            /// </summary>
            public static String ТаблицаВидыРабот
            {
                get
                {
                    return "ТаблицаВидыРабот";
                }
            }
            
            /// <summary>
            /// Описание объекта
            /// </summary>
            public static String ОписаниеОбъекта
            {
                get
                {
                    return "ОписаниеОбъекта";
                }
            }
            
            /// <summary>
            /// Текущий вид работ
            /// </summary>
            public static String ТекущийВидРабот
            {
                get
                {
                    return "ТекущийВидРабот";
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
                    descriptor.Name = "ЗаявкиНаРаботы";
                    descriptor.GroupName = "Документы";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Документы.ЗаявкиНаРаботы";
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
        /// Номер документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String НомерДокумента
        {
            get
            {
				 NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                 return (System.String)__НомерДокумента.Value;
            }
            set
            {
                NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                __НомерДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Индекс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataIndex")]
        
        public System.String Индекс
        {
            get
            {
				 NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                 return (System.String)__Индекс.Value;
            }
            set
            {
                NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                __Индекс.Value = value;
            }
        }
        
        /// <summary>
        /// Документ основание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("")]
        public NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
        {
            get
            {
				 NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ДокументОснование.Referent;
            }
            set
            {
                NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                __ДокументОснование.Referent = value;
            }
        }
        
        /// <summary>
        /// Комментарий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Комментарий
        {
            get
            {
				 NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                 return (System.String)__Комментарий.Value;
            }
            set
            {
                NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                __Комментарий.Value = value;
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
        /// Статус заявки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Перечисления.СтатусыЗаявок СтатусЗаявки
        {
            get
            {
				 NsgDataEnumReference __СтатусЗаявки = ObjectList["СтатусЗаявки"] as NsgDataEnumReference;
                 return (Перечисления.СтатусыЗаявок)__СтатусЗаявки.Referent;
            }
            set
            {
                NsgDataEnumReference __СтатусЗаявки = ObjectList["СтатусЗаявки"] as NsgDataEnumReference;
                __СтатусЗаявки.Referent = value;
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
        /// Дата передачи объекта заказчиком
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПередачиОбъектаЗаказчиком
        {
            get
            {
				 NsgDataDateTime __ДатаПередачиОбъектаЗаказчиком = ObjectList["ДатаПередачиОбъектаЗаказчиком"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПередачиОбъектаЗаказчиком.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПередачиОбъектаЗаказчиком = ObjectList["ДатаПередачиОбъектаЗаказчиком"] as NsgDataDateTime;
                __ДатаПередачиОбъектаЗаказчиком.Value = value;
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
        /// Заказчик строка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ЗаказчикСтрока
        {
            get
            {
				 NsgDataString __ЗаказчикСтрока = ObjectList["ЗаказчикСтрока"] as NsgDataString;
                 return (System.String)__ЗаказчикСтрока.Value;
            }
            set
            {
                NsgDataString __ЗаказчикСтрока = ObjectList["ЗаказчикСтрока"] as NsgDataString;
                __ЗаказчикСтрока.Value = value;
            }
        }
        
        /// <summary>
        /// Номер заявки заказчика
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String НомерЗаявкиЗаказчика
        {
            get
            {
				 NsgDataString __НомерЗаявкиЗаказчика = ObjectList["НомерЗаявкиЗаказчика"] as NsgDataString;
                 return (System.String)__НомерЗаявкиЗаказчика.Value;
            }
            set
            {
                NsgDataString __НомерЗаявкиЗаказчика = ObjectList["НомерЗаявкиЗаказчика"] as NsgDataString;
                __НомерЗаявкиЗаказчика.Value = value;
            }
        }
        
        /// <summary>
        /// Дата окончания работ по объекту
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияРаботПоОбъекту
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияРаботПоОбъекту = ObjectList["ДатаОкончанияРаботПоОбъекту"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияРаботПоОбъекту.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияРаботПоОбъекту = ObjectList["ДатаОкончанияРаботПоОбъекту"] as NsgDataDateTime;
                __ДатаОкончанияРаботПоОбъекту.Value = value;
            }
        }
        
        /// <summary>
        /// Таблица виды работ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот ТаблицаВидыРабот
        {
            get
            {
				 NsgDataTableReference __ТаблицаВидыРабот = ObjectList["ТаблицаВидыРабот"] as NsgDataTableReference;
                 return (_SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот)__ТаблицаВидыРабот.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаВидыРабот = ObjectList["ТаблицаВидыРабот"] as NsgDataTableReference;
                __ТаблицаВидыРабот.Referent = value;
            }
        }
        
        /// <summary>
        /// Описание объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ОписаниеОбъекта
        {
            get
            {
				 NsgDataString __ОписаниеОбъекта = ObjectList["ОписаниеОбъекта"] as NsgDataString;
                 return (System.String)__ОписаниеОбъекта.Value;
            }
            set
            {
                NsgDataString __ОписаниеОбъекта = ObjectList["ОписаниеОбъекта"] as NsgDataString;
                __ОписаниеОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Текущий вид работ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Справочники.ВидыРабот ТекущийВидРабот
        {
            get
            {
				 NsgDataTypedReference __ТекущийВидРабот = ObjectList["ТекущийВидРабот"] as NsgDataTypedReference;
                 return (Справочники.ВидыРабот)__ТекущийВидРабот.Referent;
            }
            set
            {
                NsgDataTypedReference __ТекущийВидРабот = ObjectList["ТекущийВидРабот"] as NsgDataTypedReference;
                __ТекущийВидРабот.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDocument
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDocument

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDocument

        #region Методы NsgMultipleObject
        private ЗаявкиНаРаботы[] convertArray(NsgMultipleObject[] array)
        {
            ЗаявкиНаРаботы[] res = new ЗаявкиНаРаботы[array.Length];
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
        public new virtual ЗаявкиНаРаботы[] FindAll(NsgCompare compare)
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
        public new virtual ЗаявкиНаРаботы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ЗаявкиНаРаботы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ЗаявкиНаРаботы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ЗаявкиНаРаботы(this as NsgObject);
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
                base.NSGType = typeof(ЗаявкиНаРаботы);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ЗаявкиНаРаботы Value
            {
                get
                {
                    return (ЗаявкиНаРаботы)base.Value;
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
                    return "s_NsgDataDocument";
                }
            }
        }

    }

}
