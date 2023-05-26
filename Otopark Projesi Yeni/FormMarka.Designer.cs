namespace Otopark_Projesi_Yeni
{
    partial class FormMarka
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
            label1 = new Label();
            textBox1 = new TextBox();
            buttonMarkaEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // buttonMarkaEkle
            // 
            buttonMarkaEkle.Location = new Point(196, 136);
            buttonMarkaEkle.Name = "buttonMarkaEkle";
            buttonMarkaEkle.Size = new Size(94, 29);
            buttonMarkaEkle.TabIndex = 2;
            buttonMarkaEkle.Text = "Ekle";
            buttonMarkaEkle.UseVisualStyleBackColor = true;
            buttonMarkaEkle.Click += buttonMarkaEkle_Click;
            // 
            // FormMarka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(349, 226);
            Controls.Add(buttonMarkaEkle);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka Ekleme";
            Load += FormMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonMarkaEkle;
    }
}