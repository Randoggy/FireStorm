using FireStorm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FireStorm.Controllers
{
    public class DealerWSController : Controller
    {
        //
        // GET: /DealerWS/

        FireStormDealerWS.FirestormDealerWSSoapClient Client = new FireStormDealerWS.FirestormDealerWSSoapClient();
        public ActionResult Index()
        {
            return View();           
        }
        public ActionResult GetDealerDetail(DealerBasicInfoDO dbi)
        {
            DataTable dt;
            DealerDetailDO d = null;
            try
            {
                dt = Client.GetDealerDetail(dbi.Token, dbi.Context, dbi.DealerID.ToString(), dbi.TaxPayerNumber, dbi.Firstname, dbi.LastName, dbi.CompanyName, dbi.PrimaryEmail, dbi.SecondaryEmail, dbi.IsCustomer.ToString());

                d = dt.AsEnumerable().Select(obj => new DealerDetailDO
                {
                    Account = obj.Field<String>("Account"),
                    AffiliateSponsoringDealerID = obj.Field<Int32?>("AffiliateSponsoringDealerID"),
                    APDealershipNumber = obj.Field<Int32?>("APDealershipNumber"),
                    APLineage = obj.Field<char?>("APLineage"),
                    APPlacementDealerID = obj.Field<Int32?>("APPlacementDealerID"),
                    CurrencyTypeID = obj.Field<Int32?>("CurrencyTypeID"),
                    CustomerStatusID = obj.Field<Int32?>("CustomerStatusID"),
                    CustomerTypeID = obj.Field<Int32?>("CustomerTypeID"),
                    DateEmailPrimaryLastValidated = obj.Field<DateTime?>("DateEmailPrimaryLastValidated"),
                    DateExported = obj.Field<DateTime?>("DateExported"),
                    DealerStatusCodeID = obj.Field<Int32?>("DealerStatusCodeID"),
                    DEFSponsorDealerID = obj.Field<Int32?>("DEFSponsorDealerID"),
                    DEFSponsorDealershipNumber = obj.Field<Int32?>("DEFSponsorDealershipNumber"),
                    EnrollDate = obj.Field<DateTime?>("EnrollDate"),
                    FaxPhone = obj.Field<String>("FaxPhone"),
                    NPO = obj.Field<Int16?>("NPO"),
                    PayCurrencyTypeID = obj.Field<Int32?>("PayCurrencyTypeID"),
                    SponsoringDealerID = obj.Field<Int32?>("SponsoringDealerID"),
                    SubAccount = obj.Field<String>("SubAccount"),
                    TaxExempt = obj.Field<Int16?>("TaxExempt"),
                    UseEWalletOnly = obj.Field<Int32?>("UseEWalletOnly"),
                    WebGreeting = obj.Field<String>("WebGreeting"),
                    CustomerType = obj.Field<String>("CustomerType"),
                    CustomerStatus = obj.Field<String>("CustomerStatus"),
                    StructureSponsoringDealerID = obj.Field<String>("StructureSponsoringDealerID"),

                    AllowWebAccess = obj.Field<Int16?>("AllowWebAccess"),
                    BirthDate = obj.Field<DateTime>("BirthDate"),
                    CellPhone = obj.Field<String>("CellPhone"),
                    CompanyName = obj.Field<String>("CompanyName"),
                    DealerID = obj.Field<Int32?>("DealerID"),
                    DealerURL = obj.Field<String>("DealerURL"),
                    Firstname = obj.Field<String>("Firstname"),
                    IsCustomer = obj.Field<Int16?>("IsCustomer"),
                    TaxPayerNumber = obj.Field<String>("TaxPayerNumber"),
                    HomePhone = obj.Field<String>("HomePhone"),
                    LastName = obj.Field<String>("LastName"),
                    MiddleInitial = obj.Field<String>("MiddleInitial"),
                    OldID = obj.Field<String>("OldID"),
                    Password = obj.Field<String>("Password"),

                    EmailDetail = new EmailDetailDO
                    {
                        EMailFormatTextOnly = obj.Field<Int16?>("EMailFormatTextOnly"),
                        EmailOptOutGlobal = obj.Field<Int16?>("EmailOptOutGlobal"),
                        EmailOptOutUpline = obj.Field<Int16?>("EmailOptOutUpline"),
                        EmailPrimary = obj.Field<String>("EmailPrimary"),
                        EmailPrimaryValidated = obj.Field<Int16?>("EmailPrimaryValidated"),
                        EmailPrimaryValidationResult = obj.Field<String>("EmailPrimaryValidationResult"),
                        EmailSecondary = obj.Field<String>("EmailSecondary"),
                        lstMailAddress = new List<String>(){
                        obj.Field<String>("MailAddress1"),
                        obj.Field<String>("MailAddress2")                    
                    },
                        MailCity = obj.Field<String>("MailCity"),
                        MailCountry = obj.Field<String>("MailCountry"),
                        MailState = obj.Field<String>("MailState"),
                        MailZip = obj.Field<String>("MailZip")
                    },
                    ShippingDetail = new ShippingDetailDO
                    {
                        lstShipAddress = new List<String>(){
                        obj.Field<String>("ShipAddress1"),
                        obj.Field<String>("ShipAddress2")
                    },
                        ShipCity = obj.Field<String>("ShipCity"),
                        ShipCountry = obj.Field<String>("ShipCountry"),
                        ShipState = obj.Field<String>("ShipState"),
                        ShipZip = obj.Field<String>("ShipZip")
                    },
                    SMSDetail = new SMSDetailDO()
                    {
                        SMSTextInfoAlerts = obj.Field<Int16?>("SMSTextInfoAlerts"),
                        SMSTextOnEnroll = obj.Field<Int16?>("SMSTextOnEnroll"),
                        SMSTextOnOrder = obj.Field<Int16?>("SMSTextOnOrder"),
                        SMSTextOptOut = obj.Field<Int16?>("SMSTextOptOut")
                    }
                }).FirstOrDefault();
            }
            catch (System.ServiceModel.FaultException fe)
            {
 
            }
            return View(d);
        }
    }
}
