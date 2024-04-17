namespace zh_2_gyak_hajos
{
    partial class ÚjKérdés
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
            this.buttonMentés = new System.Windows.Forms.Button();
            this.buttonMégse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kérdésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMentés
            // 
            this.buttonMentés.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMentés.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMentés.Location = new System.Drawing.Point(232, 404);
            this.buttonMentés.Name = "buttonMentés";
            this.buttonMentés.Size = new System.Drawing.Size(112, 34);
            this.buttonMentés.TabIndex = 0;
            this.buttonMentés.Text = "Mentés";
            this.buttonMentés.UseVisualStyleBackColor = true;
            // 
            // buttonMégse
            // 
            this.buttonMégse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMégse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMégse.Location = new System.Drawing.Point(105, 404);
            this.buttonMégse.Name = "buttonMégse";
            this.buttonMégse.Size = new System.Drawing.Size(112, 34);
            this.buttonMégse.TabIndex = 1;
            this.buttonMégse.Text = "Mégse";
            this.buttonMégse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Szam", true));
            this.textBox1.Location = new System.Drawing.Point(60, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 31);
            this.textBox1.TabIndex = 2;
            // 
            // kérdésBindingSource
            // 
            this.kérdésBindingSource.DataSource = typeof(zh_2_gyak_hajos.Kérdés);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Kerdes", true));
            this.textBox2.Location = new System.Drawing.Point(60, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 31);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V1", true));
            this.textBox3.Location = new System.Drawing.Point(60, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 31);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V2", true));
            this.textBox4.Location = new System.Drawing.Point(60, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 31);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "V3", true));
            this.textBox5.Location = new System.Drawing.Point(60, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 31);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "Kep", true));
            this.textBox6.Location = new System.Drawing.Point(60, 290);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 31);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kérdésBindingSource, "HelyesValasz", true));
            this.textBox7.Location = new System.Drawing.Point(60, 340);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(237, 31);
            this.textBox7.TabIndex = 8;
            // 
            // ÚjKérdés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMégse);
            this.Controls.Add(this.buttonMentés);
            this.Name = "ÚjKérdés";
            this.Text = "ÚjKérdés";
            this.Load += new System.EventHandler(this.ÚjKérdés_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kérdésBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMentés;
        private Button buttonMégse;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private BindingSource kérdésBindingSource;
    }
}