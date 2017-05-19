using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion_2
{
    /// <summary>
    /// Clase de excepción personalizada.
    /// </summary>
    [Serializable]
    public class excepcionRango : System.Exception
    {
        public excepcionRango() { }
        public excepcionRango(string message) { }
        public excepcionRango(string message, Exception innerException) { }
        public excepcionRango(SerializationInfo info, StreamingContext context) { }
    }

}
