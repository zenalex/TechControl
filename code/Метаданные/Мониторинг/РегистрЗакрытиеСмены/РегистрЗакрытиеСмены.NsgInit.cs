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
    
    [NsgTypeName("NsgDataRegister", Guid = "25547e60-b3e0-45df-900e-1ab407fb308a")]
    public partial class РегистрЗакрытиеСмены : NsgSoft.DataObjects.NsgDataRegister
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
        public static РегистрЗакрытиеСмены Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("25547e60-b3e0-45df-900e-1ab407fb308a"));
            if (obj == null)
                obj = new РегистрЗакрытиеСмены();
            (obj as РегистрЗакрытиеСмены).Document = document;
            return obj as РегистрЗакрытиеСмены;
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegister

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрЗакрытиеСмены()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрЗакрытиеСмены(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрЗакрытиеСмены Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("25547e60-b3e0-45df-900e-1ab407fb308a"));
            if (obj == null)
                obj = new РегистрЗакрытиеСмены();
            return obj as РегистрЗакрытиеСмены;
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
	Идентификатор.Guid = NsgService.StringToGuid("9e2e31eb-c584-4d5f-9506-26c5796e183e");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("62d972ec-1ed4-4dcd-a52d-fdb037673b0c");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.МониторингРегистрЗакрытиеСменыДвижения Движения
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
	Движения.ReferentName = "МониторингРегистрЗакрытиеСменыДвижения";
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
	Движения.Guid = NsgService.StringToGuid("051824c9-7f84-4965-9f9f-d5bbced1cd3f");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.МониторингРегистрЗакрытиеСменыДвижения Движения
			
			#region создание _SystemTables.МониторингРегистрЗакрытиеСменыНакопления Накопления
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
	Накопления.ReferentName = "МониторингРегистрЗакрытиеСменыНакопления";
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
	Накопления.Guid = NsgService.StringToGuid("8120901a-ac97-4356-8159-d05366edb11f");
	
				if (!ObjectList.Contains("Накопления"))
                    ObjectList.Add(Накопления);
			}
			#endregion //создание _SystemTables.МониторингРегистрЗакрытиеСменыНакопления Накопления
			
			#region создание _SystemTables.МониторингРегистрЗакрытиеСменыНакопления_1 Накопления_1
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
	Накопления_1.ReferentName = "МониторингРегистрЗакрытиеСменыНакопления_1";
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
	Накопления_1.Guid = NsgService.StringToGuid("f0d92c8b-59c2-4a70-9a52-748177e8d53b");
	
				if (!ObjectList.Contains("Накопления_1"))
                    ObjectList.Add(Накопления_1);
			}
			#endregion //создание _SystemTables.МониторингРегистрЗакрытиеСменыНакопления_1 Накопления_1
			
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
	Владелец.Guid = NsgService.StringToGuid("3ae6416a-e2d6-40ac-8e4f-5a2580bbaa4d");
	
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
	ВидДвижения.Guid = NsgService.StringToGuid("26cd8d1f-c294-4202-abaf-6c6aaf69fd03");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("4570175b-94ce-41ad-b178-74a8dd7b8672");
	
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
	Активность.Guid = NsgService.StringToGuid("215ad065-4d99-43c2-aa1e-26c016b3d8af");
	
				if (!ObjectList.Contains("Активность"))
                    ObjectList.Add(Активность);
			}
			#endregion //создание System.Boolean Активность
			
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
	Техника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
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
	Техника.Guid = NsgService.StringToGuid("24ec25d4-eaec-4ada-9706-7a74f43711fa");
	
				if (!ObjectList.Contains("Техника"))
                    ObjectList.Add(Техника);
			}
			#endregion //создание Мониторинг.Техника Техника
			
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
	Объект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
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
	Объект.Guid = NsgService.StringToGuid("7e0cf6e7-810c-4579-915b-c8affe404eb9");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание System.Decimal Сумма
			{  
                NsgDataFloat Сумма = null;
				if (ObjectList.Contains("Сумма"))
                    Сумма = ObjectList["Сумма"] as NsgDataFloat;
                else
                    Сумма = new NsgDataFloat();
	//NsgDataFloat
	Сумма.IsLoadedFromDll = true;
	Сумма.Precision = 2;
	Сумма.HideZero = true;
	Сумма.DefaultValue = 0M;
	Сумма.MinValue = -100000000000000000M;
	Сумма.MaxValue = 100000000000000000M;
	Сумма.UseCalculator = true;
	Сумма.StringFormat = "";
	Сумма.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Сумма.IncludeInPredefined = false;
	Сумма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сумма.Required = false;
	Сумма.EmptyValue = "";
	Сумма.NullAllow = false;
	Сумма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сумма.FieldName = "Summa";
	Сумма.InformMetaDataOnValueChanged = false;
	Сумма.Visible = true;
	Сумма.Name = "Сумма";
	Сумма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сумма.Description = "Сумма";
	Сумма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сумма.GroupName = "";
	Сумма.Guid = NsgService.StringToGuid("64c94dd1-0ade-4b6e-949b-59e92fbcf7ca");
	
				if (!ObjectList.Contains("Сумма"))
                    ObjectList.Add(Сумма);
			}
			#endregion //создание System.Decimal Сумма
			
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
	Время.Guid = NsgService.StringToGuid("ae5807ed-7159-40ef-8425-46bc29fee6f5");
	
				if (!ObjectList.Contains("Время"))
                    ObjectList.Add(Время);
			}
			#endregion //создание System.DateTime Время
			

			#region заполнение полей класса
				//NsgDataRegister
	IsLoadedFromDll = true;
	SearchFieldName = "";
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Accummulate;
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "РегистрЗакрытиеСмены";
	Visible = true;
	Guid = NsgService.StringToGuid("25547e60-b3e0-45df-900e-1ab407fb308a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrZakrytieSmeny";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистр закрытие смены";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
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
            /// Сумма
            /// </summary>
            public static String Сумма
            {
                get
                {
                    return "Сумма";
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
                    descriptor.Name = "РегистрЗакрытиеСмены";
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
            return "Мониторинг.РегистрЗакрытиеСмены";
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
        
        public _SystemTables.МониторингРегистрЗакрытиеСменыДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.МониторингРегистрЗакрытиеСменыДвижения)__Движения.Referent;
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
        
        public _SystemTables.МониторингРегистрЗакрытиеСменыНакопления Накопления
        {
            get
            {
				 NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                 return (_SystemTables.МониторингРегистрЗакрытиеСменыНакопления)__Накопления.Referent;
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
        
        public _SystemTables.МониторингРегистрЗакрытиеСменыНакопления_1 Накопления_1
        {
            get
            {
				 NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                 return (_SystemTables.МониторингРегистрЗакрытиеСменыНакопления_1)__Накопления_1.Referent;
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
        /// Сумма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Сумма
        {
            get
            {
				 NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                 return (System.Decimal)__Сумма.Value;
            }
            set
            {
                NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                __Сумма.Value = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataRegister
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataRegister

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataRegister

        #region Методы NsgMultipleObject
        private РегистрЗакрытиеСмены[] convertArray(NsgMultipleObject[] array)
        {
            РегистрЗакрытиеСмены[] res = new РегистрЗакрытиеСмены[array.Length];
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
        public new virtual РегистрЗакрытиеСмены[] FindAll(NsgCompare compare)
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
        public new virtual РегистрЗакрытиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрЗакрытиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрЗакрытиеСмены[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрЗакрытиеСмены(this as NsgObject);
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
                base.NSGType = typeof(РегистрЗакрытиеСмены);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрЗакрытиеСмены Value
            {
                get
                {
                    return (РегистрЗакрытиеСмены)base.Value;
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
