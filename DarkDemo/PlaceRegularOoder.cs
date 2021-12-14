using DarkDemo.LogicClass;
using DarkDemo.ModalClass;
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
    public partial class PlaceRegularOoder : Form
    {
        private bool creatingRecord;
        private DataAccess db=new DataAccess();
        private Random random = new Random();
        private List<Shipment> shipments;
        private List<List<Item>> items;
        private List<DTDOrder> dTDOrders;
        private Customer customer;
        private MailServer ms = new MailServer();
        private List<Invoice> invoices;
        private List<RegularOrder> regularOrders;
        public PlaceRegularOoder(Customer customer)
        {
            InitializeComponent();
            creatingRecord = false;
            this.customer = customer;
        }

        private void PlaceRegularOoder_Load(object sender, EventArgs e)
        {
            btnCreateRecord.Text = "New Record";
            creatingRecord = false;
            txtRecordName.Visible = false;
            btnUploadShipment.Visible = false;
            shipments = new List<Shipment>();
            items = new List<List<Item>>();
            dTDOrders = new List<DTDOrder>();
            dtpDate.MinDate = DateTime.Now;
            invoices = new List<Invoice>();
            lstBoxReceiver.DataSource = null;
            lstBoxReceiver.SelectedIndex = -1;
            regularOrders = db.GetRegularOrder(customer.account_id);
            UpdateOrderRecord();
        }

        private void btnUploadShipment_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Reqired File|*.csv;*.xls" })
                {
                    DateTime now = DateTime.Now;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        UpdateReceiver();
                        ReadCSV(File.ReadAllLines(ofd.FileName), false);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File format wrong.");
                PlaceRegularOoder_Load(sender,e);
            }
            
        }

        public void ReadCSV(string[] lines, bool reload)
        {
            try { 
                if (reload)
                {
                    Console.WriteLine("1");
                    PlaceRegularOoder_Load(null, null);
                }
                List<string> shipmentData;
                List<string> itemData;
                shipments = new List<Shipment>();
                items = new List<List<Item>>();
                dTDOrders = new List<DTDOrder>();
                lstBoxReceiver.SelectedIndex = -1;
                dtpDate.MinDate = DateTime.Now;
                invoices = new List<Invoice>();
                for (int i = 0; i < lines.Length; i++)
                {
                    shipmentData = lines[i].Split('|')[0].Split(',').Select(p => p.Trim()).ToList();
                    Shipment s = new Shipment { shipment_id = genShipmentID(customer.country.Trim(), shipmentData[2].Trim()), sender_id = customer.account_id, recCompanyName = shipmentData[0], recAddress = shipmentData[1], recCountry = shipmentData[2], recPOSTCODE = shipmentData[3], contact_name = shipmentData[4], contact_phone = shipmentData[5], recEmail = shipmentData[6], description = shipmentData[7], service_type = shipmentData[8], code = ms.genCode(), invoice_id = genInvoiceID(), status = "Collecting package" };
                    shipments.Add(s);
                    invoices.Add(new Invoice { invoice_id = s.invoice_id, account_id = customer.account_id });
                    items.Add(new List<Item>());
                    for (int j = 1; j < lines[i].Split('|').Length; j++)
                    {
                        itemData = lines[i].Split('|')[j].Split(',').Select(p => p.Trim()).ToList();
                        items[i].Add(new Item { item_id = j, shipment_id = s.shipment_id, description = itemData[0], value = itemData[1], length = int.Parse(itemData[2].Split('*')[0].Trim()), width = int.Parse(itemData[2].Split('*')[1].Trim()), height = int.Parse(itemData[2].Split('*')[2].Trim()), weight = double.Parse(itemData[3]) });
                    }
                    s.price = GetPrice(i);
                    dTDOrders.Add(new DTDOrder { shipment_id = s.shipment_id, account_id = customer.account_id, date = shipmentData[9] });
                }
                UpdateReceiver();
                }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private int genInvoiceID()
        {
            int invoiceID;
            do
            {
                invoiceID = random.Next(1000001, 9999999);
                foreach (Invoice i in invoices)
                {
                    if (i.invoice_id == invoiceID)
                    {
                        continue;
                    }
                }
            }
            while (db.GetInvoiceByAbsInvID(invoiceID).Count > 0 );
            return invoiceID;
        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            if (creatingRecord)
            {
                PlaceRegularOoder_Load(sender, e);
            }
            else
            {
                lstBoxReceiver.DataSource = null;
                cboRegularOrder.SelectedIndex = -1;
                txtRecordName.Text = "";
                btnCreateRecord.Text = "Cancel";
                creatingRecord = true;
                txtRecordName.Visible = true;
                btnUploadShipment.Visible = true;
            }
        }

        private void lstBoxReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxReceiver.SelectedIndex >= 0)
            {
                Shipment s;
                DTDOrder d;
                s = shipments[lstBoxReceiver.SelectedIndex];
                d = dTDOrders[lstBoxReceiver.SelectedIndex];
                txtName.Text = s.contact_name;
                txtAddress.Text = s.recAddress;
                txtCompany.Text = s.recCompanyName;
                txtEmail.Text = s.recEmail;
                txtPhone.Text = s.contact_phone;
                txtPostCode.Text = s.recPOSTCODE.ToString();
                cboCountry.Text = s.recCountry;
                cboShipmentType.Text = s.service_type;
                txtDescription.Text = s.description;
                btnSave.Visible = true;
                btnCancelEdit.Visible = true;
                dtpDate.Value = Convert.ToDateTime(d.date.Split(' ')[0]);
                dtpTime.Value = Convert.ToDateTime(d.date.Split(' ')[1]);
                UpdateItem(lstBoxReceiver.SelectedIndex);
            }
            else
            {
                txtName.Text = "";
                txtAddress.Text = "";
                txtCompany.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtPostCode.Text = "";
                cboCountry.Text = "";
                cboShipmentType.Text = "";
                txtDescription.Text = "";
                UpdateItem(lstBoxReceiver.SelectedIndex);
                dtpDate.Value = DateTime.Now;
                dtpTime.Value = DateTime.Now;
                btnSave.Visible = false;
                btnCancelEdit.Visible = false;
            
            }
        }

        private void UpdateItem(int index)
        {
            lsvItem.Items.Clear();
            lblPrice.Text = "";
            if (index >= 0)
            {
                foreach (Item i in items[index])
                {
                    ListViewItem lvitems = new ListViewItem(i.item_id.ToString());
                    lvitems.SubItems.Add(i.description);
                    lvitems.SubItems.Add(i.weight.ToString());
                    lvitems.SubItems.Add(i.length.ToString());
                    lvitems.SubItems.Add(i.width.ToString());
                    lvitems.SubItems.Add(i.height.ToString());
                    lvitems.SubItems.Add(i.value);
                    lsvItem.Items.Add(lvitems);
                }
                lblPrice.Text += " HKD$ " + shipments[index].price;
            }
        }

        public double GetPrice(int index)
        {
            Shipment s = shipments[index];
            Calculator cal = new Calculator();
            double totalWeight = 0.0;
            double shippingFees = 0.0;
            bool isDocument = (s.service_type == "DOCUMENT");
            foreach (Item item in items[index])
            {
                totalWeight += item.weight;
            }
            if (s.recCountry == "Australia" || s.recCountry == "Japan")
            {
                if (isDocument && totalWeight < 3)
                {
                    shippingFees += cal.calDocument(totalWeight);
                }
                else if (isDocument && totalWeight >= 3)
                {
                    MessageBox.Show("Document cannot weight over 3kg");
                    return 0.0;
                }
                else if (!isDocument && totalWeight >= 3 && totalWeight <= 999)
                {
                    shippingFees += cal.calculateOversea(totalWeight);
                }
                else
                {
                    MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                    return 0.0;
                }
            }
            else
            {
                if (isDocument && totalWeight < 3)
                {
                    shippingFees += cal.calDocument(totalWeight);
                }
                else if (isDocument && totalWeight >= 3)
                {
                    MessageBox.Show("Document cannot weight over 3kg");
                    return 0.0;
                }
                else if (!isDocument && totalWeight >= 3 && totalWeight <= 999)
                {
                    shippingFees += cal.calculateMainland(totalWeight);
                }
                else
                {
                    MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                    return 0.0;
                }
            }
            return shippingFees;
        }

        private async void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtRecordName.Text == "")
            {
                MessageBox.Show("Record name can not be empty.");
            }
            else{
                double totalFees = 0.0;
                for (int i = 0; i < items.Count; i++)
                {
                    totalFees += GetPrice(i);
                }
                switch (MessageBox.Show("The total shipping fee of all order is HKD" + totalFees + "\nConfirm order?", "Confirm booking", MessageBoxButtons.YesNo))
                {

                    case DialogResult.Yes:
                        if (lstBoxReceiver.Items.Count > 0)
                        {
                            db.MergeInvoice(invoices);
                            for (int i = 0; i < shipments.Count; i++)
                            {
                                shipments[i].monthlyInvoice_id = CreateMInvoiceIfNotExits(dTDOrders[i].date.Split(' ')[0], customer.account_id.ToString());
                            }
                            await Task.Run(()=>db.MergeShipmentAsync(shipments));
                            db.MergeDTDOrder(dTDOrders);
                            foreach (List<Item> i in items)
                            {
                                db.insertItems(i);
                            }
                            StoreToRecord();
                            DialogResult dialogResult = MessageBox.Show("Keep placing order?", "Continue or?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                PlaceRegularOoder_Load(sender, e);
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Select Stored Record or Upload your .csv record.");
                        }
                        break;
                    case DialogResult.No:
                        totalFees = 0;
                        break;
                }
            }
        }
        public void StoreToRecord() {
            string csv = "";
            for(int i=0; i < lstBoxReceiver.Items.Count; i++)
            {
                if(i != 0)
                {
                    csv += "\n";
                }
                Shipment s = shipments[i];
                DTDOrder d = dTDOrders[i];
                csv += $"{s.recCompanyName},{s.recAddress},{s.recCountry},{s.recPOSTCODE},{s.contact_name},{s.contact_phone},{s.recEmail},{s.description},{s.service_type},{d.date}";
                List<Item> item = items[i];
                foreach(Item j in item)
                {
                    csv += $"|{j.description},{j.value},{j.length}*{j.width}*{j.height},{j.weight}";
                }
                
            }
            Console.WriteLine(csv);
            db.MergeRegularOrder(new RegularOrder { record_name = txtRecordName.Text, sender_id = customer.account_id, csv = csv });
        }
        private int CreateMInvoiceIfNotExits(string shipmentDate, string accountID)
        {
            string[] yearMonth = shipmentDate.Split('-');
            int monthlyInvoiceID = int.Parse(yearMonth[0] + yearMonth[1]);
            if (db.getMonthlyInvoiceByKey(monthlyInvoiceID.ToString(), accountID).Count != 1)
            {
                db.MergeMonthlyInvoice(new MonthlyInvoice() { invoice_id = monthlyInvoiceID, account_id = int.Parse(accountID), paid_status = 'N', payment_method = "NOT SET" });
            }
            return monthlyInvoiceID;
        }

        private string genShipmentID(string fCountry, string tCountry)
        {
            string frontCode = shortForm(fCountry) + shortForm(tCountry);
            string shipmentID;
            do
            {
                shipmentID = frontCode + random.Next(1000000, 9999999).ToString();
                foreach(Shipment shipment in shipments)
                {
                    if(shipment.shipment_id == shipmentID)
                    {
                        continue;
                    } 
                }
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

        public void UpdateReceiver()
        {
            lstBoxReceiver.DataSource = null;
            lstBoxReceiver.DataSource = shipments;
            lstBoxReceiver.DisplayMember = "ReceiverInfo";
        }

        public void UpdateOrderRecord()
        {
            cboRegularOrder.DataSource = null;
            cboRegularOrder.DataSource = regularOrders;
            cboRegularOrder.DisplayMember = "name";
            cboRegularOrder.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shipment s = shipments[lstBoxReceiver.SelectedIndex];
            DTDOrder d = dTDOrders[lstBoxReceiver.SelectedIndex];
            string date = dtpDate.Value.ToString("yyyy-MM-dd") + " " + dtpTime.Value.ToString("HH:mm");
            switch (MessageBox.Show("Confirm Edit?", "Confirm?", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    s.recEmail = txtEmail.Text;
                    s.recAddress = txtAddress.Text;
                    s.recCompanyName = txtCompany.Text;
                    s.recPOSTCODE = txtPostCode.Text;
                    s.contact_name = txtName.Text;
                    s.contact_phone = txtPhone.Text;
                    s.description = txtDescription.Text;
                    d.date = date;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            int i = lstBoxReceiver.SelectedIndex;
            lstBoxReceiver.SelectedIndex = -1;
            lstBoxReceiver.SelectedIndex = i;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRegularOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboRegularOrder.SelectedIndex >= 0)
            {
                txtRecordName.Text = regularOrders[cboRegularOrder.SelectedIndex].record_name;
                ReadCSV(regularOrders[cboRegularOrder.SelectedIndex].csv.Split(new[] { "\n" }, StringSplitOptions.None),false);
            }
            else
            {
                lstBoxReceiver.DataSource = null;
            }
        }
    }
}
