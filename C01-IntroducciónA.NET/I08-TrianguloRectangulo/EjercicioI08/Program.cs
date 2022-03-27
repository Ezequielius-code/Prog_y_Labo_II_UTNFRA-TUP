using System;

namespace EjercicioI08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte floors = 0;

            Console.WriteLine("Right-angled triangle.");
            Console.WriteLine("Enter the number of floors for your triangle: ");

            if (byte.TryParse(Console.ReadLine(), out floors))
            {
                Console.WriteLine("\n");
                for (int i = 1; i <= floors; i++)
                {
                    for (int j = 1; j < i * 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR. Closing app...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
