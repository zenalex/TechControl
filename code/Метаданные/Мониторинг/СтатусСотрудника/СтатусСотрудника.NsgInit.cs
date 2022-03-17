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
    
    [NsgTypeName("NsgDataEnum", Guid = "647de465-addc-4048-9670-33bacd6ed726")]
    public partial class СтатусСотрудника : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String НаРаботе
            {
                NsgDataEnumElement НаРаботе = null;
                if (ObjectList.Contains("НаРаботе"))
                    НаРаботе = ObjectList["НаРаботе"] as NsgDataEnumElement;
                else
                    НаРаботе = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НаРаботе.IsLoadedFromDll = true;
	НаРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НаРаботе.Index = 0;
	НаРаботе.StringFormat = "";
	НаРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НаРаботе.IncludeInPredefined = false;
	НаРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НаРаботе.Required = false;
	НаРаботе.EmptyValue = "";
	НаРаботе.NullAllow = false;
	НаРаботе.FieldName = "NaRabote";
	НаРаботе.SaveInDatabase = true;
	НаРаботе.InformMetaDataOnValueChanged = false;
	НаРаботе.Visible = true;
	НаРаботе.Name = "НаРаботе";
	НаРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НаРаботе.Description = "На работе";
	НаРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НаРаботе.GroupName = "";
	НаРаботе.Guid = NsgService.StringToGuid("8cc76912-9a3c-4d62-86bc-33ab1760cb94");
	
                if (!ObjectList.Contains("НаРаботе"))
                    ObjectList.Add(НаРаботе);
			}
			#endregion //создание System.String НаРаботе
			
            #region создание System.String Отсутствует
            {
                NsgDataEnumElement Отсутствует = null;
                if (ObjectList.Contains("Отсутствует"))
                    Отсутствует = ObjectList["Отсутствует"] as NsgDataEnumElement;
                else
                    Отсутствует = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Отсутствует.IsLoadedFromDll = true;
	Отсутствует.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Отсутствует.Index = 1;
	Отсутствует.StringFormat = "";
	Отсутствует.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Отсутствует.IncludeInPredefined = false;
	Отсутствует.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Отсутствует.Required = false;
	Отсутствует.EmptyValue = "";
	Отсутствует.NullAllow = false;
	Отсутствует.FieldName = "Otsutstvuet";
	Отсутствует.SaveInDatabase = true;
	Отсутствует.InformMetaDataOnValueChanged = false;
	Отсутствует.Visible = true;
	Отсутствует.Name = "Отсутствует";
	Отсутствует.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Отсутствует.Description = "Отсутствует";
	Отсутствует.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Отсутствует.GroupName = "";
	Отсутствует.Guid = NsgService.StringToGuid("e5c97f0b-49bc-4e9d-8a73-e34eed6f88a5");
	
                if (!ObjectList.Contains("Отсутствует"))
                    ObjectList.Add(Отсутствует);
			}
			#endregion //создание System.String Отсутствует
			
            #region создание System.String ВОтпуске
            {
                NsgDataEnumElement ВОтпуске = null;
                if (ObjectList.Contains("ВОтпуске"))
                    ВОтпуске = ObjectList["ВОтпуске"] as NsgDataEnumElement;
                else
                    ВОтпуске = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ВОтпуске.IsLoadedFromDll = true;
	ВОтпуске.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВОтпуске.Index = 2;
	ВОтпуске.StringFormat = "";
	ВОтпуске.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВОтпуске.IncludeInPredefined = false;
	ВОтпуске.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВОтпуске.Required = false;
	ВОтпуске.EmptyValue = "";
	ВОтпуске.NullAllow = false;
	ВОтпуске.FieldName = "VOtpuske";
	ВОтпуске.SaveInDatabase = true;
	ВОтпуске.InformMetaDataOnValueChanged = false;
	ВОтпуске.Visible = true;
	ВОтпуске.Name = "ВОтпуске";
	ВОтпуске.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВОтпуске.Description = "ВОтпуске";
	ВОтпуске.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВОтпуске.GroupName = "";
	ВОтпуске.Guid = NsgService.StringToGuid("96d9f5b3-fd27-4432-bc98-8daeb9e222de");
	
                if (!ObjectList.Contains("ВОтпуске"))
                    ObjectList.Add(ВОтпуске);
			}
			#endregion //создание System.String ВОтпуске
			
            #region создание System.String НаБольничном
            {
                NsgDataEnumElement НаБольничном = null;
                if (ObjectList.Contains("НаБольничном"))
                    НаБольничном = ObjectList["НаБольничном"] as NsgDataEnumElement;
                else
                    НаБольничном = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НаБольничном.IsLoadedFromDll = true;
	НаБольничном.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НаБольничном.Index = 3;
	НаБольничном.StringFormat = "";
	НаБольничном.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НаБольничном.IncludeInPredefined = false;
	НаБольничном.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НаБольничном.Required = false;
	НаБольничном.EmptyValue = "";
	НаБольничном.NullAllow = false;
	НаБольничном.FieldName = "NaBolnichnom";
	НаБольничном.SaveInDatabase = true;
	НаБольничном.InformMetaDataOnValueChanged = false;
	НаБольничном.Visible = true;
	НаБольничном.Name = "НаБольничном";
	НаБольничном.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НаБольничном.Description = "На больничном";
	НаБольничном.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НаБольничном.GroupName = "";
	НаБольничном.Guid = NsgService.StringToGuid("8aa597d1-17ba-48ae-b05d-3eaa21d65bee");
	
                if (!ObjectList.Contains("НаБольничном"))
                    ObjectList.Add(НаБольничном);
			}
			#endregion //создание System.String НаБольничном
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусСотрудника";
	Visible = true;
	Guid = NsgService.StringToGuid("647de465-addc-4048-9670-33bacd6ed726");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusSotrudnika";
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

		public static СтатусСотрудника Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("647de465-addc-4048-9670-33bacd6ed726"));
            if (obj == null)
                obj = new СтатусСотрудника();
            return obj as СтатусСотрудника;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусСотрудника()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусСотрудника(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.СтатусСотрудника";
        }

        
        /// <summary>
        /// На работе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусСотрудника НаРаботе
        {
            get
            {
                СтатусСотрудника res = СтатусСотрудника.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Отсутствует
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусСотрудника Отсутствует
        {
            get
            {
                СтатусСотрудника res = СтатусСотрудника.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// ВОтпуске
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусСотрудника ВОтпуске
        {
            get
            {
                СтатусСотрудника res = СтатусСотрудника.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// На больничном
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусСотрудника НаБольничном
        {
            get
            {
                СтатусСотрудника res = СтатусСотрудника.Новый();
                res.Value = 3;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static СтатусСотрудника Parse(string str)
        {
            СтатусСотрудника res = СтатусСотрудника.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусСотрудника(this as NsgObject);
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
                base.NSGType = typeof(СтатусСотрудника);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусСотрудника Value
            {
                get
                {
                    return (СтатусСотрудника)base.Value;
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
