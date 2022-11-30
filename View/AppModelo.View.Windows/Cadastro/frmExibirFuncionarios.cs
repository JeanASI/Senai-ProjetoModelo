using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmExibirFuncionarios : Form
    {
        private FuncionarioController _FuncionarioController = new FuncionarioController();
        public frmExibirFuncionarios()
        {
            InitializeComponent();
            var listaDeFuncionarios = _FuncionarioController.ObterFuncionarios();
            gvExibirFuncionarios.DataSource = listaDeFuncionarios;
        }

        /// <summary>
        /// Evento associado ao botao atualizar que tras as informações da lista instanciada no controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var listaNacionalidade = _FuncionarioController.ObterFuncionarios();
            gvExibirFuncionarios.DataSource = listaNacionalidade;
            MessageBox.Show("Atualizado com sucesso!");
        }
        /// <summary>
        /// Evento associado ao botao excluir funcionarios solicita ao controlador que delete o funcionario selecionado no formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdFuncionarios.Text);
            var deletou = _FuncionarioController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Funcionario deletado com sucesso!", "Funcionario deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvExibirFuncionarios.DataSource = _FuncionarioController.ObterFuncionarios();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma funcionario", "Funcionario não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
