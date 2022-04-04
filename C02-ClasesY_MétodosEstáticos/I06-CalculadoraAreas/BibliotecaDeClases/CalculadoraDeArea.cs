using System;

namespace BibliotecaDeClases
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado = longitudLado * longitudLado;
            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double longitudBase, double altura)
        {
            double areaTriangulo = (longitudBase * altura) / 2;
            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            return areaCirculo;
        }
    }
}
