namespace eShift_Logistics_System.Forms.Customer
{
    partial class CustomerDashboardViewForm
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
            lblWelcome = new Label();
            pnlHeader = new Panel();
            pnlWidgets = new Panel();
            tblWidgetsLayout = new TableLayoutPanel();
            pnlCompletedJobs = new Panel();
            lblCompletedJobsValue = new Label();
            lblCompletedJobsTitle = new Label();
            picCompletedJobs = new PictureBox();
            pnlInTransit = new Panel();
            lblInTransitValue = new Label();
            lblInTransitTitle = new Label();
            picInTransit = new PictureBox();
            pnlTotalJobs = new Panel();
            lblTotalJobsValue = new Label();
            lblTotalJobsTitle = new Label();
            picTotalJobs = new PictureBox();
            pnlRecentJobs = new Panel();
            dgvRecentJobs = new DataGridView();
            lblRecentJobsTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlWidgets.SuspendLayout();
            tblWidgetsLayout.SuspendLayout();
            pnlCompletedJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCompletedJobs).BeginInit();
            pnlInTransit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInTransit).BeginInit();
            pnlTotalJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalJobs).BeginInit();
            pnlRecentJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblWelcome.Location = new Point(3, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(383, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Customer!";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(34, 40);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(778, 67);
            pnlHeader.TabIndex = 1;
            // 
            // pnlWidgets
            // 
            pnlWidgets.BackColor = Color.White;
            pnlWidgets.Controls.Add(tblWidgetsLayout);
            pnlWidgets.Dock = DockStyle.Top;
            pnlWidgets.Location = new Point(34, 107);
            pnlWidgets.Margin = new Padding(3, 4, 3, 4);
            pnlWidgets.Name = "pnlWidgets";
            pnlWidgets.Padding = new Padding(11, 13, 11, 13);
            pnlWidgets.Size = new Size(778, 160);
            pnlWidgets.TabIndex = 2;
            // 
            // tblWidgetsLayout
            // 
            tblWidgetsLayout.ColumnCount = 3;
            tblWidgetsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblWidgetsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblWidgetsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblWidgetsLayout.Controls.Add(pnlCompletedJobs, 2, 0);
            tblWidgetsLayout.Controls.Add(pnlInTransit, 1, 0);
            tblWidgetsLayout.Controls.Add(pnlTotalJobs, 0, 0);
            tblWidgetsLayout.Dock = DockStyle.Fill;
            tblWidgetsLayout.Location = new Point(11, 13);
            tblWidgetsLayout.Margin = new Padding(3, 4, 3, 4);
            tblWidgetsLayout.Name = "tblWidgetsLayout";
            tblWidgetsLayout.RowCount = 1;
            tblWidgetsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblWidgetsLayout.Size = new Size(756, 134);
            tblWidgetsLayout.TabIndex = 0;
            // 
            // pnlCompletedJobs
            // 
            pnlCompletedJobs.Controls.Add(lblCompletedJobsValue);
            pnlCompletedJobs.Controls.Add(lblCompletedJobsTitle);
            pnlCompletedJobs.Controls.Add(picCompletedJobs);
            pnlCompletedJobs.Dock = DockStyle.Fill;
            pnlCompletedJobs.Location = new Point(507, 4);
            pnlCompletedJobs.Margin = new Padding(3, 4, 3, 4);
            pnlCompletedJobs.Name = "pnlCompletedJobs";
            pnlCompletedJobs.Size = new Size(246, 126);
            pnlCompletedJobs.TabIndex = 2;
            // 
            // lblCompletedJobsValue
            // 
            lblCompletedJobsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCompletedJobsValue.ForeColor = Color.FromArgb(40, 167, 69);
            lblCompletedJobsValue.Location = new Point(69, 60);
            lblCompletedJobsValue.Name = "lblCompletedJobsValue";
            lblCompletedJobsValue.Size = new Size(49, 43);
            lblCompletedJobsValue.TabIndex = 2;
            lblCompletedJobsValue.Text = "25";
            // 
            // lblCompletedJobsTitle
            // 
            lblCompletedJobsTitle.ForeColor = Color.Gray;
            lblCompletedJobsTitle.Location = new Point(69, 27);
            lblCompletedJobsTitle.Name = "lblCompletedJobsTitle";
            lblCompletedJobsTitle.Size = new Size(109, 20);
            lblCompletedJobsTitle.TabIndex = 1;
            lblCompletedJobsTitle.Text = "Completed Jobs";
            // 
            // picCompletedJobs
            // 
            picCompletedJobs.Location = new Point(17, 36);
            picCompletedJobs.Margin = new Padding(3, 4, 3, 4);
            picCompletedJobs.Name = "picCompletedJobs";
            picCompletedJobs.Size = new Size(46, 53);
            picCompletedJobs.SizeMode = PictureBoxSizeMode.Zoom;
            picCompletedJobs.TabIndex = 0;
            picCompletedJobs.TabStop = false;
            // 
            // pnlInTransit
            // 
            pnlInTransit.Controls.Add(lblInTransitValue);
            pnlInTransit.Controls.Add(lblInTransitTitle);
            pnlInTransit.Controls.Add(picInTransit);
            pnlInTransit.Dock = DockStyle.Fill;
            pnlInTransit.Location = new Point(255, 4);
            pnlInTransit.Margin = new Padding(3, 4, 3, 4);
            pnlInTransit.Name = "pnlInTransit";
            pnlInTransit.Size = new Size(246, 126);
            pnlInTransit.TabIndex = 1;
            // 
            // lblInTransitValue
            // 
            lblInTransitValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInTransitValue.ForeColor = Color.FromArgb(255, 193, 7);
            lblInTransitValue.Location = new Point(69, 60);
            lblInTransitValue.Name = "lblInTransitValue";
            lblInTransitValue.Size = new Size(33, 43);
            lblInTransitValue.TabIndex = 2;
            lblInTransitValue.Text = "2";
            // 
            // lblInTransitTitle
            // 
            lblInTransitTitle.ForeColor = Color.Gray;
            lblInTransitTitle.Location = new Point(69, 27);
            lblInTransitTitle.Name = "lblInTransitTitle";
            lblInTransitTitle.Size = new Size(93, 20);
            lblInTransitTitle.TabIndex = 1;
            lblInTransitTitle.Text = "Jobs in Transit";
            // 
            // picInTransit
            // 
            picInTransit.Location = new Point(17, 36);
            picInTransit.Margin = new Padding(3, 4, 3, 4);
            picInTransit.Name = "picInTransit";
            picInTransit.Size = new Size(46, 53);
            picInTransit.SizeMode = PictureBoxSizeMode.Zoom;
            picInTransit.TabIndex = 0;
            picInTransit.TabStop = false;
            // 
            // pnlTotalJobs
            // 
            pnlTotalJobs.Controls.Add(lblTotalJobsValue);
            pnlTotalJobs.Controls.Add(lblTotalJobsTitle);
            pnlTotalJobs.Controls.Add(picTotalJobs);
            pnlTotalJobs.Dock = DockStyle.Fill;
            pnlTotalJobs.Location = new Point(3, 4);
            pnlTotalJobs.Margin = new Padding(3, 4, 3, 4);
            pnlTotalJobs.Name = "pnlTotalJobs";
            pnlTotalJobs.Size = new Size(246, 126);
            pnlTotalJobs.TabIndex = 0;
            // 
            // lblTotalJobsValue
            // 
            lblTotalJobsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJobsValue.ForeColor = Color.IndianRed;
            lblTotalJobsValue.Location = new Point(69, 60);
            lblTotalJobsValue.Name = "lblTotalJobsValue";
            lblTotalJobsValue.Size = new Size(49, 43);
            lblTotalJobsValue.TabIndex = 2;
            lblTotalJobsValue.Text = "32";
            // 
            // lblTotalJobsTitle
            // 
            lblTotalJobsTitle.ForeColor = Color.Gray;
            lblTotalJobsTitle.Location = new Point(69, 27);
            lblTotalJobsTitle.Name = "lblTotalJobsTitle";
            lblTotalJobsTitle.Size = new Size(69, 20);
            lblTotalJobsTitle.TabIndex = 1;
            lblTotalJobsTitle.Text = "Total Jobs";
            // 
            // picTotalJobs
            // 
            picTotalJobs.Location = new Point(17, 36);
            picTotalJobs.Margin = new Padding(3, 4, 3, 4);
            picTotalJobs.Name = "picTotalJobs";
            picTotalJobs.Size = new Size(46, 53);
            picTotalJobs.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalJobs.TabIndex = 0;
            picTotalJobs.TabStop = false;
            // 
            // pnlRecentJobs
            // 
            pnlRecentJobs.BackColor = Color.White;
            pnlRecentJobs.Controls.Add(dgvRecentJobs);
            pnlRecentJobs.Controls.Add(lblRecentJobsTitle);
            pnlRecentJobs.Dock = DockStyle.Fill;
            pnlRecentJobs.Location = new Point(34, 267);
            pnlRecentJobs.Margin = new Padding(3, 13, 3, 4);
            pnlRecentJobs.Name = "pnlRecentJobs";
            pnlRecentJobs.Padding = new Padding(17, 20, 17, 20);
            pnlRecentJobs.Size = new Size(778, 493);
            pnlRecentJobs.TabIndex = 3;
            // 
            // dgvRecentJobs
            // 
            dgvRecentJobs.AllowUserToAddRows = false;
            dgvRecentJobs.AllowUserToDeleteRows = false;
            dgvRecentJobs.BackgroundColor = Color.White;
            dgvRecentJobs.BorderStyle = BorderStyle.None;
            dgvRecentJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dgvRecentJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentJobs.Dock = DockStyle.Fill;
            dgvRecentJobs.EnableHeadersVisualStyles = false;
            dgvRecentJobs.Location = new Point(17, 59);
            dgvRecentJobs.Margin = new Padding(3, 4, 3, 4);
            dgvRecentJobs.Name = "dgvRecentJobs";
            dgvRecentJobs.ReadOnly = true;
            dgvRecentJobs.RowHeadersVisible = false;
            dgvRecentJobs.RowHeadersWidth = 51;
            dgvRecentJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentJobs.Size = new Size(744, 414);
            dgvRecentJobs.TabIndex = 1;
            // 
            // lblRecentJobsTitle
            // 
            lblRecentJobsTitle.AutoSize = true;
            lblRecentJobsTitle.Dock = DockStyle.Top;
            lblRecentJobsTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblRecentJobsTitle.Location = new Point(17, 20);
            lblRecentJobsTitle.Name = "lblRecentJobsTitle";
            lblRecentJobsTitle.Padding = new Padding(0, 0, 0, 7);
            lblRecentJobsTitle.Size = new Size(215, 39);
            lblRecentJobsTitle.TabIndex = 0;
            lblRecentJobsTitle.Text = "Recent Job Status";
            // 
            // CustomerDashboardViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255);
            ClientSize = new Size(846, 800);
            Controls.Add(pnlRecentJobs);
            Controls.Add(pnlWidgets);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDashboardViewForm";
            Padding = new Padding(34, 40, 34, 40);
            Text = "CustomerDashboardViewForm";
            Load += CustomerDashboardViewForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlWidgets.ResumeLayout(false);
            tblWidgetsLayout.ResumeLayout(false);
            pnlCompletedJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCompletedJobs).EndInit();
            pnlInTransit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInTransit).EndInit();
            pnlTotalJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTotalJobs).EndInit();
            pnlRecentJobs.ResumeLayout(false);
            pnlRecentJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlWidgets;
        private System.Windows.Forms.TableLayoutPanel tblWidgetsLayout;
        private System.Windows.Forms.Panel pnlTotalJobs;
        private System.Windows.Forms.Label lblTotalJobsValue;
        private System.Windows.Forms.Label lblTotalJobsTitle;
        private System.Windows.Forms.PictureBox picTotalJobs;
        private System.Windows.Forms.Panel pnlCompletedJobs;
        private System.Windows.Forms.Label lblCompletedJobsValue;
        private System.Windows.Forms.Label lblCompletedJobsTitle;
        private System.Windows.Forms.PictureBox picCompletedJobs;
        private System.Windows.Forms.Panel pnlInTransit;
        private System.Windows.Forms.Label lblInTransitValue;
        private System.Windows.Forms.Label lblInTransitTitle;
        private System.Windows.Forms.PictureBox picInTransit;
        private System.Windows.Forms.Panel pnlRecentJobs;
        private System.Windows.Forms.Label lblRecentJobsTitle;
        private System.Windows.Forms.DataGridView dgvRecentJobs;
    }
}