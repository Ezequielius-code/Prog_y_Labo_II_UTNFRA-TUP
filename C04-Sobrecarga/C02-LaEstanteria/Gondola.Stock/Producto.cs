using System;
using System.Text;

namespace Gondola.Stock
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder detalleProducto = new StringBuilder();
            detalleProducto.Append($"|Marca: {p.GetMarca(),-10}\t\t");
            detalleProducto.Append($"|Código: {(string)p,-20}\t");
            detalleProducto.AppendLine($"|Precio: {p.GetPrecio():C2}|");

            return detalleProducto.ToString();
        }

        public static explicit operator string(Producto p)
        {
            if (p is null)
            {
                return "Código dañado.";
            }
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p is not null && marca is not null)
            {
                return p.marca == marca;
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return (p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
