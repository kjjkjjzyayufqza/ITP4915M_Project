using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class DailyReportDetail : Form
    {
        private List<StatisticsReport> report = new List<StatisticsReport>();
        private DataAccess db = new DataAccess();
        private DateTime date ;
        private Staff staff;
        Bitmap bmp;
        public DailyReportDetail(Staff staff, DateTime date)
        {
            InitializeComponent();
            this.staff = staff;
            this.date = date;
        }

        private string shortForm(string country)
        {
            switch (country)
            {
                case "HK":
                    return "Hong Kong";
                case "SH":
                    return "Shang Hai-China";
                case "AS":
                    return "Australia";
                case "JP":
                    return "Japan";
                default:
                    return "";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(1000, 700, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y + 60, 0, 0, new Size(840, 620));
            printPreviewDialog1.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            report = db.GetDailyNumIncome(date);
            lblNoOfOrder.Text += " " + report[0].totalNumber.ToString();
            lblIncome.Text += " " + report[0].totalIncome.ToString();
            lblReportID.Text += " " + date.ToString("yyyyMMdd");
            lblReportDate.Text += "\n" + date.ToString("yyyy-MM-dd");
            chartFrom.Titles.Add("From");
            chartFrom.Series["s1"]["PieLabelStyle"] = "Disabled";
            int[] from = new int[4];
            string[] Location = { "HK", "SH", "AS", "JP" };
            for (int i = 0; i < 4; i++)
            {
                from[i] = db.GetDailyFromLocation(date, Location[i])[0].totalNumber;
            }
            for (int i = 0; i < 4; i++)
            {
                chartFrom.Series["s1"].Points.AddXY(Location[i], ((double)from[i] / (double)report[0].totalNumber) * 100);
            }

            chartTo.Titles.Add("To");
            chartTo.Series["s1"]["PieLabelStyle"] = "Disabled";
            int[] to = new int[4];
            for (int i = 0; i < 4; i++)
            {
                to[i] = db.GetDailyToLocation(date, shortForm(Location[i]))[0].totalNumber;
            }
            for (int i = 0; i < 4; i++)
            {
                chartTo.Series["s1"].Points.AddXY(Location[i], ((double)to[i] / (double)report[0].totalNumber) * 100);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
