namespace Otopark_Projesi_Yeni
{
    partial class FormSeri
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
            buttonSeriEkle = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBoxMarka = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSeriEkle
            // 
            buttonSeriEkle.Location = new Point(197, 129);
            buttonSeriEkle.Name = "buttonSeriEkle";
            buttonSeriEkle.Size = new Size(94, 29);
            buttonSeriEkle.TabIndex = 5;
            buttonSeriEkle.Text = "Ekle";
            buttonSeriEkle.TextAlign = ContentAlignment.TopCenter;
            buttonSeriEkle.UseVisualStyleBackColor = true;
            buttonSeriEkle.Click += buttonSeriEkle_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 3;
            label1.Text = "Marka";
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(166, 35);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(125, 28);
            comboBoxMarka.TabIndex = 6;
            comboBoxMarka.SelectedIndexChanged += comboBoxMarka_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 7;
            label2.Text = "Seri";
            // 
            // FormSeri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(349, 226);
            Controls.Add(label2);
            Controls.Add(comboBoxMarka);
            Controls.Add(buttonSeriEkle);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormSeri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeri";
            Load += FormSeri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSeriEkle;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBoxMarka;
        private Label label2;
    }
}