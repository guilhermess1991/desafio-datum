using Datum.Desafio.Api_1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Datum.Desafio.Api_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {        
        [HttpGet]
        [Route("/taxajuros")]
        public IActionResult BuscaTaxaJuros() => Ok(new TaxaJuros());
    }
}
