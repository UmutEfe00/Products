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
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();
        }

        Context db=new Context();
        void tazele()
        {
            var tumveriler = db.Productlar.ToList();
            dataGridView1.DataSource = tumveriler;
        }
        private void FormG_Load(object sender, EventArgs e)
        {
            tazele();
        }
        int gncl_id;
        private void button1_Click(object sender, EventArgs e)
        {
            gncl_id = Convert.ToInt32(textBox_id.Text);
            var vericek = db.Productlar.Find(gncl_id);
            textBox_Descriptions.Text = vericek.Descriptions;
            textBox_price.Text=vericek.Price.ToString();
            textBox_productname.Text = vericek.ProductName;
            if (vericek.Discontinued==true)
            {
                radioButton_true.Checked = true;
            }
            else
            {
                radioButton_false.Checked = true;
            }
        }
        Product yeni_product = new Product();
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            yeni_product=db.Productlar.Find(gncl_id);
            yeni_product.ProductName = textBox_productname.Text;
            yeni_product.Descriptions = textBox_Descriptions.Text;
            yeni_product.Price = Convert.ToInt32(textBox_price.Text);
            if (radioButton_true.Checked)
            {
                yeni_product.Discontinued = true;
            }
            if (radioButton_false.Checked)
            {
                yeni_product.Discontinued = false;
            }           
            db.SaveChanges();
            tazele();
        }
    }
}
