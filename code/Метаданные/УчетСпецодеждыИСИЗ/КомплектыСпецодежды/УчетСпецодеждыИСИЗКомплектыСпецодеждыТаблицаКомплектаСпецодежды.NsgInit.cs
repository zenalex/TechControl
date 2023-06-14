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
    
    [NsgTypeName("NsgDataTable", Guid = "8396e326-26ac-475f-a29a-61152e8f2f2e")]
    public partial class УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды : NsgSoft.DataObjects.NsgDataTable
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
        protected УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("8396e326-26ac-475f-a29a-61152e8f2f2e"));
            if (obj == null)
                obj = new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды();
            return obj as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды;
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
	Идентификатор.Guid = NsgService.StringToGuid("d50a11fe-4b59-4502-a2b9-2486aa4d3264");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("ad98845f-c61d-4aa0-b36f-48bd0a381d39");
	
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
	Владелец.FilterForConfigurator = "УчетСпецодеждыИСИЗ.КомплектыСпецодежды";
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
	Владелец.Guid = NsgService.StringToGuid("4dcbd4c2-7a9f-4ea9-908f-f89c8721a4b4");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("fa9fb66d-eedd-482b-91ec-60adcd7263bc");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
			{  
                NsgDataTypedReference НоменклатураСпецодеждыИСИЗ = null;
				if (ObjectList.Contains("НоменклатураСпецодеждыИСИЗ"))
                    НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                else
                    НоменклатураСпецодеждыИСИЗ = new NsgDataTypedReference();
	//NsgDataTypedReference
	НоменклатураСпецодеждыИСИЗ.IsLoadedFromDll = true;
	НоменклатураСпецодеждыИСИЗ.ReferentGroup = "Учет";
	НоменклатураСпецодеждыИСИЗ.ReferentName = "Номенклатура";
	НоменклатураСпецодеждыИСИЗ.SaveInDatabase = true;
	НоменклатураСпецодеждыИСИЗ.OwnerName = "";
	НоменклатураСпецодеждыИСИЗ.AllowEmptyOwner = false;
	НоменклатураСпецодеждыИСИЗ.StringFormat = "";
	НоменклатураСпецодеждыИСИЗ.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НоменклатураСпецодеждыИСИЗ.IncludeInPredefined = false;
	НоменклатураСпецодеждыИСИЗ.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НоменклатураСпецодеждыИСИЗ.Required = false;
	НоменклатураСпецодеждыИСИЗ.EmptyValue = "";
	НоменклатураСпецодеждыИСИЗ.NullAllow = false;
	НоменклатураСпецодеждыИСИЗ.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НоменклатураСпецодеждыИСИЗ.FieldName = "NomenklaturaSpeco";
	НоменклатураСпецодеждыИСИЗ.InformMetaDataOnValueChanged = false;
	НоменклатураСпецодеждыИСИЗ.Visible = true;
	НоменклатураСпецодеждыИСИЗ.Name = "НоменклатураСпецодеждыИСИЗ";
	НоменклатураСпецодеждыИСИЗ.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НоменклатураСпецодеждыИСИЗ.Description = "Номенклатура спецодежды ИСИЗ";
	НоменклатураСпецодеждыИСИЗ.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НоменклатураСпецодеждыИСИЗ.GroupName = "";
	НоменклатураСпецодеждыИСИЗ.Guid = NsgService.StringToGuid("b26d0d34-68cd-446c-ae08-229d6d276476");
	
				if (!ObjectList.Contains("НоменклатураСпецодеждыИСИЗ"))
                    ObjectList.Add(НоменклатураСпецодеждыИСИЗ);
			}
			#endregion //создание Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
			
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
	Количество.Guid = NsgService.StringToGuid("ac7749d6-bd61-447a-bffb-a12597258be2");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Decimal Количество
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "УчетСпецодеждыИСИЗ.КомплектыСпецодежды";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды";
	Visible = true;
	Guid = NsgService.StringToGuid("8396e326-26ac-475f-a29a-61152e8f2f2e");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_UchetSpecodezhdyISI2";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Учет спецодежды ИСИЗКомплекты спецодежды таблица комплекта спецодежды";
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
            /// Номенклатура спецодежды ИСИЗ
            /// </summary>
            public static String НоменклатураСпецодеждыИСИЗ
            {
                get
                {
                    return "НоменклатураСпецодеждыИСИЗ";
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
                    descriptor.Name = "УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды";
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
            return "_SystemTables.УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды";
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
        [NsgReferentsFilterAttribute("УчетСпецодеждыИСИЗ.КомплектыСпецодежды")]
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
        /// Номенклатура спецодежды ИСИЗ
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Учет.Номенклатура НоменклатураСпецодеждыИСИЗ
        {
            get
            {
				 NsgDataTypedReference __НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                 return (Учет.Номенклатура)__НоменклатураСпецодеждыИСИЗ.Referent;
            }
            set
            {
                NsgDataTypedReference __НоменклатураСпецодеждыИСИЗ = ObjectList["НоменклатураСпецодеждыИСИЗ"] as NsgDataTypedReference;
                __НоменклатураСпецодеждыИСИЗ.Referent = value;
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка NewRow()
        {
            return newRow(null) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка(this);
            return base.newRow(row) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка NewRow(УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка inRow)
        {
            УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка row = inRow.Clone as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
            return base.newRow(row) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка GetEtalonRow()
        {
            УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка row = new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] res = new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка[] AllRows
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
        public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] convertArray(NsgMultipleObject[] array)
        {
            УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] res = new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[array.Length];
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
        public new virtual УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] FindAll(NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды(this as NsgObject);
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
                base.NSGType = typeof(УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды Value
            {
                get
                {
                    return (УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды)base.Value;
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
