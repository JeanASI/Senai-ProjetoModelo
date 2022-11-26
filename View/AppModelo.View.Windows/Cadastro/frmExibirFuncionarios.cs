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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var listaNacionalidade = _FuncionarioController.ObterFuncionarios();
            gvExibirFuncionarios.DataSource = listaNacionalidade;
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdFuncionarios.Text);
            var deletou = _FuncionarioController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Nacionalidade deletado com sucesso!", "Nacionalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvExibirFuncionarios.DataSource = _FuncionarioController.ObterFuncionarios();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma nacionalidade", "Nacionalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
