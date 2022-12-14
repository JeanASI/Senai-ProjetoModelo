using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Segurança
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario, senha);
            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {   var repository = new UsuarioRepository();
            var usuario = repository.ObterPorEmail(email);
            if(usuario is null)
            {
                return "Usuario não encontrado";
            }
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Programador errou sql e vc não pode recuperar senha";
            }
            var emailService = new emailService();
            var mensagemHtml = @"<p><b>Criamos um nova senha para você</b></p><p>Sua senha e: <b>" + novaSenha+ "</b></p>";
            var emailEnviado = emailService.EnviarEmail(usuario.Name, usuario.Email, "Recuperação de senha",mensagemHtml);
            return "";
        }
    }
    
}     