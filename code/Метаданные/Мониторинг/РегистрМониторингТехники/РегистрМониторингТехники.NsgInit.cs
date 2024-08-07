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
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "7b195da5-41c5-4f12-b74b-895fa0a08c81")]
    public partial class РегистрМониторингТехники : NsgSoft.DataObjects.NsgDataCharacteristics
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
        public static РегистрМониторингТехники Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("7b195da5-41c5-4f12-b74b-895fa0a08c81"));
            if (obj == null)
                obj = new РегистрМониторингТехники();
            (obj as РегистрМониторингТехники).Document = document;
            return obj as РегистрМониторингТехники;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрМониторингТехники()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрМониторингТехники(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрМониторингТехники Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("7b195da5-41c5-4f12-b74b-895fa0a08c81"));
            if (obj == null)
                obj = new РегистрМониторингТехники();
            return obj as РегистрМониторингТехники;
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
	Идентификатор.Guid = NsgService.StringToGuid("bd2e0f4f-7f6d-47e7-be98-637a5d80ed90");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("72ae1d02-f76d-424f-a4a0-1caca158d19b");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.МониторингРегистрМониторингТехникиДвижения Движения
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
	Движения.ReferentName = "МониторингРегистрМониторингТехникиДвижения";
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
	Движения.Guid = NsgService.StringToGuid("5a88508c-0ace-4f3d-8b08-022108e9eb2d");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.МониторингРегистрМониторингТехникиДвижения Движения
			
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
	Владелец.Guid = NsgService.StringToGuid("048a2b36-88c0-42e1-843b-4638339ffda1");
	
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
	Техника.Guid = NsgService.StringToGuid("c57723b1-d715-41e3-96ce-f0772d59fa89");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
			#region создание System.Decimal ТекущаяСкорость
			{  
                NsgDataFloat ТекущаяСкорость = null;
				if (ObjectList.Contains("ТекущаяСкорость"))
                    ТекущаяСкорость = ObjectList["ТекущаяСкорость"] as NsgDataFloat;
                else
                    ТекущаяСкорость = new NsgDataFloat();
	//NsgDataFloat
	ТекущаяСкорость.IsLoadedFromDll = true;
	ТекущаяСкорость.Precision = 2;
	ТекущаяСкорость.HideZero = true;
	ТекущаяСкорость.DefaultValue = 0M;
	ТекущаяСкорость.MinValue = -100000000000000000M;
	ТекущаяСкорость.MaxValue = 100000000000000000M;
	ТекущаяСкорость.UseCalculator = true;
	ТекущаяСкорость.StringFormat = "";
	ТекущаяСкорость.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ТекущаяСкорость.IncludeInPredefined = false;
	ТекущаяСкорость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТекущаяСкорость.Required = false;
	ТекущаяСкорость.EmptyValue = "";
	ТекущаяСкорость.NullAllow = false;
	ТекущаяСкорость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТекущаяСкорость.FieldName = "TekuschajaSkorost";
	ТекущаяСкорость.SaveInDatabase = true;
	ТекущаяСкорость.InformMetaDataOnValueChanged = false;
	ТекущаяСкорость.Visible = true;
	ТекущаяСкорость.Name = "ТекущаяСкорость";
	ТекущаяСкорость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТекущаяСкорость.Description = "Текущая скорость";
	ТекущаяСкорость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТекущаяСкорость.GroupName = "";
	ТекущаяСкорость.Guid = NsgService.StringToGuid("2e515f7c-bdad-4e5f-a699-5368c62c183a");
	
				if (!ObjectList.Contains("ТекущаяСкорость"))
                    ObjectList.Add(ТекущаяСкорость);
			}
			#endregion //создание System.Decimal ТекущаяСкорость
			
			#region создание Мониторинг.СтатусТехники СтатусТехники
			{  
                NsgDataEnumReference СтатусТехники = null;
				if (ObjectList.Contains("СтатусТехники"))
                    СтатусТехники = ObjectList["СтатусТехники"] as NsgDataEnumReference;
                else
                    СтатусТехники = new NsgDataEnumReference();
	//NsgDataEnumReference
	СтатусТехники.IsLoadedFromDll = true;
	СтатусТехники.ReferentGroup = "Мониторинг";
	СтатусТехники.ReferentName = "СтатусТехники";
	СтатусТехники.SaveInDatabase = true;
	СтатусТехники.OwnerName = "";
	СтатусТехники.AllowEmptyOwner = false;
	СтатусТехники.StringFormat = "";
	СтатусТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	СтатусТехники.IncludeInPredefined = false;
	СтатусТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СтатусТехники.Required = false;
	СтатусТехники.EmptyValue = "";
	СтатусТехники.NullAllow = false;
	СтатусТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СтатусТехники.FieldName = "StatusTekhniki";
	СтатусТехники.InformMetaDataOnValueChanged = false;
	СтатусТехники.Visible = true;
	СтатусТехники.Name = "СтатусТехники";
	СтатусТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусТехники.Description = "Статус техники";
	СтатусТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СтатусТехники.GroupName = "";
	СтатусТехники.Guid = NsgService.StringToGuid("0dccd082-8f19-4d2d-91c4-c0fd6e8c11d9");
	
				if (!ObjectList.Contains("СтатусТехники"))
                    ObjectList.Add(СтатусТехники);
			}
			#endregion //создание Мониторинг.СтатусТехники СтатусТехники
			
			#region создание TechControl.Метаданные.Мониторинг.РегистрМониторингТехникиФормаЭлемента ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "TechControl.Метаданные.Мониторинг.РегистрМониторингТехникиФормаЭлемента";
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
	ФормаЭлемента.Guid = NsgService.StringToGuid("bb8394c8-d12c-4b3e-9090-008559c90ea4");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание TechControl.Метаданные.Мониторинг.РегистрМониторингТехникиФормаЭлемента ФормаЭлемента
			
			#region создание System.Decimal Широта
			{  
                NsgDataFloat Широта = null;
				if (ObjectList.Contains("Широта"))
                    Широта = ObjectList["Широта"] as NsgDataFloat;
                else
                    Широта = new NsgDataFloat();
	//NsgDataFloat
	Широта.IsLoadedFromDll = true;
	Широта.Precision = 7;
	Широта.HideZero = true;
	Широта.DefaultValue = 0M;
	Широта.MinValue = -100000000000000000M;
	Широта.MaxValue = 100000000000000000M;
	Широта.UseCalculator = true;
	Широта.StringFormat = "";
	Широта.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	Широта.Guid = NsgService.StringToGuid("0377dcd3-55f6-42d4-b4dc-ef74e514bd62");
	
				if (!ObjectList.Contains("Широта"))
                    ObjectList.Add(Широта);
			}
			#endregion //создание System.Decimal Широта
			
			#region создание System.Decimal ТекущееКолвоТоплива
			{  
                NsgDataFloat ТекущееКолвоТоплива = null;
				if (ObjectList.Contains("ТекущееКолвоТоплива"))
                    ТекущееКолвоТоплива = ObjectList["ТекущееКолвоТоплива"] as NsgDataFloat;
                else
                    ТекущееКолвоТоплива = new NsgDataFloat();
	//NsgDataFloat
	ТекущееКолвоТоплива.IsLoadedFromDll = true;
	ТекущееКолвоТоплива.Precision = 2;
	ТекущееКолвоТоплива.HideZero = true;
	ТекущееКолвоТоплива.DefaultValue = 0M;
	ТекущееКолвоТоплива.MinValue = -100000000000000000M;
	ТекущееКолвоТоплива.MaxValue = 100000000000000000M;
	ТекущееКолвоТоплива.UseCalculator = true;
	ТекущееКолвоТоплива.StringFormat = "";
	ТекущееКолвоТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ТекущееКолвоТоплива.IncludeInPredefined = false;
	ТекущееКолвоТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТекущееКолвоТоплива.Required = false;
	ТекущееКолвоТоплива.EmptyValue = "";
	ТекущееКолвоТоплива.NullAllow = false;
	ТекущееКолвоТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТекущееКолвоТоплива.FieldName = "TekuscheeKolvoTop";
	ТекущееКолвоТоплива.SaveInDatabase = true;
	ТекущееКолвоТоплива.InformMetaDataOnValueChanged = false;
	ТекущееКолвоТоплива.Visible = true;
	ТекущееКолвоТоплива.Name = "ТекущееКолвоТоплива";
	ТекущееКолвоТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТекущееКолвоТоплива.Description = "Текущее колво топлива";
	ТекущееКолвоТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТекущееКолвоТоплива.GroupName = "";
	ТекущееКолвоТоплива.Guid = NsgService.StringToGuid("4d6f41f9-d181-482c-a3c9-d82668d1adfe");
	
				if (!ObjectList.Contains("ТекущееКолвоТоплива"))
                    ObjectList.Add(ТекущееКолвоТоплива);
			}
			#endregion //создание System.Decimal ТекущееКолвоТоплива
			
			#region создание System.Decimal Долгота
			{  
                NsgDataFloat Долгота = null;
				if (ObjectList.Contains("Долгота"))
                    Долгота = ObjectList["Долгота"] as NsgDataFloat;
                else
                    Долгота = new NsgDataFloat();
	//NsgDataFloat
	Долгота.IsLoadedFromDll = true;
	Долгота.Precision = 7;
	Долгота.HideZero = true;
	Долгота.DefaultValue = 0M;
	Долгота.MinValue = -100000000000000000M;
	Долгота.MaxValue = 100000000000000000M;
	Долгота.UseCalculator = true;
	Долгота.StringFormat = "";
	Долгота.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	Долгота.Guid = NsgService.StringToGuid("6bd0b9dc-df8b-4839-a597-d07a6b5eb814");
	
				if (!ObjectList.Contains("Долгота"))
                    ObjectList.Add(Долгота);
			}
			#endregion //создание System.Decimal Долгота
			
			#region создание System.Boolean ПодНагрузкой
			{  
                NsgDataBoolean ПодНагрузкой = null;
				if (ObjectList.Contains("ПодНагрузкой"))
                    ПодНагрузкой = ObjectList["ПодНагрузкой"] as NsgDataBoolean;
                else
                    ПодНагрузкой = new NsgDataBoolean();
	//NsgDataBoolean
	ПодНагрузкой.IsLoadedFromDll = true;
	ПодНагрузкой.DefaultValue = false;
	ПодНагрузкой.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПодНагрузкой.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПодНагрузкой.StringFormat = "";
	ПодНагрузкой.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ПодНагрузкой.IncludeInPredefined = false;
	ПодНагрузкой.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПодНагрузкой.Required = false;
	ПодНагрузкой.EmptyValue = "";
	ПодНагрузкой.NullAllow = false;
	ПодНагрузкой.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПодНагрузкой.FieldName = "PodNagruzkoij";
	ПодНагрузкой.SaveInDatabase = true;
	ПодНагрузкой.InformMetaDataOnValueChanged = false;
	ПодНагрузкой.Visible = true;
	ПодНагрузкой.Name = "ПодНагрузкой";
	ПодНагрузкой.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПодНагрузкой.Description = "Под нагрузкой";
	ПодНагрузкой.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПодНагрузкой.GroupName = "";
	ПодНагрузкой.Guid = NsgService.StringToGuid("e0cc3e9d-fc42-4c01-8cdb-b4204334ff97");
	
				if (!ObjectList.Contains("ПодНагрузкой"))
                    ObjectList.Add(ПодНагрузкой);
			}
			#endregion //создание System.Boolean ПодНагрузкой
			
			#region создание Мониторинг.ФизЛица Сотрудники
			{  
                NsgDataTypedReference Сотрудники = null;
				if (ObjectList.Contains("Сотрудники"))
                    Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                else
                    Сотрудники = new NsgDataTypedReference();
	//NsgDataTypedReference
	Сотрудники.IsLoadedFromDll = true;
	Сотрудники.ReferentGroup = "Мониторинг";
	Сотрудники.ReferentName = "ФизЛица";
	Сотрудники.SaveInDatabase = true;
	Сотрудники.OwnerName = "";
	Сотрудники.AllowEmptyOwner = false;
	Сотрудники.StringFormat = "";
	Сотрудники.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Сотрудники.IncludeInPredefined = false;
	Сотрудники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудники.Required = false;
	Сотрудники.EmptyValue = "";
	Сотрудники.NullAllow = false;
	Сотрудники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сотрудники.FieldName = "Sotrudniki";
	Сотрудники.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Сотрудники.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Сотрудники.CharactericticWeight = 1;
	Сотрудники.InformMetaDataOnValueChanged = false;
	Сотрудники.Visible = true;
	Сотрудники.Name = "Сотрудники";
	Сотрудники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудники.Description = "Сотрудники";
	Сотрудники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудники.GroupName = "";
	Сотрудники.Guid = NsgService.StringToGuid("c85c7767-9db7-4bb4-8ebc-74f5ded3a9ac");
	
				if (!ObjectList.Contains("Сотрудники"))
                    ObjectList.Add(Сотрудники);
			}
			#endregion //создание Мониторинг.ФизЛица Сотрудники
			
			#region создание Мониторинг.Объекты Объекты
			{  
                NsgDataTypedReference Объекты = null;
				if (ObjectList.Contains("Объекты"))
                    Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                else
                    Объекты = new NsgDataTypedReference();
	//NsgDataTypedReference
	Объекты.IsLoadedFromDll = true;
	Объекты.ReferentGroup = "Мониторинг";
	Объекты.ReferentName = "Объекты";
	Объекты.SaveInDatabase = true;
	Объекты.OwnerName = "";
	Объекты.AllowEmptyOwner = false;
	Объекты.StringFormat = "";
	Объекты.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Объекты.IncludeInPredefined = false;
	Объекты.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объекты.Required = false;
	Объекты.EmptyValue = "";
	Объекты.NullAllow = false;
	Объекты.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Объекты.FieldName = "Obekty";
	Объекты.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Объекты.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Объекты.CharactericticWeight = 1;
	Объекты.InformMetaDataOnValueChanged = false;
	Объекты.Visible = true;
	Объекты.Name = "Объекты";
	Объекты.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объекты.Description = "Объекты";
	Объекты.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объекты.GroupName = "";
	Объекты.Guid = NsgService.StringToGuid("05ff7720-caff-4265-8858-3040948c452c");
	
				if (!ObjectList.Contains("Объекты"))
                    ObjectList.Add(Объекты);
			}
			#endregion //создание Мониторинг.Объекты Объекты
			
			#region создание System.Boolean РаботаетДвигатель
			{  
                NsgDataBoolean РаботаетДвигатель = null;
				if (ObjectList.Contains("РаботаетДвигатель"))
                    РаботаетДвигатель = ObjectList["РаботаетДвигатель"] as NsgDataBoolean;
                else
                    РаботаетДвигатель = new NsgDataBoolean();
	//NsgDataBoolean
	РаботаетДвигатель.IsLoadedFromDll = true;
	РаботаетДвигатель.DefaultValue = false;
	РаботаетДвигатель.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РаботаетДвигатель.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РаботаетДвигатель.StringFormat = "";
	РаботаетДвигатель.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	РаботаетДвигатель.IncludeInPredefined = false;
	РаботаетДвигатель.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РаботаетДвигатель.Required = false;
	РаботаетДвигатель.EmptyValue = "";
	РаботаетДвигатель.NullAllow = false;
	РаботаетДвигатель.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РаботаетДвигатель.FieldName = "RabotaetDvigatel";
	РаботаетДвигатель.SaveInDatabase = true;
	РаботаетДвигатель.InformMetaDataOnValueChanged = false;
	РаботаетДвигатель.Visible = true;
	РаботаетДвигатель.Name = "РаботаетДвигатель";
	РаботаетДвигатель.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РаботаетДвигатель.Description = "Работает двигатель";
	РаботаетДвигатель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РаботаетДвигатель.GroupName = "";
	РаботаетДвигатель.Guid = NsgService.StringToGuid("fec583f1-8e89-4e3d-a523-3d05acb77d36");
	
				if (!ObjectList.Contains("РаботаетДвигатель"))
                    ObjectList.Add(РаботаетДвигатель);
			}
			#endregion //создание System.Boolean РаботаетДвигатель
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = false;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "РегистрМониторингТехники";
	Visible = true;
	Guid = NsgService.StringToGuid("7b195da5-41c5-4f12-b74b-895fa0a08c81");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrMonitoringTe";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистр мониторинг техники";
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
            /// Текущая скорость
            /// </summary>
            public static String ТекущаяСкорость
            {
                get
                {
                    return "ТекущаяСкорость";
                }
            }
            
            /// <summary>
            /// Статус техники
            /// </summary>
            public static String СтатусТехники
            {
                get
                {
                    return "СтатусТехники";
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
            /// Текущее колво топлива
            /// </summary>
            public static String ТекущееКолвоТоплива
            {
                get
                {
                    return "ТекущееКолвоТоплива";
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
            /// Под нагрузкой
            /// </summary>
            public static String ПодНагрузкой
            {
                get
                {
                    return "ПодНагрузкой";
                }
            }
            
            /// <summary>
            /// Сотрудники
            /// </summary>
            public static String Сотрудники
            {
                get
                {
                    return "Сотрудники";
                }
            }
            
            /// <summary>
            /// Объекты
            /// </summary>
            public static String Объекты
            {
                get
                {
                    return "Объекты";
                }
            }
            
            /// <summary>
            /// Работает двигатель
            /// </summary>
            public static String РаботаетДвигатель
            {
                get
                {
                    return "РаботаетДвигатель";
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
                    descriptor.Name = "РегистрМониторингТехники";
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
            return "Мониторинг.РегистрМониторингТехники";
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
        
        public _SystemTables.МониторингРегистрМониторингТехникиДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.МониторингРегистрМониторингТехникиДвижения)__Движения.Referent;
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
        /// Текущая скорость
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ТекущаяСкорость
        {
            get
            {
				 NsgDataFloat __ТекущаяСкорость = ObjectList["ТекущаяСкорость"] as NsgDataFloat;
                 return (System.Decimal)__ТекущаяСкорость.Value;
            }
            set
            {
                NsgDataFloat __ТекущаяСкорость = ObjectList["ТекущаяСкорость"] as NsgDataFloat;
                __ТекущаяСкорость.Value = value;
            }
        }
        
        /// <summary>
        /// Статус техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.СтатусТехники СтатусТехники
        {
            get
            {
				 NsgDataEnumReference __СтатусТехники = ObjectList["СтатусТехники"] as NsgDataEnumReference;
                 return (Мониторинг.СтатусТехники)__СтатусТехники.Referent;
            }
            set
            {
                NsgDataEnumReference __СтатусТехники = ObjectList["СтатусТехники"] as NsgDataEnumReference;
                __СтатусТехники.Referent = value;
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
        /// Текущее колво топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal ТекущееКолвоТоплива
        {
            get
            {
				 NsgDataFloat __ТекущееКолвоТоплива = ObjectList["ТекущееКолвоТоплива"] as NsgDataFloat;
                 return (System.Decimal)__ТекущееКолвоТоплива.Value;
            }
            set
            {
                NsgDataFloat __ТекущееКолвоТоплива = ObjectList["ТекущееКолвоТоплива"] as NsgDataFloat;
                __ТекущееКолвоТоплива.Value = value;
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
        /// Под нагрузкой
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ПодНагрузкой
        {
            get
            {
				 NsgDataBoolean __ПодНагрузкой = ObjectList["ПодНагрузкой"] as NsgDataBoolean;
                 return (System.Boolean)__ПодНагрузкой.Value;
            }
            set
            {
                NsgDataBoolean __ПодНагрузкой = ObjectList["ПодНагрузкой"] as NsgDataBoolean;
                __ПодНагрузкой.Value = value;
            }
        }
        
        /// <summary>
        /// Сотрудники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Сотрудники
        {
            get
            {
				 NsgDataTypedReference __Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Сотрудники.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудники = ObjectList["Сотрудники"] as NsgDataTypedReference;
                __Сотрудники.Referent = value;
            }
        }
        
        /// <summary>
        /// Объекты
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Объекты Объекты
        {
            get
            {
				 NsgDataTypedReference __Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                 return (Мониторинг.Объекты)__Объекты.Referent;
            }
            set
            {
                NsgDataTypedReference __Объекты = ObjectList["Объекты"] as NsgDataTypedReference;
                __Объекты.Referent = value;
            }
        }
        
        /// <summary>
        /// Работает двигатель
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean РаботаетДвигатель
        {
            get
            {
				 NsgDataBoolean __РаботаетДвигатель = ObjectList["РаботаетДвигатель"] as NsgDataBoolean;
                 return (System.Boolean)__РаботаетДвигатель.Value;
            }
            set
            {
                NsgDataBoolean __РаботаетДвигатель = ObjectList["РаботаетДвигатель"] as NsgDataBoolean;
                __РаботаетДвигатель.Value = value;
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
        
        #region Свойства NsgSoft.DataObjects.NsgDataCharacteristics
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataCharacteristics

        #region Методы NsgMultipleObject
        private РегистрМониторингТехники[] convertArray(NsgMultipleObject[] array)
        {
            РегистрМониторингТехники[] res = new РегистрМониторингТехники[array.Length];
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
        public new virtual РегистрМониторингТехники[] FindAll(NsgCompare compare)
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
        public new virtual РегистрМониторингТехники[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрМониторингТехники[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрМониторингТехники[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрМониторингТехники(this as NsgObject);
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
                base.NSGType = typeof(РегистрМониторингТехники);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрМониторингТехники Value
            {
                get
                {
                    return (РегистрМониторингТехники)base.Value;
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
