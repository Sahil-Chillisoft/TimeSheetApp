using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheetApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnViewTotalHoursByPersonAndProject_Click(object sender, EventArgs e)
        {
            var userAndProjectTimeSlotsForm = new UserAndProjectTimeSlotsForm();
            userAndProjectTimeSlotsForm.Show();
            this.Hide();
        }

        private void btnSearchForUsers_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void btnViewTimeSlotsByUserAndMonth_Click(object sender, EventArgs e)
        {
            var userTimeSlotsForm = new UserTimeSlotsForm();
            userTimeSlotsForm.Show();
            this.Hide();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}