namespace KígyósJáték
{
    partial class ered
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(53, 67);
            button1.Name = "button1";
            button1.Size = new Size(90, 53);
            button1.TabIndex = 0;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Location = new Point(190, 67);
            button2.Name = "button2";
            button2.Size = new Size(93, 53);
            button2.TabIndex = 1;
            button2.Text = "retry";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(322, 67);
            button3.Name = "button3";
            button3.Size = new Size(94, 53);
            button3.TabIndex = 2;
            button3.Text = "ok";
            button3.UseVisualStyleBackColor = true;
            // 
            // ered
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 158);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ered";
            Text = "ered";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}