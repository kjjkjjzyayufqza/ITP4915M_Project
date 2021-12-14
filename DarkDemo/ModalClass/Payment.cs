using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.RelationalClass
{
    class Payment
    {
        public string invoiceID { get; set; }
        public string paymentMethod { get; set; }
        public string dateTime { get; set; }
    }
}
