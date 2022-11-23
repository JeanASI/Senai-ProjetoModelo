using AppModelo.View.Windows.Cadastro;
using AppModelo.View.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }

<<<<<<< HEAD
        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form  = new frmExibirFuncionarios();
=======
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExcluirFuncionario();
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            form.Show();
        }
    }
}
