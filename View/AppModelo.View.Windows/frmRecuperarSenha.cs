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

        private void btnRecuperarAcesso_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmailRecuperarSenha.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmailRecuperarSenha, "Seu e-mail está errado");
                txtEmailRecuperarSenha.Focus();
                return;             
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}