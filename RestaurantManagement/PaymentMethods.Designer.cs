namespace RestaurantManagement
{
    partial class PaymentMethods
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
            this.methodNameLabel = new System.Windows.Forms.Label();
            this.methodStatusBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // methodNameLabel
            // 
            this.methodNameLabel.AutoSize = true;
            this.methodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodNameLabel.Location = new System.Drawing.Point(100, 15);
            this.methodNameLabel.Name = "methodNameLabel";
            this.methodNameLabel.Size = new System.Drawing.Size(120, 20);
            this.methodNameLabel.TabIndex = 0;
            this.methodNameLabel.Text = "Method Name";
            // 
            // methodStatusBox
            // 
            this.methodStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.methodStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodStatusBox.FormattingEnabled = true;
            this.methodStatusBox.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.methodStatusBox.Location = new System.Drawing.Point(439, 15);
            this.methodStatusBox.Name = "methodStatusBox";
            this.methodStatusBox.Size = new System.Drawing.Size(121, 21);
            this.methodStatusBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(565, 15);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(70, 22);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PaymentMethods
            // 
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.methodStatusBox);
            this.Controls.Add(this.methodNameLabel);
            this.Name = "PaymentMethods";
            this.Size = new System.Drawing.Size(730, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label methodNameLabel;
        private System.Windows.Forms.ComboBox methodStatusBox;
        private System.Windows.Forms.Button saveBtn;
    }
}
