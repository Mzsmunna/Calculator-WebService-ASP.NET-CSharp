﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeskCalculator.CalOperations {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalOperations.CalServiceSoap")]
    public interface CalServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        DeskCalculator.CalOperations.HelloWorldResponse HelloWorld(DeskCalculator.CalOperations.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DeskCalculator.CalOperations.HelloWorldResponse> HelloWorldAsync(DeskCalculator.CalOperations.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalOperations.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DeskCalculator.CalOperations.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalOperations.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DeskCalculator.CalOperations.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalServiceSoapChannel : DeskCalculator.CalOperations.CalServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalServiceSoapClient : System.ServiceModel.ClientBase<DeskCalculator.CalOperations.CalServiceSoap>, DeskCalculator.CalOperations.CalServiceSoap {
        
        public CalServiceSoapClient() {
        }
        
        public CalServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DeskCalculator.CalOperations.HelloWorldResponse DeskCalculator.CalOperations.CalServiceSoap.HelloWorld(DeskCalculator.CalOperations.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DeskCalculator.CalOperations.HelloWorldRequest inValue = new DeskCalculator.CalOperations.HelloWorldRequest();
            inValue.Body = new DeskCalculator.CalOperations.HelloWorldRequestBody();
            DeskCalculator.CalOperations.HelloWorldResponse retVal = ((DeskCalculator.CalOperations.CalServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DeskCalculator.CalOperations.HelloWorldResponse> DeskCalculator.CalOperations.CalServiceSoap.HelloWorldAsync(DeskCalculator.CalOperations.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DeskCalculator.CalOperations.HelloWorldResponse> HelloWorldAsync() {
            DeskCalculator.CalOperations.HelloWorldRequest inValue = new DeskCalculator.CalOperations.HelloWorldRequest();
            inValue.Body = new DeskCalculator.CalOperations.HelloWorldRequestBody();
            return ((DeskCalculator.CalOperations.CalServiceSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
