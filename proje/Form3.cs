using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    using Models;
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        otomasyonContext  ctx = new otomasyonContext ();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctx = new otomasyonContext();
            kullanıcı  newkullanıcı = new kullanıcı ();
            newkullanıcı.kullanıcı_isim = textBox1.Text;
            newkullanıcı.kullanıcı_soyisim  = textBox2.Text;
            newkullanıcı.telefon = Convert.ToInt32 (textBox3.Text);
            newkullanıcı.kullanıcı_adi  = textBox4.Text;
            newkullanıcı.kullanıcı_sifre = textBox5.Text;
            newkullanıcı.mail  = textBox6.Text;
          
            MessageBox.Show("Kayit İşlemi Tamamlandi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
