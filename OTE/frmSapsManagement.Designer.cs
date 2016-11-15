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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyposDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSapsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.getSapsDetailsTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetSapsDetailsTableAdapter();
            this.txbSap = new System.Windows.Forms.TextBox();
            this.txbCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSap = new System.Windows.Forms.Button();
            this.btnUpdateSap = new System.Windows.Forms.Button();
            this.btnDeleteSap = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn1,
            this.TyposDescr});
            this.dvgSap.DataSource = this.getSapsDetailsBindingSource;
            this.dvgSap.Location = new System.Drawing.Point(112, 28);
            this.dvgSap.Name = "dvgSap";
            this.dvgSap.ReadOnly = true;
            this.dvgSap.Size = new System.Drawing.Size(466, 227);
            this.dvgSap.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "SAP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // getSapsDetailsTableAdapter
            // 
            this.getSapsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txbSap
            // 
            this.txbSap.Location = new System.Drawing.Point(111, 281);
            this.txbSap.Name = "txbSap";
            this.txbSap.Size = new System.Drawing.Size(100, 20);
            this.txbSap.TabIndex = 1;
            // 
            // txbCategory
            // 
            this.txbCategory.Location = new System.Drawing.Point(220, 282);
            this.txbCategory.Name = "txbCategory";
            this.txbCategory.Size = new System.Drawing.Size(100, 20);
            this.txbCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // btnAddSap
            // 
            this.btnAddSap.Location = new System.Drawing.Point(112, 308);
            this.btnAddSap.Name = "btnAddSap";
            this.btnAddSap.Size = new System.Drawing.Size(75, 23);
            this.btnAddSap.TabIndex = 6;
            this.btnAddSap.Text = "Add";
            this.btnAddSap.UseVisualStyleBackColor = true;
            this.btnAddSap.Click += new System.EventHandler(this.btnAddSap_Click);
            // 
            // btnUpdateSap
            // 
            this.btnUpdateSap.Location = new System.Drawing.Point(220, 308);
            this.btnUpdateSap.Name = "btnUpdateSap";
            this.btnUpdateSap.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSap.TabIndex = 7;
            this.btnUpdateSap.Text = "Update";
            this.btnUpdateSap.UseVisualStyleBackColor = true;
            this.btnUpdateSap.Click += new System.EventHandler(this.btnUpdateSap_Click);
            // 
            // btnDeleteSap
            // 
            this.btnDeleteSap.Location = new System.Drawing.Point(325, 307);
            this.btnDeleteSap.Name = "btnDeleteSap";
            this.btnDeleteSap.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSap.TabIndex = 8;
            this.btnDeleteSap.Text = "Delete";
            this.btnDeleteSap.UseVisualStyleBackColor = true;
            this.btnDeleteSap.Click += new System.EventHandler(this.btnDeleteSap_Click);
            // 
            // frmSapsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 420);
            this.Controls.Add(this.btnDeleteSap);
            this.Controls.Add(this.btnUpdateSap);
            this.Controls.Add(this.btnAddSap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCategory);
            this.Controls.Add(this.txbSap);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyposDescr;
        private System.Windows.Forms.TextBox txbSap;
        private System.Windows.Forms.TextBox txbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSap;
        private System.Windows.Forms.Button btnUpdateSap;
        private System.Windows.Forms.Button btnDeleteSap;
    }
}