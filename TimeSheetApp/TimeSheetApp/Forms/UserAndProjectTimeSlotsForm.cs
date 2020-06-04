using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetApp.Data;

namespace TimeSheetApp
{
    public partial class UserAndProjectTimeSlotsForm : Form
    {
        public UserAndProjectTimeSlotsForm()
        {
            InitializeComponent();
        }

        private void UserAndProjectTimeSlotsForm_Load(object sender, EventArgs e)
        {
            SetCustomDateTimePickerFormat();
            monthComboBox.DataSource = DateManager.LoadMonthData();
        }

        private void SetCustomDateTimePickerFormat()
        {
            yearPicker.Format = DateManager.DateFormatType;
            yearPicker.CustomFormat = DateManager.DateFormat;
            yearPicker.ShowUpDown = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrids();
        }

        private void BindGrids()
        {
            GridViewUsers.DataSource = SqlHelper.GetUsersTimeByMonthAndYear(monthComboBox.Text, yearPicker.Text);
            GridViewProjects.DataSource = SqlHelper.GetProjectTimeByMonthAndYear(monthComboBox.Text, yearPicker.Text);
            groupBoxUsersTimeSheet.Visible = true;
            groupBoxProjectTimeSheet.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserAndProjectTimeSlotsForm_FormClosing(sender, null);
        }

        private void UserAndProjectTimeSlotsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}