using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireStorm.Models
{
    public class SMSDetailDO
    {
        public Int16? SMSTextInfoAlerts { get; set; }
        public Int16? SMSTextOnEnroll { get; set; }
        public Int16? SMSTextOnOrder { get; set; }
        public Int16? SMSTextOptOut { get; set; }
        public SMSDetailDO SMSDetail { get; set; }
    }
}