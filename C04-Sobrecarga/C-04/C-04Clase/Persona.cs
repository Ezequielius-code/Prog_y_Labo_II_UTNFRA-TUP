using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_04Clase
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private long dni;

        public Persona()
        {
            this.nombre = string.Empty;
            this.fechaNacimiento = new DateTime(1990, 1, 1);
            this.dni = -1;
        }

        public Persona(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public Persona(string nombre, DateTime fechaNacimiento, long dni) : this(nombre, fechaNacimiento)
        {
            this.dni = dni;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString(); 
        }

        public static bool operator == (Persona persona1, Persona persona2)
        {
            if (persona1 is not null && persona2 is not null)
            {
                return persona1.nombre == persona2.nombre;
            }
            return false;
        }

        public static bool operator != (Persona persona1, Persona persona2)
        {
            return !(persona1 == persona2);
        }

        public static implicit operator long (Persona persona)
        {
            return persona.dni;
        }

        public static implicit operator string (Persona persona)
        {
            return persona.dni.ToString();
        }
    }
}
