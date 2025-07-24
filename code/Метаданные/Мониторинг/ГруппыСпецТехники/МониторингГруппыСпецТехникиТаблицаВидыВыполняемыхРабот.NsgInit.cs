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
    
    [NsgTypeName("NsgDataTable", Guid = "3b253a20-4a1c-498a-8010-f2ed4b66a5ec")]
    public partial class МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот : NsgSoft.DataObjects.NsgDataTable
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
        protected МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3b253a20-4a1c-498a-8010-f2ed4b66a5ec"));
            if (obj == null)
                obj = new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот();
            return obj as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот;
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
	Идентификатор.Guid = NsgService.StringToGuid("f9742249-82e2-4665-a93a-4be2deff1fe5");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("55e3c056-23a0-46d6-a277-ccaefc358bc7");
	
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
	Владелец.FilterForConfigurator = "Мониторинг.ГруппыСпецТехники";
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
	Владелец.Guid = NsgService.StringToGuid("1a56dcf5-ed39-432e-b2fa-d7bd44dc2cf8");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("5a145554-3bac-470c-adba-b55233bfe7f1");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
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
	ВидРаботы.Guid = NsgService.StringToGuid("8325ab44-3699-4c26-87a5-69444ea8eace");
	
				if (!ObjectList.Contains("ВидРаботы"))
                    ObjectList.Add(ВидРаботы);
			}
			#endregion //создание Справочники.ВидыРабот ВидРаботы
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Мониторинг.ГруппыСпецТехники";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот";
	Visible = true;
	Guid = NsgService.StringToGuid("3b253a20-4a1c-498a-8010-f2ed4b66a5ec");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_MonitoringGruppySpe";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Мониторинг группы спец техники таблица виды выполняемых работ";
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
            /// Вид работы
            /// </summary>
            public static String ВидРаботы
            {
                get
                {
                    return "ВидРаботы";
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
                    descriptor.Name = "МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот";
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
            return "_SystemTables.МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот";
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
        [NsgReferentsFilterAttribute("Мониторинг.ГруппыСпецТехники")]
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка NewRow()
        {
            return newRow(null) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка(this);
            return base.newRow(row) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка NewRow(МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка inRow)
        {
            МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка row = inRow.Clone as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
            return base.newRow(row) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка GetEtalonRow()
        {
            МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка row = new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] res = new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка[] AllRows
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
        public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] convertArray(NsgMultipleObject[] array)
        {
            МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] res = new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[array.Length];
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
        public new virtual МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] FindAll(NsgCompare compare)
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
        public new virtual МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот(this as NsgObject);
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
                base.NSGType = typeof(МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот Value
            {
                get
                {
                    return (МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот)base.Value;
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
