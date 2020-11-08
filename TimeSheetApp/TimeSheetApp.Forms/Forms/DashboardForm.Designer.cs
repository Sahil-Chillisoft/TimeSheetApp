namespace TimeSheetApp.Forms
{
    partial class DashboardForm
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
            this.btnViewTotalHoursByPersonAndProject = new System.Windows.Forms.Button();
            this.btnSearchForUsers = new System.Windows.Forms.Button();
            this.btnViewTimeSlotsByUserAndMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(248, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Timesheet App Dashboard";
            // 
            // btnViewTotalHoursByPersonAndProject
            // 
            this.btnViewTotalHoursByPersonAndProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTotalHoursByPersonAndProject.Location = new System.Drawing.Point(253, 93);
            this.btnViewTotalHoursByPersonAndProject.Name = "btnViewTotalHoursByPersonAndProject";
            this.btnViewTotalHoursByPersonAndProject.Size = new System.Drawing.Size(326, 67);
            this.btnViewTotalHoursByPersonAndProject.TabIndex = 0;
            this.btnViewTotalHoursByPersonAndProject.Text = "View Total Hours by Person and Project";
            this.btnViewTotalHoursByPersonAndProject.UseVisualStyleBackColor = true;
            this.btnViewTotalHoursByPersonAndProject.Click += new System.EventHandler(this.btnViewTotalHoursByPersonAndProject_Click);
            // 
            // btnSearchForUsers
            // 
            this.btnSearchForUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForUsers.Location = new System.Drawing.Point(253, 222);
            this.btnSearchForUsers.Name = "btnSearchForUsers";
            this.btnSearchForUsers.Size = new System.Drawing.Size(326, 67);
            this.btnSearchForUsers.TabIndex = 1;
            this.btnSearchForUsers.Text = "Search For Users";
            this.btnSearchForUsers.UseVisualStyleBackColor = true;
            this.btnSearchForUsers.Click += new System.EventHandler(this.btnSearchForUsers_Click);
            // 
            // btnViewTimeSlotsByUserAndMonth
            // 
            this.btnViewTimeSlotsByUserAndMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTimeSlotsByUserAndMonth.Location = new System.Drawing.Point(253, 358);
            this.btnViewTimeSlotsByUserAndMonth.Name = "btnViewTimeSlotsByUserAndMonth";
            this.btnViewTimeSlotsByUserAndMonth.Size = new System.Drawing.Size(326, 67);
            this.btnViewTimeSlotsByUserAndMonth.TabIndex = 2;
            this.btnViewTimeSlotsByUserAndMonth.Text = "View Timeslots by User and Month";
            this.btnViewTimeSlotsByUserAndMonth.UseVisualStyleBackColor = true;
            this.btnViewTimeSlotsByUserAndMonth.Click += new System.EventHandler(this.btnViewTimeSlotsByUserAndMonth_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewTimeSlotsByUserAndMonth);
            this.Controls.Add(this.btnViewTotalHoursByPersonAndProject);
            this.Controls.Add(this.btnSearchForUsers);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewTotalHoursByPersonAndProject;
        private System.Windows.Forms.Button btnSearchForUsers;
        private System.Windows.Forms.Button btnViewTimeSlotsByUserAndMonth;
    }
}

