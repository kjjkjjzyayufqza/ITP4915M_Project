using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class WeeklyReport
    {
        public string report_id { get; set; }
        public DateTime sDate { get; set; }
        public DateTime eDate { get; set; }
        public int shipmentVolume { get; set; }
        public int fromHK { get; set; }
        public int toHK { get; set; }
        public int fromJapan { get; set; }
        public int toJapan { get; set; }
        public int fromShangHai { get; set; }
        public int toShangHai { get; set; }
        public int fromAustralia { get; set; }
        public int toAustralia { get; set; }
    }
}
