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
    
    [NsgTypeName("NsgDataTable", Guid = "18e58fad-d057-40e2-adb9-bdbb40eaaa67")]
    public partial class ДокументыЗаявкиНаРаботыТаблицаВидыРабот : NsgSoft.DataObjects.NsgDataTable
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
        protected ДокументыЗаявкиНаРаботыТаблицаВидыРабот()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ДокументыЗаявкиНаРаботыТаблицаВидыРабот(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ДокументыЗаявкиНаРаботыТаблицаВидыРабот Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("18e58fad-d057-40e2-adb9-bdbb40eaaa67"));
            if (obj == null)
                obj = new ДокументыЗаявкиНаРаботыТаблицаВидыРабот();
            return obj as ДокументыЗаявкиНаРаботыТаблицаВидыРабот;
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
	Идентификатор.Guid = NsgService.StringToGuid("c048f8e1-2fe4-4861-9fd4-e0c2bc5d56b5");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("aad51b93-dd3f-4af5-bccc-80ee34d2c9fa");
	
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
	Владелец.FilterForConfigurator = "Документы.ЗаявкиНаРаботы";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
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
	Владелец.Guid = NsgService.StringToGuid("21754bba-6a05-4028-b47a-ad00ed7b2363");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.Int64 НомерСтроки
			{  
                NsgDataInteger НомерСтроки = null;
				if (ObjectList.Contains("НомерСтроки"))
                    НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                else
                    НомерСтроки = new NsgDataInteger();
	//NsgDataInteger
	НомерСтроки.IsLoadedFromDll = true;
	НомерСтроки.DefaultValue = 0M;
	НомерСтроки.MinValue = 0M;
	НомерСтроки.MaxValue = 0M;
	НомерСтроки.UseCalculator = true;
	НомерСтроки.StringFormat = "";
	НомерСтроки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерСтроки.IncludeInPredefined = false;
	НомерСтроки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСтроки.Required = false;
	НомерСтроки.EmptyValue = "";
	НомерСтроки.NullAllow = false;
	НомерСтроки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСтроки.FieldName = "_RowNumber";
	НомерСтроки.SaveInDatabase = true;
	НомерСтроки.InformMetaDataOnValueChanged = false;
	НомерСтроки.Visible = true;
	НомерСтроки.Name = "НомерСтроки";
	НомерСтроки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСтроки.Description = "Номер строки";
	НомерСтроки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	НомерСтроки.GroupName = "";
	НомерСтроки.Guid = NsgService.StringToGuid("484c27c5-d35a-40d9-8a5c-7a0567de86dc");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.DateTime ДатаОкончания
			{  
                NsgDataDateTime ДатаОкончания = null;
				if (ObjectList.Contains("ДатаОкончания"))
                    ДатаОкончания = ObjectList["ДатаОкончания"] as NsgDataDateTime;
                else
                    ДатаОкончания = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончания.IsLoadedFromDll = true;
	ДатаОкончания.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОкончания.StringFormat = "";
	ДатаОкончания.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончания.IncludeInPredefined = false;
	ДатаОкончания.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончания.Required = false;
	ДатаОкончания.EmptyValue = "";
	ДатаОкончания.NullAllow = false;
	ДатаОкончания.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончания.FieldName = "DataOkonchanija";
	ДатаОкончания.SaveInDatabase = true;
	ДатаОкончания.InformMetaDataOnValueChanged = false;
	ДатаОкончания.Visible = true;
	ДатаОкончания.Name = "ДатаОкончания";
	ДатаОкончания.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончания.Description = "Дата окончания";
	ДатаОкончания.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОкончания.GroupName = "";
	ДатаОкончания.Guid = NsgService.StringToGuid("18a7400f-8927-472e-9ab2-f440d048c0a2");
	
				if (!ObjectList.Contains("ДатаОкончания"))
                    ObjectList.Add(ДатаОкончания);
			}
			#endregion //создание System.DateTime ДатаОкончания
			
			#region создание Справочники.ВидыРабот ВидРаботы
			{  
                NsgDataTypedReference ВидРаботы = null;
				if (ObjectList.Contains("ВидРаботы"))
                    ВидРаботы = ObjectList["ВидРаботы"] as NsgDataTypedReference;
                else
                    ВидРаботы = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидРаботы.IsLoadedFromDll = true;
	ВидРаботы.ReferentGroup = "Справочники";
	ВидРаботы.ReferentName = "ВидыРабот";
	ВидРаботы.SaveInDatabase = true;
	ВидРаботы.OwnerName = "";
	ВидРаботы.AllowEmptyOwner = false;
	ВидРаботы.StringFormat = "";
	ВидРаботы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВидРаботы.IncludeInPredefined = false;
	ВидРаботы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидРаботы.Required = false;
	ВидРаботы.EmptyValue = "";
	ВидРаботы.NullAllow = false;
	ВидРаботы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидРаботы.FieldName = "VidRaboty";
	ВидРаботы.InformMetaDataOnValueChanged = false;
	ВидРаботы.Visible = true;
	ВидРаботы.Name = "ВидРаботы";
	ВидРаботы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидРаботы.Description = "Вид работы";
	ВидРаботы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидРаботы.GroupName = "";
	ВидРаботы.Guid = NsgService.StringToGuid("5e3378f0-953f-442f-a0e5-1a72230b3034");
	
				if (!ObjectList.Contains("ВидРаботы"))
                    ObjectList.Add(ВидРаботы);
			}
			#endregion //создание Справочники.ВидыРабот ВидРаботы
			
			#region создание System.DateTime ДатаНачала
			{  
                NsgDataDateTime ДатаНачала = null;
				if (ObjectList.Contains("ДатаНачала"))
                    ДатаНачала = ObjectList["ДатаНачала"] as NsgDataDateTime;
                else
                    ДатаНачала = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаНачала.IsLoadedFromDll = true;
	ДатаНачала.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаНачала.StringFormat = "";
	ДатаНачала.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаНачала.IncludeInPredefined = false;
	ДатаНачала.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаНачала.Required = false;
	ДатаНачала.EmptyValue = "";
	ДатаНачала.NullAllow = false;
	ДатаНачала.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаНачала.FieldName = "DataNachala";
	ДатаНачала.SaveInDatabase = true;
	ДатаНачала.InformMetaDataOnValueChanged = false;
	ДатаНачала.Visible = true;
	ДатаНачала.Name = "ДатаНачала";
	ДатаНачала.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаНачала.Description = "Дата начала";
	ДатаНачала.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаНачала.GroupName = "";
	ДатаНачала.Guid = NsgService.StringToGuid("fe35965f-f871-4db4-b844-2a786e893a4e");
	
				if (!ObjectList.Contains("ДатаНачала"))
                    ObjectList.Add(ДатаНачала);
			}
			#endregion //создание System.DateTime ДатаНачала
			
			#region создание System.String Комментарий
			{  
                NsgDataString Комментарий = null;
				if (ObjectList.Contains("Комментарий"))
                    Комментарий = ObjectList["Комментарий"] as NsgDataString;
                else
                    Комментарий = new NsgDataString();
	//NsgDataString
	Комментарий.IsLoadedFromDll = true;
	Комментарий.Length = 50;
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
	Комментарий.Guid = NsgService.StringToGuid("1710fa93-2414-470a-ba17-bc950a6af6c0");
	
				if (!ObjectList.Contains("Комментарий"))
                    ObjectList.Add(Комментарий);
			}
			#endregion //создание System.String Комментарий
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Документы.ЗаявкиНаРаботы";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДокументыЗаявкиНаРаботыТаблицаВидыРабот";
	Visible = true;
	Guid = NsgService.StringToGuid("18e58fad-d057-40e2-adb9-bdbb40eaaa67");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_DokumentyZajavkiNaR";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документы заявки на работы таблица виды работ";
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
            /// Номер строки
            /// </summary>
            public static String НомерСтроки
            {
                get
                {
                    return "НомерСтроки";
                }
            }
            
            /// <summary>
            /// Дата окончания
            /// </summary>
            public static String ДатаОкончания
            {
                get
                {
                    return "ДатаОкончания";
                }
            }
            
            /// <summary>
            /// Вид работы
            /// </summary>
            public static String ВидРаботы
            {
                get
                {
                    return "ВидРаботы";
                }
            }
            
            /// <summary>
            /// Дата начала
            /// </summary>
            public static String ДатаНачала
            {
                get
                {
                    return "ДатаНачала";
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
                    descriptor.Name = "ДокументыЗаявкиНаРаботыТаблицаВидыРабот";
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
            return "_SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот";
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
        [NsgReferentsFilterAttribute("Документы.ЗаявкиНаРаботы")]
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
        /// Номер строки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСтроки
        {
            get
            {
				 NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                 return (System.Int64)__НомерСтроки.Value;
            }
            set
            {
                NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                __НомерСтроки.Value = value;
            }
        }
        
        /// <summary>
        /// Дата окончания
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончания
        {
            get
            {
				 NsgDataDateTime __ДатаОкончания = ObjectList["ДатаОкончания"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончания.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончания = ObjectList["ДатаОкончания"] as NsgDataDateTime;
                __ДатаОкончания.Value = value;
            }
        }
        
        /// <summary>
        /// Вид работы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Справочники.ВидыРабот ВидРаботы
        {
            get
            {
				 NsgDataTypedReference __ВидРаботы = ObjectList["ВидРаботы"] as NsgDataTypedReference;
                 return (Справочники.ВидыРабот)__ВидРаботы.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидРаботы = ObjectList["ВидРаботы"] as NsgDataTypedReference;
                __ВидРаботы.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата начала
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаНачала
        {
            get
            {
				 NsgDataDateTime __ДатаНачала = ObjectList["ДатаНачала"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаНачала.Value;
            }
            set
            {
                NsgDataDateTime __ДатаНачала = ObjectList["ДатаНачала"] as NsgDataDateTime;
                __ДатаНачала.Value = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка NewRow()
        {
            return newRow(null) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка(this);
            return base.newRow(row) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка NewRow(ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка inRow)
        {
            ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка row = inRow.Clone as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
            return base.newRow(row) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка GetEtalonRow()
        {
            ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка row = new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] res = new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<ДокументыЗаявкиНаРаботыТаблицаВидыРабот> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<ДокументыЗаявкиНаРаботыТаблицаВидыРабот>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка[] AllRows
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
        public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] convertArray(NsgMultipleObject[] array)
        {
            ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] res = new ДокументыЗаявкиНаРаботыТаблицаВидыРабот[array.Length];
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
        public new virtual ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] FindAll(NsgCompare compare)
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
        public new virtual ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ДокументыЗаявкиНаРаботыТаблицаВидыРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ДокументыЗаявкиНаРаботыТаблицаВидыРабот(this as NsgObject);
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
                base.NSGType = typeof(ДокументыЗаявкиНаРаботыТаблицаВидыРабот);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ДокументыЗаявкиНаРаботыТаблицаВидыРабот Value
            {
                get
                {
                    return (ДокументыЗаявкиНаРаботыТаблицаВидыРабот)base.Value;
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
