﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechControl.EventRibbonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RibbonEventObject", Namespace="http://schemas.datacontract.org/2004/07/Titan")]
    [System.SerializableAttribute()]
    public partial class RibbonEventObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatetimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MclassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Datetime {
            get {
                return this.DatetimeField;
            }
            set {
                if ((this.DatetimeField.Equals(value) != true)) {
                    this.DatetimeField = value;
                    this.RaisePropertyChanged("Datetime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Desc {
            get {
                return this.DescField;
            }
            set {
                if ((object.ReferenceEquals(this.DescField, value) != true)) {
                    this.DescField = value;
                    this.RaisePropertyChanged("Desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mclass {
            get {
                return this.MclassField;
            }
            set {
                if ((object.ReferenceEquals(this.MclassField, value) != true)) {
                    this.MclassField = value;
                    this.RaisePropertyChanged("Mclass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Titan.IEventRibbonService", ConfigurationName="EventRibbonService.IEventRibbonService")]
    public interface IEventRibbonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWODate", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWODateRespons" +
            "e")]
        TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWODate(string monitoringNumber, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWODate", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWODateRespons" +
            "e")]
        System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWODateAsync(string monitoringNumber, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWOneDate", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWOneDateRespo" +
            "nse")]
        TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWOneDate(string monitoringNumber, System.DateTime start, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWOneDate", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWOneDateRespo" +
            "nse")]
        System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWOneDateAsync(string monitoringNumber, System.DateTime start, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDates", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesResp" +
            "onse")]
        TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWTwoDates(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDates", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesResp" +
            "onse")]
        System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWTwoDatesAsync(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesAndC" +
            "odes", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesAndC" +
            "odesResponse")]
        TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWTwoDatesAndCodes(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents, string[] allowedCodes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesAndC" +
            "odes", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetRibbonEventsWTwoDatesAndC" +
            "odesResponse")]
        System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWTwoDatesAndCodesAsync(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents, string[] allowedCodes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetObjectStatusHistory", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetObjectStatusHistoryRespon" +
            "se")]
        System.Tuple<long, bool>[] GetObjectStatusHistory(string monitoringNumber, System.DateTime start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetObjectStatusHistory", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetObjectStatusHistoryRespon" +
            "se")]
        System.Threading.Tasks.Task<System.Tuple<long, bool>[]> GetObjectStatusHistoryAsync(string monitoringNumber, System.DateTime start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/ReceiveShurgardMessage", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/ReceiveShurgardMessageRespon" +
            "se")]
        bool ReceiveShurgardMessage(string monNum, string code, string message, string zone, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/ReceiveShurgardMessage", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/ReceiveShurgardMessageRespon" +
            "se")]
        System.Threading.Tasks.Task<bool> ReceiveShurgardMessageAsync(string monNum, string code, string message, string zone, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetButtonAlarms", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetButtonAlarmsResponse")]
        bool GetButtonAlarms(string monNum, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/GetButtonAlarms", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/GetButtonAlarmsResponse")]
        System.Threading.Tasks.Task<bool> GetButtonAlarmsAsync(string monNum, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/IsAlarmWithKeywords", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/IsAlarmWithKeywordsResponse")]
        bool IsAlarmWithKeywords(string monNum, string[] keywords);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Titan.IEventRibbonService/IEventRibbonService/IsAlarmWithKeywords", ReplyAction="http://Titan.IEventRibbonService/IEventRibbonService/IsAlarmWithKeywordsResponse")]
        System.Threading.Tasks.Task<bool> IsAlarmWithKeywordsAsync(string monNum, string[] keywords);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventRibbonServiceChannel : TechControl.EventRibbonService.IEventRibbonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventRibbonServiceClient : System.ServiceModel.ClientBase<TechControl.EventRibbonService.IEventRibbonService>, TechControl.EventRibbonService.IEventRibbonService {
        
        public EventRibbonServiceClient() {
        }
        
        public EventRibbonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventRibbonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventRibbonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventRibbonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWODate(string monitoringNumber, int maxEvents) {
            return base.Channel.GetRibbonEventsWODate(monitoringNumber, maxEvents);
        }
        
        public System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWODateAsync(string monitoringNumber, int maxEvents) {
            return base.Channel.GetRibbonEventsWODateAsync(monitoringNumber, maxEvents);
        }
        
        public TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWOneDate(string monitoringNumber, System.DateTime start, int maxEvents) {
            return base.Channel.GetRibbonEventsWOneDate(monitoringNumber, start, maxEvents);
        }
        
        public System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWOneDateAsync(string monitoringNumber, System.DateTime start, int maxEvents) {
            return base.Channel.GetRibbonEventsWOneDateAsync(monitoringNumber, start, maxEvents);
        }
        
        public TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWTwoDates(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents) {
            return base.Channel.GetRibbonEventsWTwoDates(monitoringNumber, start, end, maxEvents);
        }
        
        public System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWTwoDatesAsync(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents) {
            return base.Channel.GetRibbonEventsWTwoDatesAsync(monitoringNumber, start, end, maxEvents);
        }
        
        public TechControl.EventRibbonService.RibbonEventObject[] GetRibbonEventsWTwoDatesAndCodes(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents, string[] allowedCodes) {
            return base.Channel.GetRibbonEventsWTwoDatesAndCodes(monitoringNumber, start, end, maxEvents, allowedCodes);
        }
        
        public System.Threading.Tasks.Task<TechControl.EventRibbonService.RibbonEventObject[]> GetRibbonEventsWTwoDatesAndCodesAsync(string monitoringNumber, System.DateTime start, System.DateTime end, int maxEvents, string[] allowedCodes) {
            return base.Channel.GetRibbonEventsWTwoDatesAndCodesAsync(monitoringNumber, start, end, maxEvents, allowedCodes);
        }
        
        public System.Tuple<long, bool>[] GetObjectStatusHistory(string monitoringNumber, System.DateTime start) {
            return base.Channel.GetObjectStatusHistory(monitoringNumber, start);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<long, bool>[]> GetObjectStatusHistoryAsync(string monitoringNumber, System.DateTime start) {
            return base.Channel.GetObjectStatusHistoryAsync(monitoringNumber, start);
        }
        
        public bool ReceiveShurgardMessage(string monNum, string code, string message, string zone, string user) {
            return base.Channel.ReceiveShurgardMessage(monNum, code, message, zone, user);
        }
        
        public System.Threading.Tasks.Task<bool> ReceiveShurgardMessageAsync(string monNum, string code, string message, string zone, string user) {
            return base.Channel.ReceiveShurgardMessageAsync(monNum, code, message, zone, user);
        }
        
        public bool GetButtonAlarms(string monNum, System.DateTime time) {
            return base.Channel.GetButtonAlarms(monNum, time);
        }
        
        public System.Threading.Tasks.Task<bool> GetButtonAlarmsAsync(string monNum, System.DateTime time) {
            return base.Channel.GetButtonAlarmsAsync(monNum, time);
        }
        
        public bool IsAlarmWithKeywords(string monNum, string[] keywords) {
            return base.Channel.IsAlarmWithKeywords(monNum, keywords);
        }
        
        public System.Threading.Tasks.Task<bool> IsAlarmWithKeywordsAsync(string monNum, string[] keywords) {
            return base.Channel.IsAlarmWithKeywordsAsync(monNum, keywords);
        }
    }
}
