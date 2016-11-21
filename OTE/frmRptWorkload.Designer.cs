namespace OTE
{
    partial class frmRptWorkload
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptWorkload));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvModems = new System.Windows.Forms.DataGridView();
            this.getRptWorkloadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaxeirhshExoplismouOTEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.cbxUsersModem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterModem = new System.Windows.Forms.Button();
            this.dtpDateToModem = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateFromModem = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.getRptWorkloadTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetRptWorkloadTableAdapter();
            this.userFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmeromhniaElenxouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dslDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.internetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wlanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wpsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lan1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lan2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lan3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stbDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiKereasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiLedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiTrofodotikoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiKapakiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiVismatosTrofodosiasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiFirmwareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allagiPackBoxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paratiriseisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okOffUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRptWorkloadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvModems);
            this.groupBox1.Controls.Add(this.cbxUsersModem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilterModem);
            this.groupBox1.Controls.Add(this.dtpDateToModem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpDateFromModem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modems";
            // 
            // dgvModems
            // 
            this.dgvModems.AllowUserToAddRows = false;
            this.dgvModems.AllowUserToDeleteRows = false;
            this.dgvModems.AutoGenerateColumns = false;
            this.dgvModems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userFullNameDataGridViewTextBoxColumn,
            this.hmeromhniaElenxouDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.sapDataGridViewTextBoxColumn,
            this.powerDataGridViewCheckBoxColumn,
            this.dslDataGridViewCheckBoxColumn,
            this.internetDataGridViewCheckBoxColumn,
            this.wlanDataGridViewCheckBoxColumn,
            this.wpsDataGridViewCheckBoxColumn,
            this.lan1DataGridViewCheckBoxColumn,
            this.lan2DataGridViewCheckBoxColumn,
            this.lan3DataGridViewCheckBoxColumn,
            this.stbDataGridViewCheckBoxColumn,
            this.allagiKereasDataGridViewCheckBoxColumn,
            this.allagiLedDataGridViewCheckBoxColumn,
            this.allagiTrofodotikoDataGridViewCheckBoxColumn,
            this.allagiKapakiDataGridViewCheckBoxColumn,
            this.allagiVismatosTrofodosiasDataGridViewCheckBoxColumn,
            this.allagiFirmwareDataGridViewCheckBoxColumn,
            this.allagiPackBoxDataGridViewCheckBoxColumn,
            this.paratiriseisDataGridViewTextBoxColumn,
            this.okOffUpdateDataGridViewTextBoxColumn});
            this.dgvModems.DataSource = this.getRptWorkloadBindingSource;
            this.dgvModems.Location = new System.Drawing.Point(12, 70);
            this.dgvModems.Name = "dgvModems";
            this.dgvModems.Size = new System.Drawing.Size(962, 166);
            this.dgvModems.TabIndex = 45;
            // 
            // getRptWorkloadBindingSource
            // 
            this.getRptWorkloadBindingSource.DataMember = "GetRptWorkload";
            this.getRptWorkloadBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSetBindingSource;
            // 
            // diaxeirhshExoplismouOTEDataSetBindingSource
            // 
            this.diaxeirhshExoplismouOTEDataSetBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSet;
            this.diaxeirhshExoplismouOTEDataSetBindingSource.Position = 0;
            // 
            // diaxeirhshExoplismouOTEDataSet
            // 
            this.diaxeirhshExoplismouOTEDataSet.DataSetName = "DiaxeirhshExoplismouOTEDataSet";
            this.diaxeirhshExoplismouOTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxUsersModem
            // 
            this.cbxUsersModem.FormattingEnabled = true;
            this.cbxUsersModem.Location = new System.Drawing.Point(224, 42);
            this.cbxUsersModem.Name = "cbxUsersModem";
            this.cbxUsersModem.Size = new System.Drawing.Size(134, 21);
            this.cbxUsersModem.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Users";
            // 
            // btnFilterModem
            // 
            this.btnFilterModem.Location = new System.Drawing.Point(377, 40);
            this.btnFilterModem.Name = "btnFilterModem";
            this.btnFilterModem.Size = new System.Drawing.Size(75, 23);
            this.btnFilterModem.TabIndex = 42;
            this.btnFilterModem.Text = "Filter";
            this.btnFilterModem.UseVisualStyleBackColor = true;
            this.btnFilterModem.Click += new System.EventHandler(this.btnFilterModem_Click);
            // 
            // dtpDateToModem
            // 
            this.dtpDateToModem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateToModem.Location = new System.Drawing.Point(122, 43);
            this.dtpDateToModem.Name = "dtpDateToModem";
            this.dtpDateToModem.ShowCheckBox = true;
            this.dtpDateToModem.Size = new System.Drawing.Size(96, 20);
            this.dtpDateToModem.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Date To";
            // 
            // dtpDateFromModem
            // 
            this.dtpDateFromModem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFromModem.Location = new System.Drawing.Point(12, 43);
            this.dtpDateFromModem.Name = "dtpDateFromModem";
            this.dtpDateFromModem.ShowCheckBox = true;
            this.dtpDateFromModem.Size = new System.Drawing.Size(96, 20);
            this.dtpDateFromModem.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Date From";
            // 
            // getRptWorkloadTableAdapter
            // 
            this.getRptWorkloadTableAdapter.ClearBeforeFill = true;
            // 
            // userFullNameDataGridViewTextBoxColumn
            // 
            this.userFullNameDataGridViewTextBoxColumn.DataPropertyName = "UserFullName";
            this.userFullNameDataGridViewTextBoxColumn.HeaderText = "Technician";
            this.userFullNameDataGridViewTextBoxColumn.Name = "userFullNameDataGridViewTextBoxColumn";
            this.userFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hmeromhniaElenxouDataGridViewTextBoxColumn
            // 
            this.hmeromhniaElenxouDataGridViewTextBoxColumn.DataPropertyName = "HmeromhniaElenxou";
            this.hmeromhniaElenxouDataGridViewTextBoxColumn.HeaderText = "Inspection Date";
            this.hmeromhniaElenxouDataGridViewTextBoxColumn.Name = "hmeromhniaElenxouDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "S/N";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // sapDataGridViewTextBoxColumn
            // 
            this.sapDataGridViewTextBoxColumn.DataPropertyName = "Sap";
            this.sapDataGridViewTextBoxColumn.HeaderText = "SAP";
            this.sapDataGridViewTextBoxColumn.Name = "sapDataGridViewTextBoxColumn";
            // 
            // powerDataGridViewCheckBoxColumn
            // 
            this.powerDataGridViewCheckBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewCheckBoxColumn.HeaderText = "Power";
            this.powerDataGridViewCheckBoxColumn.Name = "powerDataGridViewCheckBoxColumn";
            // 
            // dslDataGridViewCheckBoxColumn
            // 
            this.dslDataGridViewCheckBoxColumn.DataPropertyName = "Dsl";
            this.dslDataGridViewCheckBoxColumn.HeaderText = "Dsl";
            this.dslDataGridViewCheckBoxColumn.Name = "dslDataGridViewCheckBoxColumn";
            // 
            // internetDataGridViewCheckBoxColumn
            // 
            this.internetDataGridViewCheckBoxColumn.DataPropertyName = "Internet";
            this.internetDataGridViewCheckBoxColumn.HeaderText = "Internet";
            this.internetDataGridViewCheckBoxColumn.Name = "internetDataGridViewCheckBoxColumn";
            // 
            // wlanDataGridViewCheckBoxColumn
            // 
            this.wlanDataGridViewCheckBoxColumn.DataPropertyName = "Wlan";
            this.wlanDataGridViewCheckBoxColumn.HeaderText = "Wlan";
            this.wlanDataGridViewCheckBoxColumn.Name = "wlanDataGridViewCheckBoxColumn";
            // 
            // wpsDataGridViewCheckBoxColumn
            // 
            this.wpsDataGridViewCheckBoxColumn.DataPropertyName = "Wps";
            this.wpsDataGridViewCheckBoxColumn.HeaderText = "Wps";
            this.wpsDataGridViewCheckBoxColumn.Name = "wpsDataGridViewCheckBoxColumn";
            // 
            // lan1DataGridViewCheckBoxColumn
            // 
            this.lan1DataGridViewCheckBoxColumn.DataPropertyName = "Lan1";
            this.lan1DataGridViewCheckBoxColumn.HeaderText = "Lan1";
            this.lan1DataGridViewCheckBoxColumn.Name = "lan1DataGridViewCheckBoxColumn";
            // 
            // lan2DataGridViewCheckBoxColumn
            // 
            this.lan2DataGridViewCheckBoxColumn.DataPropertyName = "Lan2";
            this.lan2DataGridViewCheckBoxColumn.HeaderText = "Lan2";
            this.lan2DataGridViewCheckBoxColumn.Name = "lan2DataGridViewCheckBoxColumn";
            // 
            // lan3DataGridViewCheckBoxColumn
            // 
            this.lan3DataGridViewCheckBoxColumn.DataPropertyName = "Lan3";
            this.lan3DataGridViewCheckBoxColumn.HeaderText = "Lan3";
            this.lan3DataGridViewCheckBoxColumn.Name = "lan3DataGridViewCheckBoxColumn";
            // 
            // stbDataGridViewCheckBoxColumn
            // 
            this.stbDataGridViewCheckBoxColumn.DataPropertyName = "Stb";
            this.stbDataGridViewCheckBoxColumn.HeaderText = "STB";
            this.stbDataGridViewCheckBoxColumn.Name = "stbDataGridViewCheckBoxColumn";
            // 
            // allagiKereasDataGridViewCheckBoxColumn
            // 
            this.allagiKereasDataGridViewCheckBoxColumn.DataPropertyName = "AllagiKereas";
            this.allagiKereasDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Κεραίας";
            this.allagiKereasDataGridViewCheckBoxColumn.Name = "allagiKereasDataGridViewCheckBoxColumn";
            // 
            // allagiLedDataGridViewCheckBoxColumn
            // 
            this.allagiLedDataGridViewCheckBoxColumn.DataPropertyName = "AllagiLed";
            this.allagiLedDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Led";
            this.allagiLedDataGridViewCheckBoxColumn.Name = "allagiLedDataGridViewCheckBoxColumn";
            // 
            // allagiTrofodotikoDataGridViewCheckBoxColumn
            // 
            this.allagiTrofodotikoDataGridViewCheckBoxColumn.DataPropertyName = "AllagiTrofodotiko";
            this.allagiTrofodotikoDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Τροφοδοτικού";
            this.allagiTrofodotikoDataGridViewCheckBoxColumn.Name = "allagiTrofodotikoDataGridViewCheckBoxColumn";
            // 
            // allagiKapakiDataGridViewCheckBoxColumn
            // 
            this.allagiKapakiDataGridViewCheckBoxColumn.DataPropertyName = "AllagiKapaki";
            this.allagiKapakiDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Καπάκι";
            this.allagiKapakiDataGridViewCheckBoxColumn.Name = "allagiKapakiDataGridViewCheckBoxColumn";
            // 
            // allagiVismatosTrofodosiasDataGridViewCheckBoxColumn
            // 
            this.allagiVismatosTrofodosiasDataGridViewCheckBoxColumn.DataPropertyName = "AllagiVismatosTrofodosias";
            this.allagiVismatosTrofodosiasDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Βύσματος Τροφοδοσίας";
            this.allagiVismatosTrofodosiasDataGridViewCheckBoxColumn.Name = "allagiVismatosTrofodosiasDataGridViewCheckBoxColumn";
            // 
            // allagiFirmwareDataGridViewCheckBoxColumn
            // 
            this.allagiFirmwareDataGridViewCheckBoxColumn.DataPropertyName = "AllagiFirmware";
            this.allagiFirmwareDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή Firmware";
            this.allagiFirmwareDataGridViewCheckBoxColumn.Name = "allagiFirmwareDataGridViewCheckBoxColumn";
            // 
            // allagiPackBoxDataGridViewCheckBoxColumn
            // 
            this.allagiPackBoxDataGridViewCheckBoxColumn.DataPropertyName = "AllagiPackBox";
            this.allagiPackBoxDataGridViewCheckBoxColumn.HeaderText = "Αλλαγή PackBox";
            this.allagiPackBoxDataGridViewCheckBoxColumn.Name = "allagiPackBoxDataGridViewCheckBoxColumn";
            // 
            // paratiriseisDataGridViewTextBoxColumn
            // 
            this.paratiriseisDataGridViewTextBoxColumn.DataPropertyName = "Paratiriseis";
            this.paratiriseisDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.paratiriseisDataGridViewTextBoxColumn.Name = "paratiriseisDataGridViewTextBoxColumn";
            // 
            // okOffUpdateDataGridViewTextBoxColumn
            // 
            this.okOffUpdateDataGridViewTextBoxColumn.DataPropertyName = "StatusDescr";
            this.okOffUpdateDataGridViewTextBoxColumn.HeaderText = "Status";
            this.okOffUpdateDataGridViewTextBoxColumn.Name = "okOffUpdateDataGridViewTextBoxColumn";
            // 
            // frmRptWorkload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 460);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptWorkload";
            this.Text = "Workload Reports";
            this.Load += new System.EventHandler(this.frmRptWorkload_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRptWorkloadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterModem;
        private System.Windows.Forms.DateTimePicker dtpDateToModem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateFromModem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxUsersModem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModems;
        private System.Windows.Forms.BindingSource getRptWorkloadBindingSource;
        private System.Windows.Forms.BindingSource diaxeirhshExoplismouOTEDataSetBindingSource;
        private DiaxeirhshExoplismouOTEDataSet diaxeirhshExoplismouOTEDataSet;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetRptWorkloadTableAdapter getRptWorkloadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hmeromhniaElenxouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn powerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dslDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wlanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wpsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lan1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lan2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lan3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stbDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiKereasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiLedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiTrofodotikoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiKapakiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiVismatosTrofodosiasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiFirmwareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allagiPackBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paratiriseisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okOffUpdateDataGridViewTextBoxColumn;
    }
}