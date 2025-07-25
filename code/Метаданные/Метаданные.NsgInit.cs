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
	 TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаРазмеров.Новый(),
	 TechControl.Метаданные.Мониторинг.РежимыРаботы.Новый(),
	 TechControl.Метаданные.Мониторинг.Должности.Новый(),
	 TechControl.Метаданные.Мониторинг.ШтатныеРасписания.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРежимыРаботыТаблицаГрафик.Новый(),
	 TechControl.Метаданные.Мониторинг.ДеньНедели.Новый(),
	 TechControl.Метаданные.Мониторинг.ТипСобственности.Новый(),
	 TechControl.Метаданные.Мониторинг.СтатусТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингМониторирнгТехникиДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.МониторирнгТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингОтработанноеВремяТехникиТаблица.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтработанноеВремяТехники.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрОтработанногоВремениДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрОтработанногоВремени.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрСменНакопления.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрСмен.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрСменНакопления_1.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтчетЗакрытиеСмены.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрСменДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.Тарифы.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингТехникаТарифы.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтчетАрендаПоМесяцам.Новый(),
	 TechControl.Метаданные.Мониторинг.ЗакрытиеСмены.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗаправокДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.Заправка.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗаправокНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрЗаправокНакопления_1.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрПоставокТопливаДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрЗаправок.Новый(),
	 TechControl.Метаданные.Мониторинг.ПоставкаТоплива.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрПоставокТопливаНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрПоставокТопливаНакопления_1.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрПоставокТоплива.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтчетПоЗаправкам.Новый(),
	 TechControl.Метаданные.Мониторинг.ОтчетПоПоставкамТоплива.Новый(),
	 TechControl.Метаданные.Мониторинг.ГруппыСпецТехники.Новый(),
	 TechControl.Метаданные.Мониторинг.ГруппыДолжностей.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФормированиеСменыТаблицаПерсонал.Новый(),
	 TechControl.Метаданные.Мониторинг.СтатусСотрудника.Новый(),
	 TechControl.Метаданные.Мониторинг.ВидОперацииЗаправки.Новый(),
	 TechControl.Метаданные.Мониторинг.ИсточникиЗаправки.Новый(),
	 TechControl.Метаданные.Мониторинг.Роль.Новый(),
	 TechControl.Метаданные.Мониторинг.ТипСистемыСлежения.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингТехникаСистемыСлежения.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингЗаправкаТаблица.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФиксацияИсторииСотрудниковДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.ФиксацияИсторииСотрудников.Новый(),
	 TechControl.Метаданные.Перечисления.ПризнакиДвижений.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФормированиеСменыДеньТаблицаПерсонал.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФормированиеСменыДеньТаблицаТехника.Новый(),
	 TechControl.Метаданные.Мониторинг.ФормированиеСменыДень.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингОбъектыТаблицаСистемыСлежения.Новый(),
	 TechControl.Метаданные.Учет.Номенклатура.Новый(),
	 TechControl.Метаданные.Учет.ТипНоменклатуры.Новый(),
	 TechControl.Метаданные.Учет.КатегорияНоменклатуры.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.АккаунтПользователя.Новый(),
	 TechControl.Метаданные._SystemTables.СлужебныеСправочникиПользователиСервисовАккаутыПользователя.Новый(),
	 TechControl.Метаданные.Учет.СвойствоНоменклатуры.Новый(),
	 TechControl.Метаданные.Учет.ВидСвойствНоменклатуры.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.ПриглашениеПользователя.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСвойствоНоменклатурыТаблица.Новый(),
	 TechControl.Метаданные._SystemTables.УчетКатегорияНоменклатурыТаблица.Новый(),
	 TechControl.Метаданные.Учет.ВариантыЗначений.Новый(),
	 TechControl.Метаданные._SystemTables.УчетПриходнаяНакладнаяТаблица.Новый(),
	 TechControl.Метаданные.Учет.ПриходнаяНакладная.Новый(),
	 TechControl.Метаданные._SystemTables.УчетПеремещениеТаблица.Новый(),
	 TechControl.Метаданные.Учет.Перемещение.Новый(),
	 TechControl.Метаданные._SystemTables.УчетОстаткиНоменклатурыНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.УчетОстаткиНоменклатурыНакопления_1.Новый(),
	 TechControl.Метаданные.Учет.ОстаткиНоменклатуры.Новый(),
	 TechControl.Метаданные._SystemTables.УчетОстаткиНоменклатурыДвижения.Новый(),
	 TechControl.Метаданные.Мониторинг.Геозоны.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрацияХодокТабличнаяЧасть.Новый(),
	 TechControl.Метаданные.Мониторинг.РегистрацияХодок.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингРегистрацияХодокТаблицаКоличестваХодок.Новый(),
	 TechControl.Метаданные.Мониторинг.Ходки.Новый(),
	 TechControl.Метаданные.Учет.Фотографии.Новый(),
	 TechControl.Метаданные.Учет.Размеры.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.Уведомления.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингПроверкаЗаправкиТаблица.Новый(),
	 TechControl.Метаданные.Мониторинг.ПроверкаЗаправки.Новый(),
	 TechControl.Метаданные.СлужебныеСправочники.НастройкиПользователейСервисов.Новый(),
	 TechControl.Метаданные.Мониторинг.Договоры.Новый(),
	 TechControl.Метаданные._SystemTables.СлужебныеСправочникиАккаунтПользователяДоступныеОбъекты.Новый(),
	 TechControl.Метаданные.Мониторинг.ЗагрузкаИзJSON.Новый(),
	 TechControl.Метаданные.Грузы.ВывозГруза.Новый(),
	 TechControl.Метаданные.Грузы.ПривозГруза.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыПривозГрузаТаблицаКартинок.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыВывозГрузаТаблицаКартинок.Новый(),
	 TechControl.Метаданные._SystemTables.УчетПодтверждениеПеремещенияТаблица.Новый(),
	 TechControl.Метаданные.Учет.ПодтверждениеПеремещения.Новый(),
	 TechControl.Метаданные.Учет.СтатусыПеремещений.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗПеремещениеСпецодеждыТаблица.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.КомплектыСпецодежды.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗКомплектыСпецодеждыТаблицаКомплектаСпецодежды.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.ПеремещениеСпецодежды.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.КонтрольСпецодеждыИСИЗ.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаКомплектовСпецодежды.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингФизЛицаТаблицаСовмещаемыхДолжностей.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.РегистрУчетСпецодежды.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрУчетСпецодеждыДвижения.Новый(),
	 TechControl.Метаданные.Администрирование.СлужебныеДействия.Новый(),
	 TechControl.Метаданные._SystemTables.УчетИнструментаПеремещениеИнструментаТаблица.Новый(),
	 TechControl.Метаданные.УчетИнструмента.РегистрУчетИнструмента.Новый(),
	 TechControl.Метаданные._SystemTables.УчетИнструментаРегистрУчетИнструментаДвижения.Новый(),
	 TechControl.Метаданные.УчетИнструмента.ПеремещениеИнструмента.Новый(),
	 TechControl.Метаданные.УчетИнструмента.КонтрольИнструмента.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.Мерки.Новый(),
	 TechControl.Метаданные.Учет.ПланыАмортизации.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.ВидыРазмернойСетки.Новый(),
	 TechControl.Метаданные.Учет.РегистрЦен.Новый(),
	 TechControl.Метаданные._SystemTables.УчетРегистрЦенДвижения.Новый(),
	 TechControl.Метаданные.Учет.ТипыЦен.Новый(),
	 TechControl.Метаданные.Мониторинг.Подразделения.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФПеремещениеСпецодежды.Новый(),
	 TechControl.Метаданные._SystemTables.УчетФормированиеЦеныТаблица.Новый(),
	 TechControl.Метаданные.Отчеты.ОтчетПоСпецодежде.Новый(),
	 TechControl.Метаданные.Отчеты.ОтчетПоЗакупкам.Новый(),
	 TechControl.Метаданные.Учет.ФормированиеЦены.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингДолжностиТаблицаНеобязательнойНоменклатуры.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗЗаявкиПоставщикамТаблица.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.ЗаявкиПоставщикам.Новый(),
	 TechControl.Метаданные.Администрирование.ОбработкаДокументов.Новый(),
	 TechControl.Метаданные.Перечисления.СтатусыЗаявок.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФЗаявкаПоставщику.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗЗаявкаНаСотрудникаТаблица.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.ЗаявкаНаСотрудника.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗнСДвижения.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗнСНакопления_1.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗнСНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗПДвижения.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФЗаявкаНаСотрудника.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.РегистрРезерваЗнС.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗПНакопления.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСпецодеждыИСИЗРегистрРезерваЗПНакопления_1.Новый(),
	 TechControl.Метаданные.УчетСпецодеждыИСИЗ.РегистрРезерваЗП.Новый(),
	 TechControl.Метаданные.Перечисления.СтатусыЗаявокНаСотрудника.Новый(),
	 TechControl.Метаданные.СлужебныеДокументы.Оповещения.Новый(),
	 TechControl.Метаданные.Перечисления.СтатусыОповещений.Новый(),
	 TechControl.Метаданные.Константы.КонстантыОбщие.Новый(),
	 TechControl.Метаданные.Перечисления.ВидыПериодов.Новый(),
	 TechControl.Метаданные.Отчеты.ОтчетПоИнструменту.Новый(),
	 TechControl.Метаданные.Справочники.ТипыОбъектов.Новый(),
	 TechControl.Метаданные._SystemTables.СправочникиТипыОбъектовТаблицаНоменлатуры.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСотрудниковРегистрУчетСотрудниковДвижения.Новый(),
	 TechControl.Метаданные._SystemTables.УчетСотрудниковНазначенияСотрудниковТаблица.Новый(),
	 TechControl.Метаданные.УчетСотрудников.РегистрУчетСотрудников.Новый(),
	 TechControl.Метаданные.УчетСотрудников.НазначенияСотрудников.Новый(),
	 TechControl.Метаданные.УчетСотрудников.ПриказОНазначенииСотрудника.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФПриказОНазначенииСотрудника.Новый(),
	 TechControl.Метаданные.УчетСотрудников.УправлениеСотрудниками.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингТехникаТаблицаДопущенныеДоУправленияДолжности.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыГрафикРаботыОбъектаТаблица.Новый(),
	 TechControl.Метаданные.Документы.ГрафикРаботыОбъекта.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыОтработанныеМесяцыТаблица.Новый(),
	 TechControl.Метаданные.Документы.НастройкиПраздников.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыНастройкиПраздниковТаблицаПраздников.Новый(),
	 TechControl.Метаданные.Документы.ОтработанныеМесяцы.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФОтработанныеМесяцы.Новый(),
	 TechControl.Метаданные.УчетСотрудников.ВидыДокументов.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыЭСМТаблица.Новый(),
	 TechControl.Метаданные.Документы.ЭСМ.Новый(),
	 TechControl.Метаданные.ПечатныеФормыДокументов.ПФЭСМ.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыЭСМТаблицаДокументов.Новый(),
	 TechControl.Метаданные.Документы.Доверенности.Новый(),
	 TechControl.Метаданные.УчетСотрудников.ПланированиеГрафиковРаботы.Новый(),
	 TechControl.Метаданные.Перечисления.ВидыРежимовРаботы.Новый(),
	 TechControl.Метаданные.Документы.ПлановыйГрафикРаботы.Новый(),
	 TechControl.Метаданные._SystemTables.РегистрыРегистрПерсоналОбъектаДвижения.Новый(),
	 TechControl.Метаданные._SystemTables.РегистрыРегистрТехникаОбъектаДвижения.Новый(),
	 TechControl.Метаданные.Регистры.РегистрПерсоналОбъекта.Новый(),
	 TechControl.Метаданные._SystemTables.РегистрыРегистрТарифыПерсоналаОбъектаДвижения.Новый(),
	 TechControl.Метаданные.Регистры.РегистрТехникаОбъекта.Новый(),
	 TechControl.Метаданные._SystemTables.РегистрыРегистрТарифыТехникиОбъектаДвижения.Новый(),
	 TechControl.Метаданные.Регистры.РегистрТарифыПерсоналаОбъекта.Новый(),
	 TechControl.Метаданные.Регистры.РегистрТарифыТехникиОбъекта.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыПлановыйГрафикРаботыТаблицаПодробныйГрафик.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления.Новый(),
	 TechControl.Метаданные.Грузы.ДокументыВъезда.Новый(),
	 TechControl.Метаданные.Грузы.ДокументыВыезда.Новый(),
	 TechControl.Метаданные.Грузы.КонтрольноПропускныеПункты.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыРегистрПеремещениеЧерезКППДвижения.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыРегистрПеремещениеЧерезКППНакопления_1.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыДокументыВыездаТаблицаФотографии.Новый(),
	 TechControl.Метаданные.Грузы.РегистрПеремещениеЧерезКПП.Новый(),
	 TechControl.Метаданные.Грузы.ВидыГрузов.Новый(),
	 TechControl.Метаданные._SystemTables.ГрузыДокументыВъездаТаблицаФотографии.Новый(),
	 TechControl.Метаданные.Грузы.УправлениеВъездамиВыездами.Новый(),
	 TechControl.Метаданные.Грузы.УправлениеПогрузкойРазгрузкой.Новый(),
	 TechControl.Метаданные.УчетСотрудников.ДокументыФизЛиц.Новый(),
	 TechControl.Метаданные.Мониторинг.ФизЛица.Новый(),
	 TechControl.Метаданные.Учет.ТипыФотографий.Новый(),
	 TechControl.Метаданные.Учет.ИсточникФотографииКлиента.Новый(),
	 TechControl.Метаданные.Документы.ДокументСменыТекущегоВидаРабот.Новый(),
	 TechControl.Метаданные.Документы.ЗаявкиНаРаботы.Новый(),
	 TechControl.Метаданные.Справочники.ВидыРабот.Новый(),
	 TechControl.Метаданные._SystemTables.ДокументыЗаявкиНаРаботыТаблицаВидыРабот.Новый(),
	 TechControl.Метаданные.Мониторинг.СтатусыЗаявокНаТехнику.Новый(),
	 TechControl.Метаданные.Документы.ЗаявкиНаТехнику.Новый(),
	 TechControl.Метаданные._SystemTables.МониторингГруппыСпецТехникиТаблицаВидыВыполняемыхРабот.Новый(),
	 TechControl.Метаданные.Мониторинг.ВидыКузовов.Новый()});
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
	Version = "2025.7.24.2";
	ContainsUserInformation = true;
	UserActionsRegisteration = true;
	UseUserMenu = true;
	Groups = new System.String[]{"Сервис", "Мониторинг", "СлужебныеСправочники", "Перечисления", "Учет", "Грузы", "УчетСпецодеждыИСИЗ", "Администрирование", "УчетИнструмента", "ПечатныеФормыДокументов", "Отчеты", "СлужебныеДокументы", "Константы", "Справочники", "УчетСотрудников", "Документы", "Регистры"};
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
