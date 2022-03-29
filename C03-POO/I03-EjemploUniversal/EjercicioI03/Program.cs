using System;
using BibliotecaDeClases;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Zaira", "Ribera", "101001");
            Estudiante estudiante2 = new Estudiante("Abelardo", "Soriano", "101012");
            Estudiante estudiante3 = new Estudiante("Montserrat", "Puertas", "101023");

            estudiante1.SetNotaPrimerParcial(4);
            estudiante1.SetNotaSegundoParcial(3);

            estudiante2.SetNotaPrimerParcial(7);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(8);
            estudiante3.SetNotaSegundoParcial(10);

            Console.WriteLine(estudiante1.Mostrar()); 
            Console.WriteLine(estudiante2.Mostrar()); 
            Console.WriteLine(estudiante3.Mostrar()); 
        }
    }
}
