using System.Drawing; // Ensure this is present for Color
using eShift_Logistics_System.Properties; // Assuming this is still needed for resources

namespace eShift_Logistics_System.Forms.Customer
{
    partial class CustomerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            pnlSidebar = new Panel();
            pnlMyProfile = new Panel();
            picMyProfile = new PictureBox();
            lblMyProfile = new Label();
            pnlRequestPickup = new Panel();
            picRequestPickup = new PictureBox();
            lblRequestPickup = new Label();
            pnlMyJobs = new Panel();
            picMyJobs = new PictureBox();
            lblMyJobs = new Label();
            pnlDashboard = new Panel();
            picDashboard = new PictureBox();
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
            pnlMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMyProfile).BeginInit();
            pnlRequestPickup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRequestPickup).BeginInit();
            pnlMyJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMyJobs).BeginInit();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAppLogo).BeginInit();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(220, 53, 69); // Modern vibrant red
            pnlSidebar.Controls.Add(pnlMyProfile);
            pnlSidebar.Controls.Add(pnlRequestPickup);
            pnlSidebar.Controls.Add(pnlMyJobs);
            pnlSidebar.Controls.Add(pnlDashboard);
            pnlSidebar.Controls.Add(pnlUser);
            pnlSidebar.Controls.Add(pnlHeader);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(297, 719);
            pnlSidebar.TabIndex = 0;
            //
            // pnlMyProfile
            //
            pnlMyProfile.BackColor = Color.Transparent;
            pnlMyProfile.Controls.Add(picMyProfile);
            pnlMyProfile.Controls.Add(lblMyProfile);
            pnlMyProfile.Cursor = Cursors.Hand;
            pnlMyProfile.Location = new Point(0, 320); // Aligned to left edge of sidebar
            pnlMyProfile.Margin = new Padding(3, 4, 3, 4);
            pnlMyProfile.Name = "pnlMyProfile";
            pnlMyProfile.Size = new Size(297, 60); // Full width of sidebar
            pnlMyProfile.TabIndex = 4;
            //
            // picMyProfile
            //
            picMyProfile.Image = (Image)resources.GetObject("picMyProfile.Image");
            picMyProfile.Location = new Point(25, 13); // Adjusted icon position
            picMyProfile.Margin = new Padding(3, 4, 3, 4);
            picMyProfile.Name = "picMyProfile";
            picMyProfile.Size = new Size(27, 32);
            picMyProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picMyProfile.TabIndex = 1;
            picMyProfile.TabStop = false;
            //
            // lblMyProfile
            //
            lblMyProfile.AutoSize = true;
            lblMyProfile.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold); // Consistent font
            lblMyProfile.ForeColor = Color.White; // Pure white for contrast
            lblMyProfile.Location = new Point(65, 16); // Adjusted text position
            lblMyProfile.Name = "lblMyProfile";
            lblMyProfile.Size = new Size(104, 25);
            lblMyProfile.TabIndex = 0;
            lblMyProfile.Text = "My Profile";
            //
            // pnlRequestPickup
            //
            pnlRequestPickup.BackColor = Color.Transparent; // Default to transparent
            pnlRequestPickup.Controls.Add(picRequestPickup);
            pnlRequestPickup.Controls.Add(lblRequestPickup);
            pnlRequestPickup.Cursor = Cursors.Hand;
            pnlRequestPickup.Location = new Point(0, 400); // Aligned to left edge of sidebar
            pnlRequestPickup.Margin = new Padding(3, 4, 3, 4);
            pnlRequestPickup.Name = "pnlRequestPickup";
            pnlRequestPickup.Size = new Size(297, 60); // Full width of sidebar
            pnlRequestPickup.TabIndex = 3;
            //
            // picRequestPickup
            //
            picRequestPickup.Image = (Image)resources.GetObject("picRequestPickup.Image");
            picRequestPickup.Location = new Point(25, 13); // Adjusted icon position
            picRequestPickup.Margin = new Padding(3, 4, 3, 4);
            picRequestPickup.Name = "picRequestPickup";
            picRequestPickup.Size = new Size(27, 32);
            picRequestPickup.SizeMode = PictureBoxSizeMode.Zoom;
            picRequestPickup.TabIndex = 1;
            picRequestPickup.TabStop = false;
            //
            // lblRequestPickup
            //
            lblRequestPickup.AutoSize = true;
            lblRequestPickup.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold); // Consistent font
            lblRequestPickup.ForeColor = Color.White; // Pure white
            lblRequestPickup.Location = new Point(65, 16); // Adjusted text position
            lblRequestPickup.Name = "lblRequestPickup";
            lblRequestPickup.Size = new Size(149, 25);
            lblRequestPickup.TabIndex = 0;
            lblRequestPickup.Text = "Request Pickup";
            //
            // pnlMyJobs
            //
            pnlMyJobs.BackColor = Color.Transparent;
            pnlMyJobs.Controls.Add(picMyJobs);
            pnlMyJobs.Controls.Add(lblMyJobs);
            pnlMyJobs.Cursor = Cursors.Hand;
            pnlMyJobs.Location = new Point(0, 240); // Aligned to left edge of sidebar
            pnlMyJobs.Margin = new Padding(3, 4, 3, 4);
            pnlMyJobs.Name = "pnlMyJobs";
            pnlMyJobs.Size = new Size(297, 60); // Full width of sidebar
            pnlMyJobs.TabIndex = 2;
            //
            // picMyJobs
            //
            picMyJobs.Image = (Image)resources.GetObject("picMyJobs.Image");
            picMyJobs.Location = new Point(25, 13); // Adjusted icon position
            picMyJobs.Margin = new Padding(3, 4, 3, 4);
            picMyJobs.Name = "picMyJobs";
            picMyJobs.Size = new Size(27, 32);
            picMyJobs.SizeMode = PictureBoxSizeMode.Zoom;
            picMyJobs.TabIndex = 1;
            picMyJobs.TabStop = false;
            //
            // lblMyJobs
            //
            lblMyJobs.AutoSize = true;
            lblMyJobs.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold); // Consistent font
            lblMyJobs.ForeColor = Color.White; // Pure white
            lblMyJobs.Location = new Point(65, 16); // Adjusted text position
            lblMyJobs.Name = "lblMyJobs";
            lblMyJobs.Size = new Size(85, 25);
            lblMyJobs.TabIndex = 0;
            lblMyJobs.Text = "My Jobs";
            //
            // pnlDashboard
            //
            pnlDashboard.BackColor = Color.FromArgb(200, 48, 60); // Slightly darker red for selected/active state
            pnlDashboard.Controls.Add(picDashboard);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Cursor = Cursors.Hand;
            pnlDashboard.Location = new Point(0, 160); // Aligned to left edge of sidebar
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(297, 60); // Full width of sidebar
            pnlDashboard.TabIndex = 1;
            //
            // picDashboard
            //
            picDashboard.Image = (Image)resources.GetObject("picDashboard.Image");
            picDashboard.Location = new Point(25, 13); // Adjusted icon position
            picDashboard.Margin = new Padding(3, 4, 3, 4);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(27, 32);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 1;
            picDashboard.TabStop = false;
            //
            // lblDashboard
            //
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold); // Consistent font
            lblDashboard.ForeColor = Color.White; // Pure white
            lblDashboard.Location = new Point(65, 16); // Adjusted text position
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(109, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            //
            // pnlUser
            //
            pnlUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlUser.BackColor = Color.Transparent;
            pnlUser.Controls.Add(btnLogout);
            pnlUser.Controls.Add(lblUserName);
            pnlUser.Controls.Add(picUserAvatar);
            pnlUser.Location = new Point(23, 612);
            pnlUser.Margin = new Padding(3, 4, 3, 4);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(251, 80); // Adjusted size
            pnlUser.TabIndex = 0;
            //
            // btnLogout
            //
            btnLogout.AutoSize = true;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Segoe UI", 8.5F); // Consistent font
            btnLogout.ForeColor = Color.FromArgb(240, 240, 240); // Lighter grey for logout link
            btnLogout.Location = new Point(69, 43);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 20); // Adjusted size
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            //
            // lblUserName
            //
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold); // Consistent font
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(69, 16);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(139, 25); // Adjusted size
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Customer Name";
            //
            // picUserAvatar
            //
            picUserAvatar.Image = (Image)resources.GetObject("picUserAvatar.Image");
            picUserAvatar.Location = new Point(11, 13);
            picUserAvatar.Margin = new Padding(3, 4, 3, 4);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.Size = new Size(41, 48);
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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(297, 107);
            pnlHeader.TabIndex = 0;
            //
            // lblAppName
            //
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold); // Larger font
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(80, 33);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(119, 41); // Adjusted size
            lblAppName.TabIndex = 1;
            lblAppName.Text = "E-Shift";
            //
            // picAppLogo
            //
            picAppLogo.Image = (Image)resources.GetObject("picAppLogo.Image");
            picAppLogo.Location = new Point(29, 27);
            picAppLogo.Margin = new Padding(3, 4, 3, 4);
            picAppLogo.Name = "picAppLogo";
            picAppLogo.Size = new Size(46, 53);
            picAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picAppLogo.TabIndex = 0;
            picAppLogo.TabStop = false;
            //
            // pnlMainContent
            //
            pnlMainContent.BackColor = Color.FromArgb(247, 248, 255); // Consistent light background
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(297, 0);
            pnlMainContent.Margin = new Padding(3, 4, 3, 4);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1075, 719);
            pnlMainContent.TabIndex = 1;
            //
            // CustomerDashboardForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F); // Consistent font scaling
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 719);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Shift Customer Dashboard";
            Load += CustomerDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMyProfile.ResumeLayout(false);
            pnlMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMyProfile).EndInit();
            pnlRequestPickup.ResumeLayout(false);
            pnlRequestPickup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRequestPickup).EndInit();
            pnlMyJobs.ResumeLayout(false);
            pnlMyJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMyJobs).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
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
        private System.Windows.Forms.Label btnLogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlMyProfile;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Panel pnlRequestPickup;
        private System.Windows.Forms.Label lblRequestPickup;
        private System.Windows.Forms.Panel pnlMyJobs;
        private System.Windows.Forms.Label lblMyJobs;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.PictureBox picMyProfile;
        private System.Windows.Forms.PictureBox picRequestPickup;
        private System.Windows.Forms.PictureBox picMyJobs;
    }
}
