using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class TablaMultiplicar
    {
        const double valorMaximo = 9;
        public static string GenerarTablaMultiplicar(double multiplicador)
        {
            double multiplicando = 1;
            StringBuilder tablaMultiplicar = new StringBuilder();

            tablaMultiplicar.AppendLine($"Tabla de multiplicar del número {multiplicador}:");
            while (multiplicando <= valorMaximo)
            {
                tablaMultiplicar.AppendLine($"{multiplicador} x {multiplicando} = {multiplicador * multiplicando}");
                multiplicando++;
            }

            return tablaMultiplicar.ToString();
        }
    }
}
