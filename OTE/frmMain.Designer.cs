namespace OTE
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.mniModemsInspection = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSatelitesInspection = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSapManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWorkload = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAdministrator = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUsersRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mniIptvsInspection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHome,
            this.mniEquipment,
            this.mniReports,
            this.mniAdministrator});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(611, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "File";
            // 
            // mniHome
            // 
            this.mniHome.Name = "mniHome";
            this.mniHome.Size = new System.Drawing.Size(52, 20);
            this.mniHome.Text = "Home";
            this.mniHome.Click += new System.EventHandler(this.mniHome_Click);
            // 
            // mniEquipment
            // 
            this.mniEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniModemsInspection,
            this.mniSatelitesInspection,
            this.mniIptvsInspection,
            this.mniSapManagement});
            this.mniEquipment.Name = "mniEquipment";
            this.mniEquipment.Size = new System.Drawing.Size(77, 20);
            this.mniEquipment.Text = "Equipment";
            // 
            // mniModemsInspection
            // 
            this.mniModemsInspection.Enabled = false;
            this.mniModemsInspection.Name = "mniModemsInspection";
            this.mniModemsInspection.Size = new System.Drawing.Size(179, 22);
            this.mniModemsInspection.Text = "Modems Inspection";
            this.mniModemsInspection.Click += new System.EventHandler(this.mniModems_Click);
            // 
            // mniSatelitesInspection
            // 
            this.mniSatelitesInspection.Enabled = false;
            this.mniSatelitesInspection.Name = "mniSatelitesInspection";
            this.mniSatelitesInspection.Size = new System.Drawing.Size(179, 22);
            this.mniSatelitesInspection.Text = "Satellites Inspection";
            // 
            // mniSapManagement
            // 
            this.mniSapManagement.Enabled = false;
            this.mniSapManagement.Name = "mniSapManagement";
            this.mniSapManagement.Size = new System.Drawing.Size(179, 22);
            this.mniSapManagement.Text = "SAP Management";
            this.mniSapManagement.Click += new System.EventHandler(this.mniSapManagement_Click);
            // 
            // mniReports
            // 
            this.mniReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniWorkload,
            this.mniStatistics});
            this.mniReports.Name = "mniReports";
            this.mniReports.Size = new System.Drawing.Size(59, 20);
            this.mniReports.Text = "Reports";
            // 
            // mniWorkload
            // 
            this.mniWorkload.Enabled = false;
            this.mniWorkload.Name = "mniWorkload";
            this.mniWorkload.Size = new System.Drawing.Size(125, 22);
            this.mniWorkload.Text = "Workload";
            this.mniWorkload.Click += new System.EventHandler(this.mniWorkload_Click);
            // 
            // mniStatistics
            // 
            this.mniStatistics.Enabled = false;
            this.mniStatistics.Name = "mniStatistics";
            this.mniStatistics.Size = new System.Drawing.Size(125, 22);
            this.mniStatistics.Text = "Statistics";
            this.mniStatistics.Click += new System.EventHandler(this.mniStatistics_Click);
            // 
            // mniAdministrator
            // 
            this.mniAdministrator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUsersRoles});
            this.mniAdministrator.Name = "mniAdministrator";
            this.mniAdministrator.Size = new System.Drawing.Size(92, 20);
            this.mniAdministrator.Text = "Administrator";
            // 
            // mniUsersRoles
            // 
            this.mniUsersRoles.Enabled = false;
            this.mniUsersRoles.Name = "mniUsersRoles";
            this.mniUsersRoles.Size = new System.Drawing.Size(146, 22);
            this.mniUsersRoles.Text = "Users && Roles";
            this.mniUsersRoles.Click += new System.EventHandler(this.mniUsersRoles_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMessage,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslMessage
            // 
            this.tslMessage.Name = "tslMessage";
            this.tslMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // mniIptvsInspection
            // 
            this.mniIptvsInspection.Enabled = false;
            this.mniIptvsInspection.Name = "mniIptvsInspection";
            this.mniIptvsInspection.Size = new System.Drawing.Size(179, 22);
            this.mniIptvsInspection.Text = "IPTV\'s Inspection";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 428);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "OTE Equipment Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniEquipment;
        private System.Windows.Forms.ToolStripMenuItem mniReports;
        private System.Windows.Forms.ToolStripMenuItem mniAdministrator;
        private System.Windows.Forms.ToolStripMenuItem mniModemsInspection;
        private System.Windows.Forms.ToolStripMenuItem mniSatelitesInspection;
        private System.Windows.Forms.ToolStripMenuItem mniSapManagement;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mniUsersRoles;
        private System.Windows.Forms.ToolStripMenuItem mniWorkload;
        private System.Windows.Forms.ToolStripMenuItem mniStatistics;
        private System.Windows.Forms.ToolStripMenuItem mniHome;
        private System.Windows.Forms.ToolStripMenuItem mniIptvsInspection;
    }
}