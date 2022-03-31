using System;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operando1 = 0;
            double operando2 = 0;
            char operador = '_';
            double resultado = 0;
            char respuesta = 'S';
            bool validarRespuesta = true;
            bool ingresoValido = false;

            while (validarRespuesta)
            {
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese el primer operando: ");
                    if (double.TryParse(Console.ReadLine(), out operando1))
                    {
                        ingresoValido = true;
                        break;
                    }
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.\n");
                }

                ingresoValido = false;
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese el segundo operando: ");
                    if (double.TryParse(Console.ReadLine(), out operando2))
                    {
                        ingresoValido = true;
                        break;
                    }
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.\n");
                }

                ingresoValido = false;
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese la operación a realizar (+ | - | * | /): ");
                    operador = Convert.ToChar(Console.ReadLine());
                    if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                    {
                        ingresoValido = true;
                        break;
                    }
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.\n");
                }

                resultado = Calculadora.Calcular(operando1, operando2, operador);
                Console.WriteLine($"\nResultado de la operación: {operando1} {operador} {operando2} = {resultado}");
                
                Console.WriteLine("\n¿Desea realizar otra operación? (S / N)");
                respuesta = Convert.ToChar(Console.ReadLine());
                if (Validador.ValidarRespuesta(respuesta))
                {
                    validarRespuesta = true;
                    ingresoValido = false;
                }
                else
                {
                    validarRespuesta = false;
                }
            }
        }
    }
}
