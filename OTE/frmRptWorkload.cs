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
    public partial class frmRptWorkload : Form
    {
        public frmRptWorkload()
        {
            InitializeComponent();
        }

        #region Events

        private void frmRptWorkload_Load(object sender, EventArgs e)
        {
            ColorConverter cc = new ColorConverter();
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).BackColoring))
                this.BackColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).BackColoring);
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).ForeColoring))
                this.ForeColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).ForeColoring);

            LoadUsers();
        }

        private void btnFilterModem_Click(object sender, EventArgs e)
        {
            dgvModems.DataSource = GetRptWorkloadFromDB(dtpDateFromModem.Checked ? dtpDateFromModem.Value.Date : Helpers.GetDefaultDate(), dtpDateToModem.Checked ? dtpDateToModem.Value.Date : Helpers.GetDefaultDate(), int.Parse(cbxUsersModem.SelectedValue.ToString()));
        }

        #endregion

        #region Methods

        private void LoadUsers()
        {
            DataTable dt = GetUsersFromDB();
            if (dt.Rows.Count > 0)
            {
                cbxUsersModem.DataSource = dt;
                cbxUsersModem.DisplayMember = "Username";
                cbxUsersModem.ValueMember = "UserID";
            }
        }

        private DataTable GetUsersFromDB()
        {
            DataTable usersDT = new DataTable();
            //usersDT.Rows.Add(new DataRow(""))
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetUsers]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(usersDT);

                        DataRow dr = usersDT.NewRow();
                        dr["Username"] = "Select";
                        dr["UserID"] = "-1";
                        usersDT.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            DataView dv = usersDT.DefaultView;
            dv.Sort = "UserID asc";
            DataTable sortedDT = dv.ToTable();

            return sortedDT;
        }

        private DataTable GetRptWorkloadFromDB(DateTime? dateFrom, DateTime? dateTo, int userId)
        {
            DataTable modemsDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetRptWorkload]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", dateFrom);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", dateTo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(modemsDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            return modemsDT;
        }

        #endregion
    }
}
