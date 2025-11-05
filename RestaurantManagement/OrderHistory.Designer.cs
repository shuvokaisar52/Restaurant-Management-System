namespace RestaurantManagement
{
    partial class OrderHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistory));
            this.orderHistoryGrid = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDetails = new System.Windows.Forms.Panel();
            this.allProductGrid = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.payTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderByBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.orderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderHistoryGrid
            // 
            this.orderHistoryGrid.AllowUserToAddRows = false;
            this.orderHistoryGrid.AllowUserToDeleteRows = false;
            this.orderHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.orderHistoryGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.orderDate,
            this.productId,
            this.paymentId,
            this.employeeId});
            this.orderHistoryGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.orderHistoryGrid.Name = "orderHistoryGrid";
            this.orderHistoryGrid.ReadOnly = true;
            this.orderHistoryGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderHistoryGrid.Size = new System.Drawing.Size(823, 472);
            this.orderHistoryGrid.TabIndex = 0;
            this.orderHistoryGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderHistoryGrid_CellDoubleClick);
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Order ID";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "orderDate";
            this.orderDate.HeaderText = "Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "Products";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // paymentId
            // 
            this.paymentId.DataPropertyName = "paymentId";
            this.paymentId.HeaderText = "Payment ID";
            this.paymentId.Name = "paymentId";
            this.paymentId.ReadOnly = true;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "Employee ID";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.showAllBtn);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 49);
            this.panel1.TabIndex = 1;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(748, 23);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllBtn.TabIndex = 3;
            this.showAllBtn.Text = "Show all>>";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(3, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Order History";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderDetails);
            this.panel2.Controls.Add(this.orderHistoryGrid);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(823, 475);
            this.panel2.TabIndex = 2;
            // 
            // orderDetails
            // 
            this.orderDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderDetails.Controls.Add(this.allProductGrid);
            this.orderDetails.Controls.Add(this.closeBtn);
            this.orderDetails.Controls.Add(this.button1);
            this.orderDetails.Controls.Add(this.dateBox);
            this.orderDetails.Controls.Add(this.label7);
            this.orderDetails.Controls.Add(this.statusBox);
            this.orderDetails.Controls.Add(this.label6);
            this.orderDetails.Controls.Add(this.payTypeBox);
            this.orderDetails.Controls.Add(this.label5);
            this.orderDetails.Controls.Add(this.amountBox);
            this.orderDetails.Controls.Add(this.label4);
            this.orderDetails.Controls.Add(this.orderByBox);
            this.orderDetails.Controls.Add(this.label3);
            this.orderDetails.Controls.Add(this.paymentIdBox);
            this.orderDetails.Controls.Add(this.label2);
            this.orderDetails.Controls.Add(this.orderIdBox);
            this.orderDetails.Controls.Add(this.label1);
            this.orderDetails.Location = new System.Drawing.Point(100, 100);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(630, 275);
            this.orderDetails.TabIndex = 1;
            // 
            // allProductGrid
            // 
            this.allProductGrid.AllowUserToAddRows = false;
            this.allProductGrid.AllowUserToDeleteRows = false;
            this.allProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allProductGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.allProductGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total,
            this.size,
            this.Qty,
            this.productName,
            this.dataGridViewTextBoxColumn1});
            this.allProductGrid.Location = new System.Drawing.Point(271, 15);
            this.allProductGrid.Name = "allProductGrid";
            this.allProductGrid.ReadOnly = true;
            this.allProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allProductGrid.Size = new System.Drawing.Size(345, 212);
            this.allProductGrid.TabIndex = 34;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(516, 233);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 30);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(410, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateBox
            // 
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(110, 200);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(150, 15);
            this.dateBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date";
            // 
            // statusBox
            // 
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.Color.Green;
            this.statusBox.Location = new System.Drawing.Point(110, 168);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(150, 15);
            this.statusBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Status";
            // 
            // payTypeBox
            // 
            this.payTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payTypeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTypeBox.Location = new System.Drawing.Point(110, 136);
            this.payTypeBox.Name = "payTypeBox";
            this.payTypeBox.ReadOnly = true;
            this.payTypeBox.Size = new System.Drawing.Size(150, 15);
            this.payTypeBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pay Type";
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(110, 106);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(150, 15);
            this.amountBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Amount";
            // 
            // orderByBox
            // 
            this.orderByBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderByBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByBox.Location = new System.Drawing.Point(110, 76);
            this.orderByBox.Name = "orderByBox";
            this.orderByBox.ReadOnly = true;
            this.orderByBox.Size = new System.Drawing.Size(150, 15);
            this.orderByBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Order By";
            // 
            // paymentIdBox
            // 
            this.paymentIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentIdBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIdBox.Location = new System.Drawing.Point(110, 46);
            this.paymentIdBox.Name = "paymentIdBox";
            this.paymentIdBox.ReadOnly = true;
            this.paymentIdBox.Size = new System.Drawing.Size(150, 15);
            this.paymentIdBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Payment ID";
            // 
            // orderIdBox
            // 
            this.orderIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderIdBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdBox.Location = new System.Drawing.Point(110, 16);
            this.orderIdBox.Name = "orderIdBox";
            this.orderIdBox.ReadOnly = true;
            this.orderIdBox.Size = new System.Drawing.Size(150, 15);
            this.orderIdBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order ID";
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Amount";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderHistory";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allProductGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderHistoryGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Panel orderDetails;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox payTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderByBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paymentIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allProductGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
