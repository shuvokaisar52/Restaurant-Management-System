namespace RestaurantManagement
{
    partial class Dashboard
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
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.controlsBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmployeeHistory = new System.Windows.Forms.DataGridView();
            this.eId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysOfWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalSalesAmountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalProductAmountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.totalOrderAmountLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.totalCategoryAmountLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.totalEmployeeAmountLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.todaysSalesLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeHistory)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dashboardPanel.Controls.Add(this.controlsLabel);
            this.dashboardPanel.Controls.Add(this.controlsBox);
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Controls.Add(this.dgvEmployeeHistory);
            this.dashboardPanel.Controls.Add(this.panel5);
            this.dashboardPanel.Controls.Add(this.panel4);
            this.dashboardPanel.Controls.Add(this.panel6);
            this.dashboardPanel.Controls.Add(this.panel7);
            this.dashboardPanel.Controls.Add(this.panel8);
            this.dashboardPanel.Controls.Add(this.panel9);
            this.dashboardPanel.Controls.Add(this.label19);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(830, 530);
            this.dashboardPanel.TabIndex = 2;
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.Location = new System.Drawing.Point(417, 285);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(76, 20);
            this.controlsLabel.TabIndex = 12;
            this.controlsLabel.Text = "Controls";
            // 
            // controlsBox
            // 
            this.controlsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlsBox.Location = new System.Drawing.Point(419, 308);
            this.controlsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.ReadOnly = true;
            this.controlsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.controlsBox.Size = new System.Drawing.Size(380, 200);
            this.controlsBox.TabIndex = 11;
            this.controlsBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee History";
            // 
            // dgvEmployeeHistory
            // 
            this.dgvEmployeeHistory.AllowUserToAddRows = false;
            this.dgvEmployeeHistory.AllowUserToDeleteRows = false;
            this.dgvEmployeeHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEmployeeHistory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployeeHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eId,
            this.sales,
            this.completeOrder,
            this.daysOfWorking});
            this.dgvEmployeeHistory.Location = new System.Drawing.Point(30, 308);
            this.dgvEmployeeHistory.Name = "dgvEmployeeHistory";
            this.dgvEmployeeHistory.RowHeadersWidth = 62;
            this.dgvEmployeeHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeHistory.Size = new System.Drawing.Size(769, 200);
            this.dgvEmployeeHistory.TabIndex = 8;
            // 
            // eId
            // 
            this.eId.DataPropertyName = "eId";
            this.eId.HeaderText = "ID";
            this.eId.MinimumWidth = 8;
            this.eId.Name = "eId";
            // 
            // sales
            // 
            this.sales.DataPropertyName = "sales";
            this.sales.HeaderText = "Total Sales";
            this.sales.MinimumWidth = 8;
            this.sales.Name = "sales";
            // 
            // completeOrder
            // 
            this.completeOrder.DataPropertyName = "completeOrder";
            this.completeOrder.HeaderText = "Complete Order";
            this.completeOrder.MinimumWidth = 8;
            this.completeOrder.Name = "completeOrder";
            // 
            // daysOfWorking
            // 
            this.daysOfWorking.DataPropertyName = "daysOfWorking";
            this.daysOfWorking.HeaderText = "Woking";
            this.daysOfWorking.MinimumWidth = 8;
            this.daysOfWorking.Name = "daysOfWorking";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.HotPink;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.totalSalesAmountLabel);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(560, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 100);
            this.panel5.TabIndex = 6;
            // 
            // totalSalesAmountLabel
            // 
            this.totalSalesAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesAmountLabel.Location = new System.Drawing.Point(0, 55);
            this.totalSalesAmountLabel.Name = "totalSalesAmountLabel";
            this.totalSalesAmountLabel.Size = new System.Drawing.Size(240, 24);
            this.totalSalesAmountLabel.TabIndex = 1;
            this.totalSalesAmountLabel.Text = "00";
            this.totalSalesAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Sales";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.totalProductAmountLabel);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(560, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 100);
            this.panel4.TabIndex = 3;
            // 
            // totalProductAmountLabel
            // 
            this.totalProductAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductAmountLabel.Location = new System.Drawing.Point(0, 55);
            this.totalProductAmountLabel.Name = "totalProductAmountLabel";
            this.totalProductAmountLabel.Size = new System.Drawing.Size(240, 24);
            this.totalProductAmountLabel.TabIndex = 2;
            this.totalProductAmountLabel.Text = "00";
            this.totalProductAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Products";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.totalOrderAmountLabel);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(295, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 100);
            this.panel6.TabIndex = 5;
            // 
            // totalOrderAmountLabel
            // 
            this.totalOrderAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderAmountLabel.Location = new System.Drawing.Point(0, 55);
            this.totalOrderAmountLabel.Name = "totalOrderAmountLabel";
            this.totalOrderAmountLabel.Size = new System.Drawing.Size(240, 24);
            this.totalOrderAmountLabel.TabIndex = 2;
            this.totalOrderAmountLabel.Text = "00";
            this.totalOrderAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Order Complete";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Info;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.totalCategoryAmountLabel);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(295, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 100);
            this.panel7.TabIndex = 2;
            // 
            // totalCategoryAmountLabel
            // 
            this.totalCategoryAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCategoryAmountLabel.Location = new System.Drawing.Point(0, 55);
            this.totalCategoryAmountLabel.Name = "totalCategoryAmountLabel";
            this.totalCategoryAmountLabel.Size = new System.Drawing.Size(240, 24);
            this.totalCategoryAmountLabel.TabIndex = 2;
            this.totalCategoryAmountLabel.Text = "00";
            this.totalCategoryAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total Category";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.totalEmployeeAmountLabel);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(30, 170);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 100);
            this.panel8.TabIndex = 4;
            // 
            // totalEmployeeAmountLabel
            // 
            this.totalEmployeeAmountLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmployeeAmountLabel.Location = new System.Drawing.Point(0, 55);
            this.totalEmployeeAmountLabel.Name = "totalEmployeeAmountLabel";
            this.totalEmployeeAmountLabel.Size = new System.Drawing.Size(240, 24);
            this.totalEmployeeAmountLabel.TabIndex = 2;
            this.totalEmployeeAmountLabel.Text = "00";
            this.totalEmployeeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Employee";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.HotPink;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.todaysSalesLabel);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(30, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(240, 100);
            this.panel9.TabIndex = 1;
            // 
            // todaysSalesLabel
            // 
            this.todaysSalesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysSalesLabel.Location = new System.Drawing.Point(-1, 54);
            this.todaysSalesLabel.Name = "todaysSalesLabel";
            this.todaysSalesLabel.Size = new System.Drawing.Size(240, 24);
            this.todaysSalesLabel.TabIndex = 2;
            this.todaysSalesLabel.Text = "00";
            this.todaysSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(70, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "Today Sales";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(25, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardPanel);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeHistory)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label totalSalesAmountLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label totalCategoryAmountLabel;
        private System.Windows.Forms.Label totalProductAmountLabel;
        private System.Windows.Forms.Label totalOrderAmountLabel;
        private System.Windows.Forms.Label totalEmployeeAmountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmployeeHistory;
        private System.Windows.Forms.Label todaysSalesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn eId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn completeOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysOfWorking;
        private System.Windows.Forms.RichTextBox controlsBox;
        private System.Windows.Forms.Label controlsLabel;
    }
}
