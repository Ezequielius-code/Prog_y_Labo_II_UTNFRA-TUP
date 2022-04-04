using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI08
{
    internal class Validador
    {
        private static DateTime fechaMinima = new DateTime(1900, 1, 1);
        public static bool ValidarDia(int dia)
        {
            if (dia < 1 || dia > 31)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarMes(int mes)
        {
            if (mes < 1 || mes > 12)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarAnio(int anio)
        {
            if (anio < 1900 || anio > DateTime.Today.Year)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarFecha(DateTime fecha)
        {
            if (fecha.Day == 29 && fecha.Month == 02 && !DateTime.IsLeapYear(fecha.Year))
            {
                return false;
            }
            if (fecha < DateTime.Today && fecha >= fechaMinima)
            {
                return true;
            }
            return false;
        }
    }
}
