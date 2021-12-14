using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class Shipment
    {
        public string shipment_id { get; set; }
        public int monthlyInvoice_id { get; set; }
        public int sender_id { get; set; }
        public string recAddress { get; set; }
        public string recEmail { get; set; }
        public string recCompanyName { get; set; }
        public string recCountry { get; set; }
        public string recPOSTCODE { get; set; }
        public string contact_name { get; set; }
        public string contact_phone { get; set; }
        public string createdDate { get; set; }
        public string description { get; set; }
        public string service_type { get; set; }
        public double price { get; set; }
        public string status { get; set; }
        public int invoice_id { get; set; }
        public string code { get; set; }
        public string ReceiverInfo
        {
            get
            {
                return $"{recCompanyName} | {recAddress} | | {contact_name}";
            }
        }
    }
}
