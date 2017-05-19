using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion_1;

namespace PruebasUnitarias
{
    
    [TestClass]
    public class PruebasUnitariasApp1
    {
        [TestMethod]
        public void PruebaApp1ValorNegativo1()
        {
            tBilletesLogica Dinero = new tBilletesLogica();
                      
            int dineroIntroducido;
            dineroIntroducido = -1;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1ValorNegativo2()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = -1;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 1;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1ValorCero1()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 0;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1ValorCero2()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 0;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 1;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1Valor25Uno()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 25;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 1;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1Valor25Dos()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 25;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1Valor1Uno()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 1;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 0;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        [TestMethod]
        public void PruebaApp1Valor1Dos()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dineroIntroducido;
            dineroIntroducido = 1;
            Dinero.Dinero = dineroIntroducido;

            int billetes10000E = 1;
            int billetes5000E = 0;
            int billetes2000E = 0;
            int billetes100E = 0;
            int billetes25E = 0;

            int billetes10000Ob = Dinero.billetes10000();
            int billetes5000Ob = Dinero.billetes5000();
            int billetes2000Ob = Dinero.billetes2000();
            int billetes100Ob = Dinero.billetes100();
            int billetes25Ob = Dinero.billetes25();


            Assert.AreEqual(billetes10000E, billetes10000Ob);
            Assert.AreEqual(billetes5000E, billetes5000Ob);
            Assert.AreEqual(billetes2000E, billetes2000Ob);
            Assert.AreEqual(billetes100E, billetes100Ob);
            Assert.AreEqual(billetes25E, billetes25Ob);
        }
        
    }
}
