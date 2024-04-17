namespace zh_2_gyak_hajos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerdesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyesValaszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kérdésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(936, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 34);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Megnyitás";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szamDataGridViewTextBoxColumn,
            this.kerdesDataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.v3DataGridViewTextBoxColumn,
            this.kepDataGridViewTextBoxColumn,
            this.helyesValaszDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kérdésBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            this.szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            this.szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            this.szamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            this.szamDataGridViewTextBoxColumn.Width = 150;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            this.kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            this.kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            this.kerdesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            this.kerdesDataGridViewTextBoxColumn.Width = 150;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "V1";
            this.v1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            this.v1DataGridViewTextBoxColumn.Width = 150;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            this.v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            this.v2DataGridViewTextBoxColumn.HeaderText = "V2";
            this.v2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            this.v2DataGridViewTextBoxColumn.Width = 150;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            this.v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            this.v3DataGridViewTextBoxColumn.HeaderText = "V3";
            this.v3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            this.v3DataGridViewTextBoxColumn.Width = 150;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            this.kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            this.kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            this.kepDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            this.kepDataGridViewTextBoxColumn.Width = 150;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            this.helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            this.helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            this.helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            this.helyesValaszDataGridViewTextBoxColumn.Width = 150;
            // 
            // kérdésBindingSource
            // 
            this.kérdésBindingSource.DataSource = typeof(zh_2_gyak_hajos.Kérdés);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(818, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(27, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(145, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(112, 34);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Új";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(263, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 34);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Szerkeszt";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpen;
        private DataGridView dataGridView1;
        private Button buttonSave;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private BindingSource kérdésBindingSource;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonEdit;
    }
}