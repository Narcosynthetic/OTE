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
    public partial class frmSupervisorManagmentDisplay : Form
    {
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

        public frmSupervisorManagmentDisplay(string userName, int userId)
        {
            InitializeComponent();

            UserName = userName;
            UserId = userId;
            lblUserName.Text = "Welcome " + UserName;

        }

        public frmSupervisorManagmentDisplay()
        {
            InitializeComponent();
        }

        private void btnModems_Click(object sender, EventArgs e)
        {
            frmModemInspection mI = new frmModemInspection(UserName, UserId);
            mI.Show();
            this.Hide();
        }

        private void btnManageSAPs_Click(object sender, EventArgs e)
        {
            frmSapsManagement mI = new frmSapsManagement();
            mI.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement mI = new frmUsersManagement();
            mI.Show();
            this.Hide();
        }
    }
}
