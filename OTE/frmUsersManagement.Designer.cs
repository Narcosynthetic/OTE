namespace OTE
{
    partial class frmUsersManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.getUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnAddNewRole = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.getRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUsersRoles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaxeirhshExoplismouOTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getUsersTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetUsersTableAdapter();
            this.getRolesTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetRolesTableAdapter();
            this.getUsersRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getUsersRolesTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetUsersRolesTableAdapter();
            this.txtUserRoleUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoleUser = new System.Windows.Forms.TextBox();
            this.btnDeleteUserRole = new System.Windows.Forms.Button();
            this.btnUpdateUserRole = new System.Windows.Forms.Button();
            this.btnAddNewUserRole = new System.Windows.Forms.Button();
            this.userIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRolesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.Controls.Add(this.btnAddNewUser);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(436, 223);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 13;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Is Active";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(146, 247);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(64, 23);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(76, 247);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(64, 23);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(6, 247);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(64, 23);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "Add New";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(327, 220);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(220, 221);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 221);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.Password,
            this.FirstName,
            this.LastName,
            this.IsActive});
            this.dgvUsers.DataSource = this.getUsersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(6, 28);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(629, 159);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // getUsersBindingSource
            // 
            this.getUsersBindingSource.DataMember = "GetUsers";
            this.getUsersBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSetBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteRole);
            this.groupBox2.Controls.Add(this.btnUpdateRole);
            this.groupBox2.Controls.Add(this.btnAddNewRole);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRole);
            this.groupBox2.Controls.Add(this.dgvRoles);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(146, 192);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(64, 23);
            this.btnDeleteRole.TabIndex = 14;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(76, 192);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(64, 23);
            this.btnUpdateRole.TabIndex = 13;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.Location = new System.Drawing.Point(6, 192);
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(64, 23);
            this.btnAddNewRole.TabIndex = 12;
            this.btnAddNewRole.Text = "Add New";
            this.btnAddNewRole.UseVisualStyleBackColor = true;
            this.btnAddNewRole.Click += new System.EventHandler(this.btnAddNewRole_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(6, 166);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 1;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AutoGenerateColumns = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Role});
            this.dgvRoles.DataSource = this.getRolesBindingSource;
            this.dgvRoles.Location = new System.Drawing.Point(6, 19);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(268, 109);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // getRolesBindingSource
            // 
            this.getRolesBindingSource.DataMember = "GetRoles";
            this.getRolesBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSetBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteUserRole);
            this.groupBox3.Controls.Add(this.btnUpdateUserRole);
            this.groupBox3.Controls.Add(this.btnAddNewUserRole);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtRoleUser);
            this.groupBox3.Controls.Add(this.txtUserRoleUserName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dgvUsersRoles);
            this.groupBox3.Location = new System.Drawing.Point(339, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users && Roles";
            // 
            // dgvUsersRoles
            // 
            this.dgvUsersRoles.AllowUserToAddRows = false;
            this.dgvUsersRoles.AllowUserToDeleteRows = false;
            this.dgvUsersRoles.AutoGenerateColumns = false;
            this.dgvUsersRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdColumn,
            this.userNameColumn,
            this.roleIdColumn,
            this.roleColumn});
            this.dgvUsersRoles.DataSource = this.getUsersRolesBindingSource;
            this.dgvUsersRoles.Location = new System.Drawing.Point(6, 19);
            this.dgvUsersRoles.Name = "dgvUsersRoles";
            this.dgvUsersRoles.ReadOnly = true;
            this.dgvUsersRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersRoles.Size = new System.Drawing.Size(302, 109);
            this.dgvUsersRoles.TabIndex = 0;
            this.dgvUsersRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersRoles_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 200;
            // 
            // diaxeirhshExoplismouOTEDataSetBindingSource
            // 
            this.diaxeirhshExoplismouOTEDataSetBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSet;
            this.diaxeirhshExoplismouOTEDataSetBindingSource.Position = 0;
            // 
            // diaxeirhshExoplismouOTEDataSet
            // 
            this.diaxeirhshExoplismouOTEDataSet.DataSetName = "DiaxeirhshExoplismouOTEDataSet";
            this.diaxeirhshExoplismouOTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 70;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // getUsersTableAdapter
            // 
            this.getUsersTableAdapter.ClearBeforeFill = true;
            // 
            // getRolesTableAdapter
            // 
            this.getRolesTableAdapter.ClearBeforeFill = true;
            // 
            // getUsersRolesBindingSource
            // 
            this.getUsersRolesBindingSource.DataMember = "GetUsersRoles";
            this.getUsersRolesBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSetBindingSource;
            // 
            // getUsersRolesTableAdapter
            // 
            this.getUsersRolesTableAdapter.ClearBeforeFill = true;
            // 
            // txtUserRoleUserName
            // 
            this.txtUserRoleUserName.Location = new System.Drawing.Point(6, 166);
            this.txtUserRoleUserName.Name = "txtUserRoleUserName";
            this.txtUserRoleUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserRoleUserName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Role";
            // 
            // txtRoleUser
            // 
            this.txtRoleUser.Location = new System.Drawing.Point(112, 166);
            this.txtRoleUser.Name = "txtRoleUser";
            this.txtRoleUser.Size = new System.Drawing.Size(100, 20);
            this.txtRoleUser.TabIndex = 5;
            // 
            // btnDeleteUserRole
            // 
            this.btnDeleteUserRole.Location = new System.Drawing.Point(146, 192);
            this.btnDeleteUserRole.Name = "btnDeleteUserRole";
            this.btnDeleteUserRole.Size = new System.Drawing.Size(64, 23);
            this.btnDeleteUserRole.TabIndex = 17;
            this.btnDeleteUserRole.Text = "Delete";
            this.btnDeleteUserRole.UseVisualStyleBackColor = true;
            this.btnDeleteUserRole.Click += new System.EventHandler(this.btnDeleteUserRole_Click);
            // 
            // btnUpdateUserRole
            // 
            this.btnUpdateUserRole.Location = new System.Drawing.Point(76, 192);
            this.btnUpdateUserRole.Name = "btnUpdateUserRole";
            this.btnUpdateUserRole.Size = new System.Drawing.Size(64, 23);
            this.btnUpdateUserRole.TabIndex = 16;
            this.btnUpdateUserRole.Text = "Update";
            this.btnUpdateUserRole.UseVisualStyleBackColor = true;
            this.btnUpdateUserRole.Click += new System.EventHandler(this.btnUpdateUserRole_Click);
            // 
            // btnAddNewUserRole
            // 
            this.btnAddNewUserRole.Location = new System.Drawing.Point(6, 192);
            this.btnAddNewUserRole.Name = "btnAddNewUserRole";
            this.btnAddNewUserRole.Size = new System.Drawing.Size(64, 23);
            this.btnAddNewUserRole.TabIndex = 15;
            this.btnAddNewUserRole.Text = "Add New";
            this.btnAddNewUserRole.UseVisualStyleBackColor = true;
            this.btnAddNewUserRole.Click += new System.EventHandler(this.btnAddNewUserRole_Click);
            // 
            // userIdColumn
            // 
            this.userIdColumn.DataPropertyName = "UserId";
            this.userIdColumn.HeaderText = "UserId";
            this.userIdColumn.Name = "userIdColumn";
            this.userIdColumn.ReadOnly = true;
            this.userIdColumn.Visible = false;
            // 
            // userNameColumn
            // 
            this.userNameColumn.DataPropertyName = "UserName";
            this.userNameColumn.HeaderText = "User Name";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            this.userNameColumn.Width = 110;
            // 
            // roleIdColumn
            // 
            this.roleIdColumn.DataPropertyName = "RoleId";
            this.roleIdColumn.HeaderText = "RoleId";
            this.roleIdColumn.Name = "roleIdColumn";
            this.roleIdColumn.ReadOnly = true;
            this.roleIdColumn.Visible = false;
            // 
            // roleColumn
            // 
            this.roleColumn.DataPropertyName = "Role";
            this.roleColumn.HeaderText = "Role";
            this.roleColumn.Name = "roleColumn";
            this.roleColumn.ReadOnly = true;
            this.roleColumn.Width = 110;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsersManagement";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRolesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersRolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource diaxeirhshExoplismouOTEDataSetBindingSource;
        private DiaxeirhshExoplismouOTEDataSet diaxeirhshExoplismouOTEDataSet;
        private System.Windows.Forms.BindingSource getUsersBindingSource;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetUsersTableAdapter getUsersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.BindingSource getRolesBindingSource;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetRolesTableAdapter getRolesTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnAddNewRole;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridView dgvUsersRoles;
        private System.Windows.Forms.BindingSource getUsersRolesBindingSource;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetUsersRolesTableAdapter getUsersRolesTableAdapter;
        private System.Windows.Forms.Button btnDeleteUserRole;
        private System.Windows.Forms.Button btnUpdateUserRole;
        private System.Windows.Forms.Button btnAddNewUserRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoleUser;
        private System.Windows.Forms.TextBox txtUserRoleUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;

    }
}