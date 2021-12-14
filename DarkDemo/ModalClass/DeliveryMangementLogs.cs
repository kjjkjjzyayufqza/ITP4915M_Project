using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class DeliveryMangementLogs
    {
        public int dmlog_id { get; set; }
        public int staff_id { get; set; }
        public string shipment_id { get; set; }
        public string content { get; set; }
        public DateTime dateTime { get; set; }
    }
}
