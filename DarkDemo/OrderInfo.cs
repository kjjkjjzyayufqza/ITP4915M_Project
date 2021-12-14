using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DarkDemo
{
    public partial class OrderInfo : Form
    {
        private List<Shipment> shipments = new List<Shipment>();
        private Customer customer;
        private Staff staff;
        private Boolean isStaff;
        private List<Item> itemlist = new List<Item>();
        DataAccess db = new DataAccess();
        private checkOrder f;
        private string search;
        public OrderInfo(string search)
        {
            InitializeComponent();
            this.search = search; 
        }

        public OrderInfo(string search, Customer customer)
        {
            InitializeComponent();
            this.search = search;
            this.customer = customer;
            f = new checkOrder(customer);
            isStaff = false;
            shipments = db.getShipmentAbsoluteID(search);
        }

        public OrderInfo(string search, Staff staff)
        {
            InitializeComponent();
            this.search = search;
            this.staff = staff;
            f = new checkOrder(staff);
            isStaff = true;
            shipments = db.getShipmentAbsoluteID(search);
        }

        private void lblShipmentID_Click(object sender, EventArgs e)
        {

        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            
            Shipment shipment = shipments[0];
            lblShipmentID.Text += shipment.shipment_id;
            lblAddress.Text += shipment.recAddress;
            lblCompany.Text += shipment.recCompanyName;
            lblName.Text += shipment.contact_name;
            lblPhone.Text += shipment.contact_phone;
            lblDate.Text += shipment.createdDate;
            lblStatus.Text += shipment.status;
            lblPrice.Text += shipment.price;
            lblPriceEdit.Text += shipment.price;
            lblShipmentIDEdit.Text += shipment.shipment_id;
            lblDateEdit.Text += shipment.createdDate;
            lblStatusEdit.Text += shipment.status;
            txtAddress.Text = shipment.recAddress;
            txtCompany.Text = shipment.recCompanyName;
            txtName.Text = shipment.contact_name;
            txtPhone.Text = shipment.contact_phone;

            itemlist = db.getItem(search);
            foreach (Item i in itemlist)
            {
                ListViewItem item = new ListViewItem(i.item_id.ToString());
                item.SubItems.Add(i.length + " x " + i.width + " x " + i.height);
                item.SubItems.Add(i.weight.ToString());
                item.SubItems.Add(i.description);
                lsvItem.Items.Add(item);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelCheck.Visible = false;
            panelEdit.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string[] original = { shipments[0].recAddress, shipments[0].recCompanyName, shipments[0].contact_name, shipments[0].contact_phone};
            string[] name = { "address", "company name", "name", "phone"};
            string[] change = { txtAddress.Text.ToString(), txtCompany.Text.ToString(), txtName.Text.ToString(),txtPhone.Text.ToString()};

            string con;
            Boolean isUpdate = false;
            Boolean isFirst = true;
            con = "Shipment detail (";
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
            con += ") of shipment " + shipments[0].shipment_id + " is updated";

            shipments[0].recAddress = txtAddress.Text;
            shipments[0].recCompanyName = txtCompany.Text;
            shipments[0].contact_name = txtName.Text;
            shipments[0].contact_phone = txtPhone.Text;
            db.MergeShipment(shipments[0]);
            if (isStaff)
            {
                if (isUpdate)
                {
                    db.MergeDeliveryMangementLogs(new DeliveryMangementLogs { staff_id = staff.staff_id, shipment_id = shipments[0].shipment_id, content = con });
                }
            }
            else
            {
                if (isUpdate)
                {
                    db.MergeUserDeliveryManagementLogs(new UserDeliveryManagementLogs { customer_id = customer.account_id, shipment_id = shipments[0].shipment_id, content = con });
                }
            }
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panelCheck.Visible = true;
            panelEdit.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
