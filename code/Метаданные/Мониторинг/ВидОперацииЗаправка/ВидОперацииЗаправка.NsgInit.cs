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

namespace TechControl.Метаданные.Мониторинг
{
    
    [NsgTypeName("NsgDataEnum", Guid = "487e357b-cc2b-4d47-b0ac-6b8f822d2802")]
    public partial class ВидОперацииЗаправка : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Заправка
            {
                NsgDataEnumElement Заправка = null;
                if (ObjectList.Contains("Заправка"))
                    Заправка = ObjectList["Заправка"] as NsgDataEnumElement;
                else
                    Заправка = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Заправка.IsLoadedFromDll = true;
	Заправка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Заправка.Index = 0;
	Заправка.StringFormat = "";
	Заправка.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Заправка.IncludeInPredefined = false;
	Заправка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Заправка.Required = false;
	Заправка.EmptyValue = "";
	Заправка.NullAllow = false;
	Заправка.FieldName = "Zapravka";
	Заправка.SaveInDatabase = true;
	Заправка.InformMetaDataOnValueChanged = false;
	Заправка.Visible = true;
	Заправка.Name = "Заправка";
	Заправка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Заправка.Description = "Заправка";
	Заправка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Заправка.GroupName = "";
	Заправка.Guid = NsgService.StringToGuid("002d6dd5-e793-4145-b8fd-6b978a8b58cb");
	
                if (!ObjectList.Contains("Заправка"))
                    ObjectList.Add(Заправка);
			}
			#endregion //создание System.String Заправка
			
            #region создание System.String Слив
            {
                NsgDataEnumElement Слив = null;
                if (ObjectList.Contains("Слив"))
                    Слив = ObjectList["Слив"] as NsgDataEnumElement;
                else
                    Слив = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Слив.IsLoadedFromDll = true;
	Слив.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Слив.Index = 1;
	Слив.StringFormat = "";
	Слив.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Слив.IncludeInPredefined = false;
	Слив.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Слив.Required = false;
	Слив.EmptyValue = "";
	Слив.NullAllow = false;
	Слив.FieldName = "Sliv";
	Слив.SaveInDatabase = true;
	Слив.InformMetaDataOnValueChanged = false;
	Слив.Visible = true;
	Слив.Name = "Слив";
	Слив.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Слив.Description = "Слив";
	Слив.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Слив.GroupName = "";
	Слив.Guid = NsgService.StringToGuid("4a18924c-d2be-4133-a114-0adc193b1df9");
	
                if (!ObjectList.Contains("Слив"))
                    ObjectList.Add(Слив);
			}
			#endregion //создание System.String Слив
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ВидОперацииЗаправка";
	Visible = true;
	Guid = NsgService.StringToGuid("487e357b-cc2b-4d47-b0ac-6b8f822d2802");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_VidOperaciiZapravka";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перечисление";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Мониторинг";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static ВидОперацииЗаправка Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("487e357b-cc2b-4d47-b0ac-6b8f822d2802"));
            if (obj == null)
                obj = new ВидОперацииЗаправка();
            return obj as ВидОперацииЗаправка;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ВидОперацииЗаправка()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ВидОперацииЗаправка(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.ВидОперацииЗаправка";
        }

        
        /// <summary>
        /// Заправка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидОперацииЗаправка Заправка
        {
            get
            {
                ВидОперацииЗаправка res = ВидОперацииЗаправка.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Слив
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидОперацииЗаправка Слив
        {
            get
            {
                ВидОперацииЗаправка res = ВидОперацииЗаправка.Новый();
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
		




        public static ВидОперацииЗаправка Parse(string str)
        {
            ВидОперацииЗаправка res = ВидОперацииЗаправка.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ВидОперацииЗаправка(this as NsgObject);
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
                base.NSGType = typeof(ВидОперацииЗаправка);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ВидОперацииЗаправка Value
            {
                get
                {
                    return (ВидОперацииЗаправка)base.Value;
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
