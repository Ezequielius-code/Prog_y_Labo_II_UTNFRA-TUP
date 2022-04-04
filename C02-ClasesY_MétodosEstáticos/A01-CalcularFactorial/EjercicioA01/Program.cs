using System;

namespace EjercicioA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double factorialResult = 0;

            Console.WriteLine("Enter a number to calculate its factorial:");
            if (double.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                factorialResult = CalculateFactorial(number);
                Console.WriteLine($"The result of {number} factorial is: {factorialResult}");
            }
            else
            {
                Console.WriteLine("FATAL ERROR. Program is closing...");
            }
        }

        static double CalculateFactorial(double number)
        {
            double factorial = 1;
            
            if (number == 0)
            {
                return factorial;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i; 
                }

                return factorial;
            }
        }
    }
}
