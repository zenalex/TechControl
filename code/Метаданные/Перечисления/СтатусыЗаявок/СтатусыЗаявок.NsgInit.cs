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
    
    [NsgTypeName("NsgDataEnum", Guid = "29f483b0-ce31-4a3b-84b4-03a17a783a7d")]
    public partial class СтатусыЗаявок : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Передана
            {
                NsgDataEnumElement Передана = null;
                if (ObjectList.Contains("Передана"))
                    Передана = ObjectList["Передана"] as NsgDataEnumElement;
                else
                    Передана = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Передана.IsLoadedFromDll = true;
	Передана.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Передана.Index = 1;
	Передана.StringFormat = "";
	Передана.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Передана.IncludeInPredefined = false;
	Передана.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Передана.Required = false;
	Передана.EmptyValue = "";
	Передана.NullAllow = false;
	Передана.FieldName = "Peredana";
	Передана.SaveInDatabase = true;
	Передана.InformMetaDataOnValueChanged = false;
	Передана.Visible = true;
	Передана.Name = "Передана";
	Передана.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Передана.Description = "Передана";
	Передана.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Передана.GroupName = "";
	Передана.Guid = NsgService.StringToGuid("a2f1792a-ef8e-4f14-ab38-1193ca9b9d0a");
	
                if (!ObjectList.Contains("Передана"))
                    ObjectList.Add(Передана);
			}
			#endregion //создание System.String Передана
			
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
	Новая.Guid = NsgService.StringToGuid("f415981c-6958-4956-8c9d-cfe71aa9c097");
	
                if (!ObjectList.Contains("Новая"))
                    ObjectList.Add(Новая);
			}
			#endregion //создание System.String Новая
			
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
	Выполнена.Guid = NsgService.StringToGuid("a458f2bf-5157-4ac7-b6a1-b1c0632523e5");
	
                if (!ObjectList.Contains("Выполнена"))
                    ObjectList.Add(Выполнена);
			}
			#endregion //создание System.String Выполнена
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыЗаявок";
	Visible = true;
	Guid = NsgService.StringToGuid("29f483b0-ce31-4a3b-84b4-03a17a783a7d");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyZajavok";
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

		public static СтатусыЗаявок Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("29f483b0-ce31-4a3b-84b4-03a17a783a7d"));
            if (obj == null)
                obj = new СтатусыЗаявок();
            return obj as СтатусыЗаявок;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыЗаявок()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыЗаявок(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.СтатусыЗаявок";
        }

        
        /// <summary>
        /// Передана
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявок Передана
        {
            get
            {
                СтатусыЗаявок res = СтатусыЗаявок.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Новая
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявок Новая
        {
            get
            {
                СтатусыЗаявок res = СтатусыЗаявок.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Выполнена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявок Выполнена
        {
            get
            {
                СтатусыЗаявок res = СтатусыЗаявок.Новый();
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
		




        public static СтатусыЗаявок Parse(string str)
        {
            СтатусыЗаявок res = СтатусыЗаявок.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыЗаявок(this as NsgObject);
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
                base.NSGType = typeof(СтатусыЗаявок);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыЗаявок Value
            {
                get
                {
                    return (СтатусыЗаявок)base.Value;
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
