using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles
using eShift_Logistics_System.Properties; // Assuming this is still needed for resources

namespace eShift_Logistics_System.Forms.Customer
{
    partial class MyJobsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMyJobs = new System.Windows.Forms.DataGridView();
            this.grpJobTracker = new System.Windows.Forms.GroupBox();
            this.pnlTracker = new System.Windows.Forms.Panel();
            this.lblStatusCompleted = new System.Windows.Forms.Label();
            this.lblStatusOnJob = new System.Windows.Forms.Label();
            this.lblStatusAssigned = new System.Windows.Forms.Label();
            this.lblStatusAccepted = new System.Windows.Forms.Label();
            this.lblStatusPending = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.pnlTxtSearch = new System.Windows.Forms.Panel(); // New panel wrapper for txtSearch
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlCmbFilterStatus = new System.Windows.Forms.Panel(); // New panel wrapper for cmbFilterStatus
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).BeginInit();
            this.grpJobTracker.SuspendLayout();
            this.pnlTracker.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlTxtSearch.SuspendLayout();
            this.pnlCmbFilterStatus.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold); // Consistent title style
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))); // Darker grey for main title
            this.lblTitle.Location = new System.Drawing.Point(30, 30); // Adjusted padding
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 54); // Adjusted size
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Jobs";
            //
            // dgvMyJobs
            //
            this.dgvMyJobs.AllowUserToAddRows = false;
            this.dgvMyJobs.AllowUserToDeleteRows = false;
            this.dgvMyJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMyJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyJobs.BorderStyle = System.Windows.Forms.BorderStyle.None; // No border
            this.dgvMyJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None; // No cell borders for cleaner look
            this.dgvMyJobs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Light grey header background
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold); // Semibold header font
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))); // Darker text
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Keep header background on selection
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))); // Keep header text color on selection
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1; // Apply new header style
            this.dgvMyJobs.ColumnHeadersHeight = 40; // Taller header
            this.dgvMyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Prevent resizing
            this.dgvMyJobs.EnableHeadersVisualStyles = false;
            this.dgvMyJobs.Location = new System.Drawing.Point(30, 150); // Adjusted location for filters
            this.dgvMyJobs.MultiSelect = false;
            this.dgvMyJobs.Name = "dgvMyJobs";
            this.dgvMyJobs.ReadOnly = true;

            // Default cell style for rows
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255))))); // Lighter blue for selection
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvMyJobs.DefaultCellStyle = dataGridViewCellStyle2;

            // Alternating row style
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))); // Very light grey for alternating rows
            this.dgvMyJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;

            this.dgvMyJobs.RowHeadersVisible = false;
            this.dgvMyJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyJobs.Size = new System.Drawing.Size(680, 200); // Adjusted height
            this.dgvMyJobs.TabIndex = 1;
            //
            // grpJobTracker
            //
            this.grpJobTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpJobTracker.BackColor = System.Drawing.Color.White; // Set background to white
            this.grpJobTracker.Controls.Add(this.pnlTracker);
            this.grpJobTracker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold); // Semibold for group box titles
            this.grpJobTracker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))); // Darker text
            this.grpJobTracker.Location = new System.Drawing.Point(30, 370); // Adjusted top margin
            this.grpJobTracker.Name = "grpJobTracker";
            this.grpJobTracker.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15); // Increased padding
            this.grpJobTracker.Size = new System.Drawing.Size(680, 100); // Adjusted height
            this.grpJobTracker.TabIndex = 2;
            this.grpJobTracker.TabStop = false;
            this.grpJobTracker.Text = "Job Status Tracker";
            //
            // pnlTracker
            //
            this.pnlTracker.Controls.Add(this.lblStatusCompleted);
            this.pnlTracker.Controls.Add(this.lblStatusOnJob);
            this.pnlTracker.Controls.Add(this.lblStatusAssigned);
            this.pnlTracker.Controls.Add(this.lblStatusAccepted);
            this.pnlTracker.Controls.Add(this.lblStatusPending);
            this.pnlTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTracker.Location = new System.Drawing.Point(15, 38); // Adjusted padding
            this.pnlTracker.Name = "pnlTracker";
            this.pnlTracker.Size = new System.Drawing.Size(650, 47); // Adjusted size
            this.pnlTracker.TabIndex = 0;
            this.pnlTracker.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTracker_Paint); // Custom paint for tracker line
            //
            // lblStatusCompleted
            //
            this.lblStatusCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusCompleted.AutoSize = true;
            this.lblStatusCompleted.Font = new System.Drawing.Font("Segoe UI", 8.5F); // Consistent font
            this.lblStatusCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatusCompleted.Location = new System.Drawing.Point(540, 28); // Adjusted position for visual line
            this.lblStatusCompleted.Name = "lblStatusCompleted";
            this.lblStatusCompleted.Size = new System.Drawing.Size(68, 20); // Adjusted size
            this.lblStatusCompleted.TabIndex = 4;
            this.lblStatusCompleted.Text = "Completed";
            this.lblStatusCompleted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblStatusOnJob
            //
            this.lblStatusOnJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusOnJob.AutoSize = true;
            this.lblStatusOnJob.Font = new System.Drawing.Font("Segoe UI", 8.5F); // Consistent font
            this.lblStatusOnJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatusOnJob.Location = new System.Drawing.Point(410, 28); // Adjusted position
            this.lblStatusOnJob.Name = "lblStatusOnJob";
            this.lblStatusOnJob.Size = new System.Drawing.Size(44, 20); // Adjusted size
            this.lblStatusOnJob.TabIndex = 3;
            this.lblStatusOnJob.Text = "On Job";
            this.lblStatusOnJob.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblStatusAssigned
            //
            this.lblStatusAssigned.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusAssigned.AutoSize = true;
            this.lblStatusAssigned.Font = new System.Drawing.Font("Segoe UI", 8.5F); // Consistent font
            this.lblStatusAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatusAssigned.Location = new System.Drawing.Point(280, 28); // Adjusted position
            this.lblStatusAssigned.Name = "lblStatusAssigned";
            this.lblStatusAssigned.Size = new System.Drawing.Size(55, 20); // Adjusted size
            this.lblStatusAssigned.TabIndex = 2;
            this.lblStatusAssigned.Text = "Assigned";
            this.lblStatusAssigned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblStatusAccepted
            //
            this.lblStatusAccepted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusAccepted.AutoSize = true;
            this.lblStatusAccepted.Font = new System.Drawing.Font("Segoe UI", 8.5F); // Consistent font
            this.lblStatusAccepted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatusAccepted.Location = new System.Drawing.Point(150, 28); // Adjusted position
            this.lblStatusAccepted.Name = "lblStatusAccepted";
            this.lblStatusAccepted.Size = new System.Drawing.Size(58, 20); // Adjusted size
            this.lblStatusAccepted.TabIndex = 1;
            this.lblStatusAccepted.Text = "Accepted";
            this.lblStatusAccepted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblStatusPending
            //
            this.lblStatusPending.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusPending.AutoSize = true;
            this.lblStatusPending.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font
            this.lblStatusPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatusPending.Location = new System.Drawing.Point(20, 28); // Adjusted position
            this.lblStatusPending.Name = "lblStatusPending";
            this.lblStatusPending.Size = new System.Drawing.Size(50, 20); // Adjusted size
            this.lblStatusPending.TabIndex = 0;
            this.lblStatusPending.Text = "Pending";
            this.lblStatusPending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // pnlFilters
            //
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilters.BackColor = System.Drawing.Color.White; // Set background to white
            this.pnlFilters.Controls.Add(this.btnClearFilters);
            this.pnlFilters.Controls.Add(this.pnlTxtSearch); // Use panel wrapper
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Controls.Add(this.pnlCmbFilterStatus); // Use panel wrapper
            this.pnlFilters.Controls.Add(this.lblFilterStatus);
            this.pnlFilters.Location = new System.Drawing.Point(30, 90); // Adjusted location for better spacing
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10); // Increased padding
            this.pnlFilters.Size = new System.Drawing.Size(680, 50); // Adjusted height
            this.pnlFilters.TabIndex = 3;
            //
            // btnClearFilters
            //
            this.btnClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))); // Modern accent red
            this.btnClearFilters.FlatAppearance.BorderSize = 0;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); // Consistent button font
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(565, 8); // Adjusted location
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(100, 34); // Adjusted size
            this.btnClearFilters.TabIndex = 4;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            //
            // pnlTxtSearch
            //
            this.pnlTxtSearch.BackColor = System.Drawing.Color.White;
            this.pnlTxtSearch.Controls.Add(this.txtSearch);
            this.pnlTxtSearch.Location = new System.Drawing.Point(300, 10); // Adjusted position
            this.pnlTxtSearch.Name = "pnlTxtSearch";
            this.pnlTxtSearch.Size = new System.Drawing.Size(200, 30); // Adjusted size
            this.pnlTxtSearch.TabIndex = 3;
            //
            // txtSearch
            //
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None; // No border
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F); // Consistent font
            this.txtSearch.Location = new System.Drawing.Point(5, 5); // Adjusted internal padding
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 23); // Adjusted size
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F); // Consistent label font
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSearch.Location = new System.Drawing.Point(240, 18); // Adjusted position
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 20); // Adjusted size
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            //
            // pnlCmbFilterStatus
            //
            this.pnlCmbFilterStatus.BackColor = System.Drawing.Color.White;
            this.pnlCmbFilterStatus.Controls.Add(this.cmbFilterStatus);
            this.pnlCmbFilterStatus.Location = new System.Drawing.Point(70, 10); // Adjusted position
            this.pnlCmbFilterStatus.Name = "pnlCmbFilterStatus";
            this.pnlCmbFilterStatus.Size = new System.Drawing.Size(150, 30); // Adjusted size
            this.pnlCmbFilterStatus.TabIndex = 1;
            //
            // cmbFilterStatus
            //
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F); // Consistent font
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Location = new System.Drawing.Point(5, 4); // Adjusted internal padding
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(140, 28); // Adjusted size
            this.cmbFilterStatus.TabIndex = 1;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            //
            // lblFilterStatus
            //
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F); // Consistent label font
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 18); // Adjusted position
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(52, 20); // Adjusted size
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "Status:";
            //
            // MyJobsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F); // Consistent with other forms
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(255))))); // Consistent light background
            this.ClientSize = new System.Drawing.Size(740, 500);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.grpJobTracker);
            this.Controls.Add(this.dgvMyJobs);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Consistent with dashboard child forms
            this.Name = "MyJobsForm";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 20); // Consistent padding
            this.Text = "MyJobsForm";
            this.Load += new System.EventHandler(this.MyJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).EndInit();
            this.grpJobTracker.ResumeLayout(false);
            this.pnlTracker.ResumeLayout(false);
            this.pnlTracker.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlTxtSearch.ResumeLayout(false);
            this.pnlTxtSearch.PerformLayout();
            this.pnlCmbFilterStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMyJobs;
        private System.Windows.Forms.GroupBox grpJobTracker;
        private System.Windows.Forms.Panel pnlTracker;
        private System.Windows.Forms.Label lblStatusPending;
        private System.Windows.Forms.Label lblStatusAccepted;
        private System.Windows.Forms.Label lblStatusAssigned;
        private System.Windows.Forms.Label lblStatusOnJob;
        private System.Windows.Forms.Label lblStatusCompleted;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Panel pnlTxtSearch; // Added to designer.cs
        private System.Windows.Forms.Panel pnlCmbFilterStatus; // Added to designer.cs
    }
}
