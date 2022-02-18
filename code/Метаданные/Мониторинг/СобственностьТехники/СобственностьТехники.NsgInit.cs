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
    
    [NsgTypeName("NsgDataEnum", Guid = "df2f17b4-a0b2-4947-903d-1fa614d6e414")]
    public partial class СобственностьТехники : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Неизвестно
            {
                NsgDataEnumElement Неизвестно = null;
                if (ObjectList.Contains("Неизвестно"))
                    Неизвестно = ObjectList["Неизвестно"] as NsgDataEnumElement;
                else
                    Неизвестно = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Неизвестно.IsLoadedFromDll = true;
	Неизвестно.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Неизвестно.Index = 0;
	Неизвестно.StringFormat = "";
	Неизвестно.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Неизвестно.IncludeInPredefined = false;
	Неизвестно.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Неизвестно.Required = false;
	Неизвестно.EmptyValue = "";
	Неизвестно.NullAllow = false;
	Неизвестно.FieldName = "Neizvestno";
	Неизвестно.SaveInDatabase = true;
	Неизвестно.InformMetaDataOnValueChanged = false;
	Неизвестно.Visible = true;
	Неизвестно.Name = "Неизвестно";
	Неизвестно.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Неизвестно.Description = "Неизвестно";
	Неизвестно.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Неизвестно.GroupName = "";
	Неизвестно.Guid = NsgService.StringToGuid("b532973c-0fce-4618-bb62-dd575005502e");
	
                if (!ObjectList.Contains("Неизвестно"))
                    ObjectList.Add(Неизвестно);
			}
			#endregion //создание System.String Неизвестно
			
            #region создание System.String Собственный
            {
                NsgDataEnumElement Собственный = null;
                if (ObjectList.Contains("Собственный"))
                    Собственный = ObjectList["Собственный"] as NsgDataEnumElement;
                else
                    Собственный = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Собственный.IsLoadedFromDll = true;
	Собственный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Собственный.Index = 1;
	Собственный.StringFormat = "";
	Собственный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Собственный.IncludeInPredefined = false;
	Собственный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Собственный.Required = false;
	Собственный.EmptyValue = "";
	Собственный.NullAllow = false;
	Собственный.FieldName = "Sobstvennyij";
	Собственный.SaveInDatabase = true;
	Собственный.InformMetaDataOnValueChanged = false;
	Собственный.Visible = true;
	Собственный.Name = "Собственный";
	Собственный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Собственный.Description = "Собственный";
	Собственный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Собственный.GroupName = "";
	Собственный.Guid = NsgService.StringToGuid("b0951cdc-021d-4ba5-a31a-da7b09159019");
	
                if (!ObjectList.Contains("Собственный"))
                    ObjectList.Add(Собственный);
			}
			#endregion //создание System.String Собственный
			
            #region создание System.String Аренда
            {
                NsgDataEnumElement Аренда = null;
                if (ObjectList.Contains("Аренда"))
                    Аренда = ObjectList["Аренда"] as NsgDataEnumElement;
                else
                    Аренда = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Аренда.IsLoadedFromDll = true;
	Аренда.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Аренда.Index = 2;
	Аренда.StringFormat = "";
	Аренда.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Аренда.IncludeInPredefined = false;
	Аренда.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Аренда.Required = false;
	Аренда.EmptyValue = "";
	Аренда.NullAllow = false;
	Аренда.FieldName = "Arenda";
	Аренда.SaveInDatabase = true;
	Аренда.InformMetaDataOnValueChanged = false;
	Аренда.Visible = true;
	Аренда.Name = "Аренда";
	Аренда.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Аренда.Description = "Аренда";
	Аренда.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Аренда.GroupName = "";
	Аренда.Guid = NsgService.StringToGuid("0f6c4670-fb8f-4f45-9a1a-32fd762e817b");
	
                if (!ObjectList.Contains("Аренда"))
                    ObjectList.Add(Аренда);
			}
			#endregion //создание System.String Аренда
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СобственностьТехники";
	Visible = true;
	Guid = NsgService.StringToGuid("df2f17b4-a0b2-4947-903d-1fa614d6e414");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_SobstvennostTekhniki";
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

		public static СобственностьТехники Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("df2f17b4-a0b2-4947-903d-1fa614d6e414"));
            if (obj == null)
                obj = new СобственностьТехники();
            return obj as СобственностьТехники;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СобственностьТехники()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СобственностьТехники(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.СобственностьТехники";
        }

        
        /// <summary>
        /// Неизвестно
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СобственностьТехники Неизвестно
        {
            get
            {
                СобственностьТехники res = СобственностьТехники.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Собственный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СобственностьТехники Собственный
        {
            get
            {
                СобственностьТехники res = СобственностьТехники.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Аренда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СобственностьТехники Аренда
        {
            get
            {
                СобственностьТехники res = СобственностьТехники.Новый();
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
		




        public static СобственностьТехники Parse(string str)
        {
            СобственностьТехники res = СобственностьТехники.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СобственностьТехники(this as NsgObject);
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
                base.NSGType = typeof(СобственностьТехники);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СобственностьТехники Value
            {
                get
                {
                    return (СобственностьТехники)base.Value;
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
