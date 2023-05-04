using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_IMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestarIMC
{
    [TestClass]
    public class ClassificarIMCTests
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            //arrange
            double imc = 28;

            //act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
