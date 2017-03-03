using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class FabricaDeArboles
    {
        private static Dictionary<String, Arbol> arboles = new Dictionary<string, Arbol>();

        public FabricaDeArboles()
        {
            
        }

        public IArbolLigero getArbol(String tipo)
        {
           

            if(!arboles.ContainsKey(tipo))
            {
                arboles.Add(tipo,new Arbol(tipo));
                Console.WriteLine("Agregando árbol ["+tipo+"] al pool");
            }

            return arboles[tipo];
        }
    }
}

