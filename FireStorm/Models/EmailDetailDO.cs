using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireStorm.Models
{
    public class EmailDetailDO
    {
        public String MailCity { get; set; }
        public String MailCountry { get; set; }
        public String MailState { get; set; }
        public String MailZip { get; set; }
        public String EmailSecondary { get; set; }
        public Int16? EMailFormatTextOnly { get; set; }
        public Int16? EmailOptOutGlobal { get; set; }
        public Int16? EmailOptOutUpline { get; set; }
        public String EmailPrimary { get; set; }
        public Int16? EmailPrimaryValidated { get; set; }
        public String EmailPrimaryValidationResult { get; set; }
        public List<String> lstMailAddress { get; set; }
        
    }
}