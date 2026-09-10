using Apresentacao.DTO;
using Entidade;
using Microsoft.AspNetCore.Mvc;

namespace ContaBancaria
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasBancariasController : ControllerBase
    {

        private Dominio.ContaBancariaDomain _contaBancariaDomain;

        public ContasBancariasController(Dominio.ContaBancariaDomain contaBancariaDomain)
        {
            _contaBancariaDomain = contaBancariaDomain;
        }


        [HttpPost]
        public IActionResult Inserir(InserirContaDTO dto)
        {
            try
            {
                var contaBancaria = new Entidade.ContaBancaria()
                {
                    Titular = dto.Titular,
                    NumeroConta = dto.NumeroConta,
                    TipoConta = dto.TipoConta
                };

                 _contaBancariaDomain.Inserir(contaBancaria);

                return Ok(contaBancaria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
