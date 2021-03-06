﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sdpassist.SDPOPSService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sdp", Namespace="http://schemas.datacontract.org/2004/07/sdpopsservice")]
    [System.SerializableAttribute()]
    public partial class Sdp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TamField;
        
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
        public string Tam {
            get {
                return this.TamField;
            }
            set {
                if ((object.ReferenceEquals(this.TamField, value) != true)) {
                    this.TamField = value;
                    this.RaisePropertyChanged("Tam");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OPSStaff", Namespace="http://schemas.datacontract.org/2004/07/sdpopsservice")]
    [System.SerializableAttribute()]
    public partial class OPSStaff : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Manager {
            get {
                return this.ManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManagerField, value) != true)) {
                    this.ManagerField = value;
                    this.RaisePropertyChanged("Manager");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SDPOPSService.ISDPOPSService")]
    public interface ISDPOPSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/setOwner", ReplyAction="http://tempuri.org/ISDPOPSService/setOwnerResponse")]
        bool setOwner(string env, int sdpid, string empalias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/setOwner", ReplyAction="http://tempuri.org/ISDPOPSService/setOwnerResponse")]
        System.Threading.Tasks.Task<bool> setOwnerAsync(string env, int sdpid, string empalias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/searchSdpbyTam", ReplyAction="http://tempuri.org/ISDPOPSService/searchSdpbyTamResponse")]
        sdpassist.SDPOPSService.Sdp[] searchSdpbyTam(string env, string tam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/searchSdpbyTam", ReplyAction="http://tempuri.org/ISDPOPSService/searchSdpbyTamResponse")]
        System.Threading.Tasks.Task<sdpassist.SDPOPSService.Sdp[]> searchSdpbyTamAsync(string env, string tam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/searchSdpbyName", ReplyAction="http://tempuri.org/ISDPOPSService/searchSdpbyNameResponse")]
        sdpassist.SDPOPSService.Sdp[] searchSdpbyName(string env, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/searchSdpbyName", ReplyAction="http://tempuri.org/ISDPOPSService/searchSdpbyNameResponse")]
        System.Threading.Tasks.Task<sdpassist.SDPOPSService.Sdp[]> searchSdpbyNameAsync(string env, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/getAllOpsStaff", ReplyAction="http://tempuri.org/ISDPOPSService/getAllOpsStaffResponse")]
        sdpassist.SDPOPSService.OPSStaff[] getAllOpsStaff();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISDPOPSService/getAllOpsStaff", ReplyAction="http://tempuri.org/ISDPOPSService/getAllOpsStaffResponse")]
        System.Threading.Tasks.Task<sdpassist.SDPOPSService.OPSStaff[]> getAllOpsStaffAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISDPOPSServiceChannel : sdpassist.SDPOPSService.ISDPOPSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SDPOPSServiceClient : System.ServiceModel.ClientBase<sdpassist.SDPOPSService.ISDPOPSService>, sdpassist.SDPOPSService.ISDPOPSService {
        
        public SDPOPSServiceClient() {
        }
        
        public SDPOPSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SDPOPSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SDPOPSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SDPOPSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool setOwner(string env, int sdpid, string empalias) {
            return base.Channel.setOwner(env, sdpid, empalias);
        }
        
        public System.Threading.Tasks.Task<bool> setOwnerAsync(string env, int sdpid, string empalias) {
            return base.Channel.setOwnerAsync(env, sdpid, empalias);
        }
        
        public sdpassist.SDPOPSService.Sdp[] searchSdpbyTam(string env, string tam) {
            return base.Channel.searchSdpbyTam(env, tam);
        }
        
        public System.Threading.Tasks.Task<sdpassist.SDPOPSService.Sdp[]> searchSdpbyTamAsync(string env, string tam) {
            return base.Channel.searchSdpbyTamAsync(env, tam);
        }
        
        public sdpassist.SDPOPSService.Sdp[] searchSdpbyName(string env, string Name) {
            return base.Channel.searchSdpbyName(env, Name);
        }
        
        public System.Threading.Tasks.Task<sdpassist.SDPOPSService.Sdp[]> searchSdpbyNameAsync(string env, string Name) {
            return base.Channel.searchSdpbyNameAsync(env, Name);
        }
        
        public sdpassist.SDPOPSService.OPSStaff[] getAllOpsStaff() {
            return base.Channel.getAllOpsStaff();
        }
        
        public System.Threading.Tasks.Task<sdpassist.SDPOPSService.OPSStaff[]> getAllOpsStaffAsync() {
            return base.Channel.getAllOpsStaffAsync();
        }
    }
}
