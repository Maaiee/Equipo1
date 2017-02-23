using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    public class Arbol : IArbolLigero
    {

        private String tipo;

        public Arbol(String tipo)
        {
            this.tipo = tipo;
        }

        public void Dibujar(long x, long y)
        {
            Console.WriteLine("Árbol ["+this.GetTipo()+"] dibujado en las coordenadas ("+x+","+y+")");
        }

        public String GetTipo()
        {
            return this.tipo;
        }
    }
}

