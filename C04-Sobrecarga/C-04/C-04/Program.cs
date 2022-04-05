using System;
using C_04Clase;

namespace C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sobrecargadora.Sumar(5, 8);
            Console.WriteLine(resultado);

            int resultado2 = Sobrecargadora.Sumar(5, 9, 10);
            Console.WriteLine(resultado2);

            Console.WriteLine(Sobrecargadora.Concatenar("Hola", "Mundo"));
            Console.WriteLine(Sobrecargadora.Concatenar("Hola", "Mundo", 12));

            Console.WriteLine(Sobrecargadora.Mostrar("Ezequiel", "Brutto"));
            Console.WriteLine(Sobrecargadora.Mostrar("Ezequiel", "Brutto", 37));

            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Ezequiel");
            Persona persona3 = new Persona("Ezequiel", new DateTime(1984, 3, 31));
            Persona persona4 = new Persona("Ezequiel", new DateTime(1984, 3, 31), 31182065);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona4.Mostrar());

            Persona persona5 = new Persona("Eze");
            Persona persona6 = new Persona("Nico");

            Console.WriteLine(persona5 == persona6);

            Aula aula = new Aula();

            if (persona5 + aula)
            {
                Console.WriteLine("Agregada.");
            }

            if (persona6 + aula)
            {
                Console.WriteLine("Agregada.");
            }

            aula = aula + persona3;

            aula += persona4;

            long dni = persona4;
            Console.WriteLine(dni);

            string otroDni = (string)persona6;
            Console.WriteLine($"{otroDni} {otroDni.GetType()}");
        }
    }
}
