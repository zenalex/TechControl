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
    
    [NsgTypeName("NsgDataTable", Guid = "c008463c-3e29-438d-b7ed-1b705e668cc7")]
    public partial class РегистрыРегистрТарифыТехникиОбъектаДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected РегистрыРегистрТарифыТехникиОбъектаДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрыРегистрТарифыТехникиОбъектаДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрыРегистрТарифыТехникиОбъектаДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("c008463c-3e29-438d-b7ed-1b705e668cc7"));
            if (obj == null)
                obj = new РегистрыРегистрТарифыТехникиОбъектаДвижения();
            return obj as РегистрыРегистрТарифыТехникиОбъектаДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("5d9411a9-4c4a-4513-9560-ad8db798c0b7");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("6cbc9ea6-f0c6-4426-aa89-be176fe2b382");
	
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
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("aa0c4a3b-e8bc-43dc-884c-4efe69576a14");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.DateTime Дата
			{  
                NsgDataDateTime Дата = null;
				if (ObjectList.Contains("Дата"))
                    Дата = ObjectList["Дата"] as NsgDataDateTime;
                else
                    Дата = new NsgDataDateTime();
	//NsgDataDateTime
	Дата.IsLoadedFromDll = true;
	Дата.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Дата.StringFormat = "";
	Дата.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Дата.IncludeInPredefined = false;
	Дата.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Дата.Required = false;
	Дата.EmptyValue = "";
	Дата.NullAllow = false;
	Дата.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Дата.FieldName = "_Date";
	Дата.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Дата.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Дата.CharactericticWeight = 1;
	Дата.InformMetaDataOnValueChanged = false;
	Дата.Visible = true;
	Дата.Name = "Дата";
	Дата.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	Дата.Description = "Дата документа";
	Дата.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Дата.GroupName = "";
	Дата.Guid = NsgService.StringToGuid("29634835-164f-482f-9a5c-46afa913f08e");
	
				if (!ObjectList.Contains("Дата"))
                    ObjectList.Add(Дата);
			}
			#endregion //создание System.DateTime Дата
			
			#region создание System.DateTime КонецПериода
			{  
                NsgDataDateTime КонецПериода = null;
				if (ObjectList.Contains("КонецПериода"))
                    КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                else
                    КонецПериода = new NsgDataDateTime();
	//NsgDataDateTime
	КонецПериода.IsLoadedFromDll = true;
	КонецПериода.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	КонецПериода.StringFormat = "";
	КонецПериода.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	КонецПериода.IncludeInPredefined = false;
	КонецПериода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонецПериода.Required = false;
	КонецПериода.EmptyValue = "";
	КонецПериода.NullAllow = false;
	КонецПериода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонецПериода.FieldName = "_DateEnd";
	КонецПериода.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	КонецПериода.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	КонецПериода.CharactericticWeight = 1;
	КонецПериода.InformMetaDataOnValueChanged = false;
	КонецПериода.Visible = true;
	КонецПериода.Name = "КонецПериода";
	КонецПериода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонецПериода.Description = "Конец периода";
	КонецПериода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	КонецПериода.GroupName = "";
	КонецПериода.Guid = NsgService.StringToGuid("420cd31d-524b-4e9f-b84f-02d61b5c7459");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
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
	Объект.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Объект.IncludeInPredefined = false;
	Объект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объект.Required = false;
	Объект.EmptyValue = "";
	Объект.NullAllow = false;
	Объект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Объект.FieldName = "Obekt";
	Объект.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Объект.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Объект.CharactericticWeight = 1;
	Объект.InformMetaDataOnValueChanged = false;
	Объект.Visible = true;
	Объект.Name = "Объект";
	Объект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объект.Description = "Объект";
	Объект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объект.GroupName = "";
	Объект.Guid = NsgService.StringToGuid("6e32f88e-38af-42f8-ad0f-ee20f1c41ed1");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	Тариф.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	Тариф.Guid = NsgService.StringToGuid("2dd9693d-fc7f-4de3-822d-accb51d8d76c");
	
				if (!ObjectList.Contains("Тариф"))
                    ObjectList.Add(Тариф);
			}
			#endregion //создание Мониторинг.Тарифы Тариф
			
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
	ГруппаСпецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
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
	ГруппаСпецТехники.Guid = NsgService.StringToGuid("2717a53c-7f90-4c90-8023-6f4d1b94b929");
	
				if (!ObjectList.Contains("ГруппаСпецТехники"))
                    ObjectList.Add(ГруппаСпецТехники);
			}
			#endregion //создание Мониторинг.ГруппыСпецТехники ГруппаСпецТехники
			
			#region создание System.Decimal Стоимость
			{  
                NsgDataFloat Стоимость = null;
				if (ObjectList.Contains("Стоимость"))
                    Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                else
                    Стоимость = new NsgDataFloat();
	//NsgDataFloat
	Стоимость.IsLoadedFromDll = true;
	Стоимость.Precision = 2;
	Стоимость.HideZero = true;
	Стоимость.DefaultValue = 0M;
	Стоимость.MinValue = -100000000000000000M;
	Стоимость.MaxValue = 100000000000000000M;
	Стоимость.UseCalculator = true;
	Стоимость.StringFormat = "";
	Стоимость.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Стоимость.IncludeInPredefined = false;
	Стоимость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Стоимость.Required = false;
	Стоимость.EmptyValue = "";
	Стоимость.NullAllow = false;
	Стоимость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Стоимость.FieldName = "Stoimost";
	Стоимость.SaveInDatabase = true;
	Стоимость.InformMetaDataOnValueChanged = false;
	Стоимость.Visible = true;
	Стоимость.Name = "Стоимость";
	Стоимость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Стоимость.Description = "Стоимость";
	Стоимость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Стоимость.GroupName = "";
	Стоимость.Guid = NsgService.StringToGuid("f21317f8-69a3-4296-9dac-268937857bbc");
	
				if (!ObjectList.Contains("Стоимость"))
                    ObjectList.Add(Стоимость);
			}
			#endregion //создание System.Decimal Стоимость
			
			#region создание System.Boolean ИспользоватьПоУмолчанию
			{  
                NsgDataBoolean ИспользоватьПоУмолчанию = null;
				if (ObjectList.Contains("ИспользоватьПоУмолчанию"))
                    ИспользоватьПоУмолчанию = ObjectList["ИспользоватьПоУмолчанию"] as NsgDataBoolean;
                else
                    ИспользоватьПоУмолчанию = new NsgDataBoolean();
	//NsgDataBoolean
	ИспользоватьПоУмолчанию.IsLoadedFromDll = true;
	ИспользоватьПоУмолчанию.DefaultValue = false;
	ИспользоватьПоУмолчанию.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспользоватьПоУмолчанию.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспользоватьПоУмолчанию.StringFormat = "";
	ИспользоватьПоУмолчанию.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИспользоватьПоУмолчанию.IncludeInPredefined = false;
	ИспользоватьПоУмолчанию.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИспользоватьПоУмолчанию.Required = false;
	ИспользоватьПоУмолчанию.EmptyValue = "";
	ИспользоватьПоУмолчанию.NullAllow = false;
	ИспользоватьПоУмолчанию.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИспользоватьПоУмолчанию.FieldName = "IspolzovatPoUmolc";
	ИспользоватьПоУмолчанию.SaveInDatabase = true;
	ИспользоватьПоУмолчанию.InformMetaDataOnValueChanged = false;
	ИспользоватьПоУмолчанию.Visible = true;
	ИспользоватьПоУмолчанию.Name = "ИспользоватьПоУмолчанию";
	ИспользоватьПоУмолчанию.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИспользоватьПоУмолчанию.Description = "Использовать по умолчанию";
	ИспользоватьПоУмолчанию.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ИспользоватьПоУмолчанию.GroupName = "";
	ИспользоватьПоУмолчанию.Guid = NsgService.StringToGuid("9712bf1b-96dc-4d68-b606-b1dd54b532d8");
	
				if (!ObjectList.Contains("ИспользоватьПоУмолчанию"))
                    ObjectList.Add(ИспользоватьПоУмолчанию);
			}
			#endregion //создание System.Boolean ИспользоватьПоУмолчанию
			
			#region создание System.Boolean ТребуетсяСотрудник
			{  
                NsgDataBoolean ТребуетсяСотрудник = null;
				if (ObjectList.Contains("ТребуетсяСотрудник"))
                    ТребуетсяСотрудник = ObjectList["ТребуетсяСотрудник"] as NsgDataBoolean;
                else
                    ТребуетсяСотрудник = new NsgDataBoolean();
	//NsgDataBoolean
	ТребуетсяСотрудник.IsLoadedFromDll = true;
	ТребуетсяСотрудник.DefaultValue = false;
	ТребуетсяСотрудник.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуетсяСотрудник.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуетсяСотрудник.StringFormat = "";
	ТребуетсяСотрудник.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ТребуетсяСотрудник.IncludeInPredefined = false;
	ТребуетсяСотрудник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТребуетсяСотрудник.Required = false;
	ТребуетсяСотрудник.EmptyValue = "";
	ТребуетсяСотрудник.NullAllow = false;
	ТребуетсяСотрудник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТребуетсяСотрудник.FieldName = "TrebuetsjaSotrudnik";
	ТребуетсяСотрудник.SaveInDatabase = true;
	ТребуетсяСотрудник.InformMetaDataOnValueChanged = false;
	ТребуетсяСотрудник.Visible = true;
	ТребуетсяСотрудник.Name = "ТребуетсяСотрудник";
	ТребуетсяСотрудник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуетсяСотрудник.Description = "Требуется сотрудник";
	ТребуетсяСотрудник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТребуетсяСотрудник.GroupName = "";
	ТребуетсяСотрудник.Guid = NsgService.StringToGuid("c6620a0c-a471-4300-9e0d-a6abd251af5a");
	
				if (!ObjectList.Contains("ТребуетсяСотрудник"))
                    ObjectList.Add(ТребуетсяСотрудник);
			}
			#endregion //создание System.Boolean ТребуетсяСотрудник
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Регистры.РегистрТарифыТехникиОбъекта";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCharacteristicsTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "РегистрыРегистрТарифыТехникиОбъектаДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("c008463c-3e29-438d-b7ed-1b705e668cc7");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_RegistryRegistrTari1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистры регистр тарифы техники объекта движения";
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
            /// Дата документа
            /// </summary>
            public static String Дата
            {
                get
                {
                    return "Дата";
                }
            }
            
            /// <summary>
            /// Конец периода
            /// </summary>
            public static String КонецПериода
            {
                get
                {
                    return "КонецПериода";
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
            /// Стоимость
            /// </summary>
            public static String Стоимость
            {
                get
                {
                    return "Стоимость";
                }
            }
            
            /// <summary>
            /// Использовать по умолчанию
            /// </summary>
            public static String ИспользоватьПоУмолчанию
            {
                get
                {
                    return "ИспользоватьПоУмолчанию";
                }
            }
            
            /// <summary>
            /// Требуется сотрудник
            /// </summary>
            public static String ТребуетсяСотрудник
            {
                get
                {
                    return "ТребуетсяСотрудник";
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
                    descriptor.Name = "РегистрыРегистрТарифыТехникиОбъектаДвижения";
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
            return "_SystemTables.РегистрыРегистрТарифыТехникиОбъектаДвижения";
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
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime Дата
        {
            get
            {
				 NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                 return (System.DateTime)__Дата.Value;
            }
            set
            {
                NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                __Дата.Value = value;
            }
        }
        
        /// <summary>
        /// Конец периода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime КонецПериода
        {
            get
            {
				 NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                 return (System.DateTime)__КонецПериода.Value;
            }
            set
            {
                NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                __КонецПериода.Value = value;
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
        /// Стоимость
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Стоимость
        {
            get
            {
				 NsgDataFloat __Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                 return (System.Decimal)__Стоимость.Value;
            }
            set
            {
                NsgDataFloat __Стоимость = ObjectList["Стоимость"] as NsgDataFloat;
                __Стоимость.Value = value;
            }
        }
        
        /// <summary>
        /// Использовать по умолчанию
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ИспользоватьПоУмолчанию
        {
            get
            {
				 NsgDataBoolean __ИспользоватьПоУмолчанию = ObjectList["ИспользоватьПоУмолчанию"] as NsgDataBoolean;
                 return (System.Boolean)__ИспользоватьПоУмолчанию.Value;
            }
            set
            {
                NsgDataBoolean __ИспользоватьПоУмолчанию = ObjectList["ИспользоватьПоУмолчанию"] as NsgDataBoolean;
                __ИспользоватьПоУмолчанию.Value = value;
            }
        }
        
        /// <summary>
        /// Требуется сотрудник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ТребуетсяСотрудник
        {
            get
            {
				 NsgDataBoolean __ТребуетсяСотрудник = ObjectList["ТребуетсяСотрудник"] as NsgDataBoolean;
                 return (System.Boolean)__ТребуетсяСотрудник.Value;
            }
            set
            {
                NsgDataBoolean __ТребуетсяСотрудник = ObjectList["ТребуетсяСотрудник"] as NsgDataBoolean;
                __ТребуетсяСотрудник.Value = value;
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
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка NewRow()
        {
            return newRow(null) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка(this);
            return base.newRow(row) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка NewRow(РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка inRow)
        {
            РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка row = inRow.Clone as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
            return base.newRow(row) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка GetEtalonRow()
        {
            РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка row = new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] res = new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<РегистрыРегистрТарифыТехникиОбъектаДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<РегистрыРегистрТарифыТехникиОбъектаДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка[] AllRows
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
        public new РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as РегистрыРегистрТарифыТехникиОбъектаДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private РегистрыРегистрТарифыТехникиОбъектаДвижения[] convertArray(NsgMultipleObject[] array)
        {
            РегистрыРегистрТарифыТехникиОбъектаДвижения[] res = new РегистрыРегистрТарифыТехникиОбъектаДвижения[array.Length];
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
        public new virtual РегистрыРегистрТарифыТехникиОбъектаДвижения[] FindAll(NsgCompare compare)
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
        public new virtual РегистрыРегистрТарифыТехникиОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрыРегистрТарифыТехникиОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрыРегистрТарифыТехникиОбъектаДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрыРегистрТарифыТехникиОбъектаДвижения(this as NsgObject);
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
                base.NSGType = typeof(РегистрыРегистрТарифыТехникиОбъектаДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрыРегистрТарифыТехникиОбъектаДвижения Value
            {
                get
                {
                    return (РегистрыРегистрТарифыТехникиОбъектаДвижения)base.Value;
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
