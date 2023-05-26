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
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select marka from markaBilgileri", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BosAraclar()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from aracDurumu WHERE durumu='BOS'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into aracOtopakKayit(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
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

                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update aracDurumu set durumu='DOLU' where parkyeri=@parkyeri", baglanti);
                komut2.Parameters.AddWithValue("@parkyeri", comboBoxParkYeri.SelectedItem);
                komut2.ExecuteNonQuery();

                baglanti.Close();
            }

            MessageBox.Show("Araç kaydı oluşturuldu.", "Kayit");
            comboBoxParkYeri.Items.Clear();
            BosAraclar();
            comboBoxMarka.Items.Clear();
            Marka();
            comboBoxSeri.Items.Clear();
            foreach (Control item in groupBoxKisi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBoxArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void buttonMarka_Click(object sender, EventArgs e)
        {
            FormMarka marka = new FormMarka();
            marka.ShowDialog();
        }

        private void buttonSeri_Click(object sender, EventArgs e)
        {
            FormSeri seri = new FormSeri();
            seri.ShowDialog();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select marka,seri from seriBilgileri where marka='"+comboBoxMarka.SelectedItem+"'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();
        }
    }
}
