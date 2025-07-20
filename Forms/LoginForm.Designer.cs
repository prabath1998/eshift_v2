using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles
using eShift_Logistics_System.Properties;

namespace eShift_Logistics_System.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // The System.ExecutionEngineException is a critical error that usually indicates a severe problem with the .NET runtime or native interop.
        // It is not caused by the code in the Dispose method you selected.
        // However, to ensure best practices, you can add a null check for the base class and ensure proper disposal pattern:

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLeft = new Panel();
            label4 = new Label();
            picIllustration = new PictureBox();
            lblAppName = new Label();
            pnlRight = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            pnlEmail = new Panel();
            picEmailIcon = new PictureBox();
            txtEmail = new TextBox();
            pnlPassword = new Panel();
            picPasswordIcon = new PictureBox();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            lnkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            lblNoAccount = new Label();
            lnkRegister = new LinkLabel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIllustration).BeginInit();
            pnlRight.SuspendLayout();
            pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmailIcon).BeginInit();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPasswordIcon).BeginInit();
            SuspendLayout();
            //
            // pnlLeft
            //
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(label4);
            pnlLeft.Controls.Add(picIllustration);
            pnlLeft.Controls.Add(lblAppName);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(450, 700);
            pnlLeft.TabIndex = 1;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0); // Softer font weight
            label4.ForeColor = Color.FromArgb(100, 100, 100); // Darker grey for better contrast
            label4.Location = new Point(40, 95);
            label4.Name = "label4";
            label4.Size = new Size(424, 25);
            label4.TabIndex = 14;
            label4.Text = "Effortless logistics for household goods transport";
            //
            // picIllustration
            //
            picIllustration.Image = (Image)resources.GetObject("picIllustration.Image");
            picIllustration.Location = new Point(40, 155);
            picIllustration.Margin = new Padding(3, 4, 3, 4);
            picIllustration.Name = "picIllustration";
            picIllustration.Size = new Size(370, 432);
            picIllustration.SizeMode = PictureBoxSizeMode.Zoom;
            picIllustration.TabIndex = 0;
            picIllustration.TabStop = false;
            //
            // lblAppName
            //
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold); // Slightly larger
            lblAppName.ForeColor = Color.FromArgb(220, 53, 69); // A modern, vibrant red
            lblAppName.Location = new Point(40, 49);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(275, 46);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "E-Shift Household";
            //
            // pnlRight
            //
            pnlRight.BackColor = Color.FromArgb(245, 245, 245); // Slightly darker off-white background
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(label1);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(pnlEmail);
            pnlRight.Controls.Add(pnlPassword);
            pnlRight.Controls.Add(chkRememberMe);
            pnlRight.Controls.Add(lnkForgotPassword);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lblNoAccount);
            pnlRight.Controls.Add(lnkRegister);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(450, 0);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(430, 700);
            pnlRight.TabIndex = 0;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); // Adjusted font
            label3.ForeColor = Color.FromArgb(85, 85, 85); // Softer grey
            label3.Location = new Point(49, 100); // Adjusted location
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 13;
            label3.Text = "Sign in to your account";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F); // Semibold for emphasis
            label2.ForeColor = Color.FromArgb(51, 51, 51); // Darker text for labels
            label2.Location = new Point(49, 291); // Adjusted location
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "Password *"; // Added asterisk for consistency
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F); // Semibold for emphasis
            label1.ForeColor = Color.FromArgb(51, 51, 51); // Darker text for labels
            label1.Location = new Point(49, 196); // Adjusted location
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 11;
            label1.Text = "Email Address *"; // Added asterisk for consistency
            //
            // lblWelcome
            //
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0); // Larger, bolder heading
            lblWelcome.ForeColor = Color.FromArgb(51, 51, 51); // Darker grey for primary text
            lblWelcome.Location = new Point(49, 53); // Adjusted location
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(230, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back!"; // Added exclamation for warmth
            //
            // pnlEmail
            //
            pnlEmail.BackColor = Color.White;
            pnlEmail.BorderStyle = BorderStyle.None; // Changed to None
            pnlEmail.Controls.Add(picEmailIcon);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(49, 220); // Adjusted for better spacing
            pnlEmail.Margin = new Padding(3, 4, 3, 4);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(320, 55);
            pnlEmail.TabIndex = 4;
            //pnlEmail.Paint += Panel_RoundedBorder_Paint; // Custom paint for rounded border
            //
            // picEmailIcon
            //
            picEmailIcon.ErrorImage = null; // Set to null for cleaner code
            picEmailIcon.Image = (Image)resources.GetObject("picEmailIcon.Image");
            picEmailIcon.InitialImage = null; // Set to null for cleaner code
            picEmailIcon.Location = new Point(12, 14); // Adjusted icon position
            picEmailIcon.Margin = new Padding(3, 4, 3, 4);
            picEmailIcon.Name = "picEmailIcon";
            picEmailIcon.Size = new Size(20, 25); // Slightly smaller icon
            picEmailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picEmailIcon.TabIndex = 0;
            picEmailIcon.TabStop = false;
            //
            // txtEmail
            //
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F); // Larger text input font
            txtEmail.Location = new Point(45, 16); // Adjusted for icon and padding
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 25);
            txtEmail.TabIndex = 1;
            //
            // pnlPassword
            //
            pnlPassword.BackColor = Color.White;
            pnlPassword.BorderStyle = BorderStyle.None; // Changed to None
            pnlPassword.Controls.Add(picPasswordIcon);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(49, 315); // Adjusted for better spacing
            pnlPassword.Margin = new Padding(3, 4, 3, 4);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(320, 55);
            pnlPassword.TabIndex = 5;
            //pnlPassword.Paint += Panel_RoundedBorder_Paint; // Custom paint for rounded border
            //
            // picPasswordIcon
            //
            picPasswordIcon.Image = (Image)resources.GetObject("picPasswordIcon.Image");
            picPasswordIcon.Location = new Point(12, 14); // Adjusted icon position
            picPasswordIcon.Margin = new Padding(3, 4, 3, 4);
            picPasswordIcon.Name = "picPasswordIcon";
            picPasswordIcon.Size = new Size(20, 25); // Slightly smaller icon
            picPasswordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picPasswordIcon.TabIndex = 0;
            picPasswordIcon.TabStop = false;
            //
            // txtPassword
            //
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F); // Larger text input font
            txtPassword.Location = new Point(45, 16); // Adjusted for icon and padding
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 10;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(261, 25);
            txtPassword.TabIndex = 1;
            //
            // chkRememberMe
            //
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0); // Consistent font
            chkRememberMe.ForeColor = Color.FromArgb(85, 85, 85); // Softer grey
            chkRememberMe.Location = new Point(49, 391); // Adjusted location
            chkRememberMe.Margin = new Padding(3, 4, 3, 4);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(129, 24);
            chkRememberMe.TabIndex = 6;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            //
            // lnkForgotPassword
            //
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for emphasis
            lnkForgotPassword.LinkColor = Color.FromArgb(220, 53, 69); // Match accent red
            lnkForgotPassword.Location = new Point(249, 391); // Adjusted for better alignment
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(125, 20);
            lnkForgotPassword.TabIndex = 7;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            //
            // btnLogin
            //
            btnLogin.BackColor = Color.FromArgb(220, 53, 69); // Match accent red
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold); // Slightly larger, bolder
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(49, 440); // Adjusted spacing
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 60); // Adjusted height
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            //btnLogin.Paint += Button_RoundedBorder_Paint; // Custom paint for rounded border
            //
            // lblNoAccount
            //
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0); // Consistent font
            lblNoAccount.ForeColor = Color.FromArgb(85, 85, 85); // Softer grey
            lblNoAccount.Location = new Point(65, 528); // Adjusted for centering with link
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(163, 20);
            lblNoAccount.TabIndex = 9;
            lblNoAccount.Text = "Don't have an account?";
            //
            // lnkRegister
            //
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0); // Semibold for emphasis
            lnkRegister.LinkColor = Color.FromArgb(220, 53, 69); // Match accent red
            lnkRegister.Location = new Point(234, 528); // Adjusted for centering with label
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(128, 20);
            lnkRegister.TabIndex = 10;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Create an account";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 700);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift - Login";
            Load += LoginForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIllustration).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmailIcon).EndInit();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPasswordIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picIllustration;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.PictureBox picEmailIcon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}