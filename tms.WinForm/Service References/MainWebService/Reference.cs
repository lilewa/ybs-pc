﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tms.WinForm.MainWebService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainWebService.MainWebServiceSoap")]
    public interface MainWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteReturnInt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteReturnIntResponse ExecuteReturnInt(tms.WinForm.MainWebService.ExecuteReturnIntRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteReturnInt", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteReturnIntResponse> ExecuteReturnIntAsync(tms.WinForm.MainWebService.ExecuteReturnIntRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteReturnTb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteReturnTbResponse ExecuteReturnTb(tms.WinForm.MainWebService.ExecuteReturnTbRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteReturnTb", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteReturnTbResponse> ExecuteReturnTbAsync(tms.WinForm.MainWebService.ExecuteReturnTbRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteTrans", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ExecuteTrans(string spaceAndForm, string funcName, string[] jsonParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteTrans", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ExecuteTransAsync(string spaceAndForm, string funcName, string[] jsonParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteDynamicSql", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteDynamicSqlResponse ExecuteDynamicSql(tms.WinForm.MainWebService.ExecuteDynamicSqlRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteDynamicSql", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteDynamicSqlResponse> ExecuteDynamicSqlAsync(tms.WinForm.MainWebService.ExecuteDynamicSqlRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteDataset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteDatasetResponse ExecuteDataset(tms.WinForm.MainWebService.ExecuteDatasetRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteDataset", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteDatasetResponse> ExecuteDatasetAsync(tms.WinForm.MainWebService.ExecuteDatasetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteCheckBoxTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteCheckBoxTableResponse ExecuteCheckBoxTable(tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteCheckBoxTable", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteCheckBoxTableResponse> ExecuteCheckBoxTableAsync(tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchTbSqlWhere", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.SearchTbSqlWhereResponse SearchTbSqlWhere(tms.WinForm.MainWebService.SearchTbSqlWhereRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchTbSqlWhere", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.SearchTbSqlWhereResponse> SearchTbSqlWhereAsync(tms.WinForm.MainWebService.SearchTbSqlWhereRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteUpdate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tms.WinForm.MainWebService.ExecuteUpdateResponse ExecuteUpdate(tms.WinForm.MainWebService.ExecuteUpdateRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteUpdate", ReplyAction="*")]
        System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteUpdateResponse> ExecuteUpdateAsync(tms.WinForm.MainWebService.ExecuteUpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteReturnInt", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteReturnIntRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string spaceAndForm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string funcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] dicParams;
        
        public ExecuteReturnIntRequest() {
        }
        
        public ExecuteReturnIntRequest(string spaceAndForm, string funcName, string[] dicParams) {
            this.spaceAndForm = spaceAndForm;
            this.funcName = funcName;
            this.dicParams = dicParams;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteReturnIntResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteReturnIntResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int ExecuteReturnIntResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteReturnIntResponse() {
        }
        
        public ExecuteReturnIntResponse(int ExecuteReturnIntResult, string errMsg) {
            this.ExecuteReturnIntResult = ExecuteReturnIntResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteReturnTb", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteReturnTbRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string spaceAndForm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string funcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] dicParams;
        
        public ExecuteReturnTbRequest() {
        }
        
        public ExecuteReturnTbRequest(string spaceAndForm, string funcName, string[] dicParams) {
            this.spaceAndForm = spaceAndForm;
            this.funcName = funcName;
            this.dicParams = dicParams;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteReturnTbResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteReturnTbResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ExecuteReturnTbResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteReturnTbResponse() {
        }
        
        public ExecuteReturnTbResponse(System.Data.DataTable ExecuteReturnTbResult, string errMsg) {
            this.ExecuteReturnTbResult = ExecuteReturnTbResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteDynamicSql", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteDynamicSqlRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string spaceAndForm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string funcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] dicParams;
        
        public ExecuteDynamicSqlRequest() {
        }
        
        public ExecuteDynamicSqlRequest(string spaceAndForm, string funcName, string[] dicParams) {
            this.spaceAndForm = spaceAndForm;
            this.funcName = funcName;
            this.dicParams = dicParams;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteDynamicSqlResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteDynamicSqlResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ExecuteDynamicSqlResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteDynamicSqlResponse() {
        }
        
        public ExecuteDynamicSqlResponse(System.Data.DataTable ExecuteDynamicSqlResult, string errMsg) {
            this.ExecuteDynamicSqlResult = ExecuteDynamicSqlResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteDataset", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteDatasetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sql;
        
        public ExecuteDatasetRequest() {
        }
        
        public ExecuteDatasetRequest(string sql) {
            this.sql = sql;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteDatasetResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteDatasetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ExecuteDatasetResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteDatasetResponse() {
        }
        
        public ExecuteDatasetResponse(System.Data.DataTable ExecuteDatasetResult, string errMsg) {
            this.ExecuteDatasetResult = ExecuteDatasetResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteCheckBoxTable", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteCheckBoxTableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string spaceAndForm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string funcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] dicParams;
        
        public ExecuteCheckBoxTableRequest() {
        }
        
        public ExecuteCheckBoxTableRequest(string spaceAndForm, string funcName, string[] dicParams) {
            this.spaceAndForm = spaceAndForm;
            this.funcName = funcName;
            this.dicParams = dicParams;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteCheckBoxTableResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteCheckBoxTableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ExecuteCheckBoxTableResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteCheckBoxTableResponse() {
        }
        
        public ExecuteCheckBoxTableResponse(System.Data.DataTable ExecuteCheckBoxTableResult, string errMsg) {
            this.ExecuteCheckBoxTableResult = ExecuteCheckBoxTableResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchTbSqlWhere", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchTbSqlWhereRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string spaceAndForm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string funcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sqlWhere;
        
        public SearchTbSqlWhereRequest() {
        }
        
        public SearchTbSqlWhereRequest(string spaceAndForm, string funcName, string sqlWhere) {
            this.spaceAndForm = spaceAndForm;
            this.funcName = funcName;
            this.sqlWhere = sqlWhere;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchTbSqlWhereResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchTbSqlWhereResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable SearchTbSqlWhereResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public SearchTbSqlWhereResponse() {
        }
        
        public SearchTbSqlWhereResponse(System.Data.DataTable SearchTbSqlWhereResult, string errMsg) {
            this.SearchTbSqlWhereResult = SearchTbSqlWhereResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteUpdate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteUpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string selectSql;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Data.DataTable changedDt;
        
        public ExecuteUpdateRequest() {
        }
        
        public ExecuteUpdateRequest(string selectSql, System.Data.DataTable changedDt) {
            this.selectSql = selectSql;
            this.changedDt = changedDt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteUpdateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteUpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int ExecuteUpdateResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public ExecuteUpdateResponse() {
        }
        
        public ExecuteUpdateResponse(int ExecuteUpdateResult, string errMsg) {
            this.ExecuteUpdateResult = ExecuteUpdateResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MainWebServiceSoapChannel : tms.WinForm.MainWebService.MainWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainWebServiceSoapClient : System.ServiceModel.ClientBase<tms.WinForm.MainWebService.MainWebServiceSoap>, tms.WinForm.MainWebService.MainWebServiceSoap {
        
        public MainWebServiceSoapClient() {
        }
        
        public MainWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteReturnIntResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteReturnInt(tms.WinForm.MainWebService.ExecuteReturnIntRequest request) {
            return base.Channel.ExecuteReturnInt(request);
        }
        
        public int ExecuteReturnInt(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteReturnIntRequest inValue = new tms.WinForm.MainWebService.ExecuteReturnIntRequest();
            inValue.spaceAndForm = spaceAndForm;
            inValue.funcName = funcName;
            inValue.dicParams = dicParams;
            tms.WinForm.MainWebService.ExecuteReturnIntResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteReturnInt(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteReturnIntResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteReturnIntResponse> ExecuteReturnIntAsync(tms.WinForm.MainWebService.ExecuteReturnIntRequest request) {
            return base.Channel.ExecuteReturnIntAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteReturnTbResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteReturnTb(tms.WinForm.MainWebService.ExecuteReturnTbRequest request) {
            return base.Channel.ExecuteReturnTb(request);
        }
        
        public System.Data.DataTable ExecuteReturnTb(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteReturnTbRequest inValue = new tms.WinForm.MainWebService.ExecuteReturnTbRequest();
            inValue.spaceAndForm = spaceAndForm;
            inValue.funcName = funcName;
            inValue.dicParams = dicParams;
            tms.WinForm.MainWebService.ExecuteReturnTbResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteReturnTb(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteReturnTbResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteReturnTbResponse> ExecuteReturnTbAsync(tms.WinForm.MainWebService.ExecuteReturnTbRequest request) {
            return base.Channel.ExecuteReturnTbAsync(request);
        }
        
        public string ExecuteTrans(string spaceAndForm, string funcName, string[] jsonParams) {
            return base.Channel.ExecuteTrans(spaceAndForm, funcName, jsonParams);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteTransAsync(string spaceAndForm, string funcName, string[] jsonParams) {
            return base.Channel.ExecuteTransAsync(spaceAndForm, funcName, jsonParams);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteDynamicSqlResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteDynamicSql(tms.WinForm.MainWebService.ExecuteDynamicSqlRequest request) {
            return base.Channel.ExecuteDynamicSql(request);
        }
        
        public System.Data.DataTable ExecuteDynamicSql(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteDynamicSqlRequest inValue = new tms.WinForm.MainWebService.ExecuteDynamicSqlRequest();
            inValue.spaceAndForm = spaceAndForm;
            inValue.funcName = funcName;
            inValue.dicParams = dicParams;
            tms.WinForm.MainWebService.ExecuteDynamicSqlResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteDynamicSql(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteDynamicSqlResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteDynamicSqlResponse> ExecuteDynamicSqlAsync(tms.WinForm.MainWebService.ExecuteDynamicSqlRequest request) {
            return base.Channel.ExecuteDynamicSqlAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteDatasetResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteDataset(tms.WinForm.MainWebService.ExecuteDatasetRequest request) {
            return base.Channel.ExecuteDataset(request);
        }
        
        public System.Data.DataTable ExecuteDataset(string sql, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteDatasetRequest inValue = new tms.WinForm.MainWebService.ExecuteDatasetRequest();
            inValue.sql = sql;
            tms.WinForm.MainWebService.ExecuteDatasetResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteDataset(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteDatasetResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteDatasetResponse> ExecuteDatasetAsync(tms.WinForm.MainWebService.ExecuteDatasetRequest request) {
            return base.Channel.ExecuteDatasetAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteCheckBoxTableResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteCheckBoxTable(tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest request) {
            return base.Channel.ExecuteCheckBoxTable(request);
        }
        
        public System.Data.DataTable ExecuteCheckBoxTable(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest inValue = new tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest();
            inValue.spaceAndForm = spaceAndForm;
            inValue.funcName = funcName;
            inValue.dicParams = dicParams;
            tms.WinForm.MainWebService.ExecuteCheckBoxTableResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteCheckBoxTable(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteCheckBoxTableResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteCheckBoxTableResponse> ExecuteCheckBoxTableAsync(tms.WinForm.MainWebService.ExecuteCheckBoxTableRequest request) {
            return base.Channel.ExecuteCheckBoxTableAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.SearchTbSqlWhereResponse tms.WinForm.MainWebService.MainWebServiceSoap.SearchTbSqlWhere(tms.WinForm.MainWebService.SearchTbSqlWhereRequest request) {
            return base.Channel.SearchTbSqlWhere(request);
        }
        
        public System.Data.DataTable SearchTbSqlWhere(string spaceAndForm, string funcName, string sqlWhere, out string errMsg) {
            tms.WinForm.MainWebService.SearchTbSqlWhereRequest inValue = new tms.WinForm.MainWebService.SearchTbSqlWhereRequest();
            inValue.spaceAndForm = spaceAndForm;
            inValue.funcName = funcName;
            inValue.sqlWhere = sqlWhere;
            tms.WinForm.MainWebService.SearchTbSqlWhereResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).SearchTbSqlWhere(inValue);
            errMsg = retVal.errMsg;
            return retVal.SearchTbSqlWhereResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.SearchTbSqlWhereResponse> SearchTbSqlWhereAsync(tms.WinForm.MainWebService.SearchTbSqlWhereRequest request) {
            return base.Channel.SearchTbSqlWhereAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tms.WinForm.MainWebService.ExecuteUpdateResponse tms.WinForm.MainWebService.MainWebServiceSoap.ExecuteUpdate(tms.WinForm.MainWebService.ExecuteUpdateRequest request) {
            return base.Channel.ExecuteUpdate(request);
        }
        
        public int ExecuteUpdate(string selectSql, System.Data.DataTable changedDt, out string errMsg) {
            tms.WinForm.MainWebService.ExecuteUpdateRequest inValue = new tms.WinForm.MainWebService.ExecuteUpdateRequest();
            inValue.selectSql = selectSql;
            inValue.changedDt = changedDt;
            tms.WinForm.MainWebService.ExecuteUpdateResponse retVal = ((tms.WinForm.MainWebService.MainWebServiceSoap)(this)).ExecuteUpdate(inValue);
            errMsg = retVal.errMsg;
            return retVal.ExecuteUpdateResult;
        }
        
        public System.Threading.Tasks.Task<tms.WinForm.MainWebService.ExecuteUpdateResponse> ExecuteUpdateAsync(tms.WinForm.MainWebService.ExecuteUpdateRequest request) {
            return base.Channel.ExecuteUpdateAsync(request);
        }
    }
}