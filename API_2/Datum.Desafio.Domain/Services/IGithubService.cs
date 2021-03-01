using Datum.Desafio.Domain.Models;
using System.Threading.Tasks;

namespace Datum.Desafio.Domain.Services
{
    public interface IGithubService
    {
        Task<GithubModelResult> BuscarUrlProjeto();
    }
}
