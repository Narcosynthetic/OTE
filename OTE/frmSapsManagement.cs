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
    public partial class frmSapsManagement : Form
    {
        #region Properties
        private int UserId
        {
            get;
            set;
        }

        private string UserName
        {
            get;
            set;
        }

        #endregion

        public frmSapsManagement()
        {
            InitializeComponent();
        }

        private void SapsManagement_Load(object sender, EventArgs e)
        {
            GetSapsTechFromDb();

        }

        #region Methods

        private void PopulateGrid()
        {
            try
            {
                sAPBindingSource.DataSource = GetSapsTechFromDb();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private DataTable GetSapsTechFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetSapsTechDiscr]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            da.Fill(dt);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
            return dt;
        }

        #endregion

    }

}
