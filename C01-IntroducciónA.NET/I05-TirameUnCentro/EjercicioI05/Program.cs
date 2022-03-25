using System;

namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = 0;
            int firstGroupAddition = 0;
            
            Console.WriteLine("Enter a number to find numerical centers: ");

            if (int.TryParse(Console.ReadLine(), out enteredNumber))
            {
                if (enteredNumber < 8)
                {
                    Console.WriteLine("There´s no numerical centers between 1 and {0}.", enteredNumber);
                }
                for (int i = 1; i <= enteredNumber; i++)
                {
                    firstGroupAddition += i - 1;
                    int secondGroupAddition = 0;
                    for (int j = i; j < enteredNumber; j++)
                    {
                        secondGroupAddition += j + 1;
                        if (firstGroupAddition == secondGroupAddition)
                        {
                            int numericalCenter = i;
                            Console.WriteLine("Numerical center: " + numericalCenter);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR. Invalid format.");
            }
        }
    }
}
