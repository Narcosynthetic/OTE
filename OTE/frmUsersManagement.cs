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
        private int UserId
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
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                UserId = int.Parse(id);
                txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            }
        }

        #endregion

        #region Methods


        private void LoadUsers()
        {
            getUsersBindingSource.DataSource = GetUsersFromDB();
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


        #endregion

    }
}
