using System;
using BibliotecaDeClases;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Paloma", new DateTime(2010, 7, 15), 46032128);
            Persona persona2 = new Persona("Dorotea", new DateTime(1977, 10, 19), 18748923);
            Persona persona3 = new Persona("Roberto", new DateTime(1975, 2, 12), 17533125);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
            Console.ReadKey();
            Console.Clear();

            Persona[] personas =  new Persona[] { persona1, persona2, persona3 };

            foreach  (Persona persona in personas)
            {
                Console.WriteLine(persona.EsMayorDeEdad(persona));
            }
        }
    }
}
