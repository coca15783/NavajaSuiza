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
    public static class tTablaLogica
    {
       
        ///<summary>
        ///Funcion que calcula la tabla de multiplicar de un número.
        ///</summary>
        ///<return>
        ///Devuelve un texto que corresponde con el resultado.
        ///</return>

        public static string tabla(int numero)
        {
            string texto;
            int i;
            int tabla;

            texto = "Tabla del" + " " + numero + ":" + "\n";
            tabla = 0;

            for (i = 1; i <= 10; i++)
            {
                tabla = numero * i;
                texto = texto + numero + " " + "*" + " " + i + " " + "=" + " " + tabla + "\n";
            }
            return texto;
        }

    }
}
