using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Teste_IMC
{
    public static class Operacoes
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round(peso/(altura*altura), 2); 
            // a função round serve p/ arrendondar os valores, nesse caso, para 2 casas decimais
        }
        public static String ClassificarIMC(double imc)
        {
            if(imc < 18.5)
            {
                return "Abaixo do peso";
            } else if (imc < 25)
            {
                return "Peso normal";
            } else if (imc < 30)
            {
                return "Sobrepeso";
            } else if (imc < 35)
            {
                return "Obesidade I";
            } else if (imc < 40)
            {
                return "Obesidade II";
            } else
            {
                return "Obesidade III";
            }
        }

    }
}
