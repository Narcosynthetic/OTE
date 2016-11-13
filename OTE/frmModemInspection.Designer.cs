namespace OTE
{
    partial class frmModemInspection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModemInspection));
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtOk = new System.Windows.Forms.RadioButton();
            this.rbtOff = new System.Windows.Forms.RadioButton();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbPower = new System.Windows.Forms.CheckBox();
            this.chbDsl = new System.Windows.Forms.CheckBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.chbWlan = new System.Windows.Forms.CheckBox();
            this.chbWps = new System.Windows.Forms.CheckBox();
            this.chbLan1 = new System.Windows.Forms.CheckBox();
            this.chbLan2 = new System.Windows.Forms.CheckBox();
            this.chbLan3 = new System.Windows.Forms.CheckBox();
            this.chbStb = new System.Windows.Forms.CheckBox();
            this.chbChangeAntenna = new System.Windows.Forms.CheckBox();
            this.chbChangeLed = new System.Windows.Forms.CheckBox();
            this.chbChangeSupply = new System.Windows.Forms.CheckBox();
            this.chbChangePlastic = new System.Windows.Forms.CheckBox();
            this.chbChangeSupplyInput = new System.Windows.Forms.CheckBox();
            this.chbFirmware = new System.Windows.Forms.CheckBox();
            this.chbPackBox = new System.Windows.Forms.CheckBox();
            this.rbtUpdate = new System.Windows.Forms.RadioButton();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblErrSn = new System.Windows.Forms.Label();
            this.lblErrOkOffUpdate = new System.Windows.Forms.Label();
            this.dgvModemsPersonal = new System.Windows.Forms.DataGridView();
            this.getModemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.sAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getModemsTableAdapter1 = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetModemsTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblModemId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SapId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OkOffUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paratiriseis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModemsPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaxeirhshExoplismouOTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(55, 550);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(79, 69);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(298, 20);
            this.txtSn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SAP";
            // 
            // cbxSap
            // 
            this.cbxSap.FormattingEnabled = true;
            this.cbxSap.Location = new System.Drawing.Point(79, 31);
            this.cbxSap.Name = "cbxSap";
            this.cbxSap.Size = new System.Drawing.Size(174, 21);
            this.cbxSap.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "S/N";
            // 
            // rbtOk
            // 
            this.rbtOk.AutoSize = true;
            this.rbtOk.Location = new System.Drawing.Point(73, 387);
            this.rbtOk.Name = "rbtOk";
            this.rbtOk.Size = new System.Drawing.Size(40, 17);
            this.rbtOk.TabIndex = 6;
            this.rbtOk.TabStop = true;
            this.rbtOk.Text = "OK";
            this.rbtOk.UseVisualStyleBackColor = true;
            // 
            // rbtOff
            // 
            this.rbtOff.AutoSize = true;
            this.rbtOff.Location = new System.Drawing.Point(116, 387);
            this.rbtOff.Name = "rbtOff";
            this.rbtOff.Size = new System.Drawing.Size(45, 17);
            this.rbtOff.TabIndex = 6;
            this.rbtOff.TabStop = true;
            this.rbtOff.Text = "OFF";
            this.rbtOff.UseVisualStyleBackColor = true;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(31, 468);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(346, 63);
            this.rtbNotes.TabIndex = 7;
            this.rtbNotes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Errors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fix";
            // 
            // chbPower
            // 
            this.chbPower.AutoSize = true;
            this.chbPower.Location = new System.Drawing.Point(31, 143);
            this.chbPower.Name = "chbPower";
            this.chbPower.Size = new System.Drawing.Size(56, 17);
            this.chbPower.TabIndex = 8;
            this.chbPower.Text = "Power";
            this.chbPower.UseVisualStyleBackColor = true;
            // 
            // chbDsl
            // 
            this.chbDsl.AutoSize = true;
            this.chbDsl.Location = new System.Drawing.Point(31, 168);
            this.chbDsl.Name = "chbDsl";
            this.chbDsl.Size = new System.Drawing.Size(41, 17);
            this.chbDsl.TabIndex = 9;
            this.chbDsl.Text = "Dsl";
            this.chbDsl.UseVisualStyleBackColor = true;
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Location = new System.Drawing.Point(31, 193);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(62, 17);
            this.chbInternet.TabIndex = 10;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // chbWlan
            // 
            this.chbWlan.AutoSize = true;
            this.chbWlan.Location = new System.Drawing.Point(31, 218);
            this.chbWlan.Name = "chbWlan";
            this.chbWlan.Size = new System.Drawing.Size(51, 17);
            this.chbWlan.TabIndex = 11;
            this.chbWlan.Text = "Wlan";
            this.chbWlan.UseVisualStyleBackColor = true;
            // 
            // chbWps
            // 
            this.chbWps.AutoSize = true;
            this.chbWps.Location = new System.Drawing.Point(31, 243);
            this.chbWps.Name = "chbWps";
            this.chbWps.Size = new System.Drawing.Size(48, 17);
            this.chbWps.TabIndex = 12;
            this.chbWps.Text = "Wps";
            this.chbWps.UseVisualStyleBackColor = true;
            // 
            // chbLan1
            // 
            this.chbLan1.AutoSize = true;
            this.chbLan1.Location = new System.Drawing.Point(31, 268);
            this.chbLan1.Name = "chbLan1";
            this.chbLan1.Size = new System.Drawing.Size(50, 17);
            this.chbLan1.TabIndex = 13;
            this.chbLan1.Text = "Lan1";
            this.chbLan1.UseVisualStyleBackColor = true;
            // 
            // chbLan2
            // 
            this.chbLan2.AutoSize = true;
            this.chbLan2.Location = new System.Drawing.Point(31, 293);
            this.chbLan2.Name = "chbLan2";
            this.chbLan2.Size = new System.Drawing.Size(50, 17);
            this.chbLan2.TabIndex = 14;
            this.chbLan2.Text = "Lan2";
            this.chbLan2.UseVisualStyleBackColor = true;
            // 
            // chbLan3
            // 
            this.chbLan3.AutoSize = true;
            this.chbLan3.Location = new System.Drawing.Point(31, 318);
            this.chbLan3.Name = "chbLan3";
            this.chbLan3.Size = new System.Drawing.Size(50, 17);
            this.chbLan3.TabIndex = 15;
            this.chbLan3.Text = "Lan3";
            this.chbLan3.UseVisualStyleBackColor = true;
            // 
            // chbStb
            // 
            this.chbStb.AutoSize = true;
            this.chbStb.Location = new System.Drawing.Point(31, 343);
            this.chbStb.Name = "chbStb";
            this.chbStb.Size = new System.Drawing.Size(47, 17);
            this.chbStb.TabIndex = 16;
            this.chbStb.Text = "STB";
            this.chbStb.UseVisualStyleBackColor = true;
            // 
            // chbChangeAntenna
            // 
            this.chbChangeAntenna.AutoSize = true;
            this.chbChangeAntenna.Location = new System.Drawing.Point(141, 143);
            this.chbChangeAntenna.Name = "chbChangeAntenna";
            this.chbChangeAntenna.Size = new System.Drawing.Size(106, 17);
            this.chbChangeAntenna.TabIndex = 17;
            this.chbChangeAntenna.Text = "Αλλαγή Κεραίας";
            this.chbChangeAntenna.UseVisualStyleBackColor = true;
            // 
            // chbChangeLed
            // 
            this.chbChangeLed.AutoSize = true;
            this.chbChangeLed.Location = new System.Drawing.Point(141, 167);
            this.chbChangeLed.Name = "chbChangeLed";
            this.chbChangeLed.Size = new System.Drawing.Size(83, 17);
            this.chbChangeLed.TabIndex = 18;
            this.chbChangeLed.Text = "Αλλαγή Led";
            this.chbChangeLed.UseVisualStyleBackColor = true;
            // 
            // chbChangeSupply
            // 
            this.chbChangeSupply.AutoSize = true;
            this.chbChangeSupply.Location = new System.Drawing.Point(141, 191);
            this.chbChangeSupply.Name = "chbChangeSupply";
            this.chbChangeSupply.Size = new System.Drawing.Size(135, 17);
            this.chbChangeSupply.TabIndex = 19;
            this.chbChangeSupply.Text = "Αλλαγή Τροφοδοτικού";
            this.chbChangeSupply.UseVisualStyleBackColor = true;
            // 
            // chbChangePlastic
            // 
            this.chbChangePlastic.AutoSize = true;
            this.chbChangePlastic.Location = new System.Drawing.Point(141, 215);
            this.chbChangePlastic.Name = "chbChangePlastic";
            this.chbChangePlastic.Size = new System.Drawing.Size(99, 17);
            this.chbChangePlastic.TabIndex = 20;
            this.chbChangePlastic.Text = "Αλλαγή Καπάκι";
            this.chbChangePlastic.UseVisualStyleBackColor = true;
            // 
            // chbChangeSupplyInput
            // 
            this.chbChangeSupplyInput.AutoSize = true;
            this.chbChangeSupplyInput.Location = new System.Drawing.Point(141, 239);
            this.chbChangeSupplyInput.Name = "chbChangeSupplyInput";
            this.chbChangeSupplyInput.Size = new System.Drawing.Size(185, 17);
            this.chbChangeSupplyInput.TabIndex = 21;
            this.chbChangeSupplyInput.Text = "Αλλαγή Βύσματος Τροφοδοσίας";
            this.chbChangeSupplyInput.UseVisualStyleBackColor = true;
            // 
            // chbFirmware
            // 
            this.chbFirmware.AutoSize = true;
            this.chbFirmware.Location = new System.Drawing.Point(141, 263);
            this.chbFirmware.Name = "chbFirmware";
            this.chbFirmware.Size = new System.Drawing.Size(107, 17);
            this.chbFirmware.TabIndex = 22;
            this.chbFirmware.Text = "Αλλαγή Firmware";
            this.chbFirmware.UseVisualStyleBackColor = true;
            // 
            // chbPackBox
            // 
            this.chbPackBox.AutoSize = true;
            this.chbPackBox.Location = new System.Drawing.Point(141, 287);
            this.chbPackBox.Name = "chbPackBox";
            this.chbPackBox.Size = new System.Drawing.Size(108, 17);
            this.chbPackBox.TabIndex = 23;
            this.chbPackBox.Text = "Αλλαγή PackBox";
            this.chbPackBox.UseVisualStyleBackColor = true;
            // 
            // rbtUpdate
            // 
            this.rbtUpdate.AutoSize = true;
            this.rbtUpdate.Location = new System.Drawing.Point(164, 387);
            this.rbtUpdate.Name = "rbtUpdate";
            this.rbtUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbtUpdate.TabIndex = 24;
            this.rbtUpdate.TabStop = true;
            this.rbtUpdate.Text = "Update";
            this.rbtUpdate.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(956, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 13);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "lblUserName";
            // 
            // lblErrSn
            // 
            this.lblErrSn.AutoSize = true;
            this.lblErrSn.ForeColor = System.Drawing.Color.Red;
            this.lblErrSn.Location = new System.Drawing.Point(79, 96);
            this.lblErrSn.Name = "lblErrSn";
            this.lblErrSn.Size = new System.Drawing.Size(51, 13);
            this.lblErrSn.TabIndex = 26;
            this.lblErrSn.Text = "@@@@";
            this.lblErrSn.Visible = false;
            // 
            // lblErrOkOffUpdate
            // 
            this.lblErrOkOffUpdate.AutoSize = true;
            this.lblErrOkOffUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblErrOkOffUpdate.Location = new System.Drawing.Point(69, 407);
            this.lblErrOkOffUpdate.Name = "lblErrOkOffUpdate";
            this.lblErrOkOffUpdate.Size = new System.Drawing.Size(51, 13);
            this.lblErrOkOffUpdate.TabIndex = 27;
            this.lblErrOkOffUpdate.Text = "@@@@";
            this.lblErrOkOffUpdate.Visible = false;
            // 
            // dgvModemsPersonal
            // 
            this.dgvModemsPersonal.AllowUserToAddRows = false;
            this.dgvModemsPersonal.AllowUserToDeleteRows = false;
            this.dgvModemsPersonal.AutoGenerateColumns = false;
            this.dgvModemsPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModemsPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SapId,
            this.Sap,
            this.SerialNumber,
            this.OkOffUpdate,
            this.Status,
            this.Paratiriseis});
            this.dgvModemsPersonal.DataSource = this.getModemsBindingSource;
            this.dgvModemsPersonal.Location = new System.Drawing.Point(481, 96);
            this.dgvModemsPersonal.MultiSelect = false;
            this.dgvModemsPersonal.Name = "dgvModemsPersonal";
            this.dgvModemsPersonal.ReadOnly = true;
            this.dgvModemsPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModemsPersonal.Size = new System.Drawing.Size(542, 235);
            this.dgvModemsPersonal.TabIndex = 28;
            this.dgvModemsPersonal.TabStop = false;
            this.dgvModemsPersonal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvModemsPersonal_CellMouseDoubleClick);
            // 
            // getModemsBindingSource
            // 
            this.getModemsBindingSource.DataMember = "GetModems";
            this.getModemsBindingSource.DataSource = this.DiaxeirhshExoplismouOTEDataSet;
            // 
            // DiaxeirhshExoplismouOTEDataSet
            // 
            this.DiaxeirhshExoplismouOTEDataSet.DataSetName = "DiaxeirhshExoplismouOTEDataSet";
            this.DiaxeirhshExoplismouOTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status";
            // 
            // getModemsTableAdapter1
            // 
            this.getModemsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(137, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblModemId
            // 
            this.lblModemId.AutoSize = true;
            this.lblModemId.Location = new System.Drawing.Point(294, 38);
            this.lblModemId.Name = "lblModemId";
            this.lblModemId.Size = new System.Drawing.Size(61, 13);
            this.lblModemId.TabIndex = 31;
            this.lblModemId.Text = "lblModemId";
            this.lblModemId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SapId
            // 
            this.SapId.DataPropertyName = "SapId";
            this.SapId.HeaderText = "SapId";
            this.SapId.Name = "SapId";
            this.SapId.ReadOnly = true;
            this.SapId.Visible = false;
            // 
            // Sap
            // 
            this.Sap.DataPropertyName = "Sap";
            this.Sap.HeaderText = "SAP";
            this.Sap.Name = "Sap";
            this.Sap.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // OkOffUpdate
            // 
            this.OkOffUpdate.DataPropertyName = "OkOffUpdate";
            this.OkOffUpdate.HeaderText = "StatusID";
            this.OkOffUpdate.Name = "OkOffUpdate";
            this.OkOffUpdate.ReadOnly = true;
            this.OkOffUpdate.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Paratiriseis
            // 
            this.Paratiriseis.DataPropertyName = "Paratiriseis";
            this.Paratiriseis.HeaderText = "Notes";
            this.Paratiriseis.Name = "Paratiriseis";
            this.Paratiriseis.ReadOnly = true;
            this.Paratiriseis.Width = 200;
            // 
            // ModemInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 598);
            this.Controls.Add(this.lblModemId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvModemsPersonal);
            this.Controls.Add(this.lblErrOkOffUpdate);
            this.Controls.Add(this.lblErrSn);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.rbtUpdate);
            this.Controls.Add(this.chbPackBox);
            this.Controls.Add(this.chbFirmware);
            this.Controls.Add(this.chbChangeSupplyInput);
            this.Controls.Add(this.chbChangePlastic);
            this.Controls.Add(this.chbChangeSupply);
            this.Controls.Add(this.chbChangeLed);
            this.Controls.Add(this.chbChangeAntenna);
            this.Controls.Add(this.chbStb);
            this.Controls.Add(this.chbLan3);
            this.Controls.Add(this.chbLan2);
            this.Controls.Add(this.chbLan1);
            this.Controls.Add(this.chbWps);
            this.Controls.Add(this.chbWlan);
            this.Controls.Add(this.chbInternet);
            this.Controls.Add(this.chbDsl);
            this.Controls.Add(this.chbPower);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.rbtOff);
            this.Controls.Add(this.rbtOk);
            this.Controls.Add(this.cbxSap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModemInspection";
            this.Text = "Modem Inspection";
            this.Load += new System.EventHandler(this.ModemInspection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModemsPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaxeirhshExoplismouOTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtOk;
        private System.Windows.Forms.RadioButton rbtOff;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbPower;
        private System.Windows.Forms.CheckBox chbDsl;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.CheckBox chbWlan;
        private System.Windows.Forms.CheckBox chbWps;
        private System.Windows.Forms.CheckBox chbLan1;
        private System.Windows.Forms.CheckBox chbLan2;
        private System.Windows.Forms.CheckBox chbLan3;
        private System.Windows.Forms.CheckBox chbStb;
        private System.Windows.Forms.CheckBox chbChangeAntenna;
        private System.Windows.Forms.CheckBox chbChangeLed;
        private System.Windows.Forms.CheckBox chbChangeSupply;
        private System.Windows.Forms.CheckBox chbChangePlastic;
        private System.Windows.Forms.CheckBox chbChangeSupplyInput;
        private System.Windows.Forms.CheckBox chbFirmware;
        private System.Windows.Forms.CheckBox chbPackBox;
        private System.Windows.Forms.RadioButton rbtUpdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblErrSn;
        private System.Windows.Forms.Label lblErrOkOffUpdate;
        private System.Windows.Forms.DataGridView dgvModemsPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource sAPBindingSource;
        private System.Windows.Forms.BindingSource getModemsBindingSource;
        private DiaxeirhshExoplismouOTEDataSet DiaxeirhshExoplismouOTEDataSet;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetModemsTableAdapter getModemsTableAdapter1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblModemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OkOffUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paratiriseis;
    }
}