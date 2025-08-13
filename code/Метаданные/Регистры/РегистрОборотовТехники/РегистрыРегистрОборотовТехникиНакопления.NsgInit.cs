using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace TechControl.Метаданные._SystemTables
{
    
    [NsgTypeName("NsgDataTable", Guid = "723cdc0a-d35a-433f-9c6a-c5defe68d820")]
    public partial class РегистрыРегистрОборотовТехникиНакопления : NsgSoft.DataObjects.NsgDataTable
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTable

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTable

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected РегистрыРегистрОборотовТехникиНакопления()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрыРегистрОборотовТехникиНакопления(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрыРегистрОборотовТехникиНакопления Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("723cdc0a-d35a-433f-9c6a-c5defe68d820"));
            if (obj == null)
                obj = new РегистрыРегистрОборотовТехникиНакопления();
            return obj as РегистрыРегистрОборотовТехникиНакопления;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTable
			
			#region создание System.Int64 КоличествоХодок
			{  
                NsgDataInteger КоличествоХодок = null;
				if (ObjectList.Contains("КоличествоХодок"))
                    КоличествоХодок = ObjectList["КоличествоХодок"] as NsgDataInteger;
                else
                    КоличествоХодок = new NsgDataInteger();
	//NsgDataInteger
	КоличествоХодок.IsLoadedFromDll = true;
	КоличествоХодок.DefaultValue = 0M;
	КоличествоХодок.MinValue = -10000000000000000000M;
	КоличествоХодок.MaxValue = 10000000000000000000M;
	КоличествоХодок.UseCalculator = true;
	КоличествоХодок.StringFormat = "";
	КоличествоХодок.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	КоличествоХодок.IncludeInPredefined = false;
	КоличествоХодок.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоХодок.Required = false;
	КоличествоХодок.EmptyValue = "";
	КоличествоХодок.NullAllow = false;
	КоличествоХодок.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоХодок.FieldName = "KolichestvoKHodok";
	КоличествоХодок.InformMetaDataOnValueChanged = false;
	КоличествоХодок.Visible = true;
	КоличествоХодок.Name = "КоличествоХодок";
	КоличествоХодок.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоХодок.Description = "Количество ходок";
	КоличествоХодок.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоХодок.GroupName = "";
	КоличествоХодок.Guid = NsgService.StringToGuid("7e7eba66-13fb-4d8e-8d43-a4facaf2e496");
	
				if (!ObjectList.Contains("КоличествоХодок"))
                    ObjectList.Add(КоличествоХодок);
			}
			#endregion //создание System.Int64 КоличествоХодок
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("674a6be2-52eb-4796-9cfb-e624718d7af8");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание Документы.ЗаявкиНаТехнику ЗаявкаНаТехнику
			{  
                NsgDataTypedReference ЗаявкаНаТехнику = null;
				if (ObjectList.Contains("ЗаявкаНаТехнику"))
                    ЗаявкаНаТехнику = ObjectList["ЗаявкаНаТехнику"] as NsgDataTypedReference;
                else
                    ЗаявкаНаТехнику = new NsgDataTypedReference();
	//NsgDataTypedReference
	ЗаявкаНаТехнику.IsLoadedFromDll = true;
	ЗаявкаНаТехнику.ReferentGroup = "Документы";
	ЗаявкаНаТехнику.ReferentName = "ЗаявкиНаТехнику";
	ЗаявкаНаТехнику.SaveInDatabase = true;
	ЗаявкаНаТехнику.OwnerName = "";
	ЗаявкаНаТехнику.AllowEmptyOwner = false;
	ЗаявкаНаТехнику.StringFormat = "";
	ЗаявкаНаТехнику.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ЗаявкаНаТехнику.IncludeInPredefined = false;
	ЗаявкаНаТехнику.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЗаявкаНаТехнику.Required = false;
	ЗаявкаНаТехнику.EmptyValue = "";
	ЗаявкаНаТехнику.NullAllow = false;
	ЗаявкаНаТехнику.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ЗаявкаНаТехнику.FieldName = "ZajavkaNaTekhniku";
	ЗаявкаНаТехнику.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	ЗаявкаНаТехнику.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	ЗаявкаНаТехнику.CharactericticWeight = 1;
	ЗаявкаНаТехнику.InformMetaDataOnValueChanged = false;
	ЗаявкаНаТехнику.Visible = true;
	ЗаявкаНаТехнику.Name = "ЗаявкаНаТехнику";
	ЗаявкаНаТехнику.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЗаявкаНаТехнику.Description = "Заявка на технику";
	ЗаявкаНаТехнику.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ЗаявкаНаТехнику.GroupName = "";
	ЗаявкаНаТехнику.Guid = NsgService.StringToGuid("32c31b3e-c243-42ff-bd64-0f1a2e5930c8");
	
				if (!ObjectList.Contains("ЗаявкаНаТехнику"))
                    ObjectList.Add(ЗаявкаНаТехнику);
			}
			#endregion //создание Документы.ЗаявкиНаТехнику ЗаявкаНаТехнику
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Регистры.РегистрОборотовТехники";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterAccumTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "РегистрыРегистрОборотовТехникиНакопления";
	Visible = true;
	Guid = NsgService.StringToGuid("723cdc0a-d35a-433f-9c6a-c5defe68d820");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_RegistryRegistrObor1";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистры регистр оборотов техники накопления";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "_SystemTables";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTable

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTable.Names
        {
            
            /// <summary>
            /// Количество ходок
            /// </summary>
            public static String КоличествоХодок
            {
                get
                {
                    return "КоличествоХодок";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Заявка на технику
            /// </summary>
            public static String ЗаявкаНаТехнику
            {
                get
                {
                    return "ЗаявкаНаТехнику";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "РегистрыРегистрОборотовТехникиНакопления";
                    descriptor.GroupName = "_SystemTables";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "_SystemTables.РегистрыРегистрОборотовТехникиНакопления";
        }

        
        /// <summary>
        /// Количество ходок
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоХодок
        {
            get
            {
				 NsgDataInteger __КоличествоХодок = ObjectList["КоличествоХодок"] as NsgDataInteger;
                 return (System.Int64)__КоличествоХодок.Value;
            }
            set
            {
                NsgDataInteger __КоличествоХодок = ObjectList["КоличествоХодок"] as NsgDataInteger;
                __КоличествоХодок.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Заявка на технику
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDocument")]
        
        public Документы.ЗаявкиНаТехнику ЗаявкаНаТехнику
        {
            get
            {
				 NsgDataTypedReference __ЗаявкаНаТехнику = ObjectList["ЗаявкаНаТехнику"] as NsgDataTypedReference;
                 return (Документы.ЗаявкиНаТехнику)__ЗаявкаНаТехнику.Referent;
            }
            set
            {
                NsgDataTypedReference __ЗаявкаНаТехнику = ObjectList["ЗаявкаНаТехнику"] as NsgDataTypedReference;
                __ЗаявкаНаТехнику.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка NewRow()
        {
            return newRow(null) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new РегистрыРегистрОборотовТехникиНакопления.Строка(this);
            return base.newRow(row) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public РегистрыРегистрОборотовТехникиНакопления.Строка NewRow(РегистрыРегистрОборотовТехникиНакопления.Строка inRow)
        {
            РегистрыРегистрОборотовТехникиНакопления.Строка row = inRow.Clone as РегистрыРегистрОборотовТехникиНакопления.Строка;
            return base.newRow(row) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка GetEtalonRow()
        {
            РегистрыРегистрОборотовТехникиНакопления.Строка row = new РегистрыРегистрОборотовТехникиНакопления.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private РегистрыРегистрОборотовТехникиНакопления.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            РегистрыРегистрОборотовТехникиНакопления.Строка[] res = new РегистрыРегистрОборотовТехникиНакопления.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<РегистрыРегистрОборотовТехникиНакопления> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<РегистрыРегистрОборотовТехникиНакопления>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка[] AllRows
        {
            get
            {
                return convertRowsArray(base.AllRows);
            }
        }

        /// <summary>
        /// Получить строку таблицы
        /// </summary>
        /// <param name="inName">Идентификатор строки.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиНакопления.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as РегистрыРегистрОборотовТехникиНакопления.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private РегистрыРегистрОборотовТехникиНакопления[] convertArray(NsgMultipleObject[] array)
        {
            РегистрыРегистрОборотовТехникиНакопления[] res = new РегистрыРегистрОборотовТехникиНакопления[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual РегистрыРегистрОборотовТехникиНакопления[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual РегистрыРегистрОборотовТехникиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual РегистрыРегистрОборотовТехникиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual РегистрыРегистрОборотовТехникиНакопления[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрыРегистрОборотовТехникиНакопления(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(РегистрыРегистрОборотовТехникиНакопления);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрыРегистрОборотовТехникиНакопления Value
            {
                get
                {
                    return (РегистрыРегистрОборотовТехникиНакопления)base.Value;
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
                    return "s_NsgDataTable";
                }
            }
        }

    }

}
