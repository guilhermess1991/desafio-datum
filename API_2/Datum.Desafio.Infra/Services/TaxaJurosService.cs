using Datum.Desafio.Domain.Models;
using Datum.Desafio.Domain.Services;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Datum.Desafio.Infra.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly HttpClient _httpClient;
        private string Endpoint => "http://datum_api1:80";
        public TaxaJurosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TaxaJurosModelResult> BuscarTaxaJuros()
        {

            var resposta = await _httpClient.GetFromJsonAsync<TaxaJurosModelResult>($"{Endpoint}/taxajuros");
            return resposta;
            
        }
    }
}
