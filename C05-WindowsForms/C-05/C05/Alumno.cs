using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05
{
    public class Alumno
    {
        private string nombre;
        public string apellido;
        private int dni;
        private int telefono;
        private string direccion;

        public Alumno(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Alumno(string nombre, string apellido, int dni, int telefono, string direccion) : this(nombre, apellido, dni)
        {
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
