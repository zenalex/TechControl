﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechControl.UtilityServiceWeb {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressInfo", Namespace="http://schemas.datacontract.org/2004/07/TitanUtilityService")]
    [System.SerializableAttribute()]
    public partial class AddressInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContractorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContractorGroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsTechieOnSiteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MonNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartnerOOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TechieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TechiePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long TimeTechieArrivedField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contractor {
            get {
                return this.ContractorField;
            }
            set {
                if ((object.ReferenceEquals(this.ContractorField, value) != true)) {
                    this.ContractorField = value;
                    this.RaisePropertyChanged("Contractor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractorGroup {
            get {
                return this.ContractorGroupField;
            }
            set {
                if ((object.ReferenceEquals(this.ContractorGroupField, value) != true)) {
                    this.ContractorGroupField = value;
                    this.RaisePropertyChanged("ContractorGroup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsTechieOnSite {
            get {
                return this.IsTechieOnSiteField;
            }
            set {
                if ((this.IsTechieOnSiteField.Equals(value) != true)) {
                    this.IsTechieOnSiteField = value;
                    this.RaisePropertyChanged("IsTechieOnSite");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Lat {
            get {
                return this.LatField;
            }
            set {
                if ((this.LatField.Equals(value) != true)) {
                    this.LatField = value;
                    this.RaisePropertyChanged("Lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Lon {
            get {
                return this.LonField;
            }
            set {
                if ((this.LonField.Equals(value) != true)) {
                    this.LonField = value;
                    this.RaisePropertyChanged("Lon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MonNumber {
            get {
                return this.MonNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.MonNumberField, value) != true)) {
                    this.MonNumberField = value;
                    this.RaisePropertyChanged("MonNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartnerOO {
            get {
                return this.PartnerOOField;
            }
            set {
                if ((object.ReferenceEquals(this.PartnerOOField, value) != true)) {
                    this.PartnerOOField = value;
                    this.RaisePropertyChanged("PartnerOO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Techie {
            get {
                return this.TechieField;
            }
            set {
                if ((object.ReferenceEquals(this.TechieField, value) != true)) {
                    this.TechieField = value;
                    this.RaisePropertyChanged("Techie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TechiePhone {
            get {
                return this.TechiePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TechiePhoneField, value) != true)) {
                    this.TechiePhoneField = value;
                    this.RaisePropertyChanged("TechiePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long TimeTechieArrived {
            get {
                return this.TimeTechieArrivedField;
            }
            set {
                if ((this.TimeTechieArrivedField.Equals(value) != true)) {
                    this.TimeTechieArrivedField = value;
                    this.RaisePropertyChanged("TimeTechieArrived");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NsgEmployee", Namespace="http://schemas.datacontract.org/2004/07/TitanUtilityService")]
    [System.SerializableAttribute()]
    public partial class NsgEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FatherNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TableNumberField;
        
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
        public string FatherName {
            get {
                return this.FatherNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FatherNameField, value) != true)) {
                    this.FatherNameField = value;
                    this.RaisePropertyChanged("FatherName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName {
            get {
                return this.SecondNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNameField, value) != true)) {
                    this.SecondNameField = value;
                    this.RaisePropertyChanged("SecondName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TableNumber {
            get {
                return this.TableNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.TableNumberField, value) != true)) {
                    this.TableNumberField = value;
                    this.RaisePropertyChanged("TableNumber");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NsgVisitation", Namespace="http://schemas.datacontract.org/2004/07/TitanUtilityService")]
    [System.SerializableAttribute()]
    public partial class NsgVisitation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MonNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PeriodField;
        
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
        public string MonNumber {
            get {
                return this.MonNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.MonNumberField, value) != true)) {
                    this.MonNumberField = value;
                    this.RaisePropertyChanged("MonNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Period {
            get {
                return this.PeriodField;
            }
            set {
                if ((object.ReferenceEquals(this.PeriodField, value) != true)) {
                    this.PeriodField = value;
                    this.RaisePropertyChanged("Period");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://TitanUtilityService.ITechControlUtilityWebService", ConfigurationName="UtilityServiceWeb.ITechControlUtilityWebService")]
    public interface ITechControlUtilityWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/IsAddressGuarded" +
            "ByPartners", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/IsAddressGuarded" +
            "ByPartnersResponse")]
        bool IsAddressGuardedByPartners(string monNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/IsAddressGuarded" +
            "ByPartners", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/IsAddressGuarded" +
            "ByPartnersResponse")]
        System.Threading.Tasks.Task<bool> IsAddressGuardedByPartnersAsync(string monNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressByMonN" +
            "umber", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressByMonN" +
            "umberResponse")]
        TechControl.UtilityServiceWeb.AddressInfo[] GetAddressByMonNumber(string monNum, string numType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressByMonN" +
            "umber", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressByMonN" +
            "umberResponse")]
        System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.AddressInfo[]> GetAddressByMonNumberAsync(string monNum, string numType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressesByMo" +
            "nNumber", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressesByMo" +
            "nNumberResponse")]
        TechControl.UtilityServiceWeb.AddressInfo[] GetAddressesByMonNumber(string[] monNums);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressesByMo" +
            "nNumber", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetAddressesByMo" +
            "nNumberResponse")]
        System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.AddressInfo[]> GetAddressesByMonNumberAsync(string[] monNums);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/MonNumbersToGetP" +
            "ushMessages", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/MonNumbersToGetP" +
            "ushMessagesResponse")]
        string[] MonNumbersToGetPushMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/MonNumbersToGetP" +
            "ushMessages", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/MonNumbersToGetP" +
            "ushMessagesResponse")]
        System.Threading.Tasks.Task<string[]> MonNumbersToGetPushMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/CreateLKPushMess" +
            "age", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/CreateLKPushMess" +
            "ageResponse")]
        void CreateLKPushMessage(string monNumber, string code, string LKStatus, string zone, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/CreateLKPushMess" +
            "age", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/CreateLKPushMess" +
            "ageResponse")]
        System.Threading.Tasks.Task CreateLKPushMessageAsync(string monNumber, string code, string LKStatus, string zone, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetObjectStatusS" +
            "tring", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetObjectStatusS" +
            "tringResponse")]
        string GetObjectStatusString(string monNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetObjectStatusS" +
            "tring", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetObjectStatusS" +
            "tringResponse")]
        System.Threading.Tasks.Task<string> GetObjectStatusStringAsync(string monNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetGBREmployees", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetGBREmployeesR" +
            "esponse")]
        TechControl.UtilityServiceWeb.NsgEmployee[] GetGBREmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetGBREmployees", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetGBREmployeesR" +
            "esponse")]
        System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.NsgEmployee[]> GetGBREmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetEmployeePhoto" +
            "", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetEmployeePhoto" +
            "Response")]
        string GetEmployeePhoto(string TabelNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetEmployeePhoto" +
            "", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetEmployeePhoto" +
            "Response")]
        System.Threading.Tasks.Task<string> GetEmployeePhotoAsync(string TabelNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "ts", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsResponse")]
        string GetRawCobraObjects(string[] fields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "ts", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsResponse")]
        System.Threading.Tasks.Task<string> GetRawCobraObjectsAsync(string[] fields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsOneObject", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsOneObjectResponse")]
        string GetRawCobraObjectsOneObject(string monNumber, string[] fields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsOneObject", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/GetRawCobraObjec" +
            "tsOneObjectResponse")]
        System.Threading.Tasks.Task<string> GetRawCobraObjectsOneObjectAsync(string monNumber, string[] fields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/FindGBRVisitatio" +
            "ns", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/FindGBRVisitatio" +
            "nsResponse")]
        TechControl.UtilityServiceWeb.NsgVisitation[] FindGBRVisitations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/FindGBRVisitatio" +
            "ns", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/FindGBRVisitatio" +
            "nsResponse")]
        System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.NsgVisitation[]> FindGBRVisitationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/AsteriskOriginat" +
            "e", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/AsteriskOriginat" +
            "eResponse")]
        void AsteriskOriginate(string clientPhone, string gbrPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/AsteriskOriginat" +
            "e", ReplyAction="http://TitanUtilityService.ITechControlUtilityWebService/ITechControlUtilityWebService/AsteriskOriginat" +
            "eResponse")]
        System.Threading.Tasks.Task AsteriskOriginateAsync(string clientPhone, string gbrPhone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITechControlUtilityWebServiceChannel : TechControl.UtilityServiceWeb.ITechControlUtilityWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UtilityWebServiceClient : System.ServiceModel.ClientBase<TechControl.UtilityServiceWeb.ITechControlUtilityWebService>, TechControl.UtilityServiceWeb.ITechControlUtilityWebService {
        
        public UtilityWebServiceClient() {
        }
        
        public UtilityWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UtilityWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UtilityWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UtilityWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsAddressGuardedByPartners(string monNum) {
            return base.Channel.IsAddressGuardedByPartners(monNum);
        }
        
        public System.Threading.Tasks.Task<bool> IsAddressGuardedByPartnersAsync(string monNum) {
            return base.Channel.IsAddressGuardedByPartnersAsync(monNum);
        }
        
        public TechControl.UtilityServiceWeb.AddressInfo[] GetAddressByMonNumber(string monNum, string numType) {
            return base.Channel.GetAddressByMonNumber(monNum, numType);
        }
        
        public System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.AddressInfo[]> GetAddressByMonNumberAsync(string monNum, string numType) {
            return base.Channel.GetAddressByMonNumberAsync(monNum, numType);
        }
        
        public TechControl.UtilityServiceWeb.AddressInfo[] GetAddressesByMonNumber(string[] monNums) {
            return base.Channel.GetAddressesByMonNumber(monNums);
        }
        
        public System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.AddressInfo[]> GetAddressesByMonNumberAsync(string[] monNums) {
            return base.Channel.GetAddressesByMonNumberAsync(monNums);
        }
        
        public string[] MonNumbersToGetPushMessages() {
            return base.Channel.MonNumbersToGetPushMessages();
        }
        
        public System.Threading.Tasks.Task<string[]> MonNumbersToGetPushMessagesAsync() {
            return base.Channel.MonNumbersToGetPushMessagesAsync();
        }
        
        public void CreateLKPushMessage(string monNumber, string code, string LKStatus, string zone, string user) {
            base.Channel.CreateLKPushMessage(monNumber, code, LKStatus, zone, user);
        }
        
        public System.Threading.Tasks.Task CreateLKPushMessageAsync(string monNumber, string code, string LKStatus, string zone, string user) {
            return base.Channel.CreateLKPushMessageAsync(monNumber, code, LKStatus, zone, user);
        }
        
        public string GetObjectStatusString(string monNumber) {
            return base.Channel.GetObjectStatusString(monNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetObjectStatusStringAsync(string monNumber) {
            return base.Channel.GetObjectStatusStringAsync(monNumber);
        }
        
        public TechControl.UtilityServiceWeb.NsgEmployee[] GetGBREmployees() {
            return base.Channel.GetGBREmployees();
        }
        
        public System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.NsgEmployee[]> GetGBREmployeesAsync() {
            return base.Channel.GetGBREmployeesAsync();
        }
        
        public string GetEmployeePhoto(string TabelNumber) {
            return base.Channel.GetEmployeePhoto(TabelNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetEmployeePhotoAsync(string TabelNumber) {
            return base.Channel.GetEmployeePhotoAsync(TabelNumber);
        }
        
        public string GetRawCobraObjects(string[] fields) {
            return base.Channel.GetRawCobraObjects(fields);
        }
        
        public System.Threading.Tasks.Task<string> GetRawCobraObjectsAsync(string[] fields) {
            return base.Channel.GetRawCobraObjectsAsync(fields);
        }
        
        public string GetRawCobraObjectsOneObject(string monNumber, string[] fields) {
            return base.Channel.GetRawCobraObjectsOneObject(monNumber, fields);
        }
        
        public System.Threading.Tasks.Task<string> GetRawCobraObjectsOneObjectAsync(string monNumber, string[] fields) {
            return base.Channel.GetRawCobraObjectsOneObjectAsync(monNumber, fields);
        }
        
        public TechControl.UtilityServiceWeb.NsgVisitation[] FindGBRVisitations() {
            return base.Channel.FindGBRVisitations();
        }
        
        public System.Threading.Tasks.Task<TechControl.UtilityServiceWeb.NsgVisitation[]> FindGBRVisitationsAsync() {
            return base.Channel.FindGBRVisitationsAsync();
        }
        
        public void AsteriskOriginate(string clientPhone, string gbrPhone) {
            base.Channel.AsteriskOriginate(clientPhone, gbrPhone);
        }
        
        public System.Threading.Tasks.Task AsteriskOriginateAsync(string clientPhone, string gbrPhone) {
            return base.Channel.AsteriskOriginateAsync(clientPhone, gbrPhone);
        }
    }
}
