using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion_4;
using NavajaSuiza.Aplicación_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    
    [TestClass]
   public class PruebasUnitariasApp4
    {
        [TestMethod]
        public void PruebaApp4TablaDentrodeRango()
        {

            int numeroIntroducido;
            numeroIntroducido = 1;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp4TablaCero()
        {

            int numeroIntroducido;
            numeroIntroducido = 0;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp4TablaUno()
        {

            int numeroIntroducido;
            numeroIntroducido = 1;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp4Tabla99()
        {

            int numeroIntroducido;
            numeroIntroducido = 99;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp4Tabla100()
        {

            int numeroIntroducido;
            numeroIntroducido = 100;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void PruebaApp4FueradeRango1()
        {

            int numeroIntroducido;
            numeroIntroducido = 101;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);
            Formulario4.rango(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp4FueradeRango2()
        {

            int numeroIntroducido;
            numeroIntroducido = -1;

            string resultadoEsperado;
            string resultadoObtenido;

            resultadoObtenido = tTablaLogica.tabla(numeroIntroducido);
            Formulario4.rango(numeroIntroducido);

            resultadoEsperado = "";

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }


    }
}
