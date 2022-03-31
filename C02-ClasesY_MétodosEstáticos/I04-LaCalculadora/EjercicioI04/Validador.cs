using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04
{
    internal class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            if (respuesta == 'S')
            {
                return true;
            }
            return false;
        }
    }
}
