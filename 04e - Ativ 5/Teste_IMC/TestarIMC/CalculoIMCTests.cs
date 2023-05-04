using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//todas as referencias acima são desnecessárias
using Teste_IMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestarIMC
{
    // classe de testes que serão executadas
    [TestClass]
    public class CalculoIMCTests
    {
        //método de teste
        [TestMethod]
        //descrição do teste
        public void CalcularIMC()
        {
            //arrange
            double peso = 110;
            double altura = 1.79;

            //act
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //act
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
