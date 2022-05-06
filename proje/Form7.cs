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
    using Models ;
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            otomasyonContext  ctx = new otomasyonContext ();
            dataGridView1.DataSource = ctx.ürünler.ToList(); ;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ürün_adi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string ürün_modeli = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string ürün_serino = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string ürün_adedi = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();

            textBox1.Text = ürün_adi;
            textBox2.Text = ürün_modeli;
            textBox3.Text = ürün_serino;
           textBox4 .Text  = ürün_adedi;
            textBox5.Text = fiyat;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1 . Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            listView1.Items[sayac].SubItems.Add(textBox5.Text);
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);

        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
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
