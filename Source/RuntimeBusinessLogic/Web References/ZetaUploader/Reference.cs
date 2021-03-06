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

namespace ZetaResourceEditor.RuntimeBusinessLogic.Web_References.ZetaUploader
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Web.Services;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "ZetaUploaderCommunicationSoap", Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZetaUploaderCommunication : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback SendFileOperationCompleted;

        private System.Threading.SendOrPostCallback SendFile2OperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public ZetaUploaderCommunication()
        {
            this.Url = "https://www.zeta-uploader.com/WebServices/ZetaUploaderCommunication.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event SendFileCompletedEventHandler SendFileCompleted;

        /// <remarks/>
        public event SendFile2CompletedEventHandler SendFile2Completed;

        /// <remarks/>
        [SoapDocumentMethod("http://zetauploader.zeta-software.de/webservices/SendFile", RequestNamespace = "http://zetauploader.zeta-software.de/webservices/", ResponseNamespace = "http://zetauploader.zeta-software.de/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ZetaUploaderCommunicationClientTransferResult SendFile(ZetaUploaderCommunicationClientTransferInformation information)
        {
            var results = this.Invoke("SendFile", new object[] {
                        information});
            return ((ZetaUploaderCommunicationClientTransferResult)(results[0]));
        }

        /// <remarks/>
        public void SendFileAsync(ZetaUploaderCommunicationClientTransferInformation information)
        {
            this.SendFileAsync(information, null);
        }

        /// <remarks/>
        public void SendFileAsync(ZetaUploaderCommunicationClientTransferInformation information, object userState)
        {
            if ((this.SendFileOperationCompleted == null))
            {
                this.SendFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendFileOperationCompleted);
            }
            this.InvokeAsync("SendFile", new object[] {
                        information}, this.SendFileOperationCompleted, userState);
        }

        private void OnSendFileOperationCompleted(object arg)
        {
            if ((this.SendFileCompleted != null))
            {
                var invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendFileCompleted(this, new SendFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [SoapDocumentMethod("http://zetauploader.zeta-software.de/webservices/SendFile2", RequestNamespace = "http://zetauploader.zeta-software.de/webservices/", ResponseNamespace = "http://zetauploader.zeta-software.de/webservices/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ZetaUploaderCommunicationClientTransferResult2 SendFile2(ZetaUploaderCommunicationClientTransferInformation2 information)
        {
            var results = this.Invoke("SendFile2", new object[] {
                        information});
            return ((ZetaUploaderCommunicationClientTransferResult2)(results[0]));
        }

        /// <remarks/>
        public void SendFile2Async(ZetaUploaderCommunicationClientTransferInformation2 information)
        {
            this.SendFile2Async(information, null);
        }

        /// <remarks/>
        public void SendFile2Async(ZetaUploaderCommunicationClientTransferInformation2 information, object userState)
        {
            if ((this.SendFile2OperationCompleted == null))
            {
                this.SendFile2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendFile2OperationCompleted);
            }
            this.InvokeAsync("SendFile2", new object[] {
                        information}, this.SendFile2OperationCompleted, userState);
        }

        private void OnSendFile2OperationCompleted(object arg)
        {
            if ((this.SendFile2Completed != null))
            {
                var invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendFile2Completed(this, new SendFile2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            var wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZetaUploaderCommunicationClientTransferInformation
    {

        private string apiKeyField;

        private string fileNameField;

        private byte[] fileContentField;

        private string eMailSubjectField;

        private string eMailBodyField;

        private string additionalRemarksField;

        private string[] eMailReceiverAddressesField;

        private string eMailSenderFromNameField;

        private string eMailSenderFromAddressField;

        private string eMailSenderReplyToNameField;

        private string eMailSenderReplyToAddressField;

        private string languageField;

        private bool isPasswordProtectedField;

        private string passwordField;

        private bool doesExpireField;

        private System.DateTime expirationDateField;

        /// <remarks/>
        public string ApiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] FileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }

        /// <remarks/>
        public string EMailSubject
        {
            get
            {
                return this.eMailSubjectField;
            }
            set
            {
                this.eMailSubjectField = value;
            }
        }

        /// <remarks/>
        public string EMailBody
        {
            get
            {
                return this.eMailBodyField;
            }
            set
            {
                this.eMailBodyField = value;
            }
        }

        /// <remarks/>
        public string AdditionalRemarks
        {
            get
            {
                return this.additionalRemarksField;
            }
            set
            {
                this.additionalRemarksField = value;
            }
        }

        /// <remarks/>
        public string[] EMailReceiverAddresses
        {
            get
            {
                return this.eMailReceiverAddressesField;
            }
            set
            {
                this.eMailReceiverAddressesField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderFromName
        {
            get
            {
                return this.eMailSenderFromNameField;
            }
            set
            {
                this.eMailSenderFromNameField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderFromAddress
        {
            get
            {
                return this.eMailSenderFromAddressField;
            }
            set
            {
                this.eMailSenderFromAddressField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderReplyToName
        {
            get
            {
                return this.eMailSenderReplyToNameField;
            }
            set
            {
                this.eMailSenderReplyToNameField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderReplyToAddress
        {
            get
            {
                return this.eMailSenderReplyToAddressField;
            }
            set
            {
                this.eMailSenderReplyToAddressField = value;
            }
        }

        /// <remarks/>
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public bool IsPasswordProtected
        {
            get
            {
                return this.isPasswordProtectedField;
            }
            set
            {
                this.isPasswordProtectedField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public bool DoesExpire
        {
            get
            {
                return this.doesExpireField;
            }
            set
            {
                this.doesExpireField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZetaUploaderCommunicationClientTransferResult2
    {

        private string downloadUrlField;

        private System.DateTime downloadUrlExpirationDateField;

        private ZulPair[] userStatesField;

        /// <remarks/>
        public string DownloadUrl
        {
            get
            {
                return this.downloadUrlField;
            }
            set
            {
                this.downloadUrlField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DownloadUrlExpirationDate
        {
            get
            {
                return this.downloadUrlExpirationDateField;
            }
            set
            {
                this.downloadUrlExpirationDateField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public ZulPair[] UserStates
        {
            get
            {
                return this.userStatesField;
            }
            set
            {
                this.userStatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZulPair
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZetaUploaderCommunicationClientTransferInformation2
    {

        private string apiKeyField;

        private string fileNameField;

        private byte[] fileContentField;

        private string eMailSubjectField;

        private string eMailBodyField;

        private string additionalRemarksField;

        private string[] eMailReceiverAddressesField;

        private string eMailSenderFromNameField;

        private string eMailSenderFromAddressField;

        private string eMailSenderReplyToNameField;

        private string eMailSenderReplyToAddressField;

        private string languageField;

        private bool isPasswordProtectedField;

        private string passwordField;

        private bool doesExpireField;

        private System.DateTime expirationDateField;

        private ZulPair[] userStatesField;

        /// <remarks/>
        public string ApiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] FileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }

        /// <remarks/>
        public string EMailSubject
        {
            get
            {
                return this.eMailSubjectField;
            }
            set
            {
                this.eMailSubjectField = value;
            }
        }

        /// <remarks/>
        public string EMailBody
        {
            get
            {
                return this.eMailBodyField;
            }
            set
            {
                this.eMailBodyField = value;
            }
        }

        /// <remarks/>
        public string AdditionalRemarks
        {
            get
            {
                return this.additionalRemarksField;
            }
            set
            {
                this.additionalRemarksField = value;
            }
        }

        /// <remarks/>
        public string[] EMailReceiverAddresses
        {
            get
            {
                return this.eMailReceiverAddressesField;
            }
            set
            {
                this.eMailReceiverAddressesField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderFromName
        {
            get
            {
                return this.eMailSenderFromNameField;
            }
            set
            {
                this.eMailSenderFromNameField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderFromAddress
        {
            get
            {
                return this.eMailSenderFromAddressField;
            }
            set
            {
                this.eMailSenderFromAddressField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderReplyToName
        {
            get
            {
                return this.eMailSenderReplyToNameField;
            }
            set
            {
                this.eMailSenderReplyToNameField = value;
            }
        }

        /// <remarks/>
        public string EMailSenderReplyToAddress
        {
            get
            {
                return this.eMailSenderReplyToAddressField;
            }
            set
            {
                this.eMailSenderReplyToAddressField = value;
            }
        }

        /// <remarks/>
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public bool IsPasswordProtected
        {
            get
            {
                return this.isPasswordProtectedField;
            }
            set
            {
                this.isPasswordProtectedField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public bool DoesExpire
        {
            get
            {
                return this.doesExpireField;
            }
            set
            {
                this.doesExpireField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public ZulPair[] UserStates
        {
            get
            {
                return this.userStatesField;
            }
            set
            {
                this.userStatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://zetauploader.zeta-software.de/webservices/")]
    public partial class ZetaUploaderCommunicationClientTransferResult
    {

        private string downloadUrlField;

        private System.DateTime downloadUrlExpirationDateField;

        /// <remarks/>
        public string DownloadUrl
        {
            get
            {
                return this.downloadUrlField;
            }
            set
            {
                this.downloadUrlField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DownloadUrlExpirationDate
        {
            get
            {
                return this.downloadUrlExpirationDateField;
            }
            set
            {
                this.downloadUrlExpirationDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SendFileCompletedEventHandler(object sender, SendFileCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class SendFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SendFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ZetaUploaderCommunicationClientTransferResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ZetaUploaderCommunicationClientTransferResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SendFile2CompletedEventHandler(object sender, SendFile2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class SendFile2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SendFile2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ZetaUploaderCommunicationClientTransferResult2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ZetaUploaderCommunicationClientTransferResult2)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591