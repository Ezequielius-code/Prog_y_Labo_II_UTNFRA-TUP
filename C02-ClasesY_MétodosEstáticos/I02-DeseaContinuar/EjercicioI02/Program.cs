using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            bool respuesta = true;
            int enteredNumber = 0;
            bool validNumber = false;
            int accumulator = 0;

            Console.WriteLine("SUMADOR");
            while (respuesta)
            {
                while (!validNumber)
                {
                    Console.WriteLine("Ingrese número a sumar: ");
                    if (int.TryParse(Console.ReadLine(), out enteredNumber))
                    {
                        accumulator += enteredNumber;
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Ingreso no válido.");
                    }
                }

                Console.WriteLine("¿Desea continuar? (S/N)");

                caracter = Convert.ToChar(Console.ReadLine());
                if (Validador.ValidarRespuesta(caracter))
                {
                    respuesta = true;
                    validNumber = false;
                }
                else
                {
                    respuesta = false;
                }
            }

            Console.Clear();    
            Console.WriteLine($"La suma total de los números ingresados es: {accumulator}");
        }
    }
}
