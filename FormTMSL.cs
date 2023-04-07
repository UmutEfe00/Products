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
    public partial class FormTMSL : Form
    {
        public FormTMSL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        Context db = new Context();
        private void button1_Click(object sender, EventArgs e)
        {
            //db.Database.ExecuteSqlCommand("delete from Products");
            foreach (var item in db.Productlar)
            {
                db.Productlar.Remove(item);                
            }
            db.SaveChanges();
            yenile();
        }
        void yenile()
        {
            var tumveriler = db.Productlar.ToList();
            dataGridView1.DataSource = tumveriler;
        }

        private void FormTMSL_Load(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
