using Datum.Desafio.Domain.Models;
using System.Threading.Tasks;

namespace Datum.Desafio.Domain.Services
{
    public interface ITaxaJurosService
    {
        Task<TaxaJurosModelResult> BuscarTaxaJuros();
    }
}
