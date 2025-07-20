using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles (though not directly used for rounded panels here, good to keep for consistency if you add it later)
using eShift_Logistics_System.Properties;

namespace eShift_Logistics_System.Forms.Admin
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            pnlSidebar = new Panel();
            pnlReports = new Panel();
            imgHelp = new PictureBox();
            lblHelp = new Label();
            pnlProduct = new Panel();
            imgPromote = new PictureBox();
            lblPromote = new Label();
            pnlVehicle = new Panel();
            imgIncome = new PictureBox();
            lblIncome = new Label();
            pnlJobs = new Panel();
            imgCustomers = new PictureBox();
            lblCustomers = new Label();
            pnlCustomer = new Panel();
            imgProduct = new PictureBox();
            lblProduct = new Label();
            pnlDashboard = new Panel();
            imgDashboard = new PictureBox();
            lblDashboard = new Label();
            pnlUser = new Panel();
            btnLogout = new Label();
            lblUserName = new Label();
            picUserAvatar = new PictureBox();
            pnlHeader = new Panel();
            lblAppName = new Label();
            picAppLogo = new PictureBox();
            pnlMainContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgHelp).BeginInit();
            pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPromote).BeginInit();
            pnlVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgIncome).BeginInit();
            pnlJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCustomers).BeginInit();
            pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProduct).BeginInit();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).BeginInit();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAppLogo).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(220, 53, 69); // Modern vibrant red
            pnlSidebar.Controls.Add(pnlReports);
            pnlSidebar.Controls.Add(pnlProduct);
            pnlSidebar.Controls.Add(pnlVehicle);
            pnlSidebar.Controls.Add(pnlJobs);
            pnlSidebar.Controls.Add(pnlCustomer);
            pnlSidebar.Controls.Add(pnlDashboard);
            pnlSidebar.Controls.Add(pnlUser);
            pnlSidebar.Controls.Add(pnlHeader);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(311, 853);
            pnlSidebar.TabIndex = 0;
            //
            // pnlReports
            //
            pnlReports.BackColor = Color.Transparent;
            pnlReports.Controls.Add(imgHelp);
            pnlReports.Controls.Add(lblHelp);
            pnlReports.Cursor = Cursors.Hand;
            pnlReports.Location = new Point(0, 420); // Aligned to left edge of sidebar
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(311, 50); // Increased height for better spacing
            pnlReports.TabIndex = 6;
            //pnlReports.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlReports.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgHelp
            //
            imgHelp.Image = (Image)resources.GetObject("imgHelp.Image");
            imgHelp.Location = new Point(25, 13); // Adjusted icon position
            imgHelp.Name = "imgHelp";
            imgHelp.Size = new Size(24, 24);
            imgHelp.SizeMode = PictureBoxSizeMode.Zoom;
            imgHelp.TabIndex = 1;
            imgHelp.TabStop = false;
            //
            // lblHelp
            //
            lblHelp.AutoSize = true;
            lblHelp.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblHelp.ForeColor = Color.White; // Pure white for better contrast
            lblHelp.Location = new Point(65, 14); // Adjusted text position
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(74, 25);
            lblHelp.TabIndex = 0;
            lblHelp.Text = "Reports";
            //
            // pnlProduct
            //
            pnlProduct.BackColor = Color.Transparent;
            pnlProduct.Controls.Add(imgPromote);
            pnlProduct.Controls.Add(lblPromote);
            pnlProduct.Cursor = Cursors.Hand;
            pnlProduct.Location = new Point(0, 360); // Aligned to left edge of sidebar
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(311, 50); // Increased height
            pnlProduct.TabIndex = 5;
            //pnlProduct.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlProduct.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgPromote
            //
            imgPromote.Image = (Image)resources.GetObject("imgPromote.Image");
            imgPromote.Location = new Point(25, 13); // Adjusted icon position
            imgPromote.Name = "imgPromote";
            imgPromote.Size = new Size(24, 24);
            imgPromote.SizeMode = PictureBoxSizeMode.Zoom;
            imgPromote.TabIndex = 1;
            imgPromote.TabStop = false;
            //
            // lblPromote
            //
            lblPromote.AutoSize = true;
            lblPromote.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblPromote.ForeColor = Color.White; // Pure white
            lblPromote.Location = new Point(65, 14); // Adjusted text position
            lblPromote.Name = "lblPromote";
            lblPromote.Size = new Size(184, 25);
            lblPromote.TabIndex = 0;
            lblPromote.Text = "Product Management";
            //
            // pnlVehicle
            //
            pnlVehicle.BackColor = Color.Transparent;
            pnlVehicle.Controls.Add(imgIncome);
            pnlVehicle.Controls.Add(lblIncome);
            pnlVehicle.Cursor = Cursors.Hand;
            pnlVehicle.Location = new Point(0, 300); // Aligned to left edge of sidebar
            pnlVehicle.Name = "pnlVehicle";
            pnlVehicle.Size = new Size(311, 50); // Increased height
            pnlVehicle.TabIndex = 4;
            //pnlVehicle.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlVehicle.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgIncome
            //
            imgIncome.Image = (Image)resources.GetObject("imgIncome.Image");
            imgIncome.Location = new Point(25, 13); // Adjusted icon position
            imgIncome.Name = "imgIncome";
            imgIncome.Size = new Size(24, 24);
            imgIncome.SizeMode = PictureBoxSizeMode.Zoom;
            imgIncome.TabIndex = 1;
            imgIncome.TabStop = false;
            //
            // lblIncome
            //
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblIncome.ForeColor = Color.White; // Pure white
            lblIncome.Location = new Point(65, 14); // Adjusted text position
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(177, 25);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Vehicle Management";
            //
            // pnlJobs
            //
            pnlJobs.BackColor = Color.Transparent;
            pnlJobs.Controls.Add(imgCustomers);
            pnlJobs.Controls.Add(lblCustomers);
            pnlJobs.Cursor = Cursors.Hand;
            pnlJobs.Location = new Point(0, 240); // Aligned to left edge of sidebar
            pnlJobs.Name = "pnlJobs";
            pnlJobs.Size = new Size(311, 50); // Increased height
            pnlJobs.TabIndex = 3;
            //pnlJobs.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlJobs.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgCustomers
            //
            imgCustomers.Image = (Image)resources.GetObject("imgCustomers.Image");
            imgCustomers.Location = new Point(25, 13); // Adjusted icon position
            imgCustomers.Name = "imgCustomers";
            imgCustomers.Size = new Size(24, 24);
            imgCustomers.SizeMode = PictureBoxSizeMode.Zoom;
            imgCustomers.TabIndex = 1;
            imgCustomers.TabStop = false;
            //
            // lblCustomers
            //
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblCustomers.ForeColor = Color.White; // Pure white
            lblCustomers.Location = new Point(65, 14); // Adjusted text position
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(150, 25);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Job Management";
            //
            // pnlCustomer
            //
            pnlCustomer.BackColor = Color.Transparent;
            pnlCustomer.Controls.Add(imgProduct);
            pnlCustomer.Controls.Add(lblProduct);
            pnlCustomer.Cursor = Cursors.Hand;
            pnlCustomer.Location = new Point(0, 180); // Aligned to left edge of sidebar
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(311, 50); // Increased height
            pnlCustomer.TabIndex = 2;
            //pnlCustomer.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlCustomer.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgProduct
            //
            imgProduct.Image = (Image)resources.GetObject("imgProduct.Image");
            imgProduct.Location = new Point(25, 13); // Adjusted icon position
            imgProduct.Name = "imgProduct";
            imgProduct.Size = new Size(24, 24);
            imgProduct.SizeMode = PictureBoxSizeMode.Zoom;
            imgProduct.TabIndex = 1;
            imgProduct.TabStop = false;
            //
            // lblProduct
            //
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblProduct.ForeColor = Color.White; // Pure white
            lblProduct.Location = new Point(65, 14); // Adjusted text position
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(198, 25);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Customer Management";
            //
            // pnlDashboard
            //
            pnlDashboard.BackColor = Color.FromArgb(200, 48, 60); // Slightly darker red for selected/active state
            pnlDashboard.Controls.Add(imgDashboard);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Cursor = Cursors.Hand;
            pnlDashboard.Location = new Point(0, 120); // Aligned to left edge of sidebar
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(311, 50); // Increased height
            pnlDashboard.TabIndex = 1;
            //pnlDashboard.MouseEnter += MenuItem_MouseEnter; // Add hover effect
            //pnlDashboard.MouseLeave += MenuItem_MouseLeave; // Add hover effect
            //
            // imgDashboard
            //
            imgDashboard.Image = (Image)resources.GetObject("imgDashboard.Image");
            imgDashboard.Location = new Point(25, 13); // Adjusted icon position
            imgDashboard.Name = "imgDashboard";
            imgDashboard.Size = new Size(24, 24);
            imgDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            imgDashboard.TabIndex = 1;
            imgDashboard.TabStop = false;
            //
            // lblDashboard
            //
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Slightly larger font
            lblDashboard.ForeColor = Color.White; // Pure white
            lblDashboard.Location = new Point(65, 14); // Adjusted text position
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(97, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            //
            // pnlUser
            //
            pnlUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlUser.BackColor = Color.Transparent;
            pnlUser.Controls.Add(btnLogout);
            pnlUser.Controls.Add(lblUserName);
            pnlUser.Controls.Add(picUserAvatar);
            pnlUser.Location = new Point(20, 773);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(270, 60); // Slightly wider
            pnlUser.TabIndex = 0;
            //
            // btnLogout
            //
            btnLogout.AutoSize = true;
            btnLogout.Cursor = Cursors.Hand; // Add hand cursor for clickable label
            btnLogout.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0); // Slightly larger font
            btnLogout.ForeColor = Color.FromArgb(240, 240, 240); // Lighter grey for logout link
            btnLogout.Location = new Point(60, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 20);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            //
            // lblUserName
            //
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0); // Slightly larger font
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(60, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Evano";
            //
            // picUserAvatar
            //
            picUserAvatar.Image = (Image)resources.GetObject("picUserAvatar.Image");
            picUserAvatar.Location = new Point(10, 10);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.Size = new Size(38, 38); // Slightly larger avatar
            picUserAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picUserAvatar.TabIndex = 0;
            picUserAvatar.TabStop = false;
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(picAppLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(311, 80);
            pnlHeader.TabIndex = 0;
            //
            // lblAppName
            //
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0); // Larger font
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(70, 20); // Adjusted position
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(119, 41);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "E-Shift";
            //
            // picAppLogo
            //
            picAppLogo.Image = (Image)resources.GetObject("picAppLogo.Image");
            picAppLogo.Location = new Point(25, 20);
            picAppLogo.Name = "picAppLogo";
            picAppLogo.Size = new Size(40, 40);
            picAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picAppLogo.TabIndex = 0;
            picAppLogo.TabStop = false;
            //
            // pnlMainContent
            //
            pnlMainContent.BackColor = Color.FromArgb(247, 248, 255); // Keep light blue-ish white
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(311, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1271, 853);
            pnlMainContent.TabIndex = 1;
            //
            // AdminDashboardForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1600, 800);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Shift - Admin Dashboard";
            Load += AdminDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgHelp).EndInit();
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPromote).EndInit();
            pnlVehicle.ResumeLayout(false);
            pnlVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgIncome).EndInit();
            pnlJobs.ResumeLayout(false);
            pnlJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCustomers).EndInit();
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProduct).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAppLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox picAppLogo;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.PictureBox imgHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.PictureBox imgPromote;
        private System.Windows.Forms.Label lblPromote;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.PictureBox imgIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Panel pnlJobs;
        private System.Windows.Forms.PictureBox imgCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlMainContent;
    }
}
