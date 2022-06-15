using Newtonsoft.Json;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TechControl.EventRibbonService;
using TechControl.ServiceReferenceControllerStistics;
using TechControl.ServiceReferenceDataOnline;
using TechControl.ServiceReferenceDataOnlineSensors;
using TechControl.ServiceReferenceFDStat;
using TechControl.ServiceReferenceMotorModes;
using TechControl.ServiceReferenceTrackPeriods;
using TechControl.ServiceReferenceUnitsSpic;
using TechControl.ServiceReferenceValidationNavigation;
using TechControl.UtilityServiceWeb;
using TechControl.Метаданные._SystemTables;
using TechControl.SpicSoapGeofenceVisitsStatisticsService;
using TechControl.SpicGeofenceService;
using TechControl.SpicNavigationFiltrationStatisticsService;

namespace TechControl.Метаданные.Мониторинг
{
    public partial class ПолучениеДанныхСПИКФорма
    {
        public ПолучениеДанныхСПИКФорма()
        {
            InitializeComponent();
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override async void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);

            //var cmp = new NsgCompare().Add(ОтработанноеВремяТехники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            //var a = ОтработанноеВремяТехники.Новый().FindAll(cmp);
            //foreach (var b in a)
            //{
            //    b.Delete();
            //}

            //var cmpB = new NsgCompare().Add(ФормированиеСмены.Names.ПровереноАвтоматически, true);
            //var r = ФормированиеСмены.Новый().FindAll(cmpB);
            //foreach (var b in r)
            //{
            //    b.Edit();
            //    b.ПровереноАвтоматически = false;
            //    b.Post();
            //}

            //var cmp = new NsgCompare().Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален);
            //var a = Техника.Новый().FindAll(cmp);
            //foreach (var b in a)
            //{
            //    b.Delete();
            //}

            //SpicSoapUnitsServiceClient _client = new SpicSoapUnitsServiceClient();
            //_client.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            //var unitsCount = _client.GetAllUnitsCount();
            //Dictionary<int, string> unitIDName = new Dictionary<int, string>();
            ////Создание запроса.
            //var request = new SpicObjectsChunkRequest { Offset = 0, Count = unitsCount };
            //var units = _client.GetAllUnitsPaged(request);
            //var list = new List<string>();
            //foreach (var unit in units.Units)
            //{
            //    var cmp = new NsgCompare().Add(Техника.Names.Наименование, unit.Name, NsgComparison.Contain);
            //    var тех = Техника.Новый().FindAll(cmp);
            //    тех[0].Edit();
            //    тех[0].СистемыСлежения.Edit();
            //    var row = тех[0].СистемыСлежения.NewRow();
            //    row.ИдентификаторСистемыСлежения = $"{unit.UnitId}";
            //    row.ТипСистемыСлежения = ТипСистемыСлежения.Скаут;
            //    row.Post();
            //    тех[0].СистемыСлежения.Post();
            //    тех[0].Post();
            //    unitIDName.Add(unit.UnitId, unit.Name);
            //    list.Add(unit.Name);
            //}

            //var cmpTech = new NsgCompare().Add(Техника.Names.Наименование, list.ToArray(), NsgComparison.In);
            //var tech = Техника.Новый().FindAll(cmpTech);
            //foreach (var t in tech)
            //{
            //    foreach (var unit in unitIDName)
            //    {
            //        if (t.Наименование == unit.Value)
            //        {
            //            t.Edit();
            //            t.СистемыСлежения.Edit();
            //            var row = t.СистемыСлежения.NewRow();
            //            row.ИдентификаторСистемыСлежения = $"{unit.Key}";
            //            row.Post();
            //            t.СистемыСлежения.Post();
            //            t.Post();
            //        }
            //    }               
            //}
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private async void nsgButton1_AsyncClick(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var cmpФормСмены = new NsgCompare().Add(ФормированиеСмены.Names.ПровереноАвтоматически, false);
            var формСмен = ФормированиеСмены.Новый().FindAll(cmpФормСмены);

            var листДат = new List<DateTime>();
            var листТехники = new List<Техника>();
            List<TrackingSystems> trackingSystemsWorkshifts = new List<TrackingSystems>();
            List<TrackingSystems> trackingSystemsSkayt = new List<TrackingSystems>();
            List<TrackingSystems> trackingSystemsHistory = new List<TrackingSystems>();

            foreach (var смена in формСмен)
            {
                if (!листДат.Contains(смена.ДатаДокумента.Date))
                    листДат.Add(смена.ДатаДокумента.Date);

                foreach (var строкаТаб in смена.Таблица.Rows)
                {
                    var техника = строкаТаб.Техника;
                    var время = строкаТаб.Длительность;

                    if (!string.IsNullOrEmpty(техника.ToString()))
                    {
                        if (!листТехники.Contains(техника))
                            листТехники.Add(техника);

                        TrackingSystems workShifts = new TrackingSystems();
                        workShifts.tech = техника;
                        workShifts.date = смена.ДатаДокумента.Date;
                        workShifts.totalHours = время;
                        workShifts.typeSystem = TypeTrackingSystem.Workshifts;
                        trackingSystemsWorkshifts.Add(workShifts);

                        foreach (var строка in техника.СистемыСлежения.Rows)
                        {
                            if (строка.ТипСистемыСлежения == ТипСистемыСлежения.Сигнализации)
                            {
                                var historys = EventRibbonClient.GetRibbonEventsWTwoDatesAndCodes(строка.ИдентификаторСистемыСлежения, смена.ДатаДокумента.Date,
                                NsgService.EndOfDay(смена.ДатаДокумента), 1000, new string[] { "3401", "1401" });

                                if (historys.Length > 0)
                                {
                                    DateTime workBegin = new DateTime();
                                    DateTime workEnd = new DateTime();
                                    var sortHistory = historys.OrderBy(x => x.Datetime).ToList();

                                    string снятие = "1401";
                                    string постановка = "3401";
                                    string предыдущийСтатус = null;

                                    var истории = new List<decimal>();

                                    for (var i = 0; i < sortHistory.Count; i++)
                                    {
                                        var текущийСтатус = sortHistory[i].Code;
                                        var текущаяДата = sortHistory[i].Datetime;

                                        if (i != 0)
                                        {
                                            if (предыдущийСтатус == null && sortHistory[i - 1].Code.Contains(снятие))
                                            {
                                                предыдущийСтатус = sortHistory[i - 1].Code;
                                            }

                                            if (предыдущийСтатус != null && предыдущийСтатус != текущийСтатус)
                                            {
                                                if (текущийСтатус.Contains(постановка) && предыдущийСтатус.Contains(снятие))
                                                {
                                                    TimeSpan tick = new TimeSpan();
                                                    workEnd = текущаяДата;
                                                    tick = (workEnd - workBegin);
                                                    var totalHours = tick.TotalHours > 24 ? 24 : tick.TotalHours;

                                                    TrackingSystems history = new TrackingSystems();
                                                    history.date = смена.ДатаДокумента.Date;
                                                    history.tech = техника;
                                                    history.totalHours = Math.Round((decimal)totalHours, 2);
                                                    history.typeSystem = TypeTrackingSystem.Alarms;
                                                    trackingSystemsHistory.Add(history);

                                                    истории.Add(Math.Round((decimal)totalHours, 2));

                                                    var cmpОтрабВремяСигнал = new NsgCompare().Add(ОтработанноеВремяТехники.Names.ДатаДокумента, текущаяДата.Date, NsgComparison.GreaterOrEqual);
                                                    cmpОтрабВремяСигнал.Add(ОтработанноеВремяТехники.Names.ДатаДокумента, NsgService.EndOfDay(текущаяДата), NsgComparison.LessOrEqual);
                                                    cmpОтрабВремяСигнал.Add(ОтработанноеВремяТехники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                                                    var отрабВремяСигнал = ОтработанноеВремяТехники.Новый().FindAll(cmpОтрабВремяСигнал);

                                                    if (отрабВремяСигнал.Length > 0)
                                                    {
                                                        отрабВремяСигнал[0].Edit();
                                                        отрабВремяСигнал[0].Таблица.Edit();
                                                        var listТехники = new List<Техника>();
                                                        foreach (var item in отрабВремяСигнал[0].Таблица.Rows)
                                                        {
                                                            if (!listТехники.Contains(item.Техника))
                                                                listТехники.Add(item.Техника);
                                                        }

                                                        foreach (var x in отрабВремяСигнал[0].Таблица.Rows)
                                                        {
                                                            if (x.ТипСистемыСлежения == ТипСистемыСлежения.Сигнализации && x.Техника == техника)
                                                            {
                                                                x.ДатаНачалаРаботы = workBegin;
                                                                x.ДатаОкончанияРаботы = workEnd;
                                                                x.ДлительностьРаботы = Math.Round((decimal)totalHours, 2);
                                                                x.Post();
                                                            }
                                                        }

                                                        if (!listТехники.Contains(техника))
                                                        {
                                                            var row = отрабВремяСигнал[0].Таблица.NewRow();
                                                            row.Техника = техника;
                                                            row.ДатаНачалаРаботы = workBegin;
                                                            row.ДатаОкончанияРаботы = workEnd;
                                                            row.ДлительностьРаботы = Math.Round((decimal)totalHours, 2);
                                                            row.ТипСистемыСлежения = ТипСистемыСлежения.Сигнализации;
                                                            row.Post();
                                                        }

                                                        отрабВремяСигнал[0].Таблица.Post();
                                                        отрабВремяСигнал[0].Post();
                                                        отрабВремяСигнал[0].Handle();
                                                    }
                                                    else
                                                    {
                                                        var отрабВремяСигналНовый = ОтработанноеВремяТехники.Новый();
                                                        отрабВремяСигналНовый.New();
                                                        отрабВремяСигналНовый.ДатаДокумента = текущаяДата;
                                                        var row = отрабВремяСигналНовый.Таблица.NewRow();
                                                        row.Техника = техника;
                                                        row.ДатаНачалаРаботы = workBegin;
                                                        row.ДатаОкончанияРаботы = workEnd;
                                                        row.ДлительностьРаботы = Math.Round((decimal)totalHours, 2);
                                                        row.ТипСистемыСлежения = ТипСистемыСлежения.Сигнализации;
                                                        row.Post();
                                                        отрабВремяСигналНовый.Post();
                                                        отрабВремяСигналНовый.Handle();
                                                    }

                                                    предыдущийСтатус = null;
                                                }
                                            }
                                        }
                                        else if (текущийСтатус.Contains(снятие))
                                            workBegin = текущаяДата;
                                    }
                                }
                            }
                        }
                    }                   
                }
                смена.Edit();
                смена.ПровереноАвтоматически = true;
                смена.Post();
            }

            #region[Получение данных спик]
            SpicSoapUnitsServiceClient _client = new SpicSoapUnitsServiceClient();
            SpicSoapOnlineDataServiceClient _dataServiceClient = new SpicSoapOnlineDataServiceClient();
            SpicSoapStatisticsControllerServiceClient _statisticsClient = new SpicSoapStatisticsControllerServiceClient();
            SpicSoapOnlineDataWithSensorsServiceClient _dataServiceSensorClient = new SpicSoapOnlineDataWithSensorsServiceClient();
            SpicSoapNavigationValidationStatisticsServiceClient _navigationValidationClient = new SpicSoapNavigationValidationStatisticsServiceClient();
            SpicSoapTrackPeriodsMileageStatisticsServiceClient _specificStatisticsClient = new SpicSoapTrackPeriodsMileageStatisticsServiceClient();
            SpicSoapMotorModesStatisticsServiceClient _motorModesClient = new SpicSoapMotorModesStatisticsServiceClient();
            SpicSoapFuelingDefuelingStatisticsServiceClient _fuelDefuelStatisticClient = new SpicSoapFuelingDefuelingStatisticsServiceClient();

            // добавляем поведение авторизации перед связью с конечной точкой 
            _client.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _statisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceSensorClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _navigationValidationClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _specificStatisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _motorModesClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _fuelDefuelStatisticClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());

            //Получить количество доступных объектов мониторинга.
            //var unitsCount = _client.GetAllUnitsCount();

            List<string> listModel = new List<string>();
            List<string> listBrand = new List<string>();
            List<int> listUnitID = new List<int>();
            Dictionary<string, string> unitIDName = new Dictionary<string, string>();
            //Создание запроса.
            //var request = new SpicObjectsChunkRequest { Offset = 0, Count = unitsCount };
            //var units = _client.GetAllUnitsPaged(request);
            //foreach (var unit in units.Units)
            //{
            //    listUnitID.Add(unit.UnitId);
            //    unitIDName.Add(unit.UnitId, unit.Name);
            //}

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string dataAuth = "grant_type=password&username=skvortsov@titan002.ru&password=skvortsov@titan002.ru&locale=ru&client_id=8b1fd704-096e-42d6-9ba5-6d98980e7cd1&client_secret=scout-online";
            string urlAuth = "auth/token";
            var outputResultAuth = await RequestAsync(dataAuth, urlAuth, true, string.Empty);
            var deserializeJsonAuth = JsonConvert.DeserializeObject<DeserializeAuth>(outputResultAuth);

            string onlineDataUrl = $"?api-version=2.0&request.skip=0&request.take={листТехники.Count}&request.filter=All&request.search";
            var sb = new StringBuilder(onlineDataUrl);
            foreach (var row in листТехники)
            {
                foreach (var строка in row.СистемыСлежения.Rows)
                {
                    if (строка.ТипСистемыСлежения == ТипСистемыСлежения.Скаут)
                    {
                        sb.Append(строка.ИдентификаторСистемыСлежения);
                        unitIDName.Add(строка.ИдентификаторСистемыСлежения, row.Наименование);
                    }
                }
            }
            var outputResultOnlineData = await RequestAsync(sb.ToString(), string.Empty, false, deserializeJsonAuth.access_token);
            var deserializeJsonResult = JsonConvert.DeserializeObject<Result>(outputResultOnlineData);

            foreach (var data in deserializeJsonResult.data)
            {
                var online = data.onlineData;
                var unit = data.unit;

                var cmpTech = new NsgCompare().Add(Техника.Names.СистемыСлежения + "." + МониторингТехникаСистемыСлежения.Names.ИдентификаторСистемыСлежения, unit.id);
                cmpTech.Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var techIsReal = Техника.Новый().FindAll(cmpTech);
                var tech = Техника.Новый();

                if (techIsReal.Length == 0)
                {
                    tech.New();
                    tech.ГосНомер = unit.stateNumber;
                    tech.Наименование = unit.name;
                    var row = tech.СистемыСлежения.NewRow();
                    row.ИдентификаторСистемыСлежения = $"{unit.id}";
                    row.ТипСистемыСлежения = ТипСистемыСлежения.Скаут;
                    row.Post();

                    var model = unit.model;
                    var brand = unit.brand;
                    var type = unit.deviceName;

                    if (!listModel.Contains(model) && !string.IsNullOrEmpty(model))
                    {
                        listModel.Add(model);
                        var cmpModel = new NsgCompare().Add(Модель.Names.Наименование, model);
                        cmpModel.Add(Модель.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                        var такаяМодельЕсть = Модель.Новый().FindAll(cmpModel);
                        if (такаяМодельЕсть.Length == 0)
                        {
                            var модельНовая = Модель.Новый();
                            модельНовая.New();
                            модельНовая.Наименование = model;
                            модельНовая.Post();

                            tech.Модель = модельНовая;
                        }
                        else
                            tech.Модель = такаяМодельЕсть[0];
                    }

                    if (!listBrand.Contains(brand) && !string.IsNullOrEmpty(brand))
                    {
                        listBrand.Add(brand);
                        var cmpBrand = new NsgCompare().Add(Марка.Names.Наименование, brand);
                        cmpBrand.Add(Марка.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                        var такаяМаркаЕсть = Марка.Новый().FindAll(cmpBrand);
                        if (такаяМаркаЕсть.Length == 0)
                        {
                            var модельНовая = Марка.Новый();
                            модельНовая.New();
                            модельНовая.Наименование = brand;
                            модельНовая.Post();

                            tech.Марка = модельНовая;
                        }
                        else
                            tech.Марка = такаяМаркаЕсть[0];
                    }

                    if (type != null)
                    {
                        var cmpType = new NsgCompare().Add(ГруппыСпецТехники.Names.Наименование, type);
                        cmpType.Add(ГруппыСпецТехники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                        var такойТипЕсть = ГруппыСпецТехники.Новый().FindAll(cmpType);
                        if (такойТипЕсть.Length == 0)
                        {
                            var модельНовая = ГруппыСпецТехники.Новый();
                            модельНовая.New();
                            модельНовая.Наименование = type;
                            модельНовая.Post();

                            tech.ГруппаСпецТехники = модельНовая;
                        }
                        else
                            tech.ГруппаСпецТехники = такойТипЕсть[0];
                    }

                    tech.Post();
                }
                else
                    tech = techIsReal[0];

                var рег = МониторирнгТехники.Новый();
                рег.New();

                if (online.isEngineWorking == null)
                    рег.РаботаетДвигатель = false;
                else
                    рег.РаботаетДвигатель = (bool)online.isEngineWorking;

                if (online.fuelLevel == null)
                    рег.ТекущееКолвоТоплива = 0;
                else
                    рег.ТекущееКолвоТоплива = (decimal)online.fuelLevel;

                if (online.speed == null)
                    рег.ТекущаяСкорость = 0;
                else
                    рег.ТекущаяСкорость = (decimal)online.speed;

                if (online.longitude == null)
                    рег.Долгота = 0;
                else
                    рег.Долгота = (decimal)online.longitude;

                if (online.latitude == null)
                    рег.Широта = 0;
                else
                    рег.Широта = (decimal)online.latitude;

                рег.Техника = tech;
                рег.AddMovement();
                рег.Post();
            }

            foreach (var дата in листДат)
            {
                var cmpОтработанноеВремя = new NsgCompare().Add(ОтработанноеВремяТехники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                cmpОтработанноеВремя.Add(ОтработанноеВремяТехники.Names.ДатаДокумента, дата.Date, NsgComparison.GreaterOrEqual);
                cmpОтработанноеВремя.Add(ОтработанноеВремяТехники.Names.ДатаДокумента, NsgService.EndOfDay(дата), NsgComparison.LessOrEqual);
                var отработанноеВремя = ОтработанноеВремяТехники.Новый().FindAll(cmpОтработанноеВремя);
                bool такоеВремяЕсть = false;

                if (отработанноеВремя.Length > 0)
                {
                    такоеВремяЕсть = true;
                }

                var докОтработанноеВремяТехники = ОтработанноеВремяТехники.Новый();
                if (!такоеВремяЕсть)
                {
                    докОтработанноеВремяТехники.New();
                    докОтработанноеВремяТехники.ДатаДокумента = дата;
                }
                else
                {
                    докОтработанноеВремяТехники = отработанноеВремя[0];
                    докОтработанноеВремяТехники.Edit();
                }

                try
                {
                    foreach (var id in unitIDName)
                    {
                        NsgSettings.MainForm.ShowMessage($"запрос статистики {id}");
                        //создаем запрос сессии статистик
                        var statisticsSessionRequest = new SpicStatisticsSessionRequest
                        {
                            Period = new ServiceReferenceControllerStistics.SpicDateTimeRange
                            {
                                Begin = дата,
                                End = NsgService.EndOfDay(дата)
                            },

                            TargetObject = new SpicObjectIdentity
                            {
                                ObjectTypeId = ObjectTypeId.Vehicle,
                                ObjectId = Convert.ToInt32(id.Key)
                            }
                        };

                        //отправляем запрос и получаем сессию
                        var statisticsSession = _statisticsClient.StartStatisticsSession(statisticsSessionRequest).Session;
                        // на самом деле, это один и тот же контракт, но его нужно пересоздать  
                        var fuelDefuelStatisticsSession = new ServiceReferenceFDStat.SpicStatisticsSession
                        {
                            StatisticsSessionId = statisticsSession.StatisticsSessionId,
                        };
                        // добавляем запрос на построение статистики  
                        _fuelDefuelStatisticClient.AddStatisticsRequest(fuelDefuelStatisticsSession);

                        var motorModesStatisticsSession = new ServiceReferenceMotorModes.SpicStatisticsSession
                        {
                            StatisticsSessionId = statisticsSession.StatisticsSessionId,
                        };
                        _motorModesClient.AddStatisticsRequest(motorModesStatisticsSession);

                        // запускаем построение  
                        _statisticsClient.StartBuild(statisticsSession);

                        var statisticsListFuelDefuel = new List<SpicFuelingDefuelingStatistics>();
                        SpicFuelingDefuelingStatisticsResult statisticsResponseFuelDefuel;

                        var statisticsListMotorModes = new List<SpicMotorModesStatistics>();
                        SpicMotorModesStatisticsResult statisticsResponseMotorModes;

                        // выполняем, пока не получим последнюю порцию статистик  
                        do
                        {
                            // ждем, пока порция статистик построится  
                            do
                            {
                                statisticsResponseFuelDefuel = _fuelDefuelStatisticClient.GetStatistics(fuelDefuelStatisticsSession);
                                statisticsResponseMotorModes = _motorModesClient.GetStatistics(motorModesStatisticsSession);

                                var fuelDefuel = statisticsResponseFuelDefuel.Statistics;
                                var motorModes = statisticsResponseMotorModes.Statistics;

                                double? beginFuelVolumeL = 0;
                                double? endFuelVolumeL = 0;
                                double? totalVolumeOfFuelFilled = 0;
                                double countFueling = 0;

                                var cmpTech = new NsgCompare().Add(Техника.Names.СистемыСлежения + "." + МониторингТехникаСистемыСлежения.Names.ИдентификаторСистемыСлежения, id.Key);
                                cmpTech.Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                                var tech = Техника.Новый().FindAll(cmpTech);

                                if (tech.Length > 0)
                                {
                                    DateTime beginDate = new DateTime();
                                    DateTime endDate = new DateTime();
                                    double durationOfWork = 0;
                                    if (motorModes != null)
                                    {
                                        foreach (var period in motorModes.Periods)
                                        {
                                            if (period.IsIgnitionOn)
                                            {
                                                beginDate = period.Period.Begin;
                                                break;
                                            }
                                        }

                                        var length = motorModes.Periods.Length;
                                        for (var i = 1; i <= length; i++)
                                        {
                                            if (motorModes.Periods[length - i].IsIgnitionOn)
                                            {
                                                endDate = motorModes.Periods[length - i].Period.End;
                                                break;
                                            }
                                        }

                                        durationOfWork = motorModes.EngineOnHours.TotalHours;
                                    }

                                    if (fuelDefuel != null)
                                    {
                                        if (tech.Length > 0)
                                        {
                                            beginFuelVolumeL = fuelDefuel.BeginFuelVolumeL;
                                            endFuelVolumeL = fuelDefuel.EndFuelVolumeL;
                                            totalVolumeOfFuelFilled = fuelDefuel.FuelingTotalVolumeL;
                                            countFueling = fuelDefuel.FuelingCount;
                                        }
                                    }

                                    if (fuelDefuel != null || motorModes != null)
                                    {
                                        if (такоеВремяЕсть)
                                        {
                                            var listTech = new List<Техника>();
                                            foreach (var строка in докОтработанноеВремяТехники.Таблица.Rows)
                                            {
                                                if (!listTech.Contains(строка.Техника))
                                                    listTech.Add(строка.Техника);
                                            }

                                            докОтработанноеВремяТехники.Таблица.Edit();
                                            foreach (var x in докОтработанноеВремяТехники.Таблица.Rows)
                                            {
                                                if (x.ТипСистемыСлежения == ТипСистемыСлежения.Скаут && x.Техника == tech[0])
                                                {
                                                    x.ДатаНачалаРаботы = beginDate;
                                                    x.ДатаОкончанияРаботы = endDate;
                                                    x.ДлительностьРаботы = (decimal)durationOfWork;
                                                    x.НачальныйЗапасТоплива = (decimal)(beginFuelVolumeL == null ? 0 : beginFuelVolumeL);
                                                    x.КонечныйЗапасТоплива = (decimal)(endFuelVolumeL == null ? 0 : endFuelVolumeL);
                                                    x.общийОбъемЗаправленногоТоплива = (decimal)(totalVolumeOfFuelFilled == null ? 0 : totalVolumeOfFuelFilled);
                                                    x.КоличествоЗаправок = (decimal)countFueling;
                                                    x.ДлительностьРаботы = (decimal)durationOfWork;
                                                    x.Post();
                                                }
                                                else if (x.ТипСистемыСлежения == ТипСистемыСлежения.Сигнализации && x.Техника == tech[0])
                                                {
                                                    var row = докОтработанноеВремяТехники.Таблица.NewRow();
                                                    row.Техника = tech[0];
                                                    row.НачальныйЗапасТоплива = (decimal)(beginFuelVolumeL == null ? 0 : beginFuelVolumeL);
                                                    row.КонечныйЗапасТоплива = (decimal)(endFuelVolumeL == null ? 0 : endFuelVolumeL);
                                                    row.общийОбъемЗаправленногоТоплива = (decimal)(totalVolumeOfFuelFilled == null ? 0 : totalVolumeOfFuelFilled);
                                                    row.КоличествоЗаправок = (decimal)countFueling;
                                                    row.ДлительностьРаботы = (decimal)durationOfWork;
                                                    row.ДатаНачалаРаботы = beginDate;
                                                    row.ДатаОкончанияРаботы = endDate;
                                                    row.ТипСистемыСлежения = ТипСистемыСлежения.Скаут;
                                                    row.Post();
                                                }
                                            }

                                            if (!listTech.Contains(tech[0]))
                                            {
                                                var row = докОтработанноеВремяТехники.Таблица.NewRow();
                                                row.Техника = tech[0];
                                                row.НачальныйЗапасТоплива = (decimal)(beginFuelVolumeL == null ? 0 : beginFuelVolumeL);
                                                row.КонечныйЗапасТоплива = (decimal)(endFuelVolumeL == null ? 0 : endFuelVolumeL);
                                                row.общийОбъемЗаправленногоТоплива = (decimal)(totalVolumeOfFuelFilled == null ? 0 : totalVolumeOfFuelFilled);
                                                row.КоличествоЗаправок = (decimal)countFueling;
                                                row.ДлительностьРаботы = (decimal)durationOfWork;
                                                row.ДатаНачалаРаботы = beginDate;
                                                row.ДатаОкончанияРаботы = endDate;
                                                row.ТипСистемыСлежения = ТипСистемыСлежения.Скаут;
                                                row.Post();
                                            }

                                            докОтработанноеВремяТехники.Таблица.Post();
                                        }
                                        else
                                        {
                                            var row = докОтработанноеВремяТехники.Таблица.NewRow();
                                            row.Техника = tech[0];
                                            row.НачальныйЗапасТоплива = (decimal)(beginFuelVolumeL == null ? 0 : beginFuelVolumeL);
                                            row.КонечныйЗапасТоплива = (decimal)(endFuelVolumeL == null ? 0 : endFuelVolumeL);
                                            row.общийОбъемЗаправленногоТоплива = (decimal)(totalVolumeOfFuelFilled == null ? 0 : totalVolumeOfFuelFilled);
                                            row.КоличествоЗаправок = (decimal)countFueling;
                                            row.ДлительностьРаботы = (decimal)durationOfWork;
                                            row.ДатаНачалаРаботы = beginDate;
                                            row.ДатаОкончанияРаботы = endDate;
                                            row.ТипСистемыСлежения = ТипСистемыСлежения.Скаут;
                                            row.Post();
                                        }                                       
                                    }

                                    TrackingSystems skayt = new TrackingSystems();
                                    skayt.tech = tech[0];
                                    skayt.date = дата;
                                    skayt.totalHours = (decimal)durationOfWork;
                                    skayt.typeSystem = TypeTrackingSystem.Skayt;
                                    trackingSystemsSkayt.Add(skayt);
                                }
                                else
                                {
                                    NsgSettings.MainForm.ShowMessage("Техника не найдена");
                                }
                            }
                            while (statisticsResponseFuelDefuel.ChunkInfo.Status.Value == "Processing" && statisticsResponseMotorModes.ChunkInfo.Status.Value == "Processing");

                            if (statisticsResponseFuelDefuel.Statistics != null)
                                statisticsListFuelDefuel.Add(statisticsResponseFuelDefuel.Statistics);
                            if (statisticsResponseMotorModes.Statistics != null)
                                statisticsListMotorModes.Add(statisticsResponseMotorModes.Statistics);
                            //    break;

                            // заказываем следующую порцию статистики  
                            _statisticsClient.BuildNextChunk(statisticsSession);
                        }
                        while (!statisticsResponseFuelDefuel.ChunkInfo.IsFinalChunk && !statisticsResponseMotorModes.ChunkInfo.IsFinalChunk);

                        // закрываем сессию построения статистик  
                        _statisticsClient.StopStatisticsSession(statisticsSession);
                    }

                    докОтработанноеВремяТехники.Post();
                    докОтработанноеВремяТехники.Handle();
                }
                catch (Exception ee)
                {
                    NsgSettings.MainForm.ShowMessage("Ошибка " + ee);
                    докОтработанноеВремяТехники.Cancel();
                }
            }

            #endregion

            var all = new List<TrackingSystemsAll>();

            foreach (var workshift in trackingSystemsWorkshifts)
            {
                var trackAll = new TrackingSystemsAll();
                trackAll.tech = workshift.tech;
                trackAll.date = workshift.date;
                trackAll.totalHoursWorkshifts = workshift.totalHours;
                all.Add(trackAll);
            }    

            foreach (var skayt in trackingSystemsSkayt)
            {
                foreach (var row in all)
                {
                    if (row.date == skayt.date && row.tech == skayt.tech)
                    {
                        row.totalHoursSkayt = skayt.totalHours;
                    }
                }               
            }

            foreach (var history in trackingSystemsHistory)
            {
                foreach (var row in all)
                {
                    if (row.date == history.date && row.tech == history.tech)
                    {
                        row.totalHoursHistory = history.totalHours;
                    }
                }
            }

            vmoСигнализации.Data.BeginUpdateData();
            vmoСигнализации.Data.MemoryTable.Clear();
            foreach (var строка in all)
            {
                var row = vmoСигнализации.Data.MemoryTable.NewRow();
                row[Дата_vmoСигнализации].Value = строка.date;
                row[Техника_vmoСигнализации].Value = строка.tech;
                row[ВремяРаботыДок_vmoСигнализации].Value = строка.totalHoursWorkshifts;
                row[ВремяРаботыСкаут_vmoСигнализации].Value = строка.totalHoursSkayt;
                row[ВремяРаботыСигнализации_vmoСигнализации].Value = строка.totalHoursHistory;
                row.Post();
            }         
            vmoСигнализации.Data.UpdateDataAsync(this);
        }

        public async Task<string> RequestAsync(string data, string url, bool authorization, string token)
        {
            string outputResult = string.Empty;

            if (!authorization)
            {
                HttpWebRequest requestWEB = (HttpWebRequest)WebRequest.Create("https://online.scout-gps.ru:444/api/v2/online-data" + data);
                requestWEB.Method = "GET";
                requestWEB.Headers["Authorization"] = "Bearer " + token;
                requestWEB.ContentLength = 0;

                HttpWebResponse response = (HttpWebResponse)await requestWEB.GetResponseAsync();

                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        outputResult = reader.ReadToEnd();
                    }
                }
                response.Close();
            }
            else
            {
                HttpWebRequest requestWEB = (HttpWebRequest)WebRequest.Create("https://api.scout-gps.ru/api/" + url);
                requestWEB.Method = "POST";

                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
                requestWEB.ContentLength = byteArray.Length;

                using (Stream dataStream = requestWEB.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                HttpWebResponse response = (HttpWebResponse)await requestWEB.GetResponseAsync();

                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        outputResult = reader.ReadToEnd();
                    }
                }
                response.Close();
            }

            return outputResult;
        }

        static UtilityWebServiceClient utilityServiceClient;
        public static UtilityWebServiceClient UtilityServiceClient
        {
            get
            {
                if (utilityServiceClient == null)
                {
                    BasicHttpBinding binding = new BasicHttpBinding();
                    binding.MaxReceivedMessageSize = 10 * 1024 * 1024;
                    EndpointAddress address = new EndpointAddress("http://10.10.4.160:5072/UtilityService.svc");
                    utilityServiceClient = new UtilityWebServiceClient(binding, address);

                    try
                    {
                        utilityServiceClient.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                return utilityServiceClient;
            }
        }

        static EventRibbonServiceClient eventRibbonClient;
        public static EventRibbonServiceClient EventRibbonClient
        {
            get
            {
                if (eventRibbonClient == null)
                {
                    try
                    {
                        BasicHttpBinding binding = new BasicHttpBinding();
                        binding.MaxReceivedMessageSize = 10 * 1024 * 1024;
                        EndpointAddress address = new EndpointAddress("http://10.10.4.163:3396/Service2.svc");
                        eventRibbonClient = new EventRibbonServiceClient(binding, address);
                        eventRibbonClient.Open();
                    }
                    catch (Exception ex)
                    {
                        NsgSettings.ShowMessage(ex);
                    }
                }
                return eventRibbonClient;

            }
        }

        private void nsgButton2_AsyncClick(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var cmp = new NsgCompare(NsgLogicalOperator.Or).Add(Техника.Names.Наименование, "Самосвал", NsgComparison.Contain);
            cmp.Add(Техника.Names.Наименование, "МАН", NsgComparison.Contain);
            var техника = Техника.Новый().FindAll(cmp);
            int[] mass = new int[техника.Length];
            var listID = new Dictionary<Техника, int>();
            for (var i = 0; i < техника.Length; i++)
            {
                foreach (var строка in техника[i].СистемыСлежения.Rows)
                {
                    if (строка.ТипСистемыСлежения == ТипСистемыСлежения.Скаут)
                    {
                        mass[i] = Convert.ToInt32(строка.ИдентификаторСистемыСлежения);
                        listID.Add(техника[i], Convert.ToInt32(строка.ИдентификаторСистемыСлежения));
                    }    
                }
            }

            var cmpОбъекты = new NsgCompare().Add(Объекты.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var объекты = Объекты.Новый().FindAll(cmpОбъекты);

            var cmpГеозоны = new NsgCompare().Add(Геозоны.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var геозоны = Геозоны.Новый().FindAll(cmpГеозоны);

            SpicSoapStatisticsControllerServiceClient _statisticsClient = new SpicSoapStatisticsControllerServiceClient();
            _statisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            SpicSoapGeofenceVisitsStatisticsServiceClient _statisticsGeofenceVisitsClient = new SpicSoapGeofenceVisitsStatisticsServiceClient();
            _statisticsGeofenceVisitsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            SpicSoapNavigationFiltrationStatisticsServiceClient _statisticsNavigationFiltrationClient = new SpicSoapNavigationFiltrationStatisticsServiceClient();
            _statisticsNavigationFiltrationClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());

            vmoАнализДанных.Data.BeginUpdateData();
            vmoАнализДанных.Data.MemoryTable.Clear();
            var date = nsgPeriodPicker1.Period.Begin.Date;

            while (date <= NsgService.EndOfDay(nsgPeriodPicker1.Period.End))
            {
                foreach (var id in listID)
                {
                    var statisticsSessionRequest = new SpicStatisticsSessionRequest
                    {
                        Period = new ServiceReferenceControllerStistics.SpicDateTimeRange
                        {
                            Begin = date,
                            End = NsgService.EndOfDay(date)
                        },

                        TargetObject = new SpicObjectIdentity
                        {
                            ObjectTypeId = ObjectTypeId.Vehicle,
                            ObjectId = id.Value
                        }
                    };

                    //отправляем запрос и получаем сессию
                    var statisticsSession = _statisticsClient.StartStatisticsSession(statisticsSessionRequest).Session;
                    // на самом деле, это один и тот же контракт, но его нужно пересоздать  
                    var navigationFiltrationStatisticsSession = new SpicNavigationFiltrationStatisticsService.SpicStatisticsSession
                    {
                        StatisticsSessionId = statisticsSession.StatisticsSessionId,
                    };

                    var trackPeriodsFiler = new SpicNavigationFiltrationStatisticsService.SpicTrackPeriodsFilter
                    {
                        ExcludeRecoilPoints = false,
                        ExcludeNotMovePoints = false,
                        IncludeParkingPoints = true
                    };

                    var navigationValidationFilter = new SpicNavigationFiltrationStatisticsService.SpicNavigationValidationFilter
                    {
                        ExcludeInvalidPoints = false,
                        ExcludeValidPoints = false,
                        ExcludeNotValidatedPoints = false
                    };

                    var settingsNavigationFiltration = new SpicNavigationFiltrationStatisticsService.SpicNavigationFiltrationStatisticsSettings
                    {
                        NavigationValidationFilter = navigationValidationFilter,
                        TrackPeriodsFilter = trackPeriodsFiler
                    };

                    var navigationFiltrationStatisticsRequest = new SpicNavigationFiltrationStatisticsService.NavigationFiltrationStatisticsRequest
                    {
                        Session = navigationFiltrationStatisticsSession,
                        Settings = settingsNavigationFiltration
                    };

                    // добавляем запрос на построение статистики  
                    _statisticsNavigationFiltrationClient.AddStatisticsRequest(navigationFiltrationStatisticsRequest);

                    // запускаем построение  
                    _statisticsClient.StartBuild(statisticsSession);

                    var statisticsListNavigationFiltration = new List<SpicNavigationFiltrationStatistics>();
                    SpicNavigationFiltrationStatisticsResult statisticsResponseNavigationFiltration;

                    // выполняем, пока не получим последнюю порцию статистик  
                    do
                    {
                        // ждем, пока порция статистик построится  
                        do
                        {
                            statisticsResponseNavigationFiltration = _statisticsNavigationFiltrationClient.GetStatistics(navigationFiltrationStatisticsSession);

                            var navigationFiltration = statisticsResponseNavigationFiltration.Statistics;
                            if (navigationFiltration != null)
                            {
                                foreach (var point in navigationFiltration.Points)
                                {
                                    if (point.Navigation.Location != null)
                                    {
                                        var x = point.Navigation.Location.Longitude;
                                        var y = point.Navigation.Location.Latitude;
                                        NsgMemoryTableRow row = vmoАнализДанных.Data.MemoryTable.NewRow();

                                        foreach (var геозона in геозоны)
                                        {
                                            if (Math.Pow((x - (double)геозона.Долгота), 2) + Math.Pow((y - (double)геозона.Широта), 2) <= Math.Pow((double)геозона.РадиусГеозоны, 2))
                                            {
                                                row[Техника_vmoАнализДанных].Value = id.Key;
                                                row[Геозона_vmoАнализДанных].Value = геозона;
                                                row[ВремяПриездаВГеозону_vmoАнализДанных].Value = point.Timestamp;
                                            }
                                        }
                                        foreach (var объект in объекты)
                                        {
                                            if (Math.Pow((x - (double)объект.Долгота), 2) + Math.Pow((y - (double)объект.Широта), 2) <= Math.Pow((double)объект.РадиусГеозоны, 2))
                                            {
                                                row[Объект_vmoАнализДанных].Value = объект;
                                                row[ВремяПриездаНаОбъект_vmoАнализДанных].Value = point.Timestamp;
                                            }
                                        }

                                        row.Post();
                                    }
                                }
                            }                            
                        }
                        while (statisticsResponseNavigationFiltration.ChunkInfo.Status.Value == "Processing");

                        if (statisticsResponseNavigationFiltration.Statistics != null)
                            statisticsListNavigationFiltration.Add(statisticsResponseNavigationFiltration.Statistics);

                        // заказываем следующую порцию статистики  
                        _statisticsClient.BuildNextChunk(statisticsSession);
                    }
                    while (!statisticsResponseNavigationFiltration.ChunkInfo.IsFinalChunk);

                    // закрываем сессию построения статистик  
                    _statisticsClient.StopStatisticsSession(statisticsSession);
                }

                if (date.Day == DateTime.DaysInMonth(date.Year, date.Month))
                    date = new DateTime(date.Year, date.AddMonths(1).Month, date.AddDays(1).Day);
                else
                    date = new DateTime(date.Year, date.Month, date.AddDays(1).Day);
            }
            vmoАнализДанных.Data.UpdateDataAsync(this);
        }

        private void nsgButton3_AsyncClick(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SpicSoapStatisticsControllerServiceClient _statisticsClient = new SpicSoapStatisticsControllerServiceClient();
            _statisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            SpicSoapFuelingDefuelingStatisticsServiceClient _fuelDefuelStatisticClient = new SpicSoapFuelingDefuelingStatisticsServiceClient();
            _fuelDefuelStatisticClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            var cmpTech = new NsgCompare().Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
            var tech = Техника.Новый().FindAll(cmpTech);
            var unitIDName = new Dictionary<Техника, int>();

            foreach(var a in tech)
            {
                foreach (var item in a.СистемыСлежения.Rows)
                {
                    if (item.ТипСистемыСлежения == ТипСистемыСлежения.Скаут)
                        unitIDName.Add(a, Convert.ToInt32(item.ИдентификаторСистемыСлежения));
                }
            }

            vmo.Data.BeginUpdateData();
            vmo.Data.MemoryTable.Clear();
            var date = nsgPeriodPicker2.Period.Begin.Date;

            while (date <= NsgService.EndOfDay(nsgPeriodPicker2.Period.End))
            {
                foreach (var id in unitIDName)
                {
                    //создаем запрос сессии статистик
                    var statisticsSessionRequest = new SpicStatisticsSessionRequest
                    {
                        Period = new ServiceReferenceControllerStistics.SpicDateTimeRange
                        {
                            Begin = date,
                            End = NsgService.EndOfDay(date)
                        },

                        TargetObject = new SpicObjectIdentity
                        {
                            ObjectTypeId = ObjectTypeId.Vehicle,
                            ObjectId = id.Value
                        }
                    };

                    //отправляем запрос и получаем сессию
                    var statisticsSession = _statisticsClient.StartStatisticsSession(statisticsSessionRequest).Session;
                    // на самом деле, это один и тот же контракт, но его нужно пересоздать  
                    var fuelDefuelStatisticsSession = new ServiceReferenceFDStat.SpicStatisticsSession
                    {
                        StatisticsSessionId = statisticsSession.StatisticsSessionId,
                    };
                    // добавляем запрос на построение статистики  
                    _fuelDefuelStatisticClient.AddStatisticsRequest(fuelDefuelStatisticsSession);

                    // запускаем построение  
                    _statisticsClient.StartBuild(statisticsSession);

                    var statisticsListFuelDefuel = new List<SpicFuelingDefuelingStatistics>();
                    SpicFuelingDefuelingStatisticsResult statisticsResponseFuelDefuel;
                    SpicFuelingDefuelingStatistics fuelDefuel = null;

                    // выполняем, пока не получим последнюю порцию статистик  
                    do
                    {
                        // ждем, пока порция статистик построится  
                        do
                        {
                            statisticsResponseFuelDefuel = _fuelDefuelStatisticClient.GetStatistics(fuelDefuelStatisticsSession);

                            fuelDefuel = statisticsResponseFuelDefuel.Statistics;

                            if (fuelDefuel != null)
                            {
                                for (int i = fuelDefuel.Events.Length - 1; i >= 0; i--)
                                {
                                    if (fuelDefuel.Events[i].EventType.Value.Contains("Fueling"))
                                    {
                                        var item = fuelDefuel.Events[i];
                                        var row = vmo.Data.MemoryTable.NewRow();
                                        row[Техника_vmo].Value = id.Key;
                                        row[ОбъемЗаправки].Value = item.EndFuelVolumeL - item.BeginFuelVolumeL;
                                        row[ДатаПоследнейЗаправки].Value = item.Timestamp;
                                        row.Post();
                                        break;
                                    }
                                }
                            }
                        }
                        while (statisticsResponseFuelDefuel.ChunkInfo.Status.Value == "Processing");

                        if (statisticsResponseFuelDefuel.Statistics != null)
                            statisticsListFuelDefuel.Add(statisticsResponseFuelDefuel.Statistics);

                        // заказываем следующую порцию статистики  
                        _statisticsClient.BuildNextChunk(statisticsSession);
                    }
                    while (!statisticsResponseFuelDefuel.ChunkInfo.IsFinalChunk);

                    // закрываем сессию построения статистик  
                    _statisticsClient.StopStatisticsSession(statisticsSession);
                }

                if (date.Day == DateTime.DaysInMonth(date.Year, date.Month))
                    date = new DateTime(date.Year, date.AddMonths(1).Month, date.AddDays(1).Day);
                else
                    date = new DateTime(date.Year, date.Month, date.AddDays(1).Day);
            }
            vmo.Data.UpdateDataAsync(this);
        }
    }

    public class TrackingSystemsAll
    {
        public decimal totalHoursWorkshifts { get; set; }
        public decimal totalHoursSkayt { get; set; }
        public decimal totalHoursHistory { get; set; }
        public Техника tech { get; set; }
        public DateTime date { get; set; }
    }

    public class TrackingSystems
    {
        public Техника tech { get; set; }
        public DateTime date { get; set; }
        public decimal totalHours { get; set; }
        public TypeTrackingSystem typeSystem { get; set; }
    }

    public enum TypeTrackingSystem
    {
        Workshifts,
        Alarms,
        Skayt
    }

    public class DeserializeAuth
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
    }

    public class Unit
    {
        public int id { get; set; }
        public string name { get; set; }
        public string stateNumber { get; set; }
        public string garageNumber { get; set; }
        public string description { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public int? typeId { get; set; }
        public string deviceName { get; set; }
        public string brand { get; set; }
        public string vin { get; set; }
        public string registration { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public string owner { get; set; }
        public int companyId { get; set; }
        public string olson { get; set; }
        public object olsonDescription { get; set; }
        public string power { get; set; }
        public string terminalNumber { get; set; }
        public string terminalType { get; set; }
    }

    public class OnlineData
    {
        public int unitId { get; set; }
        public int status { get; set; }
        public int parkingStatus { get; set; }
        public DateTime? date { get; set; }
        public int? satellitesNumber { get; set; }
        public double? speed { get; set; }
        public double? fuelLevel { get; set; }
        public bool? isEngineWorking { get; set; }
        public string address { get; set; }
        public object driverName { get; set; }
        public int driverId { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public double? angle { get; set; }
    }

    public class Datum
    {
        public Unit unit { get; set; }
        public OnlineData onlineData { get; set; }
    }

    public class Result
    {
        public List<Datum> data { get; set; }
    }
}