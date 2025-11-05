namespace RestaurantManagement
{
    partial class Product
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
            this.img = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.preferenceBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(6, 6);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(152, 83);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(6, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Spicy Burger";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.Dock = System.Windows.Forms.DockStyle.Left;
            this.price.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.price.Location = new System.Drawing.Point(0, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(90, 25);
            this.price.TabIndex = 2;
            this.price.Text = "500";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addProductBtn.Location = new System.Drawing.Point(42, 187);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(84, 27);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(86, 138);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(59, 20);
            this.quantityBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select:";
            // 
            // preferenceBox
            // 
            this.preferenceBox.FormattingEnabled = true;
            this.preferenceBox.Location = new System.Drawing.Point(86, 162);
            this.preferenceBox.Name = "preferenceBox";
            this.preferenceBox.Size = new System.Drawing.Size(59, 21);
            this.preferenceBox.TabIndex = 10;
            this.preferenceBox.SelectedValueChanged += new System.EventHandler(this.PreferenceBox_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.price);
            this.panel1.Location = new System.Drawing.Point(-1, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 25);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(87, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "BDT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.preferenceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img);
            this.Controls.Add(this.name);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(165, 220);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox preferenceBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
