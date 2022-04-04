using System;

namespace EjercicioI08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ingresoValido = false;
            int dia = 0;
            int mes = 0;
            int anio = 0;
            bool fechaValida = false;
            DateTime fecha;
            double diasTranscurridos = 0;

            while (!fechaValida)
            {
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese el día en el que nació:");
                    if (int.TryParse(Console.ReadLine(), out dia) && Validador.ValidarDia(dia))
                    {
                        ingresoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Ha ocurrido un problema.");
                    }
                }

                ingresoValido = false;
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese el mes en el que nació:");
                    if (int.TryParse(Console.ReadLine(), out mes) && Validador.ValidarMes(mes))
                    {
                        ingresoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Ha ocurrido un problema.");
                    }
                }

                ingresoValido = false;
                while (!ingresoValido)
                {
                    Console.WriteLine("Ingrese el año en el que nació:");
                    if (int.TryParse(Console.ReadLine(), out anio) && Validador.ValidarAnio(anio))
                    {
                        ingresoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Ha ocurrido un problema.");
                    }
                }

                fecha = new DateTime(anio, mes, dia);
                if (Validador.ValidarFecha(fecha))
                {
                    fechaValida = true;
                    diasTranscurridos = DiasDesdeNacimiento(fecha);
                    Console.Clear();
                    Console.WriteLine($"Desde la fecha {fecha.ToString("dd/MM/yyyy")} hasta el día de hoy, han transcurrido: " +
                                      $"{diasTranscurridos} días");
                }
                else
                {
                    Console.WriteLine("ERROR. Se ha producido un error al cargar la fecha.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static double DiasDesdeNacimiento(DateTime fecha)
        {
            double dias;
            dias = DateTime.Today.Subtract(fecha).Days;
            return dias;
        }
    }
}
