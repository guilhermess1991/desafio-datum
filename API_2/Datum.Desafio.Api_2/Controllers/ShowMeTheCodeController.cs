using Datum.Desafio.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Datum.Desafio.Api_2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IGithubService _service;

        public ShowMeTheCodeController(IGithubService service)
        {
            _service = service;
        }

        /// <summary>
        /// Busca URL referente do código fonte deste projeto disponibilizado no Github
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/showmethecode")]
        public async Task<IActionResult> ShowMeTheCode()
        {
            return Ok(await _service.BuscarUrlProjeto());
        }
    }
}
