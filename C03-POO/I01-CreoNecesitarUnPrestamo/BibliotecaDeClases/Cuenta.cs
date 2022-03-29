using System;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return titular;
        }
        public float GetCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            return $"Titular: {GetTitular()}         Cantidad: $ {GetCantidad()}.-";
        }
        public void Ingresar(float monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(float monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
