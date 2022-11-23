using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmExibirFuncionarios : Form
    {   
        private FuncionarioController _FuncionarioController = new FuncionarioController();
        public frmExibirFuncionarios()
        {
            InitializeComponent();
            var listaDeFuncionarios = _FuncionarioController.ObterTodosFuncionarios();
            gvExibirFuncionarios.DataSource = listaDeFuncionarios;
        }

        private void MiAtualizarFuncionarios_Click(object sender, EventArgs e)
        {
            var listaFuncionarios = _FuncionarioController.ObterTodosFuncionarios();
            gvExibirFuncionarios.DataSource = listaFuncionarios;
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void MiExcluirFuncionarios_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdExibirFuncionarios.Text);
            var deletou = _FuncionarioController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Funcionario deletado com sucesso!", "Funcionario deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvExibirFuncionarios.DataSource = _FuncionarioController.ObterTodosFuncionarios();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma funcionario", "Funcionario não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
