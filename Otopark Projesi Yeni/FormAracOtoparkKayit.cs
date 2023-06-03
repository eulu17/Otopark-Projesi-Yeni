using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark_Projesi_Yeni
{
    public partial class FormAracOtoparkKayit : Form
    {
        public FormAracOtoparkKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormAracOtoparkKayit_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Marka();
        }

        private void Marka()
        {
            baglanti.Open(); // veritabanı baglantisi acar.
            SqlCommand cmd = new SqlCommand("select marka from markaBilgileri", baglanti); 
            // marka bilgilerini çekmek için komut oluşturulur.

            SqlDataReader read = cmd.ExecuteReader(); 
            // SQL komutunu çalıştırır ve sonuçları okumak için SqlDataReader nesnesi oluşturulur

            while (read.Read()) // okunan her bir satırda döngüye girer
            {
                comboBoxMarka.Items.Add(read["marka"].ToString()); // comboBoxa markaları ekler.
            }
            baglanti.Close(); // veritabanı bağlantısını kapatır.
        }

        private void BosAraclar()
        {
            baglanti.Open(); // baglantiyi acar
            SqlCommand cmd = new SqlCommand("select *from aracDurumu WHERE durumu='BOS'", baglanti);
            // Boş araçları veritabanından çekmek için SQL komutu oluşturulur

            SqlDataReader read = cmd.ExecuteReader(); 
            // SQL komutunu çalıştırır ve sonuçları okumak için SqlDataReader nesnesi oluşturulur

            while (read.Read()) // okunan her bir satırda döngüye girer.
            {
                comboBoxParkYeri.Items.Add(read["parkyeri"].ToString()); // comboBoxa park yeri bilgilerini ekler.
            }
            baglanti.Close(); // bağlantıyı kapatır.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // button2 ye basınca formu kapatır. button2.Text = İptal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True"))
            {
                baglanti.Open(); // bağlantı açar
                SqlCommand komut = new SqlCommand("insert into aracOtopakKayit(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
                //aracı kaydetmek için komut

                // paramete ile tek tek değerler atanır
                komut.Parameters.AddWithValue("@tc", textBoxTC.Text);
                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
                komut.Parameters.AddWithValue("@email", textBoxEmail.Text);
                komut.Parameters.AddWithValue("@plaka", textBoxPlaka.Text);
                komut.Parameters.AddWithValue("@marka", comboBoxMarka.Text);
                komut.Parameters.AddWithValue("@seri", comboBoxSeri.Text);
                komut.Parameters.AddWithValue("@renk", textBoxRenk.Text);
                komut.Parameters.AddWithValue("@parkyeri", comboBoxParkYeri.SelectedItem);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery(); // veritabanına kaydetme komutunu çalıştır.

                SqlCommand komut2 = new SqlCommand("update aracDurumu set durumu='DOLU' where parkyeri=@parkyeri", baglanti);
                // Aracın park yeri durumunu güncellemek için SQL komutu oluşturulur
                komut2.Parameters.AddWithValue("@parkyeri", comboBoxParkYeri.SelectedItem);
                komut2.ExecuteNonQuery(); // güncelleme komutunu çalıştır

                baglanti.Close(); // bglnti kapat
            }

            MessageBox.Show("Araç kaydı oluşturuldu.", "Kayit"); // mesaj göster
            comboBoxParkYeri.Items.Clear(); // kayıt sonrası comboboxı temizle
            BosAraclar(); // metodu çalıştırır . comboboxa park yeri bilgisi ekle
            comboBoxMarka.Items.Clear();  // kayıt sonrası comboBoxMarkayı temziler
            Marka(); // marka ekleme metodu
            comboBoxSeri.Items.Clear(); // comboBoxSeri yi temizler
            foreach (Control item in groupBoxKisi.Controls) // grupBoxın içindeki tüm kontroller
            {
                if (item is TextBox)
                {
                    item.Text = ""; // textboxların tümünü temizleyelim.
                }
            }
            foreach (Control item in groupBoxArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = ""; // comoboBoxları temizle
                }
            }
        }

        private void buttonMarka_Click(object sender, EventArgs e)
        {
            FormMarka marka = new FormMarka(); // FormMarka formunu aç
            marka.ShowDialog();
        }

        private void buttonSeri_Click(object sender, EventArgs e)
        {
            FormSeri seri = new FormSeri(); // FormSeri formunu ac
            seri.ShowDialog();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select marka,seri from seriBilgileri where marka='" + comboBoxMarka.SelectedItem + "'", baglanti);
            // seçilen marka için seri ekleyeceğiz
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxSeri.Items.Add(read["seri"].ToString()); // seri ekle combobaxa
            }
            baglanti.Close();
        }
    }
}
