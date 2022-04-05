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

namespace TechControl.Метаданные.СпециальнаяОдежда
{
    
    [NsgTypeName("NsgDataEnum", Guid = "f69c6611-b20d-43f9-9688-caba33adfbec")]
    public partial class Сезонность : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Зима
            {
                NsgDataEnumElement Зима = null;
                if (ObjectList.Contains("Зима"))
                    Зима = ObjectList["Зима"] as NsgDataEnumElement;
                else
                    Зима = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Зима.IsLoadedFromDll = true;
	Зима.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Зима.Index = 0;
	Зима.StringFormat = "";
	Зима.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Зима.IncludeInPredefined = false;
	Зима.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Зима.Required = false;
	Зима.EmptyValue = "";
	Зима.NullAllow = false;
	Зима.FieldName = "Zima";
	Зима.SaveInDatabase = true;
	Зима.InformMetaDataOnValueChanged = false;
	Зима.Visible = true;
	Зима.Name = "Зима";
	Зима.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Зима.Description = "Зима";
	Зима.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Зима.GroupName = "";
	Зима.Guid = NsgService.StringToGuid("92f9406b-69f3-4527-9781-af60564b9b20");
	
                if (!ObjectList.Contains("Зима"))
                    ObjectList.Add(Зима);
			}
			#endregion //создание System.String Зима
			
            #region создание System.String Лето
            {
                NsgDataEnumElement Лето = null;
                if (ObjectList.Contains("Лето"))
                    Лето = ObjectList["Лето"] as NsgDataEnumElement;
                else
                    Лето = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Лето.IsLoadedFromDll = true;
	Лето.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Лето.Index = 1;
	Лето.StringFormat = "";
	Лето.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Лето.IncludeInPredefined = false;
	Лето.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Лето.Required = false;
	Лето.EmptyValue = "";
	Лето.NullAllow = false;
	Лето.FieldName = "Leto";
	Лето.SaveInDatabase = true;
	Лето.InformMetaDataOnValueChanged = false;
	Лето.Visible = true;
	Лето.Name = "Лето";
	Лето.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Лето.Description = "Лето";
	Лето.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Лето.GroupName = "";
	Лето.Guid = NsgService.StringToGuid("cb4de941-98b7-442c-8dfa-f3d7b00ca3f0");
	
                if (!ObjectList.Contains("Лето"))
                    ObjectList.Add(Лето);
			}
			#endregion //создание System.String Лето
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Сезонность";
	Visible = true;
	Guid = NsgService.StringToGuid("f69c6611-b20d-43f9-9688-caba33adfbec");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_Sezonnost";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перечисление";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "СпециальнаяОдежда";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static Сезонность Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f69c6611-b20d-43f9-9688-caba33adfbec"));
            if (obj == null)
                obj = new Сезонность();
            return obj as Сезонность;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected Сезонность()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  Сезонность(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "СпециальнаяОдежда.Сезонность";
        }

        
        /// <summary>
        /// Зима
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Сезонность Зима
        {
            get
            {
                Сезонность res = Сезонность.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Лето
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Сезонность Лето
        {
            get
            {
                Сезонность res = Сезонность.Новый();
                res.Value = 1;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static Сезонность Parse(string str)
        {
            Сезонность res = Сезонность.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new Сезонность(this as NsgObject);
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
                base.NSGType = typeof(Сезонность);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new Сезонность Value
            {
                get
                {
                    return (Сезонность)base.Value;
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
