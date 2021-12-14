using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkDemo.InvoiceUI;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using DarkDemo.RelationalClass;

namespace DarkDemo
{
    public partial class GenerateInvoice : Form
    {
        private DataAccess db = new DataAccess();
       List<MonthInvoiceReport> invoice = new List<MonthInvoiceReport>();
        public string put { get; set; }

        private Boolean isStaff;
        private int account_id;
        private Customer c;
        private Staff s;

        private List<MonthlyInvoice> monthlyInvoices = new List<MonthlyInvoice>();
        

        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;

        public GenerateInvoice(Customer c)
        {
            InitializeComponent();
            this.c = c;
            isStaff = false;
        }

        public GenerateInvoice(Staff s)
        {
            InitializeComponent();
            this.s = s;
            isStaff = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvShipment.Visible = true;
            reportViewer1.Visible = false;
            lsvShipment.Items.Clear();


            if (isStaff)
            {
                monthlyInvoices = db.GetMonthlyInvoiceByID(txtInvoiceID.Text);

                foreach (MonthlyInvoice Mo in monthlyInvoices)
                {
                    ListViewItem item = new ListViewItem(Mo.invoice_id.ToString());
                    item.SubItems.Add(Mo.account_id.ToString());
                    item.SubItems.Add(Mo.paid_status.ToString());
                    item.SubItems.Add(Mo.payment_method.ToString());
                    item.SubItems.Add(Mo.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
            }
            else
            {
                monthlyInvoices = db.getMonthlyInvoiceByKey(txtInvoiceID.Text,c.account_id.ToString());

                foreach (MonthlyInvoice Mo in monthlyInvoices)
                {
                    ListViewItem item = new ListViewItem(Mo.invoice_id.ToString());
                    item.SubItems.Add(Mo.account_id.ToString());
                    item.SubItems.Add(Mo.paid_status.ToString());
                    item.SubItems.Add(Mo.payment_method.ToString());
                    item.SubItems.Add(Mo.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
            }
        }

        public void GenerateInvoice_Load(object sender, EventArgs e)
        {
            //guna2Panel1.Width = 60;
            if (isStaff)
            {
                //CheckCS_btn.Text = "Check CustomerInfo";
                Payment_btn_se.Visible = false;
                List<MonthlyInvoice> invoices = db.getAllMonthlyInvoice();

                foreach (MonthlyInvoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.invoice_id.ToString());
                    item.SubItems.Add(invoice.account_id.ToString());
                    item.SubItems.Add(invoice.paid_status.ToString());
                    item.SubItems.Add(invoice.payment_method.ToString());
                    item.SubItems.Add(invoice.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
                //this.Controls.Remove(PU_btn);
            }
            else
            {


                /*invoice = db.generateInvoice();
                this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\user\\Desktop\\EDE\\ITP4915M_Project\\DarkDemo\\InvoiceUI\\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", invoice);
                this.reportViewer1.LocalReport.DataSources.Add(rds);*/

                lsvShipment.Items.Clear();

                monthlyInvoices = db.getMonthlyInvoiceByAccountID(c.account_id);
                foreach (MonthlyInvoice Mo in monthlyInvoices)
                {
                    ListViewItem item = new ListViewItem(Mo.invoice_id.ToString());
                    item.SubItems.Add(Mo.account_id.ToString());
                    item.SubItems.Add(Mo.paid_status.ToString());
                    item.SubItems.Add(Mo.payment_method.ToString());
                    item.SubItems.Add(Mo.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            //btn_show.Visible = false;
            //btn_hide.Visible = true;
            //guna2Panel1.Visible = false;
            //guna2Panel1.Width = 265;
            //guna2Transition1.ShowSync(guna2Panel1);
            minormax = false;
            //Profile_btnn.Location = new Point(20000, 132);
            //CheckCS_btn.Location = new Point(20000, 132);
            //CheckO_btn.Location = new Point(20000, 232);
            //btn_Invoice.Location = new Point(20000, 292);
            //PU_btn.Location = new Point(20000, 352);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            //guna2Panel1.Visible = false;
            //btn_hide.Visible = false;
            //btn_show.Visible = true;
            //guna2Panel1.Width = 60;
            //guna2Transition1.ShowSync(guna2Panel1);
            minormax = true;
            //Profile_btnn.Location = new Point(20000, 132);
            //CheckCS_btn.Location = new Point(20000, 132);
            //CheckO_btn.Location = new Point(20000, 232);
            //btn_Invoice.Location = new Point(20000, 292);
            //PU_btn.Location = new Point(20000, 352);
        }
        private void Profile_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
            if (check == false && minormax == false)
            {
                //Profile_btnn.Visible = false;
                //Profile_btnn.Location = new Point(260, 132);
                //Profile_btnn.Width = 200;
                //guna2Transition_menu.ShowSync(Profile_btnn);
                check = true;
                User = 1;
            }
            else if (check == false && minormax == true)
            {
                //Profile_btnn.Visible = false;
                //Profile_btnn.Location = new Point(70, 132);
                //Profile_btnn.Width = 200;
                //guna2Transition_menu.ShowSync(Profile_btnn);
                check = true;
            }


        }

        private void Profile_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();

        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            time += timer_menu.Interval;
            if (time == 300)
            {

                //Profile_btnn.Location = new Point(20000, 132);
                //CheckCS_btn.Location = new Point(20000, 132);
                //CheckO_btn.Location = new Point(20000, 232);
                //btn_Invoice.Location = new Point(20000, 292);
                //PU_btn.Location = new Point(20000, 352);
                time = 0;
                check = false;
                timer_menu.Stop();

            }
        }

        private void Tracking_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;

            if (check == false && minormax == false)
            {
                //CheckCS_btn.Visible = false;
                //CheckCS_btn.Location = new Point(260, 212);
                //CheckCS_btn.Width = 200;
                //guna2Transition_menu.ShowSync(CheckCS_btn);
                check = true;
            }
            else if (check == false && minormax == true)
            {
                //CheckCS_btn.Visible = false;
                //CheckCS_btn.Location = new Point(70, 212);
                //CheckCS_btn.Width = 200;
                //guna2Transition_menu.ShowSync(CheckCS_btn);
                check = true;
            }
        }

        private void Tracking_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void Order_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;

            if (check == false && minormax == false)
            {
                check = true;
                //CheckO_btn.Visible = false;
                //btn_Invoice.Visible = false;
                //PU_btn.Visible = false;
                //CheckO_btn.Location = new Point(260, 232);
                //btn_Invoice.Location = new Point(260, 292);
                //PU_btn.Location = new Point(260, 352);
                //CheckO_btn.Width = 200;
                //btn_Invoice.Width = 200;
                //PU_btn.Width = 200;
                //guna2Transition_menu.ShowSync(CheckO_btn);
                //guna2Transition_menu.ShowSync(btn_Invoice);
                //guna2Transition_menu.ShowSync(PU_btn);

            }
            else if (check == false && minormax == true)
            {
                check = true;
                //CheckO_btn.Visible = false;
                //btn_Invoice.Visible = false;
                //PU_btn.Visible = false;
                //CheckO_btn.Location = new Point(70, 232);
                //btn_Invoice.Location = new Point(70, 292);
                //PU_btn.Location = new Point(70, 352);
                //CheckO_btn.Width = 200;
                //btn_Invoice.Width = 200;
                //PU_btn.Width = 200;
                //guna2Transition_menu.ShowSync(CheckO_btn);
                //guna2Transition_menu.ShowSync(btn_Invoice);
                //guna2Transition_menu.ShowSync(PU_btn);
                
            }
        }

        private void Order_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void guna2GradientButton4_MouseHover(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton4_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void Profile_btnn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void CheckCS_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void CheckO_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void Payment_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void GenerateABill_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void PU_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }
        private void Profile_btnn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void CheckCS_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void CheckO_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void Payment_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void GenerateABill_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void PU_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void GenerateInvoice_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }
        private void Profile_btnn_Click(object sender, EventArgs e)
        {
            if (isStaff)
            {
                StaffMenu profile = new StaffMenu(s);
                this.Hide();
                profile.ShowDialog();
                this.Close();
            }
            else
            {
                CustomerProfile profile = new CustomerProfile(c);
                this.Hide();
                profile.ShowDialog();
                this.Close();
            }
        }

        private void CheckCS_btn_Click(object sender, EventArgs e)
        {
            if (isStaff)
            {
                CheckCustomerInfo ci = new CheckCustomerInfo(s);
                this.Hide();
                ci.ShowDialog();
                this.Close();
            }
            else
            {
                CheckStatus Status = new CheckStatus(c);
                this.Hide();
                Status.ShowDialog();
                this.Close();
            }
        }

        private void CheckO_btn_Click(object sender, EventArgs e)
        {
            checkOrder CO;
            if (isStaff)
            {
                CO = new checkOrder(s);
            }
            else
            {
                CO = new checkOrder(c);
            }
            this.Hide();
            CO.ShowDialog();
            this.Close();
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI;
            if (isStaff)
            {
                GI = new GenerateInvoice(s);
            }
            else { 
                GI = new GenerateInvoice(c);
            }
            this.Hide();
            GI.ShowDialog();
            this.Close();
        }

        private void GenerateABill_btn_Click(object sender, EventArgs e)
        {
            /*
            GenerateAirwayBill GAB = new GenerateAirwayBill();
            this.Hide();
            GAB.ShowDialog();
            this.Close();
            */
        }

        private void PU_btn_Click(object sender, EventArgs e)
        {
            Pickup pu = new Pickup(c);
            this.Hide();
            pu.ShowDialog();
            this.Close();
        }

        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            /*
            GenerateInvoice GI = new GenerateInvoice(c);
            this.Hide();
            GI.ShowDialog();
            this.Close();
            */
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            if (isStaff)
            {
                StaffMenu Menu = new StaffMenu(s);
                this.Hide();
                Menu.ShowDialog();
                this.Close();
            }
            else
            {
                CustomerMenu Menu = new CustomerMenu(c);
                this.Hide();
                Menu.ShowDialog();
                this.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Payment_btn_se_Click(object sender, EventArgs e)
        {
            try
            {
                MonthlyInvoice inv = db.getMonthlyInvoiceByKey(lsvShipment.SelectedItems[0].Text, c.account_id.ToString())[0];
                Payment f = new Payment(inv, c, this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an invoice");
            }
            
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            try
            {

                System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
                System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

                mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

                mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                mPageSettings.PaperSize = mPaperSize;

                mPageSettings.Landscape = false;

                this.reportViewer1.SetPageSettings(mPageSettings);
                this.reportViewer1.RefreshReport();

                invoice = db.searchMonthInvoice(Convert.ToInt32(lsvShipment.SelectedItems[0].Text), Convert.ToInt32(lsvShipment.Items[0].SubItems[1].Text.ToString()));
                this.reportViewer1.LocalReport.ReportPath = @".\InvoiceUI\MonthlyInvoice.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", invoice);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();

                reportViewer1.Visible = true;
                lsvShipment.Visible = false;
                btnReturn.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an invoice");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Are You Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login ui = new Login();
                this.Hide();
                ui.ShowDialog();
                this.Close();
            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lsvShipment.Visible = true;
            reportViewer1.Visible = false;
            btnReturn.Visible = false;
            if (isStaff)
            {
                monthlyInvoices = db.getAllMonthlyInvoice();
                lsvShipment.Items.Clear();
                foreach (MonthlyInvoice Mo in monthlyInvoices)
                {
                    ListViewItem item = new ListViewItem(Mo.invoice_id.ToString());
                    item.SubItems.Add(Mo.account_id.ToString());
                    item.SubItems.Add(Mo.paid_status.ToString());
                    item.SubItems.Add(Mo.payment_method.ToString());
                    item.SubItems.Add(Mo.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
            }
            else
            {
                monthlyInvoices = db.getMonthlyInvoiceByAccountID(c.account_id);
                lsvShipment.Items.Clear();
                foreach (MonthlyInvoice Mo in monthlyInvoices)
                {
                    ListViewItem item = new ListViewItem(Mo.invoice_id.ToString());
                    item.SubItems.Add(Mo.account_id.ToString());
                    item.SubItems.Add(Mo.paid_status.ToString());
                    item.SubItems.Add(Mo.payment_method.ToString());
                    item.SubItems.Add(Mo.dateTime.ToString());
                    lsvShipment.Items.Add(item);
                }
            }
        }

        private void lsvShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; 
            if (lsvShipment.SelectedItems.Count > 0)
            {
                foreach (MonthlyInvoice inv in monthlyInvoices)
                {
                    if (inv.invoice_id.ToString() == lsvShipment.SelectedItems[0].Text)
                    {
                        if (int.Parse(inv.invoice_id.ToString()) >= int.Parse(now.ToString("yyyyMM")) || inv.paid_status=='Y')
                        {
                            Payment_btn_se.Enabled = false;
                        }
                        else
                        {
                            Payment_btn_se.Enabled = true;
                        }
                    }
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
