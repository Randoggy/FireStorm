using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireStorm.Models
{
    public class DealerDetailDO:DealerBasicInfoDO
    {
        public EmailDetailDO EmailDetail { get; set; }
        public SMSDetailDO SMSDetail { get; set; }
        public ShippingDetailDO ShippingDetail { get; set; }
        public String Account { get; set; }
        public Int32? AffiliateSponsoringDealerID { get; set; }
        public Int32? APDealershipNumber { get; set; }
        public Char? APLineage { get; set; }
        public Int32? APPlacementDealerID { get; set; }        
        public Int32? CurrencyTypeID { get; set; }
        public Int32? CustomerStatusID { get; set; }
        public Int32? CustomerTypeID { get; set; }
        public DateTime? DateEmailPrimaryLastValidated { get; set; }
        public DateTime? DateExported { get; set; }        
        public Int32? DealerStatusCodeID { get; set; }       
        public Int32? DEFSponsorDealerID { get; set; }
        public Int32? DEFSponsorDealershipNumber { get; set; }
        public DateTime? EnrollDate { get; set; }       
        public Int16? NPO { get; set; }       
        public Int32? PayCurrencyTypeID { get; set; }
        public Int32? SponsoringDealerID { get; set; }
        public String SubAccount { get; set; }
        public Int16? TaxExempt { get; set; }
        public Int32? UseEWalletOnly { get; set; }
        public String WebGreeting { get; set; }
        public String CustomerType { get; set; }
        public String CustomerStatus { get; set; }
        public String StructureSponsoringDealerID { get; set; }       
    }
}