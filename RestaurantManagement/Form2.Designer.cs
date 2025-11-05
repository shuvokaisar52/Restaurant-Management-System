namespace RestaurantManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nextPanel = new System.Windows.Forms.Panel();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.nextBtn2 = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.forgetEmailLabel = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.nextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 150);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Orbitron", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forget";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Orbitron", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password??";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // nextPanel
            // 
            this.nextPanel.Controls.Add(this.submitBtn);
            this.nextPanel.Controls.Add(this.passwordBox);
            this.nextPanel.Controls.Add(this.label5);
            this.nextPanel.Controls.Add(this.label3);
            this.nextPanel.Controls.Add(this.newPasswordLabel);
            this.nextPanel.Controls.Add(this.nextBtn2);
            this.nextPanel.Controls.Add(this.emailBox);
            this.nextPanel.Controls.Add(this.forgetEmailLabel);
            this.nextPanel.Controls.Add(this.userIDBox);
            this.nextPanel.Controls.Add(this.userIdLabel);
            this.nextPanel.Location = new System.Drawing.Point(0, 149);
            this.nextPanel.Name = "nextPanel";
            this.nextPanel.Size = new System.Drawing.Size(356, 247);
            this.nextPanel.TabIndex = 2;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(42, 40);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(0, 19);
            this.newPasswordLabel.TabIndex = 16;
            // 
            // nextBtn2
            // 
            this.nextBtn2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn2.Location = new System.Drawing.Point(46, 177);
            this.nextBtn2.Name = "nextBtn2";
            this.nextBtn2.Size = new System.Drawing.Size(269, 30);
            this.nextBtn2.TabIndex = 15;
            this.nextBtn2.Text = "Next";
            this.nextBtn2.UseVisualStyleBackColor = true;
            this.nextBtn2.Click += new System.EventHandler(this.NextBtn2_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.White;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(46, 135);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(269, 26);
            this.emailBox.TabIndex = 14;
            // 
            // forgetEmailLabel
            // 
            this.forgetEmailLabel.AutoSize = true;
            this.forgetEmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetEmailLabel.Location = new System.Drawing.Point(42, 106);
            this.forgetEmailLabel.Name = "forgetEmailLabel";
            this.forgetEmailLabel.Size = new System.Drawing.Size(121, 19);
            this.forgetEmailLabel.TabIndex = 13;
            this.forgetEmailLabel.Text = "Enter Your Email";
            // 
            // userIDBox
            // 
            this.userIDBox.BackColor = System.Drawing.Color.White;
            this.userIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDBox.Location = new System.Drawing.Point(46, 69);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(269, 26);
            this.userIDBox.TabIndex = 12;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(42, 40);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(102, 19);
            this.userIdLabel.TabIndex = 11;
            this.userIdLabel.Text = "Enter your ID";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(46, 142);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(269, 30);
            this.submitBtn.TabIndex = 19;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(46, 104);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(269, 26);
            this.passwordBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter your new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 391);
            this.Controls.Add(this.nextPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.nextPanel.ResumeLayout(false);
            this.nextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel nextPanel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button nextBtn2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label forgetEmailLabel;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}