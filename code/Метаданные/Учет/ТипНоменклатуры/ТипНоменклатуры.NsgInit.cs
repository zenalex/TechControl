using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.Design;
using System.ComponentModel;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace TechControl.Метаданные.Учет
{
    
    [NsgTypeName("NsgDataEnum", Guid = "6a061ab7-d046-483e-be8e-1f967de3afd5")]
    public partial class ТипНоменклатуры : NsgSoft.DataObjects.NsgDataEnum
	{
		#region Данные
		#region Данные NsgSoft.DataObjects.NsgDataEnum
		




		#endregion Данные NsgSoft.DataObjects.NsgDataEnum

		#endregion //Данные

		#region Инициализация

		/// <summary>
		/// Инициализация
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей

			
            #region создание System.String Спецодежда
            {
                NsgDataEnumElement Спецодежда = null;
                if (ObjectList.Contains("Спецодежда"))
                    Спецодежда = ObjectList["Спецодежда"] as NsgDataEnumElement;
                else
                    Спецодежда = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Спецодежда.IsLoadedFromDll = true;
	Спецодежда.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Спецодежда.Index = 1;
	Спецодежда.StringFormat = "";
	Спецодежда.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Спецодежда.IncludeInPredefined = false;
	Спецодежда.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Спецодежда.Required = false;
	Спецодежда.EmptyValue = "";
	Спецодежда.NullAllow = false;
	Спецодежда.FieldName = "Specodezhda";
	Спецодежда.SaveInDatabase = true;
	Спецодежда.InformMetaDataOnValueChanged = false;
	Спецодежда.Visible = true;
	Спецодежда.Name = "Спецодежда";
	Спецодежда.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Спецодежда.Description = "Спецодежда";
	Спецодежда.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Спецодежда.GroupName = "";
	Спецодежда.Guid = NsgService.StringToGuid("94709439-3a1b-4fc4-91fc-e06659f49cad");
	
                if (!ObjectList.Contains("Спецодежда"))
                    ObjectList.Add(Спецодежда);
			}
			#endregion //создание System.String Спецодежда
			
            #region создание System.String Инструменты
            {
                NsgDataEnumElement Инструменты = null;
                if (ObjectList.Contains("Инструменты"))
                    Инструменты = ObjectList["Инструменты"] as NsgDataEnumElement;
                else
                    Инструменты = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Инструменты.IsLoadedFromDll = true;
	Инструменты.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Инструменты.Index = 2;
	Инструменты.StringFormat = "";
	Инструменты.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Инструменты.IncludeInPredefined = false;
	Инструменты.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Инструменты.Required = false;
	Инструменты.EmptyValue = "";
	Инструменты.NullAllow = false;
	Инструменты.FieldName = "Instrumenty";
	Инструменты.SaveInDatabase = true;
	Инструменты.InformMetaDataOnValueChanged = false;
	Инструменты.Visible = true;
	Инструменты.Name = "Инструменты";
	Инструменты.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Инструменты.Description = "Инструменты";
	Инструменты.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Инструменты.GroupName = "";
	Инструменты.Guid = NsgService.StringToGuid("e0a5ca77-f0c3-405f-873a-787a2de1803d");
	
                if (!ObjectList.Contains("Инструменты"))
                    ObjectList.Add(Инструменты);
			}
			#endregion //создание System.String Инструменты
			
            #region создание System.String Материалы
            {
                NsgDataEnumElement Материалы = null;
                if (ObjectList.Contains("Материалы"))
                    Материалы = ObjectList["Материалы"] as NsgDataEnumElement;
                else
                    Материалы = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Материалы.IsLoadedFromDll = true;
	Материалы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Материалы.Index = 0;
	Материалы.StringFormat = "";
	Материалы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Материалы.IncludeInPredefined = false;
	Материалы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Материалы.Required = false;
	Материалы.EmptyValue = "";
	Материалы.NullAllow = false;
	Материалы.FieldName = "Materialy";
	Материалы.SaveInDatabase = true;
	Материалы.InformMetaDataOnValueChanged = false;
	Материалы.Visible = true;
	Материалы.Name = "Материалы";
	Материалы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Материалы.Description = "Материалы";
	Материалы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Материалы.GroupName = "";
	Материалы.Guid = NsgService.StringToGuid("3a2d3163-1a8b-4184-a002-16408d23c67b");
	
                if (!ObjectList.Contains("Материалы"))
                    ObjectList.Add(Материалы);
			}
			#endregion //создание System.String Материалы
			
            #region создание System.String Продукция
            {
                NsgDataEnumElement Продукция = null;
                if (ObjectList.Contains("Продукция"))
                    Продукция = ObjectList["Продукция"] as NsgDataEnumElement;
                else
                    Продукция = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Продукция.IsLoadedFromDll = true;
	Продукция.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Продукция.Index = 3;
	Продукция.StringFormat = "";
	Продукция.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Продукция.IncludeInPredefined = false;
	Продукция.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Продукция.Required = false;
	Продукция.EmptyValue = "";
	Продукция.NullAllow = false;
	Продукция.FieldName = "Produkcija";
	Продукция.SaveInDatabase = true;
	Продукция.InformMetaDataOnValueChanged = false;
	Продукция.Visible = true;
	Продукция.Name = "Продукция";
	Продукция.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Продукция.Description = "Продукция";
	Продукция.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Продукция.GroupName = "";
	Продукция.Guid = NsgService.StringToGuid("c3bcc274-1bcf-497e-8e5e-c9340b19f138");
	
                if (!ObjectList.Contains("Продукция"))
                    ObjectList.Add(Продукция);
			}
			#endregion //создание System.String Продукция
			
            #region создание System.String Товары
            {
                NsgDataEnumElement Товары = null;
                if (ObjectList.Contains("Товары"))
                    Товары = ObjectList["Товары"] as NsgDataEnumElement;
                else
                    Товары = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Товары.IsLoadedFromDll = true;
	Товары.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Товары.Index = 4;
	Товары.StringFormat = "";
	Товары.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Товары.IncludeInPredefined = false;
	Товары.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Товары.Required = false;
	Товары.EmptyValue = "";
	Товары.NullAllow = false;
	Товары.FieldName = "Tovary";
	Товары.SaveInDatabase = true;
	Товары.InformMetaDataOnValueChanged = false;
	Товары.Visible = true;
	Товары.Name = "Товары";
	Товары.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Товары.Description = "Товары";
	Товары.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Товары.GroupName = "";
	Товары.Guid = NsgService.StringToGuid("84b2e8d1-b974-4673-8519-caed16f0f2be");
	
                if (!ObjectList.Contains("Товары"))
                    ObjectList.Add(Товары);
			}
			#endregion //создание System.String Товары
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипНоменклатуры";
	Visible = true;
	Guid = NsgService.StringToGuid("6a061ab7-d046-483e-be8e-1f967de3afd5");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_TipNomenklatury";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перечисление";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Учет";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static ТипНоменклатуры Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("6a061ab7-d046-483e-be8e-1f967de3afd5"));
            if (obj == null)
                obj = new ТипНоменклатуры();
            return obj as ТипНоменклатуры;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипНоменклатуры()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипНоменклатуры(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Учет.ТипНоменклатуры";
        }

        
        /// <summary>
        /// Спецодежда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипНоменклатуры Спецодежда
        {
            get
            {
                ТипНоменклатуры res = ТипНоменклатуры.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Инструменты
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипНоменклатуры Инструменты
        {
            get
            {
                ТипНоменклатуры res = ТипНоменклатуры.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Материалы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипНоменклатуры Материалы
        {
            get
            {
                ТипНоменклатуры res = ТипНоменклатуры.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Продукция
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипНоменклатуры Продукция
        {
            get
            {
                ТипНоменклатуры res = ТипНоменклатуры.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Товары
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипНоменклатуры Товары
        {
            get
            {
                ТипНоменклатуры res = ТипНоменклатуры.Новый();
                res.Value = 4;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ТипНоменклатуры Parse(string str)
        {
            ТипНоменклатуры res = ТипНоменклатуры.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипНоменклатуры(this as NsgObject);
            }
        }

		#endregion //Методы NsgMultipleObject
		#endregion //Методы

		/// <summary>
		///  Описатель колонки источника данных
		/// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(ТипНоменклатуры);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипНоменклатуры Value
            {
                get
                {
                    return (ТипНоменклатуры)base.Value;
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
                    return "s_NsgDataEnum";
                }
            }
        }

    }
    
}
