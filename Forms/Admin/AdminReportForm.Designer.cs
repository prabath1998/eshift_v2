namespace eShift_Logistics_System.Forms.Admin
{
    partial class AdminReportForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlReportControls = new Panel();
            grpReportFilters = new GroupBox();
            cmbTransportUnit = new ComboBox();
            lblTransportUnit = new Label();
            cmbDriver = new ComboBox();
            lblDriver = new Label();
            btnGenerateReport = new Button();
            btnExport = new Button();
            cmbUser = new ComboBox();
            lblUser = new Label();
            cmbJobStatus = new ComboBox();
            lblJobStatus = new Label();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            cmbReportType = new ComboBox();
            lblReportType = new Label();
            dgvReportResults = new DataGridView();
            pnlReportControls.SuspendLayout();
            grpReportFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResults).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            // 
            // pnlReportControls
            // 
            pnlReportControls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportControls.Controls.Add(grpReportFilters);
            pnlReportControls.Location = new Point(30, 75);
            pnlReportControls.Name = "pnlReportControls";
            pnlReportControls.Size = new Size(740, 240);
            pnlReportControls.TabIndex = 1;
            // 
            // grpReportFilters
            // 
            grpReportFilters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpReportFilters.Controls.Add(cmbTransportUnit);
            grpReportFilters.Controls.Add(lblTransportUnit);
            grpReportFilters.Controls.Add(cmbDriver);
            grpReportFilters.Controls.Add(lblDriver);
            grpReportFilters.Controls.Add(btnGenerateReport);
            grpReportFilters.Controls.Add(btnExport);
            grpReportFilters.Controls.Add(cmbUser);
            grpReportFilters.Controls.Add(lblUser);
            grpReportFilters.Controls.Add(cmbJobStatus);
            grpReportFilters.Controls.Add(lblJobStatus);
            grpReportFilters.Controls.Add(dtpEndDate);
            grpReportFilters.Controls.Add(lblEndDate);
            grpReportFilters.Controls.Add(dtpStartDate);
            grpReportFilters.Controls.Add(lblStartDate);
            grpReportFilters.Controls.Add(cmbReportType);
            grpReportFilters.Controls.Add(lblReportType);
            grpReportFilters.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpReportFilters.Location = new Point(0, 0);
            grpReportFilters.Name = "grpReportFilters";
            grpReportFilters.Padding = new Padding(10);
            grpReportFilters.Size = new Size(740, 240);
            grpReportFilters.TabIndex = 0;
            grpReportFilters.TabStop = false;
            grpReportFilters.Text = "Report Options";
            // 
            // cmbTransportUnit
            // 
            cmbTransportUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransportUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTransportUnit.FormattingEnabled = true;
            cmbTransportUnit.Location = new Point(470, 110);
            cmbTransportUnit.Name = "cmbTransportUnit";
            cmbTransportUnit.Size = new Size(250, 28);
            cmbTransportUnit.TabIndex = 15;
            cmbTransportUnit.Visible = false;
            // 
            // lblTransportUnit
            // 
            lblTransportUnit.AutoSize = true;
            lblTransportUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransportUnit.Location = new Point(380, 113);
            lblTransportUnit.Name = "lblTransportUnit";
            lblTransportUnit.Size = new Size(105, 20);
            lblTransportUnit.TabIndex = 14;
            lblTransportUnit.Text = "Transport Unit:";
            lblTransportUnit.Visible = false;
            // 
            // cmbDriver
            // 
            cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriver.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(130, 150);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(200, 28);
            cmbDriver.TabIndex = 13;
            cmbDriver.Visible = false;
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDriver.Location = new Point(20, 153);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(52, 20);
            lblDriver.TabIndex = 12;
            lblDriver.Text = "Driver:";
            lblDriver.Visible = false;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.IndianRed;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(510, 190);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(100, 35);
            btnGenerateReport.TabIndex = 11;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(40, 167, 69);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(620, 190);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 35);
            btnExport.TabIndex = 10;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // cmbUser
            // 
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(470, 70);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(250, 28);
            cmbUser.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(380, 73);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 20);
            lblUser.TabIndex = 8;
            lblUser.Text = "User:";
            // 
            // cmbJobStatus
            // 
            cmbJobStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbJobStatus.FormattingEnabled = true;
            cmbJobStatus.Location = new Point(130, 110);
            cmbJobStatus.Name = "cmbJobStatus";
            cmbJobStatus.Size = new Size(200, 28);
            cmbJobStatus.TabIndex = 7;
            // 
            // lblJobStatus
            // 
            lblJobStatus.AutoSize = true;
            lblJobStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJobStatus.Location = new Point(20, 113);
            lblJobStatus.Name = "lblJobStatus";
            lblJobStatus.Size = new Size(79, 20);
            lblJobStatus.TabIndex = 6;
            lblJobStatus.Text = "Job Status:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(470, 30);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 27);
            dtpEndDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(380, 33);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(130, 70);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(20, 73);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 20);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(130, 30);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(200, 28);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportType.Location = new Point(20, 33);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(92, 20);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type:";
            // 
            // dgvReportResults
            // 
            dgvReportResults.AllowUserToAddRows = false;
            dgvReportResults.AllowUserToDeleteRows = false;
            dgvReportResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportResults.BackgroundColor = Color.White;
            dgvReportResults.BorderStyle = BorderStyle.None;
            dgvReportResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportResults.ColumnHeadersHeight = 35;
            dgvReportResults.EnableHeadersVisualStyles = false;
            dgvReportResults.Location = new Point(30, 325);
            dgvReportResults.MultiSelect = false;
            dgvReportResults.Name = "dgvReportResults";
            dgvReportResults.ReadOnly = true;
            dgvReportResults.RowHeadersVisible = false;
            dgvReportResults.RowHeadersWidth = 51;
            dgvReportResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportResults.Size = new Size(740, 240);
            dgvReportResults.TabIndex = 2;
            // 
            // AdminReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255);
            ClientSize = new Size(800, 600);
            Controls.Add(dgvReportResults);
            Controls.Add(pnlReportControls);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminReportForm";
            Padding = new Padding(30, 30, 30, 20);
            Text = "AdminReportForm";
            Load += AdminReportForm_Load;
            pnlReportControls.ResumeLayout(false);
            grpReportFilters.ResumeLayout(false);
            grpReportFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResults).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlReportControls;
        private System.Windows.Forms.GroupBox grpReportFilters;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbJobStatus;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvReportResults;
        private System.Windows.Forms.ComboBox cmbTransportUnit;
        private System.Windows.Forms.Label lblTransportUnit;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label lblDriver;
    }
}