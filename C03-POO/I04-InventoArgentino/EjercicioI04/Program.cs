using System;
using BibliotecaDeClases;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo = "";

            Console.ForegroundColor = boligrafoAzul.GetColor();
            if (boligrafoAzul.Pintar(100, out dibujo))
            {
                Console.WriteLine(dibujo);
            }

            if (boligrafoAzul.Pintar(10, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("\nEl bolífgrafo azul se ha quedado sin tinta.\n");
            }
            boligrafoAzul.Recargar();
            Console.ForegroundColor = boligrafoAzul.GetColor();
            if(boligrafoAzul.Pintar(5, out dibujo))
            {
                Console.WriteLine(dibujo);
            }

            dibujo = "";
            Console.ForegroundColor = boligrafoRojo.GetColor();
            if (boligrafoRojo.Pintar(100, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("\nEl bolífgrafo rojo se ha quedado sin tinta.\n");
            }

            Console.ResetColor();
            boligrafoRojo.Recargar();

            Console.ForegroundColor = boligrafoRojo.GetColor();
            if (boligrafoRojo.Pintar(97, out dibujo))
            {
                Console.WriteLine(dibujo);
            }

            if (boligrafoRojo.Pintar(10, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            Console.ResetColor();
        }
    }
}
