using System;

namespace Presentación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            fullName = "Ezequiel Brutto";
            string message = "Hello World " + fullName + "!";
            Console.WriteLine(message);

            //Comentario de una línea

            /*
             * Comentario
             * Multilínea
             */

            // Tipo de valor (estructura)
            int number = 12;
            ChangeValue(number);
            Console.WriteLine(number);

            // Tipo de referencia (clase)
            Person person = new Person()
            {
                Name = "Ezequiel Brutto"
            };
            ChangeValue(person);
            Console.WriteLine(person.Name);

            string name = "Ezequiel";
            double average = 9.7;
            Console.WriteLine("Soy {0,20}, mi promedio es {1:0#.00} en total.", name, average);

            Console.WriteLine("Ingrese el nombre del producto: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Ingrese el precio:");
            string productPrice = Console.ReadLine();

            //decimal price = Convert.ToDecimal(productPrice);
            //decimal priceWithVAT = price + price * 0.21M;

            if (decimal.TryParse(productPrice , out decimal price))
            {
                decimal priceWithVAT = price + price * 0.21M;
                Console.WriteLine("Producto: {0}. Precio $ {1}.-", productName, priceWithVAT);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se ha ingresado un formato incorrecto. Cerrando programa...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void ChangeValue(int number)
        {
            number = 90;
        }

        static void ChangeValue(Person person)
        {
            person.Name = "Zolomeo Paredes";
        }   
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
