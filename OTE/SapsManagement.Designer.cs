namespace OTE
{
    partial class SapsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapsManagement));
            this.lblUserName = new System.Windows.Forms.Label();
            this.dgvSaps = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAPDataSet = new OTE.SAPDataSet();
            this.sAPTableAdapter = new OTE.SAPDataSetTableAdapters.SAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(556, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // dgvSaps
            // 
            this.dgvSaps.AllowUserToOrderColumns = true;
            this.dgvSaps.AutoGenerateColumns = false;
            this.dgvSaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sapDataGridViewTextBoxColumn,
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn});
            this.dgvSaps.DataSource = this.sAPBindingSource;
            this.dgvSaps.Location = new System.Drawing.Point(12, 59);
            this.dgvSaps.Name = "dgvSaps";
            this.dgvSaps.Size = new System.Drawing.Size(520, 102);
            this.dgvSaps.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sapDataGridViewTextBoxColumn
            // 
            this.sapDataGridViewTextBoxColumn.DataPropertyName = "Sap";
            this.sapDataGridViewTextBoxColumn.HeaderText = "SAP";
            this.sapDataGridViewTextBoxColumn.Name = "sapDataGridViewTextBoxColumn";
            this.sapDataGridViewTextBoxColumn.Width = 200;
            // 
            // typosMhxanhmatosIdDataGridViewTextBoxColumn
            // 
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.DataPropertyName = "TyposMhxanhmatosId";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.HeaderText = "Typos Mhxanhmatos";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.Name = "typosMhxanhmatosIdDataGridViewTextBoxColumn";
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typosMhxanhmatosIdDataGridViewTextBoxColumn.Width = 119;
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
            // SapsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 420);
            this.Controls.Add(this.dgvSaps);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SapsManagement";
            this.Text = "SAP\'s Management";
            this.Load += new System.EventHandler(this.SapsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridView dgvSaps;
        private SAPDataSet sAPDataSet;
        private System.Windows.Forms.BindingSource sAPBindingSource;
        private SAPDataSetTableAdapters.SAPTableAdapter sAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typosMhxanhmatosIdDataGridViewTextBoxColumn;
    }
}