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
    public partial class Formk : Form
    {
        public Formk()
        {
            InitializeComponent();
        }

        Context dbyeBaglan = new Context();
        Product yeni_product = new Product();
        private void button_kaydet_Click(object sender, EventArgs e)
        {
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
            dbyeBaglan.Productlar.Add(yeni_product);
            dbyeBaglan.SaveChanges();
        }

        private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_true_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Descriptions_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_productname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
