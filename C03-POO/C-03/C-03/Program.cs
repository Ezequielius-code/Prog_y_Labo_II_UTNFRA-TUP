using System;
using Veterinaria;

namespace C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato garfield = new Gato("Garfield", new DateTime(2018, 03, 28));
            Gato garfield2 = new Gato("Garfield", new DateTime(2018, 03, 28));
            Gato garfield3 = garfield;
            Gato felix = new Gato(null, new DateTime());
            
            garfield.AsignarPeso(5);
            felix.AsignarPeso(3);

            double pesoGarfield = garfield.ObtenerPeso();
            double pesoFelix = felix.ObtenerPeso();
            
            Console.WriteLine(garfield.ObtenerDatos());
            Console.WriteLine(felix.ObtenerDatos());
            Console.WriteLine($"El peso de Felix es: {felix.ObtenerPeso()} kg.\n");

            Console.WriteLine(garfield);
            Console.WriteLine("¿Son iguales? {0}", garfield == garfield2);
            Console.WriteLine("¿Son iguales? {0}", garfield == garfield3);
            Console.WriteLine("¿Son iguales? {0}", garfield.Equals(garfield2));
            Console.WriteLine(ReferenceEquals(garfield, garfield2));
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{nameof(garfield)} : {garfield.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield3)} : {garfield3.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield2)} : {garfield2.GetHashCode()}");
        }
    }
}