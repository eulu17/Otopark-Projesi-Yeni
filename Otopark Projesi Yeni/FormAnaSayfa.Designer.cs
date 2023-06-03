namespace Otopark_Projesi_Yeni
{
    partial class FormAnaSayfa
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(18, 36);
            button1.Name = "button1";
            button1.Size = new Size(370, 186);
            button1.TabIndex = 0;
            button1.Text = "Araç Kayıt Sistemi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(406, 36);
            button2.Name = "button2";
            button2.Size = new Size(370, 125);
            button2.TabIndex = 1;
            button2.Text = "Araç Otopark Yerleri Kontrol Sistemi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(18, 228);
            button3.Name = "button3";
            button3.Size = new Size(370, 186);
            button3.TabIndex = 2;
            button3.Text = "Araç Çıkış Sistemi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(406, 298);
            button4.Name = "button4";
            button4.Size = new Size(370, 84);
            button4.TabIndex = 3;
            button4.Text = "Çıkış Yap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(406, 167);
            button5.Name = "button5";
            button5.Size = new Size(370, 125);
            button5.TabIndex = 4;
            button5.Text = "Satış Listeleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(629, 385);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 5;
            label1.Text = "Erdem Ulu ve Ahmet Kaya";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(691, 400);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 6;
            label2.Text = "Sibersan A.Ş";
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Otopark Sistemi";
            Load += FormAnaSayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
    }
}