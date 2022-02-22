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
    
    [NsgTypeName("NsgDataEnum", Guid = "745a7094-96b8-44f4-be8c-ce87cbde8744")]
    public partial class ДеньНедели : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Вторник
            {
                NsgDataEnumElement Вторник = null;
                if (ObjectList.Contains("Вторник"))
                    Вторник = ObjectList["Вторник"] as NsgDataEnumElement;
                else
                    Вторник = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Вторник.IsLoadedFromDll = true;
	Вторник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Вторник.Index = 1;
	Вторник.StringFormat = "";
	Вторник.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Вторник.IncludeInPredefined = false;
	Вторник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Вторник.Required = false;
	Вторник.EmptyValue = "";
	Вторник.NullAllow = false;
	Вторник.FieldName = "Vtornik";
	Вторник.SaveInDatabase = true;
	Вторник.InformMetaDataOnValueChanged = false;
	Вторник.Visible = true;
	Вторник.Name = "Вторник";
	Вторник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Вторник.Description = "Вторник";
	Вторник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Вторник.GroupName = "";
	Вторник.Guid = NsgService.StringToGuid("ce8c05aa-3e01-414b-946f-c85954591b04");
	
                if (!ObjectList.Contains("Вторник"))
                    ObjectList.Add(Вторник);
			}
			#endregion //создание System.String Вторник
			
            #region создание System.String Среда
            {
                NsgDataEnumElement Среда = null;
                if (ObjectList.Contains("Среда"))
                    Среда = ObjectList["Среда"] as NsgDataEnumElement;
                else
                    Среда = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Среда.IsLoadedFromDll = true;
	Среда.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Среда.Index = 2;
	Среда.StringFormat = "";
	Среда.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Среда.IncludeInPredefined = false;
	Среда.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Среда.Required = false;
	Среда.EmptyValue = "";
	Среда.NullAllow = false;
	Среда.FieldName = "Sreda";
	Среда.SaveInDatabase = true;
	Среда.InformMetaDataOnValueChanged = false;
	Среда.Visible = true;
	Среда.Name = "Среда";
	Среда.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Среда.Description = "Среда";
	Среда.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Среда.GroupName = "";
	Среда.Guid = NsgService.StringToGuid("346069b2-8bc4-4f1b-9f6e-1674c0e380c6");
	
                if (!ObjectList.Contains("Среда"))
                    ObjectList.Add(Среда);
			}
			#endregion //создание System.String Среда
			
            #region создание System.String Четверг
            {
                NsgDataEnumElement Четверг = null;
                if (ObjectList.Contains("Четверг"))
                    Четверг = ObjectList["Четверг"] as NsgDataEnumElement;
                else
                    Четверг = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Четверг.IsLoadedFromDll = true;
	Четверг.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Четверг.Index = 3;
	Четверг.StringFormat = "";
	Четверг.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Четверг.IncludeInPredefined = false;
	Четверг.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Четверг.Required = false;
	Четверг.EmptyValue = "";
	Четверг.NullAllow = false;
	Четверг.FieldName = "CHetverg";
	Четверг.SaveInDatabase = true;
	Четверг.InformMetaDataOnValueChanged = false;
	Четверг.Visible = true;
	Четверг.Name = "Четверг";
	Четверг.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Четверг.Description = "Четверг";
	Четверг.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Четверг.GroupName = "";
	Четверг.Guid = NsgService.StringToGuid("86418aa5-dbba-4e28-9978-26be12518092");
	
                if (!ObjectList.Contains("Четверг"))
                    ObjectList.Add(Четверг);
			}
			#endregion //создание System.String Четверг
			
            #region создание System.String Пятница
            {
                NsgDataEnumElement Пятница = null;
                if (ObjectList.Contains("Пятница"))
                    Пятница = ObjectList["Пятница"] as NsgDataEnumElement;
                else
                    Пятница = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Пятница.IsLoadedFromDll = true;
	Пятница.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Пятница.Index = 4;
	Пятница.StringFormat = "";
	Пятница.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Пятница.IncludeInPredefined = false;
	Пятница.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пятница.Required = false;
	Пятница.EmptyValue = "";
	Пятница.NullAllow = false;
	Пятница.FieldName = "Pjatnica";
	Пятница.SaveInDatabase = true;
	Пятница.InformMetaDataOnValueChanged = false;
	Пятница.Visible = true;
	Пятница.Name = "Пятница";
	Пятница.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Пятница.Description = "Пятница";
	Пятница.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Пятница.GroupName = "";
	Пятница.Guid = NsgService.StringToGuid("b0f94b68-a8b6-4408-b9f4-c1856a49132b");
	
                if (!ObjectList.Contains("Пятница"))
                    ObjectList.Add(Пятница);
			}
			#endregion //создание System.String Пятница
			
            #region создание System.String Суббота
            {
                NsgDataEnumElement Суббота = null;
                if (ObjectList.Contains("Суббота"))
                    Суббота = ObjectList["Суббота"] as NsgDataEnumElement;
                else
                    Суббота = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Суббота.IsLoadedFromDll = true;
	Суббота.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Суббота.Index = 5;
	Суббота.StringFormat = "";
	Суббота.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Суббота.IncludeInPredefined = false;
	Суббота.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Суббота.Required = false;
	Суббота.EmptyValue = "";
	Суббота.NullAllow = false;
	Суббота.FieldName = "Subbota";
	Суббота.SaveInDatabase = true;
	Суббота.InformMetaDataOnValueChanged = false;
	Суббота.Visible = true;
	Суббота.Name = "Суббота";
	Суббота.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Суббота.Description = "Суббота";
	Суббота.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Суббота.GroupName = "";
	Суббота.Guid = NsgService.StringToGuid("fe80b8c2-3ef4-401a-a3b9-b8746de28b84");
	
                if (!ObjectList.Contains("Суббота"))
                    ObjectList.Add(Суббота);
			}
			#endregion //создание System.String Суббота
			
            #region создание System.String Воскресенье
            {
                NsgDataEnumElement Воскресенье = null;
                if (ObjectList.Contains("Воскресенье"))
                    Воскресенье = ObjectList["Воскресенье"] as NsgDataEnumElement;
                else
                    Воскресенье = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Воскресенье.IsLoadedFromDll = true;
	Воскресенье.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Воскресенье.Index = 6;
	Воскресенье.StringFormat = "";
	Воскресенье.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Воскресенье.IncludeInPredefined = false;
	Воскресенье.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Воскресенье.Required = false;
	Воскресенье.EmptyValue = "";
	Воскресенье.NullAllow = false;
	Воскресенье.FieldName = "Voskresene";
	Воскресенье.SaveInDatabase = true;
	Воскресенье.InformMetaDataOnValueChanged = false;
	Воскресенье.Visible = true;
	Воскресенье.Name = "Воскресенье";
	Воскресенье.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Воскресенье.Description = "Воскресенье";
	Воскресенье.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Воскресенье.GroupName = "";
	Воскресенье.Guid = NsgService.StringToGuid("5984a7fb-0255-4c41-b194-dfb069ac4918");
	
                if (!ObjectList.Contains("Воскресенье"))
                    ObjectList.Add(Воскресенье);
			}
			#endregion //создание System.String Воскресенье
			
            #region создание System.String Понедельник
            {
                NsgDataEnumElement Понедельник = null;
                if (ObjectList.Contains("Понедельник"))
                    Понедельник = ObjectList["Понедельник"] as NsgDataEnumElement;
                else
                    Понедельник = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Понедельник.IsLoadedFromDll = true;
	Понедельник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Понедельник.Index = 0;
	Понедельник.StringFormat = "";
	Понедельник.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Понедельник.IncludeInPredefined = false;
	Понедельник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Понедельник.Required = false;
	Понедельник.EmptyValue = "";
	Понедельник.NullAllow = false;
	Понедельник.FieldName = "Ponedelnik";
	Понедельник.SaveInDatabase = true;
	Понедельник.InformMetaDataOnValueChanged = false;
	Понедельник.Visible = true;
	Понедельник.Name = "Понедельник";
	Понедельник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Понедельник.Description = "Понедельник";
	Понедельник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Понедельник.GroupName = "";
	Понедельник.Guid = NsgService.StringToGuid("01b678dc-b61e-4516-8806-e193156ed847");
	
                if (!ObjectList.Contains("Понедельник"))
                    ObjectList.Add(Понедельник);
			}
			#endregion //создание System.String Понедельник
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДеньНедели";
	Visible = true;
	Guid = NsgService.StringToGuid("745a7094-96b8-44f4-be8c-ce87cbde8744");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_DenNedeli";
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

		public static ДеньНедели Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("745a7094-96b8-44f4-be8c-ce87cbde8744"));
            if (obj == null)
                obj = new ДеньНедели();
            return obj as ДеньНедели;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ДеньНедели()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ДеньНедели(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.ДеньНедели";
        }

        
        /// <summary>
        /// Вторник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Вторник
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Среда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Среда
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Четверг
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Четверг
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Пятница
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Пятница
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Суббота
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Суббота
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 5;
                return res;
            }
        }

		
        /// <summary>
        /// Воскресенье
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Воскресенье
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
                res.Value = 6;
                return res;
            }
        }

		
        /// <summary>
        /// Понедельник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДеньНедели Понедельник
        {
            get
            {
                ДеньНедели res = ДеньНедели.Новый();
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
		




        public static ДеньНедели Parse(string str)
        {
            ДеньНедели res = ДеньНедели.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ДеньНедели(this as NsgObject);
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
                base.NSGType = typeof(ДеньНедели);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ДеньНедели Value
            {
                get
                {
                    return (ДеньНедели)base.Value;
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
