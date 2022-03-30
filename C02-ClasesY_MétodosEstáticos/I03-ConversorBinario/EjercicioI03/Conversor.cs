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
            string numeroRecibido = numeroEntero.ToString();
            char[] numeroBinario = numeroRecibido.ToCharArray();
            int potencia = 0;
            int numeroDecimal = 0;
            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    numeroDecimal += (int)Math.Pow(2, potencia);
                }
                potencia++;
            }
            return numeroDecimal;
        }
    }
}
