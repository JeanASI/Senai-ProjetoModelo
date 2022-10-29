﻿using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            var cepController = new ViaCepContrpller();
            var endereco = cepController.Obter(txtEnderecoCep.Text);
            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
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



        

    }
}

