using System;
using System.Windows.Forms;
using TimeSheetApp.Data;

namespace TimeSheetApp
{
    public partial class DashboardForm : Form
    {
        private readonly ISqlHelper _sqlHelper;
        private readonly IDateManager _dateManager;

        public DashboardForm(ISqlHelper sqlHelper, IDateManager dateManager)
        {
            _sqlHelper = sqlHelper;
            _dateManager = dateManager;
            InitializeComponent();
        }

        private void btnViewTotalHoursByPersonAndProject_Click(object sender, EventArgs e)
        {
            var userAndProjectTimeSlotsForm = new UserAndProjectTimeSlotsForm(_sqlHelper, _dateManager);
            userAndProjectTimeSlotsForm.Show();
            this.Hide();
        }

        private void btnSearchForUsers_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm(_sqlHelper, _dateManager);
            usersForm.Show();
            this.Hide();
        }

        private void btnViewTimeSlotsByUserAndMonth_Click(object sender, EventArgs e)
        {
            var userTimeSlotsForm = new UserTimeSlotsForm(_sqlHelper, _dateManager);
            userTimeSlotsForm.Show();
            this.Hide();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}