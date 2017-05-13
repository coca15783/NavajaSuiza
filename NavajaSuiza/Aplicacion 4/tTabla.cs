using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_4
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para devolver la tabla de multiplicar de un número.
    /// <remarks>Recuerde utilizar esta clase cuando necesite modificar toda la información referente a Tabla</remarks>
    /// </summary>
    class tTabla
    {
        private int mNumero;

        /// <summary>
        /// Constructor de la clase tTabla.
        /// </summary>
        public tTabla()
        {
            mNumero = 0;
        }

        /// <summary>
        /// Propiedad de la clase tTabla que obtiene el numero.
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
        ///Funcion que calcula la tabla de multiplicar de un número.
        ///</summary>
        ///<return>
        ///Devuelve un texto que corresponde con el resultado.
        ///</return>

        private string tabla()
        {
            string texto;
            int i;
            int tabla;

            texto = "Tabla del" + " " + mNumero + ":" + "\n";
            tabla = 0;

            for (i = 1; i <= 10; i++)
            {
                tabla = mNumero * i;
                texto = texto + mNumero + " " + "*" + " " + i + " " + "=" + " " + tabla + "\n";
            }
            return texto;
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
            texto = texto + tabla();

            return texto;
        }
    }
}
