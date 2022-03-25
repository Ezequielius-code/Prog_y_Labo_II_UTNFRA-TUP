using System;

namespace App03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appName = Functions.AppName();
            Console.WriteLine(appName + "\n");

            Console.WriteLine("Enter number of students: ");

            int studentsQuantity;

            studentsQuantity = int.Parse(Console.ReadLine());

            bool couldConvert = int.TryParse(Console.ReadLine(), out studentsQuantity);

            Console.WriteLine(studentsQuantity);
        }
    }
}
