using System;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = 0;
            bool validData;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int numberAccum = 0;

            for (int i = 0; i < 5; i++)
            {
                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Ingrese el valor #{0}: ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out enteredNumber))
                    {
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. El dato ingresado no es válido.");
                        validData = false;
                    }
                }

                if (enteredNumber < minNumber)
                {
                    minNumber = enteredNumber;
                }
                else
                {
                    if (enteredNumber > maxNumber)
                    {
                        maxNumber = enteredNumber;
                    }
                }

                numberAccum += enteredNumber;
            }

            decimal average = numberAccum / 5M;

            Console.Clear();
            Console.WriteLine("El valor mínimo ingresado es: {0}", minNumber);
            Console.WriteLine("El valor máximo ingresado es: {0}", maxNumber);
            Console.WriteLine("El promedio de los números ingresados es: {0:0#.00}", average);
        }
    }
}
