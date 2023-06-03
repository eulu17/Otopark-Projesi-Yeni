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
    public partial class FormMarka : Form
    {
        public FormMarka()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantısı için SqlConnection nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");

        private void buttonMarkaEkle_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını aç
            baglanti.Open();

            // TextBox'tan alınan değeri "markaBilgileri" tablosuna yeni bir kayıt olarak eklemek için komut
            SqlCommand komut = new SqlCommand("insert into markaBilgileri(marka) values('" + textBox1.Text + "')", baglanti);

            // Sorguyu çalıştır
            komut.ExecuteNonQuery();

            // Veritabanı bağlantısını kapat
            baglanti.Close();

            // Markanın başarıyla eklendiğini belirten bir ileti kutusu göster
            MessageBox.Show("Marka eklendi.");

            // TextBox'ı temizle
            textBox1.Clear();
        }

        private void FormMarka_Load(object sender, EventArgs e)
        {
            
        }
    }
}
