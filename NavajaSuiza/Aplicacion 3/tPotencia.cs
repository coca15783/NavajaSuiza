using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_3
{
    class tPotencia
    {
        private int mBase;
        private int mExponente;
        public tPotencia()
        {
            mBase = 0;
            mExponente = 0;
        }
        public int Base
        {
            get { return mBase; }
            set { mBase = value; }
        }
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

        public string mostrarDatos()
        {
            string texto;

            texto = "";
            texto = texto + potencia();

            return texto;
        }
    }
}
