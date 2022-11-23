using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{

}

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(string nome, DateTime dataAniversario, string cpf, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataAniversario, cpf, sexo, nacionalidade, naturalidade, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf);
            return resposta;
        }
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }
        public bool Deletar(int id)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
        public List<FuncionarioEntity> ObterTodasFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodasFuncionarios();
            return (List<FuncionarioEntity>)resposta;
        }
    }
}
