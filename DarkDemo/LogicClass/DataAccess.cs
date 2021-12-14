using Dapper;
using DarkDemo.ModalClass;
using DarkDemo.RelationalClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public class DataAccess
    {

        public List<Customer> CustomerLogin(string email, string password)
        {
            string sql = "CALL itp4915m.customerLogin(@email, @password)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Customer>(sql, new { email = email, password = password }).ToList();
            }
        }

        public List<Staff> StaffLogin(string staff_mail, string password)
        {
            string sql = "CALL itp4915m.staffLogin(@staff_mail, @password)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Staff>(sql, new { staff_mail = staff_mail, password = password }).ToList();
            }
        }

        public List<Customer> GetCustomerByEmail(string email)
        {
            string sql = "CALL itp4915m.GetCustomerByEmail(@email)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Customer>(sql, new { email = email }).ToList();
            }
        }
        public void MergeCustomer(Customer customer)
        {
            string sql = "CALL itp4915m.MergeCustomer(@account_id, @email, @password, @name, @company_name, @address, @postcode, @phone, @country, @credit_limit)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, customer);
            }
        }
        public void MergeCustomerAsync(List<Customer> customers)
        {
            string sql = "CALL itp4915m.MergeCustomer(@account_id, @email, @password, @name, @company_name, @address, @postcode, @phone, @country, @credit_limit)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, customers);
            }
        }


        public void MergeShipment(Shipment shipment)
        {
            string sql = "CALL itp4915m.MergeShipment(@shipment_id, @sender_id, @recAddress,@recEmail, @recCountry, @recCompanyName, @recPOSTCODE, @contact_name, @contact_phone, @description, @service_type, @price, @status, @invoice_id, @monthlyInvoice_id, @code)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, shipment);
            }
        }

        public void MergeShipmentAsync(List<Shipment> shipments)
        {
            string sql = "CALL itp4915m.MergeShipment(@shipment_id, @sender_id, @recAddress,@recEmail, @recCountry, @recCompanyName, @recPOSTCODE, @contact_name, @contact_phone, @description, @service_type, @price, @status, @invoice_id, @monthlyInvoice_id, @code)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                 connection.Execute(sql, shipments);
            }
        }

        public void MergeDeliveryRecord(DeliveryRecord record)
        {
            string sql = "CALL itp4915m.MergeDeliveryRecord(@shipmentID, @status)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, record);
            }
        }

        public void customerChangePassword(Customer customer)
        {
            string sql = "CALL itp4915m.customerChangePassword(@account_id, @password)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, new { account_id = customer.account_id, password = customer.password });
            }
        }

        public void staffChangePassword(Staff staff)
        {
            string sql = "CALL itp4915m.staffChangePassword(@staff_id, @password)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, new { staff_id = staff.staff_id, password = staff.password });
            }
        }

        public void MergePickupOrder(PickUpOrder order)
        {
            string sql = "CALL itp4915m.MergePickupOrder(@order_id, @shipment_id, @recEmail, @date)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, order);
            }
        }

        public List<Shipment> getShipmentByID(string shipment_id)
        {
            string sql = "CALL itp4915m.getShipmentByID(@shipment_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Shipment>(sql, new { shipment_id = shipment_id }).ToList();
            }
        }


        public List<Shipment> getShipmentBytwoID(string shipment_id, string sender_id)
        {
            string sql = "CALL itp4915m.getShipmentBytwoID(@shipment_id, @senderID)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Shipment>(sql, new { shipment_id = shipment_id, senderID = sender_id }).ToList();
            }
        }

        public List<Shipment> getAllShipments()
        {
            string sql = "CALL itp4915m.getAllShipments()";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Shipment>(sql).ToList();
            }
        }

        public List<Item> getItem(string shipment_id)
        {
            string sql = "CALL itp4915m.getItem(@shipment_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Item>(sql, new { shipment_id = shipment_id }).ToList();
            }
        }

        public List<Customer> getCustomer()
        {
            string sql = "CALL itp4915m.getCustomer()";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Customer>(sql).ToList();
            }
        }

        public List<Customer> getCustomerByID(int account_id)
        {
            string sql = "CALL itp4915m.getCustomerByID(@account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Customer>(sql, new { account_id = account_id }).ToList();
            }
        }

        public List<MonthInvoiceReport> searchMonthInvoice(int invoice_id, int account_id)
        {
            string sql = "CALL itp4915m.searchMonthInvoice(@invoice_id, @account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthInvoiceReport>(sql, new { invoice_id = invoice_id, account_id = account_id }).ToList();
            }
        }

        public List<InvoiceReport> searchInvoice(string shipment_id)
        {
            string sql = "CALL itp4915m.searchInvoice(@shipment_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<InvoiceReport>(sql, new { shipment_id = shipment_id}).ToList();
            }
        }

        public List<AirwaybillReport> searchAirwaybill(string shipmentID)
        {
            string sql = "CALL itp4915m.searchAirwaybill(@shipmentID)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<AirwaybillReport>(sql, new { shipmentID = shipmentID }).ToList();
            }
        }

        public void insertItems(List<Item> items)
        {
            string sql = "CALL itp4915m.insertItem(@item_id, @shipment_id, @description, @weight, @height, @width, @length, @value)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, items);
            }
        }


        public List<MonthlyInvoice> getAllMonthlyInvoice()
        {
            string sql = "CALL itp4915m.getAllMonthlyInvoice()";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql).ToList();
            }
        }


        public List<MonthlyInvoice> GetMonthlyInvoiceByID(string invoice_id)
        {
            string sql = "CALL itp4915m.getMonthlyInvoiceByID(@invoice_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql, new { invoice_id = invoice_id }).ToList();
            }
        }

        public List<MonthlyInvoice> getMonthlyInvoiceByKey(string invoice_id, string account_id)
        {
            string sql = "CALL itp4915m.getMonthlyInvoiceByKey(@invoice_id, @account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql, new { invoice_id = invoice_id, account_id = account_id }).ToList();
            }
        }

        public List<MonthlyInvoice> getMonthlyInvoiceByAccountID(int account_id)
        {
            string sql = "CALL itp4915m.getMonthlyInvoiceByAccountID(@account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql, new { account_id = account_id }).ToList();
            }
        }

        public List<Shipment> getShipmentByAccount(string senderID)
        {
            string sql = "CALL itp4915m.getShipmentByAccount(@senderID)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Shipment>(sql, new { senderID = senderID }).ToList();
            }
        }

        public List<Shipment> getShipmentAbsoluteID(string shipmentID)
        {
            string sql = "CALL itp4915m.getShipmentAbsoluteID(@shipmentID)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Shipment>(sql, new { shipmentID = shipmentID }).ToList();
            }
        }

        public List<DeliveryRecord> getDeliveryRecord(string shipmentID)
        {
            string sql = "CALL itp4915m.getDeliveryRecord(@shipmentID)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<DeliveryRecord>(sql, new { shipmentID = shipmentID }).ToList();
            }
        }

        public List<MonthlyInvoice> GetInvoiceByAbsInvID(int invoice_id)
        {
            string sql = "CALL itp4915m.GetInvoiceByAbsInvID(@invoice_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql, new { invoice_id = invoice_id }).ToList();
            }
        }

        public List<MonthInvoiceReport> getInvoicePrice(int invoice_id, int account_id)
        {
            string sql = "CALL itp4915m.getInvoicePrice(@invoice_id, @account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthInvoiceReport>(sql, new { invoice_id = invoice_id, account_id = account_id }).ToList();
            }
        }


        public void MergeInvoice(Invoice invoice)
        {
            string sql = "CALL itp4915m.MergeInvoice(@invoice_id, @account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, invoice);
            }
        }

        public void MergeInvoice(List<Invoice> invoices)
        {
            string sql = "CALL itp4915m.MergeInvoice(@invoice_id, @account_id)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, invoices);
            }
        }

        public void MergeMonthlyInvoice(MonthlyInvoice invoice)
        {
            string sql = "CALL itp4915m.MergeMonthlyInvoice(@invoice_id, @account_id, @paid_status, @payment_method)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, invoice);
            }
        }

        public void MergeDTDOrder(DTDOrder dtdOrder)
        {
            string sql = "CALL itp4915m.MergeDTDOrder(@shipment_id, @account_id, @date)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, dtdOrder);
            }
        }

        public void MergeDTDOrder(List<DTDOrder> dtdOrders)
        {
            string sql = "CALL itp4915m.MergeDTDOrder(@shipment_id, @account_id, @date)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, dtdOrders);
            }
        }

        public void MergeCustomerManagementLogs(CustomerManagementLogs customermangementlogs)
        {
            string sql = "CALL itp4915m.MergeCustomerManagementLogs(@staff_id, @customer_id, @content)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, customermangementlogs);
            }
        }
        public void MergeDeliveryMangementLogs(DeliveryMangementLogs deliverymanagementlogs)
        {
            string sql = "CALL itp4915m.MergeDeliveryMangementLogs(@staff_id, @shipment_id, @content)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, deliverymanagementlogs);
            }
        }

        public void MergeUserDeliveryManagementLogs(UserDeliveryManagementLogs deliverymanagementlogs)
        {
            string sql = "CALL itp4915m.MergeUserDeliveryManagementLogs( @shipment_id, @customer_id, @content)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, deliverymanagementlogs);
            }
        }

        public void MergeUserProfileManagementLogs(UserProfileManagementLogs deliverymanagementlogs)
        {
            string sql = "CALL itp4915m.MergeUserProfileManagementLogs(@customer_id, @content)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, deliverymanagementlogs);
            }
        }

        public void MergeImage(ImageSign imageSign)
        {
            string sql = "CALL itp4915m.MergeImage(@image_id, @image)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, imageSign);
            }
        }

        public List<ImageSign> GetImage(string image_id)
        {
            string sql = "SELECT * FROM image WHERE image_id = '" + image_id + "'";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<ImageSign>(sql).ToList();
            }
        }

        public List<MonthlyInvoice> GetAllInvoices()
        {
            string sql = "SELECT* FROM invoices; ";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<MonthlyInvoice>(sql).ToList();
            }
        }


        public Customer GetEmailByEmail(string mail)
        {
            string sql = "CALL itp4915m.GetEmailByEmail(@email)";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<Customer>(sql, new  {email=mail}).ToList()[0];
            }
        }
        public List<StatisticsReport> GetWeeklyNumIncome(DateTime sDate, DateTime eDate)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber, SUM(price) AS totalIncome FROM shipments WHERE createdDate BETWEEN \""+sDate.ToString("yyyy-MM-dd") + "\" AND \"" + eDate.ToString("yyyy-MM-dd") + "\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }

        public List<StatisticsReport> GetDailyNumIncome(DateTime date)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber, SUM(price) AS totalIncome FROM shipments WHERE createdDate LIKE \"" + date.ToString("yyyy-MM-dd")+"%\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }

        public List<StatisticsReport> GetWeeklyFromLocation(DateTime sDate, DateTime eDate, string shipment_id)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber FROM shipments WHERE createdDate BETWEEN \"" + sDate.ToString("yyyy-MM-dd") + "\" AND \"" + eDate.ToString("yyyy-MM-dd") + "\" AND shipment_id LIKE\"" + shipment_id + "%\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }
        public List<StatisticsReport> GetWeeklyToLocation(DateTime sDate, DateTime eDate, string recCountry)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber FROM shipments WHERE createdDate BETWEEN \"" + sDate.ToString("yyyy-MM-dd") + "\" AND \"" + eDate.ToString("yyyy-MM-dd") + "\" AND recCountry = \"" + recCountry + "\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }

        public List<StatisticsReport> GetDailyFromLocation(DateTime date, string shipment_id)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber FROM shipments WHERE createdDate LIKE \"" + date.ToString("yyyy-MM-dd") + "%\" AND shipment_id LIKE\"" + shipment_id + "%\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }
        public List<StatisticsReport> GetDailyToLocation(DateTime date, string recCountry)
        {
            string sql = "SELECT COUNT(shipment_id) AS totalNumber FROM shipments WHERE createdDate LIKE \"" + date.ToString("yyyy-MM-dd") + "%\" AND recCountry = \"" + recCountry + "\";";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<StatisticsReport>(sql).ToList();
            }
        }

        public void MergeRegularOrder(RegularOrder order)
        {
            string sql = "CALL itp4915m.MergeRegularOrder(@sender_id,@record_name,@csv);";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                connection.Execute(sql, order);
            }
        }
        public List<RegularOrder> GetRegularOrder(int sender_id)
        {
            string sql = "SELECT * FROM RegularOrders WHERE sender_id=@sender_id;";
            using (MySqlConnection connection = new MySqlConnection(Helper.GetConnectionString("itp4915m")))
            {
                return connection.Query<RegularOrder>(sql, new { sender_id = sender_id }).ToList();
            }
        }
    }
}
