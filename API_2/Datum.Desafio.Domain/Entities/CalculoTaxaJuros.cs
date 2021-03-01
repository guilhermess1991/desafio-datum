using System;

namespace Datum.Desafio.Domain.Entities
{
    public class CalculoTaxaJuros
    {
        public CalculoTaxaJuros(double valorInicial,
                                int tempo,
                                double taxaJuros)
        {
            ValorInicial = valorInicial;
            Tempo = tempo;
            TaxaJuros = taxaJuros;

            CalcularValorFinal();
        }

        public double ValorInicial { get; private set; }
        public double ValorFinal { get; private set; }
        public int Tempo { get; private set; }
        public double TaxaJuros { get; private set; }

        private void CalcularValorFinal()
        {
            var result = ValorInicial * Math.Pow((1 + TaxaJuros), Tempo);
            ValorFinal = Math.Truncate(100 * result) / 100;
        }
    }
}
