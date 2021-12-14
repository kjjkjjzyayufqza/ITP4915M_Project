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
    public partial class SignReceipt : Form
    {
        Boolean isSign = false;
        Bitmap bmp;
        byte[] img;
        MemoryStream ms;
        private DataAccess db = new DataAccess();
        private List<InvoiceReport> invoiceReport = new List<InvoiceReport>();
        private List<ImageSign> imageSigns = new List<ImageSign>();
        private List<Shipment> shipments = new List<Shipment>();
        private Customer customer;
        private Shipment shipment;
        private checkOrder checkOrder;
        float PointX = 0;
        float PointY = 0;

        float LastX = 0;
        float LastY = 0;
        public SignReceipt(Customer customer, Shipment shipment, checkOrder checkOrder)
        {
            InitializeComponent();
            this.customer = customer;
            this.shipment = shipment;
            this.checkOrder = checkOrder;
        }

        private void SignReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                
                /*
                System.Drawing.Printing.PageSettings mPageSettings = new System.Drawing.Printing.PageSettings();
                System.Drawing.Printing.PaperSize mPaperSize = new System.Drawing.Printing.PaperSize();

                mPaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.B4;

                mPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                mPageSettings.PaperSize = mPaperSize;

                mPageSettings.Landscape = false;

                this.reportViewer2.SetPageSettings(mPageSettings);*/
                this.reportViewer2.RefreshReport();

                invoiceReport = db.searchInvoice(shipment.shipment_id);
                this.reportViewer2.LocalReport.ReportPath = @".\InvoiceUI\Report2.rdlc";
                this.reportViewer2.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", invoiceReport);
                this.reportViewer2.LocalReport.DataSources.Add(rds);

                imageSigns = db.GetImage("0");
                img = imageSigns[0].image;
                string base64String = Convert.ToBase64String(img);
                ms = new MemoryStream(img);

                this.reportViewer2.RefreshReport();
                ReportParameter pImageUrl = new ReportParameter("pImageUrl", base64String);
                this.reportViewer2.LocalReport.EnableExternalImages = true;
                this.reportViewer2.LocalReport.SetParameters(pImageUrl);

                this.reportViewer2.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (btnSign.Text == "Sign")
            {
                panel1.Visible = true;
                btnSign.Text = "Back";
                btnConfirm.Text = "Clear";
            }
            else
            {
                panel1.Visible = false;
                btnSign.Text = "Sign";
                btnConfirm.Text = "Confirm";
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (btnConfirm.Text == "Confirm")
            {
                if (!isSign) {
                    MessageBox.Show("Please sign");
                }
                else
                {
                    shipments = db.getShipmentAbsoluteID(shipment.shipment_id);
                    DialogResult dialogResult = MessageBox.Show("Sign receipt?", "Are You Sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        shipments[0].status = "Received";
                        db.MergeShipment(shipments[0]);
                        db.MergeUserDeliveryManagementLogs(new UserDeliveryManagementLogs { customer_id = customer.account_id, shipment_id = shipments[0].shipment_id, content = "Status of shipment " + shipments[0].shipment_id + " is updated to received" });
                        this.Hide();
                        this.Close();
                        checkOrder.checkOrder_Load(sender, e);
                    }
                }
            }
            else
            {
                panel1.Visible = false;
                panel1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            G.DrawLine(blackPen, PointX, PointY, LastX, LastY);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {/*
            try
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(740, 524, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X + 194, this.Location.Y + 90, 0, 0, new Size(740, 524));
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JPG(*.JPG)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btnDTD_Click(object sender, EventArgs e)
        {
            try
            {
                
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(908, 588, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X + 38, this.Location.Y + 37, 0, 0, new Size(908, 588));
                /*
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                byte[] img = ms.ToArray();
                String insertQuery = "INSERT INTO image(image_id, image) VALUES(@image_id, @image)";
                connection.Open();
                command = new MySqlCommand(insertQuery, connection);
                command.Parameters.Add("@image_id", MySqlDbType.VarChar, 20);
                command.Parameters.Add("@image", MySqlDbType.Blob);
                command.Parameters["@image_id"].Value = shipment.shipment_id;
                command.Parameters["@image"].Value = img;
                command.ExecuteNonQuery();


                /*String selectQuery = "SELECT * FROM image WHERE image_id = '" + shipment.shipment_id + "'";
                command = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                da.Fill(table);
                img = (byte[])table.Rows[0][1];
                string base64String = Convert.ToBase64String(img);
                ms = new MemoryStream(img);
                da.Dispose();*/
                ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                img = ms.ToArray();
                db.MergeImage(new ImageSign { image_id = shipment.shipment_id, image = img });

                imageSigns = db.GetImage(shipment.shipment_id);
                img = imageSigns[0].image;
                string base64String = Convert.ToBase64String(img);
                //ms = new MemoryStream(img);

                this.reportViewer2.RefreshReport();
                ReportParameter pImageUrl = new ReportParameter("pImageUrl", base64String);
                this.reportViewer2.LocalReport.EnableExternalImages = true;
                this.reportViewer2.LocalReport.SetParameters(pImageUrl);
                this.reportViewer2.RefreshReport();
                btnSign.Text = "Sign";
                btnConfirm.Text = "Confirm";
                isSign = true;
                panel1.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
