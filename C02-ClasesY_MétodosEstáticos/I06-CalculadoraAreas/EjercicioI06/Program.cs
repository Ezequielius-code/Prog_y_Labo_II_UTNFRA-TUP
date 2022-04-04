using System;
using BibliotecaDeClases;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            bool respuesta = true;
            byte opcion = 0;
            bool numeroValido = false;
            string unidadMedida = "";
            double ladoBase = 0;
            double radioAltura = 0;
            double area = 0;

            while (respuesta)
            {
                Console.Write("Ingrese la opción de la figura de la que desea calcular el área:" +
                              "\n1_Cuadrado\n2_Triangulo\n3_Círculo\n4_Salir\n");
                if (byte.TryParse(Console.ReadLine(), out opcion) && (opcion >= 1 && opcion <= 4))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese la unidad de medida con la que desea operar (mm - cm - m):");
                            unidadMedida = Console.ReadLine();
                            Console.Clear();
                            while (!numeroValido)
                            {
                                Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
                                if (double.TryParse(Console.ReadLine(), out ladoBase))
                                {
                                    numeroValido = true;
                                    Console.Clear();
                                    area = CalculadoraDeArea.CalcularAreaCuadrado(ladoBase);
                                    Console.WriteLine($"El área de un cuadrado de {ladoBase} {unidadMedida} de lado, " +
                                                      $"es de: {area} {unidadMedida}\u00B2");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese la unidad de medida con la que desea operar (mm - cm - m):");
                            unidadMedida = Console.ReadLine();
                            Console.Clear();
                            while (!numeroValido)
                            {
                                Console.WriteLine("Ingrese la longitud de la base del triángulo:");
                                if (double.TryParse(Console.ReadLine(), out ladoBase))
                                {
                                    numeroValido = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            numeroValido = false;
                            while (!numeroValido)
                            {
                                Console.WriteLine("Ingrese la longitud de la altura del triángulo:");
                                if (double.TryParse(Console.ReadLine(), out radioAltura))
                                {
                                    numeroValido = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }

                            area = CalculadoraDeArea.CalcularAreaTriangulo(ladoBase, radioAltura);
                            Console.WriteLine($"El área de un triángulo de {ladoBase} {unidadMedida} de base y {radioAltura} {unidadMedida}" +
                                              $" de altura es de: {area} {unidadMedida}\u00B2");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese la unidad de medida con la que desea operar (mm - cm - m):");
                            unidadMedida = Console.ReadLine();
                            Console.Clear();
                            while (!numeroValido)
                            {
                                Console.WriteLine("Ingrese la longitud del radio del círculo:");
                                if (double.TryParse(Console.ReadLine(), out radioAltura))
                                {
                                    numeroValido = true;
                                    Console.Clear();
                                    area = CalculadoraDeArea.CalcularAreaCirculo(radioAltura);
                                    Console.WriteLine($"El área de un círculo de {radioAltura} {unidadMedida} de radio, " +
                                                      $"es de: {area} {unidadMedida}\u00B2");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        default:
                            respuesta = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. Ha ingresado un dato inválido.");
                    Console.ReadKey();
                    Console.ReadKey();
                }

                Console.Clear();
                if (respuesta)
                {
                    Console.WriteLine("¿Desea calcular un área nuevamente? (S/N)");
                    caracter = Convert.ToChar(Console.ReadLine());
                    if (Validador.ValidarRespuesta(caracter))
                    {
                        numeroValido = false;
                        respuesta = true;
                        Console.Clear();
                    }
                    else
                    {
                        respuesta = false;
                    }
                }
            }
        }
    }
}
