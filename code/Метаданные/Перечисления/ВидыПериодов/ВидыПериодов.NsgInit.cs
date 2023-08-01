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

namespace TechControl.Метаданные.Перечисления
{
    
    [NsgTypeName("NsgDataEnum", Guid = "fb714f67-f0be-4e93-a355-ae5413271c0a")]
    public partial class ВидыПериодов : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Месяц
            {
                NsgDataEnumElement Месяц = null;
                if (ObjectList.Contains("Месяц"))
                    Месяц = ObjectList["Месяц"] as NsgDataEnumElement;
                else
                    Месяц = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Месяц.IsLoadedFromDll = true;
	Месяц.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Месяц.Index = 0;
	Месяц.StringFormat = "";
	Месяц.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Месяц.IncludeInPredefined = false;
	Месяц.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Месяц.Required = false;
	Месяц.EmptyValue = "";
	Месяц.NullAllow = false;
	Месяц.FieldName = "Mesjac";
	Месяц.SaveInDatabase = true;
	Месяц.InformMetaDataOnValueChanged = false;
	Месяц.Visible = true;
	Месяц.Name = "Месяц";
	Месяц.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Месяц.Description = "Месяц";
	Месяц.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Месяц.GroupName = "";
	Месяц.Guid = NsgService.StringToGuid("ddf19c52-5445-44be-a4e8-9ce7a32417e8");
	
                if (!ObjectList.Contains("Месяц"))
                    ObjectList.Add(Месяц);
			}
			#endregion //создание System.String Месяц
			
            #region создание System.String Квартал
            {
                NsgDataEnumElement Квартал = null;
                if (ObjectList.Contains("Квартал"))
                    Квартал = ObjectList["Квартал"] as NsgDataEnumElement;
                else
                    Квартал = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Квартал.IsLoadedFromDll = true;
	Квартал.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Квартал.Index = 1;
	Квартал.StringFormat = "";
	Квартал.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Квартал.IncludeInPredefined = false;
	Квартал.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Квартал.Required = false;
	Квартал.EmptyValue = "";
	Квартал.NullAllow = false;
	Квартал.FieldName = "Kvartal";
	Квартал.SaveInDatabase = true;
	Квартал.InformMetaDataOnValueChanged = false;
	Квартал.Visible = true;
	Квартал.Name = "Квартал";
	Квартал.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Квартал.Description = "Квартал";
	Квартал.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Квартал.GroupName = "";
	Квартал.Guid = NsgService.StringToGuid("a6ce716b-c40e-4d86-a97f-bc269e1836a4");
	
                if (!ObjectList.Contains("Квартал"))
                    ObjectList.Add(Квартал);
			}
			#endregion //создание System.String Квартал
			
            #region создание System.String Полугодие
            {
                NsgDataEnumElement Полугодие = null;
                if (ObjectList.Contains("Полугодие"))
                    Полугодие = ObjectList["Полугодие"] as NsgDataEnumElement;
                else
                    Полугодие = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Полугодие.IsLoadedFromDll = true;
	Полугодие.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Полугодие.Index = 2;
	Полугодие.StringFormat = "";
	Полугодие.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Полугодие.IncludeInPredefined = false;
	Полугодие.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Полугодие.Required = false;
	Полугодие.EmptyValue = "";
	Полугодие.NullAllow = false;
	Полугодие.FieldName = "Polugodie";
	Полугодие.SaveInDatabase = true;
	Полугодие.InformMetaDataOnValueChanged = false;
	Полугодие.Visible = true;
	Полугодие.Name = "Полугодие";
	Полугодие.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Полугодие.Description = "Полугодие";
	Полугодие.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Полугодие.GroupName = "";
	Полугодие.Guid = NsgService.StringToGuid("0c8defc2-ea53-42be-b31c-b51a483bfaa0");
	
                if (!ObjectList.Contains("Полугодие"))
                    ObjectList.Add(Полугодие);
			}
			#endregion //создание System.String Полугодие
			
            #region создание System.String Год
            {
                NsgDataEnumElement Год = null;
                if (ObjectList.Contains("Год"))
                    Год = ObjectList["Год"] as NsgDataEnumElement;
                else
                    Год = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Год.IsLoadedFromDll = true;
	Год.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Год.Index = 3;
	Год.StringFormat = "";
	Год.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Год.IncludeInPredefined = false;
	Год.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Год.Required = false;
	Год.EmptyValue = "";
	Год.NullAllow = false;
	Год.FieldName = "God";
	Год.SaveInDatabase = true;
	Год.InformMetaDataOnValueChanged = false;
	Год.Visible = true;
	Год.Name = "Год";
	Год.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Год.Description = "Год";
	Год.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Год.GroupName = "";
	Год.Guid = NsgService.StringToGuid("273caf39-ae2c-4742-bc29-cd6ed757e036");
	
                if (!ObjectList.Contains("Год"))
                    ObjectList.Add(Год);
			}
			#endregion //создание System.String Год
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ВидыПериодов";
	Visible = true;
	Guid = NsgService.StringToGuid("fb714f67-f0be-4e93-a355-ae5413271c0a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_VidyPeriodov";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перечисление";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Перечисления";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static ВидыПериодов Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("fb714f67-f0be-4e93-a355-ae5413271c0a"));
            if (obj == null)
                obj = new ВидыПериодов();
            return obj as ВидыПериодов;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ВидыПериодов()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ВидыПериодов(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.ВидыПериодов";
        }

        
        /// <summary>
        /// Месяц
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыПериодов Месяц
        {
            get
            {
                ВидыПериодов res = ВидыПериодов.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Квартал
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыПериодов Квартал
        {
            get
            {
                ВидыПериодов res = ВидыПериодов.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Полугодие
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыПериодов Полугодие
        {
            get
            {
                ВидыПериодов res = ВидыПериодов.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Год
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыПериодов Год
        {
            get
            {
                ВидыПериодов res = ВидыПериодов.Новый();
                res.Value = 3;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ВидыПериодов Parse(string str)
        {
            ВидыПериодов res = ВидыПериодов.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ВидыПериодов(this as NsgObject);
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
                base.NSGType = typeof(ВидыПериодов);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ВидыПериодов Value
            {
                get
                {
                    return (ВидыПериодов)base.Value;
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
