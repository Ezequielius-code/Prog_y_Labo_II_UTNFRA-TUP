using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "seguir";

            do
            {
                Console.WriteLine("Para calcular números primos, ingrese un número.\n" +
                                  "Si desea cerrar el programa, ingrese salir.");
                answer = Console.ReadLine();

                if (int.TryParse(answer, out int enteredNumber))
                {
                    int temp = 0;
                    for (int i = 2; i <= enteredNumber; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                                temp++;
                        }
                        if (temp <= 2)
                        {
                            Console.WriteLine("{0}", i);
                        }
                        temp = 0;
                    }

                    Console.WriteLine("\n¿Desea ingresar un nuevo número o salir?\n   Ingrese: seguir - salir");
                    answer = Console.ReadLine();
                }
            } while (answer != "salir");
        }
    }
}
