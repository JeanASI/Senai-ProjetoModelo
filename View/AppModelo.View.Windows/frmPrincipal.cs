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
        /// <summary>
        /// Botao do formulario principal que chama o formulario cadastro de funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Botao do formulario principal que chama o formulario nacionalidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Botao do formulario principal que chama o formulario naturalidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Botao do formulario principal que chama o formulario exibir funcionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExibirFuncionarios();
            form.MdiParent = this;
            form.Show();
        }

        private void tsmFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
