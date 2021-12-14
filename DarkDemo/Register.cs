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
    public partial class Register : Form
    {
        private Customer newAccount;
        private Boolean mailRegistered;
        private MailServer mailServer;
        Boolean check = false;
        Boolean checkEmail = false;
        Boolean checkPwd = false;
        Boolean checkCode = false;
        private DataAccess db;
        private string code;
        int time = 30;
        int times = 0;
        private static Random random = new Random();
        public Register()
        {
            InitializeComponent();
            db = new DataAccess();
            mailServer = new MailServer();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CircleProgressBar_Register.Value = 0;
            CircleProgressBar_Register.ProgressColor = Color.GreenYellow;
            CircleProgressBar_Register.ProgressColor2 = Color.LightGreen;
        }

        private void txtBoxRegisterUserEmail_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxRegisterUserEmail.TextLength > 5 && check == false)
            {
                //CircleProgressBar_Register.Value += 25;
                check = true;
            }
            else if (txtBoxRegisterUserEmail.TextLength < 5 && check == true)
            {
                //CircleProgressBar_Register.Value -= 25;
                check = false;
            }
            
            if (txtBoxRegisterUserEmail.Text.Contains("@"))
            {
                mailRegistered = (db.GetCustomerByEmail(txtBoxRegisterUserEmail.Text).Count >= 1) ? true : false;
            }
            
            if(txtBoxRegisterUserEmail.TextLength > 5 && txtBoxRegisterUserEmail.Text.Contains("@"))
            {
                checkEmail = true;
            }
            else
            {
                checkEmail = false;
            }
            validateInInput();
        }

        private void txtBoxRegisterUserPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxRegisterUserPassword.TextLength >= 6 && check == true)
            {
                //CircleProgressBar_Register.Value += 25;
                check = false;
            }
            else if (txtBoxRegisterUserPassword.TextLength < 5 && check == false)
            {
                //CircleProgressBar_Register.Value -= 25;
                check = true;
            }
            if (txtBoxRegisterUserPassword.Text != txtBoxRegisterUserPassword_c.Text)
            {
                lblMessage.Text = "Password does not match!";
            }else
            {
                lblMessage.Text = "";
            }
            if(txtBoxRegisterUserPassword.TextLength < 6 || txtBoxRegisterUserPassword_c.TextLength <6)
            {
                lblMessage.Text = "At least 6 digits in password";
            }

            if (txtBoxRegisterUserPassword.TextLength >= 6 && txtBoxRegisterUserPassword.Text == txtBoxRegisterUserPassword_c.Text)
            {
                checkPwd = true;
            }
            else
            {
                checkPwd = false;
            }
            validateInInput();
        }

        private void txtBoxRegisterUserPassword_c_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxRegisterUserPassword.TextLength >= 6 && txtBoxRegisterUserPassword.Text == txtBoxRegisterUserPassword_c.Text)
            {
                checkPwd = true;
            }
            else
            {
                checkPwd = false;
            }
            validateInInput();
        }

        private void Code_c_TextChanged(object sender, EventArgs e)
        {
            if(Code_c.TextLength == 6)
            {
                checkCode = true;
            }
            else
            {
                checkCode = false;
            }
            validateInInput();
        }
        private void BtnSendcode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtBoxRegisterUserEmail.Text.Contains("@") || txtBoxRegisterUserEmail.TextLength == 0)
                {
                    MessageBox.Show("Email input invalid.");
                }
                else
                {
                    code = mailServer.genCode();
                    BtnSendcode.Enabled = false;
                    lblMessage.Text = "Verification Code sent, please check you email.";
                    string message = "Dear Sir/Madam,<br /><br />Thank you " +
                        "for using our services. Your verification code is: <br /><h1><b>" +
                         code + "</b></h1><br /><br />Regards,<br />EDE Express Team";
                    string subject = "EDE Express Account Register Verification";
                    mailServer.sendMail(txtBoxRegisterUserEmail.Text,subject, message);
                    timer_register.Start();
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Some error occurs, please contact us." +
                    "\r\nsupport@edeexpress.co";
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxRegisterUserEmail.Text))
            {
                lblMessage.Text = "Please Enter You Email.";
            }
            else if (!txtBoxRegisterUserEmail.Text.Contains("@"))
            {
                lblMessage.Text = "Invalid Email Format.";
            }
            else if (mailRegistered)
            {
                lblMessage.Text = "Mail have been registered. Please use another email address.";
            }
            else if (String.IsNullOrEmpty(txtBoxRegisterUserPassword.Text))
            {
                lblMessage.Text = "Please Enter You Password.";
            }
            else if (String.IsNullOrEmpty(txtBoxRegisterUserPassword_c.Text))
            {
                lblMessage.Text = "Please Confirm You Password .";
            }
            else if (txtBoxRegisterUserPassword.Text != txtBoxRegisterUserPassword_c.Text)
            {
                lblMessage.Text = "Password does not match!";
            }
            else if (String.IsNullOrEmpty(Code_c.Text))
            {
                lblMessage.Text = "Please Enter the Vaerification Code from your mailbox.";
            }
            else if (Code_c.Text.Equals(code))
            {
                try
                {
                    newAccount = new Customer { email = txtBoxRegisterUserEmail.Text , password = txtBoxRegisterUserPassword.Text };
                    db.MergeCustomer(newAccount);
                    MessageBox.Show("Register success! Please Login!");
                    this.Close();
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {

                MessageBox.Show("Register failed! Incorrect verification code.");
            }
        }

        private void validateInInput()
        {
            CircleProgressBar_Register.Value = 0;
            if (mailRegistered)
            {
                lblMessage.Text = "Mail have been registered.Please use another mail address.";
                CircleProgressBar_Register.ProgressColor = Color.FromArgb(255, 128, 128);
                CircleProgressBar_Register.ProgressColor2 = Color.Firebrick;
                CircleProgressBar_Register.Value = 100;
                btRegister.FillColor = Color.FromArgb(255, 128, 128);
                btRegister.FillColor2 = Color.Firebrick;
                btRegister.ForeColor = Color.White;
            }
            else
            {
                if (checkEmail)
                {
                    CircleProgressBar_Register.ProgressColor = Color.GreenYellow;
                    CircleProgressBar_Register.ProgressColor2 = Color.LightGreen;
                    CircleProgressBar_Register.Value += 25;
                    lblMessage.Text = "";
                    btRegister.FillColor = Color.FromArgb(255, 128, 128);
                    btRegister.FillColor2 = Color.Firebrick;
                    btRegister.ForeColor = Color.White;
                }
                if (checkPwd)
                {
                    CircleProgressBar_Register.ProgressColor = Color.GreenYellow;
                    CircleProgressBar_Register.ProgressColor2 = Color.LightGreen;
                    CircleProgressBar_Register.Value += 25;
                    lblMessage.Text = "";
                    btRegister.FillColor = Color.FromArgb(255, 128, 128);
                    btRegister.FillColor2 = Color.Firebrick;
                    btRegister.ForeColor = Color.White;
                }
                if (checkCode)
                {
                    CircleProgressBar_Register.ProgressColor = Color.GreenYellow;
                    CircleProgressBar_Register.ProgressColor2 = Color.LightGreen;
                    CircleProgressBar_Register.Value += 25;
                    lblMessage.Text = "";
                    btRegister.FillColor = Color.FromArgb(255, 128, 128);
                    btRegister.FillColor2 = Color.Firebrick;
                    btRegister.ForeColor = Color.White;
                }
            }

            if(checkCode && checkEmail && checkPwd)
            {
                CircleProgressBar_Register.ProgressColor = Color.GreenYellow;
                CircleProgressBar_Register.ProgressColor2 = Color.LightGreen;
                CircleProgressBar_Register.Value = 100;
                lblMessage.Text = "";
                btRegister.FillColor = Color.GreenYellow;
                btRegister.FillColor2 = Color.LawnGreen;
                btRegister.ForeColor = Color.Black;
            }
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lab_Register_Click(object sender, EventArgs e)
        {

        }

        private void CircleProgressBar_Register_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            times += timer_register.Interval;
            if (times == 1000)
            {
                time--;
                times = 0;
            }
            BtnSendcode.Text = time + " s";
            if (time == 0)
            {
                timer_register.Stop();
                BtnSendcode.Text = "Send Code";
                BtnSendcode.Enabled = true;
                time = 60;
            }
            
        }
    }
}
