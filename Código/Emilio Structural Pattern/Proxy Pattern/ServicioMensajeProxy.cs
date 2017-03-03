using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class ServicioMensajeProxy : IServicioMensaje
    {
        ServicioMensaje sm;

        public ServicioMensajeProxy()
        {
            this.sm = new ServicioMensaje();
        }

        public string Mensaje(string origen, string destino, string mensaje)
        {
            Console.WriteLine(String.Format("Log {0}: {1} envía a {2}: {3}",DateTime.Now,origen,destino,mensaje));
            return sm.Mensaje(origen,destino,mensaje);
        }
    }
}
