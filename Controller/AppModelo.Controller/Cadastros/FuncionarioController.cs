﻿using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    internal class FuncionarioController
    {
        public bool Cadastrar(string nome, DateTime dataAniversario, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataAniversario, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade);
            return resposta;
        }
    }
}
