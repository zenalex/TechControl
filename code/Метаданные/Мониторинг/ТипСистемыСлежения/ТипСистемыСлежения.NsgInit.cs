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
			
            #region создание System.String Сигнализации
            {
                NsgDataEnumElement Сигнализации = null;
                if (ObjectList.Contains("Сигнализации"))
                    Сигнализации = ObjectList["Сигнализации"] as NsgDataEnumElement;
                else
                    Сигнализации = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Сигнализации.IsLoadedFromDll = true;
	Сигнализации.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сигнализации.Index = 1;
	Сигнализации.StringFormat = "";
	Сигнализации.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сигнализации.IncludeInPredefined = false;
	Сигнализации.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сигнализации.Required = false;
	Сигнализации.EmptyValue = "";
	Сигнализации.NullAllow = false;
	Сигнализации.FieldName = "Signalizacii";
	Сигнализации.SaveInDatabase = true;
	Сигнализации.InformMetaDataOnValueChanged = false;
	Сигнализации.Visible = true;
	Сигнализации.Name = "Сигнализации";
	Сигнализации.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сигнализации.Description = "Сигнализации";
	Сигнализации.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сигнализации.GroupName = "";
	Сигнализации.Guid = NsgService.StringToGuid("90bcd894-3190-49ff-b96f-3933e5174a73");
	
                if (!ObjectList.Contains("Сигнализации"))
                    ObjectList.Add(Сигнализации);
			}
			#endregion //создание System.String Сигнализации
			
            #region создание System.String ДанныеВведенныеВРучную
            {
                NsgDataEnumElement ДанныеВведенныеВРучную = null;
                if (ObjectList.Contains("ДанныеВведенныеВРучную"))
                    ДанныеВведенныеВРучную = ObjectList["ДанныеВведенныеВРучную"] as NsgDataEnumElement;
                else
                    ДанныеВведенныеВРучную = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ДанныеВведенныеВРучную.IsLoadedFromDll = true;
	ДанныеВведенныеВРучную.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДанныеВведенныеВРучную.Index = 2;
	ДанныеВведенныеВРучную.StringFormat = "";
	ДанныеВведенныеВРучную.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДанныеВведенныеВРучную.IncludeInPredefined = false;
	ДанныеВведенныеВРучную.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДанныеВведенныеВРучную.Required = false;
	ДанныеВведенныеВРучную.EmptyValue = "";
	ДанныеВведенныеВРучную.NullAllow = false;
	ДанныеВведенныеВРучную.FieldName = "DannyeVvedennyeVR";
	ДанныеВведенныеВРучную.SaveInDatabase = true;
	ДанныеВведенныеВРучную.InformMetaDataOnValueChanged = false;
	ДанныеВведенныеВРучную.Visible = true;
	ДанныеВведенныеВРучную.Name = "ДанныеВведенныеВРучную";
	ДанныеВведенныеВРучную.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДанныеВведенныеВРучную.Description = "Данные введенные ВРучную";
	ДанныеВведенныеВРучную.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДанныеВведенныеВРучную.GroupName = "";
	ДанныеВведенныеВРучную.Guid = NsgService.StringToGuid("31df4566-e872-48ef-ad26-11572ead6586");
	
                if (!ObjectList.Contains("ДанныеВведенныеВРучную"))
                    ObjectList.Add(ДанныеВведенныеВРучную);
			}
			#endregion //создание System.String ДанныеВведенныеВРучную
			

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

		
        /// <summary>
        /// Сигнализации
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСистемыСлежения Сигнализации
        {
            get
            {
                ТипСистемыСлежения res = ТипСистемыСлежения.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Данные введенные ВРучную
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСистемыСлежения ДанныеВведенныеВРучную
        {
            get
            {
                ТипСистемыСлежения res = ТипСистемыСлежения.Новый();
                res.Value = 2;
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
