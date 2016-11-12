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
    public partial class SapsManagement : Form
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

        public SapsManagement()
        {
            InitializeComponent();
        }

        public SapsManagement(string userName, int userId)
        {
            InitializeComponent();

            UserName = userName;
            UserId = userId;
            lblUserName.Text = "Welcome " + UserName;

        }

        private void SapsManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAPDataSet.SAP' table. You can move, or remove it, as needed.
            this.sAPTableAdapter.Fill(this.sAPDataSet.SAP);

        }

        #region Methods

        private void PopulateGrid()
        {
            try
            {
                //for (int i = 0; i < g.Rows.Count; ++i)
                //{
                //    DataGridViewComboBoxCell cell = dgvSaps.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                //        cell.Items.Clear();
                //        cell.Items.Add("one");
                //        cell.Items.Add("two");
                //        cell.Items.Add("three");
                //}
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

    }
}
