namespace RestaurantManagement
{
    partial class AddCatagory
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
            this.managerPanel = new System.Windows.Forms.Panel();
            this.categoryStatusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.categorypicbox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.categorysGrid = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.categoryidBox = new System.Windows.Forms.TextBox();
            this.managerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorypicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managerPanel
            // 
            this.managerPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.managerPanel.Controls.Add(this.categoryStatusBox);
            this.managerPanel.Controls.Add(this.label1);
            this.managerPanel.Controls.Add(this.addImageBtn);
            this.managerPanel.Controls.Add(this.categorypicbox);
            this.managerPanel.Controls.Add(this.searchBox);
            this.managerPanel.Controls.Add(this.label33);
            this.managerPanel.Controls.Add(this.categorysGrid);
            this.managerPanel.Controls.Add(this.clearBtn);
            this.managerPanel.Controls.Add(this.updateBtn);
            this.managerPanel.Controls.Add(this.removeBtn);
            this.managerPanel.Controls.Add(this.addBtn);
            this.managerPanel.Controls.Add(this.label35);
            this.managerPanel.Controls.Add(this.label37);
            this.managerPanel.Controls.Add(this.nameBox);
            this.managerPanel.Controls.Add(this.label39);
            this.managerPanel.Controls.Add(this.categoryidBox);
            this.managerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerPanel.Location = new System.Drawing.Point(0, 0);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(830, 530);
            this.managerPanel.TabIndex = 45;
            // 
            // categoryStatusBox
            // 
            this.categoryStatusBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryStatusBox.FormattingEnabled = true;
            this.categoryStatusBox.Items.AddRange(new object[] {
            "Available",
            "Sold Out"});
            this.categoryStatusBox.Location = new System.Drawing.Point(7, 182);
            this.categoryStatusBox.Name = "categoryStatusBox";
            this.categoryStatusBox.Size = new System.Drawing.Size(201, 27);
            this.categoryStatusBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Category Status";
            // 
            // addImageBtn
            // 
            this.addImageBtn.Location = new System.Drawing.Point(8, 378);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(200, 39);
            this.addImageBtn.TabIndex = 41;
            this.addImageBtn.Text = "Add Image";
            this.addImageBtn.UseVisualStyleBackColor = true;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // categorypicbox
            // 
            this.categorypicbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categorypicbox.Location = new System.Drawing.Point(7, 228);
            this.categorypicbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categorypicbox.Name = "categorypicbox";
            this.categorypicbox.Size = new System.Drawing.Size(202, 146);
            this.categorypicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categorypicbox.TabIndex = 40;
            this.categorypicbox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(432, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(389, 26);
            this.searchBox.TabIndex = 39;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(384, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 15);
            this.label33.TabIndex = 38;
            this.label33.Text = "Search:";
            // 
            // categorysGrid
            // 
            this.categorysGrid.AllowUserToAddRows = false;
            this.categorysGrid.AllowUserToDeleteRows = false;
            this.categorysGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorysGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorysGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.categoryName,
            this.categoryImg,
            this.categoryStatus});
            this.categorysGrid.Location = new System.Drawing.Point(225, 53);
            this.categorysGrid.Name = "categorysGrid";
            this.categorysGrid.ReadOnly = true;
            this.categorysGrid.RowHeadersWidth = 51;
            this.categorysGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorysGrid.Size = new System.Drawing.Size(596, 424);
            this.categorysGrid.TabIndex = 36;
            this.categorysGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorysGrid_CellDoubleClick);
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "ID";
            this.categoryId.MinimumWidth = 8;
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "Name";
            this.categoryName.MinimumWidth = 8;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // categoryImg
            // 
            this.categoryImg.DataPropertyName = "categoryImg";
            this.categoryImg.HeaderText = "Image";
            this.categoryImg.MinimumWidth = 8;
            this.categoryImg.Name = "categoryImg";
            this.categoryImg.ReadOnly = true;
            // 
            // categoryStatus
            // 
            this.categoryStatus.DataPropertyName = "categoryStatus";
            this.categoryStatus.HeaderText = "Status";
            this.categoryStatus.MinimumWidth = 8;
            this.categoryStatus.Name = "categoryStatus";
            this.categoryStatus.ReadOnly = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(688, 483);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 39);
            this.clearBtn.TabIndex = 35;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(549, 483);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 39);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(410, 483);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(133, 39);
            this.removeBtn.TabIndex = 33;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(271, 483);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 39);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(5, 114);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 15);
            this.label35.TabIndex = 31;
            this.label35.Text = "Category Name";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(5, 210);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(96, 15);
            this.label37.TabIndex = 23;
            this.label37.Text = "Category Picture";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(7, 132);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(201, 26);
            this.nameBox.TabIndex = 24;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(5, 65);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(72, 15);
            this.label39.TabIndex = 19;
            this.label39.Text = "Category ID";
            // 
            // categoryidBox
            // 
            this.categoryidBox.BackColor = System.Drawing.Color.White;
            this.categoryidBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryidBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryidBox.Location = new System.Drawing.Point(7, 83);
            this.categoryidBox.Name = "categoryidBox";
            this.categoryidBox.ReadOnly = true;
            this.categoryidBox.Size = new System.Drawing.Size(201, 26);
            this.categoryidBox.TabIndex = 20;
            // 
            // AddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCatagory";
            this.Size = new System.Drawing.Size(830, 530);
            this.managerPanel.ResumeLayout(false);
            this.managerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorypicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managerPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView categorysGrid;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox categoryidBox;
        private System.Windows.Forms.PictureBox categorypicbox;
        private System.Windows.Forms.Button addImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryStatusBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryStatus;
    }
}
