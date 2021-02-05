namespace Automasion
{
    partial class Duyurular
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILDIRIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUYURUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oztuncelvincDataSet2 = new Automasion.oztuncelvincDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oztuncelvincDataSet = new Automasion.oztuncelvincDataSet();
            this.oztuncelvincDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUYURUTableAdapter = new Automasion.oztuncelvincDataSet2TableAdapters.DUYURUTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUYURUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATEDataGridViewTextBoxColumn,
            this.bILDIRIMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dUYURUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 296);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bILDIRIMDataGridViewTextBoxColumn
            // 
            this.bILDIRIMDataGridViewTextBoxColumn.DataPropertyName = "BILDIRIM";
            this.bILDIRIMDataGridViewTextBoxColumn.HeaderText = "BILDIRIM";
            this.bILDIRIMDataGridViewTextBoxColumn.Name = "bILDIRIMDataGridViewTextBoxColumn";
            this.bILDIRIMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dUYURUBindingSource
            // 
            this.dUYURUBindingSource.DataMember = "DUYURU";
            this.dUYURUBindingSource.DataSource = this.oztuncelvincDataSet2;
            // 
            // oztuncelvincDataSet2
            // 
            this.oztuncelvincDataSet2.DataSetName = "oztuncelvincDataSet2";
            this.oztuncelvincDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 124);
            this.button1.TabIndex = 2;
            this.button1.Text = "Duyuru Paylaş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 124);
            this.textBox1.TabIndex = 3;
            // 
            // oztuncelvincDataSet
            // 
            this.oztuncelvincDataSet.DataSetName = "oztuncelvincDataSet";
            this.oztuncelvincDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oztuncelvincDataSetBindingSource
            // 
            this.oztuncelvincDataSetBindingSource.DataSource = this.oztuncelvincDataSet;
            this.oztuncelvincDataSetBindingSource.Position = 0;
            // 
            // dUYURUTableAdapter
            // 
            this.dUYURUTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yeni Duyuru";
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Duyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.Duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUYURUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oztuncelvincDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource oztuncelvincDataSetBindingSource;
        private oztuncelvincDataSet oztuncelvincDataSet;
        private oztuncelvincDataSet2 oztuncelvincDataSet2;
        private System.Windows.Forms.BindingSource dUYURUBindingSource;
        private oztuncelvincDataSet2TableAdapters.DUYURUTableAdapter dUYURUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILDIRIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}