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
            this.sAPDataSet = new OTE.SAPDataSet();
            this.sAPTableAdapter = new OTE.SAPDataSetTableAdapters.SAPTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sAPBindingSource
            // 
            this.sAPBindingSource.DataMember = "SAP";
            this.sAPBindingSource.DataSource = this.sAPDataSet;
            // 
            // sAPDataSet
            // 
            this.sAPDataSet.DataSetName = "SAPDataSet";
            this.sAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAPTableAdapter
            // 
            this.sAPTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sapDataGridViewTextBoxColumn,
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sAPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(112, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sapDataGridViewTextBoxColumn
            // 
            this.sapDataGridViewTextBoxColumn.DataPropertyName = "Sap";
            this.sapDataGridViewTextBoxColumn.HeaderText = "Sap";
            this.sapDataGridViewTextBoxColumn.Name = "sapDataGridViewTextBoxColumn";
            this.sapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typosMhxanhmatosIdDataGridViewTextBoxColumn
            // 
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.DataPropertyName = "TyposMhxanhmatosId";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.HeaderText = "TyposMhxanhmatosId";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.Name = "typosMhxanhmatosIdDataGridViewTextBoxColumn";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSapsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 420);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSapsManagement";
            this.Text = "SAP\'s Management";
            this.Load += new System.EventHandler(this.SapsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SAPDataSet sAPDataSet;
        private System.Windows.Forms.BindingSource sAPBindingSource;
        private SAPDataSetTableAdapters.SAPTableAdapter sAPTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typosMhxanhmatosIdDataGridViewTextBoxColumn;
    }
}