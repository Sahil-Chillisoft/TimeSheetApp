using System;
using System.Windows.Forms;
using TimeSheetApp.Helpers.Data;

namespace TimeSheetApp.Forms
{
    public partial class UserAndProjectTimeSlotsForm : Form
    {
        private readonly ISqlHelper _sqlHelper;
        private readonly IDateManager _dateManager;

        public UserAndProjectTimeSlotsForm(ISqlHelper sqlHelper, IDateManager dateManager)
        {
            _sqlHelper = sqlHelper ?? throw new ArgumentNullException(nameof(sqlHelper));
            _dateManager = dateManager ?? throw new ArgumentNullException(nameof(dateManager));
            InitializeComponent();
        }

        private void UserAndProjectTimeSlotsForm_Load(object sender, EventArgs e)
        {
            SetCustomDateTimePickerFormat();
            monthComboBox.DataSource = _dateManager.GetMonthData();
        }

        private void SetCustomDateTimePickerFormat()
        {
            yearPicker.Format = _dateManager.DateFormatType();
            yearPicker.CustomFormat = _dateManager.DateFormat();
            yearPicker.ShowUpDown = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrids();
        }

        private void BindGrids()
        {
            GridViewUsers.DataSource = _sqlHelper.GetUsersTimeByMonthAndYear(monthComboBox.Text, yearPicker.Text);
            GridViewProjects.DataSource = _sqlHelper.GetProjectTimeByMonthAndYear(monthComboBox.Text, yearPicker.Text);
            groupBoxUsersTimeSheet.Visible = true;
            groupBoxProjectTimeSheet.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm(_sqlHelper, _dateManager);
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