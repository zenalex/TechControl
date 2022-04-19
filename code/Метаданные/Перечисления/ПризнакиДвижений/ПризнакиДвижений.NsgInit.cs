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
    
    [NsgTypeName("NsgDataEnum", Guid = "0eabd92e-1159-421d-bf96-190687219913")]
    public partial class ПризнакиДвижений : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Возврат
            {
                NsgDataEnumElement Возврат = null;
                if (ObjectList.Contains("Возврат"))
                    Возврат = ObjectList["Возврат"] as NsgDataEnumElement;
                else
                    Возврат = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Возврат.IsLoadedFromDll = true;
	Возврат.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Возврат.Index = 1;
	Возврат.StringFormat = "";
	Возврат.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Возврат.IncludeInPredefined = false;
	Возврат.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Возврат.Required = false;
	Возврат.EmptyValue = "";
	Возврат.NullAllow = false;
	Возврат.FieldName = "Vozvrat";
	Возврат.SaveInDatabase = true;
	Возврат.InformMetaDataOnValueChanged = false;
	Возврат.Visible = true;
	Возврат.Name = "Возврат";
	Возврат.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Возврат.Description = "Возврат";
	Возврат.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Возврат.GroupName = "";
	Возврат.Guid = NsgService.StringToGuid("a93ba4cf-be7f-4cfa-ba30-c03ef513138f");
	
                if (!ObjectList.Contains("Возврат"))
                    ObjectList.Add(Возврат);
			}
			#endregion //создание System.String Возврат
			
            #region создание System.String Выдача
            {
                NsgDataEnumElement Выдача = null;
                if (ObjectList.Contains("Выдача"))
                    Выдача = ObjectList["Выдача"] as NsgDataEnumElement;
                else
                    Выдача = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Выдача.IsLoadedFromDll = true;
	Выдача.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Выдача.Index = 0;
	Выдача.StringFormat = "";
	Выдача.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Выдача.IncludeInPredefined = false;
	Выдача.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Выдача.Required = false;
	Выдача.EmptyValue = "";
	Выдача.NullAllow = false;
	Выдача.FieldName = "Vydacha";
	Выдача.SaveInDatabase = true;
	Выдача.InformMetaDataOnValueChanged = false;
	Выдача.Visible = true;
	Выдача.Name = "Выдача";
	Выдача.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выдача.Description = "Выдача";
	Выдача.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Выдача.GroupName = "";
	Выдача.Guid = NsgService.StringToGuid("0e058883-4ad0-4f64-b57a-968f78aa56a4");
	
                if (!ObjectList.Contains("Выдача"))
                    ObjectList.Add(Выдача);
			}
			#endregion //создание System.String Выдача
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ПризнакиДвижений";
	Visible = true;
	Guid = NsgService.StringToGuid("0eabd92e-1159-421d-bf96-190687219913");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_PriznakiDvizheniij";
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

		public static ПризнакиДвижений Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0eabd92e-1159-421d-bf96-190687219913"));
            if (obj == null)
                obj = new ПризнакиДвижений();
            return obj as ПризнакиДвижений;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ПризнакиДвижений()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ПризнакиДвижений(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.ПризнакиДвижений";
        }

        
        /// <summary>
        /// Возврат
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ПризнакиДвижений Возврат
        {
            get
            {
                ПризнакиДвижений res = ПризнакиДвижений.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Выдача
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ПризнакиДвижений Выдача
        {
            get
            {
                ПризнакиДвижений res = ПризнакиДвижений.Новый();
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
		




        public static ПризнакиДвижений Parse(string str)
        {
            ПризнакиДвижений res = ПризнакиДвижений.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ПризнакиДвижений(this as NsgObject);
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
                base.NSGType = typeof(ПризнакиДвижений);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ПризнакиДвижений Value
            {
                get
                {
                    return (ПризнакиДвижений)base.Value;
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
