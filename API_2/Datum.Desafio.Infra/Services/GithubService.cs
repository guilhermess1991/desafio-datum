using Datum.Desafio.Domain.Models;
using Datum.Desafio.Domain.Services;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Datum.Desafio.Infra.Services
{
    public class GithubService : IGithubService
    {
        private readonly HttpClient _httpClient;
        private string Endpoint => "https://api.github.com/repos/guilhermess1991/desafio-datum";
        public GithubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Datum-Desafio-App");
        }
        public async Task<GithubModelResult> BuscarUrlProjeto() => await _httpClient.GetFromJsonAsync<GithubModelResult>($"{Endpoint}");
    }
}
