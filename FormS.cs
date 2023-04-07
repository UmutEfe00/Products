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
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }
        
        Context db= new Context();
        int id_gir;
        private void button1_Click(object sender, EventArgs e)
        {
            id_gir=Convert.ToInt32(textBox1.Text);
            var silinecekveriyibul = db.Productlar.Find(id_gir);
            db.Productlar.Remove(silinecekveriyibul);
            db.SaveChanges();
            tazele();
        }
        void tazele()
        {
           var tumveriler= db.Productlar.ToList();
            dataGridView1.DataSource = tumveriler;
        }

        private void FormS_Load(object sender, EventArgs e)
        {
            tazele();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
