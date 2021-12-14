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
    public partial class UpdateShipments : Form
    {
        private Staff staff;
        private DataAccess db = new DataAccess();
        private List<Shipment> dr;
        private MailServer ms = new MailServer();
        private Customer customer;
        public UpdateShipments()
        {
            InitializeComponent();
            btnSearch_Click(null, null);
        }

        public UpdateShipments(Staff staff)
        {
            InitializeComponent();
            btnSearch_Click(null, null);
            this.staff = staff;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvDelivery.Items.Clear();
            if (txtShipmentID.TextLength == 0)
            {
                dr = db.getAllShipments();
                foreach (Shipment ship in dr)
                {
                    customer = db.getCustomerByID(ship.sender_id)[0];
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(customer.country);
                    item.SubItems.Add(ship.recCountry);
                    item.SubItems.Add(ship.status);
                    lsvDelivery.Items.Add(item);
                }
            }
            else
            {
                dr = db.getShipmentByID(txtShipmentID.Text);
                foreach (Shipment ship in dr)
                {
                    customer = db.getCustomerByID(ship.sender_id)[0];
                    ListViewItem item = new ListViewItem(ship.shipment_id);
                    item.SubItems.Add(customer.country);
                    item.SubItems.Add(ship.recCountry);
                    item.SubItems.Add(ship.status);
                    lsvDelivery.Items.Add(item);
                }
            }
        }

        private void txtShipmentID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void UpdateShipments_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(lsvDelivery.SelectedItems.Count > 0 && cboStatus.SelectedIndex != -1)
            {
                
                Shipment s = db.getShipmentAbsoluteID(lsvDelivery.SelectedItems[0].Text)[0];
                customer = db.getCustomerByID(s.sender_id)[0];
                s.status = cboStatus.Items[cboStatus.SelectedIndex].ToString();
                db.MergeShipment(s);
                DeliveryRecord dd = new DeliveryRecord { shipmentID = s.shipment_id, status = cboStatus.Items[cboStatus.SelectedIndex].ToString()};
                db.MergeDeliveryRecord(dd);
                if (cboStatus.Items[cboStatus.SelectedIndex].ToString() == "Delivering")
                {
                    string title = "Package Delivering!";
                    string message = "Dear Sir/Madam,<br /><br />Thank you for using our services. Your Package <b>(ID: " + s.shipment_id + ")</b><br />is now sending to our warehouse<b>(" + s.recCountry + ")</b>.<br />If you have any question, please contact us.<br /><br />Regards,<br />EDE Express Team";
                    ms.sendMail(customer.email, title, message);
                    MessageBox.Show("Update success and Mail already sent to customer.");
                }
                else if(cboStatus.Items[cboStatus.SelectedIndex].ToString() == "Arrived at Destination")
                {
                    string title = "Package Arrived!";
                    string message = "Dear Sir/Madam,<br /><br />Thank you for using our services. Your Package <b>(ID: " + s.shipment_id + ")</b><br />arrived to the desination warehouse<b>(" + s.recCountry + ")</b>.<br />If you have any question, please contact us.<br /><br />Regards,<br />EDE Express Team";
                    ms.sendMail(s.recEmail, title, message);
                    MessageBox.Show("Update success and Mail already sent to receiver.");
                }
                db.MergeDeliveryMangementLogs(new DeliveryMangementLogs { staff_id = staff.staff_id, shipment_id = s.shipment_id, content = "Status of shipment " + s.shipment_id + " is updated to " + cboStatus.Items[cboStatus.SelectedIndex].ToString() });
                MessageBox.Show("Update success.");
                btnSearch_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please Select shipment and the status.");
            }
        }

        private void lsvDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
