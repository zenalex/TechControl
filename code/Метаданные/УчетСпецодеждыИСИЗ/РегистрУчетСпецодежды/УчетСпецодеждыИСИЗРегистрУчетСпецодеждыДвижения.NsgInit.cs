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
    
    [NsgTypeName("NsgDataTable", Guid = "0668065b-f9e1-42c0-8eb9-34c45e62562d")]
    public partial class УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0668065b-f9e1-42c0-8eb9-34c45e62562d"));
            if (obj == null)
                obj = new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения();
            return obj as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("1bd6cdc1-a43d-48bd-9014-3d46c86272db");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("3f72d77a-d780-4944-84c5-a5ea98ecb165");
	
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
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("708e1f4b-80f3-4c47-b8f1-8a16b171379e");
	
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
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCharacteristicsTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("0668065b-f9e1-42c0-8eb9-34c45e62562d");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetSpecodezhdyISI3";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет спецодежды ИСИЗУчет спецодежды движения";
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
                    descriptor.Name = "УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения";
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
            return "_SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения";
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка NewRow()
        {
            return newRow(null) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка(this);
            return base.newRow(row) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка NewRow(УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка inRow)
        {
            УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка row = inRow.Clone as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
            return base.newRow(row) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка GetEtalonRow()
        {
            УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка row = new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] res = new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка[] AllRows
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
        public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] convertArray(NsgMultipleObject[] array)
        {
            УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] res = new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[array.Length];
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
        public new virtual УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] FindAll(NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения(this as NsgObject);
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
                base.NSGType = typeof(УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения Value
            {
                get
                {
                    return (УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения)base.Value;
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
