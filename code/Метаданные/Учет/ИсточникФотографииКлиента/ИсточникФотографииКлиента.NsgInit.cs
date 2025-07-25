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
    
    [NsgTypeName("NsgDataEnum", Guid = "39081bad-f4c4-4779-992d-a5816eb4b3f9")]
    public partial class ИсточникФотографииКлиента : NsgSoft.DataObjects.NsgDataEnum
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
	Неизвестно.Guid = NsgService.StringToGuid("9e968e2f-da86-4913-a22e-8c7a903c201b");
	
                if (!ObjectList.Contains("Неизвестно"))
                    ObjectList.Add(Неизвестно);
			}
			#endregion //создание System.String Неизвестно
			
            #region создание System.String Галерея
            {
                NsgDataEnumElement Галерея = null;
                if (ObjectList.Contains("Галерея"))
                    Галерея = ObjectList["Галерея"] as NsgDataEnumElement;
                else
                    Галерея = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Галерея.IsLoadedFromDll = true;
	Галерея.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Галерея.Index = 1;
	Галерея.StringFormat = "";
	Галерея.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Галерея.IncludeInPredefined = false;
	Галерея.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Галерея.Required = false;
	Галерея.EmptyValue = "";
	Галерея.NullAllow = false;
	Галерея.FieldName = "Galereja";
	Галерея.SaveInDatabase = true;
	Галерея.InformMetaDataOnValueChanged = false;
	Галерея.Visible = true;
	Галерея.Name = "Галерея";
	Галерея.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Галерея.Description = "Галерея";
	Галерея.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Галерея.GroupName = "";
	Галерея.Guid = NsgService.StringToGuid("511a58ad-697e-4c6a-93c9-8af8936c1c01");
	
                if (!ObjectList.Contains("Галерея"))
                    ObjectList.Add(Галерея);
			}
			#endregion //создание System.String Галерея
			
            #region создание System.String Камера
            {
                NsgDataEnumElement Камера = null;
                if (ObjectList.Contains("Камера"))
                    Камера = ObjectList["Камера"] as NsgDataEnumElement;
                else
                    Камера = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Камера.IsLoadedFromDll = true;
	Камера.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Камера.Index = 2;
	Камера.StringFormat = "";
	Камера.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Камера.IncludeInPredefined = false;
	Камера.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Камера.Required = false;
	Камера.EmptyValue = "";
	Камера.NullAllow = false;
	Камера.FieldName = "Kamera";
	Камера.SaveInDatabase = true;
	Камера.InformMetaDataOnValueChanged = false;
	Камера.Visible = true;
	Камера.Name = "Камера";
	Камера.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Камера.Description = "Камера";
	Камера.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Камера.GroupName = "";
	Камера.Guid = NsgService.StringToGuid("c356a670-611d-4fb4-ab7c-3c8a758450ea");
	
                if (!ObjectList.Contains("Камера"))
                    ObjectList.Add(Камера);
			}
			#endregion //создание System.String Камера
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ИсточникФотографииКлиента";
	Visible = true;
	Guid = NsgService.StringToGuid("39081bad-f4c4-4779-992d-a5816eb4b3f9");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_enum_IstochnikFotografi";
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

		public static ИсточникФотографииКлиента Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("39081bad-f4c4-4779-992d-a5816eb4b3f9"));
            if (obj == null)
                obj = new ИсточникФотографииКлиента();
            return obj as ИсточникФотографииКлиента;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ИсточникФотографииКлиента()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ИсточникФотографииКлиента(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Учет.ИсточникФотографииКлиента";
        }

        
        /// <summary>
        /// Неизвестно
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ИсточникФотографииКлиента Неизвестно
        {
            get
            {
                ИсточникФотографииКлиента res = ИсточникФотографииКлиента.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Галерея
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ИсточникФотографииКлиента Галерея
        {
            get
            {
                ИсточникФотографииКлиента res = ИсточникФотографииКлиента.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Камера
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ИсточникФотографииКлиента Камера
        {
            get
            {
                ИсточникФотографииКлиента res = ИсточникФотографииКлиента.Новый();
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
		




        public static ИсточникФотографииКлиента Parse(string str)
        {
            ИсточникФотографииКлиента res = ИсточникФотографииКлиента.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ИсточникФотографииКлиента(this as NsgObject);
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
                base.NSGType = typeof(ИсточникФотографииКлиента);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ИсточникФотографииКлиента Value
            {
                get
                {
                    return (ИсточникФотографииКлиента)base.Value;
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
