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
    
    [NsgTypeName("NsgDataTable", Guid = "3e97f1b1-9245-40d5-9817-b59cad1a46c3")]
    public partial class МониторингФиксацияИсторииСотрудниковДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингФиксацияИсторииСотрудниковДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингФиксацияИсторииСотрудниковДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингФиксацияИсторииСотрудниковДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3e97f1b1-9245-40d5-9817-b59cad1a46c3"));
            if (obj == null)
                obj = new МониторингФиксацияИсторииСотрудниковДвижения();
            return obj as МониторингФиксацияИсторииСотрудниковДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("b4c50400-f217-4859-93a6-1080c00e748a");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("828d8256-7884-4100-bd99-1d2d7f3eac09");
	
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,Мониторинг.ФормированиеСмены,Мониторинг.ЗакрытиеСмены,Мониторинг.ФормированиеСменыДень";
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
	Владелец.Guid = NsgService.StringToGuid("90964b26-84f6-43c1-b7d2-85fbb4efe677");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	Объект.Guid = NsgService.StringToGuid("9d449ff2-06a2-40ae-a897-43782154d9e2");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание Мониторинг.СтатусСотрудника СтатусСотрудника
			{  
                NsgDataEnumReference СтатусСотрудника = null;
				if (ObjectList.Contains("СтатусСотрудника"))
                    СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                else
                    СтатусСотрудника = new NsgDataEnumReference();
	//NsgDataEnumReference
	СтатусСотрудника.IsLoadedFromDll = true;
	СтатусСотрудника.ReferentGroup = "Мониторинг";
	СтатусСотрудника.ReferentName = "СтатусСотрудника";
	СтатусСотрудника.SaveInDatabase = true;
	СтатусСотрудника.OwnerName = "";
	СтатусСотрудника.AllowEmptyOwner = false;
	СтатусСотрудника.StringFormat = "";
	СтатусСотрудника.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	СтатусСотрудника.IncludeInPredefined = false;
	СтатусСотрудника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СтатусСотрудника.Required = false;
	СтатусСотрудника.EmptyValue = "";
	СтатусСотрудника.NullAllow = false;
	СтатусСотрудника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СтатусСотрудника.FieldName = "StatusSotrudnika";
	СтатусСотрудника.InformMetaDataOnValueChanged = false;
	СтатусСотрудника.Visible = true;
	СтатусСотрудника.Name = "СтатусСотрудника";
	СтатусСотрудника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусСотрудника.Description = "Статус сотрудника";
	СтатусСотрудника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СтатусСотрудника.GroupName = "";
	СтатусСотрудника.Guid = NsgService.StringToGuid("b89ab7b8-230c-4ed5-88e0-7db248e3d92f");
	
				if (!ObjectList.Contains("СтатусСотрудника"))
                    ObjectList.Add(СтатусСотрудника);
			}
			#endregion //создание Мониторинг.СтатусСотрудника СтатусСотрудника
			
			#region создание System.DateTime Время
			{  
                NsgDataDateTime Время = null;
				if (ObjectList.Contains("Время"))
                    Время = ObjectList["Время"] as NsgDataDateTime;
                else
                    Время = new NsgDataDateTime();
	//NsgDataDateTime
	Время.IsLoadedFromDll = true;
	Время.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Время.StringFormat = "";
	Время.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Время.IncludeInPredefined = false;
	Время.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Время.Required = false;
	Время.EmptyValue = "";
	Время.NullAllow = false;
	Время.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Время.FieldName = "Vremja";
	Время.SaveInDatabase = true;
	Время.InformMetaDataOnValueChanged = false;
	Время.Visible = true;
	Время.Name = "Время";
	Время.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Время.Description = "Время";
	Время.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Время.GroupName = "";
	Время.Guid = NsgService.StringToGuid("0d6b37d0-3c02-4849-b390-6048bf793df6");
	
				if (!ObjectList.Contains("Время"))
                    ObjectList.Add(Время);
			}
			#endregion //создание System.DateTime Время
			
			#region создание System.Int64 НомерСмены
			{  
                NsgDataInteger НомерСмены = null;
				if (ObjectList.Contains("НомерСмены"))
                    НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                else
                    НомерСмены = new NsgDataInteger();
	//NsgDataInteger
	НомерСмены.IsLoadedFromDll = true;
	НомерСмены.DefaultValue = 0M;
	НомерСмены.MinValue = -10000000000000000000M;
	НомерСмены.MaxValue = 10000000000000000000M;
	НомерСмены.UseCalculator = true;
	НомерСмены.StringFormat = "";
	НомерСмены.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	НомерСмены.IncludeInPredefined = false;
	НомерСмены.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСмены.Required = false;
	НомерСмены.EmptyValue = "";
	НомерСмены.NullAllow = false;
	НомерСмены.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСмены.FieldName = "NomerSmeny";
	НомерСмены.SaveInDatabase = true;
	НомерСмены.InformMetaDataOnValueChanged = false;
	НомерСмены.Visible = true;
	НомерСмены.Name = "НомерСмены";
	НомерСмены.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСмены.Description = "Номер смены";
	НомерСмены.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерСмены.GroupName = "";
	НомерСмены.Guid = NsgService.StringToGuid("9347e562-65a7-43ca-b893-eb9e7e40693f");
	
				if (!ObjectList.Contains("НомерСмены"))
                    ObjectList.Add(НомерСмены);
			}
			#endregion //создание System.Int64 НомерСмены
			
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
	Тариф.Guid = NsgService.StringToGuid("af3ebdf3-6fba-4559-9a7f-700009310d10");
	
				if (!ObjectList.Contains("Тариф"))
                    ObjectList.Add(Тариф);
			}
			#endregion //создание Мониторинг.Тарифы Тариф
			
			#region создание Мониторинг.ФизЛица Сотрудник
			{  
                NsgDataTypedReference Сотрудник = null;
				if (ObjectList.Contains("Сотрудник"))
                    Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                else
                    Сотрудник = new NsgDataTypedReference();
	//NsgDataTypedReference
	Сотрудник.IsLoadedFromDll = true;
	Сотрудник.ReferentGroup = "Мониторинг";
	Сотрудник.ReferentName = "ФизЛица";
	Сотрудник.SaveInDatabase = true;
	Сотрудник.OwnerName = "";
	Сотрудник.AllowEmptyOwner = false;
	Сотрудник.StringFormat = "";
	Сотрудник.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Сотрудник.IncludeInPredefined = false;
	Сотрудник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сотрудник.Required = false;
	Сотрудник.EmptyValue = "";
	Сотрудник.NullAllow = false;
	Сотрудник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сотрудник.FieldName = "Sotrudnik";
	Сотрудник.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Сотрудник.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Сотрудник.CharactericticWeight = 1;
	Сотрудник.InformMetaDataOnValueChanged = false;
	Сотрудник.Visible = true;
	Сотрудник.Name = "Сотрудник";
	Сотрудник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сотрудник.Description = "Сотрудник";
	Сотрудник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сотрудник.GroupName = "";
	Сотрудник.Guid = NsgService.StringToGuid("95546b91-42d3-4d2b-b3b0-eccbf8e79be6");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.ФизЛица Сотрудник
			
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
	Дата.Guid = NsgService.StringToGuid("8ddcfea0-6279-4609-854d-f23f7950c08b");
	
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
	КонецПериода.Guid = NsgService.StringToGuid("31d89e09-1bc4-48c4-bf7f-36ce48382626");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
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
	Должность.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Должность.IncludeInPredefined = false;
	Должность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Должность.Required = false;
	Должность.EmptyValue = "";
	Должность.NullAllow = false;
	Должность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Должность.FieldName = "Dolzhnost";
	Должность.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Должность.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Должность.CharactericticWeight = 1;
	Должность.InformMetaDataOnValueChanged = false;
	Должность.Visible = true;
	Должность.Name = "Должность";
	Должность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Должность.Description = "Должность";
	Должность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Должность.GroupName = "";
	Должность.Guid = NsgService.StringToGuid("4d1fa6dc-c85c-426b-9241-418c68df6d1e");
	
				if (!ObjectList.Contains("Должность"))
                    ObjectList.Add(Должность);
			}
			#endregion //создание Мониторинг.Должности Должность
			
			#region создание Мониторинг.ФормированиеСмены Смена
			{  
                NsgDataTypedReference Смена = null;
				if (ObjectList.Contains("Смена"))
                    Смена = ObjectList["Смена"] as NsgDataTypedReference;
                else
                    Смена = new NsgDataTypedReference();
	//NsgDataTypedReference
	Смена.IsLoadedFromDll = true;
	Смена.ReferentGroup = "Мониторинг";
	Смена.ReferentName = "ФормированиеСмены";
	Смена.SaveInDatabase = true;
	Смена.OwnerName = "";
	Смена.AllowEmptyOwner = false;
	Смена.StringFormat = "";
	Смена.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Смена.IncludeInPredefined = false;
	Смена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Смена.Required = false;
	Смена.EmptyValue = "";
	Смена.NullAllow = false;
	Смена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Смена.FieldName = "Smena";
	Смена.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Смена.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Смена.CharactericticWeight = 1;
	Смена.InformMetaDataOnValueChanged = false;
	Смена.Visible = true;
	Смена.Name = "Смена";
	Смена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Смена.Description = "Смена";
	Смена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Смена.GroupName = "";
	Смена.Guid = NsgService.StringToGuid("ac48fecd-b789-4cf2-9e62-58f1342ddbd0");
	
				if (!ObjectList.Contains("Смена"))
                    ObjectList.Add(Смена);
			}
			#endregion //создание Мониторинг.ФормированиеСмены Смена
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.ФиксацияИсторииСотрудников";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCharacteristicsTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингФиксацияИсторииСотрудниковДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("3e97f1b1-9245-40d5-9817-b59cad1a46c3");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringFiksacija1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг фиксация истории сотрудников движения";
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
            /// Статус сотрудника
            /// </summary>
            public static String СтатусСотрудника
            {
                get
                {
                    return "СтатусСотрудника";
                }
            }
            
            /// <summary>
            /// Время
            /// </summary>
            public static String Время
            {
                get
                {
                    return "Время";
                }
            }
            
            /// <summary>
            /// Номер смены
            /// </summary>
            public static String НомерСмены
            {
                get
                {
                    return "НомерСмены";
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
            /// Смена
            /// </summary>
            public static String Смена
            {
                get
                {
                    return "Смена";
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
                    descriptor.Name = "МониторингФиксацияИсторииСотрудниковДвижения";
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
            return "_SystemTables.МониторингФиксацияИсторииСотрудниковДвижения";
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Мониторинг.ФормированиеСмены,Мониторинг.ЗакрытиеСмены,Мониторинг.ФормированиеСменыДень")]
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
        /// Статус сотрудника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Мониторинг.СтатусСотрудника СтатусСотрудника
        {
            get
            {
				 NsgDataEnumReference __СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                 return (Мониторинг.СтатусСотрудника)__СтатусСотрудника.Referent;
            }
            set
            {
                NsgDataEnumReference __СтатусСотрудника = ObjectList["СтатусСотрудника"] as NsgDataEnumReference;
                __СтатусСотрудника.Referent = value;
            }
        }
        
        /// <summary>
        /// Время
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime Время
        {
            get
            {
				 NsgDataDateTime __Время = ObjectList["Время"] as NsgDataDateTime;
                 return (System.DateTime)__Время.Value;
            }
            set
            {
                NsgDataDateTime __Время = ObjectList["Время"] as NsgDataDateTime;
                __Время.Value = value;
            }
        }
        
        /// <summary>
        /// Номер смены
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСмены
        {
            get
            {
				 NsgDataInteger __НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                 return (System.Int64)__НомерСмены.Value;
            }
            set
            {
                NsgDataInteger __НомерСмены = ObjectList["НомерСмены"] as NsgDataInteger;
                __НомерСмены.Value = value;
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
        /// Сотрудник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.ФизЛица Сотрудник
        {
            get
            {
				 NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                 return (Мониторинг.ФизЛица)__Сотрудник.Referent;
            }
            set
            {
                NsgDataTypedReference __Сотрудник = ObjectList["Сотрудник"] as NsgDataTypedReference;
                __Сотрудник.Referent = value;
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
        /// Смена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDocument")]
        
        public Мониторинг.ФормированиеСмены Смена
        {
            get
            {
				 NsgDataTypedReference __Смена = ObjectList["Смена"] as NsgDataTypedReference;
                 return (Мониторинг.ФормированиеСмены)__Смена.Referent;
            }
            set
            {
                NsgDataTypedReference __Смена = ObjectList["Смена"] as NsgDataTypedReference;
                __Смена.Referent = value;
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
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка NewRow()
        {
            return newRow(null) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингФиксацияИсторииСотрудниковДвижения.Строка(this);
            return base.newRow(row) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингФиксацияИсторииСотрудниковДвижения.Строка NewRow(МониторингФиксацияИсторииСотрудниковДвижения.Строка inRow)
        {
            МониторингФиксацияИсторииСотрудниковДвижения.Строка row = inRow.Clone as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
            return base.newRow(row) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка GetEtalonRow()
        {
            МониторингФиксацияИсторииСотрудниковДвижения.Строка row = new МониторингФиксацияИсторииСотрудниковДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингФиксацияИсторииСотрудниковДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингФиксацияИсторииСотрудниковДвижения.Строка[] res = new МониторингФиксацияИсторииСотрудниковДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингФиксацияИсторииСотрудниковДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингФиксацияИсторииСотрудниковДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка[] AllRows
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
        public new МониторингФиксацияИсторииСотрудниковДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингФиксацияИсторииСотрудниковДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингФиксацияИсторииСотрудниковДвижения[] convertArray(NsgMultipleObject[] array)
        {
            МониторингФиксацияИсторииСотрудниковДвижения[] res = new МониторингФиксацияИсторииСотрудниковДвижения[array.Length];
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
        public new virtual МониторингФиксацияИсторииСотрудниковДвижения[] FindAll(NsgCompare compare)
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
        public new virtual МониторингФиксацияИсторииСотрудниковДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингФиксацияИсторииСотрудниковДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингФиксацияИсторииСотрудниковДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингФиксацияИсторииСотрудниковДвижения(this as NsgObject);
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
                base.NSGType = typeof(МониторингФиксацияИсторииСотрудниковДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингФиксацияИсторииСотрудниковДвижения Value
            {
                get
                {
                    return (МониторингФиксацияИсторииСотрудниковДвижения)base.Value;
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
