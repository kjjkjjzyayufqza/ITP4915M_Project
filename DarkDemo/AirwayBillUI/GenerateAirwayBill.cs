using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace DarkDemo
{
    public partial class GenerateAirwayBill : Form
    {
        private checkOrder f;
        private DataAccess db = new DataAccess();
        private string shipmentID;
        private Customer customer;
        private Staff staff;
        List<AirwaybillReport> airwaybill = new List<AirwaybillReport>();
        public GenerateAirwayBill()
        {
            InitializeComponent();
        }
        public GenerateAirwayBill(string ship, Customer c)
        {
            InitializeComponent();
            shipmentID = ship;
            customer = c;
            f = new checkOrder(c);
        }

        public GenerateAirwayBill(string ship, Staff s)
        {
            InitializeComponent();
            shipmentID = ship;
            staff = s;
            f = new checkOrder(s);
        }

        private void GenerateAirwayBill_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

            mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

            mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            mPageSettings.PaperSize = mPaperSize;

            mPageSettings.Landscape = true;

            this.reportViewer1.SetPageSettings(mPageSettings);
            this.reportViewer1.RefreshReport();

            airwaybill = db.searchAirwaybill(shipmentID);
            this.reportViewer1.LocalReport.ReportPath = ".\\AirwayBillUI\\Report_AirwayBill.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet_AirwayBill", airwaybill);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
