namespace gırısEkranı
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = textBox1.Text;
            string sifre=textBox2.Text;

            if (kullanıcıAdı == "mertkarahan")
            {
                if (sifre == "123456")
                {
                    Form2 f2=new Form2();
                    f2.Show();
                }
            }
            else
            {
                Form4 f4=new Form4();
                f4.Show();
            }
        }
    }
}