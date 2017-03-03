using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class Programa
    {
        static void Main(string[] args)
        {
            ServicioMensajeProxy smp = new ServicioMensajeProxy();
            Console.WriteLine(smp.Mensaje("Juan","Carlos","vas a ir o no vas a ir"));
            Console.ReadLine();
        }
    }
}
