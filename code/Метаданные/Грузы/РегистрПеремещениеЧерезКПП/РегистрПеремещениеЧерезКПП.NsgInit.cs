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

namespace TechControl.Метаданные.Грузы
{
    
    [NsgTypeName("NsgDataRegister", Guid = "b5bc8d01-aede-4260-8455-3b9730a065ff")]
    public partial class РегистрПеремещениеЧерезКПП : NsgSoft.DataObjects.NsgDataRegister
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
        public static РегистрПеремещениеЧерезКПП Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b5bc8d01-aede-4260-8455-3b9730a065ff"));
            if (obj == null)
                obj = new РегистрПеремещениеЧерезКПП();
            (obj as РегистрПеремещениеЧерезКПП).Document = document;
            return obj as РегистрПеремещениеЧерезКПП;
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegister

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрПеремещениеЧерезКПП()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрПеремещениеЧерезКПП(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрПеремещениеЧерезКПП Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("b5bc8d01-aede-4260-8455-3b9730a065ff"));
            if (obj == null)
                obj = new РегистрПеремещениеЧерезКПП();
            return obj as РегистрПеремещениеЧерезКПП;
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
	Идентификатор.Guid = NsgService.StringToGuid("b251debc-4368-436e-be79-e9f1377299e1");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("103746a3-a416-4329-945a-700e5c47d9c1");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППДвижения Движения
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
	Движения.ReferentName = "ГрузыРегистрПеремещениеЧерезКППДвижения";
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
	Движения.Guid = NsgService.StringToGuid("d259f292-c7ea-4c8e-8716-79339aabb51b");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППДвижения Движения
			
			#region создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления Накопления
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
	Накопления.ReferentName = "ГрузыРегистрПеремещениеЧерезКППНакопления";
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
	Накопления.Guid = NsgService.StringToGuid("1aabd7fc-1eea-4821-8fde-d7878ad1a77e");
	
				if (!ObjectList.Contains("Накопления"))
                    ObjectList.Add(Накопления);
			}
			#endregion //создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления Накопления
			
			#region создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления_1 Накопления_1
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
	Накопления_1.ReferentName = "ГрузыРегистрПеремещениеЧерезКППНакопления_1";
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
	Накопления_1.Guid = NsgService.StringToGuid("4f299db7-77ea-45e0-aeaa-ab24c70045f4");
	
				if (!ObjectList.Contains("Накопления_1"))
                    ObjectList.Add(Накопления_1);
			}
			#endregion //создание _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления_1 Накопления_1
			
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,Грузы.ДокументыВъезда,Грузы.ДокументыВыезда";
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
	Владелец.Guid = NsgService.StringToGuid("b83d1edf-4460-422f-b32d-85c255c74b58");
	
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
	ВидДвижения.Guid = NsgService.StringToGuid("5d7a4289-b18f-40c9-9600-8357b64fcc6b");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("1c2e0925-acf5-4d61-8117-7ed783e7f2dc");
	
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
	Активность.Guid = NsgService.StringToGuid("f5256a03-d2a7-4067-bca1-7da833c363d5");
	
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
	Техника.Guid = NsgService.StringToGuid("658df213-8cba-4342-a847-7003238d76cc");
	
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
	Объект.Guid = NsgService.StringToGuid("8a5952ff-dad7-4c9a-b379-c8a57ce084a2");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
			#region создание System.Int64 НахождениеНаОбъекте
			{  
                NsgDataInteger НахождениеНаОбъекте = null;
				if (ObjectList.Contains("НахождениеНаОбъекте"))
                    НахождениеНаОбъекте = ObjectList["НахождениеНаОбъекте"] as NsgDataInteger;
                else
                    НахождениеНаОбъекте = new NsgDataInteger();
	//NsgDataInteger
	НахождениеНаОбъекте.IsLoadedFromDll = true;
	НахождениеНаОбъекте.DefaultValue = 0M;
	НахождениеНаОбъекте.MinValue = 0M;
	НахождениеНаОбъекте.MaxValue = 0M;
	НахождениеНаОбъекте.UseCalculator = true;
	НахождениеНаОбъекте.StringFormat = "";
	НахождениеНаОбъекте.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	НахождениеНаОбъекте.IncludeInPredefined = false;
	НахождениеНаОбъекте.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НахождениеНаОбъекте.Required = false;
	НахождениеНаОбъекте.EmptyValue = "";
	НахождениеНаОбъекте.NullAllow = false;
	НахождениеНаОбъекте.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НахождениеНаОбъекте.FieldName = "NakhozhdenieNaObekte";
	НахождениеНаОбъекте.InformMetaDataOnValueChanged = false;
	НахождениеНаОбъекте.Visible = true;
	НахождениеНаОбъекте.Name = "НахождениеНаОбъекте";
	НахождениеНаОбъекте.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НахождениеНаОбъекте.Description = "Нахождение на объекте";
	НахождениеНаОбъекте.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НахождениеНаОбъекте.GroupName = "";
	НахождениеНаОбъекте.Guid = NsgService.StringToGuid("81b56c31-67fd-4fb7-8deb-272e2c96b8b4");
	
				if (!ObjectList.Contains("НахождениеНаОбъекте"))
                    ObjectList.Add(НахождениеНаОбъекте);
			}
			#endregion //создание System.Int64 НахождениеНаОбъекте
			
			#region создание Грузы.КонтрольноПропускныеПункты КПП
			{  
                NsgDataTypedReference КПП = null;
				if (ObjectList.Contains("КПП"))
                    КПП = ObjectList["КПП"] as NsgDataTypedReference;
                else
                    КПП = new NsgDataTypedReference();
	//NsgDataTypedReference
	КПП.IsLoadedFromDll = true;
	КПП.ReferentGroup = "Грузы";
	КПП.ReferentName = "КонтрольноПропускныеПункты";
	КПП.SaveInDatabase = true;
	КПП.OwnerName = "";
	КПП.AllowEmptyOwner = false;
	КПП.StringFormat = "";
	КПП.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	КПП.IncludeInPredefined = false;
	КПП.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КПП.Required = false;
	КПП.EmptyValue = "";
	КПП.NullAllow = false;
	КПП.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КПП.FieldName = "KPP";
	КПП.InformMetaDataOnValueChanged = false;
	КПП.Visible = true;
	КПП.Name = "КПП";
	КПП.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КПП.Description = "КПП";
	КПП.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КПП.GroupName = "";
	КПП.Guid = NsgService.StringToGuid("8d2ea08f-7c7b-48ac-a5dc-6f565b55a4e6");
	
				if (!ObjectList.Contains("КПП"))
                    ObjectList.Add(КПП);
			}
			#endregion //создание Грузы.КонтрольноПропускныеПункты КПП
			

			#region заполнение полей класса
				//NsgDataRegister
	IsLoadedFromDll = true;
	SearchFieldName = "";
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Accummulate;
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "РегистрПеремещениеЧерезКПП";
	Visible = true;
	Guid = NsgService.StringToGuid("b5bc8d01-aede-4260-8455-3b9730a065ff");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_reg_RegistrPeremescheni";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистр";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Грузы";
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
            /// Нахождение на объекте
            /// </summary>
            public static String НахождениеНаОбъекте
            {
                get
                {
                    return "НахождениеНаОбъекте";
                }
            }
            
            /// <summary>
            /// КПП
            /// </summary>
            public static String КПП
            {
                get
                {
                    return "КПП";
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
                    descriptor.Name = "РегистрПеремещениеЧерезКПП";
                    descriptor.GroupName = "Грузы";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Грузы.РегистрПеремещениеЧерезКПП";
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
        
        public _SystemTables.ГрузыРегистрПеремещениеЧерезКППДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.ГрузыРегистрПеремещениеЧерезКППДвижения)__Движения.Referent;
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
        
        public _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления Накопления
        {
            get
            {
				 NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                 return (_SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления)__Накопления.Referent;
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
        
        public _SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления_1 Накопления_1
        {
            get
            {
				 NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                 return (_SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления_1)__Накопления_1.Referent;
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Грузы.ДокументыВъезда,Грузы.ДокументыВыезда")]
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
        /// Нахождение на объекте
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НахождениеНаОбъекте
        {
            get
            {
				 NsgDataInteger __НахождениеНаОбъекте = ObjectList["НахождениеНаОбъекте"] as NsgDataInteger;
                 return (System.Int64)__НахождениеНаОбъекте.Value;
            }
            set
            {
                NsgDataInteger __НахождениеНаОбъекте = ObjectList["НахождениеНаОбъекте"] as NsgDataInteger;
                __НахождениеНаОбъекте.Value = value;
            }
        }
        
        /// <summary>
        /// КПП
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Грузы.КонтрольноПропускныеПункты КПП
        {
            get
            {
				 NsgDataTypedReference __КПП = ObjectList["КПП"] as NsgDataTypedReference;
                 return (Грузы.КонтрольноПропускныеПункты)__КПП.Referent;
            }
            set
            {
                NsgDataTypedReference __КПП = ObjectList["КПП"] as NsgDataTypedReference;
                __КПП.Referent = value;
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
        private РегистрПеремещениеЧерезКПП[] convertArray(NsgMultipleObject[] array)
        {
            РегистрПеремещениеЧерезКПП[] res = new РегистрПеремещениеЧерезКПП[array.Length];
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
        public new virtual РегистрПеремещениеЧерезКПП[] FindAll(NsgCompare compare)
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
        public new virtual РегистрПеремещениеЧерезКПП[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрПеремещениеЧерезКПП[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрПеремещениеЧерезКПП[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрПеремещениеЧерезКПП(this as NsgObject);
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
                base.NSGType = typeof(РегистрПеремещениеЧерезКПП);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрПеремещениеЧерезКПП Value
            {
                get
                {
                    return (РегистрПеремещениеЧерезКПП)base.Value;
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
