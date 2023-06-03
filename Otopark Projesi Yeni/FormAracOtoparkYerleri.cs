using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark_Projesi_Yeni
{
    public partial class FormAracOtoparkYerleri : Form
    {
        public FormAracOtoparkYerleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");
        // veritabanına bağlanmak için değişken oluşturma.
        private void FormAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışan olayları ele alır.
            BosParkYerleri(); // Boş park yerlerini ayarlar.
            DoluParkYerleri(); // Dolu park yerlerini ayarlar.

            baglanti.Open(); // Veritabanı bağlantısını açar.
            SqlCommand cmd = new SqlCommand("select *from aracOtopakKayit", baglanti); 
            // Veritabanından aracOtopakKayit tablosundaki verileri seçmek için SqlCommand nesnesi  oluşturulur.

            SqlDataReader read = cmd.ExecuteReader(); // Komutu çalıştırarak verileri okumak için SqlDataReader nesnesi oluşturulur.
            while (read.Read()) // Verileri okurken ilerler.
            {
                foreach (Control item in Controls) // Formdaki kontrol elemanlarını döner.
                {
                    if (item is Button) // Kontrol elemanı bir buton ise devam eder.
                    {
                        if (item.Text == read["parkyeri"].ToString()) // Butonun metni, okunan veritabanı sütununa eşitse devam eder. park-2 - park2 
                        {
                            item.Text = read["plaka"].ToString(); // Butonun metnini veritabanındaki plaka bilgisiyle günceller.
                        }
                    }
                }
            }
            baglanti.Close(); // Veritabanı bağlantısını kapatır.
        }

        private void DoluParkYerleri()
        {
            baglanti.Open(); // Veritabanı baglantsini acar.
            SqlCommand cmd = new SqlCommand("select *from aracDurumu", baglanti); 
            // Veritabanından aracDurumu tablosundaki verileri seçmek için SqlCommand nesnesi oluşturulur.

            SqlDataReader read = cmd.ExecuteReader(); // Komutu çalıştırarak verileri okumak için SqlDataReader nesnesi oluşturulur.
            while (read.Read()) // Verileri okurken ilerler.
            {
                foreach (Control item in Controls) // Formdaki kontrol elemanlarına bakılırken
                {
                    if (item is Button) // Kontrol elemanı bir buton ise devam eder.
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU") 
                            // Butonun metni, okunan veritabanı sütununa ve durumu "DOLU" ise devam eder.
                        {
                            item.BackColor = Color.Red; // Dolu park yerlerinin arka plan rengini kırmızı yapar.
                        }
                    }
                }
            }
            baglanti.Close(); // Veritabanı bağlantısını kapatır.
        }

        private void BosParkYerleri() // basitce 10 tane park yeri butonuna text atamak için oluşturulur.
        {
            int sayac = 1; // Park yeri numarasını tutmak için bir sayaç oluşturulur.
            foreach (Control item in Controls) // Formdaki kontrol elemanlarını döner.
            {
                if (item is Button) // Kontrol elemanı bir buton ise devam eder.
                {
                    item.Text = "Park - " + sayac; // Boş park yerlerine numara atar.
                    sayac++;
                }
            }
        }
    }
}
