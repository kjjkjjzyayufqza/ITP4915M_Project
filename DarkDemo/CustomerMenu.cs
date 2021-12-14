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
    public partial class CustomerMenu : Form
    {

        private Form activeForm = null;
        private Customer customer;
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        public CustomerMenu()
        {
            InitializeComponent();
        }

        public CustomerMenu(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 265;
            guna2Transition1.ShowSync(guna2Panel1);
            minormax = false;
            Profile_btnn.Location = new Point(20000, 132);
            CheckCS_btn.Location = new Point(20000, 132);
            CheckO_btn.Location = new Point(20000, 232);
            Payment_btn.Location = new Point(20000, 292);
            PU_btn.Location = new Point(20000, 352);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
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
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            guna2Panel1.Width = 60;
            if (welcome_bar.Value == 0)
            {
                timer_welcome.Start();
            }
            welcome_lab.Text += " " + customer.name;
            lblCustomerName.Text += " " + customer.name;
            //guna2GradientButton2.Location = new Point(2000, 70);
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Tracking_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel_Dargcontrl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void Support_btn_Click(object sender, EventArgs e)
        {

        }

        private void Order_btn_Click(object sender, EventArgs e)
        {

        }

        private void timer_welcome_Tick(object sender, EventArgs e)
        {
            welcome_bar.Increment(1);
            if (welcome_bar.Value == 5)
            {
                welcome_bar.Increment(200);
            }
            if (welcome_bar.Value == 208)
            {
                welcome_bar.Increment(200);
            }
            if (welcome_bar.Value == 400)
            {
                timer_welcome.Stop();
                guna2Panel_welcome.Visible = false;
                lblCustomerName.Visible = true;
                guna2PictureBox2.Visible = true;
            }
        }

        private void guna2Panel_welcome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
            if (check == false && minormax == false)
            {
                Profile_btnn.Visible = false;
                Profile_btnn.Location = new Point(270, 132);
                Profile_btnn.Width = 200;
                guna2Transition_menu.ShowSync(Profile_btnn);
                check = true;
                User = 1;
            }else if (check == false && minormax == true)
            {
                Profile_btnn.Visible = false;
                Profile_btnn.Location = new Point(70, 132);
                Profile_btnn.Width = 200;
                guna2Transition_menu.ShowSync(Profile_btnn);
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

                Profile_btnn.Location = new Point(20000, 132);
                CheckCS_btn.Location = new Point(20000, 132);
                CheckO_btn.Location = new Point(20000, 232);
                Payment_btn.Location = new Point(20000, 292);
                PU_btn.Location = new Point(20000, 352);
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
                CheckCS_btn.Visible = false;
                CheckCS_btn.Location = new Point(270, 212);
                CheckCS_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckCS_btn);
                check = true;
            }
            else if (check == false && minormax == true)
            {
                CheckCS_btn.Visible = false;
                CheckCS_btn.Location = new Point(70, 212);
                CheckCS_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckCS_btn);
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
                CheckO_btn.Visible = false;
                Payment_btn.Visible = false;
                PU_btn.Visible = false;
                CheckO_btn.Location = new Point(270, 232);
                Payment_btn.Location = new Point(270, 292);
                PU_btn.Location = new Point(270, 352);
                CheckO_btn.Width = 200;
                Payment_btn.Width = 200;
                PU_btn.Width = 200;
                guna2Transition_menu.ShowSync(CheckO_btn);
                guna2Transition_menu.ShowSync(Payment_btn);
                guna2Transition_menu.ShowSync(PU_btn);
                
            }
            else if (check == false && minormax == true)
            {
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
            openChildForm(new CustomerProfile(customer));
        }

        private void CheckCS_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new CheckStatus(customer));
        }

        private void CheckO_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new checkOrder(customer));
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerateInvoice(customer));
        }

        private void GenerateABill_btn_Click(object sender, EventArgs e)
        {

        }

        private void PU_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Pickup(customer, this));
        }

        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerateInvoice(customer));
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Close(); }
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

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
