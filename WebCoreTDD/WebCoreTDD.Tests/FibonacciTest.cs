using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreTDD.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        //POSIÇÃO   0   1   2   3   4   5   6   7   8   9   10  ...
        //NUMERO    0   1   1   2   3   5   8   13  21  34  55  ...

        [TestMethod]
        public void PrimeiroElementoDeveSerZero()
        {
            var resultado = Fibonacci.ObterElemento(0);
            Assert.AreEqual(resultado, 0, "Valor não é zero");
        }

        // Para fins de teste vamos criar aqui mesmo, mas o correto seria no projeto
        public static class Fibonacci
        {
            public static int ObterElemento(int posicao)
            {
                return 0;
            }
        }
    }
}
