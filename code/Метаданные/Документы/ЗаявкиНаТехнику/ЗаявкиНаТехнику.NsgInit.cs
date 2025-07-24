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
    
    [NsgTypeName("NsgDataDocument", Guid = "b2f24728-e1c6-4843-813a-a5316e5c24e8")]
    public partial class ЗаявкиНаТехнику : NsgSoft.DataObjects.NsgDataDocument
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
        protected ЗаявкиНаТехнику()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ЗаявкиНаТехнику(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ЗаявкиНаТехнику Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b2f24728-e1c6-4843-813a-a5316e5c24e8"));
            if (obj == null)
                obj = new ЗаявкиНаТехнику();
            return obj as ЗаявкиНаТехнику;
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
	Идентификатор.Guid = NsgService.StringToGuid("fb4d098d-98ae-4401-99da-989df372ee4e");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("7932449c-b8ae-4ed5-a5e5-2f5e87980a20");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("907a7e0d-7ff3-4687-8faf-cf56ff5b1c84");
	
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
	НомерКода.Guid = NsgService.StringToGuid("173f9315-d1d1-41f5-bbf2-4a447708a778");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("c172b648-7ddd-44ed-a5cf-f5802d1e3c7e");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("a2e45217-c9c6-4d2f-a70f-5ae5c7f19d9a");
	
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
	Индекс.Guid = NsgService.StringToGuid("4a02c9f9-a148-46ba-87d6-ad81021a0bc6");
	
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
	ДокументОснование.Guid = NsgService.StringToGuid("3f402b66-4233-42fe-bc73-baff17274428");
	
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
	Комментарий.Guid = NsgService.StringToGuid("2a8d4bd9-6409-4c1b-af2f-7d2838fbc93c");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("6d920a21-0db1-4687-a137-6c2c4be494e0");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Мониторинг.ТипСобственности ТипСобственности
			{  
                NsgDataEnumReference ТипСобственности = null;
				if (ObjectList.Contains("ТипСобственности"))
                    ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                else
                    ТипСобственности = new NsgDataEnumReference();
	//NsgDataEnumReference
	ТипСобственности.IsLoadedFromDll = true;
	ТипСобственности.ReferentGroup = "Мониторинг";
	ТипСобственности.ReferentName = "ТипСобственности";
	ТипСобственности.SaveInDatabase = true;
	ТипСобственности.OwnerName = "";
	ТипСобственности.AllowEmptyOwner = false;
	ТипСобственности.StringFormat = "";
	ТипСобственности.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТипСобственности.IncludeInPredefined = false;
	ТипСобственности.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипСобственности.Required = false;
	ТипСобственности.EmptyValue = "";
	ТипСобственности.NullAllow = false;
	ТипСобственности.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипСобственности.FieldName = "TipSobstvennosti";
	ТипСобственности.InformMetaDataOnValueChanged = false;
	ТипСобственности.Visible = true;
	ТипСобственности.Name = "ТипСобственности";
	ТипСобственности.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТипСобственности.Description = "Тип собственности";
	ТипСобственности.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТипСобственности.GroupName = "";
	ТипСобственности.Guid = NsgService.StringToGuid("7ab2cb1c-52c7-4d2b-8b2e-3aaf46d56aa7");
	
				if (!ObjectList.Contains("ТипСобственности"))
                    ObjectList.Add(ТипСобственности);
			}
			#endregion //создание Мониторинг.ТипСобственности ТипСобственности
			
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
	Объект.Guid = NsgService.StringToGuid("820d6f11-3cca-47ea-a09f-11524eeaf51b");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Мониторинг.ГруппыСпецТехники ВидСпецТехники
			{  
                NsgDataTypedReference ВидСпецТехники = null;
				if (ObjectList.Contains("ВидСпецТехники"))
                    ВидСпецТехники = ObjectList["ВидСпецТехники"] as NsgDataTypedReference;
                else
                    ВидСпецТехники = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидСпецТехники.IsLoadedFromDll = true;
	ВидСпецТехники.ReferentGroup = "Мониторинг";
	ВидСпецТехники.ReferentName = "ГруппыСпецТехники";
	ВидСпецТехники.SaveInDatabase = true;
	ВидСпецТехники.OwnerName = "";
	ВидСпецТехники.AllowEmptyOwner = false;
	ВидСпецТехники.StringFormat = "";
	ВидСпецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВидСпецТехники.IncludeInPredefined = false;
	ВидСпецТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидСпецТехники.Required = false;
	ВидСпецТехники.EmptyValue = "";
	ВидСпецТехники.NullAllow = false;
	ВидСпецТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидСпецТехники.FieldName = "VidSpecTekhniki";
	ВидСпецТехники.InformMetaDataOnValueChanged = false;
	ВидСпецТехники.Visible = true;
	ВидСпецТехники.Name = "ВидСпецТехники";
	ВидСпецТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидСпецТехники.Description = "Вид спец техники";
	ВидСпецТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидСпецТехники.GroupName = "";
	ВидСпецТехники.Guid = NsgService.StringToGuid("a75d5bd9-49ce-4084-9cb1-50e8e343f820");
	
				if (!ObjectList.Contains("ВидСпецТехники"))
                    ObjectList.Add(ВидСпецТехники);
			}
			#endregion //создание Мониторинг.ГруппыСпецТехники ВидСпецТехники
			
			#region создание Мониторинг.Техника УтвержденнаяТехника
			{  
                NsgDataTypedReference УтвержденнаяТехника = null;
				if (ObjectList.Contains("УтвержденнаяТехника"))
                    УтвержденнаяТехника = ObjectList["УтвержденнаяТехника"] as NsgDataTypedReference;
                else
                    УтвержденнаяТехника = new NsgDataTypedReference();
	//NsgDataTypedReference
	УтвержденнаяТехника.IsLoadedFromDll = true;
	УтвержденнаяТехника.ReferentGroup = "Мониторинг";
	УтвержденнаяТехника.ReferentName = "Техника";
	УтвержденнаяТехника.SaveInDatabase = true;
	УтвержденнаяТехника.OwnerName = "";
	УтвержденнаяТехника.AllowEmptyOwner = false;
	УтвержденнаяТехника.StringFormat = "";
	УтвержденнаяТехника.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	УтвержденнаяТехника.IncludeInPredefined = false;
	УтвержденнаяТехника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	УтвержденнаяТехника.Required = false;
	УтвержденнаяТехника.EmptyValue = "";
	УтвержденнаяТехника.NullAllow = false;
	УтвержденнаяТехника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	УтвержденнаяТехника.FieldName = "UtverzhdennajaTek";
	УтвержденнаяТехника.InformMetaDataOnValueChanged = false;
	УтвержденнаяТехника.Visible = true;
	УтвержденнаяТехника.Name = "УтвержденнаяТехника";
	УтвержденнаяТехника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	УтвержденнаяТехника.Description = "Утвержденная техника";
	УтвержденнаяТехника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	УтвержденнаяТехника.GroupName = "";
	УтвержденнаяТехника.Guid = NsgService.StringToGuid("59d160c3-7049-46e8-808c-19b6d53d9db6");
	
				if (!ObjectList.Contains("УтвержденнаяТехника"))
                    ObjectList.Add(УтвержденнаяТехника);
			}
			#endregion //создание Мониторинг.Техника УтвержденнаяТехника
			
			#region создание Справочники.ВидыРабот ВидРабот
			{  
                NsgDataTypedReference ВидРабот = null;
				if (ObjectList.Contains("ВидРабот"))
                    ВидРабот = ObjectList["ВидРабот"] as NsgDataTypedReference;
                else
                    ВидРабот = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидРабот.IsLoadedFromDll = true;
	ВидРабот.ReferentGroup = "Справочники";
	ВидРабот.ReferentName = "ВидыРабот";
	ВидРабот.SaveInDatabase = true;
	ВидРабот.OwnerName = "";
	ВидРабот.AllowEmptyOwner = false;
	ВидРабот.StringFormat = "";
	ВидРабот.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВидРабот.IncludeInPredefined = false;
	ВидРабот.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидРабот.Required = false;
	ВидРабот.EmptyValue = "";
	ВидРабот.NullAllow = false;
	ВидРабот.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидРабот.FieldName = "VidRabot";
	ВидРабот.InformMetaDataOnValueChanged = false;
	ВидРабот.Visible = true;
	ВидРабот.Name = "ВидРабот";
	ВидРабот.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидРабот.Description = "Вид работ";
	ВидРабот.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидРабот.GroupName = "";
	ВидРабот.Guid = NsgService.StringToGuid("ae2fb093-673c-4499-a730-18436b6cafc2");
	
				if (!ObjectList.Contains("ВидРабот"))
                    ObjectList.Add(ВидРабот);
			}
			#endregion //создание Справочники.ВидыРабот ВидРабот
			
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
	Автор.Guid = NsgService.StringToGuid("c7199062-9e43-433b-914b-a19159e5f53a");
	
				if (!ObjectList.Contains("Автор"))
                    ObjectList.Add(Автор);
			}
			#endregion //создание СлужебныеСправочники.ПользователиСервисов Автор
			
			#region создание System.DateTime ДатаОкончанияРабот
			{  
                NsgDataDateTime ДатаОкончанияРабот = null;
				if (ObjectList.Contains("ДатаОкончанияРабот"))
                    ДатаОкончанияРабот = ObjectList["ДатаОкончанияРабот"] as NsgDataDateTime;
                else
                    ДатаОкончанияРабот = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияРабот.IsLoadedFromDll = true;
	ДатаОкончанияРабот.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончанияРабот.StringFormat = "";
	ДатаОкончанияРабот.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияРабот.IncludeInPredefined = false;
	ДатаОкончанияРабот.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияРабот.Required = false;
	ДатаОкончанияРабот.EmptyValue = "";
	ДатаОкончанияРабот.NullAllow = false;
	ДатаОкончанияРабот.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончанияРабот.FieldName = "DataOkonchanijaRabot";
	ДатаОкончанияРабот.SaveInDatabase = true;
	ДатаОкончанияРабот.InformMetaDataOnValueChanged = false;
	ДатаОкончанияРабот.Visible = true;
	ДатаОкончанияРабот.Name = "ДатаОкончанияРабот";
	ДатаОкончанияРабот.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончанияРабот.Description = "Дата окончания работ";
	ДатаОкончанияРабот.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончанияРабот.GroupName = "";
	ДатаОкончанияРабот.Guid = NsgService.StringToGuid("70cef2ed-3def-4aa3-a13e-ec10a3a27b90");
	
				if (!ObjectList.Contains("ДатаОкончанияРабот"))
                    ObjectList.Add(ДатаОкончанияРабот);
			}
			#endregion //создание System.DateTime ДатаОкончанияРабот
			
			#region создание Мониторинг.Контрагенты ВладелецТехники
			{  
                NsgDataTypedReference ВладелецТехники = null;
				if (ObjectList.Contains("ВладелецТехники"))
                    ВладелецТехники = ObjectList["ВладелецТехники"] as NsgDataTypedReference;
                else
                    ВладелецТехники = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВладелецТехники.IsLoadedFromDll = true;
	ВладелецТехники.ReferentGroup = "Мониторинг";
	ВладелецТехники.ReferentName = "Контрагенты";
	ВладелецТехники.SaveInDatabase = true;
	ВладелецТехники.OwnerName = "";
	ВладелецТехники.AllowEmptyOwner = false;
	ВладелецТехники.StringFormat = "";
	ВладелецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВладелецТехники.IncludeInPredefined = false;
	ВладелецТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВладелецТехники.Required = false;
	ВладелецТехники.EmptyValue = "";
	ВладелецТехники.NullAllow = false;
	ВладелецТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВладелецТехники.FieldName = "VladelecTekhniki";
	ВладелецТехники.InformMetaDataOnValueChanged = false;
	ВладелецТехники.Visible = true;
	ВладелецТехники.Name = "ВладелецТехники";
	ВладелецТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВладелецТехники.Description = "Владелец техники";
	ВладелецТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВладелецТехники.GroupName = "";
	ВладелецТехники.Guid = NsgService.StringToGuid("63a85a22-a0da-4c43-9dd1-8bf791f745c3");
	
				if (!ObjectList.Contains("ВладелецТехники"))
                    ObjectList.Add(ВладелецТехники);
			}
			#endregion //создание Мониторинг.Контрагенты ВладелецТехники
			
			#region создание System.DateTime ДатаИсполнения
			{  
                NsgDataDateTime ДатаИсполнения = null;
				if (ObjectList.Contains("ДатаИсполнения"))
                    ДатаИсполнения = ObjectList["ДатаИсполнения"] as NsgDataDateTime;
                else
                    ДатаИсполнения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаИсполнения.IsLoadedFromDll = true;
	ДатаИсполнения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаИсполнения.StringFormat = "";
	ДатаИсполнения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаИсполнения.IncludeInPredefined = false;
	ДатаИсполнения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаИсполнения.Required = false;
	ДатаИсполнения.EmptyValue = "";
	ДатаИсполнения.NullAllow = false;
	ДатаИсполнения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаИсполнения.FieldName = "DataIspolnenija";
	ДатаИсполнения.SaveInDatabase = true;
	ДатаИсполнения.InformMetaDataOnValueChanged = false;
	ДатаИсполнения.Visible = true;
	ДатаИсполнения.Name = "ДатаИсполнения";
	ДатаИсполнения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаИсполнения.Description = "Дата исполнения";
	ДатаИсполнения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаИсполнения.GroupName = "";
	ДатаИсполнения.Guid = NsgService.StringToGuid("fbffa508-e10e-4379-9899-b684a7e72267");
	
				if (!ObjectList.Contains("ДатаИсполнения"))
                    ObjectList.Add(ДатаИсполнения);
			}
			#endregion //создание System.DateTime ДатаИсполнения
			
			#region создание System.DateTime ДатаНачалаРабот
			{  
                NsgDataDateTime ДатаНачалаРабот = null;
				if (ObjectList.Contains("ДатаНачалаРабот"))
                    ДатаНачалаРабот = ObjectList["ДатаНачалаРабот"] as NsgDataDateTime;
                else
                    ДатаНачалаРабот = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаНачалаРабот.IsLoadedFromDll = true;
	ДатаНачалаРабот.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаНачалаРабот.StringFormat = "";
	ДатаНачалаРабот.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаНачалаРабот.IncludeInPredefined = false;
	ДатаНачалаРабот.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаНачалаРабот.Required = false;
	ДатаНачалаРабот.EmptyValue = "";
	ДатаНачалаРабот.NullAllow = false;
	ДатаНачалаРабот.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаНачалаРабот.FieldName = "DataNachalaRabot";
	ДатаНачалаРабот.SaveInDatabase = true;
	ДатаНачалаРабот.InformMetaDataOnValueChanged = false;
	ДатаНачалаРабот.Visible = true;
	ДатаНачалаРабот.Name = "ДатаНачалаРабот";
	ДатаНачалаРабот.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаНачалаРабот.Description = "Дата начала работ";
	ДатаНачалаРабот.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаНачалаРабот.GroupName = "";
	ДатаНачалаРабот.Guid = NsgService.StringToGuid("1bed6aef-f6a6-4e8c-92b7-dec547de6d97");
	
				if (!ObjectList.Contains("ДатаНачалаРабот"))
                    ObjectList.Add(ДатаНачалаРабот);
			}
			#endregion //создание System.DateTime ДатаНачалаРабот
			
			#region создание System.Decimal ТребуемыйОбъемКузова
			{  
                NsgDataFloat ТребуемыйОбъемКузова = null;
				if (ObjectList.Contains("ТребуемыйОбъемКузова"))
                    ТребуемыйОбъемКузова = ObjectList["ТребуемыйОбъемКузова"] as NsgDataFloat;
                else
                    ТребуемыйОбъемКузова = new NsgDataFloat();
	//NsgDataFloat
	ТребуемыйОбъемКузова.IsLoadedFromDll = true;
	ТребуемыйОбъемКузова.Precision = 2;
	ТребуемыйОбъемКузова.HideZero = true;
	ТребуемыйОбъемКузова.DefaultValue = 0M;
	ТребуемыйОбъемКузова.MinValue = -100000000000000000M;
	ТребуемыйОбъемКузова.MaxValue = 100000000000000000M;
	ТребуемыйОбъемКузова.UseCalculator = true;
	ТребуемыйОбъемКузова.StringFormat = "";
	ТребуемыйОбъемКузова.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТребуемыйОбъемКузова.IncludeInPredefined = false;
	ТребуемыйОбъемКузова.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТребуемыйОбъемКузова.Required = false;
	ТребуемыйОбъемКузова.EmptyValue = "";
	ТребуемыйОбъемКузова.NullAllow = false;
	ТребуемыйОбъемКузова.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТребуемыйОбъемКузова.FieldName = "TrebuemyijObemKuzova";
	ТребуемыйОбъемКузова.SaveInDatabase = true;
	ТребуемыйОбъемКузова.InformMetaDataOnValueChanged = false;
	ТребуемыйОбъемКузова.Visible = true;
	ТребуемыйОбъемКузова.Name = "ТребуемыйОбъемКузова";
	ТребуемыйОбъемКузова.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуемыйОбъемКузова.Description = "Требуемый объем кузова";
	ТребуемыйОбъемКузова.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТребуемыйОбъемКузова.GroupName = "";
	ТребуемыйОбъемКузова.Guid = NsgService.StringToGuid("8ecf8ff1-959f-4c85-897a-198da9299eea");
	
				if (!ObjectList.Contains("ТребуемыйОбъемКузова"))
                    ObjectList.Add(ТребуемыйОбъемКузова);
			}
			#endregion //создание System.Decimal ТребуемыйОбъемКузова
			
			#region создание Мониторинг.ФизЛица Водитель
			{  
                NsgDataTypedReference Водитель = null;
				if (ObjectList.Contains("Водитель"))
                    Водитель = ObjectList["Водитель"] as NsgDataTypedReference;
                else
                    Водитель = new NsgDataTypedReference();
	//NsgDataTypedReference
	Водитель.IsLoadedFromDll = true;
	Водитель.ReferentGroup = "Мониторинг";
	Водитель.ReferentName = "ФизЛица";
	Водитель.SaveInDatabase = true;
	Водитель.OwnerName = "";
	Водитель.AllowEmptyOwner = false;
	Водитель.StringFormat = "";
	Водитель.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Водитель.IncludeInPredefined = false;
	Водитель.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Водитель.Required = false;
	Водитель.EmptyValue = "";
	Водитель.NullAllow = false;
	Водитель.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Водитель.FieldName = "Voditel";
	Водитель.InformMetaDataOnValueChanged = false;
	Водитель.Visible = true;
	Водитель.Name = "Водитель";
	Водитель.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Водитель.Description = "Водитель";
	Водитель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Водитель.GroupName = "";
	Водитель.Guid = NsgService.StringToGuid("63a32285-1471-4bb0-9736-d496462379c8");
	
				if (!ObjectList.Contains("Водитель"))
                    ObjectList.Add(Водитель);
			}
			#endregion //создание Мониторинг.ФизЛица Водитель
			
			#region создание System.DateTime ДатаОтправкиЗаявки
			{  
                NsgDataDateTime ДатаОтправкиЗаявки = null;
				if (ObjectList.Contains("ДатаОтправкиЗаявки"))
                    ДатаОтправкиЗаявки = ObjectList["ДатаОтправкиЗаявки"] as NsgDataDateTime;
                else
                    ДатаОтправкиЗаявки = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОтправкиЗаявки.IsLoadedFromDll = true;
	ДатаОтправкиЗаявки.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОтправкиЗаявки.StringFormat = "";
	ДатаОтправкиЗаявки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОтправкиЗаявки.IncludeInPredefined = false;
	ДатаОтправкиЗаявки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОтправкиЗаявки.Required = false;
	ДатаОтправкиЗаявки.EmptyValue = "";
	ДатаОтправкиЗаявки.NullAllow = false;
	ДатаОтправкиЗаявки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОтправкиЗаявки.FieldName = "DataOtpravkiZajavki";
	ДатаОтправкиЗаявки.SaveInDatabase = true;
	ДатаОтправкиЗаявки.InformMetaDataOnValueChanged = false;
	ДатаОтправкиЗаявки.Visible = true;
	ДатаОтправкиЗаявки.Name = "ДатаОтправкиЗаявки";
	ДатаОтправкиЗаявки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОтправкиЗаявки.Description = "Дата отправки заявки";
	ДатаОтправкиЗаявки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОтправкиЗаявки.GroupName = "";
	ДатаОтправкиЗаявки.Guid = NsgService.StringToGuid("2ab1b7c2-071c-4403-a9aa-9fe3ddb2fe05");
	
				if (!ObjectList.Contains("ДатаОтправкиЗаявки"))
                    ObjectList.Add(ДатаОтправкиЗаявки);
			}
			#endregion //создание System.DateTime ДатаОтправкиЗаявки
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ЗаявкиНаТехнику"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ЗаявкиНаТехнику";
	Visible = true;
	Guid = NsgService.StringToGuid("b2f24728-e1c6-4843-813a-a5316e5c24e8");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_ZajavkiNaTekhniku";
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
            /// Тип собственности
            /// </summary>
            public static String ТипСобственности
            {
                get
                {
                    return "ТипСобственности";
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
            /// Вид спец техники
            /// </summary>
            public static String ВидСпецТехники
            {
                get
                {
                    return "ВидСпецТехники";
                }
            }
            
            /// <summary>
            /// Утвержденная техника
            /// </summary>
            public static String УтвержденнаяТехника
            {
                get
                {
                    return "УтвержденнаяТехника";
                }
            }
            
            /// <summary>
            /// Вид работ
            /// </summary>
            public static String ВидРабот
            {
                get
                {
                    return "ВидРабот";
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
            /// Дата окончания работ
            /// </summary>
            public static String ДатаОкончанияРабот
            {
                get
                {
                    return "ДатаОкончанияРабот";
                }
            }
            
            /// <summary>
            /// Владелец техники
            /// </summary>
            public static String ВладелецТехники
            {
                get
                {
                    return "ВладелецТехники";
                }
            }
            
            /// <summary>
            /// Дата исполнения
            /// </summary>
            public static String ДатаИсполнения
            {
                get
                {
                    return "ДатаИсполнения";
                }
            }
            
            /// <summary>
            /// Дата начала работ
            /// </summary>
            public static String ДатаНачалаРабот
            {
                get
                {
                    return "ДатаНачалаРабот";
                }
            }
            
            /// <summary>
            /// Требуемый объем кузова
            /// </summary>
            public static String ТребуемыйОбъемКузова
            {
                get
                {
                    return "ТребуемыйОбъемКузова";
                }
            }
            
            /// <summary>
            /// Водитель
            /// </summary>
            public static String Водитель
            {
                get
                {
                    return "Водитель";
                }
            }
            
            /// <summary>
            /// Дата отправки заявки
            /// </summary>
            public static String ДатаОтправкиЗаявки
            {
                get
                {
                    return "ДатаОтправкиЗаявки";
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
                    descriptor.Name = "ЗаявкиНаТехнику";
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
            return "Документы.ЗаявкиНаТехнику";
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
        /// Тип собственности
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ТипСобственности ТипСобственности
        {
            get
            {
				 NsgDataEnumReference __ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                 return (Мониторинг.ТипСобственности)__ТипСобственности.Referent;
            }
            set
            {
                NsgDataEnumReference __ТипСобственности = ObjectList["ТипСобственности"] as NsgDataEnumReference;
                __ТипСобственности.Referent = value;
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
        /// Вид спец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ГруппыСпецТехники ВидСпецТехники
        {
            get
            {
				 NsgDataTypedReference __ВидСпецТехники = ObjectList["ВидСпецТехники"] as NsgDataTypedReference;
                 return (Мониторинг.ГруппыСпецТехники)__ВидСпецТехники.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидСпецТехники = ObjectList["ВидСпецТехники"] as NsgDataTypedReference;
                __ВидСпецТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Утвержденная техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Техника УтвержденнаяТехника
        {
            get
            {
				 NsgDataTypedReference __УтвержденнаяТехника = ObjectList["УтвержденнаяТехника"] as NsgDataTypedReference;
                 return (Мониторинг.Техника)__УтвержденнаяТехника.Referent;
            }
            set
            {
                NsgDataTypedReference __УтвержденнаяТехника = ObjectList["УтвержденнаяТехника"] as NsgDataTypedReference;
                __УтвержденнаяТехника.Referent = value;
            }
        }
        
        /// <summary>
        /// Вид работ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Справочники.ВидыРабот ВидРабот
        {
            get
            {
				 NsgDataTypedReference __ВидРабот = ObjectList["ВидРабот"] as NsgDataTypedReference;
                 return (Справочники.ВидыРабот)__ВидРабот.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидРабот = ObjectList["ВидРабот"] as NsgDataTypedReference;
                __ВидРабот.Referent = value;
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
        /// Дата окончания работ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияРабот
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияРабот = ObjectList["ДатаОкончанияРабот"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияРабот.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияРабот = ObjectList["ДатаОкончанияРабот"] as NsgDataDateTime;
                __ДатаОкончанияРабот.Value = value;
            }
        }
        
        /// <summary>
        /// Владелец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты ВладелецТехники
        {
            get
            {
				 NsgDataTypedReference __ВладелецТехники = ObjectList["ВладелецТехники"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__ВладелецТехники.Referent;
            }
            set
            {
                NsgDataTypedReference __ВладелецТехники = ObjectList["ВладелецТехники"] as NsgDataTypedReference;
                __ВладелецТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата исполнения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаИсполнения
        {
            get
            {
				 NsgDataDateTime __ДатаИсполнения = ObjectList["ДатаИсполнения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаИсполнения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаИсполнения = ObjectList["ДатаИсполнения"] as NsgDataDateTime;
                __ДатаИсполнения.Value = value;
            }
        }
        
        /// <summary>
        /// Дата начала работ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаНачалаРабот
        {
            get
            {
				 NsgDataDateTime __ДатаНачалаРабот = ObjectList["ДатаНачалаРабот"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаНачалаРабот.Value;
            }
            set
            {
                NsgDataDateTime __ДатаНачалаРабот = ObjectList["ДатаНачалаРабот"] as NsgDataDateTime;
                __ДатаНачалаРабот.Value = value;
            }
        }
        
        /// <summary>
        /// Требуемый объем кузова
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ТребуемыйОбъемКузова
        {
            get
            {
				 NsgDataFloat __ТребуемыйОбъемКузова = ObjectList["ТребуемыйОбъемКузова"] as NsgDataFloat;
                 return (System.Decimal)__ТребуемыйОбъемКузова.Value;
            }
            set
            {
                NsgDataFloat __ТребуемыйОбъемКузова = ObjectList["ТребуемыйОбъемКузова"] as NsgDataFloat;
                __ТребуемыйОбъемКузова.Value = value;
            }
        }
        
        /// <summary>
        /// Водитель
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Водитель
        {
            get
            {
				 NsgDataTypedReference __Водитель = ObjectList["Водитель"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Водитель.Referent;
            }
            set
            {
                NsgDataTypedReference __Водитель = ObjectList["Водитель"] as NsgDataTypedReference;
                __Водитель.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата отправки заявки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОтправкиЗаявки
        {
            get
            {
				 NsgDataDateTime __ДатаОтправкиЗаявки = ObjectList["ДатаОтправкиЗаявки"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОтправкиЗаявки.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОтправкиЗаявки = ObjectList["ДатаОтправкиЗаявки"] as NsgDataDateTime;
                __ДатаОтправкиЗаявки.Value = value;
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
        private ЗаявкиНаТехнику[] convertArray(NsgMultipleObject[] array)
        {
            ЗаявкиНаТехнику[] res = new ЗаявкиНаТехнику[array.Length];
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
        public new virtual ЗаявкиНаТехнику[] FindAll(NsgCompare compare)
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
        public new virtual ЗаявкиНаТехнику[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ЗаявкиНаТехнику[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ЗаявкиНаТехнику[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ЗаявкиНаТехнику(this as NsgObject);
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
                base.NSGType = typeof(ЗаявкиНаТехнику);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ЗаявкиНаТехнику Value
            {
                get
                {
                    return (ЗаявкиНаТехнику)base.Value;
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
