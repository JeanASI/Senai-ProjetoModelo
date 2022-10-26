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
            
        }
    }
}
