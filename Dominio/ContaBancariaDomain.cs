using Entidade;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dominio
{
    public class ContaBancariaDomain
    {
        private ContasBancariasRepositorio _contasBancariasRepositorio;
       

        public ContaBancariaDomain(ContasBancariasRepositorio contaBancariaRepositorio)
        {
            _contasBancariasRepositorio = contaBancariaRepositorio;
        }

        public void Inserir(ContaBancaria contaBancaria)
        {
            if (string.IsNullOrEmpty(contaBancaria.Titular))
            {
                throw new Exception("Falta informar o titular da conta.");
            }

            if (contaBancaria.NumeroConta.Contains("-"))
            {
                throw new Exception("Falta informar o digito da conta");
            }

            _contasBancariasRepositorio.Inserir(contaBancaria);
        }
    }
}
