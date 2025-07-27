using System.Drawing.Drawing2D; // Needed for GraphicsPath for rounded rectangles
using eShift_Logistics_System.Properties;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            grpLocations = new GroupBox();
            pnlDtpRequestedDate = new Panel();
            dtpRequestedDate = new DateTimePicker();
            label3 = new Label();
            pnlTxtDeliveryAddress = new Panel();
            txtDeliveryAddress = new TextBox();
            label2 = new Label();
            pnlTxtPickupAddress = new Panel();
            txtPickupAddress = new TextBox();
            label1 = new Label();
            grpProducts = new GroupBox();
            btnAddItem = new Button();
            pnlNumQuantity = new Panel();
            numQuantity = new NumericUpDown();
            label5 = new Label();
            pnlCboProduct = new Panel();
            cboProduct = new ComboBox();
            label4 = new Label();
            grpShipmentList = new GroupBox();
            dgvShipmentItems = new DataGridView();
            btnSubmitRequest = new Button();
            grpNotes = new GroupBox();
            pnlTxtNotes = new Panel();
            txtNotes = new TextBox();
            grpLocations.SuspendLayout();
            pnlDtpRequestedDate.SuspendLayout();
            pnlTxtDeliveryAddress.SuspendLayout();
            pnlTxtPickupAddress.SuspendLayout();
            grpProducts.SuspendLayout();
            pnlNumQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            pnlCboProduct.SuspendLayout();
            grpShipmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).BeginInit();
            grpNotes.SuspendLayout();
            pnlTxtNotes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitle.Location = new Point(34, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Pickup Request";
            // 
            // grpLocations
            // 
            grpLocations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLocations.BackColor = Color.White;
            grpLocations.Controls.Add(pnlDtpRequestedDate);
            grpLocations.Controls.Add(label3);
            grpLocations.Controls.Add(pnlTxtDeliveryAddress);
            grpLocations.Controls.Add(label2);
            grpLocations.Controls.Add(pnlTxtPickupAddress);
            grpLocations.Controls.Add(label1);
            grpLocations.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            grpLocations.ForeColor = Color.FromArgb(51, 51, 51);
            grpLocations.Location = new Point(34, 110);
            grpLocations.Margin = new Padding(3, 4, 3, 4);
            grpLocations.Name = "grpLocations";
            grpLocations.Padding = new Padding(15);
            grpLocations.Size = new Size(1031, 207);
            grpLocations.TabIndex = 0;
            grpLocations.TabStop = false;
            grpLocations.Text = "1. Location and Date";
            // 
            // pnlDtpRequestedDate
            // 
            pnlDtpRequestedDate.BackColor = Color.White;
            pnlDtpRequestedDate.Controls.Add(dtpRequestedDate);
            pnlDtpRequestedDate.Location = new Point(160, 153);
            pnlDtpRequestedDate.Name = "pnlDtpRequestedDate";
            pnlDtpRequestedDate.Size = new Size(285, 38);
            pnlDtpRequestedDate.TabIndex = 2;
            // 
            // dtpRequestedDate
            // 
            dtpRequestedDate.Font = new Font("Segoe UI", 9.75F);
            dtpRequestedDate.Location = new Point(5, 5);
            dtpRequestedDate.Margin = new Padding(3, 4, 3, 4);
            dtpRequestedDate.Name = "dtpRequestedDate";
            dtpRequestedDate.Size = new Size(275, 29);
            dtpRequestedDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(85, 85, 85);
            label3.Location = new Point(23, 160);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 4;
            label3.Text = "Requested Date:";
            // 
            // pnlTxtDeliveryAddress
            // 
            pnlTxtDeliveryAddress.BackColor = Color.White;
            pnlTxtDeliveryAddress.Controls.Add(txtDeliveryAddress);
            pnlTxtDeliveryAddress.Location = new Point(537, 40);
            pnlTxtDeliveryAddress.Name = "pnlTxtDeliveryAddress";
            pnlTxtDeliveryAddress.Size = new Size(371, 92);
            pnlTxtDeliveryAddress.TabIndex = 1;
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeliveryAddress.BorderStyle = BorderStyle.None;
            txtDeliveryAddress.Font = new Font("Segoe UI", 9.75F);
            txtDeliveryAddress.Location = new Point(5, 5);
            txtDeliveryAddress.Margin = new Padding(3, 4, 3, 4);
            txtDeliveryAddress.Multiline = true;
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(361, 82);
            txtDeliveryAddress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(85, 85, 85);
            label2.Location = new Point(406, 44);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Delivery Address:";
            // 
            // pnlTxtPickupAddress
            // 
            pnlTxtPickupAddress.BackColor = Color.White;
            pnlTxtPickupAddress.Controls.Add(txtPickupAddress);
            pnlTxtPickupAddress.Location = new Point(160, 40);
            pnlTxtPickupAddress.Name = "pnlTxtPickupAddress";
            pnlTxtPickupAddress.Size = new Size(228, 92);
            pnlTxtPickupAddress.TabIndex = 0;
            // 
            // txtPickupAddress
            // 
            txtPickupAddress.BorderStyle = BorderStyle.None;
            txtPickupAddress.Font = new Font("Segoe UI", 9.75F);
            txtPickupAddress.Location = new Point(5, 5);
            txtPickupAddress.Margin = new Padding(3, 4, 3, 4);
            txtPickupAddress.Multiline = true;
            txtPickupAddress.Name = "txtPickupAddress";
            txtPickupAddress.Size = new Size(218, 82);
            txtPickupAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(85, 85, 85);
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 0;
            label1.Text = "Pickup Address:";
            // 
            // grpProducts
            // 
            grpProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpProducts.BackColor = Color.White;
            grpProducts.Controls.Add(btnAddItem);
            grpProducts.Controls.Add(pnlNumQuantity);
            grpProducts.Controls.Add(label5);
            grpProducts.Controls.Add(pnlCboProduct);
            grpProducts.Controls.Add(label4);
            grpProducts.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            grpProducts.ForeColor = Color.FromArgb(51, 51, 51);
            grpProducts.Location = new Point(34, 330);
            grpProducts.Margin = new Padding(3, 4, 3, 4);
            grpProducts.Name = "grpProducts";
            grpProducts.Padding = new Padding(15);
            grpProducts.Size = new Size(1031, 100);
            grpProducts.TabIndex = 1;
            grpProducts.TabStop = false;
            grpProducts.Text = "2. Add Products to Shipment";
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.BackColor = Color.FromArgb(220, 53, 69);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(883, 40);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 40);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // pnlNumQuantity
            // 
            pnlNumQuantity.BackColor = Color.White;
            pnlNumQuantity.Controls.Add(numQuantity);
            pnlNumQuantity.Location = new Point(423, 40);
            pnlNumQuantity.Name = "pnlNumQuantity";
            pnlNumQuantity.Size = new Size(137, 38);
            pnlNumQuantity.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 9.75F);
            numQuantity.Location = new Point(5, 5);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(127, 29);
            numQuantity.TabIndex = 1;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(85, 85, 85);
            label5.Location = new Point(349, 48);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 2;
            label5.Text = "Quantity:";
            // 
            // pnlCboProduct
            // 
            pnlCboProduct.BackColor = Color.White;
            pnlCboProduct.Controls.Add(cboProduct);
            pnlCboProduct.Location = new Point(91, 40);
            pnlCboProduct.Name = "pnlCboProduct";
            pnlCboProduct.Size = new Size(239, 38);
            pnlCboProduct.TabIndex = 0;
            // 
            // cboProduct
            // 
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.Font = new Font("Segoe UI", 9.75F);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(5, 5);
            cboProduct.Margin = new Padding(3, 4, 3, 4);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(229, 29);
            cboProduct.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(85, 85, 85);
            label4.Location = new Point(23, 48);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 0;
            label4.Text = "Product:";
            // 
            // grpShipmentList
            // 
            grpShipmentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpShipmentList.BackColor = Color.White;
            grpShipmentList.Controls.Add(dgvShipmentItems);
            grpShipmentList.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            grpShipmentList.ForeColor = Color.FromArgb(51, 51, 51);
            grpShipmentList.Location = new Point(34, 447);
            grpShipmentList.Margin = new Padding(3, 4, 3, 4);
            grpShipmentList.Name = "grpShipmentList";
            grpShipmentList.Padding = new Padding(15);
            grpShipmentList.Size = new Size(1031, 351);
            grpShipmentList.TabIndex = 2;
            grpShipmentList.TabStop = false;
            grpShipmentList.Text = "3. Shipment Item List";
            // 
            // dgvShipmentItems
            // 
            dgvShipmentItems.AllowUserToAddRows = false;
            dgvShipmentItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dgvShipmentItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvShipmentItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipmentItems.BackgroundColor = Color.White;
            dgvShipmentItems.BorderStyle = BorderStyle.None;
            dgvShipmentItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvShipmentItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvShipmentItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvShipmentItems.ColumnHeadersHeight = 100;
            dgvShipmentItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvShipmentItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvShipmentItems.Dock = DockStyle.Fill;
            dgvShipmentItems.EnableHeadersVisualStyles = false;
            dgvShipmentItems.Location = new Point(15, 39);
            dgvShipmentItems.Margin = new Padding(3, 4, 3, 4);
            dgvShipmentItems.Name = "dgvShipmentItems";
            dgvShipmentItems.ReadOnly = true;
            dgvShipmentItems.RowHeadersVisible = true;
            dgvShipmentItems.RowHeadersWidth = 51;
            dgvShipmentItems.Size = new Size(1001, 400);
            dgvShipmentItems.TabIndex = 0;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmitRequest.BackColor = Color.FromArgb(220, 53, 69);
            btnSubmitRequest.FlatAppearance.BorderSize = 0;
            btnSubmitRequest.FlatStyle = FlatStyle.Flat;
            btnSubmitRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(34, 945);
            btnSubmitRequest.Margin = new Padding(3, 4, 3, 4);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(229, 68);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Request Pickup";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            // 
            // grpNotes
            // 
            grpNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNotes.BackColor = Color.White;
            grpNotes.Controls.Add(pnlTxtNotes);
            grpNotes.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            grpNotes.ForeColor = Color.FromArgb(51, 51, 51);
            grpNotes.Location = new Point(34, 821);
            grpNotes.Margin = new Padding(3, 4, 3, 4);
            grpNotes.Name = "grpNotes";
            grpNotes.Padding = new Padding(15);
            grpNotes.Size = new Size(728, 107);
            grpNotes.TabIndex = 3;
            grpNotes.TabStop = false;
            grpNotes.Text = "4. Additional Notes / Description";
            // 
            // pnlTxtNotes
            // 
            pnlTxtNotes.BackColor = Color.White;
            pnlTxtNotes.Controls.Add(txtNotes);
            pnlTxtNotes.Dock = DockStyle.Fill;
            pnlTxtNotes.Location = new Point(15, 39);
            pnlTxtNotes.Name = "pnlTxtNotes";
            pnlTxtNotes.Size = new Size(698, 53);
            pnlTxtNotes.TabIndex = 0;
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = new Font("Segoe UI", 9.75F);
            txtNotes.Location = new Point(0, 0);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(698, 53);
            txtNotes.TabIndex = 0;
            // 
            // RequestPickupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 255);
            ClientSize = new Size(1100, 1102);
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
            pnlDtpRequestedDate.ResumeLayout(false);
            pnlTxtDeliveryAddress.ResumeLayout(false);
            pnlTxtDeliveryAddress.PerformLayout();
            pnlTxtPickupAddress.ResumeLayout(false);
            pnlTxtPickupAddress.PerformLayout();
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            pnlNumQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            pnlCboProduct.ResumeLayout(false);
            grpShipmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShipmentItems).EndInit();
            grpNotes.ResumeLayout(false);
            pnlTxtNotes.ResumeLayout(false);
            pnlTxtNotes.PerformLayout();
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
        private Panel pnlDtpRequestedDate;
        private Panel pnlTxtDeliveryAddress;
        private Panel pnlTxtPickupAddress;
        private Panel pnlNumQuantity;
        private Panel pnlCboProduct;
        private Panel pnlTxtNotes;
    }
}
