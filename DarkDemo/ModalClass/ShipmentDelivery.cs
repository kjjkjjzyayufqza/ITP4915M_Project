using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class ShipmentDelivery
    {
        public string shipmentID { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime datetime { get; set; }
        public string status { get; set; }
    }
}
