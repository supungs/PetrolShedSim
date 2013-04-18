﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS_POS.PosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FuelItem", Namespace="http://schemas.datacontract.org/2004/07/PSS_Server")]
    [System.SerializableAttribute()]
    public partial class FuelItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ValueField;
        
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
        public float Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
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
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Value {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PosService.IPumpService", CallbackContract=typeof(PSS_POS.PosService.IPumpServiceCallback))]
    public interface IPumpService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPumpService/subscribePump")]
        void subscribePump(int pumpNo);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPumpService/customerReady")]
        void customerReady(int pumpNo, string fueltype);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPumpService/pumpProgress")]
        void pumpProgress(int pumpNo, float amount);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPumpService/PumpingFinished")]
        void PumpingFinished(int pumpNo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPumpServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPumpService/activateMe")]
        void activateMe(float price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPumpServiceChannel : PSS_POS.PosService.IPumpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PumpServiceClient : System.ServiceModel.DuplexClientBase<PSS_POS.PosService.IPumpService>, PSS_POS.PosService.IPumpService {
        
        public PumpServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PumpServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PumpServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PumpServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PumpServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void subscribePump(int pumpNo) {
            base.Channel.subscribePump(pumpNo);
        }
        
        public void customerReady(int pumpNo, string fueltype) {
            base.Channel.customerReady(pumpNo, fueltype);
        }
        
        public void pumpProgress(int pumpNo, float amount) {
            base.Channel.pumpProgress(pumpNo, amount);
        }
        
        public void PumpingFinished(int pumpNo) {
            base.Channel.PumpingFinished(pumpNo);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PosService.IManagerService")]
    public interface IManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/getFuelLevels", ReplyAction="http://tempuri.org/IManagerService/getFuelLevelsResponse")]
        PSS_POS.PosService.FuelItem[] getFuelLevels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/getSaleData", ReplyAction="http://tempuri.org/IManagerService/getSaleDataResponse")]
        PSS_POS.PosService.FuelItem[] getSaleData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/getNumofCustomers", ReplyAction="http://tempuri.org/IManagerService/getNumofCustomersResponse")]
        int getNumofCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerService/getFuelOrders", ReplyAction="http://tempuri.org/IManagerService/getFuelOrdersResponse")]
        PSS_POS.PosService.FuelItem[] getFuelOrders();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IManagerService/setPrice")]
        void setPrice(string fueltype, float price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerServiceChannel : PSS_POS.PosService.IManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerServiceClient : System.ServiceModel.ClientBase<PSS_POS.PosService.IManagerService>, PSS_POS.PosService.IManagerService {
        
        public ManagerServiceClient() {
        }
        
        public ManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PSS_POS.PosService.FuelItem[] getFuelLevels() {
            return base.Channel.getFuelLevels();
        }
        
        public PSS_POS.PosService.FuelItem[] getSaleData() {
            return base.Channel.getSaleData();
        }
        
        public int getNumofCustomers() {
            return base.Channel.getNumofCustomers();
        }
        
        public PSS_POS.PosService.FuelItem[] getFuelOrders() {
            return base.Channel.getFuelOrders();
        }
        
        public void setPrice(string fueltype, float price) {
            base.Channel.setPrice(fueltype, price);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PosService.IPosService", CallbackContract=typeof(PSS_POS.PosService.IPosServiceCallback))]
    public interface IPosService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/subscribePos")]
        void subscribePos(int posId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/activatePump")]
        void activatePump(int pumpNo);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/recordPayment")]
        void recordPayment(int posId, string fueltype, float amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosService/unSubscribePos", ReplyAction="http://tempuri.org/IPosService/unSubscribePosResponse")]
        void unSubscribePos(int posId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPosServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/customerWaiting")]
        void customerWaiting(int pumpNo, string fueltype);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/pumpingProgress")]
        void pumpingProgress(int pumpNo, PSS_POS.PosService.FuelItem update, float price);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPosService/finishedPumping")]
        void finishedPumping(int pumpNo, PSS_POS.PosService.FuelItem fuel, float price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPosServiceChannel : PSS_POS.PosService.IPosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PosServiceClient : System.ServiceModel.DuplexClientBase<PSS_POS.PosService.IPosService>, PSS_POS.PosService.IPosService {
        
        public PosServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PosServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PosServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PosServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PosServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void subscribePos(int posId) {
            base.Channel.subscribePos(posId);
        }
        
        public void activatePump(int pumpNo) {
            base.Channel.activatePump(pumpNo);
        }
        
        public void recordPayment(int posId, string fueltype, float amount) {
            base.Channel.recordPayment(posId, fueltype, amount);
        }
        
        public void unSubscribePos(int posId) {
            base.Channel.unSubscribePos(posId);
        }
    }
}
