using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DarkDemo.LogicClass;
using MySql.Data.MySqlClient;

namespace DarkDemo
{
    public partial class Login : Form
    {
        public int accountID { get; set; }
        private DataAccess db = new DataAccess();
        private Boolean isCal = true;
        private int debug = 0;
        public Login()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void buttonCal_Click(object sender, EventArgs e)
        {
            if (isCal)
            {
                isCal = false;
                cal_btn.Visible = false;
                lblLogin.Text = "Calculate";
                PanelCal.Visible = false;
                PanelCal.Width = 360;
                TransitionCal1.ShowSync(PanelCal);
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register f = new Register();

            f.ShowDialog();
        }

        private void swtchShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (isCal == false)
            {
                cal_btn.Visible = true;
                lblLogin.Text = "Login";
                PanelCal.Visible = true;
                PanelCal.Width = 0;
                TransitionCal1.ShowSync(PanelCal);
                isCal = true;
            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string domain;
            if (String.IsNullOrEmpty(txtBoxUserName.Text))
            {
                txtBoxUserName.Focus();
                lblAlert.Text = "Email is required!";
            }
            else if (String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                txtBoxPassword.Focus();
                lblAlert.Text = "Password is required!";
            }
            else if (txtBoxUserName.Text.Contains("@"))
            {
                domain = txtBoxUserName.Text.Split('@')[1];
                if (domain.Equals("edeexpress.com.hk"))
                {
                    try
                    {
                        userLogin("staff", txtBoxUserName.Text, txtBoxPassword.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message); 
                    }
                    
                }
                else
                {
                    try
                    {
                        userLogin("customer", txtBoxUserName.Text, txtBoxPassword.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                txtBoxUserName.Focus();
                lblAlert.Text = "Email format invalid!";
            }
        }

        private void lblForgetPWD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added in the future");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelCal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboDestination.SelectedIndex = -1;
            txtWeight.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtWeight.TextLength == 0)
            {
                MessageBox.Show("please enter the weight");
            }
            else
            {
                try
                {
                    double weight = Convert.ToDouble(txtWeight.Text);
                    Calculator cal = new Calculator();
                    if (cboDestination.SelectedItem.ToString() == "Australia" ||
                        cboDestination.SelectedItem.ToString() == "Japan")
                    {
                        if (cboType.SelectedItem.ToString() == "Document" && weight < 3)
                        {
                            MessageBox.Show("Countries: " + cboDestination.SelectedItem.ToString() + "\n" + "Fee (HKD): " + cal.calDocument(weight));
                        }
                        else if (cboType.SelectedItem.ToString() == "Document" && weight >= 3)
                        {
                            MessageBox.Show("Document cannot weight over 3kg");
                        }
                        else if(cboType.SelectedItem.ToString() == "Freight" && weight >= 3 && weight <= 999)
                        {
                            MessageBox.Show("Countries: " + cboDestination.SelectedItem.ToString() + "\n" + "Fee (HKD): " + cal.calculateOversea(weight));
                        }
                        else if (cboType.SelectedItem.ToString() == "Freight" && (weight < 3 || weight > 999))
                        {
                            MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                        }
                     }
                    if (cboDestination.SelectedItem.ToString() == "Shanghai-China"){
                        
                        if (cboType.SelectedItem.ToString() == "Document" && weight < 3)
                        {
                            MessageBox.Show("Countries: " + cboDestination.SelectedItem.ToString() + "\n" + "Fee (HKD): " + cal.calDocument(weight));
                        }
                        else if (cboType.SelectedItem.ToString() == "Document" && weight >= 3)
                        {
                            MessageBox.Show("Document cannot weight over 3kg");
                        }
                        else if (cboType.SelectedItem.ToString() == "Freight" && weight >= 3 && weight <= 999)
                        {
                            MessageBox.Show("Countries: " + cboDestination.SelectedItem.ToString() + "\n" + "Fee (HKD): " + cal.calculateMainland(weight));
                        }
                        else if(cboType.SelectedItem.ToString() == "Freight" && (weight < 3 || weight > 999))
                        {
                            MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                        }
                    }
                }catch (Exception)
                {
                    MessageBox.Show("Please Enter number");
                }
            }

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            debug++;
            if (debug >= 3)
            {
                EGG egg = new EGG();
                egg.Show();

            }
        }
        private void userLogin(string userType, string email, string password)
        {
            if (userType.Equals("staff"))
            {
                List<Staff> staff = db.StaffLogin(email, password);
                if (staff.Count != 1)
                {
                    lblAlert.Text = "Invalid email or password! \nEmail has not registered \nOr the password is invalid.";
                }
                else
                {
                    StaffMenu menu = new StaffMenu(staff[0]);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                List<Customer> customer = db.CustomerLogin(email, password);
                if (customer.Count != 1)
                {
                    lblAlert.Text = "Invalid email or password! \nEmail has not registered \nOr the password is invalid.";
                }
                else
                {
                    CustomerMenu menu = new CustomerMenu(customer[0]);
                    accountID = customer[0].account_id;
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();

                }
            }
        }

        private void togswitShowPWD_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void cboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("未整");
        }

        private void txtBoxUserName_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                btnLogin.Focus();

                btLogin_Click(sender, e);

                btnLogin.Focus();
            }
        }

        private void txtBoxPassword_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                btnLogin.Focus();

                btLogin_Click(sender, e);

                btnLogin.Focus();
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

