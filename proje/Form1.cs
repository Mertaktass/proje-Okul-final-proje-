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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kullanicidogrula(textBox1 .Text ,textBox2 .Text ))

            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show ("Hatalı giriş");
            }
        }
        private bool kullanicidogrula(string kAdi, string   kParola)
        {
            otomasyonContext  context = new otomasyonContext();
            var sorgu = from p in context.kullanıcı
                        where p.kullanıcı_adi == kAdi 
                        && p.kullanıcı_sifre == kParola
                        select p;
                       

            if (sorgu .Any ())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanımKlavuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
