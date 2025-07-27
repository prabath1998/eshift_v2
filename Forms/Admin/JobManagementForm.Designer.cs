using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles
using eShift_Logistics_System.Properties;

namespace eShift_Logistics_System.Forms.Admin
{
    partial class JobManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            btnFilter = new Button();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label3 = new Label();
            cboStatusFilter = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            dgvJobs = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(23, 27);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1097, 60); // Adjusted height
            pnlHeader.TabIndex = 1;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold); // Larger, more prominent
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51); // Darker grey for main title
            lblTitle.Location = new Point(-8, 3); // Adjusted location
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(324, 54); // Adjusted size
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Job Management";
            //
            // pnlSearch
            //
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(btnFilter);
            pnlSearch.Controls.Add(label4);
            pnlSearch.Controls.Add(dtpEndDate);
            pnlSearch.Controls.Add(dtpStartDate);
            pnlSearch.Controls.Add(label3);
            pnlSearch.Controls.Add(cboStatusFilter);
            pnlSearch.Controls.Add(label1);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(label2);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(23, 87); // Adjusted to account for new pnlHeader height
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(15, 10, 15, 10); // Increased padding for internal elements
            pnlSearch.Size = new Size(1097, 70); // Increased height for better spacing
            pnlSearch.TabIndex = 2;
            //
            // btnFilter
            //
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilter.BackColor = Color.FromArgb(220, 53, 69); // Modern accent red
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Slightly larger font
            btnFilter.ForeColor = Color.White; // White text for contrast
            btnFilter.Location = new Point(985, 15); // Adjusted location
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(97, 40); // Larger button
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            //
            // label4
            //
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Consistent font
            label4.ForeColor = Color.FromArgb(85, 85, 85); // Softer grey
            label4.Location = new Point(800, 23); // Adjusted location
            label4.Name = "label4";
            label4.Size = new Size(16, 23); // Adjusted size
            label4.TabIndex = 7;
            label4.Text = "-";
            //
            // dtpEndDate
            //
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpEndDate.Font = new Font("Segoe UI", 10F); // Consistent font
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(818, 19); // Adjusted location
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(114, 30); // Adjusted size
            dtpEndDate.TabIndex = 6;
            //
            // dtpStartDate
            //
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpStartDate.Font = new Font("Segoe UI", 10F); // Consistent font
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(683, 19); // Adjusted location
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(114, 30); // Adjusted size
            dtpStartDate.TabIndex = 5;
            //
            // label3
            //
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for emphasis
            label3.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            label3.Location = new Point(625, 23); // Adjusted location
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            //
            // cboStatusFilter
            //
            cboStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusFilter.Font = new Font("Segoe UI", 10F); // Consistent font
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Location = new Point(449, 19); // Adjusted location
            cboStatusFilter.Margin = new Padding(3, 4, 3, 4);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(159, 31); // Adjusted size
            cboStatusFilter.TabIndex = 3;
            //
            // label1
            //
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for emphasis
            label1.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            label1.Location = new Point(388, 23); // Adjusted location
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.None; // No border, parent panel handles it
            txtSearch.Font = new Font("Segoe UI", 11F); // Larger font for input
            txtSearch.Location = new Point(88, 22); // Adjusted padding
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(285, 25); // Adjusted size
            txtSearch.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for emphasis
            label2.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            label2.Location = new Point(15, 23); // Adjusted location
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 0;
            label2.Text = "Search:";
            //
            // dgvJobs
            //
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToDeleteRows = false;
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.BorderStyle = BorderStyle.None; // No border
            dgvJobs.CellBorderStyle = DataGridViewCellBorderStyle.None; // No cell borders for a cleaner look
            dgvJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240); // Light grey header background
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold); // Semibold header font
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(240, 240, 240); // Keep header background on selection
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 51, 51); // Keep header text color on selection
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobs.ColumnHeadersHeight = 40; // Taller header
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Prevent resizing
            dgvJobs.Dock = DockStyle.Fill;
            dgvJobs.EnableHeadersVisualStyles = false;
            dgvJobs.Location = new Point(23, 161); // Adjusted location
            dgvJobs.Margin = new Padding(3, 4, 3, 4);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;

            // Default cell style for rows
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 240, 255); // Lighter blue for selection
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvJobs.DefaultCellStyle = dataGridViewCellStyle2;

            // Alternating row style
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 250, 250); // Very light grey for alternating rows
            dgvJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;

            dgvJobs.RowHeadersVisible = false;
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(1097, 545);
            dgvJobs.TabIndex = 3;
            //
            // JobManagementForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F); // Consistent with other forms
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255); // Consistent light background
            ClientSize = new Size(1143, 733);
            Controls.Add(dgvJobs);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None; // Consistent with dashboard child forms
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobManagementForm";
            Padding = new Padding(23, 27, 23, 27); // Consistent padding
            Text = "Job Management";
            Load += JobManagementForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvJobs;
    }

}
