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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
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
            GridViewUsers.DataSource = SqlHelper.GetUsers(txtUsername.Text);
            groupBoxUsers.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm();
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
