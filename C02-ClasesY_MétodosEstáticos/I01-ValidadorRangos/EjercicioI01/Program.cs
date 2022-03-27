using System;

namespace EjercicioI01
{
    internal class Program
    {
        const short maxEntries = 10;
        const int minValidNumber = -100;
        const int maxValidNumber = 100;
        static void Main(string[] args)
        {
            int enteredNumber = 0;
            bool validData;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int numberAccum = 0;

            for (int i = 0; i < maxEntries; i++)
            {
                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Ingrese el valor #{0} (entre -100 y 100): ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out enteredNumber) && Validador.Validar(enteredNumber, minValidNumber, maxValidNumber))
                    {
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. El dato ingresado no es válido.");
                    }
                }

                if (enteredNumber < minNumber)
                {
                    minNumber = enteredNumber;
                }
                else if (enteredNumber > maxNumber)
                {
                    maxNumber = enteredNumber;
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
