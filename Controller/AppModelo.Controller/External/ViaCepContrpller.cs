
using AppModelo.Model.Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.External
{
    public class ViaCepContrpller
    {
        public ViaCepWrapper Obter(string cep)
        {
            var viaCep = new ViaCepWrapper();
            //Fake consulta
            viaCep.Bairro = "Aviso";
            viaCep.Logradouro = "Filogonio Peixoto";
            viaCep.Localidade = "Linhares";

            return viaCep;
        }
    }
}
