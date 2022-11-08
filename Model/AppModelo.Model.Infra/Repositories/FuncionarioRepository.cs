using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Inserir(int id, string nome, DateTime dataNascimento, string cpf, bool sexo, int nacionalidade, int naturalidade, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (id, data_de_aniversario, cpf, sexo, fk_nacionalidade, fk_naturalidade, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, ) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
