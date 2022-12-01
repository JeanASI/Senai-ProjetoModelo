using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNacionalidades : Form

    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();
            var listaDeNacionalidade = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                txtDescricao.Focus();
                return;
            }
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, "Nacionalidade geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NacionalidadeController ();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkAtivo.Checked);
            MessageBox.Show("Inserido com sucesso!");


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var listaNacionalidade = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaNacionalidade;
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _nacionalidadeController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Nacionalidade deletado com sucesso!", "Nacionalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma nacionalidade", "Nacionalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
