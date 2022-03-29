using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string numeroBinario = "";

            while (numeroEntero > 0)
            {
                numeroBinario = numeroEntero % 2 + numeroBinario;
                numeroEntero /= 2;
            }
            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            return 99;
        }
    }
}
