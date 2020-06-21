using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IreneDesktop.FormsAtualizar;
using IreneDesktop.FormsCadastrar;

namespace IreneDesktop
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void BtnAtualizarProduto_Click(object sender, EventArgs e)
        {
            AtualizarProdutos f = new AtualizarProdutos();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CadastrarProdutos f = new CadastrarProdutos();
            f.Show();
        }
    }
}
