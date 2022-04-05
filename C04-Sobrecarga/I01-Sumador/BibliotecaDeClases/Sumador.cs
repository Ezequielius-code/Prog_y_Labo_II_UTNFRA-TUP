using System;

namespace BibliotecaDeClases
{
    public class Sumador
    {
        private int cantidadSumas;
        
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {}

        public long Sumar(long a, long b)
        {
            long resultado = a + b;
            cantidadSumas++;
            return resultado;
        }

        public string Sumar(string a, string b)
        {
            string resultado = a + b;

            cantidadSumas++;
            return resultado;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator + (Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        public static bool operator | (Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
}
}
