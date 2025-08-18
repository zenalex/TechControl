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
    
    [NsgTypeName("NsgDataEnum", Guid = "6e3112e7-36f5-48db-89bf-e1702f291cf0")]
    public partial class СтатусыДокументовСмен : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String ПодтвержденоВремяЗакрытия
            {
                NsgDataEnumElement ПодтвержденоВремяЗакрытия = null;
                if (ObjectList.Contains("ПодтвержденоВремяЗакрытия"))
                    ПодтвержденоВремяЗакрытия = ObjectList["ПодтвержденоВремяЗакрытия"] as NsgDataEnumElement;
                else
                    ПодтвержденоВремяЗакрытия = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПодтвержденоВремяЗакрытия.IsLoadedFromDll = true;
	ПодтвержденоВремяЗакрытия.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПодтвержденоВремяЗакрытия.Index = 2;
	ПодтвержденоВремяЗакрытия.StringFormat = "";
	ПодтвержденоВремяЗакрытия.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПодтвержденоВремяЗакрытия.IncludeInPredefined = false;
	ПодтвержденоВремяЗакрытия.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПодтвержденоВремяЗакрытия.Required = false;
	ПодтвержденоВремяЗакрытия.EmptyValue = "";
	ПодтвержденоВремяЗакрытия.NullAllow = false;
	ПодтвержденоВремяЗакрытия.FieldName = "PodtverzhdenoVrem";
	ПодтвержденоВремяЗакрытия.SaveInDatabase = true;
	ПодтвержденоВремяЗакрытия.InformMetaDataOnValueChanged = false;
	ПодтвержденоВремяЗакрытия.Visible = true;
	ПодтвержденоВремяЗакрытия.Name = "ПодтвержденоВремяЗакрытия";
	ПодтвержденоВремяЗакрытия.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПодтвержденоВремяЗакрытия.Description = "Подтверждено время закрытия";
	ПодтвержденоВремяЗакрытия.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ПодтвержденоВремяЗакрытия.GroupName = "";
	ПодтвержденоВремяЗакрытия.Guid = NsgService.StringToGuid("70feaec7-f7cb-4698-b542-ea2df544d9b1");
	
                if (!ObjectList.Contains("ПодтвержденоВремяЗакрытия"))
                    ObjectList.Add(ПодтвержденоВремяЗакрытия);
			}
			#endregion //создание System.String ПодтвержденоВремяЗакрытия
			
            #region создание System.String АвтоматическиЗавершено
            {
                NsgDataEnumElement АвтоматическиЗавершено = null;
                if (ObjectList.Contains("АвтоматическиЗавершено"))
                    АвтоматическиЗавершено = ObjectList["АвтоматическиЗавершено"] as NsgDataEnumElement;
                else
                    АвтоматическиЗавершено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	АвтоматическиЗавершено.IsLoadedFromDll = true;
	АвтоматическиЗавершено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АвтоматическиЗавершено.Index = 1;
	АвтоматическиЗавершено.StringFormat = "";
	АвтоматическиЗавершено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	АвтоматическиЗавершено.IncludeInPredefined = false;
	АвтоматическиЗавершено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АвтоматическиЗавершено.Required = false;
	АвтоматическиЗавершено.EmptyValue = "";
	АвтоматическиЗавершено.NullAllow = false;
	АвтоматическиЗавершено.FieldName = "AvtomaticheskiZav";
	АвтоматическиЗавершено.SaveInDatabase = true;
	АвтоматическиЗавершено.InformMetaDataOnValueChanged = false;
	АвтоматическиЗавершено.Visible = true;
	АвтоматическиЗавершено.Name = "АвтоматическиЗавершено";
	АвтоматическиЗавершено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	АвтоматическиЗавершено.Description = "Автоматически завершено";
	АвтоматическиЗавершено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	АвтоматическиЗавершено.GroupName = "";
	АвтоматическиЗавершено.Guid = NsgService.StringToGuid("b45abe59-9f0d-4d43-bbcf-f2e81f12bf27");
	
                if (!ObjectList.Contains("АвтоматическиЗавершено"))
                    ObjectList.Add(АвтоматическиЗавершено);
			}
			#endregion //создание System.String АвтоматическиЗавершено
			
            #region создание System.String НеОпределено
            {
                NsgDataEnumElement НеОпределено = null;
                if (ObjectList.Contains("НеОпределено"))
                    НеОпределено = ObjectList["НеОпределено"] as NsgDataEnumElement;
                else
                    НеОпределено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	НеОпределено.IsLoadedFromDll = true;
	НеОпределено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НеОпределено.Index = 0;
	НеОпределено.StringFormat = "";
	НеОпределено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НеОпределено.IncludeInPredefined = false;
	НеОпределено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НеОпределено.Required = false;
	НеОпределено.EmptyValue = "";
	НеОпределено.NullAllow = false;
	НеОпределено.FieldName = "NeOpredeleno";
	НеОпределено.SaveInDatabase = true;
	НеОпределено.InformMetaDataOnValueChanged = false;
	НеОпределено.Visible = true;
	НеОпределено.Name = "НеОпределено";
	НеОпределено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НеОпределено.Description = "Не определено";
	НеОпределено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НеОпределено.GroupName = "";
	НеОпределено.Guid = NsgService.StringToGuid("65673d2d-3fe2-43f9-a560-7c4c642912c5");
	
                if (!ObjectList.Contains("НеОпределено"))
                    ObjectList.Add(НеОпределено);
			}
			#endregion //создание System.String НеОпределено
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СтатусыДокументовСмен";
	Visible = true;
	Guid = NsgService.StringToGuid("6e3112e7-36f5-48db-89bf-e1702f291cf0");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_StatusyDokumentovSmen";
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

		public static СтатусыДокументовСмен Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("6e3112e7-36f5-48db-89bf-e1702f291cf0"));
            if (obj == null)
                obj = new СтатусыДокументовСмен();
            return obj as СтатусыДокументовСмен;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СтатусыДокументовСмен()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СтатусыДокументовСмен(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Перечисления.СтатусыДокументовСмен";
        }

        
        /// <summary>
        /// Подтверждено время закрытия
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыДокументовСмен ПодтвержденоВремяЗакрытия
        {
            get
            {
                СтатусыДокументовСмен res = СтатусыДокументовСмен.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Автоматически завершено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыДокументовСмен АвтоматическиЗавершено
        {
            get
            {
                СтатусыДокументовСмен res = СтатусыДокументовСмен.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Не определено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СтатусыДокументовСмен НеОпределено
        {
            get
            {
                СтатусыДокументовСмен res = СтатусыДокументовСмен.Новый();
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
		




        public static СтатусыДокументовСмен Parse(string str)
        {
            СтатусыДокументовСмен res = СтатусыДокументовСмен.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СтатусыДокументовСмен(this as NsgObject);
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
                base.NSGType = typeof(СтатусыДокументовСмен);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СтатусыДокументовСмен Value
            {
                get
                {
                    return (СтатусыДокументовСмен)base.Value;
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
