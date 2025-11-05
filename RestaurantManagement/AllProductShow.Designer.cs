namespace RestaurantManagement
{
    partial class AllProductShow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.showProductFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dicountCodeBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.givediscountCodeBtn = new System.Windows.Forms.Button();
            this.discountBtn = new System.Windows.Forms.Button();
            this.goBuyBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.semiTotalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTaxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discountAmountBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.totalAmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPreferences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 45);
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(4, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "All Products";
            // 
            // showProductFlowLayout
            // 
            this.showProductFlowLayout.Location = new System.Drawing.Point(0, 38);
            this.showProductFlowLayout.Name = "showProductFlowLayout";
            this.showProductFlowLayout.Size = new System.Drawing.Size(532, 443);
            this.showProductFlowLayout.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dicountCodeBox);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.givediscountCodeBtn);
            this.panel2.Controls.Add(this.discountBtn);
            this.panel2.Controls.Add(this.goBuyBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.semiTotalBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.totalTaxBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.discountAmountBox);
            this.panel2.Controls.Add(this.discountLabel);
            this.panel2.Controls.Add(this.totalAmountBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Location = new System.Drawing.Point(525, 48);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(300, 481);
            this.panel2.TabIndex = 2;
            // 
            // dicountCodeBox
            // 
            this.dicountCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dicountCodeBox.Location = new System.Drawing.Point(195, 355);
            this.dicountCodeBox.Name = "dicountCodeBox";
            this.dicountCodeBox.Size = new System.Drawing.Size(75, 20);
            this.dicountCodeBox.TabIndex = 50;
            this.dicountCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(43, 441);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 30);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // givediscountCodeBtn
            // 
            this.givediscountCodeBtn.Location = new System.Drawing.Point(275, 355);
            this.givediscountCodeBtn.Name = "givediscountCodeBtn";
            this.givediscountCodeBtn.Size = new System.Drawing.Size(20, 20);
            this.givediscountCodeBtn.TabIndex = 12;
            this.givediscountCodeBtn.Text = "X";
            this.givediscountCodeBtn.UseVisualStyleBackColor = true;
            this.givediscountCodeBtn.Click += new System.EventHandler(this.GivediscountCodeBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.Location = new System.Drawing.Point(275, 355);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(20, 20);
            this.discountBtn.TabIndex = 11;
            this.discountBtn.Text = "D";
            this.discountBtn.UseVisualStyleBackColor = true;
            this.discountBtn.Click += new System.EventHandler(this.DiscountBtn_Click);
            // 
            // goBuyBtn
            // 
            this.goBuyBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.goBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBuyBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBuyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goBuyBtn.Location = new System.Drawing.Point(215, 441);
            this.goBuyBtn.Name = "goBuyBtn";
            this.goBuyBtn.Size = new System.Drawing.Size(80, 30);
            this.goBuyBtn.TabIndex = 10;
            this.goBuyBtn.Text = "Next";
            this.goBuyBtn.UseVisualStyleBackColor = false;
            this.goBuyBtn.Click += new System.EventHandler(this.GoBuyBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(129, 441);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(80, 30);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // semiTotalBox
            // 
            this.semiTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semiTotalBox.Location = new System.Drawing.Point(195, 325);
            this.semiTotalBox.Name = "semiTotalBox";
            this.semiTotalBox.ReadOnly = true;
            this.semiTotalBox.Size = new System.Drawing.Size(100, 20);
            this.semiTotalBox.TabIndex = 8;
            this.semiTotalBox.Text = "0";
            this.semiTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 328);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Semi Total: ";
            // 
            // totalTaxBox
            // 
            this.totalTaxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTaxBox.Location = new System.Drawing.Point(195, 384);
            this.totalTaxBox.Name = "totalTaxBox";
            this.totalTaxBox.ReadOnly = true;
            this.totalTaxBox.Size = new System.Drawing.Size(100, 20);
            this.totalTaxBox.TabIndex = 6;
            this.totalTaxBox.Text = "0";
            this.totalTaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 388);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tax: ";
            // 
            // discountAmountBox
            // 
            this.discountAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountAmountBox.Location = new System.Drawing.Point(195, 355);
            this.discountAmountBox.Name = "discountAmountBox";
            this.discountAmountBox.ReadOnly = true;
            this.discountAmountBox.Size = new System.Drawing.Size(75, 20);
            this.discountAmountBox.TabIndex = 4;
            this.discountAmountBox.Text = "0";
            this.discountAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(137, 359);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountLabel.Size = new System.Drawing.Size(52, 13);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "Discount:";
            // 
            // totalAmountBox
            // 
            this.totalAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountBox.Location = new System.Drawing.Point(195, 415);
            this.totalAmountBox.Name = "totalAmountBox";
            this.totalAmountBox.ReadOnly = true;
            this.totalAmountBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountBox.TabIndex = 2;
            this.totalAmountBox.Text = "0";
            this.totalAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 418);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: ";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.Quantity,
            this.productPreferences,
            this.Total});
            this.dgvCart.Location = new System.Drawing.Point(3, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(292, 309);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCart_CellValueChanged);
            this.dgvCart.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvCart_RowsAdded);
            this.dgvCart.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvCart_RowsRemoved);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(99, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(416, 26);
            this.searchBox.TabIndex = 47;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.showProductFlowLayout);
            this.panel3.Controls.Add(this.searchBox);
            this.panel3.Location = new System.Drawing.Point(3, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 481);
            this.panel3.TabIndex = 49;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "ID";
            this.productId.Name = "productId";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // productPreferences
            // 
            this.productPreferences.DataPropertyName = "productPreferences";
            this.productPreferences.HeaderText = "Preferences";
            this.productPreferences.Name = "productPreferences";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // AllProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AllProductShow";
            this.Size = new System.Drawing.Size(829, 533);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel showProductFlowLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTaxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox discountAmountBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox totalAmountBox;
        private System.Windows.Forms.TextBox semiTotalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goBuyBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button givediscountCodeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox dicountCodeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPreferences;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
