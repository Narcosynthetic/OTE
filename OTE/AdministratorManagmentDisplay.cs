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
    public partial class AdministratorManagmentDisplay : Form
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

        public AdministratorManagmentDisplay(string userName, int userId)
        {
            InitializeComponent();

            UserName = userName;
            UserId = userId;
            lblUserName.Text = "Welcome " + UserName;

        }

        public AdministratorManagmentDisplay()
        {
            InitializeComponent();
        }

        private void btnModems_Click(object sender, EventArgs e)
        {
            ModemInspection mI = new ModemInspection(UserName, UserId);
            mI.Show();
            this.Hide();
        }

        private void btnManageSAPs_Click(object sender, EventArgs e)
        {
            SapsManagement mI = new SapsManagement(UserName, UserId);
            mI.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UsersManagement mI = new UsersManagement(UserName, UserId);
            mI.Show();
            this.Hide();
        }
    }
}
