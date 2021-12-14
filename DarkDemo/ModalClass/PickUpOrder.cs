using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class PickUpOrder
    {
        public string order_id { get; set; }
        public string shipment_id { get; set; }
        public string recEmail { get; set; }
        public DateTime date { get; set; }
    }
}
