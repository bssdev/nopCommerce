﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nop.Plugin.SMS.Clickatell.Clickatell {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.clickatell.com/soap/webservice", ConfigurationName="Clickatell.PushServerWSPortType")]
    internal interface PushServerWSPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/auth", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string auth(int api_id, string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/ping", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string ping(string session_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/sendmsg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] sendmsg(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string from, 
                    string text, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int unicode, 
                    string msg_type, 
                    string udh, 
                    string data, 
                    int validity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/querymsg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] querymsg(string session_id, int api_id, string user, string password, string apimsgid, string climsgid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/delmsg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] delmsg(string session_id, string api_id, string user, string password, string apimsgid, string climsgid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/getbalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getbalance(string session_id, int api_id, string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/routeCoverage", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string routeCoverage(string session_id, int api_id, string user, string password, string msisdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/si_push", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] si_push(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string si_id, 
                    string si_url, 
                    string si_text, 
                    string si_created, 
                    string si_expires, 
                    string si_action, 
                    string from, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int validity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/ind_push", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] ind_push(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string mms_subject, 
                    string mms_class, 
                    string mms_expire, 
                    string mms_from, 
                    string mms_url, 
                    string from, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int validity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/token_pay", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string token_pay(string session_id, int api_id, string user, string password, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/startbatch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] startbatch(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string from, 
                    int concat, 
                    string template, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int unicode, 
                    string msg_type, 
                    string udh, 
                    string data, 
                    int validity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/senditem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] senditem(string session_id, int api_id, string user, string password, string batch_id, string[] to, string field1, string field2, string field3, string field4);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/quicksend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] quicksend(string session_id, int api_id, string user, string password, string batch_id, string[] to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/endbatch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] endbatch(string session_id, int api_id, string user, string password, string batch_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.clickatell.com/soap/webservice_vs.php/getmsgcharge", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string[] getmsgcharge(string session_id, int api_id, string user, string password, string apimsgid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface PushServerWSPortTypeChannel : Nop.Plugin.SMS.Clickatell.Clickatell.PushServerWSPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class PushServerWSPortTypeClient : System.ServiceModel.ClientBase<Nop.Plugin.SMS.Clickatell.Clickatell.PushServerWSPortType>, Nop.Plugin.SMS.Clickatell.Clickatell.PushServerWSPortType {
        
        public PushServerWSPortTypeClient() {
        }
        
        public PushServerWSPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PushServerWSPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PushServerWSPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PushServerWSPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string auth(int api_id, string user, string password) {
            return base.Channel.auth(api_id, user, password);
        }
        
        public string ping(string session_id) {
            return base.Channel.ping(session_id);
        }
        
        public string[] sendmsg(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string from, 
                    string text, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int unicode, 
                    string msg_type, 
                    string udh, 
                    string data, 
                    int validity) {
            return base.Channel.sendmsg(session_id, api_id, user, password, to, from, text, concat, deliv_ack, msg_callback, deliv_time, max_credits, req_feat, queue, escalate, mo, cliMsgId, unicode, msg_type, udh, data, validity);
        }
        
        public string[] querymsg(string session_id, int api_id, string user, string password, string apimsgid, string climsgid) {
            return base.Channel.querymsg(session_id, api_id, user, password, apimsgid, climsgid);
        }
        
        public string[] delmsg(string session_id, string api_id, string user, string password, string apimsgid, string climsgid) {
            return base.Channel.delmsg(session_id, api_id, user, password, apimsgid, climsgid);
        }
        
        public string getbalance(string session_id, int api_id, string user, string password) {
            return base.Channel.getbalance(session_id, api_id, user, password);
        }
        
        public string routeCoverage(string session_id, int api_id, string user, string password, string msisdn) {
            return base.Channel.routeCoverage(session_id, api_id, user, password, msisdn);
        }
        
        public string[] si_push(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string si_id, 
                    string si_url, 
                    string si_text, 
                    string si_created, 
                    string si_expires, 
                    string si_action, 
                    string from, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int validity) {
            return base.Channel.si_push(session_id, api_id, user, password, to, si_id, si_url, si_text, si_created, si_expires, si_action, from, concat, deliv_ack, msg_callback, deliv_time, max_credits, req_feat, queue, escalate, mo, cliMsgId, validity);
        }
        
        public string[] ind_push(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string[] to, 
                    string mms_subject, 
                    string mms_class, 
                    string mms_expire, 
                    string mms_from, 
                    string mms_url, 
                    string from, 
                    int concat, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int validity) {
            return base.Channel.ind_push(session_id, api_id, user, password, to, mms_subject, mms_class, mms_expire, mms_from, mms_url, from, concat, deliv_ack, msg_callback, deliv_time, max_credits, req_feat, queue, escalate, mo, cliMsgId, validity);
        }
        
        public string token_pay(string session_id, int api_id, string user, string password, string token) {
            return base.Channel.token_pay(session_id, api_id, user, password, token);
        }
        
        public string[] startbatch(
                    string session_id, 
                    int api_id, 
                    string user, 
                    string password, 
                    string from, 
                    int concat, 
                    string template, 
                    int deliv_ack, 
                    int msg_callback, 
                    int deliv_time, 
                    float max_credits, 
                    int req_feat, 
                    int queue, 
                    int escalate, 
                    int mo, 
                    string cliMsgId, 
                    int unicode, 
                    string msg_type, 
                    string udh, 
                    string data, 
                    int validity) {
            return base.Channel.startbatch(session_id, api_id, user, password, from, concat, template, deliv_ack, msg_callback, deliv_time, max_credits, req_feat, queue, escalate, mo, cliMsgId, unicode, msg_type, udh, data, validity);
        }
        
        public string[] senditem(string session_id, int api_id, string user, string password, string batch_id, string[] to, string field1, string field2, string field3, string field4) {
            return base.Channel.senditem(session_id, api_id, user, password, batch_id, to, field1, field2, field3, field4);
        }
        
        public string[] quicksend(string session_id, int api_id, string user, string password, string batch_id, string[] to) {
            return base.Channel.quicksend(session_id, api_id, user, password, batch_id, to);
        }
        
        public string[] endbatch(string session_id, int api_id, string user, string password, string batch_id) {
            return base.Channel.endbatch(session_id, api_id, user, password, batch_id);
        }
        
        public string[] getmsgcharge(string session_id, int api_id, string user, string password, string apimsgid) {
            return base.Channel.getmsgcharge(session_id, api_id, user, password, apimsgid);
        }
    }
}
