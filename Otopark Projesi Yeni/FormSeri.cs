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
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=arac_otopark;Integrated Security=True");
        private void FormSeri_Load(object sender, EventArgs e)
        {
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

        private void buttonSeriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seriBilgileri(marka,seri) values('" + comboBoxMarka.Text + "','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka serisi eklendi.");
            textBox1.Clear();
            comboBoxMarka.Text = "";
            comboBoxMarka.Items.Clear();
            Marka();
        }

        private void buttonSeriEkle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seriBilgileri(marka,seri) values('" + comboBoxMarka.Text + "','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka serisi eklendi.");
            textBox1.Clear();
            comboBoxMarka.Text = "";
            comboBoxMarka.Items.Clear();
            Marka();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
