using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Teste_IMC;

namespace TesteIMC_XUnit
{
    public class ClassificarIMCTests
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            //arrange
            double imc = 28;

            //act
            var resultado = Operacoes.ClassificarIMC(imc);

            //assert
            Assert.Equal("Sobrepeso", resultado);
        }
        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade I")]
        public void ClassificarIMC_RetornaResultado_Para_Uma_Lista(double primeiroNUmero, string resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primeiroNUmero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
