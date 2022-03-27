using System;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Para la realización del ejercicio, no usaré el algoritmo más óptimo.
             *Esto se debe a que debido al pedido de los primeros 4 números perfectos
             *es coincidente con el hecho de que, los primeros 4 números perfectos
             *hallados y publicados hallan sido propuestos por Euclides en su 
             *influyente obra "Los Elementos" (c.300 aC), deseo utilizar un sistema
             *similar al propuesto por este genio en su libro a modo de homenaje.
             */

            int temp = 1;
            int addition = 0;
            int aux = 0; 
            byte count = 0;

            for (int i = 1; count < 4 ; i*=2)
            {
                temp = i;
                addition += i;
                for (int lastNumber = 2; lastNumber < addition; lastNumber++)
                {
                    if (addition % lastNumber == 0)
                    {
                        aux++;
                    }
                }
                if (aux == 0 && i != 1)
                {
                    int perfectNumber = temp * addition;
                    Console.WriteLine("Perfect number: " + perfectNumber);
                    count++;
                }
                aux = 0;
            }
        }
    }
}
