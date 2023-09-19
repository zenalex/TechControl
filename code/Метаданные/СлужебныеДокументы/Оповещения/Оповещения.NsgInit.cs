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

namespace TechControl.Метаданные.СлужебныеДокументы
{
    
    [NsgTypeName("NsgDataDocument", Guid = "afe65d00-d392-48f1-a6a5-a40f40dc0e7a")]
    public partial class Оповещения : NsgSoft.DataObjects.NsgDataDocument
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
        protected Оповещения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Оповещения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Оповещения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("afe65d00-d392-48f1-a6a5-a40f40dc0e7a"));
            if (obj == null)
                obj = new Оповещения();
            return obj as Оповещения;
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
	Идентификатор.Guid = NsgService.StringToGuid("6cd26311-201b-4e84-832d-73949270d4f5");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("31b4996a-c4ae-455a-813f-7d12e0c39fdd");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("de1981ab-d09b-46c4-b062-1b38faeceea2");
	
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
	НомерКода.Guid = NsgService.StringToGuid("7271c0d7-abb0-47b1-87e6-d0159c8998fe");
	
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
	НомерДокумента.Guid = NsgService.StringToGuid("109e785e-6257-4892-9eff-4029ded75ec1");
	
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
	ДатаДокумента.Guid = NsgService.StringToGuid("08e488f3-b10e-46a1-bf5e-7715b8297ec2");
	
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
	Индекс.Guid = NsgService.StringToGuid("c4b4706e-3d02-4394-8721-73fabbc62c5e");
	
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
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	ДокументОснование.FilterForConfigurator = "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника,УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам";
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
	ДокументОснование.Guid = NsgService.StringToGuid("fb12a885-9d22-4a98-b0a3-814be0c081df");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
			#region создание System.String Комментарий
			{  
                NsgDataString Комментарий = null;
				if (ObjectList.Contains("Комментарий"))
                    Комментарий = ObjectList["Комментарий"] as NsgDataString;
                else
                    Комментарий = new NsgDataString();
	//NsgDataString
	Комментарий.IsLoadedFromDll = true;
	Комментарий.Length = 0;
	Комментарий.StringFormat = "";
	Комментарий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Комментарий.IncludeInPredefined = false;
	Комментарий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Комментарий.Required = false;
	Комментарий.EmptyValue = "";
	Комментарий.NullAllow = false;
	Комментарий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Комментарий.FieldName = "Kommentariij";
	Комментарий.SaveInDatabase = true;
	Комментарий.InformMetaDataOnValueChanged = false;
	Комментарий.Visible = true;
	Комментарий.Name = "Комментарий";
	Комментарий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Комментарий.Description = "Комментарий";
	Комментарий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Комментарий.GroupName = "";
	Комментарий.Guid = NsgService.StringToGuid("cd61fb26-6587-4a5b-b92e-bace5e7e4b3d");
	
				if (!ObjectList.Contains("Комментарий"))
                    ObjectList.Add(Комментарий);
			}
			#endregion //создание System.String Комментарий
			
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("62877ba4-3423-452e-abd6-ac12aacb5211");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание System.DateTime ДатаПоследнегоОповещения
			{  
                NsgDataDateTime ДатаПоследнегоОповещения = null;
				if (ObjectList.Contains("ДатаПоследнегоОповещения"))
                    ДатаПоследнегоОповещения = ObjectList["ДатаПоследнегоОповещения"] as NsgDataDateTime;
                else
                    ДатаПоследнегоОповещения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПоследнегоОповещения.IsLoadedFromDll = true;
	ДатаПоследнегоОповещения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПоследнегоОповещения.StringFormat = "";
	ДатаПоследнегоОповещения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаПоследнегоОповещения.IncludeInPredefined = false;
	ДатаПоследнегоОповещения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПоследнегоОповещения.Required = false;
	ДатаПоследнегоОповещения.EmptyValue = "";
	ДатаПоследнегоОповещения.NullAllow = false;
	ДатаПоследнегоОповещения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПоследнегоОповещения.FieldName = "DataPoslednegoOpo";
	ДатаПоследнегоОповещения.SaveInDatabase = true;
	ДатаПоследнегоОповещения.InformMetaDataOnValueChanged = false;
	ДатаПоследнегоОповещения.Visible = true;
	ДатаПоследнегоОповещения.Name = "ДатаПоследнегоОповещения";
	ДатаПоследнегоОповещения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПоследнегоОповещения.Description = "Дата последнего оповещения";
	ДатаПоследнегоОповещения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПоследнегоОповещения.GroupName = "";
	ДатаПоследнегоОповещения.Guid = NsgService.StringToGuid("b02eaf81-8b6c-453a-b81e-2b65223169c2");
	
				if (!ObjectList.Contains("ДатаПоследнегоОповещения"))
                    ObjectList.Add(ДатаПоследнегоОповещения);
			}
			#endregion //создание System.DateTime ДатаПоследнегоОповещения
			
			#region создание System.Int64 СчетчикОтправки
			{  
                NsgDataInteger СчетчикОтправки = null;
				if (ObjectList.Contains("СчетчикОтправки"))
                    СчетчикОтправки = ObjectList["СчетчикОтправки"] as NsgDataInteger;
                else
                    СчетчикОтправки = new NsgDataInteger();
	//NsgDataInteger
	СчетчикОтправки.IsLoadedFromDll = true;
	СчетчикОтправки.DefaultValue = 0M;
	СчетчикОтправки.MinValue = 0M;
	СчетчикОтправки.MaxValue = 0M;
	СчетчикОтправки.UseCalculator = true;
	СчетчикОтправки.StringFormat = "";
	СчетчикОтправки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СчетчикОтправки.IncludeInPredefined = false;
	СчетчикОтправки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СчетчикОтправки.Required = false;
	СчетчикОтправки.EmptyValue = "";
	СчетчикОтправки.NullAllow = false;
	СчетчикОтправки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СчетчикОтправки.FieldName = "SchetchikOtpravki";
	СчетчикОтправки.SaveInDatabase = true;
	СчетчикОтправки.InformMetaDataOnValueChanged = false;
	СчетчикОтправки.Visible = true;
	СчетчикОтправки.Name = "СчетчикОтправки";
	СчетчикОтправки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СчетчикОтправки.Description = "Счетчик отправки";
	СчетчикОтправки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СчетчикОтправки.GroupName = "";
	СчетчикОтправки.Guid = NsgService.StringToGuid("2ee48a7b-9521-4392-baa7-ca99d2bf71d9");
	
				if (!ObjectList.Contains("СчетчикОтправки"))
                    ObjectList.Add(СчетчикОтправки);
			}
			#endregion //создание System.Int64 СчетчикОтправки
			
			#region создание System.DateTime ДатаПервогоОповещения
			{  
                NsgDataDateTime ДатаПервогоОповещения = null;
				if (ObjectList.Contains("ДатаПервогоОповещения"))
                    ДатаПервогоОповещения = ObjectList["ДатаПервогоОповещения"] as NsgDataDateTime;
                else
                    ДатаПервогоОповещения = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаПервогоОповещения.IsLoadedFromDll = true;
	ДатаПервогоОповещения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаПервогоОповещения.StringFormat = "";
	ДатаПервогоОповещения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаПервогоОповещения.IncludeInPredefined = false;
	ДатаПервогоОповещения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаПервогоОповещения.Required = false;
	ДатаПервогоОповещения.EmptyValue = "";
	ДатаПервогоОповещения.NullAllow = false;
	ДатаПервогоОповещения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаПервогоОповещения.FieldName = "DataPervogoOpoves";
	ДатаПервогоОповещения.SaveInDatabase = true;
	ДатаПервогоОповещения.InformMetaDataOnValueChanged = false;
	ДатаПервогоОповещения.Visible = true;
	ДатаПервогоОповещения.Name = "ДатаПервогоОповещения";
	ДатаПервогоОповещения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаПервогоОповещения.Description = "Дата первого оповещения";
	ДатаПервогоОповещения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаПервогоОповещения.GroupName = "";
	ДатаПервогоОповещения.Guid = NsgService.StringToGuid("c27dd38f-735b-477c-bbc9-21ad438319b8");
	
				if (!ObjectList.Contains("ДатаПервогоОповещения"))
                    ObjectList.Add(ДатаПервогоОповещения);
			}
			#endregion //создание System.DateTime ДатаПервогоОповещения
			
			#region создание Перечисления.СтатусыОповещений Статус
			{  
                NsgDataEnumReference Статус = null;
				if (ObjectList.Contains("Статус"))
                    Статус = ObjectList["Статус"] as NsgDataEnumReference;
                else
                    Статус = new NsgDataEnumReference();
	//NsgDataEnumReference
	Статус.IsLoadedFromDll = true;
	Статус.ReferentGroup = "Перечисления";
	Статус.ReferentName = "СтатусыОповещений";
	Статус.SaveInDatabase = true;
	Статус.OwnerName = "";
	Статус.AllowEmptyOwner = false;
	Статус.StringFormat = "";
	Статус.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Статус.IncludeInPredefined = false;
	Статус.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Статус.Required = false;
	Статус.EmptyValue = "";
	Статус.NullAllow = false;
	Статус.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Статус.FieldName = "Status";
	Статус.InformMetaDataOnValueChanged = false;
	Статус.Visible = true;
	Статус.Name = "Статус";
	Статус.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Статус.Description = "Статус";
	Статус.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Статус.GroupName = "";
	Статус.Guid = NsgService.StringToGuid("8b2ed3bd-f7d5-49d9-8068-2c834ed55a37");
	
				if (!ObjectList.Contains("Статус"))
                    ObjectList.Add(Статус);
			}
			#endregion //создание Перечисления.СтатусыОповещений Статус
			
			#region создание System.String Сообщение
			{  
                NsgDataString Сообщение = null;
				if (ObjectList.Contains("Сообщение"))
                    Сообщение = ObjectList["Сообщение"] as NsgDataString;
                else
                    Сообщение = new NsgDataString();
	//NsgDataString
	Сообщение.IsLoadedFromDll = true;
	Сообщение.Length = 50;
	Сообщение.StringFormat = "";
	Сообщение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сообщение.IncludeInPredefined = false;
	Сообщение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сообщение.Required = false;
	Сообщение.EmptyValue = "";
	Сообщение.NullAllow = false;
	Сообщение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сообщение.FieldName = "Soobschenie";
	Сообщение.SaveInDatabase = true;
	Сообщение.InformMetaDataOnValueChanged = false;
	Сообщение.Visible = true;
	Сообщение.Name = "Сообщение";
	Сообщение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сообщение.Description = "Сообщение";
	Сообщение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сообщение.GroupName = "";
	Сообщение.Guid = NsgService.StringToGuid("02adfe06-8a89-4164-9af3-730dd57e0294");
	
				if (!ObjectList.Contains("Сообщение"))
                    ObjectList.Add(Сообщение);
			}
			#endregion //создание System.String Сообщение
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ПолучательОповещения
			{  
                NsgDataUntypedReference ПолучательОповещения = null;
				if (ObjectList.Contains("ПолучательОповещения"))
                    ПолучательОповещения = ObjectList["ПолучательОповещения"] as NsgDataUntypedReference;
                else
                    ПолучательОповещения = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ПолучательОповещения.IsLoadedFromDll = true;
	ПолучательОповещения.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	ПолучательОповещения.FilterForConfigurator = "Мониторинг.Сотрудники";
	ПолучательОповещения.ReferentName = "";
	ПолучательОповещения.ReferentGroup = "";
	ПолучательОповещения.TypeSelectorName = "";
	ПолучательОповещения.SaveInDatabase = true;
	ПолучательОповещения.OwnerName = "";
	ПолучательОповещения.AllowEmptyOwner = false;
	ПолучательОповещения.StringFormat = "";
	ПолучательОповещения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПолучательОповещения.IncludeInPredefined = false;
	ПолучательОповещения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПолучательОповещения.Required = false;
	ПолучательОповещения.EmptyValue = "";
	ПолучательОповещения.NullAllow = false;
	ПолучательОповещения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПолучательОповещения.FieldName = "PoluchatelOpovesc";
	ПолучательОповещения.InformMetaDataOnValueChanged = false;
	ПолучательОповещения.Visible = true;
	ПолучательОповещения.Name = "ПолучательОповещения";
	ПолучательОповещения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПолучательОповещения.Description = "Получатель оповещения";
	ПолучательОповещения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПолучательОповещения.GroupName = "";
	ПолучательОповещения.Guid = NsgService.StringToGuid("fd4e0c94-6eb2-4cfd-81a2-e9ea0c094008");
	
				if (!ObjectList.Contains("ПолучательОповещения"))
                    ObjectList.Add(ПолучательОповещения);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ПолучательОповещения
			

			#region заполнение полей класса
				//NsgDataDocument
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Мониторинг.ФормированиеСмены", "Сервис.СервернаяЗадача", "Мониторинг.ОтработанноеВремяТехники", "Мониторинг.ЗакрытиеСмены", "Мониторинг.Заправка", "Мониторинг.ПоставкаТоплива", "Мониторинг.ФормированиеСменыДень", "СлужебныеСправочники.ПриглашениеПользователя", "Учет.Перемещение", "Мониторинг.РегистрацияХодок", "Мониторинг.Ходки", "СлужебныеСправочники.Уведомления", "Мониторинг.ПроверкаЗаправки", "Грузы.ВывозГруза", "Грузы.ПривозГруза", "УчетИнструмента.ПеремещениеИнструмента", "УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам", "УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника"});
	SearchFieldName = "_Code";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Мониторинг.РегистрМониторингТехники", "Мониторинг.ФиксацияИстории", "Сервис.ПраваПользователей", "Мониторинг.МониторирнгТехники", "Мониторинг.РегистрОтработанногоВремени", "Мониторинг.РегистрСмен", "Мониторинг.РегистрЗаправок", "Мониторинг.РегистрПоставокТоплива", "Мониторинг.ФиксацияИсторииСотрудников", "Учет.ОстаткиНоменклатуры", "УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды", "УчетИнструмента.РегистрУчетИнструмента", "Учет.РегистрЦен", "УчетСпецодеждыИСИЗ.РегистрРезерваЗнС", "УчетСпецодеждыИСИЗ.РегистрРезерваЗП"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.None});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Оповещения";
	Visible = true;
	Guid = NsgService.StringToGuid("afe65d00-d392-48f1-a6a5-a40f40dc0e7a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление} №{НомерДокумента} от {ДатаДокумента:d}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_doc_Opoveschenija";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документ";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "СлужебныеДокументы";
	
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
            /// Комментарий
            /// </summary>
            public static String Комментарий
            {
                get
                {
                    return "Комментарий";
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
            
            /// <summary>
            /// Дата последнего оповещения
            /// </summary>
            public static String ДатаПоследнегоОповещения
            {
                get
                {
                    return "ДатаПоследнегоОповещения";
                }
            }
            
            /// <summary>
            /// Счетчик отправки
            /// </summary>
            public static String СчетчикОтправки
            {
                get
                {
                    return "СчетчикОтправки";
                }
            }
            
            /// <summary>
            /// Дата первого оповещения
            /// </summary>
            public static String ДатаПервогоОповещения
            {
                get
                {
                    return "ДатаПервогоОповещения";
                }
            }
            
            /// <summary>
            /// Статус
            /// </summary>
            public static String Статус
            {
                get
                {
                    return "Статус";
                }
            }
            
            /// <summary>
            /// Сообщение
            /// </summary>
            public static String Сообщение
            {
                get
                {
                    return "Сообщение";
                }
            }
            
            /// <summary>
            /// Получатель оповещения
            /// </summary>
            public static String ПолучательОповещения
            {
                get
                {
                    return "ПолучательОповещения";
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
                    descriptor.Name = "Оповещения";
                    descriptor.GroupName = "СлужебныеДокументы";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "СлужебныеДокументы.Оповещения";
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
        [NsgReferentsFilterAttribute("УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника,УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам")]
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
        /// Комментарий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Комментарий
        {
            get
            {
				 NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                 return (System.String)__Комментарий.Value;
            }
            set
            {
                NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                __Комментарий.Value = value;
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
        
        /// <summary>
        /// Дата последнего оповещения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПоследнегоОповещения
        {
            get
            {
				 NsgDataDateTime __ДатаПоследнегоОповещения = ObjectList["ДатаПоследнегоОповещения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПоследнегоОповещения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПоследнегоОповещения = ObjectList["ДатаПоследнегоОповещения"] as NsgDataDateTime;
                __ДатаПоследнегоОповещения.Value = value;
            }
        }
        
        /// <summary>
        /// Счетчик отправки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 СчетчикОтправки
        {
            get
            {
				 NsgDataInteger __СчетчикОтправки = ObjectList["СчетчикОтправки"] as NsgDataInteger;
                 return (System.Int64)__СчетчикОтправки.Value;
            }
            set
            {
                NsgDataInteger __СчетчикОтправки = ObjectList["СчетчикОтправки"] as NsgDataInteger;
                __СчетчикОтправки.Value = value;
            }
        }
        
        /// <summary>
        /// Дата первого оповещения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаПервогоОповещения
        {
            get
            {
				 NsgDataDateTime __ДатаПервогоОповещения = ObjectList["ДатаПервогоОповещения"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаПервогоОповещения.Value;
            }
            set
            {
                NsgDataDateTime __ДатаПервогоОповещения = ObjectList["ДатаПервогоОповещения"] as NsgDataDateTime;
                __ДатаПервогоОповещения.Value = value;
            }
        }
        
        /// <summary>
        /// Статус
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Перечисления.СтатусыОповещений Статус
        {
            get
            {
				 NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                 return (Перечисления.СтатусыОповещений)__Статус.Referent;
            }
            set
            {
                NsgDataEnumReference __Статус = ObjectList["Статус"] as NsgDataEnumReference;
                __Статус.Referent = value;
            }
        }
        
        /// <summary>
        /// Сообщение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Сообщение
        {
            get
            {
				 NsgDataString __Сообщение = ObjectList["Сообщение"] as NsgDataString;
                 return (System.String)__Сообщение.Value;
            }
            set
            {
                NsgDataString __Сообщение = ObjectList["Сообщение"] as NsgDataString;
                __Сообщение.Value = value;
            }
        }
        
        /// <summary>
        /// Получатель оповещения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Мониторинг.Сотрудники")]
        public NsgSoft.DataObjects.NsgReferencedObject ПолучательОповещения
        {
            get
            {
				 NsgDataUntypedReference __ПолучательОповещения = ObjectList["ПолучательОповещения"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ПолучательОповещения.Referent;
            }
            set
            {
                NsgDataUntypedReference __ПолучательОповещения = ObjectList["ПолучательОповещения"] as NsgDataUntypedReference;
                __ПолучательОповещения.Referent = value;
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
        private Оповещения[] convertArray(NsgMultipleObject[] array)
        {
            Оповещения[] res = new Оповещения[array.Length];
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
        public new virtual Оповещения[] FindAll(NsgCompare compare)
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
        public new virtual Оповещения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Оповещения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Оповещения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Оповещения(this as NsgObject);
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
                base.NSGType = typeof(Оповещения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Оповещения Value
            {
                get
                {
                    return (Оповещения)base.Value;
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
