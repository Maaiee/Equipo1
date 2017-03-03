using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Gasolina : IMotor
    {
        #region IMotor Members

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Gasolina");
        }

        public void ConsumirCombustible()
        {
            RealizarCombustion();
        }

        #endregion

        private void RealizarCombustion()
        {
            Console.WriteLine("Realizada la combustión de la Gasolina");
        }
    }
}
