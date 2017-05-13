using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_2
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para devolver el factorial de un número.
    /// <remarks>Recuerde utilizar esta clase cuando necesite modificar toda la información referente a Factorial</remarks>
    /// </summary>
    class tFactorial
    {
        private int mNumero;

        /// <summary>
        /// Constructor de la clase tFactorial.
        /// </summary>
        public tFactorial()
        {
            mNumero = 0;
        }

        /// <summary>
        /// Propiedad de la clase tFactorial que obtiene el numero.
        /// <value>
        /// Numero introducido.
        /// </value>
        /// </summary>
        public int Numero
        {
            get { return mNumero; }
            set { mNumero = value; }
        }

        ///<summary>
        ///Funcion que calcula el factorial de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>

        private int factorial()
        {

            int fac;
            int i;

            fac = 1;

            for (i = mNumero; i > 0; i--)
            {
                fac = fac * i;
            }

            return fac;

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
            texto = texto + factorial();

            return texto;
        }
    }
}
