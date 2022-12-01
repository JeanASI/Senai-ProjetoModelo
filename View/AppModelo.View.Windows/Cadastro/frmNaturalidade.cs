using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        }

        private void btnSalvarNaturalidade_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                txtDescricao.Focus();
                return;
            }
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            if(temNumero)
            {
                errorProvider1.SetError(txtDescricao, "Naturalidade geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkBox.Checked);
            MessageBox.Show("Inserido com sucesso!");

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var listaNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaNaturalidade;
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _naturalidadeController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Naturalidade deletada com sucesso!", "Naturalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma naturalidade", "Naturalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
