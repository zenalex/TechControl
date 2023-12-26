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
    
    [NsgTypeName("NsgDataTable", Guid = "1e47e65a-df14-4b73-96d7-0dc7cdf6be70")]
    public partial class ДокументыГрафикРаботыОбъектаТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected ДокументыГрафикРаботыОбъектаТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ДокументыГрафикРаботыОбъектаТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ДокументыГрафикРаботыОбъектаТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("1e47e65a-df14-4b73-96d7-0dc7cdf6be70"));
            if (obj == null)
                obj = new ДокументыГрафикРаботыОбъектаТаблица();
            return obj as ДокументыГрафикРаботыОбъектаТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("916070f0-a8f8-495d-82c7-227116925601");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("7d117c49-711e-4022-93e0-8f979bb1df3f");
	
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
	Владелец.FilterForConfigurator = "Документы.ГрафикРаботыОбъекта";
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
	Владелец.Guid = NsgService.StringToGuid("72683c94-a510-4b45-aeca-7d9ef0e05c9d");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("c4f6c720-a9d6-4ea3-bb45-48bc3f994032");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.DateTime ДатаКонкретныйДень
			{  
                NsgDataDateTime ДатаКонкретныйДень = null;
				if (ObjectList.Contains("ДатаКонкретныйДень"))
                    ДатаКонкретныйДень = ObjectList["ДатаКонкретныйДень"] as NsgDataDateTime;
                else
                    ДатаКонкретныйДень = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаКонкретныйДень.IsLoadedFromDll = true;
	ДатаКонкретныйДень.Format = NsgSoft.Common.NsgDateTimeFormat.Date;
	ДатаКонкретныйДень.StringFormat = "";
	ДатаКонкретныйДень.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаКонкретныйДень.IncludeInPredefined = false;
	ДатаКонкретныйДень.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаКонкретныйДень.Required = false;
	ДатаКонкретныйДень.EmptyValue = "";
	ДатаКонкретныйДень.NullAllow = false;
	ДатаКонкретныйДень.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаКонкретныйДень.FieldName = "DataKonkretnyijDen";
	ДатаКонкретныйДень.SaveInDatabase = true;
	ДатаКонкретныйДень.InformMetaDataOnValueChanged = false;
	ДатаКонкретныйДень.Visible = true;
	ДатаКонкретныйДень.Name = "ДатаКонкретныйДень";
	ДатаКонкретныйДень.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаКонкретныйДень.Description = "Дата конкретный день";
	ДатаКонкретныйДень.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаКонкретныйДень.GroupName = "";
	ДатаКонкретныйДень.Guid = NsgService.StringToGuid("6d4f0881-6df4-4be7-a059-439e56d473f9");
	
				if (!ObjectList.Contains("ДатаКонкретныйДень"))
                    ObjectList.Add(ДатаКонкретныйДень);
			}
			#endregion //создание System.DateTime ДатаКонкретныйДень
			
			#region создание Мониторинг.ДеньНедели ДеньНедели
			{  
                NsgDataEnumReference ДеньНедели = null;
				if (ObjectList.Contains("ДеньНедели"))
                    ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                else
                    ДеньНедели = new NsgDataEnumReference();
	//NsgDataEnumReference
	ДеньНедели.IsLoadedFromDll = true;
	ДеньНедели.ReferentGroup = "Мониторинг";
	ДеньНедели.ReferentName = "ДеньНедели";
	ДеньНедели.SaveInDatabase = true;
	ДеньНедели.OwnerName = "";
	ДеньНедели.AllowEmptyOwner = false;
	ДеньНедели.StringFormat = "";
	ДеньНедели.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДеньНедели.IncludeInPredefined = false;
	ДеньНедели.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДеньНедели.Required = false;
	ДеньНедели.EmptyValue = "";
	ДеньНедели.NullAllow = false;
	ДеньНедели.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДеньНедели.FieldName = "DenNedeli";
	ДеньНедели.InformMetaDataOnValueChanged = false;
	ДеньНедели.Visible = true;
	ДеньНедели.Name = "ДеньНедели";
	ДеньНедели.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДеньНедели.Description = "День недели";
	ДеньНедели.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДеньНедели.GroupName = "";
	ДеньНедели.Guid = NsgService.StringToGuid("2e350f48-b344-4c8a-a723-7f8f8051ef10");
	
				if (!ObjectList.Contains("ДеньНедели"))
                    ObjectList.Add(ДеньНедели);
			}
			#endregion //создание Мониторинг.ДеньНедели ДеньНедели
			
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
	Должность.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Должность.Guid = NsgService.StringToGuid("0b50118b-1a1c-4827-a917-7df1da64c75c");
	
				if (!ObjectList.Contains("Должность"))
                    ObjectList.Add(Должность);
			}
			#endregion //создание Мониторинг.Должности Должность
			
			#region создание Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
			{  
                NsgDataTypedReference ГруппаСпецТехники = null;
				if (ObjectList.Contains("ГруппаСпецТехники"))
                    ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                else
                    ГруппаСпецТехники = new NsgDataTypedReference();
	//NsgDataTypedReference
	ГруппаСпецТехники.IsLoadedFromDll = true;
	ГруппаСпецТехники.ReferentGroup = "Мониторинг";
	ГруппаСпецТехники.ReferentName = "ГруппыСпецТехники";
	ГруппаСпецТехники.SaveInDatabase = true;
	ГруппаСпецТехники.OwnerName = "";
	ГруппаСпецТехники.AllowEmptyOwner = false;
	ГруппаСпецТехники.StringFormat = "";
	ГруппаСпецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ГруппаСпецТехники.IncludeInPredefined = false;
	ГруппаСпецТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГруппаСпецТехники.Required = false;
	ГруппаСпецТехники.EmptyValue = "";
	ГруппаСпецТехники.NullAllow = false;
	ГруппаСпецТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГруппаСпецТехники.FieldName = "GruppaSpecTekhniki";
	ГруппаСпецТехники.InformMetaDataOnValueChanged = false;
	ГруппаСпецТехники.Visible = true;
	ГруппаСпецТехники.Name = "ГруппаСпецТехники";
	ГруппаСпецТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГруппаСпецТехники.Description = "Группа спец техники";
	ГруппаСпецТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГруппаСпецТехники.GroupName = "";
	ГруппаСпецТехники.Guid = NsgService.StringToGuid("46e40a7a-5c9a-4ec8-80c1-abffda50cda2");
	
				if (!ObjectList.Contains("ГруппаСпецТехники"))
                    ObjectList.Add(ГруппаСпецТехники);
			}
			#endregion //создание Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
			
			#region создание System.DateTime ВремяНачалаСмены1
			{  
                NsgDataDateTime ВремяНачалаСмены1 = null;
				if (ObjectList.Contains("ВремяНачалаСмены1"))
                    ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены1 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены1.IsLoadedFromDll = true;
	ВремяНачалаСмены1.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены1.StringFormat = "";
	ВремяНачалаСмены1.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены1.IncludeInPredefined = false;
	ВремяНачалаСмены1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены1.Required = false;
	ВремяНачалаСмены1.EmptyValue = "";
	ВремяНачалаСмены1.NullAllow = false;
	ВремяНачалаСмены1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены1.FieldName = "VremjaNachalaSmeny1";
	ВремяНачалаСмены1.SaveInDatabase = true;
	ВремяНачалаСмены1.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены1.Visible = true;
	ВремяНачалаСмены1.Name = "ВремяНачалаСмены1";
	ВремяНачалаСмены1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены1.Description = "Время начала смены1";
	ВремяНачалаСмены1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены1.GroupName = "";
	ВремяНачалаСмены1.Guid = NsgService.StringToGuid("ddd73c02-234b-49c5-98c9-1ef58246b851");
	
				if (!ObjectList.Contains("ВремяНачалаСмены1"))
                    ObjectList.Add(ВремяНачалаСмены1);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены1
			
			#region создание System.Boolean Выходной
			{  
                NsgDataBoolean Выходной = null;
				if (ObjectList.Contains("Выходной"))
                    Выходной = ObjectList["Выходной"] as NsgDataBoolean;
                else
                    Выходной = new NsgDataBoolean();
	//NsgDataBoolean
	Выходной.IsLoadedFromDll = true;
	Выходной.DefaultValue = false;
	Выходной.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выходной.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выходной.StringFormat = "";
	Выходной.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Выходной.IncludeInPredefined = false;
	Выходной.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Выходной.Required = false;
	Выходной.EmptyValue = "";
	Выходной.NullAllow = false;
	Выходной.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Выходной.FieldName = "Vykhodnoij";
	Выходной.SaveInDatabase = true;
	Выходной.InformMetaDataOnValueChanged = false;
	Выходной.Visible = true;
	Выходной.Name = "Выходной";
	Выходной.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выходной.Description = "Выходной";
	Выходной.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Выходной.GroupName = "";
	Выходной.Guid = NsgService.StringToGuid("b6c06d4e-e6fb-437e-b3f9-27caea546d59");
	
				if (!ObjectList.Contains("Выходной"))
                    ObjectList.Add(Выходной);
			}
			#endregion //создание System.Boolean Выходной
			
			#region создание System.Decimal ДлительностьСмены1ВЧасах
			{  
                NsgDataFloat ДлительностьСмены1ВЧасах = null;
				if (ObjectList.Contains("ДлительностьСмены1ВЧасах"))
                    ДлительностьСмены1ВЧасах = ObjectList["ДлительностьСмены1ВЧасах"] as NsgDataFloat;
                else
                    ДлительностьСмены1ВЧасах = new NsgDataFloat();
	//NsgDataFloat
	ДлительностьСмены1ВЧасах.IsLoadedFromDll = true;
	ДлительностьСмены1ВЧасах.Precision = 2;
	ДлительностьСмены1ВЧасах.HideZero = true;
	ДлительностьСмены1ВЧасах.DefaultValue = 0M;
	ДлительностьСмены1ВЧасах.MinValue = -100000000000000000M;
	ДлительностьСмены1ВЧасах.MaxValue = 100000000000000000M;
	ДлительностьСмены1ВЧасах.UseCalculator = true;
	ДлительностьСмены1ВЧасах.StringFormat = "";
	ДлительностьСмены1ВЧасах.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДлительностьСмены1ВЧасах.IncludeInPredefined = false;
	ДлительностьСмены1ВЧасах.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлительностьСмены1ВЧасах.Required = false;
	ДлительностьСмены1ВЧасах.EmptyValue = "";
	ДлительностьСмены1ВЧасах.NullAllow = false;
	ДлительностьСмены1ВЧасах.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлительностьСмены1ВЧасах.FieldName = "DlitelnostSmeny1V";
	ДлительностьСмены1ВЧасах.SaveInDatabase = true;
	ДлительностьСмены1ВЧасах.InformMetaDataOnValueChanged = false;
	ДлительностьСмены1ВЧасах.Visible = true;
	ДлительностьСмены1ВЧасах.Name = "ДлительностьСмены1ВЧасах";
	ДлительностьСмены1ВЧасах.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлительностьСмены1ВЧасах.Description = "Длительность смены1 ВЧасах";
	ДлительностьСмены1ВЧасах.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлительностьСмены1ВЧасах.GroupName = "";
	ДлительностьСмены1ВЧасах.Guid = NsgService.StringToGuid("0f0468fd-44bd-4866-b4e4-fd0051ebbbed");
	
				if (!ObjectList.Contains("ДлительностьСмены1ВЧасах"))
                    ObjectList.Add(ДлительностьСмены1ВЧасах);
			}
			#endregion //создание System.Decimal ДлительностьСмены1ВЧасах
			
			#region создание System.Decimal ДлительностьСмены3ВЧасах
			{  
                NsgDataFloat ДлительностьСмены3ВЧасах = null;
				if (ObjectList.Contains("ДлительностьСмены3ВЧасах"))
                    ДлительностьСмены3ВЧасах = ObjectList["ДлительностьСмены3ВЧасах"] as NsgDataFloat;
                else
                    ДлительностьСмены3ВЧасах = new NsgDataFloat();
	//NsgDataFloat
	ДлительностьСмены3ВЧасах.IsLoadedFromDll = true;
	ДлительностьСмены3ВЧасах.Precision = 2;
	ДлительностьСмены3ВЧасах.HideZero = true;
	ДлительностьСмены3ВЧасах.DefaultValue = 0M;
	ДлительностьСмены3ВЧасах.MinValue = -100000000000000000M;
	ДлительностьСмены3ВЧасах.MaxValue = 100000000000000000M;
	ДлительностьСмены3ВЧасах.UseCalculator = true;
	ДлительностьСмены3ВЧасах.StringFormat = "";
	ДлительностьСмены3ВЧасах.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДлительностьСмены3ВЧасах.IncludeInPredefined = false;
	ДлительностьСмены3ВЧасах.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлительностьСмены3ВЧасах.Required = false;
	ДлительностьСмены3ВЧасах.EmptyValue = "";
	ДлительностьСмены3ВЧасах.NullAllow = false;
	ДлительностьСмены3ВЧасах.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлительностьСмены3ВЧасах.FieldName = "DlitelnostSmeny3V";
	ДлительностьСмены3ВЧасах.SaveInDatabase = true;
	ДлительностьСмены3ВЧасах.InformMetaDataOnValueChanged = false;
	ДлительностьСмены3ВЧасах.Visible = true;
	ДлительностьСмены3ВЧасах.Name = "ДлительностьСмены3ВЧасах";
	ДлительностьСмены3ВЧасах.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлительностьСмены3ВЧасах.Description = "Длительность смены3 ВЧасах";
	ДлительностьСмены3ВЧасах.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлительностьСмены3ВЧасах.GroupName = "";
	ДлительностьСмены3ВЧасах.Guid = NsgService.StringToGuid("9c9d7b97-bb8f-420f-84c4-21d9ff381047");
	
				if (!ObjectList.Contains("ДлительностьСмены3ВЧасах"))
                    ObjectList.Add(ДлительностьСмены3ВЧасах);
			}
			#endregion //создание System.Decimal ДлительностьСмены3ВЧасах
			
			#region создание System.Decimal ДлительностьСмены2ВЧасах
			{  
                NsgDataFloat ДлительностьСмены2ВЧасах = null;
				if (ObjectList.Contains("ДлительностьСмены2ВЧасах"))
                    ДлительностьСмены2ВЧасах = ObjectList["ДлительностьСмены2ВЧасах"] as NsgDataFloat;
                else
                    ДлительностьСмены2ВЧасах = new NsgDataFloat();
	//NsgDataFloat
	ДлительностьСмены2ВЧасах.IsLoadedFromDll = true;
	ДлительностьСмены2ВЧасах.Precision = 2;
	ДлительностьСмены2ВЧасах.HideZero = true;
	ДлительностьСмены2ВЧасах.DefaultValue = 0M;
	ДлительностьСмены2ВЧасах.MinValue = -100000000000000000M;
	ДлительностьСмены2ВЧасах.MaxValue = 100000000000000000M;
	ДлительностьСмены2ВЧасах.UseCalculator = true;
	ДлительностьСмены2ВЧасах.StringFormat = "";
	ДлительностьСмены2ВЧасах.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДлительностьСмены2ВЧасах.IncludeInPredefined = false;
	ДлительностьСмены2ВЧасах.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлительностьСмены2ВЧасах.Required = false;
	ДлительностьСмены2ВЧасах.EmptyValue = "";
	ДлительностьСмены2ВЧасах.NullAllow = false;
	ДлительностьСмены2ВЧасах.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлительностьСмены2ВЧасах.FieldName = "DlitelnostSmeny2V";
	ДлительностьСмены2ВЧасах.SaveInDatabase = true;
	ДлительностьСмены2ВЧасах.InformMetaDataOnValueChanged = false;
	ДлительностьСмены2ВЧасах.Visible = true;
	ДлительностьСмены2ВЧасах.Name = "ДлительностьСмены2ВЧасах";
	ДлительностьСмены2ВЧасах.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлительностьСмены2ВЧасах.Description = "Длительность смены2 ВЧасах";
	ДлительностьСмены2ВЧасах.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлительностьСмены2ВЧасах.GroupName = "";
	ДлительностьСмены2ВЧасах.Guid = NsgService.StringToGuid("835d5e4f-e030-435f-aa62-20b1544f01d6");
	
				if (!ObjectList.Contains("ДлительностьСмены2ВЧасах"))
                    ObjectList.Add(ДлительностьСмены2ВЧасах);
			}
			#endregion //создание System.Decimal ДлительностьСмены2ВЧасах
			
			#region создание System.DateTime ВремяНачалаСмены2
			{  
                NsgDataDateTime ВремяНачалаСмены2 = null;
				if (ObjectList.Contains("ВремяНачалаСмены2"))
                    ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены2 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены2.IsLoadedFromDll = true;
	ВремяНачалаСмены2.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены2.StringFormat = "";
	ВремяНачалаСмены2.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены2.IncludeInPredefined = false;
	ВремяНачалаСмены2.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены2.Required = false;
	ВремяНачалаСмены2.EmptyValue = "";
	ВремяНачалаСмены2.NullAllow = false;
	ВремяНачалаСмены2.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены2.FieldName = "VremjaNachalaSmeny2";
	ВремяНачалаСмены2.SaveInDatabase = true;
	ВремяНачалаСмены2.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены2.Visible = true;
	ВремяНачалаСмены2.Name = "ВремяНачалаСмены2";
	ВремяНачалаСмены2.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены2.Description = "Время начала смены2";
	ВремяНачалаСмены2.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены2.GroupName = "";
	ВремяНачалаСмены2.Guid = NsgService.StringToGuid("b5c0d5a6-7e9d-43b3-9824-595027cd1122");
	
				if (!ObjectList.Contains("ВремяНачалаСмены2"))
                    ObjectList.Add(ВремяНачалаСмены2);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены2
			
			#region создание System.DateTime ВремяНачалаСмены3
			{  
                NsgDataDateTime ВремяНачалаСмены3 = null;
				if (ObjectList.Contains("ВремяНачалаСмены3"))
                    ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                else
                    ВремяНачалаСмены3 = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяНачалаСмены3.IsLoadedFromDll = true;
	ВремяНачалаСмены3.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ВремяНачалаСмены3.StringFormat = "";
	ВремяНачалаСмены3.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВремяНачалаСмены3.IncludeInPredefined = false;
	ВремяНачалаСмены3.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяНачалаСмены3.Required = false;
	ВремяНачалаСмены3.EmptyValue = "";
	ВремяНачалаСмены3.NullAllow = false;
	ВремяНачалаСмены3.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВремяНачалаСмены3.FieldName = "VremjaNachalaSmeny3";
	ВремяНачалаСмены3.SaveInDatabase = true;
	ВремяНачалаСмены3.InformMetaDataOnValueChanged = false;
	ВремяНачалаСмены3.Visible = true;
	ВремяНачалаСмены3.Name = "ВремяНачалаСмены3";
	ВремяНачалаСмены3.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВремяНачалаСмены3.Description = "Время начала смены3";
	ВремяНачалаСмены3.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВремяНачалаСмены3.GroupName = "";
	ВремяНачалаСмены3.Guid = NsgService.StringToGuid("0afe0e64-e371-40d9-9b14-2325a9910d0f");
	
				if (!ObjectList.Contains("ВремяНачалаСмены3"))
                    ObjectList.Add(ВремяНачалаСмены3);
			}
			#endregion //создание System.DateTime ВремяНачалаСмены3
			
			#region создание System.Int64 Количество
			{  
                NsgDataInteger Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataInteger;
                else
                    Количество = new NsgDataInteger();
	//NsgDataInteger
	Количество.IsLoadedFromDll = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = 0M;
	Количество.MaxValue = 0M;
	Количество.UseCalculator = true;
	Количество.StringFormat = "";
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.SaveInDatabase = true;
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("43815c22-c260-42f3-affb-f946a9ce97b2");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Int64 Количество
			
			#region создание System.String КодГруппы
			{  
                NsgDataString КодГруппы = null;
				if (ObjectList.Contains("КодГруппы"))
                    КодГруппы = ObjectList["КодГруппы"] as NsgDataString;
                else
                    КодГруппы = new NsgDataString();
	//NsgDataString
	КодГруппы.IsLoadedFromDll = true;
	КодГруппы.Length = 50;
	КодГруппы.StringFormat = "";
	КодГруппы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КодГруппы.IncludeInPredefined = false;
	КодГруппы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КодГруппы.Required = false;
	КодГруппы.EmptyValue = "";
	КодГруппы.NullAllow = false;
	КодГруппы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КодГруппы.FieldName = "KodGruppy";
	КодГруппы.SaveInDatabase = true;
	КодГруппы.InformMetaDataOnValueChanged = false;
	КодГруппы.Visible = true;
	КодГруппы.Name = "КодГруппы";
	КодГруппы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КодГруппы.Description = "Код группы";
	КодГруппы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КодГруппы.GroupName = "";
	КодГруппы.Guid = NsgService.StringToGuid("d7a9a988-acaf-4e07-8ef1-2a5ea3929796");
	
				if (!ObjectList.Contains("КодГруппы"))
                    ObjectList.Add(КодГруппы);
			}
			#endregion //создание System.String КодГруппы
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Документы.ГрафикРаботыОбъекта";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДокументыГрафикРаботыОбъектаТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("1e47e65a-df14-4b73-96d7-0dc7cdf6be70");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_DokumentyGrafikRabo";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документы график работы объекта таблица";
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
            /// Дата конкретный день
            /// </summary>
            public static String ДатаКонкретныйДень
            {
                get
                {
                    return "ДатаКонкретныйДень";
                }
            }
            
            /// <summary>
            /// День недели
            /// </summary>
            public static String ДеньНедели
            {
                get
                {
                    return "ДеньНедели";
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
            /// Группа спец техники
            /// </summary>
            public static String ГруппаСпецТехники
            {
                get
                {
                    return "ГруппаСпецТехники";
                }
            }
            
            /// <summary>
            /// Время начала смены1
            /// </summary>
            public static String ВремяНачалаСмены1
            {
                get
                {
                    return "ВремяНачалаСмены1";
                }
            }
            
            /// <summary>
            /// Выходной
            /// </summary>
            public static String Выходной
            {
                get
                {
                    return "Выходной";
                }
            }
            
            /// <summary>
            /// Длительность смены1 ВЧасах
            /// </summary>
            public static String ДлительностьСмены1ВЧасах
            {
                get
                {
                    return "ДлительностьСмены1ВЧасах";
                }
            }
            
            /// <summary>
            /// Длительность смены3 ВЧасах
            /// </summary>
            public static String ДлительностьСмены3ВЧасах
            {
                get
                {
                    return "ДлительностьСмены3ВЧасах";
                }
            }
            
            /// <summary>
            /// Длительность смены2 ВЧасах
            /// </summary>
            public static String ДлительностьСмены2ВЧасах
            {
                get
                {
                    return "ДлительностьСмены2ВЧасах";
                }
            }
            
            /// <summary>
            /// Время начала смены2
            /// </summary>
            public static String ВремяНачалаСмены2
            {
                get
                {
                    return "ВремяНачалаСмены2";
                }
            }
            
            /// <summary>
            /// Время начала смены3
            /// </summary>
            public static String ВремяНачалаСмены3
            {
                get
                {
                    return "ВремяНачалаСмены3";
                }
            }
            
            /// <summary>
            /// Количество
            /// </summary>
            public static String Количество
            {
                get
                {
                    return "Количество";
                }
            }
            
            /// <summary>
            /// Код группы
            /// </summary>
            public static String КодГруппы
            {
                get
                {
                    return "КодГруппы";
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
                    descriptor.Name = "ДокументыГрафикРаботыОбъектаТаблица";
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
            return "_SystemTables.ДокументыГрафикРаботыОбъектаТаблица";
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
        [NsgReferentsFilterAttribute("Документы.ГрафикРаботыОбъекта")]
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
        /// Дата конкретный день
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаКонкретныйДень
        {
            get
            {
				 NsgDataDateTime __ДатаКонкретныйДень = ObjectList["ДатаКонкретныйДень"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаКонкретныйДень.Value;
            }
            set
            {
                NsgDataDateTime __ДатаКонкретныйДень = ObjectList["ДатаКонкретныйДень"] as NsgDataDateTime;
                __ДатаКонкретныйДень.Value = value;
            }
        }
        
        /// <summary>
        /// День недели
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.ДеньНедели ДеньНедели
        {
            get
            {
				 NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                 return (Мониторинг.ДеньНедели)__ДеньНедели.Referent;
            }
            set
            {
                NsgDataEnumReference __ДеньНедели = ObjectList["ДеньНедели"] as NsgDataEnumReference;
                __ДеньНедели.Referent = value;
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
        /// Группа спец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
        {
            get
            {
				 NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                 return (Мониторинг.ГруппыСпецТехники)__ГруппаСпецТехники.Referent;
            }
            set
            {
                NsgDataTypedReference __ГруппаСпецТехники = ObjectList["ГруппаСпецТехники"] as NsgDataTypedReference;
                __ГруппаСпецТехники.Referent = value;
            }
        }
        
        /// <summary>
        /// Время начала смены1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены1
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены1.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены1 = ObjectList["ВремяНачалаСмены1"] as NsgDataDateTime;
                __ВремяНачалаСмены1.Value = value;
            }
        }
        
        /// <summary>
        /// Выходной
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Выходной
        {
            get
            {
				 NsgDataBoolean __Выходной = ObjectList["Выходной"] as NsgDataBoolean;
                 return (System.Boolean)__Выходной.Value;
            }
            set
            {
                NsgDataBoolean __Выходной = ObjectList["Выходной"] as NsgDataBoolean;
                __Выходной.Value = value;
            }
        }
        
        /// <summary>
        /// Длительность смены1 ВЧасах
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлительностьСмены1ВЧасах
        {
            get
            {
				 NsgDataFloat __ДлительностьСмены1ВЧасах = ObjectList["ДлительностьСмены1ВЧасах"] as NsgDataFloat;
                 return (System.Decimal)__ДлительностьСмены1ВЧасах.Value;
            }
            set
            {
                NsgDataFloat __ДлительностьСмены1ВЧасах = ObjectList["ДлительностьСмены1ВЧасах"] as NsgDataFloat;
                __ДлительностьСмены1ВЧасах.Value = value;
            }
        }
        
        /// <summary>
        /// Длительность смены3 ВЧасах
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлительностьСмены3ВЧасах
        {
            get
            {
				 NsgDataFloat __ДлительностьСмены3ВЧасах = ObjectList["ДлительностьСмены3ВЧасах"] as NsgDataFloat;
                 return (System.Decimal)__ДлительностьСмены3ВЧасах.Value;
            }
            set
            {
                NsgDataFloat __ДлительностьСмены3ВЧасах = ObjectList["ДлительностьСмены3ВЧасах"] as NsgDataFloat;
                __ДлительностьСмены3ВЧасах.Value = value;
            }
        }
        
        /// <summary>
        /// Длительность смены2 ВЧасах
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлительностьСмены2ВЧасах
        {
            get
            {
				 NsgDataFloat __ДлительностьСмены2ВЧасах = ObjectList["ДлительностьСмены2ВЧасах"] as NsgDataFloat;
                 return (System.Decimal)__ДлительностьСмены2ВЧасах.Value;
            }
            set
            {
                NsgDataFloat __ДлительностьСмены2ВЧасах = ObjectList["ДлительностьСмены2ВЧасах"] as NsgDataFloat;
                __ДлительностьСмены2ВЧасах.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены2
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены2
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены2.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены2 = ObjectList["ВремяНачалаСмены2"] as NsgDataDateTime;
                __ВремяНачалаСмены2.Value = value;
            }
        }
        
        /// <summary>
        /// Время начала смены3
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяНачалаСмены3
        {
            get
            {
				 NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяНачалаСмены3.Value;
            }
            set
            {
                NsgDataDateTime __ВремяНачалаСмены3 = ObjectList["ВремяНачалаСмены3"] as NsgDataDateTime;
                __ВремяНачалаСмены3.Value = value;
            }
        }
        
        /// <summary>
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Количество
        {
            get
            {
				 NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                 return (System.Int64)__Количество.Value;
            }
            set
            {
                NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                __Количество.Value = value;
            }
        }
        
        /// <summary>
        /// Код группы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String КодГруппы
        {
            get
            {
				 NsgDataString __КодГруппы = ObjectList["КодГруппы"] as NsgDataString;
                 return (System.String)__КодГруппы.Value;
            }
            set
            {
                NsgDataString __КодГруппы = ObjectList["КодГруппы"] as NsgDataString;
                __КодГруппы.Value = value;
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
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка NewRow()
        {
            return newRow(null) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new ДокументыГрафикРаботыОбъектаТаблица.Строка(this);
            return base.newRow(row) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public ДокументыГрафикРаботыОбъектаТаблица.Строка NewRow(ДокументыГрафикРаботыОбъектаТаблица.Строка inRow)
        {
            ДокументыГрафикРаботыОбъектаТаблица.Строка row = inRow.Clone as ДокументыГрафикРаботыОбъектаТаблица.Строка;
            return base.newRow(row) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка GetEtalonRow()
        {
            ДокументыГрафикРаботыОбъектаТаблица.Строка row = new ДокументыГрафикРаботыОбъектаТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private ДокументыГрафикРаботыОбъектаТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            ДокументыГрафикРаботыОбъектаТаблица.Строка[] res = new ДокументыГрафикРаботыОбъектаТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<ДокументыГрафикРаботыОбъектаТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<ДокументыГрафикРаботыОбъектаТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка[] AllRows
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
        public new ДокументыГрафикРаботыОбъектаТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as ДокументыГрафикРаботыОбъектаТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private ДокументыГрафикРаботыОбъектаТаблица[] convertArray(NsgMultipleObject[] array)
        {
            ДокументыГрафикРаботыОбъектаТаблица[] res = new ДокументыГрафикРаботыОбъектаТаблица[array.Length];
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
        public new virtual ДокументыГрафикРаботыОбъектаТаблица[] FindAll(NsgCompare compare)
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
        public new virtual ДокументыГрафикРаботыОбъектаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ДокументыГрафикРаботыОбъектаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ДокументыГрафикРаботыОбъектаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ДокументыГрафикРаботыОбъектаТаблица(this as NsgObject);
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
                base.NSGType = typeof(ДокументыГрафикРаботыОбъектаТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ДокументыГрафикРаботыОбъектаТаблица Value
            {
                get
                {
                    return (ДокументыГрафикРаботыОбъектаТаблица)base.Value;
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
