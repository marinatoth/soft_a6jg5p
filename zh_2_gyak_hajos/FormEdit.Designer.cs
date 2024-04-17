namespace zh_2_gyak_hajos
{
    partial class FormEdit
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
            this.buttonOke = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.kérdésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOke
            // 
            this.buttonOke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOke.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOke.Location = new System.Drawing.Point(245, 404);
            this.buttonOke.Name = "buttonOke";
            this.buttonOke.Size = new System.Drawing.Size(112, 34);
            this.buttonOke.TabIndex = 0;
            this.buttonOke.Text = "&Ok";
            this.buttonOke.UseVisualStyleBackColor = true;
            this.buttonOke.Click += new System.EventHandler(this.buttonOke_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Szam", true));
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Kerdes", true));
            this.textBox2.Location = new System.Drawing.Point(44, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 31);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V1", true));
            this.textBox3.Location = new System.Drawing.Point(44, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 31);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V2", true));
            this.textBox4.Location = new System.Drawing.Point(44, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(295, 31);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V3", true));
            this.textBox5.Location = new System.Drawing.Point(44, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(295, 31);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Kep", true));
            this.textBox6.Location = new System.Drawing.Point(44, 293);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(295, 31);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "HelyesValasz", true));
            this.textBox7.Location = new System.Drawing.Point(44, 350);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(295, 31);
            this.textBox7.TabIndex = 7;
            // 
            // kérdésBindingSource
            // 
            this.kérdésBindingSource.DataSource = typeof(zh_2_gyak_hajos.Kérdés);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOke);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOke;
        private TextBox textBox1;
        private TextBox textBox2;
        private BindingSource kérdésBindingSource;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}