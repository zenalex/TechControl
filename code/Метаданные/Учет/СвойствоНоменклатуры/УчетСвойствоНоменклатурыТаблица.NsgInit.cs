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
    
    [NsgTypeName("NsgDataTable", Guid = "49e46312-f496-449c-86f1-7b58caa165f4")]
    public partial class УчетСвойствоНоменклатурыТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетСвойствоНоменклатурыТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСвойствоНоменклатурыТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСвойствоНоменклатурыТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("49e46312-f496-449c-86f1-7b58caa165f4"));
            if (obj == null)
                obj = new УчетСвойствоНоменклатурыТаблица();
            return obj as УчетСвойствоНоменклатурыТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("21759201-79b9-42ec-9ec4-5a20a90b2535");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("cb07f0d0-c9ee-4f43-8730-0a04bd23bb38");
	
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
	Владелец.FilterForConfigurator = "Учет.СвойствоНоменклатуры";
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
	Владелец.Guid = NsgService.StringToGuid("9a7e3f86-1c6b-49ae-b66c-55d1e94169a1");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("ba3a3f03-3fad-45aa-a19c-fa50b1eaff56");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
			{  
                NsgDataTypedReference ВидСвойствНоменклатуры = null;
				if (ObjectList.Contains("ВидСвойствНоменклатуры"))
                    ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                else
                    ВидСвойствНоменклатуры = new NsgDataTypedReference();
	//NsgDataTypedReference
	ВидСвойствНоменклатуры.IsLoadedFromDll = true;
	ВидСвойствНоменклатуры.ReferentGroup = "Учет";
	ВидСвойствНоменклатуры.ReferentName = "ВидСвойствНоменклатуры";
	ВидСвойствНоменклатуры.SaveInDatabase = true;
	ВидСвойствНоменклатуры.OwnerName = "";
	ВидСвойствНоменклатуры.AllowEmptyOwner = false;
	ВидСвойствНоменклатуры.StringFormat = "";
	ВидСвойствНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВидСвойствНоменклатуры.IncludeInPredefined = false;
	ВидСвойствНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидСвойствНоменклатуры.Required = false;
	ВидСвойствНоменклатуры.EmptyValue = "";
	ВидСвойствНоменклатуры.NullAllow = false;
	ВидСвойствНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидСвойствНоменклатуры.FieldName = "VidSvoijstvNomenk";
	ВидСвойствНоменклатуры.InformMetaDataOnValueChanged = false;
	ВидСвойствНоменклатуры.Visible = true;
	ВидСвойствНоменклатуры.Name = "ВидСвойствНоменклатуры";
	ВидСвойствНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидСвойствНоменклатуры.Description = "Вид свойств номенклатуры";
	ВидСвойствНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВидСвойствНоменклатуры.GroupName = "";
	ВидСвойствНоменклатуры.Guid = NsgService.StringToGuid("b2f7a341-cacf-4360-9e8a-b3626604cc06");
	
				if (!ObjectList.Contains("ВидСвойствНоменклатуры"))
                    ObjectList.Add(ВидСвойствНоменклатуры);
			}
			#endregion //создание Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
			
			#region создание Учет.ВариантыЗначений Значение
			{  
                NsgDataTypedReference Значение = null;
				if (ObjectList.Contains("Значение"))
                    Значение = ObjectList["Значение"] as NsgDataTypedReference;
                else
                    Значение = new NsgDataTypedReference();
	//NsgDataTypedReference
	Значение.IsLoadedFromDll = true;
	Значение.ReferentGroup = "Учет";
	Значение.ReferentName = "ВариантыЗначений";
	Значение.SaveInDatabase = true;
	Значение.OwnerName = "";
	Значение.AllowEmptyOwner = false;
	Значение.StringFormat = "";
	Значение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Значение.IncludeInPredefined = false;
	Значение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Значение.Required = false;
	Значение.EmptyValue = "";
	Значение.NullAllow = false;
	Значение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Значение.FieldName = "Znachenie";
	Значение.InformMetaDataOnValueChanged = false;
	Значение.Visible = true;
	Значение.Name = "Значение";
	Значение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Значение.Description = "Значение";
	Значение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Значение.GroupName = "";
	Значение.Guid = NsgService.StringToGuid("bf0ab7cd-de12-4e8d-ac08-033729945161");
	
				if (!ObjectList.Contains("Значение"))
                    ObjectList.Add(Значение);
			}
			#endregion //создание Учет.ВариантыЗначений Значение
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Учет.СвойствоНоменклатуры";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетСвойствоНоменклатурыТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("49e46312-f496-449c-86f1-7b58caa165f4");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetSvoijstvoNomen";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет свойство номенклатуры таблица";
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
            /// Вид свойств номенклатуры
            /// </summary>
            public static String ВидСвойствНоменклатуры
            {
                get
                {
                    return "ВидСвойствНоменклатуры";
                }
            }
            
            /// <summary>
            /// Значение
            /// </summary>
            public static String Значение
            {
                get
                {
                    return "Значение";
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
                    descriptor.Name = "УчетСвойствоНоменклатурыТаблица";
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
            return "_SystemTables.УчетСвойствоНоменклатурыТаблица";
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
        [NsgReferentsFilterAttribute("Учет.СвойствоНоменклатуры")]
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
        /// Вид свойств номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ВидСвойствНоменклатуры ВидСвойствНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.ВидСвойствНоменклатуры)__ВидСвойствНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __ВидСвойствНоменклатуры = ObjectList["ВидСвойствНоменклатуры"] as NsgDataTypedReference;
                __ВидСвойствНоменклатуры.Referent = value;
            }
        }
        
        /// <summary>
        /// Значение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.ВариантыЗначений Значение
        {
            get
            {
				 NsgDataTypedReference __Значение = ObjectList["Значение"] as NsgDataTypedReference;
                 return (Учет.ВариантыЗначений)__Значение.Referent;
            }
            set
            {
                NsgDataTypedReference __Значение = ObjectList["Значение"] as NsgDataTypedReference;
                __Значение.Referent = value;
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
        public new УчетСвойствоНоменклатурыТаблица.Строка NewRow()
        {
            return newRow(null) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетСвойствоНоменклатурыТаблица.Строка(this);
            return base.newRow(row) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетСвойствоНоменклатурыТаблица.Строка NewRow(УчетСвойствоНоменклатурыТаблица.Строка inRow)
        {
            УчетСвойствоНоменклатурыТаблица.Строка row = inRow.Clone as УчетСвойствоНоменклатурыТаблица.Строка;
            return base.newRow(row) as УчетСвойствоНоменклатурыТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетСвойствоНоменклатурыТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетСвойствоНоменклатурыТаблица.Строка GetEtalonRow()
        {
            УчетСвойствоНоменклатурыТаблица.Строка row = new УчетСвойствоНоменклатурыТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетСвойствоНоменклатурыТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетСвойствоНоменклатурыТаблица.Строка[] res = new УчетСвойствоНоменклатурыТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСвойствоНоменклатурыТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетСвойствоНоменклатурыТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетСвойствоНоменклатурыТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетСвойствоНоменклатурыТаблица.Строка[] AllRows
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
        public new УчетСвойствоНоменклатурыТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетСвойствоНоменклатурыТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетСвойствоНоменклатурыТаблица[] convertArray(NsgMultipleObject[] array)
        {
            УчетСвойствоНоменклатурыТаблица[] res = new УчетСвойствоНоменклатурыТаблица[array.Length];
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
        public new virtual УчетСвойствоНоменклатурыТаблица[] FindAll(NsgCompare compare)
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
        public new virtual УчетСвойствоНоменклатурыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСвойствоНоменклатурыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСвойствоНоменклатурыТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСвойствоНоменклатурыТаблица(this as NsgObject);
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
                base.NSGType = typeof(УчетСвойствоНоменклатурыТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСвойствоНоменклатурыТаблица Value
            {
                get
                {
                    return (УчетСвойствоНоменклатурыТаблица)base.Value;
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
