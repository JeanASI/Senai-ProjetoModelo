
using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;
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
            var service = new ViaCepServices();

            var viaCep = service.ObterDaApi(cep);

            return viaCep;
        }
    }
}
