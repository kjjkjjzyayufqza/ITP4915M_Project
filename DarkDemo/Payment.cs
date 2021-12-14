using DarkDemo.RelationalClass;
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
    public partial class Payment : Form
    {
        Customer customer;
        private DataAccess db = new DataAccess();
        private int accountID;
        private Payment py;
        private GenerateInvoice generateInvoice;
        private MonthlyInvoice inv;
        private List<MonthlyInvoice> monthlyInvoices = new List<MonthlyInvoice>();
        private List<MonthInvoiceReport> monthlyInvoicesReport = new List<MonthInvoiceReport>();
        private Boolean isVisa;
        private Boolean isECheck;
        private Boolean isCash;
        private Boolean isEc = false;
        private Boolean isCa = false;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(Payment py, Customer customer)
        {
            InitializeComponent();
            this.py = py;
            this.customer = customer;
        }

        public Payment(MonthlyInvoice inv, Customer customer, GenerateInvoice generateInvoice)
        {
            InitializeComponent();
            this.inv = inv;
            this.customer = customer;
            this.generateInvoice = generateInvoice;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            monthlyInvoicesReport = db.getInvoicePrice(inv.invoice_id, customer.account_id);
            ListViewItem item = new ListViewItem(inv.invoice_id.ToString());
            item.SubItems.Add(customer.account_id.ToString());
            item.SubItems.Add(inv.paid_status.ToString());
            item.SubItems.Add(inv.payment_method.ToString());
            item.SubItems.Add(inv.dateTime.ToString());
            item.SubItems.Add(monthlyInvoicesReport[0].totalPrice.ToString());
            select_item.Items.Add(item);
        }

        private void next_btn_a_Click(object sender, EventArgs e)
        {
            Panel_conf.Location = new Point(2000, 135);
            Panel_conf.Visible = false;
            PB_a.Value = 100;
            PB_a1.Value = 100;
            Panel_paymen.Location = new Point(106, 135);
            Panel_paymen.Visible = true;
        }

        private void next_btn_py_Click(object sender, EventArgs e)
        {

            if (VISA_panel.Visible)
            {
                if (CARDN_tb.TextLength == 0 || month_tb.TextLength < 2 || year_tb.TextLength < 2 || CN_tb.TextLength == 0 || CVV_tb.TextLength == 0)
                {
                    MessageBox.Show("Please input the data");
                }
                else
                {
                    Panel_paymen.Location = new Point(2000, 135);
                    Panel_paymen.Visible = false;
                    Panel_mo.Location = new Point(106, 135);
                    Panel_mo.Visible = true;
                    PB_c.Value = 100;
                    PB_c1.Value = 100;
                }
            }
            else if (Echeck_panel.Visible)
            {
                if (isEc)
                {
                    Panel_paymen.Location = new Point(2000, 135);
                    Panel_paymen.Visible = false;
                    Panel_mo.Location = new Point(106, 135);
                    Panel_mo.Visible = true;
                    PB_c.Value = 100;
                    PB_c1.Value = 100;
                }
                else
                {
                    MessageBox.Show("Please select image to upload");
                }
            }
            else if (Cash_panel.Visible)
            {
                if (isCa)
                {
                    Panel_paymen.Location = new Point(2000, 135);
                    Panel_paymen.Visible = false;
                    Panel_mo.Location = new Point(106, 135);
                    Panel_mo.Visible = true;
                    PB_c.Value = 100;
                    PB_c1.Value = 100;
                }
                else
                {
                    MessageBox.Show("Please select image to upload");
                }
            }
        }
        private void back_btn_py_Click(object sender, EventArgs e)
        {
            Panel_paymen.Location = new Point(2000, 135);
            Panel_paymen.Visible = false;
            Panel_conf.Location = new Point(106, 135);
            Panel_conf.Visible = true;
            PB_a.Value = 0;
            PB_a1.Value = 0;
        }

        private void conf_btn_mo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Success");
            inv.paid_status = 'Y';
            if (isCash)
            {
                inv.payment_method = "Cash";
            }
            else if (isECheck)
            {
                inv.payment_method = "Echeque";
            }
            else if (isVisa)
            {
                inv.payment_method = "Visa";
            }
            db.MergeMonthlyInvoice(inv);
            generateInvoice.GenerateInvoice_Load(sender, e);
            this.Hide();
            this.Close();

        }

        private void back_btn_mo_Click(object sender, EventArgs e)
        {
            Panel_mo.Location = new Point(2000, 135);
            Panel_mo.Visible = false;
            Panel_paymen.Location = new Point(106, 135);
            Panel_paymen.Visible = true;
            PB_c.Value = 0;
            PB_c1.Value = 0;
        }

        private void Panel_paymen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void individual_p_btn_Click(object sender, EventArgs e)
        {
            isVisa = true;
            isECheck = false;
            isCash = false;
            VISA_panel.Visible = true;
            Echeck_panel.Location = new Point(20000, 95);
            Cash_panel.Location = new Point(20000, 95);
            VISA_panel.Location = new Point(231, 95);
            Echeck_panel.Visible = false;
            Cash_panel.Visible = false;
            isCa = false;
            isEc = false;
            ictureBox_Cash.Visible = false;
            ictureBox_Echeck.Visible = false;
        }

        private void m_p_btn_Click(object sender, EventArgs e)
        {
            isVisa = false;
            isECheck = true;
            isCash = false;
            VISA_panel.Visible = false;
            VISA_panel.Location = new Point(20000, 95);
            Cash_panel.Location = new Point(20000, 95);
            Echeck_panel.Visible = true;
            Echeck_panel.Location = new Point(231, 95);
            Cash_panel.Visible = false;
            isCa = false;
            isEc = false;
            ictureBox_Cash.Visible = false;
            ictureBox_Echeck.Visible = false;
        }

        private void Cash_btn_Click(object sender, EventArgs e)
        {
            isVisa = false;
            isECheck = false;
            isCash = true;
            Cash_panel.Visible = true;
            VISA_panel.Location = new Point(20000, 95);
            Echeck_panel.Location = new Point(20000, 95);
            Cash_panel.Location = new Point(231, 95);
            VISA_panel.Visible = false;
            Echeck_panel.Visible = false;
            isCa = false;
            isEc = false;
            ictureBox_Cash.Visible = false;
            ictureBox_Echeck.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void canel_btn_a_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click_2(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click_3(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click_4(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click_5(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG or PNG File| *.jpg; *.png";
                
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    isCa = true;
                    ictureBox_Cash.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upload_btn_Click_6(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG or PNG File| *.jpg; *.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    isEc = true;
                    ictureBox_Echeck.Visible = true;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Echeck_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CARDN_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CVV_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void month_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void year_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
