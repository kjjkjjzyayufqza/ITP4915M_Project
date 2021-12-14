using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.RelationalClass
{
    public class MonthInvoiceReport
    {
        public int invoice_id { get; set; }
        public int account_id { get; set; }
        public string shipment_id { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public double price { get; set; }
        public int item_id { get; set; }
        public int totalItem { get; set; }
        public int totalPrice { get; set; }
    }
}
