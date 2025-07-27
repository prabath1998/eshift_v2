using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles
using eShift_Logistics_System.Properties;

namespace eShift_Logistics_System.Forms.Admin
{
    partial class CustomersForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            cboFilterStatus = new ComboBox();
            txtSearch = new TextBox();
            statusStrip = new StatusStrip();
            lblTotalCustomers = new ToolStripStatusLabel();
            lblActiveCustomers = new ToolStripStatusLabel();
            lblInactiveCustomers = new ToolStripStatusLabel();
            tabControlDetails = new TabControl();
            tabPageJobHistory = new TabPage();
            dgvJobHistory = new DataGridView();
            tabPageNotes = new TabPage();
            txtNotes = new TextBox();
            dgvCustomers = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            statusStrip.SuspendLayout();
            tabControlDetails.SuspendLayout();
            tabPageJobHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobHistory).BeginInit();
            tabPageNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(20, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(960, 50);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold); // Larger, more prominent
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51); // Darker grey for main title
            lblTitle.Location = new Point(-7, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(405, 54); // Adjusted size
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Management";
            //
            // pnlSearch
            //
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(btnClear);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(cboFilterStatus);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(20, 70);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(10); // Added padding for internal elements
            pnlSearch.Size = new Size(960, 70); // Increased height for better spacing
            pnlSearch.TabIndex = 1;
            //
            // btnClear
            //
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(220, 53, 69); // Modern accent red
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Slightly larger font
            btnClear.ForeColor = Color.White; // White text for contrast
            btnClear.Location = new Point(865, 15); // Adjusted location
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 40); // Larger buttons
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            //
            // btnSearch
            //
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(220, 53, 69); // Modern accent red
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Slightly larger font
            btnSearch.ForeColor = Color.White; // White text for contrast
            btnSearch.Location = new Point(774, 15); // Adjusted location
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 40); // Larger buttons
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            //
            // cboFilterStatus
            //
            cboFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Font = new Font("Segoe UI", 11F); // Slightly smaller font for better fit
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(568, 18); // Adjusted location
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(200, 33); // Adjusted size
            cboFilterStatus.TabIndex = 1;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None; // No border, parent panel draws it
            txtSearch.Font = new Font("Segoe UI", 11F); // Larger font for input
            txtSearch.Location = new Point(20, 22); // Adjusted padding
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(538, 25); // Adjusted size
            txtSearch.TabIndex = 0;
            //
            // statusStrip
            //
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTotalCustomers, lblActiveCustomers, lblInactiveCustomers });
            statusStrip.Location = new Point(20, 508);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(960, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            //
            // lblTotalCustomers
            //
            lblTotalCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold); // Semibold for status
            lblTotalCustomers.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(130, 20);
            lblTotalCustomers.Text = "Total Customers: 0";
            //
            // lblActiveCustomers
            //
            lblActiveCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblActiveCustomers.ForeColor = Color.FromArgb(51, 51, 51);
            lblActiveCustomers.Name = "lblActiveCustomers";
            lblActiveCustomers.Size = new Size(65, 20);
            lblActiveCustomers.Text = "Active: 0";
            //
            // lblInactiveCustomers
            //
            lblInactiveCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblInactiveCustomers.ForeColor = Color.FromArgb(51, 51, 51);
            lblInactiveCustomers.Name = "lblInactiveCustomers";
            lblInactiveCustomers.Size = new Size(76, 20);
            lblInactiveCustomers.Text = "Inactive: 0";
            //
            // tabControlDetails
            //
            tabControlDetails.Controls.Add(tabPageJobHistory);
            tabControlDetails.Controls.Add(tabPageNotes);
            tabControlDetails.Dock = DockStyle.Bottom;
            tabControlDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for tabs
            tabControlDetails.Location = new Point(20, 328);
            tabControlDetails.Name = "tabControlDetails";
            tabControlDetails.SelectedIndex = 0;
            tabControlDetails.Size = new Size(960, 180);
            tabControlDetails.TabIndex = 4;
            //
            // tabPageJobHistory
            //
            tabPageJobHistory.Controls.Add(dgvJobHistory);
            tabPageJobHistory.Location = new Point(4, 29); // Adjusted for new tab font size
            tabPageJobHistory.Name = "tabPageJobHistory";
            tabPageJobHistory.Padding = new Padding(10); // Increased padding
            tabPageJobHistory.Size = new Size(952, 147); // Adjusted size
            tabPageJobHistory.TabIndex = 0;
            tabPageJobHistory.Text = "Job History";
            tabPageJobHistory.UseVisualStyleBackColor = true;
            //
            // dgvJobHistory
            //
            dgvJobHistory.AllowUserToAddRows = false;
            dgvJobHistory.AllowUserToDeleteRows = false;
            dgvJobHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobHistory.BackgroundColor = Color.White;
            dgvJobHistory.BorderStyle = BorderStyle.None; // No border
            dgvJobHistory.CellBorderStyle = DataGridViewCellBorderStyle.None; // No cell borders
            dgvJobHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240); // Light grey header background
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold); // Semibold header font
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(240, 240, 240); // Keep header background on selection
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 51, 51); // Keep header text color on selection
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobHistory.ColumnHeadersHeight = 40; // Taller header
            dgvJobHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Prevent resizing
            dgvJobHistory.Dock = DockStyle.Fill;
            dgvJobHistory.EnableHeadersVisualStyles = false;
            dgvJobHistory.Location = new Point(10, 10); // Adjusted padding
            dgvJobHistory.Name = "dgvJobHistory";
            dgvJobHistory.ReadOnly = true;
            dgvJobHistory.RowHeadersVisible = false;

            // Default cell style for rows
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 240, 255); // Lighter blue for selection
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvJobHistory.DefaultCellStyle = dataGridViewCellStyle2;

            // Alternating row style
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 250, 250); // Very light grey for alternating rows
            dgvJobHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;

            dgvJobHistory.Size = new Size(932, 127); // Adjusted size
            dgvJobHistory.TabIndex = 0;
            //
            // tabPageNotes
            //
            tabPageNotes.Controls.Add(txtNotes);
            tabPageNotes.Location = new Point(4, 29); // Adjusted for new tab font size
            tabPageNotes.Name = "tabPageNotes";
            tabPageNotes.Padding = new Padding(10); // Increased padding
            tabPageNotes.Size = new Size(952, 147); // Adjusted size
            tabPageNotes.TabIndex = 1;
            tabPageNotes.Text = "Notes";
            tabPageNotes.UseVisualStyleBackColor = true;
            //
            // txtNotes
            //
            txtNotes.BackColor = Color.White;
            txtNotes.BorderStyle = BorderStyle.None; // No border, parent tab page handles it
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = new Font("Segoe UI", 9.5F); // Consistent font
            txtNotes.Location = new Point(10, 10); // Adjusted padding
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(932, 127); // Adjusted size
            txtNotes.TabIndex = 0;
            //
            // dgvCustomers
            //
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None; // No border
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None; // No cell borders for a cleaner look
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 240, 240); // Light grey header background
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold); // Semibold header font
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51); // Darker text
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(240, 240, 240); // Keep header background on selection
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(51, 51, 51); // Keep header text color on selection
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.ColumnHeadersHeight = 40; // Taller header
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Prevent resizing
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.Gainsboro; // Retain grid color for subtle lines if needed, but CellBorderStyle.None removes them
            dgvCustomers.Location = new Point(20, 140); // Adjusted to account for new pnlSearch height
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;

            // Default cell style for rows
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 240, 255); // Lighter blue for selection
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle5;

            // Alternating row style
            dataGridViewCellStyle6.BackColor = Color.FromArgb(250, 250, 250); // Very light grey for alternating rows
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;

            dgvCustomers.RowTemplate.Height = 35;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(960, 188); // Adjusted size
            dgvCustomers.TabIndex = 5;
            //
            // CustomersForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F); // Changed to 8F, 20F for consistency with other forms
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255); // Consistent light background
            ClientSize = new Size(1000, 550);
            Controls.Add(dgvCustomers);
            Controls.Add(tabControlDetails);
            Controls.Add(statusStrip);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None; // Consistent with dashboard child forms
            Name = "CustomersForm";
            Padding = new Padding(20); // Consistent padding
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tabControlDetails.ResumeLayout(false);
            tabPageJobHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobHistory).EndInit();
            tabPageNotes.ResumeLayout(false);
            tabPageNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalCustomers;
        private System.Windows.Forms.ToolStripStatusLabel lblActiveCustomers;
        private System.Windows.Forms.ToolStripStatusLabel lblInactiveCustomers;
        private System.Windows.Forms.TabControl tabControlDetails;
        private System.Windows.Forms.TabPage tabPageJobHistory;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.DataGridView dgvJobHistory;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}
