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
    
    [NsgTypeName("NsgDataEnum", Guid = "cbddc276-cf50-4893-80e3-48a3def83b80")]
    public partial class ВидыРежимовРаботы : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Ежедневно
            {
                NsgDataEnumElement Ежедневно = null;
                if (ObjectList.Contains("Ежедневно"))
                    Ежедневно = ObjectList["Ежедневно"] as NsgDataEnumElement;
                else
                    Ежедневно = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Ежедневно.IsLoadedFromDll = true;
	Ежедневно.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Ежедневно.Index = 0;
	Ежедневно.StringFormat = "";
	Ежедневно.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Ежедневно.IncludeInPredefined = false;
	Ежедневно.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Ежедневно.Required = false;
	Ежедневно.EmptyValue = "";
	Ежедневно.NullAllow = false;
	Ежедневно.FieldName = "Ezhednevno";
	Ежедневно.SaveInDatabase = true;
	Ежедневно.InformMetaDataOnValueChanged = false;
	Ежедневно.Visible = true;
	Ежедневно.Name = "Ежедневно";
	Ежедневно.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Ежедневно.Description = "Ежедневно";
	Ежедневно.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Ежедневно.GroupName = "";
	Ежедневно.Guid = NsgService.StringToGuid("0243bd49-992b-4c48-8d09-65ec9c4f72dc");
	
                if (!ObjectList.Contains("Ежедневно"))
                    ObjectList.Add(Ежедневно);
			}
			#endregion //создание System.String Ежедневно
			
            #region создание System.String ПятьЧерезДва
            {
                NsgDataEnumElement ПятьЧерезДва = null;
                if (ObjectList.Contains("ПятьЧерезДва"))
                    ПятьЧерезДва = ObjectList["ПятьЧерезДва"] as NsgDataEnumElement;
                else
                    ПятьЧерезДва = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПятьЧерезДва.IsLoadedFromDll = true;
	ПятьЧерезДва.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПятьЧерезДва.Index = 1;
	ПятьЧерезДва.StringFormat = "";
	ПятьЧерезДва.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПятьЧерезДва.IncludeInPredefined = false;
	ПятьЧерезДва.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПятьЧерезДва.Required = false;
	ПятьЧерезДва.EmptyValue = "";
	ПятьЧерезДва.NullAllow = false;
	ПятьЧерезДва.FieldName = "PjatCHerezDva";
	ПятьЧерезДва.SaveInDatabase = true;
	ПятьЧерезДва.InformMetaDataOnValueChanged = false;
	ПятьЧерезДва.Visible = true;
	ПятьЧерезДва.Name = "ПятьЧерезДва";
	ПятьЧерезДва.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПятьЧерезДва.Description = "Пять через два";
	ПятьЧерезДва.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПятьЧерезДва.GroupName = "";
	ПятьЧерезДва.Guid = NsgService.StringToGuid("0b18a316-b12a-47b6-92ee-301eadc2c033");
	
                if (!ObjectList.Contains("ПятьЧерезДва"))
                    ObjectList.Add(ПятьЧерезДва);
			}
			#endregion //создание System.String ПятьЧерезДва
			
            #region создание System.String ШестьЧерезОдин
            {
                NsgDataEnumElement ШестьЧерезОдин = null;
                if (ObjectList.Contains("ШестьЧерезОдин"))
                    ШестьЧерезОдин = ObjectList["ШестьЧерезОдин"] as NsgDataEnumElement;
                else
                    ШестьЧерезОдин = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ШестьЧерезОдин.IsLoadedFromDll = true;
	ШестьЧерезОдин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ШестьЧерезОдин.Index = 2;
	ШестьЧерезОдин.StringFormat = "";
	ШестьЧерезОдин.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ШестьЧерезОдин.IncludeInPredefined = false;
	ШестьЧерезОдин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ШестьЧерезОдин.Required = false;
	ШестьЧерезОдин.EmptyValue = "";
	ШестьЧерезОдин.NullAllow = false;
	ШестьЧерезОдин.FieldName = "SHestCHerezOdin";
	ШестьЧерезОдин.SaveInDatabase = true;
	ШестьЧерезОдин.InformMetaDataOnValueChanged = false;
	ШестьЧерезОдин.Visible = true;
	ШестьЧерезОдин.Name = "ШестьЧерезОдин";
	ШестьЧерезОдин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ШестьЧерезОдин.Description = "Шесть через один";
	ШестьЧерезОдин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ШестьЧерезОдин.GroupName = "";
	ШестьЧерезОдин.Guid = NsgService.StringToGuid("b2be4643-3d37-4ab2-a173-670d6b8935fa");
	
                if (!ObjectList.Contains("ШестьЧерезОдин"))
                    ObjectList.Add(ШестьЧерезОдин);
			}
			#endregion //создание System.String ШестьЧерезОдин
			
            #region создание System.String ДваЧерезДва
            {
                NsgDataEnumElement ДваЧерезДва = null;
                if (ObjectList.Contains("ДваЧерезДва"))
                    ДваЧерезДва = ObjectList["ДваЧерезДва"] as NsgDataEnumElement;
                else
                    ДваЧерезДва = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ДваЧерезДва.IsLoadedFromDll = true;
	ДваЧерезДва.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДваЧерезДва.Index = 3;
	ДваЧерезДва.StringFormat = "";
	ДваЧерезДва.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДваЧерезДва.IncludeInPredefined = false;
	ДваЧерезДва.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДваЧерезДва.Required = false;
	ДваЧерезДва.EmptyValue = "";
	ДваЧерезДва.NullAllow = false;
	ДваЧерезДва.FieldName = "DvaCHerezDva";
	ДваЧерезДва.SaveInDatabase = true;
	ДваЧерезДва.InformMetaDataOnValueChanged = false;
	ДваЧерезДва.Visible = true;
	ДваЧерезДва.Name = "ДваЧерезДва";
	ДваЧерезДва.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДваЧерезДва.Description = "Два через два";
	ДваЧерезДва.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДваЧерезДва.GroupName = "";
	ДваЧерезДва.Guid = NsgService.StringToGuid("135980d1-931a-4ca9-a72f-bc7c9f9d544d");
	
                if (!ObjectList.Contains("ДваЧерезДва"))
                    ObjectList.Add(ДваЧерезДва);
			}
			#endregion //создание System.String ДваЧерезДва
			
            #region создание System.String СуткиЧерезТрое
            {
                NsgDataEnumElement СуткиЧерезТрое = null;
                if (ObjectList.Contains("СуткиЧерезТрое"))
                    СуткиЧерезТрое = ObjectList["СуткиЧерезТрое"] as NsgDataEnumElement;
                else
                    СуткиЧерезТрое = new NsgDataEnumElement();
                	//NsgDataEnumElement
	СуткиЧерезТрое.IsLoadedFromDll = true;
	СуткиЧерезТрое.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СуткиЧерезТрое.Index = 4;
	СуткиЧерезТрое.StringFormat = "";
	СуткиЧерезТрое.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СуткиЧерезТрое.IncludeInPredefined = false;
	СуткиЧерезТрое.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СуткиЧерезТрое.Required = false;
	СуткиЧерезТрое.EmptyValue = "";
	СуткиЧерезТрое.NullAllow = false;
	СуткиЧерезТрое.FieldName = "SutkiCHerezTroe";
	СуткиЧерезТрое.SaveInDatabase = true;
	СуткиЧерезТрое.InformMetaDataOnValueChanged = false;
	СуткиЧерезТрое.Visible = true;
	СуткиЧерезТрое.Name = "СуткиЧерезТрое";
	СуткиЧерезТрое.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СуткиЧерезТрое.Description = "Сутки через трое";
	СуткиЧерезТрое.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СуткиЧерезТрое.GroupName = "";
	СуткиЧерезТрое.Guid = NsgService.StringToGuid("e1d5e4c8-2513-4ee3-8831-c9cda0b7bc7b");
	
                if (!ObjectList.Contains("СуткиЧерезТрое"))
                    ObjectList.Add(СуткиЧерезТрое);
			}
			#endregion //создание System.String СуткиЧерезТрое
			
            #region создание System.String СуткиЧерезДвое
            {
                NsgDataEnumElement СуткиЧерезДвое = null;
                if (ObjectList.Contains("СуткиЧерезДвое"))
                    СуткиЧерезДвое = ObjectList["СуткиЧерезДвое"] as NsgDataEnumElement;
                else
                    СуткиЧерезДвое = new NsgDataEnumElement();
                	//NsgDataEnumElement
	СуткиЧерезДвое.IsLoadedFromDll = true;
	СуткиЧерезДвое.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СуткиЧерезДвое.Index = 5;
	СуткиЧерезДвое.StringFormat = "";
	СуткиЧерезДвое.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СуткиЧерезДвое.IncludeInPredefined = false;
	СуткиЧерезДвое.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СуткиЧерезДвое.Required = false;
	СуткиЧерезДвое.EmptyValue = "";
	СуткиЧерезДвое.NullAllow = false;
	СуткиЧерезДвое.FieldName = "SutkiCHerezDvoe";
	СуткиЧерезДвое.SaveInDatabase = true;
	СуткиЧерезДвое.InformMetaDataOnValueChanged = false;
	СуткиЧерезДвое.Visible = true;
	СуткиЧерезДвое.Name = "СуткиЧерезДвое";
	СуткиЧерезДвое.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СуткиЧерезДвое.Description = "Сутки через двое";
	СуткиЧерезДвое.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СуткиЧерезДвое.GroupName = "";
	СуткиЧерезДвое.Guid = NsgService.StringToGuid("fe693cd7-d3f6-4e35-9a31-557d494920d2");
	
                if (!ObjectList.Contains("СуткиЧерезДвое"))
                    ObjectList.Add(СуткиЧерезДвое);
			}
			#endregion //создание System.String СуткиЧерезДвое
			
            #region создание System.String СуткиЧерезСутки
            {
                NsgDataEnumElement СуткиЧерезСутки = null;
                if (ObjectList.Contains("СуткиЧерезСутки"))
                    СуткиЧерезСутки = ObjectList["СуткиЧерезСутки"] as NsgDataEnumElement;
                else
                    СуткиЧерезСутки = new NsgDataEnumElement();
                	//NsgDataEnumElement
	СуткиЧерезСутки.IsLoadedFromDll = true;
	СуткиЧерезСутки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СуткиЧерезСутки.Index = 6;
	СуткиЧерезСутки.StringFormat = "";
	СуткиЧерезСутки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СуткиЧерезСутки.IncludeInPredefined = false;
	СуткиЧерезСутки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СуткиЧерезСутки.Required = false;
	СуткиЧерезСутки.EmptyValue = "";
	СуткиЧерезСутки.NullAllow = false;
	СуткиЧерезСутки.FieldName = "SutkiCHerezSutki";
	СуткиЧерезСутки.SaveInDatabase = true;
	СуткиЧерезСутки.InformMetaDataOnValueChanged = false;
	СуткиЧерезСутки.Visible = true;
	СуткиЧерезСутки.Name = "СуткиЧерезСутки";
	СуткиЧерезСутки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СуткиЧерезСутки.Description = "Сутки через сутки";
	СуткиЧерезСутки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	СуткиЧерезСутки.GroupName = "";
	СуткиЧерезСутки.Guid = NsgService.StringToGuid("352a0974-5141-4433-82cb-9bb2018dca95");
	
                if (!ObjectList.Contains("СуткиЧерезСутки"))
                    ObjectList.Add(СуткиЧерезСутки);
			}
			#endregion //создание System.String СуткиЧерезСутки
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ВидыРежимовРаботы";
	Visible = true;
	Guid = NsgService.StringToGuid("cbddc276-cf50-4893-80e3-48a3def83b80");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_VidyRezhimovRaboty";
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

		public static ВидыРежимовРаботы Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("cbddc276-cf50-4893-80e3-48a3def83b80"));
            if (obj == null)
                obj = new ВидыРежимовРаботы();
            return obj as ВидыРежимовРаботы;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ВидыРежимовРаботы()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ВидыРежимовРаботы(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.ВидыРежимовРаботы";
        }

        
        /// <summary>
        /// Ежедневно
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы Ежедневно
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Пять через два
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы ПятьЧерезДва
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Шесть через один
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы ШестьЧерезОдин
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Два через два
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы ДваЧерезДва
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Сутки через трое
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы СуткиЧерезТрое
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Сутки через двое
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы СуткиЧерезДвое
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 5;
                return res;
            }
        }

		
        /// <summary>
        /// Сутки через сутки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыРежимовРаботы СуткиЧерезСутки
        {
            get
            {
                ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
                res.Value = 6;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ВидыРежимовРаботы Parse(string str)
        {
            ВидыРежимовРаботы res = ВидыРежимовРаботы.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ВидыРежимовРаботы(this as NsgObject);
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
                base.NSGType = typeof(ВидыРежимовРаботы);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ВидыРежимовРаботы Value
            {
                get
                {
                    return (ВидыРежимовРаботы)base.Value;
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
