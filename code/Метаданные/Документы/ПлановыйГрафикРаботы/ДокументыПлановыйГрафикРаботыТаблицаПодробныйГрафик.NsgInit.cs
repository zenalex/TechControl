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
    
    [NsgTypeName("NsgDataTable", Guid = "fadceb33-62e1-4645-ae76-a636f791cd35")]
    public partial class ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик : NsgSoft.DataObjects.NsgDataTable
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
        protected ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("fadceb33-62e1-4645-ae76-a636f791cd35"));
            if (obj == null)
                obj = new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик();
            return obj as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик;
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
	Идентификатор.Guid = NsgService.StringToGuid("d2b11bcc-b7a4-4c76-8693-e25014442d69");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("82746d6b-18ee-45be-a260-fc9e0f5689ab");
	
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
	Владелец.FilterForConfigurator = "Документы.ПлановыйГрафикРаботы";
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
	Владелец.Guid = NsgService.StringToGuid("d13d93c0-29ce-4a3b-bd5f-bc6213da6ea3");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("625abf5a-02b3-4dbd-a4ee-cd2af0f8defc");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.Int64 ДеньМесяца
			{  
                NsgDataInteger ДеньМесяца = null;
				if (ObjectList.Contains("ДеньМесяца"))
                    ДеньМесяца = ObjectList["ДеньМесяца"] as NsgDataInteger;
                else
                    ДеньМесяца = new NsgDataInteger();
	//NsgDataInteger
	ДеньМесяца.IsLoadedFromDll = true;
	ДеньМесяца.DefaultValue = 0M;
	ДеньМесяца.MinValue = 0M;
	ДеньМесяца.MaxValue = 0M;
	ДеньМесяца.UseCalculator = true;
	ДеньМесяца.StringFormat = "";
	ДеньМесяца.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДеньМесяца.IncludeInPredefined = false;
	ДеньМесяца.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДеньМесяца.Required = false;
	ДеньМесяца.EmptyValue = "";
	ДеньМесяца.NullAllow = false;
	ДеньМесяца.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДеньМесяца.FieldName = "DenMesjaca";
	ДеньМесяца.SaveInDatabase = true;
	ДеньМесяца.InformMetaDataOnValueChanged = false;
	ДеньМесяца.Visible = true;
	ДеньМесяца.Name = "ДеньМесяца";
	ДеньМесяца.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДеньМесяца.Description = "День месяца";
	ДеньМесяца.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДеньМесяца.GroupName = "";
	ДеньМесяца.Guid = NsgService.StringToGuid("75ce31b2-eb0c-4f8d-ae70-160e3c96ba0a");
	
				if (!ObjectList.Contains("ДеньМесяца"))
                    ObjectList.Add(ДеньМесяца);
			}
			#endregion //создание System.Int64 ДеньМесяца
			
			#region создание System.Boolean РабочийДень
			{  
                NsgDataBoolean РабочийДень = null;
				if (ObjectList.Contains("РабочийДень"))
                    РабочийДень = ObjectList["РабочийДень"] as NsgDataBoolean;
                else
                    РабочийДень = new NsgDataBoolean();
	//NsgDataBoolean
	РабочийДень.IsLoadedFromDll = true;
	РабочийДень.DefaultValue = false;
	РабочийДень.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РабочийДень.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РабочийДень.StringFormat = "";
	РабочийДень.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	РабочийДень.IncludeInPredefined = false;
	РабочийДень.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РабочийДень.Required = false;
	РабочийДень.EmptyValue = "";
	РабочийДень.NullAllow = false;
	РабочийДень.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РабочийДень.FieldName = "RabochiijDen";
	РабочийДень.SaveInDatabase = true;
	РабочийДень.InformMetaDataOnValueChanged = false;
	РабочийДень.Visible = true;
	РабочийДень.Name = "РабочийДень";
	РабочийДень.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	РабочийДень.Description = "Рабочий день";
	РабочийДень.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	РабочийДень.GroupName = "";
	РабочийДень.Guid = NsgService.StringToGuid("b7ad9260-3b85-4581-a35e-e93633804d08");
	
				if (!ObjectList.Contains("РабочийДень"))
                    ObjectList.Add(РабочийДень);
			}
			#endregion //создание System.Boolean РабочийДень
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Документы.ПлановыйГрафикРаботы";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик";
	Visible = true;
	Guid = NsgService.StringToGuid("fadceb33-62e1-4645-ae76-a636f791cd35");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_DokumentyPlanovyijG";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Документы плановый график работы таблица подробный график";
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
            /// День месяца
            /// </summary>
            public static String ДеньМесяца
            {
                get
                {
                    return "ДеньМесяца";
                }
            }
            
            /// <summary>
            /// Рабочий день
            /// </summary>
            public static String РабочийДень
            {
                get
                {
                    return "РабочийДень";
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
                    descriptor.Name = "ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик";
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
            return "_SystemTables.ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик";
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
        [NsgReferentsFilterAttribute("Документы.ПлановыйГрафикРаботы")]
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
        /// День месяца
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ДеньМесяца
        {
            get
            {
				 NsgDataInteger __ДеньМесяца = ObjectList["ДеньМесяца"] as NsgDataInteger;
                 return (System.Int64)__ДеньМесяца.Value;
            }
            set
            {
                NsgDataInteger __ДеньМесяца = ObjectList["ДеньМесяца"] as NsgDataInteger;
                __ДеньМесяца.Value = value;
            }
        }
        
        /// <summary>
        /// Рабочий день
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean РабочийДень
        {
            get
            {
				 NsgDataBoolean __РабочийДень = ObjectList["РабочийДень"] as NsgDataBoolean;
                 return (System.Boolean)__РабочийДень.Value;
            }
            set
            {
                NsgDataBoolean __РабочийДень = ObjectList["РабочийДень"] as NsgDataBoolean;
                __РабочийДень.Value = value;
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
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка NewRow()
        {
            return newRow(null) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка(this);
            return base.newRow(row) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка NewRow(ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка inRow)
        {
            ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка row = inRow.Clone as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
            return base.newRow(row) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка GetEtalonRow()
        {
            ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка row = new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] res = new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка[] AllRows
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
        public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] convertArray(NsgMultipleObject[] array)
        {
            ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] res = new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[array.Length];
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
        public new virtual ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] FindAll(NsgCompare compare)
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
        public new virtual ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик(this as NsgObject);
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
                base.NSGType = typeof(ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик Value
            {
                get
                {
                    return (ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик)base.Value;
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
