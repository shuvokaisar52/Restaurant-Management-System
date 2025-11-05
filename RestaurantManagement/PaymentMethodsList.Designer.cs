namespace RestaurantManagement
{
    partial class PaymentMethodsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.showAllMethodFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.reloadBtn);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 49);
            this.panel1.TabIndex = 4;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(748, 23);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(75, 23);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(3, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "Payment Methods";
            // 
            // showAllMethodFlow
            // 
            this.showAllMethodFlow.Location = new System.Drawing.Point(50, 54);
            this.showAllMethodFlow.Name = "showAllMethodFlow";
            this.showAllMethodFlow.Size = new System.Drawing.Size(730, 470);
            this.showAllMethodFlow.TabIndex = 5;
            // 
            // PaymentMethodsList
            // 
            this.Controls.Add(this.showAllMethodFlow);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentMethodsList";
            this.Size = new System.Drawing.Size(830, 530);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel showAllMethodFlow;
    }
}
