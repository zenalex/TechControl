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
    
    [NsgTypeName("NsgDataEnum", Guid = "80f700cc-034d-4349-a7aa-ab9f1381aa2c")]
    public partial class СтатусТехники : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String ВРемонте
            {
                NsgDataEnumElement ВРемонте = null;
                if (ObjectList.Contains("ВРемонте"))
                    ВРемонте = ObjectList["ВРемонте"] as NsgDataEnumElement;
                else
                    ВРемонте = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ВРемонте.IsLoadedFromDll = true;
	ВРемонте.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВРемонте.Index = 2;
	ВРемонте.StringFormat = "";
	ВРемонте.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВРемонте.IncludeInPredefined = false;
	ВРемонте.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВРемонте.Required = false;
	ВРемонте.EmptyValue = "";
	ВРемонте.NullAllow = false;
	ВРемонте.FieldName = "VRemonte";
	ВРемонте.SaveInDatabase = true;
	ВРемонте.InformMetaDataOnValueChanged = false;
	ВРемонте.Visible = true;
	ВРемонте.Name = "ВРемонте";
	ВРемонте.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВРемонте.Description = "ВРемонте";
	ВРемонте.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВРемонте.GroupName = "";
	ВРемонте.Guid = NsgService.StringToGuid("88d30c54-204c-4434-b65b-6455109952d5");
	
                if (!ObjectList.Contains("ВРемонте"))
                    ObjectList.Add(ВРемонте);
			}
			#endregion //создание System.String ВРемонте
			
            #region создание System.String Сломан
            {
                NsgDataEnumElement Сломан = null;
                if (ObjectList.Contains("Сломан"))
                    Сломан = ObjectList["Сломан"] as NsgDataEnumElement;
                else
                    Сломан = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Сломан.IsLoadedFromDll = true;
	Сломан.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сломан.Index = 3;
	Сломан.StringFormat = "";
	Сломан.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сломан.IncludeInPredefined = false;
	Сломан.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сломан.Required = false;
	Сломан.EmptyValue = "";
	Сломан.NullAllow = false;
	Сломан.FieldName = "Sloman";
	Сломан.SaveInDatabase = true;
	Сломан.InformMetaDataOnValueChanged = false;
	Сломан.Visible = true;
	Сломан.Name = "Сломан";
	Сломан.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сломан.Description = "Сломан";
	Сломан.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сломан.GroupName = "";
	Сломан.Guid = NsgService.StringToGuid("f7183e98-1983-4d30-ae72-8c4414837066");
	
                if (!ObjectList.Contains("Сломан"))
                    ObjectList.Add(Сломан);
			}
			#endregion //создание System.String Сломан
			
            #region создание System.String ВРаботе
            {
                NsgDataEnumElement ВРаботе = null;
                if (ObjectList.Contains("ВРаботе"))
                    ВРаботе = ObjectList["ВРаботе"] as NsgDataEnumElement;
                else
                    ВРаботе = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ВРаботе.IsLoadedFromDll = true;
	ВРаботе.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВРаботе.Index = 1;
	ВРаботе.StringFormat = "";
	ВРаботе.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ВРаботе.IncludeInPredefined = false;
	ВРаботе.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВРаботе.Required = false;
	ВРаботе.EmptyValue = "";
	ВРаботе.NullAllow = false;
	ВРаботе.FieldName = "VRabote";
	ВРаботе.SaveInDatabase = true;
	ВРаботе.InformMetaDataOnValueChanged = false;
	ВРаботе.Visible = true;
	ВРаботе.Name = "ВРаботе";
	ВРаботе.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВРаботе.Description = "ВРаботе";
	ВРаботе.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВРаботе.GroupName = "";
	ВРаботе.Guid = NsgService.StringToGuid("5e98bf7e-28a9-423e-888d-5c130bffd9c4");
	
                if (!ObjectList.Contains("ВРаботе"))
                    ObjectList.Add(ВРаботе);
			}
			#endregion //создание System.String ВРаботе
			
            #region создание System.String НеРаботает
            {
                NsgDataEnumElement НеРаботает = null;
                if (ObjectList.Contains("НеРаботает"))
                    НеРаботает = ObjectList["НеРаботает"] as NsgDataEnumElement;
                else
                    НеРаботает = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НеРаботает.IsLoadedFromDll = true;
	НеРаботает.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НеРаботает.Index = 4;
	НеРаботает.StringFormat = "";
	НеРаботает.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НеРаботает.IncludeInPredefined = false;
	НеРаботает.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НеРаботает.Required = false;
	НеРаботает.EmptyValue = "";
	НеРаботает.NullAllow = false;
	НеРаботает.FieldName = "NeRabotaet";
	НеРаботает.SaveInDatabase = true;
	НеРаботает.InformMetaDataOnValueChanged = false;
	НеРаботает.Visible = true;
	НеРаботает.Name = "НеРаботает";
	НеРаботает.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НеРаботает.Description = "Не работает";
	НеРаботает.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НеРаботает.GroupName = "";
	НеРаботает.Guid = NsgService.StringToGuid("adf6aed9-8414-4d78-bf77-7d149e70abdd");
	
                if (!ObjectList.Contains("НеРаботает"))
                    ObjectList.Add(НеРаботает);
			}
			#endregion //создание System.String НеРаботает
			
            #region создание System.String НетДанных
            {
                NsgDataEnumElement НетДанных = null;
                if (ObjectList.Contains("НетДанных"))
                    НетДанных = ObjectList["НетДанных"] as NsgDataEnumElement;
                else
                    НетДанных = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НетДанных.IsLoadedFromDll = true;
	НетДанных.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НетДанных.Index = 0;
	НетДанных.StringFormat = "";
	НетДанных.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НетДанных.IncludeInPredefined = false;
	НетДанных.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НетДанных.Required = false;
	НетДанных.EmptyValue = "";
	НетДанных.NullAllow = false;
	НетДанных.FieldName = "NetDannykh";
	НетДанных.SaveInDatabase = true;
	НетДанных.InformMetaDataOnValueChanged = false;
	НетДанных.Visible = true;
	НетДанных.Name = "НетДанных";
	НетДанных.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НетДанных.Description = "Нет данных";
	НетДанных.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НетДанных.GroupName = "";
	НетДанных.Guid = NsgService.StringToGuid("8b3326db-ccd7-44c9-bfe3-59d16de26b90");
	
                if (!ObjectList.Contains("НетДанных"))
                    ObjectList.Add(НетДанных);
			}
			#endregion //создание System.String НетДанных
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусТехники";
	Visible = true;
	Guid = NsgService.StringToGuid("80f700cc-034d-4349-a7aa-ab9f1381aa2c");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusTekhniki";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Статус техники";
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

		public static СтатусТехники Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("80f700cc-034d-4349-a7aa-ab9f1381aa2c"));
            if (obj == null)
                obj = new СтатусТехники();
            return obj as СтатусТехники;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусТехники()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусТехники(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Мониторинг.СтатусТехники";
        }

        
        /// <summary>
        /// ВРемонте
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусТехники ВРемонте
        {
            get
            {
                СтатусТехники res = СтатусТехники.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Сломан
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусТехники Сломан
        {
            get
            {
                СтатусТехники res = СтатусТехники.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// ВРаботе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусТехники ВРаботе
        {
            get
            {
                СтатусТехники res = СтатусТехники.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Не работает
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусТехники НеРаботает
        {
            get
            {
                СтатусТехники res = СтатусТехники.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Нет данных
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусТехники НетДанных
        {
            get
            {
                СтатусТехники res = СтатусТехники.Новый();
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
		




        public static СтатусТехники Parse(string str)
        {
            СтатусТехники res = СтатусТехники.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусТехники(this as NsgObject);
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
                base.NSGType = typeof(СтатусТехники);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусТехники Value
            {
                get
                {
                    return (СтатусТехники)base.Value;
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
