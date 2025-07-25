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

namespace TechControl.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataDocument", Guid = "34a8ec89-332f-41aa-a616-136ebfd5979b")]
    public partial class ОбщийЖурнал : NsgSoft.DataObjects.NsgDataDocument
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDocument

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDocument

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ОбщийЖурнал()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ОбщийЖурнал(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ОбщийЖурнал Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("34a8ec89-332f-41aa-a616-136ebfd5979b"));
            if (obj == null)
                obj = new ОбщийЖурнал();
            return obj as ОбщийЖурнал;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDocument
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject Наследник
			{  
                NsgDataUntypedReference Наследник = null;
				if (ObjectList.Contains("Наследник"))
                    Наследник = ObjectList["Наследник"] as NsgDataUntypedReference;
                else
                    Наследник = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	Наследник.IsLoadedFromDll = true;
	Наследник.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	Наследник.FilterForConfigurator = "Сервис.КорректировкаРегистра,Мониторинг.ФормированиеСмены,Сервис.СервернаяЗадача,Мониторинг.ОтработанноеВремяТехники,Мониторинг.ЗакрытиеСмены,Мониторинг.Заправка,Мониторинг.ПоставкаТоплива,Мониторинг.ФормированиеСменыДень,СлужебныеСправочники.ПриглашениеПользователя,Учет.ПриходнаяНакладная,Учет.Перемещение,Мониторинг.РегистрацияХодок,Мониторинг.Ходки,СлужебныеСправочники.Уведомления,Мониторинг.ПроверкаЗаправки,Грузы.ВывозГруза,Грузы.ПривозГруза,Учет.ПодтверждениеПеремещения,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды,УчетИнструмента.ПеремещениеИнструмента,Учет.ФормированиеЦены,УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам,УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника,СлужебныеДокументы.Оповещения,УчетСотрудников.НазначенияСотрудников,УчетСотрудников.ПриказОНазначенииСотрудника,Документы.ГрафикРаботыОбъекта,Документы.НастройкиПраздников,Документы.ОтработанныеМесяцы,Документы.ЭСМ,Документы.Доверенности,Документы.ПлановыйГрафикРаботы,Грузы.ДокументыВъезда,Грузы.ДокументыВыезда,Документы.ДокументСменыТекущегоВидаРабот,Документы.ЗаявкиНаРаботы,Документы.ЗаявкиНаТехнику";
	Наследник.ReferentName = "";
	Наследник.ReferentGroup = "";
	Наследник.TypeSelectorName = "";
	Наследник.SaveInDatabase = true;
	Наследник.OwnerName = "";
	Наследник.AllowEmptyOwner = false;
	Наследник.StringFormat = "";
	Наследник.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наследник.IncludeInPredefined = false;
	Наследник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наследник.Required = false;
	Наследник.EmptyValue = "";
	Наследник.NullAllow = false;
	Наследник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Наследник.FieldName = "_RefInherit";
	Наследник.InformMetaDataOnValueChanged = false;
	Наследник.Visible = true;
	Наследник.Name = "Наследник";
	Наследник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Наследник.Description = "Наследник";
	Наследник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Наследник.GroupName = "";
	Наследник.Guid = NsgService.StringToGuid("6ab5eab4-bdd1-4d88-a030-1ca992da207f");
	
				if (!ObjectList.Contains("Наследник"))
                    ObjectList.Add(Наследник);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Наследник
			
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
	Идентификатор.Guid = NsgService.StringToGuid("0cb8b96e-cdf8-4532-a99d-a61df7208d74");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("a361724c-7d45-413d-9534-5807c80f84e0");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.String ПрефиксКода
			{  
                NsgDataString ПрефиксКода = null;
				if (ObjectList.Contains("ПрефиксКода"))
                    ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                else
                    ПрефиксКода = new NsgDataString();
	//NsgDataString
	ПрефиксКода.IsLoadedFromDll = true;
	ПрефиксКода.Length = 10;
	ПрефиксКода.StringFormat = "";
	ПрефиксКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПрефиксКода.IncludeInPredefined = false;
	ПрефиксКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПрефиксКода.Required = false;
	ПрефиксКода.EmptyValue = "";
	ПрефиксКода.NullAllow = false;
	ПрефиксКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПрефиксКода.FieldName = "_CodePrefix";
	ПрефиксКода.SaveInDatabase = true;
	ПрефиксКода.InformMetaDataOnValueChanged = false;
	ПрефиксКода.Visible = true;
	ПрефиксКода.Name = "ПрефиксКода";
	ПрефиксКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПрефиксКода.Description = "Префикс кода";
	ПрефиксКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПрефиксКода.GroupName = "";
	ПрефиксКода.Guid = NsgService.StringToGuid("2516b510-0a3c-4ae5-860b-40d28da33379");
	
				if (!ObjectList.Contains("ПрефиксКода"))
                    ObjectList.Add(ПрефиксКода);
			}
			#endregion //создание System.String ПрефиксКода
			
			#region создание System.Int64 НомерКода
			{  
                NsgDataInteger НомерКода = null;
				if (ObjectList.Contains("НомерКода"))
                    НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                else
                    НомерКода = new NsgDataInteger();
	//NsgDataInteger
	НомерКода.IsLoadedFromDll = true;
	НомерКода.DefaultValue = 0M;
	НомерКода.MinValue = 0M;
	НомерКода.MaxValue = 0M;
	НомерКода.UseCalculator = true;
	НомерКода.StringFormat = "";
	НомерКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерКода.IncludeInPredefined = false;
	НомерКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерКода.Required = false;
	НомерКода.EmptyValue = "";
	НомерКода.NullAllow = false;
	НомерКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерКода.FieldName = "_CodeNumber";
	НомерКода.SaveInDatabase = true;
	НомерКода.InformMetaDataOnValueChanged = false;
	НомерКода.Visible = true;
	НомерКода.Name = "НомерКода";
	НомерКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерКода.Description = "Номер кода";
	НомерКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерКода.GroupName = "";
	НомерКода.Guid = NsgService.StringToGuid("c0d410d7-450b-4103-871a-b2c055a5937e");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String НомерДокумента
			{  
                NsgDataVirtualObject НомерДокумента = null;
				if (ObjectList.Contains("НомерДокумента"))
                    НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                else
                    НомерДокумента = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	НомерДокумента.IsLoadedFromDll = true;
	НомерДокумента.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	НомерДокумента.SaveInDatabase = false;
	НомерДокумента.StringFormat = "";
	НомерДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерДокумента.IncludeInPredefined = false;
	НомерДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерДокумента.Required = false;
	НомерДокумента.EmptyValue = "";
	НомерДокумента.NullAllow = false;
	НомерДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерДокумента.FieldName = "_Code";
	НомерДокумента.InformMetaDataOnValueChanged = false;
	НомерДокумента.Visible = true;
	НомерДокумента.Name = "НомерДокумента";
	НомерДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Номер документа"});
	НомерДокумента.Description = "Номер документа";
	НомерДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерДокумента.GroupName = "";
	НомерДокумента.Guid = NsgService.StringToGuid("75c82003-ad55-4873-ba5f-7e4a9bf6d7bd");
	
				if (!ObjectList.Contains("НомерДокумента"))
                    ObjectList.Add(НомерДокумента);
			}
			#endregion //создание System.String НомерДокумента
			
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
		 new System.Object[]{"Дата документа"});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("a58c02f9-94a8-4565-a884-b30e2229dcdd");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.String Индекс
			{  
                NsgDataIndex Индекс = null;
				if (ObjectList.Contains("Индекс"))
                    Индекс = ObjectList["Индекс"] as NsgDataIndex;
                else
                    Индекс = new NsgDataIndex();
	//NsgDataIndex
	Индекс.IsLoadedFromDll = true;
	Индекс.RequisiteList = "ДатаДокумента,Автоинкремент";
	Индекс.SaveInDatabase = false;
	Индекс.StringFormat = "";
	Индекс.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Индекс.IncludeInPredefined = false;
	Индекс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Индекс.Required = false;
	Индекс.EmptyValue = "";
	Индекс.NullAllow = false;
	Индекс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Индекс.FieldName = "_Index";
	Индекс.InformMetaDataOnValueChanged = false;
	Индекс.Visible = true;
	Индекс.Name = "Индекс";
	Индекс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Индекс.Description = "Индекс";
	Индекс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Индекс.GroupName = "";
	Индекс.Guid = NsgService.StringToGuid("47fe784d-d8a9-4c91-bd04-604ad3f4956f");
	
				if (!ObjectList.Contains("Индекс"))
                    ObjectList.Add(Индекс);
			}
			#endregion //создание System.String Индекс
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			{  
                NsgDataUntypedReference ДокументОснование = null;
				if (ObjectList.Contains("ДокументОснование"))
                    ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                else
                    ДокументОснование = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ДокументОснование.IsLoadedFromDll = true;
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.None;
	ДокументОснование.FilterForConfigurator = "";
	ДокументОснование.ReferentName = "";
	ДокументОснование.ReferentGroup = "";
	ДокументОснование.TypeSelectorName = "";
	ДокументОснование.SaveInDatabase = true;
	ДокументОснование.OwnerName = "";
	ДокументОснование.AllowEmptyOwner = false;
	ДокументОснование.StringFormat = "";
	ДокументОснование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДокументОснование.IncludeInPredefined = false;
	ДокументОснование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументОснование.Required = false;
	ДокументОснование.EmptyValue = "";
	ДокументОснование.NullAllow = false;
	ДокументОснование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДокументОснование.FieldName = "_BaseDocument";
	ДокументОснование.InformMetaDataOnValueChanged = false;
	ДокументОснование.Visible = true;
	ДокументОснование.Name = "ДокументОснование";
	ДокументОснование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументОснование.Description = "Документ основание";
	ДокументОснование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДокументОснование.GroupName = "";
	ДокументОснование.Guid = NsgService.StringToGuid("be12f914-a941-4c1c-92d8-7b87b9997c38");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
			#region создание Сервис.СостоянияОбъекта СостояниеДокумента
			{  
                NsgDataEnumReference СостояниеДокумента = null;
				if (ObjectList.Contains("СостояниеДокумента"))
                    СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                else
                    СостояниеДокумента = new NsgDataEnumReference();
	//NsgDataEnumReference
	СостояниеДокумента.IsLoadedFromDll = true;
	СостояниеДокумента.ReferentGroup = "Сервис";
	СостояниеДокумента.ReferentName = "СостоянияОбъекта";
	СостояниеДокумента.SaveInDatabase = true;
	СостояниеДокумента.OwnerName = "";
	СостояниеДокумента.AllowEmptyOwner = false;
	СостояниеДокумента.StringFormat = "";
	СостояниеДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СостояниеДокумента.IncludeInPredefined = false;
	СостояниеДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СостояниеДокумента.Required = false;
	СостояниеДокумента.EmptyValue = "";
	СостояниеДокумента.NullAllow = false;
	СостояниеДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СостояниеДокумента.FieldName = "_State";
	СостояниеДокумента.InformMetaDataOnValueChanged = false;
	СостояниеДокумента.Visible = true;
	СостояниеДокумента.Name = "СостояниеДокумента";
	СостояниеДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СостояниеДокумента.Description = "Состояние документа";
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("cc070168-474d-4863-8c11-379acc118ede");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "УчетСотрудников.НазначенияСотрудников", "Документы.ГрафикРаботыОбъекта", "Документы.НастройкиПраздников", "Документы.ОтработанныеМесяцы", "Документы.ЭСМ", "Документы.Доверенности", "Документы.ПлановыйГрафикРаботы", "Грузы.ДокументыВъезда", "Грузы.ДокументыВыезда", "Документы.ЗаявкиНаТехнику"});
	SearchFieldName = "НомерДокумента";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП", "УчетСотрудников.РегистрУчетСотрудников", "Регистры.РегистрПерсоналОбъекта", "Регистры.РегистрТехникаОбъекта", "Регистры.РегистрТарифыПерсоналаОбъекта", "Регистры.РегистрТарифыТехникиОбъекта", "Грузы.РегистрПеремещениеЧерезКПП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Interface;
	HasHistory = false;
	AssociatedFields = new NsgSoft.DataObjects.NsgDataFieldsContainer[]{new NsgSoft.DataObjects.NsgDataFieldsContainer("ДатаДокумента",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ПеремещениеСпецодежды", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ЗаказСпецодежды", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструмента", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструментов", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "ДатаДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "ДатаДокумента")}),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer("ПрефиксКода",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ПеремещениеСпецодежды", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ЗаказСпецодежды", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструмента", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструментов", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "ПрефиксКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "ПрефиксКода")}),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer("НомерКода",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ПеремещениеСпецодежды", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ЗаказСпецодежды", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструмента", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструментов", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "НомерКода"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "НомерКода")}),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer("НомерДокумента",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "НомерДокумента"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "НомерДокумента")}),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer("Индекс",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ПеремещениеСпецодежды", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ЗаказСпецодежды", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструмента", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструментов", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "Индекс"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "Индекс")}),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer("ДокументОснование",
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet[]{new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.КорректировкаРегистра", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Сервис.СервернаяЗадача", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСмены", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ОтработанноеВремяТехники", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ЗакрытиеСмены", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Заправка", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПоставкаТоплива", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ПеремещениеСпецодежды", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СпециальнаяОдежда.ЗаказСпецодежды", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструмента", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Инструменты.ПеремещениеИнструментов", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ФормированиеСменыДень", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.ПриглашениеПользователя", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПриходнаяНакладная", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.Перемещение", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.РегистрацияХодок", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.Ходки", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеСправочники.Уведомления", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Мониторинг.ПроверкаЗаправки", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ВывозГруза", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ПривозГруза", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ПодтверждениеПеремещения", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетИнструмента.ПеремещениеИнструмента", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Учет.ФормированиеЦены", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("СлужебныеДокументы.Оповещения", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.НазначенияСотрудников", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("УчетСотрудников.ПриказОНазначенииСотрудника", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ГрафикРаботыОбъекта", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.НастройкиПраздников", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ОтработанныеМесяцы", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЭСМ", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.Доверенности", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ПлановыйГрафикРаботы", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВъезда", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Грузы.ДокументыВыезда", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаРаботы", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ДокументСменыТекущегоВидаРабот", "ДокументОснование"),
		 new NsgSoft.DataObjects.NsgDataFieldsContainer.DataFieldSet("Документы.ЗаявкиНаТехнику", "ДокументОснование")})};
	Alias = "ОбщийЖурнал";
	Name = "ОбщийЖурнал";
	Visible = true;
	Guid = NsgService.StringToGuid("34a8ec89-332f-41aa-a616-136ebfd5979b");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наследник}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "CommonJournal";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Общий журнал";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDocument
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDocument

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDocument.Names
        {
            
            /// <summary>
            /// Наследник
            /// </summary>
            public static String Наследник
            {
                get
                {
                    return "Наследник";
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
            /// Префикс кода
            /// </summary>
            public static String ПрефиксКода
            {
                get
                {
                    return "ПрефиксКода";
                }
            }
            
            /// <summary>
            /// Номер кода
            /// </summary>
            public static String НомерКода
            {
                get
                {
                    return "НомерКода";
                }
            }
            
            /// <summary>
            /// Номер документа
            /// </summary>
            public static String НомерДокумента
            {
                get
                {
                    return "НомерДокумента";
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
            /// Индекс
            /// </summary>
            public static String Индекс
            {
                get
                {
                    return "Индекс";
                }
            }
            
            /// <summary>
            /// Документ основание
            /// </summary>
            public static String ДокументОснование
            {
                get
                {
                    return "ДокументОснование";
                }
            }
            
            /// <summary>
            /// Состояние документа
            /// </summary>
            public static String СостояниеДокумента
            {
                get
                {
                    return "СостояниеДокумента";
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
                    descriptor.Name = "ОбщийЖурнал";
                    descriptor.GroupName = "Сервис";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Сервис.ОбщийЖурнал";
        }

        
        /// <summary>
        /// Наследник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Мониторинг.ФормированиеСмены,Сервис.СервернаяЗадача,Мониторинг.ОтработанноеВремяТехники,Мониторинг.ЗакрытиеСмены,Мониторинг.Заправка,Мониторинг.ПоставкаТоплива,Мониторинг.ФормированиеСменыДень,СлужебныеСправочники.ПриглашениеПользователя,Учет.ПриходнаяНакладная,Учет.Перемещение,Мониторинг.РегистрацияХодок,Мониторинг.Ходки,СлужебныеСправочники.Уведомления,Мониторинг.ПроверкаЗаправки,Грузы.ВывозГруза,Грузы.ПривозГруза,Учет.ПодтверждениеПеремещения,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды,УчетИнструмента.ПеремещениеИнструмента,Учет.ФормированиеЦены,УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам,УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника,СлужебныеДокументы.Оповещения,УчетСотрудников.НазначенияСотрудников,УчетСотрудников.ПриказОНазначенииСотрудника,Документы.ГрафикРаботыОбъекта,Документы.НастройкиПраздников,Документы.ОтработанныеМесяцы,Документы.ЭСМ,Документы.Доверенности,Документы.ПлановыйГрафикРаботы,Грузы.ДокументыВъезда,Грузы.ДокументыВыезда,Документы.ДокументСменыТекущегоВидаРабот,Документы.ЗаявкиНаРаботы,Документы.ЗаявкиНаТехнику")]
        public NsgSoft.DataObjects.NsgReferencedObject Наследник
        {
            get
            {
				 NsgDataUntypedReference __Наследник = ObjectList["Наследник"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__Наследник.Referent;
            }
            set
            {
                NsgDataUntypedReference __Наследник = ObjectList["Наследник"] as NsgDataUntypedReference;
                __Наследник.Referent = value;
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
        /// Префикс кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПрефиксКода
        {
            get
            {
				 NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                 return (System.String)__ПрефиксКода.Value;
            }
            set
            {
                NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                __ПрефиксКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерКода
        {
            get
            {
				 NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                 return (System.Int64)__НомерКода.Value;
            }
            set
            {
                NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                __НомерКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String НомерДокумента
        {
            get
            {
				 NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                 return (System.String)__НомерДокумента.Value;
            }
            set
            {
                NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                __НомерДокумента.Value = value;
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
        /// Индекс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataIndex")]
        
        public System.String Индекс
        {
            get
            {
				 NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                 return (System.String)__Индекс.Value;
            }
            set
            {
                NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                __Индекс.Value = value;
            }
        }
        
        /// <summary>
        /// Документ основание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("")]
        public NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
        {
            get
            {
				 NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ДокументОснование.Referent;
            }
            set
            {
                NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                __ДокументОснование.Referent = value;
            }
        }
        
        /// <summary>
        /// Состояние документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.СостоянияОбъекта СостояниеДокумента
        {
            get
            {
				 NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                 return (Сервис.СостоянияОбъекта)__СостояниеДокумента.Referent;
            }
            set
            {
                NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                __СостояниеДокумента.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDocument
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataDocument

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDocument
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDocument

        #region Методы NsgMultipleObject
        private ОбщийЖурнал[] convertArray(NsgMultipleObject[] array)
        {
            ОбщийЖурнал[] res = new ОбщийЖурнал[array.Length];
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
        public new virtual ОбщийЖурнал[] FindAll(NsgCompare compare)
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
        public new virtual ОбщийЖурнал[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ОбщийЖурнал[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ОбщийЖурнал[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ОбщийЖурнал(this as NsgObject);
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
                base.NSGType = typeof(ОбщийЖурнал);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ОбщийЖурнал Value
            {
                get
                {
                    return (ОбщийЖурнал)base.Value;
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
                    return "s_NsgDataDocument";
                }
            }
        }

    }

}
