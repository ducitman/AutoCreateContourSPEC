﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoCreateContourSPEC.WebMailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebMailService.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessage", ReplyAction="http://tempuri.org/IEmailService/SendMessageResponse")]
        void SendMessage(string[] receivers, string[] ccs, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessage", ReplyAction="http://tempuri.org/IEmailService/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(string[] receivers, string[] ccs, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageCcBcc", ReplyAction="http://tempuri.org/IEmailService/SendMessageCcBccResponse")]
        void SendMessageCcBcc(string[] receivers, string[] ccs, string[] bcc, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageCcBcc", ReplyAction="http://tempuri.org/IEmailService/SendMessageCcBccResponse")]
        System.Threading.Tasks.Task SendMessageCcBccAsync(string[] receivers, string[] ccs, string[] bcc, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageBCC", ReplyAction="http://tempuri.org/IEmailService/SendMessageBCCResponse")]
        void SendMessageBCC(string[] receivers, string[] bcc, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageBCC", ReplyAction="http://tempuri.org/IEmailService/SendMessageBCCResponse")]
        System.Threading.Tasks.Task SendMessageBCCAsync(string[] receivers, string[] bcc, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageWithOutlookEmail", ReplyAction="http://tempuri.org/IEmailService/SendMessageWithOutlookEmailResponse")]
        void SendMessageWithOutlookEmail(string[] receivers, string[] ccs, string[] bcc, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMessageWithOutlookEmail", ReplyAction="http://tempuri.org/IEmailService/SendMessageWithOutlookEmailResponse")]
        System.Threading.Tasks.Task SendMessageWithOutlookEmailAsync(string[] receivers, string[] ccs, string[] bcc, string subject, string body);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : AutoCreateContourSPEC.WebMailService.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<AutoCreateContourSPEC.WebMailService.IEmailService>, AutoCreateContourSPEC.WebMailService.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendMessage(string[] receivers, string[] ccs, string subject, string body) {
            base.Channel.SendMessage(receivers, ccs, subject, body);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string[] receivers, string[] ccs, string subject, string body) {
            return base.Channel.SendMessageAsync(receivers, ccs, subject, body);
        }
        
        public void SendMessageCcBcc(string[] receivers, string[] ccs, string[] bcc, string subject, string body) {
            base.Channel.SendMessageCcBcc(receivers, ccs, bcc, subject, body);
        }
        
        public System.Threading.Tasks.Task SendMessageCcBccAsync(string[] receivers, string[] ccs, string[] bcc, string subject, string body) {
            return base.Channel.SendMessageCcBccAsync(receivers, ccs, bcc, subject, body);
        }
        
        public void SendMessageBCC(string[] receivers, string[] bcc, string subject, string body) {
            base.Channel.SendMessageBCC(receivers, bcc, subject, body);
        }
        
        public System.Threading.Tasks.Task SendMessageBCCAsync(string[] receivers, string[] bcc, string subject, string body) {
            return base.Channel.SendMessageBCCAsync(receivers, bcc, subject, body);
        }
        
        public void SendMessageWithOutlookEmail(string[] receivers, string[] ccs, string[] bcc, string subject, string body) {
            base.Channel.SendMessageWithOutlookEmail(receivers, ccs, bcc, subject, body);
        }
        
        public System.Threading.Tasks.Task SendMessageWithOutlookEmailAsync(string[] receivers, string[] ccs, string[] bcc, string subject, string body) {
            return base.Channel.SendMessageWithOutlookEmailAsync(receivers, ccs, bcc, subject, body);
        }
    }
}