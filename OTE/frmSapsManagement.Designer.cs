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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diaxeirhshExoplismouOTEDataSet = new OTE.DiaxeirhshExoplismouOTEDataSet();
            this.getSapsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSapsDetailsTableAdapter = new OTE.DiaxeirhshExoplismouOTEDataSetTableAdapters.GetSapsDetailsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyposDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSapsDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TyposDescr});
            this.dataGridView1.DataSource = this.getSapsDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(112, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // diaxeirhshExoplismouOTEDataSet
            // 
            this.diaxeirhshExoplismouOTEDataSet.DataSetName = "DiaxeirhshExoplismouOTEDataSet";
            this.diaxeirhshExoplismouOTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSapsDetailsBindingSource
            // 
            this.getSapsDetailsBindingSource.DataMember = "GetSapsDetails";
            this.getSapsDetailsBindingSource.DataSource = this.diaxeirhshExoplismouOTEDataSet;
            // 
            // getSapsDetailsTableAdapter
            // 
            this.getSapsDetailsTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaxeirhshExoplismouOTEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSapsDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sAPBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typosMhxanhmatosIdDataGridViewTextBoxColumn;
        private DiaxeirhshExoplismouOTEDataSet diaxeirhshExoplismouOTEDataSet;
        private System.Windows.Forms.BindingSource getSapsDetailsBindingSource;
        private DiaxeirhshExoplismouOTEDataSetTableAdapters.GetSapsDetailsTableAdapter getSapsDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyposDescr;
    }
}