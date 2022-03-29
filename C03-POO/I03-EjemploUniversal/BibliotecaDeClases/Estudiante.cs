using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
                return notaFinal;
            }
            return notaFinal;
        }

        private float CalcularPromedio()
        {
            float promedio = (notaPrimerParcial + notaSegundoParcial) / 2F;
            return promedio;
        }

        public string Mostrar()
        {
            StringBuilder datosEstudiante = new StringBuilder();
            datosEstudiante.AppendLine("Datos del estudiante:");
            datosEstudiante.AppendLine($"Nombre: {nombre} Apellido: {apellido} - N° de Legajo: {legajo}");
            datosEstudiante.AppendLine($"Nota primer parcial: {notaPrimerParcial} / Nota segundo parcial: {notaSegundoParcial}");
            datosEstudiante.AppendLine($"Promedio: {CalcularPromedio()}");
            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                datosEstudiante.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                datosEstudiante.AppendLine("Alumno desaprobado.");
            }
            return datosEstudiante.ToString();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }
    }
}
