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

namespace TechControl.Метаданные.УчетСпецодеждыИСИЗ
{
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "f0a5c4db-26b7-46b7-8678-3f262d748788")]
    public partial class УчетСпецодеждыИСИЗ : NsgSoft.DataObjects.NsgDataCharacteristics
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
        public static УчетСпецодеждыИСИЗ Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f0a5c4db-26b7-46b7-8678-3f262d748788"));
            if (obj == null)
                obj = new УчетСпецодеждыИСИЗ();
            (obj as УчетСпецодеждыИСИЗ).Document = document;
            return obj as УчетСпецодеждыИСИЗ;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected УчетСпецодеждыИСИЗ()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСпецодеждыИСИЗ(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСпецодеждыИСИЗ Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f0a5c4db-26b7-46b7-8678-3f262d748788"));
            if (obj == null)
                obj = new УчетСпецодеждыИСИЗ();
            return obj as УчетСпецодеждыИСИЗ;
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
	Дата.Guid = NsgService.StringToGuid("a98a047f-70b0-48ba-9574-2d545b96acb9");
	
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
	КонецПериода.Guid = NsgService.StringToGuid("87f818ff-e08a-4202-86f9-1925c453ef54");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
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
	Идентификатор.Guid = NsgService.StringToGuid("0bd32add-6ff5-4d16-b3f2-9e7d70252842");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("a7f401bc-8df4-40ac-b505-da6bd5718d02");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.УчетСпецодеждыИСИЗУчетСпецодеждыИСИЗДвижения Движения
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
	Движения.ReferentName = "УчетСпецодеждыИСИЗУчетСпецодеждыИСИЗДвижения";
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
	Движения.Guid = NsgService.StringToGuid("e4d88724-9f9a-46f5-abce-39e8c57ab000");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.УчетСпецодеждыИСИЗУчетСпецодеждыИСИЗДвижения Движения
			
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,Учет.ПриходнаяНакладная,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды";
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
	Владелец.Guid = NsgService.StringToGuid("2c2a07e6-9c39-41a4-ac70-252db4552c30");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	Сотрудник.Guid = NsgService.StringToGuid("ba3c74ae-e4e6-48f5-9d10-3b4908e15c9d");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудник
			
			#region создание Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
			{  
                NsgDataTypedReference НоменклатураСпецодеждыИСИЗ = null;
				if (ObjectList.Contains("НоменклатураСпецодеждыИСИЗ"))
                    НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                else
                    НоменклатураСпецодеждыИСИЗ = new NsgDataTypedReference();
	//NsgDataTypedReference
	НоменклатураСпецодеждыИСИЗ.IsLoadedFromDll = true;
	НоменклатураСпецодеждыИСИЗ.ReferentGroup = "Учет";
	НоменклатураСпецодеждыИСИЗ.ReferentName = "Номенклатура";
	НоменклатураСпецодеждыИСИЗ.SaveInDatabase = true;
	НоменклатураСпецодеждыИСИЗ.OwnerName = "";
	НоменклатураСпецодеждыИСИЗ.AllowEmptyOwner = false;
	НоменклатураСпецодеждыИСИЗ.StringFormat = "";
	НоменклатураСпецодеждыИСИЗ.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	НоменклатураСпецодеждыИСИЗ.IncludeInPredefined = false;
	НоменклатураСпецодеждыИСИЗ.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НоменклатураСпецодеждыИСИЗ.Required = false;
	НоменклатураСпецодеждыИСИЗ.EmptyValue = "";
	НоменклатураСпецодеждыИСИЗ.NullAllow = false;
	НоменклатураСпецодеждыИСИЗ.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НоменклатураСпецодеждыИСИЗ.FieldName = "NomenklaturaSpeco";
	НоменклатураСпецодеждыИСИЗ.InformMetaDataOnValueChanged = false;
	НоменклатураСпецодеждыИСИЗ.Visible = true;
	НоменклатураСпецодеждыИСИЗ.Name = "НоменклатураСпецодеждыИСИЗ";
	НоменклатураСпецодеждыИСИЗ.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НоменклатураСпецодеждыИСИЗ.Description = "Номенклатура спецодежды ИСИЗ";
	НоменклатураСпецодеждыИСИЗ.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НоменклатураСпецодеждыИСИЗ.GroupName = "";
	НоменклатураСпецодеждыИСИЗ.Guid = NsgService.StringToGuid("86557717-139c-4c10-ab4b-1622f86c966d");
	
				if (!ObjectList.Contains("НоменклатураСпецодеждыИСИЗ"))
                    ObjectList.Add(НоменклатураСпецодеждыИСИЗ);
			}
			#endregion //создание Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
			
			#region создание System.DateTime ДатаВыдачи
			{  
                NsgDataDateTime ДатаВыдачи = null;
				if (ObjectList.Contains("ДатаВыдачи"))
                    ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                else
                    ДатаВыдачи = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаВыдачи.IsLoadedFromDll = true;
	ДатаВыдачи.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаВыдачи.StringFormat = "";
	ДатаВыдачи.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ДатаВыдачи.IncludeInPredefined = false;
	ДатаВыдачи.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаВыдачи.Required = false;
	ДатаВыдачи.EmptyValue = "";
	ДатаВыдачи.NullAllow = false;
	ДатаВыдачи.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаВыдачи.FieldName = "DataVydachi";
	ДатаВыдачи.SaveInDatabase = true;
	ДатаВыдачи.InformMetaDataOnValueChanged = false;
	ДатаВыдачи.Visible = true;
	ДатаВыдачи.Name = "ДатаВыдачи";
	ДатаВыдачи.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаВыдачи.Description = "Дата выдачи";
	ДатаВыдачи.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаВыдачи.GroupName = "";
	ДатаВыдачи.Guid = NsgService.StringToGuid("209df52b-ebaa-481d-9cf3-a0301673b262");
	
				if (!ObjectList.Contains("ДатаВыдачи"))
                    ObjectList.Add(ДатаВыдачи);
			}
			#endregion //создание System.DateTime ДатаВыдачи
			
			#region создание УчетСпецодеждыИСИЗ.КомплектыСпецодежды КомплектСпецодежды
			{  
                NsgDataTypedReference КомплектСпецодежды = null;
				if (ObjectList.Contains("КомплектСпецодежды"))
                    КомплектСпецодежды = ObjectList["КомплектСпецодежды"] as NsgDataTypedReference;
                else
                    КомплектСпецодежды = new NsgDataTypedReference();
	//NsgDataTypedReference
	КомплектСпецодежды.IsLoadedFromDll = true;
	КомплектСпецодежды.ReferentGroup = "УчетСпецодеждыИСИЗ";
	КомплектСпецодежды.ReferentName = "КомплектыСпецодежды";
	КомплектСпецодежды.SaveInDatabase = true;
	КомплектСпецодежды.OwnerName = "";
	КомплектСпецодежды.AllowEmptyOwner = false;
	КомплектСпецодежды.StringFormat = "";
	КомплектСпецодежды.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	КомплектСпецодежды.IncludeInPredefined = false;
	КомплектСпецодежды.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КомплектСпецодежды.Required = false;
	КомплектСпецодежды.EmptyValue = "";
	КомплектСпецодежды.NullAllow = false;
	КомплектСпецодежды.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КомплектСпецодежды.FieldName = "KomplektSpecodezhdy";
	КомплектСпецодежды.InformMetaDataOnValueChanged = false;
	КомплектСпецодежды.Visible = true;
	КомплектСпецодежды.Name = "КомплектСпецодежды";
	КомплектСпецодежды.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КомплектСпецодежды.Description = "Комплект спецодежды";
	КомплектСпецодежды.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КомплектСпецодежды.GroupName = "";
	КомплектСпецодежды.Guid = NsgService.StringToGuid("ec2c4b88-00dd-499b-9269-4c99e6c07f0a");
	
				if (!ObjectList.Contains("КомплектСпецодежды"))
                    ObjectList.Add(КомплектСпецодежды);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.КомплектыСпецодежды КомплектСпецодежды
			
			#region создание Учет.Размеры Размер
			{  
                NsgDataTypedReference Размер = null;
				if (ObjectList.Contains("Размер"))
                    Размер = ObjectList["Размер"] as NsgDataTypedReference;
                else
                    Размер = new NsgDataTypedReference();
	//NsgDataTypedReference
	Размер.IsLoadedFromDll = true;
	Размер.ReferentGroup = "Учет";
	Размер.ReferentName = "Размеры";
	Размер.SaveInDatabase = true;
	Размер.OwnerName = "";
	Размер.AllowEmptyOwner = false;
	Размер.StringFormat = "";
	Размер.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Размер.IncludeInPredefined = false;
	Размер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Размер.Required = false;
	Размер.EmptyValue = "";
	Размер.NullAllow = false;
	Размер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Размер.FieldName = "Razmer";
	Размер.InformMetaDataOnValueChanged = false;
	Размер.Visible = true;
	Размер.Name = "Размер";
	Размер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Размер.Description = "Размер";
	Размер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Размер.GroupName = "";
	Размер.Guid = NsgService.StringToGuid("489471a5-b0eb-4d15-b7ba-236b61211bf1");
	
				if (!ObjectList.Contains("Размер"))
                    ObjectList.Add(Размер);
			}
			#endregion //создание Учет.Размеры Размер
			
			#region создание System.String УникальныйНомер
			{  
                NsgDataString УникальныйНомер = null;
				if (ObjectList.Contains("УникальныйНомер"))
                    УникальныйНомер = ObjectList["УникальныйНомер"] as NsgDataString;
                else
                    УникальныйНомер = new NsgDataString();
	//NsgDataString
	УникальныйНомер.IsLoadedFromDll = true;
	УникальныйНомер.Length = 50;
	УникальныйНомер.StringFormat = "";
	УникальныйНомер.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	УникальныйНомер.IncludeInPredefined = false;
	УникальныйНомер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	УникальныйНомер.Required = false;
	УникальныйНомер.EmptyValue = "";
	УникальныйНомер.NullAllow = false;
	УникальныйНомер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	УникальныйНомер.FieldName = "UnikalnyijNomer";
	УникальныйНомер.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	УникальныйНомер.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	УникальныйНомер.CharactericticWeight = 1;
	УникальныйНомер.InformMetaDataOnValueChanged = false;
	УникальныйНомер.Visible = true;
	УникальныйНомер.Name = "УникальныйНомер";
	УникальныйНомер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	УникальныйНомер.Description = "Уникальный номер";
	УникальныйНомер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	УникальныйНомер.GroupName = "";
	УникальныйНомер.Guid = NsgService.StringToGuid("eb7c355c-d6a8-47e5-9c8a-a5d08c52095c");
	
				if (!ObjectList.Contains("УникальныйНомер"))
                    ObjectList.Add(УникальныйНомер);
			}
			#endregion //создание System.String УникальныйНомер
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = true;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "УчетСпецодеждыИСИЗ";
	Visible = true;
	Guid = NsgService.StringToGuid("f0a5c4db-26b7-46b7-8678-3f262d748788");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_UchetSpecodezhdyISIZ";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Характеристики";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "УчетСпецодеждыИСИЗ";
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
            /// Номенклатура спецодежды ИСИЗ
            /// </summary>
            public static String НоменклатураСпецодеждыИСИЗ
            {
                get
                {
                    return "НоменклатураСпецодеждыИСИЗ";
                }
            }
            
            /// <summary>
            /// Дата выдачи
            /// </summary>
            public static String ДатаВыдачи
            {
                get
                {
                    return "ДатаВыдачи";
                }
            }
            
            /// <summary>
            /// Комплект спецодежды
            /// </summary>
            public static String КомплектСпецодежды
            {
                get
                {
                    return "КомплектСпецодежды";
                }
            }
            
            /// <summary>
            /// Размер
            /// </summary>
            public static String Размер
            {
                get
                {
                    return "Размер";
                }
            }
            
            /// <summary>
            /// Уникальный номер
            /// </summary>
            public static String УникальныйНомер
            {
                get
                {
                    return "УникальныйНомер";
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
                    descriptor.Name = "УчетСпецодеждыИСИЗ";
                    descriptor.GroupName = "УчетСпецодеждыИСИЗ";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "УчетСпецодеждыИСИЗ.УчетСпецодеждыИСИЗ";
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
        
        public _SystemTables.УчетСпецодеждыИСИЗУчетСпецодеждыИСИЗДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.УчетСпецодеждыИСИЗУчетСпецодеждыИСИЗДвижения)__Движения.Referent;
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Учет.ПриходнаяНакладная,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды")]
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
        /// Номенклатура спецодежды ИСИЗ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
        {
            get
            {
				 NsgDataTypedReference __НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                 return (Учет.Номенклатура)__НоменклатураСпецодеждыИСИЗ.Referent;
            }
            set
            {
                NsgDataTypedReference __НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                __НоменклатураСпецодеждыИСИЗ.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата выдачи
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаВыдачи
        {
            get
            {
				 NsgDataDateTime __ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаВыдачи.Value;
            }
            set
            {
                NsgDataDateTime __ДатаВыдачи = ObjectList["ДатаВыдачи"] as NsgDataDateTime;
                __ДатаВыдачи.Value = value;
            }
        }
        
        /// <summary>
        /// Комплект спецодежды
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public КомплектыСпецодежды КомплектСпецодежды
        {
            get
            {
				 NsgDataTypedReference __КомплектСпецодежды = ObjectList["КомплектСпецодежды"] as NsgDataTypedReference;
                 return (КомплектыСпецодежды)__КомплектСпецодежды.Referent;
            }
            set
            {
                NsgDataTypedReference __КомплектСпецодежды = ObjectList["КомплектСпецодежды"] as NsgDataTypedReference;
                __КомплектСпецодежды.Referent = value;
            }
        }
        
        /// <summary>
        /// Размер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Размеры Размер
        {
            get
            {
				 NsgDataTypedReference __Размер = ObjectList["Размер"] as NsgDataTypedReference;
                 return (Учет.Размеры)__Размер.Referent;
            }
            set
            {
                NsgDataTypedReference __Размер = ObjectList["Размер"] as NsgDataTypedReference;
                __Размер.Referent = value;
            }
        }
        
        /// <summary>
        /// Уникальный номер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String УникальныйНомер
        {
            get
            {
				 NsgDataString __УникальныйНомер = ObjectList["УникальныйНомер"] as NsgDataString;
                 return (System.String)__УникальныйНомер.Value;
            }
            set
            {
                NsgDataString __УникальныйНомер = ObjectList["УникальныйНомер"] as NsgDataString;
                __УникальныйНомер.Value = value;
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
        private УчетСпецодеждыИСИЗ[] convertArray(NsgMultipleObject[] array)
        {
            УчетСпецодеждыИСИЗ[] res = new УчетСпецодеждыИСИЗ[array.Length];
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
        public new virtual УчетСпецодеждыИСИЗ[] FindAll(NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗ[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗ[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСпецодеждыИСИЗ[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСпецодеждыИСИЗ(this as NsgObject);
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
                base.NSGType = typeof(УчетСпецодеждыИСИЗ);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСпецодеждыИСИЗ Value
            {
                get
                {
                    return (УчетСпецодеждыИСИЗ)base.Value;
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
