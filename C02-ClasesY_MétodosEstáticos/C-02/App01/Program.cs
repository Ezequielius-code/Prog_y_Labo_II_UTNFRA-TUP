using System;
using App02;

namespace App01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Formulas.ReturnMessage();
            Console.WriteLine(data);
        }
    }
}