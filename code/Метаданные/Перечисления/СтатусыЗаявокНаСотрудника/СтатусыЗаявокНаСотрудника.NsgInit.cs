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
    
    [NsgTypeName("NsgDataEnum", Guid = "2f07747c-d98a-418d-8619-8b8c4ceb6492")]
    public partial class СтатусыЗаявокНаСотрудника : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Создана
            {
                NsgDataEnumElement Создана = null;
                if (ObjectList.Contains("Создана"))
                    Создана = ObjectList["Создана"] as NsgDataEnumElement;
                else
                    Создана = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Создана.IsLoadedFromDll = true;
	Создана.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Создана.Index = 0;
	Создана.StringFormat = "";
	Создана.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Создана.IncludeInPredefined = false;
	Создана.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Создана.Required = false;
	Создана.EmptyValue = "";
	Создана.NullAllow = false;
	Создана.FieldName = "Sozdana";
	Создана.SaveInDatabase = true;
	Создана.InformMetaDataOnValueChanged = false;
	Создана.Visible = true;
	Создана.Name = "Создана";
	Создана.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Создана.Description = "Создана";
	Создана.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Создана.GroupName = "";
	Создана.Guid = NsgService.StringToGuid("1c385c09-8543-4bc2-9a0a-7918308fb5db");
	
                if (!ObjectList.Contains("Создана"))
                    ObjectList.Add(Создана);
			}
			#endregion //создание System.String Создана
			
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
	Отменена.Index = 1;
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
	Отменена.Guid = NsgService.StringToGuid("45573a8a-9985-4433-af57-f4b3d40ae6e8");
	
                if (!ObjectList.Contains("Отменена"))
                    ObjectList.Add(Отменена);
			}
			#endregion //создание System.String Отменена
			
            #region создание System.String ГотоваКВыдаче
            {
                NsgDataEnumElement ГотоваКВыдаче = null;
                if (ObjectList.Contains("ГотоваКВыдаче"))
                    ГотоваКВыдаче = ObjectList["ГотоваКВыдаче"] as NsgDataEnumElement;
                else
                    ГотоваКВыдаче = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ГотоваКВыдаче.IsLoadedFromDll = true;
	ГотоваКВыдаче.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ГотоваКВыдаче.Index = 2;
	ГотоваКВыдаче.StringFormat = "";
	ГотоваКВыдаче.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ГотоваКВыдаче.IncludeInPredefined = false;
	ГотоваКВыдаче.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГотоваКВыдаче.Required = false;
	ГотоваКВыдаче.EmptyValue = "";
	ГотоваКВыдаче.NullAllow = false;
	ГотоваКВыдаче.FieldName = "GotovaKVydache";
	ГотоваКВыдаче.SaveInDatabase = true;
	ГотоваКВыдаче.InformMetaDataOnValueChanged = false;
	ГотоваКВыдаче.Visible = true;
	ГотоваКВыдаче.Name = "ГотоваКВыдаче";
	ГотоваКВыдаче.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ГотоваКВыдаче.Description = "Готова КВыдаче";
	ГотоваКВыдаче.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ГотоваКВыдаче.GroupName = "";
	ГотоваКВыдаче.Guid = NsgService.StringToGuid("f5d87aa7-1a31-4f02-ac6e-a74988f09de2");
	
                if (!ObjectList.Contains("ГотоваКВыдаче"))
                    ObjectList.Add(ГотоваКВыдаче);
			}
			#endregion //создание System.String ГотоваКВыдаче
			
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
	Выполнена.Index = 3;
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
	Выполнена.Guid = NsgService.StringToGuid("b30c5d4c-a2d3-4b97-993c-10d5a89286f7");
	
                if (!ObjectList.Contains("Выполнена"))
                    ObjectList.Add(Выполнена);
			}
			#endregion //создание System.String Выполнена
			
            #region создание System.String ТребуетОбъединения
            {
                NsgDataEnumElement ТребуетОбъединения = null;
                if (ObjectList.Contains("ТребуетОбъединения"))
                    ТребуетОбъединения = ObjectList["ТребуетОбъединения"] as NsgDataEnumElement;
                else
                    ТребуетОбъединения = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ТребуетОбъединения.IsLoadedFromDll = true;
	ТребуетОбъединения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТребуетОбъединения.Index = 4;
	ТребуетОбъединения.StringFormat = "";
	ТребуетОбъединения.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ТребуетОбъединения.IncludeInPredefined = false;
	ТребуетОбъединения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТребуетОбъединения.Required = false;
	ТребуетОбъединения.EmptyValue = "";
	ТребуетОбъединения.NullAllow = false;
	ТребуетОбъединения.FieldName = "TrebuetObedinenija";
	ТребуетОбъединения.SaveInDatabase = true;
	ТребуетОбъединения.InformMetaDataOnValueChanged = false;
	ТребуетОбъединения.Visible = true;
	ТребуетОбъединения.Name = "ТребуетОбъединения";
	ТребуетОбъединения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ТребуетОбъединения.Description = "Требует объединения";
	ТребуетОбъединения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ТребуетОбъединения.GroupName = "";
	ТребуетОбъединения.Guid = NsgService.StringToGuid("5b0f4361-55ed-4a90-81c9-5ad1da9359a5");
	
                if (!ObjectList.Contains("ТребуетОбъединения"))
                    ObjectList.Add(ТребуетОбъединения);
			}
			#endregion //создание System.String ТребуетОбъединения
			
            #region создание System.String Объединена
            {
                NsgDataEnumElement Объединена = null;
                if (ObjectList.Contains("Объединена"))
                    Объединена = ObjectList["Объединена"] as NsgDataEnumElement;
                else
                    Объединена = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Объединена.IsLoadedFromDll = true;
	Объединена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Объединена.Index = 5;
	Объединена.StringFormat = "";
	Объединена.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Объединена.IncludeInPredefined = false;
	Объединена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Объединена.Required = false;
	Объединена.EmptyValue = "";
	Объединена.NullAllow = false;
	Объединена.FieldName = "Obedinena";
	Объединена.SaveInDatabase = true;
	Объединена.InformMetaDataOnValueChanged = false;
	Объединена.Visible = true;
	Объединена.Name = "Объединена";
	Объединена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Объединена.Description = "Объединена";
	Объединена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Объединена.GroupName = "";
	Объединена.Guid = NsgService.StringToGuid("90fbf4f5-3360-4696-bd87-5e9a153cfaf7");
	
                if (!ObjectList.Contains("Объединена"))
                    ObjectList.Add(Объединена);
			}
			#endregion //создание System.String Объединена
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыЗаявокНаСотрудника";
	Visible = true;
	Guid = NsgService.StringToGuid("2f07747c-d98a-418d-8619-8b8c4ceb6492");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyZajavokNaSo";
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

		public static СтатусыЗаявокНаСотрудника Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("2f07747c-d98a-418d-8619-8b8c4ceb6492"));
            if (obj == null)
                obj = new СтатусыЗаявокНаСотрудника();
            return obj as СтатусыЗаявокНаСотрудника;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыЗаявокНаСотрудника()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыЗаявокНаСотрудника(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.СтатусыЗаявокНаСотрудника";
        }

        
        /// <summary>
        /// Создана
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника Создана
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Отменена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника Отменена
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Готова КВыдаче
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника ГотоваКВыдаче
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Выполнена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника Выполнена
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Требует объединения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника ТребуетОбъединения
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Объединена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыЗаявокНаСотрудника Объединена
        {
            get
            {
                СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
                res.Value = 5;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static СтатусыЗаявокНаСотрудника Parse(string str)
        {
            СтатусыЗаявокНаСотрудника res = СтатусыЗаявокНаСотрудника.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыЗаявокНаСотрудника(this as NsgObject);
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
                base.NSGType = typeof(СтатусыЗаявокНаСотрудника);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыЗаявокНаСотрудника Value
            {
                get
                {
                    return (СтатусыЗаявокНаСотрудника)base.Value;
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
