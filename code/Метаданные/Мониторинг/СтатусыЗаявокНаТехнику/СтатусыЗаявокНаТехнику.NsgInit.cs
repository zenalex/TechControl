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
    
    [NsgTypeName("NsgDataEnum", Guid = "1fbf86e6-f70d-40d1-954a-bf86dfa84549")]
    public partial class СтатусыЗаявокНаТехнику : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String ПереданаКонтрагенту
            {
                NsgDataEnumElement ПереданаКонтрагенту = null;
                if (ObjectList.Contains("ПереданаКонтрагенту"))
                    ПереданаКонтрагенту = ObjectList["ПереданаКонтрагенту"] as NsgDataEnumElement;
                else
                    ПереданаКонтрагенту = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПереданаКонтрагенту.IsLoadedFromDll = true;
	ПереданаКонтрагенту.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПереданаКонтрагенту.Index = 1;
	ПереданаКонтрагенту.StringFormat = "";
	ПереданаКонтрагенту.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПереданаКонтрагенту.IncludeInPredefined = false;
	ПереданаКонтрагенту.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПереданаКонтрагенту.Required = false;
	ПереданаКонтрагенту.EmptyValue = "";
	ПереданаКонтрагенту.NullAllow = false;
	ПереданаКонтрагенту.FieldName = "PeredanaKontragentu";
	ПереданаКонтрагенту.SaveInDatabase = true;
	ПереданаКонтрагенту.InformMetaDataOnValueChanged = false;
	ПереданаКонтрагенту.Visible = true;
	ПереданаКонтрагенту.Name = "ПереданаКонтрагенту";
	ПереданаКонтрагенту.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПереданаКонтрагенту.Description = "Передана контрагенту";
	ПереданаКонтрагенту.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПереданаКонтрагенту.GroupName = "";
	ПереданаКонтрагенту.Guid = NsgService.StringToGuid("b1422734-1eb1-4790-9e6a-85eaf4c2867f");
	
                if (!ObjectList.Contains("ПереданаКонтрагенту"))
                    ObjectList.Add(ПереданаКонтрагенту);
			}
			#endregion //создание System.String ПереданаКонтрагенту
			
            #region создание System.String Выполнена
            {
                NsgDataEnumElement Выполнена = null;
                if (ObjectList.Contains("Выполнена"))
                    Выполнена = ObjectList["Выполнена"] as NsgDataEnumElement;
                else
                    Выполнена = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Выполнена.IsLoadedFromDll = true;
	Выполнена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Выполнена.Index = 2;
	Выполнена.StringFormat = "";
	Выполнена.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Выполнена.IncludeInPredefined = false;
	Выполнена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Выполнена.Required = false;
	Выполнена.EmptyValue = "";
	Выполнена.NullAllow = false;
	Выполнена.FieldName = "Vypolnena";
	Выполнена.SaveInDatabase = true;
	Выполнена.InformMetaDataOnValueChanged = false;
	Выполнена.Visible = true;
	Выполнена.Name = "Выполнена";
	Выполнена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выполнена.Description = "Выполнена";
	Выполнена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Выполнена.GroupName = "";
	Выполнена.Guid = NsgService.StringToGuid("621e2e91-0a2c-4a91-ac01-a631153ff4b0");
	
                if (!ObjectList.Contains("Выполнена"))
                    ObjectList.Add(Выполнена);
			}
			#endregion //создание System.String Выполнена
			
            #region создание System.String Отменена
            {
                NsgDataEnumElement Отменена = null;
                if (ObjectList.Contains("Отменена"))
                    Отменена = ObjectList["Отменена"] as NsgDataEnumElement;
                else
                    Отменена = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Отменена.IsLoadedFromDll = true;
	Отменена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Отменена.Index = 3;
	Отменена.StringFormat = "";
	Отменена.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Отменена.IncludeInPredefined = false;
	Отменена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Отменена.Required = false;
	Отменена.EmptyValue = "";
	Отменена.NullAllow = false;
	Отменена.FieldName = "Otmenena";
	Отменена.SaveInDatabase = true;
	Отменена.InformMetaDataOnValueChanged = false;
	Отменена.Visible = true;
	Отменена.Name = "Отменена";
	Отменена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Отменена.Description = "Отменена";
	Отменена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Отменена.GroupName = "";
	Отменена.Guid = NsgService.StringToGuid("55444c07-156a-4139-94a8-25cd2ab0b696");
	
                if (!ObjectList.Contains("Отменена"))
                    ObjectList.Add(Отменена);
			}
			#endregion //создание System.String Отменена
			
            #region создание System.String НазначенаМашина
            {
                NsgDataEnumElement НазначенаМашина = null;
                if (ObjectList.Contains("НазначенаМашина"))
                    НазначенаМашина = ObjectList["НазначенаМашина"] as NsgDataEnumElement;
                else
                    НазначенаМашина = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НазначенаМашина.IsLoadedFromDll = true;
	НазначенаМашина.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НазначенаМашина.Index = 4;
	НазначенаМашина.StringFormat = "";
	НазначенаМашина.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НазначенаМашина.IncludeInPredefined = false;
	НазначенаМашина.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НазначенаМашина.Required = false;
	НазначенаМашина.EmptyValue = "";
	НазначенаМашина.NullAllow = false;
	НазначенаМашина.FieldName = "NaznachenaMashina";
	НазначенаМашина.SaveInDatabase = true;
	НазначенаМашина.InformMetaDataOnValueChanged = false;
	НазначенаМашина.Visible = true;
	НазначенаМашина.Name = "НазначенаМашина";
	НазначенаМашина.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НазначенаМашина.Description = "Назначена машина";
	НазначенаМашина.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НазначенаМашина.GroupName = "";
	НазначенаМашина.Guid = NsgService.StringToGuid("fc2b05af-b8f5-47ab-8a5e-40e1469964a0");
	
                if (!ObjectList.Contains("НазначенаМашина"))
                    ObjectList.Add(НазначенаМашина);
			}
			#endregion //создание System.String НазначенаМашина
			
            #region создание System.String Новая
            {
                NsgDataEnumElement Новая = null;
                if (ObjectList.Contains("Новая"))
                    Новая = ObjectList["Новая"] as NsgDataEnumElement;
                else
                    Новая = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Новая.IsLoadedFromDll = true;
	Новая.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Новая.Index = 0;
	Новая.StringFormat = "";
	Новая.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Новая.IncludeInPredefined = false;
	Новая.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Новая.Required = false;
	Новая.EmptyValue = "";
	Новая.NullAllow = false;
	Новая.FieldName = "Novaja";
	Новая.SaveInDatabase = true;
	Новая.InformMetaDataOnValueChanged = false;
	Новая.Visible = true;
	Новая.Name = "Новая";
	Новая.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Новая.Description = "Новая";
	Новая.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Новая.GroupName = "";
	Новая.Guid = NsgService.StringToGuid("b34585fd-975d-4cc5-8400-49a37a5ca720");
	
                if (!ObjectList.Contains("Новая"))
                    ObjectList.Add(Новая);
			}
			#endregion //создание System.String Новая
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыЗаявокНаТехнику";
	Visible = true;
	Guid = NsgService.StringToGuid("1fbf86e6-f70d-40d1-954a-bf86dfa84549");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyZajavokNaTe";
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

		public static СтатусыЗаявокНаТехнику Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("1fbf86e6-f70d-40d1-954a-bf86dfa84549"));
            if (obj == null)
                obj = new СтатусыЗаявокНаТехнику();
            return obj as СтатусыЗаявокНаТехнику;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыЗаявокНаТехнику()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыЗаявокНаТехнику(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.СтатусыЗаявокНаТехнику";
        }

        
        /// <summary>
        /// Передана контрагенту
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаТехнику ПереданаКонтрагенту
        {
            get
            {
                СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Выполнена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаТехнику Выполнена
        {
            get
            {
                СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Отменена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаТехнику Отменена
        {
            get
            {
                СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Назначена машина
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаТехнику НазначенаМашина
        {
            get
            {
                СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Новая
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаТехнику Новая
        {
            get
            {
                СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
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
		




        public static СтатусыЗаявокНаТехнику Parse(string str)
        {
            СтатусыЗаявокНаТехнику res = СтатусыЗаявокНаТехнику.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыЗаявокНаТехнику(this as NsgObject);
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
                base.NSGType = typeof(СтатусыЗаявокНаТехнику);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыЗаявокНаТехнику Value
            {
                get
                {
                    return (СтатусыЗаявокНаТехнику)base.Value;
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
