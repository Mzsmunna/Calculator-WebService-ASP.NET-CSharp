﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeskCalculator.CalService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalService.CalServiceSoap")]
    public interface CalServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        DeskCalculator.CalService.HelloWorldResponse HelloWorld(DeskCalculator.CalService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DeskCalculator.CalService.HelloWorldResponse> HelloWorldAsync(DeskCalculator.CalService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Initialize", ReplyAction="*")]
        void Initialize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Initialize", ReplyAction="*")]
        System.Threading.Tasks.Task InitializeAsync();
        
        // CODEGEN: Generating message contract since element name CalculationResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculation", ReplyAction="*")]
        DeskCalculator.CalService.CalculationResponse Calculation(DeskCalculator.CalService.CalculationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculation", ReplyAction="*")]
        System.Threading.Tasks.Task<DeskCalculator.CalService.CalculationResponse> CalculationAsync(DeskCalculator.CalService.CalculationRequest request);
        
        // CODEGEN: Generating message contract since element name ButtonPressedResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ButtonPressed", ReplyAction="*")]
        DeskCalculator.CalService.ButtonPressedResponse ButtonPressed(DeskCalculator.CalService.ButtonPressedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ButtonPressed", ReplyAction="*")]
        System.Threading.Tasks.Task<DeskCalculator.CalService.ButtonPressedResponse> ButtonPressedAsync(DeskCalculator.CalService.ButtonPressedRequest request);
        
        // CODEGEN: Generating message contract since element name sign from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SignPressed", ReplyAction="*")]
        DeskCalculator.CalService.SignPressedResponse SignPressed(DeskCalculator.CalService.SignPressedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SignPressed", ReplyAction="*")]
        System.Threading.Tasks.Task<DeskCalculator.CalService.SignPressedResponse> SignPressedAsync(DeskCalculator.CalService.SignPressedRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DeskCalculator.CalService.HelloWorldRequestBody Body) {
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
        public DeskCalculator.CalService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DeskCalculator.CalService.HelloWorldResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Calculation", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.CalculationRequestBody Body;
        
        public CalculationRequest() {
        }
        
        public CalculationRequest(DeskCalculator.CalService.CalculationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CalculationRequestBody {
        
        public CalculationRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculationResponse", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.CalculationResponseBody Body;
        
        public CalculationResponse() {
        }
        
        public CalculationResponse(DeskCalculator.CalService.CalculationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CalculationResult;
        
        public CalculationResponseBody() {
        }
        
        public CalculationResponseBody(string CalculationResult) {
            this.CalculationResult = CalculationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ButtonPressedRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ButtonPressed", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.ButtonPressedRequestBody Body;
        
        public ButtonPressedRequest() {
        }
        
        public ButtonPressedRequest(DeskCalculator.CalService.ButtonPressedRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ButtonPressedRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int digit;
        
        public ButtonPressedRequestBody() {
        }
        
        public ButtonPressedRequestBody(int digit) {
            this.digit = digit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ButtonPressedResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ButtonPressedResponse", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.ButtonPressedResponseBody Body;
        
        public ButtonPressedResponse() {
        }
        
        public ButtonPressedResponse(DeskCalculator.CalService.ButtonPressedResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ButtonPressedResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ButtonPressedResult;
        
        public ButtonPressedResponseBody() {
        }
        
        public ButtonPressedResponseBody(string ButtonPressedResult) {
            this.ButtonPressedResult = ButtonPressedResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SignPressedRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SignPressed", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.SignPressedRequestBody Body;
        
        public SignPressedRequest() {
        }
        
        public SignPressedRequest(DeskCalculator.CalService.SignPressedRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SignPressedRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sign;
        
        public SignPressedRequestBody() {
        }
        
        public SignPressedRequestBody(string sign) {
            this.sign = sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SignPressedResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SignPressedResponse", Namespace="http://tempuri.org/", Order=0)]
        public DeskCalculator.CalService.SignPressedResponseBody Body;
        
        public SignPressedResponse() {
        }
        
        public SignPressedResponse(DeskCalculator.CalService.SignPressedResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SignPressedResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SignPressedResult;
        
        public SignPressedResponseBody() {
        }
        
        public SignPressedResponseBody(string SignPressedResult) {
            this.SignPressedResult = SignPressedResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalServiceSoapChannel : DeskCalculator.CalService.CalServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalServiceSoapClient : System.ServiceModel.ClientBase<DeskCalculator.CalService.CalServiceSoap>, DeskCalculator.CalService.CalServiceSoap {
        
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
        DeskCalculator.CalService.HelloWorldResponse DeskCalculator.CalService.CalServiceSoap.HelloWorld(DeskCalculator.CalService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DeskCalculator.CalService.HelloWorldRequest inValue = new DeskCalculator.CalService.HelloWorldRequest();
            inValue.Body = new DeskCalculator.CalService.HelloWorldRequestBody();
            DeskCalculator.CalService.HelloWorldResponse retVal = ((DeskCalculator.CalService.CalServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DeskCalculator.CalService.HelloWorldResponse> DeskCalculator.CalService.CalServiceSoap.HelloWorldAsync(DeskCalculator.CalService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DeskCalculator.CalService.HelloWorldResponse> HelloWorldAsync() {
            DeskCalculator.CalService.HelloWorldRequest inValue = new DeskCalculator.CalService.HelloWorldRequest();
            inValue.Body = new DeskCalculator.CalService.HelloWorldRequestBody();
            return ((DeskCalculator.CalService.CalServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public void Initialize() {
            base.Channel.Initialize();
        }
        
        public System.Threading.Tasks.Task InitializeAsync() {
            return base.Channel.InitializeAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DeskCalculator.CalService.CalculationResponse DeskCalculator.CalService.CalServiceSoap.Calculation(DeskCalculator.CalService.CalculationRequest request) {
            return base.Channel.Calculation(request);
        }
        
        public string Calculation() {
            DeskCalculator.CalService.CalculationRequest inValue = new DeskCalculator.CalService.CalculationRequest();
            inValue.Body = new DeskCalculator.CalService.CalculationRequestBody();
            DeskCalculator.CalService.CalculationResponse retVal = ((DeskCalculator.CalService.CalServiceSoap)(this)).Calculation(inValue);
            return retVal.Body.CalculationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DeskCalculator.CalService.CalculationResponse> DeskCalculator.CalService.CalServiceSoap.CalculationAsync(DeskCalculator.CalService.CalculationRequest request) {
            return base.Channel.CalculationAsync(request);
        }
        
        public System.Threading.Tasks.Task<DeskCalculator.CalService.CalculationResponse> CalculationAsync() {
            DeskCalculator.CalService.CalculationRequest inValue = new DeskCalculator.CalService.CalculationRequest();
            inValue.Body = new DeskCalculator.CalService.CalculationRequestBody();
            return ((DeskCalculator.CalService.CalServiceSoap)(this)).CalculationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DeskCalculator.CalService.ButtonPressedResponse DeskCalculator.CalService.CalServiceSoap.ButtonPressed(DeskCalculator.CalService.ButtonPressedRequest request) {
            return base.Channel.ButtonPressed(request);
        }
        
        public string ButtonPressed(int digit) {
            DeskCalculator.CalService.ButtonPressedRequest inValue = new DeskCalculator.CalService.ButtonPressedRequest();
            inValue.Body = new DeskCalculator.CalService.ButtonPressedRequestBody();
            inValue.Body.digit = digit;
            DeskCalculator.CalService.ButtonPressedResponse retVal = ((DeskCalculator.CalService.CalServiceSoap)(this)).ButtonPressed(inValue);
            return retVal.Body.ButtonPressedResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DeskCalculator.CalService.ButtonPressedResponse> DeskCalculator.CalService.CalServiceSoap.ButtonPressedAsync(DeskCalculator.CalService.ButtonPressedRequest request) {
            return base.Channel.ButtonPressedAsync(request);
        }
        
        public System.Threading.Tasks.Task<DeskCalculator.CalService.ButtonPressedResponse> ButtonPressedAsync(int digit) {
            DeskCalculator.CalService.ButtonPressedRequest inValue = new DeskCalculator.CalService.ButtonPressedRequest();
            inValue.Body = new DeskCalculator.CalService.ButtonPressedRequestBody();
            inValue.Body.digit = digit;
            return ((DeskCalculator.CalService.CalServiceSoap)(this)).ButtonPressedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DeskCalculator.CalService.SignPressedResponse DeskCalculator.CalService.CalServiceSoap.SignPressed(DeskCalculator.CalService.SignPressedRequest request) {
            return base.Channel.SignPressed(request);
        }
        
        public string SignPressed(string sign) {
            DeskCalculator.CalService.SignPressedRequest inValue = new DeskCalculator.CalService.SignPressedRequest();
            inValue.Body = new DeskCalculator.CalService.SignPressedRequestBody();
            inValue.Body.sign = sign;
            DeskCalculator.CalService.SignPressedResponse retVal = ((DeskCalculator.CalService.CalServiceSoap)(this)).SignPressed(inValue);
            return retVal.Body.SignPressedResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DeskCalculator.CalService.SignPressedResponse> DeskCalculator.CalService.CalServiceSoap.SignPressedAsync(DeskCalculator.CalService.SignPressedRequest request) {
            return base.Channel.SignPressedAsync(request);
        }
        
        public System.Threading.Tasks.Task<DeskCalculator.CalService.SignPressedResponse> SignPressedAsync(string sign) {
            DeskCalculator.CalService.SignPressedRequest inValue = new DeskCalculator.CalService.SignPressedRequest();
            inValue.Body = new DeskCalculator.CalService.SignPressedRequestBody();
            inValue.Body.sign = sign;
            return ((DeskCalculator.CalService.CalServiceSoap)(this)).SignPressedAsync(inValue);
        }
    }
}
