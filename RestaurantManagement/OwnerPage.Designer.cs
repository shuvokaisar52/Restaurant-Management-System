namespace RestaurantManagement
{
    partial class OwnerPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.paymentMethodBtn = new System.Windows.Forms.Button();
            this.orderHistoryBtn = new System.Windows.Forms.Button();
            this.paymentHistoryBtn = new System.Windows.Forms.Button();
            this.discountBtn = new System.Windows.Forms.Button();
            this.controlsBtn = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.employeBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentMethodsList = new RestaurantManagement.PaymentMethodsList();
            this.addCatagory = new RestaurantManagement.AddCatagory();
            this.dashboard1 = new RestaurantManagement.Dashboard();
            this.orderHistory = new RestaurantManagement.OrderHistory();
            this.discountList = new RestaurantManagement.DiscountList();
            this.managerList = new RestaurantManagement.ManagerList();
            this.employeeList = new RestaurantManagement.EmployeeList();
            this.productList = new RestaurantManagement.ProductList();
            this.paymentHistory = new RestaurantManagement.PaymentHistory();
            this.panel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonPanel);
            this.panel1.Controls.Add(this.discountBtn);
            this.panel1.Controls.Add(this.controlsBtn);
            this.panel1.Controls.Add(this.managerBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.categoryBtn);
            this.panel1.Controls.Add(this.employeBtn);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 530);
            this.panel1.TabIndex = 54;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.paymentMethodBtn);
            this.buttonPanel.Controls.Add(this.orderHistoryBtn);
            this.buttonPanel.Controls.Add(this.paymentHistoryBtn);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 352);
            this.buttonPanel.MaximumSize = new System.Drawing.Size(225, 125);
            this.buttonPanel.MinimumSize = new System.Drawing.Size(225, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(225, 10);
            this.buttonPanel.TabIndex = 600;
            this.buttonPanel.Visible = false;
            // 
            // paymentMethodBtn
            // 
            this.paymentMethodBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paymentMethodBtn.FlatAppearance.BorderSize = 0;
            this.paymentMethodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentMethodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodBtn.ForeColor = System.Drawing.Color.Black;
            this.paymentMethodBtn.Location = new System.Drawing.Point(0, -2);
            this.paymentMethodBtn.Name = "paymentMethodBtn";
            this.paymentMethodBtn.Size = new System.Drawing.Size(225, 40);
            this.paymentMethodBtn.TabIndex = 62;
            this.paymentMethodBtn.Text = "Payment Methods";
            this.paymentMethodBtn.UseVisualStyleBackColor = false;
            this.paymentMethodBtn.Click += new System.EventHandler(this.paymentMethodBtn_Click);
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.orderHistoryBtn.FlatAppearance.BorderSize = 0;
            this.orderHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.ForeColor = System.Drawing.Color.Black;
            this.orderHistoryBtn.Location = new System.Drawing.Point(0, 82);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(225, 40);
            this.orderHistoryBtn.TabIndex = 61;
            this.orderHistoryBtn.Text = "Order History";
            this.orderHistoryBtn.UseVisualStyleBackColor = false;
            this.orderHistoryBtn.Click += new System.EventHandler(this.OrderHistoryBtn_Click);
            // 
            // paymentHistoryBtn
            // 
            this.paymentHistoryBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paymentHistoryBtn.FlatAppearance.BorderSize = 0;
            this.paymentHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentHistoryBtn.ForeColor = System.Drawing.Color.Black;
            this.paymentHistoryBtn.Location = new System.Drawing.Point(0, 40);
            this.paymentHistoryBtn.Name = "paymentHistoryBtn";
            this.paymentHistoryBtn.Size = new System.Drawing.Size(225, 40);
            this.paymentHistoryBtn.TabIndex = 60;
            this.paymentHistoryBtn.Text = "Payment Histoy";
            this.paymentHistoryBtn.UseVisualStyleBackColor = false;
            this.paymentHistoryBtn.Click += new System.EventHandler(this.PaymentHistoryBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.BackColor = System.Drawing.Color.Transparent;
            this.discountBtn.FlatAppearance.BorderSize = 0;
            this.discountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.discountBtn.Location = new System.Drawing.Point(-1, 267);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(225, 40);
            this.discountBtn.TabIndex = 63;
            this.discountBtn.Text = "Discount";
            this.discountBtn.UseVisualStyleBackColor = false;
            this.discountBtn.Click += new System.EventHandler(this.DiscountBtn_Click);
            // 
            // controlsBtn
            // 
            this.controlsBtn.BackColor = System.Drawing.Color.Transparent;
            this.controlsBtn.FlatAppearance.BorderSize = 0;
            this.controlsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlsBtn.Location = new System.Drawing.Point(-1, 311);
            this.controlsBtn.Name = "controlsBtn";
            this.controlsBtn.Size = new System.Drawing.Size(225, 40);
            this.controlsBtn.TabIndex = 59;
            this.controlsBtn.Text = "Controls";
            this.controlsBtn.UseVisualStyleBackColor = false;
            this.controlsBtn.Click += new System.EventHandler(this.ControlsBtn_Click);
            // 
            // managerBtn
            // 
            this.managerBtn.BackColor = System.Drawing.Color.Transparent;
            this.managerBtn.FlatAppearance.BorderSize = 0;
            this.managerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.managerBtn.Location = new System.Drawing.Point(-1, 95);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(225, 40);
            this.managerBtn.TabIndex = 62;
            this.managerBtn.Text = "Manager";
            this.managerBtn.UseVisualStyleBackColor = false;
            this.managerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutBtn.Location = new System.Drawing.Point(-1, 489);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(225, 40);
            this.logoutBtn.TabIndex = 61;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Welcome,";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(119, 20);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(60, 16);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Tofayel";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Snow;
            this.dashboardBtn.Location = new System.Drawing.Point(-1, 54);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(225, 40);
            this.dashboardBtn.TabIndex = 55;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryBtn.Location = new System.Drawing.Point(-1, 223);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(225, 40);
            this.categoryBtn.TabIndex = 58;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // employeBtn
            // 
            this.employeBtn.BackColor = System.Drawing.Color.Transparent;
            this.employeBtn.FlatAppearance.BorderSize = 0;
            this.employeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeBtn.Location = new System.Drawing.Point(-1, 137);
            this.employeBtn.Name = "employeBtn";
            this.employeBtn.Size = new System.Drawing.Size(225, 40);
            this.employeBtn.TabIndex = 56;
            this.employeBtn.Text = "Employee";
            this.employeBtn.UseVisualStyleBackColor = false;
            this.employeBtn.Click += new System.EventHandler(this.EmployeBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.Transparent;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productBtn.Location = new System.Drawing.Point(-1, 181);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(225, 40);
            this.productBtn.TabIndex = 57;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paymentMethodsList);
            this.panel2.Controls.Add(this.addCatagory);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Controls.Add(this.orderHistory);
            this.panel2.Controls.Add(this.discountList);
            this.panel2.Controls.Add(this.managerList);
            this.panel2.Controls.Add(this.employeeList);
            this.panel2.Controls.Add(this.productList);
            this.panel2.Controls.Add(this.paymentHistory);
            this.panel2.Location = new System.Drawing.Point(243, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 530);
            this.panel2.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // paymentMethodsList
            // 
            this.paymentMethodsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentMethodsList.Location = new System.Drawing.Point(0, 0);
            this.paymentMethodsList.Name = "paymentMethodsList";
            this.paymentMethodsList.Size = new System.Drawing.Size(830, 530);
            this.paymentMethodsList.TabIndex = 8;
            // 
            // addCatagory
            // 
            this.addCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCatagory.Location = new System.Drawing.Point(0, 0);
            this.addCatagory.Margin = new System.Windows.Forms.Padding(2);
            this.addCatagory.Name = "addCatagory";
            this.addCatagory.Size = new System.Drawing.Size(830, 530);
            this.addCatagory.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(830, 530);
            this.dashboard1.TabIndex = 6;
            // 
            // orderHistory
            // 
            this.orderHistory.Location = new System.Drawing.Point(0, 0);
            this.orderHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(830, 530);
            this.orderHistory.TabIndex = 3;
            // 
            // discountList
            // 
            this.discountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountList.Location = new System.Drawing.Point(0, 0);
            this.discountList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountList.Name = "discountList";
            this.discountList.Size = new System.Drawing.Size(830, 530);
            this.discountList.TabIndex = 2;
            // 
            // managerList
            // 
            this.managerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerList.Location = new System.Drawing.Point(0, 0);
            this.managerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.managerList.Name = "managerList";
            this.managerList.Size = new System.Drawing.Size(830, 530);
            this.managerList.TabIndex = 1;
            // 
            // employeeList
            // 
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(830, 530);
            this.employeeList.TabIndex = 0;
            // 
            // productList
            // 
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.Location = new System.Drawing.Point(0, 0);
            this.productList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(830, 530);
            this.productList.TabIndex = 5;
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
            // 
            // OwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button controlsBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button employeBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button orderHistoryBtn;
        private System.Windows.Forms.Button paymentHistoryBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EmployeeList employeeList;
        private ManagerList managerList;
        private System.Windows.Forms.Button discountBtn;
        private DiscountList discountList;
        private OrderHistory orderHistory;
        private PaymentHistory paymentHistory;
        private ProductList productList;
        private Dashboard dashboard1;
        private AddCatagory addCatagory;
        private System.Windows.Forms.Button paymentMethodBtn;
        private PaymentMethodsList paymentMethodsList;
    }
}