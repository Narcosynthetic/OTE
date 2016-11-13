using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OTE
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //var username = txtUserName.Text.Trim();
                //var password = txtPassword.Text.Trim();

                var username = "papas";
                var password = "papas";

                bool isValid = true;
                if (String.IsNullOrEmpty(username))
                {
                    lblMandatoryUserName.Visible = true;
                    isValid = false;
                }
                else
                    lblMandatoryUserName.Visible = false;

                if (String.IsNullOrEmpty(password))
                {
                    lblMandatoryPassword.Visible = true;
                    isValid = false;
                }
                else
                    lblMandatoryPassword.Visible = false;

                if (!isValid)
                    return;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetUserDetails]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dTable = new DataTable();
                            da.Fill(dTable);

                            if (dTable.Rows.Count > 0)
                            {
                                var _userName = dTable.Rows[0]["UserName"].ToString();
                                var _userId = int.Parse(dTable.Rows[0]["UserID"].ToString());
                                var _roles = dTable.Rows[0]["Roles"].ToString();

                                if (String.IsNullOrEmpty(_roles))
                                {
                                    lblNoAccess.Text = "This user has no roles. Please contact your administrator.";
                                    lblNoAccess.Visible = true;
                                    return;
                                }

                                string[] roles = _roles.Split(new char[] { ',' });
                                frmMain frmMain = new frmMain(_userId, _userName, roles);
                                frmMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                lblNoAccess.Text = "No user was found with these credentials. Please contact your administrator.";
                                lblNoAccess.Visible = true;
                            }

                        }
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }


        }

    }
}

