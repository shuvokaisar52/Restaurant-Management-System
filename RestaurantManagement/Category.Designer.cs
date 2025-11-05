namespace RestaurantManagement
{
    partial class Category
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
            this.name = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(7, 173);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.name.Size = new System.Drawing.Size(154, 21);
            this.name.TabIndex = 3;
            this.name.Text = "Burger";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.Name_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(3, 2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(165, 165);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.Img_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.name);
            this.Controls.Add(this.img);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(170, 200);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox img;
    }
}
