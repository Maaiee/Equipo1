﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    public interface IArbolLigero
    {
        String GetTipo();
        void Dibujar(long x,long y);
    }
}


