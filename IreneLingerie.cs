using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IreneDesktop
{
    public partial class IreneLingerie : Form
    {
        public IreneLingerie()
        {
            InitializeComponent();
        }

        private void SacolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sacolas f = new Sacolas();
            f.MdiParent = this;
            f.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos f = new Produtos();
            f.MdiParent = this;
            f.Show();
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedores f = new Vendedores();
            f.MdiParent = this;
            f.Show();
        }
    }
}
