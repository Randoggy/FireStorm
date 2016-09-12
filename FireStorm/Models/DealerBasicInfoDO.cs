using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireStorm.Models
{
    public class DealerBasicInfoDO
    {
        public String Account { get; set; }
        public Int32? DealerID { get; set; }
        public String Firstname { get; set; }
        public String MiddleInitial { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String HomePhone { get; set; }
        public String FaxPhone { get; set; }       
        public String CellPhone { get; set; }
        public String CompanyName { get; set; }
        public String TaxPayerNumber { get; set; }
        public Int16? Active { get; set; }
        public Int16? AllowWebAccess { get; set; }
        public String DealerURL { get; set; }
        public String OldID { get; set; }
        public String Password { get; set; }
        public Int16? IsCustomer { get; set; }

        // extra params used to call service method
        public String Token { get; set; }
        public String Context { get; set; }
        public String PrimaryEmail { get; set; }
        public String SecondaryEmail { get; set; }
        public String WorkPhone { get; set; }
    }
}