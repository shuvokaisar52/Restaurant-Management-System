namespace RestaurantManagement
{
    partial class ManagerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.employeBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCatagory = new RestaurantManagement.AddCatagory();
            this.paymentHistory = new RestaurantManagement.PaymentHistory();
            this.productList = new RestaurantManagement.ProductList();
            this.orderHistory = new RestaurantManagement.OrderHistory();
            this.employeeList = new RestaurantManagement.EmployeeList();
            this.dashboard = new RestaurantManagement.Dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.paymentBtn);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Controls.Add(this.categoryBtn);
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Controls.Add(this.employeBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 529);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutBtn.Location = new System.Drawing.Point(0, 366);
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
            this.paymentBtn.Location = new System.Drawing.Point(0, 324);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(225, 40);
            this.paymentBtn.TabIndex = 13;
            this.paymentBtn.Text = "Payment History";
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.Transparent;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productBtn.Location = new System.Drawing.Point(1, 282);
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
            this.categoryBtn.Location = new System.Drawing.Point(1, 240);
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
            this.orderBtn.Location = new System.Drawing.Point(0, 198);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(225, 40);
            this.orderBtn.TabIndex = 10;
            this.orderBtn.Text = "Order History";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // employeBtn
            // 
            this.employeBtn.BackColor = System.Drawing.Color.Transparent;
            this.employeBtn.FlatAppearance.BorderSize = 0;
            this.employeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeBtn.Location = new System.Drawing.Point(0, 156);
            this.employeBtn.Name = "employeBtn";
            this.employeBtn.Size = new System.Drawing.Size(225, 40);
            this.employeBtn.TabIndex = 9;
            this.employeBtn.Text = "Employee";
            this.employeBtn.UseVisualStyleBackColor = false;
            this.employeBtn.Click += new System.EventHandler(this.EmployeBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Welcome,";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(115, 50);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(60, 16);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Tofayel";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 114);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(225, 40);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addCatagory);
            this.panel2.Controls.Add(this.paymentHistory);
            this.panel2.Controls.Add(this.productList);
            this.panel2.Controls.Add(this.orderHistory);
            this.panel2.Controls.Add(this.employeeList);
            this.panel2.Controls.Add(this.dashboard);
            this.panel2.Location = new System.Drawing.Point(244, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 530);
            this.panel2.TabIndex = 3;
            // 
            // addCatagory
            // 
            this.addCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCatagory.Location = new System.Drawing.Point(0, 0);
            this.addCatagory.Margin = new System.Windows.Forms.Padding(1);
            this.addCatagory.Name = "addCatagory";
            this.addCatagory.Size = new System.Drawing.Size(830, 530);
            this.addCatagory.TabIndex = 5;
            // 
            // paymentHistory
            // 
            this.paymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentHistory.Location = new System.Drawing.Point(0, 0);
            this.paymentHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentHistory.Name = "paymentHistory";
            this.paymentHistory.Size = new System.Drawing.Size(830, 530);
            this.paymentHistory.TabIndex = 4;
            // 
            // productList
            // 
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.Location = new System.Drawing.Point(0, 0);
            this.productList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(830, 530);
            this.productList.TabIndex = 3;
            // 
            // orderHistory
            // 
            this.orderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderHistory.Location = new System.Drawing.Point(0, 0);
            this.orderHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(830, 530);
            this.orderHistory.TabIndex = 2;
            // 
            // employeeList
            // 
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(830, 530);
            this.employeeList.TabIndex = 1;
            // 
            // dashboard
            // 
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(830, 530);
            this.dashboard.TabIndex = 0;
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button employeBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Panel panel2;
        private Dashboard dashboard;
        private EmployeeList employeeList;
        private OrderHistory orderHistory;
        private ProductList productList;
        private PaymentHistory paymentHistory;
        private AddCatagory addCatagory;
    }
}