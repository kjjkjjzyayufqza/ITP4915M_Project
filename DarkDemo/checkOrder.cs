using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
using System.IO;

namespace DarkDemo
{
    public partial class checkOrder : Form
    {
        private Form activeForm = null;
        private List<Shipment> sh = new List<Shipment>();
        private DataAccess db = new DataAccess();
        private Customer customer;
        private Staff staff;
        private Boolean isStaff;
        private List<Shipment> shipment = new List<Shipment>();
        private List<Invoice> invoices = new List<Invoice>();
        private List<InvoiceReport> invoiceReport = new List<InvoiceReport>();
        private List<ImageSign> imageSigns = new List<ImageSign>();

        byte[] img;
        public string search { get; set; }
        public checkOrder()
        {
            InitializeComponent();
        }

        float PointX = 0;
        float PointY = 0;

        float LastX = 0;
        float LastY = 0;

        public checkOrder(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            isStaff = false;
        }

        public checkOrder(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            isStaff = true;
        }

        public void checkOrder_Load(object sender, EventArgs e)
        {
            btnReturn.Visible = false;
            lsvShipment.Items.Clear();
            if (isStaff)
            {
                guna2Button3.Text = "Check Signed Invoice";
                btnUpdate.Visible = true;
                shipment = db.getAllShipments();
                foreach (Shipment ship in shipment)
                {
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(ship.price.ToString());
                    item.SubItems.Add(ship.createdDate.ToString());
                    item.SubItems.Add(ship.status);
                    lsvShipment.Items.Add(item);
                }
            }
            else
            {
                guna2Button3.Text = "Sign Receipt";
                shipment = db.getShipmentByAccount(customer.account_id.ToString());

                foreach (Shipment ship in shipment)
                {
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(ship.price.ToString());
                    item.SubItems.Add(ship.createdDate.ToString());
                    item.SubItems.Add(ship.status);
                    lsvShipment.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isStaff)
            {
                if (lsvShipment.SelectedItems.Count > 0)
                {
                    foreach (Shipment ship in shipment)
                    {
                        if (ship.shipment_id == lsvShipment.SelectedItems[0].Text)
                        {
                            if (ship.status == "Received")
                            {
                                guna2Button3.Enabled = true;
                                guna2Button3.Text = "Check Signed Invoice";
                            }
                            else if (ship.status != "Delivered")
                            {
                                guna2Button3.Enabled = false;
                                guna2Button3.Text = "Sign Receipt";
                            }
                            else
                            {
                                guna2Button3.Enabled = true;
                                guna2Button3.Text = "Sign Receipt";
                            }
                        }
                    }
                }
            }
            else
            {
                if (lsvShipment.SelectedItems.Count > 0)
                {
                    foreach (Shipment ship in shipment)
                    {
                        if (ship.shipment_id == lsvShipment.SelectedItems[0].Text)
                        {
                            if (ship.status == "Received")
                            {
                                guna2Button3.Enabled = true;
                                guna2Button3.Text = "Check Signed Invoice";
                            }
                            else
                            {
                                guna2Button3.Enabled = false;
                            }
                        }
                    }
                }

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lsvShipment.Items.Clear();
            if (isStaff)
            {
                shipment = db.getShipmentByID(txtSearch.Text);
                foreach (Shipment ship in shipment)
                {
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(ship.price.ToString());
                    item.SubItems.Add(ship.createdDate.ToString());
                    item.SubItems.Add(ship.status);
                    lsvShipment.Items.Add(item);
                }
            }
            else
            {
                shipment = db.getShipmentBytwoID(txtSearch.Text, customer.account_id.ToString());
                foreach (Shipment ship in shipment)
                {
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(ship.price.ToString());
                    item.SubItems.Add(ship.createdDate.ToString());
                    item.SubItems.Add(ship.status);
                    lsvShipment.Items.Add(item);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                search = lsvShipment.SelectedItems[0].Text;
                OrderInfo f;
                if (isStaff)
                {
                    f = new OrderInfo(search, staff);
                }
                else
                {
                    f = new OrderInfo(search, customer);
                }
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a shipment");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (isStaff)
                {
                    btnReturn.Visible = true;
                    System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
                    System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

                    mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

                    mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                    mPageSettings.PaperSize = mPaperSize;

                    mPageSettings.Landscape = false;

                    this.reportViewer2.SetPageSettings(mPageSettings);
                    this.reportViewer2.RefreshReport();
                    invoiceReport = db.searchInvoice(lsvShipment.SelectedItems[0].Text);
                    this.reportViewer2.LocalReport.ReportPath = @".\InvoiceUI\Report2.rdlc";
                    this.reportViewer2.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", invoiceReport);
                    this.reportViewer2.LocalReport.DataSources.Add(rds);

                    imageSigns = db.GetImage(lsvShipment.SelectedItems[0].Text);
                    if (imageSigns.Count == 0)
                    {
                        imageSigns = db.GetImage("0");
                    }
                    img = imageSigns[0].image;
                    string base64String = Convert.ToBase64String(img);
                    ReportParameter pImageUrl = new ReportParameter("pImageUrl", base64String);
                    this.reportViewer2.LocalReport.EnableExternalImages = true;
                    this.reportViewer2.LocalReport.SetParameters(pImageUrl);
                    this.reportViewer2.RefreshReport();

                    reportViewer2.Visible = true;
                    lsvShipment.Visible = false;
                }
                else
                {
                    if (guna2Button3.Text == "Sign Receipt")
                    {
                        sh = db.getShipmentAbsoluteID(lsvShipment.SelectedItems[0].Text);
                        SignReceipt f = new SignReceipt(customer, sh[0], this);
                        f.ShowDialog();

                    }
                    else
                    {
                        btnReturn.Visible = true;
                        System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
                        System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

                        mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

                        mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                        mPageSettings.PaperSize = mPaperSize;

                        mPageSettings.Landscape = false;

                        this.reportViewer2.SetPageSettings(mPageSettings);
                        this.reportViewer2.RefreshReport();
                        invoiceReport = db.searchInvoice(lsvShipment.SelectedItems[0].Text);
                        this.reportViewer2.LocalReport.ReportPath = @".\InvoiceUI\Report2.rdlc";
                        this.reportViewer2.LocalReport.DataSources.Clear();
                        ReportDataSource rds = new ReportDataSource("DataSet1", invoiceReport);
                        this.reportViewer2.LocalReport.DataSources.Add(rds);

                        imageSigns = db.GetImage(lsvShipment.SelectedItems[0].Text);
                        if (imageSigns.Count == 0)
                        {
                            imageSigns = db.GetImage("0");
                        }
                        img = imageSigns[0].image;
                        string base64String = Convert.ToBase64String(img);
                        ReportParameter pImageUrl = new ReportParameter("pImageUrl", base64String);
                        this.reportViewer2.LocalReport.EnableExternalImages = true;
                        this.reportViewer2.LocalReport.SetParameters(pImageUrl);
                        this.reportViewer2.RefreshReport();

                        reportViewer2.Visible = true;
                        lsvShipment.Visible = false;
                    }

                }

            }
            catch (Exception ex)
            {
                btnReturn.Visible = false;
                MessageBox.Show("Please select a shipment");
            }
        }
        private void guna2GradientButton4_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            /*
            if (check == false && minormax == false)
            {
                check = true;
                GenerateInvoice_btn.Visible = false;
                GenerateInvoice_btn.Location = new Point(290, 399);
                GenerateInvoice_btn.Width = 200;
                guna2Transition_menu.ShowSync(GenerateInvoice_btn);

            }
            else if (check == false && minormax == true)
            {
                check = true;
                GenerateInvoice_btn.Visible = false;
                GenerateInvoice_btn.Location = new Point(80, 399);
                GenerateInvoice_btn.Width = 200;
                guna2Transition_menu.ShowSync(GenerateInvoice_btn);

            }*/
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
            Pickup pu = new Pickup(customer);
            this.Hide();
            pu.ShowDialog();
            this.Close();
        }
        /*
        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI;
            if (isStaff)
            {
                GI = new GenerateInvoice(staff);
            }
            else { 
                GI = new GenerateInvoice(customer);
            }
            this.Hide();
            GI.ShowDialog();
            this.Close();
        }
        */
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (lsvShipment.SelectedItems.Count > 0)
            {
                search = lsvShipment.SelectedItems[0].Text;
                GenerateAirwayBill air;
                if (isStaff)
                {
                    air = new GenerateAirwayBill(search, staff);
                }
                else
                {
                    air = new GenerateAirwayBill(search, customer);
                }
                air.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a shipment");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = panel1.CreateGraphics();
            G.DrawLine(Pens.Black, PointX, PointY, LastX, LastY);
            LastX = PointX;
            LastY = PointY;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointX = e.X;
                PointY = e.Y;
                panel1_Paint(this, null);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Image bmp = new Bitmap(panel1.Width, panel1.Height);
            var gg = Graphics.FromImage(bmp);
            var rect = panel1.RectangleToScreen(panel1.ClientRectangle);
            gg.CopyFromScreen(rect.Location, Point.Empty, panel1.Size);

            bmp.Save("Test.jpg", ImageFormat.Jpeg);
        }
        
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (reportViewer2.Visible)
                {
                    guna2Button4.Text = "Check Invoice";
                }
                else
                {
                    btnReturn.Visible = true;
                    System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
                    System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

                    mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

                    mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                    mPageSettings.PaperSize = mPaperSize;

                    mPageSettings.Landscape = false;

                    this.reportViewer2.SetPageSettings(mPageSettings);
                    this.reportViewer2.RefreshReport();
                    invoiceReport = db.searchInvoice(lsvShipment.SelectedItems[0].Text);
                    this.reportViewer2.LocalReport.ReportPath = @".\InvoiceUI\Report1.rdlc";
                    this.reportViewer2.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", invoiceReport);
                    this.reportViewer2.LocalReport.DataSources.Add(rds);
                    this.reportViewer2.RefreshReport();

                    reportViewer2.Visible = true;
                    lsvShipment.Visible = false;

                    //guna2Button4.Text = "Return";
                }
            }
            catch (Exception ex)
            {
                btnReturn.Visible = false;
                MessageBox.Show("Please select a shipment");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = false;
            lsvShipment.Visible = true;
            btnReturn.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UpdateShipments f = new UpdateShipments(staff);
            f.ShowDialog();
        }
    }
}