﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS_Server.ReportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DailyReport", Namespace="http://schemas.datacontract.org/2004/07/PetroFexHQ.Services")]
    [System.SerializableAttribute()]
    public partial class DailyReport : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PSS_Server.ReportService.FuelData[] PurchasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PSS_Server.ReportService.FuelData[] SalesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StationIdField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PSS_Server.ReportService.FuelData[] Purchases {
            get {
                return this.PurchasesField;
            }
            set {
                if ((object.ReferenceEquals(this.PurchasesField, value) != true)) {
                    this.PurchasesField = value;
                    this.RaisePropertyChanged("Purchases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PSS_Server.ReportService.FuelData[] Sales {
            get {
                return this.SalesField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesField, value) != true)) {
                    this.SalesField = value;
                    this.RaisePropertyChanged("Sales");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StationId {
            get {
                return this.StationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.StationIdField, value) != true)) {
                    this.StationIdField = value;
                    this.RaisePropertyChanged("StationId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FuelData", Namespace="http://schemas.datacontract.org/2004/07/PetroFexHQ.Services")]
    [System.SerializableAttribute()]
    public partial class FuelData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FuelTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValueField;
        
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
        public string FuelType {
            get {
                return this.FuelTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FuelTypeField, value) != true)) {
                    this.FuelTypeField = value;
                    this.RaisePropertyChanged("FuelType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReportService.IReportService")]
    public interface IReportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportService/SendDailyReport", ReplyAction="http://tempuri.org/IReportService/SendDailyReportResponse")]
        string SendDailyReport(PSS_Server.ReportService.DailyReport report);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServiceChannel : PSS_Server.ReportService.IReportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportServiceClient : System.ServiceModel.ClientBase<PSS_Server.ReportService.IReportService>, PSS_Server.ReportService.IReportService {
        
        public ReportServiceClient() {
        }
        
        public ReportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SendDailyReport(PSS_Server.ReportService.DailyReport report) {
            return base.Channel.SendDailyReport(report);
        }
    }
}
