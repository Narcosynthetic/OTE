using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTE
{
    public partial class frmUsersManagement : Form
    {
        #region Properties

        private string CurrentUserId
        {
            get;
            set;
        }

        private string CurrentRoleId
        {
            get;
            set;
        }

        //private string CurrentUserRoleUserId
        //{
        //    get;
        //    set;
        //}

        private string CurrentUserRoleRoleId
        {
            get;
            set;
        }

        #endregion

        #region Events

        public frmUsersManagement()
        {
            InitializeComponent();
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
            LoadUsersRoles();
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentUserId = dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                chkIsActive.Checked = bool.Parse(dgvUsers.Rows[e.RowIndex].Cells["IsActive"].Value.ToString());
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRoleId = dgvRoles.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtRole.Text = dgvRoles.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            }
        }

        private void dgvUsersRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //CurrentUserRoleUserId = dgvUsersRoles.Rows[e.RowIndex].Cells["userIdColumn"].Value.ToString();
                CurrentUserRoleRoleId = dgvUsersRoles.Rows[e.RowIndex].Cells["roleIdColumn"].Value.ToString();
                cbxUserName.SelectedValue = dgvUsersRoles.Rows[e.RowIndex].Cells["userIdColumn"].Value.ToString();
                cbxRoles.SelectedValue = dgvUsersRoles.Rows[e.RowIndex].Cells["roleIdColumn"].Value.ToString();
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            InsertUserToDB();
            LoadUsers();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUserToDB();
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Do you want to delete the user with ID {0}?", CurrentUserId), "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUserToDB();
                LoadUsers();
            }
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            InsertRoleToDB();
            LoadRoles();
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            UpdateRoleToDB();
            LoadRoles();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Do you want to delete the role with ID {0}?", CurrentRoleId), "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteRoleToDB();
                LoadRoles();
            }
        }

        private void btnAddNewUserRole_Click(object sender, EventArgs e)
        {
            InsertUserRoleToDB();
            LoadUsersRoles();
        }

        private void btnUpdateUserRole_Click(object sender, EventArgs e)
        {
            UpdateUserRoleToDB();
            LoadUsersRoles();
        }

        private void btnDeleteUserRole_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this user/role?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUserRoleToDB();
                LoadUsersRoles();
            }
        }


        #endregion

        #region Methods
        //private void LoadUserNames()
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("[dbo].[GetUserNames]", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                {
        //                    DataTable dt = new DataTable();
        //                    da.Fill(dt);
        //                    if (dt.Rows.Count > 0)
        //                    {
        //                        cbxUserName.DataSource = dt;
        //                        cbxUserName.DisplayMember = "UserName";
        //                        cbxUserName.ValueMember = "UserId";
        //                    }
        //                }
        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
        //        throw;
        //    }
        //}

        private void LoadUsers()
        {
            DataTable dt = GetUsersFromDB();
            getUsersBindingSource.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                cbxUserName.DataSource = dt;
                cbxUserName.DisplayMember = "Username";
                cbxUserName.ValueMember = "UserID";
            }
        }

        private void LoadRoles()
        {
            DataTable dt = GetRolesFromDB();
            getRolesBindingSource.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                cbxRoles.DataSource = dt;
                cbxRoles.DisplayMember = "Role";
                cbxRoles.ValueMember = "Id";
            }
        }

        private void LoadUsersRoles()
        {
            getUsersRolesBindingSource.DataSource = GetUsersRolesFromDB();
        }

        private DataTable GetUsersFromDB()
        {
            DataTable usersDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetUsers]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(usersDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return usersDT;
        }

        private DataTable GetRolesFromDB()
        {
            DataTable rolesDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetRoles]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(rolesDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return rolesDT;
        }

        private DataTable GetUsersRolesFromDB()
        {
            DataTable usersRolesDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetUsersRoles]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(usersRolesDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return usersRolesDT;
        }

        private void InsertUserToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertUser]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void UpdateUserToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateUser]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", CurrentUserId);
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void DeleteUserToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteUser]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void InsertRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Role", txtUsername.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void UpdateRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", CurrentRoleId);
                        cmd.Parameters.AddWithValue("@Role", txtUsername.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void DeleteRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", CurrentRoleId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void InsertUserRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertUserRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", cbxUserName.SelectedValue);
                        cmd.Parameters.AddWithValue("@RoleId", cbxRoles.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void UpdateUserRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateUserRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", cbxUserName.SelectedValue);
                        cmd.Parameters.AddWithValue("@RoleId", cbxRoles.SelectedValue);
                        cmd.Parameters.AddWithValue("@oldRoleId", CurrentUserRoleRoleId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private void DeleteUserRoleToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteUserRole]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", cbxUserName.SelectedValue);
                        cmd.Parameters.AddWithValue("@RoleId", cbxRoles.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        #endregion

    }
}
