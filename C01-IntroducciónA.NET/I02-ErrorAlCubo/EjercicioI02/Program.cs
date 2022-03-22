using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;
            bool validNumber = false;

            Console.WriteLine("Ingrese un número: ");

            while (!validNumber)
            {
                if (int.TryParse(Console.ReadLine(), out enteredNumber) && enteredNumber > 0)
                {
                    int temp = enteredNumber;
                    int squaredNumber = (int)Math.Pow(temp, 2);
                    int cubedNumber = (int)Math.Pow(temp, 3);

                    Console.WriteLine("{0} elevado al cuadrado es igual a: {1}", enteredNumber, squaredNumber);
                    Console.WriteLine("{0} elevado al cubo es igual a: {1}",enteredNumber, cubedNumber);

                    validNumber = true;
                }
                else 
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
        }
    }
}
