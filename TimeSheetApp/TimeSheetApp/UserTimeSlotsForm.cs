using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetApp.Data;

namespace TimeSheetApp
{
    public partial class UserTimeSlotsForm : Form
    {
        public UserTimeSlotsForm()
        {
            InitializeComponent();
        }

        private void UserTimeSlotsForm_Load(object sender, EventArgs e)
        {
            monthComboBox.DataSource = DateManager.LoadMonthData();
            groupBoxUserTimeSlots.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show(@"Please enter a username.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                BindGrid();
        }

        private void BindGrid()
        {
            GridViewUserTimeSlots.DataSource = SqlHelper.GetTimeSlotsByUsernameAndMonth(txtUsername.Text, monthComboBox.Text);
            groupBoxUserTimeSlots.Visible = true;
        }

        private void UserTimeSlotsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
