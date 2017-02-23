using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Diesel : IMotor
    {
        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Gasolina");
        }

        public void ConsumirCombustible()
        {
            RealizarExplosion();
        }



        private void RealizarExplosion()
        {
            Console.WriteLine("Realizada la explosión del Gasoil");
        }
    }
}
