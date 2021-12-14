using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class CheckCustomerInfo : Form
    {
        private Boolean creatingAc;
        private Boolean updatingAc;
        private Staff staff;
        private Boolean isStaff;
        private MailServer ms;
        private DataAccess db = new DataAccess();
        private List<Customer> customers = new List<Customer>();
        int User = 0;
        int time = 0;
        Boolean minormax = true;
        Boolean check = false;
        public CheckCustomerInfo(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            isStaff = true;
        }

        private void CheckCustomerInfo_Load(object sender, EventArgs e)
        {

            lsvCustomer.Items.Clear();
            panel1.Visible = true;
            txtAccountID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtCompany.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCountry.Text = "";
            customers = db.getCustomer();
            btnUpdate.Enabled = false;
            foreach (Customer customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.account_id.ToString());
                item.SubItems.Add(customer.email);
                item.SubItems.Add(customer.name);
                item.SubItems.Add(customer.company_name);
                item.SubItems.Add(customer.address);
                item.SubItems.Add(customer.postcode);
                item.SubItems.Add(customer.phone);
                item.SubItems.Add(customer.country);
                item.SubItems.Add(customer.credit_limit);
                item.SubItems.Add(customer.create_date);
                lsvCustomer.Items.Add(item);
            }
            btnSave.Enabled = false;
            lsvCustomer.FullRowSelect = true;
            btnNew.Enabled = true;
            lsvCustomer.Enabled = true;
            creatingAc = false;
            updatingAc = false;
            txtAddress.ReadOnly = true;
            txtCompany.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int custID = 0;
            string con = "";
            Customer customer;
            Boolean isUpdate = false;
            try
            {
                string[] original = new string[6];
                if (creatingAc)
                {
                    if (db.GetCustomerByEmail(txtEmail.Text).Count > 0)
                    {
                        MessageBox.Show("Email have been registed.");
                        lsvCustomer.Items.Clear();
                        CheckCustomerInfo_Load(sender, e);
                        return;
                    }else if (!txtEmail.Text.Contains('@'))
                    {
                        MessageBox.Show("Please input an email.");
                        lsvCustomer.Items.Clear();
                        CheckCustomerInfo_Load(sender, e);
                        return;
                    }
                    else
                    {
                        ms = new MailServer();
                        customer = new Customer { name = txtName.Text, email = txtEmail.Text, company_name = txtCompany.Text, address = txtAddress.Text, phone = txtPhone.Text, country = txtCountry.Text };
                        db.MergeCustomer(customer);
                        string message = "Dear Sir/Madam,<br /><br />Thank you " +
                                "for using our services. Our staff have created an account for you as you ask,<br /><h3><b>" +
                                "Your register mail is: <br /></h3><b>" +
                                customer.email + "</b><br /><h3>Please click the link below to set up your password and " +
                                "update your personal info.</h3><a href='127.0.0.1/ITP4915M/set-password.php?email="
                                + db.GetEmailByEmail(customer.email).email + "'>Set your password here</a>" + "<br /><br />Regards,<br />EDE Express Team";
                        string subject = "Account Registered!";
                        ms.sendMail(customer.email, subject, message);
                        MessageBox.Show("Success. a mail sent to the new Customer for registration.");
                        custID = db.GetCustomerByEmail(txtEmail.Text)[0].account_id;
                        con = "New customer account " + custID + " created.";
                        creatingAc = false;

                    }
                    
                }
                else
                {
                    customers = db.getCustomerByID(Int32.Parse(lsvCustomer.SelectedItems[0].Text));
                    string[] cus = { customers[0].name, customers[0].email, customers[0].company_name, customers[0].address, customers[0].phone, customers[0].country };
                    for (int i = 0; i < original.Length; i++)
                    {
                        original[i] = cus[i];
                    }
                    customer = new Customer { account_id = int.Parse(lsvCustomer.SelectedItems[0].Text), name = txtName.Text, email = txtEmail.Text, password = "", company_name = txtCompany.Text, address = txtAddress.Text, phone = txtPhone.Text, country = txtCountry.Text, credit_limit="0" };
                    db.MergeCustomer(customer);
                    con = "Personal information (";
                    string[] name = { "name", "email", "company name", "address", "phone", "country" };
                    string[] change = { txtName.Text.ToString(), txtEmail.Text.ToString(), txtCompany.Text.ToString(), txtAddress.Text.ToString(), txtPhone.Text.ToString(), txtCountry.Text.ToString() };
                    Boolean isFirst = true;
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
                    custID = int.Parse(lsvCustomer.SelectedItems[0].Text);
                    con += ") of account " + custID + " is updated";
                }
                if (isUpdate)
                {
                    db.MergeCustomerManagementLogs(new CustomerManagementLogs { staff_id = staff.staff_id, customer_id = custID, content = con });
                }
                MessageBox.Show(con);
                lsvCustomer.Items.Clear();
                CheckCustomerInfo_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updatingAc)
            {
                updatingAc = false;
                CheckCustomerInfo_Load(null, e);
            }
            else
            {
                panel1.Visible = true;
                updatingAc = true;
                txtAddress.ReadOnly = false;
                txtCompany.ReadOnly = false;
                txtCountry.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                btnSave.Enabled = true;
                btnNew.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                lsvCustomer.Items.Clear();
                if (txtAccountID.TextLength == 0)
                {
                    customers = db.getCustomer();
                    foreach (Customer customer in customers)
                    {
                        ListViewItem item = new ListViewItem(customer.account_id.ToString());
                        item.SubItems.Add(customer.email);
                        item.SubItems.Add(customer.name);
                        item.SubItems.Add(customer.company_name);
                        item.SubItems.Add(customer.address);
                        item.SubItems.Add(customer.postcode);
                        item.SubItems.Add(customer.phone);
                        item.SubItems.Add(customer.country);
                        item.SubItems.Add(customer.credit_limit);
                        item.SubItems.Add(customer.create_date);
                        lsvCustomer.Items.Add(item);
                    }
                }
                else
                {
                    customers = db.getCustomerByID(int.Parse(txtAccountID.Text));
                    foreach (Customer customer in customers)
                    {
                        ListViewItem item = new ListViewItem(customer.account_id.ToString());
                        item.SubItems.Add(customer.email);
                        item.SubItems.Add(customer.name);
                        item.SubItems.Add(customer.company_name);
                        item.SubItems.Add(customer.address);
                        item.SubItems.Add(customer.postcode);
                        item.SubItems.Add(customer.phone);
                        item.SubItems.Add(customer.country);
                        item.SubItems.Add(customer.credit_limit);
                        item.SubItems.Add(customer.create_date);
                        lsvCustomer.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the correct index");
            }
        }

        private void lsvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (lsvCustomer.SelectedItems.Count > 0)
            {
                btnUpdate.Enabled = true;
                string custId = lsvCustomer.SelectedItems[0].Text;
                int cid = int.Parse(custId);
                Customer customer = db.getCustomerByID(cid)[0];
                txtName.Text = customer.name;
                txtEmail.Text = customer.email;
                txtCompany.Text = customer.company_name;
                txtAddress.Text = customer.address;
                txtPhone.Text = customer.phone;
                txtCountry.Text = customer.country;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtNew_Click(object sender, EventArgs e)
        {
            if (creatingAc)
            {
                CheckCustomerInfo_Load(sender, e);
            }
            else
            {
                txtAccountID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtCompany.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtCountry.Text = "";
                creatingAc = true;
                txtAddress.ReadOnly = false;
                txtCompany.ReadOnly = false;
                txtCountry.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                panel1.Visible = true;
                lsvCustomer.Enabled = false;
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void lsvCustomer_Click(object sender, EventArgs e)
        {
            if(btnNew.Enabled == true)
            {
                txtAddress.ReadOnly = true;
                txtCompany.ReadOnly = true;
                txtCountry.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
            }
        }
    }
}
