﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public interface IServicioMensaje
    {
        String Mensaje(String origen,String destino,String mensaje);
    }
}
