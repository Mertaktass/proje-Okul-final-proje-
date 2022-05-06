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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

         private void Form6_Load(object sender, EventArgs e)
        {

            otomasyonContext ctx = new otomasyonContext();
            dataGridView1.DataSource = ctx.ürünler.ToList();
            
            
        }

        
          private void button1_Click(object sender, EventArgs e)
        {
            Models.otomasyonContext ctx = new Models.otomasyonContext();
           Models . ürünler yeniürün = new Models.ürünler();
            
            yeniürün.ürün_adi = textBox1.Text;
            yeniürün.ürün_modeli = textBox2.Text;
            yeniürün.ürün_serino = Convert.ToInt32(textBox3.Text);
            yeniürün.ürün_adedi = Convert.ToInt32(textBox4.Text);
            yeniürün.ürün_tarihi = Convert.ToDateTime(dateTimePicker1.Text);
            yeniürün.fiyat = Convert.ToInt32(textBox5.Text);
            ctx.ürünler.Add(yeniürün);
            ctx.SaveChanges( );
            dataGridView1.DataSource = ctx.ürünler.ToList();
            
        }

        
          private void button5_Click(object sender, EventArgs e)
        {
            Models.otomasyonContext ctx = new Models.otomasyonContext();
            int pId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = ctx.ürünler.Where(w => w.ürünid == pId).FirstOrDefault();
            ctx.ürünler.Remove(query);
            ctx.SaveChanges();
            dataGridView1.DataSource = ctx.ürünler.ToList();
            
        }
          private void button2_Click(object sender, EventArgs e)
        {
            Models.otomasyonContext  ctx = new Models.otomasyonContext();
            int pId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var quary = ctx.ürünler.Where(w => w.ürünid == pId).FirstOrDefault();
            quary.ürün_adi = textBox1.Text;
            quary.ürün_modeli  = textBox2.Text;
            quary.ürün_serino = Convert.ToInt32(textBox3.Text);
            quary.ürün_adedi = Convert.ToInt32(textBox4.Text);
            quary.ürün_tarihi = Convert.ToDateTime (dateTimePicker1.Text);
            quary.fiyat = Convert.ToInt32(textBox5.Text);
            ctx.SaveChanges();
            dataGridView1.DataSource = ctx.ürünler.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ürün_adi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string ürün_modeli = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string ürün_serino = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string ürün_adedi = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string ürün_tarihi = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();

            textBox1.Text = ürün_adi;
            textBox2.Text = ürün_modeli;
            textBox3.Text = ürün_serino;
            textBox4.Text = ürün_adedi;
            dateTimePicker1.Text = ürün_tarihi;
            textBox5.Text = fiyat;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

       

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 =new Form5 ();
            f5.Show();
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

        private void satişİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

       
       

       

       
    }
}
