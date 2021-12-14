using System;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class CustomerProfile : Form
    {
        private DataAccess db;
        private Customer customer;
        private Staff s;
        private Boolean isStaff = false;
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        public CustomerProfile()
        {
            InitializeComponent();
            db = new DataAccess();
        }
        public CustomerProfile(Customer customer)
        {
            InitializeComponent();
            db = new DataAccess();
            this.customer = customer;
        }

        public CustomerProfile(Staff s)
        {
            InitializeComponent();
            this.s = s;
            isStaff = true;
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            if (isStaff)
            {
                //this.Controls.Remove(PU_btn);
            }
            //guna2Panel1.Width = 60;
            btnCancelEdit.Visible = false;
            btnConfirmEdit.Visible = false;
            lblAccountidValue.Text = customer.account_id.ToString();
            txtEmail.Text = customer.email;
            txtName.Text = customer.name;
            txtCompanyName.Text = customer.company_name;
            txtAddress.Text = customer.address;
            txtPhone.Text = customer.phone;
            cboCountry.Text = customer.country;
            txtPostcode.Text = customer.postcode;
            lblACCreateDate.Text = "Your account created at: " + customer.create_date;
            btnEdit.Visible = true;
            btnChangePWD.Visible = true;
            txtEmail.ReadOnly = true;
            txtName.ReadOnly = true;
            txtCompanyName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhone.ReadOnly = true;
            cboCountry.Enabled = false;
            txtPostcode.ReadOnly = true;
            btnEdit.Visible = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtName.ReadOnly = false;
            txtCompanyName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPhone.ReadOnly = false;
            cboCountry.Enabled = true;
            txtPostcode.ReadOnly = false;
            btnEdit.Visible = false;
            btnConfirmEdit.Visible = true;
            btnCancelEdit.Visible = true;
        }

        private void btnChangePWD_Click(object sender, EventArgs e)
        {
            gpBoxChangePWD.Visible = true;
            btnConfirmPWD.Visible = true;
            btnCancelPWD.Visible = true;
        }

        private void btnCancelPWD_Click(object sender, EventArgs e)
        {
            gpBoxChangePWD.Visible = false;
            txtConfirmPwd.Text = "";
            txtCurrentPwd.Text = "";
            txtNewPwd.Text = "";
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            string[] original = { customer.name, customer.email, customer.company_name, customer.address, customer.phone, customer.country, customer.postcode };
            string[] name = { "name", "email", "company name", "address", "phone", "country", "postcode" };
            string[] change = { txtName.Text.ToString(), txtEmail.Text.ToString(), txtCompanyName.Text.ToString(), txtAddress.Text.ToString(), txtPhone.Text.ToString(), cboCountry.Text.ToString(), txtPostcode.Text };

            string con;
            Boolean isUpdate = false;
            Boolean isFirst = true;
            con = "Personal information (";
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] != change[i])
                {
                    if (isFirst)
                    {
                        con += name[i];
                        isFirst = false;
                    }
                    else
                    {
                        con += ", " + name[i];
                    }
                    isUpdate = true;
                }
            }
            con += ") of account " + customer.account_id + " is updated";
            DialogResult dialogResult = MessageBox.Show("Confirm profile information change？", "Are You Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                customer.email = txtEmail.Text;
                customer.name = txtName.Text;
                customer.company_name = txtCompanyName.Text;
                customer.address = txtAddress.Text;
                customer.phone = txtPhone.Text;
                customer.country = cboCountry.Text;
                customer.postcode = txtPostcode.Text;
                db.MergeCustomer(customer);
                if (isUpdate)
                {
                    db.MergeUserProfileManagementLogs(new UserProfileManagementLogs { customer_id = customer.account_id, content = con });
                }
                CustomerProfile_Load(null, EventArgs.Empty);
            }
            else if (dialogResult == DialogResult.No)
            {
                CustomerProfile_Load(null, EventArgs.Empty);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            CustomerProfile_Load(null, EventArgs.Empty);
        }

        private void btnConfirmPWD_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("Password does not match!");
            }
            else if (txtNewPwd.TextLength < 6)
            {
                MessageBox.Show("at least 6 disgits are required for Passowrd!");
            }
            else
            {
                if (db.CustomerLogin(customer.email, txtCurrentPwd.Text).Count != 1)
                {
                    MessageBox.Show("Invalid Passowrd!!");
                }
                else
                {
                    customer.password = txtConfirmPwd.Text;
                    db.customerChangePassword(customer);
                    db.MergeUserProfileManagementLogs(new UserProfileManagementLogs { customer_id = customer.account_id, content = "User password of account " + customer.account_id + " is changed" });
                    MessageBox.Show("Successfully Changed!");
                    gpBoxChangePWD.Visible = false;
                    txtConfirmPwd.Text = "";
                    txtCurrentPwd.Text = "";
                    txtNewPwd.Text = "";
                }
            }
        }

        private void txtCurrentPwd_TextChanged(object sender, EventArgs e)
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
            //Payment_btn.Location = new Point(20000, 292);
            //PU_btn.Location = new Point(20000, 352);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            /*
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Panel1.Width = 60;
            guna2Transition1.ShowSync(guna2Panel1);
            minormax = true;
            Profile_btnn.Location = new Point(20000, 132);
            CheckCS_btn.Location = new Point(20000, 132);
            CheckO_btn.Location = new Point(20000, 232);
            Payment_btn.Location = new Point(20000, 292);
            PU_btn.Location = new Point(20000, 352);
            */
        }

        private void Profile_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
            if (check == false && minormax == false)
            {
                /*
                Profile_btnn.Visible = false;
                Profile_btnn.Location = new Point(260, 132);
                Profile_btnn.Width = 200;
                guna2Transition_menu.ShowSync(Profile_btnn);
                check = true;
                User = 1;
                */
            }
            else if (check == false && minormax == true)
            {
                /*
                Profile_btnn.Visible = false;
                Profile_btnn.Location = new Point(70, 132);
                Profile_btnn.Width = 200;
                guna2Transition_menu.ShowSync(Profile_btnn);
                check = true;
                */
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
                /*
                Profile_btnn.Location = new Point(20000, 132);
                CheckCS_btn.Location = new Point(20000, 132);
                CheckO_btn.Location = new Point(20000, 232);
                Payment_btn.Location = new Point(20000, 292);
                PU_btn.Location = new Point(20000, 352);
                time = 0;
                check = false;
                timer_menu.Stop();
                */
            }
        }

        private void Tracking_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;

            if (check == false && minormax == false)
            {
                /*
                CheckCS_btn.Visible = false;
                CheckCS_btn.Location = new Point(260, 212);
                CheckCS_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckCS_btn);
                check = true;
                */
            }
            else if (check == false && minormax == true)
            {
                /*
                CheckCS_btn.Visible = false;
                CheckCS_btn.Location = new Point(70, 212);
                CheckCS_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckCS_btn);
                check = true;
                */
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
                /*
                check = true;
                CheckO_btn.Visible = false;
                Payment_btn.Visible = false;
                PU_btn.Visible = false;
                CheckO_btn.Location = new Point(260, 232);
                Payment_btn.Location = new Point(260, 292);
                PU_btn.Location = new Point(260, 352);
                CheckO_btn.Width = 200;
                Payment_btn.Width = 200;
                PU_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckO_btn);
                guna2Transition_menu.ShowSync(Payment_btn);
                guna2Transition_menu.ShowSync(PU_btn);
                */

            }
            else if (check == false && minormax == true)
            {
                /*
                check = true;
                CheckO_btn.Visible = false;
                Payment_btn.Visible = false;
                PU_btn.Visible = false;
                CheckO_btn.Location = new Point(70, 232);
                Payment_btn.Location = new Point(70, 292);
                PU_btn.Location = new Point(70, 352);
                CheckO_btn.Width = 200;
                Payment_btn.Width = 200;
                PU_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckO_btn);
                guna2Transition_menu.ShowSync(Payment_btn);
                guna2Transition_menu.ShowSync(PU_btn);
                */
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
            CheckStatus Status = new CheckStatus(customer);
            this.Hide();
            Status.ShowDialog();
            this.Close();
        }

        private void CheckO_btn_Click(object sender, EventArgs e)
        {
            checkOrder CO = new checkOrder(customer);
            this.Hide();
            CO.ShowDialog();
            this.Close();
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI = new GenerateInvoice(customer);
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

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            CustomerMenu Menu = new CustomerMenu(customer);
            this.Hide();
            Menu.ShowDialog();
            this.Close();
            //sdasdasdasdasd
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
    }
}
