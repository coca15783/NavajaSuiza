using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion_2;
using NavajaSuiza.Aplicación_2;

namespace PruebasUnitarias
{
    
    [TestClass]
    public class PruebasUnitariasApp2
    {
        [TestMethod]
        public void PruebaApp2FactorialValorNegativoUno()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = -1;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();
            
            resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            
        }
        [TestMethod]
        public void PruebaApp2FactorialValorNegativoDos()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = -1;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        
        [TestMethod]
        public void PruebaApp2FactorialValorCeroUno()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = 0;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp2FactorialValorCeroDos()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = 0;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp2FactorialValorUno()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = 1;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp2FactorialValor14()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = 14;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 87178291200;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp2FactorialValor15()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numeroIntroducido;
            numeroIntroducido = 15;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();

            resultadoEsperado = 1307674368000;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp2FactorialValor16()
        {
            tFactorialLogica Factorial = new tFactorialLogica();
            Formulario2 Formulario = new Formulario2();

            long numeroIntroducido;
            numeroIntroducido = 16;
            Factorial.Numero = numeroIntroducido;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = Factorial.factorial();
            Formulario.rango(numeroIntroducido);

            resultadoEsperado = 20922789888000;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

    }

}