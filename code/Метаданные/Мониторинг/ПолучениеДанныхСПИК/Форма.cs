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

            SpicSoapUnitsServiceClient _client = new SpicSoapUnitsServiceClient();
            SpicSoapOnlineDataServiceClient _dataServiceClient = new SpicSoapOnlineDataServiceClient();
            SpicSoapStatisticsControllerServiceClient _statisticsClient = new SpicSoapStatisticsControllerServiceClient();
            SpicSoapOnlineDataWithSensorsServiceClient _dataServiceSensorClient = new SpicSoapOnlineDataWithSensorsServiceClient();
            SpicSoapNavigationValidationStatisticsServiceClient _navigationValidationClient = new SpicSoapNavigationValidationStatisticsServiceClient();
            SpicSoapTrackPeriodsMileageStatisticsServiceClient _specificStatisticsClient = new SpicSoapTrackPeriodsMileageStatisticsServiceClient();
            SpicSoapMotorModesStatisticsServiceClient _motorModesClient = new SpicSoapMotorModesStatisticsServiceClient();

            // добавляем поведение авторизации перед связью с конечной точкой 
            _client.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _statisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceSensorClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _navigationValidationClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _specificStatisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _motorModesClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());

            //Получить количество доступных объектов мониторинга.
            var unitsCount = _client.GetAllUnitsCount();

            List<string> listModel = new List<string>();
            List<string> listBrand = new List<string>();
            List<int> listUnitID = new List<int>();

            //Создание запроса.
            var request = new SpicObjectsChunkRequest { Offset = 0, Count = unitsCount };
            var units = _client.GetAllUnitsPaged(request);
            foreach(var unit in units.Units)
            {
                listUnitID.Add(unit.UnitId);
            }

            Dictionary<int, List<SpicMotorModesStatistics>> idStatistic = new Dictionary<int, List<SpicMotorModesStatistics>>();
            List<int> listHavy = new List<int>();
            foreach (var id in listUnitID)
            {
                //создаем запрос сессии статистик
                var statisticsSessionRequest = new SpicStatisticsSessionRequest
                {
                    Period = new ServiceReferenceControllerStistics.SpicDateTimeRange
                    {
                        Begin = DateTime.Now.AddDays(-1).Date,
                        End = DateTime.Now
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
                var motorModesStatisticsSession = new ServiceReferenceMotorModes.SpicStatisticsSession
                {
                    StatisticsSessionId = statisticsSession.StatisticsSessionId,
                };

                // добавляем запрос на построение статистики  
                _motorModesClient.AddStatisticsRequest(motorModesStatisticsSession);
                // запускаем построение  
                _statisticsClient.StartBuild(statisticsSession);

                var statisticsListPeriodsMileage = new List<SpicMotorModesStatistics>();
                SpicMotorModesStatisticsResult statisticsResponse;

                // выполняем, пока не получим последнюю порцию статистик  
                do
                {
                    // ждем, пока порция статистик построится  
                    do
                    {
                        statisticsResponse = _motorModesClient.GetStatistics(motorModesStatisticsSession);
                    }
                    while (statisticsResponse.ChunkInfo.Status.Value == "Processing");

                    statisticsListPeriodsMileage.Add(statisticsResponse.Statistics);
                    var length = statisticsResponse.Statistics.Periods.Length;

                    if (length > 1)
                    {
                        if (statisticsResponse.Statistics.Periods[length - 1].Period.End > DateTime.Now.Date && statisticsResponse.Statistics.Periods[length - 1].IsActiveWork)
                        {
                            if (!listHavy.Contains(id))
                                listHavy.Add(id);
                        }
                    }

                    if (!idStatistic.ContainsKey(id))
                    {
                        idStatistic.Add(id, statisticsListPeriodsMileage);
                    }

                    // заказываем следующую порцию статистики  
                    _statisticsClient.BuildNextChunk(statisticsSession);
                }
                while (!statisticsResponse.ChunkInfo.IsFinalChunk);

                // закрываем сессию построения статистик  
                _statisticsClient.StopStatisticsSession(statisticsSession);
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string dataAuth = "grant_type=password&username=skvortsov@titan002.ru&password=skvortsov@titan002.ru&locale=ru&client_id=8b1fd704-096e-42d6-9ba5-6d98980e7cd1&client_secret=scout-online";
            string urlAuth = "auth/token";
            var outputResultAuth = await RequestAsync(dataAuth, urlAuth, true, string.Empty);
            var deserializeJsonAuth = JsonConvert.DeserializeObject<DeserializeAuth>(outputResultAuth);

            string onlineDataUrl = $"?api-version=2.0&request.skip=0&request.take={unitsCount}&request.filter=All";
            var outputResultOnlineData = await RequestAsync(onlineDataUrl, string.Empty, false, deserializeJsonAuth.access_token);
            var deserializeJsonResult = JsonConvert.DeserializeObject<Result>(outputResultOnlineData);

            var рег = МониторирнгТехники.Новый();
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

                рег.ПодНагрузкой = false;
                foreach (var id in listHavy)
                {
                    if (unit.id == id)
                    {
                        рег.ПодНагрузкой = true;
                        break;
                    }
                }

                рег.AddMovement();
            }
            рег.Post();
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