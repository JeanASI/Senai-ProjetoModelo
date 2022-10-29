using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataAniversario { get; set; }
        public string cpf { get; set; }
    }
}

