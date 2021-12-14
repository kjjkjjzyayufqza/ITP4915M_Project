using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class UserDeliveryManagementLogs
    {
        public int udlog_id { get; set; }
        public string shipment_id { get; set; }
        public int customer_id { get; set; }
        public string content { get; set; }
        public DateTime dateTime { get; set; }
    }
}
