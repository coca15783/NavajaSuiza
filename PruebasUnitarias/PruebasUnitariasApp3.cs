using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    
    [TestClass]
    public class PruebasUnitariasApp3
    {
        [TestMethod]
        public void PruebaApp3PotenciaBaseyExponentePositivo()
        {
            
            int baseIntroducido;
            baseIntroducido = 0;

            int exponenteIntroducido;
            exponenteIntroducido = 0;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = tPotenciaLogica.potencia(baseIntroducido,exponenteIntroducido);

            resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void PruebaApp3BaseyExponenteNegativo()
        {

            int baseIntroducido;
            baseIntroducido = -1;

            int exponenteIntroducido;
            exponenteIntroducido = -1;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = tPotenciaLogica.potencia(baseIntroducido, exponenteIntroducido);

            resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void PruebaApp3PotenciaBasePositivayExponenteNegativo()
        {

            int baseIntroducido;
            baseIntroducido = 0;

            int exponenteIntroducido;
            exponenteIntroducido = -1;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = tPotenciaLogica.potencia(baseIntroducido, exponenteIntroducido);

            resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }
        [TestMethod]
        public void PruebaApp3PotenciaBaseNegativayExponentePositivo()
        {

            int baseIntroducido;
            baseIntroducido = -1;

            int exponenteIntroducido;
            exponenteIntroducido = 0;

            long resultadoEsperado;
            long resultadoObtenido;

            resultadoObtenido = tPotenciaLogica.potencia(baseIntroducido, exponenteIntroducido);

            resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }
    }
}
