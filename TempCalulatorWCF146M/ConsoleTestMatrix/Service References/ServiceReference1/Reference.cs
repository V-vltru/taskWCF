﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleTestMatrix.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Array3DOfdouble", Namespace="http://schemas.datacontract.org/2004/07/Array3DLibrary")]
    [System.SerializableAttribute()]
    public partial class Array3DOfdouble : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double[] ItemsField;
        
        private int MaxItemNumberField;
        
        private int xLengthField;
        
        private int yLengthField;
        
        private int zLengthField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int MaxItemNumber {
            get {
                return this.MaxItemNumberField;
            }
            set {
                if ((this.MaxItemNumberField.Equals(value) != true)) {
                    this.MaxItemNumberField = value;
                    this.RaisePropertyChanged("MaxItemNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int xLength {
            get {
                return this.xLengthField;
            }
            set {
                if ((this.xLengthField.Equals(value) != true)) {
                    this.xLengthField = value;
                    this.RaisePropertyChanged("xLength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int yLength {
            get {
                return this.yLengthField;
            }
            set {
                if ((this.yLengthField.Equals(value) != true)) {
                    this.yLengthField = value;
                    this.RaisePropertyChanged("yLength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int zLength {
            get {
                return this.zLengthField;
            }
            set {
                if ((this.zLengthField.Equals(value) != true)) {
                    this.zLengthField = value;
                    this.RaisePropertyChanged("zLength");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp", ReplyAction="http://tempuri.org/IService/CalculateTempResponse")]
        WcfMathLibrary.Temperature.OutputForTemp CalculateTemp(WcfMathLibrary.Temperature.InputForTemp input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp", ReplyAction="http://tempuri.org/IService/CalculateTempResponse")]
        System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp> CalculateTempAsync(WcfMathLibrary.Temperature.InputForTemp input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp3D", ReplyAction="http://tempuri.org/IService/CalculateTemp3DResponse")]
        WcfMathLibrary.Temperature.OutputForTemp3D CalculateTemp3D(WcfMathLibrary.Temperature.InputForTemp3D input3D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp3D", ReplyAction="http://tempuri.org/IService/CalculateTemp3DResponse")]
        System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp3D> CalculateTemp3DAsync(WcfMathLibrary.Temperature.InputForTemp3D input3D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp1D", ReplyAction="http://tempuri.org/IService/CalculateTemp1DResponse")]
        WcfMathLibrary.Temperature.OutputForTemp1D CalculateTemp1D(WcfMathLibrary.Temperature.InputForTemp1D input1D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateTemp1D", ReplyAction="http://tempuri.org/IService/CalculateTemp1DResponse")]
        System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp1D> CalculateTemp1DAsync(WcfMathLibrary.Temperature.InputForTemp1D input1D);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MatrixSum", ReplyAction="http://tempuri.org/IService/MatrixSumResponse")]
        WcfMathLibrary.Matrix.MatrixOutput MatrixSum(WcfMathLibrary.Matrix.MatrixInput Input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MatrixSum", ReplyAction="http://tempuri.org/IService/MatrixSumResponse")]
        System.Threading.Tasks.Task<WcfMathLibrary.Matrix.MatrixOutput> MatrixSumAsync(WcfMathLibrary.Matrix.MatrixInput Input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MatrixMul", ReplyAction="http://tempuri.org/IService/MatrixMulResponse")]
        WcfMathLibrary.Matrix.MatrixOutput MatrixMul(WcfMathLibrary.Matrix.MatrixInput Input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MatrixMul", ReplyAction="http://tempuri.org/IService/MatrixMulResponse")]
        System.Threading.Tasks.Task<WcfMathLibrary.Matrix.MatrixOutput> MatrixMulAsync(WcfMathLibrary.Matrix.MatrixInput Input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ConsoleTestMatrix.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ConsoleTestMatrix.ServiceReference1.IService>, ConsoleTestMatrix.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfMathLibrary.Temperature.OutputForTemp CalculateTemp(WcfMathLibrary.Temperature.InputForTemp input) {
            return base.Channel.CalculateTemp(input);
        }
        
        public System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp> CalculateTempAsync(WcfMathLibrary.Temperature.InputForTemp input) {
            return base.Channel.CalculateTempAsync(input);
        }
        
        public WcfMathLibrary.Temperature.OutputForTemp3D CalculateTemp3D(WcfMathLibrary.Temperature.InputForTemp3D input3D) {
            return base.Channel.CalculateTemp3D(input3D);
        }
        
        public System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp3D> CalculateTemp3DAsync(WcfMathLibrary.Temperature.InputForTemp3D input3D) {
            return base.Channel.CalculateTemp3DAsync(input3D);
        }
        
        public WcfMathLibrary.Temperature.OutputForTemp1D CalculateTemp1D(WcfMathLibrary.Temperature.InputForTemp1D input1D) {
            return base.Channel.CalculateTemp1D(input1D);
        }
        
        public System.Threading.Tasks.Task<WcfMathLibrary.Temperature.OutputForTemp1D> CalculateTemp1DAsync(WcfMathLibrary.Temperature.InputForTemp1D input1D) {
            return base.Channel.CalculateTemp1DAsync(input1D);
        }
        
        public WcfMathLibrary.Matrix.MatrixOutput MatrixSum(WcfMathLibrary.Matrix.MatrixInput Input) {
            return base.Channel.MatrixSum(Input);
        }
        
        public System.Threading.Tasks.Task<WcfMathLibrary.Matrix.MatrixOutput> MatrixSumAsync(WcfMathLibrary.Matrix.MatrixInput Input) {
            return base.Channel.MatrixSumAsync(Input);
        }
        
        public WcfMathLibrary.Matrix.MatrixOutput MatrixMul(WcfMathLibrary.Matrix.MatrixInput Input) {
            return base.Channel.MatrixMul(Input);
        }
        
        public System.Threading.Tasks.Task<WcfMathLibrary.Matrix.MatrixOutput> MatrixMulAsync(WcfMathLibrary.Matrix.MatrixInput Input) {
            return base.Channel.MatrixMulAsync(Input);
        }
    }
}
