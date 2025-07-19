namespace eShift_Logistics_System.Forms.Admin
{
    partial class AddEditTransportUnitForm
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
            lblTitle = new Label();
            label2 = new Label();
            cboTruck = new ComboBox();
            cboDriver = new ComboBox();
            label3 = new Label();
            cboAssistant = new ComboBox();
            label4 = new Label();
            cboStatus = new ComboBox();
            label5 = new Label();
            chkIsActive = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.Location = new Point(29, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Transport Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Select Truck";
            // 
            // cboTruck
            // 
            cboTruck.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTruck.FormattingEnabled = true;
            cboTruck.Location = new Point(160, 107);
            cboTruck.Margin = new Padding(3, 4, 3, 4);
            cboTruck.Name = "cboTruck";
            cboTruck.Size = new Size(262, 28);
            cboTruck.TabIndex = 1;
            // 
            // cboDriver
            // 
            cboDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDriver.FormattingEnabled = true;
            cboDriver.Location = new Point(160, 153);
            cboDriver.Margin = new Padding(3, 4, 3, 4);
            cboDriver.Name = "cboDriver";
            cboDriver.Size = new Size(262, 28);
            cboDriver.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 157);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 5;
            label3.Text = "Select Driver";
            // 
            // cboAssistant
            // 
            cboAssistant.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssistant.FormattingEnabled = true;
            cboAssistant.Location = new Point(160, 200);
            cboAssistant.Margin = new Padding(3, 4, 3, 4);
            cboAssistant.Name = "cboAssistant";
            cboAssistant.Size = new Size(262, 28);
            cboAssistant.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 204);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 7;
            label4.Text = "Select Assistant";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(160, 247);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(262, 28);
            cboStatus.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 251);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(160, 297);
            chkIsActive.Margin = new Padding(3, 4, 3, 4);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(86, 24);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(286, 353);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 53);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(160, 353);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 53);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddEditTransportUnitForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(462, 435);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(cboStatus);
            Controls.Add(label5);
            Controls.Add(cboAssistant);
            Controls.Add(label4);
            Controls.Add(cboDriver);
            Controls.Add(label3);
            Controls.Add(cboTruck);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditTransportUnitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transport Unit Details";
            Load += AddEditUnitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTruck;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAssistant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}