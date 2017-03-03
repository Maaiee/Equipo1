using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class ServicioMensaje : IServicioMensaje
    {
        public string Mensaje(string origen, string destino, string mensaje)
        {
            return origen + " envía a " + destino + ": "+mensaje;
        }
    }
}
