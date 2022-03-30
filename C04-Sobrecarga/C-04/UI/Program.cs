using System;
using Logica;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Sistema.ChequearUsuario("pepe", "asd123"))
            {
                Console.WriteLine("Se ha logueado exitosamente.");
            }
            else
            {
                Console.WriteLine("SIN ACCESO.");
            }
        }
    }
}
