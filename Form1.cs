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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formk yeniform_k=new Formk();
        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniform_k.ShowDialog();
        }

        FormL yeniForml=new FormL();
        private void lISTEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniForml.ShowDialog();
        }

        FormS yeni_formS=new FormS();
        private void sILMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_formS.ShowDialog();
        }
        FormG yeni_formG=new FormG();
        private void gUNCELLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_formG.ShowDialog();
        }

        FormA yeni_forma=new FormA();
        private void aRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_forma.ShowDialog();
        }
        FormTMSL yeni_formSİL=new FormTMSL(); 
        private void tÜMÜNÜSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_formSİL.ShowDialog();
        }
        FormFA yeni_formFA = new FormFA();
        private void yENİFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_formFA.ShowDialog();
        }
    }
}
