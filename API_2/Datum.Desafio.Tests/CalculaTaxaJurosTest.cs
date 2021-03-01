using Datum.Desafio.Domain.Entities;
using Xunit;

namespace Datum.Desafio.Domain.Tests
{
    public class CalculaTaxaJurosTest
    {
        [Fact]
        public void CalculaJuros_ObtemValorFinal()
        {
            //Arrange
            var valorInicial = 100;
            var taxaJuros = 0.01;
            var tempo = 5;


            //Act
            var calculoTaxaJuros = new CalculoTaxaJuros(valorInicial, tempo, taxaJuros);

            //Assert
            Assert.Equal(105.10, calculoTaxaJuros.ValorFinal);
        }
    }
}
