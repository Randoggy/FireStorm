using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireStorm.Models
{
    public class ShippingDetailDO
    {
        public List<String> lstShipAddress { get; set; }
        public String ShipCity { get; set; }
        public String ShipCountry { get; set; }
        public String ShipState { get; set; }
        public String ShipZip { get; set; }
    }
}