using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class Programa
    {
        static void Main(string[] args)
        {
            FabricaDeArboles fabricaDeArboles = new FabricaDeArboles();

            String[] tipoArboles = { "pino", "palmera", "roble" };

            Random random = new Random();
            for (int i = 0; 1 <= 10000; i++)
            {
                fabricaDeArboles.getArbol(tipoArboles[random.Next(tipoArboles.Length)]).Dibujar(random.Next(600), random.Next(400));
                Console.ReadLine();
            }

        }
    }
}

