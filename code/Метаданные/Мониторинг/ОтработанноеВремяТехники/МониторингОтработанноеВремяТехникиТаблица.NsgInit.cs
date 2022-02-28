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
    
    [NsgTypeName("NsgDataTable", Guid = "ab85dfac-f155-4e2e-af9a-8ad0f937fedf")]
    public partial class МониторингОтработанноеВремяТехникиТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингОтработанноеВремяТехникиТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингОтработанноеВремяТехникиТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингОтработанноеВремяТехникиТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("ab85dfac-f155-4e2e-af9a-8ad0f937fedf"));
            if (obj == null)
                obj = new МониторингОтработанноеВремяТехникиТаблица();
            return obj as МониторингОтработанноеВремяТехникиТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("0fb3b796-95d0-4fc1-a8ef-57a6b43fd309");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("2b2a129c-9562-4a2c-a10f-56608f48245e");
	
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
	Владелец.FilterForConfigurator = "Мониторинг.ОтработанноеВремяТехники";
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
	Владелец.Guid = NsgService.StringToGuid("3476382b-6e64-4070-a8de-2fc1da3af4f1");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("f2240176-5a55-40ff-a857-0e6a08ec1cbf");
	
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
	Техника.Guid = NsgService.StringToGuid("e573159f-3473-406e-8134-c55d4d0f053f");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
			#region создание System.DateTime ДатаОкончанияРаботы
			{  
                NsgDataDateTime ДатаОкончанияРаботы = null;
				if (ObjectList.Contains("ДатаОкончанияРаботы"))
                    ДатаОкончанияРаботы = ObjectList["ДатаОкончанияРаботы"] as NsgDataDateTime;
                else
                    ДатаОкончанияРаботы = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияРаботы.IsLoadedFromDll = true;
	ДатаОкончанияРаботы.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончанияРаботы.StringFormat = "";
	ДатаОкончанияРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияРаботы.IncludeInPredefined = false;
	ДатаОкончанияРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияРаботы.Required = false;
	ДатаОкончанияРаботы.EmptyValue = "";
	ДатаОкончанияРаботы.NullAllow = false;
	ДатаОкончанияРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончанияРаботы.FieldName = "DataOkonchanijaRa";
	ДатаОкончанияРаботы.SaveInDatabase = true;
	ДатаОкончанияРаботы.InformMetaDataOnValueChanged = false;
	ДатаОкончанияРаботы.Visible = true;
	ДатаОкончанияРаботы.Name = "ДатаОкончанияРаботы";
	ДатаОкончанияРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончанияРаботы.Description = "Дата окончания работы";
	ДатаОкончанияРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончанияРаботы.GroupName = "";
	ДатаОкончанияРаботы.Guid = NsgService.StringToGuid("30fcdd6b-df33-4a35-b931-0614a628fe3c");
	
				if (!ObjectList.Contains("ДатаОкончанияРаботы"))
                    ObjectList.Add(ДатаОкончанияРаботы);
			}
			#endregion //создание System.DateTime ДатаОкончанияРаботы
			
			#region создание System.DateTime ДлительностьРаботы
			{  
                NsgDataDateTime ДлительностьРаботы = null;
				if (ObjectList.Contains("ДлительностьРаботы"))
                    ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataDateTime;
                else
                    ДлительностьРаботы = new NsgDataDateTime();
	//NsgDataDateTime
	ДлительностьРаботы.IsLoadedFromDll = true;
	ДлительностьРаботы.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДлительностьРаботы.StringFormat = "";
	ДлительностьРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДлительностьРаботы.IncludeInPredefined = false;
	ДлительностьРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДлительностьРаботы.Required = false;
	ДлительностьРаботы.EmptyValue = "";
	ДлительностьРаботы.NullAllow = false;
	ДлительностьРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДлительностьРаботы.FieldName = "DlitelnostRaboty";
	ДлительностьРаботы.SaveInDatabase = true;
	ДлительностьРаботы.InformMetaDataOnValueChanged = false;
	ДлительностьРаботы.Visible = true;
	ДлительностьРаботы.Name = "ДлительностьРаботы";
	ДлительностьРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДлительностьРаботы.Description = "Длительность работы";
	ДлительностьРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДлительностьРаботы.GroupName = "";
	ДлительностьРаботы.Guid = NsgService.StringToGuid("ce2cab2a-fd02-488d-80a7-75f6ce0645eb");
	
				if (!ObjectList.Contains("ДлительностьРаботы"))
                    ObjectList.Add(ДлительностьРаботы);
			}
			#endregion //создание System.DateTime ДлительностьРаботы
			
			#region создание System.DateTime ДатаНачалаРаботы
			{  
                NsgDataDateTime ДатаНачалаРаботы = null;
				if (ObjectList.Contains("ДатаНачалаРаботы"))
                    ДатаНачалаРаботы = ObjectList["ДатаНачалаРаботы"] as NsgDataDateTime;
                else
                    ДатаНачалаРаботы = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаНачалаРаботы.IsLoadedFromDll = true;
	ДатаНачалаРаботы.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаНачалаРаботы.StringFormat = "";
	ДатаНачалаРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаНачалаРаботы.IncludeInPredefined = false;
	ДатаНачалаРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаНачалаРаботы.Required = false;
	ДатаНачалаРаботы.EmptyValue = "";
	ДатаНачалаРаботы.NullAllow = false;
	ДатаНачалаРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаНачалаРаботы.FieldName = "DataNachalaRaboty";
	ДатаНачалаРаботы.SaveInDatabase = true;
	ДатаНачалаРаботы.InformMetaDataOnValueChanged = false;
	ДатаНачалаРаботы.Visible = true;
	ДатаНачалаРаботы.Name = "ДатаНачалаРаботы";
	ДатаНачалаРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаНачалаРаботы.Description = "Дата начала работы";
	ДатаНачалаРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаНачалаРаботы.GroupName = "";
	ДатаНачалаРаботы.Guid = NsgService.StringToGuid("c9a53c3a-600b-49c1-a6eb-9804965e2ec3");
	
				if (!ObjectList.Contains("ДатаНачалаРаботы"))
                    ObjectList.Add(ДатаНачалаРаботы);
			}
			#endregion //создание System.DateTime ДатаНачалаРаботы
			
			#region создание System.Decimal НачальныйЗапасТоплива
			{  
                NsgDataFloat НачальныйЗапасТоплива = null;
				if (ObjectList.Contains("НачальныйЗапасТоплива"))
                    НачальныйЗапасТоплива = ObjectList["НачальныйЗапасТоплива"] as NsgDataFloat;
                else
                    НачальныйЗапасТоплива = new NsgDataFloat();
	//NsgDataFloat
	НачальныйЗапасТоплива.IsLoadedFromDll = true;
	НачальныйЗапасТоплива.Precision = 2;
	НачальныйЗапасТоплива.HideZero = true;
	НачальныйЗапасТоплива.DefaultValue = 0M;
	НачальныйЗапасТоплива.MinValue = -100000000000000000M;
	НачальныйЗапасТоплива.MaxValue = 100000000000000000M;
	НачальныйЗапасТоплива.UseCalculator = true;
	НачальныйЗапасТоплива.StringFormat = "";
	НачальныйЗапасТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НачальныйЗапасТоплива.IncludeInPredefined = false;
	НачальныйЗапасТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НачальныйЗапасТоплива.Required = false;
	НачальныйЗапасТоплива.EmptyValue = "";
	НачальныйЗапасТоплива.NullAllow = false;
	НачальныйЗапасТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НачальныйЗапасТоплива.FieldName = "NachalnyijZapasTo";
	НачальныйЗапасТоплива.SaveInDatabase = true;
	НачальныйЗапасТоплива.InformMetaDataOnValueChanged = false;
	НачальныйЗапасТоплива.Visible = true;
	НачальныйЗапасТоплива.Name = "НачальныйЗапасТоплива";
	НачальныйЗапасТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НачальныйЗапасТоплива.Description = "Начальный запас топлива";
	НачальныйЗапасТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НачальныйЗапасТоплива.GroupName = "";
	НачальныйЗапасТоплива.Guid = NsgService.StringToGuid("da4156b9-1b70-4a06-a706-7198615c18f8");
	
				if (!ObjectList.Contains("НачальныйЗапасТоплива"))
                    ObjectList.Add(НачальныйЗапасТоплива);
			}
			#endregion //создание System.Decimal НачальныйЗапасТоплива
			
			#region создание System.Decimal КонечныйЗапасТоплива
			{  
                NsgDataFloat КонечныйЗапасТоплива = null;
				if (ObjectList.Contains("КонечныйЗапасТоплива"))
                    КонечныйЗапасТоплива = ObjectList["КонечныйЗапасТоплива"] as NsgDataFloat;
                else
                    КонечныйЗапасТоплива = new NsgDataFloat();
	//NsgDataFloat
	КонечныйЗапасТоплива.IsLoadedFromDll = true;
	КонечныйЗапасТоплива.Precision = 2;
	КонечныйЗапасТоплива.HideZero = true;
	КонечныйЗапасТоплива.DefaultValue = 0M;
	КонечныйЗапасТоплива.MinValue = -100000000000000000M;
	КонечныйЗапасТоплива.MaxValue = 100000000000000000M;
	КонечныйЗапасТоплива.UseCalculator = true;
	КонечныйЗапасТоплива.StringFormat = "";
	КонечныйЗапасТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КонечныйЗапасТоплива.IncludeInPredefined = false;
	КонечныйЗапасТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонечныйЗапасТоплива.Required = false;
	КонечныйЗапасТоплива.EmptyValue = "";
	КонечныйЗапасТоплива.NullAllow = false;
	КонечныйЗапасТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонечныйЗапасТоплива.FieldName = "KonechnyijZapasTo";
	КонечныйЗапасТоплива.SaveInDatabase = true;
	КонечныйЗапасТоплива.InformMetaDataOnValueChanged = false;
	КонечныйЗапасТоплива.Visible = true;
	КонечныйЗапасТоплива.Name = "КонечныйЗапасТоплива";
	КонечныйЗапасТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонечныйЗапасТоплива.Description = "Конечный запас топлива";
	КонечныйЗапасТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КонечныйЗапасТоплива.GroupName = "";
	КонечныйЗапасТоплива.Guid = NsgService.StringToGuid("0c371920-0648-4f69-9af7-6f68fb9945dd");
	
				if (!ObjectList.Contains("КонечныйЗапасТоплива"))
                    ObjectList.Add(КонечныйЗапасТоплива);
			}
			#endregion //создание System.Decimal КонечныйЗапасТоплива
			
			#region создание System.Decimal КоличествоЗаправок
			{  
                NsgDataFloat КоличествоЗаправок = null;
				if (ObjectList.Contains("КоличествоЗаправок"))
                    КоличествоЗаправок = ObjectList["КоличествоЗаправок"] as NsgDataFloat;
                else
                    КоличествоЗаправок = new NsgDataFloat();
	//NsgDataFloat
	КоличествоЗаправок.IsLoadedFromDll = true;
	КоличествоЗаправок.Precision = 2;
	КоличествоЗаправок.HideZero = true;
	КоличествоЗаправок.DefaultValue = 0M;
	КоличествоЗаправок.MinValue = -100000000000000000M;
	КоличествоЗаправок.MaxValue = 100000000000000000M;
	КоличествоЗаправок.UseCalculator = true;
	КоличествоЗаправок.StringFormat = "";
	КоличествоЗаправок.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	КоличествоЗаправок.IncludeInPredefined = false;
	КоличествоЗаправок.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоЗаправок.Required = false;
	КоличествоЗаправок.EmptyValue = "";
	КоличествоЗаправок.NullAllow = false;
	КоличествоЗаправок.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоЗаправок.FieldName = "KolichestvoZapravok";
	КоличествоЗаправок.SaveInDatabase = true;
	КоличествоЗаправок.InformMetaDataOnValueChanged = false;
	КоличествоЗаправок.Visible = true;
	КоличествоЗаправок.Name = "КоличествоЗаправок";
	КоличествоЗаправок.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоЗаправок.Description = "Количество заправок";
	КоличествоЗаправок.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоЗаправок.GroupName = "";
	КоличествоЗаправок.Guid = NsgService.StringToGuid("238f7c97-2a75-4d2a-a929-b5ac09149b8d");
	
				if (!ObjectList.Contains("КоличествоЗаправок"))
                    ObjectList.Add(КоличествоЗаправок);
			}
			#endregion //создание System.Decimal КоличествоЗаправок
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.ОтработанноеВремяТехники";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингОтработанноеВремяТехникиТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("ab85dfac-f155-4e2e-af9a-8ad0f937fedf");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringOtrabotan";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг отработанное время техники таблица";
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
            /// Дата окончания работы
            /// </summary>
            public static String ДатаОкончанияРаботы
            {
                get
                {
                    return "ДатаОкончанияРаботы";
                }
            }
            
            /// <summary>
            /// Длительность работы
            /// </summary>
            public static String ДлительностьРаботы
            {
                get
                {
                    return "ДлительностьРаботы";
                }
            }
            
            /// <summary>
            /// Дата начала работы
            /// </summary>
            public static String ДатаНачалаРаботы
            {
                get
                {
                    return "ДатаНачалаРаботы";
                }
            }
            
            /// <summary>
            /// Начальный запас топлива
            /// </summary>
            public static String НачальныйЗапасТоплива
            {
                get
                {
                    return "НачальныйЗапасТоплива";
                }
            }
            
            /// <summary>
            /// Конечный запас топлива
            /// </summary>
            public static String КонечныйЗапасТоплива
            {
                get
                {
                    return "КонечныйЗапасТоплива";
                }
            }
            
            /// <summary>
            /// Количество заправок
            /// </summary>
            public static String КоличествоЗаправок
            {
                get
                {
                    return "КоличествоЗаправок";
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
                    descriptor.Name = "МониторингОтработанноеВремяТехникиТаблица";
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
            return "_SystemTables.МониторингОтработанноеВремяТехникиТаблица";
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
        [NsgReferentsFilterAttribute("Мониторинг.ОтработанноеВремяТехники")]
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
        /// Дата окончания работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияРаботы
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияРаботы = ObjectList["ДатаОкончанияРаботы"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияРаботы.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияРаботы = ObjectList["ДатаОкончанияРаботы"] as NsgDataDateTime;
                __ДатаОкончанияРаботы.Value = value;
            }
        }
        
        /// <summary>
        /// Длительность работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДлительностьРаботы
        {
            get
            {
				 NsgDataDateTime __ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataDateTime;
                 return (System.DateTime)__ДлительностьРаботы.Value;
            }
            set
            {
                NsgDataDateTime __ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataDateTime;
                __ДлительностьРаботы.Value = value;
            }
        }
        
        /// <summary>
        /// Дата начала работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаНачалаРаботы
        {
            get
            {
				 NsgDataDateTime __ДатаНачалаРаботы = ObjectList["ДатаНачалаРаботы"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаНачалаРаботы.Value;
            }
            set
            {
                NsgDataDateTime __ДатаНачалаРаботы = ObjectList["ДатаНачалаРаботы"] as NsgDataDateTime;
                __ДатаНачалаРаботы.Value = value;
            }
        }
        
        /// <summary>
        /// Начальный запас топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal НачальныйЗапасТоплива
        {
            get
            {
				 NsgDataFloat __НачальныйЗапасТоплива = ObjectList["НачальныйЗапасТоплива"] as NsgDataFloat;
                 return (System.Decimal)__НачальныйЗапасТоплива.Value;
            }
            set
            {
                NsgDataFloat __НачальныйЗапасТоплива = ObjectList["НачальныйЗапасТоплива"] as NsgDataFloat;
                __НачальныйЗапасТоплива.Value = value;
            }
        }
        
        /// <summary>
        /// Конечный запас топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal КонечныйЗапасТоплива
        {
            get
            {
				 NsgDataFloat __КонечныйЗапасТоплива = ObjectList["КонечныйЗапасТоплива"] as NsgDataFloat;
                 return (System.Decimal)__КонечныйЗапасТоплива.Value;
            }
            set
            {
                NsgDataFloat __КонечныйЗапасТоплива = ObjectList["КонечныйЗапасТоплива"] as NsgDataFloat;
                __КонечныйЗапасТоплива.Value = value;
            }
        }
        
        /// <summary>
        /// Количество заправок
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal КоличествоЗаправок
        {
            get
            {
				 NsgDataFloat __КоличествоЗаправок = ObjectList["КоличествоЗаправок"] as NsgDataFloat;
                 return (System.Decimal)__КоличествоЗаправок.Value;
            }
            set
            {
                NsgDataFloat __КоличествоЗаправок = ObjectList["КоличествоЗаправок"] as NsgDataFloat;
                __КоличествоЗаправок.Value = value;
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
        public new МониторингОтработанноеВремяТехникиТаблица.Строка NewRow()
        {
            return newRow(null) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингОтработанноеВремяТехникиТаблица.Строка(this);
            return base.newRow(row) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингОтработанноеВремяТехникиТаблица.Строка NewRow(МониторингОтработанноеВремяТехникиТаблица.Строка inRow)
        {
            МониторингОтработанноеВремяТехникиТаблица.Строка row = inRow.Clone as МониторингОтработанноеВремяТехникиТаблица.Строка;
            return base.newRow(row) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка GetEtalonRow()
        {
            МониторингОтработанноеВремяТехникиТаблица.Строка row = new МониторингОтработанноеВремяТехникиТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингОтработанноеВремяТехникиТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингОтработанноеВремяТехникиТаблица.Строка[] res = new МониторингОтработанноеВремяТехникиТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингОтработанноеВремяТехникиТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингОтработанноеВремяТехникиТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингОтработанноеВремяТехникиТаблица.Строка[] AllRows
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
        public new МониторингОтработанноеВремяТехникиТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингОтработанноеВремяТехникиТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингОтработанноеВремяТехникиТаблица[] convertArray(NsgMultipleObject[] array)
        {
            МониторингОтработанноеВремяТехникиТаблица[] res = new МониторингОтработанноеВремяТехникиТаблица[array.Length];
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
        public new virtual МониторингОтработанноеВремяТехникиТаблица[] FindAll(NsgCompare compare)
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
        public new virtual МониторингОтработанноеВремяТехникиТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингОтработанноеВремяТехникиТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингОтработанноеВремяТехникиТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингОтработанноеВремяТехникиТаблица(this as NsgObject);
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
                base.NSGType = typeof(МониторингОтработанноеВремяТехникиТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингОтработанноеВремяТехникиТаблица Value
            {
                get
                {
                    return (МониторингОтработанноеВремяТехникиТаблица)base.Value;
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
