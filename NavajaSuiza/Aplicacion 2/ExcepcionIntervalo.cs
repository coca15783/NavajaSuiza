using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace NavajaSuiza.Aplicacion_2
{
    [Serializable]
    public class ExcepcionIntervalo : Exception
    {
        public ExcepcionIntervalo() { }
        public ExcepcionIntervalo(string message) { }
        public ExcepcionIntervalo(string message, Exception innerException) { }
        public ExcepcionIntervalo(SerializationInfo info, StreamingContext context) { }


    }
        
}
