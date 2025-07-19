namespace eShift_Logistics_System.Forms.Admin
{
    partial class JobDetailsForm
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
            lblTitle = new Label();
            tblMainLayout = new TableLayoutPanel();
            pnlLeft = new Panel();
            grpStatusUpdate = new GroupBox();
            btnUpdateStatus = new Button();
            cboUpdateStatus = new ComboBox();
            lblUpdateStatus = new Label();
            grpCustomer = new GroupBox();
            txtCustomerEmail = new TextBox();
            label5 = new Label();
            txtCustomerPhone = new TextBox();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            grpLocations = new GroupBox();
            txtDeliveryAddress = new TextBox();
            label7 = new Label();
            txtPickupAddress = new TextBox();
            label6 = new Label();
            grpJobInfo = new GroupBox();
            txtStatus = new TextBox();
            label10 = new Label();
            txtRequestedDate = new TextBox();
            label9 = new Label();
            txtJobNumber = new TextBox();
            label8 = new Label();
            pnlRight = new Panel();
            grpLoads = new GroupBox();
            dgvLoads = new DataGridView();
            pnlAddLoad = new Panel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            btnAddLoad = new Button();
            numLoadVolume = new NumericUpDown();
            numLoadWeight = new NumericUpDown();
            txtLoadDescription = new TextBox();
            grpProductsRequested = new GroupBox();
            dgvJobProducts = new DataGridView();
            grpCosting = new GroupBox();
            btnAssignAndSave = new Button();
            cboTransportUnit = new ComboBox();
            label15 = new Label();
            txtEstimatedCost = new TextBox();
            label14 = new Label();
            txtTotalVolume = new TextBox();
            label13 = new Label();
            txtTotalWeight = new TextBox();
            label12 = new Label();
            tblMainLayout.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpStatusUpdate.SuspendLayout();
            grpCustomer.SuspendLayout();
            grpLocations.SuspendLayout();
            grpJobInfo.SuspendLayout();
            pnlRight.SuspendLayout();
            grpLoads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            pnlAddLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLoadVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLoadWeight).BeginInit();
            grpProductsRequested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobProducts).BeginInit();
            grpCosting.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblTitle.Location = new Point(26, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(363, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Job Details";
            // 
            // tblMainLayout
            // 
            tblMainLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMainLayout.ColumnCount = 2;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblMainLayout.Controls.Add(pnlLeft, 0, 0);
            tblMainLayout.Controls.Add(pnlRight, 1, 0);
            tblMainLayout.Location = new Point(34, 100);
            tblMainLayout.Margin = new Padding(3, 4, 3, 4);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 1;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMainLayout.Size = new Size(1074, 724);
            tblMainLayout.TabIndex = 1;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(grpStatusUpdate);
            pnlLeft.Controls.Add(grpCustomer);
            pnlLeft.Controls.Add(grpLocations);
            pnlLeft.Controls.Add(grpJobInfo);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(3, 4);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(369, 716);
            pnlLeft.TabIndex = 0;
            // 
            // grpStatusUpdate
            // 
            grpStatusUpdate.Controls.Add(btnUpdateStatus);
            grpStatusUpdate.Controls.Add(cboUpdateStatus);
            grpStatusUpdate.Controls.Add(lblUpdateStatus);
            grpStatusUpdate.Dock = DockStyle.Top;
            grpStatusUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpStatusUpdate.Location = new Point(0, 587);
            grpStatusUpdate.Margin = new Padding(3, 4, 3, 4);
            grpStatusUpdate.Name = "grpStatusUpdate";
            grpStatusUpdate.Padding = new Padding(3, 4, 3, 4);
            grpStatusUpdate.Size = new Size(369, 133);
            grpStatusUpdate.TabIndex = 3;
            grpStatusUpdate.TabStop = false;
            grpStatusUpdate.Text = "Update Status";
            grpStatusUpdate.Visible = false;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.IndianRed;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(126, 73);
            btnUpdateStatus.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(229, 40);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // cboUpdateStatus
            // 
            cboUpdateStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUpdateStatus.Font = new Font("Segoe UI", 9.75F);
            cboUpdateStatus.FormattingEnabled = true;
            cboUpdateStatus.Location = new Point(126, 32);
            cboUpdateStatus.Margin = new Padding(3, 4, 3, 4);
            cboUpdateStatus.Name = "cboUpdateStatus";
            cboUpdateStatus.Size = new Size(228, 29);
            cboUpdateStatus.TabIndex = 1;
            // 
            // lblUpdateStatus
            // 
            lblUpdateStatus.AutoSize = true;
            lblUpdateStatus.Font = new Font("Segoe UI", 9.75F);
            lblUpdateStatus.Location = new Point(15, 36);
            lblUpdateStatus.Name = "lblUpdateStatus";
            lblUpdateStatus.Size = new Size(99, 23);
            lblUpdateStatus.TabIndex = 0;
            lblUpdateStatus.Text = "New Status:";
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(txtCustomerEmail);
            grpCustomer.Controls.Add(label5);
            grpCustomer.Controls.Add(txtCustomerPhone);
            grpCustomer.Controls.Add(label4);
            grpCustomer.Controls.Add(txtCustomerName);
            grpCustomer.Controls.Add(label1);
            grpCustomer.Dock = DockStyle.Top;
            grpCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpCustomer.Location = new Point(0, 414);
            grpCustomer.Margin = new Padding(3, 4, 3, 4);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Padding = new Padding(11, 13, 11, 13);
            grpCustomer.Size = new Size(369, 173);
            grpCustomer.TabIndex = 2;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer Details";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerEmail.BackColor = SystemColors.Control;
            txtCustomerEmail.BorderStyle = BorderStyle.None;
            txtCustomerEmail.Font = new Font("Segoe UI", 9.75F);
            txtCustomerEmail.Location = new Point(126, 120);
            txtCustomerEmail.Margin = new Padding(3, 4, 3, 4);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.ReadOnly = true;
            txtCustomerEmail.Size = new Size(229, 22);
            txtCustomerEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(15, 120);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerPhone.BackColor = SystemColors.Control;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Font = new Font("Segoe UI", 9.75F);
            txtCustomerPhone.Location = new Point(126, 80);
            txtCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.ReadOnly = true;
            txtCustomerPhone.Size = new Size(229, 22);
            txtCustomerPhone.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(15, 80);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 2;
            label4.Text = "Phone:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.BackColor = SystemColors.Control;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Segoe UI", 9.75F);
            txtCustomerName.Location = new Point(126, 40);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(229, 22);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // grpLocations
            // 
            grpLocations.Controls.Add(txtDeliveryAddress);
            grpLocations.Controls.Add(label7);
            grpLocations.Controls.Add(txtPickupAddress);
            grpLocations.Controls.Add(label6);
            grpLocations.Dock = DockStyle.Top;
            grpLocations.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpLocations.Location = new Point(0, 187);
            grpLocations.Margin = new Padding(3, 4, 3, 4);
            grpLocations.Name = "grpLocations";
            grpLocations.Padding = new Padding(11, 13, 11, 13);
            grpLocations.Size = new Size(369, 227);
            grpLocations.TabIndex = 1;
            grpLocations.TabStop = false;
            grpLocations.Text = "Location Details";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeliveryAddress.BackColor = SystemColors.Control;
            txtDeliveryAddress.BorderStyle = BorderStyle.None;
            txtDeliveryAddress.Font = new Font("Segoe UI", 9.75F);
            txtDeliveryAddress.Location = new Point(15, 153);
            txtDeliveryAddress.Margin = new Padding(3, 4, 3, 4);
            txtDeliveryAddress.Multiline = true;
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.ReadOnly = true;
            txtDeliveryAddress.Size = new Size(339, 53);
            txtDeliveryAddress.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(15, 127);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 2;
            label7.Text = "Delivery Address:";
            // 
            // txtPickupAddress
            // 
            txtPickupAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPickupAddress.BackColor = SystemColors.Control;
            txtPickupAddress.BorderStyle = BorderStyle.None;
            txtPickupAddress.Font = new Font("Segoe UI", 9.75F);
            txtPickupAddress.Location = new Point(15, 60);
            txtPickupAddress.Margin = new Padding(3, 4, 3, 4);
            txtPickupAddress.Multiline = true;
            txtPickupAddress.Name = "txtPickupAddress";
            txtPickupAddress.ReadOnly = true;
            txtPickupAddress.Size = new Size(339, 53);
            txtPickupAddress.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(15, 33);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 0;
            label6.Text = "Pickup Address:";
            // 
            // grpJobInfo
            // 
            grpJobInfo.Controls.Add(txtStatus);
            grpJobInfo.Controls.Add(label10);
            grpJobInfo.Controls.Add(txtRequestedDate);
            grpJobInfo.Controls.Add(label9);
            grpJobInfo.Controls.Add(txtJobNumber);
            grpJobInfo.Controls.Add(label8);
            grpJobInfo.Dock = DockStyle.Top;
            grpJobInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpJobInfo.Location = new Point(0, 0);
            grpJobInfo.Margin = new Padding(3, 4, 3, 4);
            grpJobInfo.Name = "grpJobInfo";
            grpJobInfo.Padding = new Padding(11, 13, 11, 13);
            grpJobInfo.Size = new Size(369, 187);
            grpJobInfo.TabIndex = 0;
            grpJobInfo.TabStop = false;
            grpJobInfo.Text = "Job Information";
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.BackColor = SystemColors.Control;
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtStatus.Location = new Point(126, 120);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(229, 22);
            txtStatus.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(15, 120);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 4;
            label10.Text = "Status:";
            // 
            // txtRequestedDate
            // 
            txtRequestedDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRequestedDate.BackColor = SystemColors.Control;
            txtRequestedDate.BorderStyle = BorderStyle.None;
            txtRequestedDate.Font = new Font("Segoe UI", 9.75F);
            txtRequestedDate.Location = new Point(126, 80);
            txtRequestedDate.Margin = new Padding(3, 4, 3, 4);
            txtRequestedDate.Name = "txtRequestedDate";
            txtRequestedDate.ReadOnly = true;
            txtRequestedDate.Size = new Size(229, 22);
            txtRequestedDate.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(15, 80);
            label9.Name = "label9";
            label9.Size = new Size(88, 23);
            label9.TabIndex = 2;
            label9.Text = "Req. Date:";
            // 
            // txtJobNumber
            // 
            txtJobNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtJobNumber.BackColor = SystemColors.Control;
            txtJobNumber.BorderStyle = BorderStyle.None;
            txtJobNumber.Font = new Font("Segoe UI", 9.75F);
            txtJobNumber.Location = new Point(126, 40);
            txtJobNumber.Margin = new Padding(3, 4, 3, 4);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.ReadOnly = true;
            txtJobNumber.Size = new Size(229, 22);
            txtJobNumber.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(15, 40);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 0;
            label8.Text = "Job #:";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpLoads);
            pnlRight.Controls.Add(grpProductsRequested);
            pnlRight.Controls.Add(grpCosting);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(378, 4);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(693, 716);
            pnlRight.TabIndex = 1;
            // 
            // grpLoads
            // 
            grpLoads.Controls.Add(dgvLoads);
            grpLoads.Controls.Add(pnlAddLoad);
            grpLoads.Dock = DockStyle.Fill;
            grpLoads.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpLoads.Location = new Point(0, 173);
            grpLoads.Margin = new Padding(3, 4, 3, 4);
            grpLoads.Name = "grpLoads";
            grpLoads.Padding = new Padding(11, 13, 11, 13);
            grpLoads.Size = new Size(693, 216);
            grpLoads.TabIndex = 1;
            grpLoads.TabStop = false;
            grpLoads.Text = "Create/Manage Loads";
            // 
            // dgvLoads
            // 
            dgvLoads.AllowUserToAddRows = false;
            dgvLoads.AllowUserToDeleteRows = false;
            dgvLoads.BackgroundColor = Color.WhiteSmoke;
            dgvLoads.BorderStyle = BorderStyle.None;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoads.Dock = DockStyle.Fill;
            dgvLoads.Location = new Point(11, 131);
            dgvLoads.Margin = new Padding(3, 4, 3, 4);
            dgvLoads.Name = "dgvLoads";
            dgvLoads.ReadOnly = true;
            dgvLoads.RowHeadersVisible = false;
            dgvLoads.RowHeadersWidth = 51;
            dgvLoads.Size = new Size(671, 72);
            dgvLoads.TabIndex = 1;
            // 
            // pnlAddLoad
            // 
            pnlAddLoad.Controls.Add(label18);
            pnlAddLoad.Controls.Add(label17);
            pnlAddLoad.Controls.Add(label16);
            pnlAddLoad.Controls.Add(btnAddLoad);
            pnlAddLoad.Controls.Add(numLoadVolume);
            pnlAddLoad.Controls.Add(numLoadWeight);
            pnlAddLoad.Controls.Add(txtLoadDescription);
            pnlAddLoad.Dock = DockStyle.Top;
            pnlAddLoad.Location = new Point(11, 35);
            pnlAddLoad.Margin = new Padding(3, 4, 3, 4);
            pnlAddLoad.Name = "pnlAddLoad";
            pnlAddLoad.Size = new Size(671, 96);
            pnlAddLoad.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(413, 24);
            label18.Name = "label18";
            label18.Size = new Size(92, 20);
            label18.TabIndex = 7;
            label18.Text = "Volume (m³)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(267, 24);
            label17.Name = "label17";
            label17.Size = new Size(86, 20);
            label17.TabIndex = 6;
            label17.Text = "Weight (kg)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(8, 24);
            label16.Name = "label16";
            label16.Size = new Size(85, 20);
            label16.TabIndex = 5;
            label16.Text = "Description";
            // 
            // btnAddLoad
            // 
            btnAddLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddLoad.BackColor = Color.DarkGray;
            btnAddLoad.FlatAppearance.BorderSize = 0;
            btnAddLoad.FlatStyle = FlatStyle.Flat;
            btnAddLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddLoad.ForeColor = Color.White;
            btnAddLoad.Location = new Point(551, 47);
            btnAddLoad.Margin = new Padding(3, 4, 3, 4);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Size = new Size(114, 40);
            btnAddLoad.TabIndex = 4;
            btnAddLoad.Text = "Add Load";
            btnAddLoad.UseVisualStyleBackColor = false;
            // 
            // numLoadVolume
            // 
            numLoadVolume.DecimalPlaces = 3;
            numLoadVolume.Font = new Font("Segoe UI", 9.75F);
            numLoadVolume.Location = new Point(409, 51);
            numLoadVolume.Margin = new Padding(3, 4, 3, 4);
            numLoadVolume.Name = "numLoadVolume";
            numLoadVolume.Size = new Size(133, 29);
            numLoadVolume.TabIndex = 3;
            // 
            // numLoadWeight
            // 
            numLoadWeight.DecimalPlaces = 2;
            numLoadWeight.Font = new Font("Segoe UI", 9.75F);
            numLoadWeight.Location = new Point(267, 51);
            numLoadWeight.Margin = new Padding(3, 4, 3, 4);
            numLoadWeight.Name = "numLoadWeight";
            numLoadWeight.Size = new Size(135, 29);
            numLoadWeight.TabIndex = 2;
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLoadDescription.Font = new Font("Segoe UI", 9.75F);
            txtLoadDescription.Location = new Point(11, 51);
            txtLoadDescription.Margin = new Padding(3, 4, 3, 4);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(251, 29);
            txtLoadDescription.TabIndex = 1;
            // 
            // grpProductsRequested
            // 
            grpProductsRequested.Controls.Add(dgvJobProducts);
            grpProductsRequested.Dock = DockStyle.Top;
            grpProductsRequested.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpProductsRequested.Location = new Point(0, 0);
            grpProductsRequested.Margin = new Padding(3, 4, 3, 4);
            grpProductsRequested.Name = "grpProductsRequested";
            grpProductsRequested.Padding = new Padding(11, 13, 11, 13);
            grpProductsRequested.Size = new Size(693, 173);
            grpProductsRequested.TabIndex = 2;
            grpProductsRequested.TabStop = false;
            grpProductsRequested.Text = "Products Requested by Customer";
            // 
            // dgvJobProducts
            // 
            dgvJobProducts.AllowUserToAddRows = false;
            dgvJobProducts.AllowUserToDeleteRows = false;
            dgvJobProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobProducts.BackgroundColor = Color.WhiteSmoke;
            dgvJobProducts.BorderStyle = BorderStyle.None;
            dgvJobProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobProducts.Dock = DockStyle.Fill;
            dgvJobProducts.Location = new Point(11, 35);
            dgvJobProducts.Margin = new Padding(3, 4, 3, 4);
            dgvJobProducts.Name = "dgvJobProducts";
            dgvJobProducts.ReadOnly = true;
            dgvJobProducts.RowHeadersVisible = false;
            dgvJobProducts.RowHeadersWidth = 51;
            dgvJobProducts.Size = new Size(671, 125);
            dgvJobProducts.TabIndex = 0;
            // 
            // grpCosting
            // 
            grpCosting.Controls.Add(btnAssignAndSave);
            grpCosting.Controls.Add(cboTransportUnit);
            grpCosting.Controls.Add(label15);
            grpCosting.Controls.Add(txtEstimatedCost);
            grpCosting.Controls.Add(label14);
            grpCosting.Controls.Add(txtTotalVolume);
            grpCosting.Controls.Add(label13);
            grpCosting.Controls.Add(txtTotalWeight);
            grpCosting.Controls.Add(label12);
            grpCosting.Dock = DockStyle.Bottom;
            grpCosting.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpCosting.Location = new Point(0, 389);
            grpCosting.Margin = new Padding(3, 4, 3, 4);
            grpCosting.Name = "grpCosting";
            grpCosting.Padding = new Padding(11, 13, 11, 13);
            grpCosting.Size = new Size(693, 327);
            grpCosting.TabIndex = 1;
            grpCosting.TabStop = false;
            grpCosting.Text = "Costing and Assignment";
            // 
            // btnAssignAndSave
            // 
            btnAssignAndSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAssignAndSave.BackColor = Color.FromArgb(40, 167, 69);
            btnAssignAndSave.FlatAppearance.BorderSize = 0;
            btnAssignAndSave.FlatStyle = FlatStyle.Flat;
            btnAssignAndSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAssignAndSave.ForeColor = Color.White;
            btnAssignAndSave.Location = new Point(15, 247);
            btnAssignAndSave.Margin = new Padding(3, 4, 3, 4);
            btnAssignAndSave.Name = "btnAssignAndSave";
            btnAssignAndSave.Size = new Size(664, 60);
            btnAssignAndSave.TabIndex = 8;
            btnAssignAndSave.Text = "Assign Unit and Finalize Job";
            btnAssignAndSave.UseVisualStyleBackColor = false;
            // 
            // cboTransportUnit
            // 
            cboTransportUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboTransportUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransportUnit.Font = new Font("Segoe UI", 9.75F);
            cboTransportUnit.FormattingEnabled = true;
            cboTransportUnit.Location = new Point(171, 193);
            cboTransportUnit.Margin = new Padding(3, 4, 3, 4);
            cboTransportUnit.Name = "cboTransportUnit";
            cboTransportUnit.Size = new Size(507, 29);
            cboTransportUnit.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F);
            label15.Location = new Point(15, 197);
            label15.Name = "label15";
            label15.Size = new Size(177, 23);
            label15.TabIndex = 6;
            label15.Text = "Assign Transport Unit:";
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEstimatedCost.BackColor = SystemColors.Control;
            txtEstimatedCost.BorderStyle = BorderStyle.None;
            txtEstimatedCost.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtEstimatedCost.ForeColor = Color.FromArgb(40, 167, 69);
            txtEstimatedCost.Location = new Point(171, 133);
            txtEstimatedCost.Margin = new Padding(3, 4, 3, 4);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.ReadOnly = true;
            txtEstimatedCost.Size = new Size(507, 35);
            txtEstimatedCost.TabIndex = 5;
            txtEstimatedCost.Text = "LKR 0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F);
            label14.Location = new Point(15, 144);
            label14.Name = "label14";
            label14.Size = new Size(128, 23);
            label14.TabIndex = 4;
            label14.Text = "Estimated Cost:";
            // 
            // txtTotalVolume
            // 
            txtTotalVolume.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalVolume.BackColor = SystemColors.Control;
            txtTotalVolume.BorderStyle = BorderStyle.None;
            txtTotalVolume.Font = new Font("Segoe UI", 9.75F);
            txtTotalVolume.Location = new Point(171, 87);
            txtTotalVolume.Margin = new Padding(3, 4, 3, 4);
            txtTotalVolume.Name = "txtTotalVolume";
            txtTotalVolume.ReadOnly = true;
            txtTotalVolume.Size = new Size(507, 22);
            txtTotalVolume.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(15, 87);
            label13.Name = "label13";
            label13.Size = new Size(149, 23);
            label13.TabIndex = 2;
            label13.Text = "Total Volume (m³):";
            // 
            // txtTotalWeight
            // 
            txtTotalWeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalWeight.BackColor = SystemColors.Control;
            txtTotalWeight.BorderStyle = BorderStyle.None;
            txtTotalWeight.Font = new Font("Segoe UI", 9.75F);
            txtTotalWeight.Location = new Point(171, 40);
            txtTotalWeight.Margin = new Padding(3, 4, 3, 4);
            txtTotalWeight.Name = "txtTotalWeight";
            txtTotalWeight.ReadOnly = true;
            txtTotalWeight.Size = new Size(507, 22);
            txtTotalWeight.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(15, 40);
            label12.Name = "label12";
            label12.Size = new Size(142, 23);
            label12.TabIndex = 0;
            label12.Text = "Total Weight (kg):";
            // 
            // JobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255);
            ClientSize = new Size(1143, 867);
            Controls.Add(tblMainLayout);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1159, 903);
            Name = "JobDetailsForm";
            Padding = new Padding(23, 27, 23, 27);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Job Details";
            Load += JobDetailsForm_Load;
            tblMainLayout.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            grpStatusUpdate.ResumeLayout(false);
            grpStatusUpdate.PerformLayout();
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpLocations.ResumeLayout(false);
            grpLocations.PerformLayout();
            grpJobInfo.ResumeLayout(false);
            grpJobInfo.PerformLayout();
            pnlRight.ResumeLayout(false);
            grpLoads.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
            pnlAddLoad.ResumeLayout(false);
            pnlAddLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLoadVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLoadWeight).EndInit();
            grpProductsRequested.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobProducts).EndInit();
            grpCosting.ResumeLayout(false);
            grpCosting.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpJobInfo;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRequestedDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.TextBox txtPickupAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpLoads;
        private System.Windows.Forms.DataGridView dgvLoads;
        private System.Windows.Forms.Panel pnlAddLoad;
        private System.Windows.Forms.TextBox txtLoadDescription;
        private System.Windows.Forms.NumericUpDown numLoadWeight;
        private System.Windows.Forms.NumericUpDown numLoadVolume;
        private System.Windows.Forms.Button btnAddLoad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpCosting;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalVolume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstimatedCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTransportUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAssignAndSave;
        private System.Windows.Forms.GroupBox grpProductsRequested;
        private System.Windows.Forms.DataGridView dgvJobProducts;
        private System.Windows.Forms.GroupBox grpStatusUpdate;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}