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
    
    [NsgTypeName("NsgDataDocument", Guid = "f316f894-ac6d-4180-a789-b7af7194acf7")]
    public partial class ФормированиеСменыДень : NsgSoft.DataObjects.NsgDataDocument
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
        protected ФормированиеСменыДень()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ФормированиеСменыДень(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ФормированиеСменыДень Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f316f894-ac6d-4180-a789-b7af7194acf7"));
            if (obj == null)
                obj = new ФормированиеСменыДень();
            return obj as ФормированиеСменыДень;
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
	Идентификатор.Guid = NsgService.StringToGuid("a7d0e42c-b3a9-4447-9e47-632693b296e2");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("d1d8d3ee-c40f-4ea0-b59e-dd07ed225e78");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("1d54f7dc-35bb-4412-b3ec-8151cda368a9");
	
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
	НомерКода.Guid = NsgService.StringToGuid("97258d2c-3ef1-4961-8e7e-d1408340fa74");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("d7101248-8f1b-4f25-8a3c-275a94049313");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("9694713d-846d-4729-b123-cdd93ab326a8");
	
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
	Индекс.Guid = NsgService.StringToGuid("b8198e13-8562-4b8b-8c08-e817a68d720c");
	
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
	ДокументОснование.FilterForConfigurator = "Мониторинг.ФормированиеСмены";
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
	ДокументОснование.Guid = NsgService.StringToGuid("3bf16e5e-67a9-41f7-bb7a-3894fd026c9d");
	
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
	Комментарий.Guid = NsgService.StringToGuid("b51d5cca-3657-4df6-b88c-1950fb3cbdae");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("0d1918d6-1ebd-4d66-9d97-1f7c518a3532");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание _SystemTables.МониторингФормированиеСменыДеньТаблицаТехника ТаблицаТехника
			{  
                NsgDataTableReference ТаблицаТехника = null;
				if (ObjectList.Contains("ТаблицаТехника"))
                    ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                else
                    ТаблицаТехника = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаТехника.IsLoadedFromDll = true;
	ТаблицаТехника.Name = "ТаблицаТехника";
	ТаблицаТехника.SaveInDatabase = false;
	ТаблицаТехника.ReferentGroup = "_SystemTables";
	ТаблицаТехника.ReferentName = "МониторингФормированиеСменыДеньТаблицаТехника";
	ТаблицаТехника.OwnerName = "";
	ТаблицаТехника.AllowEmptyOwner = false;
	ТаблицаТехника.StringFormat = "";
	ТаблицаТехника.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаТехника.IncludeInPredefined = false;
	ТаблицаТехника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаТехника.Required = false;
	ТаблицаТехника.EmptyValue = "";
	ТаблицаТехника.NullAllow = false;
	ТаблицаТехника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаТехника.FieldName = "TablicaTekhnika";
	ТаблицаТехника.InformMetaDataOnValueChanged = false;
	ТаблицаТехника.Visible = true;
	ТаблицаТехника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаТехника.Description = "Таблица техника";
	ТаблицаТехника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаТехника.GroupName = "";
	ТаблицаТехника.Guid = NsgService.StringToGuid("1bea220e-5e72-4149-8584-8f143ea76f39");
	
				if (!ObjectList.Contains("ТаблицаТехника"))
                    ObjectList.Add(ТаблицаТехника);
			}
			#endregion //создание _SystemTables.МониторингФормированиеСменыДеньТаблицаТехника ТаблицаТехника
			
			#region создание System.Int64 ВсегоТехникиВРаботе
			{  
                NsgDataInteger ВсегоТехникиВРаботе = null;
				if (ObjectList.Contains("ВсегоТехникиВРаботе"))
                    ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                else
                    ВсегоТехникиВРаботе = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиВРаботе.IsLoadedFromDll = true;
	ВсегоТехникиВРаботе.DefaultValue = 0M;
	ВсегоТехникиВРаботе.MinValue = 0M;
	ВсегоТехникиВРаботе.MaxValue = 0M;
	ВсегоТехникиВРаботе.UseCalculator = true;
	ВсегоТехникиВРаботе.StringFormat = "";
	ВсегоТехникиВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиВРаботе.IncludeInPredefined = false;
	ВсегоТехникиВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиВРаботе.Required = false;
	ВсегоТехникиВРаботе.EmptyValue = "";
	ВсегоТехникиВРаботе.NullAllow = false;
	ВсегоТехникиВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиВРаботе.FieldName = "VsegoTekhnikiVRabote";
	ВсегоТехникиВРаботе.SaveInDatabase = true;
	ВсегоТехникиВРаботе.InformMetaDataOnValueChanged = false;
	ВсегоТехникиВРаботе.Visible = true;
	ВсегоТехникиВРаботе.Name = "ВсегоТехникиВРаботе";
	ВсегоТехникиВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиВРаботе.Description = "Всего техники ВРаботе";
	ВсегоТехникиВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиВРаботе.GroupName = "";
	ВсегоТехникиВРаботе.Guid = NsgService.StringToGuid("e1c3b1fd-906f-42b5-8c17-a5c408c9a11b");
	
				if (!ObjectList.Contains("ВсегоТехникиВРаботе"))
                    ObjectList.Add(ВсегоТехникиВРаботе);
			}
			#endregion //создание System.Int64 ВсегоТехникиВРаботе
			
			#region создание System.Int64 ВсегоТехникиВРемонте
			{  
                NsgDataInteger ВсегоТехникиВРемонте = null;
				if (ObjectList.Contains("ВсегоТехникиВРемонте"))
                    ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                else
                    ВсегоТехникиВРемонте = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиВРемонте.IsLoadedFromDll = true;
	ВсегоТехникиВРемонте.DefaultValue = 0M;
	ВсегоТехникиВРемонте.MinValue = 0M;
	ВсегоТехникиВРемонте.MaxValue = 0M;
	ВсегоТехникиВРемонте.UseCalculator = true;
	ВсегоТехникиВРемонте.StringFormat = "";
	ВсегоТехникиВРемонте.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиВРемонте.IncludeInPredefined = false;
	ВсегоТехникиВРемонте.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиВРемонте.Required = false;
	ВсегоТехникиВРемонте.EmptyValue = "";
	ВсегоТехникиВРемонте.NullAllow = false;
	ВсегоТехникиВРемонте.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиВРемонте.FieldName = "VsegoTekhnikiVRem";
	ВсегоТехникиВРемонте.SaveInDatabase = true;
	ВсегоТехникиВРемонте.InformMetaDataOnValueChanged = false;
	ВсегоТехникиВРемонте.Visible = true;
	ВсегоТехникиВРемонте.Name = "ВсегоТехникиВРемонте";
	ВсегоТехникиВРемонте.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиВРемонте.Description = "Всего техники ВРемонте";
	ВсегоТехникиВРемонте.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиВРемонте.GroupName = "";
	ВсегоТехникиВРемонте.Guid = NsgService.StringToGuid("67a5f086-94f6-497d-8b85-45bd94a62b72");
	
				if (!ObjectList.Contains("ВсегоТехникиВРемонте"))
                    ObjectList.Add(ВсегоТехникиВРемонте);
			}
			#endregion //создание System.Int64 ВсегоТехникиВРемонте
			
			#region создание System.Int64 ВсегоТехникиНеВРаботе
			{  
                NsgDataInteger ВсегоТехникиНеВРаботе = null;
				if (ObjectList.Contains("ВсегоТехникиНеВРаботе"))
                    ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                else
                    ВсегоТехникиНеВРаботе = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиНеВРаботе.IsLoadedFromDll = true;
	ВсегоТехникиНеВРаботе.DefaultValue = 0M;
	ВсегоТехникиНеВРаботе.MinValue = 0M;
	ВсегоТехникиНеВРаботе.MaxValue = 0M;
	ВсегоТехникиНеВРаботе.UseCalculator = true;
	ВсегоТехникиНеВРаботе.StringFormat = "";
	ВсегоТехникиНеВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиНеВРаботе.IncludeInPredefined = false;
	ВсегоТехникиНеВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиНеВРаботе.Required = false;
	ВсегоТехникиНеВРаботе.EmptyValue = "";
	ВсегоТехникиНеВРаботе.NullAllow = false;
	ВсегоТехникиНеВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиНеВРаботе.FieldName = "VsegoTekhnikiNeVR";
	ВсегоТехникиНеВРаботе.SaveInDatabase = true;
	ВсегоТехникиНеВРаботе.InformMetaDataOnValueChanged = false;
	ВсегоТехникиНеВРаботе.Visible = true;
	ВсегоТехникиНеВРаботе.Name = "ВсегоТехникиНеВРаботе";
	ВсегоТехникиНеВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиНеВРаботе.Description = "Всего техники не ВРаботе";
	ВсегоТехникиНеВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиНеВРаботе.GroupName = "";
	ВсегоТехникиНеВРаботе.Guid = NsgService.StringToGuid("70278ea7-c3db-4cc7-933e-97e24824d7e0");
	
				if (!ObjectList.Contains("ВсегоТехникиНеВРаботе"))
                    ObjectList.Add(ВсегоТехникиНеВРаботе);
			}
			#endregion //создание System.Int64 ВсегоТехникиНеВРаботе
			
			#region создание System.Int64 ВсегоТехникиСломано
			{  
                NsgDataInteger ВсегоТехникиСломано = null;
				if (ObjectList.Contains("ВсегоТехникиСломано"))
                    ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                else
                    ВсегоТехникиСломано = new NsgDataInteger();
	//NsgDataInteger
	ВсегоТехникиСломано.IsLoadedFromDll = true;
	ВсегоТехникиСломано.DefaultValue = 0M;
	ВсегоТехникиСломано.MinValue = 0M;
	ВсегоТехникиСломано.MaxValue = 0M;
	ВсегоТехникиСломано.UseCalculator = true;
	ВсегоТехникиСломано.StringFormat = "";
	ВсегоТехникиСломано.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВсегоТехникиСломано.IncludeInPredefined = false;
	ВсегоТехникиСломано.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВсегоТехникиСломано.Required = false;
	ВсегоТехникиСломано.EmptyValue = "";
	ВсегоТехникиСломано.NullAllow = false;
	ВсегоТехникиСломано.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВсегоТехникиСломано.FieldName = "VsegoTekhnikiSlomano";
	ВсегоТехникиСломано.SaveInDatabase = true;
	ВсегоТехникиСломано.InformMetaDataOnValueChanged = false;
	ВсегоТехникиСломано.Visible = true;
	ВсегоТехникиСломано.Name = "ВсегоТехникиСломано";
	ВсегоТехникиСломано.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВсегоТехникиСломано.Description = "Всего техники сломано";
	ВсегоТехникиСломано.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВсегоТехникиСломано.GroupName = "";
	ВсегоТехникиСломано.Guid = NsgService.StringToGuid("a9b0fe8c-f050-4ec0-b0de-1649fd53ec11");
	
				if (!ObjectList.Contains("ВсегоТехникиСломано"))
                    ObjectList.Add(ВсегоТехникиСломано);
			}
			#endregion //создание System.Int64 ВсегоТехникиСломано
			
			#region создание System.Int64 КоличествоТехники
			{  
                NsgDataInteger КоличествоТехники = null;
				if (ObjectList.Contains("КоличествоТехники"))
                    КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                else
                    КоличествоТехники = new NsgDataInteger();
	//NsgDataInteger
	КоличествоТехники.IsLoadedFromDll = true;
	КоличествоТехники.DefaultValue = 0M;
	КоличествоТехники.MinValue = 0M;
	КоличествоТехники.MaxValue = 0M;
	КоличествоТехники.UseCalculator = true;
	КоличествоТехники.StringFormat = "";
	КоличествоТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КоличествоТехники.IncludeInPredefined = false;
	КоличествоТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоТехники.Required = false;
	КоличествоТехники.EmptyValue = "";
	КоличествоТехники.NullAllow = false;
	КоличествоТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоТехники.FieldName = "KolichestvoTekhniki";
	КоличествоТехники.SaveInDatabase = true;
	КоличествоТехники.InformMetaDataOnValueChanged = false;
	КоличествоТехники.Visible = true;
	КоличествоТехники.Name = "КоличествоТехники";
	КоличествоТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоТехники.Description = "Количество техники";
	КоличествоТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоТехники.GroupName = "";
	КоличествоТехники.Guid = NsgService.StringToGuid("ba6a7cbe-3957-4df2-8e6d-96a40f9af23a");
	
				if (!ObjectList.Contains("КоличествоТехники"))
                    ObjectList.Add(КоличествоТехники);
			}
			#endregion //создание System.Int64 КоличествоТехники
			
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
	Объект.Guid = NsgService.StringToGuid("ab214c23-a1ae-4e45-9684-e2b09279a9ee");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	Ответственный.Guid = NsgService.StringToGuid("d0ab72e7-4d2b-4af1-8463-909678e35384");
	
				if (!ObjectList.Contains("Ответственный"))
                    ObjectList.Add(Ответственный);
			}
			#endregion //создание Мониторинг.ФизЛица Ответственный
			
			#region создание _SystemTables.МониторингФормированиеСменыДеньТаблицаПерсонал ТаблицаПерсонал
			{  
                NsgDataTableReference ТаблицаПерсонал = null;
				if (ObjectList.Contains("ТаблицаПерсонал"))
                    ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                else
                    ТаблицаПерсонал = new NsgDataTableReference();
	//NsgDataTableReference
	ТаблицаПерсонал.IsLoadedFromDll = true;
	ТаблицаПерсонал.Name = "ТаблицаПерсонал";
	ТаблицаПерсонал.SaveInDatabase = false;
	ТаблицаПерсонал.ReferentGroup = "_SystemTables";
	ТаблицаПерсонал.ReferentName = "МониторингФормированиеСменыДеньТаблицаПерсонал";
	ТаблицаПерсонал.OwnerName = "";
	ТаблицаПерсонал.AllowEmptyOwner = false;
	ТаблицаПерсонал.StringFormat = "";
	ТаблицаПерсонал.SubType = NsgSoft.Common.NsgRekvisitSubType.Tables;
	ТаблицаПерсонал.IncludeInPredefined = false;
	ТаблицаПерсонал.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТаблицаПерсонал.Required = false;
	ТаблицаПерсонал.EmptyValue = "";
	ТаблицаПерсонал.NullAllow = false;
	ТаблицаПерсонал.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТаблицаПерсонал.FieldName = "TablicaPersonal";
	ТаблицаПерсонал.InformMetaDataOnValueChanged = false;
	ТаблицаПерсонал.Visible = true;
	ТаблицаПерсонал.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТаблицаПерсонал.Description = "Таблица персонал";
	ТаблицаПерсонал.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТаблицаПерсонал.GroupName = "";
	ТаблицаПерсонал.Guid = NsgService.StringToGuid("f2e4d0b7-b918-4271-ac37-0f7eb1630a9b");
	
				if (!ObjectList.Contains("ТаблицаПерсонал"))
                    ObjectList.Add(ТаблицаПерсонал);
			}
			#endregion //создание _SystemTables.МониторингФормированиеСменыДеньТаблицаПерсонал ТаблицаПерсонал
			
			#region создание TechControl.Метаданные.Мониторинг.ФормированиеСменыДеньФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.ФормированиеСменыДеньФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("c351f8fe-a5ef-44cc-a433-24752a6358a4");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.ФормированиеСменыДеньФормаЭлемента ФормаЭлемента
			
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
	АккаунтПользователя.Guid = NsgService.StringToGuid("6fd11aa2-4276-447d-97a0-5b8c0353f01c");
	
				if (!ObjectList.Contains("АккаунтПользователя"))
                    ObjectList.Add(АккаунтПользователя);
			}
			#endregion //создание СлужебныеСправочники.АккаунтПользователя АккаунтПользователя
			
			#region создание System.DateTime ДатаПоследнгегоИзменения
			{  
                NsgDataDateTime ДатаПоследнгегоИзменения = null;
				if (ObjectList.Contains("ДатаПоследнгегоИзменения"))
                    ДатаПоследнгегоИзменения = ObjectList["ДатаПоследнгегоИзменения"] as NsgDataDateTime;
                else
                    ДатаПоследнгегоИзменения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПоследнгегоИзменения.IsLoadedFromDll = true;
	ДатаПоследнгегоИзменения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПоследнгегоИзменения.StringFormat = "";
	ДатаПоследнгегоИзменения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаПоследнгегоИзменения.IncludeInPredefined = false;
	ДатаПоследнгегоИзменения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПоследнгегоИзменения.Required = false;
	ДатаПоследнгегоИзменения.EmptyValue = "";
	ДатаПоследнгегоИзменения.NullAllow = false;
	ДатаПоследнгегоИзменения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПоследнгегоИзменения.FieldName = "DataPosledngegoIz";
	ДатаПоследнгегоИзменения.SaveInDatabase = true;
	ДатаПоследнгегоИзменения.InformMetaDataOnValueChanged = false;
	ДатаПоследнгегоИзменения.Visible = true;
	ДатаПоследнгегоИзменения.Name = "ДатаПоследнгегоИзменения";
	ДатаПоследнгегоИзменения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПоследнгегоИзменения.Description = "Дата последнгего изменения";
	ДатаПоследнгегоИзменения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПоследнгегоИзменения.GroupName = "";
	ДатаПоследнгегоИзменения.Guid = NsgService.StringToGuid("5da966a4-2a58-4f0e-aef5-1e6f030fdd5e");
	
				if (!ObjectList.Contains("ДатаПоследнгегоИзменения"))
                    ObjectList.Add(ДатаПоследнгегоИзменения);
			}
			#endregion //создание System.DateTime ДатаПоследнгегоИзменения
			
			#region создание System.Boolean ЗавершаетСмену
			{  
                NsgDataBoolean ЗавершаетСмену = null;
				if (ObjectList.Contains("ЗавершаетСмену"))
                    ЗавершаетСмену = ObjectList["ЗавершаетСмену"] as NsgDataBoolean;
                else
                    ЗавершаетСмену = new NsgDataBoolean();
	//NsgDataBoolean
	ЗавершаетСмену.IsLoadedFromDll = true;
	ЗавершаетСмену.DefaultValue = false;
	ЗавершаетСмену.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗавершаетСмену.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗавершаетСмену.StringFormat = "";
	ЗавершаетСмену.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЗавершаетСмену.IncludeInPredefined = false;
	ЗавершаетСмену.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЗавершаетСмену.Required = false;
	ЗавершаетСмену.EmptyValue = "";
	ЗавершаетСмену.NullAllow = false;
	ЗавершаетСмену.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЗавершаетСмену.FieldName = "ZavershaetSmenu";
	ЗавершаетСмену.SaveInDatabase = true;
	ЗавершаетСмену.InformMetaDataOnValueChanged = false;
	ЗавершаетСмену.Visible = true;
	ЗавершаетСмену.Name = "ЗавершаетСмену";
	ЗавершаетСмену.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗавершаетСмену.Description = "Завершает смену";
	ЗавершаетСмену.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЗавершаетСмену.GroupName = "";
	ЗавершаетСмену.Guid = NsgService.StringToGuid("87ecf06f-f635-4c74-ada1-5ac0f87520e9");
	
				if (!ObjectList.Contains("ЗавершаетСмену"))
                    ObjectList.Add(ЗавершаетСмену);
			}
			#endregion //создание System.Boolean ЗавершаетСмену
			
			#region создание System.Decimal Широта
			{  
                NsgDataFloat Широта = null;
				if (ObjectList.Contains("Широта"))
                    Широта = ObjectList["Широта"] as NsgDataFloat;
                else
                    Широта = new NsgDataFloat();
	//NsgDataFloat
	Широта.IsLoadedFromDll = true;
	Широта.Precision = 2;
	Широта.HideZero = true;
	Широта.DefaultValue = 0M;
	Широта.MinValue = -100000000000000000M;
	Широта.MaxValue = 100000000000000000M;
	Широта.UseCalculator = true;
	Широта.StringFormat = "";
	Широта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Широта.Guid = NsgService.StringToGuid("7b57db3d-26d7-44df-80e0-cb536685a37d");
	
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
	Долгота.Precision = 2;
	Долгота.HideZero = true;
	Долгота.DefaultValue = 0M;
	Долгота.MinValue = -100000000000000000M;
	Долгота.MaxValue = 100000000000000000M;
	Долгота.UseCalculator = true;
	Долгота.StringFormat = "";
	Долгота.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Долгота.Guid = NsgService.StringToGuid("18d6dd45-2fe6-4904-9fe6-2b4bcb6d40b7");
	
				if (!ObjectList.Contains("Долгота"))
                    ObjectList.Add(Долгота);
			}
			#endregion //создание System.Decimal Долгота
			
			#region создание System.Decimal Возвышение
			{  
                NsgDataFloat Возвышение = null;
				if (ObjectList.Contains("Возвышение"))
                    Возвышение = ObjectList["Возвышение"] as NsgDataFloat;
                else
                    Возвышение = new NsgDataFloat();
	//NsgDataFloat
	Возвышение.IsLoadedFromDll = true;
	Возвышение.Precision = 2;
	Возвышение.HideZero = true;
	Возвышение.DefaultValue = 0M;
	Возвышение.MinValue = -100000000000000000M;
	Возвышение.MaxValue = 100000000000000000M;
	Возвышение.UseCalculator = true;
	Возвышение.StringFormat = "";
	Возвышение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Возвышение.IncludeInPredefined = false;
	Возвышение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Возвышение.Required = false;
	Возвышение.EmptyValue = "";
	Возвышение.NullAllow = false;
	Возвышение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Возвышение.FieldName = "Vozvyshenie";
	Возвышение.SaveInDatabase = true;
	Возвышение.InformMetaDataOnValueChanged = false;
	Возвышение.Visible = true;
	Возвышение.Name = "Возвышение";
	Возвышение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Возвышение.Description = "Возвышение";
	Возвышение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Возвышение.GroupName = "";
	Возвышение.Guid = NsgService.StringToGuid("880e673d-49da-45b5-aa81-a00a2c36a57d");
	
				if (!ObjectList.Contains("Возвышение"))
                    ObjectList.Add(Возвышение);
			}
			#endregion //создание System.Decimal Возвышение
			
			#region создание System.Decimal ТочностьВозвышения
			{  
                NsgDataFloat ТочностьВозвышения = null;
				if (ObjectList.Contains("ТочностьВозвышения"))
                    ТочностьВозвышения = ObjectList["ТочностьВозвышения"] as NsgDataFloat;
                else
                    ТочностьВозвышения = new NsgDataFloat();
	//NsgDataFloat
	ТочностьВозвышения.IsLoadedFromDll = true;
	ТочностьВозвышения.Precision = 2;
	ТочностьВозвышения.HideZero = true;
	ТочностьВозвышения.DefaultValue = 0M;
	ТочностьВозвышения.MinValue = -100000000000000000M;
	ТочностьВозвышения.MaxValue = 100000000000000000M;
	ТочностьВозвышения.UseCalculator = true;
	ТочностьВозвышения.StringFormat = "";
	ТочностьВозвышения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТочностьВозвышения.IncludeInPredefined = false;
	ТочностьВозвышения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТочностьВозвышения.Required = false;
	ТочностьВозвышения.EmptyValue = "";
	ТочностьВозвышения.NullAllow = false;
	ТочностьВозвышения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТочностьВозвышения.FieldName = "TochnostVozvyshenija";
	ТочностьВозвышения.SaveInDatabase = true;
	ТочностьВозвышения.InformMetaDataOnValueChanged = false;
	ТочностьВозвышения.Visible = true;
	ТочностьВозвышения.Name = "ТочностьВозвышения";
	ТочностьВозвышения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТочностьВозвышения.Description = "Точность возвышения";
	ТочностьВозвышения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТочностьВозвышения.GroupName = "";
	ТочностьВозвышения.Guid = NsgService.StringToGuid("aa9def56-8f66-434d-853b-c7dd02a1755c");
	
				if (!ObjectList.Contains("ТочностьВозвышения"))
                    ObjectList.Add(ТочностьВозвышения);
			}
			#endregion //создание System.Decimal ТочностьВозвышения
			
			#region создание System.Decimal ТочностьКоординатGPS
			{  
                NsgDataFloat ТочностьКоординатGPS = null;
				if (ObjectList.Contains("ТочностьКоординатGPS"))
                    ТочностьКоординатGPS = ObjectList["ТочностьКоординатGPS"] as NsgDataFloat;
                else
                    ТочностьКоординатGPS = new NsgDataFloat();
	//NsgDataFloat
	ТочностьКоординатGPS.IsLoadedFromDll = true;
	ТочностьКоординатGPS.Precision = 2;
	ТочностьКоординатGPS.HideZero = true;
	ТочностьКоординатGPS.DefaultValue = 0M;
	ТочностьКоординатGPS.MinValue = -100000000000000000M;
	ТочностьКоординатGPS.MaxValue = 100000000000000000M;
	ТочностьКоординатGPS.UseCalculator = true;
	ТочностьКоординатGPS.StringFormat = "";
	ТочностьКоординатGPS.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТочностьКоординатGPS.IncludeInPredefined = false;
	ТочностьКоординатGPS.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТочностьКоординатGPS.Required = false;
	ТочностьКоординатGPS.EmptyValue = "";
	ТочностьКоординатGPS.NullAllow = false;
	ТочностьКоординатGPS.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТочностьКоординатGPS.FieldName = "TochnostKoordinatGPS";
	ТочностьКоординатGPS.SaveInDatabase = true;
	ТочностьКоординатGPS.InformMetaDataOnValueChanged = false;
	ТочностьКоординатGPS.Visible = true;
	ТочностьКоординатGPS.Name = "ТочностьКоординатGPS";
	ТочностьКоординатGPS.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТочностьКоординатGPS.Description = "Точность координат GPS";
	ТочностьКоординатGPS.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТочностьКоординатGPS.GroupName = "";
	ТочностьКоординатGPS.Guid = NsgService.StringToGuid("c585589b-7d9f-4c9d-978f-895e29b15e55");
	
				if (!ObjectList.Contains("ТочностьКоординатGPS"))
                    ObjectList.Add(ТочностьКоординатGPS);
			}
			#endregion //создание System.Decimal ТочностьКоординатGPS
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ЗаявкиНаТехнику"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ФормированиеСменыДень";
	Visible = true;
	Guid = NsgService.StringToGuid("f316f894-ac6d-4180-a789-b7af7194acf7");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_FormirovanieSmenyDen";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Формирование смены (день)";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	
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
            /// Таблица техника
            /// </summary>
            public static String ТаблицаТехника
            {
                get
                {
                    return "ТаблицаТехника";
                }
            }
            
            /// <summary>
            /// Всего техники ВРаботе
            /// </summary>
            public static String ВсегоТехникиВРаботе
            {
                get
                {
                    return "ВсегоТехникиВРаботе";
                }
            }
            
            /// <summary>
            /// Всего техники ВРемонте
            /// </summary>
            public static String ВсегоТехникиВРемонте
            {
                get
                {
                    return "ВсегоТехникиВРемонте";
                }
            }
            
            /// <summary>
            /// Всего техники не ВРаботе
            /// </summary>
            public static String ВсегоТехникиНеВРаботе
            {
                get
                {
                    return "ВсегоТехникиНеВРаботе";
                }
            }
            
            /// <summary>
            /// Всего техники сломано
            /// </summary>
            public static String ВсегоТехникиСломано
            {
                get
                {
                    return "ВсегоТехникиСломано";
                }
            }
            
            /// <summary>
            /// Количество техники
            /// </summary>
            public static String КоличествоТехники
            {
                get
                {
                    return "КоличествоТехники";
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
            /// Таблица персонал
            /// </summary>
            public static String ТаблицаПерсонал
            {
                get
                {
                    return "ТаблицаПерсонал";
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
            /// Дата последнгего изменения
            /// </summary>
            public static String ДатаПоследнгегоИзменения
            {
                get
                {
                    return "ДатаПоследнгегоИзменения";
                }
            }
            
            /// <summary>
            /// Завершает смену
            /// </summary>
            public static String ЗавершаетСмену
            {
                get
                {
                    return "ЗавершаетСмену";
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
            /// Возвышение
            /// </summary>
            public static String Возвышение
            {
                get
                {
                    return "Возвышение";
                }
            }
            
            /// <summary>
            /// Точность возвышения
            /// </summary>
            public static String ТочностьВозвышения
            {
                get
                {
                    return "ТочностьВозвышения";
                }
            }
            
            /// <summary>
            /// Точность координат GPS
            /// </summary>
            public static String ТочностьКоординатGPS
            {
                get
                {
                    return "ТочностьКоординатGPS";
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
                    descriptor.Name = "ФормированиеСменыДень";
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
            return "Мониторинг.ФормированиеСменыДень";
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
        [NsgReferentsFilterAttribute("Мониторинг.ФормированиеСмены")]
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
        /// Таблица техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФормированиеСменыДеньТаблицаТехника ТаблицаТехника
        {
            get
            {
				 NsgDataTableReference __ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФормированиеСменыДеньТаблицаТехника)__ТаблицаТехника.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаТехника = ObjectList["ТаблицаТехника"] as NsgDataTableReference;
                __ТаблицаТехника.Referent = value;
            }
        }
        
        /// <summary>
        /// Всего техники ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиВРаботе
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиВРаботе.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиВРаботе = ObjectList["ВсегоТехникиВРаботе"] as NsgDataInteger;
                __ВсегоТехникиВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники ВРемонте
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиВРемонте
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиВРемонте.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиВРемонте = ObjectList["ВсегоТехникиВРемонте"] as NsgDataInteger;
                __ВсегоТехникиВРемонте.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники не ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиНеВРаботе
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиНеВРаботе.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиНеВРаботе = ObjectList["ВсегоТехникиНеВРаботе"] as NsgDataInteger;
                __ВсегоТехникиНеВРаботе.Value = value;
            }
        }
        
        /// <summary>
        /// Всего техники сломано
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ВсегоТехникиСломано
        {
            get
            {
				 NsgDataInteger __ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                 return (System.Int64)__ВсегоТехникиСломано.Value;
            }
            set
            {
                NsgDataInteger __ВсегоТехникиСломано = ObjectList["ВсегоТехникиСломано"] as NsgDataInteger;
                __ВсегоТехникиСломано.Value = value;
            }
        }
        
        /// <summary>
        /// Количество техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоТехники
        {
            get
            {
				 NsgDataInteger __КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                 return (System.Int64)__КоличествоТехники.Value;
            }
            set
            {
                NsgDataInteger __КоличествоТехники = ObjectList["КоличествоТехники"] as NsgDataInteger;
                __КоличествоТехники.Value = value;
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
        /// Таблица персонал
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингФормированиеСменыДеньТаблицаПерсонал ТаблицаПерсонал
        {
            get
            {
				 NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                 return (_SystemTables.МониторингФормированиеСменыДеньТаблицаПерсонал)__ТаблицаПерсонал.Referent;
            }
            set
            {
                NsgDataTableReference __ТаблицаПерсонал = ObjectList["ТаблицаПерсонал"] as NsgDataTableReference;
                __ТаблицаПерсонал.Referent = value;
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
        /// Дата последнгего изменения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПоследнгегоИзменения
        {
            get
            {
				 NsgDataDateTime __ДатаПоследнгегоИзменения = ObjectList["ДатаПоследнгегоИзменения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПоследнгегоИзменения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПоследнгегоИзменения = ObjectList["ДатаПоследнгегоИзменения"] as NsgDataDateTime;
                __ДатаПоследнгегоИзменения.Value = value;
            }
        }
        
        /// <summary>
        /// Завершает смену
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЗавершаетСмену
        {
            get
            {
				 NsgDataBoolean __ЗавершаетСмену = ObjectList["ЗавершаетСмену"] as NsgDataBoolean;
                 return (System.Boolean)__ЗавершаетСмену.Value;
            }
            set
            {
                NsgDataBoolean __ЗавершаетСмену = ObjectList["ЗавершаетСмену"] as NsgDataBoolean;
                __ЗавершаетСмену.Value = value;
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
        /// Возвышение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Возвышение
        {
            get
            {
				 NsgDataFloat __Возвышение = ObjectList["Возвышение"] as NsgDataFloat;
                 return (System.Decimal)__Возвышение.Value;
            }
            set
            {
                NsgDataFloat __Возвышение = ObjectList["Возвышение"] as NsgDataFloat;
                __Возвышение.Value = value;
            }
        }
        
        /// <summary>
        /// Точность возвышения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ТочностьВозвышения
        {
            get
            {
				 NsgDataFloat __ТочностьВозвышения = ObjectList["ТочностьВозвышения"] as NsgDataFloat;
                 return (System.Decimal)__ТочностьВозвышения.Value;
            }
            set
            {
                NsgDataFloat __ТочностьВозвышения = ObjectList["ТочностьВозвышения"] as NsgDataFloat;
                __ТочностьВозвышения.Value = value;
            }
        }
        
        /// <summary>
        /// Точность координат GPS
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ТочностьКоординатGPS
        {
            get
            {
				 NsgDataFloat __ТочностьКоординатGPS = ObjectList["ТочностьКоординатGPS"] as NsgDataFloat;
                 return (System.Decimal)__ТочностьКоординатGPS.Value;
            }
            set
            {
                NsgDataFloat __ТочностьКоординатGPS = ObjectList["ТочностьКоординатGPS"] as NsgDataFloat;
                __ТочностьКоординатGPS.Value = value;
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
        
        #region Свойства NsgSoft.DataObjects.NsgDataDocument
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDocument

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDocument

        #region Методы NsgMultipleObject
        private ФормированиеСменыДень[] convertArray(NsgMultipleObject[] array)
        {
            ФормированиеСменыДень[] res = new ФормированиеСменыДень[array.Length];
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
        public new virtual ФормированиеСменыДень[] FindAll(NsgCompare compare)
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
        public new virtual ФормированиеСменыДень[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ФормированиеСменыДень[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ФормированиеСменыДень[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ФормированиеСменыДень(this as NsgObject);
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
                base.NSGType = typeof(ФормированиеСменыДень);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ФормированиеСменыДень Value
            {
                get
                {
                    return (ФормированиеСменыДень)base.Value;
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
