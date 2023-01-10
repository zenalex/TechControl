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
    
    [NsgTypeName("NsgDataTable", Guid = "d0e1159c-763a-4e23-8c89-91dc75f16d02")]
    public partial class УчетПодтверждениеПеремещенияТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетПодтверждениеПеремещенияТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетПодтверждениеПеремещенияТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетПодтверждениеПеремещенияТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("d0e1159c-763a-4e23-8c89-91dc75f16d02"));
            if (obj == null)
                obj = new УчетПодтверждениеПеремещенияТаблица();
            return obj as УчетПодтверждениеПеремещенияТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("9e621d2e-bdd2-4d8e-be12-8fbc4853f4d8");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("d74f3e10-1505-4d91-b15f-5c725c498d44");
	
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
	Владелец.FilterForConfigurator = "Учет.ПодтверждениеПеремещения";
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
	Владелец.Guid = NsgService.StringToGuid("d267f6d4-2d36-4502-8786-06a7e60a18f0");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("c0b192a1-ed84-4528-9bb2-f5b665c90971");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.Int64 Количество
			{  
                NsgDataInteger Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataInteger;
                else
                    Количество = new NsgDataInteger();
	//NsgDataInteger
	Количество.IsLoadedFromDll = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = 0M;
	Количество.MaxValue = 0M;
	Количество.UseCalculator = true;
	Количество.StringFormat = "";
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.SaveInDatabase = true;
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("54a02d93-9984-458f-bf5f-087418cd6863");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Int64 Количество
			
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
	Номенклатура.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Номенклатура.IncludeInPredefined = false;
	Номенклатура.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Номенклатура.Required = true;
	Номенклатура.EmptyValue = "";
	Номенклатура.NullAllow = false;
	Номенклатура.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Номенклатура.FieldName = "Nomenklatura";
	Номенклатура.InformMetaDataOnValueChanged = false;
	Номенклатура.Visible = true;
	Номенклатура.Name = "Номенклатура";
	Номенклатура.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Номенклатура.Description = "Номенклатура";
	Номенклатура.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Номенклатура.GroupName = "";
	Номенклатура.Guid = NsgService.StringToGuid("152515fb-7dd7-465e-9c35-8a3d2433eb27");
	
				if (!ObjectList.Contains("Номенклатура"))
                    ObjectList.Add(Номенклатура);
			}
			#endregion //создание Учет.Номенклатура Номенклатура
			
			#region создание Учет.СвойствоНоменклатуры СвойствоНоменклатуры
			{  
                NsgDataTypedReference СвойствоНоменклатуры = null;
				if (ObjectList.Contains("СвойствоНоменклатуры"))
                    СвойствоНоменклатуры = ObjectList["СвойствоНоменклатуры"] as NsgDataTypedReference;
                else
                    СвойствоНоменклатуры = new NsgDataTypedReference();
	//NsgDataTypedReference
	СвойствоНоменклатуры.IsLoadedFromDll = true;
	СвойствоНоменклатуры.ReferentGroup = "Учет";
	СвойствоНоменклатуры.ReferentName = "СвойствоНоменклатуры";
	СвойствоНоменклатуры.SaveInDatabase = true;
	СвойствоНоменклатуры.OwnerName = "";
	СвойствоНоменклатуры.AllowEmptyOwner = false;
	СвойствоНоменклатуры.StringFormat = "";
	СвойствоНоменклатуры.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СвойствоНоменклатуры.IncludeInPredefined = false;
	СвойствоНоменклатуры.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СвойствоНоменклатуры.Required = false;
	СвойствоНоменклатуры.EmptyValue = "";
	СвойствоНоменклатуры.NullAllow = false;
	СвойствоНоменклатуры.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СвойствоНоменклатуры.FieldName = "SvoijstvoNomenkla";
	СвойствоНоменклатуры.InformMetaDataOnValueChanged = false;
	СвойствоНоменклатуры.Visible = true;
	СвойствоНоменклатуры.Name = "СвойствоНоменклатуры";
	СвойствоНоменклатуры.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СвойствоНоменклатуры.Description = "Свойство номенклатуры";
	СвойствоНоменклатуры.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СвойствоНоменклатуры.GroupName = "";
	СвойствоНоменклатуры.Guid = NsgService.StringToGuid("f067d59b-45e8-4f81-a3ef-cb181ac14b67");
	
				if (!ObjectList.Contains("СвойствоНоменклатуры"))
                    ObjectList.Add(СвойствоНоменклатуры);
			}
			#endregion //создание Учет.СвойствоНоменклатуры СвойствоНоменклатуры
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Учет.ПодтверждениеПеремещения";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетПодтверждениеПеремещенияТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("d0e1159c-763a-4e23-8c89-91dc75f16d02");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetPodtverzhdenie";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет подтверждение перемещения таблица";
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
            /// Свойство номенклатуры
            /// </summary>
            public static String СвойствоНоменклатуры
            {
                get
                {
                    return "СвойствоНоменклатуры";
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
                    descriptor.Name = "УчетПодтверждениеПеремещенияТаблица";
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
            return "_SystemTables.УчетПодтверждениеПеремещенияТаблица";
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
        [NsgReferentsFilterAttribute("Учет.ПодтверждениеПеремещения")]
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
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Количество
        {
            get
            {
				 NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                 return (System.Int64)__Количество.Value;
            }
            set
            {
                NsgDataInteger __Количество = ObjectList["Количество"] as NsgDataInteger;
                __Количество.Value = value;
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
        /// Свойство номенклатуры
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.СвойствоНоменклатуры СвойствоНоменклатуры
        {
            get
            {
				 NsgDataTypedReference __СвойствоНоменклатуры = ObjectList["СвойствоНоменклатуры"] as NsgDataTypedReference;
                 return (Учет.СвойствоНоменклатуры)__СвойствоНоменклатуры.Referent;
            }
            set
            {
                NsgDataTypedReference __СвойствоНоменклатуры = ObjectList["СвойствоНоменклатуры"] as NsgDataTypedReference;
                __СвойствоНоменклатуры.Referent = value;
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
        public new УчетПодтверждениеПеремещенияТаблица.Строка NewRow()
        {
            return newRow(null) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетПодтверждениеПеремещенияТаблица.Строка(this);
            return base.newRow(row) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетПодтверждениеПеремещенияТаблица.Строка NewRow(УчетПодтверждениеПеремещенияТаблица.Строка inRow)
        {
            УчетПодтверждениеПеремещенияТаблица.Строка row = inRow.Clone as УчетПодтверждениеПеремещенияТаблица.Строка;
            return base.newRow(row) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетПодтверждениеПеремещенияТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетПодтверждениеПеремещенияТаблица.Строка GetEtalonRow()
        {
            УчетПодтверждениеПеремещенияТаблица.Строка row = new УчетПодтверждениеПеремещенияТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетПодтверждениеПеремещенияТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетПодтверждениеПеремещенияТаблица.Строка[] res = new УчетПодтверждениеПеремещенияТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетПодтверждениеПеремещенияТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетПодтверждениеПеремещенияТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетПодтверждениеПеремещенияТаблица.Строка[] AllRows
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
        public new УчетПодтверждениеПеремещенияТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетПодтверждениеПеремещенияТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетПодтверждениеПеремещенияТаблица[] convertArray(NsgMultipleObject[] array)
        {
            УчетПодтверждениеПеремещенияТаблица[] res = new УчетПодтверждениеПеремещенияТаблица[array.Length];
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
        public new virtual УчетПодтверждениеПеремещенияТаблица[] FindAll(NsgCompare compare)
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
        public new virtual УчетПодтверждениеПеремещенияТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетПодтверждениеПеремещенияТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетПодтверждениеПеремещенияТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетПодтверждениеПеремещенияТаблица(this as NsgObject);
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
                base.NSGType = typeof(УчетПодтверждениеПеремещенияТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетПодтверждениеПеремещенияТаблица Value
            {
                get
                {
                    return (УчетПодтверждениеПеремещенияТаблица)base.Value;
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
