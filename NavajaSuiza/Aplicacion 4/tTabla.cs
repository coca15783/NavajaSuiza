using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_4
{
    class tTabla
    {
        private int mNumero;

        public tTabla()
        {
            mNumero = 0;
        }

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
        ///<param name="num">
        ///Ruta del número a leer.
        ///</param>

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

        public string mostrarDatos()
        {
            string texto;

            texto = "";
            texto = texto + tabla();

            return texto;
        }
    }
}
