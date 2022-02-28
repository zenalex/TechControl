using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace TechControl.Метаданные
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
            ObjectList.AddRange( new NsgMultipleObject[] {TechControl.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 TechControl.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ТипыОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 TechControl.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 TechControl.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 TechControl.Метаданные.Сервис.ОбменДанными.Новый(),
	 TechControl.Метаданные.Сервис.ИмпортДанных.Новый(),
	 TechControl.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 TechControl.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 TechControl.Метаданные.Сервис.ВидыДвижений.Новый(),
	 TechControl.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 TechControl.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 TechControl.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 TechControl.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 TechControl.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 TechControl.Метаданные._SystemTables.PeriodicTable.Новый(),
	 TechControl.Метаданные.Мониторинг.ТипТС.Новый(),
	 TechControl.Метаданные.Мониторинг.Марка.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрМониторингТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрМониторингТехникиДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.Техника.Новый(),
	 TechControl.Метаданные.Мониторинг.Модель.Новый(),
	 TechControl.Метаданные.Мониторинг.СистемаМониторинга.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.ТокенПользователя.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.ПользователиСервисов.Новый(),
	 TechControl.Метаданные.Мониторинг.Объекты.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФиксацияИсторииДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.ПолучениеДанныхСПИК.Новый(),
	 TechControl.Метаданные.Мониторинг.ФормированиеСмены.Новый(),
	 TechControl.Метаданные.Мониторинг.Картинки.Новый(),
	 TechControl.Метаданные.Мониторинг.ФиксацияИстории.Новый(),
	 TechControl.Метаданные.Сервис.РазрешениеОперацииПользователя.Новый(),
	 TechControl.Метаданные.Сервис.ДействияПользователей.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблица.Новый(),
	 TechControl.Метаданные.Сервис.Пользователи.Новый(),
	 TechControl.Метаданные._SystemTables.РолиПользователя.Новый(),
	 TechControl.Метаданные.Сервис.ТипСообщения.Новый(),
	 TechControl.Метаданные.Сервис.СписокСообщений.Новый(),
	 TechControl.Метаданные.Сервис.Приоритет.Новый(),
	 TechControl.Метаданные.Сервис.ТипЗадачиНаСервере.Новый(),
	 TechControl.Метаданные.Сервис.СервернаяЗадача.Новый(),
	 TechControl.Метаданные.Сервис.НастройкиПользователей.Новый(),
	 TechControl.Метаданные.Сервис.ПраваПользователей.Новый(),
	 TechControl.Метаданные._SystemTables.СервисПраваПользователейДвижения.Новый(),
	 TechControl.Метаданные.Сервис.ОбновленияСистемы.Новый(),
	 TechControl.Метаданные.Сервис.ТаблицаРолиМенюПользователя.Новый(),
	 TechControl.Метаданные.Сервис.РольПользователяМеню.Новый(),
	 TechControl.Метаданные.Сервис.ДействиеЭлементаМеню.Новый(),
	 TechControl.Метаданные.Сервис.ТаблицаЭлементаМенюПользователя.Новый(),
	 TechControl.Метаданные.Сервис.ЭлементМенюПользователя.Новый(),
	 TechControl.Метаданные.Мониторинг.Контрагенты.Новый(),
	 TechControl.Метаданные.Мониторинг.Сотрудники.Новый(),
	 TechControl.Метаданные.Мониторинг.РежимыРаботы.Новый(),
	 TechControl.Метаданные.Мониторинг.Должности.Новый(),
	 TechControl.Метаданные.Мониторинг.ШтатныеРасписания.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРежимыРаботыТаблицаГрафик.Новый(),
	 TechControl.Метаданные.Мониторинг.ДеньНедели.Новый(),
	 TechControl.Метаданные.Мониторинг.ТипСобственности.Новый(),
	 TechControl.Метаданные.Мониторинг.СтатусТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаПерсонал.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаТехника.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингМониторирнгТехникиДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.МониторирнгТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингОтработанноеВремяТехникиТаблица.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтработанноеВремяТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрОтработанногоВремениДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрОтработанногоВремени.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗакрытиеСменыДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.ЗакрытиеСмены.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗакрытиеСменыНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗакрытиеСменыНакопления_1.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрЗакрытиеСмены.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтчетЗакрытиеСмены.Новый()});
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
	Version = "2022.2.28.1";
	ContainsUserInformation = true;
	UserActionsRegisteration = true;
	UseUserMenu = true;
	Groups = new System.String[]{"Сервис", "Мониторинг", "СлужебныеСправочники"};
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
                return "TechControl";
            }
        }
        #endregion //Методы
    }
}
