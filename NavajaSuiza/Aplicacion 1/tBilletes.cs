using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_1
{
    class tDinero
    {
        private int mDinero;

        public tDinero()
        {
            mDinero = 0;
        }
        ///<summary>
        ///Introduciremos una cantidad de dinero en metálico y nos mostrará la cantidad de billetes que le corresponda.
        ///</summary>
        ///<remarks>
        ///Cuando la cantidad de billetes sea igual a 0 no deberá aparecer nada.
        ///</remarks>
        /// <para> Tipos de Billetes
        ///     <list type="bullet">
        ///         <item>
        ///             <description>10000</description>
        ///         </item>
        ///         <item>
        ///             <description>5000</description>
        ///         </item>
        ///         <item>
        ///             <description>2000</description>
        ///         </item>
        ///         <item>
        ///             <description>100</description>
        ///         </item>
        ///         <item>
        ///             <description>25</description>
        ///         </item>
        ///        </list>
        /// </para>
        
        public int Dinero
        {
            get { return mDinero; }
            set { mDinero = value; }
        }
        private int billetes10000()
        {

            int billete10000;

            billete10000 = mDinero / 10000;
           
            mDinero = mDinero % 10000;
            

            return billete10000;
        }
        private int billetes5000()
        {

            int billete5000;

            billete5000 = mDinero / 5000;
            
            mDinero = mDinero % 5000;
            

            return billete5000;
        }
        private int billetes2000()
        {

            int billete2000;

            billete2000 = mDinero / 2000;
            mDinero = mDinero % 2000;

            return billete2000;
        }

        private int billetes100()
        {

            int billete100;

            billete100 = mDinero / 100;
            mDinero = mDinero % 100;

            return billete100;
        }
        private int billetes25()
        {

            int billete25;

            billete25 = mDinero / 25;
            mDinero = mDinero % 25;

            return billete25;
        }
        public string mostrarDatos()
        {
            string texto;

            texto = "";
            texto = texto + "Billetes de 10000: " + billetes10000() + "\n";
            texto = texto + "Billetes de 5000: " + billetes5000() + "\n";
            texto = texto + "Billetes de 2000: " + billetes2000() + "\n";
            texto = texto + "Billetes de 100: " + billetes100() + "\n";
            texto = texto + "Billetes de 25: " + billetes25() + "\n";

            return texto;
        }







         
        
    }
}
