﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesignPatterns.RemoteProxy.ClientApp.ActualPrices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ActualPrices.IActualPrices")]
    public interface IActualPrices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActualPrices/GetUsdToUah", ReplyAction="http://tempuri.org/IActualPrices/GetUsdToUahResponse")]
        int GetUsdToUah();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActualPrices/GetUsdToUah", ReplyAction="http://tempuri.org/IActualPrices/GetUsdToUahResponse")]
        System.Threading.Tasks.Task<int> GetUsdToUahAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActualPrices/GetEuroToUah", ReplyAction="http://tempuri.org/IActualPrices/GetEuroToUahResponse")]
        int GetEuroToUah();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActualPrices/GetEuroToUah", ReplyAction="http://tempuri.org/IActualPrices/GetEuroToUahResponse")]
        System.Threading.Tasks.Task<int> GetEuroToUahAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IActualPricesChannel : DesignPatterns.RemoteProxy.ClientApp.ActualPrices.IActualPrices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ActualPricesClient : System.ServiceModel.ClientBase<DesignPatterns.RemoteProxy.ClientApp.ActualPrices.IActualPrices>, DesignPatterns.RemoteProxy.ClientApp.ActualPrices.IActualPrices {
        
        public ActualPricesClient() {
        }
        
        public ActualPricesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ActualPricesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActualPricesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActualPricesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetUsdToUah() {
            return base.Channel.GetUsdToUah();
        }
        
        public System.Threading.Tasks.Task<int> GetUsdToUahAsync() {
            return base.Channel.GetUsdToUahAsync();
        }
        
        public int GetEuroToUah() {
            return base.Channel.GetEuroToUah();
        }
        
        public System.Threading.Tasks.Task<int> GetEuroToUahAsync() {
            return base.Channel.GetEuroToUahAsync();
        }
    }
}