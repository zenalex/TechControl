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
    
    [NsgTypeName("NsgDataEnum", Guid = "1223222b-45cc-4ef5-9e62-e0fdb951cab4")]
    public partial class ТипСобственности : NsgSoft.DataObjects.NsgDataEnum
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
	Собственный.Guid = NsgService.StringToGuid("855f3446-a828-4c64-9dd5-4f4fbfc85017");
	
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
	Аренда.Guid = NsgService.StringToGuid("9e14e0c9-4e36-422b-913a-4d806148351b");
	
                if (!ObjectList.Contains("Аренда"))
                    ObjectList.Add(Аренда);
			}
			#endregion //создание System.String Аренда
			
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
	Неизвестно.Guid = NsgService.StringToGuid("26850b8c-7d91-4c42-8021-2c441eb697a8");
	
                if (!ObjectList.Contains("Неизвестно"))
                    ObjectList.Add(Неизвестно);
			}
			#endregion //создание System.String Неизвестно
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипСобственности";
	Visible = true;
	Guid = NsgService.StringToGuid("1223222b-45cc-4ef5-9e62-e0fdb951cab4");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_TipSobstvennosti";
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

		public static ТипСобственности Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("1223222b-45cc-4ef5-9e62-e0fdb951cab4"));
            if (obj == null)
                obj = new ТипСобственности();
            return obj as ТипСобственности;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипСобственности()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипСобственности(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.ТипСобственности";
        }

        
        /// <summary>
        /// Собственный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСобственности Собственный
        {
            get
            {
                ТипСобственности res = ТипСобственности.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Аренда
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСобственности Аренда
        {
            get
            {
                ТипСобственности res = ТипСобственности.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Неизвестно
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСобственности Неизвестно
        {
            get
            {
                ТипСобственности res = ТипСобственности.Новый();
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
		




        public static ТипСобственности Parse(string str)
        {
            ТипСобственности res = ТипСобственности.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипСобственности(this as NsgObject);
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
                base.NSGType = typeof(ТипСобственности);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипСобственности Value
            {
                get
                {
                    return (ТипСобственности)base.Value;
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
