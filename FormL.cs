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
    public partial class FormL : Form
    {
        public FormL()
        {
            InitializeComponent();
        }

        Context db_den_getir=new Context();
        private void FormL_Load(object sender, EventArgs e)
        {
            var tum_veriler=db_den_getir.Productlar.ToList();
            dataGridView1.DataSource = tum_veriler;

        }
    }
}
