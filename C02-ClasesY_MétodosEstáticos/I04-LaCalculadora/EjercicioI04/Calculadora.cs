using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04
{
    internal class Calculadora
    {
        public static double Calcular(double operando1, double operando2, char operador)
        {
            double result = 0;

            switch (operador)
            {
                case '+':
                    result = operando1 + operando2;
                    break;
                case '-':
                    result = operando1 - operando2;
                    break;
                case '*':
                    result = operando1 * operando2;
                    break;
                default:
                    if (Validar(operando2))
                    {
                        result = operando1 / operando2;
                    }
                    else
                    {
                        result = double.MinValue;
                    }
                    break;
            }
            return result;
        }

        private static bool Validar(double divisor)
        {
            if (divisor != 0)
            {
                return true;
            }
            return false;
        }
    }
}
