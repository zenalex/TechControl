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
    
    [NsgTypeName("NsgDataDocument", Guid = "ab8fc786-6aa4-4cb8-980b-11659254bf2f")]
    public partial class Перемещение : NsgSoft.DataObjects.NsgDataDocument
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
        protected Перемещение()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Перемещение(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Перемещение Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("ab8fc786-6aa4-4cb8-980b-11659254bf2f"));
            if (obj == null)
                obj = new Перемещение();
            return obj as Перемещение;
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
	Идентификатор.Guid = NsgService.StringToGuid("f6945130-2fb1-4b0b-9f6c-9b544c77eb86");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("841de0df-531b-46e1-b008-ef6974bf2c3a");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("cda9d1dd-55b8-4ff6-9064-326316db3112");
	
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
	НомерКода.Guid = NsgService.StringToGuid("bcb578b4-b102-425c-92cd-e7b03f81226a");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("bbd069f0-eec1-45c8-b7c7-da0468936267");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("22cca7e2-4651-4215-970a-f5cdc88a424b");
	
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
	Индекс.Guid = NsgService.StringToGuid("7b1e11d0-a6b3-4800-83fa-b965b57b54e0");
	
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
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.None;
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
	ДокументОснование.Guid = NsgService.StringToGuid("deaa0f89-4d19-4163-b364-2ec3d3720db7");
	
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
	Комментарий.Guid = NsgService.StringToGuid("fd5b8c7a-b0b3-4f79-9c2b-ee3fc01e9a2f");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("07bf94a1-76e8-4b73-9909-16509b09fc10");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Мониторинг.Сотрудники Сотрудник
			{  
                NsgDataTypedReference Сотрудник = null;
				if (ObjectList.Contains("Сотрудник"))
                    Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                else
                    Сотрудник = new NsgDataTypedReference();
	//NsgDataTypedReference
	Сотрудник.IsLoadedFromDll = true;
	Сотрудник.ReferentGroup = "Мониторинг";
	Сотрудник.ReferentName = "Сотрудники";
	Сотрудник.SaveInDatabase = true;
	Сотрудник.OwnerName = "";
	Сотрудник.AllowEmptyOwner = false;
	Сотрудник.StringFormat = "";
	Сотрудник.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сотрудник.IncludeInPredefined = false;
	Сотрудник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудник.Required = false;
	Сотрудник.EmptyValue = "";
	Сотрудник.NullAllow = false;
	Сотрудник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сотрудник.FieldName = "Sotrudnik";
	Сотрудник.InformMetaDataOnValueChanged = false;
	Сотрудник.Visible = true;
	Сотрудник.Name = "Сотрудник";
	Сотрудник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудник.Description = "Сотрудник";
	Сотрудник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудник.GroupName = "";
	Сотрудник.Guid = NsgService.StringToGuid("d90e800b-91ec-46a6-93a8-4acd0df750a2");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудник
			
			#region создание _SystemTables.УчетПеремещениеТаблица Таблица
			{  
                NsgDataTableReference Таблица = null;
				if (ObjectList.Contains("Таблица"))
                    Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                else
                    Таблица = new NsgDataTableReference();
	//NsgDataTableReference
	Таблица.IsLoadedFromDll = true;
	Таблица.Name = "Таблица";
	Таблица.SaveInDatabase = false;
	Таблица.ReferentGroup = "_SystemTables";
	Таблица.ReferentName = "УчетПеремещениеТаблица";
	Таблица.OwnerName = "";
	Таблица.AllowEmptyOwner = false;
	Таблица.StringFormat = "";
	Таблица.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	Таблица.IncludeInPredefined = false;
	Таблица.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Таблица.Required = false;
	Таблица.EmptyValue = "";
	Таблица.NullAllow = false;
	Таблица.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Таблица.FieldName = "Tablica";
	Таблица.InformMetaDataOnValueChanged = false;
	Таблица.Visible = true;
	Таблица.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Таблица.Description = "Таблица";
	Таблица.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Таблица.GroupName = "";
	Таблица.Guid = NsgService.StringToGuid("924aabe3-d556-4c2d-af19-01d2390942f7");
	
				if (!ObjectList.Contains("Таблица"))
                    ObjectList.Add(Таблица);
			}
			#endregion //создание _SystemTables.УчетПеремещениеТаблица Таблица
			
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
	Объект.Guid = NsgService.StringToGuid("4c37b4cb-4acd-461d-9f33-1866a9f582aa");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Мониторинг.ФормированиеСмены", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СпециальнаяОдежда.ПеремещениеСпецодежды", "СпециальнаяОдежда.ЗаказСпецодежды", "Инструменты.ПеремещениеИнструментов", "Мониторинг.ФормированиеСменыДень", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.ПриходнаяНакладная", "Учет.Перемещение"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "СпециальнаяОдежда.УчетСпецодежды", "Мониторинг.ФиксацияИсторииСотрудников", "Инструменты.УчетИнструментов", "Учет.ОстаткиНоменклатуры"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Перемещение";
	Visible = true;
	Guid = NsgService.StringToGuid("ab8fc786-6aa4-4cb8-980b-11659254bf2f");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_Peremeschenie";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перемещение";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Учет";
	
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
            /// Сотрудник
            /// </summary>
            public static String Сотрудник
            {
                get
                {
                    return "Сотрудник";
                }
            }
            
            /// <summary>
            /// Таблица
            /// </summary>
            public static String Таблица
            {
                get
                {
                    return "Таблица";
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
                    descriptor.Name = "Перемещение";
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
            return "Учет.Перемещение";
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
        /// Сотрудник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Сотрудники Сотрудник
        {
            get
            {
				 NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                 return (Мониторинг.Сотрудники)__Сотрудник.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                __Сотрудник.Referent = value;
            }
        }
        
        /// <summary>
        /// Таблица
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.УчетПеремещениеТаблица Таблица
        {
            get
            {
				 NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                 return (_SystemTables.УчетПеремещениеТаблица)__Таблица.Referent;
            }
            set
            {
                NsgDataTableReference __Таблица = ObjectList["Таблица"] as NsgDataTableReference;
                __Таблица.Referent = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDocument
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDocument

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDocument

        #region Методы NsgMultipleObject
        private Перемещение[] convertArray(NsgMultipleObject[] array)
        {
            Перемещение[] res = new Перемещение[array.Length];
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
        public new virtual Перемещение[] FindAll(NsgCompare compare)
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
        public new virtual Перемещение[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Перемещение[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Перемещение[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Перемещение(this as NsgObject);
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
                base.NSGType = typeof(Перемещение);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Перемещение Value
            {
                get
                {
                    return (Перемещение)base.Value;
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
