using System;

namespace EjercicioI09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte floors = 0;

            Console.WriteLine("Isosceles triangle.");
            Console.WriteLine("Enter the number of floors for your triangle: ");

            if (byte.TryParse(Console.ReadLine(), out floors))
            {
                Console.WriteLine("\n");
                for (int i = 1; i <= floors; i++)
                {
                    for (int j = floors - i; j >= 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < i * 2; k++)
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
