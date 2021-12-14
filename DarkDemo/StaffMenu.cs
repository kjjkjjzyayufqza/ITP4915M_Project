using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class StaffMenu : Form
    {
        private Form activeForm = null;
        private Staff staff;
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        public StaffMenu()
        {
            InitializeComponent();
        }
        public StaffMenu(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }


        private void StaffMenu_Load(object sender, EventArgs e)
        {
            guna2Panel1.Width = 60;
            if (welcome_bar.Value == 0)
            {
                timer_welcome.Start();
            }
            //guna2GradientButton2.Location = new Point(2000, 70);
            welcome_lab.Text += " " + staff.Name;
            label_welcome.Text += " " + staff.Name;
            if (staff.position == "Shipping Clerk")
            {
                Data_M_btn.Enabled = false;
                Checkrp_btn.Enabled = false;
                CheckCS_btn.Enabled = false;
                btnInvoice.Enabled = false;
            }
            else if (staff.position != "Manager")
            {
                Checkrp_btn.Enabled = false;
            }else if (staff.position != "Customer Service Staff"){
                Data_M_btn.Enabled = false;
            }
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
            btnInvoice.Location = new Point(20000, 292);
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
            btnInvoice.Location = new Point(20000, 292);
        }
        private void Profile_btn_Click(object sender, EventArgs e)
        {
            StaffProfile profile = new StaffProfile(staff);
            this.Hide();
            profile.ShowDialog();
            this.Close();
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
                label_welcome.Visible = true;
                guna2PictureBox1.Visible = true;
            }

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
            }
            else if (check == false && minormax == true)
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
                btnInvoice.Location = new Point(20000, 292);
                Data_M_btn.Location = new Point(20000, 292);
                Checkrp_btn.Location = new Point(20000, 292);
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
                btnInvoice.Visible = false;
                CheckO_btn.Location = new Point(270, 272);
                btnInvoice.Location = new Point(270, 322);
                CheckO_btn.Width = 200;
                btnInvoice.Width = 200;
                guna2Transition_menu.ShowSync(CheckO_btn);
                guna2Transition_menu.ShowSync(btnInvoice);

            }
            else if (check == false && minormax == true)
            {
                check = true;
                CheckO_btn.Visible = false;
                btnInvoice.Visible = false;
                CheckO_btn.Location = new Point(70, 272);
                btnInvoice.Location = new Point(70, 322);
                CheckO_btn.Width = 200;
                btnInvoice.Width = 200;
                guna2Transition_menu.ShowSync(CheckO_btn);
                guna2Transition_menu.ShowSync(btnInvoice);

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
            openChildForm(new StaffProfile(staff));
        }

        private void CheckCS_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new CheckCustomerInfo(staff));
        }

        private void CheckO_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new checkOrder(staff));
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerateInvoice(staff));
        }

        private void Console_btn_MouseHover(object sender, EventArgs e)
        {
            if (check == false && minormax == false)
            {
                Data_M_btn.Visible = false;
                Checkrp_btn.Visible = false;
                Data_M_btn.Location = new Point(270, 370);
                Checkrp_btn.Location = new Point(270, 420);
                Data_M_btn.Width = 200;
                Checkrp_btn.Width = 200;
                guna2Transition_menu.ShowSync(Data_M_btn);
                guna2Transition_menu.ShowSync(Checkrp_btn);

                check = true;
            }
            else if (check == false && minormax == true)
            {
                Data_M_btn.Visible = false;
                Checkrp_btn.Visible = false;
                Data_M_btn.Location = new Point(70, 370);
                Checkrp_btn.Location = new Point(70, 420);
                Data_M_btn.Width = 200;
                Checkrp_btn.Width = 200;
                guna2Transition_menu.ShowSync(Data_M_btn);
                guna2Transition_menu.ShowSync(Checkrp_btn);
                check = true;
            }
            timer_menu.Stop();
            time = 0;
        }

        private void Console_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void Data_M_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void Data_M_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void Checkrp_btn_MouseHover(object sender, EventArgs e)
        {
            timer_menu.Stop();
            time = 0;
        }

        private void Checkrp_btn_MouseLeave(object sender, EventArgs e)
        {
            timer_menu.Start();
        }
        /*
        private void GenerateABill_btn_Click(object sender, EventArgs e)
        {
            GenerateAirwayBill GAB = new GenerateAirwayBill(staff);
            this.Hide();
            GAB.ShowDialog();
            this.Close();
        }
        */
        /*
        private void PU_btn_Click(object sender, EventArgs e)
        {
            Pickup pu = new Pickup();
            this.Hide();
            pu.ShowDialog();
            this.Close();
        }*/
        /*
        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI = new GenerateInvoice();
            this.Hide();
            GI.ShowDialog();
            this.Close();
        }*/

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

        private void btnToDataMigrationForm_Click(object sender, EventArgs e)
        {
            openChildForm(new DataMigration(staff));
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new DataMigration(staff));
        }

        private void Checkrp_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new CheckReport(staff));
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
