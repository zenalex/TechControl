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
    
    [NsgTypeName("NsgDataEnum", Guid = "57b4fb97-25a6-4ea4-8da3-bd56b8b35846")]
    public partial class СтатусыОповещений : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String ТребуетсяОтправка
            {
                NsgDataEnumElement ТребуетсяОтправка = null;
                if (ObjectList.Contains("ТребуетсяОтправка"))
                    ТребуетсяОтправка = ObjectList["ТребуетсяОтправка"] as NsgDataEnumElement;
                else
                    ТребуетсяОтправка = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ТребуетсяОтправка.IsLoadedFromDll = true;
	ТребуетсяОтправка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТребуетсяОтправка.Index = 0;
	ТребуетсяОтправка.StringFormat = "";
	ТребуетсяОтправка.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТребуетсяОтправка.IncludeInPredefined = false;
	ТребуетсяОтправка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТребуетсяОтправка.Required = false;
	ТребуетсяОтправка.EmptyValue = "";
	ТребуетсяОтправка.NullAllow = false;
	ТребуетсяОтправка.FieldName = "Sozdan";
	ТребуетсяОтправка.SaveInDatabase = true;
	ТребуетсяОтправка.InformMetaDataOnValueChanged = false;
	ТребуетсяОтправка.Visible = true;
	ТребуетсяОтправка.Name = "ТребуетсяОтправка";
	ТребуетсяОтправка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуетсяОтправка.Description = "Требуется отправка";
	ТребуетсяОтправка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТребуетсяОтправка.GroupName = "";
	ТребуетсяОтправка.Guid = NsgService.StringToGuid("937a4d1a-aef7-4dcb-8b83-f83b2bbcc3e3");
	
                if (!ObjectList.Contains("ТребуетсяОтправка"))
                    ObjectList.Add(ТребуетсяОтправка);
			}
			#endregion //создание System.String ТребуетсяОтправка
			
            #region создание System.String Отправлен
            {
                NsgDataEnumElement Отправлен = null;
                if (ObjectList.Contains("Отправлен"))
                    Отправлен = ObjectList["Отправлен"] as NsgDataEnumElement;
                else
                    Отправлен = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Отправлен.IsLoadedFromDll = true;
	Отправлен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Отправлен.Index = 1;
	Отправлен.StringFormat = "";
	Отправлен.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Отправлен.IncludeInPredefined = false;
	Отправлен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Отправлен.Required = false;
	Отправлен.EmptyValue = "";
	Отправлен.NullAllow = false;
	Отправлен.FieldName = "Otpravlen";
	Отправлен.SaveInDatabase = true;
	Отправлен.InformMetaDataOnValueChanged = false;
	Отправлен.Visible = true;
	Отправлен.Name = "Отправлен";
	Отправлен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Отправлен.Description = "Отправлен";
	Отправлен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Отправлен.GroupName = "";
	Отправлен.Guid = NsgService.StringToGuid("43c5226d-bb5e-4a35-be09-20d8bd2c3a2c");
	
                if (!ObjectList.Contains("Отправлен"))
                    ObjectList.Add(Отправлен);
			}
			#endregion //создание System.String Отправлен
			
            #region создание System.String ОтправленПовторно
            {
                NsgDataEnumElement ОтправленПовторно = null;
                if (ObjectList.Contains("ОтправленПовторно"))
                    ОтправленПовторно = ObjectList["ОтправленПовторно"] as NsgDataEnumElement;
                else
                    ОтправленПовторно = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ОтправленПовторно.IsLoadedFromDll = true;
	ОтправленПовторно.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОтправленПовторно.Index = 2;
	ОтправленПовторно.StringFormat = "";
	ОтправленПовторно.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОтправленПовторно.IncludeInPredefined = false;
	ОтправленПовторно.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОтправленПовторно.Required = false;
	ОтправленПовторно.EmptyValue = "";
	ОтправленПовторно.NullAllow = false;
	ОтправленПовторно.FieldName = "OtpravlenPovtorno";
	ОтправленПовторно.SaveInDatabase = true;
	ОтправленПовторно.InformMetaDataOnValueChanged = false;
	ОтправленПовторно.Visible = true;
	ОтправленПовторно.Name = "ОтправленПовторно";
	ОтправленПовторно.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОтправленПовторно.Description = "Отправлен повторно";
	ОтправленПовторно.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОтправленПовторно.GroupName = "";
	ОтправленПовторно.Guid = NsgService.StringToGuid("9cd59c7f-19a5-48a1-9731-5fc56b14a6b2");
	
                if (!ObjectList.Contains("ОтправленПовторно"))
                    ObjectList.Add(ОтправленПовторно);
			}
			#endregion //создание System.String ОтправленПовторно
			
            #region создание System.String Выполнен
            {
                NsgDataEnumElement Выполнен = null;
                if (ObjectList.Contains("Выполнен"))
                    Выполнен = ObjectList["Выполнен"] as NsgDataEnumElement;
                else
                    Выполнен = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Выполнен.IsLoadedFromDll = true;
	Выполнен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Выполнен.Index = 3;
	Выполнен.StringFormat = "";
	Выполнен.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Выполнен.IncludeInPredefined = false;
	Выполнен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Выполнен.Required = false;
	Выполнен.EmptyValue = "";
	Выполнен.NullAllow = false;
	Выполнен.FieldName = "Vypolnen";
	Выполнен.SaveInDatabase = true;
	Выполнен.InformMetaDataOnValueChanged = false;
	Выполнен.Visible = true;
	Выполнен.Name = "Выполнен";
	Выполнен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выполнен.Description = "Выполнен";
	Выполнен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Выполнен.GroupName = "";
	Выполнен.Guid = NsgService.StringToGuid("510e1fb8-4c46-4d82-be1d-41df0e318abf");
	
                if (!ObjectList.Contains("Выполнен"))
                    ObjectList.Add(Выполнен);
			}
			#endregion //создание System.String Выполнен
			
            #region создание System.String ОжидаетсяРазрешениеНаОтправку
            {
                NsgDataEnumElement ОжидаетсяРазрешениеНаОтправку = null;
                if (ObjectList.Contains("ОжидаетсяРазрешениеНаОтправку"))
                    ОжидаетсяРазрешениеНаОтправку = ObjectList["ОжидаетсяРазрешениеНаОтправку"] as NsgDataEnumElement;
                else
                    ОжидаетсяРазрешениеНаОтправку = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ОжидаетсяРазрешениеНаОтправку.IsLoadedFromDll = true;
	ОжидаетсяРазрешениеНаОтправку.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОжидаетсяРазрешениеНаОтправку.Index = 4;
	ОжидаетсяРазрешениеНаОтправку.StringFormat = "";
	ОжидаетсяРазрешениеНаОтправку.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОжидаетсяРазрешениеНаОтправку.IncludeInPredefined = false;
	ОжидаетсяРазрешениеНаОтправку.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОжидаетсяРазрешениеНаОтправку.Required = false;
	ОжидаетсяРазрешениеНаОтправку.EmptyValue = "";
	ОжидаетсяРазрешениеНаОтправку.NullAllow = false;
	ОжидаетсяРазрешениеНаОтправку.FieldName = "OzhidaetsjaRazres";
	ОжидаетсяРазрешениеНаОтправку.SaveInDatabase = true;
	ОжидаетсяРазрешениеНаОтправку.InformMetaDataOnValueChanged = false;
	ОжидаетсяРазрешениеНаОтправку.Visible = true;
	ОжидаетсяРазрешениеНаОтправку.Name = "ОжидаетсяРазрешениеНаОтправку";
	ОжидаетсяРазрешениеНаОтправку.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОжидаетсяРазрешениеНаОтправку.Description = "Ожидается разрешение на отправку";
	ОжидаетсяРазрешениеНаОтправку.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОжидаетсяРазрешениеНаОтправку.GroupName = "";
	ОжидаетсяРазрешениеНаОтправку.Guid = NsgService.StringToGuid("a7be8d15-f0d5-4b92-b9d6-4121a2342e0f");
	
                if (!ObjectList.Contains("ОжидаетсяРазрешениеНаОтправку"))
                    ObjectList.Add(ОжидаетсяРазрешениеНаОтправку);
			}
			#endregion //создание System.String ОжидаетсяРазрешениеНаОтправку
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыОповещений";
	Visible = true;
	Guid = NsgService.StringToGuid("57b4fb97-25a6-4ea4-8da3-bd56b8b35846");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyOpovescheniij";
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

		public static СтатусыОповещений Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("57b4fb97-25a6-4ea4-8da3-bd56b8b35846"));
            if (obj == null)
                obj = new СтатусыОповещений();
            return obj as СтатусыОповещений;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыОповещений()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыОповещений(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.СтатусыОповещений";
        }

        
        /// <summary>
        /// Требуется отправка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыОповещений ТребуетсяОтправка
        {
            get
            {
                СтатусыОповещений res = СтатусыОповещений.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Отправлен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыОповещений Отправлен
        {
            get
            {
                СтатусыОповещений res = СтатусыОповещений.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Отправлен повторно
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыОповещений ОтправленПовторно
        {
            get
            {
                СтатусыОповещений res = СтатусыОповещений.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Выполнен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыОповещений Выполнен
        {
            get
            {
                СтатусыОповещений res = СтатусыОповещений.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Ожидается разрешение на отправку
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыОповещений ОжидаетсяРазрешениеНаОтправку
        {
            get
            {
                СтатусыОповещений res = СтатусыОповещений.Новый();
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
		




        public static СтатусыОповещений Parse(string str)
        {
            СтатусыОповещений res = СтатусыОповещений.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыОповещений(this as NsgObject);
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
                base.NSGType = typeof(СтатусыОповещений);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыОповещений Value
            {
                get
                {
                    return (СтатусыОповещений)base.Value;
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
