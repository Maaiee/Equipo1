using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IMotor
    {
        void InyectarCombustible(double cantidad);
        void ConsumirCombustible();

    }
}
