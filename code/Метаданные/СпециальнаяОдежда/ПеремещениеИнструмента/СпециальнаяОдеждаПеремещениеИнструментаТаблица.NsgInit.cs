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
    
    [NsgTypeName("NsgDataTable", Guid = "5f59aefa-4036-410d-bf7d-05027d697ed6")]
    public partial class СпециальнаяОдеждаПеремещениеИнструментаТаблица : NsgSoft.DataObjects.NsgDataTable
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
        protected СпециальнаяОдеждаПеремещениеИнструментаТаблица()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected СпециальнаяОдеждаПеремещениеИнструментаТаблица(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static СпециальнаяОдеждаПеремещениеИнструментаТаблица Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("5f59aefa-4036-410d-bf7d-05027d697ed6"));
            if (obj == null)
                obj = new СпециальнаяОдеждаПеремещениеИнструментаТаблица();
            return obj as СпециальнаяОдеждаПеремещениеИнструментаТаблица;
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
	Идентификатор.Guid = NsgService.StringToGuid("06d9933a-8660-4361-be10-6b91c3d485a9");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("f2d8223e-f83d-427a-8b7b-286192256fee");
	
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
	Владелец.FilterForConfigurator = "СпециальнаяОдежда.ПеремещениеИнструмента";
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
	Владелец.Guid = NsgService.StringToGuid("c2411018-4efd-45f8-90e2-3f60ec869a86");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("d92fc1f3-5e94-4e0a-ba53-c7fe47ab7b67");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание СпециальнаяОдежда.Инструменты Инструмент
			{  
                NsgDataTypedReference Инструмент = null;
				if (ObjectList.Contains("Инструмент"))
                    Инструмент = ObjectList["Инструмент"] as NsgDataTypedReference;
                else
                    Инструмент = new NsgDataTypedReference();
	//NsgDataTypedReference
	Инструмент.IsLoadedFromDll = true;
	Инструмент.ReferentGroup = "СпециальнаяОдежда";
	Инструмент.ReferentName = "Инструменты";
	Инструмент.SaveInDatabase = true;
	Инструмент.OwnerName = "";
	Инструмент.AllowEmptyOwner = false;
	Инструмент.StringFormat = "";
	Инструмент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Инструмент.IncludeInPredefined = false;
	Инструмент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Инструмент.Required = false;
	Инструмент.EmptyValue = "";
	Инструмент.NullAllow = false;
	Инструмент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Инструмент.FieldName = "Instrument";
	Инструмент.InformMetaDataOnValueChanged = false;
	Инструмент.Visible = true;
	Инструмент.Name = "Инструмент";
	Инструмент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Инструмент.Description = "Инструмент";
	Инструмент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Инструмент.GroupName = "";
	Инструмент.Guid = NsgService.StringToGuid("9a3b5ca3-0a48-40fa-a105-4a2d3a540eb7");
	
				if (!ObjectList.Contains("Инструмент"))
                    ObjectList.Add(Инструмент);
			}
			#endregion //создание СпециальнаяОдежда.Инструменты Инструмент
			
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
	Количество.Guid = NsgService.StringToGuid("c6d26b83-5eef-41f7-9a53-35b3a0ba53a5");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Int64 Количество
			
			#region создание System.Decimal Сумма
			{  
                NsgDataFloat Сумма = null;
				if (ObjectList.Contains("Сумма"))
                    Сумма = ObjectList["Сумма"] as NsgDataFloat;
                else
                    Сумма = new NsgDataFloat();
	//NsgDataFloat
	Сумма.IsLoadedFromDll = true;
	Сумма.Precision = 2;
	Сумма.HideZero = true;
	Сумма.DefaultValue = 0M;
	Сумма.MinValue = -100000000000000000M;
	Сумма.MaxValue = 100000000000000000M;
	Сумма.UseCalculator = true;
	Сумма.StringFormat = "";
	Сумма.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сумма.IncludeInPredefined = false;
	Сумма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сумма.Required = false;
	Сумма.EmptyValue = "";
	Сумма.NullAllow = false;
	Сумма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сумма.FieldName = "Summa";
	Сумма.SaveInDatabase = true;
	Сумма.InformMetaDataOnValueChanged = false;
	Сумма.Visible = true;
	Сумма.Name = "Сумма";
	Сумма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сумма.Description = "Сумма";
	Сумма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сумма.GroupName = "";
	Сумма.Guid = NsgService.StringToGuid("6eccafe0-6399-4bec-a910-1ebaea23b991");
	
				if (!ObjectList.Contains("Сумма"))
                    ObjectList.Add(Сумма);
			}
			#endregion //создание System.Decimal Сумма
			
			#region создание System.Decimal Цена
			{  
                NsgDataFloat Цена = null;
				if (ObjectList.Contains("Цена"))
                    Цена = ObjectList["Цена"] as NsgDataFloat;
                else
                    Цена = new NsgDataFloat();
	//NsgDataFloat
	Цена.IsLoadedFromDll = true;
	Цена.Precision = 2;
	Цена.HideZero = true;
	Цена.DefaultValue = 0M;
	Цена.MinValue = -100000000000000000M;
	Цена.MaxValue = 100000000000000000M;
	Цена.UseCalculator = true;
	Цена.StringFormat = "";
	Цена.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Цена.IncludeInPredefined = false;
	Цена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Цена.Required = false;
	Цена.EmptyValue = "";
	Цена.NullAllow = false;
	Цена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Цена.FieldName = "Cena";
	Цена.SaveInDatabase = true;
	Цена.InformMetaDataOnValueChanged = false;
	Цена.Visible = true;
	Цена.Name = "Цена";
	Цена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Цена.Description = "Цена";
	Цена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Цена.GroupName = "";
	Цена.Guid = NsgService.StringToGuid("37ad397b-c52c-4345-b1bd-f6cfe4f61e93");
	
				if (!ObjectList.Contains("Цена"))
                    ObjectList.Add(Цена);
			}
			#endregion //создание System.Decimal Цена
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "СпециальнаяОдежда.ПеремещениеИнструмента";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СпециальнаяОдеждаПеремещениеИнструментаТаблица";
	Visible = true;
	Guid = NsgService.StringToGuid("5f59aefa-4036-410d-bf7d-05027d697ed6");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_SpecialnajaOdezhdaP1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Специальная одежда перемещение инструмента таблица";
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
            /// Инструмент
            /// </summary>
            public static String Инструмент
            {
                get
                {
                    return "Инструмент";
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
            /// Сумма
            /// </summary>
            public static String Сумма
            {
                get
                {
                    return "Сумма";
                }
            }
            
            /// <summary>
            /// Цена
            /// </summary>
            public static String Цена
            {
                get
                {
                    return "Цена";
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
                    descriptor.Name = "СпециальнаяОдеждаПеремещениеИнструментаТаблица";
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
            return "_SystemTables.СпециальнаяОдеждаПеремещениеИнструментаТаблица";
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
        [NsgReferentsFilterAttribute("СпециальнаяОдежда.ПеремещениеИнструмента")]
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
        /// Инструмент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public СпециальнаяОдежда.Инструменты Инструмент
        {
            get
            {
				 NsgDataTypedReference __Инструмент = ObjectList["Инструмент"] as NsgDataTypedReference;
                 return (СпециальнаяОдежда.Инструменты)__Инструмент.Referent;
            }
            set
            {
                NsgDataTypedReference __Инструмент = ObjectList["Инструмент"] as NsgDataTypedReference;
                __Инструмент.Referent = value;
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
        /// Сумма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Сумма
        {
            get
            {
				 NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                 return (System.Decimal)__Сумма.Value;
            }
            set
            {
                NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                __Сумма.Value = value;
            }
        }
        
        /// <summary>
        /// Цена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Цена
        {
            get
            {
				 NsgDataFloat __Цена = ObjectList["Цена"] as NsgDataFloat;
                 return (System.Decimal)__Цена.Value;
            }
            set
            {
                NsgDataFloat __Цена = ObjectList["Цена"] as NsgDataFloat;
                __Цена.Value = value;
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
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка NewRow()
        {
            return newRow(null) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка(this);
            return base.newRow(row) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка NewRow(СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка inRow)
        {
            СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка row = inRow.Clone as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
            return base.newRow(row) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка GetEtalonRow()
        {
            СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка row = new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] res = new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<СпециальнаяОдеждаПеремещениеИнструментаТаблица> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<СпециальнаяОдеждаПеремещениеИнструментаТаблица>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка[] AllRows
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
        public new СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as СпециальнаяОдеждаПеремещениеИнструментаТаблица.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private СпециальнаяОдеждаПеремещениеИнструментаТаблица[] convertArray(NsgMultipleObject[] array)
        {
            СпециальнаяОдеждаПеремещениеИнструментаТаблица[] res = new СпециальнаяОдеждаПеремещениеИнструментаТаблица[array.Length];
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
        public new virtual СпециальнаяОдеждаПеремещениеИнструментаТаблица[] FindAll(NsgCompare compare)
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
        public new virtual СпециальнаяОдеждаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual СпециальнаяОдеждаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual СпециальнаяОдеждаПеремещениеИнструментаТаблица[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new СпециальнаяОдеждаПеремещениеИнструментаТаблица(this as NsgObject);
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
                base.NSGType = typeof(СпециальнаяОдеждаПеремещениеИнструментаТаблица);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new СпециальнаяОдеждаПеремещениеИнструментаТаблица Value
            {
                get
                {
                    return (СпециальнаяОдеждаПеремещениеИнструментаТаблица)base.Value;
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
