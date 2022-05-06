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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personeldogrula(textBox1.Text, textBox2.Text))
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
             private bool personeldogrula (string pAdi, string   pParola)
        {
            otomasyonContext  context = new otomasyonContext ();
            var sorgu = from p in context.personels  
                        where p.personel_adi == pAdi 
                        && p.personel_sifre == pParola
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
                 Form1 f1 = new Form1();
                 f1.Show();
                 this.Hide();
             }

             private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
             {
                 this.Close();
             }

             private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
             {
                 Form4 f4 = new Form4();
                 f4.Show();

             }
    }
}
