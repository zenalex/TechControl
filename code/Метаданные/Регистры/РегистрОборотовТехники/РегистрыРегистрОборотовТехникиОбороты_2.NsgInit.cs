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
    
    [NsgTypeName("NsgDataTable", Guid = "66295f57-a574-4e9a-aa9a-fdfa09aa0732")]
    public partial class РегистрыРегистрОборотовТехникиОбороты_2 : NsgSoft.DataObjects.NsgDataTable
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
        protected РегистрыРегистрОборотовТехникиОбороты_2()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected РегистрыРегистрОборотовТехникиОбороты_2(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static РегистрыРегистрОборотовТехникиОбороты_2 Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("66295f57-a574-4e9a-aa9a-fdfa09aa0732"));
            if (obj == null)
                obj = new РегистрыРегистрОборотовТехникиОбороты_2();
            return obj as РегистрыРегистрОборотовТехникиОбороты_2;
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
			
			#region создание System.Int64 КоличествоМашин
			{  
                NsgDataInteger КоличествоМашин = null;
				if (ObjectList.Contains("КоличествоМашин"))
                    КоличествоМашин = ObjectList["КоличествоМашин"] as NsgDataInteger;
                else
                    КоличествоМашин = new NsgDataInteger();
	//NsgDataInteger
	КоличествоМашин.IsLoadedFromDll = true;
	КоличествоМашин.DefaultValue = 0M;
	КоличествоМашин.MinValue = -10000000000000000000M;
	КоличествоМашин.MaxValue = 10000000000000000000M;
	КоличествоМашин.UseCalculator = true;
	КоличествоМашин.StringFormat = "";
	КоличествоМашин.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	КоличествоМашин.IncludeInPredefined = false;
	КоличествоМашин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КоличествоМашин.Required = false;
	КоличествоМашин.EmptyValue = "";
	КоличествоМашин.NullAllow = false;
	КоличествоМашин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КоличествоМашин.FieldName = "KolichestvoMashin";
	КоличествоМашин.InformMetaDataOnValueChanged = false;
	КоличествоМашин.Visible = true;
	КоличествоМашин.Name = "КоличествоМашин";
	КоличествоМашин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КоличествоМашин.Description = "Количество машин";
	КоличествоМашин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	КоличествоМашин.GroupName = "";
	КоличествоМашин.Guid = NsgService.StringToGuid("7a219525-963f-4f77-8bef-f9a9ddd15fbc");
	
				if (!ObjectList.Contains("КоличествоМашин"))
                    ObjectList.Add(КоличествоМашин);
			}
			#endregion //создание System.Int64 КоличествоМашин
			
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
	Автоинкремент.Guid = NsgService.StringToGuid("8c1ab21c-1f74-436b-bd30-875f33862587");
	
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
	ЗаявкаНаТехнику.Guid = NsgService.StringToGuid("6341052f-2b1c-4fcb-91f9-77120ca4e852");
	
				if (!ObjectList.Contains("ЗаявкаНаТехнику"))
                    ObjectList.Add(ЗаявкаНаТехнику);
			}
			#endregion //создание Документы.ЗаявкиНаТехнику ЗаявкаНаТехнику
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("00ab50e9-f5b0-4f0b-9f8c-e2d176b1133e");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Регистры.РегистрОборотовТехники";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.Month;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCirculatTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "РегистрыРегистрОборотовТехникиОбороты_2";
	Visible = true;
	Guid = NsgService.StringToGuid("66295f57-a574-4e9a-aa9a-fdfa09aa0732");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_RegistryRegistrObor3";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистры регистр оборотов техники обороты_2";
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
            /// Количество машин
            /// </summary>
            public static String КоличествоМашин
            {
                get
                {
                    return "КоличествоМашин";
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
            
            /// <summary>
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
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
                    descriptor.Name = "РегистрыРегистрОборотовТехникиОбороты_2";
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
            return "_SystemTables.РегистрыРегистрОборотовТехникиОбороты_2";
        }

        
        /// <summary>
        /// Количество машин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 КоличествоМашин
        {
            get
            {
				 NsgDataInteger __КоличествоМашин = ObjectList["КоличествоМашин"] as NsgDataInteger;
                 return (System.Int64)__КоличествоМашин.Value;
            }
            set
            {
                NsgDataInteger __КоличествоМашин = ObjectList["КоличествоМашин"] as NsgDataInteger;
                __КоличествоМашин.Value = value;
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
        
        /// <summary>
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
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
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка NewRow()
        {
            return newRow(null) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new РегистрыРегистрОборотовТехникиОбороты_2.Строка(this);
            return base.newRow(row) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public РегистрыРегистрОборотовТехникиОбороты_2.Строка NewRow(РегистрыРегистрОборотовТехникиОбороты_2.Строка inRow)
        {
            РегистрыРегистрОборотовТехникиОбороты_2.Строка row = inRow.Clone as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
            return base.newRow(row) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка GetEtalonRow()
        {
            РегистрыРегистрОборотовТехникиОбороты_2.Строка row = new РегистрыРегистрОборотовТехникиОбороты_2.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private РегистрыРегистрОборотовТехникиОбороты_2.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            РегистрыРегистрОборотовТехникиОбороты_2.Строка[] res = new РегистрыРегистрОборотовТехникиОбороты_2.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<РегистрыРегистрОборотовТехникиОбороты_2> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<РегистрыРегистрОборотовТехникиОбороты_2>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка[] AllRows
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
        public new РегистрыРегистрОборотовТехникиОбороты_2.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as РегистрыРегистрОборотовТехникиОбороты_2.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private РегистрыРегистрОборотовТехникиОбороты_2[] convertArray(NsgMultipleObject[] array)
        {
            РегистрыРегистрОборотовТехникиОбороты_2[] res = new РегистрыРегистрОборотовТехникиОбороты_2[array.Length];
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
        public new virtual РегистрыРегистрОборотовТехникиОбороты_2[] FindAll(NsgCompare compare)
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
        public new virtual РегистрыРегистрОборотовТехникиОбороты_2[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual РегистрыРегистрОборотовТехникиОбороты_2[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual РегистрыРегистрОборотовТехникиОбороты_2[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new РегистрыРегистрОборотовТехникиОбороты_2(this as NsgObject);
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
                base.NSGType = typeof(РегистрыРегистрОборотовТехникиОбороты_2);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new РегистрыРегистрОборотовТехникиОбороты_2 Value
            {
                get
                {
                    return (РегистрыРегистрОборотовТехникиОбороты_2)base.Value;
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
