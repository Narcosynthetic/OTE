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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //var username = txtUserName.Text;
                //var password = txtPassword.Text;
                var username = "papas";
                var password = "papas";


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

                                if (dTable.Rows[0]["AccessLevel"].ToString() == "1")
                                {
                                    AdministratorManagmentDisplay amd = new AdministratorManagmentDisplay(_userName, _userId);
                                    amd.Show();
                                }
                                else if (dTable.Rows[0][0].ToString() == "2")
                                {
                                    AdministratorManagmentDisplay amd = new AdministratorManagmentDisplay(_userName, _userId);
                                    amd.Show();
                                }
                                else if (dTable.Rows[0][0].ToString() == "3")
                                {
                                    AdministratorManagmentDisplay amd = new AdministratorManagmentDisplay(_userName, _userId);
                                    amd.Show();
                                }

                                this.Hide();
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

