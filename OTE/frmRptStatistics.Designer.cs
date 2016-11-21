namespace OTE
{
    partial class frmRptStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptStatistics));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvByUsers = new System.Windows.Forms.DataGridView();
            this.cbxUsersUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterByUsers = new System.Windows.Forms.Button();
            this.dtpDateToUser = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateFromUser = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBySap = new System.Windows.Forms.DataGridView();
            this.cbxUsersSap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilterBySap = new System.Windows.Forms.Button();
            this.dtpDateToSap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateFromSap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBySap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvByUsers);
            this.groupBox1.Controls.Add(this.cbxUsersUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilterByUsers);
            this.groupBox1.Controls.Add(this.dtpDateToUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpDateFromUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics By User";
            // 
            // dgvByUsers
            // 
            this.dgvByUsers.AllowUserToAddRows = false;
            this.dgvByUsers.AllowUserToDeleteRows = false;
            this.dgvByUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByUsers.Location = new System.Drawing.Point(11, 67);
            this.dgvByUsers.Name = "dgvByUsers";
            this.dgvByUsers.Size = new System.Drawing.Size(440, 190);
            this.dgvByUsers.TabIndex = 53;
            // 
            // cbxUsersUser
            // 
            this.cbxUsersUser.FormattingEnabled = true;
            this.cbxUsersUser.Location = new System.Drawing.Point(228, 39);
            this.cbxUsersUser.Name = "cbxUsersUser";
            this.cbxUsersUser.Size = new System.Drawing.Size(134, 21);
            this.cbxUsersUser.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Users";
            // 
            // btnFilterByUsers
            // 
            this.btnFilterByUsers.Location = new System.Drawing.Point(376, 37);
            this.btnFilterByUsers.Name = "btnFilterByUsers";
            this.btnFilterByUsers.Size = new System.Drawing.Size(75, 23);
            this.btnFilterByUsers.TabIndex = 50;
            this.btnFilterByUsers.Text = "Filter";
            this.btnFilterByUsers.UseVisualStyleBackColor = true;
            this.btnFilterByUsers.Click += new System.EventHandler(this.btnFilterByUsers_Click);
            // 
            // dtpDateToUser
            // 
            this.dtpDateToUser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateToUser.Location = new System.Drawing.Point(121, 40);
            this.dtpDateToUser.Name = "dtpDateToUser";
            this.dtpDateToUser.ShowCheckBox = true;
            this.dtpDateToUser.Size = new System.Drawing.Size(96, 20);
            this.dtpDateToUser.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Date To";
            // 
            // dtpDateFromUser
            // 
            this.dtpDateFromUser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFromUser.Location = new System.Drawing.Point(11, 40);
            this.dtpDateFromUser.Name = "dtpDateFromUser";
            this.dtpDateFromUser.ShowCheckBox = true;
            this.dtpDateFromUser.Size = new System.Drawing.Size(96, 20);
            this.dtpDateFromUser.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Date From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBySap);
            this.groupBox2.Controls.Add(this.cbxUsersSap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnFilterBySap);
            this.groupBox2.Controls.Add(this.dtpDateToSap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpDateFromSap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics By SAP";
            // 
            // dgvBySap
            // 
            this.dgvBySap.AllowUserToAddRows = false;
            this.dgvBySap.AllowUserToDeleteRows = false;
            this.dgvBySap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBySap.Location = new System.Drawing.Point(11, 67);
            this.dgvBySap.Name = "dgvBySap";
            this.dgvBySap.Size = new System.Drawing.Size(440, 190);
            this.dgvBySap.TabIndex = 53;
            // 
            // cbxUsersSap
            // 
            this.cbxUsersSap.FormattingEnabled = true;
            this.cbxUsersSap.Location = new System.Drawing.Point(228, 39);
            this.cbxUsersSap.Name = "cbxUsersSap";
            this.cbxUsersSap.Size = new System.Drawing.Size(134, 21);
            this.cbxUsersSap.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Users";
            // 
            // btnFilterBySap
            // 
            this.btnFilterBySap.Location = new System.Drawing.Point(376, 37);
            this.btnFilterBySap.Name = "btnFilterBySap";
            this.btnFilterBySap.Size = new System.Drawing.Size(75, 23);
            this.btnFilterBySap.TabIndex = 50;
            this.btnFilterBySap.Text = "Filter";
            this.btnFilterBySap.UseVisualStyleBackColor = true;
            this.btnFilterBySap.Click += new System.EventHandler(this.btnFilterBySap_Click);
            // 
            // dtpDateToSap
            // 
            this.dtpDateToSap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateToSap.Location = new System.Drawing.Point(121, 40);
            this.dtpDateToSap.Name = "dtpDateToSap";
            this.dtpDateToSap.ShowCheckBox = true;
            this.dtpDateToSap.Size = new System.Drawing.Size(96, 20);
            this.dtpDateToSap.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Date To";
            // 
            // dtpDateFromSap
            // 
            this.dtpDateFromSap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFromSap.Location = new System.Drawing.Point(11, 40);
            this.dtpDateFromSap.Name = "dtpDateFromSap";
            this.dtpDateFromSap.ShowCheckBox = true;
            this.dtpDateFromSap.Size = new System.Drawing.Size(96, 20);
            this.dtpDateFromSap.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date From";
            // 
            // frmRptStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptStatistics";
            this.Text = "Statistics Report";
            this.Load += new System.EventHandler(this.frmRptStatistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBySap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvByUsers;
        private System.Windows.Forms.ComboBox cbxUsersUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterByUsers;
        private System.Windows.Forms.DateTimePicker dtpDateToUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateFromUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBySap;
        private System.Windows.Forms.ComboBox cbxUsersSap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilterBySap;
        private System.Windows.Forms.DateTimePicker dtpDateToSap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateFromSap;
        private System.Windows.Forms.Label label4;
    }
}