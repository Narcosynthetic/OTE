namespace OTE
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMandatoryUserName = new System.Windows.Forms.Label();
            this.lblMandatoryPassword = new System.Windows.Forms.Label();
            this.lblNoAccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(41, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 65);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(151, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(195, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMandatoryUserName
            // 
            this.lblMandatoryUserName.AutoSize = true;
            this.lblMandatoryUserName.ForeColor = System.Drawing.Color.Red;
            this.lblMandatoryUserName.Location = new System.Drawing.Point(349, 36);
            this.lblMandatoryUserName.Name = "lblMandatoryUserName";
            this.lblMandatoryUserName.Size = new System.Drawing.Size(86, 13);
            this.lblMandatoryUserName.TabIndex = 27;
            this.lblMandatoryUserName.Text = "* Mandatory field";
            this.lblMandatoryUserName.Visible = false;
            // 
            // lblMandatoryPassword
            // 
            this.lblMandatoryPassword.AutoSize = true;
            this.lblMandatoryPassword.ForeColor = System.Drawing.Color.Red;
            this.lblMandatoryPassword.Location = new System.Drawing.Point(349, 68);
            this.lblMandatoryPassword.Name = "lblMandatoryPassword";
            this.lblMandatoryPassword.Size = new System.Drawing.Size(86, 13);
            this.lblMandatoryPassword.TabIndex = 28;
            this.lblMandatoryPassword.Text = "* Mandatory field";
            this.lblMandatoryPassword.Visible = false;
            // 
            // lblNoAccess
            // 
            this.lblNoAccess.AutoSize = true;
            this.lblNoAccess.ForeColor = System.Drawing.Color.Red;
            this.lblNoAccess.Location = new System.Drawing.Point(38, 110);
            this.lblNoAccess.Name = "lblNoAccess";
            this.lblNoAccess.Size = new System.Drawing.Size(29, 13);
            this.lblNoAccess.TabIndex = 29;
            this.lblNoAccess.Text = "@@";
            this.lblNoAccess.Visible = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 273);
            this.Controls.Add(this.lblNoAccess);
            this.Controls.Add(this.lblMandatoryPassword);
            this.Controls.Add(this.lblMandatoryUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogIn";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMandatoryUserName;
        private System.Windows.Forms.Label lblMandatoryPassword;
        private System.Windows.Forms.Label lblNoAccess;
    }
}

