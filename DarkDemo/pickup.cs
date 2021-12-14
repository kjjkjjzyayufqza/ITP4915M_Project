using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Pickup : Form
    {
        private CustomerMenu customerMenu;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];
        Customer customer;
        public string orderID;
        public int accountID;
        public string name;
        public string phone;
        public string address;
        public string company;
        public string postcode;
        public DateTime datetime;
        public string shipmentID;
        public string code;
        public DateTime pickupDatetime;
        public string country;
        private DataAccess db = new DataAccess();
        List<PickUpOrder> pickup = new List<PickUpOrder>();
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        Shipment shipment;
        private List<Shipment> shipments = new List<Shipment>();
        MailServer ms = new MailServer();
        private readonly Random random = new Random();
        public Pickup()
        {
            InitializeComponent();
            //accountID = ((Login)f).accountID;
        }

        public Pickup(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        public Pickup(Customer customer, CustomerMenu customerMenu)
        {
            InitializeComponent();
            this.customer = customer;
            this.customerMenu = customerMenu;
        }

        public Pickup(Customer customer, Shipment shipment, CustomerMenu customerMenu)
        {
            InitializeComponent();
            this.customer = customer;
            this.shipment = shipment;
            this.customerMenu = customerMenu;
            txtAddress.Text = shipment.recAddress;
            txtCompany.Text = shipment.recCompanyName;
            txtDescription.Text = shipment.description;
            txtEmail.Text = shipment.recEmail;
            txtName.Text = shipment.contact_name;
            txtPhone.Text = shipment.contact_phone;
            txtPostCode.Text = shipment.recPOSTCODE;
            cboCountry.Text = shipment.recCountry;
            cboShipmentType.Text = shipment.service_type;
            PanelPickup.Visible = false;
            panelDTD.Visible = true;
            tbtnDTD.FillColor = Color.FromArgb(64, 64, 64);
            tbtnDTD.ForeColor = Color.FromName("Control");
            tbtnPickup.FillColor = Color.FromName("Control");
            tbtnPickup.ForeColor = Color.FromArgb(64, 64, 64);
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        private void pickup_Load(object sender, EventArgs e)
        {


            dtpDTDdate.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            dtpDTDdate.MinDate = DateTime.Now;
            dtpDate.MinDate = DateTime.Now;
        }

        public void tbtnPickup_Click(object sender, EventArgs e)
        {
            PanelPickup.Visible = true;
            panelDTD.Visible = false;
            tbtnPickup.FillColor = Color.FromArgb(64, 64, 64);
            tbtnPickup.ForeColor = Color.FromName("Control");
            tbtnDTD.FillColor = Color.FromName("Control");
            tbtnDTD.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void tbtnDTD_Click(object sender, EventArgs e)
        {
            if (customer.country == null || customer.name == null || customer.address == null || customer.phone == null || customer.country == "" || customer.name == "" || customer.address == "" || customer.phone == "")
            {
                DialogResult result = MessageBox.Show("Please provide more info before booking pickup order.", "Sorry, but....", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CustomerProfile cp = new CustomerProfile(customer);
                    cp.ShowDialog();
                }
            }
            else
            {
                PanelPickup.Visible = false;
                panelDTD.Visible = true;
                tbtnDTD.FillColor = Color.FromArgb(64, 64, 64);
                tbtnDTD.ForeColor = Color.FromName("Control");
                tbtnPickup.FillColor = Color.FromName("Control");
                tbtnPickup.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
                var date = dtpDTDdate.Value.ToString("yyyy-MM-dd");
                if (cbBranch.SelectedIndex == -1 || txtDTDshipID.TextLength == 0 || txtPickUpCode.TextLength == 0)
                {
                    MessageBox.Show("Please input the infomation properly.");
                }
                else
                {
                    string branch = shortForm(cbBranch.Items[cbBranch.SelectedIndex].ToString());
                    orderID = branch + date;
                    shipmentID = txtDTDshipID.Text;
                    pickupDatetime = dtpDTDdate.Value.Date;
                    shipments = db.getShipmentAbsoluteID(shipmentID);
                if (shipments.Count == 0)
                {
                    MessageBox.Show("Shipment Not Found! Please Check again.");
                }
                else
                {
                    shipment = shipments[0];
                    try
                    {
                        if (shipment.code != txtPickUpCode.Text)
                        {
                            MessageBox.Show("Shipment Code Wrong, Please Check again.");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Confirm booking？", "Are You Sure?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {


                                PickUpOrder order = new PickUpOrder { order_id = orderID, shipment_id = shipmentID, recEmail = customer.email, date = pickupDatetime };
                                db.MergePickupOrder(order);
                                string message = "Dear Sir/Madam,<br /><br />Thank you " +
                        "for using our services. Your Pickup booking is confirmed. Please remember to go to our branch <b>(" + branch + ")</b>on <b>" + date + "</b>.<br /> Please show the below code<br /><h2> " + shipment.code + "</h2><br /> to our staff when pickingup.<br /><br />Regards,<br />EDE Express Team";
                                ms.sendMail(customer.email, "Pickup Booking Confirmed", message);
                                MessageBox.Show("Booking Made! Please Check Your Email.");


                            }
                        }
                    
                    db.MergeUserDeliveryManagementLogs(new UserDeliveryManagementLogs { customer_id = customer.account_id, shipment_id = shipmentID, content = "Pickup order of shipment " + shipmentID + " is booked" });

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please contact us for help");
                    }
                }
            }

        }

        private void btnDTD_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0 || txtPhone.TextLength == 0 || txtAddress.TextLength == 0 || txtCompany.TextLength == 0 || txtDescription.TextLength == 0 || cboCountry.SelectedIndex == -1 || cboShipmentType.Text == "")
            {
                MessageBox.Show("Please fill in every filed.");
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email format invalid.");
            }
            else
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(cboShipmentType.SelectedItem);
                Shipment shipment = new Shipment
                {
                    sender_id = customer.account_id,
                    shipment_id = genShipmentID(customer.country, cboCountry.Text),
                    service_type = cboShipmentType.Text,
                    recEmail = txtEmail.Text,
                    recAddress = txtAddress.Text,
                    recCountry = cboCountry.Text,
                    recCompanyName = txtCompany.Text,
                    recPOSTCODE = txtPostCode.Text,
                    contact_name = txtName.Text,
                    contact_phone = txtPhone.Text,
                    description = txtDescription.Text,
                    monthlyInvoice_id = Int32.Parse(now.ToString("yyyyMM")),
                    code = ms.genCode(),
                    invoice_id = genInvoiceID()
                };
                string date = dtpDate.Value.ToString("yyyy-MM-dd") + " " + dtpTime.Value.ToString("HH:mm");
                DTDOrder dtdOrder = new DTDOrder { account_id = customer.account_id, shipment_id = shipment.shipment_id, date = date };
                Items f = new Items(customer, shipment, dtdOrder, (cboShipmentType.SelectedIndex == 0), customerMenu);
                customerMenu.openChildForm(f);

                //f.ShowDialog();

            }
        }
        private int genInvoiceID()
        {
            int invoiceID;
            do
            {
                invoiceID = random.Next(1000001, 9999999);
            }
            while (db.GetInvoiceByAbsInvID(invoiceID).Count > 0);
            return invoiceID;
        }
        private string genShipmentID(string fCountry, string tCountry)
        {
            string frontCode = shortForm(fCountry) + shortForm(tCountry);
            string shipmentID;
            do
            {
                shipmentID = frontCode + random.Next(1000000, 9999999).ToString();
            }
            while (db.getShipmentAbsoluteID(shipmentID).Count > 0);
            return shipmentID;
        }

        private string shortForm(string country)
        {
            switch (country)
            {
                case "Hong Kong":
                    return "HK";
                case "Shang Hai-China":
                    return "SH";
                case "Australia":
                    return "AS";
                case "Japan":
                    return "JP";
                case "New Territories":
                    return "NT";
                case "Kowloon":
                    return "KL";
                default:
                    return "HK";
            }
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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


        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {

        }

        private void Tracking_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Tracking_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Order_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Order_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_MouseHover(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Profile_btnn_MouseHover(object sender, EventArgs e)
        {

        }

        private void CheckCS_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void CheckO_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Payment_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void GenerateABill_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void PU_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void GenerateInvoice_btn_MouseHover(object sender, EventArgs e)
        {

        }
        private void Profile_btnn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CheckCS_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CheckO_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Payment_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void GenerateABill_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PU_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void GenerateInvoice_btn_MouseLeave(object sender, EventArgs e)
        {

        }





        private void txtDTDshipID_TextChanged(object sender, EventArgs e)
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

        private void cboShipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShipmentType.SelectedItem.ToString() == "WORLDMAIL")
            {
                MessageBox.Show("hi");
            }
        }

        private void txtPostCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPostCode.Text != "")
                {
                    int.Parse(txtPostCode.Text);
                }
            }
            catch (Exception) { MessageBox.Show("Please Enter number in Postcode filed."); txtPostCode.Text = ""; }
        }

        private void btnRegularOrder_Click(object sender, EventArgs e)
        {
            if (customer.country == null || customer.name == null || customer.address == null || customer.phone == null || customer.country == "" || customer.name == "" || customer.address == "" || customer.phone == "")
            {
                DialogResult result = MessageBox.Show("Please provide more info before booking pickup order.", "Sorry, but....", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CustomerProfile cp = new CustomerProfile(customer);
                    cp.ShowDialog();
                }
            }
            else
            {
                new PlaceRegularOoder(customer).ShowDialog();
            }
        }
    }
}
