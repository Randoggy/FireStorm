﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FireStorm.FireStormDealerWS {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://trinitysoft.net/", ConfigurationName="FireStormDealerWS.FirestormDealerWSSoap")]
    public interface FirestormDealerWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerDetail(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetail", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetailExtended", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerDetailExtended(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer, string OldID, string HomePhone, string WorkPhone, string FaxPhone, string CellPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetailExtended", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailExtendedAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer, string OldID, string HomePhone, string WorkPhone, string FaxPhone, string CellPhone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/DealerSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DealerSearch(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string State, string DealerURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/DealerSearch", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DealerSearchAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string State, string DealerURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/SaveDealerDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool SaveDealerDetail(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string LastName, 
                    string FirstName, 
                    string MiddleInitial, 
                    string CompanyName, 
                    string ShipAddress1, 
                    string ShipAddress2, 
                    string ShipCity, 
                    string ShipState, 
                    string ShipZip, 
                    string ShipCountry, 
                    string MailAddress1, 
                    string MailAddress2, 
                    string MailCity, 
                    string MailState, 
                    string MailZip, 
                    string MailCountry, 
                    string WorkPhone, 
                    string HomePhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string BirthDate, 
                    string EmailOptOutUpline, 
                    string EmailOptOutGlobal, 
                    string EmailFormatTextOnly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/SaveDealerDetail", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SaveDealerDetailAsync(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string LastName, 
                    string FirstName, 
                    string MiddleInitial, 
                    string CompanyName, 
                    string ShipAddress1, 
                    string ShipAddress2, 
                    string ShipCity, 
                    string ShipState, 
                    string ShipZip, 
                    string ShipCountry, 
                    string MailAddress1, 
                    string MailAddress2, 
                    string MailCity, 
                    string MailState, 
                    string MailZip, 
                    string MailCountry, 
                    string WorkPhone, 
                    string HomePhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string BirthDate, 
                    string EmailOptOutUpline, 
                    string EmailOptOutGlobal, 
                    string EmailFormatTextOnly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerListByDealerIDRange", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerListByDealerIDRange(string Token, string Context, string StartDealerID, string EndDealerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerListByDealerIDRange", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerListByDealerIDRangeAsync(string Token, string Context, string StartDealerID, string EndDealerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/UpdateTaxpayerNumber", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool UpdateTaxpayerNumber(string Token, string Context, int DealerID, string TaxPayerNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/UpdateTaxpayerNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> UpdateTaxpayerNumberAsync(string Token, string Context, int DealerID, string TaxPayerNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/DealerLocator", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DealerLocator(string Token, string Context, string SourceZipCode, string LastName, double MaxDistanceInMiles, int MaxResults, string FirstName, string StateID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/DealerLocator", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DealerLocatorAsync(string Token, string Context, string SourceZipCode, string LastName, double MaxDistanceInMiles, int MaxResults, string FirstName, string StateID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetUnpaidCommissions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        double GetUnpaidCommissions(string Token, string Context, string DealerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetUnpaidCommissions", ReplyAction="*")]
        System.Threading.Tasks.Task<double> GetUnpaidCommissionsAsync(string Token, string Context, string DealerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerCommissionsByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerCommissionsByDate(string Token, string Context, string DealerID, System.DateTime StartDate, System.DateTime EndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerCommissionsByDate", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerCommissionsByDateAsync(string Token, string Context, string DealerID, System.DateTime StartDate, System.DateTime EndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/SaveDealerOption", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool SaveDealerOption(string Token, string Context, int DealerID, string OptionName, string User1, string User2, string User3, string User4, string User5, string User6, string User7, string User8, string User9, string User10);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/SaveDealerOption", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SaveDealerOptionAsync(string Token, string Context, int DealerID, string OptionName, string User1, string User2, string User3, string User4, string User5, string User6, string User7, string User8, string User9, string User10);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerOptions(string Token, string Context, int DealerID, string OptionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerOptions", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerOptionsAsync(string Token, string Context, int DealerID, string OptionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetailExtended2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDealerDetailExtended2(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string TaxPayerNumber, 
                    string FirstName, 
                    string LastName, 
                    string CompanyName, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string IsCustomer, 
                    string OldID, 
                    string HomePhone, 
                    string WorkPhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string IsDealer, 
                    string IsActive);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://trinitysoft.net/GetDealerDetailExtended2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailExtended2Async(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string TaxPayerNumber, 
                    string FirstName, 
                    string LastName, 
                    string CompanyName, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string IsCustomer, 
                    string OldID, 
                    string HomePhone, 
                    string WorkPhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string IsDealer, 
                    string IsActive);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FirestormDealerWSSoapChannel : FireStorm.FireStormDealerWS.FirestormDealerWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FirestormDealerWSSoapClient : System.ServiceModel.ClientBase<FireStorm.FireStormDealerWS.FirestormDealerWSSoap>, FireStorm.FireStormDealerWS.FirestormDealerWSSoap {
        
        public FirestormDealerWSSoapClient() {
        }
        
        public FirestormDealerWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FirestormDealerWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirestormDealerWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirestormDealerWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetDealerDetail(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer) {
            return base.Channel.GetDealerDetail(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer) {
            return base.Channel.GetDealerDetailAsync(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer);
        }
        
        public System.Data.DataTable GetDealerDetailExtended(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer, string OldID, string HomePhone, string WorkPhone, string FaxPhone, string CellPhone) {
            return base.Channel.GetDealerDetailExtended(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer, OldID, HomePhone, WorkPhone, FaxPhone, CellPhone);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailExtendedAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string IsCustomer, string OldID, string HomePhone, string WorkPhone, string FaxPhone, string CellPhone) {
            return base.Channel.GetDealerDetailExtendedAsync(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer, OldID, HomePhone, WorkPhone, FaxPhone, CellPhone);
        }
        
        public System.Data.DataTable DealerSearch(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string State, string DealerURL) {
            return base.Channel.DealerSearch(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, State, DealerURL);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DealerSearchAsync(string Token, string Context, string DealerID, string TaxPayerNumber, string FirstName, string LastName, string CompanyName, string PrimaryEmail, string SecondaryEmail, string State, string DealerURL) {
            return base.Channel.DealerSearchAsync(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, State, DealerURL);
        }
        
        public bool SaveDealerDetail(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string LastName, 
                    string FirstName, 
                    string MiddleInitial, 
                    string CompanyName, 
                    string ShipAddress1, 
                    string ShipAddress2, 
                    string ShipCity, 
                    string ShipState, 
                    string ShipZip, 
                    string ShipCountry, 
                    string MailAddress1, 
                    string MailAddress2, 
                    string MailCity, 
                    string MailState, 
                    string MailZip, 
                    string MailCountry, 
                    string WorkPhone, 
                    string HomePhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string BirthDate, 
                    string EmailOptOutUpline, 
                    string EmailOptOutGlobal, 
                    string EmailFormatTextOnly) {
            return base.Channel.SaveDealerDetail(Token, Context, DealerID, LastName, FirstName, MiddleInitial, CompanyName, ShipAddress1, ShipAddress2, ShipCity, ShipState, ShipZip, ShipCountry, MailAddress1, MailAddress2, MailCity, MailState, MailZip, MailCountry, WorkPhone, HomePhone, FaxPhone, CellPhone, PrimaryEmail, SecondaryEmail, BirthDate, EmailOptOutUpline, EmailOptOutGlobal, EmailFormatTextOnly);
        }
        
        public System.Threading.Tasks.Task<bool> SaveDealerDetailAsync(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string LastName, 
                    string FirstName, 
                    string MiddleInitial, 
                    string CompanyName, 
                    string ShipAddress1, 
                    string ShipAddress2, 
                    string ShipCity, 
                    string ShipState, 
                    string ShipZip, 
                    string ShipCountry, 
                    string MailAddress1, 
                    string MailAddress2, 
                    string MailCity, 
                    string MailState, 
                    string MailZip, 
                    string MailCountry, 
                    string WorkPhone, 
                    string HomePhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string BirthDate, 
                    string EmailOptOutUpline, 
                    string EmailOptOutGlobal, 
                    string EmailFormatTextOnly) {
            return base.Channel.SaveDealerDetailAsync(Token, Context, DealerID, LastName, FirstName, MiddleInitial, CompanyName, ShipAddress1, ShipAddress2, ShipCity, ShipState, ShipZip, ShipCountry, MailAddress1, MailAddress2, MailCity, MailState, MailZip, MailCountry, WorkPhone, HomePhone, FaxPhone, CellPhone, PrimaryEmail, SecondaryEmail, BirthDate, EmailOptOutUpline, EmailOptOutGlobal, EmailFormatTextOnly);
        }
        
        public System.Data.DataTable GetDealerListByDealerIDRange(string Token, string Context, string StartDealerID, string EndDealerID) {
            return base.Channel.GetDealerListByDealerIDRange(Token, Context, StartDealerID, EndDealerID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerListByDealerIDRangeAsync(string Token, string Context, string StartDealerID, string EndDealerID) {
            return base.Channel.GetDealerListByDealerIDRangeAsync(Token, Context, StartDealerID, EndDealerID);
        }
        
        public bool UpdateTaxpayerNumber(string Token, string Context, int DealerID, string TaxPayerNumber) {
            return base.Channel.UpdateTaxpayerNumber(Token, Context, DealerID, TaxPayerNumber);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateTaxpayerNumberAsync(string Token, string Context, int DealerID, string TaxPayerNumber) {
            return base.Channel.UpdateTaxpayerNumberAsync(Token, Context, DealerID, TaxPayerNumber);
        }
        
        public System.Data.DataTable DealerLocator(string Token, string Context, string SourceZipCode, string LastName, double MaxDistanceInMiles, int MaxResults, string FirstName, string StateID) {
            return base.Channel.DealerLocator(Token, Context, SourceZipCode, LastName, MaxDistanceInMiles, MaxResults, FirstName, StateID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DealerLocatorAsync(string Token, string Context, string SourceZipCode, string LastName, double MaxDistanceInMiles, int MaxResults, string FirstName, string StateID) {
            return base.Channel.DealerLocatorAsync(Token, Context, SourceZipCode, LastName, MaxDistanceInMiles, MaxResults, FirstName, StateID);
        }
        
        public double GetUnpaidCommissions(string Token, string Context, string DealerID) {
            return base.Channel.GetUnpaidCommissions(Token, Context, DealerID);
        }
        
        public System.Threading.Tasks.Task<double> GetUnpaidCommissionsAsync(string Token, string Context, string DealerID) {
            return base.Channel.GetUnpaidCommissionsAsync(Token, Context, DealerID);
        }
        
        public System.Data.DataTable GetDealerCommissionsByDate(string Token, string Context, string DealerID, System.DateTime StartDate, System.DateTime EndDate) {
            return base.Channel.GetDealerCommissionsByDate(Token, Context, DealerID, StartDate, EndDate);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerCommissionsByDateAsync(string Token, string Context, string DealerID, System.DateTime StartDate, System.DateTime EndDate) {
            return base.Channel.GetDealerCommissionsByDateAsync(Token, Context, DealerID, StartDate, EndDate);
        }
        
        public bool SaveDealerOption(string Token, string Context, int DealerID, string OptionName, string User1, string User2, string User3, string User4, string User5, string User6, string User7, string User8, string User9, string User10) {
            return base.Channel.SaveDealerOption(Token, Context, DealerID, OptionName, User1, User2, User3, User4, User5, User6, User7, User8, User9, User10);
        }
        
        public System.Threading.Tasks.Task<bool> SaveDealerOptionAsync(string Token, string Context, int DealerID, string OptionName, string User1, string User2, string User3, string User4, string User5, string User6, string User7, string User8, string User9, string User10) {
            return base.Channel.SaveDealerOptionAsync(Token, Context, DealerID, OptionName, User1, User2, User3, User4, User5, User6, User7, User8, User9, User10);
        }
        
        public System.Data.DataTable GetDealerOptions(string Token, string Context, int DealerID, string OptionName) {
            return base.Channel.GetDealerOptions(Token, Context, DealerID, OptionName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerOptionsAsync(string Token, string Context, int DealerID, string OptionName) {
            return base.Channel.GetDealerOptionsAsync(Token, Context, DealerID, OptionName);
        }
        
        public System.Data.DataTable GetDealerDetailExtended2(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string TaxPayerNumber, 
                    string FirstName, 
                    string LastName, 
                    string CompanyName, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string IsCustomer, 
                    string OldID, 
                    string HomePhone, 
                    string WorkPhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string IsDealer, 
                    string IsActive) {
            return base.Channel.GetDealerDetailExtended2(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer, OldID, HomePhone, WorkPhone, FaxPhone, CellPhone, IsDealer, IsActive);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDealerDetailExtended2Async(
                    string Token, 
                    string Context, 
                    string DealerID, 
                    string TaxPayerNumber, 
                    string FirstName, 
                    string LastName, 
                    string CompanyName, 
                    string PrimaryEmail, 
                    string SecondaryEmail, 
                    string IsCustomer, 
                    string OldID, 
                    string HomePhone, 
                    string WorkPhone, 
                    string FaxPhone, 
                    string CellPhone, 
                    string IsDealer, 
                    string IsActive) {
            return base.Channel.GetDealerDetailExtended2Async(Token, Context, DealerID, TaxPayerNumber, FirstName, LastName, CompanyName, PrimaryEmail, SecondaryEmail, IsCustomer, OldID, HomePhone, WorkPhone, FaxPhone, CellPhone, IsDealer, IsActive);
        }
    }
}
