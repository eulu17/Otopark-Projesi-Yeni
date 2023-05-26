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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(217, 51);
            button1.Name = "button1";
            button1.Size = new Size(370, 80);
            button1.TabIndex = 0;
            button1.Text = "Araç Kayıt Sistemi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(217, 137);
            button2.Name = "button2";
            button2.Size = new Size(370, 80);
            button2.TabIndex = 1;
            button2.Text = "Araç Otopark Yerleri Kontrol Sistemi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(217, 223);
            button3.Name = "button3";
            button3.Size = new Size(370, 80);
            button3.TabIndex = 2;
            button3.Text = "Araç Çıkış Sistemi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(217, 309);
            button4.Name = "button4";
            button4.Size = new Size(370, 80);
            button4.TabIndex = 3;
            button4.Text = "Çıkış Yap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Otopark Sistemi";
            Load += FormAnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}