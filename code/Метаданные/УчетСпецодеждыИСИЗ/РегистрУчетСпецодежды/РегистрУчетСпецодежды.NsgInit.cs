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
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "0bd23bd2-9eb1-4bbb-a765-27f832202394")]
    public partial class РегистрУчетСпецодежды : NsgSoft.DataObjects.NsgDataCharacteristics
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
        public static РегистрУчетСпецодежды Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0bd23bd2-9eb1-4bbb-a765-27f832202394"));
            if (obj == null)
                obj = new РегистрУчетСпецодежды();
            (obj as РегистрУчетСпецодежды).Document = document;
            return obj as РегистрУчетСпецодежды;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрУчетСпецодежды()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрУчетСпецодежды(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрУчетСпецодежды Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0bd23bd2-9eb1-4bbb-a765-27f832202394"));
            if (obj == null)
                obj = new РегистрУчетСпецодежды();
            return obj as РегистрУчетСпецодежды;
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
	Дата.Guid = NsgService.StringToGuid("36d506c1-6513-460c-9117-9c9560542606");
	
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
	КонецПериода.Guid = NsgService.StringToGuid("f89d6fc5-2d15-4e92-906a-926bbc7c7d8f");
	
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
	Идентификатор.Guid = NsgService.StringToGuid("9d4369a5-681c-45a8-b190-3d1412bdd501");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("09293ac9-5f13-4dd9-8574-2c27c291cae2");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения Движения
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
	Движения.ReferentName = "УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения";
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
	Движения.Guid = NsgService.StringToGuid("2262bdea-634f-4560-a713-514e5f95aca6");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения Движения
			
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды";
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
	Владелец.Guid = NsgService.StringToGuid("9d6119c7-b43b-45ce-b509-bb98aa327e64");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	ДатаВыдачи.Guid = NsgService.StringToGuid("a90910b3-8f55-4a3f-a282-b8fc3fa92395");
	
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
	КомплектСпецодежды.Guid = NsgService.StringToGuid("18b51b8d-7355-43f5-bff3-9b46854f276c");
	
				if (!ObjectList.Contains("КомплектСпецодежды"))
                    ObjectList.Add(КомплектСпецодежды);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.КомплектыСпецодежды КомплектСпецодежды
			
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
	НоменклатураСпецодеждыИСИЗ.Guid = NsgService.StringToGuid("228834b8-f7af-44ac-ad3f-abb5bc528253");
	
				if (!ObjectList.Contains("НоменклатураСпецодеждыИСИЗ"))
                    ObjectList.Add(НоменклатураСпецодеждыИСИЗ);
			}
			#endregion //создание Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
			
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
	Размер.Guid = NsgService.StringToGuid("13b224a8-321f-45e9-b5f5-bee280a8bc4f");
	
				if (!ObjectList.Contains("Размер"))
                    ObjectList.Add(Размер);
			}
			#endregion //создание Учет.Размеры Размер
			
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
	Сотрудник.Guid = NsgService.StringToGuid("8074e74f-bcad-4caf-a8cf-d46044ae4e6c");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.ФизЛица Сотрудник
			
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
	УникальныйНомер.Guid = NsgService.StringToGuid("10c274d7-4b2e-4eb3-a0ff-da74ff3d09e6");
	
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
	Name = "РегистрУчетСпецодежды";
	Visible = true;
	Guid = NsgService.StringToGuid("0bd23bd2-9eb1-4bbb-a765-27f832202394");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrUchetSpecode";
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
                    descriptor.Name = "РегистрУчетСпецодежды";
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
            return "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды";
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
        
        public _SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения)__Движения.Referent;
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды")]
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
        
        public УчетСпецодеждыИСИЗ.КомплектыСпецодежды КомплектСпецодежды
        {
            get
            {
				 NsgDataTypedReference __КомплектСпецодежды = ObjectList["КомплектСпецодежды"] as NsgDataTypedReference;
                 return (УчетСпецодеждыИСИЗ.КомплектыСпецодежды)__КомплектСпецодежды.Referent;
            }
            set
            {
                NsgDataTypedReference __КомплектСпецодежды = ObjectList["КомплектСпецодежды"] as NsgDataTypedReference;
                __КомплектСпецодежды.Referent = value;
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
        private РегистрУчетСпецодежды[] convertArray(NsgMultipleObject[] array)
        {
            РегистрУчетСпецодежды[] res = new РегистрУчетСпецодежды[array.Length];
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
        public new virtual РегистрУчетСпецодежды[] FindAll(NsgCompare compare)
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
        public new virtual РегистрУчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрУчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрУчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрУчетСпецодежды(this as NsgObject);
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
                base.NSGType = typeof(РегистрУчетСпецодежды);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрУчетСпецодежды Value
            {
                get
                {
                    return (РегистрУчетСпецодежды)base.Value;
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
