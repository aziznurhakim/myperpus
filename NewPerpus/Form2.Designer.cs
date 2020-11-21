namespace NewPerpus
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTglMengembalikan = new System.Windows.Forms.TextBox();
            this.txtTglMeminjam = new System.Windows.Forms.TextBox();
            this.txtIDBuku = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglMeminjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglMengembalikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new NewPerpus.AppData();
            this.employeesTableAdapter = new NewPerpus.AppDataTableAdapters.EmployeesTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "JudulBuku", true));
            this.txtJudulBuku.Location = new System.Drawing.Point(155, 16);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.Size = new System.Drawing.Size(591, 22);
            this.txtJudulBuku.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtTglMengembalikan);
            this.panel.Controls.Add(this.txtTglMeminjam);
            this.panel.Controls.Add(this.txtIDBuku);
            this.panel.Controls.Add(this.txtJudulBuku);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(776, 145);
            this.panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tgl Mengembalikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tgl Meminjam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IDBuku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Juduk Buku";
            // 
            // txtTglMengembalikan
            // 
            this.txtTglMengembalikan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "TglMengembalikan", true));
            this.txtTglMengembalikan.Location = new System.Drawing.Point(155, 100);
            this.txtTglMengembalikan.Name = "txtTglMengembalikan";
            this.txtTglMengembalikan.Size = new System.Drawing.Size(591, 22);
            this.txtTglMengembalikan.TabIndex = 3;
            // 
            // txtTglMeminjam
            // 
            this.txtTglMeminjam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "TglMeminjam", true));
            this.txtTglMeminjam.Location = new System.Drawing.Point(155, 72);
            this.txtTglMeminjam.Name = "txtTglMeminjam";
            this.txtTglMeminjam.Size = new System.Drawing.Size(591, 22);
            this.txtTglMeminjam.TabIndex = 2;
            // 
            // txtIDBuku
            // 
            this.txtIDBuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "IDBuku", true));
            this.txtIDBuku.Location = new System.Drawing.Point(155, 44);
            this.txtIDBuku.Name = "txtIDBuku";
            this.txtIDBuku.Size = new System.Drawing.Size(591, 22);
            this.txtIDBuku.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.judulBukuDataGridViewTextBoxColumn,
            this.iDBukuDataGridViewTextBoxColumn,
            this.tglMeminjamDataGridViewTextBoxColumn,
            this.tglMengembalikanDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 187);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(167, 178);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(591, 22);
            this.txtCari.TabIndex = 1;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cari";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(632, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(551, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(470, 415);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // judulBukuDataGridViewTextBoxColumn
            // 
            this.judulBukuDataGridViewTextBoxColumn.DataPropertyName = "JudulBuku";
            this.judulBukuDataGridViewTextBoxColumn.HeaderText = "JudulBuku";
            this.judulBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.judulBukuDataGridViewTextBoxColumn.Name = "judulBukuDataGridViewTextBoxColumn";
            this.judulBukuDataGridViewTextBoxColumn.Width = 160;
            // 
            // iDBukuDataGridViewTextBoxColumn
            // 
            this.iDBukuDataGridViewTextBoxColumn.DataPropertyName = "IDBuku";
            this.iDBukuDataGridViewTextBoxColumn.HeaderText = "IDBuku";
            this.iDBukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBukuDataGridViewTextBoxColumn.Name = "iDBukuDataGridViewTextBoxColumn";
            this.iDBukuDataGridViewTextBoxColumn.Width = 120;
            // 
            // tglMeminjamDataGridViewTextBoxColumn
            // 
            this.tglMeminjamDataGridViewTextBoxColumn.DataPropertyName = "TglMeminjam";
            this.tglMeminjamDataGridViewTextBoxColumn.HeaderText = "TglMeminjam";
            this.tglMeminjamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglMeminjamDataGridViewTextBoxColumn.Name = "tglMeminjamDataGridViewTextBoxColumn";
            this.tglMeminjamDataGridViewTextBoxColumn.Width = 190;
            // 
            // tglMengembalikanDataGridViewTextBoxColumn
            // 
            this.tglMengembalikanDataGridViewTextBoxColumn.DataPropertyName = "TglMengembalikan";
            this.tglMengembalikanDataGridViewTextBoxColumn.HeaderText = "TglMengembalikan";
            this.tglMengembalikanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglMengembalikanDataGridViewTextBoxColumn.Name = "tglMengembalikanDataGridViewTextBoxColumn";
            this.tglMengembalikanDataGridViewTextBoxColumn.Width = 190;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "perpus";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTglMengembalikan;
        private System.Windows.Forms.TextBox txtTglMeminjam;
        private System.Windows.Forms.TextBox txtIDBuku;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMeminjamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMengembalikanDataGridViewTextBoxColumn;
    }
}