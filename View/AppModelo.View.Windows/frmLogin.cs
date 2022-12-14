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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botao entrar do formulario de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrodo = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if(usuarioEncontrodo)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha não encontrado");
            }
        }
        /// <summary>
        /// Label responsavel por chamar o formulario recuperar senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
