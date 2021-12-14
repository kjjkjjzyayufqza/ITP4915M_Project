using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.RelationalClass
{
    public class MonthlyInvoice
    {
        public int invoice_id { get; set; }
        public int account_id { get; set; }
        public char paid_status { get; set; }
        public string payment_method { get; set; }
        public DateTime dateTime { get; set; }
    }
}
