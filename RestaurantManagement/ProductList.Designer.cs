namespace RestaurantManagement
{
    partial class ProductList
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
            this.preferenceAddPanel = new System.Windows.Forms.Panel();
            this.addPreference = new System.Windows.Forms.Button();
            this.newPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeLabelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.savePreference = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPreferences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPreferencesBtn = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.Addimagebtn = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.preferenceBox = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.preferencesListGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerPanel.SuspendLayout();
            this.preferenceAddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managerPanel
            // 
            this.managerPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.managerPanel.Controls.Add(this.preferenceAddPanel);
            this.managerPanel.Controls.Add(this.searchBox);
            this.managerPanel.Controls.Add(this.label33);
            this.managerPanel.Controls.Add(this.productsGrid);
            this.managerPanel.Controls.Add(this.clearBtn);
            this.managerPanel.Controls.Add(this.updateBtn);
            this.managerPanel.Controls.Add(this.removeBtn);
            this.managerPanel.Controls.Add(this.addBtn);
            this.managerPanel.Controls.Add(this.panel1);
            this.managerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerPanel.Location = new System.Drawing.Point(0, 0);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(830, 530);
            this.managerPanel.TabIndex = 46;
            // 
            // preferenceAddPanel
            // 
            this.preferenceAddPanel.Controls.Add(this.preferencesListGrid);
            this.preferenceAddPanel.Controls.Add(this.addPreference);
            this.preferenceAddPanel.Controls.Add(this.newPriceBox);
            this.preferenceAddPanel.Controls.Add(this.label3);
            this.preferenceAddPanel.Controls.Add(this.sizeLabelBox);
            this.preferenceAddPanel.Controls.Add(this.label4);
            this.preferenceAddPanel.Controls.Add(this.closeBtn);
            this.preferenceAddPanel.Controls.Add(this.savePreference);
            this.preferenceAddPanel.Location = new System.Drawing.Point(243, 224);
            this.preferenceAddPanel.Name = "preferenceAddPanel";
            this.preferenceAddPanel.Size = new System.Drawing.Size(271, 229);
            this.preferenceAddPanel.TabIndex = 53;
            // 
            // addPreference
            // 
            this.addPreference.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addPreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPreference.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPreference.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addPreference.Location = new System.Drawing.Point(94, 193);
            this.addPreference.Name = "addPreference";
            this.addPreference.Size = new System.Drawing.Size(80, 30);
            this.addPreference.TabIndex = 40;
            this.addPreference.Text = "Add";
            this.addPreference.UseVisualStyleBackColor = false;
            this.addPreference.Click += new System.EventHandler(this.AddPreference_Click);
            // 
            // newPriceBox
            // 
            this.newPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPriceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPriceBox.Location = new System.Drawing.Point(106, 37);
            this.newPriceBox.Name = "newPriceBox";
            this.newPriceBox.Size = new System.Drawing.Size(150, 22);
            this.newPriceBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "New Price";
            // 
            // sizeLabelBox
            // 
            this.sizeLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeLabelBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabelBox.Location = new System.Drawing.Point(106, 8);
            this.sizeLabelBox.Name = "sizeLabelBox";
            this.sizeLabelBox.Size = new System.Drawing.Size(150, 22);
            this.sizeLabelBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Size Label";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Firebrick;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(176, 193);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(80, 30);
            this.closeBtn.TabIndex = 35;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // savePreference
            // 
            this.savePreference.BackColor = System.Drawing.Color.CornflowerBlue;
            this.savePreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePreference.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePreference.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savePreference.Location = new System.Drawing.Point(12, 193);
            this.savePreference.Name = "savePreference";
            this.savePreference.Size = new System.Drawing.Size(80, 30);
            this.savePreference.TabIndex = 34;
            this.savePreference.Text = "Save";
            this.savePreference.UseVisualStyleBackColor = false;
            this.savePreference.Click += new System.EventHandler(this.SavePreference_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(395, 21);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(416, 26);
            this.searchBox.TabIndex = 39;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(343, 26);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 15);
            this.label33.TabIndex = 38;
            this.label33.Text = "Search:";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.productsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.productTax,
            this.productStock,
            this.productCategory,
            this.productImage,
            this.productStatus,
            this.productPreferences});
            this.productsGrid.Location = new System.Drawing.Point(243, 53);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.productsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGrid.Size = new System.Drawing.Size(568, 417);
            this.productsGrid.TabIndex = 36;
            this.productsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellDoubleClick);
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "ID";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "productPrice";
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productTax
            // 
            this.productTax.DataPropertyName = "productTax";
            this.productTax.HeaderText = "Tax";
            this.productTax.Name = "productTax";
            this.productTax.ReadOnly = true;
            // 
            // productStock
            // 
            this.productStock.DataPropertyName = "productStock";
            this.productStock.HeaderText = "Strock";
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.DataPropertyName = "productCategory";
            this.productCategory.HeaderText = "Category";
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // productImage
            // 
            this.productImage.DataPropertyName = "productImage";
            this.productImage.HeaderText = "Image";
            this.productImage.Name = "productImage";
            this.productImage.ReadOnly = true;
            // 
            // productStatus
            // 
            this.productStatus.DataPropertyName = "productStatus";
            this.productStatus.HeaderText = "Status";
            this.productStatus.Name = "productStatus";
            this.productStatus.ReadOnly = true;
            // 
            // productPreferences
            // 
            this.productPreferences.DataPropertyName = "productPreferences";
            this.productPreferences.HeaderText = "Preferences";
            this.productPreferences.Name = "productPreferences";
            this.productPreferences.ReadOnly = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(700, 476);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 39);
            this.clearBtn.TabIndex = 35;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(585, 476);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 39);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(470, 476);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(109, 39);
            this.removeBtn.TabIndex = 33;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(355, 476);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 39);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addPreferencesBtn);
            this.panel1.Controls.Add(this.statusBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.taxBox);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.Addimagebtn);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.CategoryBox);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.preferenceBox);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.stockBox);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 533);
            this.panel1.TabIndex = 52;
            // 
            // addPreferencesBtn
            // 
            this.addPreferencesBtn.Location = new System.Drawing.Point(189, 228);
            this.addPreferencesBtn.Name = "addPreferencesBtn";
            this.addPreferencesBtn.Size = new System.Drawing.Size(34, 26);
            this.addPreferencesBtn.TabIndex = 55;
            this.addPreferencesBtn.Text = "Add";
            this.addPreferencesBtn.UseVisualStyleBackColor = true;
            this.addPreferencesBtn.Click += new System.EventHandler(this.AddPreferencesBtn_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Available",
            "Sold Out"});
            this.statusBox.Location = new System.Drawing.Point(21, 477);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(201, 27);
            this.statusBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Product Status";
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(21, 131);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(201, 26);
            this.priceBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Product Price";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.White;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(22, 36);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(201, 26);
            this.idBox.TabIndex = 20;
            // 
            // taxBox
            // 
            this.taxBox.BackColor = System.Drawing.Color.White;
            this.taxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxBox.Location = new System.Drawing.Point(21, 428);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(201, 26);
            this.taxBox.TabIndex = 49;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(20, 66);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 15);
            this.label40.TabIndex = 21;
            this.label40.Text = "Product Name";
            // 
            // Addimagebtn
            // 
            this.Addimagebtn.Location = new System.Drawing.Point(124, 353);
            this.Addimagebtn.Name = "Addimagebtn";
            this.Addimagebtn.Size = new System.Drawing.Size(75, 23);
            this.Addimagebtn.TabIndex = 48;
            this.Addimagebtn.Text = "Add Image";
            this.Addimagebtn.UseVisualStyleBackColor = true;
            this.Addimagebtn.Click += new System.EventHandler(this.Addimagebtn_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(20, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 15);
            this.label39.TabIndex = 19;
            this.label39.Text = "Product Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.White;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(22, 84);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(201, 26);
            this.NameBox.TabIndex = 22;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(21, 179);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(201, 27);
            this.CategoryBox.TabIndex = 46;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(20, 258);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 15);
            this.label38.TabIndex = 25;
            this.label38.Text = "Product Stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Product Tax";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(18, 210);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 15);
            this.label37.TabIndex = 23;
            this.label37.Text = "Product Preferences";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(21, 307);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 15);
            this.label34.TabIndex = 29;
            this.label34.Text = "ProductImage";
            // 
            // preferenceBox
            // 
            this.preferenceBox.BackColor = System.Drawing.Color.White;
            this.preferenceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preferenceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferenceBox.Location = new System.Drawing.Point(21, 228);
            this.preferenceBox.Name = "preferenceBox";
            this.preferenceBox.ReadOnly = true;
            this.preferenceBox.Size = new System.Drawing.Size(162, 26);
            this.preferenceBox.TabIndex = 26;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(20, 161);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(101, 15);
            this.label35.TabIndex = 31;
            this.label35.Text = "Product Category";
            // 
            // stockBox
            // 
            this.stockBox.BackColor = System.Drawing.Color.White;
            this.stockBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBox.Location = new System.Drawing.Point(21, 276);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(201, 26);
            this.stockBox.TabIndex = 28;
            // 
            // preferencesListGrid
            // 
            this.preferencesListGrid.AllowUserToAddRows = false;
            this.preferencesListGrid.AllowUserToDeleteRows = false;
            this.preferencesListGrid.AllowUserToResizeColumns = false;
            this.preferencesListGrid.AllowUserToResizeRows = false;
            this.preferencesListGrid.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.preferencesListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preferencesListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price});
            this.preferencesListGrid.Location = new System.Drawing.Point(12, 65);
            this.preferencesListGrid.Name = "preferencesListGrid";
            this.preferencesListGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.preferencesListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.preferencesListGrid.Size = new System.Drawing.Size(244, 122);
            this.preferencesListGrid.TabIndex = 41;
            // 
            // name
            // 
            this.name.HeaderText = "Sizes";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerPanel);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.managerPanel.ResumeLayout(false);
            this.managerPanel.PerformLayout();
            this.preferenceAddPanel.ResumeLayout(false);
            this.preferenceAddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managerPanel;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox preferenceBox;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPreferences;
        private System.Windows.Forms.Button addPreferencesBtn;
        private System.Windows.Forms.Button Addimagebtn;
        private System.Windows.Forms.Panel preferenceAddPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button savePreference;
        private System.Windows.Forms.TextBox newPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sizeLabelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPreference;
        private System.Windows.Forms.DataGridView preferencesListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}
