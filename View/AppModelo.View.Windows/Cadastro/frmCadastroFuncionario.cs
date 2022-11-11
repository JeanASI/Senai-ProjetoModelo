using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static AppModelo.Model.Domain.Validators.Validadores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            var cepController = new ViaCepContrpller();
            var endereco = cepController.Obter(txtEnderecoCep.Text);
            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhvalido = Validadores.ValidarCPF(cpf);
            if (cpfEhvalido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Invalido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }

            {

            }
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado");
                }
            }
            errorProvider.Clear();
        }

        private void txtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var dataNascimento = DateTime.Parse(txtDataNascimento.Text);
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            int numero = int.Parse(txtEnderecoNumero.Text);

            var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, txtCpf.Text, rbMasculino.Checked, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text, 1, 1);

            if ((bool)salvou)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário");
            }
        }
    }
}

