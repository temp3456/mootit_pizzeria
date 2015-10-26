﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1022
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mootit.Users.Service.Accounts {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Mootit.Users.Entities")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneNumerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mootit.Users.Service.Accounts.User UserField;
        
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
        public string Fullname {
            get {
                return this.FullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullnameField, value) != true)) {
                    this.FullnameField = value;
                    this.RaisePropertyChanged("Fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhoneNumer {
            get {
                return this.PhoneNumerField;
            }
            set {
                if ((this.PhoneNumerField.Equals(value) != true)) {
                    this.PhoneNumerField = value;
                    this.RaisePropertyChanged("PhoneNumer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mootit.Users.Service.Accounts.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Mootit.Users.Entities")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Mootit.Users.Service.Accounts.IAccounts")]
    public interface IAccounts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccounts/Sync", ReplyAction="http://tempuri.org/IAccounts/SyncResponse")]
        void Sync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccounts/GetCustomer", ReplyAction="http://tempuri.org/IAccounts/GetCustomerResponse")]
        Mootit.Users.Service.Accounts.Customer GetCustomer(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccounts/GetCustomerByPhone", ReplyAction="http://tempuri.org/IAccounts/GetCustomerByPhoneResponse")]
        Mootit.Users.Service.Accounts.Customer GetCustomerByPhone(int phoneNumer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccounts/InsertCustomer", ReplyAction="http://tempuri.org/IAccounts/InsertCustomerResponse")]
        Mootit.Users.Service.Accounts.Customer InsertCustomer(Mootit.Users.Service.Accounts.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountsChannel : Mootit.Users.Service.Accounts.IAccounts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountsClient : System.ServiceModel.ClientBase<Mootit.Users.Service.Accounts.IAccounts>, Mootit.Users.Service.Accounts.IAccounts {
        
        public AccountsClient() {
        }
        
        public AccountsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Sync() {
            base.Channel.Sync();
        }
        
        public Mootit.Users.Service.Accounts.Customer GetCustomer(long id) {
            return base.Channel.GetCustomer(id);
        }
        
        public Mootit.Users.Service.Accounts.Customer GetCustomerByPhone(int phoneNumer) {
            return base.Channel.GetCustomerByPhone(phoneNumer);
        }
        
        public Mootit.Users.Service.Accounts.Customer InsertCustomer(Mootit.Users.Service.Accounts.Customer customer) {
            return base.Channel.InsertCustomer(customer);
        }
    }
}