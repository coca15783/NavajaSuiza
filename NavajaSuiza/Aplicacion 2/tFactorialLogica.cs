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
    public class tFactorialLogica
    {
        private long mNumero;

        /// <summary>
        /// Constructor de la clase tFactorial.
        /// </summary>
        public tFactorialLogica()
        {
            mNumero = 0;
        }

        /// <summary>
        /// Propiedad de la clase tFactorial que obtiene el numero.
        /// <value>
        /// Numero introducido.
        /// </value>
        /// </summary>
        public long Numero
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

        public long factorial()
        {

            long fac;
            long i;

            fac = 1;

            for (i = mNumero; i > 0; i--)
            {
                fac = fac * i;
            }

            return fac;

        }
    }
}
