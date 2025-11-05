namespace RestaurantManagement
{
    partial class OrderDetails
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
            this.allproductGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.orderIdBox = new System.Windows.Forms.TextBox();
            this.paymentIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderByBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allproductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allproductGrid
            // 
            this.allproductGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.allproductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allproductGrid.Location = new System.Drawing.Point(276, 12);
            this.allproductGrid.Name = "allproductGrid";
            this.allproductGrid.Size = new System.Drawing.Size(341, 203);
            this.allproductGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID: ";
            // 
            // orderIdBox
            // 
            this.orderIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderIdBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdBox.Location = new System.Drawing.Point(116, 15);
            this.orderIdBox.Name = "orderIdBox";
            this.orderIdBox.ReadOnly = true;
            this.orderIdBox.Size = new System.Drawing.Size(136, 16);
            this.orderIdBox.TabIndex = 2;
            // 
            // paymentIdBox
            // 
            this.paymentIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentIdBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIdBox.Location = new System.Drawing.Point(116, 45);
            this.paymentIdBox.Name = "paymentIdBox";
            this.paymentIdBox.ReadOnly = true;
            this.paymentIdBox.Size = new System.Drawing.Size(136, 16);
            this.paymentIdBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment ID: ";
            // 
            // orderByBox
            // 
            this.orderByBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderByBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByBox.Location = new System.Drawing.Point(116, 75);
            this.orderByBox.Name = "orderByBox";
            this.orderByBox.ReadOnly = true;
            this.orderByBox.Size = new System.Drawing.Size(136, 16);
            this.orderByBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order By: ";
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(116, 105);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(136, 16);
            this.amountBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount: ";
            // 
            // payTypeBox
            // 
            this.payTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payTypeBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTypeBox.Location = new System.Drawing.Point(116, 135);
            this.payTypeBox.Name = "payTypeBox";
            this.payTypeBox.ReadOnly = true;
            this.payTypeBox.Size = new System.Drawing.Size(136, 16);
            this.payTypeBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pay Type: ";
            // 
            // statusBox
            // 
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(116, 167);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(136, 16);
            this.statusBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status: ";
            // 
            // dateBox
            // 
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(116, 199);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(136, 16);
            this.dateBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date: ";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printBtn.Location = new System.Drawing.Point(411, 233);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(100, 30);
            this.printBtn.TabIndex = 15;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(517, 233);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 30);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payTypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderByBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymentIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allproductGrid);
            this.Name = "OrderDetails";
            this.Size = new System.Drawing.Size(630, 276);
            ((System.ComponentModel.ISupportInitialize)(this.allproductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allproductGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIdBox;
        private System.Windows.Forms.TextBox paymentIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderByBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox payTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
