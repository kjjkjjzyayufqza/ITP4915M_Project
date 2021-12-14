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
    public partial class CheckStatus : Form
    {
        private Staff staff;
        private Customer customer;
        private List<DeliveryRecord> dr = new List<DeliveryRecord>();
        private DataAccess db = new DataAccess();
        private Boolean isStaff;
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        public CheckStatus()
        {
            InitializeComponent();
        }

        public CheckStatus(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            isStaff = false;
        }

        public CheckStatus(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            isStaff = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckStatus_Load(object sender, EventArgs e)
        {
            lblShipmentID.Text = "";
            lblServiceType.Text = "";
            lblDate.Text = "";
            lblDestination.Text = "";
            lblStatus.Text = "";
        }

        private void txtShipmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    lsvTrack.Items.Clear();
                    if (txtSearch.TextLength != 0)
                    {
                        List<Shipment> shipment_Info = db.getShipmentAbsoluteID(txtSearch.Text);
                        Shipment shipment = shipment_Info[0];
                        lblShipmentID.Text = shipment.shipment_id;
                        lblDestination.Text = shipment.recAddress;
                        lblStatus.Text = shipment.status;
                        lblDate.Text = shipment.createdDate.ToString();
                        lblServiceType.Text = shipment.service_type;

                        dr = db.getDeliveryRecord(txtSearch.Text);
                        foreach (DeliveryRecord ship in dr)
                        {
                            ListViewItem item = new ListViewItem(ship.datetime.ToString());
                            item.SubItems.Add(ship.status);
                            lsvTrack.Items.Add(item);
                        }
                    }
                    else
                    {
                        lblShipmentID.Text = "";
                        lblDestination.Text = "";
                        lblStatus.Text = "";
                        lblDate.Text = "";
                        lblServiceType.Text = "";
                    }
                }
            }catch(Exception Ex)
            {
                lsvTrack.Items.Clear();
                lblShipmentID.Text = "";
                lblDestination.Text = "";
                lblStatus.Text = "";
                lblDate.Text = "";
                lblServiceType.Text = "";
                MessageBox.Show("No record found.");
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {

        }
        private void Profile_btn_MouseHover(object sender, EventArgs e)
        {



        }

        private void Profile_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();

        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {

        }

        private void Tracking_btn_MouseHover(object sender, EventArgs e)
        {

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

            }
            else if (check == false && minormax == true)
            {

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

        private void GenerateInvoice_btn_MouseHover(object sender, EventArgs e)
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
            CustomerProfile profile = new CustomerProfile(customer);
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }

        private void CheckCS_btn_Click(object sender, EventArgs e)
        {
            CheckStatus Status;
            if (isStaff)
            {
                Status = new CheckStatus(staff);
            }
            else
            {
                Status = new CheckStatus(customer);
            }
            this.Hide();
            Status.ShowDialog();
            this.Close();
        }

        private void CheckO_btn_Click(object sender, EventArgs e)
        {
            checkOrder CO;
            if (isStaff)
            {
                CO = new checkOrder(staff);
            }
            else
            {
                CO = new checkOrder(customer);
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
                GI = new GenerateInvoice(staff);
            }
            else
            {
                GI = new GenerateInvoice(customer);
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
            Pickup pu = new Pickup(customer);
            this.Hide();
            pu.ShowDialog();
            this.Close();
        }
        /*
        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI = new GenerateInvoice();
            this.Hide();
            GI.ShowDialog();
            this.Close();
        }
        */

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            if (isStaff)
            {
                StaffMenu Menu = new StaffMenu(staff);
                this.Hide();
                Menu.ShowDialog();
                this.Close();
            }
            else
            {
                CustomerMenu Menu = new CustomerMenu(customer);
                this.Hide();
                Menu.ShowDialog();
                this.Close();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
