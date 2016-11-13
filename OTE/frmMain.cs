using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private string[] Roles
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

        public frmMain(int userId, string userName, string[] roles)
        {
            InitializeComponent();

            UserId = userId;
            UserName = userName;
            Roles = roles;
        }

        #endregion

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Welcome " + UserName;
            ManageUserAccess();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mniModems_Click(object sender, EventArgs e)
        {
            frmModemInspection frmModemInspection = new frmModemInspection();
            frmModemInspection.MdiParent = this;
            frmModemInspection.Show();
        }

        private void mniSapManagement_Click(object sender, EventArgs e)
        {
            frmSapsManagement frmSapsManagement = new frmSapsManagement();
            frmSapsManagement.MdiParent = this;
            frmSapsManagement.Show();
        }

        private void mniUsersRoles_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.MdiParent = this;
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
                    mniReport1.Enabled = true;
                    mniReport2.Enabled = true;
                }

                if ((Enums.UserRoles)Enum.Parse(typeof(Enums.UserRoles), roleId) == Enums.UserRoles.Technician)
                {
                    mniModemsInspection.Enabled = true;
                    mniModemsManagement.Enabled = true;
                    mniSatelitesInspection.Enabled = true;
                }

            }
        }

        #endregion

    }
}
