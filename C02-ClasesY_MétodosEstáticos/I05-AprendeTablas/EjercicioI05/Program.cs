using System;
using BibliotecaDeClases;

namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            bool numerovalido = false;

            while (!numerovalido)
            {
                Console.WriteLine("Ingrese un número para generar su tabla de multiplicar: ");
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Clear();
                    Console.WriteLine(TablaMultiplicar.GenerarTablaMultiplicar(numero));
                    numerovalido = true;
                }
                else
                {
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
