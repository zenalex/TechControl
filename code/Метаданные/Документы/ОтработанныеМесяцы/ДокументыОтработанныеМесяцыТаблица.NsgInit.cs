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

namespace TechControl.Метаданные._SystemTables
{
    
    [NsgTypeName("NsgDataTable", Guid = "8dcec5fe-e3c0-4dbc-9caf-80261c74f684")]
    public partial class ДокументыОтработанныеМесяцыТаблица : NsgSoft.DataObjects.NsgDataTable
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTable

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTable

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ДокументыОтработанныеМесяцыТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ДокументыОтработанныеМесяцыТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ДокументыОтработанныеМесяцыТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("8dcec5fe-e3c0-4dbc-9caf-80261c74f684"));
            if (obj == null)
                obj = new ДокументыОтработанныеМесяцыТаблица();
            return obj as ДокументыОтработанныеМесяцыТаблица;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTable
			
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
	Идентификатор.Guid = NsgService.StringToGuid("ea09a594-bc48-4fed-bc6d-49769a91d70f");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("5b079fc1-129c-41f1-8eb5-01de3a695d25");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			{  
                NsgDataUntypedReference Владелец = null;
				if (ObjectList.Contains("Владелец"))
                    Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                else
                    Владелец = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	Владелец.IsLoadedFromDll = true;
	Владелец.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	Владелец.FilterForConfigurator = "Документы.ОтработанныеМесяцы";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("24b98b71-15a5-4f11-9df7-ab2a9fbec6a5");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.Int64 НомерСтроки
			{  
                NsgDataInteger НомерСтроки = null;
				if (ObjectList.Contains("НомерСтроки"))
                    НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                else
                    НомерСтроки = new NsgDataInteger();
	//NsgDataInteger
	НомерСтроки.IsLoadedFromDll = true;
	НомерСтроки.DefaultValue = 0M;
	НомерСтроки.MinValue = 0M;
	НомерСтроки.MaxValue = 0M;
	НомерСтроки.UseCalculator = true;
	НомерСтроки.StringFormat = "";
	НомерСтроки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерСтроки.IncludeInPredefined = false;
	НомерСтроки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСтроки.Required = false;
	НомерСтроки.EmptyValue = "";
	НомерСтроки.NullAllow = false;
	НомерСтроки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСтроки.FieldName = "_RowNumber";
	НомерСтроки.SaveInDatabase = true;
	НомерСтроки.InformMetaDataOnValueChanged = false;
	НомерСтроки.Visible = true;
	НомерСтроки.Name = "НомерСтроки";
	НомерСтроки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСтроки.Description = "Номер строки";
	НомерСтроки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	НомерСтроки.GroupName = "";
	НомерСтроки.Guid = NsgService.StringToGuid("a7c1c11c-293e-4241-b5e6-26d9ba5b1671");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Мониторинг.Техника Техника
			{  
                NsgDataTypedReference Техника = null;
				if (ObjectList.Contains("Техника"))
                    Техника = ObjectList["Техника"] as NsgDataTypedReference;
                else
                    Техника = new NsgDataTypedReference();
	//NsgDataTypedReference
	Техника.IsLoadedFromDll = true;
	Техника.ReferentGroup = "Мониторинг";
	Техника.ReferentName = "Техника";
	Техника.SaveInDatabase = true;
	Техника.OwnerName = "";
	Техника.AllowEmptyOwner = false;
	Техника.StringFormat = "";
	Техника.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Техника.IncludeInPredefined = false;
	Техника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Техника.Required = false;
	Техника.EmptyValue = "";
	Техника.NullAllow = false;
	Техника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Техника.FieldName = "Tekhnika";
	Техника.InformMetaDataOnValueChanged = false;
	Техника.Visible = true;
	Техника.Name = "Техника";
	Техника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Техника.Description = "Техника";
	Техника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Техника.GroupName = "";
	Техника.Guid = NsgService.StringToGuid("a47f6278-c541-4d36-9021-6950d1258ba1");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
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
	Объект.Guid = NsgService.StringToGuid("4918a5b9-1fdc-4fbe-ad2a-7e65bf82f1d4");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	Сотрудник.Guid = NsgService.StringToGuid("1e710156-fb51-4d54-99e3-fab912501b5a");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудник
			
			#region создание System.Decimal Д2
			{  
                NsgDataFloat Д2 = null;
				if (ObjectList.Contains("Д2"))
                    Д2 = ObjectList["Д2"] as NsgDataFloat;
                else
                    Д2 = new NsgDataFloat();
	//NsgDataFloat
	Д2.IsLoadedFromDll = true;
	Д2.Precision = 2;
	Д2.HideZero = true;
	Д2.DefaultValue = 0M;
	Д2.MinValue = -100000000000000000M;
	Д2.MaxValue = 100000000000000000M;
	Д2.UseCalculator = true;
	Д2.StringFormat = "";
	Д2.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д2.IncludeInPredefined = false;
	Д2.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д2.Required = false;
	Д2.EmptyValue = "";
	Д2.NullAllow = false;
	Д2.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д2.FieldName = "D2";
	Д2.SaveInDatabase = true;
	Д2.InformMetaDataOnValueChanged = false;
	Д2.Visible = true;
	Д2.Name = "Д2";
	Д2.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д2.Description = "Д2";
	Д2.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д2.GroupName = "";
	Д2.Guid = NsgService.StringToGuid("6ec82e19-ae81-4d92-8acd-da4b5343bf4f");
	
				if (!ObjectList.Contains("Д2"))
                    ObjectList.Add(Д2);
			}
			#endregion //создание System.Decimal Д2
			
			#region создание Мониторинг.Тарифы Тариф
			{  
                NsgDataTypedReference Тариф = null;
				if (ObjectList.Contains("Тариф"))
                    Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                else
                    Тариф = new NsgDataTypedReference();
	//NsgDataTypedReference
	Тариф.IsLoadedFromDll = true;
	Тариф.ReferentGroup = "Мониторинг";
	Тариф.ReferentName = "Тарифы";
	Тариф.SaveInDatabase = true;
	Тариф.OwnerName = "";
	Тариф.AllowEmptyOwner = false;
	Тариф.StringFormat = "";
	Тариф.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Тариф.IncludeInPredefined = false;
	Тариф.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Тариф.Required = false;
	Тариф.EmptyValue = "";
	Тариф.NullAllow = false;
	Тариф.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Тариф.FieldName = "Tarif";
	Тариф.InformMetaDataOnValueChanged = false;
	Тариф.Visible = true;
	Тариф.Name = "Тариф";
	Тариф.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Тариф.Description = "Тариф";
	Тариф.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Тариф.GroupName = "";
	Тариф.Guid = NsgService.StringToGuid("9e4d4b3b-1c95-4179-b3ce-b41a9f06ce52");
	
				if (!ObjectList.Contains("Тариф"))
                    ObjectList.Add(Тариф);
			}
			#endregion //создание Мониторинг.Тарифы Тариф
			
			#region создание System.Decimal Д3
			{  
                NsgDataFloat Д3 = null;
				if (ObjectList.Contains("Д3"))
                    Д3 = ObjectList["Д3"] as NsgDataFloat;
                else
                    Д3 = new NsgDataFloat();
	//NsgDataFloat
	Д3.IsLoadedFromDll = true;
	Д3.Precision = 2;
	Д3.HideZero = true;
	Д3.DefaultValue = 0M;
	Д3.MinValue = -100000000000000000M;
	Д3.MaxValue = 100000000000000000M;
	Д3.UseCalculator = true;
	Д3.StringFormat = "";
	Д3.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д3.IncludeInPredefined = false;
	Д3.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д3.Required = false;
	Д3.EmptyValue = "";
	Д3.NullAllow = false;
	Д3.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д3.FieldName = "D3";
	Д3.SaveInDatabase = true;
	Д3.InformMetaDataOnValueChanged = false;
	Д3.Visible = true;
	Д3.Name = "Д3";
	Д3.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д3.Description = "Д3";
	Д3.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д3.GroupName = "";
	Д3.Guid = NsgService.StringToGuid("6b767c2e-faba-42dd-95c5-b71741f47f21");
	
				if (!ObjectList.Contains("Д3"))
                    ObjectList.Add(Д3);
			}
			#endregion //создание System.Decimal Д3
			
			#region создание System.Decimal Д14
			{  
                NsgDataFloat Д14 = null;
				if (ObjectList.Contains("Д14"))
                    Д14 = ObjectList["Д14"] as NsgDataFloat;
                else
                    Д14 = new NsgDataFloat();
	//NsgDataFloat
	Д14.IsLoadedFromDll = true;
	Д14.Precision = 2;
	Д14.HideZero = true;
	Д14.DefaultValue = 0M;
	Д14.MinValue = -100000000000000000M;
	Д14.MaxValue = 100000000000000000M;
	Д14.UseCalculator = true;
	Д14.StringFormat = "";
	Д14.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д14.IncludeInPredefined = false;
	Д14.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д14.Required = false;
	Д14.EmptyValue = "";
	Д14.NullAllow = false;
	Д14.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д14.FieldName = "D14";
	Д14.SaveInDatabase = true;
	Д14.InformMetaDataOnValueChanged = false;
	Д14.Visible = true;
	Д14.Name = "Д14";
	Д14.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д14.Description = "Д14";
	Д14.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д14.GroupName = "";
	Д14.Guid = NsgService.StringToGuid("9d59b1fa-decd-421d-9eb3-be705e1f436f");
	
				if (!ObjectList.Contains("Д14"))
                    ObjectList.Add(Д14);
			}
			#endregion //создание System.Decimal Д14
			
			#region создание System.Decimal Д25
			{  
                NsgDataFloat Д25 = null;
				if (ObjectList.Contains("Д25"))
                    Д25 = ObjectList["Д25"] as NsgDataFloat;
                else
                    Д25 = new NsgDataFloat();
	//NsgDataFloat
	Д25.IsLoadedFromDll = true;
	Д25.Precision = 2;
	Д25.HideZero = true;
	Д25.DefaultValue = 0M;
	Д25.MinValue = -100000000000000000M;
	Д25.MaxValue = 100000000000000000M;
	Д25.UseCalculator = true;
	Д25.StringFormat = "";
	Д25.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д25.IncludeInPredefined = false;
	Д25.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д25.Required = false;
	Д25.EmptyValue = "";
	Д25.NullAllow = false;
	Д25.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д25.FieldName = "D25";
	Д25.SaveInDatabase = true;
	Д25.InformMetaDataOnValueChanged = false;
	Д25.Visible = true;
	Д25.Name = "Д25";
	Д25.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д25.Description = "Д25";
	Д25.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д25.GroupName = "";
	Д25.Guid = NsgService.StringToGuid("94d6d5eb-7441-4937-ac06-293488f4d225");
	
				if (!ObjectList.Contains("Д25"))
                    ObjectList.Add(Д25);
			}
			#endregion //создание System.Decimal Д25
			
			#region создание System.Decimal Д27
			{  
                NsgDataFloat Д27 = null;
				if (ObjectList.Contains("Д27"))
                    Д27 = ObjectList["Д27"] as NsgDataFloat;
                else
                    Д27 = new NsgDataFloat();
	//NsgDataFloat
	Д27.IsLoadedFromDll = true;
	Д27.Precision = 2;
	Д27.HideZero = true;
	Д27.DefaultValue = 0M;
	Д27.MinValue = -100000000000000000M;
	Д27.MaxValue = 100000000000000000M;
	Д27.UseCalculator = true;
	Д27.StringFormat = "";
	Д27.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д27.IncludeInPredefined = false;
	Д27.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д27.Required = false;
	Д27.EmptyValue = "";
	Д27.NullAllow = false;
	Д27.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д27.FieldName = "D27";
	Д27.SaveInDatabase = true;
	Д27.InformMetaDataOnValueChanged = false;
	Д27.Visible = true;
	Д27.Name = "Д27";
	Д27.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д27.Description = "Д27";
	Д27.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д27.GroupName = "";
	Д27.Guid = NsgService.StringToGuid("68469afe-587d-42d5-969d-859b4807d1c1");
	
				if (!ObjectList.Contains("Д27"))
                    ObjectList.Add(Д27);
			}
			#endregion //создание System.Decimal Д27
			
			#region создание System.Decimal Д28
			{  
                NsgDataFloat Д28 = null;
				if (ObjectList.Contains("Д28"))
                    Д28 = ObjectList["Д28"] as NsgDataFloat;
                else
                    Д28 = new NsgDataFloat();
	//NsgDataFloat
	Д28.IsLoadedFromDll = true;
	Д28.Precision = 2;
	Д28.HideZero = true;
	Д28.DefaultValue = 0M;
	Д28.MinValue = -100000000000000000M;
	Д28.MaxValue = 100000000000000000M;
	Д28.UseCalculator = true;
	Д28.StringFormat = "";
	Д28.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д28.IncludeInPredefined = false;
	Д28.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д28.Required = false;
	Д28.EmptyValue = "";
	Д28.NullAllow = false;
	Д28.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д28.FieldName = "D28";
	Д28.SaveInDatabase = true;
	Д28.InformMetaDataOnValueChanged = false;
	Д28.Visible = true;
	Д28.Name = "Д28";
	Д28.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д28.Description = "Д28";
	Д28.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д28.GroupName = "";
	Д28.Guid = NsgService.StringToGuid("489a3296-05cb-4980-b779-2bf26c1bd3c3");
	
				if (!ObjectList.Contains("Д28"))
                    ObjectList.Add(Д28);
			}
			#endregion //создание System.Decimal Д28
			
			#region создание System.Decimal Д29
			{  
                NsgDataFloat Д29 = null;
				if (ObjectList.Contains("Д29"))
                    Д29 = ObjectList["Д29"] as NsgDataFloat;
                else
                    Д29 = new NsgDataFloat();
	//NsgDataFloat
	Д29.IsLoadedFromDll = true;
	Д29.Precision = 2;
	Д29.HideZero = true;
	Д29.DefaultValue = 0M;
	Д29.MinValue = -100000000000000000M;
	Д29.MaxValue = 100000000000000000M;
	Д29.UseCalculator = true;
	Д29.StringFormat = "";
	Д29.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д29.IncludeInPredefined = false;
	Д29.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д29.Required = false;
	Д29.EmptyValue = "";
	Д29.NullAllow = false;
	Д29.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д29.FieldName = "D29";
	Д29.SaveInDatabase = true;
	Д29.InformMetaDataOnValueChanged = false;
	Д29.Visible = true;
	Д29.Name = "Д29";
	Д29.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д29.Description = "Д29";
	Д29.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д29.GroupName = "";
	Д29.Guid = NsgService.StringToGuid("953db20a-08a8-41b5-abf1-5a46d1dd8d36");
	
				if (!ObjectList.Contains("Д29"))
                    ObjectList.Add(Д29);
			}
			#endregion //создание System.Decimal Д29
			
			#region создание System.Decimal Д30
			{  
                NsgDataFloat Д30 = null;
				if (ObjectList.Contains("Д30"))
                    Д30 = ObjectList["Д30"] as NsgDataFloat;
                else
                    Д30 = new NsgDataFloat();
	//NsgDataFloat
	Д30.IsLoadedFromDll = true;
	Д30.Precision = 2;
	Д30.HideZero = true;
	Д30.DefaultValue = 0M;
	Д30.MinValue = -100000000000000000M;
	Д30.MaxValue = 100000000000000000M;
	Д30.UseCalculator = true;
	Д30.StringFormat = "";
	Д30.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д30.IncludeInPredefined = false;
	Д30.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д30.Required = false;
	Д30.EmptyValue = "";
	Д30.NullAllow = false;
	Д30.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д30.FieldName = "D30";
	Д30.SaveInDatabase = true;
	Д30.InformMetaDataOnValueChanged = false;
	Д30.Visible = true;
	Д30.Name = "Д30";
	Д30.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д30.Description = "Д30";
	Д30.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д30.GroupName = "";
	Д30.Guid = NsgService.StringToGuid("635f4409-70c5-4566-96fa-c43c0226f406");
	
				if (!ObjectList.Contains("Д30"))
                    ObjectList.Add(Д30);
			}
			#endregion //создание System.Decimal Д30
			
			#region создание System.Decimal Д31
			{  
                NsgDataFloat Д31 = null;
				if (ObjectList.Contains("Д31"))
                    Д31 = ObjectList["Д31"] as NsgDataFloat;
                else
                    Д31 = new NsgDataFloat();
	//NsgDataFloat
	Д31.IsLoadedFromDll = true;
	Д31.Precision = 2;
	Д31.HideZero = true;
	Д31.DefaultValue = 0M;
	Д31.MinValue = -100000000000000000M;
	Д31.MaxValue = 100000000000000000M;
	Д31.UseCalculator = true;
	Д31.StringFormat = "";
	Д31.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д31.IncludeInPredefined = false;
	Д31.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д31.Required = false;
	Д31.EmptyValue = "";
	Д31.NullAllow = false;
	Д31.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д31.FieldName = "D31";
	Д31.SaveInDatabase = true;
	Д31.InformMetaDataOnValueChanged = false;
	Д31.Visible = true;
	Д31.Name = "Д31";
	Д31.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д31.Description = "Д31";
	Д31.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д31.GroupName = "";
	Д31.Guid = NsgService.StringToGuid("201d1419-b93e-4373-913a-51a7141e57ac");
	
				if (!ObjectList.Contains("Д31"))
                    ObjectList.Add(Д31);
			}
			#endregion //создание System.Decimal Д31
			
			#region создание System.Decimal Д4
			{  
                NsgDataFloat Д4 = null;
				if (ObjectList.Contains("Д4"))
                    Д4 = ObjectList["Д4"] as NsgDataFloat;
                else
                    Д4 = new NsgDataFloat();
	//NsgDataFloat
	Д4.IsLoadedFromDll = true;
	Д4.Precision = 2;
	Д4.HideZero = true;
	Д4.DefaultValue = 0M;
	Д4.MinValue = -100000000000000000M;
	Д4.MaxValue = 100000000000000000M;
	Д4.UseCalculator = true;
	Д4.StringFormat = "";
	Д4.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д4.IncludeInPredefined = false;
	Д4.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д4.Required = false;
	Д4.EmptyValue = "";
	Д4.NullAllow = false;
	Д4.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д4.FieldName = "D4";
	Д4.SaveInDatabase = true;
	Д4.InformMetaDataOnValueChanged = false;
	Д4.Visible = true;
	Д4.Name = "Д4";
	Д4.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д4.Description = "Д4";
	Д4.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д4.GroupName = "";
	Д4.Guid = NsgService.StringToGuid("acb0c592-2331-4515-ae0f-61f727836c21");
	
				if (!ObjectList.Contains("Д4"))
                    ObjectList.Add(Д4);
			}
			#endregion //создание System.Decimal Д4
			
			#region создание System.Decimal Д5
			{  
                NsgDataFloat Д5 = null;
				if (ObjectList.Contains("Д5"))
                    Д5 = ObjectList["Д5"] as NsgDataFloat;
                else
                    Д5 = new NsgDataFloat();
	//NsgDataFloat
	Д5.IsLoadedFromDll = true;
	Д5.Precision = 2;
	Д5.HideZero = true;
	Д5.DefaultValue = 0M;
	Д5.MinValue = -100000000000000000M;
	Д5.MaxValue = 100000000000000000M;
	Д5.UseCalculator = true;
	Д5.StringFormat = "";
	Д5.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д5.IncludeInPredefined = false;
	Д5.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д5.Required = false;
	Д5.EmptyValue = "";
	Д5.NullAllow = false;
	Д5.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д5.FieldName = "D5";
	Д5.SaveInDatabase = true;
	Д5.InformMetaDataOnValueChanged = false;
	Д5.Visible = true;
	Д5.Name = "Д5";
	Д5.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д5.Description = "Д5";
	Д5.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д5.GroupName = "";
	Д5.Guid = NsgService.StringToGuid("ade397e0-f515-479e-a904-9b4ccfd6c0cd");
	
				if (!ObjectList.Contains("Д5"))
                    ObjectList.Add(Д5);
			}
			#endregion //создание System.Decimal Д5
			
			#region создание System.Decimal Д6
			{  
                NsgDataFloat Д6 = null;
				if (ObjectList.Contains("Д6"))
                    Д6 = ObjectList["Д6"] as NsgDataFloat;
                else
                    Д6 = new NsgDataFloat();
	//NsgDataFloat
	Д6.IsLoadedFromDll = true;
	Д6.Precision = 2;
	Д6.HideZero = true;
	Д6.DefaultValue = 0M;
	Д6.MinValue = -100000000000000000M;
	Д6.MaxValue = 100000000000000000M;
	Д6.UseCalculator = true;
	Д6.StringFormat = "";
	Д6.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д6.IncludeInPredefined = false;
	Д6.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д6.Required = false;
	Д6.EmptyValue = "";
	Д6.NullAllow = false;
	Д6.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д6.FieldName = "D6";
	Д6.SaveInDatabase = true;
	Д6.InformMetaDataOnValueChanged = false;
	Д6.Visible = true;
	Д6.Name = "Д6";
	Д6.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д6.Description = "Д6";
	Д6.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д6.GroupName = "";
	Д6.Guid = NsgService.StringToGuid("6393cdb1-d8d3-4f64-b898-2831c1cb86db");
	
				if (!ObjectList.Contains("Д6"))
                    ObjectList.Add(Д6);
			}
			#endregion //создание System.Decimal Д6
			
			#region создание System.Decimal Д7
			{  
                NsgDataFloat Д7 = null;
				if (ObjectList.Contains("Д7"))
                    Д7 = ObjectList["Д7"] as NsgDataFloat;
                else
                    Д7 = new NsgDataFloat();
	//NsgDataFloat
	Д7.IsLoadedFromDll = true;
	Д7.Precision = 2;
	Д7.HideZero = true;
	Д7.DefaultValue = 0M;
	Д7.MinValue = -100000000000000000M;
	Д7.MaxValue = 100000000000000000M;
	Д7.UseCalculator = true;
	Д7.StringFormat = "";
	Д7.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д7.IncludeInPredefined = false;
	Д7.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д7.Required = false;
	Д7.EmptyValue = "";
	Д7.NullAllow = false;
	Д7.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д7.FieldName = "D7";
	Д7.SaveInDatabase = true;
	Д7.InformMetaDataOnValueChanged = false;
	Д7.Visible = true;
	Д7.Name = "Д7";
	Д7.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д7.Description = "Д7";
	Д7.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д7.GroupName = "";
	Д7.Guid = NsgService.StringToGuid("617008d4-e57a-437d-b8ad-45aab40b0192");
	
				if (!ObjectList.Contains("Д7"))
                    ObjectList.Add(Д7);
			}
			#endregion //создание System.Decimal Д7
			
			#region создание System.Decimal Д8
			{  
                NsgDataFloat Д8 = null;
				if (ObjectList.Contains("Д8"))
                    Д8 = ObjectList["Д8"] as NsgDataFloat;
                else
                    Д8 = new NsgDataFloat();
	//NsgDataFloat
	Д8.IsLoadedFromDll = true;
	Д8.Precision = 2;
	Д8.HideZero = true;
	Д8.DefaultValue = 0M;
	Д8.MinValue = -100000000000000000M;
	Д8.MaxValue = 100000000000000000M;
	Д8.UseCalculator = true;
	Д8.StringFormat = "";
	Д8.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д8.IncludeInPredefined = false;
	Д8.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д8.Required = false;
	Д8.EmptyValue = "";
	Д8.NullAllow = false;
	Д8.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д8.FieldName = "D8";
	Д8.SaveInDatabase = true;
	Д8.InformMetaDataOnValueChanged = false;
	Д8.Visible = true;
	Д8.Name = "Д8";
	Д8.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д8.Description = "Д8";
	Д8.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д8.GroupName = "";
	Д8.Guid = NsgService.StringToGuid("c0d4a816-7f20-41a9-82b7-4bb4e985183c");
	
				if (!ObjectList.Contains("Д8"))
                    ObjectList.Add(Д8);
			}
			#endregion //создание System.Decimal Д8
			
			#region создание System.Decimal Д9
			{  
                NsgDataFloat Д9 = null;
				if (ObjectList.Contains("Д9"))
                    Д9 = ObjectList["Д9"] as NsgDataFloat;
                else
                    Д9 = new NsgDataFloat();
	//NsgDataFloat
	Д9.IsLoadedFromDll = true;
	Д9.Precision = 2;
	Д9.HideZero = true;
	Д9.DefaultValue = 0M;
	Д9.MinValue = -100000000000000000M;
	Д9.MaxValue = 100000000000000000M;
	Д9.UseCalculator = true;
	Д9.StringFormat = "";
	Д9.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д9.IncludeInPredefined = false;
	Д9.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д9.Required = false;
	Д9.EmptyValue = "";
	Д9.NullAllow = false;
	Д9.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д9.FieldName = "D9";
	Д9.SaveInDatabase = true;
	Д9.InformMetaDataOnValueChanged = false;
	Д9.Visible = true;
	Д9.Name = "Д9";
	Д9.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д9.Description = "Д9";
	Д9.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д9.GroupName = "";
	Д9.Guid = NsgService.StringToGuid("0a7fb58a-f649-4efd-8a1b-bfa7c967dd34");
	
				if (!ObjectList.Contains("Д9"))
                    ObjectList.Add(Д9);
			}
			#endregion //создание System.Decimal Д9
			
			#region создание System.Decimal Д10
			{  
                NsgDataFloat Д10 = null;
				if (ObjectList.Contains("Д10"))
                    Д10 = ObjectList["Д10"] as NsgDataFloat;
                else
                    Д10 = new NsgDataFloat();
	//NsgDataFloat
	Д10.IsLoadedFromDll = true;
	Д10.Precision = 2;
	Д10.HideZero = true;
	Д10.DefaultValue = 0M;
	Д10.MinValue = -100000000000000000M;
	Д10.MaxValue = 100000000000000000M;
	Д10.UseCalculator = true;
	Д10.StringFormat = "";
	Д10.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д10.IncludeInPredefined = false;
	Д10.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д10.Required = false;
	Д10.EmptyValue = "";
	Д10.NullAllow = false;
	Д10.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д10.FieldName = "D10";
	Д10.SaveInDatabase = true;
	Д10.InformMetaDataOnValueChanged = false;
	Д10.Visible = true;
	Д10.Name = "Д10";
	Д10.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д10.Description = "Д10";
	Д10.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д10.GroupName = "";
	Д10.Guid = NsgService.StringToGuid("09044b00-1b37-4da8-92e5-ed9c6181cb25");
	
				if (!ObjectList.Contains("Д10"))
                    ObjectList.Add(Д10);
			}
			#endregion //создание System.Decimal Д10
			
			#region создание System.Decimal Д11
			{  
                NsgDataFloat Д11 = null;
				if (ObjectList.Contains("Д11"))
                    Д11 = ObjectList["Д11"] as NsgDataFloat;
                else
                    Д11 = new NsgDataFloat();
	//NsgDataFloat
	Д11.IsLoadedFromDll = true;
	Д11.Precision = 2;
	Д11.HideZero = true;
	Д11.DefaultValue = 0M;
	Д11.MinValue = -100000000000000000M;
	Д11.MaxValue = 100000000000000000M;
	Д11.UseCalculator = true;
	Д11.StringFormat = "";
	Д11.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д11.IncludeInPredefined = false;
	Д11.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д11.Required = false;
	Д11.EmptyValue = "";
	Д11.NullAllow = false;
	Д11.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д11.FieldName = "D11";
	Д11.SaveInDatabase = true;
	Д11.InformMetaDataOnValueChanged = false;
	Д11.Visible = true;
	Д11.Name = "Д11";
	Д11.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д11.Description = "Д11";
	Д11.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д11.GroupName = "";
	Д11.Guid = NsgService.StringToGuid("d3bd2d01-0c7c-4a3f-9447-750405937a69");
	
				if (!ObjectList.Contains("Д11"))
                    ObjectList.Add(Д11);
			}
			#endregion //создание System.Decimal Д11
			
			#region создание System.Decimal Д12
			{  
                NsgDataFloat Д12 = null;
				if (ObjectList.Contains("Д12"))
                    Д12 = ObjectList["Д12"] as NsgDataFloat;
                else
                    Д12 = new NsgDataFloat();
	//NsgDataFloat
	Д12.IsLoadedFromDll = true;
	Д12.Precision = 2;
	Д12.HideZero = true;
	Д12.DefaultValue = 0M;
	Д12.MinValue = -100000000000000000M;
	Д12.MaxValue = 100000000000000000M;
	Д12.UseCalculator = true;
	Д12.StringFormat = "";
	Д12.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д12.IncludeInPredefined = false;
	Д12.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д12.Required = false;
	Д12.EmptyValue = "";
	Д12.NullAllow = false;
	Д12.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д12.FieldName = "D12";
	Д12.SaveInDatabase = true;
	Д12.InformMetaDataOnValueChanged = false;
	Д12.Visible = true;
	Д12.Name = "Д12";
	Д12.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д12.Description = "Д12";
	Д12.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д12.GroupName = "";
	Д12.Guid = NsgService.StringToGuid("783c70a2-1109-4626-9f04-0d8ca24933c3");
	
				if (!ObjectList.Contains("Д12"))
                    ObjectList.Add(Д12);
			}
			#endregion //создание System.Decimal Д12
			
			#region создание System.Decimal Д13
			{  
                NsgDataFloat Д13 = null;
				if (ObjectList.Contains("Д13"))
                    Д13 = ObjectList["Д13"] as NsgDataFloat;
                else
                    Д13 = new NsgDataFloat();
	//NsgDataFloat
	Д13.IsLoadedFromDll = true;
	Д13.Precision = 2;
	Д13.HideZero = true;
	Д13.DefaultValue = 0M;
	Д13.MinValue = -100000000000000000M;
	Д13.MaxValue = 100000000000000000M;
	Д13.UseCalculator = true;
	Д13.StringFormat = "";
	Д13.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д13.IncludeInPredefined = false;
	Д13.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д13.Required = false;
	Д13.EmptyValue = "";
	Д13.NullAllow = false;
	Д13.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д13.FieldName = "D13";
	Д13.SaveInDatabase = true;
	Д13.InformMetaDataOnValueChanged = false;
	Д13.Visible = true;
	Д13.Name = "Д13";
	Д13.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д13.Description = "Д13";
	Д13.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д13.GroupName = "";
	Д13.Guid = NsgService.StringToGuid("fd61b722-9262-4091-a53e-5b81065a8bcb");
	
				if (!ObjectList.Contains("Д13"))
                    ObjectList.Add(Д13);
			}
			#endregion //создание System.Decimal Д13
			
			#region создание System.Decimal Д15
			{  
                NsgDataFloat Д15 = null;
				if (ObjectList.Contains("Д15"))
                    Д15 = ObjectList["Д15"] as NsgDataFloat;
                else
                    Д15 = new NsgDataFloat();
	//NsgDataFloat
	Д15.IsLoadedFromDll = true;
	Д15.Precision = 2;
	Д15.HideZero = true;
	Д15.DefaultValue = 0M;
	Д15.MinValue = -100000000000000000M;
	Д15.MaxValue = 100000000000000000M;
	Д15.UseCalculator = true;
	Д15.StringFormat = "";
	Д15.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д15.IncludeInPredefined = false;
	Д15.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д15.Required = false;
	Д15.EmptyValue = "";
	Д15.NullAllow = false;
	Д15.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д15.FieldName = "D15";
	Д15.SaveInDatabase = true;
	Д15.InformMetaDataOnValueChanged = false;
	Д15.Visible = true;
	Д15.Name = "Д15";
	Д15.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д15.Description = "Д15";
	Д15.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д15.GroupName = "";
	Д15.Guid = NsgService.StringToGuid("11120e56-ed49-493b-8aea-1844d7218664");
	
				if (!ObjectList.Contains("Д15"))
                    ObjectList.Add(Д15);
			}
			#endregion //создание System.Decimal Д15
			
			#region создание System.Decimal Д16
			{  
                NsgDataFloat Д16 = null;
				if (ObjectList.Contains("Д16"))
                    Д16 = ObjectList["Д16"] as NsgDataFloat;
                else
                    Д16 = new NsgDataFloat();
	//NsgDataFloat
	Д16.IsLoadedFromDll = true;
	Д16.Precision = 2;
	Д16.HideZero = true;
	Д16.DefaultValue = 0M;
	Д16.MinValue = -100000000000000000M;
	Д16.MaxValue = 100000000000000000M;
	Д16.UseCalculator = true;
	Д16.StringFormat = "";
	Д16.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д16.IncludeInPredefined = false;
	Д16.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д16.Required = false;
	Д16.EmptyValue = "";
	Д16.NullAllow = false;
	Д16.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д16.FieldName = "D16";
	Д16.SaveInDatabase = true;
	Д16.InformMetaDataOnValueChanged = false;
	Д16.Visible = true;
	Д16.Name = "Д16";
	Д16.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д16.Description = "Д16";
	Д16.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д16.GroupName = "";
	Д16.Guid = NsgService.StringToGuid("bbae4fd6-5aa2-4ae1-aa3f-0d8043707acf");
	
				if (!ObjectList.Contains("Д16"))
                    ObjectList.Add(Д16);
			}
			#endregion //создание System.Decimal Д16
			
			#region создание System.Decimal Д17
			{  
                NsgDataFloat Д17 = null;
				if (ObjectList.Contains("Д17"))
                    Д17 = ObjectList["Д17"] as NsgDataFloat;
                else
                    Д17 = new NsgDataFloat();
	//NsgDataFloat
	Д17.IsLoadedFromDll = true;
	Д17.Precision = 2;
	Д17.HideZero = true;
	Д17.DefaultValue = 0M;
	Д17.MinValue = -100000000000000000M;
	Д17.MaxValue = 100000000000000000M;
	Д17.UseCalculator = true;
	Д17.StringFormat = "";
	Д17.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д17.IncludeInPredefined = false;
	Д17.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д17.Required = false;
	Д17.EmptyValue = "";
	Д17.NullAllow = false;
	Д17.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д17.FieldName = "D17";
	Д17.SaveInDatabase = true;
	Д17.InformMetaDataOnValueChanged = false;
	Д17.Visible = true;
	Д17.Name = "Д17";
	Д17.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д17.Description = "Д17";
	Д17.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д17.GroupName = "";
	Д17.Guid = NsgService.StringToGuid("86f28f42-c350-4239-ad2b-5fbbaa585e93");
	
				if (!ObjectList.Contains("Д17"))
                    ObjectList.Add(Д17);
			}
			#endregion //создание System.Decimal Д17
			
			#region создание System.Decimal Д18
			{  
                NsgDataFloat Д18 = null;
				if (ObjectList.Contains("Д18"))
                    Д18 = ObjectList["Д18"] as NsgDataFloat;
                else
                    Д18 = new NsgDataFloat();
	//NsgDataFloat
	Д18.IsLoadedFromDll = true;
	Д18.Precision = 2;
	Д18.HideZero = true;
	Д18.DefaultValue = 0M;
	Д18.MinValue = -100000000000000000M;
	Д18.MaxValue = 100000000000000000M;
	Д18.UseCalculator = true;
	Д18.StringFormat = "";
	Д18.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д18.IncludeInPredefined = false;
	Д18.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д18.Required = false;
	Д18.EmptyValue = "";
	Д18.NullAllow = false;
	Д18.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д18.FieldName = "D18";
	Д18.SaveInDatabase = true;
	Д18.InformMetaDataOnValueChanged = false;
	Д18.Visible = true;
	Д18.Name = "Д18";
	Д18.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д18.Description = "Д18";
	Д18.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д18.GroupName = "";
	Д18.Guid = NsgService.StringToGuid("4065af92-3d9e-43da-94cb-ca7d59e5e1ef");
	
				if (!ObjectList.Contains("Д18"))
                    ObjectList.Add(Д18);
			}
			#endregion //создание System.Decimal Д18
			
			#region создание System.Decimal Д19
			{  
                NsgDataFloat Д19 = null;
				if (ObjectList.Contains("Д19"))
                    Д19 = ObjectList["Д19"] as NsgDataFloat;
                else
                    Д19 = new NsgDataFloat();
	//NsgDataFloat
	Д19.IsLoadedFromDll = true;
	Д19.Precision = 2;
	Д19.HideZero = true;
	Д19.DefaultValue = 0M;
	Д19.MinValue = -100000000000000000M;
	Д19.MaxValue = 100000000000000000M;
	Д19.UseCalculator = true;
	Д19.StringFormat = "";
	Д19.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д19.IncludeInPredefined = false;
	Д19.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д19.Required = false;
	Д19.EmptyValue = "";
	Д19.NullAllow = false;
	Д19.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д19.FieldName = "D19";
	Д19.SaveInDatabase = true;
	Д19.InformMetaDataOnValueChanged = false;
	Д19.Visible = true;
	Д19.Name = "Д19";
	Д19.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д19.Description = "Д19";
	Д19.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д19.GroupName = "";
	Д19.Guid = NsgService.StringToGuid("df000434-54bb-4dac-a6ba-7e93378f2506");
	
				if (!ObjectList.Contains("Д19"))
                    ObjectList.Add(Д19);
			}
			#endregion //создание System.Decimal Д19
			
			#region создание System.Decimal Д20
			{  
                NsgDataFloat Д20 = null;
				if (ObjectList.Contains("Д20"))
                    Д20 = ObjectList["Д20"] as NsgDataFloat;
                else
                    Д20 = new NsgDataFloat();
	//NsgDataFloat
	Д20.IsLoadedFromDll = true;
	Д20.Precision = 2;
	Д20.HideZero = true;
	Д20.DefaultValue = 0M;
	Д20.MinValue = -100000000000000000M;
	Д20.MaxValue = 100000000000000000M;
	Д20.UseCalculator = true;
	Д20.StringFormat = "";
	Д20.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д20.IncludeInPredefined = false;
	Д20.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д20.Required = false;
	Д20.EmptyValue = "";
	Д20.NullAllow = false;
	Д20.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д20.FieldName = "D20";
	Д20.SaveInDatabase = true;
	Д20.InformMetaDataOnValueChanged = false;
	Д20.Visible = true;
	Д20.Name = "Д20";
	Д20.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д20.Description = "Д20";
	Д20.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д20.GroupName = "";
	Д20.Guid = NsgService.StringToGuid("0946b997-f342-4114-a4fc-135392a3c586");
	
				if (!ObjectList.Contains("Д20"))
                    ObjectList.Add(Д20);
			}
			#endregion //создание System.Decimal Д20
			
			#region создание System.Decimal Д21
			{  
                NsgDataFloat Д21 = null;
				if (ObjectList.Contains("Д21"))
                    Д21 = ObjectList["Д21"] as NsgDataFloat;
                else
                    Д21 = new NsgDataFloat();
	//NsgDataFloat
	Д21.IsLoadedFromDll = true;
	Д21.Precision = 2;
	Д21.HideZero = true;
	Д21.DefaultValue = 0M;
	Д21.MinValue = -100000000000000000M;
	Д21.MaxValue = 100000000000000000M;
	Д21.UseCalculator = true;
	Д21.StringFormat = "";
	Д21.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д21.IncludeInPredefined = false;
	Д21.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д21.Required = false;
	Д21.EmptyValue = "";
	Д21.NullAllow = false;
	Д21.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д21.FieldName = "D21";
	Д21.SaveInDatabase = true;
	Д21.InformMetaDataOnValueChanged = false;
	Д21.Visible = true;
	Д21.Name = "Д21";
	Д21.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д21.Description = "Д21";
	Д21.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д21.GroupName = "";
	Д21.Guid = NsgService.StringToGuid("00aeeace-34c5-45a8-ba24-118d1970bf82");
	
				if (!ObjectList.Contains("Д21"))
                    ObjectList.Add(Д21);
			}
			#endregion //создание System.Decimal Д21
			
			#region создание System.Decimal Д22
			{  
                NsgDataFloat Д22 = null;
				if (ObjectList.Contains("Д22"))
                    Д22 = ObjectList["Д22"] as NsgDataFloat;
                else
                    Д22 = new NsgDataFloat();
	//NsgDataFloat
	Д22.IsLoadedFromDll = true;
	Д22.Precision = 2;
	Д22.HideZero = true;
	Д22.DefaultValue = 0M;
	Д22.MinValue = -100000000000000000M;
	Д22.MaxValue = 100000000000000000M;
	Д22.UseCalculator = true;
	Д22.StringFormat = "";
	Д22.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д22.IncludeInPredefined = false;
	Д22.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д22.Required = false;
	Д22.EmptyValue = "";
	Д22.NullAllow = false;
	Д22.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д22.FieldName = "D22";
	Д22.SaveInDatabase = true;
	Д22.InformMetaDataOnValueChanged = false;
	Д22.Visible = true;
	Д22.Name = "Д22";
	Д22.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д22.Description = "Д22";
	Д22.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д22.GroupName = "";
	Д22.Guid = NsgService.StringToGuid("c5b5ebf8-a5ff-41fa-b11e-7871cba9a647");
	
				if (!ObjectList.Contains("Д22"))
                    ObjectList.Add(Д22);
			}
			#endregion //создание System.Decimal Д22
			
			#region создание System.Decimal Д23
			{  
                NsgDataFloat Д23 = null;
				if (ObjectList.Contains("Д23"))
                    Д23 = ObjectList["Д23"] as NsgDataFloat;
                else
                    Д23 = new NsgDataFloat();
	//NsgDataFloat
	Д23.IsLoadedFromDll = true;
	Д23.Precision = 2;
	Д23.HideZero = true;
	Д23.DefaultValue = 0M;
	Д23.MinValue = -100000000000000000M;
	Д23.MaxValue = 100000000000000000M;
	Д23.UseCalculator = true;
	Д23.StringFormat = "";
	Д23.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д23.IncludeInPredefined = false;
	Д23.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д23.Required = false;
	Д23.EmptyValue = "";
	Д23.NullAllow = false;
	Д23.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д23.FieldName = "D23";
	Д23.SaveInDatabase = true;
	Д23.InformMetaDataOnValueChanged = false;
	Д23.Visible = true;
	Д23.Name = "Д23";
	Д23.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д23.Description = "Д23";
	Д23.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д23.GroupName = "";
	Д23.Guid = NsgService.StringToGuid("f273ea45-f4fd-4bed-8e50-0548dcf65fbe");
	
				if (!ObjectList.Contains("Д23"))
                    ObjectList.Add(Д23);
			}
			#endregion //создание System.Decimal Д23
			
			#region создание System.Decimal Д24
			{  
                NsgDataFloat Д24 = null;
				if (ObjectList.Contains("Д24"))
                    Д24 = ObjectList["Д24"] as NsgDataFloat;
                else
                    Д24 = new NsgDataFloat();
	//NsgDataFloat
	Д24.IsLoadedFromDll = true;
	Д24.Precision = 2;
	Д24.HideZero = true;
	Д24.DefaultValue = 0M;
	Д24.MinValue = -100000000000000000M;
	Д24.MaxValue = 100000000000000000M;
	Д24.UseCalculator = true;
	Д24.StringFormat = "";
	Д24.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д24.IncludeInPredefined = false;
	Д24.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д24.Required = false;
	Д24.EmptyValue = "";
	Д24.NullAllow = false;
	Д24.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д24.FieldName = "D24";
	Д24.SaveInDatabase = true;
	Д24.InformMetaDataOnValueChanged = false;
	Д24.Visible = true;
	Д24.Name = "Д24";
	Д24.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д24.Description = "Д24";
	Д24.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д24.GroupName = "";
	Д24.Guid = NsgService.StringToGuid("d0576148-293e-4cc6-98f9-f5a58a9e24a0");
	
				if (!ObjectList.Contains("Д24"))
                    ObjectList.Add(Д24);
			}
			#endregion //создание System.Decimal Д24
			
			#region создание System.Decimal Д26
			{  
                NsgDataFloat Д26 = null;
				if (ObjectList.Contains("Д26"))
                    Д26 = ObjectList["Д26"] as NsgDataFloat;
                else
                    Д26 = new NsgDataFloat();
	//NsgDataFloat
	Д26.IsLoadedFromDll = true;
	Д26.Precision = 2;
	Д26.HideZero = true;
	Д26.DefaultValue = 0M;
	Д26.MinValue = -100000000000000000M;
	Д26.MaxValue = 100000000000000000M;
	Д26.UseCalculator = true;
	Д26.StringFormat = "";
	Д26.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д26.IncludeInPredefined = false;
	Д26.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д26.Required = false;
	Д26.EmptyValue = "";
	Д26.NullAllow = false;
	Д26.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д26.FieldName = "D26";
	Д26.SaveInDatabase = true;
	Д26.InformMetaDataOnValueChanged = false;
	Д26.Visible = true;
	Д26.Name = "Д26";
	Д26.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д26.Description = "Д26";
	Д26.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д26.GroupName = "";
	Д26.Guid = NsgService.StringToGuid("b612427c-205b-4289-bfa6-c968f40d3dd7");
	
				if (!ObjectList.Contains("Д26"))
                    ObjectList.Add(Д26);
			}
			#endregion //создание System.Decimal Д26
			
			#region создание System.Decimal Д1
			{  
                NsgDataFloat Д1 = null;
				if (ObjectList.Contains("Д1"))
                    Д1 = ObjectList["Д1"] as NsgDataFloat;
                else
                    Д1 = new NsgDataFloat();
	//NsgDataFloat
	Д1.IsLoadedFromDll = true;
	Д1.Precision = 2;
	Д1.HideZero = true;
	Д1.DefaultValue = 0M;
	Д1.MinValue = -100000000000000000M;
	Д1.MaxValue = 100000000000000000M;
	Д1.UseCalculator = true;
	Д1.StringFormat = "";
	Д1.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Д1.IncludeInPredefined = false;
	Д1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Д1.Required = false;
	Д1.EmptyValue = "";
	Д1.NullAllow = false;
	Д1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Д1.FieldName = "D1";
	Д1.SaveInDatabase = true;
	Д1.InformMetaDataOnValueChanged = false;
	Д1.Visible = true;
	Д1.Name = "Д1";
	Д1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Д1.Description = "Д1";
	Д1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Д1.GroupName = "";
	Д1.Guid = NsgService.StringToGuid("5e1ba977-c6fb-4eee-99f2-931d74e6479c");
	
				if (!ObjectList.Contains("Д1"))
                    ObjectList.Add(Д1);
			}
			#endregion //создание System.Decimal Д1
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Документы.ОтработанныеМесяцы";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДокументыОтработанныеМесяцыТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("8dcec5fe-e3c0-4dbc-9caf-80261c74f684");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_DokumentyOtrabotann";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документы отработанные месяцы таблица";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "_SystemTables";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTable

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTable.Names
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
            /// Владелец
            /// </summary>
            public static String Владелец
            {
                get
                {
                    return "Владелец";
                }
            }
            
            /// <summary>
            /// Номер строки
            /// </summary>
            public static String НомерСтроки
            {
                get
                {
                    return "НомерСтроки";
                }
            }
            
            /// <summary>
            /// Техника
            /// </summary>
            public static String Техника
            {
                get
                {
                    return "Техника";
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
            /// Д2
            /// </summary>
            public static String Д2
            {
                get
                {
                    return "Д2";
                }
            }
            
            /// <summary>
            /// Тариф
            /// </summary>
            public static String Тариф
            {
                get
                {
                    return "Тариф";
                }
            }
            
            /// <summary>
            /// Д3
            /// </summary>
            public static String Д3
            {
                get
                {
                    return "Д3";
                }
            }
            
            /// <summary>
            /// Д14
            /// </summary>
            public static String Д14
            {
                get
                {
                    return "Д14";
                }
            }
            
            /// <summary>
            /// Д25
            /// </summary>
            public static String Д25
            {
                get
                {
                    return "Д25";
                }
            }
            
            /// <summary>
            /// Д27
            /// </summary>
            public static String Д27
            {
                get
                {
                    return "Д27";
                }
            }
            
            /// <summary>
            /// Д28
            /// </summary>
            public static String Д28
            {
                get
                {
                    return "Д28";
                }
            }
            
            /// <summary>
            /// Д29
            /// </summary>
            public static String Д29
            {
                get
                {
                    return "Д29";
                }
            }
            
            /// <summary>
            /// Д30
            /// </summary>
            public static String Д30
            {
                get
                {
                    return "Д30";
                }
            }
            
            /// <summary>
            /// Д31
            /// </summary>
            public static String Д31
            {
                get
                {
                    return "Д31";
                }
            }
            
            /// <summary>
            /// Д4
            /// </summary>
            public static String Д4
            {
                get
                {
                    return "Д4";
                }
            }
            
            /// <summary>
            /// Д5
            /// </summary>
            public static String Д5
            {
                get
                {
                    return "Д5";
                }
            }
            
            /// <summary>
            /// Д6
            /// </summary>
            public static String Д6
            {
                get
                {
                    return "Д6";
                }
            }
            
            /// <summary>
            /// Д7
            /// </summary>
            public static String Д7
            {
                get
                {
                    return "Д7";
                }
            }
            
            /// <summary>
            /// Д8
            /// </summary>
            public static String Д8
            {
                get
                {
                    return "Д8";
                }
            }
            
            /// <summary>
            /// Д9
            /// </summary>
            public static String Д9
            {
                get
                {
                    return "Д9";
                }
            }
            
            /// <summary>
            /// Д10
            /// </summary>
            public static String Д10
            {
                get
                {
                    return "Д10";
                }
            }
            
            /// <summary>
            /// Д11
            /// </summary>
            public static String Д11
            {
                get
                {
                    return "Д11";
                }
            }
            
            /// <summary>
            /// Д12
            /// </summary>
            public static String Д12
            {
                get
                {
                    return "Д12";
                }
            }
            
            /// <summary>
            /// Д13
            /// </summary>
            public static String Д13
            {
                get
                {
                    return "Д13";
                }
            }
            
            /// <summary>
            /// Д15
            /// </summary>
            public static String Д15
            {
                get
                {
                    return "Д15";
                }
            }
            
            /// <summary>
            /// Д16
            /// </summary>
            public static String Д16
            {
                get
                {
                    return "Д16";
                }
            }
            
            /// <summary>
            /// Д17
            /// </summary>
            public static String Д17
            {
                get
                {
                    return "Д17";
                }
            }
            
            /// <summary>
            /// Д18
            /// </summary>
            public static String Д18
            {
                get
                {
                    return "Д18";
                }
            }
            
            /// <summary>
            /// Д19
            /// </summary>
            public static String Д19
            {
                get
                {
                    return "Д19";
                }
            }
            
            /// <summary>
            /// Д20
            /// </summary>
            public static String Д20
            {
                get
                {
                    return "Д20";
                }
            }
            
            /// <summary>
            /// Д21
            /// </summary>
            public static String Д21
            {
                get
                {
                    return "Д21";
                }
            }
            
            /// <summary>
            /// Д22
            /// </summary>
            public static String Д22
            {
                get
                {
                    return "Д22";
                }
            }
            
            /// <summary>
            /// Д23
            /// </summary>
            public static String Д23
            {
                get
                {
                    return "Д23";
                }
            }
            
            /// <summary>
            /// Д24
            /// </summary>
            public static String Д24
            {
                get
                {
                    return "Д24";
                }
            }
            
            /// <summary>
            /// Д26
            /// </summary>
            public static String Д26
            {
                get
                {
                    return "Д26";
                }
            }
            
            /// <summary>
            /// Д1
            /// </summary>
            public static String Д1
            {
                get
                {
                    return "Д1";
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
                    descriptor.Name = "ДокументыОтработанныеМесяцыТаблица";
                    descriptor.GroupName = "_SystemTables";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "_SystemTables.ДокументыОтработанныеМесяцыТаблица";
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
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Документы.ОтработанныеМесяцы")]
        public NsgSoft.DataObjects.NsgReferencedObject Владелец
        {
            get
            {
				 NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__Владелец.Referent;
            }
            set
            {
                NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                __Владелец.Referent = value;
            }
        }
        
        /// <summary>
        /// Номер строки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСтроки
        {
            get
            {
				 NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                 return (System.Int64)__НомерСтроки.Value;
            }
            set
            {
                NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                __НомерСтроки.Value = value;
            }
        }
        
        /// <summary>
        /// Техника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Техника Техника
        {
            get
            {
				 NsgDataTypedReference __Техника = ObjectList["Техника"] as NsgDataTypedReference;
                 return (Мониторинг.Техника)__Техника.Referent;
            }
            set
            {
                NsgDataTypedReference __Техника = ObjectList["Техника"] as NsgDataTypedReference;
                __Техника.Referent = value;
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
        /// Д2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д2
        {
            get
            {
				 NsgDataFloat __Д2 = ObjectList["Д2"] as NsgDataFloat;
                 return (System.Decimal)__Д2.Value;
            }
            set
            {
                NsgDataFloat __Д2 = ObjectList["Д2"] as NsgDataFloat;
                __Д2.Value = value;
            }
        }
        
        /// <summary>
        /// Тариф
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Тарифы Тариф
        {
            get
            {
				 NsgDataTypedReference __Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                 return (Мониторинг.Тарифы)__Тариф.Referent;
            }
            set
            {
                NsgDataTypedReference __Тариф = ObjectList["Тариф"] as NsgDataTypedReference;
                __Тариф.Referent = value;
            }
        }
        
        /// <summary>
        /// Д3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д3
        {
            get
            {
				 NsgDataFloat __Д3 = ObjectList["Д3"] as NsgDataFloat;
                 return (System.Decimal)__Д3.Value;
            }
            set
            {
                NsgDataFloat __Д3 = ObjectList["Д3"] as NsgDataFloat;
                __Д3.Value = value;
            }
        }
        
        /// <summary>
        /// Д14
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д14
        {
            get
            {
				 NsgDataFloat __Д14 = ObjectList["Д14"] as NsgDataFloat;
                 return (System.Decimal)__Д14.Value;
            }
            set
            {
                NsgDataFloat __Д14 = ObjectList["Д14"] as NsgDataFloat;
                __Д14.Value = value;
            }
        }
        
        /// <summary>
        /// Д25
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д25
        {
            get
            {
				 NsgDataFloat __Д25 = ObjectList["Д25"] as NsgDataFloat;
                 return (System.Decimal)__Д25.Value;
            }
            set
            {
                NsgDataFloat __Д25 = ObjectList["Д25"] as NsgDataFloat;
                __Д25.Value = value;
            }
        }
        
        /// <summary>
        /// Д27
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д27
        {
            get
            {
				 NsgDataFloat __Д27 = ObjectList["Д27"] as NsgDataFloat;
                 return (System.Decimal)__Д27.Value;
            }
            set
            {
                NsgDataFloat __Д27 = ObjectList["Д27"] as NsgDataFloat;
                __Д27.Value = value;
            }
        }
        
        /// <summary>
        /// Д28
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д28
        {
            get
            {
				 NsgDataFloat __Д28 = ObjectList["Д28"] as NsgDataFloat;
                 return (System.Decimal)__Д28.Value;
            }
            set
            {
                NsgDataFloat __Д28 = ObjectList["Д28"] as NsgDataFloat;
                __Д28.Value = value;
            }
        }
        
        /// <summary>
        /// Д29
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д29
        {
            get
            {
				 NsgDataFloat __Д29 = ObjectList["Д29"] as NsgDataFloat;
                 return (System.Decimal)__Д29.Value;
            }
            set
            {
                NsgDataFloat __Д29 = ObjectList["Д29"] as NsgDataFloat;
                __Д29.Value = value;
            }
        }
        
        /// <summary>
        /// Д30
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д30
        {
            get
            {
				 NsgDataFloat __Д30 = ObjectList["Д30"] as NsgDataFloat;
                 return (System.Decimal)__Д30.Value;
            }
            set
            {
                NsgDataFloat __Д30 = ObjectList["Д30"] as NsgDataFloat;
                __Д30.Value = value;
            }
        }
        
        /// <summary>
        /// Д31
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д31
        {
            get
            {
				 NsgDataFloat __Д31 = ObjectList["Д31"] as NsgDataFloat;
                 return (System.Decimal)__Д31.Value;
            }
            set
            {
                NsgDataFloat __Д31 = ObjectList["Д31"] as NsgDataFloat;
                __Д31.Value = value;
            }
        }
        
        /// <summary>
        /// Д4
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д4
        {
            get
            {
				 NsgDataFloat __Д4 = ObjectList["Д4"] as NsgDataFloat;
                 return (System.Decimal)__Д4.Value;
            }
            set
            {
                NsgDataFloat __Д4 = ObjectList["Д4"] as NsgDataFloat;
                __Д4.Value = value;
            }
        }
        
        /// <summary>
        /// Д5
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д5
        {
            get
            {
				 NsgDataFloat __Д5 = ObjectList["Д5"] as NsgDataFloat;
                 return (System.Decimal)__Д5.Value;
            }
            set
            {
                NsgDataFloat __Д5 = ObjectList["Д5"] as NsgDataFloat;
                __Д5.Value = value;
            }
        }
        
        /// <summary>
        /// Д6
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д6
        {
            get
            {
				 NsgDataFloat __Д6 = ObjectList["Д6"] as NsgDataFloat;
                 return (System.Decimal)__Д6.Value;
            }
            set
            {
                NsgDataFloat __Д6 = ObjectList["Д6"] as NsgDataFloat;
                __Д6.Value = value;
            }
        }
        
        /// <summary>
        /// Д7
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д7
        {
            get
            {
				 NsgDataFloat __Д7 = ObjectList["Д7"] as NsgDataFloat;
                 return (System.Decimal)__Д7.Value;
            }
            set
            {
                NsgDataFloat __Д7 = ObjectList["Д7"] as NsgDataFloat;
                __Д7.Value = value;
            }
        }
        
        /// <summary>
        /// Д8
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д8
        {
            get
            {
				 NsgDataFloat __Д8 = ObjectList["Д8"] as NsgDataFloat;
                 return (System.Decimal)__Д8.Value;
            }
            set
            {
                NsgDataFloat __Д8 = ObjectList["Д8"] as NsgDataFloat;
                __Д8.Value = value;
            }
        }
        
        /// <summary>
        /// Д9
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д9
        {
            get
            {
				 NsgDataFloat __Д9 = ObjectList["Д9"] as NsgDataFloat;
                 return (System.Decimal)__Д9.Value;
            }
            set
            {
                NsgDataFloat __Д9 = ObjectList["Д9"] as NsgDataFloat;
                __Д9.Value = value;
            }
        }
        
        /// <summary>
        /// Д10
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д10
        {
            get
            {
				 NsgDataFloat __Д10 = ObjectList["Д10"] as NsgDataFloat;
                 return (System.Decimal)__Д10.Value;
            }
            set
            {
                NsgDataFloat __Д10 = ObjectList["Д10"] as NsgDataFloat;
                __Д10.Value = value;
            }
        }
        
        /// <summary>
        /// Д11
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д11
        {
            get
            {
				 NsgDataFloat __Д11 = ObjectList["Д11"] as NsgDataFloat;
                 return (System.Decimal)__Д11.Value;
            }
            set
            {
                NsgDataFloat __Д11 = ObjectList["Д11"] as NsgDataFloat;
                __Д11.Value = value;
            }
        }
        
        /// <summary>
        /// Д12
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д12
        {
            get
            {
				 NsgDataFloat __Д12 = ObjectList["Д12"] as NsgDataFloat;
                 return (System.Decimal)__Д12.Value;
            }
            set
            {
                NsgDataFloat __Д12 = ObjectList["Д12"] as NsgDataFloat;
                __Д12.Value = value;
            }
        }
        
        /// <summary>
        /// Д13
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д13
        {
            get
            {
				 NsgDataFloat __Д13 = ObjectList["Д13"] as NsgDataFloat;
                 return (System.Decimal)__Д13.Value;
            }
            set
            {
                NsgDataFloat __Д13 = ObjectList["Д13"] as NsgDataFloat;
                __Д13.Value = value;
            }
        }
        
        /// <summary>
        /// Д15
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д15
        {
            get
            {
				 NsgDataFloat __Д15 = ObjectList["Д15"] as NsgDataFloat;
                 return (System.Decimal)__Д15.Value;
            }
            set
            {
                NsgDataFloat __Д15 = ObjectList["Д15"] as NsgDataFloat;
                __Д15.Value = value;
            }
        }
        
        /// <summary>
        /// Д16
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д16
        {
            get
            {
				 NsgDataFloat __Д16 = ObjectList["Д16"] as NsgDataFloat;
                 return (System.Decimal)__Д16.Value;
            }
            set
            {
                NsgDataFloat __Д16 = ObjectList["Д16"] as NsgDataFloat;
                __Д16.Value = value;
            }
        }
        
        /// <summary>
        /// Д17
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д17
        {
            get
            {
				 NsgDataFloat __Д17 = ObjectList["Д17"] as NsgDataFloat;
                 return (System.Decimal)__Д17.Value;
            }
            set
            {
                NsgDataFloat __Д17 = ObjectList["Д17"] as NsgDataFloat;
                __Д17.Value = value;
            }
        }
        
        /// <summary>
        /// Д18
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д18
        {
            get
            {
				 NsgDataFloat __Д18 = ObjectList["Д18"] as NsgDataFloat;
                 return (System.Decimal)__Д18.Value;
            }
            set
            {
                NsgDataFloat __Д18 = ObjectList["Д18"] as NsgDataFloat;
                __Д18.Value = value;
            }
        }
        
        /// <summary>
        /// Д19
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д19
        {
            get
            {
				 NsgDataFloat __Д19 = ObjectList["Д19"] as NsgDataFloat;
                 return (System.Decimal)__Д19.Value;
            }
            set
            {
                NsgDataFloat __Д19 = ObjectList["Д19"] as NsgDataFloat;
                __Д19.Value = value;
            }
        }
        
        /// <summary>
        /// Д20
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д20
        {
            get
            {
				 NsgDataFloat __Д20 = ObjectList["Д20"] as NsgDataFloat;
                 return (System.Decimal)__Д20.Value;
            }
            set
            {
                NsgDataFloat __Д20 = ObjectList["Д20"] as NsgDataFloat;
                __Д20.Value = value;
            }
        }
        
        /// <summary>
        /// Д21
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д21
        {
            get
            {
				 NsgDataFloat __Д21 = ObjectList["Д21"] as NsgDataFloat;
                 return (System.Decimal)__Д21.Value;
            }
            set
            {
                NsgDataFloat __Д21 = ObjectList["Д21"] as NsgDataFloat;
                __Д21.Value = value;
            }
        }
        
        /// <summary>
        /// Д22
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д22
        {
            get
            {
				 NsgDataFloat __Д22 = ObjectList["Д22"] as NsgDataFloat;
                 return (System.Decimal)__Д22.Value;
            }
            set
            {
                NsgDataFloat __Д22 = ObjectList["Д22"] as NsgDataFloat;
                __Д22.Value = value;
            }
        }
        
        /// <summary>
        /// Д23
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д23
        {
            get
            {
				 NsgDataFloat __Д23 = ObjectList["Д23"] as NsgDataFloat;
                 return (System.Decimal)__Д23.Value;
            }
            set
            {
                NsgDataFloat __Д23 = ObjectList["Д23"] as NsgDataFloat;
                __Д23.Value = value;
            }
        }
        
        /// <summary>
        /// Д24
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д24
        {
            get
            {
				 NsgDataFloat __Д24 = ObjectList["Д24"] as NsgDataFloat;
                 return (System.Decimal)__Д24.Value;
            }
            set
            {
                NsgDataFloat __Д24 = ObjectList["Д24"] as NsgDataFloat;
                __Д24.Value = value;
            }
        }
        
        /// <summary>
        /// Д26
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д26
        {
            get
            {
				 NsgDataFloat __Д26 = ObjectList["Д26"] as NsgDataFloat;
                 return (System.Decimal)__Д26.Value;
            }
            set
            {
                NsgDataFloat __Д26 = ObjectList["Д26"] as NsgDataFloat;
                __Д26.Value = value;
            }
        }
        
        /// <summary>
        /// Д1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Д1
        {
            get
            {
				 NsgDataFloat __Д1 = ObjectList["Д1"] as NsgDataFloat;
                 return (System.Decimal)__Д1.Value;
            }
            set
            {
                NsgDataFloat __Д1 = ObjectList["Д1"] as NsgDataFloat;
                __Д1.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new ДокументыОтработанныеМесяцыТаблица.Строка NewRow()
        {
            return newRow(null) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new ДокументыОтработанныеМесяцыТаблица.Строка(this);
            return base.newRow(row) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public ДокументыОтработанныеМесяцыТаблица.Строка NewRow(ДокументыОтработанныеМесяцыТаблица.Строка inRow)
        {
            ДокументыОтработанныеМесяцыТаблица.Строка row = inRow.Clone as ДокументыОтработанныеМесяцыТаблица.Строка;
            return base.newRow(row) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new ДокументыОтработанныеМесяцыТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new ДокументыОтработанныеМесяцыТаблица.Строка GetEtalonRow()
        {
            ДокументыОтработанныеМесяцыТаблица.Строка row = new ДокументыОтработанныеМесяцыТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private ДокументыОтработанныеМесяцыТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            ДокументыОтработанныеМесяцыТаблица.Строка[] res = new ДокументыОтработанныеМесяцыТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<ДокументыОтработанныеМесяцыТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<ДокументыОтработанныеМесяцыТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new ДокументыОтработанныеМесяцыТаблица.Строка[] AllRows
        {
            get
            {
                return convertRowsArray(base.AllRows);
            }
        }

        /// <summary>
        /// Получить строку таблицы
        /// </summary>
        /// <param name="inName">Идентификатор строки.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыОтработанныеМесяцыТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as ДокументыОтработанныеМесяцыТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private ДокументыОтработанныеМесяцыТаблица[] convertArray(NsgMultipleObject[] array)
        {
            ДокументыОтработанныеМесяцыТаблица[] res = new ДокументыОтработанныеМесяцыТаблица[array.Length];
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
        public new virtual ДокументыОтработанныеМесяцыТаблица[] FindAll(NsgCompare compare)
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
        public new virtual ДокументыОтработанныеМесяцыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ДокументыОтработанныеМесяцыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ДокументыОтработанныеМесяцыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ДокументыОтработанныеМесяцыТаблица(this as NsgObject);
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
                base.NSGType = typeof(ДокументыОтработанныеМесяцыТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ДокументыОтработанныеМесяцыТаблица Value
            {
                get
                {
                    return (ДокументыОтработанныеМесяцыТаблица)base.Value;
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
                    return "s_NsgDataTable";
                }
            }
        }

    }

}
