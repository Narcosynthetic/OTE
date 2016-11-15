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
            PopulateGrid();
        }

        #region Methods

        private void PopulateGrid()
        {
            try
            {
                getSapsDetailsBindingSource.DataSource = GetSapsTechFromDb();
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
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetSapsDetails]", conn))
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


        private void btnAddSap_Click(object sender, EventArgs e)
        {
            InsertSapToDB();
            PopulateGrid();
        }

        private void btnUpdateSap_Click(object sender, EventArgs e)
        {

            PopulateGrid();

        }

        private void btnDeleteSap_Click(object sender, EventArgs e)
        {
            //DeleteSapToDB();
            PopulateGrid();

        }

        private void InsertSapToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertSap]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Sap", txbSap.Text.Trim());
                        cmd.Parameters.AddWithValue("@TyposMhxanhmatos", txbCategory.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }

        }

        private void DeleteSapToDB()
        {          
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteSap]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Sap", txbSap.Text.Trim());
                        cmd.Parameters.AddWithValue("@TyposMhxanhmatos", txbCategory.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }

        }
                

    }
}
