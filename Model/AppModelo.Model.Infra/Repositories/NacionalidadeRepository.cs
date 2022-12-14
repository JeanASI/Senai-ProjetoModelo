using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    //CRUD - create - read - update - delete
    //       insert - select - update - delete
    public class NacionalidadeRepository
    {
        public  bool Inserir(string descricao) 
        {
            var sql = $"INSERT INTO nacionalidade (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        
        public bool Remover(int id)
        {
            var sql = $"DELETE FROM nacionalidade WHERE id = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT id,descricao FROM nacionalidade";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId()
        {
            return new NacionalidadeEntity();
        }




    }
}
