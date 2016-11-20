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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        #region Events

        private void frmHome_Load(object sender, EventArgs e)
        {
            foreach (var roleId in ((frmMain)this.MdiParent).Roles)
            {
                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Technician)
                {
                    LoadTechnicianStats();
                    pnlTechnician.Visible = true;
                }

                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Supervisor)
                {
                    LoadSupervisorStats();
                    pnlSupervisor.Visible = true;
                    if (!pnlTechnician.Visible)
                        pnlSupervisor.Location = new Point(12, 12);
                }
            }
        }

        private void btnSetBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void btnSetForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.ForeColor = colorDialog1.Color;
        }

        #endregion

        #region Methods

        private void LoadTechnicianStats()
        {
            DataTable statsDT = GetTechnicianStatsFromDB();
            if (statsDT.Rows.Count > 0)
            {
                lblTechModems.Text = statsDT.Rows[0]["TotalModems"].ToString();
                lblTechIptvs.Text = statsDT.Rows[0]["TotalIPTVs"].ToString();
                lblTechSatellites.Text = statsDT.Rows[0]["TotalSatellites"].ToString();
            }
        }

        private void LoadSupervisorStats()
        {
            DataTable statsDT = GetSupervisorStatsFromDB();
            if (statsDT.Rows.Count > 0)
            {
                lblSuperModems.Text = statsDT.Rows[0]["TotalModems"].ToString();
                lblSuperIptvs.Text = statsDT.Rows[0]["TotalIPTVs"].ToString();
                lblSuperSatellites.Text = statsDT.Rows[0]["TotalSatellites"].ToString();
            }
        }

        private DataTable GetTechnicianStatsFromDB()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetWorkloadStats]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", ((frmMain)this.MdiParent).UserId);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", DateTime.Today.AddDays(-7));
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", DateTime.Today);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(dt);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                string error = ex.Message; //sto message property einai apothhkeymenh h timh toy error
                throw;
            }
        }

        private DataTable GetSupervisorStatsFromDB()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetWorkloadStats]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", string.Empty);
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouApo", DateTime.Today.AddDays(-7));
                        cmd.Parameters.AddWithValue("@hmeromhniaElenxouEos", DateTime.Today);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(dt);
                    }
                }

                return dt;
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
