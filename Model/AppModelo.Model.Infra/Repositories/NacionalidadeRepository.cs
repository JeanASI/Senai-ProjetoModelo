using AppModelo.Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    //CRUD - create - read - update - delete
    //       insert - select - update - delete
    public class NacionalidadeRepository
    {
        public  bool Inserir() { }
        public bool Atualizar() { }
        public bool Remover() { }
        public List<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT * FROM nacionalidade";
        }
        public NacionalidadeEntity ObterPorId() { }




    }
}
