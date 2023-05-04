using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Teste_IMC;

namespace TesteIMC_XUnit
{
    public class calculoIMCTests
    {
        [Fact]
        public void CalcularIMC_RetornarResultado()
        {
            //arrange
            double peso = 110;
            double altura = 1.79;

            //act
            var resultado = Operacoes.CalcularIMC(peso, altura);

            //assert
            Assert.Equal(34.33, resultado);
        }

        [Theory]
        [InlineData(80, 1.79, 24.97)]
        // valores em sequencia: peso, altura e IMC
        [InlineData(100, 1.79, 31.21)]
        public void CalcularIMC_RetornarResultado_Para_Uma_Lista(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(primeiroNumero, segundoNumero);
            Assert.Equal(resultadoEsperado, resultadoIMC);
        }
    }
}
