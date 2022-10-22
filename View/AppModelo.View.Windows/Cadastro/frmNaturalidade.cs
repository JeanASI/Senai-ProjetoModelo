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
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNacionalidades();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        }

        private void btnSalvarNaturalidade_Click(object sender, EventArgs e)
        {
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluida com sucesso");
                txtDescricao.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");
            }
        }
    }
}
