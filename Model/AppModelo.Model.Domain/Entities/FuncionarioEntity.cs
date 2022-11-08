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
        public DateTime data_de_aniversario { get; set; }
        public string cpf { get; set; }
        public bool sexo { get; set; }
        public int nacionalidade { get; set; }
        public int naturalidade { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string telefone_Contato { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }

    }   
}

