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
    
    [NsgTypeName("NsgDataEnum", Guid = "52a672f1-644a-4a72-b3e3-475beead7260")]
    public partial class ТипСистемыСлежения : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Скаут
            {
                NsgDataEnumElement Скаут = null;
                if (ObjectList.Contains("Скаут"))
                    Скаут = ObjectList["Скаут"] as NsgDataEnumElement;
                else
                    Скаут = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Скаут.IsLoadedFromDll = true;
	Скаут.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Скаут.Index = 0;
	Скаут.StringFormat = "";
	Скаут.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Скаут.IncludeInPredefined = false;
	Скаут.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Скаут.Required = false;
	Скаут.EmptyValue = "";
	Скаут.NullAllow = false;
	Скаут.FieldName = "Skaut";
	Скаут.SaveInDatabase = true;
	Скаут.InformMetaDataOnValueChanged = false;
	Скаут.Visible = true;
	Скаут.Name = "Скаут";
	Скаут.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Скаут.Description = "Скаут";
	Скаут.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Скаут.GroupName = "";
	Скаут.Guid = NsgService.StringToGuid("7c8a5e58-4851-447e-b828-73e78378e09d");
	
                if (!ObjectList.Contains("Скаут"))
                    ObjectList.Add(Скаут);
			}
			#endregion //создание System.String Скаут
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипСистемыСлежения";
	Visible = true;
	Guid = NsgService.StringToGuid("52a672f1-644a-4a72-b3e3-475beead7260");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_TipSistemySlezhenija";
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

		public static ТипСистемыСлежения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("52a672f1-644a-4a72-b3e3-475beead7260"));
            if (obj == null)
                obj = new ТипСистемыСлежения();
            return obj as ТипСистемыСлежения;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипСистемыСлежения()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипСистемыСлежения(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.ТипСистемыСлежения";
        }

        
        /// <summary>
        /// Скаут
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСистемыСлежения Скаут
        {
            get
            {
                ТипСистемыСлежения res = ТипСистемыСлежения.Новый();
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
		




        public static ТипСистемыСлежения Parse(string str)
        {
            ТипСистемыСлежения res = ТипСистемыСлежения.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипСистемыСлежения(this as NsgObject);
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
                base.NSGType = typeof(ТипСистемыСлежения);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипСистемыСлежения Value
            {
                get
                {
                    return (ТипСистемыСлежения)base.Value;
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
