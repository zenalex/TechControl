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
    
    [NsgTypeName("NsgDataEnum", Guid = "659b8b4a-54ab-43c1-8649-8018d1dd671e")]
    public partial class Роль : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Разнорабочий
            {
                NsgDataEnumElement Разнорабочий = null;
                if (ObjectList.Contains("Разнорабочий"))
                    Разнорабочий = ObjectList["Разнорабочий"] as NsgDataEnumElement;
                else
                    Разнорабочий = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Разнорабочий.IsLoadedFromDll = true;
	Разнорабочий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Разнорабочий.Index = 1;
	Разнорабочий.StringFormat = "";
	Разнорабочий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Разнорабочий.IncludeInPredefined = false;
	Разнорабочий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Разнорабочий.Required = false;
	Разнорабочий.EmptyValue = "";
	Разнорабочий.NullAllow = false;
	Разнорабочий.FieldName = "Raznorabochiij";
	Разнорабочий.SaveInDatabase = true;
	Разнорабочий.InformMetaDataOnValueChanged = false;
	Разнорабочий.Visible = true;
	Разнорабочий.Name = "Разнорабочий";
	Разнорабочий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Разнорабочий.Description = "Разнорабочий";
	Разнорабочий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Разнорабочий.GroupName = "";
	Разнорабочий.Guid = NsgService.StringToGuid("82c5ee9a-b130-427e-9f21-65594a3a254f");
	
                if (!ObjectList.Contains("Разнорабочий"))
                    ObjectList.Add(Разнорабочий);
			}
			#endregion //создание System.String Разнорабочий
			
            #region создание System.String ОператорСпецТехники
            {
                NsgDataEnumElement ОператорСпецТехники = null;
                if (ObjectList.Contains("ОператорСпецТехники"))
                    ОператорСпецТехники = ObjectList["ОператорСпецТехники"] as NsgDataEnumElement;
                else
                    ОператорСпецТехники = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ОператорСпецТехники.IsLoadedFromDll = true;
	ОператорСпецТехники.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОператорСпецТехники.Index = 0;
	ОператорСпецТехники.StringFormat = "";
	ОператорСпецТехники.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОператорСпецТехники.IncludeInPredefined = false;
	ОператорСпецТехники.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОператорСпецТехники.Required = false;
	ОператорСпецТехники.EmptyValue = "";
	ОператорСпецТехники.NullAllow = false;
	ОператорСпецТехники.FieldName = "OperatorSpecTekhniki";
	ОператорСпецТехники.SaveInDatabase = true;
	ОператорСпецТехники.InformMetaDataOnValueChanged = false;
	ОператорСпецТехники.Visible = true;
	ОператорСпецТехники.Name = "ОператорСпецТехники";
	ОператорСпецТехники.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОператорСпецТехники.Description = "Оператор спец техники";
	ОператорСпецТехники.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОператорСпецТехники.GroupName = "";
	ОператорСпецТехники.Guid = NsgService.StringToGuid("f4fe7e73-97f5-4297-80de-f204993cf1fa");
	
                if (!ObjectList.Contains("ОператорСпецТехники"))
                    ObjectList.Add(ОператорСпецТехники);
			}
			#endregion //создание System.String ОператорСпецТехники
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Роль";
	Visible = true;
	Guid = NsgService.StringToGuid("659b8b4a-54ab-43c1-8649-8018d1dd671e");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_Rol";
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

		public static Роль Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("659b8b4a-54ab-43c1-8649-8018d1dd671e"));
            if (obj == null)
                obj = new Роль();
            return obj as Роль;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected Роль()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  Роль(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.Роль";
        }

        
        /// <summary>
        /// Разнорабочий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Роль Разнорабочий
        {
            get
            {
                Роль res = Роль.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Оператор спец техники
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Роль ОператорСпецТехники
        {
            get
            {
                Роль res = Роль.Новый();
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
		




        public static Роль Parse(string str)
        {
            Роль res = Роль.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new Роль(this as NsgObject);
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
                base.NSGType = typeof(Роль);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new Роль Value
            {
                get
                {
                    return (Роль)base.Value;
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
