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
    public partial class StaffProfile : Form
    {
        Staff staff;
        DataAccess db = new DataAccess();
        public StaffProfile()
        {
            InitializeComponent();
        }

        public StaffProfile(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            lblStaffID.Text = staff.staff_id.ToString();
            lblName.Text = staff.Name;
            lblStaffMail.Text = staff.staff_mail;
            lblPosition.Text = staff.position;
            lblEntryDate.Text = staff.emplyedDate.Split(' ')[0];
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
                if (db.StaffLogin(staff.staff_mail, txtCurrentPwd.Text).Count != 1)
                {
                    MessageBox.Show("Invalid Passowrd!!");
                }
                else
                {
                    staff.password = txtConfirmPwd.Text;
                    db.staffChangePassword(staff);
                    MessageBox.Show("Successfully Changed!");
                    gpBoxChangePWD.Visible = false;
                    txtConfirmPwd.Text = "";
                    txtCurrentPwd.Text = "";
                    txtNewPwd.Text = "";
                }
            }
        }



        private void StaffProfile_Load(object sender, EventArgs e)
        {
        }

        /*
        private void GenerateABill_btn_Click(object sender, EventArgs e)
        {
            GenerateAirwayBill GAB = new GenerateAirwayBill();
            this.Hide();
            GAB.ShowDialog();
            this.Close();
        }*/
        /*
        private void PU_btn_Click(object sender, EventArgs e)
        {
            Pickup pu = new Pickup(staff);
            this.Hide();
            pu.ShowDialog();
            this.Close();
        }*/
        /*
        private void GenerateInvoice_btn_Click(object sender, EventArgs e)
        {
            GenerateInvoice GI = new GenerateInvoice(staff);
            this.Hide();
            GI.ShowDialog();
            this.Close();
        }*/
    }
}
