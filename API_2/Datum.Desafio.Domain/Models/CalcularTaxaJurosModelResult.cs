using Datum.Desafio.Domain.Entities;

namespace Datum.Desafio.Domain.Models
{
    public class CalcularTaxaJurosModelResult
    {
        public double ValorFinal { get; set; }

        public static implicit operator CalcularTaxaJurosModelResult(CalculoTaxaJuros entity)
        {
            return new CalcularTaxaJurosModelResult
            {
                ValorFinal = entity.ValorFinal
            };
        }
    }
}
