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

namespace TechControl.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataEnum", Guid = "dfe82d7d-892a-4ebd-8f24-ce146d2911a8")]
    public partial class ТипЗадачиНаСервере : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Провести
            {
                NsgDataEnumElement Провести = null;
                if (ObjectList.Contains("Провести"))
                    Провести = ObjectList["Провести"] as NsgDataEnumElement;
                else
                    Провести = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Провести.IsLoadedFromDll = true;
	Провести.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Провести.Index = 0;
	Провести.StringFormat = "";
	Провести.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Провести.IncludeInPredefined = false;
	Провести.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Провести.Required = false;
	Провести.EmptyValue = "";
	Провести.NullAllow = false;
	Провести.FieldName = "_Handle";
	Провести.SaveInDatabase = true;
	Провести.InformMetaDataOnValueChanged = false;
	Провести.Visible = true;
	Провести.Name = "Провести";
	Провести.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Провести"});
	Провести.Description = "Провести";
	Провести.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Провести.GroupName = "";
	Провести.Guid = NsgService.StringToGuid("87ce31fe-abab-4eac-b17a-8c7770f1ff28");
	
                if (!ObjectList.Contains("Провести"))
                    ObjectList.Add(Провести);
			}
			#endregion //создание System.String Провести
			
            #region создание System.String ОтменитьПроведение
            {
                NsgDataEnumElement ОтменитьПроведение = null;
                if (ObjectList.Contains("ОтменитьПроведение"))
                    ОтменитьПроведение = ObjectList["ОтменитьПроведение"] as NsgDataEnumElement;
                else
                    ОтменитьПроведение = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ОтменитьПроведение.IsLoadedFromDll = true;
	ОтменитьПроведение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОтменитьПроведение.Index = 1;
	ОтменитьПроведение.StringFormat = "";
	ОтменитьПроведение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОтменитьПроведение.IncludeInPredefined = false;
	ОтменитьПроведение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОтменитьПроведение.Required = false;
	ОтменитьПроведение.EmptyValue = "";
	ОтменитьПроведение.NullAllow = false;
	ОтменитьПроведение.FieldName = "_UnHandle";
	ОтменитьПроведение.SaveInDatabase = true;
	ОтменитьПроведение.InformMetaDataOnValueChanged = false;
	ОтменитьПроведение.Visible = true;
	ОтменитьПроведение.Name = "ОтменитьПроведение";
	ОтменитьПроведение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Отменить проведение"});
	ОтменитьПроведение.Description = "Отменить проведение";
	ОтменитьПроведение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ОтменитьПроведение.GroupName = "";
	ОтменитьПроведение.Guid = NsgService.StringToGuid("594df1ff-be80-4c12-892e-f8df1c6455c5");
	
                if (!ObjectList.Contains("ОтменитьПроведение"))
                    ObjectList.Add(ОтменитьПроведение);
			}
			#endregion //создание System.String ОтменитьПроведение
			
            #region создание System.String ПометитьНаУдаление
            {
                NsgDataEnumElement ПометитьНаУдаление = null;
                if (ObjectList.Contains("ПометитьНаУдаление"))
                    ПометитьНаУдаление = ObjectList["ПометитьНаУдаление"] as NsgDataEnumElement;
                else
                    ПометитьНаУдаление = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПометитьНаУдаление.IsLoadedFromDll = true;
	ПометитьНаУдаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПометитьНаУдаление.Index = 2;
	ПометитьНаУдаление.StringFormat = "";
	ПометитьНаУдаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПометитьНаУдаление.IncludeInPredefined = false;
	ПометитьНаУдаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПометитьНаУдаление.Required = false;
	ПометитьНаУдаление.EmptyValue = "";
	ПометитьНаУдаление.NullAllow = false;
	ПометитьНаУдаление.FieldName = "_SetDeleteMark";
	ПометитьНаУдаление.SaveInDatabase = true;
	ПометитьНаУдаление.InformMetaDataOnValueChanged = false;
	ПометитьНаУдаление.Visible = true;
	ПометитьНаУдаление.Name = "ПометитьНаУдаление";
	ПометитьНаУдаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пометить на удаление"});
	ПометитьНаУдаление.Description = "Пометить на удаление";
	ПометитьНаУдаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПометитьНаУдаление.GroupName = "";
	ПометитьНаУдаление.Guid = NsgService.StringToGuid("319328f2-f91c-4efe-97c8-330ee4f8fc2b");
	
                if (!ObjectList.Contains("ПометитьНаУдаление"))
                    ObjectList.Add(ПометитьНаУдаление);
			}
			#endregion //создание System.String ПометитьНаУдаление
			
            #region создание System.String Нет
            {
                NsgDataEnumElement Нет = null;
                if (ObjectList.Contains("Нет"))
                    Нет = ObjectList["Нет"] as NsgDataEnumElement;
                else
                    Нет = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Нет.IsLoadedFromDll = true;
	Нет.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Нет.Index = 3;
	Нет.StringFormat = "";
	Нет.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Нет.IncludeInPredefined = false;
	Нет.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Нет.Required = false;
	Нет.EmptyValue = "";
	Нет.NullAllow = false;
	Нет.FieldName = "_None";
	Нет.SaveInDatabase = true;
	Нет.InformMetaDataOnValueChanged = false;
	Нет.Visible = true;
	Нет.Name = "Нет";
	Нет.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Нет"});
	Нет.Description = "Нет";
	Нет.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Нет.GroupName = "";
	Нет.Guid = NsgService.StringToGuid("9ebd1262-d246-409d-b514-72c36b2ab6a5");
	
                if (!ObjectList.Contains("Нет"))
                    ObjectList.Add(Нет);
			}
			#endregion //создание System.String Нет
			
            #region создание System.String Печать
            {
                NsgDataEnumElement Печать = null;
                if (ObjectList.Contains("Печать"))
                    Печать = ObjectList["Печать"] as NsgDataEnumElement;
                else
                    Печать = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Печать.IsLoadedFromDll = true;
	Печать.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Печать.Index = 4;
	Печать.StringFormat = "";
	Печать.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Печать.IncludeInPredefined = false;
	Печать.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Печать.Required = false;
	Печать.EmptyValue = "";
	Печать.NullAllow = false;
	Печать.FieldName = "_Print";
	Печать.SaveInDatabase = true;
	Печать.InformMetaDataOnValueChanged = false;
	Печать.Visible = true;
	Печать.Name = "Печать";
	Печать.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Печать"});
	Печать.Description = "Печать";
	Печать.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Печать.GroupName = "";
	Печать.Guid = NsgService.StringToGuid("b772b939-c031-453e-88fb-8d84bfa47b06");
	
                if (!ObjectList.Contains("Печать"))
                    ObjectList.Add(Печать);
			}
			#endregion //создание System.String Печать
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипЗадачиНаСервере";
	Visible = true;
	Guid = NsgService.StringToGuid("dfe82d7d-892a-4ebd-8f24-ce146d2911a8");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "ServerJobAction";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"ТипЗадачиНаСервере"});
	Description = "ТипЗадачиНаСервере";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static ТипЗадачиНаСервере Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("dfe82d7d-892a-4ebd-8f24-ce146d2911a8"));
            if (obj == null)
                obj = new ТипЗадачиНаСервере();
            return obj as ТипЗадачиНаСервере;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипЗадачиНаСервере()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипЗадачиНаСервере(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.ТипЗадачиНаСервере";
        }

        
        /// <summary>
        /// Провести
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Провести
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Отменить проведение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере ОтменитьПроведение
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Пометить на удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере ПометитьНаУдаление
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Нет
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Нет
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Печать
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Печать
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 4;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ТипЗадачиНаСервере Parse(string str)
        {
            ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипЗадачиНаСервере(this as NsgObject);
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
                base.NSGType = typeof(ТипЗадачиНаСервере);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипЗадачиНаСервере Value
            {
                get
                {
                    return (ТипЗадачиНаСервере)base.Value;
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
