﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min || valor > max)
            {
                return false;
            }
            return true;
        }
    }
}
