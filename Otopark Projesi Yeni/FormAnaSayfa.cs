namespace Otopark_Projesi_Yeni
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAracOtoparkKayit kayit = new FormAracOtoparkKayit(); // FormAracOtoparkKayit formuna acar.
            kayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAracOtoparkYerleri yer = new FormAracOtoparkYerleri(); // FormAracOtoparkYerleri formunu ac.
            yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAracOtoparkCikis cikis = new FormAracOtoparkCikis(); // FormAracOtoparkCikis formunu ac.
            cikis.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // button4 e basınca uygulamadan cikar.
        }


        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSatiscs satis = new FormSatiscs(); // FormSatiscs formunu acar.
            satis.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}