using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo berlina = new Berlina(motorDiesel, 4);
            berlina.MostrarCaracteristicas();
            berlina.Acelerar(2.4d);
            Console.ReadLine();
        }
    
        }
    
}
