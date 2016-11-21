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
    public partial class frmMain : Form
    {
        #region Properties
        public int UserId
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string[] Roles
        {
            get;
            set;
        }

        public string BackColoring
        {
            get;
            set;
        }

        public string ForeColoring
        {
            get;
            set;
        }

        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(int userId, string userName, string[] roles, string backColor, string foreColor)
        {
            InitializeComponent();

            UserId = userId;
            UserName = userName;
            Roles = roles;
            BackColoring = backColor;
            ForeColoring = foreColor;
        }

        #endregion

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Welcome " + UserName;
            ManageUserAccess();
            LoadHomeForm();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mniHome_Click(object sender, EventArgs e)
        {
            LoadHomeForm();
        }

        private void mniWorkload_Click(object sender, EventArgs e)
        {
            frmRptWorkload frmRptWorkload = new frmRptWorkload();
            frmRptWorkload.MdiParent = this;
            frmRptWorkload.StartPosition = FormStartPosition.Manual;
            frmRptWorkload.Location = new Point(0, 0);
            frmRptWorkload.Show();
        }

        private void mniStatistics_Click(object sender, EventArgs e)
        {
            frmRptStatistics frmRptStatistics = new frmRptStatistics();
            frmRptStatistics.MdiParent = this;
            frmRptStatistics.StartPosition = FormStartPosition.Manual;
            frmRptStatistics.Location = new Point(0, 0);
            frmRptStatistics.Show();
        }

        private void mniModems_Click(object sender, EventArgs e)
        {
            LoadModemsForm();
        }

        private void mniSapManagement_Click(object sender, EventArgs e)
        {
            frmSapsManagement frmSapsManagement = new frmSapsManagement();
            frmSapsManagement.MdiParent = this;
            frmSapsManagement.StartPosition = FormStartPosition.Manual;
            frmSapsManagement.Location = new Point(0, 0);
            frmSapsManagement.Show();
        }

        private void mniUsersRoles_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.MdiParent = this;
            frmUsersManagement.StartPosition = FormStartPosition.Manual;
            frmUsersManagement.Location = new Point(0, 0);
            frmUsersManagement.Show();
        }

        #endregion

        #region Methods

        private void ManageUserAccess()
        {
            foreach (var roleId in Roles)
            {
                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Administrator)
                {
                    mniUsersRoles.Enabled = true;
                }

                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Supervisor)
                {
                    mniSapManagement.Enabled = true;
                    mniWorkload.Enabled = true;
                    mniStatistics.Enabled = true;
                }

                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Technician)
                {
                    mniModemsInspection.Enabled = true;
                    mniSatelitesInspection.Enabled = true;
                    mniIptvsInspection.Enabled = true;
                    LoadHabits();
                }

            }
        }

        private void LoadHabits()
        {
            DataTable habitsDT = GetLatestAction();
            if (habitsDT.Rows.Count > 0)
            {
                //Check for at least one valid date
                if (DateTime.Parse(habitsDT.Rows[0]["ModemDate"].ToString()) > Helpers.GetDefaultDate()
                    || DateTime.Parse(habitsDT.Rows[0]["SatelliteDate"].ToString()) > Helpers.GetDefaultDate()
                    || DateTime.Parse(habitsDT.Rows[0]["IptvDate"].ToString()) > Helpers.GetDefaultDate())
                {
                    //Compare dates to get the most recent
                    if (DateTime.Parse(habitsDT.Rows[0]["ModemDate"].ToString()) > DateTime.Parse(habitsDT.Rows[0]["SatelliteDate"].ToString()))
                    {
                        if (DateTime.Parse(habitsDT.Rows[0]["ModemDate"].ToString()) > DateTime.Parse(habitsDT.Rows[0]["IptvDate"].ToString()))
                        {
                            LoadModemsForm();
                        }
                        else
                        {
                            //TODO: LoadIptvForm();
                        }
                    }
                    else
                    {
                        if (DateTime.Parse(habitsDT.Rows[0]["SatelliteDate"].ToString()) > DateTime.Parse(habitsDT.Rows[0]["IptvDate"].ToString()))
                        {
                            //TODO: LoadSatelliteForm();
                        }
                        else
                        {
                            //TODO: LoadIptvForm();
                        }
                    }
                }
            }
        }

        private void LoadHomeForm()
        {
            frmHome frmHome = new frmHome();
            frmHome.MdiParent = this;
            frmHome.StartPosition = FormStartPosition.Manual;

            int leftStart = this.ClientSize.Width - (frmHome.Width + (SystemInformation.Border3DSize.Width * 2));
            //int topStart = this.ClientSize.Height - (frmHome.Height + (SystemInformation.Border3DSize.Height * 2));

            frmHome.Location = new Point(leftStart, 0);
            frmHome.Show();
        }

        private void LoadModemsForm()
        {
            frmModemInspection frmModemInspection = new frmModemInspection();
            frmModemInspection.MdiParent = this;
            frmModemInspection.StartPosition = FormStartPosition.Manual;
            frmModemInspection.Location = new Point(0, 0);
            frmModemInspection.Show();
        }

        private DataTable GetLatestAction()
        {
            DataTable habitsDT = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetLatestAction]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(habitsDT);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            return habitsDT;
        }

        #endregion

    }
}
