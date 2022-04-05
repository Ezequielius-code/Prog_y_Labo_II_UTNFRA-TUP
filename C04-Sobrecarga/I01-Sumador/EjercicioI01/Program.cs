using System;
using BibliotecaDeClases;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            long resultado = sumador.Sumar(23, 27);
            Console.WriteLine(resultado);
            
            Sumador sumadorString = new Sumador(3);
            string resultadoString = sumadorString.Sumar("Hola ", "Mundo");
            Console.WriteLine(resultadoString);
        }
    }
}
