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
    
    [NsgTypeName("NsgDataEnum", Guid = "70d5fc1a-4827-4762-b40d-f4747dc4b890")]
    public partial class ИсточникиЗаправки : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String ПоставщикТоплива
            {
                NsgDataEnumElement ПоставщикТоплива = null;
                if (ObjectList.Contains("ПоставщикТоплива"))
                    ПоставщикТоплива = ObjectList["ПоставщикТоплива"] as NsgDataEnumElement;
                else
                    ПоставщикТоплива = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПоставщикТоплива.IsLoadedFromDll = true;
	ПоставщикТоплива.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПоставщикТоплива.Index = 1;
	ПоставщикТоплива.StringFormat = "";
	ПоставщикТоплива.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПоставщикТоплива.IncludeInPredefined = false;
	ПоставщикТоплива.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПоставщикТоплива.Required = false;
	ПоставщикТоплива.EmptyValue = "";
	ПоставщикТоплива.NullAllow = false;
	ПоставщикТоплива.FieldName = "PostavschikTopliva";
	ПоставщикТоплива.SaveInDatabase = true;
	ПоставщикТоплива.InformMetaDataOnValueChanged = false;
	ПоставщикТоплива.Visible = true;
	ПоставщикТоплива.Name = "ПоставщикТоплива";
	ПоставщикТоплива.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПоставщикТоплива.Description = "Поставщик топлива";
	ПоставщикТоплива.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПоставщикТоплива.GroupName = "";
	ПоставщикТоплива.Guid = NsgService.StringToGuid("b1aaba59-2e26-4f72-95d3-ed7bbb71fb79");
	
                if (!ObjectList.Contains("ПоставщикТоплива"))
                    ObjectList.Add(ПоставщикТоплива);
			}
			#endregion //создание System.String ПоставщикТоплива
			
            #region создание System.String СобственныеЗапасы
            {
                NsgDataEnumElement СобственныеЗапасы = null;
                if (ObjectList.Contains("СобственныеЗапасы"))
                    СобственныеЗапасы = ObjectList["СобственныеЗапасы"] as NsgDataEnumElement;
                else
                    СобственныеЗапасы = new NsgDataEnumElement();
                	//NsgDataEnumElement
	СобственныеЗапасы.IsLoadedFromDll = true;
	СобственныеЗапасы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СобственныеЗапасы.Index = 0;
	СобственныеЗапасы.StringFormat = "";
	СобственныеЗапасы.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СобственныеЗапасы.IncludeInPredefined = false;
	СобственныеЗапасы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СобственныеЗапасы.Required = false;
	СобственныеЗапасы.EmptyValue = "";
	СобственныеЗапасы.NullAllow = false;
	СобственныеЗапасы.FieldName = "SobstvennyeZapasy";
	СобственныеЗапасы.SaveInDatabase = true;
	СобственныеЗапасы.InformMetaDataOnValueChanged = false;
	СобственныеЗапасы.Visible = true;
	СобственныеЗапасы.Name = "СобственныеЗапасы";
	СобственныеЗапасы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СобственныеЗапасы.Description = "Собственные запасы";
	СобственныеЗапасы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СобственныеЗапасы.GroupName = "";
	СобственныеЗапасы.Guid = NsgService.StringToGuid("d18e4588-c0fe-418c-a81c-47085d9abc5f");
	
                if (!ObjectList.Contains("СобственныеЗапасы"))
                    ObjectList.Add(СобственныеЗапасы);
			}
			#endregion //создание System.String СобственныеЗапасы
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ИсточникиЗаправки";
	Visible = true;
	Guid = NsgService.StringToGuid("70d5fc1a-4827-4762-b40d-f4747dc4b890");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_IstochnikiZapravki";
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

		public static ИсточникиЗаправки Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("70d5fc1a-4827-4762-b40d-f4747dc4b890"));
            if (obj == null)
                obj = new ИсточникиЗаправки();
            return obj as ИсточникиЗаправки;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ИсточникиЗаправки()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ИсточникиЗаправки(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.ИсточникиЗаправки";
        }

        
        /// <summary>
        /// Поставщик топлива
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ИсточникиЗаправки ПоставщикТоплива
        {
            get
            {
                ИсточникиЗаправки res = ИсточникиЗаправки.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Собственные запасы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ИсточникиЗаправки СобственныеЗапасы
        {
            get
            {
                ИсточникиЗаправки res = ИсточникиЗаправки.Новый();
                res.Value = 0;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ИсточникиЗаправки Parse(string str)
        {
            ИсточникиЗаправки res = ИсточникиЗаправки.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ИсточникиЗаправки(this as NsgObject);
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
                base.NSGType = typeof(ИсточникиЗаправки);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ИсточникиЗаправки Value
            {
                get
                {
                    return (ИсточникиЗаправки)base.Value;
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
