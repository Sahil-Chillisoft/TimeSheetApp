using System;
using System.Windows.Forms;
using TimeSheetApp.Helpers.Data;

namespace TimeSheetApp.Forms
{
    public partial class UserTimeSlotsForm : Form
    {
        private readonly ISqlHelper _sqlHelper;
        private readonly IDateManager _dateManager;

        public UserTimeSlotsForm(ISqlHelper sqlHelper, IDateManager dateManager)
        {
            _sqlHelper = sqlHelper ?? throw new ArgumentNullException(nameof(sqlHelper));
            _dateManager = dateManager ?? throw new ArgumentNullException(nameof(dateManager));
            InitializeComponent();
        }

        private void UserTimeSlotsForm_Load(object sender, EventArgs e)
        {
            monthComboBox.DataSource = _dateManager.GetMonthData();
            groupBoxUserTimeSlots.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show(@"Please enter a username.", @"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                BindGrid();
        }

        private void BindGrid()
        {
            GridViewUserTimeSlots.DataSource = _sqlHelper.GetTimeSlotsByUsernameAndMonth(txtUsername.Text, monthComboBox.Text);
            groupBoxUserTimeSlots.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm(_sqlHelper, _dateManager);
            dashboardForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTimeSlotsForm_FormClosing(sender, null);
        }

        private void UserTimeSlotsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
