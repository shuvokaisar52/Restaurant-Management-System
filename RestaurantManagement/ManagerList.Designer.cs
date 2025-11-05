namespace RestaurantManagement
{
    partial class ManagerList
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
            this.managerPanel = new System.Windows.Forms.Panel();
            this.firedBtn = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.joindateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.managerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // managerPanel
            // 
            this.managerPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.managerPanel.Controls.Add(this.firedBtn);
            this.managerPanel.Controls.Add(this.statusBox);
            this.managerPanel.Controls.Add(this.label5);
            this.managerPanel.Controls.Add(this.joindateBox);
            this.managerPanel.Controls.Add(this.label4);
            this.managerPanel.Controls.Add(this.label3);
            this.managerPanel.Controls.Add(this.roleBox);
            this.managerPanel.Controls.Add(this.label1);
            this.managerPanel.Controls.Add(this.label2);
            this.managerPanel.Controls.Add(this.genderBox);
            this.managerPanel.Controls.Add(this.searchBox);
            this.managerPanel.Controls.Add(this.dataGridView2);
            this.managerPanel.Controls.Add(this.clearBtn);
            this.managerPanel.Controls.Add(this.updateBtn);
            this.managerPanel.Controls.Add(this.removeBtn);
            this.managerPanel.Controls.Add(this.addBtn);
            this.managerPanel.Controls.Add(this.label34);
            this.managerPanel.Controls.Add(this.label35);
            this.managerPanel.Controls.Add(this.salaryBox);
            this.managerPanel.Controls.Add(this.emailBox);
            this.managerPanel.Controls.Add(this.label37);
            this.managerPanel.Controls.Add(this.label38);
            this.managerPanel.Controls.Add(this.nameBox);
            this.managerPanel.Controls.Add(this.passwordBox);
            this.managerPanel.Controls.Add(this.label39);
            this.managerPanel.Controls.Add(this.label40);
            this.managerPanel.Controls.Add(this.idBox);
            this.managerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerPanel.Location = new System.Drawing.Point(0, 0);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(830, 530);
            this.managerPanel.TabIndex = 44;
            // 
            // firedBtn
            // 
            this.firedBtn.Location = new System.Drawing.Point(224, 483);
            this.firedBtn.Name = "firedBtn";
            this.firedBtn.Size = new System.Drawing.Size(110, 40);
            this.firedBtn.TabIndex = 51;
            this.firedBtn.Text = "Fire";
            this.firedBtn.UseVisualStyleBackColor = true;
            this.firedBtn.Click += new System.EventHandler(this.FiredBtn_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Unblocked",
            "Blocked",
            "Fired"});
            this.statusBox.Location = new System.Drawing.Point(9, 433);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(201, 27);
            this.statusBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Status";
            // 
            // joindateBox
            // 
            this.joindateBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joindateBox.Location = new System.Drawing.Point(9, 338);
            this.joindateBox.Name = "joindateBox";
            this.joindateBox.Size = new System.Drawing.Size(200, 26);
            this.joindateBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Join Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search";
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Manager"});
            this.roleBox.Location = new System.Drawing.Point(9, 383);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(201, 27);
            this.roleBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 42;
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderBox.Location = new System.Drawing.Point(9, 288);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(201, 27);
            this.genderBox.TabIndex = 40;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(402, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(416, 26);
            this.searchBox.TabIndex = 39;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mId,
            this.mPassword,
            this.mName,
            this.mEmail,
            this.mSalary,
            this.mGender,
            this.mJoinDate,
            this.mFireDate,
            this.mRole,
            this.mStatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(215, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(603, 436);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick_1);
            // 
            // mId
            // 
            this.mId.DataPropertyName = "mId";
            this.mId.HeaderText = "ID";
            this.mId.Name = "mId";
            this.mId.ReadOnly = true;
            // 
            // mPassword
            // 
            this.mPassword.DataPropertyName = "mPassword";
            this.mPassword.HeaderText = "Password";
            this.mPassword.Name = "mPassword";
            this.mPassword.ReadOnly = true;
            // 
            // mName
            // 
            this.mName.DataPropertyName = "mName";
            this.mName.HeaderText = "Name";
            this.mName.Name = "mName";
            this.mName.ReadOnly = true;
            // 
            // mEmail
            // 
            this.mEmail.DataPropertyName = "mEmail";
            this.mEmail.HeaderText = "Email";
            this.mEmail.Name = "mEmail";
            this.mEmail.ReadOnly = true;
            // 
            // mSalary
            // 
            this.mSalary.DataPropertyName = "mSalary";
            this.mSalary.HeaderText = "Salary";
            this.mSalary.Name = "mSalary";
            this.mSalary.ReadOnly = true;
            // 
            // mGender
            // 
            this.mGender.DataPropertyName = "mGender";
            this.mGender.HeaderText = "Gender";
            this.mGender.Name = "mGender";
            this.mGender.ReadOnly = true;
            // 
            // mJoinDate
            // 
            this.mJoinDate.DataPropertyName = "mJoinDate";
            this.mJoinDate.HeaderText = "Join Date";
            this.mJoinDate.Name = "mJoinDate";
            this.mJoinDate.ReadOnly = true;
            // 
            // mFireDate
            // 
            this.mFireDate.DataPropertyName = "mFireDate";
            this.mFireDate.HeaderText = "Fire Date";
            this.mFireDate.Name = "mFireDate";
            this.mFireDate.ReadOnly = true;
            // 
            // mRole
            // 
            this.mRole.DataPropertyName = "mRole";
            this.mRole.HeaderText = "Role";
            this.mRole.Name = "mRole";
            this.mRole.ReadOnly = true;
            // 
            // mStatus
            // 
            this.mStatus.DataPropertyName = "mStatus";
            this.mStatus.HeaderText = "Status";
            this.mStatus.Name = "mStatus";
            this.mStatus.ReadOnly = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(708, 483);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(110, 40);
            this.clearBtn.TabIndex = 35;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(587, 483);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 40);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(466, 483);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(110, 40);
            this.removeBtn.TabIndex = 33;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(345, 483);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 40);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(9, 270);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 15);
            this.label34.TabIndex = 29;
            this.label34.Text = "Gender";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(9, 132);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(37, 15);
            this.label35.TabIndex = 31;
            this.label35.Text = "Name";
            // 
            // salaryBox
            // 
            this.salaryBox.BackColor = System.Drawing.Color.White;
            this.salaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBox.Location = new System.Drawing.Point(9, 242);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(201, 26);
            this.salaryBox.TabIndex = 28;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.White;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(9, 196);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(201, 26);
            this.emailBox.TabIndex = 26;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(9, 178);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 15);
            this.label37.TabIndex = 23;
            this.label37.Text = "Email";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(9, 224);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 15);
            this.label38.TabIndex = 25;
            this.label38.Text = "Salary";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(9, 150);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(201, 26);
            this.nameBox.TabIndex = 24;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(9, 104);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(201, 26);
            this.passwordBox.TabIndex = 22;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(9, 41);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(20, 15);
            this.label39.TabIndex = 19;
            this.label39.Text = "ID";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(9, 86);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 15);
            this.label40.TabIndex = 21;
            this.label40.Text = "Password";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.White;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(9, 58);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(201, 26);
            this.idBox.TabIndex = 20;
            // 
            // ManagerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerPanel);
            this.Name = "ManagerList";
            this.Size = new System.Drawing.Size(830, 530);
            this.managerPanel.ResumeLayout(false);
            this.managerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managerPanel;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker joindateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button firedBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mId;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStatus;
    }
}
