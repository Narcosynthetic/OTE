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
    public partial class frmUsersManagement : Form
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

        public frmUsersManagement()
        {
            InitializeComponent();
        }
        public frmUsersManagement(string userName, int userId)
        {
            InitializeComponent();

            UserName = userName;
            UserId = userId;
            lblUserName.Text = "Welcome " + UserName;
        }

    }
}
