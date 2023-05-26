namespace Otopark_Projesi_Yeni
{
    partial class FormAracOtoparkKayit
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
            textBoxTC = new TextBox();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPlaka = new TextBox();
            textBoxRenk = new TextBox();
            comboBoxMarka = new ComboBox();
            comboBoxSeri = new ComboBox();
            groupBoxKisi = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxArac = new GroupBox();
            buttonSeri = new Button();
            buttonMarka = new Button();
            comboBoxParkYeri = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBoxKisi.SuspendLayout();
            groupBoxArac.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTC
            // 
            textBoxTC.Location = new Point(147, 81);
            textBoxTC.Name = "textBoxTC";
            textBoxTC.Size = new Size(151, 34);
            textBoxTC.TabIndex = 0;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(147, 121);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(151, 34);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(147, 161);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(151, 34);
            textBoxSoyad.TabIndex = 2;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(147, 201);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(151, 34);
            textBoxTelefon.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(147, 241);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 34);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPlaka
            // 
            textBoxPlaka.Location = new Point(147, 79);
            textBoxPlaka.Name = "textBoxPlaka";
            textBoxPlaka.Size = new Size(151, 34);
            textBoxPlaka.TabIndex = 5;
            // 
            // textBoxRenk
            // 
            textBoxRenk.Location = new Point(147, 203);
            textBoxRenk.Name = "textBoxRenk";
            textBoxRenk.Size = new Size(151, 34);
            textBoxRenk.TabIndex = 6;
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.FormattingEnabled = true;
            comboBoxMarka.Location = new Point(147, 119);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(151, 36);
            comboBoxMarka.TabIndex = 7;
            comboBoxMarka.SelectedIndexChanged += comboBoxMarka_SelectedIndexChanged;
            // 
            // comboBoxSeri
            // 
            comboBoxSeri.FormattingEnabled = true;
            comboBoxSeri.Location = new Point(147, 161);
            comboBoxSeri.Name = "comboBoxSeri";
            comboBoxSeri.Size = new Size(151, 36);
            comboBoxSeri.TabIndex = 8;
            // 
            // groupBoxKisi
            // 
            groupBoxKisi.Controls.Add(label5);
            groupBoxKisi.Controls.Add(label4);
            groupBoxKisi.Controls.Add(label3);
            groupBoxKisi.Controls.Add(label2);
            groupBoxKisi.Controls.Add(label1);
            groupBoxKisi.Controls.Add(textBoxTC);
            groupBoxKisi.Controls.Add(textBoxAd);
            groupBoxKisi.Controls.Add(textBoxSoyad);
            groupBoxKisi.Controls.Add(textBoxTelefon);
            groupBoxKisi.Controls.Add(textBoxEmail);
            groupBoxKisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxKisi.Location = new Point(61, 35);
            groupBoxKisi.Name = "groupBoxKisi";
            groupBoxKisi.Size = new Size(334, 345);
            groupBoxKisi.TabIndex = 10;
            groupBoxKisi.TabStop = false;
            groupBoxKisi.Text = "Kişi Bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(55, 247);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 9;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(55, 207);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 8;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(55, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 7;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(55, 127);
            label2.Name = "label2";
            label2.Size = new Size(36, 28);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(55, 87);
            label1.Name = "label1";
            label1.Size = new Size(36, 28);
            label1.TabIndex = 5;
            label1.Text = "TC";
            label1.Click += label1_Click;
            // 
            // groupBoxArac
            // 
            groupBoxArac.Controls.Add(buttonSeri);
            groupBoxArac.Controls.Add(buttonMarka);
            groupBoxArac.Controls.Add(comboBoxParkYeri);
            groupBoxArac.Controls.Add(label10);
            groupBoxArac.Controls.Add(label9);
            groupBoxArac.Controls.Add(label8);
            groupBoxArac.Controls.Add(label7);
            groupBoxArac.Controls.Add(label6);
            groupBoxArac.Controls.Add(textBoxPlaka);
            groupBoxArac.Controls.Add(comboBoxMarka);
            groupBoxArac.Controls.Add(comboBoxSeri);
            groupBoxArac.Controls.Add(textBoxRenk);
            groupBoxArac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxArac.Location = new Point(401, 35);
            groupBoxArac.Name = "groupBoxArac";
            groupBoxArac.Size = new Size(367, 345);
            groupBoxArac.TabIndex = 11;
            groupBoxArac.TabStop = false;
            groupBoxArac.Text = "Araç Bilgileri";
            // 
            // buttonSeri
            // 
            buttonSeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeri.Location = new Point(314, 161);
            buttonSeri.Name = "buttonSeri";
            buttonSeri.Size = new Size(37, 36);
            buttonSeri.TabIndex = 17;
            buttonSeri.Text = "+";
            buttonSeri.UseVisualStyleBackColor = true;
            buttonSeri.Click += buttonSeri_Click;
            // 
            // buttonMarka
            // 
            buttonMarka.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMarka.Location = new Point(314, 119);
            buttonMarka.Name = "buttonMarka";
            buttonMarka.Size = new Size(37, 36);
            buttonMarka.TabIndex = 16;
            buttonMarka.Text = "+";
            buttonMarka.UseVisualStyleBackColor = true;
            buttonMarka.Click += buttonMarka_Click;
            // 
            // comboBoxParkYeri
            // 
            comboBoxParkYeri.FormattingEnabled = true;
            comboBoxParkYeri.Location = new Point(148, 244);
            comboBoxParkYeri.Name = "comboBoxParkYeri";
            comboBoxParkYeri.Size = new Size(151, 36);
            comboBoxParkYeri.TabIndex = 15;
            comboBoxParkYeri.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(47, 249);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 14;
            label10.Text = "Park Yeri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(47, 209);
            label9.Name = "label9";
            label9.Size = new Size(57, 28);
            label9.TabIndex = 13;
            label9.Text = "Renk";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(47, 169);
            label8.Name = "label8";
            label8.Size = new Size(46, 28);
            label8.TabIndex = 12;
            label8.Text = "Seri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(47, 127);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 11;
            label7.Text = "Marka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(47, 87);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 10;
            label6.Text = "Plaka";
            // 
            // button1
            // 
            button1.Location = new Point(301, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 12;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(401, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 13;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormAracOtoparkKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(780, 486);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBoxArac);
            Controls.Add(groupBoxKisi);
            Name = "FormAracOtoparkKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Otopark Kayıt Sistemi";
            Load += FormAracOtoparkKayit_Load;
            groupBoxKisi.ResumeLayout(false);
            groupBoxKisi.PerformLayout();
            groupBoxArac.ResumeLayout(false);
            groupBoxArac.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTC;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxTelefon;
        private TextBox textBoxEmail;
        private TextBox textBoxPlaka;
        private TextBox textBoxRenk;
        private ComboBox comboBoxMarka;
        private ComboBox comboBoxSeri;
        private GroupBox groupBoxKisi;
        private GroupBox groupBoxArac;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxParkYeri;
        private Button buttonSeri;
        private Button buttonMarka;
    }
}