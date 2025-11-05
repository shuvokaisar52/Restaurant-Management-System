namespace RestaurantManagement
{
    partial class PaymentHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderHistoryGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.payId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.payId,
            this.payAmount,
            this.payType,
            this.orderId,
            this.employeeId,
            this.payTime});
            this.orderHistoryGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderHistoryGrid.Location = new System.Drawing.Point(4, 54);
            this.orderHistoryGrid.Name = "orderHistoryGrid";
            this.orderHistoryGrid.ReadOnly = true;
            this.orderHistoryGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderHistoryGrid.Size = new System.Drawing.Size(823, 472);
            this.orderHistoryGrid.TabIndex = 2;
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
            this.panel1.TabIndex = 3;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(748, 23);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllBtn.TabIndex = 3;
            this.showAllBtn.Text = "show all>>";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(3, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Payment History";
            // 
            // payId
            // 
            this.payId.DataPropertyName = "payId";
            this.payId.HeaderText = "Payment ID";
            this.payId.Name = "payId";
            this.payId.ReadOnly = true;
            // 
            // payAmount
            // 
            this.payAmount.DataPropertyName = "payAmount";
            this.payAmount.HeaderText = "Amount";
            this.payAmount.Name = "payAmount";
            this.payAmount.ReadOnly = true;
            // 
            // payType
            // 
            this.payType.DataPropertyName = "payType";
            this.payType.HeaderText = "Type";
            this.payType.Name = "payType";
            this.payType.ReadOnly = true;
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Order ID";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "Employee ID";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // payTime
            // 
            this.payTime.DataPropertyName = "payTime";
            this.payTime.HeaderText = "Time";
            this.payTime.Name = "payTime";
            this.payTime.ReadOnly = true;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderHistoryGrid);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentHistory";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderHistoryGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn payId;
        private System.Windows.Forms.DataGridViewTextBoxColumn payAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTime;
    }
}
