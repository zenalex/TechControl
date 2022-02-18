using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using TechControl.ServiceReferenceControllerStistics;
using TechControl.ServiceReferenceDataOnline;
using TechControl.ServiceReferenceDataOnlineSensors;
using TechControl.ServiceReferenceTrackPeriods;
using TechControl.ServiceReferenceUnitsSpic;
using TechControl.ServiceReferenceValidationNavigation;

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

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);

            SpicSoapUnitsServiceClient _client = new SpicSoapUnitsServiceClient();
            SpicSoapOnlineDataServiceClient _dataServiceClient = new SpicSoapOnlineDataServiceClient();
            SpicSoapStatisticsControllerServiceClient _statisticsClient = new SpicSoapStatisticsControllerServiceClient();
            SpicSoapOnlineDataWithSensorsServiceClient _dataServiceSensorClient = new SpicSoapOnlineDataWithSensorsServiceClient();
            SpicSoapNavigationValidationStatisticsServiceClient _navigationValidationClient = new SpicSoapNavigationValidationStatisticsServiceClient();
            SpicSoapTrackPeriodsMileageStatisticsServiceClient _specificStatisticsClient = new SpicSoapTrackPeriodsMileageStatisticsServiceClient();

            // добавляем поведение авторизации перед связью с конечной точкой 
            _client.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _statisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _dataServiceSensorClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _navigationValidationClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());
            _specificStatisticsClient.Endpoint.Behaviors.Add(new AuthorizationBehavior());

            //Получить количество доступных объектов мониторинга.
            var unitsCount = _client.GetAllUnitsCount();

            //Создание запроса.
            var request = new SpicObjectsChunkRequest { Offset = 0, Count = unitsCount };
            var units = _client.GetAllUnitsPaged(request);

            Dictionary<int, double[]> locationCar = new Dictionary<int, double[]>();
            Dictionary<int, bool> objectWork = new Dictionary<int, bool>();
            Dictionary<int, string> typeObject = new Dictionary<int, string>();
            Dictionary<int, string> nameID = new Dictionary<int, string>();
            List<int> listUnitID = new List<int>();
            List<string> listModel = new List<string>();
            List<string> listBrand = new List<string>();

            foreach (var unit in units.Units)
            {
                var id = unit.UnitId;
                var brand = unit.Brand;
                var model = unit.Model;
                var type = $"{unit.UnitTypeId}";

                listUnitID.Add(id);

                var tech = Техника.Новый();
                tech.New();
                tech.ГосНомер = unit.StateNumber;
                tech.IdСкаут = $"{id}";

                if(!listModel.Contains(model))
                {
                    listModel.Add(model);
                    var cmpModel = new NsgCompare().Add(Модель.Names.Наименование, model);
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

                if (!listBrand.Contains(brand))
                {
                    listBrand.Add(brand);
                    var cmpBrand = new NsgCompare().Add(Марка.Names.Наименование, brand);
                    var такаяМодельЕсть = Марка.Новый().FindAll(cmpBrand);
                    if (такаяМодельЕсть.Length == 0)
                    {
                        var модельНовая = Марка.Новый();
                        модельНовая.New();
                        модельНовая.Наименование = brand;
                        модельНовая.Post();

                        tech.Марка = модельНовая;
                    }
                    else
                        tech.Марка = такаяМодельЕсть[0];
                }

                if (unit.UnitTypeId == null)
                {
                    tech.ТипТС = null;
                }    
                else
                {
                    var cmpType = new NsgCompare().Add(ТипТС.Names.Наименование, type);
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

                nameID.Add(id, unit.Name);
            }

            var subscription = new SpicOnlineDataSubscriptionRequest { UnitIds = listUnitID.ToArray() };
            var response = _dataServiceClient.Subscribe(subscription);
            var onlineData = _dataServiceClient.GetOnlineData(new SpicOnlineDataSessionId { Id = response.SessionId.Value.Id });

            var b = Convert.ToUInt16(20000);
            var k = Convert.ToUInt16(32800);
            var c = new ushort[1];
            for (var i = 0; i < c.Length; i++)
            {
                c[i] = b;
            }

            foreach (var id in listUnitID)
            {
                var listId = new List<int>();
                listId.Add(id);

                var subscribeSensors = new SpicOnlineDataWithSensorsSubscriptionRequest { UnitIds = listId.ToArray(), SensorTypes = c };
                var responseSensors = _dataServiceSensorClient.Subscribe(subscribeSensors);
                var onlineDataSensors = _dataServiceSensorClient.GetOnlineData(new SpicOnlineDataWithSensorsSessionId { Id = responseSensors.SessionId.Value.Id });

                foreach (var data in onlineDataSensors.OnlineDataWithSensorsCollection.DataCollection)
                {
                    foreach (var sensor in data.Sensors)
                    {
                        if (sensor.SensorNumber == k)
                        {
                            bool work = false;
                            if (sensor.SensorValue == "True")
                                work = true;

                            objectWork.Add(id, work);
                        }
                    }
                }
            }

            foreach (var data in onlineData.OnlineDataCollection.DataCollection)
            {
                double[] xy = new double[2];
                xy[0] = data.Navigation.Location.Longitude;
                xy[1] = data.Navigation.Location.Latitude;
                foreach (var id in listUnitID)
                {
                    if (!locationCar.ContainsKey(id))
                    {
                        locationCar.Add(id, xy);
                        break;
                    }
                }
            }

            foreach (var id in listUnitID)
            {
                //создаем запрос сессии статистик
                var statisticsSessionRequest = new SpicStatisticsSessionRequest
                {
                    Period = new ServiceReferenceControllerStistics.SpicDateTimeRange
                    {
                        Begin = DateTime.Now.AddDays(-1).Date,
                        End = DateTime.Now.Date
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
                var specificStatisticsSession = new ServiceReferenceTrackPeriods.SpicStatisticsSession
                {
                    StatisticsSessionId = statisticsSession.StatisticsSessionId,
                };

                // добавляем запрос на построение статистики  
                _specificStatisticsClient.AddStatisticsRequest(specificStatisticsSession);
                // запускаем построение  
                _statisticsClient.StartBuild(statisticsSession);

                var statisticsListPeriodsMileage = new List<SpicTrackPeriodsMileageStatistics>();
                SpicTrackPeriodsMileageStatisticsResult statisticsResponse;

                // выполняем, пока не получим последнюю порцию статистик  
                do
                {
                    // ждем, пока порция статистик построится  
                    do
                    {
                        statisticsResponse = _specificStatisticsClient.GetStatistics(specificStatisticsSession);
                    }
                    while (statisticsResponse.ChunkInfo.Status.Value == "Processing");

                    statisticsListPeriodsMileage.Add(statisticsResponse.Statistics);

                    // заказываем следующую порцию статистики  
                    _statisticsClient.BuildNextChunk(statisticsSession);
                }
                while (!statisticsResponse.ChunkInfo.IsFinalChunk);

                // закрываем сессию построения статистик  
                _statisticsClient.StopStatisticsSession(statisticsSession);
            }
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        private string GetTypeCar(int i)
        {
            string typeCar = string.Empty;
            switch (i)
            {
                case 10:
                    typeCar = "Экскаватор";
                    break;
                case 5:
                    typeCar = "Самосвал";
                    break;
                case 11:
                    typeCar = "Погрузчик";
                    break;
                case 9:
                    typeCar = "Бульдозер";
                    break;
                case 17:
                    typeCar = "Дорожная техника";
                    break;
                case 4:
                    typeCar = "Автокран";
                    break;
                case 6:
                    typeCar = "Автовоз";
                    break;
                case 21:
                    typeCar = "Технический";
                    break;
                case 3:
                    typeCar = "Седельный тягач";
                    break;
                case 1:
                    typeCar = "Легковой автомобиль";
                    break;
                case 2:
                    typeCar = "Бортовой грузовой";
                    break;
                case 18:
                    typeCar = "Человек";
                    break;
            }
            return typeCar;
        }
    }
}