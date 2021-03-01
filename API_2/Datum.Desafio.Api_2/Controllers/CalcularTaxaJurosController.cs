using Datum.Desafio.Domain.Entities;
using Datum.Desafio.Domain.Models;
using Datum.Desafio.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Datum.Desafio.Api_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalcularTaxaJuros : ControllerBase
    {
        private readonly ITaxaJurosService _service;

        public CalcularTaxaJuros(ITaxaJurosService service)
        {
            _service = service;
        }

        /// <summary>
        /// Calcula taxa de juros
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/calculajuros")]
        public async Task<IActionResult> CalculaJuros([FromBody] CalcularTaxaJurosModel model)
        {
            if (!model.IsValid) return BadRequest();

            var taxaJuros = await _service.BuscarTaxaJuros();

            var calculoTaxaJuros = new CalculoTaxaJuros(model.ValorInicial, model.Tempo, taxaJuros.Valor);

            return Ok((CalcularTaxaJurosModelResult)calculoTaxaJuros);
        }
    }
}
