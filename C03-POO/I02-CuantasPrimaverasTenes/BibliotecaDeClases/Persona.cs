using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = SetNombre(nombre);
            this.fechaNacimiento = SetFechaNacimiento(fechaNacimiento);
            this.dni = SetDni(dni);
        }

        private string SetNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return "Nombre no ingresado";
            }
            return nombre;
        }

        private string GetNombre()
        {
            return nombre;
        }

        private DateTime SetFechaNacimiento(DateTime fechaNacimiento) 
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaActual.Year - fechaNacimiento.Year <= 100 && fechaActual.Day - fechaNacimiento.Day >= 1)
            {
                return fechaNacimiento;
            }
            return new DateTime();
        }

        private DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        private int SetDni(int dni)
        {
            if (dni >= 3000000 && dni <= 99999999)
            {
                return dni;
            }
            return 1000001;
        }

        private int GetDni()
        {
            return dni;
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder datosPersona = new StringBuilder();
            datosPersona.AppendLine($"Nombre: {GetNombre()}");
            datosPersona.AppendLine($"DNI: {GetDni()}");
            datosPersona.AppendLine($"Fecha de nacimiento: {GetFechaNacimiento().ToString("dd/MM/yyyy")}");
            datosPersona.AppendLine($"Edad actual: {CalcularEdad(fechaNacimiento)}\n");

            return datosPersona.ToString();
        }

        public string EsMayorDeEdad(Persona persona)
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaActual.Year - persona.GetFechaNacimiento().Year < 18)
            {
                return $"{GetNombre()}. Es menor de edad.";
            }
            return $"{GetNombre()}. Es mayor de edad.";
        }
    }
}
