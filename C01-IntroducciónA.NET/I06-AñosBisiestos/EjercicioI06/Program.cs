using System;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fromYear;
            string toYear;
            int startingYear = 0;
            int endingYear = 0;
            bool validData = false;
            short count = 0; 

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LEAP-YEAR CALCULATOR\n");
            Console.ForegroundColor = ConsoleColor.White;

            while (!validData)
            {
                Console.WriteLine("From (enter year (since 1582)): ");
                fromYear = Console.ReadLine();
                Console.WriteLine("To (enter year): ");
                toYear = Console.ReadLine();

                if (int.TryParse(fromYear, out startingYear) && int.TryParse(toYear, out endingYear) 
                    && startingYear <= endingYear && startingYear >= 1582)
                {
                    validData = true;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seems that you´ve entered invalid data.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LEAP-YEAR CALCULATOR\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Leap-year/s: ");

            for (int i = startingYear; i <= endingYear; i++)
            {
                if (!(i % 100 == 0) && (i % 4 == 0 || i % 400 == 0))
                {
                    if (count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t     " + i);
                    }
                    count++;
                }
            }

            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
