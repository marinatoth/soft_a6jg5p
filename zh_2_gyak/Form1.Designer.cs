namespace zh_2_gyak
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
            this.buttonBetöltés = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.versenyzoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemzetisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eredmenyPercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMentés = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTörlés = new System.Windows.Forms.Button();
            this.buttonÚj = new System.Windows.Forms.Button();
            this.buttonSzámolás = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futókBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBetöltés
            // 
            this.buttonBetöltés.Location = new System.Drawing.Point(676, 40);
            this.buttonBetöltés.Name = "buttonBetöltés";
            this.buttonBetöltés.Size = new System.Drawing.Size(112, 34);
            this.buttonBetöltés.TabIndex = 0;
            this.buttonBetöltés.Text = "Betöltés";
            this.buttonBetöltés.UseVisualStyleBackColor = true;
            this.buttonBetöltés.Click += new System.EventHandler(this.buttonBetöltés_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.versenyzoIDDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.nemzetisegDataGridViewTextBoxColumn,
            this.eredmenyPercDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.futókBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(776, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            this.versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            this.versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            this.versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            this.versenyzoIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.Width = 150;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            this.nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            this.nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            this.nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            this.nemzetisegDataGridViewTextBoxColumn.Width = 150;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            this.eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            this.eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            this.eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            this.eredmenyPercDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            this.kategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // futókBindingSource
            // 
            this.futókBindingSource.DataSource = typeof(zh_2_gyak.Futók);
            // 
            // buttonMentés
            // 
            this.buttonMentés.Location = new System.Drawing.Point(558, 40);
            this.buttonMentés.Name = "buttonMentés";
            this.buttonMentés.Size = new System.Drawing.Size(112, 34);
            this.buttonMentés.TabIndex = 2;
            this.buttonMentés.Text = "Mentés";
            this.buttonMentés.UseVisualStyleBackColor = true;
            this.buttonMentés.Click += new System.EventHandler(this.buttonMentés_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.futókBindingSource, "Nev", true));
            this.textBox1.Location = new System.Drawing.Point(217, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 31);
            this.textBox1.TabIndex = 4;
            // 
            // buttonTörlés
            // 
            this.buttonTörlés.Location = new System.Drawing.Point(676, 385);
            this.buttonTörlés.Name = "buttonTörlés";
            this.buttonTörlés.Size = new System.Drawing.Size(112, 34);
            this.buttonTörlés.TabIndex = 5;
            this.buttonTörlés.Text = "Törlés";
            this.buttonTörlés.UseVisualStyleBackColor = true;
            this.buttonTörlés.Click += new System.EventHandler(this.buttonTörlés_Click);
            // 
            // buttonÚj
            // 
            this.buttonÚj.Location = new System.Drawing.Point(549, 385);
            this.buttonÚj.Name = "buttonÚj";
            this.buttonÚj.Size = new System.Drawing.Size(112, 34);
            this.buttonÚj.TabIndex = 6;
            this.buttonÚj.Text = "Új";
            this.buttonÚj.UseVisualStyleBackColor = true;
            this.buttonÚj.Click += new System.EventHandler(this.buttonÚj_Click);
            // 
            // buttonSzámolás
            // 
            this.buttonSzámolás.Location = new System.Drawing.Point(12, 385);
            this.buttonSzámolás.Name = "buttonSzámolás";
            this.buttonSzámolás.Size = new System.Drawing.Size(112, 34);
            this.buttonSzámolás.TabIndex = 7;
            this.buttonSzámolás.Text = "Számolás";
            this.buttonSzámolás.UseVisualStyleBackColor = true;
            this.buttonSzámolás.Click += new System.EventHandler(this.buttonSzámolás_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSzámolás);
            this.Controls.Add(this.buttonÚj);
            this.Controls.Add(this.buttonTörlés);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonMentés);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBetöltés);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futókBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBetöltés;
        private DataGridView dataGridView1;
        private Button buttonMentés;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource futókBindingSource;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Button buttonTörlés;
        private Button buttonÚj;
        private Button buttonSzámolás;
    }
}