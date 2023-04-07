using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class FormFA : Form
    {
        public FormFA()
        {
            InitializeComponent();
        }
        Context db = new Context();
        int fiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(textBox1.Text);
            var sonuclar = (from i in db.Productlar
                            where i.Price < fiyat
                            select i).ToList();
            dataGridView1.DataSource = sonuclar;
        }


        private void FormFA_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var iki_alan = (from i in db.Productlar
                            select new
                            {
                                ürün_adı = i.ProductName,
                                tanım = i.Descriptions.Substring(0, 8),
                                fiyat = i.Price
                            }).ToList();
            dataGridView1.DataSource = iki_alan;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var ekle = (from i in db.Productlar
                        select new
                        {
                            i.ProductName,
                            i.Descriptions,
                            i.Discontinued,
                            yeni = i.Price < 50 ? i.Price + 50 : i.Price
                        }
                      ).ToList();
           dataGridView1.DataSource = ekle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var eksilt = (from i in db.Productlar
                          select new
                          {
                              i.ProductName,
                              i.Descriptions,
                              yeni = i.Price > 30 && i.Discontinued == false ? i.Price - 30 : i.Price
                          }
                        ).ToList();
            dataGridView1.DataSource= eksilt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var trgoster = (from i in db.Productlar
                            where i.Discontinued == true
                            select new
                            {
                                i.ProductName,
                                i.Discontinued
                            }
                          ).ToList();
            dataGridView1.DataSource=trgoster;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sıarala=(from i in db.Productlar
                         orderby i.Price ascending
                         select i 
                         ).ToList();
            dataGridView1.DataSource = sıarala;
        }
    }
}
