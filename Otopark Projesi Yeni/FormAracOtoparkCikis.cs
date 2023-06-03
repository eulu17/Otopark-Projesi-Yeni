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
    public partial class FormAracOtoparkCikis : Form
    {
        public FormAracOtoparkCikis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");
        //giriş yapıldığında park yerleri ve plakaları yükler
        private void FormAracOtoparkCikis_Load(object sender, EventArgs e)
        {
            DoluYerler();
            Plakalar();
            timer1.Enabled = true;
        }
        //kayıtlı plakaları yükler
        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from aracOtopakKayit", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboPlaka.Items.Add(reader["plaka"].ToString());
            }
            baglanti.Close();
        }
        //dolu park yerlerini yükler
        private void DoluYerler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from aracDurumu where durumu='DOLU'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboParkYeri.Items.Add(reader["parkyeri"].ToString());
            }
            baglanti.Close();
        }
        // plaka seçildiğinde ilgili park yerini yükler 
        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from aracOtopakKayit where plaka='" + comboPlaka.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text = read["parkyeri"].ToString();
            }
            baglanti.Close();
        }
        // park yeri seçildiğinde ilgili kayıtları yükler ve süre hesaplar
        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from aracOtopakKayit where parkyeri='" + comboParkYeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                lblGelişTarihi.Text = read["tarih"].ToString();
            }
            baglanti.Close();
            //geliş ve çıkış tarihleri arasında geçen süreyi hesaplar
            DateTime gelis, cikis;
            gelis = DateTime.Parse(lblGelişTarihi.Text);
            cikis = DateTime.Parse(lblÇıkışTarihi.Text);
            TimeSpan fark;
            fark = cikis - gelis;
            lblSüre.Text = fark.TotalHours.ToString("0.00");
            lblToplamTutar.Text = (double.Parse(lblSüre.Text) * 10).ToString("0.00");
        }
        //zamanlayıcı her saniye çıkış tarihini günceller
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblÇıkışTarihi.Text = DateTime.Now.ToString();
        }
        //araç çıkışını gerçekleştirir
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //araç kaydını siler
            SqlCommand komut = new SqlCommand("delete from aracOtopakKayit where plaka='" + txtPlaka.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            //park yeri durumunu boş olarak günceller
            SqlCommand komut2 = new SqlCommand("update aracDurumu set durumu='BOŞ' where parkyeri='" + txtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            //satış tablosuna çıkış bilgilerini ekler
            SqlCommand komut3 = new SqlCommand("insert into satis(parkyeri,plaka,geliş_tarihi,çıkış_tarihi,süre,tutar) values(@parkyeri,@plaka,@geliş_tarihi,@çıkış_tarihi,@süre,@tutar) ", baglanti);
            komut3.Parameters.AddWithValue("@parkyeri", txtParkYeri2.Text);
            komut3.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut3.Parameters.AddWithValue("@geliş_tarihi", lblGelişTarihi.Text);
            komut3.Parameters.AddWithValue("@çıkış_tarihi", lblÇıkışTarihi.Text);
            komut3.Parameters.AddWithValue("@süre", double.Parse(lblSüre.Text));
            komut3.Parameters.AddWithValue("@tutar", double.Parse(lblToplamTutar.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Araç çıkışı yapıldı");
            //alanları temizler
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    txtParkYeri.Text = "";
                    comboParkYeri.Text = "";
                    comboPlaka.Text = "";
                }
            }
            //seçenekleri yeniden yükler
            comboPlaka.Items.Clear();
            comboParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }
        // iptal tuşuna basılınca formu kapatır
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
