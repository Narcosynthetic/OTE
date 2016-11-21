namespace OTE
{
    partial class frmSapsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSapsManagement));
            this.sAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvgSap = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyposId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyposDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSapsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.txtSap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSap = new System.Windows.Forms.Button();
            this.btnUpdateSap = new System.Windows.Forms.Button();
            this.btnDeleteSap = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblErrSap = new System.Windows.Forms.Label();
            this.getSapsDetailsTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetSapsDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSapsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgSap
            // 
            this.dvgSap.AllowUserToAddRows = false;
            this.dvgSap.AllowUserToDeleteRows = false;
            this.dvgSap.AutoGenerateColumns = false;
            this.dvgSap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SAP,
            this.TyposId,
            this.TyposDescr});
            this.dvgSap.DataSource = this.getSapsDetailsBindingSource;
            this.dvgSap.Location = new System.Drawing.Point(12, 22);
            this.dvgSap.Name = "dvgSap";
            this.dvgSap.ReadOnly = true;
            this.dvgSap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSap.Size = new System.Drawing.Size(254, 281);
            this.dvgSap.TabIndex = 0;
            this.dvgSap.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSap_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SAP
            // 
            this.SAP.DataPropertyName = "SAP";
            this.SAP.HeaderText = "SAP";
            this.SAP.Name = "SAP";
            this.SAP.ReadOnly = true;
            // 
            // TyposId
            // 
            this.TyposId.DataPropertyName = "TyposId";
            this.TyposId.HeaderText = "TyposId";
            this.TyposId.Name = "TyposId";
            this.TyposId.ReadOnly = true;
            this.TyposId.Visible = false;
            // 
            // TyposDescr
            // 
            this.TyposDescr.DataPropertyName = "TyposDescr";
            this.TyposDescr.HeaderText = "Category";
            this.TyposDescr.Name = "TyposDescr";
            this.TyposDescr.ReadOnly = true;
            // 
            // getSapsDetailsBindingSource
            // 
            this.getSapsDetailsBindingSource.DataMember = "GetSapsDetails";
            this.getSapsDetailsBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSet;
            // 
            // diaxeirhshExoplismouOTEDataSet
            // 
            this.diaxeirhshExoplismouOTEDataSet.DataSetName = "DiaxeirhshExoplismouOTEDataSet";
            this.diaxeirhshExoplismouOTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSap
            // 
            this.txtSap.Location = new System.Drawing.Point(12, 336);
            this.txtSap.Name = "txtSap";
            this.txtSap.Size = new System.Drawing.Size(100, 20);
            this.txtSap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // btnAddSap
            // 
            this.btnAddSap.Location = new System.Drawing.Point(13, 391);
            this.btnAddSap.Name = "btnAddSap";
            this.btnAddSap.Size = new System.Drawing.Size(75, 23);
            this.btnAddSap.TabIndex = 6;
            this.btnAddSap.Text = "Add";
            this.btnAddSap.UseVisualStyleBackColor = true;
            this.btnAddSap.Click += new System.EventHandler(this.btnAddSap_Click);
            // 
            // btnUpdateSap
            // 
            this.btnUpdateSap.Location = new System.Drawing.Point(96, 391);
            this.btnUpdateSap.Name = "btnUpdateSap";
            this.btnUpdateSap.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSap.TabIndex = 7;
            this.btnUpdateSap.Text = "Update";
            this.btnUpdateSap.UseVisualStyleBackColor = true;
            this.btnUpdateSap.Click += new System.EventHandler(this.btnUpdateSap_Click);
            // 
            // btnDeleteSap
            // 
            this.btnDeleteSap.Location = new System.Drawing.Point(179, 391);
            this.btnDeleteSap.Name = "btnDeleteSap";
            this.btnDeleteSap.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSap.TabIndex = 8;
            this.btnDeleteSap.Text = "Delete";
            this.btnDeleteSap.UseVisualStyleBackColor = true;
            this.btnDeleteSap.Click += new System.EventHandler(this.btnDeleteSap_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(127, 335);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(174, 21);
            this.cbxCategory.TabIndex = 9;
            // 
            // lblErrSap
            // 
            this.lblErrSap.AutoSize = true;
            this.lblErrSap.ForeColor = System.Drawing.Color.Red;
            this.lblErrSap.Location = new System.Drawing.Point(10, 359);
            this.lblErrSap.Name = "lblErrSap";
            this.lblErrSap.Size = new System.Drawing.Size(51, 13);
            this.lblErrSap.TabIndex = 27;
            this.lblErrSap.Text = "@@@@";
            this.lblErrSap.Visible = false;
            // 
            // getSapsDetailsTableAdapter
            // 
            this.getSapsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSapsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 442);
            this.Controls.Add(this.lblErrSap);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.btnDeleteSap);
            this.Controls.Add(this.btnUpdateSap);
            this.Controls.Add(this.btnAddSap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSap);
            this.Controls.Add(this.dvgSap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSapsManagement";
            this.Text = "SAP\'s Management";
            this.Load += new System.EventHandler(this.SapsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSapsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sAPBindingSource;
        private System.Windows.Forms.DataGridView dvgSap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typosMhxanhmatosIdDataGridViewTextBoxColumn;
        private DiaxeirhshExoplismouOTEDataSet diaxeirhshExoplismouOTEDataSet;
        private System.Windows.Forms.BindingSource getSapsDetailsBindingSource;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetSapsDetailsTableAdapter getSapsDetailsTableAdapter;
        private System.Windows.Forms.TextBox txtSap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSap;
        private System.Windows.Forms.Button btnUpdateSap;
        private System.Windows.Forms.Button btnDeleteSap;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblErrSap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyposId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyposDescr;
    }
}