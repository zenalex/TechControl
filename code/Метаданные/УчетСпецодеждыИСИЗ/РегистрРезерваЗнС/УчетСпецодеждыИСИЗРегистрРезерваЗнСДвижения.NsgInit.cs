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
    
    [NsgTypeName("NsgDataTable", Guid = "e8456305-38ae-4a39-84ef-6f7687bddaac")]
    public partial class УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("e8456305-38ae-4a39-84ef-6f7687bddaac"));
            if (obj == null)
                obj = new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения();
            return obj as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("8f5a971c-1d66-4099-9db0-586cf6cbeb2f");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("230780cf-ff15-4e1f-b63c-9144e01c26ad");
	
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,Учет.ПриходнаяНакладная,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды,УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника";
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
	Владелец.Guid = NsgService.StringToGuid("b2e52a99-c34c-44a4-8743-c28609cced01");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("36edebf3-3eee-464d-a11b-08f662a4b7cb");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
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
	ВидДвижения.Guid = NsgService.StringToGuid("9581a2b8-e984-4cf6-8361-47d4b577fa04");
	
				if (!ObjectList.Contains("ВидДвижения"))
                    ObjectList.Add(ВидДвижения);
			}
			#endregion //создание Сервис.ВидыДвижений ВидДвижения
			
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
	Активность.Guid = NsgService.StringToGuid("c788c479-0c25-4a50-8f65-40fb81ae6cab");
	
				if (!ObjectList.Contains("Активность"))
                    ObjectList.Add(Активность);
			}
			#endregion //создание System.Boolean Активность
			
			#region создание Учет.Номенклатура Номенклатура
			{  
                NsgDataTypedReference Номенклатура = null;
				if (ObjectList.Contains("Номенклатура"))
                    Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                else
                    Номенклатура = new NsgDataTypedReference();
	//NsgDataTypedReference
	Номенклатура.IsLoadedFromDll = true;
	Номенклатура.ReferentGroup = "Учет";
	Номенклатура.ReferentName = "Номенклатура";
	Номенклатура.SaveInDatabase = true;
	Номенклатура.OwnerName = "";
	Номенклатура.AllowEmptyOwner = false;
	Номенклатура.StringFormat = "";
	Номенклатура.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Номенклатура.IncludeInPredefined = false;
	Номенклатура.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Номенклатура.Required = false;
	Номенклатура.EmptyValue = "";
	Номенклатура.NullAllow = false;
	Номенклатура.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Номенклатура.FieldName = "Nomenklatura";
	Номенклатура.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Номенклатура.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Номенклатура.CharactericticWeight = 1;
	Номенклатура.InformMetaDataOnValueChanged = false;
	Номенклатура.Visible = true;
	Номенклатура.Name = "Номенклатура";
	Номенклатура.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Номенклатура.Description = "Номенклатура";
	Номенклатура.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Номенклатура.GroupName = "";
	Номенклатура.Guid = NsgService.StringToGuid("af223456-4429-4730-988e-8c5f19e28ac7");
	
				if (!ObjectList.Contains("Номенклатура"))
                    ObjectList.Add(Номенклатура);
			}
			#endregion //создание Учет.Номенклатура Номенклатура
			
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
	Сотрудник.Guid = NsgService.StringToGuid("6af92899-02e6-42e7-b90d-ef1543a3e4da");
	
				if (!ObjectList.Contains("Сотрудник"))
                    ObjectList.Add(Сотрудник);
			}
			#endregion //создание Мониторинг.ФизЛица Сотрудник
			
			#region создание Мониторинг.Контрагенты Поставщик
			{  
                NsgDataTypedReference Поставщик = null;
				if (ObjectList.Contains("Поставщик"))
                    Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                else
                    Поставщик = new NsgDataTypedReference();
	//NsgDataTypedReference
	Поставщик.IsLoadedFromDll = true;
	Поставщик.ReferentGroup = "Мониторинг";
	Поставщик.ReferentName = "Контрагенты";
	Поставщик.SaveInDatabase = true;
	Поставщик.OwnerName = "";
	Поставщик.AllowEmptyOwner = false;
	Поставщик.StringFormat = "";
	Поставщик.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Поставщик.IncludeInPredefined = false;
	Поставщик.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Поставщик.Required = false;
	Поставщик.EmptyValue = "";
	Поставщик.NullAllow = false;
	Поставщик.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Поставщик.FieldName = "Postavschik";
	Поставщик.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Поставщик.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Поставщик.CharactericticWeight = 1;
	Поставщик.InformMetaDataOnValueChanged = false;
	Поставщик.Visible = true;
	Поставщик.Name = "Поставщик";
	Поставщик.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Поставщик.Description = "Поставщик";
	Поставщик.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Поставщик.GroupName = "";
	Поставщик.Guid = NsgService.StringToGuid("53f4f90c-3be2-456a-9acb-a495d6f88316");
	
				if (!ObjectList.Contains("Поставщик"))
                    ObjectList.Add(Поставщик);
			}
			#endregion //создание Мониторинг.Контрагенты Поставщик
			
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
	Объект.Guid = NsgService.StringToGuid("0b4bd6e9-329f-4cff-ab29-7debdbe03256");
	
				if (!ObjectList.Contains("Объект"))
                    ObjectList.Add(Объект);
			}
			#endregion //создание Мониторинг.Объекты Объект
			
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
	Размер.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Размер.IncludeInPredefined = false;
	Размер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Размер.Required = false;
	Размер.EmptyValue = "";
	Размер.NullAllow = false;
	Размер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Размер.FieldName = "Razmer";
	Размер.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Размер.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Размер.CharactericticWeight = 1;
	Размер.InformMetaDataOnValueChanged = false;
	Размер.Visible = true;
	Размер.Name = "Размер";
	Размер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Размер.Description = "Размер";
	Размер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Размер.GroupName = "";
	Размер.Guid = NsgService.StringToGuid("d12fbaf1-7a6f-49c0-9420-a5b724c83df0");
	
				if (!ObjectList.Contains("Размер"))
                    ObjectList.Add(Размер);
			}
			#endregion //создание Учет.Размеры Размер
			
			#region создание System.Decimal Количество
			{  
                NsgDataFloat Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataFloat;
                else
                    Количество = new NsgDataFloat();
	//NsgDataFloat
	Количество.IsLoadedFromDll = true;
	Количество.Precision = 2;
	Количество.HideZero = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = -100000000000000000M;
	Количество.MaxValue = 100000000000000000M;
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
	Количество.Guid = NsgService.StringToGuid("77a86192-97ab-4ad9-845d-ef8be284b1f0");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Decimal Количество
			
			#region создание УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника ДокументЗаявкиНаСотрудника
			{  
                NsgDataTypedReference ДокументЗаявкиНаСотрудника = null;
				if (ObjectList.Contains("ДокументЗаявкиНаСотрудника"))
                    ДокументЗаявкиНаСотрудника = ObjectList["ДокументЗаявкиНаСотрудника"] as NsgDataTypedReference;
                else
                    ДокументЗаявкиНаСотрудника = new NsgDataTypedReference();
	//NsgDataTypedReference
	ДокументЗаявкиНаСотрудника.IsLoadedFromDll = true;
	ДокументЗаявкиНаСотрудника.ReferentGroup = "УчетСпецодеждыИСИЗ";
	ДокументЗаявкиНаСотрудника.ReferentName = "ЗаявкаНаСотрудника";
	ДокументЗаявкиНаСотрудника.SaveInDatabase = true;
	ДокументЗаявкиНаСотрудника.OwnerName = "";
	ДокументЗаявкиНаСотрудника.AllowEmptyOwner = false;
	ДокументЗаявкиНаСотрудника.StringFormat = "";
	ДокументЗаявкиНаСотрудника.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ДокументЗаявкиНаСотрудника.IncludeInPredefined = false;
	ДокументЗаявкиНаСотрудника.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументЗаявкиНаСотрудника.Required = false;
	ДокументЗаявкиНаСотрудника.EmptyValue = "";
	ДокументЗаявкиНаСотрудника.NullAllow = false;
	ДокументЗаявкиНаСотрудника.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДокументЗаявкиНаСотрудника.FieldName = "DokumentZajavki";
	ДокументЗаявкиНаСотрудника.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	ДокументЗаявкиНаСотрудника.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	ДокументЗаявкиНаСотрудника.CharactericticWeight = 1;
	ДокументЗаявкиНаСотрудника.InformMetaDataOnValueChanged = false;
	ДокументЗаявкиНаСотрудника.Visible = true;
	ДокументЗаявкиНаСотрудника.Name = "ДокументЗаявкиНаСотрудника";
	ДокументЗаявкиНаСотрудника.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументЗаявкиНаСотрудника.Description = "Документ заявки на сотрудника";
	ДокументЗаявкиНаСотрудника.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДокументЗаявкиНаСотрудника.GroupName = "";
	ДокументЗаявкиНаСотрудника.Guid = NsgService.StringToGuid("162793ea-70bb-40aa-89aa-340bcfac76d2");
	
				if (!ObjectList.Contains("ДокументЗаявкиНаСотрудника"))
                    ObjectList.Add(ДокументЗаявкиНаСотрудника);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника ДокументЗаявкиНаСотрудника
			
			#region создание УчетСпецодеждыИСИЗ.КомплектыСпецодежды Комплект
			{  
                NsgDataTypedReference Комплект = null;
				if (ObjectList.Contains("Комплект"))
                    Комплект = ObjectList["Комплект"] as NsgDataTypedReference;
                else
                    Комплект = new NsgDataTypedReference();
	//NsgDataTypedReference
	Комплект.IsLoadedFromDll = true;
	Комплект.ReferentGroup = "УчетСпецодеждыИСИЗ";
	Комплект.ReferentName = "КомплектыСпецодежды";
	Комплект.SaveInDatabase = true;
	Комплект.OwnerName = "";
	Комплект.AllowEmptyOwner = false;
	Комплект.StringFormat = "";
	Комплект.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Комплект.IncludeInPredefined = false;
	Комплект.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Комплект.Required = false;
	Комплект.EmptyValue = "";
	Комплект.NullAllow = false;
	Комплект.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Комплект.FieldName = "Komplekt";
	Комплект.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Комплект.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Комплект.CharactericticWeight = 1;
	Комплект.InformMetaDataOnValueChanged = false;
	Комплект.Visible = true;
	Комплект.Name = "Комплект";
	Комплект.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Комплект.Description = "Комплект";
	Комплект.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Комплект.GroupName = "";
	Комплект.Guid = NsgService.StringToGuid("a431b9a0-0f16-432a-a288-82d45c7364e4");
	
				if (!ObjectList.Contains("Комплект"))
                    ObjectList.Add(Комплект);
			}
			#endregion //создание УчетСпецодеждыИСИЗ.КомплектыСпецодежды Комплект
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterMovementTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("e8456305-38ae-4a39-84ef-6f7687bddaac");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetSpecodezhdyISI5";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет спецодежды ИСИЗРегистр резерва зн СДвижения";
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
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
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
            /// Номенклатура
            /// </summary>
            public static String Номенклатура
            {
                get
                {
                    return "Номенклатура";
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
            /// Поставщик
            /// </summary>
            public static String Поставщик
            {
                get
                {
                    return "Поставщик";
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
            /// Документ заявки на сотрудника
            /// </summary>
            public static String ДокументЗаявкиНаСотрудника
            {
                get
                {
                    return "ДокументЗаявкиНаСотрудника";
                }
            }
            
            /// <summary>
            /// Комплект
            /// </summary>
            public static String Комплект
            {
                get
                {
                    return "Комплект";
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
                    descriptor.Name = "УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения";
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
            return "_SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения";
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Учет.ПриходнаяНакладная,УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды,УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника")]
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
        /// Номенклатура
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Номенклатура Номенклатура
        {
            get
            {
				 NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                 return (Учет.Номенклатура)__Номенклатура.Referent;
            }
            set
            {
                NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                __Номенклатура.Referent = value;
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
        /// Поставщик
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Мониторинг.Контрагенты Поставщик
        {
            get
            {
				 NsgDataTypedReference __Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                 return (Мониторинг.Контрагенты)__Поставщик.Referent;
            }
            set
            {
                NsgDataTypedReference __Поставщик = ObjectList["Поставщик"] as NsgDataTypedReference;
                __Поставщик.Referent = value;
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
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Количество
        {
            get
            {
				 NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                 return (System.Decimal)__Количество.Value;
            }
            set
            {
                NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                __Количество.Value = value;
            }
        }
        
        /// <summary>
        /// Документ заявки на сотрудника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDocument")]
        
        public УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника ДокументЗаявкиНаСотрудника
        {
            get
            {
				 NsgDataTypedReference __ДокументЗаявкиНаСотрудника = ObjectList["ДокументЗаявкиНаСотрудника"] as NsgDataTypedReference;
                 return (УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника)__ДокументЗаявкиНаСотрудника.Referent;
            }
            set
            {
                NsgDataTypedReference __ДокументЗаявкиНаСотрудника = ObjectList["ДокументЗаявкиНаСотрудника"] as NsgDataTypedReference;
                __ДокументЗаявкиНаСотрудника.Referent = value;
            }
        }
        
        /// <summary>
        /// Комплект
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public УчетСпецодеждыИСИЗ.КомплектыСпецодежды Комплект
        {
            get
            {
				 NsgDataTypedReference __Комплект = ObjectList["Комплект"] as NsgDataTypedReference;
                 return (УчетСпецодеждыИСИЗ.КомплектыСпецодежды)__Комплект.Referent;
            }
            set
            {
                NsgDataTypedReference __Комплект = ObjectList["Комплект"] as NsgDataTypedReference;
                __Комплект.Referent = value;
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
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка NewRow()
        {
            return newRow(null) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка(this);
            return base.newRow(row) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка NewRow(УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка inRow)
        {
            УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка row = inRow.Clone as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
            return base.newRow(row) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка GetEtalonRow()
        {
            УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка row = new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] res = new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка[] AllRows
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
        public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] convertArray(NsgMultipleObject[] array)
        {
            УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] res = new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[array.Length];
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
        public new virtual УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] FindAll(NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения(this as NsgObject);
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
                base.NSGType = typeof(УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения Value
            {
                get
                {
                    return (УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения)base.Value;
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
