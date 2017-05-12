using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_2
{
    class tFactorial
    {
        private int mNumero;

        public tFactorial()
        {
            mNumero = 0;
        }

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

        public string mostrarDatos()
        {
            string texto;

            texto = "";
            texto = texto + factorial();

            return texto;
        }
    }
}
