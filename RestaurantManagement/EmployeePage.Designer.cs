namespace RestaurantManagement
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paymentHistory = new RestaurantManagement.PaymentHistory();
            this.orderHistory = new RestaurantManagement.OrderHistory();
            this.showCategory = new RestaurantManagement.ShowCategory();
            this.allProductShow = new RestaurantManagement.AllProductShow();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.paymentBtn);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Controls.Add(this.categoryBtn);
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 533);
            this.panel1.TabIndex = 4;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutBtn.Location = new System.Drawing.Point(0, 285);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(225, 40);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentBtn.FlatAppearance.BorderSize = 0;
            this.paymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentBtn.Location = new System.Drawing.Point(-1, 241);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(225, 40);
            this.paymentBtn.TabIndex = 13;
            this.paymentBtn.Text = "Payment History";
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productBtn.Location = new System.Drawing.Point(-1, 112);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(225, 40);
            this.productBtn.TabIndex = 12;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryBtn.Location = new System.Drawing.Point(-1, 153);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(225, 40);
            this.categoryBtn.TabIndex = 11;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.Transparent;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderBtn.Location = new System.Drawing.Point(0, 197);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(225, 40);
            this.orderBtn.TabIndex = 10;
            this.orderBtn.Text = "Order History";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Welcome,";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(115, 50);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(62, 16);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Tofayel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paymentHistory);
            this.panel2.Controls.Add(this.orderHistory);
            this.panel2.Controls.Add(this.showCategory);
            this.panel2.Controls.Add(this.allProductShow);
            this.panel2.Location = new System.Drawing.Point(244, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 533);
            this.panel2.TabIndex = 5;
            // 
            // paymentHistory
            // 
            this.paymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentHistory.Location = new System.Drawing.Point(0, 0);
            this.paymentHistory.Name = "paymentHistory";
            this.paymentHistory.Size = new System.Drawing.Size(829, 533);
            this.paymentHistory.TabIndex = 4;
            // 
            // orderHistory
            // 
            this.orderHistory.BackColor = System.Drawing.Color.AliceBlue;
            this.orderHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderHistory.Location = new System.Drawing.Point(0, 0);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(829, 533);
            this.orderHistory.TabIndex = 3;
            // 
            // showCategory
            // 
            this.showCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCategory.Location = new System.Drawing.Point(0, 0);
            this.showCategory.Name = "showCategory";
            this.showCategory.Size = new System.Drawing.Size(829, 533);
            this.showCategory.TabIndex = 2;
            // 
            // allProductShow
            // 
            this.allProductShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProductShow.Location = new System.Drawing.Point(0, 0);
            this.allProductShow.Name = "allProductShow";
            this.allProductShow.Size = new System.Drawing.Size(829, 533);
            this.allProductShow.TabIndex = 1;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1085, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel panel2;
        private AllProductShow allProductShow;
        private ShowCategory showCategory;
        private OrderHistory orderHistory;
        private PaymentHistory paymentHistory;
    }
}