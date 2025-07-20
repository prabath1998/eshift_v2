namespace eShift_Logistics_System.Forms.Customer
{

    partial class RequestPickupForm
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
            grpLocations = new GroupBox();
            dtpRequestedDate = new DateTimePicker();
            label3 = new Label();
            txtDeliveryAddress = new TextBox();
            label2 = new Label();
            txtPickupAddress = new TextBox();
            label1 = new Label();
            grpProducts = new GroupBox();
            btnAddItem = new Button();
            numQuantity = new NumericUpDown();
            label5 = new Label();
            cboProduct = new ComboBox();
            label4 = new Label();
            grpShipmentList = new GroupBox();
            dgvShipmentItems = new DataGridView();
            btnSubmitRequest = new Button();
            grpNotes = new GroupBox();
            txtNotes = new TextBox();
            grpLocations.SuspendLayout();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            grpShipmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).BeginInit();
            grpNotes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblTitle.Location = new Point(26, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Pickup Request";
            // 
            // grpLocations
            // 
            grpLocations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLocations.Controls.Add(dtpRequestedDate);
            grpLocations.Controls.Add(label3);
            grpLocations.Controls.Add(txtDeliveryAddress);
            grpLocations.Controls.Add(label2);
            grpLocations.Controls.Add(txtPickupAddress);
            grpLocations.Controls.Add(label1);
            grpLocations.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpLocations.Location = new Point(34, 93);
            grpLocations.Margin = new Padding(3, 4, 3, 4);
            grpLocations.Name = "grpLocations";
            grpLocations.Padding = new Padding(3, 4, 3, 4);
            grpLocations.Size = new Size(931, 207);
            grpLocations.TabIndex = 0;
            grpLocations.TabStop = false;
            grpLocations.Text = "1. Location and Date";
            // 
            // dtpRequestedDate
            // 
            dtpRequestedDate.Font = new Font("Segoe UI", 9.75F);
            dtpRequestedDate.Location = new Point(160, 153);
            dtpRequestedDate.Margin = new Padding(3, 4, 3, 4);
            dtpRequestedDate.Name = "dtpRequestedDate";
            dtpRequestedDate.Size = new Size(285, 29);
            dtpRequestedDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(23, 160);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 4;
            label3.Text = "Requested Date";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeliveryAddress.Font = new Font("Segoe UI", 9.75F);
            txtDeliveryAddress.Location = new Point(537, 40);
            txtDeliveryAddress.Margin = new Padding(3, 4, 3, 4);
            txtDeliveryAddress.Multiline = true;
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(371, 92);
            txtDeliveryAddress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(406, 44);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 2;
            label2.Text = "Delivery Address";
            // 
            // txtPickupAddress
            // 
            txtPickupAddress.Font = new Font("Segoe UI", 9.75F);
            txtPickupAddress.Location = new Point(160, 40);
            txtPickupAddress.Margin = new Padding(3, 4, 3, 4);
            txtPickupAddress.Multiline = true;
            txtPickupAddress.Name = "txtPickupAddress";
            txtPickupAddress.Size = new Size(228, 92);
            txtPickupAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 0;
            label1.Text = "Pickup Address";
            // 
            // grpProducts
            // 
            grpProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpProducts.Controls.Add(btnAddItem);
            grpProducts.Controls.Add(numQuantity);
            grpProducts.Controls.Add(label5);
            grpProducts.Controls.Add(cboProduct);
            grpProducts.Controls.Add(label4);
            grpProducts.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpProducts.Location = new Point(34, 313);
            grpProducts.Margin = new Padding(3, 4, 3, 4);
            grpProducts.Name = "grpProducts";
            grpProducts.Padding = new Padding(3, 4, 3, 4);
            grpProducts.Size = new Size(931, 100);
            grpProducts.TabIndex = 1;
            grpProducts.TabStop = false;
            grpProducts.Text = "2. Add Products to Shipment";
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.BackColor = Color.IndianRed;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(783, 40);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 40);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 9.75F);
            numQuantity.Location = new Point(423, 44);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(137, 29);
            numQuantity.TabIndex = 1;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(349, 48);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 2;
            label5.Text = "Quantity";
            // 
            // cboProduct
            // 
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.Font = new Font("Segoe UI", 9.75F);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(91, 44);
            cboProduct.Margin = new Padding(3, 4, 3, 4);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(239, 29);
            cboProduct.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(23, 48);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 0;
            label4.Text = "Product";
            // 
            // grpShipmentList
            // 
            grpShipmentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpShipmentList.Controls.Add(dgvShipmentItems);
            grpShipmentList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpShipmentList.Location = new Point(34, 427);
            grpShipmentList.Margin = new Padding(3, 4, 3, 4);
            grpShipmentList.Name = "grpShipmentList";
            grpShipmentList.Padding = new Padding(11, 13, 11, 13);
            grpShipmentList.Size = new Size(931, 134);
            grpShipmentList.TabIndex = 2;
            grpShipmentList.TabStop = false;
            grpShipmentList.Text = "3. Shipment Item List";
            // 
            // dgvShipmentItems
            // 
            dgvShipmentItems.AllowUserToAddRows = false;
            dgvShipmentItems.AllowUserToDeleteRows = false;
            dgvShipmentItems.BackgroundColor = Color.White;
            dgvShipmentItems.BorderStyle = BorderStyle.None;
            dgvShipmentItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipmentItems.Dock = DockStyle.Fill;
            dgvShipmentItems.Location = new Point(11, 35);
            dgvShipmentItems.Margin = new Padding(3, 4, 3, 4);
            dgvShipmentItems.Name = "dgvShipmentItems";
            dgvShipmentItems.ReadOnly = true;
            dgvShipmentItems.RowHeadersVisible = false;
            dgvShipmentItems.RowHeadersWidth = 51;
            dgvShipmentItems.Size = new Size(909, 86);
            dgvShipmentItems.TabIndex = 0;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmitRequest.BackColor = Color.IndianRed;
            btnSubmitRequest.FlatAppearance.BorderSize = 0;
            btnSubmitRequest.FlatStyle = FlatStyle.Flat;
            btnSubmitRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(34, 689);
            btnSubmitRequest.Margin = new Padding(3, 4, 3, 4);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(931, 67);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Request Pickup";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            // 
            // grpNotes
            // 
            grpNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNotes.Controls.Add(txtNotes);
            grpNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpNotes.Location = new Point(34, 574);
            grpNotes.Margin = new Padding(3, 4, 3, 4);
            grpNotes.Name = "grpNotes";
            grpNotes.Padding = new Padding(11, 13, 11, 13);
            grpNotes.Size = new Size(931, 107);
            grpNotes.TabIndex = 3;
            grpNotes.TabStop = false;
            grpNotes.Text = "4. Additional Notes / Description";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = new Font("Segoe UI", 9.75F);
            txtNotes.Location = new Point(11, 35);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(909, 59);
            txtNotes.TabIndex = 0;
            // 
            // RequestPickupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255);
            ClientSize = new Size(1000, 800);
            Controls.Add(grpNotes);
            Controls.Add(btnSubmitRequest);
            Controls.Add(grpShipmentList);
            Controls.Add(grpProducts);
            Controls.Add(grpLocations);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RequestPickupForm";
            Padding = new Padding(34, 40, 34, 40);
            Text = "RequestPickupForm";
            Load += RequestPickupForm_Load;
            grpLocations.ResumeLayout(false);
            grpLocations.PerformLayout();
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            grpShipmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).EndInit();
            grpNotes.ResumeLayout(false);
            grpNotes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.TextBox txtPickupAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRequestedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpShipmentList;
        private System.Windows.Forms.DataGridView dgvShipmentItems;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}