﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace tms.WinForm.MainWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MainWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class MainWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ExecuteReturnIntOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteReturnTbOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteTransOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteDynamicSqlOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteDatasetOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteCheckBoxTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchTbSqlWhereOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExecuteUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback BulkInsertTableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MainWebService() {
            this.Url = global::tms.WinForm.Properties.Settings.Default.tms_WinForm_MainWebService_MainWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ExecuteReturnIntCompletedEventHandler ExecuteReturnIntCompleted;
        
        /// <remarks/>
        public event ExecuteReturnTbCompletedEventHandler ExecuteReturnTbCompleted;
        
        /// <remarks/>
        public event ExecuteTransCompletedEventHandler ExecuteTransCompleted;
        
        /// <remarks/>
        public event ExecuteDynamicSqlCompletedEventHandler ExecuteDynamicSqlCompleted;
        
        /// <remarks/>
        public event ExecuteDatasetCompletedEventHandler ExecuteDatasetCompleted;
        
        /// <remarks/>
        public event ExecuteCheckBoxTableCompletedEventHandler ExecuteCheckBoxTableCompleted;
        
        /// <remarks/>
        public event SearchTbSqlWhereCompletedEventHandler SearchTbSqlWhereCompleted;
        
        /// <remarks/>
        public event ExecuteUpdateCompletedEventHandler ExecuteUpdateCompleted;
        
        /// <remarks/>
        public event BulkInsertTableCompletedEventHandler BulkInsertTableCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteReturnInt", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int ExecuteReturnInt(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            object[] results = this.Invoke("ExecuteReturnInt", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams});
            errMsg = ((string)(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteReturnIntAsync(string spaceAndForm, string funcName, string[] dicParams) {
            this.ExecuteReturnIntAsync(spaceAndForm, funcName, dicParams, null);
        }
        
        /// <remarks/>
        public void ExecuteReturnIntAsync(string spaceAndForm, string funcName, string[] dicParams, object userState) {
            if ((this.ExecuteReturnIntOperationCompleted == null)) {
                this.ExecuteReturnIntOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteReturnIntOperationCompleted);
            }
            this.InvokeAsync("ExecuteReturnInt", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams}, this.ExecuteReturnIntOperationCompleted, userState);
        }
        
        private void OnExecuteReturnIntOperationCompleted(object arg) {
            if ((this.ExecuteReturnIntCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteReturnIntCompleted(this, new ExecuteReturnIntCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteReturnTb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable ExecuteReturnTb(string spaceAndForm, string funcName, string[] dicParams, out string selectSql, out string errMsg) {
            object[] results = this.Invoke("ExecuteReturnTb", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams});
            selectSql = ((string)(results[1]));
            errMsg = ((string)(results[2]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteReturnTbAsync(string spaceAndForm, string funcName, string[] dicParams) {
            this.ExecuteReturnTbAsync(spaceAndForm, funcName, dicParams, null);
        }
        
        /// <remarks/>
        public void ExecuteReturnTbAsync(string spaceAndForm, string funcName, string[] dicParams, object userState) {
            if ((this.ExecuteReturnTbOperationCompleted == null)) {
                this.ExecuteReturnTbOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteReturnTbOperationCompleted);
            }
            this.InvokeAsync("ExecuteReturnTb", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams}, this.ExecuteReturnTbOperationCompleted, userState);
        }
        
        private void OnExecuteReturnTbOperationCompleted(object arg) {
            if ((this.ExecuteReturnTbCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteReturnTbCompleted(this, new ExecuteReturnTbCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteTrans", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExecuteTrans(string spaceAndForm, string funcName, [System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfString")] [System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)] string[][] param) {
            object[] results = this.Invoke("ExecuteTrans", new object[] {
                        spaceAndForm,
                        funcName,
                        param});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteTransAsync(string spaceAndForm, string funcName, string[][] param) {
            this.ExecuteTransAsync(spaceAndForm, funcName, param, null);
        }
        
        /// <remarks/>
        public void ExecuteTransAsync(string spaceAndForm, string funcName, string[][] param, object userState) {
            if ((this.ExecuteTransOperationCompleted == null)) {
                this.ExecuteTransOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteTransOperationCompleted);
            }
            this.InvokeAsync("ExecuteTrans", new object[] {
                        spaceAndForm,
                        funcName,
                        param}, this.ExecuteTransOperationCompleted, userState);
        }
        
        private void OnExecuteTransOperationCompleted(object arg) {
            if ((this.ExecuteTransCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteTransCompleted(this, new ExecuteTransCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteDynamicSql", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable ExecuteDynamicSql(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            object[] results = this.Invoke("ExecuteDynamicSql", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams});
            errMsg = ((string)(results[1]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteDynamicSqlAsync(string spaceAndForm, string funcName, string[] dicParams) {
            this.ExecuteDynamicSqlAsync(spaceAndForm, funcName, dicParams, null);
        }
        
        /// <remarks/>
        public void ExecuteDynamicSqlAsync(string spaceAndForm, string funcName, string[] dicParams, object userState) {
            if ((this.ExecuteDynamicSqlOperationCompleted == null)) {
                this.ExecuteDynamicSqlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteDynamicSqlOperationCompleted);
            }
            this.InvokeAsync("ExecuteDynamicSql", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams}, this.ExecuteDynamicSqlOperationCompleted, userState);
        }
        
        private void OnExecuteDynamicSqlOperationCompleted(object arg) {
            if ((this.ExecuteDynamicSqlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteDynamicSqlCompleted(this, new ExecuteDynamicSqlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteDataset", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable ExecuteDataset(string sql, out string errMsg) {
            object[] results = this.Invoke("ExecuteDataset", new object[] {
                        sql});
            errMsg = ((string)(results[1]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteDatasetAsync(string sql) {
            this.ExecuteDatasetAsync(sql, null);
        }
        
        /// <remarks/>
        public void ExecuteDatasetAsync(string sql, object userState) {
            if ((this.ExecuteDatasetOperationCompleted == null)) {
                this.ExecuteDatasetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteDatasetOperationCompleted);
            }
            this.InvokeAsync("ExecuteDataset", new object[] {
                        sql}, this.ExecuteDatasetOperationCompleted, userState);
        }
        
        private void OnExecuteDatasetOperationCompleted(object arg) {
            if ((this.ExecuteDatasetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteDatasetCompleted(this, new ExecuteDatasetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteCheckBoxTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable ExecuteCheckBoxTable(string spaceAndForm, string funcName, string[] dicParams, out string errMsg) {
            object[] results = this.Invoke("ExecuteCheckBoxTable", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams});
            errMsg = ((string)(results[1]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteCheckBoxTableAsync(string spaceAndForm, string funcName, string[] dicParams) {
            this.ExecuteCheckBoxTableAsync(spaceAndForm, funcName, dicParams, null);
        }
        
        /// <remarks/>
        public void ExecuteCheckBoxTableAsync(string spaceAndForm, string funcName, string[] dicParams, object userState) {
            if ((this.ExecuteCheckBoxTableOperationCompleted == null)) {
                this.ExecuteCheckBoxTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteCheckBoxTableOperationCompleted);
            }
            this.InvokeAsync("ExecuteCheckBoxTable", new object[] {
                        spaceAndForm,
                        funcName,
                        dicParams}, this.ExecuteCheckBoxTableOperationCompleted, userState);
        }
        
        private void OnExecuteCheckBoxTableOperationCompleted(object arg) {
            if ((this.ExecuteCheckBoxTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteCheckBoxTableCompleted(this, new ExecuteCheckBoxTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchTbSqlWhere", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable SearchTbSqlWhere(string spaceAndForm, string funcName, string sqlWhere, out string errMsg) {
            object[] results = this.Invoke("SearchTbSqlWhere", new object[] {
                        spaceAndForm,
                        funcName,
                        sqlWhere});
            errMsg = ((string)(results[1]));
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void SearchTbSqlWhereAsync(string spaceAndForm, string funcName, string sqlWhere) {
            this.SearchTbSqlWhereAsync(spaceAndForm, funcName, sqlWhere, null);
        }
        
        /// <remarks/>
        public void SearchTbSqlWhereAsync(string spaceAndForm, string funcName, string sqlWhere, object userState) {
            if ((this.SearchTbSqlWhereOperationCompleted == null)) {
                this.SearchTbSqlWhereOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchTbSqlWhereOperationCompleted);
            }
            this.InvokeAsync("SearchTbSqlWhere", new object[] {
                        spaceAndForm,
                        funcName,
                        sqlWhere}, this.SearchTbSqlWhereOperationCompleted, userState);
        }
        
        private void OnSearchTbSqlWhereOperationCompleted(object arg) {
            if ((this.SearchTbSqlWhereCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchTbSqlWhereCompleted(this, new SearchTbSqlWhereCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int ExecuteUpdate(string selectSql, System.Data.DataTable changedDt, out string errMsg) {
            object[] results = this.Invoke("ExecuteUpdate", new object[] {
                        selectSql,
                        changedDt});
            errMsg = ((string)(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void ExecuteUpdateAsync(string selectSql, System.Data.DataTable changedDt) {
            this.ExecuteUpdateAsync(selectSql, changedDt, null);
        }
        
        /// <remarks/>
        public void ExecuteUpdateAsync(string selectSql, System.Data.DataTable changedDt, object userState) {
            if ((this.ExecuteUpdateOperationCompleted == null)) {
                this.ExecuteUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExecuteUpdateOperationCompleted);
            }
            this.InvokeAsync("ExecuteUpdate", new object[] {
                        selectSql,
                        changedDt}, this.ExecuteUpdateOperationCompleted, userState);
        }
        
        private void OnExecuteUpdateOperationCompleted(object arg) {
            if ((this.ExecuteUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExecuteUpdateCompleted(this, new ExecuteUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BulkInsertTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BulkInsertTable(string[] columnMappings, System.Data.DataTable dt) {
            object[] results = this.Invoke("BulkInsertTable", new object[] {
                        columnMappings,
                        dt});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void BulkInsertTableAsync(string[] columnMappings, System.Data.DataTable dt) {
            this.BulkInsertTableAsync(columnMappings, dt, null);
        }
        
        /// <remarks/>
        public void BulkInsertTableAsync(string[] columnMappings, System.Data.DataTable dt, object userState) {
            if ((this.BulkInsertTableOperationCompleted == null)) {
                this.BulkInsertTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBulkInsertTableOperationCompleted);
            }
            this.InvokeAsync("BulkInsertTable", new object[] {
                        columnMappings,
                        dt}, this.BulkInsertTableOperationCompleted, userState);
        }
        
        private void OnBulkInsertTableOperationCompleted(object arg) {
            if ((this.BulkInsertTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BulkInsertTableCompleted(this, new BulkInsertTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteReturnIntCompletedEventHandler(object sender, ExecuteReturnIntCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteReturnIntCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteReturnIntCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteReturnTbCompletedEventHandler(object sender, ExecuteReturnTbCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteReturnTbCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteReturnTbCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string selectSql {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteTransCompletedEventHandler(object sender, ExecuteTransCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteTransCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteTransCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteDynamicSqlCompletedEventHandler(object sender, ExecuteDynamicSqlCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteDynamicSqlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteDynamicSqlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteDatasetCompletedEventHandler(object sender, ExecuteDatasetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteDatasetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteDatasetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteCheckBoxTableCompletedEventHandler(object sender, ExecuteCheckBoxTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteCheckBoxTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteCheckBoxTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SearchTbSqlWhereCompletedEventHandler(object sender, SearchTbSqlWhereCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchTbSqlWhereCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchTbSqlWhereCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ExecuteUpdateCompletedEventHandler(object sender, ExecuteUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExecuteUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExecuteUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errMsg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void BulkInsertTableCompletedEventHandler(object sender, BulkInsertTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BulkInsertTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BulkInsertTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591