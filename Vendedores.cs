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
    public partial class Vendedores : Form
    {
        public Vendedores()
        {
            InitializeComponent();
        }

        private void BtnAtualizarVendedores_Click(object sender, EventArgs e)
        {
            AtualizarVendedores f = new AtualizarVendedores();
            f.Show();
        }

        private void BtnCadastrarVendedores_Click(object sender, EventArgs e)
        {
            CadastrarVendedores f = new CadastrarVendedores();
            f.Show();
        }
    }
}
