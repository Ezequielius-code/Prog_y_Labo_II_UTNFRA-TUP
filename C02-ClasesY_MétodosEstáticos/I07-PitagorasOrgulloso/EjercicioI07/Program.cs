using System;

namespace EjercicioI07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cateto1 = 0;
            double cateto2 = 0;
            double sumaCuadradosCatetos = 0;
            double hipotenusa = 0;
            bool numeroValido = false;

            while (!numeroValido)
            {
                Console.WriteLine("Ingrese la longitud de la base del triángulo:");
                if (double.TryParse(Console.ReadLine(), out cateto1))
                {
                    numeroValido = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            numeroValido = false;
            while (!numeroValido)
            {
                Console.WriteLine("Ingrese la longitud de la altura del triángulo:");
                if (double.TryParse(Console.ReadLine(), out cateto2))
                {
                    numeroValido = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            sumaCuadradosCatetos = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            hipotenusa = Math.Sqrt(sumaCuadradosCatetos);

            Console.WriteLine($"Resultados:\nBase: {cateto1}    Altura: {cateto2}    Hipotenusa: {hipotenusa.ToString("F6")}");
        }
    }
}
