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

namespace TechControl.Метаданные.Учет
{
    
    [NsgTypeName("NsgDataEnum", Guid = "a4e2cece-7df8-4aaf-95df-ca16425f18d8")]
    public partial class СтатусыПеремещений : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Отменено
            {
                NsgDataEnumElement Отменено = null;
                if (ObjectList.Contains("Отменено"))
                    Отменено = ObjectList["Отменено"] as NsgDataEnumElement;
                else
                    Отменено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Отменено.IsLoadedFromDll = true;
	Отменено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Отменено.Index = 1;
	Отменено.StringFormat = "";
	Отменено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Отменено.IncludeInPredefined = false;
	Отменено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Отменено.Required = false;
	Отменено.EmptyValue = "";
	Отменено.NullAllow = false;
	Отменено.FieldName = "Otmeneno";
	Отменено.SaveInDatabase = true;
	Отменено.InformMetaDataOnValueChanged = false;
	Отменено.Visible = true;
	Отменено.Name = "Отменено";
	Отменено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Отменено.Description = "Отменено";
	Отменено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Отменено.GroupName = "";
	Отменено.Guid = NsgService.StringToGuid("d89a474b-fa6e-4b70-bcc8-7133d553ddde");
	
                if (!ObjectList.Contains("Отменено"))
                    ObjectList.Add(Отменено);
			}
			#endregion //создание System.String Отменено
			
            #region создание System.String Частично
            {
                NsgDataEnumElement Частично = null;
                if (ObjectList.Contains("Частично"))
                    Частично = ObjectList["Частично"] as NsgDataEnumElement;
                else
                    Частично = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Частично.IsLoadedFromDll = true;
	Частично.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Частично.Index = 2;
	Частично.StringFormat = "";
	Частично.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Частично.IncludeInPredefined = false;
	Частично.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Частично.Required = false;
	Частично.EmptyValue = "";
	Частично.NullAllow = false;
	Частично.FieldName = "CHastichno";
	Частично.SaveInDatabase = true;
	Частично.InformMetaDataOnValueChanged = false;
	Частично.Visible = true;
	Частично.Name = "Частично";
	Частично.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Частично.Description = "Частично";
	Частично.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Частично.GroupName = "";
	Частично.Guid = NsgService.StringToGuid("2a49f47d-956c-4d01-a4ba-de9b087031b0");
	
                if (!ObjectList.Contains("Частично"))
                    ObjectList.Add(Частично);
			}
			#endregion //создание System.String Частично
			
            #region создание System.String Выполнено
            {
                NsgDataEnumElement Выполнено = null;
                if (ObjectList.Contains("Выполнено"))
                    Выполнено = ObjectList["Выполнено"] as NsgDataEnumElement;
                else
                    Выполнено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Выполнено.IsLoadedFromDll = true;
	Выполнено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Выполнено.Index = 0;
	Выполнено.StringFormat = "";
	Выполнено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Выполнено.IncludeInPredefined = false;
	Выполнено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Выполнено.Required = false;
	Выполнено.EmptyValue = "";
	Выполнено.NullAllow = false;
	Выполнено.FieldName = "Vypolneno";
	Выполнено.SaveInDatabase = true;
	Выполнено.InformMetaDataOnValueChanged = false;
	Выполнено.Visible = true;
	Выполнено.Name = "Выполнено";
	Выполнено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Выполнено.Description = "Выполнено";
	Выполнено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Выполнено.GroupName = "";
	Выполнено.Guid = NsgService.StringToGuid("c749b140-c0c1-4b75-a939-72ba35890e3a");
	
                if (!ObjectList.Contains("Выполнено"))
                    ObjectList.Add(Выполнено);
			}
			#endregion //создание System.String Выполнено
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыПеремещений";
	Visible = true;
	Guid = NsgService.StringToGuid("a4e2cece-7df8-4aaf-95df-ca16425f18d8");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyPeremescheniij";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Перечисление";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Учет";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static СтатусыПеремещений Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("a4e2cece-7df8-4aaf-95df-ca16425f18d8"));
            if (obj == null)
                obj = new СтатусыПеремещений();
            return obj as СтатусыПеремещений;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыПеремещений()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыПеремещений(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Учет.СтатусыПеремещений";
        }

        
        /// <summary>
        /// Отменено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыПеремещений Отменено
        {
            get
            {
                СтатусыПеремещений res = СтатусыПеремещений.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Частично
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыПеремещений Частично
        {
            get
            {
                СтатусыПеремещений res = СтатусыПеремещений.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Выполнено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыПеремещений Выполнено
        {
            get
            {
                СтатусыПеремещений res = СтатусыПеремещений.Новый();
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
		




        public static СтатусыПеремещений Parse(string str)
        {
            СтатусыПеремещений res = СтатусыПеремещений.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыПеремещений(this as NsgObject);
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
                base.NSGType = typeof(СтатусыПеремещений);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыПеремещений Value
            {
                get
                {
                    return (СтатусыПеремещений)base.Value;
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
