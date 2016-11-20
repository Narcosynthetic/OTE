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
        private int SapId
        {
            get;
            set;
        }

        #endregion

        public frmSapsManagement()
        {
            InitializeComponent();
        }

        #region Events

        private void SapsManagement_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            LoadTypoiMyxanhmatwn();
        }

        private void btnAddSap_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                InsertSapToDB();
                PopulateGrid();
                ClearForm();
            }
        }

        private void btnUpdateSap_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update this Sap ?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    UpdateSapToDB();
                PopulateGrid();
                ClearForm();
            }
        }

        private void btnDeleteSap_Click(object sender, EventArgs e)
        {
            if (SapId != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this Sap ?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    DeleteSapToDB();
                PopulateGrid();
                ClearForm();
            }
        }

        private void dvgSap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SapId = int.Parse(dvgSap.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                txtSap.Text = dvgSap.Rows[e.RowIndex].Cells["SAP"].Value.ToString();
                cbxCategory.SelectedValue = dvgSap.Rows[e.RowIndex].Cells["TyposId"].Value.ToString();
            }
        }

        #endregion

        #region Methods

        //private void LoadSap(int SapId)
        //{
        //    DataTable SapDT = GetSapFromDB(SapId);
        //    if (SapDT.Rows.Count > 0)
        //    {
        //        DataRow sap = SapDT.Rows[0];
        //        txtSap.Text = sap["Sap"].ToString();
        //        cbxCategory.SelectedValue = sap["TyposMhxanhmatosId"].ToString();

        //    }
        //}

        //private DataTable GetSapFromDB(int SapId)
        //{
        //    DataTable modemDT = new DataTable();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("[dbo].[GetSap]", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@id", SapId);
        //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //                    da.Fill(modemDT);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
        //        throw;
        //    }
        //    return modemDT;
        //}

        private bool ValidateInput()
        {
            bool isValid = true;
            lblErrSap.Visible = false;

            try
            {
                if (string.IsNullOrEmpty(txtSap.Text.Trim()))
                {
                    isValid = false;
                    lblErrSap.Text = "*Το πεδίο είναι υποχρεωτικό.";
                    lblErrSap.Visible = true;
                }

                if (!Helpers.IsNumeric(txtSap.Text.Trim()))
                {
                    isValid = false;
                    lblErrSap.Text = "*Βαλεεε ΑΡΙΘΜΟΟΟΟ.";
                    lblErrSap.Visible = true;
                }

                return isValid;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ClearForm()
        {

            try
            {
                txtSap.Text = string.Empty;
                cbxCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

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

        private void LoadTypoiMyxanhmatwn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetTypoiMhxanhmatwn]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                cbxCategory.DataSource = dt;
                                cbxCategory.DisplayMember = "TyposDescr";
                                cbxCategory.ValueMember = "Id";
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
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
                        cmd.Parameters.AddWithValue("@Sap", int.Parse(txtSap.Text.Trim()));
                        cmd.Parameters.AddWithValue("@TyposMhxanhmatos", int.Parse(cbxCategory.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        ClearForm();
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
                        cmd.Parameters.AddWithValue("@Id", SapId);
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

        private void UpdateSapToDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateSap]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Sap", txtSap.Text);
                        cmd.Parameters.AddWithValue("@TyposMhxanhmatosId", int.Parse(cbxCategory.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@Id", SapId);
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
