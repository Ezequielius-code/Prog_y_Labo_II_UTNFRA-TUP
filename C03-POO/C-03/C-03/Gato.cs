using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        public Gato(string nombre, DateTime fechaNacimiento)
        {
            AsignarNombre(nombre);
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetFechaNacimiento(int dia, int mes, int año)
        {
            this.fechaNacimiento = new DateTime(dia, mes, año);
        }

        public void AsignarNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "Sin nombre";
            }
            this.nombre = nombre;
        }

        public void AsignarPeso(double peso)
        {
            if (peso < 0)
            {
                this.peso = 0;
            }
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Datos del gato:");  
            datos.AppendFormat("Nombre: {0}", nombre.ToUpper());
            datos.Append("\nFecha de nacimiento: ");
            datos.Append(fechaNacimiento.ToString("dd/MM/yyyy"));
            datos.AppendLine($"\nPeso: {peso} kg.");

            return datos.ToString();
        }
    }
}