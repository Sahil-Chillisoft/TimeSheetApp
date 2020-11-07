using System;
using System.Windows.Forms;
using TimeSheetApp.Data;

namespace TimeSheetApp
{
    public partial class UsersForm : Form
    {
        private readonly ISqlHelper _sqlHelper;
        private readonly IDateManager _dateManager;

        public UsersForm(ISqlHelper sqlHelper, IDateManager dateManager)
        {
            _sqlHelper = sqlHelper ?? throw new ArgumentNullException(nameof(sqlHelper));
            _dateManager = dateManager;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show(@"Please enter a search parameter.", @"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                BindGrid();
        }

        private void BindGrid()
        {
            GridViewUsers.DataSource = _sqlHelper.GetUsers(txtUsername.Text);
            groupBoxUsers.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm(_sqlHelper, _dateManager);
            dashboardForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm_FormClosing(sender, null);
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
