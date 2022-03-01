using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NsgSoft.Database;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.ServiceReferenceControllerStistics;
using TechControl.ServiceReferenceDataOnline;
using TechControl.ServiceReferenceDataOnlineSensors;
using TechControl.ServiceReferenceTrackPeriods;
using TechControl.ServiceReferenceUnitsSpic;
using TechControl.ServiceReferenceValidationNavigation;
using TechControl.Метаданные._SystemTables;
using TechControl.ServiceReferenceMotorModes;
using TechControl.ServiceReferenceFDStat;
using NsgSoft.Common;

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
            var unitsCount = _client.GetAllUnitsCount();

            List<string> listModel = new List<string>();
            List<string> listBrand = new List<string>();
            List<int> listUnitID = new List<int>();
            Dictionary<int, string> unitIDName = new Dictionary<int, string>();
            //Создание запроса.
            var request = new SpicObjectsChunkRequest { Offset = 0, Count = unitsCount };
            var units = _client.GetAllUnitsPaged(request);
            foreach (var unit in units.Units)
            {
                listUnitID.Add(unit.UnitId);
                unitIDName.Add(unit.UnitId, unit.Name);
            }

            Dictionary<int, List<SpicFuelingDefuelingStatistics>> idStatisticsFuelDefuel = new Dictionary<int, List<SpicFuelingDefuelingStatistics>>();
            Dictionary<int, List<SpicMotorModesStatistics>> idStatisticsMotorModes = new Dictionary<int, List<SpicMotorModesStatistics>>();

            var date = nsgPeriodPicker1.Period.Begin.Date;

            while (date <= NsgService.EndOfDay(nsgPeriodPicker1.Period.End))
            {
                var cmpОтработанноеВремя = new NsgCompare().Add(ОтработанноеВремяТехники.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                cmpОтработанноеВремя.Add(ОтработанноеВремяТехники.Names.ДатаДокумента, date.Date, NsgComparison.GreaterOrEqual);
                cmpОтработанноеВремя.Add(ОтработанноеВремяТехники.Names.ДатаДокумента, NsgService.EndOfDay(date), NsgComparison.LessOrEqual);
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
                    докОтработанноеВремяТехники.ДатаДокумента = date;
                }
                else
                {
                    докОтработанноеВремяТехники = отработанноеВремя[0];
                    докОтработанноеВремяТехники.Edit();
                }

                foreach (var id in listUnitID)
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
                            ObjectId = id
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
                        }
                        while (statisticsResponseFuelDefuel.ChunkInfo.Status.Value == "Processing" && statisticsResponseMotorModes.ChunkInfo.Status.Value == "Processing");

                        var fuelDefuel = statisticsResponseFuelDefuel.Statistics;
                        var motorModes = statisticsResponseMotorModes.Statistics;

                        if (fuelDefuel == null || motorModes == null)
                            break;

                        DateTime beginDate = new DateTime();
                        DateTime endDate = new DateTime();
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
                            if (!motorModes.Periods[length - i].IsIgnitionOn)
                            {
                                endDate = motorModes.Periods[length - i].Period.End;
                                break;
                            }
                        }

                        var cmpTech = new NsgCompare().Add(Техника.Names.IdСкаут, id);
                        cmpTech.Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                        var tech = Техника.Новый().FindAll(cmpTech);
                        if (tech.Length > 0)
                        {
                            var beginFuelVolumeL = fuelDefuel.BeginFuelVolumeL;
                            var endFuelVolumeL = fuelDefuel.EndFuelVolumeL;
                            var totalVolumeOfFuelFilled = fuelDefuel.DefuelingTotalVolumeL;
                            var durationOfWork = (motorModes.EngineActiveWorkHours + motorModes.EngineIdleHours).TotalHours;

                            if (такоеВремяЕсть)
                            {
                                докОтработанноеВремяТехники.Таблица.DeleteAll();
                            }

                            var row = докОтработанноеВремяТехники.Таблица.NewRow();
                            row.Техника = tech[0];

                            if (beginFuelVolumeL != null)
                                row.НачальныйЗапасТоплива = (decimal)fuelDefuel.BeginFuelVolumeL;
                            else
                                row.НачальныйЗапасТоплива = 0;

                            if (endFuelVolumeL != null)
                                row.КонечныйЗапасТоплива = (decimal)fuelDefuel.EndFuelVolumeL;
                            else
                                row.КонечныйЗапасТоплива = 0;

                            if (totalVolumeOfFuelFilled != null)
                                row.общийОбъемЗаправленногоТоплива = (decimal)totalVolumeOfFuelFilled;
                            else
                                row.общийОбъемЗаправленногоТоплива = 0;

                            row.КоличествоЗаправок = fuelDefuel.DefuelingCount;
                            row.ДлительностьРаботы = (decimal)durationOfWork;
                            row.ДатаНачалаРаботы = beginDate;
                            row.ДатаОкончанияРаботы = endDate;
                            row.Post();
                        }

                        statisticsListFuelDefuel.Add(statisticsResponseFuelDefuel.Statistics);

                        statisticsListMotorModes.Add(statisticsResponseMotorModes.Statistics);

                        // заказываем следующую порцию статистики  
                        _statisticsClient.BuildNextChunk(statisticsSession);
                    }
                    while (!statisticsResponseFuelDefuel.ChunkInfo.IsFinalChunk && !statisticsResponseMotorModes.ChunkInfo.IsFinalChunk);

                    if (!idStatisticsFuelDefuel.ContainsKey(id))
                    {
                        idStatisticsFuelDefuel.Add(id, statisticsListFuelDefuel);
                    }

                    if (!idStatisticsMotorModes.ContainsKey(id))
                    {
                        idStatisticsMotorModes.Add(id, statisticsListMotorModes);
                    }

                    // закрываем сессию построения статистик  
                    _statisticsClient.StopStatisticsSession(statisticsSession);
                }
                докОтработанноеВремяТехники.Post();
                докОтработанноеВремяТехники.Handle();
                date = new DateTime(date.Year, date.Month, date.AddDays(1).Day);
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string dataAuth = "grant_type=password&username=skvortsov@titan002.ru&password=skvortsov@titan002.ru&locale=ru&client_id=8b1fd704-096e-42d6-9ba5-6d98980e7cd1&client_secret=scout-online";
            string urlAuth = "auth/token";
            var outputResultAuth = await RequestAsync(dataAuth, urlAuth, true, string.Empty);
            var deserializeJsonAuth = JsonConvert.DeserializeObject<DeserializeAuth>(outputResultAuth);

            string onlineDataUrl = $"?api-version=2.0&request.skip=0&request.take={unitsCount}&request.filter=All";
            var outputResultOnlineData = await RequestAsync(onlineDataUrl, string.Empty, false, deserializeJsonAuth.access_token);
            var deserializeJsonResult = JsonConvert.DeserializeObject<Result>(outputResultOnlineData);

            foreach (var data in deserializeJsonResult.data)
            {
                var online = data.onlineData;
                var unit = data.unit;

                var cmpTech = new NsgCompare().Add(Техника.Names.Наименование, unit.name);
                cmpTech.Add(Техника.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                var techIsReal = Техника.Новый().FindAll(cmpTech);
                var tech = Техника.Новый();

                if (techIsReal.Length == 0)
                {
                    tech.New();
                    tech.IdСкаут = $"{unit.id}";
                    tech.ГосНомер = unit.stateNumber;
                    tech.Наименование = unit.name;

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
                        var cmpType = new NsgCompare().Add(ТипТС.Names.Наименование, type);
                        cmpType.Add(ТипТС.Names.СостояниеДокумента, Сервис.СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                        var такойТипЕсть = ТипТС.Новый().FindAll(cmpType);
                        if (такойТипЕсть.Length == 0)
                        {
                            var модельНовая = ТипТС.Новый();
                            модельНовая.New();
                            модельНовая.Наименование = type;
                            модельНовая.Post();

                            tech.ТипТС = модельНовая;
                        }
                        else
                            tech.ТипТС = такойТипЕсть[0];
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

                рег.Техника = tech;
                рег.ТекущаяСкорость = (decimal)online.speed;
                рег.Долгота = (decimal)online.longitude;
                рег.Широта = (decimal)online.latitude;

                рег.AddMovement();
                рег.Post();
            }
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
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
        public DateTime date { get; set; }
        public int satellitesNumber { get; set; }
        public double speed { get; set; }
        public double? fuelLevel { get; set; }
        public bool? isEngineWorking { get; set; }
        public string address { get; set; }
        public object driverName { get; set; }
        public int driverId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double angle { get; set; }
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