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
    
    [NsgTypeName("NsgDataTable", Guid = "bc7bc86e-e1fd-4a3c-a05a-f5cc02341cfb")]
    public partial class УчетИнструментаПеремещениеИнструментаТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетИнструментаПеремещениеИнструментаТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетИнструментаПеремещениеИнструментаТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетИнструментаПеремещениеИнструментаТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("bc7bc86e-e1fd-4a3c-a05a-f5cc02341cfb"));
            if (obj == null)
                obj = new УчетИнструментаПеремещениеИнструментаТаблица();
            return obj as УчетИнструментаПеремещениеИнструментаТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("b3d3ae15-d64a-41c3-96b1-da5c6beb0fb8");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("501e4330-d241-408f-80ba-6d0da70b48f3");
	
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
	Владелец.FilterForConfigurator = "УчетИнструмента.ПеремещениеИнструмента";
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
	Владелец.Guid = NsgService.StringToGuid("cbe8cec6-99d0-4d94-8568-84db141ca0dd");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("60e4cadd-a38b-4d9a-9993-98b0287dffed");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Учет.Номенклатура НоменклатураИнструмента
			{  
                NsgDataTypedReference НоменклатураИнструмента = null;
				if (ObjectList.Contains("НоменклатураИнструмента"))
                    НоменклатураИнструмента = ObjectList["НоменклатураИнструмента"] as NsgDataTypedReference;
                else
                    НоменклатураИнструмента = new NsgDataTypedReference();
	//NsgDataTypedReference
	НоменклатураИнструмента.IsLoadedFromDll = true;
	НоменклатураИнструмента.ReferentGroup = "Учет";
	НоменклатураИнструмента.ReferentName = "Номенклатура";
	НоменклатураИнструмента.SaveInDatabase = true;
	НоменклатураИнструмента.OwnerName = "";
	НоменклатураИнструмента.AllowEmptyOwner = false;
	НоменклатураИнструмента.StringFormat = "";
	НоменклатураИнструмента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НоменклатураИнструмента.IncludeInPredefined = false;
	НоменклатураИнструмента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НоменклатураИнструмента.Required = false;
	НоменклатураИнструмента.EmptyValue = "";
	НоменклатураИнструмента.NullAllow = false;
	НоменклатураИнструмента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НоменклатураИнструмента.FieldName = "NomenklaturaInstr";
	НоменклатураИнструмента.InformMetaDataOnValueChanged = false;
	НоменклатураИнструмента.Visible = true;
	НоменклатураИнструмента.Name = "НоменклатураИнструмента";
	НоменклатураИнструмента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НоменклатураИнструмента.Description = "Номенклатура инструмента";
	НоменклатураИнструмента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НоменклатураИнструмента.GroupName = "";
	НоменклатураИнструмента.Guid = NsgService.StringToGuid("e2eafb06-f67d-452d-af6e-f2e6bf84574e");
	
				if (!ObjectList.Contains("НоменклатураИнструмента"))
                    ObjectList.Add(НоменклатураИнструмента);
			}
			#endregion //создание Учет.Номенклатура НоменклатураИнструмента
			
			#region создание System.String СерийныйНомер
			{  
                NsgDataString СерийныйНомер = null;
				if (ObjectList.Contains("СерийныйНомер"))
                    СерийныйНомер = ObjectList["СерийныйНомер"] as NsgDataString;
                else
                    СерийныйНомер = new NsgDataString();
	//NsgDataString
	СерийныйНомер.IsLoadedFromDll = true;
	СерийныйНомер.Length = 50;
	СерийныйНомер.StringFormat = "";
	СерийныйНомер.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СерийныйНомер.IncludeInPredefined = false;
	СерийныйНомер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СерийныйНомер.Required = false;
	СерийныйНомер.EmptyValue = "";
	СерийныйНомер.NullAllow = false;
	СерийныйНомер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СерийныйНомер.FieldName = "SeriijnyijNomer";
	СерийныйНомер.SaveInDatabase = true;
	СерийныйНомер.InformMetaDataOnValueChanged = false;
	СерийныйНомер.Visible = true;
	СерийныйНомер.Name = "СерийныйНомер";
	СерийныйНомер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СерийныйНомер.Description = "Серийный номер";
	СерийныйНомер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СерийныйНомер.GroupName = "";
	СерийныйНомер.Guid = NsgService.StringToGuid("b7a82c2a-4e34-4aa6-9c9b-c67535e680d8");
	
				if (!ObjectList.Contains("СерийныйНомер"))
                    ObjectList.Add(СерийныйНомер);
			}
			#endregion //создание System.String СерийныйНомер
			
			#region создание Учет.Фотографии Фотография
			{  
                NsgDataTypedReference Фотография = null;
				if (ObjectList.Contains("Фотография"))
                    Фотография = ObjectList["Фотография"] as NsgDataTypedReference;
                else
                    Фотография = new NsgDataTypedReference();
	//NsgDataTypedReference
	Фотография.IsLoadedFromDll = true;
	Фотография.ReferentGroup = "Учет";
	Фотография.ReferentName = "Фотографии";
	Фотография.SaveInDatabase = true;
	Фотография.OwnerName = "";
	Фотография.AllowEmptyOwner = false;
	Фотография.StringFormat = "";
	Фотография.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Фотография.IncludeInPredefined = false;
	Фотография.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Фотография.Required = false;
	Фотография.EmptyValue = "";
	Фотография.NullAllow = false;
	Фотография.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Фотография.FieldName = "Fotografija";
	Фотография.InformMetaDataOnValueChanged = false;
	Фотография.Visible = true;
	Фотография.Name = "Фотография";
	Фотография.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Фотография.Description = "Фотография";
	Фотография.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Фотография.GroupName = "";
	Фотография.Guid = NsgService.StringToGuid("f5814049-0ef7-4ebb-96b7-4ae082417d52");
	
				if (!ObjectList.Contains("Фотография"))
                    ObjectList.Add(Фотография);
			}
			#endregion //создание Учет.Фотографии Фотография
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "УчетИнструмента.ПеремещениеИнструмента";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетИнструментаПеремещениеИнструментаТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("bc7bc86e-e1fd-4a3c-a05a-f5cc02341cfb");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetInstrumentaPer";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет инструмента перемещение инструмента таблица";
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
            /// Номенклатура инструмента
            /// </summary>
            public static String НоменклатураИнструмента
            {
                get
                {
                    return "НоменклатураИнструмента";
                }
            }
            
            /// <summary>
            /// Серийный номер
            /// </summary>
            public static String СерийныйНомер
            {
                get
                {
                    return "СерийныйНомер";
                }
            }
            
            /// <summary>
            /// Фотография
            /// </summary>
            public static String Фотография
            {
                get
                {
                    return "Фотография";
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
                    descriptor.Name = "УчетИнструментаПеремещениеИнструментаТаблица";
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
            return "_SystemTables.УчетИнструментаПеремещениеИнструментаТаблица";
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
        [NsgReferentsFilterAttribute("УчетИнструмента.ПеремещениеИнструмента")]
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
        /// Номенклатура инструмента
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Номенклатура НоменклатураИнструмента
        {
            get
            {
				 NsgDataTypedReference __НоменклатураИнструмента = ObjectList["НоменклатураИнструмента"] as NsgDataTypedReference;
                 return (Учет.Номенклатура)__НоменклатураИнструмента.Referent;
            }
            set
            {
                NsgDataTypedReference __НоменклатураИнструмента = ObjectList["НоменклатураИнструмента"] as NsgDataTypedReference;
                __НоменклатураИнструмента.Referent = value;
            }
        }
        
        /// <summary>
        /// Серийный номер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String СерийныйНомер
        {
            get
            {
				 NsgDataString __СерийныйНомер = ObjectList["СерийныйНомер"] as NsgDataString;
                 return (System.String)__СерийныйНомер.Value;
            }
            set
            {
                NsgDataString __СерийныйНомер = ObjectList["СерийныйНомер"] as NsgDataString;
                __СерийныйНомер.Value = value;
            }
        }
        
        /// <summary>
        /// Фотография
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Фотографии Фотография
        {
            get
            {
				 NsgDataTypedReference __Фотография = ObjectList["Фотография"] as NsgDataTypedReference;
                 return (Учет.Фотографии)__Фотография.Referent;
            }
            set
            {
                NsgDataTypedReference __Фотография = ObjectList["Фотография"] as NsgDataTypedReference;
                __Фотография.Referent = value;
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
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка NewRow()
        {
            return newRow(null) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетИнструментаПеремещениеИнструментаТаблица.Строка(this);
            return base.newRow(row) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетИнструментаПеремещениеИнструментаТаблица.Строка NewRow(УчетИнструментаПеремещениеИнструментаТаблица.Строка inRow)
        {
            УчетИнструментаПеремещениеИнструментаТаблица.Строка row = inRow.Clone as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
            return base.newRow(row) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка GetEtalonRow()
        {
            УчетИнструментаПеремещениеИнструментаТаблица.Строка row = new УчетИнструментаПеремещениеИнструментаТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетИнструментаПеремещениеИнструментаТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетИнструментаПеремещениеИнструментаТаблица.Строка[] res = new УчетИнструментаПеремещениеИнструментаТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетИнструментаПеремещениеИнструментаТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетИнструментаПеремещениеИнструментаТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка[] AllRows
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
        public new УчетИнструментаПеремещениеИнструментаТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетИнструментаПеремещениеИнструментаТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетИнструментаПеремещениеИнструментаТаблица[] convertArray(NsgMultipleObject[] array)
        {
            УчетИнструментаПеремещениеИнструментаТаблица[] res = new УчетИнструментаПеремещениеИнструментаТаблица[array.Length];
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
        public new virtual УчетИнструментаПеремещениеИнструментаТаблица[] FindAll(NsgCompare compare)
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
        public new virtual УчетИнструментаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетИнструментаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетИнструментаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетИнструментаПеремещениеИнструментаТаблица(this as NsgObject);
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
                base.NSGType = typeof(УчетИнструментаПеремещениеИнструментаТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетИнструментаПеремещениеИнструментаТаблица Value
            {
                get
                {
                    return (УчетИнструментаПеремещениеИнструментаТаблица)base.Value;
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
