using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Projesi_Yeni
{
    public partial class FormSeri : Form
    {
        public FormSeri()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantısı için SqlConnection nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");
        private void FormSeri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde "Marka" metodu çağrılır
            Marka();
        }

        private void Marka()
        {
            baglanti.Open();// db bgltni ac.
            SqlCommand cmd = new SqlCommand("select marka from markaBilgileri", baglanti); 
            // "markaBilgileri" tablosundan "marka" sütununu seçen bir SqlCommand oluştur

            SqlDataReader read = cmd.ExecuteReader();  // Sorguyu çalıştırarak verileri SqlDataReader ile oku
            while (read.Read())
            {
                comboBoxMarka.Items.Add(read["marka"].ToString()); // Okunan her bir satır için "marka" değerini ComboBox'a ekle
            }
            baglanti.Close();
        }

        private void buttonSeriEkle_Click_1(object sender, EventArgs e) // aynı işlem
        { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seriBilgileri(marka,seri) values('" + comboBoxMarka.Text + "','" + textBox1.Text + "')", baglanti);
            // ComboBox'tan seçilen "marka" ve TextBox'tan alınan değeri kullanarak "seriBilgileri" tablosuna yeni bir kayıt eklemek için SqlCommand oluşturulur
            komut.ExecuteNonQuery();// komut çalıştır
            baglanti.Close();
            MessageBox.Show("Marka serisi eklendi.");// mesaj göster
            textBox1.Clear(); // textBox1 i temizle
            comboBoxMarka.Text = ""; // comboBoxMarka yı temizle
            comboBoxMarka.Items.Clear(); // itemleri temizle
            Marka(); // Markaları güncellemek için "Marka" metodunu tekrar çağır
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
