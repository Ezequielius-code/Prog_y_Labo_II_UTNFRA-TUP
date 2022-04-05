using System;
using BibliotecaDeClases;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            long resultado = 0;
            string resultadoString = "";
            int cantidadSumas = 0;

            resultado = sumador.Sumar(125, 143);
            Console.WriteLine($"Resultado sumador long: {resultado}");

            resultadoString = sumador.Sumar("String ", "concatenado");
            Console.WriteLine($"Resultado sumador string: {resultadoString}");

            cantidadSumas = (int)sumador;
            Console.WriteLine($"Sumas totales del sumador: {cantidadSumas}");

            Sumador sumadorAlt = new Sumador(11);

            Console.WriteLine(sumador + sumadorAlt);
            Console.WriteLine(sumador | sumadorAlt);
        }
    }
}
