using DarkDemo.LogicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkDemo.RelationalClass;

namespace DarkDemo
{
    public partial class Items : Form
    {
        private Calculator cal;
        private int itemID = 1;
        private DataAccess db = new DataAccess();
        private List<Item> items = new List<Item>();
        private List<MonthlyInvoice> monthlyInvoices = new List<MonthlyInvoice>();
        public CustomerMenu customerMenu;
        public Staff s;
        private int count = 0;
        private int itemNo = 0;
        private double shippingFees = 0;
        private Boolean isStaff;
        private LinkedList<Guna.UI2.WinForms.Guna2Button> btn = new LinkedList<Guna.UI2.WinForms.Guna2Button>();
        int time = 0;
        int User = 0;
        Boolean minormax = true;
        Boolean check = false;
        Shipment shipment;
        private readonly Random random = new Random();
        private DTDOrder dtdOrder;
        private Boolean isDocument;
        private Customer customer;
        private Pickup pickup;
        public Items(Customer customer, Shipment shipment, DTDOrder dtdOrder, Boolean isDocument, CustomerMenu customerMenu)
        {
           InitializeComponent();
            this.shipment = shipment;
            Console.WriteLine(shipment.recEmail);
            this.dtdOrder = dtdOrder;
            this.isDocument = isDocument;
            this.customer = customer;
            this.customerMenu = customerMenu;
        }


        private void tbtnPickup_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Your order is not completed. Are you sure to leave the current order?", "caption", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    this.Hide();
                    this.Close();
                    customerMenu.openChildForm(new Pickup(customer, customerMenu));
                    break;
                case DialogResult.No: 
                    break;
            }
        }

        private void tbtnDTD_Click(object sender, EventArgs e)
        {
            PanelPickup.Visible = false;
            panelDTD.Visible = true;
            tbtnDTD.FillColor = Color.FromArgb(64, 64, 64);
            tbtnDTD.ForeColor = Color.FromName("Control");
            tbtnPickup.FillColor = Color.FromName("Control");
            tbtnPickup.ForeColor = Color.FromArgb(64, 64, 64);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWeight.TextLength == 0 || txtWidth.TextLength == 0 || txtHeight.TextLength == 0 || txtLength.TextLength == 0 || txtValue.TextLength == 0 || txtDescription.TextLength == 0)
            {
                MessageBox.Show("Please fill in all required info.");
            }
            else
            {
                try
                {
                    double iweight = Convert.ToDouble(txtWeight.Text);
                    int iwidth = Convert.ToInt32(txtWidth.Text);
                    int ilength = Convert.ToInt32(txtLength.Text);
                    int iheight = Convert.ToInt32(txtHeight.Text);

                    lsvItem.Items.Clear();
                    Item item = new Item { item_id = itemID, shipment_id = shipment.shipment_id, description = txtDescription.Text, weight = iweight, length = ilength, width = iwidth, height = iheight, value = txtValue.Text };
                    items.Add(item);
                    itemID++;
                    itemNo++;
                    foreach (Item i in items)
                    {
                        ListViewItem lvitems = new ListViewItem(i.item_id.ToString());
                        lvitems.SubItems.Add(i.description.ToString());
                        lvitems.SubItems.Add(i.weight.ToString());
                        lvitems.SubItems.Add(i.length.ToString());
                        lvitems.SubItems.Add(i.width.ToString());
                        lvitems.SubItems.Add(i.height.ToString());
                        lvitems.SubItems.Add(i.value.ToString());
                        lsvItem.Items.Add(lvitems);
                    }
                    if (isDocument)
                    {
                        isDocument = false;
                        txtWeight.Text = "";
                        txtLength.Text = "";
                        txtWidth.Text = "";
                        txtHeight.Text = "";
                        txtValue.Text = "";
                        txtDescription.Text = "";
                        isDocument = true;
                    }
                    else
                    {
                        txtWeight.Text = "";
                        txtLength.Text = "";
                        txtWidth.Text = "";
                        txtHeight.Text = "";
                        txtValue.Text = "";
                        txtDescription.Text = "";
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Please Enter number in weight or size filed.");
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lsvItem.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Please Select a Item before removing.");
            }
            else
            {
                
                for (int i = 0; i < items.Count; i++)
                {
                    if (int.Parse(lsvItem.SelectedItems[0].Text) == items[i].item_id)
                    {
                        items.RemoveAt(i);
                    }

                }
                for (int i = 0; i < items.Count; i++)
                {
                    items[i].item_id = i + 1;
                }
                lsvItem.Items.Clear();
                if (isDocument)
                {
                    isDocument = false;
                    txtWeight.Text = "";
                    txtLength.Text = "";
                    txtWidth.Text = "";
                    txtHeight.Text = "";
                    txtValue.Text = "";
                    txtDescription.Text = "";
                    isDocument = true;
                }
                else
                {
                    txtWeight.Text = "";
                    txtLength.Text = "";
                    txtWidth.Text = "";
                    txtHeight.Text = "";
                    txtValue.Text = "";
                    txtDescription.Text = "";
                }
                foreach (Item i in items)
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

            }
        }
        private void btnDTD_Click(object sender, EventArgs e)
        {
            cal = new Calculator();
            double totalWeight = 0.0;
            foreach (Item item in items)
            {
                totalWeight += item.weight;
            }
            if (shipment.recCountry == "Australia" || shipment.recCountry == "Japan")
            {
                if (isDocument && totalWeight == 0)
                {
                    MessageBox.Show("Document cannot weight 0kg");
                    return;
                }
                else if (isDocument && totalWeight < 3)
                {
                    shippingFees += cal.calDocument(totalWeight);
                }
                else if(isDocument && totalWeight >= 3)
                {
                    MessageBox.Show("Document cannot weight over 3kg");
                    return;
                }
                else if(!isDocument && totalWeight >= 3 && totalWeight <= 999)
                {
                    shippingFees += cal.calculateOversea(totalWeight);
                }
                else 
                {
                    MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                    return;
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
                    return;
                }
                else if (!isDocument && totalWeight >= 3 && totalWeight <= 999)
                {
                    shippingFees += cal.calculateMainland(totalWeight);
                }
                else
                {
                    MessageBox.Show("Package cannot weight below 3kg or above 999kg");
                    return;
                }
            }
            switch (MessageBox.Show("The total shipping fee " + shippingFees  + ".\nConfirm order?", "Confirm booking", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    if (lsvItem.Items.Count > 0)
                    {
                        Boolean hasMonInvoice = false;
                        monthlyInvoices = db.getMonthlyInvoiceByAccountID(customer.account_id);
                        foreach(MonthlyInvoice mon in monthlyInvoices)
                        {
                            if(mon.invoice_id == shipment.monthlyInvoice_id)
                            {
                                hasMonInvoice = true;
                            }
                        }
                        if (!hasMonInvoice)
                        {
                            db.MergeMonthlyInvoice(new MonthlyInvoice { invoice_id = shipment.monthlyInvoice_id, account_id = customer.account_id , paid_status='N', payment_method= "NOT SET" });
                        }
                        shipment.status = "Collecting package";
                        shipment.invoice_id = genInvoiceID();
                        shipment.price = shippingFees;
                        Invoice inv = new Invoice { invoice_id = shipment.invoice_id, account_id = customer.account_id};
                        db.MergeInvoice(inv);
                        db.MergeShipment(shipment);
                        db.MergeDTDOrder(dtdOrder);
                        db.insertItems(items);
                        MessageBox.Show("Shipment is confirmed, please go to check the invoice.");
                        
                        customerMenu.openChildForm(new GenerateInvoice(customer));
                    }
                    else
                    {
                        MessageBox.Show("No items in shipment.");
                    }
                    break;
                case DialogResult.No:
                    shippingFees = 0;
                    break;
            }
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {
        }
        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (isDocument && int.Parse(txtLength.Text) > 25 && txtLength.Text != "")
                {
                    MessageBox.Show("Size of EDE Express Document Envelope: 25cm(L) x 35cm(W).");
                }
            }
            catch(Exception) { MessageBox.Show("Please Enter number in weight or size filed."); }
        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isDocument && int.Parse(txtWidth.Text) > 35 && txtLength.Text != "")
                {
                    MessageBox.Show("Size of EDE Express Document Envelope: 25cm(L) x 35cm(W).");
                }
            }
            catch (Exception) { MessageBox.Show("Please Enter number in weight or size filed."); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenu.openChildForm(new Pickup(customer, shipment, customerMenu));
        }

        private void panelDTD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsvItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
