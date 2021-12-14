using DarkDemo.LogicClass;
using DarkDemo.RelationalClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class DataMigration : Form
    {
        private Random random;
        private Staff staff;
        private DataAccess db;
        private int failedInsert = 0;
        private List<int> problemLines;

        public DataMigration(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            db = new DataAccess();
            random = new Random();
        }



        private async void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            failedInsert = 0;
            problemLines = new List<int>();
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Reqired File|*.csv;*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataMigration_Load(sender, e);
                    txtFailedLines.Clear();
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    await (Task.Run(() => readLine(lines, new List<Customer>())));
                }
            }
        }

        private void readLine(string[] lines, List<Customer> customers)
        {
            string[] value;
            HashSet<string> records = new HashSet<string>();
            int i = 0;
            for (int j = 0; j < lines.Length; j++)
            {
                records.Add(lines[j]);
                lblTotal.Invoke((MethodInvoker)(() => lblTotal.Text = "Readed " + (j + 1) + " lines."));
            }
            foreach (string record in records)
            {
                value = record.Split(',');
                try
                {
                    customers.Add(new Customer() { account_id = int.Parse(value[0].Trim()), email = value[1].Trim(), password = value[2].Trim(), name = value[3].Trim(), company_name = value[4].Trim(), address = value[5].Trim(), postcode = value[6].Trim(), phone = value[7].Trim(), country = value[8].Trim(), credit_limit = value[9].Trim(), create_date = value[10].Trim() });
                }
                catch (Exception)
                {
                    failedInsert++;
                    problemLines.Add(i + 1);
                }
                i++;
            }
            lblSuccess.Invoke((MethodInvoker)(() => lblSuccess.Text = (i - failedInsert) + " invoice records inserted successfully.\n" + (lines.Length - i) + " record ignored due to duplicate"));
            lblFailed.Invoke((MethodInvoker)(() => lblFailed.Text = failedInsert + " record insert failed. At rows (Possiblely due to wrong record structure.)"));
            foreach (int num in problemLines)
            {
                txtFailedLines.Invoke((MethodInvoker)(() => txtFailedLines.AppendText(num + Environment.NewLine)));
            }
            db.MergeCustomerAsync(customers);
        }

        private async void btnInsertShipment_Click(object sender, EventArgs e)
        {
            failedInsert = 0;
            problemLines = new List<int>();

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Reqired File|*.csv;*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataMigration_Load(sender, e);
                    txtFailedLines.Clear();
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    await(Task.Run(() => readLine(lines, new List<Shipment>())));
                }
            }
        }

        private void readLine(string[] lines, List<Shipment> shipments)
        {
            string[] value;
            HashSet<string> records = new HashSet<string>();
            List<Invoice> invoices = new List<Invoice>();
            int i = 0;
            for (int j = 0; j < lines.Length; j++)
            {
                records.Add(lines[j]);
                lblTotal.Invoke((MethodInvoker)(() => lblTotal.Text = "Readed " + (j + 1) + " lines."));
            }
            foreach (string record in records)
            {
                value = record.Split(',');
                try
                {
                    Shipment shipment = new Shipment()
                    {
                        shipment_id = value[0].Trim(),
                        sender_id = int.Parse(value[1].Trim()),
                        recAddress = value[2].Trim(),
                        recEmail = value[3].Trim(),
                        recCountry = value[4].Trim(),
                        recCompanyName = value[5].Trim(),
                        recPOSTCODE = value[6].Trim(),
                        contact_name = value[7].Trim(),
                        contact_phone = value[8].Trim(),
                        createdDate = value[9].Trim(),
                        description = value[10].Trim(),
                        service_type = value[11].Trim(),
                        price = Double.Parse(value[12].Trim()),
                        status = value[13].Trim(),
                        monthlyInvoice_id = CreateMInvoiceIfNotExits(value[9].Trim().Split(' ')[0], value[1].Trim())
                    };
                    Invoice invoice = new Invoice() { invoice_id = genInvoiceID(), account_id = shipment.sender_id };
                    db.MergeInvoice(invoice);
                    shipment.invoice_id = invoice.invoice_id;
                    shipments.Add(shipment);
                }
                catch (Exception)
                {
                    failedInsert++;
                    problemLines.Add(i + 1);
                }
                i++;
            }
            lblSuccess.Invoke((MethodInvoker)(() => lblSuccess.Text = (i - failedInsert) + " invoice records inserted successfully.\n" + (lines.Length - i) + " record ignored due to duplicate"));
            lblFailed.Invoke((MethodInvoker)(() => lblFailed.Text = failedInsert + " record insert failed. At rows (Possiblely due to wrong record structure.)"));
            foreach (int num in problemLines)
            {
                txtFailedLines.Invoke((MethodInvoker)(() => txtFailedLines.AppendText(num + Environment.NewLine)));
            }
            Console.WriteLine(1);
            db.MergeShipmentAsync(shipments);
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

        private int CreateMInvoiceIfNotExits(string shipmentDate, string accountID)
        {
            string[] yearMonth = shipmentDate.Split('-');
            int monthlyInvoiceID = int.Parse(yearMonth[0] + yearMonth[1]);
            
            if (db.getMonthlyInvoiceByKey(monthlyInvoiceID.ToString(), accountID).Count != 1)
            {
                db.MergeMonthlyInvoice(new MonthlyInvoice() { invoice_id= monthlyInvoiceID , account_id= int.Parse(accountID) , paid_status='Y', payment_method="Cash"});
            }
            return monthlyInvoiceID;
        }

        private void DataMigration_Load(object sender, EventArgs e)
        {
            txtFailedLines.Text = "";
            lblFailed.Text = "";
            lblSuccess.Text = "";
            lblTotal.Text = "";
        }
    }
}
