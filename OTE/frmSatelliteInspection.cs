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
    public partial class frmSatelliteInspection : Form
    {
        public frmSatelliteInspection()
        {
            InitializeComponent();
        }

        private void frmSatInspection_Load(object sender, EventArgs e)
        {
            ColorConverter cc = new ColorConverter();
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).BackColoring))
                this.BackColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).BackColoring);
            if (!string.IsNullOrEmpty(((frmMain)this.MdiParent).ForeColoring))
                this.ForeColor = (Color)cc.ConvertFromString(((frmMain)this.MdiParent).ForeColoring);
            
        }
    }
}
