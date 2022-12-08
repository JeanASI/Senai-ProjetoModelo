using AppModelo.Controller.Segurança;
using AppModelo.Model.Domain.Validators;
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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarAcesso_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmailRecuperarSenha.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmailRecuperarSenha, "Seu e-mail está errado");
                txtEmailRecuperarSenha.Focus();
                return;
            }
            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmailRecuperarSenha.Text);
            MessageBox.Show(resultado);
        }
        /// <summary>
        /// Botao responsavel por fechar o formulario recuperar senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}