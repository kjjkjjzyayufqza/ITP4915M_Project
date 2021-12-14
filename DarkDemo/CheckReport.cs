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
    public partial class CheckReport : Form
    {
        private Staff staff;
        private DataAccess db = new DataAccess();
        public CheckReport(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void CheckReport_Load(object sender, EventArgs e)
        {
            dtpSDate.Enabled = false;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboReportType.Text.ToString() == "Daily")
                {
                    DailyReportDetail dReport = new DailyReportDetail(staff, dtpSDate.Value);
                    dReport.ShowDialog();
                }
                else if (cboReportType.Text.ToString() == "Weekly")
                {
                    WeeklyReportDetail wReport = new WeeklyReportDetail(staff, dtpSDate.Value, dtpEDate.Value);
                    wReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a report");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a report");
            }
        }


        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cboReportType.Text.ToString() == "Daily")
            {
                
                dtpEDate.Text = dtpSDate.Text;
            }
            else
            {
                while ((int)dtpSDate.Value.DayOfWeek != 0 ) 
                {
                    dtpSDate.Value = dtpSDate.Value.AddDays(-1);
                }
                dtpEDate.Text = dtpSDate.Value.AddDays(6).ToString();
            }
        }

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpSDate.Enabled = true;
            dtpSDate.Value = DateTime.Today;
            if (cboReportType.Text.ToString() == "Daily")
            {
                
                dtpEDate.Text = dtpSDate.Text;
            }
            else
            {
                while ((int)dtpSDate.Value.DayOfWeek != 0)
                {
                    dtpSDate.Value = dtpSDate.Value.AddDays(-1);
                }
                dtpEDate.Text = dtpSDate.Value.AddDays(6).ToString();
            }
        }
    }
}
