using System;
using BibliotecaDeClases;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random initBalance = new Random();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("BIENVENIDO A GARCHETTI BANKING INTERNATIONAL.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese su apellido y nombre para comenzar a operar:");

            string titular = Console.ReadLine();
            float cantidad = (float)initBalance.Next(-10000, 10000);
            Cuenta cuenta1 = new Cuenta(titular, cantidad);

            bool continuarOperando = false;
            int respuesta = 0;
            float monto;
            do
            {
                switch (cuenta1.GetCantidad())
                {
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(cuenta1.Mostrar());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nSu saldo no le permite realizar extracciones.\n¿Desea seguir operando?\n1_Depositar\n2_Salir");
                        if (int.TryParse(Console.ReadLine(), out respuesta))
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el monto a depositar:");
                                    if (float.TryParse(Console.ReadLine(), out monto))
                                    {
                                        cuenta1.Ingresar(monto);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("La operación se ha realizado con éxito.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n¿Desea seguir operando?\n1_SÍ\n2_NO");
                                        if (int.TryParse(Console.ReadLine(), out respuesta) && respuesta == 1)
                                        {
                                            continuarOperando = true;
                                        }
                                        else
                                        {
                                            continuarOperando = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ERROR. La operación no pudo ser procesada.");
                                        continuarOperando = false;
                                    }
                                    break;
                                default:
                                    continuarOperando = false;
                                    break;
                            }
                        }
                        break;
                    case > 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(cuenta1.Mostrar());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("¿Qué operación desea realizar?\n1_Depositar\n2_Extraer\n3_Salir");
                        if (int.TryParse(Console.ReadLine(), out respuesta))
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el monto a depositar:");
                                    if (float.TryParse(Console.ReadLine(), out monto))
                                    {
                                        cuenta1.Ingresar(monto);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("La operación se ha realizado con éxito.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n¿Desea seguir operando?\n1_SÍ\n2_NO");
                                        if (int.TryParse(Console.ReadLine(), out respuesta) && respuesta == 1)
                                        {
                                            continuarOperando = true;
                                        }
                                        else
                                        {
                                            continuarOperando = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ERROR. La operación no pudo ser procesada.");
                                        continuarOperando = false;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el monto a retirar:");
                                    if (float.TryParse(Console.ReadLine(), out monto))
                                    {
                                        cuenta1.Retirar(monto);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("La operación se ha realizado con éxito.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n¿Desea seguir operando?\n1_SÍ\n2_NO");
                                        if (int.TryParse(Console.ReadLine(), out respuesta) && respuesta == 1)
                                        {
                                            continuarOperando = true;
                                        }
                                        else
                                        {
                                            continuarOperando = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ERROR. La operación no pudo ser procesada.");
                                        continuarOperando = false;
                                    }
                                    break;
                                default:
                                    continuarOperando = false;
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(cuenta1.Mostrar());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n¿Hora de pedir un préstamo?");
                        Console.WriteLine("GARCHETTI FINANCIAL SOLUTIONS INTERNATIONAL. Llamá ya: 001-904-1234");
                        continuarOperando = false;
                        break;
                }
            } while (continuarOperando);
        }
    }
}
