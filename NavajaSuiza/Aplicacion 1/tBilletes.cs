using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_1
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para devolver la cantidad de billetes.
    /// <remarks>Recuerde utilizar esta clase cuando necesite modificar toda la información referente a Billetes</remarks>
    /// </summary>
    class tDinero
    {
        private int mDinero;

        /// <summary>
        /// Constructor de la clase tDinero.
        /// </summary>
        public tDinero()
        {
            mDinero = 0;
        }

        /// <summary>
        /// Propiedad de la clase tDinero que obtiene el dinero.
        /// <value>
        /// Dinero introducido.
        /// </value>
        /// </summary>
        public int Dinero
        {
            get { return mDinero; }
            set { mDinero = value; }
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

        ///<summary>
        ///Funcion que devuelve la cantidad de billetes de 10000 pesetas.
        ///<returns>
        ///Devuelve el numero de billetes.
        ///</returns>
        ///</summary>
        private int billetes10000()
        {

            int billete10000;

            billete10000 = mDinero / 10000;

            mDinero = mDinero % 10000;


            return billete10000;
        }

        ///<summary>
        ///Funcion que devuelve la cantidad de billetes de 5000 pesetas.
        ///<returns>
        ///Devuelve el numero de billetes.
        ///</returns>
        ///</summary>
        private int billetes5000()
        {

            int billete5000;

            billete5000 = mDinero / 5000;

            mDinero = mDinero % 5000;


            return billete5000;
        }

        ///<summary>
        ///Funcion que devuelve la cantidad de billetes de 2000 pesetas.
        ///<returns>
        ///Devuelve el numero de billetes.
        ///</returns>
        ///</summary>
        private int billetes2000()
        {

            int billete2000;

            billete2000 = mDinero / 2000;
            mDinero = mDinero % 2000;

            return billete2000;
        }

        ///<summary>
        ///Funcion que devuelve la cantidad de billetes de 100 pesetas.
        ///<returns>
        ///Devuelve el numero de billetes.
        ///</returns>
        ///</summary>
        private int billetes100()
        {

            int billete100;

            billete100 = mDinero / 100;
            mDinero = mDinero % 100;

            return billete100;
        }

        ///<summary>
        ///Funcion que devuelve la cantidad de billetes de 25 pesetas.
        ///<returns>
        ///Devuelve el numero de billetes.
        ///</returns>
        ///</summary>
        private int billetes25()
        {

            int billete25;

            billete25 = mDinero / 25;
            mDinero = mDinero % 25;

            return billete25;
        }

        ///<summary>
        ///Funcion que mustra los datos devueltos por el resto de funciones de la clase.
        ///<returns>
        ///Devuelve un texto.
        ///</returns>
        ///</summary>
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
