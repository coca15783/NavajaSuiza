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
   public static class tPotenciaLogica
    {
        
        ///<summary>
        ///Funcion que calcula la potencia de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>
        public static int potencia(int basE,int exponente)
        {
            int potencia;
            int i;

            potencia = 0;

            if (exponente >= 0)
            {
                for (i = 1; i <= exponente; i++)
                {

                    potencia = potencia + basE;
                }
            }
            else
            {
                for (i = -1; i >= exponente; i--)
                {
                    potencia = potencia - basE;
                }
            }

            return potencia;
        }

    }
}