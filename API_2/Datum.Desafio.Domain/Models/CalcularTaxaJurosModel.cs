using System.Text.Json.Serialization;

namespace Datum.Desafio.Domain.Models
{
    public class CalcularTaxaJurosModel
    {
        public double ValorInicial { get; set; }
        public int Tempo { get; set; }

        [JsonIgnore]
        public bool IsValid => ValorInicial > 0 && Tempo > 0;
    }
}
