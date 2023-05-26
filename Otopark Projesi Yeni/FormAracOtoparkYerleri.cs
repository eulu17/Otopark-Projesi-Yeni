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
        private void FormAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BosParkYerleri();
            DoluParkYerleri();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from aracOtopakKayit", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Text = read["plaka"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from aracDurumu", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void BosParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "Park - " + sayac;
                    sayac++;
                }
            }
        }
    }
}
