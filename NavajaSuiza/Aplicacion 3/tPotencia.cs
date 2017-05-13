using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_3
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para devolver la potencia de un número.
    /// <remarks>Recuerde utilizar esta clase cuando necesite modificar toda la información referente a Potencia</remarks>
    /// </summary>
    class tPotencia
    {
        private int mBase;
        private int mExponente;

        /// <summary>
        /// Constructor de la clase tPotencia.
        /// </summary>
        public tPotencia()
        {
            mBase = 0;
            mExponente = 0;
        }

        /// <summary>
        /// Propiedad de la clase tPotencia que obtiene la base de la potencia.
        /// <value>
        /// Base introducida.
        /// </value>
        /// </summary>
        public int Base
        {
            get { return mBase; }
            set { mBase = value; }
        }

        /// <summary>
        /// Propiedad de la clase tPotencia que obtiene el exponente de la potencia.
        /// <value>
        /// Base introducida.
        /// </value>
        /// </summary>
        public int Exponente
        {
            get { return mExponente; }
            set { mExponente = value; }
        }

        ///<summary>
        ///Funcion que calcula la potencia de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>
        private int potencia()
        {
            int potencia;
            int i;

            potencia = 0;

            if (mExponente >= 0)
            {
                for (i = 1; i <= mExponente; i++)
                {

                    potencia = potencia + mBase;
                }
            }
            else
            {
                for (i = -1; i >= mExponente; i--)
                {
                    potencia = potencia - mBase;
                }
            }

            return potencia;
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
            texto = texto + potencia();

            return texto;
        }
    }
}