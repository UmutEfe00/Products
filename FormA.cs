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
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        Context db = new Context();
        void tazele()
        {
            var tumveriler = db.Productlar.ToList();
            dataGridView1.DataSource = tumveriler;
        }
        string aranck_urun;
        private void button_ara_Click(object sender, EventArgs e)
        {
            aranck_urun = textBox_ara.Text;
            var sonuclar= (from i in db.Productlar
                          where i.ProductName== aranck_urun
                          select i).ToList();
            dataGridView1.DataSource = sonuclar;            
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            tazele();
        }
    }
}
