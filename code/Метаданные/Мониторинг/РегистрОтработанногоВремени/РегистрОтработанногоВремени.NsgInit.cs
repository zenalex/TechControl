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
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "48c89720-3172-47b1-bcaf-a3d635d3cb53")]
    public partial class РегистрОтработанногоВремени : NsgSoft.DataObjects.NsgDataCharacteristics
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics
        

		/// <summary>
        /// Конструктор для проведения документов, передается проводимый документ.
        /// </summary>
        public static РегистрОтработанногоВремени Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("48c89720-3172-47b1-bcaf-a3d635d3cb53"));
            if (obj == null)
                obj = new РегистрОтработанногоВремени();
            (obj as РегистрОтработанногоВремени).Document = document;
            return obj as РегистрОтработанногоВремени;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрОтработанногоВремени()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрОтработанногоВремени(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрОтработанногоВремени Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("48c89720-3172-47b1-bcaf-a3d635d3cb53"));
            if (obj == null)
                obj = new РегистрОтработанногоВремени();
            return obj as РегистрОтработанногоВремени;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			
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
	Идентификатор.Guid = NsgService.StringToGuid("9978638a-98ce-4ee4-a76a-709b1f41f324");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("fb4c99b2-dac9-4a19-a32a-911713828b80");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.МониторингРегистрОтработанногоВремениДвижения Движения
			{  
                NsgRegisterTable Движения = null;
				if (ObjectList.Contains("Движения"))
                    Движения = ObjectList["Движения"] as NsgRegisterTable;
                else
                    Движения = new NsgRegisterTable();
	//NsgRegisterTable
	Движения.IsLoadedFromDll = true;
	Движения.Name = "Движения";
	Движения.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Движения.RegisterPeriodCount = 1;
	Движения.ReferentGroup = "_SystemTables";
	Движения.ReferentName = "МониторингРегистрОтработанногоВремениДвижения";
	Движения.SaveInDatabase = false;
	Движения.OwnerName = "";
	Движения.AllowEmptyOwner = false;
	Движения.StringFormat = "";
	Движения.SubType = NsgSoft.Common.NsgRekvisitSubType.TabCharacteristics;
	Движения.IncludeInPredefined = false;
	Движения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Движения.Required = false;
	Движения.EmptyValue = "";
	Движения.NullAllow = false;
	Движения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Движения.FieldName = "Dvizhenija";
	Движения.InformMetaDataOnValueChanged = false;
	Движения.Visible = true;
	Движения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Движения.Description = "Движения";
	Движения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Движения.GroupName = "";
	Движения.Guid = NsgService.StringToGuid("7e683c8b-10ed-4869-8388-b237ad9a706e");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.МониторингРегистрОтработанногоВремениДвижения Движения
			
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("cd085f04-631d-42e9-bcb0-3c74c5f65126");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	Техника.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Техника.IncludeInPredefined = false;
	Техника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Техника.Required = false;
	Техника.EmptyValue = "";
	Техника.NullAllow = false;
	Техника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Техника.FieldName = "Tekhnika";
	Техника.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Техника.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Техника.CharactericticWeight = 1;
	Техника.InformMetaDataOnValueChanged = false;
	Техника.Visible = true;
	Техника.Name = "Техника";
	Техника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Техника.Description = "Техника";
	Техника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Техника.GroupName = "";
	Техника.Guid = NsgService.StringToGuid("80ec0096-1aa8-411a-b8db-bf997d1a13b1");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
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
	НачальныйЗапасТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	НачальныйЗапасТоплива.Guid = NsgService.StringToGuid("937a32a9-1bdb-4a2c-a957-aa7b79e2b7fe");
	
				if (!ObjectList.Contains("НачальныйЗапасТоплива"))
                    ObjectList.Add(НачальныйЗапасТоплива);
			}
			#endregion //создание System.Decimal НачальныйЗапасТоплива
			
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
	КоличествоЗаправок.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	КоличествоЗаправок.Guid = NsgService.StringToGuid("7ffcbbae-0628-4b7c-80dd-6c9eca8b433d");
	
				if (!ObjectList.Contains("КоличествоЗаправок"))
                    ObjectList.Add(КоличествоЗаправок);
			}
			#endregion //создание System.Decimal КоличествоЗаправок
			
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
	КонечныйЗапасТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	КонечныйЗапасТоплива.Guid = NsgService.StringToGuid("d4bb8ca7-faac-4463-964d-369620be8c42");
	
				if (!ObjectList.Contains("КонечныйЗапасТоплива"))
                    ObjectList.Add(КонечныйЗапасТоплива);
			}
			#endregion //создание System.Decimal КонечныйЗапасТоплива
			
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
	ДатаОкончанияРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	ДатаОкончанияРаботы.Guid = NsgService.StringToGuid("ff8b0576-2f85-4145-a5fd-44da83b31afa");
	
				if (!ObjectList.Contains("ДатаОкончанияРаботы"))
                    ObjectList.Add(ДатаОкончанияРаботы);
			}
			#endregion //создание System.DateTime ДатаОкончанияРаботы
			
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
	ДатаНачалаРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	ДатаНачалаРаботы.Guid = NsgService.StringToGuid("668d0c9b-1969-4b35-aeda-47e078186904");
	
				if (!ObjectList.Contains("ДатаНачалаРаботы"))
                    ObjectList.Add(ДатаНачалаРаботы);
			}
			#endregion //создание System.DateTime ДатаНачалаРаботы
			
			#region создание System.Decimal ДлительностьРаботы
			{  
                NsgDataFloat ДлительностьРаботы = null;
				if (ObjectList.Contains("ДлительностьРаботы"))
                    ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataFloat;
                else
                    ДлительностьРаботы = new NsgDataFloat();
	//NsgDataFloat
	ДлительностьРаботы.IsLoadedFromDll = true;
	ДлительностьРаботы.Precision = 2;
	ДлительностьРаботы.HideZero = true;
	ДлительностьРаботы.DefaultValue = 0M;
	ДлительностьРаботы.MinValue = -100000000000000000M;
	ДлительностьРаботы.MaxValue = 100000000000000000M;
	ДлительностьРаботы.UseCalculator = true;
	ДлительностьРаботы.StringFormat = "";
	ДлительностьРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	ДлительностьРаботы.Guid = NsgService.StringToGuid("cb3e3ca1-93ab-46c5-94b7-1d059ca80efd");
	
				if (!ObjectList.Contains("ДлительностьРаботы"))
                    ObjectList.Add(ДлительностьРаботы);
			}
			#endregion //создание System.Decimal ДлительностьРаботы
			
			#region создание System.Decimal общийОбъемЗаправленногоТоплива
			{  
                NsgDataFloat общийОбъемЗаправленногоТоплива = null;
				if (ObjectList.Contains("общийОбъемЗаправленногоТоплива"))
                    общийОбъемЗаправленногоТоплива = ObjectList["общийОбъемЗаправленногоТоплива"] as NsgDataFloat;
                else
                    общийОбъемЗаправленногоТоплива = new NsgDataFloat();
	//NsgDataFloat
	общийОбъемЗаправленногоТоплива.IsLoadedFromDll = true;
	общийОбъемЗаправленногоТоплива.Precision = 2;
	общийОбъемЗаправленногоТоплива.HideZero = true;
	общийОбъемЗаправленногоТоплива.DefaultValue = 0M;
	общийОбъемЗаправленногоТоплива.MinValue = -100000000000000000M;
	общийОбъемЗаправленногоТоплива.MaxValue = 100000000000000000M;
	общийОбъемЗаправленногоТоплива.UseCalculator = true;
	общийОбъемЗаправленногоТоплива.StringFormat = "";
	общийОбъемЗаправленногоТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	общийОбъемЗаправленногоТоплива.IncludeInPredefined = false;
	общийОбъемЗаправленногоТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	общийОбъемЗаправленногоТоплива.Required = false;
	общийОбъемЗаправленногоТоплива.EmptyValue = "";
	общийОбъемЗаправленногоТоплива.NullAllow = false;
	общийОбъемЗаправленногоТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	общийОбъемЗаправленногоТоплива.FieldName = "obschiijObemZapra";
	общийОбъемЗаправленногоТоплива.SaveInDatabase = true;
	общийОбъемЗаправленногоТоплива.InformMetaDataOnValueChanged = false;
	общийОбъемЗаправленногоТоплива.Visible = true;
	общийОбъемЗаправленногоТоплива.Name = "общийОбъемЗаправленногоТоплива";
	общийОбъемЗаправленногоТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	общийОбъемЗаправленногоТоплива.Description = "общий объем заправленного топлива";
	общийОбъемЗаправленногоТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	общийОбъемЗаправленногоТоплива.GroupName = "";
	общийОбъемЗаправленногоТоплива.Guid = NsgService.StringToGuid("03a3b1e0-d19a-4e2c-ad05-dacc40fdd4c8");
	
				if (!ObjectList.Contains("общийОбъемЗаправленногоТоплива"))
                    ObjectList.Add(общийОбъемЗаправленногоТоплива);
			}
			#endregion //создание System.Decimal общийОбъемЗаправленногоТоплива
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = false;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "РегистрОтработанногоВремени";
	Visible = true;
	Guid = NsgService.StringToGuid("48c89720-3172-47b1-bcaf-a3d635d3cb53");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrOtrabotannog";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "РегистротработанногоВремени";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	ConnectAdditionalTables();

			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataCharacteristics.Names
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
            /// Движения
            /// </summary>
            public static String Движения
            {
                get
                {
                    return "Движения";
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
            /// Количество заправок
            /// </summary>
            public static String КоличествоЗаправок
            {
                get
                {
                    return "КоличествоЗаправок";
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
            /// общий объем заправленного топлива
            /// </summary>
            public static String общийОбъемЗаправленногоТоплива
            {
                get
                {
                    return "общийОбъемЗаправленногоТоплива";
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
                    descriptor.Name = "РегистрОтработанногоВремени";
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
            return "Мониторинг.РегистрОтработанногоВремени";
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
        /// Движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.МониторингРегистрОтработанногоВремениДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.МониторингРегистрОтработанногоВремениДвижения)__Движения.Referent;
            }
            set
            {
                NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                __Движения.Referent = value;
            }
        }
        
        /// <summary>
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра")]
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
        /// Длительность работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ДлительностьРаботы
        {
            get
            {
				 NsgDataFloat __ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataFloat;
                 return (System.Decimal)__ДлительностьРаботы.Value;
            }
            set
            {
                NsgDataFloat __ДлительностьРаботы = ObjectList["ДлительностьРаботы"] as NsgDataFloat;
                __ДлительностьРаботы.Value = value;
            }
        }
        
        /// <summary>
        /// общий объем заправленного топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal общийОбъемЗаправленногоТоплива
        {
            get
            {
				 NsgDataFloat __общийОбъемЗаправленногоТоплива = ObjectList["общийОбъемЗаправленногоТоплива"] as NsgDataFloat;
                 return (System.Decimal)__общийОбъемЗаправленногоТоплива.Value;
            }
            set
            {
                NsgDataFloat __общийОбъемЗаправленногоТоплива = ObjectList["общийОбъемЗаправленногоТоплива"] as NsgDataFloat;
                __общийОбъемЗаправленногоТоплива.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataCharacteristics
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataCharacteristics

        #region Методы NsgMultipleObject
        private РегистрОтработанногоВремени[] convertArray(NsgMultipleObject[] array)
        {
            РегистрОтработанногоВремени[] res = new РегистрОтработанногоВремени[array.Length];
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
        public new virtual РегистрОтработанногоВремени[] FindAll(NsgCompare compare)
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
        public new virtual РегистрОтработанногоВремени[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрОтработанногоВремени[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрОтработанногоВремени[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрОтработанногоВремени(this as NsgObject);
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
                base.NSGType = typeof(РегистрОтработанногоВремени);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрОтработанногоВремени Value
            {
                get
                {
                    return (РегистрОтработанногоВремени)base.Value;
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
                    return "s_NsgDataCharacteristics";
                }
            }
        }

    }

}
