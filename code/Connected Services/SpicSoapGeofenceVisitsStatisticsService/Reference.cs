﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechControl.SpicSoapGeofenceVisitsStatisticsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisitStatisticRequest", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisitStatisticRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession SessionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticSettings SettingsField;
        
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
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession Session {
            get {
                return this.SessionField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionField, value) != true)) {
                    this.SessionField = value;
                    this.RaisePropertyChanged("Session");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticSettings Settings {
            get {
                return this.SettingsField;
            }
            set {
                if ((object.ReferenceEquals(this.SettingsField, value) != true)) {
                    this.SettingsField = value;
                    this.RaisePropertyChanged("Settings");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicStatisticsSession", Namespace="http://schemas.datacontract.org/2004/07/Scout.Plugins.Spic.Server.Statistics.Cont" +
        "roller")]
    [System.SerializableAttribute()]
    public partial class SpicStatisticsSession : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid StatisticsSessionIdField;
        
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
        public System.Guid StatisticsSessionId {
            get {
                return this.StatisticsSessionIdField;
            }
            set {
                if ((this.StatisticsSessionIdField.Equals(value) != true)) {
                    this.StatisticsSessionIdField = value;
                    this.RaisePropertyChanged("StatisticsSessionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisitStatisticSettings", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisitStatisticSettings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExcludeVisitsWithoutParkingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticsSettingsItem[] GeofencesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinTimeBetweenSameGeoZoneVisitSecondsField;
        
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
        public bool ExcludeVisitsWithoutParkings {
            get {
                return this.ExcludeVisitsWithoutParkingsField;
            }
            set {
                if ((this.ExcludeVisitsWithoutParkingsField.Equals(value) != true)) {
                    this.ExcludeVisitsWithoutParkingsField = value;
                    this.RaisePropertyChanged("ExcludeVisitsWithoutParkings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticsSettingsItem[] Geofences {
            get {
                return this.GeofencesField;
            }
            set {
                if ((object.ReferenceEquals(this.GeofencesField, value) != true)) {
                    this.GeofencesField = value;
                    this.RaisePropertyChanged("Geofences");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinTimeBetweenSameGeoZoneVisitSeconds {
            get {
                return this.MinTimeBetweenSameGeoZoneVisitSecondsField;
            }
            set {
                if ((this.MinTimeBetweenSameGeoZoneVisitSecondsField.Equals(value) != true)) {
                    this.MinTimeBetweenSameGeoZoneVisitSecondsField = value;
                    this.RaisePropertyChanged("MinTimeBetweenSameGeoZoneVisitSeconds");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisitStatisticsSettingsItem", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisitStatisticsSettingsItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GeofenceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinVisitTimeSecondsField;
        
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
        public int GeofenceId {
            get {
                return this.GeofenceIdField;
            }
            set {
                if ((this.GeofenceIdField.Equals(value) != true)) {
                    this.GeofenceIdField = value;
                    this.RaisePropertyChanged("GeofenceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinVisitTimeSeconds {
            get {
                return this.MinVisitTimeSecondsField;
            }
            set {
                if ((this.MinVisitTimeSecondsField.Equals(value) != true)) {
                    this.MinVisitTimeSecondsField = value;
                    this.RaisePropertyChanged("MinVisitTimeSeconds");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicAddonStatisticsResult", Namespace="http://schemas.datacontract.org/2004/07/Scout.Plugins.Spic.Server.Statistics.Conc" +
        "rete")]
    [System.SerializableAttribute()]
    public partial class SpicAddonStatisticsResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsOperationResult StatusField;
        
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
        public string ErrorText {
            get {
                return this.ErrorTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTextField, value) != true)) {
                    this.ErrorTextField = value;
                    this.RaisePropertyChanged("ErrorText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsOperationResult Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicStatisticsOperationResult", Namespace="http://schemas.datacontract.org/2004/07/Scout.Plugins.Spic.Server.Infrastructure." +
        "Data")]
    [System.SerializableAttribute()]
    public partial class SpicStatisticsOperationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisitStatisticResult", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisitStatisticResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsChunkInfo ChunkInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatistic StatisticsField;
        
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
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsChunkInfo ChunkInfo {
            get {
                return this.ChunkInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ChunkInfoField, value) != true)) {
                    this.ChunkInfoField = value;
                    this.RaisePropertyChanged("ChunkInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatistic Statistics {
            get {
                return this.StatisticsField;
            }
            set {
                if ((object.ReferenceEquals(this.StatisticsField, value) != true)) {
                    this.StatisticsField = value;
                    this.RaisePropertyChanged("Statistics");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicStatisticsChunkInfo", Namespace="http://schemas.datacontract.org/2004/07/Scout.Plugins.Spic.Server.Statistics.Conc" +
        "rete")]
    [System.SerializableAttribute()]
    public partial class SpicStatisticsChunkInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ChunkNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsFinalChunkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicDateTimeRange PeriodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsOperationResult StatusField;
        
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
        public int ChunkNumber {
            get {
                return this.ChunkNumberField;
            }
            set {
                if ((this.ChunkNumberField.Equals(value) != true)) {
                    this.ChunkNumberField = value;
                    this.RaisePropertyChanged("ChunkNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorText {
            get {
                return this.ErrorTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTextField, value) != true)) {
                    this.ErrorTextField = value;
                    this.RaisePropertyChanged("ErrorText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsFinalChunk {
            get {
                return this.IsFinalChunkField;
            }
            set {
                if ((this.IsFinalChunkField.Equals(value) != true)) {
                    this.IsFinalChunkField = value;
                    this.RaisePropertyChanged("IsFinalChunk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicDateTimeRange Period {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsOperationResult Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisitStatistic", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisitStatistic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnitIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnitNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisit[] VisitsField;
        
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
        public int UnitId {
            get {
                return this.UnitIdField;
            }
            set {
                if ((this.UnitIdField.Equals(value) != true)) {
                    this.UnitIdField = value;
                    this.RaisePropertyChanged("UnitId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnitName {
            get {
                return this.UnitNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UnitNameField, value) != true)) {
                    this.UnitNameField = value;
                    this.RaisePropertyChanged("UnitName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisit[] Visits {
            get {
                return this.VisitsField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitsField, value) != true)) {
                    this.VisitsField = value;
                    this.RaisePropertyChanged("Visits");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicDateTimeRange", Namespace="http://schemas.datacontract.org/2004/07/Scout.Plugins.Spic.Server.Infrastructure." +
        "Data")]
    [System.SerializableAttribute()]
    public partial class SpicDateTimeRange : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BeginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndField;
        
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
        public System.DateTime Begin {
            get {
                return this.BeginField;
            }
            set {
                if ((this.BeginField.Equals(value) != true)) {
                    this.BeginField = value;
                    this.RaisePropertyChanged("Begin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime End {
            get {
                return this.EndField;
            }
            set {
                if ((this.EndField.Equals(value) != true)) {
                    this.EndField = value;
                    this.RaisePropertyChanged("End");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpicGeofenceVisit", Namespace="http://schemas.datacontract.org/2004/07/Scout.Platform.Components.TrackServer.Spi" +
        "c.GeofenceVisitsStat")]
    [System.SerializableAttribute()]
    public partial class SpicGeofenceVisit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeofenceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GeozoneIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double InnerMileageKmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicDateTimeRange PeriodField;
        
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
        public string GeofenceName {
            get {
                return this.GeofenceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GeofenceNameField, value) != true)) {
                    this.GeofenceNameField = value;
                    this.RaisePropertyChanged("GeofenceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GeozoneId {
            get {
                return this.GeozoneIdField;
            }
            set {
                if ((this.GeozoneIdField.Equals(value) != true)) {
                    this.GeozoneIdField = value;
                    this.RaisePropertyChanged("GeozoneId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double InnerMileageKm {
            get {
                return this.InnerMileageKmField;
            }
            set {
                if ((this.InnerMileageKmField.Equals(value) != true)) {
                    this.InnerMileageKmField = value;
                    this.RaisePropertyChanged("InnerMileageKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicDateTimeRange Period {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SpicSoapGeofenceVisitsStatisticsService.ISpicSoapGeofenceVisitsStatisticsService")]
    public interface ISpicSoapGeofenceVisitsStatisticsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/AddStatisticsRequest", ReplyAction="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/AddStatisticsRequestR" +
            "esponse")]
        TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicAddonStatisticsResult AddStatisticsRequest(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticRequest session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/AddStatisticsRequest", ReplyAction="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/AddStatisticsRequestR" +
            "esponse")]
        System.Threading.Tasks.Task<TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicAddonStatisticsResult> AddStatisticsRequestAsync(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticRequest session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/GetStatistics", ReplyAction="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/GetStatisticsResponse" +
            "")]
        TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticResult GetStatistics(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/GetStatistics", ReplyAction="http://tempuri.org/ISpicSoapGeofenceVisitsStatisticsService/GetStatisticsResponse" +
            "")]
        System.Threading.Tasks.Task<TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticResult> GetStatisticsAsync(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession session);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISpicSoapGeofenceVisitsStatisticsServiceChannel : TechControl.SpicSoapGeofenceVisitsStatisticsService.ISpicSoapGeofenceVisitsStatisticsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SpicSoapGeofenceVisitsStatisticsServiceClient : System.ServiceModel.ClientBase<TechControl.SpicSoapGeofenceVisitsStatisticsService.ISpicSoapGeofenceVisitsStatisticsService>, TechControl.SpicSoapGeofenceVisitsStatisticsService.ISpicSoapGeofenceVisitsStatisticsService {
        
        public SpicSoapGeofenceVisitsStatisticsServiceClient() {
        }
        
        public SpicSoapGeofenceVisitsStatisticsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SpicSoapGeofenceVisitsStatisticsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SpicSoapGeofenceVisitsStatisticsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SpicSoapGeofenceVisitsStatisticsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicAddonStatisticsResult AddStatisticsRequest(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticRequest session) {
            return base.Channel.AddStatisticsRequest(session);
        }
        
        public System.Threading.Tasks.Task<TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicAddonStatisticsResult> AddStatisticsRequestAsync(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticRequest session) {
            return base.Channel.AddStatisticsRequestAsync(session);
        }
        
        public TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticResult GetStatistics(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession session) {
            return base.Channel.GetStatistics(session);
        }
        
        public System.Threading.Tasks.Task<TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicGeofenceVisitStatisticResult> GetStatisticsAsync(TechControl.SpicSoapGeofenceVisitsStatisticsService.SpicStatisticsSession session) {
            return base.Channel.GetStatisticsAsync(session);
        }
    }
}
