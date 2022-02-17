using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace TT.Метаданные
{
    public partial class Метаданные : NsgSoft.DataObjects.NsgMetaData
    {
        #region Данные
        #endregion //Данные

        #region Инициализация


        public static Метаданные Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("2dbd2646-52ef-4d89-8d8e-ef1f94e39426"));
            if (obj == null)
                obj = new Метаданные();
            return obj as Метаданные;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void InitObjectList()
        {
            ObjectList.AddRange( new NsgMultipleObject[] {TT.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 TT.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 TT.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 TT.Метаданные.Сервис.ТипыОбмена.Новый(),
	 TT.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 TT.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 TT.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 TT.Метаданные.Сервис.ОбменДанными.Новый(),
	 TT.Метаданные.Сервис.ИмпортДанных.Новый(),
	 TT.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 TT.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 TT.Метаданные.Сервис.ВидыДвижений.Новый(),
	 TT.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 TT.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 TT.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 TT.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 TT.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 TT.Метаданные._SystemTables.PeriodicTable.Новый(),
	 TT.Метаданные.Мониторинг.ТипТС.Новый(),
	 TT.Метаданные.Мониторинг.Марка.Новый(),
	 TT.Метаданные.Мониторинг.РегистрМониторингТехники.Новый(),
	 TT.Метаданные._SystemTables.МониторингРегистрМониторингТехникиДвижения.Новый(),
	 TT.Метаданные.Мониторинг.Техника.Новый(),
	 TT.Метаданные.Мониторинг.Модель.Новый(),
	 TT.Метаданные.Мониторинг.СистемаМониторинга.Новый()});
        }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            	//NsgMetaData
	IsLoadedFromDll = true;
	Guid = NsgService.StringToGuid("2dbd2646-52ef-4d89-8d8e-ef1f94e39426");
	PeriodicTable = "_SystemTables.PeriodicTable";
	SystemGroup = "_SystemTables";
	Version = "2022.2.17.0";
	ContainsUserInformation = false;
	UserActionsRegisteration = false;
	UseUserMenu = false;
	Groups = new System.String[]{"Сервис", "Мониторинг"};
	Name = "Метаданные";
	
            AfterLoad();
        }

        #endregion //Инициализация

        #region Свойства
        #endregion //Свойства

        #region Методы
        /// <summary>
        /// Идентификатор текущего уровня метаданных
        /// </summary>
        private string ID
        {
            get
            {
                return "TT";
            }
        }
        #endregion //Методы
    }
}
