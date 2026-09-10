using Entidade;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public class ContasBancariasRepositorio
    {
        private readonly DataContext _dataContext; 

        public ContasBancariasRepositorio()
        {
            _dataContext = GeradorDeServico.CarregarContexto();
        }

        public void Inserir(ContaBancaria contaBancaria)
        {
            // Inserir no banco de dados;

            contaBancaria.Id = Guid.CreateVersion7();

            _dataContext.Add(contaBancaria);

            _dataContext.SaveChanges();
        }
    }
}
