namespace RestaurantManagement
{
    partial class ShowCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.showCategoryFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showProductFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 44);
            this.panel1.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(4, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "All Categorys";
            // 
            // showCategoryFlowLayout
            // 
            this.showCategoryFlowLayout.Location = new System.Drawing.Point(3, 48);
            this.showCategoryFlowLayout.Name = "showCategoryFlowLayout";
            this.showCategoryFlowLayout.Size = new System.Drawing.Size(823, 480);
            this.showCategoryFlowLayout.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // showProductFlowLayout
            // 
            this.showProductFlowLayout.Location = new System.Drawing.Point(3, 48);
            this.showProductFlowLayout.Name = "showProductFlowLayout";
            this.showProductFlowLayout.Size = new System.Drawing.Size(823, 480);
            this.showProductFlowLayout.TabIndex = 2;
            // 
            // ShowCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showProductFlowLayout);
            this.Controls.Add(this.showCategoryFlowLayout);
            this.Controls.Add(this.panel1);
            this.Name = "ShowCategory";
            this.Size = new System.Drawing.Size(829, 533);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel showCategoryFlowLayout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel showProductFlowLayout;
    }
}
