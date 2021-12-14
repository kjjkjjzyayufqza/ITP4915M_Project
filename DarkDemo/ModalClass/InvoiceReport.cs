using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class InvoiceReport
    {
        public string shipment_id { get; set; }
        public string recCountry { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string recAddress { get; set; }
        public string recCompanyName { get; set; }
        public string recPOSTCODE { get; set; }
        public string contact_name { get; set; }
        public string contact_phone { get; set; }
        public double weight { get; set; }
        public double value { get; set; }
    }
}
