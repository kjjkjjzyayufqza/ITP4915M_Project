using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.ModalClass
{
    public class Receiver
    {
        public string address { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public string company_name { get; set; }
        public string postcode { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        
        public string FullInfo
        {
            get
            {
                return $"{company_name} | {address} | {name} | {phone}";
            }
        }
    }
}
