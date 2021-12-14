using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.ModalClass
{
    public class RegularOrder
    {
        public string record_name { get; set; }
        public int sender_id { get; set; }
        public string csv { get; set; }
        public  string name
        {
            get { return record_name; }
        }
    }
}
