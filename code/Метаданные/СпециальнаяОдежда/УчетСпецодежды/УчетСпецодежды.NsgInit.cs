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

namespace TechControl.Метаданные.СпециальнаяОдежда
{
    
    [NsgTypeName("NsgDataRegister", Guid = "e0a368e7-569b-48e9-8a80-27354cd1cd3f")]
    public partial class УчетСпецодежды : NsgSoft.DataObjects.NsgDataRegister
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataRegister

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataRegister
        

        /// <summary>
        /// Конструктор для проведения документов, передается проводимый документ.
        /// </summary>
        public static УчетСпецодежды Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("e0a368e7-569b-48e9-8a80-27354cd1cd3f"));
            if (obj == null)
                obj = new УчетСпецодежды();
            (obj as УчетСпецодежды).Document = document;
            return obj as УчетСпецодежды;
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegister

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected УчетСпецодежды()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСпецодежды(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСпецодежды Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("e0a368e7-569b-48e9-8a80-27354cd1cd3f"));
            if (obj == null)
                obj = new УчетСпецодежды();
            return obj as УчетСпецодежды;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataRegister
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataRegister
			
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
	Идентификатор.Guid = NsgService.StringToGuid("9b2211e3-687d-4cdd-b550-c8f6ee9114a8");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("bc52dc44-0f53-4164-a5d2-ba7dcc149a1e");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыДвижения Движения
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
	Движения.ReferentName = "СпециальнаяОдеждаУчетСпецодеждыДвижения";
	Движения.SaveInDatabase = false;
	Движения.OwnerName = "";
	Движения.AllowEmptyOwner = false;
	Движения.StringFormat = "";
	Движения.SubType = NsgSoft.Common.NsgRekvisitSubType.TabMovement;
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
	Движения.Guid = NsgService.StringToGuid("88ba9c84-bac5-4fe0-8ad4-faeb0deb2129");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыДвижения Движения
			
			#region создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления Накопления
			{  
                NsgRegisterTable Накопления = null;
				if (ObjectList.Contains("Накопления"))
                    Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                else
                    Накопления = new NsgRegisterTable();
	//NsgRegisterTable
	Накопления.IsLoadedFromDll = true;
	Накопления.Name = "Накопления";
	Накопления.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Накопления.RegisterPeriodCount = 1;
	Накопления.ReferentGroup = "_SystemTables";
	Накопления.ReferentName = "СпециальнаяОдеждаУчетСпецодеждыНакопления";
	Накопления.SaveInDatabase = false;
	Накопления.OwnerName = "";
	Накопления.AllowEmptyOwner = false;
	Накопления.StringFormat = "";
	Накопления.SubType = NsgSoft.Common.NsgRekvisitSubType.TabAccumulate;
	Накопления.IncludeInPredefined = false;
	Накопления.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Накопления.Required = false;
	Накопления.EmptyValue = "";
	Накопления.NullAllow = false;
	Накопления.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Накопления.FieldName = "Nakoplenija";
	Накопления.InformMetaDataOnValueChanged = false;
	Накопления.Visible = true;
	Накопления.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Накопления.Description = "Накопления";
	Накопления.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Накопления.GroupName = "";
	Накопления.Guid = NsgService.StringToGuid("ba5de856-cad8-460b-b281-0565d0ed0b03");
	
				if (!ObjectList.Contains("Накопления"))
                    ObjectList.Add(Накопления);
			}
			#endregion //создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления Накопления
			
			#region создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления_1 Накопления_1
			{  
                NsgRegisterTable Накопления_1 = null;
				if (ObjectList.Contains("Накопления_1"))
                    Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                else
                    Накопления_1 = new NsgRegisterTable();
	//NsgRegisterTable
	Накопления_1.IsLoadedFromDll = true;
	Накопления_1.Name = "Накопления_1";
	Накопления_1.RegisterPeriod = NsgSoft.Common.NsgPeriod.Month;
	Накопления_1.RegisterPeriodCount = 1;
	Накопления_1.ReferentGroup = "_SystemTables";
	Накопления_1.ReferentName = "СпециальнаяОдеждаУчетСпецодеждыНакопления_1";
	Накопления_1.SaveInDatabase = false;
	Накопления_1.OwnerName = "";
	Накопления_1.AllowEmptyOwner = false;
	Накопления_1.StringFormat = "";
	Накопления_1.SubType = NsgSoft.Common.NsgRekvisitSubType.TabAccumulate;
	Накопления_1.IncludeInPredefined = false;
	Накопления_1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Накопления_1.Required = false;
	Накопления_1.EmptyValue = "";
	Накопления_1.NullAllow = false;
	Накопления_1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Накопления_1.FieldName = "Nakoplenija_1";
	Накопления_1.InformMetaDataOnValueChanged = false;
	Накопления_1.Visible = true;
	Накопления_1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Накопления_1.Description = "Накопления_1";
	Накопления_1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Накопления_1.GroupName = "";
	Накопления_1.Guid = NsgService.StringToGuid("07c839ee-e7f1-46b7-99d0-91d3855b2117");
	
				if (!ObjectList.Contains("Накопления_1"))
                    ObjectList.Add(Накопления_1);
			}
			#endregion //создание _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления_1 Накопления_1
			
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
	Владелец.Guid = NsgService.StringToGuid("915fc226-80fd-4cf7-9241-a8c2608fc192");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание Сервис.ВидыДвижений ВидДвижения
			{  
                NsgDataEnumReference ВидДвижения = null;
				if (ObjectList.Contains("ВидДвижения"))
                    ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                else
                    ВидДвижения = new NsgDataEnumReference();
	//NsgDataEnumReference
	ВидДвижения.IsLoadedFromDll = true;
	ВидДвижения.ReferentGroup = "Сервис";
	ВидДвижения.ReferentName = "ВидыДвижений";
	ВидДвижения.SaveInDatabase = true;
	ВидДвижения.OwnerName = "";
	ВидДвижения.AllowEmptyOwner = false;
	ВидДвижения.StringFormat = "";
	ВидДвижения.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ВидДвижения.IncludeInPredefined = false;
	ВидДвижения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидДвижения.Required = false;
	ВидДвижения.EmptyValue = "";
	ВидДвижения.NullAllow = false;
	ВидДвижения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидДвижения.FieldName = "_Sign";
	ВидДвижения.InformMetaDataOnValueChanged = false;
	ВидДвижения.Visible = true;
	ВидДвижения.Name = "ВидДвижения";
	ВидДвижения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидДвижения.Description = "Вид движения";
	ВидДвижения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ВидДвижения.GroupName = "";
	ВидДвижения.Guid = NsgService.StringToGuid("18de06f8-c458-43f2-8e5d-5f4c91c339d9");
	
				if (!ObjectList.Contains("ВидДвижения"))
                    ObjectList.Add(ВидДвижения);
			}
			#endregion //создание Сервис.ВидыДвижений ВидДвижения
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("0b4e9952-a9a8-4d7a-bc4d-f0c3f4a0e45d");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.Boolean Активность
			{  
                NsgDataBoolean Активность = null;
				if (ObjectList.Contains("Активность"))
                    Активность = ObjectList["Активность"] as NsgDataBoolean;
                else
                    Активность = new NsgDataBoolean();
	//NsgDataBoolean
	Активность.IsLoadedFromDll = true;
	Активность.DefaultValue = false;
	Активность.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.StringFormat = "";
	Активность.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Активность.IncludeInPredefined = false;
	Активность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Активность.Required = false;
	Активность.EmptyValue = "";
	Активность.NullAllow = false;
	Активность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Активность.FieldName = "_Active";
	Активность.SaveInDatabase = true;
	Активность.InformMetaDataOnValueChanged = false;
	Активность.Visible = true;
	Активность.Name = "Активность";
	Активность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.Description = "Активность";
	Активность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Активность.GroupName = "";
	Активность.Guid = NsgService.StringToGuid("83d8ab27-f2a8-4d23-bf84-a2400bb6e454");
	
				if (!ObjectList.Contains("Активность"))
                    ObjectList.Add(Активность);
			}
			#endregion //создание System.Boolean Активность
			
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
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("c03a8b06-6d06-4920-a2c9-3926c5557776");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Int64 Количество
			
			#region создание СпециальнаяОдежда.Спецодежда Спецодежда
			{  
                NsgDataTypedReference Спецодежда = null;
				if (ObjectList.Contains("Спецодежда"))
                    Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                else
                    Спецодежда = new NsgDataTypedReference();
	//NsgDataTypedReference
	Спецодежда.IsLoadedFromDll = true;
	Спецодежда.ReferentGroup = "СпециальнаяОдежда";
	Спецодежда.ReferentName = "Спецодежда";
	Спецодежда.SaveInDatabase = true;
	Спецодежда.OwnerName = "";
	Спецодежда.AllowEmptyOwner = false;
	Спецодежда.StringFormat = "";
	Спецодежда.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Спецодежда.IncludeInPredefined = false;
	Спецодежда.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Спецодежда.Required = false;
	Спецодежда.EmptyValue = "";
	Спецодежда.NullAllow = false;
	Спецодежда.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Спецодежда.FieldName = "Specodezhda";
	Спецодежда.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Спецодежда.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Спецодежда.CharactericticWeight = 1;
	Спецодежда.InformMetaDataOnValueChanged = false;
	Спецодежда.Visible = true;
	Спецодежда.Name = "Спецодежда";
	Спецодежда.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Спецодежда.Description = "Спецодежда";
	Спецодежда.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Спецодежда.GroupName = "";
	Спецодежда.Guid = NsgService.StringToGuid("81098b01-b622-438e-ad97-1804436a2c4b");
	
				if (!ObjectList.Contains("Спецодежда"))
                    ObjectList.Add(Спецодежда);
			}
			#endregion //создание СпециальнаяОдежда.Спецодежда Спецодежда
			
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
	ДатаВыдачи.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ДатаВыдачи.IncludeInPredefined = false;
	ДатаВыдачи.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаВыдачи.Required = false;
	ДатаВыдачи.EmptyValue = "";
	ДатаВыдачи.NullAllow = false;
	ДатаВыдачи.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаВыдачи.FieldName = "DataVydachi";
	ДатаВыдачи.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	ДатаВыдачи.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	ДатаВыдачи.CharactericticWeight = 1;
	ДатаВыдачи.InformMetaDataOnValueChanged = false;
	ДатаВыдачи.Visible = true;
	ДатаВыдачи.Name = "ДатаВыдачи";
	ДатаВыдачи.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаВыдачи.Description = "Дата выдачи";
	ДатаВыдачи.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаВыдачи.GroupName = "";
	ДатаВыдачи.Guid = NsgService.StringToGuid("2afd82e6-50e8-473f-878c-ba448c1134b8");
	
				if (!ObjectList.Contains("ДатаВыдачи"))
                    ObjectList.Add(ДатаВыдачи);
			}
			#endregion //создание System.DateTime ДатаВыдачи
			
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
	Сотрудник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
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
	Сотрудник.Guid = NsgService.StringToGuid("eae26df2-00e2-42df-b227-5506586e90d1");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.Сотрудники Сотрудник
			
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
	Стоимость.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Стоимость.IncludeInPredefined = false;
	Стоимость.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Стоимость.Required = false;
	Стоимость.EmptyValue = "";
	Стоимость.NullAllow = false;
	Стоимость.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Стоимость.FieldName = "Stoimost";
	Стоимость.InformMetaDataOnValueChanged = false;
	Стоимость.Visible = true;
	Стоимость.Name = "Стоимость";
	Стоимость.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Стоимость.Description = "Стоимость";
	Стоимость.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Стоимость.GroupName = "";
	Стоимость.Guid = NsgService.StringToGuid("509d040b-9a12-4e1a-96cd-faf257b784bb");
	
				if (!ObjectList.Contains("Стоимость"))
                    ObjectList.Add(Стоимость);
			}
			#endregion //создание System.Decimal Стоимость
			

			#region заполнение полей класса
				//NsgDataRegister
	IsLoadedFromDll = true;
	SearchFieldName = "";
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Accummulate;
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "УчетСпецодежды";
	Visible = true;
	Guid = NsgService.StringToGuid("e0a368e7-569b-48e9-8a80-27354cd1cd3f");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_UchetSpecodezhdy";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет спецодежды";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "СпециальнаяОдежда";
	ConnectAdditionalTables();

			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataRegister
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataRegister

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataRegister.Names
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
            /// Накопления
            /// </summary>
            public static String Накопления
            {
                get
                {
                    return "Накопления";
                }
            }
            
            /// <summary>
            /// Накопления_1
            /// </summary>
            public static String Накопления_1
            {
                get
                {
                    return "Накопления_1";
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
            /// Вид движения
            /// </summary>
            public static String ВидДвижения
            {
                get
                {
                    return "ВидДвижения";
                }
            }
            
            /// <summary>
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
                }
            }
            
            /// <summary>
            /// Активность
            /// </summary>
            public static String Активность
            {
                get
                {
                    return "Активность";
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
            /// Спецодежда
            /// </summary>
            public static String Спецодежда
            {
                get
                {
                    return "Спецодежда";
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
            /// Стоимость
            /// </summary>
            public static String Стоимость
            {
                get
                {
                    return "Стоимость";
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
                    descriptor.Name = "УчетСпецодежды";
                    descriptor.GroupName = "СпециальнаяОдежда";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "СпециальнаяОдежда.УчетСпецодежды";
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
        
        public _SystemTables.СпециальнаяОдеждаУчетСпецодеждыДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.СпециальнаяОдеждаУчетСпецодеждыДвижения)__Движения.Referent;
            }
            set
            {
                NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                __Движения.Referent = value;
            }
        }
        
        /// <summary>
        /// Накопления
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления Накопления
        {
            get
            {
				 NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                 return (_SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления)__Накопления.Referent;
            }
            set
            {
                NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                __Накопления.Referent = value;
            }
        }
        
        /// <summary>
        /// Накопления_1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления_1 Накопления_1
        {
            get
            {
				 NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                 return (_SystemTables.СпециальнаяОдеждаУчетСпецодеждыНакопления_1)__Накопления_1.Referent;
            }
            set
            {
                NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                __Накопления_1.Referent = value;
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
        /// Вид движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.ВидыДвижений ВидДвижения
        {
            get
            {
				 NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                 return (Сервис.ВидыДвижений)__ВидДвижения.Referent;
            }
            set
            {
                NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                __ВидДвижения.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Активность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Активность
        {
            get
            {
				 NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                 return (System.Boolean)__Активность.Value;
            }
            set
            {
                NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                __Активность.Value = value;
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
        /// Спецодежда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СпециальнаяОдежда.Спецодежда Спецодежда
        {
            get
            {
				 NsgDataTypedReference __Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                 return (СпециальнаяОдежда.Спецодежда)__Спецодежда.Referent;
            }
            set
            {
                NsgDataTypedReference __Спецодежда = ObjectList["Спецодежда"] as NsgDataTypedReference;
                __Спецодежда.Referent = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataRegister
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataRegister

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataRegister

        #region Методы NsgMultipleObject
        private УчетСпецодежды[] convertArray(NsgMultipleObject[] array)
        {
            УчетСпецодежды[] res = new УчетСпецодежды[array.Length];
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
        public new virtual УчетСпецодежды[] FindAll(NsgCompare compare)
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
        public new virtual УчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСпецодежды(this as NsgObject);
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
                base.NSGType = typeof(УчетСпецодежды);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСпецодежды Value
            {
                get
                {
                    return (УчетСпецодежды)base.Value;
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
                    return "s_NsgDataRegister";
                }
            }
        }

    }

}
