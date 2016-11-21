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
    public partial class frmRptStatistics : Form
    {
        public frmRptStatistics()
        {
            InitializeComponent();
        }

        #region Events

        private void frmRptStatistics_Load(object sender, EventArgs e)
        {
            ColorConverter cc = new ColorConverter();
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).BackColoring))
                this.BackColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).BackColoring);
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).ForeColoring))
                this.ForeColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).ForeColoring);

            LoadUsers();
        }

        private void btnFilterByUsers_Click(object sender, EventArgs e)
        {
            dgvByUsers.DataSource = GetRptStatisticsByUserFromDB(dtpDateFromUser.Checked ? dtpDateFromUser.Value.Date : Helpers.GetDefaultDate(), dtpDateToUser.Checked ? dtpDateToUser.Value.Date : Helpers.GetDefaultDate(), int.Parse(cbxUsersUser.SelectedValue.ToString()));
        }

        private void btnFilterBySap_Click(object sender, EventArgs e)
        {
            dgvBySap.DataSource = GetRptStatisticsBySapFromDB(dtpDateFromSap.Checked ? dtpDateFromSap.Value.Date : Helpers.GetDefaultDate(), dtpDateToSap.Checked ? dtpDateToSap.Value.Date : Helpers.GetDefaultDate(), int.Parse(cbxUsersSap.SelectedValue.ToString()));
        }

        #endregion

        #region Methods

        private void LoadUsers()
        {
            DataTable dt = GetUsersFromDB();
            if (dt.Rows.Count > 0)
            {
                cbxUsersUser.DataSource = dt;
                cbxUsersUser.DisplayMember = "Username";
                cbxUsersUser.ValueMember = "UserID";

                cbxUsersSap.DataSource = dt;
                cbxUsersSap.DisplayMember = "Username";
                cbxUsersSap.ValueMember = "UserID";
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

        private DataTable GetRptStatisticsByUserFromDB(DateTime? dateFrom, DateTime? dateTo, int userId)
        {
            DataTable byUserDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetRptStatisticsByUser]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", dateFrom);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", dateTo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(byUserDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            return byUserDT;
        }

        private DataTable GetRptStatisticsBySapFromDB(DateTime? dateFrom, DateTime? dateTo, int userId)
        {
            DataTable bySapDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetRptStatisticsBySap]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", dateFrom);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", dateTo);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(bySapDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            return bySapDT;
        }

        #endregion

    }
}
