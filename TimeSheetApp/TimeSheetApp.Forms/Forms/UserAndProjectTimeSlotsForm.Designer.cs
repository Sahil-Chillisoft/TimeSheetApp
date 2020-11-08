namespace TimeSheetApp.Forms
{
    partial class UserAndProjectTimeSlotsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxUsersTimeSheet = new System.Windows.Forms.GroupBox();
            this.groupBoxProjectTimeSheet = new System.Windows.Forms.GroupBox();
            this.GridViewProjects = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.groupBoxUsersTimeSheet.SuspendLayout();
            this.groupBoxProjectTimeSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProjects)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(214, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search For Hours For Users and Projects By Date";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.lblYear);
            this.groupBoxSearch.Controls.Add(this.lblMonth);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.monthComboBox);
            this.groupBoxSearch.Controls.Add(this.yearPicker);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(217, 44);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(458, 93);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Panel";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(168, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 16);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 28);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(49, 16);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(308, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(7, 47);
            this.monthComboBox.MaxDropDownItems = 12;
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(144, 26);
            this.monthComboBox.TabIndex = 2;
            // 
            // yearPicker
            // 
            this.yearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPicker.Location = new System.Drawing.Point(168, 49);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(108, 24);
            this.yearPicker.TabIndex = 1;
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.AllowUserToAddRows = false;
            this.GridViewUsers.AllowUserToDeleteRows = false;
            this.GridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Location = new System.Drawing.Point(6, 17);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.ReadOnly = true;
            this.GridViewUsers.Size = new System.Drawing.Size(387, 294);
            this.GridViewUsers.TabIndex = 3;
            // 
            // groupBoxUsersTimeSheet
            // 
            this.groupBoxUsersTimeSheet.Controls.Add(this.GridViewUsers);
            this.groupBoxUsersTimeSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsersTimeSheet.Location = new System.Drawing.Point(12, 161);
            this.groupBoxUsersTimeSheet.Name = "groupBoxUsersTimeSheet";
            this.groupBoxUsersTimeSheet.Size = new System.Drawing.Size(399, 320);
            this.groupBoxUsersTimeSheet.TabIndex = 4;
            this.groupBoxUsersTimeSheet.TabStop = false;
            this.groupBoxUsersTimeSheet.Text = "Total Hours Per User for Specified Month and Year";
            this.groupBoxUsersTimeSheet.Visible = false;
            // 
            // groupBoxProjectTimeSheet
            // 
            this.groupBoxProjectTimeSheet.Controls.Add(this.GridViewProjects);
            this.groupBoxProjectTimeSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProjectTimeSheet.Location = new System.Drawing.Point(459, 161);
            this.groupBoxProjectTimeSheet.Name = "groupBoxProjectTimeSheet";
            this.groupBoxProjectTimeSheet.Size = new System.Drawing.Size(409, 320);
            this.groupBoxProjectTimeSheet.TabIndex = 5;
            this.groupBoxProjectTimeSheet.TabStop = false;
            this.groupBoxProjectTimeSheet.Text = "Total Hours Per Project for Specified Month and Year";
            this.groupBoxProjectTimeSheet.Visible = false;
            // 
            // GridViewProjects
            // 
            this.GridViewProjects.AllowUserToAddRows = false;
            this.GridViewProjects.AllowUserToDeleteRows = false;
            this.GridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProjects.Location = new System.Drawing.Point(6, 17);
            this.GridViewProjects.Name = "GridViewProjects";
            this.GridViewProjects.ReadOnly = true;
            this.GridViewProjects.Size = new System.Drawing.Size(397, 294);
            this.GridViewProjects.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // UserAndProjectTimeSlotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 484);
            this.Controls.Add(this.groupBoxProjectTimeSheet);
            this.Controls.Add(this.groupBoxUsersTimeSheet);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserAndProjectTimeSlotsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users And Projects TimeSlots Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAndProjectTimeSlotsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserAndProjectTimeSlotsForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.groupBoxUsersTimeSheet.ResumeLayout(false);
            this.groupBoxProjectTimeSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProjects)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.GroupBox groupBoxUsersTimeSheet;
        private System.Windows.Forms.GroupBox groupBoxProjectTimeSheet;
        private System.Windows.Forms.DataGridView GridViewProjects;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DateTimePicker yearPicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}